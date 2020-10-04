using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using UtilitForDeletFileFromDirs.Views;
using UtilitForDeletFileFromDirs.Interfaces;
using UtilitForDeletFileFromDirs.Models;
using UtilitForDeletFileFromDirs.Presenter;

namespace UtilitForDeletFileFromDirs
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            IMainFormModel mfmodel = new MainFormModel();
            MainForm mfview = new MainForm();
            MainFormPresenter mfpresenter = new MainFormPresenter(mfmodel, mfview);
            Application.Run(mfview);
        }
    }
}
