using System.Diagnostics;

namespace FolderReport
{
    public partial class MainWindow : Form
    {
        public FolderScanner.Scanner scanner = new FolderScanner.Scanner();
        string folderPath = string.Empty;
        string outputFilePath = string.Empty;

        public MainWindow()
        {
            InitializeComponent();
            toolStripProgressBar1.Visible = false;
        }

        private async void generateFolderReportButton_Click(object sender, EventArgs e)
        {
            toolStripProgressBar1.Visible = true;
            timer2.Enabled = true;

            progressLabel.Text = "Scanning directory...";

            //Generate CSV Header row
            AppendLine(outputFilePath, "fullPath;fileExtention;fileName;fileDirectory;fileSizeMegabytes;fileCreated;fileModified");

            await Task.Run(() => scanner.GetFiles(folderPath, outputFilePath));
            await Task.Delay(500);

            timer2.Enabled = false;
            progressLabel.Text = "Done! Report generated " + Properties.Settings.Default.fileCounter + " entries to CSV.";
            toolStripProgressBar1.Visible = false;




        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            toolStripProgressBar1.Enabled = false;
            Properties.Settings.Default.fileCounter = 0;
            Properties.Settings.Default.Save();

        }

        private void selectFolderButton_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    folderPath = fbd.SelectedPath;
                    Debug.WriteLine(fbd.SelectedPath);
                }
            }
        }

        private void selectOutputButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            saveFileDialog1.Title = "Choose where to save folder report";
            saveFileDialog1.CheckPathExists = true;
            saveFileDialog1.DefaultExt = "csv";
            saveFileDialog1.Filter = "CSV Files (*.csv)|*.csv|All files (*.*)|*.*";
            saveFileDialog1.RestoreDirectory = true;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                outputFilePath = saveFileDialog1.FileName;
                Debug.WriteLine(outputFilePath);
                CreateEmpty(outputFilePath);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (folderPath == string.Empty) { selectOutputButton.Enabled = false; } else { selectOutputButton.Enabled = true; }
            if (outputFilePath == string.Empty) { generateFolderReportButton.Enabled = false; } else { generateFolderReportButton.Enabled = true; }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            folderPath = string.Empty;
            outputFilePath = string.Empty;
            scanner = new FolderScanner.Scanner();
        }

        public static void CreateEmpty(string filepath)
        {
            //Delete if existing
            if (File.Exists(filepath))
            {
                Delete(filepath);

            }
            //Create new empty file
            try
            {
                File.Create(filepath).Dispose();
                //Console.WriteLine("Creating new empty file: " + filepath);
            }
            catch { MessageBox.Show("Failed to create output file: " + filepath); return; }

        }

        public static void Delete(string filepath)
        {
            try
            {
                if (File.Exists(filepath))
                {
                    //Console.WriteLine("File exists. Deleting file: " + filepath);
                    File.Delete(filepath);
                }
            }
            catch { MessageBox.Show("Failed to delete file: " + filepath); return; }

        }

        public static void AppendLine(string filepath, string lineData)
        {
            try { File.AppendAllText(filepath, lineData + Environment.NewLine); }
            catch { MessageBox.Show("Failed to append line to file: " + filepath); return; }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            progressLabel.Text = "Files scanned: " + Properties.Settings.Default.fileCounter;
        }
    }
}