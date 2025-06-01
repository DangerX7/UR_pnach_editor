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
using NAudio.CoreAudioApi;
using System.Drawing;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Windows.Controls;

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


        private string _patchingStatusBrad;
        public string PatchingStatusBrad
        {
            get { return _patchingStatusBrad; }
            set
            {
                if (_patchingStatusBrad != value)
                {
                    _patchingStatusBrad = value;
                    RaisePropertyChanged("PatchingStatusBrad");
                }
            }
        }

        public List<string> BradModels_List = new List<string>
        {
            "Original",
            //cutscenes face ok
            "Miguel",
            "Ramon",
            "Jose",
            "Emilio",
            "Reggie",
            "Zach",
            "Colin",
            "Jake",
            "Grimm",
            "BK",
            "Grave Digga'",
            "Busta",
            "Spider",
            "Pain Killah",
            "Dwayne",
            "GD-05",
            "DR-88",
            "FK-71",
            "PT-22",
            "Bain",
            "Cooper",
            "Taylor",
            "Chris",
            "Alex",
            "Napalm 99",
            "Golem",
            "Riki",
            "Masa",
            "Hiro",
            "Ryuji",
            "Bordin",
            "Vera Ross",
            "Marshall Law",
            "Unused Prisoner",
            //cutscenes face messed up
            "Glen",
            "Rod",
            "Seth",
            "Nas-Tiii",
            "Em Cee",
            "Real Deal",
            "Ty",
            "Booma",
            "Shun Ying Lee",
            "Park",
            "Ye Wei",
            "Sha Ying",
            "Yan Jun",
            "Shinkai",
            "Lin Fong Lee",
            "Lilian",
            "Kelly"
            //missing models too big
            //Torque
            //Kadonashi
            //Tong Yoon
            //Bones
            //Anderson
            //McKinzie
            //Paul Phoenix
            //KG
        };

        //public List<string> BradModels_List = new List<string>
        //{
        //    "Original",
        //    "Glen*",//04
        //    //05
        //    "Rod*",//06
        //    "Seth*",//07
        //    "Nas-Tiii*",//08
        //    "Em Cee*",//09
        //    "Real Deal*",//10
        //    "Ty*",//11
        //    "Miguel",//12
        //    "Ramon",//13
        //    "Jose",//14
        //    "Emilio",//15
        //    //16
        //    "Reggie",//17
        //    "Zach",//18
        //    "Colin",//19
        //    "Jake",//20
        //    //21
        //    "Grimm",//22
        //    "BK",//23
        //    "Grave Digga'",//24
        //    //25
        //    "Booma*",//26
        //    "Busta",//27
        //    "Spider",//28
        //    "Pain Killah",//29
        //    //30
        //    "Dwayne",//31
        //    "Shun Ying Lee*",//32
        //    "GD-05",//33
        //    "DR-88",//34
        //    "FK-71",//35
        //    "PT-22",//36
        //    "Bain",//37
        //    "Cooper",//38
        //    //39
        //    "Taylor",//40
        //    "Chris",//41
        //    "Park*",//42S
        //    "Alex",//43
        //    //44
        //    "Napalm 99",//45
        //    "Golem",//46
        //    "Riki",//47
        //    "Masa",//48
        //    "Hiro",//49
        //    "Ryuji",//50
        //    "Ye Wei*",//51
        //    "Sha Ying*",//52
        //    "Yan Jun*",//53
        //    "Shinkai*",//54
        //    "Lin Fong Lee*",//55
        //    "Bordin",//56
        //    "Lilian*",//57
        //    "Kelly*",//58
        //    "Vera Ross",//59
        //    //60
        //    "Marshall Law",//61
        //    "Unused Prisoner"//69
        //};

    }
}
