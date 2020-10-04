using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UtilitForDeletFileFromDirs.Events
{
    public class SetDirectoryEventArgs : EventArgs
    {
        public string Directory { get; private set; }
        public SetDirectoryEventArgs(string directory)
        {
            Directory = directory;
        }
    }
}
