using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Globalization;

namespace FolderScanner
{
    public class Scanner
    {
        public async Task<bool> GetFiles(string folderPath, string outputFilePath)
        {
            List<String> rawFiles;
            try
            {
                rawFiles = Directory.GetFiles(folderPath, "*", SearchOption.AllDirectories).ToList();
            }catch (Exception ex) { MessageBox.Show("ACCESS DENIED: " + ex.Message); return false; }
            FileInfo fInfo;
            LogFile newFile;

            foreach (String f in rawFiles) {
                fInfo = new FileInfo(f);
                newFile = new LogFile();

                Debug.WriteLine("\n\nNew file: " + f);

                newFile.fullPath = f;
                newFile.fileExtention = fInfo.Extension.Replace(".","").ToUpper().Trim();
                newFile.fileName = fInfo.Name;
                newFile.fileDirectory = fInfo.DirectoryName;
                newFile.fileSizeMegabytes = Math.Round(ConvertBytesToMegabytes(fInfo.Length), 1);
                newFile.fileCreated = ConvertDatetimeToString(fInfo.CreationTime);
                newFile.fileModified = ConvertDatetimeToString(fInfo.LastWriteTime);
                await Task.Run(() => AppendLine(outputFilePath, newFile.GetCsvRow()));

                Debug.WriteLine(newFile.GetFormattedString());

                FolderReport.Properties.Settings.Default.fileCounter++;
                //FolderReport.Properties.Settings.Default.Save();

                fInfo = null;
                newFile = null;
                

            }

            return true;

        }
        private double ConvertBytesToMegabytes(long bytes)
        {
            return (bytes / 1024f) / 1024f;
        }

        private string ConvertDatetimeToString(DateTime timestamp)
        {
            return timestamp.ToString("yyyy-MM-dd_HH:mm:ss");
        }

        public async Task<bool> AppendLine(string filepath, string lineData)
        {
            try { File.AppendAllText(filepath, lineData + Environment.NewLine); return true; }
            catch { MessageBox.Show("Failed to append line to file: " + filepath); return false; }
        }
    }

    public class LogFile
    {
        public string fullPath {  get; set; }
        public string fileName { get; set; }
        public string fileExtention { get; set; }
        public string fileDirectory { get; set; }
        public double fileSizeMegabytes { get; set; }
        public string fileCreated { get; set; }
        public string fileModified { get; set; }

        public string GetFormattedString()
        {
            return string.Format("\nFile Info\nFull path: {0}\nFilename: {1}\n File extention: {2}\n Directory: {3}\n Filesize: {4}Mb\nFile created: {5}\nFile modified: {6}", fullPath, fileName, fileExtention, fileDirectory, fileSizeMegabytes, fileCreated, fileModified);
        }

        public string GetCsvRow()
        {

            return string.Format("{0};{1};{2};{3};{4};{5};{6}",
                   SanitizeString(fullPath),
                   SanitizeString(fileName),
                   SanitizeString(fileExtention),
                   SanitizeString(fileDirectory),
                   fileSizeMegabytes,
                   SanitizeString(fileCreated),
                   SanitizeString(fileModified));
        }

        private string SanitizeString(string input)
        {
            return input.Replace(";", ":");
        }

    }

    
}

