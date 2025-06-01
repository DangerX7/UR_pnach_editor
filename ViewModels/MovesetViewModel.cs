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
using UR_pnach_editor.Codes;

namespace UR_pnach_editor.ViewModels
{
    public class MovesetViewModel : BaseViewModel
    {
        public MovesetViewModel()
        {
            MasterBradMoves = SettingsClass.MasterBradMoves;
            BradAndOthersParry = SettingsClass.BradAndOthersParry;
            GolemBrokenShitMoves = SettingsClass.GolemBrokenShitMoves;
            BordinAllAroundMoves = SettingsClass.BordinAllAroundMoves;
            PaulAshesMoves = SettingsClass.PaulAshesMoves;
            SakamotoRyomaMoves = SettingsClass.SakamotoRyomaMoves;
            ShinBordinMoves = SettingsClass.ShinBordinMoves;
            KOGMoves = SettingsClass.KOGMoves;
            KingJakeMoves = SettingsClass.KingJakeMoves;
            MMAGipsiesMoves = SettingsClass.MMAGipsiesMoves;
            RikiDensetsuMoves = SettingsClass.RikiDensetsuMoves;
            PhoenixStanceShunYingMoves = SettingsClass.PhoenixStanceShunYingMoves;
            BrokenDwayneMoves = SettingsClass.BrokenDwayneMoves;
            MonsterVeraMoves = SettingsClass.MonsterVeraMoves;
            ThugKellyMoves = SettingsClass.ThugKellyMoves;
            SwordmasterShunYingAndLilianMoves = SettingsClass.SwordmasterShunYingAndLilianMoves;
            SwordmasterLinFongMoves = SettingsClass.SwordmasterLinFongMoves;


            GameFolderPath = SettingsClass.gameFolderPath;
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


        private bool _masterBradMoves;

        public bool MasterBradMoves
        {
            get { return _masterBradMoves; }
            set
            {
                if (_masterBradMoves != value)
                {
                    _masterBradMoves = value;
                    SettingsClass.MasterBradMoves = _masterBradMoves;
                    RaisePropertyChanged("MasterBradMoves");
                }
            }
        }


        private bool _bradAndOthersParry;

        public bool BradAndOthersParry
        {
            get { return _bradAndOthersParry; }
            set
            {
                if (_bradAndOthersParry != value)
                {
                    _bradAndOthersParry = value;
                    SettingsClass.BradAndOthersParry = _bradAndOthersParry;
                    RaisePropertyChanged("BradAndOthersParry");
                }
            }
        }

        private bool _golemBrokenShitMoves;

        public bool GolemBrokenShitMoves
        {
            get { return _golemBrokenShitMoves; }
            set
            {
                if (_golemBrokenShitMoves != value)
                {
                    _golemBrokenShitMoves = value;
                    SettingsClass.GolemBrokenShitMoves = _golemBrokenShitMoves;
                    RaisePropertyChanged("GolemBrokenShitMoves");
                }
            }
        }

        private bool _bordinAllAroundMoves;

        public bool BordinAllAroundMoves
        {
            get { return _bordinAllAroundMoves; }
            set
            {
                if (_bordinAllAroundMoves != value)
                {
                    _bordinAllAroundMoves = value;
                    SettingsClass.BordinAllAroundMoves = _bordinAllAroundMoves;
                    RaisePropertyChanged("BordinAllAroundMoves");
                    if (_bordinAllAroundMoves)
                    {
                        _shinBordinMoves = false;
                        RaisePropertyChanged("ShinBordinMoves");
                        SettingsClass.ShinBordinMoves = false;
                    }
                }
            }
        }

        private bool _paulAshesMoves;

        public bool PaulAshesMoves
        {
            get { return _paulAshesMoves; }
            set
            {
                if (_paulAshesMoves != value)
                {
                    _paulAshesMoves = value;
                    SettingsClass.PaulAshesMoves = _paulAshesMoves;
                    RaisePropertyChanged("PaulAshesMoves");
                }
            }
        }

        private bool _sakamotoRyomaMoves;

        public bool SakamotoRyomaMoves
        {
            get { return _sakamotoRyomaMoves; }
            set
            {
                if (_sakamotoRyomaMoves != value)
                {
                    _sakamotoRyomaMoves = value;
                    SettingsClass.SakamotoRyomaMoves = _sakamotoRyomaMoves;
                    RaisePropertyChanged("SakamotoRyomaMoves");
                }
            }
        }

        private bool _shinBordinMoves;

        public bool ShinBordinMoves
        {
            get { return _shinBordinMoves; }
            set
            {
                if (_shinBordinMoves != value)
                {
                    _shinBordinMoves = value;
                    SettingsClass.ShinBordinMoves = _shinBordinMoves;
                    RaisePropertyChanged("ShinBordinMoves");
                    if (_shinBordinMoves)
                    {
                        _bordinAllAroundMoves = false;
                        RaisePropertyChanged("BordinAllAroundMoves");
                        SettingsClass.BordinAllAroundMoves = false;
                    }
                }
            }
        }

        private bool _kOGMoves;

        public bool KOGMoves
        {
            get { return _kOGMoves; }
            set
            {
                if (_kOGMoves != value)
                {
                    _kOGMoves = value;
                    SettingsClass.KOGMoves = _kOGMoves;
                    RaisePropertyChanged("KOGMoves");
                }
            }
        }

        private bool _kingJakeMoves;

        public bool KingJakeMoves
        {
            get { return _kingJakeMoves; }
            set
            {
                if (_kingJakeMoves != value)
                {
                    _kingJakeMoves = value;
                    SettingsClass.KingJakeMoves = _kingJakeMoves;
                    RaisePropertyChanged("KingJakeMoves");
                }
            }
        }

        private bool _mMAGipsiesMoves;

        public bool MMAGipsiesMoves
        {
            get { return _mMAGipsiesMoves; }
            set
            {
                if (_mMAGipsiesMoves != value)
                {
                    _mMAGipsiesMoves = value;
                    SettingsClass.MMAGipsiesMoves = _mMAGipsiesMoves;
                    RaisePropertyChanged("MMAGipsiesMoves");
                }
            }
        }

        private bool _rikiDensetsuMoves;

        public bool RikiDensetsuMoves
        {
            get { return _rikiDensetsuMoves; }
            set
            {
                if (_rikiDensetsuMoves != value)
                {
                    _rikiDensetsuMoves = value;
                    SettingsClass.RikiDensetsuMoves = _rikiDensetsuMoves;
                    RaisePropertyChanged("RikiDensetsuMoves");
                }
            }
        }

        private bool _phoenixStanceShunYingMoves;

        public bool PhoenixStanceShunYingMoves
        {
            get { return _phoenixStanceShunYingMoves; }
            set
            {
                if (_phoenixStanceShunYingMoves != value)
                {
                    _phoenixStanceShunYingMoves = value;
                    SettingsClass.PhoenixStanceShunYingMoves = _phoenixStanceShunYingMoves;
                    RaisePropertyChanged("PhoenixStanceShunYingMoves");
                    if (_phoenixStanceShunYingMoves)
                    {
                        _swordmasterShunYingAndLilianMoves = false;
                        RaisePropertyChanged("SwordmasterShunYingAndLilianMoves");
                        SettingsClass.SwordmasterShunYingAndLilianMoves = false;
                    }
                }
            }
        }

        private bool _brokenDwayneMoves;

        public bool BrokenDwayneMoves
        {
            get { return _brokenDwayneMoves; }
            set
            {
                if (_brokenDwayneMoves != value)
                {
                    _brokenDwayneMoves = value;
                    SettingsClass.BrokenDwayneMoves = _brokenDwayneMoves;
                    RaisePropertyChanged("BrokenDwayneMoves");
                }
            }
        }

        private bool _monsterVeraMoves;

        public bool MonsterVeraMoves
        {
            get { return _monsterVeraMoves; }
            set
            {
                if (_monsterVeraMoves != value)
                {
                    _monsterVeraMoves = value;
                    SettingsClass.MonsterVeraMoves = _monsterVeraMoves;
                    RaisePropertyChanged("MonsterVeraMoves");
                }
            }
        }

        private bool _thugKellyMoves;

        public bool ThugKellyMoves
        {
            get { return _thugKellyMoves; }
            set
            {
                if (_thugKellyMoves != value)
                {
                    _thugKellyMoves = value;
                    SettingsClass.ThugKellyMoves = _thugKellyMoves;
                    RaisePropertyChanged("ThugKellyMoves");
                }
            }
        }

        private bool _swordmasterShunYingAndLilianMoves;

        public bool SwordmasterShunYingAndLilianMoves
        {
            get { return _swordmasterShunYingAndLilianMoves; }
            set
            {
                if (_swordmasterShunYingAndLilianMoves != value)
                {
                    _swordmasterShunYingAndLilianMoves = value;
                    SettingsClass.SwordmasterShunYingAndLilianMoves = _swordmasterShunYingAndLilianMoves;
                    RaisePropertyChanged("SwordmasterShunYingAndLilianMoves");
                    if (_swordmasterShunYingAndLilianMoves)
                    {
                        _phoenixStanceShunYingMoves = false;
                        RaisePropertyChanged("PhoenixStanceShunYingMoves");
                        SettingsClass.PhoenixStanceShunYingMoves = false;
                    }
                }
            }
        }

        private bool _swordmasterLinFongMoves;

        public bool SwordmasterLinFongMoves
        {
            get { return _swordmasterLinFongMoves; }
            set
            {
                if (_swordmasterLinFongMoves != value)
                {
                    _swordmasterLinFongMoves = value;
                    SettingsClass.SwordmasterLinFongMoves = _swordmasterLinFongMoves;
                    RaisePropertyChanged("SwordmasterLinFongMoves");
                }
            }
        }


        
    }
}
