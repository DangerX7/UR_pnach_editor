using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Collections.ObjectModel;
using System.IO;
using System.Windows;
using UR_pnach_editor.Services;

namespace UR_pnach_editor.ViewModels
{
    public class ChallengeModeViewModel : BaseViewModel
    {
        public ChallengeModeViewModel()
        {

        }

        private string _codeString = "";

        public string CodeString
        {
            get { return _codeString; }
            set
            {
                if (_codeString != value)
                {
                    _codeString = value;
                    RaisePropertyChanged("CodeString");
                }
            }
        }

        private string _modeInformation = "";

        public string ModeInformation
        {
            get { return _modeInformation; }
            set
            {
                if (_modeInformation != value)
                {
                    _modeInformation = value;
                    RaisePropertyChanged("ModeInformation");
                }
            }
        }


    }
}
