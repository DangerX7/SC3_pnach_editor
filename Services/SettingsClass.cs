﻿using Microsoft.VisualBasic;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SC3_pnach_editor.Services
{
    public class SettingsClass
    {

        public static string PnachName = @"\CABA0878.pnach";
        public static string codeFolderPath { get; set; } = @"";
        public static string codeFilePath = codeFolderPath + PnachName;


        public static string SettingsPath = @"C:\\AppSettings\\Settings_File2";
        public static string folderPath = @"C:\\AppSettings";

        public static string GfxCopyFrom = "";
        public static string GfxCopyTo = "";

        public static bool BonusCharacters { get; set; } = false;
        public static bool UltimateWeapons { get; set; } = false;
        public static bool GuardianForceP1 { get; set; } = false;
        public static bool GuardianForceP2 { get; set; } = false;


        public static int WeaponEffectP1 = 0;
        public static int WeaponSpecialPowerP1 = 0;
        public static int WeaponEffectP2 = 0;
        public static int WeaponSpecialPowerP2 = 0;
        public static int ChroniclesCharacterP1 = 0;
        public static int ChroniclesCharacterP2 = 0;
        public static int ChroniclesCharacterP1_weapon = 0;
        public static int ChroniclesCharacterP2_weapon = 0;

        public static int OpponentControl = 0;

        public static bool SlipperyFieldP1 { get; set; } = false;
        public static bool SlipperyFieldP2 { get; set; } = false;


        public static int WpnEffect1 { get; set; } = 0;
        public static int WpnEffect2 { get; set; } = 0;
        public static int WpnEffect3 { get; set; } = 0;
        public static int WpnEffect4 { get; set; } = 0;
        public static int WpnEffect5 { get; set; } = 0;
        public static int WpnEffect6 { get; set; } = 0;
        public static int WpnEffect7 { get; set; } = 0;
        public static int WpnEffect8 { get; set; } = 0;
        public static int WpnEffect9 { get; set; } = 0;
        public static int WpnEffect10 { get; set; } = 0;
        public static int WpnEffect11 { get; set; } = 0;
        public static int WpnEffect12 { get; set; } = 0;
        public static int WpnEffect13 { get; set; } = 0;
        public static int WpnEffect14 { get; set; } = 0;
        public static int WpnEffect15 { get; set; } = 0;
        public static int WpnEffect16 { get; set; } = 0;
        public static int WpnEffect17 { get; set; } = 0;
        public static int WpnEffect18 { get; set; } = 0;

        public static string CharacterP1 { get; set; } = "";
        public static string CharacterP2 { get; set; } = "";
        public static string ModelP1 { get; set; } = "";
        public static string ModelP2 { get; set; } = "";

        public static bool UseSetCharacters { get; set; } = false;

        public static string StageValue { get; set; } = "XX";

        public static int P1Speed = 0;
        public static int P2Speed = 0;

        public static string NightTerrorSkin { get; set; } = "";
        public static string TakiSkin { get; set; } = "";
        public static string CassandraSkin { get; set; } = "";
        public static string ColossusSkin { get; set; } = "";
        public static string LynetteSkin { get; set; } = "";
        public static string NightmareSkin { get; set; } = "";
        public static string SiegfriedSkin { get; set; } = "";
        public static string SophitiaSkin { get; set; } = "";

        public SettingsClass(string connectionString, string pnachName, string gfxCopyFrom, string gfxCopyTo, bool bonusCharacters, bool ultimateWeapons, bool guardianForceP1,
            bool guardianForceP2, int weaponEffectP1, int weaponSpecialPowerP1, int weaponEffectP2, int weaponSpecialPowerP2,
            bool slipperyFieldP1, bool slipperyFieldP2, int chroniclesCharacterP1, int chroniclesCharacterP2, int opponentControl,
            int chroniclesCharacterP1_weapon, int chroniclesCharacterP2_weapon,
            int wpnEffect1, int wpnEffect2, int wpnEffect3, int wpnEffect4, int wpnEffect5, int wpnEffect6,
            int wpnEffect7, int wpnEffect8, int wpnEffect9, int wpnEffect10, int wpnEffect11, int wpnEffect12,
            int wpnEffect13, int wpnEffect14, int wpnEffect15, int wpnEffect16, int wpnEffect17, int wpnEffect18,
            string characterP1, string characterP2, string modelP1, string modelP2, bool useSetCharacters, int p1Speed, int p2Speed,
            string nightTerrorSkin, string takiSkin, string cassandraSkin, string colossusSkin, string lynetteSkin, string nightmareSkin, 
            string siegfriedSkin, string sophitiaSkin)
        {
            codeFolderPath = connectionString;
            PnachName = pnachName;
            GfxCopyFrom = gfxCopyFrom;
            GfxCopyTo = gfxCopyTo;
            BonusCharacters = bonusCharacters;
            UltimateWeapons = ultimateWeapons;
            GuardianForceP1 = guardianForceP1;
            GuardianForceP2 = guardianForceP2;
            WeaponEffectP1 = weaponEffectP1;
            WeaponSpecialPowerP1 = weaponSpecialPowerP1;
            WeaponEffectP2 = weaponEffectP2;
            WeaponSpecialPowerP2 = weaponSpecialPowerP2;
            SlipperyFieldP1 = slipperyFieldP1;
            SlipperyFieldP2 = slipperyFieldP2;
            ChroniclesCharacterP1 = chroniclesCharacterP1;
            ChroniclesCharacterP2 = chroniclesCharacterP2;
            ChroniclesCharacterP1_weapon = chroniclesCharacterP1_weapon;
            ChroniclesCharacterP2_weapon = chroniclesCharacterP2_weapon;
            OpponentControl = opponentControl;

            WpnEffect1 = wpnEffect1;
            WpnEffect2 = wpnEffect2;
            WpnEffect3 = wpnEffect3;
            WpnEffect4 = wpnEffect4;
            WpnEffect5 = wpnEffect5;
            WpnEffect6 = wpnEffect6;
            WpnEffect7 = wpnEffect7;
            WpnEffect8 = wpnEffect8;
            WpnEffect9 = wpnEffect9;
            WpnEffect10 = wpnEffect10;
            WpnEffect11 = wpnEffect11;
            WpnEffect12 = wpnEffect12;
            WpnEffect13 = wpnEffect13;
            WpnEffect14 = wpnEffect14;
            WpnEffect15 = wpnEffect15;
            WpnEffect16 = wpnEffect16;
            WpnEffect17 = wpnEffect17;
            WpnEffect18 = wpnEffect18;

            CharacterP1 = characterP1;
            CharacterP2 = characterP2;
            ModelP1 = modelP1;
            ModelP2 = modelP2;

            useSetCharacters = UseSetCharacters;//CHECK THIS DUMBASS

            P1Speed = p1Speed;
            P2Speed = p2Speed;

            NightTerrorSkin = nightTerrorSkin;
            TakiSkin = takiSkin;
            CassandraSkin = cassandraSkin;
            ColossusSkin = colossusSkin;
            LynetteSkin = lynetteSkin;
            NightmareSkin = nightmareSkin;
            SiegfriedSkin = siegfriedSkin;
            SophitiaSkin = sophitiaSkin;

        }

        public static bool isConfigFileLoaded = false;
        public class GetData
        {
            public string codeFolderPath { get; set; } = SettingsClass.codeFolderPath;
            public string PnachName { get; set; } = SettingsClass.PnachName;
            public string GfxCopyFrom { get; set; } = SettingsClass.GfxCopyFrom;
            public string GfxCopyTo { get; set; } = SettingsClass.GfxCopyTo;
            public bool BonusCharacters { get; set; } = SettingsClass.BonusCharacters;
            public bool UltimateWeapons { get; set; } = SettingsClass.UltimateWeapons;
            public bool GuardianForceP1 { get; set; } = SettingsClass.GuardianForceP1;
            public bool GuardianForceP2 { get; set; } = SettingsClass.GuardianForceP2;
            public int WeaponEffectP1 { get; set; } = SettingsClass.WeaponEffectP1;
            public int WeaponSpecialPowerP1 { get; set; } = SettingsClass.WeaponSpecialPowerP1;
            public int WeaponEffectP2 { get; set; } = SettingsClass.WeaponEffectP2;
            public int WeaponSpecialPowerP2 { get; set; } = SettingsClass.WeaponSpecialPowerP2;
            public bool SlipperyFieldP1 { get; set; } = SettingsClass.SlipperyFieldP1;
            public bool SlipperyFieldP2 { get; set; } = SettingsClass.SlipperyFieldP2;

            public int ChroniclesCharacterP1 { get; set; } = SettingsClass.ChroniclesCharacterP1;
            public int ChroniclesCharacterP2 { get; set; } = SettingsClass.ChroniclesCharacterP2;
            public int ChroniclesCharacterP1_weapon { get; set; } = SettingsClass.ChroniclesCharacterP1_weapon;
            public int ChroniclesCharacterP2_weapon { get; set; } = SettingsClass.ChroniclesCharacterP2_weapon;


            public int OpponentControl { get; set; } = SettingsClass.OpponentControl;
            public int WpnEffect1 { get; set; } = SettingsClass.WpnEffect1;
            public int WpnEffect2 { get; set; } = SettingsClass.WpnEffect2;
            public int WpnEffect3 { get; set; } = SettingsClass.WpnEffect3;
            public int WpnEffect4 { get; set; } = SettingsClass.WpnEffect4;
            public int WpnEffect5 { get; set; } = SettingsClass.WpnEffect5;
            public int WpnEffect6 { get; set; } = SettingsClass.WpnEffect6;
            public int WpnEffect7 { get; set; } = SettingsClass.WpnEffect7;
            public int WpnEffect8 { get; set; } = SettingsClass.WpnEffect8;
            public int WpnEffect9 { get; set; } = SettingsClass.WpnEffect9;
            public int WpnEffect10 { get; set; } = SettingsClass.WpnEffect10;
            public int WpnEffect11 { get; set; } = SettingsClass.WpnEffect11;
            public int WpnEffect12 { get; set; } = SettingsClass.WpnEffect12;
            public int WpnEffect13 { get; set; } = SettingsClass.WpnEffect13;
            public int WpnEffect14 { get; set; } = SettingsClass.WpnEffect14;
            public int WpnEffect15 { get; set; } = SettingsClass.WpnEffect15;
            public int WpnEffect16 { get; set; } = SettingsClass.WpnEffect16;
            public int WpnEffect17 { get; set; } = SettingsClass.WpnEffect17;
            public int WpnEffect18 { get; set; } = SettingsClass.WpnEffect18;

            public string CharacterP1 { get; set; } = SettingsClass.CharacterP1;
            public string CharacterP2 { get; set; } = SettingsClass.CharacterP2;
            public string ModelP1 { get; set; } = SettingsClass.ModelP1;
            public string ModelP2 { get; set; } = SettingsClass.ModelP2;

            public bool UseSetCharacters { get; set; } = SettingsClass.UseSetCharacters;

            public int P1Speed { get; set; } = SettingsClass.P1Speed;
            public int P2Speed { get; set; } = SettingsClass.P2Speed;

            public string NightTerrorSkin { get; set; } = SettingsClass.NightTerrorSkin;
            public string TakiSkin { get; set; } = SettingsClass.TakiSkin;
            public string CassandraSkin { get; set; } = SettingsClass.CassandraSkin;
            public string ColossusSkin { get; set; } = SettingsClass.ColossusSkin;
            public string LynetteSkin { get; set; } = SettingsClass.LynetteSkin;
            public string NightmareSkin { get; set; } = SettingsClass.NightmareSkin;
            public string SiegfriedSkin { get; set; } = SettingsClass.SiegfriedSkin;
            public string SophitiaSkin { get; set; } = SettingsClass.SophitiaSkin;

        }

        public static GetData Settings = new GetData();

        public static void LoadData()
        {
            if (File.Exists(SettingsPath))
            {
                string JsonString = File.ReadAllText(SettingsPath);
                Settings = JsonConvert.DeserializeObject<GetData>(JsonString);

                codeFolderPath = Settings.codeFolderPath;
                PnachName = Settings.PnachName;
                GfxCopyFrom = Settings.GfxCopyFrom;
                GfxCopyTo = Settings.GfxCopyTo;
                BonusCharacters = Settings.BonusCharacters;
                UltimateWeapons = Settings.UltimateWeapons;
                GuardianForceP1 = Settings.GuardianForceP1;
                GuardianForceP2 = Settings.GuardianForceP2;
                WeaponEffectP1 = Settings.WeaponEffectP1;
                WeaponSpecialPowerP1 = Settings.WeaponSpecialPowerP1;
                WeaponEffectP2 = Settings.WeaponEffectP2;
                WeaponSpecialPowerP2 = Settings.WeaponSpecialPowerP2;
                SlipperyFieldP1 = Settings.SlipperyFieldP1;
                SlipperyFieldP2 = Settings.SlipperyFieldP2;

                ChroniclesCharacterP1 = Settings.ChroniclesCharacterP1;
                ChroniclesCharacterP2 = Settings.ChroniclesCharacterP2;
                ChroniclesCharacterP1_weapon = Settings.ChroniclesCharacterP1_weapon;
                ChroniclesCharacterP2_weapon = Settings.ChroniclesCharacterP2_weapon;
                OpponentControl = Settings.OpponentControl;

                WpnEffect1 = Settings.WpnEffect1;
                WpnEffect2 = Settings.WpnEffect2;
                WpnEffect3 = Settings.WpnEffect3;
                WpnEffect4 = Settings.WpnEffect4;
                WpnEffect5 = Settings.WpnEffect5;
                WpnEffect6 = Settings.WpnEffect6;
                WpnEffect7 = Settings.WpnEffect7;
                WpnEffect8 = Settings.WpnEffect8;
                WpnEffect9 = Settings.WpnEffect9;
                WpnEffect10 = Settings.WpnEffect10;
                WpnEffect11 = Settings.WpnEffect11;
                WpnEffect12 = Settings.WpnEffect12;
                WpnEffect13 = Settings.WpnEffect13;
                WpnEffect14 = Settings.WpnEffect14;
                WpnEffect15 = Settings.WpnEffect15;
                WpnEffect16 = Settings.WpnEffect16;
                WpnEffect17 = Settings.WpnEffect17;
                WpnEffect18 = Settings.WpnEffect18;

                CharacterP1 = Settings.CharacterP1;
                CharacterP2 = Settings.CharacterP2;
                ModelP1 = Settings.ModelP1;
                ModelP2 = Settings.ModelP2;

                UseSetCharacters = Settings.UseSetCharacters;

                codeFilePath = codeFolderPath + PnachName;

                P1Speed = Settings.P1Speed;
                P2Speed = Settings.P2Speed;

                NightTerrorSkin = Settings.NightTerrorSkin;
                TakiSkin = Settings.TakiSkin;
                CassandraSkin = Settings.CassandraSkin;
                ColossusSkin = Settings.ColossusSkin;
                LynetteSkin = Settings.LynetteSkin;
                NightmareSkin = Settings.NightmareSkin;
                SiegfriedSkin = Settings.SiegfriedSkin;
                SophitiaSkin = Settings.SophitiaSkin;
    }
            else
            {
                SaveData();
            }
        }

        public static void SaveData()
        {
            Settings.codeFolderPath = codeFolderPath;
            Settings.PnachName = PnachName;
            Settings.GfxCopyFrom = GfxCopyFrom;
            Settings.GfxCopyTo = GfxCopyTo;
            Settings.BonusCharacters = BonusCharacters;
            Settings.UltimateWeapons = UltimateWeapons;
            Settings.GuardianForceP1 = GuardianForceP1;
            Settings.GuardianForceP2 = GuardianForceP2;
            Settings.WeaponEffectP1 = WeaponEffectP1;
            Settings.WeaponSpecialPowerP1 = WeaponSpecialPowerP1;
            Settings.WeaponEffectP2 = WeaponEffectP2;
            Settings.WeaponSpecialPowerP2 = WeaponSpecialPowerP2;
            Settings.SlipperyFieldP1 = SlipperyFieldP1;
            Settings.SlipperyFieldP2 = SlipperyFieldP2;

            Settings.ChroniclesCharacterP1 = ChroniclesCharacterP1;
            Settings.ChroniclesCharacterP2 = ChroniclesCharacterP2;
            Settings.ChroniclesCharacterP1_weapon = ChroniclesCharacterP1_weapon;
            Settings.ChroniclesCharacterP2_weapon = ChroniclesCharacterP2_weapon;
            Settings.OpponentControl = OpponentControl;

            Settings.WpnEffect1 = WpnEffect1;
            Settings.WpnEffect2 = WpnEffect2;
            Settings.WpnEffect3 = WpnEffect3;
            Settings.WpnEffect4 = WpnEffect4;
            Settings.WpnEffect5 = WpnEffect5;
            Settings.WpnEffect6 = WpnEffect6;
            Settings.WpnEffect7 = WpnEffect7;
            Settings.WpnEffect8 = WpnEffect8;
            Settings.WpnEffect9 = WpnEffect9;
            Settings.WpnEffect10 = WpnEffect10;
            Settings.WpnEffect11 = WpnEffect11;
            Settings.WpnEffect12 = WpnEffect12;
            Settings.WpnEffect13 = WpnEffect13;
            Settings.WpnEffect14 = WpnEffect14;
            Settings.WpnEffect15 = WpnEffect15;
            Settings.WpnEffect16 = WpnEffect16;
            Settings.WpnEffect17 = WpnEffect17;
            Settings.WpnEffect18 = WpnEffect18;

            Settings.CharacterP1 = CharacterP1;
            Settings.CharacterP2 = CharacterP2;
            Settings.ModelP1 = ModelP1;
            Settings.ModelP2 = ModelP2;

            Settings.UseSetCharacters = UseSetCharacters;

            Settings.P1Speed = P1Speed;
            Settings.P2Speed = P2Speed;

            Settings.NightTerrorSkin = NightTerrorSkin;
            Settings.TakiSkin = TakiSkin;
            Settings.CassandraSkin = CassandraSkin;
            Settings.ColossusSkin = ColossusSkin;
            Settings.LynetteSkin = LynetteSkin;
            Settings.NightmareSkin = NightmareSkin;
            Settings.SiegfriedSkin = SiegfriedSkin;
            Settings.SophitiaSkin = SophitiaSkin;

            string serialString = JsonConvert.SerializeObject(Settings);
            Directory.CreateDirectory(folderPath);
            File.WriteAllText(SettingsPath, serialString);
        }
    }
}
