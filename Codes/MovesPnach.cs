using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UR_pnach_editor.Codes
{
    public class MovesPnach
    {
        //6B68C800 = 204A0000 (4B1EC800 dif)

        public static string masterBradMoveset =
                "patch=1,EE,20579408,extended,031D //Master Brad : IDLE" + Environment.NewLine +
                "patch=1,EE,2057943A,extended,03DB //Master Brad : TAUNT" + Environment.NewLine +
                "patch=1,EE,205566A8,extended,0F16 //Master Brad : ○ 3RD state" + Environment.NewLine +
                "patch=1,EE,20556504,extended,0EF8 //Master Brad : ○ 3RD state	DELAYED" + Environment.NewLine +
                "patch=1,EE,205563F6,extended,0EB8 //Master Brad : Cancel Neutral △" + Environment.NewLine +
                "patch=1,EE,20557986,extended,046D //Master Brad : ○ 3RD state" + Environment.NewLine +
                "patch=1,EE,20557B2A,extended,06D1 //Master Brad : ○ 3RD state	ALT." + Environment.NewLine +
                "patch=1,EE,20579658,extended,0CD1 //Master Brad : △ + ↑" + Environment.NewLine +
                "patch=1,EE,20555820,extended,0C29 //Master Brad : WALL HIT CONFIRM" + Environment.NewLine +
                "patch=1,EE,20579676,extended,0EA4 //Master Brad : △ + ↓" + Environment.NewLine +
                "patch=1,EE,20579694,extended,0E70 //Master Brad : △ + →" + Environment.NewLine +
                "patch=1,EE,2057965A,extended,0C53 //Master Brad : Back △ + ↑" + Environment.NewLine +
                "patch=1,EE,20579696,extended,0DB0 //Master Brad : Back △ + →" + Environment.NewLine +
                "patch=1,EE,20579678,extended,0DC1 //Master Brad : Back △ + ↓" + Environment.NewLine +
                "patch=1,EE,2057965C,extended,0CEF //Master Brad : Face away △ + ↑" + Environment.NewLine +
                "patch=1,EE,20579698,extended,0E47 //Master Brad : Face away △ + →" + Environment.NewLine +
                "patch=1,EE,2057967A,extended,0CF0 //Master Brad : Face away △ + ↓" + Environment.NewLine +
                "patch=1,EE,2057966E,extended,0C40 //Master Brad : △ + downed enemy face up LEGS" + Environment.NewLine +
                "patch=1,EE,20579650,extended,0CE7 //Master Brad : △ + downed enemy face up HEAD" + Environment.NewLine +
                "patch=1,EE,2057968C,extended,0C32 //Master Brad : △ + downed enemy face up RIGHT" + Environment.NewLine +
                "patch=1,EE,205796AA,extended,0C3D //Master Brad : △ + downed enemy face up LEFT" + Environment.NewLine +
                "patch=1,EE,2057968E,extended,0EC4 //Master Brad : △ + downed enemy face down RIGHT" + Environment.NewLine +
                "patch=1,EE,205796AC,extended,0C3F //Master Brad : △ + downed enemy face down LEFT" + Environment.NewLine +
                "patch=1,EE,20579654,extended,0E21 //Master Brad : △ + AIR ENEMY BACK FACE UP" + Environment.NewLine +
                "patch=1,EE,20555A96,extended,0EA9 //Master Brad : ✕ follow-up" + Environment.NewLine +
                "patch=1,EE,20579674,extended,0CCB //Master Brad : △ + AIR ENEMY FACE DOWN LEGS" + Environment.NewLine +
                "patch=1,EE,205796B0,extended,0F4F //Master Brad : △ + AIR ENEMY FACE DOWN SIDE" + Environment.NewLine +
                "patch=1,EE,20579656,extended,0E24 //Master Brad : △ + AIR ENEMY FACE DOWN HEAD" + Environment.NewLine +
                "patch=1,EE,205796AE,extended,0F5A //Master Brad : △ + AIR ENEMY SIDE FACE UP" + Environment.NewLine +
                "patch=1,EE,205440C0,extended,0D8E //Master Brad : △ Front" + Environment.NewLine +
                "patch=1,EE,205440DE,extended,0D92 //Master Brad : △ Back" + Environment.NewLine +
                "patch=1,EE,20545CC2,extended,08A3 //Master Brad : ○ . ○ . ○ . ○ last" + Environment.NewLine +
                "patch=1,EE,205795E2,extended,0535 //Master Brad : ○ + ↑" + Environment.NewLine +
                "patch=1,EE,2054D666,extended,08C2 //Master Brad : ○ + → . ○ . ○ last" + Environment.NewLine +
                "patch=1,EE,205795FA,extended,0972 //Master Brad : ○ + ↓" + Environment.NewLine +
                "patch=1,EE,205795FE,extended,0BCF //Master Brad : Face away ○ + ↓" + Environment.NewLine +
                "patch=1,EE,205795E4,extended,0ADE //Master Brad : Face away ○ + ↑" + Environment.NewLine +
                "patch=1,EE,2054DCBA,extended,0570 //Master Brad : Face away ○ + → . ○ . ○ last" + Environment.NewLine +
                "patch=1,EE,205795D0,extended,06CD //Master Brad : Neutral ✕ . ○" + Environment.NewLine +
                "patch=1,EE,20579618,extended,076F //Master Brad : ✕ . ○ + →" + Environment.NewLine +
                "patch=1,EE,205795E8,extended,0AC6 //Master Brad : ✕ . ○ + ↑" + Environment.NewLine +
                "patch=1,EE,20579482,extended,073F //Master Brad : △ + ○" + Environment.NewLine +
                "patch=1,EE,20579484,extended,068F //Master Brad : △ + ○ + ↑" + Environment.NewLine +
                "patch=1,EE,20579486,extended,07D5 //Master Brad : △ + ○ + ↓" + Environment.NewLine +
                "patch=1,EE,20545998,extended,0817 //Master Brad : △ + ○ + → last" + Environment.NewLine +
                "patch=1,EE,20579418,extended,0CA7 //Master Brad : ✕ . □" + Environment.NewLine +
                "";

        public static string golemBrokenShitMoveset =
                "patch=1,EE,20579B5A,extended,073F //Golem Broken Shit : O" + Environment.NewLine +
                "patch=1,EE,20579B72,extended,0BC1 //Golem Broken Shit : O+↑" + Environment.NewLine +
                "patch=1,EE,20579B8A,extended,0489 //Golem Broken Shit : O+↓" + Environment.NewLine +
                "patch=1,EE,20579BA2,extended,05F4 //Golem Broken Shit : O+→" + Environment.NewLine +
                "patch=1,EE,20579A16,extended,07D5 //Golem Broken Shit : O+△+↓" + Environment.NewLine +//07D6
                "";

        public static string bordinAllAroundMoves =
                "patch=1,EE,2055ABAE,extended,0BCB //Bordin Improved : last hit from △" + Environment.NewLine +
                "patch=1,EE,2057A26A,extended,073F //Bordin Improved : △+O" + Environment.NewLine +
                "patch=1,EE,2057A26C,extended,06EC //Bordin Improved : △+O+↑" + Environment.NewLine +
                "patch=1,EE,2057A26E,extended,0A99 //Bordin Improved : △+O+↓" + Environment.NewLine +
                "patch=1,EE,2057A270,extended,0744 //Bordin Improved : △+O+→" + Environment.NewLine +
                "patch=1,EE,2057A3B2,extended,0535 //Bordin Improved : O" + Environment.NewLine +
                "patch=1,EE,2057A3B8,extended,0AC6 //Bordin Improved : Run+O" + Environment.NewLine +
                "patch=1,EE,2057A3CA,extended,0880 //Bordin Improved : O+↑" + Environment.NewLine +
                "patch=1,EE,2057A3E2,extended,089E //Bordin Improved : O+↓" + Environment.NewLine +
                "patch=1,EE,2057A3FA,extended,072A //Bordin Improved : O+→" + Environment.NewLine +
                "patch=1,EE,2057A400,extended,0B05 //Bordin Improved : Run+O+Side" + Environment.NewLine +
                "patch=1,EE,2057A440,extended,0E0A //Bordin Improved : △+↑" + Environment.NewLine +
                "patch=1,EE,2057A45E,extended,0CC9 //Bordin Improved : △+↓" + Environment.NewLine +
                "patch=1,EE,2057A47C,extended,0EA9 //Bordin Improved : △+→" + Environment.NewLine +
                "";

        public static string paulAshesMoves =
                "patch=1,EE,2057C512,extended,0DF3 //Paul Ashes : N Str" + Environment.NewLine +
                "patch=1,EE,2057C542,extended,09D3 //Paul Ashes : D Str" + Environment.NewLine +
                "patch=1,EE,2057C55A,extended,09A9 //Paul Ashes : S Str" + Environment.NewLine +
                "patch=1,EE,2057C5A0,extended,0E0A //Paul Ashes : U G" + Environment.NewLine +
                "patch=1,EE,2057C5DC,extended,0C35 //Paul Ashes : S G" + Environment.NewLine +
                "patch=1,EE,2057C5BE,extended,0F53 //Paul Ashes : D G" + Environment.NewLine +
                "patch=1,EE,2057C514,extended,0E10 //Paul Ashes : FA Str" + Environment.NewLine +
                "patch=1,EE,2057C5DE,extended,0CAF //Paul Ashes : B S G" + Environment.NewLine +
                "patch=1,EE,2057C5A2,extended,0C53 //Paul Ashes : B U G" + Environment.NewLine +
                "patch=1,EE,2057C3CC,extended,0580 //Paul Ashes : SPA U" + Environment.NewLine +
                "patch=1,EE,2057C5C0,extended,0E21 //Paul Ashes : B D G" + Environment.NewLine +
                "patch=1,EE,20596E9A,extended,0AEE //Paul Ashes : SPA N STR" + Environment.NewLine +
                "patch=1,EE,20596E9E,extended,0DF3 //Paul Ashes : SPA FA N STR" + Environment.NewLine +
                "patch=1,EE,20596ECA,extended,09D3 //Paul Ashes : SPA D STR" + Environment.NewLine +
                "patch=1,EE,2057C5A4,extended,0E24 //Paul Ashes : FA U G" + Environment.NewLine +
                "patch=1,EE,2057C530,extended,09B3 //Paul Ashes : WR U STR" + Environment.NewLine +
                "patch=1,EE,2057C544,extended,046D //Paul Ashes : FA D STR 2" + Environment.NewLine +
                "patch=1,EE,2057B1CE,extended,046D //Paul Ashes : FA D STR" + Environment.NewLine +
                "patch=1,EE,2057C598,extended,0E8C //Paul Ashes : GROUNDED HEAD G" + Environment.NewLine +
                "patch=1,EE,2057C5B6,extended,0E8C //Paul Ashes : GROUNDED LEG G" + Environment.NewLine +
                "patch=1,EE,2057C5B8,extended,0F58 //Paul Ashes : PRONE LEG G" + Environment.NewLine +
                "patch=1,EE,2057C59A,extended,0F58 //Paul Ashes : PRONE HEAD G" + Environment.NewLine +
                "patch=1,EE,2057C54A,extended,046D //Paul Ashes : GROUNDED D STR" + Environment.NewLine +
                "patch=1,EE,2057C588,extended,0E8A //Paul Ashes : WR G" + Environment.NewLine +
                "patch=1,EE,20637E90,extended,0E8C //Paul Ashes : WR G FOLLOW UP" + Environment.NewLine + 
                "";

    }
}
