using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UR_pnach_editor.Services;
using System.IO;
using System.Text.RegularExpressions;
using System.Security.Cryptography;
using System.Text;
using System.Windows;
using NAudio.Wave;
using System.DirectoryServices;

namespace UR_pnach_editor.Codes
{
    public class ExportPnach
    {

        public static void ExportFile(string baseCode)
        {
            SettingsClass.codeFilePath = SettingsClass.codeFolderPath + @"\" + SettingsClass.PnachName + ".pnach";

            if (File.Exists(SettingsClass.codeFilePath))
            {
                File.Delete(SettingsClass.codeFilePath);
            }

            File.WriteAllText(SettingsClass.codeFilePath, "\n" + baseCode/* + sortedMovesetString*/, new UTF8Encoding(false));
        }


    }

}
