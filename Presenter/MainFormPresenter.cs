using UtilitForDeletFileFromDirs.Interfaces;
using UtilitForDeletFileFromDirs.Events;

namespace UtilitForDeletFileFromDirs.Presenter
{
    public class MainFormPresenter
    {
        private IMainFormModel _mfmodel;
        private IMainFormView _mfview;

        public MainFormPresenter(IMainFormModel mfmodel, IMainFormView mfview)
        {
            _mfmodel = mfmodel;
            _mfview = mfview;
            _mfview.StartDelet += mfview_StartDelet;
        }
        private void mfview_StartDelet(object sender,StartDeletEventArgs e)
        {
            _mfmodel.SetDirs(e.DirWithFiles,e.DirForControl);
            _mfview.SetMaxValForPB(_mfmodel.ReturnValOfFile());
            _mfmodel.CheckDgv(e.DGVRowCol);
            _mfmodel.DeletFile();
            _mfmodel.ClearData();
            _mfview.ClearData();
        }
    }
}
