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

namespace UR_pnach_editor.ViewModels
{
    public class StatsViewModel : BaseViewModel
    {
        public StatsViewModel()
        {

        }

        private double _limitP1 = 0;

        public double LimitP1
        {
            get { return _limitP1; }
            set
            {
                if (_limitP1 != value)
                {
                    _limitP1 = value;
                    RaisePropertyChanged("LimitP1");

                }
            }
        }

        private double _limitP2 = 0;

        public double LimitP2
        {
            get { return _limitP2; }
            set
            {
                if (_limitP2 != value)
                {
                    _limitP2 = value;
                    RaisePropertyChanged("LimitP2");

                }
            }
        }

        private double _limitP3 = 0;

        public double LimitP3
        {
            get { return _limitP3; }
            set
            {
                if (_limitP3 != value)
                {
                    _limitP3 = value;
                    RaisePropertyChanged("LimitP3");

                }
            }
        }

        private double _limitP4 = 0;

        public double LimitP4
        {
            get { return _limitP4; }
            set
            {
                if (_limitP4 != value)
                {
                    _limitP4 = value;
                    RaisePropertyChanged("LimitP4");

                }
            }
        }


        private bool _modifyP1 = false;

        public bool ModifyP1
        {
            get { return _modifyP1; }
            set
            {
                if (_modifyP1 != value)
                {
                    _modifyP1 = value;
                    RaisePropertyChanged("ModifyP1");

                }
            }
        }

        private bool _modifyP2 = false;

        public bool ModifyP2
        {
            get { return _modifyP2; }
            set
            {
                if (_modifyP2 != value)
                {
                    _modifyP2 = value;
                    RaisePropertyChanged("ModifyP2");

                }
            }
        }

        private bool _modifyP3 = false;

        public bool ModifyP3
        {
            get { return _modifyP3; }
            set
            {
                if (_modifyP3 != value)
                {
                    _modifyP3 = value;
                    RaisePropertyChanged("ModifyP3");

                }
            }
        }

        private bool _modifyP4 = false;

        public bool ModifyP4
        {
            get { return _modifyP4; }
            set
            {
                if (_modifyP4 != value)
                {
                    _modifyP4 = value;
                    RaisePropertyChanged("ModifyP4");

                }
            }
        }


        private string _textP1 = "";

        public string TextP1
        {
            get { return _textP1; }
            set
            {
                if (_textP1 != value)
                {
                    _textP1 = value;
                    RaisePropertyChanged("TextP1");

                }
            }
        }

        private string _textP2 = "";

        public string TextP2
        {
            get { return _textP2; }
            set
            {
                if (_textP2 != value)
                {
                    _textP2 = value;
                    RaisePropertyChanged("TextP2");

                }
            }
        }

        private string _textP3 = "";

        public string TextP3
        {
            get { return _textP3; }
            set
            {
                if (_textP3 != value)
                {
                    _textP3 = value;
                    RaisePropertyChanged("TextP3");

                }
            }
        }

        private string _textP4 = "";

        public string TextP4
        {
            get { return _textP4; }
            set
            {
                if (_textP4 != value)
                {
                    _textP4 = value;
                    RaisePropertyChanged("TextP4");

                }
            }
        }



        internal void SavePreset(string slotNumber, double strike, double grapple, double regional, double special, double weapon, double toughness,
            double headEnd, double bodyEnd, double lowerEnd)
        {

            List<double> presetValues = new List<double>() { strike, grapple, regional, special, weapon, toughness, headEnd, bodyEnd, lowerEnd };

            switch (slotNumber)
            {
                case "1":
                    //if (SettingsClass.customStatsSlot1 != null)
                    //{
                    //    SettingsClass.customStatsSlot1.Clear();
                    //}

                    SettingsClass.STK_1 = strike;
                    SettingsClass.GRP_1 = grapple;
                    SettingsClass.RGA_1 = regional;
                    SettingsClass.SPA_1 = special;
                    SettingsClass.WPA_1 = weapon;
                    SettingsClass.TGH_1 = toughness;
                    SettingsClass.HDE_1 = headEnd;
                    SettingsClass.UBE_1 = bodyEnd;
                    SettingsClass.LBE_1 = lowerEnd;
                    //SettingsClass.customStatsSlot1 = presetValues;
                    break;
                case "2":
                    //if (SettingsClass.customStatsSlot2 != null)
                    //{
                    //    SettingsClass.customStatsSlot2.Clear();
                    //}
                    SettingsClass.STK_2 = strike;
                    SettingsClass.GRP_2 = grapple;
                    SettingsClass.RGA_2 = regional;
                    SettingsClass.SPA_2 = special;
                    SettingsClass.WPA_2 = weapon;
                    SettingsClass.TGH_2 = toughness;
                    SettingsClass.HDE_2 = headEnd;
                    SettingsClass.UBE_2 = bodyEnd;
                    SettingsClass.LBE_2 = lowerEnd;
                    //SettingsClass.customStatsSlot2 = presetValues;
                    break;
                case "3":
                    //if (SettingsClass.customStatsSlot3 != null)
                    //{
                    //    SettingsClass.customStatsSlot3.Clear();
                    //}
                    SettingsClass.STK_3 = strike;
                    SettingsClass.GRP_3 = grapple;
                    SettingsClass.RGA_3 = regional;
                    SettingsClass.SPA_3 = special;
                    SettingsClass.WPA_3 = weapon;
                    SettingsClass.TGH_3 = toughness;
                    SettingsClass.HDE_3 = headEnd;
                    SettingsClass.UBE_3 = bodyEnd;
                    SettingsClass.LBE_3 = lowerEnd;
                    //SettingsClass.customStatsSlot3 = presetValues;
                    break;
                case "4":
                    //if (SettingsClass.customStatsSlot4 != null)
                    //{
                    //    SettingsClass.customStatsSlot4.Clear();
                    //}
                    SettingsClass.STK_4 = strike;
                    SettingsClass.GRP_4 = grapple;
                    SettingsClass.RGA_4 = regional;
                    SettingsClass.SPA_4 = special;
                    SettingsClass.WPA_4 = weapon;
                    SettingsClass.TGH_4 = toughness;
                    SettingsClass.HDE_4 = headEnd;
                    SettingsClass.UBE_4 = bodyEnd;
                    SettingsClass.LBE_4 = lowerEnd;
                    //SettingsClass.customStatsSlot4 = presetValues;
                    break;
                case "5":
                    //if (SettingsClass.customStatsSlot5 != null)
                    //{
                    //    SettingsClass.customStatsSlot5.Clear();
                    //}
                    SettingsClass.STK_5 = strike;
                    SettingsClass.GRP_5 = grapple;
                    SettingsClass.RGA_5 = regional;
                    SettingsClass.SPA_5 = special;
                    SettingsClass.WPA_5 = weapon;
                    SettingsClass.TGH_5 = toughness;
                    SettingsClass.HDE_5 = headEnd;
                    SettingsClass.UBE_5 = bodyEnd;
                    SettingsClass.LBE_5 = lowerEnd;
                    //SettingsClass.customStatsSlot5 = presetValues;
                    break;
            }

            SettingsClass.SaveData();
        }


    }
}
