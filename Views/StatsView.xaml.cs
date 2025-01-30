using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using UR_pnach_editor.ViewModels;
using OfficeOpenXml;
using System.IO;
using System.Data;
using UR_pnach_editor.Codes;
using System.Windows.Media.Media3D;
using UR_pnach_editor.Services;
using System.Collections;
using NAudio.Wave;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Drawing;
using WpfAnimatedGif;

namespace UR_pnach_editor.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class StatsView : UserControl
    {
        StatsViewModel viewModel;

        public bool isLimitSet = false;
        private int limitPoints = 0;
        private double P1Limit = 0;
        private double P2Limit = 0;
        private double P3Limit = 0;
        private double P4Limit = 0;

        public StatsView()
        {
            //if (!ConfigClass.isConfigFileLoaded)
            //{
            //    ConfigClass.LoadData();
            //    ConfigClass.isConfigFileLoaded = true;
            //}

            InitializeComponent();

            SettingsClass.LoadData();


            if (SettingsClass.EditorEffectsIndex == 0)
            {
                var imageUri = new Uri("pack://application:,,,/Resources/Nothing.png");
                ImageBehavior.SetAnimatedSource(gifImage, new BitmapImage(imageUri));
            }
            else if (SettingsClass.EditorEffectsIndex == 1)
            {
                var imageUri = new Uri("pack://application:,,,/Resources/Snowing.gif");
                ImageBehavior.SetAnimatedSource(gifImage, new BitmapImage(imageUri));
            }
            else if (SettingsClass.EditorEffectsIndex == 2)
            {
                var imageUri = new Uri("pack://application:,,,/Resources/Raining.gif");
                ImageBehavior.SetAnimatedSource(gifImage, new BitmapImage(imageUri));
            }
            else if (SettingsClass.EditorEffectsIndex == 3)
            {
                var imageUri = new Uri("pack://application:,,,/Resources/Blooding.gif");
                ImageBehavior.SetAnimatedSource(gifImage, new BitmapImage(imageUri));
            }
            else if (SettingsClass.EditorEffectsIndex == 4)
            {
                var imageUri = new Uri("pack://application:,,,/Resources/Leaves.gif");
                ImageBehavior.SetAnimatedSource(gifImage, new BitmapImage(imageUri));
            }

            viewModel = new();

            this.DataContext = viewModel;



            if (SettingsClass.missionFolderPath != "" && File.Exists(SettingsClass.missionFolderPath + @"\M1.txt") && SettingsClass.PageEnterSFX)
            {
                string partialPath = SettingsClass.missionFolderPath.Substring(0, SettingsClass.missionFolderPath.Length - 14);
                string sfxPath = "";
                double volume = 0;

                int random = new Random().Next(1, 101);

                if (random < 71)
                {
                    sfxPath = partialPath + @"\sfx\SpaWave.mp3";
                    volume = 1.0;
                }
                else if (random > 70 && random < 99)
                {
                    sfxPath = partialPath + @"\sfx\ShinkaiTaunt.mp3";
                    volume = 0.4;
                }
                else
                {
                    sfxPath = partialPath + @"\sfx\Gipsy_Laugh.mp3";
                    volume = 0.4;
                }

                customSound.Source = new Uri(sfxPath);
                customSound.Volume = volume;
            }

            viewModel.ModifyP1 = true;
            viewModel.ModifyP2 = true;
            viewModel.ModifyP3 = true;
            viewModel.ModifyP4 = true;
            viewModel.TextP1 = "ON";
            viewModel.TextP2 = "ON";
            viewModel.TextP3 = "ON";
            viewModel.TextP4 = "ON";

            viewModel.LimitP1 = 9000;
            viewModel.LimitP2 = 9000;
            viewModel.LimitP3 = 9000;
            viewModel.LimitP4 = 9000;


            SettingsClass.LoadData();


        }

        private void GoToMainPage_Click(object sender, RoutedEventArgs e)
        {
            viewModel.DisplayMainView();
        }

        private void slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            int stkValue = 14;
            int grpValue = 16;
            int rgaValue = 10;
            int spaValue = 18;
            int wpaValue = 10;
            int tghValue = 20;
            int hdeValue = 6;
            int ubeValue = 7;
            int lbeValue = 6;


            if (sliderSTK1 != null && sliderGRP1 != null && sliderRGA1 != null && sliderSPA1 != null && sliderWPA1 != null
                && sliderTGH1 != null && sliderHDE1 != null && sliderUBE1 != null && sliderLBE1 != null && txtLimit1 != null)
            {
                P1Limit = sliderSTK1.Value * stkValue + sliderGRP1.Value * grpValue + sliderRGA1.Value * rgaValue + 
                sliderSPA1.Value * spaValue + sliderWPA1.Value * wpaValue + sliderTGH1.Value * tghValue +
                sliderHDE1.Value * hdeValue + sliderUBE1.Value * ubeValue + sliderLBE1.Value * lbeValue;
                viewModel.LimitP1 = P1Limit;

            }

            if (sliderSTK2 != null && sliderGRP2 != null && sliderRGA2 != null && sliderSPA2 != null && sliderWPA2 != null
                && sliderTGH2 != null && sliderHDE2 != null && sliderUBE2 != null && sliderLBE2 != null && txtLimit2 != null)
            {
                P2Limit = sliderSTK2.Value * stkValue + sliderGRP2.Value * grpValue + sliderRGA2.Value * rgaValue +
                sliderSPA2.Value * spaValue + sliderWPA2.Value * wpaValue + sliderTGH2.Value * tghValue +
                sliderHDE2.Value * hdeValue + sliderUBE2.Value * ubeValue + sliderLBE2.Value * lbeValue;
                viewModel.LimitP2 = P2Limit;

            }

            if (sliderSTK3 != null && sliderGRP3 != null && sliderRGA3 != null && sliderSPA3 != null && sliderWPA3 != null
                && sliderTGH3 != null && sliderHDE3 != null && sliderUBE3 != null && sliderLBE3 != null && txtLimit3 != null)
            {
                P3Limit = sliderSTK3.Value * stkValue + sliderGRP3.Value * grpValue + sliderRGA3.Value * rgaValue +
                sliderSPA3.Value * spaValue + sliderWPA3.Value * wpaValue  + sliderTGH3.Value * tghValue +
                sliderHDE3.Value * hdeValue + sliderUBE3.Value * ubeValue + sliderLBE3.Value * lbeValue;
                viewModel.LimitP3 = P3Limit;

            }

            if (sliderSTK4 != null && sliderGRP4 != null && sliderRGA4 != null && sliderSPA4 != null && sliderWPA4 != null
                && sliderTGH4 != null && sliderHDE4 != null && sliderUBE4 != null && sliderLBE4 != null && txtLimit4 != null)
            {
                P4Limit = sliderSTK4.Value * stkValue + sliderGRP4.Value * grpValue + sliderRGA4.Value * rgaValue +
                sliderSPA4.Value * spaValue + sliderWPA4.Value * wpaValue + sliderTGH4.Value * tghValue +
                sliderHDE4.Value * hdeValue + sliderUBE4.Value * ubeValue + sliderLBE4.Value * lbeValue;
                viewModel.LimitP4 = P4Limit;

            }
        }



        private void ActivateStatsModifier_Click(object sender, RoutedEventArgs e)
        {

            int STK1 = Convert.ToInt32(sliderSTK1.Value);
            int GRP1 = Convert.ToInt32(sliderGRP1.Value);
            int RGA1 = Convert.ToInt32(sliderRGA1.Value);
            int SPA1 = Convert.ToInt32(sliderSPA1.Value);
            int WPA1 = Convert.ToInt32(sliderWPA1.Value);
            int TGH1 = Convert.ToInt32(sliderTGH1.Value);
            int HDE1 = Convert.ToInt32(sliderHDE1.Value);
            int UBE1 = Convert.ToInt32(sliderUBE1.Value);
            int LBE1 = Convert.ToInt32(sliderLBE1.Value);

            int STK2 = Convert.ToInt32(sliderSTK2.Value);
            int GRP2 = Convert.ToInt32(sliderGRP2.Value);
            int RGA2 = Convert.ToInt32(sliderRGA2.Value);
            int SPA2 = Convert.ToInt32(sliderSPA2.Value);
            int WPA2 = Convert.ToInt32(sliderWPA2.Value);
            int TGH2 = Convert.ToInt32(sliderTGH2.Value);
            int HDE2 = Convert.ToInt32(sliderHDE2.Value);
            int UBE2 = Convert.ToInt32(sliderUBE2.Value);
            int LBE2 = Convert.ToInt32(sliderLBE2.Value);

            int STK3 = Convert.ToInt32(sliderSTK3.Value);
            int GRP3 = Convert.ToInt32(sliderGRP3.Value);
            int RGA3 = Convert.ToInt32(sliderRGA3.Value);
            int SPA3 = Convert.ToInt32(sliderSPA3.Value);
            int WPA3 = Convert.ToInt32(sliderWPA3.Value);
            int TGH3 = Convert.ToInt32(sliderTGH3.Value);
            int HDE3 = Convert.ToInt32(sliderHDE3.Value);
            int UBE3 = Convert.ToInt32(sliderUBE3.Value);
            int LBE3 = Convert.ToInt32(sliderLBE3.Value);

            int STK4 = Convert.ToInt32(sliderSTK4.Value);
            int GRP4 = Convert.ToInt32(sliderGRP4.Value);
            int RGA4 = Convert.ToInt32(sliderRGA4.Value);
            int SPA4 = Convert.ToInt32(sliderSPA4.Value);
            int WPA4 = Convert.ToInt32(sliderWPA4.Value);
            int TGH4 = Convert.ToInt32(sliderTGH4.Value);
            int HDE4 = Convert.ToInt32(sliderHDE4.Value);
            int UBE4 = Convert.ToInt32(sliderUBE4.Value);
            int LBE4 = Convert.ToInt32(sliderLBE4.Value);


            CreatePnach3.ActivateStatsModifier(STK1, GRP1, RGA1, SPA1, WPA1, TGH1, HDE1, UBE1, LBE1,
                                  STK2, GRP2, RGA2, SPA2, WPA2, TGH2, HDE2, UBE2, LBE2,
                                  STK3, GRP3, RGA3, SPA3, WPA3, TGH3, HDE3, UBE3, LBE3,
                                  STK4, GRP4, RGA4, SPA4, WPA4, TGH4, HDE4, UBE4, LBE4,
            viewModel.ModifyP1, viewModel.ModifyP2, viewModel.ModifyP3, viewModel.ModifyP4);

        }

        private void SwitchP1_Click(object sender, RoutedEventArgs e)
        {
            if (viewModel.ModifyP1)
            {
                viewModel.TextP1 = "OFF";
            }
            else
            {
                viewModel.TextP1 = "ON";
            }
            viewModel.ModifyP1 = !viewModel.ModifyP1;
        }
        private void SwitchP2_Click(object sender, RoutedEventArgs e)
        {
            if (viewModel.ModifyP2)
            {
                viewModel.TextP2 = "OFF";
            }
            else
            {
                viewModel.TextP2 = "ON";
            }
            viewModel.ModifyP2 = !viewModel.ModifyP2;
        }
        private void SwitchP3_Click(object sender, RoutedEventArgs e)
        {
            if (viewModel.ModifyP3)
            {
                viewModel.TextP3 = "OFF";
            }
            else
            {
                viewModel.TextP3 = "ON";
            }
            viewModel.ModifyP3 = !viewModel.ModifyP3;
        }
        private void SwitchP4_Click(object sender, RoutedEventArgs e)
        {
            if (viewModel.ModifyP4)
            {
                viewModel.TextP4 = "OFF";
            }
            else
            {
                viewModel.TextP4 = "ON";
            }
            viewModel.ModifyP4 = !viewModel.ModifyP4;
        }


        private void LoadButton_Click(object sender, RoutedEventArgs e)
        {
            if ((InputLoadPlayer.Text != "1" || InputLoadPlayer.Text != "2" || InputLoadPlayer.Text != "3" || InputLoadPlayer.Text != "4") &&
                (InputLoadSlot.Text != "1" || InputLoadSlot.Text != "2" || InputLoadSlot.Text != "3" || InputLoadSlot.Text != "4" || InputLoadSlot.Text != "5"))
            {
                SettingsClass.LoadData();

                switch (InputLoadSlot.Text)
                {
                    case "1":

                        switch (InputLoadPlayer.Text)
                        {
                            case "1":
                                sliderSTK1.Value = SettingsClass.STK_1;
                                sliderGRP1.Value = SettingsClass.GRP_1;
                                sliderRGA1.Value = SettingsClass.RGA_1;
                                sliderSPA1.Value = SettingsClass.SPA_1;
                                sliderWPA1.Value = SettingsClass.WPA_1;
                                sliderTGH1.Value = SettingsClass.TGH_1;
                                sliderHDE1.Value = SettingsClass.HDE_1;
                                sliderUBE1.Value = SettingsClass.UBE_1;
                                sliderLBE1.Value = SettingsClass.LBE_1;
                                break;
                            case "2":
                                sliderSTK2.Value = SettingsClass.STK_1;
                                sliderGRP2.Value = SettingsClass.GRP_1;
                                sliderRGA2.Value = SettingsClass.RGA_1;
                                sliderSPA2.Value = SettingsClass.SPA_1;
                                sliderWPA2.Value = SettingsClass.WPA_1;
                                sliderTGH2.Value = SettingsClass.TGH_1;
                                sliderHDE2.Value = SettingsClass.HDE_1;
                                sliderUBE2.Value = SettingsClass.UBE_1;
                                sliderLBE2.Value = SettingsClass.LBE_1;
                                break;
                            case "3":
                                sliderSTK3.Value = SettingsClass.STK_1;
                                sliderGRP3.Value = SettingsClass.GRP_1;
                                sliderRGA3.Value = SettingsClass.RGA_1;
                                sliderSPA3.Value = SettingsClass.SPA_1;
                                sliderWPA3.Value = SettingsClass.WPA_1;
                                sliderTGH3.Value = SettingsClass.TGH_1;
                                sliderHDE3.Value = SettingsClass.HDE_1;
                                sliderUBE3.Value = SettingsClass.UBE_1;
                                sliderLBE3.Value = SettingsClass.LBE_1;
                                break;
                            case "4":
                                sliderSTK4.Value = SettingsClass.STK_1;
                                sliderGRP4.Value = SettingsClass.GRP_1;
                                sliderRGA4.Value = SettingsClass.RGA_1;
                                sliderSPA4.Value = SettingsClass.SPA_1;
                                sliderWPA4.Value = SettingsClass.WPA_1;
                                sliderTGH4.Value = SettingsClass.TGH_1;
                                sliderHDE4.Value = SettingsClass.HDE_1;
                                sliderUBE4.Value = SettingsClass.UBE_1;
                                sliderLBE4.Value = SettingsClass.LBE_1;
                                break;
                        }

                        break;
                    case "2":

                        switch (InputLoadPlayer.Text)
                        {
                            case "1":
                                sliderSTK1.Value = SettingsClass.STK_2;
                                sliderGRP1.Value = SettingsClass.GRP_2;
                                sliderRGA1.Value = SettingsClass.RGA_2;
                                sliderSPA1.Value = SettingsClass.SPA_2;
                                sliderWPA1.Value = SettingsClass.WPA_2;
                                sliderTGH1.Value = SettingsClass.TGH_2;
                                sliderHDE1.Value = SettingsClass.HDE_2;
                                sliderUBE1.Value = SettingsClass.UBE_2;
                                sliderLBE1.Value = SettingsClass.LBE_2;
                                break;
                            case "2":
                                sliderSTK2.Value = SettingsClass.STK_2;
                                sliderGRP2.Value = SettingsClass.GRP_2;
                                sliderRGA2.Value = SettingsClass.RGA_2;
                                sliderSPA2.Value = SettingsClass.SPA_2;
                                sliderWPA2.Value = SettingsClass.WPA_2;
                                sliderTGH2.Value = SettingsClass.TGH_2;
                                sliderHDE2.Value = SettingsClass.HDE_2;
                                sliderUBE2.Value = SettingsClass.UBE_2;
                                sliderLBE2.Value = SettingsClass.LBE_2;
                                break;
                            case "3":
                                sliderSTK3.Value = SettingsClass.STK_2;
                                sliderGRP3.Value = SettingsClass.GRP_2;
                                sliderRGA3.Value = SettingsClass.RGA_2;
                                sliderSPA3.Value = SettingsClass.SPA_2;
                                sliderWPA3.Value = SettingsClass.WPA_2;
                                sliderTGH3.Value = SettingsClass.TGH_2;
                                sliderHDE3.Value = SettingsClass.HDE_2;
                                sliderUBE3.Value = SettingsClass.UBE_2;
                                sliderLBE3.Value = SettingsClass.LBE_2;
                                break;
                            case "4":
                                sliderSTK4.Value = SettingsClass.STK_2;
                                sliderGRP4.Value = SettingsClass.GRP_2;
                                sliderRGA4.Value = SettingsClass.RGA_2;
                                sliderSPA4.Value = SettingsClass.SPA_2;
                                sliderWPA4.Value = SettingsClass.WPA_2;
                                sliderTGH4.Value = SettingsClass.TGH_2;
                                sliderHDE4.Value = SettingsClass.HDE_2;
                                sliderUBE4.Value = SettingsClass.UBE_2;
                                sliderLBE4.Value = SettingsClass.LBE_2;
                                break;
                        }

                        break;
                    case "3":

                        switch (InputLoadPlayer.Text)
                        {
                            case "1":
                                sliderSTK1.Value = SettingsClass.STK_3;
                                sliderGRP1.Value = SettingsClass.GRP_3;
                                sliderRGA1.Value = SettingsClass.RGA_3;
                                sliderSPA1.Value = SettingsClass.SPA_3;
                                sliderWPA1.Value = SettingsClass.WPA_3;
                                sliderTGH1.Value = SettingsClass.TGH_3;
                                sliderHDE1.Value = SettingsClass.HDE_3;
                                sliderUBE1.Value = SettingsClass.UBE_3;
                                sliderLBE1.Value = SettingsClass.LBE_3;
                                break;
                            case "2":
                                sliderSTK2.Value = SettingsClass.STK_3;
                                sliderGRP2.Value = SettingsClass.GRP_3;
                                sliderRGA2.Value = SettingsClass.RGA_3;
                                sliderSPA2.Value = SettingsClass.SPA_3;
                                sliderWPA2.Value = SettingsClass.WPA_3;
                                sliderTGH2.Value = SettingsClass.TGH_3;
                                sliderHDE2.Value = SettingsClass.HDE_3;
                                sliderUBE2.Value = SettingsClass.UBE_3;
                                sliderLBE2.Value = SettingsClass.LBE_3;
                                break;
                            case "3":
                                sliderSTK3.Value = SettingsClass.STK_3;
                                sliderGRP3.Value = SettingsClass.GRP_3;
                                sliderRGA3.Value = SettingsClass.RGA_3;
                                sliderSPA3.Value = SettingsClass.SPA_3;
                                sliderWPA3.Value = SettingsClass.WPA_3;
                                sliderTGH3.Value = SettingsClass.TGH_3;
                                sliderHDE3.Value = SettingsClass.HDE_3;
                                sliderUBE3.Value = SettingsClass.UBE_3;
                                sliderLBE3.Value = SettingsClass.LBE_3;
                                break;
                            case "4":
                                sliderSTK4.Value = SettingsClass.STK_3;
                                sliderGRP4.Value = SettingsClass.GRP_3;
                                sliderRGA4.Value = SettingsClass.RGA_3;
                                sliderSPA4.Value = SettingsClass.SPA_3;
                                sliderWPA4.Value = SettingsClass.WPA_3;
                                sliderTGH4.Value = SettingsClass.TGH_3;
                                sliderHDE4.Value = SettingsClass.HDE_3;
                                sliderUBE4.Value = SettingsClass.UBE_3;
                                sliderLBE4.Value = SettingsClass.LBE_3;
                                break;
                        }

                        break;
                    case "4":

                        switch (InputLoadPlayer.Text)
                        {
                            case "1":
                                sliderSTK1.Value = SettingsClass.STK_4;
                                sliderGRP1.Value = SettingsClass.GRP_4;
                                sliderRGA1.Value = SettingsClass.RGA_4;
                                sliderSPA1.Value = SettingsClass.SPA_4;
                                sliderWPA1.Value = SettingsClass.WPA_4;
                                sliderTGH1.Value = SettingsClass.TGH_4;
                                sliderHDE1.Value = SettingsClass.HDE_4;
                                sliderUBE1.Value = SettingsClass.UBE_4;
                                sliderLBE1.Value = SettingsClass.LBE_4;
                                break;
                            case "2":
                                sliderSTK2.Value = SettingsClass.STK_4;
                                sliderGRP2.Value = SettingsClass.GRP_4;
                                sliderRGA2.Value = SettingsClass.RGA_4;
                                sliderSPA2.Value = SettingsClass.SPA_4;
                                sliderWPA2.Value = SettingsClass.WPA_4;
                                sliderTGH2.Value = SettingsClass.TGH_4;
                                sliderHDE2.Value = SettingsClass.HDE_4;
                                sliderUBE2.Value = SettingsClass.UBE_4;
                                sliderLBE2.Value = SettingsClass.LBE_4;
                                break;
                            case "3":
                                sliderSTK3.Value = SettingsClass.STK_4;
                                sliderGRP3.Value = SettingsClass.GRP_4;
                                sliderRGA3.Value = SettingsClass.RGA_4;
                                sliderSPA3.Value = SettingsClass.SPA_4;
                                sliderWPA3.Value = SettingsClass.WPA_4;
                                sliderTGH3.Value = SettingsClass.TGH_4;
                                sliderHDE3.Value = SettingsClass.HDE_4;
                                sliderUBE3.Value = SettingsClass.UBE_4;
                                sliderLBE3.Value = SettingsClass.LBE_4;
                                break;
                            case "4":
                                sliderSTK4.Value = SettingsClass.STK_4;
                                sliderGRP4.Value = SettingsClass.GRP_4;
                                sliderRGA4.Value = SettingsClass.RGA_4;
                                sliderSPA4.Value = SettingsClass.SPA_4;
                                sliderWPA4.Value = SettingsClass.WPA_4;
                                sliderTGH4.Value = SettingsClass.TGH_4;
                                sliderHDE4.Value = SettingsClass.HDE_4;
                                sliderUBE4.Value = SettingsClass.UBE_4;
                                sliderLBE4.Value = SettingsClass.LBE_4;
                                break;
                        }

                        break;
                    case "5":
                        //SettingsClass.customStatsSlot5.Clear();
                        //SettingsClass.customStatsSlot5.AddRange(new double[] { 0, 0, 0, 0, 0, 0, 0, 0, 0 });

                        //sliderSTK1.Value = SettingsClass.customStatsSlot1[0];

                        switch (InputLoadPlayer.Text)
                        {
                            case "1":
                                sliderSTK1.Value = SettingsClass.STK_5;
                                sliderGRP1.Value = SettingsClass.GRP_5;
                                sliderRGA1.Value = SettingsClass.RGA_5;
                                sliderSPA1.Value = SettingsClass.SPA_5;
                                sliderWPA1.Value = SettingsClass.WPA_5;
                                sliderTGH1.Value = SettingsClass.TGH_5;
                                sliderHDE1.Value = SettingsClass.HDE_5;
                                sliderUBE1.Value = SettingsClass.UBE_5;
                                sliderLBE1.Value = SettingsClass.LBE_5;
                                break;
                            case "2":
                                sliderSTK2.Value = SettingsClass.STK_5;
                                sliderGRP2.Value = SettingsClass.GRP_5;
                                sliderRGA2.Value = SettingsClass.RGA_5;
                                sliderSPA2.Value = SettingsClass.SPA_5;
                                sliderWPA2.Value = SettingsClass.WPA_5;
                                sliderTGH2.Value = SettingsClass.TGH_5;
                                sliderHDE2.Value = SettingsClass.HDE_5;
                                sliderUBE2.Value = SettingsClass.UBE_5;
                                sliderLBE2.Value = SettingsClass.LBE_5;
                                break;
                            case "3":
                                sliderSTK3.Value = SettingsClass.STK_5;
                                sliderGRP3.Value = SettingsClass.GRP_5;
                                sliderRGA3.Value = SettingsClass.RGA_5;
                                sliderSPA3.Value = SettingsClass.SPA_5;
                                sliderWPA3.Value = SettingsClass.WPA_5;
                                sliderTGH3.Value = SettingsClass.TGH_5;
                                sliderHDE3.Value = SettingsClass.HDE_5;
                                sliderUBE3.Value = SettingsClass.UBE_5;
                                sliderLBE3.Value = SettingsClass.LBE_5;
                                break;
                            case "4":
                                sliderSTK4.Value = SettingsClass.STK_5;
                                sliderGRP4.Value = SettingsClass.GRP_5;
                                sliderRGA4.Value = SettingsClass.RGA_5;
                                sliderSPA4.Value = SettingsClass.SPA_5;
                                sliderWPA4.Value = SettingsClass.WPA_5;
                                sliderTGH4.Value = SettingsClass.TGH_5;
                                sliderHDE4.Value = SettingsClass.HDE_5;
                                sliderUBE4.Value = SettingsClass.UBE_5;
                                sliderLBE4.Value = SettingsClass.LBE_5;
                                break;
                        }

                        break;
                }

            }
            else
            {
                MessageBox.Show("Players 1,2,3,4 & Slots 1,2,3,4,5 Only!");
            }
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            if ((InputSavePlayer.Text == "1" || InputSavePlayer.Text == "2" || InputSavePlayer.Text == "3" || InputSavePlayer.Text == "4") &&
                (InputSaveSlot.Text == "1" || InputSaveSlot.Text == "2" || InputSaveSlot.Text == "3" || InputSaveSlot.Text == "4" || InputSaveSlot.Text == "5"))
            {

                if (InputSavePlayer.Text == "1")
                {
                    viewModel.SavePreset(InputSaveSlot.Text, Convert.ToDouble(sliderSTK1.Value), Convert.ToDouble(sliderGRP1.Value), Convert.ToDouble(sliderRGA1.Value), Convert.ToDouble(sliderSPA1.Value),
                            Convert.ToDouble(sliderWPA1.Value), Convert.ToDouble(sliderTGH1.Value), Convert.ToDouble(sliderHDE1.Value), Convert.ToDouble(sliderUBE1.Value), Convert.ToDouble(sliderLBE1.Value));
                }
                else if (InputSavePlayer.Text == "2")
                {
                    viewModel.SavePreset(InputSaveSlot.Text, Convert.ToDouble(sliderSTK2.Value), Convert.ToDouble(sliderGRP2.Value), Convert.ToDouble(sliderRGA2.Value), Convert.ToDouble(sliderSPA2.Value),
                            Convert.ToDouble(sliderWPA2.Value), Convert.ToDouble(sliderTGH2.Value), Convert.ToDouble(sliderHDE2.Value), Convert.ToDouble(sliderUBE2.Value), Convert.ToDouble(sliderLBE2.Value));
                }
                else if (InputSavePlayer.Text == "3")
                {
                    viewModel.SavePreset(InputSaveSlot.Text, Convert.ToDouble(sliderSTK3.Value), Convert.ToDouble(sliderGRP3.Value), Convert.ToDouble(sliderRGA3.Value), Convert.ToDouble(sliderSPA3.Value),
                            Convert.ToDouble(sliderWPA3.Value), Convert.ToDouble(sliderTGH3.Value), Convert.ToDouble(sliderHDE3.Value), Convert.ToDouble(sliderUBE3.Value), Convert.ToDouble(sliderLBE3.Value));
                }
                else if (InputSavePlayer.Text == "4")
                {
                    viewModel.SavePreset(InputSaveSlot.Text, Convert.ToDouble(sliderSTK4.Value), Convert.ToDouble(sliderGRP4.Value), Convert.ToDouble(sliderRGA4.Value), Convert.ToDouble(sliderSPA4.Value),
                            Convert.ToDouble(sliderWPA4.Value), Convert.ToDouble(sliderTGH4.Value), Convert.ToDouble(sliderHDE4.Value), Convert.ToDouble(sliderUBE4.Value), Convert.ToDouble(sliderLBE4.Value));
                }

            }
            else
            {
                MessageBox.Show("Players 1,2,3,4 & Slots 1,2,3,4,5 Only!");
            }
        }

        private void ActivateStatsModifier_Info(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Each player have his column, pick a column and a slider and drag it to the desired value\n" +
                "after that click Ovewrite Stats button to make all the sliders take effect, if you want to change only certain players values " +
                "click the stats button at the end of each column to dissable the changes for that player\n" +
                "Do you want a balanced fight change each player you want with the desired stats then take a look at Points " +
                "value near the end of the column for each players, make sure each have same value (or more points if you want a challenge)\n" +
                "If there is a player setting you want to use later go near the save button after Player and type the number of that player " +
                "then to slot (number of the slot you to save in [5 slots available]) type your slot number then click Save button " +
                "now when you want to load it go near the Load button pick slot (your slot) to player (the one you want) and click Load button, " +
                "you can use this to fast copy paste a setting between all players if you want.");
        }
    }




}
