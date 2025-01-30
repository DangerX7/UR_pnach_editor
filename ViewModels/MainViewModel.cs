using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UR_pnach_editor.Services;

namespace UR_pnach_editor.ViewModels
{
    public class MainViewModel:BaseViewModel
    {
        public MainViewModel()
        {
            SettingsClass.LoadData();
            FolderPath = SettingsClass.codeFolderPath;
            CRC_Name = SettingsClass.PnachName;
            EditorVersion = InfoClass.editorVersion;
            DiscordServer = InfoClass.discordServer;
            YoutubeLink = InfoClass.youtubeLink;


            if (SettingsClass.EditorEffectsIndex == 1)
            {
                SnowImg1 = "/Resources/gift_box.png";
                SnowImg1x = "/Resources/gift_box_open.png";
                SnowImg2 = "/Resources/christmas-brad_hawk.png";
            }
            else
            {
                SnowImg1 = "/Resources/Box.png";
                SnowImg1x = "/Resources/BoxFocus.png";
                SnowImg2 = "/Resources/Nothing.png";
            }
        }


        private string _folderPath;
        public string FolderPath
        {
            get { return _folderPath; }
            set
            {
                if (_folderPath != value)
                {
                    _folderPath = value;
                    RaisePropertyChanged("FolderPath");
                }
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


        private string _cRC_Name = "";

        public string CRC_Name
        {
            get { return _cRC_Name; }
            set
            {
                if (_cRC_Name != value)
                {
                    _cRC_Name = value;
                    RaisePropertyChanged("CRC_Name");
                }
            }
        }
        

        public List<string> Characters = new List<string>
        {
            "Brad Hawk",
            "Glen",
            "Torque",
            "Rod",
            "Seth",
            "Nas-Tiii",
            "Em Cee",
            "Real Deal",
            "Ty",
            "Miguel",
            "Ramon",
            "Jose",
            "Emilio",
            "Kadonashi",
            "Reggie",
            "Zack",
            "Colin",
            "Jake",
            "Tong Yoon",
            "Grimm",
            "BK",
            "Grave Digga'",
            "Bones",
            "Booma",
            "Busta",
            "Spider",
            "Pain Killah",
            "Dwayne",
            "Shun Ying Lee",
            "GD-05",
            "DR-88",
            "FK-71",
            "PT-22",
            "Bain",
            "Cooper",
            "Anderson",
            "Taylor",
            "Chris",
            "Park",
            "Alex",
            "McKinzie",
            "Napalm 99",
            "Golem",
            "Riki",
            "Masa",
            "Hiro",
            "Ryuji",
            "Ye Wei",
            "Sha Ying",
            "Yan Jun",
            "Shinkai",
            "Lin Fong Lee",
            "Bordin",
            "Lilian",
            "Kelly",
            "Vera",
            "Paul",
            "Law",
            "Bordin (Story)",
            "KG (Beat-up)",
            "Bain (Mask)",
            "Cooper (Mask)"
        };



        public List<string> SpaList = new List<string>
        {
            "None",
            "Armor SPA",
            "Power Up SPA",
            "Concentration SPA",
            "Arcanum SPA",
            "Power + Armor *",
            "Power + Armor #",
            "Power + Concentration",
            "Power + Arcanum",
        };



        public List<string> CodeFileNames = new List<string>
        {
            "Original Usa (Ntsc)",
            "Europe (Pal)",
            "All Weapons Patch",
            "PAL Patched (USA) + Weapons",
            "NTSC Patched (Europe)",
        };

        private string _textCode = "";

        public string TextCode
        {
            get { return _textCode; }
            set
            {
                if (_textCode != value)
                {
                    _textCode = value;
                    RaisePropertyChanged("TextCode");

                }
            }
        }


        private string _editorVersion;
        public string EditorVersion
        {
            get { return _editorVersion; }
            set
            {
                if (_editorVersion != value)
                {
                    _editorVersion = value;
                    RaisePropertyChanged("EditorVersion");
                }
            }
        }

        private string _discordServer;
        public string DiscordServer
        {
            get { return _discordServer; }
            set
            {
                if (_discordServer != value)
                {
                    _discordServer = value;
                    RaisePropertyChanged("DiscordServer");
                }
            }
        }

        private string _youtubeLink;
        public string YoutubeLink
        {
            get { return _youtubeLink; }
            set
            {
                if (_youtubeLink != value)
                {
                    _youtubeLink = value;
                    RaisePropertyChanged("YoutubeLink");
                }
            }
        }

        private string _randomizeSupremeStatus;
        public string RandomizeSupremeStatus
        {
            get { return _randomizeSupremeStatus; }
            set
            {
                if (_randomizeSupremeStatus != value)
                {
                    _randomizeSupremeStatus = value;
                    RaisePropertyChanged("RandomizeSupremeStatus");
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

        private string _snowImg2;
        public string SnowImg2
        {
            get { return _snowImg2; }
            set
            {
                if (_snowImg2 != value)
                {
                    _snowImg2 = value;
                    RaisePropertyChanged("SnowImg2");
                }
            }
        }

    }


}
