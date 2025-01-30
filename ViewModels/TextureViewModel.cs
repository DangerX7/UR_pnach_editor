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
using System.Drawing;

namespace UR_pnach_editor.ViewModels
{
    public class TextureViewModel : BaseViewModel
    {

        #region Load Data

        public TextureViewModel()
        {
            //SettingsClass.LoadData();
            BaseFolderPath = SettingsClass.textureBaseFolderPath;
            DumpFolderPath = SettingsClass.textureDumpFolderPath;
            if (!SettingsClass.modelsSizeStatus)
            {
                ModelsSizeStatus = "Original";
            }
            else
            {
                ModelsSizeStatus = "Custom";
            }

            GolemTuxedoTxt = SettingsClass.GolemTuxedoTxt;
            GolemShirtlessTxt = SettingsClass.GolemShirtlessTxt;
            KGBeat_upTxt = SettingsClass.KGBeat_upTxt;
            GD_04Txt = SettingsClass.GD_04Txt;
            GD_05Skin = SettingsClass.GD_05Skin;
            KadonashiOGTxt = SettingsClass.KadonashiOGTxt;
            OfficerNapalm99Txt = SettingsClass.OfficerNapalm99Txt;
            NightmareTxt = SettingsClass.NightmareTxt;
            SuspectTxt = SettingsClass.SuspectTxt;
            Shinkai007Txt = SettingsClass.Shinkai007Txt;
            YanJunDrunkenFistTxt = SettingsClass.YanJunDrunkenFistTxt;
            BoomaSurgeonTxt = SettingsClass.BoomaSurgeonTxt;
            FashionShunYingTxt = SettingsClass.FashionShunYingTxt;
            CollegeBoyBradTxt = SettingsClass.CollegeBoyBradTxt;
            HellsLegionBordinTxt = SettingsClass.HellsLegionBordinTxt;
            AlternativeParkTxt = SettingsClass.AlternativeParkTxt;
            AristocratChrisTxt = SettingsClass.AristocratChrisTxt;
            BouncerFKTxt = SettingsClass.BouncerFKTxt;
            FlamingMiguelTxt = SettingsClass.FlamingMiguelTxt;
            GeishaLilianTxt = SettingsClass.GeishaLilianTxt;
            GrolemTxt = SettingsClass.GrolemTxt;
            KoolRamonTxt = SettingsClass.KoolRamonTxt;
            MountainGrimTxt = SettingsClass.MountainGrimTxt;
            RejinTxt = SettingsClass.RejinTxt;
            SpyKellyTxt = SettingsClass.SpyKellyTxt;
            TYCleanClothesTxt = SettingsClass.TYCleanClothesTxt;

            GlenSkin = SettingsClass.GlenSkin;
            TorqueSkin = SettingsClass.TorqueSkin;
            RodSkin = SettingsClass.RodSkin;
            SethSkin = SettingsClass.SethSkin;
            NasTiiiSkin = SettingsClass.NasTiiiSkin;
            EmCeeSkin = SettingsClass.EmCeeSkin;
            RealDealSkin = SettingsClass.RealDealSkin;
            JoseSkin = SettingsClass.JoseSkin;
            EmilioSkin = SettingsClass.EmilioSkin;
            ZackSkin = SettingsClass.ZackSkin;
            ColinSkin = SettingsClass.ColinSkin;
            JakeSkin = SettingsClass.JakeSkin;
            TongYoonSkin = SettingsClass.TongYoonSkin;
            BKSkin = SettingsClass.BKSkin;
            GraveDiggaSkin = SettingsClass.GraveDiggaSkin;
            BonesSkin = SettingsClass.BonesSkin;
            BustaSkin = SettingsClass.BustaSkin;
            SpiderSkin = SettingsClass.SpiderSkin;
            PainKillahSkin = SettingsClass.PainKillahSkin;
            DwayneSkin = SettingsClass.DwayneSkin;
            DR88Skin = SettingsClass.DR88Skin;
            PT22Skin = SettingsClass.PT22Skin;
            BainSkin = SettingsClass.BainSkin;
            CooperSkin = SettingsClass.CooperSkin;
            AndersonSkin = SettingsClass.AndersonSkin;
            TaylorSkin = SettingsClass.TaylorSkin;
            AlexSkin = SettingsClass.AlexSkin;
            McKinzieSkin = SettingsClass.McKinzieSkin;
            RikiSkin = SettingsClass.RikiSkin;
            MasaSkin = SettingsClass.MasaSkin;
            HiroSkin = SettingsClass.HiroSkin;
            RyujiSkin = SettingsClass.RyujiSkin;
            YeWeiSkin = SettingsClass.YeWeiSkin;
            ShaYingSkin = SettingsClass.ShaYingSkin;
            LinFongLeeSkin = SettingsClass.LinFongLeeSkin;
            VeraSkin = SettingsClass.VeraSkin;
            PaulSkin = SettingsClass.PaulSkin;
            LawSkin = SettingsClass.LawSkin;

            SH2JamesTxt = SettingsClass.SH2JamesTxt;
            RebeccaChambersTxt = SettingsClass.RebeccaChambersTxt;
            ParkDanteTxt = SettingsClass.ParkDanteTxt;
            BKCJTxt = SettingsClass.BKCJTxt;
            GolemKratosTxt = SettingsClass.GolemKratosTxt;
            SubzeroGolemTxt = SettingsClass.SubzeroGolemTxt;
            VolcanicNapalmTxt = SettingsClass.VolcanicNapalmTxt;
            CyberDwayneTxt = SettingsClass.CyberDwayneTxt;
            HornswoggleTxt = SettingsClass.HornswoggleTxt;
            DemonJinpachiTxt = SettingsClass.DemonJinpachiTxt;
            RyuTxt = SettingsClass.RyuTxt;
            AyaneShunYingTxt = SettingsClass.AyaneShunYingTxt;
            MaskedDemonBradTxt = SettingsClass.MaskedDemonBradTxt;
            KOFJakeTxt = SettingsClass.KOFJakeTxt;
            PutaTxt = SettingsClass.PutaTxt;
            ShunYingV2Txt = SettingsClass.ShunYingV2Txt;
            SpiderManTxt = SettingsClass.SpiderManTxt;
            SymbioteSpiderTxt = SettingsClass.SymbioteSpiderTxt;
            HoboBonesTxt = SettingsClass.HoboBonesTxt;
            NegativeToonYoonTxt = SettingsClass.NegativeToonYoonTxt;
            SWAG_TyTxt = SettingsClass.SWAG_TyTxt;
            HiroGATTxt = SettingsClass.HiroGATTxt;
            KG_WhatsAppTxt = SettingsClass.KG_WhatsAppTxt;
            RodKlugerTxt = SettingsClass.RodKlugerTxt;
            TorqueGalsiaTxt = SettingsClass.TorqueGalsiaTxt;
            RealDealKidTxt = SettingsClass.RealDealKidTxt;
            BatmanGlenTxt = SettingsClass.BatmanGlenTxt;
            TerminatorMckinzieTxt = SettingsClass.TerminatorMckinzieTxt;
            EvilShunYingTxt = SettingsClass.EvilShunYingTxt;
            OldMasterShinkaiTxt = SettingsClass.OldMasterShinkaiTxt;
            CyberpunkGrimmTxt = SettingsClass.CyberpunkGrimmTxt;
            KazumaKiryuBradTxt = SettingsClass.KazumaKiryuBradTxt;
            CollinHermitSchoolTxt = SettingsClass.CollinHermitSchoolTxt;
            MonsterEnergyGolemTxt = SettingsClass.MonsterEnergyGolemTxt;
            BradfromGymTxt = SettingsClass.BradfromGymTxt;
            CustomGrimmTxt = SettingsClass.CustomGrimmTxt;
            SpecialAgentBradHawkTxt = SettingsClass.SpecialAgentBradHawkTxt;
            MayorJakeHudsonTxt = SettingsClass.MayorJakeHudsonTxt;
            GangsterAlexTxt = SettingsClass.GangsterAlexTxt;
            GovernmentAgentBradHawkTxt = SettingsClass.GovernmentAgentBradHawkTxt;
            SkeletonBoyTxt = SettingsClass.SkeletonBoyTxt;
            HalloweenFKTxt = SettingsClass.HalloweenFKTxt;
            Napumpin99Txt = SettingsClass.Napumpin99Txt;

            VergilAlexTxt = SettingsClass.VergilAlexTxt;
            GolemusTxt = SettingsClass.GolemusTxt;
            X2000PopMiguelTxt = SettingsClass.X2000PopMiguelTxt;
            MartialArtistBordinTxt = SettingsClass.MartialArtistBordinTxt;
            McPunisherTxt = SettingsClass.McPunisherTxt;
            TuxLinTxt = SettingsClass.TuxLinTxt;
            CEOLinFongTxt = SettingsClass.CEOLinFongTxt;
            VeraNinjaTxt = SettingsClass.VeraNinjaTxt;
            JohnnyCageLawTxt = SettingsClass.JohnnyCageLawTxt;
            GolemFanboyTxt = SettingsClass.GolemFanboyTxt;
            EndangeredMasaTxt = SettingsClass.EndangeredMasaTxt;
            SantaBonesTxt = SettingsClass.SantaBonesTxt;
            GoldenGipsyTxt = SettingsClass.GoldenGipsyTxt;


            SethSkin2 = SettingsClass.SethSkin2;
            NasTiiiSkin2 = SettingsClass.NasTiiiSkin2;
            EmCeeSkin2 = SettingsClass.EmCeeSkin2;
            RamonSkin2 = SettingsClass.RamonSkin2;
            JoseSkin2 = SettingsClass.JoseSkin2;
            ZackSkin2 = SettingsClass.ZackSkin2;
            GraveDiggaSkin2 = SettingsClass.GraveDiggaSkin2;
            BoomaSkin2 = SettingsClass.BoomaSkin2;
            BustaSkin2 = SettingsClass.BustaSkin2;
            SpiderSkin2 = SettingsClass.SpiderSkin2;
            PainKillahSkin2 = SettingsClass.PainKillahSkin2;
            CooperSkin2 = SettingsClass.CooperSkin2;
            TaylorSkin2 = SettingsClass.TaylorSkin2;
            ChrisSkin2 = SettingsClass.ChrisSkin2;
            RikiSkin2 = SettingsClass.RikiSkin2;
            RyujiSkin2 = SettingsClass.RyujiSkin2;
            YeWeiSkin2 = SettingsClass.YeWeiSkin2;
            ShaYingSkin2 = SettingsClass.ShaYingSkin2;
            YanJunSkin2 = SettingsClass.YanJunSkin2;
            KellySkin2 = SettingsClass.KellySkin2;
            PaulSkin2 = SettingsClass.PaulSkin2;

            PepsimanTxt = SettingsClass.PepsimanTxt;
            EddyTrainerTxt = SettingsClass.EddyTrainerTxt;
            BrademTxt = SettingsClass.BrademTxt;
            Paul2040Txt = SettingsClass.Paul2040Txt;
            BeachGolemTxt = SettingsClass.BeachGolemTxt;

            TitleScreenTxt = SettingsClass.TitleScreenTxt;
            WarehouseTxt = SettingsClass.WarehouseTxt;
            WeaponsTxt = SettingsClass.WeaponsTxt;
            MultyplayerTxt = SettingsClass.MultyplayerTxt;
        }
        #endregion

        #region Config Variables

        private string _basefolderPath;
        public string BaseFolderPath
        {
            get { return _basefolderPath; }
            set
            {
                if (_basefolderPath != value)
                {
                    _basefolderPath = value;
                    RaisePropertyChanged("BaseFolderPath");
                }
            }
        }

        private string _dumpFolderPath;
        public string DumpFolderPath
        {
            get { return _dumpFolderPath; }
            set
            {
                if (_dumpFolderPath != value)
                {
                    _dumpFolderPath = value;
                    RaisePropertyChanged("DumpFolderPath");
                }
            }
        }

        private int _pageNumber;
        public int PageNumber
        {
            get { return _pageNumber; }
            set
            {
                if (_pageNumber != value)
                {
                    _pageNumber = value;
                    RaisePropertyChanged("PageNumber");
                }
            }
        }

        private string _skinPreview;
        public string SkinPreview
        {
            get { return _skinPreview; }
            set
            {
                if (_skinPreview != value)
                {
                    _skinPreview = value;
                    RaisePropertyChanged("SkinPreview");
                }
            }
        }

        private string _modelsSizeStatus;
        public string ModelsSizeStatus
        {
            get { return _modelsSizeStatus; }
            set
            {
                if (_modelsSizeStatus != value)
                {
                    _modelsSizeStatus = value;
                    RaisePropertyChanged("ModelsSizeStatus");
                }
            }
        }


        #endregion

        #region Textures Variables

        //00 - Brad Hawk****************************************************

        private bool _collegeBoyBradTxt;

        public bool CollegeBoyBradTxt
        {
            get { return _collegeBoyBradTxt; }
            set
            {
                if (_collegeBoyBradTxt != value)
                {
                    _collegeBoyBradTxt = value;
                    SettingsClass.CollegeBoyBradTxt = _collegeBoyBradTxt;
                    RaisePropertyChanged("CollegeBoyBradTxt");
                    if (_collegeBoyBradTxt)
                    {
                        _sH2JamesTxt = false;
                        _maskedDemonBradTxt = false;
                        _kazumaKiryuBradTxt = false;
                        _bradfromGymTxt = false;
                        _specialAgentBradHawkTxt = false;
                        _governmentAgentBradHawkTxt = false;
                        RaisePropertyChanged("SH2JamesTxt");
                        RaisePropertyChanged("MaskedDemonBradTxt");
                        RaisePropertyChanged("KazumaKiryuBradTxt");
                        RaisePropertyChanged("BradfromGymTxt");
                        RaisePropertyChanged("SpecialAgentBradHawkTxt");
                        RaisePropertyChanged("GovernmentAgentBradHawkTxt");
                        SettingsClass.SH2JamesTxt = false;
                        SettingsClass.MaskedDemonBradTxt = false;
                        SettingsClass.KazumaKiryuBradTxt = false;
                        SettingsClass.BradfromGymTxt = false;
                        SettingsClass.SpecialAgentBradHawkTxt = false;
                        SettingsClass.GovernmentAgentBradHawkTxt = false;
                    }
                }
            }
        }

        private bool _sH2JamesTxt;

        public bool SH2JamesTxt
        {
            get { return _sH2JamesTxt; }
            set
            {
                if (_sH2JamesTxt != value)
                {
                    _sH2JamesTxt = value;
                    SettingsClass.SH2JamesTxt = _sH2JamesTxt;
                    RaisePropertyChanged("SH2JamesTxt");
                    if (_sH2JamesTxt)
                    {
                        _collegeBoyBradTxt = false;
                        _maskedDemonBradTxt = false;
                        _kazumaKiryuBradTxt = false;
                        _bradfromGymTxt = false;
                        _specialAgentBradHawkTxt = false;
                        _governmentAgentBradHawkTxt = false;
                        RaisePropertyChanged("CollegeBoyBradTxt");
                        RaisePropertyChanged("MaskedDemonBradTxt");
                        RaisePropertyChanged("KazumaKiryuBradTxt");
                        RaisePropertyChanged("BradfromGymTxt");
                        RaisePropertyChanged("SpecialAgentBradHawkTxt");
                        RaisePropertyChanged("GovernmentAgentBradHawkTxt");
                        SettingsClass.CollegeBoyBradTxt = false;
                        SettingsClass.MaskedDemonBradTxt = false;
                        SettingsClass.KazumaKiryuBradTxt = false;
                        SettingsClass.BradfromGymTxt = false;
                        SettingsClass.SpecialAgentBradHawkTxt = false;
                        SettingsClass.GovernmentAgentBradHawkTxt = false;
                    }
                }
            }
        }

        private bool _maskedDemonBradTxt;

        public bool MaskedDemonBradTxt
        {
            get { return _maskedDemonBradTxt; }
            set
            {
                if (_maskedDemonBradTxt != value)
                {
                    _maskedDemonBradTxt = value;
                    SettingsClass.MaskedDemonBradTxt = _maskedDemonBradTxt;
                    RaisePropertyChanged("MaskedDemonBradTxt");
                    if (_maskedDemonBradTxt)
                    {
                        _collegeBoyBradTxt = false;
                        _sH2JamesTxt = false;
                        _kazumaKiryuBradTxt = false;
                        _bradfromGymTxt = false;
                        _specialAgentBradHawkTxt = false;
                        _governmentAgentBradHawkTxt = false;
                        RaisePropertyChanged("CollegeBoyBradTxt");
                        RaisePropertyChanged("SH2JamesTxt");
                        RaisePropertyChanged("KazumaKiryuBradTxt");
                        RaisePropertyChanged("BradfromGymTxt");
                        RaisePropertyChanged("SpecialAgentBradHawkTxt");
                        RaisePropertyChanged("GovernmentAgentBradHawkTxt");
                        SettingsClass.CollegeBoyBradTxt = false;
                        SettingsClass.SH2JamesTxt = false;
                        SettingsClass.KazumaKiryuBradTxt = false;
                        SettingsClass.BradfromGymTxt = false;
                        SettingsClass.SpecialAgentBradHawkTxt = false;
                        SettingsClass.GovernmentAgentBradHawkTxt = false;
                    }
                }
            }
        }

        private bool _kazumaKiryuBradTxt;

        public bool KazumaKiryuBradTxt
        {
            get { return _kazumaKiryuBradTxt; }
            set
            {
                if (_kazumaKiryuBradTxt != value)
                {
                    _kazumaKiryuBradTxt = value;
                    SettingsClass.KazumaKiryuBradTxt = _kazumaKiryuBradTxt;
                    RaisePropertyChanged("KazumaKiryuBradTxt");
                    if (_kazumaKiryuBradTxt)
                    {
                        _collegeBoyBradTxt = false;
                        _sH2JamesTxt = false;
                        _maskedDemonBradTxt = false;
                        _bradfromGymTxt = false;
                        _specialAgentBradHawkTxt = false;
                        _governmentAgentBradHawkTxt = false;
                        RaisePropertyChanged("CollegeBoyBradTxt");
                        RaisePropertyChanged("SH2JamesTxt");
                        RaisePropertyChanged("MaskedDemonBradTxt");
                        RaisePropertyChanged("BradfromGymTxt");
                        RaisePropertyChanged("SpecialAgentBradHawkTxt");
                        RaisePropertyChanged("GovernmentAgentBradHawkTxt");
                        SettingsClass.CollegeBoyBradTxt = false;
                        SettingsClass.SH2JamesTxt = false;
                        SettingsClass.MaskedDemonBradTxt = false;
                        SettingsClass.BradfromGymTxt = false;
                        SettingsClass.SpecialAgentBradHawkTxt = false;
                        SettingsClass.GovernmentAgentBradHawkTxt = false;
                    }
                }
            }
        }

        private bool _bradfromGymTxt;

        public bool BradfromGymTxt
        {
            get { return _bradfromGymTxt; }
            set
            {
                if (_bradfromGymTxt != value)
                {
                    _bradfromGymTxt = value;
                    SettingsClass.BradfromGymTxt = _bradfromGymTxt;
                    RaisePropertyChanged("BradfromGymTxt");
                    if (_bradfromGymTxt)
                    {
                        _collegeBoyBradTxt = false;
                        _sH2JamesTxt = false;
                        _maskedDemonBradTxt = false;
                        _kazumaKiryuBradTxt = false;
                        _specialAgentBradHawkTxt = false;
                        _governmentAgentBradHawkTxt = false;
                        RaisePropertyChanged("CollegeBoyBradTxt");
                        RaisePropertyChanged("SH2JamesTxt");
                        RaisePropertyChanged("MaskedDemonBradTxt");
                        RaisePropertyChanged("KazumaKiryuBradTxt");
                        RaisePropertyChanged("SpecialAgentBradHawkTxt");
                        RaisePropertyChanged("GovernmentAgentBradHawkTxt");
                        SettingsClass.CollegeBoyBradTxt = false;
                        SettingsClass.SH2JamesTxt = false;
                        SettingsClass.MaskedDemonBradTxt = false;
                        SettingsClass.KazumaKiryuBradTxt = false;
                        SettingsClass.SpecialAgentBradHawkTxt = false;
                        SettingsClass.GovernmentAgentBradHawkTxt = false;
                    }
                }
            }
        }

        private bool _specialAgentBradHawkTxt;

        public bool SpecialAgentBradHawkTxt
        {
            get { return _specialAgentBradHawkTxt; }
            set
            {
                if (_specialAgentBradHawkTxt != value)
                {
                    _specialAgentBradHawkTxt = value;
                    SettingsClass.SpecialAgentBradHawkTxt = _specialAgentBradHawkTxt;
                    RaisePropertyChanged("SpecialAgentBradHawkTxt");
                    if (_specialAgentBradHawkTxt)
                    {
                        _collegeBoyBradTxt = false;
                        _sH2JamesTxt = false;
                        _maskedDemonBradTxt = false;
                        _kazumaKiryuBradTxt = false;
                        _bradfromGymTxt = false;
                        _governmentAgentBradHawkTxt = false;
                        RaisePropertyChanged("CollegeBoyBradTxt");
                        RaisePropertyChanged("SH2JamesTxt");
                        RaisePropertyChanged("MaskedDemonBradTxt");
                        RaisePropertyChanged("KazumaKiryuBradTxt");
                        RaisePropertyChanged("BradfromGymTxt");
                        RaisePropertyChanged("GovernmentAgentBradHawkTxt");
                        SettingsClass.CollegeBoyBradTxt = false;
                        SettingsClass.SH2JamesTxt = false;
                        SettingsClass.MaskedDemonBradTxt = false;
                        SettingsClass.KazumaKiryuBradTxt = false;
                        SettingsClass.BradfromGymTxt = false;
                        SettingsClass.GovernmentAgentBradHawkTxt = false;
                    }
                }
            }
        }

        private bool _governmentAgentBradHawkTxt;

        public bool GovernmentAgentBradHawkTxt
        {
            get { return _governmentAgentBradHawkTxt; }
            set
            {
                if (_governmentAgentBradHawkTxt != value)
                {
                    _governmentAgentBradHawkTxt = value;
                    SettingsClass.GovernmentAgentBradHawkTxt = _governmentAgentBradHawkTxt;
                    RaisePropertyChanged("GovernmentAgentBradHawkTxt");
                    if (_governmentAgentBradHawkTxt)
                    {
                        _collegeBoyBradTxt = false;
                        _sH2JamesTxt = false;
                        _maskedDemonBradTxt = false;
                        _kazumaKiryuBradTxt = false;
                        _bradfromGymTxt = false;
                        _specialAgentBradHawkTxt = false;
                        RaisePropertyChanged("CollegeBoyBradTxt");
                        RaisePropertyChanged("SH2JamesTxt");
                        RaisePropertyChanged("MaskedDemonBradTxt");
                        RaisePropertyChanged("KazumaKiryuBradTxt");
                        RaisePropertyChanged("BradfromGymTxt");
                        RaisePropertyChanged("SpecialAgentBradHawkTxt");
                        SettingsClass.CollegeBoyBradTxt = false;
                        SettingsClass.SH2JamesTxt = false;
                        SettingsClass.MaskedDemonBradTxt = false;
                        SettingsClass.KazumaKiryuBradTxt = false;
                        SettingsClass.BradfromGymTxt = false;
                        SettingsClass.SpecialAgentBradHawkTxt = false;
                    }
                }
            }
        }
        //03 - Glen*********************************************************

        private bool _glenSkin;

        public bool GlenSkin
        {
            get { return _glenSkin; }
            set
            {
                if (_glenSkin != value)
                {
                    _glenSkin = value;
                    SettingsClass.GlenSkin = _glenSkin;
                    RaisePropertyChanged("GlenSkin");
                    if (_glenSkin)
                    {
                        _batmanGlenTxt = false;
                        RaisePropertyChanged("BatmanGlenTxt");
                        SettingsClass.BatmanGlenTxt = false;
                    }
                }
            }
        }

        private bool _batmanGlenTxt;

        public bool BatmanGlenTxt
        {
            get { return _batmanGlenTxt; }
            set
            {
                if (_batmanGlenTxt != value)
                {
                    _batmanGlenTxt = value;
                    SettingsClass.BatmanGlenTxt = _batmanGlenTxt;
                    RaisePropertyChanged("BatmanGlenTxt");
                    if (_batmanGlenTxt)
                    {
                        _glenSkin = false;
                        RaisePropertyChanged("GlenSkin");
                        SettingsClass.GlenSkin = false;
                    }
                }
            }
        }
        //04 - Torque*******************************************************

        private bool _torqueSkin;

        public bool TorqueSkin
        {
            get { return _torqueSkin; }
            set
            {
                if (_torqueSkin != value)
                {
                    _torqueSkin = value;
                    SettingsClass.TorqueSkin = _torqueSkin;
                    RaisePropertyChanged("TorqueSkin");
                    if (_torqueSkin)
                    {
                        _torqueGalsiaTxt = false;
                        RaisePropertyChanged("TorqueGalsiaTxt");
                        SettingsClass.TorqueGalsiaTxt = false;
                    }
                }
            }
        }

        private bool _torqueGalsiaTxt;

        public bool TorqueGalsiaTxt
        {
            get { return _torqueGalsiaTxt; }
            set
            {
                if (_torqueGalsiaTxt != value)
                {
                    _torqueGalsiaTxt = value;
                    SettingsClass.TorqueGalsiaTxt = _torqueGalsiaTxt;
                    RaisePropertyChanged("TorqueGalsiaTxt");
                    if (_torqueGalsiaTxt)
                    {
                        _torqueSkin = false;
                        RaisePropertyChanged("TorqueSkin");
                        SettingsClass.TorqueSkin = false;
                    }
                }
            }
        }
        //05 - Rod**********************************************************

        private bool _rodSkin;

        public bool RodSkin
        {
            get { return _rodSkin; }
            set
            {
                if (_rodSkin != value)
                {
                    _rodSkin = value;
                    SettingsClass.RodSkin = _rodSkin;
                    RaisePropertyChanged("RodSkin");
                    if (_rodSkin)
                    {
                        _rodKlugerTxt = false;
                        RaisePropertyChanged("RodKlugerTxt");
                        SettingsClass.RodKlugerTxt = false;
                    }
                }
            }
        }

        private bool _rodKlugerTxt;

        public bool RodKlugerTxt
        {
            get { return _rodKlugerTxt; }
            set
            {
                if (_rodKlugerTxt != value)
                {
                    _rodKlugerTxt = value;
                    SettingsClass.RodKlugerTxt = _rodKlugerTxt;
                    RaisePropertyChanged("RodKlugerTxt");
                    if (_rodKlugerTxt)
                    {
                        _rodSkin = false;
                        RaisePropertyChanged("RodSkin");
                        SettingsClass.RodSkin = false;
                    }
                }
            }
        }
        //06 - Seth*********************************************************

        private bool _sethSkin;

        public bool SethSkin
        {
            get { return _sethSkin; }
            set
            {
                if (_sethSkin != value)
                {
                    _sethSkin = value;
                    SettingsClass.SethSkin = _sethSkin;
                    RaisePropertyChanged("SethSkin");
                    if (_sethSkin)
                    {
                        _sethSkin2 = false;
                        RaisePropertyChanged("SethSkin2");
                        SettingsClass.SethSkin2 = false;
                    }
                }
            }
        }

        private bool _sethSkin2;

        public bool SethSkin2
        {
            get { return _sethSkin2; }
            set
            {
                if (_sethSkin2 != value)
                {
                    _sethSkin2 = value;
                    SettingsClass.SethSkin2 = _sethSkin2;
                    RaisePropertyChanged("SethSkin2");
                    if (_sethSkin2)
                    {
                        _sethSkin = false;
                        RaisePropertyChanged("SethSkin");
                        SettingsClass.SethSkin = false;
                    }
                }
            }
        }
        //07 - Nas-Tiii*****************************************************

        private bool _nasTiiiSkin;

        public bool NasTiiiSkin
        {
            get { return _nasTiiiSkin; }
            set
            {
                if (_nasTiiiSkin != value)
                {
                    _nasTiiiSkin = value;
                    SettingsClass.NasTiiiSkin = _nasTiiiSkin;
                    RaisePropertyChanged("NasTiiiSkin");
                    if (_nasTiiiSkin)
                    {
                        _nasTiiiSkin2 = false;
                        RaisePropertyChanged("NasTiiiSkin2");
                        SettingsClass.NasTiiiSkin2 = false;
                    }
                }
            }
        }

        private bool _nasTiiiSkin2;

        public bool NasTiiiSkin2
        {
            get { return _nasTiiiSkin2; }
            set
            {
                if (_nasTiiiSkin2 != value)
                {
                    _nasTiiiSkin2 = value;
                    SettingsClass.NasTiiiSkin2 = _nasTiiiSkin2;
                    RaisePropertyChanged("NasTiiiSkin2");
                    if (_nasTiiiSkin2)
                    {
                        _nasTiiiSkin = false;
                        RaisePropertyChanged("NasTiiiSkin");
                        SettingsClass.NasTiiiSkin = false;
                    }
                }
            }
        }
        //08 - Em Cee*******************************************************

        private bool _emCeeSkin;

        public bool EmCeeSkin
        {
            get { return _emCeeSkin; }
            set
            {
                if (_emCeeSkin != value)
                {
                    _emCeeSkin = value;
                    SettingsClass.EmCeeSkin = _emCeeSkin;
                    RaisePropertyChanged("EmCeeSkin");
                    if (_emCeeSkin)
                    {
                        _emCeeSkin2 = false;
                        RaisePropertyChanged("EmCeeSkin2");
                        SettingsClass.EmCeeSkin2 = false;
                    }
                }
            }
        }

        private bool _emCeeSkin2;

        public bool EmCeeSkin2
        {
            get { return _emCeeSkin2; }
            set
            {
                if (_emCeeSkin2 != value)
                {
                    _emCeeSkin2 = value;
                    SettingsClass.EmCeeSkin2 = _emCeeSkin2;
                    RaisePropertyChanged("EmCeeSkin2");
                    if (_emCeeSkin2)
                    {
                        _emCeeSkin = false;
                        RaisePropertyChanged("EmCeeSkin");
                        SettingsClass.EmCeeSkin = false;
                    }
                }
            }
        }
        //09 - Real Deal****************************************************

        private bool _realDealSkin;

        public bool RealDealSkin
        {
            get { return _realDealSkin; }
            set
            {
                if (_realDealSkin != value)
                {
                    _realDealSkin = value;
                    SettingsClass.RealDealSkin = _realDealSkin;
                    RaisePropertyChanged("RealDealSkin");
                    if (_realDealSkin)
                    {
                        _hornswoggleTxt = false;
                        _realDealKidTxt = false;
                        RaisePropertyChanged("HornswoggleTxt");
                        RaisePropertyChanged("RealDealKidTxt");
                        SettingsClass.HornswoggleTxt = false;
                        SettingsClass.RealDealKidTxt = false;
                    }
                }
            }
        }

        private bool _realDealKidTxt;

        public bool RealDealKidTxt
        {
            get { return _realDealKidTxt; }
            set
            {
                if (_realDealKidTxt != value)
                {
                    _realDealKidTxt = value;
                    SettingsClass.RealDealKidTxt = _realDealKidTxt;
                    RaisePropertyChanged("RealDealKidTxt");
                    if (_realDealKidTxt)
                    {
                        _realDealSkin = false;
                        _hornswoggleTxt = false;
                        RaisePropertyChanged("RealDealSkin");
                        RaisePropertyChanged("HornswoggleTxt");
                        SettingsClass.RealDealSkin = false;
                        SettingsClass.HornswoggleTxt = false;
                    }
                }
            }
        }

        private bool _hornswoggleTxt;

        public bool HornswoggleTxt
        {
            get { return _hornswoggleTxt; }
            set
            {
                if (_hornswoggleTxt != value)
                {
                    _hornswoggleTxt = value;
                    SettingsClass.HornswoggleTxt = _hornswoggleTxt;
                    RaisePropertyChanged("HornswoggleTxt");
                    if (_hornswoggleTxt)
                    {
                        _realDealSkin = false;
                        _realDealKidTxt = false;
                        RaisePropertyChanged("RealDealSkin");
                        RaisePropertyChanged("RealDealKidTxt");
                        SettingsClass.RealDealSkin = false;
                        SettingsClass.RealDealKidTxt = false;
                    }
                }
            }
        }
        //0A - Ty***********************************************************

        private bool _tYCleanClothesTxt;

        public bool TYCleanClothesTxt
        {
            get { return _tYCleanClothesTxt; }
            set
            {
                if (_tYCleanClothesTxt != value)
                {
                    _tYCleanClothesTxt = value;
                    SettingsClass.TYCleanClothesTxt = _tYCleanClothesTxt;
                    RaisePropertyChanged("TYCleanClothesTxt");
                    if (_tYCleanClothesTxt)
                    {
                        _sWAG_TyTxt = false;
                        RaisePropertyChanged("SWAG_TyTxt");
                        SettingsClass.SWAG_TyTxt = false;
                    }
                }
            }
        }

        private bool _sWAG_TyTxt;

        public bool SWAG_TyTxt
        {
            get { return _sWAG_TyTxt; }
            set
            {
                if (_sWAG_TyTxt != value)
                {
                    _sWAG_TyTxt = value;
                    SettingsClass.SWAG_TyTxt = _sWAG_TyTxt;
                    RaisePropertyChanged("SWAG_TyTxt");
                    if (_sWAG_TyTxt)
                    {
                        _tYCleanClothesTxt = false;
                        RaisePropertyChanged("TYCleanClothesTxt");
                        SettingsClass.TYCleanClothesTxt = false;
                    }
                }
            }
        }
        //0B - Miguel*******************************************************

        private bool _flamingMiguelTxt;

        public bool FlamingMiguelTxt
        {
            get { return _flamingMiguelTxt; }
            set
            {
                if (_flamingMiguelTxt != value)
                {
                    _flamingMiguelTxt = value;
                    SettingsClass.FlamingMiguelTxt = _flamingMiguelTxt;
                    RaisePropertyChanged("FlamingMiguelTxt");
                    if (_flamingMiguelTxt)
                    {
                        _x2000PopMiguelTxt = false;
                        RaisePropertyChanged("X2000PopMiguelTxt");
                        SettingsClass.X2000PopMiguelTxt = false;
                    }
                }
            }
        }

        private bool _x2000PopMiguelTxt;

        public bool X2000PopMiguelTxt
        {
            get { return _x2000PopMiguelTxt; }
            set
            {
                if (_x2000PopMiguelTxt != value)
                {
                    _x2000PopMiguelTxt = value;
                    SettingsClass.X2000PopMiguelTxt = _x2000PopMiguelTxt;
                    RaisePropertyChanged("X2000PopMiguelTxt");
                    if (_x2000PopMiguelTxt)
                    {
                        _flamingMiguelTxt = false;
                        RaisePropertyChanged("FlamingMiguelTxt");
                        SettingsClass.FlamingMiguelTxt = false;
                    }
                }
            }
        }
        //0C - Ramon********************************************************

        private bool _koolRamonTxt;

        public bool KoolRamonTxt
        {
            get { return _koolRamonTxt; }
            set
            {
                if (_koolRamonTxt != value)
                {
                    _koolRamonTxt = value;
                    SettingsClass.KoolRamonTxt = _koolRamonTxt;
                    RaisePropertyChanged("KoolRamonTxt");
                    if (_koolRamonTxt)
                    {
                        _ramonSkin2 = false;
                        RaisePropertyChanged("RamonSkin2");
                        SettingsClass.RamonSkin2 = false;
                    }
                }
            }
        }

        private bool _ramonSkin2;

        public bool RamonSkin2
        {
            get { return _ramonSkin2; }
            set
            {
                if (_ramonSkin2 != value)
                {
                    _ramonSkin2 = value;
                    SettingsClass.RamonSkin2 = _ramonSkin2;
                    RaisePropertyChanged("RamonSkin2");
                    if (_ramonSkin2)
                    {
                        _koolRamonTxt = false;
                        RaisePropertyChanged("KoolRamonTxt");
                        SettingsClass.KoolRamonTxt = false;
                    }
                }
            }
        }
        //0D - Jose*********************************************************

        private bool _joseSkin;

        public bool JoseSkin
        {
            get { return _joseSkin; }
            set
            {
                if (_joseSkin != value)
                {
                    _joseSkin = value;
                    SettingsClass.JoseSkin = _joseSkin;
                    RaisePropertyChanged("JoseSkin");
                    if (_joseSkin)
                    {
                        _joseSkin2 = false;
                        RaisePropertyChanged("JoseSkin2");
                        SettingsClass.JoseSkin2 = false;
                    }
                }
            }
        }

        private bool _joseSkin2;

        public bool JoseSkin2
        {
            get { return _joseSkin2; }
            set
            {
                if (_joseSkin2 != value)
                {
                    _joseSkin2 = value;
                    SettingsClass.JoseSkin2 = _joseSkin2;
                    RaisePropertyChanged("JoseSkin2");
                    if (_joseSkin2)
                    {
                        _joseSkin = false;
                        RaisePropertyChanged("JoseSkin");
                        SettingsClass.JoseSkin = false;
                    }
                }
            }
        }
        //0E - Emilio*******************************************************

        private bool _emilioSkin;

        public bool EmilioSkin
        {
            get { return _emilioSkin; }
            set
            {
                if (_emilioSkin != value)
                {
                    _emilioSkin = value;
                    SettingsClass.EmilioSkin = _emilioSkin;
                    RaisePropertyChanged("EmilioSkin");
                    if (_emilioSkin)
                    {
                        _goldenGipsyTxt = false;
                        RaisePropertyChanged("GoldenGipsyTxt");
                        SettingsClass.GoldenGipsyTxt = false;
                    }
                }
            }
        }

        private bool _goldenGipsyTxt;

        public bool GoldenGipsyTxt
        {
            get { return _goldenGipsyTxt; }
            set
            {
                if (_goldenGipsyTxt != value)
                {
                    _goldenGipsyTxt = value;
                    SettingsClass.GoldenGipsyTxt = _goldenGipsyTxt;
                    RaisePropertyChanged("GoldenGipsyTxt");
                    if (_goldenGipsyTxt)
                    {
                        _emilioSkin = false;
                        RaisePropertyChanged("EmilioSkin");
                        SettingsClass.EmilioSkin = false;
                    }
                }
            }
        }
        //0F - Kadonashi****************************************************
        private bool _kadonashiOGTxt;

        public bool KadonashiOGTxt
        {
            get { return _kadonashiOGTxt; }
            set
            {
                if (_kadonashiOGTxt != value)
                {
                    _kadonashiOGTxt = value;
                    SettingsClass.KadonashiOGTxt = _kadonashiOGTxt;
                    RaisePropertyChanged("KadonashiOGTxt");
                    if (_kadonashiOGTxt)
                    {
                        _ryuTxt = false;
                        RaisePropertyChanged("RyuTxt");
                        SettingsClass.RyuTxt = false;
                    }
                }
            }
        }

        private bool _ryuTxt;

        public bool RyuTxt
        {
            get { return _ryuTxt; }
            set
            {
                if (_ryuTxt != value)
                {
                    _ryuTxt = value;
                    SettingsClass.RyuTxt = _ryuTxt;
                    RaisePropertyChanged("RyuTxt");
                    if (_ryuTxt)
                    {
                        _kadonashiOGTxt = false;
                        RaisePropertyChanged("KadonashiOGTxt");
                        SettingsClass.KadonashiOGTxt = false;
                    }
                }
            }
        }
        //10 - Reggie*******************************************************

        private bool _rejinTxt;

        public bool RejinTxt
        {
            get { return _rejinTxt; }
            set
            {
                if (_rejinTxt != value)
                {
                    _rejinTxt = value;
                    SettingsClass.RejinTxt = _rejinTxt;
                    RaisePropertyChanged("RejinTxt");
                    if (_rejinTxt)
                    {
                        _spiderManTxt = false;
                        RaisePropertyChanged("SpiderManTxt");
                        SettingsClass.SpiderManTxt = false;
                    }
                }
            }
        }

        private bool _spiderManTxt;

        public bool SpiderManTxt
        {
            get { return _spiderManTxt; }
            set
            {
                if (_spiderManTxt != value)
                {
                    _spiderManTxt = value;
                    SettingsClass.SpiderManTxt = _spiderManTxt;
                    RaisePropertyChanged("SpiderManTxt");
                    if (_spiderManTxt)
                    {
                        _rejinTxt = false;
                        RaisePropertyChanged("RejinTxt");
                        SettingsClass.RejinTxt = false;
                    }
                }
            }
        }
        //11 - Zack*********************************************************

        private bool _zackSkin;

        public bool ZackSkin
        {
            get { return _zackSkin; }
            set
            {
                if (_zackSkin != value)
                {
                    _zackSkin = value;
                    SettingsClass.ZackSkin = _zackSkin;
                    RaisePropertyChanged("ZackSkin");
                    if (_zackSkin)
                    {
                        _zackSkin2 = false;
                        RaisePropertyChanged("ZackSkin2");
                        SettingsClass.ZackSkin2 = false;
                    }
                }
            }
        }
        private bool _zackSkin2;

        public bool ZackSkin2
        {
            get { return _zackSkin2; }
            set
            {
                if (_zackSkin2 != value)
                {
                    _zackSkin2 = value;
                    SettingsClass.ZackSkin2 = _zackSkin2;
                    RaisePropertyChanged("ZackSkin2");
                    if (_zackSkin2)
                    {
                        _zackSkin = false;
                        RaisePropertyChanged("ZackSkin");
                        SettingsClass.ZackSkin = false;
                    }
                }
            }
        }
        //12 - Colin********************************************************

        private bool _colinSkin;

        public bool ColinSkin
        {
            get { return _colinSkin; }
            set
            {
                if (_colinSkin != value)
                {
                    _colinSkin = value;
                    SettingsClass.ColinSkin = _colinSkin;
                    RaisePropertyChanged("ColinSkin");
                    if (_colinSkin)
                    {
                        _collinHermitSchoolTxt = false;
                        RaisePropertyChanged("CollinHermitSchoolTxt");
                        SettingsClass.CollinHermitSchoolTxt = false;
                    }
                }
            }
        }

        private bool _collinHermitSchoolTxt;

        public bool CollinHermitSchoolTxt
        {
            get { return _collinHermitSchoolTxt; }
            set
            {
                if (_collinHermitSchoolTxt != value)
                {
                    _collinHermitSchoolTxt = value;
                    SettingsClass.CollinHermitSchoolTxt = _collinHermitSchoolTxt;
                    RaisePropertyChanged("CollinHermitSchoolTxt");
                    if (_collinHermitSchoolTxt)
                    {
                        _colinSkin = false;
                        RaisePropertyChanged("ColinSkin");
                        SettingsClass.ColinSkin = false;
                    }
                }
            }
        }
        //13 - Jake*********************************************************

        private bool _jakeSkin;

        public bool JakeSkin
        {
            get { return _jakeSkin; }
            set
            {
                if (_jakeSkin != value)
                {
                    _jakeSkin = value;
                    SettingsClass.JakeSkin = _jakeSkin;
                    RaisePropertyChanged("JakeSkin");
                    if (_jakeSkin)
                    {
                        _kOFJakeTxt = false;
                        _mayorJakeHudsonTxt = false;
                        RaisePropertyChanged("KOFJakeTxt");
                        RaisePropertyChanged("MayorJakeHudsonTxt");
                        SettingsClass.KOFJakeTxt = false;
                        SettingsClass.MayorJakeHudsonTxt = false;
                    }
                }
            }
        }

        private bool _kOFJakeTxt;

        public bool KOFJakeTxt
        {
            get { return _kOFJakeTxt; }
            set
            {
                if (_kOFJakeTxt != value)
                {
                    _kOFJakeTxt = value;
                    SettingsClass.KOFJakeTxt = _kOFJakeTxt;
                    RaisePropertyChanged("KOFJakeTxt");
                    if (_kOFJakeTxt)
                    {
                        _jakeSkin = false;
                        _mayorJakeHudsonTxt = false;
                        RaisePropertyChanged("JakeSkin");
                        RaisePropertyChanged("MayorJakeHudsonTxt");
                        SettingsClass.JakeSkin = false;
                        SettingsClass.MayorJakeHudsonTxt = false;
                    }
                }
            }
        }

        private bool _mayorJakeHudsonTxt;

        public bool MayorJakeHudsonTxt
        {
            get { return _mayorJakeHudsonTxt; }
            set
            {
                if (_mayorJakeHudsonTxt != value)
                {
                    _mayorJakeHudsonTxt = value;
                    SettingsClass.MayorJakeHudsonTxt = _mayorJakeHudsonTxt;
                    RaisePropertyChanged("MayorJakeHudsonTxt");
                    if (_mayorJakeHudsonTxt)
                    {
                        _jakeSkin = false;
                        _kOFJakeTxt = false;
                        RaisePropertyChanged("JakeSkin");
                        RaisePropertyChanged("KOFJakeTxt");
                        SettingsClass.JakeSkin = false;
                        SettingsClass.KOFJakeTxt = false;
                    }
                }
            }
        }
        
        //14 - Tong Yoon****************************************************

        private bool _tongYoonSkin;

        public bool TongYoonSkin
        {
            get { return _tongYoonSkin; }
            set
            {
                if (_tongYoonSkin != value)
                {
                    _tongYoonSkin = value;
                    SettingsClass.TongYoonSkin = _tongYoonSkin;
                    RaisePropertyChanged("TongYoonSkin");
                    if (_tongYoonSkin)
                    {
                        _negativeToonYoonTxt = false;
                        RaisePropertyChanged("NegativeToonYoonTxt");
                        SettingsClass.NegativeToonYoonTxt = false;
                    }
                }
            }
        }

        private bool _negativeToonYoonTxt;

        public bool NegativeToonYoonTxt
        {
            get { return _negativeToonYoonTxt; }
            set
            {
                if (_negativeToonYoonTxt != value)
                {
                    _negativeToonYoonTxt = value;
                    SettingsClass.NegativeToonYoonTxt = _negativeToonYoonTxt;
                    RaisePropertyChanged("NegativeToonYoonTxt");
                    if (_negativeToonYoonTxt)
                    {
                        _tongYoonSkin = false;
                        RaisePropertyChanged("TongYoonSkin");
                        SettingsClass.TongYoonSkin = false;
                    }
                }
            }
        }
        //15 - Grimm********************************************************

        private bool _mountainGrimTxt;

        public bool MountainGrimTxt
        {
            get { return _mountainGrimTxt; }
            set
            {
                if (_mountainGrimTxt != value)
                {
                    _mountainGrimTxt = value;
                    SettingsClass.MountainGrimTxt = _mountainGrimTxt;
                    RaisePropertyChanged("MountainGrimTxt");
                    if (_mountainGrimTxt)
                    {
                        _customGrimmTxt = false;
                        _cyberpunkGrimmTxt = false;
                        RaisePropertyChanged("CyberpunkGrimmTxt");
                        RaisePropertyChanged("CustomGrimmTxt");
                        SettingsClass.CyberpunkGrimmTxt = false;
                        SettingsClass.CustomGrimmTxt = false;
                    }
                }
            }
        }

        private bool _cyberpunkGrimmTxt;

        public bool CyberpunkGrimmTxt
        {
            get { return _cyberpunkGrimmTxt; }
            set
            {
                if (_cyberpunkGrimmTxt != value)
                {
                    _cyberpunkGrimmTxt = value;
                    SettingsClass.CyberpunkGrimmTxt = _cyberpunkGrimmTxt;
                    RaisePropertyChanged("CyberpunkGrimmTxt");
                    if (_cyberpunkGrimmTxt)
                    {
                        _mountainGrimTxt = false;
                        _customGrimmTxt = false;
                        RaisePropertyChanged("MountainGrimTxt");
                        RaisePropertyChanged("CustomGrimmTxt");
                        SettingsClass.MountainGrimTxt = false;
                        SettingsClass.CustomGrimmTxt = false;
                    }
                }
            }
        }

        private bool _customGrimmTxt;

        public bool CustomGrimmTxt
        {
            get { return _customGrimmTxt; }
            set
            {
                if (_customGrimmTxt != value)
                {
                    _customGrimmTxt = value;
                    SettingsClass.CustomGrimmTxt = _customGrimmTxt;
                    RaisePropertyChanged("CustomGrimmTxt");
                    if (_customGrimmTxt)
                    {
                        _mountainGrimTxt = false;
                        _cyberpunkGrimmTxt = false;
                        RaisePropertyChanged("MountainGrimTxt");
                        RaisePropertyChanged("CyberpunkGrimmTxt");
                        SettingsClass.MountainGrimTxt = false;
                        SettingsClass.CyberpunkGrimmTxt = false;
                    }
                }
            }
        }
        
        //16 - BK***********************************************************

        private bool _bKSkin;

        public bool BKSkin
        {
            get { return _bKSkin; }
            set
            {
                if (_bKSkin != value)
                {
                    _bKSkin = value;
                    SettingsClass.BKSkin = _bKSkin;
                    RaisePropertyChanged("BKSkin");
                    if (_bKSkin)
                    {
                        _bKCJTxt = false;
                        RaisePropertyChanged("BKCJTxt");
                        SettingsClass.BKCJTxt = false;
                    }
                }
            }
        }

        private bool _bKCJTxt;

        public bool BKCJTxt
        {
            get { return _bKCJTxt; }
            set
            {
                if (_bKCJTxt != value)
                {
                    _bKCJTxt = value;
                    SettingsClass.BKCJTxt = _bKCJTxt;
                    RaisePropertyChanged("BKCJTxt");
                    if (_bKCJTxt)
                    {
                        _bKSkin = false;
                        RaisePropertyChanged("BKSkin");
                        SettingsClass.BKSkin = false;
                    }
                }
            }
        }
        //17 - Grave Digga'*************************************************

        private bool _graveDiggaSkin;

        public bool GraveDiggaSkin
        {
            get { return _graveDiggaSkin; }
            set
            {
                if (_graveDiggaSkin != value)
                {
                    _graveDiggaSkin = value;
                    SettingsClass.GraveDiggaSkin = _graveDiggaSkin;
                    RaisePropertyChanged("GraveDiggaSkin");
                    if (_graveDiggaSkin)
                    {
                        _graveDiggaSkin2 = false;
                        RaisePropertyChanged("GraveDiggaSkin2");
                        SettingsClass.GraveDiggaSkin2 = false;
                    }
                }
            }
        }
        private bool _graveDiggaSkin2;

        public bool GraveDiggaSkin2
        {
            get { return _graveDiggaSkin2; }
            set
            {
                if (_graveDiggaSkin2 != value)
                {
                    _graveDiggaSkin2 = value;
                    SettingsClass.GraveDiggaSkin2 = _graveDiggaSkin2;
                    RaisePropertyChanged("GraveDiggaSkin2");
                    if (_graveDiggaSkin2)
                    {
                        _graveDiggaSkin = false;
                        RaisePropertyChanged("GraveDiggaSkin");
                        SettingsClass.GraveDiggaSkin = false;
                    }
                }
            }
        }
        //18 - Bones********************************************************

        private bool _bonesSkin;

        public bool BonesSkin
        {
            get { return _bonesSkin; }
            set
            {
                if (_bonesSkin != value)
                {
                    _bonesSkin = value;
                    SettingsClass.BonesSkin = _bonesSkin;
                    RaisePropertyChanged("BonesSkin");
                    if (_bonesSkin)
                    {
                        _hoboBonesTxt = false;
                        _santaBonesTxt = false;
                        RaisePropertyChanged("HoboBonesTxt");
                        RaisePropertyChanged("SantaBonesTxt");
                        SettingsClass.HoboBonesTxt = false;
                        SettingsClass.SantaBonesTxt = false;
                    }
                }
            }
        }

        private bool _hoboBonesTxt;

        public bool HoboBonesTxt
        {
            get { return _hoboBonesTxt; }
            set
            {
                if (_hoboBonesTxt != value)
                {
                    _hoboBonesTxt = value;
                    SettingsClass.HoboBonesTxt = _hoboBonesTxt;
                    RaisePropertyChanged("HoboBonesTxt");
                    if (_hoboBonesTxt)
                    {
                        _bonesSkin = false;
                        _santaBonesTxt = false;
                        RaisePropertyChanged("BonesSkin");
                        RaisePropertyChanged("SantaBonesTxt");
                        SettingsClass.BonesSkin = false;
                        SettingsClass.SantaBonesTxt = false;
                    }
                }
            }
        }

        private bool _santaBonesTxt;

        public bool SantaBonesTxt
        {
            get { return _santaBonesTxt; }
            set
            {
                if (_santaBonesTxt != value)
                {
                    _santaBonesTxt = value;
                    SettingsClass.SantaBonesTxt = _santaBonesTxt;
                    RaisePropertyChanged("SantaBonesTxt");
                    if (_santaBonesTxt)
                    {
                        _bonesSkin = false;
                        _hoboBonesTxt = false;
                        RaisePropertyChanged("BonesSkin");
                        RaisePropertyChanged("HoboBonesTxt");
                        SettingsClass.BonesSkin = false;
                        SettingsClass.HoboBonesTxt = false;
                    }
                }
            }
        }
        //19 - Booma********************************************************

        private bool _boomaSurgeonTxt;

        public bool BoomaSurgeonTxt
        {
            get { return _boomaSurgeonTxt; }
            set
            {
                if (_boomaSurgeonTxt != value)
                {
                    _boomaSurgeonTxt = value;
                    SettingsClass.BoomaSurgeonTxt = _boomaSurgeonTxt;
                    RaisePropertyChanged("BoomaSurgeonTxt");
                    if (_boomaSurgeonTxt)
                    {
                        _boomaSkin2 = false;
                        RaisePropertyChanged("BoomaSkin2");
                        SettingsClass.BoomaSkin2 = false;
                    }
                }
            }
        }
        private bool _boomaSkin2;

        public bool BoomaSkin2
        {
            get { return _boomaSkin2; }
            set
            {
                if (_boomaSkin2 != value)
                {
                    _boomaSkin2 = value;
                    SettingsClass.BoomaSkin2 = _boomaSkin2;
                    RaisePropertyChanged("BoomaSkin2");
                    if (_boomaSkin2)
                    {
                        _boomaSurgeonTxt = false;
                        RaisePropertyChanged("BoomaSurgeonTxt");
                        SettingsClass.BoomaSurgeonTxt = false;
                    }
                }
            }
        }
        //1A - Busta********************************************************

        private bool _bustaSkin;

        public bool BustaSkin
        {
            get { return _bustaSkin; }
            set
            {
                if (_bustaSkin != value)
                {
                    _bustaSkin = value;
                    SettingsClass.BustaSkin = _bustaSkin;
                    RaisePropertyChanged("BustaSkin");
                    if (_bustaSkin)
                    {
                        _bustaSkin2 = false;
                        RaisePropertyChanged("BustaSkin2");
                        SettingsClass.BustaSkin2 = false;
                    }
                }
            }
        }

        private bool _bustaSkin2;

        public bool BustaSkin2
        {
            get { return _bustaSkin2; }
            set
            {
                if (_bustaSkin2 != value)
                {
                    _bustaSkin2 = value;
                    SettingsClass.BustaSkin2 = _bustaSkin2;
                    RaisePropertyChanged("BustaSkin2");
                    if (_bustaSkin2)
                    {
                        _bustaSkin = false;
                        RaisePropertyChanged("BustaSkin");
                        SettingsClass.BustaSkin = false;
                    }
                }
            }
        }
        //1B - Spider*******************************************************

        private bool _spiderSkin;

        public bool SpiderSkin
        {
            get { return _spiderSkin; }
            set
            {
                if (_spiderSkin != value)
                {
                    _spiderSkin = value;
                    SettingsClass.SpiderSkin = _spiderSkin;
                    RaisePropertyChanged("SpiderSkin");
                    if (_spiderSkin)
                    {
                        _spiderSkin2 = false;
                        RaisePropertyChanged("SpiderSkin2");
                        SettingsClass.SpiderSkin2 = false;
                    }
                }
            }
        }
        private bool _spiderSkin2;

        public bool SpiderSkin2
        {
            get { return _spiderSkin2; }
            set
            {
                if (_spiderSkin2 != value)
                {
                    _spiderSkin2 = value;
                    SettingsClass.SpiderSkin2 = _spiderSkin2;
                    RaisePropertyChanged("SpiderSkin2");
                    if (_spiderSkin2)
                    {
                        _spiderSkin = false;
                        RaisePropertyChanged("SpiderSkin");
                        SettingsClass.SpiderSkin = false;
                    }
                }
            }
        }
        //1C - Pain Killah**************************************************

        private bool _painKillahSkin;

        public bool PainKillahSkin
        {
            get { return _painKillahSkin; }
            set
            {
                if (_painKillahSkin != value)
                {
                    _painKillahSkin = value;
                    SettingsClass.PainKillahSkin = _painKillahSkin;
                    RaisePropertyChanged("PainKillahSkin");
                    if (_painKillahSkin)
                    {
                        _painKillahSkin2 = false;
                        RaisePropertyChanged("PainKillahSkin2");
                        SettingsClass.PainKillahSkin2 = false;
                    }
                }
            }
        }
        private bool _painKillahSkin2;

        public bool PainKillahSkin2
        {
            get { return _painKillahSkin2; }
            set
            {
                if (_painKillahSkin2 != value)
                {
                    _painKillahSkin2 = value;
                    SettingsClass.PainKillahSkin2 = _painKillahSkin2;
                    RaisePropertyChanged("PainKillahSkin2");
                    if (_painKillahSkin2)
                    {
                        _painKillahSkin = false;
                        RaisePropertyChanged("PainKillahSkin");
                        SettingsClass.PainKillahSkin = false;
                    }
                }
            }
        }
        //1E - Dwayne*******************************************************

        private bool _dwayneSkin;

        public bool DwayneSkin
        {
            get { return _dwayneSkin; }
            set
            {
                if (_dwayneSkin != value)
                {
                    _dwayneSkin = value;
                    SettingsClass.DwayneSkin = _dwayneSkin;
                    RaisePropertyChanged("DwayneSkin");
                    if (_dwayneSkin)
                    {
                        _cyberDwayneTxt = false;
                        RaisePropertyChanged("CyberDwayneTxt");
                        SettingsClass.CyberDwayneTxt = false;
                    }
                }
            }
        }

        private bool _cyberDwayneTxt;

        public bool CyberDwayneTxt
        {
            get { return _cyberDwayneTxt; }
            set
            {
                if (_cyberDwayneTxt != value)
                {
                    _cyberDwayneTxt = value;
                    SettingsClass.CyberDwayneTxt = _cyberDwayneTxt;
                    RaisePropertyChanged("CyberDwayneTxt");
                    if (_cyberDwayneTxt)
                    {
                        _dwayneSkin = false;
                        RaisePropertyChanged("DwayneSkin");
                        SettingsClass.DwayneSkin = false;
                    }
                }
            }
        }
        //1F - Shun Ying Lee************************************************

        private bool _fashionShunYingTxt;

        public bool FashionShunYingTxt
        {
            get { return _fashionShunYingTxt; }
            set
            {
                if (_fashionShunYingTxt != value)
                {
                    _fashionShunYingTxt = value;
                    SettingsClass.FashionShunYingTxt = _fashionShunYingTxt;
                    RaisePropertyChanged("FashionShunYingTxt");
                    if (_fashionShunYingTxt)
                    {
                        _ayaneShunYingTxt = false;
                        _shunYingV2Txt = false;
                        _evilShunYingTxt = false;
                        RaisePropertyChanged("AyaneShunYingTxt");
                        RaisePropertyChanged("ShunYingV2Txt");
                        RaisePropertyChanged("EvilShunYingTxt");
                        SettingsClass.AyaneShunYingTxt = false;
                        SettingsClass.ShunYingV2Txt = false;
                        SettingsClass.EvilShunYingTxt = false;
                    }
                }
            }
        }

        private bool _ayaneShunYingTxt;

        public bool AyaneShunYingTxt
        {
            get { return _ayaneShunYingTxt; }
            set
            {
                if (_ayaneShunYingTxt != value)
                {
                    _ayaneShunYingTxt = value;
                    SettingsClass.AyaneShunYingTxt = _ayaneShunYingTxt;
                    RaisePropertyChanged("AyaneShunYingTxt");
                    if (_ayaneShunYingTxt)
                    {
                        _fashionShunYingTxt = false;
                        _shunYingV2Txt = false;
                        _evilShunYingTxt = false;
                        RaisePropertyChanged("FashionShunYingTxt");
                        RaisePropertyChanged("ShunYingV2Txt");
                        RaisePropertyChanged("EvilShunYingTxt");
                        SettingsClass.FashionShunYingTxt = false;
                        SettingsClass.ShunYingV2Txt = false;
                        SettingsClass.EvilShunYingTxt = false;
                    }
                }
            }
        }

        private bool _shunYingV2Txt;

        public bool ShunYingV2Txt
        {
            get { return _shunYingV2Txt; }
            set
            {
                if (_shunYingV2Txt != value)
                {
                    _shunYingV2Txt = value;
                    SettingsClass.ShunYingV2Txt = _shunYingV2Txt;
                    RaisePropertyChanged("ShunYingV2Txt");
                    if (_shunYingV2Txt)
                    {
                        _fashionShunYingTxt = false;
                        _ayaneShunYingTxt = false;
                        _evilShunYingTxt = false;
                        RaisePropertyChanged("FashionShunYingTxt");
                        RaisePropertyChanged("AyaneShunYingTxt");
                        RaisePropertyChanged("EvilShunYingTxt");
                        SettingsClass.FashionShunYingTxt = false;
                        SettingsClass.AyaneShunYingTxt = false;
                        SettingsClass.EvilShunYingTxt = false;
                    }
                }
            }
        }

        private bool _evilShunYingTxt;

        public bool EvilShunYingTxt
        {
            get { return _evilShunYingTxt; }
            set
            {
                if (_evilShunYingTxt != value)
                {
                    _evilShunYingTxt = value;
                    SettingsClass.EvilShunYingTxt = _evilShunYingTxt;
                    RaisePropertyChanged("EvilShunYingTxt");
                    if (_evilShunYingTxt)
                    {
                        _fashionShunYingTxt = false;
                        _ayaneShunYingTxt = false;
                        _shunYingV2Txt = false;
                        RaisePropertyChanged("FashionShunYingTxt");
                        RaisePropertyChanged("AyaneShunYingTxt");
                        RaisePropertyChanged("ShunYingV2Txt");
                        SettingsClass.FashionShunYingTxt = false;
                        SettingsClass.AyaneShunYingTxt = false;
                        SettingsClass.ShunYingV2Txt = false;
                    }
                }
            }
        }
        //20 - GD 05********************************************************

        private bool _gD_04Txt;

        public bool GD_04Txt
        {
            get { return _gD_04Txt; }
            set
            {
                if (_gD_04Txt != value)
                {
                    _gD_04Txt = value;
                    SettingsClass.GD_04Txt = _gD_04Txt;
                    RaisePropertyChanged("GD_04Txt");
                    if (_gD_04Txt)
                    {
                        _gD_05Skin = false;
                        RaisePropertyChanged("GD_05Skin");
                        SettingsClass.GD_05Skin = false;
                    }
                }
            }
        }

        private bool _gD_05Skin;

        public bool GD_05Skin
        {
            get { return _gD_05Skin; }
            set
            {
                if (_gD_05Skin != value)
                {
                    _gD_05Skin = value;
                    SettingsClass.GD_05Skin = _gD_05Skin;
                    RaisePropertyChanged("GD_05Skin");
                    if (_gD_05Skin)
                    {
                        _gD_04Txt = false;
                        RaisePropertyChanged("GD_04Txt");
                        SettingsClass.GD_04Txt = false;
                    }
                }
            }
        }
        //21 - DR 88********************************************************

        private bool _dR88Skin;

        public bool DR88Skin
        {
            get { return _dR88Skin; }
            set
            {
                if (_dR88Skin != value)
                {
                    _dR88Skin = value;
                    SettingsClass.DR88Skin = _dR88Skin;
                    RaisePropertyChanged("DR88Skin");
                    if (_dR88Skin)
                    {
                        _golemFanboyTxt = false;
                        RaisePropertyChanged("GolemFanboyTxt");
                        SettingsClass.GolemFanboyTxt = false;
                    }
                }
            }
        }

        private bool _golemFanboyTxt;

        public bool GolemFanboyTxt
        {
            get { return _golemFanboyTxt; }
            set
            {
                if (_golemFanboyTxt != value)
                {
                    _golemFanboyTxt = value;
                    SettingsClass.GolemFanboyTxt = _golemFanboyTxt;
                    RaisePropertyChanged("GolemFanboyTxt");
                    if (_golemFanboyTxt)
                    {
                        _dR88Skin = false;
                        RaisePropertyChanged("DR88Skin");
                        SettingsClass.DR88Skin = false;
                    }
                }
            }
        }
        //22 - FK 71********************************************************

        private bool _bouncerFKTxt;

        public bool BouncerFKTxt
        {
            get { return _bouncerFKTxt; }
            set
            {
                if (_bouncerFKTxt != value)
                {
                    _bouncerFKTxt = value;
                    SettingsClass.BouncerFKTxt = _bouncerFKTxt;
                    RaisePropertyChanged("BouncerFKTxt");
                    if (_bouncerFKTxt)
                    {
                        _demonJinpachiTxt = false;
                        _halloweenFKTxt = false;
                        RaisePropertyChanged("DemonJinpachiTxt");
                        RaisePropertyChanged("HalloweenFKTxt");
                        SettingsClass.DemonJinpachiTxt = false;
                        SettingsClass.HalloweenFKTxt = false;
                    }
                }
            }
        }

        private bool _demonJinpachiTxt;

        public bool DemonJinpachiTxt
        {
            get { return _demonJinpachiTxt; }
            set
            {
                if (_demonJinpachiTxt != value)
                {
                    _demonJinpachiTxt = value;
                    SettingsClass.DemonJinpachiTxt = _demonJinpachiTxt;
                    RaisePropertyChanged("DemonJinpachiTxt");
                    if (_demonJinpachiTxt)
                    {
                        _bouncerFKTxt = false;
                        _halloweenFKTxt = false;
                        RaisePropertyChanged("BouncerFKTxt");
                        RaisePropertyChanged("HalloweenFKTxt");
                        SettingsClass.BouncerFKTxt = false;
                        SettingsClass.HalloweenFKTxt = false;
                    }
                }
            }
        }

        private bool _halloweenFKTxt;

        public bool HalloweenFKTxt
        {
            get { return _halloweenFKTxt; }
            set
            {
                if (_halloweenFKTxt != value)
                {
                    _halloweenFKTxt = value;
                    SettingsClass.HalloweenFKTxt = _halloweenFKTxt;
                    RaisePropertyChanged("HalloweenFKTxt");
                    if (_halloweenFKTxt)
                    {
                        _bouncerFKTxt = false;
                        _demonJinpachiTxt = false;
                        RaisePropertyChanged("BouncerFKTxt");
                        RaisePropertyChanged("DemonJinpachiTxt");
                        SettingsClass.BouncerFKTxt = false;
                        SettingsClass.DemonJinpachiTxt = false;
                    }
                }
            }
        }
        //23 - PT 22********************************************************

        private bool _pT22Skin;

        public bool PT22Skin
        {
            get { return _pT22Skin; }
            set
            {
                if (_pT22Skin != value)
                {
                    _pT22Skin = value;
                    SettingsClass.PT22Skin = _pT22Skin;
                    RaisePropertyChanged("PT22Skin");
                    if (_pT22Skin)
                    {
                        _putaTxt = false;
                        _pepsimanTxt = false;
                        RaisePropertyChanged("PutaTxt");
                        RaisePropertyChanged("PepsimanTxt");
                        SettingsClass.PutaTxt = false;
                        SettingsClass.PepsimanTxt = false;
                    }
                }
            }
        }

        private bool _putaTxt;

        public bool PutaTxt
        {
            get { return _putaTxt; }
            set
            {
                if (_putaTxt != value)
                {
                    _putaTxt = value;
                    SettingsClass.PutaTxt = _putaTxt;
                    RaisePropertyChanged("PutaTxt");
                    if (_putaTxt)
                    {
                        _pT22Skin = false;
                        _pepsimanTxt = false;
                        RaisePropertyChanged("PT22Skin");
                        RaisePropertyChanged("PepsimanTxt");
                        SettingsClass.PT22Skin = false;
                        SettingsClass.PepsimanTxt = false;
                    }
                }
            }
        }

        private bool _pepsimanTxt;

        public bool PepsimanTxt
        {
            get { return _pepsimanTxt; }
            set
            {
                if (_pepsimanTxt != value)
                {
                    _pepsimanTxt = value;
                    SettingsClass.PepsimanTxt = _pepsimanTxt;
                    RaisePropertyChanged("PepsimanTxt");
                    if (_pepsimanTxt)
                    {
                        _pT22Skin = false;
                        _putaTxt = false;
                        RaisePropertyChanged("PT22Skin");
                        RaisePropertyChanged("PutaTxt");
                        SettingsClass.PT22Skin = false;
                        SettingsClass.PutaTxt = false;
                    }
                }
            }
        }


        //24 - Bain*********************************************************

        private bool _bainSkin;

        public bool BainSkin
        {
            get { return _bainSkin; }
            set
            {
                if (_bainSkin != value)
                {
                    _bainSkin = value;
                    SettingsClass.BainSkin = _bainSkin;
                    RaisePropertyChanged("BainSkin");
                    if (_bainSkin)
                    {
                        _skeletonBoyTxt = false;
                        RaisePropertyChanged("SkeletonBoyTxt");
                        SettingsClass.SkeletonBoyTxt = false;
                    }
                }
            }
        }

        private bool _skeletonBoyTxt;

        public bool SkeletonBoyTxt
        {
            get { return _skeletonBoyTxt; }
            set
            {
                if (_skeletonBoyTxt != value)
                {
                    _skeletonBoyTxt = value;
                    SettingsClass.SkeletonBoyTxt = _skeletonBoyTxt;
                    RaisePropertyChanged("SkeletonBoyTxt");
                    if (_skeletonBoyTxt)
                    {
                        _bainSkin = false;
                        RaisePropertyChanged("BainSkin");
                        SettingsClass.BainSkin = false;
                    }
                }
            }
        }
        //25 - Cooper*******************************************************

        private bool _cooperSkin;

        public bool CooperSkin
        {
            get { return _cooperSkin; }
            set
            {
                if (_cooperSkin != value)
                {
                    _cooperSkin = value;
                    SettingsClass.CooperSkin = _cooperSkin;
                    RaisePropertyChanged("CooperSkin");
                    if (_cooperSkin)
                    {
                        _cooperSkin2 = false;
                        RaisePropertyChanged("CooperSkin2");
                        SettingsClass.CooperSkin2 = false;
                    }
                }
            }
        }
        private bool _cooperSkin2;

        public bool CooperSkin2
        {
            get { return _cooperSkin2; }
            set
            {
                if (_cooperSkin2 != value)
                {
                    _cooperSkin2 = value;
                    SettingsClass.CooperSkin2 = _cooperSkin2;
                    RaisePropertyChanged("CooperSkin2");
                    if (_cooperSkin2)
                    {
                        _cooperSkin = false;
                        RaisePropertyChanged("CooperSkin");
                        SettingsClass.CooperSkin = false;
                    }
                }
            }
        }
        //26 - Anderson*****************************************************

        private bool _suspectTxt;

        public bool SuspectTxt
        {
            get { return _suspectTxt; }
            set
            {
                if (_suspectTxt != value)
                {
                    _suspectTxt = value;
                    SettingsClass.SuspectTxt = _suspectTxt;
                    RaisePropertyChanged("SuspectTxt");
                    if (_suspectTxt)
                    {
                        _andersonSkin = false;
                        RaisePropertyChanged("AndersonSkin");
                        SettingsClass.AndersonSkin = false;
                    }
                }
            }
        }

        private bool _andersonSkin;

        public bool AndersonSkin
        {
            get { return _andersonSkin; }
            set
            {
                if (_andersonSkin != value)
                {
                    _andersonSkin = value;
                    SettingsClass.AndersonSkin = _andersonSkin;
                    RaisePropertyChanged("AndersonSkin");
                    if (_andersonSkin)
                    {
                        _suspectTxt = false;
                        RaisePropertyChanged("SuspectTxt");
                        SettingsClass.SuspectTxt = false;
                    }
                }
            }
        }
        //27 - Taylor*******************************************************

        private bool _taylorSkin;

        public bool TaylorSkin
        {
            get { return _taylorSkin; }
            set
            {
                if (_taylorSkin != value)
                {
                    _taylorSkin = value;
                    SettingsClass.TaylorSkin = _taylorSkin;
                    RaisePropertyChanged("TaylorSkin");
                    if (_taylorSkin)
                    {
                        _taylorSkin2 = false;
                        RaisePropertyChanged("TaylorSkin2");
                        SettingsClass.TaylorSkin2 = false;
                    }
                }
            }
        }
        private bool _taylorSkin2;

        public bool TaylorSkin2
        {
            get { return _taylorSkin2; }
            set
            {
                if (_taylorSkin2 != value)
                {
                    _taylorSkin2 = value;
                    SettingsClass.TaylorSkin2 = _taylorSkin2;
                    RaisePropertyChanged("TaylorSkin2");
                    if (_taylorSkin2)
                    {
                        _taylorSkin = false;
                        RaisePropertyChanged("TaylorSkin");
                        SettingsClass.TaylorSkin = false;
                    }
                }
            }
        }
        //28 - Chris********************************************************

        private bool _aristocratChrisTxt;

        public bool AristocratChrisTxt
        {
            get { return _aristocratChrisTxt; }
            set
            {
                if (_aristocratChrisTxt != value)
                {
                    _aristocratChrisTxt = value;
                    SettingsClass.AristocratChrisTxt = _aristocratChrisTxt;
                    RaisePropertyChanged("AristocratChrisTxt");
                    if (_aristocratChrisTxt)
                    {
                        _chrisSkin2 = false;
                        _eddyTrainerTxt = false;
                        RaisePropertyChanged("ChrisSkin2");
                        RaisePropertyChanged("EddyTrainerTxt");
                        SettingsClass.ChrisSkin2 = false;
                        SettingsClass.EddyTrainerTxt = false;
                    }
                }
            }
        }
        private bool _chrisSkin2;

        public bool ChrisSkin2
        {
            get { return _chrisSkin2; }
            set
            {
                if (_chrisSkin2 != value)
                {
                    _chrisSkin2 = value;
                    SettingsClass.ChrisSkin2 = _chrisSkin2;
                    RaisePropertyChanged("ChrisSkin2");
                    if (_chrisSkin2)
                    {
                        _aristocratChrisTxt = false;
                        _eddyTrainerTxt = false;
                        RaisePropertyChanged("AristocratChrisTxt");
                        RaisePropertyChanged("EddyTrainerTxt");
                        SettingsClass.AristocratChrisTxt = false;
                        SettingsClass.EddyTrainerTxt = false;
                    }
                }
            }
        }
        private bool _eddyTrainerTxt;

        public bool EddyTrainerTxt
        {
            get { return _eddyTrainerTxt; }
            set
            {
                if (_eddyTrainerTxt != value)
                {
                    _eddyTrainerTxt = value;
                    SettingsClass.EddyTrainerTxt = _eddyTrainerTxt;
                    RaisePropertyChanged("EddyTrainerTxt");
                    if (_eddyTrainerTxt)
                    {
                        _aristocratChrisTxt = false;
                        _chrisSkin2 = false;
                        RaisePropertyChanged("AristocratChrisTxt");
                        RaisePropertyChanged("ChrisSkin2");
                        SettingsClass.AristocratChrisTxt = false;
                        SettingsClass.ChrisSkin2 = false;
                    }
                }
            }
        }

        
        //29 - Park*********************************************************

        private bool _alternativeParkTxt;

        public bool AlternativeParkTxt
        {
            get { return _alternativeParkTxt; }
            set
            {
                if (_alternativeParkTxt != value)
                {
                    _alternativeParkTxt = value;
                    SettingsClass.AlternativeParkTxt = _alternativeParkTxt;
                    RaisePropertyChanged("AlternativeParkTxt");
                    if (_alternativeParkTxt)
                    {
                        _parkDanteTxt = false;
                        _symbioteSpiderTxt = false;
                        RaisePropertyChanged("ParkDanteTxt");
                        RaisePropertyChanged("SymbioteSpiderTxt");
                        SettingsClass.ParkDanteTxt = false;
                        SettingsClass.SymbioteSpiderTxt = false;
                    }
                }
            }
        }

        private bool _parkDanteTxt;

        public bool ParkDanteTxt
        {
            get { return _parkDanteTxt; }
            set
            {
                if (_parkDanteTxt != value)
                {
                    _parkDanteTxt = value;
                    SettingsClass.ParkDanteTxt = _parkDanteTxt;
                    RaisePropertyChanged("ParkDanteTxt");
                    if (_parkDanteTxt)
                    {
                        _alternativeParkTxt = false;
                        _symbioteSpiderTxt = false;
                        RaisePropertyChanged("AlternativeParkTxt");
                        RaisePropertyChanged("SymbioteSpiderTxt");
                        SettingsClass.AlternativeParkTxt = false;
                        SettingsClass.SymbioteSpiderTxt = false;
                    }
                }
            }
        }

        private bool _symbioteSpiderTxt;

        public bool SymbioteSpiderTxt
        {
            get { return _symbioteSpiderTxt; }
            set
            {
                if (_symbioteSpiderTxt != value)
                {
                    _symbioteSpiderTxt = value;
                    SettingsClass.SymbioteSpiderTxt = _symbioteSpiderTxt;
                    RaisePropertyChanged("SymbioteSpiderTxt");
                    if (_symbioteSpiderTxt)
                    {
                        _alternativeParkTxt = false;
                        _parkDanteTxt = false;
                        RaisePropertyChanged("AlternativeParkTxt");
                        RaisePropertyChanged("ParkDanteTxt");
                        SettingsClass.AlternativeParkTxt = false;
                        SettingsClass.ParkDanteTxt = false;
                    }
                }
            }
        }
        //2A - Alex*********************************************************

        private bool _alexSkin;

        public bool AlexSkin
        {
            get { return _alexSkin; }
            set
            {
                if (_alexSkin != value)
                {
                    _alexSkin = value;
                    SettingsClass.AlexSkin = _alexSkin;
                    RaisePropertyChanged("AlexSkin");
                    if (_alexSkin)
                    {
                        _gangsterAlexTxt = false;
                        _vergilAlexTxt = false;
                        RaisePropertyChanged("GangsterAlexTxt");
                        RaisePropertyChanged("VergilAlexTxt");
                        SettingsClass.GangsterAlexTxt = false;
                        SettingsClass.VergilAlexTxt = false;
                    }
                }
            }
        }
        private bool _gangsterAlexTxt;

        public bool GangsterAlexTxt
        {
            get { return _gangsterAlexTxt; }
            set
            {
                if (_gangsterAlexTxt != value)
                {
                    _gangsterAlexTxt = value;
                    SettingsClass.GangsterAlexTxt = _gangsterAlexTxt;
                    RaisePropertyChanged("GangsterAlexTxt");
                    if (_gangsterAlexTxt)
                    {
                        _alexSkin = false;
                        _vergilAlexTxt = false;
                        RaisePropertyChanged("AlexSkin");
                        RaisePropertyChanged("VergilAlexTxt");
                        SettingsClass.AlexSkin = false;
                        SettingsClass.VergilAlexTxt = false;
                    }
                }
            }
        }
        private bool _vergilAlexTxt;

        public bool VergilAlexTxt
        {
            get { return _vergilAlexTxt; }
            set
            {
                if (_vergilAlexTxt != value)
                {
                    _vergilAlexTxt = value;
                    SettingsClass.VergilAlexTxt = _vergilAlexTxt;
                    RaisePropertyChanged("VergilAlexTxt");
                    if (_vergilAlexTxt)
                    {
                        _alexSkin = false;
                        _gangsterAlexTxt = false;
                        RaisePropertyChanged("AlexSkin");
                        RaisePropertyChanged("GangsterAlexTxt");
                        SettingsClass.AlexSkin = false;
                        SettingsClass.GangsterAlexTxt = false;
                    }
                }
            }
        }

        //2B - McKinzie*****************************************************

        private bool _mcKinzieSkin;

        public bool McKinzieSkin
        {
            get { return _mcKinzieSkin; }
            set
            {
                if (_mcKinzieSkin != value)
                {
                    _mcKinzieSkin = value;
                    SettingsClass.McKinzieSkin = _mcKinzieSkin;
                    RaisePropertyChanged("McKinzieSkin");
                    if (_mcKinzieSkin)
                    {
                        _terminatorMckinzieTxt = false;
                        _mcPunisherTxt = false;
                        RaisePropertyChanged("TerminatorMckinzieTxt");
                        RaisePropertyChanged("McPunisherTxt");
                        SettingsClass.TerminatorMckinzieTxt = false;
                        SettingsClass.McPunisherTxt = false;
                    }
                }
            }
        }

        private bool _terminatorMckinzieTxt;

        public bool TerminatorMckinzieTxt
        {
            get { return _terminatorMckinzieTxt; }
            set
            {
                if (_terminatorMckinzieTxt != value)
                {
                    _terminatorMckinzieTxt = value;
                    SettingsClass.TerminatorMckinzieTxt = _terminatorMckinzieTxt;
                    RaisePropertyChanged("TerminatorMckinzieTxt");
                    if (_terminatorMckinzieTxt)
                    {
                        _mcKinzieSkin = false;
                        _mcPunisherTxt = false;
                        RaisePropertyChanged("McKinzieSkin");
                        RaisePropertyChanged("McPunisherTxt");
                        SettingsClass.McKinzieSkin = false;
                        SettingsClass.McPunisherTxt = false;
                    }
                }
            }
        }

        private bool _mcPunisherTxt;

        public bool McPunisherTxt
        {
            get { return _mcPunisherTxt; }
            set
            {
                if (_mcPunisherTxt != value)
                {
                    _mcPunisherTxt = value;
                    SettingsClass.McPunisherTxt = _mcPunisherTxt;
                    RaisePropertyChanged("McPunisherTxt");
                    if (_mcPunisherTxt)
                    {
                        _mcKinzieSkin = false;
                        _terminatorMckinzieTxt = false;
                        RaisePropertyChanged("McKinzieSkin");
                        RaisePropertyChanged("TerminatorMckinzieTxt");
                        SettingsClass.McKinzieSkin = false;
                        SettingsClass.TerminatorMckinzieTxt = false;
                    }
                }
            }
        }
        //2C - Napalm 99****************************************************

        private bool _officerNapalm99Txt;

        public bool OfficerNapalm99Txt
        {
            get { return _officerNapalm99Txt; }
            set
            {
                if (_officerNapalm99Txt != value)
                {
                    _officerNapalm99Txt = value;
                    SettingsClass.OfficerNapalm99Txt = _officerNapalm99Txt;
                    RaisePropertyChanged("OfficerNapalm99Txt");
                    if (_officerNapalm99Txt)
                    {
                        _volcanicNapalmTxt = false;
                        _napumpin99Txt = false;
                        RaisePropertyChanged("VolcanicNapalmTxt");
                        RaisePropertyChanged("Napumpin99Txt");
                        SettingsClass.VolcanicNapalmTxt = false;
                        SettingsClass.Napumpin99Txt = false;
                    }
                }
            }
        }

        private bool _volcanicNapalmTxt;

        public bool VolcanicNapalmTxt
        {
            get { return _volcanicNapalmTxt; }
            set
            {
                if (_volcanicNapalmTxt != value)
                {
                    _volcanicNapalmTxt = value;
                    SettingsClass.VolcanicNapalmTxt = _volcanicNapalmTxt;
                    RaisePropertyChanged("VolcanicNapalmTxt");
                    if (_volcanicNapalmTxt)
                    {
                        _officerNapalm99Txt = false;
                        _napumpin99Txt = false;
                        RaisePropertyChanged("OfficerNapalm99Txt");
                        RaisePropertyChanged("Napumpin99Txt");
                        SettingsClass.OfficerNapalm99Txt = false;
                        SettingsClass.Napumpin99Txt = false;
                    }
                }
            }
        }

        private bool _napumpin99Txt;

        public bool Napumpin99Txt
        {
            get { return _napumpin99Txt; }
            set
            {
                if (_napumpin99Txt != value)
                {
                    _napumpin99Txt = value;
                    SettingsClass.Napumpin99Txt = _napumpin99Txt;
                    RaisePropertyChanged("Napumpin99Txt");
                    if (_napumpin99Txt)
                    {
                        _officerNapalm99Txt = false;
                        _volcanicNapalmTxt = false;
                        RaisePropertyChanged("OfficerNapalm99Txt");
                        RaisePropertyChanged("VolcanicNapalmTxt");
                        SettingsClass.OfficerNapalm99Txt = false;
                        SettingsClass.VolcanicNapalmTxt = false;
                    }
                }
            }
        }
        //2D - Golem********************************************************

        private bool _golemTuxedoTxt;

        public bool GolemTuxedoTxt
        {
            get { return _golemTuxedoTxt; }
            set
            {
                if (_golemTuxedoTxt != value)
                {
                    _golemTuxedoTxt = value;
                    SettingsClass.GolemTuxedoTxt = _golemTuxedoTxt;
                    RaisePropertyChanged("GolemTuxedoTxt");
                    if (_golemTuxedoTxt)
                    {
                        _golemShirtlessTxt = false;
                        _nightmareTxt = false;
                        _grolemTxt = false;
                        _golemKratosTxt = false;
                        _subzeroGolemTxt = false;
                        _monsterEnergyGolemTxt = false;
                        _golemusTxt = false;
                        _brademTxt = false;
                        _beachGolemTxt = false;
                        RaisePropertyChanged("GolemShirtlessTxt");
                        RaisePropertyChanged("NightmareTxt");
                        RaisePropertyChanged("GrolemTxt");
                        RaisePropertyChanged("GolemKratosTxt");
                        RaisePropertyChanged("SubzeroGolemTxt");
                        RaisePropertyChanged("MonsterEnergyGolemTxt");
                        RaisePropertyChanged("GolemusTxt");
                        RaisePropertyChanged("BrademTxt");
                        RaisePropertyChanged("BeachGolemTxt");
                        SettingsClass.GolemShirtlessTxt = false;
                        SettingsClass.NightmareTxt = false;
                        SettingsClass.GrolemTxt = false;
                        SettingsClass.GolemKratosTxt = false;
                        SettingsClass.SubzeroGolemTxt = false;
                        SettingsClass.MonsterEnergyGolemTxt = false;
                        SettingsClass.GolemusTxt = false;
                        SettingsClass.BrademTxt = false;
                        SettingsClass.BeachGolemTxt = false;
                    }
                }
            }
        }

        private bool _golemShirtlessTxt;

        public bool GolemShirtlessTxt
        {
            get { return _golemShirtlessTxt; }
            set
            {
                if (_golemShirtlessTxt != value)
                {
                    _golemShirtlessTxt = value;
                    SettingsClass.GolemShirtlessTxt = _golemShirtlessTxt;
                    RaisePropertyChanged("GolemShirtlessTxt");
                    if (_golemShirtlessTxt)
                    {
                        _golemTuxedoTxt = false;
                        _nightmareTxt = false;
                        _grolemTxt = false;
                        _golemKratosTxt = false;
                        _subzeroGolemTxt = false;
                        _monsterEnergyGolemTxt = false;
                        _golemusTxt = false;
                        _brademTxt = false;
                        _beachGolemTxt = false;
                        RaisePropertyChanged("GolemTuxedoTxt");
                        RaisePropertyChanged("NightmareTxt");
                        RaisePropertyChanged("GrolemTxt");
                        RaisePropertyChanged("GolemKratosTxt");
                        RaisePropertyChanged("SubzeroGolemTxt");
                        RaisePropertyChanged("MonsterEnergyGolemTxt");
                        RaisePropertyChanged("GolemusTxt");
                        RaisePropertyChanged("BrademTxt");
                        RaisePropertyChanged("BeachGolemTxt");
                        SettingsClass.GolemTuxedoTxt = false;
                        SettingsClass.NightmareTxt = false;
                        SettingsClass.GrolemTxt = false;
                        SettingsClass.GolemKratosTxt = false;
                        SettingsClass.SubzeroGolemTxt = false;
                        SettingsClass.MonsterEnergyGolemTxt = false;
                        SettingsClass.GolemusTxt = false;
                        SettingsClass.BrademTxt = false;
                        SettingsClass.BeachGolemTxt = false;
                    }
                }
            }
        }

        private bool _nightmareTxt;

        public bool NightmareTxt
        {
            get { return _nightmareTxt; }
            set
            {
                if (_nightmareTxt != value)
                {
                    _nightmareTxt = value;
                    SettingsClass.NightmareTxt = _nightmareTxt;
                    RaisePropertyChanged("NightmareTxt");
                    if (_nightmareTxt)
                    {
                        _golemTuxedoTxt = false;
                        _golemShirtlessTxt = false;
                        _grolemTxt = false;
                        _golemKratosTxt = false;
                        _subzeroGolemTxt = false;
                        _monsterEnergyGolemTxt = false;
                        _golemusTxt = false;
                        _brademTxt = false;
                        _beachGolemTxt = false;
                        RaisePropertyChanged("GolemTuxedoTxt");
                        RaisePropertyChanged("GolemShirtlessTxt");
                        RaisePropertyChanged("GrolemTxt");
                        RaisePropertyChanged("GolemKratosTxt");
                        RaisePropertyChanged("SubzeroGolemTxt");
                        RaisePropertyChanged("MonsterEnergyGolemTxt");
                        RaisePropertyChanged("GolemusTxt");
                        RaisePropertyChanged("BrademTxt");
                        RaisePropertyChanged("BeachGolemTxt");
                        SettingsClass.GolemTuxedoTxt = false;
                        SettingsClass.GolemShirtlessTxt = false;
                        SettingsClass.GrolemTxt = false;
                        SettingsClass.GolemKratosTxt = false;
                        SettingsClass.SubzeroGolemTxt = false;
                        SettingsClass.MonsterEnergyGolemTxt = false;
                        SettingsClass.GolemusTxt = false;
                        SettingsClass.BrademTxt = false;
                        SettingsClass.BeachGolemTxt = false;
                    }
                }
            }
        }

        private bool _grolemTxt;

        public bool GrolemTxt
        {
            get { return _grolemTxt; }
            set
            {
                if (_grolemTxt != value)
                {
                    _grolemTxt = value;
                    SettingsClass.GrolemTxt = _grolemTxt;
                    RaisePropertyChanged("GrolemTxt");
                    if (_grolemTxt)
                    {
                        _golemTuxedoTxt = false;
                        _golemShirtlessTxt = false;
                        _nightmareTxt = false;
                        _golemKratosTxt = false;
                        _subzeroGolemTxt = false;
                        _monsterEnergyGolemTxt = false;
                        _golemusTxt = false;
                        _brademTxt = false;
                        _beachGolemTxt = false;
                        RaisePropertyChanged("GolemTuxedoTxt");
                        RaisePropertyChanged("GolemShirtlessTxt");
                        RaisePropertyChanged("NightmareTxt");
                        RaisePropertyChanged("GolemKratosTxt");
                        RaisePropertyChanged("SubzeroGolemTxt");
                        RaisePropertyChanged("MonsterEnergyGolemTxt");
                        RaisePropertyChanged("GolemusTxt");
                        RaisePropertyChanged("BrademTxt");
                        RaisePropertyChanged("BeachGolemTxt");
                        SettingsClass.GolemTuxedoTxt = false;
                        SettingsClass.GolemShirtlessTxt = false;
                        SettingsClass.NightmareTxt = false;
                        SettingsClass.GolemKratosTxt = false;
                        SettingsClass.SubzeroGolemTxt = false;
                        SettingsClass.MonsterEnergyGolemTxt = false;
                        SettingsClass.GolemusTxt = false;
                        SettingsClass.BrademTxt = false;
                        SettingsClass.BeachGolemTxt = false;
                    }
                }
            }
        }

        private bool _golemKratosTxt;

        public bool GolemKratosTxt
        {
            get { return _golemKratosTxt; }
            set
            {
                if (_golemKratosTxt != value)
                {
                    _golemKratosTxt = value;
                    SettingsClass.GolemKratosTxt = _golemKratosTxt;
                    RaisePropertyChanged("GolemKratosTxt");
                    if (_golemKratosTxt)
                    {
                        _golemTuxedoTxt = false;
                        _golemShirtlessTxt = false;
                        _nightmareTxt = false;
                        _grolemTxt = false;
                        _subzeroGolemTxt = false;
                        _monsterEnergyGolemTxt = false;
                        _golemusTxt = false;
                        _brademTxt = false;
                        _beachGolemTxt = false;
                        RaisePropertyChanged("GolemTuxedoTxt");
                        RaisePropertyChanged("GolemShirtlessTxt");
                        RaisePropertyChanged("NightmareTxt");
                        RaisePropertyChanged("GrolemTxt");
                        RaisePropertyChanged("SubzeroGolemTxt");
                        RaisePropertyChanged("MonsterEnergyGolemTxt");
                        RaisePropertyChanged("GolemusTxt");
                        RaisePropertyChanged("BrademTxt");
                        RaisePropertyChanged("BeachGolemTxt");
                        SettingsClass.GolemTuxedoTxt = false;
                        SettingsClass.GolemShirtlessTxt = false;
                        SettingsClass.NightmareTxt = false;
                        SettingsClass.GrolemTxt = false;
                        SettingsClass.SubzeroGolemTxt = false;
                        SettingsClass.MonsterEnergyGolemTxt = false;
                        SettingsClass.GolemusTxt = false;
                        SettingsClass.BrademTxt = false;
                        SettingsClass.BeachGolemTxt = false;
                    }
                }
            }
        }


        private bool _subzeroGolemTxt;

        public bool SubzeroGolemTxt
        {
            get { return _subzeroGolemTxt; }
            set
            {
                if (_subzeroGolemTxt != value)
                {
                    _subzeroGolemTxt = value;
                    SettingsClass.SubzeroGolemTxt = _subzeroGolemTxt;
                    RaisePropertyChanged("SubzeroGolemTxt");
                    if (_subzeroGolemTxt)
                    {
                        _golemTuxedoTxt = false;
                        _golemShirtlessTxt = false;
                        _nightmareTxt = false;
                        _grolemTxt = false;
                        _golemKratosTxt = false;
                        _monsterEnergyGolemTxt = false;
                        _golemusTxt = false;
                        _brademTxt = false;
                        _beachGolemTxt = false;
                        RaisePropertyChanged("GolemTuxedoTxt");
                        RaisePropertyChanged("GolemShirtlessTxt");
                        RaisePropertyChanged("NightmareTxt");
                        RaisePropertyChanged("GrolemTxt");
                        RaisePropertyChanged("GolemKratosTxt");
                        RaisePropertyChanged("MonsterEnergyGolemTxt");
                        RaisePropertyChanged("GolemusTxt");
                        RaisePropertyChanged("BrademTxt");
                        RaisePropertyChanged("BeachGolemTxt");
                        SettingsClass.GolemTuxedoTxt = false;
                        SettingsClass.GolemShirtlessTxt = false;
                        SettingsClass.NightmareTxt = false;
                        SettingsClass.GrolemTxt = false;
                        SettingsClass.GolemKratosTxt = false;
                        SettingsClass.MonsterEnergyGolemTxt = false;
                        SettingsClass.GolemusTxt = false;
                        SettingsClass.BrademTxt = false;
                        SettingsClass.BeachGolemTxt = false;
                    }
                }
            }
        }

        private bool _monsterEnergyGolemTxt;

        public bool MonsterEnergyGolemTxt
        {
            get { return _monsterEnergyGolemTxt; }
            set
            {
                if (_monsterEnergyGolemTxt != value)
                {
                    _monsterEnergyGolemTxt = value;
                    SettingsClass.MonsterEnergyGolemTxt = _monsterEnergyGolemTxt;
                    RaisePropertyChanged("MonsterEnergyGolemTxt");
                    if (_monsterEnergyGolemTxt)
                    {
                        _golemTuxedoTxt = false;
                        _golemShirtlessTxt = false;
                        _nightmareTxt = false;
                        _grolemTxt = false;
                        _golemKratosTxt = false;
                        _subzeroGolemTxt = false;
                        _golemusTxt = false;
                        _brademTxt = false;
                        _beachGolemTxt = false;
                        RaisePropertyChanged("GolemTuxedoTxt");
                        RaisePropertyChanged("GolemShirtlessTxt");
                        RaisePropertyChanged("NightmareTxt");
                        RaisePropertyChanged("GrolemTxt");
                        RaisePropertyChanged("GolemKratosTxt");
                        RaisePropertyChanged("SubzeroGolemTxt");
                        RaisePropertyChanged("GolemusTxt");
                        RaisePropertyChanged("BrademTxt");
                        RaisePropertyChanged("BeachGolemTxt");
                        SettingsClass.GolemTuxedoTxt = false;
                        SettingsClass.GolemShirtlessTxt = false;
                        SettingsClass.NightmareTxt = false;
                        SettingsClass.GrolemTxt = false;
                        SettingsClass.GolemKratosTxt = false;
                        SettingsClass.SubzeroGolemTxt = false;
                        SettingsClass.GolemusTxt = false;
                        SettingsClass.BrademTxt = false;
                        SettingsClass.BeachGolemTxt = false;
                    }
                }
            }
        }

        private bool _golemusTxt;

        public bool GolemusTxt
        {
            get { return _golemusTxt; }
            set
            {
                if (_golemusTxt != value)
                {
                    _golemusTxt = value;
                    SettingsClass.GolemusTxt = _golemusTxt;
                    RaisePropertyChanged("GolemusTxt");
                    if (_golemusTxt)
                    {
                        _golemTuxedoTxt = false;
                        _golemShirtlessTxt = false;
                        _nightmareTxt = false;
                        _grolemTxt = false;
                        _golemKratosTxt = false;
                        _subzeroGolemTxt = false;
                        _monsterEnergyGolemTxt = false;
                        _brademTxt = false;
                        _beachGolemTxt = false;
                        RaisePropertyChanged("GolemTuxedoTxt");
                        RaisePropertyChanged("GolemShirtlessTxt");
                        RaisePropertyChanged("NightmareTxt");
                        RaisePropertyChanged("GrolemTxt");
                        RaisePropertyChanged("GolemKratosTxt");
                        RaisePropertyChanged("SubzeroGolemTxt");
                        RaisePropertyChanged("MonsterEnergyGolemTxt");
                        RaisePropertyChanged("BrademTxt");
                        RaisePropertyChanged("BeachGolemTxt");
                        SettingsClass.GolemTuxedoTxt = false;
                        SettingsClass.GolemShirtlessTxt = false;
                        SettingsClass.NightmareTxt = false;
                        SettingsClass.GrolemTxt = false;
                        SettingsClass.GolemKratosTxt = false;
                        SettingsClass.SubzeroGolemTxt = false;
                        SettingsClass.MonsterEnergyGolemTxt = false;
                        SettingsClass.BrademTxt = false;
                        SettingsClass.BeachGolemTxt = false;
                    }
                }
            }
        }

        private bool _brademTxt;

        public bool BrademTxt
        {
            get { return _brademTxt; }
            set
            {
                if (_brademTxt != value)
                {
                    _brademTxt = value;
                    SettingsClass.BrademTxt = _brademTxt;
                    RaisePropertyChanged("BrademTxt");
                    if (_brademTxt)
                    {
                        _golemTuxedoTxt = false;
                        _golemShirtlessTxt = false;
                        _nightmareTxt = false;
                        _grolemTxt = false;
                        _golemKratosTxt = false;
                        _subzeroGolemTxt = false;
                        _monsterEnergyGolemTxt = false;
                        _golemusTxt = false;
                        _beachGolemTxt = false;
                        RaisePropertyChanged("GolemTuxedoTxt");
                        RaisePropertyChanged("GolemShirtlessTxt");
                        RaisePropertyChanged("NightmareTxt");
                        RaisePropertyChanged("GrolemTxt");
                        RaisePropertyChanged("GolemKratosTxt");
                        RaisePropertyChanged("SubzeroGolemTxt");
                        RaisePropertyChanged("MonsterEnergyGolemTxt");
                        RaisePropertyChanged("GolemusTxt");
                        RaisePropertyChanged("BeachGolemTxt");
                        SettingsClass.GolemTuxedoTxt = false;
                        SettingsClass.GolemShirtlessTxt = false;
                        SettingsClass.NightmareTxt = false;
                        SettingsClass.GrolemTxt = false;
                        SettingsClass.GolemKratosTxt = false;
                        SettingsClass.SubzeroGolemTxt = false;
                        SettingsClass.MonsterEnergyGolemTxt = false;
                        SettingsClass.GolemusTxt = false;
                        SettingsClass.BeachGolemTxt = false;
                    }
                }
            }
        }

        private bool _beachGolemTxt;

        public bool BeachGolemTxt
        {
            get { return _beachGolemTxt; }
            set
            {
                if (_beachGolemTxt != value)
                {
                    _beachGolemTxt = value;
                    SettingsClass.BeachGolemTxt = _beachGolemTxt;
                    RaisePropertyChanged("BeachGolemTxt");
                    if (_beachGolemTxt)
                    {
                        _golemTuxedoTxt = false;
                        _golemShirtlessTxt = false;
                        _nightmareTxt = false;
                        _grolemTxt = false;
                        _golemKratosTxt = false;
                        _subzeroGolemTxt = false;
                        _monsterEnergyGolemTxt = false;
                        _golemusTxt = false;
                        _brademTxt = false;
                        RaisePropertyChanged("GolemTuxedoTxt");
                        RaisePropertyChanged("GolemShirtlessTxt");
                        RaisePropertyChanged("NightmareTxt");
                        RaisePropertyChanged("GrolemTxt");
                        RaisePropertyChanged("GolemKratosTxt");
                        RaisePropertyChanged("SubzeroGolemTxt");
                        RaisePropertyChanged("MonsterEnergyGolemTxt");
                        RaisePropertyChanged("GolemusTxt");
                        RaisePropertyChanged("BrademTxt");
                        SettingsClass.GolemTuxedoTxt = false;
                        SettingsClass.GolemShirtlessTxt = false;
                        SettingsClass.NightmareTxt = false;
                        SettingsClass.GrolemTxt = false;
                        SettingsClass.GolemKratosTxt = false;
                        SettingsClass.SubzeroGolemTxt = false;
                        SettingsClass.MonsterEnergyGolemTxt = false;
                        SettingsClass.GolemusTxt = false;
                        SettingsClass.BrademTxt = false;
                    }
                }
            }
        }

        //2E - Riki*********************************************************

        private bool _rikiSkin;

        public bool RikiSkin
        {
            get { return _rikiSkin; }
            set
            {
                if (_rikiSkin != value)
                {
                    _rikiSkin = value;
                    SettingsClass.RikiSkin = _rikiSkin;
                    RaisePropertyChanged("RikiSkin");
                    if (_rikiSkin)
                    {
                        _rikiSkin2 = false;
                        RaisePropertyChanged("RikiSkin2");
                        SettingsClass.RikiSkin2 = false;
                    }
                }
            }
        }
        private bool _rikiSkin2;

        public bool RikiSkin2
        {
            get { return _rikiSkin2; }
            set
            {
                if (_rikiSkin2 != value)
                {
                    _rikiSkin2 = value;
                    SettingsClass.RikiSkin = _rikiSkin2;
                    RaisePropertyChanged("RikiSkin2");
                    if (_rikiSkin2)
                    {
                        _rikiSkin = false;
                        RaisePropertyChanged("RikiSkin");
                        SettingsClass.RikiSkin = false;
                    }
                }
            }
        }
        //2F - Masa*********************************************************

        private bool _masaSkin;

        public bool MasaSkin
        {
            get { return _masaSkin; }
            set
            {
                if (_masaSkin != value)
                {
                    _masaSkin = value;
                    SettingsClass.MasaSkin = _masaSkin;
                    RaisePropertyChanged("MasaSkin");
                    if (_masaSkin)
                    {
                        _endangeredMasaTxt = false;
                        RaisePropertyChanged("EndangeredMasaTxt");
                        SettingsClass.EndangeredMasaTxt = false;
                    }
                }
            }
        }
        private bool _endangeredMasaTxt;

        public bool EndangeredMasaTxt
        {
            get { return _endangeredMasaTxt; }
            set
            {
                if (_endangeredMasaTxt != value)
                {
                    _endangeredMasaTxt = value;
                    SettingsClass.EndangeredMasaTxt = _endangeredMasaTxt;
                    RaisePropertyChanged("EndangeredMasaTxt");
                    if (_endangeredMasaTxt)
                    {
                        _masaSkin = false;
                        RaisePropertyChanged("MasaSkin");
                        SettingsClass.MasaSkin = false;
                    }
                }
            }
        }
        //30 - Hiro*********************************************************

        private bool _hiroSkin;

        public bool HiroSkin
        {
            get { return _hiroSkin; }
            set
            {
                if (_hiroSkin != value)
                {
                    _hiroSkin = value;
                    SettingsClass.HiroSkin = _hiroSkin;
                    RaisePropertyChanged("HiroSkin");
                    if (_hiroSkin)
                    {
                        _hiroGATTxt = false;
                        RaisePropertyChanged("HiroGATTxt");
                        SettingsClass.HiroGATTxt = false;
                    }
                }
            }
        }

        private bool _hiroGATTxt;

        public bool HiroGATTxt
        {
            get { return _hiroGATTxt; }
            set
            {
                if (_hiroGATTxt != value)
                {
                    _hiroGATTxt = value;
                    SettingsClass.HiroGATTxt = _hiroGATTxt;
                    RaisePropertyChanged("HiroGATTxt");
                    if (_hiroGATTxt)
                    {
                        _hiroSkin = false;
                        RaisePropertyChanged("HiroSkin");
                        SettingsClass.HiroSkin = false;
                    }
                }
            }
        }
        //31 - Ryuji********************************************************

        private bool _ryujiSkin;

        public bool RyujiSkin
        {
            get { return _ryujiSkin; }
            set
            {
                if (_ryujiSkin != value)
                {
                    _ryujiSkin = value;
                    SettingsClass.RyujiSkin = _ryujiSkin;
                    RaisePropertyChanged("RyujiSkin");
                    if (_ryujiSkin)
                    {
                        _ryujiSkin2 = false;
                        RaisePropertyChanged("RyujiSkin2");
                        SettingsClass.RyujiSkin2 = false;
                    }
                }
            }
        }
        private bool _ryujiSkin2;

        public bool RyujiSkin2
        {
            get { return _ryujiSkin2; }
            set
            {
                if (_ryujiSkin2 != value)
                {
                    _ryujiSkin2 = value;
                    SettingsClass.RyujiSkin2 = _ryujiSkin2;
                    RaisePropertyChanged("RyujiSkin2");
                    if (_ryujiSkin2)
                    {
                        _ryujiSkin = false;
                        RaisePropertyChanged("RyujiSkin");
                        SettingsClass.RyujiSkin = false;
                    }
                }
            }
        }
        //32 - Ye Wei*******************************************************

        private bool _yeWeiSkin;

        public bool YeWeiSkin
        {
            get { return _yeWeiSkin; }
            set
            {
                if (_yeWeiSkin != value)
                {
                    _yeWeiSkin = value;
                    SettingsClass.YeWeiSkin = _yeWeiSkin;
                    RaisePropertyChanged("YeWeiSkin");
                    if (_yeWeiSkin)
                    {
                        _yeWeiSkin2 = false;
                        RaisePropertyChanged("YeWeiSkin2");
                        SettingsClass.YeWeiSkin2 = false;
                    }
                }
            }
        }
        private bool _yeWeiSkin2;

        public bool YeWeiSkin2
        {
            get { return _yeWeiSkin2; }
            set
            {
                if (_yeWeiSkin2 != value)
                {
                    _yeWeiSkin2 = value;
                    SettingsClass.YeWeiSkin2 = _yeWeiSkin2;
                    RaisePropertyChanged("YeWeiSkin2");
                    if (_yeWeiSkin2)
                    {
                        _yeWeiSkin = false;
                        RaisePropertyChanged("YeWeiSkin");
                        SettingsClass.YeWeiSkin = false;
                    }
                }
            }
        }
        //33 - Sha Ying*****************************************************

        private bool _shaYingSkin;

        public bool ShaYingSkin
        {
            get { return _shaYingSkin; }
            set
            {
                if (_shaYingSkin != value)
                {
                    _shaYingSkin = value;
                    SettingsClass.ShaYingSkin = _shaYingSkin;
                    RaisePropertyChanged("ShaYingSkin");
                    if (_shaYingSkin)
                    {
                        _shaYingSkin2 = false;
                        RaisePropertyChanged("ShaYingSkin2");
                        SettingsClass.ShaYingSkin2 = false;
                    }
                }
            }
        }
        private bool _shaYingSkin2;

        public bool ShaYingSkin2
        {
            get { return _shaYingSkin2; }
            set
            {
                if (_shaYingSkin2 != value)
                {
                    _shaYingSkin2 = value;
                    SettingsClass.ShaYingSkin2 = _shaYingSkin2;
                    RaisePropertyChanged("ShaYingSkin2");
                    if (_shaYingSkin2)
                    {
                        _shaYingSkin = false;
                        RaisePropertyChanged("ShaYingSkin");
                        SettingsClass.ShaYingSkin = false;
                    }
                }
            }
        }
        //34 - Yan Jun******************************************************

        private bool _yanJunDrunkenFistTxt;

        public bool YanJunDrunkenFistTxt
        {
            get { return _yanJunDrunkenFistTxt; }
            set
            {
                if (_yanJunDrunkenFistTxt != value)
                {
                    _yanJunDrunkenFistTxt = value;
                    SettingsClass.YanJunDrunkenFistTxt = _yanJunDrunkenFistTxt;
                    RaisePropertyChanged("YanJunDrunkenFistTxt");
                    if (_yanJunDrunkenFistTxt)
                    {
                        _yanJunSkin2 = false;
                        RaisePropertyChanged("YanJunSkin2");
                        SettingsClass.YanJunSkin2 = false;
                    }
                }
            }
        }
        private bool _yanJunSkin2;

        public bool YanJunSkin2
        {
            get { return _yanJunSkin2; }
            set
            {
                if (_yanJunSkin2 != value)
                {
                    _yanJunSkin2 = value;
                    SettingsClass.YanJunSkin2 = _yanJunSkin2;
                    RaisePropertyChanged("YanJunSkin2");
                    if (_yanJunSkin2)
                    {
                        _yanJunDrunkenFistTxt = false;
                        RaisePropertyChanged("YanJunDrunkenFistTxt");
                        SettingsClass.YanJunDrunkenFistTxt = false;
                    }
                }
            }
        }
        //35 - Shinkai******************************************************

        private bool _shinkai007Txt;

        public bool Shinkai007Txt
        {
            get { return _shinkai007Txt; }
            set
            {
                if (_shinkai007Txt != value)
                {
                    _shinkai007Txt = value;
                    SettingsClass.Shinkai007Txt = _shinkai007Txt;
                    RaisePropertyChanged("Shinkai007Txt");
                    if (_shinkai007Txt)
                    {
                        _oldMasterShinkaiTxt = false;
                        RaisePropertyChanged("OldMasterShinkaiTxt");
                        SettingsClass.OldMasterShinkaiTxt = false;
                    }
                }
            }
        }

        private bool _oldMasterShinkaiTxt;

        public bool OldMasterShinkaiTxt
        {
            get { return _oldMasterShinkaiTxt; }
            set
            {
                if (_oldMasterShinkaiTxt != value)
                {
                    _oldMasterShinkaiTxt = value;
                    SettingsClass.OldMasterShinkaiTxt = _oldMasterShinkaiTxt;
                    RaisePropertyChanged("OldMasterShinkaiTxt");
                    if (_oldMasterShinkaiTxt)
                    {
                        _shinkai007Txt = false;
                        RaisePropertyChanged("Shinkai007Txt");
                        SettingsClass.Shinkai007Txt = false;
                    }
                }
            }
        }
        //36 - Lin Fong Lee*************************************************

        private bool _linFongLeeSkin;

        public bool LinFongLeeSkin
        {
            get { return _linFongLeeSkin; }
            set
            {
                if (_linFongLeeSkin != value)
                {
                    _linFongLeeSkin = value;
                    SettingsClass.LinFongLeeSkin = _linFongLeeSkin;
                    RaisePropertyChanged("LinFongLeeSkin");
                    if (_linFongLeeSkin)
                    {
                        _tuxLinTxt = false;
                        _cEOLinFongTxt = false;
                        RaisePropertyChanged("TuxLinTxt");
                        RaisePropertyChanged("CEOLinFongTxt");
                        SettingsClass.TuxLinTxt = false;
                        SettingsClass.CEOLinFongTxt = false;
                    }
                }
            }
        }

        private bool _tuxLinTxt;

        public bool TuxLinTxt
        {
            get { return _tuxLinTxt; }
            set
            {
                if (_tuxLinTxt != value)
                {
                    _tuxLinTxt = value;
                    SettingsClass.TuxLinTxt = _tuxLinTxt;
                    RaisePropertyChanged("TuxLinTxt");
                    if (_tuxLinTxt)
                    {
                        _linFongLeeSkin = false;
                        _cEOLinFongTxt = false;
                        RaisePropertyChanged("LinFongLeeSkin");
                        RaisePropertyChanged("CEOLinFongTxt");
                        SettingsClass.LinFongLeeSkin = false;
                        SettingsClass.CEOLinFongTxt = false;
                    }
                }
            }
        }

        private bool _cEOLinFongTxt;

        public bool CEOLinFongTxt
        {
            get { return _cEOLinFongTxt; }
            set
            {
                if (_cEOLinFongTxt != value)
                {
                    _cEOLinFongTxt = value;
                    SettingsClass.CEOLinFongTxt = _cEOLinFongTxt;
                    RaisePropertyChanged("CEOLinFongTxt");
                    if (_cEOLinFongTxt)
                    {
                        _linFongLeeSkin = false;
                        _tuxLinTxt = false;
                        RaisePropertyChanged("LinFongLeeSkin");
                        RaisePropertyChanged("TuxLinTxt");
                        SettingsClass.LinFongLeeSkin = false;
                        SettingsClass.TuxLinTxt = false;
                    }
                }
            }
        }
        //37 - Bordin*******************************************************

        private bool _hellsLegionBordinTxt;

        public bool HellsLegionBordinTxt
        {
            get { return _hellsLegionBordinTxt; }
            set
            {
                if (_hellsLegionBordinTxt != value)
                {
                    _hellsLegionBordinTxt = value;
                    SettingsClass.HellsLegionBordinTxt = _hellsLegionBordinTxt;
                    RaisePropertyChanged("HellsLegionBordinTxt");
                    if (_hellsLegionBordinTxt)
                    {
                        _martialArtistBordinTxt = false;
                        RaisePropertyChanged("MartialArtistBordinTxt");
                        SettingsClass.MartialArtistBordinTxt = false;
                    }
                }
            }
        }

        private bool _martialArtistBordinTxt;

        public bool MartialArtistBordinTxt
        {
            get { return _martialArtistBordinTxt; }
            set
            {
                if (_martialArtistBordinTxt != value)
                {
                    _martialArtistBordinTxt = value;
                    SettingsClass.MartialArtistBordinTxt = _martialArtistBordinTxt;
                    RaisePropertyChanged("MartialArtistBordinTxt");
                    if (_martialArtistBordinTxt)
                    {
                        _hellsLegionBordinTxt = false;
                        RaisePropertyChanged("HellsLegionBordinTxt");
                        SettingsClass.HellsLegionBordinTxt = false;
                    }
                }
            }
        }
        //38 - Lilian*******************************************************

        private bool _geishaLilianTxt;

        public bool GeishaLilianTxt
        {
            get { return _geishaLilianTxt; }
            set
            {
                if (_geishaLilianTxt != value)
                {
                    _geishaLilianTxt = value;
                    SettingsClass.GeishaLilianTxt = _geishaLilianTxt;
                    RaisePropertyChanged("GeishaLilianTxt");
                    if (_rebeccaChambersTxt)
                    {
                        _geishaLilianTxt = false;
                        RaisePropertyChanged("RebeccaChambersTxt");
                        SettingsClass.RebeccaChambersTxt = false;
                    }
                }
            }
        }

        private bool _rebeccaChambersTxt;

        public bool RebeccaChambersTxt
        {
            get { return _rebeccaChambersTxt; }
            set
            {
                if (_rebeccaChambersTxt != value)
                {
                    _rebeccaChambersTxt = value;
                    SettingsClass.RebeccaChambersTxt = _rebeccaChambersTxt;
                    RaisePropertyChanged("RebeccaChambersTxt");
                    if (_rebeccaChambersTxt)
                    {
                        _geishaLilianTxt = false;
                        RaisePropertyChanged("GeishaLilianTxt");
                        SettingsClass.GeishaLilianTxt = false;
                    }
                }
            }
        }
        //39 - Kelly********************************************************

        private bool _spyKellyTxt;

        public bool SpyKellyTxt
        {
            get { return _spyKellyTxt; }
            set
            {
                if (_spyKellyTxt != value)
                {
                    _spyKellyTxt = value;
                    SettingsClass.SpyKellyTxt = _spyKellyTxt;
                    RaisePropertyChanged("SpyKellyTxt");
                    if (_spyKellyTxt)
                    {
                        _kellySkin2 = false;
                        RaisePropertyChanged("KellySkin2");
                        SettingsClass.KellySkin2 = false;
                    }
                }
            }
        }
        private bool _kellySkin2;

        public bool KellySkin2
        {
            get { return _kellySkin2; }
            set
            {
                if (_kellySkin2 != value)
                {
                    _kellySkin2 = value;
                    SettingsClass.KellySkin2 = _kellySkin2;
                    RaisePropertyChanged("KellySkin2");
                    if (_kellySkin2)
                    {
                        _spyKellyTxt = false;
                        RaisePropertyChanged("SpyKellyTxt");
                        SettingsClass.SpyKellyTxt = false;
                    }
                }
            }
        }
        //3A - Vera*********************************************************

        private bool _veraSkin;

        public bool VeraSkin
        {
            get { return _veraSkin; }
            set
            {
                if (_veraSkin != value)
                {
                    _veraSkin = value;
                    SettingsClass.VeraSkin = _veraSkin;
                    RaisePropertyChanged("VeraSkin");
                    if (_veraSkin)
                    {
                        _veraNinjaTxt = false;
                        RaisePropertyChanged("VeraNinjaTxt");
                        SettingsClass.VeraNinjaTxt = false;
                    }
                }
            }
        }

        private bool _veraNinjaTxt;

        public bool VeraNinjaTxt
        {
            get { return _veraNinjaTxt; }
            set
            {
                if (_veraNinjaTxt != value)
                {
                    _veraNinjaTxt = value;
                    SettingsClass.VeraNinjaTxt = _veraNinjaTxt;
                    RaisePropertyChanged("VeraNinjaTxt");
                    if (_veraNinjaTxt)
                    {
                        _veraSkin = false;
                        RaisePropertyChanged("VeraSkin");
                        SettingsClass.VeraSkin = false;
                    }
                }
            }
        }
        //3B - Paul*********************************************************

        private bool _paulSkin;

        public bool PaulSkin
        {
            get { return _paulSkin; }
            set
            {
                if (_paulSkin != value)
                {
                    _paulSkin = value;
                    SettingsClass.PaulSkin = _paulSkin;
                    RaisePropertyChanged("PaulSkin");
                    if (_paulSkin)
                    {
                        _paulSkin2 = false;
                        _paul2040Txt = false;
                        RaisePropertyChanged("PaulSkin2");
                        RaisePropertyChanged("Paul2040Txt");
                        SettingsClass.PaulSkin2 = false;
                        SettingsClass.Paul2040Txt = false;
                    }
                }
            }
        }

        private bool _paulSkin2;

        public bool PaulSkin2
        {
            get { return _paulSkin2; }
            set
            {
                if (_paulSkin2 != value)
                {
                    _paulSkin2 = value;
                    SettingsClass.PaulSkin2 = _paulSkin2;
                    RaisePropertyChanged("PaulSkin2");
                    if (_paulSkin2)
                    {
                        _paulSkin = false;
                        _paul2040Txt = false;
                        RaisePropertyChanged("PaulSkin");
                        RaisePropertyChanged("Paul2040Txt");
                        SettingsClass.PaulSkin = false;
                        SettingsClass.Paul2040Txt = false;
                    }
                }
            }
        }

        private bool _paul2040Txt;

        public bool Paul2040Txt
        {
            get { return _paul2040Txt; }
            set
            {
                if (_paul2040Txt != value)
                {
                    _paul2040Txt = value;
                    SettingsClass.Paul2040Txt = _paul2040Txt;
                    RaisePropertyChanged("Paul2040Txt");
                    if (_paul2040Txt)
                    {
                        _paulSkin = false;
                        _paulSkin2 = false;
                        RaisePropertyChanged("PaulSkin");
                        RaisePropertyChanged("PaulSkin2");
                        SettingsClass.PaulSkin = false;
                        SettingsClass.PaulSkin2 = false;
                    }
                }
            }
        }
        //3C - Law**********************************************************

        private bool _lawSkin;

        public bool LawSkin
        {
            get { return _lawSkin; }
            set
            {
                if (_lawSkin != value)
                {
                    _lawSkin = value;
                    SettingsClass.LawSkin = _lawSkin;
                    RaisePropertyChanged("LawSkin");
                    if (_lawSkin)
                    {
                        _johnnyCageLawTxt = false;
                        RaisePropertyChanged("JohnnyCageLawTxt");
                        SettingsClass.JohnnyCageLawTxt = false;
                    }
                }
            }
        }
        private bool _johnnyCageLawTxt;

        public bool JohnnyCageLawTxt
        {
            get { return _johnnyCageLawTxt; }
            set
            {
                if (_johnnyCageLawTxt != value)
                {
                    _johnnyCageLawTxt = value;
                    SettingsClass.JohnnyCageLawTxt = _johnnyCageLawTxt;
                    RaisePropertyChanged("JohnnyCageLawTxt");
                    if (_johnnyCageLawTxt)
                    {
                        _lawSkin = false;
                        RaisePropertyChanged("LawSkin");
                        SettingsClass.LawSkin = false;
                    }
                }
            }
        }
        //45 - KG***********************************************************

        private bool _kGBeat_upTxt;

        public bool KGBeat_upTxt
        {
            get { return _kGBeat_upTxt; }
            set
            {
                if (_kGBeat_upTxt != value)
                {
                    _kGBeat_upTxt = value;
                    SettingsClass.KGBeat_upTxt = _kGBeat_upTxt;
                    RaisePropertyChanged("KGBeat_upTxt");
                    if (_kGBeat_upTxt)
                    {
                        _kG_WhatsAppTxt = false;
                        RaisePropertyChanged("KG_WhatsAppTxt");
                        SettingsClass.KG_WhatsAppTxt = false;
                    }
                }
            }
        }

        private bool _kG_WhatsAppTxt;

        public bool KG_WhatsAppTxt
        {
            get { return _kG_WhatsAppTxt; }
            set
            {
                if (_kG_WhatsAppTxt != value)
                {
                    _kG_WhatsAppTxt = value;
                    SettingsClass.KG_WhatsAppTxt = _kG_WhatsAppTxt;
                    RaisePropertyChanged("KG_WhatsAppTxt");
                    if (_kG_WhatsAppTxt)
                    {
                        _kGBeat_upTxt = false;
                        RaisePropertyChanged("KGBeat_upTxt");
                        SettingsClass.KGBeat_upTxt = false;
                    }
                }
            }
        }


        //--------------------------------------------------------

        private bool _titleScreenTxt;

        public bool TitleScreenTxt
        {
            get { return _titleScreenTxt; }
            set
            {
                if (_titleScreenTxt != value)
                {
                    _titleScreenTxt = value;
                    SettingsClass.TitleScreenTxt = _titleScreenTxt;
                    RaisePropertyChanged("TitleScreenTxt");
                }
            }
        }

        private bool _warehouseTxt;

        public bool WarehouseTxt
        {
            get { return _warehouseTxt; }
            set
            {
                if (_warehouseTxt != value)
                {
                    _warehouseTxt = value;
                    SettingsClass.WarehouseTxt = _warehouseTxt;
                    RaisePropertyChanged("WarehouseTxt");
                }
            }
        }

        private bool _weaponsTxt;

        public bool WeaponsTxt
        {
            get { return _weaponsTxt; }
            set
            {
                if (_weaponsTxt != value)
                {
                    _weaponsTxt = value;
                    SettingsClass.WeaponsTxt = _weaponsTxt;
                    RaisePropertyChanged("WeaponsTxt");
                }
            }
        }

        private bool _multyplayerTxt;

        public bool MultyplayerTxt
        {
            get { return _multyplayerTxt; }
            set
            {
                if (_multyplayerTxt != value)
                {
                    _multyplayerTxt = value;
                    SettingsClass.MultyplayerTxt = _multyplayerTxt;
                    RaisePropertyChanged("MultyplayerTxt");
                }
            }
        }

        
        #endregion


        #region Textures Data
        internal void SwapTextures()
        {
            string notFound = "";

            #region Brad Hawk [00]

            RemoveTextures("1f8d4f29ac1fad11-73097d5b66b6c93d-r80000000800000-00006a93", "2d9db83d6fbb722e-acb50fd49fba53b8-r100000000400000-00006a94",
                    "4d0e98150eb4d4c5-ce8275a0761d86fc-r40000000800000-00006a93", "57c7807e1cb18ef4-122d1748bf215a76-r40000000400000-00006a93",
                    "92ca3fa117cf9044-32916e808b94fcbe-r100000000800000-00006a94", "9038b2fc83b0c2d6-6b7683df08f19e63-r100000000800000-00006a94",
                    "453006334b5971c1-3a18c0ef1c4401fe-r80000000800000-00006a93", "8465025957e3b334-4628b248da283aee-r27000002800000-00005a94",
                    "a3ac468a9e79b9-d1d077b742884dfa-r20000000200000-00006a93", "b24201f22fddd29-8e319ba1c3118296-r100000001000000-00006a93",
                    "d2f7e81ae43f261f-23fbf8d76f5fcf18-r10000000200000-00006a93", "fa336ac29847481d-c4c9d57a996ac45a-r80000000800000-00006a94",
                    "a22ef079df551fca-91f3304b2d6eff0e-r100000000800000-00006a93", "",
                    "2f7abe24756e0ce1-246c699f83868888-r80000000800000-00006a93", "",
                    "", "",
                    "", "");

            if (CollegeBoyBradTxt)
            {
                try
                {
                    ReplaceTextures(@"\_college boy brad\", "1f8d4f29ac1fad11-73097d5b66b6c93d-r80000000800000-00006a93", "2d9db83d6fbb722e-acb50fd49fba53b8-r100000000400000-00006a94",
                        "4d0e98150eb4d4c5-ce8275a0761d86fc-r40000000800000-00006a93", "57c7807e1cb18ef4-122d1748bf215a76-r40000000400000-00006a93",
                        "92ca3fa117cf9044-32916e808b94fcbe-r100000000800000-00006a94", "9038b2fc83b0c2d6-6b7683df08f19e63-r100000000800000-00006a94",
                        "453006334b5971c1-3a18c0ef1c4401fe-r80000000800000-00006a93", "8465025957e3b334-4628b248da283aee-r27000002800000-00005a94",
                        "a3ac468a9e79b9-d1d077b742884dfa-r20000000200000-00006a93", "b24201f22fddd29-8e319ba1c3118296-r100000001000000-00006a93",
                        "d2f7e81ae43f261f-23fbf8d76f5fcf18-r10000000200000-00006a93", "fa336ac29847481d-c4c9d57a996ac45a-r80000000800000-00006a94",
                        "a22ef079df551fca-91f3304b2d6eff0e-r100000000800000-00006a93", "",
                        "2f7abe24756e0ce1-246c699f83868888-r80000000800000-00006a93", "",
                        "", "",
                        "", "");
                }
                catch
                {
                    CollegeBoyBradTxt = false;
                    notFound += "CollegeBoyBradTxt" + Environment.NewLine + "";
                }
            }
            else if (SH2JamesTxt)
            {
                try
                {
                    ReplaceTextures(@"\_sh2jamesinspiredbradmod\", "2d9db83d6fbb722e-acb50fd49fba53b8-r100000000400000-00006a94", "92ca3fa117cf9044-32916e808b94fcbe-r100000000800000-00006a94",
                        "9038b2fc83b0c2d6-6b7683df08f19e63-r100000000800000-00006a94", "453006334b5971c1-3a18c0ef1c4401fe-r80000000800000-00006a93",
                        "fa336ac29847481d-c4c9d57a996ac45a-r80000000800000-00006a94", "a22ef079df551fca-91f3304b2d6eff0e-r100000000800000-00006a93",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "");
                }
                catch
                {
                    SH2JamesTxt = false;
                    notFound += "SH2JamesTxt" + Environment.NewLine + "";
                }
            }
            else if (MaskedDemonBradTxt)
            {
                try
                {
                    ReplaceTextures(@"\_masked_demon_brad\", "1f8d4f29ac1fad11-73097d5b66b6c93d-r80000000800000-00006a93", "2d9db83d6fbb722e-acb50fd49fba53b8-r100000000400000-00006a94",
                        "57c7807e1cb18ef4-122d1748bf215a76-r40000000400000-00006a93", "92ca3fa117cf9044-32916e808b94fcbe-r100000000800000-00006a94",
                        "9038b2fc83b0c2d6-6b7683df08f19e63-r100000000800000-00006a94", "453006334b5971c1-3a18c0ef1c4401fe-r80000000800000-00006a93",
                        "b24201f22fddd29-8e319ba1c3118296-r100000001000000-00006a93", "fa336ac29847481d-c4c9d57a996ac45a-r80000000800000-00006a94",
                        "a22ef079df551fca-91f3304b2d6eff0e-r100000000800000-00006a93", "",
                        "2f7abe24756e0ce1-246c699f83868888-r80000000800000-00006a93", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "");
                }
                catch
                {
                    MaskedDemonBradTxt = false;
                    notFound += "MaskedDemonBradTxt" + Environment.NewLine + "";
                }
            }
            else if (KazumaKiryuBradTxt)
            {
                try
                {
                    ReplaceTextures(@"\_Kazuma Kiryu Brad\", "2d9db83d6fbb722e-acb50fd49fba53b8-r100000000400000-00006a94", "",
                        "92ca3fa117cf9044-32916e808b94fcbe-r100000000800000-00006a94", "9038b2fc83b0c2d6-6b7683df08f19e63-r100000000800000-00006a94",
                        "453006334b5971c1-3a18c0ef1c4401fe-r80000000800000-00006a93", "fa336ac29847481d-c4c9d57a996ac45a-r80000000800000-00006a94",
                        "a22ef079df551fca-91f3304b2d6eff0e-r100000000800000-00006a93", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "");
                }
                catch
                {
                    KazumaKiryuBradTxt = false;
                    notFound += "KazumaKiryuBradTxt" + Environment.NewLine + "";
                }
            }
            else if (BradfromGymTxt)
            {
                try
                {
                    ReplaceTextures(@"\_Brad_from_Gym\", "", "",
                        "92ca3fa117cf9044-32916e808b94fcbe-r100000000800000-00006a94", "9038b2fc83b0c2d6-6b7683df08f19e63-r100000000800000-00006a94",
                        "453006334b5971c1-3a18c0ef1c4401fe-r80000000800000-00006a93", "fa336ac29847481d-c4c9d57a996ac45a-r80000000800000-00006a94",
                        "a22ef079df551fca-91f3304b2d6eff0e-r100000000800000-00006a93", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "");
                }
                catch
                {
                    BradfromGymTxt = false;
                    notFound += "BradfromGymTxt" + Environment.NewLine + "";
                }
            }
            else if (SpecialAgentBradHawkTxt)
            {
                try
                {
                    ReplaceTextures(@"\_Special_Agent_Brad_Hawk\", "2d9db83d6fbb722e-acb50fd49fba53b8-r100000000400000-00006a94", "",
                        "92ca3fa117cf9044-32916e808b94fcbe-r100000000800000-00006a94", "9038b2fc83b0c2d6-6b7683df08f19e63-r100000000800000-00006a94",
                        "", "fa336ac29847481d-c4c9d57a996ac45a-r80000000800000-00006a94",
                        "a22ef079df551fca-91f3304b2d6eff0e-r100000000800000-00006a93", "1f8d4f29ac1fad11-73097d5b66b6c93d-r80000000800000-00006a93",
                        "2f7abe24756e0ce1-246c699f83868888-r80000000800000-00006a93", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "");
                }
                catch
                {
                    SpecialAgentBradHawkTxt = false;
                    notFound += "SpecialAgentBradHawkTxt" + Environment.NewLine + "";
                }
            }
            else if (GovernmentAgentBradHawkTxt)
            {
                try
                {
                    ReplaceTextures(@"\_Government_Agent_Brad_Hawk\", "2d9db83d6fbb722e-acb50fd49fba53b8-r100000000400000-00006a94", "",
                        "92ca3fa117cf9044-32916e808b94fcbe-r100000000800000-00006a94", "9038b2fc83b0c2d6-6b7683df08f19e63-r100000000800000-00006a94",
                        "", "fa336ac29847481d-c4c9d57a996ac45a-r80000000800000-00006a94",
                        "a22ef079df551fca-91f3304b2d6eff0e-r100000000800000-00006a93", "",
                        "1f8d4f29ac1fad11-73097d5b66b6c93d-r80000000800000-00006a93", "2f7abe24756e0ce1-246c699f83868888-r80000000800000-00006a93",
                        "453006334b5971c1-3a18c0ef1c4401fe-r80000000800000-00006a93", "a3ac468a9e79b9-d1d077b742884dfa-r20000000200000-00006a93",
                        "", "",
                        "", "",
                        "", "",
                        "", "");
                }
                catch
                {
                    GovernmentAgentBradHawkTxt = false;
                    notFound += "GovernmentAgentBradHawkTxt" + Environment.NewLine + "";
                }
            }


            #endregion

            #region Glen [03]

            string sharedImage = "7afe29b3094e20f8-83271f76dfcefd24-r80000000800000-00006a93";
            if (!GlenSkin)
            {
                sharedImage = "";
            }

            RemoveTextures("2c405af1c7840e74-3614e4a0c33dd81e-r10000000200000-00006a93", "3dfa2821c2667227-11177136b16d0b2b-r20000000100000-00006a93",
                    "4a171a457fc3bc4f-e631813d258ad8cb-r80000000800000-00006a93", sharedImage,
                    "65ff2577fb0fca21-de9e9e3e99570870-r80000000800000-00006a93", "2192a86a111e28ca-719133f74494d42b-r20000000400000-00006a93",
                    "ab31dcb90aedf4cf-1a56b8619de39c2f-r40000000400000-00006a93", "b7eb5a2a6c285918-3b9f42bd3cb5a805-r80000000800000-00006a93",
                    "e6b2e46487b6ed28-57d7f3a4944d1686-r40000000200000-00006a93", "f18a9264607c78e7-40d7c2e9e37fe11e-r10000000200000-00006a93",
                    "1d5e2b5e639996b5-d2a04109a76d4e24-r100000001000000-00006a93", "461bd1af7afa6d52-c7a7d4c89cad7d53-r10000000200000-00006a93",
                    "6854e62263cd7d3a-250d815476a4975b-r20000000400000-00006a93", "621336b0f6704030-4d9f83943e1fc1e6-r10000000200000-00006a93",
                    "a05e8135c96d2d9a-198628decf86caf4-r10000000200000-00006a93", "b39f20867d125c82-c4350e7592a31733-r20000000200000-00006a93",
                    "e8f28ab020a75a17-2c457fd6497eff85-r20000000400000-00006a93", "",
                    "", "");

            if (GlenSkin)
            {
                try
                {
                    ReplaceTextures(@"\_modern biker glen\", "2c405af1c7840e74-3614e4a0c33dd81e-r10000000200000-00006a93", "3dfa2821c2667227-11177136b16d0b2b-r20000000100000-00006a93",
                        "4a171a457fc3bc4f-e631813d258ad8cb-r80000000800000-00006a93", sharedImage,
                        "65ff2577fb0fca21-de9e9e3e99570870-r80000000800000-00006a93", "2192a86a111e28ca-719133f74494d42b-r20000000400000-00006a93",
                        "ab31dcb90aedf4cf-1a56b8619de39c2f-r40000000400000-00006a93", "b7eb5a2a6c285918-3b9f42bd3cb5a805-r80000000800000-00006a93",
                        "e6b2e46487b6ed28-57d7f3a4944d1686-r40000000200000-00006a93", "f18a9264607c78e7-40d7c2e9e37fe11e-r10000000200000-00006a93",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "");
                }
                catch
                {
                    GlenSkin = false;

                    notFound += "ModernBikerGlenTxt" + Environment.NewLine + "";
                }
            }
            else if (BatmanGlenTxt)
            {
                try
                {
                    ReplaceTextures(@"\_batman Glen\", "", "",
                        "4a171a457fc3bc4f-e631813d258ad8cb-r80000000800000-00006a93", sharedImage,
                        "65ff2577fb0fca21-de9e9e3e99570870-r80000000800000-00006a93", "2192a86a111e28ca-719133f74494d42b-r20000000400000-00006a93",
                        "ab31dcb90aedf4cf-1a56b8619de39c2f-r40000000400000-00006a93", "b7eb5a2a6c285918-3b9f42bd3cb5a805-r80000000800000-00006a93",
                        "e6b2e46487b6ed28-57d7f3a4944d1686-r40000000200000-00006a93", "f18a9264607c78e7-40d7c2e9e37fe11e-r10000000200000-00006a93",
                        "1d5e2b5e639996b5-d2a04109a76d4e24-r100000001000000-00006a93", "461bd1af7afa6d52-c7a7d4c89cad7d53-r10000000200000-00006a93",
                        "6854e62263cd7d3a-250d815476a4975b-r20000000400000-00006a93", "621336b0f6704030-4d9f83943e1fc1e6-r10000000200000-00006a93",
                        "a05e8135c96d2d9a-198628decf86caf4-r10000000200000-00006a93", "b39f20867d125c82-c4350e7592a31733-r20000000200000-00006a93",
                        "e8f28ab020a75a17-2c457fd6497eff85-r20000000400000-00006a93", "",
                        "", "");
                }
                catch
                {
                    BatmanGlenTxt = false;

                    notFound += "BatmanGlenTxt" + Environment.NewLine + "";
                }
            }

            #endregion

            #region Torque [04]

            sharedImage = "7afe29b3094e20f8-83271f76dfcefd24-r80000000800000-00006a93";
            if (!TorqueSkin && !TorqueGalsiaTxt)
            {
                sharedImage = "";
            }

            RemoveTextures(sharedImage, "48b651f1a7be267-4b046efaa6f3e187-r80000000800000-00006a93",
                    "a1c4239db828d84f-387518e3021e4fd4-r40000000400000-00006a93", "a154c763a5fd8464-beebdfc8dfdcf02-r80000000400000-00006a93",
                    "f9f73a70ae6f4c1-6801e0b05c4479bb-r40000000400000-00006a93", "fbee05ce72e31584-a326837b44195f8f-r80000000800000-00006a93",
                    "7b4410a40a270a75-344281650713eef6-r100000001000000-00006a93", "48bb1b20c579cc98-dc75b699dbe815c8-r20000000200000-00006a93",
                    "9908b791ef70a03b-e415b68572f98dc5-r20000000400000-00006a93", "ae9cf1e8bf98af96-1daa7f06f94371b4-r20000000200000-00006a93",
                    "e5c2bde6480d216f-8aaa12027c20141b-r20000000200000-00006a93", "",
                    "", "",
                    "", "",
                    "", "",
                    "", "");

            if (TorqueSkin)
            {
                try
                {
                    ReplaceTextures(@"\_cowboy_torque\", sharedImage, "48b651f1a7be267-4b046efaa6f3e187-r80000000800000-00006a93",
                        "a1c4239db828d84f-387518e3021e4fd4-r40000000400000-00006a93", "a154c763a5fd8464-beebdfc8dfdcf02-r80000000400000-00006a93",
                        "f9f73a70ae6f4c1-6801e0b05c4479bb-r40000000400000-00006a93", "fbee05ce72e31584-a326837b44195f8f-r80000000800000-00006a93",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "");
                }
                catch
                {
                    TorqueSkin = false;
                    notFound += "CowboyTorqueTxt" + Environment.NewLine + "";
                }
            }
            else if (TorqueGalsiaTxt)
            {
                try
                {
                    ReplaceTextures(@"\_Torque_Galsia\", sharedImage, "48b651f1a7be267-4b046efaa6f3e187-r80000000800000-00006a93",
                        "a1c4239db828d84f-387518e3021e4fd4-r40000000400000-00006a93", "a154c763a5fd8464-beebdfc8dfdcf02-r80000000400000-00006a93",
                        "f9f73a70ae6f4c1-6801e0b05c4479bb-r40000000400000-00006a93", "fbee05ce72e31584-a326837b44195f8f-r80000000800000-00006a93",
                        "7b4410a40a270a75-344281650713eef6-r100000001000000-00006a93", "48bb1b20c579cc98-dc75b699dbe815c8-r20000000200000-00006a93",
                        "9908b791ef70a03b-e415b68572f98dc5-r20000000400000-00006a93", "ae9cf1e8bf98af96-1daa7f06f94371b4-r20000000200000-00006a93",
                        "e5c2bde6480d216f-8aaa12027c20141b-r20000000200000-00006a93", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "");
                }
                catch
                {
                    TorqueGalsiaTxt = false;
                    notFound += "TorqueGalsiaTxt" + Environment.NewLine + "";
                }
            }

            #endregion

            #region Rod [05]

            sharedImage = "7afe29b3094e20f8-83271f76dfcefd24-r80000000800000-00006a93";
            if (!RodSkin && !RodKlugerTxt)
            {
                sharedImage = "";
            }

            RemoveTextures(sharedImage, "9ebb86cac1a288e6-830facfe8e6213ff-r20000000400000-00006a93",
                    "249c657146880f68-cd5f81b107f4656-r40000000400000-00006a93", "855256cf13d3180d-9286596aa22f948a-r80000000800000-00006a93",
                    "c4f62cefc7ce319-8bc0017c9881aaf-r40000000800000-00006a93", "c105d38ca74a884f-f4f94f9703127bc2-r80000000800000-00006a93",
                    "dc6e465dc46b8832-8f60749c4bf87e30-r80000000400000-00006a93", "31c69b99a8246e5-af9fe19dbbbf95a7-r20000000200000-00006a93",
                    "68eb3514604d3810-830e26b10ca4a588-r20000000200000-00006a93", "824d0167550fe4ec-c64b2d90fd3d0d20-r40000000400000-00006a93",
                    "abf53fdadca8511c-b9b032a4b5b5446f-r100000001000000-00006a93", "",
                    "", "",
                    "", "",
                    "", "",
                    "", "");

            if (RodSkin)
            {
                try
                {
                    ReplaceTextures(@"\_Yorito_Misawa_Rod\", sharedImage, "9ebb86cac1a288e6-830facfe8e6213ff-r20000000400000-00006a93",
                        "249c657146880f68-cd5f81b107f4656-r40000000400000-00006a93", "855256cf13d3180d-9286596aa22f948a-r80000000800000-00006a93",
                        "c4f62cefc7ce319-8bc0017c9881aaf-r40000000800000-00006a93", "c105d38ca74a884f-f4f94f9703127bc2-r80000000800000-00006a93",
                        "dc6e465dc46b8832-8f60749c4bf87e30-r80000000400000-00006a93", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "");
                }
                catch
                {
                    RodSkin = false;
                    notFound += "YoritoMisawaRodSkin" + Environment.NewLine + "";
                }
            }
            else if (RodKlugerTxt)
            {
                try
                {
                    ReplaceTextures(@"\_Rod_Kluger\", sharedImage, "",
                        "249c657146880f68-cd5f81b107f4656-r40000000400000-00006a93", "855256cf13d3180d-9286596aa22f948a-r80000000800000-00006a93",
                        "c4f62cefc7ce319-8bc0017c9881aaf-r40000000800000-00006a93", "c105d38ca74a884f-f4f94f9703127bc2-r80000000800000-00006a93",
                        "dc6e465dc46b8832-8f60749c4bf87e30-r80000000400000-00006a93", "31c69b99a8246e5-af9fe19dbbbf95a7-r20000000200000-00006a93",
                        "68eb3514604d3810-830e26b10ca4a588-r20000000200000-00006a93", "824d0167550fe4ec-c64b2d90fd3d0d20-r40000000400000-00006a93",
                        "abf53fdadca8511c-b9b032a4b5b5446f-r100000001000000-00006a93", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "");
                }
                catch
                {
                    RodKlugerTxt = false;
                    notFound += "RodKlugerTxt" + Environment.NewLine + "";
                }
            }

            #endregion

            #region Seth [06]

            sharedImage = "7afe29b3094e20f8-83271f76dfcefd24-r80000000800000-00006a93";
            if (!SethSkin)
            {
                sharedImage = "";
            }

            RemoveTextures("3d8a914947041f63-192499ccfada87ab-r80000000400000-00006a93", "3d8a914947041f63-192499ccfada87ab-r80000000400000-00006a931",
                    "5ca27308fc25c0a2-344017c42c5a1136-r40000000400000-00006a93", sharedImage,
                    "8a62f700c811939e-f1f3bea0852cb9de-r100000001000000-00006a93", "34dee0dd2dc09dab-101898b4ef1df495-r20000000400000-00006a93",
                    "59b0fbf13f736324-2da5ffc480067beb-r40000000400000-00006a93", "75cbc30b6b287a17-5d211f35c8a123e8-r20000000400000-00006a93",
                    "94dd1c0345ccaf5e-7a3851dddb4d7da9-r80000000800000-00006a93", "96323d16391668e-903433c878125c0a-r40000000400000-00006a93",
                    "b3fcab840e7ccc73-9c64b84a262b498c-r80000000800000-00006a93", "cb2f4ab3760bad2c-fed1124e1c40e670-r80000000800000-00006a93",
                    "748a870370061b31-a5833a9968cdc5e1-r20000000200000-00006a93", "eb978dfe83518f68-5c9cfc9cb379fcf-r40000000400000-00006a93",
                    "ff37b95226d2d79b-29331a442940c755-r40000000400000-00006a93", "",
                    "", "",
                    "", "");

            if (SethSkin)
            {
                try
                {
                    ReplaceTextures(@"\_Iroquois_Seth\", "3d8a914947041f63-192499ccfada87ab-r80000000400000-00006a93", "3d8a914947041f63-192499ccfada87ab-r80000000400000-00006a931",
                        "5ca27308fc25c0a2-344017c42c5a1136-r40000000400000-00006a93", sharedImage,
                        "8a62f700c811939e-f1f3bea0852cb9de-r100000001000000-00006a93", "34dee0dd2dc09dab-101898b4ef1df495-r20000000400000-00006a93",
                        "59b0fbf13f736324-2da5ffc480067beb-r40000000400000-00006a93", "75cbc30b6b287a17-5d211f35c8a123e8-r20000000400000-00006a93",
                        "94dd1c0345ccaf5e-7a3851dddb4d7da9-r80000000800000-00006a93", "96323d16391668e-903433c878125c0a-r40000000400000-00006a93",
                        "b3fcab840e7ccc73-9c64b84a262b498c-r80000000800000-00006a93", "cb2f4ab3760bad2c-fed1124e1c40e670-r80000000800000-00006a93",
                        "", "",
                        "", "",
                        "", "",
                        "", "");
                }
                catch
                {
                    SethSkin = false;
                    notFound += "Iroquois_SethSkin" + Environment.NewLine + "";
                }
            }
            else if (SethSkin2)
            {
                try
                {
                    ReplaceTextures(@"\_The Rock Sethson\", "3d8a914947041f63-192499ccfada87ab-r80000000400000-00006a93", "5ca27308fc25c0a2-344017c42c5a1136-r40000000400000-00006a93",
                        "8a62f700c811939e-f1f3bea0852cb9de-r100000001000000-00006a93", sharedImage,
                        "34dee0dd2dc09dab-101898b4ef1df495-r20000000400000-00006a93", "b3fcab840e7ccc73-9c64b84a262b498c-r80000000800000-00006a93",
                        "94dd1c0345ccaf5e-7a3851dddb4d7da9-r80000000800000-00006a93", "75cbc30b6b287a17-5d211f35c8a123e8-r20000000400000-00006a93",
                        "748a870370061b31-a5833a9968cdc5e1-r20000000200000-00006a93", "96323d16391668e-903433c878125c0a-r40000000400000-00006a93",
                        "cb2f4ab3760bad2c-fed1124e1c40e670-r80000000800000-00006a93", "eb978dfe83518f68-5c9cfc9cb379fcf-r40000000400000-00006a93",
                        "ff37b95226d2d79b-29331a442940c755-r40000000400000-00006a93", "",
                        "", "",
                        "", "",
                        "", "");
                }
                catch
                {
                    SethSkin2 = false;
                    notFound += "The Rock Sethson" + Environment.NewLine + "";
                }
            }

            #endregion

            #region Nas-Tiii [07]

            RemoveTextures("2a397cf157967660-b8301d60d421984c-r80000000800000-00006a94", "9ca9d0567fef9a5-a6749816a1a7376-r100000000800000-00006a93",
                    "18ceef978ef33cc9-2bd93863cefbc859-r40000000400000-00006a94", "71a9d987e4e430b3-6b955cee649b95e5-r80000000800000-00006a93",
                    "88e21af804f2f833-1772a89ecb069cfd-r80000000400000-00006a93", "c6c4866eb43f1f2d-171824fa293321f3-r80000000800000-00006a93",
                    "5b4c07b9a114c473-2635d302a86bd789-r40000000400000-00006a94", "142b31df3b1cc5cd-9246b6c9e2d11098-r80000000800000-00006a94",
                    "", "",
                    "", "",
                    "", "",
                    "", "",
                    "", "",
                    "", "");

            if (NasTiiiSkin)
            {
                try
                {
                    ReplaceTextures(@"\_NasTiii ex gangster\", "2a397cf157967660-b8301d60d421984c-r80000000800000-00006a94", "9ca9d0567fef9a5-a6749816a1a7376-r100000000800000-00006a93",
                        "18ceef978ef33cc9-2bd93863cefbc859-r40000000400000-00006a94", "71a9d987e4e430b3-6b955cee649b95e5-r80000000800000-00006a93",
                        "88e21af804f2f833-1772a89ecb069cfd-r80000000400000-00006a93", "c6c4866eb43f1f2d-171824fa293321f3-r80000000800000-00006a93",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "");
                }
                catch
                {
                    NasTiiiSkin = false;
                    notFound += "NasTiii_Ex_Gangster_Txt" + Environment.NewLine + "";
                }
            }
            else if (NasTiiiSkin2)
            {
                try
                {
                    ReplaceTextures(@"\_Nasty_Mobster\", "2a397cf157967660-b8301d60d421984c-r80000000800000-00006a94", "5b4c07b9a114c473-2635d302a86bd789-r40000000400000-00006a94",
                        "9ca9d0567fef9a5-a6749816a1a7376-r100000000800000-00006a93", "18ceef978ef33cc9-2bd93863cefbc859-r40000000400000-00006a94",
                        "71a9d987e4e430b3-6b955cee649b95e5-r80000000800000-00006a93", "88e21af804f2f833-1772a89ecb069cfd-r80000000400000-00006a93",
                        "142b31df3b1cc5cd-9246b6c9e2d11098-r80000000800000-00006a94", "c6c4866eb43f1f2d-171824fa293321f3-r80000000800000-00006a93",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "");
                }
                catch
                {
                    NasTiiiSkin2 = false;
                    notFound += "Nasty_Mobster" + Environment.NewLine + "";
                }
            }

            #endregion

            #region Em Cee [08]

            RemoveTextures("5d4ed9fe1f41e76-2f92919a2d8cac7-000061d3", "8b986aabb7f101fc-3043925f69547156-r40000000800000-00006a93",
                    "9cba0554e0001ed1-b5ff98e4a89de848-00005dd3", "20cfc6abe0b9d978-83903ff6a4338c94-00005dd4",
                    "34ed810091ea2a5b-f895ad7844eec0ea-00005dd3", "90e1be372ec7ad94-6f22edca0bed91a6-00005d93",
                    "43372d948166bad9-ed940040202e297-000059d3", "f4744a97827090e5-5b43b4ca6fa4301d-00005dd3",
                    "", "",
                    "", "",
                    "", "",
                    "", "",
                    "", "",
                    "", "");

            if (EmCeeSkin)
            {
                try
                {
                    ReplaceTextures(@"\_BurritoPonchoEmCee\", "5d4ed9fe1f41e76-2f92919a2d8cac7-000061d3", "8b986aabb7f101fc-3043925f69547156-r40000000800000-00006a93",
                        "9cba0554e0001ed1-b5ff98e4a89de848-00005dd3", "20cfc6abe0b9d978-83903ff6a4338c94-00005dd4",
                        "34ed810091ea2a5b-f895ad7844eec0ea-00005dd3", "90e1be372ec7ad94-6f22edca0bed91a6-00005d93",
                        "43372d948166bad9-ed940040202e297-000059d3", "f4744a97827090e5-5b43b4ca6fa4301d-00005dd3",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "");
                }
                catch
                {
                    EmCeeSkin = false;
                    notFound += "BurritoPonchoEmCeeSkin" + Environment.NewLine + "";
                }
            }
            else if (EmCeeSkin2)
            {
                try
                {
                    ReplaceTextures(@"\_Gaming_Gipsy\", "5d4ed9fe1f41e76-2f92919a2d8cac7-000061d3", "8b986aabb7f101fc-3043925f69547156-r40000000800000-00006a93",
                        "9cba0554e0001ed1-b5ff98e4a89de848-00005dd3", "20cfc6abe0b9d978-83903ff6a4338c94-00005dd4",
                        "90e1be372ec7ad94-6f22edca0bed91a6-00005d93", "43372d948166bad9-ed940040202e297-000059d3",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "");
                }
                catch
                {
                    EmCeeSkin2 = false;
                    notFound += "Gaming_Gipsy" + Environment.NewLine + "";
                }
            }

            #endregion

            #region Real Deal [09]

            RemoveTextures("1f104e99ff1b85cb-afe73a5a25d27e2f-r80000000800000-00006a93", "3b26a8e316b863a7-7f42e35652202021-r40000000400000-00006a93",
                    "4ec8c3e108feb6b3-88ab215bd3b210fb-r40000000400000-00006a93", "9e228b1bae465ec1-749f25feabe532bf-r40000000800000-00006a93",
                    "14e489a90cacdf4f-5a3fa068b0e5ee0a-r40000000400000-00006a93", "39dfbc76496a3ce1-530bd54c6a497110-r20000000400000-00006a93",
                    "140c6c3bd5680c17-b5e6440b8f69f84f-r80000000800000-00006a93", "34772957f4e1b4cf-c1a87ce73877b6a2-r40000000400000-00006a93",
                    "bfdd1db2b7f31065-1fdd98a47a371116-r20000000400000-00006a93", "e03ac62fb721382d-a2de1a199830f54a-r20000000400000-00006a93",
                    "2f46a606d71edf02-6f54b6ce5dd92706-r20000000400000-00006a93", "8d63edd4c45be56-443581949ca2d5c4-r10000000200000-00006a93",
                    "446706eecc53ceaa-fe33935271c33927-r20000000400000-00006a93", "b48149d4637064bd-7bea09de2ebb25d3-r80000000800000-00006a93",
                    "e6bd1f93000b847f-33b9e8698351579-r100000000800000-00006a93", "1fb5003a8b9c2665-5d6ec658e24553f3-r10000000400000-00006a93",
                    "bb06f488e7aab9f3-6ca41bd2a8faddd-r40000000400000-00006a93", "",
                    "", "");

            if (RealDealSkin)
            {
                try
                {
                    ReplaceTextures(@"\_real BIG deal\", "1f104e99ff1b85cb-afe73a5a25d27e2f-r80000000800000-00006a93", "3b26a8e316b863a7-7f42e35652202021-r40000000400000-00006a93",
                        "4ec8c3e108feb6b3-88ab215bd3b210fb-r40000000400000-00006a93", "9e228b1bae465ec1-749f25feabe532bf-r40000000800000-00006a93",
                        "14e489a90cacdf4f-5a3fa068b0e5ee0a-r40000000400000-00006a93", "39dfbc76496a3ce1-530bd54c6a497110-r20000000400000-00006a93",
                        "140c6c3bd5680c17-b5e6440b8f69f84f-r80000000800000-00006a93", "34772957f4e1b4cf-c1a87ce73877b6a2-r40000000400000-00006a93",
                        "bfdd1db2b7f31065-1fdd98a47a371116-r20000000400000-00006a93", "e03ac62fb721382d-a2de1a199830f54a-r20000000400000-00006a93",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "");
                }
                catch
                {
                    RealDealSkin = false;
                    notFound += "Real_BIG_Deal_Txt" + Environment.NewLine + "";
                }
            }
            else if (HornswoggleTxt)
            {
                try
                { 
                    ReplaceTextures(@"\_hornswoggle\", "1f104e99ff1b85cb-afe73a5a25d27e2f-r80000000800000-00006a93", "2f46a606d71edf02-6f54b6ce5dd92706-r20000000400000-00006a93",
                        "3b26a8e316b863a7-7f42e35652202021-r40000000400000-00006a93", "4ec8c3e108feb6b3-88ab215bd3b210fb-r40000000400000-00006a93",
                        "8d63edd4c45be56-443581949ca2d5c4-r10000000200000-00006a93", "9e228b1bae465ec1-749f25feabe532bf-r40000000800000-00006a93",
                        "14e489a90cacdf4f-5a3fa068b0e5ee0a-r40000000400000-00006a93", "39dfbc76496a3ce1-530bd54c6a497110-r20000000400000-00006a93",
                        "140c6c3bd5680c17-b5e6440b8f69f84f-r80000000800000-00006a93", "446706eecc53ceaa-fe33935271c33927-r20000000400000-00006a93",
                        "34772957f4e1b4cf-c1a87ce73877b6a2-r40000000400000-00006a93", "b48149d4637064bd-7bea09de2ebb25d3-r80000000800000-00006a93",
                        "bfdd1db2b7f31065-1fdd98a47a371116-r20000000400000-00006a93", "e03ac62fb721382d-a2de1a199830f54a-r20000000400000-00006a93",
                        "e6bd1f93000b847f-33b9e8698351579-r100000000800000-00006a93", "",
                        "", "",
                        "", "");
                }
                catch
                {
                    HornswoggleTxt = false;
                    notFound += "Hornswoggle_Txt" + Environment.NewLine + "";
                }
            }
            else if (RealDealKidTxt)
            {
                try
                {
                    ReplaceTextures(@"\_RealDeal_Kid\", "1f104e99ff1b85cb-afe73a5a25d27e2f-r80000000800000-00006a93", "2f46a606d71edf02-6f54b6ce5dd92706-r20000000400000-00006a93",
                        "3b26a8e316b863a7-7f42e35652202021-r40000000400000-00006a93", "4ec8c3e108feb6b3-88ab215bd3b210fb-r40000000400000-00006a93",
                        "8d63edd4c45be56-443581949ca2d5c4-r10000000200000-00006a93", "9e228b1bae465ec1-749f25feabe532bf-r40000000800000-00006a93",
                        "14e489a90cacdf4f-5a3fa068b0e5ee0a-r40000000400000-00006a93", "39dfbc76496a3ce1-530bd54c6a497110-r20000000400000-00006a93",
                        "140c6c3bd5680c17-b5e6440b8f69f84f-r80000000800000-00006a93", "446706eecc53ceaa-fe33935271c33927-r20000000400000-00006a93",
                        "34772957f4e1b4cf-c1a87ce73877b6a2-r40000000400000-00006a93", "",
                        "bfdd1db2b7f31065-1fdd98a47a371116-r20000000400000-00006a93", "e03ac62fb721382d-a2de1a199830f54a-r20000000400000-00006a93",
                        "", "1fb5003a8b9c2665-5d6ec658e24553f3-r10000000400000-00006a93",
                        "", "bb06f488e7aab9f3-6ca41bd2a8faddd-r40000000400000-00006a93",
                        "", "");
                }
                catch
                {
                    RealDealKidTxt = false;
                    notFound += "RealDealKidTxt" + Environment.NewLine + "";
                }
            }


            #endregion

            #region Ty [0A]

            RemoveTextures("1db5f5a543646f3c-adc596bc0be21738-r80000000400000-00006a93", "5e5f84b97e9d4864-aec2d479c2b77267-r20000000400000-00006a93",
                    "40fd50f87521514-40110b94525cffd7-r40000000400000-00006a93", "4097f1a3a5330721-35f074cc8674b46d-r40000000400000-00006a93",
                    "508931c41ec186be-2b11c51be3c7800-r40000000400000-00006a93", "cabd9e0f6a74468f-cc46c4c8eb4d6dc6-r20000000400000-00006a93",
                    "d247c28b9b02a225-dd2f27eaa281af88-r80000000800000-00006a93", "de1dd979317e7f7d-cf88089249c06c3c-r20000000400000-00006a93",
                    "df07575aa4e2f872-88fbc483c847753e-r80000000800000-00006a93", "ed6a7a5e16fcda15-d5bec197b42517a-r20000000400000-00006a93",
                    "f73190041821b133-ee0baaae3d4fa068-r80000000800000-00006a93", "5f89f124d6825bc7-316a31479fef936e-r40000000400000-00006a93",
                    "9beb8d736160811-596d975042868625-r40000000400000-00006a93", "9056a27ae83de857-630c64e6d313e359-r40000000400000-00006a93",
                    "72576a1848d580f5-bbfd2dd673586c03-r40000000800000-00006a93", "",
                    "", "",
                    "", "");

            if (TYCleanClothesTxt)
            {
                try
                {
                    ReplaceTextures(@"\_TY clean clothes\", "1db5f5a543646f3c-adc596bc0be21738-r80000000400000-00006a93", "5e5f84b97e9d4864-aec2d479c2b77267-r20000000400000-00006a93",
                        "40fd50f87521514-40110b94525cffd7-r40000000400000-00006a93", "4097f1a3a5330721-35f074cc8674b46d-r40000000400000-00006a93",
                        "508931c41ec186be-2b11c51be3c7800-r40000000400000-00006a93", "cabd9e0f6a74468f-cc46c4c8eb4d6dc6-r20000000400000-00006a93",
                        "d247c28b9b02a225-dd2f27eaa281af88-r80000000800000-00006a93", "de1dd979317e7f7d-cf88089249c06c3c-r20000000400000-00006a93",
                        "df07575aa4e2f872-88fbc483c847753e-r80000000800000-00006a93", "ed6a7a5e16fcda15-d5bec197b42517a-r20000000400000-00006a93",
                        "f73190041821b133-ee0baaae3d4fa068-r80000000800000-00006a93", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "");
                }
                catch
                {
                    TYCleanClothesTxt = false;
                    notFound += "TYCleanClothesTxt" + Environment.NewLine + "";
                }
            }
            else if (SWAG_TyTxt)
            {
                try
                {
                    ReplaceTextures(@"\_SWAGTy\", "", "5e5f84b97e9d4864-aec2d479c2b77267-r20000000400000-00006a93",
                        "40fd50f87521514-40110b94525cffd7-r40000000400000-00006a93", "4097f1a3a5330721-35f074cc8674b46d-r40000000400000-00006a93",
                        "508931c41ec186be-2b11c51be3c7800-r40000000400000-00006a93", "",
                        "d247c28b9b02a225-dd2f27eaa281af88-r80000000800000-00006a93", "de1dd979317e7f7d-cf88089249c06c3c-r20000000400000-00006a93",
                        "df07575aa4e2f872-88fbc483c847753e-r80000000800000-00006a93", "ed6a7a5e16fcda15-d5bec197b42517a-r20000000400000-00006a93",
                        "f73190041821b133-ee0baaae3d4fa068-r80000000800000-00006a93", "5f89f124d6825bc7-316a31479fef936e-r40000000400000-00006a93",
                        "9beb8d736160811-596d975042868625-r40000000400000-00006a93", "9056a27ae83de857-630c64e6d313e359-r40000000400000-00006a93",
                        "72576a1848d580f5-bbfd2dd673586c03-r40000000800000-00006a93", "",
                        "", "",
                        "", "");
                }
                catch
                {
                    SWAG_TyTxt = false;
                    notFound += "SWAG_TyTxt" + Environment.NewLine + "";
                }
            }

            #endregion

            #region Miguel [0B]

            RemoveTextures("9cf17f90a784a68d-aa6f9a990c990b78-r80000000800000-00006a93", "e40ce99e693ba6fa-5099b06b21a57886-r80000000800000-00006a93",
                    "e5008ef7986be03-eddd5bff14c9f3bd-r40000000400000-00006a93", "87fd17a0e9ce5383-8c12c10d3114ae46-r100000001000000-00006a93",
                    "", "",
                    "", "",
                    "", "",
                    "", "",
                    "", "",
                    "", "",
                    "", "",
                    "", "");

            if (FlamingMiguelTxt)
            {
                try
                {
                    ReplaceTextures(@"\_flaming miguel\", "9cf17f90a784a68d-aa6f9a990c990b78-r80000000800000-00006a93", "e40ce99e693ba6fa-5099b06b21a57886-r80000000800000-00006a93",
                        "e5008ef7986be03-eddd5bff14c9f3bd-r40000000400000-00006a93", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "");
                }
                catch
                {
                    FlamingMiguelTxt = false;
                    notFound += "FlamingMiguelTxt" + Environment.NewLine + "";
                }
            }
            else if (X2000PopMiguelTxt)
            {
                try
                {
                    ReplaceTextures(@"\_2000_Pop_Miguel\", "9cf17f90a784a68d-aa6f9a990c990b78-r80000000800000-00006a93", "e40ce99e693ba6fa-5099b06b21a57886-r80000000800000-00006a93",
                        "e5008ef7986be03-eddd5bff14c9f3bd-r40000000400000-00006a93", "87fd17a0e9ce5383-8c12c10d3114ae46-r100000001000000-00006a93",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "");
                }
                catch
                {
                    X2000PopMiguelTxt = false;
                    notFound += "X2000PopMiguelTxt" + Environment.NewLine + "";
                }
            }

            #endregion

            #region Ramon [0C]

            RemoveTextures("9abf34f81757c523-59f50570766114a7-r80000000800000-00006a93", "77c17e9b85ad6e66-ec7b3f56ba4d72b1-r80000000800000-00006a94",
                    "86cc48af2b03d35a-b6b0d73f83bc9369-r80000000800000-00006a94", "924f874ad79131e4-69f5c573a6d81b84-r80000000800000-00006a94",
                    "a55b9b52a2cf192-331f68e6382b7091-r100000001000000-00006a93", "d1acb648d3708dca-77c6c28634183961-r80000000400000-00006a93",
                    "ec0b227cf0dfa058-ac55f79a98843fe7-r80000000800000-00006a93", "",
                    "", "",
                    "", "",
                    "", "",
                    "", "",
                    "", "",
                    "", "");

            if (KoolRamonTxt)
            {
                try
                {
                    ReplaceTextures(@"\_kool ramon\", "9abf34f81757c523-59f50570766114a7-r80000000800000-00006a93", "77c17e9b85ad6e66-ec7b3f56ba4d72b1-r80000000800000-00006a94",
                        "86cc48af2b03d35a-b6b0d73f83bc9369-r80000000800000-00006a94", "924f874ad79131e4-69f5c573a6d81b84-r80000000800000-00006a94",
                        "a55b9b52a2cf192-331f68e6382b7091-r100000001000000-00006a93", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "");
                }
                catch
                {
                    KoolRamonTxt = false;
                    notFound += "KoolRamonTxt" + Environment.NewLine + "";
                }
            }
            else if (RamonSkin2)
            {
                try
                {
                    ReplaceTextures(@"\_Tengu from the Hood\", "9abf34f81757c523-59f50570766114a7-r80000000800000-00006a93", "77c17e9b85ad6e66-ec7b3f56ba4d72b1-r80000000800000-00006a94",
                        "86cc48af2b03d35a-b6b0d73f83bc9369-r80000000800000-00006a94", "924f874ad79131e4-69f5c573a6d81b84-r80000000800000-00006a94",
                        "a55b9b52a2cf192-331f68e6382b7091-r100000001000000-00006a93", "d1acb648d3708dca-77c6c28634183961-r80000000400000-00006a93",
                        "ec0b227cf0dfa058-ac55f79a98843fe7-r80000000800000-00006a93", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "");
                }
                catch
                {
                    RamonSkin2 = false;
                    notFound += "Tengu from the Hood" + Environment.NewLine + "";
                }
            }

            #endregion

            #region Jose [0D]

            RemoveTextures("4af6990ea1183c4d-bcada34215775d32-r100000000800000-00006a93", "4d24627d00a1e4d9-8e1d2ebbc00b7f1c-r80000000800000-00006a93",
                    "8c73ba4344dcf289-fb6d5cd0a1f6f6a6-r40000000400000-00006a93", "50ed3a4437415e29-458bf5ab2511b74d-r100000000800000-00006a93",
                    "96dfbe612372aced-8c22eb474d4d6fb6-r80000000800000-00006a93", "e685861a4081fe36-dd02cadb899216b2-r20000000200000-00006a94",
                    "1aa786893caf43e6-cf0e50c46e7e31a1-r40000000400000-00006a93", "296bf4918146a364-2f260fa6c1f9c520-r20000000400000-00006a93",
                    "b977f020e424372a-8e7340726e46d0d6-r20000000400000-00006a94", "",
                    "", "",
                    "", "",
                    "", "",
                    "", "",
                    "", "");

            if (JoseSkin)
            {
                try
                {
                    ReplaceTextures(@"\_JOSE worker\", "4af6990ea1183c4d-bcada34215775d32-r100000000800000-00006a93", "4d24627d00a1e4d9-8e1d2ebbc00b7f1c-r80000000800000-00006a93",
                        "8c73ba4344dcf289-fb6d5cd0a1f6f6a6-r40000000400000-00006a93", "50ed3a4437415e29-458bf5ab2511b74d-r100000000800000-00006a93",
                        "96dfbe612372aced-8c22eb474d4d6fb6-r80000000800000-00006a93", "e685861a4081fe36-dd02cadb899216b2-r20000000200000-00006a94",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "");
                }
                catch
                {
                    JoseSkin = false;
                    notFound += "JoseWorkerTxt" + Environment.NewLine + "";
                }
            }
            else if (JoseSkin2)
            {
                try
                {
                    ReplaceTextures(@"\_Ramirez_The_Hunter\", "1aa786893caf43e6-cf0e50c46e7e31a1-r40000000400000-00006a93", "4af6990ea1183c4d-bcada34215775d32-r100000000800000-00006a93",
                        "4d24627d00a1e4d9-8e1d2ebbc00b7f1c-r80000000800000-00006a93", "50ed3a4437415e29-458bf5ab2511b74d-r100000000800000-00006a93",
                        "96dfbe612372aced-8c22eb474d4d6fb6-r80000000800000-00006a93", "296bf4918146a364-2f260fa6c1f9c520-r20000000400000-00006a93",
                        "b977f020e424372a-8e7340726e46d0d6-r20000000400000-00006a94", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "");
                }
                catch
                {
                    JoseSkin2 = false;
                    notFound += "Ramirez_The_Hunter" + Environment.NewLine + "";
                }
            }

            #endregion

            #region Emilio [0E]

            RemoveTextures("8c814e1c17277823-384592bea6fda7a5-r100000000800000-00006a93", "496d65f96e5530b-4835973c46900714-r100000000800000-00006a93",
                    "43934d7d18908a00-29d760d3253ceef1-r100000000800000-00006a93", "a1f03385948a2cda-a7e0e3392771a7a8-r40000000400000-00006a93",
                    "b6498751f8ef528f-c0c1ee40c72b7cef-r40000000400000-00006a93", "1700960dc2e4604-2027708f645f6eea-r20000000400000-00006a94",
                    "", "",
                    "", "",
                    "", "",
                    "", "",
                    "", "",
                    "", "",
                    "", "");

            if (EmilioSkin)
            {
                try
                {
                    ReplaceTextures(@"\_emilio drip\", "8c814e1c17277823-384592bea6fda7a5-r100000000800000-00006a93", "496d65f96e5530b-4835973c46900714-r100000000800000-00006a93",
                        "43934d7d18908a00-29d760d3253ceef1-r100000000800000-00006a93", "a1f03385948a2cda-a7e0e3392771a7a8-r40000000400000-00006a93",
                        "b6498751f8ef528f-c0c1ee40c72b7cef-r40000000400000-00006a93", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "");
                }
                catch
                {
                    EmilioSkin = false;
                    notFound += "EmilioDripTxt" + Environment.NewLine + "";
                }
            }
            else if (GoldenGipsyTxt)
            {
                try
                {
                    ReplaceTextures(@"\_Golden_Gipsy\", "8c814e1c17277823-384592bea6fda7a5-r100000000800000-00006a93", "",
                        "43934d7d18908a00-29d760d3253ceef1-r100000000800000-00006a93", "a1f03385948a2cda-a7e0e3392771a7a8-r40000000400000-00006a93",
                        "b6498751f8ef528f-c0c1ee40c72b7cef-r40000000400000-00006a93", "1700960dc2e4604-2027708f645f6eea-r20000000400000-00006a94",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "");
                }
                catch
                {
                    GoldenGipsyTxt = false;
                    notFound += "GoldenGipsyTxt" + Environment.NewLine + "";
                }
            }

            #endregion

            #region Kadonashi [0F]

            RemoveTextures("5a2d6c3ea878f0d3-5405859754cb06b8-r40000000400000-00006a93", "9e7c3c46a153312b-2bd07b83006bbd3f-r20000000800000-00006a93",
                    "66c60e88026d3319-8c27b1ff4c53c4ed-r20000000200000-00006a93", "794a74088efba203-85739b749c07de82-r80000000800000-00006a93",
                    "2112b2b91bff9018-f7544489ffb794c7-r20000000400000-00006a93", "8304b7b05f720d2e-60f965c0326ee66c-r20000000400000-00006a93",
                    "17584b3fde2d1acd-64b30fc67e4e8776-r80000000800000-00006a93", "44029e24ff9879a6-6c0cc8a30a993bef-r100000001000000-00006a93",
                    "96830f5511fe4a72-2d83e0c43095a5d5-r10000000400000-00006a93", "a7bba5c5e58938a1-3c5fac4951b48627-r40000000800000-00006a93",
                    "a42003a04854c3f6-3a10bac0ed8f4410-r80000001000000-00006a93", "bb94c508803d9b43-77956d10a68490eb-r40000000800000-00006a93",
                    "cf09dd24570dee29-5cb1d5584b8bfce3-r80000000800000-00006a93", "dc8e07967ddab0e3-630838f549071f68-r10000000200000-00006a93",
                    "e44457e6865b423f-dd6dd2904145da30-r80000000800000-00006a93", "fee7dea638fd8325-931ad9b0f261c8b4-r40000000400000-00006a93",
                    "cd544a3be13aeee9-4fa4110e2587aaa5-r10000000200000-00006a93", "e0f8009c32ef205b-1900282f9a5d70a7-r10000000200000-00006a93",
                    "", "");

            if (KadonashiOGTxt)
            {
                try
                {
                    ReplaceTextures(@"\_kadonashi og\", "5a2d6c3ea878f0d3-5405859754cb06b8-r40000000400000-00006a93", "9e7c3c46a153312b-2bd07b83006bbd3f-r20000000800000-00006a93",
                        "66c60e88026d3319-8c27b1ff4c53c4ed-r20000000200000-00006a93", "794a74088efba203-85739b749c07de82-r80000000800000-00006a93",
                        "2112b2b91bff9018-f7544489ffb794c7-r20000000400000-00006a93", "8304b7b05f720d2e-60f965c0326ee66c-r20000000400000-00006a93",
                        "17584b3fde2d1acd-64b30fc67e4e8776-r80000000800000-00006a93", "44029e24ff9879a6-6c0cc8a30a993bef-r100000001000000-00006a93",
                        "96830f5511fe4a72-2d83e0c43095a5d5-r10000000400000-00006a93", "a7bba5c5e58938a1-3c5fac4951b48627-r40000000800000-00006a93",
                        "a42003a04854c3f6-3a10bac0ed8f4410-r80000001000000-00006a93", "bb94c508803d9b43-77956d10a68490eb-r40000000800000-00006a93",
                        "cf09dd24570dee29-5cb1d5584b8bfce3-r80000000800000-00006a93", "dc8e07967ddab0e3-630838f549071f68-r10000000200000-00006a93",
                        "e44457e6865b423f-dd6dd2904145da30-r80000000800000-00006a93", "fee7dea638fd8325-931ad9b0f261c8b4-r40000000400000-00006a93",
                        "", "",
                        "", "");
                }
                catch
                {
                    KadonashiOGTxt = false;
                    notFound += "KadonashiOGTxt" + Environment.NewLine + "";
                }
            }
            else if (RyuTxt)
            {
                try
                {
                    ReplaceTextures(@"\_kadonashi-Ryu\", "9e7c3c46a153312b-2bd07b83006bbd3f-r20000000800000-00006a93", "794a74088efba203-85739b749c07de82-r80000000800000-00006a93",
                        "2112b2b91bff9018-f7544489ffb794c7-r20000000400000-00006a93", "8304b7b05f720d2e-60f965c0326ee66c-r20000000400000-00006a93",
                        "17584b3fde2d1acd-64b30fc67e4e8776-r80000000800000-00006a93", "44029e24ff9879a6-6c0cc8a30a993bef-r100000001000000-00006a93",
                        "96830f5511fe4a72-2d83e0c43095a5d5-r10000000400000-00006a93", "a7bba5c5e58938a1-3c5fac4951b48627-r40000000800000-00006a93",
                        "a42003a04854c3f6-3a10bac0ed8f4410-r80000001000000-00006a93", "cd544a3be13aeee9-4fa4110e2587aaa5-r10000000200000-00006a93",
                        "cf09dd24570dee29-5cb1d5584b8bfce3-r80000000800000-00006a93", "dc8e07967ddab0e3-630838f549071f68-r10000000200000-00006a93",
                        "e0f8009c32ef205b-1900282f9a5d70a7-r10000000200000-00006a93", "e44457e6865b423f-dd6dd2904145da30-r80000000800000-00006a93",
                        "fee7dea638fd8325-931ad9b0f261c8b4-r40000000400000-00006a93", "",
                        "", "",
                        "", "");
                }
                catch
                {
                    RyuTxt = false;
                    notFound += "RyuTxtxt" + Environment.NewLine + "";
                }
            }

            #endregion

            #region Regie [10]

            RemoveTextures("1b32adb0f67b2bf8-f47e3f4883aa5961-r40000000400000-00006a93", "6affcf9f1cea9fb1-be1a4a8ca56a9d2d-r80000001000000-00006a93",
                    "8b36143c462da926-cff889922a1d3750-r40000000400000-00006a93", "3fe6a8c0fd983b48-8312875d37d81c6e-r40000000400000-00006a93",
                    "48cf9b7fb2348ee1-434aa1f1aa9b9b97-r80000000800000-00006a93", "482e09fb1bc19a41-2f34dfb7d586dd47-r100000000800000-00006a93",
                    "754332f7e8e6f7ec-7dc21bf88b8098af-r40000000400000-00006a93", "a12260b0f5ddbda7-cf7cdc9047c0d3b1-r100000000800000-00006a93",
                    "d29f156e353e3981-3fc0e7d4619ed3c7-r40000000400000-00006a93", "",
                    "", "",
                    "", "",
                    "", "",
                    "", "",
                    "", "");

            if (RejinTxt)
            {
                try
                {
                    ReplaceTextures(@"\_rejin\", "1b32adb0f67b2bf8-f47e3f4883aa5961-r40000000400000-00006a93", "6affcf9f1cea9fb1-be1a4a8ca56a9d2d-r80000001000000-00006a93",
                        "8b36143c462da926-cff889922a1d3750-r40000000400000-00006a93", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "");
                }
                catch
                {
                    RejinTxt = false;
                    notFound += "RejinTxt" + Environment.NewLine + "";
                }
            }
            else if (SpiderManTxt)
            {
                try
                {
                    ReplaceTextures(@"\_Spider_Reggie\", "1b32adb0f67b2bf8-f47e3f4883aa5961-r40000000400000-00006a93", "3fe6a8c0fd983b48-8312875d37d81c6e-r40000000400000-00006a93",
                        "6affcf9f1cea9fb1-be1a4a8ca56a9d2d-r80000001000000-00006a93", "8b36143c462da926-cff889922a1d3750-r40000000400000-00006a93",
                        "48cf9b7fb2348ee1-434aa1f1aa9b9b97-r80000000800000-00006a93", "482e09fb1bc19a41-2f34dfb7d586dd47-r100000000800000-00006a93",
                        "754332f7e8e6f7ec-7dc21bf88b8098af-r40000000400000-00006a93", "a12260b0f5ddbda7-cf7cdc9047c0d3b1-r100000000800000-00006a93",
                        "d29f156e353e3981-3fc0e7d4619ed3c7-r40000000400000-00006a93", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "");
                }
                catch
                {
                    SpiderManTxt = false;
                    notFound += "SpiderManTxt" + Environment.NewLine + "";
                }
            }

            #endregion

            #region Zack [11]

            RemoveTextures("44a36fa552e41ec2-a22c38edb77a21e-r40000000800000-00006a93", "83fb2913f8f3b3fa-25e41c5576544e1e-r40000000400000-00006a93",
                    "780558d2582e5d35-b85a3efd4c52df4e-r100000000800000-00006a93", "ab67ca85e8daf87c-505a60e8a7719fd3-r40000000800000-00006a93",
                    "bbd6f28c652c54f7-2fa346e7cd1ed41b-r80000001000000-00006a93", "2ddd360082d75ec2-68d5659199a64f80-r100000000800000-00006a93",
                    "b01e17c6114503b5-59e7bbf08f2d720a-r40000000400000-00006a9", "fa2c3994fdeba83a-1f4a4e8943630745-r10000000200000-00006a93",
                    "b01e17c6114503b5-59e7bbf08f2d720a-r40000000400000-00006a93", "",
                    "", "",
                    "", "",
                    "", "",
                    "", "",
                    "", "");

            if (ZackSkin)
            {
                try
                {
                    ReplaceTextures(@"\_private Zach\", "44a36fa552e41ec2-a22c38edb77a21e-r40000000800000-00006a93", "83fb2913f8f3b3fa-25e41c5576544e1e-r40000000400000-00006a93",
                        "780558d2582e5d35-b85a3efd4c52df4e-r100000000800000-00006a93", "ab67ca85e8daf87c-505a60e8a7719fd3-r40000000800000-00006a93",
                        "bbd6f28c652c54f7-2fa346e7cd1ed41b-r80000001000000-00006a93", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "");
                }
                catch
                {
                    ZackSkin = false;
                    notFound += "ZackSkin" + Environment.NewLine + "";
                }
            }
            else if (ZackSkin2)
            {
                try
                {
                    ReplaceTextures(@"\_Einstein Disciple\", "2ddd360082d75ec2-68d5659199a64f80-r100000000800000-00006a93", "44a36fa552e41ec2-a22c38edb77a21e-r40000000800000-00006a93",
                        "83fb2913f8f3b3fa-25e41c5576544e1e-r40000000400000-00006a93", "780558d2582e5d35-b85a3efd4c52df4e-r100000000800000-00006a93",
                        "ab67ca85e8daf87c-505a60e8a7719fd3-r40000000800000-00006a93", "b01e17c6114503b5-59e7bbf08f2d720a-r40000000400000-00006a93",
                        "bbd6f28c652c54f7-2fa346e7cd1ed41b-r80000001000000-00006a93", "fa2c3994fdeba83a-1f4a4e8943630745-r10000000200000-00006a93",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "");
                }
                catch
                {
                    ZackSkin2 = false;
                    notFound += "Einstein Disciple" + Environment.NewLine + "";
                }
            }

            #endregion

            #region Colin [12]

            RemoveTextures("10c69d9b91e88b0e-6614694c39a75b7e-r80000001000000-00006a93", "82d4437b8872133a-5bcbd24cd6509694-r40000000400000-00006a93",
                    "5406d320e9e2736e-a25ffe14036adb1e-r40000000400000-00006a93", "9611d9e478039a10-30d26e3e2ce6f12f-r40000000800000-00006a93",
                    "c097c1f902fa4740-c2b4f52288c6d2b-r100000000800000-00006a93", "e7a28047e16cfc94-48f7b635ebb975e4-r40000000400000-00006a93",
                    "f280a5906da608c6-1af687d427343d2a-r100000000800000-00006a93", "f33bc65676f74e11-c2b0264dae7260d6-r80000000800000-00006a93",
                    "", "",
                    "", "",
                    "", "",
                    "", "",
                    "", "",
                    "", "");

            if (ColinSkin)
            {
                try
                {
                    ReplaceTextures(@"\_colin_burns_skater\", "10c69d9b91e88b0e-6614694c39a75b7e-r80000001000000-00006a93", "82d4437b8872133a-5bcbd24cd6509694-r40000000400000-00006a93",
                        "5406d320e9e2736e-a25ffe14036adb1e-r40000000400000-00006a93", "9611d9e478039a10-30d26e3e2ce6f12f-r40000000800000-00006a93",
                        "c097c1f902fa4740-c2b4f52288c6d2b-r100000000800000-00006a93", "e7a28047e16cfc94-48f7b635ebb975e4-r40000000400000-00006a93",
                        "f280a5906da608c6-1af687d427343d2a-r100000000800000-00006a93", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "");
                }
                catch
                {
                    ColinSkin = false;
                    notFound += "ColinBurnsSkaterSkin" + Environment.NewLine + "";
                }
            }
            else if (CollinHermitSchoolTxt)
            {
                try
                {
                    ReplaceTextures(@"\_collin hermit school\", "10c69d9b91e88b0e-6614694c39a75b7e-r80000001000000-00006a93", "82d4437b8872133a-5bcbd24cd6509694-r40000000400000-00006a93",
                        "", "9611d9e478039a10-30d26e3e2ce6f12f-r40000000800000-00006a93",
                        "c097c1f902fa4740-c2b4f52288c6d2b-r100000000800000-00006a93", "e7a28047e16cfc94-48f7b635ebb975e4-r40000000400000-00006a93",
                        "f280a5906da608c6-1af687d427343d2a-r100000000800000-00006a93", "f33bc65676f74e11-c2b0264dae7260d6-r80000000800000-00006a93",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "");
                }
                catch
                {
                    CollinHermitSchoolTxt = false;
                    notFound += "CollinHermitSchoolTxt" + Environment.NewLine + "";
                }
            }
            
            #endregion

            #region Jake [13]

            RemoveTextures("3a43aec82b03426b-3dacf49a92071570-000061d3", "5f011fcde02e97-a64217fef94c7459-000059d3",
                    "43cbfc9c2140ab48-8f9d143e95a8bb03-00005dd3", "237cc772a6c51fc-490ad29112fb4a3c-00005993",
                    "a107b0fe2e6a4190-a1e91efad4299065-00006213", "cb5871994808b252-2cb9f235d5176aed-r80000000800000-00006a93",
                    "e5912efc74d38b41-b6d68bf2a86cc95-00005553", "49cb428b8cf0424c-1c9b0158bb306568-000059d3",
                    "112ad25bcf6bc8bc-dd16516b75d16e0e-r40000000400000-00006a93", "",
                    "", "",
                    "", "",
                    "", "",
                    "", "",
                    "", "");

            if (JakeSkin)
            {
                try
                {
                    ReplaceTextures(@"\_gigolo Jake\", "3a43aec82b03426b-3dacf49a92071570-000061d3", "5f011fcde02e97-a64217fef94c7459-000059d3",
                        "43cbfc9c2140ab48-8f9d143e95a8bb03-00005dd3", "237cc772a6c51fc-490ad29112fb4a3c-00005993",
                        "a107b0fe2e6a4190-a1e91efad4299065-00006213", "cb5871994808b252-2cb9f235d5176aed-r80000000800000-00006a93",
                        "e5912efc74d38b41-b6d68bf2a86cc95-00005553", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "");
                }
                catch
                {
                    JakeSkin = false;
                    notFound += "GigoloJakeSkin" + Environment.NewLine + "";
                }
            }
            else if (KOFJakeTxt)
            {
                try
                {
                    ReplaceTextures(@"\_KOF Jake\", "3a43aec82b03426b-3dacf49a92071570-000061d3", "5f011fcde02e97-a64217fef94c7459-000059d3",
                        "43cbfc9c2140ab48-8f9d143e95a8bb03-00005dd3", "49cb428b8cf0424c-1c9b0158bb306568-000059d3",
                        "112ad25bcf6bc8bc-dd16516b75d16e0e-r40000000400000-00006a93", "237cc772a6c51fc-490ad29112fb4a3c-00005993",
                        "cb5871994808b252-2cb9f235d5176aed-r80000000800000-00006a93", "e5912efc74d38b41-b6d68bf2a86cc95-00005553",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "");
                }
                catch
                {
                    KOFJakeTxt = false;
                    notFound += "KOFJakeTxt" + Environment.NewLine + "";
                }
            }
            else if (MayorJakeHudsonTxt)
            {
                try
                {
                    ReplaceTextures(@"\_Mayor_Jake_Hudson\", "3a43aec82b03426b-3dacf49a92071570-000061d3", "5f011fcde02e97-a64217fef94c7459-000059d3",
                        "43cbfc9c2140ab48-8f9d143e95a8bb03-00005dd3", "",
                        "", "",
                        "cb5871994808b252-2cb9f235d5176aed-r80000000800000-00006a93", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "");
                }
                catch
                {
                    MayorJakeHudsonTxt = false;
                    notFound += "MayorJakeHudsonTxt" + Environment.NewLine + "";
                }
            }

            #endregion

            #region Tong Yoon [14]

            RemoveTextures("2e9f7a4ce3f6342b-6521dc1a82e4ad6b-r80000001000000-00006a93", "4a887f2f3a7da520-a20cb779d61b6d1b-r20000000400000-00006a94",
                    "4d40931a3607d9ad-694930780a096089-r40000000800000-00006a93", "56a1dae641fffcda-98ff04d93979ed2-r40000000800000-00006a93",
                    "37931afa92c48994-be5814f40a204074-r40000000400000-00006a94", "c2b717e375aefdfe-a74cde18b1e4a3f4-r100000001000000-00006a93",
                    "e1363c8a40b91dd8-3daaef0674401934-r80000001000000-00006a93", "fdeac323ba8eb01a-ed3f0f833e5c243e-r40000000800000-00006a93",
                    "5322b9dc07ac94ab-82f4cb4f5b473030-r80000000800000-00006a93", "",
                    "", "",
                    "", "",
                    "", "",
                    "", "",
                    "", "");

            if (TongYoonSkin)
            {
                try
                {
                    ReplaceTextures(@"\_modern tong yoon\", "2e9f7a4ce3f6342b-6521dc1a82e4ad6b-r80000001000000-00006a93", "4a887f2f3a7da520-a20cb779d61b6d1b-r20000000400000-00006a94",
                        "4d40931a3607d9ad-694930780a096089-r40000000800000-00006a93", "56a1dae641fffcda-98ff04d93979ed2-r40000000800000-00006a93",
                        "37931afa92c48994-be5814f40a204074-r40000000400000-00006a94", "c2b717e375aefdfe-a74cde18b1e4a3f4-r100000001000000-00006a93",
                        "e1363c8a40b91dd8-3daaef0674401934-r80000001000000-00006a93", "fdeac323ba8eb01a-ed3f0f833e5c243e-r40000000800000-00006a93",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "");
                }
                catch
                {
                    TongYoonSkin = false;
                    notFound += "ModernTongYoonTxt" + Environment.NewLine + "";
                }
            }
            else if (NegativeToonYoonTxt)
            {
                try
                {
                    ReplaceTextures(@"\_negative_toon_yoon\", "2e9f7a4ce3f6342b-6521dc1a82e4ad6b-r80000001000000-00006a93", "4a887f2f3a7da520-a20cb779d61b6d1b-r20000000400000-00006a94",
                        "4d40931a3607d9ad-694930780a096089-r40000000800000-00006a93", "56a1dae641fffcda-98ff04d93979ed2-r40000000800000-00006a93",
                        "37931afa92c48994-be5814f40a204074-r40000000400000-00006a94", "c2b717e375aefdfe-a74cde18b1e4a3f4-r100000001000000-00006a93",
                        "5322b9dc07ac94ab-82f4cb4f5b473030-r80000000800000-00006a93", "",
                        "e1363c8a40b91dd8-3daaef0674401934-r80000001000000-00006a93", "fdeac323ba8eb01a-ed3f0f833e5c243e-r40000000800000-00006a93",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "");
                }
                catch
                {
                    NegativeToonYoonTxt = false;
                    notFound += "NegativeToonYoonTxt" + Environment.NewLine + "";
                }
            }

            #endregion

            #region Grimm [15]

            RemoveTextures("2a971a5fe14f0dce-d3968ea08761486f-r80000001000000-00006a93", "9477fa0ac43a3405-7969e77b2386987b-r100000001000000-00006a93",
                    "2a038db5c921b69b-cef437048a99b79d-r40000000800000-00006a94", "8f71e05505dd440d-e9463a8922a3de8f-r40000000400000-00006a94",
                    "9477fa0ac43a3405-7969e77b2386987b-r100000001000000-00006a93", "9846d7b7840e931e-c0f6d449044cbc12-r80000000800000-00006a93",
                    "900293d5d1ae499a-a954ea92a71026f7-r100000001000000-00006a93", "9457770a5eb20ea2-b97771d85337ba01-r40000000400000-00006a93",
                    "a444ce4feffde8f2-67f645664440c523-r80000000800000-00006a93", "f3c6b9278cebfe78-6c59028ea47ac00e-r40000000400000-00006a94",
                    "", "",
                    "", "",
                    "", "",
                    "", "",
                    "", "");

            if (MountainGrimTxt)
            {
                try
                {
                    ReplaceTextures(@"\_mountain grim\", "2a971a5fe14f0dce-d3968ea08761486f-r80000001000000-00006a93", "9477fa0ac43a3405-7969e77b2386987b-r100000001000000-00006a93",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "");
                }
                catch
                {
                    MountainGrimTxt = false;
                    notFound += "MountainGrimTxt" + Environment.NewLine + "";
                }
            }
            else if (CyberpunkGrimmTxt)
            {
                try
                {
                    ReplaceTextures(@"\_Cyberpunk Grimm\", "2a038db5c921b69b-cef437048a99b79d-r40000000800000-00006a94", "2a971a5fe14f0dce-d3968ea08761486f-r80000001000000-00006a93",
                        "8f71e05505dd440d-e9463a8922a3de8f-r40000000400000-00006a94", "9477fa0ac43a3405-7969e77b2386987b-r100000001000000-00006a93",
                        "9846d7b7840e931e-c0f6d449044cbc12-r80000000800000-00006a93", "900293d5d1ae499a-a954ea92a71026f7-r100000001000000-00006a93",
                        "9457770a5eb20ea2-b97771d85337ba01-r40000000400000-00006a93", "a444ce4feffde8f2-67f645664440c523-r80000000800000-00006a93",
                        "f3c6b9278cebfe78-6c59028ea47ac00e-r40000000400000-00006a94", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "");
                }
                catch
                {
                    CyberpunkGrimmTxt = false;
                    notFound += "CyberpunkGrimmTxt" + Environment.NewLine + "";
                }
            }
            else if (CustomGrimmTxt)
            {
                try
                {
                    ReplaceTextures(@"\_CustomGrimm\", "", "2a971a5fe14f0dce-d3968ea08761486f-r80000001000000-00006a93",
                        "", "9477fa0ac43a3405-7969e77b2386987b-r100000001000000-00006a93",
                        "9846d7b7840e931e-c0f6d449044cbc12-r80000000800000-00006a93", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "");
                }
                catch
                {
                    CustomGrimmTxt = false;
                    notFound += "CustomGrimmTxt" + Environment.NewLine + "";
                }
            }

            #endregion

            #region BK [16]

            RemoveTextures("1b8dd0e685aaa5f7-8c53b890df6eb332-r80000001000000-00006a93", "1d267e8fe083d53-2fb85e5b79fd7c34-r80000000800000-00006a93",
                    "5d6b91d5792b8c2a-441ff50f375b4569-r80000000800000-00006a93", "6b7834025aab7b2c-1576f454233a907e-r80000001000000-00006a93",
                    "7a1403d64c30bab5-27cc9fdce3ff391f-r80000000800000-00006a93", "9d111f4ddba0a9a7-1f5d4d8b74c62ea4-r40000000400000-00006a94",
                    "9dd9010a85b85336-d5d8f9aade72bcef-r40000000400000-00006a93", "741ccf63d03a2ba6-36ae10213cd4efa8-r100000000800000-00006a93",
                    "", "",
                    "", "",
                    "", "",
                    "", "",
                    "", "",
                    "", "");

            if (BKSkin)
            {
                try
                {
                    ReplaceTextures(@"\_BK coach\", "1b8dd0e685aaa5f7-8c53b890df6eb332-r80000001000000-00006a93", "1d267e8fe083d53-2fb85e5b79fd7c34-r80000000800000-00006a93",
                        "5d6b91d5792b8c2a-441ff50f375b4569-r80000000800000-00006a93", "6b7834025aab7b2c-1576f454233a907e-r80000001000000-00006a93",
                        "7a1403d64c30bab5-27cc9fdce3ff391f-r80000000800000-00006a93", "9d111f4ddba0a9a7-1f5d4d8b74c62ea4-r40000000400000-00006a94",
                        "9dd9010a85b85336-d5d8f9aade72bcef-r40000000400000-00006a93", "741ccf63d03a2ba6-36ae10213cd4efa8-r100000000800000-00006a93",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "");
                }
                catch
                {
                    BKSkin = false;
                    notFound += "BKCoachTxt" + Environment.NewLine + "";
                }
            }
            else if (BKCJTxt)
            {
                try
                {
                    ReplaceTextures(@"\_CJ bk\", "1b8dd0e685aaa5f7-8c53b890df6eb332-r80000001000000-00006a93", "1d267e8fe083d53-2fb85e5b79fd7c34-r80000000800000-00006a93",
                        "5d6b91d5792b8c2a-441ff50f375b4569-r80000000800000-00006a93", "6b7834025aab7b2c-1576f454233a907e-r80000001000000-00006a93",
                        "7a1403d64c30bab5-27cc9fdce3ff391f-r80000000800000-00006a93", "9d111f4ddba0a9a7-1f5d4d8b74c62ea4-r40000000400000-00006a94",
                        "9dd9010a85b85336-d5d8f9aade72bcef-r40000000400000-00006a93", "741ccf63d03a2ba6-36ae10213cd4efa8-r100000000800000-00006a93",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "");
                }
                catch
                {
                    BKCJTxt = false;
                    notFound += "BK_CJ_Txt" + Environment.NewLine + "";
                }
            }

            #endregion

            #region Grave Digga' [17]

            RemoveTextures("5d9dab9b4da19b58-bb1042078bd02a19-r40000000400000-00006a93", "6a57ea379978e090-dc44ef25ac37ebf6-r80000000400000-00006a93",
                    "41c464d85a0f616f-6efe8135d2d1d98d-r80000000800000-00006a93", "128fc47272dbafac-326729d4dff109eb-r100000001000000-00006a93",
                    "8778633eb34cad7e-9f406c9beab8482c-r100000001000000-00006a93", "f02ab5df03de9d4e-41a2e44266161bd-r20000000200000-00006a94",
                    "2f961409e1167be-42d01f5fe7860f53-00005993", "b962788607137dc5-976602852e5db24c-r80000000400000-00006a93",
                    "", "",
                    "", "",
                    "", "",
                    "", "",
                    "", "",
                    "", "");

            if (GraveDiggaSkin)
            {
                try
                {
                    ReplaceTextures(@"\_KOF digga\", "5d9dab9b4da19b58-bb1042078bd02a19-r40000000400000-00006a93", "6a57ea379978e090-dc44ef25ac37ebf6-r80000000400000-00006a93",
                        "41c464d85a0f616f-6efe8135d2d1d98d-r80000000800000-00006a93", "128fc47272dbafac-326729d4dff109eb-r100000001000000-00006a93",
                        "8778633eb34cad7e-9f406c9beab8482c-r100000001000000-00006a93", "f02ab5df03de9d4e-41a2e44266161bd-r20000000200000-00006a94",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "");
                }
                catch
                {
                    GraveDiggaSkin = false;
                    notFound += "GraveDiggaSkin" + Environment.NewLine + "";
                }
            }
            else if (GraveDiggaSkin2)
            {
                try
                {
                    ReplaceTextures(@"\_Profaned Grave Digga\", "2f961409e1167be-42d01f5fe7860f53-00005993", "5d9dab9b4da19b58-bb1042078bd02a19-r40000000400000-00006a93",
                        "6a57ea379978e090-dc44ef25ac37ebf6-r80000000400000-00006a93", "41c464d85a0f616f-6efe8135d2d1d98d-r80000000800000-00006a93",
                        "128fc47272dbafac-326729d4dff109eb-r100000001000000-00006a93", "8778633eb34cad7e-9f406c9beab8482c-r100000001000000-00006a93",
                        "b962788607137dc5-976602852e5db24c-r80000000400000-00006a93", "f02ab5df03de9d4e-41a2e44266161bd-r20000000200000-00006a94",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "");
                }
                catch
                {
                    GraveDiggaSkin2 = false;
                    notFound += "Profaned Grave Digga" + Environment.NewLine + "";
                }
            }

            #endregion

            #region Bones [18]

            RemoveTextures("3db9b83298e6c0e5-7ca4bee43d6c7e97-r40000000400000-00006a93", "6ca41e8d6225b169-cd69356117756dd0-r40000000400000-00006a93",
                    "6e844cd5290ae8ef-c9093b392a769281-r100000001000000-00006a93", "7c3f9196d136c8db-adce96577abd1031-ra0000000400000-00006a93",
                    "62dc446f13e193b4-6d326367b66d85d-r10000000100000-00006a93", "65eac685edbf05a0-1558d8c740ec9dea-r20000000400000-00006a93",
                    "6980ca7ad5916f25-c6aa1b1e48abaf35-r80000000800000-00006a93", "c7313782bfc58e7b-b7411437f25cfe20-r80000000800000-00006a93",
                    "d20c18d0d3bb7d61-383cde95604d3da3-r40000000400000-00006a93", "e13590913dc97fe-7e4c00761f51c273-r100000001000000-00006a93",
                    "a056fe7f28cf2b63-17d29810a25380cc-r20000000200000-00006a93", "",
                    "90a054d1e5d725b8-50fc1bbce56b0198-r10000000100000-00006a93", "b12818d091ac0079-c834fa3b1213c51b-r40000000400000-00006a93",
                    "", "",
                    "", "",
                    "", "");

            if (BonesSkin)
            {
                try
                {
                    ReplaceTextures(@"\_young bones\", "3db9b83298e6c0e5-7ca4bee43d6c7e97-r40000000400000-00006a93", "6ca41e8d6225b169-cd69356117756dd0-r40000000400000-00006a93",
                        "6e844cd5290ae8ef-c9093b392a769281-r100000001000000-00006a93", "7c3f9196d136c8db-adce96577abd1031-ra0000000400000-00006a93",
                        "62dc446f13e193b4-6d326367b66d85d-r10000000100000-00006a93", "65eac685edbf05a0-1558d8c740ec9dea-r20000000400000-00006a93",
                        "6980ca7ad5916f25-c6aa1b1e48abaf35-r80000000800000-00006a93", "c7313782bfc58e7b-b7411437f25cfe20-r80000000800000-00006a93",
                        "d20c18d0d3bb7d61-383cde95604d3da3-r40000000400000-00006a93", "e13590913dc97fe-7e4c00761f51c273-r100000001000000-00006a93",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "");
                }
                catch
                {
                    BonesSkin = false;
                    notFound += "YoungBonesTxt" + Environment.NewLine + "";
                }
            }
            else if(HoboBonesTxt)
            {
                try
                {
                    ReplaceTextures(@"\_Hobones\", "3db9b83298e6c0e5-7ca4bee43d6c7e97-r40000000400000-00006a93", "6ca41e8d6225b169-cd69356117756dd0-r40000000400000-00006a93",
                        "6e844cd5290ae8ef-c9093b392a769281-r100000001000000-00006a93", "7c3f9196d136c8db-adce96577abd1031-ra0000000400000-00006a93",
                        "a056fe7f28cf2b63-17d29810a25380cc-r20000000200000-00006a93", "",
                        "6980ca7ad5916f25-c6aa1b1e48abaf35-r80000000800000-00006a93", "c7313782bfc58e7b-b7411437f25cfe20-r80000000800000-00006a93",
                        "d20c18d0d3bb7d61-383cde95604d3da3-r40000000400000-00006a93", "e13590913dc97fe-7e4c00761f51c273-r100000001000000-00006a93",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "");
                }
                catch
                {
                    HoboBonesTxt = false;
                    notFound += "HoboBonesTxt" + Environment.NewLine + "";
                }
            }
            else if (SantaBonesTxt)
            {
                try
                {
                    ReplaceTextures(@"\_Santa_Bones\", "3db9b83298e6c0e5-7ca4bee43d6c7e97-r40000000400000-00006a93", "6ca41e8d6225b169-cd69356117756dd0-r40000000400000-00006a93",
                        "6e844cd5290ae8ef-c9093b392a769281-r100000001000000-00006a93", "7c3f9196d136c8db-adce96577abd1031-ra0000000400000-00006a93",
                        "a056fe7f28cf2b63-17d29810a25380cc-r20000000200000-00006a93", "",
                        "6980ca7ad5916f25-c6aa1b1e48abaf35-r80000000800000-00006a93", "c7313782bfc58e7b-b7411437f25cfe20-r80000000800000-00006a93",
                        "d20c18d0d3bb7d61-383cde95604d3da3-r40000000400000-00006a93", "e13590913dc97fe-7e4c00761f51c273-r100000001000000-00006a93",
                        "", "",
                        "62dc446f13e193b4-6d326367b66d85d-r10000000100000-00006a93", "65eac685edbf05a0-1558d8c740ec9dea-r20000000400000-00006a93",
                        "90a054d1e5d725b8-50fc1bbce56b0198-r10000000100000-00006a93", "b12818d091ac0079-c834fa3b1213c51b-r40000000400000-00006a93",
                        "", "",
                        "", "");
                }
                catch
                {
                    SantaBonesTxt = false;
                    notFound += "SantaBonesTxt" + Environment.NewLine + "";
                }
            }

            #endregion

            #region Booma [19]

            RemoveTextures("6d481ce1400af6ad-15c0e8249a8ba6ef-r100000001000000-00006a93", "28ce97a801585b56-d30c47e273d327e5-r80000000800000-00006a93",
                    "66f47c201bfa377c-34aa2674f6262d2b-r40000000400000-00006a93", "403f88b59dfb8c35-3110fe39061f97ae-r40000000400000-00006a93",
                    "91831cd8e81c0f8c-c75ab5a3aa2b9db6-r100000001000000-00006a93", "60469000e1041c53-48fcdbb134712d23-r100000001000000-00006a93",
                    "dcb015744d451779-406bdc32aed262f8-r80000000800000-00006a93", "e66c31da67a905b6-5a02cd2bb5e5e32f-r40000000400000-00006a93",
                    "", "",
                    "", "",
                    "", "",
                    "", "",
                    "", "",
                    "", "");

            if (BoomaSurgeonTxt)
            {
                try
                {
                    ReplaceTextures(@"\_booma surgeon\", "6d481ce1400af6ad-15c0e8249a8ba6ef-r100000001000000-00006a93", "28ce97a801585b56-d30c47e273d327e5-r80000000800000-00006a93",
                        "66f47c201bfa377c-34aa2674f6262d2b-r40000000400000-00006a93", "403f88b59dfb8c35-3110fe39061f97ae-r40000000400000-00006a93",
                        "91831cd8e81c0f8c-c75ab5a3aa2b9db6-r100000001000000-00006a93", "60469000e1041c53-48fcdbb134712d23-r100000001000000-00006a93",
                        "dcb015744d451779-406bdc32aed262f8-r80000000800000-00006a93", "e66c31da67a905b6-5a02cd2bb5e5e32f-r40000000400000-00006a93",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "");
                }
                catch
                {
                    BoomaSurgeonTxt = false;
                    notFound += "BoomaSurgeonTxt" + Environment.NewLine + "";
                }
            }
            else if (BoomaSkin2)
            {
                try
                {
                    ReplaceTextures(@"\_Irak_Booma\", "6d481ce1400af6ad-15c0e8249a8ba6ef-r100000001000000-00006a93", "28ce97a801585b56-d30c47e273d327e5-r80000000800000-00006a93",
                        "66f47c201bfa377c-34aa2674f6262d2b-r40000000400000-00006a93", "403f88b59dfb8c35-3110fe39061f97ae-r40000000400000-00006a93",
                        "91831cd8e81c0f8c-c75ab5a3aa2b9db6-r100000001000000-00006a93", "60469000e1041c53-48fcdbb134712d23-r100000001000000-00006a93",
                        "dcb015744d451779-406bdc32aed262f8-r80000000800000-00006a93", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "");
                }
                catch
                {
                    BoomaSkin2 = false;
                    notFound += "Irak_Booma" + Environment.NewLine + "";
                }
            }

            #endregion

            #region Busta [1A]

            RemoveTextures("5aedb781c2c59b3-62ec6447a55436be-r40000000400000-00006a94", "6e656bc9d49c1e68-36a67077e728a4ee-r80000000800000-00006a93",
                    "7c181b2d9936e994-d794490389b9489d-r100000001000000-00006a93", "b2dc31b789ad6713-5a20dafe38e4aa3a-r40000000400000-00006a94",
                    "baafc5acf29ecb20-35cc453fda3dee8f-r80000000800000-00006a93", "ee79dc1a9608d72f-8beaeb586291a5dd-r40000000400000-00006a93",
                    "", "",
                    "", "",
                    "", "",
                    "", "",
                    "", "",
                    "", "",
                    "", "");

            if (BustaSkin)
            {
                try
                {
                    ReplaceTextures(@"\_Busta from the hood\", "5aedb781c2c59b3-62ec6447a55436be-r40000000400000-00006a94", "6e656bc9d49c1e68-36a67077e728a4ee-r80000000800000-00006a93",
                        "7c181b2d9936e994-d794490389b9489d-r100000001000000-00006a93", "b2dc31b789ad6713-5a20dafe38e4aa3a-r40000000400000-00006a94",
                        "baafc5acf29ecb20-35cc453fda3dee8f-r80000000800000-00006a93", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "");
                }
                catch
                {
                    BustaSkin = false;
                    notFound += "BustafromthehoodSkin" + Environment.NewLine + "";
                }
            }
            else if (BustaSkin2)
            {
                try
                {
                    ReplaceTextures(@"\_Wolf_Busta\", "5aedb781c2c59b3-62ec6447a55436be-r40000000400000-00006a94", "6e656bc9d49c1e68-36a67077e728a4ee-r80000000800000-00006a93",
                        "7c181b2d9936e994-d794490389b9489d-r100000001000000-00006a93", "b2dc31b789ad6713-5a20dafe38e4aa3a-r40000000400000-00006a94",
                        "baafc5acf29ecb20-35cc453fda3dee8f-r80000000800000-00006a93", "ee79dc1a9608d72f-8beaeb586291a5dd-r40000000400000-00006a93",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "");
                }
                catch
                {
                    BustaSkin2 = false;
                    notFound += "Wolf_Busta" + Environment.NewLine + "";
                }
            }

            #endregion

            #region Spider [1B]

            RemoveTextures("55d009558bc079b0-35c230ec46b488c2-r80000000800000-00006a93", "78f993f1e21a2be5-4e6c1f5003770d9b-r40000000400000-00006a93",
                    "6784e5ce7e07d2d2-ab0f7d9696a91fec-r80000000800000-00006a93", "b8240db504379cce-986ead98b3986ae0-r100000001000000-00006a93",
                    "bb9b171d16a6d926-15ffca26c295400e-r40000000400000-00006a93", "ec969c53bc24a13c-8b0cf146ee7dbc8d-r100000001000000-00006a93",
                    "f7add786f9c37724-2dfef7baff30152f-r40000000400000-00006a94", "",
                    "", "",
                    "", "",
                    "", "",
                    "", "",
                    "", "",
                    "", "");

            if (SpiderSkin)
            {
                try
                {
                    ReplaceTextures(@"\_SpiderOfChaos\", "55d009558bc079b0-35c230ec46b488c2-r80000000800000-00006a93", "78f993f1e21a2be5-4e6c1f5003770d9b-r40000000400000-00006a93",
                        "6784e5ce7e07d2d2-ab0f7d9696a91fec-r80000000800000-00006a93", "b8240db504379cce-986ead98b3986ae0-r100000001000000-00006a93",
                        "bb9b171d16a6d926-15ffca26c295400e-r40000000400000-00006a93", "ec969c53bc24a13c-8b0cf146ee7dbc8d-r100000001000000-00006a93",
                        "f7add786f9c37724-2dfef7baff30152f-r40000000400000-00006a94", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "");
                }
                catch
                {
                    SpiderSkin = false;
                    notFound += "SpiderOfChaosTxt" + Environment.NewLine + "";
                }
            }
            else if (SpiderSkin2)
            {
                try
                {
                    ReplaceTextures(@"\_Rad_Spider\", "55d009558bc079b0-35c230ec46b488c2-r80000000800000-00006a93", "78f993f1e21a2be5-4e6c1f5003770d9b-r40000000400000-00006a93",
                        "6784e5ce7e07d2d2-ab0f7d9696a91fec-r80000000800000-00006a93", "b8240db504379cce-986ead98b3986ae0-r100000001000000-00006a93",
                        "ec969c53bc24a13c-8b0cf146ee7dbc8d-r100000001000000-00006a93", "f7add786f9c37724-2dfef7baff30152f-r40000000400000-00006a94",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "");
                }
                catch
                {
                    SpiderSkin2 = false;
                    notFound += "Rad_Spider" + Environment.NewLine + "";
                }
            }

            #endregion

            #region Pain Killah [1C]

            RemoveTextures("1d8b9186a0dfe77-b572b09159efe539-r40000000400000-00006a94", "1f69d1dc5fc3725a-e55be97d042943cd-r80000000800000-00006a94",
                    "7f6eb1731e0073e1-3486c94b2c5e063e-r80000000800000-00006a94", "9bbf2b1bd0ecdf7b-ade0b50324bbda99-r80000000800000-00006a93",
                    "27a2c9ad5ca2d98f-6a0a20f39fde277f-r80000000800000-00006a93", "73c193166c1e3841-d5803d554f530bcf-r40000000400000-00006a93",
                    "94d119c08098e7b2-3d476688c6e2fc7d-r40000000800000-00006a93", "a2d01cc5bcbd5980-f935c62ae87f4924-r80000000400000-00006a94",
                    "b4d358a5b7bc2c62-f9eae1b4d65dd471-r40000000800000-00006a94", "c19fdd46c3a41c8c-4601f9a954e5dbb3-r40000000400000-00006a94",
                    "d4c65cd4ba196302-9cc8fed765e7b613-r40000000800000-00006a94", "",
                    "", "",
                    "", "",
                    "", "",
                    "", "");

            if (PainKillahSkin)
            {
                try
                {
                    ReplaceTextures(@"\_Dragon_Killah\", "1d8b9186a0dfe77-b572b09159efe539-r40000000400000-00006a94", "1f69d1dc5fc3725a-e55be97d042943cd-r80000000800000-00006a94",
                        "7f6eb1731e0073e1-3486c94b2c5e063e-r80000000800000-00006a94", "9bbf2b1bd0ecdf7b-ade0b50324bbda99-r80000000800000-00006a93",
                        "27a2c9ad5ca2d98f-6a0a20f39fde277f-r80000000800000-00006a93", "73c193166c1e3841-d5803d554f530bcf-r40000000400000-00006a93",
                        "94d119c08098e7b2-3d476688c6e2fc7d-r40000000800000-00006a93", "a2d01cc5bcbd5980-f935c62ae87f4924-r80000000400000-00006a94",
                        "b4d358a5b7bc2c62-f9eae1b4d65dd471-r40000000800000-00006a94", "c19fdd46c3a41c8c-4601f9a954e5dbb3-r40000000400000-00006a94",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "");
                }
                catch
                {
                    PainKillahSkin = false;
                    notFound += "Dragon_KillahSkin" + Environment.NewLine + "";
                }
            }
            else if (PainKillahSkin2)
            {
                try
                {
                    ReplaceTextures(@"\_Pain_Chillah\", "1d8b9186a0dfe77-b572b09159efe539-r40000000400000-00006a94", "1f69d1dc5fc3725a-e55be97d042943cd-r80000000800000-00006a94",
                    "7f6eb1731e0073e1-3486c94b2c5e063e-r80000000800000-00006a94", "9bbf2b1bd0ecdf7b-ade0b50324bbda99-r80000000800000-00006a93",
                        "94d119c08098e7b2-3d476688c6e2fc7d-r40000000800000-00006a93", "b4d358a5b7bc2c62-f9eae1b4d65dd471-r40000000800000-00006a94",
                        "d4c65cd4ba196302-9cc8fed765e7b613-r40000000800000-00006a94", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "");
                }
                catch
                {
                    PainKillahSkin2 = false;
                    notFound += "Pain_Chillah" + Environment.NewLine + "";
                }
            }

            #endregion

            #region Dwayne [1E]

            RemoveTextures("93f6a4ac2127763a-755c4c2b85259c74-r80000000800000-00006a94", "110fcade31d975f6-e7e6e97f73934c8f-r40000000400000-00006a93",
                    "1203004c6e3dab64-36b960bf90fd7d1d-r80000000800000-00006a94", "a7bba76aede71014-38509e86eec3f5d0-r80000000400000-00006a94",
                    "cdd9fcf93090044a-36d259750533e3ae-r40000000200000-00006a94", "d6d926e1cd4ef2c2-a6fd7193bf61698e-r80000000800000-00006a93",
                    "e9830bb29d703a0f-6cfdb9c2ca3852e5-r40000000400000-00006a94", "6fa9346f5cc904df-3c8c7d7c4917b6c2-r100000001000000-00006a93",
                    "", "",
                    "", "",
                    "", "",
                    "", "",
                    "", "",
                    "", "");

            if (DwayneSkin)
            {
                try
                {
                    ReplaceTextures(@"\_Oni_Dwayne\", "6fa9346f5cc904df-3c8c7d7c4917b6c2-r100000001000000-00006a93", "93f6a4ac2127763a-755c4c2b85259c74-r80000000800000-00006a94",
                        "110fcade31d975f6-e7e6e97f73934c8f-r40000000400000-00006a93", "1203004c6e3dab64-36b960bf90fd7d1d-r80000000800000-00006a94",
                        "cdd9fcf93090044a-36d259750533e3ae-r40000000200000-00006a94", "d6d926e1cd4ef2c2-a6fd7193bf61698e-r80000000800000-00006a93",
                        "e9830bb29d703a0f-6cfdb9c2ca3852e5-r40000000400000-00006a94", "a7bba76aede71014-38509e86eec3f5d0-r80000000400000-00006a94",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "");
                }
                catch
                {
                    DwayneSkin = false;
                    notFound += "OniDwayneSkin" + Environment.NewLine + "";
                }
            }
            else if (CyberDwayneTxt)
            {
                try
                {
                    ReplaceTextures(@"\_cyber dwayne\", "93f6a4ac2127763a-755c4c2b85259c74-r80000000800000-00006a94", "110fcade31d975f6-e7e6e97f73934c8f-r40000000400000-00006a93",
                        "1203004c6e3dab64-36b960bf90fd7d1d-r80000000800000-00006a94", "a7bba76aede71014-38509e86eec3f5d0-r80000000400000-00006a94",
                        "cdd9fcf93090044a-36d259750533e3ae-r40000000200000-00006a94", "d6d926e1cd4ef2c2-a6fd7193bf61698e-r80000000800000-00006a93",
                        "e9830bb29d703a0f-6cfdb9c2ca3852e5-r40000000400000-00006a94", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "");
                }
                catch
                {
                    DwayneSkin = false;
                    notFound += "CyberDwayneTxt" + Environment.NewLine + "";
                }
            }


            #endregion

            #region Shun Ying Lee [1F]

            RemoveTextures("1aad9b1c427c4f99-e690ed12d717504d-r80000000800000-00006a93", "3a88ccbadbb6301f-a3add64695ccdae-r80000000400000-00006a93",
                    "3ed2b764ee5e7275-86bd307b26e90902-r20000000400000-00006a93", "5f073a7797e1cf95-934fcf8faa581322-r20000000400000-00006a93",
                    "7be573c39a639f2d-f203483984226051-r80000000800000-00006a93", "91d27be083301d2f-928e29ba657ac36d-r40000000400000-00006a93",
                    "523b16ec9f0ee37c-3c9628f705770df9-r80000000800000-00006a93", "803d49a37daa111b-270156e009e501bd-r100000000800000-00006a93",
                    "3919a728279eef97-7812d0059070757b-r40000000400000-00006a93", "639269b29a652970-c06ef5033ca600c3-r80000000400000-00006a93",
                    "a85cd2eac1461ec7-dec8e50c83674a2d-r20000000400000-00006a93", "af3f1791c4f50e11-12f27bb7b7bad4e6-r40000000400000-00006a93",
                    "d29989c8cc266151-6ec5664a4c0f9333-r80000000800000-00006a93", "db41c0bc7c6b6a58-e0002082f32e5eb3-r40000000400000-00006a93",
                    "fee80ccd11d53cb1-461c9cde32a609af-r20000000400000-00006a93", "5a918455378fd338-4f6cb8cb2ff0f729-r20000000400000-00006a93",
                    "bd6e250e1422ed7f-1e23bb6981f87a83-r20000000200000-00006a93", "dc8e07967ddab0e3-630838f549071f68-r10000000200000-00006a93",
                    "f3631822c326670b-7a9c0a4c6149354b-r20000000400000-00006a93", "435117438ec31d17-17a0afa22800aa1e-r40000000400000-00006a93");

            RemoveTextures("15e94b9c0901ae3f-4d69c2ef60a0b2c0-r40000000400000-00006a93", "",
                    "", "",
                    "", "",
                    "", "",
                    "", "",
                    "", "",
                    "", "",
                    "", "",
                    "", "",
                    "", "");


            if (FashionShunYingTxt)
            {
                try
                {
                    ReplaceTextures(@"\_fashion_Shun_Ying\", "3ed2b764ee5e7275-86bd307b26e90902-r20000000400000-00006a93", "5a918455378fd338-4f6cb8cb2ff0f729-r20000000400000-00006a93",
                        "5f073a7797e1cf95-934fcf8faa581322-r20000000400000-00006a93", "7be573c39a639f2d-f203483984226051-r80000000800000-00006a93",
                        "91d27be083301d2f-928e29ba657ac36d-r40000000400000-00006a93", "803d49a37daa111b-270156e009e501bd-r100000000800000-00006a93",
                        "3919a728279eef97-7812d0059070757b-r40000000400000-00006a93", "a85cd2eac1461ec7-dec8e50c83674a2d-r20000000400000-00006a93",
                        "bd6e250e1422ed7f-1e23bb6981f87a83-r20000000200000-00006a93", "d29989c8cc266151-6ec5664a4c0f9333-r80000000800000-00006a93",
                        "dc8e07967ddab0e3-630838f549071f68-r10000000200000-00006a93", "f3631822c326670b-7a9c0a4c6149354b-r20000000400000-00006a93",
                        "fee80ccd11d53cb1-461c9cde32a609af-r20000000400000-00006a93", "",
                        "", "",
                        "", "",
                        "", "");
                }
                catch
                {
                    FashionShunYingTxt = false;
                    notFound += "FashionShunYingTxt" + Environment.NewLine + "";
                }
            }
            else if (AyaneShunYingTxt)
            {
                try
                {
                    ReplaceTextures(@"\_ayane shun ying\", "1aad9b1c427c4f99-e690ed12d717504d-r80000000800000-00006a93", "3a88ccbadbb6301f-a3add64695ccdae-r80000000400000-00006a93",
                        "3ed2b764ee5e7275-86bd307b26e90902-r20000000400000-00006a93", "5f073a7797e1cf95-934fcf8faa581322-r20000000400000-00006a93",
                        "7be573c39a639f2d-f203483984226051-r80000000800000-00006a93", "91d27be083301d2f-928e29ba657ac36d-r40000000400000-00006a93",
                        "523b16ec9f0ee37c-3c9628f705770df9-r80000000800000-00006a93", "803d49a37daa111b-270156e009e501bd-r100000000800000-00006a93",
                        "3919a728279eef97-7812d0059070757b-r40000000400000-00006a93", "639269b29a652970-c06ef5033ca600c3-r80000000400000-00006a93",
                        "a85cd2eac1461ec7-dec8e50c83674a2d-r20000000400000-00006a93", "af3f1791c4f50e11-12f27bb7b7bad4e6-r40000000400000-00006a93",
                        "d29989c8cc266151-6ec5664a4c0f9333-r80000000800000-00006a93", "db41c0bc7c6b6a58-e0002082f32e5eb3-r40000000400000-00006a93",
                        "fee80ccd11d53cb1-461c9cde32a609af-r20000000400000-00006a93", "",
                        "", "",
                        "", "");
                }
                catch
                {
                    AyaneShunYingTxt = false;
                    notFound += "AyaneShunYingTxt" + Environment.NewLine + "";
                }
            }
            else if (ShunYingV2Txt)
            {
                try
                {
                    ReplaceTextures(@"\_fashion_Shun_Ying_v2\", "3ed2b764ee5e7275-86bd307b26e90902-r20000000400000-00006a93", "5a918455378fd338-4f6cb8cb2ff0f729-r20000000400000-00006a93",
                        "5f073a7797e1cf95-934fcf8faa581322-r20000000400000-00006a93", "7be573c39a639f2d-f203483984226051-r80000000800000-00006a93",
                        "91d27be083301d2f-928e29ba657ac36d-r40000000400000-00006a93", "803d49a37daa111b-270156e009e501bd-r100000000800000-00006a93",
                        "3919a728279eef97-7812d0059070757b-r40000000400000-00006a93", "a85cd2eac1461ec7-dec8e50c83674a2d-r20000000400000-00006a93",
                        "bd6e250e1422ed7f-1e23bb6981f87a83-r20000000200000-00006a93", "d29989c8cc266151-6ec5664a4c0f9333-r80000000800000-00006a93",
                        "dc8e07967ddab0e3-630838f549071f68-r10000000200000-00006a93", "f3631822c326670b-7a9c0a4c6149354b-r20000000400000-00006a93",
                        "fee80ccd11d53cb1-461c9cde32a609af-r20000000400000-00006a93", "435117438ec31d17-17a0afa22800aa1e-r40000000400000-00006a93",
                        "", "",
                        "", "",
                        "", "");
                }
                catch
                {
                    ShunYingV2Txt = false;
                    notFound += "ShunYingV2Txt" + Environment.NewLine + "";
                }
            }
            else if (EvilShunYingTxt)
            {
                try
                {
                    ReplaceTextures(@"\_evil_Shun_Ying\", "1aad9b1c427c4f99-e690ed12d717504d-r80000000800000-00006a93", "3a88ccbadbb6301f-a3add64695ccdae-r80000000400000-00006a93",
                        "3ed2b764ee5e7275-86bd307b26e90902-r20000000400000-00006a93", "5f073a7797e1cf95-934fcf8faa581322-r20000000400000-00006a93",
                        "7be573c39a639f2d-f203483984226051-r80000000800000-00006a93", "15e94b9c0901ae3f-4d69c2ef60a0b2c0-r40000000400000-00006a93",
                        "91d27be083301d2f-928e29ba657ac36d-r40000000400000-00006a93", "523b16ec9f0ee37c-3c9628f705770df9-r80000000800000-00006a93",
                        "803d49a37daa111b-270156e009e501bd-r100000000800000-00006a93", "3919a728279eef97-7812d0059070757b-r40000000400000-00006a93",
                        "639269b29a652970-c06ef5033ca600c3-r80000000400000-00006a93", "435117438ec31d17-17a0afa22800aa1e-r40000000400000-00006a93",
                        "a85cd2eac1461ec7-dec8e50c83674a2d-r20000000400000-00006a93", "af3f1791c4f50e11-12f27bb7b7bad4e6-r40000000400000-00006a93",
                        "d29989c8cc266151-6ec5664a4c0f9333-r80000000800000-00006a93", "db41c0bc7c6b6a58-e0002082f32e5eb3-r40000000400000-00006a93",
                        "fee80ccd11d53cb1-461c9cde32a609af-r20000000400000-00006a93", "",
                        "", "");
                }
                catch
                {
                    EvilShunYingTxt = false;
                    notFound += "EvilShunYingTxt" + Environment.NewLine + "";
                }
            }
            
            #endregion

            #region GD 05 [20]

            RemoveTextures("6d893db564710ca1-4ff8f0ebd3ec0609-r80000000800000-00006a93", "69efda6f44f163a1-91138d7e6dffc63f-r80000000800000-00006a93",
                    "81efe0a7c43be920-af45f0038f28c59d-r80000000800000-00006a94", "444c3ed512a29968-cbfc39219f806bc2-r80000000800000-00006a93",
                    "ae7f87ca3a46eb9c-b0e87ffa1a03781f-r20000000800000-00006a94", "b8936048e4b9947-84744e9812ef4828-r100000000800000-00006a93",
                    "bb1c9cfb42c01f07-898fc451ff6f5bb1-r80000000200000-00006a93", "e6f677b51340684e-4f09c37a68391c32-r80000000800000-00006a93",
                    "ec7a8a73d7f53905-3135632c24c0ef71-r80000000800000-00006a94", "",
                    "", "",
                    "", "",
                    "", "",
                    "", "",
                    "", "");

            if (GD_05Skin)
            {
                try
                {
                    ReplaceTextures(@"\_Civil_GD 05\", "69efda6f44f163a1-91138d7e6dffc63f-r80000000800000-00006a93", "81efe0a7c43be920-af45f0038f28c59d-r80000000800000-00006a94",
                        "ae7f87ca3a46eb9c-b0e87ffa1a03781f-r20000000800000-00006a94", "ec7a8a73d7f53905-3135632c24c0ef71-r80000000800000-00006a94",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "");
                }
                catch
                {
                    GD_05Skin = false;
                    notFound += "Civil_GD 05Skin" + Environment.NewLine + "";
                }
            }
            else if (GD_04Txt)
            {
                try
                {
                    ReplaceTextures(@"\_gd 04\", "6d893db564710ca1-4ff8f0ebd3ec0609-r80000000800000-00006a93", "69efda6f44f163a1-91138d7e6dffc63f-r80000000800000-00006a93",
                        "81efe0a7c43be920-af45f0038f28c59d-r80000000800000-00006a94", "444c3ed512a29968-cbfc39219f806bc2-r80000000800000-00006a93",
                        "ae7f87ca3a46eb9c-b0e87ffa1a03781f-r20000000800000-00006a94", "b8936048e4b9947-84744e9812ef4828-r100000000800000-00006a93",
                        "bb1c9cfb42c01f07-898fc451ff6f5bb1-r80000000200000-00006a93", "e6f677b51340684e-4f09c37a68391c32-r80000000800000-00006a93",
                        "ec7a8a73d7f53905-3135632c24c0ef71-r80000000800000-00006a94", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "");
                }
                catch
                {
                    GD_04Txt = false;
                    notFound += "GD_04Txt" + Environment.NewLine + "";
                }
            }

            #endregion

            #region DR 88 [21]

            RemoveTextures("9b5e527fa1918a62-b68aed3f03cf861d-r40000000400000-00006a94", "ba134fecb0408e14-e9bca27bdcdbf9aa-r80000000800000-00006a94",
                    "fb438357bed1e1e7-2fa194f76862cfec-r80000000800000-00006a94", "58f4a7f4ccc6d30b-4da59d426bf6e590-r100000000800000-00006a93",
                    "6c1c1e2adba5b77d-fc2643411961c552-r80000000800000-00006a93", "4890e924e5deebf1-de9b58f798782dcb-r80000000200000-00006a94",
                    "beff79c55f574318-d386c6bf6f5eebb0-r80000000800000-00006a93", "fa3c54c024a8bbd8-c1479823e4ea5cf3-r80000000800000-00006a93",
                    "", "",
                    "", "",
                    "", "",
                    "", "",
                    "", "",
                    "", "");

            if (DR88Skin)
            {
                try
                {
                    ReplaceTextures(@"\_sergeant DR\", "9b5e527fa1918a62-b68aed3f03cf861d-r40000000400000-00006a94", "ba134fecb0408e14-e9bca27bdcdbf9aa-r80000000800000-00006a94",
                        "fb438357bed1e1e7-2fa194f76862cfec-r80000000800000-00006a94", "58f4a7f4ccc6d30b-4da59d426bf6e590-r100000000800000-00006a93",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "");
                }
                catch
                {
                    DR88Skin = false;
                    notFound += "SergeantDR_Txt" + Environment.NewLine + "";
                }
            }
            else if (GolemFanboyTxt)
            {
                try
                {
                    ReplaceTextures(@"\_Golem_Fanboy\", "9b5e527fa1918a62-b68aed3f03cf861d-r40000000400000-00006a94", "ba134fecb0408e14-e9bca27bdcdbf9aa-r80000000800000-00006a94",
                        "fb438357bed1e1e7-2fa194f76862cfec-r80000000800000-00006a94", "58f4a7f4ccc6d30b-4da59d426bf6e590-r100000000800000-00006a93",
                        "6c1c1e2adba5b77d-fc2643411961c552-r80000000800000-00006a93", "4890e924e5deebf1-de9b58f798782dcb-r80000000200000-00006a94",
                        "beff79c55f574318-d386c6bf6f5eebb0-r80000000800000-00006a93", "fa3c54c024a8bbd8-c1479823e4ea5cf3-r80000000800000-00006a93",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "");
                }
                catch
                {
                    GolemFanboyTxt = false;
                    notFound += "GolemFanboyTxt" + Environment.NewLine + "";
                }
            }

            #endregion

            #region FK 71 [22]

            RemoveTextures("5b864f94303ba934-4231c9a09c957bbb-r80000000800000-00006a93", "55fce7ac693eb603-df26b493e996d2dd-r40000000400000-00006a93",
                    "b7678904528e118a-a03caabd5a5eec9c-r100000000800000-00006a93", "3f5ae49df63dd88c-585275c2e18466f5-r80000000800000-00006a93",
                    "5e82512478924386-622acab33e8ad3b8-r40000000400000-00006a93", "2582024566ee53a6-eeec32c6685315bc-r40000000200000-00006a93",
                    "d6a47b0a34697a82-c4b41f1bc36e032d-r20000000200000-00006a93", "e7080b9b6b521e53-adc0b2b5b5a9a7ef-r80000000800000-00006a93",
                    "f78d6e7420c9d2af-5d9c81c0cee5802b-r100000000800000-00006a93", "",
                    "", "",
                    "", "",
                    "", "",
                    "", "",
                    "", "");

            if (BouncerFKTxt)
            {
                try
                {
                    ReplaceTextures(@"\_bouncer fk\", "5b864f94303ba934-4231c9a09c957bbb-r80000000800000-00006a93", "55fce7ac693eb603-df26b493e996d2dd-r40000000400000-00006a93",
                        "b7678904528e118a-a03caabd5a5eec9c-r100000000800000-00006a93", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "");
                }
                catch
                {
                    BouncerFKTxt = false;
                    notFound += "BouncerFKTxt" + Environment.NewLine + "";
                }
            }
            else if (DemonJinpachiTxt)
            {
                try
                {
                    ReplaceTextures(@"\_demon_jinpachi_fk\", "3f5ae49df63dd88c-585275c2e18466f5-r80000000800000-00006a93", "5b864f94303ba934-4231c9a09c957bbb-r80000000800000-00006a93",
                        "5e82512478924386-622acab33e8ad3b8-r40000000400000-00006a93", "55fce7ac693eb603-df26b493e996d2dd-r40000000400000-00006a93",
                        "2582024566ee53a6-eeec32c6685315bc-r40000000200000-00006a93", "b7678904528e118a-a03caabd5a5eec9c-r100000000800000-00006a93",
                        "d6a47b0a34697a82-c4b41f1bc36e032d-r20000000200000-00006a93", "e7080b9b6b521e53-adc0b2b5b5a9a7ef-r80000000800000-00006a93",
                        "f78d6e7420c9d2af-5d9c81c0cee5802b-r100000000800000-00006a93", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "");
                }
                catch
                {
                    DemonJinpachiTxt = false;
                    notFound += "DemonJinpachiTxt" + Environment.NewLine + "";
                }
            }
            else if (HalloweenFKTxt)
            {
                try
                {
                    ReplaceTextures(@"\_Halloween_FK\", "3f5ae49df63dd88c-585275c2e18466f5-r80000000800000-00006a93", "5b864f94303ba934-4231c9a09c957bbb-r80000000800000-00006a93",
                        "5e82512478924386-622acab33e8ad3b8-r40000000400000-00006a93", "55fce7ac693eb603-df26b493e996d2dd-r40000000400000-00006a93",
                        "2582024566ee53a6-eeec32c6685315bc-r40000000200000-00006a93", "b7678904528e118a-a03caabd5a5eec9c-r100000000800000-00006a93",
                        "d6a47b0a34697a82-c4b41f1bc36e032d-r20000000200000-00006a93", "e7080b9b6b521e53-adc0b2b5b5a9a7ef-r80000000800000-00006a93",
                        "f78d6e7420c9d2af-5d9c81c0cee5802b-r100000000800000-00006a93", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "");
                }
                catch
                {
                    HalloweenFKTxt = false;
                    notFound += "HalloweenFKTxt" + Environment.NewLine + "";
                }
            }

            #endregion

            #region PT 22 [23]

            RemoveTextures("6c2b5a38e0d97515-aed0fa40552eb02b-r80000000800000-00006a93", "42d0acf80897a17b-190eb069b8509bc1-r80000000800000-00006a93",
                    "565f642f3c05c02c-a260e6af3bdf437-r40000000400000-00006a93", "49711b7d981fbc5e-fc76fa3b6b94c287-r100000001000000-00006a93",
                    "7961894e21d632d5-52267a9a595c6ec5-r100000000800000-00006a93", "dee4c151fc0909e6-96a47ee33aa6ea75-r20000000200000-00006a93",
                    "", "348671b90151353b-cb881299cc6bdb9c-r40000000400000-00006a93",
                    "f276f99276f58a29-218570c0821c131b-r40000000400000-00006a93", "",
                    "", "",
                    "", "",
                    "", "",
                    "", "",
                    "", "");

            if (PT22Skin)
            {
                try
                {
                    ReplaceTextures(@"\_PT track n field\", "6c2b5a38e0d97515-aed0fa40552eb02b-r80000000800000-00006a93", "42d0acf80897a17b-190eb069b8509bc1-r80000000800000-00006a93",
                        "565f642f3c05c02c-a260e6af3bdf437-r40000000400000-00006a93", "49711b7d981fbc5e-fc76fa3b6b94c287-r100000001000000-00006a93",
                        "7961894e21d632d5-52267a9a595c6ec5-r100000000800000-00006a93", "dee4c151fc0909e6-96a47ee33aa6ea75-r20000000200000-00006a93",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "");
                }
                catch
                {
                    PT22Skin = false;
                    notFound += "PT_TrackandFieldTxt" + Environment.NewLine + "";
                }
            }
            if (PutaTxt)
            {
                try
                {
                    ReplaceTextures(@"\_Puta\", "6c2b5a38e0d97515-aed0fa40552eb02b-r80000000800000-00006a93", "565f642f3c05c02c-a260e6af3bdf437-r40000000400000-00006a93",
                        "42d0acf80897a17b-190eb069b8509bc1-r80000000800000-00006a93", "49711b7d981fbc5e-fc76fa3b6b94c287-r100000001000000-00006a93",
                        "7961894e21d632d5-52267a9a595c6ec5-r100000000800000-00006a93", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "");
                }
                catch
                {
                    PutaTxt = false;
                    notFound += "PutaTxt" + Environment.NewLine + "";
                }
            }
            if (PepsimanTxt)
            {
                try
                {
                    ReplaceTextures(@"\_Pepsiman\", "6c2b5a38e0d97515-aed0fa40552eb02b-r80000000800000-00006a93", "565f642f3c05c02c-a260e6af3bdf437-r40000000400000-00006a93",
                        "42d0acf80897a17b-190eb069b8509bc1-r80000000800000-00006a93", "49711b7d981fbc5e-fc76fa3b6b94c287-r100000001000000-00006a93",
                        "7961894e21d632d5-52267a9a595c6ec5-r100000000800000-00006a93", "348671b90151353b-cb881299cc6bdb9c-r40000000400000-00006a93",
                        "dee4c151fc0909e6-96a47ee33aa6ea75-r20000000200000-00006a93", "f276f99276f58a29-218570c0821c131b-r40000000400000-00006a93",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "");
                }
                catch
                {
                    PepsimanTxt = false;
                    notFound += "PepsimanTxt" + Environment.NewLine + "";
                }
            }

            #endregion

            #region Bain [24]

            RemoveTextures("9e8846a7ca31fdc6-7d91e51e21cdb02b-r100000000800000-00006a93", "469929e776784443-75740b513d932a9a-r80000000800000-00006a93",
                        "a302d1672a916079-5302beef68aff1e9-r40000000400000-00006a93", "c0ed58f7d916e0a8-b0d4f3dc6fbac86b-r100000000800000-00006a93",
                        "e4ee061a56299d99-dd9d8900a501932c-r100000000800000-00006a93", "e41a9b35582c89b6-b1b5e8ef4b8b3957-r40000000400000-00006a93",
                        "77e556099f0049ee-ba9a454b205d32ed-r40000000200000-00006a93", "29776ff74d843d34-8c4df13fd00f5934-r80000000800000-00006a93",
                        "b70d9c51af9c5857-be03ee3b8ca76166-r100000000800000-00006a93", "bb8450dbd0f7086d-5fc7e1ff3eefa57e-r20000000200000-00006a93",
                        "becbde5e0edb4097-9601e14975446a27-r20000000200000-00006a93", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "");

            if (BainSkin)
            {
                try
                {
                    ReplaceTextures(@"\_Sea_Rescue_Bain\", "9e8846a7ca31fdc6-7d91e51e21cdb02b-r100000000800000-00006a93", "469929e776784443-75740b513d932a9a-r80000000800000-00006a93",
                        "a302d1672a916079-5302beef68aff1e9-r40000000400000-00006a93", "c0ed58f7d916e0a8-b0d4f3dc6fbac86b-r100000000800000-00006a93",
                        "e4ee061a56299d99-dd9d8900a501932c-r100000000800000-00006a93", "e41a9b35582c89b6-b1b5e8ef4b8b3957-r40000000400000-00006a93",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "");
                }
                catch
                {
                    BainSkin = false;
                    notFound += "SeaRescueBainSkin" + Environment.NewLine + "";
                }
            }
            else if (SkeletonBoyTxt)
            {
                try
                {
                    ReplaceTextures(@"\_Skeleton_Boy\", "9e8846a7ca31fdc6-7d91e51e21cdb02b-r100000000800000-00006a93", "469929e776784443-75740b513d932a9a-r80000000800000-00006a93",
                        "a302d1672a916079-5302beef68aff1e9-r40000000400000-00006a93", "c0ed58f7d916e0a8-b0d4f3dc6fbac86b-r100000000800000-00006a93",
                        "e4ee061a56299d99-dd9d8900a501932c-r100000000800000-00006a93", "e41a9b35582c89b6-b1b5e8ef4b8b3957-r40000000400000-00006a93",
                        "77e556099f0049ee-ba9a454b205d32ed-r40000000200000-00006a93", "29776ff74d843d34-8c4df13fd00f5934-r80000000800000-00006a93",
                        "b70d9c51af9c5857-be03ee3b8ca76166-r100000000800000-00006a93", "bb8450dbd0f7086d-5fc7e1ff3eefa57e-r20000000200000-00006a93",
                        "becbde5e0edb4097-9601e14975446a27-r20000000200000-00006a93", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "");
                }
                catch
                {
                    SkeletonBoyTxt = false;
                    notFound += "SkeletonBoyTxt" + Environment.NewLine + "";
                }
            }

            #endregion

            #region Cooper [25]

            RemoveTextures("1b74242b1f673990-3b9e4763f448a905-r40000000400000-00006a93", "3aae6581a6bebc80-1c57ccfd1b6d0c93-r100000000800000-00006a93",
                    "3eb6384fc00e6690-c1bb51c9098259f2-r80000000800000-00006a93", "99a6fdd9ce470a66-2c50f20ac5c4e1e9-r20000000200000-00006a93",
                    "7478b07afb102f3-d6f9ba4694c7dbc6-r100000000800000-00006a93", "be1f82a0975433aa-af7a50d5ec975d57-r100000000800000-00006a93",
                    "c02ae30007df840c-7dc7df501604dfba-r80000000800000-00006a93", "c6068b58e9bc5d8d-d21bef5531eb1068-r40000000800000-00006a93",
                    "e81b8a7988fa76e0-6353d52663231802-r40000000400000-00006a93", "ec43a7baeb6ceb77-4cf1549f437b68d8-r40000000800000-00006a93",
                    "efa11ed9ec81cea9-2a5f26718c30064d-r100000000800000-00006a93", "d2b87c5b466ad21b-24d9c07885543fa1-r40000000400000-00006a93",
                    "", "",
                    "", "",
                    "", "",
                    "", "");

            if (CooperSkin)
            {
                try
                {
                    ReplaceTextures(@"\_DR2_Cooper\", "1b74242b1f673990-3b9e4763f448a905-r40000000400000-00006a93", "3aae6581a6bebc80-1c57ccfd1b6d0c93-r100000000800000-00006a93",
                        "3eb6384fc00e6690-c1bb51c9098259f2-r80000000800000-00006a93", "99a6fdd9ce470a66-2c50f20ac5c4e1e9-r20000000200000-00006a93",
                        "7478b07afb102f3-d6f9ba4694c7dbc6-r100000000800000-00006a93", "be1f82a0975433aa-af7a50d5ec975d57-r100000000800000-00006a93",
                        "c02ae30007df840c-7dc7df501604dfba-r80000000800000-00006a93", "c6068b58e9bc5d8d-d21bef5531eb1068-r40000000800000-00006a93",
                        "e81b8a7988fa76e0-6353d52663231802-r40000000400000-00006a93", "ec43a7baeb6ceb77-4cf1549f437b68d8-r40000000800000-00006a93",
                        "efa11ed9ec81cea9-2a5f26718c30064d-r100000000800000-00006a93", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "");
                }
                catch
                {
                    CooperSkin = false;
                    notFound += "dr2CooperSkin" + Environment.NewLine + "";
                }
            }
            else if (CooperSkin2)
            {
                try
                {
                    ReplaceTextures(@"\_Ballas_Cooper\", "3aae6581a6bebc80-1c57ccfd1b6d0c93-r100000000800000-00006a93", "3eb6384fc00e6690-c1bb51c9098259f2-r80000000800000-00006a93",
                        "7478b07afb102f3-d6f9ba4694c7dbc6-r100000000800000-00006a93", "be1f82a0975433aa-af7a50d5ec975d57-r100000000800000-00006a93",
                        "d2b87c5b466ad21b-24d9c07885543fa1-r40000000400000-00006a93", "ec43a7baeb6ceb77-4cf1549f437b68d8-r40000000800000-00006a93",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "");
                }
                catch
                {
                    CooperSkin2 = false;
                    notFound += "Ballas_Cooper" + Environment.NewLine + "";
                }
            }

            #endregion

            #region Anderson [26]

            RemoveTextures("3a5c42ff7197799a-c5c541b3397dbde9-r20000000200000-00006a93", "3cfae80de7d7f04d-fc105a1396a25510-r40000000400000-00006a93",
                    "8eef141ea496d704-58c031727378b1d7-r20000000200000-00006a93", "66d9c5230dd52031-bc95b2aa5707c3f-r40000000800000-00006a93",
                    "90de7824e5e44e22-d319842266b5c3b3-r100000000800000-00006a93", "96f8aa2778a4f70d-f10b71f8496b2a35-r10000000200000-00006a93",
                    "250f24d440faad80-12101a9478d9e651-r100000000800000-00006a93", "732f913b2b477b60-2556719d7e9f34c4-r100000000800000-00006a93",
                    "739dd870f8a4ace8-5ef1792f5dcda651-r40000000800000-00006a93", "609627692cf15c67-c8c14e1e04bb8312-r40000000800000-00006a93",
                    "cc12a4538e59d377-acb9bdf3f900ed47-r40000000400000-00006a93", "eb431cce4402bb34-a8ee7470ddcc7f54-r80000000800000-00006a93",
                    "f93e380e7122f2fe-57df8b5cc648d9f5-r40000000400000-00006a93", "fa2c3994fdeba83a-1f4a4e8943630745-r10000000200000-00006a93",
                    "ff723f32bb6b453d-288b5197aeaf4b1c-r40000000400000-00006a93", "",
                    "", "",
                    "", "");

            if (SuspectTxt)
            {
                try
                {
                    ReplaceTextures(@"\_suspect\", "3a5c42ff7197799a-c5c541b3397dbde9-r20000000200000-00006a93", "3cfae80de7d7f04d-fc105a1396a25510-r40000000400000-00006a93",
                        "8eef141ea496d704-58c031727378b1d7-r20000000200000-00006a93", "66d9c5230dd52031-bc95b2aa5707c3f-r40000000800000-00006a93",
                        "90de7824e5e44e22-d319842266b5c3b3-r100000000800000-00006a93", "96f8aa2778a4f70d-f10b71f8496b2a35-r10000000200000-00006a93",
                        "250f24d440faad80-12101a9478d9e651-r100000000800000-00006a93", "732f913b2b477b60-2556719d7e9f34c4-r100000000800000-00006a93",
                        "739dd870f8a4ace8-5ef1792f5dcda651-r40000000800000-00006a93", "609627692cf15c67-c8c14e1e04bb8312-r40000000800000-00006a93",
                        "cc12a4538e59d377-acb9bdf3f900ed47-r40000000400000-00006a93", "eb431cce4402bb34-a8ee7470ddcc7f54-r80000000800000-00006a93",
                        "f93e380e7122f2fe-57df8b5cc648d9f5-r40000000400000-00006a93", "fa2c3994fdeba83a-1f4a4e8943630745-r10000000200000-00006a93",
                        "ff723f32bb6b453d-288b5197aeaf4b1c-r40000000400000-00006a93", "",
                        "", "",
                        "", "");
                }
                catch
                {
                    SuspectTxt = false;
                    notFound += "SuspectTxt" + Environment.NewLine + "";
                }
            }
            else if (AndersonSkin)
            {
                try
                {
                    ReplaceTextures(@"\_kidnapper C\", "90de7824e5e44e22-d319842266b5c3b3-r100000000800000-00006a93", "739dd870f8a4ace8-5ef1792f5dcda651-r40000000800000-00006a93",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "");
                }
                catch
                {
                    AndersonSkin = false;
                    notFound += "KidnapperCTxt" + Environment.NewLine + "";
                }
            }

            #endregion

            #region Taylor [27]

            RemoveTextures("3b190ec92c610020-ddf76ce7df9af980-r100000000800000-00006a93", "3fe6a8c0fd983b48-8312875d37d81c6e-r40000000400000-00006a93",
                    "4e1a995bf730f70f-87d7a17878ab7e38-r20000000400000-00006a93", "8f339679985e5f99-cead90e65d125416-r20000000200000-00006a93",
                    "69e2905e70b8b8ae-74c94e27d13cb031-r100000000800000-00006a93", "c140b3fa1f6f048-615e8467468a3d6d-r40000000800000-00006a93",
                    "ccfd1b8cb38a6307-42c4fcd4df52e4f5-r100000000800000-00006a93", "cfaabc67891e22aa-6203e831e4673225-r20000000400000-00006a93",
                    "d568f6da9a7a98c9-e19cfe6005af6444-r80000000800000-00006a93", "e2722b39080cc3ad-fe1c2707d028206f-r80000000800000-00006a93",
                    "", "",
                    "", "",
                    "", "",
                    "", "",
                    "", "");

            if (TaylorSkin)
            {
                try
                {
                    ReplaceTextures(@"\_TK_Taylor\", "3b190ec92c610020-ddf76ce7df9af980-r100000000800000-00006a93", "3fe6a8c0fd983b48-8312875d37d81c6e-r40000000400000-00006a93",
                        "4e1a995bf730f70f-87d7a17878ab7e38-r20000000400000-00006a93", "8f339679985e5f99-cead90e65d125416-r20000000200000-00006a93",
                        "69e2905e70b8b8ae-74c94e27d13cb031-r100000000800000-00006a93", "c140b3fa1f6f048-615e8467468a3d6d-r40000000800000-00006a93",
                        "ccfd1b8cb38a6307-42c4fcd4df52e4f5-r100000000800000-00006a93", "cfaabc67891e22aa-6203e831e4673225-r20000000400000-00006a93",
                        "d568f6da9a7a98c9-e19cfe6005af6444-r80000000800000-00006a93", "e2722b39080cc3ad-fe1c2707d028206f-r80000000800000-00006a93",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "");
                }
                catch
                {
                    TaylorSkin = false;
                    notFound += "TK_TaylorSkin" + Environment.NewLine + "";
                }
            }
            else if (TaylorSkin2)
            {
                try
                {
                    ReplaceTextures(@"\_Taylor_White\", "3b190ec92c610020-ddf76ce7df9af980-r100000000800000-00006a93", "4e1a995bf730f70f-87d7a17878ab7e38-r20000000400000-00006a93",
                        "69e2905e70b8b8ae-74c94e27d13cb031-r100000000800000-00006a93", "c140b3fa1f6f048-615e8467468a3d6d-r40000000800000-00006a93",
                        "ccfd1b8cb38a6307-42c4fcd4df52e4f5-r100000000800000-00006a93", "cfaabc67891e22aa-6203e831e4673225-r20000000400000-00006a93",
                        "d568f6da9a7a98c9-e19cfe6005af6444-r80000000800000-00006a93", "e2722b39080cc3ad-fe1c2707d028206f-r80000000800000-00006a93",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "");
                }
                catch
                {
                    TaylorSkin2 = false;
                    notFound += "Taylor_White" + Environment.NewLine + "";
                }
            }

            #endregion

            #region Chris [28]

            RemoveTextures("2be09e17b78c4bc1-5e10ff8238f3a02f-r80000000800000-00006a94", "4ef9815113f118c8-c49c93dd9c832c2f-r80000000400000-00006a94",
                    "472d34d3c9e97a08-9dacf65ac94ac455-r80000000800000-00006a93", "a8d04e6e88e449df-91c1f75bdf3e0097-r80000000400000-00006a93",
                    "dbe0ab0a4db62143-66b835336406af82-r80000000800000-00006a93", "dfb09b0c75bee2b7-562f2ad8591384c7-r80000000400000-00006a93",
                    "636cc3f369c0152d-ea1255517ca2e26a-r40000000800000-00006a94", "911e5262f10a3970-528d85cd4bd89f21-r20000000400000-00006a94",
                    "15232a00548de558-283611f71bb7233d-r80000000800000-00006a93", "8dadd59f5ca14857-aedabb161c27a294-r80000000800000-00006a93",
                    "e8bd3fce0ab53d1-fff42aa3297b726f-r100000001000000-00006a93", "",
                    "", "",
                    "", "",
                    "", "",
                    "", "");

            if (AristocratChrisTxt)
            {
                try
                {
                    ReplaceTextures(@"\_aristocrat chris\", "2be09e17b78c4bc1-5e10ff8238f3a02f-r80000000800000-00006a94", "4ef9815113f118c8-c49c93dd9c832c2f-r80000000400000-00006a94",
                        "472d34d3c9e97a08-9dacf65ac94ac455-r80000000800000-00006a93", "a8d04e6e88e449df-91c1f75bdf3e0097-r80000000400000-00006a93",
                        "dbe0ab0a4db62143-66b835336406af82-r80000000800000-00006a93", "dfb09b0c75bee2b7-562f2ad8591384c7-r80000000400000-00006a93",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "");
                }
                catch
                {
                    AristocratChrisTxt = false;
                    notFound += "AristocratChrisTxt" + Environment.NewLine + "";
                }
            }
            else if (ChrisSkin2)
            {
                try
                {
                    ReplaceTextures(@"\_FlamengistChris\", "2be09e17b78c4bc1-5e10ff8238f3a02f-r80000000800000-00006a94", "4ef9815113f118c8-c49c93dd9c832c2f-r80000000400000-00006a94",
                        "472d34d3c9e97a08-9dacf65ac94ac455-r80000000800000-00006a93", "636cc3f369c0152d-ea1255517ca2e26a-r40000000800000-00006a94",
                        "911e5262f10a3970-528d85cd4bd89f21-r20000000400000-00006a94", "15232a00548de558-283611f71bb7233d-r80000000800000-00006a93",
                        "a8d04e6e88e449df-91c1f75bdf3e0097-r80000000400000-00006a93", "dbe0ab0a4db62143-66b835336406af82-r80000000800000-00006a93",
                        "dfb09b0c75bee2b7-562f2ad8591384c7-r80000000400000-00006a93", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "");
                }
                catch
                {
                    ChrisSkin2 = false;
                    notFound += "FlamengistChris" + Environment.NewLine + "";
                }
            }
            else if (EddyTrainerTxt)
            {
                try
                {
                    ReplaceTextures(@"\_Eddys_Trainer\", "2be09e17b78c4bc1-5e10ff8238f3a02f-r80000000800000-00006a94", "4ef9815113f118c8-c49c93dd9c832c2f-r80000000400000-00006a94",
                        "8dadd59f5ca14857-aedabb161c27a294-r80000000800000-00006a93", "472d34d3c9e97a08-9dacf65ac94ac455-r80000000800000-00006a93",
                        "636cc3f369c0152d-ea1255517ca2e26a-r40000000800000-00006a94", "911e5262f10a3970-528d85cd4bd89f21-r20000000400000-00006a94",
                        "15232a00548de558-283611f71bb7233d-r80000000800000-00006a93", "a8d04e6e88e449df-91c1f75bdf3e0097-r80000000400000-00006a93",
                        "dbe0ab0a4db62143-66b835336406af82-r80000000800000-00006a93", "dfb09b0c75bee2b7-562f2ad8591384c7-r80000000400000-00006a93",
                        "e8bd3fce0ab53d1-fff42aa3297b726f-r100000001000000-00006a93", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "");
                }
                catch
                {
                    EddyTrainerTxt = false;
                    notFound += "EddyTrainerTxt" + Environment.NewLine + "";
                }
            }

            #endregion

            #region Park [29]

            RemoveTextures("7de3823bf5429edd-fcab27e758cda11f-r20000000400000-00006a93", "7e5a55fce8300fdd-c71c295ac5e058ff-r40000000400000-00006a93",
                    "854d32a17ad71bd5-503b62eaff159fa9-r80000000800000-00006a93", "647238311528bdd8-69257ba70cb1b598-r80000000800000-00006a93",
                    "c651823a32cbe911-495b1d4e7f137e3f-r40000000400000-00006a93", "cb1b8f54b36f5f35-c76526accdb5253-r10000000400000-00006a93",
                    "ecf59619d0b8b35-4303fe8f71a49215-r80000000800000-00006a93", "2da2203d39a74446-3511f0037a4ef3d6-r40000000400000-00006a93",
                    "3ffc5305ef65a6b5-fc2484321ad9da19-r100000001000000-00006a93", "4e558b8619f28a2f-7b311ba27ede9ae6-r20000000400000-00006a93",
                    "7de3823bf5429edd-fcab27e758cda11f-r20000000400000-00006a93", "630dae20806ec0af-243b397743caf199-r20000000200000-00006a93",
                    "7767b9cc7ea85def-c4919a1f25371bec-r20000000200000-00006a93", "24835cad676d9cd6-6786baf34695a3b4-r40000000200000-00006a93",
                    "b33cfcfbb6c2eed-bf42ce9e6478c707-r100000001000000-00006a93", "e4b8ca5d28cd3fa1-a284fe99c659296b-r40000000400000-00006a93",
                    "", "",
                    "", "");

            if (AlternativeParkTxt)
            {
                try
                {
                    ReplaceTextures(@"\_alternative park\", "7de3823bf5429edd-fcab27e758cda11f-r20000000400000-00006a93", "7e5a55fce8300fdd-c71c295ac5e058ff-r40000000400000-00006a93",
                        "854d32a17ad71bd5-503b62eaff159fa9-r80000000800000-00006a93", "647238311528bdd8-69257ba70cb1b598-r80000000800000-00006a93",
                        "c651823a32cbe911-495b1d4e7f137e3f-r40000000400000-00006a93", "cb1b8f54b36f5f35-c76526accdb5253-r10000000400000-00006a93",
                        "ecf59619d0b8b35-4303fe8f71a49215-r80000000800000-00006a93", "2da2203d39a74446-3511f0037a4ef3d6-r40000000400000-00006a93",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "");
                }
                catch
                {
                    AlternativeParkTxt = false;
                    notFound += "AlternativeParkTxt" + Environment.NewLine + "";
                }
            }
            else if (ParkDanteTxt)
            {
                try
                {
                    ReplaceTextures(@"\_Park_Dante\", "2da2203d39a74446-3511f0037a4ef3d6-r40000000400000-00006a93", "3ffc5305ef65a6b5-fc2484321ad9da19-r100000001000000-00006a93",
                        "4e558b8619f28a2f-7b311ba27ede9ae6-r20000000400000-00006a93", "7de3823bf5429edd-fcab27e758cda11f-r20000000400000-00006a93",
                        "7e5a55fce8300fdd-c71c295ac5e058ff-r40000000400000-00006a93", "630dae20806ec0af-243b397743caf199-r20000000200000-00006a93",
                        "854d32a17ad71bd5-503b62eaff159fa9-r80000000800000-00006a93", "7767b9cc7ea85def-c4919a1f25371bec-r20000000200000-00006a93",
                        "24835cad676d9cd6-6786baf34695a3b4-r40000000200000-00006a93", "647238311528bdd8-69257ba70cb1b598-r80000000800000-00006a93",
                        "b33cfcfbb6c2eed-bf42ce9e6478c707-r100000001000000-00006a93", "c651823a32cbe911-495b1d4e7f137e3f-r40000000400000-00006a93",
                        "cb1b8f54b36f5f35-c76526accdb5253-r10000000400000-00006a93", "e4b8ca5d28cd3fa1-a284fe99c659296b-r40000000400000-00006a93",
                        "ecf59619d0b8b35-4303fe8f71a49215-r80000000800000-00006a93", "",
                        "", "",
                        "", "");
                }
                catch
                {
                    ParkDanteTxt = false;
                    notFound += "ParkDanteTxt" + Environment.NewLine + "";
                }
            }
            else if (SymbioteSpiderTxt)
            {
                try
                {
                    ReplaceTextures(@"\_Symbiote_Parker\", "2da2203d39a74446-3511f0037a4ef3d6-r40000000400000-00006a93", "3ffc5305ef65a6b5-fc2484321ad9da19-r100000001000000-00006a93",
                        "4e558b8619f28a2f-7b311ba27ede9ae6-r20000000400000-00006a93", "7de3823bf5429edd-fcab27e758cda11f-r20000000400000-00006a93",
                        "7e5a55fce8300fdd-c71c295ac5e058ff-r40000000400000-00006a93", "630dae20806ec0af-243b397743caf199-r20000000200000-00006a93",
                        "854d32a17ad71bd5-503b62eaff159fa9-r80000000800000-00006a93", "7767b9cc7ea85def-c4919a1f25371bec-r20000000200000-00006a93",
                        "24835cad676d9cd6-6786baf34695a3b4-r40000000200000-00006a93", "647238311528bdd8-69257ba70cb1b598-r80000000800000-00006a93",
                        "b33cfcfbb6c2eed-bf42ce9e6478c707-r100000001000000-00006a93", "c651823a32cbe911-495b1d4e7f137e3f-r40000000400000-00006a93",
                        "cb1b8f54b36f5f35-c76526accdb5253-r10000000400000-00006a93", "e4b8ca5d28cd3fa1-a284fe99c659296b-r40000000400000-00006a93",
                        "ecf59619d0b8b35-4303fe8f71a49215-r80000000800000-00006a93", "",
                        "", "",
                        "", "");
                }
                catch
                {
                    SymbioteSpiderTxt = false;
                    notFound += "SymbioteSpiderTxt" + Environment.NewLine + "";
                }
            }

            #endregion

            #region Alex [2A]

            RemoveTextures("2a0aed1463d1068e-90c07696069cf297-r80000000800000-00006a93", "9b5ddb83993fe50e-3af576314d692124-r80000000800000-00006a94",
                    "9de6b00c9cd11c86-dd525e18f3c10433-r100000000800000-00006a93", "40dea9592d211ec8-d8d18aaf805c2ddc-r80000000400000-00006a93",
                    "80bd5541a07168b1-e977c42a53ec449d-r100000001000000-00006a94", "91cbf0619eea9e71-9b3a64382c6fe144-r80000000800000-00006a94",
                    "1165da3ab164ea14-b3c2b223d4a1e056-r20000000800000-00006a94", "33770508143890d7-72d5c20973fab938-r10000000800000-00006a94",
                    "a1fe3cd621e19233-e86cbf456f6c26da-r10000000400000-00006a93", "afde40deebbdb02e-a58523448f3fbdfc-r40000000400000-00006a93",
                    "c48ee1c8772eafc0-bf65de1c0766e8c9-r20000000400000-00006a94", "d409e0d899d67d46-4d9228fadff5f18-r40000000400000-00006a93",
                    "f26bd6dcfe911af3-b7c2949c38c29fa4-r80000000800000-00006a94", "",
                    "", "",
                    "", "",
                    "", "");

            if (AlexSkin)
            {
                try
                {
                    ReplaceTextures(@"\_Alex_Touchdown\", "2a0aed1463d1068e-90c07696069cf297-r80000000800000-00006a93", "9b5ddb83993fe50e-3af576314d692124-r80000000800000-00006a94",
                        "9de6b00c9cd11c86-dd525e18f3c10433-r100000000800000-00006a93", "40dea9592d211ec8-d8d18aaf805c2ddc-r80000000400000-00006a93",
                        "80bd5541a07168b1-e977c42a53ec449d-r100000001000000-00006a94", "91cbf0619eea9e71-9b3a64382c6fe144-r80000000800000-00006a94",
                        "1165da3ab164ea14-b3c2b223d4a1e056-r20000000800000-00006a94", "33770508143890d7-72d5c20973fab938-r10000000800000-00006a94",
                        "a1fe3cd621e19233-e86cbf456f6c26da-r10000000400000-00006a93", "afde40deebbdb02e-a58523448f3fbdfc-r40000000400000-00006a93",
                        "c48ee1c8772eafc0-bf65de1c0766e8c9-r20000000400000-00006a94", "d409e0d899d67d46-4d9228fadff5f18-r40000000400000-00006a93",
                        "f26bd6dcfe911af3-b7c2949c38c29fa4-r80000000800000-00006a94", "",
                        "", "",
                        "", "",
                        "", "");
                }
                catch
                {
                    AlexSkin = false;
                    notFound += "AlexTouchdownSkin" + Environment.NewLine + "";
                }
            }
            else if (GangsterAlexTxt)
            {
                try
                {
                    ReplaceTextures(@"\_Gangster_Alex\", "", "9b5ddb83993fe50e-3af576314d692124-r80000000800000-00006a94",
                        "9de6b00c9cd11c86-dd525e18f3c10433-r100000000800000-00006a93", "40dea9592d211ec8-d8d18aaf805c2ddc-r80000000400000-00006a93",
                        "80bd5541a07168b1-e977c42a53ec449d-r100000001000000-00006a94", "91cbf0619eea9e71-9b3a64382c6fe144-r80000000800000-00006a94",
                        "", "",
                        "a1fe3cd621e19233-e86cbf456f6c26da-r10000000400000-00006a93", "afde40deebbdb02e-a58523448f3fbdfc-r40000000400000-00006a93",
                        "", "",
                        "f26bd6dcfe911af3-b7c2949c38c29fa4-r80000000800000-00006a94", "",
                        "", "",
                        "", "",
                        "", "");
                }
                catch
                {
                    GangsterAlexTxt = false;
                    notFound += "GangsterAlexTxt" + Environment.NewLine + "";
                }
            }
            else if (VergilAlexTxt)
            {
                try
                {
                    ReplaceTextures(@"\_VergilAlex\", "", "9b5ddb83993fe50e-3af576314d692124-r80000000800000-00006a94",
                        "9de6b00c9cd11c86-dd525e18f3c10433-r100000000800000-00006a93", "40dea9592d211ec8-d8d18aaf805c2ddc-r80000000400000-00006a93",
                        "80bd5541a07168b1-e977c42a53ec449d-r100000001000000-00006a94", "91cbf0619eea9e71-9b3a64382c6fe144-r80000000800000-00006a94",
                        "", "",
                        "a1fe3cd621e19233-e86cbf456f6c26da-r10000000400000-00006a93", "c48ee1c8772eafc0-bf65de1c0766e8c9-r20000000400000-00006a94",
                        "d409e0d899d67d46-4d9228fadff5f18-r40000000400000-00006a93", "",
                        "f26bd6dcfe911af3-b7c2949c38c29fa4-r80000000800000-00006a94", "",
                        "", "",
                        "", "",
                        "", "");
                }
                catch
                {
                    VergilAlexTxt = false;
                    notFound += "VergilAlexTxt" + Environment.NewLine + "";
                }
            }

            #endregion

            #region McKinzie [2B]

            RemoveTextures("2b3d53edeb123b09-2e070f8dc64856fd-r80000000800000-00006a93", "62b16d344d0dbdc6-4f901765070b5644-r80000000800000-00006a93",
                    "2819e0dbe0c12c74-145cb8c5d47ca7e9-r20000000400000-00006a94", "b13d24a94a030fe7-7e1bbb978555e8ea-r80000000800000-00006a93",
                    "dfca2aa739e8fab1-2b12caba339b65f0-r80000000800000-00006a93", "e12be71cde5fb8ec-e6f2cef6831fb415-r100000001000000-00006a93",
                    "612aeacb1708db49-c7f043ffa1e74870-r100000001000000-00006a93", "2667f91194bad293-94416c2a1492e048-r20000000800000-00006a94",
                    "bd9400182f9dcfe3-2c571259cd4eb408-r40000000400000-00006a93", "3a0e9ad614f09aed-f47cf87e5356b468-r40000000400000-00006a93",
                    "62f5fd8545a60254-9d6a007d56cdfdd9-r40000000400000-00006a94", "cc12a4538e59d377-acb9bdf3f900ed47-r40000000400000-00006a93",
                    "", "",
                    "", "",
                    "", "",
                    "", "");

            if (McKinzieSkin)
            {
                try
                {
                    ReplaceTextures(@"\_enforcer McKenzie\", "2b3d53edeb123b09-2e070f8dc64856fd-r80000000800000-00006a93", "62b16d344d0dbdc6-4f901765070b5644-r80000000800000-00006a93",
                        "2819e0dbe0c12c74-145cb8c5d47ca7e9-r20000000400000-00006a94", "b13d24a94a030fe7-7e1bbb978555e8ea-r80000000800000-00006a93",
                        "dfca2aa739e8fab1-2b12caba339b65f0-r80000000800000-00006a93", "e12be71cde5fb8ec-e6f2cef6831fb415-r100000001000000-00006a93",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "");
                }
                catch
                {
                    McKinzieSkin = false;
                    notFound += "McKinzieSkin" + Environment.NewLine + "";
                }
            }
            else if (TerminatorMckinzieTxt)
            {
                try
                {
                    ReplaceTextures(@"\_Terminator_McKinzie\", "2b3d53edeb123b09-2e070f8dc64856fd-r80000000800000-00006a93", "62b16d344d0dbdc6-4f901765070b5644-r80000000800000-00006a93",
                        "612aeacb1708db49-c7f043ffa1e74870-r100000001000000-00006a93", "2667f91194bad293-94416c2a1492e048-r20000000800000-00006a94",
                        "dfca2aa739e8fab1-2b12caba339b65f0-r80000000800000-00006a93", "e12be71cde5fb8ec-e6f2cef6831fb415-r100000001000000-00006a93",
                        "bd9400182f9dcfe3-2c571259cd4eb408-r40000000400000-00006a93", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "");
                }
                catch
                {
                    TerminatorMckinzieTxt = false;
                    notFound += "TerminatorMckinzieTxt" + Environment.NewLine + "";
                }
            }
            else if (McPunisherTxt)
            {
                try
                {
                    ReplaceTextures(@"\_McPunisher\", "2b3d53edeb123b09-2e070f8dc64856fd-r80000000800000-00006a93", "62b16d344d0dbdc6-4f901765070b5644-r80000000800000-00006a93",
                        "612aeacb1708db49-c7f043ffa1e74870-r100000001000000-00006a93", "2667f91194bad293-94416c2a1492e048-r20000000800000-00006a94",
                        "dfca2aa739e8fab1-2b12caba339b65f0-r80000000800000-00006a93", "e12be71cde5fb8ec-e6f2cef6831fb415-r100000001000000-00006a93",
                        "", "",
                        "3a0e9ad614f09aed-f47cf87e5356b468-r40000000400000-00006a93", "62f5fd8545a60254-9d6a007d56cdfdd9-r40000000400000-00006a94",
                        "2819e0dbe0c12c74-145cb8c5d47ca7e9-r20000000400000-00006a94", "b13d24a94a030fe7-7e1bbb978555e8ea-r80000000800000-00006a93",
                        "cc12a4538e59d377-acb9bdf3f900ed47-r40000000400000-00006a93", "",
                        "", "",
                        "", "",
                        "", "");
                }
                catch
                {
                    McPunisherTxt = false;
                    notFound += "McPunisherTxt" + Environment.NewLine + "";
                }
            }

            #endregion

            #region Napalm 99 [2C]

            RemoveTextures("2f8add318e00dffe-dbf8c749768b6a20-r80000000800000-00006a93", "3b884e228a2ddccc-6ca9b2ddf9855dde-r80000000800000-00006a93",
                    "51a1eb3a94ed3d0b-70ef6e35a9c7907-r40000000400000-00006a94", "78dc2207d9d0230b-c372c05e72b419a3-r100000001000000-00006a93",
                    "93aced97c537dadb-198fe9df32188ec9-r80000000400000-00006a94", "a455c120cdead701-f525c46992390cf7-r80000000800000-00006a93",
                    "b6fb1ee4b707443a-3158ccfef51c70c-r80000000800000-00006a93", "c0d0c6cf1e86356f-aeaf598e03a3e657-r80000000800000-00006a93",
                    "c2c24b02188507d4-d2a45bd5df75ca3-r80000000800000-00006a93", "",
                    "", "",
                    "", "",
                    "", "",
                    "", "",
                    "", "");

            if (OfficerNapalm99Txt)
            {
                try
                {
                    ReplaceTextures(@"\_officer napalm 99\", "2f8add318e00dffe-dbf8c749768b6a20-r80000000800000-00006a93", "3b884e228a2ddccc-6ca9b2ddf9855dde-r80000000800000-00006a93",
                        "51a1eb3a94ed3d0b-70ef6e35a9c7907-r40000000400000-00006a94", "78dc2207d9d0230b-c372c05e72b419a3-r100000001000000-00006a93",
                        "93aced97c537dadb-198fe9df32188ec9-r80000000400000-00006a94", "a455c120cdead701-f525c46992390cf7-r80000000800000-00006a93",
                        "b6fb1ee4b707443a-3158ccfef51c70c-r80000000800000-00006a93", "c0d0c6cf1e86356f-aeaf598e03a3e657-r80000000800000-00006a93",
                        "c2c24b02188507d4-d2a45bd5df75ca3-r80000000800000-00006a93", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "");
                }
                catch
                {
                    OfficerNapalm99Txt = false;
                    notFound += "OfficerNapalm99Txt" + Environment.NewLine + "";
                }
            }
            else if (VolcanicNapalmTxt)
            {
                try
                {
                    ReplaceTextures(@"\_volcanic napalm 99\", "2f8add318e00dffe-dbf8c749768b6a20-r80000000800000-00006a93", "3b884e228a2ddccc-6ca9b2ddf9855dde-r80000000800000-00006a93",
                        "51a1eb3a94ed3d0b-70ef6e35a9c7907-r40000000400000-00006a94", "78dc2207d9d0230b-c372c05e72b419a3-r100000001000000-00006a93",
                        "93aced97c537dadb-198fe9df32188ec9-r80000000400000-00006a94", "a455c120cdead701-f525c46992390cf7-r80000000800000-00006a93",
                        "b6fb1ee4b707443a-3158ccfef51c70c-r80000000800000-00006a93", "c0d0c6cf1e86356f-aeaf598e03a3e657-r80000000800000-00006a93",
                        "c2c24b02188507d4-d2a45bd5df75ca3-r80000000800000-00006a93", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "");
                }
                catch
                {
                    VolcanicNapalmTxt = false;
                    notFound += "VolcanicNapalmTxt" + Environment.NewLine + "";
                }
            }
            else if (Napumpin99Txt)
            {
                try
                {
                    ReplaceTextures(@"\_NAPUMPKIN 99\", "", "3b884e228a2ddccc-6ca9b2ddf9855dde-r80000000800000-00006a93",
                        "51a1eb3a94ed3d0b-70ef6e35a9c7907-r40000000400000-00006a94", "78dc2207d9d0230b-c372c05e72b419a3-r100000001000000-00006a93",
                        "93aced97c537dadb-198fe9df32188ec9-r80000000400000-00006a94", "a455c120cdead701-f525c46992390cf7-r80000000800000-00006a93",
                        "b6fb1ee4b707443a-3158ccfef51c70c-r80000000800000-00006a93", "c0d0c6cf1e86356f-aeaf598e03a3e657-r80000000800000-00006a93",
                        "c2c24b02188507d4-d2a45bd5df75ca3-r80000000800000-00006a93", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "");
                }
                catch
                {
                    Napumpin99Txt = false;
                    notFound += "Napumpin99Txt" + Environment.NewLine + "";
                }
            }

            #endregion

            #region Golem [2D]

            RemoveTextures("4e68cae30e92a268-e8e9d36cc8bb9de1-r100000001000000-00006a93", "7ec4cbcec09b2b70-406bafaeada7d036-r20000000800000-00006a94",
                    "8cfaa2f011fe2964-1a7314e0b306ab48-r40000000400000-00006a93", "79bc5d739fd2ff17-c6135a01337a1074-r80000000800000-00006a93",
                    "a4468214ec8b66b3-6e307f1df097456f-r80000000800000-00006a94", "ccf524dc21e8b737-7fc1804312095485-r40000000800000-00006a93",
                    "ecf71533b2ff6ced-95bf315ecf6a58fd-r80000001000000-00006a93", "fa2c3994fdeba83a-1f4a4e8943630745-r10000000200000-00006a93",
                    "f0d69992fd364074-3501ac4f934b6879-r80000001000000-00006a93", "5e84fe8765c6c0a8-19f01fd4c0bff550-r40000000400000-00006a93",
                    "7d233f93c7403a0f-247b695a819a4cee-r20000000200000-00006a94", "d2f7e81ae43f261f-23fbf8d76f5fcf18-r10000000200000-00006a93",
                    "d7f6ec9479928174-8602a05de0f00d0b-00005114", "4e68cae30e92a268-e8e9d36cc8bb9de1-r256x256-00002a93",
                    "8cfaa2f011fe2964-1a7314e0b306ab48-r64x64-00002a93", "79bc5d739fd2ff17-c6135a01337a1074-r128x128-00002a93",
                    "a4468214ec8b66b3-6e307f1df097456f-r128x128-00002a94", "ccf524dc21e8b737-7fc1804312095485-r128x64-00002a93",
                    "ecf71533b2ff6ced-95bf315ecf6a58fd-r256x128-00002a93", "f0d69992fd364074-3501ac4f934b6879-r256x128-00002a93");

            if (GolemTuxedoTxt)
            {
                try
                {
                    ReplaceTextures(@"\_golem tuxedo\", "4e68cae30e92a268-e8e9d36cc8bb9de1-r100000001000000-00006a93", "7ec4cbcec09b2b70-406bafaeada7d036-r20000000800000-00006a94",
                        "8cfaa2f011fe2964-1a7314e0b306ab48-r40000000400000-00006a93", "79bc5d739fd2ff17-c6135a01337a1074-r80000000800000-00006a93",
                        "a4468214ec8b66b3-6e307f1df097456f-r80000000800000-00006a94", "ccf524dc21e8b737-7fc1804312095485-r40000000800000-00006a93",
                        "ecf71533b2ff6ced-95bf315ecf6a58fd-r80000001000000-00006a93", "fa2c3994fdeba83a-1f4a4e8943630745-r10000000200000-00006a93",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "");
                }
                catch
                {
                    GolemTuxedoTxt = false;
                    notFound += "GolemTuxedoTxt" + Environment.NewLine + "";
                }
            }
            else if (GolemShirtlessTxt)
            {
                try
                {
                    ReplaceTextures(@"\_golem shirtless\", "4e68cae30e92a268-e8e9d36cc8bb9de1-r100000001000000-00006a93", "7ec4cbcec09b2b70-406bafaeada7d036-r20000000800000-00006a94",
                        "8cfaa2f011fe2964-1a7314e0b306ab48-r40000000400000-00006a93", "79bc5d739fd2ff17-c6135a01337a1074-r80000000800000-00006a93",
                        "a4468214ec8b66b3-6e307f1df097456f-r80000000800000-00006a94", "ccf524dc21e8b737-7fc1804312095485-r40000000800000-00006a93",
                        "ecf71533b2ff6ced-95bf315ecf6a58fd-r80000001000000-00006a93", "fa2c3994fdeba83a-1f4a4e8943630745-r10000000200000-00006a93",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "");
                }
                catch
                {
                    GolemShirtlessTxt = false;
                    notFound += "GolemShirtlessTxt" + Environment.NewLine + "";
                }
            }
            else if (NightmareTxt)
            {
                try
                {
                    ReplaceTextures(@"\_golem nightmare\", "4e68cae30e92a268-e8e9d36cc8bb9de1-r100000001000000-00006a93", "7ec4cbcec09b2b70-406bafaeada7d036-r20000000800000-00006a94",
                        "8cfaa2f011fe2964-1a7314e0b306ab48-r40000000400000-00006a93", "79bc5d739fd2ff17-c6135a01337a1074-r80000000800000-00006a93",
                        "a4468214ec8b66b3-6e307f1df097456f-r80000000800000-00006a94", "ccf524dc21e8b737-7fc1804312095485-r40000000800000-00006a93",
                        "ecf71533b2ff6ced-95bf315ecf6a58fd-r80000001000000-00006a93", "fa2c3994fdeba83a-1f4a4e8943630745-r10000000200000-00006a93",
                        "f0d69992fd364074-3501ac4f934b6879-r80000001000000-00006a93", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "");
                }
                catch
                {
                    NightmareTxt = false;
                    notFound += "NightmareTxt" + Environment.NewLine + "";
                }
            }
            else if (GrolemTxt)
            {
                try
                {
                    ReplaceTextures(@"\_grolem\", "4e68cae30e92a268-e8e9d36cc8bb9de1-r100000001000000-00006a93", "",
                        "7ec4cbcec09b2b70-406bafaeada7d036-r20000000800000-00006a94", "8cfaa2f011fe2964-1a7314e0b306ab48-r40000000400000-00006a93",
                        "79bc5d739fd2ff17-c6135a01337a1074-r80000000800000-00006a93", "a4468214ec8b66b3-6e307f1df097456f-r80000000800000-00006a94",
                        "ccf524dc21e8b737-7fc1804312095485-r40000000800000-00006a93", "ecf71533b2ff6ced-95bf315ecf6a58fd-r80000001000000-00006a93",
                        "f0d69992fd364074-3501ac4f934b6879-r80000001000000-00006a93", "fa2c3994fdeba83a-1f4a4e8943630745-r10000000200000-00006a93",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "");
                }
                catch
                {
                    GrolemTxt = false;
                    notFound += "GrolemTxt" + Environment.NewLine + "";
                }
            }
            else if (GolemKratosTxt)
            {
                try
                {
                    ReplaceTextures(@"\_Kratos_Golem\", "4e68cae30e92a268-e8e9d36cc8bb9de1-r100000001000000-00006a93", "5e84fe8765c6c0a8-19f01fd4c0bff550-r40000000400000-00006a93",
                        "7d233f93c7403a0f-247b695a819a4cee-r20000000200000-00006a94", "7ec4cbcec09b2b70-406bafaeada7d036-r20000000800000-00006a94",
                        "8cfaa2f011fe2964-1a7314e0b306ab48-r40000000400000-00006a93", "79bc5d739fd2ff17-c6135a01337a1074-r80000000800000-00006a93",
                        "a4468214ec8b66b3-6e307f1df097456f-r80000000800000-00006a94", "ccf524dc21e8b737-7fc1804312095485-r40000000800000-00006a93",
                        "d2f7e81ae43f261f-23fbf8d76f5fcf18-r10000000200000-00006a93", "d7f6ec9479928174-8602a05de0f00d0b-00005114",
                        "ecf71533b2ff6ced-95bf315ecf6a58fd-r80000001000000-00006a93", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "");
                }
                catch
                {
                    GolemKratosTxt = false;
                    notFound += "GolemKratosTxt" + Environment.NewLine + "";
                }
            }
            else if (SubzeroGolemTxt)
            {
                try
                {
                    ReplaceTextures(@"\_subzero golem\", "4e68cae30e92a268-e8e9d36cc8bb9de1-r100000001000000-00006a93", "",
                        "7d233f93c7403a0f-247b695a819a4cee-r20000000200000-00006a94", "7ec4cbcec09b2b70-406bafaeada7d036-r20000000800000-00006a94",
                        "8cfaa2f011fe2964-1a7314e0b306ab48-r40000000400000-00006a93", "79bc5d739fd2ff17-c6135a01337a1074-r80000000800000-00006a93",
                        "a4468214ec8b66b3-6e307f1df097456f-r80000000800000-00006a94", "ccf524dc21e8b737-7fc1804312095485-r40000000800000-00006a93",
                        "", "d7f6ec9479928174-8602a05de0f00d0b-00005114",
                        "ecf71533b2ff6ced-95bf315ecf6a58fd-r80000001000000-00006a93", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "");
                }
                catch
                {
                    SubzeroGolemTxt = false;
                    notFound += "SubzeroGolemTxt" + Environment.NewLine + "";
                }
            }
            else if (MonsterEnergyGolemTxt)
            {
                try
                {
                    ReplaceTextures(@"\_MonsterEnergyGolem\", "", "",
                        "", "",
                        "", "79bc5d739fd2ff17-c6135a01337a1074-r80000000800000-00006a93",
                        "a4468214ec8b66b3-6e307f1df097456f-r80000000800000-00006a94", "ccf524dc21e8b737-7fc1804312095485-r40000000800000-00006a93",
                        "", "",
                        "ecf71533b2ff6ced-95bf315ecf6a58fd-r80000001000000-00006a93", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "");
                }
                catch
                {
                    MonsterEnergyGolemTxt = false;
                    notFound += "MonsterEnergyGolemTxt" + Environment.NewLine + "";
                }
            }
            else if (GolemusTxt)
            {
                try
                {
                    ReplaceTextures(@"\_Golemus\", "4e68cae30e92a268-e8e9d36cc8bb9de1-r100000001000000-00006a93", "",
                        "7ec4cbcec09b2b70-406bafaeada7d036-r20000000800000-00006a94", "8cfaa2f011fe2964-1a7314e0b306ab48-r40000000400000-00006a93",
                        "", "79bc5d739fd2ff17-c6135a01337a1074-r80000000800000-00006a93",
                        "a4468214ec8b66b3-6e307f1df097456f-r80000000800000-00006a94", "ccf524dc21e8b737-7fc1804312095485-r40000000800000-00006a93",
                        "", "",
                        "ecf71533b2ff6ced-95bf315ecf6a58fd-r80000001000000-00006a93", "f0d69992fd364074-3501ac4f934b6879-r80000001000000-00006a93",
                        "", "",
                        "", "",
                        "", "",
                        "", "");
                }
                catch
                {
                    GolemusTxt = false;
                    notFound += "GolemusTxt" + Environment.NewLine + "";
                }
            }
            else if (BrademTxt)
            {
                try
                {
                    ReplaceTextures(@"\_Bradem\", "4e68cae30e92a268-e8e9d36cc8bb9de1-r100000001000000-00006a93", "",
                        "7ec4cbcec09b2b70-406bafaeada7d036-r20000000800000-00006a94", "8cfaa2f011fe2964-1a7314e0b306ab48-r40000000400000-00006a93",
                        "", "",
                        "a4468214ec8b66b3-6e307f1df097456f-r80000000800000-00006a94", "ccf524dc21e8b737-7fc1804312095485-r40000000800000-00006a93",
                        "", "",
                        "ecf71533b2ff6ced-95bf315ecf6a58fd-r80000001000000-00006a93", "f0d69992fd364074-3501ac4f934b6879-r80000001000000-00006a93",
                        "", "",
                        "", "",
                        "", "",
                        "", "");
                }
                catch
                {
                    BrademTxt = false;
                    notFound += "BrademTxt" + Environment.NewLine + "";
                }
            }
            else if (BeachGolemTxt)
            {
                try
                {
                    ReplaceTextures(@"\_beach_golem\", "4e68cae30e92a268-e8e9d36cc8bb9de1-r256x256-00002a93", "",
                        "8cfaa2f011fe2964-1a7314e0b306ab48-r64x64-00002a93", "79bc5d739fd2ff17-c6135a01337a1074-r128x128-00002a93",
                        "", "",
                        "a4468214ec8b66b3-6e307f1df097456f-r128x128-00002a94", "ccf524dc21e8b737-7fc1804312095485-r128x64-00002a93",
                        "", "",
                        "ecf71533b2ff6ced-95bf315ecf6a58fd-r256x128-00002a93", "f0d69992fd364074-3501ac4f934b6879-r256x128-00002a93",
                        "", "",
                        "", "",
                        "", "",
                        "", "");
                }
                catch
                {
                    BeachGolemTxt = false;
                    notFound += "BeachGolemTxt" + Environment.NewLine + "";
                }
            }

            #endregion

            #region Riki [2E]

            RemoveTextures("2abbffac5103ce68-bd15fd36b71bd393-00005dd3", "2c9755a10e2d806c-daac6dbe8cf5be3f-r100000000800000-00006a93",
                    "706f75156b994a99-fc278e39b2296a67-000061d3", "b866637c98a98069-928c6e57b2bd38eb-00005dd3",
                    "c09819bd5426d7c0-8753812fb5fccb07-00005dd3", "",
                    "", "",
                    "", "",
                    "", "",
                    "", "",
                    "", "",
                    "", "",
                    "", "");

            if (RikiSkin)
            {
                try
                {
                    ReplaceTextures(@"\_promoted riki\", "2abbffac5103ce68-bd15fd36b71bd393-00005dd3", "2c9755a10e2d806c-daac6dbe8cf5be3f-r100000000800000-00006a93",
                        "706f75156b994a99-fc278e39b2296a67-000061d3", "b866637c98a98069-928c6e57b2bd38eb-00005dd3",
                        "c09819bd5426d7c0-8753812fb5fccb07-00005dd3", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "");
                }
                catch
                {
                    RikiSkin = false;
                    notFound += "PromotedRikiTxt" + Environment.NewLine + "";
                }
            }
            else if (RikiSkin2)
            {
                try
                {
                    ReplaceTextures(@"\_Mystic_Riki\", "2abbffac5103ce68-bd15fd36b71bd393-00005dd3", "2c9755a10e2d806c-daac6dbe8cf5be3f-r100000000800000-00006a93",
                        "706f75156b994a99-fc278e39b2296a67-000061d3", "b866637c98a98069-928c6e57b2bd38eb-00005dd3",
                        "c09819bd5426d7c0-8753812fb5fccb07-00005dd3", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "");
                }
                catch
                {
                    RikiSkin2 = false;
                    notFound += "Mystic_Riki" + Environment.NewLine + "";
                }
            }

            #endregion

            #region Masa [2F]

            RemoveTextures("956d3f24e5e5dbe7-b77623cfcf5d634f-00005dd3", "2147a0bddeea3b16-6d245e41c65493c2-00005dd3",
                    "28369d5eb1971e4-aec9fd4fc5396c6d-00005dd3", "72dcbf9863de80e6-5e9930b10c2ada34-r40000000400000-00006a93",
                    "626f9b0263fa8c5c-4cb45252dc475e2-r20000000200000-00006a93", "a2471d4ad00d9ec8-18ff11d8c3061116-00005993",
                    "a384988744886570-62f3040d17f3eda4-00005993", "fd3e4cb4b8e548f5-66ff4701a9b48e1d-r100000000800000-00006a93",
                    "", "",
                    "", "",
                    "", "",
                    "", "",
                    "", "",
                    "", "");

            if (MasaSkin)
            {
                try
                {
                    ReplaceTextures(@"\_crime boss Masa\", "956d3f24e5e5dbe7-b77623cfcf5d634f-00005dd3", "2147a0bddeea3b16-6d245e41c65493c2-00005dd3",
                        "28369d5eb1971e4-aec9fd4fc5396c6d-00005dd3", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "");
                }
                catch
                {
                    MasaSkin = false;
                    notFound += "CrimeBossMasaSkin" + Environment.NewLine + "";
                }
            }
            else if (EndangeredMasaTxt)
            {
                try
                {
                    ReplaceTextures(@"\_Endangered_Masa\", "956d3f24e5e5dbe7-b77623cfcf5d634f-00005dd3", "2147a0bddeea3b16-6d245e41c65493c2-00005dd3",
                        "28369d5eb1971e4-aec9fd4fc5396c6d-00005dd3", "72dcbf9863de80e6-5e9930b10c2ada34-r40000000400000-00006a93",
                        "626f9b0263fa8c5c-4cb45252dc475e2-r20000000200000-00006a93", "a2471d4ad00d9ec8-18ff11d8c3061116-00005993",
                        "a384988744886570-62f3040d17f3eda4-00005993", "fd3e4cb4b8e548f5-66ff4701a9b48e1d-r100000000800000-00006a93",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "");
                }
                catch
                {
                    EndangeredMasaTxt = false;
                    notFound += "EndangeredMasaTxt" + Environment.NewLine + "";
                }
            }

            #endregion

            #region Hiro [30]

            RemoveTextures("5a97dd25557be64e-d7a1eeb03f9a360e-000061d3", "66b2adab213b809d-c32b584c0ca00cad-00005dd3",
                        "929d0e47021b754a-37a972bd1894ffd2-000061d3", "9952dcfaa5263f09-e2331665e7cc24c4-00005dd3",
                        "91528719986402c8-fb5c65cf9d5a16cb-00005dd3", "f2f2e83961e2c0f6-ce614ebf74f89800-r20000000200000-00006a93",
                        "97f8ba9e98ea1b74-b14d40124ea75bf1-r40000000400000-00006a93", "a106039b4b4c5eb4-231d345d69d877df-r40000000400000-00006a93",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "");

            if (HiroSkin)
            {
                try
                {
                    ReplaceTextures(@"\_green_hiro\", "5a97dd25557be64e-d7a1eeb03f9a360e-000061d3", "66b2adab213b809d-c32b584c0ca00cad-00005dd3",
                        "929d0e47021b754a-37a972bd1894ffd2-000061d3", "9952dcfaa5263f09-e2331665e7cc24c4-00005dd3",
                        "91528719986402c8-fb5c65cf9d5a16cb-00005dd3", "f2f2e83961e2c0f6-ce614ebf74f89800-r20000000200000-00006a93",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "");
                }
                catch
                {
                    HiroSkin = false;
                    notFound += "GreenHiroSkin" + Environment.NewLine + "";
                }
            }
            else if (HiroGATTxt)
            {
                try
                {
                    ReplaceTextures(@"\_Hiro_GAT\", "5a97dd25557be64e-d7a1eeb03f9a360e-000061d3", "66b2adab213b809d-c32b584c0ca00cad-00005dd3",
                        "929d0e47021b754a-37a972bd1894ffd2-000061d3", "9952dcfaa5263f09-e2331665e7cc24c4-00005dd3",
                        "91528719986402c8-fb5c65cf9d5a16cb-00005dd3", "f2f2e83961e2c0f6-ce614ebf74f89800-r20000000200000-00006a93",
                        "97f8ba9e98ea1b74-b14d40124ea75bf1-r40000000400000-00006a93", "a106039b4b4c5eb4-231d345d69d877df-r40000000400000-00006a93",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "");
                }
                catch
                {
                    HiroGATTxt = false;
                    notFound += "HiroGATTxt" + Environment.NewLine + "";
                }
            }

            #endregion

            #region Ryuji [31]

            RemoveTextures("21cac5f0c5a78fb5-d4fbbb99ad16ba45-r80000000800000-00006a93", "245bbfef0bc8b1b7-2d91df8707a66dd7-00005dd3",
                        "bc89eb4e091fe15b-73f44f0ad224924a-00005dd3", "deab9d1e1b167aa9-d2be40c7bd22d154-r100000000800000-00006a93",
                    "", "",
                    "", "",
                    "", "",
                    "", "",
                    "", "",
                    "", "",
                    "", "",
                    "", "");

            if (RyujiSkin)
            {
                try
                {
                    ReplaceTextures(@"\_manager_ryuji\", "21cac5f0c5a78fb5-d4fbbb99ad16ba45-r80000000800000-00006a93", "245bbfef0bc8b1b7-2d91df8707a66dd7-00005dd3",
                        "bc89eb4e091fe15b-73f44f0ad224924a-00005dd3", "deab9d1e1b167aa9-d2be40c7bd22d154-r100000000800000-00006a93",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "");
                }
                catch
                {
                    RyujiSkin = false;
                    notFound += "ManagerRyujiSkin" + Environment.NewLine + "";
                }
            }
            else if (RyujiSkin2)
            {
                try
                {
                    ReplaceTextures(@"\_Wild_West_Ryuji\", "21cac5f0c5a78fb5-d4fbbb99ad16ba45-r80000000800000-00006a93", "245bbfef0bc8b1b7-2d91df8707a66dd7-00005dd3",
                        "bc89eb4e091fe15b-73f44f0ad224924a-00005dd3", "deab9d1e1b167aa9-d2be40c7bd22d154-r100000000800000-00006a93",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "");
                }
                catch
                {
                    RyujiSkin2 = false;
                    notFound += "Wild_West_Ryuji" + Environment.NewLine + "";
                }
            }

            #endregion

            #region Ye Wei [32]

            RemoveTextures("3d876e9ed914f483-f2e5a3e0b85a445c-r100000001000000-00006a93", "38345d6ad08b1141-3a03cad730e7fa4-r10000000400000-00006a93",
                    "48123ef3e7035cae-518c6575d9b5d701-r80000000800000-00006a93", "487148360c63ee06-886cf56db5471833-r20000000200000-00006a93",
                    "b4637d2bd2f024c9-66cfdb1c86d30455-r40000000400000-00006a93", "bfdb5a117be9b063-6407bbbceb89bb5d-r40000000400000-00006a93",
                    "94a1cb930c3f2cfb-c1c0bedf28cb2483-r40000000400000-00006a93", "16626568e1329ae1-ac52b80b48f7c810-r40000000400000-00006a93",
                    "b4f310f1806f11eb-3677c00df5e9e094-r20000000400000-00006a93", "b22e56f04df294d9-d27b891641febb0d-r40000000400000-00006a93",
                    "a8e99a8ea131c2c1-1c9e452fa0f65a0f-r40000000400000-00006a93", "",
                    "", "",
                    "", "",
                    "", "",
                    "", "");

            if (YeWeiSkin)
            {
                try
                {
                    ReplaceTextures(@"\_terrorist Yei Wei\", "3d876e9ed914f483-f2e5a3e0b85a445c-r100000001000000-00006a93", "38345d6ad08b1141-3a03cad730e7fa4-r10000000400000-00006a93",
                        "48123ef3e7035cae-518c6575d9b5d701-r80000000800000-00006a93", "487148360c63ee06-886cf56db5471833-r20000000200000-00006a93",
                        "b4637d2bd2f024c9-66cfdb1c86d30455-r40000000400000-00006a93", "bfdb5a117be9b063-6407bbbceb89bb5d-r40000000400000-00006a93",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "");
                }
                catch
                {
                    YeWeiSkin = false;
                    notFound += "TerroristYeWeiSkin" + Environment.NewLine + "";
                }
            }
            else if (YeWeiSkin2)
            {
                try
                {
                    ReplaceTextures(@"\_Rooster_Wei\", "3d876e9ed914f483-f2e5a3e0b85a445c-r100000001000000-00006a93", "94a1cb930c3f2cfb-c1c0bedf28cb2483-r40000000400000-00006a93",
                        "38345d6ad08b1141-3a03cad730e7fa4-r10000000400000-00006a93", "48123ef3e7035cae-518c6575d9b5d701-r80000000800000-00006a93",
                        "16626568e1329ae1-ac52b80b48f7c810-r40000000400000-00006a93", "487148360c63ee06-886cf56db5471833-r20000000200000-00006a93",
                        "a8e99a8ea131c2c1-1c9e452fa0f65a0f-r40000000400000-00006a93", "b4f310f1806f11eb-3677c00df5e9e094-r20000000400000-00006a93",
                        "b22e56f04df294d9-d27b891641febb0d-r40000000400000-00006a93", "bfdb5a117be9b063-6407bbbceb89bb5d-r40000000400000-00006a93",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "");
                }
                catch
                {
                    YeWeiSkin2 = false;
                    notFound += "Rooster_Wei" + Environment.NewLine + "";
                }
            }

            #endregion

            #region Sha Ying [33]

            RemoveTextures("3af15f51ac2e0a68-ed5d3c32b615a4ab-r40000000400000-00006a93", "3cc45c51c037c8e7-5d0f59543d40789-r100000001000000-00006a93",
                    "4e94cc5bc949636e-3ed71876cd54e40-r80000000800000-00006a93", "6e361a23da0341b6-703d20636ca3e857-r100000001000000-00006a93",
                    "7b759cbc3c9f2ff7-ea431bde064285ec-r20000000200000-00006a93", "27abe9dcb72843d8-ee0558c707c7e05b-r20000000200000-00006a93",
                    "c967e8705bf54685-4b557f72f2d1a4f3-r40000000400000-00006a93", "d8dc45e840fa0a71-2b736c1766053560-r40000000400000-00006a93",
                    "d65e78379d9798e3-8b85828762593023-r10000000200000-00006a93", "e9ba38c669f8ad90-64d362ebb79f7637-r40000000400000-00006a93",
                    "ef96230ed0ac8d00-6aa659076fea2ef5-r80000000800000-00006a93", "c9a563cf643792dc-9c203ce3767f1532-r40000000400000-00006a93",
                    "", "",
                    "", "",
                    "", "",
                    "", "");

            if (ShaYingSkin)
            {
                try
                {
                    ReplaceTextures(@"\_Elvis Sha Ying\", "3af15f51ac2e0a68-ed5d3c32b615a4ab-r40000000400000-00006a93", "3cc45c51c037c8e7-5d0f59543d40789-r100000001000000-00006a93",
                        "4e94cc5bc949636e-3ed71876cd54e40-r80000000800000-00006a93", "6e361a23da0341b6-703d20636ca3e857-r100000001000000-00006a93",
                        "7b759cbc3c9f2ff7-ea431bde064285ec-r20000000200000-00006a93", "27abe9dcb72843d8-ee0558c707c7e05b-r20000000200000-00006a93",
                        "c967e8705bf54685-4b557f72f2d1a4f3-r40000000400000-00006a93", "d8dc45e840fa0a71-2b736c1766053560-r40000000400000-00006a93",
                        "d65e78379d9798e3-8b85828762593023-r10000000200000-00006a93", "e9ba38c669f8ad90-64d362ebb79f7637-r40000000400000-00006a93",
                        "ef96230ed0ac8d00-6aa659076fea2ef5-r80000000800000-00006a93", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "");
                }
                catch
                {
                    ShaYingSkin = false;
                    notFound += "ElvisShaYingSkin" + Environment.NewLine + "";
                }
            }
            else if (ShaYingSkin2)
            {
                try
                {
                    ReplaceTextures(@"\_Golden_Dragon_Sha_Ying_Lai\", "3af15f51ac2e0a68-ed5d3c32b615a4ab-r40000000400000-00006a93", "4e94cc5bc949636e-3ed71876cd54e40-r80000000800000-00006a93",
                        "6e361a23da0341b6-703d20636ca3e857-r100000001000000-00006a93", "7b759cbc3c9f2ff7-ea431bde064285ec-r20000000200000-00006a93",
                        "c9a563cf643792dc-9c203ce3767f1532-r40000000400000-00006a93", "c967e8705bf54685-4b557f72f2d1a4f3-r40000000400000-00006a93",
                        "d8dc45e840fa0a71-2b736c1766053560-r40000000400000-00006a93", "e9ba38c669f8ad90-64d362ebb79f7637-r40000000400000-00006a93",
                        "ef96230ed0ac8d00-6aa659076fea2ef5-r80000000800000-00006a93", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "");
                }
                catch
                {
                    ShaYingSkin2 = false;
                    notFound += "Golden_Dragon_Sha_Ying_Lai" + Environment.NewLine + "";
                }
            }

            #endregion

            #region Yan Jun [34]

            RemoveTextures("5c70a8d4aeabf12e-42dd6614582a891e-r8000000200000-00006a93", "6b2a2a1b6d61b34b-eff749543c17ddf2-r20000000400000-00006a93",
                    "61c43781bc7a125-9a4ebae94a393066-r100000001000000-00006a93", "66c60e88026d3319-8c27b1ff4c53c4ed-r20000000200000-00006a93",
                    "600760ea5bdb7913-b98b8aef390065dd-r80000000800000-00006a93", "a1610c9ea3ba80a0-59a43dbcd583febc-r40000000400000-00006a93",
                    "a19436e54ed12275-a4f5d64d5e60946c-r80000000800000-00006a93", "b664ac9aed739df0-64f47b33f9bef45b-r20000000400000-00006a93",
                    "ba01ab68f3b2ed30-3c31b496d3cc03fd-r1c0000002800000-00006694", "c6dfdb0056f6f24b-f3bbbc4ed6b907c9-r20000000200000-00006a93",
                    "c9a563cf643792dc-9c203ce3767f1532-r40000000400000-00006a93", "c85f7601f0dfd421-7d06977d775f6215-r10000000200000-00006a93",
                    "cab00981296f0372-f079807a94443613-r40000000400000-00006a93", "e925fa564cc229e6-43dc385f1cfe5fdb-r20000000400000-00006a94",
                    "ec8ae5ca86e75264-cea50d9db77c8e44-r100000001000000-00006a93", "fb97505ae642194d-7c5dbd7e4e4971dd-r40000000400000-00006a93",
                    "", "",
                    "", "");

            if (YanJunDrunkenFistTxt)
            {
                try
                {
                    ReplaceTextures(@"\_yan jun drunken fist\", "5c70a8d4aeabf12e-42dd6614582a891e-r8000000200000-00006a93", "6b2a2a1b6d61b34b-eff749543c17ddf2-r20000000400000-00006a93",
                        "61c43781bc7a125-9a4ebae94a393066-r100000001000000-00006a93", "66c60e88026d3319-8c27b1ff4c53c4ed-r20000000200000-00006a93",
                        "600760ea5bdb7913-b98b8aef390065dd-r80000000800000-00006a93", "a1610c9ea3ba80a0-59a43dbcd583febc-r40000000400000-00006a93",
                        "a19436e54ed12275-a4f5d64d5e60946c-r80000000800000-00006a93", "b664ac9aed739df0-64f47b33f9bef45b-r20000000400000-00006a93",
                        "ba01ab68f3b2ed30-3c31b496d3cc03fd-r1c0000002800000-00006694", "c6dfdb0056f6f24b-f3bbbc4ed6b907c9-r20000000200000-00006a93",
                        "c9a563cf643792dc-9c203ce3767f1532-r40000000400000-00006a93", "c85f7601f0dfd421-7d06977d775f6215-r10000000200000-00006a93",
                        "cab00981296f0372-f079807a94443613-r40000000400000-00006a93", "e925fa564cc229e6-43dc385f1cfe5fdb-r20000000400000-00006a94",
                        "ec8ae5ca86e75264-cea50d9db77c8e44-r100000001000000-00006a93", "fb97505ae642194d-7c5dbd7e4e4971dd-r40000000400000-00006a93",
                        "", "",
                        "", "");
                }
                catch
                {
                    YanJunDrunkenFistTxt = false;
                    notFound += "YanJunDrunkenFistTxt" + Environment.NewLine + "";
                }
            }
            else if (YanJunSkin2)
            {
                try
                {
                    ReplaceTextures(@"\_Farmer_Yan_Jun\", "61c43781bc7a125-9a4ebae94a393066-r100000001000000-00006a93", "600760ea5bdb7913-b98b8aef390065dd-r80000000800000-00006a93",
                        "a19436e54ed12275-a4f5d64d5e60946c-r80000000800000-00006a93", "b664ac9aed739df0-64f47b33f9bef45b-r20000000400000-00006a93",
                        "cab00981296f0372-f079807a94443613-r40000000400000-00006a93", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "");
                }
                catch
                {
                    YanJunSkin2 = false;
                    notFound += "Farmer_Yan_Jun" + Environment.NewLine + "";
                }
            }

            #endregion

            #region Shinkai [35]

            RemoveTextures("2b3c368bbeaa63c7-6f9a572b7024b0b0-r40000000200000-00006a93", "7b641a3f12ccee3b-da8eaacd17312e19-r100000001000000-00006a93",
                    "42afb3fddbd20e5f-d7c176c7c88f7aef-r80000000800000-00006a93", "45ebd6d5e8a112e0-b98e4b521ed2fdc7-r20000000200000-00006a93",
                    "66c60e88026d3319-8c27b1ff4c53c4ed-r20000000200000-00006a93", "111d8c53fba0092a-4ceeb86ecb1d7d08-r80000000800000-00006a93",
                    "497c0f32b5e67135-1d4f481018a5e7ab-r20000000200000-00006a93", "674e5072e1b90a64-d4d9247a5016beba-r80000000800000-00006a93",
                    "2263417f375061b4-fd3aad2e2f392885-r40000000400000-00006a93", "8465025957e3b334-4628b248da283aee-r27000002800000-00005a94",
                    "b327e1f5499639c3-23c91344ce09d12e-r80000000800000-00006a93", "b523c1606d8fc1a5-80797b6f76e6d49-r40000000800000-00006a93",
                    "e88e8cdcfd949421-91369cc4e82daf49-r10000000400000-00006a93", "e925fa564cc229e6-43dc385f1cfe5fdb-r20000000400000-00006a94",
                    "f253590f2662c48f-24f4d877bf1d60b6-r2800000-00005a93", "ff4a894ee8077506-fb7998a8c39a1721-r80000000400000-00006a93",
                    "", "",
                    "", "");
            
            if (Shinkai007Txt)
            {
                try
                {
                    ReplaceTextures(@"\_007 shinkai\", "2b3c368bbeaa63c7-6f9a572b7024b0b0-r40000000200000-00006a93", "7b641a3f12ccee3b-da8eaacd17312e19-r100000001000000-00006a93",
                        "42afb3fddbd20e5f-d7c176c7c88f7aef-r80000000800000-00006a93", "45ebd6d5e8a112e0-b98e4b521ed2fdc7-r20000000200000-00006a93",
                        "66c60e88026d3319-8c27b1ff4c53c4ed-r20000000200000-00006a93", "111d8c53fba0092a-4ceeb86ecb1d7d08-r80000000800000-00006a93",
                        "497c0f32b5e67135-1d4f481018a5e7ab-r20000000200000-00006a93", "674e5072e1b90a64-d4d9247a5016beba-r80000000800000-00006a93",
                        "2263417f375061b4-fd3aad2e2f392885-r40000000400000-00006a93", "8465025957e3b334-4628b248da283aee-r27000002800000-00005a94",
                        "b327e1f5499639c3-23c91344ce09d12e-r80000000800000-00006a93", "b523c1606d8fc1a5-80797b6f76e6d49-r40000000800000-00006a93",
                        "e88e8cdcfd949421-91369cc4e82daf49-r10000000400000-00006a93", "e925fa564cc229e6-43dc385f1cfe5fdb-r20000000400000-00006a94",
                        "f253590f2662c48f-24f4d877bf1d60b6-r2800000-00005a93", "ff4a894ee8077506-fb7998a8c39a1721-r80000000400000-00006a93",
                        "", "",
                        "", "");
                }
                catch
                {
                    Shinkai007Txt = false;
                    notFound += "Shinkai007Txt" + Environment.NewLine + "";
                }
            }
            else if (OldMasterShinkaiTxt)
            {
                try
                {
                    ReplaceTextures(@"\_old master Shinkai\", "2b3c368bbeaa63c7-6f9a572b7024b0b0-r40000000200000-00006a93", "7b641a3f12ccee3b-da8eaacd17312e19-r100000001000000-00006a93",
                        "42afb3fddbd20e5f-d7c176c7c88f7aef-r80000000800000-00006a93", "",
                        "", "",
                        "", "674e5072e1b90a64-d4d9247a5016beba-r80000000800000-00006a93",
                        "2263417f375061b4-fd3aad2e2f392885-r40000000400000-00006a93", "",
                        "b327e1f5499639c3-23c91344ce09d12e-r80000000800000-00006a93", "b523c1606d8fc1a5-80797b6f76e6d49-r40000000800000-00006a93",
                        "e88e8cdcfd949421-91369cc4e82daf49-r10000000400000-00006a93", "",
                        "", "ff4a894ee8077506-fb7998a8c39a1721-r80000000400000-00006a93",
                        "", "",
                        "", "");
                }
                catch
                {
                    OldMasterShinkaiTxt = false;
                    notFound += "OldMasterShinkaiTxt" + Environment.NewLine + "";
                }
            }

            #endregion

            #region Lin Fong Lee [36]

            RemoveTextures("5dbd12bdb591075-906bc43aeeb63b36-r40000001000000-00006a93", "7cd21b0bb307e87c-27b12ac9169dc9a8-r20000000200000-00006a93",
                    "8b006a17b68d428f-a1cfcfee40080d42-r40000000400000-00006a93", "17b0524a29e628d7-73cef847635d5321-r20000000400000-00006a93",
                    "91945bd3bae8dfeb-88a2de4e10d2a240-r100000001000000-00006a93", "364646c61210a4d0-6a91c578d0a52a6d-r80000000800000-00006a93",
                    "a7f0d7e7b318fa96-597507f2406c3451-r20000000400000-00006a93", "a3491050b8a1567f-616fbfc92d84729-r80000000800000-00006a93",
                    "b155553e65819fd2-71846129b72184ee-r80000000800000-00006a93", "c5013ac577525dc1-8babad4a37ebde06-r80000000800000-00006a93",
                    "c5286db334fc1b1e-7d4b5da844407b25-r10000000100000-00006a93", "dc8e07967ddab0e3-630838f549071f68-r10000000200000-00006a93",
                    "2a2d4ae0ff4eb52f-ff48ddbaa7a22a74-r20000000400000-00006a93", "4f16e5edad363d2b-5fa3f13b9e8e7735-r10000000200000-00006a93",
                    "", "",
                    "", "",
                    "", "");

            if (LinFongLeeSkin)
            {
                try
                {
                    ReplaceTextures(@"\_triads boss Lin Fong\", "5dbd12bdb591075-906bc43aeeb63b36-r40000001000000-00006a93", "7cd21b0bb307e87c-27b12ac9169dc9a8-r20000000200000-00006a93",
                        "8b006a17b68d428f-a1cfcfee40080d42-r40000000400000-00006a93", "17b0524a29e628d7-73cef847635d5321-r20000000400000-00006a93",
                        "91945bd3bae8dfeb-88a2de4e10d2a240-r100000001000000-00006a93", "364646c61210a4d0-6a91c578d0a52a6d-r80000000800000-00006a93",
                        "a7f0d7e7b318fa96-597507f2406c3451-r20000000400000-00006a93", "a3491050b8a1567f-616fbfc92d84729-r80000000800000-00006a93",
                        "b155553e65819fd2-71846129b72184ee-r80000000800000-00006a93", "c5013ac577525dc1-8babad4a37ebde06-r80000000800000-00006a93",
                        "c5286db334fc1b1e-7d4b5da844407b25-r10000000100000-00006a93", "dc8e07967ddab0e3-630838f549071f68-r10000000200000-00006a93",
                        "", "",
                        "", "",
                        "", "",
                        "", "");
                }
                catch
                {
                    LinFongLeeSkin = false;
                    notFound += "LinFongLeeSkin" + Environment.NewLine + "";
                }
            }
            else if (TuxLinTxt)
            {
                try
                {
                    ReplaceTextures(@"\_Tux_Lin\", "2a2d4ae0ff4eb52f-ff48ddbaa7a22a74-r20000000400000-00006a93", "4f16e5edad363d2b-5fa3f13b9e8e7735-r10000000200000-00006a93",
                        "7cd21b0bb307e87c-27b12ac9169dc9a8-r20000000200000-00006a93", "364646c61210a4d0-6a91c578d0a52a6d-r80000000800000-00006a93",
                        "a3491050b8a1567f-616fbfc92d84729-r80000000800000-00006a93", "b155553e65819fd2-71846129b72184ee-r80000000800000-00006a93",
                        "c5013ac577525dc1-8babad4a37ebde06-r80000000800000-00006a93", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "");
                }
                catch
                {
                    TuxLinTxt = false;
                    notFound += "TuxLinTxt" + Environment.NewLine + "";
                }
            }
            else if (CEOLinFongTxt)
            {
                try
                {
                    ReplaceTextures(@"\_CEO_Lin_Fong\", "8b006a17b68d428f-a1cfcfee40080d42-r40000000400000-00006a93", "364646c61210a4d0-6a91c578d0a52a6d-r80000000800000-00006a93",
                        "a7f0d7e7b318fa96-597507f2406c3451-r20000000400000-00006a93", "a3491050b8a1567f-616fbfc92d84729-r80000000800000-00006a93",
                        "c5013ac577525dc1-8babad4a37ebde06-r80000000800000-00006a93", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "");
                }
                catch
                {
                    CEOLinFongTxt = false;
                    notFound += "CEOLinFongTxt" + Environment.NewLine + "";
                }
            }

            #endregion

            #region Bordin [37]

            RemoveTextures("1cba52125bfc0c99-47432584bd80a917-r100000000800000-00006a93", "1d64591bcd7344fe-90f877445413c658-r20000000200000-00006a94",
                    "5ab20ecbbbc5718-ae66b7b30b3c2598-r100000000800000-00006a93", "9b3211cf3abadab7-5727d3f2b0f82060-r80000000200000-00006a93",
                    "2047c842e0f60bb5-740438c341e4189c-r80000000800000-00006a94", "2277ed083b8512-3d878ce77afd052b-r80000000800000-00006a94",
                    "86678c12c81862cb-5d1ecfd54ed286bc-r80000000800000-00006a94", "79351254fc91782a-f141d47d5767f5b8-r40000000400000-00006a93",
                    "a7c3048502dc13cc-1f9dbd8a1cdc7f70-r80000000800000-00006a94", "a98a74a530aafecd-be5a5b844195dbb3-r10000000200000-00006a94",
                    "ce33712957aa2726-e293a7ad75aeafc8-r100000000800000-00006a93", "f88b1bbe8b2fc8f4-8e4d739294f0800-r40000000800000-00006a93",
                    "f4387f3c3c375199-b555987027d0534a-r40000000400000-00006a93", "",
                    "", "",
                    "", "",
                    "", "");

            if (HellsLegionBordinTxt)
            {
                try
                {
                    ReplaceTextures(@"\_hells legion bordin\", "1cba52125bfc0c99-47432584bd80a917-r100000000800000-00006a93", "1d64591bcd7344fe-90f877445413c658-r20000000200000-00006a94",
                        "5ab20ecbbbc5718-ae66b7b30b3c2598-r100000000800000-00006a93", "9b3211cf3abadab7-5727d3f2b0f82060-r80000000200000-00006a93",
                        "2047c842e0f60bb5-740438c341e4189c-r80000000800000-00006a94", "2277ed083b8512-3d878ce77afd052b-r80000000800000-00006a94",
                        "86678c12c81862cb-5d1ecfd54ed286bc-r80000000800000-00006a94", "79351254fc91782a-f141d47d5767f5b8-r40000000400000-00006a93",
                        "a7c3048502dc13cc-1f9dbd8a1cdc7f70-r80000000800000-00006a94", "a98a74a530aafecd-be5a5b844195dbb3-r10000000200000-00006a94",
                        "ce33712957aa2726-e293a7ad75aeafc8-r100000000800000-00006a93", "f88b1bbe8b2fc8f4-8e4d739294f0800-r40000000800000-00006a93",
                        "f4387f3c3c375199-b555987027d0534a-r40000000400000-00006a93", "",
                        "", "",
                        "", "",
                        "", "");
                }
                catch
                {
                    HellsLegionBordinTxt = false;
                    notFound += "HellsLegionBordinTxt" + Environment.NewLine + "";
                }
            }
            else if (MartialArtistBordinTxt)
            {
                try
                {
                    ReplaceTextures(@"\_Martial_Artist_Bordin\", "1cba52125bfc0c99-47432584bd80a917-r100000000800000-00006a93", "",
                        "5ab20ecbbbc5718-ae66b7b30b3c2598-r100000000800000-00006a93", "9b3211cf3abadab7-5727d3f2b0f82060-r80000000200000-00006a93",
                        "2047c842e0f60bb5-740438c341e4189c-r80000000800000-00006a94", "2277ed083b8512-3d878ce77afd052b-r80000000800000-00006a94",
                        "86678c12c81862cb-5d1ecfd54ed286bc-r80000000800000-00006a94", "",
                        "a7c3048502dc13cc-1f9dbd8a1cdc7f70-r80000000800000-00006a94", "",
                        "ce33712957aa2726-e293a7ad75aeafc8-r100000000800000-00006a93", "f88b1bbe8b2fc8f4-8e4d739294f0800-r40000000800000-00006a93",
                        "f4387f3c3c375199-b555987027d0534a-r40000000400000-00006a93", "",
                        "", "",
                        "", "",
                        "", "");
                }
                catch
                {
                    MartialArtistBordinTxt = false;
                    notFound += "MartialArtistBordinTxt" + Environment.NewLine + "";
                }
            }

            #endregion

            #region Lilian [38]

            RemoveTextures("4e5e6a88f06f3297-fe660c169b709602-r10000000200000-00006a93", "5c826638598dfd4f-d9bdfaa859044503-r20000000400000-00006a93",
                    "61bc644738854138-f340962274d889a6-r40000000400000-00006a93", "703b9a13c4dee601-6920457a99f9e5c1-r80000001000000-00006a93",
                    "3087407ebca62158-28a45232ebaf37f8-r40000000400000-00006a93", "9081381aef6fbe74-dfa1ed9d66e29643-r80000000800000-00006a93",
                    "435117438ec31d17-17a0afa22800aa1e-r40000000400000-00006a93", "726730657411b344-24b77bfe9cc9b439-r20000000200000-00006a93",
                    "a009e0ded7287a5d-ca387ce2151bf405-r40000000400000-00006a93", "acc118c729302b21-1a2ec9ffd3eaf8d7-r40000000400000-00006a93",
                    "b62af87b16e4a0b7-a763fe4d7a1959c3-r40000000400000-00006a93", "b1500f058546515d-d4378fb4a7e94c05-r25000000200000-00006a93",
                    "c9fdc5ddf85e8184-3c3d298f7ce763e6-r100000000800000-00006a93", "c43c69783ab4c924-a0d2a09126c9d59-r20000000400000-00006a93",
                    "d0ad6dc0ad6fe078-4793feb75b2d26b1-r40000000400000-00006a93", "ee405b8e607248a0-39381c4f8282fca6-r40000000400000-00006a93",
                    "", "",
                    "", "");

            if (GeishaLilianTxt)
            {
                try
                {
                    ReplaceTextures(@"\_geisha lilian\", "5c826638598dfd4f-d9bdfaa859044503-r20000000400000-00006a93", "703b9a13c4dee601-6920457a99f9e5c1-r80000001000000-00006a93",
                        "9081381aef6fbe74-dfa1ed9d66e29643-r80000000800000-00006a93", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "");
                }
                catch
                {
                    GeishaLilianTxt = false;
                    notFound += "GeishaLilianTxt" + Environment.NewLine + "";
                }
            }
            else if (RebeccaChambersTxt)
            {
                try
                {
                    ReplaceTextures(@"\_RebeccaChambersLilianMod\", "4e5e6a88f06f3297-fe660c169b709602-r10000000200000-00006a93", "5c826638598dfd4f-d9bdfaa859044503-r20000000400000-00006a93",
                        "61bc644738854138-f340962274d889a6-r40000000400000-00006a93", "703b9a13c4dee601-6920457a99f9e5c1-r80000001000000-00006a93",
                        "3087407ebca62158-28a45232ebaf37f8-r40000000400000-00006a93", "9081381aef6fbe74-dfa1ed9d66e29643-r80000000800000-00006a93",
                        "435117438ec31d17-17a0afa22800aa1e-r40000000400000-00006a93", "726730657411b344-24b77bfe9cc9b439-r20000000200000-00006a93",
                        "a009e0ded7287a5d-ca387ce2151bf405-r40000000400000-00006a93", "acc118c729302b21-1a2ec9ffd3eaf8d7-r40000000400000-00006a93",
                        "b62af87b16e4a0b7-a763fe4d7a1959c3-r40000000400000-00006a93", "b1500f058546515d-d4378fb4a7e94c05-r25000000200000-00006a93",
                        "c9fdc5ddf85e8184-3c3d298f7ce763e6-r100000000800000-00006a93", "c43c69783ab4c924-a0d2a09126c9d59-r20000000400000-00006a93",
                        "d0ad6dc0ad6fe078-4793feb75b2d26b1-r40000000400000-00006a93", "ee405b8e607248a0-39381c4f8282fca6-r40000000400000-00006a93",
                        "", "",
                        "", "");
                }
                catch
                {
                    RebeccaChambersTxt = false;
                    notFound += "RebeccaChambersTxt" + Environment.NewLine + "";
                }
            }

            #endregion

            #region Kelly [39]

            RemoveTextures("3cee11e0b06664fd-fbcb53eb6942a31-r40000000400000-00006a93", "4ad463217f0795f5-c397ae7287ae91fb-r20000000400000-00006a93",
                        "46bcd8a5ec645d2-868e93cef453dd85-r80000000800000-00006a93", "61dab2c9270ff296-6cfc4be2aa867b10-r20000000400000-00006a93",
                        "774eb737a56d2b85-19f0d62fcdd81efa-r40000000800000-00006a93", "95714e3e68dbc1ab-b969971e6c70d5ba-r80000000800000-00006a93",
                        "a08b9996637b75bf-261509c975aa4aba-r100000000800000-00006a93", "a08b9996637b75bf-261509c975aa4aba-r100000000800000-00006a93",
                        "a01982474cb10635-ee5ebd555fb61c52-r20000000400000-00006a93", "afb0637c6c1788b9-ce6b06ffc8d77311-r40000000400000-00006a93",
                        "b62d2d64fb928836-fec8ea6f9fa5c605-r20000000400000-00006a93", "be6033ebc55fcd89-7c78a284de610dc-r80000000800000-00006a93",
                        "da0000b37d1d8ccf-6ea4faee219e63d-r80000000400000-00006a93", "",
                        "deef6e93102e530e-434134a47af39a7b-r20000000400000-00006a93", "dff1b9cf479cbb00-83e27735126246dd-r40000000400000-00006a93",
                        "e79df0c15c56670-60bb7e328ba2a8da-r20000000400000-00006a93", "e925fa564cc229e6-43dc385f1cfe5fdb-r20000000400000-00006a94",
                    "", "");

            if (SpyKellyTxt)
            {
                try
                {
                    ReplaceTextures(@"\_spy kelly\", "3cee11e0b06664fd-fbcb53eb6942a31-r40000000400000-00006a93", "4ad463217f0795f5-c397ae7287ae91fb-r20000000400000-00006a93",
                        "46bcd8a5ec645d2-868e93cef453dd85-r80000000800000-00006a93", "95714e3e68dbc1ab-b969971e6c70d5ba-r80000000800000-00006a93",
                        "afb0637c6c1788b9-ce6b06ffc8d77311-r40000000400000-00006a93", "be6033ebc55fcd89-7c78a284de610dc-r80000000800000-00006a93",
                        "da0000b37d1d8ccf-6ea4faee219e63d-r80000000400000-00006a93", "dff1b9cf479cbb00-83e27735126246dd-r40000000400000-00006a93",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "");
                }
                catch
                {
                    SpyKellyTxt = false;
                    notFound += "SpyKellyTxt" + Environment.NewLine + "";
                }
            }
            else if (KellySkin2)
            {
                try
                {
                    ReplaceTextures(@"\_Techwear_Kelly\", "3cee11e0b06664fd-fbcb53eb6942a31-r40000000400000-00006a93", "4ad463217f0795f5-c397ae7287ae91fb-r20000000400000-00006a93",
                        "46bcd8a5ec645d2-868e93cef453dd85-r80000000800000-00006a93", "61dab2c9270ff296-6cfc4be2aa867b10-r20000000400000-00006a93",
                        "774eb737a56d2b85-19f0d62fcdd81efa-r40000000800000-00006a93", "95714e3e68dbc1ab-b969971e6c70d5ba-r80000000800000-00006a93",
                        "a08b9996637b75bf-261509c975aa4aba-r100000000800000-00006a93", "a08b9996637b75bf-261509c975aa4aba-r100000000800000-00006a93",
                        "a01982474cb10635-ee5ebd555fb61c52-r20000000400000-00006a93", "afb0637c6c1788b9-ce6b06ffc8d77311-r40000000400000-00006a93",
                        "b62d2d64fb928836-fec8ea6f9fa5c605-r20000000400000-00006a93", "be6033ebc55fcd89-7c78a284de610dc-r80000000800000-00006a93",
                        "da0000b37d1d8ccf-6ea4faee219e63d-r80000000400000-00006a93", "",
                        "deef6e93102e530e-434134a47af39a7b-r20000000400000-00006a93", "dff1b9cf479cbb00-83e27735126246dd-r40000000400000-00006a93",
                        "e79df0c15c56670-60bb7e328ba2a8da-r20000000400000-00006a93", "e925fa564cc229e6-43dc385f1cfe5fdb-r20000000400000-00006a94",
                        "", "");
                }
                catch
                {
                    KellySkin2 = false;
                    notFound += "Techwear_Kelly" + Environment.NewLine + "";
                }
            }

            #endregion

            #region Vera [3A]

            RemoveTextures("1c41837caac15126-8084a99333069c87-r40000000400000-00006a93", "3e5b0ca356f91c6e-6bdcaf3f048ce0ad-r80000000800000-00006a94",
                    "5c0ad25f95ac3952-4dd3d7c7cfb9267a-r80000000800000-00006a93", "74f7651ac4457ba8-f7faa638c76fd9ed-r80000000800000-00006a94",
                    "32024dd6713dd590-65e2d9143e241866-r80000000800000-00006a93", "718767f4116755c3-1488bf8b0d7cce54-r10000000400000-00006a94",
                    "6095333d706ba3e8-d65bf613388a29c6-r20000000400000-00006a94", "9de0ae9238331a69-244ca83b6a2ec8f2-r40000000800000-00006a93",
                    "12c03d7679b44980-e1a41ad647eb4ae5-r80000000800000-00006a93", "83785f128cc3da-31b2df4d77106dde-r80000000200000-00006a93",
                    "bd83380ba9891e4f-5b9a49b1c3bb99b8-r20000000800000-00006a93", "cbd2cdcb1c3552cd-28eaf47b584037e9-r40000000800000-00006a94",
                    "cf1ee2bbae53abdf-81c6fc93a2c509b4-r40000000200000-00006a93", "",
                    "", "",
                    "", "",
                    "", "");

            if (VeraSkin)
            {
                try
                {
                    ReplaceTextures(@"\_Vera_Ross_Russian_Suit_Metal_Gear_Solid_2\", "1c41837caac15126-8084a99333069c87-r40000000400000-00006a93", "3e5b0ca356f91c6e-6bdcaf3f048ce0ad-r80000000800000-00006a94",
                        "5c0ad25f95ac3952-4dd3d7c7cfb9267a-r80000000800000-00006a93", "74f7651ac4457ba8-f7faa638c76fd9ed-r80000000800000-00006a94",
                        "32024dd6713dd590-65e2d9143e241866-r80000000800000-00006a93", "718767f4116755c3-1488bf8b0d7cce54-r10000000400000-00006a94",
                        "6095333d706ba3e8-d65bf613388a29c6-r20000000400000-00006a94", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "");
                }
                catch
                {
                    VeraSkin = false;
                    notFound += "VeraRussianSuitMGS2_Txt" + Environment.NewLine + "";
                }
            }
            else if (VeraNinjaTxt)
            {
                try
                {
                    ReplaceTextures(@"\_Vera_Ninja\", "12c03d7679b44980-e1a41ad647eb4ae5-r80000000800000-00006a93", "3e5b0ca356f91c6e-6bdcaf3f048ce0ad-r80000000800000-00006a94",
                        "5c0ad25f95ac3952-4dd3d7c7cfb9267a-r80000000800000-00006a93", "74f7651ac4457ba8-f7faa638c76fd9ed-r80000000800000-00006a94",
                        "", "",
                        "", "83785f128cc3da-31b2df4d77106dde-r80000000200000-00006a93",
                        "9de0ae9238331a69-244ca83b6a2ec8f2-r40000000800000-00006a93", "bd83380ba9891e4f-5b9a49b1c3bb99b8-r20000000800000-00006a93",
                        "cbd2cdcb1c3552cd-28eaf47b584037e9-r40000000800000-00006a94", "cf1ee2bbae53abdf-81c6fc93a2c509b4-r40000000200000-00006a93",
                        "", "",
                        "", "",
                        "", "",
                        "", "");
                }
                catch
                {
                    VeraNinjaTxt = false;
                    notFound += "VeraNinjaTxt" + Environment.NewLine + "";
                }
            }

            #endregion

            #region Paul [3B]

            RemoveTextures("2a17cdb8f59aa3ac-32cba7957753037e-r80000000800000-00006a93", "2beab67ede9d67d4-r128x256-00002a80",
                        "3abac545178e6fd5-c6afac499351150c-r32x32-00002a93", "3eb8271eb8a10e83-r128x128-00002a80",
                        "7c2e7b89f451cea3-3d752d459c8fb644-r20000000200000-00006a93", "7c402a34de41d393-f32222dd0f7a35bb-r64x64-00002a93",
                        "22cf4a380075f202-d50307fdf3756b31-r10000000200000-00006a93", "744b3cabc75f46bb-4c759c442a2bc815-r20000000400000-00006a93",
                        "761b700df8c9be2f-14934919ff330380-r20000000200000-00006a93", "2588ef64efb9d2e7-99dda19ed7d68efb-r20000000200000-00006a93",
                        "17939d706677195d-6da768dd718d66d4-r40000000400000-00006a93", "78999f41c272b81f-r64x64-00002a80",
                        "c99e4fe5d83ba7-cf64423e0ccc8545-r28000000400000-00006a93", "ea9eb3b85d6ef51e-70f45509308d0e93-00005593",
                        "f8d434d8606dfb2a-6333248501d15a92-r10000000800000-00006a93", "ea9eb3b85d6ef51e-70f45509308d0e93-00001593",
                        "f8d434d8606dfb2a-6333248501d15a92-r128x16-00002a93", "",
                        "", "");

            if (PaulSkin)
            {
                try
                {
                    ReplaceTextures(@"\_paul_wrath\", "2a17cdb8f59aa3ac-32cba7957753037e-r80000000800000-00006a93", "2beab67ede9d67d4-r128x256-00002a80",
                        "3abac545178e6fd5-c6afac499351150c-r32x32-00002a93", "3eb8271eb8a10e83-r128x128-00002a80",
                        "7c2e7b89f451cea3-3d752d459c8fb644-r20000000200000-00006a93", "7c402a34de41d393-f32222dd0f7a35bb-r64x64-00002a93",
                        "22cf4a380075f202-d50307fdf3756b31-r10000000200000-00006a93", "744b3cabc75f46bb-4c759c442a2bc815-r20000000400000-00006a93",
                        "761b700df8c9be2f-14934919ff330380-r20000000200000-00006a93", "2588ef64efb9d2e7-99dda19ed7d68efb-r20000000200000-00006a93",
                        "17939d706677195d-6da768dd718d66d4-r40000000400000-00006a93", "78999f41c272b81f-r64x64-00002a80",
                        "c99e4fe5d83ba7-cf64423e0ccc8545-r28000000400000-00006a93", "ea9eb3b85d6ef51e-70f45509308d0e93-00005593",
                        "f8d434d8606dfb2a-6333248501d15a92-r10000000800000-00006a93", "",
                        "", "",
                        "", "");
                }
                catch
                {
                    PaulSkin = false;
                    notFound += "PaulWrathTxt" + Environment.NewLine + "";
                }
            }
            else if (PaulSkin2)
            {
                try
                {
                    ReplaceTextures(@"\_Paul_DR\", "2a17cdb8f59aa3ac-32cba7957753037e-r80000000800000-00006a93", "3eb8271eb8a10e83-r128x128-00002a80",
                        "7c2e7b89f451cea3-3d752d459c8fb644-r20000000200000-00006a93", "744b3cabc75f46bb-4c759c442a2bc815-r20000000400000-00006a93",
                        "c99e4fe5d83ba7-cf64423e0ccc8545-r28000000400000-00006a93", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "");
                }
                catch
                {
                    PaulSkin2 = false;
                    notFound += "Paul_DR" + Environment.NewLine + "";
                }
            }
            else if (Paul2040Txt)
            {
                try
                {
                    ReplaceTextures(@"\_Paul_2040\", "2a17cdb8f59aa3ac-32cba7957753037e-r80000000800000-00006a93", "2beab67ede9d67d4-r128x256-00002a80",
                        "3abac545178e6fd5-c6afac499351150c-r32x32-00002a93", "3eb8271eb8a10e83-r128x128-00002a80",
                        "7c2e7b89f451cea3-3d752d459c8fb644-r20000000200000-00006a93", "7c402a34de41d393-f32222dd0f7a35bb-r64x64-00002a93",
                        "744b3cabc75f46bb-4c759c442a2bc815-r20000000400000-00006a93", "78999f41c272b81f-r64x64-00002a80",
                        "c99e4fe5d83ba7-cf64423e0ccc8545-r28000000400000-00006a93", "ea9eb3b85d6ef51e-70f45509308d0e93-00001593",
                        "f8d434d8606dfb2a-6333248501d15a92-r128x16-00002a93", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "");
                }
                catch
                {
                    Paul2040Txt = false;
                    notFound += "Paul2040Txt" + Environment.NewLine + "";
                }
            }

            #endregion

            #region Law [3C]

            RemoveTextures("7601f53ce0d5d9eb-3bb718f8c2cd2f2-r40000000400000-00006a94", "be490c9f42c255a6-2c340f67916cae5-r80000001000000-00006a93",
                    "d31e1a5d3fddab3c-168b78df6084a6e6-r100000000800000-00006a93", "d1fe406b6f984c89-3012bcd034aa04c6-r40000000400000-00006a93",
                    "5f694376813784c2-a2a72a209d13159d-r40000000800000-00006a93", "9e28c4a1084bebbc-4a574bb6cfca4df9-r20000000400000-00006a93",
                    "f207d18dabcc368f-a9ed9adff9040e4f-r80000000800000-00006a93", "",
                    "", "",
                    "", "",
                    "", "",
                    "", "",
                    "", "",
                    "", "");

            if (LawSkin)
            {
                try
                {
                    ReplaceTextures(@"\_game of death law\", "7601f53ce0d5d9eb-3bb718f8c2cd2f2-r40000000400000-00006a94", "be490c9f42c255a6-2c340f67916cae5-r80000001000000-00006a93",
                        "d31e1a5d3fddab3c-168b78df6084a6e6-r100000000800000-00006a93", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "");
                }
                catch
                {
                    LawSkin = false;
                    notFound += "GameofDeathLawTxt" + Environment.NewLine + "";
                }
            }
            else if (JohnnyCageLawTxt)
            {
                try
                {
                    ReplaceTextures(@"\_Johnny_Cage_Law\", "7601f53ce0d5d9eb-3bb718f8c2cd2f2-r40000000400000-00006a94", "be490c9f42c255a6-2c340f67916cae5-r80000001000000-00006a93",
                        "d31e1a5d3fddab3c-168b78df6084a6e6-r100000000800000-00006a93", "d1fe406b6f984c89-3012bcd034aa04c6-r40000000400000-00006a93",
                        "5f694376813784c2-a2a72a209d13159d-r40000000800000-00006a93", "9e28c4a1084bebbc-4a574bb6cfca4df9-r20000000400000-00006a93",
                        "f207d18dabcc368f-a9ed9adff9040e4f-r80000000800000-00006a93", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "");
                }
                catch
                {
                    JohnnyCageLawTxt = false;
                    notFound += "JohnnyCageLawTxt" + Environment.NewLine + "";
                }
            }

            #endregion

            #region KG [45]

            RemoveTextures("5f7f5857dfc9387c-e363ef0d8db43c14-r40000000400000-00006a93", "8bcd0ca82de3a176-23a42b9296f5c23d-r40000000400000-00006a93",
                    "1854cd09413de8ec-618f52e52c2f504-r100000000800000-00006a93", "b4be044c56b778ff-2c1e317ec46c7da7-r40000000800000-00006a93",
                    "b8e604a81e3554f-23e117a3d810c074-r100000000800000-00006a93", "ba23284eed89ff45-dbc961e65326805e-r100000000800000-00006a93",
                    "13bc0b2810d7c043-40ec79a75de9fc0c-r40000000400000-00006a93", "66d59fdb3e0bb8f5-4f2894c9127998a8-r40000000400000-00006a93",
                    "", "",
                    "", "",
                    "", "",
                    "", "",
                    "", "",
                    "", "");

            if (KGBeat_upTxt)
            {
                try
                {
                    ReplaceTextures(@"\_kg batut\", "5f7f5857dfc9387c-e363ef0d8db43c14-r40000000400000-00006a93", "8bcd0ca82de3a176-23a42b9296f5c23d-r40000000400000-00006a93",
                        "1854cd09413de8ec-618f52e52c2f504-r100000000800000-00006a93", "b4be044c56b778ff-2c1e317ec46c7da7-r40000000800000-00006a93",
                        "b8e604a81e3554f-23e117a3d810c074-r100000000800000-00006a93", "ba23284eed89ff45-dbc961e65326805e-r100000000800000-00006a93",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "");
                }
                catch
                {
                    KGBeat_upTxt = false;
                    notFound += "KGBeat_upTxt" + Environment.NewLine + "";
                }
            }
            if (KG_WhatsAppTxt)
            {
                try
                {
                    ReplaceTextures(@"\_KG_WhatsApp\", "5f7f5857dfc9387c-e363ef0d8db43c14-r40000000400000-00006a93", "8bcd0ca82de3a176-23a42b9296f5c23d-r40000000400000-00006a93",
                        "1854cd09413de8ec-618f52e52c2f504-r100000000800000-00006a93", "b4be044c56b778ff-2c1e317ec46c7da7-r40000000800000-00006a93",
                        "b8e604a81e3554f-23e117a3d810c074-r100000000800000-00006a93", "ba23284eed89ff45-dbc961e65326805e-r100000000800000-00006a93",
                        "13bc0b2810d7c043-40ec79a75de9fc0c-r40000000400000-00006a93", "66d59fdb3e0bb8f5-4f2894c9127998a8-r40000000400000-00006a93",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "");
                }
                catch
                {
                    KG_WhatsAppTxt = false;
                    notFound += "KG_WhatsAppTxt" + Environment.NewLine + "";
                }
            }

            #endregion

            #region Shared Images

            if (!GlenSkin && !TorqueSkin && !RodSkin && !SethSkin && !RodKlugerTxt && !TorqueGalsiaTxt)
            {
                sharedImage = "7afe29b3094e20f8-83271f76dfcefd24-r80000000800000-00006a93";
            }
            else
            {
                sharedImage = "";
            }

            RemoveTextures("8e3e7d8db0a0b992-119e5b4437dd16aa-r1c0000002800000-00006693", "19b6813ddde93b77-cbb39c65bc432525-r2c000000f00000-00005a2c",
                        "d428245b8da8e1ae-82561dc49edb0b6c-r2d000000000000-0000596c", "7f1846a7ebd4b144-506a4f20359fc377-r2c000000f00000-00005a2c",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", sharedImage);

            #endregion

            #region Menus

            RemoveTextures("8e3e7d8db0a0b992-119e5b4437dd16aa-r1c0000002800000-00006693", "19b6813ddde93b77-cbb39c65bc432525-r2c000000f00000-00005a2c",
                        "d428245b8da8e1ae-82561dc49edb0b6c-r2d000000000000-0000596c", "7f1846a7ebd4b144-506a4f20359fc377-r2c000000f00000-00005a2c",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "");

            if (TitleScreenTxt)
            {
                try
                {
                    ReplaceTextures(@"\Menus\", "8e3e7d8db0a0b992-119e5b4437dd16aa-r1c0000002800000-00006693", "19b6813ddde93b77-cbb39c65bc432525-r2c000000f00000-00005a2c",
                        "d428245b8da8e1ae-82561dc49edb0b6c-r2d000000000000-0000596c", "7f1846a7ebd4b144-506a4f20359fc377-r2c000000f00000-00005a2c",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "");
                }
                catch
                {
                    TitleScreenTxt = false;
                    notFound += "TitleScreenTxt" + Environment.NewLine + "";
                }
            }

            #endregion

            #region All Weapons


            RemoveTextures("1ad263794a707c27-r64x64-00002a80", "1c35c92331ec10e0-c39c9dd7d2b9692a-r40000000800000-00006a93",
                        "3a8399857a1709f7-fda522fedab65a04-r10000000200000-00006a94", "3c72a4dd3092c3f7-4a40edeabc358a5f-r10000000100000-00006a94",
                        "5a30d06c4c4a042b-a80f31caff562fcc-r40000000400000-00006a94", "5aad47e0fdaa75e6-20014f05606f9bff-r40000000800000-00006a94",
                        "5be7314604b3be67-a89b3d3e2e62791d-r40000000800000-00006a94", "6cdeb1c6fefd395a-dc861c544216f524-r40000000800000-00006a94",
                        "6ec827615b79dc66-c49c45edd00fb18c-r40000000400000-00006a94", "7c2c47202ef3bcd7-cc56eb052a3b809b-r20000000400000-00006a94",
                        "7ecfc1aa50892595-b31e557e0970a44e-r20000000400000-00006a93", "8de7f93871e6ac4e-fbf11bf521843aa7-r10000000100000-00006a94",
                        "9da539fb6b51c9c1-4c7d6444c5c067fa-r20000000400000-00006a94", "9ff35c4d66378669-dc86ed8c7f893647-r40000000400000-00006a94",
                        "12d41d5d02619451-20e710eacececa73-r40000000400000-00006a94", "15a03b513d938ea9-56a9efd8f86ccbc0-r20000000400000-00006a94",
                        "20ff53ed1fac1188-41516000a7c18be1-r20000000400000-00006a94", "24e8056b7f159ec-3ff1618932a881b8-r20000000400000-00006a94",
                        "35b60dbfa47fbab8-c19e5d9e57ef43c8-r140000000a00000-00006a94", "47fb5d63024eb9f3-5f8917679006a9fb-r20000000200000-00006a94");
            RemoveTextures("48b875f47e81d8da-d9d7853cd1351ad5-r100000001000000-00006a94", "252f16f7df30ad9a-dfc162ee08db312d-r40000000400000-00006a94",
                        "269a711dabbfba2f-e1238cd31d16dab7-r80000000800000-00006a93", "689fd30f3d96cd92-9b5d3111f4f0dd60-r80000000800000-00006a94",
                        "817f308b5d564103-e70216682b3d4ee2-r80000000800000-00006a94", "849de382cb1519dc-248c23144ba71663-r20000000400000-00006a94",
                        "984c9877d0e1a5b2-82d01c518e1b82d7-r40000000800000-00006a93", "3578ec4c941aa670-30afd42bfe5dc6a8-r20000000200000-00006a93",
                        "6319f97e209a5708-2c3abfcbca55c87a-r20000000400000-00006a93", "6686d367e27115f9-c6d2e261bfd13d07-r20000000400000-00006a94",
                        "9937bea3f548b6c1-cec35b6c71f37a3e-r40000000800000-00006a94", "63397d378ae5d36f-b8b22e2928cef83e-r8000000100000-00006a94",
                        "80621fb1524fd5fd-5eaa91ccf8ef2ec6-r10000000200000-00006a93", "526423d958e8ba56-fb14e77c78e58da8-r20000000400000-00006a94",
                        "784154c762ee58fd-3996d1e80d258908-r20000000400000-00006a93", "a6a11f36cfa1cc53-94b9ea5839ca1945-r20000000200000-00006a94",
                        "a6fe864d73e29d43-6d20130c0572471c-r80000000800000-00006a94", "a8e72f0d34b6d6e7-2b1035096c8de480-r80000000800000-00006a93",
                        "a780c1e9e155f4c4-bcd2113f1488001c-r40000000400000-00006a94", "ac6887de5f78d72c-730f2764b4a891db-r40000000200000-00006a94");
            RemoveTextures("ad894b699fa72709-7060b21b4f22d3ba-r40000000800000-00006a94", "afe14dff784e534b-cd9ece94e78d13d1-r20000000400000-00006a94",
                        "b43c45e71f7130fe-ffa018f87679e4d8-r20000000400000-00006a94", "b6777fe3b23e6bbe-8c7c945a9028bc21-r20000000400000-00006a93",
                        "bc8d7d124fb0fbf6-2d373b96b9190ea2-r40000000400000-00006a94", "c3d242c618554254-4e8f29cc2168697f-r40000000800000-00006a94",
                        "c50ae0cd6bd424fe-31d3f8bc8ccc942-r20000000200000-00006a94", "c56efa3b9615163-577ff31b05139868-r40000000800000-00006a94",
                        "c62e1a57ea1b73dc-ac5ccf594aa767d1-r40000000400000-00006a94", "c89b12046cea4dbe-c27f835129c87582-r20000000200000-00006a94",
                        "c92cdd9d6b7c7a95-54fa39fca2265604-r10000000200000-00006a94", "cf3315cda32cab91-bed9cab0fea3fb79-r40000000400000-00006a94",
                        "d167434fd8e121ae-29f773b52e3e9d82-r40000000400000-00006a94", "dfcf68f1af3062d7-aa01fedb6e3385e5-r10000000400000-00006a94",
                        "dfd60bcd98189ae1-68937fc8042656a6-r10000000200000-00006a94", "e85f8d0f822df5cd-f451e733d349ad8a-r40000000400000-00006a94",
                        "ea54d03db5b549dd-e2c464486508f61-r20000000200000-00006a94", "ead273861e4fa7ca-4c501fd92ce99e9-r20000000400000-00006a93",
                        "ec764331d92c1fd-ac4f07c19cd642fe-r80000000800000-00006a93", "f37f431ce83f297a-4a15eca89ead3254-r20000000400000-00006a94");
            RemoveTextures("f63b8b8234805050-1c352931413a64d6-r20000000400000-00006a94", "f482e99c1f50a45f-bacfa9ab5bbadb2c-r20000000200000-00006a94",
                        "f25790e3b735d773-7875e973b576063f-r40000000800000-00006a94", "fd08f98c9668163c-20bf1147d3bbb75-r20000000200000-00006a94",
                        "fd8f2b8663474ae5-8e4ee42475c22685-r80000000c00000-00006a93", "fe3d2b47c1464a8d-e538cb5dbcfd5792-r40000000400000-00006a94",
                        "ff075928bb0ea885-5588ca3106499504-r20000000400000-00006a94", "41d35b26f761ba9c-71238981b5ed53f5-r20000000400000-00006a93",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "");

            if (WeaponsTxt)
            {
                try
                {
                    ReplaceTextures(@"\Weapons\", "1ad263794a707c27-r64x64-00002a80", "1c35c92331ec10e0-c39c9dd7d2b9692a-r40000000800000-00006a93",
                        "3a8399857a1709f7-fda522fedab65a04-r10000000200000-00006a94", "3c72a4dd3092c3f7-4a40edeabc358a5f-r10000000100000-00006a94",
                        "5a30d06c4c4a042b-a80f31caff562fcc-r40000000400000-00006a94", "5aad47e0fdaa75e6-20014f05606f9bff-r40000000800000-00006a94",
                        "5be7314604b3be67-a89b3d3e2e62791d-r40000000800000-00006a94", "6cdeb1c6fefd395a-dc861c544216f524-r40000000800000-00006a94",
                        "6ec827615b79dc66-c49c45edd00fb18c-r40000000400000-00006a94", "7c2c47202ef3bcd7-cc56eb052a3b809b-r20000000400000-00006a94",
                        "7ecfc1aa50892595-b31e557e0970a44e-r20000000400000-00006a93", "8de7f93871e6ac4e-fbf11bf521843aa7-r10000000100000-00006a94",
                        "9da539fb6b51c9c1-4c7d6444c5c067fa-r20000000400000-00006a94", "9ff35c4d66378669-dc86ed8c7f893647-r40000000400000-00006a94",
                        "12d41d5d02619451-20e710eacececa73-r40000000400000-00006a94", "15a03b513d938ea9-56a9efd8f86ccbc0-r20000000400000-00006a94",
                        "20ff53ed1fac1188-41516000a7c18be1-r20000000400000-00006a94", "24e8056b7f159ec-3ff1618932a881b8-r20000000400000-00006a94",
                        "35b60dbfa47fbab8-c19e5d9e57ef43c8-r140000000a00000-00006a94", "47fb5d63024eb9f3-5f8917679006a9fb-r20000000200000-00006a94");
                    ReplaceTextures(@"\Weapons\", "48b875f47e81d8da-d9d7853cd1351ad5-r100000001000000-00006a94", "252f16f7df30ad9a-dfc162ee08db312d-r40000000400000-00006a94",
                        "269a711dabbfba2f-e1238cd31d16dab7-r80000000800000-00006a93", "689fd30f3d96cd92-9b5d3111f4f0dd60-r80000000800000-00006a94",
                        "817f308b5d564103-e70216682b3d4ee2-r80000000800000-00006a94", "849de382cb1519dc-248c23144ba71663-r20000000400000-00006a94",
                        "984c9877d0e1a5b2-82d01c518e1b82d7-r40000000800000-00006a93", "3578ec4c941aa670-30afd42bfe5dc6a8-r20000000200000-00006a93",
                        "6319f97e209a5708-2c3abfcbca55c87a-r20000000400000-00006a93", "6686d367e27115f9-c6d2e261bfd13d07-r20000000400000-00006a94",
                        "9937bea3f548b6c1-cec35b6c71f37a3e-r40000000800000-00006a94", "63397d378ae5d36f-b8b22e2928cef83e-r8000000100000-00006a94",
                        "80621fb1524fd5fd-5eaa91ccf8ef2ec6-r10000000200000-00006a93", "526423d958e8ba56-fb14e77c78e58da8-r20000000400000-00006a94",
                        "784154c762ee58fd-3996d1e80d258908-r20000000400000-00006a93", "a6a11f36cfa1cc53-94b9ea5839ca1945-r20000000200000-00006a94",
                        "a6fe864d73e29d43-6d20130c0572471c-r80000000800000-00006a94", "a8e72f0d34b6d6e7-2b1035096c8de480-r80000000800000-00006a93",
                        "a780c1e9e155f4c4-bcd2113f1488001c-r40000000400000-00006a94", "ac6887de5f78d72c-730f2764b4a891db-r40000000200000-00006a94");
                    ReplaceTextures(@"\Weapons\", "ad894b699fa72709-7060b21b4f22d3ba-r40000000800000-00006a94", "afe14dff784e534b-cd9ece94e78d13d1-r20000000400000-00006a94",
                        "b43c45e71f7130fe-ffa018f87679e4d8-r20000000400000-00006a94", "b6777fe3b23e6bbe-8c7c945a9028bc21-r20000000400000-00006a93",
                        "bc8d7d124fb0fbf6-2d373b96b9190ea2-r40000000400000-00006a94", "c3d242c618554254-4e8f29cc2168697f-r40000000800000-00006a94",
                        "c50ae0cd6bd424fe-31d3f8bc8ccc942-r20000000200000-00006a94", "c56efa3b9615163-577ff31b05139868-r40000000800000-00006a94",
                        "c62e1a57ea1b73dc-ac5ccf594aa767d1-r40000000400000-00006a94", "c89b12046cea4dbe-c27f835129c87582-r20000000200000-00006a94",
                        "c92cdd9d6b7c7a95-54fa39fca2265604-r10000000200000-00006a94", "cf3315cda32cab91-bed9cab0fea3fb79-r40000000400000-00006a94",
                        "d167434fd8e121ae-29f773b52e3e9d82-r40000000400000-00006a94", "dfcf68f1af3062d7-aa01fedb6e3385e5-r10000000400000-00006a94",
                        "dfd60bcd98189ae1-68937fc8042656a6-r10000000200000-00006a94", "e85f8d0f822df5cd-f451e733d349ad8a-r40000000400000-00006a94",
                        "ea54d03db5b549dd-e2c464486508f61-r20000000200000-00006a94", "ead273861e4fa7ca-4c501fd92ce99e9-r20000000400000-00006a93",
                        "ec764331d92c1fd-ac4f07c19cd642fe-r80000000800000-00006a93", "f37f431ce83f297a-4a15eca89ead3254-r20000000400000-00006a94");
                    ReplaceTextures(@"\Weapons\", "f63b8b8234805050-1c352931413a64d6-r20000000400000-00006a94", "f482e99c1f50a45f-bacfa9ab5bbadb2c-r20000000200000-00006a94",
                        "f25790e3b735d773-7875e973b576063f-r40000000800000-00006a94", "fd08f98c9668163c-20bf1147d3bbb75-r20000000200000-00006a94",
                        "fd8f2b8663474ae5-8e4ee42475c22685-r80000000c00000-00006a93", "fe3d2b47c1464a8d-e538cb5dbcfd5792-r40000000400000-00006a94",
                        "ff075928bb0ea885-5588ca3106499504-r20000000400000-00006a94", "41d35b26f761ba9c-71238981b5ed53f5-r20000000400000-00006a93",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "");

                }
                catch
                {
                    WeaponsTxt = false;
                    notFound += "WeaponsTxt" + Environment.NewLine + "";
                }
            }

            #endregion

            #region Warehouse Stage


            RemoveTextures("1b0cadb20f952102-c86dde51196e13a8-r80000000800000-00006a94", "1b3e0747ec9acd24-93bee1374ebdc093-r40000000800000-00006a94",
                        "1f689b7376748a00-97e4e03a1e864927-r80000001000000-00006a94", "2ed6e22274e64ff5-cf580950fc7cb591-r80000000800000-00006a94",
                        "7ef8c9cb9ff20b06-6192b780156c34a9-r40000000400000-00006a94", "7fc34edb01b66e90-3a119946f2c93ad3-r100000001000000-00006a94",
                        "35d4cca81b9eea90-646e264df8cfa7b4-00005994", "43a9d00eac1d81b7-8bc3d1212756b484-r40000000800000-00006a94",
                        "72d20ca5886654d7-7cd949185c415dcd-r80000000800000-00006a94", "76e2dfc8edf2b5ee-332213556f0ee1c8-r20000000200000-00006a94",
                        "79f1cbaf35303000-4406a9899a487ca5-r40000000800000-00006a94", "85b15785fca2591c-97df8e887c887a78-r100000001000000-00006a94",
                        "89f964873750de22-2cdf069ca0a36412-r80000001000000-00006a94", "94aae4a7abda74ba-492a8ee6c668cafa-r20000000200000-00006a94",
                        "96d704238915d5b-8f0096f636ff18a9-r80000001000000-00006a94", "801a77342f055001-20a486b6f5821408-r20000000200000-00006a94",
                        "887fe681c5229da0-ff74bdc8a110058c-r100000001000000-00006a94", "4374e4585c6663cf-af2f747fb70a5faf-r40000000800000-00006a94",
                        "41882fe71feb9365-24bc7e0219238a5b-r40000000400000-00006a94", "56257bd1502aa6ac-b8131c971dc8474f-r100000001000000-00006a94");
            RemoveTextures("61016e2674a27e1f-5cf409b5a658694b-r40000000400000-00006a94", "930326043f86b77c-6341feb4dd2082bb-r40000000800000-00006a94",
                        "41237710901b58b2-f794cb4f03023c28-r40000000400000-00006a94", "31994666797362d3-74f3902cf7420d0b-r40000000800000-00006a94",
                        "a6f1578592d6c6eb-6908ccf08e5c959-r40000000800000-00006a94", "a8d5c47a1ea8461c-ee0bcf66f168a4ae-r80000000800000-00006a94",
                        "aa93438a649fa045-9f0a4f21130cd2da-r100000001000000-00006a94", "ab3175aa9b91339f-2fecd555443472ef-r80000000800000-00006a94",
                        "b3c54cfd6c40138d-78f91032509d3d24-r40000000800000-00006a94", "b6501384cc11f6b3-1e66f400cfb9173a-r80000001000000-00006a94",
                        "beba319c9c4e289e-f00c33e4010628f-r80000000800000-00006a94", "c1e801ed8e76c9be-9ed78e188d3acfdb-r80000000800000-00006a94",
                        "caa4248e96cf3f67-963dfba85a32860-r40000000400000-00006a94", "cada47cceed1ff6-aba0fcffd5456af5-00005dd4",
                        "d8e5503fa9995cda-b624d171bdca63e5-r40000000800000-00006a94", "d1114c0ba050f17-ef0f53e25f16630d-r80000000800000-00006a94",
                        "df112812a8b3b243-b85894bb9a95a35d-r40000000400000-00006a94", "e4babce5b24e86ca-2bd16a0c5fff92ec-r80000001000000-00006a94",
                        "e5116bf356bcdbf8-767665b44d6cb094-r80000000800000-00006a94", "f007cf26e02a39a-38e872d472be5ba-r100000001000000-00006a94");
            RemoveTextures("f8b505b11c4a57d0-99e14fba2eb0ad51-r40000000400000-00006a94", "fd3556fbe86564b6-ff74bdc8a110058c-r40000000400000-00006a94",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "");

            if (WarehouseTxt)
            {
                try
                {
                    ReplaceTextures(@"\Stage_Makita\", "1b0cadb20f952102-c86dde51196e13a8-r80000000800000-00006a94", "1b3e0747ec9acd24-93bee1374ebdc093-r40000000800000-00006a94",
                        "1f689b7376748a00-97e4e03a1e864927-r80000001000000-00006a94", "2ed6e22274e64ff5-cf580950fc7cb591-r80000000800000-00006a94",
                        "7ef8c9cb9ff20b06-6192b780156c34a9-r40000000400000-00006a94", "7fc34edb01b66e90-3a119946f2c93ad3-r100000001000000-00006a94",
                        "35d4cca81b9eea90-646e264df8cfa7b4-00005994", "43a9d00eac1d81b7-8bc3d1212756b484-r40000000800000-00006a94",
                        "72d20ca5886654d7-7cd949185c415dcd-r80000000800000-00006a94", "76e2dfc8edf2b5ee-332213556f0ee1c8-r20000000200000-00006a94",
                        "79f1cbaf35303000-4406a9899a487ca5-r40000000800000-00006a94", "85b15785fca2591c-97df8e887c887a78-r100000001000000-00006a94",
                        "89f964873750de22-2cdf069ca0a36412-r80000001000000-00006a94", "94aae4a7abda74ba-492a8ee6c668cafa-r20000000200000-00006a94",
                        "96d704238915d5b-8f0096f636ff18a9-r80000001000000-00006a94", "801a77342f055001-20a486b6f5821408-r20000000200000-00006a94",
                        "887fe681c5229da0-ff74bdc8a110058c-r100000001000000-00006a94", "4374e4585c6663cf-af2f747fb70a5faf-r40000000800000-00006a94",
                        "41882fe71feb9365-24bc7e0219238a5b-r40000000400000-00006a94", "56257bd1502aa6ac-b8131c971dc8474f-r100000001000000-00006a94");
                    ReplaceTextures(@"\Stage_Makita\", "61016e2674a27e1f-5cf409b5a658694b-r40000000400000-00006a94", "930326043f86b77c-6341feb4dd2082bb-r40000000800000-00006a94",
                        "41237710901b58b2-f794cb4f03023c28-r40000000400000-00006a94", "31994666797362d3-74f3902cf7420d0b-r40000000800000-00006a94",
                        "a6f1578592d6c6eb-6908ccf08e5c959-r40000000800000-00006a94", "a8d5c47a1ea8461c-ee0bcf66f168a4ae-r80000000800000-00006a94",
                        "aa93438a649fa045-9f0a4f21130cd2da-r100000001000000-00006a94", "ab3175aa9b91339f-2fecd555443472ef-r80000000800000-00006a94",
                        "b3c54cfd6c40138d-78f91032509d3d24-r40000000800000-00006a94", "b6501384cc11f6b3-1e66f400cfb9173a-r80000001000000-00006a94",
                        "beba319c9c4e289e-f00c33e4010628f-r80000000800000-00006a94", "c1e801ed8e76c9be-9ed78e188d3acfdb-r80000000800000-00006a94",
                        "caa4248e96cf3f67-963dfba85a32860-r40000000400000-00006a94", "cada47cceed1ff6-aba0fcffd5456af5-00005dd4",
                        "d8e5503fa9995cda-b624d171bdca63e5-r40000000800000-00006a94", "d1114c0ba050f17-ef0f53e25f16630d-r80000000800000-00006a94",
                        "df112812a8b3b243-b85894bb9a95a35d-r40000000400000-00006a94", "e4babce5b24e86ca-2bd16a0c5fff92ec-r80000001000000-00006a94",
                        "e5116bf356bcdbf8-767665b44d6cb094-r80000000800000-00006a94", "f007cf26e02a39a-38e872d472be5ba-r100000001000000-00006a94");
                    ReplaceTextures(@"\Stage_Makita\", "f8b505b11c4a57d0-99e14fba2eb0ad51-r40000000400000-00006a94", "fd3556fbe86564b6-ff74bdc8a110058c-r40000000400000-00006a94",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "");
                }
                catch
                {
                    WarehouseTxt = false;
                    notFound += "WarehouseTxt" + Environment.NewLine + "";
                }
            }

            #endregion

            #region Multyplayer Menu

            RemoveTextures("3c6ae59efb5fdb91-966b320ae0251584-r1c0000002800000-00006693", "8eb8c9c9b89b9d3a-9ad2a93600f22fb3-r118000000d00000-00006613",
                        "84f1579d374264ce-75f85a5b32ae5bcc-r1c0000002800000-00006694", "8465025957e3b334-4628b248da283aee-r27000002800000-00005a94",
                        "caa6409bd77efeaf-6e5ddd6c8cf3aaef-r1c00000-00006253", "f253590f2662c48f-24f4d877bf1d60b6-r2800000-00005a93",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "");

            if (MultyplayerTxt)
            {
                try
                {
                    ReplaceTextures(@"\multiplayer_UI\", "3c6ae59efb5fdb91-966b320ae0251584-r1c0000002800000-00006693", "8eb8c9c9b89b9d3a-9ad2a93600f22fb3-r118000000d00000-00006613",
                        "84f1579d374264ce-75f85a5b32ae5bcc-r1c0000002800000-00006694", "8465025957e3b334-4628b248da283aee-r27000002800000-00005a94",
                        "caa6409bd77efeaf-6e5ddd6c8cf3aaef-r1c00000-00006253", "f253590f2662c48f-24f4d877bf1d60b6-r2800000-00005a93",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "",
                        "", "");
                }
                catch
                {
                    MultyplayerTxt = false;
                    notFound += "MultyplayerTxt" + Environment.NewLine + "";
                }
            }

            #endregion
            

            if (notFound != "")
            {
                MessageBox.Show("Textures were not found for" + Environment.NewLine + notFound);
            }
            SettingsClass.SaveData();
        }

        #endregion

        #region Replace & Remove

        internal void ReplaceTextures(string folderName, string name1, string name2, string name3, string name4, string name5, string name6, string name7, string name8, string name9,
            string name10, string name11, string name12, string name13, string name14, string name15, string name16, string name17, string name18, string name19, string name20)
        {
            
            if (name1 != "")
            {
                //D:\replacements\TEXTURES_BASE\_gd 04
                string file1 = SettingsClass.textureBaseFolderPath + folderName + name1 + ".png";
                string file1Path = SettingsClass.textureDumpFolderPath + @"\" + name1 + ".png";
                File.Delete(file1Path);
                File.Copy(file1, file1Path);
            }
            if (name2 != "")
            {
                string file2 = SettingsClass.textureBaseFolderPath + folderName + name2 + ".png";
                string file2Path = SettingsClass.textureDumpFolderPath + @"\" + name2 + ".png";
                File.Delete(file2Path);
                File.Copy(file2, file2Path);
            }
            if (name3 != "")
            {
                string file3 = SettingsClass.textureBaseFolderPath + folderName + name3 + ".png";
                string file3Path = SettingsClass.textureDumpFolderPath + @"\" + name3 + ".png";
                File.Delete(file3Path);
                File.Copy(file3, file3Path);
            }
            if (name4 != "")
            {
                string file4 = SettingsClass.textureBaseFolderPath + folderName + name4 + ".png";
                string file4Path = SettingsClass.textureDumpFolderPath + @"\" + name4 + ".png";
                File.Delete(file4Path);
                File.Copy(file4, file4Path);
            }
            if (name5 != "")
            {
                string file5 = SettingsClass.textureBaseFolderPath + folderName + name5 + ".png";
                string file5Path = SettingsClass.textureDumpFolderPath + @"\" + name5 + ".png";
                File.Delete(file5Path);
                File.Copy(file5, file5Path);
            }
            if (name6 != "")
            {
                string file6 = SettingsClass.textureBaseFolderPath + folderName + name6 + ".png";
                string file6Path = SettingsClass.textureDumpFolderPath + @"\" + name6 + ".png";
                File.Delete(file6Path);
                File.Copy(file6, file6Path);
            }
            if (name7 != "")
            {
                string file7 = SettingsClass.textureBaseFolderPath + folderName + name7 + ".png";
                string file7Path = SettingsClass.textureDumpFolderPath + @"\" + name7 + ".png";
                File.Delete(file7Path);
                File.Copy(file7, file7Path);
            }
            if (name8 != "")
            {
                string file8 = SettingsClass.textureBaseFolderPath + folderName + name8 + ".png";
                string file8Path = SettingsClass.textureDumpFolderPath + @"\" + name8 + ".png";
                File.Delete(file8Path);
                File.Copy(file8, file8Path);
            }
            if (name9 != "")
            {
                string file9 = SettingsClass.textureBaseFolderPath + folderName + name9 + ".png";
                string file9Path = SettingsClass.textureDumpFolderPath + @"\" + name9 + ".png";
                File.Delete(file9Path);
                File.Copy(file9, file9Path);
            }
            if (name10 != "")
            {
                string file10 = SettingsClass.textureBaseFolderPath + folderName + name10 + ".png";
                string file10Path = SettingsClass.textureDumpFolderPath + @"\" + name10 + ".png";
                File.Delete(file10Path);
                File.Copy(file10, file10Path);
            }
            if (name11 != "")
            {
                string file11 = SettingsClass.textureBaseFolderPath + folderName + name11 + ".png";
                string file11Path = SettingsClass.textureDumpFolderPath + @"\" + name11 + ".png";
                File.Delete(file11Path);
                File.Copy(file11, file11Path);
            }
            if (name12 != "")
            {
                string file12 = SettingsClass.textureBaseFolderPath + folderName + name12 + ".png";
                string file12Path = SettingsClass.textureDumpFolderPath + @"\" + name12 + ".png";
                File.Delete(file12Path);
                File.Copy(file12, file12Path);
            }
            if (name13 != "")
            {
                string file13 = SettingsClass.textureBaseFolderPath + folderName + name13 + ".png";
                string file13Path = SettingsClass.textureDumpFolderPath + @"\" + name13 + ".png";
                File.Delete(file13Path);
                File.Copy(file13, file13Path);
            }
            if (name14 != "")
            {
                string file14 = SettingsClass.textureBaseFolderPath + folderName + name14 + ".png";
                string file14Path = SettingsClass.textureDumpFolderPath + @"\" + name14 + ".png";
                File.Delete(file14Path);
                File.Copy(file14, file14Path);
            }
            if (name15 != "")
            {
                string file15 = SettingsClass.textureBaseFolderPath + folderName + name15 + ".png";
                string file15Path = SettingsClass.textureDumpFolderPath + @"\" + name15 + ".png";
                File.Delete(file15Path);
                File.Copy(file15, file15Path);
            }
            if (name16 != "")
            {
                string file16 = SettingsClass.textureBaseFolderPath + folderName + name16 + ".png";
                string file16Path = SettingsClass.textureDumpFolderPath + @"\" + name16 + ".png";
                File.Delete(file16Path);
                File.Copy(file16, file16Path);
            }
            if (name17 != "")
            {
                string file17 = SettingsClass.textureBaseFolderPath + folderName + name17 + ".png";
                string file17Path = SettingsClass.textureDumpFolderPath + @"\" + name17 + ".png";
                File.Delete(file17Path);
                File.Copy(file17, file17Path);
            }
            if (name18 != "")
            {
                string file18 = SettingsClass.textureBaseFolderPath + folderName + name18 + ".png";
                string file18Path = SettingsClass.textureDumpFolderPath + @"\" + name18 + ".png";
                File.Delete(file18Path);
                File.Copy(file18, file18Path);
            }
            if (name19 != "")
            {
                string file19 = SettingsClass.textureBaseFolderPath + folderName + name19 + ".png";
                string file19Path = SettingsClass.textureDumpFolderPath + @"\" + name19 + ".png";
                File.Delete(file19Path);
                File.Copy(file19, file19Path);
            }
            if (name20 != "")
            {
                string file20 = SettingsClass.textureBaseFolderPath + folderName + name20 + ".png";
                string file20Path = SettingsClass.textureDumpFolderPath + @"\" + name20 + ".png";
                File.Delete(file20Path);
                File.Copy(file20, file20Path);
            }
        }

        internal void RemoveTextures(string name1, string name2, string name3, string name4, string name5, string name6, string name7, string name8, string name9,
            string name10, string name11, string name12, string name13, string name14, string name15, string name16, string name17, string name18, string name19, string name20)
        {

            File.Delete(SettingsClass.textureDumpFolderPath + @"\" + name1 + ".png");
            File.Delete(SettingsClass.textureDumpFolderPath + @"\" + name2 + ".png");
            File.Delete(SettingsClass.textureDumpFolderPath + @"\" + name3 + ".png");
            File.Delete(SettingsClass.textureDumpFolderPath + @"\" + name4 + ".png");
            File.Delete(SettingsClass.textureDumpFolderPath + @"\" + name5 + ".png");
            File.Delete(SettingsClass.textureDumpFolderPath + @"\" + name6 + ".png");
            File.Delete(SettingsClass.textureDumpFolderPath + @"\" + name7 + ".png");
            File.Delete(SettingsClass.textureDumpFolderPath + @"\" + name8 + ".png");
            File.Delete(SettingsClass.textureDumpFolderPath + @"\" + name9 + ".png");
            File.Delete(SettingsClass.textureDumpFolderPath + @"\" + name10 + ".png");
            File.Delete(SettingsClass.textureDumpFolderPath + @"\" + name11 + ".png");
            File.Delete(SettingsClass.textureDumpFolderPath + @"\" + name12 + ".png");
            File.Delete(SettingsClass.textureDumpFolderPath + @"\" + name13 + ".png");
            File.Delete(SettingsClass.textureDumpFolderPath + @"\" + name14 + ".png");
            File.Delete(SettingsClass.textureDumpFolderPath + @"\" + name15 + ".png");
            File.Delete(SettingsClass.textureDumpFolderPath + @"\" + name16 + ".png");
            File.Delete(SettingsClass.textureDumpFolderPath + @"\" + name17 + ".png");
            File.Delete(SettingsClass.textureDumpFolderPath + @"\" + name18 + ".png");
            File.Delete(SettingsClass.textureDumpFolderPath + @"\" + name19 + ".png");
            File.Delete(SettingsClass.textureDumpFolderPath + @"\" + name20 + ".png");
        }
        #endregion

        #region Activate/Deactivate All

        internal void ActivateAll()
        {
            GolemShirtlessTxt = true;
            KGBeat_upTxt = true;
            GD_05Skin = true;
            KadonashiOGTxt = true;
            OfficerNapalm99Txt = true;
            Shinkai007Txt = true;
            YanJunDrunkenFistTxt = true;
            BoomaSurgeonTxt = true;
            FashionShunYingTxt = true;
            CollegeBoyBradTxt = true;
            HellsLegionBordinTxt = true;
            TYCleanClothesTxt = true;
            FlamingMiguelTxt = true;
            KoolRamonTxt = true;
            RejinTxt = true;
            MountainGrimTxt = true;
            BouncerFKTxt = true;
            AristocratChrisTxt = true;
            AlternativeParkTxt = true;
            GeishaLilianTxt = true;
            SpyKellyTxt = true;

            GlenSkin = true;
            TorqueSkin = true;
            RodSkin = true;
            SethSkin = true;
            NasTiiiSkin = true;
            EmCeeSkin = true;
            RealDealSkin = true;
            JoseSkin = true;
            EmilioSkin = true;
            ZackSkin = true;
            ColinSkin = true;
            JakeSkin = true;
            TongYoonSkin = true;
            BKSkin = true;
            GraveDiggaSkin = true;
            BonesSkin = true;
            BustaSkin = true;
            SpiderSkin = true;
            PainKillahSkin = true;
            DwayneSkin = true;
            DR88Skin = true;
            PT22Skin = true;
            BainSkin = true;
            CooperSkin = true;
            AndersonSkin = true;
            TaylorSkin = true;
            AlexSkin = true;
            McKinzieSkin = true;
            RikiSkin = true;
            MasaSkin = true;
            HiroSkin = true;
            RyujiSkin = true;
            YeWeiSkin = true;
            ShaYingSkin = true;
            LinFongLeeSkin = true;
            VeraSkin = true;
            PaulSkin = true;
            LawSkin = true;


            GolemTuxedoTxt = false;
            NightmareTxt = false;
            SuspectTxt = false;
            GrolemTxt = false;
            SH2JamesTxt = false;
            RebeccaChambersTxt = false;
            ParkDanteTxt = false;
            BKCJTxt = false;
            GolemKratosTxt = false;
            SubzeroGolemTxt = false;
            VolcanicNapalmTxt = false;
            CyberDwayneTxt = false;
            HornswoggleTxt = false;
            DemonJinpachiTxt = false;
            RyuTxt = false;
            AyaneShunYingTxt = false;
            MaskedDemonBradTxt = false;
            KOFJakeTxt = false;
            GD_04Txt = false;
            PutaTxt = false;
            ShunYingV2Txt = false;
            SpiderManTxt = false;
            SymbioteSpiderTxt = false;
            HoboBonesTxt = false;
            NegativeToonYoonTxt = false;
            SWAG_TyTxt = false;
            HiroGATTxt = false;
            KG_WhatsAppTxt = false;
            RodKlugerTxt = false;
            TorqueGalsiaTxt = false;
            RealDealKidTxt = false;
            BatmanGlenTxt = false;
            TerminatorMckinzieTxt = false;
            EvilShunYingTxt = false;
            OldMasterShinkaiTxt = false;
            CyberpunkGrimmTxt = false;
            KazumaKiryuBradTxt = false;
            CollinHermitSchoolTxt = false;
            MonsterEnergyGolemTxt = false;
            BradfromGymTxt = false;
            CustomGrimmTxt = false;
            SpecialAgentBradHawkTxt = false;
            MayorJakeHudsonTxt = false;
            GangsterAlexTxt = false;
            GovernmentAgentBradHawkTxt = false;
            SkeletonBoyTxt = false;
            HalloweenFKTxt = false;
            Napumpin99Txt = false;
            VergilAlexTxt = false;
            GolemusTxt = false;
            X2000PopMiguelTxt = false;
            MartialArtistBordinTxt = false;
            McPunisherTxt = false;
            TuxLinTxt = false;
            CEOLinFongTxt = false;
            VeraNinjaTxt = false;
            JohnnyCageLawTxt = false;
            GolemFanboyTxt = false;
            EndangeredMasaTxt = false;
            SantaBonesTxt = false;
            GoldenGipsyTxt = false;
            SethSkin2 = false;
            NasTiiiSkin2 = false;
            EmCeeSkin2 = false;
            RamonSkin2 = false;
            JoseSkin2 = false;
            ZackSkin2 = false;
            GraveDiggaSkin2 = false;
            BoomaSkin2 = false;
            BustaSkin2 = false;
            SpiderSkin2 = false;
            PainKillahSkin2 = false;
            CooperSkin2 = false;
            TaylorSkin2 = false;
            ChrisSkin2 = false;
            RikiSkin2 = false;
            RyujiSkin2 = false;
            YeWeiSkin2 = false;
            ShaYingSkin2 = false;
            YanJunSkin2 = false;
            KellySkin2 = false;
            PaulSkin2 = false;

            PepsimanTxt = false;
            EddyTrainerTxt = false;
            BrademTxt = false;
            Paul2040Txt = false;
            BeachGolemTxt = false;

            TitleScreenTxt = true;
            WarehouseTxt = true;
            WeaponsTxt = true;
            MultyplayerTxt = true;

            SwapTextures();
        }

        internal void ActivateAll2()
        {
            GolemShirtlessTxt = false;
            KGBeat_upTxt = false;
            GD_05Skin = false;
            KadonashiOGTxt = false;
            OfficerNapalm99Txt = false;
            Shinkai007Txt = false;
            YanJunDrunkenFistTxt = false;
            BoomaSurgeonTxt = false;
            FashionShunYingTxt = false;
            CollegeBoyBradTxt = false;
            HellsLegionBordinTxt = false;
            TYCleanClothesTxt = false;
            FlamingMiguelTxt = false;
            KoolRamonTxt = false;
            RejinTxt = false;
            MountainGrimTxt = false;
            BouncerFKTxt = false;
            AristocratChrisTxt = false;
            AlternativeParkTxt = false;
            GeishaLilianTxt = false;
            SpyKellyTxt = false;

            GlenSkin = false;
            TorqueSkin = false;
            RodSkin = false;
            SethSkin = false;
            NasTiiiSkin = false;
            EmCeeSkin = false;
            RealDealSkin = false;
            JoseSkin = false;
            EmilioSkin = false;
            ZackSkin = false;
            ColinSkin = false;
            JakeSkin = false;
            TongYoonSkin = false;
            BKSkin = false;
            GraveDiggaSkin = false;
            BonesSkin = false;
            BustaSkin = false;
            SpiderSkin = false;
            PainKillahSkin = false;
            DwayneSkin = false;
            DR88Skin = false;
            PT22Skin = false;
            BainSkin = false;
            CooperSkin = false;
            AndersonSkin = false;
            TaylorSkin = false;
            AlexSkin = false;
            McKinzieSkin = false;
            RikiSkin = false;
            MasaSkin = false;
            HiroSkin = false;
            RyujiSkin = false;
            YeWeiSkin = false;
            ShaYingSkin = false;
            LinFongLeeSkin = false;
            VeraSkin = false;
            PaulSkin = false;
            LawSkin = false;

            NightmareTxt = false;
            GrolemTxt = false;
            GolemKratosTxt = false;
            SubzeroGolemTxt = false;
            MaskedDemonBradTxt = false;
            ShunYingV2Txt = false;
            SymbioteSpiderTxt = false;
            RealDealKidTxt = false;
            EvilShunYingTxt = false;
            KazumaKiryuBradTxt = false;
            MonsterEnergyGolemTxt = false;
            BradfromGymTxt = false;
            CustomGrimmTxt = false;
            SpecialAgentBradHawkTxt = false;
            MayorJakeHudsonTxt = false;
            GovernmentAgentBradHawkTxt = false;
            HalloweenFKTxt = false;
            Napumpin99Txt = false;
            VergilAlexTxt = false;
            GolemusTxt = false;
            McPunisherTxt = false;
            CEOLinFongTxt = false;
            SantaBonesTxt = false;

            SH2JamesTxt = true;
            BatmanGlenTxt = true;
            TorqueGalsiaTxt = true;
            RodKlugerTxt = true;
            HornswoggleTxt = true;
            SWAG_TyTxt = true;
            X2000PopMiguelTxt = true;
            GoldenGipsyTxt = true;
            RyuTxt = true;
            SpiderManTxt = true;
            CollinHermitSchoolTxt = true;
            KOFJakeTxt = true;
            NegativeToonYoonTxt = true;
            CyberpunkGrimmTxt = true;
            BKCJTxt = true;
            HoboBonesTxt = true;
            CyberDwayneTxt = true;
            AyaneShunYingTxt = true;
            GD_04Txt = true;
            GolemFanboyTxt = true;
            DemonJinpachiTxt = true;
            PutaTxt = true;
            SkeletonBoyTxt = true;
            SuspectTxt = true;
            ParkDanteTxt = true;
            GangsterAlexTxt = true;
            TerminatorMckinzieTxt = true;
            VolcanicNapalmTxt = true;
            GolemTuxedoTxt = true;
            EndangeredMasaTxt = true;
            HiroGATTxt = true;
            OldMasterShinkaiTxt = true;
            TuxLinTxt = true;
            MartialArtistBordinTxt = true;
            RebeccaChambersTxt = true;
            VeraNinjaTxt = true;
            JohnnyCageLawTxt = true;
            KG_WhatsAppTxt = true;
            SethSkin2 = true;
            NasTiiiSkin2 = true;
            EmCeeSkin2 = true;
            RamonSkin2 = true;
            JoseSkin2 = true;
            ZackSkin2 = true;
            GraveDiggaSkin2 = true;
            BoomaSkin2 = true;
            BustaSkin2 = true;
            SpiderSkin2 = true;
            PainKillahSkin2 = true;
            CooperSkin2 = true;
            TaylorSkin2 = true;
            ChrisSkin2 = true;
            RikiSkin2 = true;
            RyujiSkin2 = true;
            YeWeiSkin2 = true;
            ShaYingSkin2 = true;
            YanJunSkin2 = true;
            KellySkin2 = true;
            PaulSkin2 = true;

            PepsimanTxt = false;
            EddyTrainerTxt = false;
            BrademTxt= false;
            Paul2040Txt = false;
            BeachGolemTxt = false;

            TitleScreenTxt = true;
            WarehouseTxt = true;
            WeaponsTxt = true;
            MultyplayerTxt = true;

            SwapTextures();
        }
        internal void RestoreOriginals()
        {
            GolemTuxedoTxt = false;
            GolemShirtlessTxt = false;
            KGBeat_upTxt = false;
            GD_05Skin = false;
            KadonashiOGTxt = false;
            OfficerNapalm99Txt = false;
            NightmareTxt = false;
            SuspectTxt = false;
            Shinkai007Txt = false;
            YanJunDrunkenFistTxt = false;
            BoomaSurgeonTxt = false;
            FashionShunYingTxt = false;
            CollegeBoyBradTxt = false;
            HellsLegionBordinTxt = false;
            TYCleanClothesTxt = false;
            FlamingMiguelTxt = false;
            KoolRamonTxt = false;
            RejinTxt = false;
            MountainGrimTxt = false;
            BouncerFKTxt = false;
            AristocratChrisTxt = false;
            AlternativeParkTxt = false;
            GrolemTxt = false;
            GeishaLilianTxt = false;
            SpyKellyTxt = false;

            GlenSkin = false;
            TorqueSkin = false;
            RodSkin = false;
            SethSkin = false;
            NasTiiiSkin = false;
            EmCeeSkin = false;
            RealDealSkin = false;
            JoseSkin = false;
            EmilioSkin = false;
            ZackSkin = false;
            ColinSkin = false;
            JakeSkin = false;
            TongYoonSkin = false;
            BKSkin = false;
            GraveDiggaSkin = false;
            BonesSkin = false;
            BustaSkin = false;
            SpiderSkin = false;
            PainKillahSkin = false;
            DwayneSkin = false;
            DR88Skin = false;
            PT22Skin = false;
            BainSkin = false;
            CooperSkin = false;
            AndersonSkin = false;
            TaylorSkin = false;
            AlexSkin = false;
            McKinzieSkin = false;
            RikiSkin = false;
            MasaSkin = false;
            HiroSkin = false;
            RyujiSkin = false;
            YeWeiSkin = false;
            ShaYingSkin = false;
            LinFongLeeSkin = false;
            VeraSkin = false;
            PaulSkin = false;
            LawSkin = false;
            VergilAlexTxt = false;
            GolemusTxt = false;
            X2000PopMiguelTxt = false;
            MartialArtistBordinTxt = false;
            McPunisherTxt = false;
            TuxLinTxt = false;
            CEOLinFongTxt = false;
            VeraNinjaTxt = false;
            JohnnyCageLawTxt = false;
            GolemFanboyTxt = false;
            EndangeredMasaTxt = false;
            GoldenGipsyTxt = false;

            SH2JamesTxt = false;
            RebeccaChambersTxt = false;
            ParkDanteTxt = false;
            BKCJTxt = false;
            GolemKratosTxt = false;
            SubzeroGolemTxt = false;
            VolcanicNapalmTxt = false;
            CyberDwayneTxt = false;
            HornswoggleTxt = false;
            DemonJinpachiTxt = false;
            RyuTxt = false;
            AyaneShunYingTxt = false;
            MaskedDemonBradTxt = false;
            KOFJakeTxt = false;
            GD_04Txt = false;
            PutaTxt = false;
            ShunYingV2Txt = false;
            SpiderManTxt = false;
            SymbioteSpiderTxt = false;
            HoboBonesTxt = false;
            NegativeToonYoonTxt = false;
            SWAG_TyTxt = false;
            HiroGATTxt = false;
            KG_WhatsAppTxt = false;
            RodKlugerTxt = false;
            TorqueGalsiaTxt = false;
            RealDealKidTxt = false;
            BatmanGlenTxt = false;
            TerminatorMckinzieTxt = false;
            EvilShunYingTxt = false;
            OldMasterShinkaiTxt = false;
            CyberpunkGrimmTxt = false;
            KazumaKiryuBradTxt = false;
            CollinHermitSchoolTxt = false;
            MonsterEnergyGolemTxt = false;
            BradfromGymTxt = false;
            CustomGrimmTxt = false;
            SpecialAgentBradHawkTxt = false;
            MayorJakeHudsonTxt = false;
            GangsterAlexTxt = false;
            GovernmentAgentBradHawkTxt = false;
            SkeletonBoyTxt = false;
            HalloweenFKTxt = false;
            Napumpin99Txt = false;
            SantaBonesTxt = false;
            SethSkin2 = false;
            NasTiiiSkin2 = false;
            EmCeeSkin2 = false;
            RamonSkin2 = false;
            JoseSkin2 = false;
            ZackSkin2 = false;
            GraveDiggaSkin2 = false;
            BoomaSkin2 = false;
            BustaSkin2 = false;
            SpiderSkin2 = false;
            PainKillahSkin2 = false;
            CooperSkin2 = false;
            TaylorSkin2 = false;
            ChrisSkin2 = false;
            RikiSkin2 = false;
            RyujiSkin2 = false;
            YeWeiSkin2 = false;
            ShaYingSkin2 = false;
            YanJunSkin2 = false;
            KellySkin2 = false;
            PaulSkin2 = false;

            PepsimanTxt = false;
            EddyTrainerTxt = false;
            BrademTxt = false;
            Paul2040Txt = false;
            BeachGolemTxt = false;

            TitleScreenTxt = false;
            WarehouseTxt = false;
            WeaponsTxt = false;
            MultyplayerTxt = false;

            SwapTextures();
        }

        internal void ActivateRandomAll()
        {
            int random = 0;

            random = new Random().Next(1, 7 + 1);//Brad Hawk
            switch (random)
            {
                case 1:
                    CollegeBoyBradTxt = true;
                    break;
                case 2:
                    SH2JamesTxt = true;
                    break;
                case 3:
                    MaskedDemonBradTxt = true;
                    break;
                case 4:
                    KazumaKiryuBradTxt = true;
                    break;
                case 5:
                    BradfromGymTxt = true;
                    break;
                case 6:
                    SpecialAgentBradHawkTxt = true;
                    break;
                case 7:
                    GovernmentAgentBradHawkTxt = true;
                    break;
            }

            random = new Random().Next(1, 2 + 1);//Glen
            switch (random)
            {
                case 1:
                    GlenSkin = true;
                    break;
                case 2:
                    BatmanGlenTxt = true;
                    break;
            }

            random = new Random().Next(1, 2 + 1);//Torque
            switch (random)
            {
                case 1:
                    TorqueSkin = true;
                    break;
                case 2:
                    TorqueGalsiaTxt = true;
                    break;
            }

            random = new Random().Next(1, 2 + 1);//Rod
            switch (random)
            {
                case 1:
                    RodSkin = true;
                    break;
                case 2:
                    RodKlugerTxt = true;
                    break;
            }

            random = new Random().Next(1, 2 + 1);//Seth
            switch (random)
            {
                case 1:
                    SethSkin = true;
                    break;
                case 2:
                    SethSkin2 = true;
                    break;
            }

            random = new Random().Next(1, 2 + 1);//Nas Tiii
            switch (random)
            {
                case 1:
                    NasTiiiSkin = true;
                    break;
                case 2:
                    NasTiiiSkin2 = true;
                    break;
            }

            random = new Random().Next(1, 2 + 1);//EmCee
            switch (random)
            {
                case 1:
                    EmCeeSkin = true;
                    break;
                case 2:
                    EmCeeSkin2 = true;
                    break;
            }

            random = new Random().Next(1, 3 + 1);//Real Deal
            switch (random)
            {
                case 1:
                    RealDealSkin = true;
                    break;
                case 2:
                    HornswoggleTxt = true;
                    break;
                case 3:
                    RealDealKidTxt = true;
                    break;
            }

            random = new Random().Next(1, 2 + 1);//Ty
            switch (random)
            {
                case 1:
                    TYCleanClothesTxt = true;
                    break;
                case 2:
                    SWAG_TyTxt = true;
                    break;
            }

            random = new Random().Next(1, 2 + 1);//Miguel
            switch (random)
            {
                case 1:
                    FlamingMiguelTxt = true;
                    break;
                case 2:
                    X2000PopMiguelTxt = true;
                    break;
            }

            random = new Random().Next(1, 2 + 1);//Ramon
            switch (random)
            {
                case 1:
                    KoolRamonTxt = true;
                    break;
                case 2:
                    RamonSkin2 = true;
                    break;
            }

            random = new Random().Next(1, 2 + 1);//Jose
            switch (random)
            {
                case 1:
                    JoseSkin = true;
                    break;
                case 2:
                    JoseSkin2 = true;
                    break;
            }

            random = new Random().Next(1, 2 + 1);//Emilio
            switch (random)
            {
                case 1:
                    EmilioSkin = true;
                    break;
                case 2:
                    GoldenGipsyTxt = true;
                    break;
            }

            random = new Random().Next(1, 2 + 1);//Kadonashi
            switch (random)
            {
                case 1:
                    KadonashiOGTxt = true;
                    break;
                case 2:
                    RyuTxt = true;
                    break;
            }

            random = new Random().Next(1, 2 + 1);//Regie
            switch (random)
            {
                case 1:
                    RejinTxt = true;
                    break;
                case 2:
                    SpiderManTxt = true;
                    break;
            }

            random = new Random().Next(1, 2 + 1);//Zack
            switch (random)
            {
                case 1:
                    ZackSkin = true;
                    break;
                case 2:
                    ZackSkin2 = true;
                    break;
            }

            random = new Random().Next(1, 2 + 1);//Colin
            switch (random)
            {
                case 1:
                    ColinSkin = true;
                    break;
                case 2:
                    CollinHermitSchoolTxt = true;
                    break;
            }

            random = new Random().Next(1, 3 + 1);//Jake
            switch (random)
            {
                case 1:
                    JakeSkin = true;
                    break;
                case 2:
                    KOFJakeTxt = true;
                    break;
                case 3:
                    MayorJakeHudsonTxt = true;
                    break;
            }

            random = new Random().Next(1, 2 + 1);//Tong Yoon
            switch (random)
            {
                case 1:
                    TongYoonSkin = true;
                    break;
                case 2:
                    NegativeToonYoonTxt = true;
                    break;
            }

            random = new Random().Next(1, 3 + 1);//Grim
            switch (random)
            {
                case 1:
                    MountainGrimTxt = true;
                    break;
                case 2:
                    CyberpunkGrimmTxt = true;
                    break;
                case 3:
                    CustomGrimmTxt = true;
                    break;
            }

            random = new Random().Next(1, 2 + 1);//BK
            switch (random)
            {
                case 1:
                    BKSkin = true;
                    break;
                case 2:
                    BKCJTxt = true;
                    break;
            }

            random = new Random().Next(1, 2 + 1);//Grave Digga'
            switch (random)
            {
                case 1:
                    GraveDiggaSkin = true;
                    break;
                case 2:
                    GraveDiggaSkin2 = true;
                    break;
            }

            random = new Random().Next(1, 3 + 1);//Bones
            switch (random)
            {
                case 1:
                    BonesSkin = true;
                    break;
                case 2:
                    HoboBonesTxt = true;
                    break;
                case 3:
                    SantaBonesTxt = true;
                    break;
            }

            random = new Random().Next(1, 2 + 1);//Booma
            switch (random)
            {
                case 1:
                    BoomaSurgeonTxt = true;
                    break;
                case 2:
                    BoomaSkin2 = true;
                    break;
            }

            random = new Random().Next(1, 2 + 1);//Busta
            switch (random)
            {
                case 1:
                    BustaSkin = true;
                    break;
                case 2:
                    BustaSkin2 = true;
                    break;
            }

            random = new Random().Next(1, 2 + 1);//Spider
            switch (random)
            {
                case 1:
                    SpiderSkin = true;
                    break;
                case 2:
                    SpiderSkin2 = true;
                    break;
            }

            random = new Random().Next(1, 2 + 1);//Pain Killah
            switch (random)
            {
                case 1:
                    PainKillahSkin = true;
                    break;
                case 2:
                    PainKillahSkin2 = true;
                    break;
            }

            random = new Random().Next(1, 2 + 1);//Dwayne
            switch (random)
            {
                case 1:
                    DwayneSkin = true;
                    break;
                case 2:
                    CyberDwayneTxt = true;
                    break;
            }

            random = new Random().Next(1, 4 + 1);//Shun Ying Lee
            switch (random)
            {
                case 1:
                    FashionShunYingTxt = true;
                    break;
                case 2:
                    AyaneShunYingTxt = true;
                    break;
                case 3:
                    ShunYingV2Txt = true;
                    break;
                case 4:
                    EvilShunYingTxt = true;
                    break;
            }

            random = new Random().Next(1, 2 + 1);//GD 05
            switch (random)
            {
                case 1:
                    GD_05Skin = true;
                    break;
                case 2:
                    GD_04Txt = true;
                    break;
            }

            random = new Random().Next(1, 2 + 1);//DR 88
            switch (random)
            {
                case 1:
                    DR88Skin = true;
                    break;
                case 2:
                    GolemFanboyTxt = true;
                    break;
            }

            random = new Random().Next(1, 3 + 1);//FK 71
            switch (random)
            {
                case 1:
                    BouncerFKTxt = true;
                    break;
                case 2:
                    DemonJinpachiTxt = true;
                    break;
                case 3:
                    HalloweenFKTxt = true;
                    break;
            }

            random = new Random().Next(1, 3 + 1);//PT 22
            switch (random)
            {
                case 1:
                    PT22Skin = true;
                    break;
                case 2:
                    PutaTxt = true;
                    break;
                case 3:
                    PepsimanTxt = true;
                    break;
            }

            random = new Random().Next(1, 2 + 1);//Bain
            switch (random)
            {
                case 1:
                    BainSkin = true;
                    break;
                case 2:
                    SkeletonBoyTxt = true;
                    break;
            }

            random = new Random().Next(1, 2 + 1);//Cooper
            switch (random)
            {
                case 1:
                    CooperSkin = true;
                    break;
                case 2:
                    CooperSkin2 = true;
                    break;
            }

            random = new Random().Next(1, 2 + 1);//Anderson
            switch (random)
            {
                case 1:
                    AndersonSkin = true;
                    break;
                case 2:
                    SuspectTxt = true;
                    break;
            }

            random = new Random().Next(1, 2 + 1);//Taylor
            switch (random)
            {
                case 1:
                    TaylorSkin = true;
                    break;
                case 2:
                    TaylorSkin2 = true;
                    break;
            }

            random = new Random().Next(1, 3 + 1);//Chris
            switch (random)
            {
                case 1:
                    AristocratChrisTxt = true;
                    break;
                case 2:
                    ChrisSkin2 = true;
                    break;
                case 3:
                    EddyTrainerTxt = true;
                    break;
            }

            random = new Random().Next(1, 3 + 1);//Park
            switch (random)
            {
                case 1:
                    AlternativeParkTxt = true;
                    break;
                case 2:
                    ParkDanteTxt = true;
                    break;
                case 3:
                    SymbioteSpiderTxt = true;
                    break;
            }

            random = new Random().Next(1, 3 + 1);//Alex
            switch (random)
            {
                case 1:
                    AlexSkin = true;
                    break;
                case 2:
                    GangsterAlexTxt = true;
                    break;
                case 3:
                    VergilAlexTxt = true;
                    break;
            }

            random = new Random().Next(1, 3 + 1);//McKinzie
            switch (random)
            {
                case 1:
                    McKinzieSkin = true;
                    break;
                case 2:
                    TerminatorMckinzieTxt = true;
                    break;
                case 3:
                    McPunisherTxt = true;
                    break;
            }

            random = new Random().Next(1, 3 + 1);//Napalm 99
            switch (random)
            {
                case 1:
                    OfficerNapalm99Txt = true;
                    break;
                case 2:
                    VolcanicNapalmTxt = true;
                    break;
                case 3:
                    Napumpin99Txt = true;
                    break;
            }

            random = new Random().Next(1, 10 + 1);//Golem
            switch (random)
            {
                case 1:
                    GolemShirtlessTxt = true;
                    break;
                case 2:
                    GolemTuxedoTxt = true;
                    break;
                case 3:
                    NightmareTxt = true;
                    break;
                case 4:
                    GrolemTxt = true;
                    break;
                case 5:
                    GolemKratosTxt = true;
                    break;
                case 6:
                    SubzeroGolemTxt = true;
                    break;
                case 7:
                    MonsterEnergyGolemTxt = true;
                    break;
                case 8:
                    GolemusTxt = true;
                    break;
                case 9:
                    BrademTxt = true;
                    break;
                case 10:
                    BeachGolemTxt = true;
                    break;
            }

            random = new Random().Next(1, 2 + 1);//Riki
            switch (random)
            {
                case 1:
                    RikiSkin = true;
                    break;
                case 2:
                    RikiSkin2 = true;
                    break;
            }

            random = new Random().Next(1, 2 + 1);//Masa
            switch (random)
            {
                case 1:
                    MasaSkin = true;
                    break;
                case 2:
                    EndangeredMasaTxt = true;
                    break;
            }

            random = new Random().Next(1, 2 + 1);//Hiro
            switch (random)
            {
                case 1:
                    HiroSkin = true;
                    break;
                case 2:
                    HiroGATTxt = true;
                    break;
            }

            random = new Random().Next(1, 2 + 1);//Ryuji
            switch (random)
            {
                case 1:
                    RyujiSkin = true;
                    break;
                case 2:
                    RyujiSkin2 = true;
                    break;
            }

            random = new Random().Next(1, 2 + 1);//Ye Wei
            switch (random)
            {
                case 1:
                    YeWeiSkin = true;
                    break;
                case 2:
                    YeWeiSkin2 = true;
                    break;
            }

            random = new Random().Next(1, 2 + 1);//Sha Ying
            switch (random)
            {
                case 1:
                    ShaYingSkin = true;
                    break;
                case 2:
                    ShaYingSkin2 = true;
                    break;
            }

            random = new Random().Next(1, 2 + 1);//Yan Jun
            switch (random)
            {
                case 1:
                    YanJunDrunkenFistTxt = true;
                    break;
                case 2:
                    YanJunSkin2 = true;
                    break;
            }

            random = new Random().Next(1, 2 + 1);//Shinkai
            switch (random)
            {
                case 1:
                    Shinkai007Txt = true;
                    break;
                case 2:
                    OldMasterShinkaiTxt = true;
                    break;
            }

            random = new Random().Next(1, 3 + 1);//Lin Fong Lee
            switch (random)
            {
                case 1:
                    LinFongLeeSkin = true;
                    break;
                case 2:
                    TuxLinTxt = true;
                    break;
                case 3:
                    CEOLinFongTxt = true;
                    break;
            }

            random = new Random().Next(1, 2 + 1);//Bordin
            switch (random)
            {
                case 1:
                    HellsLegionBordinTxt = true;
                    break;
                case 2:
                    MartialArtistBordinTxt = true;
                    break;
            }

            random = new Random().Next(1, 2 + 1);//Lilian
            switch (random)
            {
                case 1:
                    GeishaLilianTxt = true;
                    break;
                case 2:
                    RebeccaChambersTxt = true;
                    break;
            }

            random = new Random().Next(1, 2 + 1);//Kelly
            switch (random)
            {
                case 1:
                    SpyKellyTxt = true;
                    break;
                case 2:
                    KellySkin2 = true;
                    break;
            }

            random = new Random().Next(1, 2 + 1);//Vera
            switch (random)
            {
                case 1:
                    VeraSkin = true;
                    break;
                case 2:
                    VeraNinjaTxt = true;
                    break;
            }

            random = new Random().Next(1, 3 + 1);//Paul
            switch (random)
            {
                case 1:
                    PaulSkin = true;
                    break;
                case 2:
                    PaulSkin2 = true;
                    break;
                case 3:
                    Paul2040Txt = true;
                    break;
            }

            random = new Random().Next(1, 2 + 1);//Law
            switch (random)
            {
                case 1:
                    LawSkin = true;
                    break;
                case 2:
                    JohnnyCageLawTxt = true;
                    break;
            }

            random = new Random().Next(1, 2 + 1);//KG
            switch (random)
            {
                case 1:
                    KGBeat_upTxt = true;
                    break;
                case 2:
                    KG_WhatsAppTxt = true;
                    break;
            }

            SwapTextures();
        }

        #endregion


    }
}
