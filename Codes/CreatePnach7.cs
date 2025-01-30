using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UR_pnach_editor.Services;
using System.IO;
using Newtonsoft.Json.Linq;
using OfficeOpenXml.FormulaParsing.Excel.Functions.Engineering;
using System.DirectoryServices;
using System.Drawing;
using System.Windows.Documents;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Numerics;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace UR_pnach_editor.Codes
{
    public class CreatePnach7
    {
        static string baseCode = "";


        public static void x2PlayersFullFreeMode()
        {
            SettingsClass.codeFilePath = SettingsClass.codeFolderPath + @"\" + SettingsClass.PnachName + ".pnach";

            if (File.Exists(SettingsClass.codeFilePath))
            {
                File.Delete(SettingsClass.codeFilePath);
            }

            string pnachPatch = SettingsClass.missionFolderPath.Substring(0, SettingsClass.missionFolderPath.Length - 14) +
                @"\Big_Pnaches\2_Players_Full_Free_Mode.pnach";


            File.Copy(pnachPatch, SettingsClass.codeFilePath);

        }

        public static void x3PlayersFullFreeMode()
        {
            SettingsClass.codeFilePath = SettingsClass.codeFolderPath + @"\" + SettingsClass.PnachName + ".pnach";

            if (File.Exists(SettingsClass.codeFilePath))
            {
                File.Delete(SettingsClass.codeFilePath);
            }

            string pnachPatch = SettingsClass.missionFolderPath.Substring(0, SettingsClass.missionFolderPath.Length - 14) +
                @"\Big_Pnaches\3_Players_Full_Free_Mode.pnach";


            File.Copy(pnachPatch, SettingsClass.codeFilePath);
        }

        public static void x4PlayersFullFreeMode()
        {
            SettingsClass.codeFilePath = SettingsClass.codeFolderPath + @"\" + SettingsClass.PnachName + ".pnach";

            if (File.Exists(SettingsClass.codeFilePath))
            {
                File.Delete(SettingsClass.codeFilePath);
            }

            string pnachPatch = SettingsClass.missionFolderPath.Substring(0, SettingsClass.missionFolderPath.Length - 14) +
                @"\Big_Pnaches\4_Players_Full_Free_Mode.pnach";


            File.Copy(pnachPatch, SettingsClass.codeFilePath);
        }

        public static void BradsDeluxeOffensive()
        {
            baseCode = "//" + Environment.NewLine +
            "//P1" + Environment.NewLine +
            "patch=1,EE,D059D1A4,extended,06010000 //Moves & Skin Brad" + Environment.NewLine +
            "patch=1,EE,D05A6014,extended,05000000 // If P1 SPA is not activated" + Environment.NewLine +
            "patch=1,EE,105A6018,extended,03B6 //STK" + Environment.NewLine +
            "patch=1,EE,105A601A,extended,0352 //GRP" + Environment.NewLine +
            "patch=1,EE,105A601C,extended,0352 //RGA" + Environment.NewLine +
            "patch=1,EE,105A601E,extended,0384 //SPA" + Environment.NewLine +
            "patch=1,EE,105A6020,extended,0320 //WPA" + Environment.NewLine +
            "" + Environment.NewLine +
            "patch=1,EE,D059D1A4,extended,06010000 //Moves & Skin Brad" + Environment.NewLine +
            "patch=1,EE,D05A6014,extended,05100000 // If P1 SPA is activated" + Environment.NewLine +
            "patch=1,EE,105A6018,extended,0578 //STK" + Environment.NewLine +
            "patch=1,EE,105A601A,extended,044C //GRP" + Environment.NewLine +
            "patch=1,EE,105A601C,extended,03E8 //RGA" + Environment.NewLine +
            "patch=1,EE,105A601E,extended,04E2 //SPA" + Environment.NewLine +
            "patch=1,EE,105A6020,extended,03B6 //WPA" + Environment.NewLine +
            "";

            ExportPnach.ExportFile(baseCode);
        }

        public static void GolemsBossRush()
        {
            baseCode = "//" + Environment.NewLine +
            "patch=1,EE,D094D16C,extended,06010055 //If Mission 86 is selected" + Environment.NewLine +
            "patch=1,EE,21DA8528,extended,2 //number of enemies" + Environment.NewLine +
            "patch=1,EE,21DA8650,extended,02 //number of enemies (map pos)" + Environment.NewLine +
            "patch=1,EE,205B0044,extended,0000002D //P3 Model(DO NOT CHANGE)" + Environment.NewLine +
            "patch=1,EE,21DA8654,extended,00000003 //P3 Moveset" + Environment.NewLine +
            "patch=1,EE,21DA8700,extended,00000003 //P4 Moveset" + Environment.NewLine +
            "patch=1,EE,105C25B8,extended,0000 //P4 No Hp" + Environment.NewLine +
            "" + Environment.NewLine +
            "patch=1,EE,D094D16C,extended,0601005A //If Mission 91 is selected" + Environment.NewLine +
            "patch=1,EE,21DA8528,extended,2 //number of enemies" + Environment.NewLine +
            "patch=1,EE,21DA8650,extended,02 //number of enemies (map pos)" + Environment.NewLine +
            "patch=1,EE,205B0044,extended,0000002D //P3 Model(DO NOT CHANGE)" + Environment.NewLine +
            "patch=1,EE,21DA8654,extended,00000013 //P3 Moveset" + Environment.NewLine +
            "patch=1,EE,21DA8700,extended,00000013 //P4 Moveset" + Environment.NewLine +
            "patch=1,EE,105C25B8,extended,0000 //P4 No Hp" + Environment.NewLine +
            "" + Environment.NewLine +
            "patch=1,EE,D094D16C,extended,0401005C //If Mission 93 is selected" + Environment.NewLine +
            "patch=1,EE,21DA84A0,extended,0000FFFE //Always have partner" + Environment.NewLine +
            "patch=1,EE,205B9794,extended,0000002D //P4 Model(DO NOT CHANGE)" + Environment.NewLine +
            "patch=1,EE,505A68F4,extended,00000002 //Copy P2 Model's value" + Environment.NewLine +
            "patch=1,EE,01DA8700,extended,00000000 //Paste it on P4's Moveset" + Environment.NewLine +
            "" + Environment.NewLine +
            "patch=1,EE,D094D16C,extended,0301005C //If Mission 93 is selected" + Environment.NewLine +
            "patch=1,EE,D1DA84A0,extended,0210FFFF //If it's any partner" + Environment.NewLine +
            "patch=1,EE,D1DA8700,extended,01010000 //If P4 is in Brad's slot" + Environment.NewLine +
            "patch=1,EE,11DA8700,extended,0000002D //P4 will be set as Golem" + Environment.NewLine +
            "";

            ExportPnach.ExportFile(baseCode);
        }

        public static void HealingSPA()
        {
            baseCode = "//" + Environment.NewLine +
            "//P1 Healing SPA" + Environment.NewLine +
            "patch=1,EE,D05A6014,extended,02100000 // If P1 SPA is activated" + Environment.NewLine +
            "patch=1,EE,30200064,extended,05A5FC8 //Recover Health by 100" + Environment.NewLine +
            "patch=1,EE,205A6014,extended,00000000 //Disable SPA Aura" + Environment.NewLine +
            "" + Environment.NewLine +
            "//P2 Healing SPA" + Environment.NewLine +
            "patch=1,EE,D05AF764,extended,02100000 // If P2 SPA is activated" + Environment.NewLine +
            "patch=1,EE,30200064,extended,05AF718 //Recover Health by 100" + Environment.NewLine +
            "patch=1,EE,205AF764,extended,00000000 //Disable SPA Aura" + Environment.NewLine +
            "" + Environment.NewLine +
            "//P3 Healing SPA" + Environment.NewLine +
            "patch=1,EE,D05B8EB4,extended,02100000 // If P3 SPA is activated" + Environment.NewLine +
            "patch=1,EE,30200064,extended,05B8E68 //Recover Health by 100" + Environment.NewLine +
            "patch=1,EE,205B8EB4,extended,00000000 //Disable SPA Aura" + Environment.NewLine +
            "" + Environment.NewLine +
            "//P4 Healing SPA" + Environment.NewLine +
            "patch=1,EE,D05C2604,extended,02100000 // If P4 SPA is activated" + Environment.NewLine +
            "patch=1,EE,30200064,extended,05C25B8 //Recover Health by 100" + Environment.NewLine +
            "patch=1,EE,205C2604,extended,00000000 //Disable SPA Aura" + Environment.NewLine +
            "";

            ExportPnach.ExportFile(baseCode);
        }

        public static void BradStyleSwitching()
        {
            baseCode = "//" + Environment.NewLine +
            "patch=0,EE,1057943A,extended,0A97 //Brad's Taunt" + Environment.NewLine +
            "//Dragon Based                                                                        " + Environment.NewLine +
            "patch=1,EE,D05A5EE0,extended,13000A97 // If P1's Style Switch is happening          " + Environment.NewLine +
            "patch=1,EE,D059D1A4,extended,12000000 //Character P1 Slot 1                      " + Environment.NewLine +
            "patch=1,EE,D0579408,extended,110002F5 //If Brad's Style is All Round                " + Environment.NewLine +
            "patch=1,EE,105795FA,extended,0470 //Brad Front Sweep                                " + Environment.NewLine +
            "patch=1,EE,10545CC2,extended,04CD //Brad Fourth Hit Combo                           " + Environment.NewLine +
            "patch=1,EE,10579408,extended,0000 //Brad's Stance                                  " + Environment.NewLine +
            "patch=1,EE,1057943A,extended,09E3 //Brad's Taunt                                    " + Environment.NewLine +
            "patch=1,EE,10579602,extended,079C //Brad Downed Kick                                " + Environment.NewLine +
            "patch=1,EE,10579672,extended,0EAB //Brad Front Air Grab                            " + Environment.NewLine +
            "patch=1,EE,10534850,extended,046D //Quick Get Up(looking Down)                     " + Environment.NewLine +
            "patch=1,EE,1053549E,extended,046D //Quick Get Up(looking Down)                      " + Environment.NewLine +
            "patch=1,EE,10533BA8,extended,046D //Quick Get Up(looking Up)                        " + Environment.NewLine +
            "patch=1,EE,10535462,extended,0470 //Quick Get Up(looking Up)                        " + Environment.NewLine +
            "patch=1,EE,105795CE,extended,0694 //Brad Stationary Left Side Hit                   " + Environment.NewLine +
            "patch=1,EE,105795CC,extended,0695 //Brad Stationary Right Side Hit                  " + Environment.NewLine +
            "patch=1,EE,105795E2,extended,08A5 //Brad Roundhouse Kick                            " + Environment.NewLine +
            "patch=1,EE,10545D1C,extended,0533 //Brad Back Second Hit Combo                     " + Environment.NewLine +
            "patch=1,EE,105795E8,extended,0533 //Running Up Attack                               " + Environment.NewLine +
            "patch=1,EE,1054D666,extended,08AE //Brad Side Combo Third Hit                       " + Environment.NewLine +
            "patch=1,EE,1054DCBA,extended,0C26 //Brad Back Side Combo Third Hit                 " + Environment.NewLine +
            "                                                                                      " + Environment.NewLine +
            "//All Round Style                                                                     " + Environment.NewLine +
            "patch=1,EE,D05A5EE0,extended,130009E3 // If P1's Style Switch is happening       " + Environment.NewLine +
            "patch=1,EE,D059D1A4,extended,12000000 //Character P1 Slot 1                         " + Environment.NewLine +
            "patch=1,EE,D0579408,extended,11000000 //If Brad's Style is Dragon Based             " + Environment.NewLine +
            "patch=1,EE,105795FA,extended,08A6 // Brad Front Sweep                               " + Environment.NewLine +
            "patch=1,EE,10545CC2,extended,056F //Brad Fourth Hit Combo                          " + Environment.NewLine +
            "patch=1,EE,10579408,extended,02F5 //Brad's Stance                                   " + Environment.NewLine +
            "patch=1,EE,1057943A,extended,0A97 //Brad's Taunt                                    " + Environment.NewLine +
            "patch=1,EE,10579602,extended,0B79 //Brad Downed Kick                               " + Environment.NewLine +
            "patch=1,EE,10579672,extended,0CFB //Brad Front Air Grab                             " + Environment.NewLine +
            "patch=1,EE,10534850,extended,0199 //Quick Get Up(looking Down)                     " + Environment.NewLine +
            "patch=1,EE,1053549E,extended,0199 //Quick Get Up(looking Down)                      " + Environment.NewLine +
            "patch=1,EE,10533BA8,extended,0198 //Quick Get Up(looking Up)                        " + Environment.NewLine +
            "patch=1,EE,10535462,extended,0198 //Quick Get Up(looking Up)                        " + Environment.NewLine +
            "patch=1,EE,105795CE,extended,0573 //Brad Stationary Left Side Hit                   " + Environment.NewLine +
            "patch=1,EE,105795CC,extended,0574 //Brad Stationary Right Side Hit                  " + Environment.NewLine +
            "patch=1,EE,105795E2,extended,04CD //Brad Roundhouse Kick                            " + Environment.NewLine +
            "patch=1,EE,10545D1C,extended,0571 //Brad Back Second Hit Combo                     " + Environment.NewLine +
            "patch=1,EE,105795E8,extended,08AE //Running Up Attack                               " + Environment.NewLine +
            "patch=1,EE,1054D666,extended,08A5 //Brad Side Combo Third Hit                      " + Environment.NewLine +
            "patch=1,EE,1054DCBA,extended,08A5 //Brad Back Side Combo Third Hit                 " + Environment.NewLine +
            "";

            ExportPnach.ExportFile(baseCode);
        }

        public static void SPAMode()
        {
            baseCode = "//" + Environment.NewLine +
            "//P1" + Environment.NewLine +
            "patch=1,EE,D05A5FF2,extended,073000C7 // If Spa Mode reach level 1" + Environment.NewLine +
            "patch=1,EE,D05A5FF2,extended,062002BC // Spa Bar" + Environment.NewLine +
            "patch=1,EE,105A6002,extended,00000000 // " + Environment.NewLine +
            "patch=1,EE,105A6006,extended,00000000 // " + Environment.NewLine +
            "patch=1,EE,105A600A,extended,00003F20 // " + Environment.NewLine +
            "patch=1,EE,105A600E,extended,00003F80 // " + Environment.NewLine +
            "patch=1,EE,105A6010,extended,00000002 // " + Environment.NewLine +
            "patch=1,EE,205A6014,extended,44766C8C // " + Environment.NewLine +
            "patch=1,EE,D05A5FF2,extended,063002BB // if Spa Mode reach level 2 " + Environment.NewLine +
            "patch=1,EE,105A6002,extended,00003F20 // " + Environment.NewLine +
            "patch=1,EE,105A6006,extended,00000000 // " + Environment.NewLine +
            "patch=1,EE,105A600A,extended,00000000 // " + Environment.NewLine +
            "patch=1,EE,105A600E,extended,00003F80 // " + Environment.NewLine +
            "patch=1,EE,105A6010,extended,00000006 // " + Environment.NewLine +
            "patch=1,EE,205A6014,extended,44766C8C // " + Environment.NewLine +
            "patch=1,EE,D05A5FF2,extended,012000C8 // If Spa Mode is disabled" + Environment.NewLine +
            "patch=1,EE,205A6014,extended,00000000 // " + Environment.NewLine +
            "" + Environment.NewLine +
            "//P2" + Environment.NewLine +
            "patch=1,EE,D05AF742,extended,073000C7 // If Spa Mode reach level 1" + Environment.NewLine +
            "patch=1,EE,D05AF742,extended,062002BC // Spa Bar" + Environment.NewLine +
            "patch=1,EE,105AF752,extended,00000000 // " + Environment.NewLine +
            "patch=1,EE,105AF756,extended,00000000 // " + Environment.NewLine +
            "patch=1,EE,105AF75A,extended,00003F20 // " + Environment.NewLine +
            "patch=1,EE,105AF75E,extended,00003F80 // " + Environment.NewLine +
            "patch=1,EE,105AF760,extended,00000002 // " + Environment.NewLine +
            "patch=1,EE,205AF764,extended,44766C8C // " + Environment.NewLine +
            "patch=1,EE,D05AF742,extended,063002BB // if Spa Mode reach level 2 " + Environment.NewLine +
            "patch=1,EE,105AF752,extended,00003F20 // " + Environment.NewLine +
            "patch=1,EE,105AF756,extended,00000000 // " + Environment.NewLine +
            "patch=1,EE,105AF75A,extended,00000000 // " + Environment.NewLine +
            "patch=1,EE,105AF75E,extended,00003F80 // " + Environment.NewLine +
            "patch=1,EE,105AF760,extended,00000006 // " + Environment.NewLine +
            "patch=1,EE,205AF764,extended,44766C8C // " + Environment.NewLine +
            "patch=1,EE,D05AF742,extended,012000C8 // If Spa Mode is disabled" + Environment.NewLine +
            "patch=1,EE,205AF764,extended,00000000 // " + Environment.NewLine +
            "" + Environment.NewLine +
            "//P3" + Environment.NewLine +
            "patch=1,EE,D05B8E92,extended,073000C7 // If Spa Mode reach level 1" + Environment.NewLine +
            "patch=1,EE,D05B8E92,extended,062002BC // Spa Bar" + Environment.NewLine +
            "patch=1,EE,105B8EA2,extended,00000000 // " + Environment.NewLine +
            "patch=1,EE,105B8EA6,extended,00000000 // " + Environment.NewLine +
            "patch=1,EE,105B8EAA,extended,00003F20 // " + Environment.NewLine +
            "patch=1,EE,105B8EAE,extended,00003F80 // " + Environment.NewLine +
            "patch=1,EE,105B8EB0,extended,00000002 // " + Environment.NewLine +
            "patch=1,EE,205B8EB4,extended,44766C8C // " + Environment.NewLine +
            "patch=1,EE,D05B8E92,extended,063002BB // if Spa Mode reach level 2 " + Environment.NewLine +
            "patch=1,EE,105B8EA2,extended,00003F20 // " + Environment.NewLine +
            "patch=1,EE,105B8EA6,extended,00000000 // " + Environment.NewLine +
            "patch=1,EE,105B8EAA,extended,00000000 // " + Environment.NewLine +
            "patch=1,EE,105B8EAE,extended,00003F80 // " + Environment.NewLine +
            "patch=1,EE,105B8EB0,extended,00000006 // " + Environment.NewLine +
            "patch=1,EE,205B8EB4,extended,44766C8C // " + Environment.NewLine +
            "patch=1,EE,D05B8E92,extended,012000C8 // If Spa Mode is disabled" + Environment.NewLine +
            "patch=1,EE,205B8EB4,extended,00000000 // " + Environment.NewLine +
            "" + Environment.NewLine +
            "//P4" + Environment.NewLine +
            "patch=1,EE,D05C25E2,extended,073000C7 // If Spa Mode reach level 1" + Environment.NewLine +
            "patch=1,EE,D05C25E2,extended,062002BC // Spa Bar" + Environment.NewLine +
            "patch=1,EE,105C25F2,extended,00000000 // " + Environment.NewLine +
            "patch=1,EE,105C25F6,extended,00000000 // " + Environment.NewLine +
            "patch=1,EE,105C25FA,extended,00003F20 // " + Environment.NewLine +
            "patch=1,EE,105C25FE,extended,00003F80 // " + Environment.NewLine +
            "patch=1,EE,105C2600,extended,00000002 // " + Environment.NewLine +
            "patch=1,EE,205C2604,extended,44766C8C // " + Environment.NewLine +
            "patch=1,EE,D05C25E2,extended,063002BB // if Spa Mode reach level 2 " + Environment.NewLine +
            "patch=1,EE,105C25F2,extended,00003F20 // " + Environment.NewLine +
            "patch=1,EE,105C25F6,extended,00000000 // " + Environment.NewLine +
            "patch=1,EE,105C25FA,extended,00000000 // " + Environment.NewLine +
            "patch=1,EE,105C25FE,extended,00003F80 // " + Environment.NewLine +
            "patch=1,EE,105C2600,extended,00000006 // " + Environment.NewLine +
            "patch=1,EE,205C2604,extended,44766C8C // " + Environment.NewLine +
            "patch=1,EE,D05C25E2,extended,012000C8 // If Spa Mode is disabled" + Environment.NewLine +
            "patch=1,EE,205C2604,extended,00000000 // " + Environment.NewLine +
            "";

            ExportPnach.ExportFile(baseCode);
        }

        public static void NewGamePlus()
        {
            SettingsClass.codeFilePath = SettingsClass.codeFolderPath + @"\" + SettingsClass.PnachName + ".pnach";

            if (File.Exists(SettingsClass.codeFilePath))
            {
                File.Delete(SettingsClass.codeFilePath);
            }

            string pnachPatch = SettingsClass.missionFolderPath.Substring(0, SettingsClass.missionFolderPath.Length - 14) +
                @"\Big_Pnaches\New_Game_Plus.pnach";


            File.Copy(pnachPatch, SettingsClass.codeFilePath);

        }

        public static void x2PlayersNewGamePlus()
        {
            SettingsClass.codeFilePath = SettingsClass.codeFolderPath + @"\" + SettingsClass.PnachName + ".pnach";

            if (File.Exists(SettingsClass.codeFilePath))
            {
                File.Delete(SettingsClass.codeFilePath);
            }

            string pnachPatch = SettingsClass.missionFolderPath.Substring(0, SettingsClass.missionFolderPath.Length - 14) +
                @"\Big_Pnaches\2_Players_New_Game_Plus.pnach";


            File.Copy(pnachPatch, SettingsClass.codeFilePath);

        }

        public static void MortalKombatStyle()
        {
            List<int> listNumber = new List<int>();
            Random random = new Random();
            int randomIndex = -1;
            string code = "";
            string codePiece = "";

            for (int i = 1; i <= 50; i++)
            {
                //select player 1 modifier (your team)
                if (i >= 1 && i <= 10)
                {
                    listNumber = new List<int> { 0, 1, 1, 1, 1, 1, 2, 2, 2, 2, 3, 4 };
                }
                else if (i >= 11 && i <= 20)
                {
                    listNumber = new List<int> { 0, 0, 1, 1, 1, 1, 1, 2, 2, 2, 3, 3 };
                }
                else if (i >= 21 && i <= 30)
                {
                    listNumber = new List<int> { 0, 0, 0, 0, 1, 1, 1, 1, 2, 2, 2, 3, };
                }
                else if (i >= 31 && i <= 40)
                {
                    listNumber = new List<int> { 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 2, 2, 2, };
                }
                else if (i >= 41 && i <= 50)
                {
                    listNumber = new List<int> { 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 2, };
                }
                randomIndex = random.Next(0, listNumber.Count);

                codePiece = GetCode(listNumber[randomIndex], "", i, 1);
                code += codePiece;
                //switch (listNumber[randomIndex])
                //{
                //    case 0:
                //        randomIndex = random.Next(0, level0.Count);
                //        if (enemies10List.Contains(i))
                //        {
                //            code += conditionalEnemiesNumber + "0A" + conditionalEnemiesNumberInfo + "10" + Environment.NewLine;
                //            code += conditionalStage + enemies10List.IndexOf(i + 1).ToString("X2") + conditionalStageInfo + enemies10List.IndexOf(i + 1) + Environment.NewLine;
                //            code += "//P1 Stage " + enemies10List.IndexOf(i + 1) + " (debuff)" + Environment.NewLine + level0[randomIndex] + Environment.NewLine;
                //        }
                //        if (enemies20List.Contains(i))
                //        {
                //            code += conditionalEnemiesNumber + "14" + conditionalEnemiesNumberInfo + "20" + Environment.NewLine;
                //            code += conditionalStage + enemies20List.IndexOf(i + 1).ToString("X2") + conditionalStageInfo + enemies20List.IndexOf(i + 1) + Environment.NewLine;
                //            code += "//P1 Stage " + enemies20List.IndexOf(i + 1) + " (debuff)" + Environment.NewLine + level0[randomIndex] + Environment.NewLine;
                //        }
                //        if (enemies30List.Contains(i))
                //        {
                //            code += conditionalEnemiesNumber + "1E" + conditionalEnemiesNumberInfo + "30" + Environment.NewLine;
                //            code += conditionalStage + enemies30List.IndexOf(i + 1).ToString("X2") + conditionalStageInfo + enemies30List.IndexOf(i + 1) + Environment.NewLine;
                //            code += "//P1 Stage " + enemies30List.IndexOf(i + 1) + " (debuff)" + Environment.NewLine + level0[randomIndex] + Environment.NewLine;
                //        }
                //        if (enemies40List.Contains(i))
                //        {
                //            code += conditionalEnemiesNumber + "28" + conditionalEnemiesNumberInfo + "40" + Environment.NewLine;
                //            code += conditionalStage + enemies40List.IndexOf(i + 1).ToString("X2") + conditionalStageInfo + enemies40List.IndexOf(i + 1) + Environment.NewLine;
                //            code += "//P1 Stage " + enemies40List.IndexOf(i + 1) + " (debuff)" + Environment.NewLine + level0[randomIndex] + Environment.NewLine;
                //        }
                //        if (enemies50List.Contains(i))
                //        {
                //            code += conditionalEnemiesNumber + "32" + conditionalEnemiesNumberInfo + "50" + Environment.NewLine;
                //            code += conditionalStage + enemies50List.IndexOf(i + 1).ToString("X2") + conditionalStageInfo + enemies50List.IndexOf(i + 1) + Environment.NewLine;
                //            code += "//P1 Stage " + enemies50List.IndexOf(i + 1) + " (debuff)" + Environment.NewLine + level0[randomIndex] + Environment.NewLine;
                //        }
                //        break;
                //    case 1:
                //        if (enemies10List.Contains(i))
                //        {
                //            randomIndex = random.Next(0, level1.Count);
                //            code += conditionalEnemiesNumber + "0A" + conditionalEnemiesNumberInfo + "10" + Environment.NewLine;
                //            code += conditionalStage + enemies10List.IndexOf(i + 1).ToString("X2") + conditionalStageInfo + enemies10List.IndexOf(i + 1) + Environment.NewLine;
                //            code += "//P1 Stage " + enemies10List.IndexOf(i + 1) + " (small buff)" + Environment.NewLine + level1[randomIndex] + Environment.NewLine;
                //        }
                //        if (enemies20List.Contains(i))
                //        {
                //            randomIndex = random.Next(0, level1.Count);
                //            code += conditionalEnemiesNumber + "14" + conditionalEnemiesNumberInfo + "20" + Environment.NewLine;
                //            code += conditionalStage + enemies20List.IndexOf(i + 1).ToString("X2") + conditionalStageInfo + enemies20List.IndexOf(i + 1) + Environment.NewLine;
                //            code += "//P1 Stage " + enemies20List.IndexOf(i + 1) + " (small buff)" + Environment.NewLine + level1[randomIndex] + Environment.NewLine;
                //        }
                //        if (enemies30List.Contains(i))
                //        {
                //            randomIndex = random.Next(0, level1.Count);
                //            code += conditionalEnemiesNumber + "1E" + conditionalEnemiesNumberInfo + "30" + Environment.NewLine;
                //            code += conditionalStage + enemies30List.IndexOf(i + 1).ToString("X2") + conditionalStageInfo + enemies30List.IndexOf(i + 1) + Environment.NewLine;
                //            code += "//P1 Stage " + enemies30List.IndexOf(i + 1) + " (small buff)" + Environment.NewLine + level1[randomIndex] + Environment.NewLine;
                //        }
                //        if (enemies40List.Contains(i))
                //        {
                //            randomIndex = random.Next(0, level1.Count);
                //            code += conditionalEnemiesNumber + "28" + conditionalEnemiesNumberInfo + "40" + Environment.NewLine;
                //            code += conditionalStage + enemies40List.IndexOf(i + 1).ToString("X2") + conditionalStageInfo + enemies40List.IndexOf(i + 1) + Environment.NewLine;
                //            code += "//P1 Stage " + enemies40List.IndexOf(i + 1) + " (small buff)" + Environment.NewLine + level1[randomIndex] + Environment.NewLine;
                //        }
                //        if (enemies50List.Contains(i))
                //        {
                //            randomIndex = random.Next(0, level1.Count);
                //            code += conditionalEnemiesNumber + "32" + conditionalEnemiesNumberInfo + "50" + Environment.NewLine;
                //            code += conditionalStage + enemies50List.IndexOf(i + 1).ToString("X2") + conditionalStageInfo + enemies50List.IndexOf(i + 1) + Environment.NewLine;
                //            code += "//P1 Stage " + enemies50List.IndexOf(i + 1) + " (small buff)" + Environment.NewLine + level1[randomIndex] + Environment.NewLine;
                //        }
                //        break;
                //    case 2:
                //        if (enemies10List.Contains(i))
                //        {
                //            randomIndex = random.Next(0, level2.Count);
                //            code += conditionalEnemiesNumber + "0A" + conditionalEnemiesNumberInfo + "10" + Environment.NewLine;
                //            code += conditionalStage + enemies10List.IndexOf(i + 1).ToString("X2") + conditionalStageInfo + enemies10List.IndexOf(i + 1) + Environment.NewLine;
                //            code += "//P1 Stage " + enemies10List.IndexOf(i + 1) + " (medium buff)" + Environment.NewLine + level2[randomIndex] + Environment.NewLine;
                //        }
                //        if (enemies20List.Contains(i))
                //        {
                //            randomIndex = random.Next(0, level2.Count);
                //            code += conditionalEnemiesNumber + "14" + conditionalEnemiesNumberInfo + "20" + Environment.NewLine;
                //            code += conditionalStage + enemies20List.IndexOf(i + 1).ToString("X2") + conditionalStageInfo + enemies20List.IndexOf(i + 1) + Environment.NewLine;
                //            code += "//P1 Stage " + enemies20List.IndexOf(i + 1) + " (medium buff)" + Environment.NewLine + level2[randomIndex] + Environment.NewLine;
                //        }
                //        if (enemies30List.Contains(i))
                //        {
                //            randomIndex = random.Next(0, level2.Count);
                //            code += conditionalEnemiesNumber + "1E" + conditionalEnemiesNumberInfo + "30" + Environment.NewLine;
                //            code += conditionalStage + enemies30List.IndexOf(i + 1).ToString("X2") + conditionalStageInfo + enemies30List.IndexOf(i + 1) + Environment.NewLine;
                //            code += "//P1 Stage " + enemies30List.IndexOf(i + 1) + " (medium buff)" + Environment.NewLine + level2[randomIndex] + Environment.NewLine;
                //        }
                //        if (enemies40List.Contains(i))
                //        {
                //            randomIndex = random.Next(0, level2.Count);
                //            code += conditionalEnemiesNumber + "28" + conditionalEnemiesNumberInfo + "40" + Environment.NewLine;
                //            code += conditionalStage + enemies40List.IndexOf(i + 1).ToString("X2") + conditionalStageInfo + enemies40List.IndexOf(i + 1)  + Environment.NewLine;
                //            code += "//P1 Stage " + enemies40List.IndexOf(i + 1) + " (medium buff)" + Environment.NewLine + level2[randomIndex] + Environment.NewLine;
                //        }
                //        if (enemies50List.Contains(i))
                //        {
                //            randomIndex = random.Next(0, level2.Count);
                //            code += conditionalEnemiesNumber + "32" + conditionalEnemiesNumberInfo + "50" + Environment.NewLine;
                //            code += conditionalStage + enemies50List.IndexOf(i + 1).ToString("X2") + conditionalStageInfo + enemies50List.IndexOf(i + 1) + Environment.NewLine;
                //            code += "//P1 Stage " + enemies50List.IndexOf(i + 1) + " (medium buff)" + Environment.NewLine + level2[randomIndex] + Environment.NewLine;
                //        }
                //        break;
                //    case 3:
                //        if (enemies10List.Contains(i))
                //        {
                //            randomIndex = random.Next(0, level3.Count);
                //            code += conditionalEnemiesNumber + "0A" + conditionalEnemiesNumberInfo + "10" + Environment.NewLine;
                //            code += conditionalStage + enemies10List.IndexOf(i + 1).ToString("X2") + conditionalStageInfo + enemies10List.IndexOf(i + 1) + Environment.NewLine;
                //            code += "//P1 Stage " + enemies10List.IndexOf(i + 1) + " (big buff)" + Environment.NewLine + level3[randomIndex] + Environment.NewLine;
                //        }
                //        if (enemies20List.Contains(i))
                //        {
                //            randomIndex = random.Next(0, level3.Count);
                //            code += conditionalEnemiesNumber + "14" + conditionalEnemiesNumberInfo + "20" + Environment.NewLine;
                //            code += conditionalStage + enemies20List.IndexOf(i + 1).ToString("X2") + conditionalStageInfo + enemies20List.IndexOf(i + 1) + Environment.NewLine;
                //            code += "//P1 Stage " + enemies20List.IndexOf(i + 1) + " (big buff)" + Environment.NewLine + level3[randomIndex] + Environment.NewLine;
                //        }
                //        if (enemies30List.Contains(i))
                //        {
                //            randomIndex = random.Next(0, level3.Count);
                //            code += conditionalEnemiesNumber + "1E" + conditionalEnemiesNumberInfo + "30" + Environment.NewLine;
                //            code += conditionalStage + enemies30List.IndexOf(i + 1).ToString("X2") + conditionalStageInfo + enemies30List.IndexOf(i + 1) + Environment.NewLine;
                //            code += "//P1 Stage " + enemies30List.IndexOf(i + 1) + " (big buff)" + Environment.NewLine + level3[randomIndex] + Environment.NewLine;
                //        }
                //        if (enemies40List.Contains(i))
                //        {
                //            randomIndex = random.Next(0, level3.Count);
                //            code += conditionalEnemiesNumber + "28" + conditionalEnemiesNumberInfo + "40" + Environment.NewLine;
                //            code += conditionalStage + enemies40List.IndexOf(i + 1).ToString("X2") + conditionalStageInfo + enemies40List.IndexOf(i + 1) + Environment.NewLine;
                //            code += "//P1 Stage " + enemies40List.IndexOf(i + 1) + " (big buff)" + Environment.NewLine + level3[randomIndex] + Environment.NewLine;
                //        }
                //        if (enemies50List.Contains(i))
                //        {
                //            randomIndex = random.Next(0, level3.Count);
                //            code += conditionalEnemiesNumber + "32" + conditionalEnemiesNumberInfo + "50" + Environment.NewLine;
                //            code += conditionalStage + enemies50List.IndexOf(i + 1).ToString("X2") + conditionalStageInfo + enemies50List.IndexOf(i + 1) + Environment.NewLine;
                //            code += "//P1 Stage " + enemies50List.IndexOf(i + 1) + " (big buff)" + Environment.NewLine + level3[randomIndex] + Environment.NewLine;
                //        }
                //        break;
                //    case 4:
                //        if (enemies10List.Contains(i))
                //        {
                //            randomIndex = random.Next(0, level4.Count);
                //            code += conditionalEnemiesNumber + "0A" + conditionalEnemiesNumberInfo + "10" + Environment.NewLine;
                //            code += conditionalStage + enemies10List.IndexOf(i + 1).ToString("X2") + conditionalStageInfo + enemies10List.IndexOf(i + 1) + Environment.NewLine;
                //            code += "//P1 Stage " + enemies10List.IndexOf(i + 1) + " (super buff)" + Environment.NewLine + level4[randomIndex] + Environment.NewLine;
                //        }
                //        if (enemies20List.Contains(i))
                //        {
                //            randomIndex = random.Next(0, level4.Count);
                //            code += conditionalEnemiesNumber + "14" + conditionalEnemiesNumberInfo + "20" + Environment.NewLine;
                //            code += conditionalStage + enemies20List.IndexOf(i + 1).ToString("X2") + conditionalStageInfo + enemies20List.IndexOf(i + 1) + Environment.NewLine;
                //            code += "//P1 Stage " + enemies20List.IndexOf(i + 1) + " (super buff)" + Environment.NewLine + level4[randomIndex] + Environment.NewLine;
                //        }
                //        if (enemies30List.Contains(i))
                //        {
                //            randomIndex = random.Next(0, level4.Count);
                //            code += conditionalEnemiesNumber + "1E" + conditionalEnemiesNumberInfo + "30" + Environment.NewLine;
                //            code += conditionalStage + enemies30List.IndexOf(i + 1).ToString("X2") + conditionalStageInfo + enemies30List.IndexOf(i + 1) + Environment.NewLine;
                //            code += "//P1 Stage " + enemies30List.IndexOf(i + 1) + " (super buff)" + Environment.NewLine + level4[randomIndex] + Environment.NewLine;
                //        }
                //        if (enemies40List.Contains(i))
                //        {
                //            randomIndex = random.Next(0, level4.Count);
                //            code += conditionalEnemiesNumber + "28" + conditionalEnemiesNumberInfo + "40" + Environment.NewLine;
                //            code += conditionalStage + enemies40List.IndexOf(i + 1).ToString("X2") + conditionalStageInfo + enemies40List.IndexOf(i + 1) + Environment.NewLine;
                //            code += "//P1 Stage " + enemies40List.IndexOf(i + 1) + " (super buff)" + Environment.NewLine + level4[randomIndex] + Environment.NewLine;
                //        }
                //        if (enemies50List.Contains(i))
                //        {
                //            randomIndex = random.Next(0, level4.Count);
                //            code += conditionalEnemiesNumber + "32" + conditionalEnemiesNumberInfo + "50" + Environment.NewLine;
                //            code += conditionalStage + enemies50List.IndexOf(i + 1).ToString("X2") + conditionalStageInfo + enemies50List.IndexOf(i + 1) + Environment.NewLine;
                //            code += "//P1 Stage " + enemies50List.IndexOf(i + 1) + " (super buff)" + Environment.NewLine + level4[randomIndex] + Environment.NewLine;
                //        }
                //        break;
                //}

                //select player 2 modifier (your team)
                if (i >= 1 && i <= 10)
                {
                    listNumber = new List<int> { 0, 1, 1, 1, 1, 1, 2, 2, 2, 2, 3, 4 };
                }
                else if (i >= 11 && i <= 20)
                {
                    listNumber = new List<int> { 0, 0, 1, 1, 1, 1, 1, 2, 2, 2, 3, 3 };
                }
                else if (i >= 21 && i <= 30)
                {
                    listNumber = new List<int> { 0, 0, 0, 0, 1, 1, 1, 1, 2, 2, 2, 3, };
                }
                else if (i >= 31 && i <= 40)
                {
                    listNumber = new List<int> { 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 2, 2, 2, };
                }
                else if (i >= 41 && i <= 50)
                {
                    listNumber = new List<int> { 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 2, };
                }
                randomIndex = random.Next(0, listNumber.Count);
                //switch (listNumber[randomIndex])
                //{
                //    case 0:
                //        if (enemies10List.Contains(i))
                //        {
                //            randomIndex = random.Next(0, level0.Count);
                //            code += conditionalEnemiesNumber + "0A" + conditionalEnemiesNumberInfo + "10" + Environment.NewLine;
                //            code += conditionalStage + enemies10List.IndexOf(i + 1).ToString("X2") + conditionalStageInfo + enemies10List.IndexOf(i + 1) + Environment.NewLine;
                //            code += "//P2 Stage " + enemies10List.IndexOf(i + 1) + " (debuff)" + Environment.NewLine + level0[randomIndex] + Environment.NewLine;
                //        }
                //        if (enemies20List.Contains(i))
                //        {
                //            randomIndex = random.Next(0, level0.Count);
                //            code += conditionalEnemiesNumber + "14" + conditionalEnemiesNumberInfo + "20" + Environment.NewLine;
                //            code += conditionalStage + enemies20List.IndexOf(i + 1).ToString("X2") + conditionalStageInfo + enemies20List.IndexOf(i + 1) + Environment.NewLine;
                //            code += "//P2 Stage " + enemies20List.IndexOf(i + 1) + " (debuff)" + Environment.NewLine + level0[randomIndex] + Environment.NewLine;
                //        }
                //        if (enemies30List.Contains(i))
                //        {
                //            randomIndex = random.Next(0, level0.Count);
                //            code += conditionalEnemiesNumber + "1E" + conditionalEnemiesNumberInfo + "30" + Environment.NewLine;
                //            code += conditionalStage + enemies30List.IndexOf(i + 1).ToString("X2") + conditionalStageInfo + enemies30List.IndexOf(i + 1) + Environment.NewLine;
                //            code += "//P2 Stage " + enemies30List.IndexOf(i + 1) + " (debuff)" + Environment.NewLine + level0[randomIndex] + Environment.NewLine;
                //        }
                //        if (enemies40List.Contains(i))
                //        {
                //            randomIndex = random.Next(0, level0.Count);
                //            code += conditionalEnemiesNumber + "28" + conditionalEnemiesNumberInfo + "40" + Environment.NewLine;
                //            code += conditionalStage + enemies40List.IndexOf(i + 1).ToString("X2") + conditionalStageInfo + enemies40List.IndexOf(i + 1) + Environment.NewLine;
                //            code += "//P2 Stage " + enemies40List.IndexOf(i + 1) + " (debuff)" + Environment.NewLine + level0[randomIndex] + Environment.NewLine;
                //        }
                //        if (enemies50List.Contains(i))
                //        {
                //            randomIndex = random.Next(0, level0.Count);
                //            code += conditionalEnemiesNumber + "32" + conditionalEnemiesNumberInfo + "50" + Environment.NewLine;
                //            code += conditionalStage + enemies50List.IndexOf(i + 1).ToString("X2") + conditionalStageInfo + enemies50List.IndexOf(i + 1) + Environment.NewLine;
                //            code += "//P2 Stage " + enemies50List.IndexOf(i + 1) + " (debuff)" + Environment.NewLine + level0[randomIndex] + Environment.NewLine;
                //        }
                //        break;
                //    case 1:
                //        if (enemies10List.Contains(i))
                //        {
                //            randomIndex = random.Next(0, level1.Count);
                //            code += conditionalEnemiesNumber + "0A" + conditionalEnemiesNumberInfo + "10" + Environment.NewLine;
                //            code += conditionalStage + enemies10List.IndexOf(i + 1).ToString("X2") + conditionalStageInfo + enemies10List.IndexOf(i + 1) + Environment.NewLine;
                //            code += "//P2 Stage " + enemies10List.IndexOf(i + 1) + " (small buff)" + Environment.NewLine + level1[randomIndex] + Environment.NewLine;
                //        }
                //        if (enemies20List.Contains(i))
                //        {
                //            randomIndex = random.Next(0, level1.Count);
                //            code += conditionalEnemiesNumber + "14" + conditionalEnemiesNumberInfo + "20" + Environment.NewLine;
                //            code += conditionalStage + enemies20List.IndexOf(i + 1).ToString("X2") + conditionalStageInfo + enemies20List.IndexOf(i + 1) + Environment.NewLine;
                //            code += "//P2 Stage " + enemies20List.IndexOf(i + 1) + " (small buff)" + Environment.NewLine + level1[randomIndex] + Environment.NewLine;
                //        }
                //        if (enemies30List.Contains(i))
                //        {
                //            randomIndex = random.Next(0, level1.Count);
                //            code += conditionalEnemiesNumber + "1E" + conditionalEnemiesNumberInfo + "30" + Environment.NewLine;
                //            code += conditionalStage + enemies30List.IndexOf(i + 1).ToString("X2") + conditionalStageInfo + enemies30List.IndexOf(i + 1) + Environment.NewLine;
                //            code += "//P2 Stage " + enemies30List.IndexOf(i + 1) + " (small buff)" + Environment.NewLine + level1[randomIndex] + Environment.NewLine;
                //        }
                //        if (enemies40List.Contains(i))
                //        {
                //            randomIndex = random.Next(0, level1.Count);
                //            code += conditionalEnemiesNumber + "28" + conditionalEnemiesNumberInfo + "40" + Environment.NewLine;
                //            code += conditionalStage + enemies40List.IndexOf(i + 1).ToString("X2") + conditionalStageInfo + enemies40List.IndexOf(i + 1) + Environment.NewLine;
                //            code += "//P2 Stage " + enemies40List.IndexOf(i + 1) + " (small buff)" + Environment.NewLine + level1[randomIndex] + Environment.NewLine;
                //        }
                //        if (enemies50List.Contains(i))
                //        {
                //            randomIndex = random.Next(0, level1.Count);
                //            code += conditionalEnemiesNumber + "32" + conditionalEnemiesNumberInfo + "50" + Environment.NewLine;
                //            code += conditionalStage + enemies50List.IndexOf(i + 1).ToString("X2") + conditionalStageInfo + enemies50List.IndexOf(i + 1) + Environment.NewLine;
                //            code += "//P2 Stage " + enemies50List.IndexOf(i + 1) + " (small buff)" + Environment.NewLine + level1[randomIndex] + Environment.NewLine;
                //        }
                //        break;
                //    case 2:
                //        if (enemies10List.Contains(i))
                //        {
                //            randomIndex = random.Next(0, level2.Count);
                //            code += conditionalEnemiesNumber + "0A" + conditionalEnemiesNumberInfo + "10" + Environment.NewLine;
                //            code += conditionalStage + enemies10List.IndexOf(i + 1).ToString("X2") + conditionalStageInfo + enemies10List.IndexOf(i + 1) + Environment.NewLine;
                //            code += "//P2 Stage " + enemies10List.IndexOf(i + 1) + " (medium buff)" + Environment.NewLine + level2[randomIndex] + Environment.NewLine;
                //        }
                //        if (enemies20List.Contains(i))
                //        {
                //            randomIndex = random.Next(0, level2.Count);
                //            code += conditionalEnemiesNumber + "14" + conditionalEnemiesNumberInfo + "20" + Environment.NewLine;
                //            code += conditionalStage + enemies20List.IndexOf(i + 1).ToString("X2") + conditionalStageInfo + enemies20List.IndexOf(i + 1) + Environment.NewLine;
                //            code += "//P2 Stage " + enemies20List.IndexOf(i + 1) + " (medium buff)" + Environment.NewLine + level2[randomIndex] + Environment.NewLine;
                //        }
                //        if (enemies30List.Contains(i))
                //        {
                //            randomIndex = random.Next(0, level2.Count);
                //            code += conditionalEnemiesNumber + "1E" + conditionalEnemiesNumberInfo + "30" + Environment.NewLine;
                //            code += conditionalStage + enemies30List.IndexOf(i + 1).ToString("X2") + conditionalStageInfo + enemies30List.IndexOf(i + 1) + Environment.NewLine;
                //            code += "//P2 Stage " + enemies30List.IndexOf(i + 1) + " (medium buff)" + Environment.NewLine + level2[randomIndex] + Environment.NewLine;
                //        }
                //        if (enemies40List.Contains(i))
                //        {
                //            randomIndex = random.Next(0, level2.Count);
                //            code += conditionalEnemiesNumber + "28" + conditionalEnemiesNumberInfo + "40" + Environment.NewLine;
                //            code += conditionalStage + enemies40List.IndexOf(i + 1).ToString("X2") + conditionalStageInfo + enemies40List.IndexOf(i + 1) + Environment.NewLine;
                //            code += "//P2 Stage " + enemies40List.IndexOf(i + 1) + " (medium buff)" + Environment.NewLine + level2[randomIndex] + Environment.NewLine;
                //        }
                //        if (enemies50List.Contains(i))
                //        {
                //            randomIndex = random.Next(0, level2.Count);
                //            code += conditionalEnemiesNumber + "32" + conditionalEnemiesNumberInfo + "50" + Environment.NewLine;
                //            code += conditionalStage + enemies50List.IndexOf(i + 1).ToString("X2") + conditionalStageInfo + enemies50List.IndexOf(i + 1) + Environment.NewLine;
                //            code += "//P2 Stage " + enemies50List.IndexOf(i + 1) + " (medium buff)" + Environment.NewLine + level2[randomIndex] + Environment.NewLine;
                //        }
                //        break;
                //    case 3:
                //        if (enemies10List.Contains(i))
                //        {
                //            randomIndex = random.Next(0, level3.Count);
                //            code += conditionalEnemiesNumber + "0A" + conditionalEnemiesNumberInfo + "10" + Environment.NewLine;
                //            code += conditionalStage + enemies10List.IndexOf(i + 1).ToString("X2") + conditionalStageInfo + enemies10List.IndexOf(i + 1) + Environment.NewLine;
                //            code += "//P2 Stage " + enemies10List.IndexOf(i + 1) + " (big buff)" + Environment.NewLine + level3[randomIndex] + Environment.NewLine;
                //        }
                //        if (enemies20List.Contains(i))
                //        {
                //            randomIndex = random.Next(0, level3.Count);
                //            code += conditionalEnemiesNumber + "14" + conditionalEnemiesNumberInfo + "20" + Environment.NewLine;
                //            code += conditionalStage + enemies20List.IndexOf(i + 1).ToString("X2") + conditionalStageInfo + enemies20List.IndexOf(i + 1) + Environment.NewLine;
                //            code += "//P2 Stage " + enemies20List.IndexOf(i + 1) + " (big buff)" + Environment.NewLine + level3[randomIndex] + Environment.NewLine;
                //        }
                //        if (enemies30List.Contains(i))
                //        {
                //            randomIndex = random.Next(0, level3.Count);
                //            code += conditionalEnemiesNumber + "1E" + conditionalEnemiesNumberInfo + "30" + Environment.NewLine;
                //            code += conditionalStage + enemies30List.IndexOf(i + 1).ToString("X2") + conditionalStageInfo + enemies30List.IndexOf(i + 1) + Environment.NewLine;
                //            code += "//P2 Stage " + enemies30List.IndexOf(i + 1) + " (big buff)" + Environment.NewLine + level3[randomIndex] + Environment.NewLine;
                //        }
                //        if (enemies40List.Contains(i))
                //        {
                //            randomIndex = random.Next(0, level3.Count);
                //            code += conditionalEnemiesNumber + "28" + conditionalEnemiesNumberInfo + "40" + Environment.NewLine;
                //            code += conditionalStage + enemies40List.IndexOf(i + 1).ToString("X2") + conditionalStageInfo + enemies40List.IndexOf(i + 1) + Environment.NewLine;
                //            code += "//P2 Stage " + enemies40List.IndexOf(i + 1) + " (big buff)" + Environment.NewLine + level3[randomIndex] + Environment.NewLine;
                //        }
                //        if (enemies50List.Contains(i))
                //        {
                //            randomIndex = random.Next(0, level3.Count);
                //            code += conditionalEnemiesNumber + "32" + conditionalEnemiesNumberInfo + "50" + Environment.NewLine;
                //            code += conditionalStage + enemies50List.IndexOf(i + 1).ToString("X2") + conditionalStageInfo + enemies50List.IndexOf(i + 1) + Environment.NewLine;
                //            code += "//P2 Stage " + enemies50List.IndexOf(i + 1) + " (big buff)" + Environment.NewLine + level3[randomIndex] + Environment.NewLine;
                //        }
                //        break;
                //    case 4:
                //        if (enemies10List.Contains(i))
                //        {
                //            randomIndex = random.Next(0, level4.Count);
                //            code += conditionalEnemiesNumber + "0A" + conditionalEnemiesNumberInfo + "10" + Environment.NewLine;
                //            code += conditionalStage + enemies10List.IndexOf(i + 1).ToString("X2") + conditionalStageInfo + enemies10List.IndexOf(i + 1) + Environment.NewLine;
                //            code += "//P2 Stage " + enemies10List.IndexOf(i + 1) + " (super buff)" + Environment.NewLine + level4[randomIndex] + Environment.NewLine;
                //        }
                //        if (enemies20List.Contains(i))
                //        {
                //            randomIndex = random.Next(0, level4.Count);
                //            code += conditionalEnemiesNumber + "14" + conditionalEnemiesNumberInfo + "20" + Environment.NewLine;
                //            code += conditionalStage + enemies20List.IndexOf(i + 1).ToString("X2") + conditionalStageInfo + enemies20List.IndexOf(i + 1) + Environment.NewLine;
                //            code += "//P2 Stage " + enemies20List.IndexOf(i + 1) + " (super buff)" + Environment.NewLine + level4[randomIndex] + Environment.NewLine;
                //        }
                //        if (enemies30List.Contains(i))
                //        {
                //            randomIndex = random.Next(0, level4.Count);
                //            code += conditionalEnemiesNumber + "1E" + conditionalEnemiesNumberInfo + "30" + Environment.NewLine;
                //            code += conditionalStage + enemies30List.IndexOf(i + 1).ToString("X2") + conditionalStageInfo + enemies30List.IndexOf(i + 1) + Environment.NewLine;
                //            code += "//P2 Stage " + enemies30List.IndexOf(i + 1) + " (super buff)" + Environment.NewLine + level4[randomIndex] + Environment.NewLine;
                //        }
                //        if (enemies40List.Contains(i))
                //        {
                //            randomIndex = random.Next(0, level4.Count);
                //            code += conditionalEnemiesNumber + "28" + conditionalEnemiesNumberInfo + "40" + Environment.NewLine;
                //            code += conditionalStage + enemies40List.IndexOf(i + 1).ToString("X2") + conditionalStageInfo + enemies40List.IndexOf(i + 1) + Environment.NewLine;
                //            code += "//P2 Stage " + enemies40List.IndexOf(i + 1) + " (super buff)" + Environment.NewLine + level4[randomIndex] + Environment.NewLine;
                //        }
                //        if (enemies50List.Contains(i))
                //        {
                //            randomIndex = random.Next(0, level4.Count);
                //            code += conditionalEnemiesNumber + "32" + conditionalEnemiesNumberInfo + "50" + Environment.NewLine;
                //            code += conditionalStage + enemies50List.IndexOf(i + 1).ToString("X2") + conditionalStageInfo + enemies50List.IndexOf(i + 1) + Environment.NewLine;
                //            code += "//P2 Stage " + enemies50List.IndexOf(i + 1) + " (super buff)" + Environment.NewLine + level4[randomIndex] + Environment.NewLine;
                //        }
                //        break;
                //}

                //select player 3 modifier (opponent team)
                if (i >= 1 && i < 10)
                {
                    listNumber = new List<int> { 0, 0, 1, 1, 1, 1, 1, 2, 2, 2, 3, 4 };
                }
                else if (i >= 11 && i <= 20)
                {
                    listNumber = new List<int> { 0, 0, 1, 1, 1, 1, 1, 2, 2, 2, 3, 3 };
                }
                else if (i >= 21 && i <= 30)
                {
                    listNumber = new List<int> { 0, 1, 1, 1, 2, 2, 2, 2, 2, 3, 3, 4, };
                }
                else if (i >= 31 && i <= 40)
                {
                    listNumber = new List<int> { 1, 1, 1, 1, 2, 2, 2, 2, 3, 3, 3, 4, };
                }
                else if (i >= 41 && i <= 50)
                {
                    listNumber = new List<int> { 1, 2, 2, 2, 3, 3, 3, 4, 4 };
                }
                randomIndex = random.Next(0, listNumber.Count);
                //switch (listNumber[randomIndex])
                //{
                //    case 0:
                //        if (enemies10List.Contains(i))
                //        {
                //            randomIndex = random.Next(0, level0.Count);
                //            code += conditionalEnemiesNumber + "0A" + conditionalEnemiesNumberInfo + "10" + Environment.NewLine;
                //            code += conditionalStage + enemies10List.IndexOf(i + 1).ToString("X2") + conditionalStageInfo + enemies10List.IndexOf(i + 1) + Environment.NewLine;
                //            code += "//P3 Stage " + enemies10List.IndexOf(i + 1) + " (debuff)" + Environment.NewLine + level0[randomIndex] + Environment.NewLine;
                //        }
                //        if (enemies20List.Contains(i))
                //        {
                //            randomIndex = random.Next(0, level0.Count);
                //            code += conditionalEnemiesNumber + "14" + conditionalEnemiesNumberInfo + "20" + Environment.NewLine;
                //            code += conditionalStage + enemies20List.IndexOf(i + 1).ToString("X2") + conditionalStageInfo + enemies20List.IndexOf(i + 1) + Environment.NewLine;
                //            code += "//P3 Stage " + enemies20List.IndexOf(i + 1) + " (debuff)" + Environment.NewLine + level0[randomIndex] + Environment.NewLine;
                //        }
                //        if (enemies30List.Contains(i))
                //        {
                //            randomIndex = random.Next(0, level0.Count);
                //            code += conditionalEnemiesNumber + "1E" + conditionalEnemiesNumberInfo + "30" + Environment.NewLine;
                //            code += conditionalStage + enemies30List.IndexOf(i + 1).ToString("X2") + conditionalStageInfo + enemies30List.IndexOf(i + 1) + Environment.NewLine;
                //            code += "//P3 Stage " + enemies30List.IndexOf(i + 1) + " (debuff)" + Environment.NewLine + level0[randomIndex] + Environment.NewLine;
                //        }
                //        if (enemies40List.Contains(i))
                //        {
                //            randomIndex = random.Next(0, level0.Count);
                //            code += conditionalEnemiesNumber + "28" + conditionalEnemiesNumberInfo + "40" + Environment.NewLine;
                //            code += conditionalStage + enemies40List.IndexOf(i + 1).ToString("X2") + conditionalStageInfo + enemies40List.IndexOf(i + 1) + Environment.NewLine;
                //            code += "//P3 Stage " + enemies40List.IndexOf(i + 1) + " (debuff)" + Environment.NewLine + level0[randomIndex] + Environment.NewLine;
                //        }
                //        if (enemies50List.Contains(i))
                //        {
                //            randomIndex = random.Next(0, level0.Count);
                //            code += conditionalEnemiesNumber + "32" + conditionalEnemiesNumberInfo + "50" + Environment.NewLine;
                //            code += conditionalStage + enemies50List.IndexOf(i + 1).ToString("X2") + conditionalStageInfo + enemies50List.IndexOf(i + 1) + Environment.NewLine;
                //            code += "//P3 Stage " + enemies50List.IndexOf(i + 1) + " (debuff)" + Environment.NewLine + level0[randomIndex] + Environment.NewLine;
                //        }
                //        break;
                //    case 1:
                //        if (enemies10List.Contains(i))
                //        {
                //            randomIndex = random.Next(0, level1.Count);
                //            code += conditionalEnemiesNumber + "0A" + conditionalEnemiesNumberInfo + "10" + Environment.NewLine;
                //            code += conditionalStage + enemies10List.IndexOf(i + 1).ToString("X2") + conditionalStageInfo + enemies10List.IndexOf(i + 1) + Environment.NewLine;
                //            code += "//P3 Stage " + enemies10List.IndexOf(i + 1) + " (small buff)" + Environment.NewLine + level1[randomIndex] + Environment.NewLine;
                //        }
                //        if (enemies20List.Contains(i))
                //        {
                //            randomIndex = random.Next(0, level1.Count);
                //            code += conditionalEnemiesNumber + "14" + conditionalEnemiesNumberInfo + "20" + Environment.NewLine;
                //            code += conditionalStage + enemies20List.IndexOf(i + 1).ToString("X2") + conditionalStageInfo + enemies20List.IndexOf(i + 1) + Environment.NewLine;
                //            code += "//P3 Stage " + enemies20List.IndexOf(i + 1) + " (small buff)" + Environment.NewLine + level1[randomIndex] + Environment.NewLine;
                //        }
                //        if (enemies30List.Contains(i))
                //        {
                //            randomIndex = random.Next(0, level1.Count);
                //            code += conditionalEnemiesNumber + "1E" + conditionalEnemiesNumberInfo + "30" + Environment.NewLine;
                //            code += conditionalStage + enemies30List.IndexOf(i + 1).ToString("X2") + conditionalStageInfo + enemies30List.IndexOf(i + 1) + Environment.NewLine;
                //            code += "//P3 Stage " + enemies30List.IndexOf(i + 1) + " (small buff)" + Environment.NewLine + level1[randomIndex] + Environment.NewLine;
                //        }
                //        if (enemies40List.Contains(i))
                //        {
                //            randomIndex = random.Next(0, level1.Count);
                //            code += conditionalEnemiesNumber + "28" + conditionalEnemiesNumberInfo + "40" + Environment.NewLine;
                //            code += conditionalStage + enemies40List.IndexOf(i + 1).ToString("X2") + conditionalStageInfo + enemies40List.IndexOf(i + 1) + Environment.NewLine;
                //            code += "//P3 Stage " + enemies40List.IndexOf(i + 1) + " (small buff)" + Environment.NewLine + level1[randomIndex] + Environment.NewLine;
                //        }
                //        if (enemies50List.Contains(i))
                //        {
                //            randomIndex = random.Next(0, level1.Count);
                //            code += conditionalEnemiesNumber + "32" + conditionalEnemiesNumberInfo + "50" + Environment.NewLine;
                //            code += conditionalStage + enemies50List.IndexOf(i + 1).ToString("X2") + conditionalStageInfo + enemies50List.IndexOf(i + 1) + Environment.NewLine;
                //            code += "//P3 Stage " + enemies50List.IndexOf(i + 1) + " (small buff)" + Environment.NewLine + level1[randomIndex] + Environment.NewLine;
                //        }
                //        break;
                //    case 2:
                //        if (enemies10List.Contains(i))
                //        {
                //            randomIndex = random.Next(0, level2.Count);
                //            code += conditionalEnemiesNumber + "0A" + conditionalEnemiesNumberInfo + "10" + Environment.NewLine;
                //            code += conditionalStage + enemies10List.IndexOf(i + 1).ToString("X2") + conditionalStageInfo + enemies10List.IndexOf(i + 1) + Environment.NewLine;
                //            code += "//P3 Stage " + enemies10List.IndexOf(i + 1) + " (medium buff)" + Environment.NewLine + level2[randomIndex] + Environment.NewLine;
                //        }
                //        if (enemies20List.Contains(i))
                //        {
                //            randomIndex = random.Next(0, level2.Count);
                //            code += conditionalEnemiesNumber + "14" + conditionalEnemiesNumberInfo + "20" + Environment.NewLine;
                //            code += conditionalStage + enemies20List.IndexOf(i + 1).ToString("X2") + conditionalStageInfo + enemies20List.IndexOf(i + 1) + Environment.NewLine;
                //            code += "//P3 Stage " + enemies20List.IndexOf(i + 1) + " (medium buff)" + Environment.NewLine + level2[randomIndex] + Environment.NewLine;
                //        }
                //        if (enemies30List.Contains(i))
                //        {
                //            randomIndex = random.Next(0, level2.Count);
                //            code += conditionalEnemiesNumber + "1E" + conditionalEnemiesNumberInfo + "30" + Environment.NewLine;
                //            code += conditionalStage + enemies30List.IndexOf(i + 1).ToString("X2") + conditionalStageInfo + enemies30List.IndexOf(i + 1) + Environment.NewLine;
                //            code += "//P3 Stage " + enemies30List.IndexOf(i + 1) + " (medium buff)" + Environment.NewLine + level2[randomIndex] + Environment.NewLine;
                //        }
                //        if (enemies40List.Contains(i))
                //        {
                //            randomIndex = random.Next(0, level2.Count);
                //            code += conditionalEnemiesNumber + "28" + conditionalEnemiesNumberInfo + "40" + Environment.NewLine;
                //            code += conditionalStage + enemies40List.IndexOf(i + 1).ToString("X2") + conditionalStageInfo + enemies40List.IndexOf(i + 1) + Environment.NewLine;
                //            code += "//P3 Stage " + enemies40List.IndexOf(i + 1) + " (medium buff)" + Environment.NewLine + level2[randomIndex] + Environment.NewLine;
                //        }
                //        if (enemies50List.Contains(i))
                //        {
                //            randomIndex = random.Next(0, level2.Count);
                //            code += conditionalEnemiesNumber + "32" + conditionalEnemiesNumberInfo + "50" + Environment.NewLine;
                //            code += conditionalStage + enemies50List.IndexOf(i + 1).ToString("X2") + conditionalStageInfo + enemies50List.IndexOf(i + 1) + Environment.NewLine;
                //            code += "//P3 Stage " + enemies50List.IndexOf(i + 1) + " (medium buff)" + Environment.NewLine + level2[randomIndex] + Environment.NewLine;
                //        }
                //        break;
                //    case 3:
                //        if (enemies10List.Contains(i))
                //        {
                //            randomIndex = random.Next(0, level3.Count);
                //            code += conditionalEnemiesNumber + "0A" + conditionalEnemiesNumberInfo + "10" + Environment.NewLine;
                //            code += conditionalStage + enemies10List.IndexOf(i + 1).ToString("X2") + conditionalStageInfo + enemies10List.IndexOf(i + 1) + Environment.NewLine;
                //            code += "//P3 Stage " + enemies10List.IndexOf(i + 1) + " (big buff)" + Environment.NewLine + level3[randomIndex] + Environment.NewLine;
                //        }
                //        if (enemies20List.Contains(i))
                //        {
                //            randomIndex = random.Next(0, level3.Count);
                //            code += conditionalEnemiesNumber + "14" + conditionalEnemiesNumberInfo + "20" + Environment.NewLine;
                //            code += conditionalStage + enemies20List.IndexOf(i + 1).ToString("X2") + conditionalStageInfo + enemies20List.IndexOf(i + 1) + Environment.NewLine;
                //            code += "//P3 Stage " + enemies20List.IndexOf(i + 1) + " (big buff)" + Environment.NewLine + level3[randomIndex] + Environment.NewLine;
                //        }
                //        if (enemies30List.Contains(i))
                //        {
                //            randomIndex = random.Next(0, level3.Count);
                //            code += conditionalEnemiesNumber + "1E" + conditionalEnemiesNumberInfo + "30" + Environment.NewLine;
                //            code += conditionalStage + enemies30List.IndexOf(i + 1).ToString("X2") + conditionalStageInfo + enemies30List.IndexOf(i + 1) + Environment.NewLine;
                //            code += "//P3 Stage " + enemies30List.IndexOf(i + 1) + " (big buff)" + Environment.NewLine + level3[randomIndex] + Environment.NewLine;
                //        }
                //        if (enemies40List.Contains(i))
                //        {
                //            randomIndex = random.Next(0, level3.Count);
                //            code += conditionalEnemiesNumber + "28" + conditionalEnemiesNumberInfo + "40" + Environment.NewLine;
                //            code += conditionalStage + enemies40List.IndexOf(i + 1).ToString("X2") + conditionalStageInfo + enemies40List.IndexOf(i + 1) + Environment.NewLine;
                //            code += "//P3 Stage " + enemies40List.IndexOf(i + 1) + " (big buff)" + Environment.NewLine + level3[randomIndex] + Environment.NewLine;
                //        }
                //        if (enemies50List.Contains(i))
                //        {
                //            randomIndex = random.Next(0, level3.Count);
                //            code += conditionalEnemiesNumber + "32" + conditionalEnemiesNumberInfo + "50" + Environment.NewLine;
                //            code += conditionalStage + enemies50List.IndexOf(i + 1).ToString("X2") + conditionalStageInfo + enemies50List.IndexOf(i + 1) + Environment.NewLine;
                //            code += "//P3 Stage " + enemies50List.IndexOf(i + 1) + " (big buff)" + Environment.NewLine + level3[randomIndex] + Environment.NewLine;
                //        }
                //        break;
                //    case 4:
                //        if (enemies10List.Contains(i))
                //        {
                //            randomIndex = random.Next(0, level4.Count);
                //            code += conditionalEnemiesNumber + "0A" + conditionalEnemiesNumberInfo + "10" + Environment.NewLine;
                //            code += conditionalStage + enemies10List.IndexOf(i + 1).ToString("X2") + conditionalStageInfo + enemies10List.IndexOf(i + 1) + Environment.NewLine;
                //            code += "//P3 Stage " + enemies10List.IndexOf(i + 1) + " (super buff)" + Environment.NewLine + level4[randomIndex] + Environment.NewLine;
                //        }
                //        if (enemies20List.Contains(i))
                //        {
                //            randomIndex = random.Next(0, level4.Count);
                //            code += conditionalEnemiesNumber + "14" + conditionalEnemiesNumberInfo + "20" + Environment.NewLine;
                //            code += conditionalStage + enemies20List.IndexOf(i + 1).ToString("X2") + conditionalStageInfo + enemies20List.IndexOf(i + 1) + Environment.NewLine;
                //            code += "//P3 Stage " + enemies20List.IndexOf(i + 1) + " (super buff)" + Environment.NewLine + level4[randomIndex] + Environment.NewLine;
                //        }
                //        if (enemies30List.Contains(i))
                //        {
                //            randomIndex = random.Next(0, level4.Count);
                //            code += conditionalEnemiesNumber + "1E" + conditionalEnemiesNumberInfo + "30" + Environment.NewLine;
                //            code += conditionalStage + enemies30List.IndexOf(i + 1).ToString("X2") + conditionalStageInfo + enemies30List.IndexOf(i + 1) + Environment.NewLine;
                //            code += "//P3 Stage " + enemies30List.IndexOf(i + 1) + " (super buff)" + Environment.NewLine + level4[randomIndex] + Environment.NewLine;
                //        }
                //        if (enemies40List.Contains(i))
                //        {
                //            randomIndex = random.Next(0, level4.Count);
                //            code += conditionalEnemiesNumber + "28" + conditionalEnemiesNumberInfo + "40" + Environment.NewLine;
                //            code += conditionalStage + enemies40List.IndexOf(i + 1).ToString("X2") + conditionalStageInfo + enemies40List.IndexOf(i + 1) + Environment.NewLine;
                //            code += "//P3 Stage " + enemies40List.IndexOf(i + 1) + " (super buff)" + Environment.NewLine + level4[randomIndex] + Environment.NewLine;
                //        }
                //        if (enemies50List.Contains(i))
                //        {
                //            randomIndex = random.Next(0, level4.Count);
                //            code += conditionalEnemiesNumber + "32" + conditionalEnemiesNumberInfo + "50" + Environment.NewLine;
                //            code += conditionalStage + enemies50List.IndexOf(i + 1).ToString("X2") + conditionalStageInfo + enemies50List.IndexOf(i + 1) + Environment.NewLine;
                //            code += "//P3 Stage " + enemies50List.IndexOf(i + 1) + " (super buff)" + Environment.NewLine + level4[randomIndex] + Environment.NewLine;
                //        }
                //        break;
                //}

                //select player 4 modifier (opponent team)
                if (i >= 1 && i < 10)
                {
                    listNumber = new List<int> { 0, 0, 1, 1, 1, 1, 1, 2, 2, 2, 3, 4 };
                }
                else if (i >= 11 && i <= 20)
                {
                    listNumber = new List<int> { 0, 0, 1, 1, 1, 1, 1, 2, 2, 2, 3, 3 };
                }
                else if (i >= 21 && i <= 30)
                {
                    listNumber = new List<int> { 0, 1, 1, 1, 2, 2, 2, 2, 2, 3, 3, 4, };
                }
                else if (i >= 31 && i <= 40)
                {
                    listNumber = new List<int> { 1, 1, 1, 1, 2, 2, 2, 2, 3, 3, 3, 4, };
                }
                else if (i >= 41 && i <= 50)
                {
                    listNumber = new List<int> { 1, 2, 2, 2, 3, 3, 3, 4, 4 };
                }
                randomIndex = random.Next(0, listNumber.Count);
                //switch (listNumber[randomIndex])
                //{
                //    case 0:
                //        if (enemies10List.Contains(i))
                //        {
                //            randomIndex = random.Next(0, level0.Count);
                //            code += conditionalEnemiesNumber + "0A" + conditionalEnemiesNumberInfo + "10" + Environment.NewLine;
                //            code += conditionalStage + enemies10List.IndexOf(i + 1).ToString("X2") + conditionalStageInfo + enemies10List.IndexOf(i + 1) + Environment.NewLine;
                //            code += "//P4 Stage " + enemies10List.IndexOf(i + 1) + " (debuff)" + Environment.NewLine + level0[randomIndex] + Environment.NewLine;
                //        }
                //        if (enemies20List.Contains(i))
                //        {
                //            randomIndex = random.Next(0, level0.Count);
                //            code += conditionalEnemiesNumber + "14" + conditionalEnemiesNumberInfo + "20" + Environment.NewLine;
                //            code += conditionalStage + enemies20List.IndexOf(i + 1).ToString("X2") + conditionalStageInfo + enemies20List.IndexOf(i + 1) + Environment.NewLine;
                //            code += "//P4 Stage " + enemies20List.IndexOf(i + 1) + " (debuff)" + Environment.NewLine + level0[randomIndex] + Environment.NewLine;
                //        }
                //        if (enemies30List.Contains(i))
                //        {
                //            randomIndex = random.Next(0, level0.Count);
                //            code += conditionalEnemiesNumber + "1E" + conditionalEnemiesNumberInfo + "30" + Environment.NewLine;
                //            code += conditionalStage + enemies30List.IndexOf(i + 1).ToString("X2") + conditionalStageInfo + enemies30List.IndexOf(i + 1) + Environment.NewLine;
                //            code += "//P4 Stage " + enemies30List.IndexOf(i + 1) + " (debuff)" + Environment.NewLine + level0[randomIndex] + Environment.NewLine;
                //        }
                //        if (enemies40List.Contains(i))
                //        {
                //            randomIndex = random.Next(0, level0.Count);
                //            code += conditionalEnemiesNumber + "28" + conditionalEnemiesNumberInfo + "40" + Environment.NewLine;
                //            code += conditionalStage + enemies40List.IndexOf(i + 1).ToString("X2") + conditionalStageInfo + enemies40List.IndexOf(i + 1) + Environment.NewLine;
                //            code += "//P4 Stage " + enemies40List.IndexOf(i + 1) + " (debuff)" + Environment.NewLine + level0[randomIndex] + Environment.NewLine;
                //        }
                //        if (enemies50List.Contains(i))
                //        {
                //            randomIndex = random.Next(0, level0.Count);
                //            code += conditionalEnemiesNumber + "32" + conditionalEnemiesNumberInfo + "50" + Environment.NewLine;
                //            code += conditionalStage + enemies50List.IndexOf(i + 1).ToString("X2") + conditionalStageInfo + enemies50List.IndexOf(i + 1) + Environment.NewLine;
                //            code += "//P4 Stage " + enemies50List.IndexOf(i + 1) + " (debuff)" + Environment.NewLine + level0[randomIndex] + Environment.NewLine;
                //        }
                //        break;
                //    case 1:
                //        if (enemies10List.Contains(i))
                //        {
                //            randomIndex = random.Next(0, level1.Count);
                //            code += conditionalEnemiesNumber + "0A" + conditionalEnemiesNumberInfo + "10" + Environment.NewLine;
                //            code += conditionalStage + enemies10List.IndexOf(i + 1).ToString("X2") + conditionalStageInfo + enemies10List.IndexOf(i + 1) + Environment.NewLine;
                //            code += "//P4 Stage " + enemies10List.IndexOf(i + 1) + " (small buff)" + Environment.NewLine + level1[randomIndex] + Environment.NewLine;
                //        }
                //        if (enemies20List.Contains(i))
                //        {
                //            randomIndex = random.Next(0, level1.Count);
                //            code += conditionalEnemiesNumber + "14" + conditionalEnemiesNumberInfo + "20" + Environment.NewLine;
                //            code += conditionalStage + enemies20List.IndexOf(i + 1).ToString("X2") + conditionalStageInfo + enemies20List.IndexOf(i + 1) + Environment.NewLine;
                //            code += "//P4 Stage " + enemies20List.IndexOf(i + 1) + " (small buff)" + Environment.NewLine + level1[randomIndex] + Environment.NewLine;
                //        }
                //        if (enemies30List.Contains(i))
                //        {
                //            randomIndex = random.Next(0, level1.Count);
                //            code += conditionalEnemiesNumber + "1E" + conditionalEnemiesNumberInfo + "30" + Environment.NewLine;
                //            code += conditionalStage + enemies30List.IndexOf(i + 1).ToString("X2") + conditionalStageInfo + enemies30List.IndexOf(i + 1) + Environment.NewLine;
                //            code += "//P4 Stage " + enemies30List.IndexOf(i + 1) + " (small buff)" + Environment.NewLine + level1[randomIndex] + Environment.NewLine;
                //        }
                //        if (enemies40List.Contains(i))
                //        {
                //            randomIndex = random.Next(0, level1.Count);
                //            code += conditionalEnemiesNumber + "28" + conditionalEnemiesNumberInfo + "40" + Environment.NewLine;
                //            code += conditionalStage + enemies40List.IndexOf(i + 1).ToString("X2") + conditionalStageInfo + enemies40List.IndexOf(i + 1) + Environment.NewLine;
                //            code += "//P4 Stage " + enemies40List.IndexOf(i + 1) + " (small buff)" + Environment.NewLine + level1[randomIndex] + Environment.NewLine;
                //        }
                //        if (enemies50List.Contains(i))
                //        {
                //            randomIndex = random.Next(0, level1.Count);
                //            code += conditionalEnemiesNumber + "32" + conditionalEnemiesNumberInfo + "50" + Environment.NewLine;
                //            code += conditionalStage + enemies50List.IndexOf(i + 1).ToString("X2") + conditionalStageInfo + enemies50List.IndexOf(i + 1) + Environment.NewLine;
                //            code += "//P4 Stage " + enemies50List.IndexOf(i + 1) + " (small buff)" + Environment.NewLine + level1[randomIndex] + Environment.NewLine;
                //        }
                //        break;
                //    case 2:
                //        if (enemies10List.Contains(i))
                //        {
                //            randomIndex = random.Next(0, level2.Count);
                //            code += conditionalEnemiesNumber + "0A" + conditionalEnemiesNumberInfo + "10" + Environment.NewLine;
                //            code += conditionalStage + enemies10List.IndexOf(i + 1).ToString("X2") + conditionalStageInfo + enemies10List.IndexOf(i + 1) + Environment.NewLine;
                //            code += "//P4 Stage " + enemies10List.IndexOf(i + 1) + " (medium buff)" + Environment.NewLine + level2[randomIndex] + Environment.NewLine;
                //        }
                //        if (enemies20List.Contains(i))
                //        {
                //            randomIndex = random.Next(0, level2.Count);
                //            code += conditionalEnemiesNumber + "14" + conditionalEnemiesNumberInfo + "20" + Environment.NewLine;
                //            code += conditionalStage + enemies20List.IndexOf(i + 1).ToString("X2") + conditionalStageInfo + enemies20List.IndexOf(i + 1) + Environment.NewLine;
                //            code += "//P4 Stage " + enemies20List.IndexOf(i + 1) + " (medium buff)" + Environment.NewLine + level2[randomIndex] + Environment.NewLine;
                //        }
                //        if (enemies30List.Contains(i))
                //        {
                //            randomIndex = random.Next(0, level2.Count);
                //            code += conditionalEnemiesNumber + "1E" + conditionalEnemiesNumberInfo + "30" + Environment.NewLine;
                //            code += conditionalStage + enemies30List.IndexOf(i + 1).ToString("X2") + conditionalStageInfo + enemies30List.IndexOf(i + 1) + Environment.NewLine;
                //            code += "//P4 Stage " + enemies30List.IndexOf(i + 1) + " (medium buff)" + Environment.NewLine + level2[randomIndex] + Environment.NewLine;
                //        }
                //        if (enemies40List.Contains(i))
                //        {
                //            randomIndex = random.Next(0, level2.Count);
                //            code += conditionalEnemiesNumber + "28" + conditionalEnemiesNumberInfo + "40" + Environment.NewLine;
                //            code += conditionalStage + enemies40List.IndexOf(i + 1).ToString("X2") + conditionalStageInfo + enemies40List.IndexOf(i + 1) + Environment.NewLine;
                //            code += "//P4 Stage " + enemies40List.IndexOf(i + 1) + " (medium buff)" + Environment.NewLine + level2[randomIndex] + Environment.NewLine;
                //        }
                //        if (enemies50List.Contains(i))
                //        {
                //            randomIndex = random.Next(0, level2.Count);
                //            code += conditionalEnemiesNumber + "32" + conditionalEnemiesNumberInfo + "50" + Environment.NewLine;
                //            code += conditionalStage + enemies50List.IndexOf(i + 1).ToString("X2") + conditionalStageInfo + enemies50List.IndexOf(i + 1) + Environment.NewLine;
                //            code += "//P4 Stage " + enemies50List.IndexOf(i + 1) + " (medium buff)" + Environment.NewLine + level2[randomIndex] + Environment.NewLine;
                //        }
                //        break;
                //    case 3:
                //        if (enemies10List.Contains(i))
                //        {
                //            randomIndex = random.Next(0, level3.Count);
                //            code += conditionalEnemiesNumber + "0A" + conditionalEnemiesNumberInfo + "10" + Environment.NewLine;
                //            code += conditionalStage + enemies10List.IndexOf(i + 1).ToString("X2") + conditionalStageInfo + enemies10List.IndexOf(i + 1) + Environment.NewLine;
                //            code += "//P4 Stage " + enemies10List.IndexOf(i + 1) + " (big buff)" + Environment.NewLine + level3[randomIndex] + Environment.NewLine;
                //        }
                //        if (enemies20List.Contains(i))
                //        {
                //            randomIndex = random.Next(0, level3.Count);
                //            code += conditionalEnemiesNumber + "14" + conditionalEnemiesNumberInfo + "20" + Environment.NewLine;
                //            code += conditionalStage + enemies20List.IndexOf(i + 1).ToString("X2") + conditionalStageInfo + enemies20List.IndexOf(i + 1) + Environment.NewLine;
                //            code += "//P4 Stage " + enemies20List.IndexOf(i + 1) + " (big buff)" + Environment.NewLine + level3[randomIndex] + Environment.NewLine;
                //        }
                //        if (enemies30List.Contains(i))
                //        {
                //            randomIndex = random.Next(0, level3.Count);
                //            code += conditionalEnemiesNumber + "1E" + conditionalEnemiesNumberInfo + "30" + Environment.NewLine;
                //            code += conditionalStage + enemies30List.IndexOf(i + 1).ToString("X2") + conditionalStageInfo + enemies30List.IndexOf(i + 1) + Environment.NewLine;
                //            code += "//P4 Stage " + enemies30List.IndexOf(i + 1) + " (big buff)" + Environment.NewLine + level3[randomIndex] + Environment.NewLine;
                //        }
                //        if (enemies40List.Contains(i))
                //        {
                //            randomIndex = random.Next(0, level3.Count);
                //            code += conditionalEnemiesNumber + "28" + conditionalEnemiesNumberInfo + "40" + Environment.NewLine;
                //            code += conditionalStage + enemies40List.IndexOf(i + 1).ToString("X2") + conditionalStageInfo + enemies40List.IndexOf(i + 1) + Environment.NewLine;
                //            code += "//P4 Stage " + enemies40List.IndexOf(i + 1) + " (big buff)" + Environment.NewLine + level3[randomIndex] + Environment.NewLine;
                //        }
                //        if (enemies50List.Contains(i))
                //        {
                //            randomIndex = random.Next(0, level3.Count);
                //            code += conditionalEnemiesNumber + "32" + conditionalEnemiesNumberInfo + "50" + Environment.NewLine;
                //            code += conditionalStage + enemies50List.IndexOf(i + 1).ToString("X2") + conditionalStageInfo + enemies50List.IndexOf(i + 1) + Environment.NewLine;
                //            code += "//P4 Stage " + enemies50List.IndexOf(i + 1) + " (big buff)" + Environment.NewLine + level3[randomIndex] + Environment.NewLine;
                //        }
                //        break;
                //    case 4:
                //        if (enemies10List.Contains(i))
                //        {
                //            randomIndex = random.Next(0, level4.Count);
                //            code += conditionalEnemiesNumber + "0A" + conditionalEnemiesNumberInfo + "10" + Environment.NewLine;
                //            code += conditionalStage + enemies10List.IndexOf(i + 1).ToString("X2") + conditionalStageInfo + enemies10List.IndexOf(i + 1) + Environment.NewLine;
                //            code += "//P4 Stage " + enemies10List.IndexOf(i + 1) + " (super buff)" + Environment.NewLine + level4[randomIndex] + Environment.NewLine;
                //        }
                //        if (enemies20List.Contains(i))
                //        {
                //            randomIndex = random.Next(0, level4.Count);
                //            code += conditionalEnemiesNumber + "14" + conditionalEnemiesNumberInfo + "20" + Environment.NewLine;
                //            code += conditionalStage + enemies20List.IndexOf(i + 1).ToString("X2") + conditionalStageInfo + enemies20List.IndexOf(i + 1) + Environment.NewLine;
                //            code += "//P4 Stage " + enemies20List.IndexOf(i + 1) + " (super buff)" + Environment.NewLine + level4[randomIndex] + Environment.NewLine;
                //        }
                //        if (enemies30List.Contains(i))
                //        {
                //            randomIndex = random.Next(0, level4.Count);
                //            code += conditionalEnemiesNumber + "1E" + conditionalEnemiesNumberInfo + "30" + Environment.NewLine;
                //            code += conditionalStage + enemies30List.IndexOf(i + 1).ToString("X2") + conditionalStageInfo + enemies30List.IndexOf(i + 1) + Environment.NewLine;
                //            code += "//P4 Stage " + enemies30List.IndexOf(i + 1) + " (super buff)" + Environment.NewLine + level4[randomIndex] + Environment.NewLine;
                //        }
                //        if (enemies40List.Contains(i))
                //        {
                //            randomIndex = random.Next(0, level4.Count);
                //            code += conditionalEnemiesNumber + "28" + conditionalEnemiesNumberInfo + "40" + Environment.NewLine;
                //            code += conditionalStage + enemies40List.IndexOf(i + 1).ToString("X2") + conditionalStageInfo + enemies40List.IndexOf(i + 1) + Environment.NewLine;
                //            code += "//P4 Stage " + enemies40List.IndexOf(i + 1) + " (super buff)" + Environment.NewLine + level4[randomIndex] + Environment.NewLine;
                //        }
                //        if (enemies50List.Contains(i))
                //        {
                //            randomIndex = random.Next(0, level4.Count);
                //            code += conditionalEnemiesNumber + "32" + conditionalEnemiesNumberInfo + "50" + Environment.NewLine;
                //            code += conditionalStage + enemies50List.IndexOf(i + 1).ToString("X2") + conditionalStageInfo + enemies50List.IndexOf(i + 1) + Environment.NewLine;
                //            code += "//P4 Stage " + enemies50List.IndexOf(i + 1) + " (super buff)" + Environment.NewLine + level4[randomIndex] + Environment.NewLine;
                //        }
                //        break;
                //}

            }


            baseCode = code;

            ExportPnach.ExportFile(baseCode);
        }

        public static string GetCode(int randomIndexSent, string code, int i, int playerNumber)
        {
            //address for stage 205E9284
            //address for how many enemies 205E928C

            //level 0
            List<string> level0 = GetCodesList(0, playerNumber);
            string noSpa = "patch=1,EE,105A5FF2,extended,00000000";
            string allStats400 = "allStats400";
            string headEnduranceIsRed = "headEnduranceIsRed";
            string upperEnduranceIsRed = "upperEnduranceIsRed";
            string lowerEnduranceIsRed = "lowerEnduranceIsRed";
            string toughness200 = "toughness200";
            string strikeGrapple200 = "strikeGrapple200";
            level0.Add(noSpa);
            level0.Add(allStats400);
            level0.Add(headEnduranceIsRed);
            level0.Add(upperEnduranceIsRed);
            level0.Add(lowerEnduranceIsRed);
            level0.Add(toughness200);
            level0.Add(strikeGrapple200);

            //level 1
            List<string> level1 = new List<string>();
            string strike1500 = "strike1500";
            string grapple1500 = "grapple1500";
            string regional1500Weapon1500 = "regional1500Weapon1500";
            string special1500 = "special1500";
            string toughness1500 = "toughness1500";
            string allEndurance1500 = "allEndurance1500";
            string spaRecovery16 = "spaRecovery16";
            string redbullSpa = "redbullSpa";
            level1.Add(strike1500);
            level1.Add(grapple1500);
            level1.Add(regional1500Weapon1500);
            level1.Add(special1500);
            level1.Add(toughness1500);
            level1.Add(allEndurance1500);
            level1.Add(spaRecovery16);
            level1.Add(redbullSpa);

            //level 2
            List<string> level2 = new List<string>();
            string ultraInstinct = "ultraInstinct";
            string spaRecovery32 = "spaRecovery32";
            string infiniteRedSpa = "infiniteRedSpa";
            string strikeGrapple2000 = "strikeGrapple2000";
            string toughness2000 = "toughness2000";
            string spaDownWillMakeAllStats1500 = "spaDownWillMakeAllStats1500";
            level2.Add(ultraInstinct);
            level2.Add(spaRecovery32);
            level2.Add(infiniteRedSpa);
            level2.Add(strikeGrapple2000);
            level2.Add(toughness2000);
            level2.Add(spaDownWillMakeAllStats1500);

            //level 3
            List<string> level3 = new List<string>();
            string infiniteYellowSpa = "infiniteYellowSpa";
            string regenerationSpa = "regenerationSpa";
            string spaRecovery48 = "spaRecovery48";
            string toughness2500 = "toughness2500";
            string player5WillJoinThisTeam = "player5WillJoinThisTeam";
            level3.Add(infiniteYellowSpa);
            level3.Add(regenerationSpa);
            level3.Add(spaRecovery48);
            level3.Add(toughness2500);
            level3.Add(player5WillJoinThisTeam);

            //level 4
            List<string> level4 = new List<string>();
            string infiniteBlueSpa = "infiniteBlueSpa";
            string strike5000 = "strike5000";
            level4.Add(infiniteBlueSpa);
            level4.Add(strike5000);

            string conditionalEnemiesNumber = "patch=1,EE,D05E928C,extended,020000";
            string conditionalEnemiesNumberInfo = " //If Total Enemies = ";
            string conditionalStage = "patch=1,EE,D05E9284,extended,010000";
            string conditionalStageInfo = "//If Stage = ";

            List<int> enemies10List = new List<int> { 1, 2, 11, 12, 21, 22, 31, 32, 41, 42 };
            List<int> enemies20List = new List<int> { 1, 2, 3, 4, 11, 12, 13, 14, 21, 22, 23, 24, 31, 32, 33, 34, 41, 42, 43, 44 };
            List<int> enemies30List = new List<int> { 1, 2, 3, 4, 5, 6, 11, 12, 13, 14, 15, 16, 21, 22, 23, 24, 25, 26,
                31, 32, 33, 34, 35, 36, 41, 42, 43, 44, 45, 46 };
            List<int> enemies40List = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 11, 12, 13, 14, 15, 16, 17, 18, 21, 22, 23, 24, 25, 26, 27, 28,
                31, 32, 33, 34, 35, 36, 37, 38, 41, 42, 43, 44, 45, 46, 47, 48 };
            List<int> enemies50List = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20,
                21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50 };

            List<string> codesPerStage = new List<string>();
            Random random = new Random();
            int randomIndex = -1;
            int j = 0;

            switch (randomIndexSent)
            {
                case 0:
                    randomIndex = random.Next(0, level0.Count);
                    if (enemies10List.Contains(i))
                    {
                        code += conditionalEnemiesNumber + "0A" + conditionalEnemiesNumberInfo + "10" + Environment.NewLine;
                        code += conditionalStage + enemies10List.IndexOf(i + 1).ToString("X2") + conditionalStageInfo + enemies10List.IndexOf(i + 1) + Environment.NewLine;
                        code += "//P" + playerNumber + " (debuff)" + Environment.NewLine + level0[randomIndex] + Environment.NewLine;
                    }
                    if (enemies20List.Contains(i))
                    {
                        code += conditionalEnemiesNumber + "14" + conditionalEnemiesNumberInfo + "20" + Environment.NewLine;
                        code += conditionalStage + enemies20List.IndexOf(i + 1).ToString("X2") + conditionalStageInfo + enemies20List.IndexOf(i + 1) + Environment.NewLine;
                        code += "//P1 Stage " + enemies20List.IndexOf(i + 1) + " (debuff)" + Environment.NewLine + level0[randomIndex] + Environment.NewLine;
                    }
                    if (enemies30List.Contains(i))
                    {
                        code += conditionalEnemiesNumber + "1E" + conditionalEnemiesNumberInfo + "30" + Environment.NewLine;
                        code += conditionalStage + enemies30List.IndexOf(i + 1).ToString("X2") + conditionalStageInfo + enemies30List.IndexOf(i + 1) + Environment.NewLine;
                        code += "//P1 Stage " + enemies30List.IndexOf(i + 1) + " (debuff)" + Environment.NewLine + level0[randomIndex] + Environment.NewLine;
                    }
                    if (enemies40List.Contains(i))
                    {
                        code += conditionalEnemiesNumber + "28" + conditionalEnemiesNumberInfo + "40" + Environment.NewLine;
                        code += conditionalStage + enemies40List.IndexOf(i + 1).ToString("X2") + conditionalStageInfo + enemies40List.IndexOf(i + 1) + Environment.NewLine;
                        code += "//P1 Stage " + enemies40List.IndexOf(i + 1) + " (debuff)" + Environment.NewLine + level0[randomIndex] + Environment.NewLine;
                    }
                    if (enemies50List.Contains(i))
                    {
                        code += conditionalEnemiesNumber + "32" + conditionalEnemiesNumberInfo + "50" + Environment.NewLine;
                        code += conditionalStage + enemies50List.IndexOf(i + 1).ToString("X2") + conditionalStageInfo + enemies50List.IndexOf(i + 1) + Environment.NewLine;
                        code += "//P1 Stage " + enemies50List.IndexOf(i + 1) + " (debuff)" + Environment.NewLine + level0[randomIndex] + Environment.NewLine;
                    }
                    break;
                case 1:
                    if (enemies10List.Contains(i))
                    {
                        randomIndex = random.Next(0, level1.Count);
                        code += conditionalEnemiesNumber + "0A" + conditionalEnemiesNumberInfo + "10" + Environment.NewLine;
                        code += conditionalStage + enemies10List.IndexOf(i + 1).ToString("X2") + conditionalStageInfo + enemies10List.IndexOf(i + 1) + Environment.NewLine;
                        code += "//P1 Stage " + enemies10List.IndexOf(i + 1) + " (small buff)" + Environment.NewLine + level1[randomIndex] + Environment.NewLine;
                    }
                    if (enemies20List.Contains(i))
                    {
                        randomIndex = random.Next(0, level1.Count);
                        code += conditionalEnemiesNumber + "14" + conditionalEnemiesNumberInfo + "20" + Environment.NewLine;
                        code += conditionalStage + enemies20List.IndexOf(i + 1).ToString("X2") + conditionalStageInfo + enemies20List.IndexOf(i + 1) + Environment.NewLine;
                        code += "//P1 Stage " + enemies20List.IndexOf(i + 1) + " (small buff)" + Environment.NewLine + level1[randomIndex] + Environment.NewLine;
                    }
                    if (enemies30List.Contains(i))
                    {
                        randomIndex = random.Next(0, level1.Count);
                        code += conditionalEnemiesNumber + "1E" + conditionalEnemiesNumberInfo + "30" + Environment.NewLine;
                        code += conditionalStage + enemies30List.IndexOf(i + 1).ToString("X2") + conditionalStageInfo + enemies30List.IndexOf(i + 1) + Environment.NewLine;
                        code += "//P1 Stage " + enemies30List.IndexOf(i + 1) + " (small buff)" + Environment.NewLine + level1[randomIndex] + Environment.NewLine;
                    }
                    if (enemies40List.Contains(i))
                    {
                        randomIndex = random.Next(0, level1.Count);
                        code += conditionalEnemiesNumber + "28" + conditionalEnemiesNumberInfo + "40" + Environment.NewLine;
                        code += conditionalStage + enemies40List.IndexOf(i + 1).ToString("X2") + conditionalStageInfo + enemies40List.IndexOf(i + 1) + Environment.NewLine;
                        code += "//P1 Stage " + enemies40List.IndexOf(i + 1) + " (small buff)" + Environment.NewLine + level1[randomIndex] + Environment.NewLine;
                    }
                    if (enemies50List.Contains(i))
                    {
                        randomIndex = random.Next(0, level1.Count);
                        code += conditionalEnemiesNumber + "32" + conditionalEnemiesNumberInfo + "50" + Environment.NewLine;
                        code += conditionalStage + enemies50List.IndexOf(i + 1).ToString("X2") + conditionalStageInfo + enemies50List.IndexOf(i + 1) + Environment.NewLine;
                        code += "//P1 Stage " + enemies50List.IndexOf(i + 1) + " (small buff)" + Environment.NewLine + level1[randomIndex] + Environment.NewLine;
                    }
                    break;
                case 2:
                    if (enemies10List.Contains(i))
                    {
                        randomIndex = random.Next(0, level2.Count);
                        code += conditionalEnemiesNumber + "0A" + conditionalEnemiesNumberInfo + "10" + Environment.NewLine;
                        code += conditionalStage + enemies10List.IndexOf(i + 1).ToString("X2") + conditionalStageInfo + enemies10List.IndexOf(i + 1) + Environment.NewLine;
                        code += "//P1 Stage " + enemies10List.IndexOf(i + 1) + " (medium buff)" + Environment.NewLine + level2[randomIndex] + Environment.NewLine;
                    }
                    if (enemies20List.Contains(i))
                    {
                        randomIndex = random.Next(0, level2.Count);
                        code += conditionalEnemiesNumber + "14" + conditionalEnemiesNumberInfo + "20" + Environment.NewLine;
                        code += conditionalStage + enemies20List.IndexOf(i + 1).ToString("X2") + conditionalStageInfo + enemies20List.IndexOf(i + 1) + Environment.NewLine;
                        code += "//P1 Stage " + enemies20List.IndexOf(i + 1) + " (medium buff)" + Environment.NewLine + level2[randomIndex] + Environment.NewLine;
                    }
                    if (enemies30List.Contains(i))
                    {
                        randomIndex = random.Next(0, level2.Count);
                        code += conditionalEnemiesNumber + "1E" + conditionalEnemiesNumberInfo + "30" + Environment.NewLine;
                        code += conditionalStage + enemies30List.IndexOf(i + 1).ToString("X2") + conditionalStageInfo + enemies30List.IndexOf(i + 1) + Environment.NewLine;
                        code += "//P1 Stage " + enemies30List.IndexOf(i + 1) + " (medium buff)" + Environment.NewLine + level2[randomIndex] + Environment.NewLine;
                    }
                    if (enemies40List.Contains(i))
                    {
                        randomIndex = random.Next(0, level2.Count);
                        code += conditionalEnemiesNumber + "28" + conditionalEnemiesNumberInfo + "40" + Environment.NewLine;
                        code += conditionalStage + enemies40List.IndexOf(i + 1).ToString("X2") + conditionalStageInfo + enemies40List.IndexOf(i + 1) + Environment.NewLine;
                        code += "//P1 Stage " + enemies40List.IndexOf(i + 1) + " (medium buff)" + Environment.NewLine + level2[randomIndex] + Environment.NewLine;
                    }
                    if (enemies50List.Contains(i))
                    {
                        randomIndex = random.Next(0, level2.Count);
                        code += conditionalEnemiesNumber + "32" + conditionalEnemiesNumberInfo + "50" + Environment.NewLine;
                        code += conditionalStage + enemies50List.IndexOf(i + 1).ToString("X2") + conditionalStageInfo + enemies50List.IndexOf(i + 1) + Environment.NewLine;
                        code += "//P1 Stage " + enemies50List.IndexOf(i + 1) + " (medium buff)" + Environment.NewLine + level2[randomIndex] + Environment.NewLine;
                    }
                    break;
                case 3:
                    if (enemies10List.Contains(i))
                    {
                        randomIndex = random.Next(0, level3.Count);
                        code += conditionalEnemiesNumber + "0A" + conditionalEnemiesNumberInfo + "10" + Environment.NewLine;
                        code += conditionalStage + enemies10List.IndexOf(i + 1).ToString("X2") + conditionalStageInfo + enemies10List.IndexOf(i + 1) + Environment.NewLine;
                        code += "//P1 Stage " + enemies10List.IndexOf(i + 1) + " (big buff)" + Environment.NewLine + level3[randomIndex] + Environment.NewLine;
                    }
                    if (enemies20List.Contains(i))
                    {
                        randomIndex = random.Next(0, level3.Count);
                        code += conditionalEnemiesNumber + "14" + conditionalEnemiesNumberInfo + "20" + Environment.NewLine;
                        code += conditionalStage + enemies20List.IndexOf(i + 1).ToString("X2") + conditionalStageInfo + enemies20List.IndexOf(i + 1) + Environment.NewLine;
                        code += "//P1 Stage " + enemies20List.IndexOf(i + 1) + " (big buff)" + Environment.NewLine + level3[randomIndex] + Environment.NewLine;
                    }
                    if (enemies30List.Contains(i))
                    {
                        randomIndex = random.Next(0, level3.Count);
                        code += conditionalEnemiesNumber + "1E" + conditionalEnemiesNumberInfo + "30" + Environment.NewLine;
                        code += conditionalStage + enemies30List.IndexOf(i + 1).ToString("X2") + conditionalStageInfo + enemies30List.IndexOf(i + 1) + Environment.NewLine;
                        code += "//P1 Stage " + enemies30List.IndexOf(i + 1) + " (big buff)" + Environment.NewLine + level3[randomIndex] + Environment.NewLine;
                    }
                    if (enemies40List.Contains(i))
                    {
                        randomIndex = random.Next(0, level3.Count);
                        code += conditionalEnemiesNumber + "28" + conditionalEnemiesNumberInfo + "40" + Environment.NewLine;
                        code += conditionalStage + enemies40List.IndexOf(i + 1).ToString("X2") + conditionalStageInfo + enemies40List.IndexOf(i + 1) + Environment.NewLine;
                        code += "//P1 Stage " + enemies40List.IndexOf(i + 1) + " (big buff)" + Environment.NewLine + level3[randomIndex] + Environment.NewLine;
                    }
                    if (enemies50List.Contains(i))
                    {
                        randomIndex = random.Next(0, level3.Count);
                        code += conditionalEnemiesNumber + "32" + conditionalEnemiesNumberInfo + "50" + Environment.NewLine;
                        code += conditionalStage + enemies50List.IndexOf(i + 1).ToString("X2") + conditionalStageInfo + enemies50List.IndexOf(i + 1) + Environment.NewLine;
                        code += "//P1 Stage " + enemies50List.IndexOf(i + 1) + " (big buff)" + Environment.NewLine + level3[randomIndex] + Environment.NewLine;
                    }
                    break;
                case 4:
                    if (enemies10List.Contains(i))
                    {
                        randomIndex = random.Next(0, level4.Count);
                        code += conditionalEnemiesNumber + "0A" + conditionalEnemiesNumberInfo + "10" + Environment.NewLine;
                        code += conditionalStage + enemies10List.IndexOf(i + 1).ToString("X2") + conditionalStageInfo + enemies10List.IndexOf(i + 1) + Environment.NewLine;
                        code += "//P1 Stage " + enemies10List.IndexOf(i + 1) + " (super buff)" + Environment.NewLine + level4[randomIndex] + Environment.NewLine;
                    }
                    if (enemies20List.Contains(i))
                    {
                        randomIndex = random.Next(0, level4.Count);
                        code += conditionalEnemiesNumber + "14" + conditionalEnemiesNumberInfo + "20" + Environment.NewLine;
                        code += conditionalStage + enemies20List.IndexOf(i + 1).ToString("X2") + conditionalStageInfo + enemies20List.IndexOf(i + 1) + Environment.NewLine;
                        code += "//P1 Stage " + enemies20List.IndexOf(i + 1) + " (super buff)" + Environment.NewLine + level4[randomIndex] + Environment.NewLine;
                    }
                    if (enemies30List.Contains(i))
                    {
                        randomIndex = random.Next(0, level4.Count);
                        code += conditionalEnemiesNumber + "1E" + conditionalEnemiesNumberInfo + "30" + Environment.NewLine;
                        code += conditionalStage + enemies30List.IndexOf(i + 1).ToString("X2") + conditionalStageInfo + enemies30List.IndexOf(i + 1) + Environment.NewLine;
                        code += "//P1 Stage " + enemies30List.IndexOf(i + 1) + " (super buff)" + Environment.NewLine + level4[randomIndex] + Environment.NewLine;
                    }
                    if (enemies40List.Contains(i))
                    {
                        randomIndex = random.Next(0, level4.Count);
                        code += conditionalEnemiesNumber + "28" + conditionalEnemiesNumberInfo + "40" + Environment.NewLine;
                        code += conditionalStage + enemies40List.IndexOf(i + 1).ToString("X2") + conditionalStageInfo + enemies40List.IndexOf(i + 1) + Environment.NewLine;
                        code += "//P1 Stage " + enemies40List.IndexOf(i + 1) + " (super buff)" + Environment.NewLine + level4[randomIndex] + Environment.NewLine;
                    }
                    if (enemies50List.Contains(i))
                    {
                        randomIndex = random.Next(0, level4.Count);
                        code += conditionalEnemiesNumber + "32" + conditionalEnemiesNumberInfo + "50" + Environment.NewLine;
                        code += conditionalStage + enemies50List.IndexOf(i + 1).ToString("X2") + conditionalStageInfo + enemies50List.IndexOf(i + 1) + Environment.NewLine;
                        code += "//P1 Stage " + enemies50List.IndexOf(i + 1) + " (super buff)" + Environment.NewLine + level4[randomIndex] + Environment.NewLine;
                    }
                    break;
            }
            return code;
        }

        public static List<string> GetCodesList(int listNumber, int playerNumber)
        {
            List<string> codeList = new List<string>();
            switch (listNumber)
            {
                case 0:
                    switch (playerNumber)
                    {
                        case 1:
                            codeList.Add("patch=1,EE,105A5FF2,extended,00000000");//no spa
                            break;
                        case 2:
                            codeList.Add("patch=1,EE,105AF742,extended,00000000");//no spa
                            break;
                        case 3:
                            codeList.Add("patch=1,EE,105B8E92,extended,00000000");//no spa
                            break;
                        case 4:
                            codeList.Add("patch=1,EE,105C25E2,extended,00000000");//no spa
                            break;
                    }
                    break;
                case 1:
                    switch (playerNumber)
                    {
                        case 1:
                            //
                            break;
                        case 2:
                            //
                            break;
                        case 3:
                            //
                            break;
                        case 4:
                            //
                            break;
                    }
                    break;
                case 2:
                    switch (playerNumber)
                    {
                        case 1:
                            //
                            break;
                        case 2:
                            //
                            break;
                        case 3:
                            //
                            break;
                        case 4:
                            //
                            break;
                    }
                    break;
                case 3:
                    switch (playerNumber)
                    {
                        case 1:
                            //
                            break;
                        case 2:
                            //
                            break;
                        case 3:
                            //
                            break;
                        case 4:
                            //
                            break;
                    }
                    break;
                case 4:
                    switch (playerNumber)
                    {
                        case 1:
                            //
                            break;
                        case 2:
                            //
                            break;
                        case 3:
                            //
                            break;
                        case 4:
                            //
                            break;
                    }
                    break;
            }

            return codeList;
        }

    }
}
