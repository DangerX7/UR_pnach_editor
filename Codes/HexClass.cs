using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UR_pnach_editor.Services;

namespace UR_pnach_editor.Codes
{
    public class HexClass
    {

        public static void Test()//Edit Stats Hex Values in Rom
        {
            // Specify the path to the file and the hex address to edit
            string filePath = @"G:\Danger\Big Roms and Emulators\ps2 roms\Urban Reign\Urban Reign Deluxe.iso";
            int offset = 0x6B80C6DC;

            // Specify the new values to write to the file
            //   byte[] newValues = new byte[] { 0xDC, 0x05, 0xDC, 0x05, 0xDC, 0x05, 0xDC, 0x05, 0xDC, 0x05, 0xDC, 0x05, 0xDC, 0x05, 0xDC, 0x05, 0xDC, 0x05, };//new
            byte[] newValues = new byte[] { 0x52, 0x03, 0x52, 0x03, 0xE8, 0x03, 0xE8, 0x03, 0xE8, 0x03, 0xEE, 0x02, 0x20, 0x03, 0x20, 0x03, 0xEE, 0x02, };//original

            // Open the file and seek to the offset
            using (var fs = new FileStream(filePath, FileMode.Open, FileAccess.Write))
            {
                fs.Seek(offset, SeekOrigin.Begin);

                // Write the new values to the file
                fs.Write(newValues, 0, newValues.Length);
            }

        }


        public static void ChangeModelsSize()
        {
            KG_Model();
            Hornswoggle();
            Nightmare();
            GnomePalm();
            AmazonYing();

            SettingsClass.SaveData();
        }

        #region KG

        public static void KG_Model()
        {
            if (!SettingsClass.KG_Tall_Model) //original
            {
                uint offset = 0xBCA2E380;
                byte[] newValues = new byte[] { 0xFE, 0x43, 0xFA, 0x3D, };
                WriteFunction(offset, newValues);

                offset = 0xBCA2E3C0;
                newValues = new byte[] { 0xB1, 0x03, 0x67, 0x3E, };
                WriteFunction(offset, newValues);

                offset = 0xBCA2E400;
                newValues = new byte[] { 0x26, 0xC2, 0x86, 0x3D, };
                WriteFunction(offset, newValues);

                offset = 0xBCA2E440;
                newValues = new byte[] { 0x62, 0xC3, 0x53, 0x3E, };
                WriteFunction(offset, newValues);

                offset = 0xBCA2E480;
                newValues = new byte[] { 0x13, 0x83, 0xC0, 0x3D, };
                WriteFunction(offset, newValues);

                offset = 0xBCA2E4C0;
                newValues = new byte[] { 0x4E, 0x62, 0x90, 0x3E, };
                WriteFunction(offset, newValues);

                offset = 0xBCA2E500;
                newValues = new byte[] { 0x88, 0x63, 0x5D, 0x3E, };
                WriteFunction(offset, newValues);

                offset = 0xBCA2E540;
                newValues = new byte[] { 0x62, 0xC3, 0x53, 0x3E, };
                WriteFunction(offset, newValues);

                offset = 0xBCA2E580;
                newValues = new byte[] { 0x13, 0x83, 0xC0, 0x3D, };
                WriteFunction(offset, newValues);

                offset = 0xBCA2E5C0;
                newValues = new byte[] { 0x4E, 0x62, 0x90, 0x3E, };
                WriteFunction(offset, newValues);

                offset = 0xBCA2E600;
                newValues = new byte[] { 0x88, 0x63, 0x5D, 0x3E, };
                WriteFunction(offset, newValues);

                offset = 0xBCA2E680;
                newValues = new byte[] { 0x75, 0x02, 0x1A, 0x3E, };
                WriteFunction(offset, newValues);

                offset = 0xBCA2E6C0;
                newValues = new byte[] { 0x62, 0xC3, 0xD3, 0x3E, };
                WriteFunction(offset, newValues);

                offset = 0xBCA2E700;
                newValues = new byte[] { 0x39, 0x23, 0xCA, 0x3E, };
                WriteFunction(offset, newValues);

                offset = 0xBCA2E740;
                newValues = new byte[] { 0x13, 0x83, 0xC0, 0x3D, };
                WriteFunction(offset, newValues);

                offset = 0xBCA2E780;
                newValues = new byte[] { 0x75, 0x02, 0x1A, 0x3E, };
                WriteFunction(offset, newValues);

                offset = 0xBCA2E7C0;
                newValues = new byte[] { 0x62, 0xC3, 0xD3, 0x3E, };
                WriteFunction(offset, newValues);

                offset = 0xBCA2E800;
                newValues = new byte[] { 0x39, 0x23, 0xCA, 0x3E, };
                WriteFunction(offset, newValues);

                offset = 0xBCA2E840;
                newValues = new byte[] { 0x13, 0x83, 0xC0, 0x3D, };
                WriteFunction(offset, newValues);
            }
            else //custom
            {
                uint offset = 0xBCA2E380;
                byte[] newValues = new byte[] { 0x98, 0x6E, 0x12, 0x3E, };
                WriteFunction(offset, newValues);

                offset = 0xBCA2E3C0;
                newValues = new byte[] { 0x03, 0x2B, 0x87, 0x3E, };
                WriteFunction(offset, newValues);

                offset = 0xBCA2E400;
                newValues = new byte[] { 0x2D, 0xB2, 0x9D, 0x3D, };
                WriteFunction(offset, newValues);

                offset = 0xBCA2E440;
                newValues = new byte[] { 0xDA, 0xCE, 0x77, 0x3E, };
                WriteFunction(offset, newValues);

                offset = 0xBCA2E480;
                newValues = new byte[] { 0x97, 0x6E, 0x12, 0x3E, };
                WriteFunction(offset, newValues);

                offset = 0xBCA2E4C0;
                newValues = new byte[] { 0xB2, 0xF5, 0xA8, 0x3E, };
                WriteFunction(offset, newValues);

                offset = 0xBCA2E500;
                newValues = new byte[] { 0x37, 0x89, 0x81, 0x3E, };
                WriteFunction(offset, newValues);

                offset = 0xBCA2E540;
                newValues = new byte[] { 0xD8, 0xCE, 0x77, 0x3E, };
                WriteFunction(offset, newValues);

                offset = 0xBCA2E580;
                newValues = new byte[] { 0x98, 0x6E, 0x12, 0x3E, };
                WriteFunction(offset, newValues);

                offset = 0xBCA2E5C0;
                newValues = new byte[] { 0xC2, 0xF5, 0xA8, 0x3E, };
                WriteFunction(offset, newValues);

                offset = 0xBCA2E600;
                newValues = new byte[] { 0x37, 0x89, 0x81, 0x3E, };
                WriteFunction(offset, newValues);

                offset = 0xBCA2E680;
                newValues = new byte[] { 0x59, 0x39, 0x34, 0x3E, };
                WriteFunction(offset, newValues);

                offset = 0xBCA2E6C0;
                newValues = new byte[] { 0xDA, 0xCE, 0xF7, 0x3E, };
                WriteFunction(offset, newValues);

                offset = 0xBCA2E700;
                newValues = new byte[] { 0x43, 0x8B, 0xEC, 0x3E, };
                WriteFunction(offset, newValues);

                offset = 0xBCA2E740;
                newValues = new byte[] { 0xAF, 0x47, 0xE1, 0x3D, };
                WriteFunction(offset, newValues);

                offset = 0xBCA2E780;
                newValues = new byte[] { 0x59, 0x39, 0x34, 0x3E, };
                WriteFunction(offset, newValues);

                offset = 0xBCA2E7C0;
                newValues = new byte[] { 0xDA, 0xCE, 0xF7, 0x3E, };
                WriteFunction(offset, newValues);

                offset = 0xBCA2E800;
                newValues = new byte[] { 0x43, 0x8B, 0xEC, 0x3E, };
                WriteFunction(offset, newValues);

                offset = 0xBCA2E840;
                newValues = new byte[] { 0xAF, 0x47, 0xE1, 0x3D, };
                WriteFunction(offset, newValues);
            }
        }
        #endregion

        #region Hornswoggle

        public static void Hornswoggle()
        {
            if (!SettingsClass.Real_Dwarf_Model) //original
            {
                uint offset = 0xBAC2E2D3;
                byte[] newValues = new byte[] { 0x3E };
                WriteFunction(offset, newValues);

                offset = 0xBAC2E312;
                newValues = new byte[] { 0x81 };
                WriteFunction(offset, newValues);

                offset = 0xBAC2E352;
                newValues = new byte[] { 0x96 };
                WriteFunction(offset, newValues);

                offset = 0xBAC2E392;
                newValues = new byte[] { 0x6C };
                WriteFunction(offset, newValues);

                offset = 0xBAC2E3D2;
                newValues = new byte[] { 0x01, };
                WriteFunction(offset, newValues);

                offset = 0xBAC2E452;
                newValues = new byte[] { 0x77 };
                WriteFunction(offset, newValues);

                offset = 0xBAC2E492;
                newValues = new byte[] { 0x6C };
                WriteFunction(offset, newValues);

                offset = 0xBAC2E4D2;
                newValues = new byte[] { 0x01 };
                WriteFunction(offset, newValues);

                offset = 0xBAC2E552;
                newValues = new byte[] { 0x77 };
                WriteFunction(offset, newValues);

                offset = 0xBAC2E5D2;
                newValues = new byte[] { 0x2C };
                WriteFunction(offset, newValues);

                offset = 0xBAC2E612;
                newValues = new byte[] { 0xEC };
                WriteFunction(offset, newValues);

                offset = 0xBAC2E652;
                newValues = new byte[] { 0xE1 };
                WriteFunction(offset, newValues);

                offset = 0xBAC2E6D2;
                newValues = new byte[] { 0x2C };
                WriteFunction(offset, newValues);

                offset = 0xBAC2E712;
                newValues = new byte[] { 0xEC };
                WriteFunction(offset, newValues);

                offset = 0xBAC2E752;
                newValues = new byte[] { 0xE1 };
                WriteFunction(offset, newValues);
            }
            else //custom
            {
                uint offset = 0xBAC2E2D3;
                byte[] newValues = new byte[] { 0x39 };
                WriteFunction(offset, newValues);

                offset = 0xBAC2E312;
                newValues = new byte[] { 0x71 };
                WriteFunction(offset, newValues);

                offset = 0xBAC2E352;
                newValues = new byte[] { 0x86 };
                WriteFunction(offset, newValues);

                offset = 0xBAC2E392;
                newValues = new byte[] { 0x5C };
                WriteFunction(offset, newValues);

                offset = 0xBAC2E3D2;
                newValues = new byte[] { 0x11, };
                WriteFunction(offset, newValues);

                offset = 0xBAC2E452;
                newValues = new byte[] { 0x57 };
                WriteFunction(offset, newValues);

                offset = 0xBAC2E492;
                newValues = new byte[] { 0x5C };
                WriteFunction(offset, newValues);

                offset = 0xBAC2E4D2;
                newValues = new byte[] { 0x11 };
                WriteFunction(offset, newValues);

                offset = 0xBAC2E552;
                newValues = new byte[] { 0x57 };
                WriteFunction(offset, newValues);

                offset = 0xBAC2E5D2;
                newValues = new byte[] { 0x00 };
                WriteFunction(offset, newValues);

                offset = 0xBAC2E612;
                newValues = new byte[] { 0xAC };
                WriteFunction(offset, newValues);

                offset = 0xBAC2E652;
                newValues = new byte[] { 0xA1 };
                WriteFunction(offset, newValues);

                offset = 0xBAC2E6D2;
                newValues = new byte[] { 0x00 };
                WriteFunction(offset, newValues);

                offset = 0xBAC2E712;
                newValues = new byte[] { 0xAC };
                WriteFunction(offset, newValues);

                offset = 0xBAC2E752;
                newValues = new byte[] { 0xA1 };
                WriteFunction(offset, newValues);
            }
        }
        #endregion

        #region Nightmare

        public static void Nightmare()
        {
            if (!SettingsClass.Golem_Giant_Model) //original
            {
                uint offset = 0xBBE41DD2;
                byte[] newValues = new byte[] { 0x1C, };
                WriteFunction(offset, newValues);

                offset = 0xBBE41E52;
                newValues = new byte[] { 0xA8, };
                WriteFunction(offset, newValues);

                offset = 0xBBE41F12;
                newValues = new byte[] { 0xB4, };
                WriteFunction(offset, newValues);

                offset = 0xBBE41F52;
                newValues = new byte[] { 0x8A, };
                WriteFunction(offset, newValues);

                offset = 0xBBE42012;
                newValues = new byte[] { 0xB4, };
                WriteFunction(offset, newValues);

                offset = 0xBBE42052;
                newValues = new byte[] { 0x8A, };
                WriteFunction(offset, newValues);

                offset = 0xBBE420D2;
                newValues = new byte[] { 0x3C, };
                WriteFunction(offset, newValues);

                offset = 0xBBE42112;
                newValues = new byte[] { 0x01, };
                WriteFunction(offset, newValues);

                offset = 0xBBE42152;
                newValues = new byte[] { 0xF7, 0x3E, };
                WriteFunction(offset, newValues);

                offset = 0xBBE421D2;
                newValues = new byte[] { 0x3C, };
                WriteFunction(offset, newValues);

                offset = 0xBBE42212;
                newValues = new byte[] { 0x01, };
                WriteFunction(offset, newValues);

                offset = 0xBBE42252;
                newValues = new byte[] { 0xF7, 0x3E, };
                WriteFunction(offset, newValues);
            }
            else //custom
            {
                uint offset = 0xBBE41DD2;
                byte[] newValues = new byte[] { 0x8A, };
                WriteFunction(offset, newValues);

                offset = 0xBBE41E52;
                newValues = new byte[] { 0xB8, };
                WriteFunction(offset, newValues);

                offset = 0xBBE41F12;
                newValues = new byte[] { 0xE4, };
                WriteFunction(offset, newValues);

                offset = 0xBBE41F52;
                newValues = new byte[] { 0xAA, };
                WriteFunction(offset, newValues);

                offset = 0xBBE42012;
                newValues = new byte[] { 0xE4, };
                WriteFunction(offset, newValues);

                offset = 0xBBE42052;
                newValues = new byte[] { 0xAA, };
                WriteFunction(offset, newValues);

                offset = 0xBBE420D2;
                newValues = new byte[] { 0x4C, };
                WriteFunction(offset, newValues);

                offset = 0xBBE42112;
                newValues = new byte[] { 0x00, };
                WriteFunction(offset, newValues);

                offset = 0xBBE42152;
                newValues = new byte[] { 0x20, 0x3F, };
                WriteFunction(offset, newValues);

                offset = 0xBBE421D2;
                newValues = new byte[] { 0x4C, };
                WriteFunction(offset, newValues);

                offset = 0xBBE42212;
                newValues = new byte[] { 0x00, };
                WriteFunction(offset, newValues);

                offset = 0xBBE42252;
                newValues = new byte[] { 0x20, 0x3F, };
                WriteFunction(offset, newValues);
            }
        }
        #endregion

        #region GnomePalm

        public static void GnomePalm()
        {
            if (!SettingsClass.Gnome_Napalm_Model) //original
            {
                uint offset = 0xBBDBD6D2;
                byte[] newValues = new byte[] { 0x12, 0x3E };
                WriteFunction(offset, newValues);

                offset = 0xBBDBD712;
                newValues = new byte[] { 0x87, };
                WriteFunction(offset, newValues);

                offset = 0xBBDBD752;
                newValues = new byte[] { 0x9D, };
                WriteFunction(offset, newValues);

                offset = 0xBBDBD792;
                newValues = new byte[] { 0x77, };
                WriteFunction(offset, newValues);

                offset = 0xBBDBD812;
                newValues = new byte[] { 0xA8, };
                WriteFunction(offset, newValues);

                offset = 0xBBDBD852;
                newValues = new byte[] { 0x81, };
                WriteFunction(offset, newValues);

                offset = 0xBBDBD892;
                newValues = new byte[] { 0x77, };
                WriteFunction(offset, newValues);

                offset = 0xBBDBD912;
                newValues = new byte[] { 0xA8, };
                WriteFunction(offset, newValues);

                offset = 0xBBDBD952;
                newValues = new byte[] { 0x81, };
                WriteFunction(offset, newValues);

                offset = 0xBBDBD9D2;
                newValues = new byte[] { 0x34, 0x3E, };
                WriteFunction(offset, newValues);

                offset = 0xBBDBDA12;
                newValues = new byte[] { 0xF7, };
                WriteFunction(offset, newValues);

                offset = 0xBBDBDA52;
                newValues = new byte[] { 0xEC, };
                WriteFunction(offset, newValues);

                offset = 0xBBDBDAD2;
                newValues = new byte[] { 0x34, 0x3E, };
                WriteFunction(offset, newValues);

                offset = 0xBBDBDB12;
                newValues = new byte[] { 0xF7, };
                WriteFunction(offset, newValues);

                offset = 0xBBDBDB52;
                newValues = new byte[] { 0xEC, };
                WriteFunction(offset, newValues);
            }
            else //custom
            {
                uint offset = 0xBBDBD6D2;
                byte[] newValues = new byte[] { 0xB0, 0x3C };
                WriteFunction(offset, newValues);

                offset = 0xBBDBD712;
                newValues = new byte[] { 0x70, };
                WriteFunction(offset, newValues);

                offset = 0xBBDBD752;
                newValues = new byte[] { 0x90, };
                WriteFunction(offset, newValues);

                offset = 0xBBDBD792;
                newValues = new byte[] { 0x70, };
                WriteFunction(offset, newValues);

                offset = 0xBBDBD812;
                newValues = new byte[] { 0x88, };
                WriteFunction(offset, newValues);

                offset = 0xBBDBD852;
                newValues = new byte[] { 0x50, };
                WriteFunction(offset, newValues);

                offset = 0xBBDBD892;
                newValues = new byte[] { 0x70, };
                WriteFunction(offset, newValues);

                offset = 0xBBDBD912;
                newValues = new byte[] { 0x88, };
                WriteFunction(offset, newValues);

                offset = 0xBBDBD952;
                newValues = new byte[] { 0x50, };
                WriteFunction(offset, newValues);

                offset = 0xBBDBD9D2;
                newValues = new byte[] { 0xB0, 0x3D, };
                WriteFunction(offset, newValues);

                offset = 0xBBDBDA12;
                newValues = new byte[] { 0x40, };
                WriteFunction(offset, newValues);

                offset = 0xBBDBDA52;
                newValues = new byte[] { 0x40, };
                WriteFunction(offset, newValues);

                offset = 0xBBDBDAD2;
                newValues = new byte[] { 0xB0, 0x3D, };
                WriteFunction(offset, newValues);

                offset = 0xBBDBDB12;
                newValues = new byte[] { 0x40, };
                WriteFunction(offset, newValues);

                offset = 0xBBDBDB52;
                newValues = new byte[] { 0x40, };
                WriteFunction(offset, newValues);
            }
        }

        #endregion
        
        #region Shun Ying Tall

        public static void AmazonYing()
        {
            if (!SettingsClass.Amazon_Shun_Ying) //original
            {
                uint offset = 0xBB72DD22;
                byte[] newValues = new byte[] { 0xF7, 0x3D };
                WriteFunction(offset, newValues);

                offset = 0xBB72DD62;
                newValues = new byte[] { 0x64, };
                WriteFunction(offset, newValues);

                offset = 0xBB72DDA2;
                newValues = new byte[] { 0x85, };
                WriteFunction(offset, newValues);

                offset = 0xBB72DDE2;
                newValues = new byte[] { 0x51, };
                WriteFunction(offset, newValues);

                offset = 0xBB72DE22;
                newValues = new byte[] { 0x94, };
                WriteFunction(offset, newValues);

                offset = 0xBB72DE62;
                newValues = new byte[] { 0x8F, };
                WriteFunction(offset, newValues);

                offset = 0xBB72DEA2;
                newValues = new byte[] { 0x5B, };
                WriteFunction(offset, newValues);

                offset = 0xBB72DEE2;
                newValues = new byte[] { 0x51, };
                WriteFunction(offset, newValues);

                offset = 0xBB72DF22;
                newValues = new byte[] { 0x94, };
                WriteFunction(offset, newValues);

                offset = 0xBB72DF62;
                newValues = new byte[] { 0x8F, };
                WriteFunction(offset, newValues);

                offset = 0xBB72DFA2;
                newValues = new byte[] { 0x5B, };
                WriteFunction(offset, newValues);

                offset = 0xBB72E022;
                newValues = new byte[] { 0x1B, };
                WriteFunction(offset, newValues);

                offset = 0xBB72E062;
                newValues = new byte[] { 0xD6, };
                WriteFunction(offset, newValues);

                offset = 0xBB72E0A2;
                newValues = new byte[] { 0xCC, };
                WriteFunction(offset, newValues);

                offset = 0xBB72E0E2;
                newValues = new byte[] { 0xC2, };
                WriteFunction(offset, newValues);

                offset = 0xBB72E122;
                newValues = new byte[] { 0x1B, };
                WriteFunction(offset, newValues);

                offset = 0xBB72E162;
                newValues = new byte[] { 0xD6, };
                WriteFunction(offset, newValues);

                offset = 0xBB72E1A2;
                newValues = new byte[] { 0xCC, };
                WriteFunction(offset, newValues);

                offset = 0xBB72E1E2;
                newValues = new byte[] { 0xC2, };
                WriteFunction(offset, newValues);
            }
            else //custom
            {
                uint offset = 0xBB72DD22;
                byte[] newValues = new byte[] { 0x37, 0x3E };
                WriteFunction(offset, newValues);

                offset = 0xBB72DD62;
                newValues = new byte[] { 0x64, };
                WriteFunction(offset, newValues);

                offset = 0xBB72DDA2;
                newValues = new byte[] { 0x95, };
                WriteFunction(offset, newValues);

                offset = 0xBB72DDE2;
                newValues = new byte[] { 0x51, };
                WriteFunction(offset, newValues);

                offset = 0xBB72DE22;
                newValues = new byte[] { 0x94, };
                WriteFunction(offset, newValues);

                offset = 0xBB72DE62;
                newValues = new byte[] { 0xAF, };
                WriteFunction(offset, newValues);

                offset = 0xBB72DEA2;
                newValues = new byte[] { 0x7B, };
                WriteFunction(offset, newValues);

                offset = 0xBB72DEE2;
                newValues = new byte[] { 0x51, };
                WriteFunction(offset, newValues);

                offset = 0xBB72DF22;
                newValues = new byte[] { 0x94, };
                WriteFunction(offset, newValues);

                offset = 0xBB72DF62;
                newValues = new byte[] { 0xAF, };
                WriteFunction(offset, newValues);

                offset = 0xBB72DFA2;
                newValues = new byte[] { 0x7B, };
                WriteFunction(offset, newValues);

                offset = 0xBB72E022;
                newValues = new byte[] { 0x37, };
                WriteFunction(offset, newValues);

                offset = 0xBB72E062;
                newValues = new byte[] { 0xF6, };
                WriteFunction(offset, newValues);

                offset = 0xBB72E0A2;
                newValues = new byte[] { 0xFC, };
                WriteFunction(offset, newValues);

                offset = 0xBB72E0E2;
                newValues = new byte[] { 0xC2, };
                WriteFunction(offset, newValues);

                offset = 0xBB72E122;
                newValues = new byte[] { 0x37, };
                WriteFunction(offset, newValues);

                offset = 0xBB72E162;
                newValues = new byte[] { 0xF6, };
                WriteFunction(offset, newValues);

                offset = 0xBB72E1A2;
                newValues = new byte[] { 0xFC, };
                WriteFunction(offset, newValues);

                offset = 0xBB72E1E2;
                newValues = new byte[] { 0xC2, };
                WriteFunction(offset, newValues);
            }
        }

        #endregion


        public static void ChangeMoveset()
        {
            //#4B1EC800
            MasterBradMoveset();
            BradAndOthersParry();
            GolemBrokenShitMoveset();
            BordinAllAroundMoveset();
            PaulAshesMoveset();
            SakamotoRyomaMoveset();
            if (!SettingsClass.BordinAllAroundMoves)
            {
                ShinBordinMoveset();
            }
            KOGMoves();
            KingJakeMoves();
            MMAGipsiesMoves();
            RikiDensetsuMoves();
            PhoenixStanceShunYingMoves();
            BrokenDwayneMoves();
            MonsterVeraMoves();
            ThugKellyMoves();
            if (!SettingsClass.PhoenixStanceShunYingMoves)
            {
                SwordmasterShunYingAndLilianMoves();
            }
            SwordmasterLinFongMoves();
            SmartParkMoves();

            SettingsClass.SaveData();
        }

        //RAM+4B1EC800

        #region Brad_moveset

        public static void MasterBradMoveset()
        {
            if (SettingsClass.MasterBradMoves) //custom
            {
                uint offset = 0x6B765C08;
                byte[] newValues = new byte[] { 0x1D, 0x03, };
                WriteFunction(offset, newValues);

                offset = 0x6B765C3A;
                newValues = new byte[] { 0xDB, 0x03, };
                WriteFunction(offset, newValues);

                offset = 0x6B742EA8;
                newValues = new byte[] { 0x16, 0x0F, };
                WriteFunction(offset, newValues);

                offset = 0x6B742D04;
                newValues = new byte[] { 0xF8, 0x0E, };
                WriteFunction(offset, newValues);

                offset = 0x6B742BF6;
                newValues = new byte[] { 0xB8, 0x0E, };
                WriteFunction(offset, newValues);

                offset = 0x6B744186;
                newValues = new byte[] { 0x6D, 0x04, };
                WriteFunction(offset, newValues);

                offset = 0x6B74432A;
                newValues = new byte[] { 0xD1, 0x06, };
                WriteFunction(offset, newValues);

                offset = 0x6B765E58;
                newValues = new byte[] { 0xD1, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B742020;
                newValues = new byte[] { 0x29, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B765E76;
                newValues = new byte[] { 0xA4, 0x0E, };
                WriteFunction(offset, newValues);

                offset = 0x6B765E94;
                newValues = new byte[] { 0x70, 0x0E, };
                WriteFunction(offset, newValues);

                offset = 0x6B765E5A;
                newValues = new byte[] { 0x53, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B765E96;
                newValues = new byte[] { 0xB0, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B765E78;
                newValues = new byte[] { 0xC1, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B765E5C;
                newValues = new byte[] { 0xEF, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B765E98;
                newValues = new byte[] { 0x47, 0x0E, };
                WriteFunction(offset, newValues);

                offset = 0x6B765E7A;
                newValues = new byte[] { 0xF0, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B765E6E;
                newValues = new byte[] { 0x40, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B765E50;
                newValues = new byte[] { 0xE7, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B765E8C;
                newValues = new byte[] { 0x32, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B765EAA;
                newValues = new byte[] { 0x3D, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B765E8E;
                newValues = new byte[] { 0xC4, 0x0E, };
                WriteFunction(offset, newValues);

                offset = 0x6B765EAC;
                newValues = new byte[] { 0x3F, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B765E54;
                newValues = new byte[] { 0x21, 0x0E, };
                WriteFunction(offset, newValues);

                offset = 0x6B742296;
                newValues = new byte[] { 0xA9, 0x0E, };
                WriteFunction(offset, newValues);

                offset = 0x6B765E74;
                newValues = new byte[] { 0xCB, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B765EB0;
                newValues = new byte[] { 0x4F, 0x0F, };
                WriteFunction(offset, newValues);

                offset = 0x6B765E56;
                newValues = new byte[] { 0x24, 0x0E, };
                WriteFunction(offset, newValues);

                offset = 0x6B765EAE;
                newValues = new byte[] { 0x5A, 0x0F, };
                WriteFunction(offset, newValues);

                offset = 0x6B7308C0;
                newValues = new byte[] { 0x8E, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B7308DE;
                newValues = new byte[] { 0x92, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B7324C2;
                newValues = new byte[] { 0xA3, 0x08, };
                WriteFunction(offset, newValues);

                offset = 0x6B765DE2;
                newValues = new byte[] { 0x35, 0x05, };
                WriteFunction(offset, newValues);

                offset = 0x6B739E66;
                newValues = new byte[] { 0xC2, 0x08, };
                WriteFunction(offset, newValues);

                offset = 0x6B765DFA;
                newValues = new byte[] { 0x72, 0x09, };
                WriteFunction(offset, newValues);

                offset = 0x6B765DFE;
                newValues = new byte[] { 0xCF, 0x0B, };
                WriteFunction(offset, newValues);

                offset = 0x6B765DE4;
                newValues = new byte[] { 0xBE, 0x05, };
                WriteFunction(offset, newValues);

                offset = 0x6B73A4BA;
                newValues = new byte[] { 0x70, 0x05, };
                WriteFunction(offset, newValues);

                offset = 0x6B765DD0;
                newValues = new byte[] { 0xCD, 0x06, };
                WriteFunction(offset, newValues);

                offset = 0x6B765E18;
                newValues = new byte[] { 0x6F, 0x07, };
                WriteFunction(offset, newValues);

                offset = 0x6B765DE8;
                newValues = new byte[] { 0xC6, 0x0A, };
                WriteFunction(offset, newValues);

                offset = 0x6B765C82;
                newValues = new byte[] { 0x3F, 0x07, };
                WriteFunction(offset, newValues);

                offset = 0x6B765C84;
                newValues = new byte[] { 0x8E, 0x06, };
                WriteFunction(offset, newValues);

                offset = 0x6B765C86;
                newValues = new byte[] { 0xD6, 0x07, };
                WriteFunction(offset, newValues);

                offset = 0x6B732198;
                newValues = new byte[] { 0x80, 0x05, };
                WriteFunction(offset, newValues);

                offset = 0x6B765C18;
                newValues = new byte[] { 0xA7, 0x0C, };
                WriteFunction(offset, newValues);

            }
            else //original
            {
                uint offset = 0x6B765C08;
                byte[] newValues = new byte[] { 0xF5, 0x02, };
                WriteFunction(offset, newValues);

                offset = 0x6B765C3A;
                newValues = new byte[] { 0xC3, 0x03, };
                WriteFunction(offset, newValues);

                offset = 0x6B742EA8;
                newValues = new byte[] { 0xF8, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B742D04;
                newValues = new byte[] { 0xF8, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B742BF6;
                newValues = new byte[] { 0xEF, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B744186;
                newValues = new byte[] { 0x15, 0x0E, };
                WriteFunction(offset, newValues);

                offset = 0x6B74432A;
                newValues = new byte[] { 0x15, 0x0E, };
                WriteFunction(offset, newValues);

                offset = 0x6B765E58;
                newValues = new byte[] { 0x5F, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B742020;
                newValues = new byte[] { 0x7A, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B765E76;
                newValues = new byte[] { 0x3A, 0x0F, };
                WriteFunction(offset, newValues);

                offset = 0x6B765E94;
                newValues = new byte[] { 0x6D, 0x0E, };
                WriteFunction(offset, newValues);

                offset = 0x6B765E5A;
                newValues = new byte[] { 0x5E, 0x0E, };
                WriteFunction(offset, newValues);

                offset = 0x6B765E96;
                newValues = new byte[] { 0x6E, 0x0E, };
                WriteFunction(offset, newValues);

                offset = 0x6B765E78;
                newValues = new byte[] { 0xF4, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B765E5C;
                newValues = new byte[] { 0xDF, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B765E98;
                newValues = new byte[] { 0x6F, 0x0E, };
                WriteFunction(offset, newValues);

                offset = 0x6B765E7A;
                newValues = new byte[] { 0xBD, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B765E6E;
                newValues = new byte[] { 0x8E, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B765E50;
                newValues = new byte[] { 0x91, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B765E8C;
                newValues = new byte[] { 0x90, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B765EAA;
                newValues = new byte[] { 0x8F, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B765E8E;
                newValues = new byte[] { 0x94, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B765EAC;
                newValues = new byte[] { 0x93, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B765E54;
                newValues = new byte[] { 0xF9, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B742296;
                newValues = new byte[] { 0x79, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B765E74;
                newValues = new byte[] { 0x01, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B765EB0;
                newValues = new byte[] { 0x01, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B765E56;
                newValues = new byte[] { 0x02, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B765EAE;
                newValues = new byte[] { 0x06, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B7308C0;
                newValues = new byte[] { 0x92, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B7308DE;
                newValues = new byte[] { 0x93, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B7324C2;
                newValues = new byte[] { 0x6F, 0x05, };
                WriteFunction(offset, newValues);

                offset = 0x6B765DE2;
                newValues = new byte[] { 0xCD, 0x04, };
                WriteFunction(offset, newValues);

                offset = 0x6B739E66;
                newValues = new byte[] { 0xA5, 0x08, };
                WriteFunction(offset, newValues);

                offset = 0x6B765DFA;
                newValues = new byte[] { 0xA6, 0x08, };
                WriteFunction(offset, newValues);

                offset = 0x6B765DFE;
                newValues = new byte[] { 0x6D, 0x04, };
                WriteFunction(offset, newValues);

                offset = 0x6B765DE4;
                newValues = new byte[] { 0x33, 0x05, };
                WriteFunction(offset, newValues);

                offset = 0x6B73A4BA;
                newValues = new byte[] { 0xA5, 0x08, };
                WriteFunction(offset, newValues);

                offset = 0x6B765DD0;
                newValues = new byte[] { 0x6F, 0x07, };
                WriteFunction(offset, newValues);

                offset = 0x6B765E18;
                newValues = new byte[] { 0xAD, 0x08, };
                WriteFunction(offset, newValues);

                offset = 0x6B765DE8;
                newValues = new byte[] { 0xAE, 0x08, };
                WriteFunction(offset, newValues);

                offset = 0x6B765C82;
                newValues = new byte[] { 0x89, 0x04, };
                WriteFunction(offset, newValues);

                offset = 0x6B765C84;
                newValues = new byte[] { 0x71, 0x07, };
                WriteFunction(offset, newValues);

                offset = 0x6B765C86;
                newValues = new byte[] { 0xE3, 0x09, };
                WriteFunction(offset, newValues);

                offset = 0x6B732198;
                newValues = new byte[] { 0x57, 0x05, };
                WriteFunction(offset, newValues);

                offset = 0x6B765C18;
                newValues = new byte[] { 0xB4, 0x00, };
                WriteFunction(offset, newValues);

            }
        }

        #endregion

        #region Brad & others Parries

        public static void BradAndOthersParry()
        {
            if (SettingsClass.BradAndOthersParry) //custom
            {
                uint offset = 0x6B7182D0;
                byte[] newValues = new byte[] { 0xC9, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B7157D4;
                newValues = new byte[] { 0xE0, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B7193E0;
                newValues = new byte[] { 0x5E, 0x0E, };
                WriteFunction(offset, newValues);

                offset = 0x6B718696;
                newValues = new byte[] { 0x85, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B715F60;
                newValues = new byte[] { 0x8E, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B718180;
                newValues = new byte[] { 0x8E, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B7180D8;
                newValues = new byte[] { 0x79, 0x0B, };
                WriteFunction(offset, newValues);

                offset = 0x6B69EDF4;
                newValues = new byte[] { 0xEA, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B6C6EA8;
                newValues = new byte[] { 0xA0, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B6BD5A0;
                newValues = new byte[] { 0x53, 0x0F, };
                WriteFunction(offset, newValues);

                offset = 0x6B71B23A;
                newValues = new byte[] { 0x3E, 0x0F, };
                WriteFunction(offset, newValues);

                offset = 0x6B6D5AA8;
                newValues = new byte[] { 0x0A, 0x0E, };
                WriteFunction(offset, newValues);

                offset = 0x6B6BD104;
                newValues = new byte[] { 0xC3, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B6BE8FC;
                newValues = new byte[] { 0x38, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B71572C;
                newValues = new byte[] { 0xE3, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B7157FE;
                newValues = new byte[] { 0x5E, 0x0E, };
                WriteFunction(offset, newValues);

                offset = 0x6B715438;
                newValues = new byte[] { 0x84, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B717532;
                newValues = new byte[] { 0xF0, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B714574;
                newValues = new byte[] { 0x69, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B7443FC;
                newValues = new byte[] { 0xB3, 0x05, };
                WriteFunction(offset, newValues);

                offset = 0x6B744474;
                newValues = new byte[] { 0xB7, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B6E0184;
                newValues = new byte[] { 0xAF, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B6F7F2C;
                newValues = new byte[] { 0xDE, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B6F7E40;
                newValues = new byte[] { 0xDD, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B6F7A90;
                newValues = new byte[] { 0xA3, 0x0E, };
                WriteFunction(offset, newValues);

                offset = 0x6B6C4618;
                newValues = new byte[] { 0x06, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B7174DE;
                newValues = new byte[] { 0x38, 0x0F, };
                WriteFunction(offset, newValues);

                offset = 0x6B715A20;
                newValues = new byte[] { 0xE3, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B715366;
                newValues = new byte[] { 0xEF, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B719F08;
                newValues = new byte[] { 0x4F, 0x0F, };
                WriteFunction(offset, newValues);

                offset = 0x6B715E64;
                newValues = new byte[] { 0x31, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B744456;
                newValues = new byte[] { 0xD7, 0x0A, };
                WriteFunction(offset, newValues);

                offset = 0x6B6E0270;
                newValues = new byte[] { 0x5A, 0x0F, };
                WriteFunction(offset, newValues);

                offset = 0x6B6E035C;
                newValues = new byte[] { 0xB0, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B6F4E50;
                newValues = new byte[] { 0x0A, 0x0E, };
                WriteFunction(offset, newValues);

                offset = 0x6B6C8118;
                newValues = new byte[] { 0xEA, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B719F32;
                newValues = new byte[] { 0x5A, 0x0F, };
                WriteFunction(offset, newValues);

                offset = 0x6B74A46E;
                newValues = new byte[] { 0x65, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B7154B6;
                newValues = new byte[] { 0x65, 0x0F, };
                WriteFunction(offset, newValues);

                offset = 0x6B717310;
                newValues = new byte[] { 0x76, 0x0E, };
                WriteFunction(offset, newValues);

                offset = 0x6B71612E;
                newValues = new byte[] { 0xF0, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B7158D0;
                newValues = new byte[] { 0x9C, 0x04, };
                WriteFunction(offset, newValues);

                offset = 0x6B716032;
                newValues = new byte[] { 0x9D, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B71605C;
                newValues = new byte[] { 0x72, 0x09, };
                WriteFunction(offset, newValues);

                offset = 0x6B718618;
                newValues = new byte[] { 0xA8, 0x0E, };
                WriteFunction(offset, newValues);

                offset = 0x6B715DE6;
                newValues = new byte[] { 0xEF, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B718102;
                newValues = new byte[] { 0xE8, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B715198;
                newValues = new byte[] { 0xE3, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B6BAC24;
                newValues = new byte[] { 0x37, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B6B9340;
                newValues = new byte[] { 0x4E, 0x0E, };
                WriteFunction(offset, newValues);

                offset = 0x6B6BAA4C;
                newValues = new byte[] { 0x0A, 0x0E, };
                WriteFunction(offset, newValues);

                offset = 0x6B69C828;
                newValues = new byte[] { 0xFB, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B6AC698;
                newValues = new byte[] { 0xC9, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B6C4F50;
                newValues = new byte[] { 0xDD, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B7197FA;
                newValues = new byte[] { 0xA0, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B7142D4;
                newValues = new byte[] { 0xF8, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B6BDC10;
                newValues = new byte[] { 0xB0, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B7186EA;
                newValues = new byte[] { 0xE2, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B6BDD00;
                newValues = new byte[] { 0xEF, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B6C6BE4;
                newValues = new byte[] { 0x0A, 0x0E, };
                WriteFunction(offset, newValues);

                offset = 0x6B6B8A08;
                newValues = new byte[] { 0x53, 0x0F, };
                WriteFunction(offset, newValues);

                offset = 0x6B6BE374;
                newValues = new byte[] { 0xB8, 0x0E, };
                WriteFunction(offset, newValues);

                offset = 0x6B705D58;
                newValues = new byte[] { 0xF4, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B717364;
                newValues = new byte[] { 0xE2, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B715606;
                newValues = new byte[] { 0x69, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B7192BA;
                newValues = new byte[] { 0x2A, 0x0E, };
                WriteFunction(offset, newValues);

                offset = 0x6B7192E4;
                newValues = new byte[] { 0xE2, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B71812C;
                newValues = new byte[] { 0xE2, 0x0E, };
                WriteFunction(offset, newValues);

                offset = 0x6B6BBE94;
                newValues = new byte[] { 0x0A, 0x0E, };
                WriteFunction(offset, newValues);

                offset = 0x6B6BBF80;
                newValues = new byte[] { 0x6B, 0x0F, };
                WriteFunction(offset, newValues);

                offset = 0x6B6BFE30;
                newValues = new byte[] { 0xDC, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B6B51CC;
                newValues = new byte[] { 0xD7, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B6984DC;
                newValues = new byte[] { 0xA5, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B7174B4;
                newValues = new byte[] { 0xA8, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B715F36;
                newValues = new byte[] { 0xE0, 0x0E, };
                WriteFunction(offset, newValues);

                offset = 0x6B715390;
                newValues = new byte[] { 0xF8, 0x0E, };
                WriteFunction(offset, newValues);

                offset = 0x6B71930E;
                newValues = new byte[] { 0xCD, 0x06, };
                WriteFunction(offset, newValues);

                offset = 0x6B7444B0;
                newValues = new byte[] { 0x29, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B74441A;
                newValues = new byte[] { 0x92, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B6B4E1C;
                newValues = new byte[] { 0x23, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B69A8D0;
                newValues = new byte[] { 0xEA, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B708238;
                newValues = new byte[] { 0xDF, 0x0E, };
                WriteFunction(offset, newValues);

                offset = 0x6B6DDCA4;
                newValues = new byte[] { 0xA4, 0x0E, };
                WriteFunction(offset, newValues);

                offset = 0x6B6DE318;
                newValues = new byte[] { 0x4E, 0x0E, };
                WriteFunction(offset, newValues);

                offset = 0x6B6DE6C8;
                newValues = new byte[] { 0x6B, 0x0F, };
                WriteFunction(offset, newValues);

                offset = 0x6B6DE140;
                newValues = new byte[] { 0xEF, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B714868;
                newValues = new byte[] { 0xC8, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B715F0C;
                newValues = new byte[] { 0x5E, 0x0E, };
                WriteFunction(offset, newValues);

                offset = 0x6B71738E;
                newValues = new byte[] { 0x6C, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B6BE638;
                newValues = new byte[] { 0x29, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B69CAEC;
                newValues = new byte[] { 0x07, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B6B942C;
                newValues = new byte[] { 0x0A, 0x0E, };
                WriteFunction(offset, newValues);

                offset = 0x6B6B9604;
                newValues = new byte[] { 0xF1, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B6BB55C;
                newValues = new byte[] { 0xE3, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B7140DC;
                newValues = new byte[] { 0xEF, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B7158A6;
                newValues = new byte[] { 0x3E, 0x0F, };
                WriteFunction(offset, newValues);

                offset = 0x6B715FDE;
                newValues = new byte[] { 0xA3, 0x0E, };
                WriteFunction(offset, newValues);

                offset = 0x6B744492;
                newValues = new byte[] { 0xAF, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B714FF4;
                newValues = new byte[] { 0xBC, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B6FBB18;
                newValues = new byte[] { 0xE1, 0x0E, };
                WriteFunction(offset, newValues);

                offset = 0x6B6FBFB4;
                newValues = new byte[] { 0xC8, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B6FC0A0;
                newValues = new byte[] { 0x0A, 0x0E, };
                WriteFunction(offset, newValues);

                offset = 0x6B6C4354;
                newValues = new byte[] { 0xA8, 0x0E, };
                WriteFunction(offset, newValues);

                offset = 0x6B6C79B8;
                newValues = new byte[] { 0xF1, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B6FB590;
                newValues = new byte[] { 0x1D, 0x0B, };
                WriteFunction(offset, newValues);

                offset = 0x6B6FB854;
                newValues = new byte[] { 0xD9, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B71A1D2;
                newValues = new byte[] { 0xF0, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B71A154;
                newValues = new byte[] { 0x83, 0x0E, };
                WriteFunction(offset, newValues);

                offset = 0x6B715EB8;
                newValues = new byte[] { 0x6F, 0x0E, };
                WriteFunction(offset, newValues);

                offset = 0x6B7142AA;
                newValues = new byte[] { 0x31, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B71400A;
                newValues = new byte[] { 0x9C, 0x04, };
                WriteFunction(offset, newValues);

                offset = 0x6B6EB284;
                newValues = new byte[] { 0x61, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B6EA59C;
                newValues = new byte[] { 0x3E, 0x0F, };
                WriteFunction(offset, newValues);

                offset = 0x6B6EAFC0;
                newValues = new byte[] { 0xA0, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B6EAED4;
                newValues = new byte[] { 0x0A, 0x0E, };
                WriteFunction(offset, newValues);

                offset = 0x6B6E9D50;
                newValues = new byte[] { 0xEA, 0x09, };
                WriteFunction(offset, newValues);

                offset = 0x6B6EA774;
                newValues = new byte[] { 0x6B, 0x0F, };
                WriteFunction(offset, newValues);

                offset = 0x6B6E9A8C;
                newValues = new byte[] { 0xB8, 0x0E, };
                WriteFunction(offset, newValues);

                offset = 0x6B6EB548;
                newValues = new byte[] { 0xA8, 0x0E, };
                WriteFunction(offset, newValues);

                offset = 0x6B6EB45C;
                newValues = new byte[] { 0xA7, 0x0E, };
                WriteFunction(offset, newValues);

                offset = 0x6B71A88C;
                newValues = new byte[] { 0x1C, 0x0F, };
                WriteFunction(offset, newValues);

                offset = 0x6B71955A;
                newValues = new byte[] { 0xAC, 0x0E, };
                WriteFunction(offset, newValues);

                offset = 0x6B715AF2;
                newValues = new byte[] { 0x3E, 0x0F, };
                WriteFunction(offset, newValues);

                offset = 0x6B6EF134;
                newValues = new byte[] { 0x0A, 0x0E, };
                WriteFunction(offset, newValues);

                offset = 0x6B6F4F3C;
                newValues = new byte[] { 0xA8, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B71733A;
                newValues = new byte[] { 0x34, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B71AFEE;
                newValues = new byte[] { 0xC9, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B71C63E;
                newValues = new byte[] { 0xE6, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B714352;
                newValues = new byte[] { 0x5A, 0x0F, };
                WriteFunction(offset, newValues);

                offset = 0x6B6E334C;
                newValues = new byte[] { 0x6D, 0x04, };
                WriteFunction(offset, newValues);

                offset = 0x6B6CD6D4;
                newValues = new byte[] { 0x40, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B6E43E4;
                newValues = new byte[] { 0x53, 0x0F, };
                WriteFunction(offset, newValues);

                offset = 0x6B69D24C;
                newValues = new byte[] { 0x06, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B71A6BE;
                newValues = new byte[] { 0xA4, 0x0E, };
                WriteFunction(offset, newValues);

                offset = 0x6B71A694;
                newValues = new byte[] { 0x04, 0x0F, };
                WriteFunction(offset, newValues);

                offset = 0x6B71B192;
                newValues = new byte[] { 0x9D, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B71B096;
                newValues = new byte[] { 0x69, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B7160B0;
                newValues = new byte[] { 0xEF, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B6FF268;
                newValues = new byte[] { 0xEF, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B6FB4A4;
                newValues = new byte[] { 0xF4, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B6FEDCC;
                newValues = new byte[] { 0xA3, 0x0E, };
                WriteFunction(offset, newValues);

                offset = 0x6B6FE758;
                newValues = new byte[] { 0x2C, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B71A4C6;
                newValues = new byte[] { 0x9A, 0x0E, };
                WriteFunction(offset, newValues);

                offset = 0x6B71A4F0;
                newValues = new byte[] { 0x47, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B71A100;
                newValues = new byte[] { 0xF2, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B6E846C;
                newValues = new byte[] { 0xFB, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B6E9418;
                newValues = new byte[] { 0x53, 0x0F, };
                WriteFunction(offset, newValues);

                offset = 0x6B6E7870;
                newValues = new byte[] { 0x0A, 0x0E, };
                WriteFunction(offset, newValues);

                offset = 0x6B6E8730;
                newValues = new byte[] { 0xDF, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B71A27A;
                newValues = new byte[] { 0xE2, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B71A2A4;
                newValues = new byte[] { 0xBF, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B71A34C;
                newValues = new byte[] { 0x87, 0x0E, };
                WriteFunction(offset, newValues);

                offset = 0x6B71A250;
                newValues = new byte[] { 0x8F, 0x0E, };
                WriteFunction(offset, newValues);

                offset = 0x6B6E68C4;
                newValues = new byte[] { 0xEF, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B6E6B88;
                newValues = new byte[] { 0xCD, 0x04, };
                WriteFunction(offset, newValues);

                offset = 0x6B6E6E4C;
                newValues = new byte[] { 0xB7, 0x09, };
                WriteFunction(offset, newValues);

                offset = 0x6B6E6C74;
                newValues = new byte[] { 0x0A, 0x0E, };
                WriteFunction(offset, newValues);

                offset = 0x6B71A790;
                newValues = new byte[] { 0xF8, 0x0E, };
                WriteFunction(offset, newValues);

                offset = 0x6B7444CE;
                newValues = new byte[] { 0x04, 0x0A, };
                WriteFunction(offset, newValues);

                offset = 0x6B717EB6;
                newValues = new byte[] { 0x6F, 0x0E, };
                WriteFunction(offset, newValues);

                offset = 0x6B700FE8;
                newValues = new byte[] { 0x0A, 0x0E, };
                WriteFunction(offset, newValues);

                offset = 0x6B6C83DC;
                newValues = new byte[] { 0xEF, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B7011C0;
                newValues = new byte[] { 0xDD, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B7186C0;
                newValues = new byte[] { 0xE2, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B7180AE;
                newValues = new byte[] { 0xA4, 0x0E, };
                WriteFunction(offset, newValues);

                offset = 0x6B717CBE;
                newValues = new byte[] { 0xF4, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B6F8864;
                newValues = new byte[] { 0x53, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B6BE460;
                newValues = new byte[] { 0x06, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B6CBA40;
                newValues = new byte[] { 0x0A, 0x0E, };
                WriteFunction(offset, newValues);

                offset = 0x6B6BE54C;
                newValues = new byte[] { 0xC1, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B71526A;
                newValues = new byte[] { 0xEF, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B714B86;
                newValues = new byte[] { 0x9B, 0x04, };
                WriteFunction(offset, newValues);

                offset = 0x6B71C1D0;
                newValues = new byte[] { 0x78, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B71C128;
                newValues = new byte[] { 0x5E, 0x0E, };
                WriteFunction(offset, newValues);

                offset = 0x6B74A450;
                newValues = new byte[] { 0xAC, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B714256;
                newValues = new byte[] { 0xA4, 0x0E, };
                WriteFunction(offset, newValues);

                offset = 0x6B71422C;
                newValues = new byte[] { 0x31, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B718570;
                newValues = new byte[] { 0xE0, 0x0E, };
                WriteFunction(offset, newValues);

                offset = 0x6B713EBA;
                newValues = new byte[] { 0xA9, 0x0E, };
                WriteFunction(offset, newValues);

                offset = 0x6B7143FA;
                newValues = new byte[] { 0xB7, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B717C16;
                newValues = new byte[] { 0x29, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B709594;
                newValues = new byte[] { 0xD9, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B7093BC;
                newValues = new byte[] { 0xEA, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B6BD2DC;
                newValues = new byte[] { 0x0A, 0x0E, };
                WriteFunction(offset, newValues);

                offset = 0x6B6F1528;
                newValues = new byte[] { 0xC9, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B718324;
                newValues = new byte[] { 0x34, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B715C96;
                newValues = new byte[] { 0xE5, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B715EE2;
                newValues = new byte[] { 0xDC, 0x0E, };
                WriteFunction(offset, newValues);

                offset = 0x6B714910;
                newValues = new byte[] { 0xFC, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B71794C;
                newValues = new byte[] { 0x9C, 0x04, };
                WriteFunction(offset, newValues);

                offset = 0x6B717A48;
                newValues = new byte[] { 0xF1, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B717E8C;
                newValues = new byte[] { 0x65, 0x0F, };
                WriteFunction(offset, newValues);

                offset = 0x6B6CD060;
                newValues = new byte[] { 0xEF, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B6FB2CC;
                newValues = new byte[] { 0xE3, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B718084;
                newValues = new byte[] { 0xC7, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B713FE0;
                newValues = new byte[] { 0x31, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B71834E;
                newValues = new byte[] { 0xA3, 0x0E, };
                WriteFunction(offset, newValues);

                offset = 0x6B714088;
                newValues = new byte[] { 0xDC, 0x0E, };
                WriteFunction(offset, newValues);

                offset = 0x6B708324;
                newValues = new byte[] { 0x0A, 0x0E, };
                WriteFunction(offset, newValues);

                offset = 0x6B6CCE88;
                newValues = new byte[] { 0xEF, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B6DA904;
                newValues = new byte[] { 0x65, 0x0F, };
                WriteFunction(offset, newValues);

                offset = 0x6B7150C6;
                newValues = new byte[] { 0x65, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B715462;
                newValues = new byte[] { 0xEF, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B6A13BC;
                newValues = new byte[] { 0x53, 0x0F, };
                WriteFunction(offset, newValues);

                offset = 0x6B6E1890;
                newValues = new byte[] { 0xD8, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B6E1C40;
                newValues = new byte[] { 0x1C, 0x0F, };
                WriteFunction(offset, newValues);

                offset = 0x6B6CE4A8;
                newValues = new byte[] { 0xF7, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B6E1130;
                newValues = new byte[] { 0x0A, 0x0E, };
                WriteFunction(offset, newValues);

                offset = 0x6B6CF718;
                newValues = new byte[] { 0x2C, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B71B06C;
                newValues = new byte[] { 0x31, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B717922;
                newValues = new byte[] { 0x6D, 0x04, };
                WriteFunction(offset, newValues);

                offset = 0x6B717BC2;
                newValues = new byte[] { 0xDF, 0x0E, };
                WriteFunction(offset, newValues);

                offset = 0x6B6CCD9C;
                newValues = new byte[] { 0x4E, 0x0E, };
                WriteFunction(offset, newValues);

                offset = 0x6B6CDB70;
                newValues = new byte[] { 0x5A, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B6DA72C;
                newValues = new byte[] { 0x3E, 0x0F, };
                WriteFunction(offset, newValues);

                offset = 0x6B6CFE78;
                newValues = new byte[] { 0x0A, 0x0E, };
                WriteFunction(offset, newValues);

                offset = 0x6B71866C;
                newValues = new byte[] { 0x9D, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B717DE4;
                newValues = new byte[] { 0x18, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B708B70;
                newValues = new byte[] { 0xBE, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B69DE48;
                newValues = new byte[] { 0xEF, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B708F20;
                newValues = new byte[] { 0x53, 0x0F, };
                WriteFunction(offset, newValues);

                offset = 0x6B6AC4C0;
                newValues = new byte[] { 0x06, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B6AC784;
                newValues = new byte[] { 0x18, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B708D48;
                newValues = new byte[] { 0x0A, 0x0E, };
                WriteFunction(offset, newValues);

                offset = 0x6B6ABD60;
                newValues = new byte[] { 0x4F, 0x0F, };
                WriteFunction(offset, newValues);

                offset = 0x6B71469A;
                newValues = new byte[] { 0x2C, 0x0E, };
                WriteFunction(offset, newValues);

                offset = 0x6B6BDA3C;
                newValues = new byte[] { 0x6B, 0x0F, };
                WriteFunction(offset, newValues);

                offset = 0x6B6B45D0;
                newValues = new byte[] { 0x4E, 0x0E, };
                WriteFunction(offset, newValues);

                offset = 0x6B6C5214;
                newValues = new byte[] { 0x53, 0x0F, };
                WriteFunction(offset, newValues);

                offset = 0x6B6D12C0;
                newValues = new byte[] { 0xC9, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B6BB90C;
                newValues = new byte[] { 0xEF, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B717C6A;
                newValues = new byte[] { 0x31, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B717976;
                newValues = new byte[] { 0xE3, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B702AA4;
                newValues = new byte[] { 0x1D, 0x06, };
                WriteFunction(offset, newValues);

                offset = 0x6B6BB298;
                newValues = new byte[] { 0x96, 0x0B, };
                WriteFunction(offset, newValues);

                offset = 0x6B702344;
                newValues = new byte[] { 0xEA, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B7027E0;
                newValues = new byte[] { 0x7B, 0x06, };
                WriteFunction(offset, newValues);

                offset = 0x6B71B0C0;
                newValues = new byte[] { 0xE1, 0x0E, };
                WriteFunction(offset, newValues);

                offset = 0x6B6CEFB8;
                newValues = new byte[] { 0x0A, 0x0E, };
                WriteFunction(offset, newValues);

                offset = 0x6B6A13C0;
                newValues = new byte[] { 0x40, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B69AE58;
                newValues = new byte[] { 0x90, 0x04, };
                WriteFunction(offset, newValues);

                offset = 0x6B6991C4;
                newValues = new byte[] { 0xA4, 0x0E, };
                WriteFunction(offset, newValues);

                offset = 0x6B7179F4;
                newValues = new byte[] { 0x9D, 0x04, };
                WriteFunction(offset, newValues);

                offset = 0x6B714034;
                newValues = new byte[] { 0x70, 0x04, };
                WriteFunction(offset, newValues);

                offset = 0x6B6EA688;
                newValues = new byte[] { 0xEF, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B6EC7B8;
                newValues = new byte[] { 0x2F, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B718228;
                newValues = new byte[] { 0xD6, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B7173B8;
                newValues = new byte[] { 0x10, 0x0F, };
                WriteFunction(offset, newValues);

                offset = 0x6B6F4B8C;
                newValues = new byte[] { 0xAA, 0x0E, };
                WriteFunction(offset, newValues);

                offset = 0x6B6F4AA0;
                newValues = new byte[] { 0x25, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B6E070C;
                newValues = new byte[] { 0x6B, 0x0F, };
                WriteFunction(offset, newValues);

                offset = 0x6B6E0448;
                newValues = new byte[] { 0x0A, 0x0E, };
                WriteFunction(offset, newValues);

                offset = 0x6B6C77E0;
                newValues = new byte[] { 0xDF, 0x0E, };
                WriteFunction(offset, newValues);

                offset = 0x6B718792;
                newValues = new byte[] { 0x5E, 0x0E, };
                WriteFunction(offset, newValues);

                offset = 0x6B71A544;
                newValues = new byte[] { 0x9B, 0x0E, };
                WriteFunction(offset, newValues);

                offset = 0x6B6CD14C;
                newValues = new byte[] { 0x0A, 0x0E, };
                WriteFunction(offset, newValues);

                offset = 0x6B719290;
                newValues = new byte[] { 0x6F, 0x0E, };
                WriteFunction(offset, newValues);

                offset = 0x6B715828;
                newValues = new byte[] { 0x3E, 0x0F, };
                WriteFunction(offset, newValues);

                offset = 0x6B719362;
                newValues = new byte[] { 0xF2, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B6F706C;
                newValues = new byte[] { 0xEF, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B6F6CBC;
                newValues = new byte[] { 0x16, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B700EFC;
                newValues = new byte[] { 0x85, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B6F6AE4;
                newValues = new byte[] { 0x0A, 0x0E, };
                WriteFunction(offset, newValues);

                offset = 0x6B6ACA48;
                newValues = new byte[] { 0xE6, 0x0C, };
                WriteFunction(offset, newValues);



            }
            else //original
            {
                uint offset = 0x6B7182D0;
                byte[] newValues = new byte[] { 0x9C, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B7157D4;
                newValues = new byte[] { 0xDC, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B7193E0;
                newValues = new byte[] { 0xDB, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B718696;
                newValues = new byte[] { 0x4B, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B715F60;
                newValues = new byte[] { 0xC0, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B718180;
                newValues = new byte[] { 0xC2, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B7180D8;
                newValues = new byte[] { 0xC0, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B69EDF4;
                newValues = new byte[] { 0xAC, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B6C6EA8;
                newValues = new byte[] { 0x5D, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B6BD5A0;
                newValues = new byte[] { 0x66, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B71B23A;
                newValues = new byte[] { 0x3F, 0x0F, };
                WriteFunction(offset, newValues);

                offset = 0x6B6D5AA8;
                newValues = new byte[] { 0x60, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B6BD104;
                newValues = new byte[] { 0x4A, 0x0F, };
                WriteFunction(offset, newValues);

                offset = 0x6B6BE8FC;
                newValues = new byte[] { 0x5D, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B71572C;
                newValues = new byte[] { 0xD7, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B7157FE;
                newValues = new byte[] { 0x88, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B715438;
                newValues = new byte[] { 0xDE, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B717532;
                newValues = new byte[] { 0xDC, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B714574;
                newValues = new byte[] { 0xDC, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B7443FC;
                newValues = new byte[] { 0x5C, 0x02, };
                WriteFunction(offset, newValues);

                offset = 0x6B744474;
                newValues = new byte[] { 0x59, 0x02, };
                WriteFunction(offset, newValues);

                offset = 0x6B6E0184;
                newValues = new byte[] { 0x60, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B6F7F2C;
                newValues = new byte[] { 0x60, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B6F7E40;
                newValues = new byte[] { 0x60, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B6F7A90;
                newValues = new byte[] { 0x60, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B6C4618;
                newValues = new byte[] { 0xAA, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B7174DE;
                newValues = new byte[] { 0xD7, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B715A20;
                newValues = new byte[] { 0x5D, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B715366;
                newValues = new byte[] { 0xD2, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B719F08;
                newValues = new byte[] { 0xA0, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B715E64;
                newValues = new byte[] { 0x85, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B744456;
                newValues = new byte[] { 0x5C, 0x02, };
                WriteFunction(offset, newValues);

                offset = 0x6B6E0270;
                newValues = new byte[] { 0x0B, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B6E035C;
                newValues = new byte[] { 0x60, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B6F4E50;
                newValues = new byte[] { 0x51, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B6C8118;
                newValues = new byte[] { 0x63, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B719F32;
                newValues = new byte[] { 0xBC, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B74A46E;
                newValues = new byte[] { 0x5C, 0x02, };
                WriteFunction(offset, newValues);

                offset = 0x6B7154B6;
                newValues = new byte[] { 0xAE, 0x0E, };
                WriteFunction(offset, newValues);

                offset = 0x6B717310;
                newValues = new byte[] { 0x4A, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B71612E;
                newValues = new byte[] { 0xDC, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B7158D0;
                newValues = new byte[] { 0x85, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B716032;
                newValues = new byte[] { 0xDB, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B71605C;
                newValues = new byte[] { 0xDB, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B718618;
                newValues = new byte[] { 0x4B, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B715DE6;
                newValues = new byte[] { 0x5C, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B718102;
                newValues = new byte[] { 0x68, 0x0F, };
                WriteFunction(offset, newValues);

                offset = 0x6B715198;
                newValues = new byte[] { 0xDC, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B6BAC24;
                newValues = new byte[] { 0x5D, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B6B9340;
                newValues = new byte[] { 0x60, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B6BAA4C;
                newValues = new byte[] { 0x60, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B69C828;
                newValues = new byte[] { 0xAA, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B6AC698;
                newValues = new byte[] { 0x5D, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B6C4F50;
                newValues = new byte[] { 0x51, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B7197FA;
                newValues = new byte[] { 0x5D, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B7142D4;
                newValues = new byte[] { 0xA0, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B6BDC10;
                newValues = new byte[] { 0xA1, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B7186EA;
                newValues = new byte[] { 0x4B, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B6BDD00;
                newValues = new byte[] { 0x51, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B6C6BE4;
                newValues = new byte[] { 0x60, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B6B8A08;
                newValues = new byte[] { 0x63, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B6BE374;
                newValues = new byte[] { 0x60, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B705D58;
                newValues = new byte[] { 0x5D, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B717364;
                newValues = new byte[] { 0xD7, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B715606;
                newValues = new byte[] { 0xDC, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B7192BA;
                newValues = new byte[] { 0x51, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B7192E4;
                newValues = new byte[] { 0xD2, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B71812C;
                newValues = new byte[] { 0xA8, 0x0E, };
                WriteFunction(offset, newValues);

                offset = 0x6B6BBE94;
                newValues = new byte[] { 0x51, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B6BBF80;
                newValues = new byte[] { 0x60, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B6BFE30;
                newValues = new byte[] { 0x51, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B6B51CC;
                newValues = new byte[] { 0x51, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B6984DC;
                newValues = new byte[] { 0x5D, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B7174B4;
                newValues = new byte[] { 0x44, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B715F36;
                newValues = new byte[] { 0xDB, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B715390;
                newValues = new byte[] { 0xD7, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B71930E;
                newValues = new byte[] { 0xD2, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B7444B0;
                newValues = new byte[] { 0x5A, 0x02, };
                WriteFunction(offset, newValues);

                offset = 0x6B74441A;
                newValues = new byte[] { 0x5C, 0x02, };
                WriteFunction(offset, newValues);

                offset = 0x6B6B4E1C;
                newValues = new byte[] { 0x5D, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B69A8D0;
                newValues = new byte[] { 0x5D, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B708238;
                newValues = new byte[] { 0x51, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B6DDCA4;
                newValues = new byte[] { 0x63, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B6DE318;
                newValues = new byte[] { 0x60, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B6DE6C8;
                newValues = new byte[] { 0x51, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B6DE140;
                newValues = new byte[] { 0x51, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B714868;
                newValues = new byte[] { 0x2D, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B715F0C;
                newValues = new byte[] { 0xDB, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B71738E;
                newValues = new byte[] { 0xD7, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B6BE638;
                newValues = new byte[] { 0xAA, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B69CAEC;
                newValues = new byte[] { 0xAA, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B6B942C;
                newValues = new byte[] { 0x60, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B6B9604;
                newValues = new byte[] { 0x5D, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B6BB55C;
                newValues = new byte[] { 0x5D, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B7140DC;
                newValues = new byte[] { 0x5D, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B7158A6;
                newValues = new byte[] { 0xD7, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B715FDE;
                newValues = new byte[] { 0xD7, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B744492;
                newValues = new byte[] { 0x5A, 0x02, };
                WriteFunction(offset, newValues);

                offset = 0x6B714FF4;
                newValues = new byte[] { 0x60, 0x0F, };
                WriteFunction(offset, newValues);

                offset = 0x6B6FBB18;
                newValues = new byte[] { 0x60, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B6FBFB4;
                newValues = new byte[] { 0x5D, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B6FC0A0;
                newValues = new byte[] { 0x51, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B6C4354;
                newValues = new byte[] { 0x5D, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B6C79B8;
                newValues = new byte[] { 0x60, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B6FB590;
                newValues = new byte[] { 0x60, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B6FB854;
                newValues = new byte[] { 0x51, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B71A1D2;
                newValues = new byte[] { 0xDC, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B71A154;
                newValues = new byte[] { 0xD2, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B715EB8;
                newValues = new byte[] { 0x5C, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B7142AA;
                newValues = new byte[] { 0x86, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B71400A;
                newValues = new byte[] { 0xCD, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B6EB284;
                newValues = new byte[] { 0x66, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B6EA59C;
                newValues = new byte[] { 0x0B, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B6EAFC0;
                newValues = new byte[] { 0x63, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B6EAED4;
                newValues = new byte[] { 0x51, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B6E9D50;
                newValues = new byte[] { 0x51, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B6EA774;
                newValues = new byte[] { 0x60, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B6E9A8C;
                newValues = new byte[] { 0x60, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B6EB548;
                newValues = new byte[] { 0x5D, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B6EB45C;
                newValues = new byte[] { 0x66, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B71A88C;
                newValues = new byte[] { 0xAE, 0x0E, };
                WriteFunction(offset, newValues);

                offset = 0x6B71955A;
                newValues = new byte[] { 0xAE, 0x0E, };
                WriteFunction(offset, newValues);

                offset = 0x6B715AF2;
                newValues = new byte[] { 0x9A, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B6EF134;
                newValues = new byte[] { 0x51, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B6F4F3C;
                newValues = new byte[] { 0x51, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B71733A;
                newValues = new byte[] { 0xD2, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B71AFEE;
                newValues = new byte[] { 0xDB, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B71C63E;
                newValues = new byte[] { 0xDB, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B714352;
                newValues = new byte[] { 0xBC, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B6E334C;
                newValues = new byte[] { 0x60, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B6CD6D4;
                newValues = new byte[] { 0x63, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B6E43E4;
                newValues = new byte[] { 0x63, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B69D24C;
                newValues = new byte[] { 0xAA, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B71A6BE;
                newValues = new byte[] { 0x85, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B71A694;
                newValues = new byte[] { 0x51, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B71B192;
                newValues = new byte[] { 0xDB, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B71B096;
                newValues = new byte[] { 0xDC, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B7160B0;
                newValues = new byte[] { 0x18, 0x0E, };
                WriteFunction(offset, newValues);

                offset = 0x6B6FF268;
                newValues = new byte[] { 0x5D, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B6FB4A4;
                newValues = new byte[] { 0x63, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B6FEDCC;
                newValues = new byte[] { 0x51, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B6FE758;
                newValues = new byte[] { 0x63, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B71A4C6;
                newValues = new byte[] { 0xDC, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B71A4F0;
                newValues = new byte[] { 0xDC, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B71A100;
                newValues = new byte[] { 0xBC, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B6E846C;
                newValues = new byte[] { 0xAA, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B6E9418;
                newValues = new byte[] { 0x63, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B6E7870;
                newValues = new byte[] { 0x60, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B6E8730;
                newValues = new byte[] { 0x51, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B71A27A;
                newValues = new byte[] { 0xD7, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B71A2A4;
                newValues = new byte[] { 0xF0, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B71A34C;
                newValues = new byte[] { 0xD2, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B71A250;
                newValues = new byte[] { 0xD2, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B6E68C4;
                newValues = new byte[] { 0xAA, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B6E6B88;
                newValues = new byte[] { 0x5D, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B6E6E4C;
                newValues = new byte[] { 0x5D, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B6E6C74;
                newValues = new byte[] { 0x60, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B71A790;
                newValues = new byte[] { 0xD7, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B7444CE;
                newValues = new byte[] { 0x5A, 0x02, };
                WriteFunction(offset, newValues);

                offset = 0x6B717EB6;
                newValues = new byte[] { 0xF0, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B700FE8;
                newValues = new byte[] { 0x60, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B6C83DC;
                newValues = new byte[] { 0x60, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B7011C0;
                newValues = new byte[] { 0x51, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B7186C0;
                newValues = new byte[] { 0x4B, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B7180AE;
                newValues = new byte[] { 0x5D, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B717CBE;
                newValues = new byte[] { 0xA0, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B6F8864;
                newValues = new byte[] { 0x5D, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B6BE460;
                newValues = new byte[] { 0xA7, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B6CBA40;
                newValues = new byte[] { 0x63, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B6BE54C;
                newValues = new byte[] { 0x5D, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B71526A;
                newValues = new byte[] { 0x5D, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B714B86;
                newValues = new byte[] { 0x44, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B71C1D0;
                newValues = new byte[] { 0xD7, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B71C128;
                newValues = new byte[] { 0x5D, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B74A450;
                newValues = new byte[] { 0x5A, 0x02, };
                WriteFunction(offset, newValues);

                offset = 0x6B714256;
                newValues = new byte[] { 0x85, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B71422C;
                newValues = new byte[] { 0xCE, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B718570;
                newValues = new byte[] { 0x5D, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B713EBA;
                newValues = new byte[] { 0xAE, 0x0E, };
                WriteFunction(offset, newValues);

                offset = 0x6B7143FA;
                newValues = new byte[] { 0x60, 0x0F, };
                WriteFunction(offset, newValues);

                offset = 0x6B717C16;
                newValues = new byte[] { 0xA0, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B709594;
                newValues = new byte[] { 0x51, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B7093BC;
                newValues = new byte[] { 0xAA, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B6BD2DC;
                newValues = new byte[] { 0x5D, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B6F1528;
                newValues = new byte[] { 0x63, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B718324;
                newValues = new byte[] { 0xD7, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B715C96;
                newValues = new byte[] { 0xDC, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B715EE2;
                newValues = new byte[] { 0xDC, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B714910;
                newValues = new byte[] { 0xDB, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B71794C;
                newValues = new byte[] { 0xCC, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B717A48;
                newValues = new byte[] { 0x86, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B717E8C;
                newValues = new byte[] { 0xD7, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B6CD060;
                newValues = new byte[] { 0x5D, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B6FB2CC;
                newValues = new byte[] { 0x60, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B718084;
                newValues = new byte[] { 0xD2, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B713FE0;
                newValues = new byte[] { 0xD7, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B71834E;
                newValues = new byte[] { 0xDC, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B714088;
                newValues = new byte[] { 0xDC, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B708324;
                newValues = new byte[] { 0x51, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B6CCE88;
                newValues = new byte[] { 0x5D, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B6DA904;
                newValues = new byte[] { 0x51, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B7150C6;
                newValues = new byte[] { 0x87, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B715462;
                newValues = new byte[] { 0x5D, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B6A13BC;
                newValues = new byte[] { 0x66, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B6E1890;
                newValues = new byte[] { 0x63, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B6E1C40;
                newValues = new byte[] { 0x51, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B6CE4A8;
                newValues = new byte[] { 0x5D, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B6E1130;
                newValues = new byte[] { 0x60, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B6CF718;
                newValues = new byte[] { 0x63, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B71B06C;
                newValues = new byte[] { 0xD2, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B717922;
                newValues = new byte[] { 0x85, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B717BC2;
                newValues = new byte[] { 0xA0, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B6CCD9C;
                newValues = new byte[] { 0x60, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B6CDB70;
                newValues = new byte[] { 0x51, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B6DA72C;
                newValues = new byte[] { 0x60, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B6CFE78;
                newValues = new byte[] { 0x60, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B71866C;
                newValues = new byte[] { 0x4B, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B717DE4;
                newValues = new byte[] { 0xBC, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B708B70;
                newValues = new byte[] { 0x51, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B69DE48;
                newValues = new byte[] { 0x5D, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B708F20;
                newValues = new byte[] { 0x63, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B6AC4C0;
                newValues = new byte[] { 0x63, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B6AC784;
                newValues = new byte[] { 0xA1, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B708D48;
                newValues = new byte[] { 0x60, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B6ABD60;
                newValues = new byte[] { 0xAA, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B71469A;
                newValues = new byte[] { 0xDB, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B6BDA3C;
                newValues = new byte[] { 0x60, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B6B45D0;
                newValues = new byte[] { 0x60, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B6C5214;
                newValues = new byte[] { 0x63, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B6D12C0;
                newValues = new byte[] { 0x51, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B6BB90C;
                newValues = new byte[] { 0x60, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B717C6A;
                newValues = new byte[] { 0xA0, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B717976;
                newValues = new byte[] { 0xCD, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B702AA4;
                newValues = new byte[] { 0xAA, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B6BB298;
                newValues = new byte[] { 0x5D, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B702344;
                newValues = new byte[] { 0x5D, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B7027E0;
                newValues = new byte[] { 0xAA, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B71B0C0;
                newValues = new byte[] { 0xD2, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B6CEFB8;
                newValues = new byte[] { 0xAA, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B6A13C0;
                newValues = new byte[] { 0xAA, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B69AE58;
                newValues = new byte[] { 0x5D, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B6991C4;
                newValues = new byte[] { 0x63, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B7179F4;
                newValues = new byte[] { 0xCE, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B714034;
                newValues = new byte[] { 0x87, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B6EA688;
                newValues = new byte[] { 0x5D, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B6EC7B8;
                newValues = new byte[] { 0x5D, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B718228;
                newValues = new byte[] { 0xD2, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B7173B8;
                newValues = new byte[] { 0xD7, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B6F4B8C;
                newValues = new byte[] { 0xAA, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B6F4AA0;
                newValues = new byte[] { 0x51, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B6E070C;
                newValues = new byte[] { 0x0B, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B6E0448;
                newValues = new byte[] { 0x51, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B6C77E0;
                newValues = new byte[] { 0x51, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B718792;
                newValues = new byte[] { 0xDB, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B71A544;
                newValues = new byte[] { 0x60, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B6CD14C;
                newValues = new byte[] { 0x60, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B719290;
                newValues = new byte[] { 0x5C, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B715828;
                newValues = new byte[] { 0xD2, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B719362;
                newValues = new byte[] { 0xBC, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B6F706C;
                newValues = new byte[] { 0x5D, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B6F6CBC;
                newValues = new byte[] { 0x5D, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B700EFC;
                newValues = new byte[] { 0x5D, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B6F6AE4;
                newValues = new byte[] { 0x60, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B6ACA48;
                newValues = new byte[] { 0x63, 0x0C, };
                WriteFunction(offset, newValues);

            }
        }
        #endregion

        #region Golem_moveset

        public static void GolemBrokenShitMoveset()
        {
            if (SettingsClass.GolemBrokenShitMoves) //custom
            {
                uint offset = 0x6B76635A;
                byte[] newValues = new byte[] { 0x3F, 0x07, };
                WriteFunction(offset, newValues);

                offset = 0x6B766372;
                newValues = new byte[] { 0xC1, 0x0B, };
                WriteFunction(offset, newValues);

                offset = 0x6B76638A;
                newValues = new byte[] { 0xA9, 0x0A, };
                WriteFunction(offset, newValues);

                offset = 0x6B7663A2;
                newValues = new byte[] { 0xF4, 0x05, };
                WriteFunction(offset, newValues);

                offset = 0x6B766216;
                newValues = new byte[] { 0xD7, 0x07, };
                WriteFunction(offset, newValues);

                offset = 0x6B766360;
                newValues = new byte[] { 0xF3, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B766374;
                newValues = new byte[] { 0x8E, 0x06, };
                WriteFunction(offset, newValues);

                offset = 0x6B76638E;
                newValues = new byte[] { 0x80, 0x05, };
                WriteFunction(offset, newValues);

                offset = 0x6B7663A4;
                newValues = new byte[] { 0x17, 0x08, };
                WriteFunction(offset, newValues);

                offset = 0x6B766214;
                newValues = new byte[] { 0xD5, 0x07, };
                WriteFunction(offset, newValues);

                offset = 0x6B766218;
                newValues = new byte[] { 0x44, 0x07, };
                WriteFunction(offset, newValues);

                offset = 0x6B766212;
                newValues = new byte[] { 0x40, 0x07, };
                WriteFunction(offset, newValues);

                offset = 0x6B7663A8;
                newValues = new byte[] { 0xEC, 0x06, };
                WriteFunction(offset, newValues);

                offset = 0x6B766378;
                newValues = new byte[] { 0xD7, 0x0A, };
                WriteFunction(offset, newValues);

                offset = 0x6B766390;
                newValues = new byte[] { 0x89, 0x04, };
                WriteFunction(offset, newValues);

                offset = 0x6B7663A6;
                newValues = new byte[] { 0x97, 0x08, };
                WriteFunction(offset, newValues);

                offset = 0x6B7661CA;
                newValues = new byte[] { 0x45, 0x03, };
                WriteFunction(offset, newValues);

                offset = 0x6B76619E;
                newValues = new byte[] { 0x8E, 0x06, };
                WriteFunction(offset, newValues);

                offset = 0x6B7661A0;
                newValues = new byte[] { 0x97, 0x08, };
                WriteFunction(offset, newValues);
            }
            else //original
            {
                uint offset = 0x6B76635A;
                byte[] newValues = new byte[] { 0x7C, 0x0B, };
                WriteFunction(offset, newValues);

                offset = 0x6B766372;
                newValues = new byte[] { 0x35, 0x05, };
                WriteFunction(offset, newValues);

                offset = 0x6B76638A;
                newValues = new byte[] { 0x1F, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B7663A2;
                newValues = new byte[] { 0xA3, 0x07, };
                WriteFunction(offset, newValues);

                offset = 0x6B766216;
                newValues = new byte[] { 0xD6, 0x07, };
                WriteFunction(offset, newValues);

                offset = 0x6B766360;
                newValues = new byte[] { 0xA5, 0x0A, };
                WriteFunction(offset, newValues);
                
                offset = 0x6B766374;
                newValues = new byte[] { 0x45, 0x0A, };
                WriteFunction(offset, newValues);

                offset = 0x6B76638E;
                newValues = new byte[] { 0xA2, 0x07, };
                WriteFunction(offset, newValues);

                offset = 0x6B7663A4;
                newValues = new byte[] { 0x3D, 0x0A, };
                WriteFunction(offset, newValues);

                offset = 0x6B766214;
                newValues = new byte[] { 0xC1, 0x0B, };
                WriteFunction(offset, newValues);

                offset = 0x6B766218;
                newValues = new byte[] { 0xF4, 0x05, };
                WriteFunction(offset, newValues);

                offset = 0x6B766212;
                newValues = new byte[] { 0x3F, 0x07, };
                WriteFunction(offset, newValues);

                offset = 0x6B7663A8;
                newValues = new byte[] { 0x98, 0x07, };
                WriteFunction(offset, newValues);

                offset = 0x6B766378;
                newValues = new byte[] { 0x41, 0x09, };
                WriteFunction(offset, newValues);

                offset = 0x6B766390;
                newValues = new byte[] { 0x34, 0x05, };
                WriteFunction(offset, newValues);

                offset = 0x6B7663A6;
                newValues = new byte[] { 0x3D, 0x0A, };
                WriteFunction(offset, newValues);

                offset = 0x6B7661CA;
                newValues = new byte[] { 0xDB, 0x03, };
                WriteFunction(offset, newValues);

                offset = 0x6B76619E;
                newValues = new byte[] { 0x1D, 0x00, };
                WriteFunction(offset, newValues);

                offset = 0x6B7661A0;
                newValues = new byte[] { 0x3E, 0x00, };
                WriteFunction(offset, newValues);
            }
        }

        #endregion

        #region Bordin_moveset

        public static void BordinAllAroundMoveset()
        {
            if (SettingsClass.BordinAllAroundMoves) //custom
            {
                uint offset = 0x6B7473AE;
                byte[] newValues = new byte[] { 0xCB, 0x0B, };
                WriteFunction(offset, newValues);

                offset = 0x6B766A6A;
                newValues = new byte[] { 0x3F, 0x07, };
                WriteFunction(offset, newValues);

                offset = 0x6B766A6C;
                newValues = new byte[] { 0xEC, 0x06, };
                WriteFunction(offset, newValues);

                offset = 0x6B766A6E;
                newValues = new byte[] { 0x99, 0x0A, };
                WriteFunction(offset, newValues);

                offset = 0x6B766A70;
                newValues = new byte[] { 0x44, 0x07, };
                WriteFunction(offset, newValues);

                offset = 0x6B766BB2;
                newValues = new byte[] { 0x35, 0x05, };
                WriteFunction(offset, newValues);

                offset = 0x6B766BB8;
                newValues = new byte[] { 0xC6, 0x0A, };
                WriteFunction(offset, newValues);

                offset = 0x6B766BCA;
                newValues = new byte[] { 0x80, 0x08, };
                WriteFunction(offset, newValues);

                offset = 0x6B766BE2;
                newValues = new byte[] { 0x9E, 0x08, };
                WriteFunction(offset, newValues);

                offset = 0x6B766BFA;
                newValues = new byte[] { 0x2A, 0x07, };
                WriteFunction(offset, newValues);

                offset = 0x6B766C00;
                newValues = new byte[] { 0x05, 0x0B, };
                WriteFunction(offset, newValues);

                offset = 0x6B766C40;
                newValues = new byte[] { 0x0A, 0x0E, };
                WriteFunction(offset, newValues);

                offset = 0x6B766C5E;
                newValues = new byte[] { 0xC9, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B766C7C;
                newValues = new byte[] { 0xA9, 0x0E, };
                WriteFunction(offset, newValues);
            }
            else //original
            {
                uint offset = 0x6B7473AE;
                byte[] newValues = new byte[] { 0xF8, 0x0E, };
                WriteFunction(offset, newValues);

                offset = 0x6B766A6A;
                newValues = new byte[] { 0x89, 0x04, };
                WriteFunction(offset, newValues);

                offset = 0x6B766A6C;
                newValues = new byte[] { 0x42, 0x07, };
                WriteFunction(offset, newValues);

                offset = 0x6B766A6E;
                newValues = new byte[] { 0xCD, 0x0B, };
                WriteFunction(offset, newValues);

                offset = 0x6B766A70;
                newValues = new byte[] { 0xCB, 0x0B, };
                WriteFunction(offset, newValues);

                offset = 0x6B766BB2;
                newValues = new byte[] { 0x07, 0x0B, };
                WriteFunction(offset, newValues);

                offset = 0x6B766BB8;
                newValues = new byte[] { 0x14, 0x0B, };
                WriteFunction(offset, newValues);

                offset = 0x6B766BCA;
                newValues = new byte[] { 0x17, 0x0B, };
                WriteFunction(offset, newValues);

                offset = 0x6B766BE2;
                newValues = new byte[] { 0x04, 0x0B, };
                WriteFunction(offset, newValues);

                offset = 0x6B766BFA;
                newValues = new byte[] { 0xCA, 0x0B, };
                WriteFunction(offset, newValues);

                offset = 0x6B766C00;
                newValues = new byte[] { 0xF6, 0x07, };
                WriteFunction(offset, newValues);

                offset = 0x6B766C40;
                newValues = new byte[] { 0xCB, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B766C5E;
                newValues = new byte[] { 0xB0, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B766C7C;
                newValues = new byte[] { 0x5A, 0x0C, };
                WriteFunction(offset, newValues);
            }
        }

        #endregion

        #region Paul_moveset

        public static void PaulAshesMoveset()
        {
            if (SettingsClass.PaulAshesMoves) //custom
            {
                uint offset = 0x6B768D12;
                byte[] newValues = new byte[] { 0xF3, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B768D42;
                newValues = new byte[] { 0xD3, 0x09, };
                WriteFunction(offset, newValues);

                offset = 0x6B768D5A;
                newValues = new byte[] { 0xA9, 0x09, };
                WriteFunction(offset, newValues);

                offset = 0x6B768DA0;
                newValues = new byte[] { 0x0A, 0x0E, };
                WriteFunction(offset, newValues);

                offset = 0x6B768DDC;
                newValues = new byte[] { 0x35, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B768DBE;
                newValues = new byte[] { 0x53, 0x0F, };
                WriteFunction(offset, newValues);

                offset = 0x6B768D14;
                newValues = new byte[] { 0x10, 0x0E, };
                WriteFunction(offset, newValues);

                offset = 0x6B768DDE;
                newValues = new byte[] { 0xAF, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B768DA2;
                newValues = new byte[] { 0x53, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B768BCC;
                newValues = new byte[] { 0x80, 0x05, };
                WriteFunction(offset, newValues);

                offset = 0x6B768DC0;
                newValues = new byte[] { 0x21, 0x0E, };
                WriteFunction(offset, newValues);

                offset = 0x6B78369A;
                newValues = new byte[] { 0xEE, 0x0A, };
                WriteFunction(offset, newValues);

                offset = 0x6B78369E;
                newValues = new byte[] { 0xF3, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B7836CA;
                newValues = new byte[] { 0xD3, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B768DA4;
                newValues = new byte[] { 0x24, 0x0E, };
                WriteFunction(offset, newValues);

                offset = 0x6B768D30;
                newValues = new byte[] { 0xB3, 0x09, };
                WriteFunction(offset, newValues);

                offset = 0x6B768D44;
                newValues = new byte[] { 0x6D, 0x04, };
                WriteFunction(offset, newValues);

                offset = 0x6B7679CE;
                newValues = new byte[] { 0x6D, 0x04, };
                WriteFunction(offset, newValues);

                offset = 0x6B768D98;
                newValues = new byte[] { 0x8C, 0x05, };
                WriteFunction(offset, newValues);

                offset = 0x6B768DB6;
                newValues = new byte[] { 0x8C, 0x05, };
                WriteFunction(offset, newValues);

                offset = 0x6B768DB8;
                newValues = new byte[] { 0x58, 0x0F, };
                WriteFunction(offset, newValues);

                offset = 0x6B768D9A;
                newValues = new byte[] { 0x58, 0x0F, };
                WriteFunction(offset, newValues);

                offset = 0x6B768D4A;
                newValues = new byte[] { 0x6D, 0x04, };
                WriteFunction(offset, newValues);

                offset = 0x6B768D88;
                newValues = new byte[] { 0x8A, 0x0E, };
                WriteFunction(offset, newValues);

                offset = 0x6B824690;
                newValues = new byte[] { 0x8C, 0x0E, };
                WriteFunction(offset, newValues);
            }
            else //original
            {
                uint offset = 0x6B768D12;
                byte[] newValues = new byte[] { 0xA7, 0x09, };
                WriteFunction(offset, newValues);

                offset = 0x6B768D42;
                newValues = new byte[] { 0xB7, 0x09, };
                WriteFunction(offset, newValues);

                offset = 0x6B768D5A;
                newValues = new byte[] { 0xB5, 0x09, };
                WriteFunction(offset, newValues);

                offset = 0x6B768DA0;
                newValues = new byte[] { 0x87, 0x0E, };
                WriteFunction(offset, newValues);

                offset = 0x6B768DDC;
                newValues = new byte[] { 0x8F, 0x0E, };
                WriteFunction(offset, newValues);

                offset = 0x6B768DBE;
                newValues = new byte[] { 0x2C, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B768D14;
                newValues = new byte[] { 0xC1, 0x09, };
                WriteFunction(offset, newValues);

                offset = 0x6B768DDE;
                newValues = new byte[] { 0x4D, 0x0F, };
                WriteFunction(offset, newValues);

                offset = 0x6B768DA2;
                newValues = new byte[] { 0x88, 0x0E, };
                WriteFunction(offset, newValues);

                offset = 0x6B768BCC;
                newValues = new byte[] { 0xBB, 0x09, };
                WriteFunction(offset, newValues);

                offset = 0x6B768DC0;
                newValues = new byte[] { 0xFC, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B78369A;
                newValues = new byte[] { 0xEC, 0x0A, };
                WriteFunction(offset, newValues);

                offset = 0x6B78369E;
                newValues = new byte[] { 0xF6, 0x0A, };
                WriteFunction(offset, newValues);

                offset = 0x6B7836CA;
                newValues = new byte[] { 0xD3, 0x09, };
                WriteFunction(offset, newValues);

                offset = 0x6B768DA4;
                newValues = new byte[] { 0x89, 0x0E, };
                WriteFunction(offset, newValues);

                offset = 0x6B768D30;
                newValues = new byte[] { 0xB2, 0x09, };
                WriteFunction(offset, newValues);

                offset = 0x6B768D44;
                newValues = new byte[] { 0xC2, 0x05, };
                WriteFunction(offset, newValues);

                offset = 0x6B7679CE;
                newValues = new byte[] { 0xC1, 0x05, };
                WriteFunction(offset, newValues);

                offset = 0x6B768D98;
                newValues = new byte[] { 0x90, 0x0E, };
                WriteFunction(offset, newValues);

                offset = 0x6B768DB6;
                newValues = new byte[] { 0x91, 0x0E, };
                WriteFunction(offset, newValues);

                offset = 0x6B768DB8;
                newValues = new byte[] { 0x95, 0x0E, };
                WriteFunction(offset, newValues);

                offset = 0x6B768D9A;
                newValues = new byte[] { 0x94, 0x0E, };
                WriteFunction(offset, newValues);

                offset = 0x6B768D4A;
                newValues = new byte[] { 0xB6, 0x09, };
                WriteFunction(offset, newValues);

                offset = 0x6B768D88;
                newValues = new byte[] { 0x8A, 0x0E, };
                WriteFunction(offset, newValues);

                offset = 0x6B824690;
                newValues = new byte[] { 0x8C, 0x0E, };
                WriteFunction(offset, newValues);
            }
        }

        #endregion

        #region Shinkai_moveset

        public static void SakamotoRyomaMoveset()
        {
            if (SettingsClass.SakamotoRyomaMoves) //custom
            {
                uint offset = 0x6B774E80;
                byte[] newValues = new byte[] { 0x17, 0x08, };
                WriteFunction(offset, newValues);

                offset = 0x6B774E7E;
                newValues = new byte[] { 0xD5, 0x07, };
                WriteFunction(offset, newValues);

                offset = 0x6B774E7C;
                newValues = new byte[] { 0xB6, 0x05, };
                WriteFunction(offset, newValues);

                offset = 0x6B774FC2;
                newValues = new byte[] { 0x4E, 0x0B, };
                WriteFunction(offset, newValues);

                offset = 0x6B774FDA;
                newValues = new byte[] { 0x65, 0x0B, };
                WriteFunction(offset, newValues);

                offset = 0x6B774FC8;
                newValues = new byte[] { 0x14, 0x09, };
                WriteFunction(offset, newValues);

                offset = 0x6B774FE0;
                newValues = new byte[] { 0x42, 0x0B, };
                WriteFunction(offset, newValues);

                offset = 0x6B774FC6;
                newValues = new byte[] { 0xBB, 0x06, };
                WriteFunction(offset, newValues);

                offset = 0x6B774FF6;
                newValues = new byte[] { 0x35, 0x0B, };
                WriteFunction(offset, newValues);

                offset = 0x6B774FF4;
                newValues = new byte[] { 0x35, 0x0B, };
                WriteFunction(offset, newValues);

                offset = 0x6B774FDC;
                newValues = new byte[] { 0x94, 0x09, };
                WriteFunction(offset, newValues);

                offset = 0x6B774FDE;
                newValues = new byte[] { 0x94, 0x09, };
                WriteFunction(offset, newValues);

                offset = 0x6B775050;
                newValues = new byte[] { 0x7E, 0x0E, };
                WriteFunction(offset, newValues);

                offset = 0x6B77506E;
                newValues = new byte[] { 0x16, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B775052;
                newValues = new byte[] { 0x77, 0x0E, };
                WriteFunction(offset, newValues);

                offset = 0x6B77508E;
                newValues = new byte[] { 0x85, 0x0E, };
                WriteFunction(offset, newValues);

                offset = 0x6B78079A;
                newValues = new byte[] { 0xC7, 0x07, };
                WriteFunction(offset, newValues);

                offset = 0x6B78060A;
                newValues = new byte[] { 0xC9, 0x07, };
                WriteFunction(offset, newValues);

                offset = 0x6B780752;
                newValues = new byte[] { 0x5C, 0x08, };
                WriteFunction(offset, newValues);

                offset = 0x6B77504E;
                newValues = new byte[] { 0x7D, 0x0E, };
                WriteFunction(offset, newValues);

                offset = 0x6B77504C;
                newValues = new byte[] { 0x7E, 0x0E, };
                WriteFunction(offset, newValues);

                offset = 0x6B78060C;
                newValues = new byte[] { 0x8E, 0x09, };
                WriteFunction(offset, newValues);

                offset = 0x6B78060E;
                newValues = new byte[] { 0xE7, 0x0A, };
                WriteFunction(offset, newValues);

                offset = 0x6B780758;
                newValues = new byte[] { 0x7D, 0x09, };
                WriteFunction(offset, newValues);

                offset = 0x6B774FF8;
                newValues = new byte[] { 0x81, 0x08, };
                WriteFunction(offset, newValues);
            }
            else //original
            {
                uint offset = 0x6B774E80;
                byte[] newValues = new byte[] { 0xD6, 0x0A, };
                WriteFunction(offset, newValues);

                offset = 0x6B774E7E;
                newValues = new byte[] { 0x5D, 0x0B, };
                WriteFunction(offset, newValues);

                offset = 0x6B774E7C;
                newValues = new byte[] { 0x5E, 0x0B, };
                WriteFunction(offset, newValues);

                offset = 0x6B774FC2;
                newValues = new byte[] { 0x4E, 0x0B, };
                WriteFunction(offset, newValues);

                offset = 0x6B774FDA;
                newValues = new byte[] { 0x58, 0x0B, };
                WriteFunction(offset, newValues);

                offset = 0x6B774FC8;
                newValues = new byte[] { 0x5C, 0x0B, };
                WriteFunction(offset, newValues);

                offset = 0x6B774FE0;
                newValues = new byte[] { 0x53, 0x0B, };
                WriteFunction(offset, newValues);

                offset = 0x6B774FC6;
                newValues = new byte[] { 0x59, 0x0B, };
                WriteFunction(offset, newValues);

                offset = 0x6B774FF6;
                newValues = new byte[] { 0x3F, 0x0B, };
                WriteFunction(offset, newValues);

                offset = 0x6B774FF4;
                newValues = new byte[] { 0x40, 0x0B, };
                WriteFunction(offset, newValues);

                offset = 0x6B774FDC;
                newValues = new byte[] { 0x3C, 0x0B, };
                WriteFunction(offset, newValues);

                offset = 0x6B774FDE;
                newValues = new byte[] { 0x3C, 0x0B, };
                WriteFunction(offset, newValues);

                offset = 0x6B775050;
                newValues = new byte[] { 0xDF, 0x0E, };
                WriteFunction(offset, newValues);

                offset = 0x6B77506E;
                newValues = new byte[] { 0xA4, 0x0E, };
                WriteFunction(offset, newValues);

                offset = 0x6B775052;
                newValues = new byte[] { 0xE0, 0x0E, };
                WriteFunction(offset, newValues);

                offset = 0x6B77508E;
                newValues = new byte[] { 0x9D, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B78079A;
                newValues = new byte[] { 0x8F, 0x09, };
                WriteFunction(offset, newValues);

                offset = 0x6B78060A;
                newValues = new byte[] { 0x9C, 0x0A, };
                WriteFunction(offset, newValues);

                offset = 0x6B780752;
                newValues = new byte[] { 0x8B, 0x09, };
                WriteFunction(offset, newValues);

                offset = 0x6B77504E;
                newValues = new byte[] { 0x02, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B77504C;
                newValues = new byte[] { 0xF9, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B78060C;
                newValues = new byte[] { 0x96, 0x09, };
                WriteFunction(offset, newValues);

                offset = 0x6B78060E;
                newValues = new byte[] { 0x96, 0x0A, };
                WriteFunction(offset, newValues);

                offset = 0x6B780758;
                newValues = new byte[] { 0x91, 0x09, };
                WriteFunction(offset, newValues);

                offset = 0x6B774FF8;
                newValues = new byte[] { 0x34, 0x05, };
                WriteFunction(offset, newValues);
            }
        }

        #endregion

        #region Bordin2_moveset

        public static void ShinBordinMoveset()
        {
            if (SettingsClass.ShinBordinMoves) //custom
            {
                uint offset = 0x6B766A6A;
                byte[] newValues = new byte[] { 0x33, 0x02, };
                WriteFunction(offset, newValues);

                offset = 0x6B766A6C;
                newValues = new byte[] { 0x8F, 0x06, };
                WriteFunction(offset, newValues);

                offset = 0x6B766A6E;
                newValues = new byte[] { 0xA4, 0x0A, };
                WriteFunction(offset, newValues);

                offset = 0x6B766A70;
                newValues = new byte[] { 0x44, 0x07, };
                WriteFunction(offset, newValues);

                offset = 0x6B766BB2;
                newValues = new byte[] { 0x29, 0x09, };
                WriteFunction(offset, newValues);

                offset = 0x6B766BCA;
                newValues = new byte[] { 0xCA, 0x0B, };
                WriteFunction(offset, newValues);

                offset = 0x6B766BFA;
                newValues = new byte[] { 0xE0, 0x06, };
                WriteFunction(offset, newValues);

                offset = 0x6B766BE2;
                newValues = new byte[] { 0x70, 0x04, };
                WriteFunction(offset, newValues);

                offset = 0x6B766BB4;
                newValues = new byte[] { 0x2C, 0x09, };
                WriteFunction(offset, newValues);

                offset = 0x6B766BB6;
                newValues = new byte[] { 0x2D, 0x09, };
                WriteFunction(offset, newValues);

                offset = 0x6B766BB8;
                newValues = new byte[] { 0x97, 0x08, };
                WriteFunction(offset, newValues);

                offset = 0x6B766C00;
                newValues = new byte[] { 0x4A, 0x06, };
                WriteFunction(offset, newValues);

                offset = 0x6B766BE8;
                newValues = new byte[] { 0x34, 0x05, };
                WriteFunction(offset, newValues);

                offset = 0x6B766C40;
                newValues = new byte[] { 0x0A, 0x0E, };
                WriteFunction(offset, newValues);

                offset = 0x6B766C5E;
                newValues = new byte[] { 0x53, 0x0F, };
                WriteFunction(offset, newValues);

                offset = 0x6B766C7C;
                newValues = new byte[] { 0x27, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B766C28;
                newValues = new byte[] { 0xC4, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B766BD0;
                newValues = new byte[] { 0x42, 0x0B, };
                WriteFunction(offset, newValues);

                offset = 0x6B766C42;
                newValues = new byte[] { 0xAF, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B766C60;
                newValues = new byte[] { 0xE6, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B766C2A;
                newValues = new byte[] { 0x77, 0x0E, };
                WriteFunction(offset, newValues);

                offset = 0x6B766BCC;
                newValues = new byte[] { 0xE5, 0x07, };
                WriteFunction(offset, newValues);

                offset = 0x6B766BCE;
                newValues = new byte[] { 0xE5, 0x07, };
                WriteFunction(offset, newValues);

                offset = 0x6B766C44;
                newValues = new byte[] { 0xEC, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B766C80;
                newValues = new byte[] { 0x24, 0x0E, };
                WriteFunction(offset, newValues);

                offset = 0x6B766C62;
                newValues = new byte[] { 0xE3, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B766C38;
                newValues = new byte[] { 0xA8, 0x0E, };
                WriteFunction(offset, newValues);

                offset = 0x6B766C92;
                newValues = new byte[] { 0x2D, 0x03, };
                WriteFunction(offset, newValues);

                offset = 0x6B766C74;
                newValues = new byte[] { 0x32, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B766C56;
                newValues = new byte[] { 0x40, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B766C3A;
                newValues = new byte[] { 0xF0, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B766C76;
                newValues = new byte[] { 0xC4, 0x0E, };
                WriteFunction(offset, newValues);

                offset = 0x6B766C94;
                newValues = new byte[] { 0x3F, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B766C58;
                newValues = new byte[] { 0xEA, 0x0C, };
                WriteFunction(offset, newValues);
            }
            else //original
            {
                uint offset = 0x6B766A6A;
                byte[] newValues = new byte[] { 0x89, 0x04, };
                WriteFunction(offset, newValues);

                offset = 0x6B766A6C;
                newValues = new byte[] { 0x42, 0x07, };
                WriteFunction(offset, newValues);

                offset = 0x6B766A6E;
                newValues = new byte[] { 0xCD, 0x0B, };
                WriteFunction(offset, newValues);

                offset = 0x6B766A70;
                newValues = new byte[] { 0xCB, 0x0B, };
                WriteFunction(offset, newValues);

                offset = 0x6B766BB2;
                newValues = new byte[] { 0x07, 0x0B, };
                WriteFunction(offset, newValues);

                offset = 0x6B766BCA;
                newValues = new byte[] { 0x17, 0x0B, };
                WriteFunction(offset, newValues);

                offset = 0x6B766BFA;
                newValues = new byte[] { 0xCA, 0x0B, };
                WriteFunction(offset, newValues);

                offset = 0x6B766BE2;
                newValues = new byte[] { 0x04, 0x0B, };
                WriteFunction(offset, newValues);

                offset = 0x6B766BB4;
                newValues = new byte[] { 0x09, 0x0B, };
                WriteFunction(offset, newValues);

                offset = 0x6B766BB6;
                newValues = new byte[] { 0x09, 0x0B, };
                WriteFunction(offset, newValues);

                offset = 0x6B766BB8;
                newValues = new byte[] { 0x14, 0x0B, };
                WriteFunction(offset, newValues);

                offset = 0x6B766C00;
                newValues = new byte[] { 0xF6, 0x07, };
                WriteFunction(offset, newValues);

                offset = 0x6B766BE8;
                newValues = new byte[] { 0xAB, 0x04, };
                WriteFunction(offset, newValues);

                offset = 0x6B766C40;
                newValues = new byte[] { 0xCB, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B766C5E;
                newValues = new byte[] { 0xB0, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B766C7C;
                newValues = new byte[] { 0x5A, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B766C28;
                newValues = new byte[] { 0xAF, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B766BD0;
                newValues = new byte[] { 0x05, 0x0B, };
                WriteFunction(offset, newValues);

                offset = 0x6B766C42;
                newValues = new byte[] { 0xCC, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B766C60;
                newValues = new byte[] { 0xEE, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B766C2A;
                newValues = new byte[] { 0xB0, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B766BCC;
                newValues = new byte[] { 0x0D, 0x0B, };
                WriteFunction(offset, newValues);

                offset = 0x6B766BCE;
                newValues = new byte[] { 0x0D, 0x0B, };
                WriteFunction(offset, newValues);

                offset = 0x6B766C44;
                newValues = new byte[] { 0xDC, 0x0E, };
                WriteFunction(offset, newValues);

                offset = 0x6B766C80;
                newValues = new byte[] { 0x69, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B766C62;
                newValues = new byte[] { 0xF0, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B766C38;
                newValues = new byte[] { 0x91, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B766C92;
                newValues = new byte[] { 0x8F, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B766C74;
                newValues = new byte[] { 0x90, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B766C56;
                newValues = new byte[] { 0x8E, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B766C3A;
                newValues = new byte[] { 0x95, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B766C76;
                newValues = new byte[] { 0x94, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B766C94;
                newValues = new byte[] { 0x93, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B766C58;
                newValues = new byte[] { 0x92, 0x0D, };
                WriteFunction(offset, newValues);
            }
        }

        #endregion

        #region KG_moveset

        public static void KOGMoves()
        {
            if (SettingsClass.KOGMoves) //custom
            {
                uint offset = 0x6B76C2F0;
                byte[] newValues = new byte[] { 0x34, 0x02, };
                WriteFunction(offset, newValues);

                offset = 0x6B76C322;
                newValues = new byte[] { 0xDC, 0x03, };
                WriteFunction(offset, newValues);

                offset = 0x6B76C4CA;
                newValues = new byte[] { 0x47, 0x06, };
                WriteFunction(offset, newValues);

                offset = 0x6B76C4B2;
                newValues = new byte[] { 0x8B, 0x08, };
                WriteFunction(offset, newValues);

                offset = 0x6B76C4FA;
                newValues = new byte[] { 0x1E, 0x09, };
                WriteFunction(offset, newValues);

                offset = 0x6B76C4E2;
                newValues = new byte[] { 0x70, 0x04, };
                WriteFunction(offset, newValues);

                offset = 0x6B76C36A;
                newValues = new byte[] { 0x1D, 0x00, };
                WriteFunction(offset, newValues);

                offset = 0x6B76C370;
                newValues = new byte[] { 0x00, 0x00, };
                WriteFunction(offset, newValues);

                offset = 0x6B76C36E;
                newValues = new byte[] { 0xD7, 0x07, };
                WriteFunction(offset, newValues);

                offset = 0x6B76C4D0;
                newValues = new byte[] { 0xD0, 0x06, };
                WriteFunction(offset, newValues);

                offset = 0x6B76C4B8;
                newValues = new byte[] { 0xC8, 0x0A, };
                WriteFunction(offset, newValues);

                offset = 0x6B76C500;
                newValues = new byte[] { 0xF8, 0x0B, };
                WriteFunction(offset, newValues);

                offset = 0x6B76C4E8;
                newValues = new byte[] { 0x70, 0x00, };
                WriteFunction(offset, newValues);

                offset = 0x6B76C35A;
                newValues = new byte[] { 0xC8, 0x0A, };
                WriteFunction(offset, newValues);

                offset = 0x6B76C35E;
                newValues = new byte[] { 0x14, 0x09, };
                WriteFunction(offset, newValues);

                offset = 0x6B76C360;
                newValues = new byte[] { 0x42, 0x0B, };
                WriteFunction(offset, newValues);

                offset = 0x6B76C35C;
                newValues = new byte[] { 0x34, 0x05, };
                WriteFunction(offset, newValues);

                offset = 0x6B76C300;
                newValues = new byte[] { 0xA7, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B76C4FC;
                newValues = new byte[] { 0x24, 0x09, };
                WriteFunction(offset, newValues);

                offset = 0x6B76C4FE;
                newValues = new byte[] { 0x24, 0x09, };
                WriteFunction(offset, newValues);

                offset = 0x6B76C4E4;
                newValues = new byte[] { 0x70, 0x04, };
                WriteFunction(offset, newValues);

                offset = 0x6B76C4E6;
                newValues = new byte[] { 0x6D, 0x04, };
                WriteFunction(offset, newValues);

                offset = 0x6B76C52E;
                newValues = new byte[] { 0x28, 0x09, };
                WriteFunction(offset, newValues);

                offset = 0x6B76C4C0;
                newValues = new byte[] { 0x05, 0x07, };
                WriteFunction(offset, newValues);

                offset = 0x6B76C540;
                newValues = new byte[] { 0x17, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B76C57C;
                newValues = new byte[] { 0xC8, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B76C55E;
                newValues = new byte[] { 0x38, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B76C542;
                newValues = new byte[] { 0x5E, 0x0E, };
                WriteFunction(offset, newValues);

                offset = 0x6B76C57E;
                newValues = new byte[] { 0x5A, 0x0E, };
                WriteFunction(offset, newValues);

                offset = 0x6B76C560;
                newValues = new byte[] { 0x77, 0x0E, };
                WriteFunction(offset, newValues);

                offset = 0x6B76C544;
                newValues = new byte[] { 0x12, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B76C580;
                newValues = new byte[] { 0x17, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B76C562;
                newValues = new byte[] { 0xF6, 0x0C, };
                WriteFunction(offset, newValues);
            }
            else //original
            {
                uint offset = 0x6B76C2F0;
                byte[] newValues = new byte[] { 0x99, 0x02, };
                WriteFunction(offset, newValues);

                offset = 0x6B76C322;
                newValues = new byte[] { 0xDA, 0x03, };
                WriteFunction(offset, newValues);

                offset = 0x6B76C4CA;
                newValues = new byte[] { 0x17, 0x09, };
                WriteFunction(offset, newValues);

                offset = 0x6B76C4B2;
                newValues = new byte[] { 0x29, 0x09, };
                WriteFunction(offset, newValues);

                offset = 0x6B76C4FA;
                newValues = new byte[] { 0x1E, 0x09, };
                WriteFunction(offset, newValues);

                offset = 0x6B76C4E2;
                newValues = new byte[] { 0x71, 0x04, };
                WriteFunction(offset, newValues);

                offset = 0x6B76C36A;
                newValues = new byte[] { 0x89, 0x04, };
                WriteFunction(offset, newValues);

                offset = 0x6B76C370;
                newValues = new byte[] { 0x33, 0x09, };
                WriteFunction(offset, newValues);

                offset = 0x6B76C36E;
                newValues = new byte[] { 0x9A, 0x0A, };
                WriteFunction(offset, newValues);

                offset = 0x6B76C4D0;
                newValues = new byte[] { 0x05, 0x0B, };
                WriteFunction(offset, newValues);

                offset = 0x6B76C4B8;
                newValues = new byte[] { 0xF8, 0x0B, };
                WriteFunction(offset, newValues);

                offset = 0x6B76C500;
                newValues = new byte[] { 0x47, 0x06, };
                WriteFunction(offset, newValues);

                offset = 0x6B76C4E8;
                newValues = new byte[] { 0x34, 0x05, };
                WriteFunction(offset, newValues);

                offset = 0x6B76C35A;
                newValues = new byte[] { 0x74, 0x00, };
                WriteFunction(offset, newValues);

                offset = 0x6B76C35E;
                newValues = new byte[] { 0x69, 0x00, };
                WriteFunction(offset, newValues);

                offset = 0x6B76C360;
                newValues = new byte[] { 0x72, 0x00, };
                WriteFunction(offset, newValues);

                offset = 0x6B76C35C;
                newValues = new byte[] { 0x73, 0x00, };
                WriteFunction(offset, newValues);

                offset = 0x6B76C300;
                newValues = new byte[] { 0xB4, 0x00, };
                WriteFunction(offset, newValues);

                offset = 0x6B76C4FC;
                newValues = new byte[] { 0xEA, 0x06, };
                WriteFunction(offset, newValues);

                offset = 0x6B76C4FE;
                newValues = new byte[] { 0xEA, 0x06, };
                WriteFunction(offset, newValues);

                offset = 0x6B76C4E4;
                newValues = new byte[] { 0x6E, 0x07, };
                WriteFunction(offset, newValues);

                offset = 0x6B76C4E6;
                newValues = new byte[] { 0x6D, 0x07, };
                WriteFunction(offset, newValues);

                offset = 0x6B76C52E;
                newValues = new byte[] { 0x15, 0x06, };
                WriteFunction(offset, newValues);

                offset = 0x6B76C4C0;
                newValues = new byte[] { 0x05, 0x07, };
                WriteFunction(offset, newValues);

                offset = 0x6B76C540;
                newValues = new byte[] { 0xE1, 0x0E, };
                WriteFunction(offset, newValues);

                offset = 0x6B76C57C;
                newValues = new byte[] { 0x4A, 0x0E, };
                WriteFunction(offset, newValues);

                offset = 0x6B76C55E;
                newValues = new byte[] { 0xF1, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B76C542;
                newValues = new byte[] { 0x2C, 0x0E, };
                WriteFunction(offset, newValues);

                offset = 0x6B76C57E;
                newValues = new byte[] { 0xA9, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B76C560;
                newValues = new byte[] { 0xC1, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B76C544;
                newValues = new byte[] { 0xDC, 0x0E, };
                WriteFunction(offset, newValues);

                offset = 0x6B76C580;
                newValues = new byte[] { 0x69, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B76C562;
                newValues = new byte[] { 0xBD, 0x0D, };
                WriteFunction(offset, newValues);
            }
        }

        #endregion

        #region Jake_moveset

        public static void KingJakeMoves()
        {
            if (SettingsClass.KingJakeMoves) //custom
            {
                uint offset = 0x6B767248;
                byte[] newValues = new byte[] { 0xBB, 0x03, };
                WriteFunction(offset, newValues);

                offset = 0x6B76740A;
                newValues = new byte[] { 0x2A, 0x09, };
                WriteFunction(offset, newValues);

                offset = 0x6B767452;
                newValues = new byte[] { 0x18, 0x0A, };
                WriteFunction(offset, newValues);

                offset = 0x6B76743A;
                newValues = new byte[] { 0x16, 0x0A, };
                WriteFunction(offset, newValues);

                offset = 0x6B767454;
                newValues = new byte[] { 0x33, 0x0F, };
                WriteFunction(offset, newValues);

                offset = 0x6B767456;
                newValues = new byte[] { 0x33, 0x0F, };
                WriteFunction(offset, newValues);

                offset = 0x6B76743E;
                newValues = new byte[] { 0x04, 0x0A, };
                WriteFunction(offset, newValues);

                offset = 0x6B76743C;
                newValues = new byte[] { 0x04, 0x0A, };
                WriteFunction(offset, newValues);

                offset = 0x6B767428;
                newValues = new byte[] { 0x35, 0x05, };
                WriteFunction(offset, newValues);

                offset = 0x6B767410;
                newValues = new byte[] { 0x1D, 0x00, };
                WriteFunction(offset, newValues);

                offset = 0x6B767458;
                newValues = new byte[] { 0x41, 0x09, };
                WriteFunction(offset, newValues);

                offset = 0x6B7672C2;
                newValues = new byte[] { 0x07, 0x00, };
                WriteFunction(offset, newValues);

                offset = 0x6B7672B2;
                newValues = new byte[] { 0xF4, 0x09, };
                WriteFunction(offset, newValues);

                offset = 0x6B7672B4;
                newValues = new byte[] { 0xE0, 0x06, };
                WriteFunction(offset, newValues);

                offset = 0x6B7672B8;
                newValues = new byte[] { 0x80, 0x05, };
                WriteFunction(offset, newValues);

                offset = 0x6B7672B6;
                newValues = new byte[] { 0xD9, 0x0A, };
                WriteFunction(offset, newValues);

                offset = 0x6B7674D4;
                newValues = new byte[] { 0xAF, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B7674B6;
                newValues = new byte[] { 0x53, 0x0F, };
                WriteFunction(offset, newValues);

                offset = 0x6B7674BA;
                newValues = new byte[] { 0xBF, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B76749C;
                newValues = new byte[] { 0x54, 0x0F, };
                WriteFunction(offset, newValues);

                offset = 0x6B7674D6;
                newValues = new byte[] { 0x29, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B7674B8;
                newValues = new byte[] { 0x33, 0x0F, };
                WriteFunction(offset, newValues);
            }
            else //original
            {
                uint offset = 0x6B767248;
                byte[] newValues = new byte[] { 0xBB, 0x03, };
                WriteFunction(offset, newValues);

                offset = 0x6B76740A;
                newValues = new byte[] { 0xD9, 0x0A, };
                WriteFunction(offset, newValues);

                offset = 0x6B767452;
                newValues = new byte[] { 0xDC, 0x0A, };
                WriteFunction(offset, newValues);

                offset = 0x6B76743A;
                newValues = new byte[] { 0xDD, 0x0A, };
                WriteFunction(offset, newValues);

                offset = 0x6B767454;
                newValues = new byte[] { 0xDF, 0x0A, };
                WriteFunction(offset, newValues);

                offset = 0x6B767456;
                newValues = new byte[] { 0xDF, 0x0A, };
                WriteFunction(offset, newValues);

                offset = 0x6B76743E;
                newValues = new byte[] { 0x5E, 0x07, };
                WriteFunction(offset, newValues);

                offset = 0x6B76743C;
                newValues = new byte[] { 0x5E, 0x07, };
                WriteFunction(offset, newValues);

                offset = 0x6B767428;
                newValues = new byte[] { 0x60, 0x07, };
                WriteFunction(offset, newValues);

                offset = 0x6B767410;
                newValues = new byte[] { 0x41, 0x09, };
                WriteFunction(offset, newValues);

                offset = 0x6B767458;
                newValues = new byte[] { 0xF4, 0x09, };
                WriteFunction(offset, newValues);

                offset = 0x6B7672C2;
                newValues = new byte[] { 0x89, 0x04, };
                WriteFunction(offset, newValues);

                offset = 0x6B7672B2;
                newValues = new byte[] { 0x74, 0x00, };
                WriteFunction(offset, newValues);

                offset = 0x6B7672B4;
                newValues = new byte[] { 0x73, 0x00, };
                WriteFunction(offset, newValues);

                offset = 0x6B7672B8;
                newValues = new byte[] { 0x72, 0x00, };
                WriteFunction(offset, newValues);

                offset = 0x6B7672B6;
                newValues = new byte[] { 0x69, 0x00, };
                WriteFunction(offset, newValues);

                offset = 0x6B7674D4;
                newValues = new byte[] { 0xBF, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B7674B6;
                newValues = new byte[] { 0x2C, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B7674BA;
                newValues = new byte[] { 0xBD, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B76749C;
                newValues = new byte[] { 0x6A, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B7674D6;
                newValues = new byte[] { 0xC4, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B7674B8;
                newValues = new byte[] { 0xF4, 0x0C, };
                WriteFunction(offset, newValues);
            }
        }

        #endregion

        #region Nas-Tiii/Em Cee/Real Deal/Ty_moveset

        public static void MMAGipsiesMoves()
        {
            if (SettingsClass.MMAGipsiesMoves) //custom
            {
                //All
                uint offset = 0x6B73ABFE;
                byte[] newValues = new byte[] { 0x8F, 0x06, };
                WriteFunction(offset, newValues);

                //Nas-Tiii
                offset = 0x6B7702E8;
                newValues = new byte[] { 0xF5, 0x02, };
                WriteFunction(offset, newValues);

                offset = 0x6B770538;
                newValues = new byte[] { 0x16, 0x0F, };
                WriteFunction(offset, newValues);

                offset = 0x6B770574;
                newValues = new byte[] { 0x7D, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B770556;
                newValues = new byte[] { 0xC1, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B770362;
                newValues = new byte[] { 0x3F, 0x07, };
                WriteFunction(offset, newValues);

                offset = 0x6B770364;
                newValues = new byte[] { 0x80, 0x05, };
                WriteFunction(offset, newValues);

                offset = 0x6B770366;
                newValues = new byte[] { 0xD7, 0x07, };
                WriteFunction(offset, newValues);

                offset = 0x6B7704AC;
                newValues = new byte[] { 0xF8, 0x0B, };
                WriteFunction(offset, newValues);

                offset = 0x6B7704AE;
                newValues = new byte[] { 0xF8, 0x0B, };
                WriteFunction(offset, newValues);

                offset = 0x6B7704C4;
                newValues = new byte[] { 0xDF, 0x08, };
                WriteFunction(offset, newValues);

                offset = 0x6B7704C6;
                newValues = new byte[] { 0xDF, 0x08, };
                WriteFunction(offset, newValues);

                offset = 0x6B7704F4;
                newValues = new byte[] { 0x22, 0x0B, };
                WriteFunction(offset, newValues);

                offset = 0x6B7704F6;
                newValues = new byte[] { 0x22, 0x0B, };
                WriteFunction(offset, newValues);

                offset = 0x6B7704DC;
                newValues = new byte[] { 0x72, 0x09, };
                WriteFunction(offset, newValues);

                offset = 0x6B7704DE;
                newValues = new byte[] { 0x72, 0x09, };
                WriteFunction(offset, newValues);

                offset = 0x6B7704C2;
                newValues = new byte[] { 0xCA, 0x0B, };
                WriteFunction(offset, newValues);

                offset = 0x6B7704F2;
                newValues = new byte[] { 0xF1, 0x07, };
                WriteFunction(offset, newValues);

                offset = 0x6B73AA96;
                newValues = new byte[] { 0xDE, 0x08, };
                WriteFunction(offset, newValues);

                offset = 0x6B7704AA;
                newValues = new byte[] { 0x29, 0x09, };
                WriteFunction(offset, newValues);

                offset = 0x6B7704B0;
                newValues = new byte[] { 0x2C, 0x09, };
                WriteFunction(offset, newValues);

                offset = 0x6B7704C8;
                newValues = new byte[] { 0x89, 0x09, };
                WriteFunction(offset, newValues);

                offset = 0x6B7704F8;
                newValues = new byte[] { 0x18, 0x0A, };
                WriteFunction(offset, newValues);

                offset = 0x6B7704E0;
                newValues = new byte[] { 0x34, 0x05, };
                WriteFunction(offset, newValues);

                //Em Cee
                offset = 0x6B7705B0;
                newValues = new byte[] { 0x35, 0x02, };
                WriteFunction(offset, newValues);

                offset = 0x6B770800;
                newValues = new byte[] { 0x93, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B77083C;
                newValues = new byte[] { 0x7B, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B77081E;
                newValues = new byte[] { 0x3A, 0x0F, };
                WriteFunction(offset, newValues);

                offset = 0x6B77062A;
                newValues = new byte[] { 0x3F, 0x07, };
                WriteFunction(offset, newValues);

                offset = 0x6B77062C;
                newValues = new byte[] { 0xEC, 0x06, };
                WriteFunction(offset, newValues);

                offset = 0x6B77062E;
                newValues = new byte[] { 0x4C, 0x0B, };
                WriteFunction(offset, newValues);

                offset = 0x6B770774;
                newValues = new byte[] { 0x04, 0x0A, };
                WriteFunction(offset, newValues);

                offset = 0x6B770776;
                newValues = new byte[] { 0x04, 0x0A, };
                WriteFunction(offset, newValues);

                offset = 0x6B77078C;
                newValues = new byte[] { 0x64, 0x0A, };
                WriteFunction(offset, newValues);

                offset = 0x6B77078E;
                newValues = new byte[] { 0x64, 0x0A, };
                WriteFunction(offset, newValues);

                offset = 0x6B7707BC;
                newValues = new byte[] { 0x62, 0x09, };
                WriteFunction(offset, newValues);

                offset = 0x6B7707BE;
                newValues = new byte[] { 0x62, 0x09, };
                WriteFunction(offset, newValues);

                offset = 0x6B7707A4;
                newValues = new byte[] { 0x72, 0x09, };
                WriteFunction(offset, newValues);

                offset = 0x6B7707A6;
                newValues = new byte[] { 0x72, 0x09, };
                WriteFunction(offset, newValues);

                offset = 0x6B77078A;
                newValues = new byte[] { 0xB5, 0x07, };
                WriteFunction(offset, newValues);

                offset = 0x6B7707BA;
                newValues = new byte[] { 0xD0, 0x06, };
                WriteFunction(offset, newValues);

                offset = 0x6B7707A2;
                newValues = new byte[] { 0x70, 0x04, };
                WriteFunction(offset, newValues);

                offset = 0x6B770772;
                newValues = new byte[] { 0xAE, 0x07, };
                WriteFunction(offset, newValues);

                offset = 0x6B770778;
                newValues = new byte[] { 0xFB, 0x04, };
                WriteFunction(offset, newValues);

                offset = 0x6B770790;
                newValues = new byte[] { 0xBF, 0x05, };
                WriteFunction(offset, newValues);

                offset = 0x6B7707C0;
                newValues = new byte[] { 0x57, 0x06, };
                WriteFunction(offset, newValues);

                offset = 0x6B7707A8;
                newValues = new byte[] { 0x34, 0x05, };
                WriteFunction(offset, newValues);

                //Real Deal
                offset = 0x6B770878;
                newValues = new byte[] { 0x38, 0x02, };
                WriteFunction(offset, newValues);

                offset = 0x6B770AC8;
                newValues = new byte[] { 0x83, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B770B04;
                newValues = new byte[] { 0x5E, 0x0E, };
                WriteFunction(offset, newValues);

                offset = 0x6B770AE6;
                newValues = new byte[] { 0x5F, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B7708F2;
                newValues = new byte[] { 0x3F, 0x07, };
                WriteFunction(offset, newValues);

                offset = 0x6B7708F4;
                newValues = new byte[] { 0xA9, 0x0A, };
                WriteFunction(offset, newValues);

                offset = 0x6B7708F6;
                newValues = new byte[] { 0xD6, 0x07, };
                WriteFunction(offset, newValues);

                offset = 0x6B770A3A;
                newValues = new byte[] { 0xDE, 0x0A, };
                WriteFunction(offset, newValues);

                offset = 0x6B770A3C;
                newValues = new byte[] { 0xDE, 0x0A, };
                WriteFunction(offset, newValues);

                offset = 0x6B770A54;
                newValues = new byte[] { 0x35, 0x05, };
                WriteFunction(offset, newValues);

                offset = 0x6B770A56;
                newValues = new byte[] { 0x35, 0x05, };
                WriteFunction(offset, newValues);

                offset = 0x6B770A84;
                newValues = new byte[] { 0x02, 0x08, };
                WriteFunction(offset, newValues);

                offset = 0x6B770A86;
                newValues = new byte[] { 0x02, 0x08, };
                WriteFunction(offset, newValues);

                offset = 0x6B770A6C;
                newValues = new byte[] { 0x6D, 0x07, };
                WriteFunction(offset, newValues);

                offset = 0x6B770A6E;
                newValues = new byte[] { 0x6D, 0x07, };
                WriteFunction(offset, newValues);

                offset = 0x6B770A52;
                newValues = new byte[] { 0xDD, 0x07, };
                WriteFunction(offset, newValues);

                offset = 0x6B770A82;
                newValues = new byte[] { 0xF1, 0x07, };
                WriteFunction(offset, newValues);

                offset = 0x6B770A6A;
                newValues = new byte[] { 0x96, 0x04, };
                WriteFunction(offset, newValues);

                offset = 0x6B770A3A;
                newValues = new byte[] { 0x07, 0x0B, };
                WriteFunction(offset, newValues);

                offset = 0x6B770A40;
                newValues = new byte[] { 0x24, 0x0E, };
                WriteFunction(offset, newValues);

                offset = 0x6B770A58;
                newValues = new byte[] { 0x14, 0x09, };
                WriteFunction(offset, newValues);

                offset = 0x6B770A88;
                newValues = new byte[] { 0xC4, 0x05, };
                WriteFunction(offset, newValues);

                offset = 0x6B770A70;
                newValues = new byte[] { 0x34, 0x05, };
                WriteFunction(offset, newValues);

                //Ty
                offset = 0x6B770B40;
                newValues = new byte[] { 0x1B, 0x03, };
                WriteFunction(offset, newValues);

                offset = 0x6B770D90;
                newValues = new byte[] { 0x65, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B770DCC;
                newValues = new byte[] { 0x15, 0x0E, };
                WriteFunction(offset, newValues);

                offset = 0x6B770DAE;
                newValues = new byte[] { 0xF1, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B770BBA;
                newValues = new byte[] { 0x3F, 0x07, };
                WriteFunction(offset, newValues);

                offset = 0x6B770BBC;
                newValues = new byte[] { 0x6F, 0x0B, };
                WriteFunction(offset, newValues);

                offset = 0x6B770BBE;
                newValues = new byte[] { 0xD5, 0x07, };
                WriteFunction(offset, newValues);

                offset = 0x6B770D02;
                newValues = new byte[] { 0x09, 0x0B, };
                WriteFunction(offset, newValues);

                offset = 0x6B770D04;
                newValues = new byte[] { 0x09, 0x0B, };
                WriteFunction(offset, newValues);

                offset = 0x6B770D1C;
                newValues = new byte[] { 0xED, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B770D1E;
                newValues = new byte[] { 0xED, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B770D4C;
                newValues = new byte[] { 0x89, 0x09, };
                WriteFunction(offset, newValues);

                offset = 0x6B770D4E;
                newValues = new byte[] { 0x89, 0x09, };
                WriteFunction(offset, newValues);

                offset = 0x6B770D34;
                newValues = new byte[] { 0xA2, 0x07, };
                WriteFunction(offset, newValues);

                offset = 0x6B770D36;
                newValues = new byte[] { 0xA2, 0x07, };
                WriteFunction(offset, newValues);

                offset = 0x6B770D1A;
                newValues = new byte[] { 0xB6, 0x07, };
                WriteFunction(offset, newValues);

                offset = 0x6B770D4A;
                newValues = new byte[] { 0xD0, 0x06, };
                WriteFunction(offset, newValues);

                offset = 0x6B770D32;
                newValues = new byte[] { 0x6D, 0x04, };
                WriteFunction(offset, newValues);

                offset = 0x6B770D02;
                newValues = new byte[] { 0xBC, 0x07, };
                WriteFunction(offset, newValues);

                offset = 0x6B770D20;
                newValues = new byte[] { 0xBF, 0x05, };
                WriteFunction(offset, newValues);

                offset = 0x6B770D08;
                newValues = new byte[] { 0x89, 0x09, };
                WriteFunction(offset, newValues);

                offset = 0x6B770D50;
                newValues = new byte[] { 0x04, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B770D38;
                newValues = new byte[] { 0x34, 0x05, };
                WriteFunction(offset, newValues);
            }
            else //original
            {
                //Nas-Tiii
                uint offset = 0x6B73ABFE;
                byte[] newValues = new byte[] { 0xEC, 0x08, };
                WriteFunction(offset, newValues);

                offset = 0x6B7702E8;
                newValues = new byte[] { 0x39, 0x04, };
                WriteFunction(offset, newValues);

                offset = 0x6B770538;
                newValues = new byte[] { 0xBB, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B770574;
                newValues = new byte[] { 0xC7, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B770556;
                newValues = new byte[] { 0x31, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B770362;
                newValues = new byte[] { 0x89, 0x04, };
                WriteFunction(offset, newValues);

                offset = 0x6B770364;
                newValues = new byte[] { 0x17, 0x08, };
                WriteFunction(offset, newValues);

                offset = 0x6B770366;
                newValues = new byte[] { 0x98, 0x0A, };
                WriteFunction(offset, newValues);

                offset = 0x6B7704AC;
                newValues = new byte[] { 0x28, 0x08, };
                WriteFunction(offset, newValues);

                offset = 0x6B7704AE;
                newValues = new byte[] { 0x28, 0x08, };
                WriteFunction(offset, newValues);

                offset = 0x6B7704C4;
                newValues = new byte[] { 0xE1, 0x08, };
                WriteFunction(offset, newValues);

                offset = 0x6B7704C6;
                newValues = new byte[] { 0xE1, 0x08, };
                WriteFunction(offset, newValues);

                offset = 0x6B7704F4;
                newValues = new byte[] { 0x0D, 0x08, };
                WriteFunction(offset, newValues);

                offset = 0x6B7704F6;
                newValues = new byte[] { 0x0D, 0x08, };
                WriteFunction(offset, newValues);

                offset = 0x6B7704DC;
                newValues = new byte[] { 0x0A, 0x08, };
                WriteFunction(offset, newValues);

                offset = 0x6B7704DE;
                newValues = new byte[] { 0x0A, 0x08, };
                WriteFunction(offset, newValues);

                offset = 0x6B7704C2;
                newValues = new byte[] { 0xF3, 0x07, };
                WriteFunction(offset, newValues);

                offset = 0x6B7704F2;
                newValues = new byte[] { 0xF5, 0x07, };
                WriteFunction(offset, newValues);

                offset = 0x6B73AA96;
                newValues = new byte[] { 0xDF, 0x08, };
                WriteFunction(offset, newValues);

                offset = 0x6B7704AA;
                newValues = new byte[] { 0xEE, 0x07, };
                WriteFunction(offset, newValues);

                offset = 0x6B7704B0;
                newValues = new byte[] { 0xF9, 0x0B, };
                WriteFunction(offset, newValues);

                offset = 0x6B7704C8;
                newValues = new byte[] { 0x11, 0x08, };
                WriteFunction(offset, newValues);

                offset = 0x6B7704F8;
                newValues = new byte[] { 0x10, 0x08, };
                WriteFunction(offset, newValues);

                offset = 0x6B7704E0;
                newValues = new byte[] { 0xAB, 0x04, };
                WriteFunction(offset, newValues);

                //Em Cee
                offset = 0x6B7705B0;
                newValues = new byte[] { 0x39, 0x04, };
                WriteFunction(offset, newValues);

                offset = 0x6B770800;
                newValues = new byte[] { 0xBB, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B77083C;
                newValues = new byte[] { 0xC7, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B77081E;
                newValues = new byte[] { 0x31, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B77062A;
                newValues = new byte[] { 0x89, 0x04, };
                WriteFunction(offset, newValues);

                offset = 0x6B77062C;
                newValues = new byte[] { 0x17, 0x08, };
                WriteFunction(offset, newValues);

                offset = 0x6B77062E;
                newValues = new byte[] { 0x9A, 0x0A, };
                WriteFunction(offset, newValues);

                offset = 0x6B770774;
                newValues = new byte[] { 0x28, 0x08, };
                WriteFunction(offset, newValues);

                offset = 0x6B770776;
                newValues = new byte[] { 0x28, 0x08, };
                WriteFunction(offset, newValues);

                offset = 0x6B77078C;
                newValues = new byte[] { 0xE1, 0x08, };
                WriteFunction(offset, newValues);

                offset = 0x6B77078E;
                newValues = new byte[] { 0xE1, 0x08, };
                WriteFunction(offset, newValues);

                offset = 0x6B7707BC;
                newValues = new byte[] { 0x0D, 0x08, };
                WriteFunction(offset, newValues);

                offset = 0x6B7707BE;
                newValues = new byte[] { 0x0D, 0x08, };
                WriteFunction(offset, newValues);

                offset = 0x6B7707A4;
                newValues = new byte[] { 0x0A, 0x08, };
                WriteFunction(offset, newValues);

                offset = 0x6B7707A6;
                newValues = new byte[] { 0x0A, 0x08, };
                WriteFunction(offset, newValues);

                offset = 0x6B77078A;
                newValues = new byte[] { 0x18, 0x08, };
                WriteFunction(offset, newValues);

                offset = 0x6B7707BA;
                newValues = new byte[] { 0xF5, 0x07, };
                WriteFunction(offset, newValues);

                offset = 0x6B7707A2;
                newValues = new byte[] { 0x71, 0x04, };
                WriteFunction(offset, newValues);

                offset = 0x6B770772;
                newValues = new byte[] { 0xEE, 0x07, };
                WriteFunction(offset, newValues);

                offset = 0x6B770778;
                newValues = new byte[] { 0xF9, 0x0B, };
                WriteFunction(offset, newValues);

                offset = 0x6B770790;
                newValues = new byte[] { 0x11, 0x08, };
                WriteFunction(offset, newValues);

                offset = 0x6B7707C0;
                newValues = new byte[] { 0x10, 0x08, };
                WriteFunction(offset, newValues);

                offset = 0x6B7707A8;
                newValues = new byte[] { 0xAB, 0x04, };
                WriteFunction(offset, newValues);

                //Real Deal
                offset = 0x6B770878;
                newValues = new byte[] { 0x39, 0x04, };
                WriteFunction(offset, newValues);

                offset = 0x6B770AC8;
                newValues = new byte[] { 0xDF, 0x0E, };
                WriteFunction(offset, newValues);

                offset = 0x6B770B04;
                newValues = new byte[] { 0xC7, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B770AE6;
                newValues = new byte[] { 0x2C, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B7708F2;
                newValues = new byte[] { 0x89, 0x04, };
                WriteFunction(offset, newValues);

                offset = 0x6B7708F4;
                newValues = new byte[] { 0x17, 0x08, };
                WriteFunction(offset, newValues);

                offset = 0x6B7708F6;
                newValues = new byte[] { 0x99, 0x0A, };
                WriteFunction(offset, newValues);

                offset = 0x6B770A3A;
                newValues = new byte[] { 0xEE, 0x07, };
                WriteFunction(offset, newValues);

                offset = 0x6B770A3C;
                newValues = new byte[] { 0x28, 0x08, };
                WriteFunction(offset, newValues);

                offset = 0x6B770A54;
                newValues = new byte[] { 0xE1, 0x08, };
                WriteFunction(offset, newValues);

                offset = 0x6B770A56;
                newValues = new byte[] { 0xE1, 0x08, };
                WriteFunction(offset, newValues);

                offset = 0x6B770A84;
                newValues = new byte[] { 0x0D, 0x08, };
                WriteFunction(offset, newValues);

                offset = 0x6B770A86;
                newValues = new byte[] { 0x0D, 0x08, };
                WriteFunction(offset, newValues);

                offset = 0x6B770A6C;
                newValues = new byte[] { 0x0A, 0x08, };
                WriteFunction(offset, newValues);

                offset = 0x6B770A6E;
                newValues = new byte[] { 0x0A, 0x08, };
                WriteFunction(offset, newValues);

                offset = 0x6B770A52;
                newValues = new byte[] { 0x18, 0x08, };
                WriteFunction(offset, newValues);

                offset = 0x6B770A82;
                newValues = new byte[] { 0xF5, 0x07, };
                WriteFunction(offset, newValues);

                offset = 0x6B770A6A;
                newValues = new byte[] { 0xF4, 0x07, };
                WriteFunction(offset, newValues);

                offset = 0x6B770A3A;
                newValues = new byte[] { 0xEE, 0x07, };
                WriteFunction(offset, newValues);

                offset = 0x6B770A40;
                newValues = new byte[] { 0xF9, 0x0B, };
                WriteFunction(offset, newValues);

                offset = 0x6B770A58;
                newValues = new byte[] { 0x11, 0x08, };
                WriteFunction(offset, newValues);

                offset = 0x6B770A88;
                newValues = new byte[] { 0x10, 0x08, };
                WriteFunction(offset, newValues);

                offset = 0x6B770A70;
                newValues = new byte[] { 0xAB, 0x04, };
                WriteFunction(offset, newValues);

                //Ty
                offset = 0x6B770B40;
                newValues = new byte[] { 0x37, 0x02, };
                WriteFunction(offset, newValues);

                offset = 0x6B770D90;
                newValues = new byte[] { 0xE1, 0x0E, };
                WriteFunction(offset, newValues);

                offset = 0x6B770DCC;
                newValues = new byte[] { 0xC7, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B770DAE;
                newValues = new byte[] { 0x2C, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B770BBA;
                newValues = new byte[] { 0x89, 0x04, };
                WriteFunction(offset, newValues);

                offset = 0x6B770BBC;
                newValues = new byte[] { 0x17, 0x08, };
                WriteFunction(offset, newValues);

                offset = 0x6B770BBE;
                newValues = new byte[] { 0x98, 0x0A, };
                WriteFunction(offset, newValues);

                offset = 0x6B770D02;
                newValues = new byte[] { 0xEE, 0x07, };
                WriteFunction(offset, newValues);

                offset = 0x6B770D04;
                newValues = new byte[] { 0x28, 0x08, };
                WriteFunction(offset, newValues);

                offset = 0x6B770D1C;
                newValues = new byte[] { 0xE1, 0x08, };
                WriteFunction(offset, newValues);

                offset = 0x6B770D1E;
                newValues = new byte[] { 0xE1, 0x08, };
                WriteFunction(offset, newValues);

                offset = 0x6B770D4C;
                newValues = new byte[] { 0x0D, 0x08, };
                WriteFunction(offset, newValues);

                offset = 0x6B770D4E;
                newValues = new byte[] { 0x0D, 0x08, };
                WriteFunction(offset, newValues);

                offset = 0x6B770D34;
                newValues = new byte[] { 0x0A, 0x08, };
                WriteFunction(offset, newValues);

                offset = 0x6B770D36;
                newValues = new byte[] { 0x0A, 0x08, };
                WriteFunction(offset, newValues);

                offset = 0x6B770D1A;
                newValues = new byte[] { 0xF3, 0x07, };
                WriteFunction(offset, newValues);

                offset = 0x6B770D4A;
                newValues = new byte[] { 0xF5, 0x07, };
                WriteFunction(offset, newValues);

                offset = 0x6B770D32;
                newValues = new byte[] { 0x71, 0x04, };
                WriteFunction(offset, newValues);

                offset = 0x6B770D02;
                newValues = new byte[] { 0xEE, 0x07, };
                WriteFunction(offset, newValues);

                offset = 0x6B770D20;
                newValues = new byte[] { 0x11, 0x08, };
                WriteFunction(offset, newValues);

                offset = 0x6B770D08;
                newValues = new byte[] { 0xF9, 0x0B, };
                WriteFunction(offset, newValues);

                offset = 0x6B770D50;
                newValues = new byte[] { 0x10, 0x08, };
                WriteFunction(offset, newValues);

                offset = 0x6B770D38;
                newValues = new byte[] { 0xAB, 0x04, };
                WriteFunction(offset, newValues);
            }
        }

        #endregion

        #region Riki_moveset

        public static void RikiDensetsuMoves()
        {
            if (SettingsClass.RikiDensetsuMoves) //custom
            {
                uint offset = 0x6B73ED9E;
                byte[] newValues = new byte[] { 0xD3, 0x0A, };
                WriteFunction(offset, newValues);

                offset = 0x6B773142;
                newValues = new byte[] { 0xC5, 0x08, };
                WriteFunction(offset, newValues);

                offset = 0x6B7373A0;
                newValues = new byte[] { 0xCF, 0x0A, };
                WriteFunction(offset, newValues);

                offset = 0x6B77315A;
                newValues = new byte[] { 0xD5, 0x0A, };
                WriteFunction(offset, newValues);

                offset = 0x6B773130;
                newValues = new byte[] { 0x6A, 0x07, };
                WriteFunction(offset, newValues);

                offset = 0x6B773148;
                newValues = new byte[] { 0x64, 0x0A, };
                WriteFunction(offset, newValues);

                offset = 0x6B773178;
                newValues = new byte[] { 0x89, 0x09, };
                WriteFunction(offset, newValues);

                offset = 0x6B773144;
                newValues = new byte[] { 0x36, 0x05, };
                WriteFunction(offset, newValues);

                offset = 0x6B773146;
                newValues = new byte[] { 0x36, 0x05, };
                WriteFunction(offset, newValues);

                offset = 0x6B77315E;
                newValues = new byte[] { 0x83, 0x09, };
                WriteFunction(offset, newValues);

                offset = 0x6B77315C;
                newValues = new byte[] { 0x83, 0x09, };
                WriteFunction(offset, newValues);

                offset = 0x6B773174;
                newValues = new byte[] { 0xB7, 0x0B, };
                WriteFunction(offset, newValues);

                offset = 0x6B773176;
                newValues = new byte[] { 0xB7, 0x0B, };
                WriteFunction(offset, newValues);

                offset = 0x6B7731B8;
                newValues = new byte[] { 0x11, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B7731F4;
                newValues = new byte[] { 0x1C, 0x0F, };
                WriteFunction(offset, newValues);

                offset = 0x6B7731D6;
                newValues = new byte[] { 0x2C, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B7360A4;
                newValues = new byte[] { 0xB4, 0x00, };
                WriteFunction(offset, newValues);

                offset = 0x6B736086;
                newValues = new byte[] { 0xAF, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B7731BA;
                newValues = new byte[] { 0x85, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B7731F6;
                newValues = new byte[] { 0xD9, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B7731D8;
                newValues = new byte[] { 0xC1, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B7731BC;
                newValues = new byte[] { 0x83, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B7731F8;
                newValues = new byte[] { 0x16, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B772FE4;
                newValues = new byte[] { 0x95, 0x0A, };
                WriteFunction(offset, newValues);

                offset = 0x6B772FE8;
                newValues = new byte[] { 0xE3, 0x09, };
                WriteFunction(offset, newValues);

                offset = 0x6B772FE6;
                newValues = new byte[] { 0x99, 0x0A, };
                WriteFunction(offset, newValues);

                offset = 0x6B772F68;
                newValues = new byte[] { 0x32, 0x02, };
                WriteFunction(offset, newValues);

                offset = 0x6B772F9A;
                newValues = new byte[] { 0xDA, 0x03, };
                WriteFunction(offset, newValues);

                offset = 0x6B772F78;
                newValues = new byte[] { 0xAC, 0x0C, };
                WriteFunction(offset, newValues);
            }
            else //original
            {
                uint offset = 0x6B73ED9E;
                byte[] newValues = new byte[] { 0xCB, 0x0A, };
                WriteFunction(offset, newValues);

                offset = 0x6B773142;
                newValues = new byte[] { 0xD2, 0x0A, };
                WriteFunction(offset, newValues);

                offset = 0x6B7373A0;
                newValues = new byte[] { 0x6A, 0x07, };
                WriteFunction(offset, newValues);

                offset = 0x6B77315A;
                newValues = new byte[] { 0xCE, 0x0A, };
                WriteFunction(offset, newValues);

                offset = 0x6B773130;
                newValues = new byte[] { 0xCF, 0x0A, };
                WriteFunction(offset, newValues);

                offset = 0x6B773148;
                newValues = new byte[] { 0x89, 0x07, };
                WriteFunction(offset, newValues);

                offset = 0x6B773178;
                newValues = new byte[] { 0x7B, 0x0B, };
                WriteFunction(offset, newValues);

                offset = 0x6B773144;
                newValues = new byte[] { 0xF5, 0x06, };
                WriteFunction(offset, newValues);

                offset = 0x6B773146;
                newValues = new byte[] { 0xF5, 0x06, };
                WriteFunction(offset, newValues);

                offset = 0x6B77315E;
                newValues = new byte[] { 0x0C, 0x08, };
                WriteFunction(offset, newValues);

                offset = 0x6B77315C;
                newValues = new byte[] { 0x0C, 0x08, };
                WriteFunction(offset, newValues);

                offset = 0x6B773174;
                newValues = new byte[] { 0xC3, 0x05, };
                WriteFunction(offset, newValues);

                offset = 0x6B773176;
                newValues = new byte[] { 0xC4, 0x05, };
                WriteFunction(offset, newValues);

                offset = 0x6B7731B8;
                newValues = new byte[] { 0x29, 0x0E, };
                WriteFunction(offset, newValues);

                offset = 0x6B7731F4;
                newValues = new byte[] { 0xC5, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B7731D6;
                newValues = new byte[] { 0xB0, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B7360A4;
                newValues = new byte[] { 0x76, 0x0E, };
                WriteFunction(offset, newValues);

                offset = 0x6B736086;
                newValues = new byte[] { 0x75, 0x0E, };
                WriteFunction(offset, newValues);

                offset = 0x6B7731BA;
                newValues = new byte[] { 0x2E, 0x0E, };
                WriteFunction(offset, newValues);

                offset = 0x6B7731F6;
                newValues = new byte[] { 0x9D, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B7731D8;
                newValues = new byte[] { 0xFC, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B7731BC;
                newValues = new byte[] { 0xDC, 0x0E, };
                WriteFunction(offset, newValues);

                offset = 0x6B7731F8;
                newValues = new byte[] { 0xBF, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B772FE4;
                newValues = new byte[] { 0xC8, 0x0B, };
                WriteFunction(offset, newValues);

                offset = 0x6B772FE8;
                newValues = new byte[] { 0xD6, 0x0A, };
                WriteFunction(offset, newValues);

                offset = 0x6B772FE6;
                newValues = new byte[] { 0x98, 0x0A, };
                WriteFunction(offset, newValues);

                offset = 0x6B772F68;
                newValues = new byte[] { 0xBD, 0x03, };
                WriteFunction(offset, newValues);

                offset = 0x6B772F9A;
                newValues = new byte[] { 0x8E, 0x00, };
                WriteFunction(offset, newValues);

                offset = 0x6B772F78;
                newValues = new byte[] { 0xB4, 0x00, };
                WriteFunction(offset, newValues);
            }
        }

        #endregion

        #region ShunYing_moveset

        public static void PhoenixStanceShunYingMoves()
        {
            if (SettingsClass.PhoenixStanceShunYingMoves) //custom
            {
                uint offset = 0x6B766460;
                byte[] newValues = new byte[] { 0x20, 0x03, };
                WriteFunction(offset, newValues);

                offset = 0x6B766492;
                newValues = new byte[] { 0x90, 0x00, };
                WriteFunction(offset, newValues);

                offset = 0x6B7664E0;
                newValues = new byte[] { 0x97, 0x08, };
                WriteFunction(offset, newValues);

                offset = 0x6B7664DA;
                newValues = new byte[] { 0x91, 0x00, };
                WriteFunction(offset, newValues);

                offset = 0x6B7664DE;
                newValues = new byte[] { 0xE7, 0x0A, };
                WriteFunction(offset, newValues);

                offset = 0x6B766470;
                newValues = new byte[] { 0x91, 0x00, };
                WriteFunction(offset, newValues);

                offset = 0x6B7664D4;
                newValues = new byte[] { 0x4A, 0x06, };
                WriteFunction(offset, newValues);

                offset = 0x6B7664D6;
                newValues = new byte[] { 0xD5, 0x07, };
                WriteFunction(offset, newValues);

                offset = 0x6B7664D8;
                newValues = new byte[] { 0xBA, 0x00, };
                WriteFunction(offset, newValues);

                offset = 0x6B7664D2;
                newValues = new byte[] { 0x07, 0x00, };
                WriteFunction(offset, newValues);

                offset = 0x6B7664CA;
                newValues = new byte[] { 0xA7, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B7664D0;
                newValues = new byte[] { 0xC6, 0x0A, };
                WriteFunction(offset, newValues);

                offset = 0x6B7664CC;
                newValues = new byte[] { 0xE0, 0x06, };
                WriteFunction(offset, newValues);

                offset = 0x6B7664CE;
                newValues = new byte[] { 0x99, 0x08, };
                WriteFunction(offset, newValues);

                offset = 0x6B766670;
                newValues = new byte[] { 0x8D, 0x08, };
                WriteFunction(offset, newValues);

                offset = 0x6B7666EC;
                newValues = new byte[] { 0xC1, 0x0E, };
                WriteFunction(offset, newValues);

                offset = 0x6B7666CE;
                newValues = new byte[] { 0x5D, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B7666EE;
                newValues = new byte[] { 0x62, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B7666D0;
                newValues = new byte[] { 0x14, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B7666AA;
                newValues = new byte[] { 0x7A, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B7666C8;
                newValues = new byte[] { 0x7A, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B7666E6;
                newValues = new byte[] { 0xB3, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B766704;
                newValues = new byte[] { 0x09, 0x0E, };
                WriteFunction(offset, newValues);

                offset = 0x6B7666C6;
                newValues = new byte[] { 0xC3, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B7666E4;
                newValues = new byte[] { 0x5F, 0x0F, };
                WriteFunction(offset, newValues);

                offset = 0x6B7666A8;
                newValues = new byte[] { 0xC8, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B766702;
                newValues = new byte[] { 0x7A, 0x0C, };
                WriteFunction(offset, newValues);
            }
            else //original
            {
                uint offset = 0x6B766460;
                byte[] newValues = new byte[] { 0x20, 0x03, };
                WriteFunction(offset, newValues);

                offset = 0x6B766492;
                newValues = new byte[] { 0xC4, 0x03, };
                WriteFunction(offset, newValues);

                offset = 0x6B7664E0;
                newValues = new byte[] { 0x97, 0x08, };
                WriteFunction(offset, newValues);

                offset = 0x6B7664DA;
                newValues = new byte[] { 0xF7, 0x05, };
                WriteFunction(offset, newValues);

                offset = 0x6B7664DE;
                newValues = new byte[] { 0x94, 0x0A, };
                WriteFunction(offset, newValues);

                offset = 0x6B766470;
                newValues = new byte[] { 0xB4, 0x00, };
                WriteFunction(offset, newValues);

                offset = 0x6B7664D4;
                newValues = new byte[] { 0x77, 0x00, };
                WriteFunction(offset, newValues);

                offset = 0x6B7664D6;
                newValues = new byte[] { 0x75, 0x00, };
                WriteFunction(offset, newValues);

                offset = 0x6B7664D8;
                newValues = new byte[] { 0x76, 0x00, };
                WriteFunction(offset, newValues);

                offset = 0x6B7664D2;
                newValues = new byte[] { 0x78, 0x00, };
                WriteFunction(offset, newValues);

                offset = 0x6B7664CA;
                newValues = new byte[] { 0x74, 0x00, };
                WriteFunction(offset, newValues);

                offset = 0x6B7664D0;
                newValues = new byte[] { 0x72, 0x00, };
                WriteFunction(offset, newValues);

                offset = 0x6B7664CC;
                newValues = new byte[] { 0x73, 0x00, };
                WriteFunction(offset, newValues);

                offset = 0x6B7664CE;
                newValues = new byte[] { 0x69, 0x00, };
                WriteFunction(offset, newValues);

                offset = 0x6B766670;
                newValues = new byte[] { 0xE6, 0x06, };
                WriteFunction(offset, newValues);

                offset = 0x6B7666EC;
                newValues = new byte[] { 0xC9, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B7666CE;
                newValues = new byte[] { 0xF1, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B7666EE;
                newValues = new byte[] { 0xE2, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B7666D0;
                newValues = new byte[] { 0xC1, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B7666AA;
                newValues = new byte[] { 0x95, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B7666C8;
                newValues = new byte[] { 0x92, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B7666E6;
                newValues = new byte[] { 0x94, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B766704;
                newValues = new byte[] { 0x93, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B7666C6;
                newValues = new byte[] { 0x8E, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B7666E4;
                newValues = new byte[] { 0x90, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B7666A8;
                newValues = new byte[] { 0x91, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B766702;
                newValues = new byte[] { 0x8F, 0x0D, };
                WriteFunction(offset, newValues);
            }
        }

        #endregion

        #region Dwayne_moveset

        public static void BrokenDwayneMoves()
        {
            if (SettingsClass.BrokenDwayneMoves) //custom
            {
                uint offset = 0x6B766F80;
                byte[] newValues = new byte[] { 0x33, 0x02, };
                WriteFunction(offset, newValues);

                offset = 0x6B766FB2;
                newValues = new byte[] { 0x91, 0x00, };
                WriteFunction(offset, newValues);

                offset = 0x6B73B072;
                newValues = new byte[] { 0x53, 0x06, };
                WriteFunction(offset, newValues);

                offset = 0x6B7423A4;
                newValues = new byte[] { 0x43, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B767150;
                newValues = new byte[] { 0x28, 0x09, };
                WriteFunction(offset, newValues);

                offset = 0x6B7344DE;
                newValues = new byte[] { 0x7A, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B766FF2;
                newValues = new byte[] { 0x07, 0x00, };
                WriteFunction(offset, newValues);

                offset = 0x6B766FF4;
                newValues = new byte[] { 0x14, 0x09, };
                WriteFunction(offset, newValues);

                offset = 0x6B766FF8;
                newValues = new byte[] { 0x10, 0x09, };
                WriteFunction(offset, newValues);

                offset = 0x6B766FF6;
                newValues = new byte[] { 0x17, 0x09, };
                WriteFunction(offset, newValues);

                offset = 0x6B767158;
                newValues = new byte[] { 0xE7, 0x0A, };
                WriteFunction(offset, newValues);

                offset = 0x6B766FFA;
                newValues = new byte[] { 0x90, 0x00, };
                WriteFunction(offset, newValues);

                offset = 0x6B766F90;
                newValues = new byte[] { 0x90, 0x00, };
                WriteFunction(offset, newValues);

                offset = 0x6B73B1DA;
                newValues = new byte[] { 0x73, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B73B66C;
                newValues = new byte[] { 0xBA, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B7348F8;
                newValues = new byte[] { 0x24, 0x0E, };
                WriteFunction(offset, newValues);

                offset = 0x6B7671EE;
                newValues = new byte[] { 0x53, 0x0F, };
                WriteFunction(offset, newValues);

                offset = 0x6B76720C;
                newValues = new byte[] { 0x00, 0xBB, };
                WriteFunction(offset, newValues);

                offset = 0x6B7671D0;
                newValues = new byte[] { 0x83, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B766FEA;
                newValues = new byte[] { 0x07, 0x00, };
                WriteFunction(offset, newValues);

                offset = 0x6B766FEC;
                newValues = new byte[] { 0x4A, 0x06, };
                WriteFunction(offset, newValues);

                offset = 0x6B766FF0;
                newValues = new byte[] { 0x8F, 0x06, };
                WriteFunction(offset, newValues);

                offset = 0x6B766FEE;
                newValues = new byte[] { 0x1F, 0x09, };
                WriteFunction(offset, newValues);

                offset = 0x6B734FA6;
                newValues = new byte[] { 0x25, 0x09, };
                WriteFunction(offset, newValues);

                offset = 0x6B7216E0;
                newValues = new byte[] { 0x00, 0x00, };
                WriteFunction(offset, newValues);

                offset = 0x6B7671EA;
                newValues = new byte[] { 0x7A, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B7671CC;
                newValues = new byte[] { 0x00, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B7671EC;
                newValues = new byte[] { 0x81, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B7671D2;
                newValues = new byte[] { 0x77, 0x0E, };
                WriteFunction(offset, newValues);

                offset = 0x6B76720D;
                newValues = new byte[] { 0xBB, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B76720A;
                newValues = new byte[] { 0x81, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B767228;
                newValues = new byte[] { 0x13, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B766FA9;
                newValues = new byte[] { 0x00, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B7671CE;
                newValues = new byte[] { 0x83, 0x0D, };
                WriteFunction(offset, newValues);
            }
            else //original
            {
                uint offset = 0x6B766F80;
                byte[] newValues = new byte[] { 0x92, 0x00, };
                WriteFunction(offset, newValues);

                offset = 0x6B766FB2;
                newValues = new byte[] { 0xDA, 0x03, };
                WriteFunction(offset, newValues);

                offset = 0x6B73B072;
                newValues = new byte[] { 0x11, 0x09, };
                WriteFunction(offset, newValues);

                offset = 0x6B7423A4;
                newValues = new byte[] { 0x82, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B767150;
                newValues = new byte[] { 0xAF, 0x05, };
                WriteFunction(offset, newValues);

                offset = 0x6B7344DE;
                newValues = new byte[] { 0xA8, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B766FF2;
                newValues = new byte[] { 0x78, 0x00, };
                WriteFunction(offset, newValues);

                offset = 0x6B766FF4;
                newValues = new byte[] { 0x77, 0x00, };
                WriteFunction(offset, newValues);

                offset = 0x6B766FF8;
                newValues = new byte[] { 0x76, 0x00, };
                WriteFunction(offset, newValues);

                offset = 0x6B766FF6;
                newValues = new byte[] { 0x75, 0x00, };
                WriteFunction(offset, newValues);

                offset = 0x6B767158;
                newValues = new byte[] { 0x9D, 0x04, };
                WriteFunction(offset, newValues);

                offset = 0x6B766FFA;
                newValues = new byte[] { 0x89, 0x04, };
                WriteFunction(offset, newValues);

                offset = 0x6B766F90;
                newValues = new byte[] { 0xB4, 0x00, };
                WriteFunction(offset, newValues);

                offset = 0x6B73B1DA;
                newValues = new byte[] { 0x1A, 0x09, };
                WriteFunction(offset, newValues);

                offset = 0x6B73B66C;
                newValues = new byte[] { 0x37, 0x09, };
                WriteFunction(offset, newValues);

                offset = 0x6B7348F8;
                newValues = new byte[] { 0x4A, 0x06, };
                WriteFunction(offset, newValues);

                offset = 0x6B7671EE;
                newValues = new byte[] { 0xF1, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B76720C;
                newValues = new byte[] { 0x28, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B7671D0;
                newValues = new byte[] { 0x73, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B766FEA;
                newValues = new byte[] { 0x74, 0x00, };
                WriteFunction(offset, newValues);

                offset = 0x6B766FEC;
                newValues = new byte[] { 0x73, 0x00, };
                WriteFunction(offset, newValues);

                offset = 0x6B766FF0;
                newValues = new byte[] { 0x72, 0x00, };
                WriteFunction(offset, newValues);

                offset = 0x6B766FEE;
                newValues = new byte[] { 0x69, 0x00, };
                WriteFunction(offset, newValues);

                offset = 0x6B734FA6;
                newValues = new byte[] { 0x91, 0x06, };
                WriteFunction(offset, newValues);

                offset = 0x6B7216E0;
                newValues = new byte[] { 0x3D, 0x00, };
                WriteFunction(offset, newValues);

                offset = 0x6B7671EA;
                newValues = new byte[] { 0xFB, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B7671CC;
                newValues = new byte[] { 0xF9, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B7671EC;
                newValues = new byte[] { 0x01, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B7671D2;
                newValues = new byte[] { 0x2C, 0x0E, };
                WriteFunction(offset, newValues);

                offset = 0x6B76720D;
                newValues = new byte[] { 0x0C, 0xA9, };
                WriteFunction(offset, newValues);

                offset = 0x6B76720A;
                newValues = new byte[] { 0x02, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B767228;
                newValues = new byte[] { 0x01, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B766FA9;
                newValues = new byte[] { 0x00, 0x00, };
                WriteFunction(offset, newValues);

                offset = 0x6B7671CE;
                newValues = new byte[] { 0x02, 0x0D, };
                WriteFunction(offset, newValues);
            }
        }

        #endregion

        #region Vera_moveset
        public static void MonsterVeraMoves()
        {
            if (SettingsClass.MonsterVeraMoves) //custom
            {
                uint offset = 0x6B76B7D0;//
                byte[] newValues = new byte[] { 0x50, 0x04, };
                WriteFunction(offset, newValues);

                offset = 0x6B76B802;//
                newValues = new byte[] { 0xB4, 0x00, };
                WriteFunction(offset, newValues);

                offset = 0x6B76B7E0;//
                newValues = new byte[] { 0xA7, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B76BA5C;//
                newValues = new byte[] { 0xA9, 0x0E, };
                WriteFunction(offset, newValues);

                offset = 0x6B76BA5E;//
                newValues = new byte[] { 0xDA, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B76BA20;//
                newValues = new byte[] { 0xD1, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B76BA22;//
                newValues = new byte[] { 0xC8, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B76BA3E;//
                newValues = new byte[] { 0xC9, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B76BA40;//
                newValues = new byte[] { 0x76, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B76BA36;//
                newValues = new byte[] { 0xE6, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B76BA60;//
                newValues = new byte[] { 0x69, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B76BA24;//
                newValues = new byte[] { 0x49, 0x0F, };
                WriteFunction(offset, newValues);

                offset = 0x6B76BA42;//
                newValues = new byte[] { 0xF6, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B76B84C;//
                newValues = new byte[] { 0xD7, 0x0A, };
                WriteFunction(offset, newValues);

                offset = 0x6B76B84E;//
                newValues = new byte[] { 0xD5, 0x07, };
                WriteFunction(offset, newValues);

                offset = 0x6B76B9CA;//
                newValues = new byte[] { 0xC5, 0x0A, };
                WriteFunction(offset, newValues);

                offset = 0x6B76BA76;//
                newValues = new byte[] { 0x5A, 0x0F, };
                WriteFunction(offset, newValues);

                offset = 0x6B76BA58;//
                newValues = new byte[] { 0x5A, 0x0F, };
                WriteFunction(offset, newValues);

                offset = 0x6B76BA78;//
                newValues = new byte[] { 0x4F, 0x0F, };
                WriteFunction(offset, newValues);

                offset = 0x6B76BA5A;//
                newValues = new byte[] { 0x4F, 0x0F, };
                WriteFunction(offset, newValues);

                offset = 0x6B76BA1C;//
                newValues = new byte[] { 0x4F, 0x0F, };
                WriteFunction(offset, newValues);

                offset = 0x6B76BA1E;//
                newValues = new byte[] { 0x5A, 0x0F, };
                WriteFunction(offset, newValues);

                offset = 0x6B76BA3A;//
                newValues = new byte[] { 0xEA, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B76BA3C;//
                newValues = new byte[] { 0xCB, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B76B992;//
                newValues = new byte[] { 0x29, 0x09, };
                WriteFunction(offset, newValues);

                offset = 0x6B76B9DA;//
                newValues = new byte[] { 0x24, 0x0B, };
                WriteFunction(offset, newValues);

                offset = 0x6B76B9AA;//
                newValues = new byte[] { 0x35, 0x05, };
                WriteFunction(offset, newValues);

                offset = 0x6B76B9C2;//
                newValues = new byte[] { 0xE0, 0x0A, };
                WriteFunction(offset, newValues);

                offset = 0x6B76B998;//
                newValues = new byte[] { 0xCF, 0x0B, };
                WriteFunction(offset, newValues);

                offset = 0x6B76B9B0;//
                newValues = new byte[] { 0xC6, 0x0A, };
                WriteFunction(offset, newValues);

                offset = 0x6B740748;//
                newValues = new byte[] { 0x00, 0x00, };
                WriteFunction(offset, newValues);

                offset = 0x6B7406EE;//
                newValues = new byte[] { 0x00, 0x00, };
                WriteFunction(offset, newValues);

                offset = 0x6B76B9DC;//
                newValues = new byte[] { 0x6D, 0x04, };
                WriteFunction(offset, newValues);

                offset = 0x6B76B9DE;//
                newValues = new byte[] { 0x70, 0x04, };
                WriteFunction(offset, newValues);

                offset = 0x6B76B9AC;//
                newValues = new byte[] { 0x43, 0x09, };
                WriteFunction(offset, newValues);

                offset = 0x6B76B9AE;//
                newValues = new byte[] { 0x43, 0x09, };
                WriteFunction(offset, newValues);

                offset = 0x6B76B9C4;//
                newValues = new byte[] { 0x04, 0x0A, };
                WriteFunction(offset, newValues);

                offset = 0x6B76B9C6;//
                newValues = new byte[] { 0x04, 0x0A, };
                WriteFunction(offset, newValues);

                offset = 0x6B76BA08;//
                newValues = new byte[] { 0xC5, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B76BA0A;//
                newValues = new byte[] { 0x5E, 0x0E, };
                WriteFunction(offset, newValues);

                offset = 0x6B745A5E;//
                newValues = new byte[] { 0xD1, 0x06, };
                WriteFunction(offset, newValues);

                offset = 0x6B746AC6;//
                newValues = new byte[] { 0xD1, 0x06, };
                WriteFunction(offset, newValues);

                offset = 0x6B745A04;//
                newValues = new byte[] { 0xD1, 0x06, };
                WriteFunction(offset, newValues);

                offset = 0x6B746A6C;//
                newValues = new byte[] { 0xD1, 0x06, };
                WriteFunction(offset, newValues);

                offset = 0x6B745B6C;//
                newValues = new byte[] { 0xD1, 0x06, };
                WriteFunction(offset, newValues);

                offset = 0x6B745D10;//
                newValues = new byte[] { 0xD1, 0x06, };
                WriteFunction(offset, newValues);

                offset = 0x6B745B30;//
                newValues = new byte[] { 0xD1, 0x06, };
                WriteFunction(offset, newValues);

                offset = 0x6B745CD4;//
                newValues = new byte[] { 0xD1, 0x06, };
                WriteFunction(offset, newValues);

                offset = 0x6B745C02;//
                newValues = new byte[] { 0xD1, 0x06, };
                WriteFunction(offset, newValues);

                offset = 0x6B745DA6;//
                newValues = new byte[] { 0xD1, 0x06, };
                WriteFunction(offset, newValues);

                offset = 0x6B745AD6;//
                newValues = new byte[] { 0xD1, 0x06, };
                WriteFunction(offset, newValues);

                offset = 0x6B745BA8;//
                newValues = new byte[] { 0xD1, 0x06, };
                WriteFunction(offset, newValues);
            }
            else //original
            {
                uint offset = 0x6B76B7D0;//
                byte[] newValues = new byte[] { 0x99, 0x02, };
                WriteFunction(offset, newValues);

                offset = 0x6B76B802;//
                newValues = new byte[] { 0xD9, 0x03, };
                WriteFunction(offset, newValues);

                offset = 0x6B76B7E0;//
                newValues = new byte[] { 0xB4, 0x00, };
                WriteFunction(offset, newValues);

                offset = 0x6B76BA5C;//
                newValues = new byte[] { 0xB6, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B76BA5E;//
                newValues = new byte[] { 0xC4, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B76BA20;//
                newValues = new byte[] { 0xA2, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B76BA22;//
                newValues = new byte[] { 0xBE, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B76BA3E;//
                newValues = new byte[] { 0x2C, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B76BA40;//
                newValues = new byte[] { 0xF4, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B76BA36;//
                newValues = new byte[] { 0x40, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B76BA60;//
                newValues = new byte[] { 0xE0, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B76BA24;//
                newValues = new byte[] { 0xDC, 0x0E, };
                WriteFunction(offset, newValues);

                offset = 0x6B76BA42;//
                newValues = new byte[] { 0xF0, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B76B84C;//
                newValues = new byte[] { 0xC8, 0x0B, };
                WriteFunction(offset, newValues);

                offset = 0x6B76B84E;//
                newValues = new byte[] { 0xE9, 0x0B, };
                WriteFunction(offset, newValues);

                offset = 0x6B76B9CA;//
                newValues = new byte[] { 0xFD, 0x0B, };
                WriteFunction(offset, newValues);

                offset = 0x6B76BA76;//
                newValues = new byte[] { 0x06, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B76BA58;//
                newValues = new byte[] { 0x07, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B76BA78;//
                newValues = new byte[] { 0x01, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B76BA5A;//
                newValues = new byte[] { 0x02, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B76BA1C;//
                newValues = new byte[] { 0xF9, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B76BA1E;//
                newValues = new byte[] { 0xEC, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B76BA3A;//
                newValues = new byte[] { 0xFB, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B76BA3C;//
                newValues = new byte[] { 0x01, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B76B992;//
                newValues = new byte[] { 0xD9, 0x0A, };
                WriteFunction(offset, newValues);

                offset = 0x6B76B9DA;//
                newValues = new byte[] { 0xDC, 0x0A, };
                WriteFunction(offset, newValues);

                offset = 0x6B76B9AA;//
                newValues = new byte[] { 0xDB, 0x0A, };
                WriteFunction(offset, newValues);

                offset = 0x6B76B9C2;//
                newValues = new byte[] { 0xDD, 0x0A, };
                WriteFunction(offset, newValues);

                offset = 0x6B76B998;//
                newValues = new byte[] { 0x69, 0x04, };
                WriteFunction(offset, newValues);

                offset = 0x6B76B9B0;//
                newValues = new byte[] { 0x4C, 0x07, };
                WriteFunction(offset, newValues);

                offset = 0x6B740748;//
                newValues = new byte[] { 0x83, 0x0B, };
                WriteFunction(offset, newValues);

                offset = 0x6B7406EE;//
                newValues = new byte[] { 0x83, 0x0B, };
                WriteFunction(offset, newValues);

                offset = 0x6B76B9DC;//
                newValues = new byte[] { 0xB3, 0x04, };
                WriteFunction(offset, newValues);

                offset = 0x6B76B9DE;//
                newValues = new byte[] { 0xB3, 0x04, };
                WriteFunction(offset, newValues);

                offset = 0x6B76B9AC;//
                newValues = new byte[] { 0x90, 0x04, };
                WriteFunction(offset, newValues);

                offset = 0x6B76B9AE;//
                newValues = new byte[] { 0x90, 0x04, };
                WriteFunction(offset, newValues);

                offset = 0x6B76B9C4;//
                newValues = new byte[] { 0x5D, 0x07, };
                WriteFunction(offset, newValues);

                offset = 0x6B76B9C6;//
                newValues = new byte[] { 0x5D, 0x07, };
                WriteFunction(offset, newValues);

                offset = 0x6B76BA08;//
                newValues = new byte[] { 0x43, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B76BA0A;//
                newValues = new byte[] { 0x46, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B745A5E;//
                newValues = new byte[] { 0xB8, 0x0E, };
                WriteFunction(offset, newValues);

                offset = 0x6B746AC6;//
                newValues = new byte[] { 0xB8, 0x0E, };
                WriteFunction(offset, newValues);

                offset = 0x6B745A04;//
                newValues = new byte[] { 0xF0, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B746A6C;//
                newValues = new byte[] { 0xF0, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B745B6C;//
                newValues = new byte[] { 0xBE, 0x0E, };
                WriteFunction(offset, newValues);

                offset = 0x6B745D10;//
                newValues = new byte[] { 0xBE, 0x0E, };
                WriteFunction(offset, newValues);

                offset = 0x6B745B30;//
                newValues = new byte[] { 0xB8, 0x0E, };
                WriteFunction(offset, newValues);

                offset = 0x6B745CD4;//
                newValues = new byte[] { 0xB8, 0x0E, };
                WriteFunction(offset, newValues);

                offset = 0x6B745C02;//
                newValues = new byte[] { 0xB8, 0x0E, };
                WriteFunction(offset, newValues);

                offset = 0x6B745DA6;//
                newValues = new byte[] { 0xB8, 0x0E, };
                WriteFunction(offset, newValues);

                offset = 0x6B745AD6;//
                newValues = new byte[] { 0xF0, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B745BA8;//
                newValues = new byte[] { 0xF0, 0x0D, };
                WriteFunction(offset, newValues);
            }
        }
        #endregion

        #region Kelly_moveset
        public static void ThugKellyMoves()
        {
            if (SettingsClass.ThugKellyMoves) //custom
            {
                uint offset = 0x6B767510;//
                byte[] newValues = new byte[] { 0x50, 0x04, };
                WriteFunction(offset, newValues);

                offset = 0x6B767542;//
                newValues = new byte[] { 0xD0, 0x01, };
                WriteFunction(offset, newValues);

                offset = 0x6B767520;//
                newValues = new byte[] { 0xA7, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B76779C;//
                newValues = new byte[] { 0xC5, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B76779E;//
                newValues = new byte[] { 0x35, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B767760;//
                newValues = new byte[] { 0xCB, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B767762;//
                newValues = new byte[] { 0x53, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B76777E;//
                newValues = new byte[] { 0x38, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B767782;//
                newValues = new byte[] { 0xBD, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B7677A0;//
                newValues = new byte[] { 0x69, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B767702;//
                newValues = new byte[] { 0xB3, 0x06, };
                WriteFunction(offset, newValues);

                offset = 0x6B76758E;//
                newValues = new byte[] { 0xD5, 0x07, };
                WriteFunction(offset, newValues);

                offset = 0x6B77D80A;//
                newValues = new byte[] { 0xC7, 0x07, };
                WriteFunction(offset, newValues);

                offset = 0x6B77D80E;//
                newValues = new byte[] { 0xA9, 0x0B, };
                WriteFunction(offset, newValues);

                offset = 0x6B77D80C;//
                newValues = new byte[] { 0xAA, 0x0B, };
                WriteFunction(offset, newValues);

                offset = 0x6B748998;//
                newValues = new byte[] { 0xCF, 0x0B, };
                WriteFunction(offset, newValues);

                offset = 0x6B749370;//
                newValues = new byte[] { 0xCF, 0x0B, };
                WriteFunction(offset, newValues);

                offset = 0x6B74893E;//
                newValues = new byte[] { 0xCF, 0x0B, };
                WriteFunction(offset, newValues);

                offset = 0x6B749316;//
                newValues = new byte[] { 0xCF, 0x0B, };
                WriteFunction(offset, newValues);

                offset = 0x6B748AA6;//
                newValues = new byte[] { 0xCF, 0x0B, };
                WriteFunction(offset, newValues);

                offset = 0x6B748C4A;//
                newValues = new byte[] { 0xCF, 0x0B, };
                WriteFunction(offset, newValues);

                offset = 0x6B748A6A;//
                newValues = new byte[] { 0xCF, 0x0B, };
                WriteFunction(offset, newValues);

                offset = 0x6B748C0E;//
                newValues = new byte[] { 0xCF, 0x0B, };
                WriteFunction(offset, newValues);

                offset = 0x6B748B3C;//
                newValues = new byte[] { 0xCF, 0x0B, };
                WriteFunction(offset, newValues);

                offset = 0x6B748CE0;//
                newValues = new byte[] { 0xCF, 0x0B, };
                WriteFunction(offset, newValues);

                offset = 0x6B748A10;//
                newValues = new byte[] { 0xCF, 0x0B, };
                WriteFunction(offset, newValues);

                offset = 0x6B748AE2;//
                newValues = new byte[] { 0xCF, 0x0B, };
                WriteFunction(offset, newValues);
            }
            else //original
            {
                uint offset = 0x6B767510;//
                byte[] newValues = new byte[] { 0x36, 0x02, };
                WriteFunction(offset, newValues);

                offset = 0x6B767542;//
                newValues = new byte[] { 0xD9, 0x03, };
                WriteFunction(offset, newValues);

                offset = 0x6B767520;//
                newValues = new byte[] { 0xD0, 0x01, };
                WriteFunction(offset, newValues);

                offset = 0x6B76779C;//
                newValues = new byte[] { 0x65, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B76779E;//
                newValues = new byte[] { 0xE2, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B767760;//
                newValues = new byte[] { 0x2A, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B767762;//
                newValues = new byte[] { 0x4A, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B76777E;//
                newValues = new byte[] { 0x31, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B767782;//
                newValues = new byte[] { 0xF0, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B7677A0;//
                newValues = new byte[] { 0xE0, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B767702;//
                newValues = new byte[] { 0x98, 0x0B, };
                WriteFunction(offset, newValues);

                offset = 0x6B76758E;//
                newValues = new byte[] { 0x9A, 0x0A, };
                WriteFunction(offset, newValues);

                offset = 0x6B77D80A;//
                newValues = new byte[] { 0xCB, 0x07, };
                WriteFunction(offset, newValues);

                offset = 0x6B77D80E;//
                newValues = new byte[] { 0xA7, 0x0B, };
                WriteFunction(offset, newValues);

                offset = 0x6B77D80C;//
                newValues = new byte[] { 0xA8, 0x0B, };
                WriteFunction(offset, newValues);

                offset = 0x6B748998;//
                newValues = new byte[] { 0xEF, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B749370;//
                newValues = new byte[] { 0xEF, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B74893E;//
                newValues = new byte[] { 0xF0, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B749316;//
                newValues = new byte[] { 0xF0, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B748AA6;//
                newValues = new byte[] { 0x1C, 0x0F, };
                WriteFunction(offset, newValues);

                offset = 0x6B748C4A;//
                newValues = new byte[] { 0x1C, 0x0F, };
                WriteFunction(offset, newValues);

                offset = 0x6B748A6A;//
                newValues = new byte[] { 0xEF, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B748C0E;//
                newValues = new byte[] { 0xEF, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B748B3C;//
                newValues = new byte[] { 0xEF, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B748CE0;//
                newValues = new byte[] { 0xEF, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B748A10;//
                newValues = new byte[] { 0xF0, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B748AE2;//
                newValues = new byte[] { 0xF0, 0x0D, };
                WriteFunction(offset, newValues);
            }
        }
        #endregion

        #region Swordmaster_Shun_Ying_And_Lilian_Moves
        public static void SwordmasterShunYingAndLilianMoves()
        {
            if (SettingsClass.SwordmasterShunYingAndLilianMoves) //custom
            {
                uint offset = 0x6B766460;//;
                byte[] newValues = new byte[] { 0x43, 0x03, };
                WriteFunction(offset, newValues);

                offset = 0x6B766492;//;
                newValues = new byte[] { 0xD0, 0x01, };
                WriteFunction(offset, newValues);

                offset = 0x6B766470;//;
                newValues = new byte[] { 0xBA, 0x00, };
                WriteFunction(offset, newValues);

                offset = 0x6B7666EE;//;
                newValues = new byte[] { 0xD9, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B7666B2;//;
                newValues = new byte[] { 0xB1, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B7666CE;//;
                newValues = new byte[] { 0x31, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B7666F0;//;
                newValues = new byte[] { 0x69, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B7666B4;//;
                newValues = new byte[] { 0xEF, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B7666D2;//;
                newValues = new byte[] { 0xF0, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B7664DE;//;
                newValues = new byte[] { 0xD5, 0x07, };
                WriteFunction(offset, newValues);

                offset = 0x6B779650;//;
                newValues = new byte[] { 0x25, 0x03, };
                WriteFunction(offset, newValues);

                offset = 0x6B7796CC;//;
                newValues = new byte[] { 0x7D, 0x09, };
                WriteFunction(offset, newValues);

                offset = 0x6B77AF58;//;
                newValues = new byte[] { 0x25, 0x03, };
                WriteFunction(offset, newValues);

                offset = 0x6B77B11A;//;
                newValues = new byte[] { 0x7F, 0x07, };
                WriteFunction(offset, newValues);

                offset = 0x6B77B11E;//;
                newValues = new byte[] { 0xA7, 0x08, };
                WriteFunction(offset, newValues);

                offset = 0x6B77B11C;//;
                newValues = new byte[] { 0xA8, 0x08, };
                WriteFunction(offset, newValues);

                offset = 0x6B77B132;//;
                newValues = new byte[] { 0x83, 0x08, };
                WriteFunction(offset, newValues);

                offset = 0x6B77AFD4;//;
                newValues = new byte[] { 0x7D, 0x09, };
                WriteFunction(offset, newValues);

                offset = 0x6B765ED0;//;
                newValues = new byte[] { 0x43, 0x03, };
                WriteFunction(offset, newValues);

                offset = 0x6B765F02;//;
                newValues = new byte[] { 0xD0, 0x01, };
                WriteFunction(offset, newValues);

                offset = 0x6B76615E;//;
                newValues = new byte[] { 0xC9, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B766120;//;
                newValues = new byte[] { 0x37, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B766122;//;
                newValues = new byte[] { 0x37, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B76613E;//;
                newValues = new byte[] { 0x31, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B7660DA;//;
                newValues = new byte[] { 0x58, 0x0A, };
                WriteFunction(offset, newValues);

                offset = 0x6B7660C8;//;
                newValues = new byte[] { 0x34, 0x05, };
                WriteFunction(offset, newValues);

                offset = 0x6B766124;//;
                newValues = new byte[] { 0xEF, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B766142;//;
                newValues = new byte[] { 0xF0, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B765F4E;//;
                newValues = new byte[] { 0xD5, 0x07, };
                WriteFunction(offset, newValues);

                offset = 0x6B779918;//;
                newValues = new byte[] { 0x25, 0x03, };
                WriteFunction(offset, newValues);

                offset = 0x6B779ADA;//;
                newValues = new byte[] { 0x83, 0x08, };
                WriteFunction(offset, newValues);

                offset = 0x6B779ADE;//;
                newValues = new byte[] { 0xAB, 0x08, };
                WriteFunction(offset, newValues);

                offset = 0x6B779ADC;//;
                newValues = new byte[] { 0xAC, 0x08, };
                WriteFunction(offset, newValues);

                offset = 0x6B779B0A;//;
                newValues = new byte[] { 0x8F, 0x09, };
                WriteFunction(offset, newValues);

                offset = 0x6B77B4E8;//;
                newValues = new byte[] { 0x25, 0x03, };
                WriteFunction(offset, newValues);

                offset = 0x6B77B6DA;//;
                newValues = new byte[] { 0x8F, 0x09, };
                WriteFunction(offset, newValues);

                offset = 0x6B780B20;//;
                newValues = new byte[] { 0x25, 0x03, };
                WriteFunction(offset, newValues);

                offset = 0x6B780CE2;//;
                newValues = new byte[] { 0x83, 0x08, };
                WriteFunction(offset, newValues);

                offset = 0x6B780CE6;//;
                newValues = new byte[] { 0xAC, 0x08, };
                WriteFunction(offset, newValues);

                offset = 0x6B780CE4;//;
                newValues = new byte[] { 0xAB, 0x08, };
                WriteFunction(offset, newValues);

                offset = 0x6B780B9C;//;
                newValues = new byte[] { 0xFE, 0x05, };
                WriteFunction(offset, newValues);

                offset = 0x6B743844;//;
                newValues = new byte[] { 0xE0, 0x06, };
                WriteFunction(offset, newValues);

                offset = 0x6B743FA6;//;
                newValues = new byte[] { 0xE0, 0x06, };
                WriteFunction(offset, newValues);

                offset = 0x6B7437EA;//;
                newValues = new byte[] { 0xE0, 0x06, };
                WriteFunction(offset, newValues);

                offset = 0x6B743F4C;//;
                newValues = new byte[] { 0xE0, 0x06, };
                WriteFunction(offset, newValues);

                offset = 0x6B743952;//;
                newValues = new byte[] { 0xE0, 0x06, };
                WriteFunction(offset, newValues);

                offset = 0x6B743AF6;//;
                newValues = new byte[] { 0xE0, 0x06, };
                WriteFunction(offset, newValues);

                offset = 0x6B743916;//;
                newValues = new byte[] { 0xE0, 0x06, };
                WriteFunction(offset, newValues);

                offset = 0x6B743ABA;//;
                newValues = new byte[] { 0xE0, 0x06, };
                WriteFunction(offset, newValues);

                offset = 0x6B7439E8;//;
                newValues = new byte[] { 0xE0, 0x06, };
                WriteFunction(offset, newValues);

                offset = 0x6B743B8C;//;
                newValues = new byte[] { 0xE0, 0x06, };
                WriteFunction(offset, newValues);

                offset = 0x6B7438BC;//;
                newValues = new byte[] { 0xE0, 0x06, };
                WriteFunction(offset, newValues);

                offset = 0x6B74398E;//;
                newValues = new byte[] { 0xE0, 0x06, };
                WriteFunction(offset, newValues);

                offset = 0x6B73E0D8;//;
                newValues = new byte[] { 0x00, 0x00, };
                WriteFunction(offset, newValues);

                offset = 0x6B73E09C;//;
                newValues = new byte[] { 0x00, 0x00, };
                WriteFunction(offset, newValues);

                offset = 0x6B76665A;//;
                newValues = new byte[] { 0xC5, 0x0A, };
                WriteFunction(offset, newValues);
            }
            else //original
            {
                uint offset = 0x6B766460;//;
                byte[] newValues = new byte[] { 0x20, 0x03, };
                WriteFunction(offset, newValues);

                offset = 0x6B766492;//;
                newValues = new byte[] { 0xC4, 0x03, };
                WriteFunction(offset, newValues);

                offset = 0x6B766470;//;
                newValues = new byte[] { 0xB4, 0x00, };
                WriteFunction(offset, newValues);

                offset = 0x6B7666EE;//;
                newValues = new byte[] { 0xE2, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B7666B2;//;
                newValues = new byte[] { 0xC3, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B7666CE;//;
                newValues = new byte[] { 0xF1, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B7666F0;//;
                newValues = new byte[] { 0xE0, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B7666B4;//;
                newValues = new byte[] { 0x31, 0x0E, };
                WriteFunction(offset, newValues);

                offset = 0x6B7666D2;//;
                newValues = new byte[] { 0xBD, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B7664DE;//;
                newValues = new byte[] { 0x94, 0x0A, };
                WriteFunction(offset, newValues);

                offset = 0x6B779650;//;
                newValues = new byte[] { 0x21, 0x03, };
                WriteFunction(offset, newValues);

                offset = 0x6B7796CC;//;
                newValues = new byte[] { 0x89, 0x08, };
                WriteFunction(offset, newValues);

                offset = 0x6B77AF58;//;
                newValues = new byte[] { 0x21, 0x03, };
                WriteFunction(offset, newValues);

                offset = 0x6B77B11A;//;
                newValues = new byte[] { 0x83, 0x08, };
                WriteFunction(offset, newValues);

                offset = 0x6B77B11E;//;
                newValues = new byte[] { 0xAB, 0x08, };
                WriteFunction(offset, newValues);

                offset = 0x6B77B11C;//;
                newValues = new byte[] { 0xAC, 0x08, };
                WriteFunction(offset, newValues);

                offset = 0x6B77B132;//;
                newValues = new byte[] { 0x7C, 0x08, };
                WriteFunction(offset, newValues);

                offset = 0x6B77AFD4;//;
                newValues = new byte[] { 0x89, 0x08, };
                WriteFunction(offset, newValues);

                offset = 0x6B765ED0;//;
                newValues = new byte[] { 0xC8, 0x03, };
                WriteFunction(offset, newValues);

                offset = 0x6B765F02;//;
                newValues = new byte[] { 0xC4, 0x03, };
                WriteFunction(offset, newValues);

                offset = 0x6B76615E;//;
                newValues = new byte[] { 0xE2, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B766120;//;
                newValues = new byte[] { 0x2A, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B766122;//;
                newValues = new byte[] { 0x4A, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B76613E;//;
                newValues = new byte[] { 0xF1, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B7660DA;//;
                newValues = new byte[] { 0x6C, 0x0A, };
                WriteFunction(offset, newValues);

                offset = 0x6B7660C8;//;
                newValues = new byte[] { 0xAB, 0x04, };
                WriteFunction(offset, newValues);

                offset = 0x6B766124;//;
                newValues = new byte[] { 0xDC, 0x0E, };
                WriteFunction(offset, newValues);

                offset = 0x6B766142;//;
                newValues = new byte[] { 0xBD, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B765F4E;//;
                newValues = new byte[] { 0x94, 0x0A, };
                WriteFunction(offset, newValues);

                offset = 0x6B779918;//;
                newValues = new byte[] { 0xD1, 0x02, };
                WriteFunction(offset, newValues);

                offset = 0x6B779ADA;//;
                newValues = new byte[] { 0x78, 0x08, };
                WriteFunction(offset, newValues);

                offset = 0x6B779ADE;//;
                newValues = new byte[] { 0xA9, 0x08, };
                WriteFunction(offset, newValues);

                offset = 0x6B779ADC;//;
                newValues = new byte[] { 0xAA, 0x08, };
                WriteFunction(offset, newValues);

                offset = 0x6B779B0A;//;
                newValues = new byte[] { 0x81, 0x08, };
                WriteFunction(offset, newValues);

                offset = 0x6B77B4E8;//;
                newValues = new byte[] { 0xD1, 0x02, };
                WriteFunction(offset, newValues);

                offset = 0x6B77B6DA;//;
                newValues = new byte[] { 0x81, 0x08, };
                WriteFunction(offset, newValues);

                offset = 0x6B780B20;//;
                newValues = new byte[] { 0xD2, 0x02, };
                WriteFunction(offset, newValues);

                offset = 0x6B780CE2;//;
                newValues = new byte[] { 0xAE, 0x0B, };
                WriteFunction(offset, newValues);

                offset = 0x6B780CE6;//;
                newValues = new byte[] { 0xB0, 0x0B, };
                WriteFunction(offset, newValues);

                offset = 0x6B780CE4;//;
                newValues = new byte[] { 0xB1, 0x0B, };
                WriteFunction(offset, newValues);

                offset = 0x6B780B9C;//;
                newValues = new byte[] { 0xDD, 0x07, };
                WriteFunction(offset, newValues);

                offset = 0x6B743844;//;
                newValues = new byte[] { 0xEF, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B743FA6;//;
                newValues = new byte[] { 0xEF, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B7437EA;//;
                newValues = new byte[] { 0xF0, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B743F4C;//;
                newValues = new byte[] { 0xF0, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B743952;//;
                newValues = new byte[] { 0x0A, 0x0E, };
                WriteFunction(offset, newValues);

                offset = 0x6B743AF6;//;
                newValues = new byte[] { 0x0A, 0x0E, };
                WriteFunction(offset, newValues);

                offset = 0x6B743916;//;
                newValues = new byte[] { 0xEF, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B743ABA;//;
                newValues = new byte[] { 0xEF, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B7439E8;//;
                newValues = new byte[] { 0xEF, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B743B8C;//;
                newValues = new byte[] { 0xEF, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B7438BC;//;
                newValues = new byte[] { 0xF0, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B74398E;//;
                newValues = new byte[] { 0xF0, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B73E0D8;//;
                newValues = new byte[] { 0x62, 0x0A, };
                WriteFunction(offset, newValues);

                offset = 0x6B73E09C;//;
                newValues = new byte[] { 0x62, 0x0A, };
                WriteFunction(offset, newValues);

                offset = 0x6B76665A;//;
                newValues = new byte[] { 0x7A, 0x0B, };
                WriteFunction(offset, newValues);
            }
        }
        #endregion

        #region Swordmaster_Lin_Fong_Moves
        public static void SwordmasterLinFongMoves()
        {
            if (SettingsClass.SwordmasterLinFongMoves) //custom
            {
                uint offset = 0x6B7750FA;
                byte[] newValues = new byte[] { 0xD0, 0x01, };
                WriteFunction(offset, newValues);

                offset = 0x6B7750D8;
                newValues = new byte[] { 0xBA, 0x00, };
                WriteFunction(offset, newValues);

                offset = 0x6B775356;
                newValues = new byte[] { 0xD9, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B775318;
                newValues = new byte[] { 0x37, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B775358;
                newValues = new byte[] { 0x69, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B77531C;
                newValues = new byte[] { 0xEF, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B77533A;
                newValues = new byte[] { 0xF0, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B775144;
                newValues = new byte[] { 0x8E, 0x06, };
                WriteFunction(offset, newValues);

                offset = 0x6B775146;
                newValues = new byte[] { 0xD5, 0x07, };
                WriteFunction(offset, newValues);

                offset = 0x6B7752C2;
                newValues = new byte[] { 0x71, 0x09, };
                WriteFunction(offset, newValues);

                offset = 0x6B7752D8;
                newValues = new byte[] { 0xE6, 0x06, };
                WriteFunction(offset, newValues);

                offset = 0x6B73F0C8;
                newValues = new byte[] { 0x00, 0x00, };
                WriteFunction(offset, newValues);

                offset = 0x6B73F08C;
                newValues = new byte[] { 0x00, 0x00, };
                WriteFunction(offset, newValues);

                offset = 0x6B747930;
                newValues = new byte[] { 0xE0, 0x06, };
                WriteFunction(offset, newValues);

                offset = 0x6B749028;
                newValues = new byte[] { 0xE0, 0x06, };
                WriteFunction(offset, newValues);

                offset = 0x6B7478D6;
                newValues = new byte[] { 0xE0, 0x06, };
                WriteFunction(offset, newValues);

                offset = 0x6B748FCE;
                newValues = new byte[] { 0xE0, 0x06, };
                WriteFunction(offset, newValues);

                offset = 0x6B747A3E;
                newValues = new byte[] { 0xE0, 0x06, };
                WriteFunction(offset, newValues);

                offset = 0x6B747BE2;
                newValues = new byte[] { 0xE0, 0x06, };
                WriteFunction(offset, newValues);

                offset = 0x6B747A02;
                newValues = new byte[] { 0xE0, 0x06, };
                WriteFunction(offset, newValues);

                offset = 0x6B747BA6;
                newValues = new byte[] { 0xE0, 0x06, };
                WriteFunction(offset, newValues);

                offset = 0x6B747AD4;
                newValues = new byte[] { 0xE0, 0x06, };
                WriteFunction(offset, newValues);

                offset = 0x6B747C78;
                newValues = new byte[] { 0xE0, 0x06, };
                WriteFunction(offset, newValues);

                offset = 0x6B7479A8;
                newValues = new byte[] { 0xE0, 0x06, };
                WriteFunction(offset, newValues);

                offset = 0x6B747A7A;
                newValues = new byte[] { 0xE0, 0x06, };
                WriteFunction(offset, newValues);

                offset = 0x6B77AE52;
                newValues = new byte[] { 0x78, 0x09, };
                WriteFunction(offset, newValues);

                offset = 0x6B77AE56;
                newValues = new byte[] { 0x7E, 0x09, };
                WriteFunction(offset, newValues);

                offset = 0x6B77AE54;
                newValues = new byte[] { 0x7F, 0x09, };
                WriteFunction(offset, newValues);

                offset = 0x6B77AE6A;
                newValues = new byte[] { 0x7B, 0x09, };
                WriteFunction(offset, newValues);
            }
            else //original
            {
                uint offset = 0x6B7750FA;
                byte[] newValues = new byte[] { 0xEE, 0x03, };
                WriteFunction(offset, newValues);

                offset = 0x6B7750D8;
                newValues = new byte[] { 0xB4, 0x00, };
                WriteFunction(offset, newValues);

                offset = 0x6B775356;
                newValues = new byte[] { 0xE2, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B775318;
                newValues = new byte[] { 0x8E, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B775358;
                newValues = new byte[] { 0xE0, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B77531C;
                newValues = new byte[] { 0xDC, 0x0E, };
                WriteFunction(offset, newValues);

                offset = 0x6B77533A;
                newValues = new byte[] { 0xBD, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B775144;
                newValues = new byte[] { 0x8E, 0x07, };
                WriteFunction(offset, newValues);

                offset = 0x6B775146;
                newValues = new byte[] { 0x4C, 0x0B, };
                WriteFunction(offset, newValues);

                offset = 0x6B7752C2;
                newValues = new byte[] { 0x88, 0x09, };
                WriteFunction(offset, newValues);

                offset = 0x6B7752D8;
                newValues = new byte[] { 0x87, 0x09, };
                WriteFunction(offset, newValues);

                offset = 0x6B73F0C8;
                newValues = new byte[] { 0xE2, 0x0A, };
                WriteFunction(offset, newValues);

                offset = 0x6B73F08C;
                newValues = new byte[] { 0xE2, 0x0A, };
                WriteFunction(offset, newValues);

                offset = 0x6B747930;
                newValues = new byte[] { 0xEF, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B749028;
                newValues = new byte[] { 0xEF, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B7478D6;
                newValues = new byte[] { 0xF0, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B748FCE;
                newValues = new byte[] { 0xF0, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B747A3E;
                newValues = new byte[] { 0x04, 0x0F, };
                WriteFunction(offset, newValues);

                offset = 0x6B747BE2;
                newValues = new byte[] { 0x04, 0x0F, };
                WriteFunction(offset, newValues);

                offset = 0x6B747A02;
                newValues = new byte[] { 0xEF, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B747BA6;
                newValues = new byte[] { 0xEF, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B747AD4;
                newValues = new byte[] { 0xEF, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B747C78;
                newValues = new byte[] { 0xEF, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B7479A8;
                newValues = new byte[] { 0xF0, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B747A7A;
                newValues = new byte[] { 0xF0, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B77AE52;
                newValues = new byte[] { 0x83, 0x08, };
                WriteFunction(offset, newValues);

                offset = 0x6B77AE56;
                newValues = new byte[] { 0xA9, 0x08, };
                WriteFunction(offset, newValues);

                offset = 0x6B77AE54;
                newValues = new byte[] { 0xAA, 0x08, };
                WriteFunction(offset, newValues);

                offset = 0x6B77AE6A;
                newValues = new byte[] { 0x7C, 0x08, };
                WriteFunction(offset, newValues);
            }
        }

        #endregion

        #region Smart_Park_Moves
        public static void SmartParkMoves()
        {
            if (SettingsClass.SmartParkMoves) //custom
            {
                uint offset = 0x6B766728;
                byte[] newValues = new byte[] { 0xBD, 0x03, };
                WriteFunction(offset, newValues);

                offset = 0x6B76675A;
                newValues = new byte[] { 0xD0, 0x01, };
                WriteFunction(offset, newValues);

                offset = 0x6B766738;
                newValues = new byte[] { 0xA7, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B7669B6;
                newValues = new byte[] { 0xBC, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B766978;
                newValues = new byte[] { 0x37, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B76697A;
                newValues = new byte[] { 0x37, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B7669B8;
                newValues = new byte[] { 0x69, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B76697C;
                newValues = new byte[] { 0xEF, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B76699A;
                newValues = new byte[] { 0xF0, 0x0C, };
                WriteFunction(offset, newValues);

                offset = 0x6B7667A6;
                newValues = new byte[] { 0xD5, 0x07, };
                WriteFunction(offset, newValues);

                offset = 0x6B738156;
                newValues = new byte[] { 0xEA, 0x0B, };
                WriteFunction(offset, newValues);

                offset = 0x6B738390;
                newValues = new byte[] { 0xEA, 0x0B, };
                WriteFunction(offset, newValues);

                offset = 0x6B766932;
                newValues = new byte[] { 0xD9, 0x04, };
                WriteFunction(offset, newValues);

                offset = 0x6B766934;
                newValues = new byte[] { 0x6D, 0x04, };
                WriteFunction(offset, newValues);

                offset = 0x6B766936;
                newValues = new byte[] { 0x70, 0x04, };
                WriteFunction(offset, newValues);

                offset = 0x6B747930;
                newValues = new byte[] { 0xF6, 0x06, };
                WriteFunction(offset, newValues);

                offset = 0x6B749028;
                newValues = new byte[] { 0xF6, 0x06, };
                WriteFunction(offset, newValues);

                offset = 0x6B7478D6;
                newValues = new byte[] { 0xF6, 0x06, };
                WriteFunction(offset, newValues);

                offset = 0x6B748FCE;
                newValues = new byte[] { 0xF6, 0x06, };
                WriteFunction(offset, newValues);

                offset = 0x6B747BE2;
                newValues = new byte[] { 0xF6, 0x06, };
                WriteFunction(offset, newValues);

                offset = 0x6B747A3E;
                newValues = new byte[] { 0xF6, 0x06, };
                WriteFunction(offset, newValues);

                offset = 0x6B747BA6;
                newValues = new byte[] { 0xF6, 0x06, };
                WriteFunction(offset, newValues);

                offset = 0x6B747A02;
                newValues = new byte[] { 0xF6, 0x06, };
                WriteFunction(offset, newValues);

                offset = 0x6B747C78;
                newValues = new byte[] { 0xF6, 0x06, };
                WriteFunction(offset, newValues);

                offset = 0x6B747AD4;
                newValues = new byte[] { 0xF6, 0x06, };
                WriteFunction(offset, newValues);

                offset = 0x6B7479A8;
                newValues = new byte[] { 0xF6, 0x06, };
                WriteFunction(offset, newValues);

                offset = 0x6B747A7A;
                newValues = new byte[] { 0xF6, 0x06, };
                WriteFunction(offset, newValues);

                offset = 0x6B766902;
                newValues = new byte[] { 0x9C, 0x06, };
                WriteFunction(offset, newValues);

                offset = 0x6B7668F0;
                newValues = new byte[] { 0xCF, 0x0B, };
                WriteFunction(offset, newValues);
            }
            else //original
            {
                uint offset = 0x6B766728;
                byte[] newValues = new byte[] { 0x33, 0x02, };
                WriteFunction(offset, newValues);

                offset = 0x6B76675A;
                newValues = new byte[] { 0xDA, 0x03, };
                WriteFunction(offset, newValues);

                offset = 0x6B766738;
                newValues = new byte[] { 0xB4, 0x00, };
                WriteFunction(offset, newValues);

                offset = 0x6B7669B6;
                newValues = new byte[] { 0xE2, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B766978;
                newValues = new byte[] { 0xDD, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B76697A;
                newValues = new byte[] { 0xE1, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B7669B8;
                newValues = new byte[] { 0xE0, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B76697C;
                newValues = new byte[] { 0xDF, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B76699A;
                newValues = new byte[] { 0xBD, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B7667A6;
                newValues = new byte[] { 0x95, 0x0A, };
                WriteFunction(offset, newValues);

                offset = 0x6B738156;
                newValues = new byte[] { 0xE2, 0x07, };
                WriteFunction(offset, newValues);

                offset = 0x6B738390;
                newValues = new byte[] { 0xE2, 0x07, };
                WriteFunction(offset, newValues);

                offset = 0x6B766932;
                newValues = new byte[] { 0xE8, 0x0A, };
                WriteFunction(offset, newValues);

                offset = 0x6B766934;
                newValues = new byte[] { 0xEC, 0x0B, };
                WriteFunction(offset, newValues);

                offset = 0x6B766936;
                newValues = new byte[] { 0xEC, 0x0B, };
                WriteFunction(offset, newValues);

                offset = 0x6B747930;
                newValues = new byte[] { 0xEF, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B749028;
                newValues = new byte[] { 0xEF, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B7478D6;
                newValues = new byte[] { 0xF0, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B748FCE;
                newValues = new byte[] { 0xF0, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B747BE2;
                newValues = new byte[] { 0x04, 0x0F, };
                WriteFunction(offset, newValues);

                offset = 0x6B747A3E;
                newValues = new byte[] { 0x04, 0x0F, };
                WriteFunction(offset, newValues);

                offset = 0x6B747BA6;
                newValues = new byte[] { 0xEF, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B747A02;
                newValues = new byte[] { 0xEF, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B747C78;
                newValues = new byte[] { 0xEF, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B747AD4;
                newValues = new byte[] { 0xEF, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B7479A8;
                newValues = new byte[] { 0xF0, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B747A7A;
                newValues = new byte[] { 0xF0, 0x0D, };
                WriteFunction(offset, newValues);

                offset = 0x6B766902;
                newValues = new byte[] { 0xF6, 0x06, };
                WriteFunction(offset, newValues);

                offset = 0x6B7668F0;
                newValues = new byte[] { 0xEA, 0x0B, };
                WriteFunction(offset, newValues);
            }
        }
        #endregion

        public static void ChangeStats()
        {
            if (SettingsClass.StatsChanged) //custom
            {
                uint offset = 0x6B80A5BC;//Brad Hawk (first)
                byte[] newValues = new byte[] { 0x78, 0x05, 0x4C, 0x04, 0xE8, 0x03, 0xE2, 0x04, 0xB6, 0x03, 0x78, 0x05, 0xB0, 0x04, 0x14, 0x05, 0xE8, 0x03, };
                WriteFunction(offset, newValues);

                offset = 0x6B80A79C;//Glen
                newValues = new byte[] { 0xB6, 0x03, 0xB0, 0x04, 0x20, 0x03, 0xB6, 0x03, 0xE8, 0x03, 0xB0, 0x04, 0x1A, 0x04, 0x4C, 0x04, 0x20, 0x03, };
                WriteFunction(offset, newValues);

                offset = 0x6B80A83C;//Torque
                newValues = new byte[] { 0x20, 0x03, 0xBC, 0x02, 0xBC, 0x02, 0x58, 0x02, 0x58, 0x02, 0xB6, 0x03, 0x58, 0x02, 0xEE, 0x02, 0xF4, 0x01, };
                WriteFunction(offset, newValues);

                offset = 0x6B80A8DC;//Rod
                newValues = new byte[] { 0xBC, 0x02, 0xF4, 0x01, 0x8A, 0x02, 0xBC, 0x02, 0xBC, 0x02, 0x58, 0x02, 0x90, 0x01, 0xF4, 0x01, 0x90, 0x01, };
                WriteFunction(offset, newValues);

                offset = 0x6B80A97C;//Seth
                newValues = new byte[] { 0x52, 0x03, 0x84, 0x03, 0xBC, 0x02, 0xBC, 0x02, 0x26, 0x02, 0x52, 0x03, 0x58, 0x02, 0xEE, 0x02, 0xF4, 0x01, };
                WriteFunction(offset, newValues);

                offset = 0x6B80AA1C;//Nas-Tiii
                newValues = new byte[] { 0x58, 0x02, 0x26, 0x02, 0x5E, 0x01, 0x90, 0x01, 0x90, 0x01, 0xC2, 0x01, 0x2C, 0x01, 0x90, 0x01, 0x2C, 0x01, };
                WriteFunction(offset, newValues);

                offset = 0x6B80AABC;//Em Cee
                newValues = new byte[] { 0xBC, 0x02, 0xF4, 0x01, 0xF4, 0x01, 0xC2, 0x01, 0xC2, 0x01, 0x90, 0x01, 0xFA, 0x00, 0xFA, 0x00, 0xC8, 0x00, };
                WriteFunction(offset, newValues);

                offset = 0x6B80AB5C;//Real Deal
                newValues = new byte[] { 0xFA, 0x00, 0x2C, 0x01, 0x5E, 0x01, 0x2C, 0x01, 0x90, 0x01, 0x5E, 0x01, 0x2C, 0x01, 0x2C, 0x01, 0xC8, 0x00, };
                WriteFunction(offset, newValues);

                offset = 0x6B80ABFC;//Ty
                newValues = new byte[] { 0xEE, 0x02, 0x71, 0x02, 0x7B, 0x02, 0x6C, 0x02, 0x20, 0x03, 0x58, 0x02, 0x5E, 0x01, 0x5E, 0x01, 0x2C, 0x01, };
                WriteFunction(offset, newValues);

                offset = 0x6B80AC9C;//Miguel
                newValues = new byte[] { 0xF8, 0x02, 0x80, 0x02, 0x76, 0x02, 0x8A, 0x02, 0xA8, 0x02, 0x6C, 0x02, 0x2C, 0x01, 0xC2, 0x01, 0x2C, 0x01, };
                WriteFunction(offset, newValues);

                offset = 0x6B80AD3C;//Ramon
                newValues = new byte[] { 0xA8, 0x02, 0x44, 0x02, 0x6C, 0x02, 0xD0, 0x02, 0x58, 0x02, 0x90, 0x01, 0xFA, 0x00, 0x5E, 0x01, 0xC8, 0x00, };
                WriteFunction(offset, newValues);

                offset = 0x6B80ADDC;//Jose
                newValues = new byte[] { 0xBC, 0x02, 0x8A, 0x02, 0x58, 0x02, 0xF4, 0x01, 0x58, 0x02, 0x20, 0x03, 0x8A, 0x02, 0x58, 0x02, 0x90, 0x01, };
                WriteFunction(offset, newValues);

                offset = 0x6B80AE7C;//Emilio
                newValues = new byte[] { 0x52, 0x03, 0x84, 0x03, 0xEE, 0x02, 0x84, 0x03, 0xBC, 0x02, 0xEE, 0x02, 0x52, 0x03, 0x20, 0x03, 0x58, 0x02, };
                WriteFunction(offset, newValues);

                offset = 0x6B80AF1C;//Kadonashi
                newValues = new byte[] { 0xE8, 0x03, 0xEE, 0x02, 0x84, 0x03, 0x14, 0x05, 0xE2, 0x04, 0x7E, 0x04, 0x20, 0x03, 0x84, 0x03, 0xB6, 0x03, };
                WriteFunction(offset, newValues);

                offset = 0x6B80AFBC;//Reggie
                newValues = new byte[] { 0x84, 0x03, 0x58, 0x02, 0xEE, 0x02, 0x20, 0x03, 0x8A, 0x02, 0xBC, 0x02, 0x8A, 0x02, 0x58, 0x02, 0x20, 0x03, };
                WriteFunction(offset, newValues);

                offset = 0x6B80B05C;//Zack
                newValues = new byte[] { 0xEE, 0x02, 0xBC, 0x02, 0xF4, 0x01, 0x58, 0x02, 0xC2, 0x01, 0x58, 0x02, 0xF4, 0x01, 0x8A, 0x02, 0xBC, 0x02, };
                WriteFunction(offset, newValues);

                offset = 0x6B80B0FC;//Colin
                newValues = new byte[] { 0x4C, 0x04, 0xBC, 0x02, 0x20, 0x03, 0x52, 0x03, 0xBC, 0x02, 0xE8, 0x03, 0x84, 0x03, 0x20, 0x03, 0xE8, 0x03, };
                WriteFunction(offset, newValues);

                offset = 0x6B80B19C;//Jake
                newValues = new byte[] { 0xB6, 0x03, 0xAA, 0x05, 0xB6, 0x03, 0x52, 0x03, 0xBC, 0x02, 0x14, 0x05, 0xB6, 0x03, 0x52, 0x03, 0x84, 0x03, };
                WriteFunction(offset, newValues);

                offset = 0x6B80B23C;//Tong Yoon
                newValues = new byte[] { 0xB6, 0x03, 0xAA, 0x05, 0xB6, 0x03, 0x52, 0x03, 0xBC, 0x02, 0x14, 0x05, 0xB6, 0x03, 0x52, 0x03, 0x84, 0x03, };
                WriteFunction(offset, newValues);

                offset = 0x6B80B2DC;//Grimm
                newValues = new byte[] { 0x78, 0x05, 0x4C, 0x04, 0x20, 0x03, 0x84, 0x03, 0x26, 0x02, 0x7E, 0x04, 0xE8, 0x03, 0x20, 0x03, 0xF4, 0x01, };
                WriteFunction(offset, newValues);

                offset = 0x6B80B37C;//BK
                newValues = new byte[] { 0xF4, 0x01, 0x90, 0x01, 0x58, 0x02, 0xF4, 0x01, 0x90, 0x01, 0x2C, 0x01, 0x90, 0x01, 0xF4, 0x01, 0xC8, 0x00, };
                WriteFunction(offset, newValues);

                offset = 0x6B80B41C;//Grave Digga'
                newValues = new byte[] { 0x20, 0x03, 0xBC, 0x02, 0xEE, 0x02, 0x52, 0x03, 0x20, 0x03, 0x84, 0x03, 0x8A, 0x02, 0x20, 0x03, 0xBC, 0x02, };
                WriteFunction(offset, newValues);

                offset = 0x6B80B4BC;//Bones
                newValues = new byte[] { 0x84, 0x03, 0x8A, 0x02, 0xBC, 0x02, 0xEE, 0x02, 0x26, 0x02, 0xBC, 0x02, 0xF4, 0x01, 0x58, 0x02, 0x2C, 0x01, };
                WriteFunction(offset, newValues);

                offset = 0x6B80B55C;//Booma
                newValues = new byte[] { 0x20, 0x03, 0xBC, 0x02, 0x58, 0x02, 0x26, 0x02, 0xF4, 0x01, 0x20, 0x03, 0xBC, 0x02, 0x58, 0x02, 0x2C, 0x01, };
                WriteFunction(offset, newValues);

                offset = 0x6B80B5FC;//Busta
                newValues = new byte[] { 0x58, 0x02, 0xF4, 0x01, 0xF4, 0x01, 0x58, 0x02, 0xEE, 0x02, 0x52, 0x03, 0xF4, 0x01, 0x26, 0x02, 0x2C, 0x01, };
                WriteFunction(offset, newValues);

                offset = 0x6B80B69C;//Spider
                newValues = new byte[] { 0xEE, 0x02, 0xBC, 0x02, 0x8A, 0x02, 0x58, 0x02, 0xBC, 0x02, 0xEE, 0x02, 0x58, 0x02, 0xF4, 0x01, 0xC2, 0x01, };
                WriteFunction(offset, newValues);

                offset = 0x6B80B73C;//Pain Killah
                newValues = new byte[] { 0x52, 0x03, 0xBC, 0x02, 0x8A, 0x02, 0xBC, 0x02, 0xBC, 0x02, 0x84, 0x03, 0x8A, 0x02, 0xEE, 0x02, 0x8A, 0x02, };
                WriteFunction(offset, newValues);

                offset = 0x6B80B87C;//Dwayne (Mask)
                newValues = new byte[] { 0xB6, 0x03, 0x84, 0x03, 0x20, 0x03, 0x84, 0x03, 0xEE, 0x02, 0xE8, 0x03, 0x20, 0x03, 0x52, 0x03, 0xEE, 0x02, };
                WriteFunction(offset, newValues);

                offset = 0x6B80B7DC;//Dwayne
                newValues = new byte[] { 0x20, 0x03, 0x84, 0x03, 0xEE, 0x02, 0xD0, 0x02, 0xEE, 0x02, 0x20, 0x03, 0xBC, 0x02, 0xEE, 0x02, 0x8A, 0x02, };
                WriteFunction(offset, newValues);

                offset = 0x6B80B91C;//Shun Ying Lee
                newValues = new byte[] { 0xE2, 0x04, 0x52, 0x03, 0x84, 0x03, 0xB6, 0x03, 0xDC, 0x05, 0x20, 0x03, 0xEE, 0x02, 0x20, 0x03, 0x84, 0x03, };
                WriteFunction(offset, newValues);

                offset = 0x6B80B9BC;//GD 05
                newValues = new byte[] { 0x84, 0x03, 0x52, 0x03, 0xBC, 0x02, 0xEE, 0x02, 0xBC, 0x02, 0x84, 0x03, 0xEE, 0x02, 0xEE, 0x02, 0x58, 0x02, };
                WriteFunction(offset, newValues);

                offset = 0x6B80BA5C;//DR 88
                newValues = new byte[] { 0xEE, 0x02, 0x20, 0x03, 0xEE, 0x02, 0x8A, 0x02, 0xBC, 0x02, 0x20, 0x03, 0x58, 0x02, 0xBC, 0x02, 0x90, 0x01, };
                WriteFunction(offset, newValues);

                offset = 0x6B80BAFC;//FK 71
                newValues = new byte[] { 0x52, 0x03, 0xEE, 0x02, 0x20, 0x03, 0x52, 0x03, 0xEE, 0x02, 0xB6, 0x03, 0x0C, 0x03, 0xBC, 0x02, 0x8A, 0x02, };
                WriteFunction(offset, newValues);

                offset = 0x6B80BB9C;//PT 22
                newValues = new byte[] { 0x20, 0x03, 0x20, 0x03, 0xBC, 0x02, 0xEE, 0x02, 0x20, 0x03, 0x52, 0x03, 0x8A, 0x02, 0xBC, 0x02, 0x26, 0x02, };
                WriteFunction(offset, newValues);

                offset = 0x6B80BC3C;//Bain
                newValues = new byte[] { 0x52, 0x03, 0xEE, 0x02, 0xEE, 0x02, 0x20, 0x03, 0x20, 0x03, 0x52, 0x03, 0xEE, 0x02, 0x20, 0x03, 0xBC, 0x02, };
                WriteFunction(offset, newValues);

                offset = 0x6B80BCDC;//Cooper
                newValues = new byte[] { 0xF4, 0x01, 0xBC, 0x02, 0x58, 0x02, 0x58, 0x02, 0x58, 0x02, 0x26, 0x02, 0xC2, 0x01, 0xF4, 0x01, 0x2C, 0x01, };
                WriteFunction(offset, newValues);

                offset = 0x6B80BD7C;//Anderson
                newValues = new byte[] { 0x20, 0x03, 0x58, 0x02, 0x58, 0x02, 0xBC, 0x02, 0x26, 0x02, 0x26, 0x02, 0x58, 0x02, 0x58, 0x02, 0xC2, 0x01, };
                WriteFunction(offset, newValues);

                offset = 0x6B80BE1C;//Taylor
                newValues = new byte[] { 0xC2, 0x01, 0xF4, 0x01, 0xC2, 0x01, 0x26, 0x02, 0x2C, 0x01, 0xF4, 0x01, 0xF4, 0x01, 0xC2, 0x01, 0x90, 0x01, };
                WriteFunction(offset, newValues);

                offset = 0x6B80BEBC;//Chris
                newValues = new byte[] { 0xB0, 0x04, 0xEE, 0x02, 0xE8, 0x03, 0xB0, 0x04, 0x14, 0x05, 0x4C, 0x04, 0x20, 0x03, 0x84, 0x03, 0xDC, 0x05, };
                WriteFunction(offset, newValues);

                offset = 0x6B80BF5C;//Park
                newValues = new byte[] { 0xAA, 0x05, 0xEE, 0x02, 0x52, 0x03, 0xE8, 0x03, 0xEE, 0x02, 0xB0, 0x04, 0xBC, 0x02, 0xBC, 0x02, 0xE8, 0x03, };
                WriteFunction(offset, newValues);

                offset = 0x6B80BFFC;//Alex
                newValues = new byte[] { 0xB6, 0x03, 0xE8, 0x03, 0x52, 0x03, 0x52, 0x03, 0x84, 0x03, 0xB6, 0x03, 0x84, 0x03, 0xE8, 0x03, 0xBC, 0x02, };
                WriteFunction(offset, newValues);

                offset = 0x6B80C09C;//McKinzie
                newValues = new byte[] { 0x4C, 0x04, 0x14, 0x05, 0xB6, 0x03, 0x4C, 0x04, 0x78, 0x05, 0xB0, 0x04, 0xE8, 0x03, 0x84, 0x03, 0x20, 0x03, };
                WriteFunction(offset, newValues);

                offset = 0x6B80C13C;//Napalm 99
                newValues = new byte[] { 0x14, 0x05, 0x4C, 0x04, 0x52, 0x03, 0xB6, 0x03, 0xB0, 0x04, 0x46, 0x05, 0x14, 0x05, 0x84, 0x03, 0xEE, 0x02, };
                WriteFunction(offset, newValues);

                offset = 0x6B80C1DC;//Golem
                newValues = new byte[] { 0x78, 0x05, 0x78, 0x05, 0xE8, 0x03, 0x46, 0x05, 0x46, 0x05, 0xDC, 0x05, 0x14, 0x05, 0xE8, 0x03, 0x8A, 0x02, };
                WriteFunction(offset, newValues);

                offset = 0x6B80C27C;//Riki
                newValues = new byte[] { 0xBC, 0x02, 0x8A, 0x02, 0x58, 0x02, 0xBC, 0x02, 0xBC, 0x02, 0xEE, 0x02, 0x26, 0x02, 0x58, 0x02, 0xF4, 0x01, };
                WriteFunction(offset, newValues);

                offset = 0x6B80C31C;//Masa
                newValues = new byte[] { 0x2C, 0x01, 0xF4, 0x01, 0x58, 0x02, 0xF4, 0x01, 0x20, 0x03, 0x58, 0x02, 0xF4, 0x01, 0x26, 0x02, 0x5E, 0x01, };
                WriteFunction(offset, newValues);

                offset = 0x6B80C3BC;//Hiro
                newValues = new byte[] { 0x20, 0x03, 0xEE, 0x02, 0x20, 0x03, 0x84, 0x03, 0x52, 0x03, 0x20, 0x03, 0x8A, 0x02, 0xBC, 0x02, 0x26, 0x02, };
                WriteFunction(offset, newValues);

                offset = 0x6B80C45C;//Ryuji
                newValues = new byte[] { 0x20, 0x03, 0x58, 0x02, 0x58, 0x02, 0x8A, 0x02, 0xEE, 0x02, 0x90, 0x01, 0x90, 0x01, 0xF4, 0x01, 0x5E, 0x01, };
                WriteFunction(offset, newValues);

                offset = 0x6B80C4FC;//Ye Wei
                newValues = new byte[] { 0x48, 0x03, 0x58, 0x02, 0x58, 0x02, 0xEE, 0x02, 0x84, 0x03, 0x8A, 0x02, 0xF4, 0x01, 0x8A, 0x02, 0x58, 0x02, };
                WriteFunction(offset, newValues);

                offset = 0x6B80C59C;//Sha Ying
                newValues = new byte[] { 0x20, 0x03, 0x52, 0x03, 0xD0, 0x02, 0x52, 0x03, 0x52, 0x03, 0x20, 0x03, 0x8A, 0x02, 0x20, 0x03, 0x8A, 0x02, };
                WriteFunction(offset, newValues);

                offset = 0x6B80C63C;//Yan Jun
                newValues = new byte[] { 0xBC, 0x02, 0x58, 0x02, 0xBC, 0x02, 0xEE, 0x02, 0xEE, 0x02, 0xBC, 0x02, 0xF4, 0x01, 0x8A, 0x02, 0x90, 0x01, };
                WriteFunction(offset, newValues);

                offset = 0x6B80C6DC;//Shinkai
                newValues = new byte[] { 0x14, 0x05, 0x4C, 0x04, 0x4C, 0x04, 0xDC, 0x05, 0xE2, 0x04, 0xB0, 0x04, 0xE8, 0x03, 0x4C, 0x04, 0x84, 0x03, };
                WriteFunction(offset, newValues);

                offset = 0x6B80C77C;//Lin Fong Lee
                newValues = new byte[] { 0x84, 0x03, 0x20, 0x03, 0x52, 0x03, 0xE8, 0x03, 0xE8, 0x03, 0xB6, 0x03, 0x20, 0x03, 0x52, 0x03, 0x20, 0x03, };
                WriteFunction(offset, newValues);

                offset = 0x6B80C81C;//Bordin
                newValues = new byte[] { 0x8A, 0x02, 0x58, 0x02, 0xEE, 0x02, 0x58, 0x02, 0x26, 0x02, 0xBC, 0x02, 0x26, 0x02, 0xEE, 0x02, 0x58, 0x02, };
                WriteFunction(offset, newValues);

                offset = 0x6B80C8BC;//Lilian
                newValues = new byte[] { 0xB0, 0x04, 0x20, 0x03, 0xE8, 0x03, 0x20, 0x03, 0x1A, 0x04, 0x84, 0x03, 0xEE, 0x02, 0x52, 0x03, 0x46, 0x05, };
                WriteFunction(offset, newValues);

                offset = 0x6B80C95C;//Kelly
                newValues = new byte[] { 0x7E, 0x04, 0xBC, 0x02, 0x4C, 0x04, 0x48, 0x03, 0xEE, 0x02, 0x84, 0x03, 0xEE, 0x02, 0x20, 0x03, 0x78, 0x05, };
                WriteFunction(offset, newValues);

                offset = 0x6B80C9FC;//Vera
                newValues = new byte[] { 0x20, 0x03, 0x14, 0x05, 0xB6, 0x03, 0xB6, 0x03, 0xBC, 0x02, 0x4C, 0x04, 0x84, 0x03, 0xEE, 0x02, 0x52, 0x03, };
                WriteFunction(offset, newValues);

                offset = 0x6B80CA9C;//Paul
                newValues = new byte[] { 0xE8, 0x03, 0xB6, 0x03, 0x84, 0x03, 0xE8, 0x03, 0xBC, 0x02, 0xB6, 0x03, 0x52, 0x03, 0x52, 0x03, 0x52, 0x03, };
                WriteFunction(offset, newValues);

                offset = 0x6B80CB3C;//Law
                newValues = new byte[] { 0xE8, 0x03, 0x84, 0x03, 0x52, 0x03, 0xE8, 0x03, 0x20, 0x03, 0x52, 0x03, 0x20, 0x03, 0x84, 0x03, 0x84, 0x03, };
                WriteFunction(offset, newValues);

                offset = 0x6B80D0DC;//KG
                newValues = new byte[] { 0x52, 0x03, 0xBC, 0x02, 0xBC, 0x02, 0x20, 0x03, 0xEE, 0x02, 0x84, 0x03, 0xBC, 0x02, 0x20, 0x03, 0xEE, 0x02, };
                WriteFunction(offset, newValues);

                offset = 0x6B80D17C;//Bain (Mask)
                newValues = new byte[] { 0x8A, 0x02, 0xBC, 0x02, 0xF4, 0x01, 0x8A, 0x02, 0x26, 0x02, 0x20, 0x03, 0xBC, 0x02, 0xBC, 0x02, 0xF4, 0x01, };
                WriteFunction(offset, newValues);

                offset = 0x6B80D21C;//Cooper (Mask)
                newValues = new byte[] { 0x52, 0x03, 0x84, 0x03, 0x84, 0x03, 0x52, 0x03, 0x20, 0x03, 0x4C, 0x04, 0xEE, 0x02, 0x20, 0x03, 0xB6, 0x03, };
                WriteFunction(offset, newValues);
            }
            //if (SettingsClass.StatsChanged) //custom 2
            //{
            //    uint offset = 0x6B80A5BC;//Brad Hawk (first)
            //    byte[] newValues = new byte[] { 0x26, 0x02, 0xC2, 0x01, 0xC2, 0x01, 0xC2, 0x01, 0x90, 0x01, 0xC2, 0x01, 0x90, 0x01, 0xC2, 0x01, 0x5E, 0x01, };
            //    WriteFunction(offset, newValues);

            //    offset = 0x6B80A79C;//Glen
            //    newValues = new byte[] { 0xF4, 0x01, 0x90, 0x01, 0x5E, 0x01, 0x2C, 0x01, 0x20, 0x03, 0x5E, 0x01, 0x5E, 0x01, 0x5E, 0x01, 0xC8, 0x00, };
            //    WriteFunction(offset, newValues);

            //    offset = 0x6B80A83C;//Torque
            //    newValues = new byte[] { 0xB6, 0x03, 0xEE, 0x02, 0x20, 0x03, 0xBC, 0x02, 0x84, 0x03, 0xA8, 0x02, 0xF4, 0x01, 0x20, 0x03, 0x58, 0x02, };
            //    WriteFunction(offset, newValues);

            //    offset = 0x6B80A8DC;//Rod
            //    newValues = new byte[] { 0x20, 0x03, 0xE8, 0x03, 0x20, 0x03, 0x84, 0x03, 0xE8, 0x03, 0x20, 0x03, 0x84, 0x03, 0xB6, 0x03, 0x20, 0x03, };
            //    WriteFunction(offset, newValues);

            //    offset = 0x6B80A97C;//Seth
            //    newValues = new byte[] { 0x84, 0x03, 0x84, 0x03, 0xB6, 0x03, 0xB6, 0x03, 0xE8, 0x03, 0xD4, 0x03, 0x84, 0x03, 0xC0, 0x03, 0x20, 0x03, };
            //    WriteFunction(offset, newValues);

            //    offset = 0x6B80AA1C;//Nas-Tiii
            //    newValues = new byte[] { 0x84, 0x03, 0xB6, 0x03, 0xCA, 0x03, 0xE8, 0x03, 0xE8, 0x03, 0x84, 0x03, 0x7A, 0x03, 0x84, 0x03, 0x84, 0x03, };
            //    WriteFunction(offset, newValues);

            //    offset = 0x6B80AABC;//Em Cee
            //    newValues = new byte[] { 0x84, 0x03, 0xB6, 0x03, 0xCA, 0x03, 0xE8, 0x03, 0xE8, 0x03, 0x84, 0x03, 0x7A, 0x03, 0x84, 0x03, 0x84, 0x03, };
            //    WriteFunction(offset, newValues);

            //    offset = 0x6B80AB5C;//Real Deal
            //    newValues = new byte[] { 0x84, 0x03, 0xB6, 0x03, 0xCA, 0x03, 0xE8, 0x03, 0xE8, 0x03, 0x84, 0x03, 0x7A, 0x03, 0x84, 0x03, 0x84, 0x03, };
            //    WriteFunction(offset, newValues);

            //    offset = 0x6B80ABFC;//Ty
            //    newValues = new byte[] { 0xB6, 0x03, 0xB6, 0x03, 0xDE, 0x03, 0xE8, 0x03, 0xE8, 0x03, 0xB6, 0x03, 0xC0, 0x03, 0xCA, 0x03, 0x84, 0x03, };
            //    WriteFunction(offset, newValues);

            //    offset = 0x6B80AC9C;//Miguel
            //    newValues = new byte[] { 0x84, 0x03, 0x20, 0x03, 0x7A, 0x03, 0x84, 0x03, 0xE8, 0x03, 0x84, 0x03, 0x84, 0x03, 0xD4, 0x03, 0x52, 0x03, };
            //    WriteFunction(offset, newValues);

            //    offset = 0x6B80AD3C;//Ramon
            //    newValues = new byte[] { 0x7A, 0x03, 0x52, 0x03, 0x20, 0x03, 0x84, 0x03, 0xE8, 0x03, 0x84, 0x03, 0x84, 0x03, 0x84, 0x03, 0x84, 0x03, };
            //    WriteFunction(offset, newValues);

            //    offset = 0x6B80ADDC;//Jose
            //    newValues = new byte[] { 0x20, 0x03, 0x52, 0x03, 0x20, 0x03, 0x84, 0x03, 0xE8, 0x03, 0x84, 0x03, 0xB6, 0x03, 0x84, 0x03, 0x7A, 0x03, };
            //    WriteFunction(offset, newValues);

            //    offset = 0x6B80AE7C;//Emilio
            //    newValues = new byte[] { 0x84, 0x03, 0x84, 0x03, 0xD4, 0x03, 0x84, 0x03, 0xE8, 0x03, 0xD4, 0x03, 0xB6, 0x03, 0xD4, 0x03, 0x5C, 0x03, };
            //    WriteFunction(offset, newValues);

            //    offset = 0x6B80AF1C;//Kadonashi
            //    newValues = new byte[] { 0xB6, 0x03, 0x8A, 0x02, 0xF4, 0x01, 0xF4, 0x01, 0x52, 0x03, 0xF4, 0x01, 0x26, 0x02, 0xC2, 0x01, 0x2C, 0x01, };
            //    WriteFunction(offset, newValues);

            //    offset = 0x6B80AFBC;//Reggie
            //    newValues = new byte[] { 0x70, 0x03, 0x26, 0x02, 0xEE, 0x02, 0x8A, 0x02, 0xE8, 0x03, 0x84, 0x03, 0xD4, 0x03, 0x20, 0x03, 0xBC, 0x02, };
            //    WriteFunction(offset, newValues);

            //    offset = 0x6B80B05C;//Zack
            //    newValues = new byte[] { 0xEE, 0x02, 0x34, 0x03, 0xEE, 0x02, 0x44, 0x02, 0xE8, 0x03, 0x84, 0x03, 0xD4, 0x03, 0x20, 0x03, 0x8A, 0x02, };
            //    WriteFunction(offset, newValues);

            //    offset = 0x6B80B0FC;//Colin
            //    newValues = new byte[] { 0xF8, 0x02, 0x58, 0x02, 0xEE, 0x02, 0xD0, 0x02, 0xE8, 0x03, 0x84, 0x03, 0xD4, 0x03, 0x20, 0x03, 0x58, 0x02, };
            //    WriteFunction(offset, newValues);

            //    offset = 0x6B80B19C;//Jake
            //    newValues = new byte[] { 0x2C, 0x01, 0x2C, 0x01, 0x2C, 0x01, 0x2C, 0x01, 0x90, 0x01, 0xA9, 0x01, 0x90, 0x01, 0x90, 0x01, 0x5E, 0x01, };
            //    WriteFunction(offset, newValues);

            //    offset = 0x6B80B23C;//Tong Yoon
            //    newValues = new byte[] { 0x2C, 0x01, 0xC8, 0x00, 0x2C, 0x01, 0x2C, 0x01, 0x0A, 0x00, 0x90, 0x01, 0xF4, 0x01, 0x2C, 0x01, 0xE8, 0x03, };
            //    WriteFunction(offset, newValues);

            //    offset = 0x6B80B2DC;//Grimm
            //    newValues = new byte[] { 0xA9, 0x01, 0x90, 0x01, 0xC2, 0x01, 0x5E, 0x01, 0x2C, 0x01, 0x90, 0x01, 0x90, 0x01, 0x90, 0x01, 0xFA, 0x00, };
            //    WriteFunction(offset, newValues);

            //    offset = 0x6B80B37C;//BK
            //    newValues = new byte[] { 0x34, 0x03, 0x26, 0x02, 0xF4, 0x01, 0x84, 0x03, 0xF4, 0x01, 0x84, 0x03, 0xDE, 0x03, 0xE8, 0x03, 0xBC, 0x02, };
            //    WriteFunction(offset, newValues);

            //    offset = 0x6B80B41C;//Grave Digga'
            //    newValues = new byte[] { 0xBC, 0x02, 0x26, 0x02, 0x58, 0x02, 0x84, 0x03, 0xBC, 0x02, 0x20, 0x03, 0x84, 0x03, 0xE8, 0x03, 0xBC, 0x02, };
            //    WriteFunction(offset, newValues);

            //    offset = 0x6B80B4BC;//Bones
            //    newValues = new byte[] { 0xBC, 0x02, 0x58, 0x02, 0x48, 0x03, 0x84, 0x03, 0xF4, 0x01, 0x20, 0x03, 0x84, 0x03, 0xE8, 0x03, 0xBC, 0x02, };
            //    WriteFunction(offset, newValues);

            //    offset = 0x6B80B55C;//Booma
            //    newValues = new byte[] { 0xE4, 0x02, 0xF8, 0x02, 0x20, 0x03, 0x84, 0x03, 0x26, 0x02, 0x20, 0x03, 0x84, 0x03, 0xE8, 0x03, 0xBC, 0x02, };
            //    WriteFunction(offset, newValues);

            //    offset = 0x6B80B5FC;//Busta
            //    newValues = new byte[] { 0x84, 0x03, 0x84, 0x03, 0x66, 0x03, 0x20, 0x03, 0xF8, 0x02, 0x84, 0x03, 0x20, 0x03, 0xBC, 0x02, 0x58, 0x02, };
            //    WriteFunction(offset, newValues);

            //    offset = 0x6B80B69C;//Spider
            //    newValues = new byte[] { 0x84, 0x03, 0x7A, 0x03, 0x5C, 0x03, 0x20, 0x03, 0xA8, 0x02, 0x84, 0x03, 0x20, 0x03, 0xBC, 0x02, 0x58, 0x02, };
            //    WriteFunction(offset, newValues);

            //    offset = 0x6B80B73C;//Pain Killah
            //    newValues = new byte[] { 0x84, 0x03, 0xE8, 0x03, 0x7A, 0x03, 0x66, 0x03, 0xD0, 0x02, 0x84, 0x03, 0x20, 0x03, 0xBC, 0x02, 0x58, 0x02, };
            //    WriteFunction(offset, newValues);

            //    offset = 0x6B80B87C;//Dwayne (Mask)
            //    newValues = new byte[] { 0x5E, 0x01, 0x5E, 0x01, 0x5E, 0x01, 0x5E, 0x01, 0x90, 0x01, 0x77, 0x01, 0x5E, 0x01, 0x5E, 0x01, 0x2C, 0x01, };
            //    WriteFunction(offset, newValues);

            //    offset = 0x6B80B7DC;//Dwayne
            //    newValues = new byte[] { 0x5E, 0x01, 0x5E, 0x01, 0x5E, 0x01, 0x5E, 0x01, 0x90, 0x01, 0x77, 0x01, 0x5E, 0x01, 0x5E, 0x01, 0x2C, 0x01, };
            //    WriteFunction(offset, newValues);

            //    offset = 0x6B80B91C;//Shun Ying Lee
            //    newValues = new byte[] { 0xE4, 0x02, 0x84, 0x03, 0x66, 0x03, 0xE8, 0x03, 0xE8, 0x03, 0x84, 0x03, 0x20, 0x03, 0x84, 0x03, 0xE8, 0x03, };
            //    WriteFunction(offset, newValues);

            //    offset = 0x6B80B9BC;//GD 05
            //    newValues = new byte[] { 0x34, 0x03, 0xBC, 0x02, 0x58, 0x02, 0x58, 0x02, 0x8A, 0x02, 0x0C, 0x03, 0x1C, 0x02, 0xEE, 0x02, 0x90, 0x01, };
            //    WriteFunction(offset, newValues);

            //    offset = 0x6B80BA5C;//DR 88
            //    newValues = new byte[] { 0xBC, 0x02, 0x48, 0x03, 0xBC, 0x02, 0x44, 0x02, 0xA8, 0x02, 0xBC, 0x02, 0x90, 0x01, 0xD0, 0x02, 0x58, 0x02, };
            //    WriteFunction(offset, newValues);

            //    offset = 0x6B80BAFC;//FK 71
            //    newValues = new byte[] { 0xBC, 0x02, 0xBC, 0x02, 0xEE, 0x02, 0x16, 0x03, 0x8A, 0x02, 0xA8, 0x02, 0x2C, 0x01, 0x58, 0x02, 0x2C, 0x01, };
            //    WriteFunction(offset, newValues);

            //    offset = 0x6B80BB9C;//PT 22
            //    newValues = new byte[] { 0xEE, 0x02, 0xD0, 0x02, 0xB2, 0x02, 0xB2, 0x02, 0x0C, 0x03, 0xE4, 0x02, 0xF4, 0x01, 0xBC, 0x02, 0x2C, 0x01, };
            //    WriteFunction(offset, newValues);

            //    offset = 0x6B80BC3C;//Bain
            //    newValues = new byte[] { 0x16, 0x03, 0x8A, 0x02, 0xE4, 0x02, 0xA8, 0x02, 0xF8, 0x02, 0x58, 0x02, 0xC2, 0x01, 0x26, 0x02, 0x58, 0x02, };
            //    WriteFunction(offset, newValues);

            //    offset = 0x6B80BCDC;//Cooper
            //    newValues = new byte[] { 0xA8, 0x02, 0x20, 0x03, 0xF8, 0x02, 0xA8, 0x02, 0xD0, 0x02, 0xA8, 0x02, 0xF4, 0x01, 0x58, 0x02, 0x2C, 0x01, };
            //    WriteFunction(offset, newValues);

            //    offset = 0x6B80BD7C;//Anderson
            //    newValues = new byte[] { 0x9E, 0x02, 0xD0, 0x02, 0x70, 0x03, 0xBC, 0x02, 0xBC, 0x02, 0x58, 0x02, 0xF4, 0x01, 0x58, 0x02, 0x90, 0x01, };
            //    WriteFunction(offset, newValues);

            //    offset = 0x6B80BE1C;//Taylor
            //    newValues = new byte[] { 0xB2, 0x02, 0xBC, 0x02, 0xEE, 0x02, 0xA8, 0x02, 0x5C, 0x03, 0xF4, 0x01, 0x90, 0x01, 0xC2, 0x01, 0xC2, 0x01, };
            //    WriteFunction(offset, newValues);

            //    offset = 0x6B80BEBC;//Chris
            //    newValues = new byte[] { 0xDB, 0x01, 0x5E, 0x01, 0x5E, 0x01, 0x90, 0x01, 0x90, 0x01, 0xF4, 0x01, 0x26, 0x02, 0x26, 0x02, 0xE8, 0x03, };
            //    WriteFunction(offset, newValues);

            //    offset = 0x6B80BF5C;//Park
            //    newValues = new byte[] { 0x5E, 0x01, 0xFA, 0x00, 0x40, 0x01, 0x2C, 0x01, 0xBC, 0x02, 0xA8, 0x02, 0x8A, 0x02, 0x26, 0x02, 0xE8, 0x03, };
            //    WriteFunction(offset, newValues);

            //    offset = 0x6B80BFFC;//Alex
            //    newValues = new byte[] { 0xC8, 0x00, 0x2C, 0x01, 0x2C, 0x01, 0xFA, 0x00, 0xE8, 0x03, 0x2C, 0x01, 0x2C, 0x01, 0xFA, 0x00, 0x2C, 0x01, };
            //    WriteFunction(offset, newValues);

            //    offset = 0x6B80C09C;//McKinzie
            //    newValues = new byte[] { 0xFA, 0x00, 0x2C, 0x01, 0xF4, 0x01, 0xFA, 0x00, 0xE8, 0x03, 0x90, 0x01, 0x2C, 0x01, 0x2C, 0x01, 0xFA, 0x00, };
            //    WriteFunction(offset, newValues);

            //    offset = 0x6B80C13C;//Napalm 99
            //    newValues = new byte[] { 0x5E, 0x01, 0x2C, 0x01, 0x5E, 0x01, 0xFA, 0x00, 0xC8, 0x00, 0xC8, 0x00, 0x2C, 0x01, 0x2C, 0x01, 0xC8, 0x00, };
            //    WriteFunction(offset, newValues);

            //    offset = 0x6B80C1DC;//Golem
            //    newValues = new byte[] { 0xF4, 0x01, 0xF4, 0x01, 0xF4, 0x01, 0xC2, 0x01, 0xDB, 0x01, 0xF4, 0x01, 0xF4, 0x01, 0xF4, 0x01, 0xFA, 0x00, };
            //    WriteFunction(offset, newValues);

            //    offset = 0x6B80C27C;//Riki
            //    newValues = new byte[] { 0x52, 0x03, 0x8A, 0x02, 0x8A, 0x02, 0xD0, 0x02, 0xE8, 0x03, 0x84, 0x03, 0x84, 0x03, 0xCA, 0x03, 0x20, 0x03, };
            //    WriteFunction(offset, newValues);

            //    offset = 0x6B80C31C;//Masa
            //    newValues = new byte[] { 0xA8, 0x02, 0x34, 0x03, 0xD0, 0x02, 0xA8, 0x02, 0xE8, 0x03, 0x84, 0x03, 0x84, 0x03, 0xCA, 0x03, 0x20, 0x03, };
            //    WriteFunction(offset, newValues);

            //    offset = 0x6B80C3BC;//Hiro
            //    newValues = new byte[] { 0xB2, 0x02, 0xB2, 0x02, 0x20, 0x03, 0x34, 0x03, 0xE8, 0x03, 0x84, 0x03, 0x84, 0x03, 0xCA, 0x03, 0x20, 0x03, };
            //    WriteFunction(offset, newValues);

            //    offset = 0x6B80C45C;//Ryuji
            //    newValues = new byte[] { 0xEE, 0x02, 0xBC, 0x02, 0xDA, 0x02, 0xEE, 0x02, 0xE8, 0x03, 0x84, 0x03, 0x84, 0x03, 0xCA, 0x03, 0x20, 0x03, };
            //    WriteFunction(offset, newValues);

            //    offset = 0x6B80C4FC;//Ye Wei
            //    newValues = new byte[] { 0x48, 0x03, 0x94, 0x02, 0x94, 0x02, 0xBC, 0x02, 0x7A, 0x03, 0x84, 0x03, 0x84, 0x03, 0xCA, 0x03, 0x20, 0x03, };
            //    WriteFunction(offset, newValues);

            //    offset = 0x6B80C59C;//Sha Ying
            //    newValues = new byte[] { 0xBC, 0x02, 0x52, 0x03, 0xD0, 0x02, 0xA8, 0x02, 0x52, 0x03, 0x84, 0x03, 0x84, 0x03, 0xCA, 0x03, 0x20, 0x03, };
            //    WriteFunction(offset, newValues);

            //    offset = 0x6B80C63C;//Yan Jun
            //    newValues = new byte[] { 0xD0, 0x02, 0xBC, 0x02, 0x0C, 0x03, 0x70, 0x03, 0x7A, 0x03, 0x84, 0x03, 0x84, 0x03, 0xCA, 0x03, 0x20, 0x03, };
            //    WriteFunction(offset, newValues);

            //    offset = 0x6B80C6DC;//Shinkai
            //    newValues = new byte[] { 0x2C, 0x01, 0x2C, 0x01, 0xC8, 0x00, 0x2C, 0x01, 0x0A, 0x00, 0xF4, 0x01, 0x2C, 0x01, 0x2C, 0x01, 0xC8, 0x00, };
            //    WriteFunction(offset, newValues);

            //    offset = 0x6B80C77C;//Lin Fong Lee
            //    newValues = new byte[] { 0xC2, 0x01, 0x90, 0x01, 0xF4, 0x01, 0x2C, 0x01, 0x0A, 0x00, 0xF4, 0x01, 0xF4, 0x01, 0xF4, 0x01, 0x2C, 0x01, };
            //    WriteFunction(offset, newValues);

            //    offset = 0x6B80C81C;//Bordin
            //    newValues = new byte[] { 0xE8, 0x03, 0xE8, 0x03, 0xE8, 0x03, 0xE8, 0x03, 0xE8, 0x03, 0xE8, 0x03, 0xE8, 0x03, 0xE8, 0x03, 0xE8, 0x03, };
            //    WriteFunction(offset, newValues);

            //    offset = 0x6B80C8BC;//Lilian
            //    newValues = new byte[] { 0xD0, 0x02, 0x0C, 0x03, 0xEE, 0x02, 0x52, 0x03, 0xE8, 0x03, 0x20, 0x03, 0x84, 0x03, 0x84, 0x03, 0xE8, 0x03, };
            //    WriteFunction(offset, newValues);

            //    offset = 0x6B80C95C;//Kelly
            //    newValues = new byte[] { 0x20, 0x03, 0x6C, 0x02, 0xEE, 0x02, 0x48, 0x03, 0xE8, 0x03, 0x20, 0x03, 0x84, 0x03, 0x84, 0x03, 0xE8, 0x03, };
            //    WriteFunction(offset, newValues);

            //    offset = 0x6B80C9FC;//Vera
            //    newValues = new byte[] { 0x6C, 0x02, 0x8E, 0x03, 0xA8, 0x02, 0xD0, 0x02, 0xE8, 0x03, 0x20, 0x03, 0x84, 0x03, 0x84, 0x03, 0xE8, 0x03, };
            //    WriteFunction(offset, newValues);

            //    offset = 0x6B80CA9C;//Paul
            //    newValues = new byte[] { 0xF4, 0x01, 0x90, 0x01, 0x2C, 0x01, 0x2C, 0x01, 0x2C, 0x01, 0xFA, 0x00, 0xFA, 0x00, 0xC8, 0x00, 0xC8, 0x00, };
            //    WriteFunction(offset, newValues);

            //    offset = 0x6B80CB3C;//Law
            //    newValues = new byte[] { 0x90, 0x01, 0x2C, 0x01, 0x2C, 0x01, 0xF4, 0x01, 0x90, 0x01, 0x2C, 0x01, 0xFA, 0x00, 0x2C, 0x01, 0x2C, 0x01, };
            //    WriteFunction(offset, newValues);

            //    offset = 0x6B80D0DC;//KG
            //    newValues = new byte[] { 0xE4, 0x02, 0x6C, 0x02, 0x58, 0x02, 0xD0, 0x02, 0x6C, 0x02, 0x84, 0x03, 0x52, 0x03, 0x84, 0x03, 0xBC, 0x02, };
            //    WriteFunction(offset, newValues);

            //    offset = 0x6B80D17C;//Bain (Mask)
            //    newValues = new byte[] { 0x16, 0x03, 0x8A, 0x02, 0xE4, 0x02, 0xA8, 0x02, 0xF8, 0x02, 0x58, 0x02, 0xC2, 0x01, 0x26, 0x02, 0x58, 0x02, };
            //    WriteFunction(offset, newValues);

            //    offset = 0x6B80D21C;//Cooper (Mask)
            //    newValues = new byte[] { 0xA8, 0x02, 0x20, 0x03, 0xF8, 0x02, 0xA8, 0x02, 0xD0, 0x02, 0xA8, 0x02, 0xF4, 0x01, 0x58, 0x02, 0x2C, 0x01, };
            //    WriteFunction(offset, newValues);
            //}
            else //original
            {
                uint offset = 0x6B80A5BC;//Brad Hawk (First)
                byte[] newValues = new byte[] { 0xB6, 0x03, 0x52, 0x03, 0x52, 0x03, 0x84, 0x03, 0x20, 0x03, 0x84, 0x03, 0x20, 0x03, 0x84, 0x03, 0xBC, 0x02, };
                WriteFunction(offset, newValues);

                offset = 0x6B80A79C;//Glen
                newValues = new byte[] { 0xEE, 0x02, 0x84, 0x03, 0xBC, 0x02, 0x58, 0x02, 0x20, 0x03, 0xBC, 0x02, 0xBC, 0x02, 0xBC, 0x02, 0xF4, 0x01, };
                WriteFunction(offset, newValues);

                offset = 0x6B80A83C;//Torque
                newValues = new byte[] { 0x0C, 0x03, 0x58, 0x02, 0xF4, 0x01, 0xC2, 0x01, 0x26, 0x02, 0xA8, 0x02, 0x5E, 0x01, 0xC2, 0x01, 0x2C, 0x01, };
                WriteFunction(offset, newValues);

                offset = 0x6B80A8DC;//Rod
                newValues = new byte[] { 0x58, 0x02, 0xF4, 0x01, 0x58, 0x02, 0x8A, 0x02, 0x52, 0x03, 0x90, 0x01, 0xC8, 0x00, 0x2C, 0x01, 0xC8, 0x00, };
                WriteFunction(offset, newValues);

                offset = 0x6B80A97C;//Seth
                newValues = new byte[] { 0xA8, 0x02, 0x20, 0x03, 0xBC, 0x02, 0xF4, 0x01, 0xF4, 0x01, 0x0C, 0x03, 0xF4, 0x01, 0xA8, 0x02, 0x90, 0x01, };
                WriteFunction(offset, newValues);

                offset = 0x6B80AA1C;//Nas-Tiii
                newValues = new byte[] { 0xE4, 0x02, 0x26, 0x02, 0xF4, 0x01, 0xF4, 0x01, 0x26, 0x02, 0xF4, 0x01, 0x2C, 0x01, 0x5E, 0x01, 0x2C, 0x01, };
                WriteFunction(offset, newValues);

                offset = 0x6B80AABC;//Em Cee
                newValues = new byte[] { 0x8A, 0x02, 0x58, 0x02, 0xA8, 0x02, 0x8A, 0x02, 0xBC, 0x02, 0x90, 0x01, 0xC8, 0x00, 0xFA, 0x00, 0xC8, 0x00, };
                WriteFunction(offset, newValues);

                offset = 0x6B80AB5C;//Real Deal
                newValues = new byte[] { 0x58, 0x02, 0xE4, 0x02, 0x58, 0x02, 0xF4, 0x01, 0xF4, 0x01, 0x8A, 0x02, 0x2C, 0x01, 0xC2, 0x01, 0xC8, 0x00, };
                WriteFunction(offset, newValues);

                offset = 0x6B80ABFC;//Ty
                newValues = new byte[] { 0x58, 0x02, 0x26, 0x02, 0x58, 0x02, 0x26, 0x02, 0x0C, 0x03, 0xF4, 0x01, 0xC8, 0x00, 0x5E, 0x01, 0xC8, 0x00, };
                WriteFunction(offset, newValues);

                offset = 0x6B80AC9C;//Miguel
                newValues = new byte[] { 0xF8, 0x02, 0x80, 0x02, 0x76, 0x02, 0x8A, 0x02, 0xA8, 0x02, 0x6C, 0x02, 0x2C, 0x01, 0xC2, 0x01, 0x2C, 0x01, };
                WriteFunction(offset, newValues);

                offset = 0x6B80AD3C;//Ramon
                newValues = new byte[] { 0xA8, 0x02, 0x44, 0x02, 0x6C, 0x02, 0xD0, 0x02, 0x58, 0x02, 0x90, 0x01, 0xFA, 0x00, 0x5E, 0x01, 0xC8, 0x00, };
                WriteFunction(offset, newValues);

                offset = 0x6B80ADDC;//Jose
                newValues = new byte[] { 0x58, 0x02, 0x08, 0x02, 0x12, 0x02, 0x1C, 0x02, 0x02, 0x03, 0x26, 0x02, 0x2C, 0x01, 0xF4, 0x01, 0xC8, 0x00, };
                WriteFunction(offset, newValues);

                offset = 0x6B80AE7C;//Emilio
                newValues = new byte[] { 0x58, 0x02, 0xE4, 0x02, 0xF4, 0x01, 0xF4, 0x01, 0xF4, 0x01, 0x58, 0x02, 0x2C, 0x01, 0xF4, 0x01, 0x90, 0x01, };
                WriteFunction(offset, newValues);

                offset = 0x6B80AF1C;//Kadonashi
                newValues = new byte[] { 0xB6, 0x03, 0x8A, 0x02, 0x20, 0x03, 0xBC, 0x02, 0x52, 0x03, 0x58, 0x02, 0xBC, 0x02, 0xBC, 0x02, 0x20, 0x03, };
                WriteFunction(offset, newValues);

                offset = 0x6B80AFBC;//Reggie
                newValues = new byte[] { 0x70, 0x03, 0x26, 0x02, 0xEE, 0x02, 0x8A, 0x02, 0x26, 0x02, 0x26, 0x02, 0x5E, 0x01, 0x26, 0x02, 0xBC, 0x02, };
                WriteFunction(offset, newValues);

                offset = 0x6B80B05C;//Zack
                newValues = new byte[] { 0xEE, 0x02, 0x34, 0x03, 0xF4, 0x01, 0x44, 0x02, 0xF4, 0x01, 0x58, 0x02, 0xE0, 0x01, 0x44, 0x02, 0x8A, 0x02, };
                WriteFunction(offset, newValues);

                offset = 0x6B80B0FC;//Colin
                newValues = new byte[] { 0xF8, 0x02, 0x58, 0x02, 0x44, 0x02, 0xD0, 0x02, 0xF4, 0x01, 0xA8, 0x02, 0xC2, 0x01, 0x26, 0x02, 0x58, 0x02, };
                WriteFunction(offset, newValues);

                offset = 0x6B80B19C;//Jake
                newValues = new byte[] { 0x20, 0x03, 0xB6, 0x03, 0xEE, 0x02, 0xBC, 0x02, 0xF4, 0x01, 0x52, 0x03, 0x20, 0x03, 0x20, 0x03, 0xBC, 0x02, };
                WriteFunction(offset, newValues);

                offset = 0x6B80B23C;//Tong Yoon
                newValues = new byte[] { 0x84, 0x03, 0xBC, 0x02, 0x84, 0x03, 0x58, 0x02, 0x2C, 0x01, 0xBC, 0x02, 0xBC, 0x02, 0x20, 0x03, 0xE8, 0x03, };
                WriteFunction(offset, newValues);

                offset = 0x6B80B2DC;//Grimm
                newValues = new byte[] { 0x52, 0x03, 0x20, 0x03, 0x84, 0x03, 0xBC, 0x02, 0x58, 0x02, 0x20, 0x03, 0x20, 0x03, 0x20, 0x03, 0xF4, 0x01, };
                WriteFunction(offset, newValues);

                offset = 0x6B80B37C;//BK
                newValues = new byte[] { 0x34, 0x03, 0x26, 0x02, 0xF4, 0x01, 0xBC, 0x02, 0xF4, 0x01, 0x58, 0x02, 0x2C, 0x01, 0x58, 0x02, 0x2C, 0x01, };
                WriteFunction(offset, newValues);

                offset = 0x6B80B41C;//Grave Digga'
                newValues = new byte[] { 0xBC, 0x02, 0x26, 0x02, 0x58, 0x02, 0x34, 0x03, 0xBC, 0x02, 0x90, 0x01, 0x5E, 0x01, 0x58, 0x02, 0xC8, 0x00, };
                WriteFunction(offset, newValues);

                offset = 0x6B80B4BC;//Bones
                newValues = new byte[] { 0xBC, 0x02, 0x58, 0x02, 0x48, 0x03, 0x58, 0x02, 0xF4, 0x01, 0x26, 0x02, 0x2C, 0x01, 0x26, 0x02, 0xFA, 0x00, };
                WriteFunction(offset, newValues);

                offset = 0x6B80B55C;//Booma
                newValues = new byte[] { 0xE4, 0x02, 0xF8, 0x02, 0x8A, 0x02, 0x58, 0x02, 0x26, 0x02, 0x8A, 0x02, 0x08, 0x02, 0xBC, 0x02, 0x90, 0x01, };
                WriteFunction(offset, newValues);

                offset = 0x6B80B5FC;//Busta
                newValues = new byte[] { 0x0C, 0x03, 0x30, 0x02, 0x44, 0x02, 0xD0, 0x02, 0xF8, 0x02, 0x58, 0x02, 0xFA, 0x00, 0x90, 0x01, 0xC8, 0x00, };
                WriteFunction(offset, newValues);

                offset = 0x6B80B69C;//Spider
                newValues = new byte[] { 0xA8, 0x02, 0xE4, 0x02, 0xD0, 0x02, 0xF4, 0x01, 0xA8, 0x02, 0x8A, 0x02, 0x5E, 0x01, 0x90, 0x01, 0xC8, 0x00, };
                WriteFunction(offset, newValues);

                offset = 0x6B80B73C;//Pain Killah
                newValues = new byte[] { 0x8A, 0x02, 0x1C, 0x02, 0x26, 0x02, 0x08, 0x02, 0xD0, 0x02, 0xBC, 0x02, 0x90, 0x01, 0x58, 0x02, 0x5E, 0x01, };
                WriteFunction(offset, newValues);

                offset = 0x6B80B87C;//Dwayne (Mask)
                newValues = new byte[] { 0xEE, 0x02, 0xEE, 0x02, 0xBC, 0x02, 0xBC, 0x02, 0x20, 0x03, 0xEE, 0x02, 0xBC, 0x02, 0xBC, 0x02, 0x58, 0x02, };
                WriteFunction(offset, newValues);

                offset = 0x6B80B7DC;//Dwayne
                newValues = new byte[] { 0xEE, 0x02, 0xEE, 0x02, 0xBC, 0x02, 0xBC, 0x02, 0x20, 0x03, 0xEE, 0x02, 0xBC, 0x02, 0xBC, 0x02, 0x58, 0x02, };
                WriteFunction(offset, newValues);

                offset = 0x6B80B91C;//Shun Ying Lee
                newValues = new byte[] { 0xE4, 0x02, 0xA8, 0x02, 0x66, 0x03, 0x70, 0x03, 0xB6, 0x03, 0x58, 0x02, 0x5E, 0x01, 0x26, 0x02, 0xC2, 0x01, };
                WriteFunction(offset, newValues);

                offset = 0x6B80B9BC;//GD 05
                newValues = new byte[] { 0x34, 0x03, 0xBC, 0x02, 0x58, 0x02, 0x58, 0x02, 0x8A, 0x02, 0x0C, 0x03, 0x1C, 0x02, 0xEE, 0x02, 0x90, 0x01, };
                WriteFunction(offset, newValues);

                offset = 0x6B80BA5C;//DR 88
                newValues = new byte[] { 0xBC, 0x02, 0x48, 0x03, 0xBC, 0x02, 0x44, 0x02, 0xA8, 0x02, 0xBC, 0x02, 0x90, 0x01, 0xD0, 0x02, 0x58, 0x02, };
                WriteFunction(offset, newValues);

                offset = 0x6B80BAFC;//FK 71
                newValues = new byte[] { 0xBC, 0x02, 0xBC, 0x02, 0xEE, 0x02, 0x16, 0x03, 0x8A, 0x02, 0xA8, 0x02, 0x2C, 0x01, 0x58, 0x02, 0x2C, 0x01, };
                WriteFunction(offset, newValues);

                offset = 0x6B80BB9C;//PT 22
                newValues = new byte[] { 0xEE, 0x02, 0xD0, 0x02, 0xB2, 0x02, 0xB2, 0x02, 0x0C, 0x03, 0xE4, 0x02, 0xF4, 0x01, 0xBC, 0x02, 0x2C, 0x01, };
                WriteFunction(offset, newValues);

                offset = 0x6B80BC3C;//Bain
                newValues = new byte[] { 0x16, 0x03, 0x8A, 0x02, 0xE4, 0x02, 0xA8, 0x02, 0xF8, 0x02, 0x58, 0x02, 0xC2, 0x01, 0x26, 0x02, 0x58, 0x02, };
                WriteFunction(offset, newValues);

                offset = 0x6B80BCDC;//Cooper
                newValues = new byte[] { 0xA8, 0x02, 0x20, 0x03, 0xF8, 0x02, 0xA8, 0x02, 0xD0, 0x02, 0xA8, 0x02, 0xF4, 0x01, 0x58, 0x02, 0x2C, 0x01, };
                WriteFunction(offset, newValues);

                offset = 0x6B80BD7C;//Anderson
                newValues = new byte[] { 0x9E, 0x02, 0xD0, 0x02, 0x70, 0x03, 0xBC, 0x02, 0xBC, 0x02, 0x58, 0x02, 0xF4, 0x01, 0x58, 0x02, 0x90, 0x01, };
                WriteFunction(offset, newValues);

                offset = 0x6B80BE1C;//Taylor
                newValues = new byte[] { 0xB2, 0x02, 0xBC, 0x02, 0xEE, 0x02, 0xA8, 0x02, 0x5C, 0x03, 0xF4, 0x01, 0x90, 0x01, 0xC2, 0x01, 0xC2, 0x01, };
                WriteFunction(offset, newValues);

                offset = 0x6B80BEBC;//Chris
                newValues = new byte[] { 0x52, 0x03, 0xBC, 0x02, 0xBC, 0x02, 0x20, 0x03, 0xF8, 0x02, 0xEE, 0x02, 0xEE, 0x02, 0xBC, 0x02, 0xBC, 0x02, };
                WriteFunction(offset, newValues);

                offset = 0x6B80BF5C;//Park
                newValues = new byte[] { 0x84, 0x03, 0x8A, 0x02, 0x0C, 0x03, 0xCA, 0x03, 0xBC, 0x02, 0xA8, 0x02, 0x8A, 0x02, 0x26, 0x02, 0xEE, 0x02, };
                WriteFunction(offset, newValues);

                offset = 0x6B80BFFC;//Alex
                newValues = new byte[] { 0x20, 0x03, 0x84, 0x03, 0xEE, 0x02, 0xEE, 0x02, 0x34, 0x03, 0x0C, 0x03, 0xEE, 0x02, 0xBC, 0x02, 0x58, 0x02, };
                WriteFunction(offset, newValues);

                offset = 0x6B80C09C;//McKinzie
                newValues = new byte[] { 0x52, 0x03, 0x52, 0x03, 0xE8, 0x03, 0x20, 0x03, 0x84, 0x03, 0x20, 0x03, 0xEE, 0x02, 0xEE, 0x02, 0xBC, 0x02, };
                WriteFunction(offset, newValues);

                offset = 0x6B80C13C;//Napalm 99
                newValues = new byte[] { 0x84, 0x03, 0x84, 0x03, 0x20, 0x03, 0xEE, 0x02, 0xBC, 0x02, 0x84, 0x03, 0x84, 0x03, 0x84, 0x03, 0x20, 0x03, };
                WriteFunction(offset, newValues);

                offset = 0x6B80C1DC;//Golem
                newValues = new byte[] { 0xE8, 0x03, 0xE8, 0x03, 0xE8, 0x03, 0x84, 0x03, 0x52, 0x03, 0xE8, 0x03, 0xE8, 0x03, 0xE8, 0x03, 0xF4, 0x01, };
                WriteFunction(offset, newValues);

                offset = 0x6B80C27C;//Riki
                newValues = new byte[] { 0x52, 0x03, 0x8A, 0x02, 0x8A, 0x02, 0xD0, 0x02, 0x3E, 0x03, 0x58, 0x02, 0x90, 0x01, 0xBC, 0x02, 0x90, 0x01, };
                WriteFunction(offset, newValues);

                offset = 0x6B80C31C;//Masa
                newValues = new byte[] { 0xA8, 0x02, 0x34, 0x03, 0xD0, 0x02, 0xA8, 0x02, 0x20, 0x03, 0xBC, 0x02, 0x90, 0x01, 0xD0, 0x02, 0x2C, 0x01, };
                WriteFunction(offset, newValues);

                offset = 0x6B80C3BC;//Hiro
                newValues = new byte[] { 0xB2, 0x02, 0xB2, 0x02, 0x20, 0x03, 0x34, 0x03, 0x70, 0x03, 0x8A, 0x02, 0xFA, 0x00, 0x44, 0x02, 0xC8, 0x00, };
                WriteFunction(offset, newValues);

                offset = 0x6B80C45C;//Ryuji
                newValues = new byte[] { 0xEE, 0x02, 0xBC, 0x02, 0xDA, 0x02, 0xEE, 0x02, 0x34, 0x03, 0xC2, 0x01, 0x5E, 0x01, 0xA8, 0x02, 0x7C, 0x01, };
                WriteFunction(offset, newValues);

                offset = 0x6B80C4FC;//Ye Wei
                newValues = new byte[] { 0x48, 0x03, 0x94, 0x02, 0x94, 0x02, 0xBC, 0x02, 0x7A, 0x03, 0x26, 0x02, 0x5E, 0x01, 0x8A, 0x02, 0x2C, 0x01, };
                WriteFunction(offset, newValues);

                offset = 0x6B80C59C;//Sha Ying
                newValues = new byte[] { 0xBC, 0x02, 0x52, 0x03, 0xD0, 0x02, 0xA8, 0x02, 0x52, 0x03, 0x8A, 0x02, 0x90, 0x01, 0xE4, 0x02, 0x90, 0x01, };
                WriteFunction(offset, newValues);

                offset = 0x6B80C63C;//Yan Jun
                newValues = new byte[] { 0xD0, 0x02, 0xBC, 0x02, 0x0C, 0x03, 0x70, 0x03, 0x7A, 0x03, 0x6C, 0x02, 0x90, 0x01, 0xBC, 0x02, 0x90, 0x01, };
                WriteFunction(offset, newValues);

                offset = 0x6B80C6DC;//Shinkai
                newValues = new byte[] { 0x52, 0x03, 0x52, 0x03, 0xE8, 0x03, 0xE8, 0x03, 0xE8, 0x03, 0xEE, 0x02, 0x20, 0x03, 0x20, 0x03, 0xEE, 0x02, };
                WriteFunction(offset, newValues);

                offset = 0x6B80C77C;//Lin Fong Lee
                newValues = new byte[] { 0x84, 0x03, 0x20, 0x03, 0x20, 0x03, 0xB6, 0x03, 0x84, 0x03, 0xBC, 0x02, 0xBC, 0x02, 0xBC, 0x02, 0x8A, 0x02, };
                WriteFunction(offset, newValues);

                offset = 0x6B80C81C;//Bordin
                newValues = new byte[] { 0xF4, 0x01, 0xC2, 0x01, 0xF4, 0x01, 0xC2, 0x01, 0xF4, 0x01, 0x90, 0x01, 0xC8, 0x00, 0x2C, 0x01, 0xC8, 0x00, };
                WriteFunction(offset, newValues);

                offset = 0x6B80C8BC;//Lilian
                newValues = new byte[] { 0xD0, 0x02, 0x0C, 0x03, 0xEE, 0x02, 0x52, 0x03, 0x7A, 0x03, 0xF4, 0x01, 0x2C, 0x01, 0xF4, 0x01, 0x2C, 0x01, };
                WriteFunction(offset, newValues);

                offset = 0x6B80C95C;//Kelly
                newValues = new byte[] { 0x20, 0x03, 0x6C, 0x02, 0xEE, 0x02, 0x48, 0x03, 0x8A, 0x02, 0x26, 0x02, 0x2C, 0x01, 0x26, 0x02, 0x2C, 0x01, };
                WriteFunction(offset, newValues);

                offset = 0x6B80C9FC;//Vera
                newValues = new byte[] { 0x6C, 0x02, 0x8E, 0x03, 0xA8, 0x02, 0xD0, 0x02, 0x58, 0x02, 0xBC, 0x02, 0x5E, 0x01, 0x58, 0x02, 0x2C, 0x01, };
                WriteFunction(offset, newValues);

                offset = 0x6B80CA9C;//Paul
                newValues = new byte[] { 0xE8, 0x03, 0xB6, 0x03, 0x84, 0x03, 0x52, 0x03, 0x8A, 0x02, 0x84, 0x03, 0x52, 0x03, 0x52, 0x03, 0xBC, 0x02, };
                WriteFunction(offset, newValues);

                offset = 0x6B80CB3C;//Law
                newValues = new byte[] { 0xB6, 0x03, 0x84, 0x03, 0x52, 0x03, 0xE8, 0x03, 0xEE, 0x02, 0x52, 0x03, 0x20, 0x03, 0x52, 0x03, 0xBC, 0x02, };
                WriteFunction(offset, newValues);

                offset = 0x6B80D0DC;//KG
                newValues = new byte[] { 0xE4, 0x02, 0x6C, 0x02, 0x58, 0x02, 0xD0, 0x02, 0x6C, 0x02, 0x58, 0x02, 0x2C, 0x01, 0xF4, 0x01, 0x2C, 0x01, };
                WriteFunction(offset, newValues);

                offset = 0x6B80D17C;//Bain (Mask)
                newValues = new byte[] { 0x16, 0x03, 0x8A, 0x02, 0xE4, 0x02, 0xA8, 0x02, 0xF8, 0x02, 0x58, 0x02, 0xC2, 0x01, 0x26, 0x02, 0x58, 0x02, };
                WriteFunction(offset, newValues);

                offset = 0x6B80D21C;//Cooper (Mask)
                newValues = new byte[] { 0xA8, 0x02, 0x20, 0x03, 0xF8, 0x02, 0xA8, 0x02, 0xD0, 0x02, 0xA8, 0x02, 0xF4, 0x01, 0x58, 0x02, 0x2C, 0x01, };
                WriteFunction(offset, newValues);
            }
        }


        public static void WriteFunction(uint offset, byte[] newValues)
        {
            // Open the file and seek to the offset
            using (var fs = new FileStream(SettingsClass.gameFolderPath + @"\Urban Reign Deluxe.iso", FileMode.Open, FileAccess.Write))
            {
                fs.Seek(offset, SeekOrigin.Begin);

                // Write the new values to the file
                fs.Write(newValues, 0, newValues.Length);
            }
        }
    }
}
