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
    public class DeveloperViewModel : BaseViewModel
    {
        public DeveloperViewModel()
        {


            //SettingsClass.LoadData();
            GameFolderPath = SettingsClass.gameFolderPath;
            EditorVersion = InfoClass.fullEditorVersion;
            EditorReleaseDate = InfoClass.editorReleaseDate;

            KG_Tall_Model = SettingsClass.KG_Tall_Model;
            Real_Dwarf_Model = SettingsClass.Real_Dwarf_Model;
            Golem_Giant_Model = SettingsClass.Golem_Giant_Model;
            Gnome_Napalm_Model = SettingsClass.Gnome_Napalm_Model;

            StatsChanged = SettingsClass.StatsChanged;
            SfxIsOn = SettingsClass.PageEnterSFX;

            GetToolStatus();
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

        private bool _statsChanged;

        public bool StatsChanged
        {
            get { return _statsChanged; }
            set
            {
                if (_statsChanged != value)
                {
                    _statsChanged = value;
                    SettingsClass.StatsChanged = _statsChanged;
                    RaisePropertyChanged("StatsChanged");
                }
            }
        }


        private string _codesStatus;
        public string CodesStatus
        {
            get { return _codesStatus; }
            set
            {
                if (_codesStatus != value)
                {
                    _codesStatus = value;
                    RaisePropertyChanged("CodesStatus");
                }
            }
        }
        private string _skinsStatus;
        public string SkinsStatus
        {
            get { return _skinsStatus; }
            set
            {
                if (_skinsStatus != value)
                {
                    _skinsStatus = value;
                    RaisePropertyChanged("SkinsStatus");
                }
            }
        }
        private string _modelsStatus;
        public string ModelsStatus
        {
            get { return _modelsStatus; }
            set
            {
                if (_modelsStatus != value)
                {
                    _modelsStatus = value;
                    RaisePropertyChanged("ModelsStatus");
                }
            }
        }
        private string _movesetStatus;
        public string MovesetStatus
        {
            get { return _movesetStatus; }
            set
            {
                if (_movesetStatus != value)
                {
                    _movesetStatus = value;
                    RaisePropertyChanged("MovesetStatus");
                }
            }
        }
        private string _musicStatus;
        public string MusicStatus
        {
            get { return _musicStatus; }
            set
            {
                if (_musicStatus != value)
                {
                    _musicStatus = value;
                    RaisePropertyChanged("MusicStatus");
                }
            }
        }
        private string _statsStatus;
        public string StatsStatus
        {
            get { return _statsStatus; }
            set
            {
                if (_statsStatus != value)
                {
                    _statsStatus = value;
                    RaisePropertyChanged("StatsStatus");
                }
            }
        }
        private string _effectStatus;
        public string EffectStatus
        {
            get { return _effectStatus; }
            set
            {
                if (_effectStatus != value)
                {
                    _effectStatus = value;
                    RaisePropertyChanged("EffectStatus");
                }
            }
        }
        private string _folderPathsStatus;
        public string FolderPathsStatus
        {
            get { return _folderPathsStatus; }
            set
            {
                if (_folderPathsStatus != value)
                {
                    _folderPathsStatus = value;
                    RaisePropertyChanged("FolderPathsStatus");
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
        private string _editorReleaseDate;
        public string EditorReleaseDate
        {
            get { return _editorReleaseDate; }
            set
            {
                if (_editorReleaseDate != value)
                {
                    _editorReleaseDate = value;
                    RaisePropertyChanged("EditorReleaseDate");
                }
            }
        }


        private bool _sfxIsOn;

        public bool SfxIsOn
        {
            get { return _sfxIsOn; }
            set
            {
                if (_sfxIsOn != value)
                {
                    _sfxIsOn = value;
                    SettingsClass.PageEnterSFX = _sfxIsOn;
                    RaisePropertyChanged("SfxIsOn");
                }
            }
        }

        private string _soundButton;
        public string SoundButton
        {
            get { return _soundButton; }
            set
            {
                if (_soundButton != value)
                {
                    _soundButton = value;
                    RaisePropertyChanged("SoundButton");
                }
            }
        }

        public List<string> BGM_List = new List<string>
        {
            "Original",
            "Story pack 1",
            "Story pack 2",
            "Story pack 3",
            "Custom pack 1",
            "Tekken 5 pack",
            "Tekken 5DR pack",
            "Dead or Alive 2 pack",
        };


        public List<string> GunMoves = new List<string>
        {
            "Regular shoot",
            "3 bullets in a row",
            "Hidden gun trick",
            "Punch gun",
            "Shovel bullet combo",
            "Knife bullet combo",
            "SPA bullet blowout",
            "SPA sword slash",
            "Ultimate Uzi",
            "Delayed bullet",
        };

        public List<string> YesOrNo = new List<string>
        {
            "No",
            "Yes",
        };

        public List<string> EditorEffects = new List<string>
        {
            "No Effect",
            "Snowing",
            "Raining",
            "Blooding",
            "Leaves",
        };

        internal void GetToolStatus()
        {
            SettingsClass.codeFilePath = SettingsClass.codeFolderPath + @"\" + SettingsClass.PnachName + ".pnach";

            if ((File.Exists(SettingsClass.codeFilePath)))
            {
                if (File.ReadAllText(SettingsClass.codeFilePath) == "")
                {
                    CodesStatus = "OFF";
                }
                else
                {
                    CodesStatus = "ON";
                }
            }
            else
            {
                CodesStatus = "OFF";
            }

            if (SettingsClass.GolemTuxedoTxt || SettingsClass.GolemShirtlessTxt || SettingsClass.KGBeat_upTxt || SettingsClass.GD_04Txt || SettingsClass.KadonashiOGTxt ||
                SettingsClass.OfficerNapalm99Txt || SettingsClass.NightmareTxt || SettingsClass.SuspectTxt || SettingsClass.Shinkai007Txt || SettingsClass.YanJunDrunkenFistTxt ||
                SettingsClass.BoomaSurgeonTxt || SettingsClass.FashionShunYingTxt || SettingsClass.CollegeBoyBradTxt || SettingsClass.HellsLegionBordinTxt || SettingsClass.AlternativeParkTxt ||
                SettingsClass.AristocratChrisTxt || SettingsClass.BouncerFKTxt || SettingsClass.FlamingMiguelTxt || SettingsClass.GeishaLilianTxt || SettingsClass.GrolemTxt ||
                SettingsClass.KoolRamonTxt || SettingsClass.MountainGrimTxt || SettingsClass.RejinTxt || SettingsClass.SpyKellyTxt || SettingsClass.TYCleanClothesTxt ||

                SettingsClass.GlenSkin || SettingsClass.TorqueSkin || SettingsClass.RodSkin || SettingsClass.SethSkin || SettingsClass.NasTiiiSkin ||
                SettingsClass.EmCeeSkin || SettingsClass.RealDealSkin || SettingsClass.JoseSkin || SettingsClass.EmilioSkin || SettingsClass.ZackSkin ||
                SettingsClass.ColinSkin || SettingsClass.JakeSkin || SettingsClass.TongYoonSkin || SettingsClass.BKSkin || SettingsClass.GraveDiggaSkin ||
                SettingsClass.BonesSkin || SettingsClass.BustaSkin || SettingsClass.SpiderSkin || SettingsClass.PainKillahSkin || SettingsClass.DwayneSkin ||
                SettingsClass.DR88Skin || SettingsClass.PT22Skin || SettingsClass.BainSkin || SettingsClass.CooperSkin || SettingsClass.AndersonSkin ||
                SettingsClass.TaylorSkin || SettingsClass.AlexSkin || SettingsClass.McKinzieSkin || SettingsClass.RikiSkin || SettingsClass.MasaSkin ||
                SettingsClass.HiroSkin || SettingsClass.RyujiSkin || SettingsClass.YeWeiSkin || SettingsClass.ShaYingSkin || SettingsClass.LinFongLeeSkin ||
                SettingsClass.VeraSkin || SettingsClass.PaulSkin || SettingsClass.LawSkin ||

                SettingsClass.SH2JamesTxt || SettingsClass.RebeccaChambersTxt || SettingsClass.ParkDanteTxt || SettingsClass.BKCJTxt || SettingsClass.GolemKratosTxt ||
                SettingsClass.SubzeroGolemTxt || SettingsClass.VolcanicNapalmTxt || SettingsClass.CyberDwayneTxt || SettingsClass.HornswoggleTxt || SettingsClass.DemonJinpachiTxt ||
                SettingsClass.RyuTxt || SettingsClass.AyaneShunYingTxt || SettingsClass.MaskedDemonBradTxt || SettingsClass.KOFJakeTxt || SettingsClass.GD_05Skin ||
                SettingsClass.PutaTxt || SettingsClass.ShunYingV2Txt || SettingsClass.SpiderManTxt || SettingsClass.SymbioteSpiderTxt || SettingsClass.HoboBonesTxt ||
                SettingsClass.NegativeToonYoonTxt || SettingsClass.SWAG_TyTxt || SettingsClass.HiroGATTxt ||
                SettingsClass.KG_WhatsAppTxt || SettingsClass.RodKlugerTxt || SettingsClass.TorqueGalsiaTxt || SettingsClass.RealDealKidTxt || SettingsClass.BatmanGlenTxt ||
                SettingsClass.TerminatorMckinzieTxt || SettingsClass.EvilShunYingTxt || SettingsClass.OldMasterShinkaiTxt ||
                SettingsClass.CyberpunkGrimmTxt || SettingsClass.KazumaKiryuBradTxt || SettingsClass.CollinHermitSchoolTxt ||
                SettingsClass.MonsterEnergyGolemTxt || SettingsClass.BradfromGymTxt || SettingsClass.CustomGrimmTxt ||
                SettingsClass.SpecialAgentBradHawkTxt || SettingsClass.MayorJakeHudsonTxt || SettingsClass.GangsterAlexTxt ||
                SettingsClass.GovernmentAgentBradHawkTxt || SettingsClass.SkeletonBoyTxt || SettingsClass.HalloweenFKTxt ||
                SettingsClass.Napumpin99Txt || SettingsClass.VergilAlexTxt || SettingsClass.GolemusTxt ||
                SettingsClass.X2000PopMiguelTxt || SettingsClass.MartialArtistBordinTxt || SettingsClass.McPunisherTxt ||
                SettingsClass.TuxLinTxt || SettingsClass.CEOLinFongTxt || SettingsClass.VeraNinjaTxt ||
                SettingsClass.JohnnyCageLawTxt || SettingsClass.GolemFanboyTxt || SettingsClass.EndangeredMasaTxt ||
                SettingsClass.SantaBonesTxt || SettingsClass.GoldenGipsyTxt ||
                SettingsClass.SethSkin2 || SettingsClass.NasTiiiSkin2 || SettingsClass.RamonSkin2 ||
                SettingsClass.JoseSkin2 || SettingsClass.ZackSkin2 || SettingsClass.GraveDiggaSkin2 ||
                SettingsClass.BoomaSkin2 || SettingsClass.BustaSkin2 || SettingsClass.SpiderSkin2 ||
                SettingsClass.PainKillahSkin2 || SettingsClass.CooperSkin2 || SettingsClass.TaylorSkin2 ||
                SettingsClass.ChrisSkin2 || SettingsClass.RikiSkin2 || SettingsClass.RyujiSkin2 ||
                SettingsClass.YeWeiSkin2 || SettingsClass.ShaYingSkin2 || SettingsClass.YanJunSkin2 ||
                SettingsClass.KellySkin2 || SettingsClass.PaulSkin2 || SettingsClass.EmCeeSkin2 || SettingsClass.PepsimanTxt ||
                SettingsClass.EddyTrainerTxt || SettingsClass.BrademTxt ||
                SettingsClass.TitleScreenTxt || SettingsClass.WarehouseTxt || SettingsClass.WeaponsTxt || SettingsClass.MultyplayerTxt)
            {
                SkinsStatus = "ON";
            }
            else
            {
                SkinsStatus = "OFF";
            }

            if (SettingsClass.KG_Tall_Model || SettingsClass.Real_Dwarf_Model || SettingsClass.Golem_Giant_Model || SettingsClass.Gnome_Napalm_Model
                || SettingsClass.Amazon_Shun_Ying)
            {
                ModelsStatus = "ON";
            }
            else
            {
                ModelsStatus = "OFF";
            }

            if (SettingsClass.MasterBradMoves || SettingsClass.GolemBrokenShitMoves || SettingsClass.BordinAllAroundMoves ||
                SettingsClass.PaulAshesMoves || SettingsClass.SakamotoRyomaMoves || SettingsClass.BradAndOthersParry ||
                SettingsClass.ShinBordinMoves || SettingsClass.KOGMoves || SettingsClass.KingJakeMoves || SettingsClass.MMAGipsiesMoves ||
                SettingsClass.RikiDensetsuMoves || SettingsClass.PhoenixStanceShunYingMoves || SettingsClass.BrokenDwayneMoves)
            {
                MovesetStatus = "ON";
            }
            else
            {
                MovesetStatus = "OFF";
            }

            if (SettingsClass.MusicStatus != "Original")
            {
                MusicStatus = "ON";
            }
            else
            {
                MusicStatus = "OFF";
            }

            if (SettingsClass.StatsChanged)
            {
                StatsStatus = "ON";
            }
            else
            {
                StatsStatus = "OFF";
            }

            if (SettingsClass.codeFolderPath == "" || SettingsClass.codeFilePath == "" || SettingsClass.missionFolderPath == "" || SettingsClass.textureBaseFolderPath == "" ||
                SettingsClass.textureDumpFolderPath == "" || SettingsClass.gameFolderPath == "")
            {
                FolderPathsStatus = "Not Set";
            }
            else
            {
                FolderPathsStatus = "Configured";
            }

            EffectStatus = EditorEffects[SettingsClass.EditorEffectsIndex];

        }

        //internal void EffectSwap()
        //{
        //    if (SettingsClass.EditorEffects == "Original")
        //    {
        //        SettingsClass.EditorEffects = "Snow";
        //    }
        //    else if (SettingsClass.EditorEffects == "Snow")
        //    {
        //        SettingsClass.EditorEffects = "Original";
        //    }

        //    SettingsClass.SaveData();

        //    EffectStatus = SettingsClass.EditorEffects;
        //}

    }
}
