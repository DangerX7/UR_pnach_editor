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
using System.Runtime.ConstrainedExecution;
using Microsoft.EntityFrameworkCore;
using NAudio.Wave;
using System.Runtime.InteropServices;

namespace UR_pnach_editor.Codes
{
    public class CreatePnach8
    {
        static string baseCode = "";

        public static void TheTrueFinalBoss()
        {
            baseCode = "" +
                       "//Player 1 or 2 needs to be Brad                                                " + Environment.NewLine +
                       "patch=1,EE,105A6070,extended,0020 //SPA Regained                                " + Environment.NewLine +
                       "patch=1,EE,105AF7C0,extended,0020 //SPA Regained                                " + Environment.NewLine +
                       "                                                                                " + Environment.NewLine +
                       "//Bordin Code [Enemy1]                                                          " + Environment.NewLine +
                       "patch=1,EE,0094A64A,extended,16 //player 3 have gun                             " + Environment.NewLine +
                       "patch=1,EE,1027E484,extended,00000000 //infinite ammo                           " + Environment.NewLine +
                       "patch=1,EE,1027E488,extended,00000000 //infinite ammo                           " + Environment.NewLine +
                       "patch=1,EE,105B8E66,extended,0003 //Weapon grip "                 + Environment.NewLine +
                       "patch=1,EE,205B8E34,extended,00040004 //cpu 3 uses gun                          " + Environment.NewLine +
                       "patch=1,EE,105B8EC2,extended,01F4 //TGH                                         " + Environment.NewLine +
                       "patch=1,EE,105B8EC0,extended,00C8 //WPA                                         " + Environment.NewLine +
                       "patch=1,EE,205B0044,extended,003D //Moves & Skin 1                              " + Environment.NewLine +
                       "patch=1,EE,2094A63C,extended,003D //Moves & Skin 2                              " + Environment.NewLine +
                       "patch=1,EE,205B8EA2,extended,3F20 //Spa Down Red Bar Color                      " + Environment.NewLine +
                       "patch=1,EE,205B8EA6,extended,3F20 //Spa Down Green Bar Color                    " + Environment.NewLine +
                       "patch=1,EE,205B8EAA,extended,3F80 //Spa Down Blue Bar Color                     " + Environment.NewLine +
                       "patch=1,EE,205B8EAE,extended,3F80 //Spa Down Alpha Bar Color                    " + Environment.NewLine +
                       "patch=1,EE,205B8EB0,extended,0003 //Spa Down                                    " + Environment.NewLine +
                       "patch=1,EE,205B8EB4,extended,44DF8000 //Infinite Spa Down                       " + Environment.NewLine +
                       "patch=1,EE,105B8EC2,extended,1388 //Regular TGH                                 " + Environment.NewLine +
                       "patch=1,EE,D05C25B8,extended,02300600 //If P4 is dead                           " + Environment.NewLine +
                       "patch=1,EE,D05CBD08,extended,01300600 //If P5 is dead                           " + Environment.NewLine +
                       "patch=1,EE,105B8EC2,extended,01F4 //TGH (with Golem and Brad)                   " + Environment.NewLine +
                       "                                                                                " + Environment.NewLine +
                       "//Golem Code [Enemy2]                                                           " + Environment.NewLine +
                       "patch=1,EE,205C2584,extended,000C000C  //P4 AI (set to golem story)             " + Environment.NewLine +
                       "patch=1,EE,205B9794,extended,002D //Moves & Skin 1                              " + Environment.NewLine +
                       "patch=1,EE,2094A640,extended,002D //Moves & Skin 2                              " + Environment.NewLine +
                       "patch=1,EE,205C25F2,extended,3F20 //Spa Down Red Bar Color                      " + Environment.NewLine +
                       "patch=1,EE,205C25F6,extended,3FB0 //Spa Down Green Bar Color                    " + Environment.NewLine +
                       "patch=1,EE,205C25FA,extended,3FB0 //Spa Down Blue Bar Color                     " + Environment.NewLine +
                       "patch=1,EE,205C25FE,extended,3F20 //Spa Down Alpha Bar Color                    " + Environment.NewLine +
                       "patch=1,EE,205C2600,extended,0000 //Spa Down                                    " + Environment.NewLine +
                       "patch=1,EE,D05C2606,extended,02300000 //If SPA is activated                     " + Environment.NewLine +
                       "patch=1,EE,D05C25B8,extended,012005DC //If HP is lower than max [1500]          " + Environment.NewLine +
                       "patch=1,EE,30200001,extended,005C25B8 //Recover Health by 1                     " + Environment.NewLine +
                       "                                                                                " + Environment.NewLine +
                       "//Brad Code [Enemy3]                                                            " + Environment.NewLine +
                       "patch=1,EE,105C2EE4,extended,02 //P5 char set to Brad with sunglasses           " + Environment.NewLine +
                       "patch=1,EE,105CB7C4,extended,01 //P5 ON                                         " + Environment.NewLine +
                       "patch=1,EE,105CBC56,extended,01 //P5 team                                       " + Environment.NewLine +
                       "patch=1,EE,105CBC58,extended,01 //P5 controlled by ai 1 [0 = p1 control]        " + Environment.NewLine +
                       "patch=1,EE,105CBCC4,extended,01 //P5 controlled by ai 2 [0 = p1 control]        " + Environment.NewLine +
                       "patch=1,EE,105CBD58,extended,03E8 //STK                                         " + Environment.NewLine +
                       "patch=1,EE,105CBD5A,extended,03E8 //GRP                                         " + Environment.NewLine +
                       "patch=1,EE,105CBD5C,extended,03E8 //RGA                                         " + Environment.NewLine +
                       "patch=1,EE,105CBD5E,extended,03E8 //SPA                                         " + Environment.NewLine +
                       "patch=1,EE,105CBD60,extended,03E8 //WPA                                         " + Environment.NewLine +
                       "patch=1,EE,105CBD62,extended,03E8 //TGH                                         " + Environment.NewLine +
                       "patch=1,EE,105CBD12,extended,01F4 //HDE                                         " + Environment.NewLine +
                       "patch=1,EE,105CBD18,extended,00FA //HDE Balance                                 " + Environment.NewLine +
                       "patch=1,EE,105CBD14,extended,01F4 //UBE                                         " + Environment.NewLine +
                       "patch=1,EE,105CBD1A,extended,00FA //UBE Balance                                 " + Environment.NewLine +
                       "patch=1,EE,105CBD16,extended,01F4 //LBE                                         " + Environment.NewLine +
                       "patch=1,EE,105CBD1C,extended,00FA //LBE Balance                                 " + Environment.NewLine +
                       "patch=1,EE,205CBD42,extended,4000 //Spa Down Red Bar Color                      " + Environment.NewLine +
                       "patch=1,EE,205CBD46,extended,4000 //Spa Down Green Bar Color                    " + Environment.NewLine +
                       "patch=1,EE,205CBD4A,extended,4000 //Spa Down Blue Bar Color                     " + Environment.NewLine +
                       "patch=1,EE,205CBD4E,extended,4000 //Spa Down Alpha Bar Color                    " + Environment.NewLine +
                       "patch=1,EE,205CBD50,extended,0000 //Spa Down                                    " + Environment.NewLine +
                       "patch=1,EE,D05CBD56,extended,01300000 //If SPA is activated                     " + Environment.NewLine +
                       "patch=1,EE,105CBD58,extended,0BB8 //STK                                         " + Environment.NewLine +
                       "patch=1,EE,D05CBD56, extended,01300000 //If SPA is activated                    " + Environment.NewLine +
                       "patch=1,EE,105CBD5A,extended,0BB8 //GRP                                         " + Environment.NewLine +
                       "patch=1,EE,D05CBD56, extended,01300000 //If SPA is activated                    " + Environment.NewLine +
                       "patch=1,EE,105CBD5C,extended,0BB8 //RGA                                         " + Environment.NewLine +
                       "patch=1,EE,D05CBD56, extended,01300000 //If SPA is activated                    " + Environment.NewLine +
                       "patch=1,EE,105CBD5E,extended,0BB8 //SPA                                         " + Environment.NewLine +
                       "patch=1,EE,D05CBD56, extended,01300000 //If SPA is activated                    " + Environment.NewLine +
                       "patch=1,EE,105CBD60,extended,0BB8 //WPA                                         " + Environment.NewLine +
                       "patch=1,EE,D05CBD56, extended,01300000 //If SPA is activated                    " + Environment.NewLine +
                       "patch=1,EE,105CBD62,extended,0BB8 //TGH                                         " + Environment.NewLine +
                       "patch=1,EE,205CBCD4,extended,003A003A  //P5 AI (set to golem story)             " + Environment.NewLine +
            "";

            ExportPnach.ExportFile(baseCode);
        }

        public static void TheRockAndTheFlash()
        {
            baseCode = "" +
                       "//Enemy 1 Golem                                                               " + Environment.NewLine +
                       "patch=1,EE,105B8EBA,extended,07D0 //GRP                                " + Environment.NewLine +
                       "patch=1,EE,105B8EC2,extended,0BB8 //TGH                                " + Environment.NewLine +
                       "patch=1,EE,205B0044,extended,002D //Moves & Skin 1                               " + Environment.NewLine +
                       "patch=1,EE,205B8E34,extended,000C000C //P3 AI                              " + Environment.NewLine +
                       "patch=1,EE,2094A63C,extended,002D //Moves & Skin 2                               " + Environment.NewLine +
                       "                                                                                " + Environment.NewLine +
                       "//Enemy 2 Lin                                                          " + Environment.NewLine +
                       "patch=1,EE,105C2610,extended,07D0 //WPA                          " + Environment.NewLine +
                       "patch=1,EE,105C2612,extended,03E8 //TGH                        " + Environment.NewLine +
                       "patch=1,EE,105C2BB8,extended,0001 //Auta-Grab                             " + Environment.NewLine +
                       "patch=1,EE,105C2BDA,extended,0000 //Auto-Parry                           " + Environment.NewLine +
                       "patch=1,EE,105B8E96,extended,0000 //SPA Cooldown                       " + Environment.NewLine +
                       "patch=1,EE,1094A64B,extended,05 //Lin have his sword                           " + Environment.NewLine +
                       "patch=1,EE,205B9794,extended,0036 //Moves & Skin 1                            " + Environment.NewLine +
                       "patch=1,EE,205C2584,extended,002F002F //P4 AI                            " + Environment.NewLine +
                       "patch=1,EE,2094A640,extended,0036 //Moves & Skin 2                           " + Environment.NewLine +
            "";

            ExportPnach.ExportFile(baseCode);
        }



        public static void BradAndShinkaiCustomizedTeam()
        {
            baseCode = "" + Environment.NewLine +
                       "//Brad & Shinkai 𝓒𝓾𝓼𝓽𝓸𝓶𝓲𝔃𝓮𝓭 " + Environment.NewLine + 
                            "//switch camera [R2+L3 = ON | R2+R3=OFF]                    " + Environment.NewLine +
                            "patch=1,EE,D0359852,extended,FDFD                           " + Environment.NewLine +
                            "patch=1,EE,004616C0,extended,08                             " + Environment.NewLine +
                            "patch=1,EE,D0359852,extended,FDFD                           " + Environment.NewLine +
                            "patch=1,EE,004614D0,extended,05                             " + Environment.NewLine +
                            "patch=1,EE,D0359852,extended,FDFB                           " + Environment.NewLine +
                            "patch=1,EE,004616C0,extended,00                             " + Environment.NewLine +
                            "patch=1,EE,D0359852,extended,FDFB                           " + Environment.NewLine +
                            "patch=1,EE,004614D0,extended,06                             " + Environment.NewLine +
                       "//Players                                                     " + Environment.NewLine +
                       "patch=1,EE,10ABFA7E,extended,0001 //Enable Weapons          " + Environment.NewLine +
                       "patch=1,EE,D09449FC,extended,0018 //Skip Select Fighter     " + Environment.NewLine +
                       "patch=1,EE,109449FC,extended,0019 //Skip Select Fighter     " + Environment.NewLine +
                       "patch=1,EE,1094A5EC,extended,0000 //FORCE Brad As P1        " + Environment.NewLine +
                       "patch=1,EE,11DA84A0,extended,0035 //FORCE Shinkai As P2     " + Environment.NewLine +
                       "patch=1,EE,11DA84F4,extended,000F //P2 weapon               " + Environment.NewLine +
                       "patch=1,EE,D09449FC,extended,0004 // if Loading Screen      " + Environment.NewLine +
                       "patch=1,EE,105A6552,extended,000F //P1 weapon               " + Environment.NewLine +
                       "patch=1,EE,105A5FC6,extended,0003 //P1 Weapon Grip          " + Environment.NewLine +
                       "patch=1,EE,105AF716,extended,0003 //P2 Weapon Grip          " + Environment.NewLine +
                       "patch=1,EE,205AF6E4,extended,003A003A //Partner A.I         " + Environment.NewLine +
                       "                                                              " + Environment.NewLine +
                       "//Brad                                                        " + Environment.NewLine +
                       "patch=1,EE,D05A6552,extended,000F                        " + Environment.NewLine +
                       "patch=1,EE,10579408,extended,031F                           " + Environment.NewLine +
                       "patch=1,EE,D05A6552,extended,0000                           " + Environment.NewLine +
                       "patch=1,EE,10579408,extended,02F5                           " + Environment.NewLine +
                       "patch=1,EE,D05A6552,extended,000F                           " + Environment.NewLine +
                       "patch=1,EE,10594320,extended,031F                           " + Environment.NewLine +
                       "patch=1,EE,D05A6552,extended,0000                           " + Environment.NewLine +
                       "patch=1,EE,10594320,extended,02D2                           " + Environment.NewLine +
                       "patch=1,EE,D05A6552,extended,000F                           " + Environment.NewLine +
                       "patch=1,EE,1057943A,extended,03C6                           " + Environment.NewLine +
                       "patch=1,EE,D05A6552,extended,0000                        " + Environment.NewLine +
                       "patch=1,EE,1057943A,extended,03C3                           " + Environment.NewLine +
                       "patch=1,EE,D05A6552,extended,000F                        " + Environment.NewLine +
                       "patch=1,EE,10579416,extended,0412                           " + Environment.NewLine +
                       "patch=1,EE,D05A6552,extended,0000                           " + Environment.NewLine +
                       "patch=1,EE,10579416,extended,004C                           " + Environment.NewLine +
                       "patch=1,EE,10579656,extended,0CEC                          " + Environment.NewLine +
                       "                                                              " + Environment.NewLine +
                       "//Brad [▲]                                                    " + Environment.NewLine +
                       "patch=1,EE,10594552,extended,0EB9                          " + Environment.NewLine +
                       "patch=1,EE,10594556,extended,0EB9                          " + Environment.NewLine +
                       "patch=1,EE,1057963A,extended,0EB9                          " + Environment.NewLine +
                       "patch=1,EE,1057963E,extended,0EB9                          " + Environment.NewLine +
                       "patch=1,EE,D05A6552,extended,000F                        " + Environment.NewLine +
                       "patch=1,EE,10579652,extended,0E9C                           " + Environment.NewLine +
                       "patch=1,EE,D05A6552,extended,0000                        " + Environment.NewLine +
                       "patch=1,EE,10579652,extended,0D95                           " + Environment.NewLine +
                       "patch=1,EE,D05A6552,extended,000F                           " + Environment.NewLine +
                       "patch=1,EE,10579670,extended,0E9D                           " + Environment.NewLine +
                       "patch=1,EE,D05A6552,extended,0000                           " + Environment.NewLine +
                       "patch=1,EE,10579670,extended,0D92                           " + Environment.NewLine +
                       "patch=1,EE,D05A6552,extended,000F                           " + Environment.NewLine +
                       "patch=1,EE,1057968E,extended,0E9E                           " + Environment.NewLine +
                       "patch=1,EE,D05A6552,extended,0000                        " + Environment.NewLine +
                       "patch=1,EE,1057968E,extended,0EC4                           " + Environment.NewLine +
                       "patch=1,EE,D05A6552,extended,000F                        " + Environment.NewLine +
                       "patch=1,EE,105796AC,extended,0E9F                           " + Environment.NewLine +
                       "patch=1,EE,D05A6552,extended,0000                           " + Environment.NewLine +
                       "patch=1,EE,105796AC,extended,0C3F                           " + Environment.NewLine +
                       "patch=1,EE,10579650,extended,0CE7                          " + Environment.NewLine +
                       "patch=1,EE,1057968C,extended,0C32                          " + Environment.NewLine +
                       "patch=1,EE,105796AA,extended,0C3D                          " + Environment.NewLine +
                       "patch=1,EE,D05A6552,extended,000F                        " + Environment.NewLine +
                       "patch=1,EE,20579694,extended,0E850EE8                       " + Environment.NewLine +
                       "patch=1,EE,D05A6552,extended,0000                        " + Environment.NewLine +
                       "patch=1,EE,20579694,extended,0E6E0E6D                       " + Environment.NewLine +
                       "patch=1,EE,D05A6552,extended,000F                        " + Environment.NewLine +
                       "patch=1,EE,10579658,extended,0E7E                           " + Environment.NewLine +
                       "patch=1,EE,D05A6552,extended,0000                        " + Environment.NewLine +
                       "patch=1,EE,10579658,extended,0EDF                           " + Environment.NewLine +
                       "                                                              " + Environment.NewLine +
                       "//Brad [⚫]                                                   " + Environment.NewLine +
                       "patch=1,EE,D05A6552,extended,000F                        " + Environment.NewLine +
                       "patch=1,EE,105795E8,extended,0992                           " + Environment.NewLine +
                       "patch=1,EE,D05A6552,extended,0000                           " + Environment.NewLine +
                       "patch=1,EE,105795E8,extended,08AE                           " + Environment.NewLine +
                       "patch=1,EE,D05A6552,extended,000F                        " + Environment.NewLine +
                       "patch=1,EE,105795FA,extended,098D                           " + Environment.NewLine +
                       "patch=1,EE,D05A6552,extended,0000                           " + Environment.NewLine +
                       "patch=1,EE,105795FA,extended,08A6                           " + Environment.NewLine +
                       "patch=1,EE,D05A6552,extended,000F                        " + Environment.NewLine +
                       "patch=1,EE,105795E2,extended,098E                           " + Environment.NewLine +
                       "patch=1,EE,D05A6552,extended,0000                           " + Environment.NewLine +
                       "patch=1,EE,105795E2,extended,04CD                           " + Environment.NewLine +
                       "patch=1,EE,D05A6552,extended,000F                        " + Environment.NewLine +
                       "patch=1,EE,10579618,extended,0990                           " + Environment.NewLine +
                       "patch=1,EE,D05A6552,extended,0000                           " + Environment.NewLine +
                       "patch=1,EE,10579618,extended,08AD                           " + Environment.NewLine +
                       "patch=1,EE,D05A6552,extended,000F                        " + Environment.NewLine +
                       "patch=1,EE,105795D0,extended,0BB6                           " + Environment.NewLine +
                       "patch=1,EE,D05A6552,extended,0000                        " + Environment.NewLine +
                       "patch=1,EE,105795D0,extended,076F                           " + Environment.NewLine +
                       "patch=1,EE,D05A6552,extended,000F                           " + Environment.NewLine +
                       "patch=1,EE,20579614,extended,09940994                       " + Environment.NewLine +
                       "patch=1,EE,D05A6552,extended,0000                           " + Environment.NewLine +
                       "patch=1,EE,20579614,extended,08C108C1                       " + Environment.NewLine +
                       "                                                              " + Environment.NewLine +
                       "//Brad [⚫+▲]                                                 " + Environment.NewLine +
                       "patch=1,EE,D05A6552,extended,000F                        " + Environment.NewLine +
                       "patch=1,EE,10579482,extended,096D                           " + Environment.NewLine +
                       "patch=1,EE,D05A6552,extended,0000                           " + Environment.NewLine +
                       "patch=1,EE,10579482,extended,0489                           " + Environment.NewLine +
                       "patch=1,EE,D05A6552,extended,000F                           " + Environment.NewLine +
                       "patch=1,EE,10579488,extended,0997                           " + Environment.NewLine +
                       "patch=1,EE,D05A6552,extended,0000                           " + Environment.NewLine +
                       "patch=1,EE,10579488,extended,055C                           " + Environment.NewLine +
                       "patch=1,EE,D05A6552,extended,000F                        " + Environment.NewLine +
                       "patch=1,EE,10579486,extended,0A96                           " + Environment.NewLine +
                       "patch=1,EE,D05A6552,extended,0000                        " + Environment.NewLine +
                       "patch=1,EE,10579486,extended,09E3                           " + Environment.NewLine +
                       "                                                              " + Environment.NewLine +
                       "//Shinkai                                                     " + Environment.NewLine +
                       "patch=1,EE,10576194,extended,0D0C                           " + Environment.NewLine +
                       "                                                              " + Environment.NewLine +
                       "//MAX Stats                                                   " + Environment.NewLine +
                       "patch=1,EE,105A6018,extended,03E8 //P1                     " + Environment.NewLine +
                       "patch=1,EE,105A601A,extended,03E8                           " + Environment.NewLine +
                       "patch=1,EE,105A601C,extended,03E8                           " + Environment.NewLine +
                       "patch=1,EE,105A601E,extended,03E8                           " + Environment.NewLine +
                       "patch=1,EE,105A6020,extended,03E8                           " + Environment.NewLine +
                       "patch=1,EE,105A6022,extended,03E8                           " + Environment.NewLine +
                       "patch=1,EE,105A5FD2,extended,01F4                           " + Environment.NewLine +
                       "patch=1,EE,105A5FD4,extended,01F4                           " + Environment.NewLine +
                       "patch=1,EE,105A5FD6,extended,01F4                           " + Environment.NewLine +
                       "patch=1,EE,105AF768,extended,03E8 //P2                      " + Environment.NewLine +
                       "patch=1,EE,105AF76A,extended,03E8                           " + Environment.NewLine +
                       "patch=1,EE,105AF76C,extended,03E8                           " + Environment.NewLine +
                       "patch=1,EE,105AF76E,extended,03E8                           " + Environment.NewLine +
                       "patch=1,EE,105AF770,extended,03E8                           " + Environment.NewLine +
                       "patch=1,EE,105AF772,extended,03E8                           " + Environment.NewLine +
                       "patch=1,EE,105AF722,extended,01F4                           " + Environment.NewLine +
                       "patch=1,EE,105AF724,extended,01F4                           " + Environment.NewLine +
                       "patch=1,EE,105AF726,extended,01F4                           " + Environment.NewLine +
                       "                                                              " + Environment.NewLine +
                       "//Enable Partner                                              " + Environment.NewLine +
                       "patch=1,EE,105AF666,extended,0000 //P2 Is Ally              " + Environment.NewLine +
                       "patch=1,EE,D094D16C,extended,0000                           " + Environment.NewLine +
                       "patch=1,EE,21DA8494,extended,FFFFF7EA                       " + Environment.NewLine +
                       "patch=1,EE,D094D16C,extended,0000                        " + Environment.NewLine +
                       "patch=1,EE,21DA8498,extended,FFFFF128                       " + Environment.NewLine +
                       "patch=1,EE,D094D16C,extended,0002                        " + Environment.NewLine +
                       "patch=1,EE,21DA8494,extended,FFFFF692                       " + Environment.NewLine +
                       "patch=1,EE,D094D16C,extended,0004                        " + Environment.NewLine +
                       "patch=1,EE,21DA8494,extended,00003000                       " + Environment.NewLine +
                       "patch=1,EE,D094D16C,extended,0004                           " + Environment.NewLine +
                       "patch=1,EE,21DA8498,extended,FFFFB433                       " + Environment.NewLine +
                       "patch=1,EE,D094D16C,extended,0005                        " + Environment.NewLine +
                       "patch=1,EE,21DA8494,extended,FFFFFFFF                       " + Environment.NewLine +
                       "patch=1,EE,D094D16C,extended,0005                        " + Environment.NewLine +
                       "patch=1,EE,21DA8498,extended,00000FFF                       " + Environment.NewLine +
                       "patch=1,EE,D094D16C,extended,0007                        " + Environment.NewLine +
                       "patch=1,EE,21DA8494,extended,00008306                       " + Environment.NewLine +
                       "patch=1,EE,D094D16C,extended,000A                           " + Environment.NewLine +
                       "patch=1,EE,21DA8494,extended,FFFFF692                      " + Environment.NewLine +
                       "patch=1,EE,D094D16C,extended,000B                        " + Environment.NewLine +
                       "patch=1,EE,21DA8494,extended,FFFFF7EA                      " + Environment.NewLine +
                       "patch=1,EE,D094D16C,extended,000B                        " + Environment.NewLine +
                       "patch=1,EE,21DA8498,extended,FFFFDD99                      " + Environment.NewLine +
                       "patch=1,EE,D094D16C,extended,000D                        " + Environment.NewLine +
                       "patch=1,EE,21DA8494,extended,FFFFF692                       " + Environment.NewLine +
                       "patch=1,EE,D094D16C,extended,000E                        " + Environment.NewLine +
                       "patch=1,EE,21DA8494,extended,FFFFFFFF                       " + Environment.NewLine +
                       "patch=1,EE,D094D16C,extended,000E                        " + Environment.NewLine +
                       "patch=1,EE,21DA8498,extended,00000FFF                       " + Environment.NewLine +
                       "patch=1,EE,D094D16C,extended,000F                        " + Environment.NewLine +
                       "patch=1,EE,21DA8494,extended,FFFFF7EA                       " + Environment.NewLine +
                       "patch=1,EE,D094D16C,extended,000F                        " + Environment.NewLine +
                       "patch=1,EE,21DA8498,extended,FFFFDD99                       " + Environment.NewLine +
                       "patch=1,EE,D094D16C,extended,0010                        " + Environment.NewLine +
                       "patch=1,EE,21DA8494,extended,00002FFE                       " + Environment.NewLine +
                       "patch=1,EE,D094D16C,extended,0010                        " + Environment.NewLine +
                       "patch=1,EE,21DA8498,extended,FFFFF500                       " + Environment.NewLine +
                       "patch=1,EE,D094D16C,extended,0011                        " + Environment.NewLine +
                       "patch=1,EE,21DA8494,extended,FFFFF692                       " + Environment.NewLine +
                       "patch=1,EE,D094D16C,extended,0013                        " + Environment.NewLine +
                       "patch=1,EE,21DA8494,extended,FFFFF000                       " + Environment.NewLine +
                       "patch=1,EE,D094D16C,extended,0013                        " + Environment.NewLine +
                       "patch=1,EE,21DA8498,extended,00000500                       " + Environment.NewLine +
                       "patch=1,EE,D094D16C,extended,0015                           " + Environment.NewLine +
                       "patch=1,EE,21DA8494,extended,00000A32                       " + Environment.NewLine +
                       "patch=1,EE,D094D16C,extended,0015                        " + Environment.NewLine +
                       "patch=1,EE,21DA8498,extended,00000200                       " + Environment.NewLine +
                       "patch=1,EE,D094D16C,extended,0016                           " + Environment.NewLine +
                       "patch=1,EE,21DA8494,extended,FFFFF7EA                       " + Environment.NewLine +
                       "patch=1,EE,D094D16C,extended,0016                        " + Environment.NewLine +
                       "patch=1,EE,21DA8498,extended,FFFFDD99                       " + Environment.NewLine +
                       "patch=1,EE,D094D16C,extended,0018                        " + Environment.NewLine +
                       "patch=1,EE,21DA8494,extended,00008F00                       " + Environment.NewLine +
                       "patch=1,EE,D094D16C,extended,0018                           " + Environment.NewLine +
                       "patch=1,EE,21DA8498,extended,00000F00                       " + Environment.NewLine +
                       "patch=1,EE,D094D16C,extended,001B                           " + Environment.NewLine +
                       "patch=1,EE,21DA8494,extended,00001000                      " + Environment.NewLine +
                       "patch=1,EE,D094D16C,extended,001B                           " + Environment.NewLine +
                       "patch=1,EE,21DA8498,extended,FFFFF500                      " + Environment.NewLine +
                       "patch=1,EE,D094D16C,extended,001D                        " + Environment.NewLine +
                       "patch=1,EE,21DA8494,extended,00000FFF                       " + Environment.NewLine +
                       "patch=1,EE,D094D16C,extended,001D                        " + Environment.NewLine +
                       "patch=1,EE,21DA8498,extended,00000F00                       " + Environment.NewLine +
                       "patch=1,EE,D094D16C,extended,0036                           " + Environment.NewLine +
                       "patch=1,EE,21DA8494,extended,FFFFFA00                       " + Environment.NewLine +
                       "patch=1,EE,D094D16C,extended,0036                        " + Environment.NewLine +
                       "patch=1,EE,21DA8498,extended,00001000                       " + Environment.NewLine +
                       "patch=1,EE,D094D16C,extended,0039                           " + Environment.NewLine +
                       "patch=1,EE,21DA8494,extended,00005900                       " + Environment.NewLine +
                       "patch=1,EE,D094D16C,extended,0039                           " + Environment.NewLine +
                       "patch=1,EE,21DA8498,extended,00000A00                       " + Environment.NewLine +
                       "patch=1,EE,D094D16C,extended,0043                        " + Environment.NewLine +
                       "patch=1,EE,21DA8494,extended,00000FFF                       " + Environment.NewLine +
                       "patch=1,EE,D094D16C,extended,0043                        " + Environment.NewLine +
                       "patch=1,EE,21DA8498,extended,00000500                       " + Environment.NewLine +
                       "patch=1,EE,D094D16C,extended,0044                           " + Environment.NewLine +
                       "patch=1,EE,21DA8494,extended,FFFFFA00                       " + Environment.NewLine +
                       "patch=1,EE,D094D16C,extended,0044                        " + Environment.NewLine +
                       "patch=1,EE,21DA8498,extended,00000F00                       " + Environment.NewLine +
                       "patch=1,EE,D094D16C,extended,0059                           " + Environment.NewLine +
                       "patch=1,EE,21DA8494,extended,FFFF9200                       " + Environment.NewLine +
                       "patch=1,EE,D094D16C,extended,0059                        " + Environment.NewLine +
                       "patch=1,EE,21DA8498,extended,00002FFF                       " + Environment.NewLine +
                       "patch=1,EE,D094D16C,extended,005A                        " + Environment.NewLine +
                       "patch=1,EE,21DA8494,extended,000009FF                      " + Environment.NewLine +
                       "patch=1,EE,D094D16C,extended,005A                        " + Environment.NewLine +
                       "patch=1,EE,21DA8498,extended,FFFFF500                      " + Environment.NewLine +
                       "patch=1,EE,D094D16C,extended,0062                        " + Environment.NewLine +
                       "patch=1,EE,21DA8494,extended,FFFFF500                       " + Environment.NewLine +
                       "patch=1,EE,D094D16C,extended,0062                        " + Environment.NewLine +
                       "patch=1,EE,21DA8498,extended,00000C00                       " + Environment.NewLine +
                       "patch=1,EE,D094D16C,extended,0010                        " + Environment.NewLine +
                       "patch=1,EE,105860F0,extended,0BF8                           " + Environment.NewLine +
                       "patch=1,EE,D094D16C,extended,0010                        " + Environment.NewLine +
                       "patch=1,EE,10577690,extended,0D85                           " + Environment.NewLine +
                       "patch=1,EE,D094D16C,extended,0010                           " + Environment.NewLine +
                       "patch=1,EE,10586164,extended,0EDC                           " + Environment.NewLine +
                       "patch=1,EE,D094D16C,extended,0010                        " + Environment.NewLine +
                       "patch=1,EE,10586180,extended,0CFC                           " + Environment.NewLine +
            "";

            ExportPnach.ExportFile(baseCode);
        }

        public static void ShunYingAndLinFongCustomizedTeam()
        {
            baseCode = "" +
                        "//Shun Ying & Lin Fong 𝓒𝓾𝓼𝓽𝓸𝓶𝓲𝔃𝓮𝓭                                        " + Environment.NewLine + 
                            "//switch camera [R2+L3 = ON | R2+R3=OFF]                    " + Environment.NewLine +
                            "patch=1,EE,D0359852,extended,FDFD                           " + Environment.NewLine +
                            "patch=1,EE,004616C0,extended,08                             " + Environment.NewLine +
                            "patch=1,EE,D0359852,extended,FDFD                           " + Environment.NewLine +
                            "patch=1,EE,004614D0,extended,05                             " + Environment.NewLine +
                            "patch=1,EE,D0359852,extended,FDFB                           " + Environment.NewLine +
                            "patch=1,EE,004616C0,extended,00                             " + Environment.NewLine +
                            "patch=1,EE,D0359852,extended,FDFB                           " + Environment.NewLine +
                            "patch=1,EE,004614D0,extended,06                             " + Environment.NewLine +
                        "//Players                                                                 " + Environment.NewLine +
                        "patch=1,EE,10ABFA7E,extended,0001 //Enable Weapons                      " + Environment.NewLine +
                        "patch=1,EE,D09449FC,extended,0018 //Skip Select Fighter                 " + Environment.NewLine +
                        "patch=1,EE,109449FC,extended,0019 //Skip Select Fighter                 " + Environment.NewLine +
                        "patch=1,EE,1094A5EC,extended,001F //FORCE Shun Ying As P1               " + Environment.NewLine +
                        "patch=1,EE,11DA84A0,extended,0036 //FORCE Lin Fong As P2                " + Environment.NewLine +
                        "patch=1,EE,11DA84F4,extended,0005 //P2 weapon                           " + Environment.NewLine +
                        "patch=1,EE,105A5FC6,extended,0003 //P1 Weapon Grip                      " + Environment.NewLine +
                        "patch=1,EE,105AF716,extended,0003 //P2 Weapon Grip                      " + Environment.NewLine +
                        "patch=1,EE,105B8E66,extended,0003 //P3 Weapon Grip                      " + Environment.NewLine +
                        "patch=1,EE,205AF6E4,extended,003A003A //Partner A.I                     " + Environment.NewLine +
                        "                                                                          " + Environment.NewLine +
                        "//Shun Ying                                                               " + Environment.NewLine +
                        "patch=1,EE,1058E758,extended,0325                                      " + Environment.NewLine +
                        "patch=1,EE,1058CE50,extended,0325                                       " + Environment.NewLine +
                        "patch=1,EE,20579F02,extended,0C3F0C3D                                   " + Environment.NewLine +
                        "patch=1,EE,20579EE4,extended,0EC40C32                                  " + Environment.NewLine +
                        "patch=1,EE,10579EA8,extended,0CE7                                      " + Environment.NewLine +
                        "patch=1,EE,20579ECA,extended,0CCB0CFB                                  " + Environment.NewLine +
                        "patch=1,EE,20579EAC,extended,0CEC0CF9                                  " + Environment.NewLine +
                        "patch=1,EE,20579F06,extended,0D010D06                                  " + Environment.NewLine +
                        "patch=1,EE,20579EE8,extended,0D020D07                                   " + Environment.NewLine +
                        "patch=1,EE,10579C94,extended,077F                                       " + Environment.NewLine +
                        "patch=1,EE,10579C98,extended,077F                                       " + Environment.NewLine +
                        "patch=1,EE,10576194,extended,0D19                                       " + Environment.NewLine +
                        "patch=1,EE,105778F4,extended,0D31                                       " + Environment.NewLine +
                        "                                                                          " + Environment.NewLine +
                        "//Shun Ying [▲]                                                           " + Environment.NewLine +
                        "patch=1,EE,10579E92,extended,0F2C                                       " + Environment.NewLine +
                        "patch=1,EE,10579E96,extended,0F2C                                      " + Environment.NewLine +
                        "patch=1,EE,1058E98A,extended,0F2C                                      " + Environment.NewLine +
                        "patch=1,EE,1058E98E,extended,0F2C                                      " + Environment.NewLine +
                        "patch=1,EE,1058D082,extended,0F2C                                      " + Environment.NewLine +
                        "patch=1,EE,1058D086,extended,0F2C                                      " + Environment.NewLine +
                        "patch=1,EE,10579EB2,extended,0DE6                                      " + Environment.NewLine +
                        "patch=1,EE,10579EB0,extended,0C8E                                      " + Environment.NewLine +
                        "patch=1,EE,10579EB0,extended,0C8E                                      " + Environment.NewLine +
                        "patch=1,EE,10579EEC,extended,0D6A                                      " + Environment.NewLine +
                        "patch=1,EE,10557DBE,extended,0CEF                                      " + Environment.NewLine +
                        "patch=1,EE,10579EF0,extended,0C69                                      " + Environment.NewLine +
                        "patch=1,EE,1058E9E4,extended,0E7C                                      " + Environment.NewLine +
                        "                                                                          " + Environment.NewLine +
                        "//Shun Ying [⚫]                                                          " + Environment.NewLine +
                        "patch=1,EE,1054D0C6,extended,06E1                                      " + Environment.NewLine +
                        "patch=1,EE,1054D468,extended,06F9                                       " + Environment.NewLine +
                        "patch=1,EE,1054D42C,extended,06F9                                       " + Environment.NewLine +
                        "patch=1,EE,D0359852,extended,FFFF                                       " + Environment.NewLine +
                        "patch=1,EE,1054BABE,extended,07FF                                      " + Environment.NewLine +
                        "patch=1,EE,D0359852,extended,F7FF                                   " + Environment.NewLine +
                        "patch=1,EE,1054BABE,extended,0AC6                                       " + Environment.NewLine +
                        "patch=1,EE,105496C4,extended,0AE3                                      " + Environment.NewLine +
                        "patch=1,EE,10549688,extended,04D5                                      " + Environment.NewLine +
                        "patch=1,EE,10579E6A,extended,06F9                                       " + Environment.NewLine +
                        "patch=1,EE,10579E6A,extended,06F9                                       " + Environment.NewLine +
                        "patch=1,EE,104F7934,extended,00E2                                       " + Environment.NewLine +
                        "patch=1,EE,20579E6C,extended,08950895                                   " + Environment.NewLine +
                        "patch=1,EE,1058E932,extended,0978                                       " + Environment.NewLine +
                        "patch=1,EE,1058D02A,extended,0978                                       " + Environment.NewLine +
                        "patch=1,EE,20579E3C,extended,07E507E5                                   " + Environment.NewLine +
                        "patch=1,EE,20579E54,extended,07E907E9                                  " + Environment.NewLine +
                        "patch=1,EE,1054BBCC,extended,0973                                      " + Environment.NewLine +
                        "patch=1,EE,10579E28,extended,04B7                                       " + Environment.NewLine +
                        "patch=1,EE,10579E52,extended,0973                                      " + Environment.NewLine +
                        "patch=1,EE,10549610,extended,0976                                       " + Environment.NewLine +
                        "                                                                          " + Environment.NewLine +
                        "//Park                                                                    " + Environment.NewLine +
                        "patch=1,EE,2057A11C,extended,0BCF0BD0                                   " + Environment.NewLine +
                        "patch=1,EE,2057A0EC,extended,05BE05BF                                  " + Environment.NewLine +
                        "                                                                          " + Environment.NewLine +
                        "//Dwayne                                                                  " + Environment.NewLine +
                        "patch=1,EE,2057A974,extended,0BCF0BD0                                  " + Environment.NewLine +
                        "                                                                          " + Environment.NewLine +
                        "//Shun Ying [⚫+▲]                                                        " + Environment.NewLine +
                        "patch=1,EE,D0359852,extended,F7FF                                   " + Environment.NewLine +
                        "patch=1,EE,10579CE0,extended,0B71                                       " + Environment.NewLine +
                        "patch=1,EE,D0359852,extended,FFFF                                       " + Environment.NewLine +
                        "patch=1,EE,10579CE0,extended,0897                                      " + Environment.NewLine +
                        "patch=1,EE,1058E7D4,extended,05FE                                       " + Environment.NewLine +
                        "patch=1,EE,1058CECC,extended,05FE                                      " + Environment.NewLine +
                        "patch=1,EE,1058E7D8,extended,0980                                      " + Environment.NewLine +
                        "patch=1,EE,1058CED0,extended,0980                                       " + Environment.NewLine +
                        "                                                                          " + Environment.NewLine +
                        "//[⬛] Counter                                                             " + Environment.NewLine +
                        "patch=1,EE,10528CB6,extended,0CD7                                       " + Environment.NewLine +
                        "patch=1,EE,10529028,extended,0CD7                                      " + Environment.NewLine +
                        "patch=1,EE,1052D804,extended,0CD2                                      " + Environment.NewLine +
                        "patch=1,EE,1052D82E,extended,0CD2                                      " + Environment.NewLine +
                        "patch=1,EE,105179B0,extended,0C5A                                      " + Environment.NewLine +
                        "patch=1,EE,105179B8,extended,0C69                                      " + Environment.NewLine +
                        "                                                                          " + Environment.NewLine +
                        "//Shun Ying (ee)                                                          " + Environment.NewLine +
                        "patch=1,EE,104F7934,extended,005D                                      " + Environment.NewLine +
                        "patch=1,EE,1050A034,extended,0296                                       " + Environment.NewLine +
                        "patch=1,EE,104DF7DC,extended,00AD                                       " + Environment.NewLine +
                        "patch=1,EE,104DF83C,extended,00AD                                      " + Environment.NewLine +
                        "patch=1,EE,104DF84C,extended,00AD                                      " + Environment.NewLine +
                        "patch=1,EE,1050A064,extended,0296                                      " + Environment.NewLine +
                        "patch=1,EE,1050A074,extended,0296                                       " + Environment.NewLine +
                        "                                                                          " + Environment.NewLine +
                        "//Lin Fong                                                                " + Environment.NewLine +
                        "patch=1,EE,105888FC,extended,097B                                       " + Environment.NewLine +
                        "patch=1,EE,10588900,extended,097B                                      " + Environment.NewLine +
                        "patch=1,EE,10588B10,extended,0CE7                                      " + Environment.NewLine +
                        "patch=1,EE,20588B4C,extended,0EC40C32                                  " + Environment.NewLine +
                        "patch=1,EE,20588B6A,extended,0C3F0C3D                                  " + Environment.NewLine +
                        "patch=1,EE,20588B32,extended,0CCB0CEA                                  " + Environment.NewLine +
                        "patch=1,EE,20588B14,extended,0CEC0CF9                                  " + Environment.NewLine +
                        "patch=1,EE,20588B6E,extended,0D010D06                                  " + Environment.NewLine +
                        "patch=1,EE,20588B50,extended,0D020D07                                   " + Environment.NewLine +
                        "                                                                          " + Environment.NewLine +
                        "//Lin Fong [⚫]                                                           " + Environment.NewLine +
                        "patch=1,EE,1054BFE6,extended,0AE3                                       " + Environment.NewLine +
                        "patch=1,EE,1058EBFA,extended,0883                                      " + Environment.NewLine +
                        "patch=1,EE,10588AD2,extended,0987                                       " + Environment.NewLine +
                        "patch=1,EE,1058EC30,extended,0BB6                                       " + Environment.NewLine +
                        "patch=1,EE,20588AD4,extended,095A095A                                  " + Environment.NewLine +
                        "patch=1,EE,1054F394,extended,0987                                      " + Environment.NewLine +
                        "patch=1,EE,20588ABC,extended,09250925                                   " + Environment.NewLine +
                        "patch=1,EE,104F1EDC,extended,001C                                       " + Environment.NewLine +
                        "patch=1,EE,104F1EE4,extended,00B8                                      " + Environment.NewLine +
                        "patch=1,EE,1054EBBA,extended,0AE3                                      " + Environment.NewLine +
                        "patch=1,EE,10588ABA,extended,0973                                      " + Environment.NewLine +
                        "patch=1,EE,1054F664,extended,FFFF                                       " + Environment.NewLine +
                        "patch=1,EE,1058EC12,extended,0BEE                                      " + Environment.NewLine +
                        "patch=1,EE,10588AC2,extended,0AC5                                      " + Environment.NewLine +
                        "patch=1,EE,20588AA4,extended,09770977                                  " + Environment.NewLine +
                        "patch=1,EE,10588A90,extended,04B7                                       " + Environment.NewLine +
                        "patch=1,EE,10588AD8,extended,0C04                                      " + Environment.NewLine +
                        "patch=1,EE,10588AA8,extended,078D                                      " + Environment.NewLine +
                        "                                                                          " + Environment.NewLine +
                        "//Lin Fong [▲]                                                            " + Environment.NewLine +
                        "patch=1,EE,10588AFA,extended,0EB9                                       " + Environment.NewLine +
                        "patch=1,EE,10588AFE,extended,0EB9                                      " + Environment.NewLine +
                        "patch=1,EE,1058EC52,extended,0EB9                                      " + Environment.NewLine +
                        "patch=1,EE,1058EC56,extended,0EB9                                      " + Environment.NewLine +
                        "patch=1,EE,10588B18,extended,0EDF                                      " + Environment.NewLine +
                        "patch=1,EE,10588B56,extended,0F4D                                      " + Environment.NewLine +
                        "                                                                          " + Environment.NewLine +
                        "//Lin Fong [⚫+▲]                                                         " + Environment.NewLine +
                        "patch=1,EE,1058EA9C,extended,05FE                                       " + Environment.NewLine +
                        "patch=1,EE,10588944,extended,068E                                      " + Environment.NewLine +
                        "patch=1,EE,1058EA9E,extended,0A99                                       " + Environment.NewLine +
                        "patch=1,EE,10588946,extended,0A99                                      " + Environment.NewLine +
                        "                                                                          " + Environment.NewLine +
                        "//Lin Fong (ee)                                                           " + Environment.NewLine +
                        "patch=1,EE,1050BAF0,extended,0295                                      " + Environment.NewLine +
                        "patch=1,EE,1050BB20,extended,0295                                       " + Environment.NewLine +
                        "patch=1,EE,1050BB28,extended,0297                                       " + Environment.NewLine +
                        "patch=1,EE,1050BB30,extended,0295                                       " + Environment.NewLine +
                        "patch=1,EE,1050BB38,extended,0297                                       " + Environment.NewLine +
                        "patch=1,EE,204F6B60,extended,000000CD                                   " + Environment.NewLine +
                        "patch=1,EE,204F6C4C,extended,000000CF                                  " + Environment.NewLine +
                        "patch=1,EE,204F6D36,extended,02950000                                  " + Environment.NewLine +
                        "patch=1,EE,204F6D3E,extended,02970000                                   " + Environment.NewLine +
                        "patch=1,EE,204F6D66,extended,02950000                                   " + Environment.NewLine +
                        "patch=1,EE,204F6D7E,extended,02970000                                   " + Environment.NewLine +
                        "patch=1,EE,204F6D76,extended,02950000                                   " + Environment.NewLine +
                        "patch=1,EE,204F6D6E,extended,02970000                                   " + Environment.NewLine +
                        "patch=1,EE,204F72C0,extended,0000009B                                   " + Environment.NewLine +
                        "patch=1,EE,204F7496,extended,02960000                                  " + Environment.NewLine +
                        "patch=1,EE,204F749E,extended,02980000                                   " + Environment.NewLine +
                        "patch=1,EE,204F74C6,extended,02960000                                   " + Environment.NewLine +
                        "patch=1,EE,204F74D6,extended,02960000                                   " + Environment.NewLine +
                        "patch=1,EE,204F74DE,extended,02980000                                   " + Environment.NewLine +
                        "patch=1,EE,204F74CE,extended,02980000                                   " + Environment.NewLine +
                        "                                                                          " + Environment.NewLine +
                        "                                                                          " + Environment.NewLine +
                        "//MAX Stats                                                               " + Environment.NewLine +
                        "patch=1,EE,105A6018,extended,03E8 //P1                                  " + Environment.NewLine +
                        "patch=1,EE,105A601A,extended,03E8                                       " + Environment.NewLine +
                        "patch=1,EE,105A601C,extended,03E8                                       " + Environment.NewLine +
                        "patch=1,EE,105A601E,extended,03E8                                       " + Environment.NewLine +
                        "patch=1,EE,105A6020,extended,03E8                                       " + Environment.NewLine +
                        "patch=1,EE,105A6022,extended,03E8                                       " + Environment.NewLine +
                        "patch=1,EE,105A5FD2,extended,01F4                                       " + Environment.NewLine +
                        "patch=1,EE,105A5FD4,extended,01F4                                       " + Environment.NewLine +
                        "patch=1,EE,105A5FD6,extended,01F4                                       " + Environment.NewLine +
                        "patch=1,EE,105AF768,extended,03E8 //P2                                  " + Environment.NewLine +
                        "patch=1,EE,105AF76A,extended,03E8                                       " + Environment.NewLine +
                        "patch=1,EE,105AF76C,extended,03E8                                       " + Environment.NewLine +
                        "patch=1,EE,105AF76E,extended,03E8                                       " + Environment.NewLine +
                        "patch=1,EE,105AF770,extended,03E8                                       " + Environment.NewLine +
                        "patch=1,EE,105AF772,extended,03E8                                       " + Environment.NewLine +
                        "patch=1,EE,105AF722,extended,01F4                                       " + Environment.NewLine +
                        "patch=1,EE,105AF724,extended,01F4                                       " + Environment.NewLine +
                        "patch=1,EE,105AF726,extended,01F4                                       " + Environment.NewLine +
                        "                                                                          " + Environment.NewLine +
                        "//Enable Partner                                                          " + Environment.NewLine +
                        "patch=1,EE,105AF666,extended,0000 //P2 Is Ally                          " + Environment.NewLine +
                        "patch=1,EE,D094D16C,extended,0000                                       " + Environment.NewLine +
                        "patch=1,EE,21DA8494,extended,FFFFF7EA                                   " + Environment.NewLine +
                        "patch=1,EE,D094D16C,extended,0000                                    " + Environment.NewLine +
                        "patch=1,EE,21DA8498,extended,FFFFF128                                   " + Environment.NewLine +
                        "patch=1,EE,D094D16C,extended,0002                                    " + Environment.NewLine +
                        "patch=1,EE,21DA8494,extended,FFFFF692                                   " + Environment.NewLine +
                        "patch=1,EE,D094D16C,extended,0004                                    " + Environment.NewLine +
                        "patch=1,EE,21DA8494,extended,00003000                                   " + Environment.NewLine +
                        "patch=1,EE,D094D16C,extended,0004                                       " + Environment.NewLine +
                        "patch=1,EE,21DA8498,extended,FFFFB433                                   " + Environment.NewLine +
                        "patch=1,EE,D094D16C,extended,0005                                    " + Environment.NewLine +
                        "patch=1,EE,21DA8494,extended,FFFFFFFF                                   " + Environment.NewLine +
                        "patch=1,EE,D094D16C,extended,0005                                    " + Environment.NewLine +
                        "patch=1,EE,21DA8498,extended,00000FFF                                   " + Environment.NewLine +
                        "patch=1,EE,D094D16C,extended,0007                                    " + Environment.NewLine +
                        "patch=1,EE,21DA8494,extended,00008306                                   " + Environment.NewLine +
                        "patch=1,EE,D094D16C,extended,000A                                       " + Environment.NewLine +
                        "patch=1,EE,21DA8494,extended,FFFFF692                                  " + Environment.NewLine +
                        "patch=1,EE,D094D16C,extended,000B                                    " + Environment.NewLine +
                        "patch=1,EE,21DA8494,extended,FFFFF7EA                                  " + Environment.NewLine +
                        "patch=1,EE,D094D16C,extended,000B                                    " + Environment.NewLine +
                        "patch=1,EE,21DA8498,extended,FFFFDD99                                  " + Environment.NewLine +
                        "patch=1,EE,D094D16C,extended,000D                                    " + Environment.NewLine +
                        "patch=1,EE,21DA8494,extended,FFFFF692                                   " + Environment.NewLine +
                        "patch=1,EE,D094D16C,extended,000E                                    " + Environment.NewLine +
                        "patch=1,EE,21DA8494,extended,FFFFFFFF                                   " + Environment.NewLine +
                        "patch=1,EE,D094D16C,extended,000E                                    " + Environment.NewLine +
                        "patch=1,EE,21DA8498,extended,00000FFF                                   " + Environment.NewLine +
                        "patch=1,EE,D094D16C,extended,000F                                    " + Environment.NewLine +
                        "patch=1,EE,21DA8494,extended,FFFFF7EA                                   " + Environment.NewLine +
                        "patch=1,EE,D094D16C,extended,000F                                    " + Environment.NewLine +
                        "patch=1,EE,21DA8498,extended,FFFFDD99                                   " + Environment.NewLine +
                        "patch=1,EE,D094D16C,extended,0010                                    " + Environment.NewLine +
                        "patch=1,EE,21DA8494,extended,00002FFE                                   " + Environment.NewLine +
                        "patch=1,EE,D094D16C,extended,0010                                    " + Environment.NewLine +
                        "patch=1,EE,21DA8498,extended,FFFFF500                                   " + Environment.NewLine +
                        "patch=1,EE,D094D16C,extended,0011                                    " + Environment.NewLine +
                        "patch=1,EE,21DA8494,extended,FFFFF692                                   " + Environment.NewLine +
                        "patch=1,EE,D094D16C,extended,0013                                    " + Environment.NewLine +
                        "patch=1,EE,21DA8494,extended,FFFFF000                                   " + Environment.NewLine +
                        "patch=1,EE,D094D16C,extended,0013                                    " + Environment.NewLine +
                        "patch=1,EE,21DA8498,extended,00000500                                   " + Environment.NewLine +
                        "patch=1,EE,D094D16C,extended,0015                                       " + Environment.NewLine +
                        "patch=1,EE,21DA8494,extended,00000A32                                   " + Environment.NewLine +
                        "patch=1,EE,D094D16C,extended,0015                                    " + Environment.NewLine +
                        "patch=1,EE,21DA8498,extended,00000200                                   " + Environment.NewLine +
                        "patch=1,EE,D094D16C,extended,0016                                       " + Environment.NewLine +
                        "patch=1,EE,21DA8494,extended,FFFFF7EA                                   " + Environment.NewLine +
                        "patch=1,EE,D094D16C,extended,0016                                    " + Environment.NewLine +
                        "patch=1,EE,21DA8498,extended,FFFFDD99                                   " + Environment.NewLine +
                        "patch=1,EE,D094D16C,extended,0018                                    " + Environment.NewLine +
                        "patch=1,EE,21DA8494,extended,00008F00                                   " + Environment.NewLine +
                        "patch=1,EE,D094D16C,extended,0018                                       " + Environment.NewLine +
                        "patch=1,EE,21DA8498,extended,00000F00                                   " + Environment.NewLine +
                        "patch=1,EE,D094D16C,extended,001B                                       " + Environment.NewLine +
                        "patch=1,EE,21DA8494,extended,00001000                                  " + Environment.NewLine +
                        "patch=1,EE,D094D16C,extended,001B                                       " + Environment.NewLine +
                        "patch=1,EE,21DA8498,extended,FFFFF500                                  " + Environment.NewLine +
                        "patch=1,EE,D094D16C,extended,001D                                    " + Environment.NewLine +
                        "patch=1,EE,21DA8494,extended,00000FFF                                   " + Environment.NewLine +
                        "patch=1,EE,D094D16C,extended,001D                                    " + Environment.NewLine +
                        "patch=1,EE,21DA8498,extended,00000F00                                   " + Environment.NewLine +
                        "patch=1,EE,D094D16C,extended,0036                                       " + Environment.NewLine +
                        "patch=1,EE,21DA8494,extended,FFFFFA00                                   " + Environment.NewLine +
                        "patch=1,EE,D094D16C,extended,0036                                    " + Environment.NewLine +
                        "patch=1,EE,21DA8498,extended,00001000                                   " + Environment.NewLine +
                        "patch=1,EE,D094D16C,extended,0039                                       " + Environment.NewLine +
                        "patch=1,EE,21DA8494,extended,00005900                                   " + Environment.NewLine +
                        "patch=1,EE,D094D16C,extended,0039                                       " + Environment.NewLine +
                        "patch=1,EE,21DA8498,extended,00000A00                                   " + Environment.NewLine +
                        "patch=1,EE,D094D16C,extended,0043                                    " + Environment.NewLine +
                        "patch=1,EE,21DA8494,extended,00000FFF                                   " + Environment.NewLine +
                        "patch=1,EE,D094D16C,extended,0043                                    " + Environment.NewLine +
                        "patch=1,EE,21DA8498,extended,00000500                                   " + Environment.NewLine +
                        "patch=1,EE,D094D16C,extended,0044                                       " + Environment.NewLine +
                        "patch=1,EE,21DA8494,extended,FFFFFA00                                   " + Environment.NewLine +
                        "patch=1,EE,D094D16C,extended,0044                                    " + Environment.NewLine +
                        "patch=1,EE,21DA8498,extended,00000F00                                   " + Environment.NewLine +
                        "patch=1,EE,D094D16C,extended,0059                                       " + Environment.NewLine +
                        "patch=1,EE,21DA8494,extended,FFFF9200                                   " + Environment.NewLine +
                        "patch=1,EE,D094D16C,extended,0059                                    " + Environment.NewLine +
                        "patch=1,EE,21DA8498,extended,00002FFF                                   " + Environment.NewLine +
                        "patch=1,EE,D094D16C,extended,005A                                    " + Environment.NewLine +
                        "patch=1,EE,21DA8494,extended,000009FF                                  " + Environment.NewLine +
                        "patch=1,EE,D094D16C,extended,005A                                    " + Environment.NewLine +
                        "patch=1,EE,21DA8498,extended,FFFFF500                                  " + Environment.NewLine +
                        "patch=1,EE,D094D16C,extended,0062                                    " + Environment.NewLine +
                        "patch=1,EE,21DA8494,extended,FFFFF500                                   " + Environment.NewLine +
                        "patch=1,EE,D094D16C,extended,0062                                    " + Environment.NewLine +
                        "patch=1,EE,21DA8498,extended,00000C00                                   " + Environment.NewLine +
                        "patch=1,EE,D094D16C,extended,0010                                    " + Environment.NewLine +
                        "patch=1,EE,105860F0,extended,0BF8                                       " + Environment.NewLine +
                        "patch=1,EE,D094D16C,extended,0010                                    " + Environment.NewLine +
                        "patch=1,EE,10577690,extended,0D85                                       " + Environment.NewLine +
                        "patch=1,EE,D094D16C,extended,0010                                       " + Environment.NewLine +
                        "patch=1,EE,10586164,extended,0EDC                                       " + Environment.NewLine +
                        "patch=1,EE,D094D16C,extended,0010                                    " + Environment.NewLine +
                        "patch=1,EE,10586180,extended,0CFC                                       " + Environment.NewLine +
            "";

            ExportPnach.ExportFile(baseCode);
        }

        public static void McKinzieAndCooperAndBainCustomizedTeam()
        {
            baseCode = "" +
                        "//McKinzie & Cooper & Bain 𝓒𝓾𝓼𝓽𝓸𝓶𝓲𝔃𝓮𝓭                                   " + Environment.NewLine +
                            "//switch camera [R2+L3 = ON | R2+R3=OFF]                    " + Environment.NewLine +
                            "patch=1,EE,D0359852,extended,FDFD                           " + Environment.NewLine +
                            "patch=1,EE,004616C0,extended,08                             " + Environment.NewLine +
                            "patch=1,EE,D0359852,extended,FDFD                           " + Environment.NewLine +
                            "patch=1,EE,004614D0,extended,05                             " + Environment.NewLine +
                            "patch=1,EE,D0359852,extended,FDFB                           " + Environment.NewLine +
                            "patch=1,EE,004616C0,extended,00                             " + Environment.NewLine +
                            "patch=1,EE,D0359852,extended,FDFB                           " + Environment.NewLine +
                            "patch=1,EE,004614D0,extended,06                             " + Environment.NewLine +
                        "//Players                                                                " + Environment.NewLine +
                        "patch=1,EE,10ABFA7E,extended,0001 //Enable Weapons                     " + Environment.NewLine +
                        "patch=1,EE,D09449FC,extended,0018 //Skip Select Fighter                " + Environment.NewLine +
                        "patch=1,EE,109449FC,extended,0019 //Skip Select Fighter                " + Environment.NewLine +
                        "patch=1,EE,1094A5EC,extended,002B //FORCE McKinzie As P1               " + Environment.NewLine +
                        "patch=1,EE,11DA84A0,extended,0025 //FORCE Cooper As P2                " + Environment.NewLine +
                        "patch=1,EE,21DA84F4,extended,0013 //P2 weapon                          " + Environment.NewLine +
                        "patch=1,EE,105A5FC6,extended,0003 //P1 Weapon Grip                     " + Environment.NewLine +
                        "patch=1,EE,105AF716,extended,0003 //P2 Weapon Grip                     " + Environment.NewLine +
                        "patch=1,EE,105B8E66,extended,0003 //P3 Weapon Grip                     " + Environment.NewLine +
                        "patch=1,EE,205AF6E4,extended,003A003A //Partner A.I                    " + Environment.NewLine +
                        "                                                                         " + Environment.NewLine +
                        "//McKinzie                                                               " + Environment.NewLine +
                        "patch=1,EE,205882DA,extended,0CCB0CFB                                 " + Environment.NewLine +
                        "patch=1,EE,205882BC,extended,0CEC0CF9                                 " + Environment.NewLine +
                        "patch=1,EE,20588316,extended,0D010D06                                 " + Environment.NewLine +
                        "patch=1,EE,205882F8,extended,0D020D07                                  " + Environment.NewLine +
                        "patch=1,EE,10576904,extended,0D8B                                      " + Environment.NewLine +
                        "patch=1,EE,105779C0,extended,0D2F                                     " + Environment.NewLine +
                        "                                                                         " + Environment.NewLine +
                        "//McKinzie [▲]                                                           " + Environment.NewLine +
                        "patch=1,EE,205882DE,extended,0CF70F3A                                  " + Environment.NewLine +
                        "                                                                         " + Environment.NewLine +
                        "//McKinzie [⚫]                                                          " + Environment.NewLine +
                        "patch=1,EE,10550348,extended,09F9                                     " + Environment.NewLine +
                        "patch=1,EE,20592398,extended,09A2FFFD                                  " + Environment.NewLine +
                        "patch=1,EE,105923CA,extended,09A1                                     " + Environment.NewLine +
                        "patch=1,EE,105923B2,extended,0A16                                     " + Environment.NewLine +
                        "patch=1,EE,10550654,extended,0A12                                     " + Environment.NewLine +
                        "patch=1,EE,10588262,extended,0A16                                     " + Environment.NewLine +
                        "patch=1,EE,205923B8,extended,0AC5FFFD                                 " + Environment.NewLine +
                        "patch=1,EE,20550742,extended,0A190000                                 " + Environment.NewLine +
                        "patch=1,EE,2058827C,extended,07E507E5                                 " + Environment.NewLine +
                        "patch=1,EE,1054BABE,extended,09F8                                     " + Environment.NewLine +
                        "patch=1,EE,20588264,extended,07E907E9                                  " + Environment.NewLine +
                        "patch=1,EE,1054BBCC,extended,09E9                                     " + Environment.NewLine +
                        "patch=1,EE,104DFB8C,extended,001C                                      " + Environment.NewLine +
                        "patch=1,EE,104DFC2C,extended,001C                                     " + Environment.NewLine +
                        "patch=1,EE,104DFC3C,extended,001C                                     " + Environment.NewLine +
                        "patch=1,EE,104DFB94,extended,001B                                     " + Environment.NewLine +
                        "patch=1,EE,104DFC34,extended,001B                                     " + Environment.NewLine +
                        "patch=1,EE,104DFC44,extended,001B                                     " + Environment.NewLine +
                        "patch=1,EE,10588238,extended,0C04                                     " + Environment.NewLine +
                        "patch=1,EE,10592388,extended,0C04                                     " + Environment.NewLine +
                        "patch=1,EE,D0359852,extended,F7FF                                  " + Environment.NewLine +
                        "patch=1,EE,10550B22,extended,0A18                                      " + Environment.NewLine +
                        "patch=1,EE,D0359852,extended,FFFF                                  " + Environment.NewLine +
                        "patch=1,EE,10550B22,extended,09EA                                      " + Environment.NewLine +
                        "                                                                         " + Environment.NewLine +
                        "//McKinzie [⚫+▲]                                                        " + Environment.NewLine +
                        "patch=1,EE,105880F0,extended,0A06                                     " + Environment.NewLine +
                        "patch=1,EE,1055079E,extended,0A09                                     " + Environment.NewLine +
                        "patch=1,EE,10489880,extended,0190                                     " + Environment.NewLine +
                        "patch=1,EE,205880EA,extended,0BC20489                                  " + Environment.NewLine +
                        "patch=1,EE,105548C6,extended,0B6A                                     " + Environment.NewLine +
                        "patch=1,EE,10553BE2,extended,0A08                                     " + Environment.NewLine +
                        "patch=1,EE,105507BC,extended,0B69                                     " + Environment.NewLine +
                        "patch=1,EE,10513900,extended,00D0                                      " + Environment.NewLine +
                        "patch=1,EE,10513908,extended,00D5                                      " + Environment.NewLine +
                        "                                                                         " + Environment.NewLine +
                        "//Tin Jiao                                                               " + Environment.NewLine +
                        "patch=1,EE,10588C10,extended,0817                                      " + Environment.NewLine +
                        "patch=1,EE,10588ED8,extended,0817                                      " + Environment.NewLine +
                        "patch=1,EE,105891A0,extended,0817                                      " + Environment.NewLine +
                        "                                                                         " + Environment.NewLine +
                        "//Park                                                                   " + Environment.NewLine +
                        "patch=1,EE,2057A11C,extended,0BCF0BD0                                  " + Environment.NewLine +
                        "patch=1,EE,2057A0EC,extended,05BE05BF                                 " + Environment.NewLine +
                        "                                                                         " + Environment.NewLine +
                        "//The Hell's Legions                                                     " + Environment.NewLine +
                        "patch=1,EE,20581B94,extended,05C405C3                                 " + Environment.NewLine +
                        "patch=1,EE,20581E5C,extended,05C405C3                                 " + Environment.NewLine +
                        "patch=1,EE,20582124,extended,05C405C3                                 " + Environment.NewLine +
                        "                                                                         " + Environment.NewLine +
                        "//[⬛] Counter                                                            " + Environment.NewLine +
                        "patch=1,EE,10528CB6,extended,0CD7                                     " + Environment.NewLine +
                        "patch=1,EE,10529028,extended,0F3E                                     " + Environment.NewLine +
                        "patch=1,EE,105179B0,extended,0C5A                                      " + Environment.NewLine +
                        "patch=1,EE,105179B8,extended,0C69                                     " + Environment.NewLine +
                        "                                                                         " + Environment.NewLine +
                        "//McKinzie [ee]                                                          " + Environment.NewLine +
                        "patch=1,EE,104FDDE8,extended,0298                                     " + Environment.NewLine +
                        "patch=1,EE,104FDDF8,extended,0298                                      " + Environment.NewLine +
                        "patch=1,EE,104FDDF0,extended,02F8                                      " + Environment.NewLine +
                        "patch=1,EE,104FDDE0,extended,02F8                                      " + Environment.NewLine +
                        "patch=1,EE,104FD4A8,extended,0296                                      " + Environment.NewLine +
                        "patch=1,EE,104FD4B8,extended,0296                                      " + Environment.NewLine +
                        "patch=1,EE,104FD4B0,extended,0298                                      " + Environment.NewLine +
                        "patch=1,EE,104FD4C0,extended,0298                                      " + Environment.NewLine +
                        "patch=1,EE,104F8DAC,extended,0296                                      " + Environment.NewLine +
                        "patch=1,EE,104F8DBC,extended,0296                                      " + Environment.NewLine +
                        "patch=1,EE,104F8DC4,extended,0298                                      " + Environment.NewLine +
                        "patch=1,EE,104F8DB4,extended,0298                                      " + Environment.NewLine +
                        "patch=1,EE,104FE24C,extended,00C2                                      " + Environment.NewLine +
                        "patch=1,EE,104FE254,extended,005D                                     " + Environment.NewLine +
                        "patch=1,EE,104FE368,extended,0296                                      " + Environment.NewLine +
                        "patch=1,EE,104FE378,extended,0296                                      " + Environment.NewLine +
                        "patch=1,EE,104FE370,extended,0298                                      " + Environment.NewLine +
                        "patch=1,EE,104FE380,extended,0298                                      " + Environment.NewLine +
                        "patch=1,EE,104F9258,extended,0295                                      " + Environment.NewLine +
                        "patch=1,EE,104F9248,extended,0295                                      " + Environment.NewLine +
                        "patch=1,EE,104F9250,extended,0297                                      " + Environment.NewLine +
                        "patch=1,EE,104F9260,extended,0297                                      " + Environment.NewLine +
                        "patch=1,EE,104F95F8,extended,0295                                      " + Environment.NewLine +
                        "patch=1,EE,104F9608,extended,0295                                      " + Environment.NewLine +
                        "patch=1,EE,104F9610,extended,0297                                      " + Environment.NewLine +
                        "patch=1,EE,104F9600,extended,0297                                      " + Environment.NewLine +
                        "patch=1,EE,104F95C8,extended,0060                                      " + Environment.NewLine +
                        "patch=1,EE,104F9658,extended,0060                                      " + Environment.NewLine +
                        "patch=1,EE,104F95D0,extended,005F                                      " + Environment.NewLine +
                        "patch=1,EE,104F9660,extended,005F                                      " + Environment.NewLine +
                        "                                                                         " + Environment.NewLine +
                        "//Bain                                                                   " + Environment.NewLine +
                        "patch=1,EE,205874F2,extended,0CCB0CFB                                  " + Environment.NewLine +
                        "patch=1,EE,205874D4,extended,0CEC0CF9                                 " + Environment.NewLine +
                        "patch=1,EE,2058752E,extended,0D010D06                                 " + Environment.NewLine +
                        "patch=1,EE,20587510,extended,0D020D07                                  " + Environment.NewLine +
                        "patch=1,EE,105874D2,extended,0C42                                      " + Environment.NewLine +
                        "                                                                         " + Environment.NewLine +
                        "//Bain [▲]                                                               " + Environment.NewLine +
                        "patch= 1,EE,10587514,extended,0E86                                     " + Environment.NewLine +
                        "                                                                         " + Environment.NewLine +
                        "//Bain [⚫]                                                              " + Environment.NewLine +
                        "patch=1,EE,1058744A,extended,09E7                                      " + Environment.NewLine +
                        "patch=1,EE,2058744C,extended,09EB09EC                                  " + Environment.NewLine +
                        "patch=1,EE,10550BD6,extended,0A01                                     " + Environment.NewLine +
                        "patch=1,EE,10587462,extended,09F5                                     " + Environment.NewLine +
                        "patch=1,EE,20587494,extended,095A095A                                  " + Environment.NewLine +
                        "patch=1,EE,2058747C,extended,07E907E9                                 " + Environment.NewLine +
                        "patch=1,EE,10587450,extended,0C04                                     " + Environment.NewLine +
                        "                                                                         " + Environment.NewLine +
                        "//Bain [⚫+▲]                                                            " + Environment.NewLine +
                        "patch=1,EE,10587304,extended,0BC2                                     " + Environment.NewLine +
                        "patch=1,EE,10587308,extended,0A06                                     " + Environment.NewLine +
                        "patch=1,EE,10587306,extended,09E3                                     " + Environment.NewLine +
                        "                                                                         " + Environment.NewLine +
                        "//Cooper                                                                 " + Environment.NewLine +
                        "patch=1,EE,205877BA,extended,0CCB0CFB                                  " + Environment.NewLine +
                        "patch=1,EE,2058779C,extended,0CEC0CF9                                 " + Environment.NewLine +
                        "patch=1,EE,205877F6,extended,0D010D06                                 " + Environment.NewLine +
                        "patch=1,EE,205877D8,extended,0D020D07                                  " + Environment.NewLine +
                        "patch=1,EE,1058779A,extended,0C42                                      " + Environment.NewLine +
                        "                                                                         " + Environment.NewLine +
                        "//Cooper [▲]                                                             " + Environment.NewLine +
                        "patch=1,EE,205877DC,extended,0F4D0E86                                 " + Environment.NewLine +
                        "                                                                         " + Environment.NewLine +
                        "//Cooper [⚫]                                                            " + Environment.NewLine +
                        "patch=1,EE,10587712,extended,09E7                                      " + Environment.NewLine +
                        "patch=1,EE,20587714,extended,09EB09EC                                  " + Environment.NewLine +
                        "patch=1,EE,10550942,extended,09F5                                     " + Environment.NewLine +
                        "patch=1,EE,105505DC,extended,09F4                                      " + Environment.NewLine +
                        "patch=1,EE,1055097E,extended,09FE                                      " + Environment.NewLine +
                        "patch=1,EE,1058772A,extended,09F5                                     " + Environment.NewLine +
                        "patch=1,EE,20592648,extended,099A0000                                  " + Environment.NewLine +
                        "patch=1,EE,2059264C,extended,099E099F                                 " + Environment.NewLine +
                        "patch=1,EE,20592660,extended,09A2FFFD                                  " + Environment.NewLine +
                        "patch=1,EE,10592692,extended,09A1                                     " + Environment.NewLine +
                        "patch=1,EE,2058775C,extended,095A095A                                 " + Environment.NewLine +
                        "patch=1,EE,1054F40C,extended,0A01                                     " + Environment.NewLine +
                        "patch=1,EE,20587744,extended,07E907E9                                 " + Environment.NewLine +
                        "patch=1,EE,2058772C,extended,0A000A00                                 " + Environment.NewLine +
                        "patch=1,EE,10587718,extended,0C04                                     " + Environment.NewLine +
                        "                                                                         " + Environment.NewLine +
                        "//Cooper [⚫+▲]                                                          " + Environment.NewLine +
                        "patch=1,EE,205875CA,extended,0BC20489                                 " + Environment.NewLine +
                        "patch=1,EE,20592506,extended,09A3FFFD                                 " + Environment.NewLine +
                        "patch=1,EE,105875D0,extended,0A06                                     " + Environment.NewLine +
                        "patch=1,EE,105875CE,extended,0A99                                     " + Environment.NewLine +
                        "                                                                         " + Environment.NewLine +
                        "//MAX Stats                                                              " + Environment.NewLine +
                        "patch=1,EE,105A6018,extended,03E8 //P1                                " + Environment.NewLine +
                        "patch=1,EE,105A601A,extended,03E8                                      " + Environment.NewLine +
                        "patch=1,EE,105A601C,extended,03E8                                      " + Environment.NewLine +
                        "patch=1,EE,105A601E,extended,03E8                                      " + Environment.NewLine +
                        "patch=1,EE,105A6020,extended,03E8                                      " + Environment.NewLine +
                        "patch=1,EE,105A6022,extended,03E8                                      " + Environment.NewLine +
                        "patch=1,EE,105A5FD2,extended,01F4                                      " + Environment.NewLine +
                        "patch=1,EE,105A5FD4,extended,01F4                                      " + Environment.NewLine +
                        "patch=1,EE,105A5FD6,extended,01F4                                      " + Environment.NewLine +
                        "patch=1,EE,105AF768,extended,03E8 //P2                                 " + Environment.NewLine +
                        "patch=1,EE,105AF76A,extended,03E8                                      " + Environment.NewLine +
                        "patch=1,EE,105AF76C,extended,03E8                                      " + Environment.NewLine +
                        "patch=1,EE,105AF76E,extended,03E8                                      " + Environment.NewLine +
                        "patch=1,EE,105AF770,extended,03E8                                      " + Environment.NewLine +
                        "patch=1,EE,105AF772,extended,03E8                                      " + Environment.NewLine +
                        "patch=1,EE,105AF722,extended,01F4                                      " + Environment.NewLine +
                        "patch=1,EE,105AF724,extended,01F4                                      " + Environment.NewLine +
                        "patch=1,EE,105AF726,extended,01F4                                      " + Environment.NewLine +
                        "                                                                         " + Environment.NewLine +
                        "//Enable Partner                                                         " + Environment.NewLine +
                        "patch=1,EE,105AF666,extended,0000 //P2 Is Ally                         " + Environment.NewLine +
                        "patch=1,EE,D094D16C,extended,0000                                      " + Environment.NewLine +
                        "patch=1,EE,21DA8494,extended,FFFFF7EA                                  " + Environment.NewLine +
                        "patch=1,EE,D094D16C,extended,0000                                   " + Environment.NewLine +
                        "patch=1,EE,21DA8498,extended,FFFFF128                                  " + Environment.NewLine +
                        "patch=1,EE,D094D16C,extended,0002                                   " + Environment.NewLine +
                        "patch=1,EE,21DA8494,extended,FFFFF692                                  " + Environment.NewLine +
                        "patch=1,EE,D094D16C,extended,0004                                   " + Environment.NewLine +
                        "patch=1,EE,21DA8494,extended,00003000                                  " + Environment.NewLine +
                        "patch=1,EE,D094D16C,extended,0004                                      " + Environment.NewLine +
                        "patch=1,EE,21DA8498,extended,FFFFB433                                  " + Environment.NewLine +
                        "patch=1,EE,D094D16C,extended,0005                                   " + Environment.NewLine +
                        "patch=1,EE,21DA8494,extended,FFFFFFFF                                  " + Environment.NewLine +
                        "patch=1,EE,D094D16C,extended,0005                                   " + Environment.NewLine +
                        "patch=1,EE,21DA8498,extended,00000FFF                                  " + Environment.NewLine +
                        "patch=1,EE,D094D16C,extended,0007                                   " + Environment.NewLine +
                        "patch=1,EE,21DA8494,extended,00008306                                  " + Environment.NewLine +
                        "patch=1,EE,D094D16C,extended,000A                                      " + Environment.NewLine +
                        "patch=1,EE,21DA8494,extended,FFFFF692                                 " + Environment.NewLine +
                        "patch=1,EE,D094D16C,extended,000B                                   " + Environment.NewLine +
                        "patch=1,EE,21DA8494,extended,FFFFF7EA                                 " + Environment.NewLine +
                        "patch=1,EE,D094D16C,extended,000B                                   " + Environment.NewLine +
                        "patch=1,EE,21DA8498,extended,FFFFDD99                                 " + Environment.NewLine +
                        "patch=1,EE,D094D16C,extended,000D                                   " + Environment.NewLine +
                        "patch=1,EE,21DA8494,extended,FFFFF692                                  " + Environment.NewLine +
                        "patch=1,EE,D094D16C,extended,000E                                   " + Environment.NewLine +
                        "patch=1,EE,21DA8494,extended,FFFFFFFF                                  " + Environment.NewLine +
                        "patch=1,EE,D094D16C,extended,000E                                   " + Environment.NewLine +
                        "patch=1,EE,21DA8498,extended,00000FFF                                  " + Environment.NewLine +
                        "patch=1,EE,D094D16C,extended,000F                                   " + Environment.NewLine +
                        "patch=1,EE,21DA8494,extended,FFFFF7EA                                  " + Environment.NewLine +
                        "patch=1,EE,D094D16C,extended,000F                                   " + Environment.NewLine +
                        "patch=1,EE,21DA8498,extended,FFFFDD99                                  " + Environment.NewLine +
                        "patch=1,EE,D094D16C,extended,0010                                   " + Environment.NewLine +
                        "patch=1,EE,21DA8494,extended,00002FFE                                  " + Environment.NewLine +
                        "patch=1,EE,D094D16C,extended,0010                                   " + Environment.NewLine +
                        "patch=1,EE,21DA8498,extended,FFFFF500                                  " + Environment.NewLine +
                        "patch=1,EE,D094D16C,extended,0011                                   " + Environment.NewLine +
                        "patch=1,EE,21DA8494,extended,FFFFF692                                  " + Environment.NewLine +
                        "patch=1,EE,D094D16C,extended,0013                                   " + Environment.NewLine +
                        "patch=1,EE,21DA8494,extended,FFFFF000                                  " + Environment.NewLine +
                        "patch=1,EE,D094D16C,extended,0013                                   " + Environment.NewLine +
                        "patch=1,EE,21DA8498,extended,00000500                                  " + Environment.NewLine +
                        "patch=1,EE,D094D16C,extended,0015                                      " + Environment.NewLine +
                        "patch=1,EE,21DA8494,extended,00000A32                                  " + Environment.NewLine +
                        "patch=1,EE,D094D16C,extended,0015                                   " + Environment.NewLine +
                        "patch=1,EE,21DA8498,extended,00000200                                  " + Environment.NewLine +
                        "patch=1,EE,D094D16C,extended,0016                                      " + Environment.NewLine +
                        "patch=1,EE,21DA8494,extended,FFFFF7EA                                  " + Environment.NewLine +
                        "patch=1,EE,D094D16C,extended,0016                                   " + Environment.NewLine +
                        "patch=1,EE,21DA8498,extended,FFFFDD99                                  " + Environment.NewLine +
                        "patch=1,EE,D094D16C,extended,0018                                   " + Environment.NewLine +
                        "patch=1,EE,21DA8494,extended,00008F00                                  " + Environment.NewLine +
                        "patch=1,EE,D094D16C,extended,0018                                      " + Environment.NewLine +
                        "patch=1,EE,21DA8498,extended,00000F00                                  " + Environment.NewLine +
                        "patch=1,EE,D094D16C,extended,001B                                      " + Environment.NewLine +
                        "patch=1,EE,21DA8494,extended,00001000                                 " + Environment.NewLine +
                        "patch=1,EE,D094D16C,extended,001B                                      " + Environment.NewLine +
                        "patch=1,EE,21DA8498,extended,FFFFF500                                 " + Environment.NewLine +
                        "patch=1,EE,D094D16C,extended,001D                                   " + Environment.NewLine +
                        "patch=1,EE,21DA8494,extended,00000FFF                                  " + Environment.NewLine +
                        "patch=1,EE,D094D16C,extended,001D                                   " + Environment.NewLine +
                        "patch=1,EE,21DA8498,extended,00000F00                                  " + Environment.NewLine +
                        "patch=1,EE,D094D16C,extended,0036                                      " + Environment.NewLine +
                        "patch=1,EE,21DA8494,extended,FFFFFA00                                  " + Environment.NewLine +
                        "patch=1,EE,D094D16C,extended,0036                                   " + Environment.NewLine +
                        "patch=1,EE,21DA8498,extended,00001000                                  " + Environment.NewLine +
                        "patch=1,EE,D094D16C,extended,0039                                      " + Environment.NewLine +
                        "patch=1,EE,21DA8494,extended,00005900                                  " + Environment.NewLine +
                        "patch=1,EE,D094D16C,extended,0039                                      " + Environment.NewLine +
                        "patch=1,EE,21DA8498,extended,00000A00                                  " + Environment.NewLine +
                        "patch=1,EE,D094D16C,extended,0043                                   " + Environment.NewLine +
                        "patch=1,EE,21DA8494,extended,00000FFF                                  " + Environment.NewLine +
                        "patch=1,EE,D094D16C,extended,0043                                   " + Environment.NewLine +
                        "patch=1,EE,21DA8498,extended,00000500                                  " + Environment.NewLine +
                        "patch=1,EE,D094D16C,extended,0044                                      " + Environment.NewLine +
                        "patch=1,EE,21DA8494,extended,FFFFFA00                                  " + Environment.NewLine +
                        "patch=1,EE,D094D16C,extended,0044                                   " + Environment.NewLine +
                        "patch=1,EE,21DA8498,extended,00000F00                                  " + Environment.NewLine +
                        "patch=1,EE,D094D16C,extended,0059                                      " + Environment.NewLine +
                        "patch=1,EE,21DA8494,extended,FFFF9200                                  " + Environment.NewLine +
                        "patch=1,EE,D094D16C,extended,0059                                   " + Environment.NewLine +
                        "patch=1,EE,21DA8498,extended,00002FFF                                  " + Environment.NewLine +
                        "patch=1,EE,D094D16C,extended,005A                                   " + Environment.NewLine +
                        "patch=1,EE,21DA8494,extended,000009FF                                 " + Environment.NewLine +
                        "patch=1,EE,D094D16C,extended,005A                                   " + Environment.NewLine +
                        "patch=1,EE,21DA8498,extended,FFFFF500                                 " + Environment.NewLine +
                        "patch=1,EE,D094D16C,extended,0062                                   " + Environment.NewLine +
                        "patch=1,EE,21DA8494,extended,FFFFF500                                  " + Environment.NewLine +
                        "patch=1,EE,D094D16C,extended,0062                                   " + Environment.NewLine +
                        "patch=1,EE,21DA8498,extended,00000C00                                  " + Environment.NewLine +
                        "patch=1,EE,D094D16C,extended,0010                                   " + Environment.NewLine +
                        "patch=1,EE,105860F0,extended,0BF8                                      " + Environment.NewLine +
                        "patch=1,EE,D094D16C,extended,0010                                   " + Environment.NewLine +
                        "patch=1,EE,10577690,extended,0D85                                      " + Environment.NewLine +
                        "patch=1,EE,D094D16C,extended,0010                                      " + Environment.NewLine +
                        "patch=1,EE,10586164,extended,0EDC                                      " + Environment.NewLine +
                        "patch=1,EE,D094D16C,extended,0010                                   " + Environment.NewLine +
                        "patch=1,EE,10586180,extended,0CFC                                      " + Environment.NewLine +
            "";

            ExportPnach.ExportFile(baseCode);
        }

        public static void MarshallLawAndPaulPhoenixCustomizedTeam()
        {
            baseCode = "" +
                        "//Marshall Law & Paul Phoenix 𝓒𝓾𝓼𝓽𝓸𝓶𝓲𝔃𝓮𝓭                                 " + Environment.NewLine +
                            "//switch camera [R2+L3 = ON | R2+R3=OFF]                    " + Environment.NewLine +
                            "patch=1,EE,D0359852,extended,FDFD                           " + Environment.NewLine +
                            "patch=1,EE,004616C0,extended,08                             " + Environment.NewLine +
                            "patch=1,EE,D0359852,extended,FDFD                           " + Environment.NewLine +
                            "patch=1,EE,004614D0,extended,05                             " + Environment.NewLine +
                            "patch=1,EE,D0359852,extended,FDFB                           " + Environment.NewLine +
                            "patch=1,EE,004616C0,extended,00                             " + Environment.NewLine +
                            "patch=1,EE,D0359852,extended,FDFB                           " + Environment.NewLine +
                            "patch=1,EE,004614D0,extended,06                             " + Environment.NewLine +
                        "//Players                                                                 " + Environment.NewLine +
                        "patch=1,EE,D09449FC,extended,0018 //Skip Select Fighter                 " + Environment.NewLine +
                        "patch=1,EE,109449FC,extended,0019 //Skip Select Fighter                 " + Environment.NewLine +
                        "patch=1,EE,1094A5EC,extended,003C //FORCE Marshall Law As P1            " + Environment.NewLine +
                        "patch=1,EE,11DA84A0,extended,003B //FORCE Paul Phoenix As P2           " + Environment.NewLine +
                        "patch=1,EE,205AF6E4,extended,003A003A //Partner A.I                    " + Environment.NewLine +
                        "                                                                          " + Environment.NewLine +
                        "//Marshall Law                                                            " + Environment.NewLine +
                        "patch=1,EE,1057C860,extended,0CE7                                      " + Environment.NewLine +
                        "patch=1,EE,2057C89C,extended,0EC40C32                                  " + Environment.NewLine +
                        "patch=1,EE,2057C8BA,extended,0C3F0C3D                                  " + Environment.NewLine +
                        "patch=1,EE,2057C864,extended,0CEC0CF9                                  " + Environment.NewLine +
                        "patch=1,EE,2057C882,extended,0CCB0CFB                                  " + Environment.NewLine +
                        "patch=1,EE,2057C8A0,extended,0D020D07                                  " + Environment.NewLine +
                        "patch=1,EE,2057C8BE,extended,0D010D06                                   " + Environment.NewLine +
                        "patch=1,EE,1052DCC6,extended,0CDB                                       " + Environment.NewLine +
                        "patch=1,EE,1052DCF0,extended,0CDB                                      " + Environment.NewLine +
                        "                                                                          " + Environment.NewLine +
                        "//Marshall Law [⚫]                                                       " + Environment.NewLine +
                        "patch=1,EE,1057C7F2,extended,0AFE                                      " + Environment.NewLine +
                        "patch=1,EE,1057C822,extended,09DC                                      " + Environment.NewLine +
                        "patch=1,EE,1055021C,extended,0AFD                                      " + Environment.NewLine +
                        "patch=1,EE,10552D96,extended,09CD                                      " + Environment.NewLine +
                        "patch=1,EE,2057C7DC,extended,09D009D0                                  " + Environment.NewLine +
                        "patch=1,EE,2057C824,extended,0B3D0B3E                                   " + Environment.NewLine +
                        "patch=1,EE,2057C80C,extended,09250925                                   " + Environment.NewLine +
                        "patch=1,EE,104F1EDC,extended,001C                                       " + Environment.NewLine +
                        "patch=1,EE,104F1EE4,extended,001B                                      " + Environment.NewLine +
                        "patch=1,EE,1054EBBA,extended,09DE                                      " + Environment.NewLine +
                        "patch=1,EE,1057C7F8,extended,09B2                                      " + Environment.NewLine +
                        "                                                                          " + Environment.NewLine +
                        "//Marshall Law [▲]                                                        " + Environment.NewLine +
                        "patch=1,EE,1057C84A,extended,0EB9                                      " + Environment.NewLine +
                        "patch=1,EE,1057C84E,extended,0EB9                                      " + Environment.NewLine +
                        "                                                                          " + Environment.NewLine +
                        "//Marshall Law [⚫+▲]                                                     " + Environment.NewLine +
                        "patch=1,EE,1057C696,extended,0B5D                                      " + Environment.NewLine +
                        "patch=1,EE,1057C694,extended,09BB                                       " + Environment.NewLine +
                        "                                                                          " + Environment.NewLine +
                        "//Paul Phoenix                                                            " + Environment.NewLine +
                        "patch=1,EE,1057C598,extended,0CE7                                      " + Environment.NewLine +
                        "patch=1,EE,2057C5D4,extended,0EC40C32                                  " + Environment.NewLine +
                        "patch=1,EE,2057C5F2,extended,0C3F0C3D                                  " + Environment.NewLine +
                        "patch=1,EE,2057C59C,extended,0CEC0F5A                                  " + Environment.NewLine +
                        "patch=1,EE,2057C5BA,extended,0CCB0CEA                                  " + Environment.NewLine +
                        "patch=1,EE,2057C5D8,extended,0D020D07                                  " + Environment.NewLine +
                        "patch=1,EE,2057C5F6,extended,0D010D06                                   " + Environment.NewLine +
                        "                                                                          " + Environment.NewLine +
                        "//Paul Phoenix [⚫]                                                       " + Environment.NewLine +
                        "patch=1,EE,1057C55A,extended,09D6                                       " + Environment.NewLine +
                        "patch=1,EE,1054BBCC,extended,09B7                                       " + Environment.NewLine +
                        "patch=1,EE,1054FD30,extended,0AF1                                      " + Environment.NewLine +
                        "patch=1,EE,10552B02,extended,09C5                                      " + Environment.NewLine +
                        "patch=1,EE,2057C544,extended,07E907E9                                  " + Environment.NewLine +
                        "patch=1,EE,104DFB8C,extended,00B9                                      " + Environment.NewLine +
                        "patch=1,EE,104DFB94,extended,00B8                                      " + Environment.NewLine +
                        "patch=1,EE,2057C55C,extended,0B3D0B3E                                  " + Environment.NewLine +
                        "patch=1,EE,1054FCF4,extended,09CF                                       " + Environment.NewLine +
                        "patch=1,EE,1057C560,extended,09DF                                      " + Environment.NewLine +
                        "                                                                          " + Environment.NewLine +
                        "//Paul Phoenix [▲]                                                        " + Environment.NewLine +
                        "patch=1,EE,1057C582,extended,0EB9                                      " + Environment.NewLine +
                        "patch=1,EE,1057C586,extended,0EB9                                      " + Environment.NewLine +
                        "patch=1,EE,1057C5BE,extended,0EA4                                      " + Environment.NewLine +
                        "patch=1,EE,1057C5C0,extended,0CF7                                      " + Environment.NewLine +
                        "                                                                          " + Environment.NewLine +
                        "//Paul Phoenix [⚫+▲]                                                     " + Environment.NewLine +
                        "patch=1,EE,1057C3CE,extended,07D5                                      " + Environment.NewLine +
                        "                                                                          " + Environment.NewLine +
                        "//Park                                                                    " + Environment.NewLine +
                        "patch=1,EE,2057A11C,extended,0BCF0BD0                                   " + Environment.NewLine +
                        "                                                                          " + Environment.NewLine +
                        "//Dwayne                                                                  " + Environment.NewLine +
                        "patch=1,EE,2057A974,extended,0BCF0BD0                                  " + Environment.NewLine +
                        "                                                                          " + Environment.NewLine +
                        "//MAX Stats                                                               " + Environment.NewLine +
                        "patch=1,EE,105A6018,extended,03E8 //P1                                 " + Environment.NewLine +
                        "patch=1,EE,105A601A,extended,03E8                                       " + Environment.NewLine +
                        "patch=1,EE,105A601C,extended,03E8                                       " + Environment.NewLine +
                        "patch=1,EE,105A601E,extended,03E8                                       " + Environment.NewLine +
                        "patch=1,EE,105A6020,extended,03E8                                       " + Environment.NewLine +
                        "patch=1,EE,105A6022,extended,03E8                                       " + Environment.NewLine +
                        "patch=1,EE,105A5FD2,extended,01F4                                       " + Environment.NewLine +
                        "patch=1,EE,105A5FD4,extended,01F4                                       " + Environment.NewLine +
                        "patch=1,EE,105A5FD6,extended,01F4                                       " + Environment.NewLine +
                        "patch=1,EE,105AF768,extended,03E8 //P2                                  " + Environment.NewLine +
                        "patch=1,EE,105AF76A,extended,03E8                                       " + Environment.NewLine +
                        "patch=1,EE,105AF76C,extended,03E8                                       " + Environment.NewLine +
                        "patch=1,EE,105AF76E,extended,03E8                                       " + Environment.NewLine +
                        "patch=1,EE,105AF770,extended,03E8                                       " + Environment.NewLine +
                        "patch=1,EE,105AF772,extended,03E8                                       " + Environment.NewLine +
                        "patch=1,EE,105AF722,extended,01F4                                       " + Environment.NewLine +
                        "patch=1,EE,105AF724,extended,01F4                                       " + Environment.NewLine +
                        "patch=1,EE,105AF726,extended,01F4                                       " + Environment.NewLine +
                        "                                                                          " + Environment.NewLine +
                        "//Enable Partner                                                          " + Environment.NewLine +
                        "patch=1,EE,105AF666,extended,0000 //P2 Is Ally                          " + Environment.NewLine +
                        "patch=1,EE,D094D16C,extended,0000                                       " + Environment.NewLine +
                        "patch=1,EE,21DA8494,extended,FFFFF7EA                                   " + Environment.NewLine +
                        "patch=1,EE,D094D16C,extended,0000                                    " + Environment.NewLine +
                        "patch=1,EE,21DA8498,extended,FFFFF128                                   " + Environment.NewLine +
                        "patch=1,EE,D094D16C,extended,0002                                    " + Environment.NewLine +
                        "patch=1,EE,21DA8494,extended,FFFFF692                                   " + Environment.NewLine +
                        "patch=1,EE,D094D16C,extended,0004                                    " + Environment.NewLine +
                        "patch=1,EE,21DA8494,extended,00003000                                   " + Environment.NewLine +
                        "patch=1,EE,D094D16C,extended,0004                                       " + Environment.NewLine +
                        "patch=1,EE,21DA8498,extended,FFFFB433                                   " + Environment.NewLine +
                        "patch=1,EE,D094D16C,extended,0005                                    " + Environment.NewLine +
                        "patch=1,EE,21DA8494,extended,FFFFFFFF                                   " + Environment.NewLine +
                        "patch=1,EE,D094D16C,extended,0005                                    " + Environment.NewLine +
                        "patch=1,EE,21DA8498,extended,00000FFF                                   " + Environment.NewLine +
                        "patch=1,EE,D094D16C,extended,0007                                    " + Environment.NewLine +
                        "patch=1,EE,21DA8494,extended,00008306                                   " + Environment.NewLine +
                        "patch=1,EE,D094D16C,extended,000A                                       " + Environment.NewLine +
                        "patch=1,EE,21DA8494,extended,FFFFF692                                  " + Environment.NewLine +
                        "patch=1,EE,D094D16C,extended,000B                                    " + Environment.NewLine +
                        "patch=1,EE,21DA8494,extended,FFFFF7EA                                  " + Environment.NewLine +
                        "patch=1,EE,D094D16C,extended,000B                                    " + Environment.NewLine +
                        "patch=1,EE,21DA8498,extended,FFFFDD99                                  " + Environment.NewLine +
                        "patch=1,EE,D094D16C,extended,000D                                    " + Environment.NewLine +
                        "patch=1,EE,21DA8494,extended,FFFFF692                                   " + Environment.NewLine +
                        "patch=1,EE,D094D16C,extended,000E                                    " + Environment.NewLine +
                        "patch=1,EE,21DA8494,extended,FFFFFFFF                                   " + Environment.NewLine +
                        "patch=1,EE,D094D16C,extended,000E                                    " + Environment.NewLine +
                        "patch=1,EE,21DA8498,extended,00000FFF                                   " + Environment.NewLine +
                        "patch=1,EE,D094D16C,extended,000F                                    " + Environment.NewLine +
                        "patch=1,EE,21DA8494,extended,FFFFF7EA                                   " + Environment.NewLine +
                        "patch=1,EE,D094D16C,extended,000F                                    " + Environment.NewLine +
                        "patch=1,EE,21DA8498,extended,FFFFDD99                                   " + Environment.NewLine +
                        "patch=1,EE,D094D16C,extended,0010                                    " + Environment.NewLine +
                        "patch=1,EE,21DA8494,extended,00002FFE                                   " + Environment.NewLine +
                        "patch=1,EE,D094D16C,extended,0010                                    " + Environment.NewLine +
                        "patch=1,EE,21DA8498,extended,FFFFF500                                   " + Environment.NewLine +
                        "patch=1,EE,D094D16C,extended,0011                                    " + Environment.NewLine +
                        "patch=1,EE,21DA8494,extended,FFFFF692                                   " + Environment.NewLine +
                        "patch=1,EE,D094D16C,extended,0013                                    " + Environment.NewLine +
                        "patch=1,EE,21DA8494,extended,FFFFF000                                   " + Environment.NewLine +
                        "patch=1,EE,D094D16C,extended,0013                                    " + Environment.NewLine +
                        "patch=1,EE,21DA8498,extended,00000500                                   " + Environment.NewLine +
                        "patch=1,EE,D094D16C,extended,0015                                       " + Environment.NewLine +
                        "patch=1,EE,21DA8494,extended,00000A32                                   " + Environment.NewLine +
                        "patch=1,EE,D094D16C,extended,0015                                    " + Environment.NewLine +
                        "patch=1,EE,21DA8498,extended,00000200                                   " + Environment.NewLine +
                        "patch=1,EE,D094D16C,extended,0016                                       " + Environment.NewLine +
                        "patch=1,EE,21DA8494,extended,FFFFF7EA                                   " + Environment.NewLine +
                        "patch=1,EE,D094D16C,extended,0016                                    " + Environment.NewLine +
                        "patch=1,EE,21DA8498,extended,FFFFDD99                                   " + Environment.NewLine +
                        "patch=1,EE,D094D16C,extended,0018                                    " + Environment.NewLine +
                        "patch=1,EE,21DA8494,extended,00008F00                                   " + Environment.NewLine +
                        "patch=1,EE,D094D16C,extended,0018                                       " + Environment.NewLine +
                        "patch=1,EE,21DA8498,extended,00000F00                                   " + Environment.NewLine +
                        "patch=1,EE,D094D16C,extended,001B                                       " + Environment.NewLine +
                        "patch=1,EE,21DA8494,extended,00001000                                  " + Environment.NewLine +
                        "patch=1,EE,D094D16C,extended,001B                                       " + Environment.NewLine +
                        "patch=1,EE,21DA8498,extended,FFFFF500                                  " + Environment.NewLine +
                        "patch=1,EE,D094D16C,extended,001D                                    " + Environment.NewLine +
                        "patch=1,EE,21DA8494,extended,00000FFF                                   " + Environment.NewLine +
                        "patch=1,EE,D094D16C,extended,001D                                    " + Environment.NewLine +
                        "patch=1,EE,21DA8498,extended,00000F00                                   " + Environment.NewLine +
                        "patch=1,EE,D094D16C,extended,0036                                       " + Environment.NewLine +
                        "patch=1,EE,21DA8494,extended,FFFFFA00                                   " + Environment.NewLine +
                        "patch=1,EE,D094D16C,extended,0036                                    " + Environment.NewLine +
                        "patch=1,EE,21DA8498,extended,00001000                                   " + Environment.NewLine +
                        "patch=1,EE,D094D16C,extended,0039                                       " + Environment.NewLine +
                        "patch=1,EE,21DA8494,extended,00005900                                   " + Environment.NewLine +
                        "patch=1,EE,D094D16C,extended,0039                                       " + Environment.NewLine +
                        "patch=1,EE,21DA8498,extended,00000A00                                   " + Environment.NewLine +
                        "patch=1,EE,D094D16C,extended,0043                                    " + Environment.NewLine +
                        "patch=1,EE,21DA8494,extended,00000FFF                                   " + Environment.NewLine +
                        "patch=1,EE,D094D16C,extended,0043                                    " + Environment.NewLine +
                        "patch=1,EE,21DA8498,extended,00000500                                   " + Environment.NewLine +
                        "patch=1,EE,D094D16C,extended,0044                                       " + Environment.NewLine +
                        "patch=1,EE,21DA8494,extended,FFFFFA00                                   " + Environment.NewLine +
                        "patch=1,EE,D094D16C,extended,0044                                    " + Environment.NewLine +
                        "patch=1,EE,21DA8498,extended,00000F00                                   " + Environment.NewLine +
                        "patch=1,EE,D094D16C,extended,0059                                       " + Environment.NewLine +
                        "patch=1,EE,21DA8494,extended,FFFF9200                                   " + Environment.NewLine +
                        "patch=1,EE,D094D16C,extended,0059                                    " + Environment.NewLine +
                        "patch=1,EE,21DA8498,extended,00002FFF                                   " + Environment.NewLine +
                        "patch=1,EE,D094D16C,extended,005A                                    " + Environment.NewLine +
                        "patch=1,EE,21DA8494,extended,000009FF                                  " + Environment.NewLine +
                        "patch=1,EE,D094D16C,extended,005A                                    " + Environment.NewLine +
                        "patch=1,EE,21DA8498,extended,FFFFF500                                  " + Environment.NewLine +
                        "patch=1,EE,D094D16C,extended,0062                                    " + Environment.NewLine +
                        "patch=1,EE,21DA8494,extended,FFFFF500                                   " + Environment.NewLine +
                        "patch=1,EE,D094D16C,extended,0062                                    " + Environment.NewLine +
                        "patch=1,EE,21DA8498,extended,00000C00                                   " + Environment.NewLine +
                        "patch=1,EE,D094D16C,extended,0010                                    " + Environment.NewLine +
                        "patch=1,EE,105860F0,extended,0BF8                                       " + Environment.NewLine +
                        "patch=1,EE,D094D16C,extended,0010                                    " + Environment.NewLine +
                        "patch=1,EE,10577690,extended,0D85                                       " + Environment.NewLine +
                        "patch=1,EE,D094D16C,extended,0010                                       " + Environment.NewLine +
                        "patch=1,EE,10586164,extended,0EDC                                       " + Environment.NewLine +
                        "patch=1,EE,D094D16C,extended,0010                                    " + Environment.NewLine +
                        "patch=1,EE,10586180,extended,0CFC                                       " + Environment.NewLine +
            "";

            ExportPnach.ExportFile(baseCode);
        }

        public static void ShunYingAndMarshallLawCustomizedTeam()
        {
            baseCode = "" +
                        "//Shun Ying & Marshall Law 𝓒𝓾𝓼𝓽𝓸𝓶𝓲𝔃𝓮𝓭                                      " + Environment.NewLine +
                            "//switch camera [R2+L3 = ON | R2+R3=OFF]                    " + Environment.NewLine +
                            "patch=1,EE,D0359852,extended,FDFD                           " + Environment.NewLine +
                            "patch=1,EE,004616C0,extended,08                             " + Environment.NewLine +
                            "patch=1,EE,D0359852,extended,FDFD                           " + Environment.NewLine +
                            "patch=1,EE,004614D0,extended,05                             " + Environment.NewLine +
                            "patch=1,EE,D0359852,extended,FDFB                           " + Environment.NewLine +
                            "patch=1,EE,004616C0,extended,00                             " + Environment.NewLine +
                            "patch=1,EE,D0359852,extended,FDFB                           " + Environment.NewLine +
                            "patch=1,EE,004614D0,extended,06                             " + Environment.NewLine +
                        "//Players                                                                   " + Environment.NewLine +
                        "patch=1,EE,D09449FC,extended,0018 //Skip Select Fighter                   " + Environment.NewLine +
                        "patch=1,EE,109449FC,extended,0019 //Skip Select Fighter                   " + Environment.NewLine +
                        "patch=1,EE,1094A5EC,extended,001F //FORCE Shun Ying As P1                 " + Environment.NewLine +
                        "patch=1,EE,11DA84A0,extended,003C //FORCE Marshall Law As P2              " + Environment.NewLine +
                        "patch=1,EE,205AF6E4,extended,003A003A //Partner A.I                      " + Environment.NewLine +
                        "                                                                            " + Environment.NewLine +
                        "//Shun Ying                                                                 " + Environment.NewLine +
                        "patch=1,EE,20579F02,extended,0C3F0C3D                                    " + Environment.NewLine +
                        "patch=1,EE,20579EE4,extended,0EC40C32                                    " + Environment.NewLine +
                        "patch=1,EE,10579EA8,extended,0CE7                                        " + Environment.NewLine +
                        "patch=1,EE,20579ECA,extended,0CCB0CFB                                    " + Environment.NewLine +
                        "patch=1,EE,20579EAC,extended,0CEC0CF9                                    " + Environment.NewLine +
                        "patch=1,EE,20579F06,extended,0D010D06                                    " + Environment.NewLine +
                        "patch=1,EE,20579EE8,extended,0D020D07                                     " + Environment.NewLine +
                        "patch=1,EE,10576194,extended,0D19                                         " + Environment.NewLine +
                        "patch=1,EE,1057676C,extended,0D0E                                         " + Environment.NewLine +
                        "                                                                            " + Environment.NewLine +
                        "//Shun Ying [▲]                                                             " + Environment.NewLine +
                        "patch=1,EE,10579E92,extended,0F2C                                         " + Environment.NewLine +
                        "patch=1,EE,10579E96,extended,0F2C                                        " + Environment.NewLine +
                        "patch=1,EE,1058E98A,extended,0F2C                                        " + Environment.NewLine +
                        "patch=1,EE,1058E98E,extended,0F2C                                        " + Environment.NewLine +
                        "patch=1,EE,10579EB0,extended,0E98                                        " + Environment.NewLine +
                        "patch=1,EE,10579EB2,extended,0DE6                                         " + Environment.NewLine +
                        "patch=1,EE,10579EEC,extended,0C65                                        " + Environment.NewLine +
                        "patch=1,EE,10579EEE,extended,0E81                                        " + Environment.NewLine +
                        "patch=1,EE,10579ED0,extended,0E9A                                         " + Environment.NewLine +
                        "patch=1,EE,10579EB4,extended,0E99                                        " + Environment.NewLine +
                        "patch=1,EE,10579EF0,extended,0C69                                         " + Environment.NewLine +
                        "patch=1,EE,10579E9E,extended,0619                                        " + Environment.NewLine +
                        "patch=1,EE,10579EA2,extended,061B                                         " + Environment.NewLine +
                        "                                                                            " + Environment.NewLine +
                        "//Shun Ying [⚫]                                                            " + Environment.NewLine +
                        "patch=1,EE,1054D102,extended,09D0                                        " + Environment.NewLine +
                        "patch=1,EE,1054D1B6,extended,09D0                                         " + Environment.NewLine +
                        "patch=1,EE,2054D198,extended,09D2                                         " + Environment.NewLine +
                        "patch=1,EE,1054D468,extended,06F9                                         " + Environment.NewLine +
                        "patch=1,EE,1054D42C,extended,06F9                                         " + Environment.NewLine +
                        "patch=1,EE,10579E3A,extended,0AFE                                         " + Environment.NewLine +
                        "patch=1,EE,2058E91C,extended,097E097F                                    " + Environment.NewLine +
                        "patch=1,EE,20579E6C,extended,08950895                                     " + Environment.NewLine +
                        "patch=1,EE,20579E3C,extended,07E507E5                                     " + Environment.NewLine +
                        "patch=1,EE,1054BABE,extended,0AFE                                        " + Environment.NewLine +
                        "patch=1,EE,D0359852,extended,FFFF //                                  " + Environment.NewLine +
                        "patch=1,EE,10552E4A,extended,0AC6                                         " + Environment.NewLine +
                        "patch=1,EE,D0359852,extended,F7FF //R1                                " + Environment.NewLine +
                        "patch=1,EE,10552E4A,extended,0AFD                                         " + Environment.NewLine +
                        "patch=1,EE,20579E54,extended,07E907E9                                    " + Environment.NewLine +
                        "patch=1,EE,104DFB8C,extended,00B9                                        " + Environment.NewLine +
                        "patch=1,EE,104DFB94,extended,00B8                                        " + Environment.NewLine +
                        "patch=1,EE,1054BBCC,extended,09DD                                        " + Environment.NewLine +
                        "patch=1,EE,1055021C,extended,FFFF                                        " + Environment.NewLine +
                        "patch=1,EE,10579E28,extended,09CF                                        " + Environment.NewLine +
                        "patch=1,EE,10579E70,extended,09E0                                        " + Environment.NewLine +
                        "patch=1,EE,10579E52,extended,09DE                                         " + Environment.NewLine +
                        "                                                                            " + Environment.NewLine +
                        "//Shun Ying [⬛]                                                             " + Environment.NewLine +
                        "patch=1,EE,10579DAC,extended,0E98                                        " + Environment.NewLine +
                        "                                                                            " + Environment.NewLine +
                        "//Park                                                                      " + Environment.NewLine +
                        "patch=1,EE,2057A11C,extended,0BCF0BD0                                     " + Environment.NewLine +
                        "patch=1,EE,2057A0EC,extended,05BE05BF                                    " + Environment.NewLine +
                        "                                                                            " + Environment.NewLine +
                        "//Marshall Law                                                              " + Environment.NewLine +
                        "patch=1,EE,1057C860,extended,0CE7                                        " + Environment.NewLine +
                        "patch=1,EE,2057C89C,extended,0EC40C32                                    " + Environment.NewLine +
                        "patch=1,EE,2057C8BA,extended,0C3F0C3D                                    " + Environment.NewLine +
                        "patch=1,EE,2057C864,extended,0CEC0CF9                                    " + Environment.NewLine +
                        "patch=1,EE,2057C882,extended,0CCB0CFB                                    " + Environment.NewLine +
                        "patch=1,EE,2057C8A0,extended,0D020D07                                    " + Environment.NewLine +
                        "patch=1,EE,2057C8BE,extended,0D010D06                                     " + Environment.NewLine +
                        "patch=1,EE,1052DCC6,extended,0CDB                                         " + Environment.NewLine +
                        "patch=1,EE,1052DCF0,extended,0CDB                                        " + Environment.NewLine +
                        "                                                                            " + Environment.NewLine +
                        "//Marshall Law [⚫]                                                         " + Environment.NewLine +
                        "patch=1,EE,1057C7F2,extended,09CE                                        " + Environment.NewLine +
                        "patch=1,EE,1057C812,extended,0AC5                                        " + Environment.NewLine +
                        "patch=1,EE,2057C7DC,extended,09D009D0                                    " + Environment.NewLine +
                        "patch=1,EE,2057C824,extended,095A095A                                     " + Environment.NewLine +
                        "patch=1,EE,1054F394,extended,0987                                        " + Environment.NewLine +
                        "patch=1,EE,2057C80C,extended,07E907E9                                     " + Environment.NewLine +
                        "patch=1,EE,1057C7E0,extended,09CF                                        " + Environment.NewLine +
                        "patch=1,EE,1057C7F8,extended,04D5                                        " + Environment.NewLine +
                        "                                                                            " + Environment.NewLine +
                        "//Marshall Law [⚫+▲]                                                       " + Environment.NewLine +
                        "patch=1,EE,1057C696,extended,0A99                                         " + Environment.NewLine +
                        "patch=1,EE,1057C694,extended,068E                                        " + Environment.NewLine +
                        "                                                                            " + Environment.NewLine +
                        "//The Hell's Legions                                                        " + Environment.NewLine +
                        "patch=1,EE,20581B94,extended,05C405C3                                     " + Environment.NewLine +
                        "patch=1,EE,20581E5C,extended,05C405C3                                    " + Environment.NewLine +
                        "patch=1,EE,20582124,extended,05C405C3                                    " + Environment.NewLine +
                        "                                                                            " + Environment.NewLine +
                        "//MAX Stats                                                                 " + Environment.NewLine +
                        "patch=1,EE,105A6018,extended,03E8 //P1                                   " + Environment.NewLine +
                        "patch=1,EE,105A601A,extended,03E8                                         " + Environment.NewLine +
                        "patch=1,EE,105A601C,extended,03E8                                         " + Environment.NewLine +
                        "patch=1,EE,105A601E,extended,03E8                                         " + Environment.NewLine +
                        "patch=1,EE,105A6020,extended,03E8                                         " + Environment.NewLine +
                        "patch=1,EE,105A6022,extended,03E8                                         " + Environment.NewLine +
                        "patch=1,EE,105A5FD2,extended,01F4                                         " + Environment.NewLine +
                        "patch=1,EE,105A5FD4,extended,01F4                                         " + Environment.NewLine +
                        "patch=1,EE,105A5FD6,extended,01F4                                         " + Environment.NewLine +
                        "patch=1,EE,105AF768,extended,03E8 //P2                                    " + Environment.NewLine +
                        "patch=1,EE,105AF76A,extended,03E8                                         " + Environment.NewLine +
                        "patch=1,EE,105AF76C,extended,03E8                                         " + Environment.NewLine +
                        "patch=1,EE,105AF76E,extended,03E8                                         " + Environment.NewLine +
                        "patch=1,EE,105AF770,extended,03E8                                         " + Environment.NewLine +
                        "patch=1,EE,105AF772,extended,03E8                                         " + Environment.NewLine +
                        "patch=1,EE,105AF722,extended,01F4                                         " + Environment.NewLine +
                        "patch=1,EE,105AF724,extended,01F4                                         " + Environment.NewLine +
                        "patch=1,EE,105AF726,extended,01F4                                         " + Environment.NewLine +
                        "                                                                            " + Environment.NewLine +
                        "//Enable Partner                                                            " + Environment.NewLine +
                        "patch=1,EE,105AF666,extended,0000 //P2 Is Ally                            " + Environment.NewLine +
                        "patch=1,EE,D094D16C,extended,0000                                         " + Environment.NewLine +
                        "patch=1,EE,21DA8494,extended,FFFFF7EA                                     " + Environment.NewLine +
                        "patch=1,EE,D094D16C,extended,0000                                      " + Environment.NewLine +
                        "patch=1,EE,21DA8498,extended,FFFFF128                                     " + Environment.NewLine +
                        "patch=1,EE,D094D16C,extended,0002                                      " + Environment.NewLine +
                        "patch=1,EE,21DA8494,extended,FFFFF692                                     " + Environment.NewLine +
                        "patch=1,EE,D094D16C,extended,0004                                      " + Environment.NewLine +
                        "patch=1,EE,21DA8494,extended,00003000                                     " + Environment.NewLine +
                        "patch=1,EE,D094D16C,extended,0004                                         " + Environment.NewLine +
                        "patch=1,EE,21DA8498,extended,FFFFB433                                     " + Environment.NewLine +
                        "patch=1,EE,D094D16C,extended,0005                                      " + Environment.NewLine +
                        "patch=1,EE,21DA8494,extended,FFFFFFFF                                     " + Environment.NewLine +
                        "patch=1,EE,D094D16C,extended,0005                                      " + Environment.NewLine +
                        "patch=1,EE,21DA8498,extended,00000FFF                                     " + Environment.NewLine +
                        "patch=1,EE,D094D16C,extended,0007                                      " + Environment.NewLine +
                        "patch=1,EE,21DA8494,extended,00008306                                     " + Environment.NewLine +
                        "patch=1,EE,D094D16C,extended,000A                                         " + Environment.NewLine +
                        "patch=1,EE,21DA8494,extended,FFFFF692                                    " + Environment.NewLine +
                        "patch=1,EE,D094D16C,extended,000B                                      " + Environment.NewLine +
                        "patch=1,EE,21DA8494,extended,FFFFF7EA                                    " + Environment.NewLine +
                        "patch=1,EE,D094D16C,extended,000B                                      " + Environment.NewLine +
                        "patch=1,EE,21DA8498,extended,FFFFDD99                                    " + Environment.NewLine +
                        "patch=1,EE,D094D16C,extended,000D                                      " + Environment.NewLine +
                        "patch=1,EE,21DA8494,extended,FFFFF692                                     " + Environment.NewLine +
                        "patch=1,EE,D094D16C,extended,000E                                      " + Environment.NewLine +
                        "patch=1,EE,21DA8494,extended,FFFFFFFF                                     " + Environment.NewLine +
                        "patch=1,EE,D094D16C,extended,000E                                      " + Environment.NewLine +
                        "patch=1,EE,21DA8498,extended,00000FFF                                     " + Environment.NewLine +
                        "patch=1,EE,D094D16C,extended,000F                                      " + Environment.NewLine +
                        "patch=1,EE,21DA8494,extended,FFFFF7EA                                     " + Environment.NewLine +
                        "patch=1,EE,D094D16C,extended,000F                                      " + Environment.NewLine +
                        "patch=1,EE,21DA8498,extended,FFFFDD99                                     " + Environment.NewLine +
                        "patch=1,EE,D094D16C,extended,0010                                      " + Environment.NewLine +
                        "patch=1,EE,21DA8494,extended,00002FFE                                     " + Environment.NewLine +
                        "patch=1,EE,D094D16C,extended,0010                                      " + Environment.NewLine +
                        "patch=1,EE,21DA8498,extended,FFFFF500                                     " + Environment.NewLine +
                        "patch=1,EE,D094D16C,extended,0011                                      " + Environment.NewLine +
                        "patch=1,EE,21DA8494,extended,FFFFF692                                     " + Environment.NewLine +
                        "patch=1,EE,D094D16C,extended,0013                                      " + Environment.NewLine +
                        "patch=1,EE,21DA8494,extended,FFFFF000                                     " + Environment.NewLine +
                        "patch=1,EE,D094D16C,extended,0013                                      " + Environment.NewLine +
                        "patch=1,EE,21DA8498,extended,00000500                                     " + Environment.NewLine +
                        "patch=1,EE,D094D16C,extended,0015                                         " + Environment.NewLine +
                        "patch=1,EE,21DA8494,extended,00000A32                                     " + Environment.NewLine +
                        "patch=1,EE,D094D16C,extended,0015                                      " + Environment.NewLine +
                        "patch=1,EE,21DA8498,extended,00000200                                     " + Environment.NewLine +
                        "patch=1,EE,D094D16C,extended,0016                                         " + Environment.NewLine +
                        "patch=1,EE,21DA8494,extended,FFFFF7EA                                     " + Environment.NewLine +
                        "patch=1,EE,D094D16C,extended,0016                                      " + Environment.NewLine +
                        "patch=1,EE,21DA8498,extended,FFFFDD99                                     " + Environment.NewLine +
                        "patch=1,EE,D094D16C,extended,0018                                      " + Environment.NewLine +
                        "patch=1,EE,21DA8494,extended,00008F00                                     " + Environment.NewLine +
                        "patch=1,EE,D094D16C,extended,0018                                         " + Environment.NewLine +
                        "patch=1,EE,21DA8498,extended,00000F00                                     " + Environment.NewLine +
                        "patch=1,EE,D094D16C,extended,001B                                         " + Environment.NewLine +
                        "patch=1,EE,21DA8494,extended,00001000                                    " + Environment.NewLine +
                        "patch=1,EE,D094D16C,extended,001B                                         " + Environment.NewLine +
                        "patch=1,EE,21DA8498,extended,FFFFF500                                    " + Environment.NewLine +
                        "patch=1,EE,D094D16C,extended,001D                                      " + Environment.NewLine +
                        "patch=1,EE,21DA8494,extended,00000FFF                                     " + Environment.NewLine +
                        "patch=1,EE,D094D16C,extended,001D                                      " + Environment.NewLine +
                        "patch=1,EE,21DA8498,extended,00000F00                                     " + Environment.NewLine +
                        "patch=1,EE,D094D16C,extended,0036                                         " + Environment.NewLine +
                        "patch=1,EE,21DA8494,extended,FFFFFA00                                     " + Environment.NewLine +
                        "patch=1,EE,D094D16C,extended,0036                                      " + Environment.NewLine +
                        "patch=1,EE,21DA8498,extended,00001000                                     " + Environment.NewLine +
                        "patch=1,EE,D094D16C,extended,0039                                         " + Environment.NewLine +
                        "patch=1,EE,21DA8494,extended,00005900                                     " + Environment.NewLine +
                        "patch=1,EE,D094D16C,extended,0039                                         " + Environment.NewLine +
                        "patch=1,EE,21DA8498,extended,00000A00                                     " + Environment.NewLine +
                        "patch=1,EE,D094D16C,extended,0043                                      " + Environment.NewLine +
                        "patch=1,EE,21DA8494,extended,00000FFF                                     " + Environment.NewLine +
                        "patch=1,EE,D094D16C,extended,0043                                      " + Environment.NewLine +
                        "patch=1,EE,21DA8498,extended,00000500                                     " + Environment.NewLine +
                        "patch=1,EE,D094D16C,extended,0044                                         " + Environment.NewLine +
                        "patch=1,EE,21DA8494,extended,FFFFFA00                                     " + Environment.NewLine +
                        "patch=1,EE,D094D16C,extended,0044                                      " + Environment.NewLine +
                        "patch=1,EE,21DA8498,extended,00000F00                                     " + Environment.NewLine +
                        "patch=1,EE,D094D16C,extended,0059                                         " + Environment.NewLine +
                        "patch=1,EE,21DA8494,extended,FFFF9200                                     " + Environment.NewLine +
                        "patch=1,EE,D094D16C,extended,0059                                      " + Environment.NewLine +
                        "patch=1,EE,21DA8498,extended,00002FFF                                     " + Environment.NewLine +
                        "patch=1,EE,D094D16C,extended,005A                                      " + Environment.NewLine +
                        "patch=1,EE,21DA8494,extended,000009FF                                    " + Environment.NewLine +
                        "patch=1,EE,D094D16C,extended,005A                                      " + Environment.NewLine +
                        "patch=1,EE,21DA8498,extended,FFFFF500                                    " + Environment.NewLine +
                        "patch=1,EE,D094D16C,extended,0062                                      " + Environment.NewLine +
                        "patch=1,EE,21DA8494,extended,FFFFF500                                     " + Environment.NewLine +
                        "patch=1,EE,D094D16C,extended,0062                                      " + Environment.NewLine +
                        "patch=1,EE,21DA8498,extended,00000C00                                     " + Environment.NewLine +
                        "patch=1,EE,D094D16C,extended,0010                                      " + Environment.NewLine +
                        "patch=1,EE,105860F0,extended,0BF8                                         " + Environment.NewLine +
                        "patch=1,EE,D094D16C,extended,0010                                      " + Environment.NewLine +
                        "patch=1,EE,10577690,extended,0D85                                         " + Environment.NewLine +
                        "patch=1,EE,D094D16C,extended,0010                                         " + Environment.NewLine +
                        "patch=1,EE,10586164,extended,0EDC                                         " + Environment.NewLine +
                        "patch=1,EE,D094D16C,extended,0010                                      " + Environment.NewLine +
                        "patch=1,EE,10586180,extended,0CFC                                         " + Environment.NewLine +
            "";

            ExportPnach.ExportFile(baseCode);
        }

    }
}
