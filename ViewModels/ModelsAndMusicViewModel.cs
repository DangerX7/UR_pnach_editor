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
    public class ModelsAndMusicViewModel : BaseViewModel
    {
        public ModelsAndMusicViewModel()
        {


            //SettingsClass.LoadData();
            GameFolderPath = SettingsClass.gameFolderPath;

            KG_Tall_Model = SettingsClass.KG_Tall_Model;
            Real_Dwarf_Model = SettingsClass.Real_Dwarf_Model;
            Golem_Giant_Model = SettingsClass.Golem_Giant_Model;
            Gnome_Napalm_Model = SettingsClass.Gnome_Napalm_Model;
            Amazon_Shun_Ying = SettingsClass.Amazon_Shun_Ying;
        }


        private string _gameFolderPath;
        public string GameFolderPath
        {
            get { return _gameFolderPath; }
            set
            {
                if (_gameFolderPath != value)
                {
                    _gameFolderPath = value;
                    RaisePropertyChanged("GameFolderPath");
                }
            }
        }


        private bool _kG_Tall_Model;

        public bool KG_Tall_Model
        {
            get { return _kG_Tall_Model; }
            set
            {
                if (_kG_Tall_Model != value)
                {
                    _kG_Tall_Model = value;
                    SettingsClass.KG_Tall_Model = _kG_Tall_Model;
                    RaisePropertyChanged("KG_Tall_Model");
                }
            }
        }

        private bool _real_Dwarf_Model;

        public bool Real_Dwarf_Model
        {
            get { return _real_Dwarf_Model; }
            set
            {
                if (_real_Dwarf_Model != value)
                {
                    _real_Dwarf_Model = value;
                    SettingsClass.Real_Dwarf_Model = _real_Dwarf_Model;
                    RaisePropertyChanged("Real_Dwarf_Model");
                }
            }
        }

        private bool _golem_Giant_Model;

        public bool Golem_Giant_Model
        {
            get { return _golem_Giant_Model; }
            set
            {
                if (_golem_Giant_Model != value)
                {
                    _golem_Giant_Model = value;
                    SettingsClass.Golem_Giant_Model = _golem_Giant_Model;
                    RaisePropertyChanged("Golem_Giant_Model");
                }
            }
        }

        private bool _gnome_Napalm_Model;

        public bool Gnome_Napalm_Model
        {
            get { return _gnome_Napalm_Model; }
            set
            {
                if (_gnome_Napalm_Model != value)
                {
                    _gnome_Napalm_Model = value;
                    SettingsClass.Gnome_Napalm_Model = _gnome_Napalm_Model;
                    RaisePropertyChanged("Gnome_Napalm_Model");
                }
            }
        }

        private bool _amazon_Shun_Ying;

        public bool Amazon_Shun_Ying
        {
            get { return _amazon_Shun_Ying; }
            set
            {
                if (_amazon_Shun_Ying != value)
                {
                    _amazon_Shun_Ying = value;
                    SettingsClass.Amazon_Shun_Ying = _amazon_Shun_Ying;
                    RaisePropertyChanged("Amazon_Shun_Ying");
                }
            }
        }
        

        private string _patchingStatus;
        public string PatchingStatus
        {
            get { return _patchingStatus; }
            set
            {
                if (_patchingStatus != value)
                {
                    _patchingStatus = value;
                    RaisePropertyChanged("PatchingStatus");
                }
            }
        }

        public List<string> BGM_List = new List<string>
        {
            "Original",
            "Story pack 1",
            "Story pack 2",
            "Story pack 3",
            "Tekken 5 pack",
            "Tekken 5: Dark Resurrection pack",
            "Dead or Alive 2 pack",
            "WWE SmackDown vs. Raw 2011 pack",
            "Dragon Ball Z: Budokai Tenkaichi 2 pack",
            "Tekken 8"
        };

    }
}
