using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using OfficeOpenXml;
using System.Windows;
using System.IO.Packaging;
using System.Data;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.DirectoryServices;
using UR_pnach_editor.Services;

namespace UR_pnach_editor.Codes
{
    public class CreatePnach
    {
        static string baseCode = "";

        public static void RandomizeAll()
        {
            int rnd = 0;
            string random = "";
            string random2 = "";
            List<string> ValuesList = new List<string>();


            for (int i = 0; i < 36; i++)
            {
                rnd = new Random().Next(100, 1001);

                if (i < 24)
                {
                    random = rnd.ToString("X");
                }
                else if (i > 23)
                {
                    random = (rnd / 2).ToString("X");
                    random2 = (rnd / 4).ToString("X");
                }

                if (random.Length == 1)
                {
                    random = random.PadLeft(2, '0');
                }
                if (random.Length == 2)
                {
                    random = random.PadLeft(3, '0');
                }
                if (random.Length == 3)
                {
                    random = random.PadLeft(4, '0');
                }
                if (random2.Length == 1)
                {
                    random2 = random2.PadLeft(2, '0');
                }
                if (random2.Length == 2)
                {
                    random2 = random2.PadLeft(3, '0');
                }
                if (random2.Length == 3)
                {
                    random2 = random2.PadLeft(4, '0');
                }


                ValuesList.Add(random);
                if (i > 23)
                {
                    ValuesList.Add(random2);
                }
            }

            baseCode = "//P1" + Environment.NewLine +
                "patch=1,EE,105A6018,extended," + ValuesList[0] + " //STK" + Environment.NewLine +
                "patch=1,EE,105A601A,extended," + ValuesList[1] + " //GRP" + Environment.NewLine +
                "patch=1,EE,105A601C,extended," + ValuesList[2] + " //RGA" + Environment.NewLine +
                "patch=1,EE,105A601E,extended," + ValuesList[3] + " //SPA" + Environment.NewLine +
                "patch=1,EE,105A6020,extended," + ValuesList[4] + " //WPA" + Environment.NewLine +
                "patch=1,EE,105A6022,extended," + ValuesList[5] + " //TGH" + Environment.NewLine +
                "patch=1,EE,105A5FD2,extended," + ValuesList[24] + " //HDE" + Environment.NewLine +
                "patch=1,EE,105A5FD8,extended," + ValuesList[25] + " //HDE Balance" + Environment.NewLine +
                "patch=1,EE,105A5FD4,extended," + ValuesList[26] + " //UBE" + Environment.NewLine +
                "patch=1,EE,105A5FDA,extended," + ValuesList[27] + " //UBE Balance" + Environment.NewLine +
                "patch=1,EE,105A5FD6,extended," + ValuesList[28] + " //LBE" + Environment.NewLine +
                "patch=1,EE,105A5FDC,extended," + ValuesList[29] + " //LBE Balance" + Environment.NewLine +
                "//P2" + Environment.NewLine +
                "patch=1,EE,105AF768,extended," + ValuesList[6] + " //STK" + Environment.NewLine +
                "patch=1,EE,105AF76A,extended," + ValuesList[7] + " //GRP" + Environment.NewLine +
                "patch=1,EE,105AF76C,extended," + ValuesList[8] + " //RGA" + Environment.NewLine +
                "patch=1,EE,105AF76E,extended," + ValuesList[9] + " //SPA" + Environment.NewLine +
                "patch=1,EE,105AF770,extended," + ValuesList[10] + " //WPA" + Environment.NewLine +
                "patch=1,EE,105AF772,extended," + ValuesList[11] + " //TGH" + Environment.NewLine +
                "patch=1,EE,105AF722,extended," + ValuesList[30] + " //HDE" + Environment.NewLine +
                "patch=1,EE,105AF728,extended," + ValuesList[31] + " //HDE Balance" + Environment.NewLine +
                "patch=1,EE,105AF724,extended," + ValuesList[32] + " //UBE" + Environment.NewLine +
                "patch=1,EE,105AF72A,extended," + ValuesList[33] + " //UBE Balance" + Environment.NewLine +
                "patch=1,EE,105AF726,extended," + ValuesList[34] + " //LBE" + Environment.NewLine +
                "patch=1,EE,105AF72C,extended," + ValuesList[35] + " //LBE Balance" + Environment.NewLine +
                "//P3" + Environment.NewLine +
                "patch=1,EE,105B8EB8,extended," + ValuesList[12] + " //STK" + Environment.NewLine +
                "patch=1,EE,105B8EBA,extended," + ValuesList[13] + " //GRP" + Environment.NewLine +
                "patch=1,EE,105B8EBC,extended," + ValuesList[14] + " //RGA" + Environment.NewLine +
                "patch=1,EE,105B8EBE,extended," + ValuesList[15] + " //SPA" + Environment.NewLine +
                "patch=1,EE,105B8EC0,extended," + ValuesList[16] + " //WPA" + Environment.NewLine +
                "patch=1,EE,105B8EC2,extended," + ValuesList[17] + " //TGH" + Environment.NewLine +
                "patch=1,EE,105B8E72,extended," + ValuesList[36] + " //HDE" + Environment.NewLine +
                "patch=1,EE,105B8E78,extended," + ValuesList[37] + " //HDE Balance" + Environment.NewLine +
                "patch=1,EE,105B8E74,extended," + ValuesList[38] + " //UBE" + Environment.NewLine +
                "patch=1,EE,105B8E7A,extended," + ValuesList[39] + " //UBE Balance" + Environment.NewLine +
                "patch=1,EE,105B8E76,extended," + ValuesList[40] + " //LBE" + Environment.NewLine +
                "patch=1,EE,105B8E7C,extended," + ValuesList[41] + " //LBE Balance" + Environment.NewLine +
                "//P4" + Environment.NewLine +
                "patch=1,EE,105C2608,extended," + ValuesList[18] + " //STK" + Environment.NewLine +
                "patch=1,EE,105C260A,extended," + ValuesList[19] + " //GRP" + Environment.NewLine +
                "patch=1,EE,105C260C,extended," + ValuesList[20] + " //RGA" + Environment.NewLine +
                "patch=1,EE,105C260E,extended," + ValuesList[21] + " //SPA" + Environment.NewLine +
                "patch=1,EE,105C2610,extended," + ValuesList[22] + " //WPA" + Environment.NewLine +
                "patch=1,EE,105C2612,extended," + ValuesList[23] + " //TGH" + Environment.NewLine +
                "patch=1,EE,105C25C2,extended," + ValuesList[42] + " //HDE" + Environment.NewLine +
                "patch=1,EE,105C25C8,extended," + ValuesList[43] + " //HDE Balance" + Environment.NewLine +
                "patch=1,EE,105C25C4,extended," + ValuesList[44] + " //UBE" + Environment.NewLine +
                "patch=1,EE,105C25CA,extended," + ValuesList[45] + " //UBE Balance" + Environment.NewLine +
                "patch=1,EE,105C25C6,extended," + ValuesList[46] + " //LBE" + Environment.NewLine +
                "patch=1,EE,105C25CC,extended," + ValuesList[47] + " //LBE Balance" + Environment.NewLine +
                "";

            ExportPnach.ExportFile(baseCode);
        }

        public static void DoubleTghEneTeam()
        {
            baseCode = "//P1" + Environment.NewLine +
                "patch=1,EE,105A6070,extended,0014 //SPA Regained" + Environment.NewLine +
                "//P2" + Environment.NewLine +
                "patch=1,EE,105AF7C0,extended,0014 //SPA Regained" + Environment.NewLine +
                "//P3" + Environment.NewLine +
                "patch=1,EE,105B8EC2,extended,07D0 //TGH" + Environment.NewLine +
                "patch=1,EE,105B8E72,extended,03E8 //HDE" + Environment.NewLine +
                "patch=1,EE,105B8E78,extended,01F4 //HDE Balance" + Environment.NewLine +
                "patch=1,EE,105B8E74,extended,03E8 //UBE" + Environment.NewLine +
                "patch=1,EE,105B8E7A,extended,01F4 //UBE Balance" + Environment.NewLine +
                "patch=1,EE,105B8E76,extended,03E8 //LBE" + Environment.NewLine +
                "patch=1,EE,105B8E7C,extended,01F4 //LBE Balance" + Environment.NewLine +
                "//P4" + Environment.NewLine +
                "patch=1,EE,105C2612,extended,07D0 //TGH" + Environment.NewLine +
                "patch=1,EE,105C25C2,extended,03E8 //HDE" + Environment.NewLine +
                "patch=1,EE,105C25C8,extended,01F4 //HDE Balance" + Environment.NewLine +
                "patch=1,EE,105C25C4,extended,03E8 //UBE" + Environment.NewLine +
                "patch=1,EE,105C25CA,extended,01F4 //UBE Balance" + Environment.NewLine +
                "patch=1,EE,105C25C6,extended,03E8 //LBE" + Environment.NewLine +
                "patch=1,EE,105C25CC,extended,01F4 //LBE Balance" + Environment.NewLine +
                "";

            ExportPnach.ExportFile(baseCode);
        }

        public static void MaxWeaponsDmg()
        {
            baseCode = "//P1" + Environment.NewLine +
                "patch=1,EE,105A6020,extended,FFFF //WPA" + Environment.NewLine +
                "//P2" + Environment.NewLine +
                "patch=1,EE,105AF770,extended,FFFF //WPA" + Environment.NewLine +
                "//P3" + Environment.NewLine +
                "patch=1,EE,105B8EC0,extended,FFFF //WPA" + Environment.NewLine +
                "//P4" + Environment.NewLine +
                "patch=1,EE,105C2610,extended,FFFF //WPA" + Environment.NewLine +
                "";

            ExportPnach.ExportFile(baseCode);
        }

        public static void BossP3()
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
                "patch=1,EE,105B948A,extended,0000 //Auto-Parry" + Environment.NewLine +
                "patch=1,EE,105AF746,extended,0000 //SPA Cooldown" + Environment.NewLine +
                "patch=1,EE,105B8F10,extended,0014 //SPA Regained" + Environment.NewLine +
                "//P4" + Environment.NewLine +
                "patch=1,EE,D05AF718,extended,05DC //HP1" + Environment.NewLine +
                "patch=1,EE,105C25B8,extended,0000 //HP2" + Environment.NewLine +
                "";

            ExportPnach.ExportFile(baseCode);
        }


        public static void WeakPlayerTeam()
        {
            baseCode = "//P1" + Environment.NewLine +
                "patch=1,EE,105A6018,extended,0064 //STK" + Environment.NewLine +
                "patch=1,EE,105A601A,extended,0064 //GRP" + Environment.NewLine +
                "patch=1,EE,105A601C,extended,0064 //RGA" + Environment.NewLine +
                "patch=1,EE,105A601E,extended,0064 //SPA" + Environment.NewLine +
                "patch=1,EE,105A6020,extended,0064 //WPA" + Environment.NewLine +
                "patch=1,EE,105A6022,extended,0064 //TGH" + Environment.NewLine +
                "patch=1,EE,105A5FD2,extended,0032 //HDE" + Environment.NewLine +
                "patch=1,EE,105A5FD8,extended,0019 //HDE Balance" + Environment.NewLine +
                "patch=1,EE,105A5FD4,extended,0032 //UBE" + Environment.NewLine +
                "patch=1,EE,105A5FDA,extended,0019 //UBE Balance" + Environment.NewLine +
                "patch=1,EE,105A5FD6,extended,0032 //LBE" + Environment.NewLine +
                "patch=1,EE,105A5FDC,extended,0019 //LBE Balance" + Environment.NewLine +
                "//P2" + Environment.NewLine +
                "patch=1,EE,105AF768,extended,0064 //STK" + Environment.NewLine +
                "patch=1,EE,105AF76A,extended,0064 //GRP" + Environment.NewLine +
                "patch=1,EE,105AF76C,extended,0064 //RGA" + Environment.NewLine +
                "patch=1,EE,105AF76E,extended,0064 //SPA" + Environment.NewLine +
                "patch=1,EE,105AF770,extended,0064 //WPA" + Environment.NewLine +
                "patch=1,EE,105AF772,extended,0064 //TGH" + Environment.NewLine +
                "patch=1,EE,105AF722,extended,0032 //HDE" + Environment.NewLine +
                "patch=1,EE,105AF728,extended,0019 //HDE Balance" + Environment.NewLine +
                "patch=1,EE,105AF724,extended,0032 //UBE" + Environment.NewLine +
                "patch=1,EE,105AF72A,extended,0019 //UBE Balance" + Environment.NewLine +
                "patch=1,EE,105AF726,extended,0032 //LBE" + Environment.NewLine +
                "patch=1,EE,105AF72C,extended,0019 //LBE Balance" + Environment.NewLine +
                "";

            ExportPnach.ExportFile(baseCode);
        }

        public static void BossShinkaiP3()
        {
            baseCode = "//P3" + Environment.NewLine +
                "patch=1,EE,105B8EB8,extended,03E8 //STK" + Environment.NewLine +
                "patch=1,EE,105B8EBA,extended,03E8 //GRP" + Environment.NewLine +
                "patch=1,EE,105B8EBC,extended,05DC //RGA" + Environment.NewLine +
                "patch=1,EE,105B8EBE,extended,05DC //SPA" + Environment.NewLine +
                "patch=1,EE,105B8EC0,extended,0BB8 //WPA" + Environment.NewLine +
                "patch=1,EE,105B8EC2,extended,05DC //TGH" + Environment.NewLine +
                "patch=1,EE,105B8E72,extended,01F4 //HDE" + Environment.NewLine +
                "patch=1,EE,105B8E78,extended,00FA //HDE Balance" + Environment.NewLine +
                "patch=1,EE,105B8E74,extended,01F4 //UBE" + Environment.NewLine +
                "patch=1,EE,105B8E7A,extended,00FA //UBE Balance" + Environment.NewLine +
                "patch=1,EE,105B8E76,extended,01F4 //LBE" + Environment.NewLine +
                "patch=1,EE,105B8E7C,extended,00FA //LBE Balance" + Environment.NewLine +
                "patch=1,EE,205B8EA2,extended,3F20 //SPA Down Red Bar Color" + Environment.NewLine +
                "patch=1,EE,205B8EA6,extended,3F20 //SPA Down Green Bar Color" + Environment.NewLine +
                "patch=1,EE,205B8EAA,extended,3F80 //SPA Down Blue Bar Color" + Environment.NewLine +
                "patch=1,EE,205B8EAE,extended,3F80 //SPA Down Alpha Bar Color" + Environment.NewLine +
                "patch=1,EE,205B8EB0,extended,0007 //SPA Down" + Environment.NewLine +
                "patch=1,EE,105B8F10,extended,0014 //SPA Regained" + Environment.NewLine +
                "patch=1,EE,205B8E34,extended,00340034 //P3 AI" + Environment.NewLine +
                "//P4" + Environment.NewLine +
                "patch=1,EE,105C2608,extended,03E8 //STK" + Environment.NewLine +
                "patch=1,EE,105C260A,extended,03E8 //GRP" + Environment.NewLine +
                "patch=1,EE,105C260C,extended,03E8 //RGA" + Environment.NewLine +
                "patch=1,EE,105C260E,extended,03E8 //SPA" + Environment.NewLine +
                "patch=1,EE,105C2610,extended,07D0 //WPA" + Environment.NewLine +
                "patch=1,EE,105C2612,extended,03E8 //TGH" + Environment.NewLine +
                "patch=1,EE,105C25C2,extended,00FA //HDE" + Environment.NewLine +
                "patch=1,EE,105C25C8,extended,007D //HDE Balance" + Environment.NewLine +
                "patch=1,EE,105C25C4,extended,00FA //UBE" + Environment.NewLine +
                "patch=1,EE,105C25CA,extended,007D //UBE Balance" + Environment.NewLine +
                "patch=1,EE,105C25C6,extended,00FA //LBE" + Environment.NewLine +
                "patch=1,EE,205C2584,extended,00280028 //P4 AI" + Environment.NewLine +
                "patch=1,EE,105C25CC,extended,007D //LBE Balance" + Environment.NewLine +
                "" + Environment.NewLine +
                "patch=1,EE,2094A648,extended,0E0F0000 //have shinkai katana" + Environment.NewLine +
                "";

            ExportPnach.ExportFile(baseCode);
        }

        public static void ExtremeEnemyTeam()
        {
            baseCode = "//P3" + Environment.NewLine +
                "patch=1,EE,105B8EB8,extended,01F4 //STK" + Environment.NewLine +
                "patch=1,EE,105B8EBA,extended,01F4 //GRP" + Environment.NewLine +
                "patch=1,EE,105B8EBC,extended,01F4 //RGA" + Environment.NewLine +
                "patch=1,EE,105B8EBE,extended,01F4 //SPA" + Environment.NewLine +
                "patch=1,EE,105B8EC0,extended,01F4 //WPA" + Environment.NewLine +
                "patch=1,EE,105B8EC2,extended,0BB8 //TGH" + Environment.NewLine +
                "patch=1,EE,105B8E72,extended,01F4 //HDE" + Environment.NewLine +
                "patch=1,EE,105B8E78,extended,00FA //HDE Balance" + Environment.NewLine +
                "patch=1,EE,105B8E74,extended,01F4 //UBE" + Environment.NewLine +
                "patch=1,EE,105B8E7A,extended,00FA //UBE Balance" + Environment.NewLine +
                "patch=1,EE,105B8E76,extended,01F4 //LBE" + Environment.NewLine +
                "patch=1,EE,105B8E7C,extended,00FA //LBE Balance" + Environment.NewLine +
                "//P4" + Environment.NewLine +
                "patch=1,EE,105C2608,extended,0BB8 //STK" + Environment.NewLine +
                "patch=1,EE,105C260A,extended,07D0 //GRP" + Environment.NewLine +
                "patch=1,EE,105C260C,extended,07D0 //RGA" + Environment.NewLine +
                "patch=1,EE,105C260E,extended,0BB8 //SPA" + Environment.NewLine +
                "patch=1,EE,105C2610,extended,07D0 //WPA" + Environment.NewLine +
                "patch=1,EE,105C2612,extended,012C //TGH" + Environment.NewLine +
                "patch=1,EE,105AF722,extended,0032 //HDE" + Environment.NewLine +
                "patch=1,EE,105AF728,extended,0019 //HDE Balance" + Environment.NewLine +
                "patch=1,EE,105AF724,extended,0032 //UBE" + Environment.NewLine +
                "patch=1,EE,105AF72A,extended,0019 //UBE Balance" + Environment.NewLine +
                "patch=1,EE,105AF726,extended,0032 //LBE" + Environment.NewLine +
                "patch=1,EE,105AF72C,extended,0019 //LBE Balance" + Environment.NewLine +
                "patch=1,EE,105C2BB8,extended,0001 //Auta-Grab" + Environment.NewLine +
                "patch=1,EE,105C2BDA,extended,0000 //Auto-Parry" + Environment.NewLine +
                "patch=1,EE,105C2660,extended,0032 //SPA Regained" + Environment.NewLine +
                "";

            ExportPnach.ExportFile(baseCode);
        }

        public static void StrongPlayerTeam()
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
        public static void HandicapPlayerTeam()
        {
            baseCode = "//P1" + Environment.NewLine +
                "patch=1,EE,D05A5FC8,extended,05DC //HP1" + Environment.NewLine +
                "patch=1,EE,105A5FC8,extended,0177 //HP2" + Environment.NewLine +
                "patch=1,EE,105A5FF2,extended,0000 //SPA_Gauge" + Environment.NewLine +
                "//P2" + Environment.NewLine +
                "patch=1,EE,D05AF718,extended,05DC //HP1" + Environment.NewLine +
                "patch=1,EE,105AF718,extended,0177 //HP2" + Environment.NewLine +
                "patch=1,EE,105AF742,extended,0000 //SPA_Gauge" + Environment.NewLine +
                "//P3" + Environment.NewLine +
                "patch=1,EE,105B8E92,extended,01D0 //SPA_Gauge" + Environment.NewLine +
                "//P4" + Environment.NewLine +
                "patch=1,EE,105C25E2,extended,01D0 //SPA_Gauge" + Environment.NewLine +
                "";

            ExportPnach.ExportFile(baseCode);
        }

        public static void P1God()
        {
            baseCode = "//P1" + Environment.NewLine +
                "patch=1,EE,105A6018,extended,0BB8 //STK" + Environment.NewLine +
                "patch=1,EE,105A601A,extended,0BB8 //GRP" + Environment.NewLine +
                "patch=1,EE,105A601C,extended,0BB8 //RGA" + Environment.NewLine +
                "patch=1,EE,105A601E,extended,0BB8 //SPA" + Environment.NewLine +
                "patch=1,EE,105A6020,extended,0BB8 //WPA" + Environment.NewLine +
                "patch=1,EE,105A6022,extended,0BB8 //TGH" + Environment.NewLine +
                "patch=1,EE,105A5FD2,extended,03E8 //HDE" + Environment.NewLine +
                "patch=1,EE,105A5FD8,extended,01F4 //HDE Balance" + Environment.NewLine +
                "patch=1,EE,105A5FD4,extended,03E8 //UBE" + Environment.NewLine +
                "patch=1,EE,105A5FDA,extended,01F4 //UBE Balance" + Environment.NewLine +
                "patch=1,EE,105A5FD6,extended,03E8 //LBE" + Environment.NewLine +
                "patch=1,EE,105A5FDC,extended,01F4 //LBE Balance" + Environment.NewLine +
                "patch=1,EE,105A65EA,extended,0000 //Auto-Parry" + Environment.NewLine +
                "patch=1,EE,105A5FF2,extended,03E8 //SPA_Gauge" + Environment.NewLine +
                "patch=1,EE,105A5FF6,extended,0000 //SPA Cooldown" + Environment.NewLine +
                "patch=1,EE,205A6002,extended,3F40 //Spa Down Red Bar Color" + Environment.NewLine +
                "patch=1,EE,205A6006,extended,3F40 //Spa Down Green Bar Color" + Environment.NewLine +
                "patch=1,EE,205A600A,extended,3FA0 //Spa Down Blue Bar Color" + Environment.NewLine +
                "patch=1,EE,205A600E,extended,3FA0 //Spa Down Alpha Bar Color" + Environment.NewLine +
                "patch=1,EE,205A6010,extended,0003 //Spa Down" + Environment.NewLine +
                "patch=1,EE,205A6014,extended,44DF8000 //Infinite Spa Down" + Environment.NewLine +
                "";

            ExportPnach.ExportFile(baseCode);
        }

        public static void AutoGuardAll()
        {
            baseCode = "//P1" + Environment.NewLine +
                "patch=1,EE,105A65C8,extended,0001 //Auta-Grab" + Environment.NewLine +
                "patch=1,EE,105A65EA,extended,0000 //Auto-Parry" + Environment.NewLine +
                "patch=1,EE,105A5FF6,extended,0000 //SPA Cooldown" + Environment.NewLine +
                "//P2" + Environment.NewLine +
                "patch=1,EE,105AFD18,extended,0001 //Auta-Grab" + Environment.NewLine +
                "patch=1,EE,105AFD3A,extended,0000 //Auto-Parry" + Environment.NewLine +
                "patch=1,EE,105AF746,extended,0000 //SPA Cooldown" + Environment.NewLine +
                "//P3" + Environment.NewLine +
                "patch=1,EE,105B9468,extended,0001 //Auta-Grab" + Environment.NewLine +
                "patch=1,EE,105B948A,extended,0000 //Auto-Parry" + Environment.NewLine +
                "patch=1,EE,105B8E96,extended,0000 //SPA Cooldown" + Environment.NewLine +
                "//P4" + Environment.NewLine +
                "patch=1,EE,105C2BB8,extended,0001 //Auta-Grab" + Environment.NewLine +
                "patch=1,EE,105C2BDA,extended,0000 //Auto-Parry" + Environment.NewLine +
                "patch=1,EE,105C25E6,extended,0000 //SPA Cooldown" + Environment.NewLine +
                "";

            ExportPnach.ExportFile(baseCode);
        }

        public static void PersonalizedAll()
        {
            baseCode = "//P1" + Environment.NewLine +
                "patch=1,EE,105A6018,extended,03E8 //STK" + Environment.NewLine +
                "patch=1,EE,105A601A,extended,012C //GRP" + Environment.NewLine +
                "patch=1,EE,105A601C,extended,01F4 //RGA" + Environment.NewLine +
                "patch=1,EE,105A601E,extended,0190 //SPA" + Environment.NewLine +
                "patch=1,EE,105A6020,extended,01F4 //WPA" + Environment.NewLine +
                "patch=1,EE,105A6022,extended,03E8 //TGH" + Environment.NewLine +
                "patch=1,EE,105A5FD2,extended,01F4 //HDE" + Environment.NewLine +
                "patch=1,EE,105A5FD8,extended,00FA //HDE Balance" + Environment.NewLine +
                "patch=1,EE,105A5FD4,extended,01F4 //UBE" + Environment.NewLine +
                "patch=1,EE,105A5FDA,extended,00FA //UBE Balance" + Environment.NewLine +
                "patch=1,EE,105A5FD6,extended,01F4 //LBE" + Environment.NewLine +
                "patch=1,EE,105A5FDC,extended,00FA //LBE Balance" + Environment.NewLine +
                "//P2" + Environment.NewLine +
                "patch=1,EE,105AF768,extended,0258 //STK" + Environment.NewLine +
                "patch=1,EE,105AF76A,extended,0384 //GRP" + Environment.NewLine +
                "patch=1,EE,105AF76C,extended,0190 //RGA" + Environment.NewLine +
                "patch=1,EE,105AF76E,extended,0320 //SPA" + Environment.NewLine +
                "patch=1,EE,105AF770,extended,01C2 //WPA" + Environment.NewLine +
                "patch=1,EE,105AF772,extended,0384 //TGH" + Environment.NewLine +
                "patch=1,EE,105AF722,extended,0190 //HDE" + Environment.NewLine +
                "patch=1,EE,105AF728,extended,00C8 //HDE Balance" + Environment.NewLine +
                "patch=1,EE,105AF724,extended,01F4 //UBE" + Environment.NewLine +
                "patch=1,EE,105AF72A,extended,00FA //UBE Balance" + Environment.NewLine +
                "patch=1,EE,105AF726,extended,0190 //LBE" + Environment.NewLine +
                "patch=1,EE,105AF72C,extended,00C8 //LBE Balance" + Environment.NewLine +
                "//P3" + Environment.NewLine +
                "patch=1,EE,105B8EB8,extended,02BC //STK" + Environment.NewLine +
                "patch=1,EE,105B8EBA,extended,01F4 //GRP" + Environment.NewLine +
                "patch=1,EE,105B8EBC,extended,02BC //RGA" + Environment.NewLine +
                "patch=1,EE,105B8EBE,extended,01F4 //SPA" + Environment.NewLine +
                "patch=1,EE,105B8EC0,extended,0258 //WPA" + Environment.NewLine +
                "patch=1,EE,105B8EC2,extended,0320 //TGH" + Environment.NewLine +
                "patch=1,EE,105B8E72,extended,01F4 //HDE" + Environment.NewLine +
                "patch=1,EE,105B8E78,extended,00FA //HDE Balance" + Environment.NewLine +
                "patch=1,EE,105B8E74,extended,01F4 //UBE" + Environment.NewLine +
                "patch=1,EE,105B8E7A,extended,00FA //UBE Balance" + Environment.NewLine +
                "patch=1,EE,105B8E76,extended,0190 //LBE" + Environment.NewLine +
                "patch=1,EE,105B8E7C,extended,00C8 //LBE Balance" + Environment.NewLine +
                "//P4" + Environment.NewLine +
                "patch=1,EE,105C2608,extended,01F4 //STK" + Environment.NewLine +
                "patch=1,EE,105C260A,extended,0190 //GRP" + Environment.NewLine +
                "patch=1,EE,105C260C,extended,02BC //RGA" + Environment.NewLine +
                "patch=1,EE,105C260E,extended,0320 //SPA" + Environment.NewLine +
                "patch=1,EE,105C2610,extended,0258 //WPA" + Environment.NewLine +
                "patch=1,EE,105C2612,extended,0320 //TGH" + Environment.NewLine +
                "patch=1,EE,105C25C2,extended,0190 //HDE" + Environment.NewLine +
                "patch=1,EE,105C25C8,extended,00C8 //HDE Balance" + Environment.NewLine +
                "patch=1,EE,105C25C4,extended,0190 //UBE" + Environment.NewLine +
                "patch=1,EE,105C25CA,extended,00C8 //UBE Balance" + Environment.NewLine +
                "patch=1,EE,105C25C6,extended,00FA //LBE" + Environment.NewLine +
                "patch=1,EE,105C25CC,extended,007D //LBE Balance" + Environment.NewLine +
                "";

            ExportPnach.ExportFile(baseCode);
        }

        public static void SpikedWall()
        {
            baseCode = "//P1" + Environment.NewLine +
                "patch=1,EE,105A6022,extended,1388 //TGH" + Environment.NewLine +
                "patch=1,EE,105A5FEA,extended,07D0 //WALL DMG" + Environment.NewLine +
                "patch=1,EE,105A6070,extended,0022 //SPA Regained" + Environment.NewLine +
                "//P2" + Environment.NewLine +
                "patch=1,EE,105AF772,extended,1388 //TGH" + Environment.NewLine +
                "patch=1,EE,105AF73A,extended,07D0 //WALL DMG" + Environment.NewLine +
                "patch=1,EE,105AF7C0,extended,0022 //SPA Regained" + Environment.NewLine +
                "//P3" + Environment.NewLine +
                "patch=1,EE,105B8EC2,extended,1388 //TGH" + Environment.NewLine +
                "patch=1,EE,105B8E8A,extended,07D0 //WALL DMG" + Environment.NewLine +
                "patch=1,EE,105B8F10,extended,0022 //SPA Regained" + Environment.NewLine +
                "//P4" + Environment.NewLine +
                "patch=1,EE,105C2612,extended,1388 //TGH" + Environment.NewLine +
                "patch=1,EE,105C25DA,extended,07D0 //WALL DMG" + Environment.NewLine +
                "patch=1,EE,105C2660,extended,0022 //SPA Regained" + Environment.NewLine +
                "";

            ExportPnach.ExportFile(baseCode);
        }
        public static void WeakStoryOpponents()
        {
            baseCode = "//E1 (P3)" + Environment.NewLine +
                "patch=1,EE,105B8EB8,extended,0064 //STK" + Environment.NewLine +
                "patch=1,EE,105B8EBA,extended,0064 //GRP" + Environment.NewLine +
                "patch=1,EE,105B8EBC,extended,0064 //RGA" + Environment.NewLine +
                "patch=1,EE,105B8EBE,extended,0064 //SPA" + Environment.NewLine +
                "patch=1,EE,105B8EC0,extended,0064 //WPA" + Environment.NewLine +
                "patch=1,EE,105B8EC2,extended,0064 //TGH" + Environment.NewLine +
                "patch=1,EE,105B8E72,extended,0032 //HDE" + Environment.NewLine +
                "patch=1,EE,105B8E78,extended,0019 //HDE Balance" + Environment.NewLine +
                "patch=1,EE,105B8E74,extended,0032 //UBE" + Environment.NewLine +
                "patch=1,EE,105B8E7A,extended,0019 //UBE Balance" + Environment.NewLine +
                "patch=1,EE,105B8E76,extended,0032 //LBE" + Environment.NewLine +
                "patch=1,EE,105B8E7C,extended,0019 //LBE Balance" + Environment.NewLine +
                "//E2 (P4)" + Environment.NewLine +
                "patch=1,EE,105C2608,extended,0064 //STK" + Environment.NewLine +
                "patch=1,EE,105C260A,extended,0064 //GRP" + Environment.NewLine +
                "patch=1,EE,105C260C,extended,0064 //RGA" + Environment.NewLine +
                "patch=1,EE,105C260E,extended,0064 //SPA" + Environment.NewLine +
                "patch=1,EE,105C2610,extended,0064 //WPA" + Environment.NewLine +
                "patch=1,EE,105C2612,extended,0064 //TGH" + Environment.NewLine +
                "patch=1,EE,105C25C2,extended,0032 //HDE" + Environment.NewLine +
                "patch=1,EE,105C25C8,extended,0019 //HDE Balance" + Environment.NewLine +
                "patch=1,EE,105C25C4,extended,0032 //UBE" + Environment.NewLine +
                "patch=1,EE,105C25CA,extended,0019 //UBE Balance" + Environment.NewLine +
                "patch=1,EE,105C25C6,extended,0032 //LBE" + Environment.NewLine +
                "patch=1,EE,105C25CC,extended,0019 //LBE Balance" + Environment.NewLine +
                "//E3" + Environment.NewLine +
                "patch=1,EE,105CBD58,extended,0064 //STK" + Environment.NewLine +
                "patch=1,EE,105CBD5A,extended,0064 //GRP" + Environment.NewLine +
                "patch=1,EE,105CBD5C,extended,0064 //RGA" + Environment.NewLine +
                "patch=1,EE,105CBD5E,extended,0064 //SPA" + Environment.NewLine +
                "patch=1,EE,105CBD60,extended,0064 //WPA" + Environment.NewLine +
                "patch=1,EE,105CBD62,extended,0064 //TGH" + Environment.NewLine +
                "patch=1,EE,105CBD12,extended,0032 //HDE" + Environment.NewLine +
                "patch=1,EE,105CBD18,extended,0019 //HDE Balance" + Environment.NewLine +
                "patch=1,EE,105CBD14,extended,0032 //UBE" + Environment.NewLine +
                "patch=1,EE,105CBD1A,extended,0019 //UBE Balance" + Environment.NewLine +
                "patch=1,EE,105CBD16,extended,0032 //LBE" + Environment.NewLine +
                "patch=1,EE,105CBD1C,extended,0019 //LBE Balance" + Environment.NewLine +
                "//E4" + Environment.NewLine +
                "patch=1,EE,105D54A8,extended,0064 //STK" + Environment.NewLine +
                "patch=1,EE,105D54AA,extended,0064 //GRP" + Environment.NewLine +
                "patch=1,EE,105D54AC,extended,0064 //RGA" + Environment.NewLine +
                "patch=1,EE,105D54AE,extended,0064 //SPA" + Environment.NewLine +
                "patch=1,EE,105D5450,extended,0064 //WPA" + Environment.NewLine +
                "patch=1,EE,105D5452,extended,0064 //TGH" + Environment.NewLine +
                "patch=1,EE,105D5462,extended,0032 //HDE" + Environment.NewLine +
                "patch=1,EE,105D5468,extended,0019 //HDE Balance" + Environment.NewLine +
                "patch=1,EE,105D5464,extended,0032 //UBE" + Environment.NewLine +
                "patch=1,EE,105D546A,extended,0019 //UBE Balance" + Environment.NewLine +
                "patch=1,EE,105D5466,extended,0032 //LBE" + Environment.NewLine +
                "patch=1,EE,105D546C,extended,0019 //LBE Balance" + Environment.NewLine +
                "";

            ExportPnach.ExportFile(baseCode);
        }
        public static void ClearCodes()
        {
            SettingsClass.codeFilePath = SettingsClass.codeFolderPath + @"\" + SettingsClass.PnachName + ".pnach";

            if (File.Exists(SettingsClass.codeFilePath))
            {
                File.Delete(SettingsClass.codeFilePath);
            }
        }


        public static void SearchValues(string beginAddress, string endAddress, string value)
        {

            int start = Convert.ToInt32(beginAddress, 16);
            int end = Convert.ToInt32(endAddress, 16);
            int code = Convert.ToInt32(value, 16);

            //patch=1,EE,105A5FF2,extended,0000
            //patch=1,EE,105AF768,extended,03E8 //STK

            string j = "";
            string k = "";
            //LIMIT 24564-65534
            int l = 0;
            l = 74;
            baseCode = "";

            k = code.ToString("X");

            if (k.Length == 1)
            {
                k = k.PadLeft(2, '0');
            }
            if (k.Length == 2)
            {
                k = k.PadLeft(3, '0');
            }
            if (k.Length == 3)
            {
                k = k.PadLeft(4, '0');
            }
            if (k.Length == 4)
            {
                k = k.PadLeft(5, '0');
            }
            if (k.Length == 5)
            {
                k = k.PadLeft(6, '0');
            }
            if (k.Length == 6)
            {
                k = k.PadLeft(7, '0');
            }
            if (k.Length == 7)
            {
                k = k.PadLeft(8, '0');
            }


            for (int i = start; i <= end; i += 2)
            {
                j = i.ToString("X");

                if (j.Length == 1)
                {
                    j = j.PadLeft(2, '0');
                }
                if (j.Length == 2)
                {
                    j = j.PadLeft(3, '0');
                }
                if (j.Length == 3)
                {
                    j = j.PadLeft(4, '0');
                }
                if (j.Length == 4)
                {
                    j = j.PadLeft(5, '0');
                }
                if (j.Length == 5)
                {
                    j = j.PadLeft(6, '0');
                }
                if (j.Length == 6)
                {
                    j = j.PadLeft(7, '0');
                }
                if (j.Length == 7)
                {
                    j = j.PadLeft(8, '0');
                }

                baseCode += ("patch=1,EE," + j + ",extended," + k + "\n").ToString();
            }

            ExportPnach.ExportFile(baseCode);
        }

    }
}
