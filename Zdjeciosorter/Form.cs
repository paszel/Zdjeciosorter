using System;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zdjeciosorter
{
    public partial class Form : System.Windows.Forms.Form
    {
        readonly CancellationTokenSource source = new CancellationTokenSource();
        CancellationToken token;
        bool invalidCancelled = false;

        public Form()
        {
            CenterToScreen();
            InitializeComponent();
        }

        private async void startBtn_Click(object sender, EventArgs e)
        {
            token = source.Token;
            await Task.Run(() => CopyFiles(), token).ConfigureAwait(false);

            if (!invalidCancelled)
            {
                MessageBox.Show(token.IsCancellationRequested ? "Operacja anulowana." : "Operacja zakończona.");
            }
        }

        private void CopyFiles()
        {
            var sourcePath = sourceFolderBrowserDialog.SelectedPath;
            var destinationPath = destinationFolderBrowserDialog.SelectedPath;
            var searchOption = takeSubFoldersChkbx.Checked ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly;

            var errorMessage = "";
            (invalidCancelled, errorMessage) = ValidatePaths();

            if (invalidCancelled)
            {
                MessageBox.Show(errorMessage);
                return;
            }

            var fileExtentions = new string[] { ".gif", ".jpeg", ".jpg", ".bmp", ".png", ".mp4", ".mov", ".wmv", ".avi" };

            string[] filesToCopy = Directory.EnumerateFiles(sourcePath, "*.*", searchOption)
                .Where(x => fileExtentions.Any(ex => x.EndsWith(ex)))
                .ToArray();

            cancelBtn.Invoke(new MethodInvoker(() => Enabled = true));
            progressLabel.Invoke(new MethodInvoker(() => Visible = true));
            progressBar.Invoke(new MethodInvoker(() =>
            {
                progressBar.Value = 0;
                progressBar.Maximum = filesToCopy.Length;
                progressBar.Visible = true;
            }));

            foreach (var file in filesToCopy)
            {
                if (token.IsCancellationRequested)
                {
                    Debug.WriteLine("Cancelled by token");
                    break;
                }

                var createdDate = GetDateTaken(file);
                var dest = Path.Combine(destinationPath, createdDate.Year.ToString());

                if (!Directory.Exists(dest))
                {
                    Directory.CreateDirectory(dest);
                }

                File.Copy(file, Path.Combine(dest, Path.GetFileName(file)), true);

                progressBar.Invoke(new MethodInvoker(() => progressBar.Value += 1));
            }

            cancelBtn.Invoke(new MethodInvoker(() => Enabled = false));
            progressLabel.Invoke(new MethodInvoker(() => Visible = false));
            progressBar.Invoke(new MethodInvoker(() =>
            {
                progressBar.Value = 0;
                progressBar.Visible = false;
            }));

            (bool result, string errorMsg) ValidatePaths()
            {
                if (string.IsNullOrEmpty(sourcePath) || string.IsNullOrEmpty(destinationPath))
                {
                    return (true, "Folder źródłowy i docelowy muszą być wybrane!");
                }

                if (sourcePath.Equals(destinationPath, StringComparison.CurrentCultureIgnoreCase))
                {
                    return (true, "Folder źródłowy i docelowy nie mogą być takie same!");
                }

                if (!Directory.Exists(sourcePath))
                {
                    return (true, "Ścieżka do folderu źródłowego nie istnieje.");
                }

                if (!Directory.Exists(destinationPath))
                {
                    return (true, "Ścieżka do folderu docelowego nie istnieje.");
                }

                return (false, "");
            }
        }

        private void sourceFolderBtn_Click(object sender, EventArgs e)
        {
            sourceFolderBrowserDialog.ShowDialog();
            selectedSourceFolderLabel.Text = sourceFolderBrowserDialog.SelectedPath;
        }

        private void destinyFolderBtn_Click(object sender, EventArgs e)
        {
            destinationFolderBrowserDialog.ShowDialog();
            selectedDestinationFolderLabel.Text = destinationFolderBrowserDialog.SelectedPath;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            source.Cancel();
        }

        private static Regex regex = new Regex(":");

        public static DateTime GetDateTaken(string path)
        {
            int DateTakenValue = 0x9003; //36867;
            var creationDate = File.GetCreationTime(path);
            var modificationDate = File.GetCreationTime(path);

            var result = new DateTime(Math.Min(creationDate.Ticks, modificationDate.Ticks));

            try
            {
                using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
                using (Image myImage = Image.FromStream(fs, false, false))
                {
                    if (!myImage.PropertyIdList.Contains(DateTakenValue))
                    {
                        Debug.WriteLine($"Date taken not found for: {path}");
                    }
                    else
                    {
                        PropertyItem propItem = myImage.GetPropertyItem(DateTakenValue);
                        string dateTaken = regex.Replace(Encoding.UTF8.GetString(propItem.Value), "-", 2);
                        result = DateTime.Parse(dateTaken);
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Exception occured for {path}. {ex.Message}");
            }
            
            return result;
        }
    }
}
