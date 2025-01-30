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
using System.Security.Cryptography;
using Microsoft.EntityFrameworkCore;

namespace UR_pnach_editor.Codes
{
    public class CreatePnach4
    {
        static string baseCode = "";

        public static void GunMasterPlayer3()
        {
            baseCode = "//P1" + Environment.NewLine +
                "patch=1,EE,105A6020,extended,0020 //WPA" + Environment.NewLine +
                "//P2" + Environment.NewLine +
                "patch=1,EE,105AF770,extended,0020 //WPA" + Environment.NewLine +
                "//P3" + Environment.NewLine +
                "patch=1,EE,2094A64C,extended,16 //have gun" + Environment.NewLine +
                "patch=1,EE,105B8EB8,extended,0240 //STK" + Environment.NewLine +
                "patch=1,EE,105B8EBA,extended,0240 //GRP" + Environment.NewLine +
                "patch=1,EE,105B8EBC,extended,0240 //RGA" + Environment.NewLine +
                "patch=1,EE,105B8EBE,extended,0200 //SPA" + Environment.NewLine +
                "patch=1,EE,105B8EC0,extended,0100 //WPA" + Environment.NewLine +
                "patch=1,EE,105B8EC2,extended,0300 //TGH" + Environment.NewLine +
                "patch=1,EE,105B8E72,extended,0190 //HDE" + Environment.NewLine +
                "patch=1,EE,105B8E78,extended,00D2 //HDE Balance" + Environment.NewLine +
                "patch=1,EE,105B8E74,extended,0190 //UBE" + Environment.NewLine +
                "patch=1,EE,105B8E7A,extended,00D2 //UBE Balance" + Environment.NewLine +
                "patch=1,EE,105B8E76,extended,0190 //LBE" + Environment.NewLine +
                "patch=1,EE,105B8E7C,extended,00D2 //LBE Balance" + Environment.NewLine +
                "patch=1,EE,105B8F10,extended,0064 //SPA Regained" + Environment.NewLine +
                "patch=1,EE,205B8EA2,extended,3F20 //SPA Down Red Bar Color" + Environment.NewLine +
                "patch=1,EE,205B8EA6,extended,3F20 //SPA Down Green Bar Color" + Environment.NewLine +
                "patch=1,EE,205B8EAA,extended,3F80 //SPA Down Blue Bar Color" + Environment.NewLine +
                "patch=1,EE,205B8EAE,extended,3F80 //SPA Down Alpha Bar Color" + Environment.NewLine +
                "patch=1,EE,205B8EB0,extended,0003 //SPA Down" + Environment.NewLine +
                "//P4" + Environment.NewLine +
                "patch=1,EE,105C2608,extended,0400 //STK" + Environment.NewLine +
                "patch=1,EE,105C260A,extended,03D0 //GRP" + Environment.NewLine +
                "patch=1,EE,105C260C,extended,0342 //RGA" + Environment.NewLine +
                "patch=1,EE,105C260E,extended,0340 //SPA" + Environment.NewLine +
                "patch=1,EE,105C2610,extended,0320 //WPA" + Environment.NewLine +
                "patch=1,EE,105C2612,extended,0480 //TGH" + Environment.NewLine +
                "patch=1,EE,105C25C2,extended,01F4 //HDE" + Environment.NewLine +
                "patch=1,EE,105C25C8,extended,00FA //HDE Balance" + Environment.NewLine +
                "patch=1,EE,105C25C4,extended,01F4 //UBE" + Environment.NewLine +
                "patch=1,EE,105C25CA,extended,00FA //UBE Balance" + Environment.NewLine +
                "patch=1,EE,105C25C6,extended,01F4 //LBE" + Environment.NewLine +
                "patch=1,EE,105C25CC,extended,00FA //LBE Balance" + Environment.NewLine +
                "patch=1,EE,205C25F2,extended,3F80 //SPA Down Red Bar Color" + Environment.NewLine +
                "patch=1,EE,205C25F6,extended,3F80 //SPA Down Green Bar Color" + Environment.NewLine +
                "patch=1,EE,205C25FA,extended,3F20 //SPA Down Blue Bar Color" + Environment.NewLine +
                "patch=1,EE,205C25FE,extended,3F20 //SPA Down Alpha Bar Color" + Environment.NewLine +
                "patch=1,EE,205C2600,extended,0001 //SPA Down" + Environment.NewLine +
                "patch=1,EE,205C2604,extended,44DF8000 //Infinite Spa Down" + Environment.NewLine +
            "";

            ExportPnach.ExportFile(baseCode);
        }

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

        public static void NapalmShaman()
        {
            baseCode = "//P3" + Environment.NewLine +
                "patch=1,EE,105B8EB8,extended,0320 //STK" + Environment.NewLine +
                "patch=1,EE,105B8EBA,extended,0320 //GRP" + Environment.NewLine +
                "patch=1,EE,105B8EBC,extended,02EE //RGA" + Environment.NewLine +
                "patch=1,EE,105B8EBE,extended,02BC //SPA" + Environment.NewLine +
                "patch=1,EE,105B8EC0,extended,0258 //WPA" + Environment.NewLine +
                "patch=1,EE,105B8EC2,extended,01F4 //TGH" + Environment.NewLine +
                "patch=1,EE,105B8E72,extended,00C8 //HDE" + Environment.NewLine +
                "patch=1,EE,105B8E78,extended,0064 //HDE Balance" + Environment.NewLine +
                "patch=1,EE,105B8E74,extended,00C8 //UBE" + Environment.NewLine +
                "patch=1,EE,105B8E7A,extended,0064 //UBE Balance" + Environment.NewLine +
                "patch=1,EE,105B8E76,extended,00C8 //LBE" + Environment.NewLine +
                "patch=1,EE,105B8E7C,extended,0064 //LBE Balance" + Environment.NewLine +
                "patch=1,EE,105B8F10,extended,0040 //SPA Regained" + Environment.NewLine +
                "patch=1,EE,205B8EA2,extended,3FE0 //SPA Down Red Bar Color" + Environment.NewLine +
                "patch=1,EE,205B8EA6,extended,3F40 //SPA Down Green Bar Color" + Environment.NewLine +
                "patch=1,EE,205B8EAA,extended,3FE0 //SPA Down Blue Bar Color" + Environment.NewLine +
                "patch=1,EE,205B8EAE,extended,3FE0 //SPA Down Alpha Bar Color" + Environment.NewLine +
                "patch=1,EE,205B8EB0,extended,0003 //SPA Down" + Environment.NewLine +
                "patch=1,EE,205B0044,extended,002C //Moves & Skin 1" + Environment.NewLine +
                "patch=1,EE,2094A63C,extended,002C //Moves & Skin 2" + Environment.NewLine +
            "";

            ExportPnach.ExportFile(baseCode);
        }

        public static void MckenzieAndNapalm()
        {
            baseCode = "//P3" + Environment.NewLine +
                "patch=1,EE,105B8EB8,extended,0384 //STK" + Environment.NewLine +
                "patch=1,EE,105B8EBA,extended,0370 //GRP" + Environment.NewLine +
                "patch=1,EE,105B8EBC,extended,0BB8 //RGA" + Environment.NewLine +
                "patch=1,EE,105B8EBE,extended,0348 //SPA" + Environment.NewLine +
                "patch=1,EE,105B8EC0,extended,0514 //WPA" + Environment.NewLine +
                "patch=1,EE,105B8EC2,extended,03E8 //TGH" + Environment.NewLine +
                "patch=1,EE,105B8E72,extended,0190 //HDE" + Environment.NewLine +
                "patch=1,EE,105B8E78,extended,00D2 //HDE Balance" + Environment.NewLine +
                "patch=1,EE,105B8E74,extended,0190 //UBE" + Environment.NewLine +
                "patch=1,EE,105B8E7A,extended,00D2 //UBE Balance" + Environment.NewLine +
                "patch=1,EE,105B8E76,extended,0190 //LBE" + Environment.NewLine +
                "patch=1,EE,105B8E7C,extended,00D2 //LBE Balance" + Environment.NewLine +
                "patch=1,EE,105B8F10,extended,0064 //SPA Regained" + Environment.NewLine +
                "patch=1,EE,105B8E8A,extended,0064 //WALL DMG" + Environment.NewLine +
                "patch=1,EE,205B8EA2,extended,3F80 //SPA Down Red Bar Color" + Environment.NewLine +
                "patch=1,EE,205B8EA6,extended,3F20 //SPA Down Green Bar Color" + Environment.NewLine +
                "patch=1,EE,205B8EAA,extended,3F80 //SPA Down Blue Bar Color" + Environment.NewLine +
                "patch=1,EE,205B8EAE,extended,3F80 //SPA Down Alpha Bar Color" + Environment.NewLine +
                "patch=1,EE,205B8EB0,extended,0003 //SPA Down" + Environment.NewLine +
                "patch=1,EE,205B8EB4,extended,44DF8000 //Infinite Spa Down" + Environment.NewLine +
                "patch=1,EE,205B0044,extended,002B //Moves & Skin 1" + Environment.NewLine +
                "patch=1,EE,2094A63C,extended,002B //Moves & Skin 2" + Environment.NewLine +
                "//P4" + Environment.NewLine +
                "patch=1,EE,105C2608,extended,0384 //STK" + Environment.NewLine +
                "patch=1,EE,105C260A,extended,0578 //GRP" + Environment.NewLine +
                "patch=1,EE,105C260C,extended,0384 //RGA" + Environment.NewLine +
                "patch=1,EE,105C260E,extended,0384 //SPA" + Environment.NewLine +
                "patch=1,EE,105C2610,extended,0320 //WPA" + Environment.NewLine +
                "patch=1,EE,105C2612,extended,03E8 //TGH" + Environment.NewLine +
                "patch=1,EE,105C25C2,extended,01F4 //HDE" + Environment.NewLine +
                "patch=1,EE,105C25C8,extended,00FA //HDE Balance" + Environment.NewLine +
                "patch=1,EE,105C25C4,extended,01F4 //UBE" + Environment.NewLine +
                "patch=1,EE,105C25CA,extended,00FA //UBE Balance" + Environment.NewLine +
                "patch=1,EE,105C25C6,extended,01F4 //LBE" + Environment.NewLine +
                "patch=1,EE,105C25CC,extended,00FA //LBE Balance" + Environment.NewLine +
                "patch=1,EE,105C2660,extended,0008 //SPA Regained" + Environment.NewLine +
                "patch=1,EE,205C25F2,extended,3F80 //SPA Down Red Bar Color" + Environment.NewLine +
                "patch=1,EE,205C25F6,extended,3F20 //SPA Down Green Bar Color" + Environment.NewLine +
                "patch=1,EE,205C25FA,extended,3F80 //SPA Down Blue Bar Color" + Environment.NewLine +
                "patch=1,EE,205C25FE,extended,3F80 //SPA Down Alpha Bar Color" + Environment.NewLine +
                "patch=1,EE,205C2600,extended,0001 //SPA Down" + Environment.NewLine +
                "patch=1,EE,205C2604,extended,44DF8000 //Infinite Spa Down" + Environment.NewLine +
                "patch=1,EE,205B9794,extended,002C //Moves & Skin 1" + Environment.NewLine +
                "patch=1,EE,2094A640,extended,002C //Moves & Skin 2" + Environment.NewLine +
            "";

            ExportPnach.ExportFile(baseCode);
        }


        public static void EuropeanVersionCodes()
        {
            baseCode = "//Euro Codes" + Environment.NewLine +

            "//Hyper Mode (Press R1+R2+Left)//" + Environment.NewLine +
            "patch = 1,EE,E002F57F,extended,0035A5D2//" + Environment.NewLine +
            "patch = 1, EE,20238CB8,extended,3C014000//" + Environment.NewLine +
            "patch = 1, EE,20238CC0,extended,44810000//" + Environment.NewLine +

            "//Normal Speed (Press R1+R2+Right)//" + Environment.NewLine +
            "patch = 1,EE,E002F5DF,extended,0035A5D2//" + Environment.NewLine +
            "patch = 1, EE,20238CB8,extended,3C02005A//" + Environment.NewLine +
            "patch = 1, EE,20238CC0,extended,C440DBCC//" + Environment.NewLine +

            "//Quicker Game (Press R1+R2+Up)//" + Environment.NewLine +
            "patch = 1, EE, E002F5EF, extended,0035A5D2//" + Environment.NewLine +
            "patch = 1, EE,20238CB8,extended,3C013FC0//" + Environment.NewLine +
            "patch = 1, EE,20238CC0,extended,44810000//" + Environment.NewLine +

            "//Slow Motion (Press R1+R2+Down)//" + Environment.NewLine +
            "patch = 1,EE,E002F5BF,extended,0035A5D2//" + Environment.NewLine +
            "patch = 1, EE,20238CB8,extended,3C013F00//" + Environment.NewLine +
            "patch = 1, EE,20238CC0,extended,44810000//" + Environment.NewLine +


            "//skin [L2+↑ Real Deal]//" + Environment.NewLine +
            "patch = 1,EE,D035A5D2,extended,0000FEEF//" + Environment.NewLine +
            "patch = 1, EE,201E8210,extended,24110009//" + Environment.NewLine +
            "patch = 1,EE,D035A5D2,extended,0000FFF7//" + Environment.NewLine +
            "patch = 1, EE,201E8210,extended,00A0882D//" + Environment.NewLine +

            "//skin [L2+← Ty]//" + Environment.NewLine +
            "patch = 1, EE, D035A5D2, extended,0000FE7F//" + Environment.NewLine +
            "patch = 1, EE,201E8210,extended,2411000A//" + Environment.NewLine +
            "patch = 1, EE, D035A5D2, extended,0000FFF7//" + Environment.NewLine +
            "patch = 1, EE,201E8210,extended,00A0882D//" + Environment.NewLine +

            "//skin [L2+→ Em Cee]//" + Environment.NewLine +
            "patch = 1, EE, D035A5D2, extended,0000FEDF//" + Environment.NewLine +
            "patch = 1, EE,201E8210,extended,24110008//" + Environment.NewLine +
            "patch = 1,EE,D035A5D2,extended,0000FFF7//" + Environment.NewLine +
            "patch = 1, EE,201E8210,extended,00A0882D//" + Environment.NewLine +

            "//skin [L2+↓ Nas-Tiii]//" + Environment.NewLine +
            "patch = 1, EE, D035A5D2, extended,0000FEBF//" + Environment.NewLine +
            "patch = 1, EE,201E8210,extended,24110007//" + Environment.NewLine +
            "patch = 1,EE,D035A5D2,extended,0000FFF7//" + Environment.NewLine +
            "patch = 1, EE,201E8210,extended,00A0882D//" + Environment.NewLine +

            "//skin [L2+△ Miguel]//" + Environment.NewLine +
            "patch = 1, EE, D035A5D2, extended,0000EEFF//" + Environment.NewLine +
            "patch = 1, EE,201E8210,extended,2411000B//" + Environment.NewLine +
            "patch = 1, EE, D035A5D2, extended,0000FFF7//" + Environment.NewLine +
            "patch = 1, EE,201E8210,extended,00A0882D//" + Environment.NewLine +

            "//skin [L2+▢ Jose]//" + Environment.NewLine +
            "patch = 1, EE, D035A5D2, extended,00007EFF//" + Environment.NewLine +
            "patch = 1, EE,201E8210,extended,2411000D//" + Environment.NewLine +
            "patch = 1,EE,D035A5D2,extended,0000FFF7//" + Environment.NewLine +
            "patch = 1, EE,201E8210,extended,00A0882D//" + Environment.NewLine +

            "//skin [L2+O Emilio]//" + Environment.NewLine +
            "patch = 1, EE, D035A5D2, extended,0000DEFF//" + Environment.NewLine +
            "patch = 1, EE,201E8210,extended,2411000E//" + Environment.NewLine +
            "patch = 1,EE,D035A5D2,extended,0000FFF7//" + Environment.NewLine +
            "patch = 1, EE,201E8210,extended,00A0882D//" + Environment.NewLine +

            "//skin [L2+X Ramon]//" + Environment.NewLine +
            "patch = 1, EE, D035A5D2, extended,0000BEFF//" + Environment.NewLine +
            "patch = 1, EE,201E8210,extended,2411000C//" + Environment.NewLine +
            "patch = 1, EE, D035A5D2, extended,0000FFF7//" + Environment.NewLine +
            "patch = 1, EE,201E8210,extended,00A0882D//" + Environment.NewLine +

            "//skin [L2+L1 Kelly]//" + Environment.NewLine +
            "patch = 1, EE, D035A5D2, extended,0000FAFF//" + Environment.NewLine +
            "patch = 1, EE,201E8210,extended,24110039//" + Environment.NewLine +
            "patch = 1,EE,D035A5D2,extended,0000FFF7//" + Environment.NewLine +
            "patch = 1, EE,201E8210,extended,00A0882D//" + Environment.NewLine +

            "//skin [L2+R1 Vera]//" + Environment.NewLine +
            "patch = 1, EE, D035A5D2, extended,0000F6FF//" + Environment.NewLine +
            "patch = 1, EE,201E8210,extended,2411003A//" + Environment.NewLine +
            "patch = 1, EE, D035A5D2, extended,0000FFF7//" + Environment.NewLine +
            "patch = 1, EE,201E8210,extended,00A0882D//" + Environment.NewLine +


            "//skin [R2+↑ Booma]//" + Environment.NewLine +
            "patch = 1, EE, D035A5D2, extended,0000FDEF//" + Environment.NewLine +
            "patch = 1, EE,201E8210,extended,24110019//" + Environment.NewLine +
            "patch = 1,EE,D035A5D2,extended,0000FFF7//" + Environment.NewLine +
            "patch = 1, EE,201E8210,extended,00A0882D//" + Environment.NewLine +

            "//skin [R2+← Grave Digga']//" + Environment.NewLine +
            "patch = 1, EE, D035A5D2, extended,0000FD7F//" + Environment.NewLine +
            "patch = 1, EE,201E8210,extended,24110017//" + Environment.NewLine +
            "patch = 1,EE,D035A5D2,extended,0000FFF7//" + Environment.NewLine +
            "patch = 1, EE,201E8210,extended,00A0882D//" + Environment.NewLine +

            "//skin [R2+→ BK]//" + Environment.NewLine +
            "patch = 1, EE, D035A5D2, extended,0000FDDF//" + Environment.NewLine +
            "patch = 1, EE,201E8210,extended,24110016//" + Environment.NewLine +
            "patch = 1,EE,D035A5D2,extended,0000FFF7//" + Environment.NewLine +
            "patch = 1, EE,201E8210,extended,00A0882D//" + Environment.NewLine +

            "//skin [R2+↓ Bones]//" + Environment.NewLine +
            "patch = 1, EE, D035A5D2, extended,0000FDBF//" + Environment.NewLine +
            "patch = 1, EE,201E8210,extended,24110018//" + Environment.NewLine +
            "patch = 1,EE,D035A5D2,extended,0000FFF7//" + Environment.NewLine +
            "patch = 1, EE,201E8210,extended,00A0882D//" + Environment.NewLine +

            "//skin [R2+△ Pain Killah]//" + Environment.NewLine +
            "patch = 1, EE, D035A5D2, extended,0000EDFF//" + Environment.NewLine +
            "patch = 1, EE,201E8210,extended,2411001C//" + Environment.NewLine +
            "patch = 1, EE, D035A5D2, extended,0000FFF7//" + Environment.NewLine +
            "patch = 1, EE,201E8210,extended,00A0882D//" + Environment.NewLine +

            "//skin [R2+▢ Spider]//" + Environment.NewLine +
            "patch = 1, EE, D035A5D2, extended,00007DFF//" + Environment.NewLine +
            "patch = 1, EE,201E8210,extended,2411001B//" + Environment.NewLine +
            "patch = 1, EE, D035A5D2, extended,0000FFF7//" + Environment.NewLine +
            "patch = 1, EE,201E8210,extended,00A0882D//" + Environment.NewLine +

            "//skin [R2+O Busta]//" + Environment.NewLine +
            "patch = 1, EE, D035A5D2, extended,0000DDFF//" + Environment.NewLine +
            "patch = 1, EE,201E8210,extended,2411001A//" + Environment.NewLine +
            "patch = 1, EE, D035A5D2, extended,0000FFF7//" + Environment.NewLine +
            "patch = 1, EE,201E8210,extended,00A0882D//" + Environment.NewLine +

            "//skin [R2+X KG]//" + Environment.NewLine +
            "patch = 1, EE, D035A5D2, extended,0000BDFF//" + Environment.NewLine +
            "patch = 1, EE,201E8210,extended,24110045//" + Environment.NewLine +
            "patch = 1,EE,D035A5D2,extended,0000FFF7//" + Environment.NewLine +
            "patch = 1, EE,201E8210,extended,00A0882D//" + Environment.NewLine +

            "//skin [R2+L1 Lilian]//" + Environment.NewLine +
            "patch = 1, EE, D035A5D2, extended,0000F9FF//" + Environment.NewLine +
            "patch = 1, EE,201E8210,extended,24110038//" + Environment.NewLine +
            "patch = 1,EE,D035A5D2,extended,0000FFF7//" + Environment.NewLine +
            "patch = 1, EE,201E8210,extended,00A0882D//" + Environment.NewLine +

            "//skin [R2+R1 Dwayne (Mask)]//" + Environment.NewLine +
            "patch = 1, EE, D035A5D2, extended,0000F5FF//" + Environment.NewLine +
            "patch = 1, EE,201E8210,extended,2411001D//" + Environment.NewLine +
            "patch = 1,EE,D035A5D2,extended,0000FFF7//" + Environment.NewLine +
            "patch = 1, EE,201E8210,extended,00A0882D//" + Environment.NewLine +


            "//skin [L3+↑ GD 05]//" + Environment.NewLine +
            "patch = 1, EE, D035A5D2, extended,0000FFED//" + Environment.NewLine +
            "patch = 1, EE,201E8210,extended,24110020//" + Environment.NewLine +
            "patch = 1,EE,D035A5D2,extended,0000FFF7//" + Environment.NewLine +
            "patch = 1, EE,201E8210,extended,00A0882D//" + Environment.NewLine +

            "//skin [L3+← DR 88]//" + Environment.NewLine +
            "patch = 1, EE, D035A5D2, extended,0000FF7D//" + Environment.NewLine +
            "patch = 1, EE,201E8210,extended,24110021//" + Environment.NewLine +
            "patch = 1,EE,D035A5D2,extended,0000FFF7//" + Environment.NewLine +
            "patch = 1, EE,201E8210,extended,00A0882D//" + Environment.NewLine +

            "//skin [L3+→ PT 22]//" + Environment.NewLine +
            "patch = 1, EE, D035A5D2, extended,0000FFDD//" + Environment.NewLine +
            "patch = 1, EE,201E8210,extended,24110023//" + Environment.NewLine +
            "patch = 1,EE,D035A5D2,extended,0000FFF7//" + Environment.NewLine +
            "patch = 1, EE,201E8210,extended,00A0882D//" + Environment.NewLine +

            "//skin [L3+↓ FK 71]//" + Environment.NewLine +
            "patch = 1, EE, D035A5D2, extended,0000FFBD//" + Environment.NewLine +
            "patch = 1, EE,201E8210,extended,24110022//" + Environment.NewLine +
            "patch = 1,EE,D035A5D2,extended,0000FFF7//" + Environment.NewLine +
            "patch = 1, EE,201E8210,extended,00A0882D//" + Environment.NewLine +

            "//skin [L3+△ Anderson]//" + Environment.NewLine +
            "patch = 1, EE, D035A5D2, extended,0000EFFD//" + Environment.NewLine +
            "patch = 1, EE,201E8210,extended,24110026//" + Environment.NewLine +
            "patch = 1,EE,D035A5D2,extended,0000FFF7//" + Environment.NewLine +
            "patch = 1, EE,201E8210,extended,00A0882D//" + Environment.NewLine +

            "//skin [L3+▢ Cooper]//" + Environment.NewLine +
            "patch = 1, EE, D035A5D2, extended,00007FFD//" + Environment.NewLine +
            "patch = 1, EE,201E8210,extended,24110025//" + Environment.NewLine +
            "patch = 1,EE,D035A5D2,extended,0000FFF7//" + Environment.NewLine +
            "patch = 1, EE,201E8210,extended,00A0882D//" + Environment.NewLine +

            "//skin [L3+O Bain]//" + Environment.NewLine +
            "patch = 1, EE, D035A5D2, extended,0000DFFD//" + Environment.NewLine +
            "patch = 1, EE,201E8210,extended,24110024//" + Environment.NewLine +
            "patch = 1,EE,D035A5D2,extended,0000FFF7//" + Environment.NewLine +
            "patch = 1, EE,201E8210,extended,00A0882D//" + Environment.NewLine +

            "//skin [L3+X Taylor]//" + Environment.NewLine +
            "patch = 1, EE, D035A5D2, extended,0000BFFD//" + Environment.NewLine +
            "patch = 1, EE,201E8210,extended,24110027//" + Environment.NewLine +
            "patch = 1,EE,D035A5D2,extended,0000FFF7//" + Environment.NewLine +
            "patch = 1, EE,201E8210,extended,00A0882D//" + Environment.NewLine +

            "//skin [L3+L1 Bain (Mask)]//" + Environment.NewLine +
            "patch = 1, EE, D035A5D2, extended,0000FBFD//" + Environment.NewLine +
            "patch = 1, EE,201E8210,extended,24110046//" + Environment.NewLine +
            "patch = 1,EE,D035A5D2,extended,0000FFF7//" + Environment.NewLine +
            "patch = 1, EE,201E8210,extended,00A0882D//" + Environment.NewLine +

            "//skin [L3+R1 Cooper (Mask)]//" + Environment.NewLine +
            "patch = 1, EE, D035A5D2, extended,0000F7FD//" + Environment.NewLine +
            "patch = 1, EE,201E8210,extended,24110047//" + Environment.NewLine +
            "patch = 1,EE,D035A5D2,extended,0000FFF7//" + Environment.NewLine +
            "patch = 1, EE,201E8210,extended,00A0882D//" + Environment.NewLine +


            "//skin [R3+↑ Seth]//" + Environment.NewLine +
            "patch = 1, EE, D035A5D2, extended,0000FFEB//" + Environment.NewLine +
            "patch = 1, EE,201E8210,extended,24110006//" + Environment.NewLine +
            "patch = 1,EE,D035A5D2,extended,0000FFF7//" + Environment.NewLine +
            "patch = 1, EE,201E8210,extended,00A0882D//" + Environment.NewLine +

            "//skin [R3+← Rod]//" + Environment.NewLine +
            "patch = 1, EE, D035A5D2, extended,0000FF7B//" + Environment.NewLine +
            "patch = 1, EE,201E8210,extended,24110005//" + Environment.NewLine +
            "patch = 1,EE,D035A5D2,extended,0000FFF7//" + Environment.NewLine +
            "patch = 1, EE,201E8210,extended,00A0882D//" + Environment.NewLine +

            "//skin [R3+→ Torque]//" + Environment.NewLine +
            "patch = 1, EE, D035A5D2, extended,0000FFDB//" + Environment.NewLine +
            "patch = 1, EE,201E8210,extended,24110004//" + Environment.NewLine +
            "patch = 1,EE,D035A5D2,extended,0000FFF7//" + Environment.NewLine +
            "patch = 1, EE,201E8210,extended,00A0882D//" + Environment.NewLine +

            "//skin [R3+↓ Reggie]//" + Environment.NewLine +
            "patch = 1, EE, D035A5D2, extended,0000FFBB//" + Environment.NewLine +
            "patch = 1, EE,201E8210,extended,24110011//" + Environment.NewLine +
            "patch = 1,EE,D035A5D2,extended,0000FFF7//" + Environment.NewLine +
            "patch = 1, EE,201E8210,extended,00A0882D//" + Environment.NewLine +

            "//skin [R3+△ Riki]//" + Environment.NewLine +
            "patch = 1, EE, D035A5D2, extended,0000EFFB//" + Environment.NewLine +
            "patch = 1, EE,201E8210,extended,2411002E//" + Environment.NewLine +
            "patch = 1,EE,D035A5D2,extended,0000FFF7//" + Environment.NewLine +
            "patch = 1, EE,201E8210,extended,00A0882D//" + Environment.NewLine +

            "//skin [R3+▢ Masa]//" + Environment.NewLine +
            "patch = 1, EE, D035A5D2, extended,00007FFB//" + Environment.NewLine +
            "patch = 1, EE,201E8210,extended,2411002F//" + Environment.NewLine +
            "patch = 1,EE,D035A5D2,extended,0000FFF7//" + Environment.NewLine +
            "patch = 1, EE,201E8210,extended,00A0882D//" + Environment.NewLine +

            "//skin [R3+O Hiro]//" + Environment.NewLine +
            "patch = 1, EE, D035A5D2, extended,0000DFFB//" + Environment.NewLine +
            "patch = 1, EE,201E8210,extended,24110030//" + Environment.NewLine +
            "patch = 1,EE,D035A5D2,extended,0000FFF7//" + Environment.NewLine +
            "patch = 1, EE,201E8210,extended,00A0882D//" + Environment.NewLine +

            "//skin [R3+X Ryuji]//" + Environment.NewLine +
            "patch = 1, EE, D035A5D2, extended,0000BFFB//" + Environment.NewLine +
            "patch = 1, EE,201E8210,extended,24110031//" + Environment.NewLine +
            "patch = 1,EE,D035A5D2,extended,0000FFF7//" + Environment.NewLine +
            "patch = 1, EE,201E8210,extended,00A0882D//" + Environment.NewLine +

            "//skin [R3+L1 Zack]//" + Environment.NewLine +
            "patch = 1, EE, D035A5D2, extended,0000FBFB//" + Environment.NewLine +
            "patch = 1, EE,201E8210,extended,24110040//" + Environment.NewLine +
            "patch = 1,EE,D035A5D2,extended,0000FFF7//" + Environment.NewLine +
            "patch = 1, EE,201E8210,extended,00A0882D//" + Environment.NewLine +

            "//skin [R3+R1 Colin]//" + Environment.NewLine +
            "patch = 1, EE, D035A5D2, extended,0000F7FB//" + Environment.NewLine +
            "patch = 1, EE,201E8210,extended,24110012//" + Environment.NewLine +
            "patch = 1,EE,D035A5D2,extended,0000FFF7//" + Environment.NewLine +
            "patch = 1, EE,201E8210,extended,00A0882D//" + Environment.NewLine +


            "//skin [Select+↑ Lin Fong Lee]//" + Environment.NewLine +
            "patch = 1, EE, D035A5D2, extended,0000FFEE//" + Environment.NewLine +
            "patch = 1, EE,201E8210,extended,24110036//" + Environment.NewLine +
            "patch = 1,EE,D035A5D2,extended,0000FFF7//" + Environment.NewLine +
            "patch = 1, EE,201E8210,extended,00A0882D//" + Environment.NewLine +

            "//skin [Select+← Sha Ying]//" + Environment.NewLine +
            "patch = 1, EE, D035A5D2, extended,0000FF7E//" + Environment.NewLine +
            "patch = 1, EE,201E8210,extended,24110033//" + Environment.NewLine +
            "patch = 1,EE,D035A5D2,extended,0000FFF7//" + Environment.NewLine +
            "patch = 1, EE,201E8210,extended,00A0882D//" + Environment.NewLine +

            "//skin [Select+→ Yan Jun]//" + Environment.NewLine +
            "patch = 1, EE, D035A5D2, extended,0000FFDE//" + Environment.NewLine +
            "patch = 1, EE,201E8210,extended,24110034//" + Environment.NewLine +
            "patch = 1,EE,D035A5D2,extended,0000FFF7//" + Environment.NewLine +
            "patch = 1, EE,201E8210,extended,00A0882D//" + Environment.NewLine +

            "//skin [Select+↓ Ye Wei]//" + Environment.NewLine +
            "patch = 1, EE, D035A5D2, extended,0000FFBE//" + Environment.NewLine +
            "patch = 1, EE,201E8210,extended,24110032//" + Environment.NewLine +
            "patch = 1,EE,D035A5D2,extended,0000FFF7//" + Environment.NewLine +
            "patch = 1, EE,201E8210,extended,00A0882D//" + Environment.NewLine +

            "//skin [Select+△ Shinkai]//" + Environment.NewLine +
            "patch = 1, EE, D035A5D2, extended,0000EFFE//" + Environment.NewLine +
            "patch = 1, EE,201E8210,extended,24110035//" + Environment.NewLine +
            "patch = 1,EE,D035A5D2,extended,0000FFF7//" + Environment.NewLine +
            "patch = 1, EE,201E8210,extended,00A0882D//" + Environment.NewLine +

            "//skin [Select+▢ Napalm 99]//" + Environment.NewLine +
            "patch = 1, EE, D035A5D2, extended,00007FFE//" + Environment.NewLine +
            "patch = 1, EE,201E8210,extended,2411002C//" + Environment.NewLine +
            "patch = 1, EE, D035A5D2, extended,0000FFF7//" + Environment.NewLine +
            "patch = 1, EE,201E8210,extended,00A0882D//" + Environment.NewLine +

            "//skin [Select+O Golem]//" + Environment.NewLine +
            "patch = 1, EE, D035A5D2, extended,0000DFFE//" + Environment.NewLine +
            "patch = 1, EE,201E8210,extended,2411002D//" + Environment.NewLine +
            "patch = 1,EE,D035A5D2,extended,0000FFF7//" + Environment.NewLine +
            "patch = 1, EE,201E8210,extended,00A0882D//" + Environment.NewLine +

            "//skin [Select+X McKinzie]//" + Environment.NewLine +
            "patch = 1, EE, D035A5D2, extended,0000BFFE//" + Environment.NewLine +
            "patch = 1, EE,201E8210,extended,2411002B//" + Environment.NewLine +
            "patch = 1, EE, D035A5D2, extended,0000FFF7//" + Environment.NewLine +
            "patch = 1, EE,201E8210,extended,00A0882D//" + Environment.NewLine +

            "//skin [Select+L1 Paul]//" + Environment.NewLine +
            "patch = 1, EE, D035A5D2, extended,0000FBFE//" + Environment.NewLine +
            "patch = 1, EE,201E8210,extended,2411003B//" + Environment.NewLine +
            "patch = 1, EE, D035A5D2, extended,0000FFF7//" + Environment.NewLine +
            "patch = 1, EE,201E8210,extended,00A0882D//" + Environment.NewLine +

            "//skin [Select+R1 Law]//" + Environment.NewLine +
            "patch = 1, EE, D035A5D2, extended,0000F7FE//" + Environment.NewLine +
            "patch = 1, EE,201E8210,extended,2411003C//" + Environment.NewLine +
            "patch = 1, EE, D035A5D2, extended,0000FFF7//" + Environment.NewLine +
            "patch = 1, EE,201E8210,extended,00A0882D//" + Environment.NewLine +


            "//skin [Start+↑ Jake]//" + Environment.NewLine +
            "patch = 1, EE, D035A5D2, extended,0000FFE7//" + Environment.NewLine +
            "patch = 1, EE,201E8210,extended,24110013//" + Environment.NewLine +
            "patch = 1,EE,D035A5D2,extended,0000FFF7//" + Environment.NewLine +
            "patch = 1, EE,201E8210,extended,00A0882D//" + Environment.NewLine +

            "//skin [Start+← Tong Yoon]//" + Environment.NewLine +
            "patch = 1, EE, D035A5D2, extended,0000FF77//" + Environment.NewLine +
            "patch = 1, EE,201E8210,extended,24110014//" + Environment.NewLine +
            "patch = 1,EE,D035A5D2,extended,0000FFF7//" + Environment.NewLine +
            "patch = 1, EE,201E8210,extended,00A0882D//" + Environment.NewLine +

            "//skin [Start+→ Grimm]//" + Environment.NewLine +
            "patch = 1, EE, D035A5D2, extended,0000FFD7//" + Environment.NewLine +
            "patch = 1, EE,201E8210,extended,24110015//" + Environment.NewLine +
            "patch = 1,EE,D035A5D2,extended,0000FFF7//" + Environment.NewLine +
            "patch = 1, EE,201E8210,extended,00A0882D//" + Environment.NewLine +

            "//skin [Start+↓ Dwayne]//" + Environment.NewLine +
            "patch = 1, EE, D035A5D2, extended,0000FFB7//" + Environment.NewLine +
            "patch = 1, EE,201E8210,extended,2411001E//" + Environment.NewLine +
            "patch = 1,EE,D035A5D2,extended,0000FFF7//" + Environment.NewLine +
            "patch = 1, EE,201E8210,extended,00A0882D//" + Environment.NewLine +

            "//skin [Start+△ Alex]//" + Environment.NewLine +
            "patch = 1, EE, D035A5D2, extended,0000EFF7//" + Environment.NewLine +
            "patch = 1, EE,201E8210,extended,2411002A//" + Environment.NewLine +
            "patch = 1, EE, D035A5D2, extended,0000FFF7//" + Environment.NewLine +
            "patch = 1, EE,201E8210,extended,00A0882D//" + Environment.NewLine +

            "//skin [Start+▢ Park]//" + Environment.NewLine +
            "patch = 1, EE, D035A5D2, extended,00007FF7//" + Environment.NewLine +
            "patch = 1, EE,201E8210,extended,24110029//" + Environment.NewLine +
            "patch = 1,EE,D035A5D2,extended,0000FFF7//" + Environment.NewLine +
            "patch = 1, EE,201E8210,extended,00A0882D//" + Environment.NewLine +

            "//skin [Start+O Chris]//" + Environment.NewLine +
            "patch = 1, EE, D035A5D2, extended,0000DFF7//" + Environment.NewLine +
            "patch = 1, EE,201E8210,extended,24110028//" + Environment.NewLine +
            "patch = 1,EE,D035A5D2,extended,0000FFF7//" + Environment.NewLine +
            "patch = 1, EE,201E8210,extended,00A0882D//" + Environment.NewLine +

            "//skin [Start+X Shun Ying Lee]//" + Environment.NewLine +
            "patch = 1, EE, D035A5D2, extended,0000BFF7//" + Environment.NewLine +
            "patch = 1, EE,201E8210,extended,2411001F//" + Environment.NewLine +
            "patch = 1,EE,D035A5D2,extended,0000FFF7//" + Environment.NewLine +
            "patch = 1, EE,201E8210,extended,00A0882D//" + Environment.NewLine +

            "//skin [Start+L1 Glen]//" + Environment.NewLine +
            "patch = 1, EE, D035A5D2, extended,0000FBF7//" + Environment.NewLine +
            "patch = 1, EE,201E8210,extended,24110003//" + Environment.NewLine +
            "patch = 1,EE,D035A5D2,extended,0000FFF7//" + Environment.NewLine +
            "patch = 1, EE,201E8210,extended,00A0882D//" + Environment.NewLine +

            "//skin [Start+R1 Kadonashi]//" + Environment.NewLine +
            "patch = 1, EE, D035A5D2, extended,0000F7F7//" + Environment.NewLine +
            "patch = 1,EE,201E8210,extended,24110010//" + Environment.NewLine +
            "patch = 1,EE,D035A5D2,extended,0000FFF7//" + Environment.NewLine +
            "patch = 1, EE,201E8210,extended,00A0882D//" + Environment.NewLine +


            "//skin [L1+R1 KG (Damaged)]//" + Environment.NewLine +
            "patch = 1, EE, D035A5D2, extended,0000F3FF//" + Environment.NewLine +
            "patch = 1, EE,201E8210,extended,2411003E//" + Environment.NewLine +
            "patch = 1,EE,D035A5D2,extended,0000FFF7//" + Environment.NewLine +
            "patch = 1, EE,201E8210,extended,00A0882D//" + Environment.NewLine +

            "//skin [L2+R2 GD 04 (Old Model)]//" + Environment.NewLine +
            "patch = 1, EE, D035A5D2, extended,0000FCFF//" + Environment.NewLine +
            "patch = 1, EE,201E8210,extended,24110044//" + Environment.NewLine +
            "patch = 1,EE,D035A5D2,extended,0000FFF7//" + Environment.NewLine +
            "patch = 1, EE,201E8210,extended,00A0882D//" + Environment.NewLine +

            "//skin [L3+R3 Brad Hawk]//" + Environment.NewLine +
            "patch = 1, EE, D035A5D2, extended,0000FFF9//" + Environment.NewLine +
            "patch = 1, EE,201E8210,extended,24110000//" + Environment.NewLine +
            "patch = 1,EE,D035A5D2,extended,0000FFF7//" + Environment.NewLine +
            "patch = 1, EE,201E8210,extended,00A0882D//" + Environment.NewLine +

            "//skin [Start+Select Bordin]//" + Environment.NewLine +
            "patch = 1, EE, D035A5D2, extended,0000FFF6//" + Environment.NewLine +
            "patch = 1, EE,201E8210,extended,24110037//" + Environment.NewLine +
            "patch = 1,EE,D035A5D2,extended,0000FFF7//" + Environment.NewLine +
            "patch = 1, EE,201E8210,extended,00A0882D//" + Environment.NewLine +

            "//skin [L1+R1+L2+R2 Brad Hawk (Sunglasses)]//" + Environment.NewLine +
            "patch = 1, EE, D035A5D2, extended,0000F1FF//" + Environment.NewLine +
            "patch = 1, EE,201E8210,extended,24110002//" + Environment.NewLine +
            "patch = 1,EE,D035A5D2,extended,0000FFF7//" + Environment.NewLine +
            "patch = 1, EE,201E8210,extended,00A0882D//" + Environment.NewLine +

            "";

            string europeanPath = SettingsClass.codeFolderPath + @"\" + "AE4BEBD3" + ".pnach";

            if (File.Exists(europeanPath))
            {
                File.Delete(europeanPath);
            }

            File.WriteAllText(europeanPath, "\n" + baseCode, new UTF8Encoding(false));
        }


        public static void ProtagonistTeam()
        {
            baseCode = "//P3" + Environment.NewLine +
                "patch=1,EE,105B8EB8,extended,03E8 //STK" + Environment.NewLine +
                "patch=1,EE,105B8EBA,extended,03E8 //GRP" + Environment.NewLine +
                "patch=1,EE,105B8EBC,extended,04B0 //RGA" + Environment.NewLine +
                "patch=1,EE,105B8EBE,extended,0578 //SPA" + Environment.NewLine +
                "patch=1,EE,105B8EC0,extended,04B0 //WPA" + Environment.NewLine +
                "patch=1,EE,105B8EC2,extended,04B0 //TGH" + Environment.NewLine +
                "patch=1,EE,105B8E72,extended,01F4 //HDE" + Environment.NewLine +
                "patch=1,EE,105B8E78,extended,00FA //HDE Balance" + Environment.NewLine +
                "patch=1,EE,105B8E74,extended,01F4 //UBE" + Environment.NewLine +
                "patch=1,EE,105B8E7A,extended,00FA //UBE Balance" + Environment.NewLine +
                "patch=1,EE,105B8E76,extended,01F4 //LBE" + Environment.NewLine +
                "patch=1,EE,105B8E7C,extended,00FA //LBE Balance" + Environment.NewLine +
                "patch=1,EE,105B8E92,extended,01B0 //SPA Gauge" + Environment.NewLine +
                "patch=1,EE,205B8EA2,extended,3F80 //SPA Down Red Bar Color" + Environment.NewLine +
                "patch=1,EE,205B8EA6,extended,3F20 //SPA Down Green Bar Color" + Environment.NewLine +
                "patch=1,EE,205B8EAA,extended,3F20 //SPA Down Blue Bar Color" + Environment.NewLine +
                "patch=1,EE,205B8EAE,extended,3F20 //SPA Down Alpha Bar Color" + Environment.NewLine +
                "patch=1,EE,205B8EB0,extended,0002 //SPA Down" + Environment.NewLine +
                "patch=1,EE,205B8EB4,extended,44DF8000 //Infinite Spa Down" + Environment.NewLine +
                "patch=1,EE,205B0044,extended,0035 //Moves & Skin 1" + Environment.NewLine +
                "patch=1,EE,2094A63C,extended,0035 //Moves & Skin 2" + Environment.NewLine +
                "//P4" + Environment.NewLine +
                "patch=1,EE,105C2608,extended,04B0 //STK" + Environment.NewLine +
                "patch=1,EE,105C260A,extended,0320 //GRP" + Environment.NewLine +
                "patch=1,EE,105C260C,extended,0320 //RGA" + Environment.NewLine +
                "patch=1,EE,105C260E,extended,0384 //SPA" + Environment.NewLine +
                "patch=1,EE,105C2610,extended,0320 //WPA" + Environment.NewLine +
                "patch=1,EE,105C2612,extended,0384 //TGH" + Environment.NewLine +
                "patch=1,EE,105C25C2,extended,015E //HDE" + Environment.NewLine +
                "patch=1,EE,105C25C8,extended,00AF //HDE Balance" + Environment.NewLine +
                "patch=1,EE,105C25C4,extended,015E //UBE" + Environment.NewLine +
                "patch=1,EE,105C25CA,extended,00AF //UBE Balance" + Environment.NewLine +
                "patch=1,EE,105C25C6,extended,015E //LBE" + Environment.NewLine +
                "patch=1,EE,105C25CC,extended,00AF //LBE Balance" + Environment.NewLine +
                "patch=1,EE,205C25F2,extended,3F20 //SPA Down Red Bar Color" + Environment.NewLine +
                "patch=1,EE,205C25F6,extended,3F20 //SPA Down Green Bar Color" + Environment.NewLine +
                "patch=1,EE,205C25FA,extended,3F80 //SPA Down Blue Bar Color" + Environment.NewLine +
                "patch=1,EE,205C25FE,extended,3F80 //SPA Down Alpha Bar Color" + Environment.NewLine +
                "patch=1,EE,205C2600,extended,0003 //SPA Down" + Environment.NewLine +
                "patch=1,EE,205C2604,extended,44DF8000 //Infinite Spa Down" + Environment.NewLine +
                "patch=1,EE,205B9794,extended,000F //Moves & Skin 1" + Environment.NewLine +
                "patch=1,EE,2094A640,extended,000F //Moves & Skin 2" + Environment.NewLine +
            "";

            ExportPnach.ExportFile(baseCode);
        }



        
    }
}
