using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UR_pnach_editor.Services;
using System.IO;

namespace UR_pnach_editor.Codes
{
    public class CreatePnach5
    {
        static string baseCode = "";


        public static void AmateurPlayerTeam()
        {
            baseCode = "//P1" + Environment.NewLine +
                "patch=1,EE,105A6018,extended,01F4 //STK" + Environment.NewLine +
                "patch=1,EE,105A601A,extended,01F4 //GRP" + Environment.NewLine +
                "patch=1,EE,105A601C,extended,01F4 //RGA" + Environment.NewLine +
                "patch=1,EE,105A601E,extended,01F4 //SPA" + Environment.NewLine +
                "patch=1,EE,105A6020,extended,01F4 //WPA" + Environment.NewLine +
                "patch=1,EE,105A6022,extended,01F4 //TGH" + Environment.NewLine +
                "patch=1,EE,105A5FD2,extended,00FA //HDE" + Environment.NewLine +
                "patch=1,EE,105A5FD8,extended,007D //HDE Balance" + Environment.NewLine +
                "patch=1,EE,105A5FD4,extended,00FA //UBE" + Environment.NewLine +
                "patch=1,EE,105A5FDA,extended,007D //UBE Balance" + Environment.NewLine +
                "patch=1,EE,105A5FD6,extended,00FA //LBE" + Environment.NewLine +
                "patch=1,EE,105A5FDC,extended,007D //LBE Balance" + Environment.NewLine +
                "//P2" + Environment.NewLine +
                "patch=1,EE,105AF768,extended,01F4 //STK" + Environment.NewLine +
                "patch=1,EE,105AF76A,extended,01F4 //GRP" + Environment.NewLine +
                "patch=1,EE,105AF76C,extended,01F4 //RGA" + Environment.NewLine +
                "patch=1,EE,105AF76E,extended,01F4 //SPA" + Environment.NewLine +
                "patch=1,EE,105AF770,extended,01F4 //WPA" + Environment.NewLine +
                "patch=1,EE,105AF772,extended,01F4 //TGH" + Environment.NewLine +
                "patch=1,EE,105AF722,extended,00FA //HDE" + Environment.NewLine +
                "patch=1,EE,105AF728,extended,007D //HDE Balance" + Environment.NewLine +
                "patch=1,EE,105AF724,extended,00FA //UBE" + Environment.NewLine +
                "patch=1,EE,105AF72A,extended,007D //UBE Balance" + Environment.NewLine +
                "patch=1,EE,105AF726,extended,00FA //LBE" + Environment.NewLine +
                "patch=1,EE,105AF72C,extended,007D //LBE Balance" + Environment.NewLine +
            "";

            ExportPnach.ExportFile(baseCode);
        }

        public static void RedSPAEnemyTeam()
        {
            baseCode = "//P3" + Environment.NewLine +
            "patch=1,EE,205B8EA2,extended,3F80 //Spa Down Red Bar Color" + Environment.NewLine +
            "patch=1,EE,205B8EA6,extended,3F20 //Spa Down Green Bar Color" + Environment.NewLine +
            "patch=1,EE,205B8EAA,extended,3F20 //Spa Down Blue Bar Color" + Environment.NewLine +
            "patch=1,EE,205B8EAE,extended,3F20 //Spa Down Alpha Bar Color" + Environment.NewLine +
            "patch=1,EE,205B8EB0,extended,0002 //Spa Down" + Environment.NewLine +
            "patch=1,EE,205B8EB4,extended,44DF8000 //Infinite Spa Down" + Environment.NewLine +
            "//P4" + Environment.NewLine +
            "patch=1,EE,205C25F2,extended,3F80 //Spa Down Red Bar Color" + Environment.NewLine +
            "patch=1,EE,205C25F6,extended,3F20 //Spa Down Green Bar Color" + Environment.NewLine +
            "patch=1,EE,205C25FA,extended,3F20 //Spa Down Blue Bar Color" + Environment.NewLine +
            "patch=1,EE,205C25FE,extended,3F20 //Spa Down Alpha Bar Color" + Environment.NewLine +
            "patch=1,EE,205C2600,extended,0002 //Spa Down" + Environment.NewLine +
            "patch=1,EE,205C2604,extended,44DF8000 //Infinite Spa Down" + Environment.NewLine +
            "";

            ExportPnach.ExportFile(baseCode);
        }

        public static void MasterEnemyTeam()
        {
            baseCode = "//P3" + Environment.NewLine +
            "patch=1,EE,205B8EA2,extended,3F20 //Spa Down Red Bar Color" + Environment.NewLine +
            "patch=1,EE,205B8EA6,extended,3F20 //Spa Down Green Bar Color" + Environment.NewLine +
            "patch=1,EE,205B8EAA,extended,3F80 //Spa Down Blue Bar Color" + Environment.NewLine +
            "patch=1,EE,205B8EAE,extended,3F80 //Spa Down Alpha Bar Color" + Environment.NewLine +
            "patch=1,EE,205B8EB0,extended,0003 //Spa Down" + Environment.NewLine +
            "patch=1,EE,205B8EB4,extended,44DF8000 //Infinite Spa Down" + Environment.NewLine +
            "//P4" + Environment.NewLine +
            "patch=1,EE,205C25F2,extended,3F20 //Spa Down Red Bar Color" + Environment.NewLine +
            "patch=1,EE,205C25F6,extended,3F20 //Spa Down Green Bar Color" + Environment.NewLine +
            "patch=1,EE,205C25FA,extended,3F80 //Spa Down Blue Bar Color" + Environment.NewLine +
            "patch=1,EE,205C25FE,extended,3F80 //Spa Down Alpha Bar Color" + Environment.NewLine +
            "patch=1,EE,205C2600,extended,0003 //Spa Down" + Environment.NewLine +
            "patch=1,EE,205C2604,extended,44DF8000 //Infinite Spa Down" + Environment.NewLine +
            "";

            ExportPnach.ExportFile(baseCode);
        }

        public static void TankEnemyTeam()
        {
            baseCode = "//P3" + Environment.NewLine +
            "patch=1,EE,205B8EA2,extended,3F80 //Spa Down Red Bar Color" + Environment.NewLine +
            "patch=1,EE,205B8EA6,extended,3F80 //Spa Down Green Bar Color" + Environment.NewLine +
            "patch=1,EE,205B8EAA,extended,3F20 //Spa Down Blue Bar Color" + Environment.NewLine +
            "patch=1,EE,205B8EAE,extended,3F20 //Spa Down Alpha Bar Color" + Environment.NewLine +
            "patch=1,EE,205B8EB0,extended,0001 //Spa Down" + Environment.NewLine +
            "patch=1,EE,205B8EB4,extended,44DF8000 //Infinite Spa Down" + Environment.NewLine +
            "//P4" + Environment.NewLine +
            "patch=1,EE,205C25F2,extended,3F80 //Spa Down Red Bar Color" + Environment.NewLine +
            "patch=1,EE,205C25F6,extended,3F80 //Spa Down Green Bar Color" + Environment.NewLine +
            "patch=1,EE,205C25FA,extended,3F20 //Spa Down Blue Bar Color" + Environment.NewLine +
            "patch=1,EE,205C25FE,extended,3F20 //Spa Down Alpha Bar Color" + Environment.NewLine +
            "patch=1,EE,205C2600,extended,0001 //Spa Down" + Environment.NewLine +
            "patch=1,EE,205C2604,extended,44DF8000 //Infinite Spa Down" + Environment.NewLine +
            "";

            ExportPnach.ExportFile(baseCode);
        }

        public static void ToughEnemyTeam()
        {
            baseCode = "//P3" + Environment.NewLine +
            "patch=1,EE,105B8EC2,extended,07D0 //TGH" + Environment.NewLine +
            "//P4" + Environment.NewLine +
            "patch=1,EE,105C2612,extended,07D0 //TGH" + Environment.NewLine +
            "";

            ExportPnach.ExportFile(baseCode);
        }

        public static void RecoverEnemyTeam()
        {
            baseCode = "//P1" + Environment.NewLine +
            "patch=1,EE,105B8F10,extended,00C8 //SPA Regained" + Environment.NewLine +
             "//P4" + Environment.NewLine +
            "patch=1,EE,105C2660,extended,00C8 //SPA Regained" + Environment.NewLine +
            "";

            ExportPnach.ExportFile(baseCode);
        }

        public static void StrongEnemyTeam()
        {
            baseCode = "//P3" + Environment.NewLine +
                "patch=1,EE,105B8EB8,extended,05DC //STK" + Environment.NewLine +
                "patch=1,EE,105B8EBA,extended,05DC //GRP" + Environment.NewLine +
                "patch=1,EE,105B8EBC,extended,05DC //RGA" + Environment.NewLine +
                "patch=1,EE,105B8EBE,extended,05DC //SPA" + Environment.NewLine +
                "patch=1,EE,105B8EC0,extended,05DC //WPA" + Environment.NewLine +
                "patch=1,EE,105B8EC2,extended,05DC //TGH" + Environment.NewLine +
                "patch=1,EE,105B8E72,extended,02EE //HDE" + Environment.NewLine +
                "patch=1,EE,105B8E78,extended,0177 //HDE Balance" + Environment.NewLine +
                "patch=1,EE,105B8E74,extended,02EE //UBE" + Environment.NewLine +
                "patch=1,EE,105B8E7A,extended,0177 //UBE Balance" + Environment.NewLine +
                "patch=1,EE,105B8E76,extended,02EE //LBE" + Environment.NewLine +
                "patch=1,EE,105B8E7C,extended,0177 //LBE Balance" + Environment.NewLine +
                "//P4" + Environment.NewLine +
                "patch=1,EE,105C2608,extended,05DC //STK" + Environment.NewLine +
                "patch=1,EE,105C260A,extended,05DC //GRP" + Environment.NewLine +
                "patch=1,EE,105C260C,extended,05DC //RGA" + Environment.NewLine +
                "patch=1,EE,105C260E,extended,05DC //SPA" + Environment.NewLine +
                "patch=1,EE,105C2610,extended,05DC //WPA" + Environment.NewLine +
                "patch=1,EE,105C2612,extended,05DC //TGH" + Environment.NewLine +
                "patch=1,EE,105C25C2,extended,02EE //HDE" + Environment.NewLine +
                "patch=1,EE,105C25C8,extended,0177 //HDE Balance" + Environment.NewLine +
                "patch=1,EE,105C25C4,extended,02EE //UBE" + Environment.NewLine +
                "patch=1,EE,105C25CA,extended,0177 //UBE Balance" + Environment.NewLine +
                "patch=1,EE,105C25C6,extended,02EE //LBE" + Environment.NewLine +
                "patch=1,EE,105C25CC,extended,0177 //LBE Balance" + Environment.NewLine +
            "";

            ExportPnach.ExportFile(baseCode);
        }

        public static void ExtremeEnemyTeam()
        {
            baseCode = "//P3" + Environment.NewLine +
                "patch=1,EE,105B8EB8,extended,1388 //STK" + Environment.NewLine +
                "patch=1,EE,105B8EBA,extended,1388 //GRP" + Environment.NewLine +
                "patch=1,EE,105B8EBC,extended,0FA0 //RGA" + Environment.NewLine +
                "patch=1,EE,105B8EBE,extended,1388 //SPA" + Environment.NewLine +
                "patch=1,EE,105B8EC0,extended,0FA0 //WPA" + Environment.NewLine +
                "patch=1,EE,105B8EC2,extended,01F4 //TGH" + Environment.NewLine +
                "patch=1,EE,105B8E72,extended,00C8 //HDE" + Environment.NewLine +
                "patch=1,EE,105B8E78,extended,0064 //HDE Balance" + Environment.NewLine +
                "patch=1,EE,105B8E74,extended,00C8 //UBE" + Environment.NewLine +
                "patch=1,EE,105B8E7A,extended,0064 //UBE Balance" + Environment.NewLine +
                "patch=1,EE,105B8E76,extended,00C8 //LBE" + Environment.NewLine +
                "patch=1,EE,105B8E7C,extended,0064 //LBE Balance" + Environment.NewLine +
                "//P4" + Environment.NewLine +
                "patch=1,EE,105C2608,extended,00C8 //STK" + Environment.NewLine +
                "patch=1,EE,105C260A,extended,00C8 //GRP" + Environment.NewLine +
                "patch=1,EE,105C260C,extended,00C8 //RGA" + Environment.NewLine +
                "patch=1,EE,105C260E,extended,00FA //SPA" + Environment.NewLine +
                "patch=1,EE,105C2610,extended,00C8 //WPA" + Environment.NewLine +
                "patch=1,EE,105C2612,extended,07D0 //TGH" + Environment.NewLine +
                "patch=1,EE,105C25C2,extended,05DC //HDE" + Environment.NewLine +
                "patch=1,EE,105C25C8,extended,02EE //HDE Balance" + Environment.NewLine +
                "patch=1,EE,105C25C4,extended,05DC //UBE" + Environment.NewLine +
                "patch=1,EE,105C25CA,extended,02EE //UBE Balance" + Environment.NewLine +
                "patch=1,EE,105C25C6,extended,05DC //LBE" + Environment.NewLine +
                "patch=1,EE,105C25CC,extended,02EE //LBE Balance" + Environment.NewLine +
            "";

            ExportPnach.ExportFile(baseCode);
        }

        public static void FairEnemyTeam()
        {
            baseCode = "//P3" + Environment.NewLine +
                "patch=1,EE,105B8EB8,extended,07D0 //STK" + Environment.NewLine +
                "patch=1,EE,105B8EBA,extended,07D0 //GRP" + Environment.NewLine +
                "patch=1,EE,105B8EBC,extended,07D0 //RGA" + Environment.NewLine +
                "patch=1,EE,105B8EBE,extended,07D0 //SPA" + Environment.NewLine +
                "patch=1,EE,105B8EC0,extended,07D0 //WPA" + Environment.NewLine +
                "patch=1,EE,105B8EC2,extended,07D0 //TGH" + Environment.NewLine +
                "patch=1,EE,105B8E72,extended,03E8 //HDE" + Environment.NewLine +
                "patch=1,EE,105B8E78,extended,01F4 //HDE Balance" + Environment.NewLine +
                "patch=1,EE,105B8E74,extended,03E8 //UBE" + Environment.NewLine +
                "patch=1,EE,105B8E7A,extended,01F4 //UBE Balance" + Environment.NewLine +
                "patch=1,EE,105B8E76,extended,03E8 //LBE" + Environment.NewLine +
                "patch=1,EE,105B8E7C,extended,01F4 //LBE Balance" + Environment.NewLine +
                "patch=1,EE,105B8E92,extended,0000 //Spa Bar" + Environment.NewLine +
                "//P4" + Environment.NewLine +
                "patch=1,EE,105C2608,extended,07D0 //STK" + Environment.NewLine +
                "patch=1,EE,105C260A,extended,07D0 //GRP" + Environment.NewLine +
                "patch=1,EE,105C260C,extended,07D0 //RGA" + Environment.NewLine +
                "patch=1,EE,105C260E,extended,07D0 //SPA" + Environment.NewLine +
                "patch=1,EE,105C2610,extended,07D0 //WPA" + Environment.NewLine +
                "patch=1,EE,105C2612,extended,07D0 //TGH" + Environment.NewLine +
                "patch=1,EE,105C25C2,extended,03E8 //HDE" + Environment.NewLine +
                "patch=1,EE,105C25C8,extended,01F4 //HDE Balance" + Environment.NewLine +
                "patch=1,EE,105C25C4,extended,03E8 //UBE" + Environment.NewLine +
                "patch=1,EE,105C25CA,extended,01F4 //UBE Balance" + Environment.NewLine +
                "patch=1,EE,105C25C6,extended,03E8 //LBE" + Environment.NewLine +
                "patch=1,EE,105C25CC,extended,01F4 //LBE Balance" + Environment.NewLine +
                "patch=1,EE,105C25E2,extended,0000 //Spa Bar" + Environment.NewLine +
            "";

            ExportPnach.ExportFile(baseCode);
        }

        public static void OneHitEnemyTeam()
        {
            baseCode = "//P1" + Environment.NewLine +
                "patch=1,EE,105A6022,extended,0064 //TGH" + Environment.NewLine +
                "//P2" + Environment.NewLine +
                "patch=1,EE,105AF772,extended,0064 //TGH" + Environment.NewLine +
                "//P3" + Environment.NewLine +
                "patch=1,EE,105B8EB8,extended,FFFF //STK" + Environment.NewLine +
                "patch=1,EE,105B8EBA,extended,FFFF //GRP" + Environment.NewLine +
                "patch=1,EE,105B8EBC,extended,FFFF //RGA" + Environment.NewLine +
                "patch=1,EE,105B8EBE,extended,FFFF //SPA" + Environment.NewLine +
                "patch=1,EE,105B8EC0,extended,FFFF //WPA" + Environment.NewLine +
                "//P4" + Environment.NewLine +
                "patch=1,EE,105C2608,extended,FFFF //STK" + Environment.NewLine +
                "patch=1,EE,105C260A,extended,FFFF //GRP" + Environment.NewLine +
                "patch=1,EE,105C260C,extended,FFFF //RGA" + Environment.NewLine +
                "patch=1,EE,105C260E,extended,FFFF //SPA" + Environment.NewLine +
                "patch=1,EE,105C2610,extended,FFFF //WPA" + Environment.NewLine +
            "";

            ExportPnach.ExportFile(baseCode);
        }

        public static void FairPlayerTeam()
        {
            baseCode = "//P1" + Environment.NewLine +
                "patch=1,EE,105A5FF2,extended,0000 //Spa Bar" + Environment.NewLine +
                "//P2" + Environment.NewLine +
                "patch=1,EE,105AF742,extended,0000 //Spa Bar" + Environment.NewLine +
            "";

            ExportPnach.ExportFile(baseCode);
        }

        public static void UltimatePlayerTeam()
        {
            baseCode = "//P1" + Environment.NewLine +
                "patch=1,EE,105A6018,extended,07D0 //STK" + Environment.NewLine +
                "patch=1,EE,105A601A,extended,07D0 //GRP" + Environment.NewLine +
                "patch=1,EE,105A601C,extended,07D0 //RGA" + Environment.NewLine +
                "patch=1,EE,105A601E,extended,07D0 //SPA" + Environment.NewLine +
                "patch=1,EE,105A6020,extended,07D0 //WPA" + Environment.NewLine +
                "patch=1,EE,105A6022,extended,07D0 //TGH" + Environment.NewLine +
                "patch=1,EE,105A5FD2,extended,03E8 //HDE" + Environment.NewLine +
                "patch=1,EE,105A5FD8,extended,01F4 //HDE Balance" + Environment.NewLine +
                "patch=1,EE,105A5FD4,extended,03E8 //UBE" + Environment.NewLine +
                "patch=1,EE,105A5FDA,extended,01F4 //UBE Balance" + Environment.NewLine +
                "patch=1,EE,105A5FD6,extended,03E8 //LBE" + Environment.NewLine +
                "patch=1,EE,105A5FDC,extended,01F4 //LBE Balance" + Environment.NewLine +
                "//P2" + Environment.NewLine +
                "patch=1,EE,105AF768,extended,07D0 //STK" + Environment.NewLine +
                "patch=1,EE,105AF76A,extended,07D0 //GRP" + Environment.NewLine +
                "patch=1,EE,105AF76C,extended,07D0 //RGA" + Environment.NewLine +
                "patch=1,EE,105AF76E,extended,07D0 //SPA" + Environment.NewLine +
                "patch=1,EE,105AF770,extended,07D0 //WPA" + Environment.NewLine +
                "patch=1,EE,105AF772,extended,07D0 //TGH" + Environment.NewLine +
                "patch=1,EE,105AF722,extended,03E8 //HDE" + Environment.NewLine +
                "patch=1,EE,105AF728,extended,01F4 //HDE Balance" + Environment.NewLine +
                "patch=1,EE,105AF724,extended,03E8 //UBE" + Environment.NewLine +
                "patch=1,EE,105AF72A,extended,01F4 //UBE Balance" + Environment.NewLine +
                "patch=1,EE,105AF726,extended,03E8 //LBE" + Environment.NewLine +
                "patch=1,EE,105AF72C,extended,01F4 //LBE Balance" + Environment.NewLine +
            "";

            ExportPnach.ExportFile(baseCode);
        }

        public static void RegionalShowdown()
        {
            int random1 = new Random().Next(1, 4);
            int random2 = new Random().Next(1, 4);
            int random3 = new Random().Next(1, 4);
            int random4 = new Random().Next(1, 4);
            string hde1 = "";
            string hdeB1 = "";
            string ube1 = "";
            string ubeB1 = "";
            string lbe1 = "";
            string lbeB1 = "";
            string hde2 = "";
            string hdeB2 = "";
            string ube2 = "";
            string ubeB2 = "";
            string lbe2 = "";
            string lbeB2 = "";
            string hde3 = "";
            string hdeB3 = "";
            string ube3 = "";
            string ubeB3 = "";
            string lbe3 = "";
            string lbeB3 = "";
            string hde4 = "";
            string hdeB4 = "";
            string ube4 = "";
            string ubeB4 = "";
            string lbe4 = "";
            string lbeB4 = "";

            string weakPart = "258";
            string weakPartBal = "12C";
            string regularPart = "578";
            string regularPartBal = "2BC";
            string strongPart = "640";
            string strongPartBal = "320";

            switch (random1)
            {
                case 1:
                    hde1 = strongPart;
                    hdeB1 = strongPartBal;
                    ube1 = regularPart;
                    ubeB1 = regularPartBal;
                    lbe1 = weakPart;
                    lbeB1 = weakPartBal;
                    break;
                case 2:
                    hde1 = weakPart;
                    hdeB1 = weakPartBal;
                    ube1 = strongPart;
                    ubeB1 = strongPartBal;
                    lbe1 = regularPart;
                    lbeB1 = regularPartBal;
                    break;
                case 3:
                    hde1 = regularPart;
                    hdeB1 = regularPartBal;
                    ube1 = weakPart;
                    ubeB1 = weakPartBal;
                    lbe1 = strongPart;
                    lbeB1 = strongPartBal;
                    break;
            }
            switch (random2)
            {
                case 1:
                    hde2 = strongPart;
                    hdeB2 = strongPartBal;
                    ube2 = regularPart;
                    ubeB2 = regularPartBal;
                    lbe2 = weakPart;
                    lbeB2 = weakPartBal;
                    break;
                case 2:
                    hde2 = weakPart;
                    hdeB2 = weakPartBal;
                    ube2 = strongPart;
                    ubeB2 = strongPartBal;
                    lbe2 = regularPart;
                    lbeB2 = regularPartBal;
                    break;
                case 3:
                    hde2 = regularPart;
                    hdeB2 = regularPartBal;
                    ube2 = weakPart;
                    ubeB2 = weakPartBal;
                    lbe2 = strongPart;
                    lbeB2 = strongPartBal;
                    break;
            }
            switch (random3)
            {
                case 1:
                    hde3 = strongPart;
                    hdeB3 = strongPartBal;
                    ube3 = regularPart;
                    ubeB3 = regularPartBal;
                    lbe3 = weakPart;
                    lbeB3 = weakPartBal;
                    break;
                case 2:
                    hde3 = weakPart;
                    hdeB3 = weakPartBal;
                    ube3 = strongPart;
                    ubeB3 = strongPartBal;
                    lbe3 = regularPart;
                    lbeB3 = regularPartBal;
                    break;
                case 3:
                    hde3 = regularPart;
                    hdeB3 = regularPartBal;
                    ube3 = weakPart;
                    ubeB3 = weakPartBal;
                    lbe3 = strongPart;
                    lbeB3 = strongPartBal;
                    break;
            }
            switch (random4)
            {
                case 1:
                    hde4 = strongPart;
                    hdeB4 = strongPartBal;
                    ube4 = regularPart;
                    ubeB4 = regularPartBal;
                    lbe4 = weakPart;
                    lbeB4 = weakPartBal;
                    break;
                case 2:
                    hde4 = weakPart;
                    hdeB4 = weakPartBal;
                    ube4 = strongPart;
                    ubeB4 = strongPartBal;
                    lbe4 = regularPart;
                    lbeB4 = regularPartBal;
                    break;
                case 3:
                    hde4 = regularPart;
                    hdeB4 = regularPartBal;
                    ube4 = weakPart;
                    ubeB4 = weakPartBal;
                    lbe4 = strongPart;
                    lbeB4 = strongPartBal;
                    break;
            }

            baseCode = "//P1" + Environment.NewLine +
                "patch=1,EE,105A6022,extended,1388 //TGH" + Environment.NewLine +
                "patch=1,EE,105A5FD2,extended," + hde1 + " //HDE" + Environment.NewLine +
                "patch=1,EE,105A5FD8,extended," + hdeB1 + " //HDE Balance" + Environment.NewLine +
                "patch=1,EE,105A5FD4,extended," + ube1 + " //UBE" + Environment.NewLine +
                "patch=1,EE,105A5FDA,extended," + ubeB1 + " //UBE Balance" + Environment.NewLine +
                "patch=1,EE,105A5FD6,extended," + lbe1 + " //LBE" + Environment.NewLine +
                "patch=1,EE,105A5FDC,extended," + lbeB1 + " //LBE Balance" + Environment.NewLine +
                "//P2" + Environment.NewLine +
                "patch=1,EE,105AF772,extended,1388 //TGH" + Environment.NewLine +
                "patch=1,EE,105AF722,extended," + hde2 + " //HDE" + Environment.NewLine +
                "patch=1,EE,105AF728,extended," + hdeB2 + " //HDE Balance" + Environment.NewLine +
                "patch=1,EE,105AF724,extended," + ube2 + " //UBE" + Environment.NewLine +
                "patch=1,EE,105AF72A,extended," + ubeB2 + " //UBE Balance" + Environment.NewLine +
                "patch=1,EE,105AF726,extended," + lbe2 + " //LBE" + Environment.NewLine +
                "patch=1,EE,105AF72C,extended," + lbeB2 + " //LBE Balance" + Environment.NewLine +
                "//P3" + Environment.NewLine +
                "patch=1,EE,105B8EC2,extended,1388 //TGH" + Environment.NewLine +
                "patch=1,EE,105B8E72,extended," + hde3 + " //HDE" + Environment.NewLine +
                "patch=1,EE,105B8E78,extended," + hdeB3 + " //HDE Balance" + Environment.NewLine +
                "patch=1,EE,105B8E74,extended," + ube3 + " //UBE" + Environment.NewLine +
                "patch=1,EE,105B8E7A,extended," + ubeB3 + " //UBE Balance" + Environment.NewLine +
                "patch=1,EE,105B8E76,extended," + lbe3 + " //LBE" + Environment.NewLine +
                "patch=1,EE,105B8E7C,extended," + lbeB3 + " //LBE Balance" + Environment.NewLine +
                "//P4" + Environment.NewLine +
                "patch=1,EE,105C2612,extended,1388 //TGH" + Environment.NewLine +
                "patch=1,EE,105C25C2,extended," + hde4 + " //HDE" + Environment.NewLine +
                "patch=1,EE,105C25C8,extended," + hdeB4 + " //HDE Balance" + Environment.NewLine +
                "patch=1,EE,105C25C4,extended," + ube4 + " //UBE" + Environment.NewLine +
                "patch=1,EE,105C25CA,extended," + ubeB4 + " //UBE Balance" + Environment.NewLine +
                "patch=1,EE,105C25C6,extended," + lbe4 + " //LBE" + Environment.NewLine +
                "patch=1,EE,105C25CC,extended," + lbeB4 + " //LBE Balance" + Environment.NewLine +
                "" + Environment.NewLine +
                "patch=1,EE,10ABF670,extended,0001 //regional ko set to on" + Environment.NewLine +
            "";

            ExportPnach.ExportFile(baseCode);
        }

        public static void KickChampions()
        {
            baseCode = "//P3" + Environment.NewLine +
                "patch=1,EE,105B8EB8,extended,0BB8 //STK" + Environment.NewLine +
                "patch=1,EE,105B8EBA,extended,0898 //GRP" + Environment.NewLine +
                "patch=1,EE,105B8EBC,extended,0834 //RGA" + Environment.NewLine +
                "patch=1,EE,105B8EBE,extended,07D0 //SPA" + Environment.NewLine +
                "patch=1,EE,105B8EC0,extended,01F4 //WPA" + Environment.NewLine +
                "patch=1,EE,105B8EC2,extended,0898 //TGH" + Environment.NewLine +
                "patch=1,EE,105B8E72,extended,0226 //HDE" + Environment.NewLine +
                "patch=1,EE,105B8E78,extended,0113 //HDE Balance" + Environment.NewLine +
                "patch=1,EE,105B8E74,extended,0258 //UBE" + Environment.NewLine +
                "patch=1,EE,105B8E7A,extended,012C //UBE Balance" + Environment.NewLine +
                "patch=1,EE,105B8E76,extended,0384 //LBE" + Environment.NewLine +
                "patch=1,EE,105B8E7C,extended,01C2 //LBE Balance" + Environment.NewLine +
                "patch=1,EE,205B0044,extended,0014 //Moves & Skin 1" + Environment.NewLine +
                "patch=1,EE,205B8E34,extended,00320033 //P3 AI" + Environment.NewLine +
                "patch=1,EE,2094A63C,extended,0014 //Moves & Skin 2" + Environment.NewLine +
                "//P4" + Environment.NewLine +
                "patch=1,EE,105C2608,extended,0834 //STK" + Environment.NewLine +
                "patch=1,EE,105C260A,extended,07D0 //GRP" + Environment.NewLine +
                "patch=1,EE,105C260C,extended,06A4 //RGA" + Environment.NewLine +
                "patch=1,EE,105C260E,extended,0AF0 //SPA" + Environment.NewLine +
                "patch=1,EE,105C2610,extended,0258 //WPA" + Environment.NewLine +
                "patch=1,EE,105C2612,extended,0708 //TGH" + Environment.NewLine +
                "patch=1,EE,105C25C2,extended,0177 //HDE" + Environment.NewLine +
                "patch=1,EE,105C25C8,extended,00BC //HDE Balance" + Environment.NewLine +
                "patch=1,EE,105C25C4,extended,01C2 //UBE" + Environment.NewLine +
                "patch=1,EE,105C25CA,extended,00E1 //UBE Balance" + Environment.NewLine +
                "patch=1,EE,105C25C6,extended,0258 //LBE" + Environment.NewLine +
                "patch=1,EE,105C25CC,extended,012C //LBE Balance" + Environment.NewLine +
                "patch=1,EE,105C2BB8,extended,0001 //Auta-Grab" + Environment.NewLine +
                "patch=1,EE,205B9794,extended,0029 //Moves & Skin 1" + Environment.NewLine +
                "patch=1,EE,205C2584,extended,00330033 //P4 AI" + Environment.NewLine +
                "patch=1,EE,2094A640,extended,0029 //Moves & Skin 2" + Environment.NewLine +
            "";

            ExportPnach.ExportFile(baseCode);
        }

        public static void GrandmasterChallenge()
        {
            baseCode = "//P1" + Environment.NewLine +
                "patch=1,EE,105A6018,extended,4E20 //STK" + Environment.NewLine +
                "patch=1,EE,105A601A,extended,00C8 //GRP" + Environment.NewLine +
                "patch=1,EE,105A601E,extended,012C //SPA" + Environment.NewLine +
                "patch=1,EE,105A6020,extended,4E20 //WPA" + Environment.NewLine +
                "//P2" + Environment.NewLine +
                "patch=1,EE,105AF768,extended,4E20 //STK" + Environment.NewLine +
                "patch=1,EE,105AF76A,extended,00C8 //GRP" + Environment.NewLine +
                "patch=1,EE,105AF76E,extended,012C //SPA" + Environment.NewLine +
                "patch=1,EE,105AF770,extended,4E20 //WPA" + Environment.NewLine +
                "//P3" + Environment.NewLine +
                "patch=1,EE,105AF746,extended,0000 //SPA Cooldown" + Environment.NewLine +
                "patch=1,EE,105B8EC2,extended,2710 //TGH" + Environment.NewLine +
                "patch=1,EE,105B8E8A,extended,0010 //WALL DMG" + Environment.NewLine +
                "patch=1,EE,105B9468,extended,0001 //Auta-Grab" + Environment.NewLine +
                "patch=1,EE,105B948A,extended,0000 //Auto-Parry" + Environment.NewLine +
                "patch=1,EE,105B8E34,extended,000C000C //P3 AI" + Environment.NewLine +
                "//P4" + Environment.NewLine +
                "patch=1,EE,105C2608,extended,4E20 //STK" + Environment.NewLine +
                "patch=1,EE,105C260A,extended,0096 //GRP" + Environment.NewLine +
                "patch=1,EE,105C260E,extended,012C //SPA" + Environment.NewLine +
                "patch=1,EE,105C2610,extended,FFFF //WPA" + Environment.NewLine +
                "patch=1,EE,105C2506,extended,0000 //P4 team" + Environment.NewLine +
            "";

            ExportPnach.ExportFile(baseCode);
        }


        public static void P5Enemy()
        {
            baseCode = "" + Environment.NewLine +
                "patch=1,EE,105C2EE4,extended,02 //P5 char set to Brad with sunglasses" + Environment.NewLine +
                "patch=1,EE,105CB7C4,extended,01 //P5 ON" + Environment.NewLine +
                "patch=1,EE,105CBC56,extended,04 //P5 team" + Environment.NewLine +
                "patch=1,EE,105CBC58,extended,01 //P5 controlled by ai 1 [0 = p1 control]" + Environment.NewLine +
                "patch=1,EE,105CBCC4,extended,01 //P5 controlled by ai 2 [0 = p1 control]" + Environment.NewLine +
                "patch=1,EE,105CBCD4,extended,000C000C  //P5 AI (set to golem story)" + Environment.NewLine +
                "patch=1,EE,105CBD58,extended,03E8 //STK" + Environment.NewLine +
                "patch=1,EE,105CBD5A,extended,03E8 //GRP" + Environment.NewLine +
                "patch=1,EE,105CBD5C,extended,03E8 //RGA" + Environment.NewLine +
                "patch=1,EE,105CBD5E,extended,03E8 //SPA" + Environment.NewLine +
                "patch=1,EE,105CBD60,extended,03E8 //WPA" + Environment.NewLine +
                "patch=1,EE,105CBD62,extended,03E8 //TGH" + Environment.NewLine +
                "patch=1,EE,105CBD12,extended,01F4 //HDE" + Environment.NewLine +
                "patch=1,EE,105CBD18,extended,00FA //HDE Balance" + Environment.NewLine +
                "patch=1,EE,105CBD14,extended,01F4 //UBE" + Environment.NewLine +
                "patch=1,EE,105CBD1A,extended,00FA //UBE Balance" + Environment.NewLine +
                "patch=1,EE,105CBD16,extended,01F4 //LBE" + Environment.NewLine +
                "patch=1,EE,105CBD1C,extended,00FA //LBE Balance" + Environment.NewLine +
            "";

            ExportPnach.ExportFile(baseCode);
        }


    }
}
