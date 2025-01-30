using UR_pnach_editor.ViewModels;
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
using UR_pnach_editor.Services;
using Microsoft.EntityFrameworkCore.Diagnostics;
using UR_pnach_editor.Codes;
using Microsoft.Extensions.FileSystemGlobbing;
using NAudio.Wave;
using System.Windows.Resources;
using System.IO;
using System.Timers;
using System.Diagnostics;
using System.Windows.Threading;
using WpfAnimatedGif;

namespace UR_pnach_editor.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainView : UserControl
    {
        MainViewModel viewModel;

        private DispatcherTimer timer; // Declare timer at the class level
        private bool firstTime = true;

        private DispatcherTimer timer2;

        public MainView()
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

            // Initialize the DispatcherTimer
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(20);
            timer.Tick += Timer_Tick;

            //was code activated?
            timer2 = new DispatcherTimer();
            timer2.Interval = TimeSpan.FromSeconds(2);
            timer2.Tick += Timer2_Tick;

            viewModel = new();
            this.DataContext = viewModel;


            viewModel.RandomizeSupremeStatus = "Randomize All Supreme : Off";

            CharaCombo1.ItemsSource = viewModel.Characters;
            CharaCombo1.SelectedIndex = 0;
            CharaCombo2.ItemsSource = viewModel.Characters;
            CharaCombo2.SelectedIndex = 0;
            SpaDown1.ItemsSource = viewModel.SpaList;
            SpaDown1.SelectedIndex = 0;
            SpaDown2.ItemsSource = viewModel.SpaList;
            SpaDown2.SelectedIndex = 0;
            SpaDown3.ItemsSource = viewModel.SpaList;
            SpaDown3.SelectedIndex = 0;
            SpaDown4.ItemsSource = viewModel.SpaList;
            SpaDown4.SelectedIndex = 0;
            CodeFileName.Text = viewModel.CRC_Name;




            if (SettingsClass.missionFolderPath != "" && File.Exists(SettingsClass.missionFolderPath + @"\M1.txt") && SettingsClass.PageEnterSFX)
            {
                string partialPath = SettingsClass.missionFolderPath.Substring(0, SettingsClass.missionFolderPath.Length - 14);
                string sfxPath = "";
                double volume = 0;

                int random = new Random().Next(1, 101);

                if (random < 71)
                {
                    sfxPath = partialPath + @"\sfx\Gate_Clossing.mp3";
                    volume = 1.0;
                }
                else if (random > 70 && random < 99)
                {
                    sfxPath = partialPath + @"\sfx\NobodyIsInnocent.mp3";
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



            //   C:\Users\sorin\Desktop\urban reign editor

            //   CreatePnach4.Test();

            //string inputFilePath = @"D:\Healing_SPA.pnach";
            //string outputFilePath = @"D:\Danger\Healing_SPA.pnach";

            //// Read all lines from the input file
            //string[] lines = File.ReadAllLines(inputFilePath);

            //// Modify each line by adding " at the beginning and + Environment.NewLine + at the end
            //for (int i = 0; i < lines.Length; i++)
            //{
            //    lines[i] = $"\"{lines[i]}\" + Environment.NewLine +";
            //}

            //// Write the modified lines to the output file
            //File.WriteAllLines(outputFilePath, lines);


            //// Specify the file name and desktop path
            //string fileName = "Doc.txt";
            //string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            //string inputFilePath = Path.Combine(desktopPath, fileName);
            //string outputFilePath = Path.Combine(desktopPath, "Output_" + fileName);

            //// Specify the hex value to add
            //string hexToAdd = "4B1EC800";

            //// Read each line from the input file, add hex value, and write to the output file
            //ProcessFile(inputFilePath, outputFilePath, hexToAdd);

            //Console.WriteLine("Hex addition complete. Check the output file on your desktop.");

            //CreatePnach7.MortalKombatStyle();
        }

        static void ProcessFile(string inputFilePath, string outputFilePath, string hexToAdd)
        {
            try
            {
                // Read all lines from the input file
                string[] lines = File.ReadAllLines(inputFilePath);

                // Process each line
                for (int i = 0; i < lines.Length; i++)
                {
                    // Parse the hex value from the line
                    if (TryParseHex(lines[i], out long hexValue))
                    {
                        // Add the specified hex value
                        hexValue += Convert.ToInt64(hexToAdd, 16);

                        // Check if the value is above or equal to 60000000 before updating the line
                        if (hexValue >= 60000000)
                        {
                            // Convert back to hex and update the line
                            lines[i] = hexValue.ToString("X");
                        }
                        else
                        {
                            // If the value is below 60000000, remove the line
                            lines[i] = null;
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Error parsing hex value on line {i + 1}: {lines[i]}");
                        // If there's an error parsing, remove the line
                        lines[i] = null;
                    }
                }

                // Filter out null values (lines below 60000000) and write the modified content to the output file
                File.WriteAllLines(outputFilePath, lines.Where(line => line != null));
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }

        static bool TryParseHex(string input, out long result)
        {
            return long.TryParse(input, System.Globalization.NumberStyles.HexNumber, null, out result);
        }




        private void Timer_Tick(object sender, EventArgs e)
        {
            if (viewModel.RandomizeSupremeStatus == "Randomize All Supreme : On")
            {
                //MessageBox.Show("Change Stats");
                CreatePnach3.RandomizeAllUpgraded();
                viewModel.CodeString = "Randomize All Supreme";
                firstTime = false;
            }
        }

        private void StartTimer_Click(object sender, RoutedEventArgs e)
        {
            if (firstTime)
            {
                //MessageBox.Show("Change Stats");
                CreatePnach3.RandomizeAllUpgraded();
                viewModel.CodeString = "Randomize All Supreme";
                firstTime = false;
            }

            if (viewModel.RandomizeSupremeStatus == "Randomize All Supreme : Off")
            {
                viewModel.RandomizeSupremeStatus = "Randomize All Supreme : On";
            }
            else
            {
                viewModel.RandomizeSupremeStatus = "Randomize All Supreme : Off";
            }

            // Start the timer when the "Start Timer" button is clicked
            timer.Start();
        }

        private void StopTimer_Click(object sender, RoutedEventArgs e)
        {
            // Stop the timer when the "Stop Timer" button is clicked
            timer.Stop();
        }



        private void RandomAll_Click(object sender, RoutedEventArgs e)
        {
            viewModel.RandomizeSupremeStatus = "Randomize All Supreme : Off";
            CreatePnach.RandomizeAll();
            viewModel.CodeString = "Randomize All";
            CodeText.Foreground = Brushes.Yellow;
            timer2.Start();
        }

        private void MaxWeaponsDmg_Click(object sender, RoutedEventArgs e)
        {
            viewModel.RandomizeSupremeStatus = "Randomize All Supreme : Off";
            CreatePnach.MaxWeaponsDmg();
            viewModel.CodeString = "Maximum Weapons Damage";
            CodeText.Foreground = Brushes.Yellow;
            timer2.Start();
        }


        private void P1God_Click(object sender, RoutedEventArgs e)
        {
            viewModel.RandomizeSupremeStatus = "Randomize All Supreme : Off";
            CreatePnach.P1God();
            viewModel.CodeString = "Player 1 God";
            CodeText.Foreground = Brushes.Yellow;
            timer2.Start();
        }

        private void AutoGuardAll_Click(object sender, RoutedEventArgs e)
        {
            viewModel.RandomizeSupremeStatus = "Randomize All Supreme : Off";
            CreatePnach.AutoGuardAll();
            viewModel.CodeString = "Auto Guard All";
            CodeText.Foreground = Brushes.Yellow;
            timer2.Start();
        }

        private void PersonalizedAll_Click(object sender, RoutedEventArgs e)
        {
            viewModel.RandomizeSupremeStatus = "Randomize All Supreme : Off";
            CreatePnach.PersonalizedAll();
            viewModel.CodeString = "Personalized All";
            CodeText.Foreground = Brushes.Yellow;
            timer2.Start();
        }

        private void SpikedWall_Click(object sender, RoutedEventArgs e)
        {
            viewModel.RandomizeSupremeStatus = "Randomize All Supreme : Off";
            CreatePnach.SpikedWall();
            viewModel.CodeString = "Spiked Wall";
            CodeText.Foreground = Brushes.Yellow;
            timer2.Start();
        }

        private void WeakStoryOpponents_Click(object sender, RoutedEventArgs e)
        {
            viewModel.RandomizeSupremeStatus = "Randomize All Supreme : Off";
            CreatePnach.WeakStoryOpponents();
            viewModel.CodeString = "Weak Story Opponents";
            CodeText.Foreground = Brushes.Yellow;
            timer2.Start();
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            viewModel.RandomizeSupremeStatus = "Randomize All Supreme : Off";
            CreatePnach.ClearCodes();
            viewModel.CodeString = "None";
            CodeText.Foreground = Brushes.Yellow;
            timer2.Start();
        }




        private void OneStarOnly_Click(object sender, RoutedEventArgs e)
        {
            viewModel.RandomizeSupremeStatus = "Randomize All Supreme : Off";
            CreatePnach2.OneStarOnly();
            viewModel.CodeString = "One Star Only";
            CodeText.Foreground = Brushes.Yellow;
            timer2.Start();
        }

        private void TwoStarsOnly_Click(object sender, RoutedEventArgs e)
        {
            viewModel.RandomizeSupremeStatus = "Randomize All Supreme : Off";
            CreatePnach2.TwoStarsOnly();
            viewModel.CodeString = "Two Stars Only";
            CodeText.Foreground = Brushes.Yellow;
            timer2.Start();
        }

        private void ThreeStarsOnly_Click(object sender, RoutedEventArgs e)
        {
            viewModel.RandomizeSupremeStatus = "Randomize All Supreme : Off";
            CreatePnach2.ThreeStarsOnly();
            viewModel.CodeString = "Three Stars Only";
            CodeText.Foreground = Brushes.Yellow;
            timer2.Start();
        }

        private void FourStarsOnly_Click(object sender, RoutedEventArgs e)
        {
            viewModel.RandomizeSupremeStatus = "Randomize All Supreme : Off";
            CreatePnach2.FourStarsOnly();
            viewModel.CodeString = "Four Stars Only";
            CodeText.Foreground = Brushes.Yellow;
            timer2.Start();
        }

        private void FiveStarsOnly_Click(object sender, RoutedEventArgs e)
        {
            viewModel.RandomizeSupremeStatus = "Randomize All Supreme : Off";
            CreatePnach2.FiveStarsOnly();
            viewModel.CodeString = "Five Stars Only";
            CodeText.Foreground = Brushes.Yellow;
            timer2.Start();
        }


        private void MovesStatsModifier_Click(object sender, RoutedEventArgs e)
        {
            viewModel.RandomizeSupremeStatus = "Randomize All Supreme : Off";
            int selectedIndex1 = CharaCombo1.SelectedIndex;
            if (selectedIndex1 == -1)
            {
                return;
            }
            string selectedValue1 = viewModel.Characters[selectedIndex1];
            int selectedIndex2 = CharaCombo2.SelectedIndex;
            if (selectedIndex2 == -1)
            {
                return;
            }
            string selectedValue2 = viewModel.Characters[selectedIndex2];

            CreatePnach2.MovesAndStatsModifier(selectedValue1, selectedValue2);
            viewModel.CodeString = "Moves And Stats Modifier";
            CodeText.Foreground = Brushes.Yellow;
            timer2.Start();
        }


        private void SavePath_Click(object sender, RoutedEventArgs e)
        {
            viewModel.RandomizeSupremeStatus = "Randomize All Supreme : Off";
            SettingsClass.codeFolderPath = viewModel.FolderPath;
            SettingsClass.codeFilePath = viewModel.FolderPath + SettingsClass.PnachName;
            SettingsClass.SaveData();
        }
        private void WeaponsOnlyCodes_Click(object sender, RoutedEventArgs e)
        {
            viewModel.RandomizeSupremeStatus = "Randomize All Supreme : Off";
            CreatePnach3.WeaponsOnly();
            viewModel.CodeString = "Weapons Only";
            CodeText.Foreground = Brushes.Yellow;
            timer2.Start();
        }

        private void WeakBullets_Click(object sender, RoutedEventArgs e)
        {
            viewModel.RandomizeSupremeStatus = "Randomize All Supreme : Off";
            CreatePnach3.WeakBullets();
            viewModel.CodeString = "Fake Bullets";
            CodeText.Foreground = Brushes.Yellow;
            timer2.Start();
        }

        //private void RandomizeAllUpgraded_Click(object sender, RoutedEventArgs e)
        //{
        //    CreatePnach3.RandomizeAllUpgraded();
        //    viewModel.CodeString = "Randomize All Supreme";
        //}
        private void RegionalShowdown_Click(object sender, RoutedEventArgs e)
        {
            viewModel.RandomizeSupremeStatus = "Randomize All Supreme : Off";
            CreatePnach5.RegionalShowdown();
            viewModel.CodeString = "Regional Showdown";
            CodeText.Foreground = Brushes.Yellow;
            timer2.Start();
        }



        private void SpaDownModifier_Click(object sender, RoutedEventArgs e)
        {
            viewModel.RandomizeSupremeStatus = "Randomize All Supreme : Off";
            int selectedIndex1Spa = SpaDown1.SelectedIndex;
            if (selectedIndex1Spa == -1)
            {
                return;
            }
            string selectedValue1Spa = viewModel.SpaList[selectedIndex1Spa];
            int selectedIndex2Spa = SpaDown2.SelectedIndex;
            if (selectedIndex2Spa == -1)
            {
                return;
            }
            string selectedValue2Spa = viewModel.SpaList[selectedIndex2Spa];
            int selectedIndex3Spa = SpaDown3.SelectedIndex;
            if (selectedIndex3Spa == -1)
            {
                return;
            }
            string selectedValue3Spa = viewModel.SpaList[selectedIndex3Spa];
            int selectedIndex4Spa = SpaDown4.SelectedIndex;
            if (selectedIndex4Spa == -1)
            {
                return;
            }
            string selectedValue4Spa = viewModel.SpaList[selectedIndex4Spa];

            CreatePnach2.SpaDownModifier(selectedValue1Spa, selectedValue2Spa, selectedValue3Spa, selectedValue4Spa);
            viewModel.CodeString = "Spa Down Modifier";
            CodeText.Foreground = Brushes.Yellow;
            timer2.Start();
        }

        private void ChangeCodeFileName_Click(object sender, RoutedEventArgs e)
        {
            viewModel.RandomizeSupremeStatus = "Randomize All Supreme : Off";
            string currentFilePath = SettingsClass.codeFilePath;

            SettingsClass.PnachName = viewModel.CRC_Name;
            SettingsClass.codeFilePath = SettingsClass.codeFolderPath + @"\" + SettingsClass.PnachName + ".pnach";

            string newFilePath = SettingsClass.codeFilePath;

            if (File.Exists(currentFilePath))
            {
                // Rename the file
                File.Move(currentFilePath, newFilePath);
            }

            SettingsClass.SaveData();
        }

        private void GoToStatsPage_Click(object sender, RoutedEventArgs e)
        {
            viewModel.RandomizeSupremeStatus = "Randomize All Supreme : Off";
            viewModel.DisplayStatsView();
        }
        private void GoToTextureChanger_Click(object sender, RoutedEventArgs e)
        {
            viewModel.RandomizeSupremeStatus = "Randomize All Supreme : Off";
            viewModel.DisplayTextureView();
        }

        private void GoToChallengePage_Click(object sender, RoutedEventArgs e)
        {
            viewModel.RandomizeSupremeStatus = "Randomize All Supreme : Off";
            viewModel.DisplayChallengeView();
        }

        private void GoToCharacterPage_Click(object sender, RoutedEventArgs e)
        {
            viewModel.RandomizeSupremeStatus = "Randomize All Supreme : Off";
            viewModel.DisplayCharacterView();
        }

        private void OneVersusThree_Click(object sender, RoutedEventArgs e)
        {
            CreatePnach6.OneVersusThree();
            viewModel.CodeString = "1 Versus 3";
            CodeText.Foreground = Brushes.Yellow;
            timer2.Start();
        }
        private void FourVsFour_Click(object sender, RoutedEventArgs e)
        {
            CreatePnach6.FourVsFour();
            viewModel.CodeString = "4 Versus 4";
            CodeText.Foreground = Brushes.Yellow;
            timer2.Start();
        }

        private void GoToDeveloperPage_Click(object sender, RoutedEventArgs e)
        {
            //if (!SettingsClass.missile)
            //{
            //    string password = Microsoft.VisualBasic.Interaction.InputBox("Please enter developer password:", "Password");

            //    if (password == "pnach")
            //    {
            //        SettingsClass.missile = true;
            //    }
            //    else
            //    {
            //        MessageBox.Show("Password is not correct.");
            //        return;
            //    }
            //}
            viewModel.RandomizeSupremeStatus = "Randomize All Supreme : Off";
            SettingsClass.SaveData();
            viewModel.DisplayDeveloperView();
        }

        private void GoToChallengeModePage_Click(object sender, RoutedEventArgs e)
        {
            viewModel.RandomizeSupremeStatus = "Randomize All Supreme : Off";
            viewModel.DisplayChallengeModeView();
        }

        private void GoToMovesetEditorPage_Click(object sender, RoutedEventArgs e)
        {
            viewModel.RandomizeSupremeStatus = "Randomize All Supreme : Off";
            viewModel.DisplayMovesetView();
        }
        private void MusicAndModelsPage_Click(object sender, RoutedEventArgs e)
        {
            viewModel.RandomizeSupremeStatus = "Randomize All Supreme : Off";
            viewModel.DisplayModelsAndMusicView();
        }




        private void CopyDiscordLink_Click(object sender, RoutedEventArgs e)
        {
            Clipboard.SetText("discord.gg/cwwJnteZEg");
        }

        private void Hyperlink_RequestNavigate(object sender, System.Windows.Navigation.RequestNavigateEventArgs e)
        {
            // Open the default web browser and navigate to the specified URI
            Process.Start(new ProcessStartInfo
            {
                FileName = e.Uri.AbsoluteUri,
                UseShellExecute = true
            });

            // Mark the event as handled, so WPF doesn't try to navigate automatically
            e.Handled = true;
        }


        private void RandomAll_Info(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Supported Modes: Free Mode, Challenge Mode, Multiplayer. \n" +
                "\n" +
                "This buttons sets all players stats at random between 100(Minimum Power) and 1000(Max Power).\n" +
                "Stats are formed by: Strike, Grapple, Regional, Special, Weapon, Toughness," +
                "Head Endurance, Upper Body Endurance, Lower Body Endurance." +
                "");
        }

        private void SpikedWall_Info(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Supported Modes: Challenge Mode, Multiplayer \n" +
                "\n" +
                "Everyone have a large amount of health, smash them in the wall to deal extreme damage!" +
                "");
        }

        private void PersonalizedAll_Info(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Supported Modes: Challenge Mode, Multiplayer \n" +
                "\n" +
                "Special stats setting made for the developers, you can give it a try if you want." +
                "");
        }

        private void AutoGuardAll_Info(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Supported Modes: Challenge Mode, Multiplayer \n" +
                "\n" +
                "Everyone will have Ultra Instinct, that means they will automatically parry any strike and weapon attack anytime. " +
                "");
        }

        private void RandomizeAllUpgraded_Info(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Supported Modes: Challenge Mode, Multiplayer \n" +
                "\n" +
                "Everything is random in here Stats between 10 and 2000 points, Ultra Instinct, SPA Cooldown, Infinite SPA or no SPA at all), " +
                "Spa Down (sometimes infinite) and you can even fly." +
                "If you activate it, it will automatically rewrite your pnach file every 20 seconds with new codes." +
                "Now it even randomize AI and weapons.");
        }

        private void RegionalShowdown_Info(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Supported Modes: Challenge Mode, Multiplayer \n" +
                "\n" +
                "Everyone starts will a huge amount of health, and random presets for regional weaknesses.\n" +
                "You need to identify which part of the opponent body is weak and exploit it." +
                "");
        }

        private void WeaponsOnlyCodes_Info(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Supported Modes: Challenge Mode, Multiplayer \n" +
                "\n" +
                "Anyone deal very low damage and even SPA does not recover when you get hit, the best way to win is to use a weapon." +
                "");
        }

        private void MaxWeaponsDmg_Info(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Supported Modes: Challenge Mode, Multiplayer \n" +
                "\n" +
                "Weapons does max damage, you can even kill someone by just throwing your weapon at him (in most of the cases)." +
                "");
        }

        private void WeakStoryOpponents_Info(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Supported Modes: Free Mode, Challenge Mode, Multiplayer \n" +
                "\n" +
                "Just as you read, enemies in Story Mode/Free Mode will have low stats." +
                "");
        }

        private void P1God_Info(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Supported Modes: Free Mode, Challenge Mode, Multiplayer \n" +
                "\n" +
                "With this Player 1 with stats over Double Max Power, Infinite Spa " +
                "Ultra Instinct, infinite blue SPA will be the Ultimate Fighter" +
                "");
        }

        private void WeakBullets_Info(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Supported Modes: Challenge Mode, Multiplayer \n" +
                "\n" +
                "All Players will have Bordin's gun but it's nerfed :(" +
                "");
        }

        private void ChangeCodeFileName_Info(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("You need to do these setting before using any cheat from here.\n" +
                "First fill the box above where it says Codes Folder Path with the folder path where your codes are stored " +
                "to find it right click on PCSX2 shortcut and then Open File location then select cheats folder, copy paste it here then click Save path\n" +
                "The second text box is for the pnach file name, this one is set automatically to our Urban Reign Deluxe version " +
                "but if you want to change it to use on another different rom you will have to find the CRC by yourself.");
        }

        private void MovesStatsModifier_Info(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Supported Modes: Multiplayer \n" +
                "\n" +
                "Available for player 1 and player 2, you can switch moves and stats with any player you select, " +
                "by example if you chose Golem from this dropbown list and in the game you chose Bordin, you will see Bordin in the game " +
                "with Golem moves and stats. " +
                "");;
        }

        private void SpaDownModifier_Info(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Supported Modes: Challenge Mode, Multiplayer \n" +
                "\n" +
                "Here you can select which SPA down to have, by example if you chose Armor and in game you pick Brad " +
                "when activating SPA down he will have the armor (yellow) instead of his power aura (red)." +
                "");
        }

        private void Clear_Info(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("This will clean you cheat code pnach file disabling any cheat code.");
        }

        private void GoToStatsPage_Info(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Supported Modes: Challenge Mode, Multiplayer.\n" +
                "\n" +
                "Open a new page that lets you set the stats for each player (Player1 to Player 4) from 10 and 2000 (1000 is max power).\n" +
                "Stats are formed by: Strike, Grapple, Regional, Special, Weapon, Toughness, " +
                "Head Endurance, Upper Body Endurance, Lower Body Endurance.\n" +
                "You also have a load/save feature to store your custom stats for later use. " +
                "");
        }

        private void GoToCharacterPage_Info(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Supported Modes: Free Mode, Challenge Mode, Multiplayer \n" +
                "\n" +
                "Here you can select a character (stats preset) for each player from player 1 to player 4 " +
                "and even for for enemies from free mode, that means you can modify Strike, Grapple, Regional, " +
                "Special, Weapon, Toughness, Head Endurance, Upper Body Endurance, Lower Body Endurance, " +
                "Special art down (even make it infinite), Spa Recovery (how much SPA you regain when you get hit) " +
                "set ultra instinct (auto parry any strike attack or weapon) and even fly 😅\n" +
                "You can also edit free mode missions and add or reduce enemies, (max enemies number are 6), " +
                "remove their weapons, add weapon for your partner, and after you activate the code you will also have a partner for any mission." +
                "");
        }

        private void GoToChallengePage_Info(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Supported Modes: Multiplayer \n" +
                "\n" +
                "Here you will find team challenges (player 1 and 2 must be on the same team) for hardcore players\n" +
                "This includes changes in stats, spa down, characters, weapons etc.\n" +
                "Grab a friend and give it a go (you can use the AI as partner as well)\n" +
                "On the right side of the screen you will find the instruction of what was changes for every button, " +
                "watch out for high difficulty challenges too. " +
                "");
        }

        private void GoToChallengeModePage_Info(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Supported Modes: Challenge Mode, Multiplayer \n" +
                "\n" +
                "This mod was made specially for Challenge mode, here you will find different scenarios " +
                "to keep you entertained.\n" +
                "This mode can be played solo or in team of two.\n" +
                "On the right side of the screen you will find the instruction of what was changes for every button, " +
                "watch out for high difficulty challenges too. " +
                "");
        }

        private void GoToTextureChanger_Info(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Supported Modes: Free Mode, Challenge Mode, Multiplayer \n" +
                "\n" +
                "Here you can set custom textures for characters, weapons, stages and more.\n" +
                "You will need to use PCSX2 nightly and activate Texture replacements in order to make it work.\n" +
                "Don't forget to set the folders paths." +
                "");
        }

        private void GoToDeveloperPage_Info(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Supported Modes: Free Mode, Challenge Mode, Multiplayer \n" +
                "\n" +
                "Here you can access the bonus page, only those that contributed to this tool will have access to it\n" +
                "If you want to request access contact us on our discord server.\n" +
                "Here you can swap the models for some fighters making them taller or shorter, swaping the music " +
                "in the game (track from other games available), manual input a pnach code from one address to another " +
                "(good for searching new codes), activate european version cheats, check codes, folder and other status " +
                "(see which modes you activated and tool configuration), see developers names, original game codes, and some other info.");
        }

        private void GoToMovesetEditor_Info(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Supported Modes: Free Mode, Challenge Mode, Multiplayer \n" +
                "\n" + 
                "This allows you to assign new movesets per character. \n" +
                "Pick any of the movesets created by our developers and enjoy  \n" +
                "The changes are made in hex so they are permanent! \n" +
                "There are still some bugs left over here so we would appreciate your feedback!");
        }


        private void GoToModelsAndMusic_Info(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Supported Modes: Free Mode, Challenge Mode, Multiplayer \n" +
                "\n" +
                "Here you can access the bonus page, only those that contributed to this tool will have access to it\n" +
                "If you want to request access contact us on our discord server discord.gg/cwwJnteZEg\n" +
                "Here you can swap the models for some fighters making them taller or shorter, swaping the music " +
                "in the game (track from other games available), manual input a pnach code from one address to another " +
                "(good for searching new codes), activate european version cheats, check codes, folder and other status " +
                "(see which modes you activated and tool configuration), see developers names, original game codes, and some other info.");
        }


        private void P5Enemy_Click(object sender, RoutedEventArgs e)
        {
            CreatePnach5.P5Enemy();
            viewModel.CodeString = "P5 Enemy";
            CodeText.Foreground = Brushes.Yellow;
            timer2.Start();
        }

        private void P5Enemy_Info(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Supported Modes: Challenge Mode, Multiplayer \n" +
                "\n" +
                "Player 5 will be set to Brad max power.\n" +
                "He can't win and does't have any team, it's there just to make everyone life miserable.\n" +
                "Note : If no one picks Brad his moves will be incomplete." +
                "");
        }
        
        private void OneVersusThree_Info(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Supported Modes: Challenge Mode, Multiplayer \n" +
                "\n" +
                "Select Team Battle\n" +
                "Team Red: P1\n" +
                "Team Blue: P2,P3,P4\n" +
                "You can use players or computers");
        }

        private void FourVsFour_Info(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Supported Modes: Multiplayer \n" +
                "\n" +
                "Select Team Battle\n" +
                "Team Fight 4 vs 4\n" +
                "Players 5-8 are bots with Brad moveset and 500 points for all stats. \n" +
                "If PLayers 1-4 will die the game will end. \n" +
                "Remember to Chose Brad for any fighter or else the bots won't know how to perform 60% of their moves");
        }

        private void MiscellaneousCheatsPage_Click(object sender, RoutedEventArgs e)
        {
            viewModel.RandomizeSupremeStatus = "Randomize All Supreme : Off";
            viewModel.DisplayMiscellaneousCheatsView();
        }

        private void MysteriousPage_Click(object sender, RoutedEventArgs e)
        {
            viewModel.RandomizeSupremeStatus = "Randomize All Supreme : Off";
            viewModel.DisplayMysteriousView();

            ////PAGE NOT AVAILABLE FOR NOW
            //string password = Microsoft.VisualBasic.Interaction.InputBox("Please enter secret password:", "Password");

            //if (password == "pnach")
            //{
            //    MessageBox.Show("Nice Try!");
            //    return;
            //}
            //else if (password == "65629250")
            //{
            //    viewModel.RandomizeSupremeStatus = "Randomize All Supreme : Off";
            //    viewModel.DisplayMysteriousView();
            //}
            //else
            //{
            //    MessageBox.Show("Password is not correct.");
            //    return;
            //}
        }
        private void GoToMiscellaneousCheats_Info(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Supported Modes: Free Mode, Challenge Mode, Multiplayer \n" +
                "\n" +
                "Here you can find some codes made with the help of members in the discord server,\n" +
                "it can goes from simple thing like a SPA that recover your health by 100 to full coop in free mode.");
        }

        private void GoToMysterious_Info(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("?????");
        }



        private void Timer2_Tick(object sender, EventArgs e)
        {
            CodeText.Foreground = Brushes.White; // Reset the color to the original
            timer2.Stop();
        }


    }



}
