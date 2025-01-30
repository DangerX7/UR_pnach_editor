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
using OfficeOpenXml.FormulaParsing.LexicalAnalysis;

namespace UR_pnach_editor.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class ModelsAndMusicView : UserControl
    {
        ModelsAndMusicViewModel viewModel;


        public ModelsAndMusicView()
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
                    sfxPath = partialPath + @"\sfx\Ready.mp3";
                    volume = 0.4;
                }
                else if (random > 70 && random < 99)
                {
                    sfxPath = partialPath + @"\sfx\BringIt.mp3";
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

            if (SettingsClass.MusicStatus == "Original")
            {
                viewModel.PatchingStatus = "Select a pack!";
            }
            else
            {
                viewModel.PatchingStatus = "Revert to Original!";
            }    
            MusicPatch.ItemsSource = viewModel.BGM_List;
            MusicPatch.SelectedItem = SettingsClass.MusicStatus;

        }

        private void GoToMainPage_Click(object sender, RoutedEventArgs e)
        {
            viewModel.DisplayMainView();
        }

        private void SavePath_Click(object sender, RoutedEventArgs e)
        {
            SettingsClass.gameFolderPath = viewModel.GameFolderPath;
            SettingsClass.SaveData();
        }

        private void SwapModels_Click(object sender, RoutedEventArgs e)
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

            HexClass.ChangeModelsSize();
        }

        private void SwapMusic_Click(object sender, RoutedEventArgs e)
        {
            //Check
            //if (viewModel.ModelsStatus == "ON")
            //{
            //    MessageBox.Show("Because of a patching conflict you can't swap music after you swapped the models.\n" +
            //        "Get back to models uncheck them all, swap to original and try this again.\n" +
            //        "You can change the models after you changed the music.");
            //    return;
            //}


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

            if (Convert.ToString(MusicPatch.SelectedItem) == SettingsClass.MusicStatus)
            {
                MessageBox.Show("You didn't changed anything!");
                return;
            }

            if (Convert.ToString(MusicPatch.SelectedItem) != "Original" && SettingsClass.MusicStatus != "Original")
            {
                MessageBox.Show("Revert back to Original then you can pick another pack!");
                return;
            }

            //Check for Hex changes and revert back to normal
            bool KG_Tall_Model = false;
            if (SettingsClass.KG_Tall_Model)
            {
                KG_Tall_Model = true;
                SettingsClass.KG_Tall_Model = false;
            }
            bool Real_Dwarf_Model = false;
            if (SettingsClass.Real_Dwarf_Model)
            {
                Real_Dwarf_Model = true;
                SettingsClass.Real_Dwarf_Model = false;
            }
            bool Golem_Giant_Model = false;
            if (SettingsClass.Golem_Giant_Model)
            {
                Golem_Giant_Model = true;
                SettingsClass.Golem_Giant_Model = false;
            }
            bool Gnome_Napalm_Model = false;
            if (SettingsClass.Gnome_Napalm_Model)
            {
                Gnome_Napalm_Model = true;
                SettingsClass.Gnome_Napalm_Model = false;
            }
            bool Amazon_Shun_Ying = false;
            if (SettingsClass.Amazon_Shun_Ying)
            {
                Amazon_Shun_Ying = true;
                SettingsClass.Amazon_Shun_Ying = false;
            }
            bool MasterBradMoves = false;
            if (SettingsClass.MasterBradMoves)
            {
                MasterBradMoves = true;
                SettingsClass.MasterBradMoves = false;
            }
            bool GolemBrokenShitMoves = false;
            if (SettingsClass.GolemBrokenShitMoves)
            {
                GolemBrokenShitMoves = true;
                SettingsClass.GolemBrokenShitMoves = false;
            }
            bool BordinAllAroundMoves = false;
            if (SettingsClass.BordinAllAroundMoves)
            {
                BordinAllAroundMoves = true;
                SettingsClass.BordinAllAroundMoves = false;
            }
            bool PaulAshesMoves = false;
            if (SettingsClass.PaulAshesMoves)
            {
                PaulAshesMoves = true;
                SettingsClass.PaulAshesMoves = false;
            }
            bool BradAndOthersParry = false;
            if (SettingsClass.BradAndOthersParry)
            {
                BradAndOthersParry = true;
                SettingsClass.BradAndOthersParry = false;
            }
            bool StatsChanged = false;
            if (SettingsClass.StatsChanged)
            {
                StatsChanged = true;
                SettingsClass.StatsChanged = false;
            }
            HexClass.ChangeModelsSize();
            HexClass.ChangeMoveset();
            HexClass.ChangeStats();



            //Generate Instructions
            string partialPath = SettingsClass.missionFolderPath.Substring(0, SettingsClass.missionFolderPath.Length - 14);
            string instructionPath = partialPath + @"\Patches\Instructions.txt";
            if (File.Exists(instructionPath))
            {
                File.Delete(instructionPath);
            }
          
            string selectedBgm = "";
            switch (Convert.ToString(MusicPatch.SelectedItem))
            {
                case "Original":
                    switch (SettingsClass.MusicStatus)
                    {
                        case "Story pack 1":
                            selectedBgm = "bmg_story_pack_1rev";
                            break;
                        case "Story pack 2":
                            selectedBgm = "bmg_story_pack_2rev";
                            break;
                        case "Story pack 3":
                            selectedBgm = "bmg_story_pack_3rev";
                            break;
                        case "Tekken 5 pack":
                            selectedBgm = "bmg_tekken_5_packrev";
                            break;
                        case "Tekken 5: Dark Resurrection pack":
                            selectedBgm = "bmg_tekken_5DR_packrev";
                            break;
                        case "Dead or Alive 2 pack":
                            selectedBgm = "bmg_doa_2_packrev";
                            break;
                        case "WWE SmackDown vs. Raw 2011 pack":
                            selectedBgm = "bmg_sdvr_2011_packrev";
                            break;
                        case "Dragon Ball Z: Budokai Tenkaichi 2 pack":
                            selectedBgm = "bmg_dbz_bt2_packrev";
                            break;
                        case "Tekken 8":
                            selectedBgm = "bmg_tekken_8_packrev";
                            break; 
                    }
                    break;
                case "Story pack 1":
                    selectedBgm = "bmg_story_pack_1";
                    break;
                case "Story pack 2":
                    selectedBgm = "bmg_story_pack_2";
                    break;
                case "Story pack 3":
                    selectedBgm = "bmg_story_pack_3";
                    break;
                case "Tekken 5 pack":
                    selectedBgm = "bmg_tekken_5_pack";
                    break;
                case "Tekken 5: Dark Resurrection pack":
                    selectedBgm = "bmg_tekken_5DR_pack";
                    break;
                case "Dead or Alive 2 pack":
                    selectedBgm = "bmg_doa_2_pack";
                    break;
                case "WWE SmackDown vs. Raw 2011 pack":
                    selectedBgm = "bmg_sdvr_2011_pack";
                    break;
                case "Dragon Ball Z: Budokai Tenkaichi 2 pack":
                    selectedBgm = "bmg_dbz_bt2_pack";
                    break;
                case "Tekken 8":
                    selectedBgm = "bmg_tekken_8_pack";
                    break;
            }

            if (viewModel.PatchingStatus == "Select a pack!")
            {
                viewModel.PatchingStatus = "Revert to Original!";
            }
            else if (viewModel.PatchingStatus == "Revert to Original!")
            {
                viewModel.PatchingStatus = "Select a pack!";
            }
            SettingsClass.MusicStatus = Convert.ToString(MusicPatch.SelectedItem);
            SettingsClass.SaveData();

            string original = SettingsClass.gameFolderPath + @"\Urban Reign Deluxe.iso";
            string patch = partialPath + @"\Patches\" + selectedBgm + ".xdelta";

            string instructions = "Please copy the following text into Delta Patcher exe and click Apply patch" + Environment.NewLine +
                "" + Environment.NewLine +
                "Original File:\n" + original + Environment.NewLine +
                "XDelta patch:\n" + patch;

            File.WriteAllText(instructionPath, instructions, Encoding.UTF8);

            Process.Start("notepad.exe", instructionPath);


            //Open Exe
            string deltaPatcherPath = partialPath + @"\Patches\DeltaPatcher.exe";
            Process.Start(deltaPatcherPath);


            MessageBoxResult result = MessageBox.Show("Press OK when you are done.\nDO NOT CONTINUE BEFORE YOU APPLY THE PATCH IN DELTA PATCHER!!!", "Message", MessageBoxButton.OK, MessageBoxImage.Information);

            if (result == MessageBoxResult.OK)
            {
                //Check for Hex changes and revert back to normal
                SettingsClass.KG_Tall_Model = KG_Tall_Model;
                SettingsClass.Real_Dwarf_Model = Real_Dwarf_Model;
                SettingsClass.Golem_Giant_Model = Golem_Giant_Model;
                SettingsClass.Gnome_Napalm_Model = Gnome_Napalm_Model;
                SettingsClass.Amazon_Shun_Ying = Amazon_Shun_Ying;
                SettingsClass.MasterBradMoves = MasterBradMoves;
                SettingsClass.GolemBrokenShitMoves = GolemBrokenShitMoves;
                SettingsClass.BordinAllAroundMoves = BordinAllAroundMoves;
                SettingsClass.PaulAshesMoves = PaulAshesMoves;
                SettingsClass.BradAndOthersParry = BradAndOthersParry;
                SettingsClass.StatsChanged = StatsChanged;
                HexClass.ChangeModelsSize();
                HexClass.ChangeMoveset();
                HexClass.ChangeStats();
            }
        }


        private void SwapModels_Info(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Before you use this make sure to fill the search box with the rom path you are using\n" +
                "also make sure it's name is Urban Reign Deluxe.iso otherwise it will not work, now hit save path\n" +
                "Check or uncheck any model you want them click swap modes, make sure no program uses the rom " +
                "because we will make changes in hex which are permanent, also the modding tool keeps in mind your settings " +
                "for this room that you've made, in case you switch with another rom it will have the same setting " +
                "and could result in a real problem, best to deactivate everything and save before switching to a new rom.");
        }

        private void SwapMusic_Info(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("This function is semi-automatic so you need to be carefull in here " +
                "also make sure you configured the game folder path before continuing.\n" +
                "Choose any music pack you want from the dropdown menu, then click swap music, and text file " +
                "with instructions will open along with the delta patcher, follow the instructions and finalize the process " +
                "then close the text file and delta patcher\n" +
                "This is very important, as soon as you pressed the swap music button you have to follow the instructions " +
                "until the end and patch the rom, because the tool won't know if you didn't do it.\n" +
                "If you want to switch to other track after this you will have to switch to original track first, then " +
                "to another pack after that, this was made in order to avoid errors.");
        }

       
    }




}
