using System;
using System.Windows.Forms;

namespace UtilitForDeletFileFromDirs.Events
{
    public class StartDeletEventArgs: EventArgs
    {
        public DataGridViewRowCollection DGVRowCol { get; private set; }
        public string DirWithFiles { get; private set; }
        public string DirForControl { get; private set; }

        public StartDeletEventArgs(string _DirWithFiles, string _DirForControl, DataGridViewRowCollection dgvrowcol)
        {
            DGVRowCol = dgvrowcol;
            DirWithFiles = _DirWithFiles;
            DirForControl = _DirForControl;
        }
    }
}
