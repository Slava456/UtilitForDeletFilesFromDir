using System.Windows.Forms;

namespace UtilitForDeletFileFromDirs.Interfaces
{
    public interface IMainFormModel
    {
        void SetDirs(string directory, string directoryControl);
        int ReturnValOfFile();
        void DeletFile();
        void CountFile(string directory);
        void CheckDgv(DataGridViewRowCollection dgvrc);
        void ClearData();
    }
}
