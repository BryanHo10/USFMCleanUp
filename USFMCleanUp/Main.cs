using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace USFMGroom
{
    public partial class Main : Form
    {
        private List<string> FileFormatList;
        public static Regex endMarkerRegex = new Regex("(\\\\\\S+\\*)(\\S+)");
        public Main()
        {
            InitializeComponent();
            FileFormatList = new List<string>();
        }

        private void Btn_AddFiles_Click(object sender, EventArgs e)
        {
            
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog
            {
                Description = "Select the directory containing the files you want to convert.",
                // Default to the My Documents folder.
                RootFolder = Environment.SpecialFolder.MyComputer,
                SelectedPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal)
            };
            
            //Show the FolderBrowserDialog.
            DialogResult result = folderBrowserDialog.ShowDialog();
            if (result != DialogResult.OK)
            {
                return;
            }

            Msg_Complete.Visible = false;
            FileFormatList.Clear();
            var folderName = folderBrowserDialog.SelectedPath;
            var dirinfo = new DirectoryInfo(folderName);
            var allFiles = dirinfo.GetFiles("*", SearchOption.AllDirectories);
            foreach (FileInfo fileInfo in allFiles)
            {
                if (fileInfo.FullName.ToLower().EndsWith(".usfm") ||
                    fileInfo.FullName.ToLower().EndsWith(".txt"))
                {
                    FileFormatList.Add(fileInfo.Name);
                }
            }
            FolderPath.Text = folderName;
        }

        private async void Btn_Groom_Click(object sender, EventArgs e)
        {
            

            Btn_AddFiles.Enabled = false;
            Btn_Groom.Enabled = false;
            var watch = System.Diagnostics.Stopwatch.StartNew();


            await retrieveFileDataParallelAsync();


            watch.Stop();
            var ellapsedMs = watch.ElapsedMilliseconds;
            Msg_Runtime.Text += $"Total execution time: {ellapsedMs}{Environment.NewLine}";
            Btn_AddFiles.Enabled = true;
            Btn_Groom.Enabled = true;
            Msg_Complete.Visible = true;

        }
        private async Task retrieveFileDataParallelAsync()
        {
            List<Task> tasks = new List<Task>();
            foreach (string path in FileFormatList)
            {
                tasks.Add(Task.Run(() => groomUSFM(path, File.ReadAllText(FolderPath.Text + "\\" + path))));
            }

        }
        private void retrieveFileData()
        {
            foreach (string path in FileFormatList)
            {
                groomUSFM(path, File.ReadAllText(FolderPath.Text + "\\" + path));
            }

        }
        private void groomUSFM(string pathName, string text)
        {


            string copyText = text;
            do
            {
                foreach (Match match in endMarkerRegex.Matches(copyText))
                {
                    string correctUSFM = match.Groups[1].Value + " " + match.Groups[2].Value;
                    copyText = copyText.Replace(match.Value, correctUSFM);
                }
            } while (endMarkerRegex.Matches(copyText).Count > 0);


            if (!Directory.Exists(FolderPath.Text + "\\newText"))
            {
                Directory.CreateDirectory(FolderPath.Text + "\\newText");
            }
            File.WriteAllText(FolderPath.Text + "\\newText\\" + pathName, copyText);
        }

        private void Btn_Groom_Sync_Click(object sender, EventArgs e)
        {
            Btn_AddFiles.Enabled = false;
            Btn_Groom.Enabled = false;
            var watch = System.Diagnostics.Stopwatch.StartNew();


            retrieveFileData();


            watch.Stop();
            var ellapsedMs = watch.ElapsedMilliseconds;
            Msg_Runtime.Text += $"Total execution time: {ellapsedMs}{Environment.NewLine}";
            Btn_AddFiles.Enabled = true;
            Btn_Groom.Enabled = true;
            Msg_Complete.Visible = true;
        }
    }
}
