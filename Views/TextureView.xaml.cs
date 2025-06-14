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
    public partial class TextureView : UserControl
    {
        TextureViewModel viewModel;
        public TextureView()
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
            else if (SettingsClass.EditorEffectsIndex == 5)
            {
                var imageUri = new Uri("pack://application:,,,/Resources/Fireworks.gif");
                ImageBehavior.SetAnimatedSource(gifImage, new BitmapImage(imageUri));
            }

            viewModel = new();

            this.DataContext = viewModel;


            viewModel.PageNumber = 1;

            if (SettingsClass.missionFolderPath != "" && File.Exists(SettingsClass.missionFolderPath + @"\M1.txt") && SettingsClass.PageEnterSFX)
            {
                string partialPath = SettingsClass.missionFolderPath.Substring(0, SettingsClass.missionFolderPath.Length - 14);
                string sfxPath = "";
                double volume = 0;

                int random = new Random().Next(1, 101);

                if (random < 71)
                {
                    sfxPath = partialPath + @"\sfx\Ihm.mp3";
                    volume = 0.4;
                }
                else if (random > 70 && random < 99)
                {
                    sfxPath = partialPath + @"\sfx\OverHere.mp3";
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


            SwitchToFirstSet();
        }

        private void GoToMainPage_Click(object sender, RoutedEventArgs e)
        {
            viewModel.DisplayMainView();
        }

        private void Test_Click(object sender, RoutedEventArgs e)
        {
            CreatePnach4.Test();
        }

        private void SwapTextures_Click(object sender, RoutedEventArgs e)
        {
            viewModel.SwapTextures();
        }

        private void ActivateAllTextures_Click(object sender, RoutedEventArgs e)
        {
            viewModel.ActivateAll();//Primary Set Only
        }
        private void ActivateAllTextures2_Click(object sender, RoutedEventArgs e)
        {
            viewModel.ActivateAll2();//Secondary Set Only
        }
        private void RemoveAllTextures_Click(object sender, RoutedEventArgs e)
        {
            viewModel.RestoreOriginals();
        }

        private void BaseFolder_Click(object sender, RoutedEventArgs e)
        {
            //not load or save properly
            SettingsClass.textureBaseFolderPath = viewModel.BaseFolderPath;
            SettingsClass.SaveData();
        }

        private void DumpFolder_Click(object sender, RoutedEventArgs e)
        {
            SettingsClass.textureDumpFolderPath = viewModel.DumpFolderPath;
            SettingsClass.SaveData();
        }

        private void GoToCharacterPage_Click(object sender, RoutedEventArgs e)
        {
            viewModel.DisplayCharacterView();
        }

        private void SwitchTexturesPages_Click(object sender, RoutedEventArgs e)
        {
            if (viewModel.PageNumber == 3)
            {
                viewModel.PageNumber = 1;
            }
            else
            {
                viewModel.PageNumber++;
            }

            switch (viewModel.PageNumber)
            {
                case 1:
                    SwitchToFirstSet();
                    break;
                case 2:
                    SwitchToSecondSet();
                    break;
                case 3:
                    SwitchToExtraSet();
                    break;
            }


        }

        private void SwitchToFirstSet()
        {
            skin1.Visibility = Visibility.Visible;
            check1.Visibility = Visibility.Visible;
            skin2.Visibility = Visibility.Visible;
            check2.Visibility = Visibility.Visible;
            skin3.Visibility = Visibility.Visible;
            check3.Visibility = Visibility.Visible;
            skin4.Visibility = Visibility.Visible;
            check4.Visibility = Visibility.Visible;
            skin5.Visibility = Visibility.Visible;
            check5.Visibility = Visibility.Visible;
            skin6.Visibility = Visibility.Visible;
            check6.Visibility = Visibility.Visible;
            skin7.Visibility = Visibility.Visible;
            check7.Visibility = Visibility.Visible;
            skin8.Visibility = Visibility.Visible;
            check8.Visibility = Visibility.Visible;
            skin9.Visibility = Visibility.Visible;
            check9.Visibility = Visibility.Visible;
            skin10.Visibility = Visibility.Visible;
            check10.Visibility = Visibility.Visible;
            skin11.Visibility = Visibility.Visible;
            check11.Visibility = Visibility.Visible;
            skin12.Visibility = Visibility.Visible;
            check12.Visibility = Visibility.Visible;
            skin13.Visibility = Visibility.Visible;
            check13.Visibility = Visibility.Visible;
            skin14.Visibility = Visibility.Visible;
            check14.Visibility = Visibility.Visible;
            skin15.Visibility = Visibility.Visible;
            check15.Visibility = Visibility.Visible;
            skin16.Visibility = Visibility.Visible;
            check16.Visibility = Visibility.Visible;
            skin17.Visibility = Visibility.Visible;
            check17.Visibility = Visibility.Visible;
            skin18.Visibility = Visibility.Visible;
            check18.Visibility = Visibility.Visible;
            skin19.Visibility = Visibility.Visible;
            check19.Visibility = Visibility.Visible;
            skin20.Visibility = Visibility.Visible;
            check20.Visibility = Visibility.Visible;
            skin21.Visibility = Visibility.Visible;
            check21.Visibility = Visibility.Visible;
            skin22.Visibility = Visibility.Visible;
            check22.Visibility = Visibility.Visible;
            skin23.Visibility = Visibility.Visible;
            check23.Visibility = Visibility.Visible;
            skin24.Visibility = Visibility.Visible;
            check24.Visibility = Visibility.Visible;
            skin25.Visibility = Visibility.Visible;
            check25.Visibility = Visibility.Visible;
            skin26.Visibility = Visibility.Visible;
            check26.Visibility = Visibility.Visible;
            skin27.Visibility = Visibility.Visible;
            check27.Visibility = Visibility.Visible;
            skin28.Visibility = Visibility.Visible;
            check28.Visibility = Visibility.Visible;
            skin29.Visibility = Visibility.Visible;
            check29.Visibility = Visibility.Visible;
            skin30.Visibility = Visibility.Visible;
            check30.Visibility = Visibility.Visible;
            skin31.Visibility = Visibility.Visible;
            check31.Visibility = Visibility.Visible;
            skin32.Visibility = Visibility.Visible;
            check32.Visibility = Visibility.Visible;
            skin33.Visibility = Visibility.Visible;
            check33.Visibility = Visibility.Visible;
            skin34.Visibility = Visibility.Visible;
            check34.Visibility = Visibility.Visible;
            skin35.Visibility = Visibility.Visible;
            check35.Visibility = Visibility.Visible;
            skin36.Visibility = Visibility.Visible;
            check36.Visibility = Visibility.Visible;
            skin37.Visibility = Visibility.Visible;
            check37.Visibility = Visibility.Visible;
            skin38.Visibility = Visibility.Visible;
            check38.Visibility = Visibility.Visible;
            skin39.Visibility = Visibility.Visible;
            check39.Visibility = Visibility.Visible;
            skin40.Visibility = Visibility.Visible;
            check40.Visibility = Visibility.Visible;
            skin41.Visibility = Visibility.Visible;
            check41.Visibility = Visibility.Visible;
            skin42.Visibility = Visibility.Visible;
            check42.Visibility = Visibility.Visible;
            skin43.Visibility = Visibility.Visible;
            check43.Visibility = Visibility.Visible;
            skin44.Visibility = Visibility.Visible;
            check44.Visibility = Visibility.Visible;
            skin45.Visibility = Visibility.Visible;
            check45.Visibility = Visibility.Visible;
            skin46.Visibility = Visibility.Visible;
            check46.Visibility = Visibility.Visible;
            skin47.Visibility = Visibility.Visible;
            check47.Visibility = Visibility.Visible;
            skin48.Visibility = Visibility.Visible;
            check48.Visibility = Visibility.Visible;
            skin49.Visibility = Visibility.Visible;
            check49.Visibility = Visibility.Visible;
            skin50.Visibility = Visibility.Visible;
            check50.Visibility = Visibility.Visible;
            skin51.Visibility = Visibility.Visible;
            check51.Visibility = Visibility.Visible;
            skin52.Visibility = Visibility.Visible;
            check52.Visibility = Visibility.Visible;
            skin53.Visibility = Visibility.Visible;
            check53.Visibility = Visibility.Visible;
            skin54.Visibility = Visibility.Visible;
            check54.Visibility = Visibility.Visible;
            skin55.Visibility = Visibility.Visible;
            check55.Visibility = Visibility.Visible;
            skin56.Visibility = Visibility.Visible;
            check56.Visibility = Visibility.Visible;
            skin57.Visibility = Visibility.Visible;
            check57.Visibility = Visibility.Visible;
            skin58.Visibility = Visibility.Visible;
            check58.Visibility = Visibility.Visible;
            skin59.Visibility = Visibility.Visible;
            check59.Visibility = Visibility.Visible;

            skin101.Visibility = Visibility.Collapsed;
            check101.Visibility = Visibility.Collapsed;
            skin102.Visibility = Visibility.Collapsed;
            check102.Visibility = Visibility.Collapsed;
            skin103.Visibility = Visibility.Collapsed;
            skin103.Visibility = Visibility.Collapsed;
            check103.Visibility = Visibility.Collapsed;
            skin104.Visibility = Visibility.Collapsed;
            check104.Visibility = Visibility.Collapsed;
            skin105.Visibility = Visibility.Collapsed;
            check105.Visibility = Visibility.Collapsed;
            skin106.Visibility = Visibility.Collapsed;
            check106.Visibility = Visibility.Collapsed;
            skin107.Visibility = Visibility.Collapsed;
            check107.Visibility = Visibility.Collapsed;
            skin108.Visibility = Visibility.Collapsed;
            check108.Visibility = Visibility.Collapsed;
            skin109.Visibility = Visibility.Collapsed;
            check109.Visibility = Visibility.Collapsed;
            skin110.Visibility = Visibility.Collapsed;
            check110.Visibility = Visibility.Collapsed;
            skin111.Visibility = Visibility.Collapsed;
            check111.Visibility = Visibility.Collapsed;
            skin112.Visibility = Visibility.Collapsed;
            check112.Visibility = Visibility.Collapsed;
            skin113.Visibility = Visibility.Collapsed;
            check113.Visibility = Visibility.Collapsed;
            skin114.Visibility = Visibility.Collapsed;
            check114.Visibility = Visibility.Collapsed;
            skin115.Visibility = Visibility.Collapsed;
            check115.Visibility = Visibility.Collapsed;
            skin116.Visibility = Visibility.Collapsed;
            check116.Visibility = Visibility.Collapsed;
            skin117.Visibility = Visibility.Collapsed;
            check117.Visibility = Visibility.Collapsed;
            skin118.Visibility = Visibility.Collapsed;
            check118.Visibility = Visibility.Collapsed;
            skin119.Visibility = Visibility.Collapsed;
            check119.Visibility = Visibility.Collapsed;
            skin120.Visibility = Visibility.Collapsed;
            check120.Visibility = Visibility.Collapsed;
            skin121.Visibility = Visibility.Collapsed;
            check121.Visibility = Visibility.Collapsed;
            skin122.Visibility = Visibility.Collapsed;
            check122.Visibility = Visibility.Collapsed;
            skin123.Visibility = Visibility.Collapsed;
            check123.Visibility = Visibility.Collapsed;
            skin124.Visibility = Visibility.Collapsed;
            check124.Visibility = Visibility.Collapsed;
            skin125.Visibility = Visibility.Collapsed;
            check125.Visibility = Visibility.Collapsed;
            skin126.Visibility = Visibility.Collapsed;
            check126.Visibility = Visibility.Collapsed;
            skin127.Visibility = Visibility.Collapsed;
            check127.Visibility = Visibility.Collapsed;
            skin128.Visibility = Visibility.Collapsed;
            check128.Visibility = Visibility.Collapsed;
            skin129.Visibility = Visibility.Collapsed;
            check129.Visibility = Visibility.Collapsed;
            skin130.Visibility = Visibility.Collapsed;
            check130.Visibility = Visibility.Collapsed;
            skin131.Visibility = Visibility.Collapsed;
            check131.Visibility = Visibility.Collapsed;
            skin132.Visibility = Visibility.Collapsed;
            check132.Visibility = Visibility.Collapsed;
            skin133.Visibility = Visibility.Collapsed;
            check133.Visibility = Visibility.Collapsed;
            skin134.Visibility = Visibility.Collapsed;
            check134.Visibility = Visibility.Collapsed;
            skin135.Visibility = Visibility.Collapsed;
            check135.Visibility = Visibility.Collapsed;
            skin136.Visibility = Visibility.Collapsed;
            check136.Visibility = Visibility.Collapsed;
            skin137.Visibility = Visibility.Collapsed;
            check137.Visibility = Visibility.Collapsed;
            skin138.Visibility = Visibility.Collapsed;
            check138.Visibility = Visibility.Collapsed;
            skin139.Visibility = Visibility.Collapsed;
            check139.Visibility = Visibility.Collapsed;
            skin140.Visibility = Visibility.Collapsed;
            check140.Visibility = Visibility.Collapsed;
            skin141.Visibility = Visibility.Collapsed;
            check141.Visibility = Visibility.Collapsed;
            skin142.Visibility = Visibility.Collapsed;
            check142.Visibility = Visibility.Collapsed;
            skin143.Visibility = Visibility.Collapsed;
            check143.Visibility = Visibility.Collapsed;
            skin144.Visibility = Visibility.Collapsed;
            check144.Visibility = Visibility.Collapsed;
            skin145.Visibility = Visibility.Collapsed;
            check145.Visibility = Visibility.Collapsed;
            skin146.Visibility = Visibility.Collapsed;
            check146.Visibility = Visibility.Collapsed;
            skin147.Visibility = Visibility.Collapsed;
            check147.Visibility = Visibility.Collapsed;
            skin148.Visibility = Visibility.Collapsed;
            check148.Visibility = Visibility.Collapsed;
            skin149.Visibility = Visibility.Collapsed;
            check149.Visibility = Visibility.Collapsed;
            skin150.Visibility = Visibility.Collapsed;
            check150.Visibility = Visibility.Collapsed;
            skin151.Visibility = Visibility.Collapsed;
            check151.Visibility = Visibility.Collapsed;
            skin152.Visibility = Visibility.Collapsed;
            check152.Visibility = Visibility.Collapsed;
            skin153.Visibility = Visibility.Collapsed;
            check153.Visibility = Visibility.Collapsed;
            skin154.Visibility = Visibility.Collapsed;
            check154.Visibility = Visibility.Collapsed;
            skin155.Visibility = Visibility.Collapsed;
            check155.Visibility = Visibility.Collapsed;
            skin156.Visibility = Visibility.Collapsed;
            check156.Visibility = Visibility.Collapsed;
            skin157.Visibility = Visibility.Collapsed;
            check157.Visibility = Visibility.Collapsed;
            skin158.Visibility = Visibility.Collapsed;
            check158.Visibility = Visibility.Collapsed;
            skin159.Visibility = Visibility.Collapsed;
            check159.Visibility = Visibility.Collapsed;
            skin160.Visibility = Visibility.Collapsed;
            check160.Visibility = Visibility.Collapsed;
            skin161.Visibility = Visibility.Collapsed;
            check161.Visibility = Visibility.Collapsed;
            skin162.Visibility = Visibility.Collapsed;
            check162.Visibility = Visibility.Collapsed;
            skin163.Visibility = Visibility.Collapsed;
            check163.Visibility = Visibility.Collapsed;
            skin164.Visibility = Visibility.Collapsed;
            check164.Visibility = Visibility.Collapsed;
            skin165.Visibility = Visibility.Collapsed;
            check165.Visibility = Visibility.Collapsed;
            skin166.Visibility = Visibility.Collapsed;
            check166.Visibility = Visibility.Collapsed;
            skin167.Visibility = Visibility.Collapsed;
            check167.Visibility = Visibility.Collapsed;
            skin168.Visibility = Visibility.Collapsed;
            check168.Visibility = Visibility.Collapsed;
            skin169.Visibility = Visibility.Collapsed;
            check169.Visibility = Visibility.Collapsed;
            skin170.Visibility = Visibility.Collapsed;
            check170.Visibility = Visibility.Collapsed;
            skin171.Visibility = Visibility.Collapsed;
            check171.Visibility = Visibility.Collapsed;
            skin172.Visibility = Visibility.Collapsed;
            check172.Visibility = Visibility.Collapsed;
            skin173.Visibility = Visibility.Collapsed;
            check173.Visibility = Visibility.Collapsed;
            skin174.Visibility = Visibility.Collapsed;
            check174.Visibility = Visibility.Collapsed;
            skin175.Visibility = Visibility.Collapsed;
            check175.Visibility = Visibility.Collapsed;
            skin176.Visibility = Visibility.Collapsed;
            check176.Visibility = Visibility.Collapsed;
            skin177.Visibility = Visibility.Collapsed;
            check177.Visibility = Visibility.Collapsed;
            skin178.Visibility = Visibility.Collapsed;
            check178.Visibility = Visibility.Collapsed;
            skin179.Visibility = Visibility.Collapsed;
            check179.Visibility = Visibility.Collapsed;
            skin180.Visibility = Visibility.Collapsed;
            check180.Visibility = Visibility.Collapsed;
            skin181.Visibility = Visibility.Collapsed;
            check181.Visibility = Visibility.Collapsed;
            skin182.Visibility = Visibility.Collapsed;
            check182.Visibility = Visibility.Collapsed;
            skin183.Visibility = Visibility.Collapsed;
            check183.Visibility = Visibility.Collapsed;
            skin184.Visibility = Visibility.Collapsed;
            check184.Visibility = Visibility.Collapsed;
            skin185.Visibility = Visibility.Collapsed;
            check185.Visibility = Visibility.Collapsed;
            skin186.Visibility = Visibility.Collapsed;
            check186.Visibility = Visibility.Collapsed;
            skin187.Visibility = Visibility.Collapsed;
            check187.Visibility = Visibility.Collapsed;
            skin188.Visibility = Visibility.Collapsed;
            check188.Visibility = Visibility.Collapsed;
            skin189.Visibility = Visibility.Collapsed;
            check189.Visibility = Visibility.Collapsed;
            skin190.Visibility = Visibility.Collapsed;
            check190.Visibility = Visibility.Collapsed;
            skin191.Visibility = Visibility.Collapsed;
            check191.Visibility = Visibility.Collapsed;
            skin192.Visibility = Visibility.Collapsed;
            check192.Visibility = Visibility.Collapsed;
            skin193.Visibility = Visibility.Collapsed;
            check193.Visibility = Visibility.Collapsed;
            skin194.Visibility = Visibility.Collapsed;
            check194.Visibility = Visibility.Collapsed;
            skin195.Visibility = Visibility.Collapsed;
            check195.Visibility = Visibility.Collapsed;
            skin196.Visibility = Visibility.Collapsed;
            check196.Visibility = Visibility.Collapsed;
            skin197.Visibility = Visibility.Collapsed;
            check197.Visibility = Visibility.Collapsed;
            skin198.Visibility = Visibility.Collapsed;
            check198.Visibility = Visibility.Collapsed;
            skin199.Visibility = Visibility.Collapsed;
            check199.Visibility = Visibility.Collapsed;
            skin200.Visibility = Visibility.Collapsed;
            check200.Visibility = Visibility.Collapsed;
            skin201.Visibility = Visibility.Collapsed;
            check201.Visibility = Visibility.Collapsed;

            //checkTS.Visibility = Visibility.Visible;
            //Title_Screen.Visibility = Visibility.Visible;
            //stageWarehouse.Visibility = Visibility.Visible;
            //Warehouse_Level.Visibility = Visibility.Visible;
            //WeaponsTextures.Visibility = Visibility.Visible;
            //WeaponsTexturesBlock.Visibility = Visibility.Visible;
            //MultyplayerTextures.Visibility = Visibility.Visible;
            //MultyplayerTexturesBlock.Visibility = Visibility.Visible;
        }

        private void SwitchToSecondSet()
        {
            skin1.Visibility = Visibility.Collapsed;
            check1.Visibility = Visibility.Collapsed;
            skin2.Visibility = Visibility.Collapsed;
            check2.Visibility = Visibility.Collapsed;
            skin3.Visibility = Visibility.Collapsed;
            check3.Visibility = Visibility.Collapsed;
            skin4.Visibility = Visibility.Collapsed;
            check4.Visibility = Visibility.Collapsed;
            skin5.Visibility = Visibility.Collapsed;
            check5.Visibility = Visibility.Collapsed;
            skin6.Visibility = Visibility.Collapsed;
            check6.Visibility = Visibility.Collapsed;
            skin7.Visibility = Visibility.Collapsed;
            check7.Visibility = Visibility.Collapsed;
            skin8.Visibility = Visibility.Collapsed;
            check8.Visibility = Visibility.Collapsed;
            skin9.Visibility = Visibility.Collapsed;
            check9.Visibility = Visibility.Collapsed;
            skin10.Visibility = Visibility.Collapsed;
            check10.Visibility = Visibility.Collapsed;
            skin11.Visibility = Visibility.Collapsed;
            check11.Visibility = Visibility.Collapsed;
            skin12.Visibility = Visibility.Collapsed;
            check12.Visibility = Visibility.Collapsed;
            skin13.Visibility = Visibility.Collapsed;
            check13.Visibility = Visibility.Collapsed;
            skin14.Visibility = Visibility.Collapsed;
            check14.Visibility = Visibility.Collapsed;
            skin15.Visibility = Visibility.Collapsed;
            check15.Visibility = Visibility.Collapsed;
            skin16.Visibility = Visibility.Collapsed;
            check16.Visibility = Visibility.Collapsed;
            skin17.Visibility = Visibility.Collapsed;
            check17.Visibility = Visibility.Collapsed;
            skin18.Visibility = Visibility.Collapsed;
            check18.Visibility = Visibility.Collapsed;
            skin19.Visibility = Visibility.Collapsed;
            check19.Visibility = Visibility.Collapsed;
            skin20.Visibility = Visibility.Collapsed;
            check20.Visibility = Visibility.Collapsed;
            skin21.Visibility = Visibility.Collapsed;
            check21.Visibility = Visibility.Collapsed;
            skin22.Visibility = Visibility.Collapsed;
            check22.Visibility = Visibility.Collapsed;
            skin23.Visibility = Visibility.Collapsed;
            check23.Visibility = Visibility.Collapsed;
            skin24.Visibility = Visibility.Collapsed;
            check24.Visibility = Visibility.Collapsed;
            skin25.Visibility = Visibility.Collapsed;
            check25.Visibility = Visibility.Collapsed;
            skin26.Visibility = Visibility.Collapsed;
            check26.Visibility = Visibility.Collapsed;
            skin27.Visibility = Visibility.Collapsed;
            check27.Visibility = Visibility.Collapsed;
            skin28.Visibility = Visibility.Collapsed;
            check28.Visibility = Visibility.Collapsed;
            skin29.Visibility = Visibility.Collapsed;
            check29.Visibility = Visibility.Collapsed;
            skin30.Visibility = Visibility.Collapsed;
            check30.Visibility = Visibility.Collapsed;
            skin31.Visibility = Visibility.Collapsed;
            check31.Visibility = Visibility.Collapsed;
            skin32.Visibility = Visibility.Collapsed;
            check32.Visibility = Visibility.Collapsed;
            skin33.Visibility = Visibility.Collapsed;
            check33.Visibility = Visibility.Collapsed;
            skin34.Visibility = Visibility.Collapsed;
            check34.Visibility = Visibility.Collapsed;
            skin35.Visibility = Visibility.Collapsed;
            check35.Visibility = Visibility.Collapsed;
            skin36.Visibility = Visibility.Collapsed;
            check36.Visibility = Visibility.Collapsed;
            skin37.Visibility = Visibility.Collapsed;
            check37.Visibility = Visibility.Collapsed;
            skin38.Visibility = Visibility.Collapsed;
            check38.Visibility = Visibility.Collapsed;
            skin39.Visibility = Visibility.Collapsed;
            check39.Visibility = Visibility.Collapsed;
            skin40.Visibility = Visibility.Collapsed;
            check40.Visibility = Visibility.Collapsed;
            skin41.Visibility = Visibility.Collapsed;
            check41.Visibility = Visibility.Collapsed;
            skin42.Visibility = Visibility.Collapsed;
            check42.Visibility = Visibility.Collapsed;
            skin43.Visibility = Visibility.Collapsed;
            check43.Visibility = Visibility.Collapsed;
            skin44.Visibility = Visibility.Collapsed;
            check44.Visibility = Visibility.Collapsed;
            skin45.Visibility = Visibility.Collapsed;
            check45.Visibility = Visibility.Collapsed;
            skin46.Visibility = Visibility.Collapsed;
            check46.Visibility = Visibility.Collapsed;
            skin47.Visibility = Visibility.Collapsed;
            check47.Visibility = Visibility.Collapsed;
            skin48.Visibility = Visibility.Collapsed;
            check48.Visibility = Visibility.Collapsed;
            skin49.Visibility = Visibility.Collapsed;
            check49.Visibility = Visibility.Collapsed;
            skin50.Visibility = Visibility.Collapsed;
            check50.Visibility = Visibility.Collapsed;
            skin51.Visibility = Visibility.Collapsed;
            check51.Visibility = Visibility.Collapsed;
            skin52.Visibility = Visibility.Collapsed;
            check52.Visibility = Visibility.Collapsed;
            skin53.Visibility = Visibility.Collapsed;
            check53.Visibility = Visibility.Collapsed;
            skin54.Visibility = Visibility.Collapsed;
            check54.Visibility = Visibility.Collapsed;
            skin55.Visibility = Visibility.Collapsed;
            check55.Visibility = Visibility.Collapsed;
            skin56.Visibility = Visibility.Collapsed;
            check56.Visibility = Visibility.Collapsed;
            skin57.Visibility = Visibility.Collapsed;
            check57.Visibility = Visibility.Collapsed;
            skin58.Visibility = Visibility.Collapsed;
            check58.Visibility = Visibility.Collapsed;
            skin59.Visibility = Visibility.Collapsed;
            check59.Visibility = Visibility.Collapsed;

            skin101.Visibility = Visibility.Visible;
            check101.Visibility = Visibility.Visible;
            skin103.Visibility = Visibility.Visible;
            check103.Visibility = Visibility.Visible;
            skin105.Visibility = Visibility.Visible;
            check105.Visibility = Visibility.Visible;
            skin106.Visibility = Visibility.Visible;
            check106.Visibility = Visibility.Visible;
            skin107.Visibility = Visibility.Visible;
            check107.Visibility = Visibility.Visible;
            skin108.Visibility = Visibility.Visible;
            check108.Visibility = Visibility.Visible;
            skin111.Visibility = Visibility.Visible;
            check111.Visibility = Visibility.Visible;
            skin112.Visibility = Visibility.Visible;
            check112.Visibility = Visibility.Visible;
            skin113.Visibility = Visibility.Visible;
            check113.Visibility = Visibility.Visible;
            skin114.Visibility = Visibility.Visible;
            check114.Visibility = Visibility.Visible;
            skin115.Visibility = Visibility.Visible;
            check115.Visibility = Visibility.Visible;
            skin116.Visibility = Visibility.Visible;
            check116.Visibility = Visibility.Visible;
            skin118.Visibility = Visibility.Visible;
            check118.Visibility = Visibility.Visible;
            skin119.Visibility = Visibility.Visible;
            check119.Visibility = Visibility.Visible;
            skin120.Visibility = Visibility.Visible;
            check120.Visibility = Visibility.Visible;
            skin122.Visibility = Visibility.Visible;
            check122.Visibility = Visibility.Visible;
            skin124.Visibility = Visibility.Visible;
            check124.Visibility = Visibility.Visible;
            skin125.Visibility = Visibility.Visible;
            check125.Visibility = Visibility.Visible;
            skin126.Visibility = Visibility.Visible;
            check126.Visibility = Visibility.Visible;
            skin127.Visibility = Visibility.Visible;
            check127.Visibility = Visibility.Visible;
            skin128.Visibility = Visibility.Visible;
            check128.Visibility = Visibility.Visible;
            skin129.Visibility = Visibility.Visible;
            check129.Visibility = Visibility.Visible;
            skin130.Visibility = Visibility.Visible;
            check130.Visibility = Visibility.Visible;
            skin132.Visibility = Visibility.Visible;
            check132.Visibility = Visibility.Visible;
            skin133.Visibility = Visibility.Visible;
            check133.Visibility = Visibility.Visible;
            skin135.Visibility = Visibility.Visible;
            check135.Visibility = Visibility.Visible;
            skin136.Visibility = Visibility.Visible;
            check136.Visibility = Visibility.Visible;
            skin138.Visibility = Visibility.Visible;
            check138.Visibility = Visibility.Visible;
            skin144.Visibility = Visibility.Visible;
            check144.Visibility = Visibility.Visible;
            skin146.Visibility = Visibility.Visible;
            check146.Visibility = Visibility.Visible;
            skin151.Visibility = Visibility.Visible;
            check151.Visibility = Visibility.Visible;
            skin152.Visibility = Visibility.Visible;
            check152.Visibility = Visibility.Visible;
            skin154.Visibility = Visibility.Visible;
            check154.Visibility = Visibility.Visible;
            skin156.Visibility = Visibility.Visible;
            check156.Visibility = Visibility.Visible;
            skin157.Visibility = Visibility.Visible;
            check157.Visibility = Visibility.Visible;
            skin158.Visibility = Visibility.Visible;
            check158.Visibility = Visibility.Visible;
            skin159.Visibility = Visibility.Visible;
            check159.Visibility = Visibility.Visible;
            skin161.Visibility = Visibility.Visible;
            check161.Visibility = Visibility.Visible;
            skin162.Visibility = Visibility.Visible;
            check162.Visibility = Visibility.Visible;
            skin163.Visibility = Visibility.Visible;
            check163.Visibility = Visibility.Visible;
            skin164.Visibility = Visibility.Visible;
            check164.Visibility = Visibility.Visible;
            skin165.Visibility = Visibility.Visible;
            check165.Visibility = Visibility.Visible;
            skin166.Visibility = Visibility.Visible;
            check166.Visibility = Visibility.Visible;
            skin167.Visibility = Visibility.Visible;
            check167.Visibility = Visibility.Visible;
            skin168.Visibility = Visibility.Visible;
            check168.Visibility = Visibility.Visible;
            skin169.Visibility = Visibility.Visible;
            check169.Visibility = Visibility.Visible;
            skin170.Visibility = Visibility.Visible;
            check170.Visibility = Visibility.Visible;
            skin171.Visibility = Visibility.Visible;
            check171.Visibility = Visibility.Visible;
            skin172.Visibility = Visibility.Visible;
            check172.Visibility = Visibility.Visible;
            skin173.Visibility = Visibility.Visible;
            check173.Visibility = Visibility.Visible;
            skin174.Visibility = Visibility.Visible;
            check174.Visibility = Visibility.Visible;
            skin175.Visibility = Visibility.Visible;
            check175.Visibility = Visibility.Visible;
            skin176.Visibility = Visibility.Visible;
            check176.Visibility = Visibility.Visible;
            skin177.Visibility = Visibility.Visible;
            check177.Visibility = Visibility.Visible;
            skin178.Visibility = Visibility.Visible;
            check178.Visibility = Visibility.Visible;
            skin179.Visibility = Visibility.Visible;
            check179.Visibility = Visibility.Visible;
            skin180.Visibility = Visibility.Visible;
            check180.Visibility = Visibility.Visible;
            skin181.Visibility = Visibility.Visible;
            check181.Visibility = Visibility.Visible;
            skin182.Visibility = Visibility.Visible;
            check182.Visibility = Visibility.Visible;

            skin102.Visibility = Visibility.Collapsed;
            check102.Visibility = Visibility.Collapsed;
            skin104.Visibility = Visibility.Collapsed;
            check104.Visibility = Visibility.Collapsed;
            skin109.Visibility = Visibility.Collapsed;
            check109.Visibility = Visibility.Collapsed;
            skin110.Visibility = Visibility.Collapsed;
            check110.Visibility = Visibility.Collapsed;
            skin117.Visibility = Visibility.Collapsed;
            check117.Visibility = Visibility.Collapsed;
            skin121.Visibility = Visibility.Collapsed;
            check121.Visibility = Visibility.Collapsed;
            skin123.Visibility = Visibility.Collapsed;
            check123.Visibility = Visibility.Collapsed;
            skin131.Visibility = Visibility.Collapsed;
            check131.Visibility = Visibility.Collapsed;
            skin134.Visibility = Visibility.Collapsed;
            check134.Visibility = Visibility.Collapsed;
            skin137.Visibility = Visibility.Collapsed;
            check137.Visibility = Visibility.Collapsed;
            skin139.Visibility = Visibility.Collapsed;
            check139.Visibility = Visibility.Collapsed;
            skin140.Visibility = Visibility.Collapsed;
            check140.Visibility = Visibility.Collapsed;
            skin141.Visibility = Visibility.Collapsed;
            check141.Visibility = Visibility.Collapsed;
            skin142.Visibility = Visibility.Collapsed;
            check142.Visibility = Visibility.Collapsed;
            skin143.Visibility = Visibility.Collapsed;
            check143.Visibility = Visibility.Collapsed;
            skin145.Visibility = Visibility.Collapsed;
            check145.Visibility = Visibility.Collapsed;
            skin147.Visibility = Visibility.Collapsed;
            check147.Visibility = Visibility.Collapsed;
            skin148.Visibility = Visibility.Collapsed;
            check148.Visibility = Visibility.Collapsed;
            skin149.Visibility = Visibility.Collapsed;
            check149.Visibility = Visibility.Collapsed;
            skin150.Visibility = Visibility.Collapsed;
            check150.Visibility = Visibility.Collapsed;
            skin153.Visibility = Visibility.Collapsed;
            check153.Visibility = Visibility.Collapsed;
            skin155.Visibility = Visibility.Collapsed;
            check155.Visibility = Visibility.Collapsed;
            skin160.Visibility = Visibility.Collapsed;
            check160.Visibility = Visibility.Collapsed;
            skin183.Visibility = Visibility.Collapsed;
            check183.Visibility = Visibility.Collapsed;
            skin184.Visibility = Visibility.Collapsed;
            check184.Visibility = Visibility.Collapsed;
            skin185.Visibility = Visibility.Collapsed;
            check185.Visibility = Visibility.Collapsed;
            skin186.Visibility = Visibility.Collapsed;
            check186.Visibility = Visibility.Collapsed;
            skin187.Visibility = Visibility.Collapsed;
            check187.Visibility = Visibility.Collapsed;
            skin188.Visibility = Visibility.Collapsed;
            check188.Visibility = Visibility.Collapsed;
            skin189.Visibility = Visibility.Collapsed;
            check189.Visibility = Visibility.Collapsed;
            skin190.Visibility = Visibility.Collapsed;
            check190.Visibility = Visibility.Collapsed;
            skin191.Visibility = Visibility.Collapsed;
            check191.Visibility = Visibility.Collapsed;
            skin192.Visibility = Visibility.Collapsed;
            check192.Visibility = Visibility.Collapsed;
            skin193.Visibility = Visibility.Collapsed;
            check193.Visibility = Visibility.Collapsed;
            skin194.Visibility = Visibility.Collapsed;
            check194.Visibility = Visibility.Collapsed;
            skin195.Visibility = Visibility.Collapsed;
            check195.Visibility = Visibility.Collapsed;
            skin196.Visibility = Visibility.Collapsed;
            check196.Visibility = Visibility.Collapsed;
            skin197.Visibility = Visibility.Collapsed;
            check197.Visibility = Visibility.Collapsed;
            skin198.Visibility = Visibility.Collapsed;
            check198.Visibility = Visibility.Collapsed;
            skin199.Visibility = Visibility.Collapsed;
            check199.Visibility = Visibility.Collapsed;
            skin200.Visibility = Visibility.Collapsed;
            check200.Visibility = Visibility.Collapsed;
            skin201.Visibility = Visibility.Collapsed;
            check201.Visibility = Visibility.Collapsed;

            //checkTS.Visibility = Visibility.Collapsed;
            //Title_Screen.Visibility = Visibility.Collapsed;
            //stageWarehouse.Visibility = Visibility.Collapsed;
            //Warehouse_Level.Visibility = Visibility.Collapsed;
            //WeaponsTextures.Visibility = Visibility.Collapsed;
            //WeaponsTexturesBlock.Visibility = Visibility.Collapsed;
            //MultyplayerTextures.Visibility = Visibility.Collapsed;
            //MultyplayerTexturesBlock.Visibility = Visibility.Collapsed;
        }

        private void SwitchToExtraSet()
        {
            skin1.Visibility = Visibility.Collapsed;
            check1.Visibility = Visibility.Collapsed;
            skin2.Visibility = Visibility.Collapsed;
            check2.Visibility = Visibility.Collapsed;
            skin3.Visibility = Visibility.Collapsed;
            check3.Visibility = Visibility.Collapsed;
            skin4.Visibility = Visibility.Collapsed;
            check4.Visibility = Visibility.Collapsed;
            skin5.Visibility = Visibility.Collapsed;
            check5.Visibility = Visibility.Collapsed;
            skin6.Visibility = Visibility.Collapsed;
            check6.Visibility = Visibility.Collapsed;
            skin7.Visibility = Visibility.Collapsed;
            check7.Visibility = Visibility.Collapsed;
            skin8.Visibility = Visibility.Collapsed;
            check8.Visibility = Visibility.Collapsed;
            skin9.Visibility = Visibility.Collapsed;
            check9.Visibility = Visibility.Collapsed;
            skin10.Visibility = Visibility.Collapsed;
            check10.Visibility = Visibility.Collapsed;
            skin11.Visibility = Visibility.Collapsed;
            check11.Visibility = Visibility.Collapsed;
            skin12.Visibility = Visibility.Collapsed;
            check12.Visibility = Visibility.Collapsed;
            skin13.Visibility = Visibility.Collapsed;
            check13.Visibility = Visibility.Collapsed;
            skin14.Visibility = Visibility.Collapsed;
            check14.Visibility = Visibility.Collapsed;
            skin15.Visibility = Visibility.Collapsed;
            check15.Visibility = Visibility.Collapsed;
            skin16.Visibility = Visibility.Collapsed;
            check16.Visibility = Visibility.Collapsed;
            skin17.Visibility = Visibility.Collapsed;
            check17.Visibility = Visibility.Collapsed;
            skin18.Visibility = Visibility.Collapsed;
            check18.Visibility = Visibility.Collapsed;
            skin19.Visibility = Visibility.Collapsed;
            check19.Visibility = Visibility.Collapsed;
            skin20.Visibility = Visibility.Collapsed;
            check20.Visibility = Visibility.Collapsed;
            skin21.Visibility = Visibility.Collapsed;
            check21.Visibility = Visibility.Collapsed;
            skin22.Visibility = Visibility.Collapsed;
            check22.Visibility = Visibility.Collapsed;
            skin23.Visibility = Visibility.Collapsed;
            check23.Visibility = Visibility.Collapsed;
            skin24.Visibility = Visibility.Collapsed;
            check24.Visibility = Visibility.Collapsed;
            skin25.Visibility = Visibility.Collapsed;
            check25.Visibility = Visibility.Collapsed;
            skin26.Visibility = Visibility.Collapsed;
            check26.Visibility = Visibility.Collapsed;
            skin27.Visibility = Visibility.Collapsed;
            check27.Visibility = Visibility.Collapsed;
            skin28.Visibility = Visibility.Collapsed;
            check28.Visibility = Visibility.Collapsed;
            skin29.Visibility = Visibility.Collapsed;
            check29.Visibility = Visibility.Collapsed;
            skin30.Visibility = Visibility.Collapsed;
            check30.Visibility = Visibility.Collapsed;
            skin31.Visibility = Visibility.Collapsed;
            check31.Visibility = Visibility.Collapsed;
            skin32.Visibility = Visibility.Collapsed;
            check32.Visibility = Visibility.Collapsed;
            skin33.Visibility = Visibility.Collapsed;
            check33.Visibility = Visibility.Collapsed;
            skin34.Visibility = Visibility.Collapsed;
            check34.Visibility = Visibility.Collapsed;
            skin35.Visibility = Visibility.Collapsed;
            check35.Visibility = Visibility.Collapsed;
            skin36.Visibility = Visibility.Collapsed;
            check36.Visibility = Visibility.Collapsed;
            skin37.Visibility = Visibility.Collapsed;
            check37.Visibility = Visibility.Collapsed;
            skin38.Visibility = Visibility.Collapsed;
            check38.Visibility = Visibility.Collapsed;
            skin39.Visibility = Visibility.Collapsed;
            check39.Visibility = Visibility.Collapsed;
            skin40.Visibility = Visibility.Collapsed;
            check40.Visibility = Visibility.Collapsed;
            skin41.Visibility = Visibility.Collapsed;
            check41.Visibility = Visibility.Collapsed;
            skin42.Visibility = Visibility.Collapsed;
            check42.Visibility = Visibility.Collapsed;
            skin43.Visibility = Visibility.Collapsed;
            check43.Visibility = Visibility.Collapsed;
            skin44.Visibility = Visibility.Collapsed;
            check44.Visibility = Visibility.Collapsed;
            skin45.Visibility = Visibility.Collapsed;
            check45.Visibility = Visibility.Collapsed;
            skin46.Visibility = Visibility.Collapsed;
            check46.Visibility = Visibility.Collapsed;
            skin47.Visibility = Visibility.Collapsed;
            check47.Visibility = Visibility.Collapsed;
            skin48.Visibility = Visibility.Collapsed;
            check48.Visibility = Visibility.Collapsed;
            skin49.Visibility = Visibility.Collapsed;
            check49.Visibility = Visibility.Collapsed;
            skin50.Visibility = Visibility.Collapsed;
            check50.Visibility = Visibility.Collapsed;
            skin51.Visibility = Visibility.Collapsed;
            check51.Visibility = Visibility.Collapsed;
            skin52.Visibility = Visibility.Collapsed;
            check52.Visibility = Visibility.Collapsed;
            skin53.Visibility = Visibility.Collapsed;
            check53.Visibility = Visibility.Collapsed;
            skin54.Visibility = Visibility.Collapsed;
            check54.Visibility = Visibility.Collapsed;
            skin55.Visibility = Visibility.Collapsed;
            check55.Visibility = Visibility.Collapsed;
            skin56.Visibility = Visibility.Collapsed;
            check56.Visibility = Visibility.Collapsed;
            skin57.Visibility = Visibility.Collapsed;
            check57.Visibility = Visibility.Collapsed;
            skin58.Visibility = Visibility.Collapsed;
            check58.Visibility = Visibility.Collapsed;
            skin59.Visibility = Visibility.Collapsed;
            check59.Visibility = Visibility.Collapsed;

            skin101.Visibility = Visibility.Collapsed;
            check101.Visibility = Visibility.Collapsed;
            skin103.Visibility = Visibility.Collapsed;
            check103.Visibility = Visibility.Collapsed;
            skin105.Visibility = Visibility.Collapsed;
            check105.Visibility = Visibility.Collapsed;
            skin106.Visibility = Visibility.Collapsed;
            check106.Visibility = Visibility.Collapsed;
            skin107.Visibility = Visibility.Collapsed;
            check107.Visibility = Visibility.Collapsed;
            skin108.Visibility = Visibility.Collapsed;
            check108.Visibility = Visibility.Collapsed;
            skin111.Visibility = Visibility.Collapsed;
            check111.Visibility = Visibility.Collapsed;
            skin112.Visibility = Visibility.Collapsed;
            check112.Visibility = Visibility.Collapsed;
            skin113.Visibility = Visibility.Collapsed;
            check113.Visibility = Visibility.Collapsed;
            skin114.Visibility = Visibility.Collapsed;
            check114.Visibility = Visibility.Collapsed;
            skin115.Visibility = Visibility.Collapsed;
            check115.Visibility = Visibility.Collapsed;
            skin116.Visibility = Visibility.Collapsed;
            check116.Visibility = Visibility.Collapsed;
            skin118.Visibility = Visibility.Collapsed;
            check118.Visibility = Visibility.Collapsed;
            skin119.Visibility = Visibility.Collapsed;
            check119.Visibility = Visibility.Collapsed;
            skin120.Visibility = Visibility.Collapsed;
            check120.Visibility = Visibility.Collapsed;
            skin122.Visibility = Visibility.Collapsed;
            check122.Visibility = Visibility.Collapsed;
            skin124.Visibility = Visibility.Collapsed;
            check124.Visibility = Visibility.Collapsed;
            skin125.Visibility = Visibility.Collapsed;
            check125.Visibility = Visibility.Collapsed;
            skin126.Visibility = Visibility.Collapsed;
            check126.Visibility = Visibility.Collapsed;
            skin127.Visibility = Visibility.Collapsed;
            check127.Visibility = Visibility.Collapsed;
            skin128.Visibility = Visibility.Collapsed;
            check128.Visibility = Visibility.Collapsed;
            skin129.Visibility = Visibility.Collapsed;
            check129.Visibility = Visibility.Collapsed;
            skin130.Visibility = Visibility.Collapsed;
            check130.Visibility = Visibility.Collapsed;
            skin132.Visibility = Visibility.Collapsed;
            check132.Visibility = Visibility.Collapsed;
            skin133.Visibility = Visibility.Collapsed;
            check133.Visibility = Visibility.Collapsed;
            skin135.Visibility = Visibility.Collapsed;
            check135.Visibility = Visibility.Collapsed;
            skin136.Visibility = Visibility.Collapsed;
            check136.Visibility = Visibility.Collapsed;
            skin138.Visibility = Visibility.Collapsed;
            check138.Visibility = Visibility.Collapsed;
            skin144.Visibility = Visibility.Collapsed;
            check144.Visibility = Visibility.Collapsed;
            skin146.Visibility = Visibility.Collapsed;
            check146.Visibility = Visibility.Collapsed;
            skin151.Visibility = Visibility.Collapsed;
            check151.Visibility = Visibility.Collapsed;
            skin152.Visibility = Visibility.Collapsed;
            check152.Visibility = Visibility.Collapsed;
            skin154.Visibility = Visibility.Collapsed;
            check154.Visibility = Visibility.Collapsed;
            skin156.Visibility = Visibility.Collapsed;
            check156.Visibility = Visibility.Collapsed;
            skin157.Visibility = Visibility.Collapsed;
            check157.Visibility = Visibility.Collapsed;
            skin158.Visibility = Visibility.Collapsed;
            check158.Visibility = Visibility.Collapsed;
            skin159.Visibility = Visibility.Collapsed;
            check159.Visibility = Visibility.Collapsed;
            skin161.Visibility = Visibility.Collapsed;
            check161.Visibility = Visibility.Collapsed;
            skin162.Visibility = Visibility.Collapsed;
            check162.Visibility = Visibility.Collapsed;
            skin163.Visibility = Visibility.Collapsed;
            check163.Visibility = Visibility.Collapsed;
            skin164.Visibility = Visibility.Collapsed;
            check164.Visibility = Visibility.Collapsed;
            skin165.Visibility = Visibility.Collapsed;
            check165.Visibility = Visibility.Collapsed;
            skin166.Visibility = Visibility.Collapsed;
            check166.Visibility = Visibility.Collapsed;
            skin167.Visibility = Visibility.Collapsed;
            check167.Visibility = Visibility.Collapsed;
            skin168.Visibility = Visibility.Collapsed;
            check168.Visibility = Visibility.Collapsed;
            skin169.Visibility = Visibility.Collapsed;
            check169.Visibility = Visibility.Collapsed;
            skin170.Visibility = Visibility.Collapsed;
            check170.Visibility = Visibility.Collapsed;
            skin171.Visibility = Visibility.Collapsed;
            check171.Visibility = Visibility.Collapsed;
            skin172.Visibility = Visibility.Collapsed;
            check172.Visibility = Visibility.Collapsed;
            skin173.Visibility = Visibility.Collapsed;
            check173.Visibility = Visibility.Collapsed;
            skin174.Visibility = Visibility.Collapsed;
            check174.Visibility = Visibility.Collapsed;
            skin175.Visibility = Visibility.Collapsed;
            check175.Visibility = Visibility.Collapsed;
            skin176.Visibility = Visibility.Collapsed;
            check176.Visibility = Visibility.Collapsed;
            skin177.Visibility = Visibility.Collapsed;
            check177.Visibility = Visibility.Collapsed;
            skin178.Visibility = Visibility.Collapsed;
            check178.Visibility = Visibility.Collapsed;
            skin179.Visibility = Visibility.Collapsed;
            check179.Visibility = Visibility.Collapsed;
            skin180.Visibility = Visibility.Collapsed;
            check180.Visibility = Visibility.Collapsed;
            skin181.Visibility = Visibility.Collapsed;
            check181.Visibility = Visibility.Collapsed;
            skin182.Visibility = Visibility.Collapsed;
            check182.Visibility = Visibility.Collapsed;

            skin102.Visibility = Visibility.Visible;
            check102.Visibility = Visibility.Visible;
            skin104.Visibility = Visibility.Visible;
            check104.Visibility = Visibility.Visible;
            skin109.Visibility = Visibility.Visible;
            check109.Visibility = Visibility.Visible;
            skin110.Visibility = Visibility.Visible;
            check110.Visibility = Visibility.Visible;
            skin117.Visibility = Visibility.Visible;
            check117.Visibility = Visibility.Visible;
            skin121.Visibility = Visibility.Visible;
            check121.Visibility = Visibility.Visible;
            skin123.Visibility = Visibility.Visible;
            check123.Visibility = Visibility.Visible;
            skin131.Visibility = Visibility.Visible;
            check131.Visibility = Visibility.Visible;
            skin134.Visibility = Visibility.Visible;
            check134.Visibility = Visibility.Visible;
            skin137.Visibility = Visibility.Visible;
            check137.Visibility = Visibility.Visible;
            skin139.Visibility = Visibility.Visible;
            check139.Visibility = Visibility.Visible;
            skin140.Visibility = Visibility.Visible;
            check140.Visibility = Visibility.Visible;
            skin141.Visibility = Visibility.Visible;
            check141.Visibility = Visibility.Visible;
            skin142.Visibility = Visibility.Visible;
            check142.Visibility = Visibility.Visible;
            skin143.Visibility = Visibility.Visible;
            check143.Visibility = Visibility.Visible;
            skin145.Visibility = Visibility.Visible;
            check145.Visibility = Visibility.Visible;
            skin147.Visibility = Visibility.Visible;
            check147.Visibility = Visibility.Visible;
            skin148.Visibility = Visibility.Visible;
            check148.Visibility = Visibility.Visible;
            skin149.Visibility = Visibility.Visible;
            check149.Visibility = Visibility.Visible;
            skin150.Visibility = Visibility.Visible;
            check150.Visibility = Visibility.Visible;
            skin153.Visibility = Visibility.Visible;
            check153.Visibility = Visibility.Visible;
            skin155.Visibility = Visibility.Visible;
            check155.Visibility = Visibility.Visible;
            skin160.Visibility = Visibility.Visible;
            check160.Visibility = Visibility.Visible;
            skin183.Visibility = Visibility.Visible;
            check183.Visibility = Visibility.Visible;
            skin184.Visibility = Visibility.Visible;
            check184.Visibility = Visibility.Visible;
            skin185.Visibility = Visibility.Visible;
            check185.Visibility = Visibility.Visible;
            skin186.Visibility = Visibility.Visible;
            check186.Visibility = Visibility.Visible;
            skin187.Visibility = Visibility.Visible;
            check187.Visibility = Visibility.Visible;
            skin188.Visibility = Visibility.Visible;
            check188.Visibility = Visibility.Visible;
            skin189.Visibility = Visibility.Visible;
            check189.Visibility = Visibility.Visible;
            skin190.Visibility = Visibility.Visible;
            check190.Visibility = Visibility.Visible;
            skin191.Visibility = Visibility.Visible;
            check191.Visibility = Visibility.Visible;
            skin192.Visibility = Visibility.Visible;
            check192.Visibility = Visibility.Visible;
            skin193.Visibility = Visibility.Visible;
            check193.Visibility = Visibility.Visible;
            skin194.Visibility = Visibility.Visible;
            check194.Visibility = Visibility.Visible;
            skin195.Visibility = Visibility.Visible;
            check195.Visibility = Visibility.Visible;
            skin196.Visibility = Visibility.Visible;
            check196.Visibility = Visibility.Visible;
            skin197.Visibility = Visibility.Visible;
            check197.Visibility = Visibility.Visible;
            skin198.Visibility = Visibility.Visible;
            check198.Visibility = Visibility.Visible;
            skin199.Visibility = Visibility.Visible;
            check199.Visibility = Visibility.Visible;
            skin200.Visibility = Visibility.Visible;
            check200.Visibility = Visibility.Visible;
            skin201.Visibility = Visibility.Visible;
            check201.Visibility = Visibility.Visible;

            //checkTS.Visibility = Visibility.Collapsed;
            //Title_Screen.Visibility = Visibility.Collapsed;
            //stageWarehouse.Visibility = Visibility.Collapsed;
            //Warehouse_Level.Visibility = Visibility.Collapsed;
            //WeaponsTextures.Visibility = Visibility.Collapsed;
            //WeaponsTexturesBlock.Visibility = Visibility.Collapsed;
            //MultyplayerTextures.Visibility = Visibility.Collapsed;
            //MultyplayerTexturesBlock.Visibility = Visibility.Collapsed;
        }


        private void SkinPreview1(object sender, MouseEventArgs e)
        {
            viewModel.SkinPreview = "/Resources/PreviewSkin1.png";
        }
        private void SkinPreview2(object sender, MouseEventArgs e)
        {
            viewModel.SkinPreview = "/Resources/PreviewSkin2.png";
        }
        private void SkinPreview3(object sender, MouseEventArgs e)
        {
            viewModel.SkinPreview = "/Resources/PreviewSkin3.png";
        }
        private void SkinPreview4(object sender, MouseEventArgs e)
        {
            viewModel.SkinPreview = "/Resources/PreviewSkin4.png";
        }
        private void SkinPreview5(object sender, MouseEventArgs e)
        {
            viewModel.SkinPreview = "/Resources/PreviewSkin5.png";
        }
        private void SkinPreview6(object sender, MouseEventArgs e)
        {
            viewModel.SkinPreview = "/Resources/PreviewSkin6.png";
        }
        private void SkinPreview7(object sender, MouseEventArgs e)
        {
            viewModel.SkinPreview = "/Resources/PreviewSkin7.png";
        }
        private void SkinPreview8(object sender, MouseEventArgs e)
        {
            viewModel.SkinPreview = "/Resources/PreviewSkin8.png";
        }
        private void SkinPreview9(object sender, MouseEventArgs e)
        {
            viewModel.SkinPreview = "/Resources/PreviewSkin9.png";
        }
        private void SkinPreview10(object sender, MouseEventArgs e)
        {
            viewModel.SkinPreview = "/Resources/PreviewSkin10.png";
        }
        private void SkinPreview11(object sender, MouseEventArgs e)
        {
            viewModel.SkinPreview = "/Resources/PreviewSkin11.png";
        }
        private void SkinPreview12(object sender, MouseEventArgs e)
        {
            viewModel.SkinPreview = "/Resources/PreviewSkin12.png";
        }
        private void SkinPreview13(object sender, MouseEventArgs e)
        {
            viewModel.SkinPreview = "/Resources/PreviewSkin13.png";
        }
        private void SkinPreview14(object sender, MouseEventArgs e)
        {
            viewModel.SkinPreview = "/Resources/PreviewSkin14.png";
        }
        private void SkinPreview15(object sender, MouseEventArgs e)
        {
            viewModel.SkinPreview = "/Resources/PreviewSkin15.png";
        }
        private void SkinPreview16(object sender, MouseEventArgs e)
        {
            viewModel.SkinPreview = "/Resources/PreviewSkin16.png";
        }
        private void SkinPreview17(object sender, MouseEventArgs e)
        {
            viewModel.SkinPreview = "/Resources/PreviewSkin17.png";
        }
        private void SkinPreview18(object sender, MouseEventArgs e)
        {
            viewModel.SkinPreview = "/Resources/PreviewSkin18.png";
        }
        private void SkinPreview19(object sender, MouseEventArgs e)
        {
            viewModel.SkinPreview = "/Resources/PreviewSkin19.png";
        }
        private void SkinPreview20(object sender, MouseEventArgs e)
        {
            viewModel.SkinPreview = "/Resources/PreviewSkin20.png";
        }
        private void SkinPreview21(object sender, MouseEventArgs e)
        {
            viewModel.SkinPreview = "/Resources/PreviewSkin21.png";
        }
        private void SkinPreview22(object sender, MouseEventArgs e)
        {
            viewModel.SkinPreview = "/Resources/PreviewSkin22.png";
        }
        private void SkinPreview23(object sender, MouseEventArgs e)
        {
            viewModel.SkinPreview = "/Resources/PreviewSkin23.png";
        }
        private void SkinPreview24(object sender, MouseEventArgs e)
        {
            viewModel.SkinPreview = "/Resources/PreviewSkin24.png";
        }
        private void SkinPreview25(object sender, MouseEventArgs e)
        {
            viewModel.SkinPreview = "/Resources/PreviewSkin25.png";
        }
        private void SkinPreview26(object sender, MouseEventArgs e)
        {
            viewModel.SkinPreview = "/Resources/PreviewSkin26.png";
        }
        private void SkinPreview27(object sender, MouseEventArgs e)
        {
            viewModel.SkinPreview = "/Resources/PreviewSkin27.png";
        }
        private void SkinPreview28(object sender, MouseEventArgs e)
        {
            viewModel.SkinPreview = "/Resources/PreviewSkin28.png";
        }
        private void SkinPreview29(object sender, MouseEventArgs e)
        {
            viewModel.SkinPreview = "/Resources/PreviewSkin29.png";
        }
        private void SkinPreview30(object sender, MouseEventArgs e)
        {
            viewModel.SkinPreview = "/Resources/PreviewSkin30.png";
        }
        private void SkinPreview31(object sender, MouseEventArgs e)
        {
            viewModel.SkinPreview = "/Resources/PreviewSkin31.png";
        }
        private void SkinPreview32(object sender, MouseEventArgs e)
        {
            viewModel.SkinPreview = "/Resources/PreviewSkin32.png";
        }
        private void SkinPreview33(object sender, MouseEventArgs e)
        {
            viewModel.SkinPreview = "/Resources/PreviewSkin33.png";
        }
        private void SkinPreview34(object sender, MouseEventArgs e)
        {
            viewModel.SkinPreview = "/Resources/PreviewSkin34.png";
        }
        private void SkinPreview35(object sender, MouseEventArgs e)
        {
            viewModel.SkinPreview = "/Resources/PreviewSkin35.png";
        }
        private void SkinPreview36(object sender, MouseEventArgs e)
        {
            viewModel.SkinPreview = "/Resources/PreviewSkin36.png";
        }
        private void SkinPreview37(object sender, MouseEventArgs e)
        {
            viewModel.SkinPreview = "/Resources/PreviewSkin37.png";
        }
        private void SkinPreview38(object sender, MouseEventArgs e)
        {
            viewModel.SkinPreview = "/Resources/PreviewSkin38.png";
        }
        private void SkinPreview39(object sender, MouseEventArgs e)
        {
            viewModel.SkinPreview = "/Resources/PreviewSkin39.png";
        }
        private void SkinPreview40(object sender, MouseEventArgs e)
        {
            viewModel.SkinPreview = "/Resources/PreviewSkin40.png";
        }
        private void SkinPreview41(object sender, MouseEventArgs e)
        {
            viewModel.SkinPreview = "/Resources/PreviewSkin41.png";
        }
        private void SkinPreview42(object sender, MouseEventArgs e)
        {
            viewModel.SkinPreview = "/Resources/PreviewSkin42.png";
        }
        private void SkinPreview43(object sender, MouseEventArgs e)
        {
            viewModel.SkinPreview = "/Resources/PreviewSkin43.png";
        }
        private void SkinPreview44(object sender, MouseEventArgs e)
        {
            viewModel.SkinPreview = "/Resources/PreviewSkin44.png";
        }
        private void SkinPreview45(object sender, MouseEventArgs e)
        {
            viewModel.SkinPreview = "/Resources/PreviewSkin45.png";
        }
        private void SkinPreview46(object sender, MouseEventArgs e)
        {
            viewModel.SkinPreview = "/Resources/PreviewSkin46.png";
        }
        private void SkinPreview47(object sender, MouseEventArgs e)
        {
            viewModel.SkinPreview = "/Resources/PreviewSkin47.png";
        }
        private void SkinPreview48(object sender, MouseEventArgs e)
        {
            viewModel.SkinPreview = "/Resources/PreviewSkin48.png";
        }
        private void SkinPreview49(object sender, MouseEventArgs e)
        {
            viewModel.SkinPreview = "/Resources/PreviewSkin49.png";
        }
        private void SkinPreview50(object sender, MouseEventArgs e)
        {
            viewModel.SkinPreview = "/Resources/PreviewSkin50.png";
        }
        private void SkinPreview51(object sender, MouseEventArgs e)
        {
            viewModel.SkinPreview = "/Resources/PreviewSkin51.png";
        }
        private void SkinPreview52(object sender, MouseEventArgs e)
        {
            viewModel.SkinPreview = "/Resources/PreviewSkin52.png";
        }
        private void SkinPreview53(object sender, MouseEventArgs e)
        {
            viewModel.SkinPreview = "/Resources/PreviewSkin53.png";
        }
        private void SkinPreview54(object sender, MouseEventArgs e)
        {
            viewModel.SkinPreview = "/Resources/PreviewSkin54.png";
        }
        private void SkinPreview55(object sender, MouseEventArgs e)
        {
            viewModel.SkinPreview = "/Resources/PreviewSkin55.png";
        }
        private void SkinPreview56(object sender, MouseEventArgs e)
        {
            viewModel.SkinPreview = "/Resources/PreviewSkin56.png";
        }
        private void SkinPreview57(object sender, MouseEventArgs e)
        {
            viewModel.SkinPreview = "/Resources/PreviewSkin57.png";
        }
        private void SkinPreview58(object sender, MouseEventArgs e)
        {
            viewModel.SkinPreview = "/Resources/PreviewSkin58.png";
        }
        private void SkinPreview59(object sender, MouseEventArgs e)
        {
            viewModel.SkinPreview = "/Resources/PreviewSkin59.png";
        }
        private void SkinPreview101(object sender, MouseEventArgs e)
        {
            viewModel.SkinPreview = "/Resources/PreviewSkin101.png";
        }
        private void SkinPreview102(object sender, MouseEventArgs e)
        {
            viewModel.SkinPreview = "/Resources/PreviewSkin102.png";
        }
        private void SkinPreview103(object sender, MouseEventArgs e)
        {
            viewModel.SkinPreview = "/Resources/PreviewSkin103.png";
        }
        private void SkinPreview104(object sender, MouseEventArgs e)
        {
            viewModel.SkinPreview = "/Resources/PreviewSkin104.png";
        }
        private void SkinPreview105(object sender, MouseEventArgs e)
        {
            viewModel.SkinPreview = "/Resources/PreviewSkin105.png";
        }
        private void SkinPreview106(object sender, MouseEventArgs e)
        {
            viewModel.SkinPreview = "/Resources/PreviewSkin106.png";
        }
        private void SkinPreview107(object sender, MouseEventArgs e)
        {
            viewModel.SkinPreview = "/Resources/PreviewSkin107.png";
        }
        private void SkinPreview108(object sender, MouseEventArgs e)
        {
            viewModel.SkinPreview = "/Resources/PreviewSkin108.png";
        }
        private void SkinPreview109(object sender, MouseEventArgs e)
        {
            viewModel.SkinPreview = "/Resources/PreviewSkin109.png";
        }

        private void SkinPreview110(object sender, MouseEventArgs e)
        {
            viewModel.SkinPreview = "/Resources/PreviewSkin110.png";
        }

        private void SkinPreview111(object sender, MouseEventArgs e)
        {
            viewModel.SkinPreview = "/Resources/PreviewSkin111.png";
        }

        private void SkinPreview112(object sender, MouseEventArgs e)
        {
            viewModel.SkinPreview = "/Resources/PreviewSkin112.png";
        }
        private void SkinPreview113(object sender, MouseEventArgs e)
        {
            viewModel.SkinPreview = "/Resources/PreviewSkin113.png";
        }
        private void SkinPreview114(object sender, MouseEventArgs e)
        {
            viewModel.SkinPreview = "/Resources/PreviewSkin114.png";
        }

        private void SkinPreview115(object sender, MouseEventArgs e)
        {
            viewModel.SkinPreview = "/Resources/PreviewSkin115.png";
        }
        private void SkinPreview116(object sender, MouseEventArgs e)
        {
            viewModel.SkinPreview = "/Resources/PreviewSkin116.png";
        }
        private void SkinPreview117(object sender, MouseEventArgs e)
        {
            viewModel.SkinPreview = "/Resources/PreviewSkin117.png";
        }
        private void SkinPreview118(object sender, MouseEventArgs e)
        {
            viewModel.SkinPreview = "/Resources/PreviewSkin118.png";
        }
        private void SkinPreview119(object sender, MouseEventArgs e)
        {
            viewModel.SkinPreview = "/Resources/PreviewSkin119.png";
        }
        private void SkinPreview120(object sender, MouseEventArgs e)
        {
            viewModel.SkinPreview = "/Resources/PreviewSkin120.png";
        }

        private void SkinPreview121(object sender, MouseEventArgs e)
        {
            viewModel.SkinPreview = "/Resources/PreviewSkin121.png";
        }

        private void SkinPreview122(object sender, MouseEventArgs e)
        {
            viewModel.SkinPreview = "/Resources/PreviewSkin122.png";
        }

        private void SkinPreview123(object sender, MouseEventArgs e)
        {
            viewModel.SkinPreview = "/Resources/PreviewSkin123.png";
        }

        private void SkinPreview124(object sender, MouseEventArgs e)
        {
            viewModel.SkinPreview = "/Resources/PreviewSkin124.png";
        }

        private void SkinPreview125(object sender, MouseEventArgs e)
        {
            viewModel.SkinPreview = "/Resources/PreviewSkin125.png";
        }

        private void SkinPreview126(object sender, MouseEventArgs e)
        {
            viewModel.SkinPreview = "/Resources/PreviewSkin126.png";
        }

        private void SkinPreview127(object sender, MouseEventArgs e)
        {
            viewModel.SkinPreview = "/Resources/PreviewSkin127.png";
        }

        private void SkinPreview128(object sender, MouseEventArgs e)
        {
            viewModel.SkinPreview = "/Resources/PreviewSkin128.png";
        }

        private void SkinPreview129(object sender, MouseEventArgs e)
        {
            viewModel.SkinPreview = "/Resources/PreviewSkin129.png";
        }

        private void SkinPreview130(object sender, MouseEventArgs e)
        {
            viewModel.SkinPreview = "/Resources/PreviewSkin130.png";
        }

        private void SkinPreview131(object sender, MouseEventArgs e)
        {
            viewModel.SkinPreview = "/Resources/PreviewSkin131.png";
        }

        private void SkinPreview132(object sender, MouseEventArgs e)
        {
            viewModel.SkinPreview = "/Resources/PreviewSkin132.png";
        }

        private void SkinPreview133(object sender, MouseEventArgs e)
        {
            viewModel.SkinPreview = "/Resources/PreviewSkin133.png";
        }

        private void SkinPreview134(object sender, MouseEventArgs e)
        {
            viewModel.SkinPreview = "/Resources/PreviewSkin134.png";
        }
        private void SkinPreview135(object sender, MouseEventArgs e)
        {
            viewModel.SkinPreview = "/Resources/PreviewSkin135.png";
        }

        private void SkinPreview136(object sender, MouseEventArgs e)
        {
            viewModel.SkinPreview = "/Resources/PreviewSkin136.png";
        }

        private void SkinPreview137(object sender, MouseEventArgs e)
        {
            viewModel.SkinPreview = "/Resources/PreviewSkin137.png";
        }

        private void SkinPreview138(object sender, MouseEventArgs e)
        {
            viewModel.SkinPreview = "/Resources/PreviewSkin138.png";
        }

        private void SkinPreview139(object sender, MouseEventArgs e)
        {
            viewModel.SkinPreview = "/Resources/PreviewSkin139.png";
        }

        private void SkinPreview140(object sender, MouseEventArgs e)
        {
            viewModel.SkinPreview = "/Resources/PreviewSkin140.png";
        }

        private void SkinPreview141(object sender, MouseEventArgs e)
        {
            viewModel.SkinPreview = "/Resources/PreviewSkin141.png";
        }

        private void SkinPreview142(object sender, MouseEventArgs e)
        {
            viewModel.SkinPreview = "/Resources/PreviewSkin142.png";
        }

        private void SkinPreview143(object sender, MouseEventArgs e)
        {
            viewModel.SkinPreview = "/Resources/PreviewSkin143.png";
        }

        private void SkinPreview144(object sender, MouseEventArgs e)
        {
            viewModel.SkinPreview = "/Resources/PreviewSkin144.png";
        }

        private void SkinPreview145(object sender, MouseEventArgs e)
        {
            viewModel.SkinPreview = "/Resources/PreviewSkin145.png";
        }

        private void SkinPreview146(object sender, MouseEventArgs e)
        {
            viewModel.SkinPreview = "/Resources/PreviewSkin146.png";
        }

        private void SkinPreview147(object sender, MouseEventArgs e)
        {
            viewModel.SkinPreview = "/Resources/PreviewSkin147.png";
        }

        private void SkinPreview148(object sender, MouseEventArgs e)
        {
            viewModel.SkinPreview = "/Resources/PreviewSkin148.png";
        }
        private void SkinPreview149(object sender, MouseEventArgs e)
        {
            viewModel.SkinPreview = "/Resources/PreviewSkin149.png";
        }

        private void SkinPreview150(object sender, MouseEventArgs e)
        {
            viewModel.SkinPreview = "/Resources/PreviewSkin150.png";
        }

        private void SkinPreview151(object sender, MouseEventArgs e)
        {
            viewModel.SkinPreview = "/Resources/PreviewSkin151.png";
        }

        private void SkinPreview152(object sender, MouseEventArgs e)
        {
            viewModel.SkinPreview = "/Resources/PreviewSkin152.png";
        }

        private void SkinPreview153(object sender, MouseEventArgs e)
        {
            viewModel.SkinPreview = "/Resources/PreviewSkin153.png";
        }

        private void SkinPreview154(object sender, MouseEventArgs e)
        {
            viewModel.SkinPreview = "/Resources/PreviewSkin154.png";
        }

        private void SkinPreview155(object sender, MouseEventArgs e)
        {
            viewModel.SkinPreview = "/Resources/PreviewSkin155.png";
        }

        private void SkinPreview156(object sender, MouseEventArgs e)
        {
            viewModel.SkinPreview = "/Resources/PreviewSkin156.png";
        }

        private void SkinPreview157(object sender, MouseEventArgs e)
        {
            viewModel.SkinPreview = "/Resources/PreviewSkin157.png";
        }

        private void SkinPreview158(object sender, MouseEventArgs e)
        {
            viewModel.SkinPreview = "/Resources/PreviewSkin158.png";
        }

        private void SkinPreview159(object sender, MouseEventArgs e)
        {
            viewModel.SkinPreview = "/Resources/PreviewSkin159.png";
        }

        private void SkinPreview160(object sender, MouseEventArgs e)
        {
            viewModel.SkinPreview = "/Resources/PreviewSkin160.png";
        }

        private void SkinPreview161(object sender, MouseEventArgs e)
        {
            viewModel.SkinPreview = "/Resources/PreviewSkin161.png";
        }
        private void SkinPreview162(object sender, MouseEventArgs e)
        {
            viewModel.SkinPreview = "/Resources/PreviewSkin162.png";
        }
        private void SkinPreview163(object sender, MouseEventArgs e)
        {
            viewModel.SkinPreview = "/Resources/PreviewSkin163.png";
        }
        private void SkinPreview164(object sender, MouseEventArgs e)
        {
            viewModel.SkinPreview = "/Resources/PreviewSkin164.png";
        }
        private void SkinPreview165(object sender, MouseEventArgs e)
        {
            viewModel.SkinPreview = "/Resources/PreviewSkin165.png";
        }
        private void SkinPreview166(object sender, MouseEventArgs e)
        {
            viewModel.SkinPreview = "/Resources/PreviewSkin166.png";
        }
        private void SkinPreview167(object sender, MouseEventArgs e)
        {
            viewModel.SkinPreview = "/Resources/PreviewSkin167.png";
        }
        private void SkinPreview168(object sender, MouseEventArgs e)
        {
            viewModel.SkinPreview = "/Resources/PreviewSkin168.png";
        }
        private void SkinPreview169(object sender, MouseEventArgs e)
        {
            viewModel.SkinPreview = "/Resources/PreviewSkin169.png";
        }
        private void SkinPreview170(object sender, MouseEventArgs e)
        {
            viewModel.SkinPreview = "/Resources/PreviewSkin170.png";
        }
        private void SkinPreview171(object sender, MouseEventArgs e)
        {
            viewModel.SkinPreview = "/Resources/PreviewSkin171.png";
        }
        private void SkinPreview172(object sender, MouseEventArgs e)
        {
            viewModel.SkinPreview = "/Resources/PreviewSkin172.png";
        }
        private void SkinPreview173(object sender, MouseEventArgs e)
        {
            viewModel.SkinPreview = "/Resources/PreviewSkin173.png";
        }
        private void SkinPreview174(object sender, MouseEventArgs e)
        {
            viewModel.SkinPreview = "/Resources/PreviewSkin174.png";
        }
        private void SkinPreview175(object sender, MouseEventArgs e)
        {
            viewModel.SkinPreview = "/Resources/PreviewSkin175.png";
        }
        private void SkinPreview176(object sender, MouseEventArgs e)
        {
            viewModel.SkinPreview = "/Resources/PreviewSkin176.png";
        }
        private void SkinPreview177(object sender, MouseEventArgs e)
        {
            viewModel.SkinPreview = "/Resources/PreviewSkin177.png";
        }
        private void SkinPreview178(object sender, MouseEventArgs e)
        {
            viewModel.SkinPreview = "/Resources/PreviewSkin178.png";
        }
        private void SkinPreview179(object sender, MouseEventArgs e)
        {
            viewModel.SkinPreview = "/Resources/PreviewSkin179.png";
        }
        private void SkinPreview180(object sender, MouseEventArgs e)
        {
            viewModel.SkinPreview = "/Resources/PreviewSkin180.png";
        }
        private void SkinPreview181(object sender, MouseEventArgs e)
        {
            viewModel.SkinPreview = "/Resources/PreviewSkin181.png";
        }
        private void SkinPreview182(object sender, MouseEventArgs e)
        {
            viewModel.SkinPreview = "/Resources/PreviewSkin182.png";
        }
        private void SkinPreview183(object sender, MouseEventArgs e)
        {
            viewModel.SkinPreview = "/Resources/PreviewSkin183.png";
        }
        private void SkinPreview184(object sender, MouseEventArgs e)
        {
            viewModel.SkinPreview = "/Resources/PreviewSkin184.png";
        }
        private void SkinPreview185(object sender, MouseEventArgs e)
        {
            viewModel.SkinPreview = "/Resources/PreviewSkin185.png";
        }
        private void SkinPreview186(object sender, MouseEventArgs e)
        {
            viewModel.SkinPreview = "/Resources/PreviewSkin186.png";
        }
        private void SkinPreview187(object sender, MouseEventArgs e)
        {
            viewModel.SkinPreview = "/Resources/PreviewSkin187.png";
        }
        private void SkinPreview188(object sender, MouseEventArgs e)
        {
            viewModel.SkinPreview = "/Resources/PreviewSkin188.png";
        }
        private void SkinPreview189(object sender, MouseEventArgs e)
        {
            viewModel.SkinPreview = "/Resources/PreviewSkin189.png";
        }
        private void SkinPreview190(object sender, MouseEventArgs e)
        {
            viewModel.SkinPreview = "/Resources/PreviewSkin190.png";
        }
        private void SkinPreview191(object sender, MouseEventArgs e)
        {
            viewModel.SkinPreview = "/Resources/PreviewSkin191.png";
        }

        private void SkinPreview192(object sender, MouseEventArgs e)
        {
            viewModel.SkinPreview = "/Resources/PreviewSkin192.png";
        }

        private void SkinPreview193(object sender, MouseEventArgs e)
        {
            viewModel.SkinPreview = "/Resources/PreviewSkin193.png";
        }

        private void SkinPreview194(object sender, MouseEventArgs e)
        {
            viewModel.SkinPreview = "/Resources/PreviewSkin194.png";
        }

        private void SkinPreview195(object sender, MouseEventArgs e)
        {
            viewModel.SkinPreview = "/Resources/PreviewSkin195.png";
        }

        private void SkinPreview196(object sender, MouseEventArgs e)
        {
            viewModel.SkinPreview = "/Resources/PreviewSkin196.png";
        }

        private void SkinPreview197(object sender, MouseEventArgs e)
        {
            viewModel.SkinPreview = "/Resources/PreviewSkin197.png";
        }

        private void SkinPreview198(object sender, MouseEventArgs e)
        {
            viewModel.SkinPreview = "/Resources/PreviewSkin198.png";
        }

        private void SkinPreview199(object sender, MouseEventArgs e)
        {
            viewModel.SkinPreview = "/Resources/PreviewSkin199.png";
        }

        private void SkinPreview200(object sender, MouseEventArgs e)
        {
            viewModel.SkinPreview = "/Resources/PreviewSkin200.png";
        }

        private void SkinPreview201(object sender, MouseEventArgs e)
        {
            viewModel.SkinPreview = "/Resources/PreviewSkin201.png";
        }

        private void SwitchModelsSize_Click(object sender, RoutedEventArgs e)
        {
            //string DanPath = @"G:\Danger\Big Roms and Emulators\ps2 roms\Urban Reign\Urban Reign Deluxe.iso";
            //string SorinPath = @"G:\GAMES\PCSX2 nightly\games\Urban Reign USA DELUXE.iso";
            //string filePath = DanPath;

            //bool canWeContinue = false;
            //try
            //{
            //    using (FileStream fs = File.Open(filePath, FileMode.Open, FileAccess.ReadWrite, FileShare.None))
            //    {
            //        canWeContinue = true;
            //    }
            //}
            //catch
            //{
            //    canWeContinue = false;
            //}

            //if (!canWeContinue)
            //{
            //    MessageBox.Show("File is open in another program (possibly PCSX2), close it!");
            //    return;
            //}


            //if (viewModel.ModelsSizeStatus == "Original")
            //{
            //    viewModel.ModelsSizeStatus = "Custom";
            //    ModelsClass.ChangeModelsSize(true, filePath);
            //}
            //else if (viewModel.ModelsSizeStatus == "Custom")
            //{
            //    viewModel.ModelsSizeStatus = "Original";
            //    ModelsClass.ChangeModelsSize(false, filePath);
            //}


        }

        private void ActivateAllRandomTextures_Click(object sender, RoutedEventArgs e)
        {
            viewModel.ActivateRandomAll();//Activate a random skin for every character
        }

        private void SwapTextures_Info(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("This will apply all the changes you made and save them.\n" +
                "Make sure you configure the folder paths in the upper right corner before using it.\n" +
                "Base folder should be the folder where you hold all the folders " +
                "it should be present in the main folder of this tool under the name 'Textures' " +
                "with the custom textures, and Replacement folder is the one located in your nightly folder + " +
                "\\textures\\SLUS-21209\\replacements." +
                "");
        }

        private void SwitchTexturesPages_Info(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Switch page between first set of skins and the bonus set of skins, weapons and others.\n" +
                "");
        }

        private void ActivateAllTextures_Info(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("This option will activate all primary custom textures for all characters + " +
                "some other textures from the extra page");
        }
        private void ActivateAllTextures2_Info(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("This option will activate all secondary custom textures for all characters + " +
                "some other textures from the extra page");
        }

        private void ActivateAllRandomTextures_Info(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("This option will activate a custom texture for every character at random.");
        }

        private void RemoveAllTextures_Info(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Disable all textures");
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
