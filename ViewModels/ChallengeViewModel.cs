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
    public class ChallengeViewModel : BaseViewModel
    {
        public ChallengeViewModel()
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


        private bool _isPrimaryGroupActive;
        public bool IsPrimaryGroupActive
        {
            get { return _isPrimaryGroupActive; }
            set
            {
                if (_isPrimaryGroupActive != value)
                {
                    _isPrimaryGroupActive = value;
                    RaisePropertyChanged("IsPrimaryGroupActive");
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
