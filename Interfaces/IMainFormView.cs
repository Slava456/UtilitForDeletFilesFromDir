using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UtilitForDeletFileFromDirs.Events;

namespace UtilitForDeletFileFromDirs.Interfaces
{
    public interface IMainFormView
    {

        event EventHandler<StartDeletEventArgs> StartDelet;
        void SetMaxValForPB(int val);
        void ClearData();
    }
}
