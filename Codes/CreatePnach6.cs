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

namespace UR_pnach_editor.Codes
{
    public class CreatePnach6
    {
        static string baseCode = "";


        public static void ModifyGun(string upValue, string frontValue, string downValue, string aiValue)
        {
            /*
            "Regular shoot",
            "3 bullets in a row",
            "Hidden gun trick",
            "Punch gun",
            "Shovel bullet combo",
            "Knife bullet combo",
            "SPA bullet blowout",
            "SPA sword slash",
            "Ultimate Uzi",
            "Delayed bullet",
             */

            string upCode = "";
            string frontCode = "";
            string downCode = "";
            string extraCode = "";

            string upAddress = "2058A924";
            string frontAddress = "2058A922";
            string downAddress = "2058A926";
            string extraAddress = "20546640";

            switch (upValue)
            {
                case "Regular shoot" :
                    upCode = "patch=1,EE," + upAddress + ",extended,0A90 //Regular shoot";
                    break;
                case "3 bullets in a row":
                    upCode = "patch=1,EE," + upAddress + ",extended,05A7 //3 bullets in a row";
                    break;
                case "Hidden gun trick":
                    upCode = "patch=1,EE," + upAddress + ",extended,04F4 //Hidden gun trick";
                    break;
                case "Punch gun":
                    upCode = "patch=1,EE," + upAddress + ",extended,04F0 //Punch gun";
                    break;
                case "Shovel bullet combo":
                    upCode = "patch=1,EE," + upAddress + ",extended,05A2 //Shovel bullet combo";
                    break;
                case "Knife bullet combo":
                    upCode = "patch=1,EE," + upAddress + ",extended,0596 //Knife bullet combo";
                    break;
                case "SPA bullet blowout":
                    upCode = "patch=1,EE," + upAddress + ",extended,05A1 //SPA bullet blowout";
                    break;
                case "SPA sword slash":
                    upCode = "patch=1,EE," + upAddress + ",extended,059F //SPA sword slash";
                    break;
                case "Ultimate Uzi":
                    upCode = "patch=1,EE," + upAddress + ",extended,05AA //Ultimate Uzi";
                    extraCode = "patch=1,EE," + extraAddress + ",extended,05AA //Ultimate Uzi infinity";
                    break;
                case "Delayed bullet":
                    upCode = "patch=1,EE," + upAddress + ",extended,04F8 //Delayed bullet";
                    break;
            }

            switch (frontValue)
            {
                case "Regular shoot":
                    frontCode = "patch=1,EE," + frontAddress + ",extended,0A90 //Regular shoot";
                    break;
                case "3 bullets in a row":
                    frontCode = "patch=1,EE," + frontAddress + ",extended,05A7 //3 bullets in a row";
                    break;
                case "Hidden gun trick":
                    frontCode = "patch=1,EE," + frontAddress + ",extended,04F4 //Hidden gun trick";
                    break;
                case "Punch gun":
                    frontCode = "patch=1,EE," + frontAddress + ",extended,04F0 //Punch gun";
                    break;
                case "Shovel bullet combo":
                    frontCode = "patch=1,EE," + frontAddress + ",extended,05A2 //Shovel bullet combo";
                    break;
                case "Knife bullet combo":
                    frontCode = "patch=1,EE," + frontAddress + ",extended,0596 //Knife bullet combo";
                    break;
                case "SPA bullet blowout":
                    frontCode = "patch=1,EE," + frontAddress + ",extended,05A1 //SPA bullet blowout";
                    break;
                case "SPA sword slash":
                    frontCode = "patch=1,EE," + frontAddress + ",extended,059F //SPA sword slash";
                    break;
                case "Ultimate Uzi":
                    frontCode = "patch=1,EE," + frontAddress + ",extended,05AA //Ultimate Uzi";
                    extraCode = "patch=1,EE," + extraAddress + ",extended,05AA //Ultimate Uzi infinity";
                    break;
                case "Delayed bullet":
                    frontCode = "patch=1,EE," + frontAddress + ",extended,04F8 //Delayed bullet";
                    break;
            }

            switch (downValue)
            {
                case "Regular shoot":
                    downCode = "patch=1,EE," + downAddress + ",extended,0A90 //Regular shoot";
                    break;
                case "3 bullets in a row":
                    downCode = "patch=1,EE," + downAddress + ",extended,05A7 //3 bullets in a row";
                    break;
                case "Hidden gun trick":
                    downCode = "patch=1,EE," + downAddress + ",extended,04F4 //Hidden gun trick";
                    break;
                case "Punch gun":
                    downCode = "patch=1,EE," + downAddress + ",extended,04F0 //Punch gun";
                    break;
                case "Shovel bullet combo":
                    downCode = "patch=1,EE," + downAddress + ",extended,05A2 //Shovel bullet combo";
                    break;
                case "Knife bullet combo":
                    downCode = "patch=1,EE," + downAddress + ",extended,0596 //Knife bullet combo";
                    break;
                case "SPA bullet blowout":
                    downCode = "patch=1,EE," + downAddress + ",extended,05A1 //SPA bullet blowout";
                    break;
                case "SPA sword slash":
                    downCode = "patch=1,EE," + downAddress + ",extended,059F //SPA sword slash";
                    break;
                case "Ultimate Uzi":
                    downCode = "patch=1,EE," + downAddress + ",extended,05AA //Ultimate Uzi";
                    extraCode = "patch=1,EE," + extraAddress + ",extended,05AA //Ultimate Uzi infinity";
                    break;
                case "Delayed bullet":
                    downCode = "patch=1,EE," + downAddress + ",extended,04F8 //Delayed bullet";
                    break;
            }

            string ai = "";
            if (aiValue == "Yes")
            {
                ai =
                "patch=1,EE,205A5F94,extended,00040004 //cpu 1 uses gun" + Environment.NewLine +
                "patch=1,EE,205AF6E4,extended,00040004 //cpu 2 uses gun" + Environment.NewLine +
                "patch=1,EE,205B8E34,extended,00040004 //cpu 3 uses gun" + Environment.NewLine +
                "patch=1,EE,205C2584,extended,00040004 //cpu 4 uses gun";
            }


            baseCode =
                "patch=1,EE,1027E484,extended,00000000 //infinite ammo" + Environment.NewLine +
                "patch=1,EE,1027E488,extended,00000000 //infinite ammo" + Environment.NewLine +
                extraCode + Environment.NewLine +
                frontCode + Environment.NewLine +
                upCode + Environment.NewLine +
                downCode + Environment.NewLine +
                ai;

            ExportPnach.ExportFile(baseCode);
        }

        public static void SupremeOutlaw()
        {
            baseCode = "//P3" + Environment.NewLine +
                "patch=1,EE,105C2506,extended,0000 //P4 team" + Environment.NewLine +
                "patch=1,EE,105B8EB8,extended,0834 //STK" + Environment.NewLine +
                "patch=1,EE,105B8EBA,extended,0898 //GRP" + Environment.NewLine +
                "patch=1,EE,105B8EBC,extended,0640 //RGA" + Environment.NewLine +
                "patch=1,EE,105B8EBE,extended,07D0 //SPA" + Environment.NewLine +
                "patch=1,EE,105B8EC0,extended,0320 //WPA" + Environment.NewLine +
                "patch=1,EE,105B8EC2,extended,07D0 //TGH" + Environment.NewLine +
                "patch=1,EE,105B8E72,extended,0258 //HDE" + Environment.NewLine +
                "patch=1,EE,105B8E78,extended,012C //HDE Balance" + Environment.NewLine +
                "patch=1,EE,105B8E74,extended,028A //UBE" + Environment.NewLine +
                "patch=1,EE,105B8E7A,extended,0145 //UBE Balance" + Environment.NewLine +
                "patch=1,EE,105B8E76,extended,0258 //LBE" + Environment.NewLine +
                "patch=1,EE,105B8E7C,extended,012C //LBE Balance" + Environment.NewLine +
                "patch=1,EE,205B8E34,extended,000C000C //P4 AI" + Environment.NewLine +
                "patch=1,EE,205B8EA2,extended,3F80 //SPA Down Red Bar Color" + Environment.NewLine +
                "patch=1,EE,205B8EA6,extended,3E20 //SPA Down Green Bar Color" + Environment.NewLine +
                "patch=1,EE,205B8EAA,extended,3E80 //SPA Down Blue Bar Color" + Environment.NewLine +
                "patch=1,EE,205B8EAE,extended,3F80 //SPA Down Alpha Bar Color" + Environment.NewLine +
                "patch=1,EE,205B8EB0,extended,0005 //SPA Down" + Environment.NewLine +
                "patch=1,EE,205B8EB4,extended,44DF8000 //Infinite Spa Down" + Environment.NewLine +
                "patch=1,EE,105B8F10,extended,0002 //SPA Regained" + Environment.NewLine +
                "patch=1,EE,205B0044,extended,002C //Moves & Skin 1" + Environment.NewLine +
                "patch=1,EE,2094A63C,extended,002C //Moves & Skin 2" + Environment.NewLine +
            "";

            ExportPnach.ExportFile(baseCode);
        }

        public static void OneVersusThree()
        {
            baseCode = "//" + Environment.NewLine +
            "patch=1,EE,105A5F16,extended,0000 //P1 team" + Environment.NewLine +
            "patch=1,EE,105AF666,extended,0001 //P2 team" + Environment.NewLine +
            "patch=1,EE,105B8DB6,extended,0001 //P3 team" + Environment.NewLine +
            "patch=1,EE,105C2506,extended,0001 //P4 team" + Environment.NewLine +
            "";

            ExportPnach.ExportFile(baseCode);
        }

        public static void BossAndUnderboss()
        {
            baseCode =
            "patch=1,EE,1027E484,extended,00000000 //infinite ammo" + Environment.NewLine +
            "patch=1,EE,1027E488,extended,00000000 //infinite ammo" + Environment.NewLine +
            "//P3" + Environment.NewLine +
            "patch=1,EE,105B8EC0,extended,0BB8 //WPA" + Environment.NewLine +
            "patch=1,EE,105B8EC2,extended,03E8 //TGH" + Environment.NewLine +
            "patch=1,EE,205B0044,extended,003D //Moves & Skin 2" + Environment.NewLine +
            "patch=1,EE,205B8E34,extended,00040004 //P3 AI" + Environment.NewLine +
            "patch=1,EE,2058A922,extended,05A7 //Uzi" + Environment.NewLine +
            "patch=1,EE,2094A63C,extended,003D //Moves & Skin 2" + Environment.NewLine +
            "patch=1,EE,2094A63C,extended,003D //Moves & Skin 2" + Environment.NewLine + 
            "//P4" + Environment.NewLine +
            "patch=1,EE,105C2612,extended,05DC //TGH" + Environment.NewLine +
            "patch=1,EE,205C2584,extended,000C000C //P4 AI" + Environment.NewLine +
            "patch=1,EE,205C25F2,extended,3F80 //SPA Down Red Bar Color" + Environment.NewLine +
            "patch=1,EE,205C25F6,extended,3E20 //SPA Down Green Bar Color" + Environment.NewLine +
            "patch=1,EE,205C25FA,extended,3E80 //SPA Down Blue Bar Color" + Environment.NewLine +
            "patch=1,EE,205C25FE,extended,3F80 //SPA Down Alpha Bar Color" + Environment.NewLine +
            "patch=1,EE,205C2600,extended,0005 //SPA Down" + Environment.NewLine +
            "patch=1,EE,205C2604,extended,44DF8000 //Infinite Spa Down" + Environment.NewLine +
            "patch=1,EE,205B9794,extended,002D //Moves & Skin 1" + Environment.NewLine +
            "patch=1,EE,2094A640,extended,002D //Moves & Skin 2" + Environment.NewLine +
            "" + Environment.NewLine +
            "patch=1,EE,2094A648,extended,00160000 //enemies with weapons" + Environment.NewLine +
            ""; 

            ExportPnach.ExportFile(baseCode);
        }

        public static void BrainwashBoss()
        {
            int slavePick = 0;
            slavePick = new Random().Next(1, 7);

            int slave1 = 0;
            int slave2 = 0;
            int slave3 = 0;
            switch (slavePick)
            {
                case 1:
                    slave1 = 1;
                    slave2 = 2;
                    slave3 = 4;
                    break;
                case 2:
                    slave1 = 1;
                    slave2 = 4;
                    slave3 = 2;
                    break;
                case 3:
                    slave1 = 2;
                    slave2 = 1;
                    slave3 = 4;
                    break;
                case 4:
                    slave1 = 2;
                    slave2 = 4;
                    slave3 = 1;
                    break;
                case 5:
                    slave1 = 4;
                    slave2 = 1;
                    slave3 = 2;
                    break;
                case 6:
                    slave1 = 4;
                    slave2 = 2;
                    slave3 = 1;
                    break;
            }

            string slave1Code = "";
            switch (slave1)
            {
                case 1:
                    slave1Code = "105A5F16";
                    break;
                case 2:
                    slave1Code = "105AF666";
                    break;
                case 4:
                    slave1Code = "105C2506";
                    break;
            }
            string slave2Code = "";
            switch (slave2)
            {
                case 1:
                    slave2Code = "105A5F16";
                    break;
                case 2:
                    slave2Code = "105AF666";
                    break;
                case 4:
                    slave2Code = "105C2506";
                    break;
            }
            string slave3Code = "";
            switch (slave3)
            {
                case 1:
                    slave3Code = "105A5F16";
                    break;
                case 2:
                    slave3Code = "105AF666";
                    break;
                case 4:
                    slave3Code = "105C2506";
                    break;
            }



            baseCode =
            "patch=1,EE,D05AF718,extended,000005DC //if P3 hp = 1500" + Environment.NewLine +
            "patch=1,EE,105C2506,extended,0000 //P4 team" + Environment.NewLine +
            "patch=1,EE,105B8EC2,extended,07D0 //P3 TGH" + Environment.NewLine +
            "patch=1,EE,D05B8E68,extended,01200465 //if P3 hp is lower than 75%" + Environment.NewLine +
            "patch=1,EE," + slave1Code + ",extended,0001 //P" + slave1 + " team" + Environment.NewLine +
            "patch=1,EE,D05B8E68,extended,012002EE //if P3 hp is lower than 50%" + Environment.NewLine +
            "patch=1,EE," + slave2Code + ",extended,0001 //P" + slave2 + " team" + Environment.NewLine +
            "patch=1,EE,D05B8E68,extended,01200177 //if P3 hp is lower than 25%" + Environment.NewLine +
            "patch=1,EE," + slave3Code + ",extended,0001 //P" + slave3 + " team" + Environment.NewLine +
            "patch=1,EE,D05A5FC8,extended,0120012C //if P1 hp is lower than 20%" + Environment.NewLine +
            "patch=1,EE,105A5F16,extended,0000 //P1 team" + Environment.NewLine +
            "patch=1,EE,D05A5FC8,extended,0120012C //if P1 hp is lower than 20%" + Environment.NewLine +
            "patch=1,EE,105A6022,extended,0BB8 //P1 TGH" + Environment.NewLine +
            "patch=1,EE,D05AF718,extended,0120012C //if P2 hp is lower than 20%" + Environment.NewLine +
            "patch=1,EE,105AF666,extended,0000 //P2 team" + Environment.NewLine +
            "patch=1,EE,D05AF718,extended,0120012C //if P2 hp is lower than 20%" + Environment.NewLine +
            "patch=1,EE,105AF772,extended,0BB8 //P2 TGH" + Environment.NewLine +
            "patch=1,EE,D05C25B8,extended,0120012C //if P4 hp is lower than 20%" + Environment.NewLine +
            "patch=1,EE,105C2506,extended,0000 //P4 team" + Environment.NewLine +
            "patch=1,EE,D05C25B8,extended,0120012C //if P4 hp is lower than 20%" + Environment.NewLine +
            "patch=1,EE,105C2612,extended,0BB8 //P4 TGH" + Environment.NewLine +
            "";

            ExportPnach.ExportFile(baseCode);
        }


        public static void Ultimate7vs1()
        {
            baseCode = "//" + Environment.NewLine +
            //Player 3 is the enemy
            "patch=1,EE,105C2506,extended,0000 //P4 team" + Environment.NewLine +
            "patch=1,EE,105CB7C4,extended,0001 //P5 ON" + Environment.NewLine +
            "patch=1,EE,105CBC56,extended,0000 //P5 team" + Environment.NewLine +
            "patch=1,EE,105CBC58,extended,0001 //P5 controlled by ai 1 [0 = p1 control]" + Environment.NewLine +
            "patch=1,EE,105CBCC4,extended,0001 //P5 controlled by ai 2 [0 = p1 control]" + Environment.NewLine +
            "patch=1,EE,105D4F14,extended,0001 //P6 ON" + Environment.NewLine +
            "patch=1,EE,105D53A6,extended,0000 //P6 team" + Environment.NewLine +
            "patch=1,EE,105D53A8,extended,0001 //P6 controlled by ai 1 [0 = p1 control]" + Environment.NewLine +
            "patch=1,EE,105D5414,extended,0001 //P6 controlled by ai 2 [0 = p1 control]" + Environment.NewLine +
            "patch=1,EE,105DE664,extended,0001 //P7 ON" + Environment.NewLine +
            "patch=1,EE,105DEAF6,extended,0000 //P7 team" + Environment.NewLine +
            "patch=1,EE,105DEAF8,extended,0001 //P7 controlled by ai 1 [0 = p1 control]" + Environment.NewLine +
            "patch=1,EE,105DEB64,extended,0001 //P7 controlled by ai 2 [0 = p1 control]" + Environment.NewLine +
            "patch=1,EE,105E7DB4,extended,0001 //P8 ON" + Environment.NewLine +
            "patch=1,EE,105E8246,extended,0000 //P8 team" + Environment.NewLine +
            "patch=1,EE,105E8248,extended,0001 //P8 controlled by ai 1 [0 = p1 control]" + Environment.NewLine +
            "patch=1,EE,105E82B4,extended,0001 //P8 controlled by ai 2 [0 = p1 control]" + Environment.NewLine +
            "" + Environment.NewLine +
            "patch=1,EE,10ABF670,extended,0000 //no regional ko (prevent bugs)" + Environment.NewLine +
            "patch=1,EE,10ABF674,extended,0000 //no team attack ko (prevent bugs)" + Environment.NewLine +
            "" + Environment.NewLine +
            "patch=1,EE,105A6018,extended,01F4 //STK                   P1" + Environment.NewLine +
            "patch=1,EE,105A601A,extended,01F4 //GRP                   P1" + Environment.NewLine +
            "patch=1,EE,105A601C,extended,01F4 //RGA                   P1" + Environment.NewLine +
            "patch=1,EE,105A601E,extended,01F4 //SPA                   P1" + Environment.NewLine +
            "patch=1,EE,105A6020,extended,01F4 //WPA                   P1" + Environment.NewLine +
            "patch=1,EE,105A6022,extended,03E8 //TGH                   P1" + Environment.NewLine +
            "patch=1,EE,105A5FD2,extended,0320 //HDE                   P1" + Environment.NewLine +
            "patch=1,EE,105A5FD8,extended,0190 //HDE Balance           P1" + Environment.NewLine +
            "patch=1,EE,105A5FD4,extended,0320 //UBE                   P1" + Environment.NewLine +
            "patch=1,EE,105A5FDA,extended,0190 //UBE Balance           P1" + Environment.NewLine +
            "patch=1,EE,105A5FD6,extended,0320 //LBE                   P1" + Environment.NewLine +
            "patch=1,EE,105A5FDC,extended,0190 //LBE Balance           P1" + Environment.NewLine +
            "patch=1,EE,105AF768,extended,01F4 //STK                   P2" + Environment.NewLine +
            "patch=1,EE,105AF76A,extended,01F4 //GRP                   P2" + Environment.NewLine +
            "patch=1,EE,105AF76C,extended,01F4 //RGA                   P2" + Environment.NewLine +
            "patch=1,EE,105AF76E,extended,01F4 //SPA                   P2" + Environment.NewLine +
            "patch=1,EE,105AF770,extended,01F4 //WPA                   P2" + Environment.NewLine +
            "patch=1,EE,105AF772,extended,03E8 //TGH                   P2" + Environment.NewLine +
            "patch=1,EE,105AF722,extended,0320 //HDE                   P2" + Environment.NewLine +
            "patch=1,EE,105AF728,extended,0190 //HDE Balance           P2" + Environment.NewLine +
            "patch=1,EE,105AF724,extended,0320 //UBE                   P2" + Environment.NewLine +
            "patch=1,EE,105AF72A,extended,0190 //UBE Balance           P2" + Environment.NewLine +
            "patch=1,EE,105AF726,extended,0320 //LBE                   P2" + Environment.NewLine +
            "patch=1,EE,105AF72C,extended,0190 //LBE Balance           P2" + Environment.NewLine +
            "patch=1,EE,105B8EB8,extended,07D0 //STK                   P3" + Environment.NewLine +
            "patch=1,EE,105B8EBA,extended,07D0 //GRP                   P3" + Environment.NewLine +
            "patch=1,EE,105B8EBC,extended,07D0 //RGA                   P3" + Environment.NewLine +
            "patch=1,EE,105B8EBE,extended,07D0 //SPA                   P3" + Environment.NewLine +
            "patch=1,EE,105B8EC0,extended,07D0 //WPA                   P3" + Environment.NewLine +
            "patch=1,EE,105B8EC2,extended,07D0 //TGH                   P3" + Environment.NewLine +
            "patch=1,EE,105B8E72,extended,03E8 //HDE                   P3" + Environment.NewLine +
            "patch=1,EE,105B8E78,extended,01F4 //HDE Balance           P3" + Environment.NewLine +
            "patch=1,EE,105B8E74,extended,03E8 //UBE                   P3" + Environment.NewLine +
            "patch=1,EE,105B8E7A,extended,01F4 //UBE Balance           P3" + Environment.NewLine +
            "patch=1,EE,105B8E76,extended,03E8 //LBE                   P3" + Environment.NewLine +
            "patch=1,EE,105B8E7C,extended,01F4 //LBE Balance           P3" + Environment.NewLine +
            "patch=1,EE,105B8F10,extended,00000032 //SPA Regained      P3" + Environment.NewLine +
            "patch=1,EE,105C2608,extended,01F4 //STK                   P4" + Environment.NewLine +
            "patch=1,EE,105C260A,extended,01F4 //GRP                   P4" + Environment.NewLine +
            "patch=1,EE,105C260C,extended,01F4 //RGA                   P4" + Environment.NewLine +
            "patch=1,EE,105C260E,extended,01F4 //SPA                   P4" + Environment.NewLine +
            "patch=1,EE,105C2610,extended,01F4 //WPA                   P4" + Environment.NewLine +
            "patch=1,EE,105C2612,extended,03E8 //TGH                   P4" + Environment.NewLine +
            "patch=1,EE,105C25C2,extended,0320 //HDE                   P4" + Environment.NewLine +
            "patch=1,EE,105C25C8,extended,0190 //HDE Balance           P4" + Environment.NewLine +
            "patch=1,EE,105C25C4,extended,0320 //UBE                   P4" + Environment.NewLine +
            "patch=1,EE,105C25CA,extended,0190 //UBE Balance           P4" + Environment.NewLine +
            "patch=1,EE,105C25C6,extended,0320 //LBE                   P4" + Environment.NewLine +
            "patch=1,EE,105C25CC,extended,0190 //LBE Balance           P4" + Environment.NewLine +
            "patch=1,EE,105CBD58,extended,01F4 //STK          		   P5" + Environment.NewLine +
            "patch=1,EE,105CBD5A,extended,01F4 //GRP          		   P5" + Environment.NewLine +
            "patch=1,EE,105CBD5C,extended,01F4 //RGA          		   P5" + Environment.NewLine +
            "patch=1,EE,105CBD5E,extended,01F4 //SPA          		   P5" + Environment.NewLine +
            "patch=1,EE,105CBD60,extended,01F4 //WPA          		   P5" + Environment.NewLine +
            "patch=1,EE,105CBD62,extended,01F4 //TGH          		   P5" + Environment.NewLine +
            "patch=1,EE,105CBD12,extended,0320 //HDE          		   P5" + Environment.NewLine +
            "patch=1,EE,105CBD18,extended,0190 //HDE Balance  		   P5" + Environment.NewLine +
            "patch=1,EE,105CBD14,extended,0320 //UBE          		   P5" + Environment.NewLine +
            "patch=1,EE,105CBD1A,extended,0190 //UBE Balance  		   P5" + Environment.NewLine +
            "patch=1,EE,105CBD16,extended,0320 //LBE          		   P5" + Environment.NewLine +
            "patch=1,EE,105CBD1C,extended,0190 //LBE Balance  		   P5" + Environment.NewLine +
            "patch=1,EE,105D54A8,extended,01F4 //STK          		   P5" + Environment.NewLine +
            "patch=1,EE,105D54AA,extended,01F4 //GRP          		   P6" + Environment.NewLine +
            "patch=1,EE,105D54AC,extended,01F4 //RGA          		   P6" + Environment.NewLine +
            "patch=1,EE,105D54AE,extended,01F4 //SPA          		   P6" + Environment.NewLine +
            "patch=1,EE,105D54B0,extended,01F4 //WPA          		   P6" + Environment.NewLine +
            "patch=1,EE,105D54B2,extended,01F4 //TGH          		   P6" + Environment.NewLine +
            "patch=1,EE,105D5462,extended,0320 //HDE          		   P6" + Environment.NewLine +
            "patch=1,EE,105D5468,extended,0190 //HDE Balance  		   P6" + Environment.NewLine +
            "patch=1,EE,105D5464,extended,0320 //UBE          		   P6" + Environment.NewLine +
            "patch=1,EE,105D546A,extended,0190 //UBE Balance  		   P6" + Environment.NewLine +
            "patch=1,EE,105D5466,extended,0320 //LBE          		   P6" + Environment.NewLine +
            "patch=1,EE,105D546C,extended,0190 //LBE Balance  		   P6" + Environment.NewLine +
            "patch=1,EE,105DEBF8,extended,01F4 //STK          		   P7" + Environment.NewLine +
            "patch=1,EE,105DEBFA,extended,01F4 //GRP          		   P7" + Environment.NewLine +
            "patch=1,EE,105DEBFC,extended,01F4 //RGA          		   P7" + Environment.NewLine +
            "patch=1,EE,105DEBFE,extended,01F4 //SPA          		   P7" + Environment.NewLine +
            "patch=1,EE,105DEC00,extended,01F4 //WPA          		   P7" + Environment.NewLine +
            "patch=1,EE,105DEC02,extended,01F4 //TGH          		   P7" + Environment.NewLine +
            "patch=1,EE,105DEBB2,extended,0320 //HDE          		   P7" + Environment.NewLine +
            "patch=1,EE,105DEBB8,extended,0190 //HDE Balance  		   P7" + Environment.NewLine +
            "patch=1,EE,105DEBB4,extended,0320 //UBE          		   P7" + Environment.NewLine +
            "patch=1,EE,105DEBBA,extended,0190 //UBE Balance  		   P7" + Environment.NewLine +
            "patch=1,EE,105DEBB6,extended,0320 //LBE          		   P7" + Environment.NewLine +
            "patch=1,EE,105DEBBC,extended,0190 //LBE Balance  		   P7" + Environment.NewLine +
            "patch=1,EE,105E8348,extended,01F4 //STK          		   P8" + Environment.NewLine +
            "patch=1,EE,105E834A,extended,01F4 //GRP          		   P8" + Environment.NewLine +
            "patch=1,EE,105E834C,extended,01F4 //RGA          		   P8" + Environment.NewLine +
            "patch=1,EE,105E834E,extended,01F4 //SPA          		   P8" + Environment.NewLine +
            "patch=1,EE,105E8350,extended,01F4 //WPA          		   P8" + Environment.NewLine +
            "patch=1,EE,105E8352,extended,01F4 //TGH          		   P8" + Environment.NewLine +
            "patch=1,EE,105E8302,extended,0320 //HDE          		   P8" + Environment.NewLine +
            "patch=1,EE,105E8308,extended,0190 //HDE Balance  		   P8" + Environment.NewLine +
            "patch=1,EE,105E8304,extended,0320 //UBE          		   P8" + Environment.NewLine +
            "patch=1,EE,105E830A,extended,0190 //UBE Balance  		   P8" + Environment.NewLine +
            "patch=1,EE,105E8306,extended,0320 //LBE          		   P8" + Environment.NewLine +
            "patch=1,EE,105E830C,extended,0190 //LBE Balance  		   P8" + Environment.NewLine +
            "" + Environment.NewLine +
            "patch=1,EE,205B8E34,extended,000C000C //P3 AI (set to Golem story)" + Environment.NewLine +
            "patch=1,EE,205B9794,extended,00000000 //P4 Character" + Environment.NewLine +
            "patch=1,EE,205C2584,extended,00300030 //P4 AI (set to McKinzie story)" + Environment.NewLine +
            "patch=1,EE,2094A640,extended,00000000 //P4 Character" + Environment.NewLine +
            "patch=1,EE,205CBCD4,extended,002F002F //P5 AI (set to McKinzie2 story)" + Environment.NewLine +
            "patch=1,EE,205C2EE4,extended,00000026 //P5 char SKIN (set to Anderson)" + Environment.NewLine +
            //"patch=1,EE,20953D90,extended,0000002B //P5 this sets character stats   [not working]" + Environment.NewLine +
            "patch=1,EE,205D5424,extended,002F002F //P6 AI (set to McKinzie2 story)" + Environment.NewLine +
            "patch=1,EE,205CC634,extended,00000025 //P6 char SKIN (set to Cooper)" + Environment.NewLine +
            //"patch=1,EE,2095D4E0,extended,0000002B //P6 this sets character stats   [not working]" + Environment.NewLine +
            "patch=1,EE,205DEB74,extended,002F002F //P7 AI (set to McKinzie2 story)" + Environment.NewLine +
            "patch=1,EE,205D5D84,extended,00000027 //P7 char SKIN (set to Taylor)" + Environment.NewLine +
            //"patch=1,EE,20966C30,extended,0000002B //P7 this sets character stats   [not working]" + Environment.NewLine +
            "patch=1,EE,205E82C4,extended,002F002F //P8 AI (set to McKinzie2 story)" + Environment.NewLine +
            "patch=1,EE,205DF4D4,extended,00000046 //P8 char SKIN (set to Bain with Mask)" + Environment.NewLine +
            //"patch=1,EE,20970380,extended,0000002B //P8 this sets character stats   [not working]" + Environment.NewLine +
            "";

            ExportPnach.ExportFile(baseCode);
        }


        public static void FourVsFour()
        {
            baseCode = "//" + Environment.NewLine +
            "patch=1,EE,105CB7C4,extended,0001 //P5 ON" + Environment.NewLine +
            "patch=1,EE,105CBC56,extended,0001 //P5 team" + Environment.NewLine +
            "patch=1,EE,105CBC58,extended,0001 //P5 controlled by ai 1 [0 = p1 control]" + Environment.NewLine +
            "patch=1,EE,105CBCC4,extended,0001 //P5 controlled by ai 2 [0 = p1 control]" + Environment.NewLine +
            "patch=1,EE,105D4F14,extended,0001 //P6 ON" + Environment.NewLine +
            "patch=1,EE,105D53A6,extended,0001 //P6 team" + Environment.NewLine +
            "patch=1,EE,105D53A8,extended,0001 //P6 controlled by ai 1 [0 = p1 control]" + Environment.NewLine +
            "patch=1,EE,105D5414,extended,0001 //P6 controlled by ai 2 [0 = p1 control]" + Environment.NewLine +
            "patch=1,EE,105DE664,extended,0001 //P7 ON" + Environment.NewLine +
            "patch=1,EE,105DEAF6,extended,0000 //P7 team" + Environment.NewLine +
            "patch=1,EE,105DEAF8,extended,0001 //P7 controlled by ai 1 [0 = p1 control]" + Environment.NewLine +
            "patch=1,EE,105DEB64,extended,0001 //P7 controlled by ai 2 [0 = p1 control]" + Environment.NewLine +
            "patch=1,EE,105E7DB4,extended,0001 //P8 ON" + Environment.NewLine +
            "patch=1,EE,105E8246,extended,0000 //P8 team" + Environment.NewLine +
            "patch=1,EE,105E8248,extended,0001 //P8 controlled by ai 1 [0 = p1 control]" + Environment.NewLine +
            "patch=1,EE,105E82B4,extended,0001 //P8 controlled by ai 2 [0 = p1 control]" + Environment.NewLine +
            "" + Environment.NewLine +
            "patch=1,EE,10ABF670,extended,0000 //no regional ko (prevent bugs)" + Environment.NewLine +
            "patch=1,EE,10ABF674,extended,0000 //no team attack ko (prevent bugs)" + Environment.NewLine +
            "" + Environment.NewLine +
            "patch=1,EE,105CBD58,extended,01F4 //STK          		   P5" + Environment.NewLine +
            "patch=1,EE,105CBD5A,extended,01F4 //GRP          		   P5" + Environment.NewLine +
            "patch=1,EE,105CBD5C,extended,01F4 //RGA          		   P5" + Environment.NewLine +
            "patch=1,EE,105CBD5E,extended,01F4 //SPA          		   P5" + Environment.NewLine +
            "patch=1,EE,105CBD60,extended,01F4 //WPA          		   P5" + Environment.NewLine +
            "patch=1,EE,105CBD62,extended,01F4 //TGH          		   P5" + Environment.NewLine +
            "patch=1,EE,105CBD12,extended,00FA //HDE          		   P5" + Environment.NewLine +
            "patch=1,EE,105CBD18,extended,007D //HDE Balance  		   P5" + Environment.NewLine +
            "patch=1,EE,105CBD14,extended,00FA //UBE          		   P5" + Environment.NewLine +
            "patch=1,EE,105CBD1A,extended,007D //UBE Balance  		   P5" + Environment.NewLine +
            "patch=1,EE,105CBD16,extended,00FA //LBE          		   P5" + Environment.NewLine +
            "patch=1,EE,105CBD1C,extended,007D //LBE Balance  		   P5" + Environment.NewLine +
            "patch=1,EE,105D54A8,extended,01F4 //STK          		   P5" + Environment.NewLine +
            "patch=1,EE,105D54AA,extended,01F4 //GRP          		   P6" + Environment.NewLine +
            "patch=1,EE,105D54AC,extended,01F4 //RGA          		   P6" + Environment.NewLine +
            "patch=1,EE,105D54AE,extended,01F4 //SPA          		   P6" + Environment.NewLine +
            "patch=1,EE,105D54B0,extended,01F4 //WPA          		   P6" + Environment.NewLine +
            "patch=1,EE,105D54B2,extended,01F4 //TGH          		   P6" + Environment.NewLine +
            "patch=1,EE,105D5462,extended,00FA //HDE          		   P6" + Environment.NewLine +
            "patch=1,EE,105D5468,extended,007D //HDE Balance  		   P6" + Environment.NewLine +
            "patch=1,EE,105D5464,extended,00FA //UBE          		   P6" + Environment.NewLine +
            "patch=1,EE,105D546A,extended,007D //UBE Balance  		   P6" + Environment.NewLine +
            "patch=1,EE,105D5466,extended,00FA //LBE          		   P6" + Environment.NewLine +
            "patch=1,EE,105D546C,extended,007D //LBE Balance  		   P6" + Environment.NewLine +
            "patch=1,EE,105DEBF8,extended,01F4 //STK          		   P7" + Environment.NewLine +
            "patch=1,EE,105DEBFA,extended,01F4 //GRP          		   P7" + Environment.NewLine +
            "patch=1,EE,105DEBFC,extended,01F4 //RGA          		   P7" + Environment.NewLine +
            "patch=1,EE,105DEBFE,extended,01F4 //SPA          		   P7" + Environment.NewLine +
            "patch=1,EE,105DEC00,extended,01F4 //WPA          		   P7" + Environment.NewLine +
            "patch=1,EE,105DEC02,extended,01F4 //TGH          		   P7" + Environment.NewLine +
            "patch=1,EE,105DEBB2,extended,00FA //HDE          		   P7" + Environment.NewLine +
            "patch=1,EE,105DEBB8,extended,007D //HDE Balance  		   P7" + Environment.NewLine +
            "patch=1,EE,105DEBB4,extended,00FA //UBE          		   P7" + Environment.NewLine +
            "patch=1,EE,105DEBBA,extended,007D //UBE Balance  		   P7" + Environment.NewLine +
            "patch=1,EE,105DEBB6,extended,00FA //LBE          		   P7" + Environment.NewLine +
            "patch=1,EE,105DEBBC,extended,007D //LBE Balance  		   P7" + Environment.NewLine +
            "patch=1,EE,105E8348,extended,01F4 //STK          		   P8" + Environment.NewLine +
            "patch=1,EE,105E834A,extended,01F4 //GRP          		   P8" + Environment.NewLine +
            "patch=1,EE,105E834C,extended,01F4 //RGA          		   P8" + Environment.NewLine +
            "patch=1,EE,105E834E,extended,01F4 //SPA          		   P8" + Environment.NewLine +
            "patch=1,EE,105E8350,extended,01F4 //WPA          		   P8" + Environment.NewLine +
            "patch=1,EE,105E8352,extended,01F4 //TGH          		   P8" + Environment.NewLine +
            "patch=1,EE,105E8302,extended,00FA //HDE          		   P8" + Environment.NewLine +
            "patch=1,EE,105E8308,extended,007D //HDE Balance  		   P8" + Environment.NewLine +
            "patch=1,EE,105E8304,extended,00FA //UBE          		   P8" + Environment.NewLine +
            "patch=1,EE,105E830A,extended,007D //UBE Balance  		   P8" + Environment.NewLine +
            "patch=1,EE,105E8306,extended,00FA //LBE          		   P8" + Environment.NewLine +
            "patch=1,EE,105E830C,extended,007D //LBE Balance  		   P8" + Environment.NewLine +
            "" + Environment.NewLine +
            "patch=1,EE,205CBCD4,extended,002F002F //P5 AI (set to McKinzie2 story)" + Environment.NewLine +
            "patch=1,EE,205C2EE4,extended,00000021 //P5 char SKIN (set to DR 88)" + Environment.NewLine +
            "patch=1,EE,205D5424,extended,002F002F //P6 AI (set to McKinzie2 story)" + Environment.NewLine +
            "patch=1,EE,205CC634,extended,00000044 //P6 char SKIN (set to GD 04)" + Environment.NewLine +
            "patch=1,EE,205DEB74,extended,00350035 //P7 AI (set to Napalm 99 story)" + Environment.NewLine +
            "patch=1,EE,205D5D84,extended,00000024 //P7 char SKIN (set to Bain)" + Environment.NewLine +
            "patch=1,EE,205E82C4,extended,00350035 //P8 AI (set to Napalm 99 story)" + Environment.NewLine +
            "patch=1,EE,205DF4D4,extended,00000030 //P8 char SKIN (set to Hiro)" + Environment.NewLine +
            "";

            ExportPnach.ExportFile(baseCode);
        }

    }
}
