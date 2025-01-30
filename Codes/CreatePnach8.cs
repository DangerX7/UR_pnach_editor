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

    }
}
