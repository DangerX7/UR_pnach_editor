using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Collections.ObjectModel;
using System.IO;
using System.Windows;
using UR_pnach_editor.Views;
using UR_pnach_editor.Services;
using System.Windows.Documents;
using System.Diagnostics;
using System.Threading;
using System.Windows.Markup;

namespace UR_pnach_editor.ViewModels
{
    public class MiscellaneousCheatsViewModel : BaseViewModel
    {
        public MiscellaneousCheatsViewModel()
        {
            SettingsClass.LoadData();

            if (SettingsClass.EditorEffectsIndex == 1)
            {
                SnowImg1 = "/Resources/gift_box.png";
                SnowImg1x = "/Resources/gift_box_open.png";
            }
            else
            {
                SnowImg1 = "/Resources/Box.png";
                SnowImg1x = "/Resources/BoxFocus.png";
            }
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


        private string _snowImg1;
        public string SnowImg1
        {
            get { return _snowImg1; }
            set
            {
                if (_snowImg1 != value)
                {
                    _snowImg1 = value;
                    RaisePropertyChanged("SnowImg1");
                }
            }
        }
        private string _snowImg1x;
        public string SnowImg1x
        {
            get { return _snowImg1x; }
            set
            {
                if (_snowImg1x != value)
                {
                    _snowImg1x = value;
                    RaisePropertyChanged("SnowImg1x");
                }
            }
        }


    }
}
