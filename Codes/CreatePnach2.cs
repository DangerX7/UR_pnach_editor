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
    public class CreatePnach2
    {
        static string baseCode = "";

        public static void OneStarOnly()
        {
            baseCode = "Lock Characters" + Environment.NewLine +
                "patch=1,EE,1094668E,extended,00000000 //Brad Hawk" + Environment.NewLine +
                "patch=1,EE,10946694,extended,00000000 //Glen" + Environment.NewLine +
                "patch=1,EE,10946696,extended,00000000 //Torque" + Environment.NewLine +
                "patch=1,EE,10946698,extended,00000001 //Rod" + Environment.NewLine +
                "patch=1,EE,1094669A,extended,00000000 //Seth" + Environment.NewLine +
                "patch=1,EE,1094669C,extended,00000001 //Nas-Tiii" + Environment.NewLine +
                "patch=1,EE,1094669E,extended,00000001 //Em Cee" + Environment.NewLine +
                "patch=1,EE,109466A0,extended,00000000 //Real Deal" + Environment.NewLine +
                "patch=1,EE,109466A2,extended,00000001 //Ty" + Environment.NewLine +
                "patch=1,EE,109466A4,extended,00000000 //Miguel" + Environment.NewLine +
                "patch=1,EE,109466A6,extended,00000001 //Ramon" + Environment.NewLine +
                "patch=1,EE,109466A8,extended,00000000 //Jose" + Environment.NewLine +
                "patch=1,EE,109466AA,extended,00000000 //Emilio" + Environment.NewLine +
                "patch=1,EE,109466AC,extended,00000000 //Kadonashi" + Environment.NewLine +
                "patch=1,EE,109466AE,extended,00000000 //Reggie" + Environment.NewLine +
                "patch=1,EE,109466B0,extended,00000000 //Zach" + Environment.NewLine +
                "patch=1,EE,109466B2,extended,00000000 //Colin" + Environment.NewLine +
                "patch=1,EE,109466B4,extended,00000000 //Jake" + Environment.NewLine +
                "patch=1,EE,109466B6,extended,00000000 //Tong Yoon" + Environment.NewLine +
                "patch=1,EE,109466B8,extended,00000000 //Grimm" + Environment.NewLine +
                "patch=1,EE,109466BA,extended,00000000 //BK" + Environment.NewLine +
                "patch=1,EE,109466BC,extended,00000000 //Grave Digga'" + Environment.NewLine +
                "patch=1,EE,109466BE,extended,00000000 //Bones" + Environment.NewLine +
                "patch=1,EE,109466C0,extended,00000000 //Booma" + Environment.NewLine +
                "patch=1,EE,109466C2,extended,00000000 //Busta" + Environment.NewLine +
                "patch=1,EE,109466C4,extended,00000000 //Spider" + Environment.NewLine +
                "patch=1,EE,109466C6,extended,00000000 //Pain Killah" + Environment.NewLine +
                "patch=1,EE,109466C8,extended,00000000 //Dwayne" + Environment.NewLine +
                "patch=1,EE,109466CA,extended,00000000 //Dwayne with mask" + Environment.NewLine +
                "patch=1,EE,109466CC,extended,00000000 //Shun Ying Lee" + Environment.NewLine +
                "patch=1,EE,109466CE,extended,00000000 //GD-05" + Environment.NewLine +
                "patch=1,EE,109466D0,extended,00000000 //DR-88" + Environment.NewLine +
                "patch=1,EE,109466D2,extended,00000000 //FK-71" + Environment.NewLine +
                "patch=1,EE,109466D4,extended,00000000 //PT-22" + Environment.NewLine +
                "patch=1,EE,109466D6,extended,00000000 //Bain" + Environment.NewLine +
                "patch=1,EE,109466D8,extended,00000000 //Cooper" + Environment.NewLine +
                "patch=1,EE,109466DA,extended,00000000 //Anderson" + Environment.NewLine +
                "patch=1,EE,109466DC,extended,00000000 //Taylor" + Environment.NewLine +
                "patch=1,EE,109466DE,extended,00000000 //Chris" + Environment.NewLine +
                "patch=1,EE,109466E0,extended,00000000 //Park" + Environment.NewLine +
                "patch=1,EE,109466E2,extended,00000000 //Alex" + Environment.NewLine +
                "patch=1,EE,109466E4,extended,00000000 //McKinzie" + Environment.NewLine +
                "patch=1,EE,109466E6,extended,00000000 //Napalm 99" + Environment.NewLine +
                "patch=1,EE,109466E8,extended,00000000 //Golem" + Environment.NewLine +
                "patch=1,EE,109466EA,extended,00000000 //Riki" + Environment.NewLine +
                "patch=1,EE,109466EC,extended,00000000 //Masa" + Environment.NewLine +
                "patch=1,EE,109466EE,extended,00000000 //Hiro" + Environment.NewLine +
                "patch=1,EE,109466F0,extended,00000000 //Ryuji" + Environment.NewLine +
                "patch=1,EE,109466F2,extended,00000000 //Ye Wei" + Environment.NewLine +
                "patch=1,EE,109466F4,extended,00000000 //Sha Ying" + Environment.NewLine +
                "patch=1,EE,109466F6,extended,00000000 //Yan Jun" + Environment.NewLine +
                "patch=1,EE,109466F8,extended,00000000 //Shinkai" + Environment.NewLine +
                "patch=1,EE,109466FA,extended,00000000 //Lin Fong Lee" + Environment.NewLine +
                "patch=1,EE,109466FC,extended,00000001 //Bordin" + Environment.NewLine +
                "patch=1,EE,109466FE,extended,00000000 //Lilian" + Environment.NewLine +
                "patch=1,EE,10946700,extended,00000000 //Kelly" + Environment.NewLine +
                "patch=1,EE,10946702,extended,00000000 //Vera Ross" + Environment.NewLine +
                "patch=1,EE,10946704,extended,00000000 //Paul Phoenix" + Environment.NewLine +
                "patch=1,EE,10946706,extended,00000000 //Marshall Law" + Environment.NewLine +
                "patch=1,EE,10946718,extended,00000000 //KG" + Environment.NewLine +
                "patch=1,EE,1094671A,extended,00000000 //Bain with mask" + Environment.NewLine +
                "patch=1,EE,1094671C,extended,00000000 //Cooper with mask" + Environment.NewLine +
                "";

            ExportPnach.ExportFile(baseCode);
        }

        public static void TwoStarsOnly()
        {
            baseCode = "Lock Characters" + Environment.NewLine +
                "patch=1,EE,1094668E,extended,00000000 //Brad Hawk" + Environment.NewLine +
                "patch=1,EE,10946694,extended,00000000 //Glen" + Environment.NewLine +
                "patch=1,EE,10946696,extended,00000001 //Torque" + Environment.NewLine +
                "patch=1,EE,10946698,extended,00000000 //Rod" + Environment.NewLine +
                "patch=1,EE,1094669A,extended,00000000 //Seth" + Environment.NewLine +
                "patch=1,EE,1094669C,extended,00000000 //Nas-Tiii" + Environment.NewLine +
                "patch=1,EE,1094669E,extended,00000000 //Em Cee" + Environment.NewLine +
                "patch=1,EE,109466A0,extended,00000001 //Real Deal" + Environment.NewLine +
                "patch=1,EE,109466A2,extended,00000000 //Ty" + Environment.NewLine +
                "patch=1,EE,109466A4,extended,00000001 //Miguel" + Environment.NewLine +
                "patch=1,EE,109466A6,extended,00000000 //Ramon" + Environment.NewLine +
                "patch=1,EE,109466A8,extended,00000001 //Jose" + Environment.NewLine +
                "patch=1,EE,109466AA,extended,00000001 //Emilio" + Environment.NewLine +
                "patch=1,EE,109466AC,extended,00000000 //Kadonashi" + Environment.NewLine +
                "patch=1,EE,109466AE,extended,00000000 //Reggie" + Environment.NewLine +
                "patch=1,EE,109466B0,extended,00000001 //Zach" + Environment.NewLine +
                "patch=1,EE,109466B2,extended,00000001 //Colin" + Environment.NewLine +
                "patch=1,EE,109466B4,extended,00000000 //Jake" + Environment.NewLine +
                "patch=1,EE,109466B6,extended,00000000 //Tong Yoon" + Environment.NewLine +
                "patch=1,EE,109466B8,extended,00000000 //Grimm" + Environment.NewLine +
                "patch=1,EE,109466BA,extended,00000001 //BK" + Environment.NewLine +
                "patch=1,EE,109466BC,extended,00000001 //Grave Digga'" + Environment.NewLine +
                "patch=1,EE,109466BE,extended,00000001 //Bones" + Environment.NewLine +
                "patch=1,EE,109466C0,extended,00000000 //Booma" + Environment.NewLine +
                "patch=1,EE,109466C2,extended,00000001 //Busta" + Environment.NewLine +
                "patch=1,EE,109466C4,extended,00000001 //Spider" + Environment.NewLine +
                "patch=1,EE,109466C6,extended,00000001 //Pain Killah" + Environment.NewLine +
                "patch=1,EE,109466C8,extended,00000000 //Dwayne" + Environment.NewLine +
                "patch=1,EE,109466CA,extended,00000000 //Dwayne with mask" + Environment.NewLine +
                "patch=1,EE,109466CC,extended,00000000 //Shun Ying Lee" + Environment.NewLine +
                "patch=1,EE,109466CE,extended,00000000 //GD-05" + Environment.NewLine +
                "patch=1,EE,109466D0,extended,00000000 //DR-88" + Environment.NewLine +
                "patch=1,EE,109466D2,extended,00000001 //FK-71" + Environment.NewLine +
                "patch=1,EE,109466D4,extended,00000000 //PT-22" + Environment.NewLine +
                "patch=1,EE,109466D6,extended,00000000 //Bain" + Environment.NewLine +
                "patch=1,EE,109466D8,extended,00000000 //Cooper" + Environment.NewLine +
                "patch=1,EE,109466DA,extended,00000000 //Anderson" + Environment.NewLine +
                "patch=1,EE,109466DC,extended,00000001 //Taylor" + Environment.NewLine +
                "patch=1,EE,109466DE,extended,00000000 //Chris" + Environment.NewLine +
                "patch=1,EE,109466E0,extended,00000000 //Park" + Environment.NewLine +
                "patch=1,EE,109466E2,extended,00000000 //Alex" + Environment.NewLine +
                "patch=1,EE,109466E4,extended,00000000 //McKinzie" + Environment.NewLine +
                "patch=1,EE,109466E6,extended,00000000 //Napalm 99" + Environment.NewLine +
                "patch=1,EE,109466E8,extended,00000000 //Golem" + Environment.NewLine +
                "patch=1,EE,109466EA,extended,00000000 //Riki" + Environment.NewLine +
                "patch=1,EE,109466EC,extended,00000000 //Masa" + Environment.NewLine +
                "patch=1,EE,109466EE,extended,00000000 //Hiro" + Environment.NewLine +
                "patch=1,EE,109466F0,extended,00000000 //Ryuji" + Environment.NewLine +
                "patch=1,EE,109466F2,extended,00000000 //Ye Wei" + Environment.NewLine +
                "patch=1,EE,109466F4,extended,00000000 //Sha Ying" + Environment.NewLine +
                "patch=1,EE,109466F6,extended,00000000 //Yan Jun" + Environment.NewLine +
                "patch=1,EE,109466F8,extended,00000000 //Shinkai" + Environment.NewLine +
                "patch=1,EE,109466FA,extended,00000000 //Lin Fong Lee" + Environment.NewLine +
                "patch=1,EE,109466FC,extended,00000000 //Bordin" + Environment.NewLine +
                "patch=1,EE,109466FE,extended,00000000 //Lilian" + Environment.NewLine +
                "patch=1,EE,10946700,extended,00000001 //Kelly" + Environment.NewLine +
                "patch=1,EE,10946702,extended,00000001 //Vera Ross" + Environment.NewLine +
                "patch=1,EE,10946704,extended,00000000 //Paul Phoenix" + Environment.NewLine +
                "patch=1,EE,10946706,extended,00000000 //Marshall Law" + Environment.NewLine +
                "patch=1,EE,10946718,extended,00000001 //KG" + Environment.NewLine +
                "patch=1,EE,1094671A,extended,00000000 //Bain with mask" + Environment.NewLine +
                "patch=1,EE,1094671C,extended,00000000 //Cooper with mask" + Environment.NewLine +
                "";

            ExportPnach.ExportFile(baseCode);
        }

        public static void ThreeStarsOnly()
        {
            baseCode = "Lock Characters" + Environment.NewLine +
                "patch=1,EE,1094668E,extended,00000000 //Brad Hawk" + Environment.NewLine +
                "patch=1,EE,10946694,extended,00000000 //Glen" + Environment.NewLine +
                "patch=1,EE,10946696,extended,00000000 //Torque" + Environment.NewLine +
                "patch=1,EE,10946698,extended,00000000 //Rod" + Environment.NewLine +
                "patch=1,EE,1094669A,extended,00000001 //Seth" + Environment.NewLine +
                "patch=1,EE,1094669C,extended,00000000 //Nas-Tiii" + Environment.NewLine +
                "patch=1,EE,1094669E,extended,00000000 //Em Cee" + Environment.NewLine +
                "patch=1,EE,109466A0,extended,00000000 //Real Deal" + Environment.NewLine +
                "patch=1,EE,109466A2,extended,00000000 //Ty" + Environment.NewLine +
                "patch=1,EE,109466A4,extended,00000000 //Miguel" + Environment.NewLine +
                "patch=1,EE,109466A6,extended,00000000 //Ramon" + Environment.NewLine +
                "patch=1,EE,109466A8,extended,00000000 //Jose" + Environment.NewLine +
                "patch=1,EE,109466AA,extended,00000000 //Emilio" + Environment.NewLine +
                "patch=1,EE,109466AC,extended,00000000 //Kadonashi" + Environment.NewLine +
                "patch=1,EE,109466AE,extended,00000001 //Reggie" + Environment.NewLine +
                "patch=1,EE,109466B0,extended,00000000 //Zach" + Environment.NewLine +
                "patch=1,EE,109466B2,extended,00000000 //Colin" + Environment.NewLine +
                "patch=1,EE,109466B4,extended,00000000 //Jake" + Environment.NewLine +
                "patch=1,EE,109466B6,extended,00000000 //Tong Yoon" + Environment.NewLine +
                "patch=1,EE,109466B8,extended,00000000 //Grimm" + Environment.NewLine +
                "patch=1,EE,109466BA,extended,00000000 //BK" + Environment.NewLine +
                "patch=1,EE,109466BC,extended,00000000 //Grave Digga'" + Environment.NewLine +
                "patch=1,EE,109466BE,extended,00000000 //Bones" + Environment.NewLine +
                "patch=1,EE,109466C0,extended,00000001 //Booma" + Environment.NewLine +
                "patch=1,EE,109466C2,extended,00000000 //Busta" + Environment.NewLine +
                "patch=1,EE,109466C4,extended,00000000 //Spider" + Environment.NewLine +
                "patch=1,EE,109466C6,extended,00000000 //Pain Killah" + Environment.NewLine +
                "patch=1,EE,109466C8,extended,00000000 //Dwayne" + Environment.NewLine +
                "patch=1,EE,109466CA,extended,00000000 //Dwayne with mask" + Environment.NewLine +
                "patch=1,EE,109466CC,extended,00000000 //Shun Ying Lee" + Environment.NewLine +
                "patch=1,EE,109466CE,extended,00000001 //GD-05" + Environment.NewLine +
                "patch=1,EE,109466D0,extended,00000001 //DR-88" + Environment.NewLine +
                "patch=1,EE,109466D2,extended,00000000 //FK-71" + Environment.NewLine +
                "patch=1,EE,109466D4,extended,00000001 //PT-22" + Environment.NewLine +
                "patch=1,EE,109466D6,extended,00000001 //Bain" + Environment.NewLine +
                "patch=1,EE,109466D8,extended,00000001 //Cooper" + Environment.NewLine +
                "patch=1,EE,109466DA,extended,00000001 //Anderson" + Environment.NewLine +
                "patch=1,EE,109466DC,extended,00000000 //Taylor" + Environment.NewLine +
                "patch=1,EE,109466DE,extended,00000000 //Chris" + Environment.NewLine +
                "patch=1,EE,109466E0,extended,00000000 //Park" + Environment.NewLine +
                "patch=1,EE,109466E2,extended,00000000 //Alex" + Environment.NewLine +
                "patch=1,EE,109466E4,extended,00000000 //McKinzie" + Environment.NewLine +
                "patch=1,EE,109466E6,extended,00000000 //Napalm 99" + Environment.NewLine +
                "patch=1,EE,109466E8,extended,00000000 //Golem" + Environment.NewLine +
                "patch=1,EE,109466EA,extended,00000001 //Riki" + Environment.NewLine +
                "patch=1,EE,109466EC,extended,00000001 //Masa" + Environment.NewLine +
                "patch=1,EE,109466EE,extended,00000001 //Hiro" + Environment.NewLine +
                "patch=1,EE,109466F0,extended,00000001 //Ryuji" + Environment.NewLine +
                "patch=1,EE,109466F2,extended,00000001 //Ye Wei" + Environment.NewLine +
                "patch=1,EE,109466F4,extended,00000001 //Sha Ying" + Environment.NewLine +
                "patch=1,EE,109466F6,extended,00000000 //Yan Jun" + Environment.NewLine +
                "patch=1,EE,109466F8,extended,00000000 //Shinkai" + Environment.NewLine +
                "patch=1,EE,109466FA,extended,00000000 //Lin Fong Lee" + Environment.NewLine +
                "patch=1,EE,109466FC,extended,00000000 //Bordin" + Environment.NewLine +
                "patch=1,EE,109466FE,extended,00000001 //Lilian" + Environment.NewLine +
                "patch=1,EE,10946700,extended,00000000 //Kelly" + Environment.NewLine +
                "patch=1,EE,10946702,extended,00000000 //Vera Ross" + Environment.NewLine +
                "patch=1,EE,10946704,extended,00000000 //Paul Phoenix" + Environment.NewLine +
                "patch=1,EE,10946706,extended,00000000 //Marshall Law" + Environment.NewLine +
                "patch=1,EE,10946718,extended,00000000 //KG" + Environment.NewLine +
                "patch=1,EE,1094671A,extended,00000001 //Bain with mask" + Environment.NewLine +
                "patch=1,EE,1094671C,extended,00000001 //Cooper with mask" + Environment.NewLine +
                "";

            ExportPnach.ExportFile(baseCode);
        }

        public static void FourStarsOnly()
        {
            baseCode = "Lock Characters" + Environment.NewLine +
                "patch=1,EE,1094668E,extended,00000000 //Brad Hawk" + Environment.NewLine +
                "patch=1,EE,10946694,extended,00000001 //Glen" + Environment.NewLine +
                "patch=1,EE,10946696,extended,00000000 //Torque" + Environment.NewLine +
                "patch=1,EE,10946698,extended,00000000 //Rod" + Environment.NewLine +
                "patch=1,EE,1094669A,extended,00000000 //Seth" + Environment.NewLine +
                "patch=1,EE,1094669C,extended,00000000 //Nas-Tiii" + Environment.NewLine +
                "patch=1,EE,1094669E,extended,00000000 //Em Cee" + Environment.NewLine +
                "patch=1,EE,109466A0,extended,00000000 //Real Deal" + Environment.NewLine +
                "patch=1,EE,109466A2,extended,00000000 //Ty" + Environment.NewLine +
                "patch=1,EE,109466A4,extended,00000000 //Miguel" + Environment.NewLine +
                "patch=1,EE,109466A6,extended,00000000 //Ramon" + Environment.NewLine +
                "patch=1,EE,109466A8,extended,00000000 //Jose" + Environment.NewLine +
                "patch=1,EE,109466AA,extended,00000000 //Emilio" + Environment.NewLine +
                "patch=1,EE,109466AC,extended,00000001 //Kadonashi" + Environment.NewLine +
                "patch=1,EE,109466AE,extended,00000000 //Reggie" + Environment.NewLine +
                "patch=1,EE,109466B0,extended,00000000 //Zach" + Environment.NewLine +
                "patch=1,EE,109466B2,extended,00000000 //Colin" + Environment.NewLine +
                "patch=1,EE,109466B4,extended,00000001 //Jake" + Environment.NewLine +
                "patch=1,EE,109466B6,extended,00000001 //Tong Yoon" + Environment.NewLine +
                "patch=1,EE,109466B8,extended,00000001 //Grimm" + Environment.NewLine +
                "patch=1,EE,109466BA,extended,00000000 //BK" + Environment.NewLine +
                "patch=1,EE,109466BC,extended,00000000 //Grave Digga'" + Environment.NewLine +
                "patch=1,EE,109466BE,extended,00000000 //Bones" + Environment.NewLine +
                "patch=1,EE,109466C0,extended,00000000 //Booma" + Environment.NewLine +
                "patch=1,EE,109466C2,extended,00000000 //Busta" + Environment.NewLine +
                "patch=1,EE,109466C4,extended,00000000 //Spider" + Environment.NewLine +
                "patch=1,EE,109466C6,extended,00000000 //Pain Killah" + Environment.NewLine +
                "patch=1,EE,109466C8,extended,00000001 //Dwayne" + Environment.NewLine +
                "patch=1,EE,109466CA,extended,00000001 //Dwayne with mask" + Environment.NewLine +
                "patch=1,EE,109466CC,extended,00000001 //Shun Ying Lee" + Environment.NewLine +
                "patch=1,EE,109466CE,extended,00000000 //GD-05" + Environment.NewLine +
                "patch=1,EE,109466D0,extended,00000000 //DR-88" + Environment.NewLine +
                "patch=1,EE,109466D2,extended,00000000 //FK-71" + Environment.NewLine +
                "patch=1,EE,109466D4,extended,00000000 //PT-22" + Environment.NewLine +
                "patch=1,EE,109466D6,extended,00000000 //Bain" + Environment.NewLine +
                "patch=1,EE,109466D8,extended,00000000 //Cooper" + Environment.NewLine +
                "patch=1,EE,109466DA,extended,00000000 //Anderson" + Environment.NewLine +
                "patch=1,EE,109466DC,extended,00000000 //Taylor" + Environment.NewLine +
                "patch=1,EE,109466DE,extended,00000001 //Chris" + Environment.NewLine +
                "patch=1,EE,109466E0,extended,00000001 //Park" + Environment.NewLine +
                "patch=1,EE,109466E2,extended,00000001 //Alex" + Environment.NewLine +
                "patch=1,EE,109466E4,extended,00000000 //McKinzie" + Environment.NewLine +
                "patch=1,EE,109466E6,extended,00000000 //Napalm 99" + Environment.NewLine +
                "patch=1,EE,109466E8,extended,00000000 //Golem" + Environment.NewLine +
                "patch=1,EE,109466EA,extended,00000000 //Riki" + Environment.NewLine +
                "patch=1,EE,109466EC,extended,00000000 //Masa" + Environment.NewLine +
                "patch=1,EE,109466EE,extended,00000000 //Hiro" + Environment.NewLine +
                "patch=1,EE,109466F0,extended,00000000 //Ryuji" + Environment.NewLine +
                "patch=1,EE,109466F2,extended,00000000 //Ye Wei" + Environment.NewLine +
                "patch=1,EE,109466F4,extended,00000000 //Sha Ying" + Environment.NewLine +
                "patch=1,EE,109466F6,extended,00000001 //Yan Jun" + Environment.NewLine +
                "patch=1,EE,109466F8,extended,00000000 //Shinkai" + Environment.NewLine +
                "patch=1,EE,109466FA,extended,00000000 //Lin Fong Lee" + Environment.NewLine +
                "patch=1,EE,109466FC,extended,00000000 //Bordin" + Environment.NewLine +
                "patch=1,EE,109466FE,extended,00000000 //Lilian" + Environment.NewLine +
                "patch=1,EE,10946700,extended,00000000 //Kelly" + Environment.NewLine +
                "patch=1,EE,10946702,extended,00000000 //Vera Ross" + Environment.NewLine +
                "patch=1,EE,10946704,extended,00000000 //Paul Phoenix" + Environment.NewLine +
                "patch=1,EE,10946706,extended,00000000 //Marshall Law" + Environment.NewLine +
                "patch=1,EE,10946718,extended,00000000 //KG" + Environment.NewLine +
                "patch=1,EE,1094671A,extended,00000000 //Bain with mask" + Environment.NewLine +
                "patch=1,EE,1094671C,extended,00000000 //Cooper with mask" + Environment.NewLine +
                "";

            ExportPnach.ExportFile(baseCode);
        }

        public static void FiveStarsOnly()
        {
            baseCode = "Lock Characters" + Environment.NewLine +
                "patch=1,EE,1094668E,extended,00000001 //Brad Hawk" + Environment.NewLine +
                "patch=1,EE,10946694,extended,00000000 //Glen" + Environment.NewLine +
                "patch=1,EE,10946696,extended,00000000 //Torque" + Environment.NewLine +
                "patch=1,EE,10946698,extended,00000000 //Rod" + Environment.NewLine +
                "patch=1,EE,1094669A,extended,00000000 //Seth" + Environment.NewLine +
                "patch=1,EE,1094669C,extended,00000000 //Nas-Tiii" + Environment.NewLine +
                "patch=1,EE,1094669E,extended,00000000 //Em Cee" + Environment.NewLine +
                "patch=1,EE,109466A0,extended,00000000 //Real Deal" + Environment.NewLine +
                "patch=1,EE,109466A2,extended,00000000 //Ty" + Environment.NewLine +
                "patch=1,EE,109466A4,extended,00000000 //Miguel" + Environment.NewLine +
                "patch=1,EE,109466A6,extended,00000000 //Ramon" + Environment.NewLine +
                "patch=1,EE,109466A8,extended,00000000 //Jose" + Environment.NewLine +
                "patch=1,EE,109466AA,extended,00000000 //Emilio" + Environment.NewLine +
                "patch=1,EE,109466AC,extended,00000000 //Kadonashi" + Environment.NewLine +
                "patch=1,EE,109466AE,extended,00000000 //Reggie" + Environment.NewLine +
                "patch=1,EE,109466B0,extended,00000000 //Zach" + Environment.NewLine +
                "patch=1,EE,109466B2,extended,00000000 //Colin" + Environment.NewLine +
                "patch=1,EE,109466B4,extended,00000000 //Jake" + Environment.NewLine +
                "patch=1,EE,109466B6,extended,00000000 //Tong Yoon" + Environment.NewLine +
                "patch=1,EE,109466B8,extended,00000000 //Grimm" + Environment.NewLine +
                "patch=1,EE,109466BA,extended,00000000 //BK" + Environment.NewLine +
                "patch=1,EE,109466BC,extended,00000000 //Grave Digga'" + Environment.NewLine +
                "patch=1,EE,109466BE,extended,00000000 //Bones" + Environment.NewLine +
                "patch=1,EE,109466C0,extended,00000000 //Booma" + Environment.NewLine +
                "patch=1,EE,109466C2,extended,00000000 //Busta" + Environment.NewLine +
                "patch=1,EE,109466C4,extended,00000000 //Spider" + Environment.NewLine +
                "patch=1,EE,109466C6,extended,00000000 //Pain Killah" + Environment.NewLine +
                "patch=1,EE,109466C8,extended,00000000 //Dwayne" + Environment.NewLine +
                "patch=1,EE,109466CA,extended,00000000 //Dwayne with mask" + Environment.NewLine +
                "patch=1,EE,109466CC,extended,00000000 //Shun Ying Lee" + Environment.NewLine +
                "patch=1,EE,109466CE,extended,00000000 //GD-05" + Environment.NewLine +
                "patch=1,EE,109466D0,extended,00000000 //DR-88" + Environment.NewLine +
                "patch=1,EE,109466D2,extended,00000000 //FK-71" + Environment.NewLine +
                "patch=1,EE,109466D4,extended,00000000 //PT-22" + Environment.NewLine +
                "patch=1,EE,109466D6,extended,00000000 //Bain" + Environment.NewLine +
                "patch=1,EE,109466D8,extended,00000000 //Cooper" + Environment.NewLine +
                "patch=1,EE,109466DA,extended,00000000 //Anderson" + Environment.NewLine +
                "patch=1,EE,109466DC,extended,00000000 //Taylor" + Environment.NewLine +
                "patch=1,EE,109466DE,extended,00000000 //Chris" + Environment.NewLine +
                "patch=1,EE,109466E0,extended,00000000 //Park" + Environment.NewLine +
                "patch=1,EE,109466E2,extended,00000000 //Alex" + Environment.NewLine +
                "patch=1,EE,109466E4,extended,00000001 //McKinzie" + Environment.NewLine +
                "patch=1,EE,109466E6,extended,00000001 //Napalm 99" + Environment.NewLine +
                "patch=1,EE,109466E8,extended,00000001 //Golem" + Environment.NewLine +
                "patch=1,EE,109466EA,extended,00000000 //Riki" + Environment.NewLine +
                "patch=1,EE,109466EC,extended,00000000 //Masa" + Environment.NewLine +
                "patch=1,EE,109466EE,extended,00000000 //Hiro" + Environment.NewLine +
                "patch=1,EE,109466F0,extended,00000000 //Ryuji" + Environment.NewLine +
                "patch=1,EE,109466F2,extended,00000000 //Ye Wei" + Environment.NewLine +
                "patch=1,EE,109466F4,extended,00000000 //Sha Ying" + Environment.NewLine +
                "patch=1,EE,109466F6,extended,00000000 //Yan Jun" + Environment.NewLine +
                "patch=1,EE,109466F8,extended,00000001 //Shinkai" + Environment.NewLine +
                "patch=1,EE,109466FA,extended,00000001 //Lin Fong Lee" + Environment.NewLine +
                "patch=1,EE,109466FC,extended,00000000 //Bordin" + Environment.NewLine +
                "patch=1,EE,109466FE,extended,00000000 //Lilian" + Environment.NewLine +
                "patch=1,EE,10946700,extended,00000000 //Kelly" + Environment.NewLine +
                "patch=1,EE,10946702,extended,00000000 //Vera Ross" + Environment.NewLine +
                "patch=1,EE,10946704,extended,00000001 //Paul Phoenix" + Environment.NewLine +
                "patch=1,EE,10946706,extended,00000001 //Marshall Law" + Environment.NewLine +
                "patch=1,EE,10946718,extended,00000000 //KG" + Environment.NewLine +
                "patch=1,EE,1094671A,extended,00000000 //Bain with mask" + Environment.NewLine +
                "patch=1,EE,1094671C,extended,00000000 //Cooper with mask" + Environment.NewLine +
                "";

            ExportPnach.ExportFile(baseCode);
        }

        public static void BossBrad()
        {
            baseCode = "//P3" + Environment.NewLine +
                "patch=1,EE,105B8EB8,extended,0578 //STK" + Environment.NewLine +
                "patch=1,EE,105B8EBA,extended,04B0 //GRP" + Environment.NewLine +
                "patch=1,EE,105B8EBC,extended,044C //RGA" + Environment.NewLine +
                "patch=1,EE,105B8EBE,extended,0514 //SPA" + Environment.NewLine +
                "patch=1,EE,105B8EC0,extended,03E8 //WPA" + Environment.NewLine +
                "patch=1,EE,105B8EC2,extended,0514 //TGH" + Environment.NewLine +
                "patch=1,EE,105B8E72,extended,01F4 //HDE" + Environment.NewLine +
                "patch=1,EE,105B8E78,extended,00FA //HDE Balance" + Environment.NewLine +
                "patch=1,EE,105B8E74,extended,0258 //UBE" + Environment.NewLine +
                "patch=1,EE,105B8E7A,extended,012C //UBE Balance" + Environment.NewLine +
                "patch=1,EE,105B8E76,extended,0190 //LBE" + Environment.NewLine +
                "patch=1,EE,105B8E7C,extended,00C8 //LBE Balance" + Environment.NewLine +
                "patch=1,EE,105B8F10,extended,0014 //SPA Regained" + Environment.NewLine +
                "patch=1,EE,205B8EA2,extended,3F80 //SPA Down Red Bar Color" + Environment.NewLine +
                "patch=1,EE,205B8EA6,extended,3F20 //SPA Down Green Bar Color" + Environment.NewLine +
                "patch=1,EE,205B8EAA,extended,3F80 //SPA Down Blue Bar Color" + Environment.NewLine +
                "patch=1,EE,205B8EAE,extended,3F80 //SPA Down Alpha Bar Color" + Environment.NewLine +
                "patch=1,EE,205B8EB0,extended,0007 //SPA Down" + Environment.NewLine +
                "patch=1,EE,205B0044,extended,0002 //Moves & Skin 1" + Environment.NewLine +
                "patch=1,EE,2094A63C,extended,0002 //Moves & Skin 2" + Environment.NewLine +
                "";

            ExportPnach.ExportFile(baseCode);
        }

        public static void Kg_and_Bordin()
        {
            baseCode = "//P3" + Environment.NewLine +
                "patch=1,EE,205B0044,extended,003E //Moves & Skin 1" + Environment.NewLine +
                "patch=1,EE,2094A63C,extended,003E //Moves & Skin 2" + Environment.NewLine +
                "//P4" + Environment.NewLine +
                "patch=1,EE,205B9794,extended,003D //Moves & Skin 1" + Environment.NewLine +
                "patch=1,EE,2094A640,extended,003D //Moves & Skin 2" + Environment.NewLine +
                "";

            ExportPnach.ExportFile(baseCode);
        }

        public static void MovesAndStatsModifier(string p1SelectedCharacter, string p2SelectedCharacter)
        {
            string p1Char = "";
            string p2Char = "";

            p1Char = GetCharacter(p1SelectedCharacter);
            p2Char = GetCharacter(p2SelectedCharacter);



            baseCode = "//P1" + Environment.NewLine +
                "patch=1,EE,2059D1A4,extended,00" + p1Char + " //Moves & Skin 1" + Environment.NewLine +
                "patch=1,EE,2094A634,extended,00" + p1Char + " //Moves & Skin 2" + Environment.NewLine +
                "//P2" + Environment.NewLine +
                "patch=1,EE,205A68F4,extended,00" + p2Char + " //Moves & Skin 1" + Environment.NewLine +
                "patch=1,EE,2094A638,extended,00" + p2Char + " //Moves & Skin 2" + Environment.NewLine +
                "";

            ExportPnach.ExportFile(baseCode);
        }

        public static string GetCharacter(string p1SelectedCharacter)
        {
            string chara = "";
            switch (p1SelectedCharacter)
            {
                case "Brad Hawk":
                    chara = "00";
                    return chara;
                case "Glen":
                    chara = "03";
                    return chara;
                case "Torque":
                    chara = "04";
                    return chara;
                case "Rod":
                    chara = "05";
                    return chara;
                case "Seth":
                    chara = "06";
                    return chara;
                case "Nas-Tiii":
                    chara = "07";
                    return chara;
                case "Em Cee":
                    chara = "08";
                    return chara;
                case "Real Deal":
                    chara = "09";
                    return chara;
                case "Ty":
                    chara = "0A";
                    return chara;
                case "Miguel":
                    chara = "0B";
                    return chara;
                case "Ramon":
                    chara = "0C";
                    return chara;
                case "Jose":
                    chara = "0D";
                    return chara;
                case "Emilio":
                    chara = "0E";
                    return chara;
                case "Kadonashi":
                    chara = "0F";
                    return chara;
                case "Reggie":
                    chara = "10";
                    return chara;
                case "Zack":
                    chara = "11";
                    return chara;
                case "Colin":
                    chara = "12";
                    return chara;
                case "Jake":
                    chara = "13";
                    return chara;
                case "Tong Yoon":
                    chara = "14";
                    return chara;
                case "Grimm":
                    chara = "15";
                    return chara;
                case "BK":
                    chara = "16";
                    return chara;
                case "Grave Digga'":
                    chara = "17";
                    return chara;
                case "Bones":
                    chara = "18";
                    return chara;
                case "Booma":
                    chara = "19";
                    return chara;
                case "Busta":
                    chara = "1A";
                    return chara;
                case "Spider":
                    chara = "1B";
                    return chara;
                case "Pain Killah":
                    chara = "1C";
                    return chara;
                case "Dwayne":
                    chara = "1E";
                    return chara;
                case "Shun Ying Lee":
                    chara = "1F";
                    return chara;
                case "GD-05":
                    chara = "20";
                    return chara;
                case "DR-88":
                    chara = "21";
                    return chara;
                case "FK-71":
                    chara = "22";
                    return chara;
                case "PT-22":
                    chara = "23";
                    return chara;
                case "Bain":
                    chara = "24";
                    return chara;
                case "Cooper":
                    chara = "25";
                    return chara;
                case "Anderson":
                    chara = "26";
                    return chara;
                case "Taylor":
                    chara = "27";
                    return chara;
                case "Chris":
                    chara = "28";
                    return chara;
                case "Park":
                    chara = "29";
                    return chara;
                case "Alex":
                    chara = "2A";
                    return chara;
                case "McKinzie":
                    chara = "2B";
                    return chara;
                case "Napalm 99":
                    chara = "2C";
                    return chara;
                case "Golem":
                    chara = "2D";
                    return chara;
                case "Riki":
                    chara = "2E";
                    return chara;
                case "Masa":
                    chara = "2F";
                    return chara;
                case "Hiro":
                    chara = "30";
                    return chara;
                case "Ryuji":
                    chara = "31";
                    return chara;
                case "Ye Wei":
                    chara = "32";
                    return chara;
                case "Sha Ying":
                    chara = "33";
                    return chara;
                case "Yan Jun":
                    chara = "34";
                    return chara;
                case "Shinkai":
                    chara = "35";
                    return chara;
                case "Lin Fong Lee":
                    chara = "36";
                    return chara;
                case "Bordin":
                    chara = "37";
                    return chara;
                case "Lilian":
                    chara = "38";
                    return chara;
                case "Kelly":
                    chara = "39";
                    return chara;
                case "Vera":
                    chara = "3A";
                    return chara;
                case "Paul":
                    chara = "3B";
                    return chara;
                case "Law":
                    chara = "3C";
                    return chara;
                case "Bordin (Story)":
                    chara = "3D";
                    return chara;
                case "KG (Beat-up)":
                    chara = "3E";
                    return chara;
                case "KG":
                    chara = "45";
                    return chara;
                case "Bain (Mask)":
                    chara = "46";
                    return chara;
                case "Cooper (Mask)":
                    chara = "47";
                    return chara;
            }

            return chara;
        }


        public static void GunBackupMission()
        {
            baseCode = "//P1" + Environment.NewLine +
                "patch=1,EE,105A6018,extended,0046 //STK" + Environment.NewLine +
                "patch=1,EE,105A601A,extended,003C //GRP" + Environment.NewLine +
                "patch=1,EE,105A601C,extended,0050 //RGA" + Environment.NewLine +
                "patch=1,EE,105A601E,extended,0064 //SPA" + Environment.NewLine +
                "patch=1,EE,105A6020,extended,0064 //WPA" + Environment.NewLine +
                "patch=1,EE,105A6022,extended,0064 //TGH" + Environment.NewLine +
                "patch=1,EE,105A5FD2,extended,0032 //HDE" + Environment.NewLine +
                "patch=1,EE,105A5FD8,extended,0019 //HDE Balance" + Environment.NewLine +
                "patch=1,EE,105A5FD4,extended,0050 //UBE" + Environment.NewLine +
                "patch=1,EE,105A5FDA,extended,0028 //UBE Balance" + Environment.NewLine +
                "patch=1,EE,105A5FD6,extended,001E //LBE" + Environment.NewLine +
                "patch=1,EE,105A5FDC,extended,000F //LBE Balance" + Environment.NewLine +
                "patch=1,EE,2094A648,extended,16 //have gun" + Environment.NewLine +
                "//P2" + Environment.NewLine +
                "patch=1,EE,105AF768,extended,00C8 //STK" + Environment.NewLine +
                "patch=1,EE,105AF76A,extended,0078 //GRP" + Environment.NewLine +
                "patch=1,EE,105AF76C,extended,00A0 //RGA" + Environment.NewLine +
                "patch=1,EE,105AF76E,extended,0118 //SPA" + Environment.NewLine +
                "patch=1,EE,105AF770,extended,000A //WPA" + Environment.NewLine +
                "patch=1,EE,105AF772,extended,01C2 //TGH" + Environment.NewLine +
                "patch=1,EE,105AF722,extended,0122 //HDE" + Environment.NewLine +
                "patch=1,EE,105AF728,extended,0091 //HDE Balance" + Environment.NewLine +
                "patch=1,EE,105AF724,extended,00D2 //UBE" + Environment.NewLine +
                "patch=1,EE,105AF72A,extended,0069 //UBE Balance" + Environment.NewLine +
                "patch=1,EE,105AF726,extended,00F0 //LBE" + Environment.NewLine +
                "patch=1,EE,105AF72C,extended,0078 //LBE Balance" + Environment.NewLine +
                "//P3" + Environment.NewLine +
                "patch=1,EE,105B8EB8,extended,03E8 //STK" + Environment.NewLine +
                "patch=1,EE,105B8EBA,extended,04B0 //GRP" + Environment.NewLine +
                "patch=1,EE,105B8EBC,extended,03D4 //RGA" + Environment.NewLine +
                "patch=1,EE,105B8EBE,extended,03C0 //SPA" + Environment.NewLine +
                "patch=1,EE,105B8EC0,extended,000A //WPA" + Environment.NewLine +
                "patch=1,EE,105B8EC2,extended,0258 //TGH" + Environment.NewLine +
                "patch=1,EE,105B8E72,extended,01F4 //HDE" + Environment.NewLine +
                "patch=1,EE,105B8E78,extended,00FA //HDE Balance" + Environment.NewLine +
                "patch=1,EE,105B8E74,extended,01F4 //UBE" + Environment.NewLine +
                "patch=1,EE,105B8E7A,extended,00FA //UBE Balance" + Environment.NewLine +
                "patch=1,EE,105B8E76,extended,01F4 //LBE" + Environment.NewLine +
                "patch=1,EE,105B8E7C,extended,00FA //LBE Balance" + Environment.NewLine +
                "patch=1,EE,105B8F10,extended,0032 //SPA Regained" + Environment.NewLine +
                "//P4" + Environment.NewLine +
                "patch=1,EE,105C2608,extended,01F4 //STK" + Environment.NewLine +
                "patch=1,EE,105C260A,extended,012C //GRP" + Environment.NewLine +
                "patch=1,EE,105C260C,extended,0190 //RGA" + Environment.NewLine +
                "patch=1,EE,105C260E,extended,0190 //SPA" + Environment.NewLine +
                "patch=1,EE,105C2610,extended,01F4 //WPA" + Environment.NewLine +
                "patch=1,EE,105C2612,extended,0384 //TGH" + Environment.NewLine +
                "patch=1,EE,105C25C2,extended,0064 //HDE" + Environment.NewLine +
                "patch=1,EE,105C25C8,extended,0032 //HDE Balance" + Environment.NewLine +
                "patch=1,EE,105C25C4,extended,0064 //UBE" + Environment.NewLine +
                "patch=1,EE,105C25CA,extended,0032 //UBE Balance" + Environment.NewLine +
                "patch=1,EE,105C25C6,extended,0064 //LBE" + Environment.NewLine +
                "patch=1,EE,105C25CC,extended,0032 //LBE Balance" + Environment.NewLine +
                "";

            ExportPnach.ExportFile(baseCode);
        }
        public static void RegionalChallenge()
        {
            baseCode = "//P1" + Environment.NewLine +
                "patch=1,EE,105A6018,extended,0064 //STK" + Environment.NewLine +
                "patch=1,EE,105A601A,extended,0078 //GRP" + Environment.NewLine +
                "patch=1,EE,105A601C,extended,0190 //RGA" + Environment.NewLine +
                "patch=1,EE,105A601E,extended,00C8 //SPA" + Environment.NewLine +
                "patch=1,EE,105A6020,extended,0078 //WPA" + Environment.NewLine +
                "patch=1,EE,105A6022,extended,0190 //TGH" + Environment.NewLine +
                "patch=1,EE,105A5FD2,extended,015E //HDE" + Environment.NewLine +
                "patch=1,EE,105A5FD8,extended,00AF //HDE Balance" + Environment.NewLine +
                "patch=1,EE,105A5FD4,extended,0190 //UBE" + Environment.NewLine +
                "patch=1,EE,105A5FDA,extended,00C8 //UBE Balance" + Environment.NewLine +
                "patch=1,EE,105A5FD6,extended,01A4 //LBE" + Environment.NewLine +
                "patch=1,EE,105A5FDC,extended,00D2 //LBE Balance" + Environment.NewLine +
                "//P2" + Environment.NewLine +
                "patch=1,EE,105AF768,extended,005A //STK" + Environment.NewLine +
                "patch=1,EE,105AF76A,extended,0064 //GRP" + Environment.NewLine +
                "patch=1,EE,105AF76C,extended,01F4 //RGA" + Environment.NewLine +
                "patch=1,EE,105AF76E,extended,0096 //SPA" + Environment.NewLine +
                "patch=1,EE,105AF770,extended,0096 //WPA" + Environment.NewLine +
                "patch=1,EE,105AF772,extended,0258 //TGH" + Environment.NewLine +
                "patch=1,EE,105AF722,extended,00F0 //HDE" + Environment.NewLine +
                "patch=1,EE,105AF728,extended,0078 //HDE Balance" + Environment.NewLine +
                "patch=1,EE,105AF724,extended,0104 //UBE" + Environment.NewLine +
                "patch=1,EE,105AF72A,extended,0082 //UBE Balance" + Environment.NewLine +
                "patch=1,EE,105AF726,extended,00FA //LBE" + Environment.NewLine +
                "patch=1,EE,105AF72C,extended,007D //LBE Balance" + Environment.NewLine +
                "//P3" + Environment.NewLine +
                "patch=1,EE,105B8EB8,extended,02BC //STK" + Environment.NewLine +
                "patch=1,EE,105B8EBA,extended,0190 //GRP" + Environment.NewLine +
                "patch=1,EE,105B8EBC,extended,0320 //RGA" + Environment.NewLine +
                "patch=1,EE,105B8EBE,extended,02BC //SPA" + Environment.NewLine +
                "patch=1,EE,105B8EC0,extended,0258 //WPA" + Environment.NewLine +
                "patch=1,EE,105B8EC2,extended,07D0 //TGH" + Environment.NewLine +
                "patch=1,EE,105B8E72,extended,012C //HDE" + Environment.NewLine +
                "patch=1,EE,105B8E78,extended,0096 //HDE Balance" + Environment.NewLine +
                "patch=1,EE,105B8E74,extended,01C2 //UBE" + Environment.NewLine +
                "patch=1,EE,105B8E7A,extended,00E1 //UBE Balance" + Environment.NewLine +
                "patch=1,EE,105B8E76,extended,01F4 //LBE" + Environment.NewLine +
                "patch=1,EE,105B8E7C,extended,00FA //LBE Balance" + Environment.NewLine +
                "//P4" + Environment.NewLine +
                "patch=1,EE,105C2608,extended,0320 //STK" + Environment.NewLine +
                "patch=1,EE,105C260A,extended,0384 //GRP" + Environment.NewLine +
                "patch=1,EE,105C260C,extended,0256 //RGA" + Environment.NewLine +
                "patch=1,EE,105C260E,extended,0320 //SPA" + Environment.NewLine +
                "patch=1,EE,105C2610,extended,0258 //WPA" + Environment.NewLine +
                "patch=1,EE,105C2612,extended,07D0 //TGH" + Environment.NewLine +
                "patch=1,EE,105C25C2,extended,01F4 //HDE" + Environment.NewLine +
                "patch=1,EE,105C25C8,extended,00FA //HDE Balance" + Environment.NewLine +
                "patch=1,EE,105C25C4,extended,01C2 //UBE" + Environment.NewLine +
                "patch=1,EE,105C25CA,extended,00E1 //UBE Balance" + Environment.NewLine +
                "patch=1,EE,105C25C6,extended,012C //LBE" + Environment.NewLine +
                "patch=1,EE,105C25CC,extended,0096 //LBE Balance" + Environment.NewLine +
                "";

            ExportPnach.ExportFile(baseCode);
        }


        public static void SpaDownModifier(string p1SelectedSpa, string p2SelectedSpa, string p3SelectedSpa, string p4SelectedSpa)
        {
            List<string> p1Spa = new List<string>();
            List<string> p2Spa = new List<string>();
            List<string> p3Spa = new List<string>();
            List<string> p4Spa = new List<string>();

            p1Spa = GetSpa(p1SelectedSpa);
            p2Spa = GetSpa(p2SelectedSpa);
            p3Spa = GetSpa(p3SelectedSpa);
            p4Spa = GetSpa(p4SelectedSpa);



            baseCode = "//P1" + Environment.NewLine +
                "patch=1,EE,205A6002,extended,3F"+ p1Spa[0] + "0 //SPA Down Red Bar Color" + Environment.NewLine +
                "patch=1,EE,205A6006,extended,3F"+ p1Spa[1] + "0 //SPA Down Green Bar Color" + Environment.NewLine +
                "patch=1,EE,205A600A,extended,3F"+ p1Spa[2] + "0 //SPA Down Blue Bar Color" + Environment.NewLine +
                "patch=1,EE,205A600E,extended,3F"+ p1Spa[3] + "0 //SPA Down Alpha Bar Color" + Environment.NewLine +
                "patch=1,EE,205A6010,extended,000" + p1Spa[4] + " //SPA Down" + Environment.NewLine +
                "//P2" + Environment.NewLine +
                "patch=1,EE,205AF752,extended,3F"+ p2Spa[0] + "0 //SPA Down Red Bar Color" + Environment.NewLine +
                "patch=1,EE,205AF756,extended,3F"+ p2Spa[1] + "0 //SPA Down Green Bar Color" + Environment.NewLine +
                "patch=1,EE,205AF75A,extended,3F"+ p2Spa[2] + "0 //SPA Down Blue Bar Color" + Environment.NewLine +
                "patch=1,EE,205AF75E,extended,3F"+ p2Spa[3] + "0 //SPA Down Alpha Bar Color" + Environment.NewLine +
                "patch=1,EE,205AF760,extended,000" + p2Spa[4] + " //SPA Down" + Environment.NewLine +
                "//P3" + Environment.NewLine +
                "patch=1,EE,205B8EA2,extended,3F"+ p3Spa[0] + "0 //SPA Down Red Bar Color" + Environment.NewLine +
                "patch=1,EE,205B8EA6,extended,3F"+ p3Spa[1] + "0 //SPA Down Green Bar Color" + Environment.NewLine +
                "patch=1,EE,205B8EAA,extended,3F"+ p3Spa[2] + "0 //SPA Down Blue Bar Color" + Environment.NewLine +
                "patch=1,EE,205B8EAE,extended,3F"+ p3Spa[3] + "0 //SPA Down Alpha Bar Color" + Environment.NewLine +
                "patch=1,EE,205B8EB0,extended,000" + p3Spa[4] + " //SPA Down" + Environment.NewLine +
                "//P4" + Environment.NewLine +
                "patch=1,EE,205C25F2,extended,3F"+ p4Spa[0] + "0 //SPA Down Red Bar Color" + Environment.NewLine +
                "patch=1,EE,205C25F6,extended,3F"+ p4Spa[1] + "0 //SPA Down Green Bar Color" + Environment.NewLine +
                "patch=1,EE,205C25FA,extended,3F"+ p4Spa[2] + "0 //SPA Down Blue Bar Color" + Environment.NewLine +
                "patch=1,EE,205C25FE,extended,3F"+ p4Spa[3] + "0 //SPA Down Alpha Bar Color" + Environment.NewLine +
                "patch=1,EE,205C2600,extended,000" + p4Spa[4] + " //SPA Down" + Environment.NewLine +
                "";

            ExportPnach.ExportFile(baseCode);
        }


        public static List<string> GetSpa(string playerSelectedSpa)
        {
            List<string> values = new List<string>();
            switch (playerSelectedSpa)
            {
                case "None":
                    values.Add("8");
                    values.Add("8");
                    values.Add("8");
                    values.Add("0");
                    values.Add("0");
                    break;
                case "Armor SPA":
                    values.Add("8");
                    values.Add("8");
                    values.Add("2");
                    values.Add("2");
                    values.Add("1");
                    break;
                case "Power Up SPA":
                    values.Add("8");
                    values.Add("2");
                    values.Add("2");
                    values.Add("2");
                    values.Add("2");
                    break;
                case "Concentration SPA":
                    values.Add("2");
                    values.Add("2");
                    values.Add("8");
                    values.Add("8");
                    values.Add("3");
                    break;
                case "Arcanum SPA":
                    values.Add("2");
                    values.Add("8");
                    values.Add("2");
                    values.Add("2");
                    values.Add("4");
                    break;
                case "Power + Armor *":
                    values.Add("8");
                    values.Add("2");
                    values.Add("8");
                    values.Add("8");
                    values.Add("5");
                    break;
                case "Power + Armor #":
                    values.Add("8");
                    values.Add("2");
                    values.Add("8");
                    values.Add("8");
                    values.Add("6");
                    break;
                case "Power + Concentration":
                    values.Add("8");
                    values.Add("2");
                    values.Add("8");
                    values.Add("8");
                    values.Add("7");
                    break;
                case "Power + Arcanum":
                    values.Add("8");
                    values.Add("2");
                    values.Add("8");
                    values.Add("8");
                    values.Add("8");
                    break;
            }

            return values;
        }
    }
}
