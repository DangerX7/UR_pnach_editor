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
using System.Diagnostics;
using WpfAnimatedGif;
using System.Windows.Threading;

namespace UR_pnach_editor.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MiscellaneousCheatsView : UserControl
    {
        MiscellaneousCheatsViewModel viewModel;

        private DispatcherTimer timer2;


        public MiscellaneousCheatsView()
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


            //was code activated?
            timer2 = new DispatcherTimer();
            timer2.Interval = TimeSpan.FromSeconds(2);
            timer2.Tick += Timer2_Tick;

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
                    sfxPath = partialPath + @"\sfx\JapaneseWord.mp3";
                    volume = 0.4;
                }
                else if (random > 70 && random < 99)
                {
                    sfxPath = partialPath + @"\sfx\Here_I_Come.mp3";
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




        private void GoToMainPage_Click(object sender, RoutedEventArgs e)
        {
            viewModel.DisplayMainView();
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            CreatePnach.ClearCodes();
            viewModel.CodeString = "None";
            CodeText.Foreground = Brushes.Yellow;
            timer2.Start();
        }

        private void x2PlayersFullFreeMode_Click(object sender, RoutedEventArgs e)
        {
            CreatePnach7.x2PlayersFullFreeMode();
            viewModel.CodeString = "2 Players Full Free Mode";
            CodeText.Foreground = Brushes.Yellow;
            timer2.Start();
        }

        private void x2PlayersFullFreeMode_MouseEnter(object sender, MouseEventArgs e)
        {
            viewModel.ModeInformation =
                "It will set Solo Missions and specific Partner missions into allowing you to have any partner.\n" +
                "It will break timer for Timed Missions.\n" +
                "Camera is switched to multiplayer camera for a better party experience. \n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n";
        }

        private void x3PlayersFullFreeMode_Click(object sender, RoutedEventArgs e)
        {
            CreatePnach7.x3PlayersFullFreeMode();
            viewModel.CodeString = "3 Players Full Free Mode";
            CodeText.Foreground = Brushes.Yellow;
            timer2.Start();
        }

        private void x3PlayersFullFreeMode_MouseEnter(object sender, MouseEventArgs e)
        {
            viewModel.ModeInformation =
                "It will force the first enemy to be controlled by Player 3, P3 become ally to P1 and P2, player is defeated automatically once all enemies are defeated.\n" +
                "It will break timer for Timed Missions.\n" +
                "Camera is switched to multiplayer camera for a better party experience. \n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n";
        }

        private void x4PlayersFullFreeMode_Click(object sender, RoutedEventArgs e)
        {
            CreatePnach7.x4PlayersFullFreeMode();
            viewModel.CodeString = "4 Players Full Free Mode";
            CodeText.Foreground = Brushes.Yellow;
            timer2.Start();
        }

        private void x4PlayersFullFreeMode_MouseEnter(object sender, MouseEventArgs e)
        {
            viewModel.ModeInformation =
                "It will force the first enemy and second enemy to be controlled by Player 3 and Player 4,they become allies to P1 and P2, player is defeated automatically once all enemies are defeated.\n" +
                "It will break timer for Timed Missions.\n" +
                "Camera is switched to multiplayer camera for a better party experience. \n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n";
        }

        private void BradsDeluxeOffensive_Click(object sender, RoutedEventArgs e)
        {
            CreatePnach7.BradsDeluxeOffensive();
            viewModel.CodeString = "Brads Deluxe Offensive";
            CodeText.Foreground = Brushes.Yellow;
            timer2.Start();
        }

        private void BradsDeluxeOffensive_MouseEnter(object sender, MouseEventArgs e)
        {
            viewModel.ModeInformation =
                "When using Brad's SPA will cause it's offensive status to be changed for Deluxe version, it only works for P1 as Brad and in vanilla version.\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n";
        }

        private void GolemsBossRush_Click(object sender, RoutedEventArgs e)
        {
            CreatePnach7.GolemsBossRush();
            viewModel.CodeString = "Golems Boss Rush";
            CodeText.Foreground = Brushes.Yellow;
            timer2.Start();
        }

        private void GolemsBossRush_MouseEnter(object sender, MouseEventArgs e)
        {
            viewModel.ModeInformation =
                "Missions 86, 91 and 93 will cause Golem's moveset to change to other characters,Glen during Mission 86, Jake during mission 91 and whoever your partner is on 93.\n" +
                "if you have Brad as your partner on mission 93, Golem will use its default moveset instead .\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n";
        }

        private void HealingSPA_Click(object sender, RoutedEventArgs e)
        {
            CreatePnach7.HealingSPA();
            viewModel.CodeString = "Healing SPA";
            CodeText.Foreground = Brushes.Yellow;
            timer2.Start();
        }

        private void HealingSPA_MouseEnter(object sender, MouseEventArgs e)
        {
            viewModel.ModeInformation =
                "Using the SPA will recharge your health by 100, Made for Multiplayer.\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n";
        }

        private void BradStyleSwitching_Click(object sender, RoutedEventArgs e)
        {
            CreatePnach7.BradStyleSwitching();
            viewModel.CodeString = "Brad Style Switching";
            CodeText.Foreground = Brushes.Yellow;
            timer2.Start();
        }

        private void BradStyleSwitching_MouseEnter(object sender, MouseEventArgs e)
        {
            viewModel.ModeInformation =
                "Brad's taunt button now switch between two styles, All-Round and a custom made one.\n" +
                "Not alot of moves have been changed between both styles but it can give you the idea of style switching in Urban Reign.\n" +
                "Brad must be used by Player 1 for style switching to work correctly and also using the SPA Aura will cause your style to goes back to All-Round,\n" +
                "this code was made for vanilla version.\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n";
        }

        private void SPAMode_Click(object sender, RoutedEventArgs e)
        {
            CreatePnach7.SPAMode();
            viewModel.CodeString = "SPA Mode";
            CodeText.Foreground = Brushes.Yellow;
            timer2.Start();
        }

        private void SPAMode_MouseEnter(object sender, MouseEventArgs e)
        {
            viewModel.ModeInformation =
                "This pnach is based on Yakuza franchise's Heat mode, SPA Mode have two levels, \n" +
                "when you're able to use standing SPA(Circle + Cross), you reach level 1 which cause you to use Offensive SPA Aura and once your SPA Bar reach almost to the end, \n" +
                "it will enter level 2 which cause you to use Golem's SPA Aura, don't bother to use SPA Aura by yourself as the SPA effect stays the same, this works for P1-P4(Multiplayer)\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n";
        }
        private void NewGamePlus_Click(object sender, RoutedEventArgs e)
        {
            CreatePnach7.NewGamePlus();
            viewModel.CodeString = "New Game Plus";
            CodeText.Foreground = Brushes.Yellow;
            timer2.Start();
        }

        private void NewGamePlus_MouseEnter(object sender, MouseEventArgs e)
        {
            viewModel.ModeInformation =
                "Get ready for a new experince! \n" +
                "In the new game plus features we have: \n" +
                "-partner available in every mission \n" +
                "-more enemies \n" +
                "-tougher enemies \n" +
                "and a few more surprises \n" +
                "In this mode an AI (with Golem AI from story) will be your partner. \n" +
                "This is made to work on Story Mode, it's not tested for Free Mode.\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n";
        }

        private void NewGamePlus2Players_Click(object sender, RoutedEventArgs e)
        {
            CreatePnach7.x2PlayersNewGamePlus();
            viewModel.CodeString = "2 Players New Game Plus";
            CodeText.Foreground = Brushes.Yellow;
            timer2.Start();
        }

        private void NewGamePlus2Players_MouseEnter(object sender, MouseEventArgs e)
        {
            viewModel.ModeInformation =
                "Get ready for a new experince! \n" +
                "In the new game plus features we have: \n" +
                "-partner available in every mission \n" +
                "-more enemies \n" +
                "-tougher enemies \n" +
                "and a few more surprises \n" +
                "In this mode player 2 will be your partner. \n" +
                "Camera is switched to multiplayer camera for a better party experience. \n" +
                "This is made to work on Story Mode, it's not tested for Free Mode.\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n";
        }


        private void Timer2_Tick(object sender, EventArgs e)
        {
            CodeText.Foreground = Brushes.White; // Reset the color to the original
            timer2.Stop();
        }

    }




}
