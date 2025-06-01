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
using UR_pnach_editor.ViewModels;
using OfficeOpenXml;
using System.IO;
using System.Data;
using UR_pnach_editor.Codes;
using System.Windows.Media.Media3D;
using UR_pnach_editor.Services;
using NAudio.Wave;
using System.Net.Sockets;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using WpfAnimatedGif;
using System.Windows.Threading;

namespace UR_pnach_editor.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class CharacterView : UserControl
    {
        CharacterViewModel viewModel;
        public int selectedPlayer = 0;
        public int player1Char = 0;
        public int player2Char = 0;
        public int player3Char = 0;
        public int player4Char = 0;
        public int player5Char = 0;
        public int player6Char = 0;
        public int player7Char = 0;
        public int player8Char = 0;

        public string charactersCode = "";
        public string missionCode = "";

        private DispatcherTimer timer2;

        public CharacterView()
        {

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

            enemyAIbox.ItemsSource = viewModel.AIList;
            enemyAIbox.SelectedIndex = 0;



            if (SettingsClass.missionFolderPath != "" && File.Exists(SettingsClass.missionFolderPath + @"\M1.txt") && SettingsClass.PageEnterSFX)
            {
                string partialPath = SettingsClass.missionFolderPath.Substring(0, SettingsClass.missionFolderPath.Length - 14);
                string sfxPath = "";
                double volume = 0;

                int random = new Random().Next(1, 101);

                if (random < 71)
                {
                    sfxPath = partialPath + @"\sfx\Brad_OhYeah.mp3";
                    volume = 1.0;
                }
                else if (random > 70 && random < 99)
                {
                    sfxPath = partialPath + @"\sfx\WeGonnaTakeYouDown.mp3";
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


            P1Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/tile063.png", UriKind.Relative)) };
            P2Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/tile063.png", UriKind.Relative)) };
            P3Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/tile063.png", UriKind.Relative)) };
            P4Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/tile063.png", UriKind.Relative)) };
            P5Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/tile063.png", UriKind.Relative)) };
            P6Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/tile063.png", UriKind.Relative)) };
            P7Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/tile063.png", UriKind.Relative)) };
            P8Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/tile063.png", UriKind.Relative)) };

            SwitchToMultiplayer();
        }



        private void P1StatsModifier_Click(object sender, RoutedEventArgs e)
        {
            selectedPlayer = 1;
            AllChar.Content = "P1";
        }

        private void P2StatsModifier_Click(object sender, RoutedEventArgs e)
        {
            selectedPlayer = 2;
            AllChar.Content = "P2";
        }

        private void P3StatsModifier_Click(object sender, RoutedEventArgs e)
        {
            selectedPlayer = 3;
            AllChar.Content = "P3";
        }

        private void P4StatsModifier_Click(object sender, RoutedEventArgs e)
        {
            selectedPlayer = 4;
            AllChar.Content = "P4";
        }

        private void P5StatsModifier_Click(object sender, RoutedEventArgs e)
        {
            selectedPlayer = 5;
            AllChar.Content = "P5";
        }

        private void P6StatsModifier_Click(object sender, RoutedEventArgs e)
        {
            selectedPlayer = 6;
            AllChar.Content = "P6";
        }

        private void P7StatsModifier_Click(object sender, RoutedEventArgs e)
        {
            selectedPlayer = 7;
            AllChar.Content = "P7";
        }

        private void P8StatsModifier_Click(object sender, RoutedEventArgs e)
        {
            selectedPlayer = 8;
            AllChar.Content = "P8";
        }


        private void EveryoneStatsModifier_Click(object sender, RoutedEventArgs e)
        {
            if (!viewModel.SelectedMode)
            {
                selectedPlayer = 100;
            }
            else
            {
                selectedPlayer = 99;
            }
            AllChar.Content = "ALL";
        }



        #region Characters Avatars

        private void Napalm_Click(object sender, RoutedEventArgs e)
        {
            switch (selectedPlayer)
            {
                case 1:
                    P1Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_101.png", UriKind.Relative)) };
                    player1Char = 1;
                    break;
                case 2:
                    P2Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_101.png", UriKind.Relative)) };
                    player2Char = 1;
                    break;
                case 3:
                    P3Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_101.png", UriKind.Relative)) };
                    player3Char = 1;
                    break;
                case 4:
                    P4Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_101.png", UriKind.Relative)) };
                    player4Char = 1;
                    break;
                case 5:
                    P5Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_101.png", UriKind.Relative)) };
                    player5Char = 1;
                    break;
                case 6:
                    P6Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_101.png", UriKind.Relative)) };
                    player6Char = 1;
                    break;
                case 7:
                    P7Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_101.png", UriKind.Relative)) };
                    player7Char = 1;
                    break;
                case 8:
                    P8Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_101.png", UriKind.Relative)) };
                    player8Char = 1;
                    break;
                case 99:
                    P1Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_101.png", UriKind.Relative)) };
                    player1Char = 1;
                    P2Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_101.png", UriKind.Relative)) };
                    player2Char = 1;
                    P3Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_101.png", UriKind.Relative)) };
                    player3Char = 1;
                    P4Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_101.png", UriKind.Relative)) };
                    player4Char = 1;
                    P5Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_101.png", UriKind.Relative)) };
                    player5Char = 1;
                    P6Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_101.png", UriKind.Relative)) };
                    player6Char = 1;
                    P7Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_101.png", UriKind.Relative)) };
                    player7Char = 1;
                    P8Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_101.png", UriKind.Relative)) };
                    player8Char = 1;
                    break;
                case 100:
                    P3Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_101.png", UriKind.Relative)) };
                    player3Char = 1;
                    P4Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_101.png", UriKind.Relative)) };
                    player4Char = 1;
                    P5Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_101.png", UriKind.Relative)) };
                    player5Char = 1;
                    P6Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_101.png", UriKind.Relative)) };
                    player6Char = 1;
                    P7Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_101.png", UriKind.Relative)) };
                    player7Char = 1;
                    P8Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_101.png", UriKind.Relative)) };
                    player8Char = 1;
                    break;
            }

        }

        private void Shinkai_Click(object sender, RoutedEventArgs e)
        {
            switch (selectedPlayer)
            {
                case 1:
                    P1Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_102.png", UriKind.Relative)) };
                    player1Char = 2;
                    break;
                case 2:
                    P2Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_102.png", UriKind.Relative)) };
                    player2Char = 2;
                    break;
                case 3:
                    P3Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_102.png", UriKind.Relative)) };
                    player3Char = 2;
                    break;
                case 4:
                    P4Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_102.png", UriKind.Relative)) };
                    player4Char = 2;
                    break;
                case 5:
                    P5Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_102.png", UriKind.Relative)) };
                    player5Char = 2;
                    break;
                case 6:
                    P6Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_102.png", UriKind.Relative)) };
                    player6Char = 2;
                    break;
                case 7:
                    P7Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_102.png", UriKind.Relative)) };
                    player7Char = 2;
                    break;
                case 8:
                    P8Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_102.png", UriKind.Relative)) };
                    player8Char = 2;
                    break;
                case 99:
                    P1Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_102.png", UriKind.Relative)) };
                    player1Char = 2;
                    P2Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_102.png", UriKind.Relative)) };
                    player2Char = 2;
                    P3Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_102.png", UriKind.Relative)) };
                    player3Char = 2;
                    P4Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_102.png", UriKind.Relative)) };
                    player4Char = 2;
                    P5Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_102.png", UriKind.Relative)) };
                    player5Char = 2;
                    P6Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_102.png", UriKind.Relative)) };
                    player6Char = 2;
                    P7Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_102.png", UriKind.Relative)) };
                    player7Char = 2;
                    P8Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_102.png", UriKind.Relative)) };
                    player8Char = 2;
                    break;
                case 100:
                    P3Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_102.png", UriKind.Relative)) };
                    player3Char = 2;
                    P4Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_102.png", UriKind.Relative)) };
                    player4Char = 2;
                    P5Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_102.png", UriKind.Relative)) };
                    player5Char = 2;
                    P6Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_102.png", UriKind.Relative)) };
                    player6Char = 2;
                    P7Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_102.png", UriKind.Relative)) };
                    player7Char = 2;
                    P8Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_102.png", UriKind.Relative)) };
                    player8Char = 2;
                    break;
            }

        }

        private void Suspect_Click(object sender, RoutedEventArgs e)//////////
        {
            switch (selectedPlayer)
            {
                case 1:
                    P1Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_103.png", UriKind.Relative)) };
                    player1Char = 3;
                    break;
                case 2:
                    P2Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_103.png", UriKind.Relative)) };
                    player2Char = 3;
                    break;
                case 3:
                    P3Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_103.png", UriKind.Relative)) };
                    player3Char = 3;
                    break;
                case 4:
                    P4Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_103.png", UriKind.Relative)) };
                    player4Char = 3;
                    break;
                case 5:
                    P5Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_103.png", UriKind.Relative)) };
                    player5Char = 3;
                    break;
                case 6:
                    P6Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_103.png", UriKind.Relative)) };
                    player6Char = 3;
                    break;
                case 7:
                    P7Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_103.png", UriKind.Relative)) };
                    player7Char = 3;
                    break;
                case 8:
                    P8Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_103.png", UriKind.Relative)) };
                    player8Char = 3;
                    break;
                case 99:
                    P1Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_103.png", UriKind.Relative)) };
                    player1Char = 3;
                    P2Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_103.png", UriKind.Relative)) };
                    player2Char = 3;
                    P3Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_103.png", UriKind.Relative)) };
                    player3Char = 3;
                    P4Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_103.png", UriKind.Relative)) };
                    player4Char = 3;
                    P5Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_103.png", UriKind.Relative)) };
                    player5Char = 3;
                    P6Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_103.png", UriKind.Relative)) };
                    player6Char = 3;
                    P7Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_103.png", UriKind.Relative)) };
                    player7Char = 3;
                    P8Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_103.png", UriKind.Relative)) };
                    player8Char = 3;
                    break;
                case 100:
                    P3Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_103.png", UriKind.Relative)) };
                    player3Char = 3;
                    P4Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_103.png", UriKind.Relative)) };
                    player4Char = 3;
                    P5Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_103.png", UriKind.Relative)) };
                    player5Char = 3;
                    P6Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_103.png", UriKind.Relative)) };
                    player6Char = 3;
                    P7Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_103.png", UriKind.Relative)) };
                    player7Char = 3;
                    P8Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_103.png", UriKind.Relative)) };
                    player8Char = 3;
                    break;
            }
        }

        private void Kadonashi_Click(object sender, RoutedEventArgs e)
        {
            switch (selectedPlayer)
            {
                case 1:
                    P1Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_104.png", UriKind.Relative)) };
                    player1Char = 4;
                    break;
                case 2:
                    P2Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_104.png", UriKind.Relative)) };
                    player2Char = 4;
                    break;
                case 3:
                    P3Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_104.png", UriKind.Relative)) };
                    player3Char = 4;
                    break;
                case 4:
                    P4Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_104.png", UriKind.Relative)) };
                    player4Char = 4;
                    break;
                case 5:
                    P5Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_104.png", UriKind.Relative)) };
                    player5Char = 4;
                    break;
                case 6:
                    P6Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_104.png", UriKind.Relative)) };
                    player6Char = 4;
                    break;
                case 7:
                    P7Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_104.png", UriKind.Relative)) };
                    player7Char = 4;
                    break;
                case 8:
                    P8Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_104.png", UriKind.Relative)) };
                    player8Char = 4;
                    break;
                case 99:
                    P1Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_104.png", UriKind.Relative)) };
                    player1Char = 4;
                    P2Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_104.png", UriKind.Relative)) };
                    player2Char = 4;
                    P3Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_104.png", UriKind.Relative)) };
                    player3Char = 4;
                    P4Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_104.png", UriKind.Relative)) };
                    player4Char = 4;
                    P5Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_104.png", UriKind.Relative)) };
                    player5Char = 4;
                    P6Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_104.png", UriKind.Relative)) };
                    player6Char = 4;
                    P7Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_104.png", UriKind.Relative)) };
                    player7Char = 4;
                    P8Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_104.png", UriKind.Relative)) };
                    player8Char = 4;
                    break;
                case 100:
                    P3Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_104.png", UriKind.Relative)) };
                    player3Char = 4;
                    P4Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_104.png", UriKind.Relative)) };
                    player4Char = 4;
                    P5Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_104.png", UriKind.Relative)) };
                    player5Char = 4;
                    P6Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_104.png", UriKind.Relative)) };
                    player6Char = 4;
                    P7Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_104.png", UriKind.Relative)) };
                    player7Char = 4;
                    P8Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_104.png", UriKind.Relative)) };
                    player8Char = 4;
                    break;
            }
        }

        private void BradShark_Click(object sender, RoutedEventArgs e)
        {
            switch (selectedPlayer)
            {
                case 1:
                    P1Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_105.png", UriKind.Relative)) };
                    player1Char = 5;
                    break;
                case 2:
                    P2Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_105.png", UriKind.Relative)) };
                    player2Char = 5;
                    break;
                case 3:
                    P3Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_105.png", UriKind.Relative)) };
                    player3Char = 5;
                    break;
                case 4:
                    P4Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_105.png", UriKind.Relative)) };
                    player4Char = 5;
                    break;
                case 5:
                    P5Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_105.png", UriKind.Relative)) };
                    player5Char = 5;
                    break;
                case 6:
                    P6Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_105.png", UriKind.Relative)) };
                    player6Char = 5;
                    break;
                case 7:
                    P7Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_105.png", UriKind.Relative)) };
                    player7Char = 5;
                    break;
                case 8:
                    P8Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_105.png", UriKind.Relative)) };
                    player8Char = 5;
                    break;
                case 99:
                    P1Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_105.png", UriKind.Relative)) };
                    player1Char = 5;
                    P2Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_105.png", UriKind.Relative)) };
                    player2Char = 5;
                    P3Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_105.png", UriKind.Relative)) };
                    player3Char = 5;
                    P4Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_105.png", UriKind.Relative)) };
                    player4Char = 5;
                    P5Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_105.png", UriKind.Relative)) };
                    player5Char = 5;
                    P6Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_105.png", UriKind.Relative)) };
                    player6Char = 5;
                    P7Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_105.png", UriKind.Relative)) };
                    player7Char = 5;
                    P8Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_105.png", UriKind.Relative)) };
                    player8Char = 5;
                    break;
                case 100:
                    P3Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_105.png", UriKind.Relative)) };
                    player3Char = 5;
                    P4Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_105.png", UriKind.Relative)) };
                    player4Char = 5;
                    P5Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_105.png", UriKind.Relative)) };
                    player5Char = 5;
                    P6Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_105.png", UriKind.Relative)) };
                    player6Char = 5;
                    P7Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_105.png", UriKind.Relative)) };
                    player7Char = 5;
                    P8Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_105.png", UriKind.Relative)) };
                    player8Char = 5;
                    break;
            }
        }

        private void ElMiguel_Click(object sender, RoutedEventArgs e)
        {
            switch (selectedPlayer)
            {
                case 1:
                    P1Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_106.png", UriKind.Relative)) };
                    player1Char = 6;
                    break;
                case 2:
                    P2Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_106.png", UriKind.Relative)) };
                    player2Char = 6;
                    break;
                case 3:
                    P3Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_106.png", UriKind.Relative)) };
                    player3Char = 6;
                    break;
                case 4:
                    P4Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_106.png", UriKind.Relative)) };
                    player4Char = 6;
                    break;
                case 5:
                    P5Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_106.png", UriKind.Relative)) };
                    player5Char = 6;
                    break;
                case 6:
                    P6Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_106.png", UriKind.Relative)) };
                    player6Char = 6;
                    break;
                case 7:
                    P7Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_106.png", UriKind.Relative)) };
                    player7Char = 6;
                    break;
                case 8:
                    P8Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_106.png", UriKind.Relative)) };
                    player8Char = 6;
                    break;
                case 99:
                    P1Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_106.png", UriKind.Relative)) };
                    player1Char = 6;
                    P2Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_106.png", UriKind.Relative)) };
                    player2Char = 6;
                    P3Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_106.png", UriKind.Relative)) };
                    player3Char = 6;
                    P4Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_106.png", UriKind.Relative)) };
                    player4Char = 6;
                    P5Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_106.png", UriKind.Relative)) };
                    player5Char = 6;
                    P6Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_106.png", UriKind.Relative)) };
                    player6Char = 6;
                    P7Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_106.png", UriKind.Relative)) };
                    player7Char = 6;
                    P8Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_106.png", UriKind.Relative)) };
                    player8Char = 6;
                    break;
                case 100:
                    P3Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_106.png", UriKind.Relative)) };
                    player3Char = 6;
                    P4Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_106.png", UriKind.Relative)) };
                    player4Char = 6;
                    P5Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_106.png", UriKind.Relative)) };
                    player5Char = 6;
                    P6Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_106.png", UriKind.Relative)) };
                    player6Char = 6;
                    P7Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_106.png", UriKind.Relative)) };
                    player7Char = 6;
                    P8Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_106.png", UriKind.Relative)) };
                    player8Char = 6;
                    break;
            }
        }

        private void BeatenKg_Click(object sender, RoutedEventArgs e)
        {
            switch (selectedPlayer)
            {
                case 1:
                    P1Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_107.png", UriKind.Relative)) };
                    player1Char = 7;
                    break;
                case 2:
                    P2Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_107.png", UriKind.Relative)) };
                    player2Char = 7;
                    break;
                case 3:
                    P3Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_107.png", UriKind.Relative)) };
                    player3Char = 7;
                    break;
                case 4:
                    P4Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_107.png", UriKind.Relative)) };
                    player4Char = 7;
                    break;
                case 5:
                    P5Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_107.png", UriKind.Relative)) };
                    player5Char = 7;
                    break;
                case 6:
                    P6Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_107.png", UriKind.Relative)) };
                    player6Char = 7;
                    break;
                case 7:
                    P7Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_107.png", UriKind.Relative)) };
                    player7Char = 7;
                    break;
                case 8:
                    P8Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_107.png", UriKind.Relative)) };
                    player8Char = 7;
                    break;
                case 99:
                    P1Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_107.png", UriKind.Relative)) };
                    player1Char = 7;
                    P2Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_107.png", UriKind.Relative)) };
                    player2Char = 7;
                    P3Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_107.png", UriKind.Relative)) };
                    player3Char = 7;
                    P4Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_107.png", UriKind.Relative)) };
                    player4Char = 7;
                    P5Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_107.png", UriKind.Relative)) };
                    player5Char = 7;
                    P6Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_107.png", UriKind.Relative)) };
                    player6Char = 7;
                    P7Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_107.png", UriKind.Relative)) };
                    player7Char = 7;
                    P8Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_107.png", UriKind.Relative)) };
                    player8Char = 7;
                    break;
                case 100:
                    P3Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_107.png", UriKind.Relative)) };
                    player3Char = 7;
                    P4Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_107.png", UriKind.Relative)) };
                    player4Char = 7;
                    P5Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_107.png", UriKind.Relative)) };
                    player5Char = 7;
                    P6Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_107.png", UriKind.Relative)) };
                    player6Char = 7;
                    P7Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_107.png", UriKind.Relative)) };
                    player7Char = 7;
                    P8Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_107.png", UriKind.Relative)) };
                    player8Char = 7;
                    break;
            }
        }

        private void BradHawkBeginner_Click(object sender, RoutedEventArgs e)
        {
            switch (selectedPlayer)
            {
                case 1:
                    P1Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_108.png", UriKind.Relative)) };
                    player1Char = 8;
                    break;
                case 2:
                    P2Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_108.png", UriKind.Relative)) };
                    player2Char = 8;
                    break;
                case 3:
                    P3Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_108.png", UriKind.Relative)) };
                    player3Char = 8;
                    break;
                case 4:
                    P4Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_108.png", UriKind.Relative)) };
                    player4Char = 8;
                    break;
                case 5:
                    P5Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_108.png", UriKind.Relative)) };
                    player5Char = 8;
                    break;
                case 6:
                    P6Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_108.png", UriKind.Relative)) };
                    player6Char = 8;
                    break;
                case 7:
                    P7Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_108.png", UriKind.Relative)) };
                    player7Char = 8;
                    break;
                case 8:
                    P8Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_108.png", UriKind.Relative)) };
                    player8Char = 8;
                    break;
                case 99:
                    P1Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_108.png", UriKind.Relative)) };
                    player1Char = 8;
                    P2Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_108.png", UriKind.Relative)) };
                    player2Char = 8;
                    P3Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_108.png", UriKind.Relative)) };
                    player3Char = 8;
                    P4Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_108.png", UriKind.Relative)) };
                    player4Char = 8;
                    P5Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_108.png", UriKind.Relative)) };
                    player5Char = 8;
                    P6Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_108.png", UriKind.Relative)) };
                    player6Char = 8;
                    P7Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_108.png", UriKind.Relative)) };
                    player7Char = 8;
                    P8Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_108.png", UriKind.Relative)) };
                    player8Char = 8;
                    break;
                case 100:
                    P3Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_108.png", UriKind.Relative)) };
                    player3Char = 8;
                    P4Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_108.png", UriKind.Relative)) };
                    player4Char = 8;
                    P5Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_108.png", UriKind.Relative)) };
                    player5Char = 8;
                    P6Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_108.png", UriKind.Relative)) };
                    player6Char = 8;
                    P7Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_108.png", UriKind.Relative)) };
                    player7Char = 8;
                    P8Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_108.png", UriKind.Relative)) };
                    player8Char = 8;
                    break;
            }
        }

        private void Nightmare_Click(object sender, RoutedEventArgs e)
        {
            switch (selectedPlayer)
            {
                case 1:
                    P1Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_109.png", UriKind.Relative)) };
                    player1Char = 9;
                    break;
                case 2:
                    P2Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_109.png", UriKind.Relative)) };
                    player2Char = 9;
                    break;
                case 3:
                    P3Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_109.png", UriKind.Relative)) };
                    player3Char = 9;
                    break;
                case 4:
                    P4Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_109.png", UriKind.Relative)) };
                    player4Char = 9;
                    break;
                case 5:
                    P5Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_109.png", UriKind.Relative)) };
                    player5Char = 9;
                    break;
                case 6:
                    P6Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_109.png", UriKind.Relative)) };
                    player6Char = 9;
                    break;
                case 7:
                    P7Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_109.png", UriKind.Relative)) };
                    player7Char = 9;
                    break;
                case 8:
                    P8Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_109.png", UriKind.Relative)) };
                    player8Char = 9;
                    break;
                case 99:
                    P1Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_109.png", UriKind.Relative)) };
                    player1Char = 9;
                    P2Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_109.png", UriKind.Relative)) };
                    player2Char = 9;
                    P3Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_109.png", UriKind.Relative)) };
                    player3Char = 9;
                    P4Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_109.png", UriKind.Relative)) };
                    player4Char = 9;
                    P5Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_109.png", UriKind.Relative)) };
                    player5Char = 9;
                    P6Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_109.png", UriKind.Relative)) };
                    player6Char = 9;
                    P7Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_109.png", UriKind.Relative)) };
                    player7Char = 9;
                    P8Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_109.png", UriKind.Relative)) };
                    player8Char = 9;
                    break;
                case 100:
                    P3Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_109.png", UriKind.Relative)) };
                    player3Char = 9;
                    P4Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_109.png", UriKind.Relative)) };
                    player4Char = 9;
                    P5Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_109.png", UriKind.Relative)) };
                    player5Char = 9;
                    P6Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_109.png", UriKind.Relative)) };
                    player6Char = 9;
                    P7Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_109.png", UriKind.Relative)) };
                    player7Char = 9;
                    P8Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_109.png", UriKind.Relative)) };
                    player8Char = 9;
                    break;
            }
        }

        private void ShunYing_Click(object sender, RoutedEventArgs e)
        {
            switch (selectedPlayer)
            {
                case 1:
                    P1Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_110.png", UriKind.Relative)) };
                    player1Char = 10;
                    break;
                case 2:
                    P2Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_110.png", UriKind.Relative)) };
                    player2Char = 10;
                    break;
                case 3:
                    P3Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_110.png", UriKind.Relative)) };
                    player3Char = 10;
                    break;
                case 4:
                    P4Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_110.png", UriKind.Relative)) };
                    player4Char = 10;
                    break;
                case 5:
                    P5Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_110.png", UriKind.Relative)) };
                    player5Char = 10;
                    break;
                case 6:
                    P6Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_110.png", UriKind.Relative)) };
                    player6Char = 10;
                    break;
                case 7:
                    P7Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_110.png", UriKind.Relative)) };
                    player7Char = 10;
                    break;
                case 8:
                    P8Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_110.png", UriKind.Relative)) };
                    player8Char = 10;
                    break;
                case 99:
                    P1Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_110.png", UriKind.Relative)) };
                    player1Char = 10;
                    P2Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_110.png", UriKind.Relative)) };
                    player2Char = 10;
                    P3Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_110.png", UriKind.Relative)) };
                    player3Char = 10;
                    P4Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_110.png", UriKind.Relative)) };
                    player4Char = 10;
                    P5Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_110.png", UriKind.Relative)) };
                    player5Char = 10;
                    P6Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_110.png", UriKind.Relative)) };
                    player6Char = 10;
                    P7Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_110.png", UriKind.Relative)) };
                    player7Char = 10;
                    P8Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_110.png", UriKind.Relative)) };
                    player8Char = 10;
                    break;
                case 100:
                    P3Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_110.png", UriKind.Relative)) };
                    player3Char = 10;
                    P4Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_110.png", UriKind.Relative)) };
                    player4Char = 10;
                    P5Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_110.png", UriKind.Relative)) };
                    player5Char = 10;
                    P6Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_110.png", UriKind.Relative)) };
                    player6Char = 10;
                    P7Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_110.png", UriKind.Relative)) };
                    player7Char = 10;
                    P8Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_110.png", UriKind.Relative)) };
                    player8Char = 10;
                    break;
            }
        }

        private void Bordin_Click(object sender, RoutedEventArgs e)
        {
            switch (selectedPlayer)
            {
                case 1:
                    P1Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_111.png", UriKind.Relative)) };
                    player1Char = 11;
                    break;
                case 2:
                    P2Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_111.png", UriKind.Relative)) };
                    player2Char = 11;
                    break;
                case 3:
                    P3Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_111.png", UriKind.Relative)) };
                    player3Char = 11;
                    break;
                case 4:
                    P4Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_111.png", UriKind.Relative)) };
                    player4Char = 11;
                    break;
                case 5:
                    P5Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_111.png", UriKind.Relative)) };
                    player5Char = 11;
                    break;
                case 6:
                    P6Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_111.png", UriKind.Relative)) };
                    player6Char = 11;
                    break;
                case 7:
                    P7Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_111.png", UriKind.Relative)) };
                    player7Char = 11;
                    break;
                case 8:
                    P8Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_111.png", UriKind.Relative)) };
                    player8Char = 11;
                    break;
                case 99:
                    P1Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_111.png", UriKind.Relative)) };
                    player1Char = 11;
                    P2Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_111.png", UriKind.Relative)) };
                    player2Char = 11;
                    P3Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_111.png", UriKind.Relative)) };
                    player3Char = 11;
                    P4Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_111.png", UriKind.Relative)) };
                    player4Char = 11;
                    P5Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_111.png", UriKind.Relative)) };
                    player5Char = 11;
                    P6Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_111.png", UriKind.Relative)) };
                    player6Char = 11;
                    P7Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_111.png", UriKind.Relative)) };
                    player7Char = 11;
                    P8Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_111.png", UriKind.Relative)) };
                    player8Char = 11;
                    break;
                case 100:
                    P3Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_111.png", UriKind.Relative)) };
                    player3Char = 11;
                    P4Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_111.png", UriKind.Relative)) };
                    player4Char = 11;
                    P5Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_111.png", UriKind.Relative)) };
                    player5Char = 11;
                    P6Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_111.png", UriKind.Relative)) };
                    player6Char = 11;
                    P7Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_111.png", UriKind.Relative)) };
                    player7Char = 11;
                    P8Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_111.png", UriKind.Relative)) };
                    player8Char = 11;
                    break;
            }
        }

        private void Paul_Click(object sender, RoutedEventArgs e)
        {
            switch (selectedPlayer)
            {
                case 1:
                    P1Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_112.png", UriKind.Relative)) };
                    player1Char = 12;
                    break;
                case 2:
                    P2Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_112.png", UriKind.Relative)) };
                    player2Char = 12;
                    break;
                case 3:
                    P3Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_112.png", UriKind.Relative)) };
                    player3Char = 12;
                    break;
                case 4:
                    P4Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_112.png", UriKind.Relative)) };
                    player4Char = 12;
                    break;
                case 5:
                    P5Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_112.png", UriKind.Relative)) };
                    player5Char = 12;
                    break;
                case 6:
                    P6Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_112.png", UriKind.Relative)) };
                    player6Char = 12;
                    break;
                case 7:
                    P7Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_112.png", UriKind.Relative)) };
                    player7Char = 12;
                    break;
                case 8:
                    P8Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_112.png", UriKind.Relative)) };
                    player8Char = 12;
                    break;
                case 99:
                    P1Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_112.png", UriKind.Relative)) };
                    player1Char = 12;
                    P2Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_112.png", UriKind.Relative)) };
                    player2Char = 12;
                    P3Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_112.png", UriKind.Relative)) };
                    player3Char = 12;
                    P4Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_112.png", UriKind.Relative)) };
                    player4Char = 12;
                    P5Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_112.png", UriKind.Relative)) };
                    player5Char = 12;
                    P6Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_112.png", UriKind.Relative)) };
                    player6Char = 12;
                    P7Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_112.png", UriKind.Relative)) };
                    player7Char = 12;
                    P8Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_112.png", UriKind.Relative)) };
                    player8Char = 12;
                    break;
                case 100:
                    P3Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_112.png", UriKind.Relative)) };
                    player3Char = 12;
                    P4Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_112.png", UriKind.Relative)) };
                    player4Char = 12;
                    P5Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_112.png", UriKind.Relative)) };
                    player5Char = 12;
                    P6Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_112.png", UriKind.Relative)) };
                    player6Char = 12;
                    P7Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_112.png", UriKind.Relative)) };
                    player7Char = 12;
                    P8Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_112.png", UriKind.Relative)) };
                    player8Char = 12;
                    break;
            }
        }


        private void Law_Click(object sender, RoutedEventArgs e)
        {
            switch (selectedPlayer)
            {
                case 1:
                    P1Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_113.png", UriKind.Relative)) };
                    player1Char = 13;
                    break;
                case 2:
                    P2Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_113.png", UriKind.Relative)) };
                    player2Char = 13;
                    break;
                case 3:
                    P3Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_113.png", UriKind.Relative)) };
                    player3Char = 13;
                    break;
                case 4:
                    P4Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_113.png", UriKind.Relative)) };
                    player4Char = 13;
                    break;
                case 5:
                    P5Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_113.png", UriKind.Relative)) };
                    player5Char = 13;
                    break;
                case 6:
                    P6Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_113.png", UriKind.Relative)) };
                    player6Char = 13;
                    break;
                case 7:
                    P7Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_113.png", UriKind.Relative)) };
                    player7Char = 13;
                    break;
                case 8:
                    P8Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_113.png", UriKind.Relative)) };
                    player8Char = 13;
                    break;
                case 99:
                    P1Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_113.png", UriKind.Relative)) };
                    player1Char = 13;
                    P2Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_113.png", UriKind.Relative)) };
                    player2Char = 13;
                    P3Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_113.png", UriKind.Relative)) };
                    player3Char = 13;
                    P4Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_113.png", UriKind.Relative)) };
                    player4Char = 13;
                    P5Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_113.png", UriKind.Relative)) };
                    player5Char = 13;
                    P6Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_113.png", UriKind.Relative)) };
                    player6Char = 13;
                    P7Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_113.png", UriKind.Relative)) };
                    player7Char = 13;
                    P8Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_113.png", UriKind.Relative)) };
                    player8Char = 13;
                    break;
                case 100:
                    P3Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_113.png", UriKind.Relative)) };
                    player3Char = 13;
                    P4Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_113.png", UriKind.Relative)) };
                    player4Char = 13;
                    P5Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_113.png", UriKind.Relative)) };
                    player5Char = 13;
                    P6Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_113.png", UriKind.Relative)) };
                    player6Char = 13;
                    P7Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_113.png", UriKind.Relative)) };
                    player7Char = 13;
                    P8Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_113.png", UriKind.Relative)) };
                    player8Char = 13;
                    break;
            }
        }
        private void Mckinzie_Click(object sender, RoutedEventArgs e)
        {
            switch (selectedPlayer)
            {
                case 1:
                    P1Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_114.png", UriKind.Relative)) };
                    player1Char = 14;
                    break;
                case 2:
                    P2Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_114.png", UriKind.Relative)) };
                    player2Char = 14;
                    break;
                case 3:
                    P3Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_114.png", UriKind.Relative)) };
                    player3Char = 14;
                    break;
                case 4:
                    P4Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_114.png", UriKind.Relative)) };
                    player4Char = 14;
                    break;
                case 5:
                    P5Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_114.png", UriKind.Relative)) };
                    player5Char = 14;
                    break;
                case 6:
                    P6Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_114.png", UriKind.Relative)) };
                    player6Char = 14;
                    break;
                case 7:
                    P7Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_114.png", UriKind.Relative)) };
                    player7Char = 14;
                    break;
                case 8:
                    P8Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_114.png", UriKind.Relative)) };
                    player8Char = 14;
                    break;
                case 99:
                    P1Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_114.png", UriKind.Relative)) };
                    player1Char = 14;
                    P2Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_114.png", UriKind.Relative)) };
                    player2Char = 14;
                    P3Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_114.png", UriKind.Relative)) };
                    player3Char = 14;
                    P4Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_114.png", UriKind.Relative)) };
                    player4Char = 14;
                    P5Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_114.png", UriKind.Relative)) };
                    player5Char = 14;
                    P6Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_114.png", UriKind.Relative)) };
                    player6Char = 14;
                    P7Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_114.png", UriKind.Relative)) };
                    player7Char = 14;
                    P8Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_114.png", UriKind.Relative)) };
                    player8Char = 14;
                    break;
                case 100:
                    P3Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_114.png", UriKind.Relative)) };
                    player3Char = 14;
                    P4Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_114.png", UriKind.Relative)) };
                    player4Char = 14;
                    P5Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_114.png", UriKind.Relative)) };
                    player5Char = 14;
                    P6Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_114.png", UriKind.Relative)) };
                    player6Char = 14;
                    P7Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_114.png", UriKind.Relative)) };
                    player7Char = 14;
                    P8Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_114.png", UriKind.Relative)) };
                    player8Char = 14;
                    break;
            }
        }

        private void KG_Zombie_Click(object sender, RoutedEventArgs e)
        {
            switch (selectedPlayer)
            {
                case 1:
                    P1Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_115.png", UriKind.Relative)) };
                    player1Char = 15;
                    break;
                case 2:
                    P2Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_115.png", UriKind.Relative)) };
                    player2Char = 15;
                    break;
                case 3:
                    P3Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_115.png", UriKind.Relative)) };
                    player3Char = 15;
                    break;
                case 4:
                    P4Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_115.png", UriKind.Relative)) };
                    player4Char = 15;
                    break;
                case 5:
                    P5Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_115.png", UriKind.Relative)) };
                    player5Char = 15;
                    break;
                case 6:
                    P6Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_115.png", UriKind.Relative)) };
                    player6Char = 15;
                    break;
                case 7:
                    P7Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_115.png", UriKind.Relative)) };
                    player7Char = 15;
                    break;
                case 8:
                    P8Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_115.png", UriKind.Relative)) };
                    player8Char = 15;
                    break;
                case 99:
                    P1Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_115.png", UriKind.Relative)) };
                    player1Char = 15;
                    P2Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_115.png", UriKind.Relative)) };
                    player2Char = 15;
                    P3Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_115.png", UriKind.Relative)) };
                    player3Char = 15;
                    P4Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_115.png", UriKind.Relative)) };
                    player4Char = 15;
                    P5Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_115.png", UriKind.Relative)) };
                    player5Char = 15;
                    P6Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_115.png", UriKind.Relative)) };
                    player6Char = 15;
                    P7Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_115.png", UriKind.Relative)) };
                    player7Char = 15;
                    P8Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_115.png", UriKind.Relative)) };
                    player8Char = 15;
                    break;
                case 100:
                    P3Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_115.png", UriKind.Relative)) };
                    player3Char = 15;
                    P4Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_115.png", UriKind.Relative)) };
                    player4Char = 15;
                    P5Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_115.png", UriKind.Relative)) };
                    player5Char = 15;
                    P6Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_115.png", UriKind.Relative)) };
                    player6Char = 15;
                    P7Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_115.png", UriKind.Relative)) };
                    player7Char = 15;
                    P8Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_115.png", UriKind.Relative)) };
                    player8Char = 15;
                    break;
            }
        }

        private void MaxPowerUp_Click(object sender, RoutedEventArgs e)
        {
            switch (selectedPlayer)
            {
                case 1:
                    P1Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_116.png", UriKind.Relative)) };
                    player1Char = 16;
                    break;
                case 2:
                    P2Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_116.png", UriKind.Relative)) };
                    player2Char = 16;
                    break;
                case 3:
                    P3Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_116.png", UriKind.Relative)) };
                    player3Char = 16;
                    break;
                case 4:
                    P4Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_116.png", UriKind.Relative)) };
                    player4Char = 16;
                    break;
                case 5:
                    P5Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_116.png", UriKind.Relative)) };
                    player5Char = 16;
                    break;
                case 6:
                    P6Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_116.png", UriKind.Relative)) };
                    player6Char = 16;
                    break;
                case 7:
                    P7Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_116.png", UriKind.Relative)) };
                    player7Char = 16;
                    break;
                case 8:
                    P8Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_116.png", UriKind.Relative)) };
                    player8Char = 16;
                    break;
                case 99:
                    P1Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_116.png", UriKind.Relative)) };
                    player1Char = 16;
                    P2Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_116.png", UriKind.Relative)) };
                    player2Char = 16;
                    P3Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_116.png", UriKind.Relative)) };
                    player3Char = 16;
                    P4Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_116.png", UriKind.Relative)) };
                    player4Char = 16;
                    P5Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_116.png", UriKind.Relative)) };
                    player5Char = 16;
                    P6Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_116.png", UriKind.Relative)) };
                    player6Char = 16;
                    P7Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_116.png", UriKind.Relative)) };
                    player7Char = 16;
                    P8Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_116.png", UriKind.Relative)) };
                    player8Char = 16;
                    break;
                case 100:
                    P3Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_116.png", UriKind.Relative)) };
                    player3Char = 16;
                    P4Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_116.png", UriKind.Relative)) };
                    player4Char = 16;
                    P5Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_116.png", UriKind.Relative)) };
                    player5Char = 16;
                    P6Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_116.png", UriKind.Relative)) };
                    player6Char = 16;
                    P7Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_116.png", UriKind.Relative)) };
                    player7Char = 16;
                    P8Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_116.png", UriKind.Relative)) };
                    player8Char = 16;
                    break;
            }
        }

        private void OnlyWeapon_Click(object sender, RoutedEventArgs e)
        {
            switch (selectedPlayer)
            {
                case 1:
                    P1Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_117.png", UriKind.Relative)) };
                    player1Char = 17;
                    break;
                case 2:
                    P2Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_117.png", UriKind.Relative)) };
                    player2Char = 17;
                    break;
                case 3:
                    P3Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_117.png", UriKind.Relative)) };
                    player3Char = 17;
                    break;
                case 4:
                    P4Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_117.png", UriKind.Relative)) };
                    player4Char = 17;
                    break;
                case 5:
                    P5Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_117.png", UriKind.Relative)) };
                    player5Char = 17;
                    break;
                case 6:
                    P6Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_117.png", UriKind.Relative)) };
                    player6Char = 17;
                    break;
                case 7:
                    P7Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_117.png", UriKind.Relative)) };
                    player7Char = 17;
                    break;
                case 8:
                    P8Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_117.png", UriKind.Relative)) };
                    player8Char = 17;
                    break;
                case 99:
                    P1Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_117.png", UriKind.Relative)) };
                    player1Char = 17;
                    P2Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_117.png", UriKind.Relative)) };
                    player2Char = 17;
                    P3Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_117.png", UriKind.Relative)) };
                    player3Char = 17;
                    P4Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_117.png", UriKind.Relative)) };
                    player4Char = 17;
                    P5Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_117.png", UriKind.Relative)) };
                    player5Char = 17;
                    P6Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_117.png", UriKind.Relative)) };
                    player6Char = 17;
                    P7Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_117.png", UriKind.Relative)) };
                    player7Char = 17;
                    P8Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_117.png", UriKind.Relative)) };
                    player8Char = 17;
                    break;
                case 100:
                    P3Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_117.png", UriKind.Relative)) };
                    player3Char = 17;
                    P4Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_117.png", UriKind.Relative)) };
                    player4Char = 17;
                    P5Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_117.png", UriKind.Relative)) };
                    player5Char = 17;
                    P6Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_117.png", UriKind.Relative)) };
                    player6Char = 17;
                    P7Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_117.png", UriKind.Relative)) };
                    player7Char = 17;
                    P8Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_117.png", UriKind.Relative)) };
                    player8Char = 17;
                    break;
            }
        }


        private void DeadPlayer_Click(object sender, RoutedEventArgs e)
        {
            switch (selectedPlayer)
            {
                case 1:
                    P1Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_201.png", UriKind.Relative)) };
                    player1Char = 101;
                    break;
                case 2:
                    P2Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_201.png", UriKind.Relative)) };
                    player2Char = 101;
                    break;
                case 3:
                    P3Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_201.png", UriKind.Relative)) };
                    player3Char = 101;
                    break;
                case 4:
                    P4Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_201.png", UriKind.Relative)) };
                    player4Char = 101;
                    break;
                case 5:
                    P5Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_201.png", UriKind.Relative)) };
                    player5Char = 101;
                    break;
                case 6:
                    P6Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_201.png", UriKind.Relative)) };
                    player6Char = 101;
                    break;
                case 7:
                    P7Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_201.png", UriKind.Relative)) };
                    player7Char = 101;
                    break;
                case 8:
                    P8Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_201.png", UriKind.Relative)) };
                    player8Char = 101;
                    break;
                case 99:
                    P1Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_201.png", UriKind.Relative)) };
                    player1Char = 101;
                    P2Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_201.png", UriKind.Relative)) };
                    player2Char = 101;
                    P3Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_201.png", UriKind.Relative)) };
                    player3Char = 101;
                    P4Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_201.png", UriKind.Relative)) };
                    player4Char = 101;
                    P5Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_201.png", UriKind.Relative)) };
                    player5Char = 101;
                    P6Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_201.png", UriKind.Relative)) };
                    player6Char = 101;
                    P7Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_201.png", UriKind.Relative)) };
                    player7Char = 101;
                    P8Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_201.png", UriKind.Relative)) };
                    player8Char = 101;
                    break;
                case 100:
                    P3Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_201.png", UriKind.Relative)) };
                    player3Char = 101;
                    P4Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_201.png", UriKind.Relative)) };
                    player4Char = 101;
                    P5Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_201.png", UriKind.Relative)) };
                    player5Char = 101;
                    P6Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_201.png", UriKind.Relative)) };
                    player6Char = 101;
                    P7Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_201.png", UriKind.Relative)) };
                    player7Char = 101;
                    P8Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_201.png", UriKind.Relative)) };
                    player8Char = 101;
                    break;
            }
        }

        private void WeakPlayer_Click(object sender, RoutedEventArgs e)
        {
            switch (selectedPlayer)
            {
                case 1:
                    P1Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_202.png", UriKind.Relative)) };
                    player1Char = 102;
                    break;
                case 2:
                    P2Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_202.png", UriKind.Relative)) };
                    player2Char = 102;
                    break;
                case 3:
                    P3Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_202.png", UriKind.Relative)) };
                    player3Char = 102;
                    break;
                case 4:
                    P4Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_202.png", UriKind.Relative)) };
                    player4Char = 102;
                    break;
                case 5:
                    P5Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_202.png", UriKind.Relative)) };
                    player5Char = 102;
                    break;
                case 6:
                    P6Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_202.png", UriKind.Relative)) };
                    player6Char = 102;
                    break;
                case 7:
                    P7Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_202.png", UriKind.Relative)) };
                    player7Char = 102;
                    break;
                case 8:
                    P8Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_202.png", UriKind.Relative)) };
                    player8Char = 102;
                    break;
                case 99:
                    P1Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_202.png", UriKind.Relative)) };
                    player1Char = 102;
                    P2Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_202.png", UriKind.Relative)) };
                    player2Char = 102;
                    P3Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_202.png", UriKind.Relative)) };
                    player3Char = 102;
                    P4Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_202.png", UriKind.Relative)) };
                    player4Char = 102;
                    P5Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_202.png", UriKind.Relative)) };
                    player5Char = 102;
                    P6Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_202.png", UriKind.Relative)) };
                    player6Char = 102;
                    P7Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_202.png", UriKind.Relative)) };
                    player7Char = 102;
                    P8Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_202.png", UriKind.Relative)) };
                    player8Char = 102;
                    break;
                case 100:
                    P3Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_202.png", UriKind.Relative)) };
                    player3Char = 102;
                    P4Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_202.png", UriKind.Relative)) };
                    player4Char = 102;
                    P5Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_202.png", UriKind.Relative)) };
                    player5Char = 102;
                    P6Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_202.png", UriKind.Relative)) };
                    player6Char = 102;
                    P7Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_202.png", UriKind.Relative)) };
                    player7Char = 102;
                    P8Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_202.png", UriKind.Relative)) };
                    player8Char = 102;
                    break;
            }
        }

        private void StrongPLayer_Click(object sender, RoutedEventArgs e)
        {
            switch (selectedPlayer)
            {
                case 1:
                    P1Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_203.png", UriKind.Relative)) };
                    player1Char = 103;
                    break;
                case 2:
                    P2Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_203.png", UriKind.Relative)) };
                    player2Char = 103;
                    break;
                case 3:
                    P3Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_203.png", UriKind.Relative)) };
                    player3Char = 103;
                    break;
                case 4:
                    P4Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_203.png", UriKind.Relative)) };
                    player4Char = 103;
                    break;
                case 5:
                    P5Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_203.png", UriKind.Relative)) };
                    player5Char = 103;
                    break;
                case 6:
                    P6Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_203.png", UriKind.Relative)) };
                    player6Char = 103;
                    break;
                case 7:
                    P7Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_203.png", UriKind.Relative)) };
                    player7Char = 103;
                    break;
                case 8:
                    P8Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_203.png", UriKind.Relative)) };
                    player8Char = 103;
                    break;
                case 99:
                    P1Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_203.png", UriKind.Relative)) };
                    player1Char = 103;
                    P2Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_203.png", UriKind.Relative)) };
                    player2Char = 103;
                    P3Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_203.png", UriKind.Relative)) };
                    player3Char = 103;
                    P4Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_203.png", UriKind.Relative)) };
                    player4Char = 103;
                    P5Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_203.png", UriKind.Relative)) };
                    player5Char = 103;
                    P6Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_203.png", UriKind.Relative)) };
                    player6Char = 103;
                    P7Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_203.png", UriKind.Relative)) };
                    player7Char = 103;
                    P8Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_203.png", UriKind.Relative)) };
                    player8Char = 103;
                    break;
                case 100:
                    P3Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_203.png", UriKind.Relative)) };
                    player3Char = 103;
                    P4Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_203.png", UriKind.Relative)) };
                    player4Char = 103;
                    P5Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_203.png", UriKind.Relative)) };
                    player5Char = 103;
                    P6Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_203.png", UriKind.Relative)) };
                    player6Char = 103;
                    P7Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_203.png", UriKind.Relative)) };
                    player7Char = 103;
                    P8Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_203.png", UriKind.Relative)) };
                    player8Char = 103;
                    break;
            }
        }

        private void TankPlayer_Click(object sender, RoutedEventArgs e)
        {
            switch (selectedPlayer)
            {
                case 1:
                    P1Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_204.png", UriKind.Relative)) };
                    player1Char = 104;
                    break;
                case 2:
                    P2Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_204.png", UriKind.Relative)) };
                    player2Char = 104;
                    break;
                case 3:
                    P3Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_204.png", UriKind.Relative)) };
                    player3Char = 104;
                    break;
                case 4:
                    P4Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_204.png", UriKind.Relative)) };
                    player4Char = 104;
                    break;
                case 5:
                    P5Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_204.png", UriKind.Relative)) };
                    player5Char = 104;
                    break;
                case 6:
                    P6Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_204.png", UriKind.Relative)) };
                    player6Char = 104;
                    break;
                case 7:
                    P7Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_204.png", UriKind.Relative)) };
                    player7Char = 104;
                    break;
                case 8:
                    P8Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_204.png", UriKind.Relative)) };
                    player8Char = 104;
                    break;
                case 99:
                    P1Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_204.png", UriKind.Relative)) };
                    player1Char = 104;
                    P2Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_204.png", UriKind.Relative)) };
                    player2Char = 104;
                    P3Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_204.png", UriKind.Relative)) };
                    player3Char = 104;
                    P4Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_204.png", UriKind.Relative)) };
                    player4Char = 104;
                    P5Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_204.png", UriKind.Relative)) };
                    player5Char = 104;
                    P6Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_204.png", UriKind.Relative)) };
                    player6Char = 104;
                    P7Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_204.png", UriKind.Relative)) };
                    player7Char = 104;
                    P8Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_204.png", UriKind.Relative)) };
                    player8Char = 104;
                    break;
                case 100:
                    P3Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_204.png", UriKind.Relative)) };
                    player3Char = 104;
                    P4Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_204.png", UriKind.Relative)) };
                    player4Char = 104;
                    P5Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_204.png", UriKind.Relative)) };
                    player5Char = 104;
                    P6Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_204.png", UriKind.Relative)) };
                    player6Char = 104;
                    P7Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_204.png", UriKind.Relative)) };
                    player7Char = 104;
                    P8Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_204.png", UriKind.Relative)) };
                    player8Char = 104;
                    break;
            }
        }



        private void BeatUpPlayer_Click(object sender, RoutedEventArgs e)
        {
            switch (selectedPlayer)
            {
                case 1:
                    P1Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_205.png", UriKind.Relative)) };
                    player1Char = 105;
                    break;
                case 2:
                    P2Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_205.png", UriKind.Relative)) };
                    player2Char = 105;
                    break;
                case 3:
                    P3Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_205.png", UriKind.Relative)) };
                    player3Char = 105;
                    break;
                case 4:
                    P4Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_205.png", UriKind.Relative)) };
                    player4Char = 105;
                    break;
                case 5:
                    P5Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_205.png", UriKind.Relative)) };
                    player5Char = 105;
                    break;
                case 6:
                    P6Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_205.png", UriKind.Relative)) };
                    player6Char = 105;
                    break;
                case 7:
                    P7Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_205.png", UriKind.Relative)) };
                    player7Char = 105;
                    break;
                case 8:
                    P8Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_205.png", UriKind.Relative)) };
                    player8Char = 105;
                    break;
                case 99:
                    P1Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_205.png", UriKind.Relative)) };
                    player1Char = 105;
                    P2Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_205.png", UriKind.Relative)) };
                    player2Char = 105;
                    P3Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_205.png", UriKind.Relative)) };
                    player3Char = 105;
                    P4Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_205.png", UriKind.Relative)) };
                    player4Char = 105;
                    P5Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_205.png", UriKind.Relative)) };
                    player5Char = 105;
                    P6Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_205.png", UriKind.Relative)) };
                    player6Char = 105;
                    P7Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_205.png", UriKind.Relative)) };
                    player7Char = 105;
                    P8Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_205.png", UriKind.Relative)) };
                    player8Char = 105;
                    break;
                case 100:
                    P3Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_205.png", UriKind.Relative)) };
                    player3Char = 105;
                    P4Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_205.png", UriKind.Relative)) };
                    player4Char = 105;
                    P5Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_205.png", UriKind.Relative)) };
                    player5Char = 105;
                    P6Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_205.png", UriKind.Relative)) };
                    player6Char = 105;
                    P7Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_205.png", UriKind.Relative)) };
                    player7Char = 105;
                    P8Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_205.png", UriKind.Relative)) };
                    player8Char = 105;
                    break;
            }
        }

        private void NoSPA_Player_Click(object sender, RoutedEventArgs e)
        {
            switch (selectedPlayer)
            {
                case 1:
                    P1Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_206.png", UriKind.Relative)) };
                    player1Char = 106;
                    break;
                case 2:
                    P2Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_206.png", UriKind.Relative)) };
                    player2Char = 106;
                    break;
                case 3:
                    P3Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_206.png", UriKind.Relative)) };
                    player3Char = 106;
                    break;
                case 4:
                    P4Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_206.png", UriKind.Relative)) };
                    player4Char = 106;
                    break;
                case 5:
                    P5Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_206.png", UriKind.Relative)) };
                    player5Char = 106;
                    break;
                case 6:
                    P6Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_206.png", UriKind.Relative)) };
                    player6Char = 106;
                    break;
                case 7:
                    P7Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_206.png", UriKind.Relative)) };
                    player7Char = 106;
                    break;
                case 8:
                    P8Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_206.png", UriKind.Relative)) };
                    player8Char = 106;
                    break;
                case 99:
                    P1Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_206.png", UriKind.Relative)) };
                    player1Char = 106;
                    P2Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_206.png", UriKind.Relative)) };
                    player2Char = 106;
                    P3Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_206.png", UriKind.Relative)) };
                    player3Char = 106;
                    P4Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_206.png", UriKind.Relative)) };
                    player4Char = 106;
                    P5Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_206.png", UriKind.Relative)) };
                    player5Char = 106;
                    P6Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_206.png", UriKind.Relative)) };
                    player6Char = 106;
                    P7Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_206.png", UriKind.Relative)) };
                    player7Char = 106;
                    P8Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_206.png", UriKind.Relative)) };
                    player8Char = 106;
                    break;
                case 100:
                    P3Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_206.png", UriKind.Relative)) };
                    player3Char = 106;
                    P4Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_206.png", UriKind.Relative)) };
                    player4Char = 106;
                    P5Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_206.png", UriKind.Relative)) };
                    player5Char = 106;
                    P6Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_206.png", UriKind.Relative)) };
                    player6Char = 106;
                    P7Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_206.png", UriKind.Relative)) };
                    player7Char = 106;
                    P8Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_206.png", UriKind.Relative)) };
                    player8Char = 106;
                    break;
            }
        }

        private void InfiniteSPA__Click(object sender, RoutedEventArgs e)
        {
            switch (selectedPlayer)
            {
                case 1:
                    P1Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_207.png", UriKind.Relative)) };
                    player1Char = 107;
                    break;
                case 2:
                    P2Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_207.png", UriKind.Relative)) };
                    player2Char = 107;
                    break;
                case 3:
                    P3Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_207.png", UriKind.Relative)) };
                    player3Char = 107;
                    break;
                case 4:
                    P4Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_207.png", UriKind.Relative)) };
                    player4Char = 107;
                    break;
                case 5:
                    P5Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_207.png", UriKind.Relative)) };
                    player5Char = 107;
                    break;
                case 6:
                    P6Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_207.png", UriKind.Relative)) };
                    player6Char = 107;
                    break;
                case 7:
                    P7Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_207.png", UriKind.Relative)) };
                    player7Char = 107;
                    break;
                case 8:
                    P8Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_207.png", UriKind.Relative)) };
                    player8Char = 107;
                    break;
                case 99:
                    P1Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_207.png", UriKind.Relative)) };
                    player1Char = 107;
                    P2Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_207.png", UriKind.Relative)) };
                    player2Char = 107;
                    P3Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_207.png", UriKind.Relative)) };
                    player3Char = 107;
                    P4Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_207.png", UriKind.Relative)) };
                    player4Char = 107;
                    P5Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_207.png", UriKind.Relative)) };
                    player5Char = 107;
                    P6Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_207.png", UriKind.Relative)) };
                    player6Char = 107;
                    P7Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_207.png", UriKind.Relative)) };
                    player7Char = 107;
                    P8Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_207.png", UriKind.Relative)) };
                    player8Char = 107;
                    break;
                case 100:
                    P3Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_207.png", UriKind.Relative)) };
                    player3Char = 107;
                    P4Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_207.png", UriKind.Relative)) };
                    player4Char = 107;
                    P5Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_207.png", UriKind.Relative)) };
                    player5Char = 107;
                    P6Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_207.png", UriKind.Relative)) };
                    player6Char = 107;
                    P7Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_207.png", UriKind.Relative)) };
                    player7Char = 107;
                    P8Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_207.png", UriKind.Relative)) };
                    player8Char = 107;
                    break;
            }
        }


        private void UltraInstinctPlayer_Click(object sender, RoutedEventArgs e)
        {
            switch (selectedPlayer)
            {
                case 1:
                    P1Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_208.png", UriKind.Relative)) };
                    player1Char = 108;
                    break;
                case 2:
                    P2Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_208.png", UriKind.Relative)) };
                    player2Char = 108;
                    break;
                case 3:
                    P3Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_208.png", UriKind.Relative)) };
                    player3Char = 108;
                    break;
                case 4:
                    P4Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_208.png", UriKind.Relative)) };
                    player4Char = 108;
                    break;
                case 5:
                    P5Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_208.png", UriKind.Relative)) };
                    player5Char = 108;
                    break;
                case 6:
                    P6Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_208.png", UriKind.Relative)) };
                    player6Char = 108;
                    break;
                case 7:
                    P7Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_208.png", UriKind.Relative)) };
                    player7Char = 108;
                    break;
                case 8:
                    P8Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_208.png", UriKind.Relative)) };
                    player8Char = 108;
                    break;
                case 99:
                    P1Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_208.png", UriKind.Relative)) };
                    player1Char = 108;
                    P2Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_208.png", UriKind.Relative)) };
                    player2Char = 108;
                    P3Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_208.png", UriKind.Relative)) };
                    player3Char = 108;
                    P4Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_208.png", UriKind.Relative)) };
                    player4Char = 108;
                    P5Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_208.png", UriKind.Relative)) };
                    player5Char = 108;
                    P6Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_208.png", UriKind.Relative)) };
                    player6Char = 108;
                    P7Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_208.png", UriKind.Relative)) };
                    player7Char = 108;
                    P8Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_208.png", UriKind.Relative)) };
                    player8Char = 108;
                    break;
                case 100:
                    P3Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_208.png", UriKind.Relative)) };
                    player3Char = 108;
                    P4Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_208.png", UriKind.Relative)) };
                    player4Char = 108;
                    P5Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_208.png", UriKind.Relative)) };
                    player5Char = 108;
                    P6Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_208.png", UriKind.Relative)) };
                    player6Char = 108;
                    P7Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_208.png", UriKind.Relative)) };
                    player7Char = 108;
                    P8Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_208.png", UriKind.Relative)) };
                    player8Char = 108;
                    break;
            }
        }
        private void RandomStats_Click(object sender, RoutedEventArgs e)
        {
            switch (selectedPlayer)
            {
                case 1:
                    P1Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_209.png", UriKind.Relative)) };
                    player1Char = 109;
                    break;
                case 2:
                    P2Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_209.png", UriKind.Relative)) };
                    player2Char = 109;
                    break;
                case 3:
                    P3Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_209.png", UriKind.Relative)) };
                    player3Char = 109;
                    break;
                case 4:
                    P4Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_209.png", UriKind.Relative)) };
                    player4Char = 109;
                    break;
                case 5:
                    P5Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_209.png", UriKind.Relative)) };
                    player5Char = 109;
                    break;
                case 6:
                    P6Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_209.png", UriKind.Relative)) };
                    player6Char = 109;
                    break;
                case 7:
                    P7Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_209.png", UriKind.Relative)) };
                    player7Char = 109;
                    break;
                case 8:
                    P8Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_209.png", UriKind.Relative)) };
                    player8Char = 109;
                    break;
                case 99:
                    P1Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_209.png", UriKind.Relative)) };
                    player1Char = 109;
                    P2Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_209.png", UriKind.Relative)) };
                    player2Char = 109;
                    P3Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_209.png", UriKind.Relative)) };
                    player3Char = 109;
                    P4Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_209.png", UriKind.Relative)) };
                    player4Char = 109;
                    P5Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_209.png", UriKind.Relative)) };
                    player5Char = 109;
                    P6Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_209.png", UriKind.Relative)) };
                    player6Char = 109;
                    P7Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_209.png", UriKind.Relative)) };
                    player7Char = 109;
                    P8Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_209.png", UriKind.Relative)) };
                    player8Char = 109;
                    break;
                case 100:
                    P3Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_209.png", UriKind.Relative)) };
                    player3Char = 109;
                    P4Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_209.png", UriKind.Relative)) };
                    player4Char = 109;
                    P5Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_209.png", UriKind.Relative)) };
                    player5Char = 109;
                    P6Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_209.png", UriKind.Relative)) };
                    player6Char = 109;
                    P7Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_209.png", UriKind.Relative)) };
                    player7Char = 109;
                    P8Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_209.png", UriKind.Relative)) };
                    player8Char = 109;
                    break;
            }
        }

        private void SpaDownInfinite1_Click(object sender, RoutedEventArgs e)
        {

            switch (selectedPlayer)
            {
                case 1:
                    P1Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_301.png", UriKind.Relative)) };
                    player1Char = 111;
                    break;
                case 2:
                    P2Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_301.png", UriKind.Relative)) };
                    player2Char = 111;
                    break;
                case 3:
                    P3Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_301.png", UriKind.Relative)) };
                    player3Char = 111;
                    break;
                case 4:
                    P4Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_301.png", UriKind.Relative)) };
                    player4Char = 111;
                    break;
                case 5:
                    P5Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_301.png", UriKind.Relative)) };
                    player5Char = 111;
                    break;
                case 6:
                    P6Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_301.png", UriKind.Relative)) };
                    player6Char = 111;
                    break;
                case 7:
                    P7Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_301.png", UriKind.Relative)) };
                    player7Char = 111;
                    break;
                case 8:
                    P8Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_301.png", UriKind.Relative)) };
                    player8Char = 111;
                    break;
                case 99:
                    P1Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_301.png", UriKind.Relative)) };
                    player1Char = 111;
                    P2Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_301.png", UriKind.Relative)) };
                    player2Char = 111;
                    P3Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_301.png", UriKind.Relative)) };
                    player3Char = 111;
                    P4Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_301.png", UriKind.Relative)) };
                    player4Char = 111;
                    P5Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_301.png", UriKind.Relative)) };
                    player5Char = 111;
                    P6Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_301.png", UriKind.Relative)) };
                    player6Char = 111;
                    P7Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_301.png", UriKind.Relative)) };
                    player7Char = 111;
                    P8Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_301.png", UriKind.Relative)) };
                    player8Char = 111;
                    break;
                case 100:
                    P3Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_301.png", UriKind.Relative)) };
                    player3Char = 111;
                    P4Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_301.png", UriKind.Relative)) };
                    player4Char = 111;
                    P5Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_301.png", UriKind.Relative)) };
                    player5Char = 111;
                    P6Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_301.png", UriKind.Relative)) };
                    player6Char = 111;
                    P7Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_301.png", UriKind.Relative)) };
                    player7Char = 111;
                    P8Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_301.png", UriKind.Relative)) };
                    player8Char = 111;
                    break;
            }
        }
        private void SpaDownInfinite2_Click(object sender, RoutedEventArgs e)
        {

            switch (selectedPlayer)
            {
                case 1:
                    P1Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_302.png", UriKind.Relative)) };
                    player1Char = 112;
                    break;
                case 2:
                    P2Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_302.png", UriKind.Relative)) };
                    player2Char = 112;
                    break;
                case 3:
                    P3Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_302.png", UriKind.Relative)) };
                    player3Char = 112;
                    break;
                case 4:
                    P4Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_302.png", UriKind.Relative)) };
                    player4Char = 112;
                    break;
                case 5:
                    P5Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_302.png", UriKind.Relative)) };
                    player5Char = 112;
                    break;
                case 6:
                    P6Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_302.png", UriKind.Relative)) };
                    player6Char = 112;
                    break;
                case 7:
                    P7Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_302.png", UriKind.Relative)) };
                    player7Char = 112;
                    break;
                case 8:
                    P8Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_302.png", UriKind.Relative)) };
                    player8Char = 112;
                    break;
                case 99:
                    P1Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_302.png", UriKind.Relative)) };
                    player1Char = 112;
                    P2Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_302.png", UriKind.Relative)) };
                    player2Char = 112;
                    P3Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_302.png", UriKind.Relative)) };
                    player3Char = 112;
                    P4Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_302.png", UriKind.Relative)) };
                    player4Char = 112;
                    P5Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_302.png", UriKind.Relative)) };
                    player5Char = 112;
                    P6Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_302.png", UriKind.Relative)) };
                    player6Char = 112;
                    P7Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_302.png", UriKind.Relative)) };
                    player7Char = 112;
                    P8Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_302.png", UriKind.Relative)) };
                    player8Char = 112;
                    break;
                case 100:
                    P3Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_302.png", UriKind.Relative)) };
                    player3Char = 112;
                    P4Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_302.png", UriKind.Relative)) };
                    player4Char = 112;
                    P5Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_302.png", UriKind.Relative)) };
                    player5Char = 112;
                    P6Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_302.png", UriKind.Relative)) };
                    player6Char = 112;
                    P7Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_302.png", UriKind.Relative)) };
                    player7Char = 112;
                    P8Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_302.png", UriKind.Relative)) };
                    player8Char = 112;
                    break;
            }
        }
        private void SpaDownInfinite3_Click(object sender, RoutedEventArgs e)
        {

            switch (selectedPlayer)
            {
                case 1:
                    P1Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_303.png", UriKind.Relative)) };
                    player1Char = 113;
                    break;
                case 2:
                    P2Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_303.png", UriKind.Relative)) };
                    player2Char = 113;
                    break;
                case 3:
                    P3Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_303.png", UriKind.Relative)) };
                    player3Char = 113;
                    break;
                case 4:
                    P4Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_303.png", UriKind.Relative)) };
                    player4Char = 113;
                    break;
                case 5:
                    P5Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_303.png", UriKind.Relative)) };
                    player5Char = 113;
                    break;
                case 6:
                    P6Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_303.png", UriKind.Relative)) };
                    player6Char = 113;
                    break;
                case 7:
                    P7Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_303.png", UriKind.Relative)) };
                    player7Char = 113;
                    break;
                case 8:
                    P8Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_303.png", UriKind.Relative)) };
                    player8Char = 113;
                    break;
                case 99:
                    P1Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_303.png", UriKind.Relative)) };
                    player1Char = 113;
                    P2Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_303.png", UriKind.Relative)) };
                    player2Char = 113;
                    P3Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_303.png", UriKind.Relative)) };
                    player3Char = 113;
                    P4Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_303.png", UriKind.Relative)) };
                    player4Char = 113;
                    P5Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_303.png", UriKind.Relative)) };
                    player5Char = 113;
                    P6Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_303.png", UriKind.Relative)) };
                    player6Char = 113;
                    P7Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_303.png", UriKind.Relative)) };
                    player7Char = 113;
                    P8Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_303.png", UriKind.Relative)) };
                    player8Char = 113;
                    break;
                case 100:
                    P3Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_303.png", UriKind.Relative)) };
                    player3Char = 113;
                    P4Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_303.png", UriKind.Relative)) };
                    player4Char = 113;
                    P5Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_303.png", UriKind.Relative)) };
                    player5Char = 113;
                    P6Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_303.png", UriKind.Relative)) };
                    player6Char = 113;
                    P7Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_303.png", UriKind.Relative)) };
                    player7Char = 113;
                    P8Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_303.png", UriKind.Relative)) };
                    player8Char = 113;
                    break;
            }
        }
        private void SpaDownInfinite4_Click(object sender, RoutedEventArgs e)
        {

            switch (selectedPlayer)
            {
                case 1:
                    P1Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_304.png", UriKind.Relative)) };
                    player1Char = 114;
                    break;
                case 2:
                    P2Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_304.png", UriKind.Relative)) };
                    player2Char = 114;
                    break;
                case 3:
                    P3Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_304.png", UriKind.Relative)) };
                    player3Char = 114;
                    break;
                case 4:
                    P4Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_304.png", UriKind.Relative)) };
                    player4Char = 114;
                    break;
                case 5:
                    P5Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_304.png", UriKind.Relative)) };
                    player5Char = 114;
                    break;
                case 6:
                    P6Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_304.png", UriKind.Relative)) };
                    player6Char = 114;
                    break;
                case 7:
                    P7Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_304.png", UriKind.Relative)) };
                    player7Char = 114;
                    break;
                case 8:
                    P8Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_304.png", UriKind.Relative)) };
                    player8Char = 114;
                    break;
                case 99:
                    P1Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_304.png", UriKind.Relative)) };
                    player1Char = 114;
                    P2Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_304.png", UriKind.Relative)) };
                    player2Char = 114;
                    P3Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_304.png", UriKind.Relative)) };
                    player3Char = 114;
                    P4Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_304.png", UriKind.Relative)) };
                    player4Char = 114;
                    P5Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_304.png", UriKind.Relative)) };
                    player5Char = 114;
                    P6Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_304.png", UriKind.Relative)) };
                    player6Char = 114;
                    P7Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_304.png", UriKind.Relative)) };
                    player7Char = 114;
                    P8Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_304.png", UriKind.Relative)) };
                    player8Char = 114;
                    break;
                case 100:
                    P3Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_304.png", UriKind.Relative)) };
                    player3Char = 114;
                    P4Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_304.png", UriKind.Relative)) };
                    player4Char = 114;
                    P5Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_304.png", UriKind.Relative)) };
                    player5Char = 114;
                    P6Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_304.png", UriKind.Relative)) };
                    player6Char = 114;
                    P7Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_304.png", UriKind.Relative)) };
                    player7Char = 114;
                    P8Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_304.png", UriKind.Relative)) };
                    player8Char = 114;
                    break;
            }
        }
        private void SpaDownInfinite5_Click(object sender, RoutedEventArgs e)
        {

            switch (selectedPlayer)
            {
                case 1:
                    P1Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_305.png", UriKind.Relative)) };
                    player1Char = 115;
                    break;
                case 2:
                    P2Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_305.png", UriKind.Relative)) };
                    player2Char = 115;
                    break;
                case 3:
                    P3Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_305.png", UriKind.Relative)) };
                    player3Char = 115;
                    break;
                case 4:
                    P4Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_305.png", UriKind.Relative)) };
                    player4Char = 115;
                    break;
                case 5:
                    P5Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_305.png", UriKind.Relative)) };
                    player5Char = 115;
                    break;
                case 6:
                    P6Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_305.png", UriKind.Relative)) };
                    player6Char = 115;
                    break;
                case 7:
                    P7Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_305.png", UriKind.Relative)) };
                    player7Char = 115;
                    break;
                case 8:
                    P8Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_305.png", UriKind.Relative)) };
                    player8Char = 115;
                    break;
                case 99:
                    P1Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_305.png", UriKind.Relative)) };
                    player1Char = 115;
                    P2Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_305.png", UriKind.Relative)) };
                    player2Char = 115;
                    P3Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_305.png", UriKind.Relative)) };
                    player3Char = 115;
                    P4Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_305.png", UriKind.Relative)) };
                    player4Char = 115;
                    P5Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_305.png", UriKind.Relative)) };
                    player5Char = 115;
                    P6Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_305.png", UriKind.Relative)) };
                    player6Char = 115;
                    P7Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_305.png", UriKind.Relative)) };
                    player7Char = 115;
                    P8Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_305.png", UriKind.Relative)) };
                    player8Char = 115;
                    break;
                case 100:
                    P3Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_305.png", UriKind.Relative)) };
                    player3Char = 115;
                    P4Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_305.png", UriKind.Relative)) };
                    player4Char = 115;
                    P5Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_305.png", UriKind.Relative)) };
                    player5Char = 115;
                    P6Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_305.png", UriKind.Relative)) };
                    player6Char = 115;
                    P7Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_305.png", UriKind.Relative)) };
                    player7Char = 115;
                    P8Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_305.png", UriKind.Relative)) };
                    player8Char = 115;
                    break;
            }
        }
        private void SpaDownInfinite6_Click(object sender, RoutedEventArgs e)
        {

            switch (selectedPlayer)
            {
                case 1:
                    P1Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_306.png", UriKind.Relative)) };
                    player1Char = 116;
                    break;
                case 2:
                    P2Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_306.png", UriKind.Relative)) };
                    player2Char = 116;
                    break;
                case 3:
                    P3Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_306.png", UriKind.Relative)) };
                    player3Char = 116;
                    break;
                case 4:
                    P4Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_306.png", UriKind.Relative)) };
                    player4Char = 116;
                    break;
                case 5:
                    P5Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_306.png", UriKind.Relative)) };
                    player5Char = 116;
                    break;
                case 6:
                    P6Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_306.png", UriKind.Relative)) };
                    player6Char = 116;
                    break;
                case 7:
                    P7Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_306.png", UriKind.Relative)) };
                    player7Char = 116;
                    break;
                case 8:
                    P8Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_306.png", UriKind.Relative)) };
                    player8Char = 116;
                    break;
                case 99:
                    P1Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_306.png", UriKind.Relative)) };
                    player1Char = 116;
                    P2Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_306.png", UriKind.Relative)) };
                    player2Char = 116;
                    P3Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_306.png", UriKind.Relative)) };
                    player3Char = 116;
                    P4Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_306.png", UriKind.Relative)) };
                    player4Char = 116;
                    P5Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_306.png", UriKind.Relative)) };
                    player5Char = 116;
                    P6Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_306.png", UriKind.Relative)) };
                    player6Char = 116;
                    P7Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_306.png", UriKind.Relative)) };
                    player7Char = 116;
                    P8Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_306.png", UriKind.Relative)) };
                    player8Char = 116;
                    break;
                case 100:
                    P3Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_306.png", UriKind.Relative)) };
                    player3Char = 116;
                    P4Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_306.png", UriKind.Relative)) };
                    player4Char = 116;
                    P5Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_306.png", UriKind.Relative)) };
                    player5Char = 116;
                    P6Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_306.png", UriKind.Relative)) };
                    player6Char = 116;
                    P7Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_306.png", UriKind.Relative)) };
                    player7Char = 116;
                    P8Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_306.png", UriKind.Relative)) };
                    player8Char = 116;
                    break;
            }
        }
        private void SpaDownInfinite7_Click(object sender, RoutedEventArgs e)
        {

            switch (selectedPlayer)
            {
                case 1:
                    P1Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_307.png", UriKind.Relative)) };
                    player1Char = 117;
                    break;
                case 2:
                    P2Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_307.png", UriKind.Relative)) };
                    player2Char = 117;
                    break;
                case 3:
                    P3Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_307.png", UriKind.Relative)) };
                    player3Char = 117;
                    break;
                case 4:
                    P4Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_307.png", UriKind.Relative)) };
                    player4Char = 117;
                    break;
                case 5:
                    P5Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_307.png", UriKind.Relative)) };
                    player5Char = 117;
                    break;
                case 6:
                    P6Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_307.png", UriKind.Relative)) };
                    player6Char = 117;
                    break;
                case 7:
                    P7Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_307.png", UriKind.Relative)) };
                    player7Char = 117;
                    break;
                case 8:
                    P8Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_307.png", UriKind.Relative)) };
                    player8Char = 117;
                    break;
                case 99:
                    P1Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_307.png", UriKind.Relative)) };
                    player1Char = 117;
                    P2Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_307.png", UriKind.Relative)) };
                    player2Char = 117;
                    P3Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_307.png", UriKind.Relative)) };
                    player3Char = 117;
                    P4Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_307.png", UriKind.Relative)) };
                    player4Char = 117;
                    P5Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_307.png", UriKind.Relative)) };
                    player5Char = 117;
                    P6Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_307.png", UriKind.Relative)) };
                    player6Char = 117;
                    P7Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_307.png", UriKind.Relative)) };
                    player7Char = 117;
                    P8Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_307.png", UriKind.Relative)) };
                    player8Char = 117;
                    break;
                case 100:
                    P3Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_307.png", UriKind.Relative)) };
                    player3Char = 117;
                    P4Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_307.png", UriKind.Relative)) };
                    player4Char = 117;
                    P5Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_307.png", UriKind.Relative)) };
                    player5Char = 117;
                    P6Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_307.png", UriKind.Relative)) };
                    player6Char = 117;
                    P7Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_307.png", UriKind.Relative)) };
                    player7Char = 117;
                    P8Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_307.png", UriKind.Relative)) };
                    player8Char = 117;
                    break;
            }
        }

        private void SpaDownInfinite8_Click(object sender, RoutedEventArgs e)
        {

            switch (selectedPlayer)
            {
                case 1:
                    P1Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_308.png", UriKind.Relative)) };
                    player1Char = 118;
                    break;
                case 2:
                    P2Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_308.png", UriKind.Relative)) };
                    player2Char = 118;
                    break;
                case 3:
                    P3Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_308.png", UriKind.Relative)) };
                    player3Char = 118;
                    break;
                case 4:
                    P4Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_308.png", UriKind.Relative)) };
                    player4Char = 118;
                    break;
                case 5:
                    P5Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_308.png", UriKind.Relative)) };
                    player5Char = 118;
                    break;
                case 6:
                    P6Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_308.png", UriKind.Relative)) };
                    player6Char = 118;
                    break;
                case 7:
                    P7Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_308.png", UriKind.Relative)) };
                    player7Char = 118;
                    break;
                case 8:
                    P8Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_308.png", UriKind.Relative)) };
                    player8Char = 118;
                    break;
                case 99:
                    P1Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_308.png", UriKind.Relative)) };
                    player1Char = 118;
                    P2Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_308.png", UriKind.Relative)) };
                    player2Char = 118;
                    P3Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_308.png", UriKind.Relative)) };
                    player3Char = 118;
                    P4Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_308.png", UriKind.Relative)) };
                    player4Char = 118;
                    P5Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_308.png", UriKind.Relative)) };
                    player5Char = 118;
                    P6Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_308.png", UriKind.Relative)) };
                    player6Char = 118;
                    P7Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_308.png", UriKind.Relative)) };
                    player7Char = 118;
                    P8Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_308.png", UriKind.Relative)) };
                    player8Char = 118;
                    break;
                case 100:
                    P3Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_308.png", UriKind.Relative)) };
                    player3Char = 118;
                    P4Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_308.png", UriKind.Relative)) };
                    player4Char = 118;
                    P5Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_308.png", UriKind.Relative)) };
                    player5Char = 118;
                    P6Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_308.png", UriKind.Relative)) };
                    player6Char = 118;
                    P7Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_308.png", UriKind.Relative)) };
                    player7Char = 118;
                    P8Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_308.png", UriKind.Relative)) };
                    player8Char = 118;
                    break;
            }
        }

        private void FLY_Click(object sender, RoutedEventArgs e)
        {
            switch (selectedPlayer)
            {
                case 1:
                    P1Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_1000.png", UriKind.Relative)) };
                    player1Char = 1000;
                    break;
                case 2:
                    P2Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_1000.png", UriKind.Relative)) };
                    player2Char = 1000;
                    break;
                case 3:
                    P3Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_1000.png", UriKind.Relative)) };
                    player3Char = 1000;
                    break;
                case 4:
                    P4Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_1000.png", UriKind.Relative)) };
                    player4Char = 1000;
                    break;
                case 5:
                    P5Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_1000.png", UriKind.Relative)) };
                    player5Char = 1000;
                    break;
                case 6:
                    P6Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_1000.png", UriKind.Relative)) };
                    player6Char = 1000;
                    break;
                case 7:
                    P7Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_1000.png", UriKind.Relative)) };
                    player7Char = 1000;
                    break;
                case 8:
                    P8Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_1000.png", UriKind.Relative)) };
                    player8Char = 1000;
                    break;
                case 99:
                    P1Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_1000.png", UriKind.Relative)) };
                    player1Char = 1000;
                    P2Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_1000.png", UriKind.Relative)) };
                    player2Char = 1000;
                    P3Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_1000.png", UriKind.Relative)) };
                    player3Char = 1000;
                    P4Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_1000.png", UriKind.Relative)) };
                    player4Char = 1000;
                    P5Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_1000.png", UriKind.Relative)) };
                    player5Char = 1000;
                    P6Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_1000.png", UriKind.Relative)) };
                    player6Char = 1000;
                    P7Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_1000.png", UriKind.Relative)) };
                    player7Char = 1000;
                    P8Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_1000.png", UriKind.Relative)) };
                    player8Char = 1000;
                    break;
                case 100:
                    P3Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_1000.png", UriKind.Relative)) };
                    player3Char = 1000;
                    P4Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_1000.png", UriKind.Relative)) };
                    player4Char = 1000;
                    P5Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_1000.png", UriKind.Relative)) };
                    player5Char = 1000;
                    P6Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_1000.png", UriKind.Relative)) };
                    player6Char = 1000;
                    P7Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_1000.png", UriKind.Relative)) };
                    player7Char = 1000;
                    P8Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_1000.png", UriKind.Relative)) };
                    player8Char = 1000;
                    break;
            }
        }


        private void StrifeSurge_Click(object sender, RoutedEventArgs e)
        {
            switch (selectedPlayer)
            {
                case 1:
                    P1Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_118.png", UriKind.Relative)) };
                    player1Char = 119;
                    break;
                case 2:
                    P2Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_118.png", UriKind.Relative)) };
                    player2Char = 119;
                    break;
                case 3:
                    P3Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_118.png", UriKind.Relative)) };
                    player3Char = 119;
                    break;
                case 4:
                    P4Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_118.png", UriKind.Relative)) };
                    player4Char = 119;
                    break;
                case 5:
                    P5Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_118.png", UriKind.Relative)) };
                    player5Char = 119;
                    break;
                case 6:
                    P6Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_118.png", UriKind.Relative)) };
                    player6Char = 119;
                    break;
                case 7:
                    P7Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_118.png", UriKind.Relative)) };
                    player7Char = 119;
                    break;
                case 8:
                    P8Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_118.png", UriKind.Relative)) };
                    player8Char = 119;
                    break;
                case 99:
                    P1Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_118.png", UriKind.Relative)) };
                    player1Char = 119;
                    P2Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_118.png", UriKind.Relative)) };
                    player2Char = 119;
                    P3Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_118.png", UriKind.Relative)) };
                    player3Char = 119;
                    P4Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_118.png", UriKind.Relative)) };
                    player4Char = 119;
                    P5Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_118.png", UriKind.Relative)) };
                    player5Char = 119;
                    P6Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_118.png", UriKind.Relative)) };
                    player6Char = 119;
                    P7Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_118.png", UriKind.Relative)) };
                    player7Char = 119;
                    P8Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_118.png", UriKind.Relative)) };
                    player8Char = 119;
                    break;
                case 100:
                    P3Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_118.png", UriKind.Relative)) };
                    player3Char = 119;
                    P4Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_118.png", UriKind.Relative)) };
                    player4Char = 119;
                    P5Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_118.png", UriKind.Relative)) };
                    player5Char = 119;
                    P6Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_118.png", UriKind.Relative)) };
                    player6Char = 119;
                    P7Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_118.png", UriKind.Relative)) };
                    player7Char = 119;
                    P8Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_118.png", UriKind.Relative)) };
                    player8Char = 119;
                    break;
            }
        }


        private void SpaDownInfiniteCustom1_Click(object sender, RoutedEventArgs e)
        {
            switch (selectedPlayer)
            {
                case 1:
                    P1Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_311.png", UriKind.Relative)) };
                    player1Char = 121;
                    break;
                case 2:
                    P2Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_311.png", UriKind.Relative)) };
                    player2Char = 121;
                    break;
                case 3:
                    P3Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_311.png", UriKind.Relative)) };
                    player3Char = 121;
                    break;
                case 4:
                    P4Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_311.png", UriKind.Relative)) };
                    player4Char = 121;
                    break;
                case 5:
                    P5Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_311.png", UriKind.Relative)) };
                    player5Char = 121;
                    break;
                case 6:
                    P6Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_311.png", UriKind.Relative)) };
                    player6Char = 121;
                    break;
                case 7:
                    P7Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_311.png", UriKind.Relative)) };
                    player7Char = 121;
                    break;
                case 8:
                    P8Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_311.png", UriKind.Relative)) };
                    player8Char = 121;
                    break;
                case 99:
                    P1Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_311.png", UriKind.Relative)) };
                    player1Char = 121;
                    P2Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_311.png", UriKind.Relative)) };
                    player2Char = 121;
                    P3Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_311.png", UriKind.Relative)) };
                    player3Char = 121;
                    P4Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_311.png", UriKind.Relative)) };
                    player4Char = 121;
                    P5Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_311.png", UriKind.Relative)) };
                    player5Char = 121;
                    P6Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_311.png", UriKind.Relative)) };
                    player6Char = 121;
                    P7Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_311.png", UriKind.Relative)) };
                    player7Char = 121;
                    P8Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_311.png", UriKind.Relative)) };
                    player8Char = 121;
                    break;
                case 100:
                    P3Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_311.png", UriKind.Relative)) };
                    player3Char = 121;
                    P4Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_311.png", UriKind.Relative)) };
                    player4Char = 121;
                    P5Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_311.png", UriKind.Relative)) };
                    player5Char = 121;
                    P6Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_311.png", UriKind.Relative)) };
                    player6Char = 121;
                    P7Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_311.png", UriKind.Relative)) };
                    player7Char = 121;
                    P8Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_311.png", UriKind.Relative)) };
                    player8Char = 121;
                    break;
            }
        }


        private void SpaDownInfiniteCustom2_Click(object sender, RoutedEventArgs e)
        {
            switch (selectedPlayer)
            {
                case 1:
                    P1Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_312.png", UriKind.Relative)) };
                    player1Char = 122;
                    break;
                case 2:
                    P2Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_312.png", UriKind.Relative)) };
                    player2Char = 122;
                    break;
                case 3:
                    P3Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_312.png", UriKind.Relative)) };
                    player3Char = 122;
                    break;
                case 4:
                    P4Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_312.png", UriKind.Relative)) };
                    player4Char = 122;
                    break;
                case 5:
                    P5Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_312.png", UriKind.Relative)) };
                    player5Char = 122;
                    break;
                case 6:
                    P6Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_312.png", UriKind.Relative)) };
                    player6Char = 122;
                    break;
                case 7:
                    P7Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_312.png", UriKind.Relative)) };
                    player7Char = 122;
                    break;
                case 8:
                    P8Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_312.png", UriKind.Relative)) };
                    player8Char = 122;
                    break;
                case 99:
                    P1Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_312.png", UriKind.Relative)) };
                    player1Char = 122;
                    P2Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_312.png", UriKind.Relative)) };
                    player2Char = 122;
                    P3Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_312.png", UriKind.Relative)) };
                    player3Char = 122;
                    P4Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_312.png", UriKind.Relative)) };
                    player4Char = 122;
                    P5Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_312.png", UriKind.Relative)) };
                    player5Char = 122;
                    P6Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_312.png", UriKind.Relative)) };
                    player6Char = 122;
                    P7Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_312.png", UriKind.Relative)) };
                    player7Char = 122;
                    P8Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_312.png", UriKind.Relative)) };
                    player8Char = 122;
                    break;
                case 100:
                    P3Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_312.png", UriKind.Relative)) };
                    player3Char = 122;
                    P4Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_312.png", UriKind.Relative)) };
                    player4Char = 122;
                    P5Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_312.png", UriKind.Relative)) };
                    player5Char = 122;
                    P6Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_312.png", UriKind.Relative)) };
                    player6Char = 122;
                    P7Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_312.png", UriKind.Relative)) };
                    player7Char = 122;
                    P8Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_312.png", UriKind.Relative)) };
                    player8Char = 122;
                    break;
            }
        }

        private void SupermanFlight_Click(object sender, RoutedEventArgs e)
        {
            switch (selectedPlayer)
            {
                case 1:
                    P1Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_119.png", UriKind.Relative)) };
                    player1Char = 19;
                    break;
                case 2:
                    P2Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_119.png", UriKind.Relative)) };
                    player2Char = 19;
                    break;
                case 3:
                    P3Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_119.png", UriKind.Relative)) };
                    player3Char = 19;
                    break;
                case 4:
                    P4Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_119.png", UriKind.Relative)) };
                    player4Char = 19;
                    break;
                case 5:
                    P5Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_119.png", UriKind.Relative)) };
                    player5Char = 19;
                    break;
                case 6:
                    P6Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_119.png", UriKind.Relative)) };
                    player6Char = 19;
                    break;
                case 7:
                    P7Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_119.png", UriKind.Relative)) };
                    player7Char = 19;
                    break;
                case 8:
                    P8Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_119.png", UriKind.Relative)) };
                    player8Char = 19;
                    break;
                case 99:
                    P1Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_119.png", UriKind.Relative)) };
                    player1Char = 19;
                    P2Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_119.png", UriKind.Relative)) };
                    player2Char = 19;
                    P3Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_119.png", UriKind.Relative)) };
                    player3Char = 19;
                    P4Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_119.png", UriKind.Relative)) };
                    player4Char = 19;
                    P5Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_119.png", UriKind.Relative)) };
                    player5Char = 19;
                    P6Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_119.png", UriKind.Relative)) };
                    player6Char = 19;
                    P7Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_119.png", UriKind.Relative)) };
                    player7Char = 19;
                    P8Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_119.png", UriKind.Relative)) };
                    player8Char = 19;
                    break;
                case 100:
                    P3Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_119.png", UriKind.Relative)) };
                    player3Char = 19;
                    P4Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_119.png", UriKind.Relative)) };
                    player4Char = 19;
                    P5Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_119.png", UriKind.Relative)) };
                    player5Char = 19;
                    P6Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_119.png", UriKind.Relative)) };
                    player6Char = 19;
                    P7Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_119.png", UriKind.Relative)) };
                    player7Char = 19;
                    P8Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_119.png", UriKind.Relative)) };
                    player8Char = 19;
                    break;
            }
        }

        private void DevilJinPower_Click(object sender, RoutedEventArgs e)
        {
            switch (selectedPlayer)
            {
                case 1:
                    P1Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_120.png", UriKind.Relative)) };
                    player1Char = 20;
                    break;
                case 2:
                    P2Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_120.png", UriKind.Relative)) };
                    player2Char = 20;
                    break;
                case 3:
                    P3Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_120.png", UriKind.Relative)) };
                    player3Char = 20;
                    break;
                case 4:
                    P4Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_120.png", UriKind.Relative)) };
                    player4Char = 20;
                    break;
                case 5:
                    P5Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_120.png", UriKind.Relative)) };
                    player5Char = 20;
                    break;
                case 6:
                    P6Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_120.png", UriKind.Relative)) };
                    player6Char = 20;
                    break;
                case 7:
                    P7Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_120.png", UriKind.Relative)) };
                    player7Char = 20;
                    break;
                case 8:
                    P8Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_120.png", UriKind.Relative)) };
                    player8Char = 20;
                    break;
                case 99:
                    P1Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_120.png", UriKind.Relative)) };
                    player1Char = 20;
                    P2Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_120.png", UriKind.Relative)) };
                    player2Char = 20;
                    P3Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_120.png", UriKind.Relative)) };
                    player3Char = 20;
                    P4Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_120.png", UriKind.Relative)) };
                    player4Char = 20;
                    P5Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_120.png", UriKind.Relative)) };
                    player5Char = 20;
                    P6Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_120.png", UriKind.Relative)) };
                    player6Char = 20;
                    P7Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_120.png", UriKind.Relative)) };
                    player7Char = 20;
                    P8Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_120.png", UriKind.Relative)) };
                    player8Char = 20;
                    break;
                case 100:
                    P3Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_120.png", UriKind.Relative)) };
                    player3Char = 20;
                    P4Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_120.png", UriKind.Relative)) };
                    player4Char = 20;
                    P5Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_120.png", UriKind.Relative)) };
                    player5Char = 20;
                    P6Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_120.png", UriKind.Relative)) };
                    player6Char = 20;
                    P7Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_120.png", UriKind.Relative)) };
                    player7Char = 20;
                    P8Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_120.png", UriKind.Relative)) };
                    player8Char = 20;
                    break;
            }
        }

        private void PoisonedChar_Click(object sender, RoutedEventArgs e)
        {
            switch (selectedPlayer)
            {
                case 1:
                    P1Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_321.png", UriKind.Relative)) };
                    player1Char = 21;
                    break;
                case 2:
                    P2Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_321.png", UriKind.Relative)) };
                    player2Char = 21;
                    break;
                case 3:
                    P3Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_321.png", UriKind.Relative)) };
                    player3Char = 21;
                    break;
                case 4:
                    P4Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_321.png", UriKind.Relative)) };
                    player4Char = 21;
                    break;
                case 5:
                    P5Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_321.png", UriKind.Relative)) };
                    player5Char = 21;
                    break;
                case 6:
                    P6Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_321.png", UriKind.Relative)) };
                    player6Char = 21;
                    break;
                case 7:
                    P7Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_321.png", UriKind.Relative)) };
                    player7Char = 21;
                    break;
                case 8:
                    P8Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_321.png", UriKind.Relative)) };
                    player8Char = 21;
                    break;
                case 99:
                    P1Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_321.png", UriKind.Relative)) };
                    player1Char = 21;
                    P2Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_321.png", UriKind.Relative)) };
                    player2Char = 21;
                    P3Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_321.png", UriKind.Relative)) };
                    player3Char = 21;
                    P4Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_321.png", UriKind.Relative)) };
                    player4Char = 21;
                    P5Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_321.png", UriKind.Relative)) };
                    player5Char = 21;
                    P6Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_321.png", UriKind.Relative)) };
                    player6Char = 21;
                    P7Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_321.png", UriKind.Relative)) };
                    player7Char = 21;
                    P8Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_321.png", UriKind.Relative)) };
                    player8Char = 21;
                    break;
                case 100:
                    P3Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_321.png", UriKind.Relative)) };
                    player3Char = 21;
                    P4Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_321.png", UriKind.Relative)) };
                    player4Char = 21;
                    P5Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_321.png", UriKind.Relative)) };
                    player5Char = 21;
                    P6Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_321.png", UriKind.Relative)) };
                    player6Char = 21;
                    P7Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_321.png", UriKind.Relative)) };
                    player7Char = 21;
                    P8Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_321.png", UriKind.Relative)) };
                    player8Char = 21;
                    break;
            }
        }

        private void PowerOverTimeChar_Click(object sender, RoutedEventArgs e)
        {
            switch (selectedPlayer)
            {
                case 1:
                    P1Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_322.png", UriKind.Relative)) };
                    player1Char = 22;
                    break;
                case 2:
                    P2Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_322.png", UriKind.Relative)) };
                    player2Char = 22;
                    break;
                case 3:
                    P3Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_322.png", UriKind.Relative)) };
                    player3Char = 22;
                    break;
                case 4:
                    P4Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_322.png", UriKind.Relative)) };
                    player4Char = 22;
                    break;
                case 5:
                    P5Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_322.png", UriKind.Relative)) };
                    player5Char = 22;
                    break;
                case 6:
                    P6Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_322.png", UriKind.Relative)) };
                    player6Char = 22;
                    break;
                case 7:
                    P7Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_322.png", UriKind.Relative)) };
                    player7Char = 22;
                    break;
                case 8:
                    P8Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_322.png", UriKind.Relative)) };
                    player8Char = 22;
                    break;
                case 99:
                    P1Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_322.png", UriKind.Relative)) };
                    player1Char = 22;
                    P2Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_322.png", UriKind.Relative)) };
                    player2Char = 22;
                    P3Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_322.png", UriKind.Relative)) };
                    player3Char = 22;
                    P4Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_322.png", UriKind.Relative)) };
                    player4Char = 22;
                    P5Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_322.png", UriKind.Relative)) };
                    player5Char = 22;
                    P6Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_322.png", UriKind.Relative)) };
                    player6Char = 22;
                    P7Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_322.png", UriKind.Relative)) };
                    player7Char = 22;
                    P8Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_322.png", UriKind.Relative)) };
                    player8Char = 22;
                    break;
                case 100:
                    P3Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_322.png", UriKind.Relative)) };
                    player3Char = 22;
                    P4Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_322.png", UriKind.Relative)) };
                    player4Char = 22;
                    P5Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_322.png", UriKind.Relative)) };
                    player5Char = 22;
                    P6Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_322.png", UriKind.Relative)) };
                    player6Char = 22;
                    P7Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_322.png", UriKind.Relative)) };
                    player7Char = 22;
                    P8Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/img_322.png", UriKind.Relative)) };
                    player8Char = 22;
                    break;
            }
        }

        #endregion
        private void GoToMainPage_Click(object sender, RoutedEventArgs e)
        {
            viewModel.DisplayMainView();
        }

        #region Characters Stats

        private void Napalm_MouseEnter(object sender, MouseEventArgs e)
        {
            viewModel.StrikePoints = "" + 1700;
            viewModel.GrapplePoints = "" + 1600;
            viewModel.RegionalPoints = "" + 1450;
            viewModel.SpecialPoints = "" + 1200;
            viewModel.WeaponPoints = "" + 900;
            viewModel.ToughnessPoints = "" + 1800;
            viewModel.HeadEndurancePoints = "" + 1100;
            viewModel.UpperBodyEndurancePoints = "" + 1100;
            viewModel.LowerBodyEndurancePoints = "" + 1100;
            viewModel.SpecialArtDownPoints = "" + "pow+arm";
            viewModel.SPARecoveryPoints = "" + "24";
            viewModel.UltraInstinct = "" + "";
            viewModel.WeaponGrip = "" + "";
        }

        private void Shinkai_MouseEnter(object sender, MouseEventArgs e)
        {
            viewModel.StrikePoints = "" + 900;
            viewModel.GrapplePoints = "" + 900;
            viewModel.RegionalPoints = "" + 1100;
            viewModel.SpecialPoints = "" + 1400;
            viewModel.WeaponPoints = "" + 3000;
            viewModel.ToughnessPoints = "" + 1200;
            viewModel.HeadEndurancePoints = "" + 800;
            viewModel.UpperBodyEndurancePoints = "" + 800;
            viewModel.LowerBodyEndurancePoints = "" + 800;
            viewModel.SpecialArtDownPoints = "" + "pow+arm";
            viewModel.SPARecoveryPoints = "" + "32";
            viewModel.UltraInstinct = "" + "full";
            viewModel.WeaponGrip = "" + "3";
        }
        private void Suspect_MouseEnter(object sender, MouseEventArgs e)
        {
            viewModel.StrikePoints = "" + 1000;
            viewModel.GrapplePoints = "" + 1000;
            viewModel.RegionalPoints = "" + 1000;
            viewModel.SpecialPoints = "" + 1000;
            viewModel.WeaponPoints = "" + 1000;
            viewModel.ToughnessPoints = "" + 1000;
            viewModel.HeadEndurancePoints = "" + 1000;
            viewModel.UpperBodyEndurancePoints = "" + 1000;
            viewModel.LowerBodyEndurancePoints = "" + 1000;
            viewModel.SpecialArtDownPoints = "" + "";
            viewModel.SPARecoveryPoints = "" + "32";
            viewModel.UltraInstinct = "" + "";
            viewModel.WeaponGrip = "" + "2";
        }
        private void Kadonashi_MouseEnter(object sender, MouseEventArgs e)
        {
            viewModel.StrikePoints = "" + 1100;
            viewModel.GrapplePoints = "" + 700;
            viewModel.RegionalPoints = "" + 800;
            viewModel.SpecialPoints = "" + 800;
            viewModel.WeaponPoints = "" + 850;
            viewModel.ToughnessPoints = "" + 800;
            viewModel.HeadEndurancePoints = "" + 700;
            viewModel.UpperBodyEndurancePoints = "" + 700;
            viewModel.LowerBodyEndurancePoints = "" + 800;
            viewModel.SpecialArtDownPoints = "" + "GUARD";
            viewModel.SPARecoveryPoints = "" + "";
            viewModel.UltraInstinct = "" + "grabs";
            viewModel.WeaponGrip = "" + "";
        }

        private void BradShark_MouseEnter(object sender, MouseEventArgs e)
        {
            viewModel.StrikePoints = "" + 2000;
            viewModel.GrapplePoints = "" + 2000;
            viewModel.RegionalPoints = "" + 2000;
            viewModel.SpecialPoints = "" + 2000;
            viewModel.WeaponPoints = "" + 2000;
            viewModel.ToughnessPoints = "" + 2000;
            viewModel.HeadEndurancePoints = "" + 2000;
            viewModel.UpperBodyEndurancePoints = "" + 2000;
            viewModel.LowerBodyEndurancePoints = "" + 2000;
            viewModel.SpecialArtDownPoints = "" + "POW+ARM";
            viewModel.SPARecoveryPoints = "" + "";
            viewModel.UltraInstinct = "" + "full";
            viewModel.WeaponGrip = "" + "";
        }

        private void ElMiguel_MouseEnter(object sender, MouseEventArgs e)
        {
            viewModel.StrikePoints = "" + 5000;
            viewModel.GrapplePoints = "" + 5000;
            viewModel.RegionalPoints = "" + 5000;
            viewModel.SpecialPoints = "" + 5000;
            viewModel.WeaponPoints = "" + 5000;
            viewModel.ToughnessPoints = "" + 200;
            viewModel.HeadEndurancePoints = "" + 200;
            viewModel.UpperBodyEndurancePoints = "" + 200;
            viewModel.LowerBodyEndurancePoints = "" + 200;
            viewModel.SpecialArtDownPoints = "" + "";
            viewModel.SPARecoveryPoints = "" + "";
            viewModel.UltraInstinct = "" + "";
            viewModel.WeaponGrip = "" + "";
        }

        private void BeatenKg_MouseEnter(object sender, MouseEventArgs e)
        {
            viewModel.StrikePoints = "" + 480;
            viewModel.GrapplePoints = "" + 470;
            viewModel.RegionalPoints = "" + 480;
            viewModel.SpecialPoints = "" + 470;
            viewModel.WeaponPoints = "" + 420;
            viewModel.ToughnessPoints = "" + 300;
            viewModel.HeadEndurancePoints = "" + 100;
            viewModel.UpperBodyEndurancePoints = "" + 200;
            viewModel.LowerBodyEndurancePoints = "" + 100;
            viewModel.SpecialArtDownPoints = "" + "";
            viewModel.SPARecoveryPoints = "" + "4";
            viewModel.UltraInstinct = "" + "";
            viewModel.WeaponGrip = "" + "";
        }

        private void BradHawkBeginner_MouseEnter(object sender, MouseEventArgs e)
        {
            viewModel.StrikePoints = "" + 665;
            viewModel.GrapplePoints = "" + 595;
            viewModel.RegionalPoints = "" + 595;
            viewModel.SpecialPoints = "" + 630;
            viewModel.WeaponPoints = "" + 560;
            viewModel.ToughnessPoints = "" + 630;
            viewModel.HeadEndurancePoints = "" + 560;
            viewModel.UpperBodyEndurancePoints = "" + 630;
            viewModel.LowerBodyEndurancePoints = "" + 490;
            viewModel.SpecialArtDownPoints = "" + "none";
            viewModel.SPARecoveryPoints = "" + "";
            viewModel.UltraInstinct = "" + "";
            viewModel.WeaponGrip = "" + "0";
        }

        private void Nightmare_MouseEnter(object sender, MouseEventArgs e)
        {
            viewModel.StrikePoints = "" + 1800;
            viewModel.GrapplePoints = "" + 1900;
            viewModel.RegionalPoints = "" + 1600;
            viewModel.SpecialPoints = "" + 1400;
            viewModel.WeaponPoints = "" + 1000;
            viewModel.ToughnessPoints = "" + 2400;
            viewModel.HeadEndurancePoints = "" + 1200;
            viewModel.UpperBodyEndurancePoints = "" + 1000;
            viewModel.LowerBodyEndurancePoints = "" + 800;
            viewModel.SpecialArtDownPoints = "" + "POW+ARM";
            viewModel.SPARecoveryPoints = "" + "";
            viewModel.UltraInstinct = "" + "";
            viewModel.WeaponGrip = "" + "";
        }

        private void ShunYing_MouseEnter(object sender, MouseEventArgs e)
        {
            viewModel.StrikePoints = "" + 780;
            viewModel.GrapplePoints = "" + 700;
            viewModel.RegionalPoints = "" + 880;
            viewModel.SpecialPoints = "" + 900;
            viewModel.WeaponPoints = "" + 1100;
            viewModel.ToughnessPoints = "" + 850;
            viewModel.HeadEndurancePoints = "" + 400;
            viewModel.UpperBodyEndurancePoints = "" + 600;
            viewModel.LowerBodyEndurancePoints = "" + 500;
            viewModel.SpecialArtDownPoints = "" + "pow+def";
            viewModel.SPARecoveryPoints = "" + "64";
            viewModel.UltraInstinct = "" + "hits";
            viewModel.WeaponGrip = "" + "";
        }

        private void Bordin_MouseEnter(object sender, MouseEventArgs e)
        {
            viewModel.StrikePoints = "500";
            viewModel.GrapplePoints = "450";
            viewModel.RegionalPoints = "500";
            viewModel.SpecialPoints = "450";
            viewModel.WeaponPoints = "500";
            viewModel.ToughnessPoints = "40";
            viewModel.HeadEndurancePoints = "200";
            viewModel.UpperBodyEndurancePoints = "300";
            viewModel.LowerBodyEndurancePoints = "200";
            viewModel.SpecialArtDownPoints = "pow+def";
            viewModel.SPARecoveryPoints = "";
            viewModel.UltraInstinct = "";
            viewModel.WeaponGrip = "" + "3";
        }

        private void Paul_MouseEnter(object sender, MouseEventArgs e)
        {
            viewModel.StrikePoints = "2500";
            viewModel.GrapplePoints = "1200";
            viewModel.RegionalPoints = "950";
            viewModel.SpecialPoints = "900";
            viewModel.WeaponPoints = "650";
            viewModel.ToughnessPoints = "1000";
            viewModel.HeadEndurancePoints = "900";
            viewModel.UpperBodyEndurancePoints = "900";
            viewModel.LowerBodyEndurancePoints = "800";
            viewModel.SpecialArtDownPoints = "pow+move";
            viewModel.SPARecoveryPoints = "";
            viewModel.UltraInstinct = "";
            viewModel.WeaponGrip = "" + "";
        }


        private void Law_MouseEnter(object sender, MouseEventArgs e)
        {
            viewModel.StrikePoints = "1500";
            viewModel.GrapplePoints = "1050";
            viewModel.RegionalPoints = "850";
            viewModel.SpecialPoints = "2200";
            viewModel.WeaponPoints = "950";
            viewModel.ToughnessPoints = "1000";
            viewModel.HeadEndurancePoints = "800";
            viewModel.UpperBodyEndurancePoints = "800";
            viewModel.LowerBodyEndurancePoints = "750";
            viewModel.SpecialArtDownPoints = "pow+move";
            viewModel.SPARecoveryPoints = "";
            viewModel.UltraInstinct = "";
            viewModel.WeaponGrip = "" + "";
        }

        private void Mckinzie_MouseEnter(object sender, MouseEventArgs e)
        {
            viewModel.StrikePoints = "1200";
            viewModel.GrapplePoints = "1200";
            viewModel.RegionalPoints = "2100";
            viewModel.SpecialPoints = "1150";
            viewModel.WeaponPoints = "1550";
            viewModel.ToughnessPoints = "1100";
            viewModel.HeadEndurancePoints = "850";
            viewModel.UpperBodyEndurancePoints = "850";
            viewModel.LowerBodyEndurancePoints = "800";
            viewModel.SpecialArtDownPoints = "pow+def";
            viewModel.SPARecoveryPoints = "";
            viewModel.UltraInstinct = "";
            viewModel.WeaponGrip = "" + "";
        }

        private void KG_Zombie_MouseEnter(object sender, MouseEventArgs e)
        {
            viewModel.StrikePoints = "440";
            viewModel.GrapplePoints = "430";
            viewModel.RegionalPoints = "420";
            viewModel.SpecialPoints = "450";
            viewModel.WeaponPoints = "400";
            viewModel.ToughnessPoints = "5000";
            viewModel.HeadEndurancePoints = "50";
            viewModel.UpperBodyEndurancePoints = "100";
            viewModel.LowerBodyEndurancePoints = "100";
            viewModel.SpecialArtDownPoints = "ARMOR";
            viewModel.SPARecoveryPoints = "";
            viewModel.UltraInstinct = "";
            viewModel.WeaponGrip = "" + "";
        }

        private void MaxPowerUp_MouseEnter(object sender, MouseEventArgs e)
        {
            viewModel.StrikePoints = "1500";
            viewModel.GrapplePoints = "1500";
            viewModel.RegionalPoints = "1500";
            viewModel.SpecialPoints = "1500";
            viewModel.WeaponPoints = "1500";
            viewModel.ToughnessPoints = "1500";
            viewModel.HeadEndurancePoints = "1500";
            viewModel.UpperBodyEndurancePoints = "1500";
            viewModel.LowerBodyEndurancePoints = "1500";
            viewModel.SpecialArtDownPoints = "";
            viewModel.SPARecoveryPoints = "";
            viewModel.UltraInstinct = "";
            viewModel.WeaponGrip = "" + "";
        }

        private void OnlyWeapon_MouseEnter(object sender, MouseEventArgs e)
        {
            viewModel.StrikePoints = "10";
            viewModel.GrapplePoints = "10";
            viewModel.RegionalPoints = "10";
            viewModel.SpecialPoints = "10";
            viewModel.WeaponPoints = "2000";
            viewModel.ToughnessPoints = "";
            viewModel.HeadEndurancePoints = "";
            viewModel.UpperBodyEndurancePoints = "";
            viewModel.LowerBodyEndurancePoints = "";
            viewModel.SpecialArtDownPoints = "";
            viewModel.SPARecoveryPoints = "";
            viewModel.UltraInstinct = "";
            viewModel.WeaponGrip = "" + "3";
        }

        private void DeadPlayer_MouseEnter(object sender, MouseEventArgs e)
        {
            viewModel.StrikePoints = "";
            viewModel.GrapplePoints = "";
            viewModel.RegionalPoints = "";
            viewModel.SpecialPoints = "";
            viewModel.WeaponPoints = "";
            viewModel.ToughnessPoints = "DEAD";
            viewModel.HeadEndurancePoints = "";
            viewModel.UpperBodyEndurancePoints = "";
            viewModel.LowerBodyEndurancePoints = "";
            viewModel.SpecialArtDownPoints = "";
            viewModel.SPARecoveryPoints = "";
            viewModel.UltraInstinct = "";
            viewModel.WeaponGrip = "" + "";
        }

        private void WeakPlayer_MouseEnter(object sender, MouseEventArgs e)
        {
            viewModel.StrikePoints = "";
            viewModel.GrapplePoints = "";
            viewModel.RegionalPoints = "";
            viewModel.SpecialPoints = "";
            viewModel.WeaponPoints = "";
            viewModel.ToughnessPoints = "250";
            viewModel.HeadEndurancePoints = "";
            viewModel.UpperBodyEndurancePoints = "";
            viewModel.LowerBodyEndurancePoints = "";
            viewModel.SpecialArtDownPoints = "";
            viewModel.SPARecoveryPoints = "";
            viewModel.UltraInstinct = "";
            viewModel.WeaponGrip = "" + "0";
        }

        private void StrongPLayer_MouseEnter(object sender, MouseEventArgs e)
        {
            viewModel.StrikePoints = "";
            viewModel.GrapplePoints = "";
            viewModel.RegionalPoints = "";
            viewModel.SpecialPoints = "";
            viewModel.WeaponPoints = "";
            viewModel.ToughnessPoints = "1000";
            viewModel.HeadEndurancePoints = "";
            viewModel.UpperBodyEndurancePoints = "";
            viewModel.LowerBodyEndurancePoints = "";
            viewModel.SpecialArtDownPoints = "";
            viewModel.SPARecoveryPoints = "";
            viewModel.UltraInstinct = "";
            viewModel.WeaponGrip = "" + "1";
        }

        private void TankPlayer_MouseEnter(object sender, MouseEventArgs e)
        {
            viewModel.StrikePoints = "";
            viewModel.GrapplePoints = "";
            viewModel.RegionalPoints = "";
            viewModel.SpecialPoints = "";
            viewModel.WeaponPoints = "";
            viewModel.ToughnessPoints = "3000";
            viewModel.HeadEndurancePoints = "20000";
            viewModel.UpperBodyEndurancePoints = "20000";
            viewModel.LowerBodyEndurancePoints = "20000";
            viewModel.SpecialArtDownPoints = "";
            viewModel.SPARecoveryPoints = "";
            viewModel.UltraInstinct = "";
            viewModel.WeaponGrip = "" + "2";
        }

        private void BeatUpPlayer_MouseEnter(object sender, MouseEventArgs e)
        {
            viewModel.StrikePoints = "";
            viewModel.GrapplePoints = "";
            viewModel.RegionalPoints = "";
            viewModel.SpecialPoints = "";
            viewModel.WeaponPoints = "";
            viewModel.ToughnessPoints = "";
            viewModel.HeadEndurancePoints = "0";
            viewModel.UpperBodyEndurancePoints = "0";
            viewModel.LowerBodyEndurancePoints = "0";
            viewModel.SpecialArtDownPoints = "";
            viewModel.SPARecoveryPoints = "";
            viewModel.UltraInstinct = "";
            viewModel.WeaponGrip = "" + "0";
        }

        private void NoSPA_Player_MouseEnter(object sender, MouseEventArgs e)
        {
            viewModel.StrikePoints = "";
            viewModel.GrapplePoints = "";
            viewModel.RegionalPoints = "";
            viewModel.SpecialPoints = "";
            viewModel.WeaponPoints = "";
            viewModel.ToughnessPoints = "";
            viewModel.HeadEndurancePoints = "";
            viewModel.UpperBodyEndurancePoints = "";
            viewModel.LowerBodyEndurancePoints = "";
            viewModel.SpecialArtDownPoints = "";
            viewModel.SPARecoveryPoints = "NULL";
            viewModel.UltraInstinct = "";
            viewModel.WeaponGrip = "" + "";
        }


        private void InfiniteSPA__MouseEnter(object sender, MouseEventArgs e)
        {
            viewModel.StrikePoints = "";
            viewModel.GrapplePoints = "";
            viewModel.RegionalPoints = "";
            viewModel.SpecialPoints = "";
            viewModel.WeaponPoints = "";
            viewModel.ToughnessPoints = "";
            viewModel.HeadEndurancePoints = "";
            viewModel.UpperBodyEndurancePoints = "";
            viewModel.LowerBodyEndurancePoints = "";
            viewModel.SpecialArtDownPoints = "";
            viewModel.SPARecoveryPoints = "infinite";
            viewModel.UltraInstinct = "";
            viewModel.WeaponGrip = "" + "";
        }

        private void UltraInstinctPlayer_MouseEnter(object sender, MouseEventArgs e)
        {
            viewModel.StrikePoints = "";
            viewModel.GrapplePoints = "";
            viewModel.RegionalPoints = "";
            viewModel.SpecialPoints = "";
            viewModel.WeaponPoints = "";
            viewModel.ToughnessPoints = "";
            viewModel.HeadEndurancePoints = "";
            viewModel.UpperBodyEndurancePoints = "";
            viewModel.LowerBodyEndurancePoints = "";
            viewModel.SpecialArtDownPoints = "";
            viewModel.SPARecoveryPoints = "";
            viewModel.UltraInstinct = "full";
            viewModel.WeaponGrip = "" + "";
        }

        private void RandomStats_MouseEnter(object sender, MouseEventArgs e)
        {
            viewModel.StrikePoints = "???";
            viewModel.GrapplePoints = "???";
            viewModel.RegionalPoints = "???";
            viewModel.SpecialPoints = "???";
            viewModel.WeaponPoints = "???";
            viewModel.ToughnessPoints = "???";
            viewModel.HeadEndurancePoints = "???";
            viewModel.UpperBodyEndurancePoints = "???";
            viewModel.LowerBodyEndurancePoints = "???";
            viewModel.SpecialArtDownPoints = "???";
            viewModel.SPARecoveryPoints = "???";
            viewModel.UltraInstinct = "???";
            viewModel.WeaponGrip = "";
        }

        private void None_MouseEnter(object sender, MouseEventArgs e)
        {
            viewModel.StrikePoints = "default";
            viewModel.GrapplePoints = "default";
            viewModel.RegionalPoints = "default";
            viewModel.SpecialPoints = "default";
            viewModel.WeaponPoints = "default";
            viewModel.ToughnessPoints = "default";
            viewModel.HeadEndurancePoints = "default";
            viewModel.UpperBodyEndurancePoints = "default";
            viewModel.LowerBodyEndurancePoints = "default";
            viewModel.SpecialArtDownPoints = "default";
            viewModel.SPARecoveryPoints = "default";
            viewModel.UltraInstinct = "off";
            viewModel.WeaponGrip = "" + "";
        }

        private void SpaDownInfinite1_MouseEnter(object sender, MouseEventArgs e)
        {
            viewModel.StrikePoints = "";
            viewModel.GrapplePoints = "";
            viewModel.RegionalPoints = "";
            viewModel.SpecialPoints = "";
            viewModel.WeaponPoints = "";
            viewModel.ToughnessPoints = "";
            viewModel.HeadEndurancePoints = "";
            viewModel.UpperBodyEndurancePoints = "";
            viewModel.LowerBodyEndurancePoints = "";
            viewModel.SpecialArtDownPoints = "ARMOR";
            viewModel.SPARecoveryPoints = "";
            viewModel.UltraInstinct = "";
            viewModel.WeaponGrip = "" + "";
        }

        private void SpaDownInfinite2_MouseEnter(object sender, MouseEventArgs e)
        {
            viewModel.StrikePoints = "";
            viewModel.GrapplePoints = "";
            viewModel.RegionalPoints = "";
            viewModel.SpecialPoints = "";
            viewModel.WeaponPoints = "";
            viewModel.ToughnessPoints = "";
            viewModel.HeadEndurancePoints = "";
            viewModel.UpperBodyEndurancePoints = "";
            viewModel.LowerBodyEndurancePoints = "";
            viewModel.SpecialArtDownPoints = "POWER";
            viewModel.SPARecoveryPoints = "";
            viewModel.UltraInstinct = "";
            viewModel.WeaponGrip = "" + "";
        }

        private void SpaDownInfinite3_MouseEnter(object sender, MouseEventArgs e)
        {
            viewModel.StrikePoints = "";
            viewModel.GrapplePoints = "";
            viewModel.RegionalPoints = "";
            viewModel.SpecialPoints = "";
            viewModel.WeaponPoints = "";
            viewModel.ToughnessPoints = "";
            viewModel.HeadEndurancePoints = "";
            viewModel.UpperBodyEndurancePoints = "";
            viewModel.LowerBodyEndurancePoints = "";
            viewModel.SpecialArtDownPoints = "GUARD";
            viewModel.SPARecoveryPoints = "";
            viewModel.UltraInstinct = "";
            viewModel.WeaponGrip = "" + "";
        }

        private void SpaDownInfinite4_MouseEnter(object sender, MouseEventArgs e)
        {
            viewModel.StrikePoints = "";
            viewModel.GrapplePoints = "";
            viewModel.RegionalPoints = "";
            viewModel.SpecialPoints = "";
            viewModel.WeaponPoints = "";
            viewModel.ToughnessPoints = "";
            viewModel.HeadEndurancePoints = "";
            viewModel.UpperBodyEndurancePoints = "";
            viewModel.LowerBodyEndurancePoints = "";
            viewModel.SpecialArtDownPoints = "MOVES";
            viewModel.SPARecoveryPoints = "";
            viewModel.UltraInstinct = "";
            viewModel.WeaponGrip = "" + "";
        }

        private void SpaDownInfinite5_MouseEnter(object sender, MouseEventArgs e)
        {
            viewModel.StrikePoints = "";
            viewModel.GrapplePoints = "";
            viewModel.RegionalPoints = "";
            viewModel.SpecialPoints = "";
            viewModel.WeaponPoints = "";
            viewModel.ToughnessPoints = "";
            viewModel.HeadEndurancePoints = "";
            viewModel.UpperBodyEndurancePoints = "";
            viewModel.LowerBodyEndurancePoints = "";
            viewModel.SpecialArtDownPoints = "POW+ARMn";
            viewModel.SPARecoveryPoints = "";
            viewModel.UltraInstinct = "";
            viewModel.WeaponGrip = "" + "";
        }

        private void SpaDownInfinite6_MouseEnter(object sender, MouseEventArgs e)
        {
            viewModel.StrikePoints = "";
            viewModel.GrapplePoints = "";
            viewModel.RegionalPoints = "";
            viewModel.SpecialPoints = "";
            viewModel.WeaponPoints = "";
            viewModel.ToughnessPoints = "";
            viewModel.HeadEndurancePoints = "";
            viewModel.UpperBodyEndurancePoints = "";
            viewModel.LowerBodyEndurancePoints = "";
            viewModel.SpecialArtDownPoints = "POW+ARMg";
            viewModel.SPARecoveryPoints = "";
            viewModel.UltraInstinct = "";
            viewModel.WeaponGrip = "" + "";
        }

        private void SpaDownInfinite7_MouseEnter(object sender, MouseEventArgs e)
        {
            viewModel.StrikePoints = "";
            viewModel.GrapplePoints = "";
            viewModel.RegionalPoints = "";
            viewModel.SpecialPoints = "";
            viewModel.WeaponPoints = "";
            viewModel.ToughnessPoints = "";
            viewModel.HeadEndurancePoints = "";
            viewModel.UpperBodyEndurancePoints = "";
            viewModel.LowerBodyEndurancePoints = "";
            viewModel.SpecialArtDownPoints = "POW+GRD";
            viewModel.SPARecoveryPoints = "";
            viewModel.UltraInstinct = "";
            viewModel.WeaponGrip = "" + "";
        }

        private void SpaDownInfinite8_MouseEnter(object sender, MouseEventArgs e)
        {
            viewModel.StrikePoints = "";
            viewModel.GrapplePoints = "";
            viewModel.RegionalPoints = "";
            viewModel.SpecialPoints = "";
            viewModel.WeaponPoints = "";
            viewModel.ToughnessPoints = "";
            viewModel.HeadEndurancePoints = "";
            viewModel.UpperBodyEndurancePoints = "";
            viewModel.LowerBodyEndurancePoints = "";
            viewModel.SpecialArtDownPoints = "POW+MVS";
            viewModel.SPARecoveryPoints = "";
            viewModel.UltraInstinct = "";
            viewModel.WeaponGrip = "" + "";
        }


        private void StrifeSurge_MouseEnter(object sender, MouseEventArgs e)
        {
            viewModel.StrikePoints = "Go Up";
            viewModel.GrapplePoints = "Go Up";
            viewModel.RegionalPoints = "Go Up";
            viewModel.SpecialPoints = "Go Up";
            viewModel.WeaponPoints = "Go Up";
            viewModel.ToughnessPoints = "";
            viewModel.HeadEndurancePoints = "";
            viewModel.UpperBodyEndurancePoints = "";
            viewModel.LowerBodyEndurancePoints = "";
            viewModel.SpecialArtDownPoints = "";
            viewModel.SPARecoveryPoints = "";
            viewModel.UltraInstinct = "";
            viewModel.WeaponGrip = "" + "";
        }

        private void SpaDownInfiniteCustom1_MouseEnter(object sender, MouseEventArgs e)
        {
            viewModel.StrikePoints = "";
            viewModel.GrapplePoints = "";
            viewModel.RegionalPoints = "";
            viewModel.SpecialPoints = "";
            viewModel.WeaponPoints = "";
            viewModel.ToughnessPoints = "";
            viewModel.HeadEndurancePoints = "";
            viewModel.UpperBodyEndurancePoints = "";
            viewModel.LowerBodyEndurancePoints = "";
            viewModel.SpecialArtDownPoints = "Regeneration";
            viewModel.SPARecoveryPoints = "";
            viewModel.UltraInstinct = "";
            viewModel.WeaponGrip = "" + "";
        }

        private void SpaDownInfiniteCustom2_MouseEnter(object sender, MouseEventArgs e)
        {
            viewModel.StrikePoints = "";
            viewModel.GrapplePoints = "";
            viewModel.RegionalPoints = "";
            viewModel.SpecialPoints = "";
            viewModel.WeaponPoints = "";
            viewModel.ToughnessPoints = "";
            viewModel.HeadEndurancePoints = "";
            viewModel.UpperBodyEndurancePoints = "";
            viewModel.LowerBodyEndurancePoints = "";
            viewModel.SpecialArtDownPoints = "Redbull";
            viewModel.SPARecoveryPoints = "";
            viewModel.UltraInstinct = "";
            viewModel.WeaponGrip = "" + "";
        }


        private void FLY_MouseEnter(object sender, MouseEventArgs e)
        {
            viewModel.StrikePoints = "Nimbus";
            viewModel.GrapplePoints = "";
            viewModel.RegionalPoints = "";
            viewModel.SpecialPoints = "";
            viewModel.WeaponPoints = "";
            viewModel.ToughnessPoints = "";
            viewModel.HeadEndurancePoints = "";
            viewModel.UpperBodyEndurancePoints = "";
            viewModel.LowerBodyEndurancePoints = "";
            viewModel.SpecialArtDownPoints = "" + "";
            viewModel.SPARecoveryPoints = "" + "";
            viewModel.UltraInstinct = "" + "";
            viewModel.WeaponGrip = "" + "";
        }
        private void SupermanFlight_MouseEnter(object sender, MouseEventArgs e)
        {
            viewModel.StrikePoints = "Fly";
            viewModel.GrapplePoints = "";
            viewModel.RegionalPoints = "";
            viewModel.SpecialPoints = "";
            viewModel.WeaponPoints = "";
            viewModel.ToughnessPoints = "";
            viewModel.HeadEndurancePoints = "";
            viewModel.UpperBodyEndurancePoints = "";
            viewModel.LowerBodyEndurancePoints = "";
            viewModel.SpecialArtDownPoints = "" + "";
            viewModel.SPARecoveryPoints = "" + "";
            viewModel.UltraInstinct = "" + "";
            viewModel.WeaponGrip = "" + "";
        }

        private void DevilJinPower_MouseEnter(object sender, MouseEventArgs e)
        {
            viewModel.StrikePoints = "" + 1000;
            viewModel.GrapplePoints = "" + 1000;
            viewModel.RegionalPoints = "" + 1000;
            viewModel.SpecialPoints = "" + 1000;
            viewModel.WeaponPoints = "" + 1000;
            viewModel.ToughnessPoints = "" + 1000;
            viewModel.HeadEndurancePoints = "" + 1000;
            viewModel.UpperBodyEndurancePoints = "" + 1000;
            viewModel.LowerBodyEndurancePoints = "" + 1000;
            viewModel.SpecialArtDownPoints = "" + "TripleStats";
            viewModel.SPARecoveryPoints = "" + "32";
            viewModel.UltraInstinct = "" + "";
            viewModel.WeaponGrip = "" + "";
        }

        private void PoisonedChar_MouseEnter(object sender, MouseEventArgs e)
        {
            viewModel.StrikePoints = "";
            viewModel.GrapplePoints = "";
            viewModel.RegionalPoints = "";
            viewModel.SpecialPoints = "";
            viewModel.WeaponPoints = "";
            viewModel.ToughnessPoints = "lose hp";
            viewModel.HeadEndurancePoints = "";
            viewModel.UpperBodyEndurancePoints = "";
            viewModel.LowerBodyEndurancePoints = "";
            viewModel.SpecialArtDownPoints = "";
            viewModel.SPARecoveryPoints = "";
            viewModel.UltraInstinct = "";
            viewModel.WeaponGrip = "" + "";
        }

        private void PowerOverTimeChar_MouseEnter(object sender, MouseEventArgs e)
        {
            viewModel.StrikePoints = "raising";
            viewModel.GrapplePoints = "raising";
            viewModel.RegionalPoints = "raising";
            viewModel.SpecialPoints = "raising";
            viewModel.WeaponPoints = "raising";
            viewModel.ToughnessPoints = "raising";
            viewModel.HeadEndurancePoints = "";
            viewModel.UpperBodyEndurancePoints = "";
            viewModel.LowerBodyEndurancePoints = "";
            viewModel.SpecialArtDownPoints = "";
            viewModel.SPARecoveryPoints = "";
            viewModel.UltraInstinct = "";
            viewModel.WeaponGrip = "" + "";
        }

        #endregion

        private void P1DefaultStats_Click(object sender, MouseButtonEventArgs e)
        {
            P1Char.Content = null;
            player1Char = 0;
            P1Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/tile063.png", UriKind.Relative)) };
        }

        private void P2DefaultStats_Click(object sender, MouseButtonEventArgs e)
        {
            P2Char.Content = null;
            player2Char = 0;
            P2Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/tile063.png", UriKind.Relative)) };
        }

        private void P3DefaultStats_Click(object sender, MouseButtonEventArgs e)
        {
            P3Char.Content = null;
            player3Char = 0;
            P3Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/tile063.png", UriKind.Relative)) };
        }

        private void P4DefaultStats_Click(object sender, MouseButtonEventArgs e)
        {
            P4Char.Content = null;
            player4Char = 0;
            P4Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/tile063.png", UriKind.Relative)) };
        }

        private void P5DefaultStats_Click(object sender, MouseButtonEventArgs e)
        {
            P5Char.Content = null;
            player5Char = 0;
            P5Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/tile063.png", UriKind.Relative)) };
        }

        private void P6DefaultStats_Click(object sender, MouseButtonEventArgs e)
        {
            P6Char.Content = null;
            player6Char = 0;
            P6Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/tile063.png", UriKind.Relative)) };
        }

        private void P7DefaultStats_Click(object sender, MouseButtonEventArgs e)
        {
            P7Char.Content = null;
            player7Char = 0;
            P7Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/tile063.png", UriKind.Relative)) };
        }

        private void P8DefaultStats_Click(object sender, MouseButtonEventArgs e)
        {
            P8Char.Content = null;
            player8Char = 0;
            P8Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/tile063.png", UriKind.Relative)) };
        }

        private void ApplyChanges_Click(object sender, RoutedEventArgs e)
        {
            bool freeModeOn = false;
            if ( MissionBox.Visibility == Visibility.Visible)
            {
                freeModeOn = true;
            }
            charactersCode = viewModel.StatsChange(player1Char, player2Char, player3Char, player4Char, player5Char, player6Char, player7Char, player8Char, freeModeOn);
            if (!viewModel.SelectedMode)//Free Mode
            {
                if ((viewModel.MissionNumber >=0 && viewModel.MissionNumber <= 100) || (viewModel.MissionNumber == 101) || (viewModel.MissionNumber == 117) ||
                    (viewModel.MissionNumber == 178) || (viewModel.MissionNumber == 199) || (viewModel.MissionNumber == 200) ||
                    (viewModel.MissionNumber == 300) || (viewModel.MissionNumber == 400))
                {
                    int enemyAI = enemyAIbox.SelectedIndex;
                    missionCode = viewModel.GetMissionData(viewModel.MissionNumber, enemyAI);
                }
                else
                {
                    missionCode = "";
                    MessageBox.Show("Available Missions are 1-100 and 101,117,178,199,200,300,400!");
                }
            }
            else
            {
                missionCode = "";
            }

            string baseCode = charactersCode + missionCode;
            ExportPnach.ExportFile(baseCode);
            CodeText.Foreground = Brushes.Yellow;
            timer2.Start();

        }

        private void GoToTexturePage_Click(object sender, RoutedEventArgs e)
        {
            viewModel.DisplayTextureView();
        }

        private void SetMissionDataPath_Click(object sender, RoutedEventArgs e)
        {
            SettingsClass.missionFolderPath = viewModel.MissionFolderPath;
            SettingsClass.SaveData();
        }


        private void EveryoneDefaultStats_Click(object sender, MouseButtonEventArgs e)
        {
            if (!viewModel.SelectedMode)
            {
                P1Char.Content = null;
                player1Char = 0;
                P1Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/tile063.png", UriKind.Relative)) };
                P2Char.Content = null;
                player2Char = 0;
                P2Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/tile063.png", UriKind.Relative)) };
                P3Char.Content = null;
                player3Char = 0;
                P3Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/tile063.png", UriKind.Relative)) };
                P4Char.Content = null;
                player4Char = 0;
                P4Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/tile063.png", UriKind.Relative)) };
                P5Char.Content = null;
                player5Char = 0;
                P5Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/tile063.png", UriKind.Relative)) };
                P6Char.Content = null;
                player6Char = 0;
                P6Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/tile063.png", UriKind.Relative)) };
                P7Char.Content = null;
                player7Char = 0;
                P7Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/tile063.png", UriKind.Relative)) };
                P8Char.Content = null;
                player8Char = 0;
                P8Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/tile063.png", UriKind.Relative)) };
            }
            else
            {
                P1Char.Content = null;
                player1Char = 0;
                P1Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/tile063.png", UriKind.Relative)) };
                P2Char.Content = null;
                player2Char = 0;
                P2Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/tile063.png", UriKind.Relative)) };
                P3Char.Content = null;
                player3Char = 0;
                P3Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/tile063.png", UriKind.Relative)) };
                P4Char.Content = null;
                player4Char = 0;
                P4Char.Content = new Image() { Source = new BitmapImage(new Uri("/Resources/tile063.png", UriKind.Relative)) };
            }

        }


        private void SwitchMode_Click(object sender, RoutedEventArgs e)
        {
            if (viewModel.SelectedMode)
            {
                SwitchToFreeMode();
            }
            else
            {
                SwitchToMultiplayer();
            }
        }

        public void SwitchToFreeMode()
        {
            everyone.Visibility = Visibility.Collapsed;
            enemies.Visibility = Visibility.Visible;

            Player1.Visibility = Visibility.Visible;
            Player2.Visibility = Visibility.Visible;
            Enemy1.Visibility = Visibility.Visible;
            Enemy2.Visibility = Visibility.Visible;
            Enemy3.Visibility = Visibility.Visible;
            Enemy4.Visibility = Visibility.Visible;
            Enemy5.Visibility = Visibility.Visible;
            Enemy6.Visibility = Visibility.Visible;
            P1.Visibility = Visibility.Collapsed;
            P2.Visibility = Visibility.Collapsed;
            P3.Visibility = Visibility.Collapsed;
            P4.Visibility = Visibility.Collapsed;

            P5Char.Visibility = Visibility.Visible;
            P6Char.Visibility = Visibility.Visible;
            P7Char.Visibility = Visibility.Visible;
            P8Char.Visibility = Visibility.Visible;

            MissionBox.Visibility = Visibility.Visible;
            SetMissionData.Visibility = Visibility.Visible;
            MissionFolderPath.Visibility = Visibility.Visible;
            MissionTxt.Visibility = Visibility.Visible;
            MisTxt.Visibility = Visibility.Visible;
            MissionNumber.Visibility = Visibility.Visible;
            P2WPN.Visibility = Visibility.Visible;
            p2WTXT.Visibility = Visibility.Visible;
            ENE_WEAPON.Visibility = Visibility.Visible;
            eneTxtWe.Visibility = Visibility.Visible;
            EnemiesNumber.Visibility = Visibility.Visible;
            EneTextnr.Visibility = Visibility.Visible;
            MissionsInfo.Visibility = Visibility.Visible;
            enemyAIbox.Visibility = Visibility.Visible;
            eneAI.Visibility = Visibility.Visible;
            cameraTxt.Visibility = Visibility.Visible;
            multiCamera.Visibility = Visibility.Visible;

            //multiplayerAI.Visibility = Visibility.Collapsed;
            //multiplayerAITXT.Visibility = Visibility.Collapsed;

            ModeName.Text = "Free Mode";
            viewModel.SelectedMode = false;
        }

        public void SwitchToMultiplayer()
        {
            everyone.Visibility = Visibility.Visible;
            enemies.Visibility = Visibility.Collapsed;

            Player1.Visibility = Visibility.Collapsed;
            Player2.Visibility = Visibility.Collapsed;
            Enemy1.Visibility = Visibility.Collapsed;
            Enemy2.Visibility = Visibility.Collapsed;
            Enemy3.Visibility = Visibility.Collapsed;
            Enemy4.Visibility = Visibility.Collapsed;
            Enemy5.Visibility = Visibility.Collapsed;
            Enemy6.Visibility = Visibility.Collapsed;
            P1.Visibility = Visibility.Visible;
            P2.Visibility = Visibility.Visible;
            P3.Visibility = Visibility.Visible;
            P4.Visibility = Visibility.Visible;

            P5Char.Visibility = Visibility.Collapsed;
            P6Char.Visibility = Visibility.Collapsed;
            P7Char.Visibility = Visibility.Collapsed;
            P8Char.Visibility = Visibility.Collapsed;

            MissionBox.Visibility = Visibility.Collapsed;
            SetMissionData.Visibility = Visibility.Collapsed;
            MissionFolderPath.Visibility = Visibility.Collapsed;
            MissionTxt.Visibility = Visibility.Collapsed;
            MisTxt.Visibility = Visibility.Collapsed;
            MissionNumber.Visibility = Visibility.Collapsed;
            P2WPN.Visibility = Visibility.Collapsed;
            p2WTXT.Visibility = Visibility.Collapsed;
            ENE_WEAPON.Visibility = Visibility.Collapsed;
            eneTxtWe.Visibility = Visibility.Collapsed;
            EnemiesNumber.Visibility = Visibility.Collapsed;
            EneTextnr.Visibility = Visibility.Collapsed;
            MissionsInfo.Visibility = Visibility.Collapsed;
            enemyAIbox.Visibility = Visibility.Collapsed;
            eneAI.Visibility = Visibility.Collapsed;
            cameraTxt.Visibility = Visibility.Collapsed;
            multiCamera.Visibility = Visibility.Collapsed;

            //multiplayerAI.Visibility = Visibility.Visible;
            //multiplayerAITXT.Visibility = Visibility.Visible;

            ModeName.Text = "Multiplayer";
            viewModel.SelectedMode = true;
        }

        private void Characters_Info(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("First of all this page is set to Multiplayer in case you want to use Free Mode click on the switch mode button, " +
                "after that pick a player or enemy from the left side of the page and then go in the middle where " + 
                "the characters images are and hover your mouse over one, in the right side of the page you will see each of their values " +
                "chose any of them, keep in mind that these are only presets you will not play as the character in the image " +
                "finally click activate codes and enjoy." +
                "");
        }

        private void Missions_Info(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("First go to this tool folder and get the Missions_Data folder path and copy it in here " +
                "click Set Path, now pick which Mission you want to play and enter by example 100 in the mission text box " +
                "now if you want to have weapons for your partner check P2weapon box, if you want enemies to not have" + 
                "any weapon then uncheck EnemyWpn, and finally set the enemies number in the mission in Enemies box, " +
                "Now to pick the selected mission in your emulator, you will always have a partner and enemies will duplicate until they reach your set number. " +
                "there are also some extra mission coddes make sure you check them out." +
                "");
        }

        private void Teams_Info(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("C column stand for Control and T for Team. \n" +
                "For Control 0 means default (no change), 10 use to set control player, " +
                "use 1-6 to set control for cpu by level.\n" +
                "For Teams to work you have to respect some rules, first of all 0 means default." +
                "For Free For All you cannot chose more than 1 player per team or else the game won't end." +
                "For Team Battle select only team 1 or 2, any other number will be ignored by the game." +
                "");
        }

        private void Timer2_Tick(object sender, EventArgs e)
        {
            CodeText.Foreground = Brushes.White; // Reset the color to the original
            timer2.Stop();
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
