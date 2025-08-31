using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Media3D;
using Microsoft.VisualBasic.ApplicationServices;
using SC3_pnach_editor.Services;
using SC3_pnach_editor.ViewModelsClasses;

namespace SC3_pnach_editor.Codes
{
    public class SurvivalModeSubCodes
    {
        public static string GetStageCode(SurvivalList survivalCode)
        {
            string stageNumberValue = "";
            switch (survivalCode.stageNumber)
            {
                case 1:
                    stageNumberValue = "patch=1,EE,D04B6F5C,extended,00000000//If you kill 0 enemies (Set enemy 1)";
                    break;
                case 2:
                    stageNumberValue = "patch=1,EE,D04B6F5C,extended,00000001//If you kill 1 enemies (Set enemy 2)";
                    break;
                case 3:
                    stageNumberValue = "patch=1,EE,D04B6F5C,extended,00000002//If you kill 2 enemies (Set enemy 3)";
                    break;
                case 4:
                    stageNumberValue = "patch=1,EE,D04B6F5C,extended,00000003//If you kill 3 enemies (Set enemy 4)";
                    break;
                case 5:
                    stageNumberValue = "patch=1,EE,D04B6F5C,extended,00000004//If you kill 4 enemies (Set enemy 5)";
                    break;
                case 6:
                    stageNumberValue = "patch=1,EE,D04B6F5C,extended,00000005//If you kill 5 enemies (Set enemy 6)";
                    break;
                case 7:
                    stageNumberValue = "patch=1,EE,D04B6F5C,extended,00000006//If you kill 6 enemies (Set enemy 7)";
                    break;
                case 8:
                    stageNumberValue = "patch=1,EE,D04B6F5C,extended,00000007//If you kill 7 enemies (Set enemy 8)";
                    break;
                case 9:
                    stageNumberValue = "patch=1,EE,D04B6F5C,extended,00000008//If you kill 8 enemies (Set enemy 9)";
                    break;
                case 10:
                    stageNumberValue = "patch=1,EE,D04B6F5C,extended,00000009//If you kill 9 enemies (Set enemy 10)";
                    break;
                case 11:
                    stageNumberValue = "patch=1,EE,D04B6F5C,extended,0000000A//If you kill 10 enemies (Set enemy 11)";
                    break;
                case 12:
                    stageNumberValue = "patch=1,EE,D04B6F5C,extended,0000000B//If you kill 11 enemies (Set enemy 12)";
                    break;
                case 13:
                    stageNumberValue = "patch=1,EE,D04B6F5C,extended,0000000C//If you kill 12 enemies (Set enemy 13)";
                    break;
                case 14:
                    stageNumberValue = "patch=1,EE,D04B6F5C,extended,0000000D//If you kill 13 enemies (Set enemy 14)";
                    break;
                case 15:
                    stageNumberValue = "patch=1,EE,D04B6F5C,extended,0000000E//If you kill 14 enemies (Set enemy 15)";
                    break;
                case 16:
                    stageNumberValue = "patch=1,EE,D04B6F5C,extended,0000000F//If you kill 15 enemies (Set enemy 16)";
                    break;
                case 17:
                    stageNumberValue = "patch=1,EE,D04B6F5C,extended,00000010//If you kill 16 enemies (Set enemy 17)";
                    break;
                case 18:
                    stageNumberValue = "patch=1,EE,D04B6F5C,extended,00000011//If you kill 17 enemies (Set enemy 18)";
                    break;
                case 19:
                    stageNumberValue = "patch=1,EE,D04B6F5C,extended,00000012//If you kill 18 enemies (Set enemy 19)";
                    break;
                case 20:
                    stageNumberValue = "patch=1,EE,D04B6F5C,extended,00000013//If you kill 19 enemies (Set enemy 20)";
                    break;
            }

            string stageLevelValue = "";
            if (survivalCode.stageLevel != "")
            {
                string roomPart = survivalCode.stageLevel.Substring(0, 2);
                string stagePart = survivalCode.stageLevel.Substring(2, 2);

                string stageMusicPiece = "patch=1,EE,004ED648,extended,000000" + survivalCode.stageMusic + " //Music code";
                string stageLevelPiece = "patch=1,EE,004ED64C,extended,000000" + stagePart + " //Stage code";
                string stageRoomPiece = "patch=1,EE,004ED650,extended,000000" + roomPart + " //Level code";

                stageLevelValue = stageNumberValue + Environment.NewLine + stageMusicPiece + Environment.NewLine +
                                  stageNumberValue + Environment.NewLine + stageLevelPiece + Environment.NewLine +
                                  stageNumberValue + Environment.NewLine + stageRoomPiece + Environment.NewLine;
            }

            if (survivalCode.fightingStyle == "25")//Olcadan
            {
                List<string> standardChars = new List<string> { "01", "02", "03", "04", "05", "06", "07", "08", "0B", "0C", "0D",
                "0E", "0F", "11", "12", "14", "15", "16", "17", "1A", "22", "23", "24" };

                Random rnd = new Random();
                survivalCode.fightingStyle = standardChars[rnd.Next(standardChars.Count)];
            }
            if (survivalCode.fightingStyle == "2E")//Shadow Master
            {
                List<string> bonusChars = new List<string> { "30", "41", "42","43", "44", "45", "46",
                "47", "48", "4A", "4B", "4C", "4D", "4E", "4F", "51", "54" };

                Random rnd = new Random();
                survivalCode.fightingStyle = bonusChars[rnd.Next(bonusChars.Count)];
            }
            if (survivalCode.fightingStyle == "FF")//Edge Master
            {
                List<string> allChars = new List<string> { "01", "02", "03", "04", "05", "06", "07", "08", "0B", "0C", "0D",
                "0E", "0F", "11", "12", "14", "15", "16", "17", "1A", "22", "23", "24", "26",
                    "30", "41", "42","43", "44", "45", "46",
                "47", "48", "4A", "4B", "4C", "4D", "4E", "4F", "51", "54" };

                Random rnd = new Random();
                survivalCode.fightingStyle = allChars[rnd.Next(allChars.Count)];
            }

            string charPiece1 = "patch=1,EE,204D1FE0,extended,00" + survivalCode.fightingStyle + "00" + survivalCode.model + " // fighting style + model";
            charPiece1 = stageNumberValue + Environment.NewLine + charPiece1 + Environment.NewLine;
            string charPiece2 = "";
            //Charade special conditions
            if (survivalCode.fightingStyle == "28")
            {
                charPiece2 = "patch=1,EE,204D1FE4,extended,00" + survivalCode.fightingStyle + "00" + "54" + " // weapon gfx mapping (use fighting style)";
            }
            else if (survivalCode.fightingStyle == "29")
            {
                charPiece2 = "patch=1,EE,204D1FE4,extended,00" + survivalCode.fightingStyle + "00" + "46" + " // weapon gfx mapping (use fighting style)";
            }
            else if (survivalCode.fightingStyle == "2A")
            {
                charPiece2 = "patch=1,EE,204D1FE4,extended,00" + survivalCode.fightingStyle + "00" + "17" + " // weapon gfx mapping (use fighting style)";
            }
            else
            {
                charPiece2 = "patch=1,EE,204D1FE4,extended,00" + survivalCode.fightingStyle + "00" + survivalCode.fightingStyle + " // weapon gfx mapping (use fighting style)";
            }
            charPiece2 = stageNumberValue + Environment.NewLine + charPiece2 + Environment.NewLine;
            string charPiece3 = "";
            if (survivalCode.fightingStyle == "2A")
            {
                charPiece3 = "patch=1,EE,204D1FE8,extended,000100" + survivalCode.fightingStyle + " // type + weapon gfx mapping (use fighting style)";
            }
            else
            {
                charPiece3 = "patch=1,EE,204D1FE8,extended,000100" + survivalCode.fightingStyle + " // type + weapon gfx mapping (use fighting style)";
            }
            charPiece3 = stageNumberValue + Environment.NewLine + charPiece3 + Environment.NewLine;
            string charPiece4 = "patch=1,EE,204D1FEC,extended,00" + survivalCode.costume + "00" + survivalCode.model + " // costume + model";
            charPiece4 = stageNumberValue + Environment.NewLine + charPiece4 + Environment.NewLine;
            string charPiece5 = "patch=1,EE,004D2016,extended," + survivalCode.weaponNumber + " //Selected Weapon";
            charPiece5 = stageNumberValue + Environment.NewLine + charPiece5 + Environment.NewLine;

            string voicePiece = "";
            if (survivalCode.voice != null && survivalCode.voice != "")
            {
                voicePiece = "patch=1,EE,104D1FF2,extended," + survivalCode.voice + " //Voice";
                voicePiece = stageNumberValue + Environment.NewLine + voicePiece + Environment.NewLine;
            }
            if (survivalCode.model == "44")//Hwang
            {
                string secondVoicePierce = "patch=1,EE,204D2008,extended,004F49F0 //second voice";
                voicePiece = voicePiece + stageNumberValue + Environment.NewLine + secondVoicePierce + Environment.NewLine;
            }
            if (survivalCode.model == "46")//Valeria
            {
                string secondVoicePierce = "patch=1,EE,204D2008,extended,004F4A40 //second voice";
                voicePiece = voicePiece + stageNumberValue + Environment.NewLine + secondVoicePierce + Environment.NewLine;
            }
            if (survivalCode.model == "47")//Hualin
            {
                string secondVoicePierce = "patch=1,EE,204D2008,extended,004F4A68 //second voice";
                voicePiece = voicePiece + stageNumberValue + Environment.NewLine + secondVoicePierce + Environment.NewLine;
            }
            if (survivalCode.model == "4F")//Lynette
            {
                string secondVoicePierce = "patch=1,EE,204D2008,extended,004F4B80 //second voice";
                voicePiece = voicePiece + stageNumberValue + Environment.NewLine + secondVoicePierce + Environment.NewLine;
            }
            if (survivalCode.model == "51")//Li Long
            {
                string secondVoicePierce = "patch=1,EE,204D2008,extended,004F4BA8 //second voice";
                voicePiece = voicePiece + stageNumberValue + Environment.NewLine + secondVoicePierce + Environment.NewLine;
            }
            if (survivalCode.specialData == "Riese voice")
            {
                voicePiece = voicePiece + stageNumberValue + Environment.NewLine +
                    "patch=1,EE,204D2008,extended,004F45E0 //Second Voice"
                    + Environment.NewLine;
            }

            string specPiece1 = "";
            if (survivalCode.aiLevel != "")
            {
                
                string part1 = "patch=1,EE,10520D54,extended,00" + survivalCode.aiLevel + " //opponent AI";
                string part2 = "";
                if (survivalCode.model != "31")
                {
                    part2 = "patch=1,EE,10520D5C,extended,00" + survivalCode.aiLevel + " //opponent AI";
                }
                else
                {
                    part2 = "patch=1,EE,10520D5C,extended,0002 //opponent AI";
                }


                specPiece1 = stageNumberValue + Environment.NewLine + part1 + Environment.NewLine +
                             stageNumberValue + Environment.NewLine + part2 + Environment.NewLine;
            }

            string specPiece2 = "";
            string weaponSpecialPiece1 = "";
            string weaponSpecialPiece2 = "";
            string weaponSpecialPiece3 = "";
            string weaponSpecialPiece4 = "";
            string weaponSpecialPiece5 = "";
            string weaponSpecialPiece6 = "";
            switch (survivalCode.weaponSpecial)
            {
                case "All Guard Break":
                    weaponSpecialPiece1 = "patch=1,EE,104ED9CA,extended,0001 //Enable weapon effects [Shared]" + Environment.NewLine;
                    weaponSpecialPiece2 = "patch=1,EE,1053CE1C,extended,0002 //Thunder Effect P2" + Environment.NewLine;
                    weaponSpecialPiece3 = "patch=1,EE,1053CF20,extended,0001 //Thunder Gfx P2" + Environment.NewLine;
                    weaponSpecialPiece4 = "patch=1,EE,2053CD40,extended,00010003 //Thunder Effect + Gfx P2 [Shared]" + Environment.NewLine;
                    break;
                case "All Unblockable":
                    weaponSpecialPiece1 = "patch=1,EE,104ED9CA,extended,0001 //Enable weapon effects [Shared]" + Environment.NewLine;
                    weaponSpecialPiece2 = "patch=1,EE,1053CE18,extended,0002 //Fire Effect P2" + Environment.NewLine;
                    weaponSpecialPiece3 = "patch=1,EE,1053CFB0,extended,0001 //Fire Gfx P2" + Environment.NewLine;
                    weaponSpecialPiece4 = "patch=1,EE,2053CD40,extended,00010003 //Fire Effect + Gfx P2 [Shared]" + Environment.NewLine;
                    break;
                case "Paralysis":
                    weaponSpecialPiece1 = "patch=1,EE,104ED9CA,extended,0001 //Enable weapon effects [Shared]" + Environment.NewLine;
                    weaponSpecialPiece2 = "patch=1,EE,1053CE14,extended,0001 //Paralysis Effect P2" + Environment.NewLine;
                    weaponSpecialPiece3 = "patch=1,EE,1053CFAC,extended,0002 //Paralysis Gfx P2" + Environment.NewLine;
                    weaponSpecialPiece4 = "patch=1,EE,2053CD40,extended,00030001 //Paralysis Effect + Gfx P2 [Shared]" + Environment.NewLine;
                    break;
                case "Down Lose":
                    weaponSpecialPiece1 = "patch=1,EE,104ED9CA,extended,0001 //Enable weapon effects [Shared]" + Environment.NewLine;
                    weaponSpecialPiece2 = "patch=1,EE,1053CDA8,extended,0007 //Down Lose Effect P1" + Environment.NewLine;
                    weaponSpecialPiece3 = "patch=1,EE,2053CD40,extended,00000001 //Down Lose Effect P1 & P2 [Shared]" + Environment.NewLine;
                    break;
                case "Cure":
                    weaponSpecialPiece1 = "patch=1,EE,104ED9CA,extended,0001 // Enable weapon effects [Shared]" + Environment.NewLine;
                    weaponSpecialPiece2 = "patch=1,EE,1053CF48,extended,0001 // Cure Gfx P2" + Environment.NewLine;
                    weaponSpecialPiece3 = "patch=1,EE,2053CD40,extended,00010000 // P2 Cure" + Environment.NewLine;
                    weaponSpecialPiece4 = "patch=1,EE,2053E060,extended,3D000000 // P2 Cure Percentage" + Environment.NewLine;
                    break;
                case "Poison":
                    weaponSpecialPiece1 = "patch=1,EE,104ED9CA,extended,0001 // Enable weapon effects [Shared]" + Environment.NewLine;
                    weaponSpecialPiece2 = "patch=1,EE,1053CDB8,extended,0002 // P1 Poison Flag" + Environment.NewLine;
                    weaponSpecialPiece3 = "patch=1,EE,2053CD40,extended,00000003 // P1 Poison" + Environment.NewLine;
                    weaponSpecialPiece4 = "patch=1,EE,2053D064,extended,3D000000 // P1 Poison Drain Percentage" + Environment.NewLine;
                    break;
                case "Poison P2":
                    weaponSpecialPiece1 = "patch=1,EE,104ED9CA,extended,0001 // Enable weapon effects [Shared]" + Environment.NewLine;
                    weaponSpecialPiece2 = "patch=1,EE,1053CF44,extended,0002 // P2 Poison Flag" + Environment.NewLine;
                    weaponSpecialPiece3 = "patch=1,EE,2053CD40,extended,00030000 // P2 Poison" + Environment.NewLine;
                    weaponSpecialPiece4 = "patch=1,EE,2053E064,extended,3D000000 // P2 Poison Drain Percentage" + Environment.NewLine;
                    break;
                case "Minus Guard":
                    weaponSpecialPiece1 = "patch=1,EE,104ED9CA,extended,0001 // Enable weapon effects [Shared]" + Environment.NewLine;
                    weaponSpecialPiece2 = "patch=1,EE,2053CD40,extended,00000001 // P1 Poison while guarding" + Environment.NewLine;
                    weaponSpecialPiece3 = "patch=1,EE,1053CE3C,extended,0001 // P1 Poison Flag (guard)" + Environment.NewLine;
                    weaponSpecialPiece4 = "patch=1,EE,2053D060,extended,3D800000 // P1 Poison percentage" + Environment.NewLine;
                    break;
                case "Super Poison":
                    weaponSpecialPiece1 = "patch=1,EE,104ED9CA,extended,0001 // Enable weapon effects [Shared]" + Environment.NewLine;
                    weaponSpecialPiece2 = "patch=1,EE,1053CDB8,extended,0002 // P1 Poison Flag" + Environment.NewLine;
                    weaponSpecialPiece3 = "patch=1,EE,2053CD40,extended,00000003 // P1 Poison" + Environment.NewLine;
                    weaponSpecialPiece4 = "patch=1,EE,2053D064,extended,3D800000 // P1 Poison Drain Percentage" + Environment.NewLine;
                    break;
                case "Mega Poison":
                    weaponSpecialPiece1 = "patch=1,EE,104ED9CA,extended,0001 // Enable weapon effects [Shared]" + Environment.NewLine;
                    weaponSpecialPiece2 = "patch=1,EE,1053CDB8,extended,0002 // P1 Poison Flag" + Environment.NewLine;
                    weaponSpecialPiece3 = "patch=1,EE,2053CD40,extended,00000003 // P1 Poison" + Environment.NewLine;
                    weaponSpecialPiece4 = "patch=1,EE,2053D064,extended,3E000000 // P1 Poison Drain Percentage" + Environment.NewLine;
                    break;
                case "Super Cure":
                    weaponSpecialPiece1 = "patch=1,EE,104ED9CA,extended,0001 // Enable weapon effects [Shared]" + Environment.NewLine;
                    weaponSpecialPiece2 = "patch=1,EE,1053CF48,extended,0001 // Cure Gfx P2" + Environment.NewLine;
                    weaponSpecialPiece3 = "patch=1,EE,2053CD40,extended,00010000 // P2 Cure" + Environment.NewLine;
                    weaponSpecialPiece4 = "patch=1,EE,2053E060,extended,3D800000 // P2 Cure Percentage" + Environment.NewLine;
                    break;
                case "Mega Cure":
                    weaponSpecialPiece1 = "patch=1,EE,104ED9CA,extended,0001 // Enable weapon effects [Shared]" + Environment.NewLine;
                    weaponSpecialPiece2 = "patch=1,EE,1053CF48,extended,0001 // Cure Gfx P2" + Environment.NewLine;
                    weaponSpecialPiece3 = "patch=1,EE,2053CD40,extended,00010000 // P2 Cure" + Environment.NewLine;
                    weaponSpecialPiece4 = "patch=1,EE,2053E060,extended,3E000000 // P2 Cure Percentage" + Environment.NewLine;
                    break;
                case "Defense Down":
                    weaponSpecialPiece1 = "patch=1,EE,104ED9CA,extended,0001 // Enable weapon effects" + Environment.NewLine;
                    weaponSpecialPiece2 = "patch=1,EE,1053CE34,extended,0001 // P1 Flag" + Environment.NewLine;
                    weaponSpecialPiece3 = "patch=1,EE,2053CD40,extended,00000001 // P1 Effect" + Environment.NewLine;
                    weaponSpecialPiece4 = "patch=1,EE,2053D060,extended,3FC00000 // P1 Def" + Environment.NewLine;
                    break;
                case "Defense Down P2":
                    weaponSpecialPiece1 = "patch=1,EE,104ED9CA,extended,0001 // Enable weapon effects" + Environment.NewLine;
                    weaponSpecialPiece2 = "patch=1,EE,1053CFC0,extended,0001 // P2 Flag" + Environment.NewLine;
                    weaponSpecialPiece3 = "patch=1,EE,2053CD40,extended,00010000 // P2 Effect" + Environment.NewLine;
                    weaponSpecialPiece4 = "patch=1,EE,2053E060,extended,3FC00000 // P2 Def" + Environment.NewLine;
                    break;
                case "Defense Up":
                    weaponSpecialPiece1 = "patch=1,EE,104ED9CA,extended,0001 // Enable weapon effects" + Environment.NewLine;
                    weaponSpecialPiece2 = "patch=1,EE,1053CFC0,extended,0001 // P2 Flag" + Environment.NewLine;
                    weaponSpecialPiece3 = "patch=1,EE,2053CD40,extended,00010000 // P2 Effect" + Environment.NewLine;
                    weaponSpecialPiece4 = "patch=1,EE,2053E060,extended,3F400000 // P2 Def" + Environment.NewLine;
                    break;
                case "Super Defense":
                    weaponSpecialPiece1 = "patch=1,EE,104ED9CA,extended,0001 // Enable weapon effects" + Environment.NewLine;
                    weaponSpecialPiece2 = "patch=1,EE,1053CFC0,extended,0001 // P2 Flag" + Environment.NewLine;
                    weaponSpecialPiece3 = "patch=1,EE,2053CD40,extended,00010000 // P2 Effect" + Environment.NewLine;
                    weaponSpecialPiece4 = "patch=1,EE,2053E060,extended,3F000000 // P2 Def" + Environment.NewLine;
                    break;
                case "Glue":
                    weaponSpecialPiece1 = "patch=1,EE,104ED9CA,extended,0001 // Enable weapon effects" + Environment.NewLine;
                    weaponSpecialPiece2 = "patch=1,EE,1053CDA0,extended,0001 // P1 Glue Flag" + Environment.NewLine;
                    weaponSpecialPiece3 = "patch=1,EE,2053CD40,extended,00000001 // P2 Effect" + Environment.NewLine;
                    weaponSpecialPiece4 = "patch=1,EE,2053D060,extended,3C000000 // P2 Attraction percentage" + Environment.NewLine;
                    break;
                case "Separate":
                    weaponSpecialPiece1 = "patch=1,EE,104ED9CA,extended,0001 // Enable weapon effects" + Environment.NewLine;
                    weaponSpecialPiece2 = "patch=1,EE,2053CDA0,extended,0001 // P1 Flag" + Environment.NewLine;
                    weaponSpecialPiece3 = "patch=1,EE,2053CD40,extended,00000003 // P2 Effect" + Environment.NewLine;
                    weaponSpecialPiece4 = "patch=1,EE,2053D060,extended,BCA3D70A // P2 Separation power" + Environment.NewLine;
                    break;
                case "Smash":
                    weaponSpecialPiece1 = "patch=1,EE,104ED9CA,extended,0001 // Enable weapon effects" + Environment.NewLine;
                    weaponSpecialPiece2 = "patch=1,EE,1053CD5C,extended,0001 // P1 Flag" + Environment.NewLine;
                    weaponSpecialPiece3 = "patch=1,EE,2053CD40,extended,00000005 // P1 Effect" + Environment.NewLine;
                    weaponSpecialPiece4 = "patch=1,EE,1053CE04,extended,0004 // P2 Smash power" + Environment.NewLine;
                    break;
                case "Smash P2":
                    weaponSpecialPiece1 = "patch=1,EE,104ED9CA,extended,0001 // Enable weapon effects" + Environment.NewLine;
                    weaponSpecialPiece2 = "patch=1,EE,1053CEE8,extended,0001 // P2 Flag" + Environment.NewLine;
                    weaponSpecialPiece3 = "patch=1,EE,2053CD40,extended,00050000 // P2 Effect" + Environment.NewLine;
                    weaponSpecialPiece4 = "patch=1,EE,1053CF90,extended,0004 // P1 Smash power" + Environment.NewLine;
                    break;
                case "Whirlwind":
                    weaponSpecialPiece1 = "patch=1,EE,104ED9CA,extended,0001 // Enable weapon effects" + Environment.NewLine;
                    weaponSpecialPiece2 = "patch=1,EE,1053CD54,extended,0001 // P1 Flag" + Environment.NewLine;
                    weaponSpecialPiece3 = "patch=1,EE,2053CD40,extended,00000003 // P1 Effect" + Environment.NewLine;
                    weaponSpecialPiece4 = "patch=1,EE,2053D060,extended,3C23D70A // Wind power against P1" + Environment.NewLine;
                    break;
                case "Aerial Wind":
                    weaponSpecialPiece1 = "patch=1,EE,104ED9CA,extended,0001 // Enable weapon effects" + Environment.NewLine;
                    weaponSpecialPiece2 = "patch=1,EE,1053CD7C,extended,0002 // P1 Flag" + Environment.NewLine;
                    weaponSpecialPiece3 = "patch=1,EE,2053CD40,extended,00000003 // P1 Effect" + Environment.NewLine;
                    weaponSpecialPiece4 = "patch=1,EE,2053D064,extended,3F000000 // P1 fly up" + Environment.NewLine;
                    break;
                case "Aerial Wind P2":
                    weaponSpecialPiece1 = "patch=1,EE,104ED9CA,extended,0001 // Enable weapon effects" + Environment.NewLine;
                    weaponSpecialPiece2 = "patch=1,EE,1053CF08,extended,0002 // P2 Flag" + Environment.NewLine;
                    weaponSpecialPiece3 = "patch=1,EE,2053CD40,extended,00030000 // P2 Effect" + Environment.NewLine;
                    weaponSpecialPiece4 = "patch=1,EE,2053E064,extended,3F000000 // P2 fly up" + Environment.NewLine;
                    break;
                case "Reserve Offense Up":
                    weaponSpecialPiece1 = "patch=1,EE,104ED9CA,extended,0001 // Enable weapon effects" + Environment.NewLine;
                    weaponSpecialPiece2 = "patch=1,EE,1053CFC4,extended,0001 // P2 Flag" + Environment.NewLine;
                    weaponSpecialPiece3 = "patch=1,EE,2053CD40,extended,00010000 // P2 Effect" + Environment.NewLine;
                    weaponSpecialPiece4 = "patch=1,EE,2053E060,extended,40000000 // P2 Hp down = Atk up" + Environment.NewLine;
                    break;
                case "Ice":
                    weaponSpecialPiece1 = "patch=1,EE,104ED9CA,extended,0001 // Enable weapon effects" + Environment.NewLine;
                    weaponSpecialPiece2 = "patch=1,EE,1053CD4C,extended,0001 //Can Fall Of The Ring Player 1" + Environment.NewLine;
                    weaponSpecialPiece3 = "patch=1,EE,2053CD40,extended,00000007 // P1 Effect" + Environment.NewLine;
                    weaponSpecialPiece4 = "patch=1,EE,1053CD58,extended,0001 //Slippery Feets Player 1" + Environment.NewLine;
                    break;
                case "Soul Smash":
                    weaponSpecialPiece1 = "patch=1,EE,104ED9CA,extended,0001 // Enable weapon effects" + Environment.NewLine;
                    weaponSpecialPiece2 = "patch=1,EE,2053CD40,extended,0000000F // P1 Effect" + Environment.NewLine;
                    weaponSpecialPiece3 = "patch=1,EE,1053CD5C,extended,0001 // P1 Flag" + Environment.NewLine;
                    weaponSpecialPiece4 = "patch=1,EE,1053CD88,extended,0002 // P1 Flag" + Environment.NewLine;
                    weaponSpecialPiece5 = "patch=1,EE,2053D060,extended,42200000 // P1 damage when he hits walls" + Environment.NewLine;
                    weaponSpecialPiece6 = "patch=1,EE,2053D064,extended,407EB852 // distance traveled by P1" + Environment.NewLine;
                    break;
                case "Thundalysis":
                    weaponSpecialPiece1 = "patch=1,EE,104ED9CA,extended,0001 // Enable weapon effects" + Environment.NewLine;
                    weaponSpecialPiece2 = "patch=1,EE,1053CE1C,extended,0001 //Thunder Effect P2" + Environment.NewLine;
                    weaponSpecialPiece3 = "patch=1,EE,1053CF20,extended,0001 //Thunder Gfx P2" + Environment.NewLine;
                    weaponSpecialPiece4 = "patch=1,EE,1053CE14,extended,0001 //Paralysis Effect P2" + Environment.NewLine;
                    weaponSpecialPiece5 = "patch=1,EE,1053CFAC,extended,0001 //Paralysis Gfx P2" + Environment.NewLine;
                    weaponSpecialPiece6 = "patch=1,EE,2053CD40,extended,00010001 //Thunder Effect + Gfx P2 [Shared]" + Environment.NewLine;
                    break;
            }
            if (survivalCode.weaponSpecial != "")
            {
                if (survivalCode.weaponSpecial != "Ice")
                {
                    if (weaponSpecialPiece4 == "")
                    {
                        specPiece2 = stageNumberValue + Environment.NewLine + weaponSpecialPiece1 +
                                     stageNumberValue + Environment.NewLine + weaponSpecialPiece2 +
                                     stageNumberValue + Environment.NewLine + weaponSpecialPiece3;
                    }
                    else
                    {
                        specPiece2 = stageNumberValue + Environment.NewLine + weaponSpecialPiece1 +
                                     stageNumberValue + Environment.NewLine + weaponSpecialPiece2 +
                                     stageNumberValue + Environment.NewLine + weaponSpecialPiece3 +
                                     stageNumberValue + Environment.NewLine + weaponSpecialPiece4;
                    }
                    if (weaponSpecialPiece5 != "")
                    {
                        //add more code for soul smash
                        specPiece2 = specPiece2 + stageNumberValue + Environment.NewLine + weaponSpecialPiece5 +
                                                  stageNumberValue + Environment.NewLine + weaponSpecialPiece6;
                    }
                }
                else
                {
                    string stageNumberValue2 = stageNumberValue.Remove(30, 1).Insert(30, "2");//replace 0 with 2

                    specPiece2 = stageNumberValue + Environment.NewLine + weaponSpecialPiece1 +
                                 stageNumberValue + Environment.NewLine + weaponSpecialPiece2 +
                                 stageNumberValue2 + Environment.NewLine + weaponSpecialPiece3 +
                                 "patch=1,EE,D04ED754,extended,030003E7 //Time is 999 seconds" + Environment.NewLine +
                                 stageNumberValue + Environment.NewLine + weaponSpecialPiece4;
                }
            }

            string specPiece3 = "";
            if (survivalCode.guardianForce != "")
            {
                if (survivalCode.guardianForce == "00")
                {
                    //fix for Charade and Inferno
                    specPiece3 = "patch=1,EE,204D2274,extended,00010000" + " //Guardian Force";
                    specPiece3 = stageNumberValue + Environment.NewLine + specPiece3 + Environment.NewLine;
                }
                else if (survivalCode.guardianForce == "06")
                {
                    //Soul Wisp Armor
                    string pie1 = "patch=1,EE,2053CE70,extended,01 //Soul wisps in air";
                    string pie2 = "patch=1,EE,2053CFFC,extended,01 //Wisp stagger enemy";
                    string pie3 = "patch=1,EE,2053D008,extended,02 // Enable Body Gfx";
                    string pie4 = "patch=1,EE,2053CD40,extended,00030001 // P2 Soul Armor";

                    specPiece3 = stageNumberValue + Environment.NewLine + pie1 + Environment.NewLine +
                                 stageNumberValue + Environment.NewLine + pie2 + Environment.NewLine +
                                 stageNumberValue + Environment.NewLine + pie3 + Environment.NewLine +
                                 stageNumberValue + Environment.NewLine + pie4 + Environment.NewLine;
                }
                else
                {
                    specPiece3 = "patch=1,EE,204D2274,extended,000200" + survivalCode.guardianForce + " //Guardian Force";
                    specPiece3 = stageNumberValue + Environment.NewLine + specPiece3 + Environment.NewLine;
                }
            }

            string specPiece4 = "";
            if (survivalCode.stickyFeet != "")
            {
                string stickyFeetPiece1 = "patch=1,EE,1053CD42,extended,0007 //Slippery Feets Player 2";
                string stickyFeetPiece2 = "patch=1,EE,1053CED8,extended,0001 //Can Fall Of The Ring Player 2";
                string stickyFeetPiece3 = "patch=1,EE,1053CEE4,extended,0001 //Slippery Feets Player 2";

                specPiece4 = stageNumberValue + Environment.NewLine + stickyFeetPiece1 + Environment.NewLine +
                              stageNumberValue + Environment.NewLine + stickyFeetPiece2 + Environment.NewLine +
                              stageNumberValue + Environment.NewLine + stickyFeetPiece3 + Environment.NewLine;
            }

            string specPiece5 = "";
            if (survivalCode.speed != "")
            {
                string speedCodePiece1 = "patch=1,EE,200FFD0C,extended,3C01" + survivalCode.speed + "//P2 (speed value)";
                string speedCodePiece2 = "patch=1,EE,200FFD10,extended,3C04004D//P2 (speed modifier)";
                string speedCodePiece3 = "patch=1,EE,200FFD14,extended,AC8136D0//P2 (speed modifier)";
                string speedCodePiece4 = "patch=1,EE,200FFD18,extended,0260202D//BOTH (speed modifier)";
                string speedCodePiece5 = "patch=1,EE,200FFD1C,extended,0806CDD1//BOTH (speed modifier)";
                string speedCodePiece6 = "patch=1,EE,201B3740,extended,0803FF40//BOTH (speed modifier)";

                specPiece5 = stageNumberValue + Environment.NewLine + speedCodePiece1 + Environment.NewLine +
                             stageNumberValue + Environment.NewLine + speedCodePiece2 + Environment.NewLine +
                             stageNumberValue + Environment.NewLine + speedCodePiece3 + Environment.NewLine +
                             stageNumberValue + Environment.NewLine + speedCodePiece4 + Environment.NewLine +
                             stageNumberValue + Environment.NewLine + speedCodePiece5 + Environment.NewLine +
                             stageNumberValue + Environment.NewLine + speedCodePiece6 + Environment.NewLine;
            }

            string wpnPiece1 = "";
            if (survivalCode.weaponEffect != "")
            {
                wpnPiece1 = "patch=1,EE,204D23AC,extended," + survivalCode.weaponEffect +
                    " //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform";
                wpnPiece1 = stageNumberValue + Environment.NewLine + wpnPiece1 + Environment.NewLine;
            }
            string wpnPiece2 = "";
            if (survivalCode.attack != "")
            {
                wpnPiece2 = "patch=1,EE,204D23B0,extended," + survivalCode.attack + " //Decrease/Increase Attack";
                wpnPiece2 = stageNumberValue + Environment.NewLine + wpnPiece2 + Environment.NewLine;
            }
            string wpnPiece3 = "";
            if (survivalCode.defense != "")
            {
                wpnPiece3 = "patch=1,EE,204D23B4,extended," + survivalCode.defense + " //Decrease/Increase Defense";
                wpnPiece3 = stageNumberValue + Environment.NewLine + wpnPiece3 + Environment.NewLine;
            }
            string wpnPiece4 = "";
            if (survivalCode.stealHp != "")
            {
                wpnPiece4 = "patch=1,EE,204D23B8,extended," + survivalCode.stealHp + " //Steal health from enemy";
                wpnPiece4 = stageNumberValue + Environment.NewLine + wpnPiece4 + Environment.NewLine;
            }
            string wpnPiece5 = "";
            if (survivalCode.pierceDamage != "")
            {
                wpnPiece5 = "patch=1,EE,204D23BC,extended," + survivalCode.pierceDamage + " //Damage inflicted thru guard";
                wpnPiece5 = stageNumberValue + Environment.NewLine + wpnPiece5 + Environment.NewLine;
            }
            string wpnPiece6 = "";
            if (survivalCode.weaponSize != "")
            {
                wpnPiece6 = "patch=1,EE,204D23C0,extended," + survivalCode.weaponSize + " //Weapon size";
                wpnPiece6 = stageNumberValue + Environment.NewLine + wpnPiece6 + Environment.NewLine;
            }
            string wpnPiece7 = "";
            if (survivalCode.atkPushForce != "")
            {
                wpnPiece7 = "patch=1,EE,204D23C4,extended," + survivalCode.atkPushForce + " //Decrease/Increase Attack Pushback Force";
                wpnPiece7 = stageNumberValue + Environment.NewLine + wpnPiece7 + Environment.NewLine;
            }
            string wpnPiece8 = "";
            if (survivalCode.counterRate != "")
            {
                wpnPiece8 = "patch=1,EE,204D23C8,extended," + survivalCode.counterRate + " //Increase Counter Chance";
                wpnPiece8 = stageNumberValue + Environment.NewLine + wpnPiece8 + Environment.NewLine;
            }
            string wpnPiece9 = "";
            if (survivalCode.nullCounter != "")
            {
                wpnPiece9 = "patch=1,EE,204D23CC,extended," + survivalCode.nullCounter + " //Nullify Enemies Counters chance";
                wpnPiece9 = stageNumberValue + Environment.NewLine + wpnPiece9 + Environment.NewLine;
            }
            string wpnPiece10 = "";
            if (survivalCode.guardHpModify != "")
            {
                wpnPiece10 = "patch=1,EE,204D23D0,extended," + survivalCode.guardHpModify + " //Decrease/Increase Health while guarding enemies attacks";
                wpnPiece10 = stageNumberValue + Environment.NewLine + wpnPiece10 + Environment.NewLine;
            }
            string wpnPiece11 = "";
            if (survivalCode.autoGuardImpact != "")
            {
                wpnPiece11 = "patch=1,EE,204D23D4,extended," + survivalCode.autoGuardImpact + " //Automatically Guard Impact some attacks";
                wpnPiece11 = stageNumberValue + Environment.NewLine + wpnPiece11 + Environment.NewLine;
            }
            string wpnPiece12 = "";
            if (survivalCode.parryDamage != "")
            {
                wpnPiece12 = "patch=1,EE,204D23D8,extended," + survivalCode.parryDamage + " //Increase Damage Received by Opponent when successfully Guard Impact";
                wpnPiece12 = stageNumberValue + Environment.NewLine + wpnPiece12 + Environment.NewLine;
            }
            string wpnPiece13 = "";
            if (survivalCode.parryRegen != "")
            {
                wpnPiece13 = "patch=1,EE,204D23DC,extended," + survivalCode.parryRegen + " //Recover Health when successfully Guard Impact";
                wpnPiece13 = stageNumberValue + Environment.NewLine + wpnPiece13 + Environment.NewLine;
            }
            string wpnPiece14 = "";
            if (survivalCode.guardBreakRate != "")
            {
                wpnPiece14 = "patch=1,EE,204D23E0,extended," + survivalCode.guardBreakRate + " //Increase Guard Break Chance";
                wpnPiece14 = stageNumberValue + Environment.NewLine + wpnPiece14 + Environment.NewLine;
            }
            string wpnPiece15 = "";
            if (survivalCode.throwEscapeChance != "")
            {
                wpnPiece15 = "patch=1,EE,204D23E4,extended," + survivalCode.throwEscapeChance + " //Increase Throw Escape Rate";
                wpnPiece15 = stageNumberValue + Environment.NewLine + wpnPiece15 + Environment.NewLine;
            }
            string wpnPiece16 = "";
            if (survivalCode.ringOutEscapeChance != "")
            {
                wpnPiece16 = "patch=1,EE,204D23E8,extended," + survivalCode.ringOutEscapeChance + " //Increase Ring-Out Escape Rate";
                wpnPiece16 = stageNumberValue + Environment.NewLine + wpnPiece16 + Environment.NewLine;
            }
            string wpnPiece17 = "";
            if (survivalCode.hpRegenOrDrain != "")
            {
                wpnPiece17 = "patch=1,EE,204D23EC,extended," + survivalCode.hpRegenOrDrain + " //Drain/Recover Health over Time";
                wpnPiece17 = stageNumberValue + Environment.NewLine + wpnPiece17 + Environment.NewLine;
            }
            string wpnPiece18 = "";
            if (survivalCode.hpRegenOrDrainOnAtk != "")
            {
                wpnPiece18 = "patch=1,EE,204D23F0,extended," + survivalCode.hpRegenOrDrainOnAtk + " //Drain/Recover Health when Attacking";
                wpnPiece18 = stageNumberValue + Environment.NewLine + wpnPiece18 + Environment.NewLine;
            }

            string finalCode = Environment.NewLine +
                               stageLevelValue +
                               charPiece1 +
                               charPiece2 +
                               charPiece3 +
                               charPiece4 +
                               charPiece5 +
                               voicePiece +
                               specPiece1 +
                               specPiece2 +
                               specPiece3 +
                               specPiece4 +
                               specPiece5 +
                               wpnPiece1 +
                               wpnPiece2 +
                               wpnPiece3 +
                               wpnPiece4 +
                               wpnPiece5 +
                               wpnPiece6 +
                               wpnPiece7 +
                               wpnPiece8 +
                               wpnPiece9 +
                               wpnPiece10 +
                               wpnPiece11 +
                               wpnPiece12 +
                               wpnPiece13 +
                               wpnPiece14 +
                               wpnPiece15 +
                               wpnPiece16 +
                               wpnPiece17 +
                               wpnPiece18 + Environment.NewLine; //etc add all

            return finalCode;
        }

        public static string GetRandomWeaponData(string fightingStyle, int level)
        {
            Random rnd = new Random();
            string selectedWeapon = "";

            List<int> numberList = new List<int>();

            if (SettingsClass.UltimateWeapons == false)
            {
                //The Ancient
                switch (level)
                {
                    case 1:
                        switch (fightingStyle)
                        {
                            case "27":
                            case "31":
                                numberList = new List<int> { 1 };
                                break;
                            case "26":
                                numberList = new List<int> { 1, 2 };
                                break;
                            case "01":
                            case "02":
                            case "03":
                            case "04":
                            case "05":
                            case "06":
                            case "07":
                            case "08":
                            case "0B":
                            case "0C":
                            case "0D":
                            case "0E":
                            case "0F":
                            case "11":
                            case "12":
                            case "14":
                            case "15":
                            case "16":
                            case "17":
                            case "1A":
                            case "22":
                            case "23":
                            case "24":
                            case "25":
                                numberList = new List<int> { 1, 2, 7, 8 };
                                break;
                            case "45":
                            case "48":
                            case "4D":
                            case "4E":
                            case "4A":
                            case "4B":
                            case "4C":
                            case "2E": //play it safe with shadow master
                                numberList = new List<int> { 1 };
                                break;
                            case "30":
                            case "42":
                            case "43":
                            case "46":
                            case "54":
                            case "41":
                            case "47":
                            case "4F":
                            case "51":
                                numberList = new List<int> { 1, 6 };
                                break;
                            case "44":
                                numberList = new List<int> { 1, 6, 7 };
                                break;
                        }
                        break;
                    case 2:
                        switch (fightingStyle)
                        {
                            case "27":
                            case "31":
                                numberList = new List<int> { 1 };
                                break;
                            case "26":
                                numberList = new List<int> { 1, 2 };
                                break;
                            case "01":
                            case "02":
                            case "03":
                            case "04":
                            case "05":
                            case "06":
                            case "07":
                            case "08":
                            case "0B":
                            case "0C":
                            case "0D":
                            case "0E":
                            case "0F":
                            case "11":
                            case "12":
                            case "14":
                            case "15":
                            case "16":
                            case "17":
                            case "1A":
                            case "22":
                            case "23":
                            case "24":
                            case "25":
                                numberList = new List<int> { 3 };
                                break;
                            case "30":
                            case "43":
                            case "4B":
                            case "4C":
                            case "4A":
                            case "42":
                            case "47":
                            case "51":
                            case "41":
                            case "2E": //play it safe with shadow master
                                numberList = new List<int> { 2 };
                                break;
                            case "44":
                            case "4F":
                                numberList = new List<int> { 3 };
                                break;
                            case "4E":
                            case "48":
                            case "46":
                                numberList = new List<int> { 2, 3 };
                                break;
                            case "45":
                                numberList = new List<int> { 2, 3, 4 };
                                break;
                            case "4D":
                                numberList = new List<int> { 2, 3, 8 };
                                break;
                            case "54":
                                numberList = new List<int> { 2, 4 };
                                break;
                        }
                        break;
                    case 3:
                        switch (fightingStyle)
                        {
                            case "27":
                            case "31":
                                numberList = new List<int> { 1 };
                                break;
                            case "26":
                                numberList = new List<int> { 1, 2 };
                                break;
                            case "01":
                            case "02":
                            case "03":
                            case "04":
                            case "05":
                            case "06":
                            case "07":
                            case "08":
                            case "0B":
                            case "0C":
                            case "0D":
                            case "0E":
                            case "0F":
                            case "11":
                            case "12":
                            case "14":
                            case "15":
                            case "16":
                            case "17":
                            case "1A":
                            case "22":
                            case "23":
                            case "24":
                            case "25":
                                numberList = new List<int> { 4, 5 };
                                break;
                            case "4E":
                            case "48":
                                numberList = new List<int> { 4, 6, 7 };
                                break;
                            case "30":
                            case "41":
                            case "47":
                            case "2E": //play it safe with shadow master
                                numberList = new List<int> { 3, 4 };
                                break;
                            case "45":
                                numberList = new List<int> { 5, 6, 8 };
                                break;
                            case "4D":
                                numberList = new List<int> { 4, 6 };
                                break;
                            case "4A":
                            case "4B":
                            case "4C":
                                numberList = new List<int> { 3, 4, 6 };
                                break;
                            case "42":
                            case "43":
                                numberList = new List<int> { 3, 4, 7 };
                                break;
                            case "46":
                                numberList = new List<int> { 4 };
                                break;
                            case "54":
                                numberList = new List<int> { 3, 7 };
                                break;
                            case "4F":
                            case "44":
                                numberList = new List<int> { 2, 4 };
                                break;
                            case "51":
                                numberList = new List<int> { 3 };
                                break;
                        }
                        break;
                    case 4:
                        switch (fightingStyle)
                        {
                            case "27":
                            case "31":
                                numberList = new List<int> { 1 };
                                break;
                            case "26":
                                numberList = new List<int> { 1, 2 };
                                break;
                            case "01":
                            case "02":
                            case "03":
                            case "04":
                            case "05":
                            case "06":
                            case "07":
                            case "08":
                            case "0B":
                            case "0C":
                            case "0D":
                            case "0E":
                            case "0F":
                            case "11":
                            case "12":
                            case "14":
                            case "15":
                            case "16":
                            case "17":
                            case "1A":
                            case "22":
                            case "23":
                            case "24":
                            case "25":
                                numberList = new List<int> { 6 };
                                break;
                            case "51":
                                numberList = new List<int> { 4, 5 };
                                break;
                            case "4D":
                            case "46":
                                numberList = new List<int> { 5, 7 };
                                break;
                            case "48":
                                numberList = new List<int> { 5, 8 };
                                break;
                            case "45":
                                numberList = new List<int> { 7 };
                                break;
                            case "4E":
                            case "4A":
                            case "4B":
                            case "4C":
                            case "30":
                            case "42":
                            case "43":
                            case "54":
                            case "41":
                            case "47":
                            case "4F":
                            case "44":
                            case "2E": //play it safe with shadow master
                                numberList = new List<int> { 5 };
                                break;
                        }
                        break;
                }
            }
            else
            {
                //Ultimate Weapons
                switch (level)
                {
                    case 1:
                        switch (fightingStyle)
                        {
                            case "27":
                            case "31":
                                numberList = new List<int> { 1 };
                                break;
                            case "26":
                                numberList = new List<int> { 1, 2 };
                                break;
                            case "01":
                            case "02":
                            case "03":
                            case "04":
                            case "05":
                            case "06":
                            case "07":
                            case "08":
                            case "0B":
                            case "0C":
                            case "0D":
                            case "0E":
                            case "0F":
                            case "11":
                            case "12":
                            case "14":
                            case "15":
                            case "16":
                            case "17":
                            case "1A":
                            case "22":
                            case "23":
                            case "24":
                            case "25":
                                numberList = new List<int> { 1, 2, 7 };
                                break;
                            case "45":
                            case "48":
                            case "4D":
                            case "4E":
                            case "4A":
                            case "4B":
                            case "4C":
                            case "2E": //play it safe with shadow master
                                numberList = new List<int> { 1 };
                                break;
                            case "30":
                            case "42":
                            case "43":
                            case "46":
                            case "54":
                            case "41":
                            case "47":
                            case "4F":
                            case "51":
                                numberList = new List<int> { 1, 6 };
                                break;
                            case "44":
                                numberList = new List<int> { 1, 6, 7 };
                                break;
                        }
                        break;
                    case 2:
                        switch (fightingStyle)
                        {
                            case "27":
                            case "31":
                                numberList = new List<int> { 1 };
                                break;
                            case "26":
                                numberList = new List<int> { 1, 2 };
                                break;
                            case "01":
                            case "02":
                            case "03":
                            case "04":
                            case "05":
                            case "06":
                            case "07":
                            case "08":
                            case "0B":
                            case "0C":
                            case "0D":
                            case "0E":
                            case "0F":
                            case "11":
                            case "12":
                            case "14":
                            case "15":
                            case "16":
                            case "17":
                            case "1A":
                            case "22":
                            case "23":
                            case "24":
                            case "25":
                                numberList = new List<int> { 3 };
                                break;
                            case "30":
                            case "43":
                            case "4B":
                            case "4C":
                            case "4A":
                            case "42":
                            case "47":
                            case "51":
                            case "41":
                            case "2E": //play it safe with shadow master
                                numberList = new List<int> { 2 };
                                break;
                            case "44":
                            case "4F":
                                numberList = new List<int> { 3 };
                                break;
                            case "4E":
                            case "48":
                            case "46":
                                numberList = new List<int> { 2, 3 };
                                break;
                            case "45":
                                numberList = new List<int> { 2, 3, 4 };
                                break;
                            case "4D":
                                numberList = new List<int> { 2, 3, 8 };
                                break;
                            case "54":
                                numberList = new List<int> { 2, 4 };
                                break;
                        }
                        break;
                    case 3:
                        switch (fightingStyle)
                        {
                            case "27":
                            case "31":
                                numberList = new List<int> { 1 };
                                break;
                            case "26":
                                numberList = new List<int> { 1, 2 };
                                break;
                            case "01":
                            case "02":
                            case "03":
                            case "04":
                            case "05":
                            case "06":
                            case "07":
                            case "08":
                            case "0B":
                            case "0C":
                            case "0D":
                            case "0E":
                            case "0F":
                            case "11":
                            case "12":
                            case "14":
                            case "15":
                            case "16":
                            case "17":
                            case "1A":
                            case "22":
                            case "23":
                            case "24":
                            case "25":
                                numberList = new List<int> { 4, 5 };
                                break;
                            case "4E":
                            case "48":
                                numberList = new List<int> { 4, 6, 7 };
                                break;
                            case "30":
                            case "41":
                            case "47":
                            case "2E": //play it safe with shadow master
                                numberList = new List<int> { 3, 4 };
                                break;
                            case "45":
                                numberList = new List<int> { 5, 6, 8 };
                                break;
                            case "4D":
                                numberList = new List<int> { 4, 6 };
                                break;
                            case "4A":
                            case "4B":
                            case "4C":
                                numberList = new List<int> { 3, 4, 6 };
                                break;
                            case "42":
                            case "43":
                                numberList = new List<int> { 3, 4, 7 };
                                break;
                            case "46":
                                numberList = new List<int> { 4 };
                                break;
                            case "54":
                                numberList = new List<int> { 3, 7 };
                                break;
                            case "4F":
                            case "44":
                                numberList = new List<int> { 2, 4 };
                                break;
                            case "51":
                                numberList = new List<int> { 3 };
                                break;
                        }
                        break;
                    case 4:
                        switch (fightingStyle)
                        {
                            case "27":
                            case "31":
                                numberList = new List<int> { 1 };
                                break;
                            case "26":
                                numberList = new List<int> { 1, 2 };
                                break;
                            case "01":
                            case "02":
                            case "03":
                            case "04":
                            case "05":
                            case "06":
                            case "07":
                            case "08":
                            case "0B":
                            case "0C":
                            case "0D":
                            case "0E":
                            case "0F":
                            case "11":
                            case "12":
                            case "14":
                            case "15":
                            case "16":
                            case "17":
                            case "1A":
                            case "22":
                            case "23":
                            case "24":
                            case "25":
                                numberList = new List<int> { 6, 8 };
                                break;
                            case "51":
                                numberList = new List<int> { 4, 5 };
                                break;
                            case "4D":
                            case "46":
                                numberList = new List<int> { 5, 7 };
                                break;
                            case "48":
                                numberList = new List<int> { 5, 8 };
                                break;
                            case "45":
                                numberList = new List<int> { 7 };
                                break;
                            case "4E":
                            case "4A":
                            case "4B":
                            case "4C":
                            case "30":
                            case "42":
                            case "43":
                            case "54":
                            case "41":
                            case "47":
                            case "4F":
                            case "44":
                            case "2E": //play it safe with shadow master
                                numberList = new List<int> { 5 };
                                break;
                        }
                        break;
                }
            }
            // Create a Random object
            Random rand = new Random();

            // Pick a random index
            int randomIndex = rand.Next(numberList.Count);

            // Get the number at that index
            int weaponNumber = numberList[randomIndex];

            //switch (fightingStyle)
            //{
            //    case "01":
            //    case "02":
            //    case "03":
            //    case "04":
            //    case "05":
            //    case "06":
            //    case "07":
            //    case "08":
            //    case "0B":
            //    case "0C":
            //    case "0D":
            //    case "0E":
            //    case "0F":
            //    case "11":
            //    case "12":
            //    case "14":
            //    case "15":
            //    case "16":
            //    case "17":
            //    case "1A":
            //    case "22":
            //    case "23":
            //    case "24":
            //    case "25":
            //    case "45":
            //    case "48":
            //    case "4D":
            //        weaponNumber = rnd.Next(1, 9);
            //        break;
            //    case "42":
            //    case "43":
            //    case "44":
            //    case "46":
            //    case "4E":
            //    case "54":
            //        weaponNumber = rnd.Next(1, 8);
            //        break;
            //    case "2E": //play it safe with shadow master
            //    case "41":
            //    case "47":
            //    case "4A":
            //    case "4B":
            //    case "4C":
            //    case "4F":
            //    case "51":
            //        weaponNumber = rnd.Next(1, 7);
            //        break;
            //    case "26":
            //        weaponNumber = rnd.Next(1, 3);
            //        break;
            //}

            switch (weaponNumber)
            {
                case 1:
                    selectedWeapon = "00";
                    break;
                case 2:
                    selectedWeapon = "01";
                    break;
                case 3:
                    selectedWeapon = "02";
                    break;
                case 4:
                    selectedWeapon = "03";
                    break;
                case 5:
                    selectedWeapon = "04";
                    break;
                case 6:
                    selectedWeapon = "05";
                    break;
                case 7:
                    selectedWeapon = "06";
                    break;
                case 8:
                    selectedWeapon = "07";
                    break;
            }

            return selectedWeapon;
        }

        public static string GetRandomStageData(int stageNumber)
        {
            string selectedStage = "";
            switch (stageNumber)
            {
                case 1:
                    selectedStage = "0000";
                    break;
                case 2:
                    selectedStage = "0001";
                    break;
                case 3:
                    selectedStage = "0101";
                    break;
                case 4:
                    selectedStage = "0201";
                    break;
                case 5:
                    selectedStage = "0002";
                    break;
                case 6:
                    selectedStage = "0003";
                    break;
                case 7:
                    selectedStage = "0004";
                    break;
                case 8:
                    selectedStage = "0005";
                    break;
                case 9:
                    selectedStage = "0006";
                    break;
                case 10:
                    selectedStage = "0007";
                    break;
                case 11:
                    selectedStage = "0008";
                    break;
                case 12:
                    selectedStage = "0009";
                    break;
                case 13:
                    selectedStage = "0109";
                    break;
                case 14:
                    selectedStage = "000A";
                    break;
                case 15:
                    selectedStage = "000B";
                    break;
                case 16:
                    selectedStage = "000C";
                    break;
                case 17:
                    selectedStage = "000D";
                    break;
                case 18:
                    selectedStage = "000E";
                    break;
                case 19:
                    selectedStage = "000F";
                    break;
                case 20:
                    selectedStage = "0010";
                    break;
                case 21:
                    selectedStage = "0110";
                    break;
                case 22:
                    selectedStage = "0210";
                    break;
                case 23:
                    selectedStage = "0011";
                    break;
                case 24:
                    selectedStage = "0012";
                    break;
                case 25:
                    selectedStage = "0013";
                    break;
                case 26:
                    selectedStage = "0014";
                    break;
                case 27:
                    selectedStage = "0015";
                    break;
                case 28:
                    selectedStage = "0016";
                    break;
                case 29:
                    selectedStage = "0017";
                    break;
                case 30:
                    selectedStage = "0018";
                    break;
                case 31:
                    selectedStage = "0019";
                    break;
            }

            return selectedStage;
        }

        public static string GetRandomCharacterData(int CharacterLocation, List<string> selectedItems)
        {
            Random rnd = new Random();
            string CharacterCode = "";
            switch (CharacterLocation)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                case 7:
                case 8:
                    //pick standard character
                    List<string> standardChars = new List<string> {
                                "010001","010101","010801","010901",
                                "020002","020102","020802","020902",
                                "030003","030103","030803","030903",
                                "040004","040104","040804","040904",
                                "050005","050105","050805","050905",
                                "060006","060106","060806","060906",
                                "070007","070107","070807","070907",
                                "080008","080108","080808","080908",
                                "0B000B","0B010B","0B080B","0B090B",
                                "0C000C","0C010C","0C080C","0C090C",
                                "0D000D","0D010D","0D080D","0D090D",
                                "0E000E","0E010E","0E080E","0E090E",
                                "0F000F","0F010F","0F080F","0F090F",
                                "110011","110111","110811","110911",
                                "120012","120112","120812","120912",
                                "140014","140114","140814","140914",
                                "150015","150115","150815","150915",
                                "160016","160116","160816","160916",
                                "170017","170117","170817","170917",
                                "1A001A","1A011A","1A081A","1A091A",
                                "220022","220122","220822","220922",
                                "230023","230123","230823","230923",
                                "240024","240124","240824","240924",
                                "250025","250125","250825","250925",
                                //"260026","260126","260826","260926",
                                "36000E","37000E","38000E","350024"
                            };
                    standardChars.RemoveAll(item => selectedItems.Contains(item));
                    CharacterCode = standardChars[rnd.Next(standardChars.Count)];

                    break;
                case 9:
                case 10:
                case 11:
                case 12:
                    //pick bonus character
                    List<string> bonusChars = new List<string> {
                                "300030","300130",
                                "410041","410141",
                                "420042","420142",
                                "430043","430143",
                                "440044","440144",
                                "450045","450145",
                                "460046","460146",
                                "470047","470147",
                                "480048","480148",
                                "4A004A","4A014A",
                                "4B004B","4B014B",
                                "4C004C","4C014C",
                                "4D004D","4D014D",
                                "4E004E","4E014E",
                                "4F004F","4F014F",
                                "510051","510151",
                                "540054","540154",
                                "E10245","E4004C",
                                "E0024E"
                            };
                    bonusChars.RemoveAll(item => selectedItems.Contains(item));
                    CharacterCode = bonusChars[rnd.Next(bonusChars.Count)];

                    break;
                case 13:
                case 14:
                    //pick tales of souls npc
                    List<string> tosNPCChars = new List<string> {
                                "1E000E", "280028", "290029", "2A002A", "2E002E",
                                "810048",
                                "840043",
                                "840143",
                                "840243",
                                "840343",
                                "85004D",
                                "86004E",
                                "870051",
                                "880044",
                                "890043",
                                "8A0042",
                                "8B004B",
                                "8B014B",
                                "8C0041",
                                "8C0141",
                                "8C0241",
                                "8C0341",
                                "8D0045",
                                "8E004B",
                                "8E014B",
                                "8F004C",
                                "90004C",
                                "91004C",
                                "91014C",
                                "91024C",
                                "920044",
                                "920144",
                                "920244",
                                "920344",
                                "930042",
                                "940045",
                                "940145",
                                "95004E",
                                "96004D",
                                "970047",
                                "990044"
                            };
                    tosNPCChars.RemoveAll(item => selectedItems.Contains(item));
                    CharacterCode = tosNPCChars[rnd.Next(tosNPCChars.Count)];

                    break;
                case 15:
                case 16:
                case 17:
                case 18:
                case 19:
                    //pick COTS character
                    List<string> cotsChars = new List<string> {
                                "A00041", "A10041",
                                "A00141", "A10141",
                                "A00241", "A10241",
                                "A20042", "A30042",
                                "A20142", "A30142",
                                "A20242", "A30242",
                                "A40043", "A50043",
                                "A40143", "A50143",
                                "A40243", "A50243",
                                "A60044", "A70044",
                                "A60144", "A70144",
                                "A60244", "A70244",
                                "A80045", "A90045",
                                "A80145", "A90145",
                                "A80245", "A90245",
                                "AA0046", "AB0046",
                                "AA0146", "AB0146",
                                "AA0246", "AB0246",
                                "AC0047", "AD0047",
                                "AC0147", "AD0147",
                                "AC0247", "AD0247",
                                "AE0048", "AF0048",
                                "AE0148", "AF0148",
                                "AE0248", "AF0248",
                                "B0004A", "B1004A",
                                "B0014A", "B1014A",
                                "B0024A", "B1024A",
                                "B2004B", "B3004B",
                                "B2014B", "B3014B",
                                "B2024B", "B3024B",
                                "B4004C", "B5004C",
                                "B4014C", "B5014C",
                                "B4024C", "B5024C",
                                "B6004D", "B7004D",
                                "B6014D", "B7014D",
                                "B6024D", "B7024D",
                                "B8004E", "B9004E",
                                "B8014E", "B9014E",
                                "B8024E", "B9024E",
                                "BA004F", "BB004F",
                                "BA014F", "BB014F",
                                "BA024F", "BB024F",
                                "BC0051", "BD0051",
                                "BC0151", "BD0151",
                                "BC0251", "BD0251",
                                "BE0054", "BF0054",
                                "BE0154", "BF0154",
                                "BE0254", "BF0254",
                                "C00030", "C10030",
                                "C00130", "C10130",
                                "C00230", "C10230",
                                "E7004D", "E7014D",
                                "E80054", "E80154",
                                "E90042", "E90142",
                                "EA0048", "EA0148",
                                "EB0048", "EB0148",
                                "EC0046", "EC0146",
                                "ED004E", "ED014E",
                                "EE0045", "EF0043", "EF0101", "E90242",
                            };
                    cotsChars.RemoveAll(item => selectedItems.Contains(item));
                    CharacterCode = cotsChars[rnd.Next(cotsChars.Count)];

                    break;
                case 20:
                    //pick COTS common units or the unused models from cutscenes
                    List<string> extraChars = new List<string> {
                                "E00345", /*"E00744", "E10746",*/
                                "A00341", /*"A20342", "A40343", "A60344", "A80345", "AA0346", "AC0347", "AE0348", "B0034A", "B2034B", "B4034C", "B6034D", "B8034E", "BA034F", "BC0351", "BE0354", "C00330",*/
                                "A10341", /*"A30342", "A50343", "A70344", "A90345", "AB0346", "AD0347", "AF0348", "B1034A", "B3034B", "B5034C", "B7034D", "B9034E", "BB034F", "BD0351", "BF0354", "C10330",*/
                                "A00441", /*"A20442", "A40443", "A60444", "A80445", "AA0446", "AC0447", "AE0448", "B0044A", "B2044B", "B4044C", "B6044D", "B8044E", "BA044F", "BC0451", "BE0454", "C00430",*/
                                "A10441", /*"A30442", "A50443", "A70444", "A90445", "AB0446", "AD0447", "AF0448", "B1044A", "B3044B", "B5044C", "B7044D", "B9044E", "BB044F", "BD0451", "BF0454", "C10430",*/
                                "A00541", /*"A20542", "A40543", "A60544", "A80545", "AA0546", "AC0547", "AE0548", "B0054A", "B2054B", "B4054C", "B6054D", "B8054E", "BA054F", "BC0551", "BE0554", "C00530",*/
                                "A10541", /*"A30542", "A50543", "A70544", "A90545", "AB0546", "AD0547", "AF0548", "B1054A", "B3054B", "B5054C", "B7054D", "B9054E", "BB054F", "BD0551", "BF0554", "C10530",*/
                                "A00641", /*"A20642", "A40643", "A60644", "A80645", "AA0646", "AC0647", "AE0648", "B0064A", "B2064B", "B4064C", "B6064D", "B8064E", "BA064F", "BC0651", "BE0654", "C00630",*/
                                "A10641", /*"A30642", "A50643", "A70644", "A90645", "AB0646", "AD0647", "AF0648", "B1064A", "B3064B", "B5064C", "B7064D", "B9064E", "BB064F", "BD0651", "BF0654", "C10630",*/
                                "A00741", /*"A20742", "A40743", "A60744", "A80745", "AA0746", "AC0747", "AE0748", "B0074A", "B2074B", "B4074C", "B6074D", "B8074E", "BA074F", "BC0751", "BE0754", "C00730",*/
                                "A10741", /*"A30742", "A50743", "A70744", "A90745", "AB0746", "AD0747", "AF0748", "B1074A", "B3074B", "B5074C", "B7074D", "B9074E", "BB074F", "BD0751", "BF0754", "C10730",*/
                            };
                    extraChars.RemoveAll(item => selectedItems.Contains(item));
                    CharacterCode = extraChars[rnd.Next(extraChars.Count)];
                    break;
            }

            return CharacterCode;
        }

        public static SurvivalList GetRandomModifiers(int randomPick, string stagePart)
        {
            SurvivalList modifiers = new SurvivalList();

            switch (stagePart)
            {
                case "1-3":
                    switch (randomPick)
                    {
                        case 1:
                            modifiers.weaponSpecial = ""; //Fire, Thunder, Paralysis, Cure etc
                            modifiers.guardianForce = "04"; //Keres have 05, Will o the wisp have 04
                            modifiers.stickyFeet = ""; //Slippery Feets
                            modifiers.speed = "3F84"; //3F80 default speed

                            modifiers.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                            modifiers.attack = ""; //Decrease/Increase Attack
                            modifiers.defense = ""; //Decrease/Increase Defense
                            modifiers.stealHp = ""; //Steal health from enemy
                            modifiers.pierceDamage = ""; //Damage inflicted thru guard
                            modifiers.weaponSize = "";
                            modifiers.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                            modifiers.counterRate = ""; //Increase Counter Chance
                            modifiers.nullCounter = ""; //Nullify Enemies Counters chance
                            modifiers.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                            modifiers.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                            modifiers.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                            modifiers.parryRegen = ""; //Recover Health when successfully Guard Impact
                            modifiers.guardBreakRate = ""; //Increase Guard Break Chance
                            modifiers.throwEscapeChance = ""; //Increase Throw Escape Rate
                            modifiers.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                            modifiers.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                            modifiers.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                            break;
                        case 2:
                            modifiers.weaponSpecial = "Poison P2"; //Fire, Thunder, Paralysis, Cure etc
                            modifiers.guardianForce = ""; //Keres have 05, Will o the wisp have 04
                            modifiers.stickyFeet = ""; //Slippery Feets
                            modifiers.speed = "3F80"; //3F80 default speed

                            modifiers.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                            modifiers.attack = ""; //Decrease/Increase Attack
                            modifiers.defense = ""; //Decrease/Increase Defense
                            modifiers.stealHp = ""; //Steal health from enemy
                            modifiers.pierceDamage = ""; //Damage inflicted thru guard
                            modifiers.weaponSize = "";
                            modifiers.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                            modifiers.counterRate = ""; //Increase Counter Chance
                            modifiers.nullCounter = ""; //Nullify Enemies Counters chance
                            modifiers.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                            modifiers.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                            modifiers.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                            modifiers.parryRegen = ""; //Recover Health when successfully Guard Impact
                            modifiers.guardBreakRate = ""; //Increase Guard Break Chance
                            modifiers.throwEscapeChance = ""; //Increase Throw Escape Rate
                            modifiers.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                            modifiers.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                            modifiers.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                            break;
                        case 3:
                            modifiers.weaponSpecial = ""; //Fire, Thunder, Paralysis, Cure etc
                            modifiers.guardianForce = ""; //Keres have 05, Will o the wisp have 04
                            modifiers.stickyFeet = ""; //Slippery Feets
                            modifiers.speed = "3F60"; //3F80 default speed

                            modifiers.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                            modifiers.attack = ""; //Decrease/Increase Attack
                            modifiers.defense = ""; //Decrease/Increase Defense
                            modifiers.stealHp = ""; //Steal health from enemy
                            modifiers.pierceDamage = ""; //Damage inflicted thru guard
                            modifiers.weaponSize = "";
                            modifiers.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                            modifiers.counterRate = ""; //Increase Counter Chance
                            modifiers.nullCounter = ""; //Nullify Enemies Counters chance
                            modifiers.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                            modifiers.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                            modifiers.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                            modifiers.parryRegen = ""; //Recover Health when successfully Guard Impact
                            modifiers.guardBreakRate = ""; //Increase Guard Break Chance
                            modifiers.throwEscapeChance = ""; //Increase Throw Escape Rate
                            modifiers.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                            modifiers.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                            modifiers.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                            break;
                        case 4:
                            modifiers.weaponSpecial = ""; //Fire, Thunder, Paralysis, Cure etc
                            modifiers.guardianForce = ""; //Keres have 05, Will o the wisp have 04
                            modifiers.stickyFeet = ""; //Slippery Feets
                            modifiers.speed = "3F80"; //3F80 default speed

                            modifiers.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                            modifiers.attack = "3F000000"; //Decrease/Increase Attack
                            modifiers.defense = ""; //Decrease/Increase Defense
                            modifiers.stealHp = ""; //Steal health from enemy
                            modifiers.pierceDamage = ""; //Damage inflicted thru guard
                            modifiers.weaponSize = "";
                            modifiers.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                            modifiers.counterRate = ""; //Increase Counter Chance
                            modifiers.nullCounter = ""; //Nullify Enemies Counters chance
                            modifiers.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                            modifiers.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                            modifiers.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                            modifiers.parryRegen = ""; //Recover Health when successfully Guard Impact
                            modifiers.guardBreakRate = ""; //Increase Guard Break Chance
                            modifiers.throwEscapeChance = ""; //Increase Throw Escape Rate
                            modifiers.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                            modifiers.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                            modifiers.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                            break;
                        case 5:
                            modifiers.weaponSpecial = ""; //Fire, Thunder, Paralysis, Cure etc
                            modifiers.guardianForce = ""; //Keres have 05, Will o the wisp have 04
                            modifiers.stickyFeet = ""; //Slippery Feets
                            modifiers.speed = "3F80"; //3F80 default speed

                            modifiers.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                            modifiers.attack = ""; //Decrease/Increase Attack
                            modifiers.defense = ""; //Decrease/Increase Defense
                            modifiers.stealHp = ""; //Steal health from enemy
                            modifiers.pierceDamage = ""; //Damage inflicted thru guard
                            modifiers.weaponSize = "3F600000";
                            modifiers.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                            modifiers.counterRate = ""; //Increase Counter Chance
                            modifiers.nullCounter = ""; //Nullify Enemies Counters chance
                            modifiers.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                            modifiers.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                            modifiers.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                            modifiers.parryRegen = ""; //Recover Health when successfully Guard Impact
                            modifiers.guardBreakRate = ""; //Increase Guard Break Chance
                            modifiers.throwEscapeChance = ""; //Increase Throw Escape Rate
                            modifiers.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                            modifiers.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                            modifiers.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                            break;
                        case 6:
                            modifiers.weaponSpecial = "Defense Down P2"; //Fire, Thunder, Paralysis, Cure etc
                            modifiers.guardianForce = ""; //Keres have 05, Will o the wisp have 04
                            modifiers.stickyFeet = ""; //Slippery Feets
                            modifiers.speed = "3F80"; //3F80 default speed

                            modifiers.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                            modifiers.attack = ""; //Decrease/Increase Attack
                            modifiers.defense = ""; //Decrease/Increase Defense
                            modifiers.stealHp = ""; //Steal health from enemy
                            modifiers.pierceDamage = ""; //Damage inflicted thru guard
                            modifiers.weaponSize = "";
                            modifiers.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                            modifiers.counterRate = ""; //Increase Counter Chance
                            modifiers.nullCounter = ""; //Nullify Enemies Counters chance
                            modifiers.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                            modifiers.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                            modifiers.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                            modifiers.parryRegen = ""; //Recover Health when successfully Guard Impact
                            modifiers.guardBreakRate = ""; //Increase Guard Break Chance
                            modifiers.throwEscapeChance = ""; //Increase Throw Escape Rate
                            modifiers.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                            modifiers.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                            modifiers.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                            break;
                        case 7:
                            modifiers.weaponSpecial = "Smash P2"; //Fire, Thunder, Paralysis, Cure etc
                            modifiers.guardianForce = ""; //Keres have 05, Will o the wisp have 04
                            modifiers.stickyFeet = ""; //Slippery Feets
                            modifiers.speed = "3F80"; //3F80 default speed

                            modifiers.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                            modifiers.attack = ""; //Decrease/Increase Attack
                            modifiers.defense = "3F900000"; //Decrease/Increase Defense
                            modifiers.stealHp = ""; //Steal health from enemy
                            modifiers.pierceDamage = ""; //Damage inflicted thru guard
                            modifiers.weaponSize = "";
                            modifiers.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                            modifiers.counterRate = ""; //Increase Counter Chance
                            modifiers.nullCounter = ""; //Nullify Enemies Counters chance
                            modifiers.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                            modifiers.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                            modifiers.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                            modifiers.parryRegen = ""; //Recover Health when successfully Guard Impact
                            modifiers.guardBreakRate = ""; //Increase Guard Break Chance
                            modifiers.throwEscapeChance = ""; //Increase Throw Escape Rate
                            modifiers.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                            modifiers.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                            modifiers.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                            break;
                        case 8:
                            modifiers.weaponSpecial = "Aerial Wind P2"; //Fire, Thunder, Paralysis, Cure etc
                            modifiers.guardianForce = ""; //Keres have 05, Will o the wisp have 04
                            modifiers.stickyFeet = ""; //Slippery Feets
                            modifiers.speed = "3F80"; //3F80 default speed

                            modifiers.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                            modifiers.attack = ""; //Decrease/Increase Attack
                            modifiers.defense = "3FA00000"; //Decrease/Increase Defense
                            modifiers.stealHp = ""; //Steal health from enemy
                            modifiers.pierceDamage = ""; //Damage inflicted thru guard
                            modifiers.weaponSize = "";
                            modifiers.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                            modifiers.counterRate = ""; //Increase Counter Chance
                            modifiers.nullCounter = ""; //Nullify Enemies Counters chance
                            modifiers.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                            modifiers.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                            modifiers.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                            modifiers.parryRegen = ""; //Recover Health when successfully Guard Impact
                            modifiers.guardBreakRate = ""; //Increase Guard Break Chance
                            modifiers.throwEscapeChance = ""; //Increase Throw Escape Rate
                            modifiers.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                            modifiers.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                            modifiers.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                            break;
                    }
                    break;
                case "4-9":
                    switch (randomPick)
                    {
                        case 1:
                            modifiers.weaponSpecial = ""; //Fire, Thunder, Paralysis, Cure etc
                            modifiers.guardianForce = ""; //Keres have 05, Will o the wisp have 04
                            modifiers.stickyFeet = ""; //Slippery Feets
                            modifiers.speed = "3F80"; //3F80 default speed

                            modifiers.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                            modifiers.attack = ""; //Decrease/Increase Attack
                            modifiers.defense = ""; //Decrease/Increase Defense
                            modifiers.stealHp = ""; //Steal health from enemy
                            modifiers.pierceDamage = ""; //Damage inflicted thru guard
                            modifiers.weaponSize = "";
                            modifiers.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                            modifiers.counterRate = ""; //Increase Counter Chance
                            modifiers.nullCounter = ""; //Nullify Enemies Counters chance
                            modifiers.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                            modifiers.autoGuardImpact = "3DCCCCCB"; //Automatically Guard Impact some attacks
                            modifiers.parryDamage = "3E000000"; //Increase Damage Received by Opponent when successfully Guard Impact
                            modifiers.parryRegen = "3F000000"; //Recover Health when successfully Guard Impact
                            modifiers.guardBreakRate = ""; //Increase Guard Break Chance
                            modifiers.throwEscapeChance = ""; //Increase Throw Escape Rate
                            modifiers.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                            modifiers.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                            modifiers.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                            break;
                        case 2:
                            modifiers.weaponSpecial = "All Guard Break"; //Fire, Thunder, Paralysis, Cure etc
                            modifiers.guardianForce = ""; //Keres have 05, Will o the wisp have 04
                            modifiers.stickyFeet = ""; //Slippery Feets
                            modifiers.speed = "3F82"; //3F80 default speed

                            modifiers.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                            modifiers.attack = ""; //Decrease/Increase Attack
                            modifiers.defense = ""; //Decrease/Increase Defense
                            modifiers.stealHp = ""; //Steal health from enemy
                            modifiers.pierceDamage = ""; //Damage inflicted thru guard
                            modifiers.weaponSize = "";
                            modifiers.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                            modifiers.counterRate = ""; //Increase Counter Chance
                            modifiers.nullCounter = ""; //Nullify Enemies Counters chance
                            modifiers.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                            modifiers.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                            modifiers.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                            modifiers.parryRegen = ""; //Recover Health when successfully Guard Impact
                            modifiers.guardBreakRate = ""; //Increase Guard Break Chance
                            modifiers.throwEscapeChance = ""; //Increase Throw Escape Rate
                            modifiers.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                            modifiers.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                            modifiers.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                            break;
                        case 3:
                            modifiers.weaponSpecial = ""; //Fire, Thunder, Paralysis, Cure etc
                            modifiers.guardianForce = ""; //Keres have 05, Will o the wisp have 04
                            modifiers.stickyFeet = ""; //Slippery Feets
                            modifiers.speed = "3F84"; //3F80 default speed

                            modifiers.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                            modifiers.attack = ""; //Decrease/Increase Attack
                            modifiers.defense = ""; //Decrease/Increase Defense
                            modifiers.stealHp = ""; //Steal health from enemy
                            modifiers.pierceDamage = ""; //Damage inflicted thru guard
                            modifiers.weaponSize = "";
                            modifiers.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                            modifiers.counterRate = ""; //Increase Counter Chance
                            modifiers.nullCounter = ""; //Nullify Enemies Counters chance
                            modifiers.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                            modifiers.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                            modifiers.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                            modifiers.parryRegen = ""; //Recover Health when successfully Guard Impact
                            modifiers.guardBreakRate = ""; //Increase Guard Break Chance
                            modifiers.throwEscapeChance = ""; //Increase Throw Escape Rate
                            modifiers.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                            modifiers.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                            modifiers.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                            break;
                        case 4:
                            modifiers.weaponSpecial = "Smash"; //Fire, Thunder, Paralysis, Cure etc
                            modifiers.guardianForce = ""; //Keres have 05, Will o the wisp have 04
                            modifiers.stickyFeet = ""; //Slippery Feets
                            modifiers.speed = "3F80"; //3F80 default speed

                            modifiers.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                            modifiers.attack = "3F900000"; //Decrease/Increase Attack
                            modifiers.defense = ""; //Decrease/Increase Defense
                            modifiers.stealHp = ""; //Steal health from enemy
                            modifiers.pierceDamage = ""; //Damage inflicted thru guard
                            modifiers.weaponSize = "";
                            modifiers.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                            modifiers.counterRate = ""; //Increase Counter Chance
                            modifiers.nullCounter = ""; //Nullify Enemies Counters chance
                            modifiers.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                            modifiers.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                            modifiers.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                            modifiers.parryRegen = ""; //Recover Health when successfully Guard Impact
                            modifiers.guardBreakRate = ""; //Increase Guard Break Chance
                            modifiers.throwEscapeChance = ""; //Increase Throw Escape Rate
                            modifiers.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                            modifiers.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                            modifiers.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                            break;
                        case 5:
                            modifiers.weaponSpecial = ""; //Fire, Thunder, Paralysis, Cure etc
                            modifiers.guardianForce = ""; //Keres have 05, Will o the wisp have 04
                            modifiers.stickyFeet = ""; //Slippery Feets
                            modifiers.speed = "3F80"; //3F80 default speed

                            modifiers.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                            modifiers.attack = ""; //Decrease/Increase Attack
                            modifiers.defense = ""; //Decrease/Increase Defense
                            modifiers.stealHp = "3F000000"; //Steal health from enemy
                            modifiers.pierceDamage = ""; //Damage inflicted thru guard
                            modifiers.weaponSize = "";
                            modifiers.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                            modifiers.counterRate = ""; //Increase Counter Chance
                            modifiers.nullCounter = ""; //Nullify Enemies Counters chance
                            modifiers.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                            modifiers.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                            modifiers.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                            modifiers.parryRegen = ""; //Recover Health when successfully Guard Impact
                            modifiers.guardBreakRate = ""; //Increase Guard Break Chance
                            modifiers.throwEscapeChance = ""; //Increase Throw Escape Rate
                            modifiers.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                            modifiers.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                            modifiers.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                            break;
                        case 6:
                            modifiers.weaponSpecial = "Minus Guard"; //Fire, Thunder, Paralysis, Cure etc
                            modifiers.guardianForce = ""; //Keres have 05, Will o the wisp have 04
                            modifiers.stickyFeet = ""; //Slippery Feets
                            modifiers.speed = "3F80"; //3F80 default speed

                            modifiers.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                            modifiers.attack = ""; //Decrease/Increase Attack
                            modifiers.defense = ""; //Decrease/Increase Defense
                            modifiers.stealHp = ""; //Steal health from enemy
                            modifiers.pierceDamage = ""; //Damage inflicted thru guard
                            modifiers.weaponSize = "";
                            modifiers.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                            modifiers.counterRate = ""; //Increase Counter Chance
                            modifiers.nullCounter = ""; //Nullify Enemies Counters chance
                            modifiers.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                            modifiers.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                            modifiers.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                            modifiers.parryRegen = ""; //Recover Health when successfully Guard Impact
                            modifiers.guardBreakRate = ""; //Increase Guard Break Chance
                            modifiers.throwEscapeChance = ""; //Increase Throw Escape Rate
                            modifiers.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                            modifiers.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                            modifiers.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                            break;
                        case 7:
                            modifiers.weaponSpecial = "Poison"; //Fire, Thunder, Paralysis, Cure etc
                            modifiers.guardianForce = ""; //Keres have 05, Will o the wisp have 04
                            modifiers.stickyFeet = ""; //Slippery Feets
                            modifiers.speed = "3F80"; //3F80 default speed

                            modifiers.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                            modifiers.attack = ""; //Decrease/Increase Attack
                            modifiers.defense = ""; //Decrease/Increase Defense
                            modifiers.stealHp = ""; //Steal health from enemy
                            modifiers.pierceDamage = ""; //Damage inflicted thru guard
                            modifiers.weaponSize = "";
                            modifiers.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                            modifiers.counterRate = ""; //Increase Counter Chance
                            modifiers.nullCounter = ""; //Nullify Enemies Counters chance
                            modifiers.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                            modifiers.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                            modifiers.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                            modifiers.parryRegen = ""; //Recover Health when successfully Guard Impact
                            modifiers.guardBreakRate = ""; //Increase Guard Break Chance
                            modifiers.throwEscapeChance = ""; //Increase Throw Escape Rate
                            modifiers.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                            modifiers.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                            modifiers.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                            break;
                        case 8:
                            modifiers.weaponSpecial = "Cure"; //Fire, Thunder, Paralysis, Cure etc
                            modifiers.guardianForce = ""; //Keres have 05, Will o the wisp have 04
                            modifiers.stickyFeet = ""; //Slippery Feets
                            modifiers.speed = "3F80"; //3F80 default speed

                            modifiers.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                            modifiers.attack = ""; //Decrease/Increase Attack
                            modifiers.defense = ""; //Decrease/Increase Defense
                            modifiers.stealHp = ""; //Steal health from enemy
                            modifiers.pierceDamage = ""; //Damage inflicted thru guard
                            modifiers.weaponSize = "";
                            modifiers.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                            modifiers.counterRate = ""; //Increase Counter Chance
                            modifiers.nullCounter = ""; //Nullify Enemies Counters chance
                            modifiers.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                            modifiers.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                            modifiers.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                            modifiers.parryRegen = ""; //Recover Health when successfully Guard Impact
                            modifiers.guardBreakRate = ""; //Increase Guard Break Chance
                            modifiers.throwEscapeChance = ""; //Increase Throw Escape Rate
                            modifiers.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                            modifiers.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                            modifiers.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                            break;
                        case 9:
                            modifiers.weaponSpecial = "Defense Up"; //Fire, Thunder, Paralysis, Cure etc
                            modifiers.guardianForce = ""; //Keres have 05, Will o the wisp have 04
                            modifiers.stickyFeet = ""; //Slippery Feets
                            modifiers.speed = "3F80"; //3F80 default speed

                            modifiers.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                            modifiers.attack = ""; //Decrease/Increase Attack
                            modifiers.defense = ""; //Decrease/Increase Defense
                            modifiers.stealHp = ""; //Steal health from enemy
                            modifiers.pierceDamage = ""; //Damage inflicted thru guard
                            modifiers.weaponSize = "";
                            modifiers.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                            modifiers.counterRate = ""; //Increase Counter Chance
                            modifiers.nullCounter = ""; //Nullify Enemies Counters chance
                            modifiers.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                            modifiers.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                            modifiers.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                            modifiers.parryRegen = ""; //Recover Health when successfully Guard Impact
                            modifiers.guardBreakRate = ""; //Increase Guard Break Chance
                            modifiers.throwEscapeChance = ""; //Increase Throw Escape Rate
                            modifiers.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                            modifiers.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                            modifiers.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                            break;
                        case 10:
                            modifiers.weaponSpecial = "Glue"; //Fire, Thunder, Paralysis, Cure etc
                            modifiers.guardianForce = ""; //Keres have 05, Will o the wisp have 04
                            modifiers.stickyFeet = ""; //Slippery Feets
                            modifiers.speed = "3F80"; //3F80 default speed

                            modifiers.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                            modifiers.attack = ""; //Decrease/Increase Attack
                            modifiers.defense = ""; //Decrease/Increase Defense
                            modifiers.stealHp = ""; //Steal health from enemy
                            modifiers.pierceDamage = ""; //Damage inflicted thru guard
                            modifiers.weaponSize = "";
                            modifiers.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                            modifiers.counterRate = ""; //Increase Counter Chance
                            modifiers.nullCounter = ""; //Nullify Enemies Counters chance
                            modifiers.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                            modifiers.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                            modifiers.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                            modifiers.parryRegen = ""; //Recover Health when successfully Guard Impact
                            modifiers.guardBreakRate = ""; //Increase Guard Break Chance
                            modifiers.throwEscapeChance = ""; //Increase Throw Escape Rate
                            modifiers.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                            modifiers.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                            modifiers.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                            break;
                        case 11:
                            modifiers.weaponSpecial = "Separate"; //Fire, Thunder, Paralysis, Cure etc
                            modifiers.guardianForce = ""; //Keres have 05, Will o the wisp have 04
                            modifiers.stickyFeet = ""; //Slippery Feets
                            modifiers.speed = "3F80"; //3F80 default speed

                            modifiers.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                            modifiers.attack = ""; //Decrease/Increase Attack
                            modifiers.defense = ""; //Decrease/Increase Defense
                            modifiers.stealHp = ""; //Steal health from enemy
                            modifiers.pierceDamage = ""; //Damage inflicted thru guard
                            modifiers.weaponSize = "";
                            modifiers.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                            modifiers.counterRate = ""; //Increase Counter Chance
                            modifiers.nullCounter = ""; //Nullify Enemies Counters chance
                            modifiers.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                            modifiers.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                            modifiers.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                            modifiers.parryRegen = ""; //Recover Health when successfully Guard Impact
                            modifiers.guardBreakRate = ""; //Increase Guard Break Chance
                            modifiers.throwEscapeChance = ""; //Increase Throw Escape Rate
                            modifiers.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                            modifiers.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                            modifiers.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                            break;
                    }
                    break;
                case "10-15":
                    switch (randomPick)
                    {
                        case 1:
                            modifiers.weaponSpecial = "Paralysis"; //Fire, Thunder, Paralysis, Cure etc
                            modifiers.guardianForce = ""; //Keres have 05, Will o the wisp have 04
                            modifiers.stickyFeet = ""; //Slippery Feets
                            modifiers.speed = "3F84"; //3F80 default speed

                            modifiers.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                            modifiers.attack = ""; //Decrease/Increase Attack
                            modifiers.defense = ""; //Decrease/Increase Defense
                            modifiers.stealHp = ""; //Steal health from enemy
                            modifiers.pierceDamage = ""; //Damage inflicted thru guard
                            modifiers.weaponSize = "";
                            modifiers.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                            modifiers.counterRate = ""; //Increase Counter Chance
                            modifiers.nullCounter = ""; //Nullify Enemies Counters chance
                            modifiers.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                            modifiers.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                            modifiers.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                            modifiers.parryRegen = ""; //Recover Health when successfully Guard Impact
                            modifiers.guardBreakRate = ""; //Increase Guard Break Chance
                            modifiers.throwEscapeChance = ""; //Increase Throw Escape Rate
                            modifiers.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                            modifiers.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                            modifiers.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                            break;
                        case 2:
                            modifiers.weaponSpecial = ""; //Fire, Thunder, Paralysis, Cure etc
                            modifiers.guardianForce = ""; //Keres have 05, Will o the wisp have 04
                            modifiers.stickyFeet = ""; //Slippery Feets
                            modifiers.speed = "3F80"; //3F80 default speed

                            modifiers.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                            modifiers.attack = ""; //Decrease/Increase Attack
                            modifiers.defense = ""; //Decrease/Increase Defense
                            modifiers.stealHp = ""; //Steal health from enemy
                            modifiers.pierceDamage = "3F000000"; //Damage inflicted thru guard
                            modifiers.weaponSize = "";
                            modifiers.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                            modifiers.counterRate = ""; //Increase Counter Chance
                            modifiers.nullCounter = ""; //Nullify Enemies Counters chance
                            modifiers.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                            modifiers.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                            modifiers.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                            modifiers.parryRegen = ""; //Recover Health when successfully Guard Impact
                            modifiers.guardBreakRate = "3F000000"; //Increase Guard Break Chance
                            modifiers.throwEscapeChance = ""; //Increase Throw Escape Rate
                            modifiers.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                            modifiers.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                            modifiers.hpRegenOrDrainOnAtk = "C0000000"; //Drain/Recover Health when Attacking
                            break;
                        case 3:
                            modifiers.weaponSpecial = ""; //Fire, Thunder, Paralysis, Cure etc
                            modifiers.guardianForce = ""; //Keres have 05, Will o the wisp have 04
                            modifiers.stickyFeet = ""; //Slippery Feets
                            modifiers.speed = "3F80"; //3F80 default speed

                            modifiers.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                            modifiers.attack = ""; //Decrease/Increase Attack
                            modifiers.defense = ""; //Decrease/Increase Defense
                            modifiers.stealHp = ""; //Steal health from enemy
                            modifiers.pierceDamage = ""; //Damage inflicted thru guard
                            modifiers.weaponSize = "3FE00000";
                            modifiers.atkPushForce = "40000000"; //Decrease/Increase Attack Pushback Force
                            modifiers.counterRate = "3F000000"; //Increase Counter Chance
                            modifiers.nullCounter = "3F200000"; //Nullify Enemies Counters chance
                            modifiers.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                            modifiers.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                            modifiers.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                            modifiers.parryRegen = ""; //Recover Health when successfully Guard Impact
                            modifiers.guardBreakRate = ""; //Increase Guard Break Chance
                            modifiers.throwEscapeChance = ""; //Increase Throw Escape Rate
                            modifiers.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                            modifiers.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                            modifiers.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                            break;
                        case 4:
                            modifiers.weaponSpecial = ""; //Fire, Thunder, Paralysis, Cure etc
                            modifiers.guardianForce = ""; //Keres have 05, Will o the wisp have 04
                            modifiers.stickyFeet = ""; //Slippery Feets
                            modifiers.speed = "3F82"; //3F80 default speed

                            modifiers.weaponEffect = "00080000"; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                            modifiers.attack = ""; //Decrease/Increase Attack
                            modifiers.defense = ""; //Decrease/Increase Defense
                            modifiers.stealHp = ""; //Steal health from enemy
                            modifiers.pierceDamage = ""; //Damage inflicted thru guard
                            modifiers.weaponSize = "";
                            modifiers.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                            modifiers.counterRate = ""; //Increase Counter Chance
                            modifiers.nullCounter = ""; //Nullify Enemies Counters chance
                            modifiers.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                            modifiers.autoGuardImpact = "3DCCCCCB"; //Automatically Guard Impact some attacks
                            modifiers.parryDamage = "3F000000"; //Increase Damage Received by Opponent when successfully Guard Impact
                            modifiers.parryRegen = "38000000"; //Recover Health when successfully Guard Impact
                            modifiers.guardBreakRate = ""; //Increase Guard Break Chance
                            modifiers.throwEscapeChance = "40000000"; //Increase Throw Escape Rate
                            modifiers.ringOutEscapeChance = "40000000"; //Increase Ring-Out Escape Rate
                            modifiers.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                            modifiers.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                            break;
                        case 5:
                            modifiers.weaponSpecial = ""; //Fire, Thunder, Paralysis, Cure etc
                            modifiers.guardianForce = ""; //Keres have 05, Will o the wisp have 04
                            modifiers.stickyFeet = ""; //Slippery Feets
                            modifiers.speed = "3F80"; //3F80 default speed

                            modifiers.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                            modifiers.attack = "3FA00000"; //Decrease/Increase Attack
                            modifiers.defense = ""; //Decrease/Increase Defense
                            modifiers.stealHp = ""; //Steal health from enemy
                            modifiers.pierceDamage = ""; //Damage inflicted thru guard
                            modifiers.weaponSize = "";
                            modifiers.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                            modifiers.counterRate = ""; //Increase Counter Chance
                            modifiers.nullCounter = ""; //Nullify Enemies Counters chance
                            modifiers.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                            modifiers.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                            modifiers.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                            modifiers.parryRegen = ""; //Recover Health when successfully Guard Impact
                            modifiers.guardBreakRate = ""; //Increase Guard Break Chance
                            modifiers.throwEscapeChance = ""; //Increase Throw Escape Rate
                            modifiers.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                            modifiers.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                            modifiers.hpRegenOrDrainOnAtk = "C1000000"; //Drain/Recover Health when Attacking
                            break;
                        case 6:
                            modifiers.weaponSpecial = "Super Poison"; //Fire, Thunder, Paralysis, Cure etc
                            modifiers.guardianForce = ""; //Keres have 05, Will o the wisp have 04
                            modifiers.stickyFeet = ""; //Slippery Feets
                            modifiers.speed = "3F80"; //3F80 default speed

                            modifiers.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                            modifiers.attack = ""; //Decrease/Increase Attack
                            modifiers.defense = ""; //Decrease/Increase Defense
                            modifiers.stealHp = ""; //Steal health from enemy
                            modifiers.pierceDamage = ""; //Damage inflicted thru guard
                            modifiers.weaponSize = "";
                            modifiers.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                            modifiers.counterRate = ""; //Increase Counter Chance
                            modifiers.nullCounter = ""; //Nullify Enemies Counters chance
                            modifiers.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                            modifiers.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                            modifiers.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                            modifiers.parryRegen = ""; //Recover Health when successfully Guard Impact
                            modifiers.guardBreakRate = ""; //Increase Guard Break Chance
                            modifiers.throwEscapeChance = ""; //Increase Throw Escape Rate
                            modifiers.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                            modifiers.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                            modifiers.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                            break;
                        case 7:
                            modifiers.weaponSpecial = "Super Cure"; //Fire, Thunder, Paralysis, Cure etc
                            modifiers.guardianForce = ""; //Keres have 05, Will o the wisp have 04
                            modifiers.stickyFeet = ""; //Slippery Feets
                            modifiers.speed = "3F80"; //3F80 default speed

                            modifiers.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                            modifiers.attack = ""; //Decrease/Increase Attack
                            modifiers.defense = ""; //Decrease/Increase Defense
                            modifiers.stealHp = ""; //Steal health from enemy
                            modifiers.pierceDamage = ""; //Damage inflicted thru guard
                            modifiers.weaponSize = "";
                            modifiers.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                            modifiers.counterRate = ""; //Increase Counter Chance
                            modifiers.nullCounter = ""; //Nullify Enemies Counters chance
                            modifiers.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                            modifiers.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                            modifiers.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                            modifiers.parryRegen = ""; //Recover Health when successfully Guard Impact
                            modifiers.guardBreakRate = ""; //Increase Guard Break Chance
                            modifiers.throwEscapeChance = ""; //Increase Throw Escape Rate
                            modifiers.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                            modifiers.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                            modifiers.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                            break;
                        case 8:
                            modifiers.weaponSpecial = "Defense Down"; //Fire, Thunder, Paralysis, Cure etc
                            modifiers.guardianForce = ""; //Keres have 05, Will o the wisp have 04
                            modifiers.stickyFeet = ""; //Slippery Feets
                            modifiers.speed = "3F80"; //3F80 default speed

                            modifiers.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                            modifiers.attack = ""; //Decrease/Increase Attack
                            modifiers.defense = ""; //Decrease/Increase Defense
                            modifiers.stealHp = ""; //Steal health from enemy
                            modifiers.pierceDamage = ""; //Damage inflicted thru guard
                            modifiers.weaponSize = "";
                            modifiers.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                            modifiers.counterRate = ""; //Increase Counter Chance
                            modifiers.nullCounter = ""; //Nullify Enemies Counters chance
                            modifiers.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                            modifiers.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                            modifiers.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                            modifiers.parryRegen = ""; //Recover Health when successfully Guard Impact
                            modifiers.guardBreakRate = ""; //Increase Guard Break Chance
                            modifiers.throwEscapeChance = ""; //Increase Throw Escape Rate
                            modifiers.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                            modifiers.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                            modifiers.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                            break;
                        case 9:
                            modifiers.weaponSpecial = "Whirlwind"; //Fire, Thunder, Paralysis, Cure etc
                            modifiers.guardianForce = ""; //Keres have 05, Will o the wisp have 04
                            modifiers.stickyFeet = ""; //Slippery Feets
                            modifiers.speed = "3F80"; //3F80 default speed

                            modifiers.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                            modifiers.attack = ""; //Decrease/Increase Attack
                            modifiers.defense = ""; //Decrease/Increase Defense
                            modifiers.stealHp = ""; //Steal health from enemy
                            modifiers.pierceDamage = ""; //Damage inflicted thru guard
                            modifiers.weaponSize = "";
                            modifiers.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                            modifiers.counterRate = ""; //Increase Counter Chance
                            modifiers.nullCounter = ""; //Nullify Enemies Counters chance
                            modifiers.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                            modifiers.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                            modifiers.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                            modifiers.parryRegen = ""; //Recover Health when successfully Guard Impact
                            modifiers.guardBreakRate = ""; //Increase Guard Break Chance
                            modifiers.throwEscapeChance = ""; //Increase Throw Escape Rate
                            modifiers.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                            modifiers.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                            modifiers.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                            break;
                        case 10:
                            modifiers.weaponSpecial = "Aerial Wind"; //Fire, Thunder, Paralysis, Cure etc
                            modifiers.guardianForce = ""; //Keres have 05, Will o the wisp have 04
                            modifiers.stickyFeet = ""; //Slippery Feets
                            modifiers.speed = "3F80"; //3F80 default speed

                            modifiers.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                            modifiers.attack = ""; //Decrease/Increase Attack
                            modifiers.defense = ""; //Decrease/Increase Defense
                            modifiers.stealHp = ""; //Steal health from enemy
                            modifiers.pierceDamage = ""; //Damage inflicted thru guard
                            modifiers.weaponSize = "";
                            modifiers.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                            modifiers.counterRate = ""; //Increase Counter Chance
                            modifiers.nullCounter = ""; //Nullify Enemies Counters chance
                            modifiers.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                            modifiers.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                            modifiers.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                            modifiers.parryRegen = ""; //Recover Health when successfully Guard Impact
                            modifiers.guardBreakRate = ""; //Increase Guard Break Chance
                            modifiers.throwEscapeChance = ""; //Increase Throw Escape Rate
                            modifiers.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                            modifiers.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                            modifiers.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                            break;
                        case 11:
                            modifiers.weaponSpecial = "Reserve Offense Up"; //Fire, Thunder, Paralysis, Cure etc
                            modifiers.guardianForce = ""; //Keres have 05, Will o the wisp have 04
                            modifiers.stickyFeet = ""; //Slippery Feets
                            modifiers.speed = "3F80"; //3F80 default speed

                            modifiers.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                            modifiers.attack = ""; //Decrease/Increase Attack
                            modifiers.defense = ""; //Decrease/Increase Defense
                            modifiers.stealHp = ""; //Steal health from enemy
                            modifiers.pierceDamage = ""; //Damage inflicted thru guard
                            modifiers.weaponSize = "";
                            modifiers.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                            modifiers.counterRate = ""; //Increase Counter Chance
                            modifiers.nullCounter = ""; //Nullify Enemies Counters chance
                            modifiers.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                            modifiers.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                            modifiers.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                            modifiers.parryRegen = ""; //Recover Health when successfully Guard Impact
                            modifiers.guardBreakRate = ""; //Increase Guard Break Chance
                            modifiers.throwEscapeChance = ""; //Increase Throw Escape Rate
                            modifiers.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                            modifiers.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                            modifiers.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                            break;
                    }
                    break;
                case "16-19":
                    switch (randomPick)
                    {
                        case 1:
                            modifiers.weaponSpecial = "All Unblockable"; //Fire, Thunder, Paralysis, Cure etc
                            modifiers.guardianForce = ""; //Keres have 05, Will o the wisp have 04
                            modifiers.stickyFeet = ""; //Slippery Feets
                            modifiers.speed = "3F80"; //3F80 default speed

                            modifiers.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                            modifiers.attack = ""; //Decrease/Increase Attack
                            modifiers.defense = "3FB00000"; //Decrease/Increase Defense
                            modifiers.stealHp = ""; //Steal health from enemy
                            modifiers.pierceDamage = ""; //Damage inflicted thru guard
                            modifiers.weaponSize = "";
                            modifiers.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                            modifiers.counterRate = ""; //Increase Counter Chance
                            modifiers.nullCounter = ""; //Nullify Enemies Counters chance
                            modifiers.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                            modifiers.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                            modifiers.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                            modifiers.parryRegen = ""; //Recover Health when successfully Guard Impact
                            modifiers.guardBreakRate = ""; //Increase Guard Break Chance
                            modifiers.throwEscapeChance = ""; //Increase Throw Escape Rate
                            modifiers.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                            modifiers.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                            modifiers.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                            break;
                        case 2:
                            modifiers.weaponSpecial = ""; //Fire, Thunder, Paralysis, Cure etc
                            modifiers.guardianForce = "05"; //Keres have 05, Will o the wisp have 04
                            modifiers.stickyFeet = ""; //Slippery Feets
                            modifiers.speed = "3F78"; //3F80 default speed

                            modifiers.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                            modifiers.attack = ""; //Decrease/Increase Attack
                            modifiers.defense = ""; //Decrease/Increase Defense
                            modifiers.stealHp = ""; //Steal health from enemy
                            modifiers.pierceDamage = ""; //Damage inflicted thru guard
                            modifiers.weaponSize = "";
                            modifiers.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                            modifiers.counterRate = ""; //Increase Counter Chance
                            modifiers.nullCounter = ""; //Nullify Enemies Counters chance
                            modifiers.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                            modifiers.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                            modifiers.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                            modifiers.parryRegen = ""; //Recover Health when successfully Guard Impact
                            modifiers.guardBreakRate = ""; //Increase Guard Break Chance
                            modifiers.throwEscapeChance = ""; //Increase Throw Escape Rate
                            modifiers.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                            modifiers.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                            modifiers.hpRegenOrDrainOnAtk = "41000000"; //Drain/Recover Health when Attacking
                            break;
                        case 3:
                            modifiers.weaponSpecial = "Mega Cure"; //Fire, Thunder, Paralysis, Cure etc
                            modifiers.guardianForce = ""; //Keres have 05, Will o the wisp have 04
                            modifiers.stickyFeet = ""; //Slippery Feets
                            modifiers.speed = "3F80"; //3F80 default speed

                            modifiers.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                            modifiers.attack = ""; //Decrease/Increase Attack
                            modifiers.defense = ""; //Decrease/Increase Defense
                            modifiers.stealHp = ""; //Steal health from enemy
                            modifiers.pierceDamage = ""; //Damage inflicted thru guard
                            modifiers.weaponSize = "";
                            modifiers.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                            modifiers.counterRate = ""; //Increase Counter Chance
                            modifiers.nullCounter = ""; //Nullify Enemies Counters chance
                            modifiers.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                            modifiers.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                            modifiers.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                            modifiers.parryRegen = ""; //Recover Health when successfully Guard Impact
                            modifiers.guardBreakRate = ""; //Increase Guard Break Chance
                            modifiers.throwEscapeChance = ""; //Increase Throw Escape Rate
                            modifiers.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                            modifiers.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                            modifiers.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                            break;
                        case 4:
                            modifiers.weaponSpecial = ""; //Fire, Thunder, Paralysis, Cure etc
                            modifiers.guardianForce = ""; //Keres have 05, Will o the wisp have 04
                            modifiers.stickyFeet = ""; //Slippery Feets
                            modifiers.speed = "3F90"; //3F80 default speed

                            modifiers.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                            modifiers.attack = ""; //Decrease/Increase Attack
                            modifiers.defense = ""; //Decrease/Increase Defense
                            modifiers.stealHp = ""; //Steal health from enemy
                            modifiers.pierceDamage = ""; //Damage inflicted thru guard
                            modifiers.weaponSize = "";
                            modifiers.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                            modifiers.counterRate = ""; //Increase Counter Chance
                            modifiers.nullCounter = ""; //Nullify Enemies Counters chance
                            modifiers.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                            modifiers.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                            modifiers.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                            modifiers.parryRegen = ""; //Recover Health when successfully Guard Impact
                            modifiers.guardBreakRate = ""; //Increase Guard Break Chance
                            modifiers.throwEscapeChance = ""; //Increase Throw Escape Rate
                            modifiers.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                            modifiers.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                            modifiers.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                            break;
                        case 5:
                            modifiers.weaponSpecial = ""; //Fire, Thunder, Paralysis, Cure etc
                            modifiers.guardianForce = ""; //Keres have 05, Will o the wisp have 04
                            modifiers.stickyFeet = ""; //Slippery Feets
                            modifiers.speed = "3F80"; //3F80 default speed

                            modifiers.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                            modifiers.attack = "40000000"; //Decrease/Increase Attack
                            modifiers.defense = "3F000000"; //Decrease/Increase Defense
                            modifiers.stealHp = ""; //Steal health from enemy
                            modifiers.pierceDamage = ""; //Damage inflicted thru guard
                            modifiers.weaponSize = "";
                            modifiers.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                            modifiers.counterRate = ""; //Increase Counter Chance
                            modifiers.nullCounter = ""; //Nullify Enemies Counters chance
                            modifiers.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                            modifiers.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                            modifiers.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                            modifiers.parryRegen = ""; //Recover Health when successfully Guard Impact
                            modifiers.guardBreakRate = ""; //Increase Guard Break Chance
                            modifiers.throwEscapeChance = ""; //Increase Throw Escape Rate
                            modifiers.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                            modifiers.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                            modifiers.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                            break;
                        case 6:
                            modifiers.weaponSpecial = ""; //Fire, Thunder, Paralysis, Cure etc
                            modifiers.guardianForce = "06"; //Keres have 05, Will o the wisp have 04
                            modifiers.stickyFeet = ""; //Slippery Feets
                            modifiers.speed = "3F80"; //3F80 default speed

                            modifiers.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                            modifiers.attack = ""; //Decrease/Increase Attack
                            modifiers.defense = ""; //Decrease/Increase Defense
                            modifiers.stealHp = ""; //Steal health from enemy
                            modifiers.pierceDamage = ""; //Damage inflicted thru guard
                            modifiers.weaponSize = "";
                            modifiers.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                            modifiers.counterRate = ""; //Increase Counter Chance
                            modifiers.nullCounter = ""; //Nullify Enemies Counters chance
                            modifiers.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                            modifiers.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                            modifiers.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                            modifiers.parryRegen = ""; //Recover Health when successfully Guard Impact
                            modifiers.guardBreakRate = ""; //Increase Guard Break Chance
                            modifiers.throwEscapeChance = ""; //Increase Throw Escape Rate
                            modifiers.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                            modifiers.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                            modifiers.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                            break;
                        case 7:
                            modifiers.weaponSpecial = "Mega Poison"; //Fire, Thunder, Paralysis, Cure etc
                            modifiers.guardianForce = ""; //Keres have 05, Will o the wisp have 04
                            modifiers.stickyFeet = ""; //Slippery Feets
                            modifiers.speed = "3F80"; //3F80 default speed

                            modifiers.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                            modifiers.attack = ""; //Decrease/Increase Attack
                            modifiers.defense = ""; //Decrease/Increase Defense
                            modifiers.stealHp = ""; //Steal health from enemy
                            modifiers.pierceDamage = ""; //Damage inflicted thru guard
                            modifiers.weaponSize = "";
                            modifiers.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                            modifiers.counterRate = ""; //Increase Counter Chance
                            modifiers.nullCounter = ""; //Nullify Enemies Counters chance
                            modifiers.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                            modifiers.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                            modifiers.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                            modifiers.parryRegen = ""; //Recover Health when successfully Guard Impact
                            modifiers.guardBreakRate = ""; //Increase Guard Break Chance
                            modifiers.throwEscapeChance = ""; //Increase Throw Escape Rate
                            modifiers.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                            modifiers.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                            modifiers.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                            break;
                        case 8:
                            modifiers.weaponSpecial = "Super Defense"; //Fire, Thunder, Paralysis, Cure etc
                            modifiers.guardianForce = ""; //Keres have 05, Will o the wisp have 04
                            modifiers.stickyFeet = ""; //Slippery Feets
                            modifiers.speed = "3F80"; //3F80 default speed

                            modifiers.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                            modifiers.attack = ""; //Decrease/Increase Attack
                            modifiers.defense = ""; //Decrease/Increase Defense
                            modifiers.stealHp = ""; //Steal health from enemy
                            modifiers.pierceDamage = ""; //Damage inflicted thru guard
                            modifiers.weaponSize = "";
                            modifiers.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                            modifiers.counterRate = ""; //Increase Counter Chance
                            modifiers.nullCounter = ""; //Nullify Enemies Counters chance
                            modifiers.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                            modifiers.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                            modifiers.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                            modifiers.parryRegen = ""; //Recover Health when successfully Guard Impact
                            modifiers.guardBreakRate = ""; //Increase Guard Break Chance
                            modifiers.throwEscapeChance = ""; //Increase Throw Escape Rate
                            modifiers.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                            modifiers.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                            modifiers.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                            break;
                        case 9:
                            modifiers.weaponSpecial = "Ice"; //Fire, Thunder, Paralysis, Cure etc
                            modifiers.guardianForce = ""; //Keres have 05, Will o the wisp have 04
                            modifiers.stickyFeet = ""; //Slippery Feets
                            modifiers.speed = "3F80"; //3F80 default speed

                            modifiers.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                            modifiers.attack = ""; //Decrease/Increase Attack
                            modifiers.defense = ""; //Decrease/Increase Defense
                            modifiers.stealHp = ""; //Steal health from enemy
                            modifiers.pierceDamage = ""; //Damage inflicted thru guard
                            modifiers.weaponSize = "";
                            modifiers.atkPushForce = "3FA00000"; //Decrease/Increase Attack Pushback Force
                            modifiers.counterRate = ""; //Increase Counter Chance
                            modifiers.nullCounter = ""; //Nullify Enemies Counters chance
                            modifiers.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                            modifiers.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                            modifiers.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                            modifiers.parryRegen = ""; //Recover Health when successfully Guard Impact
                            modifiers.guardBreakRate = ""; //Increase Guard Break Chance
                            modifiers.throwEscapeChance = ""; //Increase Throw Escape Rate
                            modifiers.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                            modifiers.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                            modifiers.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                            break;
                        case 10:
                            modifiers.weaponSpecial = "Down Lose"; //Fire, Thunder, Paralysis, Cure etc
                            modifiers.guardianForce = ""; //Keres have 05, Will o the wisp have 04
                            modifiers.stickyFeet = ""; //Slippery Feets
                            modifiers.speed = "3F80"; //3F80 default speed

                            modifiers.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                            modifiers.attack = ""; //Decrease/Increase Attack
                            modifiers.defense = "3FA00000"; //Decrease/Increase Defense
                            modifiers.stealHp = ""; //Steal health from enemy
                            modifiers.pierceDamage = ""; //Damage inflicted thru guard
                            modifiers.weaponSize = "";
                            modifiers.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                            modifiers.counterRate = ""; //Increase Counter Chance
                            modifiers.nullCounter = ""; //Nullify Enemies Counters chance
                            modifiers.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                            modifiers.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                            modifiers.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                            modifiers.parryRegen = ""; //Recover Health when successfully Guard Impact
                            modifiers.guardBreakRate = ""; //Increase Guard Break Chance
                            modifiers.throwEscapeChance = ""; //Increase Throw Escape Rate
                            modifiers.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                            modifiers.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                            modifiers.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                            break;
                    }
                    break;
                case "20":
                    switch (randomPick)
                    {
                        case 1:
                            //Night Terror
                            modifiers.model = "27";
                            modifiers.costume = "00";
                            modifiers.fightingStyle = "27";
                            modifiers.weaponNumber = "00";

                            modifiers.weaponSpecial = ""; //Fire, Thunder, Paralysis, Cure etc
                            modifiers.guardianForce = ""; //Keres have 05, Will o the wisp have 04
                            modifiers.stickyFeet = ""; //Slippery Feets
                            modifiers.speed = "3F80"; //3F80 default speed

                            modifiers.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                            modifiers.attack = ""; //Decrease/Increase Attack
                            modifiers.defense = ""; //Decrease/Increase Defense
                            modifiers.stealHp = ""; //Steal health from enemy
                            modifiers.pierceDamage = ""; //Damage inflicted thru guard
                            modifiers.weaponSize = "";
                            modifiers.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                            modifiers.counterRate = ""; //Increase Counter Chance
                            modifiers.nullCounter = ""; //Nullify Enemies Counters chance
                            modifiers.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                            modifiers.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                            modifiers.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                            modifiers.parryRegen = ""; //Recover Health when successfully Guard Impact
                            modifiers.guardBreakRate = ""; //Increase Guard Break Chance
                            modifiers.throwEscapeChance = ""; //Increase Throw Escape Rate
                            modifiers.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                            modifiers.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                            modifiers.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                            break;
                        case 2:
                            //Inferno
                            modifiers.model = "2B";
                            modifiers.costume = "00";
                            modifiers.fightingStyle = "14";
                            modifiers.weaponNumber = "05";

                            modifiers.weaponSpecial = "All Unblockable"; //Fire, Thunder, Paralysis, Cure etc
                            modifiers.guardianForce = "00"; //Keres have 05, Will o the wisp have 04
                            modifiers.stickyFeet = ""; //Slippery Feets
                            modifiers.speed = "3F80"; //3F80 default speed

                            modifiers.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                            modifiers.attack = ""; //Decrease/Increase Attack
                            modifiers.defense = ""; //Decrease/Increase Defense
                            modifiers.stealHp = ""; //Steal health from enemy
                            modifiers.pierceDamage = ""; //Damage inflicted thru guard
                            modifiers.weaponSize = "";
                            modifiers.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                            modifiers.counterRate = ""; //Increase Counter Chance
                            modifiers.nullCounter = ""; //Nullify Enemies Counters chance
                            modifiers.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                            modifiers.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                            modifiers.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                            modifiers.parryRegen = ""; //Recover Health when successfully Guard Impact
                            modifiers.guardBreakRate = ""; //Increase Guard Break Chance
                            modifiers.throwEscapeChance = ""; //Increase Throw Escape Rate
                            modifiers.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                            modifiers.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                            modifiers.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                            break;
                        case 3:
                            //Colossus
                            modifiers.model = "31";
                            modifiers.costume = "00";
                            modifiers.fightingStyle = "31";
                            modifiers.weaponNumber = "00";

                            modifiers.weaponSpecial = ""; //Fire, Thunder, Paralysis, Cure etc
                            modifiers.guardianForce = ""; //Keres have 05, Will o the wisp have 04
                            modifiers.stickyFeet = ""; //Slippery Feets
                            modifiers.speed = "3F80"; //3F80 default speed

                            modifiers.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                            modifiers.attack = ""; //Decrease/Increase Attack
                            modifiers.defense = "3E800000"; //Decrease/Increase Defense
                            modifiers.stealHp = ""; //Steal health from enemy
                            modifiers.pierceDamage = ""; //Damage inflicted thru guard
                            modifiers.weaponSize = "";
                            modifiers.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                            modifiers.counterRate = ""; //Increase Counter Chance
                            modifiers.nullCounter = ""; //Nullify Enemies Counters chance
                            modifiers.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                            modifiers.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                            modifiers.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                            modifiers.parryRegen = ""; //Recover Health when successfully Guard Impact
                            modifiers.guardBreakRate = ""; //Increase Guard Break Chance
                            modifiers.throwEscapeChance = ""; //Increase Throw Escape Rate
                            modifiers.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                            modifiers.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                            modifiers.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                            break;
                        case 4:
                            //Keres
                            modifiers.model = "98";
                            modifiers.costume = "00";
                            modifiers.fightingStyle = "4D";
                            modifiers.weaponNumber = "00";

                            modifiers.weaponSpecial = ""; //Fire, Thunder, Paralysis, Cure etc
                            modifiers.guardianForce = ""; //Keres have 05, Will o the wisp have 04
                            modifiers.stickyFeet = ""; //Slippery Feets
                            modifiers.speed = "3F80"; //3F80 default speed

                            modifiers.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                            modifiers.attack = ""; //Decrease/Increase Attack
                            modifiers.defense = ""; //Decrease/Increase Defense
                            modifiers.stealHp = ""; //Steal health from enemy
                            modifiers.pierceDamage = ""; //Damage inflicted thru guard
                            modifiers.weaponSize = "";
                            modifiers.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                            modifiers.counterRate = ""; //Increase Counter Chance
                            modifiers.nullCounter = ""; //Nullify Enemies Counters chance
                            modifiers.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                            modifiers.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                            modifiers.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                            modifiers.parryRegen = ""; //Recover Health when successfully Guard Impact
                            modifiers.guardBreakRate = ""; //Increase Guard Break Chance
                            modifiers.throwEscapeChance = ""; //Increase Throw Escape Rate
                            modifiers.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                            modifiers.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                            modifiers.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                            break;
                        case 5:
                            //Abyss
                            modifiers.model = "26";
                            modifiers.costume = "00";
                            modifiers.fightingStyle = "26";
                            modifiers.weaponNumber = "00";

                            modifiers.weaponSpecial = "Thundalysis"; //Fire, Thunder, Paralysis, Cure etc
                            modifiers.guardianForce = ""; //Keres have 05, Will o the wisp have 04
                            modifiers.stickyFeet = ""; //Slippery Feets
                            modifiers.speed = "3F80"; //3F80 default speed

                            modifiers.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                            modifiers.attack = ""; //Decrease/Increase Attack
                            modifiers.defense = ""; //Decrease/Increase Defense
                            modifiers.stealHp = ""; //Steal health from enemy
                            modifiers.pierceDamage = ""; //Damage inflicted thru guard
                            modifiers.weaponSize = "";
                            modifiers.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                            modifiers.counterRate = ""; //Increase Counter Chance
                            modifiers.nullCounter = ""; //Nullify Enemies Counters chance
                            modifiers.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                            modifiers.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                            modifiers.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                            modifiers.parryRegen = ""; //Recover Health when successfully Guard Impact
                            modifiers.guardBreakRate = ""; //Increase Guard Break Chance
                            modifiers.throwEscapeChance = ""; //Increase Throw Escape Rate
                            modifiers.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                            modifiers.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                            modifiers.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                            break;
                    }
                    break;
            }

            return modifiers;
        }

    }
}
