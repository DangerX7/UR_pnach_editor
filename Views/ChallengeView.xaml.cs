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
    public partial class ChallengeView : UserControl
    {
        ChallengeViewModel viewModel;

        private DispatcherTimer timer;

        public ChallengeView()
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
                    sfxPath = partialPath + @"\sfx\Golem_Roar.mp3";
                    volume = 0.4;
                }
                else if (random > 70 && random < 99)
                {
                    sfxPath = partialPath + @"\sfx\GunShoot.mp3";
                    volume = 1.0;
                }
                else
                {
                    sfxPath = partialPath + @"\sfx\Gipsy_Laugh.mp3";
                    volume = 0.4;
                }

                customSound.Source = new Uri(sfxPath);
                customSound.Volume = volume;
            }

            SwitchToFirstGroup();

        }


        private void DoubleTghEneTeam_Click(object sender, RoutedEventArgs e)
        {
            CreatePnach.DoubleTghEneTeam();
            viewModel.CodeString = "Double Toughness Enemy Team";
            CodeText.Foreground = Brushes.Yellow;
            timer.Start();
        }

        private void BossP3_Click(object sender, RoutedEventArgs e)
        {
            CreatePnach.BossP3();
            viewModel.CodeString = "Boss Player 3";
            CodeText.Foreground = Brushes.Yellow;
            timer.Start();
        }

        private void WeakPlayerTeam_Click(object sender, RoutedEventArgs e)
        {
            CreatePnach.WeakPlayerTeam();
            viewModel.CodeString = "Weak Player Team";
            CodeText.Foreground = Brushes.Yellow;
            timer.Start();
        }

        private void BossShinkaiP3_Click(object sender, RoutedEventArgs e)
        {
            CreatePnach.BossShinkaiP3();
            viewModel.CodeString = "Boss Katana Master";
            CodeText.Foreground = Brushes.Yellow;
            timer.Start();
        }

        private void ExtremeEnemyTeam_Click(object sender, RoutedEventArgs e)
        {
            CreatePnach.ExtremeEnemyTeam();
            viewModel.CodeString = "Extreme Enemy Team";
            CodeText.Foreground = Brushes.Yellow;
            timer.Start();
        }

        private void StrongPlayerTeam_Click(object sender, RoutedEventArgs e)
        {
            CreatePnach.StrongPlayerTeam();
            viewModel.CodeString = "Strong Player Team";
            CodeText.Foreground = Brushes.Yellow;
            timer.Start();
        }

        private void HandicapPlayerTeam_Click(object sender, RoutedEventArgs e)
        {
            CreatePnach.HandicapPlayerTeam();
            viewModel.CodeString = "Handicap Player Team";
            CodeText.Foreground = Brushes.Yellow;
            timer.Start();
        }

        private void BossBradHawk_Click(object sender, RoutedEventArgs e)
        {
            CreatePnach2.BossBrad();
            viewModel.CodeString = "Boss Brad Hawk";
            CodeText.Foreground = Brushes.Yellow;
            timer.Start();
        }

        private void KGandBordin_Click(object sender, RoutedEventArgs e)
        {
            CreatePnach2.Kg_and_Bordin();
            viewModel.CodeString = "Kg and Bordin";
            CodeText.Foreground = Brushes.Yellow;
            timer.Start();
        }
        private void GunBackupMission_Click(object sender, RoutedEventArgs e)
        {
            CreatePnach2.GunBackupMission();
            viewModel.CodeString = "Gun Backup Mission";
            CodeText.Foreground = Brushes.Yellow;
            timer.Start();
        }

        private void RegionalChallenge_Click(object sender, RoutedEventArgs e)
        {
            CreatePnach2.RegionalChallenge();
            viewModel.CodeString = "Regional Challenge";
            CodeText.Foreground = Brushes.Yellow;
            timer.Start();
        }

        private void UndeadKG_Codes_Click(object sender, RoutedEventArgs e)
        {
            CreatePnach3.UndeadKG();
            viewModel.CodeString = "Undead KG";
            CodeText.Foreground = Brushes.Yellow;
            timer.Start();
        }

        private void BojunTeamCodes_Click(object sender, RoutedEventArgs e)
        {
            CreatePnach3.BojunTeam();
            viewModel.CodeString = "Boss Bojun Team";
            CodeText.Foreground = Brushes.Yellow;
            timer.Start();
        }

        private void BossDanSorinCodes_Click(object sender, RoutedEventArgs e)
        {
            CreatePnach3.BossDanSorin();
            viewModel.CodeString = "Boss Dan and Sorin";
            CodeText.Foreground = Brushes.Yellow;
            timer.Start();
        }

        private void BossFabioNashCodes_Click(object sender, RoutedEventArgs e)
        {
            CreatePnach3.BossFabioNash();
            viewModel.CodeString = "Boss Fabio and Nash";
            CodeText.Foreground = Brushes.Yellow;
            timer.Start();
        }

        private void BossUltraInstinctTeamCodes_Click(object sender, RoutedEventArgs e)
        {
            CreatePnach3.BossUltraInstinctTeam();
            viewModel.CodeString = "Boss Ultra Instinct Team";
            CodeText.Foreground = Brushes.Yellow;
            timer.Start();
        }

        private void BossTheMonstersCodes_Click(object sender, RoutedEventArgs e)
        {
            CreatePnach3.BossTheMonsters();
            viewModel.CodeString = "Boss The Monsters";
            CodeText.Foreground = Brushes.Yellow;
            timer.Start();
        }

        private void BossWeaponMastersCodes_Click(object sender, RoutedEventArgs e)
        {
            CreatePnach3.BossWeaponMasters();
            viewModel.CodeString = "Boss Weapon Masters";
            CodeText.Foreground = Brushes.Yellow;
            timer.Start();
        }

        private void BossTheBestCodes_Click(object sender, RoutedEventArgs e)
        {
            CreatePnach3.BossTheBest();
            viewModel.CodeString = "Boss The Best Team";
            CodeText.Foreground = Brushes.Yellow;
            timer.Start();
        }

        private void TekkenForceCodes_Click(object sender, RoutedEventArgs e)
        {
            CreatePnach3.TekkenForce();
            viewModel.CodeString = "Tekken Force";
            CodeText.Foreground = Brushes.Yellow;
            timer.Start();
        }

        private void GirlsPowerCodes_Click(object sender, RoutedEventArgs e)
        {
            CreatePnach3.GirlsPower();
            viewModel.CodeString = "Girls Power";
            CodeText.Foreground = Brushes.Yellow;
            timer.Start();
        }

        private void EnemyTeamInstantSPA_Click(object sender, RoutedEventArgs e)
        {
            CreatePnach3.EnemyTeamInstantSPA();
            viewModel.CodeString = "Enemy Team Instant SPA";
            CodeText.Foreground = Brushes.Yellow;
            timer.Start();
        }

        private void OneHitBoss_Click(object sender, RoutedEventArgs e)
        {
            CreatePnach3.OneHitBoss();
            viewModel.CodeString = "One Hit Boss";
            CodeText.Foreground = Brushes.Yellow;
            timer.Start();
        }

        private void KadonashiBoss_Click(object sender, RoutedEventArgs e)
        {
            CreatePnach3.KadonashiBoss();
            viewModel.CodeString = "Kadonashi Boss";
            CodeText.Foreground = Brushes.Yellow;
            timer.Start();
        }

        private void GunMasterPlayer3_Click(object sender, RoutedEventArgs e)
        {
            CreatePnach4.GunMasterPlayer3();
            viewModel.CodeString = "Gun Master Player 3";
            CodeText.Foreground = Brushes.Yellow;
            timer.Start();
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

        private void NapalmShaman_Codes_Click(object sender, RoutedEventArgs e)
        {
            CreatePnach4.NapalmShaman();
            viewModel.CodeString = "Napalm Shaman";
            CodeText.Foreground = Brushes.Yellow;
            timer.Start();
        }

        private void SuperVillainsCodes_Click(object sender, RoutedEventArgs e)
        {
            CreatePnach4.MckenzieAndNapalm();
            viewModel.CodeString = "Super Villains";
            CodeText.Foreground = Brushes.Yellow;
            timer.Start();
        }

        private void GoChallengeModePage_Click(object sender, RoutedEventArgs e)
        {
            viewModel.DisplayChallengeModeView();
        }

        private void ProtagonistTeamCodes_Click(object sender, RoutedEventArgs e)
        {
            CreatePnach4.ProtagonistTeam();
            viewModel.CodeString = "Protagonist Team";
            CodeText.Foreground = Brushes.Yellow;
            timer.Start();
        }

        private void KickChampionsCodes_Click(object sender, RoutedEventArgs e)
        {
            CreatePnach5.KickChampions();
            viewModel.CodeString = "Kick Champions";
            CodeText.Foreground = Brushes.Yellow;
            timer.Start();
        }

        private void GrandmasterChallenge_Click(object sender, RoutedEventArgs e)
        {
            CreatePnach5.GrandmasterChallenge();
            viewModel.CodeString = "Grandmaster Challenge";
            CodeText.Foreground = Brushes.Yellow;
            timer.Start();
        }

        private void SupremeOutlaw_Click(object sender, RoutedEventArgs e)
        {
            CreatePnach6.SupremeOutlaw();
            viewModel.CodeString = "Supreme Outlaw";
            CodeText.Foreground = Brushes.Yellow;
            timer.Start();
        }

        private void BossAndUnderboss_Click(object sender, RoutedEventArgs e)
        {
            CreatePnach6.BossAndUnderboss();
            viewModel.CodeString = "Boss and Underboss";
            CodeText.Foreground = Brushes.Yellow;
            timer.Start();
        }

        private void BrainwashBoss_Click(object sender, RoutedEventArgs e)
        {
            CreatePnach6.BrainwashBoss();
            viewModel.CodeString = "Brainwash Boss";
            CodeText.Foreground = Brushes.Yellow;
            timer.Start();
        }

        private void Ultimate7vs1_Click(object sender, RoutedEventArgs e)
        {
            CreatePnach6.Ultimate7vs1();
            viewModel.CodeString = "Ultimate 7 vs 1";
            CodeText.Foreground = Brushes.Yellow;
            timer.Start();
        }

        private void TheRockAndTheFlash_Click(object sender, RoutedEventArgs e)
        {
            CreatePnach8.TheRockAndTheFlash();
            viewModel.CodeString = "The Rock & The Flash";
            CodeText.Foreground = Brushes.Yellow;
            timer.Start();
        }

        private void SwitchGroup_Click(object sender, RoutedEventArgs e)
        {
            if (viewModel.IsPrimaryGroupActive)
            {
                SwitchToSecondGroup();
            }
            else
            {
                SwitchToFirstGroup();
            }
        }

        private void SwitchToFirstGroup()
        {
            KadonashiBoss.Visibility = Visibility.Visible;
            Napalm_Shaman.Visibility = Visibility.Visible;
            BossBrad.Visibility = Visibility.Visible;
            KG_Undead.Visibility = Visibility.Visible;
            OneHitBoss.Visibility = Visibility.Visible;
            BossShinkaiP3Code.Visibility = Visibility.Visible;
            btnBossP3.Visibility = Visibility.Visible;
            StrongPlayerTeamCode.Visibility = Visibility.Visible;
            HandicapPlayerTeamCode.Visibility = Visibility.Visible;
            WeakPlayerTeamCode.Visibility = Visibility.Visible;
            GrandmasterChallenge.Visibility = Visibility.Visible;
            SupremeOutlaw.Visibility = Visibility.Visible;
            BrainwashBoss.Visibility = Visibility.Visible;
            TheRockAndTheFlash.Visibility = Visibility.Visible;
            ThrowAndGunMasters.Visibility = Visibility.Visible;

            BossFabioNash.Visibility = Visibility.Collapsed;
            BossDanSorin.Visibility = Visibility.Collapsed;
            BojunTeam.Visibility = Visibility.Collapsed;
            BossWeaponMasters.Visibility = Visibility.Collapsed;
            BossTheMonsters.Visibility = Visibility.Collapsed;
            BossUltraInstinctTeam.Visibility = Visibility.Collapsed;
            TekkenForce.Visibility = Visibility.Collapsed;
            GirlsPower.Visibility = Visibility.Collapsed;
            BossTheBest.Visibility = Visibility.Collapsed;
            ProtagonistTeam.Visibility = Visibility.Collapsed;
            SuperVillains.Visibility = Visibility.Collapsed;
            KGandBordin.Visibility = Visibility.Collapsed;
            GunMasterPlayer.Visibility = Visibility.Collapsed;
            GunBackupMission.Visibility = Visibility.Collapsed;
            btnDoubleTghEneTeam.Visibility = Visibility.Collapsed;
            ExtremeEnemyTeamCode.Visibility = Visibility.Collapsed;
            RegionalChallenge.Visibility = Visibility.Collapsed;
            EnemyTeamInstantSPA.Visibility = Visibility.Collapsed;
            KickChampions.Visibility = Visibility.Collapsed;
            BossAndUnderboss.Visibility = Visibility.Collapsed;
            Ultimate7vs1.Visibility = Visibility.Collapsed;
            TheTrueFinalBoss.Visibility = Visibility.Collapsed;

            viewModel.IsPrimaryGroupActive = !viewModel.IsPrimaryGroupActive;
        }

        private void SwitchToSecondGroup()
        {
            KadonashiBoss.Visibility = Visibility.Collapsed;
            Napalm_Shaman.Visibility = Visibility.Collapsed;
            BossBrad.Visibility = Visibility.Collapsed;
            KG_Undead.Visibility = Visibility.Collapsed;
            OneHitBoss.Visibility = Visibility.Collapsed;
            BossShinkaiP3Code.Visibility = Visibility.Collapsed;
            btnBossP3.Visibility = Visibility.Collapsed;
            StrongPlayerTeamCode.Visibility = Visibility.Collapsed;
            HandicapPlayerTeamCode.Visibility = Visibility.Collapsed;
            WeakPlayerTeamCode.Visibility = Visibility.Collapsed;
            GrandmasterChallenge.Visibility = Visibility.Collapsed;
            SupremeOutlaw.Visibility = Visibility.Collapsed;
            BrainwashBoss.Visibility = Visibility.Collapsed;
            TheRockAndTheFlash.Visibility = Visibility.Collapsed;
            ThrowAndGunMasters.Visibility = Visibility.Collapsed;

            BossFabioNash.Visibility = Visibility.Visible;
            BossDanSorin.Visibility = Visibility.Visible;
            BojunTeam.Visibility = Visibility.Visible;
            BossWeaponMasters.Visibility = Visibility.Visible;
            BossTheMonsters.Visibility = Visibility.Visible;
            BossUltraInstinctTeam.Visibility = Visibility.Visible;
            TekkenForce.Visibility = Visibility.Visible;
            GirlsPower.Visibility = Visibility.Visible;
            BossTheBest.Visibility = Visibility.Visible;
            ProtagonistTeam.Visibility = Visibility.Visible;
            SuperVillains.Visibility = Visibility.Visible;
            KGandBordin.Visibility = Visibility.Visible;
            GunMasterPlayer.Visibility = Visibility.Visible;
            GunBackupMission.Visibility = Visibility.Visible;
            btnDoubleTghEneTeam.Visibility = Visibility.Visible;
            ExtremeEnemyTeamCode.Visibility = Visibility.Visible;
            RegionalChallenge.Visibility = Visibility.Visible;
            EnemyTeamInstantSPA.Visibility = Visibility.Visible;
            KickChampions.Visibility = Visibility.Visible;
            BossAndUnderboss.Visibility = Visibility.Visible;
            Ultimate7vs1.Visibility = Visibility.Visible;
            TheTrueFinalBoss.Visibility = Visibility.Visible;

            viewModel.IsPrimaryGroupActive = !viewModel.IsPrimaryGroupActive;
        }

        private void KadonashiBoss_MouseEnter(object sender, MouseEventArgs e)
        {
            viewModel.ModeInformation = "Enemy 1 \n" +
                "STK-1000 GRP-1000 RGA-1000\n" +
                "SPA-1000 WPA-1000 TGH-1000\n" +
                "HDE-1000 UBE-1000 LBE-1000\n" +
                "SPA DOWN = Power + Guard (infinite)\n" +
                "Character set to Kadonashi\n" +
                "\n" +
                "\n" +
                "\n" +
                "Enemy 2 \n" +
                "Default \n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "Difficulty ★★★★\n";
        }

        private void NapalmShaman_MouseEnter(object sender, MouseEventArgs e)
        {
            viewModel.ModeInformation = "Enemy 1 \n" +
                "STK- 800 GRP- 800 RGA- 750\n" +
                "SPA- 700 WPA- 600 TGH- 500\n" +
                "HDE- 400 UBE- 400 LBE- 400\n" +
                "SPA Regain 33%\n" +
                "SPA DOWN = Guard\n" +
                "Character set to Napalm\n" +
                "\n" +
                "\n" +
                "Enemy 2 \n" +
                "Default \n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "Difficulty ★★★★\n";
        }

        private void BossBradHawk_MouseEnter(object sender, MouseEventArgs e)
        {
            viewModel.ModeInformation = "Enemy 1 \n" +
                "STK-1400 GRP-1200 RGA-1100\n" +
                "SPA-1300 WPA-1000 TGH-1300\n" +
                "HDE-1000 UBE-1200 LBE- 800\n" +
                "SPA DOWN = Power + Guard\n" +
                "SPA Regain 10%\n" +
                "Character set to Brad with sunglasses\n" +
                "\n" +
                "\n" +
                "Enemy 2 \n" +
                "Default \n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "Difficulty ★★★★\n";
        }

        private void UndeadKG_Codes_MouseEnter(object sender, MouseEventArgs e)
        {
            viewModel.ModeInformation = "Enemy 1 \n" +
                "STK- 576 GRP- 500 RGA- 516\n" +
                "SPA- 546 WPA- 320 TGH-5000\n" +
                "HDE- 200 UBE- 200 LBE- 200\n" +
                "SPA DOWN = Armor\n" +
                "Character set to KG Beat-up\n" +
                "AI set to DWAYNE Story\n" +
                "\n" +
                "\n" +
                "\n" +
                "Enemy 2 \n" +
                "Default \n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "Difficulty ★★★★\n";
        }

        private void OneHitBoss_MouseEnter(object sender, MouseEventArgs e)
        {
            viewModel.ModeInformation = "Enemy 1 \n" +
                "STK-65535 GRP-65535 RGA-65535\n" +
                "SPA-65535 WPA-65535 TGH- 600\n" +
                "HDE-1000 UBE-1000 LBE-1000\n" +
                "AI set to Shadow Platoon Story\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "Enemy 2 \n" +
                "Default \n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "Difficulty ★★★★★★★★★\n";
        }

        private void BossShinkaiP3_MouseEnter(object sender, MouseEventArgs e)
        {
            viewModel.ModeInformation = "Enemy 1 \n" +
                "STK-1000 GRP-1000 RGA-1500\n" +
                "SPA-1500 WPA-3000 TGH-1500\n" +
                "HDE-1000 UBE-1000 LBE-1000\n" +
                "SPA DOWN = Power + Guard\n" +
                "SPA Regain 10%\n" +
                "AI set to Shinkai Story\n" +
                "\n" +
                "\n" +
                "Enemy 2 \n" +
                "STK-1000 GRP-1000 RGA-1000\n" +
                "SPA-1000 WPA-2000 TGH-1000\n" +
                "HDE- 500 UBE- 500 LBE- 500\n" +
                "AI set to Riki Story\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "Difficulty ★★★★★✩\n";
        }

        private void BossP3_MouseEnter(object sender, MouseEventArgs e)
        {
            viewModel.ModeInformation = "Enemy 1 \n" +
                "STK-2000 GRP-2000 RGA-2000\n" +
                "SPA-2000 WPA-2000 TGH-2000\n" +
                "HDE-2000 UBE-2000 LBE-2000\n" +
                "SPA Regain 10%\n" +
                "Ultra Instinct Hits\n" +
                "SPA Cooldown\n" +
                "\n" +
                "\n" +
                "Enemy 2 \n" +
                "Dead" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "Difficulty ★★★★✩\n";
        }

        private void StrongPlayerTeam_MouseEnter(object sender, MouseEventArgs e)
        {
            viewModel.ModeInformation = "Player 1 \n" +
                "STK-2000 GRP-2000 RGA-2000\n" +
                "SPA-2000 WPA-2000 TGH-2000\n" +
                "HDE-2000 UBE-2000 LBE-2000\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "Player 2 \n" +
                "STK-2000 GRP-2000 RGA-2000\n" +
                "SPA-2000 WPA-2000 TGH-2000\n" +
                "HDE-2000 UBE-2000 LBE-2000\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "Difficulty ✩\n";
        }

        private void HandicapPlayerTeam_MouseEnter(object sender, MouseEventArgs e)
        {
            viewModel.ModeInformation = "Player 1 \n" +
                "Health Bar 25%\n" +
                "Spa Gauge 0\n" +
                "\n" +
                "Player 2\n" +
                "Health Bar 25%\n" +
                "Spa Gauge 0\n" +
                "\n" +
                "\n" +
                "Enemy 1\n" +
                "SPA Gauge 47%" +
                "\n" +
                "\n" +
                "Enemy 2\n" +
                "SPA Gauge 47%\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "Difficulty ★★★★★★★\n";
        }

        private void WeakPlayerTeam_MouseEnter(object sender, MouseEventArgs e)
        {
            viewModel.ModeInformation = "Player 1 \n" +
                "STK- 100 GRP- 100 RGA- 100\n" +
                "SPA- 100 WPA- 100 TGH- 100\n" +
                "HDE- 100 UBE- 100 LBE- 100\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "Player 2 \n" +
                "STK- 100 GRP- 100 RGA- 100\n" +
                "SPA- 100 WPA- 100 TGH- 100\n" +
                "HDE- 100 UBE- 100 LBE- 100\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "Difficulty ★★★★★✩\n";
        }

        private void BossFabioNashCodes_MouseEnter(object sender, MouseEventArgs e)
        {
            viewModel.ModeInformation = "Enemy 1 \n" +
                "STK-1070 GRP-1010 RGA-1480\n" +
                "SPA-1690 WPA- 300 TGH-1710\n" +
                "HDE- 900 UBE- 900 LBE- 940\n" +
                "Character set to Park\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "Enemy 2 \n" +
                "STK-1210 GRP-1170 RGA-1110\n" +
                "SPA-1080 WPA-1000 TGH-1000\n" +
                "HDE-1090 UBE-1090 LBE-1250\n" +
                "SPA DOWN = Armor\n" +
                "Character set to Grimm\n" +
                "\n" +
                "\n" +
                "\n" +
                "Difficulty ★★★★✩\n";
        }

        private void BossDanSorinCodes_MouseEnter(object sender, MouseEventArgs e)
        {
            viewModel.ModeInformation = "Enemy 1 \n" +
                "STK-2000 GRP- 996 RGA-1100\n" +
                "SPA-1384 WPA- 520 TGH-1800\n" +
                "HDE- 740 UBE- 760 LBE- 700\n" +
                "SPA DOWN = Power + Armor\n" +
                "Character set to Brad with sunglasses\n" +
                "AI set to Golem Story\n" +
                "\n" +
                "\n" +
                "Enemy 2 \n" +
                "STK- 610 GRP-2000 RGA-2000\n" +
                "SPA-1480 WPA- 300 TGH-1590\n" +
                "HDE- 600 UBE- 690 LBE- 730\n" +
                "SPA DOWN = Power + Moves\n" +
                "Character set to Jake\n" +
                "Ultra Instinct Grabs\n" +
                "AI set to Alex Story\n" +
                "\n" +
                "Difficulty ★★★★★★★★\n";
        }

        private void BojunTeamCodes_MouseEnter(object sender, MouseEventArgs e)
        {
            viewModel.ModeInformation = "Enemy 1 \n" +
                "STK-1120 GRP-1024 RGA-1000\n" +
                "SPA- 976 WPA- 512 TGH- 944\n" +
                "HDE- 832 UBE-1008 LBE- 704\n" +
                "SPA Regain 10%\n" +
                "Character set to Booma\n" +
                "AI set to Grimm Story\n" +
                "\n" +
                "\n" +
                "Enemy 2 \n" +
                "STK-1000 GRP- 968 RGA-1024\n" +
                "SPA-1120 WPA-1192 TGH- 928\n" +
                "HDE- 880 UBE- 992 LBE- 368\n" +
                "Ultra Instinct Hits\n" +
                "Character set to Yan Jun\n" +
                "AI set to Alex Story\n" +
                "\n" +
                "\n" +
                "Difficulty ★★★★★✩\n";
        }

        private void BossWeaponMastersCodes_MouseEnter(object sender, MouseEventArgs e)
        {
            viewModel.ModeInformation = "Enemy 1 \n" +
                "STK-1000 GRP- 992 RGA-1056\n" +
                "SPA-1088 WPA-2500 TGH-1536\n" +
                "HDE- 800 UBE- 800 LBE- 800\n" +
                "Character set to Shinkai\n" +
                "Weapon set to Shinkai Katana\n" +
                "\n" +
                "\n" +
                "\n" +
                "Enemy 2 \n" +
                "STK-1056 GRP- 976 RGA- 944\n" +
                "SPA-1056 WPA-2000 TGH-1440\n" +
                "HDE- 680 UBE- 680 LBE- 680\n" +
                "Character set to Lin Fong\n" +
                "Weapon set to Lin Saber\n" +
                "\n" +
                "\n" +
                "\n" +
                "Difficulty ★★★★★★★\n";
        }

        private void BossTheMonstersCodes_MouseEnter(object sender, MouseEventArgs e)
        {
            viewModel.ModeInformation = "Enemy 1 \n" +
                "STK-1700 GRP-1800 RGA-1500\n" +
                "SPA-1050 WPA- 800 TGH-2000\n" +
                "HDE-1000 UBE-1400 LBE- 800\n" +
                "Character set to Golem\n" +
                "AI set to Golem Story\n" +
                "\n" +
                "\n" +
                "\n" +
                "Enemy 2 \n" +
                "STK-1552 GRP-1696 RGA-1328\n" +
                "SPA-1024 WPA-1000 TGH-1800\n" +
                "HDE-1000 UBE-1100 LBE-1000\n" +
                "Character set to Napalm 99\n" +
                "AI set to Napalm 99 Story\n" +
                "SPA Regain 0.5%\n" +
                "\n" +
                "\n" +
                "Difficulty ★★★★★★★★✩\n";
        }

        private void BossUltraInstinctTeamCodes_MouseEnter(object sender, MouseEventArgs e)
        {
            viewModel.ModeInformation = "Enemy 1 \n" +
                "STK-1100 GRP-1024 RGA-1500\n" +
                "SPA- 976 WPA-1040 TGH-1056\n" +
                "HDE- 928 UBE- 896 LBE- 864\n" +
                "Character set to McKinzie\n" +
                "Ultra Instinct Grabs\n" +
                "\n" +
                "\n" +
                "\n" +
                "Enemy 2 \n" +
                "STK-1184 GRP- 848 RGA-1024\n" +
                "SPA-1152 WPA-1120 TGH- 992\n" +
                "HDE-896  UBE- 864 LBE- 832\n" +
                "Character set to Lin Fong Lee\n" +
                "Ultra Instinct Hits\n" +
                "\n" +
                "\n" +
                "\n" +
                "Difficulty ★★★★★★★✩\n";
        }

        private void TekkenForceCodes_MouseEnter(object sender, MouseEventArgs e)
        {
            viewModel.ModeInformation = "Enemy 1 \n" +
                "STK-2000 GRP-1568 RGA-1536\n" +
                "SPA-1456 WPA-1000 TGH-1568\n" +
                "HDE- 800 UBE- 800 LBE- 800\n" +
                "Character set to Paul\n" + 
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "Enemy 2 \n" +
                "STK-1824 GRP-1536 RGA-1472\n" +
                "SPA-1888 WPA-1088 TGH-1440\n" +
                "HDE-1024 UBE-1024 LBE-1024\n" +
                "Character set to Law\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "Difficulty ★★★★★★★\n";
        }

        private void GirlsPowerCodes_MouseEnter(object sender, MouseEventArgs e)
        {
            viewModel.ModeInformation = "Enemy 1 \n" +
                "STK-1110 GRP-1024 RGA-1360\n" +
                "SPA-1344 WPA-1638 TGH- 800\n" +
                "HDE-760  UBE- 840 LBE- 800\n" +
                "SPA DOWN = Armor\n" +
                "Character set to Shun Ying Lee\n" +
                "\n" +
                "\n" +
                "\n" +
                "Enemy 2 \n" +
                "STK-1056 GRP-1072 RGA-1026\n" +
                "SPA-1248 WPA-1568 TGH- 640\n" +
                "HDE- 600 UBE- 720 LBE- 600\n" +
                "Ultra Instinct Hits\n" +
                "SPA Regain 10%\n" +
                "Character set to Lilian\n" +
                "\n" +
                "\n" +
                "Difficulty ★★★★★★\n";
        }

        private void BossTheBestCodes_MouseEnter(object sender, MouseEventArgs e)
        {
            viewModel.ModeInformation = "Enemy 1 \n" +
                "STK-1000 GRP- 992 RGA-1056\n" +
                "SPA-1088 WPA-2500 TGH-1536\n" +
                "HDE- 800 UBE- 800 LBE- 800\n" +
                "SPA DOWN = Power + Armor\n" +
                "Character set to Shinkai\n" +
                "Weapon set to Shinkai Katana\n" +
                "\n" +
                "\n" +
                "Enemy 2 \n" +
                "STK-1700 GRP-1800 RGA-1500\n" +
                "SPA-1050 WPA- 800 TGH-2000\n" +
                "HDE-1000 UBE-1400 LBE- 800\n" +
                "Character set to Golem\n" +
                "Weapon set to Axe\n" +
                "\n" +
                "\n" +
                "\n" +
                "Difficulty ★★★★★★★★★★\n";
        }

        private void ProtagonistTeamCodes_MouseEnter(object sender, MouseEventArgs e)
        {
            viewModel.ModeInformation = "Enemy 1 \n" +
                "STK-1000 GRP-1000 RGA-1200\n" +
                "SPA-1400 WPA-1200 TGH-1200\n" +
                "HDE- 700 UBE- 700 LBE- 700\n" +
                "SPA DOWN = Power (infinite)\n" +
                "SPA Gauge 47%\n" +
                "Character set to Shinkai\n" +
                "\n" +
                "\n" +
                "Enemy 2 \n" +
                "STK-1200 GRP- 800 RGA- 800\n" +
                "SPA- 900 WPA- 800 TGH- 900\n" +
                "HDE-1000 UBE-1000 LBE-1000\n" +
                "SPA DOWN = Guard (infinite)\n" +
                "Character set to Kadonashi\n" +
                "\n" +
                "\n" +
                "\n" +
                "Difficulty ★★★★★★★\n";
        }

        private void SuperVillainsCodes_MouseEnter(object sender, MouseEventArgs e)
        {
            viewModel.ModeInformation = "Enemy 1 \n" +
                "STK- 900 GRP- 880 RGA-3000\n" +
                "SPA- 840 WPA-1300 TGH-1000\n" +
                "HDE- 800 UBE- 800 LBE- 800\n" +
                "SPA Regain 50%\n" +
                "Damage from Wall High\n" +
                "SPA DOWN = Guard (infinite)\n" +
                "Character set to McKinzie\n" +
                "\n" +
                "Enemy 2 \n" +
                "STK- 900 GRP-1400 RGA- 900\n" +
                "SPA- 900 WPA- 800 TGH-1000\n" +
                "HDE-1000 UBE-1000 LBE-1000\n" +
                "SPA Regain 4%\n" +
                "SPA DOWN = Armor (infinite)\n" +
                "Character set to Napalm 99\n" +
                "\n" +
                "\n" +
                "Difficulty ★★★★★★★✩\n";
        }

        private void KGandBordin_MouseEnter(object sender, MouseEventArgs e)
        {
            viewModel.ModeInformation = "Enemy 1 \n" +
                "Character set to KG Beat-Up\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "Enemy 2 \n" +
                "Character set to Bordin (story)" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "Difficulty ✩\n";
        }

        private void GunMasterPlayer3_MouseEnter(object sender, MouseEventArgs e)
        {
            viewModel.ModeInformation = "Player 1 \n" +
                "Weapon Attack-32\n" +
                "Player 2 \n" +
                "Weapon Attack-32\n" +
                "\n" +
                "Enemy 1\n" +
                "STK- 576 GRP- 576 RGA- 576\n" +
                "SPA- 512 WPA- 256 TGH- 768\n" +
                "HDE- 800 UBE- 800 LBE- 800\n" +
                "SPA Regain 50%\n" +
                "SPA DOWN = Guard\n" +
                "Weapon set to Bordin's Gun\n" +
                "\n" +
                "Enemy 2\n" +
                "STK-1024 GRP- 976 RGA- 834\n" +
                "SPA- 832 WPA- 800 TGH-1152\n" +
                "HDE-1000 UBE-1000 LBE-1000\n" +
                "SPA DOWN = Armor (infinite)\n" +
                "Difficulty ★★★★\n";
        }

        private void GunBackupMission_MouseEnter(object sender, MouseEventArgs e)
        {
            viewModel.ModeInformation = "Player 1 \n" +
                "STK-70 GRP-60 RGA-80 SPA-100 WPA-100\n" +
                "TGH-100 HDE-100 UBE-160 LBE-60\n" +
                "Weapon set to Bordin's Gun\n" +
                "\n" +
                "PLayer 2 \n" +
                "STK-200 GRP-120 RGA-160 SPA-280 WPA-10\n" +
                "TGH-450 HDE-580 UBE-420 LBE-240\n" +
                "\n" +
                "Enemy 1 \n" +
                "STK-1000 GRP-1200 RGA-980 SPA-960 WPA-10\n" +
                "TGH-600 HDE-1000 UBE-1000 LBE-1000\n" +
                "SPA Regain 25%\n" +
                "\n" +
                "Enemy 2\n" +
                "STK-500 GRP-300 RGA-400 SPA-400 WPA-500\n" +
                "TGH-900 HDE-200 UBE-200 LBE-200\n" +
                "\n" +
                "Difficulty ★★★★✩\n";
        }

        private void RegionalChallenge_MouseEnter(object sender, MouseEventArgs e)
        {
            viewModel.ModeInformation = "Player 1 \n" +
                 "STK-100 GRP-120 RGA-400 SPA-200 WPA-120\n" +
                 "TGH-400 HDE-700 UBE-800 LBE-840\n" +
                 "\n" +
                 "PLayer 2 \n" +
                 "STK-90 GRP-100 RGA-500 SPA-150 WPA-150\n" +
                 "TGH-600 HDE-480 UBE-520 LBE-500\n" +
                 "\n" +
                 "Enemy 1 \n" +
                 "STK-700 GRP-400 RGA-800 SPA-700 WPA-600\n" +
                 "TGH-2000 HDE-600 UBE-900 LBE-1000\n" +
                 "\n" +
                 "Enemy 2\n" +
                 "STK-800 GRP-900 RGA-598 SPA-800 WPA-600\n" +
                 "TGH-900 HDE-1000 UBE-900 LBE-600\n" +
                 "\n" +
                 "\n" +
                 "\n" +
                 "Difficulty ★★★✩\n";
        }

        private void EnemyTeamInstantSPA_MouseEnter(object sender, MouseEventArgs e)
        {
            viewModel.ModeInformation = "Enemy 1 \n" +
                "SPA Regain 100%\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "Enemy 2 \n" +
                "SPA Regain 100%" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "Difficulty ★★★★★\n";
        }

        private void ExtremeEnemyTeam_MouseEnter(object sender, MouseEventArgs e)
        {
            viewModel.ModeInformation = "Enemy 1 \n" +
                "STK-500 GRP-500 RGA-500\n" +
                "SPA-500 WPA-500 TGH-3000\n" +
                "HDE-1000 UBE-1000 LBE-1000\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "Enemy 2 \n" +
                "STK-3000 GRP-2000 RGA-2000\n" +
                "SPA-3000 WPA-2000 TGH-500\n" +
                "HDE-100 UBE-100 LBE-100\n" +
                "Ultra Instinct Full\n" +
                "SPA Regain 25%\n" +
                "\n" +
                "\n" +
                "\n" +
                "Difficulty ★★★★★\n";
        }

        private void DoubleTghEneTeam_MouseEnter(object sender, MouseEventArgs e)
        {
            viewModel.ModeInformation = "Player 1 \n" +
                "SPA Regain 10%\n" +
                "\n" +
                "Player 2\n" +
                "SPA Regain 10%\n" +
                "\n" +
                "Enemy 1 \n" +
                "Toughness-2000\n" +
                "HDE-2000 UBE-2000 LBE-2000\n" +
                "\n" +
                "Enemy 2 \n" +
                "Toughness-2000\n" +
                "HDE-2000 UBE-2000 LBE-2000\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "Difficulty ★★★★★\n";
        }

        private void KickChampionsCodes_MouseEnter(object sender, MouseEventArgs e)
        {
            viewModel.ModeInformation = "Enemy 1 \n" +
                "STK-3000 GRP-2200 RGA-2100\n" +
                "SPA-2000 WPA- 500 TGH-2200\n" +
                "HDE-1100 UBE-1200 LBE-1800\n" +
                "Character set to Tong Yoon\n" +
                "AI set to Tong Yoon Story\n" +
                "\n" +
                "\n" +
                "\n" +
                "Enemy 2 \n" +
                "STK-2100 GRP-2000 RGA-1700\n" +
                "SPA-2800 WPA- 600 TGH-1800\n" +
                "HDE- 750 UBE- 900 LBE-1200\n" +
                "Ultra Instinct Grabs\n" +
                "Character set to Park\n" +
                "AI set to Park Story\n" +
                "\n" +
                "\n" +
                "Difficulty ★★★★★★★★★✩\n";
        }

        private void GrandmasterChallenge_MouseEnter(object sender, MouseEventArgs e)
        {
            viewModel.ModeInformation = "Player 1, 2, 4 will be on the same team\n" +
                "Strike & Weapon Attack - Max\n" +
                "Grapple & Special Attack - Min\n" +
                "\n" +
                "\n" +
                "\n" +
                "Enemy will be\n" +
                "fighter number 3\n" +
                "Toughness - Steel\n" +
                "Ultra Instinct Full\n" +
                "Low Wall Damage (takes)\n" +
                "SPA Regain 100%\n" +
                "\n" +
                "\n" +
                "Fighter number 4 \n" +
                "will join your team\n" +
                "\n" +
                "\n" +
                "Difficulty ★★★★★★★★★★\n";
        }

        private void SupremeOutlaw_MouseEnter(object sender, MouseEventArgs e)
        {
            viewModel.ModeInformation =  "\n" +
                "Enemy 1 is Napalm\n" +
                "STK-2100 GRP-2200 RGA-1600\n" +
                "SPA-2000 WPA- 800 TGH-2000\n" +
                "HDE-1200 UBE-1300 LBE-1200\n" +
                "SPA DOWN = Armor (infinite)\n" +
                "SPA Regain 0.2%\n" +
                "AI set to Golem Story\n" +
                "\n" +
                "\n" +
                "\n" +
                "Fighter number 4 \n" +
                "will join your team\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "Difficulty ★★★★★★★\n";
        }

        private void BossAndUnderboss_MouseEnter(object sender, MouseEventArgs e)
        {
            viewModel.ModeInformation = "Enemy 1 \n" +
                "Weapon-3000\n" +
                "Toughness-1000\n" +
                "Character set to Bordin\n" +
                "AI set to Bordin Story\n" +
                "Have modified gun\n" +
                "\n" +
                "\n" +
                "\n" +
                "Enemy 2 \n" +
                "Toughness-1500\n" +
                "Ultra Instinct Hits\n" +
                "Character set to Golem\n" +
                "AI set to Golem Story\n" +
                "SPA DOWN = Armor (infinite)\n" +
                "\n" +
                "\n" +
                "\n" +
                "Difficulty ★★★★★★★\n";
        }

        private void BrainwashBoss_MouseEnter(object sender, MouseEventArgs e)
        {
            viewModel.ModeInformation = "Player 1, 2, 4 will be on the same team\n" + 
                "Player 3 will be your enemy \n" +
                "Toughness-2000\n" +
                "Everytime his hp gets decreased he takes one\n" +
                "of your allies by his side, that includes you too.\n" +
                "Beat the brainwashed allied up to make them\n" +
                "come back to their senses and join your team.\n" +
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
                "Difficulty ★★★★★★★★★★\n";
        }


        private void Ultimate7vs1_MouseEnter(object sender, MouseEventArgs e)
        {
            viewModel.ModeInformation = "Player 3 will be your enemy \n" +
                "All Stats-2000\n" +
                "\n" +
                "Everyone else will be on your team\n" +
                "Others Stats will be 500\n" +
                "Except Players 1,2,4 Toughness - 1000\n" +
                "\n" +
                "This will be a 7 vs 1 fight, you can select 1,2,3 players\n" +
                "the rest are selected thru pnach code.\n" +
                "This is the first time playing with 8 fighters at once in multiplayer\n" +
                "so espect some problems.\n" +
                "\n" +
                "Lastly if player 1,2 and 4 is defeated the fight is over,\n" +
                "Players 5,6,7,8 does not count.\n" +
                "\n" +
                "Difficulty ★★★★★★★★★\n";
        }


        private void Timer_Tick(object sender, EventArgs e)
        {
            CodeText.Foreground = Brushes.White; // Reset the color to the original
            timer.Stop();
        }

        private void TheTrueFinalBoss_Click(object sender, RoutedEventArgs e)
        {
            CreatePnach8.TheTrueFinalBoss();
            viewModel.CodeString = "The True Final Boss";
            CodeText.Foreground = Brushes.Yellow;
            timer.Start();
        }

        private void TheTrueFinalBoss_MouseEnter(object sender, MouseEventArgs e)
        {
            viewModel.ModeInformation = "Player 1 or 2 must select Brad\n" +
                "\n" +
                "Enemy 1 is Bordin\n" +
                "infinite blue spa\n" +
                "5000 TGH + the gun\n" +
                "\n" +
                "Enemy 2 is Golem\n" +
                "Regeneration SPA\n" +
                "\n" +
                "Enemy 3 is Brad (clone)\n" +
                "All Stats 1000\n" +
                "All Stats 3000 when using spa down\n" +
                "\n" +
                "This is the true final battle,\n" +
                "you must beat Brad and Golem first\n" +
                "then Bordin will be vulnerable.\n" +
                "\n" +
                "\n" +
                "Difficulty ★★★★★★★★★★★★\n";
        }


        private void TheRockAndTheFlash_MouseEnter(object sender, MouseEventArgs e)
        {
            viewModel.ModeInformation = "\n" +
                "\n" +
                "\n" +
                "Enemy 1 is Golem\n" +
                "2000 GRP\n" +
                "3000 TGH\n" +
                "\n" +
                "\n" +
                "Enemy 2 is Lin Fong Lee\n" +
                "2000 WPA\n" +
                "1000 TGH\n" +
                "Ultra Instinct Hits\n" +
                "Ultra Instinct Grabs\n" +
                "Equiped with Lin Saber\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "Difficulty ★★★★★★★★★\n";
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



        private void ThrowAndGunMasters_Click(object sender, RoutedEventArgs e)
        {
            CreatePnach9.ThrowAndGunMasters();
            viewModel.CodeString = "Throw and Gun Masters";
            CodeText.Foreground = Brushes.Yellow;
            timer.Start();
        }
        private void ThrowAndGunMasters_MouseEnter(object sender, MouseEventArgs e)
        {
            viewModel.ModeInformation = "Enemy 1\n" +
                "1000 GRP\n" +
                "1200 TGH\n" +
                "Armor SPA\n" +
                "Ultra instinct for grabs\n" +
                "Increase Grapple while SPA is active\n" +
                "\n" +
                "Enemy 2\n" +
                "Max weapon grip and bullets\n" +
                "5 WPA\n" +
                "5000 TGH\n" +
                "Have gun\n" +
                "You need to beat Enemy 1 first\n" +
                "After enemy 1 is defeated enemy 2 toughness will fall but his gun will get an upgrade\n" +
                "\n" +
                "\n" +
                "\n" +
                "Difficulty ★???\n";
        }

    }




}
