using Microsoft.IdentityModel.Tokens;
using SC3_pnach_editor.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SC3_pnach_editor.Codes
{
    public class CharacterSelect
    {
        public static string GetCharacterPnachCode(bool liteModeOn, bool restrictP2, bool restrictP1)
        {
            string charCode = "";

            SettingsClass.LoadData();

            if ((SettingsClass.UseSetCharacters && !liteModeOn) || liteModeOn)//main menu char set block
            {
                string player1Char = "";
                if (SettingsClass.CharacterP1 != "none" && SettingsClass.CharacterP1 != "" && restrictP1 != true)
                {
                    if (SettingsClass.CharacterP1 != "FF")
                    {
                        string voicePiece1 = "";
                        if (SettingsClass.VoiceP1 != null && SettingsClass.VoiceP1 != "")
                        {
                            voicePiece1 = Environment.NewLine + "patch=1,EE,004B4872,extended," + SettingsClass.VoiceP1 + " //Voice";
                            if (SettingsClass.CharacterP1 == "BF" && SettingsClass.ModelP1 == "01")
                            {
                                //Add Riese second voice
                                voicePiece1 = voicePiece1 +
                                    Environment.NewLine + "patch=1,EE,204B4888,extended,004F4608 //Second Voice";
                            }
                            if (SettingsClass.CharacterP1 == "C0" && SettingsClass.ModelP1 == "01")
                            {
                                //Add Leraje second voice
                                voicePiece1 = voicePiece1 +
                                    Environment.NewLine + "patch=1,EE,204B4888,extended,004F4540 //Second Voice";
                            }
                            if (SettingsClass.CharacterP1 == "E8" && SettingsClass.ModelP1 == "00")
                            {
                                //Add Heal-Do second voice
                                voicePiece1 = voicePiece1 +
                                    Environment.NewLine + "patch=1,EE,204B4888,extended,004F45E0 //Second Voice";
                            }
                            if (SettingsClass.CharacterP1 == "30" && SettingsClass.ModelP1 == "00")
                            {
                                //Add Amy special second voice
                                voicePiece1 = voicePiece1 +
                                    Environment.NewLine + "patch=1,EE,204B4888,extended,004F4518 //Second Voice";
                            }
                        }

                        player1Char = "patch=1,EE,004B4860,extended," + SettingsClass.CharacterP1 + " //Character" + Environment.NewLine +
                                      "patch=1,EE,004B486E,extended," + SettingsClass.ModelP1 + " //Model" +
                                      voicePiece1;
                    }
                    else//for bosses
                    {
                        switch (SettingsClass.ModelP1)
                        {
                            case "01"://Keres
                                player1Char = "patch=1,EE,004B4860,extended,98 //Character" + Environment.NewLine +
                                              "patch=1,EE,004B4862,extended,15 //Style" + Environment.NewLine +
                                              "patch=1,EE,004B486E,extended,00 //Model" + Environment.NewLine +
                                              "patch=1,EE,004B4896,extended,04 //Weapon" + Environment.NewLine +
                                              "patch=1,EE,204B4C40,extended,3FE00000 //Weapon Size";
                                break;
                            case "02"://Taki
                                player1Char = "patch=1,EE,004B4860,extended,03 //Character" + Environment.NewLine +
                                    "patch=1,EE,004B4862,extended,14 //Style" + Environment.NewLine +
                                    //"patch=1,EE,004B486E,extended,00 //Model" + Environment.NewLine +
                                    "patch=1,EE,004B4896,extended,05 //Weapon" + Environment.NewLine +
                                    "patch=1,EE,204B4C38,extended,3F000000 //Steal health from enemy" + Environment.NewLine +
                                    "patch=1,EE,204B4C40,extended,40000000 //Weapon Size" + Environment.NewLine +
                                    "patch=1,EE,104ED9CA,extended,0001 //Enable weapon effects [Shared]" + Environment.NewLine +
                                    "patch=1,EE,1053CFA4,extended,0002 //Fire Effect P1" + Environment.NewLine +
                                    "patch=1,EE,1053CE24,extended,0001 //Fire Gfx P1" + Environment.NewLine +
                                    "patch=1,EE,2053CD40,extended,00020001 //Fire Effect + Gfx P1 [Shared]";
                                break;
                            case "03"://Sophitia
                                player1Char = "patch=1,EE,004B4860,extended,06 //Character" + Environment.NewLine +
                                    //"patch=1,EE,004B486E,extended,00 //Model" + Environment.NewLine +
                                    "patch=1,EE,004B4896,extended,6D //Weapon" + Environment.NewLine +
                                    "patch=1,EE,204B4C30,extended,3E800000 //Decrease/Increase Defense" + Environment.NewLine +
                                    "patch=1,EE,204B4C50,extended,3C800000 //Decrease/Increase Health while guarding enemies attacks";
                                break;
                            case "04"://Arthur
                                player1Char = "patch=1,EE,004B4860,extended,43 //Character" + Environment.NewLine +
                                    "patch=1,EE,004B486E,extended,00 //Model" + Environment.NewLine +
                                    "patch=1,EE,004B4896,extended,14 //Weapon" + Environment.NewLine +
                                    "patch=1,EE,204B4C40,extended,3FE00000 //Decrease/Increase Attack" + Environment.NewLine +
                                    "patch=1,EE,204B4C6C,extended,3D800000 //Drain/Recover Health over Time";
                                break;
                            case "05"://Siegfried
                                player1Char = "patch=1,EE,004B4860,extended,07 //Character" + Environment.NewLine +
                                    //"patch=1,EE,004B486E,extended,00 //Model" + Environment.NewLine +
                                    "patch=1,EE,004B4896,extended,3D //Weapon" + Environment.NewLine +
                                    "patch=1,EE,204B4C30,extended,40200000 //Decrease/Increase Defense";
                                break;
                            case "06"://Seong Mi-Na
                                player1Char = "patch=1,EE,004B4860,extended,02 //Character" + Environment.NewLine +
                                    //"patch=1,EE,004B486E,extended,00 //Model" + Environment.NewLine +
                                    "patch=1,EE,004B4896,extended,45 //Weapon" + Environment.NewLine +
                                    "patch=1,EE,204B4C44,extended,40200000 //Decrease/Increase Attack Pushback Force" + Environment.NewLine +
                                "patch=1,EE,204B4C60,extended,3FF00000 //Increase Guard Break Chance";
                                break;
                            case "07"://Rock
                                player1Char = "patch=1,EE,004B4860,extended,08 //Character" + Environment.NewLine +
                                    //"patch=1,EE,004B486E,extended,00 //Model" + Environment.NewLine +
                                    "patch=1,EE,004B4896,extended,3D //Weapon" + Environment.NewLine +
                                    "patch=1,EE,204B4C3C,extended,3FF00000 //Damage inflicted thru guard";
                                break;

                            case "11"://Lizardman
                                player1Char = "patch=1,EE,004B4860,extended,0E //Character" + Environment.NewLine +
                                              "patch=1,EE,004B4896,extended,3C //Weapon" + Environment.NewLine +
                                              "patch=1,EE,204B4C40,extended,3FE00000 //Weapon Size" + Environment.NewLine +
                                              "patch=1,EE,204B4C38,extended,3FA00000 //Steal health from enemy" + Environment.NewLine +
                                              "patch=1,EE,204B4C3C,extended,3F200000 //Damage inflicted thru guard";
                                break;
                            case "12"://Ende
                                player1Char = "patch=1,EE,004B4860,extended,EF //Character" + Environment.NewLine +
                                              "patch=1,EE,004B4862,extended,44 //Style" + Environment.NewLine +
                                              "patch=1,EE,004B486E,extended,00 //Model" + Environment.NewLine +
                                              "patch=1,EE,004B4896,extended,40 //Weapon" + Environment.NewLine +
                                              "patch=1,EE,204B4C30,extended,3FA00000 //Decrease/Increase Attack" + Environment.NewLine +
                                              "patch=1,EE,204B4C34,extended,3F700000 //Decrease/Increase Defense" + Environment.NewLine +
                                              "patch=1,EE,204B4C38,extended,3D000000 //Steal health from enemy" + Environment.NewLine +
                                              "patch=1,EE,204B4C3C,extended,3F000000 //Damage inflicted thru guard" + Environment.NewLine +
                                              "patch=1,EE,204B4C40,extended,3FA00000 //Weapon Size" + Environment.NewLine +
                                              "patch=1,EE,204B4C44,extended,3FC00000 //Decrease/Increase Attack Pushback Force" + Environment.NewLine +
                                              "patch=1,EE,204B4C48,extended,40000000 //Increase Counter Chance" + Environment.NewLine +
                                              "patch=1,EE,204B4C4C,extended,40000000 //Nullify Enemies Counters chance" + Environment.NewLine +
                                              "patch=1,EE,204B4C50,extended,3C000000 //Decrease/Increase Health while guarding enemies attacks" + Environment.NewLine +
                                              "patch=1,EE,204B4C54,extended,3DCCCCCB //Automatically Guard Impact some attacks" + Environment.NewLine +
                                              "patch=1,EE,204B4C58,extended,3F800000 //Increase Damage Received by Opponent when successfully Guard Impact" + Environment.NewLine +
                                              "patch=1,EE,204B4C5C,extended,3F800000 //Recover Health when successfully Guard Impact" + Environment.NewLine +
                                              "patch=1,EE,204B4C60,extended,3D800000 //Increase Guard Break Chance" + Environment.NewLine +
                                              "patch=1,EE,204B4C64,extended,3F800000 //Increase Throw Escape Rate" + Environment.NewLine +
                                              "patch=1,EE,204B4C68,extended,40000000 //Increase Ring-Out Escape Rate" + Environment.NewLine +
                                              "patch=1,EE,204B4C6C,extended,3C000000 //Drain/Recover Health over Time" + Environment.NewLine +
                                              "patch=1,EE,204B4C70,extended,3F800000 //Drain/Recover Health when Attacking";
                                break;
                            case "13"://Nightmare
                                player1Char = "patch=1,EE,004B4860,extended,11 //Character" + Environment.NewLine +
                                              "patch=1,EE,004B4896,extended,1D //Weapon" + Environment.NewLine +
                                              "patch=1,EE,204B4C40,extended,40000000 //Weapon Size" + Environment.NewLine +
                                              "patch=1,EE,204B4C6C,extended,3E000000 //Drain/Recover Health over Time" + Environment.NewLine +
                                              "patch=1,EE,104B4C6E,extended,3D80 // Change Weapon Heal Stat" + Environment.NewLine +
                                              "patch=1,EE,104ED9CA,extended,0001 // Enable weapon effects [Shared]" + Environment.NewLine +
                                              "patch=1,EE,1053CDBC,extended,0001 // Cure Gfx P1" + Environment.NewLine +
                                              "patch=1,EE,2053CD40,extended,00000001 // P1 Cure";
                                break;
                            case "14"://Setsuka
                                player1Char = "patch=1,EE,004B4860,extended,22 //Character" + Environment.NewLine +
                                              "patch=1,EE,004B4896,extended,07 //Weapon" + Environment.NewLine +
                                              "patch=1,EE,204B4C30,extended,3FC00000 //Decrease/Increase Attack" + Environment.NewLine +
                                              "patch=1,EE,204B4C38,extended,3D800000 //Steal health from enemy" + Environment.NewLine +
                                              "patch=1,EE,204B4C40,extended,3FA00000 //Weapon Size" + Environment.NewLine +
                                              "patch=1,EE,104ED9CA,extended,0001 //Enable weapon effects [Shared]" + Environment.NewLine +
                                              "patch=1,EE,1053CFA0,extended,0001 //Paralysis Effect P1" + Environment.NewLine +
                                              "patch=1,EE,1053CE20,extended,0002 //Paralysis Gfx P1" + Environment.NewLine +
                                              "patch=1,EE,2053CD40,extended,00010002 //Paralysis Effect + Gfx P1 [Shared]";
                                break;
                            case "15"://Assassin
                                player1Char = "patch=1,EE,004B4860,extended,93 //Character" + Environment.NewLine +
                                              "patch=1,EE,004B486E,extended,00 //Model" + Environment.NewLine +
                                              "patch=1,EE,004B4896,extended,03 //Weapon" + Environment.NewLine +
                                              "patch=1,EE,204B4C38,extended,3FC00000 //Steal health from enemy" + Environment.NewLine +
                                              "patch=1,EE,104D23EE,extended,BD80 // Change Weapon Damage Stat P2" + Environment.NewLine +
                                              "patch=1,EE,104ED9CA,extended,0001 // Enable weapon effects [Shared]" + Environment.NewLine +
                                              "patch=1,EE,1053CFCC,extended,0001 // Poison Gfx P2" + Environment.NewLine +
                                              "patch=1,EE,2053CD40,extended,00030000 // P2 Poison";
                                break;
                            case "16"://Berserker
                                player1Char = "patch=1,EE,004B4860,extended,81 //Character" + Environment.NewLine +
                                              "patch=1,EE,004B486E,extended,00 //Model" + Environment.NewLine +
                                              "patch=1,EE,004B4896,extended,02 //Weapon" + Environment.NewLine +
                                              "patch=1,EE,204B4C70,extended,C0000000 //Drain/Recover Health when Attacking" + Environment.NewLine +
                                              "patch=1,EE,104ED9CA,extended,0001 //Enable weapon effects [Shared]" + Environment.NewLine +
                                              "patch=1,EE,1053CFA8,extended,0002 //Thunder Effect P1" + Environment.NewLine +
                                              "patch=1,EE,1053CD94,extended,0001 //Thunder Gfx P1" + Environment.NewLine +
                                              "patch=1,EE,2053CD40,extended,00020001 //Thunder Effect + Gfx P1 [Shared]";
                                break;
                            case "17"://Abyss
                                player1Char = "patch=1,EE,004B4860,extended,26 //Character" + Environment.NewLine +
                                              //"patch=1,EE,004B486E,extended,00 //Model" + Environment.NewLine +
                                              "patch=1,EE,004B4896,extended,07 //Weapon" + Environment.NewLine +
                                              "patch=1,EE,104ED9CA,extended,0001 //Enable weapon effects [Shared]" + Environment.NewLine +
                                              "patch=1,EE,1053CFA4,extended,0002 //Fire Effect P1" + Environment.NewLine +
                                              "patch=1,EE,1053CE24,extended,0001 //Fire Gfx P1" + Environment.NewLine +
                                              "patch=1,EE,2053CD40,extended,00020001 //Fire Effect + Gfx P1 [Shared]" + Environment.NewLine +
                                              "patch=1,EE,204B4AF4,extended,00020005 //Guardian Force Player 1";
                                break;
                        }
                    }
                }
                string player2Char = "";
                if (SettingsClass.CharacterP2 != "none" && SettingsClass.CharacterP2 != "" && restrictP2 != true)
                {
                    if (SettingsClass.CharacterP2 != "FF")
                    {
                        string voicePiece2 = "";
                        if (SettingsClass.VoiceP2 != null && SettingsClass.VoiceP2 != "")
                        {
                            voicePiece2 = Environment.NewLine + "patch=1,EE,004D1FF2,extended," + SettingsClass.VoiceP2 + " //Voice";
                            if (SettingsClass.CharacterP2 == "BF" && SettingsClass.ModelP2 == "01")
                            {
                                //Add Riese second voice
                                voicePiece2 = voicePiece2 +
                                    Environment.NewLine + "patch=1,EE,204D2008,extended,004F4608 //Second Voice";
                            }
                            if (SettingsClass.CharacterP2 == "C0" && SettingsClass.ModelP2 == "01")
                            {
                                //Add Leraje second voice
                                voicePiece2 = voicePiece2 +
                                    Environment.NewLine + "patch=1,EE,204D2008,extended,004F4540 //Second Voice";
                            }
                            if (SettingsClass.CharacterP2 == "E8" && SettingsClass.ModelP2 == "00")
                            {
                                //Add Heal-Do second voice
                                voicePiece2 = voicePiece2 +
                                    Environment.NewLine + "patch=1,EE,204D2008,extended,004F45E0 //Second Voice";
                            }
                            if (SettingsClass.CharacterP2 == "30" && SettingsClass.ModelP2 == "00")
                            {
                                //Add Amy special second voice
                                voicePiece2 = voicePiece2 +
                                    Environment.NewLine + "patch=1,EE,204B4888,extended,004F4518 //Second Voice";
                            }
                        }

                        player2Char = "patch=1,EE,004D1FE0,extended," + SettingsClass.CharacterP2 + " //Character2" + Environment.NewLine +
                                      "patch=1,EE,004D1FEE,extended," + SettingsClass.ModelP2 + " //Model2" +
                                      voicePiece2;
                    }
                    else//for bosses
                    {
                        switch (SettingsClass.ModelP2)
                        {
                            case "01"://Keres
                                player2Char = "patch=1,EE,004D1FE0,extended,98 //Character" + Environment.NewLine +
                                              "patch=1,EE,004D1FE2,extended,15 //Style" + Environment.NewLine +
                                              "patch=1,EE,004D1FEE,extended,00 //Model" + Environment.NewLine +
                                              "patch=1,EE,004D2016,extended,04 //Weapon" + Environment.NewLine +
                                              "patch=1,EE,204D23C0,extended,3FE00000 //Weapon Size";
                                break;
                            case "02"://Taki
                                player2Char = "patch=1,EE,004D1FE0,extended,03 //Character" + Environment.NewLine +
                                    "patch=1,EE,004D1FE2,004D1FE2,14 //Style" + Environment.NewLine +
                                    //"patch=1,EE,004D1FEE,extended,00 //Model" + Environment.NewLine +
                                    "patch=1,EE,004D2016,extended,05 //Weapon" + Environment.NewLine +
                                    "patch=1,EE,204D23B8,extended,3F000000 //Steal health from enemy" + Environment.NewLine +
                                    "patch=1,EE,204D23C0,extended,40000000 //Weapon Size" + Environment.NewLine +
                                    "patch=1,EE,104ED9CA,extended,0001 //Enable weapon effects [Shared]" + Environment.NewLine +
                                    "patch=1,EE,1053CE18,extended,0002 //Fire Effect P1" + Environment.NewLine +
                                    "patch=1,EE,1053CFB0,extended,0001 //Fire Gfx P1" + Environment.NewLine +
                                    "patch=1,EE,2053CD40,extended,00010002 //Fire Effect + Gfx P1 [Shared]";
                                break;
                            case "03"://Sophitia
                                player2Char = "patch=1,EE,004D1FE0,extended,06 //Character" + Environment.NewLine +
                                    //"patch=1,EE,004D1FEE,extended,00 //Model" + Environment.NewLine +
                                    "patch=1,EE,004D2016,extended,6D //Weapon" + Environment.NewLine +
                                    "patch=1,EE,204D23B4,extended,3E800000 //Decrease/Increase Defense" + Environment.NewLine +
                                    "patch=1,EE,204D23D0,extended,3C800000 //Decrease/Increase Health while guarding enemies attacks";
                                break;
                            case "04"://Arthur
                                player2Char = "patch=1,EE,004D1FE0,extended,43 //Character" + Environment.NewLine +
                                    "patch=1,EE,004D1FEE,extended,00 //Model" + Environment.NewLine +
                                    "patch=1,EE,004D2016,extended,14 //Weapon" + Environment.NewLine +
                                    "patch=1,EE,204D23B0,extended,3FA00000 //Decrease/Increase Attack" + Environment.NewLine +
                                    "patch=1,EE,204D23EC,extended,3D800000 //Drain/Recover Health over Time";
                                break;
                            case "05"://Siegfried
                                player2Char = "patch=1,EE,004D1FE0,extended,07 //Character" + Environment.NewLine +
                                    //"patch=1,EE,004D1FEE,extended,00 //Model" + Environment.NewLine +
                                    "patch=1,EE,004D2016,extended,3D //Weapon" + Environment.NewLine +
                                    "patch=1,EE,204D23B0,extended,40200000 //Decrease/Increase Defense";
                                break;
                            case "06"://Seong Mi-Na
                                player2Char = "patch=1,EE,004D1FE0,extended,02 //Character" + Environment.NewLine +
                                    //"patch=1,EE,004D1FEE,extended,00 //Model" + Environment.NewLine +
                                    "patch=1,EE,004D2016,extended,45 //Weapon" + Environment.NewLine +
                                    "patch=1,EE,204D23C4,extended,40200000 //Decrease/Increase Attack Pushback Force" + Environment.NewLine +
                                "patch=1,EE,204D23E0,extended,3FF00000 //Increase Guard Break Chance";
                                break;
                            case "07"://Rock
                                player2Char = "patch=1,EE,004D1FE0,extended,08 //Character" + Environment.NewLine +
                                    //"patch=1,EE,004D1FEE,extended,00 //Model" + Environment.NewLine +
                                    "patch=1,EE,004D2016,extended,3D //Weapon" + Environment.NewLine +
                                    "patch=1,EE,204D23BC,extended,3FF00000 //Damage inflicted thru guard";
                                break;

                            case "11"://Lizardman
                                player2Char = "patch=1,EE,004D1FE0,extended,0E //Character" + Environment.NewLine +
                                              "patch=1,EE,004D2016,extended,3C //Weapon" + Environment.NewLine +
                                              "patch=1,EE,204D23C0,extended,3FE00000 //Weapon Size" + Environment.NewLine +
                                              "patch=1,EE,204D23B8,extended,3FA00000 //Steal health from enemy" + Environment.NewLine +
                                              "patch=1,EE,204D23BC,extended,3F200000 //Damage inflicted thru guard";
                                break;
                            case "12"://Ende
                                player2Char = "patch=1,EE,004D1FE0,extended,EF //Character" + Environment.NewLine +
                                              "patch=1,EE,004D1FE2,extended,44 //Style" + Environment.NewLine +
                                              "patch=1,EE,004D1FEE,extended,00 //Model" + Environment.NewLine +
                                              "patch=1,EE,004D2016,extended,40 //Weapon" + Environment.NewLine +
                                              "patch=1,EE,204D23B0,extended,3FA00000 //Decrease/Increase Attack" + Environment.NewLine +
                                              "patch=1,EE,204D23B4,extended,3F700000 //Decrease/Increase Defense" + Environment.NewLine +
                                              "patch=1,EE,204D23B8,extended,3D000000 //Steal health from enemy" + Environment.NewLine +
                                              "patch=1,EE,204D23BC,extended,3F000000 //Damage inflicted thru guard" + Environment.NewLine +
                                              "patch=1,EE,204D23C0,extended,3FA00000 //Weapon Size" + Environment.NewLine +
                                              "patch=1,EE,204D23C4,extended,3FC00000 //Decrease/Increase Attack Pushback Force" + Environment.NewLine +
                                              "patch=1,EE,204D23C8,extended,40000000 //Increase Counter Chance" + Environment.NewLine +
                                              "patch=1,EE,204D23CC,extended,40000000 //Nullify Enemies Counters chance" + Environment.NewLine +
                                              "patch=1,EE,204D23D0,extended,3C000000 //Decrease/Increase Health while guarding enemies attacks" + Environment.NewLine +
                                              "patch=1,EE,204D23D4,extended,3DCCCCCB //Automatically Guard Impact some attacks" + Environment.NewLine +
                                              "patch=1,EE,204D23D8,extended,3F800000 //Increase Damage Received by Opponent when successfully Guard Impact" + Environment.NewLine +
                                              "patch=1,EE,204D23DC,extended,3F800000 //Recover Health when successfully Guard Impact" + Environment.NewLine +
                                              "patch=1,EE,204D23E0,extended,3D800000 //Increase Guard Break Chance" + Environment.NewLine +
                                              "patch=1,EE,204D23E4,extended,3F800000 //Increase Throw Escape Rate" + Environment.NewLine +
                                              "patch=1,EE,204D23E8,extended,40000000 //Increase Ring-Out Escape Rate" + Environment.NewLine +
                                              "patch=1,EE,204D23EC,extended,3C000000 //Drain/Recover Health over Time" + Environment.NewLine +
                                              "patch=1,EE,204D23F0,extended,3F800000 //Drain/Recover Health when Attacking";
                                break;
                            case "13"://Nightmare
                                player2Char = "patch=1,EE,004D1FE0,extended,11 //Character" + Environment.NewLine +
                                              "patch=1,EE,004D2016,extended,1D //Weapon" + Environment.NewLine +
                                              "patch=1,EE,204D23C0,extended,40000000 //Weapon Size" + Environment.NewLine +
                                              "patch=1,EE,204D23EC,extended,3E000000 //Drain/Recover Health over Time" + Environment.NewLine +
                                              "patch=1,EE,104D23EE,extended,3D80 // Change Weapon Heal Stat" + Environment.NewLine +
                                              "patch=1,EE,104ED9CA,extended,0001 // Enable weapon effects [Shared]" + Environment.NewLine +
                                              "patch=1,EE,1053CF48,extended,0001 // Cure Gfx P2" + Environment.NewLine +
                                              "patch=1,EE,2053CD40,extended,00010000 // P2 Cure";
                                break;
                            case "14"://Setsuka
                                player2Char = "patch=1,EE,004D1FE0,extended,22 //Character" + Environment.NewLine +
                                              "patch=1,EE,004D2016,extended,07 //Weapon" + Environment.NewLine +
                                              "patch=1,EE,204D23B0,extended,3FC00000 //Decrease/Increase Attack" + Environment.NewLine +
                                              "patch=1,EE,204D23B8,extended,3D800000 //Steal health from enemy" + Environment.NewLine +
                                              "patch=1,EE,204D23C0,extended,3FA00000 //Weapon Size" + Environment.NewLine +
                                              "patch=1,EE,104ED9CA,extended,0001 //Enable weapon effects [Shared]" + Environment.NewLine +
                                              "patch=1,EE,1053CE14,extended,0001 //Paralysis Effect P2" + Environment.NewLine +
                                              "patch=1,EE,1053CFAC,extended,0002 //Paralysis Gfx P2" + Environment.NewLine +
                                              "patch=1,EE,2053CD40,extended,00020001 //Paralysis Effect + Gfx P2 [Shared]";
                                break;
                            case "15"://Assassin
                                player2Char = "patch=1,EE,004D1FE0,extended,93 //Character" + Environment.NewLine +
                                              "patch=1,EE,004D1FEE,extended,00 //Model" + Environment.NewLine +
                                              "patch=1,EE,004D2016,extended,03 //Weapon" + Environment.NewLine +
                                              "patch=1,EE,204D23B8,extended,3FC00000 //Steal health from enemy" + Environment.NewLine +
                                              "patch=1,EE,104B4C6E,extended,BD80 // Change Weapon Damage Stat P2" + Environment.NewLine +
                                              "patch=1,EE,104ED9CA,extended,0001 // Enable weapon effects [Shared]" + Environment.NewLine +
                                              "patch=1,EE,1053CE40,extended,0001 // Poison Gfx P2" + Environment.NewLine +
                                              "patch=1,EE,2053CD40,extended,00000003 // P2 Poison";
                                break;
                            case "16"://Berserker
                                player2Char = "patch=1,EE,004D1FE0,extended,81 //Character" + Environment.NewLine +
                                              "patch=1,EE,004D1FEE,extended,00 //Model" + Environment.NewLine +
                                              "patch=1,EE,004D2016,extended,02 //Weapon" + Environment.NewLine +
                                              "patch=1,EE,204D23F0,extended,C0000000 //Drain/Recover Health when Attacking" + Environment.NewLine +
                                              "patch=1,EE,104ED9CA,extended,0001 //Enable weapon effects [Shared]" + Environment.NewLine +
                                              "patch=1,EE,1053CE1C,extended,0002 //Thunder Effect P1" + Environment.NewLine +
                                              "patch=1,EE,1053CF20,extended,0001 //Thunder Gfx P1" + Environment.NewLine +
                                              "patch=1,EE,2053CD40,extended,00010002 //Thunder Effect + Gfx P1 [Shared]";
                                break;
                            case "17"://Abyss
                                player2Char = "patch=1,EE,004D1FE0,extended,26 //Character" + Environment.NewLine +
                                              //"patch=1,EE,004B486E,extended,00 //Model" + Environment.NewLine +
                                              "patch=1,EE,004D2016,extended,07 //Weapon" + Environment.NewLine +
                                              "patch=1,EE,104ED9CA,extended,0001 //Enable weapon effects [Shared]" + Environment.NewLine +
                                              "patch=1,EE,1053CE18,extended,0002 //Fire Effect P2" + Environment.NewLine +
                                              "patch=1,EE,1053CFB0,extended,0001 //Fire Gfx P2" + Environment.NewLine +
                                              "patch=1,EE,2053CD40,extended,00010002 //Fire Effect + Gfx P2 [Shared]" + Environment.NewLine +
                                              "patch=1,EE,204D2274,extended,00020005 //Guardian Force Player 2";
                                break;
                        }
                    }
                }
                charCode += "" + Environment.NewLine +  player1Char + Environment.NewLine + player2Char + Environment.NewLine + "";
            }

            int test = SettingsClass.OpponentControl;

            if (liteModeOn)
            {
                if (restrictP2 != true)
                {
                    //add inferno code
                    charCode += "" + Environment.NewLine +
                            "patch=1,EE,D04B4860,extended,0000002B //If P1 is Inferno" + Environment.NewLine +
                            "patch=1,EE,204B4AF4,extended,00020000 //Default Defense P1" + Environment.NewLine +

                            "patch=1,EE,D04B4860,extended,0000002B //If P1 is Inferno" + Environment.NewLine +
                            "patch=1,EE,204B4C30,extended,40000000 //Attack Player 1" + Environment.NewLine +

                            "patch=1,EE,D04B4860,extended,0000002B //If P1 is Inferno" + Environment.NewLine +
                            "patch=1,EE,004B4862,extended,14 //Inferno plays like Cervantes" + Environment.NewLine +

                            "patch=1,EE,D04B4860,extended,0000002B //If P1 is Inferno" + Environment.NewLine +
                            "patch=1,EE,004B4896,extended,05 //Inferno have Soul Edge" + Environment.NewLine +

                            "patch=1,EE,D04B4860,extended,020000EF //If P1 is Yotory character" + Environment.NewLine +
                            "patch=1,EE,D04B486E,extended,01000001 //If P1 is Yotory model" + Environment.NewLine +
                            "patch=1,EE,004B4862,extended,01 //Yotory plays like Mitsurugi" + Environment.NewLine +

                            "patch=1,EE,D04B4860,extended,00000031 //If P1 is Collosus" + Environment.NewLine +
                            "patch=1,EE,1051F2CC,extended,0002 //Change AI to Collosus" + Environment.NewLine +

                            "patch=1,EE,D04D1FE0,extended,0000002B //If P2 is Inferno" + Environment.NewLine +
                            "patch=1,EE,204D2274,extended,00020000 //Default Defense P2" + Environment.NewLine +

                            "patch=1,EE,D04D1FE0,extended,0000002B //If P2 is Inferno" + Environment.NewLine +
                            "patch=1,EE,204D23B0,extended,40000000 //Attack Player 2" + Environment.NewLine +

                            "patch=1,EE,D04D1FE0,extended,0000002B //If P2 is Inferno" + Environment.NewLine +
                            "patch=1,EE,004D1FE2,extended,14 //Inferno plays like Cervantes" + Environment.NewLine +

                            "patch=1,EE,D04D1FE0,extended,0000002B //If P2 is Inferno" + Environment.NewLine +
                            "patch=1,EE,004D2016,extended,05 //Inferno have Soul Edge" + Environment.NewLine +

                            "patch=1,EE,D04D1FE0,extended,020000EF //If P2 is Yotory character" + Environment.NewLine +
                            "patch=1,EE,D04D1FEE,extended,01000001 //If P2 is Yotory model" + Environment.NewLine +
                            "patch=1,EE,004D1FE2,extended,01 //Yotory plays like Mitsurugi" + Environment.NewLine +

                            "patch=1,EE,D04D1FE0,extended,00000031 //If P2 is Collosus" + Environment.NewLine +
                            "patch=1,EE,10520D5C,extended,0002 //Change AI to Collosus" + Environment.NewLine;
                }
                else
                {
                    //only add for P1
                    charCode += "" + Environment.NewLine +
                            "patch=1,EE,D04B4860,extended,0000002B //If P1 is Inferno" + Environment.NewLine +
                            "patch=1,EE,204B4AF4,extended,00020000 //Default Defense P1" + Environment.NewLine +

                            "patch=1,EE,D04B4860,extended,0000002B //If P1 is Inferno" + Environment.NewLine +
                            "patch=1,EE,204B4C30,extended,40000000 //Attack Player 1" + Environment.NewLine +

                            "patch=1,EE,D04B4860,extended,0000002B //If P1 is Inferno" + Environment.NewLine +
                            "patch=1,EE,004B4862,extended,14 //Inferno plays like Cervantes" + Environment.NewLine +

                            "patch=1,EE,D04B4860,extended,0000002B //If P1 is Inferno" + Environment.NewLine +
                            "patch=1,EE,004B4896,extended,05 //Inferno have Soul Edge" + Environment.NewLine +

                            "patch=1,EE,D04B4860,extended,020000EF //If P1 is Yotory character" + Environment.NewLine +
                            "patch=1,EE,D04B486E,extended,01000001 //If P1 is Yotory model" + Environment.NewLine +
                            "patch=1,EE,004B4862,extended,01 //Yotory plays like Mitsurugi";
                }


                if (restrictP2 != true)
                {
                    //add enemy control code
                    SettingsClass.LoadData();
                    int controlIndex = SettingsClass.OpponentControl;
                    if (controlIndex > 0)
                    {
                        List<string> OpponentControlCombo = new List<string>
                    {
                        "No Change",
                        "Player 2",
                        "Easy",
                        "Normal",
                        "Hard",
                        "Very Hard",
                        "Ultra Hard",
                        "Extremely Hard"
                    };

                        string opponentControl = OpponentControlCombo[SettingsClass.OpponentControl];
                        string opponentControlCode = "";
                        switch (opponentControl)
                        {
                            case "Player 2":
                                opponentControlCode = "" + Environment.NewLine +
                                "patch=1,EE,104D1FD8,extended,0001 //opponent control" + Environment.NewLine +
                                "";
                                break;
                            case "Easy":
                                opponentControlCode = "" + Environment.NewLine +
                                "patch=1,EE,104D1FD8,extended,0002 //opponent control" + Environment.NewLine +
                                "patch=1,EE,10520D54,extended,0000 //opponent AI" + Environment.NewLine +
                                "";
                                break;
                            case "Normal":
                                opponentControlCode = "" + Environment.NewLine +
                                "patch=1,EE,104D1FD8,extended,0002 //opponent control" + Environment.NewLine +
                                "patch=1,EE,10520D54,extended,0001 //opponent AI" + Environment.NewLine +
                                "";
                                break;
                            case "Hard":
                                opponentControlCode = "" + Environment.NewLine +
                                "patch=1,EE,104D1FD8,extended,0002 //opponent control" + Environment.NewLine +
                                "patch=1,EE,10520D54,extended,0002 //opponent AI" + Environment.NewLine +
                                "";
                                break;
                            case "Very Hard":
                                opponentControlCode = "" + Environment.NewLine +
                                "patch=1,EE,104D1FD8,extended,0002 //opponent control" + Environment.NewLine +
                                "patch=1,EE,10520D54,extended,0003 //opponent AI" + Environment.NewLine +
                                "";
                                break;
                            case "Ultra Hard":
                                opponentControlCode = "" + Environment.NewLine +
                                "patch=1,EE,104D1FD8,extended,0002 //opponent control" + Environment.NewLine +
                                "patch=1,EE,10520D54,extended,0004 //opponent AI" + Environment.NewLine +
                                "";
                                break;
                            case "Extremely Hard":
                                opponentControlCode = "" + Environment.NewLine +
                                "patch=1,EE,104D1FD8,extended,0002 //opponent control" + Environment.NewLine +
                                "patch=1,EE,10520D54,extended,0005 //opponent AI" + Environment.NewLine +
                                "";
                                break;
                        }

                        charCode += "" + Environment.NewLine + opponentControlCode;

                    }


                    //SettingsClass.OpponentControl = OpponentControlCombo.SelectedIndex;
                    //string opponentControl = Convert.ToString(OpponentControlCombo.SelectedValue);
                }
            }

            if (SettingsClass.StageValue != "XX" && !SettingsClass.StageValue.IsNullOrEmpty() && restrictP2 != true)
            {
                var stageCode = "" + Environment.NewLine +
                            "patch=1,EE,004ED64C,extended,000000" + SettingsClass.StageValue + " //Stage code (unstable)" + Environment.NewLine +
                            "";

                charCode += "" + Environment.NewLine + stageCode;
            }

            return charCode;
        }
    }
}
