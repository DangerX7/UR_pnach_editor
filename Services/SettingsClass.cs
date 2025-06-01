using Microsoft.VisualBasic;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace UR_pnach_editor.Services
{
    public class SettingsClass
    {
        //    static string Desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        //    static string filepath = System.IO.Path.Combine(Desktop, "file.txt");
        static string dangerLaptopPath = @"C:\Users\dange\Documents\PCSX2\cheats\";
        static string sorinPCPath = @"D:\DOCUMENTS\PCSX2\cheats\";
        static string dangerWorkPath = @"C:\Users\a.pandele\Documents\PCSX2\cheats\";
        static string nashPCPath = @"C:\Users\Asus\Documents\PCSX2\cheats\";

        public static string originalPnach = "BDD9BAAD";
        public static string deluxePnach = "A9D22191";
        public static string MovesPnach = "A584220F";
        public static string StatsPnach = "AC59257A";
        public static string MovesAndStatsPnach = "A00F26E4";


        public static string PnachName = "C319B3A4";
        public static string codeFolderPath { get; set; } = @"";
        public static string codeFilePath = codeFolderPath + @"\" + PnachName + ".pnach";
        public static string missionFolderPath { get; set; } = @"";

        public static string textureBaseFolderPath { get; set; } = @"";
        public static string textureDumpFolderPath { get; set; } = @""; //G:\GAMES\PCSX2 nightly\textures\SLUS-21209\replacements
        public static string gameFolderPath { get; set; } = @"";


        public static bool missile = false;
        public static int EditorEffectsIndex = 0;
        public static bool modelsSizeStatus { get; set; } = false;
        public static bool KG_Tall_Model { get; set; } = false;
        public static bool Real_Dwarf_Model { get; set; } = false;
        public static bool Golem_Giant_Model { get; set; } = false;
        public static bool Gnome_Napalm_Model { get; set; } = false;
        public static bool Amazon_Shun_Ying { get; set; } = false;
        public static string MusicStatus { get; set; } = "Original";
        public static string BradModelSwap { get; set; } = "Original";


        public static double STK_1 { get; set; } = 0;
        public static double GRP_1 { get; set; } = 0;
        public static double RGA_1 { get; set; } = 0;
        public static double SPA_1 { get; set; } = 0;
        public static double WPA_1 { get; set; } = 0;
        public static double TGH_1 { get; set; } = 0;
        public static double HDE_1 { get; set; } = 0;
        public static double UBE_1 { get; set; } = 0;
        public static double LBE_1 { get; set; } = 0;
        public static double STK_2 { get; set; } = 0;
        public static double GRP_2 { get; set; } = 0;
        public static double RGA_2 { get; set; } = 0;
        public static double SPA_2 { get; set; } = 0;
        public static double WPA_2 { get; set; } = 0;
        public static double TGH_2 { get; set; } = 0;
        public static double HDE_2 { get; set; } = 0;
        public static double UBE_2 { get; set; } = 0;
        public static double LBE_2 { get; set; } = 0;
        public static double STK_3 { get; set; } = 0;
        public static double GRP_3 { get; set; } = 0;
        public static double RGA_3 { get; set; } = 0;
        public static double SPA_3 { get; set; } = 0;
        public static double WPA_3 { get; set; } = 0;
        public static double TGH_3 { get; set; } = 0;
        public static double HDE_3 { get; set; } = 0;
        public static double UBE_3 { get; set; } = 0;
        public static double LBE_3 { get; set; } = 0;
        public static double STK_4 { get; set; } = 0;
        public static double GRP_4 { get; set; } = 0;
        public static double RGA_4 { get; set; } = 0;
        public static double SPA_4 { get; set; } = 0;
        public static double WPA_4 { get; set; } = 0;
        public static double TGH_4 { get; set; } = 0;
        public static double HDE_4 { get; set; } = 0;
        public static double UBE_4 { get; set; } = 0;
        public static double LBE_4 { get; set; } = 0;
        public static double STK_5 { get; set; } = 0;
        public static double GRP_5 { get; set; } = 0;
        public static double RGA_5 { get; set; } = 0;
        public static double SPA_5 { get; set; } = 0;
        public static double WPA_5 { get; set; } = 0;
        public static double TGH_5 { get; set; } = 0;
        public static double HDE_5 { get; set; } = 0;
        public static double UBE_5 { get; set; } = 0;
        public static double LBE_5 { get; set; } = 0;

        public static bool WarehouseTxt { get; set; } = false;
        public static bool GolemTuxedoTxt { get; set; } = false;
        public static bool GolemShirtlessTxt { get; set; } = false;
        public static bool KGBeat_upTxt { get; set; } = false;
        public static bool GD_04Txt { get; set; } = false;
        public static bool GD_05Skin { get; set; } = false;
        public static bool KadonashiOGTxt { get; set; } = false;
        public static bool OfficerNapalm99Txt { get; set; } = false;
        public static bool NightmareTxt { get; set; } = false;
        public static bool SuspectTxt { get; set; } = false;
        public static bool Shinkai007Txt { get; set; } = false;
        public static bool YanJunDrunkenFistTxt { get; set; } = false;
        public static bool BoomaSurgeonTxt { get; set; } = false;
        public static bool FashionShunYingTxt { get; set; } = false;
        public static bool CollegeBoyBradTxt { get; set; } = false;
        public static bool HellsLegionBordinTxt { get; set; } = false;
        public static bool AlternativeParkTxt { get; set; } = false;
        public static bool AristocratChrisTxt { get; set; } = false;
        public static bool BouncerFKTxt { get; set; } = false;
        public static bool FlamingMiguelTxt { get; set; } = false;
        public static bool GeishaLilianTxt { get; set; } = false;
        public static bool GrolemTxt { get; set; } = false;
        public static bool KoolRamonTxt { get; set; } = false;
        public static bool MountainGrimTxt { get; set; } = false;
        public static bool RejinTxt { get; set; } = false;
        public static bool SpyKellyTxt { get; set; } = false;
        public static bool TYCleanClothesTxt { get; set; } = false;

        public static bool GlenSkin { get; set; } = false;
        public static bool TorqueSkin { get; set; } = false;
        public static bool RodSkin { get; set; } = false;
        public static bool SethSkin { get; set; } = false;
        public static bool NasTiiiSkin { get; set; } = false;
        public static bool EmCeeSkin { get; set; } = false;
        public static bool RealDealSkin { get; set; } = false;
        public static bool JoseSkin { get; set; } = false;
        public static bool EmilioSkin { get; set; } = false;
        public static bool ZackSkin { get; set; } = false;
        public static bool ColinSkin { get; set; } = false;
        public static bool JakeSkin { get; set; } = false;
        public static bool TongYoonSkin { get; set; } = false;
        public static bool BKSkin { get; set; } = false;
        public static bool GraveDiggaSkin { get; set; } = false;
        public static bool BonesSkin { get; set; } = false;
        public static bool BustaSkin { get; set; } = false;
        public static bool SpiderSkin { get; set; } = false;
        public static bool PainKillahSkin { get; set; } = false;
        public static bool DwayneSkin { get; set; } = false;
        public static bool DR88Skin { get; set; } = false;
        public static bool PT22Skin { get; set; } = false;
        public static bool BainSkin { get; set; } = false;
        public static bool CooperSkin { get; set; } = false;
        public static bool AndersonSkin { get; set; } = false;
        public static bool TaylorSkin { get; set; } = false;
        public static bool AlexSkin { get; set; } = false;
        public static bool McKinzieSkin { get; set; } = false;
        public static bool RikiSkin { get; set; } = false;
        public static bool MasaSkin { get; set; } = false;
        public static bool HiroSkin { get; set; } = false;
        public static bool RyujiSkin { get; set; } = false;
        public static bool YeWeiSkin { get; set; } = false;
        public static bool ShaYingSkin { get; set; } = false;
        public static bool LinFongLeeSkin { get; set; } = false;
        public static bool VeraSkin { get; set; } = false;
        public static bool PaulSkin { get; set; } = false;
        public static bool LawSkin { get; set; } = false;

        public static bool SH2JamesTxt { get; set; } = false;
        public static bool RebeccaChambersTxt { get; set; } = false;
        public static bool ParkDanteTxt { get; set; } = false;
        public static bool BKCJTxt { get; set; } = false;
        public static bool GolemKratosTxt { get; set; } = false;
        public static bool SubzeroGolemTxt { get; set; } = false;
        public static bool VolcanicNapalmTxt { get; set; } = false;
        public static bool CyberDwayneTxt { get; set; } = false;
        public static bool HornswoggleTxt { get; set; } = false;
        public static bool DemonJinpachiTxt { get; set; } = false;
        public static bool RyuTxt { get; set; } = false;
        public static bool AyaneShunYingTxt { get; set; } = false;
        public static bool MaskedDemonBradTxt { get; set; } = false;
        public static bool KOFJakeTxt { get; set; } = false;
        public static bool PutaTxt { get; set; } = false;
        public static bool ShunYingV2Txt { get; set; } = false;
        public static bool SpiderManTxt { get; set; } = false;
        public static bool SymbioteSpiderTxt { get; set; } = false;
        public static bool HoboBonesTxt { get; set; } = false;
        public static bool NegativeToonYoonTxt { get; set; } = false;
        public static bool SWAG_TyTxt { get; set; } = false;
        public static bool HiroGATTxt { get; set; } = false;
        public static bool KG_WhatsAppTxt { get; set; } = false;
        public static bool RodKlugerTxt { get; set; } = false;
        public static bool TorqueGalsiaTxt { get; set; } = false;
        public static bool RealDealKidTxt { get; set; } = false;
        public static bool BatmanGlenTxt { get; set; } = false;
        public static bool TerminatorMckinzieTxt { get; set; } = false;
        public static bool EvilShunYingTxt { get; set; } = false;
        public static bool OldMasterShinkaiTxt { get; set; } = false;
        public static bool CyberpunkGrimmTxt { get; set; } = false;
        public static bool KazumaKiryuBradTxt { get; set; } = false;
        public static bool CollinHermitSchoolTxt { get; set; } = false;
        public static bool MonsterEnergyGolemTxt { get; set; } = false;
        public static bool BradfromGymTxt { get; set; } = false;
        public static bool CustomGrimmTxt { get; set; } = false;
        public static bool SpecialAgentBradHawkTxt { get; set; } = false;
        public static bool MayorJakeHudsonTxt { get; set; } = false;
        public static bool GangsterAlexTxt { get; set; } = false;
        public static bool GovernmentAgentBradHawkTxt { get; set; } = false;
        public static bool SkeletonBoyTxt { get; set; } = false;
        public static bool HalloweenFKTxt { get; set; } = false;
        public static bool Napumpin99Txt { get; set; } = false;
        public static bool VergilAlexTxt { get; set; } = false;
        public static bool GolemusTxt { get; set; } = false;
        public static bool X2000PopMiguelTxt { get; set; } = false;
        public static bool MartialArtistBordinTxt { get; set; } = false;
        public static bool McPunisherTxt { get; set; } = false;
        public static bool TuxLinTxt { get; set; } = false;
        public static bool CEOLinFongTxt { get; set; } = false;
        public static bool VeraNinjaTxt { get; set; } = false;
        public static bool JohnnyCageLawTxt { get; set; } = false;
        public static bool GolemFanboyTxt { get; set; } = false;
        public static bool EndangeredMasaTxt { get; set; } = false;
        public static bool SantaBonesTxt { get; set; } = false;
        public static bool GoldenGipsyTxt { get; set; } = false;

        public static bool SethSkin2 { get; set; } = false;
        public static bool NasTiiiSkin2 { get; set; } = false;
        public static bool EmCeeSkin2 { get; set; } = false;
        public static bool RamonSkin2 { get; set; } = false;
        public static bool JoseSkin2 { get; set; } = false;
        public static bool ZackSkin2 { get; set; } = false;
        public static bool GraveDiggaSkin2 { get; set; } = false;
        public static bool BoomaSkin2 { get; set; } = false;
        public static bool BustaSkin2 { get; set; } = false;
        public static bool SpiderSkin2 { get; set; } = false;
        public static bool PainKillahSkin2 { get; set; } = false;
        public static bool CooperSkin2 { get; set; } = false;
        public static bool TaylorSkin2 { get; set; } = false;
        public static bool ChrisSkin2 { get; set; } = false;
        public static bool RikiSkin2 { get; set; } = false;
        public static bool RyujiSkin2 { get; set; } = false;
        public static bool YeWeiSkin2 { get; set; } = false;
        public static bool ShaYingSkin2 { get; set; } = false;
        public static bool YanJunSkin2 { get; set; } = false;
        public static bool KellySkin2 { get; set; } = false;
        public static bool PaulSkin2 { get; set; } = false;

        public static bool PepsimanTxt { get; set; } = false;
        public static bool EddyTrainerTxt { get; set; } = false;
        public static bool BrademTxt { get; set; } = false;
        public static bool Paul2040Txt { get; set; } = false;
        public static bool BeachGolemTxt { get; set; } = false;
        public static bool SpaceYakuzaTxt { get; set; } = false;
        public static bool AlmostWhiteMiguelTxt { get; set; } = false;
        public static bool PrinceBordinTxt { get; set; } = false;
        public static bool ClassyShunYingTxt { get; set; } = false;
        public static bool SchoolgirlLilianTxt { get; set; } = false;
        public static bool StreetKellyTxt { get; set; } = false;
        public static bool SeriousVeraTxt { get; set; } = false;
        public static bool CrimsonLinFongTxt { get; set; } = false;
        public static bool EasterBunnyLinFongTxt { get; set; } = false;
        public static bool BlackHawkTxt { get; set; } = false;
        public static bool GoldenDragonLinFongTxt { get; set; } = false;
        public static bool GothicShunYingTxt { get; set; } = false;

        public static bool WeaponsTxt { get; set; } = false;
        public static bool TitleScreenTxt { get; set; } = false;
        public static bool MultyplayerTxt { get; set; } = false;

        public static bool MasterBradMoves { get; set; } = false;
        public static bool GolemBrokenShitMoves { get; set; } = false;
        public static bool BordinAllAroundMoves { get; set; } = false;
        public static bool PaulAshesMoves { get; set; } = false;
        public static bool SakamotoRyomaMoves { get; set; } = false;
        public static bool BradAndOthersParry { get; set; } = false;
        public static bool ShinBordinMoves { get; set; } = false;
        public static bool KOGMoves { get; set; } = false;
        public static bool KingJakeMoves { get; set; } = false;
        public static bool MMAGipsiesMoves { get; set; } = false;
        public static bool RikiDensetsuMoves { get; set; } = false;
        public static bool PhoenixStanceShunYingMoves { get; set; } = false;
        public static bool BrokenDwayneMoves { get; set; } = false;
        public static bool MonsterVeraMoves { get; set; } = false;
        public static bool ThugKellyMoves { get; set; } = false;
        public static bool SwordmasterShunYingAndLilianMoves { get; set; } = false;
        public static bool SwordmasterLinFongMoves { get; set; } = false;


        public static bool StatsChanged { get; set; } = false;


        public static string SettingsPath = @"C:\\AppSettings\\Settings_File";
        public static string folderPath = @"C:\\AppSettings";

        public static bool PageEnterSFX { get; set; } = false;

        public SettingsClass(string connectionString, string missionFolder, string textureFolderBase, string textureFolderDump,
            string _gameFolderPath, bool _missile, bool _modelsSizeStatus, string pnachName,
            bool kG_Tall_Model, bool real_Dwarf_Model, bool golem_Giant_Model, bool gnome_Napalm_Model,
            bool amazon_Shun_Ying, string musicStatus, string bradModelSwap, int editorEffectsIndex,
            double stk1, double grp1, double rga1, double spa1, double wpa1, double tgh1, double hde1, double ube1, double lbe1,
            double stk2, double grp2, double rga2, double spa2, double wpa2, double tgh2, double hde2, double ube2, double lbe2,
            double stk3, double grp3, double rga3, double spa3, double wpa3, double tgh3, double hde3, double ube3, double lbe3,
            double stk4, double grp4, double rga4, double spa4, double wpa4, double tgh4, double hde4, double ube4, double lbe4,
            double stk5, double grp5, double rga5, double spa5, double wpa5, double tgh5, double hde5, double ube5, double lbe5,
            bool warehouseTxt,
            bool golemTuxedoTxt, bool golemShirtlessTxt, bool kGBeat_upTxt,
            bool gD04Txt, bool gD_05Skin, bool kadonashiOGTxt, bool officerNapalm99Txt, bool nightmareTxt, bool suspectTxt, bool shinkai007Txt, bool yanJunDrunkenFistTxt,
            bool boomaSurgeonTxt, bool fashionShunYingTxt, bool collegeBoyBradTxt, bool hellsLegionBordinTxt, bool alternativeParkTxt, bool aristocratChrisTxt,
            bool bouncerFKTxt, bool flamingMiguelTxt, bool geishaLilianTxt, bool grolemTxt, bool koolRamonTxt, bool mountainGrimTxt, bool rejinTxt, bool spyKellyTxt, bool yYCleanClothesTxt,
            bool glenSkin, bool torqueSkin, bool rodSkin, bool sethSkin, bool nasTiiiSkin,
            bool emCeeSkin, bool realDealSkin, bool joseSkin, bool emilioSkin, bool zackSkin,
            bool colinSkin, bool jakeSkin, bool tongYoonSkin, bool bKSkin, bool graveDiggaSkin,
            bool bonesSkin, bool bustaSkin, bool spiderSkin, bool painKillahSkin, bool dwayneSkin,
            bool dR88Skin, bool pT22Skin, bool bainSkin, bool cooperSkin, bool andersonSkin,
            bool taylorSkin, bool alexSkin, bool mcKinzieSkin, bool rikiSkin, bool masaSkin,
            bool hiroSkin, bool ryujiSkin, bool yeWeiSkin, bool shaYingSkin, bool linFongLeeSkin,
            bool veraSkin, bool paulSkin, bool lawSkin,
            bool sH2JamesTxt, bool rebeccaChambersTxt, bool parkDanteTxt, bool bKCJTxt, bool golemKratosTxt, bool subzeroGolemTxt,
            bool volcanicNapalmTxt, bool cyberDwayneTxt, bool hornswoggleTxt, bool demonJinpachiTxt, bool ryuTxt, bool ayaneShunYingTxt,
            bool maskedDemonBradTxt, bool kOFJakeTxt, bool putaTxt, bool shunYingV2Txt, bool spiderManTxt, bool symbioteSpiderTxt, bool hoboBonesTxt,
            bool negativeToonYoonTxt, bool sWAG_TyTxt, bool hiroGATTxt, bool kG_WhatsAppTxt, bool rodKlugerTxt, bool torqueGalsiaTxt,
            bool realDealKidTxt, bool batmanGlenTxt, bool terminatorMckinzieTxt, bool evilShunYingTxt, bool oldMasterShinkaiTxt, bool cyberpunkGrimmTxt,
            bool kazumaKiryuBradTxt, bool collinHermitSchoolTxt, bool monsterEnergyGolemTxt, bool bradfromGymTxt, bool customGrimmTxt,
            bool specialAgentBradHawkTxt, bool mayorJakeHudsonTxt, bool gangsterAlexTxt, bool governmentAgentBradHawkTxt,
            bool skeletonBoyTxt, bool halloweenFKTxt, bool napumpin99Txt, bool vergilAlexTxt, bool golemusTxt,
            bool x2000PopMiguelTxt, bool martialArtistBordinTxt, bool mcPunisherTxt, bool tuxLinTxt,
            bool cEOLinFongTxt, bool veraNinjaTxt, bool johnnyCageLawTxt, bool golemFanboyTxt, bool endangeredMasaTxt,
            bool santaBonesTxt, bool goldenGipsyTxt, bool sethSkin2,
            bool nasTiiiSkin2, bool emCeeSkin2, bool ramonSkin2, bool joseSkin2, bool zackSkin2,
            bool graveDiggaSkin2, bool boomaSkin2, bool bustaSkin2, bool spiderSkin2, bool painKillahSkin2,
            bool cooperSkin2, bool taylorSkin2, bool chrisSkin2, bool rikiSkin2, bool ryujiSkin2,
            bool yeWeiSkin2, bool shaYingSkin2, bool yanJunSkin2, bool kellySkin2, bool paulSkin2, bool pepsimanTxt, bool eddyTrainerTxt,
            bool brademTxt, bool paul2040Txt, bool beachGolemTxt, bool spaceYakuzaTxt, bool almostWhiteMiguelTxt, bool princeBordinTxt,
            bool classyShunYingTxt, bool schoolgirlLilianTxt, bool streetKellyTxt, bool seriousVeraTxt, bool crimsonLinFongTxt, bool easterBunnyLinFongTxt,
            bool blackHawkTxt, bool goldenDragonLinFongTxt, bool gothicShunYingTxt,
            bool weaponsTxt, bool titleScreenTxt, bool multyplayerTxt,
            bool masterBradMoves, bool golemBrokenShitMoves, bool bordinAllAroundMoves, bool paulAshesMoves, bool sakamotoRyomaMoves,
            bool bradAndOthersParry, bool shinBordinMoves, bool kOGMoves, bool kingJakeMoves, bool mMAGipsiesMoves, bool rikiDensetsuMoves,
            bool phoenixStanceShunYingMoves, bool brokenDwayneMoves, bool monsterVeraMoves, bool thugKellyMoves, bool swordmasterShunYingAndLilianMoves,
            bool swordmasterLinFongMoves,
            bool statsChanged, bool pageEnterSFX)
        {
            codeFolderPath = connectionString;
            missionFolderPath = missionFolder;
            textureBaseFolderPath = textureFolderBase;
            textureDumpFolderPath = textureFolderDump;
            gameFolderPath = _gameFolderPath;
            missile = _missile;
            modelsSizeStatus = _modelsSizeStatus;
            PnachName = pnachName;
            KG_Tall_Model = kG_Tall_Model;
            Real_Dwarf_Model = real_Dwarf_Model;
            Golem_Giant_Model = golem_Giant_Model;
            Gnome_Napalm_Model = gnome_Napalm_Model;
            Amazon_Shun_Ying = amazon_Shun_Ying;
            MusicStatus = musicStatus;
            BradModelSwap = bradModelSwap;
            EditorEffectsIndex = editorEffectsIndex;

            STK_1 = stk1;
            GRP_1 = grp1;
            RGA_1 = rga1;
            SPA_1 = spa1;
            WPA_1 = wpa1;
            TGH_1 = tgh1;
            HDE_1 = hde1;
            UBE_1 = ube1;
            LBE_1 = lbe1;
            STK_2 = stk2;
            GRP_2 = grp2;
            RGA_2 = rga2;
            SPA_2 = spa2;
            WPA_2 = wpa2;
            TGH_2 = tgh2;
            HDE_2 = hde2;
            UBE_2 = ube2;
            LBE_2 = lbe2;
            STK_3 = stk3;
            GRP_3 = grp3;
            RGA_3 = rga3;
            SPA_3 = spa3;
            WPA_3 = wpa3;
            TGH_3 = tgh3;
            HDE_3 = hde3;
            UBE_3 = ube3;
            LBE_3 = lbe3;
            STK_4 = stk4;
            GRP_4 = grp4;
            RGA_4 = rga4;
            SPA_4 = spa4;
            WPA_4 = wpa4;
            TGH_4 = tgh4;
            HDE_4 = hde4;
            UBE_4 = ube4;
            LBE_4 = lbe4;
            STK_5 = stk5;
            GRP_5 = grp5;
            RGA_5 = rga5;
            SPA_5 = spa5;
            WPA_5 = wpa5;
            TGH_5 = tgh5;
            HDE_5 = hde5;
            UBE_5 = ube5;
            LBE_5 = lbe5;

            WarehouseTxt = warehouseTxt;
            GolemTuxedoTxt = golemTuxedoTxt;
            GolemShirtlessTxt = golemShirtlessTxt;
            KGBeat_upTxt = kGBeat_upTxt;
            GD_04Txt = gD04Txt;
            GD_05Skin = gD_05Skin;
            KadonashiOGTxt = kadonashiOGTxt;
            OfficerNapalm99Txt = officerNapalm99Txt;
            NightmareTxt = nightmareTxt;
            SuspectTxt = suspectTxt;
            Shinkai007Txt = shinkai007Txt;
            YanJunDrunkenFistTxt = yanJunDrunkenFistTxt;
            BoomaSurgeonTxt = boomaSurgeonTxt;
            FashionShunYingTxt = fashionShunYingTxt;
            CollegeBoyBradTxt = collegeBoyBradTxt;
            HellsLegionBordinTxt = hellsLegionBordinTxt;
            AlternativeParkTxt = alternativeParkTxt;
            AristocratChrisTxt = aristocratChrisTxt;
            BouncerFKTxt = bouncerFKTxt;
            FlamingMiguelTxt = flamingMiguelTxt;
            GeishaLilianTxt = geishaLilianTxt;
            GrolemTxt = grolemTxt;
            KoolRamonTxt = koolRamonTxt;
            MountainGrimTxt = mountainGrimTxt;
            RejinTxt = rejinTxt;
            SpyKellyTxt = spyKellyTxt;
            TYCleanClothesTxt = yYCleanClothesTxt;

            GlenSkin = glenSkin;
            TorqueSkin = torqueSkin;
            RodSkin = rodSkin;
            SethSkin = sethSkin;
            NasTiiiSkin = nasTiiiSkin;
            EmCeeSkin = emCeeSkin;
            RealDealSkin = realDealSkin;
            JoseSkin = joseSkin;
            EmilioSkin = emilioSkin;
            ZackSkin = zackSkin;
            ColinSkin = colinSkin;
            JakeSkin = jakeSkin;
            TongYoonSkin = tongYoonSkin;
            BKSkin = bKSkin;
            GraveDiggaSkin = graveDiggaSkin;
            BonesSkin = bonesSkin;
            BustaSkin = bustaSkin;
            SpiderSkin = spiderSkin;
            PainKillahSkin = painKillahSkin;
            DwayneSkin = dwayneSkin;
            DR88Skin = dR88Skin;
            PT22Skin = pT22Skin;
            BainSkin = bainSkin;
            CooperSkin = cooperSkin;
            AndersonSkin = andersonSkin;
            TaylorSkin = taylorSkin;
            AlexSkin = alexSkin;
            McKinzieSkin = mcKinzieSkin;
            RikiSkin = rikiSkin;
            MasaSkin = masaSkin;
            HiroSkin = hiroSkin;
            RyujiSkin = ryujiSkin;
            YeWeiSkin = yeWeiSkin;
            ShaYingSkin = shaYingSkin;
            LinFongLeeSkin = linFongLeeSkin;
            VeraSkin = veraSkin;
            PaulSkin = paulSkin;
            LawSkin = lawSkin;

            SH2JamesTxt = sH2JamesTxt;
            RebeccaChambersTxt = rebeccaChambersTxt;
            ParkDanteTxt = parkDanteTxt;
            BKCJTxt = bKCJTxt;
            GolemKratosTxt = golemKratosTxt;
            SubzeroGolemTxt = subzeroGolemTxt;
            VolcanicNapalmTxt = volcanicNapalmTxt;
            CyberDwayneTxt = cyberDwayneTxt;
            HornswoggleTxt = hornswoggleTxt;
            DemonJinpachiTxt = demonJinpachiTxt;
            RyuTxt = ryuTxt;
            AyaneShunYingTxt = ayaneShunYingTxt;
            MaskedDemonBradTxt = maskedDemonBradTxt;
            KOFJakeTxt = kOFJakeTxt;
            PutaTxt = putaTxt;
            ShunYingV2Txt = shunYingV2Txt;
            SpiderManTxt = spiderManTxt;
            SymbioteSpiderTxt = symbioteSpiderTxt;
            HoboBonesTxt = hoboBonesTxt;
            NegativeToonYoonTxt = negativeToonYoonTxt;
            SWAG_TyTxt = sWAG_TyTxt;
            HiroGATTxt = hiroGATTxt;
            KG_WhatsAppTxt = kG_WhatsAppTxt;
            RodKlugerTxt = rodKlugerTxt;
            TorqueGalsiaTxt = torqueGalsiaTxt;
            RealDealKidTxt = realDealKidTxt;
            BatmanGlenTxt = batmanGlenTxt;
            TerminatorMckinzieTxt = terminatorMckinzieTxt;
            EvilShunYingTxt = evilShunYingTxt;
            OldMasterShinkaiTxt = oldMasterShinkaiTxt;
            CyberpunkGrimmTxt = cyberpunkGrimmTxt;
            KazumaKiryuBradTxt = kazumaKiryuBradTxt;
            CollinHermitSchoolTxt = collinHermitSchoolTxt;
            MonsterEnergyGolemTxt = monsterEnergyGolemTxt;
            BradfromGymTxt = bradfromGymTxt;
            CustomGrimmTxt = customGrimmTxt;
            SpecialAgentBradHawkTxt = specialAgentBradHawkTxt;
            MayorJakeHudsonTxt = mayorJakeHudsonTxt;
            GangsterAlexTxt = gangsterAlexTxt;
            GovernmentAgentBradHawkTxt = governmentAgentBradHawkTxt;
            SkeletonBoyTxt = skeletonBoyTxt;
            HalloweenFKTxt = halloweenFKTxt;
            Napumpin99Txt = napumpin99Txt;
            VergilAlexTxt = vergilAlexTxt;
            GolemusTxt = golemusTxt;
            X2000PopMiguelTxt = x2000PopMiguelTxt;
            MartialArtistBordinTxt = martialArtistBordinTxt;
            McPunisherTxt = mcPunisherTxt;
            TuxLinTxt = tuxLinTxt;
            CEOLinFongTxt = cEOLinFongTxt;
            VeraNinjaTxt = veraNinjaTxt;
            JohnnyCageLawTxt = johnnyCageLawTxt;
            GolemFanboyTxt = golemFanboyTxt;
            EndangeredMasaTxt = endangeredMasaTxt;
            SantaBonesTxt = santaBonesTxt;
            GoldenGipsyTxt = goldenGipsyTxt;

            SethSkin2 = sethSkin2;
            NasTiiiSkin2 = nasTiiiSkin2;
            EmCeeSkin2 = emCeeSkin2;
            RamonSkin2 = ramonSkin2;
            JoseSkin2 = joseSkin2;
            ZackSkin2 = zackSkin2;
            GraveDiggaSkin2 = graveDiggaSkin2;
            BoomaSkin2 = boomaSkin2;
            BustaSkin2 = bustaSkin2;
            SpiderSkin2 = spiderSkin2;
            PainKillahSkin2 = painKillahSkin2;
            CooperSkin2 = cooperSkin2;
            TaylorSkin2 = taylorSkin2;
            ChrisSkin2 = chrisSkin2;
            RikiSkin2 = rikiSkin2;
            RyujiSkin2 = ryujiSkin2;
            YeWeiSkin2 = yeWeiSkin2;
            ShaYingSkin2 = shaYingSkin2;
            YanJunSkin2 = yanJunSkin2;
            KellySkin2 = kellySkin2;
            PaulSkin2 = paulSkin2;

            PepsimanTxt = pepsimanTxt;
            EddyTrainerTxt = eddyTrainerTxt;
            BrademTxt = brademTxt;
            Paul2040Txt = paul2040Txt;
            BeachGolemTxt = beachGolemTxt;
            SpaceYakuzaTxt = spaceYakuzaTxt;
            AlmostWhiteMiguelTxt = almostWhiteMiguelTxt;
            PrinceBordinTxt = princeBordinTxt;
            ClassyShunYingTxt = classyShunYingTxt;
            SchoolgirlLilianTxt = schoolgirlLilianTxt;
            StreetKellyTxt = streetKellyTxt;
            SeriousVeraTxt = seriousVeraTxt;
            CrimsonLinFongTxt = crimsonLinFongTxt;
            EasterBunnyLinFongTxt = easterBunnyLinFongTxt;
            BlackHawkTxt = blackHawkTxt;
            GoldenDragonLinFongTxt = goldenDragonLinFongTxt;
            GothicShunYingTxt = gothicShunYingTxt;

            WeaponsTxt = weaponsTxt;
            TitleScreenTxt = titleScreenTxt;
            MultyplayerTxt = multyplayerTxt;

            MasterBradMoves = masterBradMoves;
            GolemBrokenShitMoves = golemBrokenShitMoves;
            BordinAllAroundMoves = bordinAllAroundMoves;
            PaulAshesMoves = paulAshesMoves;
            SakamotoRyomaMoves = sakamotoRyomaMoves;
            BradAndOthersParry = bradAndOthersParry;
            ShinBordinMoves = shinBordinMoves;
            KOGMoves = kOGMoves;
            KingJakeMoves = kingJakeMoves;
            MMAGipsiesMoves = mMAGipsiesMoves;
            RikiDensetsuMoves = rikiDensetsuMoves;
            PhoenixStanceShunYingMoves = phoenixStanceShunYingMoves;
            BrokenDwayneMoves = brokenDwayneMoves;
            MonsterVeraMoves = monsterVeraMoves;
            ThugKellyMoves = thugKellyMoves;
            SwordmasterShunYingAndLilianMoves = swordmasterShunYingAndLilianMoves;
            SwordmasterLinFongMoves = swordmasterLinFongMoves;

            StatsChanged = statsChanged;
            PageEnterSFX = pageEnterSFX;
    }

        public static bool isConfigFileLoaded = false;

        public class GetData
        {
            public string codeFolderPath { get; set; } = SettingsClass.codeFolderPath;
            public string missionFolderPath { get; set; } = SettingsClass.missionFolderPath;
            
            public string textureBaseFolderPath { get; set; } = SettingsClass.textureBaseFolderPath;
            public string textureDumpFolderPath { get; set; } = SettingsClass.textureDumpFolderPath;
            public string gameFolderPath { get; set; } = SettingsClass.gameFolderPath;
            
            public bool missile { get; set; } = SettingsClass.missile;
            public bool modelsSizeStatus { get; set; } = SettingsClass.modelsSizeStatus;
            public string PnachName { get; set; } = SettingsClass.PnachName;
            public bool KG_Tall_Model { get; set; } = SettingsClass.KG_Tall_Model;
            public bool Real_Dwarf_Model { get; set; } = SettingsClass.Real_Dwarf_Model;
            public bool Golem_Giant_Model { get; set; } = SettingsClass.Golem_Giant_Model;
            public bool Gnome_Napalm_Model { get; set; } = SettingsClass.Gnome_Napalm_Model;
            public bool Amazon_Shun_Ying { get; set; } = SettingsClass.Amazon_Shun_Ying;
            public string MusicStatus { get; set; } = SettingsClass.MusicStatus;
            public string BradModelSwap { get; set; } = SettingsClass.BradModelSwap;
            public int EditorEffectsIndex { get; set; } = SettingsClass.EditorEffectsIndex;

            public double STK_1 { get; set; } = SettingsClass.STK_1;
            public double GRP_1 { get; set; } = SettingsClass.GRP_1;
            public double RGA_1 { get; set; } = SettingsClass.RGA_1;
            public double SPA_1 { get; set; } = SettingsClass.SPA_1;
            public double WPA_1 { get; set; } = SettingsClass.WPA_1;
            public double TGH_1 { get; set; } = SettingsClass.TGH_1;
            public double HDE_1 { get; set; } = SettingsClass.HDE_1;
            public double UBE_1 { get; set; } = SettingsClass.UBE_1;
            public double LBE_1 { get; set; } = SettingsClass.LBE_1;
            public double STK_2 { get; set; } = SettingsClass.STK_2;
            public double GRP_2 { get; set; } = SettingsClass.GRP_2;
            public double RGA_2 { get; set; } = SettingsClass.RGA_2;
            public double SPA_2 { get; set; } = SettingsClass.SPA_2;
            public double WPA_2 { get; set; } = SettingsClass.WPA_2;
            public double TGH_2 { get; set; } = SettingsClass.TGH_2;
            public double HDE_2 { get; set; } = SettingsClass.HDE_2;
            public double UBE_2 { get; set; } = SettingsClass.UBE_2;
            public double LBE_2 { get; set; } = SettingsClass.LBE_2;
            public double STK_3 { get; set; } = SettingsClass.STK_3;
            public double GRP_3 { get; set; } = SettingsClass.GRP_3;
            public double RGA_3 { get; set; } = SettingsClass.RGA_3;
            public double SPA_3 { get; set; } = SettingsClass.SPA_3;
            public double WPA_3 { get; set; } = SettingsClass.WPA_3;
            public double TGH_3 { get; set; } = SettingsClass.TGH_3;
            public double HDE_3 { get; set; } = SettingsClass.HDE_3;
            public double UBE_3 { get; set; } = SettingsClass.UBE_3;
            public double LBE_3 { get; set; } = SettingsClass.LBE_3;
            public double STK_4 { get; set; } = SettingsClass.STK_4;
            public double GRP_4 { get; set; } = SettingsClass.GRP_4;
            public double RGA_4 { get; set; } = SettingsClass.RGA_4;
            public double SPA_4 { get; set; } = SettingsClass.SPA_4;
            public double WPA_4 { get; set; } = SettingsClass.WPA_4;
            public double TGH_4 { get; set; } = SettingsClass.TGH_4;
            public double HDE_4 { get; set; } = SettingsClass.HDE_4;
            public double UBE_4 { get; set; } = SettingsClass.UBE_4;
            public double LBE_4 { get; set; } = SettingsClass.LBE_4;
            public double STK_5 { get; set; } = SettingsClass.STK_5;
            public double GRP_5 { get; set; } = SettingsClass.GRP_5;
            public double RGA_5 { get; set; } = SettingsClass.RGA_5;
            public double SPA_5 { get; set; } = SettingsClass.SPA_5;
            public double WPA_5 { get; set; } = SettingsClass.WPA_5;
            public double TGH_5 { get; set; } = SettingsClass.TGH_5;
            public double HDE_5 { get; set; } = SettingsClass.HDE_5;
            public double UBE_5 { get; set; } = SettingsClass.UBE_5;
            public double LBE_5 { get; set; } = SettingsClass.LBE_5;

            public bool WarehouseTxt { get; set; } = SettingsClass.WarehouseTxt;

            public bool GolemTuxedoTxt { get; set; } = SettingsClass.GolemTuxedoTxt;
            public bool GolemShirtlessTxt { get; set; } = SettingsClass.GolemShirtlessTxt;
            public bool KGBeat_upTxt { get; set; } = SettingsClass.KGBeat_upTxt;
            public bool GD_04Txt { get; set; } = SettingsClass.GD_04Txt;
            public bool GD_05Skin { get; set; } = SettingsClass.GD_05Skin;
            public bool KadonashiOGTxt { get; set; } = SettingsClass.KadonashiOGTxt;
            public bool OfficerNapalm99Txt { get; set; } = SettingsClass.OfficerNapalm99Txt;
            public bool NightmareTxt { get; set; } = SettingsClass.NightmareTxt;
            public bool SuspectTxt { get; set; } = SettingsClass.SuspectTxt;
            public bool Shinkai007Txt { get; set; } = SettingsClass.Shinkai007Txt;
            public bool YanJunDrunkenFistTxt { get; set; } = SettingsClass.YanJunDrunkenFistTxt;
            public bool BoomaSurgeonTxt { get; set; } = SettingsClass.BoomaSurgeonTxt;
            public bool FashionShunYingTxt { get; set; } = SettingsClass.FashionShunYingTxt;
            public bool CollegeBoyBradTxt { get; set; } = SettingsClass.CollegeBoyBradTxt;
            public bool HellsLegionBordinTxt { get; set; } = SettingsClass.HellsLegionBordinTxt;
            public bool AlternativeParkTxt { get; set; } = SettingsClass.AlternativeParkTxt;
            public bool AristocratChrisTxt { get; set; } = SettingsClass.AristocratChrisTxt;
            public bool BouncerFKTxt { get; set; } = SettingsClass.BouncerFKTxt;
            public bool FlamingMiguelTxt { get; set; } = SettingsClass.FlamingMiguelTxt;
            public bool GeishaLilianTxt { get; set; } = SettingsClass.GeishaLilianTxt;
            public bool GrolemTxt { get; set; } = SettingsClass.GrolemTxt;
            public bool KoolRamonTxt { get; set; } = SettingsClass.KoolRamonTxt;
            public bool MountainGrimTxt { get; set; } = SettingsClass.MountainGrimTxt;
            public bool RejinTxt { get; set; } = SettingsClass.RejinTxt;
            public bool SpyKellyTxt { get; set; } = SettingsClass.SpyKellyTxt;
            public bool TYCleanClothesTxt { get; set; } = SettingsClass.TYCleanClothesTxt;

            public bool GlenSkin { get; set; } = SettingsClass.GlenSkin;
            public bool TorqueSkin { get; set; } = SettingsClass.TorqueSkin;
            public bool RodSkin { get; set; } = SettingsClass.RodSkin;
            public bool SethSkin { get; set; } = SettingsClass.SethSkin;
            public bool NasTiiiSkin { get; set; } = SettingsClass.NasTiiiSkin;
            public bool EmCeeSkin { get; set; } = SettingsClass.EmCeeSkin;
            public bool RealDealSkin { get; set; } = SettingsClass.RealDealSkin;
            public bool JoseSkin { get; set; } = SettingsClass.JoseSkin;
            public bool EmilioSkin { get; set; } = SettingsClass.EmilioSkin;
            public bool ZackSkin { get; set; } = SettingsClass.ZackSkin;
            public bool ColinSkin { get; set; } = SettingsClass.ColinSkin;
            public bool JakeSkin { get; set; } = SettingsClass.JakeSkin;
            public bool TongYoonSkin { get; set; } = SettingsClass.TongYoonSkin;
            public bool BKSkin { get; set; } = SettingsClass.BKSkin;
            public bool GraveDiggaSkin { get; set; } = SettingsClass.GraveDiggaSkin;
            public bool BonesSkin { get; set; } = SettingsClass.BonesSkin;
            public bool BustaSkin { get; set; } = SettingsClass.BustaSkin;
            public bool SpiderSkin { get; set; } = SettingsClass.SpiderSkin;
            public bool PainKillahSkin { get; set; } = SettingsClass.PainKillahSkin;
            public bool DwayneSkin { get; set; } = SettingsClass.DwayneSkin;
            public bool DR88Skin { get; set; } = SettingsClass.DR88Skin;
            public bool PT22Skin { get; set; } = SettingsClass.PT22Skin;
            public bool BainSkin { get; set; } = SettingsClass.BainSkin;
            public bool CooperSkin { get; set; } = SettingsClass.CooperSkin;
            public bool AndersonSkin { get; set; } = SettingsClass.AndersonSkin;
            public bool TaylorSkin { get; set; } = SettingsClass.TaylorSkin;
            public bool AlexSkin { get; set; } = SettingsClass.AlexSkin;
            public bool McKinzieSkin { get; set; } = SettingsClass.McKinzieSkin;
            public bool RikiSkin { get; set; } = SettingsClass.RikiSkin;
            public bool MasaSkin { get; set; } = SettingsClass.MasaSkin;
            public bool HiroSkin { get; set; } = SettingsClass.HiroSkin;
            public bool RyujiSkin { get; set; } = SettingsClass.RyujiSkin;
            public bool YeWeiSkin { get; set; } = SettingsClass.YeWeiSkin;
            public bool ShaYingSkin { get; set; } = SettingsClass.ShaYingSkin;
            public bool LinFongLeeSkin { get; set; } = SettingsClass.LinFongLeeSkin;
            public bool VeraSkin { get; set; } = SettingsClass.VeraSkin;
            public bool PaulSkin { get; set; } = SettingsClass.PaulSkin;
            public bool LawSkin { get; set; } = SettingsClass.LawSkin;

            public bool SH2JamesTxt { get; set; } = SettingsClass.SH2JamesTxt;
            public bool RebeccaChambersTxt { get; set; } = SettingsClass.RebeccaChambersTxt;
            public bool ParkDanteTxt { get; set; } = SettingsClass.RebeccaChambersTxt;
            public bool BKCJTxt { get; set; } = SettingsClass.BKCJTxt;
            public bool GolemKratosTxt { get; set; } = SettingsClass.GolemKratosTxt;
            public bool SubzeroGolemTxt { get; set; } = SettingsClass.SubzeroGolemTxt;
            public bool VolcanicNapalmTxt { get; set; } = SettingsClass.VolcanicNapalmTxt;
            public bool CyberDwayneTxt { get; set; } = SettingsClass.CyberDwayneTxt;
            public bool HornswoggleTxt { get; set; } = SettingsClass.HornswoggleTxt;
            public bool DemonJinpachiTxt { get; set; } = SettingsClass.DemonJinpachiTxt;
            public bool RyuTxt { get; set; } = SettingsClass.RyuTxt;
            public bool AyaneShunYingTxt { get; set; } = SettingsClass.AyaneShunYingTxt;
            public bool MaskedDemonBradTxt { get; set; } = SettingsClass.MaskedDemonBradTxt;
            public bool KOFJakeTxt { get; set; } = SettingsClass.KOFJakeTxt;
            public bool PutaTxt { get; set; } = SettingsClass.KOFJakeTxt;
            public bool ShunYingV2Txt { get; set; } = SettingsClass.ShunYingV2Txt;
            public bool SpiderManTxt { get; set; } = SettingsClass.SpiderManTxt;
            public bool SymbioteSpiderTxt { get; set; } = SettingsClass.SymbioteSpiderTxt;
            public bool HoboBonesTxt { get; set; } = SettingsClass.HoboBonesTxt;
            public bool NegativeToonYoonTxt { get; set; } = SettingsClass.HoboBonesTxt;
            public bool SWAG_TyTxt { get; set; } = SettingsClass.HoboBonesTxt;
            public bool HiroGATTxt { get; set; } = SettingsClass.HoboBonesTxt;
            public bool KG_WhatsAppTxt { get; set; } = SettingsClass.HoboBonesTxt;
            public bool RodKlugerTxt { get; set; } = SettingsClass.HoboBonesTxt;
            public bool TorqueGalsiaTxt { get; set; } = SettingsClass.HoboBonesTxt;
            public bool RealDealKidTxt { get; set; } = SettingsClass.RealDealKidTxt;
            public bool BatmanGlenTxt { get; set; } = SettingsClass.BatmanGlenTxt;
            public bool TerminatorMckinzieTxt { get; set; } = SettingsClass.TerminatorMckinzieTxt;
            public bool EvilShunYingTxt { get; set; } = SettingsClass.EvilShunYingTxt;
            public bool OldMasterShinkaiTxt { get; set; } = SettingsClass.OldMasterShinkaiTxt;
            public bool CyberpunkGrimmTxt { get; set; } = SettingsClass.CyberpunkGrimmTxt;
            public bool KazumaKiryuBradTxt { get; set; } = SettingsClass.KazumaKiryuBradTxt;
            public bool CollinHermitSchoolTxt { get; set; } = SettingsClass.CollinHermitSchoolTxt;
            public bool MonsterEnergyGolemTxt { get; set; } = SettingsClass.MonsterEnergyGolemTxt;
            public bool BradfromGymTxt { get; set; } = SettingsClass.BradfromGymTxt;
            public bool CustomGrimmTxt { get; set; } = SettingsClass.CustomGrimmTxt;
            public bool SpecialAgentBradHawkTxt { get; set; } = SettingsClass.SpecialAgentBradHawkTxt;
            public bool MayorJakeHudsonTxt { get; set; } = SettingsClass.MayorJakeHudsonTxt;
            public bool GangsterAlexTxt { get; set; } = SettingsClass.GangsterAlexTxt;
            public bool GovernmentAgentBradHawkTxt { get; set; } = SettingsClass.GangsterAlexTxt;
            public bool SkeletonBoyTxt { get; set; } = SettingsClass.GangsterAlexTxt;
            public bool HalloweenFKTxt { get; set; } = SettingsClass.GangsterAlexTxt;
            public bool Napumpin99Txt { get; set; } = SettingsClass.GangsterAlexTxt;
            public bool VergilAlexTxt { get; set; } = SettingsClass.VergilAlexTxt;
            public bool GolemusTxt { get; set; } = SettingsClass.GolemusTxt;
            public bool X2000PopMiguelTxt { get; set; } = SettingsClass.X2000PopMiguelTxt;
            public bool MartialArtistBordinTxt { get; set; } = SettingsClass.MartialArtistBordinTxt;
            public bool McPunisherTxt { get; set; } = SettingsClass.McPunisherTxt;
            public bool TuxLinTxt { get; set; } = SettingsClass.TuxLinTxt;
            public bool CEOLinFongTxt { get; set; } = SettingsClass.CEOLinFongTxt;
            public bool VeraNinjaTxt { get; set; } = SettingsClass.VeraNinjaTxt;
            public bool JohnnyCageLawTxt { get; set; } = SettingsClass.JohnnyCageLawTxt;
            public bool GolemFanboyTxt { get; set; } = SettingsClass.GolemFanboyTxt;
            public bool EndangeredMasaTxt { get; set; } = SettingsClass.EndangeredMasaTxt;
            public bool SantaBonesTxt { get; set; } = SettingsClass.SantaBonesTxt;
            public bool GoldenGipsyTxt { get; set; } = SettingsClass.GoldenGipsyTxt;
            public bool SethSkin2 { get; set; } = SettingsClass.SethSkin2;
            public bool NasTiiiSkin2 { get; set; } = SettingsClass.NasTiiiSkin2;
            public bool EmCeeSkin2 { get; set; } = SettingsClass.EmCeeSkin2;
            public bool RamonSkin2 { get; set; } = SettingsClass.RamonSkin2;
            public bool JoseSkin2 { get; set; } = SettingsClass.JoseSkin2;
            public bool ZackSkin2 { get; set; } = SettingsClass.ZackSkin2;
            public bool GraveDiggaSkin2 { get; set; } = SettingsClass.GraveDiggaSkin2;
            public bool BoomaSkin2 { get; set; } = SettingsClass.BoomaSkin2;
            public bool BustaSkin2 { get; set; } = SettingsClass.BustaSkin2;
            public bool SpiderSkin2 { get; set; } = SettingsClass.SpiderSkin2;
            public bool PainKillahSkin2 { get; set; } = SettingsClass.PainKillahSkin2;
            public bool CooperSkin2 { get; set; } = SettingsClass.CooperSkin2;
            public bool TaylorSkin2 { get; set; } = SettingsClass.TaylorSkin2;
            public bool ChrisSkin2 { get; set; } = SettingsClass.ChrisSkin2;
            public bool RikiSkin2 { get; set; } = SettingsClass.RikiSkin2;
            public bool RyujiSkin2 { get; set; } = SettingsClass.RyujiSkin2;
            public bool YeWeiSkin2 { get; set; } = SettingsClass.YeWeiSkin2;
            public bool ShaYingSkin2 { get; set; } = SettingsClass.ShaYingSkin2;
            public bool YanJunSkin2 { get; set; } = SettingsClass.YanJunSkin2;
            public bool KellySkin2 { get; set; } = SettingsClass.KellySkin2;
            public bool PaulSkin2 { get; set; } = SettingsClass.PaulSkin2;

            public bool PepsimanTxt { get; set; } = SettingsClass.PepsimanTxt;
            public bool EddyTrainerTxt { get; set; } = SettingsClass.EddyTrainerTxt;
            public bool BrademTxt { get; set; } = SettingsClass.BrademTxt;
            public bool Paul2040Txt { get; set; } = SettingsClass.Paul2040Txt;
            public bool BeachGolemTxt { get; set; } = SettingsClass.BeachGolemTxt;
            public bool SpaceYakuzaTxt { get; set; } = SettingsClass.SpaceYakuzaTxt;
            public bool AlmostWhiteMiguelTxt { get; set; } = SettingsClass.AlmostWhiteMiguelTxt;
            public bool PrinceBordinTxt { get; set; } = SettingsClass.PrinceBordinTxt;
            public bool ClassyShunYingTxt { get; set; } = SettingsClass.ClassyShunYingTxt;
            public bool SchoolgirlLilianTxt { get; set; } = SettingsClass.SchoolgirlLilianTxt;
            public bool StreetKellyTxt { get; set; } = SettingsClass.StreetKellyTxt;
            public bool SeriousVeraTxt { get; set; } = SettingsClass.SeriousVeraTxt;
            public bool CrimsonLinFongTxt { get; set; } = SettingsClass.CrimsonLinFongTxt;
            public bool EasterBunnyLinFongTxt { get; set; } = SettingsClass.EasterBunnyLinFongTxt;
            public bool BlackHawkTxt { get; set; } = SettingsClass.BlackHawkTxt;
            public bool GoldenDragonLinFongTxt { get; set; } = SettingsClass.GoldenDragonLinFongTxt;
            public bool GothicShunYingTxt { get; set; } = SettingsClass.GothicShunYingTxt;


            public bool WeaponsTxt { get; set; } = SettingsClass.WeaponsTxt;
            public bool TitleScreenTxt { get; set; } = SettingsClass.TitleScreenTxt;
            public bool MultyplayerTxt { get; set; } = SettingsClass.MultyplayerTxt;
            
            public bool MasterBradMoves { get; set;} = SettingsClass.MasterBradMoves;
            public bool GolemBrokenShitMoves { get; set; } = SettingsClass.GolemBrokenShitMoves;
            public bool BordinAllAroundMoves { get; set; } = SettingsClass.BordinAllAroundMoves;
            public bool PaulAshesMoves { get; set; } = SettingsClass.PaulAshesMoves;
            public bool BradAndOthersParry { get; set; } = SettingsClass.BradAndOthersParry;
            public bool SakamotoRyomaMoves { get; set; } = SettingsClass.SakamotoRyomaMoves;
            public bool ShinBordinMoves { get; set; } = SettingsClass.ShinBordinMoves;
            public bool KOGMoves { get; set; } = SettingsClass.KOGMoves;
            public bool KingJakeMoves { get; set; } = SettingsClass.KingJakeMoves;
            public bool MMAGipsiesMoves { get; set; } = SettingsClass.MMAGipsiesMoves;
            public bool RikiDensetsuMoves { get; set; } = SettingsClass.RikiDensetsuMoves;
            public bool PhoenixStanceShunYingMoves { get; set; } = SettingsClass.PhoenixStanceShunYingMoves;
            public bool BrokenDwayneMoves { get; set; } = SettingsClass.BrokenDwayneMoves;
            public bool MonsterVeraMoves { get; set; } = SettingsClass.MonsterVeraMoves;
            public bool ThugKellyMoves { get; set; } = SettingsClass.ThugKellyMoves;
            public bool SwordmasterShunYingAndLilianMoves { get; set; } = SettingsClass.SwordmasterShunYingAndLilianMoves;
            public bool SwordmasterLinFongMoves { get; set; } = SettingsClass.SwordmasterLinFongMoves;

            public bool StatsChanged { get; set; } = SettingsClass.StatsChanged;
            public bool PageEnterSFX { get; set; } = SettingsClass.PageEnterSFX;
        }

        public static GetData Settings = new GetData();

        public static void LoadData()
        {
            if (File.Exists(SettingsPath))
            {
                string JsonString = File.ReadAllText(SettingsPath);
                Settings = JsonConvert.DeserializeObject<GetData>(JsonString);
                codeFolderPath = Settings.codeFolderPath;
                missionFolderPath = Settings.missionFolderPath;
                textureBaseFolderPath = Settings.textureBaseFolderPath;
                textureDumpFolderPath = Settings.textureDumpFolderPath;
                gameFolderPath  = Settings.gameFolderPath;
                missile = Settings.missile;
                modelsSizeStatus = Settings.modelsSizeStatus;
                PnachName = Settings.PnachName;
                KG_Tall_Model = Settings.KG_Tall_Model;
                Real_Dwarf_Model = Settings.Real_Dwarf_Model;
                Golem_Giant_Model = Settings.Golem_Giant_Model;
                Gnome_Napalm_Model = Settings.Gnome_Napalm_Model;
                Amazon_Shun_Ying = Settings.Amazon_Shun_Ying;
                MusicStatus = Settings.MusicStatus;
                BradModelSwap = Settings.BradModelSwap;
                EditorEffectsIndex = Settings.EditorEffectsIndex;

                STK_1 = Settings.STK_1;
                GRP_1 = Settings.GRP_1;
                RGA_1 = Settings.RGA_1;
                SPA_1 = Settings.SPA_1;
                WPA_1 = Settings.WPA_1;
                TGH_1 = Settings.TGH_1;
                HDE_1 = Settings.HDE_1;
                UBE_1 = Settings.UBE_1;
                LBE_1 = Settings.LBE_1;
                STK_2 = Settings.STK_2;
                GRP_2 = Settings.GRP_2;
                RGA_2 = Settings.RGA_2;
                SPA_2 = Settings.SPA_2;
                WPA_2 = Settings.WPA_2;
                TGH_2 = Settings.TGH_2;
                HDE_2 = Settings.HDE_2;
                UBE_2 = Settings.UBE_2;
                LBE_2 = Settings.LBE_2;
                STK_3 = Settings.STK_3;
                GRP_3 = Settings.GRP_3;
                RGA_3 = Settings.RGA_3;
                SPA_3 = Settings.SPA_3;
                WPA_3 = Settings.WPA_3;
                TGH_3 = Settings.TGH_3;
                HDE_3 = Settings.HDE_3;
                UBE_3 = Settings.UBE_3;
                LBE_3 = Settings.LBE_3;
                STK_4 = Settings.STK_4;
                GRP_4 = Settings.GRP_4;
                RGA_4 = Settings.RGA_4;
                SPA_4 = Settings.SPA_4;
                WPA_4 = Settings.WPA_4;
                TGH_4 = Settings.TGH_4;
                HDE_4 = Settings.HDE_4;
                UBE_4 = Settings.UBE_4;
                LBE_4 = Settings.LBE_4;
                STK_5 = Settings.STK_5;
                GRP_5 = Settings.GRP_5;
                RGA_5 = Settings.RGA_5;
                SPA_5 = Settings.SPA_5;
                WPA_5 = Settings.WPA_5;
                TGH_5 = Settings.TGH_5;
                HDE_5 = Settings.HDE_5;
                UBE_5 = Settings.UBE_5;
                LBE_5 = Settings.LBE_5;

                WarehouseTxt = Settings.WarehouseTxt;
                GolemTuxedoTxt = Settings.GolemTuxedoTxt;
                GolemShirtlessTxt = Settings.GolemShirtlessTxt;
                KGBeat_upTxt = Settings.KGBeat_upTxt;
                GD_04Txt = Settings.GD_04Txt;
                GD_05Skin = Settings.GD_05Skin;
                KadonashiOGTxt = Settings.KadonashiOGTxt;
                OfficerNapalm99Txt = Settings.OfficerNapalm99Txt;
                NightmareTxt = Settings.NightmareTxt;
                SuspectTxt = Settings.SuspectTxt;
                Shinkai007Txt = Settings.Shinkai007Txt;
                YanJunDrunkenFistTxt = Settings.YanJunDrunkenFistTxt;
                BoomaSurgeonTxt = Settings.BoomaSurgeonTxt;
                FashionShunYingTxt = Settings.FashionShunYingTxt;
                CollegeBoyBradTxt = Settings.CollegeBoyBradTxt;
                HellsLegionBordinTxt = Settings.HellsLegionBordinTxt;
                AlternativeParkTxt = Settings.AlternativeParkTxt;
                AristocratChrisTxt = Settings.AristocratChrisTxt;
                BouncerFKTxt = Settings.BouncerFKTxt;
                FlamingMiguelTxt = Settings.FlamingMiguelTxt;
                GeishaLilianTxt = Settings.GeishaLilianTxt;
                GrolemTxt = Settings.GrolemTxt;
                KoolRamonTxt = Settings.KoolRamonTxt;
                MountainGrimTxt = Settings.MountainGrimTxt;
                RejinTxt = Settings.RejinTxt;
                SpyKellyTxt = Settings.SpyKellyTxt;
                TYCleanClothesTxt = Settings.TYCleanClothesTxt;

                GlenSkin = Settings.GlenSkin;
                TorqueSkin = Settings.TorqueSkin;
                RodSkin = Settings.RodSkin;
                SethSkin = Settings.SethSkin;
                NasTiiiSkin = Settings.NasTiiiSkin;
                EmCeeSkin = Settings.EmCeeSkin;
                RealDealSkin = Settings.RealDealSkin;
                JoseSkin = Settings.JoseSkin;
                EmilioSkin = Settings.EmilioSkin;
                ZackSkin = Settings.ZackSkin;
                ColinSkin = Settings.ColinSkin;
                JakeSkin = Settings.JakeSkin;
                TongYoonSkin = Settings.TongYoonSkin;
                BKSkin = Settings.BKSkin;
                GraveDiggaSkin = Settings.GraveDiggaSkin;
                BonesSkin = Settings.BonesSkin;
                BustaSkin = Settings.BustaSkin;
                SpiderSkin = Settings.SpiderSkin;
                PainKillahSkin = Settings.PainKillahSkin;
                DwayneSkin = Settings.DwayneSkin;
                DR88Skin = Settings.DR88Skin;
                PT22Skin = Settings.PT22Skin;
                BainSkin = Settings.BainSkin;
                CooperSkin = Settings.CooperSkin;
                AndersonSkin = Settings.AndersonSkin;
                TaylorSkin = Settings.TaylorSkin;
                AlexSkin = Settings.AlexSkin;
                McKinzieSkin = Settings.McKinzieSkin;
                RikiSkin = Settings.RikiSkin;
                MasaSkin = Settings.MasaSkin;
                HiroSkin = Settings.HiroSkin;
                RyujiSkin = Settings.RyujiSkin;
                YeWeiSkin = Settings.YeWeiSkin;
                ShaYingSkin = Settings.ShaYingSkin;
                LinFongLeeSkin = Settings.LinFongLeeSkin;
                VeraSkin = Settings.VeraSkin;
                PaulSkin = Settings.PaulSkin;
                LawSkin = Settings.LawSkin;

                SH2JamesTxt = Settings.SH2JamesTxt;
                RebeccaChambersTxt = Settings.RebeccaChambersTxt;
                ParkDanteTxt = Settings.ParkDanteTxt;
                BKCJTxt = Settings.BKCJTxt;
                GolemKratosTxt = Settings.GolemKratosTxt;
                SubzeroGolemTxt = Settings.SubzeroGolemTxt;
                VolcanicNapalmTxt = Settings.VolcanicNapalmTxt;
                CyberDwayneTxt = Settings.CyberDwayneTxt;
                HornswoggleTxt = Settings.HornswoggleTxt;
                DemonJinpachiTxt = Settings.DemonJinpachiTxt;
                RyuTxt = Settings.RyuTxt;
                AyaneShunYingTxt = Settings.AyaneShunYingTxt;
                MaskedDemonBradTxt = Settings.MaskedDemonBradTxt;
                KOFJakeTxt = Settings.KOFJakeTxt;
                PutaTxt = Settings.PutaTxt;
                ShunYingV2Txt = Settings.ShunYingV2Txt;
                SpiderManTxt = Settings.SpiderManTxt;
                SymbioteSpiderTxt = Settings.SymbioteSpiderTxt;
                HoboBonesTxt = Settings.HoboBonesTxt;
                NegativeToonYoonTxt = Settings.NegativeToonYoonTxt;
                SWAG_TyTxt = Settings.SWAG_TyTxt;
                HiroGATTxt = Settings.HiroGATTxt;
                KG_WhatsAppTxt = Settings.KG_WhatsAppTxt;
                RodKlugerTxt = Settings.RodKlugerTxt;
                TorqueGalsiaTxt = Settings.TorqueGalsiaTxt;
                RealDealKidTxt = Settings.RealDealKidTxt;
                BatmanGlenTxt = Settings.BatmanGlenTxt;
                TerminatorMckinzieTxt = Settings.TerminatorMckinzieTxt;
                EvilShunYingTxt = Settings.EvilShunYingTxt;
                OldMasterShinkaiTxt = Settings.OldMasterShinkaiTxt;
                CyberpunkGrimmTxt = Settings.CyberpunkGrimmTxt;
                KazumaKiryuBradTxt = Settings.KazumaKiryuBradTxt;
                CollinHermitSchoolTxt = Settings.CollinHermitSchoolTxt;
                MonsterEnergyGolemTxt = Settings.MonsterEnergyGolemTxt;
                BradfromGymTxt = Settings.BradfromGymTxt;
                CustomGrimmTxt = Settings.CustomGrimmTxt;
                SpecialAgentBradHawkTxt = Settings.SpecialAgentBradHawkTxt;
                MayorJakeHudsonTxt = Settings.MayorJakeHudsonTxt;
                GangsterAlexTxt = Settings.GangsterAlexTxt;
                GovernmentAgentBradHawkTxt = Settings.GovernmentAgentBradHawkTxt;
                SkeletonBoyTxt = Settings.SkeletonBoyTxt;
                HalloweenFKTxt = Settings.HalloweenFKTxt;
                Napumpin99Txt = Settings.Napumpin99Txt;
                VergilAlexTxt = Settings.VergilAlexTxt;
                GolemusTxt = Settings.GolemusTxt;
                X2000PopMiguelTxt = Settings.X2000PopMiguelTxt;
                MartialArtistBordinTxt = Settings.MartialArtistBordinTxt;
                McPunisherTxt = Settings.McPunisherTxt;
                TuxLinTxt = Settings.TuxLinTxt;
                CEOLinFongTxt = Settings.CEOLinFongTxt;
                VeraNinjaTxt = Settings.VeraNinjaTxt;
                JohnnyCageLawTxt = Settings.JohnnyCageLawTxt;
                GolemFanboyTxt = Settings.GolemFanboyTxt;
                EndangeredMasaTxt = Settings.EndangeredMasaTxt;
                SantaBonesTxt = Settings.SantaBonesTxt;
                GoldenGipsyTxt = Settings.GoldenGipsyTxt;
                SethSkin2 = Settings.SethSkin2;
                EmCeeSkin2 = Settings.EmCeeSkin2;
                NasTiiiSkin2 = Settings.NasTiiiSkin2;
                RamonSkin2 = Settings.RamonSkin2;
                JoseSkin2 = Settings.JoseSkin2;
                ZackSkin2 = Settings.ZackSkin2;
                GraveDiggaSkin2 = Settings.GraveDiggaSkin2;
                BoomaSkin2 = Settings.BoomaSkin2;
                BustaSkin2 = Settings.BustaSkin2;
                SpiderSkin2 = Settings.SpiderSkin2;
                PainKillahSkin2 = Settings.PainKillahSkin2;
                CooperSkin2 = Settings.CooperSkin2;
                TaylorSkin2 = Settings.TaylorSkin2;
                ChrisSkin2 = Settings.ChrisSkin2;
                RikiSkin2 = Settings.RikiSkin2;
                RyujiSkin2 = Settings.RyujiSkin2;
                YeWeiSkin2 = Settings.YeWeiSkin2;
                ShaYingSkin2 = Settings.ShaYingSkin2;
                YanJunSkin2 = Settings.YanJunSkin2;
                KellySkin2 = Settings.KellySkin2;
                PaulSkin2 = Settings.PaulSkin2;

                PepsimanTxt = Settings.PepsimanTxt;
                EddyTrainerTxt = Settings.EddyTrainerTxt;
                BrademTxt = Settings.BrademTxt;
                Paul2040Txt = Settings.Paul2040Txt;
                BeachGolemTxt = Settings.BeachGolemTxt;
                SpaceYakuzaTxt = Settings.SpaceYakuzaTxt;
                AlmostWhiteMiguelTxt = Settings.AlmostWhiteMiguelTxt;
                PrinceBordinTxt = Settings.PrinceBordinTxt;
                ClassyShunYingTxt = Settings.ClassyShunYingTxt;
                SchoolgirlLilianTxt = Settings.SchoolgirlLilianTxt;
                StreetKellyTxt = Settings.StreetKellyTxt;
                SeriousVeraTxt = Settings.SeriousVeraTxt;
                CrimsonLinFongTxt = Settings.CrimsonLinFongTxt;
                EasterBunnyLinFongTxt = Settings.EasterBunnyLinFongTxt;
                BlackHawkTxt = Settings.BlackHawkTxt;
                GoldenDragonLinFongTxt = Settings.GoldenDragonLinFongTxt;
                GothicShunYingTxt = Settings.GothicShunYingTxt;

                WeaponsTxt = Settings.WeaponsTxt;
                TitleScreenTxt = Settings.TitleScreenTxt;
                MultyplayerTxt = Settings.MultyplayerTxt;

                codeFilePath = codeFolderPath + PnachName;

                MasterBradMoves = Settings.MasterBradMoves;
                GolemBrokenShitMoves = Settings.GolemBrokenShitMoves;
                BordinAllAroundMoves = Settings.BordinAllAroundMoves;
                PaulAshesMoves = Settings.PaulAshesMoves;
                BradAndOthersParry = Settings.BradAndOthersParry;
                SakamotoRyomaMoves = Settings.SakamotoRyomaMoves;
                ShinBordinMoves = Settings.ShinBordinMoves;
                KOGMoves = Settings.KOGMoves;
                KingJakeMoves = Settings.KingJakeMoves;
                MMAGipsiesMoves = Settings.MMAGipsiesMoves;
                RikiDensetsuMoves = Settings.RikiDensetsuMoves;
                PhoenixStanceShunYingMoves = Settings.PhoenixStanceShunYingMoves;
                BrokenDwayneMoves = Settings.BrokenDwayneMoves;
                MonsterVeraMoves = Settings.MonsterVeraMoves;
                ThugKellyMoves = Settings.ThugKellyMoves;
                SwordmasterShunYingAndLilianMoves = Settings.SwordmasterShunYingAndLilianMoves;
                SwordmasterLinFongMoves = Settings.SwordmasterLinFongMoves;

                StatsChanged = Settings.StatsChanged;
                PageEnterSFX = Settings.PageEnterSFX;
            }
            else
            {
                SaveData();
            }
        }

        public static void SaveData()
        {
            Settings.codeFolderPath = codeFolderPath;
            Settings.missionFolderPath = missionFolderPath;
            Settings.textureBaseFolderPath = textureBaseFolderPath;
            Settings.textureDumpFolderPath = textureDumpFolderPath;
            Settings.gameFolderPath = gameFolderPath;
            Settings.missile = missile;
            Settings.PnachName = PnachName;
            Settings.modelsSizeStatus = modelsSizeStatus;
            Settings.KG_Tall_Model = KG_Tall_Model;
            Settings.Real_Dwarf_Model = Real_Dwarf_Model;
            Settings.Golem_Giant_Model = Golem_Giant_Model;
            Settings.Gnome_Napalm_Model = Gnome_Napalm_Model;
            Settings.Amazon_Shun_Ying = Amazon_Shun_Ying;
            Settings.MusicStatus = MusicStatus;
            Settings.BradModelSwap = BradModelSwap;
            Settings.EditorEffectsIndex = EditorEffectsIndex;

            Settings.STK_1 = STK_1;
            Settings.GRP_1 = GRP_1;
            Settings.RGA_1 = RGA_1;
            Settings.SPA_1 = SPA_1;
            Settings.WPA_1 = WPA_1;
            Settings.TGH_1 = TGH_1;
            Settings.HDE_1 = HDE_1;
            Settings.UBE_1 = UBE_1;
            Settings.LBE_1 = LBE_1;
            Settings.STK_2 = STK_2;
            Settings.GRP_2 = GRP_2;
            Settings.RGA_2 = RGA_2;
            Settings.SPA_2 = SPA_2;
            Settings.WPA_2 = WPA_2;
            Settings.TGH_2 = TGH_2;
            Settings.HDE_2 = HDE_2;
            Settings.UBE_2 = UBE_2;
            Settings.LBE_2 = LBE_2;
            Settings.STK_3 = STK_3;
            Settings.GRP_3 = GRP_3;
            Settings.RGA_3 = RGA_3;
            Settings.SPA_3 = SPA_3;
            Settings.WPA_3 = WPA_3;
            Settings.TGH_3 = TGH_3;
            Settings.HDE_3 = HDE_3;
            Settings.UBE_3 = UBE_3;
            Settings.LBE_3 = LBE_3;
            Settings.STK_4 = STK_4;
            Settings.GRP_4 = GRP_4;
            Settings.RGA_4 = RGA_4;
            Settings.SPA_4 = SPA_4;
            Settings.WPA_4 = WPA_4;
            Settings.TGH_4 = TGH_4;
            Settings.HDE_4 = HDE_4;
            Settings.UBE_4 = UBE_4;
            Settings.LBE_4 = LBE_4;
            Settings.STK_5 = STK_5;
            Settings.GRP_5 = GRP_5;
            Settings.RGA_5 = RGA_5;
            Settings.SPA_5 = SPA_5;
            Settings.WPA_5 = WPA_5;
            Settings.TGH_5 = TGH_5;
            Settings.HDE_5 = HDE_5;
            Settings.UBE_5 = UBE_5;
            Settings.LBE_5 = LBE_5;

            Settings.WarehouseTxt = WarehouseTxt;
            Settings.GolemTuxedoTxt = GolemTuxedoTxt; 
            Settings.GolemShirtlessTxt = GolemShirtlessTxt;
            Settings.KGBeat_upTxt = KGBeat_upTxt;
            Settings.GD_04Txt = GD_04Txt;
            Settings.GD_05Skin = GD_05Skin;
            Settings.KadonashiOGTxt = KadonashiOGTxt;
            Settings.OfficerNapalm99Txt = OfficerNapalm99Txt;
            Settings.NightmareTxt = NightmareTxt;
            Settings.SuspectTxt = SuspectTxt;
            Settings.Shinkai007Txt = Shinkai007Txt;
            Settings.YanJunDrunkenFistTxt = YanJunDrunkenFistTxt;
            Settings.BoomaSurgeonTxt = BoomaSurgeonTxt;
            Settings.FashionShunYingTxt = FashionShunYingTxt;
            Settings.CollegeBoyBradTxt = CollegeBoyBradTxt;
            Settings.HellsLegionBordinTxt = HellsLegionBordinTxt;
            Settings.AlternativeParkTxt = AlternativeParkTxt;
            Settings.AristocratChrisTxt = AristocratChrisTxt;
            Settings.BouncerFKTxt = BouncerFKTxt;
            Settings.FlamingMiguelTxt = FlamingMiguelTxt;
            Settings.GeishaLilianTxt = GeishaLilianTxt;
            Settings.GrolemTxt = GrolemTxt;
            Settings.KoolRamonTxt = KoolRamonTxt;
            Settings.MountainGrimTxt = MountainGrimTxt;
            Settings.RejinTxt = RejinTxt;
            Settings.SpyKellyTxt = SpyKellyTxt;
            Settings.TYCleanClothesTxt = TYCleanClothesTxt;

            Settings.GlenSkin = GlenSkin;
            Settings.TorqueSkin = TorqueSkin;
            Settings.RodSkin = RodSkin;
            Settings.SethSkin = SethSkin;
            Settings.NasTiiiSkin = NasTiiiSkin;
            Settings.EmCeeSkin = EmCeeSkin;
            Settings.RealDealSkin = RealDealSkin;
            Settings.JoseSkin = JoseSkin;
            Settings.EmilioSkin = EmilioSkin;
            Settings.ZackSkin = ZackSkin;
            Settings.ColinSkin = ColinSkin;
            Settings.JakeSkin = JakeSkin;
            Settings.TongYoonSkin = TongYoonSkin;
            Settings.BKSkin = BKSkin;
            Settings.GraveDiggaSkin = GraveDiggaSkin;
            Settings.BonesSkin = BonesSkin;
            Settings.BustaSkin = BustaSkin;
            Settings.SpiderSkin = SpiderSkin;
            Settings.PainKillahSkin = PainKillahSkin;
            Settings.DwayneSkin = DwayneSkin;
            Settings.DR88Skin = DR88Skin;
            Settings.PT22Skin = PT22Skin;
            Settings.BainSkin = BainSkin;
            Settings.CooperSkin = CooperSkin;
            Settings.AndersonSkin = AndersonSkin;
            Settings.TaylorSkin = TaylorSkin;
            Settings.AlexSkin = AlexSkin;
            Settings.McKinzieSkin = McKinzieSkin;
            Settings.RikiSkin = RikiSkin;
            Settings.MasaSkin = MasaSkin;
            Settings.HiroSkin = HiroSkin;
            Settings.RyujiSkin = RyujiSkin;
            Settings.YeWeiSkin = YeWeiSkin;
            Settings.ShaYingSkin = ShaYingSkin;
            Settings.LinFongLeeSkin = LinFongLeeSkin;
            Settings.VeraSkin = VeraSkin;
            Settings.PaulSkin = PaulSkin;
            Settings.LawSkin = LawSkin;

            Settings.SH2JamesTxt = SH2JamesTxt;
            Settings.RebeccaChambersTxt = RebeccaChambersTxt;
            Settings.ParkDanteTxt = ParkDanteTxt;
            Settings.BKCJTxt = BKCJTxt;
            Settings.GolemKratosTxt = GolemKratosTxt;
            Settings.SubzeroGolemTxt = SubzeroGolemTxt;
            Settings.VolcanicNapalmTxt = VolcanicNapalmTxt;
            Settings.CyberDwayneTxt = CyberDwayneTxt;
            Settings.HornswoggleTxt = HornswoggleTxt;
            Settings.DemonJinpachiTxt = DemonJinpachiTxt;
            Settings.RyuTxt = RyuTxt;
            Settings.AyaneShunYingTxt = AyaneShunYingTxt;
            Settings.MaskedDemonBradTxt = MaskedDemonBradTxt;
            Settings.KOFJakeTxt = KOFJakeTxt;
            Settings.PutaTxt = PutaTxt;
            Settings.ShunYingV2Txt = ShunYingV2Txt;
            Settings.SpiderManTxt = SpiderManTxt;
            Settings.SymbioteSpiderTxt = SymbioteSpiderTxt;
            Settings.HoboBonesTxt = HoboBonesTxt;
            Settings.NegativeToonYoonTxt = NegativeToonYoonTxt;
            Settings.SWAG_TyTxt = SWAG_TyTxt;
            Settings.HiroGATTxt = HiroGATTxt;
            Settings.KG_WhatsAppTxt = KG_WhatsAppTxt;
            Settings.RodKlugerTxt = RodKlugerTxt;
            Settings.TorqueGalsiaTxt = TorqueGalsiaTxt;
            Settings.RealDealKidTxt = RealDealKidTxt;
            Settings.BatmanGlenTxt = BatmanGlenTxt;
            Settings.TerminatorMckinzieTxt = TerminatorMckinzieTxt;
            Settings.EvilShunYingTxt = EvilShunYingTxt;
            Settings.OldMasterShinkaiTxt = OldMasterShinkaiTxt;
            Settings.CyberpunkGrimmTxt = CyberpunkGrimmTxt;
            Settings.KazumaKiryuBradTxt = KazumaKiryuBradTxt;
            Settings.CollinHermitSchoolTxt = CollinHermitSchoolTxt;
            Settings.MonsterEnergyGolemTxt = MonsterEnergyGolemTxt;
            Settings.BradfromGymTxt = BradfromGymTxt;
            Settings.CustomGrimmTxt = CustomGrimmTxt;
            Settings.SpecialAgentBradHawkTxt = SpecialAgentBradHawkTxt;
            Settings.MayorJakeHudsonTxt = MayorJakeHudsonTxt;
            Settings.GangsterAlexTxt = GangsterAlexTxt;
            Settings.GovernmentAgentBradHawkTxt = GovernmentAgentBradHawkTxt;
            Settings.SkeletonBoyTxt = SkeletonBoyTxt;
            Settings.HalloweenFKTxt = HalloweenFKTxt;
            Settings.Napumpin99Txt = Napumpin99Txt;
            Settings.VergilAlexTxt = VergilAlexTxt;
            Settings.GolemusTxt = GolemusTxt;
            Settings.X2000PopMiguelTxt = X2000PopMiguelTxt;
            Settings.MartialArtistBordinTxt = MartialArtistBordinTxt;
            Settings.McPunisherTxt = McPunisherTxt;
            Settings.TuxLinTxt = TuxLinTxt;
            Settings.CEOLinFongTxt = CEOLinFongTxt;
            Settings.VeraNinjaTxt = VeraNinjaTxt;
            Settings.JohnnyCageLawTxt = JohnnyCageLawTxt;
            Settings.GolemFanboyTxt = GolemFanboyTxt;
            Settings.EndangeredMasaTxt = EndangeredMasaTxt;
            Settings.SantaBonesTxt = SantaBonesTxt;
            Settings.GoldenGipsyTxt = GoldenGipsyTxt;
            Settings.SethSkin2 = SethSkin2;
            Settings.NasTiiiSkin2 = NasTiiiSkin2;
            Settings.EmCeeSkin2 = EmCeeSkin2;
            Settings.RamonSkin2 = RamonSkin2;
            Settings.JoseSkin2 = JoseSkin2;
            Settings.ZackSkin2 = ZackSkin2;
            Settings.GraveDiggaSkin2 = GraveDiggaSkin2;
            Settings.BoomaSkin2 = BoomaSkin2;
            Settings.BustaSkin2 = BustaSkin2;
            Settings.SpiderSkin2 = SpiderSkin2;
            Settings.PainKillahSkin2 = PainKillahSkin2;
            Settings.CooperSkin2 = CooperSkin2;
            Settings.TaylorSkin2 = TaylorSkin2;
            Settings.ChrisSkin2 = ChrisSkin2;
            Settings.RikiSkin2 = RikiSkin2;
            Settings.RyujiSkin2 = RyujiSkin2;
            Settings.YeWeiSkin2 = YeWeiSkin2;
            Settings.ShaYingSkin2 = ShaYingSkin2;
            Settings.YanJunSkin2 = YanJunSkin2;
            Settings.KellySkin2 = KellySkin2;
            Settings.PaulSkin2 = PaulSkin2;

            Settings.PepsimanTxt = PepsimanTxt;
            Settings.EddyTrainerTxt = EddyTrainerTxt;
            Settings.BrademTxt = BrademTxt;
            Settings.Paul2040Txt = Paul2040Txt;
            Settings.BeachGolemTxt = BeachGolemTxt;
            Settings.SpaceYakuzaTxt = SpaceYakuzaTxt;
            Settings.AlmostWhiteMiguelTxt = AlmostWhiteMiguelTxt;
            Settings.PrinceBordinTxt = PrinceBordinTxt;

            Settings.WeaponsTxt = WeaponsTxt;
            Settings.TitleScreenTxt = TitleScreenTxt;
            Settings.MultyplayerTxt = MultyplayerTxt;

            Settings.MasterBradMoves = MasterBradMoves;
            Settings.GolemBrokenShitMoves = GolemBrokenShitMoves;
            Settings.BordinAllAroundMoves = BordinAllAroundMoves;
            Settings.PaulAshesMoves = PaulAshesMoves;
            Settings.BradAndOthersParry = BradAndOthersParry;
            Settings.SakamotoRyomaMoves = SakamotoRyomaMoves;
            Settings.ShinBordinMoves = ShinBordinMoves;
            Settings.KOGMoves = KOGMoves;
            Settings.KingJakeMoves = KingJakeMoves;
            Settings.MMAGipsiesMoves = MMAGipsiesMoves;
            Settings.RikiDensetsuMoves = RikiDensetsuMoves;
            Settings.PhoenixStanceShunYingMoves = PhoenixStanceShunYingMoves;
            Settings.BrokenDwayneMoves = BrokenDwayneMoves;
            Settings.MonsterVeraMoves = MonsterVeraMoves;
            Settings.ThugKellyMoves = ThugKellyMoves;
            Settings.SwordmasterShunYingAndLilianMoves = SwordmasterShunYingAndLilianMoves;
            Settings.SwordmasterLinFongMoves = SwordmasterLinFongMoves;

            Settings.ClassyShunYingTxt = ClassyShunYingTxt;
            Settings.SchoolgirlLilianTxt = SchoolgirlLilianTxt;
            Settings.StreetKellyTxt = StreetKellyTxt;
            Settings.SeriousVeraTxt = SeriousVeraTxt;
            Settings.CrimsonLinFongTxt = CrimsonLinFongTxt;
            Settings.EasterBunnyLinFongTxt = EasterBunnyLinFongTxt;
            Settings.BlackHawkTxt = BlackHawkTxt;
            Settings.GoldenDragonLinFongTxt = GoldenDragonLinFongTxt;
            Settings.GothicShunYingTxt = GothicShunYingTxt;

            Settings.StatsChanged = StatsChanged;
            Settings.PageEnterSFX = PageEnterSFX;

            string serialString = JsonConvert.SerializeObject(Settings);
            Directory.CreateDirectory(folderPath);
            File.WriteAllText(SettingsPath, serialString);
        }
    }
}
