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
using System.Diagnostics;
using System.Windows.Threading;
using System.Threading;
using WpfAnimatedGif;
using NAudio.SoundFont;
using System.Text.RegularExpressions;
using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows;

namespace UR_pnach_editor.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class DeveloperView : UserControl
    {
        DeveloperViewModel viewModel;


        public DeveloperView()
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

            if (SettingsClass.PageEnterSFX)
            {
                viewModel.SoundButton = "/Resources/SoundOn.png";
            }
            else
            {
                viewModel.SoundButton = "/Resources/SoundOff.png";
            }

            SettingUp.ItemsSource = viewModel.GunMoves;
            SettingUp.SelectedIndex = 0;
            SettingNormal.ItemsSource = viewModel.GunMoves;
            SettingNormal.SelectedIndex = 0;
            SettingDown.ItemsSource = viewModel.GunMoves;
            SettingDown.SelectedIndex = 0;
            SettingAI.ItemsSource = viewModel.YesOrNo;
            SettingAI.SelectedIndex = 0;

            EditorEffect.ItemsSource = viewModel.EditorEffects;
            EditorEffect.SelectedIndex = SettingsClass.EditorEffectsIndex;


            if (SettingsClass.missionFolderPath != "" && File.Exists(SettingsClass.missionFolderPath + @"\M1.txt") && SettingsClass.PageEnterSFX)
            {

                string partialPath = SettingsClass.missionFolderPath.Substring(0, SettingsClass.missionFolderPath.Length - 14);
                string sfxPath = "";
                double volume = 0;

                int random = new Random().Next(1, 101);

                if (random < 71)
                {
                    sfxPath = partialPath + @"\sfx\VictoryLaugh.mp3";
                    volume = 0.4;
                }
                else if (random > 70 && random < 99)
                {
                    sfxPath = partialPath + @"\sfx\Yuhuu.mp3";
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

        }
        private void EditorEffect_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Get the selected item as a string
            SettingsClass.EditorEffectsIndex = EditorEffect.SelectedIndex;
            SettingsClass.SaveData();
        }

        private void GoToMainPage_Click(object sender, RoutedEventArgs e)
        {
            viewModel.DisplayMainView();
        }

        private void SearchCodes_Click(object sender, RoutedEventArgs e)
        {
            if (InputBeginCode.Text != "" && InputEndCode.Text != "" && InputValueCode.Text != "")
            {
                CreatePnach.SearchValues(InputBeginCode.Text, InputEndCode.Text, InputValueCode.Text);
            }
        }

        private void EuropeanCodes_Click(object sender, RoutedEventArgs e)
        {
            CreatePnach4.EuropeanVersionCodes();
        }

        private void StatsChange_Click(object sender, RoutedEventArgs e)
        {
            bool usingPnachOverHex = true;

            if (!usingPnachOverHex)
            {
                if (!File.Exists(SettingsClass.gameFolderPath + @"\Urban Reign Deluxe.iso"))
                {
                    MessageBox.Show("Rom was not found in the provided folder!\n" +
                        "Make sure your rom name is Urban Reign Deluxe.iso");
                    return;
                }

                bool canWeContinue = false;
                try
                {
                    using (FileStream fs = File.Open(SettingsClass.gameFolderPath + @"\Urban Reign Deluxe.iso", FileMode.Open, FileAccess.ReadWrite, FileShare.None))
                    {
                        canWeContinue = true;
                    }
                }
                catch
                {
                    canWeContinue = false;
                }

                if (!canWeContinue)
                {
                    MessageBox.Show("File is open in another program (possibly PCSX2), close it and try again!");
                    return;
                }
            }

            viewModel.StatsChanged = !viewModel.StatsChanged;
            viewModel.GetToolStatus();

            if (!usingPnachOverHex)
            {
                if (SettingsClass.MasterBradMoves || SettingsClass.GolemBrokenShitMoves || SettingsClass.BordinAllAroundMoves ||
                    SettingsClass.PaulAshesMoves || SettingsClass.BradAndOthersParry)
                {
                    if (viewModel.StatsChanged)
                    {
                        string currentFilePath = SettingsClass.codeFolderPath + @"\" + SettingsClass.PnachName + ".pnach";
                        SettingsClass.PnachName = SettingsClass.MovesAndStatsPnach;
                        string newFilePath = SettingsClass.codeFolderPath + @"\" + SettingsClass.MovesAndStatsPnach + ".pnach";

                        if (File.Exists(currentFilePath))
                        {
                            // Rename the file
                            File.Move(currentFilePath, newFilePath);
                        }

                    }
                    else
                    {
                        string currentFilePath = SettingsClass.codeFolderPath + @"\" + SettingsClass.PnachName + ".pnach";
                        SettingsClass.PnachName = SettingsClass.MovesPnach;
                        string newFilePath = SettingsClass.codeFolderPath + @"\" + SettingsClass.MovesPnach + ".pnach";

                        if (File.Exists(currentFilePath))
                        {
                            // Rename the file
                            File.Move(currentFilePath, newFilePath);
                        }
                    }
                }
                else
                {
                    if (viewModel.StatsChanged)
                    {
                        string currentFilePath = SettingsClass.codeFolderPath + @"\" + SettingsClass.PnachName + ".pnach";
                        SettingsClass.PnachName = SettingsClass.StatsPnach;
                        string newFilePath = SettingsClass.codeFolderPath + @"\" + SettingsClass.StatsPnach + ".pnach";

                        if (File.Exists(currentFilePath))
                        {
                            // Rename the file
                            if (!File.Exists(newFilePath))
                            {
                                // Rename the file
                                File.Move(currentFilePath, newFilePath);
                            }
                        }
                    }
                    else
                    {
                        string currentFilePath = SettingsClass.codeFolderPath + @"\" + SettingsClass.PnachName + ".pnach";
                        SettingsClass.PnachName = SettingsClass.deluxePnach;
                        string newFilePath = SettingsClass.codeFolderPath + @"\" + SettingsClass.deluxePnach + ".pnach";

                        if (File.Exists(currentFilePath))
                        {
                            // Rename the file
                            if (!File.Exists(newFilePath))
                            {
                                // Rename the file
                                File.Move(currentFilePath, newFilePath);
                            }
                        }
                    }
                }
                HexClass.ChangeStats();
            }

            if (usingPnachOverHex)
            {
                ExportPnach.ExportFile("clean stats");
            }
            SettingsClass.SaveData();
        }


        private void SearchCodes_Info(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Use this to manually input a code inside your cheat file. Starting address is the first\n" +
                "address for your code by example 20000000, and last address is the last one by example 20000010 " +
                "and the value is the value of your code let's say 00FF\n" +
                "Now if you hit manual input button these codes will be generated in your cheat file:\n" +
                "patch=1,EE,20000000,extended,000000FF\r\n"+
                "patch=1,EE,20000002,extended,000000FF\r\n"+
                "patch=1,EE,20000004,extended,000000FF\r\n"+
                "patch=1,EE,20000006,extended,000000FF\r\n"+
                "patch=1,EE,20000008,extended,000000FF\r\n"+
                "patch=1,EE,2000000A,extended,000000FF\r\n"+
                "patch=1,EE,2000000C,extended,000000FF\r\n"+
                "patch=1,EE,2000000E,extended,000000FF\r\n"+
                "patch=1,EE,20000010,extended,000000FF\r\n");
        }

        private void EuropeanCodes_Info(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("This button will automatically generate a cheat file in the folder you provided with\n" +
                "the european version cheats, that includes skins swaps at the character selection screen with some " +
                "buttons combination, and game speed change codes (check the cheat file for more information).");
        }


        private void StatsChange_Info(object sender, RoutedEventArgs e)
        {
            if (viewModel.StatsStatus == "ON")
            {
                MessageBox.Show("This button will swap every character default stats to original or custom depending on which value you currently have\n" +
                    "Right now you have Custom stats.");
            }
            else
            {
                MessageBox.Show("This button will swap every character default stats to original or custom depending on which value you currently have\n" +
                    "Right now you have Default stats.");
            }
        }

        private void ModifyGun_Click(object sender, RoutedEventArgs e)
        {
            string upPosValue = SettingUp.Text;
            string normalPosValue = SettingNormal.Text;
            string downPosValue = SettingDown.Text;
            string aiValue = SettingAI.Text;

            CreatePnach6.ModifyGun(upPosValue, normalPosValue, downPosValue, aiValue);
        }

        private void ModifyGun_Info(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Select the moves to use for each position and then activate to modify your gun moveset for all characters.\n" +
                "Have Fun!");
        }

        //private void EditorEffects_Click(object sender, RoutedEventArgs e)
        //{
        //    viewModel.EffectSwap();
        //}

        private void EditorEffects_Info(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("This will swap pnach editor effect with the ones you have available.");
        }

        private void MouseLeftClickSound(object sender, MouseButtonEventArgs e)
        {

            if (viewModel.SfxIsOn)
            {
                viewModel.SoundButton = "/Resources/SoundOff.png";
            }
            else
            {
                viewModel.SoundButton = "/Resources/SoundOn.png";
            }

            viewModel.SfxIsOn = !viewModel.SfxIsOn;
            SettingsClass.PageEnterSFX = viewModel.SfxIsOn;
            SettingsClass.SaveData();
        }


        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            this.Focus(); // Ensure the Window gets keyboard input
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            // Check if either Shift key is held down
            if (Keyboard.IsKeyDown(Key.LeftShift) || Keyboard.IsKeyDown(Key.RightShift))
            {
                if (e.Key == Key.Oem3 || e.Key == Key.Multiply)
                {
                    viewModel.DisplayMainView();
                }
                else if (e.Key == Key.D1 || e.Key == Key.NumPad1)
                {
                    viewModel.DisplayStatsView();
                }
                else if (e.Key == Key.D2 || e.Key == Key.NumPad2)
                {
                    viewModel.DisplayTextureView();
                }
                else if (e.Key == Key.D3 || e.Key == Key.NumPad3)
                {
                    viewModel.DisplayCharacterView();
                }
                else if (e.Key == Key.D4 || e.Key == Key.NumPad4)
                {
                    viewModel.DisplayModelsAndMusicView();
                }
                else if (e.Key == Key.D5 || e.Key == Key.NumPad5)
                {
                    viewModel.DisplayChallengeView();
                }
                else if (e.Key == Key.D6 || e.Key == Key.NumPad6)
                {
                    viewModel.DisplayMovesetView();
                }
                else if (e.Key == Key.D7 || e.Key == Key.NumPad7)
                {
                    viewModel.DisplayChallengeModeView();
                }
                else if (e.Key == Key.D8 || e.Key == Key.NumPad8)
                {
                    viewModel.DisplayDeveloperView();
                }
                else if (e.Key == Key.D9 || e.Key == Key.NumPad9)
                {
                    viewModel.DisplayMiscellaneousCheatsView();
                }
                else if (e.Key == Key.D0 || e.Key == Key.NumPad0)
                {
                    viewModel.DisplayMysteriousView();
                }
            }
        }
    }




}
