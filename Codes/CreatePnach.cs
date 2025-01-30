using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.DirectoryServices;
using System.Drawing;
using Microsoft.IdentityModel.Tokens;

namespace SC3_pnach_editor.Services
{
    public class CreatePnach
    {

        public static void ExportPnach(bool extraChars, string weaponEfcP1, string weaponSpP1, bool guardianP1, bool slipperyP1,
                 string weaponEfcP2, string weaponSpP2, bool guardianP2, bool slipperyP2, string selectedChar, string selectedChar2,
                 string opponentControl, string selectedDis, string selectedDis2, bool ultWeapons, int p1Speed, int p2Speed)
        {
            if (File.Exists(SettingsClass.codeFilePath))
            {
                File.Delete(SettingsClass.codeFilePath);
            }

            string extraCharacters = "";
            if (extraChars)
            {
                extraCharacters = "" + Environment.NewLine +
                "patch=1,EE,205A4AA0,extended,2E989381 //Bonus Characters Set 1" + Environment.NewLine +
                "patch=1,EE,205A4AA4,extended,B2A6A02B //Bonus Characters Set 2" + Environment.NewLine +
                "patch=1,EE,205A4AA8,extended,E9E8E7C0 //Bonus Characters Set 3" + Environment.NewLine +
                "patch=1,EE,205A4AAC,extended,EDECEBEA //Bonus Characters Set 4" + Environment.NewLine +
                "patch=1,EE,205A4AB0,extended,A1AE94EF //Bonus Characters Set 5" + Environment.NewLine +
                "patch=1,EE,205A4AB4,extended,31B728A4 //Bonus Characters Set 6" + Environment.NewLine +
                "";
            }

            #region Weapon Special Powers

            string weaponsSpecialPower = "";
            if (weaponSpP1 == "None" && weaponSpP2 == "All Guard Break")
            {
                weaponsSpecialPower = "" + Environment.NewLine +
                "patch=1,EE,104ED9CA,extended,0001 //Enable weapon effects [Shared]" + Environment.NewLine +
                "patch=1,EE,1053CE1C,extended,0002 //Thunder Effect P2" + Environment.NewLine +
                "patch=1,EE,1053CF20,extended,0001 //Thunder Gfx P2" + Environment.NewLine +
                "patch=1,EE,2053CD40,extended,00010002 //Thunder Effect + Gfx P2 [Shared]" + Environment.NewLine +
                "";
            }
            if (weaponSpP1 == "None" && weaponSpP2 == "All Unblockable")
            {
                weaponsSpecialPower = "" + Environment.NewLine +
                "patch=1,EE,104ED9CA,extended,0001 //Enable weapon effects [Shared]" + Environment.NewLine +
                "patch=1,EE,1053CE18,extended,0002 //Fire Effect P2" + Environment.NewLine +
                "patch=1,EE,1053CFB0,extended,0001 //Fire Gfx P2" + Environment.NewLine +
                "patch=1,EE,2053CD40,extended,00010002 //Fire Effect + Gfx P2 [Shared]" + Environment.NewLine +
                "";
            }
            if (weaponSpP1 == "None" && weaponSpP2 == "Paralysis")
            {
                weaponsSpecialPower = "" + Environment.NewLine +
                "patch=1,EE,104ED9CA,extended,0001 //Enable weapon effects [Shared]" + Environment.NewLine +
                "patch=1,EE,1053CE14,extended,0001 //Paralysis Effect P2" + Environment.NewLine +
                "patch=1,EE,1053CFAC,extended,0002 //Paralysis Gfx P2" + Environment.NewLine +
                "patch=1,EE,2053CD40,extended,00020001 //Paralysis Effect + Gfx P2 [Shared]" + Environment.NewLine +
                "";
            }
            if (weaponSpP1 == "None" && weaponSpP2 == "Down Lose")
            {
                weaponsSpecialPower = "" + Environment.NewLine +
                "patch=1,EE,104ED9CA,extended,0001 //Enable weapon effects [Shared]" + Environment.NewLine +
                "patch=1,EE,1053CF34,extended,0007 //Down Lose Effect P2" + Environment.NewLine +
                "patch=1,EE,2053CD40,extended,00010000 //Down Lose Effect P1 & P2 [Shared]" + Environment.NewLine +
                "";
            }
            if (weaponSpP1 == "None" && weaponSpP2 == "Cure")
            {
                weaponsSpecialPower = "" + Environment.NewLine +
                "patch=1,EE,104D23EE,extended,3D80 // Change Weapon Heal Stat" + Environment.NewLine +
                "patch=1,EE,104ED9CA,extended,0001 // Enable weapon effects [Shared]" + Environment.NewLine +
                "patch=1,EE,1053CF48,extended,0001 // Cure Gfx P2" + Environment.NewLine +
                "patch=1,EE,2053CD40,extended,00010000 // P2 Cure" + Environment.NewLine +
                "";
            }
            if (weaponSpP1 == "None" && weaponSpP2 == "Poison")
            {
                weaponsSpecialPower = "" + Environment.NewLine +
                "patch=1,EE,104D23EE,extended,BD80 // Change Weapon Damage Stat P2" + Environment.NewLine +
                "patch=1,EE,104ED9CA,extended,0001 // Enable weapon effects [Shared]" + Environment.NewLine +
                "patch=1,EE,1053CFCC,extended,0001 // Poison Gfx P2" + Environment.NewLine +
                "patch=1,EE,2053CD40,extended,00030000 // P2 Poison" + Environment.NewLine +
                "";
            }
            if (weaponSpP1 == "All Guard Break" && weaponSpP2 == "None")
            {
                weaponsSpecialPower = "" + Environment.NewLine +
                "patch=1,EE,104ED9CA,extended,0001 //Enable weapon effects [Shared]" + Environment.NewLine +
                "patch=1,EE,1053CFA8,extended,0002 //Thunder Effect P1" + Environment.NewLine +
                "patch=1,EE,1053CD94,extended,0001 //Thunder Gfx P1" + Environment.NewLine +
                "patch=1,EE,2053CD40,extended,00020001 //Thunder Effect + Gfx P1 [Shared]" + Environment.NewLine +
                "";
            }
            if (weaponSpP1 == "All Guard Break" && weaponSpP2 == "All Guard Break")
            {
                weaponsSpecialPower = "" + Environment.NewLine +
                "patch=1,EE,104ED9CA,extended,0001 //Enable weapon effects [Shared]" + Environment.NewLine +
                "patch=1,EE,1053CFA8,extended,0002 //Thunder Effect P1" + Environment.NewLine +
                "patch=1,EE,1053CE1C,extended,0002 //Thunder Effect P2" + Environment.NewLine +
                "patch=1,EE,1053CD94,extended,0001 //Thunder Gfx P1" + Environment.NewLine +
                "patch=1,EE,1053CF20,extended,0001 //Thunder Gfx P2" + Environment.NewLine +
                "patch=1,EE,2053CD40,extended,00030003 //Thunder Effect + Gfx P1 & P2 [Shared]" + Environment.NewLine +
                "";
            }
            if (weaponSpP1 == "All Unblockable" && weaponSpP2 == "None")
            {
                weaponsSpecialPower = "" + Environment.NewLine +
                "patch=1,EE,104ED9CA,extended,0001 //Enable weapon effects [Shared]" + Environment.NewLine +
                "patch=1,EE,1053CFA4,extended,0002 //Fire Effect P1" + Environment.NewLine +
                "patch=1,EE,1053CE24,extended,0001 //Fire Gfx P1" + Environment.NewLine +
                "patch=1,EE,2053CD40,extended,00020001 //Fire Effect + Gfx P1 [Shared]" + Environment.NewLine +
                "";
            }
            if (weaponSpP1 == "All Unblockable" && weaponSpP2 == "All Unblockable")
            {
                weaponsSpecialPower = "" + Environment.NewLine +
                "patch=1,EE,104ED9CA,extended,0001 //Enable weapon effects [Shared]" + Environment.NewLine +
                "patch=1,EE,1053CFA4,extended,0002 //Fire Effect P1" + Environment.NewLine +
                "patch=1,EE,1053CE18,extended,0002 //Fire Effect P2" + Environment.NewLine +
                "patch=1,EE,1053CE24,extended,0001 //Fire Gfx P1" + Environment.NewLine +
                "patch=1,EE,1053CFB0,extended,0001 //Fire Gfx P2" + Environment.NewLine +
                "patch=1,EE,2053CD40,extended,00030003 //Fire Effect + Gfx P1 & P2 [Shared]" + Environment.NewLine +
                "";
            }
            if (weaponSpP1 == "Paralysis" && weaponSpP2 == "None")
            {
                weaponsSpecialPower = "" + Environment.NewLine +
                "patch=1,EE,104ED9CA,extended,0001 //Enable weapon effects [Shared]" + Environment.NewLine +
                "patch=1,EE,1053CFA0,extended,0001 //Paralysis Effect P1" + Environment.NewLine +
                "patch=1,EE,1053CE20,extended,0002 //Paralysis Gfx P1" + Environment.NewLine +
                "patch=1,EE,2053CD40,extended,00010002 //Paralysis Effect + Gfx P1 [Shared]" + Environment.NewLine +
                "";
            }
            if (weaponSpP1 == "Paralysis" && weaponSpP2 == "Paralysis")
            {
                weaponsSpecialPower = "" + Environment.NewLine +
                "patch=1,EE,104ED9CA,extended,0001 //Enable weapon effects [Shared]" + Environment.NewLine +
                "patch=1,EE,1053CFA0,extended,0001 //Paralysis Effect P1" + Environment.NewLine +
                "patch=1,EE,1053CE14,extended,0001 //Paralysis Effect P2" + Environment.NewLine +
                "patch=1,EE,1053CE20,extended,0002 //Paralysis Gfx P1" + Environment.NewLine +
                "patch=1,EE,1053CFAC,extended,0002 //Paralysis Gfx P2" + Environment.NewLine +
                "patch=1,EE,2053CD40,extended,00030003 //Paralysis Effect + Gfx P1 & P2 [Shared]" + Environment.NewLine +
                "";
            }
            if (weaponSpP1 == "Down Lose" && weaponSpP2 == "None")
            {
                weaponsSpecialPower = "" + Environment.NewLine +
                "patch=1,EE,104ED9CA,extended,0001 //Enable weapon effects [Shared]" + Environment.NewLine +
                "patch=1,EE,1053CDA8,extended,0007 //Down Lose Effect P1" + Environment.NewLine +
                "patch=1,EE,2053CD40,extended,00000001 //Down Lose Effect P1 & P2 [Shared]" + Environment.NewLine +
                "";
            }
            if (weaponSpP1 == "Down Lose" && weaponSpP2 == "Down Lose")
            {
                weaponsSpecialPower = "" + Environment.NewLine +
                "patch=1,EE,104ED9CA,extended,0001 //Enable weapon effects [Shared]" + Environment.NewLine +
                "patch=1,EE,1053CDA8,extended,0007 //Down Lose Effect P1" + Environment.NewLine +
                "patch=1,EE,1053CF34,extended,0007 //Down Lose Effect P2" + Environment.NewLine +
                "patch=1,EE,2053CD40,extended,00010001 //Down Lose Effect P1 & P2 [Shared]" + Environment.NewLine +
                "";
            }
            if (weaponSpP1 == "Cure" && weaponSpP2 == "None")
            {
                weaponsSpecialPower = "" + Environment.NewLine +
                "patch=1,EE,104B4C6E,extended,3D80 // Change Weapon Heal Stat" + Environment.NewLine +
                "patch=1,EE,104ED9CA,extended,0001 // Enable weapon effects [Shared]" + Environment.NewLine +
                "patch=1,EE,1053CDBC,extended,0001 // Cure Gfx P1" + Environment.NewLine +
                "patch=1,EE,2053CD40,extended,00000001 // P1 Cure" + Environment.NewLine +
                "";
            }
            if (weaponSpP1 == "Cure" && weaponSpP2 == "Cure")
            {
                weaponsSpecialPower = "" + Environment.NewLine +
                "patch=1,EE,104B4C6E,extended,3D80 // Change Weapon Heal Stat P1" + Environment.NewLine +
                "patch=1,EE,104D23EE,extended,3D80 // Change Weapon Heal Stat P2" + Environment.NewLine +
                "patch=1,EE,104ED9CA,extended,0001 // Enable weapon effects [Shared]" + Environment.NewLine +
                "patch=1,EE,1053CDBC,extended,0007 // P1 Down Lose" + Environment.NewLine +
                "patch=1,EE,1053CF48,extended,0007 // P2 Down Lose" + Environment.NewLine +
                "patch=1,EE,2053CD40,extended,00010001 // P1 & P2 Cure" + Environment.NewLine +
                "";
            }
            if (weaponSpP1 == "Poison" && weaponSpP2 == "None")
            {
                weaponsSpecialPower = "" + Environment.NewLine +
                "patch=1,EE,104B4C6E,extended,BD80 // Change Weapon Damage Stat P1" + Environment.NewLine +
                "patch=1,EE,104ED9CA,extended,0001 // Enable weapon effects [Shared]" + Environment.NewLine +
                "patch=1,EE,1053CE40,extended,0001 // Poison Gfx P1" + Environment.NewLine +
                "patch=1,EE,2053CD40,extended,00000003 // P1 Poison" + Environment.NewLine +
                "";
            }
            if (weaponSpP1 == "Poison" && weaponSpP2 == "Poison")
            {
                weaponsSpecialPower = "" + Environment.NewLine +
                "patch=1,EE,104B4C6E,extended,BD80 // Change Weapon Damage Stat P1" + Environment.NewLine +
                "patch=1,EE,104D23EE,extended,BD80 // Change Weapon Damage Stat P2" + Environment.NewLine +
                "patch=1,EE,104ED9CA,extended,0001 // Enable weapon effects [Shared]" + Environment.NewLine +
                "patch=1,EE,1053CE40,extended,0001 // P1 Poison Gfx" + Environment.NewLine +
                "patch=1,EE,1053CFCC,extended,0001 // P2 Poison Gfx" + Environment.NewLine +
                "patch=1,EE,2053CD40,extended,00030003 // P1 & P2 Poison" + Environment.NewLine +
                "";
            }

            #endregion

            string weaponEffectsP1 = "";

            #region Custom Weapon Effect Values
            string _P1_1  = "204B4C2C";
            string _P1_2  = "204B4C30";
            string _P1_3  = "204B4C34";
            string _P1_4  = "204B4C38";
            string _P1_5  = "204B4C3C";
            string _P1_6  = "204B4C40";
            string _P1_7  = "204B4C44";
            string _P1_8  = "204B4C48";
            string _P1_9  = "204B4C4C";
            string _P1_10 = "204B4C50";
            string _P1_11 = "204B4C54";
            string _P1_12 = "204B4C58";
            string _P1_13 = "204B4C5C";
            string _P1_14 = "204B4C60";
            string _P1_15 = "204B4C64";
            string _P1_16 = "204B4C68";
            string _P1_17 = "204B4C6C";
            string _P1_18 = "204B4C70";
            string _P2_1  = "204D23AC";
            string _P2_2  = "204D23B0";
            string _P2_3  = "204D23B4";
            string _P2_4  = "204D23B8";
            string _P2_5  = "204D23BC";
            string _P2_6  = "204D23C0";
            string _P2_7  = "204D23C4";
            string _P2_8  = "204D23C8";
            string _P2_9  = "204D23CC";
            string _P2_10 = "204D23D0";
            string _P2_11 = "204D23D4";
            string _P2_12 = "204D23D8";
            string _P2_13 = "204D23DC";
            string _P2_14 = "204D23E0";
            string _P2_15 = "204D23E4";
            string _P2_16 = "204D23E8";
            string _P2_17 = "204D23EC";
            string _P2_18 = "204D23F0";
            string _CV_1  = "";
            string _CV_2  = "";
            string _CV_3  = "";
            string _CV_4  = "";
            string _CV_5  = "";
            string _CV_6  = "";
            string _CV_7  = "";
            string _CV_8  = "";
            string _CV_9  = "";
            string _CV_10 = "";
            string _CV_11 = "";
            string _CV_12 = "";
            string _CV_13 = "";
            string _CV_14 = "";
            string _CV_15 = "";
            string _CV_16 = "";
            string _CV_17 = "";
            string _CV_18 = "";


            switch (SettingsClass.WpnEffect1)
            {
                case 0:
                    _CV_1 = "00000000";
                    break;
                case 1:
                    _CV_1 = "00080000";
                    break;
                case 2:
                    _CV_1 = "00100000";
                    break;
            }
            switch (SettingsClass.WpnEffect2)
            {
                case -6:
                    _CV_2 = "3E000000";
                    break;
                case -5:
                    _CV_2 = "3E400000";
                    break;
                case -4:
                    _CV_2 = "3E800000";
                    break;
                case -3:
                    _CV_2 = "3EC00000";
                    break;
                case -2:
                    _CV_2 = "3F000000";
                    break;
                case -1:
                    _CV_2 = "3F400000";
                    break;
                case 0:
                    _CV_2 = "3F800000";
                    break;
                case 1:
                    _CV_2 = "3FC00000";
                    break;
                case 2:
                    _CV_2 = "40000000";
                    break;
                case 3:
                    _CV_2 = "40400000";
                    break;
                case 4:
                    _CV_2 = "40800000";
                    break;
                case 5:
                    _CV_2 = "40C00000";
                    break;
                case 6:
                    _CV_2 = "41000000";
                    break;
                case 7:
                    _CV_2 = "41400000";
                    break;
                case 8:
                    _CV_2 = "41800000";
                    break;
                case 9:
                    _CV_2 = "41C00000";
                    break;
                case 10:
                    _CV_2 = "42000000";
                    break;
            }
            switch (SettingsClass.WpnEffect3)
            {
                case -6:
                    _CV_3 = "41000000";
                    break;
                case -5:
                    _CV_3 = "40C00000";
                    break;
                case -4:
                    _CV_3 = "40800000";
                    break;
                case -3:
                    _CV_3 = "40400000";
                    break;
                case -2:
                    _CV_3 = "40000000";
                    break;
                case -1:
                    _CV_3 = "3FC00000";
                    break;
                case 0:
                    _CV_3 = "3F800000";
                    break;
                case 1:
                    _CV_3 = "3F400000";
                    break;
                case 2:
                    _CV_3 = "3F000000";
                    break;
                case 3:
                    _CV_3 = "3EC00000";
                    break;
                case 4:
                    _CV_3 = "3E800000";
                    break;
                case 5:
                    _CV_3 = "3E400000";
                    break;
                case 6:
                    _CV_3 = "3E000000";
                    break;
                case 7:
                    _CV_3 = "3DC00000";
                    break;
                case 8:
                    _CV_3 = "3D800000";
                    break;
                case 9:
                    _CV_3 = "3D400000";
                    break;
                case 10:
                    _CV_3 = "3D000000";
                    break;
            }
            switch (SettingsClass.WpnEffect4)
            {
                case 0:
                    _CV_4 = "00000000";
                    break;
                case 1:
                    _CV_4 = "3D000000";
                    break;
                case 2:
                    _CV_4 = "3D400000";
                    break;
                case 3:
                    _CV_4 = "3D800000";
                    break;
                case 4:
                    _CV_4 = "3DC00000";
                    break;
                case 5:
                    _CV_4 = "3E000000";
                    break;
                case 6:
                    _CV_4 = "3E400000";
                    break;
                case 7:
                    _CV_4 = "3E800000";
                    break;
                case 8:
                    _CV_4 = "3EC00000";
                    break;
                case 9:
                    _CV_4 = "3F000000";
                    break;
                case 10:
                    _CV_4 = "3F400000";
                    break;
                case 11:
                    _CV_4 = "3F800000";
                    break;
                case 12:
                    _CV_4 = "3FC00000";
                    break;
                case 13:
                    _CV_4 = "40000000";
                    break;
                case 14:
                    _CV_4 = "40400000";
                    break;
                case 15:
                    _CV_4 = "40800000";
                    break;
                case 16:
                    _CV_4 = "40C00000";
                    break;
                case 17:
                    _CV_4 = "41000000";
                    break;
            }
            switch (SettingsClass.WpnEffect5)
            {
                case 0:
                    _CV_5 = "00000000";
                    break;
                case 1:
                    _CV_5 = "3D800000";
                    break;
                case 2:
                    _CV_5 = "3DC00000";
                    break;
                case 3:
                    _CV_5 = "3E000000";
                    break;
                case 4:
                    _CV_5 = "3E400000";
                    break;
                case 5:
                    _CV_5 = "3E800000";
                    break;
                case 6:
                    _CV_5 = "3EC00000";
                    break;
                case 7:
                    _CV_5 = "3F000000";
                    break;
                case 8:
                    _CV_5 = "3F400000";
                    break;
                case 9:
                    _CV_5 = "3F800000";
                    break;
                case 10:
                    _CV_5 = "3FC00000";
                    break;
                case 11:
                    _CV_5 = "40000000";
                    break;
            }
            switch (SettingsClass.WpnEffect6)
            {
                case -4:
                    _CV_6 = "3F000000";
                    break;
                case -3:
                    _CV_6 = "3F200000";
                    break;
                case -2:
                    _CV_6 = "3F400000";
                    break;
                case -1:
                    _CV_6 = "3F600000";
                    break;
                case 0:
                    _CV_6 = "3F800000";
                    break;
                case 1:
                    _CV_6 = "3FA00000";
                    break;
                case 2:
                    _CV_6 = "3FC00000";
                    break;
                case 3:
                    _CV_6 = "3FE00000";
                    break;
                case 4:
                    _CV_6 = "40000000";
                    break;
                case 5:
                    _CV_6 = "40200000";
                    break;
                case 6:
                    _CV_6 = "40400000";
                    break;
                case 7:
                    _CV_6 = "40600000";
                    break;
                case 8:
                    _CV_6 = "40800000";
                    break;
                case 9:
                    _CV_6 = "40A00000";
                    break;
                case 10:
                    _CV_6 = "40C00000";
                    break;
                case 11:
                    _CV_6 = "40E00000";
                    break;
                case 12:
                    _CV_6 = "41000000";
                    break;
            }
            switch (SettingsClass.WpnEffect7)
            {
                case -2:
                    _CV_7 = "3F000000";
                    break;
                case -1:
                    _CV_7 = "3F400000";
                    break;
                case 0:
                    _CV_7 = "3F800000";
                    break;
                case 1:
                    _CV_7 = "3FC00000";
                    break;
                case 2:
                    _CV_7 = "40000000";
                    break;
                case 3:
                    _CV_7 = "40400000";
                    break;
                case 4:
                    _CV_7 = "40800000";
                    break;
                case 5:
                    _CV_7 = "40C00000";
                    break;
                case 6:
                    _CV_7 = "41000000";
                    break;
            }
            switch (SettingsClass.WpnEffect8)
            {
                case 0:
                    _CV_8 = "00000000";
                    break;
                case 1:
                    _CV_8 = "3E000000";
                    break;
                case 2:
                    _CV_8 = "3E800000";
                    break;
                case 3:
                    _CV_8 = "3F000000";
                    break;
                case 4:
                    _CV_8 = "3F800000";
                    break;
                case 5:
                    _CV_8 = "40000000";
                    break;
            }
            switch (SettingsClass.WpnEffect9)
            {
                case 0:
                    _CV_9 = "00000000";
                    break;
                case 1:
                    _CV_9 = "3F000000";
                    break;
                case 2:
                    _CV_9 = "3F800000";
                    break;
                case 3:
                    _CV_9 = "40000000";
                    break;
            }
            switch (SettingsClass.WpnEffect10)
            {
                case -7:
                    _CV_10 = "C0000000";
                    break;
                case -6:
                    _CV_10 = "BF800000";
                    break;
                case -5:
                    _CV_10 = "BF000000";
                    break;
                case -4:
                    _CV_10 = "BE800000";
                    break;
                case -3:
                    _CV_10 = "BE000000";
                    break;
                case -2:
                    _CV_10 = "BD800000";
                    break;
                case -1:
                    _CV_10 = "BD000000";
                    break;
                case 0:
                    _CV_10 = "00000000";
                    break;
                case 1:
                    _CV_10 = "3C000000";
                    break;
                case 2:
                    _CV_10 = "3C800000";
                    break;
                case 3:
                    _CV_10 = "3D000000";
                    break;
                case 4:
                    _CV_10 = "3D800000";
                    break;
                case 5:
                    _CV_10 = "3E000000";
                    break;
                case 6:
                    _CV_10 = "3E800000";
                    break;
                case 7:
                    _CV_10 = "3F000000";
                    break;
                case 8:
                    _CV_10 = "3F800000";
                    break;
                case 9:
                    _CV_10 = "40000000";
                    break;
            }
            switch (SettingsClass.WpnEffect11)
            {
                case 0:
                    _CV_11 = "00000000";
                    break;
                case 1:
                    _CV_11 = "3DCCCCCB";
                    break;
            }
            switch (SettingsClass.WpnEffect12)
            {
                case 0:
                    _CV_12 = "00000000";
                    break;
                case 1:
                    _CV_12 = "3E800000";
                    break;
                case 2:
                    _CV_12 = "3F000000";
                    break;
                case 3:
                    _CV_12 = "3F800000";
                    break;
                case 4:
                    _CV_12 = "40000000";
                    break;
            }
            switch (SettingsClass.WpnEffect13)
            {
                case 0:
                    _CV_13 = "00000000";
                    break;
                case 1:
                    _CV_13 = "3E000000";
                    break;
                case 2:
                    _CV_13 = "3E800000";
                    break;
                case 3:
                    _CV_13 = "3F000000";
                    break;
                case 4:
                    _CV_13 = "3F800000";
                    break;
                case 5:
                    _CV_13 = "40000000";
                    break;
                case 6:
                    _CV_13 = "40800000";
                    break;
                case 7:
                    _CV_13 = "41000000";
                    break;
            }
            switch (SettingsClass.WpnEffect14)
            {
                case 0:
                    _CV_14 = "00000000";
                    break;
                case 1:
                    _CV_14 = "3D000000";
                    break;
                case 2:
                    _CV_14 = "3D800000";
                    break;
                case 3:
                    _CV_14 = "3E000000";
                    break;
                case 4:
                    _CV_14 = "3E800000";
                    break;
                case 5:
                    _CV_14 = "3F000000";
                    break;
                case 6:
                    _CV_14 = "3F800000";
                    break;
                case 7:
                    _CV_14 = "40000000";
                    break;
            }
            switch (SettingsClass.WpnEffect15)
            {
                case 0:
                    _CV_15 = "00000000";
                    break;
                case 1:
                    _CV_15 = "3E800000";
                    break;
                case 2:
                    _CV_15 = "3F000000";
                    break;
                case 3:
                    _CV_15 = "3F800000";
                    break;
                case 4:
                    _CV_15 = "40000000";
                    break;
            }
            switch (SettingsClass.WpnEffect16)
            {
                case 0:
                    _CV_16 = "00000000";
                    break;
                case 1:
                    _CV_16 = "3E000000";
                    break;
                case 2:
                    _CV_16 = "3E800000";
                    break;
                case 3:
                    _CV_16 = "3F000000";
                    break;
                case 4:
                    _CV_16 = "3F800000";
                    break;
                case 5:
                    _CV_16 = "40000000";
                    break;
            }
            switch (SettingsClass.WpnEffect17)
            {
                case -13:
                    _CV_17 = "BF000000";
                    break;
                case -12:
                    _CV_17 = "BEC00000";
                    break;
                case -11:
                    _CV_17 = "BE800000";
                    break;
                case -10:
                    _CV_17 = "BE400000";
                    break;
                case -9:
                    _CV_17 = "BE000000";
                    break;
                case -8:
                    _CV_17 = "BDC00000";
                    break;
                case -7:
                    _CV_17 = "BD800000";
                    break;
                case -6:
                    _CV_17 = "BD400000";
                    break;
                case -5:
                    _CV_17 = "BD000000";
                    break;
                case -4:
                    _CV_17 = "BCC00000";
                    break;
                case -3:
                    _CV_17 = "BC800000";
                    break;
                case -2:
                    _CV_17 = "BC400000";
                    break;
                case -1:
                    _CV_17 = "BC000000";
                    break;
                case 0:
                    _CV_17 = "00000000";
                    break;
                case 1:
                    _CV_17 = "3C000000";
                    break;
                case 2:
                    _CV_17 = "3C400000";
                    break;
                case 3:
                    _CV_17 = "3C800000";
                    break;
                case 4:
                    _CV_17 = "3CC00000";
                    break;
                case 5:
                    _CV_17 = "3D000000";
                    break;
                case 6:
                    _CV_17 = "3D400000";
                    break;
                case 7:
                    _CV_17 = "3D800000";
                    break;
                case 8:
                    _CV_17 = "3DC00000";
                    break;
                case 9:
                    _CV_17 = "3E000000";
                    break;
                case 10:
                    _CV_17 = "3E400000";
                    break;
                case 11:
                    _CV_17 = "3E800000";
                    break;
                case 12:
                    _CV_17 = "3EC00000";
                    break;
                case 13:
                    _CV_17 = "3F000000";
                    break;
            }
            switch (SettingsClass.WpnEffect18)
            {
                case -6:
                    _CV_18 = "42000000";
                    break;
                case -5:
                    _CV_18 = "41800000";
                    break;
                case -4:
                    _CV_18 = "41000000";
                    break;
                case -3:
                    _CV_18 = "40800000";
                    break;
                case -2:
                    _CV_18 = "40000000";
                    break;
                case -1:
                    _CV_18 = "3F800000";
                    break;
                case 0:
                    _CV_18 = "00000000";
                    break;
                case 1:
                    _CV_18 = "BF000000";
                    break;
                case 2:
                    _CV_18 = "BF800000";
                    break;
                case 3:
                    _CV_18 = "C0000000";
                    break;
                case 4:
                    _CV_18 = "C0800000";
                    break;
                case 5:
                    _CV_18 = "C1000000";
                    break;
                case 6:
                    _CV_18 = "C1800000";
                    break;
                case 7:
                    _CV_18 = "C2000000";
                    break;
                case 8:
                    _CV_18 = "C2800000";
                    break;
                case 9:
                    _CV_18 = "C3000000";
                    break;
            }
            #endregion

            #region Weapon Effect Codes

            switch (weaponEfcP1)
            {
                case "Custom":
                    weaponEffectsP1 = "" + Environment.NewLine +
                    "patch=1,EE," + _P1_1  + ",extended," + _CV_1  + " //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform" + Environment.NewLine +
                    "patch=1,EE," + _P1_2  + ",extended," + _CV_2  + " //Decrease/Increase Attack" + Environment.NewLine +
                    "patch=1,EE," + _P1_3  + ",extended," + _CV_3  + " //Decrease/Increase Defense" + Environment.NewLine +
                    "patch=1,EE," + _P1_4  + ",extended," + _CV_4  + " //Steal health from enemy" + Environment.NewLine +
                    "patch=1,EE," + _P1_5  + ",extended," + _CV_5  + " //Damage inflicted thru guard" + Environment.NewLine +
                    "patch=1,EE," + _P1_6  + ",extended," + _CV_6  + " //Weapon Size" + Environment.NewLine +
                    "patch=1,EE," + _P1_7  + ",extended," + _CV_7  + " //Decrease/Increase Attack Pushback Force" + Environment.NewLine +
                    "patch=1,EE," + _P1_8  + ",extended," + _CV_8  + " //Increase Counter Chance" + Environment.NewLine +
                    "patch=1,EE," + _P1_9  + ",extended," + _CV_9  + " //Nullify Enemies Counters chance" + Environment.NewLine +
                    "patch=1,EE," + _P1_10 + ",extended," + _CV_10 + " //Decrease/Increase Health while guarding enemies attacks" + Environment.NewLine +
                    "patch=1,EE," + _P1_11 + ",extended," + _CV_11 + " //Automatically Guard Impact some attacks" + Environment.NewLine +
                    "patch=1,EE," + _P1_12 + ",extended," + _CV_12 + " //Increase Damage Received by Opponent when successfully Guard Impact" + Environment.NewLine +
                    "patch=1,EE," + _P1_13 + ",extended," + _CV_13 + " //Recover Health when successfully Guard Impact" + Environment.NewLine +
                    "patch=1,EE," + _P1_14 + ",extended," + _CV_14 + " //Increase Guard Break Chance" + Environment.NewLine +
                    "patch=1,EE," + _P1_15 + ",extended," + _CV_15 + " //Increase Throw Escape Rate" + Environment.NewLine +
                    "patch=1,EE," + _P1_16 + ",extended," + _CV_16 + " //Increase Ring-Out Escape Rate" + Environment.NewLine +
                    "patch=1,EE," + _P1_17 + ",extended," + _CV_17 + " //Drain/Recover Health over Time" + Environment.NewLine +
                    "patch=1,EE," + _P1_18 + ",extended," + _CV_18 + " //Drain/Recover Health when Attacking" + Environment.NewLine +
                    "";
                    break;
                case "Soul Edge Complete":
                    weaponEffectsP1 = "" + Environment.NewLine +
                    "patch=1,EE," + _P1_1  + ",extended,00080000 //Increase Attack Over Time Player 1" + Environment.NewLine +
                    "patch=1,EE," + _P1_2  + ",extended,40200000 //Attack Player 1" + Environment.NewLine +
                    "patch=1,EE," + _P1_3  + ",extended,40000000 //Defense Player 1" + Environment.NewLine +
                    "patch=1,EE," + _P1_4  + ",extended,3F800000 //Steal Health Player 1" + Environment.NewLine +
                    "patch=1,EE," + _P1_5  + ",extended,3F000000 //Damage Give Thru Guard Player 1" + Environment.NewLine +
                    "patch=1,EE," + _P1_6  + ",extended,3FA00000 //Weapon Size Player 1" + Environment.NewLine +
                    "patch=1,EE," + _P1_7  + ",extended,3FC00000 //Pushback Enemy Force Player 1" + Environment.NewLine +
                    "patch=1,EE," + _P1_8  + ",extended,3F000000 //Counter Rate Player 1" + Environment.NewLine +
                    "patch=1,EE," + _P1_9  + ",extended,3F200000 //Nulify Counters Rate Player 1" + Environment.NewLine +
                    "patch=1,EE," + _P1_10 + ",extended,BD800000 //Damage Taken Thru Guard Player 1" + Environment.NewLine +
                    "patch=1,EE," + _P1_11 + ",extended,3E000000 //Auto Guard Impact Player 1" + Environment.NewLine +
                    "patch=1,EE," + _P1_12 + ",extended,3E000000 //Impact Damage Given Player 1" + Environment.NewLine +
                    "patch=1,EE," + _P1_13 + ",extended,3E800000 //Health Regain When Impact Player 1" + Environment.NewLine +
                    "patch=1,EE," + _P1_14 + ",extended,3F000000 //Guard Break Rate Player 1" + Environment.NewLine +
                    "patch=1,EE," + _P1_15 + ",extended,3EA00000 //Auto Guard Throws Rate Player 1" + Environment.NewLine +
                    "patch=1,EE," + _P1_16 + ",extended,3F000000 //Avoid Ring Out Rate Player 1" + Environment.NewLine +
                    "patch=1,EE," + _P1_17 + ",extended,BE000000 //Auto HP Drain Player 1" + Environment.NewLine +
                    "patch=1,EE," + _P1_18 + ",extended,40000000 //Lose HP When Attacking Drain Player 1" + Environment.NewLine +
                    "";
                    break;
                case "Soul Calibur Complete":
                    weaponEffectsP1 = "" + Environment.NewLine +
                    "patch=1,EE," + _P1_1  + ",extended,00100000 //Easier Impacts Player 1" + Environment.NewLine +
                    "patch=1,EE," + _P1_2  + ",extended,3FA00000 //Attack Player 1" + Environment.NewLine +
                    "patch=1,EE," + _P1_3  + ",extended,3E800000 //Defense Player 1" + Environment.NewLine +
                    "patch=1,EE," + _P1_4  + ",extended,00000000 //Steal Health Player 1" + Environment.NewLine +
                    "patch=1,EE," + _P1_5  + ",extended,3D800000 //Damage Give Thru Guard Player 1" + Environment.NewLine +
                    "patch=1,EE," + _P1_6  + ",extended,3F800000 //Weapon Size Player 1" + Environment.NewLine +
                    "patch=1,EE," + _P1_7  + ",extended,3F000000 //Pushback Enemy Force Player 1" + Environment.NewLine +
                    "patch=1,EE," + _P1_8  + ",extended,3E000000 //Counter Rate Player 1" + Environment.NewLine +
                    "patch=1,EE," + _P1_9  + ",extended,3F000000 //Nulify Counters Rate Player 1" + Environment.NewLine +
                    "patch=1,EE," + _P1_10 + ",extended,3D800000 //HP Recovered Thru Guard Player 1" + Environment.NewLine +
                    "patch=1,EE," + _P1_11 + ",extended,00000000 //Auto Guard Impact Player 1" + Environment.NewLine +
                    "patch=1,EE," + _P1_12 + ",extended,00000000 //Impact Damage Given Player 1" + Environment.NewLine +
                    "patch=1,EE," + _P1_13 + ",extended,3F000000 //Health Regain When Impact Player 1" + Environment.NewLine +
                    "patch=1,EE," + _P1_14 + ",extended,00000000 //Guard Break Rate Player 1" + Environment.NewLine +
                    "patch=1,EE," + _P1_15 + ",extended,3F000000 //Auto Guard Throws Rate Player 1" + Environment.NewLine +
                    "patch=1,EE," + _P1_16 + ",extended,3F000000 //Avoid Ring Out Rate Player 1" + Environment.NewLine +
                    "patch=1,EE," + _P1_17 + ",extended,3D800000 //Auto HP Recover Player 1" + Environment.NewLine +
                    "patch=1,EE," + _P1_18 + ",extended,BF200000 //Recover HP When Attacking Drain Player 1" + Environment.NewLine +
                    "";
                    break;
                case "The Ancient True Power":
                    weaponEffectsP1 = "" + Environment.NewLine +
                    "patch=1,EE," + _P1_1  + ",extended,00100000 //Easier Impacts Player 1" + Environment.NewLine +
                    "patch=1,EE," + _P1_2  + ",extended,3FA00000 //Attack Player 1" + Environment.NewLine +
                    "patch=1,EE," + _P1_3  + ",extended,3F600000 //Defense Player 1" + Environment.NewLine +
                    "patch=1,EE," + _P1_4  + ",extended,3D000000 //Steal Health Player 1" + Environment.NewLine +
                    "patch=1,EE," + _P1_5  + ",extended,3D800000 //Damage Give Thru Guard Player 1" + Environment.NewLine +
                    "patch=1,EE," + _P1_6  + ",extended,3F900000 //Weapon Size Player 1" + Environment.NewLine +
                    "patch=1,EE," + _P1_7  + ",extended,3FA00000 //Pushback Enemy Force Player 1" + Environment.NewLine +
                    "patch=1,EE," + _P1_8  + ",extended,40000000 //Counter Rate Player 1" + Environment.NewLine +
                    "patch=1,EE," + _P1_9  + ",extended,40000000 //Nulify Counters Rate Player 1" + Environment.NewLine +
                    "patch=1,EE," + _P1_10 + ",extended,3C400000 //HP Recovered Thru Guard Player 1" + Environment.NewLine +
                    "patch=1,EE," + _P1_11 + ",extended,3DCCCCCB //Auto Guard Impact Player 1" + Environment.NewLine +
                    "patch=1,EE," + _P1_12 + ",extended,3F000000 //Impact Damage Given Player 1" + Environment.NewLine +
                    "patch=1,EE," + _P1_13 + ",extended,40800000 //Health Regain When Impact Player 1" + Environment.NewLine +
                    "patch=1,EE," + _P1_14 + ",extended,3F000000 //Guard Break Rate Player 1" + Environment.NewLine +
                    "patch=1,EE," + _P1_15 + ",extended,40000000 //Auto Guard Throws Rate Player 1" + Environment.NewLine +
                    "patch=1,EE," + _P1_16 + ",extended,40000000 //Avoid Ring Out Rate Player 1" + Environment.NewLine +
                    "patch=1,EE," + _P1_17 + ",extended,00000000 //Auto HP Recover Player 1" + Environment.NewLine +
                    "patch=1,EE," + _P1_18 + ",extended,BF000000 //Recover HP When Attacking Drain Player 1" + Environment.NewLine +
                    "";
                    break;
                case "Olympus Punisher Power":
                    weaponEffectsP1 = "" + Environment.NewLine +
                    "patch=1,EE," + _P1_1  + ",extended,00000000 //Easier Impacts Player 1" + Environment.NewLine +
                    "patch=1,EE," + _P1_2  + ",extended,3FC00000 //Attack Player 1" + Environment.NewLine +
                    "patch=1,EE," + _P1_3  + ",extended,3F900000 //Defense Player 1" + Environment.NewLine +
                    "patch=1,EE," + _P1_4  + ",extended,00000000 //Steal Health Player 1" + Environment.NewLine +
                    "patch=1,EE," + _P1_5  + ",extended,3F200000 //Damage Give Thru Guard Player 1" + Environment.NewLine +
                    "patch=1,EE," + _P1_6  + ",extended,40000000 //Weapon Size Player 1" + Environment.NewLine +
                    "patch=1,EE," + _P1_7  + ",extended,40400000 //Pushback Enemy Force Player 1" + Environment.NewLine +
                    "patch=1,EE," + _P1_8  + ",extended,00000000 //Counter Rate Player 1" + Environment.NewLine +
                    "patch=1,EE," + _P1_9  + ",extended,00000000 //Nulify Counters Rate Player 1" + Environment.NewLine +
                    "patch=1,EE," + _P1_10 + ",extended,3C000000 //HP Recovered Thru Guard Player 1" + Environment.NewLine +
                    "patch=1,EE," + _P1_11 + ",extended,00000000 //Auto Guard Impact Player 1" + Environment.NewLine +
                    "patch=1,EE," + _P1_12 + ",extended,00000000 //Impact Damage Given Player 1" + Environment.NewLine +
                    "patch=1,EE," + _P1_13 + ",extended,00000000 //Health Regain When Impact Player 1" + Environment.NewLine +
                    "patch=1,EE," + _P1_14 + ",extended,3F000000 //Guard Break Rate Player 1" + Environment.NewLine +
                    "patch=1,EE," + _P1_15 + ",extended,00000000 //Auto Guard Throws Rate Player 1" + Environment.NewLine +
                    "patch=1,EE," + _P1_16 + ",extended,00000000 //Avoid Ring Out Rate Player 1" + Environment.NewLine +
                    "patch=1,EE," + _P1_17 + ",extended,00000000 //Auto HP Recover Player 1" + Environment.NewLine +
                    "patch=1,EE," + _P1_18 + ",extended,41000000 //Recover HP When Attacking Drain Player 1" + Environment.NewLine +
                    "";
                    break;
            }
            


            string weaponEffectsP2 = "";
            switch (weaponEfcP2)
            {
                case "Custom":
                    weaponEffectsP2 = "" + Environment.NewLine +
                    "patch=1,EE," + _P2_1  + ",extended," + _CV_1  + " //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform" + Environment.NewLine +
                    "patch=1,EE," + _P2_2  + ",extended," + _CV_2  + " //Decrease/Increase Attack" + Environment.NewLine +
                    "patch=1,EE," + _P2_3  + ",extended," + _CV_3  + " //Decrease/Increase Defense" + Environment.NewLine +
                    "patch=1,EE," + _P2_4  + ",extended," + _CV_4  + " //Steal health from enemy" + Environment.NewLine +
                    "patch=1,EE," + _P2_5  + ",extended," + _CV_5  + " //Damage inflicted thru guard" + Environment.NewLine +
                    "patch=1,EE," + _P2_6  + ",extended," + _CV_6  + " //Weapon Size" + Environment.NewLine +
                    "patch=1,EE," + _P2_7  + ",extended," + _CV_7  + " //Decrease/Increase Attack Pushback Force" + Environment.NewLine +
                    "patch=1,EE," + _P2_8  + ",extended," + _CV_8  + " //Increase Counter Chance" + Environment.NewLine +
                    "patch=1,EE," + _P2_9  + ",extended," + _CV_9  + " //Nullify Enemies Counters chance" + Environment.NewLine +
                    "patch=1,EE," + _P2_10 + ",extended," + _CV_10 + " //Decrease/Increase Health while guarding enemies attacks" + Environment.NewLine +
                    "patch=1,EE," + _P2_11 + ",extended," + _CV_11 + " //Automatically Guard Impact some attacks" + Environment.NewLine +
                    "patch=1,EE," + _P2_12 + ",extended," + _CV_12 + " //Increase Damage Received by Opponent when successfully Guard Impact" + Environment.NewLine +
                    "patch=1,EE," + _P2_13 + ",extended," + _CV_13 + " //Recover Health when successfully Guard Impact" + Environment.NewLine +
                    "patch=1,EE," + _P2_14 + ",extended," + _CV_14 + " //Increase Guard Break Chance" + Environment.NewLine +
                    "patch=1,EE," + _P2_15 + ",extended," + _CV_15 + " //Increase Throw Escape Rate" + Environment.NewLine +
                    "patch=1,EE," + _P2_16 + ",extended," + _CV_16 + " //Increase Ring-Out Escape Rate" + Environment.NewLine +
                    "patch=1,EE," + _P2_17 + ",extended," + _CV_17 + " //Drain/Recover Health over Time" + Environment.NewLine +
                    "patch=1,EE," + _P2_18 + ",extended," + _CV_18 + " //Drain/Recover Health when Attacking" + Environment.NewLine +
                    "";
                    break;
                case "Soul Edge Complete":
                    weaponEffectsP2 = "" + Environment.NewLine +
                    "patch=1,EE," + _P2_1  + ",extended,00080000 //Increase Attack Over Time Player 2" + Environment.NewLine +
                    "patch=1,EE," + _P2_2  + ",extended,40200000 //Attack Player 2" + Environment.NewLine +
                    "patch=1,EE," + _P2_3  + ",extended,40000000 //Defense Player 2" + Environment.NewLine +
                    "patch=1,EE," + _P2_4  + ",extended,3F800000 //Steal Health Player 2" + Environment.NewLine +
                    "patch=1,EE," + _P2_5  + ",extended,3F000000 //Damage Give Thru Guard Player 2" + Environment.NewLine +
                    "patch=1,EE," + _P2_6  + ",extended,3FA00000 //Weapon Size Player 2" + Environment.NewLine +
                    "patch=1,EE," + _P2_7  + ",extended,3FC00000 //Pushback Enemy Force Player 2" + Environment.NewLine +
                    "patch=1,EE," + _P2_8  + ",extended,3F000000 //Counter Rate Player 2" + Environment.NewLine +
                    "patch=1,EE," + _P2_9  + ",extended,3F200000 //Nulify Counters Rate Player 2" + Environment.NewLine +
                    "patch=1,EE," + _P2_10 + ",extended,BD800000 //Damage Taken Thru Guard Player 2" + Environment.NewLine +
                    "patch=1,EE," + _P2_11 + ",extended,3E000000 //Auto Guard Impact Player 2" + Environment.NewLine +
                    "patch=1,EE," + _P2_12 + ",extended,3E000000 //Impact Damage Given Player 2" + Environment.NewLine +
                    "patch=1,EE," + _P2_13 + ",extended,3E800000 //Health Regain When Impact Player 2" + Environment.NewLine +
                    "patch=1,EE," + _P2_14 + ",extended,3F000000 //Guard Break Rate Player 2" + Environment.NewLine +
                    "patch=1,EE," + _P2_15 + ",extended,3EA00000 //Auto Guard Throws Rate Player 2" + Environment.NewLine +
                    "patch=1,EE," + _P2_16 + ",extended,3F000000 //Avoid Ring Out Rate Player 2" + Environment.NewLine +
                    "patch=1,EE," + _P2_17 + ",extended,BE000000 //Auto HP Drain Player 2" + Environment.NewLine +
                    "patch=1,EE," + _P2_18 + ",extended,40000000 //Lose HP When Attacking Drain Player 2" + Environment.NewLine +
                    "";
                    break;
                case "Soul Calibur Complete":
                    weaponEffectsP2 = "" + Environment.NewLine +
                    "patch=1,EE," + _P2_1  + ",extended,00100000 //Easier Impacts Player 2" + Environment.NewLine +
                    "patch=1,EE," + _P2_2  + ",extended,3FA00000 //Attack Player 2" + Environment.NewLine +
                    "patch=1,EE," + _P2_3  + ",extended,3E800000 //Defense Player 2" + Environment.NewLine +
                    "patch=1,EE," + _P2_4  + ",extended,00000000 //Steal Health Player 2" + Environment.NewLine +
                    "patch=1,EE," + _P2_5  + ",extended,3D800000 //Damage Give Thru Guard Player 2" + Environment.NewLine +
                    "patch=1,EE," + _P2_6  + ",extended,3F800000 //Weapon Size Player 2" + Environment.NewLine +
                    "patch=1,EE," + _P2_7  + ",extended,3F000000 //Pushback Enemy Force Player 2" + Environment.NewLine +
                    "patch=1,EE," + _P2_8  + ",extended,3E000000 //Counter Rate Player 2" + Environment.NewLine +
                    "patch=1,EE," + _P2_9  + ",extended,3F000000 //Nulify Counters Rate Player 2" + Environment.NewLine +
                    "patch=1,EE," + _P2_10 + ",extended,3D800000 //HP Recovered Thru Guard Player 2" + Environment.NewLine +
                    "patch=1,EE," + _P2_11 + ",extended,00000000 //Auto Guard Impact Player 2" + Environment.NewLine +
                    "patch=1,EE," + _P2_12 + ",extended,00000000 //Impact Damage Given Player 2" + Environment.NewLine +
                    "patch=1,EE," + _P2_13 + ",extended,3F000000 //Health Regain When Impact Player 2" + Environment.NewLine +
                    "patch=1,EE," + _P2_14 + ",extended,00000000 //Guard Break Rate Player 2" + Environment.NewLine +
                    "patch=1,EE," + _P2_15 + ",extended,3F000000 //Auto Guard Throws Rate Player 2" + Environment.NewLine +
                    "patch=1,EE," + _P2_16 + ",extended,3F000000 //Avoid Ring Out Rate Player 2" + Environment.NewLine +
                    "patch=1,EE," + _P2_17 + ",extended,3D800000 //Auto HP Recover Player 2" + Environment.NewLine +
                    "patch=1,EE," + _P2_18 + ",extended,BF200000 //Recover HP When Attacking Drain Player 2" + Environment.NewLine +
                    "";
                    break;
                case "The Ancient True Power":
                    weaponEffectsP2 = "" + Environment.NewLine +
                    "patch=1,EE," + _P2_1  + ",extended,00100000 //Easier Impacts Player 2" + Environment.NewLine +
                    "patch=1,EE," + _P2_2  + ",extended,3FA00000 //Attack Player 2" + Environment.NewLine +
                    "patch=1,EE," + _P2_3  + ",extended,3F600000 //Defense Player 2" + Environment.NewLine +
                    "patch=1,EE," + _P2_4  + ",extended,3D000000 //Steal Health Player 2" + Environment.NewLine +
                    "patch=1,EE," + _P2_5  + ",extended,3D800000 //Damage Give Thru Guard Player 2" + Environment.NewLine +
                    "patch=1,EE," + _P2_6  + ",extended,3F900000 //Weapon Size Player 2" + Environment.NewLine +
                    "patch=1,EE," + _P2_7  + ",extended,3FA00000 //Pushback Enemy Force Player 2" + Environment.NewLine +
                    "patch=1,EE," + _P2_8  + ",extended,40000000 //Counter Rate Player 2" + Environment.NewLine +
                    "patch=1,EE," + _P2_9  + ",extended,40000000 //Nulify Counters Rate Player 2" + Environment.NewLine +
                    "patch=1,EE," + _P2_10 + ",extended,3C400000 //HP Recovered Thru Guard Player 2" + Environment.NewLine +
                    "patch=1,EE," + _P2_11 + ",extended,3DCCCCCB //Auto Guard Impact Player 2" + Environment.NewLine +
                    "patch=1,EE," + _P2_12 + ",extended,3F000000 //Impact Damage Given Player 2" + Environment.NewLine +
                    "patch=1,EE," + _P2_13 + ",extended,40800000 //Health Regain When Impact Player 2" + Environment.NewLine +
                    "patch=1,EE," + _P2_14 + ",extended,3F000000 //Guard Break Rate Player 2" + Environment.NewLine +
                    "patch=1,EE," + _P2_15 + ",extended,40000000 //Auto Guard Throws Rate Player 2" + Environment.NewLine +
                    "patch=1,EE," + _P2_16 + ",extended,40000000 //Avoid Ring Out Rate Player 2" + Environment.NewLine +
                    "patch=1,EE," + _P2_17 + ",extended,00000000 //Auto HP Recover Player 2" + Environment.NewLine +
                    "patch=1,EE," + _P2_18 + ",extended,BF000000 //Recover HP When Attacking Drain Player 2" + Environment.NewLine +
                    "";
                    break;
                case "Olympus Punisher Power":
                    weaponEffectsP2 = "" + Environment.NewLine +
                    "patch=1,EE," + _P2_1  + ",extended,00000000 //Easier Impacts Player 2" + Environment.NewLine +
                    "patch=1,EE," + _P2_2  + ",extended,3FC00000 //Attack Player 2" + Environment.NewLine +
                    "patch=1,EE," + _P2_3  + ",extended,3F900000 //Defense Player 2" + Environment.NewLine +
                    "patch=1,EE," + _P2_4  + ",extended,00000000 //Steal Health Player 2" + Environment.NewLine +
                    "patch=1,EE," + _P2_5  + ",extended,3F200000 //Damage Give Thru Guard Player 2" + Environment.NewLine +
                    "patch=1,EE," + _P2_6  + ",extended,40000000 //Weapon Size Player 2" + Environment.NewLine +
                    "patch=1,EE," + _P2_7  + ",extended,40400000 //Pushback Enemy Force Player 2" + Environment.NewLine +
                    "patch=1,EE," + _P2_8  + ",extended,00000000 //Counter Rate Player 2" + Environment.NewLine +
                    "patch=1,EE," + _P2_9  + ",extended,00000000 //Nulify Counters Rate Player 2" + Environment.NewLine +
                    "patch=1,EE," + _P2_10 + ",extended,3C000000 //HP Recovered Thru Guard Player 2" + Environment.NewLine +
                    "patch=1,EE," + _P2_11 + ",extended,00000000 //Auto Guard Impact Player 2" + Environment.NewLine +
                    "patch=1,EE," + _P2_12 + ",extended,00000000 //Impact Damage Given Player 2" + Environment.NewLine +
                    "patch=1,EE," + _P2_13 + ",extended,00000000 //Health Regain When Impact Player 2" + Environment.NewLine +
                    "patch=1,EE," + _P2_14 + ",extended,3F000000 //Guard Break Rate Player 2" + Environment.NewLine +
                    "patch=1,EE," + _P2_15 + ",extended,00000000 //Auto Guard Throws Rate Player 2" + Environment.NewLine +
                    "patch=1,EE," + _P2_16 + ",extended,00000000 //Avoid Ring Out Rate Player 2" + Environment.NewLine +
                    "patch=1,EE," + _P2_17 + ",extended,00000000 //Auto HP Recover Player 2" + Environment.NewLine +
                    "patch=1,EE," + _P2_18 + ",extended,41000000 //Recover HP When Attacking Drain Player 2" + Environment.NewLine +
                    "";
                    break;
            }

            #endregion


            string guardianForceP1 = "";
            if (guardianP1)
            {
                guardianForceP1 = "" + Environment.NewLine +
                "patch=1,EE,204B4AF4,extended,00020005 //Guardian Force Player 1" + Environment.NewLine +
                "";
            }

            string guardianForceP2 = "";
            if (guardianP2)
            {
                guardianForceP2 = "" + Environment.NewLine +
                "patch=1,EE,204D2274,extended,00020005 //Guardian Force Player 2" + Environment.NewLine +
                "";
            }

            string slipperyFieldP1 = "";
            if (slipperyP1)
            {
                slipperyFieldP1 = "" + Environment.NewLine +
                "patch=1,EE,1053CD40,extended,0007 //Slippery Feets Player 1" + Environment.NewLine +
                "patch=1,EE,1053CD4C,extended,0001 //Can Fall Of The Ring Player 1" + Environment.NewLine +
                "patch=1,EE,1053CD58,extended,0001 //Slippery Feets Player 1" + Environment.NewLine +
                "";
            }

            string slipperyFieldP2 = "";
            if (slipperyP2)
            {
                slipperyFieldP2 = "" + Environment.NewLine +
                "patch=1,EE,1053CD42,extended,0007 //Slippery Feets Player 2" + Environment.NewLine +
                "patch=1,EE,1053CED8,extended,0001 //Can Fall Of The Ring Player 2" + Environment.NewLine +
                "patch=1,EE,1053CEE4,extended,0001 //Slippery Feets Player 2" + Environment.NewLine +
                "";
            }


            #region Inferno Code
            string infernoCode = "";

            if (extraChars)
            {
                string infernoCodeP1_Guard = "";
                if (!guardianP1)
                {
                    infernoCodeP1_Guard = "" + Environment.NewLine +
                    "patch=1,EE,D04B4860,extended,0000002B //If P1 is Inferno" + Environment.NewLine +
                    "patch=1,EE,204B4AF4,extended,00020000 //Default Defense P1" + Environment.NewLine +
                    "";
                }
                string infernoCodeP1_Power = "";
                if (weaponEfcP1 == "Original")
                {
                    infernoCodeP1_Power = "" + Environment.NewLine +
                    "patch=1,EE,D04B4860,extended,0000002B //If P1 is Inferno" + Environment.NewLine +
                    "patch=1,EE,204B4C30,extended,40000000 //Attack Player 1" + Environment.NewLine +
                    "";
                }
                string infernoCodeP1_Discipline = "";
                infernoCodeP1_Discipline = "" + Environment.NewLine +
                "patch=1,EE,D04B4860,extended,0000002B //If P1 is Inferno" + Environment.NewLine +
                "patch=1,EE,004B4862,extended,14 //Inferno plays like Cervantes" + Environment.NewLine +
                "";
                string infernoCodeP1_Weapon = "";
                infernoCodeP1_Weapon = "" + Environment.NewLine +
                "patch=1,EE,D04B4860,extended,0000002B //If P1 is Inferno" + Environment.NewLine +
                "patch=1,EE,004B4896,extended,05 //Inferno have Soul Edge" + Environment.NewLine +
                "";

                string infernoCodeP2_Guard = "";
                if (!guardianP2)
                {
                    infernoCodeP2_Guard = "" + Environment.NewLine +
                    "patch=1,EE,D04D1FE0,extended,0000002B //If P2 is Inferno" + Environment.NewLine +
                    "patch=1,EE,204D2274,extended,00020000 //Default Defense P2" + Environment.NewLine +
                    "";
                }
                string infernoCodeP2_Power = "";
                if (weaponEfcP2 == "Original")
                {
                    infernoCodeP2_Power = "" + Environment.NewLine +
                    "patch=1,EE,D04D1FE0,extended,0000002B //If P2 is Inferno" + Environment.NewLine +
                    "patch=1,EE,204D23B0,extended,40000000 //Attack Player 2" + Environment.NewLine +
                    "";
                }
                string infernoCodeP2_Discipline = "";
                infernoCodeP2_Discipline = "" + Environment.NewLine +
                "patch=1,EE,D04D1FE0,extended,0000002B //If P2 is Inferno" + Environment.NewLine +
                "patch=1,EE,004D1FE2,extended,14 //Inferno plays like Cervantes" + Environment.NewLine +
                "";
                string infernoCodeP2_Weapon = "";
                infernoCodeP2_Weapon = "" + Environment.NewLine +
                "patch=1,EE,D04D1FE0,extended,0000002B //If P2 is Inferno" + Environment.NewLine +
                "patch=1,EE,004D2016,extended,05 //Inferno have Soul Edge" + Environment.NewLine +
                "";

                string YotoryCode = "patch=1,EE,D04B4860,extended,020000EF //If P1 is Yotory character" + Environment.NewLine +
                                    "patch=1,EE,D04B486E,extended,01000001 //If P1 is Yotory model" + Environment.NewLine +
                                    "patch=1,EE,004B4862,extended,01 //Yotory plays like Mitsurugi" + Environment.NewLine +
                                   
                                    "patch=1,EE,D04D1FE0,extended,020000EF //If P2 is Yotory character" + Environment.NewLine +
                                    "patch=1,EE,D04D1FEE,extended,01000001 //If P2 is Yotory model" + Environment.NewLine +
                                    "patch=1,EE,004D1FE2,extended,01 //Yotory plays like Mitsurugi";

                infernoCode = infernoCodeP1_Guard + infernoCodeP1_Power + infernoCodeP1_Discipline + infernoCodeP1_Weapon +
                    infernoCodeP2_Guard + infernoCodeP2_Power + infernoCodeP2_Discipline + infernoCodeP2_Weapon + YotoryCode;
            }
            #endregion


            #region Chronicles

            string selectedCharacter = "";
            string selectedModel = "";
            string charCode = "";
            string selectedCharacter2 = "";
            string selectedModel2 = "";
            string charCode2 = "";
            if (selectedChar != "None" || selectedChar2 != "None")
            {
                switch (selectedChar)
                {
                    case "Jinkai":
                        selectedCharacter = "A0";
                        selectedModel = "00";
                        break;
                    case "Kagami":
                        selectedCharacter = "A0";
                        selectedModel = "01";
                        break;
                    case "Shiun":
                        selectedCharacter = "A0";
                        selectedModel = "02";
                        break;
                    case "Shiina":
                        selectedCharacter = "A1";
                        selectedModel = "00";
                        break;
                    case "Chikage":
                        selectedCharacter = "A1";
                        selectedModel = "01";
                        break;
                    case "Konomi":
                        selectedCharacter = "A1";
                        selectedModel = "02";
                        break;
                    case "Cassius":
                        selectedCharacter = "A2";
                        selectedModel = "00";
                        break;
                    case "Saizou":
                        selectedCharacter = "A2";
                        selectedModel = "01";
                        break;
                    case "Ryouga":
                        selectedCharacter = "A2";
                        selectedModel = "02";
                        break;
                    case "Kimika":
                        selectedCharacter = "A3";
                        selectedModel = "00";
                        break;
                    case "Syunna":
                        selectedCharacter = "A3";
                        selectedModel = "01";
                        break;
                    case "Tomoe":
                        selectedCharacter = "A3";
                        selectedModel = "02";
                        break;
                    case "Meiga":
                        selectedCharacter = "A4";
                        selectedModel = "00";
                        break;
                    case "Alastor":
                        selectedCharacter = "A4";
                        selectedModel = "01";
                        break;
                    case "Shizuma":
                        selectedCharacter = "A4";
                        selectedModel = "02";
                        break;
                    case "Azumi":
                        selectedCharacter = "A5";
                        selectedModel = "00";
                        break;
                    case "Yukina":
                        selectedCharacter = "A5";
                        selectedModel = "01";
                        break;
                    case "Ouka":
                        selectedCharacter = "A5";
                        selectedModel = "02";
                        break;
                    case "Xiaoxin":
                        selectedCharacter = "A6";
                        selectedModel = "00";
                        break;
                    case "Oruks":
                        selectedCharacter = "A6";
                        selectedModel = "01";
                        break;
                    case "Agareth":
                        selectedCharacter = "A6";
                        selectedModel = "02";
                        break;
                    case "Jyuri":
                        selectedCharacter = "A7";
                        selectedModel = "00";
                        break;
                    case "Shuyu":
                        selectedCharacter = "A7";
                        selectedModel = "01";
                        break;
                    case "Mingyue":
                        selectedCharacter = "A7";
                        selectedModel = "02";
                        break;
                    case "Veles":
                        selectedCharacter = "A8";
                        selectedModel = "00";
                        break;
                    case "Aether":
                        selectedCharacter = "A8";
                        selectedModel = "01";
                        break;
                    case "Ixion":
                        selectedCharacter = "A8";
                        selectedModel = "02";
                        break;
                    case "Siulan":
                        selectedCharacter = "A9";
                        selectedModel = "00";
                        break;
                    case "Fenglin":
                        selectedCharacter = "A9";
                        selectedModel = "01";
                        break;
                    case "Philine":
                        selectedCharacter = "A9";
                        selectedModel = "02";
                        break;
                    case "Ignis":
                        selectedCharacter = "AA";
                        selectedModel = "00";
                        break;
                    case "Notus":
                        selectedCharacter = "AA";
                        selectedModel = "01";
                        break;
                    case "Azrael":
                        selectedCharacter = "AA";
                        selectedModel = "02";
                        break;
                    case "Mireille":
                        selectedCharacter = "AB";
                        selectedModel = "00";
                        break;
                    case "Aglaia":
                        selectedCharacter = "AB";
                        selectedModel = "01";
                        break;
                    case "Kanon":
                        selectedCharacter = "AB";
                        selectedModel = "02";
                        break;
                    case "Jyurai":
                        selectedCharacter = "AC";
                        selectedModel = "00";
                        break;
                    case "Kureha":
                        selectedCharacter = "AC";
                        selectedModel = "01";
                        break;
                    case "Xunyu":
                        selectedCharacter = "AC";
                        selectedModel = "02";
                        break;
                    case "Fengyu":
                        selectedCharacter = "AD";
                        selectedModel = "00";
                        break;
                    case "Fenglei":
                        selectedCharacter = "AD";
                        selectedModel = "01";
                        break;
                    case "Minglian":
                        selectedCharacter = "AD";
                        selectedModel = "02";
                        break;
                    case "Noel":
                        selectedCharacter = "AE";
                        selectedModel = "00";
                        break;
                    case "Rudiger":
                        selectedCharacter = "AE";
                        selectedModel = "01";
                        break;
                    case "Aeneas":
                        selectedCharacter = "AE";
                        selectedModel = "02";
                        break;
                    case "Annaretta":
                        selectedCharacter = "AF";
                        selectedModel = "00";
                        break;
                    case "Iris":
                        selectedCharacter = "AF";
                        selectedModel = "01";
                        break;
                    case "Brunhild":
                        selectedCharacter = "AF";
                        selectedModel = "02";
                        break;
                    case "Asrafil":
                        selectedCharacter = "B0";
                        selectedModel = "00";
                        break;
                    case "Zifeng":
                        selectedCharacter = "B0";
                        selectedModel = "01";
                        break;
                    case "Aeolos":
                        selectedCharacter = "B0";
                        selectedModel = "02";
                        break;
                    case "Amrita":
                        selectedCharacter = "B1";
                        selectedModel = "00";
                        break;
                    case "Azalea":
                        selectedCharacter = "B1";
                        selectedModel = "01";
                        break;
                    case "Yueliang":
                        selectedCharacter = "B1";
                        selectedModel = "02";
                        break;
                    case "Kanade":
                        selectedCharacter = "B2";
                        selectedModel = "00";
                        break;
                    case "Domenthi":
                        selectedCharacter = "B2";
                        selectedModel = "01";
                        break;
                    case "Marid":
                        selectedCharacter = "B2";
                        selectedModel = "02";
                        break;
                    case "Ambrose":
                        selectedCharacter = "B3";
                        selectedModel = "00";
                        break;
                    case "Ailian":
                        selectedCharacter = "B3";
                        selectedModel = "01";
                        break;
                    case "Aika":
                        selectedCharacter = "B3";
                        selectedModel = "02";
                        break;
                    case "Loki":
                        selectedCharacter = "B4";
                        selectedModel = "00";
                        break;
                    case "Celestis":
                        selectedCharacter = "B4";
                        selectedModel = "01";
                        break;
                    case "Beleth":
                        selectedCharacter = "B4";
                        selectedModel = "02";
                        break;
                    case "Karen":
                        selectedCharacter = "B5";
                        selectedModel = "00";
                        break;
                    case "Lilan":
                        selectedCharacter = "B5";
                        selectedModel = "01";
                        break;
                    case "Abigail":
                        selectedCharacter = "B5";
                        selectedModel = "02";
                        break;
                    case "Balduin":
                        selectedCharacter = "B6";
                        selectedModel = "00";
                        break;
                    case "Aloces":
                        selectedCharacter = "B6";
                        selectedModel = "01";
                        break;
                    case "Areon":
                        selectedCharacter = "B6";
                        selectedModel = "02";
                        break;
                    case "Juno":
                        selectedCharacter = "B7";
                        selectedModel = "00";
                        break;
                    case "Eurydice":
                        selectedCharacter = "B7";
                        selectedModel = "01";
                        break;
                    case "Ishtar":
                        selectedCharacter = "B7";
                        selectedModel = "02";
                        break;
                    case "Rufus":
                        selectedCharacter = "B8";
                        selectedModel = "00";
                        break;
                    case "Raguel":
                        selectedCharacter = "B8";
                        selectedModel = "01";
                        break;
                    case "Feofan":
                        selectedCharacter = "B8";
                        selectedModel = "02";
                        break;
                    case "Eunice":
                        selectedCharacter = "B9";
                        selectedModel = "00";
                        break;
                    case "Acacia":
                        selectedCharacter = "B9";
                        selectedModel = "01";
                        break;
                    case "Hilda":
                        selectedCharacter = "B9";
                        selectedModel = "02";
                        break;
                    case "Iblis":
                        selectedCharacter = "BA";
                        selectedModel = "00";
                        break;
                    case "Alberic":
                        selectedCharacter = "BA";
                        selectedModel = "01";
                        break;
                    case "Leshy":
                        selectedCharacter = "BA";
                        selectedModel = "02";
                        break;
                    case "Muriel":
                        selectedCharacter = "BB";
                        selectedModel = "00";
                        break;
                    case "Wenli":
                        selectedCharacter = "BB";
                        selectedModel = "01";
                        break;
                    case "Irene":
                        selectedCharacter = "BB";
                        selectedModel = "02";
                        break;
                    case "Yufeng":
                        selectedCharacter = "BC";
                        selectedModel = "00";
                        break;
                    case "Yakumo":
                        selectedCharacter = "BC";
                        selectedModel = "01";
                        break;
                    case "Dufeng":
                        selectedCharacter = "BC";
                        selectedModel = "02";
                        break;
                    case "Mayura":
                        selectedCharacter = "BD";
                        selectedModel = "00";
                        break;
                    case "Meilan":
                        selectedCharacter = "BD";
                        selectedModel = "01";
                        break;
                    case "Rhea":
                        selectedCharacter = "BD";
                        selectedModel = "02";
                        break;
                    case "Halphas":
                        selectedCharacter = "BE";
                        selectedModel = "00";
                        break;
                    case "Gorus":
                        selectedCharacter = "BE";
                        selectedModel = "01";
                        break;
                    case "Ilyusha":
                        selectedCharacter = "BE";
                        selectedModel = "02";
                        break;
                    case "Edith":
                        selectedCharacter = "BF";
                        selectedModel = "00";
                        break;
                    case "Riese":
                        selectedCharacter = "BF";
                        selectedModel = "01";
                        break;
                    case "Agave":
                        selectedCharacter = "BF";
                        selectedModel = "02";
                        break;
                    case "Haystir":
                        selectedCharacter = "C0";
                        selectedModel = "00";
                        break;
                    case "Leraje":
                        selectedCharacter = "C0";
                        selectedModel = "01";
                        break;
                    case "Ratziel":
                        selectedCharacter = "C0";
                        selectedModel = "02";
                        break;
                    case "Katina":
                        selectedCharacter = "C1";
                        selectedModel = "00";
                        break;
                    case "Eris":
                        selectedCharacter = "C1";
                        selectedModel = "01";
                        break;
                    case "Sizuku":
                        selectedCharacter = "C1";
                        selectedModel = "02";
                        break;

                    case "Aege_1":
                        selectedCharacter = "E7";
                        selectedModel = "00";
                        break;
                    case "Aege_2":
                        selectedCharacter = "E7";
                        selectedModel = "01";
                        break;
                    case "Heal-Do_1":
                        selectedCharacter = "E8";
                        selectedModel = "00";
                        break;
                    case "Heal-Do_2":
                        selectedCharacter = "E8";
                        selectedModel = "01";
                        break;
                    case "Elua_1":
                        selectedCharacter = "E9";
                        selectedModel = "00";
                        break;
                    case "Elua_2":
                        selectedCharacter = "E9";
                        selectedModel = "01";
                        break;
                    case "Lupi_1":
                        selectedCharacter = "EA";
                        selectedModel = "00";
                        break;
                    case "Lupi_2":
                        selectedCharacter = "EA";
                        selectedModel = "01";
                        break;
                    case "Roin_1":
                        selectedCharacter = "EB";
                        selectedModel = "00";
                        break;
                    case "Roin_2":
                        selectedCharacter = "EB";
                        selectedModel = "01";
                        break;
                    case "Kierkess_1":
                        selectedCharacter = "EC";
                        selectedModel = "00";
                        break;
                    case "Kierkess_2":
                        selectedCharacter = "EC";
                        selectedModel = "01";
                        break;
                    case "Hyle_1":
                        selectedCharacter = "ED";
                        selectedModel = "00";
                        break;
                    case "Hyle_2":
                        selectedCharacter = "ED";
                        selectedModel = "01";
                        break;
                    case "Mooncalf":
                        selectedCharacter = "EE";
                        selectedModel = "00";
                        break;
                    case "Ende":
                        selectedCharacter = "EF";
                        selectedModel = "00";
                        break;

                    case "Grandall_M":
                        switch (selectedDis)
                        {
                            case "Katana & Shuriken":
                                selectedCharacter = "A0";
                                selectedModel = "03";
                                break;
                            case "Kunai":
                                selectedCharacter = "A2";
                                selectedModel = "03";
                                break;
                            case "Katana":
                                selectedCharacter = "A4";
                                selectedModel = "03";
                                break;
                            case "Chinese Sword":
                                selectedCharacter = "A6";
                                selectedModel = "03";
                                break;
                            case "Chinese Blade":
                                selectedCharacter = "A8";
                                selectedModel = "03";
                                break;
                            case "Grieve Edge":
                                selectedCharacter = "AA";
                                selectedModel = "03";
                                break;
                            case "Staff":
                                selectedCharacter = "AC";
                                selectedModel = "03";
                                break;
                            case "Lance":
                                selectedCharacter = "AE";
                                selectedModel = "03";
                                break;
                            case "Steel Fan":
                                selectedCharacter = "B0";
                                selectedModel = "03";
                                break;
                            case "Sickle":
                                selectedCharacter = "B2";
                                selectedModel = "03";
                                break;
                            case "Dagger":
                                selectedCharacter = "B4";
                                selectedModel = "03";
                                break;
                            case "Iron Sword":
                                selectedCharacter = "B6";
                                selectedModel = "03";
                                break;
                            case "Sword & Shield":
                                selectedCharacter = "B8";
                                selectedModel = "03";
                                break;
                            case "Tambourine":
                                selectedCharacter = "BA";
                                selectedModel = "03";
                                break;
                            case "Nunchaku":
                                selectedCharacter = "BC";
                                selectedModel = "03";
                                break;
                            case "Wave Sword":
                                selectedCharacter = "BE";
                                selectedModel = "03";
                                break;
                            case "Rapier":
                                selectedCharacter = "C0";
                                selectedModel = "03";
                                break;
                        }
                        break;
                    case "Grandall_F":
                        switch (selectedDis)
                        {
                            case "Katana & Shuriken":
                                selectedCharacter = "A1";
                                selectedModel = "03";
                                break;
                            case "Kunai":
                                selectedCharacter = "A3";
                                selectedModel = "03";
                                break;
                            case "Katana":
                                selectedCharacter = "A5";
                                selectedModel = "03";
                                break;
                            case "Chinese Sword":
                                selectedCharacter = "A7";
                                selectedModel = "03";
                                break;
                            case "Chinese Blade":
                                selectedCharacter = "A9";
                                selectedModel = "03";
                                break;
                            case "Grieve Edge":
                                selectedCharacter = "AB";
                                selectedModel = "03";
                                break;
                            case "Staff":
                                selectedCharacter = "AD";
                                selectedModel = "03";
                                break;
                            case "Lance":
                                selectedCharacter = "AF";
                                selectedModel = "03";
                                break;
                            case "Steel Fan":
                                selectedCharacter = "B0";
                                selectedModel = "03";
                                break;
                            case "Sickle":
                                selectedCharacter = "B3";
                                selectedModel = "03";
                                break;
                            case "Dagger":
                                selectedCharacter = "B5";
                                selectedModel = "03";
                                break;
                            case "Iron Sword":
                                selectedCharacter = "B7";
                                selectedModel = "03";
                                break;
                            case "Sword & Shield":
                                selectedCharacter = "B9";
                                selectedModel = "03";
                                break;
                            case "Tambourine":
                                selectedCharacter = "BB";
                                selectedModel = "03";
                                break;
                            case "Nunchaku":
                                selectedCharacter = "BD";
                                selectedModel = "03";
                                break;
                            case "Wave Sword":
                                selectedCharacter = "BF";
                                selectedModel = "03";
                                break;
                            case "Rapier":
                                selectedCharacter = "C1";
                                selectedModel = "03";
                                break;
                        }
                        break;
                    case "Dalkia_M":
                        switch (selectedDis)
                        {
                            case "Katana & Shuriken":
                                selectedCharacter = "A0";
                                selectedModel = "04";
                                break;
                            case "Kunai":
                                selectedCharacter = "A2";
                                selectedModel = "04";
                                break;
                            case "Katana":
                                selectedCharacter = "A4";
                                selectedModel = "04";
                                break;
                            case "Chinese Sword":
                                selectedCharacter = "A6";
                                selectedModel = "04";
                                break;
                            case "Chinese Blade":
                                selectedCharacter = "A8";
                                selectedModel = "04";
                                break;
                            case "Grieve Edge":
                                selectedCharacter = "AA";
                                selectedModel = "04";
                                break;
                            case "Staff":
                                selectedCharacter = "AC";
                                selectedModel = "04";
                                break;
                            case "Lance":
                                selectedCharacter = "AE";
                                selectedModel = "04";
                                break;
                            case "Steel Fan":
                                selectedCharacter = "B0";
                                selectedModel = "04";
                                break;
                            case "Sickle":
                                selectedCharacter = "B2";
                                selectedModel = "04";
                                break;
                            case "Dagger":
                                selectedCharacter = "B4";
                                selectedModel = "04";
                                break;
                            case "Iron Sword":
                                selectedCharacter = "B6";
                                selectedModel = "04";
                                break;
                            case "Sword & Shield":
                                selectedCharacter = "B8";
                                selectedModel = "04";
                                break;
                            case "Tambourine":
                                selectedCharacter = "BA";
                                selectedModel = "04";
                                break;
                            case "Nunchaku":
                                selectedCharacter = "BC";
                                selectedModel = "04";
                                break;
                            case "Wave Sword":
                                selectedCharacter = "BE";
                                selectedModel = "04";
                                break;
                            case "Rapier":
                                selectedCharacter = "C0";
                                selectedModel = "04";
                                break;
                        }
                        break;
                    case "Dalkia_F":
                        switch (selectedDis)
                        {
                            case "Katana & Shuriken":
                                selectedCharacter = "A1";
                                selectedModel = "04";
                                break;
                            case "Kunai":
                                selectedCharacter = "A3";
                                selectedModel = "04";
                                break;
                            case "Katana":
                                selectedCharacter = "A5";
                                selectedModel = "04";
                                break;
                            case "Chinese Sword":
                                selectedCharacter = "A7";
                                selectedModel = "04";
                                break;
                            case "Chinese Blade":
                                selectedCharacter = "A9";
                                selectedModel = "04";
                                break;
                            case "Grieve Edge":
                                selectedCharacter = "AB";
                                selectedModel = "04";
                                break;
                            case "Staff":
                                selectedCharacter = "AD";
                                selectedModel = "04";
                                break;
                            case "Lance":
                                selectedCharacter = "AF";
                                selectedModel = "04";
                                break;
                            case "Steel Fan":
                                selectedCharacter = "B1";
                                selectedModel = "04";
                                break;
                            case "Sickle":
                                selectedCharacter = "B3";
                                selectedModel = "04";
                                break;
                            case "Dagger":
                                selectedCharacter = "B5";
                                selectedModel = "04";
                                break;
                            case "Iron Sword":
                                selectedCharacter = "B7";
                                selectedModel = "04";
                                break;
                            case "Sword & Shield":
                                selectedCharacter = "B9";
                                selectedModel = "04";
                                break;
                            case "Tambourine":
                                selectedCharacter = "BB";
                                selectedModel = "04";
                                break;
                            case "Nunchaku":
                                selectedCharacter = "BD";
                                selectedModel = "04";
                                break;
                            case "Wave Sword":
                                selectedCharacter = "BF";
                                selectedModel = "04";
                                break;
                            case "Rapier":
                                selectedCharacter = "C1";
                                selectedModel = "04";
                                break;
                        }
                        break;
                    case "Brigand_M":
                        switch (selectedDis)
                        {
                            case "Katana & Shuriken":
                                selectedCharacter = "A0";
                                selectedModel = "05";
                                break;
                            case "Kunai":
                                selectedCharacter = "A2";
                                selectedModel = "05";
                                break;
                            case "Katana":
                                selectedCharacter = "A4";
                                selectedModel = "05";
                                break;
                            case "Chinese Sword":
                                selectedCharacter = "A6";
                                selectedModel = "05";
                                break;
                            case "Chinese Blade":
                                selectedCharacter = "A8";
                                selectedModel = "05";
                                break;
                            case "Grieve Edge":
                                selectedCharacter = "AA";
                                selectedModel = "05";
                                break;
                            case "Staff":
                                selectedCharacter = "AC";
                                selectedModel = "05";
                                break;
                            case "Lance":
                                selectedCharacter = "AE";
                                selectedModel = "05";
                                break;
                            case "Steel Fan":
                                selectedCharacter = "B0";
                                selectedModel = "05";
                                break;
                            case "Sickle":
                                selectedCharacter = "B2";
                                selectedModel = "05";
                                break;
                            case "Dagger":
                                selectedCharacter = "B4";
                                selectedModel = "05";
                                break;
                            case "Iron Sword":
                                selectedCharacter = "B6";
                                selectedModel = "05";
                                break;
                            case "Sword & Shield":
                                selectedCharacter = "B8";
                                selectedModel = "05";
                                break;
                            case "Tambourine":
                                selectedCharacter = "BA";
                                selectedModel = "05";
                                break;
                            case "Nunchaku":
                                selectedCharacter = "BC";
                                selectedModel = "05";
                                break;
                            case "Wave Sword":
                                selectedCharacter = "BE";
                                selectedModel = "05";
                                break;
                            case "Rapier":
                                selectedCharacter = "C0";
                                selectedModel = "05";
                                break;
                        }
                        break;
                    case "Brigand_F":
                        switch (selectedDis)
                        {
                            case "Katana & Shuriken":
                                selectedCharacter = "A1";
                                selectedModel = "05";
                                break;
                            case "Kunai":
                                selectedCharacter = "A3";
                                selectedModel = "05";
                                break;
                            case "Katana":
                                selectedCharacter = "A5";
                                selectedModel = "05";
                                break;
                            case "Chinese Sword":
                                selectedCharacter = "A7";
                                selectedModel = "05";
                                break;
                            case "Chinese Blade":
                                selectedCharacter = "A9";
                                selectedModel = "05";
                                break;
                            case "Grieve Edge":
                                selectedCharacter = "AB";
                                selectedModel = "05";
                                break;
                            case "Staff":
                                selectedCharacter = "AD";
                                selectedModel = "05";
                                break;
                            case "Lance":
                                selectedCharacter = "AF";
                                selectedModel = "05";
                                break;
                            case "Steel Fan":
                                selectedCharacter = "B1";
                                selectedModel = "05";
                                break;
                            case "Sickle":
                                selectedCharacter = "B3";
                                selectedModel = "05";
                                break;
                            case "Dagger":
                                selectedCharacter = "B5";
                                selectedModel = "05";
                                break;
                            case "Iron Sword":
                                selectedCharacter = "B7";
                                selectedModel = "05";
                                break;
                            case "Sword & Shield":
                                selectedCharacter = "B9";
                                selectedModel = "05";
                                break;
                            case "Tambourine":
                                selectedCharacter = "BB";
                                selectedModel = "05";
                                break;
                            case "Nunchaku":
                                selectedCharacter = "BD";
                                selectedModel = "05";
                                break;
                            case "Wave Sword":
                                selectedCharacter = "BF";
                                selectedModel = "05";
                                break;
                            case "Rapier":
                                selectedCharacter = "C1";
                                selectedModel = "05";
                                break;
                        }
                        break;
                    case "Maletta_M":
                        switch (selectedDis)
                        {
                            case "Katana & Shuriken":
                                selectedCharacter = "A0";
                                selectedModel = "06";
                                break;
                            case "Kunai":
                                selectedCharacter = "A2";
                                selectedModel = "06";
                                break;
                            case "Katana":
                                selectedCharacter = "A4";
                                selectedModel = "06";
                                break;
                            case "Chinese Sword":
                                selectedCharacter = "A6";
                                selectedModel = "06";
                                break;
                            case "Chinese Blade":
                                selectedCharacter = "A8";
                                selectedModel = "06";
                                break;
                            case "Grieve Edge":
                                selectedCharacter = "AA";
                                selectedModel = "06";
                                break;
                            case "Staff":
                                selectedCharacter = "AC";
                                selectedModel = "06";
                                break;
                            case "Lance":
                                selectedCharacter = "AE";
                                selectedModel = "06";
                                break;
                            case "Steel Fan":
                                selectedCharacter = "B0";
                                selectedModel = "06";
                                break;
                            case "Sickle":
                                selectedCharacter = "B2";
                                selectedModel = "06";
                                break;
                            case "Dagger":
                                selectedCharacter = "B4";
                                selectedModel = "06";
                                break;
                            case "Iron Sword":
                                selectedCharacter = "B6";
                                selectedModel = "06";
                                break;
                            case "Sword & Shield":
                                selectedCharacter = "B8";
                                selectedModel = "06";
                                break;
                            case "Tambourine":
                                selectedCharacter = "BA";
                                selectedModel = "06";
                                break;
                            case "Nunchaku":
                                selectedCharacter = "BC";
                                selectedModel = "06";
                                break;
                            case "Wave Sword":
                                selectedCharacter = "BE";
                                selectedModel = "06";
                                break;
                            case "Rapier":
                                selectedCharacter = "C0";
                                selectedModel = "06";
                                break;
                        }
                        break;
                    case "Maletta_F":
                        switch (selectedDis)
                        {
                            case "Katana & Shuriken":
                                selectedCharacter = "A1";
                                selectedModel = "06";
                                break;
                            case "Kunai":
                                selectedCharacter = "A3";
                                selectedModel = "06";
                                break;
                            case "Katana":
                                selectedCharacter = "A5";
                                selectedModel = "06";
                                break;
                            case "Chinese Sword":
                                selectedCharacter = "A7";
                                selectedModel = "06";
                                break;
                            case "Chinese Blade":
                                selectedCharacter = "A9";
                                selectedModel = "06";
                                break;
                            case "Grieve Edge":
                                selectedCharacter = "AB";
                                selectedModel = "06";
                                break;
                            case "Staff":
                                selectedCharacter = "AD";
                                selectedModel = "06";
                                break;
                            case "Lance":
                                selectedCharacter = "AF";
                                selectedModel = "06";
                                break;
                            case "Steel Fan":
                                selectedCharacter = "B1";
                                selectedModel = "06";
                                break;
                            case "Sickle":
                                selectedCharacter = "B3";
                                selectedModel = "06";
                                break;
                            case "Dagger":
                                selectedCharacter = "B5";
                                selectedModel = "06";
                                break;
                            case "Iron Sword":
                                selectedCharacter = "B7";
                                selectedModel = "06";
                                break;
                            case "Sword & Shield":
                                selectedCharacter = "B9";
                                selectedModel = "06";
                                break;
                            case "Tambourine":
                                selectedCharacter = "BB";
                                selectedModel = "06";
                                break;
                            case "Nunchaku":
                                selectedCharacter = "BD";
                                selectedModel = "06";
                                break;
                            case "Wave Sword":
                                selectedCharacter = "BF";
                                selectedModel = "06";
                                break;
                            case "Rapier":
                                selectedCharacter = "C1";
                                selectedModel = "06";
                                break;
                        }
                        break;
                    case "Rebel_M":
                        switch (selectedDis)
                        {
                            case "Katana & Shuriken":
                                selectedCharacter = "A0";
                                selectedModel = "07";
                                break;
                            case "Kunai":
                                selectedCharacter = "A2";
                                selectedModel = "07";
                                break;
                            case "Katana":
                                selectedCharacter = "A4";
                                selectedModel = "07";
                                break;
                            case "Chinese Sword":
                                selectedCharacter = "A6";
                                selectedModel = "07";
                                break;
                            case "Chinese Blade":
                                selectedCharacter = "A8";
                                selectedModel = "03";
                                break;
                            case "Grieve Edge":
                                selectedCharacter = "AA";
                                selectedModel = "07";
                                break;
                            case "Staff":
                                selectedCharacter = "AC";
                                selectedModel = "07";
                                break;
                            case "Lance":
                                selectedCharacter = "AE";
                                selectedModel = "07";
                                break;
                            case "Steel Fan":
                                selectedCharacter = "B0";
                                selectedModel = "07";
                                break;
                            case "Sickle":
                                selectedCharacter = "B2";
                                selectedModel = "07";
                                break;
                            case "Dagger":
                                selectedCharacter = "B4";
                                selectedModel = "07";
                                break;
                            case "Iron Sword":
                                selectedCharacter = "B6";
                                selectedModel = "07";
                                break;
                            case "Sword & Shield":
                                selectedCharacter = "B8";
                                selectedModel = "07";
                                break;
                            case "Tambourine":
                                selectedCharacter = "BA";
                                selectedModel = "07";
                                break;
                            case "Nunchaku":
                                selectedCharacter = "BC";
                                selectedModel = "07";
                                break;
                            case "Wave Sword":
                                selectedCharacter = "BE";
                                selectedModel = "07";
                                break;
                            case "Rapier":
                                selectedCharacter = "C0";
                                selectedModel = "07";
                                break;
                        }
                        break;
                    case "Rebel_F":
                        switch (selectedDis)
                        {
                            case "Katana & Shuriken":
                                selectedCharacter = "A1";
                                selectedModel = "07";
                                break;
                            case "Kunai":
                                selectedCharacter = "A3";
                                selectedModel = "07";
                                break;
                            case "Katana":
                                selectedCharacter = "A5";
                                selectedModel = "07";
                                break;
                            case "Chinese Sword":
                                selectedCharacter = "A7";
                                selectedModel = "07";
                                break;
                            case "Chinese Blade":
                                selectedCharacter = "A9";
                                selectedModel = "07";
                                break;
                            case "Grieve Edge":
                                selectedCharacter = "AB";
                                selectedModel = "07";
                                break;
                            case "Staff":
                                selectedCharacter = "AD";
                                selectedModel = "07";
                                break;
                            case "Lance":
                                selectedCharacter = "AF";
                                selectedModel = "07";
                                break;
                            case "Steel Fan":
                                selectedCharacter = "B1";
                                selectedModel = "07";
                                break;
                            case "Sickle":
                                selectedCharacter = "B3";
                                selectedModel = "07";
                                break;
                            case "Dagger":
                                selectedCharacter = "B5";
                                selectedModel = "07";
                                break;
                            case "Iron Sword":
                                selectedCharacter = "B7";
                                selectedModel = "07";
                                break;
                            case "Sword & Shield":
                                selectedCharacter = "B9";
                                selectedModel = "07";
                                break;
                            case "Tambourine":
                                selectedCharacter = "BB";
                                selectedModel = "07";
                                break;
                            case "Nunchaku":
                                selectedCharacter = "BD";
                                selectedModel = "07";
                                break;
                            case "Wave Sword":
                                selectedCharacter = "BF";
                                selectedModel = "07";
                                break;
                            case "Rapier":
                                selectedCharacter = "C1";
                                selectedModel = "07";
                                break;
                        }
                        break;
                }

                charCode = "" + Environment.NewLine +
                    "patch=1,EE,004B4860,extended," + selectedCharacter + " //Character" + Environment.NewLine +
                    "patch=1,EE,004B486E,extended," + selectedModel + " //Model" + Environment.NewLine +
                    "";


                switch (selectedChar2)
                {
                    case "Jinkai":
                        selectedCharacter2 = "A0";
                        selectedModel2 = "00";
                        break;
                    case "Kagami":
                        selectedCharacter2 = "A0";
                        selectedModel2 = "01";
                        break;
                    case "Shiun":
                        selectedCharacter2 = "A0";
                        selectedModel2 = "02";
                        break;
                    case "Shiina":
                        selectedCharacter2 = "A1";
                        selectedModel2 = "00";
                        break;
                    case "Chikage":
                        selectedCharacter2 = "A1";
                        selectedModel2 = "01";
                        break;
                    case "Konomi":
                        selectedCharacter2 = "A1";
                        selectedModel2 = "02";
                        break;
                    case "Cassius":
                        selectedCharacter2 = "A2";
                        selectedModel2 = "00";
                        break;
                    case "Saizou":
                        selectedCharacter2 = "A2";
                        selectedModel2 = "01";
                        break;
                    case "Ryouga":
                        selectedCharacter2 = "A2";
                        selectedModel2 = "02";
                        break;
                    case "Kimika":
                        selectedCharacter2 = "A3";
                        selectedModel2 = "00";
                        break;
                    case "Syunna":
                        selectedCharacter2 = "A3";
                        selectedModel2 = "01";
                        break;
                    case "Tomoe":
                        selectedCharacter2 = "A3";
                        selectedModel2 = "02";
                        break;
                    case "Meiga":
                        selectedCharacter2 = "A4";
                        selectedModel2 = "00";
                        break;
                    case "Alastor":
                        selectedCharacter2 = "A4";
                        selectedModel2 = "01";
                        break;
                    case "Shizuma":
                        selectedCharacter2 = "A4";
                        selectedModel2 = "02";
                        break;
                    case "Azumi":
                        selectedCharacter2 = "A5";
                        selectedModel2 = "00";
                        break;
                    case "Yukina":
                        selectedCharacter2 = "A5";
                        selectedModel2 = "01";
                        break;
                    case "Ouka":
                        selectedCharacter2 = "A5";
                        selectedModel2 = "02";
                        break;
                    case "Xiaoxin":
                        selectedCharacter2 = "A6";
                        selectedModel2 = "00";
                        break;
                    case "Oruks":
                        selectedCharacter2 = "A6";
                        selectedModel2 = "01";
                        break;
                    case "Agareth":
                        selectedCharacter2 = "A6";
                        selectedModel2 = "02";
                        break;
                    case "Jyuri":
                        selectedCharacter2 = "A7";
                        selectedModel2 = "00";
                        break;
                    case "Shuyu":
                        selectedCharacter2 = "A7";
                        selectedModel2 = "01";
                        break;
                    case "Mingyue":
                        selectedCharacter2 = "A7";
                        selectedModel2 = "02";
                        break;
                    case "Veles":
                        selectedCharacter2 = "A8";
                        selectedModel2 = "00";
                        break;
                    case "Aether":
                        selectedCharacter2 = "A8";
                        selectedModel2 = "01";
                        break;
                    case "Ixion":
                        selectedCharacter2 = "A8";
                        selectedModel2 = "02";
                        break;
                    case "Siulan":
                        selectedCharacter2 = "A9";
                        selectedModel2 = "00";
                        break;
                    case "Fenglin":
                        selectedCharacter2 = "A9";
                        selectedModel2 = "01";
                        break;
                    case "Philine":
                        selectedCharacter2 = "A9";
                        selectedModel2 = "02";
                        break;
                    case "Ignis":
                        selectedCharacter2 = "AA";
                        selectedModel2 = "00";
                        break;
                    case "Notus":
                        selectedCharacter2 = "AA";
                        selectedModel2 = "01";
                        break;
                    case "Azrael":
                        selectedCharacter2 = "AA";
                        selectedModel2 = "02";
                        break;
                    case "Mireille":
                        selectedCharacter2 = "AB";
                        selectedModel2 = "00";
                        break;
                    case "Aglaia":
                        selectedCharacter2 = "AB";
                        selectedModel2 = "01";
                        break;
                    case "Kanon":
                        selectedCharacter2 = "AB";
                        selectedModel2 = "02";
                        break;
                    case "Jyurai":
                        selectedCharacter2 = "AC";
                        selectedModel2 = "00";
                        break;
                    case "Kureha":
                        selectedCharacter2 = "AC";
                        selectedModel2 = "01";
                        break;
                    case "Xunyu":
                        selectedCharacter2 = "AC";
                        selectedModel2 = "02";
                        break;
                    case "Fengyu":
                        selectedCharacter2 = "AD";
                        selectedModel2 = "00";
                        break;
                    case "Fenglei":
                        selectedCharacter2 = "AD";
                        selectedModel2 = "01";
                        break;
                    case "Minglian":
                        selectedCharacter2 = "AD";
                        selectedModel2 = "02";
                        break;
                    case "Noel":
                        selectedCharacter2 = "AE";
                        selectedModel2 = "00";
                        break;
                    case "Rudiger":
                        selectedCharacter2 = "AE";
                        selectedModel2 = "01";
                        break;
                    case "Aeneas":
                        selectedCharacter2 = "AE";
                        selectedModel2 = "02";
                        break;
                    case "Annaretta":
                        selectedCharacter2 = "AF";
                        selectedModel2 = "00";
                        break;
                    case "Iris":
                        selectedCharacter2 = "AF";
                        selectedModel2 = "01";
                        break;
                    case "Brunhild":
                        selectedCharacter2 = "AF";
                        selectedModel2 = "02";
                        break;
                    case "Asrafil":
                        selectedCharacter2 = "B0";
                        selectedModel2 = "00";
                        break;
                    case "Zifeng":
                        selectedCharacter2 = "B0";
                        selectedModel2 = "01";
                        break;
                    case "Aeolos":
                        selectedCharacter2 = "B0";
                        selectedModel2 = "02";
                        break;
                    case "Amrita":
                        selectedCharacter2 = "B1";
                        selectedModel2 = "00";
                        break;
                    case "Azalea":
                        selectedCharacter2 = "B1";
                        selectedModel2 = "01";
                        break;
                    case "Yueliang":
                        selectedCharacter2 = "B1";
                        selectedModel2 = "02";
                        break;
                    case "Kanade":
                        selectedCharacter2 = "B2";
                        selectedModel2 = "00";
                        break;
                    case "Domenthi":
                        selectedCharacter2 = "B2";
                        selectedModel2 = "01";
                        break;
                    case "Marid":
                        selectedCharacter2 = "B2";
                        selectedModel2 = "02";
                        break;
                    case "Ambrose":
                        selectedCharacter2 = "B3";
                        selectedModel2 = "00";
                        break;
                    case "Ailian":
                        selectedCharacter2 = "B3";
                        selectedModel2 = "01";
                        break;
                    case "Aika":
                        selectedCharacter2 = "B3";
                        selectedModel2 = "02";
                        break;
                    case "Loki":
                        selectedCharacter2 = "B4";
                        selectedModel2 = "00";
                        break;
                    case "Celestis":
                        selectedCharacter2 = "B4";
                        selectedModel2 = "01";
                        break;
                    case "Beleth":
                        selectedCharacter2 = "B4";
                        selectedModel2 = "02";
                        break;
                    case "Karen":
                        selectedCharacter2 = "B5";
                        selectedModel2 = "00";
                        break;
                    case "Lilan":
                        selectedCharacter2 = "B5";
                        selectedModel2 = "01";
                        break;
                    case "Abigail":
                        selectedCharacter2 = "B5";
                        selectedModel2 = "02";
                        break;
                    case "Balduin":
                        selectedCharacter2 = "B6";
                        selectedModel2 = "00";
                        break;
                    case "Aloces":
                        selectedCharacter2 = "B6";
                        selectedModel2 = "01";
                        break;
                    case "Areon":
                        selectedCharacter2 = "B6";
                        selectedModel2 = "02";
                        break;
                    case "Juno":
                        selectedCharacter2 = "B7";
                        selectedModel2 = "00";
                        break;
                    case "Eurydice":
                        selectedCharacter2 = "B7";
                        selectedModel2 = "01";
                        break;
                    case "Ishtar":
                        selectedCharacter2 = "B7";
                        selectedModel2 = "02";
                        break;
                    case "Rufus":
                        selectedCharacter2 = "B8";
                        selectedModel2 = "00";
                        break;
                    case "Raguel":
                        selectedCharacter2 = "B8";
                        selectedModel2 = "01";
                        break;
                    case "Feofan":
                        selectedCharacter2 = "B8";
                        selectedModel2 = "02";
                        break;
                    case "Eunice":
                        selectedCharacter2 = "B9";
                        selectedModel2 = "00";
                        break;
                    case "Acacia":
                        selectedCharacter2 = "B9";
                        selectedModel2 = "01";
                        break;
                    case "Hilda":
                        selectedCharacter2 = "B9";
                        selectedModel2 = "02";
                        break;
                    case "Iblis":
                        selectedCharacter2 = "BA";
                        selectedModel2 = "00";
                        break;
                    case "Alberic":
                        selectedCharacter2 = "BA";
                        selectedModel2 = "01";
                        break;
                    case "Leshy":
                        selectedCharacter2 = "BA";
                        selectedModel2 = "02";
                        break;
                    case "Muriel":
                        selectedCharacter2 = "BB";
                        selectedModel2 = "00";
                        break;
                    case "Wenli":
                        selectedCharacter2 = "BB";
                        selectedModel2 = "01";
                        break;
                    case "Irene":
                        selectedCharacter2 = "BB";
                        selectedModel2 = "02";
                        break;
                    case "Yufeng":
                        selectedCharacter2 = "BC";
                        selectedModel2 = "00";
                        break;
                    case "Yakumo":
                        selectedCharacter2 = "BC";
                        selectedModel2 = "01";
                        break;
                    case "Dufeng":
                        selectedCharacter2 = "BC";
                        selectedModel2 = "02";
                        break;
                    case "Mayura":
                        selectedCharacter2 = "BD";
                        selectedModel2 = "00";
                        break;
                    case "Meilan":
                        selectedCharacter2 = "BD";
                        selectedModel2 = "01";
                        break;
                    case "Rhea":
                        selectedCharacter2 = "BD";
                        selectedModel2 = "02";
                        break;
                    case "Halphas":
                        selectedCharacter2 = "BE";
                        selectedModel2 = "00";
                        break;
                    case "Gorus":
                        selectedCharacter2 = "BE";
                        selectedModel2 = "01";
                        break;
                    case "Ilyusha":
                        selectedCharacter2 = "BE";
                        selectedModel2 = "02";
                        break;
                    case "Edith":
                        selectedCharacter2 = "BF";
                        selectedModel2 = "00";
                        break;
                    case "Riese":
                        selectedCharacter2 = "BF";
                        selectedModel2 = "01";
                        break;
                    case "Agave":
                        selectedCharacter2 = "BF";
                        selectedModel2 = "02";
                        break;
                    case "Haystir":
                        selectedCharacter2 = "C0";
                        selectedModel2 = "00";
                        break;
                    case "Leraje":
                        selectedCharacter2 = "C0";
                        selectedModel2 = "01";
                        break;
                    case "Ratziel":
                        selectedCharacter2 = "C0";
                        selectedModel2 = "02";
                        break;
                    case "Katina":
                        selectedCharacter2 = "C1";
                        selectedModel2 = "00";
                        break;
                    case "Eris":
                        selectedCharacter2 = "C1";
                        selectedModel2 = "01";
                        break;
                    case "Sizuku":
                        selectedCharacter2 = "C1";
                        selectedModel2 = "02";
                        break;

                    case "Aege_1":
                        selectedCharacter2 = "E7";
                        selectedModel2 = "00";
                        break;
                    case "Aege_2":
                        selectedCharacter2 = "E7";
                        selectedModel2 = "01";
                        break;
                    case "Heal-Do_1":
                        selectedCharacter2 = "E8";
                        selectedModel2 = "00";
                        break;
                    case "Heal-Do_2":
                        selectedCharacter2 = "E8";
                        selectedModel2 = "01";
                        break;
                    case "Elua_1":
                        selectedCharacter2 = "E9";
                        selectedModel2 = "00";
                        break;
                    case "Elua_2":
                        selectedCharacter2 = "E9";
                        selectedModel2 = "01";
                        break;
                    case "Lupi_1":
                        selectedCharacter2 = "EA";
                        selectedModel2 = "00";
                        break;
                    case "Lupi_2":
                        selectedCharacter2 = "EA";
                        selectedModel2 = "01";
                        break;
                    case "Roin_1":
                        selectedCharacter2 = "EB";
                        selectedModel2 = "00";
                        break;
                    case "Roin_2":
                        selectedCharacter2 = "EB";
                        selectedModel2 = "01";
                        break;
                    case "Kierkess_1":
                        selectedCharacter2 = "EC";
                        selectedModel2 = "00";
                        break;
                    case "Kierkess_2":
                        selectedCharacter2 = "EC";
                        selectedModel2 = "01";
                        break;
                    case "Hyle_1":
                        selectedCharacter2 = "ED";
                        selectedModel2 = "00";
                        break;
                    case "Hyle_2":
                        selectedCharacter2 = "ED";
                        selectedModel2 = "01";
                        break;
                    case "Mooncalf":
                        selectedCharacter2 = "EE";
                        selectedModel2 = "00";
                        break;
                    case "Ende":
                        selectedCharacter2 = "EF";
                        selectedModel2 = "00";
                        break;

                    case "Grandall_M":
                        switch (selectedDis2)
                        {
                            case "Katana & Shuriken":
                                selectedCharacter2 = "A0";
                                selectedModel2 = "03";
                                break;
                            case "Kunai":
                                selectedCharacter2 = "A2";
                                selectedModel2 = "03";
                                break;
                            case "Katana":
                                selectedCharacter2 = "A4";
                                selectedModel2 = "03";
                                break;
                            case "Chinese Sword":
                                selectedCharacter2 = "A6";
                                selectedModel2 = "03";
                                break;
                            case "Chinese Blade":
                                selectedCharacter2 = "A8";
                                selectedModel2 = "03";
                                break;
                            case "Grieve Edge":
                                selectedCharacter2 = "AA";
                                selectedModel2 = "03";
                                break;
                            case "Staff":
                                selectedCharacter2 = "AC";
                                selectedModel2 = "03";
                                break;
                            case "Lance":
                                selectedCharacter2 = "AE";
                                selectedModel2 = "03";
                                break;
                            case "Steel Fan":
                                selectedCharacter2 = "B0";
                                selectedModel2 = "03";
                                break;
                            case "Sickle":
                                selectedCharacter2 = "B2";
                                selectedModel2 = "03";
                                break;
                            case "Dagger":
                                selectedCharacter2 = "B4";
                                selectedModel2 = "03";
                                break;
                            case "Iron Sword":
                                selectedCharacter2 = "B6";
                                selectedModel2 = "03";
                                break;
                            case "Sword & Shield":
                                selectedCharacter2 = "B8";
                                selectedModel2 = "03";
                                break;
                            case "Tambourine":
                                selectedCharacter2 = "BA";
                                selectedModel2 = "03";
                                break;
                            case "Nunchaku":
                                selectedCharacter2 = "BC";
                                selectedModel2 = "03";
                                break;
                            case "Wave Sword":
                                selectedCharacter2 = "BE";
                                selectedModel2 = "03";
                                break;
                            case "Rapier":
                                selectedCharacter2 = "C0";
                                selectedModel2 = "03";
                                break;
                        }
                        break;
                    case "Grandall_F":
                        switch (selectedDis2)
                        {
                            case "Katana & Shuriken":
                                selectedCharacter2 = "A1";
                                selectedModel2 = "03";
                                break;
                            case "Kunai":
                                selectedCharacter2 = "A3";
                                selectedModel2 = "03";
                                break;
                            case "Katana":
                                selectedCharacter2 = "A5";
                                selectedModel2 = "03";
                                break;
                            case "Chinese Sword":
                                selectedCharacter2 = "A7";
                                selectedModel2 = "03";
                                break;
                            case "Chinese Blade":
                                selectedCharacter2 = "A9";
                                selectedModel2 = "03";
                                break;
                            case "Grieve Edge":
                                selectedCharacter2 = "AB";
                                selectedModel2 = "03";
                                break;
                            case "Staff":
                                selectedCharacter2 = "AD";
                                selectedModel2 = "03";
                                break;
                            case "Lance":
                                selectedCharacter2 = "AF";
                                selectedModel2 = "03";
                                break;
                            case "Steel Fan":
                                selectedCharacter2 = "B0";
                                selectedModel2 = "03";
                                break;
                            case "Sickle":
                                selectedCharacter2 = "B3";
                                selectedModel2 = "03";
                                break;
                            case "Dagger":
                                selectedCharacter2 = "B5";
                                selectedModel2 = "03";
                                break;
                            case "Iron Sword":
                                selectedCharacter2 = "B7";
                                selectedModel2 = "03";
                                break;
                            case "Sword & Shield":
                                selectedCharacter2 = "B9";
                                selectedModel2 = "03";
                                break;
                            case "Tambourine":
                                selectedCharacter2 = "BB";
                                selectedModel2 = "03";
                                break;
                            case "Nunchaku":
                                selectedCharacter2 = "BD";
                                selectedModel2 = "03";
                                break;
                            case "Wave Sword":
                                selectedCharacter2 = "BF";
                                selectedModel2 = "03";
                                break;
                            case "Rapier":
                                selectedCharacter2 = "C1";
                                selectedModel2 = "03";
                                break;
                        }
                        break;
                    case "Dalkia_M":
                        switch (selectedDis2)
                        {
                            case "Katana & Shuriken":
                                selectedCharacter2 = "A0";
                                selectedModel2 = "04";
                                break;
                            case "Kunai":
                                selectedCharacter2 = "A2";
                                selectedModel2 = "04";
                                break;
                            case "Katana":
                                selectedCharacter2 = "A4";
                                selectedModel2 = "04";
                                break;
                            case "Chinese Sword":
                                selectedCharacter2 = "A6";
                                selectedModel2 = "04";
                                break;
                            case "Chinese Blade":
                                selectedCharacter2 = "A8";
                                selectedModel2 = "04";
                                break;
                            case "Grieve Edge":
                                selectedCharacter2 = "AA";
                                selectedModel2 = "04";
                                break;
                            case "Staff":
                                selectedCharacter2 = "AC";
                                selectedModel2 = "04";
                                break;
                            case "Lance":
                                selectedCharacter2 = "AE";
                                selectedModel2 = "04";
                                break;
                            case "Steel Fan":
                                selectedCharacter2 = "B0";
                                selectedModel2 = "04";
                                break;
                            case "Sickle":
                                selectedCharacter2 = "B2";
                                selectedModel2 = "04";
                                break;
                            case "Dagger":
                                selectedCharacter2 = "B4";
                                selectedModel2 = "04";
                                break;
                            case "Iron Sword":
                                selectedCharacter2 = "B6";
                                selectedModel2 = "04";
                                break;
                            case "Sword & Shield":
                                selectedCharacter2 = "B8";
                                selectedModel2 = "04";
                                break;
                            case "Tambourine":
                                selectedCharacter2 = "BA";
                                selectedModel2 = "04";
                                break;
                            case "Nunchaku":
                                selectedCharacter2 = "BC";
                                selectedModel2 = "04";
                                break;
                            case "Wave Sword":
                                selectedCharacter2 = "BE";
                                selectedModel2 = "04";
                                break;
                            case "Rapier":
                                selectedCharacter2 = "C0";
                                selectedModel2 = "04";
                                break;
                        }
                        break;
                    case "Dalkia_F":
                        switch (selectedDis2)
                        {
                            case "Katana & Shuriken":
                                selectedCharacter2 = "A1";
                                selectedModel2 = "04";
                                break;
                            case "Kunai":
                                selectedCharacter2 = "A3";
                                selectedModel2 = "04";
                                break;
                            case "Katana":
                                selectedCharacter2 = "A5";
                                selectedModel2 = "04";
                                break;
                            case "Chinese Sword":
                                selectedCharacter2 = "A7";
                                selectedModel2 = "04";
                                break;
                            case "Chinese Blade":
                                selectedCharacter2 = "A9";
                                selectedModel2 = "04";
                                break;
                            case "Grieve Edge":
                                selectedCharacter2 = "AB";
                                selectedModel2 = "04";
                                break;
                            case "Staff":
                                selectedCharacter2 = "AD";
                                selectedModel2 = "04";
                                break;
                            case "Lance":
                                selectedCharacter2 = "AF";
                                selectedModel2 = "04";
                                break;
                            case "Steel Fan":
                                selectedCharacter2 = "B1";
                                selectedModel2 = "04";
                                break;
                            case "Sickle":
                                selectedCharacter2 = "B3";
                                selectedModel2 = "04";
                                break;
                            case "Dagger":
                                selectedCharacter2 = "B5";
                                selectedModel2 = "04";
                                break;
                            case "Iron Sword":
                                selectedCharacter2 = "B7";
                                selectedModel2 = "04";
                                break;
                            case "Sword & Shield":
                                selectedCharacter2 = "B9";
                                selectedModel2 = "04";
                                break;
                            case "Tambourine":
                                selectedCharacter2 = "BB";
                                selectedModel2 = "04";
                                break;
                            case "Nunchaku":
                                selectedCharacter2 = "BD";
                                selectedModel2 = "04";
                                break;
                            case "Wave Sword":
                                selectedCharacter2 = "BF";
                                selectedModel2 = "04";
                                break;
                            case "Rapier":
                                selectedCharacter2 = "C1";
                                selectedModel2 = "04";
                                break;
                        }
                        break;
                    case "Brigand_M":
                        switch (selectedDis2)
                        {
                            case "Katana & Shuriken":
                                selectedCharacter2 = "A0";
                                selectedModel2 = "05";
                                break;
                            case "Kunai":
                                selectedCharacter2 = "A2";
                                selectedModel2 = "05";
                                break;
                            case "Katana":
                                selectedCharacter2 = "A4";
                                selectedModel2 = "05";
                                break;
                            case "Chinese Sword":
                                selectedCharacter2 = "A6";
                                selectedModel2 = "05";
                                break;
                            case "Chinese Blade":
                                selectedCharacter2 = "A8";
                                selectedModel2 = "05";
                                break;
                            case "Grieve Edge":
                                selectedCharacter2 = "AA";
                                selectedModel2 = "05";
                                break;
                            case "Staff":
                                selectedCharacter2 = "AC";
                                selectedModel2 = "05";
                                break;
                            case "Lance":
                                selectedCharacter2 = "AE";
                                selectedModel2 = "05";
                                break;
                            case "Steel Fan":
                                selectedCharacter2 = "B0";
                                selectedModel2 = "05";
                                break;
                            case "Sickle":
                                selectedCharacter2 = "B2";
                                selectedModel2 = "05";
                                break;
                            case "Dagger":
                                selectedCharacter2 = "B4";
                                selectedModel2 = "05";
                                break;
                            case "Iron Sword":
                                selectedCharacter2 = "B6";
                                selectedModel2 = "05";
                                break;
                            case "Sword & Shield":
                                selectedCharacter2 = "B8";
                                selectedModel2 = "05";
                                break;
                            case "Tambourine":
                                selectedCharacter2 = "BA";
                                selectedModel2 = "05";
                                break;
                            case "Nunchaku":
                                selectedCharacter2 = "BC";
                                selectedModel2 = "05";
                                break;
                            case "Wave Sword":
                                selectedCharacter2 = "BE";
                                selectedModel2 = "05";
                                break;
                            case "Rapier":
                                selectedCharacter2 = "C0";
                                selectedModel2 = "05";
                                break;
                        }
                        break;
                    case "Brigand_F":
                        switch (selectedDis2)
                        {
                            case "Katana & Shuriken":
                                selectedCharacter2 = "A1";
                                selectedModel2 = "05";
                                break;
                            case "Kunai":
                                selectedCharacter2 = "A3";
                                selectedModel2 = "05";
                                break;
                            case "Katana":
                                selectedCharacter2 = "A5";
                                selectedModel2 = "05";
                                break;
                            case "Chinese Sword":
                                selectedCharacter2 = "A7";
                                selectedModel2 = "05";
                                break;
                            case "Chinese Blade":
                                selectedCharacter2 = "A9";
                                selectedModel2 = "05";
                                break;
                            case "Grieve Edge":
                                selectedCharacter2 = "AB";
                                selectedModel2 = "05";
                                break;
                            case "Staff":
                                selectedCharacter2 = "AD";
                                selectedModel2 = "05";
                                break;
                            case "Lance":
                                selectedCharacter2 = "AF";
                                selectedModel2 = "05";
                                break;
                            case "Steel Fan":
                                selectedCharacter2 = "B1";
                                selectedModel2 = "05";
                                break;
                            case "Sickle":
                                selectedCharacter2 = "B3";
                                selectedModel2 = "05";
                                break;
                            case "Dagger":
                                selectedCharacter2 = "B5";
                                selectedModel2 = "05";
                                break;
                            case "Iron Sword":
                                selectedCharacter2 = "B7";
                                selectedModel2 = "05";
                                break;
                            case "Sword & Shield":
                                selectedCharacter2 = "B9";
                                selectedModel2 = "05";
                                break;
                            case "Tambourine":
                                selectedCharacter2 = "BB";
                                selectedModel2 = "05";
                                break;
                            case "Nunchaku":
                                selectedCharacter2 = "BD";
                                selectedModel2 = "05";
                                break;
                            case "Wave Sword":
                                selectedCharacter2 = "BF";
                                selectedModel2 = "05";
                                break;
                            case "Rapier":
                                selectedCharacter2 = "C1";
                                selectedModel2 = "05";
                                break;
                        }
                        break;
                    case "Maletta_M":
                        switch (selectedDis2)
                        {
                            case "Katana & Shuriken":
                                selectedCharacter2 = "A0";
                                selectedModel2 = "06";
                                break;
                            case "Kunai":
                                selectedCharacter2 = "A2";
                                selectedModel2 = "06";
                                break;
                            case "Katana":
                                selectedCharacter2 = "A4";
                                selectedModel2 = "06";
                                break;
                            case "Chinese Sword":
                                selectedCharacter2 = "A6";
                                selectedModel2 = "06";
                                break;
                            case "Chinese Blade":
                                selectedCharacter2 = "A8";
                                selectedModel2 = "06";
                                break;
                            case "Grieve Edge":
                                selectedCharacter2 = "AA";
                                selectedModel2 = "06";
                                break;
                            case "Staff":
                                selectedCharacter2 = "AC";
                                selectedModel2 = "06";
                                break;
                            case "Lance":
                                selectedCharacter2 = "AE";
                                selectedModel2 = "06";
                                break;
                            case "Steel Fan":
                                selectedCharacter2 = "B0";
                                selectedModel2 = "06";
                                break;
                            case "Sickle":
                                selectedCharacter2 = "B2";
                                selectedModel2 = "06";
                                break;
                            case "Dagger":
                                selectedCharacter2 = "B4";
                                selectedModel2 = "06";
                                break;
                            case "Iron Sword":
                                selectedCharacter2 = "B6";
                                selectedModel2 = "06";
                                break;
                            case "Sword & Shield":
                                selectedCharacter2 = "B8";
                                selectedModel2 = "06";
                                break;
                            case "Tambourine":
                                selectedCharacter2 = "BA";
                                selectedModel2 = "06";
                                break;
                            case "Nunchaku":
                                selectedCharacter2 = "BC";
                                selectedModel2 = "06";
                                break;
                            case "Wave Sword":
                                selectedCharacter2 = "BE";
                                selectedModel2 = "06";
                                break;
                            case "Rapier":
                                selectedCharacter2 = "C0";
                                selectedModel2 = "06";
                                break;
                        }
                        break;
                    case "Maletta_F":
                        switch (selectedDis2)
                        {
                            case "Katana & Shuriken":
                                selectedCharacter2 = "A1";
                                selectedModel2 = "06";
                                break;
                            case "Kunai":
                                selectedCharacter2 = "A3";
                                selectedModel2 = "06";
                                break;
                            case "Katana":
                                selectedCharacter2 = "A5";
                                selectedModel2 = "06";
                                break;
                            case "Chinese Sword":
                                selectedCharacter2 = "A7";
                                selectedModel2 = "06";
                                break;
                            case "Chinese Blade":
                                selectedCharacter2 = "A9";
                                selectedModel2 = "06";
                                break;
                            case "Grieve Edge":
                                selectedCharacter2 = "AB";
                                selectedModel2 = "06";
                                break;
                            case "Staff":
                                selectedCharacter2 = "AD";
                                selectedModel2 = "06";
                                break;
                            case "Lance":
                                selectedCharacter2 = "AF";
                                selectedModel2 = "06";
                                break;
                            case "Steel Fan":
                                selectedCharacter2 = "B1";
                                selectedModel2 = "06";
                                break;
                            case "Sickle":
                                selectedCharacter2 = "B3";
                                selectedModel2 = "06";
                                break;
                            case "Dagger":
                                selectedCharacter2 = "B5";
                                selectedModel2 = "06";
                                break;
                            case "Iron Sword":
                                selectedCharacter2 = "B7";
                                selectedModel2 = "06";
                                break;
                            case "Sword & Shield":
                                selectedCharacter2 = "B9";
                                selectedModel2 = "06";
                                break;
                            case "Tambourine":
                                selectedCharacter2 = "BB";
                                selectedModel2 = "06";
                                break;
                            case "Nunchaku":
                                selectedCharacter2 = "BD";
                                selectedModel2 = "06";
                                break;
                            case "Wave Sword":
                                selectedCharacter2 = "BF";
                                selectedModel2 = "06";
                                break;
                            case "Rapier":
                                selectedCharacter2 = "C1";
                                selectedModel2 = "06";
                                break;
                        }
                        break;
                    case "Rebel_M":
                        switch (selectedDis2)
                        {
                            case "Katana & Shuriken":
                                selectedCharacter2 = "A0";
                                selectedModel2 = "07";
                                break;
                            case "Kunai":
                                selectedCharacter2 = "A2";
                                selectedModel2 = "07";
                                break;
                            case "Katana":
                                selectedCharacter2 = "A4";
                                selectedModel2 = "07";
                                break;
                            case "Chinese Sword":
                                selectedCharacter2 = "A6";
                                selectedModel2 = "07";
                                break;
                            case "Chinese Blade":
                                selectedCharacter2 = "A8";
                                selectedModel2 = "03";
                                break;
                            case "Grieve Edge":
                                selectedCharacter2 = "AA";
                                selectedModel2 = "07";
                                break;
                            case "Staff":
                                selectedCharacter2 = "AC";
                                selectedModel2 = "07";
                                break;
                            case "Lance":
                                selectedCharacter2 = "AE";
                                selectedModel2 = "07";
                                break;
                            case "Steel Fan":
                                selectedCharacter2 = "B0";
                                selectedModel2 = "07";
                                break;
                            case "Sickle":
                                selectedCharacter2 = "B2";
                                selectedModel2 = "07";
                                break;
                            case "Dagger":
                                selectedCharacter2 = "B4";
                                selectedModel2 = "07";
                                break;
                            case "Iron Sword":
                                selectedCharacter2 = "B6";
                                selectedModel2 = "07";
                                break;
                            case "Sword & Shield":
                                selectedCharacter2 = "B8";
                                selectedModel2 = "07";
                                break;
                            case "Tambourine":
                                selectedCharacter2 = "BA";
                                selectedModel2 = "07";
                                break;
                            case "Nunchaku":
                                selectedCharacter2 = "BC";
                                selectedModel2 = "07";
                                break;
                            case "Wave Sword":
                                selectedCharacter2 = "BE";
                                selectedModel2 = "07";
                                break;
                            case "Rapier":
                                selectedCharacter2 = "C0";
                                selectedModel2 = "07";
                                break;
                        }
                        break;
                    case "Rebel_F":
                        switch (selectedDis2)
                        {
                            case "Katana & Shuriken":
                                selectedCharacter2 = "A1";
                                selectedModel2 = "07";
                                break;
                            case "Kunai":
                                selectedCharacter2 = "A3";
                                selectedModel2 = "07";
                                break;
                            case "Katana":
                                selectedCharacter2 = "A5";
                                selectedModel2 = "07";
                                break;
                            case "Chinese Sword":
                                selectedCharacter2 = "A7";
                                selectedModel2 = "07";
                                break;
                            case "Chinese Blade":
                                selectedCharacter2 = "A9";
                                selectedModel2 = "07";
                                break;
                            case "Grieve Edge":
                                selectedCharacter2 = "AB";
                                selectedModel2 = "07";
                                break;
                            case "Staff":
                                selectedCharacter2 = "AD";
                                selectedModel2 = "07";
                                break;
                            case "Lance":
                                selectedCharacter2 = "AF";
                                selectedModel2 = "07";
                                break;
                            case "Steel Fan":
                                selectedCharacter2 = "B1";
                                selectedModel2 = "07";
                                break;
                            case "Sickle":
                                selectedCharacter2 = "B3";
                                selectedModel2 = "07";
                                break;
                            case "Dagger":
                                selectedCharacter2 = "B5";
                                selectedModel2 = "07";
                                break;
                            case "Iron Sword":
                                selectedCharacter2 = "B7";
                                selectedModel2 = "07";
                                break;
                            case "Sword & Shield":
                                selectedCharacter2 = "B9";
                                selectedModel2 = "07";
                                break;
                            case "Tambourine":
                                selectedCharacter2 = "BB";
                                selectedModel2 = "07";
                                break;
                            case "Nunchaku":
                                selectedCharacter2 = "BD";
                                selectedModel2 = "07";
                                break;
                            case "Wave Sword":
                                selectedCharacter2 = "BF";
                                selectedModel2 = "07";
                                break;
                            case "Rapier":
                                selectedCharacter2 = "C1";
                                selectedModel2 = "07";
                                break;
                        }
                        break;
                }

                charCode2 = "" + Environment.NewLine +
                    "patch=1,EE,004D1FE0,extended," + selectedCharacter2 + " //Character2" + Environment.NewLine +
                    "patch=1,EE,004D1FEE,extended," + selectedModel2 + " //Model2" + Environment.NewLine +
                    "";
            }

            #endregion

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

            var stageCode = "";
            if (SettingsClass.StageValue != "XX" && !SettingsClass.StageValue.IsNullOrEmpty())
            {
                stageCode = "" + Environment.NewLine +
                            "patch=1,EE,004ED64C,extended,000000" + SettingsClass.StageValue + " //Stage code (unstable)" + Environment.NewLine +
                            "";
            }

            string characterSelect = Codes.CharacterSelect.GetCharacterPnachCode(false);


            bool p1WpnEf = true;
            if (weaponEffectsP1 == "")
            {
                p1WpnEf = false;
            }
            bool p2WpnEf = true;
            if (weaponEffectsP2 == "")
            {
                p2WpnEf = false;
            }
            string ultimateWeapons = Codes.NewWeapons.GetWeaponsCode(ultWeapons, p1WpnEf, p2WpnEf);

            string p1SpeedCodeValue = "";
            switch (p1Speed)
            {
                case 1:
                    p1SpeedCodeValue = "3C013EC0";
                    break;
                case 2:
                    p1SpeedCodeValue = "3C013F00";
                    break;
                case 3:
                    p1SpeedCodeValue = "3C013F40";
                    break;
                case 4:
                    p1SpeedCodeValue = "3C013F80";
                    break;
                case 5:
                    p1SpeedCodeValue = "3C013FC0";
                    break;
                case 6:
                    p1SpeedCodeValue = "3C014000";
                    break;
                case 7:
                    p1SpeedCodeValue = "3C014040";
                    break;
            }
            string p1SpeedCode = "\n patch=1,EE,200FFD00,extended," + p1SpeedCodeValue + "//P1" +
                                 "\n patch=1,EE,200FFD04,extended,3C04004B//P1" +
                                 "\n patch=1,EE,200FFD08,extended,AC815F50//P1";


            string p2SpeedCodeValue = "";
            switch (p2Speed)
            {
                case 1:
                    p2SpeedCodeValue = "3C013EC0";
                    break;
                case 2:
                    p2SpeedCodeValue = "3C013F00";
                    break;
                case 3:
                    p2SpeedCodeValue = "3C013F40";
                    break;
                case 4:
                    p2SpeedCodeValue = "3C013F80";
                    break;
                case 5:
                    p2SpeedCodeValue = "3C013FC0";
                    break;
                case 6:
                    p2SpeedCodeValue = "3C014000";
                    break;
                case 7:
                    p2SpeedCodeValue = "3C014040";
                    break;
            }
            string p2SpeedCode = "\n patch=1,EE,200FFD0C,extended," + p2SpeedCodeValue + "//P2" +
                                 "\n patch=1,EE,200FFD10,extended,3C04004D//P2" +
                                 "\n patch=1,EE,200FFD14,extended,AC8136D0//P2";


            string bothSpeedCode = "\n patch=1,EE,200FFD18,extended,0260202D//BOTH" +
                                   "\n patch=1,EE,200FFD1C,extended,0806CDD1//BOTH" +
                                   "\n patch=1,EE,201B3740,extended,0803FF40//BOTH";


            string pnachCode = "\n" + stageCode + characterSelect + /*charCode + charCode2 +*/ opponentControlCode + weaponsSpecialPower +
                weaponEffectsP1 + weaponEffectsP2 + guardianForceP1 +
                guardianForceP2 + slipperyFieldP1 + slipperyFieldP2 + ultimateWeapons  + extraCharacters + infernoCode +
                p1SpeedCode + p2SpeedCode + bothSpeedCode;

            File.WriteAllText(SettingsClass.codeFilePath, pnachCode, Encoding.UTF8);
        }

        public static void ExportPnachLite()
        {
            string pnachCode = "";

            SettingsClass.LoadData();
            pnachCode += Codes.NewWeapons.GetWeaponsCode(SettingsClass.UltimateWeapons, false, false);
            pnachCode += Codes.CharacterSelect.GetCharacterPnachCode(true);

            File.WriteAllText(SettingsClass.codeFilePath, pnachCode, Encoding.UTF8);
        }

        public static void ClearPnach()
        {
            File.WriteAllText(SettingsClass.codeFilePath, "", Encoding.UTF8);
        }

    }
}
