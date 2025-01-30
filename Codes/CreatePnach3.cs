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
using System.Windows.Documents;
using UR_pnach_editor.Services;

namespace UR_pnach_editor.Codes
{
    public class CreatePnach3
    {
        static string baseCode = "";

        public static void ActivateStatsModifier(int STK1, int GRP1, int RGA1, int SPA1, int WPA1,
                                                 int TGH1, int HDE1, int UBE1, int LBE1,
                                                 int STK2, int GRP2, int RGA2, int SPA2, int WPA2,
                                                 int TGH2, int HDE2, int UBE2, int LBE2,
                                                 int STK3, int GRP3, int RGA3, int SPA3, int WPA3,
                                                 int TGH3, int HDE3, int UBE3, int LBE3,
                                                 int STK4, int GRP4, int RGA4, int SPA4, int WPA4,
                                                 int TGH4, int HDE4, int UBE4, int LBE4,
            bool modifyP1, bool modifyP2, bool modifyP3, bool modifyP4)
        {

            string P1_Stats = "";
            string P2_Stats = "";
            string P3_Stats = "";
            string P4_Stats = "";


            if (modifyP1)
            {
                string stk1 = CalculateString(STK1);
                string grp1 = CalculateString(GRP1);
                string rga1 = CalculateString(RGA1);
                string spa1 = CalculateString(SPA1);
                string wpa1 = CalculateString(WPA1);
                string tgh1 = CalculateString(TGH1);
                string hde1 = CalculateString(HDE1 / 2);
                string hdeB1 = CalculateString(HDE1 / 4);
                string ube1 = CalculateString(UBE1 / 2);
                string ubeB1 = CalculateString(UBE1 / 4);
                string lbe1 = CalculateString(LBE1 / 2);
                string lbeB1 = CalculateString(LBE1 / 4);

                P1_Stats = "//P1" + Environment.NewLine +
                    "patch=1,EE,105A6018,extended,0" + stk1 + " //STK" + Environment.NewLine +
                    "patch=1,EE,105A601A,extended,0" + grp1 + " //GRP" + Environment.NewLine +
                    "patch=1,EE,105A601C,extended,0" + rga1 + " //RGA" + Environment.NewLine +
                    "patch=1,EE,105A601E,extended,0" + spa1 + " //SPA" + Environment.NewLine +
                    "patch=1,EE,105A6020,extended,0" + wpa1 + " //WPA" + Environment.NewLine +
                    "patch=1,EE,105A6022,extended,0" + tgh1 + " //TGH" + Environment.NewLine +
                    "patch=1,EE,105A5FD2,extended,0" + hde1 + " //HDE" + Environment.NewLine +
                    "patch=1,EE,105A5FD8,extended,0" + hdeB1 + " //HDE Balance" + Environment.NewLine +
                    "patch=1,EE,105A5FD4,extended,0" + ube1 + " //UBE" + Environment.NewLine +
                    "patch=1,EE,105A5FDA,extended,0" + ubeB1 + " //UBE Balance" + Environment.NewLine +
                    "patch=1,EE,105A5FD6,extended,0" + lbe1 + " //LBE" + Environment.NewLine +
                    "patch=1,EE,105A5FDC,extended,0" + lbeB1 + " //LBE Balance" + Environment.NewLine +
                    "";
            }

            if (modifyP2)
            {
                string stk2 = CalculateString(STK2);
                string grp2 = CalculateString(GRP2);
                string rga2 = CalculateString(RGA2);
                string spa2 = CalculateString(SPA2);
                string wpa2 = CalculateString(WPA2);
                string tgh2 = CalculateString(TGH2);
                string hde2 = CalculateString(HDE2 / 2);
                string hdeB2 = CalculateString(HDE2 / 4);
                string ube2 = CalculateString(UBE2 / 2);
                string ubeB2 = CalculateString(UBE2 / 4);
                string lbe2 = CalculateString(LBE2 / 2);
                string lbeB2 = CalculateString(LBE2 / 4);

                P2_Stats = "//P2" + Environment.NewLine +
                    "patch=1,EE,105AF768,extended,0" + stk2 + " //STK" + Environment.NewLine +
                    "patch=1,EE,105AF76A,extended,0" + grp2 + " //GRP" + Environment.NewLine +
                    "patch=1,EE,105AF76C,extended,0" + rga2 + " //RGA" + Environment.NewLine +
                    "patch=1,EE,105AF76E,extended,0" + spa2 + " //SPA" + Environment.NewLine +
                    "patch=1,EE,105AF770,extended,0" + wpa2 + " //WPA" + Environment.NewLine +
                    "patch=1,EE,105AF772,extended,0" + tgh2 + " //TGH" + Environment.NewLine +
                    "patch=1,EE,105AF722,extended,0" + hde2 + " //HDE" + Environment.NewLine +
                    "patch=1,EE,105AF728,extended,0" + hdeB2 + " //HDE Balance" + Environment.NewLine +
                    "patch=1,EE,105AF724,extended,0" + ube2 + " //UBE" + Environment.NewLine +
                    "patch=1,EE,105AF72A,extended,0" + ubeB2 + " //UBE Balance" + Environment.NewLine +
                    "patch=1,EE,105AF726,extended,0" + lbe2 + " //LBE" + Environment.NewLine +
                    "patch=1,EE,105AF72C,extended,0" + lbeB2 + " //LBE Balance" + Environment.NewLine +
                    "";
            }

            if (modifyP3)
            {
                string stk3 = CalculateString(STK3);
                string grp3 = CalculateString(GRP3);
                string rga3 = CalculateString(RGA3);
                string spa3 = CalculateString(SPA3);
                string wpa3 = CalculateString(WPA3);
                string tgh3 = CalculateString(TGH3);
                string hde3 = CalculateString(HDE3 / 2);
                string hdeB3 = CalculateString(HDE3 / 4);
                string ube3 = CalculateString(UBE3 / 2);
                string ubeB3 = CalculateString(UBE3 / 4);
                string lbe3 = CalculateString(LBE3 / 2);
                string lbeB3 = CalculateString(LBE3 / 4);

                P3_Stats = "//P3" + Environment.NewLine +
                    "patch=1,EE,105B8EB8,extended,0" + stk3 + " //STK" + Environment.NewLine +
                    "patch=1,EE,105B8EBA,extended,0" + grp3 + " //GRP" + Environment.NewLine +
                    "patch=1,EE,105B8EBC,extended,0" + rga3 + " //RGA" + Environment.NewLine +
                    "patch=1,EE,105B8EBE,extended,0" + spa3 + " //SPA" + Environment.NewLine +
                    "patch=1,EE,105B8EC0,extended,0" + wpa3 + " //WPA" + Environment.NewLine +
                    "patch=1,EE,105B8EC2,extended,0" + tgh3 + " //TGH" + Environment.NewLine +
                    "patch=1,EE,105B8E72,extended,0" + hde3 + " //HDE" + Environment.NewLine +
                    "patch=1,EE,105B8E78,extended,0" + hdeB3 + " //HDE Balance" + Environment.NewLine +
                    "patch=1,EE,105B8E74,extended,0" + ube3 + " //UBE" + Environment.NewLine +
                    "patch=1,EE,105B8E7A,extended,0" + ubeB3 + " //UBE Balance" + Environment.NewLine +
                    "patch=1,EE,105B8E76,extended,0" + lbe3 + " //LBE" + Environment.NewLine +
                    "patch=1,EE,105B8E7C,extended,0" + lbeB3 + " //LBE Balance" + Environment.NewLine +
                    "";
            }

            if (modifyP4)
            {
                string stk4 = CalculateString(STK4);
                string grp4 = CalculateString(GRP4);
                string rga4 = CalculateString(RGA4);
                string spa4 = CalculateString(SPA4);
                string wpa4 = CalculateString(WPA4);
                string tgh4 = CalculateString(TGH4);
                string hde4 = CalculateString(HDE4 / 2);
                string hdeB4 = CalculateString(HDE4 / 4);
                string ube4 = CalculateString(UBE4 / 2);
                string ubeB4 = CalculateString(UBE4 / 4);
                string lbe4 = CalculateString(LBE4 / 2);
                string lbeB4 = CalculateString(LBE4 / 4);

                P4_Stats = "//P4" + Environment.NewLine +
                    "patch=1,EE,105C2608,extended,0" + stk4 + " //STK" + Environment.NewLine +
                    "patch=1,EE,105C260A,extended,0" + grp4 + " //GRP" + Environment.NewLine +
                    "patch=1,EE,105C260C,extended,0" + rga4 + " //RGA" + Environment.NewLine +
                    "patch=1,EE,105C260E,extended,0" + spa4 + " //SPA" + Environment.NewLine +
                    "patch=1,EE,105C2610,extended,0" + wpa4 + " //WPA" + Environment.NewLine +
                    "patch=1,EE,105C2612,extended,0" + tgh4 + " //TGH" + Environment.NewLine +
                    "patch=1,EE,105C25C2,extended,0" + hde4 + " //HDE" + Environment.NewLine +
                    "patch=1,EE,105C25C8,extended,0" + hdeB4 + " //HDE Balance" + Environment.NewLine +
                    "patch=1,EE,105C25C4,extended,0" + ube4 + " //UBE" + Environment.NewLine +
                    "patch=1,EE,105C25CA,extended,0" + ubeB4 + " //UBE Balance" + Environment.NewLine +
                    "patch=1,EE,105C25C6,extended,0" + lbe4 + " //LBE" + Environment.NewLine +
                    "patch=1,EE,105C25CC,extended,0" + lbeB4 + " //LBE Balance" + Environment.NewLine +
                    "";
            }


            baseCode = P1_Stats + P2_Stats + P3_Stats + P4_Stats;

            ExportPnach.ExportFile(baseCode);
        }

        public static string CalculateString(int inputValue)
        {
            string outputValue = inputValue.ToString("X");
            if (outputValue.Length == 1)
            {
                outputValue = outputValue.PadLeft(2, '0');
            }
            if (outputValue.Length == 2)
            {
                outputValue = outputValue.PadLeft(3, '0');
            }
            return outputValue;
        }

        public static void UndeadKG()
        {
            baseCode = "//P3" + Environment.NewLine +
                "patch=1,EE,105B8EB8,extended,0240 //STK" + Environment.NewLine +
                "patch=1,EE,105B8EBA,extended,01F4 //GRP" + Environment.NewLine +
                "patch=1,EE,105B8EBC,extended,0204 //RGA" + Environment.NewLine +
                "patch=1,EE,105B8EBE,extended,0222 //SPA" + Environment.NewLine +
                "patch=1,EE,105B8EC0,extended,0140 //WPA" + Environment.NewLine +
                "patch=1,EE,105B8EC2,extended,1388 //TGH" + Environment.NewLine +
                "patch=1,EE,105B8E72,extended,0064 //HDE" + Environment.NewLine +
                "patch=1,EE,105B8E78,extended,0032 //HDE Balance" + Environment.NewLine +
                "patch=1,EE,105B8E74,extended,0064 //UBE" + Environment.NewLine +
                "patch=1,EE,105B8E7A,extended,0032 //UBE Balance" + Environment.NewLine +
                "patch=1,EE,105B8E76,extended,0064 //LBE" + Environment.NewLine +
                "patch=1,EE,105B8E7C,extended,0032 //LBE Balance" + Environment.NewLine +
                "patch=1,EE,205B8EA2,extended,3F80 //SPA Down Red Bar Color" + Environment.NewLine +
                "patch=1,EE,205B8EA6,extended,3F80 //SPA Down Green Bar Color" + Environment.NewLine +
                "patch=1,EE,205B8EAA,extended,3F20 //SPA Down Blue Bar Color" + Environment.NewLine +
                "patch=1,EE,205B8EAE,extended,3F20 //SPA Down Alpha Bar Color" + Environment.NewLine +
                "patch=1,EE,205B8EB0,extended,0001 //SPA Down" + Environment.NewLine +
                "patch=1,EE,205B0044,extended,003E //Moves & Skin 1" + Environment.NewLine +
                "patch=1,EE,205B8E34,extended,003A003A //P3 AI" + Environment.NewLine +
                "patch=1,EE,2094A63C,extended,003E //Moves & Skin 2" + Environment.NewLine +
                "";
            
            ExportPnach.ExportFile(baseCode);
        }

        public static void BojunTeam()
        {
            baseCode = "//P3" + Environment.NewLine +
                "patch=1,EE,105B8EB8,extended,0460 //STK" + Environment.NewLine +
                "patch=1,EE,105B8EBA,extended,0400 //GRP" + Environment.NewLine +
                "patch=1,EE,105B8EBC,extended,03E8 //RGA" + Environment.NewLine +
                "patch=1,EE,105B8EBE,extended,03D0 //SPA" + Environment.NewLine +
                "patch=1,EE,105B8EC0,extended,0200 //WPA" + Environment.NewLine +
                "patch=1,EE,105B8EC2,extended,03B0 //TGH" + Environment.NewLine +
                "patch=1,EE,105B8E72,extended,01A0 //HDE" + Environment.NewLine +
                "patch=1,EE,105B8E78,extended,00D0 //HDE Balance" + Environment.NewLine +
                "patch=1,EE,105B8E74,extended,01F8 //UBE" + Environment.NewLine +
                "patch=1,EE,105B8E7A,extended,00FC //UBE Balance" + Environment.NewLine +
                "patch=1,EE,105B8E76,extended,0160 //LBE" + Environment.NewLine +
                "patch=1,EE,105B8E76,extended,00B0 //LBE Balance" + Environment.NewLine +
                "patch=1,EE,105B8F10,extended,0014 //SPA Regained" + Environment.NewLine +
                "patch=1,EE,205B0044,extended,0019 //Moves & Skin 1" + Environment.NewLine +
                "patch=1,EE,205B8E34,extended,00070007 //P3 AI" + Environment.NewLine +
                "patch=1,EE,2094A63C,extended,0019 //Moves & Skin 2" + Environment.NewLine +
                "//P4" + Environment.NewLine +
                "patch=1,EE,105C2608,extended,03E8 //STK" + Environment.NewLine +
                "patch=1,EE,105C260A,extended,03C8 //GRP" + Environment.NewLine +
                "patch=1,EE,105C260C,extended,0400 //RGA" + Environment.NewLine +
                "patch=1,EE,105C260E,extended,0460 //SPA" + Environment.NewLine +
                "patch=1,EE,105C2610,extended,04A8 //WPA" + Environment.NewLine +
                "patch=1,EE,105C2612,extended,03A0 //TGH" + Environment.NewLine +
                "patch=1,EE,105C25C2,extended,01B8 //HDE" + Environment.NewLine +
                "patch=1,EE,105C25C8,extended,00DC //HDE Balance" + Environment.NewLine +
                "patch=1,EE,105C25C4,extended,01F0 //UBE" + Environment.NewLine +
                "patch=1,EE,105C25CA,extended,00F8 //UBE Balance" + Environment.NewLine +
                "patch=1,EE,105C25C6,extended,0170 //LBE" + Environment.NewLine +
                "patch=1,EE,105C25CC,extended,00B8 //LBE Balance" + Environment.NewLine +
                "patch=1,EE,105C2BDA,extended,0000 //Auto-Parry" + Environment.NewLine +
                "patch=1,EE,205B9794,extended,0034 //Moves & Skin 1" + Environment.NewLine +
                "patch=1,EE,205C2584,extended,00390039 //P4 AI" + Environment.NewLine +
                "patch=1,EE,2094A640,extended,0034 //Moves & Skin 2" + Environment.NewLine +
                "";

            ExportPnach.ExportFile(baseCode);
        }

        public static void BossDanSorin()
        {
            baseCode = "//P3" + Environment.NewLine +
                "patch=1,EE,105B8EB8,extended,07D0 //STK" + Environment.NewLine +
                "patch=1,EE,105B8EBA,extended,03E4 //GRP" + Environment.NewLine +
                "patch=1,EE,105B8EBC,extended,044C //RGA" + Environment.NewLine +
                "patch=1,EE,105B8EBE,extended,0568 //SPA" + Environment.NewLine +
                "patch=1,EE,105B8EC0,extended,0208 //WPA" + Environment.NewLine +
                "patch=1,EE,105B8EC2,extended,0708 //TGH" + Environment.NewLine +
                "patch=1,EE,105B8E72,extended,0172 //HDE" + Environment.NewLine +
                "patch=1,EE,105B8E78,extended,00B9 //HDE Balance" + Environment.NewLine +
                "patch=1,EE,105B8E74,extended,017C //UBE" + Environment.NewLine +
                "patch=1,EE,105B8E7A,extended,00BE //UBE Balance" + Environment.NewLine +
                "patch=1,EE,105B8E76,extended,015E //LBE" + Environment.NewLine +
                "patch=1,EE,105B8E7C,extended,00AF //LBE Balance" + Environment.NewLine +
                "patch=1,EE,205B8EA2,extended,3F80 //SPA Down Red Bar Color" + Environment.NewLine +
                "patch=1,EE,205B8EA6,extended,3F20 //SPA Down Green Bar Color" + Environment.NewLine +
                "patch=1,EE,205B8EAA,extended,3F80 //SPA Down Blue Bar Color" + Environment.NewLine +
                "patch=1,EE,205B8EAE,extended,3F80 //SPA Down Alpha Bar Color" + Environment.NewLine +
                "patch=1,EE,205B8EB0,extended,0006 //SPA Down" + Environment.NewLine +
                "patch=1,EE,205B0044,extended,0002 //Moves & Skin 1" + Environment.NewLine +
                "patch=1,EE,205B8E34,extended,000C000C //P3 AI" + Environment.NewLine +
                "patch=1,EE,2094A63C,extended,0002 //Moves & Skin 2" + Environment.NewLine +
                "//P4" + Environment.NewLine +
                "patch=1,EE,105C2608,extended,0262 //STK" + Environment.NewLine +
                "patch=1,EE,105C260A,extended,07D0 //GRP" + Environment.NewLine +
                "patch=1,EE,105C260C,extended,07D0 //RGA" + Environment.NewLine +
                "patch=1,EE,105C260E,extended,05C8 //SPA" + Environment.NewLine +
                "patch=1,EE,105C2610,extended,012C //WPA" + Environment.NewLine +
                "patch=1,EE,105C2612,extended,0636 //TGH" + Environment.NewLine +
                "patch=1,EE,105C25C2,extended,012C //HDE" + Environment.NewLine +
                "patch=1,EE,105C25C8,extended,0096 //HDE Balance" + Environment.NewLine +
                "patch=1,EE,105C25C4,extended,0159 //UBE" + Environment.NewLine +
                "patch=1,EE,105C25CA,extended,00AC //UBE Balance" + Environment.NewLine +
                "patch=1,EE,105C25C6,extended,016D //LBE" + Environment.NewLine +
                "patch=1,EE,105C25CC,extended,00B6 //LBE Balance" + Environment.NewLine +
                "patch=1,EE,205C25F2,extended,3F80 //SPA Down Red Bar Color" + Environment.NewLine +
                "patch=1,EE,205C25F6,extended,3F20 //SPA Down Green Bar Color" + Environment.NewLine +
                "patch=1,EE,205C25FA,extended,3F80 //SPA Down Blue Bar Color" + Environment.NewLine +
                "patch=1,EE,205C25FE,extended,3F80 //SPA Down Alpha Bar Color" + Environment.NewLine +
                "patch=1,EE,205C2600,extended,0008 //SPA Down" + Environment.NewLine +
                "patch=1,EE,105C2BB8,extended,0001 //Auta-Grab" + Environment.NewLine +
                "patch=1,EE,105C2BDA,extended,0000 //Auto-Parry" + Environment.NewLine +
                "patch=1,EE,105C2660,extended,0013 //SPA Regained" + Environment.NewLine +
                "patch=1,EE,205B9794,extended,0013 //Moves & Skin 1" + Environment.NewLine +
                "patch=1,EE,205C2584,extended,00390039 //P4 AI" + Environment.NewLine +
                "patch=1,EE,2094A640,extended,0013 //Moves & Skin 2" + Environment.NewLine +
                "";

            ExportPnach.ExportFile(baseCode);
        }

        public static void BossFabioNash()
        {
            baseCode = "//P3" + Environment.NewLine +
                "patch=1,EE,105B8EB8,extended,042E //STK" + Environment.NewLine +
                "patch=1,EE,105B8EBA,extended,03F2 //GRP" + Environment.NewLine +
                "patch=1,EE,105B8EBC,extended,05C8 //RGA" + Environment.NewLine +
                "patch=1,EE,105B8EBE,extended,069A //SPA" + Environment.NewLine +
                "patch=1,EE,105B8EC0,extended,012C //WPA" + Environment.NewLine +
                "patch=1,EE,105B8EC2,extended,06AE //TGH" + Environment.NewLine +
                "patch=1,EE,105B8E72,extended,01C2 //HDE" + Environment.NewLine +
                "patch=1,EE,105B8E78,extended,00E1 //HDE Balance" + Environment.NewLine +
                "patch=1,EE,105B8E74,extended,01C2 //UBE" + Environment.NewLine +
                "patch=1,EE,105B8E7A,extended,00E1 //UBE Balance" + Environment.NewLine +
                "patch=1,EE,105B8E76,extended,01D6 //LBE" + Environment.NewLine +
                "patch=1,EE,105B8E7C,extended,00EB //LBE Balance" + Environment.NewLine +
                "patch=1,EE,205B0044,extended,0029 //Moves & Skin 1" + Environment.NewLine +
                "patch=1,EE,2094A63C,extended,0029 //Moves & Skin 2" + Environment.NewLine +
                "//P4" + Environment.NewLine +
                "patch=1,EE,105C2608,extended,04BA //STK" + Environment.NewLine +
                "patch=1,EE,105C260A,extended,0492 //GRP" + Environment.NewLine +
                "patch=1,EE,105C260C,extended,0456 //RGA" + Environment.NewLine +
                "patch=1,EE,105C260E,extended,0438 //SPA" + Environment.NewLine +
                "patch=1,EE,105C2610,extended,03E8 //WPA" + Environment.NewLine +
                "patch=1,EE,105C2612,extended,03E8 //TGH" + Environment.NewLine +
                "patch=1,EE,105C25C2,extended,0221 //HDE" + Environment.NewLine +
                "patch=1,EE,105C25C8,extended,0110 //HDE Balance" + Environment.NewLine +
                "patch=1,EE,105C25C4,extended,0221 //UBE" + Environment.NewLine +
                "patch=1,EE,105C25CA,extended,0110 //UBE Balance" + Environment.NewLine +
                "patch=1,EE,105C25C6,extended,0271 //LBE" + Environment.NewLine +
                "patch=1,EE,105C25CC,extended,0138 //LBE Balance" + Environment.NewLine +
                "patch=1,EE,205C25F2,extended,3F80 //SPA Down Red Bar Color" + Environment.NewLine +
                "patch=1,EE,205C25F6,extended,3F80 //SPA Down Green Bar Color" + Environment.NewLine +
                "patch=1,EE,205C25FA,extended,3F20 //SPA Down Blue Bar Color" + Environment.NewLine +
                "patch=1,EE,205C25FE,extended,3F20 //SPA Down Alpha Bar Color" + Environment.NewLine +
                "patch=1,EE,205C2600,extended,0001 //SPA Down" + Environment.NewLine +
                "patch=1,EE,205B9794,extended,0015 //Moves & Skin 1" + Environment.NewLine +
                "patch=1,EE,2094A640,extended,0015 //Moves & Skin 2" + Environment.NewLine +
                "";

            ExportPnach.ExportFile(baseCode);
        }

        public static void BossUltraInstinctTeam()
        {
            baseCode = "//P3" + Environment.NewLine +
                "patch=1,EE,105B8EB8,extended,044C //STK" + Environment.NewLine +
                "patch=1,EE,105B8EBA,extended,0400 //GRP" + Environment.NewLine +
                "patch=1,EE,105B8EBC,extended,05DC //RGA" + Environment.NewLine +
                "patch=1,EE,105B8EBE,extended,03D0 //SPA" + Environment.NewLine +
                "patch=1,EE,105B8EC0,extended,0410 //WPA" + Environment.NewLine +
                "patch=1,EE,105B8EC2,extended,0420 //TGH" + Environment.NewLine +
                "patch=1,EE,105B8E72,extended,01D0 //HDE" + Environment.NewLine +
                "patch=1,EE,105B8E78,extended,00E8 //HDE Balance" + Environment.NewLine +
                "patch=1,EE,105B8E74,extended,01C0 //UBE" + Environment.NewLine +
                "patch=1,EE,105B8E7A,extended,00E0 //UBE Balance" + Environment.NewLine +
                "patch=1,EE,105B8E76,extended,01B0 //LBE" + Environment.NewLine +
                "patch=1,EE,105B8E7C,extended,00D8 //LBE Balance" + Environment.NewLine +
                "patch=1,EE,105B9468,extended,0001 //Auta-Grab" + Environment.NewLine +
                "patch=1,EE,205B0044,extended,002B //Moves & Skin 1" + Environment.NewLine +
                "patch=1,EE,2094A63C,extended,002B //Moves & Skin 2" + Environment.NewLine +
                "//P4" + Environment.NewLine +
                "patch=1,EE,105C2608,extended,04A0 //STK" + Environment.NewLine +
                "patch=1,EE,105C260A,extended,0350 //GRP" + Environment.NewLine +
                "patch=1,EE,105C260C,extended,0400 //RGA" + Environment.NewLine +
                "patch=1,EE,105C260E,extended,0480 //SPA" + Environment.NewLine +
                "patch=1,EE,105C2610,extended,0460 //WPA" + Environment.NewLine +
                "patch=1,EE,105C2612,extended,03E0 //TGH" + Environment.NewLine +
                "patch=1,EE,105C25C2,extended,01C0 //HDE" + Environment.NewLine +
                "patch=1,EE,105C25C8,extended,00E0 //HDE Balance" + Environment.NewLine +
                "patch=1,EE,105C25C4,extended,01B0 //UBE" + Environment.NewLine +
                "patch=1,EE,105C25CA,extended,00D8 //UBE Balance" + Environment.NewLine +
                "patch=1,EE,105C25C6,extended,01A0 //LBE" + Environment.NewLine +
                "patch=1,EE,105C25CC,extended,00D0 //LBE Balance" + Environment.NewLine +
                "patch=1,EE,105C2BDA,extended,0000 //Auto-Parry" + Environment.NewLine +
                "patch=1,EE,205B9794,extended,0036 //Moves & Skin 1" + Environment.NewLine +
                "patch=1,EE,2094A640,extended,0036 //Moves & Skin 2" + Environment.NewLine +
                "";

            ExportPnach.ExportFile(baseCode);
        }

        public static void BossTheMonsters()
        {
            baseCode = "//P3" + Environment.NewLine +
                "patch=1,EE,105B8EB8,extended,06A4 //STK" + Environment.NewLine +
                "patch=1,EE,105B8EBA,extended,0708 //GRP" + Environment.NewLine +
                "patch=1,EE,105B8EBC,extended,05DC //RGA" + Environment.NewLine +
                "patch=1,EE,105B8EBE,extended,041A //SPA" + Environment.NewLine +
                "patch=1,EE,105B8EC0,extended,0320 //WPA" + Environment.NewLine +
                "patch=1,EE,105B8EC2,extended,07D0 //TGH" + Environment.NewLine +
                "patch=1,EE,105B8E72,extended,01F4 //HDE" + Environment.NewLine +
                "patch=1,EE,105B8E78,extended,00FA //HDE Balance" + Environment.NewLine +
                "patch=1,EE,105B8E74,extended,02BC //UBE" + Environment.NewLine +
                "patch=1,EE,105B8E7A,extended,015E //UBE Balance" + Environment.NewLine +
                "patch=1,EE,105B8E76,extended,0190 //LBE" + Environment.NewLine +
                "patch=1,EE,105B8E7C,extended,00C8 //LBE Balance" + Environment.NewLine +
                "patch=1,EE,205B0044,extended,002D //Moves & Skin 1" + Environment.NewLine +
                "patch=1,EE,205B8E34,extended,000C000C //P3 AI" + Environment.NewLine +
                "patch=1,EE,2094A63C,extended,002D //Moves & Skin 2" + Environment.NewLine +
                "//P4" + Environment.NewLine +
                "patch=1,EE,105C2608,extended,0610 //STK" + Environment.NewLine +
                "patch=1,EE,105C260A,extended,06A0 //GRP" + Environment.NewLine +
                "patch=1,EE,105C260C,extended,0530 //RGA" + Environment.NewLine +
                "patch=1,EE,105C260E,extended,0400 //SPA" + Environment.NewLine +
                "patch=1,EE,105C2610,extended,03E8 //WPA" + Environment.NewLine +
                "patch=1,EE,105C2612,extended,0708 //TGH" + Environment.NewLine +
                "patch=1,EE,105C25C2,extended,01F4 //HDE" + Environment.NewLine +
                "patch=1,EE,105C25C8,extended,00FA //HDE Balance" + Environment.NewLine +
                "patch=1,EE,105C25C4,extended,0226 //UBE" + Environment.NewLine +
                "patch=1,EE,105C25CA,extended,0113 //UBE Balance" + Environment.NewLine +
                "patch=1,EE,105C25C6,extended,01F4 //LBE" + Environment.NewLine +
                "patch=1,EE,105C25CC,extended,00FA //LBE Balance" + Environment.NewLine +
                "patch=1,EE,105C2660,extended,0005 //SPA Regained" + Environment.NewLine +
                "patch=1,EE,205B9794,extended,002C //Moves & Skin 1" + Environment.NewLine +
                "patch=1,EE,205C2584,extended,00350035 //P4 AI" + Environment.NewLine +
                "patch=1,EE,2094A640,extended,002C //Moves & Skin 2" + Environment.NewLine +
                "";

            ExportPnach.ExportFile(baseCode);
        }

        public static void BossWeaponMasters()
        {
            baseCode = "//P3" + Environment.NewLine +
                "patch=1,EE,105B8EB8,extended,03E8 //STK" + Environment.NewLine +
                "patch=1,EE,105B8EBA,extended,03E0 //GRP" + Environment.NewLine +
                "patch=1,EE,105B8EBC,extended,0420 //RGA" + Environment.NewLine +
                "patch=1,EE,105B8EBE,extended,0440 //SPA" + Environment.NewLine +
                "patch=1,EE,105B8EC0,extended,09C4 //WPA" + Environment.NewLine +
                "patch=1,EE,105B8EC2,extended,0600 //TGH" + Environment.NewLine +
                "patch=1,EE,105B8E72,extended,0190 //HDE" + Environment.NewLine +
                "patch=1,EE,105B8E78,extended,00C8 //HDE Balance" + Environment.NewLine +
                "patch=1,EE,105B8E74,extended,0190 //UBE" + Environment.NewLine +
                "patch=1,EE,105B8E7A,extended,00C8 //UBE Balance" + Environment.NewLine +
                "patch=1,EE,105B8E76,extended,0190 //LBE" + Environment.NewLine +
                "patch=1,EE,105B8E7C,extended,00C8 //LBE Balance" + Environment.NewLine +
                "patch=1,EE,205B0044,extended,0035 //Moves & Skin 1" + Environment.NewLine +
                "patch=1,EE,205B8E34,extended,00340034 //P3 AI" + Environment.NewLine +
                "patch=1,EE,2094A63C,extended,0035 //Moves & Skin 2" + Environment.NewLine +
                "//P4" + Environment.NewLine +
                "patch=1,EE,105C2608,extended,0420 //STK" + Environment.NewLine +
                "patch=1,EE,105C260A,extended,03D0 //GRP" + Environment.NewLine +
                "patch=1,EE,105C260C,extended,03B0 //RGA" + Environment.NewLine +
                "patch=1,EE,105C260E,extended,0420 //SPA" + Environment.NewLine +
                "patch=1,EE,105C2610,extended,07D0 //WPA" + Environment.NewLine +
                "patch=1,EE,105C2612,extended,05A0 //TGH" + Environment.NewLine +
                "patch=1,EE,105C25C2,extended,0154 //HDE" + Environment.NewLine +
                "patch=1,EE,105C25C8,extended,00AA //HDE Balance" + Environment.NewLine +
                "patch=1,EE,105C25C4,extended,0154 //UBE" + Environment.NewLine +
                "patch=1,EE,105C25CA,extended,00AA //UBE Balance" + Environment.NewLine +
                "patch=1,EE,105C25C6,extended,0154 //LBE" + Environment.NewLine +
                "patch=1,EE,105C25CC,extended,00AA //LBE Balance" + Environment.NewLine +
                "patch=1,EE,205B9794,extended,0036 //Moves & Skin 1" + Environment.NewLine +
                "patch=1,EE,205C2584,extended,002F002F //P4 AI" + Environment.NewLine +
                "patch=1,EE,2094A640,extended,0036 //Moves & Skin 2" + Environment.NewLine +
                "" + Environment.NewLine +
                "patch=1,EE,2094A648,extended,050F0000 //enemies with weapons" + Environment.NewLine +
                "";

            ExportPnach.ExportFile(baseCode);
        }

        public static void BossTheBest()
        {
            baseCode = "//P3" + Environment.NewLine +
                "patch=1,EE,105B8EB8,extended,03E8 //STK" + Environment.NewLine +
                "patch=1,EE,105B8EBA,extended,03E0 //GRP" + Environment.NewLine +
                "patch=1,EE,105B8EBC,extended,0420 //RGA" + Environment.NewLine +
                "patch=1,EE,105B8EBE,extended,0440 //SPA" + Environment.NewLine +
                "patch=1,EE,105B8EC0,extended,09C4 //WPA" + Environment.NewLine +
                "patch=1,EE,105B8EC2,extended,0600 //TGH" + Environment.NewLine +
                "patch=1,EE,105B8E72,extended,0190 //HDE" + Environment.NewLine +
                "patch=1,EE,105B8E78,extended,00C8 //HDE Balance" + Environment.NewLine +
                "patch=1,EE,105B8E74,extended,0190 //UBE" + Environment.NewLine +
                "patch=1,EE,105B8E7A,extended,00C8 //UBE Balance" + Environment.NewLine +
                "patch=1,EE,105B8E76,extended,0190 //LBE" + Environment.NewLine +
                "patch=1,EE,105B8E7C,extended,00C8 //LBE Balance" + Environment.NewLine +
                "patch=1,EE,105B948A,extended,0000 //Auto-Parry" + Environment.NewLine +
                "patch=1,EE,205B8EA2,extended,3F80 //SPA Down Red Bar Color" + Environment.NewLine +
                "patch=1,EE,205B8EA6,extended,3F20 //SPA Down Green Bar Color" + Environment.NewLine +
                "patch=1,EE,205B8EAA,extended,3F80 //SPA Down Blue Bar Color" + Environment.NewLine +
                "patch=1,EE,205B8EAE,extended,3F80 //SPA Down Alpha Bar Color" + Environment.NewLine +
                "patch=1,EE,205B8EB0,extended,0005 //SPA Down" + Environment.NewLine +
                "patch=1,EE,205B0044,extended,0035 //Moves & Skin 1" + Environment.NewLine +
                "patch=1,EE,2094A63C,extended,0035 //Moves & Skin 2" + Environment.NewLine +
                "//P4" + Environment.NewLine +
                "patch=1,EE,105C2608,extended,06A4 //STK" + Environment.NewLine +
                "patch=1,EE,105C260A,extended,0708 //GRP" + Environment.NewLine +
                "patch=1,EE,105C260C,extended,05DC //RGA" + Environment.NewLine +
                "patch=1,EE,105C260E,extended,041A //SPA" + Environment.NewLine +
                "patch=1,EE,105C2610,extended,0320 //WPA" + Environment.NewLine +
                "patch=1,EE,105C2612,extended,07D0 //TGH" + Environment.NewLine +
                "patch=1,EE,105C25C2,extended,01F4 //HDE" + Environment.NewLine +
                "patch=1,EE,105C25C8,extended,00FA //HDE Balance" + Environment.NewLine +
                "patch=1,EE,105C25C4,extended,02BC //UBE" + Environment.NewLine +
                "patch=1,EE,105C25CA,extended,015E //UBE Balance" + Environment.NewLine +
                "patch=1,EE,105C25C6,extended,0190 //LBE" + Environment.NewLine +
                "patch=1,EE,105C25CC,extended,00C8 //LBE Balance" + Environment.NewLine +
                "patch=1,EE,105C2660,extended,0013 //SPA Regained" + Environment.NewLine +
                "patch=1,EE,205B9794,extended,002D //Moves & Skin 1" + Environment.NewLine +
                "patch=1,EE,2094A640,extended,002D //Moves & Skin 2" + Environment.NewLine +
                "" + Environment.NewLine +
                "patch=1,EE,2094A648,extended,190F1818 //enemies with weapons" + Environment.NewLine +
                "";

            ExportPnach.ExportFile(baseCode);
        }

        public static void WeaponsOnly()
        {
            baseCode = "//P1" + Environment.NewLine +
                "patch=1,EE,105A6018,extended,000A //STK" + Environment.NewLine +
                "patch=1,EE,105A601A,extended,000A //GRP" + Environment.NewLine +
                "patch=1,EE,105A601C,extended,000A //RGA" + Environment.NewLine +
                "patch=1,EE,105A601E,extended,000A //SPA" + Environment.NewLine +
                "patch=1,EE,105A5FEA,extended,0001 //WALL DMG" + Environment.NewLine +
                "patch=1,EE,105A6070,extended,0000 //SPA Regained" + Environment.NewLine +
                "//P2" + Environment.NewLine +
                "patch=1,EE,105AF768,extended,000A //STK" + Environment.NewLine +
                "patch=1,EE,105AF76A,extended,000A //GRP" + Environment.NewLine +
                "patch=1,EE,105AF76C,extended,000A //RGA" + Environment.NewLine +
                "patch=1,EE,105AF76E,extended,000A //SPA" + Environment.NewLine +
                "patch=1,EE,105AF73A,extended,0001 //WALL DMG" + Environment.NewLine +
                "patch=1,EE,105AF7C0,extended,0000 //SPA Regained" + Environment.NewLine +
                "//P3" + Environment.NewLine +
                "patch=1,EE,105B8EB8,extended,000A //STK" + Environment.NewLine +
                "patch=1,EE,105B8EBA,extended,000A //GRP" + Environment.NewLine +
                "patch=1,EE,105B8EBC,extended,000A //RGA" + Environment.NewLine +
                "patch=1,EE,105B8EBE,extended,000A //SPA" + Environment.NewLine +
                "patch=1,EE,105B8E8A,extended,0001 //WALL DMG" + Environment.NewLine +
                "patch=1,EE,105B8F10,extended,0000 //SPA Regained" + Environment.NewLine +
                "//P4" + Environment.NewLine +
                "patch=1,EE,105C2608,extended,000A //STK" + Environment.NewLine +
                "patch=1,EE,105C260A,extended,000A //GRP" + Environment.NewLine +
                "patch=1,EE,105C260C,extended,000A //RGA" + Environment.NewLine +
                "patch=1,EE,105C260E,extended,000A //SPA" + Environment.NewLine +
                "patch=1,EE,105C25DA,extended,0001 //WALL DMG" + Environment.NewLine +
                "patch=1,EE,105C2660,extended,0000 //SPA Regained" + Environment.NewLine +
                "";

            ExportPnach.ExportFile(baseCode);
        }

        public static void TekkenForce()
        {
            baseCode = "//P3" + Environment.NewLine +
                "patch=1,EE,105B8EB8,extended,07D0 //STK" + Environment.NewLine +
                "patch=1,EE,105B8EBA,extended,0620 //GRP" + Environment.NewLine +
                "patch=1,EE,105B8EBC,extended,0600 //RGA" + Environment.NewLine +
                "patch=1,EE,105B8EBE,extended,05B0 //SPA" + Environment.NewLine +
                "patch=1,EE,105B8EC0,extended,03E8 //WPA" + Environment.NewLine +
                "patch=1,EE,105B8EC2,extended,0620 //TGH" + Environment.NewLine +
                "patch=1,EE,105B8E72,extended,0190 //HDE" + Environment.NewLine +
                "patch=1,EE,105B8E78,extended,00C8 //HDE Balance" + Environment.NewLine +
                "patch=1,EE,105B8E74,extended,0190 //UBE" + Environment.NewLine +
                "patch=1,EE,105B8E7A,extended,00C8 //UBE Balance" + Environment.NewLine +
                "patch=1,EE,105B8E76,extended,0190 //LBE" + Environment.NewLine +
                "patch=1,EE,105B8E7C,extended,00C8 //LBE Balance" + Environment.NewLine +
                "patch=1,EE,205B0044,extended,003B //Moves & Skin 1" + Environment.NewLine +
                "patch=1,EE,2094A63C,extended,003B //Moves & Skin 2" + Environment.NewLine +
                "//P4" + Environment.NewLine +
                "patch=1,EE,105C2608,extended,0720 //STK" + Environment.NewLine +
                "patch=1,EE,105C260A,extended,0600 //GRP" + Environment.NewLine +
                "patch=1,EE,105C260C,extended,05C0 //RGA" + Environment.NewLine +
                "patch=1,EE,105C260E,extended,0760 //SPA" + Environment.NewLine +
                "patch=1,EE,105C2610,extended,0440 //WPA" + Environment.NewLine +
                "patch=1,EE,105C2612,extended,05A0 //TGH" + Environment.NewLine +
                "patch=1,EE,105C25C2,extended,0200 //HDE" + Environment.NewLine +
                "patch=1,EE,105C25C8,extended,0100 //HDE Balance" + Environment.NewLine +
                "patch=1,EE,105C25C4,extended,0200 //UBE" + Environment.NewLine +
                "patch=1,EE,105C25CA,extended,0100 //UBE Balance" + Environment.NewLine +
                "patch=1,EE,105C25C6,extended,0200 //LBE" + Environment.NewLine +
                "patch=1,EE,105C25CC,extended,0100 //LBE Balance" + Environment.NewLine +
                "patch=1,EE,205B9794,extended,003C //Moves & Skin 1" + Environment.NewLine +
                "patch=1,EE,2094A640,extended,003C //Moves & Skin 2" + Environment.NewLine +
                "";

            ExportPnach.ExportFile(baseCode);
        }

        public static void GirlsPower()
        {
            baseCode = "//P3" + Environment.NewLine +
                "patch=1,EE,105B8EB8,extended,0456 //STK" + Environment.NewLine +
                "patch=1,EE,105B8EBA,extended,0400 //GRP" + Environment.NewLine +
                "patch=1,EE,105B8EBC,extended,0550 //RGA" + Environment.NewLine +
                "patch=1,EE,105B8EBE,extended,0540 //SPA" + Environment.NewLine +
                "patch=1,EE,105B8EC0,extended,0666 //WPA" + Environment.NewLine +
                "patch=1,EE,105B8EC2,extended,0320 //TGH" + Environment.NewLine +
                "patch=1,EE,105B8E72,extended,017C //HDE" + Environment.NewLine +
                "patch=1,EE,105B8E78,extended,00BE //HDE Balance" + Environment.NewLine +
                "patch=1,EE,105B8E74,extended,01A4 //UBE" + Environment.NewLine +
                "patch=1,EE,105B8E7A,extended,00D2 //UBE Balance" + Environment.NewLine +
                "patch=1,EE,105B8E76,extended,0190 //LBE" + Environment.NewLine +
                "patch=1,EE,105B8E7C,extended,00C8 //LBE Balance" + Environment.NewLine +
                "patch=1,EE,205B8EA2,extended,3F80 //SPA Down Red Bar Color" + Environment.NewLine +
                "patch=1,EE,205B8EA6,extended,3F80 //SPA Down Green Bar Color" + Environment.NewLine +
                "patch=1,EE,205B8EAA,extended,3F20 //SPA Down Blue Bar Color" + Environment.NewLine +
                "patch=1,EE,205B8EAE,extended,3F20 //SPA Down Alpha Bar Color" + Environment.NewLine +
                "patch=1,EE,205B8EB0,extended,0001 //SPA Down" + Environment.NewLine +
                "patch=1,EE,205B0044,extended,001F //Moves & Skin 1" + Environment.NewLine +
                "patch=1,EE,2094A63C,extended,001F //Moves & Skin 2" + Environment.NewLine +
                "//P4" + Environment.NewLine +
                "patch=1,EE,105C2608,extended,0420 //STK" + Environment.NewLine +
                "patch=1,EE,105C260A,extended,0430 //GRP" + Environment.NewLine +
                "patch=1,EE,105C260C,extended,0402 //RGA" + Environment.NewLine +
                "patch=1,EE,105C260E,extended,04E0 //SPA" + Environment.NewLine +
                "patch=1,EE,105C2610,extended,0620 //WPA" + Environment.NewLine +
                "patch=1,EE,105C2612,extended,0280 //TGH" + Environment.NewLine +
                "patch=1,EE,105C25C2,extended,012C //HDE" + Environment.NewLine +
                "patch=1,EE,105C25C8,extended,0096 //HDE Balance" + Environment.NewLine +
                "patch=1,EE,105C25C4,extended,0168 //UBE" + Environment.NewLine +
                "patch=1,EE,105C25CA,extended,00B4 //UBE Balance" + Environment.NewLine +
                "patch=1,EE,105C25C6,extended,012C //LBE" + Environment.NewLine +
                "patch=1,EE,105C25CC,extended,0096 //LBE Balance" + Environment.NewLine +
                "patch=1,EE,105C2BDA,extended,0000 //Auto-Parry" + Environment.NewLine +
                "patch=1,EE,105C2660,extended,0014 //SPA Regained" + Environment.NewLine +
                "patch=1,EE,205B9794,extended,0038 //Moves & Skin 1" + Environment.NewLine +
                "patch=1,EE,2094A640,extended,0038 //Moves & Skin 2" + Environment.NewLine +
                "";

            ExportPnach.ExportFile(baseCode);
        }

        public static void WeakBullets()
        {
            baseCode = "//P1" + Environment.NewLine +
                "patch=1,EE,105A6020,extended,0064 //WPA" + Environment.NewLine +
                "//P2" + Environment.NewLine +
                "patch=1,EE,105AF770,extended,0064 //WPA" + Environment.NewLine +
                "//P3" + Environment.NewLine +
                "patch=1,EE,105B8EC0,extended,0064 //WPA" + Environment.NewLine +
                "//P4" + Environment.NewLine +
                "patch=1,EE,105C2610,extended,0064 //WPA" + Environment.NewLine +
                "//All" + Environment.NewLine +
                "patch=1,EE,2094A648,extended,16161616 //All players have gun" + Environment.NewLine +
                "";

            ExportPnach.ExportFile(baseCode);
        }

        public static void EnemyTeamInstantSPA()
        {
            baseCode = "//P3" + Environment.NewLine +
                "patch=1,EE,105B8F10,extended,00FF //SPA Regained" + Environment.NewLine +
                "//P4" + Environment.NewLine +
                "patch=1,EE,105C2660,extended,00FF //SPA Regained" + Environment.NewLine +
                "";

            ExportPnach.ExportFile(baseCode);
        }

        public static void RandomizeAllUpgraded()
        {
            int rnd = 0;
            int rndWall = 0;
            int rndSpa = 0;
            int rndSpecial = 0;
            int rndSpaInfinite = 0;
            int rndSpaDown = 0;
            int rndInfiniteSpaDown = 0;
            int flychance = 0;
            string random = "";
            string random2 = "";
            int rndSpecial2 = 0;

            List<string> weaponsList = new List<string> { "00", "01", "02", "03", "04", "05", "06", "07", "08", "09", "0A", "0B", "0C", "0D", "0E", "0F",
                "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "1A", "1B", "1C", "1D", "1E", "1F",
                "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "2A", "16", "16" };
            int rndWeapon = 0;
            string p1Weapon = "";
            string p2Weapon = "";
            string p3Weapon = "";
            string p4Weapon = "";

            List<string> aiList = new List<string> { "00040004", "000C000C", "00340034", "002F002F", "00350035", "00070007",
                "003A003A", "00390039", "00330033", "00120012", "00280028", "0004001B", "00110028"};
            int rndAI = 0;

            //int rndTeam = 0;

            List<string> ValuesList = new List<string>();

            for (int i = 0; i <= 83; i++)
            {

                rnd = new Random().Next(10, 2001);
                rndWall = new Random().Next(1, 201);
                rndSpa = new Random().Next(1, 65);
                rndSpecial = new Random().Next(1, 8);//PARRY HIT
                rndSpaInfinite = new Random().Next(1, 21);
                rndSpaDown = new Random().Next(1, 11);
                rndInfiniteSpaDown = new Random().Next(1, 6);
                flychance = new Random().Next(1, 21);
                rndWeapon = new Random().Next(0, 45);
                rndAI = new Random().Next(0, 13);
                rndSpecial2 = new Random().Next(1, 8);//PARRY GRAB
                //rndTeam = new Random().Next(0, 4);

                if (i < 24)
                {
                    random = rnd.ToString("X");
                }
                else if (i >= 24 && i <= 35)
                {
                    random = (rnd / 2).ToString("X");
                    random2 = (rnd / 4).ToString("X");
                }
                else if (i >= 36 && i <= 39)
                {
                    random = rndWall.ToString("X");
                }
                else if (i >= 40 && i <= 43)
                {
                    random = rndSpa.ToString("X");
                }
                else if (i >= 44 && i <= 51)//AUTO PARRY
                {
                    if (rndSpecial < 7 )
                    {
                        random = "//";
                    }
                    else if (rndSpecial == 7)
                    {
                        random = "";
                    }
                }
                else if (i >= 52 && i <= 55)
                {
                    if (rndSpaInfinite == 1)
                    {
                        ValuesList.Add("");
                        ValuesList.Add("03E8");
                    }
                    else if (rndSpaInfinite == 2)
                    {
                        ValuesList.Add("");
                        ValuesList.Add("0000");
                    }
                    else if (rndSpaInfinite >= 3)
                    {
                        ValuesList.Add("//");
                        ValuesList.Add("XXXX");
                    }
                }
                else if (i >= 56 && i <= 59)
                {
                    switch (rndSpaDown)
                    {
                        case 0:
                            ValuesList.Add("");
                            ValuesList.Add("88800");
                            break;
                        case 1:
                            ValuesList.Add("");
                            ValuesList.Add("88221");
                            break;
                        case 2:
                            ValuesList.Add("");
                            ValuesList.Add("82222");
                            break;
                        case 3:
                            ValuesList.Add("");
                            ValuesList.Add("22883");
                            break;
                        case 4:
                            ValuesList.Add("");
                            ValuesList.Add("28224");
                            break;
                        case 5:
                            ValuesList.Add("");
                            ValuesList.Add("82885");
                            break;
                        case 6:
                            ValuesList.Add("");
                            ValuesList.Add("82886");
                            break;
                        case 7:
                            ValuesList.Add("");
                            ValuesList.Add("82887");
                            break;
                        case 8:
                            ValuesList.Add("");
                            ValuesList.Add("82888");
                            break;
                        case 9:
                            ValuesList.Add("//");
                            ValuesList.Add("XXXXX");
                            break;
                        case 10:
                            ValuesList.Add("//");
                            ValuesList.Add("XXXXX");
                            break;
                    }
                }
                else if (i >= 60 && i <= 63)//Infinite Spa
                {
                    if (rndInfiniteSpaDown == 1)
                    {
                        ValuesList.Add("");
                    }
                    else
                    {
                        ValuesList.Add("//");
                    }
                }
                else if (i >= 64 && i <= 67)//Nimbus
                {
                    if (flychance == 1)
                    {
                        ValuesList.Add("");
                    }
                    else
                    {
                        ValuesList.Add("//");
                    }
                }
                else if (i >= 68 && i <= 71)//Weapons
                {
                    switch (i)
                    {
                        case 68:
                            p1Weapon = weaponsList[rndWeapon];
                            break;
                        case 69:
                            p2Weapon = weaponsList[rndWeapon];
                            break;
                        case 70:
                            p3Weapon = weaponsList[rndWeapon];
                            break;
                        case 71:
                            p4Weapon = weaponsList[rndWeapon];
                            ValuesList.Add(p4Weapon + p3Weapon + p2Weapon + p1Weapon);
                            break;
                    }
                }
                else if (i >= 72 && i <= 75)//AI
                {
                    switch (i)
                    {
                        case 72:
                            if (p1Weapon == "16")//Bordin gun
                            {
                                ValuesList.Add(aiList[0]);
                            }
                            else
                            {
                                if (rndAI == 0) { rndAI = 1; }
                                ValuesList.Add(aiList[rndAI]);
                            }
                            break;
                        case 73:
                            if (p2Weapon == "16")
                            {
                                ValuesList.Add(aiList[0]);
                            }
                            else
                            {
                                if (rndAI == 0) { rndAI = 1; }
                                ValuesList.Add(aiList[rndAI]);
                            }
                            break;
                        case 74:
                            if (p3Weapon == "16")
                            {
                                ValuesList.Add(aiList[0]);
                            }
                            else
                            {
                                if (rndAI == 0) { rndAI = 1; }
                                ValuesList.Add(aiList[rndAI]);
                            }
                            break;
                        case 75:
                            if (p4Weapon == "16")
                            {
                                ValuesList.Add(aiList[0]);
                            }
                            else
                            {
                                if (rndAI == 0) { rndAI = 1; }
                                ValuesList.Add(aiList[rndAI]);
                            }
                            break;
                    }
                }
                else if (i >= 76 && i <= 83)//AUTO PARRY
                {
                    if (rndSpecial2 < 7)
                    {
                        ValuesList.Add("//");
                    }
                    else if (rndSpecial2 == 7)
                    {
                        ValuesList.Add("");
                    }
                }
                //else if (i >= 76 && i <= 79)//Team
                //{
                //    ValuesList.Add("0000000" + rndTeam);
                //}
                //ADD HERE NEXT

                if (i<= 43)
                {
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
                }

                if (i <= 51)
                {
                    ValuesList.Add(random);
                    if (i >= 24 && i <= 35)
                    {
                        ValuesList.Add(random2);
                    }
                }


            }

            string nothing = "";

            baseCode = "//P1" + Environment.NewLine +
                "" + ValuesList[60] + "patch=1,EE,1059C8A6,extended,0000 //SPA Cooldown" + Environment.NewLine +
                "patch=1,EE,105A5FD2,extended," + ValuesList[24] + " //HDE" + Environment.NewLine +
                "patch=1,EE,105A5FD8,extended," + ValuesList[25] + " //HDE Balance" + Environment.NewLine +
                "patch=1,EE,105A5FD4,extended," + ValuesList[26] + " //UBE" + Environment.NewLine +
                "patch=1,EE,105A5FDA,extended," + ValuesList[27] + " //UBE Balance" + Environment.NewLine +
                "patch=1,EE,105A5FD6,extended," + ValuesList[28] + " //LBE" + Environment.NewLine +
                "patch=1,EE,105A5FDC,extended," + ValuesList[29] + " //LBE Balance" + Environment.NewLine +
                "patch=1,EE,105A5FEA,extended," + ValuesList[48] + " //WALL DMG" + Environment.NewLine +
                "" + ValuesList[64] + "patch=1,EE,105A5FF2,extended," + ValuesList[65] + " //Infinite or No SPA" + Environment.NewLine +
                "patch=1,EE,105A6018,extended," + ValuesList[0] + " //STK" + Environment.NewLine +
                "patch=1,EE,105A601A,extended," + ValuesList[1] + " //GRP" + Environment.NewLine +
                "patch=1,EE,105A601C,extended," + ValuesList[2] + " //RGA" + Environment.NewLine +
                "patch=1,EE,105A601E,extended," + ValuesList[3] + " //SPA" + Environment.NewLine +
                "patch=1,EE,105A6020,extended," + ValuesList[4] + " //WPA" + Environment.NewLine +
                "patch=1,EE,105A6022,extended," + ValuesList[5] + " //TGH" + Environment.NewLine +
                "patch=1,EE,105A6070,extended," + ValuesList[52] + " //SPA Regained" + Environment.NewLine +
                "" + ValuesList[93] + "patch=1,EE,105A65C8,extended,0001 //Auta-Grab" + Environment.NewLine +
                "" + ValuesList[56] + "patch=1,EE,105A65EA,extended,0000 //Auto-Parry" + Environment.NewLine +
                "//P2" + Environment.NewLine +
                "" + ValuesList[61] + "patch=1,EE,105A5FF6,extended,0000 //SPA Cooldown" + Environment.NewLine +
                "patch=1,EE,105AF722,extended," + ValuesList[30] + " //HDE" + Environment.NewLine +
                "patch=1,EE,105AF728,extended," + ValuesList[31] + " //HDE Balance" + Environment.NewLine +
                "patch=1,EE,105AF724,extended," + ValuesList[32] + " //UBE" + Environment.NewLine +
                "patch=1,EE,105AF72A,extended," + ValuesList[33] + " //UBE Balance" + Environment.NewLine +
                "patch=1,EE,105AF726,extended," + ValuesList[34] + " //LBE" + Environment.NewLine +
                "patch=1,EE,105AF72C,extended," + ValuesList[35] + " //LBE Balance" + Environment.NewLine +
                "patch=1,EE,105AF73A,extended," + ValuesList[49] + " //WALL DMG" + Environment.NewLine +
                "" + ValuesList[66] + "patch=1,EE,105AF742,extended," + ValuesList[67] + " //Infinite or No SPA" + Environment.NewLine +
                "patch=1,EE,105AF768,extended," + ValuesList[6] + " //STK" + Environment.NewLine +
                "patch=1,EE,105AF76A,extended," + ValuesList[7] + " //GRP" + Environment.NewLine +
                "patch=1,EE,105AF76C,extended," + ValuesList[8] + " //RGA" + Environment.NewLine +
                "patch=1,EE,105AF76E,extended," + ValuesList[9] + " //SPA" + Environment.NewLine +
                "patch=1,EE,105AF770,extended," + ValuesList[10] + " //WPA" + Environment.NewLine +
                "patch=1,EE,105AF772,extended," + ValuesList[11] + " //TGH" + Environment.NewLine +
                "patch=1,EE,105AF7C0,extended," + ValuesList[53] + " //SPA Regained" + Environment.NewLine +
                "" + ValuesList[94] + "patch=1,EE,105AFD18,extended,0001 //Auta-Grab" + Environment.NewLine +
                "" + ValuesList[57] + "patch=1,EE,105AFD3A,extended,0000 //Auto-Parry" + Environment.NewLine +
                "//P3" + Environment.NewLine +
                "" + ValuesList[62] + "patch=1,EE,105AF746,extended,0000 //SPA Cooldown" + Environment.NewLine +
                "patch=1,EE,105B8E72,extended," + ValuesList[36] + " //HDE" + Environment.NewLine +
                "patch=1,EE,105B8E78,extended," + ValuesList[37] + " //HDE Balance" + Environment.NewLine +
                "patch=1,EE,105B8E74,extended," + ValuesList[38] + " //UBE" + Environment.NewLine +
                "patch=1,EE,105B8E7A,extended," + ValuesList[39] + " //UBE Balance" + Environment.NewLine +
                "patch=1,EE,105B8E76,extended," + ValuesList[40] + " //LBE" + Environment.NewLine +
                "patch=1,EE,105B8E7C,extended," + ValuesList[41] + " //LBE Balance" + Environment.NewLine +
                "patch=1,EE,105B8E8A,extended," + ValuesList[50] + " //WALL DMG" + Environment.NewLine +
                "" + ValuesList[68] + "patch=1,EE,105B8E92,extended," + ValuesList[69] + " //Infinite or No SPA" + Environment.NewLine +
                "patch=1,EE,105B8EB8,extended," + ValuesList[12] + " //STK" + Environment.NewLine +
                "patch=1,EE,105B8EBA,extended," + ValuesList[13] + " //GRP" + Environment.NewLine +
                "patch=1,EE,105B8EBC,extended," + ValuesList[14] + " //RGA" + Environment.NewLine +
                "patch=1,EE,105B8EBE,extended," + ValuesList[15] + " //SPA" + Environment.NewLine +
                "patch=1,EE,105B8EC0,extended," + ValuesList[16] + " //WPA" + Environment.NewLine +
                "patch=1,EE,105B8EC2,extended," + ValuesList[17] + " //TGH" + Environment.NewLine +
                "patch=1,EE,105B8F10,extended," + ValuesList[54] + " //SPA Regained" + Environment.NewLine +
                "" + ValuesList[95] + "patch=1,EE,105B9468,extended,0001 //Auta-Grab" + Environment.NewLine +
                "" + ValuesList[58] + "patch=1,EE,105B948A,extended,0000 //Auto-Parry" + Environment.NewLine +
                "//P4" + Environment.NewLine +
                "" + ValuesList[63] + "patch=1,EE,105B8E96,extended,0000 //SPA Cooldown" + Environment.NewLine +
                "patch=1,EE,105C25C2,extended," + ValuesList[42] + " //HDE" + Environment.NewLine +
                "patch=1,EE,105C25C8,extended," + ValuesList[43] + " //HDE Balance" + Environment.NewLine +
                "patch=1,EE,105C25C4,extended," + ValuesList[44] + " //UBE" + Environment.NewLine +
                "patch=1,EE,105C25CA,extended," + ValuesList[45] + " //UBE Balance" + Environment.NewLine +
                "patch=1,EE,105C25C6,extended," + ValuesList[46] + " //LBE" + Environment.NewLine +
                "patch=1,EE,105C25CC,extended," + ValuesList[47] + " //LBE Balance" + Environment.NewLine +
                "patch=1,EE,105C25DA,extended," + ValuesList[51] + " //WALL DMG" + Environment.NewLine +
                "" + ValuesList[70] + "patch=1,EE,105C25E2,extended," + ValuesList[71] + " //Infinite or No SPA" + Environment.NewLine +
                "patch=1,EE,105C2608,extended," + ValuesList[18] + " //STK" + Environment.NewLine +
                "patch=1,EE,105C260A,extended," + ValuesList[19] + " //GRP" + Environment.NewLine +
                "patch=1,EE,105C260C,extended," + ValuesList[20] + " //RGA" + Environment.NewLine +
                "patch=1,EE,105C260E,extended," + ValuesList[21] + " //SPA" + Environment.NewLine +
                "patch=1,EE,105C2610,extended," + ValuesList[22] + " //WPA" + Environment.NewLine +
                "patch=1,EE,105C2612,extended," + ValuesList[23] + " //TGH" + Environment.NewLine +
                "patch=1,EE,105C2660,extended," + ValuesList[55] + " //SPA Regained" + Environment.NewLine +
                "" + ValuesList[96] + "patch=1,EE,105C2BB8,extended,0001 //Auta-Grab" + Environment.NewLine +
                "" + ValuesList[59] + "patch=1,EE,105C2BDA,extended,0000 //Auto-Parry" + Environment.NewLine +
                "//P1" + Environment.NewLine +
                "" + ValuesList[84] + "patch=1,EE,205A5A50,extended,40400000 //Y pos" + Environment.NewLine +
                //"patch=1,EE,205A5F16,extended," + ValuesList[93] + " //Team" + Environment.NewLine +
                "patch=1,EE,205A5F94,extended," + ValuesList[89] + " //AI" + Environment.NewLine +
                "" + ValuesList[72] + "patch=1,EE,205A6002,extended,3F" + ValuesList[73][0] + "0 //Spa Down Red Bar Color" + Environment.NewLine +
                "" + ValuesList[72] + "patch=1,EE,205A6006,extended,3F" + ValuesList[73][1] + "0 //Spa Down Green Bar Color" + Environment.NewLine +
                "" + ValuesList[72] + "patch=1,EE,205A600A,extended,3F" + ValuesList[73][2] + "0 //Spa Down Blue Bar Color" + Environment.NewLine +
                "" + ValuesList[72] + "patch=1,EE,205A600E,extended,3F" + ValuesList[73][3] + "0 //Spa Down Alpha Bar Color" + Environment.NewLine +
                "" + ValuesList[72] + "patch=1,EE,205A6010,extended,000" + ValuesList[73][4] + " //Spa Down" + Environment.NewLine +
                "" + ValuesList[80] + "patch=1,EE,205A6014,extended,44DF8000 //Infinite Spa Down" + Environment.NewLine +
                "//P2" + Environment.NewLine +
                "" + ValuesList[85] + "patch=1,EE,205AF1A0,extended,40400000 //Y pos" + Environment.NewLine +
                //"patch=1,EE,205AF666,extended," + ValuesList[94] + " //Team" + Environment.NewLine +
                "patch=1,EE,205AF6E4,extended," + ValuesList[90] + " //AI" + Environment.NewLine +
                "" + ValuesList[74] + "patch=1,EE,205AF752,extended,3F" + ValuesList[75][0] + "0 //Spa Down Red Bar Color" + Environment.NewLine +
                "" + ValuesList[74] + "patch=1,EE,205AF756,extended,3F" + ValuesList[75][1] + "0 //Spa Down Green Bar Color" + Environment.NewLine +
                "" + ValuesList[74] + "patch=1,EE,205AF75A,extended,3F" + ValuesList[75][2] + "0 //Spa Down Blue Bar Color" + Environment.NewLine +
                "" + ValuesList[74] + "patch=1,EE,205AF75E,extended,3F" + ValuesList[75][3] + "0 //Spa Down Alpha Bar Color" + Environment.NewLine +
                "" + ValuesList[74] + "patch=1,EE,205AF760,extended,000" + ValuesList[75][4] + " //Spa Down" + Environment.NewLine +
                "" + ValuesList[81] + "patch=1,EE,205AF764,extended,44DF8000 //Infinite Spa Down" + Environment.NewLine +
                "//P3" + Environment.NewLine +
                "" + ValuesList[86] + "patch=1,EE,205B88F0,extended,40400000 //Y pos" + Environment.NewLine +
                //"patch=1,EE,205B8DB6,extended," + ValuesList[95] + " //Team" + Environment.NewLine +
                "patch=1,EE,205B8E34,extended," + ValuesList[91] + " //AI" + Environment.NewLine +
                "" + ValuesList[76] + "patch=1,EE,205B8EA2,extended,3F" + ValuesList[77][0] + "0 //Spa Down Red Bar Color" + Environment.NewLine +
                "" + ValuesList[76] + "patch=1,EE,205B8EA6,extended,3F" + ValuesList[77][1] + "0 //Spa Down Red Green Color" + Environment.NewLine +
                "" + ValuesList[76] + "patch=1,EE,205B8EAA,extended,3F" + ValuesList[77][2] + "0 //Spa Down Red Blue Color" + Environment.NewLine +
                "" + ValuesList[76] + "patch=1,EE,205B8EAE,extended,3F" + ValuesList[77][3] + "0 //Spa Down Red Alpha Color" + Environment.NewLine +
                "" + ValuesList[76] + "patch=1,EE,205B8EB0,extended,000" + ValuesList[77][4] + " //Spa Down" + Environment.NewLine +
                "" + ValuesList[82] + "patch=1,EE,205B8EB4,extended,44DF8000 //Infinite Spa Down" + Environment.NewLine +
                "//P4" + Environment.NewLine +
                "" + ValuesList[87] + "patch=1,EE,205C2040,extended,40400000 //Y pos" + Environment.NewLine +
                //"patch=1,EE,205C2506,extended," + ValuesList[96] + " //Team" + Environment.NewLine +
                "patch=1,EE,205C2584,extended," + ValuesList[92] + " //AI" + Environment.NewLine +
                "" + ValuesList[78] + "patch=1,EE,205C25F2,extended,3F" + ValuesList[79][0] + "0 //Spa Down Red Bar Color" + Environment.NewLine +
                "" + ValuesList[78] + "patch=1,EE,205C25F6,extended,3F" + ValuesList[79][1] + "0 //Spa Down Red Green Color" + Environment.NewLine +
                "" + ValuesList[78] + "patch=1,EE,205C25FA,extended,3F" + ValuesList[79][2] + "0 //Spa Down Red Blue Color" + Environment.NewLine +
                "" + ValuesList[78] + "patch=1,EE,205C25FE,extended,3F" + ValuesList[79][3] + "0 //Spa Down Red Alpha Color" + Environment.NewLine +
                "" + ValuesList[78] + "patch=1,EE,205C2600,extended,000" + ValuesList[79][4] + " //Spa Down" + Environment.NewLine +
                "" + ValuesList[83] + "patch=1,EE,205C2604,extended,44DF8000 //Infinite Spa Down" + Environment.NewLine +
                "//ALL" + Environment.NewLine +
                "patch=1,EE,2094A648,extended," + ValuesList[88] + " //Weapons" + Environment.NewLine +
                "";

            ExportPnach.ExportFile(baseCode);
        }

        public static void OneHitBoss()
        {
            baseCode = "//P3" + Environment.NewLine +
                "patch=1,EE,105B8EB8,extended,FFFF//STK" + Environment.NewLine +
                "patch=1,EE,105B8EBA,extended,FFFF //GRP" + Environment.NewLine +
                "patch=1,EE,105B8EBC,extended,FFFF //RGA" + Environment.NewLine +
                "patch=1,EE,105B8EBE,extended,FFFF //SPA" + Environment.NewLine +
                "patch=1,EE,105B8EC0,extended,FFFF //WPA" + Environment.NewLine +
                "patch=1,EE,105B8EC2,extended,0258 //TGH" + Environment.NewLine +
                "patch=1,EE,105B8E72,extended,01F4 //HDE" + Environment.NewLine +
                "patch=1,EE,105B8E78,extended,00FA //HDE Balance" + Environment.NewLine +
                "patch=1,EE,105B8E74,extended,01F4 //UBE" + Environment.NewLine +
                "patch=1,EE,105B8E7A,extended,00FA //UBE Balance" + Environment.NewLine +
                "patch=1,EE,105B8E76,extended,01F4 //LBE" + Environment.NewLine +
                "patch=1,EE,105B8E7C,extended,00FA //LBE Balance" + Environment.NewLine +
                "patch=1,EE,205B8E34,extended,00120012 //p3 ai" + Environment.NewLine +
                "";

            ExportPnach.ExportFile(baseCode);
        }

        public static void KadonashiBoss()
        {
            baseCode = "//P3" + Environment.NewLine +
                "patch=1,EE,105B8EB8,extended,03E8 //STK" + Environment.NewLine +
                "patch=1,EE,105B8EBA,extended,03E8 //GRP" + Environment.NewLine +
                "patch=1,EE,105B8EBC,extended,03E8 //RGA" + Environment.NewLine +
                "patch=1,EE,105B8EBE,extended,03E8 //SPA" + Environment.NewLine +
                "patch=1,EE,105B8EC0,extended,03E8 //WPA" + Environment.NewLine +
                "patch=1,EE,105B8EC2,extended,03E8 //TGH" + Environment.NewLine +
                "patch=1,EE,105B8E72,extended,01F4 //HDE" + Environment.NewLine +
                "patch=1,EE,105B8E78,extended,00FA //HDE Balance" + Environment.NewLine +
                "patch=1,EE,105B8E74,extended,01F4 //UBE" + Environment.NewLine +
                "patch=1,EE,105B8E7A,extended,00FA //UBE Balance" + Environment.NewLine +
                "patch=1,EE,105B8E76,extended,01F4 //LBE" + Environment.NewLine +
                "patch=1,EE,105B8E7C,extended,00FA //LBE Balance" + Environment.NewLine +
                "patch=1,EE,205B8EA2,extended,3F80 //SPA Down Red Bar Color" + Environment.NewLine +
                "patch=1,EE,205B8EA6,extended,3F20 //SPA Down Green Bar Color" + Environment.NewLine +
                "patch=1,EE,205B8EAA,extended,3F80 //SPA Down Blue Bar Color" + Environment.NewLine +
                "patch=1,EE,205B8EAE,extended,3F80 //SPA Down Alpha Bar Color" + Environment.NewLine +
                "patch=1,EE,205B8EB0,extended,0007 //SPA Down" + Environment.NewLine +
                "patch=1,EE,205B8EB4,extended,44DF8000 //Infinite SPA Down" + Environment.NewLine +
                "patch=1,EE,205B0044,extended,000F //Moves & Skin 1" + Environment.NewLine +
                "patch=1,EE,2094A63C,extended,000F //Moves & Skin 2" + Environment.NewLine +
                "";

            ExportPnach.ExportFile(baseCode);
        }
    }
}
