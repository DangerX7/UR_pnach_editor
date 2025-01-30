using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Collections.ObjectModel;
using System.IO;
using System.Windows;
using UR_pnach_editor.Views;
using UR_pnach_editor.Services;
using System.Windows.Documents;
using System.Diagnostics;
using System.Threading;
using System.Windows.Markup;
using UR_pnach_editor.Codes;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.DirectoryServices;

namespace UR_pnach_editor.ViewModels
{
    public class MysteriousViewModel : BaseViewModel
    {
        public MysteriousViewModel()
        {
            SettingsClass.LoadData();
        }


        private string animatedSource;
        public string AnimatedSource
        {
            get { return animatedSource; }
            set
            {
                if (animatedSource != value)
                {
                    animatedSource = value;
                    RaisePropertyChanged("AnimatedSource");
                }
            }
        }

        private string animatedSource2;
        public string AnimatedSource2
        {
            get { return animatedSource2; }
            set
            {
                if (animatedSource2 != value)
                {
                    animatedSource2 = value;
                    RaisePropertyChanged("AnimatedSource2");
                }
            }
        }

        private string animatedSource3;
        public string AnimatedSource3
        {
            get { return animatedSource3; }
            set
            {
                if (animatedSource3 != value)
                {
                    animatedSource3 = value;
                    RaisePropertyChanged("AnimatedSource3");
                }
            }
        }

        public List<string> Difficulty_List = new List<string>
        {
            "Simple",
            "Easy",
            "Normal",
            "Hard",
            "Hell",
            "Random",
        };

        public List<int> EnemyNumbers_List = new List<int>
        {
            5,
            10,
            20,
            30,
            40,
            50,
            60,
            70,
            80,
            90,
            100,
            150,
            200,
        };

        public List<string> EnemyDifficulty_List = new List<string>
        {
            "Level 1",
            "Level 2",
            "Level 3",
            "Level 4",
            "Level 5",
            "Level 6",
        };

        public List<string> ChallengeFormat_List = new List<string>
        {
            "Single Battle",
            "Team Battle",
        };

        public int playersToGet = 0;
        public bool onlyP1 = false;

        internal void GenerateModifiers(string difficulty, int numbers, string enemyDifficulty, string challengeFormat)
        {

            string baseCode = "";
            string conditionalStage = "patch=1,EE,D05E9284,extended,";
            string conditionalStageRest = "0000";
            string conditionalStageInfo = " //If Stage = ";

            //divide by 5  (10:5=2, 50:5=10)

            List<int> difficultyRandomsPlayer1 = new List<int> { 0 };
            List<int> difficultyRandomsPlayer2 = new List<int> { 0 };
            List<int> difficultyRandomsPlayer3 = new List<int> { 0 };
            List<int> difficultyRandomsPlayer4 = new List<int> { 0 };
            List<int> difficultyRandomsPlayer5 = new List<int> { 0 };
            List<int> difficultyRandomsOpponent1 = new List<int> { 0 };
            List<int> difficultyRandomsOpponent2 = new List<int> { 0 };
            List<int> difficultyRandomsOpponent3 = new List<int> { 0 };
            List<int> difficultyRandomsOpponent4 = new List<int> { 0 };
            List<int> difficultyRandomsOpponent5 = new List<int> { 0 };

            switch (difficulty)
            {
                case "Simple":
                    difficultyRandomsPlayer1 = new List<int> { 4, };
                    difficultyRandomsOpponent1 = new List<int> { 0, };
                    difficultyRandomsPlayer2 = new List<int> { 3, 4 };
                    difficultyRandomsOpponent2 = new List<int> { 0, 1, };
                    difficultyRandomsPlayer3 = new List<int> { 3, 3, 3, 4,};
                    difficultyRandomsOpponent3 = new List<int> { 0, 1, 1, 2 };
                    difficultyRandomsPlayer4 = new List<int> { 2, 3, 4 };
                    difficultyRandomsOpponent4 = new List<int> { 1, 1, 2, };
                    difficultyRandomsPlayer5 = new List<int> { 3 };
                    difficultyRandomsOpponent5 = new List<int> { 2 };
                    break;
                case "Easy":
                    difficultyRandomsPlayer1 = new List<int> { 3, 4, 4, };
                    difficultyRandomsOpponent1 = new List<int> { 0, 1, };
                    difficultyRandomsPlayer2 = new List<int> { 3 };
                    difficultyRandomsOpponent2 = new List<int> { 0, 1, 1, 2, };
                    difficultyRandomsPlayer3 = new List<int> { 2, 3, 3, 4, 4 };
                    difficultyRandomsOpponent3 = new List<int> { 1, 2 };
                    difficultyRandomsPlayer4 = new List<int> { 2, 3, 4 };
                    difficultyRandomsOpponent4 = new List<int> { 1, 2, 2, 3, };
                    difficultyRandomsPlayer5 = new List<int> { 2, 3, };
                    difficultyRandomsOpponent5 = new List<int> { 2, 3 };
                    break;
                case "Normal":
                    difficultyRandomsPlayer1 = new List<int> { 2, 3, 4 };
                    difficultyRandomsOpponent1 = new List<int> { 0, 1, 2 };
                    difficultyRandomsPlayer2 = new List<int> { 2, 2, 2, 3, 4 };
                    difficultyRandomsOpponent2 = new List<int> { 1, 2, 2 };
                    difficultyRandomsPlayer3 = new List<int> { 2, 2, 3, };
                    difficultyRandomsOpponent3 = new List<int> { 2, 2, 2 };
                    difficultyRandomsPlayer4 = new List<int> { 1, 2, 2, };
                    difficultyRandomsOpponent4 = new List<int> { 2, 2, 3 };
                    difficultyRandomsPlayer5 = new List<int> { 0, 1, 2, };
                    difficultyRandomsOpponent5 = new List<int> { 2, 2, 3, 4 };
                    break;
                case "Hard":
                    difficultyRandomsPlayer1 = new List<int> { 1, 2, 3 };
                    difficultyRandomsOpponent1 = new List<int> { 1, 2, 3 };
                    difficultyRandomsPlayer2 = new List<int> { 0, 1, 2, 2};
                    difficultyRandomsOpponent2 = new List<int> { 2, 3, 3 };
                    difficultyRandomsPlayer3 = new List<int> { 1,};
                    difficultyRandomsOpponent3 = new List<int> { 2, 3, 3, 3, 4 };
                    difficultyRandomsPlayer4 = new List<int> { 0, 0, 0, 1, 1, 1, 1, 2 };
                    difficultyRandomsOpponent4 = new List<int> { 3, 3, 3, 4 };
                    difficultyRandomsPlayer5 = new List<int> { 0, 1, 1, };
                    difficultyRandomsOpponent5 = new List<int> { 1, 3, 3, 3, 4, 4 };
                    break;
                case "Hell":
                    difficultyRandomsPlayer1 = new List<int> { 1, 2,};
                    difficultyRandomsOpponent1 = new List<int> { 2, 3 };
                    difficultyRandomsPlayer2 = new List<int> { 1, 1, 1, 2 };
                    difficultyRandomsOpponent2 = new List<int> { 2, 3, 3, 4 };
                    difficultyRandomsPlayer3 = new List<int> { 1, };
                    difficultyRandomsOpponent3 = new List<int> { 3, 3, 3, 4 };
                    difficultyRandomsPlayer4 = new List<int> { 0, 1,};
                    difficultyRandomsOpponent4 = new List<int> { 3, 4 };
                    difficultyRandomsPlayer5 = new List<int> { 0, 0, 1, };
                    difficultyRandomsOpponent5 = new List<int> { 3, 4, 4, 4,};
                    break;
                case "Random":
                    difficultyRandomsPlayer1 = new List<int> { 0, 1, 2, 3, 4 };
                    difficultyRandomsOpponent1 = new List<int> { 0, 1, 2, 3, 4 };
                    difficultyRandomsPlayer2 = new List<int> { 0, 1, 2, 3, 4 };
                    difficultyRandomsOpponent2 = new List<int> { 0, 1, 2, 3, 4 };
                    difficultyRandomsPlayer3 = new List<int> { 0, 1, 2, 3, 4 };
                    difficultyRandomsOpponent3 = new List<int> { 0, 1, 2, 3, 4 };
                    difficultyRandomsPlayer4 = new List<int> { 0, 1, 2, 3, 4 };
                    difficultyRandomsOpponent4 = new List<int> { 0, 1, 2, 3, 4 };
                    difficultyRandomsPlayer5 = new List<int> { 0, 1, 2, 3, 4 };
                    difficultyRandomsOpponent5 = new List<int> { 0, 1, 2, 3, 4 };
                    break;
            }


            int halfNumber = numbers / 5;  //10:5=2
            List<int> limits = new List<int> { halfNumber, halfNumber * 2, halfNumber * 3, halfNumber * 4 };
            Random random = new Random();
            int randomIndex = 0;
            int selectedElement = 0;
            string code = "";
            int testCodeRows = 0;
            int j = 0;

            baseCode += "patch=1,EE,005E928C,extended," + numbers.ToString("X2") + " // enemies number" + Environment.NewLine;

            switch (enemyDifficulty)
            {
                case "Level 1":
                    baseCode += "patch=1,EE,205A5F94,extended,00000014 //cpu 1 AI" + Environment.NewLine +
                                "patch=1,EE,205AF6E4,extended,00000014 //cpu 2 AI" + Environment.NewLine +
                                "patch=1,EE,205B8E34,extended,00000014 //cpu 3 AI" + Environment.NewLine +
                                "patch=1,EE,205C2584,extended,00000014 //cpu 4 AI" + Environment.NewLine;
                    break;
                case "Level 2":
                    baseCode += "patch=1,EE,205A5F94,extended,00010016 //cpu 1 AI" + Environment.NewLine +
                                "patch=1,EE,205AF6E4,extended,00010016 //cpu 2 AI" + Environment.NewLine +
                                "patch=1,EE,205B8E34,extended,00010016 //cpu 3 AI" + Environment.NewLine +
                                "patch=1,EE,205C2584,extended,00010016 //cpu 4 AI" + Environment.NewLine;
                    break;
                case "Level 3":
                    baseCode += "patch=1,EE,205A5F94,extended,00020019 //cpu 1 AI" + Environment.NewLine +
                                "patch=1,EE,205AF6E4,extended,00020019 //cpu 2 AI" + Environment.NewLine +
                                "patch=1,EE,205B8E34,extended,00020019 //cpu 3 AI" + Environment.NewLine +
                                "patch=1,EE,205C2584,extended,00020019 //cpu 4 AI" + Environment.NewLine;
                    break;
                case "Level 4":
                    baseCode += "patch=1,EE,205A5F94,extended,0003001A //cpu 1 AI" + Environment.NewLine +
                                "patch=1,EE,205AF6E4,extended,0003001A //cpu 2 AI" + Environment.NewLine +
                                "patch=1,EE,205B8E34,extended,0003001A //cpu 3 AI" + Environment.NewLine +
                                "patch=1,EE,205C2584,extended,0003001A //cpu 4 AI" + Environment.NewLine;
                    break;
                case "Level 5":
                    baseCode += "patch=1,EE,205A5F94,extended,0004001B //cpu 1 AI" + Environment.NewLine +
                                "patch=1,EE,205AF6E4,extended,0004001B //cpu 2 AI" + Environment.NewLine +
                                "patch=1,EE,205B8E34,extended,0004001B //cpu 3 AI" + Environment.NewLine +
                                "patch=1,EE,205C2584,extended,0004001B //cpu 4 AI" + Environment.NewLine;
                    break;
                case "Level 6":
                    baseCode += "patch=1,EE,205A5F94,extended,003A003A //cpu 1 AI" + Environment.NewLine +
                                "patch=1,EE,205AF6E4,extended,003A003A //cpu 2 AI" + Environment.NewLine +
                                "patch=1,EE,205B8E34,extended,003A003A //cpu 3 AI" + Environment.NewLine +
                                "patch=1,EE,205C2584,extended,003A003A //cpu 4 AI" + Environment.NewLine;
                    break;
            }

            int jLimit = 0;
            int teamMultiplier = 0;
            if (challengeFormat == "Single Battle")
            {
                jLimit = 2;
                teamMultiplier = 1;
                playersToGet = 1;
            }
            else if (challengeFormat == "Team Battle")
            {
                jLimit = 3;
                teamMultiplier = 2;
                playersToGet = 2;
            }

            if (playersToGet == 1)
            {
                onlyP1 = true;
            }

            for (int i = 1; i <= numbers; i++) //1,2/ 3,4/ 5,6/ 7,8/ 9,10
            {
                if (i <= limits[0])
                {
                    for (j = 1; j < jLimit; j++)
                    {

                        //select random modifier from selected list
                        randomIndex = random.Next(0, difficultyRandomsPlayer1.Count);
                        selectedElement = difficultyRandomsPlayer1[randomIndex];
                        code = GetCode(selectedElement, j, "player");

                        //stats read and write in memory (they need to be reseted manually when you enter a new stage)
                        code = StatsReadAndWriteInMemory(code, teamMultiplier, j);

                        //Get rows count
                        testCodeRows = code.Split(new[] { Environment.NewLine }, StringSplitOptions.None).Length;
                        //Write condition code
                        baseCode += (conditionalStage + testCodeRows.ToString("X2") + conditionalStageRest + ((i - 1) * teamMultiplier).ToString("X2") + conditionalStageInfo + i + " and Player " + j) + Environment.NewLine;
                        //write pnach code
                        baseCode += code + Environment.NewLine;


                        //select random modifier from selected list
                        randomIndex = random.Next(0, difficultyRandomsOpponent1.Count);
                        selectedElement = difficultyRandomsOpponent1[randomIndex];
                        code = GetCode(selectedElement, j + (1* teamMultiplier), "enemy");

                        //Get rows count
                        testCodeRows = code.Split(new[] { Environment.NewLine }, StringSplitOptions.None).Length;
                        //Write condition code
                        baseCode += (conditionalStage + testCodeRows.ToString("X2") + conditionalStageRest + ((i - 1)* teamMultiplier).ToString("X2") + conditionalStageInfo + i + " and Enemy " + j) + Environment.NewLine;
                        //write pnach code
                        baseCode += code + Environment.NewLine;
                    }
                }
                else if (i > limits[0] && i <= limits[1])
                {
                    for (j = 1; j < jLimit; j++)
                    {

                        //select random modifier from selected list
                        randomIndex = random.Next(0, difficultyRandomsPlayer2.Count);
                        selectedElement = difficultyRandomsPlayer2[randomIndex];
                        code = GetCode(selectedElement, j, "player");

                        //stats read and write in memory (they need to be reseted manually when you enter a new stage)
                        code = StatsReadAndWriteInMemory(code, teamMultiplier, j);

                        //Get rows count
                        testCodeRows = code.Split(new[] { Environment.NewLine }, StringSplitOptions.None).Length;
                        //Write condition code
                        baseCode += (conditionalStage + testCodeRows.ToString("X2") + conditionalStageRest + ((i - 1) * teamMultiplier).ToString("X2") + conditionalStageInfo + i + " and Player " + j) + Environment.NewLine;
                        //write pnach code
                        baseCode += code + Environment.NewLine;


                        //select random modifier from selected list
                        randomIndex = random.Next(0, difficultyRandomsOpponent2.Count);
                        selectedElement = difficultyRandomsOpponent2[randomIndex];
                        code = GetCode(selectedElement, j + (1 * teamMultiplier), "enemy");

                        //Get rows count
                        testCodeRows = code.Split(new[] { Environment.NewLine }, StringSplitOptions.None).Length;
                        //Write condition code
                        baseCode += (conditionalStage + testCodeRows.ToString("X2") + conditionalStageRest + ((i - 1) * teamMultiplier).ToString("X2") + conditionalStageInfo + i + " and Enemy " + j) + Environment.NewLine;
                        //write pnach code
                        baseCode += code + Environment.NewLine;
                    }
                }
                else if (i > limits[1] && i <= limits[2])
                {
                    for (j = 1; j < jLimit; j++)
                    {

                        //select random modifier from selected list
                        randomIndex = random.Next(0, difficultyRandomsPlayer3.Count);
                        selectedElement = difficultyRandomsPlayer3[randomIndex];
                        code = GetCode(selectedElement, j, "player");

                        //stats read and write in memory (they need to be reseted manually when you enter a new stage)
                        code = StatsReadAndWriteInMemory(code, teamMultiplier, j);

                        //Get rows count
                        testCodeRows = code.Split(new[] { Environment.NewLine }, StringSplitOptions.None).Length;
                        //Write condition code
                        baseCode += (conditionalStage + testCodeRows.ToString("X2") + conditionalStageRest + ((i - 1) * teamMultiplier).ToString("X2") + conditionalStageInfo + i + " and Player " + j) + Environment.NewLine;
                        //write pnach code
                        baseCode += code + Environment.NewLine;


                        //select random modifier from selected list
                        randomIndex = random.Next(0, difficultyRandomsOpponent3.Count);
                        selectedElement = difficultyRandomsOpponent3[randomIndex];
                        code = GetCode(selectedElement, j + (1 * teamMultiplier), "enemy");

                        //Get rows count
                        testCodeRows = code.Split(new[] { Environment.NewLine }, StringSplitOptions.None).Length;
                        //Write condition code
                        baseCode += (conditionalStage + testCodeRows.ToString("X2") + conditionalStageRest + ((i - 1) * teamMultiplier).ToString("X2") + conditionalStageInfo + i + " and Enemy " + j) + Environment.NewLine;
                        //write pnach code
                        baseCode += code + Environment.NewLine;
                    }
                }
                else if (i > limits[2] && i <= limits[3])
                {
                    for (j = 1; j < jLimit; j++)
                    {

                        //select random modifier from selected list
                        randomIndex = random.Next(0, difficultyRandomsPlayer4.Count);
                        selectedElement = difficultyRandomsPlayer4[randomIndex];
                        code = GetCode(selectedElement, j, "player");

                        //stats read and write in memory (they need to be reseted manually when you enter a new stage)
                        code = StatsReadAndWriteInMemory(code, teamMultiplier, j);

                        //Get rows count
                        testCodeRows = code.Split(new[] { Environment.NewLine }, StringSplitOptions.None).Length;
                        //Write condition code
                        baseCode += (conditionalStage + testCodeRows.ToString("X2") + conditionalStageRest + ((i - 1) * teamMultiplier).ToString("X2") + conditionalStageInfo + i + " and Player " + j) + Environment.NewLine;
                        //write pnach code
                        baseCode += code + Environment.NewLine;


                        //select random modifier from selected list
                        randomIndex = random.Next(0, difficultyRandomsOpponent4.Count);
                        selectedElement = difficultyRandomsOpponent4[randomIndex];
                        code = GetCode(selectedElement, j + (1 * teamMultiplier), "enemy");

                        //Get rows count
                        testCodeRows = code.Split(new[] { Environment.NewLine }, StringSplitOptions.None).Length;
                        //Write condition code
                        baseCode += (conditionalStage + testCodeRows.ToString("X2") + conditionalStageRest + ((i - 1) * teamMultiplier).ToString("X2") + conditionalStageInfo + i + " and Enemy " + j) + Environment.NewLine;
                        //write pnach code
                        baseCode += code + Environment.NewLine;
                    }
                }
                else if (i > limits[3])
                {
                    for (j = 1; j < jLimit; j++)
                    {

                        //select random modifier from selected list
                        randomIndex = random.Next(0, difficultyRandomsPlayer5.Count);
                        selectedElement = difficultyRandomsPlayer5[randomIndex];
                        code = GetCode(selectedElement, j, "player");

                        //stats read and write in memory (they need to be reseted manually when you enter a new stage)
                        code = StatsReadAndWriteInMemory(code, teamMultiplier, j);

                        //Get rows count
                        testCodeRows = code.Split(new[] { Environment.NewLine }, StringSplitOptions.None).Length;
                        //Write condition code
                        baseCode += (conditionalStage + testCodeRows.ToString("X2") + conditionalStageRest + ((i - 1) * teamMultiplier).ToString("X2") + conditionalStageInfo + i + " and Player " + j) + Environment.NewLine;
                        //write pnach code
                        baseCode += code + Environment.NewLine;


                        //select random modifier from selected list
                        randomIndex = random.Next(0, difficultyRandomsOpponent5.Count);
                        selectedElement = difficultyRandomsOpponent5[randomIndex];
                        code = GetCode(selectedElement, j + (1 * teamMultiplier), "enemy");

                        //Get rows count
                        testCodeRows = code.Split(new[] { Environment.NewLine }, StringSplitOptions.None).Length;
                        //Write condition code
                        baseCode += (conditionalStage + testCodeRows.ToString("X2") + conditionalStageRest + ((i - 1) * teamMultiplier).ToString("X2") + conditionalStageInfo + i + " and Enemy " + j) + Environment.NewLine;
                        //write pnach code
                        baseCode += code + Environment.NewLine;
                    }
                }

            }





            ExportPnach.ExportFile(baseCode);
        }

        internal string GetCode(int listNumber, int playerNumber, string type)
        {
            //based on playerNumber send different addresses into the switch case

            string code = "";
            List<string> codesList = new List<string>();
            Random random = new Random();
            int randomIndex = 0;
            string selectedElement = "";

            switch (listNumber)
            {
                case 0:
                    string noSpa = "noSpa";
                    string allStats400 = "allStats400";
                    string headEnduranceIsRed = "headEnduranceIsRed";
                    string upperEnduranceIsRed = "upperEnduranceIsRed";
                    string lowerEnduranceIsRed = "lowerEnduranceIsRed";
                    string toughness200 = "toughness200";
                    string strikeGrapple200 = "strikeGrapple200";
                    string startWithHalfHp = "startWithHalfHp";
                    switch (playerNumber)
                    {
                        case 1: //Player 1
                            noSpa = "patch=1,EE,105A5FF2,extended,0000 //no spa";
                            allStats400 = "patch=1,EE,105A6018,extended,0190 //STK" + Environment.NewLine +
                                          "patch=1,EE,105A601A,extended,0190 //GRP" + Environment.NewLine +
                                          "patch=1,EE,105A601C,extended,0190 //RGA" + Environment.NewLine +
                                          "patch=1,EE,105A601E,extended,0190 //SPA" + Environment.NewLine +
                                          "patch=1,EE,105A6020,extended,0190 //WPA" + Environment.NewLine +
                                          "patch=1,EE,105A6022,extended,0190 //TGH" + Environment.NewLine +
                                          "patch=1,EE,105A5FD2,extended,00C8 //HDEx" + Environment.NewLine +
                                          "patch=1,EE,105A5FD8,extended,0064 //HDE Balance" + Environment.NewLine +
                                          "patch=1,EE,105A5FD4,extended,00C8 //UBEx" + Environment.NewLine +
                                          "patch=1,EE,105A5FDA,extended,0064 //UBE Balance" + Environment.NewLine +
                                          "patch=1,EE,105A5FD6,extended,00C8 //LBEx" + Environment.NewLine +
                                          "patch=1,EE,105A5FDC,extended,0064 //LBE Balance";
                            headEnduranceIsRed = "patch=1,EE,105A5FD2,extended,0000 //HDEx" + Environment.NewLine +
                                                 "patch=1,EE,105A5FD8,extended,0000 //HDE Balance";
                            upperEnduranceIsRed = "patch=1,EE,105A5FD4,extended,0000 //UBEx" + Environment.NewLine +
                                                  "patch=1,EE,105A5FDA,extended,0000 //UBE Balance";
                            lowerEnduranceIsRed = "patch=1,EE,105A5FD6,extended,0000 //LBEx" + Environment.NewLine +
                                                  "patch=1,EE,105A5FDC,extended,0000 //LBE Balance";
                            toughness200 = "patch=1,EE,105A6022,extended,00C8 //TGH";
                            strikeGrapple200 = "patch=1,EE,105A6018,extended,00C8 //STK";
                            startWithHalfHp = "patch=1,EE,D05A5FC8,extended,010005DC //if hp 100%" + Environment.NewLine +
                                              "patch=1,EE,105A5FC8,extended,02EE //hp is 50%";
                            break;
                        case 2: //Player 2
                            noSpa = "patch=1,EE,105AF742,extended,0000 //no spa";
                            allStats400 = "patch=1,EE,105AF768,extended,0190 //STK" + Environment.NewLine +
                                          "patch=1,EE,105AF76A,extended,0190 //GRP" + Environment.NewLine +
                                          "patch=1,EE,105AF76C,extended,0190 //RGA" + Environment.NewLine +
                                          "patch=1,EE,105AF76E,extended,0190 //SPA" + Environment.NewLine +
                                          "patch=1,EE,105AF770,extended,0190 //WPA" + Environment.NewLine +
                                          "patch=1,EE,105AF772,extended,0190 //TGH" + Environment.NewLine +
                                          "patch=1,EE,105AF722,extended,00C8 //HDEx" + Environment.NewLine +
                                          "patch=1,EE,105AF728,extended,0064 //HDE Balance" + Environment.NewLine +
                                          "patch=1,EE,105AF724,extended,00C8 //UBEx" + Environment.NewLine +
                                          "patch=1,EE,105AF72A,extended,0064 //UBE Balance" + Environment.NewLine +
                                          "patch=1,EE,105AF726,extended,00C8 //LBEx" + Environment.NewLine +
                                          "patch=1,EE,105AF72C,extended,0064 //LBE Balance";
                            headEnduranceIsRed = "patch=1,EE,105AF722,extended,0000 //HDEx" + Environment.NewLine +
                                                 "patch=1,EE,105AF728,extended,0000 //HDE Balance";
                            upperEnduranceIsRed = "patch=1,EE,105AF724,extended,0000 //UBEx" + Environment.NewLine +
                                                  "patch=1,EE,105AF72A,extended,0000 //UBE Balance";
                            lowerEnduranceIsRed = "patch=1,EE,105AF726,extended,0000 //LBEx" + Environment.NewLine +
                                                  "patch=1,EE,105AF72C,extended,0000 //LBE Balance";
                            toughness200 = "patch=1,EE,105AF772,extended,00C8 //TGH";
                            strikeGrapple200 = "patch=1,EE,105AF768,extended,00C8 //STK";
                            startWithHalfHp = "patch=1,EE,D05AF718,extended,010005DC //if hp 100%" + Environment.NewLine +
                                              "patch=1,EE,105AF718,extended,02EE //hp is 50%";
                            break;
                        case 3: //Enemy 1
                            noSpa = "patch=1,EE,105B8E92,extended,0000 //no spa";
                            allStats400 = "patch=1,EE,105B8EB8,extended,0190 //STK" + Environment.NewLine +
                                          "patch=1,EE,105B8EBA,extended,0190 //GRP" + Environment.NewLine +
                                          "patch=1,EE,105B8EBC,extended,0190 //RGA" + Environment.NewLine +
                                          "patch=1,EE,105B8EBE,extended,0190 //SPA" + Environment.NewLine +
                                          "patch=1,EE,105B8EC0,extended,0190 //WPA" + Environment.NewLine +
                                          "patch=1,EE,105B8EC2,extended,0190 //TGH" + Environment.NewLine +
                                          "patch=1,EE,105B8E72,extended,00C8 //HDEx" + Environment.NewLine +
                                          "patch=1,EE,105B8E78,extended,0064 //HDE Balance" + Environment.NewLine +
                                          "patch=1,EE,105B8E74,extended,00C8 //UBEx" + Environment.NewLine +
                                          "patch=1,EE,105B8E7A,extended,0064 //UBE Balance" + Environment.NewLine +
                                          "patch=1,EE,105B8E76,extended,00C8 //LBEx" + Environment.NewLine +
                                          "patch=1,EE,105B8E7C,extended,0064 //LBE Balance";
                            headEnduranceIsRed = "patch=1,EE,105B8E72,extended,0000 //HDEx" + Environment.NewLine +
                                                 "patch=1,EE,105B8E78,extended,0000 //HDE Balance";
                            upperEnduranceIsRed = "patch=1,EE,105B8E74,extended,0000 //UBEx" + Environment.NewLine +
                                                  "patch=1,EE,105B8E7A,extended,0000 //UBE Balance";
                            lowerEnduranceIsRed = "patch=1,EE,105B8E76,extended,0000 //LBEx" + Environment.NewLine +
                                                  "patch=1,EE,105B8E7C,extended,0000 //LBE Balance";
                            toughness200 = "patch=1,EE,105B8EC2,extended,00C8 //TGH";
                            strikeGrapple200 = "patch=1,EE,105B8EB8,extended,00C8 //STK";
                            startWithHalfHp = "patch=1,EE,D05A5FC8,extended,010005DC //if hp 100%" + Environment.NewLine +
                                              "patch=1,EE,105B8E68,extended,02EE //hp is 50%";
                            break;
                        case 4: //Enemy 2
                            noSpa = "patch=1,EE,105C25E2,extended,0000 //no spa";
                            allStats400 = "patch=1,EE,105C2608,extended,0190 //STK" + Environment.NewLine +
                                          "patch=1,EE,105C260A,extended,0190 //GRP" + Environment.NewLine +
                                          "patch=1,EE,105C260C,extended,0190 //RGA" + Environment.NewLine +
                                          "patch=1,EE,105C260E,extended,0190 //SPA" + Environment.NewLine +
                                          "patch=1,EE,105C2610,extended,0190 //WPA" + Environment.NewLine +
                                          "patch=1,EE,105C2612,extended,0190 //TGH" + Environment.NewLine +
                                          "patch=1,EE,105C25C2,extended,00C8 //HDEx" + Environment.NewLine +
                                          "patch=1,EE,105C25C8,extended,0064 //HDE Balance" + Environment.NewLine +
                                          "patch=1,EE,105C25C4,extended,00C8 //UBEx" + Environment.NewLine +
                                          "patch=1,EE,105C25CA,extended,0064 //UBE Balance" + Environment.NewLine +
                                          "patch=1,EE,105C25C6,extended,00C8 //LBEx" + Environment.NewLine +
                                          "patch=1,EE,105C25CC,extended,0064 //LBE Balance";
                            headEnduranceIsRed = "patch=1,EE,105C25C2,extended,0000 //HDEx" + Environment.NewLine +
                                                 "patch=1,EE,105C25C8,extended,0000 //HDE Balance";
                            upperEnduranceIsRed = "patch=1,EE,105C25C4,extended,0000 //UBEx" + Environment.NewLine +
                                                  "patch=1,EE,105C25CA,extended,0000 //UBE Balance";
                            lowerEnduranceIsRed = "patch=1,EE,105C25C6,extended,0000 //LBEx" + Environment.NewLine +
                                                  "patch=1,EE,105C25CC,extended,0000 //LBE Balance";
                            toughness200 = "patch=1,EE,105C2612,extended,00C8 //TGH";
                            strikeGrapple200 = "patch=1,EE,105C2608,extended,00C8 //STK";
                            startWithHalfHp = "patch=1,EE,D05AF718,extended,010005DC //if hp 100%" + Environment.NewLine +
                                              "patch=1,EE,105C25B8,extended,02EE //hp is 50%";
                            break;
                    }

                    codesList.Add(noSpa);
                    codesList.Add(startWithHalfHp);
                    if (playersToGet == 0)
                    {
                        codesList.Add(allStats400);
                        codesList.Add(headEnduranceIsRed);
                        codesList.Add(upperEnduranceIsRed);
                        codesList.Add(lowerEnduranceIsRed);
                        codesList.Add(toughness200);
                        codesList.Add(strikeGrapple200);
                    }
                    randomIndex = random.Next(0, codesList.Count);
                    code = codesList[randomIndex];
                    break;
                case 1:
                    string strike1500 = "strike1500";
                    string grapple1500 = "grapple1500";
                    string regional1500Weapon1500 = "regional1500Weapon1500";
                    string special1500 = "special1500";
                    string toughness1500 = "toughness1500";
                    string allEndurance1500 = "allEndurance1500";
                    string spaRecovery16 = "spaRecovery16";
                    string redbullSpa = "redbullSpa";

                    switch (playerNumber)
                    {
                        case 1: //Player 1
                            strike1500 = "patch=1,EE,105A6018,extended,05DC //STK";
                            grapple1500 = "patch=1,EE,105A601A,extended,05DC //GRP";
                            regional1500Weapon1500 = "patch=1,EE,105A601C,extended,05DC //RGA" + Environment.NewLine +
                                                     "patch=1,EE,105A6020,extended,03E8 //WPA";
                            special1500 = "patch=1,EE,105A601E,extended,05DC //SPA";
                            toughness1500 = "patch=1,EE,105A6022,extended,05DC //TGH";
                            allEndurance1500 = "patch=1,EE,105A5FD2,extended,02EE //HDEx" + Environment.NewLine +
                                               "patch=1,EE,105A5FD8,extended,0177 //HDE Balance" + Environment.NewLine +
                                               "patch=1,EE,105A5FD4,extended,02EE //UBEx" + Environment.NewLine +
                                               "patch=1,EE,105A5FDA,extended,0177 //UBE Balance" + Environment.NewLine +
                                               "patch=1,EE,105A5FD6,extended,02EE //LBEx" + Environment.NewLine +
                                               "patch=1,EE,105A5FDC,extended,0177 //LBE Balance";
                            spaRecovery16 = "patch=1,EE,105A6070,extended,00000010 //SPA Regained";
                            redbullSpa = "patch=1,EE,205A6002,extended,4000 //Spa Down Red Bar Color" + Environment.NewLine +
                                         "patch=1,EE,205A6006,extended,3F00 //Spa Down Green Bar Color" + Environment.NewLine +
                                         "patch=1,EE,205A600A,extended,3F00 //Spa Down Blue Bar Color" + Environment.NewLine +
                                         "patch=1,EE,205A600E,extended,4000 //Spa Down Alpha Bar Color" + Environment.NewLine +
                                         "patch=1,EE,205A6010,extended,0000 //Spa Down" + Environment.NewLine +
                                         "patch=1,EE,D05A6016,extended,02300000 //If SPA is activated" + Environment.NewLine +
                                         "patch=1,EE,D05A5FC8,extended,01300001 //If HP is higher than 0" + Environment.NewLine +
                                         "patch=1,EE,30300001,extended,005A5FC8 //Lose Health by 1" + Environment.NewLine +
                                         "patch=1,EE,D05A6016,extended,03300000 //If SPA is activated" + Environment.NewLine +
                                         "patch=1,EE,D05A5FF2,extended,022003E8 //If SPA is lower than max [1000]" + Environment.NewLine +
                                         "patch=1,EE,D05A5FC8,extended,01300001 //If HP is higher than 0" + Environment.NewLine +
                                         "patch=1,EE,30200005,extended,005A5FF2 //Recover SPA by 5";
                            break;
                        case 2: //Player 2
                            strike1500 = "patch=1,EE,105AF768,extended,05DC //STK";
                            grapple1500 = "patch=1,EE,105AF76A,extended,05DC //GRP";
                            regional1500Weapon1500 = "patch=1,EE,105AF76C,extended,05DC //RGA" + Environment.NewLine +
                                                     "patch=1,EE,105AF770,extended,03E8 //WPA";
                            special1500 = "patch=1,EE,105AF76E,extended,05DC //SPA";
                            toughness1500 = "patch=1,EE,105AF772,extended,05DC //TGH";
                            allEndurance1500 = "patch=1,EE,105AF722,extended,02EE //HDEx" + Environment.NewLine +
                                               "patch=1,EE,105AF728,extended,0177 //HDE Balance" + Environment.NewLine +
                                               "patch=1,EE,105AF724,extended,02EE //UBEx" + Environment.NewLine +
                                               "patch=1,EE,105AF72A,extended,0177 //UBE Balance" + Environment.NewLine +
                                               "patch=1,EE,105AF726,extended,02EE //LBEx" + Environment.NewLine +
                                               "patch=1,EE,105AF72C,extended,0177 //LBE Balance";
                            spaRecovery16 = "patch=1,EE,105AF7C0,extended,00000010 //SPA Regained";
                            redbullSpa = "patch=1,EE,205AF752,extended,4000 //Spa Down Red Bar Color" + Environment.NewLine +
                                         "patch=1,EE,205AF756,extended,3F00 //Spa Down Green Bar Color" + Environment.NewLine +
                                         "patch=1,EE,205AF75A,extended,3F00 //Spa Down Blue Bar Color" + Environment.NewLine +
                                         "patch=1,EE,205AF75E,extended,4000 //Spa Down Alpha Bar Color" + Environment.NewLine +
                                         "patch=1,EE,205AF760,extended,0000 //Spa Down" + Environment.NewLine +
                                         "patch=1,EE,D05AF766,extended,02300000 //If SPA is activated" + Environment.NewLine +
                                         "patch=1,EE,D05AF718,extended,01300001 //If HP is higher than 0" + Environment.NewLine +
                                         "patch=1,EE,30300001,extended,005AF718 //Lose Health by 1" + Environment.NewLine +
                                         "patch=1,EE,D05AF766,extended,03300000 //If SPA is activated" + Environment.NewLine +
                                         "patch=1,EE,D05AF742,extended,022003E8 //If SPA is lower than max [1000]" + Environment.NewLine +
                                         "patch=1,EE,D05AF718,extended,01300001 //If HP is higher than 0" + Environment.NewLine +
                                         "patch=1,EE,30200005,extended,005AF742 //Recover SPA by 5";
                            break;
                        case 3: //Enemy 1
                            strike1500 = "patch=1,EE,105B8EB8,extended,05DC //STK";
                            grapple1500 = "patch=1,EE,105B8EBA,extended,05DC //GRP";
                            regional1500Weapon1500 = "patch=1,EE,105B8EBC,extended,05DC //RGA" + Environment.NewLine +
                                                     "patch=1,EE,105B8EC0,extended,03E8 //WPA";
                            special1500 = "patch=1,EE,105B8EBE,extended,05DC //SPA";
                            toughness1500 = "patch=1,EE,105B8EC2,extended,05DC //TGH";
                            allEndurance1500 = "patch=1,EE,105B8E72,extended,02EE //HDEx" + Environment.NewLine +
                                               "patch=1,EE,105B8E78,extended,0177 //HDE Balance" + Environment.NewLine +
                                               "patch=1,EE,105B8E74,extended,02EE //UBEx" + Environment.NewLine +
                                               "patch=1,EE,105B8E7A,extended,0177 //UBE Balance" + Environment.NewLine +
                                               "patch=1,EE,105B8E76,extended,02EE //LBEx" + Environment.NewLine +
                                               "patch=1,EE,105B8E7C,extended,0177 //LBE Balance";
                            spaRecovery16 = "patch=1,EE,105B8F10,extended,00000010 //SPA Regained";
                            redbullSpa = "patch=1,EE,205B8EA2,extended,4000 //Spa Down Red Bar Color" + Environment.NewLine +
                                         "patch=1,EE,205B8EA6,extended,3F00 //Spa Down Green Bar Color" + Environment.NewLine +
                                         "patch=1,EE,205B8EAA,extended,3F00 //Spa Down Blue Bar Color" + Environment.NewLine +
                                         "patch=1,EE,205B8EAE,extended,4000 //Spa Down Alpha Bar Color" + Environment.NewLine +
                                         "patch=1,EE,205B8EB0,extended,0000 //Spa Down" + Environment.NewLine +
                                         "patch=1,EE,D05B8EB6,extended,02300000 //If SPA is activated" + Environment.NewLine +
                                         "patch=1,EE,D05B8E68,extended,01300001 //If HP is higher than 0" + Environment.NewLine +
                                         "patch=1,EE,30300001,extended,005B8E68 //Lose Health by 1" + Environment.NewLine +
                                         "patch=1,EE,D05B8EB6,extended,03300000 //If SPA is activated" + Environment.NewLine +
                                         "patch=1,EE,D05B8E92,extended,022003E8 //If SPA is lower than max [1000]" + Environment.NewLine +
                                         "patch=1,EE,D05B8E68,extended,01300001 //If HP is higher than 0" + Environment.NewLine +
                                         "patch=1,EE,30200005,extended,005B8E92 //Recover SPA by 5";
                            break;
                        case 4: //Enemy 2
                            strike1500 = "patch=1,EE,105C2608,extended,05DC //STK";
                            grapple1500 = "patch=1,EE,105C260A,extended,05DC //GRP";
                            regional1500Weapon1500 = "patch=1,EE,105C260C,extended,05DC //RGA" + Environment.NewLine +
                                                     "patch=1,EE,105C2610,extended,03E8 //WPA";
                            special1500 = "patch=1,EE,105C260E,extended,05DC //SPA";
                            toughness1500 = "patch=1,EE,105C2612,extended,05DC //TGH";
                            allEndurance1500 = "patch=1,EE,105C25C2,extended,02EE //HDEx" + Environment.NewLine +
                                               "patch=1,EE,105C25C8,extended,0177 //HDE Balance" + Environment.NewLine +
                                               "patch=1,EE,105C25C4,extended,02EE //UBEx" + Environment.NewLine +
                                               "patch=1,EE,105C25CA,extended,0177 //UBE Balance" + Environment.NewLine +
                                               "patch=1,EE,105C25C6,extended,02EE //LBEx" + Environment.NewLine +
                                               "patch=1,EE,105C25CC,extended,0177 //LBE Balance";
                            spaRecovery16 = "patch=1,EE,105C2660,extended,00000010 //SPA Regained";
                            redbullSpa = "patch=1,EE,205C25F2,extended,4000 //Spa Down Red Bar Color" + Environment.NewLine +
                                         "patch=1,EE,205C25F6,extended,3F00 //Spa Down Green Bar Color" + Environment.NewLine +
                                         "patch=1,EE,205C25FA,extended,3F00 //Spa Down Blue Bar Color" + Environment.NewLine +
                                         "patch=1,EE,205C25FE,extended,4000 //Spa Down Alpha Bar Color" + Environment.NewLine +
                                         "patch=1,EE,205C2600,extended,0000 //Spa Down" + Environment.NewLine +
                                         "patch=1,EE,D05C2606,extended,02300000 //If SPA is activated" + Environment.NewLine +
                                         "patch=1,EE,D05C25B8,extended,01300001 //If HP is higher than 0" + Environment.NewLine +
                                         "patch=1,EE,30300001,extended,005C25B8 //Lose Health by 1" + Environment.NewLine +
                                         "patch=1,EE,D05C2606,extended,03300000 //If SPA is activated" + Environment.NewLine +
                                         "patch=1,EE,D05C25E2,extended,022003E8 //If SPA is lower than max [1000]" + Environment.NewLine +
                                         "patch=1,EE,D05C25B8,extended,01300001 //If HP is higher than 0" + Environment.NewLine +
                                         "patch=1,EE,30200005,extended,005C25E2 //Recover SPA by 5";
                            break;
                    }

                    codesList.Add(spaRecovery16);
                    codesList.Add(redbullSpa);
                    if (playersToGet == 0)
                    {
                        codesList.Add(strike1500);
                        codesList.Add(grapple1500);
                        codesList.Add(regional1500Weapon1500);
                        codesList.Add(special1500);
                        codesList.Add(toughness1500);
                        codesList.Add(allEndurance1500);
                    }
                    randomIndex = random.Next(0, codesList.Count);
                    code = codesList[randomIndex];
                    break;
                case 2:
                    string ultraInstinct = "ultraInstinct";
                    string spaRecovery32 = "spaRecovery32";
                    string infiniteRedSpa = "infiniteRedSpa";
                    string strikeGrapple2000 = "strikeGrapple2000";
                    string toughness2000 = "toughness2000";
                    string spaDownWillMakeAllStats2000 = "spaDownWillMakeAllStats2000";

                    switch (playerNumber)
                    {
                        case 1: //Player 1
                            ultraInstinct = "patch=1,EE,105A65EA,extended,0000 //Auto-Parry";
                            spaRecovery32 = "patch=1,EE,105A6070,extended,0020 //SPA Regained";
                            infiniteRedSpa = "patch=1,EE,205A6002,extended,3F80 //Spa Down Red Bar Color" + Environment.NewLine +
                                             "patch=1,EE,205A6006,extended,3F20 //Spa Down Green Bar Color" + Environment.NewLine +
                                             "patch=1,EE,205A600A,extended,3F20 //Spa Down Blue Bar Color" + Environment.NewLine +
                                             "patch=1,EE,205A600E,extended,3F20 //Spa Down Alpha Bar Color" + Environment.NewLine +
                                             "patch=1,EE,205A6010,extended,0002 //Spa Down" + Environment.NewLine +
                                             "patch=1,EE,205A6014,extended,44DF8000 //Infinite Spa Down";
                            strikeGrapple2000 = "patch=1,EE,105A6018,extended,07D0 //STK" + Environment.NewLine +
                                                "patch=1,EE,105A601A,extended,07D0 //GRP";
                            toughness2000 = "patch=1,EE,105A6022,extended,07D0 //TGH";
                            spaDownWillMakeAllStats2000 =
                                                          "patch=1,EE,105A6018,extended,0320 //STK" + Environment.NewLine +
                                                          "patch=1,EE,105A601A,extended,0320 //GRP" + Environment.NewLine +
                                                          "patch=1,EE,105A601C,extended,0320 //RGA" + Environment.NewLine +
                                                          "patch=1,EE,105A601E,extended,0320 //SPA" + Environment.NewLine +
                                                          "patch=1,EE,105A6020,extended,0320 //WPA" + Environment.NewLine +
                                                          "patch=1,EE,105A6022,extended,0320 //TGH" + Environment.NewLine +
                                                          "patch=1,EE,105A5FD2,extended,0190 //HDEx" + Environment.NewLine +
                                                          "patch=1,EE,105A5FD8,extended,00C8 //HDE Balance" + Environment.NewLine +
                                                          "patch=1,EE,105A5FD4,extended,0190 //UBEx" + Environment.NewLine +
                                                          "patch=1,EE,105A5FDA,extended,00C8 //UBE Balance" + Environment.NewLine +
                                                          "patch=1,EE,105A5FD6,extended,0190 //LBEx" + Environment.NewLine +
                                                          "patch=1,EE,105A5FDC,extended,00C8 //LBE Balance" + Environment.NewLine +
                                                          "patch=1,EE,205A6002,extended,4000 //Spa Down Red Bar Color" + Environment.NewLine +
                                                          "patch=1,EE,205A6006,extended,4000 //Spa Down Green Bar Color" + Environment.NewLine +
                                                          "patch=1,EE,205A600A,extended,4000 //Spa Down Blue Bar Color" + Environment.NewLine +
                                                          "patch=1,EE,205A600E,extended,4000 //Spa Down Alpha Bar Color" + Environment.NewLine +
                                                          "patch=1,EE,205A6010,extended,0000 //Spa Down" + Environment.NewLine +
                                                          "patch=1,EE,D05A6016,extended,0C300000 //If SPA (SUPER) is activated" + Environment.NewLine +
                                                          "patch=1,EE,105A6018,extended,07D0 //STK" + Environment.NewLine +
                                                          "patch=1,EE,105A601A,extended,07D0 //GRP" + Environment.NewLine +
                                                          "patch=1,EE,105A601C,extended,07D0 //RGA" + Environment.NewLine +
                                                          "patch=1,EE,105A601E,extended,07D0 //SPA" + Environment.NewLine +
                                                          "patch=1,EE,105A6020,extended,07D0 //WPA" + Environment.NewLine +
                                                          "patch=1,EE,105A6022,extended,07D0 //TGH" + Environment.NewLine +
                                                          "patch=1,EE,105A5FD2,extended,03E8 //HDEx" + Environment.NewLine +
                                                          "patch=1,EE,105A5FD8,extended,01F4 //HDE Balance" + Environment.NewLine +
                                                          "patch=1,EE,105A5FD4,extended,03E8 //UBEx" + Environment.NewLine +
                                                          "patch=1,EE,105A5FDA,extended,01F4 //UBE Balance" + Environment.NewLine +
                                                          "patch=1,EE,105A5FD6,extended,03E8 //LBEx" + Environment.NewLine +
                                                          "patch=1,EE,105A5FDC,extended,01F4 //LBE Balance";
                            break;
                        case 2: //Player 2
                            ultraInstinct = "patch=1,EE,105AFD3A,extended,0000 //Auto-Parry";
                            spaRecovery32 = "patch=1,EE,105AF7C0,extended,0020 //SPA Regained";
                            infiniteRedSpa = "patch=1,EE,205AF752,extended,3F80 //Spa Down Red Bar Color" + Environment.NewLine +
                                             "patch=1,EE,205AF756,extended,3F20 //Spa Down Green Bar Color" + Environment.NewLine +
                                             "patch=1,EE,205AF75A,extended,3F20 //Spa Down Blue Bar Color" + Environment.NewLine +
                                             "patch=1,EE,205AF75E,extended,3F20 //Spa Down Alpha Bar Color" + Environment.NewLine +
                                             "patch=1,EE,205AF760,extended,0002 //Spa Down" + Environment.NewLine +
                                             "patch=1,EE,205AF764,extended,44DF8000 //Infinite Spa Down";
                            strikeGrapple2000 = "patch=1,EE,105AF768,extended,07D0 //STK" + Environment.NewLine +
                                                "patch=1,EE,105AF76A,extended,07D0 //GRP";
                            toughness2000 = "patch=1,EE,105AF772,extended,07D0 //TGH";
                            spaDownWillMakeAllStats2000 =
                                                          "patch=1,EE,105AF768,extended,0320 //STK" + Environment.NewLine +
                                                          "patch=1,EE,105AF76A,extended,0320 //GRP" + Environment.NewLine +
                                                          "patch=1,EE,105AF76C,extended,0320 //RGA" + Environment.NewLine +
                                                          "patch=1,EE,105AF76E,extended,0320 //SPA" + Environment.NewLine +
                                                          "patch=1,EE,105AF770,extended,0320 //WPA" + Environment.NewLine +
                                                          "patch=1,EE,105AF772,extended,0320 //TGH" + Environment.NewLine +
                                                          "patch=1,EE,105AF722,extended,0190 //HDEx" + Environment.NewLine +
                                                          "patch=1,EE,105AF728,extended,00C8 //HDE Balance" + Environment.NewLine +
                                                          "patch=1,EE,105AF724,extended,0190 //UBEx" + Environment.NewLine +
                                                          "patch=1,EE,105AF72A,extended,00C8 //UBE Balance" + Environment.NewLine +
                                                          "patch=1,EE,105AF726,extended,0190 //LBEx" + Environment.NewLine +
                                                          "patch=1,EE,105AF72C,extended,00C8 //LBE Balance" + Environment.NewLine +
                                                          "patch=1,EE,205AF752,extended,4000 //Spa Down Red Bar Color" + Environment.NewLine +
                                                          "patch=1,EE,205AF756,extended,4000 //Spa Down Green Bar Color" + Environment.NewLine +
                                                          "patch=1,EE,205AF75A,extended,4000 //Spa Down Blue Bar Color" + Environment.NewLine +
                                                          "patch=1,EE,205AF75E,extended,4000 //Spa Down Alpha Bar Color" + Environment.NewLine +
                                                          "patch=1,EE,205AF760,extended,0000 //Spa Down" + Environment.NewLine +
                                                          "patch=1,EE,D05AF766,extended,0C300000 //If SPA (SUPER) is activated" + Environment.NewLine +
                                                          "patch=1,EE,105AF768,extended,07D0 //STK" + Environment.NewLine +
                                                          "patch=1,EE,105AF76A,extended,07D0 //GRP" + Environment.NewLine +
                                                          "patch=1,EE,105AF76C,extended,07D0 //RGA" + Environment.NewLine +
                                                          "patch=1,EE,105AF76E,extended,07D0 //SPA" + Environment.NewLine +
                                                          "patch=1,EE,105AF770,extended,07D0 //WPA" + Environment.NewLine +
                                                          "patch=1,EE,105AF772,extended,07D0 //TGH" + Environment.NewLine +
                                                          "patch=1,EE,105AF722,extended,03E8 //HDEx" + Environment.NewLine +
                                                          "patch=1,EE,105AF728,extended,01F4 //HDE Balance" + Environment.NewLine +
                                                          "patch=1,EE,105AF724,extended,03E8 //UBEx" + Environment.NewLine +
                                                          "patch=1,EE,105AF72A,extended,01F4 //UBE Balance" + Environment.NewLine +
                                                          "patch=1,EE,105AF726,extended,03E8 //LBEx" + Environment.NewLine +
                                                          "patch=1,EE,105AF72C,extended,01F4 //LBE Balance";
                            break;
                        case 3: //Enemy 1
                            ultraInstinct = "patch=1,EE,105B948A,extended,0000 //Auto-Parry";
                            spaRecovery32 = "patch=1,EE,105B8F10,extended,0020 //SPA Regained";
                            infiniteRedSpa = "patch=1,EE,205B8EA2,extended,3F80 //Spa Down Red Bar Color" + Environment.NewLine +
                                             "patch=1,EE,205B8EA6,extended,3F20 //Spa Down Green Bar Color" + Environment.NewLine +
                                             "patch=1,EE,205B8EAA,extended,3F20 //Spa Down Blue Bar Color" + Environment.NewLine +
                                             "patch=1,EE,205B8EAE,extended,3F20 //Spa Down Alpha Bar Color" + Environment.NewLine +
                                             "patch=1,EE,205B8EB0,extended,0002 //Spa Down" + Environment.NewLine +
                                             "patch=1,EE,205B8EB4,extended,44DF8000 //Infinite Spa Down";
                            strikeGrapple2000 = "patch=1,EE,105B8EB8,extended,07D0 //STK" + Environment.NewLine +
                                                "patch=1,EE,105B8EBA,extended,07D0 //GRP";
                            toughness2000 = "patch=1,EE,105B8EC2,extended,07D0 //TGH";
                            spaDownWillMakeAllStats2000 =
                                                          "patch=1,EE,105B8EB8,extended,0320 //STK" + Environment.NewLine +
                                                          "patch=1,EE,105B8EBA,extended,0320 //GRP" + Environment.NewLine +
                                                          "patch=1,EE,105B8EBC,extended,0320 //RGA" + Environment.NewLine +
                                                          "patch=1,EE,105B8EBE,extended,0320 //SPA" + Environment.NewLine +
                                                          "patch=1,EE,105B8EC0,extended,0320 //WPA" + Environment.NewLine +
                                                          "patch=1,EE,105B8EC2,extended,0320 //TGH" + Environment.NewLine +
                                                          "patch=1,EE,105B8E72,extended,0190 //HDEx" + Environment.NewLine +
                                                          "patch=1,EE,105B8E78,extended,00C8 //HDE Balance" + Environment.NewLine +
                                                          "patch=1,EE,105B8E74,extended,0190 //UBEx" + Environment.NewLine +
                                                          "patch=1,EE,105B8E7A,extended,00C8 //UBE Balance" + Environment.NewLine +
                                                          "patch=1,EE,105B8E76,extended,0190 //LBEx" + Environment.NewLine +
                                                          "patch=1,EE,105B8E7C,extended,00C8 //LBE Balance" + Environment.NewLine +
                                                          "patch=1,EE,205B8EA2,extended,4000 //Spa Down Red Bar Color" + Environment.NewLine +
                                                          "patch=1,EE,205B8EA6,extended,4000 //Spa Down Green Bar Color" + Environment.NewLine +
                                                          "patch=1,EE,205B8EAA,extended,4000 //Spa Down Blue Bar Color" + Environment.NewLine +
                                                          "patch=1,EE,205B8EAE,extended,4000 //Spa Down Alpha Bar Color" + Environment.NewLine +
                                                          "patch=1,EE,205B8EB0,extended,0000 //Spa Down" + Environment.NewLine +
                                                          "patch=1,EE,D05B8EB6,extended,0C300000 //If SPA (SUPER) is activated" + Environment.NewLine +
                                                          "patch=1,EE,105B8EB8,extended,07D0 //STK" + Environment.NewLine +
                                                          "patch=1,EE,105B8EBA,extended,07D0 //GRP" + Environment.NewLine +
                                                          "patch=1,EE,105B8EBC,extended,07D0 //RGA" + Environment.NewLine +
                                                          "patch=1,EE,105B8EBE,extended,07D0 //SPA" + Environment.NewLine +
                                                          "patch=1,EE,105B8EC0,extended,07D0 //WPA" + Environment.NewLine +
                                                          "patch=1,EE,105B8EC2,extended,07D0 //TGH" + Environment.NewLine +
                                                          "patch=1,EE,105B8E72,extended,03E8 //HDEx" + Environment.NewLine +
                                                          "patch=1,EE,105B8E78,extended,01F4 //HDE Balance" + Environment.NewLine +
                                                          "patch=1,EE,105B8E74,extended,03E8 //UBEx" + Environment.NewLine +
                                                          "patch=1,EE,105B8E7A,extended,01F4 //UBE Balance" + Environment.NewLine +
                                                          "patch=1,EE,105B8E76,extended,03E8 //LBEx" + Environment.NewLine +
                                                          "patch=1,EE,105B8E7C,extended,01F4 //LBE Balance";
                            break;
                        case 4: //Enemy 2
                            ultraInstinct = "patch=1,EE,105C2BDA,extended,0000 //Auto-Parry";
                            spaRecovery32 = "patch=1,EE,105C2660,extended,0020 //SPA Regained";
                            infiniteRedSpa = "patch=1,EE,205C25F2,extended,3F80 //Spa Down Red Bar Color" + Environment.NewLine +
                                             "patch=1,EE,205C25F6,extended,3F20 //Spa Down Green Bar Color" + Environment.NewLine +
                                             "patch=1,EE,205C25FA,extended,3F20 //Spa Down Blue Bar Color" + Environment.NewLine +
                                             "patch=1,EE,205C25FE,extended,3F20 //Spa Down Alpha Bar Color" + Environment.NewLine +
                                             "patch=1,EE,205C2600,extended,0002 //Spa Down" + Environment.NewLine +
                                             "patch=1,EE,205C2604,extended,44DF8000 //Infinite Spa Down";
                            strikeGrapple2000 = "patch=1,EE,105C2608,extended,07D0 //STK" + Environment.NewLine +
                                                "patch=1,EE,105C260A,extended,07D0 //GRP";
                            toughness2000 = "patch=1,EE,105C2612,extended,07D0 //TGH";
                            spaDownWillMakeAllStats2000 =
                                                          "patch=1,EE,105C2608,extended,0320 //STK" + Environment.NewLine +
                                                          "patch=1,EE,105C260A,extended,0320 //GRP" + Environment.NewLine +
                                                          "patch=1,EE,105C260C,extended,0320 //RGA" + Environment.NewLine +
                                                          "patch=1,EE,105C260E,extended,0320 //SPA" + Environment.NewLine +
                                                          "patch=1,EE,105C2610,extended,0320 //WPA" + Environment.NewLine +
                                                          "patch=1,EE,105C2612,extended,0320 //TGH" + Environment.NewLine +
                                                          "patch=1,EE,105C25C2,extended,0190 //HDEx" + Environment.NewLine +
                                                          "patch=1,EE,105C25C8,extended,00C8 //HDE Balance" + Environment.NewLine +
                                                          "patch=1,EE,105C25C4,extended,0190 //UBEx" + Environment.NewLine +
                                                          "patch=1,EE,105C25CA,extended,00C8 //UBE Balance" + Environment.NewLine +
                                                          "patch=1,EE,105C25C6,extended,0190 //LBEx" + Environment.NewLine +
                                                          "patch=1,EE,105C25CC,extended,00C8 //LBE Balance" + Environment.NewLine +
                                                          "patch=1,EE,205C25F2,extended,4000 //Spa Down Red Bar Color" + Environment.NewLine +
                                                          "patch=1,EE,205C25F6,extended,4000 //Spa Down Green Bar Color" + Environment.NewLine +
                                                          "patch=1,EE,205C25FA,extended,4000 //Spa Down Blue Bar Color" + Environment.NewLine +
                                                          "patch=1,EE,205C25FE,extended,4000 //Spa Down Alpha Bar Color" + Environment.NewLine +
                                                          "patch=1,EE,205C2600,extended,0000 //Spa Down" + Environment.NewLine +
                                                          "patch=1,EE,D05C2606,extended,0C300000 //If SPA (SUPER) is activated" + Environment.NewLine +
                                                          "patch=1,EE,105C2608,extended,07D0 //STK" + Environment.NewLine +
                                                          "patch=1,EE,105C260A,extended,07D0 //GRP" + Environment.NewLine +
                                                          "patch=1,EE,105C260C,extended,07D0 //RGA" + Environment.NewLine +
                                                          "patch=1,EE,105C260E,extended,07D0 //SPA" + Environment.NewLine +
                                                          "patch=1,EE,105C2610,extended,07D0 //WPA" + Environment.NewLine +
                                                          "patch=1,EE,105C2612,extended,07D0 //TGH" + Environment.NewLine +
                                                          "patch=1,EE,105C25C2,extended,03E8 //HDEx" + Environment.NewLine +
                                                          "patch=1,EE,105C25C8,extended,01F4 //HDE Balance" + Environment.NewLine +
                                                          "patch=1,EE,105C25C4,extended,03E8 //UBEx" + Environment.NewLine +
                                                          "patch=1,EE,105C25CA,extended,01F4 //UBE Balance" + Environment.NewLine +
                                                          "patch=1,EE,105C25C6,extended,03E8 //LBEx" + Environment.NewLine +
                                                          "patch=1,EE,105C25CC,extended,01F4 //LBE Balance";
                            break;
                    }

                    codesList.Add(ultraInstinct);
                    codesList.Add(spaRecovery32);
                    codesList.Add(infiniteRedSpa);
                    if (playersToGet == 0)
                    {
                        codesList.Add(spaDownWillMakeAllStats2000);
                        codesList.Add(strikeGrapple2000);
                        codesList.Add(toughness2000);
                    }
                    randomIndex = random.Next(0, codesList.Count);
                    code = codesList[randomIndex];
                    break;
                case 3:
                    string ultraInstinct2 = "ultraInstinct2";
                    string infiniteYellowSpa = "infiniteYellowSpa";
                    string regenerationSpa = "regenerationSpa";
                    string spaRecovery48 = "spaRecovery48";
                    string toughness2500 = "toughness2500";

                    switch (playerNumber)
                    {
                        case 1: //Player 1
                            ultraInstinct2 = "patch=1,EE,105A65C8,extended,0001 //Auta-Grab";
                            infiniteYellowSpa = "patch=1,EE,205A6002,extended,3F80 //Spa Down Red Bar Color" + Environment.NewLine +
                                                "patch=1,EE,205A6006,extended,3F80 //Spa Down Green Bar Color" + Environment.NewLine +
                                                "patch=1,EE,205A600A,extended,3F20 //Spa Down Blue Bar Color" + Environment.NewLine +
                                                "patch=1,EE,205A600E,extended,3F20 //Spa Down Alpha Bar Color" + Environment.NewLine +
                                                "patch=1,EE,205A6010,extended,0001 //Spa Down" + Environment.NewLine +
                                                "patch=1,EE,205A6014,extended,44DF8000 //Infinite Spa Down";
                            regenerationSpa = "patch=1,EE,205A6002,extended,3F20 //Spa Down Red Bar Color" + Environment.NewLine +
                                              "patch=1,EE,205A6006,extended,3FB0 //Spa Down Green Bar Color" + Environment.NewLine +
                                              "patch=1,EE,205A600A,extended,3FB0 //Spa Down Blue Bar Color" + Environment.NewLine +
                                              "patch=1,EE,205A600E,extended,3F20 //Spa Down Alpha Bar Color" + Environment.NewLine +
                                              "patch=1,EE,205A6010,extended,0000 //Spa Down" + Environment.NewLine +
                                              "patch=1,EE,D05A6016,extended,02300000 //If SPA is activated" + Environment.NewLine +
                                              "patch=1,EE,D05A5FC8,extended,012005DC //If HP is lower than max [1500]" + Environment.NewLine +
                                              "patch=1,EE,30200001,extended,005A5FC8 //Recover Health by 1";
                            spaRecovery48 = "patch=1,EE,105A6070,extended,0030 //SPA Regained";
                            toughness2500 = "patch=1,EE,105A6022,extended,09C4 //TGH";
                            break;
                        case 2: //Player 2
                            ultraInstinct2 = "patch=1,EE,105AFD18,extended,0001 //Auta-Grab";
                            infiniteYellowSpa = "patch=1,EE,205AF752,extended,3F80 //Spa Down Red Bar Color" + Environment.NewLine +
                                                "patch=1,EE,205AF756,extended,3F80 //Spa Down Green Bar Color" + Environment.NewLine +
                                                "patch=1,EE,205AF75A,extended,3F20 //Spa Down Blue Bar Color" + Environment.NewLine +
                                                "patch=1,EE,205AF75E,extended,3F20 //Spa Down Alpha Bar Color" + Environment.NewLine +
                                                "patch=1,EE,205AF760,extended,0001 //Spa Down" + Environment.NewLine +
                                                "patch=1,EE,205AF764,extended,44DF8000 //Infinite Spa Down";
                            regenerationSpa = "patch=1,EE,205AF752,extended,3F20 //Spa Down Red Bar Color" + Environment.NewLine +
                                              "patch=1,EE,205AF756,extended,3FB0 //Spa Down Green Bar Color" + Environment.NewLine +
                                              "patch=1,EE,205AF75A,extended,3FB0 //Spa Down Blue Bar Color" + Environment.NewLine +
                                              "patch=1,EE,205AF75E,extended,3F20 //Spa Down Alpha Bar Color" + Environment.NewLine +
                                              "patch=1,EE,205AF760,extended,0000 //Spa Down" + Environment.NewLine +
                                              "patch=1,EE,D05A6016,extended,02300000 //If SPA is activated" + Environment.NewLine +
                                              "patch=1,EE,D05AF718,extended,012005DC //If HP is lower than max [1500]" + Environment.NewLine +
                                              "patch=1,EE,30200001,extended,005AF718 //Recover Health by 1";
                            spaRecovery48 = "patch=1,EE,105AF7C0,extended,0030 //SPA Regained";
                            toughness2500 = "patch=1,EE,105AF772,extended,09C4 //TGH";
                            break;
                        case 3: //Enemy 1
                            ultraInstinct2 = "patch=1,EE,105B9468,extended,0001 //Auta-Grab";
                            infiniteYellowSpa = "patch=1,EE,205B8EA2,extended,3F80 //Spa Down Red Bar Color" + Environment.NewLine +
                                                "patch=1,EE,205B8EA6,extended,3F80 //Spa Down Green Bar Color" + Environment.NewLine +
                                                "patch=1,EE,205B8EAA,extended,3F20 //Spa Down Blue Bar Color" + Environment.NewLine +
                                                "patch=1,EE,205B8EAE,extended,3F20 //Spa Down Alpha Bar Color" + Environment.NewLine +
                                                "patch=1,EE,205B8EB0,extended,0001 //Spa Down" + Environment.NewLine +
                                                "patch=1,EE,205B8EB4,extended,44DF8000 //Infinite Spa Down";
                            regenerationSpa = "patch=1,EE,205B8EA2,extended,3F20 //Spa Down Red Bar Color" + Environment.NewLine +
                                              "patch=1,EE,205B8EA6,extended,3FB0 //Spa Down Green Bar Color" + Environment.NewLine +
                                              "patch=1,EE,205B8EAA,extended,3FB0 //Spa Down Blue Bar Color" + Environment.NewLine +
                                              "patch=1,EE,205B8EAE,extended,3F20 //Spa Down Alpha Bar Color" + Environment.NewLine +
                                              "patch=1,EE,205B8EB0,extended,0000 //Spa Down" + Environment.NewLine +
                                              "patch=1,EE,D05B8EB6,extended,02300000 //If SPA is activated" + Environment.NewLine +
                                              "patch=1,EE,D05B8E68,extended,012005DC //If HP is lower than max [1500]" + Environment.NewLine +
                                              "patch=1,EE,30200001,extended,005B8E68 //Recover Health by 1";
                            spaRecovery48 = "patch=1,EE,105B8F10,extended,0030 //SPA Regained";
                            toughness2500 = "patch=1,EE,105B8EC2,extended,09C4 //TGH";
                            break;
                        case 4: //Enemy 2
                            ultraInstinct2 = "patch=1,EE,105C2BB8,extended,0001 //Auta-Grab";
                            infiniteYellowSpa = "patch=1,EE,205C25F2,extended,3F80 //Spa Down Red Bar Color" + Environment.NewLine +
                                                "patch=1,EE,205C25F6,extended,3F80 //Spa Down Green Bar Color" + Environment.NewLine +
                                                "patch=1,EE,205C25FA,extended,3F20 //Spa Down Blue Bar Color" + Environment.NewLine +
                                                "patch=1,EE,205C25FE,extended,3F20 //Spa Down Alpha Bar Color" + Environment.NewLine +
                                                "patch=1,EE,205C2600,extended,0001 //Spa Down" + Environment.NewLine +
                                                "patch=1,EE,205C2604,extended,44DF8000 //Infinite Spa Down";
                            regenerationSpa = "patch=1,EE,205C25F2,extended,3F20 //Spa Down Red Bar Color" + Environment.NewLine +
                                              "patch=1,EE,205C25F6,extended,3FB0 //Spa Down Green Bar Color" + Environment.NewLine +
                                              "patch=1,EE,205C25FA,extended,3FB0 //Spa Down Blue Bar Color" + Environment.NewLine +
                                              "patch=1,EE,205C25FE,extended,3F20 //Spa Down Alpha Bar Color" + Environment.NewLine +
                                              "patch=1,EE,205C2600,extended,0000 //Spa Down" + Environment.NewLine +
                                              "patch=1,EE,D05C2606,extended,02300000 //If SPA is activated" + Environment.NewLine +
                                              "patch=1,EE,D05C25B8,extended,012005DC //If HP is lower than max [1500]" + Environment.NewLine +
                                              "patch=1,EE,30200001,extended,005C25B8 //Recover Health by 1";
                            spaRecovery48 = "patch=1,EE,105C2660,extended,0030 //SPA Regained";
                            toughness2500 = "patch=1,EE,105C2612,extended,09C4 //TGH";
                            break;
                    }

                    codesList.Add(ultraInstinct2);
                    codesList.Add(infiniteYellowSpa);
                    codesList.Add(regenerationSpa);
                    codesList.Add(spaRecovery48);
                    if (playersToGet == 0)
                    {
                        codesList.Add(toughness2500);
                    }
                    randomIndex = random.Next(0, codesList.Count);
                    code = codesList[randomIndex];
                    break;
                case 4:
                    string infiniteBlueSpa = "infiniteBlueSpa";
                    string strike5000 = "strike5000";
                    string masterSpa = "masterSpa";

                    switch (playerNumber)
                    {
                        case 1: //Player 1
                            infiniteBlueSpa = "patch=1,EE,205A6002,extended,3F20 //Spa Down Red Bar Color" + Environment.NewLine +
                                              "patch=1,EE,205A6006,extended,3F20 //Spa Down Green Bar Color" + Environment.NewLine +
                                              "patch=1,EE,205A600A,extended,3F80 //Spa Down Blue Bar Color" + Environment.NewLine +
                                              "patch=1,EE,205A600E,extended,3F80 //Spa Down Alpha Bar Color" + Environment.NewLine +
                                              "patch=1,EE,205A6010,extended,0003 //Spa Down" + Environment.NewLine +
                                              "patch=1,EE,205A6014,extended,44DF8000 //Infinite Spa Down";
                            strike5000 = "patch=1,EE,105A6018,extended,1388 //STK";
                            masterSpa =  "patch=1,EE,205A6002,extended,3FA0 //Spa Down Red Bar Color" + Environment.NewLine +
                                         "patch=1,EE,205A6006,extended,3F40 //Spa Down Green Bar Color" + Environment.NewLine +
                                         "patch=1,EE,205A600A,extended,3F20 //Spa Down Blue Bar Color" + Environment.NewLine +
                                         "patch=1,EE,205A600E,extended,3FB0 //Spa Down Alpha Bar Color" + Environment.NewLine +
                                         "patch=1,EE,205A6010,extended,0000 //Spa Down" + Environment.NewLine +
                                         "patch=1,EE,D05A6016,extended,02300000 //If SPA is activated" + Environment.NewLine +
                                         "patch=1,EE,D05A5FF2,extended,012003E8 //If SPA is lower than max [1000]" + Environment.NewLine +
                                         "patch=1,EE,30200002,extended,005A5FF2 //Recover SPA by 2";
                            break;
                        case 2: //Player 2
                            infiniteBlueSpa = "patch=1,EE,205AF752,extended,3F20 //Spa Down Red Bar Color" + Environment.NewLine +
                                              "patch=1,EE,205AF756,extended,3F20 //Spa Down Green Bar Color" + Environment.NewLine +
                                              "patch=1,EE,205AF75A,extended,3F80 //Spa Down Blue Bar Color" + Environment.NewLine +
                                              "patch=1,EE,205AF75E,extended,3F80 //Spa Down Alpha Bar Color" + Environment.NewLine +
                                              "patch=1,EE,205AF760,extended,0003 //Spa Down" + Environment.NewLine +
                                              "patch=1,EE,205AF764,extended,44DF8000 //Infinite Spa Down";
                            strike5000 = "patch=1,EE,105AF768,extended,1388 //STK";
                            masterSpa =  "patch=1,EE,205AF752,extended,3FA0 //Spa Down Red Bar Color" + Environment.NewLine +
                                         "patch=1,EE,205AF756,extended,3F40 //Spa Down Green Bar Color" + Environment.NewLine +
                                         "patch=1,EE,205AF75A,extended,3F20 //Spa Down Blue Bar Color" + Environment.NewLine +
                                         "patch=1,EE,205AF75E,extended,3FB0 //Spa Down Alpha Bar Color" + Environment.NewLine +
                                         "patch=1,EE,205AF760,extended,0000 //Spa Down" + Environment.NewLine +
                                         "patch=1,EE,D05AF766,extended,02300000 //If SPA is activated" + Environment.NewLine +
                                         "patch=1,EE,D05AF742,extended,012003E8 //If SPA is lower than max [1000]" + Environment.NewLine +
                                         "patch=1,EE,30200002,extended,005AF742 //Recover SPA by 2";
                            break;
                        case 3: //Enemy 1
                            infiniteBlueSpa = "patch=1,EE,205B8EA2,extended,3F20 //Spa Down Red Bar Color" + Environment.NewLine +
                                              "patch=1,EE,205B8EA6,extended,3F20 //Spa Down Green Bar Color" + Environment.NewLine +
                                              "patch=1,EE,205B8EAA,extended,3F80 //Spa Down Blue Bar Color" + Environment.NewLine +
                                              "patch=1,EE,205B8EAE,extended,3F80 //Spa Down Alpha Bar Color" + Environment.NewLine +
                                              "patch=1,EE,205B8EB0,extended,0003 //Spa Down" + Environment.NewLine +
                                              "patch=1,EE,205B8EB4,extended,44DF8000 //Infinite Spa Down";
                            strike5000 = "patch=1,EE,105B8EB8,extended,1388 //STK";
                            masterSpa =  "patch=1,EE,205B8EA2,extended,3FA0 //Spa Down Red Bar Color" + Environment.NewLine +
                                         "patch=1,EE,205B8EA6,extended,3F40 //Spa Down Green Bar Color" + Environment.NewLine +
                                         "patch=1,EE,205B8EAA,extended,3F20 //Spa Down Blue Bar Color" + Environment.NewLine +
                                         "patch=1,EE,205B8EAE,extended,3FB0 //Spa Down Alpha Bar Color" + Environment.NewLine +
                                         "patch=1,EE,205B8EB0,extended,0000 //Spa Down" + Environment.NewLine +
                                         "patch=1,EE,D05B8EB6,extended,02300000 //If SPA is activated" + Environment.NewLine +
                                         "patch=1,EE,D05B8E92,extended,012003E8 //If SPA is lower than max [1000]" + Environment.NewLine +
                                         "patch=1,EE,30200002,extended,005B8E92 //Recover SPA by 2";
                            break;
                        case 4: //Enemy 2
                            infiniteBlueSpa = "patch=1,EE,205C25F2,extended,3F20 //Spa Down Red Bar Color" + Environment.NewLine +
                                              "patch=1,EE,205C25F6,extended,3F20 //Spa Down Green Bar Color" + Environment.NewLine +
                                              "patch=1,EE,205C25FA,extended,3F80 //Spa Down Blue Bar Color" + Environment.NewLine +
                                              "patch=1,EE,205C25FE,extended,3F80 //Spa Down Alpha Bar Color" + Environment.NewLine +
                                              "patch=1,EE,205C2600,extended,0003 //Spa Down" + Environment.NewLine +
                                              "patch=1,EE,205C2604,extended,44DF8000 //Infinite Spa Down";
                            strike5000 = "patch=1,EE,105C2608,extended,1388 //STK";
                            masterSpa =  "patch=1,EE,205C25F2,extended,3FA0 //Spa Down Red Bar Color" + Environment.NewLine +
                                         "patch=1,EE,205C25F6,extended,3F40 //Spa Down Green Bar Color" + Environment.NewLine +
                                         "patch=1,EE,205C25FA,extended,3F20 //Spa Down Blue Bar Color" + Environment.NewLine +
                                         "patch=1,EE,205C25FE,extended,3FB0 //Spa Down Alpha Bar Color" + Environment.NewLine +
                                         "patch=1,EE,205C2600,extended,0000 //Spa Down" + Environment.NewLine +
                                         "patch=1,EE,D05C2606,extended,02300000 //If SPA is activated" + Environment.NewLine +
                                         "patch=1,EE,D05C25E2,extended,012003E8 //If SPA is lower than max [1000]" + Environment.NewLine +
                                         "patch=1,EE,30200002,extended,005C25E2 //Recover SPA by 2";
                            break;
                    }

                    codesList.Add(infiniteBlueSpa);
                    codesList.Add(masterSpa);
                    if (playersToGet == 0)
                    {
                        codesList.Add(strike5000);
                    }
                    randomIndex = random.Next(0, codesList.Count);
                    code = codesList[randomIndex];
                    break;
            }



            return code;
        }

        internal string StatsReadAndWriteInMemory(string code, int teamMultiplier, int j)
        {
            if (playersToGet == 2)
            {
                //for P1
                code += Environment.NewLine +
                        "patch=1,EE,505A6018,extended,00000002 //copy STK" + Environment.NewLine +
                        "patch=1,EE,01DA8A98,extended,0030 //paste to memory address" + Environment.NewLine +
                        "patch=1,EE,505A601A,extended,00000002 //copy GRP" + Environment.NewLine +
                        "patch=1,EE,01DA8A9C,extended,0030 //paste to memory address" + Environment.NewLine +
                        "patch=1,EE,505A601C,extended,00000002 //copy RGA" + Environment.NewLine +
                        "patch=1,EE,01DA8AA0,extended,0030 //paste to memory address" + Environment.NewLine +
                        "patch=1,EE,505A601E,extended,00000002 //copy SPA" + Environment.NewLine +
                        "patch=1,EE,01DA8AA4,extended,0030 //paste to memory address" + Environment.NewLine +
                        "patch=1,EE,505A6020,extended,00000002 //copy WPA" + Environment.NewLine +
                        "patch=1,EE,01DA8AA8,extended,0030 //paste to memory address" + Environment.NewLine +
                        "patch=1,EE,505A6022,extended,00000002 //copy TGH" + Environment.NewLine +
                        "patch=1,EE,01DA8AAC,extended,0030 //paste to memory address" + Environment.NewLine +
                        "patch=1,EE,505A5FD2,extended,00000002 //copy HDEx" + Environment.NewLine +
                        "patch=1,EE,01DA8AB0,extended,0030 //paste to memory address" + Environment.NewLine +
                        "patch=1,EE,505A5FD8,extended,00000002 //copy HDE Balance" + Environment.NewLine +
                        "patch=1,EE,01DA8AB4,extended,0030 //paste to memory address" + Environment.NewLine +
                        "patch=1,EE,505A5FD4,extended,00000002 //copy UBEx" + Environment.NewLine +
                        "patch=1,EE,01DA8AB8,extended,0030 //paste to memory address" + Environment.NewLine +
                        "patch=1,EE,505A5FDA,extended,00000002 //copy UBE Balance" + Environment.NewLine +
                        "patch=1,EE,01DA8ABC,extended,0030 //paste to memory address" + Environment.NewLine +
                        "patch=1,EE,505A5FD6,extended,00000002 //copy LBEx" + Environment.NewLine +
                        "patch=1,EE,01DA8AC0,extended,0030 //paste to memory address" + Environment.NewLine +
                        "patch=1,EE,505A5FDC,extended,00000002 //copy LBE Balance" + Environment.NewLine +
                        "patch=1,EE,01DA8AC4,extended,0030 //paste to memory address";

                if (teamMultiplier == 1)
                {
                    playersToGet = 0;
                }
                else
                {

                    playersToGet--;
                }
            }
            else if (playersToGet == 1)
            {
                if (onlyP1)
                {
                    //for P1
                    code += Environment.NewLine +
                            "patch=1,EE,505A6018,extended,00000002 //copy STK" + Environment.NewLine +
                            "patch=1,EE,01DA8A98,extended,0030 //paste to memory address" + Environment.NewLine +
                            "patch=1,EE,505A601A,extended,00000002 //copy GRP" + Environment.NewLine +
                            "patch=1,EE,01DA8A9C,extended,0030 //paste to memory address" + Environment.NewLine +
                            "patch=1,EE,505A601C,extended,00000002 //copy RGA" + Environment.NewLine +
                            "patch=1,EE,01DA8AA0,extended,0030 //paste to memory address" + Environment.NewLine +
                            "patch=1,EE,505A601E,extended,00000002 //copy SPA" + Environment.NewLine +
                            "patch=1,EE,01DA8AA4,extended,0030 //paste to memory address" + Environment.NewLine +
                            "patch=1,EE,505A6020,extended,00000002 //copy WPA" + Environment.NewLine +
                            "patch=1,EE,01DA8AA8,extended,0030 //paste to memory address" + Environment.NewLine +
                            "patch=1,EE,505A6022,extended,00000002 //copy TGH" + Environment.NewLine +
                            "patch=1,EE,01DA8AAC,extended,0030 //paste to memory address" + Environment.NewLine +
                            "patch=1,EE,505A5FD2,extended,00000002 //copy HDEx" + Environment.NewLine +
                            "patch=1,EE,01DA8AB0,extended,0030 //paste to memory address" + Environment.NewLine +
                            "patch=1,EE,505A5FD8,extended,00000002 //copy HDE Balance" + Environment.NewLine +
                            "patch=1,EE,01DA8AB4,extended,0030 //paste to memory address" + Environment.NewLine +
                            "patch=1,EE,505A5FD4,extended,00000002 //copy UBEx" + Environment.NewLine +
                            "patch=1,EE,01DA8AB8,extended,0030 //paste to memory address" + Environment.NewLine +
                            "patch=1,EE,505A5FDA,extended,00000002 //copy UBE Balance" + Environment.NewLine +
                            "patch=1,EE,01DA8ABC,extended,0030 //paste to memory address" + Environment.NewLine +
                            "patch=1,EE,505A5FD6,extended,00000002 //copy LBEx" + Environment.NewLine +
                            "patch=1,EE,01DA8AC0,extended,0030 //paste to memory address" + Environment.NewLine +
                            "patch=1,EE,505A5FDC,extended,00000002 //copy LBE Balance" + Environment.NewLine +
                            "patch=1,EE,01DA8AC4,extended,0030 //paste to memory address";
                }
                else
                {
                    //for P2
                    code += Environment.NewLine +
                            "patch=1,EE,505AF768,extended,00000002 //copy STK" + Environment.NewLine +
                            "patch=1,EE,01DA8AC8,extended,0030 //paste to memory address" + Environment.NewLine +
                            "patch=1,EE,505AF76A,extended,00000002 //copy GRP" + Environment.NewLine +
                            "patch=1,EE,01DA8ACC,extended,0030 //paste to memory address" + Environment.NewLine +
                            "patch=1,EE,505AF76C,extended,00000002 //copy RGA" + Environment.NewLine +
                            "patch=1,EE,01DA8AD0,extended,0030 //paste to memory address" + Environment.NewLine +
                            "patch=1,EE,505AF76E,extended,00000002 //copy SPA" + Environment.NewLine +
                            "patch=1,EE,01DA8AD4,extended,0030 //paste to memory address" + Environment.NewLine +
                            "patch=1,EE,505AF770,extended,00000002 //copy WPA" + Environment.NewLine +
                            "patch=1,EE,01DA8AD8,extended,0030 //paste to memory address" + Environment.NewLine +
                            "patch=1,EE,505AF772,extended,00000002 //copy TGH" + Environment.NewLine +
                            "patch=1,EE,01DA8ADC,extended,0030 //paste to memory address" + Environment.NewLine +
                            "patch=1,EE,505AF722,extended,00000002 //copy HDEx" + Environment.NewLine +
                            "patch=1,EE,01DA8AE0,extended,0030 //paste to memory address" + Environment.NewLine +
                            "patch=1,EE,505AF728,extended,00000002 //copy HDE Balance" + Environment.NewLine +
                            "patch=1,EE,01DA8AE4,extended,0030 //paste to memory address" + Environment.NewLine +
                            "patch=1,EE,505AF724,extended,00000002 //copy UBEx" + Environment.NewLine +
                            "patch=1,EE,01DA8AE8,extended,0030 //paste to memory address" + Environment.NewLine +
                            "patch=1,EE,505AF72A,extended,00000002 //copy UBE Balance" + Environment.NewLine +
                            "patch=1,EE,01DA8AEC,extended,0030 //paste to memory address" + Environment.NewLine +
                            "patch=1,EE,505AF726,extended,00000002 //copy LBEx" + Environment.NewLine +
                            "patch=1,EE,01DA8AF0,extended,0030 //paste to memory address" + Environment.NewLine +
                            "patch=1,EE,505AF72C,extended,00000002 //copy LBE Balance" + Environment.NewLine +
                            "patch=1,EE,01DA8AF4,extended,0030 //paste to memory address";
                }

                playersToGet--;
            }
            else if (playersToGet == 0 && !code.Contains("SUPER"))
            {
                //restore originals
                if (j == 1)
                {
                    //for player 1
                    if (!code.Contains("STK"))
                    {
                        code += Environment.NewLine +
                                "patch=1,EE,51DA8A98,extended,00000002 //copy from stored memory" + Environment.NewLine +
                                "patch=1,EE,005A6018,extended,0000 //to STK";
                    }
                    if (!code.Contains("GRP"))
                    {
                        code += Environment.NewLine +
                                "patch=1,EE,51DA8A9C,extended,00000002 //copy from stored memory" + Environment.NewLine +
                                "patch=1,EE,005A601A,extended,0000 //to GRP";
                    }
                    if (!code.Contains("RGA"))
                    {
                        code += Environment.NewLine +
                                "patch=1,EE,51DA8AA0,extended,00000002 //copy from stored memory" + Environment.NewLine +
                                "patch=1,EE,005A601C,extended,0000 //to RGA";
                    }
                    if (!code.Contains("SPA"))
                    {
                        code += Environment.NewLine +
                                "patch=1,EE,51DA8AA4,extended,00000002 //copy from stored memory" + Environment.NewLine +
                                "patch=1,EE,005A601E,extended,0000 //to SPA";
                    }
                    if (!code.Contains("WPA"))
                    {
                        code += Environment.NewLine +
                                "patch=1,EE,51DA8AA8,extended,00000002 //copy from stored memory" + Environment.NewLine +
                                "patch=1,EE,005A6020,extended,0000 //to WPA";
                    }
                    if (!code.Contains("TGH"))
                    {
                        code += Environment.NewLine +
                                "patch=1,EE,51DA8AAC,extended,00000002 //copy from stored memory" + Environment.NewLine +
                                "patch=1,EE,005A6022,extended,0000 //to TGH";
                    }
                    if (!code.Contains("HDEx"))
                    {
                        code += Environment.NewLine +
                                "patch=1,EE,51DA8AB0,extended,00000002 //copy from stored memory" + Environment.NewLine +
                                "patch=1,EE,005A5FD2,extended,0000 //to HDEx";
                    }
                    if (!code.Contains("HDE Balance"))
                    {
                        code += Environment.NewLine +
                                "patch=1,EE,51DA8AB4,extended,00000002 //copy from stored memory" + Environment.NewLine +
                                "patch=1,EE,005A5FD8,extended,0000 //to HDE Balance";
                    }
                    if (!code.Contains("UBEx"))
                    {
                        code += Environment.NewLine +
                                "patch=1,EE,51DA8AB8,extended,00000002 //copy from stored memory" + Environment.NewLine +
                                "patch=1,EE,005A5FD4,extended,0000 //to UBEx";
                    }
                    if (!code.Contains("UBE Balance"))
                    {
                        code += Environment.NewLine +
                                "patch=1,EE,51DA8ABC,extended,00000002 //copy from stored memory" + Environment.NewLine +
                                "patch=1,EE,005A5FDA,extended,0000 //to UBE Balance";
                    }
                    if (!code.Contains("LBEx"))
                    {
                        code += Environment.NewLine +
                                "patch=1,EE,51DA8AC0,extended,00000002 //copy from stored memory" + Environment.NewLine +
                                "patch=1,EE,005A5FD6,extended,0000 //to LBEx";
                    }
                    if (!code.Contains("LBE Balance"))
                    {
                        code += Environment.NewLine +
                                "patch=1,EE,51DA8AC4,extended,00000002 //copy from stored memory" + Environment.NewLine +
                                "patch=1,EE,005A5FDC,extended,0000 //to LBE Balance";
                    }
                }
                else if (j == 2)
                {
                    //for player 2
                    if (!code.Contains("STK"))
                    {
                        code += Environment.NewLine +
                                "patch=1,EE,51DA8AC8,extended,00000002 //copy from stored memory" + Environment.NewLine +
                                "patch=1,EE,005AF768,extended,0000 //to STK";
                    }
                    if (!code.Contains("GRP"))
                    {
                        code += Environment.NewLine +
                                "patch=1,EE,51DA8ACC,extended,00000002 //copy from stored memory" + Environment.NewLine +
                                "patch=1,EE,005AF76A,extended,0000 //to GRP";
                    }
                    if (!code.Contains("RGA"))
                    {
                        code += Environment.NewLine +
                                "patch=1,EE,51DA8AD0,extended,00000002 //copy from stored memory" + Environment.NewLine +
                                "patch=1,EE,005AF76C,extended,0000 //to RGA";
                    }
                    if (!code.Contains("SPA"))
                    {
                        code += Environment.NewLine +
                                "patch=1,EE,51DA8AD4,extended,00000002 //copy from stored memory" + Environment.NewLine +
                                "patch=1,EE,005AF76E,extended,0000 //to SPA";
                    }
                    if (!code.Contains("WPA"))
                    {
                        code += Environment.NewLine +
                                "patch=1,EE,51DA8AD8,extended,00000002 //copy from stored memory" + Environment.NewLine +
                                "patch=1,EE,005AF770,extended,0000 //to WPA";
                    }
                    if (!code.Contains("TGH"))
                    {
                        code += Environment.NewLine +
                                "patch=1,EE,51DA8ADC,extended,00000002 //copy from stored memory" + Environment.NewLine +
                                "patch=1,EE,005AF772,extended,0000 //to TGH";
                    }
                    if (!code.Contains("HDEx"))
                    {
                        code += Environment.NewLine +
                                "patch=1,EE,51DA8AE0,extended,00000002 //copy from stored memory" + Environment.NewLine +
                                "patch=1,EE,005AF722,extended,0000 //to HDEx";
                    }
                    if (!code.Contains("HDE Balance"))
                    {
                        code += Environment.NewLine +
                                "patch=1,EE,51DA8AE4,extended,00000002 //copy from stored memory" + Environment.NewLine +
                                "patch=1,EE,005AF728,extended,0000 //to HDE Balance";
                    }
                    if (!code.Contains("UBEx"))
                    {
                        code += Environment.NewLine +
                                "patch=1,EE,51DA8AE8,extended,00000002 //copy from stored memory" + Environment.NewLine +
                                "patch=1,EE,005AF724,extended,0000 //to UBEx";
                    }
                    if (!code.Contains("UBE Balance"))
                    {
                        code += Environment.NewLine +
                                "patch=1,EE,51DA8AEC,extended,00000002 //copy from stored memory" + Environment.NewLine +
                                "patch=1,EE,005AF72A,extended,0000 //to UBE Balance";
                    }
                    if (!code.Contains("LBEx"))
                    {
                        code += Environment.NewLine +
                                "patch=1,EE,51DA8AF0,extended,00000002 //copy from stored memory" + Environment.NewLine +
                                "patch=1,EE,005AF726,extended,0000 //to LBEx";
                    }
                    if (!code.Contains("LBE Balance"))
                    {
                        code += Environment.NewLine +
                                "patch=1,EE,51DA8AF4,extended,00000002 //copy from stored memory" + Environment.NewLine +
                                "patch=1,EE,005AF72C,extended,0000 //to LBE Balance";
                    }
                }

            }

            return code;
        }
    }
}
