using System;
using System.Windows.Forms;
using UtilitForDeletFileFromDirs.Classes;
using UtilitForDeletFileFromDirs.Events;
using UtilitForDeletFileFromDirs.Interfaces;

namespace UtilitForDeletFileFromDirs.Views
{
    public partial class MainForm : Form, IMainFormView
    {
        private string[] _directory = new string[1];
        private string[] _directoryOut = new string[1];

        public event EventHandler<StartDeletEventArgs> StartDelet;
        public MainForm()
        {
            InitializeComponent();
        }
        protected virtual void OnStartDelet(StartDeletEventArgs e)
        {
            StartDelet?.Invoke(this, e);
        }
        public void SetMaxValForPB(int val)
        {
            pb.Maximum = val;
            pb.Value = 0;
        }
        private void btGo_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(_directory[0]))
                OnStartDelet(new StartDeletEventArgs(_directory[0], _directoryOut[0], dgvTargetFiles.Rows));
        }

        private void pnlDropDir_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }
        private void pnlDropOut_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }
        private void pnlDropDir_DragDrop(object sender, DragEventArgs e)
        {
            _directory = (string[])e.Data.GetData(DataFormats.FileDrop);
            lblDir.Text = StaticParamClass.DirComplet;
        }

        private void pnlDropOut_DragDrop(object sender, DragEventArgs e)
        {
            _directoryOut = (string[])e.Data.GetData(DataFormats.FileDrop);
            lblDirForControl.Text = StaticParamClass.DirComplet;
        }

        private void btClearDir_Click(object sender, EventArgs e)
        {
            ClearDir();
        }

        private void btClearDGV_Click(object sender, EventArgs e)
        {
            ClearDGV();
        }
        public void ClearData()
        {
            ClearDGV();
            ClearDir();
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
        private void ClearDGV()
        {
            try
            {
                dgvTargetFiles.Rows.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void ClearDir()
        {
            _directory[0] = string.Empty;
            _directoryOut[0] = string.Empty;
            lblDir.Text = StaticParamClass.SetDirWithFiles;
            lblDirForControl.Text = StaticParamClass.SetDirForControl;
        }
    }
}
