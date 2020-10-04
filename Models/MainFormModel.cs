using System;
using System.Collections.Generic;
using UtilitForDeletFileFromDirs.Interfaces;
using System.Windows.Forms;
using System.IO;

namespace UtilitForDeletFileFromDirs.Models
{
    public class MainFormModel : IMainFormModel
    {
        private int _count = 0;
        private List<string> _targetFilesForDelet = new List<string>();
        private string _directory = string.Empty;
        private string _directoryControl = string.Empty;
        private int _addtodeletfile = 0;
        public void SetDirs(string directory,string directoryControl)
        {
            _directory = directory;
            _directoryControl = directoryControl;
        }
        public int ReturnValOfFile()
        {
            _count = 0;
            CountFile(_directory);
            return _count;
        }
        public void CountFile(string directory)
        {
            try
            {
                GC.Collect();
                GC.WaitForPendingFinalizers();
                DirectoryInfo dir = new DirectoryInfo(directory);
                DirectoryInfo[] dirs = dir.GetDirectories();
                _count += dir.GetFiles().Length;
                foreach (DirectoryInfo subdir in dirs)
                {
                    CountFile(subdir.FullName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public void CheckDgv(DataGridViewRowCollection dgvrc)
        {
            for (int i = 0; i < dgvrc.Count; i++)
            {
                if (dgvrc[i].Cells[0].Value != null)
                {
                    if (!string.IsNullOrEmpty(dgvrc[i].Cells[0].Value.ToString().Trim()))
                    {
                        _targetFilesForDelet.Add(dgvrc[i].Cells[0].Value.ToString().Trim());
                    }
                }
            }
        }
        public void DeletFile()
        {
            FindAndDeletFile(_directory);
        }
        public void FindAndDeletFile(string sourceDirName)
        {
            try
            {
                GC.Collect();
                GC.WaitForPendingFinalizers();
                DirectoryInfo dir = new DirectoryInfo(sourceDirName);
                DirectoryInfo[] dirs = dir.GetDirectories();
                FileInfo[] files = dir.GetFiles();
                foreach (FileInfo file in files)
                {
                    if (_targetFilesForDelet.Contains(file.Name))
                    {
                        if (!string.IsNullOrEmpty(_directoryControl))
                        {
                            string path = Path.Combine(_directoryControl, file.Name + _addtodeletfile.ToString());
                            _addtodeletfile++;
                            File.Create(path);
                        }
                        File.Delete(file.FullName);
                    }
                }
                foreach (DirectoryInfo subdir in dirs)
                {
                    FindAndDeletFile(subdir.FullName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public void ClearData()
        {
            _count = 0;
            _targetFilesForDelet = new List<string>();
            _directory = string.Empty;
            _directoryControl = string.Empty;
            _addtodeletfile = 0;
        }
    }
}
