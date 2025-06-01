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
using System.Security.Cryptography;
using System.Windows.Documents;
using System.Windows.Shapes;
using System.Windows.Controls;
using UR_pnach_editor.Codes;
using System.DirectoryServices;
using System.Text.RegularExpressions;

namespace UR_pnach_editor.ViewModels
{
    public class CharacterViewModel : BaseViewModel
    {
        public CharacterViewModel()
        {
            //SettingsClass.LoadData();

            MissionFolderPath = SettingsClass.missionFolderPath;

            EnemiesNumber = 6;
            WeaponsOn = true;
            WeaponsEnemyOn = true;
            MultiplayerCamera = false;
            AI = "original";
        }



        public List<string> GameMode = new List<string>
        {
            "Free Mode",
            "Multiplayer",
        };

        private string _missionFolderPath;
        public string MissionFolderPath
        {
            get { return _missionFolderPath; }
            set
            {
                if (_missionFolderPath != value)
                {
                    _missionFolderPath = value;
                    RaisePropertyChanged("MissionFolderPath");
                }
            }
        }

        private int _missionNumber;
        public int MissionNumber
        {
            get { return _missionNumber; }
            set
            {
                if (_missionNumber != value)
                {
                    _missionNumber = value;
                    RaisePropertyChanged("MissionNumber");
                }
            }
        }


        private int _enemiesNumber;
        public int EnemiesNumber
        {
            get { return _enemiesNumber; }
            set
            {
                if (_enemiesNumber != value)
                {
                    _enemiesNumber = value;
                    RaisePropertyChanged("EnemiesNumber");
                }
            }
        }

        private bool _weaponsOn;

        public bool WeaponsOn
        {
            get { return _weaponsOn; }
            set
            {
                if (_weaponsOn != value)
                {
                    _weaponsOn = value;
                    RaisePropertyChanged("WeaponsOn");
                }
            }
        }

        private string _aI;

        public string AI
        {
            get { return _aI; }
            set
            {
                if (_aI != value)
                {
                    _aI = value;
                    RaisePropertyChanged("AI");
                }
            }
        }

        private bool _weaponsEnemyOn;

        public bool WeaponsEnemyOn
        {
            get { return _weaponsEnemyOn; }
            set
            {
                if (_weaponsEnemyOn != value)
                {
                    _weaponsEnemyOn = value;
                    RaisePropertyChanged("WeaponsEnemyOn");
                }
            }
        }

        private bool _selectedMode;

        public bool SelectedMode
        {
            get { return _selectedMode; }
            set
            {
                if (_selectedMode != value)
                {
                    _selectedMode = value;
                    RaisePropertyChanged("SelectedMode");
                }
            }
        }

        public List<string> AIList = new List<string>
        {
            "Original",
            "Trash",
            "Average",
            "Relentless",
        };

        private bool _multiplayerCamera;

        public bool MultiplayerCamera
        {
            get { return _multiplayerCamera; }
            set
            {
                if (_multiplayerCamera != value)
                {
                    _multiplayerCamera = value;
                    RaisePropertyChanged("MultiplayerCamera");
                }
            }
        }

        private int _p1Control;
        public int P1Control
        {
            get { return _p1Control; }
            set
            {
                if (_p1Control != value)
                {
                    _p1Control = value;
                    RaisePropertyChanged("P1Control");
                }
            }
        }
        private int _p2Control;
        public int P2Control
        {
            get { return _p2Control; }
            set
            {
                if (_p2Control != value)
                {
                    _p2Control = value;
                    RaisePropertyChanged("P2Control");
                }
            }
        }
        private int _p3Control;
        public int P3Control
        {
            get { return _p3Control; }
            set
            {
                if (_p3Control != value)
                {
                    _p3Control = value;
                    RaisePropertyChanged("P3Control");
                }
            }
        }
        private int _p4Control;
        public int P4Control
        {
            get { return _p4Control; }
            set
            {
                if (_p4Control != value)
                {
                    _p4Control = value;
                    RaisePropertyChanged("P4Control");
                }
            }
        }
        private int _p5Control;
        public int P5Control
        {
            get { return _p5Control; }
            set
            {
                if (_p5Control != value)
                {
                    _p5Control = value;
                    RaisePropertyChanged("P5Control");
                }
            }
        }
        private int _p6Control;
        public int P6Control
        {
            get { return _p6Control; }
            set
            {
                if (_p6Control != value)
                {
                    _p6Control = value;
                    RaisePropertyChanged("P6Control");
                }
            }
        }
        private int _p7Control;
        public int P7Control
        {
            get { return _p7Control; }
            set
            {
                if (_p7Control != value)
                {
                    _p7Control = value;
                    RaisePropertyChanged("P7Control");
                }
            }
        }
        private int _p8Control;
        public int P8Control
        {
            get { return _p8Control; }
            set
            {
                if (_p8Control != value)
                {
                    _p8Control = value;
                    RaisePropertyChanged("P8Control");
                }
            }
        }

        private int _p1Team;
        public int P1Team
        {
            get { return _p1Team; }
            set
            {
                if (_p1Team != value)
                {
                    _p1Team = value;
                    RaisePropertyChanged("P1Team");
                }
            }
        }
        private int _p2Team;
        public int P2Team
        {
            get { return _p2Team; }
            set
            {
                if (_p2Team != value)
                {
                    _p2Team = value;
                    RaisePropertyChanged("P2Team");
                }
            }
        }
        private int _p3Team;
        public int P3Team
        {
            get { return _p3Team; }
            set
            {
                if (_p3Team != value)
                {
                    _p3Team = value;
                    RaisePropertyChanged("P3Team");
                }
            }
        }
        private int _p4Team;
        public int P4Team
        {
            get { return _p4Team; }
            set
            {
                if (_p4Team != value)
                {
                    _p4Team = value;
                    RaisePropertyChanged("P4Team");
                }
            }
        }
        private int _p5Team;
        public int P5Team
        {
            get { return _p5Team; }
            set
            {
                if (_p5Team != value)
                {
                    _p5Team = value;
                    RaisePropertyChanged("P5Team");
                }
            }
        }
        private int _p6Team;
        public int P6Team
        {
            get { return _p6Team; }
            set
            {
                if (_p6Team != value)
                {
                    _p6Team = value;
                    RaisePropertyChanged("P6Team");
                }
            }
        }
        private int _p7Team;
        public int P7Team
        {
            get { return _p7Team; }
            set
            {
                if (_p7Team != value)
                {
                    _p7Team = value;
                    RaisePropertyChanged("P7Team");
                }
            }
        }
        private int _p8Team;
        public int P8Team
        {
            get { return _p8Team; }
            set
            {
                if (_p8Team != value)
                {
                    _p8Team = value;
                    RaisePropertyChanged("P8Team");
                }
            }
        }

        private bool _player2Camera;

        public bool Player2Camera
        {
            get { return _player2Camera; }
            set
            {
                if (_player2Camera != value)
                {
                    _player2Camera = value;
                    RaisePropertyChanged("Player2Camera");
                }
            }
        }
        

        private string _strikePoints;
        public string StrikePoints
        {
            get { return _strikePoints; }
            set
            {
                if (_strikePoints != value)
                {
                    _strikePoints = value;
                    RaisePropertyChanged("StrikePoints");
                }
            }
        }


        private string _grapplePoints;
        public string GrapplePoints
        {
            get { return _grapplePoints; }
            set
            {
                if (_grapplePoints != value)
                {
                    _grapplePoints = value;
                    RaisePropertyChanged("GrapplePoints");
                }
            }
        }


        private string _regionalPoints;
        public string RegionalPoints
        {
            get { return _regionalPoints; }
            set
            {
                if (_regionalPoints != value)
                {
                    _regionalPoints = value;
                    RaisePropertyChanged("RegionalPoints");
                }
            }
        }


        private string _specialPoints;
        public string SpecialPoints
        {
            get { return _specialPoints; }
            set
            {
                if (_specialPoints != value)
                {
                    _specialPoints = value;
                    RaisePropertyChanged("SpecialPoints");
                }
            }
        }


        private string _weaponPoints;
        public string WeaponPoints
        {
            get { return _weaponPoints; }
            set
            {
                if (_weaponPoints != value)
                {
                    _weaponPoints = value;
                    RaisePropertyChanged("WeaponPoints");
                }
            }
        }


        private string _toughnessPoints;
        public string ToughnessPoints
        {
            get { return _toughnessPoints; }
            set
            {
                if (_toughnessPoints != value)
                {
                    _toughnessPoints = value;
                    RaisePropertyChanged("ToughnessPoints");
                }
            }
        }


        private string _headEndurancePoints;
        public string HeadEndurancePoints
        {
            get { return _headEndurancePoints; }
            set
            {
                if (_headEndurancePoints != value)
                {
                    _headEndurancePoints = value;
                    RaisePropertyChanged("HeadEndurancePoints");
                }
            }
        }


        private string _upperBodyEndurancePoints;
        public string UpperBodyEndurancePoints
        {
            get { return _upperBodyEndurancePoints; }
            set
            {
                if (_upperBodyEndurancePoints != value)
                {
                    _upperBodyEndurancePoints = value;
                    RaisePropertyChanged("UpperBodyEndurancePoints");
                }
            }
        }


        private string _lowerBodyEndurancePoints;
        public string LowerBodyEndurancePoints
        {
            get { return _lowerBodyEndurancePoints; }
            set
            {
                if (_lowerBodyEndurancePoints != value)
                {
                    _lowerBodyEndurancePoints = value;
                    RaisePropertyChanged("LowerBodyEndurancePoints");
                }
            }
        }


        private string _specialArtDownPoints;
        public string SpecialArtDownPoints
        {
            get { return _specialArtDownPoints; }
            set
            {
                if (_specialArtDownPoints != value)
                {
                    _specialArtDownPoints = value;
                    RaisePropertyChanged("SpecialArtDownPoints");
                }
            }
        }


        private string _sPARecoveryPoints;
        public string SPARecoveryPoints
        {
            get { return _sPARecoveryPoints; }
            set
            {
                if (_sPARecoveryPoints != value)
                {
                    _sPARecoveryPoints = value;
                    RaisePropertyChanged("SPARecoveryPoints");
                }
            }
        }


        private string _ultraInstinct;
        public string UltraInstinct
        {
            get { return _ultraInstinct; }
            set
            {
                if (_ultraInstinct != value)
                {
                    _ultraInstinct = value;
                    RaisePropertyChanged("UltraInstinct");
                }
            }
        }


        private string _weaponGrip;
        public string WeaponGrip
        {
            get { return _weaponGrip; }
            set
            {
                if (_weaponGrip != value)
                {
                    _weaponGrip = value;
                    RaisePropertyChanged("WeaponGrip");
                }
            }
        }


        private bool _multiplayerAI;
        public bool MultiplayerAI
        {
            get { return _multiplayerAI; }
            set
            {
                if (_multiplayerAI != value)
                {
                    _multiplayerAI = value;
                    RaisePropertyChanged("MultiplayerAI");
                }
            }
        }


        internal string StatsChange(int player1, int player2, int player3, int player4, int player5, int player6, int player7, int player8,
            bool freeModeOn)
        {
            string player1Data = "";
            string player2Data = "";
            string player3Data = "";
            string player4Data = "";
            string player5Data = "";
            string player6Data = "";
            string player7Data = "";
            string player8Data = "";

            //9750//25D40
            player1Data = GetStats(player1, "105A6018", "105A601A", "105A601C", "105A601E", "105A6020", "105A6022", "105A5FD2", "105A5FD8", "105A5FD4", "105A5FDA",
                "105A5FD6", "105A5FDC", "205A6010", "205A6002", "205A6006", "205A600A", "205A600E", "205A6014", "105A6070", "105A65EA", "1059C8A6", "105A5FC8",
                "105A5FF2", 1, "105A5FCC", "105A5FCE", "105A5FD0", "205A5A50", "D05A5FC8", "D05A6016", "D05A5FC8", "005A5FC8", "D05A5FF2", "005A5FF2",
                "D05A5A52", "D0359854", "005A5A52", freeModeOn, "105A65C8", "005A6018", "005A601A", "005A601C", "005A601E", "005A6020", "005A6022", "105A5FC6");

            player2Data = GetStats(player2, "105AF768", "105AF76A", "105AF76C", "105AF76E", "105AF770", "105AF772", "105AF722", "105AF728", "105AF724", "105AF72A",
                "105AF726", "105AF72C", "205AF760", "205AF752", "205AF756", "205AF75A", "205AF75E", "205AF764", "105AF7C0", "105AFD3A", "105A5FF6", "105AF718",
                "105AF742", 2, "105AF71C", "105AF71E", "105AF720", "205AF1A0", "D05AF718", "D05AF766", "D05AF718", "005AF718", "D05AF742", "005AF742",
                "D05AF1A2", "D0359924", "005AF1A2", freeModeOn, "105AFD18", "005AF768", "005AF76A", "005AF76C", "005AF76E", "005AF770", "005AF772", "105AF716");

            player3Data = GetStats(player3, "105B8EB8", "105B8EBA", "105B8EBC", "105B8EBE", "105B8EC0", "105B8EC2", "105B8E72", "105B8E78", "105B8E74", "105B8E7A",
                "105B8E76", "105B8E7C", "205B8EB0", "205B8EA2", "205B8EA6", "205B8EAA", "205B8EAE", "205B8EB4", "105B8F10", "105B948A", "105AF746", "105B8E68",
                "105B8E92", 3, "105B8E6C", "105B8E6E", "105B8E70", "205B88F0", "D05B8E68", "D05B8EB6", "D05B8E68", "005B8E68", "D05B8E92", "005B8E92",
                "D05B88F2", "D0359AC4", "005B88F2", freeModeOn, "105B9468", "005B8EB8", "005B8EBA", "005B8EBC", "005B8EBE", "005B8EC0", "005B8EC2", "105B8E66");

            player4Data = GetStats(player4, "105C2608", "105C260A", "105C260C", "105C260E", "105C2610", "105C2612", "105C25C2", "105C25C8", "105C25C4", "105C25CA",
                "105C25C6", "105C25CC", "205C2600", "205C25F2", "205C25F6", "205C25FA", "205C25FE", "205C2604", "105C2660", "105C2BDA", "105B8E96", "105C25B8",
                "105C25E2", 4, "105C25BC", "105C25BE", "105C25C0", "205C2040", "D05C25B8", "D05C2606", "D05C25B8", "005C25B8", "D05C25E2", "005C25E2",
                "D05C2042", "D0359C64", "005C2042", freeModeOn, "105C2BB8", "005C2608", "005C260A", "005C260C", "005C260E", "005C2610", "005C2612", "105C25B6");

            player5Data = GetStats(player5, "105CBD58", "105CBD5A", "105CBD5C", "105CBD5E", "105CBD60", "105CBD62", "105CBD12", "105CBD18", "105CBD14", "105CBD1A",
                "105CBD16", "105CBD1C", "205CBD50", "205CBD42", "205CBD46", "205CBD4A", "205CBD4E", "205CBD54", "105CBD1C", "105CC32A", "105C25E6", "105CBD08",
                "105CBD32", 5, "105CBD0C", "105CBD0E", "105CBD10", "205CB790", "D05CBD08", "D05CBD56", "D05CBD08", "005CBD08", "D05CBD32", "005CBD32",
                "D05CB792", "D0359E04", "005CB792", freeModeOn, "105CC308", "005CBD58", "005CBD5A", "005CBD5C", "005CBD5E", "005CBD60", "005CBD62", "105CBD06");

            player6Data = GetStats(player6, "105D54A8", "105D54AA", "105D54AC", "105D54AE", "105D54B0", "105D54B2", "105D5462", "105D5468", "105D5464", "105D546A",
                "105D5466", "105D546C", "205D54A0", "205D5492", "205D5496", "205D549A", "205D549E", "205D54A4", "105D5500", "105D5A7A", "105CBD36", "105D5458",
                "105D5482", 6, "105D545C", "105D545E", "105D5460", "205D4EE0", "D05D5458", "D05D54A6", "D05D5458", "005D5458", "D05D5482", "005D5482",
                "D05D4EE2", "D0359FA4", "005D4EE2", freeModeOn, "105D5A58", "005D54A8", "005D54AA", "005D54AC", "005D54AE", "005D54B0", "005D54B2", "105D5456");

            player7Data = GetStats(player7, "105DEBF8", "105DEBFA", "105DEBFC", "105DEBFE", "105DEC00", "105DEC02", "105DEBB2", "105DEBB8", "105DEBB4", "105DEBBA",
                "105DEBB6", "105DEBBC", "205DEBF0", "205DEBE2", "205DEBE6", "205DEBEA", "205DEBEE", "205DEBF4", "105DEC50", "105DF1CA", "105D5486", "105DEBA8",
                "105DEBD2", 7, "105DEBAC", "105DEBAE", "105DEBB0", "205DE630", "D05DEBA8", "D05DEBF6", "D05DEBA8", "005DEBA8", "D05DEBD2", "005DEBD2",
                "D05DE632", "D035A144", "005DE632", freeModeOn, "105DF1A8", "005DEBF8", "005DEBFA", "005DEBFC", "005DEBFE", "005DEC00", "005DEC02", "105DEBA6");

            player8Data = GetStats(player8, "105E8348", "105E834A", "105E834C", "105E834E", "105E8350", "105E8352", "105E8302", "105E8308", "105E8304", "105E830A",
                "105E8306", "105E830C", "205E8340", "205E8332", "205E8336", "205E833A", "205E833E", "205E8344", "105E83A0", "105E891A", "105DEBD6", "105E82F8",
                "105E8322", 8, "105E82FC", "105E82FE", "105E8300", "205E7D80", "D05E82F8", "D05E8346", "D05E82F8", "005E82F8", "D05E8322", "005E8322",
                "D05E7D82", "D035A2E4", "005E7D82", freeModeOn, "105E88F8", "005E8348", "005E834A", "005E834C", "005E834E", "005E8350", "005E8352", "105E82F6");

            string controls = "";
            string p1control = GetControlCode(P1Control, 1);
            string p2control = GetControlCode(P2Control, 2);
            string p3control = GetControlCode(P3Control, 3);
            string p4control = GetControlCode(P4Control, 4);
            string p5control = GetControlCode(P5Control, 5);
            string p6control = GetControlCode(P6Control, 6);
            string p7control = GetControlCode(P7Control, 7);
            string p8control = GetControlCode(P8Control, 8);

            controls = "" + Environment.NewLine +
            "//Controls" + Environment.NewLine +
            p1control + "//P1 control" + Environment.NewLine +
            p2control + "//P2 control" + Environment.NewLine +
            p3control + "//P3 control" + Environment.NewLine +
            p4control + "//P4 control" + Environment.NewLine +
            p5control + "//P5 control" + Environment.NewLine +
            p6control + "//P6 control" + Environment.NewLine +
            p7control + "//P7 control" + Environment.NewLine +
            p8control + "//P8 control" + Environment.NewLine +
            "";


            string teams = "";
            string p1team = "";
            string p2team = "";
            string p3team = "";
            string p4team = "";
            string p5team = "";
            string p6team = "";
            string p7team = "";
            string p8team = "";
            if (P1Team != 0)
            {
                p1team = "patch=1,EE,105A5F16,extended,000" + (P1Team - 1);
            }
            if (P2Team != 0)
            {
                p2team = "patch=1,EE,105AF666,extended,000" + (P2Team - 1);
            }
            if (P3Team != 0)
            {
                p3team = "patch=1,EE,105B8DB6,extended,000" + (P3Team - 1);
            }
            if (P4Team != 0)
            {
                p4team = "patch=1,EE,105C2506,extended,000" + (P4Team - 1);
            }
            if (P5Team != 0)
            {
                p5team = "patch=1,EE,105CBC56,extended,000" + (P5Team - 1);
            }
            if (P6Team != 0)
            {
                p6team = "patch=1,EE,105D53A6,extended,000" + (P6Team - 1);
            }
            if (P7Team != 0)
            {
                p7team = "patch=1,EE,105DEAF6,extended,000" + (P7Team - 1);
            }
            if (P8Team != 0)
            {
                p8team = "patch=1,EE,105E8246,extended,000" + (P8Team - 1);
            }

            teams = "" + Environment.NewLine +
            "//Teams" + Environment.NewLine +
            p1team + "//P1 team" + Environment.NewLine +
            p2team + "//P2 team" + Environment.NewLine +
            p3team + "//P3 team" + Environment.NewLine +
            p4team + "//P4 team" + Environment.NewLine +
            p5team + "//P5 team" + Environment.NewLine +
            p6team + "//P6 team" + Environment.NewLine +
            p7team + "//P7 team" + Environment.NewLine +
            p8team + "//P8 team" + Environment.NewLine +
            "";

            string ai = "";
            if (!freeModeOn && MultiplayerAI)
            {
                ai = "patch=1,EE,205A5F94,extended,003A003A //cpu 1 AI" + Environment.NewLine +
                     "patch=1,EE,205AF6E4,extended,003A003A //cpu 2 AI" + Environment.NewLine +
                     "patch=1,EE,205B8E34,extended,003A003A //cpu 3 AI" + Environment.NewLine +
                     "patch=1,EE,205C2584,extended,003A003A //cpu 4 AI";
            }

            string stats = player1Data + player2Data + player3Data + player4Data + player5Data + player6Data + player7Data + player8Data + teams + controls + ai;
            return stats;

        }


        internal string GetStats(int playerChar, string STK, string GRP, string RGA, string SPA, string WPA, string TGH, string HDE, string HDEbAl, string UBE, string UBEbal,
            string LBE, string LBEbal, string SPAdown, string SPAred, string SPAgreen, string SPAblue, string SPAalpha, string infiniteSPAdown, string SPAregained,
            string autoParry, string spaCooldown, string hp, string spaBar, int player, string HDEfix, string UBEfix, string LBEfix, string fly, string hpCondition,
            string spaActivation, string playerHpCondition, string playerHealthValueCondition, string spaCondition, string playerSpaValueCondition,
            string yAxisCondition, string rightStickInput, string yAxisValueCondition, bool freeModeOn, string autaGrab,
            string stkIncrease, string grpIncrease, string rgaIncrease, string spaIncrease, string wpaIncrease, string tghIncrease, string wpnGrip)
        {
            string data = "";

            switch (playerChar)
            {
                case 1://Napalm
                    data = "" + Environment.NewLine +
                           "Player" + player + Environment.NewLine +
                           "patch=1,EE," + STK + ",extended,06A4 //STK" + Environment.NewLine +
                           "patch=1,EE," + GRP + ",extended,0640 //GRP" + Environment.NewLine +
                           "patch=1,EE," + RGA + ",extended,05AA //RGA" + Environment.NewLine +
                           "patch=1,EE," + SPA + ",extended,04B0 //SPA" + Environment.NewLine +
                           "patch=1,EE," + WPA + ",extended,0384 //WPA" + Environment.NewLine +
                           "patch=1,EE," + TGH + ",extended,0708 //TGH" + Environment.NewLine +
                           "patch=1,EE," + HDE + ",extended,0226 //HDE" + Environment.NewLine +
                           "patch=1,EE," + HDEbAl + ",extended,0113 //HDE Balance" + Environment.NewLine +
                           "patch=1,EE," + UBE + ",extended,0226 //UBE" + Environment.NewLine +
                           "patch=1,EE," + UBEbal + ",extended,0113 //UBE Balance" + Environment.NewLine +
                           "patch=1,EE," + LBE + ",extended,0226 //LBE" + Environment.NewLine +
                           "patch=1,EE," + LBEbal + ",extended,0113 //LBE Balance" + Environment.NewLine +
                           "patch=1,EE," + SPAred + ",extended,3F00 //Spa Down Red Bar Color" + Environment.NewLine +
                           "patch=1,EE," + SPAgreen + ",extended,3E20 //Spa Down Green Bar Color" + Environment.NewLine +
                           "patch=1,EE," + SPAblue + ",extended,3F00 //Spa Down Blue Bar Color" + Environment.NewLine +
                           "patch=1,EE," + SPAalpha + ",extended,3E20 //Spa Down Alpha Bar Color" + Environment.NewLine +
                           "patch=1,EE," + SPAdown + ",extended,0005 //Spa Down";
                    break;
                case 2://Shinkai Katana
                    data = "" + Environment.NewLine +
                           "Player" + player + Environment.NewLine +
                           "patch=1,EE," + STK + ",extended,0384 //STK" + Environment.NewLine +
                           "patch=1,EE," + GRP + ",extended,0384 //GRP" + Environment.NewLine +
                           "patch=1,EE," + RGA + ",extended,044C //RGA" + Environment.NewLine +
                           "patch=1,EE," + SPA + ",extended,0578 //SPA" + Environment.NewLine +
                           "patch=1,EE," + WPA + ",extended,0BB8 //WPA" + Environment.NewLine +
                           "patch=1,EE," + TGH + ",extended,04B0 //TGH" + Environment.NewLine +
                           "patch=1,EE," + HDE + ",extended,0190 //HDE" + Environment.NewLine +
                           "patch=1,EE," + HDEbAl + ",extended,00C8 //HDE Balance" + Environment.NewLine +
                           "patch=1,EE," + UBE + ",extended,0190 //UBE" + Environment.NewLine +
                           "patch=1,EE," + UBEbal + ",extended,00C8 //UBE Balance" + Environment.NewLine +
                           "patch=1,EE," + LBE + ",extended,0190 //LBE" + Environment.NewLine +
                           "patch=1,EE," + LBEbal + ",extended,00C8 //LBE Balance" + Environment.NewLine +
                           "patch=1,EE," + SPAred + ",extended,3EF0 //Spa Down Red Bar Color" + Environment.NewLine +
                           "patch=1,EE," + SPAgreen + ",extended,3F20 //Spa Down Green Bar Color" + Environment.NewLine +
                           "patch=1,EE," + SPAblue + ",extended,3E20 //Spa Down Blue Bar Color" + Environment.NewLine +
                           "patch=1,EE," + SPAalpha + ",extended,3E20 //Spa Down Alpha Bar Color" + Environment.NewLine +
                           "patch=1,EE," + SPAdown + ",extended,0006 //Spa Down" + Environment.NewLine +
                           "patch=1,EE," + SPAregained + ",extended,0020 //SPA Regained" + Environment.NewLine +
                           "patch=1,EE," + autaGrab + ",extended,0001 //Auta-Grab" + Environment.NewLine +
                           "patch=1,EE," + autoParry + ",extended,0000 //Auto-Parry" + Environment.NewLine +
                           "patch=1,EE," + wpnGrip + ",extended,0003 //Weapon Grip" + Environment.NewLine +
                           "patch=1,EE," + spaCooldown + ",extended,0000 //SPA Cooldown";
                    break;
                case 3://Suspect
                    data = "" + Environment.NewLine +
                           "Player" + player + Environment.NewLine +
                           "patch=1,EE," + STK + ",extended,03E8 //STK" + Environment.NewLine +
                           "patch=1,EE," + GRP + ",extended,03E8 //GRP" + Environment.NewLine +
                           "patch=1,EE," + RGA + ",extended,03E8 //RGA" + Environment.NewLine +
                           "patch=1,EE," + SPA + ",extended,03E8 //SPA" + Environment.NewLine +
                           "patch=1,EE," + WPA + ",extended,03E8 //WPA" + Environment.NewLine +
                           "patch=1,EE," + TGH + ",extended,03E8 //TGH" + Environment.NewLine +
                           "patch=1,EE," + HDE + ",extended,0190 //HDE" + Environment.NewLine +
                           "patch=1,EE," + HDEbAl + ",extended,00C8 //HDE Balance" + Environment.NewLine +
                           "patch=1,EE," + UBE + ",extended,0190 //UBE" + Environment.NewLine +
                           "patch=1,EE," + UBEbal + ",extended,00C8 //UBE Balance" + Environment.NewLine +
                           "patch=1,EE," + LBE + ",extended,0190 //LBE" + Environment.NewLine +
                           "patch=1,EE," + LBEbal + ",extended,00C8 //LBE Balance" + Environment.NewLine +
                           "patch=1,EE," + wpnGrip + ",extended,0002 //Weapon Grip" + Environment.NewLine +
                           "patch=1,EE," + SPAregained + ",extended,0020 //SPA Regained";
                    break;
                case 4://Kadonashi
                    data = "" + Environment.NewLine +
                           "Player" + player + Environment.NewLine +
                           "patch=1,EE," + STK + ",extended,044C //STK" + Environment.NewLine +
                           "patch=1,EE," + GRP + ",extended,02BC //GRP" + Environment.NewLine +
                           "patch=1,EE," + RGA + ",extended,0320 //RGA" + Environment.NewLine +
                           "patch=1,EE," + SPA + ",extended,0320 //SPA" + Environment.NewLine +
                           "patch=1,EE," + WPA + ",extended,0355 //WPA" + Environment.NewLine +
                           "patch=1,EE," + TGH + ",extended,0320 //TGH" + Environment.NewLine +
                           "patch=1,EE," + HDE + ",extended,015E //HDE" + Environment.NewLine +
                           "patch=1,EE," + HDEbAl + ",extended,00AF //HDE Balance" + Environment.NewLine +
                           "patch=1,EE," + UBE + ",extended,015E //UBE" + Environment.NewLine +
                           "patch=1,EE," + UBEbal + ",extended,00AF //UBE Balance" + Environment.NewLine +
                           "patch=1,EE," + LBE + ",extended,0190 //LBE" + Environment.NewLine +
                           "patch=1,EE," + LBEbal + ",extended,00C8 //LBE Balance" + Environment.NewLine +
                           "patch=1,EE," + SPAred + ",extended,3E20 //Spa Down Red Bar Color" + Environment.NewLine +
                           "patch=1,EE," + SPAgreen + ",extended,3F80 //Spa Down Green Bar Color" + Environment.NewLine +
                           "patch=1,EE," + SPAblue + ",extended,3F80 //Spa Down Blue Bar Color" + Environment.NewLine +
                           "patch=1,EE," + SPAalpha + ",extended,3E20 //Spa Down Alpha Bar Color" + Environment.NewLine +
                           "patch=1,EE," + SPAdown + ",extended,0003 //Spa Down" + Environment.NewLine +
                           "patch=1,EE," + infiniteSPAdown + ",extended,44DF8000 //Infinite Spa Down" + Environment.NewLine +
                           "patch=1,EE," + autaGrab + ",extended,0001 //Auta-Grab" + Environment.NewLine +
                           "patch=1,EE," + spaCooldown + ",extended,0000 //SPA Cooldown";
                    break;
                case 5://Brad Shark
                    data = "" + Environment.NewLine +
                           "Player" + player + Environment.NewLine +
                           "patch=1,EE," + STK + ",extended,07D0 //STK" + Environment.NewLine +
                           "patch=1,EE," + GRP + ",extended,07D0 //GRP" + Environment.NewLine +
                           "patch=1,EE," + RGA + ",extended,07D0 //RGA" + Environment.NewLine +
                           "patch=1,EE," + SPA + ",extended,07D0 //SPA" + Environment.NewLine +
                           "patch=1,EE," + WPA + ",extended,07D0 //WPA" + Environment.NewLine +
                           "patch=1,EE," + TGH + ",extended,07D0 //TGH" + Environment.NewLine +
                           "patch=1,EE," + HDE + ",extended,03E8 //HDE" + Environment.NewLine +
                           "patch=1,EE," + HDEbAl + ",extended,0190 //HDE Balance" + Environment.NewLine +
                           "patch=1,EE," + UBE + ",extended,03E8 //UBE" + Environment.NewLine +
                           "patch=1,EE," + UBEbal + ",extended,0190 //UBE Balance" + Environment.NewLine +
                           "patch=1,EE," + LBE + ",extended,03E8 //LBE" + Environment.NewLine +
                           "patch=1,EE," + LBEbal + ",extended,0190 //LBE Balance" + Environment.NewLine +
                           "patch=1,EE," + SPAred + ",extended,3E20 //Spa Down Red Bar Color" + Environment.NewLine +
                           "patch=1,EE," + SPAgreen + ",extended,3E20 //Spa Down Green Bar Color" + Environment.NewLine +
                           "patch=1,EE," + SPAblue + ",extended,3F80 //Spa Down Blue Bar Color" + Environment.NewLine +
                           "patch=1,EE," + SPAalpha + ",extended,3E20 //Spa Down Alpha Bar Color" + Environment.NewLine +
                           "patch=1,EE," + SPAdown + ",extended,0006 //Spa Down" + Environment.NewLine +
                           "patch=1,EE," + infiniteSPAdown + ",extended,44DF8000 //Infinite Spa Down" + Environment.NewLine +
                           "patch=1,EE," + autaGrab + ",extended,0001 //Auta-Grab" + Environment.NewLine +
                           "patch=1,EE," + autoParry + ",extended,0000 //Auto-Parry" + Environment.NewLine +
                           "patch=1,EE," + spaCooldown + ",extended,0000 //SPA Cooldown";
                    break;
                case 6://El Miguel
                    data = "" + Environment.NewLine +
                           "Player" + player + Environment.NewLine +
                           "patch=1,EE," + STK + ",extended,1388 //STK" + Environment.NewLine +
                           "patch=1,EE," + GRP + ",extended,1388 //GRP" + Environment.NewLine +
                           "patch=1,EE," + RGA + ",extended,1388 //RGA" + Environment.NewLine +
                           "patch=1,EE," + SPA + ",extended,1388 //SPA" + Environment.NewLine +
                           "patch=1,EE," + WPA + ",extended,1388 //WPA" + Environment.NewLine +
                           "patch=1,EE," + TGH + ",extended,00C8 //TGH" + Environment.NewLine +
                           "patch=1,EE," + HDE + ",extended,0064 //HDE" + Environment.NewLine +
                           "patch=1,EE," + HDEbAl + ",extended,0032 //HDE Balance" + Environment.NewLine +
                           "patch=1,EE," + UBE + ",extended,0064 //UBE" + Environment.NewLine +
                           "patch=1,EE," + UBEbal + ",extended,0032 //UBE Balance" + Environment.NewLine +
                           "patch=1,EE," + LBE + ",extended,0064 //LBE" + Environment.NewLine +
                           "patch=1,EE," + LBEbal + ",extended,0032 //LBE Balance";
                    break;
                case 7://Beaten KG
                    data = "" + Environment.NewLine +
                           "Player" + player + Environment.NewLine +
                           "patch=1,EE," + STK + ",extended,01E0 //STK" + Environment.NewLine +
                           "patch=1,EE," + GRP + ",extended,01D6 //GRP" + Environment.NewLine +
                           "patch=1,EE," + RGA + ",extended,01E0 //RGA" + Environment.NewLine +
                           "patch=1,EE," + SPA + ",extended,01D6 //SPA" + Environment.NewLine +
                           "patch=1,EE," + WPA + ",extended,01A4 //WPA" + Environment.NewLine +
                           "patch=1,EE," + TGH + ",extended,012C //TGH" + Environment.NewLine +
                           "patch=1,EE," + HDE + ",extended,0032 //HDE" + Environment.NewLine +
                           "patch=1,EE," + HDEbAl + ",extended,0019 //HDE Balance" + Environment.NewLine +
                           "patch=1,EE," + UBE + ",extended,0064 //UBE" + Environment.NewLine +
                           "patch=1,EE," + UBEbal + ",extended,0032 //UBE Balance" + Environment.NewLine +
                           "patch=1,EE," + LBE + ",extended,0032 //LBE" + Environment.NewLine +
                           "patch=1,EE," + LBEbal + ",extended,0019 //LBE Balance" + Environment.NewLine +
                           "patch=1,EE," + SPAregained + ",extended,0002 //SPA Regained";
                    break;
                case 8://Brad At Story Start
                    data = "" + Environment.NewLine +
                           "Player" + player + Environment.NewLine +
                           "patch=1,EE," + STK + ",extended,0299 //STK" + Environment.NewLine +
                           "patch=1,EE," + GRP + ",extended,0253 //GRP" + Environment.NewLine +
                           "patch=1,EE," + RGA + ",extended,0253 //RGA" + Environment.NewLine +
                           "patch=1,EE," + SPA + ",extended,0276 //SPA" + Environment.NewLine +
                           "patch=1,EE," + WPA + ",extended,0230 //WPA" + Environment.NewLine +
                           "patch=1,EE," + TGH + ",extended,0276 //TGH" + Environment.NewLine +
                           "patch=1,EE," + HDE + ",extended,0118 //HDE" + Environment.NewLine +
                           "patch=1,EE," + HDEbAl + ",extended,008C //HDE Balance" + Environment.NewLine +
                           "patch=1,EE," + UBE + ",extended,013B //UBE" + Environment.NewLine +
                           "patch=1,EE," + UBEbal + ",extended,009E //UBE Balance" + Environment.NewLine +
                           "patch=1,EE," + LBE + ",extended,00F5 //LBE" + Environment.NewLine +
                           "patch=1,EE," + LBEbal + ",extended,007B //LBE Balance" + Environment.NewLine +
                           "patch=1,EE," + wpnGrip + ",extended,0000 //Weapon Grip" + Environment.NewLine +
                           "patch=1,EE," + SPAdown + ",extended,0000 //Spa Down";
                    break;
                case 9://Nightmare
                    data = "" + Environment.NewLine +
                           "Player" + player + Environment.NewLine +
                           "patch=1,EE," + STK + ",extended,0708 //STK" + Environment.NewLine +
                           "patch=1,EE," + GRP + ",extended,076C //GRP" + Environment.NewLine +
                           "patch=1,EE," + RGA + ",extended,0640 //RGA" + Environment.NewLine +
                           "patch=1,EE," + SPA + ",extended,0578 //SPA" + Environment.NewLine +
                           "patch=1,EE," + WPA + ",extended,03E8 //WPA" + Environment.NewLine +
                           "patch=1,EE," + TGH + ",extended,0960 //TGH" + Environment.NewLine +
                           "patch=1,EE," + HDE + ",extended,0258 //HDE" + Environment.NewLine +
                           "patch=1,EE," + HDEbAl + ",extended,012C //HDE Balance" + Environment.NewLine +
                           "patch=1,EE," + UBE + ",extended,01F4 //UBE" + Environment.NewLine +
                           "patch=1,EE," + UBEbal + ",extended,00FA //UBE Balance" + Environment.NewLine +
                           "patch=1,EE," + LBE + ",extended,0190 //LBE" + Environment.NewLine +
                           "patch=1,EE," + LBEbal + ",extended,00C8 //LBE Balance" + Environment.NewLine +
                           "patch=1,EE," + SPAred + ",extended,3FE0 //Spa Down Red Bar Color" + Environment.NewLine +
                           "patch=1,EE," + SPAgreen + ",extended,3E20 //Spa Down Green Bar Color" + Environment.NewLine +
                           "patch=1,EE," + SPAblue + ",extended,3E20 //Spa Down Blue Bar Color" + Environment.NewLine +
                           "patch=1,EE," + SPAalpha + ",extended,3E20 //Spa Down Alpha Bar Color" + Environment.NewLine +
                           "patch=1,EE," + SPAdown + ",extended,0006 //Spa Down" + Environment.NewLine +
                           "patch=1,EE," + infiniteSPAdown + ",extended,44DF8000 //Infinite Spa Down";
                    break;
                case 10://Shun Ying
                    data = "" + Environment.NewLine +
                           "Player" + player + Environment.NewLine +
                           "patch=1,EE," + STK + ",extended,030C //STK" + Environment.NewLine +
                           "patch=1,EE," + GRP + ",extended,02BC //GRP" + Environment.NewLine +
                           "patch=1,EE," + RGA + ",extended,0370 //RGA" + Environment.NewLine +
                           "patch=1,EE," + SPA + ",extended,0384 //SPA" + Environment.NewLine +
                           "patch=1,EE," + WPA + ",extended,044C //WPA" + Environment.NewLine +
                           "patch=1,EE," + TGH + ",extended,0352 //TGH" + Environment.NewLine +
                           "patch=1,EE," + HDE + ",extended,00C8 //HDE" + Environment.NewLine +
                           "patch=1,EE," + HDEbAl + ",extended,0064 //HDE Balance" + Environment.NewLine +
                           "patch=1,EE," + UBE + ",extended,012C //UBE" + Environment.NewLine +
                           "patch=1,EE," + UBEbal + ",extended,0096 //UBE Balance" + Environment.NewLine +
                           "patch=1,EE," + LBE + ",extended,00FA //LBE" + Environment.NewLine +
                           "patch=1,EE," + LBEbal + ",extended,007D //LBE Balance" + Environment.NewLine +
                           "patch=1,EE," + SPAred + ",extended,3FE0 //Spa Down Red Bar Color" + Environment.NewLine +
                           "patch=1,EE," + SPAgreen + ",extended,3E20 //Spa Down Green Bar Color" + Environment.NewLine +
                           "patch=1,EE," + SPAblue + ",extended,3F00 //Spa Down Blue Bar Color" + Environment.NewLine +
                           "patch=1,EE," + SPAalpha + ",extended,3E20 //Spa Down Alpha Bar Color" + Environment.NewLine +
                           "patch=1,EE," + SPAdown + ",extended,0007 //Spa Down" + Environment.NewLine +
                           "patch=1,EE," + SPAregained + ",extended,0040 //SPA Regained" + Environment.NewLine +
                           "patch=1,EE," + autoParry + ",extended,0000 //Auto-Parry" + Environment.NewLine +
                           "patch=1,EE," + spaCooldown + ",extended,0000 //SPA Cooldown";
                    break;
                case 11://Bordin (Story)
                    data = "" + Environment.NewLine +
                           "Player" + player + Environment.NewLine +
                           "patch=1,EE," + STK + ",extended,01F4 //STK" + Environment.NewLine +
                           "patch=1,EE," + GRP + ",extended,01C2 //GRP" + Environment.NewLine +
                           "patch=1,EE," + RGA + ",extended,01F4 //RGA" + Environment.NewLine +
                           "patch=1,EE," + SPA + ",extended,01C2 //SPA" + Environment.NewLine +
                           "patch=1,EE," + WPA + ",extended,01F4 //WPA" + Environment.NewLine +
                           "patch=1,EE," + TGH + ",extended,0028 //TGH" + Environment.NewLine +
                           "patch=1,EE," + HDE + ",extended,0064 //HDE" + Environment.NewLine +
                           "patch=1,EE," + HDEbAl + ",extended,0032 //HDE Balance" + Environment.NewLine +
                           "patch=1,EE," + UBE + ",extended,0096 //UBE" + Environment.NewLine +
                           "patch=1,EE," + UBEbal + ",extended,004B //UBE Balance" + Environment.NewLine +
                           "patch=1,EE," + LBE + ",extended,0064 //LBE" + Environment.NewLine +
                           "patch=1,EE," + LBEbal + ",extended,0032 //LBE Balance" + Environment.NewLine +
                           "patch=1,EE," + SPAred + ",extended,3E80 //Spa Down Red Bar Color" + Environment.NewLine +
                           "patch=1,EE," + SPAgreen + ",extended,3E20 //Spa Down Green Bar Color" + Environment.NewLine +
                           "patch=1,EE," + SPAblue + ",extended,3E80 //Spa Down Blue Bar Color" + Environment.NewLine +
                           "patch=1,EE," + SPAalpha + ",extended,3E80 //Spa Down Alpha Bar Color" + Environment.NewLine +
                           "patch=1,EE," + wpnGrip + ",extended,0003 //Weapon Grip" + Environment.NewLine +
                           "patch=1,EE," + SPAdown + ",extended,0007 //Spa Down";
                    break;
                case 12://Paul
                    data = "" + Environment.NewLine +
                           "Player" + player + Environment.NewLine +
                           "patch=1,EE," + STK + ",extended,09C4 //STK" + Environment.NewLine +
                           "patch=1,EE," + GRP + ",extended,04B0 //GRP" + Environment.NewLine +
                           "patch=1,EE," + RGA + ",extended,03B6 //RGA" + Environment.NewLine +
                           "patch=1,EE," + SPA + ",extended,0384 //SPA" + Environment.NewLine +
                           "patch=1,EE," + WPA + ",extended,028A //WPA" + Environment.NewLine +
                           "patch=1,EE," + TGH + ",extended,03E8 //TGH" + Environment.NewLine +
                           "patch=1,EE," + HDE + ",extended,01C2 //HDE" + Environment.NewLine +
                           "patch=1,EE," + HDEbAl + ",extended,00E1 //HDE Balance" + Environment.NewLine +
                           "patch=1,EE," + UBE + ",extended,01C2 //UBE" + Environment.NewLine +
                           "patch=1,EE," + UBEbal + ",extended,00E1 //UBE Balance" + Environment.NewLine +
                           "patch=1,EE," + LBE + ",extended,0190 //LBE" + Environment.NewLine +
                           "patch=1,EE," + LBEbal + ",extended,00C8 //LBE Balance" + Environment.NewLine +
                           "patch=1,EE," + SPAred + ",extended,3EB0 //Spa Down Red Bar Color" + Environment.NewLine +
                           "patch=1,EE," + SPAgreen + ",extended,3E20 //Spa Down Green Bar Color" + Environment.NewLine +
                           "patch=1,EE," + SPAblue + ",extended,3EB0 //Spa Down Blue Bar Color" + Environment.NewLine +
                           "patch=1,EE," + SPAalpha + ",extended,3EB0 //Spa Down Alpha Bar Color" + Environment.NewLine +
                           "patch=1,EE," + SPAdown + ",extended,0008 //Spa Down";
                    break;
                case 13://Law
                    data = "" + Environment.NewLine +
                           "Player" + player + Environment.NewLine +
                           "patch=1,EE," + STK + ",extended,05DC //STK" + Environment.NewLine +
                           "patch=1,EE," + GRP + ",extended,041A //GRP" + Environment.NewLine +
                           "patch=1,EE," + RGA + ",extended,0352 //RGA" + Environment.NewLine +
                           "patch=1,EE," + SPA + ",extended,0898 //SPA" + Environment.NewLine +
                           "patch=1,EE," + WPA + ",extended,03B6 //WPA" + Environment.NewLine +
                           "patch=1,EE," + TGH + ",extended,03E8 //TGH" + Environment.NewLine +
                           "patch=1,EE," + HDE + ",extended,0190 //HDE" + Environment.NewLine +
                           "patch=1,EE," + HDEbAl + ",extended,00C8 //HDE Balance" + Environment.NewLine +
                           "patch=1,EE," + UBE + ",extended,0190 //UBE" + Environment.NewLine +
                           "patch=1,EE," + UBEbal + ",extended,00C8 //UBE Balance" + Environment.NewLine +
                           "patch=1,EE," + LBE + ",extended,0177 //LBE" + Environment.NewLine +
                           "patch=1,EE," + LBEbal + ",extended,00BC //LBE Balance" + Environment.NewLine +
                           "patch=1,EE," + SPAred + ",extended,3EB0 //Spa Down Red Bar Color" + Environment.NewLine +
                           "patch=1,EE," + SPAgreen + ",extended,3E20 //Spa Down Green Bar Color" + Environment.NewLine +
                           "patch=1,EE," + SPAblue + ",extended,3EB0 //Spa Down Blue Bar Color" + Environment.NewLine +
                           "patch=1,EE," + SPAalpha + ",extended,3EB0 //Spa Down Alpha Bar Color" + Environment.NewLine +
                           "patch=1,EE," + SPAdown + ",extended,0008 //Spa Down";
                    break;
                case 14://Mckinzie
                    data = "" + Environment.NewLine +
                           "Player" + player + Environment.NewLine +
                           "patch=1,EE," + STK + ",extended,04B0 //STK" + Environment.NewLine +
                           "patch=1,EE," + GRP + ",extended,04B0 //GRP" + Environment.NewLine +
                           "patch=1,EE," + RGA + ",extended,0834 //RGA" + Environment.NewLine +
                           "patch=1,EE," + SPA + ",extended,047E //SPA" + Environment.NewLine +
                           "patch=1,EE," + WPA + ",extended,060E //WPA" + Environment.NewLine +
                           "patch=1,EE," + TGH + ",extended,044C //TGH" + Environment.NewLine +
                           "patch=1,EE," + HDE + ",extended,01A9 //HDE" + Environment.NewLine +
                           "patch=1,EE," + HDEbAl + ",extended,00D5 //HDE Balance" + Environment.NewLine +
                           "patch=1,EE," + UBE + ",extended,01A9 //UBE" + Environment.NewLine +
                           "patch=1,EE," + UBEbal + ",extended,00D5 //UBE Balance" + Environment.NewLine +
                           "patch=1,EE," + LBE + ",extended,0190 //LBE" + Environment.NewLine +
                           "patch=1,EE," + LBEbal + ",extended,00C8 //LBE Balance" + Environment.NewLine +
                           "patch=1,EE," + SPAred + ",extended,3FB0 //Spa Down Red Bar Color" + Environment.NewLine +
                           "patch=1,EE," + SPAgreen + ",extended,3FB0 //Spa Down Green Bar Color" + Environment.NewLine +
                           "patch=1,EE," + SPAblue + ",extended,3EB0 //Spa Down Blue Bar Color" + Environment.NewLine +
                           "patch=1,EE," + SPAalpha + ",extended,3EB0 //Spa Down Alpha Bar Color" + Environment.NewLine +
                           "patch=1,EE," + SPAdown + ",extended,0007 //Spa Down";
                    break;
                case 15://Zombie KG
                    data = "" + Environment.NewLine +
                           "Player" + player + Environment.NewLine +
                           "patch=1,EE," + STK + ",extended,01B8 //STK" + Environment.NewLine +
                           "patch=1,EE," + GRP + ",extended,01AE //GRP" + Environment.NewLine +
                           "patch=1,EE," + RGA + ",extended,01A4 //RGA" + Environment.NewLine +
                           "patch=1,EE," + SPA + ",extended,01C2 //SPA" + Environment.NewLine +
                           "patch=1,EE," + WPA + ",extended,0190 //WPA" + Environment.NewLine +
                           "patch=1,EE," + TGH + ",extended,1388 //TGH" + Environment.NewLine +
                           "patch=1,EE," + HDE + ",extended,001A //HDE" + Environment.NewLine +
                           "patch=1,EE," + HDEbAl + ",extended,000D //HDE Balance" + Environment.NewLine +
                           "patch=1,EE," + UBE + ",extended,0032 //UBE" + Environment.NewLine +
                           "patch=1,EE," + UBEbal + ",extended,0019 //UBE Balance" + Environment.NewLine +
                           "patch=1,EE," + LBE + ",extended,0032 //LBE" + Environment.NewLine +
                           "patch=1,EE," + LBEbal + ",extended,0019 //LBE Balance" + Environment.NewLine +
                           "patch=1,EE," + SPAred + ",extended,3F80 //Spa Down Red Bar Color" + Environment.NewLine +
                           "patch=1,EE," + SPAgreen + ",extended,3F80 //Spa Down Green Bar Color" + Environment.NewLine +
                           "patch=1,EE," + SPAblue + ",extended,3F20 //Spa Down Blue Bar Color" + Environment.NewLine +
                           "patch=1,EE," + SPAalpha + ",extended,3F20 //Spa Down Alpha Bar Color" + Environment.NewLine +
                           "patch=1,EE," + SPAdown + ",extended,0001 //Spa Down" + Environment.NewLine +
                           "patch=1,EE," + infiniteSPAdown + ",extended,44DF8000 //Infinite Spa Down";
                    break;
                case 16://Max Power Up
                    data = "" + Environment.NewLine +
                           "Player" + player + Environment.NewLine +
                           "patch=1,EE," + STK + ",extended,05DC //STK" + Environment.NewLine +
                           "patch=1,EE," + GRP + ",extended,05DC //GRP" + Environment.NewLine +
                           "patch=1,EE," + RGA + ",extended,05DC //RGA" + Environment.NewLine +
                           "patch=1,EE," + SPA + ",extended,05DC //SPA" + Environment.NewLine +
                           "patch=1,EE," + WPA + ",extended,05DC //WPA" + Environment.NewLine +
                           "patch=1,EE," + TGH + ",extended,05DC //TGH" + Environment.NewLine +
                           "patch=1,EE," + HDE + ",extended,02EE //HDE" + Environment.NewLine +
                           "patch=1,EE," + HDEbAl + ",extended,0177 //HDE Balance" + Environment.NewLine +
                           "patch=1,EE," + UBE + ",extended,02EE //UBE" + Environment.NewLine +
                           "patch=1,EE," + UBEbal + ",extended,0177 //UBE Balance" + Environment.NewLine +
                           "patch=1,EE," + LBE + ",extended,02EE //LBE" + Environment.NewLine +
                           "patch=1,EE," + LBEbal + ",extended,0177 //LBE Balance";
                    break;
                case 17://Weapon Only
                    data = "" + Environment.NewLine +
                           "Player" + player + Environment.NewLine +
                           "patch=1,EE," + STK + ",extended,000A //STK" + Environment.NewLine +
                           "patch=1,EE," + GRP + ",extended,000A //GRP" + Environment.NewLine +
                           "patch=1,EE," + RGA + ",extended,000A //RGA" + Environment.NewLine +
                           "patch=1,EE," + SPA + ",extended,000A //SPA" + Environment.NewLine +
                           "patch=1,EE," + WPA + ",extended,07D0 //WPA" + Environment.NewLine +
                           "patch=1,EE," + wpnGrip + ",extended,0003 //Weapon Grip";
                    break;
                case 19://Superman Flight (R3 Up or R3 Down)
                    data = "" + Environment.NewLine +
                           "Player" + player + " R3 Up or Down" + Environment.NewLine +
                           "patch=1,EE," + yAxisCondition + ",extended,02204060 //If Y axis is lower than 4060 then read the next line" + Environment.NewLine +
                           "patch=1,EE," + rightStickInput + ",extended,0100007F //If Right Stick Up is pressed then read the next line" + Environment.NewLine +
                           "patch=1,EE,30200005,extended," + yAxisValueCondition + " //Increase Y axis by 5" + Environment.NewLine +
                           "patch=1,EE," + yAxisCondition + ",extended,02303F80 //If Y axis is higher than 3F80 then read the next line" + Environment.NewLine +
                           "patch=1,EE," + rightStickInput + ",extended,0100FF7F //If Right Stick Down is pressed then read the next line" + Environment.NewLine +
                           "patch=1,EE,30300005,extended," + yAxisValueCondition + " //Decrease Y axis by 5";
                    break;
                case 20://Devil Jin Power (Triple Stats on Spa Down)
                    data = "" + Environment.NewLine +
                           "Player" + player + Environment.NewLine +
                           "patch=1,EE," + STK + ",extended,03E8 //STK" + Environment.NewLine +
                           "patch=1,EE," + GRP + ",extended,03E8 //GRP" + Environment.NewLine +
                           "patch=1,EE," + RGA + ",extended,03E8 //RGA" + Environment.NewLine +
                           "patch=1,EE," + SPA + ",extended,03E8 //SPA" + Environment.NewLine +
                           "patch=1,EE," + WPA + ",extended,03E8 //WPA" + Environment.NewLine +
                           "patch=1,EE," + TGH + ",extended,03E8 //TGH" + Environment.NewLine +
                           "patch=1,EE," + HDE + ",extended,0190 //HDE" + Environment.NewLine +
                           "patch=1,EE," + HDEbAl + ",extended,00C8 //HDE Balance" + Environment.NewLine +
                           "patch=1,EE," + UBE + ",extended,0190 //UBE" + Environment.NewLine +
                           "patch=1,EE," + UBEbal + ",extended,00C8 //UBE Balance" + Environment.NewLine +
                           "patch=1,EE," + LBE + ",extended,0190 //LBE" + Environment.NewLine +
                           "patch=1,EE," + LBEbal + ",extended,00C8 //LBE Balance" + Environment.NewLine +

                           "patch=1,EE," + SPAred + ",extended,4000 //Spa Down Red Bar Color" + Environment.NewLine +
                           "patch=1,EE," + SPAgreen + ",extended,4000 //Spa Down Green Bar Color" + Environment.NewLine +
                           "patch=1,EE," + SPAblue + ",extended,4000 //Spa Down Blue Bar Color" + Environment.NewLine +
                           "patch=1,EE," + SPAalpha + ",extended,4000 //Spa Down Alpha Bar Color" + Environment.NewLine +
                           "patch=1,EE," + SPAdown + ",extended,0000 //Spa Down" + Environment.NewLine +

                           "patch=1,EE," + spaActivation + ",extended,01300000 //If SPA is activated" + Environment.NewLine +
                           "patch=1,EE," + STK + ",extended,0BB8 //STK" + Environment.NewLine +
                           "patch=1,EE," + spaActivation + ",extended,01300000 //If SPA is activated" + Environment.NewLine +
                           "patch=1,EE," + GRP + ",extended,0BB8 //GRP" + Environment.NewLine +
                           "patch=1,EE," + spaActivation + ",extended,01300000 //If SPA is activated" + Environment.NewLine +
                           "patch=1,EE," + RGA + ",extended,0BB8 //RGA" + Environment.NewLine +
                           "patch=1,EE," + spaActivation + ",extended,01300000 //If SPA is activated" + Environment.NewLine +
                           "patch=1,EE," + SPA + ",extended,0BB8 //SPA" + Environment.NewLine +
                           "patch=1,EE," + spaActivation + ",extended,01300000 //If SPA is activated" + Environment.NewLine +
                           "patch=1,EE," + WPA + ",extended,0BB8 //WPA" + Environment.NewLine +
                           "patch=1,EE," + spaActivation + ",extended,01300000 //If SPA is activated" + Environment.NewLine +
                           "patch=1,EE," + TGH + ",extended,0BB8 //TGH" + Environment.NewLine +
                           "patch=1,EE," + spaActivation + ",extended,01300000 //If SPA is activated" + Environment.NewLine +
                           "patch=1,EE," + HDE + ",extended,04B0 //HDE" + Environment.NewLine +
                           "patch=1,EE," + spaActivation + ",extended,01300000 //If SPA is activated" + Environment.NewLine +
                           "patch=1,EE," + HDEbAl + ",extended,0258 //HDE Balance" + Environment.NewLine +
                           "patch=1,EE," + spaActivation + ",extended,01300000 //If SPA is activated" + Environment.NewLine +
                           "patch=1,EE," + UBE + ",extended,04B0 //UBE" + Environment.NewLine +
                           "patch=1,EE," + spaActivation + ",extended,01300000 //If SPA is activated" + Environment.NewLine +
                           "patch=1,EE," + UBEbal + ",extended,0258 //UBE Balance" + Environment.NewLine +
                           "patch=1,EE," + spaActivation + ",extended,01300000 //If SPA is activated" + Environment.NewLine +
                           "patch=1,EE," + LBE + ",extended,04B0 //LBE" + Environment.NewLine +
                           "patch=1,EE," + spaActivation + ",extended,01300000 //If SPA is activated" + Environment.NewLine +
                           "patch=1,EE," + LBEbal + ",extended,0258 //LBE Balance";
                    break;
                case 21://Poisoned
                    data = "" + Environment.NewLine +
                           "patch=1,EE," + playerHpCondition + ",extended,01300001 //If HP is higher than 0" + Environment.NewLine +
                           "patch=1,EE,30300001,extended," + playerHealthValueCondition + " //Lose Health by 1";
                    break;
                case 22://Auto Raise Stats
                    data = "" + Environment.NewLine +
                           "patch=1,EE," + spaActivation + ",extended,01300000 //If SPA is activated" + Environment.NewLine +
                           "patch=1,EE,30200001,extended," + stkIncrease + " //Increase STK by 1" + Environment.NewLine +
                           "patch=1,EE,30200001,extended," + grpIncrease + " //Increase GRP by 1" + Environment.NewLine +
                           "patch=1,EE,30200001,extended," + rgaIncrease + " //Increase RGA by 1" + Environment.NewLine +
                           "patch=1,EE,30200001,extended," + spaIncrease + " //Increase SPA by 1" + Environment.NewLine +
                           "patch=1,EE,30200001,extended," + wpaIncrease + " //Increase WPA by 1" + Environment.NewLine +
                           "patch=1,EE,30200001,extended," + tghIncrease + " //Increase TGH by 1";
                    break;

                case 101://Dead
                    data = "" + Environment.NewLine +
                           "Player" + player + Environment.NewLine +
                           "patch=1,EE," + hp + ",extended,0000 //No Hp";
                    break;
                case 102://Weak
                    data = "" + Environment.NewLine +
                           "Player" + player + Environment.NewLine +
                           "patch=1,EE," + TGH + ",extended,00FA //TGH" + Environment.NewLine +
                           "patch=1,EE," + wpnGrip + ",extended,0000 //Weapon Grip";
                    break;
                case 103://Strong
                    data = "" + Environment.NewLine +
                           "Player" + player + Environment.NewLine +
                           "patch=1,EE," + TGH + ",extended,03E8 //TGH" + Environment.NewLine +
                           "patch=1,EE," + wpnGrip + ",extended,0001 //Weapon Grip";
                    break;
                case 104://Tank
                    data = "" + Environment.NewLine +
                           "Player" + player + Environment.NewLine +
                           "patch=1,EE," + TGH + ",extended,0BB8 //TGH" + Environment.NewLine +
                           "patch=1,EE," + HDE + ",extended,2710 //HDE" + Environment.NewLine +
                           "patch=1,EE," + HDEfix + ",extended,1388 //HDE Fix" + Environment.NewLine +
                           "patch=1,EE," + UBE + ",extended,2710 //UBE" + Environment.NewLine +
                           "patch=1,EE," + UBEfix + ",extended,1388 //UBE Fix" + Environment.NewLine +
                           "patch=1,EE," + LBE + ",extended,2710 //LBE" + Environment.NewLine +
                           "patch=1,EE," + LBEfix + ",extended,1388 //LBE Fix" + Environment.NewLine +
                           "patch=1,EE," + wpnGrip + ",extended,0002 //Weapon Grip";
                    break;
                case 105://Beat-Up Player
                    data = "" + Environment.NewLine +
                           "Player" + player + Environment.NewLine +
                           "patch=1,EE," + HDE + ",extended,0000 //HDE" + Environment.NewLine +
                           "patch=1,EE," + HDEfix + ",extended,0000 //HDE Fix" + Environment.NewLine +
                           "patch=1,EE," + UBE + ",extended,0000 //UBE" + Environment.NewLine +
                           "patch=1,EE," + UBEfix + ",extended,0000 //UBE Fix" + Environment.NewLine +
                           "patch=1,EE," + LBE + ",extended,0000 //LBE" + Environment.NewLine +
                           "patch=1,EE," + LBEfix + ",extended,0000 //LBE Fix" + Environment.NewLine +
                           "patch=1,EE," + wpnGrip + ",extended,0000 //Weapon Grip";
                    break;
                case 106://No Spa
                    data = "" + Environment.NewLine +
                           "Player" + player + Environment.NewLine +
                           "patch=1,EE," + spaBar + ",extended,0000 //Spa Bar";
                    break;
                case 107://Infinite Spa
                    data = "" + Environment.NewLine +
                           "Player" + player + Environment.NewLine +
                           "patch=1,EE," + spaBar + ",extended,03E8 //Spa Bar";
                    break;
                case 108://Ultra Instinct
                    data = "" + Environment.NewLine +
                           "Player" + player + Environment.NewLine +
                           "patch=1,EE," + autaGrab + ",extended,0001 //Auta-Grab" + Environment.NewLine +
                           "patch=1,EE," + autoParry + ",extended,0000 //Auto-Parry" + Environment.NewLine +
                           "patch=1,EE," + spaCooldown + ",extended,0000 //SPA Cooldown";
                    break;
                #region Random

                case 109://Random
                    int _strike = new Random().Next(10, 2001);
                    int _grapple = new Random().Next(10, 2001);
                    int _regional = new Random().Next(10, 2001);
                    int _special = new Random().Next(10, 2001);
                    int _weapon = new Random().Next(10, 2001);
                    int _toughness = new Random().Next(10, 2001);
                    string Strike = _strike.ToString("X");
                    if (Strike.Length == 1)
                    {
                        Strike = Strike.PadLeft(2, '0');
                    }
                    if (Strike.Length == 2)
                    {
                        Strike = Strike.PadLeft(3, '0');
                    }
                    if (Strike.Length == 3)
                    {
                        Strike = Strike.PadLeft(4, '0');
                    }
                    if (Strike.Length == 4)
                    {
                        Strike = Strike.PadLeft(5, '0');
                    }
                    if (Strike.Length == 5)
                    {
                        Strike = Strike.PadLeft(6, '0');
                    }
                    if (Strike.Length == 6)
                    {
                        Strike = Strike.PadLeft(7, '0');
                    }
                    if (Strike.Length == 7)
                    {
                        Strike = Strike.PadLeft(8, '0');
                    }
                    string Grapple = _grapple.ToString("X");
                    if (Grapple.Length == 1)
                    {
                        Grapple = Grapple.PadLeft(2, '0');
                    }
                    if (Grapple.Length == 2)
                    {
                        Grapple = Grapple.PadLeft(3, '0');
                    }
                    if (Grapple.Length == 3)
                    {
                        Grapple = Grapple.PadLeft(4, '0');
                    }
                    if (Grapple.Length == 4)
                    {
                        Grapple = Grapple.PadLeft(5, '0');
                    }
                    if (Grapple.Length == 5)
                    {
                        Grapple = Grapple.PadLeft(6, '0');
                    }
                    if (Grapple.Length == 6)
                    {
                        Grapple = Grapple.PadLeft(7, '0');
                    }
                    if (Grapple.Length == 7)
                    {
                        Grapple = Grapple.PadLeft(8, '0');
                    }
                    string Regional = _regional.ToString("X");
                    if (Regional.Length == 1)
                    {
                        Regional = Regional.PadLeft(2, '0');
                    }
                    if (Regional.Length == 2)
                    {
                        Regional = Regional.PadLeft(3, '0');
                    }
                    if (Regional.Length == 3)
                    {
                        Regional = Regional.PadLeft(4, '0');
                    }
                    if (Regional.Length == 4)
                    {
                        Regional = Regional.PadLeft(5, '0');
                    }
                    if (Regional.Length == 5)
                    {
                        Regional = Regional.PadLeft(6, '0');
                    }
                    if (Regional.Length == 6)
                    {
                        Regional = Regional.PadLeft(7, '0');
                    }
                    if (Regional.Length == 7)
                    {
                        Regional = Regional.PadLeft(8, '0');
                    }
                    string Special = _special.ToString("X");
                    if (Special.Length == 1)
                    {
                        Special = Special.PadLeft(2, '0');
                    }
                    if (Special.Length == 2)
                    {
                        Special = Special.PadLeft(3, '0');
                    }
                    if (Special.Length == 3)
                    {
                        Special = Special.PadLeft(4, '0');
                    }
                    if (Special.Length == 4)
                    {
                        Special = Special.PadLeft(5, '0');
                    }
                    if (Special.Length == 5)
                    {
                        Special = Special.PadLeft(6, '0');
                    }
                    if (Special.Length == 6)
                    {
                        Special = Special.PadLeft(7, '0');
                    }
                    if (Special.Length == 7)
                    {
                        Special = Special.PadLeft(8, '0');
                    }
                    string Weapon = _weapon.ToString("X");
                    if (Weapon.Length == 1)
                    {
                        Weapon = Weapon.PadLeft(2, '0');
                    }
                    if (Weapon.Length == 2)
                    {
                        Weapon = Weapon.PadLeft(3, '0');
                    }
                    if (Weapon.Length == 3)
                    {
                        Weapon = Weapon.PadLeft(4, '0');
                    }
                    if (Weapon.Length == 4)
                    {
                        Weapon = Weapon.PadLeft(5, '0');
                    }
                    if (Weapon.Length == 5)
                    {
                        Weapon = Weapon.PadLeft(6, '0');
                    }
                    if (Weapon.Length == 6)
                    {
                        Weapon = Weapon.PadLeft(7, '0');
                    }
                    if (Weapon.Length == 7)
                    {
                        Weapon = Weapon.PadLeft(8, '0');
                    }
                    string Toughness = _toughness.ToString("X");
                    if (Toughness.Length == 1)
                    {
                        Toughness = Toughness.PadLeft(2, '0');
                    }
                    if (Toughness.Length == 2)
                    {
                        Toughness = Toughness.PadLeft(3, '0');
                    }
                    if (Toughness.Length == 3)
                    {
                        Toughness = Toughness.PadLeft(4, '0');
                    }
                    if (Toughness.Length == 4)
                    {
                        Toughness = Toughness.PadLeft(5, '0');
                    }
                    if (Toughness.Length == 5)
                    {
                        Toughness = Toughness.PadLeft(6, '0');
                    }
                    if (Toughness.Length == 6)
                    {
                        Toughness = Toughness.PadLeft(7, '0');
                    }
                    if (Toughness.Length == 7)
                    {
                        Toughness = Toughness.PadLeft(8, '0');
                    }

                    int _headEnd = new Random().Next(10, 1001);
                    int _headEndBal = _headEnd / 2;
                    int _UpBodyEnd = new Random().Next(10, 1001);
                    int _UpBodyEndBal = _UpBodyEnd / 2;
                    int _LowBodyEnd = new Random().Next(10, 1001);
                    int _LowBodyEndBal = _LowBodyEnd / 2;
                    string HeadEnd = _headEnd.ToString("X");
                    if (HeadEnd.Length == 1)
                    {
                        HeadEnd = HeadEnd.PadLeft(2, '0');
                    }
                    if (HeadEnd.Length == 2)
                    {
                        HeadEnd = HeadEnd.PadLeft(3, '0');
                    }
                    if (HeadEnd.Length == 3)
                    {
                        HeadEnd = HeadEnd.PadLeft(4, '0');
                    }
                    if (HeadEnd.Length == 4)
                    {
                        HeadEnd = HeadEnd.PadLeft(5, '0');
                    }
                    if (HeadEnd.Length == 5)
                    {
                        HeadEnd = HeadEnd.PadLeft(6, '0');
                    }
                    if (HeadEnd.Length == 6)
                    {
                        HeadEnd = HeadEnd.PadLeft(7, '0');
                    }
                    if (HeadEnd.Length == 7)
                    {
                        HeadEnd = HeadEnd.PadLeft(8, '0');
                    }
                    string HeadEndBal = _headEndBal.ToString("X");
                    if (HeadEndBal.Length == 1)
                    {
                        HeadEndBal = HeadEndBal.PadLeft(2, '0');
                    }
                    if (HeadEndBal.Length == 2)
                    {
                        HeadEndBal = HeadEndBal.PadLeft(3, '0');
                    }
                    if (HeadEndBal.Length == 3)
                    {
                        HeadEndBal = HeadEndBal.PadLeft(4, '0');
                    }
                    if (HeadEndBal.Length == 4)
                    {
                        HeadEndBal = HeadEndBal.PadLeft(5, '0');
                    }
                    if (HeadEndBal.Length == 5)
                    {
                        HeadEndBal = HeadEndBal.PadLeft(6, '0');
                    }
                    if (HeadEndBal.Length == 6)
                    {
                        HeadEndBal = HeadEndBal.PadLeft(7, '0');
                    }
                    if (HeadEndBal.Length == 7)
                    {
                        HeadEndBal = HeadEndBal.PadLeft(8, '0');
                    }
                    string UpBodyEnd = _UpBodyEnd.ToString("X");
                    if (UpBodyEnd.Length == 1)
                    {
                        UpBodyEnd = UpBodyEnd.PadLeft(2, '0');
                    }
                    if (UpBodyEnd.Length == 2)
                    {
                        UpBodyEnd = UpBodyEnd.PadLeft(3, '0');
                    }
                    if (UpBodyEnd.Length == 3)
                    {
                        UpBodyEnd = UpBodyEnd.PadLeft(4, '0');
                    }
                    if (UpBodyEnd.Length == 4)
                    {
                        UpBodyEnd = UpBodyEnd.PadLeft(5, '0');
                    }
                    if (UpBodyEnd.Length == 5)
                    {
                        UpBodyEnd = UpBodyEnd.PadLeft(6, '0');
                    }
                    if (UpBodyEnd.Length == 6)
                    {
                        UpBodyEnd = UpBodyEnd.PadLeft(7, '0');
                    }
                    if (UpBodyEnd.Length == 7)
                    {
                        UpBodyEnd = UpBodyEnd.PadLeft(8, '0');
                    }
                    string UpBodyEndBal = _UpBodyEndBal.ToString("X");
                    if (UpBodyEndBal.Length == 1)
                    {
                        UpBodyEndBal = UpBodyEndBal.PadLeft(2, '0');
                    }
                    if (UpBodyEndBal.Length == 2)
                    {
                        UpBodyEndBal = UpBodyEndBal.PadLeft(3, '0');
                    }
                    if (UpBodyEndBal.Length == 3)
                    {
                        UpBodyEndBal = UpBodyEndBal.PadLeft(4, '0');
                    }
                    if (UpBodyEndBal.Length == 4)
                    {
                        UpBodyEndBal = UpBodyEndBal.PadLeft(5, '0');
                    }
                    if (UpBodyEndBal.Length == 5)
                    {
                        UpBodyEndBal = UpBodyEndBal.PadLeft(6, '0');
                    }
                    if (UpBodyEndBal.Length == 6)
                    {
                        UpBodyEndBal = UpBodyEndBal.PadLeft(7, '0');
                    }
                    if (UpBodyEndBal.Length == 7)
                    {
                        UpBodyEndBal = UpBodyEndBal.PadLeft(8, '0');
                    }
                    string LowBodyEnd = _LowBodyEnd.ToString("X");
                    if (LowBodyEnd.Length == 1)
                    {
                        LowBodyEnd = LowBodyEnd.PadLeft(2, '0');
                    }
                    if (LowBodyEnd.Length == 2)
                    {
                        LowBodyEnd = LowBodyEnd.PadLeft(3, '0');
                    }
                    if (LowBodyEnd.Length == 3)
                    {
                        LowBodyEnd = LowBodyEnd.PadLeft(4, '0');
                    }
                    if (LowBodyEnd.Length == 4)
                    {
                        LowBodyEnd = LowBodyEnd.PadLeft(5, '0');
                    }
                    if (LowBodyEnd.Length == 5)
                    {
                        LowBodyEnd = LowBodyEnd.PadLeft(6, '0');
                    }
                    if (LowBodyEnd.Length == 6)
                    {
                        LowBodyEnd = LowBodyEnd.PadLeft(7, '0');
                    }
                    if (LowBodyEnd.Length == 7)
                    {
                        LowBodyEnd = LowBodyEnd.PadLeft(8, '0');
                    }
                    string LowBodyEndBal = _LowBodyEndBal.ToString("X");
                    if (LowBodyEndBal.Length == 1)
                    {
                        LowBodyEndBal = LowBodyEndBal.PadLeft(2, '0');
                    }
                    if (LowBodyEndBal.Length == 2)
                    {
                        LowBodyEndBal = LowBodyEndBal.PadLeft(3, '0');
                    }
                    if (LowBodyEndBal.Length == 3)
                    {
                        LowBodyEndBal = LowBodyEndBal.PadLeft(4, '0');
                    }
                    if (LowBodyEndBal.Length == 4)
                    {
                        LowBodyEndBal = LowBodyEndBal.PadLeft(5, '0');
                    }
                    if (LowBodyEndBal.Length == 5)
                    {
                        LowBodyEndBal = LowBodyEndBal.PadLeft(6, '0');
                    }
                    if (LowBodyEndBal.Length == 6)
                    {
                        LowBodyEndBal = LowBodyEndBal.PadLeft(7, '0');
                    }
                    if (LowBodyEndBal.Length == 7)
                    {
                        LowBodyEndBal = LowBodyEndBal.PadLeft(8, '0');
                    }

                    int spaDown = new Random().Next(0, 9);
                    string SPA_dOWN = spaDown + "";
                    if (SPA_dOWN.Length == 1)
                    {
                        SPA_dOWN = SPA_dOWN.PadLeft(2, '0');
                    }
                    if (SPA_dOWN.Length == 2)
                    {
                        SPA_dOWN = SPA_dOWN.PadLeft(3, '0');
                    }
                    if (SPA_dOWN.Length == 3)
                    {
                        SPA_dOWN = SPA_dOWN.PadLeft(4, '0');
                    }
                    if (SPA_dOWN.Length == 4)
                    {
                        SPA_dOWN = SPA_dOWN.PadLeft(5, '0');
                    }
                    if (SPA_dOWN.Length == 5)
                    {
                        SPA_dOWN = SPA_dOWN.PadLeft(6, '0');
                    }
                    if (SPA_dOWN.Length == 6)
                    {
                        SPA_dOWN = SPA_dOWN.PadLeft(7, '0');
                    }
                    if (SPA_dOWN.Length == 7)
                    {
                        SPA_dOWN = SPA_dOWN.PadLeft(8, '0');
                    }
                    string spa_red = "";
                    string spa_blue = "";
                    string spa_green = "";
                    string spa_alpha = "";
                    switch (spaDown)
                    {
                        case 0:
                            spa_red = "3F80";
                            spa_blue = "3F80";
                            spa_green = "3F80";
                            spa_alpha = "3F00";
                            break;
                        case 1:
                            spa_red = "3F80";
                            spa_blue = "3F80";
                            spa_green = "3F20";
                            spa_alpha = "3F20";
                            break;
                        case 2:
                            spa_red = "3F80";
                            spa_blue = "3F20";
                            spa_green = "3F20";
                            spa_alpha = "3F20";
                            break;
                        case 3:
                            spa_red = "3F20";
                            spa_blue = "3F20";
                            spa_green = "3F80";
                            spa_alpha = "3F80";
                            break;
                        case 4:
                            spa_red = "3F20";
                            spa_blue = "3F80";
                            spa_green = "3F20";
                            spa_alpha = "3F20";
                            break;
                        case 5:
                        case 6:
                        case 7:
                        case 8:
                            spa_red = "3F80";
                            spa_blue = "3F20";
                            spa_green = "3F80";
                            spa_alpha = "3F80";
                            break;
                    }

                    int _infSPAdown = new Random().Next(0, 2);
                    string spaDownInfinite = "";
                    if (_infSPAdown == 0)
                    {
                        spaDownInfinite = "//";
                    }

                    int _spaRegained = new Random().Next(0, 65);
                    string spa_Regained = _spaRegained.ToString("X");
                    if (spa_Regained.Length == 1)
                    {
                        spa_Regained = spa_Regained.PadLeft(2, '0');
                    }
                    if (spa_Regained.Length == 2)
                    {
                        spa_Regained = spa_Regained.PadLeft(3, '0');
                    }
                    if (spa_Regained.Length == 3)
                    {
                        spa_Regained = spa_Regained.PadLeft(4, '0');
                    }
                    if (spa_Regained.Length == 4)
                    {
                        spa_Regained = spa_Regained.PadLeft(5, '0');
                    }
                    if (spa_Regained.Length == 5)
                    {
                        spa_Regained = spa_Regained.PadLeft(6, '0');
                    }
                    if (spa_Regained.Length == 6)
                    {
                        spa_Regained = spa_Regained.PadLeft(7, '0');
                    }
                    if (spa_Regained.Length == 7)
                    {
                        spa_Regained = spa_Regained.PadLeft(8, '0');
                    }

                    int _autoParry = new Random().Next(0, 2);
                    string autoParryStrikes = "";
                    if (_autoParry == 0)
                    {
                        autoParryStrikes = "//";
                    }

                    int _autaGrab = new Random().Next(0, 2);
                    string autaEscapeThrows = "";
                    if (_autaGrab == 0)
                    {
                        autaEscapeThrows = "//";
                    }

                    int _spaCooldown = new Random().Next(0, 2);
                    string spaCooldownOn = "";
                    if (_spaCooldown == 0)
                    {
                        spaCooldownOn = "//";
                    }

                    data = "" + Environment.NewLine +
                           "Player" + player + Environment.NewLine +
                "patch=1,EE," + STK + ",extended," + Strike + " //STK" + Environment.NewLine +
                "patch=1,EE," + GRP + ",extended," + Grapple + " //GRP" + Environment.NewLine +
                "patch=1,EE," + RGA + ",extended," + Regional + " //RGA" + Environment.NewLine +
                "patch=1,EE," + SPA + ",extended," + Special + " //SPA" + Environment.NewLine +
                "patch=1,EE," + WPA + ",extended," + Weapon + " //WPA" + Environment.NewLine +
                "patch=1,EE," + TGH + ",extended," + Toughness + " //TGH" + Environment.NewLine +
                "patch=1,EE," + HDE + ",extended," + HeadEnd + " //HDE" + Environment.NewLine +
                "patch=1,EE," + HDEbAl + ",extended," + HeadEndBal + " //HDE Balance" + Environment.NewLine +
                "patch=1,EE," + UBE + ",extended," + UpBodyEnd + " //UBE" + Environment.NewLine +
                "patch=1,EE," + UBEbal + ",extended," + UpBodyEndBal + " //UBE Balance" + Environment.NewLine +
                "patch=1,EE," + LBE + ",extended," + LowBodyEnd + " //LBE" + Environment.NewLine +
                "patch=1,EE," + LBEbal + ",extended," + LowBodyEndBal + " //LBE Balance" + Environment.NewLine +
                "patch=1,EE," + SPAred + ",extended," + spa_red + " //Spa Down Red Bar Color" + Environment.NewLine +
                "patch=1,EE," + SPAgreen + ",extended," + spa_blue + " //Spa Down Green Bar Color" + Environment.NewLine +
                "patch=1,EE," + SPAblue + ",extended," + spa_green + " //Spa Down Blue Bar Color" + Environment.NewLine +
                "patch=1,EE," + SPAalpha + ",extended," + spa_alpha + " //Spa Down Alpha Bar Color" + Environment.NewLine +
                "patch=1,EE," + SPAdown + ",extended," + SPA_dOWN + " //Spa Down" + Environment.NewLine +
                spaDownInfinite + "patch=1,EE," + infiniteSPAdown + ",extended,44DF8000 //Infinite Spa Down" + Environment.NewLine +
                "patch=1,EE," + SPAregained + ",extended," + spa_Regained + " //SPA Regained" + Environment.NewLine +
                autoParryStrikes + "patch=1,EE," + autoParry + ",extended,00000000 //Auto-Parry" + Environment.NewLine +
                autaEscapeThrows + "patch=1,EE," + autaGrab + ",extended,00000001 //Auta-Grab" + Environment.NewLine +
                spaCooldownOn + "patch=1,EE," + spaCooldown + ",extended,00000000 //SPA Cooldown";
                    break;

                #endregion

                case 111://Infinite Spa Down 01
                    data = "" + Environment.NewLine +
                           "Player" + player + Environment.NewLine +
                           "patch=1,EE," + SPAred + ",extended,3F80 //Spa Down Red Bar Color" + Environment.NewLine +
                           "patch=1,EE," + SPAgreen + ",extended,3F80 //Spa Down Green Bar Color" + Environment.NewLine +
                           "patch=1,EE," + SPAblue + ",extended,3F20 //Spa Down Blue Bar Color" + Environment.NewLine +
                           "patch=1,EE," + SPAalpha + ",extended,3F20 //Spa Down Alpha Bar Color" + Environment.NewLine +
                           "patch=1,EE," + SPAdown + ",extended,0001 //Spa Down" + Environment.NewLine +
                           "patch=1,EE," + infiniteSPAdown + ",extended,44DF8000 //Infinite Spa Down";
                    break;
                case 112://Infinite Spa Down 02
                    data = "" + Environment.NewLine +
                           "Player" + player + Environment.NewLine +
                           "patch=1,EE," + SPAred + ",extended,3F80 //Spa Down Red Bar Color" + Environment.NewLine +
                           "patch=1,EE," + SPAgreen + ",extended,3F20 //Spa Down Green Bar Color" + Environment.NewLine +
                           "patch=1,EE," + SPAblue + ",extended,3F20 //Spa Down Blue Bar Color" + Environment.NewLine +
                           "patch=1,EE," + SPAalpha + ",extended,3F20 //Spa Down Alpha Bar Color" + Environment.NewLine +
                           "patch=1,EE," + SPAdown + ",extended,0002 //Spa Down" + Environment.NewLine +
                           "patch=1,EE," + infiniteSPAdown + ",extended,44DF8000 //Infinite Spa Down";
                    break;
                case 113://Infinite Spa Down 03
                    data = "" + Environment.NewLine +
                           "Player" + player + Environment.NewLine +
                           "patch=1,EE," + SPAred + ",extended,3F20 //Spa Down Red Bar Color" + Environment.NewLine +
                           "patch=1,EE," + SPAgreen + ",extended,3F20 //Spa Down Green Bar Color" + Environment.NewLine +
                           "patch=1,EE," + SPAblue + ",extended,3F80 //Spa Down Blue Bar Color" + Environment.NewLine +
                           "patch=1,EE," + SPAalpha + ",extended,3F80 //Spa Down Alpha Bar Color" + Environment.NewLine +
                           "patch=1,EE," + SPAdown + ",extended,0003 //Spa Down" + Environment.NewLine +
                           "patch=1,EE," + infiniteSPAdown + ",extended,44DF8000 //Infinite Spa Down";
                    break;
                case 114://Infinite Spa Down 04
                    data = "" + Environment.NewLine +
                           "Player" + player + Environment.NewLine +
                           "patch=1,EE," + SPAred + ",extended,3F20 //Spa Down Red Bar Color" + Environment.NewLine +
                           "patch=1,EE," + SPAgreen + ",extended,3F80 //Spa Down Green Bar Color" + Environment.NewLine +
                           "patch=1,EE," + SPAblue + ",extended,3F20 //Spa Down Blue Bar Color" + Environment.NewLine +
                           "patch=1,EE," + SPAalpha + ",extended,3F20 //Spa Down Alpha Bar Color" + Environment.NewLine +
                           "patch=1,EE," + SPAdown + ",extended,0004 //Spa Down" + Environment.NewLine +
                           "patch=1,EE," + infiniteSPAdown + ",extended,44DF8000 //Infinite Spa Down";
                    break;
                case 115://Infinite Spa Down 05
                    data = "" + Environment.NewLine +
                           "Player" + player + Environment.NewLine +
                           "patch=1,EE," + SPAred + ",extended,3F80 //Spa Down Red Bar Color" + Environment.NewLine +
                           "patch=1,EE," + SPAgreen + ",extended,3F20 //Spa Down Green Bar Color" + Environment.NewLine +
                           "patch=1,EE," + SPAblue + ",extended,3F80 //Spa Down Blue Bar Color" + Environment.NewLine +
                           "patch=1,EE," + SPAalpha + ",extended,3F80 //Spa Down Alpha Bar Color" + Environment.NewLine +
                           "patch=1,EE," + SPAdown + ",extended,0005 //Spa Down" + Environment.NewLine +
                           "patch=1,EE," + infiniteSPAdown + ",extended,44DF8000 //Infinite Spa Down";
                    break;
                case 116://Infinite Spa Down 06
                    data = "" + Environment.NewLine +
                           "Player" + player + Environment.NewLine +
                           "patch=1,EE," + SPAred + ",extended,3F80 //Spa Down Red Bar Color" + Environment.NewLine +
                           "patch=1,EE," + SPAgreen + ",extended,3F20 //Spa Down Green Bar Color" + Environment.NewLine +
                           "patch=1,EE," + SPAblue + ",extended,3F80 //Spa Down Blue Bar Color" + Environment.NewLine +
                           "patch=1,EE," + SPAalpha + ",extended,3F80 //Spa Down Alpha Bar Color" + Environment.NewLine +
                           "patch=1,EE," + SPAdown + ",extended,0006 //Spa Down" + Environment.NewLine +
                           "patch=1,EE," + infiniteSPAdown + ",extended,44DF8000 //Infinite Spa Down";
                    break;
                case 117://Infinite Spa Down 07
                    data = "" + Environment.NewLine +
                           "Player" + player + Environment.NewLine +
                           "patch=1,EE," + SPAred + ",extended,3F80 //Spa Down Red Bar Color" + Environment.NewLine +
                           "patch=1,EE," + SPAgreen + ",extended,3F20 //Spa Down Green Bar Color" + Environment.NewLine +
                           "patch=1,EE," + SPAblue + ",extended,3F80 //Spa Down Blue Bar Color" + Environment.NewLine +
                           "patch=1,EE," + SPAalpha + ",extended,3F80 //Spa Down Alpha Bar Color" + Environment.NewLine +
                           "patch=1,EE," + SPAdown + ",extended,0007 //Spa Down" + Environment.NewLine +
                           "patch=1,EE," + infiniteSPAdown + ",extended,44DF8000 //Infinite Spa Down";
                    break;
                case 118://Infinite Spa Down 08
                    data = "" + Environment.NewLine +
                           "Player" + player + Environment.NewLine +
                           "patch=1,EE," + SPAred + ",extended,3F80 //Spa Down Red Bar Color" + Environment.NewLine +
                           "patch=1,EE," + SPAgreen + ",extended,3F20 //Spa Down Green Bar Color" + Environment.NewLine +
                           "patch=1,EE," + SPAblue + ",extended,3F80 //Spa Down Blue Bar Color" + Environment.NewLine +
                           "patch=1,EE," + SPAalpha + ",extended,3F80 //Spa Down Alpha Bar Color" + Environment.NewLine +
                           "patch=1,EE," + SPAdown + ",extended,0008 //Spa Down" + Environment.NewLine +
                           "patch=1,EE," + infiniteSPAdown + ",extended,44DF8000 //Infinite Spa Down";
                    break;
                case 119://Strife Surge (getting damage = increse stats)
                    data = "" + Environment.NewLine +
                           "Player" + player + Environment.NewLine +
                           "patch=1,EE," + hpCondition + ",extended,012005DC //if hp is less than 1500 (100%)" + Environment.NewLine +
                           "patch=1,EE," + STK + ",extended,03E8 //STK" + Environment.NewLine +
                           "patch=1,EE," + hpCondition + ",extended,012005DC //if hp is less than 1500 (100%)" + Environment.NewLine +
                           "patch=1,EE," + GRP + ",extended,03E8 //GRP" + Environment.NewLine +
                           "patch=1,EE," + hpCondition + ",extended,012005DC //if hp is less than 1500 (100%)" + Environment.NewLine +
                           "patch=1,EE," + RGA + ",extended,03E8 //RGA" + Environment.NewLine +
                           "patch=1,EE," + hpCondition + ",extended,012005DC //if hp is less than 1500 (100%)" + Environment.NewLine +
                           "patch=1,EE," + SPA + ",extended,03E8 //SPA" + Environment.NewLine +
                           "patch=1,EE," + hpCondition + ",extended,012005DC //if hp is less than 1500 (100%)" + Environment.NewLine +
                           "patch=1,EE," + WPA + ",extended,03E8 //WPA" + Environment.NewLine +

                           "patch=1,EE," + hpCondition + ",extended,012004E2 //if hp is less than 1250 (83%)" + Environment.NewLine +
                           "patch=1,EE," + STK + ",extended,05DC //STK" + Environment.NewLine +
                           "patch=1,EE," + hpCondition + ",extended,012004E2 //if hp is less than 1250 (83%)" + Environment.NewLine +
                           "patch=1,EE," + GRP + ",extended,05DC //GRP" + Environment.NewLine +
                           "patch=1,EE," + hpCondition + ",extended,012004E2 //if hp is less than 1250 (83%)" + Environment.NewLine +
                           "patch=1,EE," + RGA + ",extended,05DC //RGA" + Environment.NewLine +
                           "patch=1,EE," + hpCondition + ",extended,012004E2 //if hp is less than 1250 (83%)" + Environment.NewLine +
                           "patch=1,EE," + SPA + ",extended,05DC //SPA" + Environment.NewLine +
                           "patch=1,EE," + hpCondition + ",extended,012004E2 //if hp is less than 1250 (83%)" + Environment.NewLine +
                           "patch=1,EE," + WPA + ",extended,05DC //WPA" + Environment.NewLine +

                           "patch=1,EE," + hpCondition + ",extended,012003E8 //if hp is less than 1000 (66%)" + Environment.NewLine +
                           "patch=1,EE," + STK + ",extended,07D0 //STK" + Environment.NewLine +
                           "patch=1,EE," + hpCondition + ",extended,012003E8 //if hp is less than 1000 (66%)" + Environment.NewLine +
                           "patch=1,EE," + GRP + ",extended,07D0 //GRP" + Environment.NewLine +
                           "patch=1,EE," + hpCondition + ",extended,012003E8 //if hp is less than 1000 (66%)" + Environment.NewLine +
                           "patch=1,EE," + RGA + ",extended,07D0 //RGA" + Environment.NewLine +
                           "patch=1,EE," + hpCondition + ",extended,012003E8 //if hp is less than 1000 (66%)" + Environment.NewLine +
                           "patch=1,EE," + SPA + ",extended,07D0 //SPA" + Environment.NewLine +
                           "patch=1,EE," + hpCondition + ",extended,012003E8 //if hp is less than 1000 (66%)" + Environment.NewLine +
                           "patch=1,EE," + WPA + ",extended,07D0 //WPA" + Environment.NewLine +

                           "patch=1,EE," + hpCondition + ",extended,012002EE //if hp is less than 750 (50%)" + Environment.NewLine +
                           "patch=1,EE," + STK + ",extended,09C4 //STK" + Environment.NewLine +
                           "patch=1,EE," + hpCondition + ",extended,012002EE //if hp is less than 750 (50%)" + Environment.NewLine +
                           "patch=1,EE," + GRP + ",extended,09C4 //GRP" + Environment.NewLine +
                           "patch=1,EE," + hpCondition + ",extended,012002EE //if hp is less than 750 (50%)" + Environment.NewLine +
                           "patch=1,EE," + RGA + ",extended,09C4 //RGA" + Environment.NewLine +
                           "patch=1,EE," + hpCondition + ",extended,012002EE //if hp is less than 750 (50%)" + Environment.NewLine +
                           "patch=1,EE," + SPA + ",extended,09C4 //SPA" + Environment.NewLine +
                           "patch=1,EE," + hpCondition + ",extended,012002EE //if hp is less than 750 (50%)" + Environment.NewLine +
                           "patch=1,EE," + WPA + ",extended,09C4 //WPA" + Environment.NewLine +

                           "patch=1,EE," + hpCondition + ",extended,012001F4 //if hp is less than 500 (33%)" + Environment.NewLine +
                           "patch=1,EE," + STK + ",extended,0BB8 //STK" + Environment.NewLine +
                           "patch=1,EE," + hpCondition + ",extended,012001F4 //if hp is less than 500 (33%)" + Environment.NewLine +
                           "patch=1,EE," + GRP + ",extended,0BB8 //GRP" + Environment.NewLine +
                           "patch=1,EE," + hpCondition + ",extended,012001F4 //if hp is less than 500 (33%)" + Environment.NewLine +
                           "patch=1,EE," + RGA + ",extended,0BB8 //RGA" + Environment.NewLine +
                           "patch=1,EE," + hpCondition + ",extended,012001F4 //if hp is less than 500 (33%)" + Environment.NewLine +
                           "patch=1,EE," + SPA + ",extended,0BB8 //SPA" + Environment.NewLine +
                           "patch=1,EE," + hpCondition + ",extended,012001F4 //if hp is less than 500 (33%)" + Environment.NewLine +
                           "patch=1,EE," + WPA + ",extended,0BB8 //WPA" + Environment.NewLine +

                           "patch=1,EE," + hpCondition + ",extended,012000FA //if hp is less than 250 (16%)" + Environment.NewLine +
                           "patch=1,EE," + TGH + ",extended,05DC //TGH" + Environment.NewLine +
                           "patch=1,EE," + hpCondition + ",extended,012000FA //if hp is less than 250 (16%)" + Environment.NewLine +
                           "patch=1,EE," + autoParry + ",extended,0000 //Auto-Parry" + Environment.NewLine +
                           "patch=1,EE," + hpCondition + ",extended,012000FA //if hp is less than 250 (16%)" + Environment.NewLine +
                           "patch=1,EE," + SPAregained + ",extended,00FA //SPA Regained";
                    break;
                case 121://Spa Down Custom 1 [Regeneration]
                    string baseHP = "05DC";
                    if (freeModeOn)
                    {
                        baseHP = "04B0";
                    }

                    data = "" + Environment.NewLine +
                           "Player" + player + Environment.NewLine +
                           "patch=1,EE," + SPAred + ",extended,3F20 //Spa Down Red Bar Color" + Environment.NewLine +
                           "patch=1,EE," + SPAgreen + ",extended,3FB0 //Spa Down Green Bar Color" + Environment.NewLine +
                           "patch=1,EE," + SPAblue + ",extended,3FB0 //Spa Down Blue Bar Color" + Environment.NewLine +
                           "patch=1,EE," + SPAalpha + ",extended,3F20 //Spa Down Alpha Bar Color" + Environment.NewLine +
                           "patch=1,EE," + SPAdown + ",extended,0000 //Spa Down" + Environment.NewLine +

                           "patch=1,EE," + spaActivation + ",extended,02300000 //If SPA is activated" + Environment.NewLine +
                           "patch=1,EE," + playerHpCondition + ",extended,0120" + baseHP + " //If HP is lower than max [1500]" + Environment.NewLine +
                           "patch=1,EE,30200001,extended," + playerHealthValueCondition + " //Recover Health by 1";
                    break;
                case 122://Spa Down Custom 2 [Redbull]
                    data = "" + Environment.NewLine +
                           "Player" + player + Environment.NewLine +
                           "patch=1,EE," + SPAred + ",extended,4000 //Spa Down Red Bar Color" + Environment.NewLine +
                           "patch=1,EE," + SPAgreen + ",extended,3F00 //Spa Down Green Bar Color" + Environment.NewLine +
                           "patch=1,EE," + SPAblue + ",extended,3F00 //Spa Down Blue Bar Color" + Environment.NewLine +
                           "patch=1,EE," + SPAalpha + ",extended,4000 //Spa Down Alpha Bar Color" + Environment.NewLine +
                           "patch=1,EE," + SPAdown + ",extended,0008 //Spa Down" + Environment.NewLine +

                           "patch=1,EE," + spaActivation + ",extended,02300000 //If SPA is activated" + Environment.NewLine +
                           "patch=1,EE," + playerHpCondition + ",extended,01300001 //If HP is higher than 0" + Environment.NewLine +
                           "patch=1,EE,30300001,extended," + playerHealthValueCondition + " //Lose Health by 1" + Environment.NewLine +
                           "patch=1,EE," + spaActivation + ",extended,03300000 //If SPA is activated" + Environment.NewLine +
                           "patch=1,EE," + spaCondition + ",extended,022003E8 //If SPA is lower than max [1000]" + Environment.NewLine +
                           "patch=1,EE," + playerHpCondition + ",extended,01300001 //If HP is higher than 0" + Environment.NewLine +
                           "patch=1,EE,30200005,extended," + playerSpaValueCondition + " //Recover SPA by 5";
                    break;
                case 1000://Fly ???
                    data = "" + Environment.NewLine +
                           "Player" + player + Environment.NewLine +
                           "patch=1,EE," + fly + ",extended,40400000 //Y pos";
                    break;

            }

            return data;
        }


        internal string GetMissionData(int missionNumber, int enemyAI)
        {
            // Read the text file
            string[] lines = File.ReadAllLines(SettingsClass.missionFolderPath + @"\M" + missionNumber + ".txt");

            // Assign each line to a string variable
            string player2posA = lines[0];
            string player2posB = lines[1];
            string player2posC = lines[2];

            #region Get Enemy Data

            //line7 = lines[6].Substring(8);
            //line8 = lines[6].Substring(0, 8);

            string enemy1ID = lines[5];
            string enemy1_data1 = lines[6];
            string enemy1_data2 = lines[7];
            string enemy1_data3 = lines[8];
            string enemy1_data4 = lines[9];
            string enemy1_data5 = lines[10];
            string enemy1_data6 = lines[11];
            string enemy1_data7 = lines[12];
            string enemy1_data8 = lines[13];
            string enemy1_data9 = lines[14];
            string enemy1_data10 = lines[15];
            string enemy1_data11 = lines[16];
            string enemy1_data12 = lines[17];
            string enemy1_data13 = lines[18];
            string enemy1_data14 = lines[19];
            string enemy1_data15 = lines[20];
            string enemy1_data16 = lines[21];
            string enemy1_data17 = lines[22];
            string enemy1_data18 = lines[23];
            string enemy1_data19 = lines[24];
            string enemy1_data20 = lines[25];
            string enemy1_data21 = lines[26];
            string enemy1_data22 = lines[27];
            string enemy1_data23 = lines[28];
            string enemy1_data24 = lines[29];
            string enemy1_data25 = lines[30];
            string enemy1_data26 = lines[31];
            string enemy1_data27 = lines[32];
            string enemy1_data28 = lines[33];
            string enemy1_data29 = lines[34];
            string enemy1_data30 = lines[35];
            string enemy1_data31 = lines[36];
            string enemy1_data32 = lines[37];
            string enemy1_data33 = lines[38];
            string enemy1_data34 = lines[39];
            string enemy1_data35 = lines[40];
            string enemy1_data36 = lines[41];
            string enemy1_data37 = lines[42];
            string enemy1_data38 = lines[43];
            string enemy1_data39 = lines[44];
            string enemy1_data40 = lines[45];
            string enemy1_data41 = lines[46];
            string enemy1_data42 = lines[47];

            string enemy2ID = "";
            string enemy2_data1 = "";
            string enemy2_data2 = "";
            string enemy2_data3 = "";
            string enemy2_data4 = "";
            string enemy2_data5 = "";
            string enemy2_data6 = "";
            string enemy2_data7 = "";
            string enemy2_data8 = "";
            string enemy2_data9 = "";
            string enemy2_data10 = "";
            string enemy2_data11 = "";
            string enemy2_data12 = "";
            string enemy2_data13 = "";
            string enemy2_data14 = "";
            string enemy2_data15 = "";
            string enemy2_data16 = "";
            string enemy2_data17 = "";
            string enemy2_data18 = "";
            string enemy2_data19 = "";
            string enemy2_data20 = "";
            string enemy2_data21 = "";
            string enemy2_data22 = "";
            string enemy2_data23 = "";
            string enemy2_data24 = "";
            string enemy2_data25 = "";
            string enemy2_data26 = "";
            string enemy2_data27 = "";
            string enemy2_data28 = "";
            string enemy2_data29 = "";
            string enemy2_data30 = "";
            string enemy2_data31 = "";
            string enemy2_data32 = "";
            string enemy2_data33 = "";
            string enemy2_data34 = "";
            string enemy2_data35 = "";
            string enemy2_data36 = "";
            string enemy2_data37 = "";
            string enemy2_data38 = "";
            string enemy2_data39 = "";
            string enemy2_data40 = "";
            string enemy2_data41 = "";
            string enemy2_data42 = "";
            
            string enemy3ID = "";
            string enemy3_data1 = "";
            string enemy3_data2 = "";
            string enemy3_data3 = "";
            string enemy3_data4 = "";
            string enemy3_data5 = "";
            string enemy3_data6 = "";
            string enemy3_data7 = "";
            string enemy3_data8 = "";
            string enemy3_data9 = "";
            string enemy3_data10 = "";
            string enemy3_data11 = "";
            string enemy3_data12 = "";
            string enemy3_data13 = "";
            string enemy3_data14 = "";
            string enemy3_data15 = "";
            string enemy3_data16 = "";
            string enemy3_data17 = "";
            string enemy3_data18 = "";
            string enemy3_data19 = "";
            string enemy3_data20 = "";
            string enemy3_data21 = "";
            string enemy3_data22 = "";
            string enemy3_data23 = "";
            string enemy3_data24 = "";
            string enemy3_data25 = "";
            string enemy3_data26 = "";
            string enemy3_data27 = "";
            string enemy3_data28 = "";
            string enemy3_data29 = "";
            string enemy3_data30 = "";
            string enemy3_data31 = "";
            string enemy3_data32 = "";
            string enemy3_data33 = "";
            string enemy3_data34 = "";
            string enemy3_data35 = "";
            string enemy3_data36 = "";
            string enemy3_data37 = "";
            string enemy3_data38 = "";
            string enemy3_data39 = "";
            string enemy3_data40 = "";
            string enemy3_data41 = "";
            string enemy3_data42 = "";


            string enemy4ID = "";
            string enemy4_data1 = "";
            string enemy4_data2 = "";
            string enemy4_data3 = "";
            string enemy4_data4 = "";
            string enemy4_data5 = "";
            string enemy4_data6 = "";
            string enemy4_data7 = "";
            string enemy4_data8 = "";
            string enemy4_data9 = "";
            string enemy4_data10 = "";
            string enemy4_data11 = "";
            string enemy4_data12 = "";
            string enemy4_data13 = "";
            string enemy4_data14 = "";
            string enemy4_data15 = "";
            string enemy4_data16 = "";
            string enemy4_data17 = "";
            string enemy4_data18 = "";
            string enemy4_data19 = "";
            string enemy4_data20 = "";
            string enemy4_data21 = "";
            string enemy4_data22 = "";
            string enemy4_data23 = "";
            string enemy4_data24 = "";
            string enemy4_data25 = "";
            string enemy4_data26 = "";
            string enemy4_data27 = "";
            string enemy4_data28 = "";
            string enemy4_data29 = "";
            string enemy4_data30 = "";
            string enemy4_data31 = "";
            string enemy4_data32 = "";
            string enemy4_data33 = "";
            string enemy4_data34 = "";
            string enemy4_data35 = "";
            string enemy4_data36 = "";
            string enemy4_data37 = "";
            string enemy4_data38 = "";
            string enemy4_data39 = "";
            string enemy4_data40 = "";
            string enemy4_data41 = "";
            string enemy4_data42 = "";


            string enemy5ID = "";
            string enemy5_data1 = "";
            string enemy5_data2 = "";
            string enemy5_data3 = "";
            string enemy5_data4 = "";
            string enemy5_data5 = "";
            string enemy5_data6 = "";
            string enemy5_data7 = "";
            string enemy5_data8 = "";
            string enemy5_data9 = "";
            string enemy5_data10 = "";
            string enemy5_data11 = "";
            string enemy5_data12 = "";
            string enemy5_data13 = "";
            string enemy5_data14 = "";
            string enemy5_data15 = "";
            string enemy5_data16 = "";
            string enemy5_data17 = "";
            string enemy5_data18 = "";
            string enemy5_data19 = "";
            string enemy5_data20 = "";
            string enemy5_data21 = "";
            string enemy5_data22 = "";
            string enemy5_data23 = "";
            string enemy5_data24 = "";
            string enemy5_data25 = "";
            string enemy5_data26 = "";
            string enemy5_data27 = "";
            string enemy5_data28 = "";
            string enemy5_data29 = "";
            string enemy5_data30 = "";
            string enemy5_data31 = "";
            string enemy5_data32 = "";
            string enemy5_data33 = "";
            string enemy5_data34 = "";
            string enemy5_data35 = "";
            string enemy5_data36 = "";
            string enemy5_data37 = "";
            string enemy5_data38 = "";
            string enemy5_data39 = "";
            string enemy5_data40 = "";
            string enemy5_data41 = "";
            string enemy5_data42 = "";


            string enemy6ID = "";
            string enemy6_data1 = "";
            string enemy6_data2 = "";
            string enemy6_data3 = "";
            string enemy6_data4 = "";
            string enemy6_data5 = "";
            string enemy6_data6 = "";
            string enemy6_data7 = "";
            string enemy6_data8 = "";
            string enemy6_data9 = "";
            string enemy6_data10 = "";
            string enemy6_data11 = "";
            string enemy6_data12 = "";
            string enemy6_data13 = "";
            string enemy6_data14 = "";
            string enemy6_data15 = "";
            string enemy6_data16 = "";
            string enemy6_data17 = "";
            string enemy6_data18 = "";
            string enemy6_data19 = "";
            string enemy6_data20 = "";
            string enemy6_data21 = "";
            string enemy6_data22 = "";
            string enemy6_data23 = "";
            string enemy6_data24 = "";
            string enemy6_data25 = "";
            string enemy6_data26 = "";
            string enemy6_data27 = "";
            string enemy6_data28 = "";
            string enemy6_data29 = "";
            string enemy6_data30 = "";
            string enemy6_data31 = "";
            string enemy6_data32 = "";
            string enemy6_data33 = "";
            string enemy6_data34 = "";
            string enemy6_data35 = "";
            string enemy6_data36 = "";
            string enemy6_data37 = "";
            string enemy6_data38 = "";
            string enemy6_data39 = "";
            string enemy6_data40 = "";
            string enemy6_data41 = "";
            string enemy6_data42 = "";

            try
            {
                enemy2ID = lines[50];
                enemy2_data1 = lines[51];
                enemy2_data2 = lines[52];
                enemy2_data3 = lines[53];
                enemy2_data4 = lines[54];
                enemy2_data5 = lines[55];
                enemy2_data6 = lines[56];
                enemy2_data7 = lines[57];
                enemy2_data8 = lines[58];
                enemy2_data9 = lines[59];
                enemy2_data10 = lines[60];
                enemy2_data11 = lines[61];
                enemy2_data12 = lines[62];
                enemy2_data13 = lines[63];
                enemy2_data14 = lines[64];
                enemy2_data15 = lines[65];
                enemy2_data16 = lines[66];
                enemy2_data17 = lines[67];
                enemy2_data18 = lines[68];
                enemy2_data19 = lines[69];
                enemy2_data20 = lines[70];
                enemy2_data21 = lines[71];
                enemy2_data22 = lines[72];
                enemy2_data23 = lines[73];
                enemy2_data24 = lines[74];
                enemy2_data25 = lines[75];
                enemy2_data26 = lines[76];
                enemy2_data27 = lines[77];
                enemy2_data28 = lines[78];
                enemy2_data29 = lines[79];
                enemy2_data30 = lines[80];
                enemy2_data31 = lines[81];
                enemy2_data32 = lines[82];
                enemy2_data33 = lines[83];
                enemy2_data34 = lines[84];
                enemy2_data35 = lines[85];
                enemy2_data36 = lines[86];
                enemy2_data37 = lines[87];
                enemy2_data38 = lines[88];
                enemy2_data39 = lines[89];
                enemy2_data40 = lines[90];
                enemy2_data41 = lines[91];
                enemy2_data42 = lines[92];

                enemy3ID = lines[95];
                enemy3_data1 = lines[96];
                enemy3_data2 = lines[97];
                enemy3_data3 = lines[98];
                enemy3_data4 = lines[99];
                enemy3_data5 = lines[100];
                enemy3_data6 = lines[101];
                enemy3_data7 = lines[102];
                enemy3_data8 = lines[103];
                enemy3_data9 = lines[104];
                enemy3_data10 = lines[105];
                enemy3_data11 = lines[106];
                enemy3_data12 = lines[107];
                enemy3_data13 = lines[108];
                enemy3_data14 = lines[109];
                enemy3_data15 = lines[110];
                enemy3_data16 = lines[111];
                enemy3_data17 = lines[112];
                enemy3_data18 = lines[113];
                enemy3_data19 = lines[114];
                enemy3_data20 = lines[115];
                enemy3_data21 = lines[116];
                enemy3_data22 = lines[117];
                enemy3_data23 = lines[118];
                enemy3_data24 = lines[119];
                enemy3_data25 = lines[120];
                enemy3_data26 = lines[121];
                enemy3_data27 = lines[122];
                enemy3_data28 = lines[123];
                enemy3_data29 = lines[124];
                enemy3_data30 = lines[125];
                enemy3_data31 = lines[126];
                enemy3_data32 = lines[127];
                enemy3_data33 = lines[128];
                enemy3_data34 = lines[129];
                enemy3_data35 = lines[130];
                enemy3_data36 = lines[131];
                enemy3_data37 = lines[132];
                enemy3_data38 = lines[133];
                enemy3_data39 = lines[134];
                enemy3_data40 = lines[135];
                enemy3_data41 = lines[136];
                enemy3_data42 = lines[137];

                enemy4ID = lines[140];
                enemy4_data1 = lines[141];
                enemy4_data2 = lines[142];
                enemy4_data3 = lines[143];
                enemy4_data4 = lines[144];
                enemy4_data5 = lines[145];
                enemy4_data6 = lines[146];
                enemy4_data7 = lines[147];
                enemy4_data8 = lines[148];
                enemy4_data9 = lines[149];
                enemy4_data10 = lines[150];
                enemy4_data11 = lines[151];
                enemy4_data12 = lines[152];
                enemy4_data13 = lines[153];
                enemy4_data14 = lines[154];
                enemy4_data15 = lines[155];
                enemy4_data16 = lines[156];
                enemy4_data17 = lines[157];
                enemy4_data18 = lines[158];
                enemy4_data19 = lines[159];
                enemy4_data20 = lines[160];
                enemy4_data21 = lines[161];
                enemy4_data22 = lines[162];
                enemy4_data23 = lines[163];
                enemy4_data24 = lines[164];
                enemy4_data25 = lines[165];
                enemy4_data26 = lines[166];
                enemy4_data27 = lines[167];
                enemy4_data28 = lines[168];
                enemy4_data29 = lines[169];
                enemy4_data30 = lines[170];
                enemy4_data31 = lines[171];
                enemy4_data32 = lines[172];
                enemy4_data33 = lines[173];
                enemy4_data34 = lines[174];
                enemy4_data35 = lines[175];
                enemy4_data36 = lines[176];
                enemy4_data37 = lines[177];
                enemy4_data38 = lines[178];
                enemy4_data39 = lines[179];
                enemy4_data40 = lines[180];
                enemy4_data41 = lines[181];
                enemy4_data42 = lines[182];

                enemy5ID = lines[185];
                enemy5_data1 = lines[186];
                enemy5_data2 = lines[187];
                enemy5_data3 = lines[188];
                enemy5_data4 = lines[189];
                enemy5_data5 = lines[190];
                enemy5_data6 = lines[191];
                enemy5_data7 = lines[192];
                enemy5_data8 = lines[193];
                enemy5_data9 = lines[194];
                enemy5_data10 = lines[195];
                enemy5_data11 = lines[196];
                enemy5_data12 = lines[197];
                enemy5_data13 = lines[198];
                enemy5_data14 = lines[199];
                enemy5_data15 = lines[200];
                enemy5_data16 = lines[201];
                enemy5_data17 = lines[202];
                enemy5_data18 = lines[203];
                enemy5_data19 = lines[204];
                enemy5_data20 = lines[205];
                enemy5_data21 = lines[206];
                enemy5_data22 = lines[207];
                enemy5_data23 = lines[208];
                enemy5_data24 = lines[209];
                enemy5_data25 = lines[210];
                enemy5_data26 = lines[211];
                enemy5_data27 = lines[212];
                enemy5_data28 = lines[213];
                enemy5_data29 = lines[214];
                enemy5_data30 = lines[215];
                enemy5_data31 = lines[216];
                enemy5_data32 = lines[217];
                enemy5_data33 = lines[218];
                enemy5_data34 = lines[219];
                enemy5_data35 = lines[220];
                enemy5_data36 = lines[221];
                enemy5_data37 = lines[222];
                enemy5_data38 = lines[223];
                enemy5_data39 = lines[224];
                enemy5_data40 = lines[225];
                enemy5_data41 = lines[226];
                enemy5_data42 = lines[227];

                enemy6ID = lines[230];
            }
            catch
            {
                if (enemy2ID == "")
                {
                     enemy2ID = enemy1ID;
                     enemy2_data1 = enemy1_data1;
                     enemy2_data2 = enemy1_data2;
                     enemy2_data3 = enemy1_data3;
                     enemy2_data4 = enemy1_data4;
                     enemy2_data5 = enemy1_data5;
                     enemy2_data6 = enemy1_data6;
                     enemy2_data7 = enemy1_data7;
                     enemy2_data8 = enemy1_data8;
                     enemy2_data9 = enemy1_data9;
                     enemy2_data10 = enemy1_data10;
                     enemy2_data11 = enemy1_data11;
                     enemy2_data12 = enemy1_data12;
                     enemy2_data13 = enemy1_data13;
                     enemy2_data14 = enemy1_data14;
                     enemy2_data15 = enemy1_data15;
                     enemy2_data16 = enemy1_data16;
                     enemy2_data17 = enemy1_data17;
                     enemy2_data18 = enemy1_data18;
                     enemy2_data19 = enemy1_data19;
                     enemy2_data20 = enemy1_data20;
                     enemy2_data21 = enemy1_data21;
                     enemy2_data22 = enemy1_data22;
                     enemy2_data23 = enemy1_data23;
                     enemy2_data24 = enemy1_data24;
                     enemy2_data25 = enemy1_data25;
                     enemy2_data26 = enemy1_data26;
                     enemy2_data27 = enemy1_data27;
                     enemy2_data28 = enemy1_data28;
                     enemy2_data29 = enemy1_data29;
                     enemy2_data30 = enemy1_data30;
                     enemy2_data31 = enemy1_data31;
                     enemy2_data32 = enemy1_data32;
                     enemy2_data33 = enemy1_data33;
                     enemy2_data34 = enemy1_data34;
                     enemy2_data35 = enemy1_data35;
                     enemy2_data36 = enemy1_data36;
                     enemy2_data37 = enemy1_data37;
                     enemy2_data38 = enemy1_data38;
                     enemy2_data39 = enemy1_data39;
                     enemy2_data40 = enemy1_data40;
                     enemy2_data41 = enemy1_data41;
                     enemy2_data42 = enemy1_data42;
                    
                     enemy3ID = enemy1ID;
                     enemy3_data1 = enemy1_data1;
                     enemy3_data2 = enemy1_data2;
                     enemy3_data3 = enemy1_data3;
                     enemy3_data4 = enemy1_data4;
                     enemy3_data5 = enemy1_data5;
                     enemy3_data6 = enemy1_data6;
                     enemy3_data7 = enemy1_data7;
                     enemy3_data8 = enemy1_data8;
                     enemy3_data9 = enemy1_data9;
                     enemy3_data10 = enemy1_data10;
                     enemy3_data11 = enemy1_data11;
                     enemy3_data12 = enemy1_data12;
                     enemy3_data13 = enemy1_data13;
                     enemy3_data14 = enemy1_data14;
                     enemy3_data15 = enemy1_data15;
                     enemy3_data16 = enemy1_data16;
                     enemy3_data17 = enemy1_data17;
                     enemy3_data18 = enemy1_data18;
                     enemy3_data19 = enemy1_data19;
                     enemy3_data20 = enemy1_data20;
                     enemy3_data21 = enemy1_data21;
                     enemy3_data22 = enemy1_data22;
                     enemy3_data23 = enemy1_data23;
                     enemy3_data24 = enemy1_data24;
                     enemy3_data25 = enemy1_data25;
                     enemy3_data26 = enemy1_data26;
                     enemy3_data27 = enemy1_data27;
                     enemy3_data28 = enemy1_data28;
                     enemy3_data29 = enemy1_data29;
                     enemy3_data30 = enemy1_data30;
                     enemy3_data31 = enemy1_data31;
                     enemy3_data32 = enemy1_data32;
                     enemy3_data33 = enemy1_data33;
                     enemy3_data34 = enemy1_data34;
                     enemy3_data35 = enemy1_data35;
                     enemy3_data36 = enemy1_data36;
                     enemy3_data37 = enemy1_data37;
                     enemy3_data38 = enemy1_data38;
                     enemy3_data39 = enemy1_data39;
                     enemy3_data40 = enemy1_data40;
                     enemy3_data41 = enemy1_data41;
                     enemy3_data42 = enemy1_data42;


                     enemy4ID = enemy1ID;
                     enemy4_data1 = enemy1_data1;
                     enemy4_data2 = enemy1_data2;
                     enemy4_data3 = enemy1_data3;
                     enemy4_data4 = enemy1_data4;
                     enemy4_data5 = enemy1_data5;
                     enemy4_data6 = enemy1_data6;
                     enemy4_data7 = enemy1_data7;
                     enemy4_data8 = enemy1_data8;
                     enemy4_data9 = enemy1_data9;
                     enemy4_data10 = enemy1_data10;
                     enemy4_data11 = enemy1_data11;
                     enemy4_data12 = enemy1_data12;
                     enemy4_data13 = enemy1_data13;
                     enemy4_data14 = enemy1_data14;
                     enemy4_data15 = enemy1_data15;
                     enemy4_data16 = enemy1_data16;
                     enemy4_data17 = enemy1_data17;
                     enemy4_data18 = enemy1_data18;
                     enemy4_data19 = enemy1_data19;
                     enemy4_data20 = enemy1_data20;
                     enemy4_data21 = enemy1_data21;
                     enemy4_data22 = enemy1_data22;
                     enemy4_data23 = enemy1_data23;
                     enemy4_data24 = enemy1_data24;
                     enemy4_data25 = enemy1_data25;
                     enemy4_data26 = enemy1_data26;
                     enemy4_data27 = enemy1_data27;
                     enemy4_data28 = enemy1_data28;
                     enemy4_data29 = enemy1_data29;
                     enemy4_data30 = enemy1_data30;
                     enemy4_data31 = enemy1_data31;
                     enemy4_data32 = enemy1_data32;
                     enemy4_data33 = enemy1_data33;
                     enemy4_data34 = enemy1_data34;
                     enemy4_data35 = enemy1_data35;
                     enemy4_data36 = enemy1_data36;
                     enemy4_data37 = enemy1_data37;
                     enemy4_data38 = enemy1_data38;
                     enemy4_data39 = enemy1_data39;
                     enemy4_data40 = enemy1_data40;
                     enemy4_data41 = enemy1_data41;
                     enemy4_data42 = enemy1_data42;


                     enemy5ID = enemy1ID;
                     enemy5_data1 = enemy1_data1;
                     enemy5_data2 = enemy1_data2;
                     enemy5_data3 = enemy1_data3;
                     enemy5_data4 = enemy1_data4;
                     enemy5_data5 = enemy1_data5;
                     enemy5_data6 = enemy1_data6;
                     enemy5_data7 = enemy1_data7;
                     enemy5_data8 = enemy1_data8;
                     enemy5_data9 = enemy1_data9;
                     enemy5_data10 = enemy1_data10;
                     enemy5_data11 = enemy1_data11;
                     enemy5_data12 = enemy1_data12;
                     enemy5_data13 = enemy1_data13;
                     enemy5_data14 = enemy1_data14;
                     enemy5_data15 = enemy1_data15;
                     enemy5_data16 = enemy1_data16;
                     enemy5_data17 = enemy1_data17;
                     enemy5_data18 = enemy1_data18;
                     enemy5_data19 = enemy1_data19;
                     enemy5_data20 = enemy1_data20;
                     enemy5_data21 = enemy1_data21;
                     enemy5_data22 = enemy1_data22;
                     enemy5_data23 = enemy1_data23;
                     enemy5_data24 = enemy1_data24;
                     enemy5_data25 = enemy1_data25;
                     enemy5_data26 = enemy1_data26;
                     enemy5_data27 = enemy1_data27;
                     enemy5_data28 = enemy1_data28;
                     enemy5_data29 = enemy1_data29;
                     enemy5_data30 = enemy1_data30;
                     enemy5_data31 = enemy1_data31;
                     enemy5_data32 = enemy1_data32;
                     enemy5_data33 = enemy1_data33;
                     enemy5_data34 = enemy1_data34;
                     enemy5_data35 = enemy1_data35;
                     enemy5_data36 = enemy1_data36;
                     enemy5_data37 = enemy1_data37;
                     enemy5_data38 = enemy1_data38;
                     enemy5_data39 = enemy1_data39;
                     enemy5_data40 = enemy1_data40;
                     enemy5_data41 = enemy1_data41;
                     enemy5_data42 = enemy1_data42;


                     enemy6ID = enemy1ID;
                     enemy6_data1 = enemy1_data1;
                     enemy6_data2 = enemy1_data2;
                     enemy6_data3 = enemy1_data3;
                     enemy6_data4 = enemy1_data4;
                     enemy6_data5 = enemy1_data5;
                     enemy6_data6 = enemy1_data6;
                     enemy6_data7 = enemy1_data7;
                     enemy6_data8 = enemy1_data8;
                     enemy6_data9 = enemy1_data9;
                     enemy6_data10 = enemy1_data10;
                     enemy6_data11 = enemy1_data11;
                     enemy6_data12 = enemy1_data12;
                     enemy6_data13 = enemy1_data13;
                     enemy6_data14 = enemy1_data14;
                     enemy6_data15 = enemy1_data15;
                     enemy6_data16 = enemy1_data16;
                     enemy6_data17 = enemy1_data17;
                     enemy6_data18 = enemy1_data18;
                     enemy6_data19 = enemy1_data19;
                     enemy6_data20 = enemy1_data20;
                     enemy6_data21 = enemy1_data21;
                     enemy6_data22 = enemy1_data22;
                     enemy6_data23 = enemy1_data23;
                     enemy6_data24 = enemy1_data24;
                     enemy6_data25 = enemy1_data25;
                     enemy6_data26 = enemy1_data26;
                     enemy6_data27 = enemy1_data27;
                     enemy6_data28 = enemy1_data28;
                     enemy6_data29 = enemy1_data29;
                     enemy6_data30 = enemy1_data30;
                     enemy6_data31 = enemy1_data31;
                     enemy6_data32 = enemy1_data32;
                     enemy6_data33 = enemy1_data33;
                     enemy6_data34 = enemy1_data34;
                     enemy6_data35 = enemy1_data35;
                     enemy6_data36 = enemy1_data36;
                     enemy6_data37 = enemy1_data37;
                     enemy6_data38 = enemy1_data38;
                     enemy6_data39 = enemy1_data39;
                     enemy6_data40 = enemy1_data40;
                     enemy6_data41 = enemy1_data41;
                     enemy6_data42 = enemy1_data42;

                }
                else if (enemy3ID == "")
                {

                     enemy3ID = enemy1ID;
                     enemy3_data1 = enemy1_data1;
                     enemy3_data2 = enemy1_data2;
                     enemy3_data3 = enemy1_data3;
                     enemy3_data4 = enemy1_data4;
                     enemy3_data5 = enemy1_data5;
                     enemy3_data6 = enemy1_data6;
                     enemy3_data7 = enemy1_data7;
                     enemy3_data8 = enemy1_data8;
                     enemy3_data9 = enemy1_data9;
                     enemy3_data10 = enemy1_data10;
                     enemy3_data11 = enemy1_data11;
                     enemy3_data12 = enemy1_data12;
                     enemy3_data13 = enemy1_data13;
                     enemy3_data14 = enemy1_data14;
                     enemy3_data15 = enemy1_data15;
                     enemy3_data16 = enemy1_data16;
                     enemy3_data17 = enemy1_data17;
                     enemy3_data18 = enemy1_data18;
                     enemy3_data19 = enemy1_data19;
                     enemy3_data20 = enemy1_data20;
                     enemy3_data21 = enemy1_data21;
                     enemy3_data22 = enemy1_data22;
                     enemy3_data23 = enemy1_data23;
                     enemy3_data24 = enemy1_data24;
                     enemy3_data25 = enemy1_data25;
                     enemy3_data26 = enemy1_data26;
                     enemy3_data27 = enemy1_data27;
                     enemy3_data28 = enemy1_data28;
                     enemy3_data29 = enemy1_data29;
                     enemy3_data30 = enemy1_data30;
                     enemy3_data31 = enemy1_data31;
                     enemy3_data32 = enemy1_data32;
                     enemy3_data33 = enemy1_data33;
                     enemy3_data34 = enemy1_data34;
                     enemy3_data35 = enemy1_data35;
                     enemy3_data36 = enemy1_data36;
                     enemy3_data37 = enemy1_data37;
                     enemy3_data38 = enemy1_data38;
                     enemy3_data39 = enemy1_data39;
                     enemy3_data40 = enemy1_data40;
                     enemy3_data41 = enemy1_data41;
                     enemy3_data42 = enemy1_data42;


                     enemy4ID = enemy2ID;
                     enemy4_data1 = enemy2_data1;
                     enemy4_data2 = enemy2_data2;
                     enemy4_data3 = enemy2_data3;
                     enemy4_data4 = enemy2_data4;
                     enemy4_data5 = enemy2_data5;
                     enemy4_data6 = enemy2_data6;
                     enemy4_data7 = enemy2_data7;
                     enemy4_data8 = enemy2_data8;
                     enemy4_data9 = enemy2_data9;
                     enemy4_data10 = enemy2_data10;
                     enemy4_data11 = enemy2_data11;
                     enemy4_data12 = enemy2_data12;
                     enemy4_data13 = enemy2_data13;
                     enemy4_data14 = enemy2_data14;
                     enemy4_data15 = enemy2_data15;
                     enemy4_data16 = enemy2_data16;
                     enemy4_data17 = enemy2_data17;
                     enemy4_data18 = enemy2_data18;
                     enemy4_data19 = enemy2_data19;
                     enemy4_data20 = enemy2_data20;
                     enemy4_data21 = enemy2_data21;
                     enemy4_data22 = enemy2_data22;
                     enemy4_data23 = enemy2_data23;
                     enemy4_data24 = enemy2_data24;
                     enemy4_data25 = enemy2_data25;
                     enemy4_data26 = enemy2_data26;
                     enemy4_data27 = enemy2_data27;
                     enemy4_data28 = enemy2_data28;
                     enemy4_data29 = enemy2_data29;
                     enemy4_data30 = enemy2_data30;
                     enemy4_data31 = enemy2_data31;
                     enemy4_data32 = enemy2_data32;
                     enemy4_data33 = enemy2_data33;
                     enemy4_data34 = enemy2_data34;
                     enemy4_data35 = enemy2_data35;
                     enemy4_data36 = enemy2_data36;
                     enemy4_data37 = enemy2_data37;
                     enemy4_data38 = enemy2_data38;
                     enemy4_data39 = enemy2_data39;
                     enemy4_data40 = enemy2_data40;
                     enemy4_data41 = enemy2_data41;
                     enemy4_data42 = enemy2_data42;


                     enemy5ID = enemy1ID;
                     enemy5_data1 = enemy1_data1;
                     enemy5_data2 = enemy1_data2;
                     enemy5_data3 = enemy1_data3;
                     enemy5_data4 = enemy1_data4;
                     enemy5_data5 = enemy1_data5;
                     enemy5_data6 = enemy1_data6;
                     enemy5_data7 = enemy1_data7;
                     enemy5_data8 = enemy1_data8;
                     enemy5_data9 = enemy1_data9;
                     enemy5_data10 = enemy1_data10;
                     enemy5_data11 = enemy1_data11;
                     enemy5_data12 = enemy1_data12;
                     enemy5_data13 = enemy1_data13;
                     enemy5_data14 = enemy1_data14;
                     enemy5_data15 = enemy1_data15;
                     enemy5_data16 = enemy1_data16;
                     enemy5_data17 = enemy1_data17;
                     enemy5_data18 = enemy1_data18;
                     enemy5_data19 = enemy1_data19;
                     enemy5_data20 = enemy1_data20;
                     enemy5_data21 = enemy1_data21;
                     enemy5_data22 = enemy1_data22;
                     enemy5_data23 = enemy1_data23;
                     enemy5_data24 = enemy1_data24;
                     enemy5_data25 = enemy1_data25;
                     enemy5_data26 = enemy1_data26;
                     enemy5_data27 = enemy1_data27;
                     enemy5_data28 = enemy1_data28;
                     enemy5_data29 = enemy1_data29;
                     enemy5_data30 = enemy1_data30;
                     enemy5_data31 = enemy1_data31;
                     enemy5_data32 = enemy1_data32;
                     enemy5_data33 = enemy1_data33;
                     enemy5_data34 = enemy1_data34;
                     enemy5_data35 = enemy1_data35;
                     enemy5_data36 = enemy1_data36;
                     enemy5_data37 = enemy1_data37;
                     enemy5_data38 = enemy1_data38;
                     enemy5_data39 = enemy1_data39;
                     enemy5_data40 = enemy1_data40;
                     enemy5_data41 = enemy1_data41;
                     enemy5_data42 = enemy1_data42;


                     enemy6ID = enemy2ID;
                     enemy6_data1 = enemy2_data1;
                     enemy6_data2 = enemy2_data2;
                     enemy6_data3 = enemy2_data3;
                     enemy6_data4 = enemy2_data4;
                     enemy6_data5 = enemy2_data5;
                     enemy6_data6 = enemy2_data6;
                     enemy6_data7 = enemy2_data7;
                     enemy6_data8 = enemy2_data8;
                     enemy6_data9 = enemy2_data9;
                     enemy6_data10 = enemy2_data10;
                     enemy6_data11 = enemy2_data11;
                     enemy6_data12 = enemy2_data12;
                     enemy6_data13 = enemy2_data13;
                     enemy6_data14 = enemy2_data14;
                     enemy6_data15 = enemy2_data15;
                     enemy6_data16 = enemy2_data16;
                     enemy6_data17 = enemy2_data17;
                     enemy6_data18 = enemy2_data18;
                     enemy6_data19 = enemy2_data19;
                     enemy6_data20 = enemy2_data20;
                     enemy6_data21 = enemy2_data21;
                     enemy6_data22 = enemy2_data22;
                     enemy6_data23 = enemy2_data23;
                     enemy6_data24 = enemy2_data24;
                     enemy6_data25 = enemy2_data25;
                     enemy6_data26 = enemy2_data26;
                     enemy6_data27 = enemy2_data27;
                     enemy6_data28 = enemy2_data28;
                     enemy6_data29 = enemy2_data29;
                     enemy6_data30 = enemy2_data30;
                     enemy6_data31 = enemy2_data31;
                     enemy6_data32 = enemy2_data32;
                     enemy6_data33 = enemy2_data33;
                     enemy6_data34 = enemy2_data34;
                     enemy6_data35 = enemy2_data35;
                     enemy6_data36 = enemy2_data36;
                     enemy6_data37 = enemy2_data37;
                     enemy6_data38 = enemy2_data38;
                     enemy6_data39 = enemy2_data39;
                     enemy6_data40 = enemy2_data40;
                     enemy6_data41 = enemy2_data41;
                     enemy6_data42 = enemy2_data42;

                }
                else if (enemy4ID == "")
                {

                     enemy4ID = enemy1ID;
                     enemy4_data1 = enemy1_data1;
                     enemy4_data2 = enemy1_data2;
                     enemy4_data3 = enemy1_data3;
                     enemy4_data4 = enemy1_data4;
                     enemy4_data5 = enemy1_data5;
                     enemy4_data6 = enemy1_data6;
                     enemy4_data7 = enemy1_data7;
                     enemy4_data8 = enemy1_data8;
                     enemy4_data9 = enemy1_data9;
                     enemy4_data10 = enemy1_data10;
                     enemy4_data11 = enemy1_data11;
                     enemy4_data12 = enemy1_data12;
                     enemy4_data13 = enemy1_data13;
                     enemy4_data14 = enemy1_data14;
                     enemy4_data15 = enemy1_data15;
                     enemy4_data16 = enemy1_data16;
                     enemy4_data17 = enemy1_data17;
                     enemy4_data18 = enemy1_data18;
                     enemy4_data19 = enemy1_data19;
                     enemy4_data20 = enemy1_data20;
                     enemy4_data21 = enemy1_data21;
                     enemy4_data22 = enemy1_data22;
                     enemy4_data23 = enemy1_data23;
                     enemy4_data24 = enemy1_data24;
                     enemy4_data25 = enemy1_data25;
                     enemy4_data26 = enemy1_data26;
                     enemy4_data27 = enemy1_data27;
                     enemy4_data28 = enemy1_data28;
                     enemy4_data29 = enemy1_data29;
                     enemy4_data30 = enemy1_data30;
                     enemy4_data31 = enemy1_data31;
                     enemy4_data32 = enemy1_data32;
                     enemy4_data33 = enemy1_data33;
                     enemy4_data34 = enemy1_data34;
                     enemy4_data35 = enemy1_data35;
                     enemy4_data36 = enemy1_data36;
                     enemy4_data37 = enemy1_data37;
                     enemy4_data38 = enemy1_data38;
                     enemy4_data39 = enemy1_data39;
                     enemy4_data40 = enemy1_data40;
                     enemy4_data41 = enemy1_data41;
                     enemy4_data42 = enemy1_data42;


                     enemy5ID = enemy2ID;
                     enemy5_data1 = enemy2_data1;
                     enemy5_data2 = enemy2_data2;
                     enemy5_data3 = enemy2_data3;
                     enemy5_data4 = enemy2_data4;
                     enemy5_data5 = enemy2_data5;
                     enemy5_data6 = enemy2_data6;
                     enemy5_data7 = enemy2_data7;
                     enemy5_data8 = enemy2_data8;
                     enemy5_data9 = enemy2_data9;
                     enemy5_data10 = enemy2_data10;
                     enemy5_data11 = enemy2_data11;
                     enemy5_data12 = enemy2_data12;
                     enemy5_data13 = enemy2_data13;
                     enemy5_data14 = enemy2_data14;
                     enemy5_data15 = enemy2_data15;
                     enemy5_data16 = enemy2_data16;
                     enemy5_data17 = enemy2_data17;
                     enemy5_data18 = enemy2_data18;
                     enemy5_data19 = enemy2_data19;
                     enemy5_data20 = enemy2_data20;
                     enemy5_data21 = enemy2_data21;
                     enemy5_data22 = enemy2_data22;
                     enemy5_data23 = enemy2_data23;
                     enemy5_data24 = enemy2_data24;
                     enemy5_data25 = enemy2_data25;
                     enemy5_data26 = enemy2_data26;
                     enemy5_data27 = enemy2_data27;
                     enemy5_data28 = enemy2_data28;
                     enemy5_data29 = enemy2_data29;
                     enemy5_data30 = enemy2_data30;
                     enemy5_data31 = enemy2_data31;
                     enemy5_data32 = enemy2_data32;
                     enemy5_data33 = enemy2_data33;
                     enemy5_data34 = enemy2_data34;
                     enemy5_data35 = enemy2_data35;
                     enemy5_data36 = enemy2_data36;
                     enemy5_data37 = enemy2_data37;
                     enemy5_data38 = enemy2_data38;
                     enemy5_data39 = enemy2_data39;
                     enemy5_data40 = enemy2_data40;
                     enemy5_data41 = enemy2_data41;
                     enemy5_data42 = enemy2_data42;


                     enemy6ID = enemy3ID;
                     enemy6_data1 = enemy3_data1;
                     enemy6_data2 = enemy3_data2;
                     enemy6_data3 = enemy3_data3;
                     enemy6_data4 = enemy3_data4;
                     enemy6_data5 = enemy3_data5;
                     enemy6_data6 = enemy3_data6;
                     enemy6_data7 = enemy3_data7;
                     enemy6_data8 = enemy3_data8;
                     enemy6_data9 = enemy3_data9;
                     enemy6_data10 = enemy3_data10;
                     enemy6_data11 = enemy3_data11;
                     enemy6_data12 = enemy3_data12;
                     enemy6_data13 = enemy3_data13;
                     enemy6_data14 = enemy3_data14;
                     enemy6_data15 = enemy3_data15;
                     enemy6_data16 = enemy3_data16;
                     enemy6_data17 = enemy3_data17;
                     enemy6_data18 = enemy3_data18;
                     enemy6_data19 = enemy3_data19;
                     enemy6_data20 = enemy3_data20;
                     enemy6_data21 = enemy3_data21;
                     enemy6_data22 = enemy3_data22;
                     enemy6_data23 = enemy3_data23;
                     enemy6_data24 = enemy3_data24;
                     enemy6_data25 = enemy3_data25;
                     enemy6_data26 = enemy3_data26;
                     enemy6_data27 = enemy3_data27;
                     enemy6_data28 = enemy3_data28;
                     enemy6_data29 = enemy3_data29;
                     enemy6_data30 = enemy3_data30;
                     enemy6_data31 = enemy3_data31;
                     enemy6_data32 = enemy3_data32;
                     enemy6_data33 = enemy3_data33;
                     enemy6_data34 = enemy3_data34;
                     enemy6_data35 = enemy3_data35;
                     enemy6_data36 = enemy3_data36;
                     enemy6_data37 = enemy3_data37;
                     enemy6_data38 = enemy3_data38;
                     enemy6_data39 = enemy3_data39;
                     enemy6_data40 = enemy3_data40;
                     enemy6_data41 = enemy3_data41;
                     enemy6_data42 = enemy3_data42;

                }
                else if (enemy5ID == "")
                {

                     enemy5ID = enemy1ID;
                     enemy5_data1 = enemy1_data1;
                     enemy5_data2 = enemy1_data2;
                     enemy5_data3 = enemy1_data3;
                     enemy5_data4 = enemy1_data4;
                     enemy5_data5 = enemy1_data5;
                     enemy5_data6 = enemy1_data6;
                     enemy5_data7 = enemy1_data7;
                     enemy5_data8 = enemy1_data8;
                     enemy5_data9 = enemy1_data9;
                     enemy5_data10 = enemy1_data10;
                     enemy5_data11 = enemy1_data11;
                     enemy5_data12 = enemy1_data12;
                     enemy5_data13 = enemy1_data13;
                     enemy5_data14 = enemy1_data14;
                     enemy5_data15 = enemy1_data15;
                     enemy5_data16 = enemy1_data16;
                     enemy5_data17 = enemy1_data17;
                     enemy5_data18 = enemy1_data18;
                     enemy5_data19 = enemy1_data19;
                     enemy5_data20 = enemy1_data20;
                     enemy5_data21 = enemy1_data21;
                     enemy5_data22 = enemy1_data22;
                     enemy5_data23 = enemy1_data23;
                     enemy5_data24 = enemy1_data24;
                     enemy5_data25 = enemy1_data25;
                     enemy5_data26 = enemy1_data26;
                     enemy5_data27 = enemy1_data27;
                     enemy5_data28 = enemy1_data28;
                     enemy5_data29 = enemy1_data29;
                     enemy5_data30 = enemy1_data30;
                     enemy5_data31 = enemy1_data31;
                     enemy5_data32 = enemy1_data32;
                     enemy5_data33 = enemy1_data33;
                     enemy5_data34 = enemy1_data34;
                     enemy5_data35 = enemy1_data35;
                     enemy5_data36 = enemy1_data36;
                     enemy5_data37 = enemy1_data37;
                     enemy5_data38 = enemy1_data38;
                     enemy5_data39 = enemy1_data39;
                     enemy5_data40 = enemy1_data40;
                     enemy5_data41 = enemy1_data41;
                     enemy5_data42 = enemy1_data42;


                     enemy6ID = enemy2ID;
                     enemy6_data1 = enemy2_data1;
                     enemy6_data2 = enemy2_data2;
                     enemy6_data3 = enemy2_data3;
                     enemy6_data4 = enemy2_data4;
                     enemy6_data5 = enemy2_data5;
                     enemy6_data6 = enemy2_data6;
                     enemy6_data7 = enemy2_data7;
                     enemy6_data8 = enemy2_data8;
                     enemy6_data9 = enemy2_data9;
                     enemy6_data10 = enemy2_data10;
                     enemy6_data11 = enemy2_data11;
                     enemy6_data12 = enemy2_data12;
                     enemy6_data13 = enemy2_data13;
                     enemy6_data14 = enemy2_data14;
                     enemy6_data15 = enemy2_data15;
                     enemy6_data16 = enemy2_data16;
                     enemy6_data17 = enemy2_data17;
                     enemy6_data18 = enemy2_data18;
                     enemy6_data19 = enemy2_data19;
                     enemy6_data20 = enemy2_data20;
                     enemy6_data21 = enemy2_data21;
                     enemy6_data22 = enemy2_data22;
                     enemy6_data23 = enemy2_data23;
                     enemy6_data24 = enemy2_data24;
                     enemy6_data25 = enemy2_data25;
                     enemy6_data26 = enemy2_data26;
                     enemy6_data27 = enemy2_data27;
                     enemy6_data28 = enemy2_data28;
                     enemy6_data29 = enemy2_data29;
                     enemy6_data30 = enemy2_data30;
                     enemy6_data31 = enemy2_data31;
                     enemy6_data32 = enemy2_data32;
                     enemy6_data33 = enemy2_data33;
                     enemy6_data34 = enemy2_data34;
                     enemy6_data35 = enemy2_data35;
                     enemy6_data36 = enemy2_data36;
                     enemy6_data37 = enemy2_data37;
                     enemy6_data38 = enemy2_data38;
                     enemy6_data39 = enemy2_data39;
                     enemy6_data40 = enemy2_data40;
                     enemy6_data41 = enemy2_data41;
                     enemy6_data42 = enemy2_data42;

                }
                else if (enemy6ID == "")
                {

                    enemy6ID = enemy1ID;
                    enemy6_data1 = enemy1_data1;
                    enemy6_data2 = enemy1_data2;
                    enemy6_data3 = enemy1_data3;
                    enemy6_data4 = enemy1_data4;
                    enemy6_data5 = enemy1_data5;
                    enemy6_data6 = enemy1_data6;
                    enemy6_data7 = enemy1_data7;
                    enemy6_data8 = enemy1_data8;
                    enemy6_data9 = enemy1_data9;
                    enemy6_data10 = enemy1_data10;
                    enemy6_data11 = enemy1_data11;
                    enemy6_data12 = enemy1_data12;
                    enemy6_data13 = enemy1_data13;
                    enemy6_data14 = enemy1_data14;
                    enemy6_data15 = enemy1_data15;
                    enemy6_data16 = enemy1_data16;
                    enemy6_data17 = enemy1_data17;
                    enemy6_data18 = enemy1_data18;
                    enemy6_data19 = enemy1_data19;
                    enemy6_data20 = enemy1_data20;
                    enemy6_data21 = enemy1_data21;
                    enemy6_data22 = enemy1_data22;
                    enemy6_data23 = enemy1_data23;
                    enemy6_data24 = enemy1_data24;
                    enemy6_data25 = enemy1_data25;
                    enemy6_data26 = enemy1_data26;
                    enemy6_data27 = enemy1_data27;
                    enemy6_data28 = enemy1_data28;
                    enemy6_data29 = enemy1_data29;
                    enemy6_data30 = enemy1_data30;
                    enemy6_data31 = enemy1_data31;
                    enemy6_data32 = enemy1_data32;
                    enemy6_data33 = enemy1_data33;
                    enemy6_data34 = enemy1_data34;
                    enemy6_data35 = enemy1_data35;
                    enemy6_data36 = enemy1_data36;
                    enemy6_data37 = enemy1_data37;
                    enemy6_data38 = enemy1_data38;
                    enemy6_data39 = enemy1_data39;
                    enemy6_data40 = enemy1_data40;
                    enemy6_data41 = enemy1_data41;
                    enemy6_data42 = enemy1_data42;

                }
            }

            if (missionNumber == 4)//reduce some textures by swaping enemies
            {
                enemy6ID = enemy2ID;
                enemy6_data1 = enemy2_data1;
                enemy6_data2 = enemy2_data2;
                enemy6_data3 = enemy2_data3;
                enemy6_data4 = enemy2_data4;
                enemy6_data5 = enemy2_data5;
                enemy6_data6 = enemy2_data6;
                enemy6_data7 = enemy2_data7;
                enemy6_data8 = enemy2_data8;
                enemy6_data9 = enemy2_data9;
                enemy6_data10 = enemy2_data10;
                enemy6_data11 = enemy2_data11;
                enemy6_data12 = enemy2_data12;
                enemy6_data13 = enemy2_data13;
                enemy6_data14 = enemy2_data14;
                enemy6_data15 = enemy2_data15;
                enemy6_data16 = enemy2_data16;
                enemy6_data17 = enemy2_data17;
                enemy6_data18 = enemy2_data18;
                enemy6_data19 = enemy2_data19;
                enemy6_data20 = enemy2_data20;
                enemy6_data21 = enemy2_data21;
                enemy6_data22 = enemy2_data22;
                enemy6_data23 = enemy2_data23;
                enemy6_data24 = enemy2_data24;
                enemy6_data25 = enemy2_data25;
                enemy6_data26 = enemy2_data26;
                enemy6_data27 = enemy2_data27;
                enemy6_data28 = enemy2_data28;
                enemy6_data29 = enemy2_data29;
                enemy6_data30 = enemy2_data30;
                enemy6_data31 = enemy2_data31;
                enemy6_data32 = enemy2_data32;
                enemy6_data33 = enemy2_data33;
                enemy6_data34 = enemy2_data34;
                enemy6_data35 = enemy2_data35;
                enemy6_data36 = enemy2_data36;
                enemy6_data37 = enemy2_data37;
                enemy6_data38 = enemy2_data38;
                enemy6_data39 = enemy2_data39;
                enemy6_data40 = enemy2_data40;
                enemy6_data41 = enemy2_data41;
                enemy6_data42 = enemy2_data42;
            }
            if (missionNumber == 9)
            {
                enemy5ID = enemy1ID;
                enemy5_data1 = enemy1_data1;
                enemy5_data2 = enemy1_data2;
                enemy5_data3 = enemy1_data3;
                enemy5_data4 = enemy1_data4;
                enemy5_data5 = enemy1_data5;
                enemy5_data6 = enemy1_data6;
                enemy5_data7 = enemy1_data7;
                enemy5_data8 = enemy1_data8;
                enemy5_data9 = enemy1_data9;
                enemy5_data10 = enemy1_data10;
                enemy5_data11 = enemy1_data11;
                enemy5_data12 = enemy1_data12;
                enemy5_data13 = enemy1_data13;
                enemy5_data14 = enemy1_data14;
                enemy5_data15 = enemy1_data15;
                enemy5_data16 = enemy1_data16;
                enemy5_data17 = enemy1_data17;
                enemy5_data18 = enemy1_data18;
                enemy5_data19 = enemy1_data19;
                enemy5_data20 = enemy1_data20;
                enemy5_data21 = enemy1_data21;
                enemy5_data22 = enemy1_data22;
                enemy5_data23 = enemy1_data23;
                enemy5_data24 = enemy1_data24;
                enemy5_data25 = enemy1_data25;
                enemy5_data26 = enemy1_data26;
                enemy5_data27 = enemy1_data27;
                enemy5_data28 = enemy1_data28;
                enemy5_data29 = enemy1_data29;
                enemy5_data30 = enemy1_data30;
                enemy5_data31 = enemy1_data31;
                enemy5_data32 = enemy1_data32;
                enemy5_data33 = enemy1_data33;
                enemy5_data34 = enemy1_data34;
                enemy5_data35 = enemy1_data35;
                enemy5_data36 = enemy1_data36;
                enemy5_data37 = enemy1_data37;
                enemy5_data38 = enemy1_data38;
                enemy5_data39 = enemy1_data39;
                enemy5_data40 = enemy1_data40;
                enemy5_data41 = enemy1_data41;
                enemy5_data42 = enemy1_data42;
            }
            #endregion

            string missionObjective = "0000";
            string missionTimer = "0000";
            string allowPartnerDeath = "0000";

            string noPosChange = "//";
            string bulletHellCodes = "";
            string customStats = "//";

            if (missionNumber == 101)
            {
                missionObjective = "0001";
                missionTimer = "005A";
                allowPartnerDeath = "0001";

                enemy6ID = "00000009";
                enemy6_data9 = "002D0000";
                enemy6_data10 = "00000000";
                enemy6_data11 = "00290009";

                enemy1_data2 = "FFFFF372";
                enemy1_data3 = "FFFFFFAF";
                enemy3_data2 = "FFFFFA72";
                enemy3_data3 = "FFFFF7AF";
                enemy3_data4 = "00009BBC";
                enemy4_data2 = "FFFFF939";
                enemy4_data3 = "FFFFEB48";
                enemy6_data2 = "FFFFEC39";
                enemy6_data3 = "FFFFF248";
                enemy6_data4 = "00004BBC";
            }
            if (missionNumber == 117)
            {
                player2posA = "0000386E";
                enemy6ID = "00000008";
                enemy6_data2 = "00002658";
            }
            if (missionNumber == 178)
            {
                missionObjective = "0001";
                missionTimer = "007A";
                allowPartnerDeath = "0001";
                EnemiesNumber = 1;
                customStats =
                "patch=1,EE,105B8EB8,extended,07D0//STK" + Environment.NewLine +
                "patch=1,EE,105B8EBA,extended,07D0//GRP" + Environment.NewLine +
                "patch=1,EE,105B8EBC,extended,07D0//RGA" + Environment.NewLine +
                "patch=1,EE,105B8EBE,extended,07D0//SPA" + Environment.NewLine +
                "patch=1,EE,105B8EC2,extended,1388//TGH" + Environment.NewLine +
                "patch=1,EE,205B8EB4,extended,44DF8000//Infinite Spa Down" + Environment.NewLine +
                "patch=1,EE,D0A5E3D4,extended,0001//if timer reaches 1 P3 is defeated" + Environment.NewLine +
                "patch=1,EE,105B8E68,extended,0000//P3 HP";
            }
            if (missionNumber == 199)
            {
                enemy1_data3 = "FFFFEE18";
                enemy2_data3 = "FFFFF318";
                enemy3_data3 = "FFFFF718";
                enemy4_data3 = "FFFFFB18";
                enemy5_data3 = "FFFFFF18";
                enemy6_data3 = "FFFFF718";
                enemy6_data7 = "00000016";
                enemy6_data9 = "00040000";
                enemy6_data10 = "00040004";
                enemy6_data11 = "00040004";
            }
            if (missionNumber == 200)
            {
                enemy1_data3 = "FFFFEA92";
                enemy2_data3 = "FFFFEF92";
                enemy3_data3 = "FFFFF392";
                enemy4_data3 = "FFFFF792";
                enemy5_data3 = "FFFFFA92";
                enemy6_data3 = "FFFFFF92";

                enemy1_data7 = "0000000F";
                enemy1_data9 = "00240000";
                enemy1_data10 = "00340027";
                enemy1_data11 = "000C0034";

                enemy3_data7 = "0000000F";
                enemy3_data9 = "00240000";
                enemy3_data10 = "00340027";
                enemy3_data11 = "000C0034";

                enemy5_data7 = "0000000F";
                enemy5_data9 = "00240000";
                enemy5_data10 = "00340027";
                enemy5_data11 = "000C0034";
            }
            if (missionNumber == 300)
            {
                enemy1ID = "00000035";
                enemy1_data7 = "0000000F";
                enemy1_data9 = "00240000";
                enemy1_data10 = "00340027";
                enemy1_data11 = "00340034";
                enemy2ID = "0000002D";
                enemy2_data7 = "00000019";
                enemy2_data9 = "00370000";
                enemy2_data10 = "00370037";
                enemy2_data11 = "00370037";
                enemy3ID = "0000002C";
                enemy3_data7 = "0000000A";
                enemy3_data9 = "00360000";
                enemy3_data10 = "00360036";
                enemy3_data11 = "00360036";
                enemy4ID = "00000036";
                enemy4_data7 = "00000005";
                enemy4_data9 = "002F0000";
                enemy4_data10 = "002F002F";
                enemy4_data11 = "002F002F";
                enemy5ID = "0000002B";
                enemy5_data7 = "00000013";
                enemy5_data9 = "002F0000";
                enemy5_data10 = "002F002F";
                enemy5_data11 = "00300030";
                enemy6ID = "0000003D";
                enemy6_data7 = "00000016";
                enemy6_data9 = "00040000";
                enemy6_data10 = "00040004";
                enemy6_data11 = "00040004";
                noPosChange = "";
            }
            if (missionNumber == 400)
            {
                bulletHellCodes = " " + Environment.NewLine +
                    "patch=1,EE,1027E484,extended,00000000// infinite ammo" + Environment.NewLine +
                    "patch=1,EE,1027E488,extended,00000000// infinite ammo" + Environment.NewLine +
                    "patch=1,EE,1057A1F6,extended,059F// Get up atk" + Environment.NewLine +
                    "patch=1,EE,1057A1F8,extended,05A1// Get up atk" + Environment.NewLine +
                    "patch=1,EE,1058A922,extended,04F0// Punch gun" + Environment.NewLine +
                    "patch=1,EE,1058A924,extended,04F0// Punch gun" + Environment.NewLine +
                    "patch=1,EE,1058A926,extended,04F0// Punch gun" + Environment.NewLine +
                    "";
            }

            //if (Player2Camera)
            //{
            //    ///ADD CAMERA CODE HERE THEN PASS IT TO missionData STRING
            //}

            string weapons = "0001";
            if (!WeaponsOn)
            {
                weapons = "0000";
            }
            if (!WeaponsEnemyOn)
            {
                enemy1_data7 = enemy1_data7.Substring(0, 6) + "00";
                enemy2_data7 = enemy2_data7.Substring(0, 6) + "00";
                enemy3_data7 = enemy3_data7.Substring(0, 6) + "00";
                enemy4_data7 = enemy4_data7.Substring(0, 6) + "00";
                enemy5_data7 = enemy5_data7.Substring(0, 6) + "00";
                enemy6_data7 = enemy6_data7.Substring(0, 6) + "00";
            }

            switch (enemyAI)
            {
                case 1:
                    enemy1_data11 = "0004" + enemy1_data11.Substring(4);
                    enemy2_data11 = "0004" + enemy1_data11.Substring(4);
                    enemy3_data11 = "0004" + enemy1_data11.Substring(4);
                    enemy4_data11 = "0004" + enemy1_data11.Substring(4);
                    enemy5_data11 = "0004" + enemy1_data11.Substring(4);
                    enemy6_data11 = "0004" + enemy1_data11.Substring(4);
                    break;
                case 2:
                    enemy1_data11 = "0011" + enemy1_data11.Substring(4);
                    enemy2_data11 = "0011" + enemy1_data11.Substring(4);
                    enemy3_data11 = "0011" + enemy1_data11.Substring(4);
                    enemy4_data11 = "0011" + enemy1_data11.Substring(4);
                    enemy5_data11 = "0011" + enemy1_data11.Substring(4);
                    enemy6_data11 = "0011" + enemy1_data11.Substring(4);
                    break;
                case 3:
                    enemy1_data11 = "000C" + enemy1_data11.Substring(4);
                    enemy2_data11 = "000C" + enemy1_data11.Substring(4);
                    enemy3_data11 = "000C" + enemy1_data11.Substring(4);
                    enemy4_data11 = "000C" + enemy1_data11.Substring(4);
                    enemy5_data11 = "000C" + enemy1_data11.Substring(4);
                    enemy6_data11 = "000C" + enemy1_data11.Substring(4);
                    break;
            }


            string cameraCode = "";
            if (MultiplayerCamera)
            {
                cameraCode = "patch=1,EE,10ABFA74,extended,0001 //partner is controller by player 2";
            }
            else
            {
                cameraCode = "patch=1,EE,10ABFA74,extended,0000 //partner is controller by AI";
            }

            string enemiesData = "";

            if (missionNumber != 0)
            {
                enemiesData =
                              noPosChange + "patch=1,EE,205B88F0,extended,3F900000 //player 3 y-pos" + Environment.NewLine +
                              noPosChange + "patch=1,EE,205C2040,extended,3F900000 //player 3 y-pos" + Environment.NewLine +
                              noPosChange + "patch=1,EE,205CB790,extended,3F900000 //player 3 y-pos" + Environment.NewLine +
                              noPosChange + "patch=1,EE,205D4EE0,extended,3F900000 //player 3 y-pos" + Environment.NewLine +
                              noPosChange + "patch=1,EE,205DE630,extended,3F900000 //player 3 y-pos" + Environment.NewLine +
                              noPosChange + "patch=1,EE,205E7D80,extended,3F900000 //player 3 y-pos" + Environment.NewLine +

                              "" + Environment.NewLine +
                              "patch=1,EE,21DA8654,extended," + enemy1ID + "//1st id" + Environment.NewLine +
                              "patch=1,EE,21DA8658,extended," + enemy1_data1 + "//1st code" + Environment.NewLine +
                              "patch=1,EE,21DA865C,extended," + enemy1_data2 + "//1st code" + Environment.NewLine +
                              "patch=1,EE,21DA8660,extended," + enemy1_data3 + "//1st code" + Environment.NewLine +
                              "patch=1,EE,21DA8664,extended," + enemy1_data4 + "//1st code" + Environment.NewLine +
                              "patch=1,EE,21DA8668,extended," + enemy1_data5 + "//1st code" + Environment.NewLine +
                              "patch=1,EE,21DA866C,extended," + enemy1_data6 + "//1st code" + Environment.NewLine +
                              "patch=1,EE,21DA8670,extended," + enemy1_data7 + "//1st code" + Environment.NewLine +
                              "patch=1,EE,21DA8674,extended," + enemy1_data8 + "//1st code" + Environment.NewLine +
                              "patch=1,EE,21DA8678,extended," + enemy1_data9 + "//1st code" + Environment.NewLine +
                              "patch=1,EE,21DA867C,extended," + enemy1_data10 + "//1st code" + Environment.NewLine +
                              "patch=1,EE,21DA8680,extended," + enemy1_data11 + "//1st code" + Environment.NewLine +
                              "patch=1,EE,21DA8684,extended," + enemy1_data12 + "//1st code" + Environment.NewLine +
                              "patch=1,EE,21DA8688,extended," + enemy1_data13 + "//1st code" + Environment.NewLine +
                              "patch=1,EE,21DA868C,extended," + enemy1_data14 + "//1st code" + Environment.NewLine +
                              "patch=1,EE,21DA8690,extended," + enemy1_data15 + "//1st code" + Environment.NewLine +
                              "patch=1,EE,21DA8694,extended," + enemy1_data16 + "//1st code" + Environment.NewLine +
                              "patch=1,EE,21DA8698,extended," + enemy1_data17 + "//1st code" + Environment.NewLine +
                              "patch=1,EE,21DA869C,extended," + enemy1_data18 + "//1st code" + Environment.NewLine +
                              "patch=1,EE,21DA86A0,extended," + enemy1_data19 + "//1st code" + Environment.NewLine +
                              "patch=1,EE,21DA86A4,extended," + enemy1_data20 + "//1st code" + Environment.NewLine +
                              "patch=1,EE,21DA86A8,extended," + enemy1_data21 + "//1st code" + Environment.NewLine +
                              "patch=1,EE,21DA86AC,extended," + enemy1_data22 + "//1st code" + Environment.NewLine +
                              "patch=1,EE,21DA86B0,extended," + enemy1_data23 + "//1st code" + Environment.NewLine +
                              "patch=1,EE,21DA86B4,extended," + enemy1_data24 + "//1st code" + Environment.NewLine +
                              "patch=1,EE,21DA86B8,extended," + enemy1_data25 + "//1st code" + Environment.NewLine +
                              "patch=1,EE,21DA86BC,extended," + enemy1_data26 + "//1st code" + Environment.NewLine +
                              "patch=1,EE,21DA86C0,extended," + enemy1_data27 + "//1st code" + Environment.NewLine +
                              "patch=1,EE,21DA86C4,extended," + enemy1_data28 + "//1st code" + Environment.NewLine +
                              "patch=1,EE,21DA86C8,extended," + enemy1_data29 + "//1st code" + Environment.NewLine +
                              "patch=1,EE,21DA86CC,extended," + enemy1_data30 + "//1st code" + Environment.NewLine +
                              "patch=1,EE,21DA86D0,extended," + enemy1_data31 + "//1st code" + Environment.NewLine +
                              "patch=1,EE,21DA86D4,extended," + enemy1_data32 + "//1st code" + Environment.NewLine +
                              "patch=1,EE,21DA86D8,extended," + enemy1_data33 + "//1st code" + Environment.NewLine +
                              "patch=1,EE,21DA86DC,extended," + enemy1_data34 + "//1st code" + Environment.NewLine +
                              "patch=1,EE,21DA86E0,extended," + enemy1_data35 + "//1st code" + Environment.NewLine +
                              "patch=1,EE,21DA86E4,extended," + enemy1_data36 + "//1st code" + Environment.NewLine +
                              "patch=1,EE,21DA86E8,extended," + enemy1_data37 + "//1st code" + Environment.NewLine +
                              "patch=1,EE,21DA86EC,extended," + enemy1_data38 + "//1st code" + Environment.NewLine +
                              "patch=1,EE,21DA86F0,extended," + enemy1_data39 + "//1st code" + Environment.NewLine +
                              "patch=1,EE,21DA86F4,extended," + enemy1_data40 + "//1st code" + Environment.NewLine +
                              "patch=1,EE,21DA86F8,extended," + enemy1_data41 + "//1st code" + Environment.NewLine +
                              "patch=1,EE,21DA86FC,extended," + enemy1_data42 + "//1st code" + Environment.NewLine +

                              "" + Environment.NewLine +
                              "patch=1,EE,21DA8700,extended," + enemy2ID + "//2nd id" + Environment.NewLine +
                              "patch=1,EE,21DA8704,extended," + enemy2_data1 + "//2nd code" + Environment.NewLine +
                              "patch=1,EE,21DA8708,extended," + enemy2_data2 + "//2nd code" + Environment.NewLine +
                              "patch=1,EE,21DA870C,extended," + enemy2_data3 + "//2nd code" + Environment.NewLine +
                              "patch=1,EE,21DA8710,extended," + enemy2_data4 + "//2nd code" + Environment.NewLine +
                              "patch=1,EE,21DA8714,extended," + enemy2_data5 + "//2nd code" + Environment.NewLine +
                              "patch=1,EE,21DA8718,extended," + enemy2_data6 + "//2nd code" + Environment.NewLine +
                              "patch=1,EE,21DA871C,extended," + enemy2_data7 + "//2nd code" + Environment.NewLine +
                              "patch=1,EE,21DA8720,extended," + enemy2_data8 + "//2nd code" + Environment.NewLine +
                              "patch=1,EE,21DA8724,extended," + enemy2_data9 + "//2nd code" + Environment.NewLine +
                              "patch=1,EE,21DA8728,extended," + enemy2_data10 + "//2nd code" + Environment.NewLine +
                              "patch=1,EE,21DA872C,extended," + enemy2_data11 + "//2nd code" + Environment.NewLine +
                              "patch=1,EE,21DA8730,extended," + enemy2_data12 + "//2nd code" + Environment.NewLine +
                              "patch=1,EE,21DA8734,extended," + enemy2_data13 + "//2nd code" + Environment.NewLine +
                              "patch=1,EE,21DA8738,extended," + enemy2_data14 + "//2nd code" + Environment.NewLine +
                              "patch=1,EE,21DA873C,extended," + enemy2_data15 + "//2nd code" + Environment.NewLine +
                              "patch=1,EE,21DA8740,extended," + enemy2_data16 + "//2nd code" + Environment.NewLine +
                              "patch=1,EE,21DA8744,extended," + enemy2_data17 + "//2nd code" + Environment.NewLine +
                              "patch=1,EE,21DA8748,extended," + enemy2_data18 + "//2nd code" + Environment.NewLine +
                              "patch=1,EE,21DA874C,extended," + enemy2_data19 + "//2nd code" + Environment.NewLine +
                              "patch=1,EE,21DA8750,extended," + enemy2_data20 + "//2nd code" + Environment.NewLine +
                              "patch=1,EE,21DA8754,extended," + enemy2_data21 + "//2nd code" + Environment.NewLine +
                              "patch=1,EE,21DA8758,extended," + enemy2_data22 + "//2nd code" + Environment.NewLine +
                              "patch=1,EE,21DA875C,extended," + enemy2_data23 + "//2nd code" + Environment.NewLine +
                              "patch=1,EE,21DA8760,extended," + enemy2_data24 + "//2nd code" + Environment.NewLine +
                              "patch=1,EE,21DA8764,extended," + enemy2_data25 + "//2nd code" + Environment.NewLine +
                              "patch=1,EE,21DA8768,extended," + enemy2_data26 + "//2nd code" + Environment.NewLine +
                              "patch=1,EE,21DA876C,extended," + enemy2_data27 + "//2nd code" + Environment.NewLine +
                              "patch=1,EE,21DA8770,extended," + enemy2_data28 + "//2nd code" + Environment.NewLine +
                              "patch=1,EE,21DA8774,extended," + enemy2_data29 + "//2nd code" + Environment.NewLine +
                              "patch=1,EE,21DA8778,extended," + enemy2_data30 + "//2nd code" + Environment.NewLine +
                              "patch=1,EE,21DA877C,extended," + enemy2_data31 + "//2nd code" + Environment.NewLine +
                              "patch=1,EE,21DA8780,extended," + enemy2_data32 + "//2nd code" + Environment.NewLine +
                              "patch=1,EE,21DA8784,extended," + enemy2_data33 + "//2nd code" + Environment.NewLine +
                              "patch=1,EE,21DA8788,extended," + enemy2_data34 + "//2nd code" + Environment.NewLine +
                              "patch=1,EE,21DA878C,extended," + enemy2_data35 + "//2nd code" + Environment.NewLine +
                              "patch=1,EE,21DA8790,extended," + enemy2_data36 + "//2nd code" + Environment.NewLine +
                              "patch=1,EE,21DA8794,extended," + enemy2_data37 + "//2nd code" + Environment.NewLine +
                              "patch=1,EE,21DA8798,extended," + enemy2_data38 + "//2nd code" + Environment.NewLine +
                              "patch=1,EE,21DA879C,extended," + enemy2_data39 + "//2nd code" + Environment.NewLine +
                              "patch=1,EE,21DA87A0,extended," + enemy2_data40 + "//2nd code" + Environment.NewLine +
                              "patch=1,EE,21DA87A4,extended," + enemy2_data41 + "//2nd code" + Environment.NewLine +
                              "patch=1,EE,21DA87A8,extended," + enemy2_data42 + "//2nd code" + Environment.NewLine +

                              "" + Environment.NewLine +
                              "patch=1,EE,21DA87AC,extended," + enemy3ID + "//3rd id" + Environment.NewLine +
                              "patch=1,EE,21DA87B0,extended," + enemy3_data1 + "//3rd code" + Environment.NewLine +
                              "patch=1,EE,21DA87B4,extended," + enemy3_data2 + "//3rd code" + Environment.NewLine +
                              "patch=1,EE,21DA87B8,extended," + enemy3_data3 + "//3rd code" + Environment.NewLine +
                              "patch=1,EE,21DA87BC,extended," + enemy3_data4 + "//3rd code" + Environment.NewLine +
                              "patch=1,EE,21DA87C0,extended," + enemy3_data5 + "//3rd code" + Environment.NewLine +
                              "patch=1,EE,21DA87C4,extended," + enemy3_data6 + "//3rd code" + Environment.NewLine +
                              "patch=1,EE,21DA87C8,extended," + enemy3_data7 + "//3rd code" + Environment.NewLine +
                              "patch=1,EE,21DA87CC,extended," + enemy3_data8 + "//3rd code" + Environment.NewLine +
                              "patch=1,EE,21DA87D0,extended," + enemy3_data9 + "//3rd code" + Environment.NewLine +
                              "patch=1,EE,21DA87D4,extended," + enemy3_data10 + "//3rd code" + Environment.NewLine +
                              "patch=1,EE,21DA87D8,extended," + enemy3_data11 + "//3rd code" + Environment.NewLine +
                              "patch=1,EE,21DA87DC,extended," + enemy3_data12 + "//3rd code" + Environment.NewLine +
                              "patch=1,EE,21DA87E0,extended," + enemy3_data13 + "//3rd code" + Environment.NewLine +
                              "patch=1,EE,21DA87E4,extended," + enemy3_data14 + "//3rd code" + Environment.NewLine +
                              "patch=1,EE,21DA87E8,extended," + enemy3_data15 + "//3rd code" + Environment.NewLine +
                              "patch=1,EE,21DA87EC,extended," + enemy3_data16 + "//3rd code" + Environment.NewLine +
                              "patch=1,EE,21DA87F0,extended," + enemy3_data17 + "//3rd code" + Environment.NewLine +
                              "patch=1,EE,21DA87F4,extended," + enemy3_data18 + "//3rd code" + Environment.NewLine +
                              "patch=1,EE,21DA87F8,extended," + enemy3_data19 + "//3rd code" + Environment.NewLine +
                              "patch=1,EE,21DA87FC,extended," + enemy3_data20 + "//3rd code" + Environment.NewLine +
                              "patch=1,EE,21DA8800,extended," + enemy3_data21 + "//3rd code" + Environment.NewLine +
                              "patch=1,EE,21DA8804,extended," + enemy3_data22 + "//3rd code" + Environment.NewLine +
                              "patch=1,EE,21DA8808,extended," + enemy3_data23 + "//3rd code" + Environment.NewLine +
                              "patch=1,EE,21DA880C,extended," + enemy3_data24 + "//3rd code" + Environment.NewLine +
                              "patch=1,EE,21DA8810,extended," + enemy3_data25 + "//3rd code" + Environment.NewLine +
                              "patch=1,EE,21DA8814,extended," + enemy3_data26 + "//3rd code" + Environment.NewLine +
                              "patch=1,EE,21DA8818,extended," + enemy3_data27 + "//3rd code" + Environment.NewLine +
                              "patch=1,EE,21DA881C,extended," + enemy3_data28 + "//3rd code" + Environment.NewLine +
                              "patch=1,EE,21DA8820,extended," + enemy3_data29 + "//3rd code" + Environment.NewLine +
                              "patch=1,EE,21DA8824,extended," + enemy3_data30 + "//3rd code" + Environment.NewLine +
                              "patch=1,EE,21DA8828,extended," + enemy3_data31 + "//3rd code" + Environment.NewLine +
                              "patch=1,EE,21DA882C,extended," + enemy3_data32 + "//3rd code" + Environment.NewLine +
                              "patch=1,EE,21DA8830,extended," + enemy3_data33 + "//3rd code" + Environment.NewLine +
                              "patch=1,EE,21DA8834,extended," + enemy3_data34 + "//3rd code" + Environment.NewLine +
                              "patch=1,EE,21DA8838,extended," + enemy3_data35 + "//3rd code" + Environment.NewLine +
                              "patch=1,EE,21DA883C,extended," + enemy3_data36 + "//3rd code" + Environment.NewLine +
                              "patch=1,EE,21DA8840,extended," + enemy3_data37 + "//3rd code" + Environment.NewLine +
                              "patch=1,EE,21DA8844,extended," + enemy3_data38 + "//3rd code" + Environment.NewLine +
                              "patch=1,EE,21DA8848,extended," + enemy3_data39 + "//3rd code" + Environment.NewLine +
                              "patch=1,EE,21DA884C,extended," + enemy3_data40 + "//3rd code" + Environment.NewLine +
                              "patch=1,EE,21DA8850,extended," + enemy3_data41 + "//3rd code" + Environment.NewLine +
                              "patch=1,EE,21DA8854,extended," + enemy3_data42 + "//3rd code" + Environment.NewLine +

                              "" + Environment.NewLine +
                              "patch=1,EE,21DA8858,extended," + enemy4ID + "//4th id" + Environment.NewLine +
                              "patch=1,EE,21DA885C,extended," + enemy4_data1 + "//4th code" + Environment.NewLine +
                              "patch=1,EE,21DA8860,extended," + enemy4_data2 + "//4th code" + Environment.NewLine +
                              "patch=1,EE,21DA8864,extended," + enemy4_data3 + "//4th code" + Environment.NewLine +
                              "patch=1,EE,21DA8868,extended," + enemy4_data4 + "//4th code" + Environment.NewLine +
                              "patch=1,EE,21DA886C,extended," + enemy4_data5 + "//4th code" + Environment.NewLine +
                              "patch=1,EE,21DA8870,extended," + enemy4_data6 + "//4th code" + Environment.NewLine +
                              "patch=1,EE,21DA8874,extended," + enemy4_data7 + "//4th code" + Environment.NewLine +
                              "patch=1,EE,21DA8878,extended," + enemy4_data8 + "//4th code" + Environment.NewLine +
                              "patch=1,EE,21DA887C,extended," + enemy4_data9 + "//4th code" + Environment.NewLine +
                              "patch=1,EE,21DA8880,extended," + enemy4_data10 + "//4th code" + Environment.NewLine +
                              "patch=1,EE,21DA8884,extended," + enemy4_data11 + "//4th code" + Environment.NewLine +
                              "patch=1,EE,21DA8888,extended," + enemy4_data12 + "//4th code" + Environment.NewLine +
                              "patch=1,EE,21DA888C,extended," + enemy4_data13 + "//4th code" + Environment.NewLine +
                              "patch=1,EE,21DA8890,extended," + enemy4_data14 + "//4th code" + Environment.NewLine +
                              "patch=1,EE,21DA8894,extended," + enemy4_data15 + "//4th code" + Environment.NewLine +
                              "patch=1,EE,21DA8898,extended," + enemy4_data16 + "//4th code" + Environment.NewLine +
                              "patch=1,EE,21DA889C,extended," + enemy4_data17 + "//4th code" + Environment.NewLine +
                              "patch=1,EE,21DA88A0,extended," + enemy4_data18 + "//4th code" + Environment.NewLine +
                              "patch=1,EE,21DA88A4,extended," + enemy4_data19 + "//4th code" + Environment.NewLine +
                              "patch=1,EE,21DA88A8,extended," + enemy4_data20 + "//4th code" + Environment.NewLine +
                              "patch=1,EE,21DA88AC,extended," + enemy4_data21 + "//4th code" + Environment.NewLine +
                              "patch=1,EE,21DA88B0,extended," + enemy4_data22 + "//4th code" + Environment.NewLine +
                              "patch=1,EE,21DA88B4,extended," + enemy4_data23 + "//4th code" + Environment.NewLine +
                              "patch=1,EE,21DA88B8,extended," + enemy4_data24 + "//4th code" + Environment.NewLine +
                              "patch=1,EE,21DA88BC,extended," + enemy4_data25 + "//4th code" + Environment.NewLine +
                              "patch=1,EE,21DA88C0,extended," + enemy4_data26 + "//4th code" + Environment.NewLine +
                              "patch=1,EE,21DA88C4,extended," + enemy4_data27 + "//4th code" + Environment.NewLine +
                              "patch=1,EE,21DA88C8,extended," + enemy4_data28 + "//4th code" + Environment.NewLine +
                              "patch=1,EE,21DA88CC,extended," + enemy4_data29 + "//4th code" + Environment.NewLine +
                              "patch=1,EE,21DA88D0,extended," + enemy4_data30 + "//4th code" + Environment.NewLine +
                              "patch=1,EE,21DA88D4,extended," + enemy4_data31 + "//4th code" + Environment.NewLine +
                              "patch=1,EE,21DA88D8,extended," + enemy4_data32 + "//4th code" + Environment.NewLine +
                              "patch=1,EE,21DA88DC,extended," + enemy4_data33 + "//4th code" + Environment.NewLine +
                              "patch=1,EE,21DA88E0,extended," + enemy4_data34 + "//4th code" + Environment.NewLine +
                              "patch=1,EE,21DA88E4,extended," + enemy4_data35 + "//4th code" + Environment.NewLine +
                              "patch=1,EE,21DA88E8,extended," + enemy4_data36 + "//4th code" + Environment.NewLine +
                              "patch=1,EE,21DA88EC,extended," + enemy4_data37 + "//4th code" + Environment.NewLine +
                              "patch=1,EE,21DA88F0,extended," + enemy4_data38 + "//4th code" + Environment.NewLine +
                              "patch=1,EE,21DA88F4,extended," + enemy4_data39 + "//4th code" + Environment.NewLine +
                              "patch=1,EE,21DA88F8,extended," + enemy4_data40 + "//4th code" + Environment.NewLine +
                              "patch=1,EE,21DA88FC,extended," + enemy4_data41 + "//4th code" + Environment.NewLine +
                              "patch=1,EE,21DA8900,extended," + enemy4_data42 + "//4th code" + Environment.NewLine +

                              "" + Environment.NewLine +
                              "patch=1,EE,21DA8904,extended," + enemy5ID + "//5th id" + Environment.NewLine +
                              "patch=1,EE,21DA8908,extended," + enemy5_data1 + "//5th code" + Environment.NewLine +
                              "patch=1,EE,21DA890C,extended," + enemy5_data2 + "//5th code" + Environment.NewLine +
                              "patch=1,EE,21DA8910,extended," + enemy5_data3 + "//5th code" + Environment.NewLine +
                              "patch=1,EE,21DA8914,extended," + enemy5_data4 + "//5th code" + Environment.NewLine +
                              "patch=1,EE,21DA8918,extended," + enemy5_data5 + "//5th code" + Environment.NewLine +
                              "patch=1,EE,21DA891C,extended," + enemy5_data6 + "//5th code" + Environment.NewLine +
                              "patch=1,EE,21DA8920,extended," + enemy5_data7 + "//5th code" + Environment.NewLine +
                              "patch=1,EE,21DA8924,extended," + enemy5_data8 + "//5th code" + Environment.NewLine +
                              "patch=1,EE,21DA8928,extended," + enemy5_data9 + "//5th code" + Environment.NewLine +
                              "patch=1,EE,21DA892C,extended," + enemy5_data10 + "//5th code" + Environment.NewLine +
                              "patch=1,EE,21DA8930,extended," + enemy5_data11 + "//5th code" + Environment.NewLine +
                              "patch=1,EE,21DA8934,extended," + enemy5_data12 + "//5th code" + Environment.NewLine +
                              "patch=1,EE,21DA8938,extended," + enemy5_data13 + "//5th code" + Environment.NewLine +
                              "patch=1,EE,21DA893C,extended," + enemy5_data14 + "//5th code" + Environment.NewLine +
                              "patch=1,EE,21DA8940,extended," + enemy5_data15 + "//5th code" + Environment.NewLine +
                              "patch=1,EE,21DA8944,extended," + enemy5_data16 + "//5th code" + Environment.NewLine +
                              "patch=1,EE,21DA8948,extended," + enemy5_data17 + "//5th code" + Environment.NewLine +
                              "patch=1,EE,21DA894C,extended," + enemy5_data18 + "//5th code" + Environment.NewLine +
                              "patch=1,EE,21DA8950,extended," + enemy5_data19 + "//5th code" + Environment.NewLine +
                              "patch=1,EE,21DA8954,extended," + enemy5_data20 + "//5th code" + Environment.NewLine +
                              "patch=1,EE,21DA8958,extended," + enemy5_data21 + "//5th code" + Environment.NewLine +
                              "patch=1,EE,21DA895C,extended," + enemy5_data22 + "//5th code" + Environment.NewLine +
                              "patch=1,EE,21DA8960,extended," + enemy5_data23 + "//5th code" + Environment.NewLine +
                              "patch=1,EE,21DA8964,extended," + enemy5_data24 + "//5th code" + Environment.NewLine +
                              "patch=1,EE,21DA8968,extended," + enemy5_data25 + "//5th code" + Environment.NewLine +
                              "patch=1,EE,21DA896C,extended," + enemy5_data26 + "//5th code" + Environment.NewLine +
                              "patch=1,EE,21DA8970,extended," + enemy5_data27 + "//5th code" + Environment.NewLine +
                              "patch=1,EE,21DA8974,extended," + enemy5_data28 + "//5th code" + Environment.NewLine +
                              "patch=1,EE,21DA8978,extended," + enemy5_data29 + "//5th code" + Environment.NewLine +
                              "patch=1,EE,21DA897C,extended," + enemy5_data30 + "//5th code" + Environment.NewLine +
                              "patch=1,EE,21DA8980,extended," + enemy5_data31 + "//5th code" + Environment.NewLine +
                              "patch=1,EE,21DA8984,extended," + enemy5_data32 + "//5th code" + Environment.NewLine +
                              "patch=1,EE,21DA8988,extended," + enemy5_data33 + "//5th code" + Environment.NewLine +
                              "patch=1,EE,21DA898C,extended," + enemy5_data34 + "//5th code" + Environment.NewLine +
                              "patch=1,EE,21DA8990,extended," + enemy5_data35 + "//5th code" + Environment.NewLine +
                              "patch=1,EE,21DA8994,extended," + enemy5_data36 + "//5th code" + Environment.NewLine +
                              "patch=1,EE,21DA8998,extended," + enemy5_data37 + "//5th code" + Environment.NewLine +
                              "patch=1,EE,21DA899C,extended," + enemy5_data38 + "//5th code" + Environment.NewLine +
                              "patch=1,EE,21DA89A0,extended," + enemy5_data39 + "//5th code" + Environment.NewLine +
                              "patch=1,EE,21DA89A4,extended," + enemy5_data40 + "//5th code" + Environment.NewLine +
                              "patch=1,EE,21DA89A8,extended," + enemy5_data41 + "//5th code" + Environment.NewLine +
                              "patch=1,EE,21DA89AC,extended," + enemy5_data42 + "//5th code" + Environment.NewLine +

                              "" + Environment.NewLine +
                              "patch=1,EE,21DA89B0,extended," + enemy6ID + "//6th id" + Environment.NewLine +
                              "patch=1,EE,21DA89B4,extended," + enemy6_data1 + "//6th code" + Environment.NewLine +
                              "patch=1,EE,21DA89B8,extended," + enemy6_data2 + "//6th code" + Environment.NewLine +
                              "patch=1,EE,21DA89BC,extended," + enemy6_data3 + "//6th code" + Environment.NewLine +
                              "patch=1,EE,21DA89C0,extended," + enemy6_data4 + "//6th code" + Environment.NewLine +
                              "patch=1,EE,21DA89C4,extended," + enemy6_data5 + "//6th code" + Environment.NewLine +
                              "patch=1,EE,21DA89C8,extended," + enemy6_data6 + "//6th code" + Environment.NewLine +
                              "patch=1,EE,21DA89CC,extended," + enemy6_data7 + "//6th code" + Environment.NewLine +
                              "patch=1,EE,21DA89D0,extended," + enemy6_data8 + "//6th code" + Environment.NewLine +
                              "patch=1,EE,21DA89D4,extended," + enemy6_data9 + "//6th code" + Environment.NewLine +
                              "patch=1,EE,21DA89D8,extended," + enemy6_data10 + "//6th code" + Environment.NewLine +
                              "patch=1,EE,21DA89DC,extended," + enemy6_data11 + "//6th code" + Environment.NewLine +
                              "patch=1,EE,21DA89E0,extended," + enemy6_data12 + "//6th code" + Environment.NewLine +
                              "patch=1,EE,21DA89E4,extended," + enemy6_data13 + "//6th code" + Environment.NewLine +
                              "patch=1,EE,21DA89E8,extended," + enemy6_data14 + "//6th code" + Environment.NewLine +
                              "patch=1,EE,21DA89EC,extended," + enemy6_data15 + "//6th code" + Environment.NewLine +
                              "patch=1,EE,21DA89F0,extended," + enemy6_data16 + "//6th code" + Environment.NewLine +
                              "patch=1,EE,21DA89F4,extended," + enemy6_data17 + "//6th code" + Environment.NewLine +
                              "patch=1,EE,21DA89F8,extended," + enemy6_data18 + "//6th code" + Environment.NewLine +
                              "patch=1,EE,21DA89FC,extended," + enemy6_data19 + "//6th code" + Environment.NewLine +
                              "patch=1,EE,21DA8A00,extended," + enemy6_data20 + "//6th code" + Environment.NewLine +
                              "patch=1,EE,21DA8A04,extended," + enemy6_data21 + "//6th code" + Environment.NewLine +
                              "patch=1,EE,21DA8A08,extended," + enemy6_data22 + "//6th code" + Environment.NewLine +
                              "patch=1,EE,21DA8A0C,extended," + enemy6_data23 + "//6th code" + Environment.NewLine +
                              "patch=1,EE,21DA8A10,extended," + enemy6_data24 + "//6th code" + Environment.NewLine +
                              "patch=1,EE,21DA8A14,extended," + enemy6_data25 + "//6th code" + Environment.NewLine +
                              "patch=1,EE,21DA8A18,extended," + enemy6_data26 + "//6th code" + Environment.NewLine +
                              "patch=1,EE,21DA8A1C,extended," + enemy6_data27 + "//6th code" + Environment.NewLine +
                              "patch=1,EE,21DA8A20,extended," + enemy6_data28 + "//6th code" + Environment.NewLine +
                              "patch=1,EE,21DA8A24,extended," + enemy6_data29 + "//6th code" + Environment.NewLine +
                              "patch=1,EE,21DA8A28,extended," + enemy6_data30 + "//6th code" + Environment.NewLine +
                              "patch=1,EE,21DA8A2C,extended," + enemy6_data31 + "//6th code" + Environment.NewLine +
                              "patch=1,EE,21DA8A30,extended," + enemy6_data32 + "//6th code" + Environment.NewLine +
                              "patch=1,EE,21DA8A34,extended," + enemy6_data33 + "//6th code" + Environment.NewLine +
                              "patch=1,EE,21DA8A38,extended," + enemy6_data34 + "//6th code" + Environment.NewLine +
                              "patch=1,EE,21DA8A3C,extended," + enemy6_data35 + "//6th code" + Environment.NewLine +
                              "patch=1,EE,21DA8A40,extended," + enemy6_data36 + "//6th code" + Environment.NewLine +
                              "patch=1,EE,21DA8A44,extended," + enemy6_data37 + "//6th code" + Environment.NewLine +
                              "patch=1,EE,21DA8A48,extended," + enemy6_data38 + "//6th code" + Environment.NewLine +
                              "patch=1,EE,21DA8A4C,extended," + enemy6_data39 + "//6th code" + Environment.NewLine +
                              "patch=1,EE,21DA8A50,extended," + enemy6_data40 + "//6th code" + Environment.NewLine +
                              "patch=1,EE,21DA8A54,extended," + enemy6_data41 + "//6th code" + Environment.NewLine +
                              "patch=1,EE,21DA8A58,extended," + enemy6_data42 + "//6th code";
            }

            string missionData = bulletHellCodes + Environment.NewLine +
                          "Mission" + missionNumber + Environment.NewLine +

                          customStats + Environment.NewLine +
                          cameraCode + Environment.NewLine +

                            "//All Missions Have The Same Objective = Take Everyone Down " + Environment.NewLine +
                            "patch=1,EE,01DA9BE6,extended,01                             " + Environment.NewLine +
                            "patch=1,EE,01DA9BE4,extended,00                             " + Environment.NewLine +
                            "patch=1,EE,01DA854C,extended,01                             " + Environment.NewLine +
                            "patch=1,EE,01DA8548,extended,01                             " + Environment.NewLine +
                            "patch=1,EE,01DA85FE,extended,00                             " + Environment.NewLine +
                            "patch=1,EE,01DA85DC,extended,00                             " + Environment.NewLine +
                            "patch=1,EE,01DA8552,extended,00                             " + Environment.NewLine +
                            "patch=1,EE,01DA8554,extended,00                             " + Environment.NewLine +

                            "//switch camera [R2+L3 = ON | R2+R3=OFF]                    " + Environment.NewLine +
                            "patch=1,EE,D0359852,extended,FDFD                           " + Environment.NewLine +
                            "patch=1,EE,004616C0,extended,08                             " + Environment.NewLine +
                            "patch=1,EE,D0359852,extended,FDFD                           " + Environment.NewLine +
                            "patch=1,EE,004614D0,extended,05                             " + Environment.NewLine +
                            "patch=1,EE,D0359852,extended,FDFB                           " + Environment.NewLine +
                            "patch=1,EE,004616C0,extended,00                             " + Environment.NewLine +
                            "patch=1,EE,D0359852,extended,FDFB                           " + Environment.NewLine +
                            "patch=1,EE,004614D0,extended,06                             " + Environment.NewLine +


                          "patch=1,EE,21DA8494,extended," + player2posA + "//player 2 pos" + Environment.NewLine +
                          "patch=1,EE,21DA8498,extended," + player2posB + "//player 2 pos" + Environment.NewLine +
                          "patch=1,EE,21DA849C,extended," + player2posC + "//player 2 pos" + Environment.NewLine +

                          "patch=1,EE,21DA84A0,extended,0000FFFE //always have partner" + Environment.NewLine +

                          "patch=1,EE,205AF6E4,extended,00390039 //partner ai" + Environment.NewLine +

                          "patch=1,EE,21DA84F4,extended," + weapons + " //player and partner have favorite weapon" + Environment.NewLine +

                          "patch=1,EE,21DA8528,extended," + EnemiesNumber + " //number of enemies" + Environment.NewLine +

                          //patch = 1,EE,21DA85E2,extended,0001
                          //patch = 1,EE,21DA85EC,extended,003C

                          "patch=1,EE,21DA85DC,extended," + allowPartnerDeath + " //partner can die" + Environment.NewLine +


                          "patch=1,EE,21DA85E2,extended," + missionObjective + " //timed mission or not" + Environment.NewLine +
                          "patch=1,EE,21DA85EC,extended," + missionTimer + " //timer" + Environment.NewLine +

                          "patch=1,EE,21DA8650,extended,0" + EnemiesNumber + " //number of enemies (map pos)" + Environment.NewLine +

                          enemiesData + Environment.NewLine +

                          "";

            return missionData;
        }

        public string GetControlCode(int input, int number)
        {
            string controlAddress = "";
            switch (number)
            {
                case 1:
                    controlAddress = "005A5F82";
                    break;
                case 2:
                    controlAddress = "005AF6D2";
                    break;
                case 3:
                    controlAddress = "005B8E22";
                    break;
                case 4:
                    controlAddress = "005C2572";
                    break;
                case 5:
                    controlAddress = "005CBCC2";
                    break;
                case 6:
                    controlAddress = "005D5412";
                    break;
                case 7:
                    controlAddress = "005DEB62";
                    break;
                case 8:
                    controlAddress = "005E82B2";
                    break;
            }

            string playerAddress = "";
            switch (number)
            {
                case 1:
                    playerAddress = "10AB6324";
                    break;
                case 2:
                    playerAddress = "10ABFA74";
                    break;
                case 3:
                    playerAddress = "10AC91C4";
                    break;
                case 4:
                    playerAddress = "10AD2914";
                    break;
                case 5:
                    playerAddress = "10ADC064";
                    break;
                case 6:
                    playerAddress = "10AE57B4";
                    break;
                case 7:
                    playerAddress = "10AEEF04";
                    break;
                case 8:
                    playerAddress = "10AF8654";
                    break;
            }

            string aiAddress = "";
            switch (number)
            {
                case 1:
                    aiAddress = "205A5F94";
                    break;
                case 2:
                    aiAddress = "205AF6E4";
                    break;
                case 3:
                    aiAddress = "205B8E34";
                    break;
                case 4:
                    aiAddress = "205C2584";
                    break;
                case 5:
                    aiAddress = "205CBCD4";
                    break;
                case 6:
                    aiAddress = "205D5424";
                    break;
                case 7:
                    aiAddress = "205DEB74";
                    break;
                case 8:
                    aiAddress = "205E82C4";
                    break;
            }


            string controlCode = "";

            switch (input)
            {
                case 0:
                    controlCode = "";
                    break;
                case 1:
                    controlCode = "patch=1,EE," + controlAddress + ",extended,01 //Force AI Control" + Environment.NewLine +
                                  "patch=1,EE," + aiAddress + ",extended,00000014//AI Level";
                    break;
                case 2:
                    controlCode = "patch=1,EE," + controlAddress + ",extended,01 //Force AI Control" + Environment.NewLine +
                                  "patch=1,EE," + aiAddress + ",extended,00010016//AI Level";
                    break;
                case 3:
                    controlCode = "patch=1,EE," + controlAddress + ",extended,01 //Force AI Control" + Environment.NewLine +
                                  "patch=1,EE," + aiAddress + ",extended,00020019//AI Level";
                    break;
                case 4:
                    controlCode = "patch=1,EE," + controlAddress + ",extended,01 //Force AI Control" + Environment.NewLine +
                                  "patch=1,EE," + aiAddress + ",extended,0003001A//AI Level";
                    break;
                case 5:
                    controlCode = "patch=1,EE," + controlAddress + ",extended,01 //Force AI Control" + Environment.NewLine +
                                  "patch=1,EE," + aiAddress + ",extended,0004001B//AI Level";
                    break;
                case 6:
                    controlCode = "patch=1,EE," + controlAddress + ",extended,01 //Force AI Control" + Environment.NewLine +
                                  "patch=1,EE," + aiAddress + ",extended,003A003A//AI Level";
                    break;
                case 10:
                    controlCode = "patch=1,EE,"+controlAddress+",extended,00 //Force Human Control" + Environment.NewLine +
                                  "patch=1,EE,"+playerAddress+",extended,00"+input+" //Number of Player in Control";
                    break;
            }


            return controlCode;
        }

    }
}
