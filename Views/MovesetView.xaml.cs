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
using WpfAnimatedGif;

namespace UR_pnach_editor.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MovesetView : UserControl
    {
        MovesetViewModel viewModel;

        public MovesetView()
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
            else if (SettingsClass.EditorEffectsIndex == 5)
            {
                var imageUri = new Uri("pack://application:,,,/Resources/Fireworks.gif");
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
                    sfxPath = partialPath + @"\sfx\thisIsIt.mp3";
                    volume = 0.4;
                }
                else if (random > 70 && random < 99)
                {
                    sfxPath = partialPath + @"\sfx\noSweat.mp3";
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

        private void ActivateAll_Click(object sender, RoutedEventArgs e)
        {
            bool usingPnachOverHex = false;//can't do it with pnach because some moves doesn't work without hex

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

            viewModel.MasterBradMoves = true;
            viewModel.GolemBrokenShitMoves = true;
            viewModel.BordinAllAroundMoves = true;
            viewModel.PaulAshesMoves = true;
            viewModel.SakamotoRyomaMoves = true;
            viewModel.KOGMoves = true;
            viewModel.KingJakeMoves = true;
            viewModel.MMAGipsiesMoves = true;
            viewModel.RikiDensetsuMoves = true;
            viewModel.PhoenixStanceShunYingMoves = true;
            viewModel.MonsterVeraMoves = true;
            viewModel.ThugKellyMoves = true;
            viewModel.SwordmasterLinFongMoves = true;
            viewModel.SmartParkMoves = true;

            viewModel.BradAndOthersParry = false;
            viewModel.ShinBordinMoves = false;
            viewModel.BrokenDwayneMoves = false;
            viewModel.SwordmasterShunYingAndLilianMoves = false;
            viewModel.OriginalTaunts = false;

            SettingsClass.MasterBradMoves = true;
            SettingsClass.GolemBrokenShitMoves = true;
            SettingsClass.BordinAllAroundMoves = true;
            SettingsClass.PaulAshesMoves = true;
            SettingsClass.SakamotoRyomaMoves = true;
            SettingsClass.KOGMoves = true;
            SettingsClass.KingJakeMoves = true;
            SettingsClass.MMAGipsiesMoves = true;
            SettingsClass.RikiDensetsuMoves = true;
            SettingsClass.PhoenixStanceShunYingMoves = true;
            SettingsClass.MonsterVeraMoves = true;
            SettingsClass.ThugKellyMoves = true;
            SettingsClass.SwordmasterLinFongMoves = true;
            SettingsClass.SmartParkMoves = true;

            SettingsClass.BradAndOthersParry = false;
            SettingsClass.ShinBordinMoves = false;
            SettingsClass.BrokenDwayneMoves = false;
            SettingsClass.SwordmasterShunYingAndLilianMoves = false;
            SettingsClass.OriginalTaunts = false;

            if (!usingPnachOverHex)
            {
                if (SettingsClass.StatsChanged == true)
                {
                    string currentFilePath = SettingsClass.codeFolderPath + @"\" + SettingsClass.PnachName + ".pnach";
                    SettingsClass.PnachName = SettingsClass.MovesAndStatsPnach;
                    string newFilePath = SettingsClass.codeFolderPath + @"\" + SettingsClass.MovesAndStatsPnach + ".pnach";

                    if (File.Exists(currentFilePath))
                    {
                        if (File.Exists(newFilePath))
                        {
                            File.Delete(newFilePath);
                        }
                        // Rename the file
                        File.Move(currentFilePath, newFilePath);
                    }

                }
                else
                {
                    string currentFilePath = SettingsClass.codeFolderPath + @"\" + SettingsClass.PnachName + ".pnach";
                    SettingsClass.PnachName = SettingsClass.MovesPnach;
                    string newFilePath = SettingsClass.codeFolderPath + @"\" + SettingsClass.MovesPnach + ".pnach";

                    if (currentFilePath != newFilePath)// in case the name changes
                    {
                        if (File.Exists(currentFilePath))
                        {
                            if (File.Exists(newFilePath))
                            {
                                File.Delete(newFilePath);
                            }
                            // Rename the file
                            File.Move(currentFilePath, newFilePath);
                        }
                    }

                }
                HexClass.ChangeMoveset();
            }

            if (usingPnachOverHex)
            {
                ExportPnach.ExportFile("clean moves");
            }
            SettingsClass.SaveData();
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            bool usingPnachOverHex = false;//can't do it with pnach because some moves doesn't work without hex

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

            viewModel.MasterBradMoves = false;
            viewModel.GolemBrokenShitMoves = false;
            viewModel.BordinAllAroundMoves = false;
            viewModel.PaulAshesMoves = false;
            viewModel.BradAndOthersParry = false;
            viewModel.SakamotoRyomaMoves = false;
            viewModel.ShinBordinMoves = false;
            viewModel.KOGMoves = false;
            viewModel.KingJakeMoves = false;
            viewModel.MMAGipsiesMoves = false;
            viewModel.RikiDensetsuMoves = false;
            viewModel.PhoenixStanceShunYingMoves = false;
            viewModel.BrokenDwayneMoves = false;
            viewModel.MonsterVeraMoves = false;
            viewModel.ThugKellyMoves = false;
            viewModel.SwordmasterShunYingAndLilianMoves = false;
            viewModel.SwordmasterLinFongMoves = false;
            viewModel.SmartParkMoves = false;
            viewModel.OriginalTaunts = false;
            
            SettingsClass.MasterBradMoves = false;
            SettingsClass.BradAndOthersParry = false;
            SettingsClass.GolemBrokenShitMoves = false;
            SettingsClass.BordinAllAroundMoves = false;
            SettingsClass.PaulAshesMoves = false;
            SettingsClass.SakamotoRyomaMoves = false;
            SettingsClass.ShinBordinMoves = false;
            SettingsClass.KOGMoves = false;
            SettingsClass.KingJakeMoves = false;
            SettingsClass.MMAGipsiesMoves = false;
            SettingsClass.RikiDensetsuMoves = false;
            SettingsClass.PhoenixStanceShunYingMoves = false;
            SettingsClass.BrokenDwayneMoves = false;
            SettingsClass.MonsterVeraMoves = false;
            SettingsClass.ThugKellyMoves = false;
            SettingsClass.SwordmasterShunYingAndLilianMoves = false;
            SettingsClass.SwordmasterLinFongMoves = false;
            SettingsClass.SmartParkMoves = false;
            SettingsClass.OriginalTaunts = false;

            if (!usingPnachOverHex)
            {
                if (SettingsClass.StatsChanged == true)
                {
                    string currentFilePath = SettingsClass.codeFolderPath + @"\" + SettingsClass.PnachName + ".pnach";
                    SettingsClass.PnachName = SettingsClass.StatsPnach;
                    string newFilePath = SettingsClass.codeFolderPath + @"\" + SettingsClass.StatsPnach + ".pnach";

                    if (currentFilePath != newFilePath)// in case the name changes
                    {
                        if (File.Exists(currentFilePath))
                        {
                            if (File.Exists(newFilePath))
                            {
                                File.Delete(newFilePath);
                            }
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
                        if (File.Exists(newFilePath))
                        {
                            File.Delete(newFilePath);
                        }
                        // Rename the file
                        File.Move(currentFilePath, newFilePath);
                    }

                }
                HexClass.ChangeMoveset();
            }

            if (usingPnachOverHex)
            {
                ExportPnach.ExportFile("clean moves");
            }
            SettingsClass.SaveData();
        }

        private void MovesetsModify(object sender, RoutedEventArgs e)
        {
            bool usingPnachOverHex = false;//can't do it with pnach because some moves doesn't work without hex

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

                MessageBoxResult result = MessageBox.Show("If you proceed you will have to set the CRC manually.\nARE YOU SURE???", "Message", MessageBoxButton.YesNo, MessageBoxImage.Question);

                if (result == MessageBoxResult.Yes)
                {
                    HexClass.ChangeMoveset();
                }
            }
            else
            {
                ExportPnach.ExportFile("clean moves");
            }
            SettingsClass.SaveData();
        }

        private void MasterBrad_MouseEnter(object sender, MouseEventArgs e)
        {
            viewModel.ModeInformation = "This moveset replaces regular grapples and SPAs, extends Brad's combo strings, integrates Team Attacks into regular grapples. \n" +
                "Unique parries/deflects based on who is attacking, many which are non reversable. \n" +
                "Dodge roll is replaced with Step dodge.\n" +
                "Made by So007";
        }

        private void BradAndOthersParry_MouseEnter(object sender, MouseEventArgs e)
        {
            viewModel.ModeInformation = "This will replace most of Brad parries with the enemy character grapple. \n" +
                "Be carefull because it's sharred with the others this means it will replace theirs as well.\n" +
                "Made by So007";
        }

        private void GolemBrokenShit_MouseEnter(object sender, MouseEventArgs e)
        {
            viewModel.ModeInformation = "This moveset swaps golem regular attacks with spa attack, \n" +
                "that includes standing strikes and running strikes.\n" +
                "It also add regeneration to your O+△+↑ spa move and red+blue spa for O+△+↓. \n" +
                "Made by Danger";
        }

        private void BordinAllAround_MouseEnter(object sender, MouseEventArgs e)
        {
            viewModel.ModeInformation = "This moveset changes regular attacks, throws, spa attacks and some running strikes. \n" +
                "That's all for now.\n" +
                "Made by Danger";
        }

        private void PaulAshes_MouseEnter(object sender, MouseEventArgs e)
        {
            viewModel.ModeInformation = "Neutral strike is changed to a teleporting hold.\r\nDown Grapple, back side grapple are unreflectable. \n" +
                "Demoman is now available without spa. \n" +
                "Minor change to grounded grapple now converting into ultimate punishment. \n" +
                "Side strikes are a new string. \n" +
                "Made by Flowchart ken";
        }
        private void SakamotoRyoma_MouseEnter(object sender, MouseEventArgs e)
        {
            viewModel.ModeInformation = "Revamped Shinkai moveset that throws swordplay strikes into his unarmed master style,\n" +
                "and more combo rejuggles, unarmed master style will also have a more improved version of his spa.\n" +
                "word master style is given more combo opportunities and a different spa in sword master style\n" +
                "Made by Flowchart ken";
        }

        private void ApplyMovesets_Info(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Use this to manualy change the movesets, that means you chose which one is " +
                "enabled or dissabled. \n" +
                "Warning this means the CRC won't update automatically, you will have to find it with PCSX2 " +
                "and then change it in the main menu. (if CRC is incorrect pnach codes won't work)");
        }

        private void ActivateAll_Info(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Use this button to activate every custom moveset from the left part of the page. \n" +
                "This option will automatically change your CRC so don't worry about it.");
        }

        private void ResetAll_Info(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Use this button to reset every moveset to original. \n" +
                "This option will automatically change your CRC so don't worry about it.");
        }

        private void SavePath_Click(object sender, RoutedEventArgs e)
        {
            SettingsClass.gameFolderPath = viewModel.GameFolderPath;
            SettingsClass.SaveData();
        }

        private void ShinBordin_MouseEnter(object sender, MouseEventArgs e)
        {
            viewModel.ModeInformation = "Bordin takes his medication, replaced all of his str but mainly his shitty Str combo with a viable 4 hit combo. \n" +
                "Replaced his short d Spa with mckenzie’s more longer version of his spa. \n" +
                "Bordin is able to cancel his moves with an idle stance using spa.\n" +
                "Made by Flowchart ken";
        }

        private void KOG_MouseEnter(object sender, MouseEventArgs e)
        {
            viewModel.ModeInformation = "KG becomes just as strong as his old brother, maybe way little stronger this older brethren. Changed up most of his str moves. \n" +
                "He has Dwayne’s str for longer combos. His wr d str can do a wall jump for attacks or he can back off for neutral.\n" +
                "His most notable move is lay down stance. By pressing spa, he can immediately hit the ground and do follows ups using different roll inputs depending on the direction he’s facing.\n" +
                "Made by Flowchart ken";
        }

        private void KingJake_MouseEnter(object sender, MouseEventArgs e)
        {
            viewModel.ModeInformation = "This moveset incorporates approach into Jake’s play style alongside his heavy grapple style. \n" +
                "Jake has a run cancel from spa to go into running moves. He can also teleport grab from miles away. \n" +
                "Jake can also go into laydown stance from running strike, giving him access to more moves. \n" +
                "Made by Flowchart ken";
        }

        private void MMAGipsies_MouseEnter(object sender, MouseEventArgs e)
        {
            viewModel.ModeInformation = "The gypsies grew tired of being beaten by Brad a hundred times, so they started learning mixed martial arts. \n" +
                "Days of rigorous training in diverse disciplines transformed them into formidable opponents. \n" +
                "Each had different movesets to try out.\n" +
                "Made by Danger";
        }

        private void RikiDensetsu_MouseEnter(object sender, MouseEventArgs e)
        {
            viewModel.ModeInformation = "Riki harnesses the SPA power of all his Yakuza fellows.\n" +
                "His combos are extended, his grapples are stronger and his roll has been replaced with a quick slide.\n" +
                "The other Yakuzas share his Standing 3x O combo.\n" +
                "Made by So007";
        }

        private void PhoenixStanceShunYing_MouseEnter(object sender, MouseEventArgs e)
        {
            viewModel.ModeInformation = "Taunt is replaced with grounded, roll and spa is replaced with prone stance.\n" +
                "Really good ground grapple game.\n" +
                "Made by Flowchart Ken";
        }

        private void BrokenDwayne_MouseEnter(object sender, MouseEventArgs e)
        {
            viewModel.ModeInformation = "Dwayne has 2 different stances from roll and taunt, focuses more on Aerial combos and defensive play.\n" +
                "Also can zone with teleporting grabs.\n" +
                "Made by Flowchart Ken";
        }

        private void MonsterVera_MouseEnter(object sender, MouseEventArgs e)
        {
            viewModel.ModeInformation = "Changed pretty much every move to make them better, stronger and flashier.\n" +
                "Taunt button as dodge roll. SPA down: armor + regeneration.\n" +
                "Made by FallenR";
        }

        private void ThugKelly_MouseEnter(object sender, MouseEventArgs e)
        {
            viewModel.ModeInformation = "Grapples are cooler and safer (opponents' counter-grapples are light attacks, not grapples); better axe swing.\n" +
                "Taunt button as cartwheel dodge. SPA down: armor + regeneration.\n" +
                "Made by FallenR";
        }

        private void SwordmasterShunYingAndLilian_MouseEnter(object sender, MouseEventArgs e)
        {
            viewModel.ModeInformation = "S stands for Swordmaster. Grapples are cooler and safer (opponents' counter-grapples are light attacks, not grapples); better swordsmanship (chinese sword, sabers and katanas).\n" +
                "Taunt button as cartwheel dodge. SPA down: armor + regeneration.\n" +
                "Made by FallenR";
        }

        private void SwordmasterLinFong_MouseEnter(object sender, MouseEventArgs e)
        {
            viewModel.ModeInformation = "Grapples are cooler and safer (opponents' counter-grapples are light attacks, not grapples),\n" +
                "better swordsmanship (chinese sword, sabers and katanas). Taunt button as cartwheel dodge. SPA down: armor + regeneration.\n" +
                "Made by FallenR";
        }
        private void SmartParkMoves_MouseEnter(object sender, MouseEventArgs e)
        {
            viewModel.ModeInformation = "Changed side and neutral combos (facing and not facing the opponent).\n" +
                "Combo sample: ↑O (wait a bit), O, O, O (wait a bit), O, O, O, O, O.\n" +
                "Grapples are cooler and safer (opponents' counter-grapples are light attacks, not grapples).\n" +
                "Taunt button as cartwheel dodge.\n" +
                "SPA down: armor + regeneration.\n" +
                "Made by FallenR";
        }

        private void OriginalTaunts_MouseEnter(object sender, MouseEventArgs e)
        {
            viewModel.ModeInformation = "This restores every activated custom moveset taunt to original " +
                "(only for those that doesn't have a taunt).\n" +
                "Requested by Zenca";
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
