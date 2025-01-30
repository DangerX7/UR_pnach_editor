using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace UR_pnach_editor.Services
{
    public static class ProcessingClass
    {

        public static MainWindow MainWindow { get; set; } = (MainWindow)Application.Current.MainWindow;
        public static Frame MainWindowFrame { get; set; } = MainWindow.MainFrame;


    }
}
