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
    public class CreatePnach9
    {
        static string baseCode = "";


        public static void ThrowAndGunMasters()
        {
            baseCode = "" +
                       "//Enemy 1" + Environment.NewLine +
                       "patch=1,EE,105B8EBA,extended,03E8//GRP                   " + Environment.NewLine +
                       "patch=1,EE,105B8EC2,extended,04B0 //TGH                   " + Environment.NewLine +
                       "patch=1,EE,205B8EB0,extended,0001 //Spa Down              " + Environment.NewLine +
                       "patch=1,EE,105B9468,extended,0001 //Auta-Grab                   " + Environment.NewLine +
                       "patch=1,EE,D05B8EB6,extended,01300000 //If SPA is activated " + Environment.NewLine +
                       "patch=1,EE,30200001,extended,005B8EBA //Increase GRP by 1 " + Environment.NewLine +

                       "//Enemy 2" + Environment.NewLine +
                       "patch=1,EE,2094A648,extended,16000000 //have gun" + Environment.NewLine +
                       "patch=1,EE,105C25B6,extended,0003 //Max weapon grip " + Environment.NewLine +
                       "patch=1,EE,105C2610,extended,0032 //WPA " + Environment.NewLine +
                       "patch=1,EE,2058A922,extended,0A90 //Regular shoot" + Environment.NewLine +
                       "patch=1,EE,2058A924,extended,0A90 //Regular shoot" + Environment.NewLine +
                       "patch=1,EE,2058A926,extended,0A90 //Regular shoot" + Environment.NewLine +
                       "patch=1,EE,105C2612,extended,1388 //Regular TGH" + Environment.NewLine +
                       "patch=1,EE,D05B8E68,extended,05300600 //If P3 is dead" + Environment.NewLine +
                       "patch=1,EE,105C2612,extended,0258 //TGH (back to normal)  " + Environment.NewLine +
                       "patch=1,EE,2058A922,extended,04F0 //Punch gun" + Environment.NewLine +
                       "patch=1,EE,2058A924,extended,04F0 //Punch gun" + Environment.NewLine +
                       "patch=1,EE,2058A926,extended,04F0 //Punch gun" + Environment.NewLine +
                       "patch=1,EE,105C2610,extended,0320 //WPA " + Environment.NewLine +

                       "patch=1,EE,1027E484,extended,00000000 //infinite ammo" + Environment.NewLine +
                       "patch=1,EE,1027E488,extended,00000000 //infinite ammo" + Environment.NewLine +
                       "patch=1,EE,205A5F94,extended,00040004 //cpu 1 uses gun" + Environment.NewLine +
                       "patch=1,EE,205AF6E4,extended,00040004 //cpu 2 uses gun" + Environment.NewLine +
                       "patch=1,EE,205B8E34,extended,00040004 //cpu 3 uses gun" + Environment.NewLine +
                       "patch=1,EE,205C2584,extended,00040004 //cpu 4 uses gun" + Environment.NewLine +
            "";

            ExportPnach.ExportFile(baseCode);
        }
    }
}
