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
using WpfAnimatedGif;

namespace UR_pnach_editor.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MysteriousView : UserControl
    {
        MysteriousViewModel viewModel;


        public MysteriousView()
        {
            //if (!ConfigClass.isConfigFileLoaded)
            //{
            //    ConfigClass.LoadData();
            //    ConfigClass.isConfigFileLoaded = true;
            //}

            InitializeComponent();



            viewModel = new();

            this.DataContext = viewModel;


            SettingsClass.LoadData();

            int random = 0;

            random = new Random().Next(1, 25);
            viewModel.AnimatedSource = @"pack://application:,,,/Resources/movie" + random + ".gif";
            random = new Random().Next(1, 25);
            viewModel.AnimatedSource2 = @"pack://application:,,,/Resources/movie" + random + ".gif";
            random = new Random().Next(1, 25);
            viewModel.AnimatedSource3 = @"pack://application:,,,/Resources/movie" + random + ".gif";

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

            if (SettingsClass.missionFolderPath != "" && File.Exists(SettingsClass.missionFolderPath + @"\M1.txt") && SettingsClass.PageEnterSFX)
            {
                string partialPath = SettingsClass.missionFolderPath.Substring(0, SettingsClass.missionFolderPath.Length - 14);
                string sfxPath = "";
                double volume = 0;

                sfxPath = partialPath + @"\sfx\Gipsy_Laugh.mp3";
                volume = 0.4;

                customSound.Source = new Uri(sfxPath);
                customSound.Volume = volume;

            }

            DifficultyBox.ItemsSource = viewModel.Difficulty_List;
            DifficultyBox.SelectedItem = viewModel.Difficulty_List[2];
            EnemiesBox.ItemsSource = viewModel.EnemyNumbers_List;
            EnemiesBox.SelectedItem = viewModel.EnemyNumbers_List[1];
            EnemiesDifBox.ItemsSource = viewModel.EnemyDifficulty_List;
            EnemiesDifBox.SelectedItem = viewModel.EnemyDifficulty_List[2];
            ChallengeFormatBox.ItemsSource = viewModel.ChallengeFormat_List;
            ChallengeFormatBox.SelectedItem = viewModel.ChallengeFormat_List[0];
        }
        

        private void GenerateCodes_Click(object sender, RoutedEventArgs e)
        {
            viewModel.GenerateModifiers(Convert.ToString(DifficultyBox.SelectedItem), Convert.ToInt32(EnemiesBox.SelectedItem),
                Convert.ToString(EnemiesDifBox.SelectedItem), Convert.ToString(ChallengeFormatBox.SelectedItem));
        }

        private void GoToMainPage_Click(object sender, RoutedEventArgs e)
        {
            viewModel.DisplayMainView();
        }

        private void Modifiers_Info(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Use this settings with Challenge mode to have an experience like never before. Everyone will get random buffs" +
                "and debuffs at random bassed on the modifier difficulty you select.\n" +
                "Remember to also do the in game settings combined with this ones otherwise problems will appear.\n" +
                "Go and have some fun, Mortal Kombat style!");
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
