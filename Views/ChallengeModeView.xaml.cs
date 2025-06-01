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
using NAudio.Wave;
using System.Windows.Threading;
using WpfAnimatedGif;

namespace UR_pnach_editor.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class ChallengeModeView : UserControl
    {
        ChallengeModeViewModel viewModel;

        private DispatcherTimer timer;

        public ChallengeModeView()
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
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(2);
            timer.Tick += Timer_Tick;


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
                    sfxPath = partialPath + @"\sfx\Brad_ComeOn.mp3";
                    volume = 0.4;
                }
                else if (random > 70 && random < 99)
                {
                    sfxPath = partialPath + @"\sfx\Hey_ComeOn.mp3";
                    volume = 0.4;
                }
                else
                {
                    sfxPath = partialPath + @"\sfx\Gipsy_Laugh.mp3";
                    volume = 0.25;
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
            timer.Start();
        }

        private void AmateurPlayerTeam_Click(object sender, RoutedEventArgs e)
        {
            CreatePnach5.AmateurPlayerTeam();
            viewModel.CodeString = "Amateur Player Team";
            CodeText.Foreground = Brushes.Yellow;
            timer.Start();
        }

        private void RedSPAEnemyTeam_Click(object sender, RoutedEventArgs e)
        {
            CreatePnach5.RedSPAEnemyTeam();
            viewModel.CodeString = "Angry Enemy Team";
            CodeText.Foreground = Brushes.Yellow;
            timer.Start();
        }

        private void MasterEnemyTeam_Click(object sender, RoutedEventArgs e)
        {
            CreatePnach5.MasterEnemyTeam();
            viewModel.CodeString = "Master Enemy Team";
            CodeText.Foreground = Brushes.Yellow;
            timer.Start();
        }

        private void TankEnemyTeam_Click(object sender, RoutedEventArgs e)
        {
            CreatePnach5.TankEnemyTeam();
            viewModel.CodeString = "Tank Enemy Team";
            CodeText.Foreground = Brushes.Yellow;
            timer.Start();
        }

        private void ToughEnemyTeam_Click(object sender, RoutedEventArgs e)
        {
            CreatePnach5.ToughEnemyTeam();
            viewModel.CodeString = "Tough Enemy Team";
            CodeText.Foreground = Brushes.Yellow;
            timer.Start();
        }

        private void RecoverEnemyTeam_Click(object sender, RoutedEventArgs e)
        {
            CreatePnach5.RecoverEnemyTeam();
            viewModel.CodeString = "Recover Enemy Team";
            CodeText.Foreground = Brushes.Yellow;
            timer.Start();
        }

        private void StrongEnemyTeam_Click(object sender, RoutedEventArgs e)
        {
            CreatePnach5.StrongEnemyTeam();
            viewModel.CodeString = "Strong Enemy Team";
            CodeText.Foreground = Brushes.Yellow;
            timer.Start();
        }

        private void ExtremeEnemyTeam_Click(object sender, RoutedEventArgs e)
        {
            CreatePnach5.ExtremeEnemyTeam();
            viewModel.CodeString = "Extreme Enemy Team";
            CodeText.Foreground = Brushes.Yellow;
            timer.Start();
        }

        private void FairEnemyTeam_Click(object sender, RoutedEventArgs e)
        {
            CreatePnach5.FairEnemyTeam();
            viewModel.CodeString = "Fair Enemy Team";
            CodeText.Foreground = Brushes.Yellow;
            timer.Start();
        }

        private void OneHitEnemyTeam_Click(object sender, RoutedEventArgs e)
        {
            CreatePnach5.OneHitEnemyTeam();
            viewModel.CodeString = "One-Hit Enemy Team";
            CodeText.Foreground = Brushes.Yellow;
            timer.Start();
        }

        private void FairPlayerTeam_Click(object sender, RoutedEventArgs e)
        {
            CreatePnach5.FairPlayerTeam();
            viewModel.CodeString = "Fair Player Team";
            CodeText.Foreground = Brushes.Yellow;
            timer.Start();
        }
        private void UltimatePlayerTeam_Click(object sender, RoutedEventArgs e)
        {
            CreatePnach5.UltimatePlayerTeam();
            viewModel.CodeString = "Ultimate Player Team";
            CodeText.Foreground = Brushes.Yellow;
            timer.Start();
        }



        private void AmateurPlayerTeam_MouseEnter(object sender, MouseEventArgs e)
        {
            viewModel.ModeInformation = "Player Team \n" +
                "500 points all stats (1 star character) \n" +
                "\n" +
                "Enemy Team \n" +
                "Nothing Changed\n" +
                "\n" +
                "Side Notes\n" +
                "Test your might against Max Power opponents!\n" +
                "\n" +
                "Difficulty ★★★\n";
        }

        private void RedSPAEnemyTeam_MouseEnter(object sender, MouseEventArgs e)
        {
            viewModel.ModeInformation = "Player Team \n" +
                "Nothing Changed\n" +
                "\n" +
                "Enemy Team \n" +
                "Infinite Red Aura (Increased attack)\n" +
                "\n" +
                "Side Notes\n" +
                "Watch out for enemy attacks!\n" +
                "\n" +
                "Difficulty ★★\n";
        }

        private void MasterEnemyTeam_MouseEnter(object sender, MouseEventArgs e)
        {
            viewModel.ModeInformation = "Player Team \n" +
                "Nothing Changed\n" +
                "\n" +
                "Enemy Team \n" +
                "Infinite Blue Aura (Parry all attacks and throws)\n" +
                "\n" +
                "Side Notes\n" +
                "Try team attacks and Spa attacks!\n" +
                "\n" +
                "Difficulty ★★★★★\n";
        }

        private void TankEnemyTeam_MouseEnter(object sender, MouseEventArgs e)
        {
            viewModel.ModeInformation = "Player Team \n" +
                "Nothing Changed\n" +
                "\n" +
                "Enemy Team \n" +
                "Infinite Yellow Aura (Does not flinch when they are hit)\n" +
                "\n" +
                "Side Notes\n" +
                "This is a throw challenge, avoid using regular attacks!\n" +
                "\n" +
                "Difficulty ★★★★\n";
        }

        private void ToughEnemyTeam_MouseEnter(object sender, MouseEventArgs e)
        {
            viewModel.ModeInformation = "Player Team \n" +
                "Nothing Changed\n" +
                "\n" +
                "Enemy Team \n" +
                "2000 Thoughness (Double Golem HP)\n" +
                "\n" +
                "Side Notes\n" +
                "This is going to be a long fight, good luck!\n" +
                "\n" +
                "Difficulty ★★★\n";
        }

        private void RecoverEnemyTeam_MouseEnter(object sender, MouseEventArgs e)
        {
            viewModel.ModeInformation = "Player Team \n" +
                "Nothing Changed\n" +
                "\n" +
                "Enemy Team \n" +
                "20% SPA bar recovery per hit taken\n" +
                "\n" +
                "Side Notes\n" +
                "Try to use attacks that gives a lot of damage!\n" +
                "\n" +
                "Difficulty ★★★✩\n";
        }

        private void StrongEnemyTeam_MouseEnter(object sender, MouseEventArgs e)
        {
            viewModel.ModeInformation = "Player Team \n" +
                "Nothing Changed\n" +
                "\n" +
                "Enemy Team \n" +
                "1500 points all stats (7 star character) \n" +
                "\n" +
                "Side Notes\n" +
                "All around strong opponents, do your best!\n" +
                "\n" +
                "Difficulty ★★★\n";
        }

        private void ExtremeEnemyTeam_MouseEnter(object sender, MouseEventArgs e)
        {
            viewModel.ModeInformation = "Player Team \n" +
                "Nothing Changed\n" +
                "\n" +
                "Enemy Team \n" +
                "opponent 1 very strong attack but low defense \n" +
                "opponent 2 very strong defense but low attack \n" +
                "\n" +
                "Side Notes\n" +
                "Better target the one with low def first!\n" +
                "\n" +
                "Difficulty ★★★★\n";
        }

        private void FairEnemyTeam_MouseEnter(object sender, MouseEventArgs e)
        {
            viewModel.ModeInformation = "Player Team \n" +
                "Nothing Changed\n" +
                "\n" +
                "Enemy Team \n" +
                "2000 points all stats (10 star character) \n" +
                "No SPA (empty spa bar forever)\n" +
                "\n" +
                "Side Notes\n" +
                "Enemy is strong but they play fair!\n" +
                "\n" +
                "Difficulty ★★★✩\n";
        }

        private void OneHitEnemyTeam_MouseEnter(object sender, MouseEventArgs e)
        {
            viewModel.ModeInformation = "Player Team \n" +
                "Very low Defense\n" +
                "\n" +
                "Enemy Team \n" +
                "One hit kills you\n" +
                "\n" +
                "Side Notes\n" +
                "Enemies will wipe you out in one hit!\n" +
                "\n" +
                "Difficulty ★★★★★★★★★★\n";
        }

        private void FairPlayerTeam_MouseEnter(object sender, MouseEventArgs e)
        {
            viewModel.ModeInformation = "Player Team \n" +
                "No SPA (empty spa bar forever)\n" +
                "\n" +
                "Enemy Team \n" +
                "Nothing Changed\n" +
                "\n" +
                "Side Notes\n" +
                "No SPA usage in this one, but enemies can!\n" +
                "\n" +
                "Difficulty ★★★\n";
        }

        private void UltimatePlayerTeam_MouseEnter(object sender, MouseEventArgs e)
        {
            viewModel.ModeInformation = "Player Team \n" +
                "2000 points all stats (10 star character)\n" +
                "\n" +
                "Enemy Team \n" +
                "Nothing Changed\n" +
                "\n" +
                "Side Notes\n" +
                "This one is good to use it as Time Attack!\n" +
                "\n" +
                "Difficulty ★\n";
        }

        private void GoMultiplayerChallengesPage_Click(object sender, RoutedEventArgs e)
        {
            viewModel.DisplayChallengeView();
        }



        private void Timer_Tick(object sender, EventArgs e)
        {
            CodeText.Foreground = Brushes.White; // Reset the color to the original
            timer.Stop();
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
