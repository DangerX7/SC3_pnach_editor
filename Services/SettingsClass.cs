using Microsoft.VisualBasic;
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
        public static string SurvivalPath = "";

        public static string Slot1Type = "Memory Card 1";
        public static string Slot2Type = "Memory Card 2";

        public static bool BonusCharacters { get; set; } = false;
        public static bool UltimateWeapons { get; set; } = false;
        public static int GuardianForceP1 { get; set; } = 0;
        public static int GuardianForceP2 { get; set; } = 0;


        public static int WeaponEffectP1 = 0;
        public static int WeaponSpecialPowerP1 = 0;
        public static int WeaponEffectP2 = 0;
        public static int WeaponSpecialPowerP2 = 0;
        public static int ChroniclesCharacterP1 = 0;
        public static int ChroniclesCharacterP2 = 0;
        public static int ChroniclesCharacterP1_weapon = 0;
        public static int ChroniclesCharacterP2_weapon = 0;

        public static int PlayerControl = 0;
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
        public static string Taki1Skin { get; set; } = "";
        public static string Cassandra2Skin { get; set; } = "";
        public static string ColossusSkin { get; set; } = "";
        public static string Lynette1Skin { get; set; } = "";
        public static string Nightmare1Skin { get; set; } = "";
        public static string Siegfried1Skin { get; set; } = "";
        public static string Sophitia1Skin { get; set; } = "";
        public static string Amy1Skin { get; set; } = "";
        public static string CharadeSkin { get; set; } = "";
        public static string LizardMenSkin { get; set; } = "";
        public static string Astaroth2Skin { get; set; } = "";
        public static string SeongMina1Skin { get; set; } = "";
        public static string Raphael2Skin { get; set; } = "";
        public static string Ivy1Skin { get; set; } = "";
        public static string Cassandra1Skin { get; set; } = "";
        public static string Sophitia2Skin { get; set; } = "";
        public static string Tira1Skin { get; set; } = "";

        public static string SelectedSurvivalMode { get; set; } = "";
        public static string LastSelectedCharP1 { get; set; } = "";
        public static string LastSelectedCharP2 { get; set; } = "";
        public static int LastSelectedIndexP1 { get; set; } = -1;
        public static int LastSelectedIndexP2 { get; set; } = -1;
        public static string VoiceP1 { get; set; } = "";
        public static string VoiceP2 { get; set; } = "";

        public static bool AllGuardBreakP1 { get; set; } = false;
        public static bool AllGuardBreakP2 { get; set; } = false;
        public static bool AllUnblockableP1 { get; set; } = false;
        public static bool AllUnblockableP2 { get; set; } = false; 
        public static bool ParalysisP1 { get; set; } = false;
        public static bool ParalysisP2 { get; set; } = false;
        public static bool DownLoseP1 { get; set; } = false;
        public static bool DownLoseP2 { get; set; } = false;
        public static bool MinusGuardP1 { get; set; } = false;
        public static bool MinusGuardP2 { get; set; } = false;
        public static bool PoisonP1 { get; set; } = false;
        public static bool PoisonP2 { get; set; } = false;
        public static bool SuperPoisonP1 { get; set; } = false;
        public static bool SuperPoisonP2 { get; set; } = false;
        public static bool MegaPoisonP1 { get; set; } = false;
        public static bool MegaPoisonP2 { get; set; } = false;
        public static bool CureP1 { get; set; } = false;
        public static bool CureP2 { get; set; } = false;
        public static bool SuperCureP1 { get; set; } = false;
        public static bool SuperCureP2 { get; set; } = false;
        public static bool MegaCureP1 { get; set; } = false;
        public static bool MegaCureP2 { get; set; } = false;
        public static bool DefenseDownP1 { get; set; } = false;
        public static bool DefenseDownP2 { get; set; } = false;
        public static bool DefenseUpP1 { get; set; } = false;
        public static bool DefenseUpP2 { get; set; } = false;
        public static bool SuperDefenseP1 { get; set; } = false;
        public static bool SuperDefenseP2 { get; set; } = false;
        public static bool GlueP1 { get; set; } = false;
        public static bool GlueP2 { get; set; } = false;
        public static bool SeparateP1 { get; set; } = false;
        public static bool SeparateP2 { get; set; } = false;
        public static bool IceP1 { get; set; } = false;
        public static bool IceP2 { get; set; } = false;
        public static bool WhirlwindP1 { get; set; } = false;
        public static bool WhirlwindP2 { get; set; } = false;
        public static bool AerialWindP1 { get; set; } = false;
        public static bool AerialWindP2 { get; set; } = false;
        public static bool SmashP1 { get; set; } = false;
        public static bool SmashP2 { get; set; } = false;
        public static bool SoulSmashP1 { get; set; } = false;
        public static bool SoulSmashP2 { get; set; } = false;
        public static bool ReserveOffenseUpP1 { get; set; } = false;
        public static bool ReserveOffenseUpP2 { get; set; } = false;

        public static string CustomCharacter1 { get; set; } = "";
        public static string CustomCharacter2 { get; set; } = "";
        public static string CustomCharacter3 { get; set; } = "";
        public static string CustomCharacter4 { get; set; } = "";
        public static string CustomCharacter5 { get; set; } = "";
        public static string CustomCharacter6 { get; set; } = "";
        public static string CustomCharacter7 { get; set; } = "";
        public static string CustomCharacter8 { get; set; } = "";
        public static string CustomCharacter9 { get; set; } = "";
        public static string CustomCharacter10 { get; set; } = "";

        public static string CustomCharacter11 { get; set; } = "";
        public static string CustomCharacter12 { get; set; } = "";
        public static string CustomCharacter13 { get; set; } = "";
        public static string CustomCharacter14 { get; set; } = "";
        public static string CustomCharacter15 { get; set; } = "";
        public static string CustomCharacter16 { get; set; } = "";
        public static string CustomCharacter17 { get; set; } = "";
        public static string CustomCharacter18 { get; set; } = "";
        public static string CustomCharacter19 { get; set; } = "";
        public static string CustomCharacter20 { get; set; } = "";
        public SettingsClass(string connectionString, string pnachName, string gfxCopyFrom, string gfxCopyTo, string survivalPath,
            string slot1Type, string slot2Type, bool bonusCharacters, bool ultimateWeapons,
            int guardianForceP1, int guardianForceP2, int weaponEffectP1, int weaponSpecialPowerP1, int weaponEffectP2, int weaponSpecialPowerP2,
            bool slipperyFieldP1, bool slipperyFieldP2, int chroniclesCharacterP1, int chroniclesCharacterP2, int playerControl, int opponentControl,
            int chroniclesCharacterP1_weapon, int chroniclesCharacterP2_weapon,
            int wpnEffect1, int wpnEffect2, int wpnEffect3, int wpnEffect4, int wpnEffect5, int wpnEffect6,
            int wpnEffect7, int wpnEffect8, int wpnEffect9, int wpnEffect10, int wpnEffect11, int wpnEffect12,
            int wpnEffect13, int wpnEffect14, int wpnEffect15, int wpnEffect16, int wpnEffect17, int wpnEffect18,
            string characterP1, string characterP2, string modelP1, string modelP2, bool useSetCharacters, int p1Speed, int p2Speed,
            string nightTerrorSkin, string taki1Skin, string cassandra2Skin, string colossusSkin, string lynette1Skin, string nightmare1Skin, 
            string siegfried1Skin, string sophitia1Skin, string amy1Skin, string charadeSkin, string lizardMenSkin, string astaroth2Skin,
            string seongMina1Skin, string raphael2Skin, string ivy1Skin, string cassandra1Skin, string sophitia2Skin, string tira1Skin,
            string selectedSurvivalMode, string lastSelectedCharP1, string lastSelectedCharP2,
            int lastSelectedIndexP1, int lastSelectedIndexP2, string voiceP1, string voiceP2,
            bool allGuardBreakP1, bool allGuardBreakP2, bool allUnblockableP1, bool allUnblockableP2, bool paralysisP1, bool paralysisP2,
            bool downLoseP1, bool downLoseP2, bool minusGuardP1, bool minusGuardP2, bool poisonP1, bool poisonP2, bool superPoisonP1, bool superPoisonP2,
            bool megaPoisonP1, bool megaPoisonP2, bool cureP1, bool cureP2, bool superCureP1, bool superCureP2, bool megaCureP1, bool megaCureP2,
            bool defenseDownP1, bool defenseDownP2, bool defenseUpP1, bool defenseUpP2, bool superDefenseP1, bool superDefenseP2,
            bool glueP1, bool glueP2, bool separateP1, bool separateP2, bool iceP1, bool iceP2, bool whirlwindP1, bool whirlwindP2,
            bool aerialWindP1, bool aerialWindP2, bool smashP1, bool smashP2, bool soulSmashP1, bool soulSmashP2,
            bool reserveOffenseUpP1, bool reserveOffenseUpP2,
            string customCharacter1, string customCharacter2, string customCharacter3, string customCharacter4, string customCharacter5,
            string customCharacter6, string customCharacter7, string customCharacter8, string customCharacter9, string customCharacter10,
            string customCharacter11, string customCharacter12, string customCharacter13, string customCharacter14, string customCharacter15,
            string customCharacter16, string customCharacter17, string customCharacter18, string customCharacter19, string customCharacter20)
        {
            codeFolderPath = connectionString;
            PnachName = pnachName;
            GfxCopyFrom = gfxCopyFrom;
            GfxCopyTo = gfxCopyTo;
            SurvivalPath = survivalPath;
            Slot1Type = slot1Type;
            Slot2Type = slot2Type;
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
            PlayerControl = playerControl;
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

            useSetCharacters = UseSetCharacters;//CHECK THIS DUMBASS - no I won't

            P1Speed = p1Speed;
            P2Speed = p2Speed;

            NightTerrorSkin = nightTerrorSkin;
            Taki1Skin = taki1Skin;
            Cassandra2Skin = cassandra2Skin;
            ColossusSkin = colossusSkin;
            Lynette1Skin = lynette1Skin;
            Nightmare1Skin = nightmare1Skin;
            Siegfried1Skin = siegfried1Skin;
            Sophitia1Skin = sophitia1Skin;
            Amy1Skin = amy1Skin;
            CharadeSkin = charadeSkin;
            LizardMenSkin = lizardMenSkin;
            Astaroth2Skin = astaroth2Skin;
            SeongMina1Skin = seongMina1Skin;
            Raphael2Skin = raphael2Skin;
            Ivy1Skin = ivy1Skin;
            Cassandra1Skin = cassandra1Skin;
            Sophitia2Skin = sophitia2Skin;
            Tira1Skin = tira1Skin;

            SelectedSurvivalMode = selectedSurvivalMode;

            LastSelectedCharP1 = lastSelectedCharP1;
            LastSelectedCharP2 = lastSelectedCharP2;
            LastSelectedIndexP1 = lastSelectedIndexP1;
            LastSelectedIndexP2 = lastSelectedIndexP2;

            VoiceP1 = voiceP1;
            VoiceP2 = voiceP2;

            AllGuardBreakP1     = allGuardBreakP1    ;
            AllGuardBreakP2     = allGuardBreakP2    ;
            AllUnblockableP1    = allUnblockableP1   ;
            AllUnblockableP2    = allUnblockableP2   ;
            ParalysisP1         = paralysisP1        ;
            ParalysisP2         = paralysisP2        ;
            DownLoseP1          = downLoseP1         ;
            DownLoseP2          = downLoseP2         ;
            MinusGuardP1        = minusGuardP1       ;
            MinusGuardP2        = minusGuardP2       ;
            PoisonP1            = poisonP1           ;
            PoisonP2            = poisonP2           ;
            SuperPoisonP1       = superPoisonP1      ;
            SuperPoisonP2       = superPoisonP2      ;
            MegaPoisonP1        = megaPoisonP1       ;
            MegaPoisonP2        = megaPoisonP2       ;
            CureP1              = cureP1             ;
            CureP2              = cureP2             ;
            SuperCureP1         = superCureP1        ;
            SuperCureP2         = superCureP2        ;
            MegaCureP1          = megaCureP1         ;
            MegaCureP2          = megaCureP2         ;
            DefenseDownP1       = defenseDownP1      ;
            DefenseDownP2       = defenseDownP2      ;
            DefenseUpP1         = defenseUpP1        ;
            DefenseUpP2         = defenseUpP2        ;
            SuperDefenseP1      = superDefenseP1     ;
            SuperDefenseP2      = superDefenseP2     ;
            GlueP1              = glueP1             ;
            GlueP2              = glueP2             ;
            SeparateP1          = separateP1         ;
            SeparateP2          = separateP2         ;
            IceP1               = iceP1              ;
            IceP2               = iceP2              ;
            WhirlwindP1         = whirlwindP1        ;
            WhirlwindP2         = whirlwindP2        ;
            AerialWindP1        = aerialWindP1       ;
            AerialWindP2        = aerialWindP2       ;
            SmashP1             = smashP1            ;
            SmashP2             = smashP2            ;
            SoulSmashP1         = soulSmashP1        ;
            SoulSmashP2         = soulSmashP2        ;
            ReserveOffenseUpP1  = reserveOffenseUpP1 ;
            ReserveOffenseUpP2  = reserveOffenseUpP2 ;

            CustomCharacter1 = customCharacter1;
            CustomCharacter2 = customCharacter2;
            CustomCharacter3 = customCharacter3;
            CustomCharacter4 = customCharacter4;
            CustomCharacter5 = customCharacter5;
            CustomCharacter6 = customCharacter6;
            CustomCharacter7 = customCharacter7;
            CustomCharacter8 = customCharacter8;
            CustomCharacter9 = customCharacter9;
            CustomCharacter10 = customCharacter10;

            CustomCharacter11 = customCharacter11;
            CustomCharacter12 = customCharacter12;
            CustomCharacter13 = customCharacter13;
            CustomCharacter14 = customCharacter14;
            CustomCharacter15 = customCharacter15;
            CustomCharacter16 = customCharacter16;
            CustomCharacter17 = customCharacter17;
            CustomCharacter18 = customCharacter18;
            CustomCharacter19 = customCharacter19;
            CustomCharacter20 = customCharacter20;
        }

        public static bool isConfigFileLoaded = false;
        public class GetData
        {
            public string codeFolderPath { get; set; } = SettingsClass.codeFolderPath;
            public string PnachName { get; set; } = SettingsClass.PnachName;
            public string GfxCopyFrom { get; set; } = SettingsClass.GfxCopyFrom;
            public string GfxCopyTo { get; set; } = SettingsClass.GfxCopyTo;
            public string SurvivalPath { get; set; } = SettingsClass.SurvivalPath;
            public string Slot1Type { get; set; } = SettingsClass.Slot1Type;
            public string Slot2Type { get; set; } = SettingsClass.Slot2Type;

            public bool BonusCharacters { get; set; } = SettingsClass.BonusCharacters;
            public bool UltimateWeapons { get; set; } = SettingsClass.UltimateWeapons;
            public int GuardianForceP1 { get; set; } = SettingsClass.GuardianForceP1;
            public int GuardianForceP2 { get; set; } = SettingsClass.GuardianForceP2;
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


            public int PlayerControl { get; set; } = SettingsClass.PlayerControl;
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
            public string Taki1Skin { get; set; } = SettingsClass.Taki1Skin;
            public string Cassandra2Skin { get; set; } = SettingsClass.Cassandra2Skin;
            public string ColossusSkin { get; set; } = SettingsClass.ColossusSkin;
            public string Lynette1Skin { get; set; } = SettingsClass.Lynette1Skin;
            public string Nightmare1Skin { get; set; } = SettingsClass.Nightmare1Skin;
            public string Siegfried1Skin { get; set; } = SettingsClass.Siegfried1Skin;
            public string Sophitia1Skin { get; set; } = SettingsClass.Sophitia1Skin;
            public string Amy1Skin { get; set; } = SettingsClass.Amy1Skin;
            public string CharadeSkin { get; set; } = SettingsClass.CharadeSkin;
            public string LizardMenSkin { get; set; } = SettingsClass.LizardMenSkin;
            public string Astaroth2Skin { get; set; } = SettingsClass.Astaroth2Skin;
            public string SeongMina1Skin { get; set; } = SettingsClass.SeongMina1Skin;
            public string Raphael2Skin { get; set; } = SettingsClass.Raphael2Skin;
            public string Ivy1Skin { get; set; } = SettingsClass.Ivy1Skin;
            public string Cassandra1Skin { get; set; } = SettingsClass.Cassandra1Skin;
            public string Sophitia2Skin { get; set; } = SettingsClass.Sophitia2Skin;
            public string Tira1Skin { get; set; } = SettingsClass.Tira1Skin;

            public string SelectedSurvivalMode { get; set; } = SettingsClass.SelectedSurvivalMode;
            public string LastSelectedCharP1 { get; set; } = SettingsClass.LastSelectedCharP1;
            public string LastSelectedCharP2 { get; set; } = SettingsClass.LastSelectedCharP2;
            public int LastSelectedIndexP1 { get; set; } = SettingsClass.LastSelectedIndexP1;
            public int LastSelectedIndexP2 { get; set; } = SettingsClass.LastSelectedIndexP2;

            public string VoiceP1 { get; set; } = SettingsClass.VoiceP1;
            public string VoiceP2 { get; set; } = SettingsClass.VoiceP2;

            public bool AllGuardBreakP1       { get; set; } = SettingsClass.AllGuardBreakP1   ;
            public bool AllGuardBreakP2       { get; set; } = SettingsClass.AllGuardBreakP2   ;
            public bool AllUnblockableP1      { get; set; } = SettingsClass.AllUnblockableP1  ;
            public bool AllUnblockableP2      { get; set; } = SettingsClass.AllUnblockableP2  ;
            public bool ParalysisP1           { get; set; } = SettingsClass.ParalysisP1       ;
            public bool ParalysisP2           { get; set; } = SettingsClass.ParalysisP2       ;
            public bool DownLoseP1            { get; set; } = SettingsClass.DownLoseP1        ;
            public bool DownLoseP2            { get; set; } = SettingsClass.DownLoseP2        ;
            public bool MinusGuardP1          { get; set; } = SettingsClass.MinusGuardP1      ;
            public bool MinusGuardP2          { get; set; } = SettingsClass.MinusGuardP2      ;
            public bool PoisonP1              { get; set; } = SettingsClass.PoisonP1          ;
            public bool PoisonP2              { get; set; } = SettingsClass.PoisonP2          ;
            public bool SuperPoisonP1         { get; set; } = SettingsClass.SuperPoisonP1     ;
            public bool SuperPoisonP2         { get; set; } = SettingsClass.SuperPoisonP2     ;
            public bool MegaPoisonP1          { get; set; } = SettingsClass.MegaPoisonP1      ;
            public bool MegaPoisonP2          { get; set; } = SettingsClass.MegaPoisonP2      ;
            public bool CureP1                { get; set; } = SettingsClass.CureP1            ;
            public bool CureP2                { get; set; } = SettingsClass.CureP2            ;
            public bool SuperCureP1           { get; set; } = SettingsClass.SuperCureP1       ;
            public bool SuperCureP2           { get; set; } = SettingsClass.SuperCureP2       ;
            public bool MegaCureP1            { get; set; } = SettingsClass.MegaCureP1        ;
            public bool MegaCureP2            { get; set; } = SettingsClass.MegaCureP2        ;
            public bool DefenseDownP1         { get; set; } = SettingsClass.DefenseDownP1     ;
            public bool DefenseDownP2         { get; set; } = SettingsClass.DefenseDownP2     ;
            public bool DefenseUpP1           { get; set; } = SettingsClass.DefenseUpP1       ;
            public bool DefenseUpP2           { get; set; } = SettingsClass.DefenseUpP2       ;
            public bool SuperDefenseP1        { get; set; } = SettingsClass.SuperDefenseP1    ;
            public bool SuperDefenseP2        { get; set; } = SettingsClass.SuperDefenseP2    ;
            public bool GlueP1                { get; set; } = SettingsClass.GlueP1            ;
            public bool GlueP2                { get; set; } = SettingsClass.GlueP2            ;
            public bool SeparateP1            { get; set; } = SettingsClass.SeparateP1        ;
            public bool SeparateP2            { get; set; } = SettingsClass.SeparateP2        ;
            public bool IceP1                 { get; set; } = SettingsClass.IceP1             ;
            public bool IceP2                 { get; set; } = SettingsClass.IceP2             ;
            public bool WhirlwindP1           { get; set; } = SettingsClass.WhirlwindP1       ;
            public bool WhirlwindP2           { get; set; } = SettingsClass.WhirlwindP2       ;
            public bool AerialWindP1          { get; set; } = SettingsClass.AerialWindP1      ;
            public bool AerialWindP2          { get; set; } = SettingsClass.AerialWindP2      ;
            public bool SmashP1               { get; set; } = SettingsClass.SmashP1           ;
            public bool SmashP2               { get; set; } = SettingsClass.SmashP2           ;
            public bool SoulSmashP1           { get; set; } = SettingsClass.SoulSmashP1       ;
            public bool SoulSmashP2           { get; set; } = SettingsClass.SoulSmashP2       ;
            public bool ReserveOffenseUpP1    { get; set; } = SettingsClass.ReserveOffenseUpP1;
            public bool ReserveOffenseUpP2    { get; set; } = SettingsClass.ReserveOffenseUpP2;


            public string CustomCharacter1 { get; set; } = SettingsClass.CustomCharacter1;
            public string CustomCharacter2 { get; set; } = SettingsClass.CustomCharacter2;
            public string CustomCharacter3 { get; set; } = SettingsClass.CustomCharacter3;
            public string CustomCharacter4 { get; set; } = SettingsClass.CustomCharacter4;
            public string CustomCharacter5 { get; set; } = SettingsClass.CustomCharacter5;
            public string CustomCharacter6 { get; set; } = SettingsClass.CustomCharacter6;
            public string CustomCharacter7 { get; set; } = SettingsClass.CustomCharacter7;
            public string CustomCharacter8 { get; set; } = SettingsClass.CustomCharacter8;
            public string CustomCharacter9 { get; set; } = SettingsClass.CustomCharacter9;
            public string CustomCharacter10 { get; set; } = SettingsClass.CustomCharacter10;

            public string CustomCharacter11 { get; set; } = SettingsClass.CustomCharacter11;
            public string CustomCharacter12 { get; set; } = SettingsClass.CustomCharacter12;
            public string CustomCharacter13 { get; set; } = SettingsClass.CustomCharacter13;
            public string CustomCharacter14 { get; set; } = SettingsClass.CustomCharacter14;
            public string CustomCharacter15 { get; set; } = SettingsClass.CustomCharacter15;
            public string CustomCharacter16 { get; set; } = SettingsClass.CustomCharacter16;
            public string CustomCharacter17 { get; set; } = SettingsClass.CustomCharacter17;
            public string CustomCharacter18 { get; set; } = SettingsClass.CustomCharacter18;
            public string CustomCharacter19 { get; set; } = SettingsClass.CustomCharacter19;
            public string CustomCharacter20 { get; set; } = SettingsClass.CustomCharacter20;
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
                SurvivalPath = Settings.SurvivalPath;
                Slot1Type = Settings.Slot1Type;
                Slot2Type = Settings.Slot2Type;
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
                PlayerControl = Settings.PlayerControl;

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
                Taki1Skin = Settings.Taki1Skin;
                Cassandra2Skin = Settings.Cassandra2Skin;
                ColossusSkin = Settings.ColossusSkin;
                Lynette1Skin = Settings.Lynette1Skin;
                Nightmare1Skin = Settings.Nightmare1Skin;
                Siegfried1Skin = Settings.Siegfried1Skin;
                Sophitia1Skin = Settings.Sophitia1Skin;
                Amy1Skin = Settings.Amy1Skin;
                CharadeSkin = Settings.CharadeSkin;
                LizardMenSkin = Settings.LizardMenSkin;
                Astaroth2Skin = Settings.Astaroth2Skin;
                SeongMina1Skin = Settings.SeongMina1Skin;
                Raphael2Skin = Settings.Raphael2Skin;
                Ivy1Skin = Settings.Ivy1Skin;
                Cassandra1Skin = Settings.Cassandra1Skin;
                Sophitia2Skin = Settings.Sophitia2Skin;
                Tira1Skin = Settings.Tira1Skin;

                SelectedSurvivalMode = Settings.SelectedSurvivalMode;
                LastSelectedCharP1 = Settings.LastSelectedCharP1;
                LastSelectedCharP2 = Settings.LastSelectedCharP2;
                LastSelectedIndexP1 = Settings.LastSelectedIndexP1;
                LastSelectedIndexP2 = Settings.LastSelectedIndexP2;

                VoiceP1 = Settings.VoiceP1;
                VoiceP2 = Settings.VoiceP2;

                AllGuardBreakP1       = Settings.AllGuardBreakP1   ;
                AllGuardBreakP2       = Settings.AllGuardBreakP2   ;
                AllUnblockableP1      = Settings.AllUnblockableP1  ;
                AllUnblockableP2      = Settings.AllUnblockableP2  ;
                ParalysisP1           = Settings.ParalysisP1       ;
                ParalysisP2           = Settings.ParalysisP2       ;
                DownLoseP1            = Settings.DownLoseP1        ;
                DownLoseP2            = Settings.DownLoseP2        ;
                MinusGuardP1          = Settings.MinusGuardP1      ;
                MinusGuardP2          = Settings.MinusGuardP2      ;
                PoisonP1              = Settings.PoisonP1          ;
                PoisonP2              = Settings.PoisonP2          ;
                SuperPoisonP1         = Settings.SuperPoisonP1     ;
                SuperPoisonP2         = Settings.SuperPoisonP2     ;
                MegaPoisonP1          = Settings.MegaPoisonP1      ;
                MegaPoisonP2          = Settings.MegaPoisonP2      ;
                CureP1                = Settings.CureP1            ;
                CureP2                = Settings.CureP2            ;
                SuperCureP1           = Settings.SuperCureP1       ;
                SuperCureP2           = Settings.SuperCureP2       ;
                MegaCureP1            = Settings.MegaCureP1        ;
                MegaCureP2            = Settings.MegaCureP2        ;
                DefenseDownP1         = Settings.DefenseDownP1     ;
                DefenseDownP2         = Settings.DefenseDownP2     ;
                DefenseUpP1           = Settings.DefenseUpP1       ;
                DefenseUpP2           = Settings.DefenseUpP2       ;
                SuperDefenseP1        = Settings.SuperDefenseP1    ;
                SuperDefenseP2        = Settings.SuperDefenseP2    ;
                GlueP1                = Settings.GlueP1            ;
                GlueP2                = Settings.GlueP2            ;
                SeparateP1            = Settings.SeparateP1        ;
                SeparateP2            = Settings.SeparateP2        ;
                IceP1                 = Settings.IceP1             ;
                IceP2                 = Settings.IceP2             ;
                WhirlwindP1           = Settings.WhirlwindP1       ;
                WhirlwindP2           = Settings.WhirlwindP2       ;
                AerialWindP1          = Settings.AerialWindP1      ;
                AerialWindP2          = Settings.AerialWindP2      ;
                SmashP1               = Settings.SmashP1           ;
                SmashP2               = Settings.SmashP2           ;
                SoulSmashP1           = Settings.SoulSmashP1       ;
                SoulSmashP2           = Settings.SoulSmashP2       ;
                ReserveOffenseUpP1    = Settings.ReserveOffenseUpP1;
                ReserveOffenseUpP2    = Settings.ReserveOffenseUpP2;

                CustomCharacter1 = Settings.CustomCharacter1;
                CustomCharacter2 = Settings.CustomCharacter2;
                CustomCharacter3 = Settings.CustomCharacter3;
                CustomCharacter4 = Settings.CustomCharacter4;
                CustomCharacter5 = Settings.CustomCharacter5;
                CustomCharacter6 = Settings.CustomCharacter6;
                CustomCharacter7 = Settings.CustomCharacter7;
                CustomCharacter8 = Settings.CustomCharacter8;
                CustomCharacter9 = Settings.CustomCharacter9;
                CustomCharacter10 = Settings.CustomCharacter10;

                CustomCharacter11 = Settings.CustomCharacter11;
                CustomCharacter12 = Settings.CustomCharacter12;
                CustomCharacter13 = Settings.CustomCharacter13;
                CustomCharacter14 = Settings.CustomCharacter14;
                CustomCharacter15 = Settings.CustomCharacter15;
                CustomCharacter16 = Settings.CustomCharacter16;
                CustomCharacter17 = Settings.CustomCharacter17;
                CustomCharacter18 = Settings.CustomCharacter18;
                CustomCharacter19 = Settings.CustomCharacter19;
                CustomCharacter20 = Settings.CustomCharacter20;
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
            Settings.SurvivalPath = SurvivalPath;
            Settings.Slot1Type = Slot1Type;
            Settings.Slot2Type = Slot2Type;
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
            Settings.PlayerControl = PlayerControl;

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
            Settings.Taki1Skin = Taki1Skin;
            Settings.Cassandra2Skin = Cassandra2Skin;
            Settings.ColossusSkin = ColossusSkin;
            Settings.Lynette1Skin = Lynette1Skin;
            Settings.Nightmare1Skin = Nightmare1Skin;
            Settings.Siegfried1Skin = Siegfried1Skin;
            Settings.Sophitia1Skin = Sophitia1Skin;
            Settings.Amy1Skin = Amy1Skin;
            Settings.CharadeSkin = CharadeSkin;
            Settings.LizardMenSkin = LizardMenSkin;
            Settings.Astaroth2Skin = Astaroth2Skin;
            Settings.SeongMina1Skin = SeongMina1Skin;
            Settings.Raphael2Skin = Raphael2Skin;
            Settings.Ivy1Skin = Ivy1Skin;
            Settings.Cassandra1Skin = Cassandra1Skin;
            Settings.Sophitia2Skin = Sophitia2Skin;
            Settings.Tira1Skin = Tira1Skin;

            Settings.SelectedSurvivalMode = SelectedSurvivalMode;
            Settings.LastSelectedCharP1 = LastSelectedCharP1;
            Settings.LastSelectedCharP2 = LastSelectedCharP2;
            Settings.LastSelectedIndexP1 = LastSelectedIndexP1;
            Settings.LastSelectedIndexP2 = LastSelectedIndexP2;

            Settings.VoiceP1 = VoiceP1;
            Settings.VoiceP2 = VoiceP2;

            Settings.AllGuardBreakP1       = AllGuardBreakP1   ;
            Settings.AllGuardBreakP2       = AllGuardBreakP2   ;
            Settings.AllUnblockableP1      = AllUnblockableP1  ;
            Settings.AllUnblockableP2      = AllUnblockableP2  ;
            Settings.ParalysisP1           = ParalysisP1       ;
            Settings.ParalysisP2           = ParalysisP2       ;
            Settings.DownLoseP1            = DownLoseP1        ;
            Settings.DownLoseP2            = DownLoseP2        ;
            Settings.MinusGuardP1          = MinusGuardP1      ;
            Settings.MinusGuardP2          = MinusGuardP2      ;
            Settings.PoisonP1              = PoisonP1          ;
            Settings.PoisonP2              = PoisonP2          ;
            Settings.SuperPoisonP1         = SuperPoisonP1     ;
            Settings.SuperPoisonP2         = SuperPoisonP2     ;
            Settings.MegaPoisonP1          = MegaPoisonP1      ;
            Settings.MegaPoisonP2          = MegaPoisonP2      ;
            Settings.CureP1                = CureP1            ;
            Settings.CureP2                = CureP2            ;
            Settings.SuperCureP1           = SuperCureP1       ;
            Settings.SuperCureP2           = SuperCureP2       ;
            Settings.MegaCureP1            = MegaCureP1        ;
            Settings.MegaCureP2            = MegaCureP2        ;
            Settings.DefenseDownP1         = DefenseDownP1     ;
            Settings.DefenseDownP2         = DefenseDownP2     ;
            Settings.DefenseUpP1           = DefenseUpP1       ;
            Settings.DefenseUpP2           = DefenseUpP2       ;
            Settings.SuperDefenseP1        = SuperDefenseP1    ;
            Settings.SuperDefenseP2        = SuperDefenseP2    ;
            Settings.GlueP1                = GlueP1            ;
            Settings.GlueP2                = GlueP2            ;
            Settings.SeparateP1            = SeparateP1        ;
            Settings.SeparateP2            = SeparateP2        ;
            Settings.IceP1                 = IceP1             ;
            Settings.IceP2                 = IceP2             ;
            Settings.WhirlwindP1           = WhirlwindP1       ;
            Settings.WhirlwindP2           = WhirlwindP2       ;
            Settings.AerialWindP1          = AerialWindP1      ;
            Settings.AerialWindP2          = AerialWindP2      ;
            Settings.SmashP1               = SmashP1           ;
            Settings.SmashP2               = SmashP2           ;
            Settings.SoulSmashP1           = SoulSmashP1       ;
            Settings.SoulSmashP2           = SoulSmashP2       ;
            Settings.ReserveOffenseUpP1    = ReserveOffenseUpP1;
            Settings.ReserveOffenseUpP2    = ReserveOffenseUpP2;

            Settings.CustomCharacter1 = CustomCharacter1;
            Settings.CustomCharacter2 = CustomCharacter2;
            Settings.CustomCharacter3 = CustomCharacter3;
            Settings.CustomCharacter4 = CustomCharacter4;
            Settings.CustomCharacter5 = CustomCharacter5;
            Settings.CustomCharacter6 = CustomCharacter6;
            Settings.CustomCharacter7 = CustomCharacter7;
            Settings.CustomCharacter8 = CustomCharacter8;
            Settings.CustomCharacter9 = CustomCharacter9;
            Settings.CustomCharacter10 = CustomCharacter10;

            Settings.CustomCharacter11 = CustomCharacter11;
            Settings.CustomCharacter12 = CustomCharacter12;
            Settings.CustomCharacter13 = CustomCharacter13;
            Settings.CustomCharacter14 = CustomCharacter14;
            Settings.CustomCharacter15 = CustomCharacter15;
            Settings.CustomCharacter16 = CustomCharacter16;
            Settings.CustomCharacter17 = CustomCharacter17;
            Settings.CustomCharacter18 = CustomCharacter18;
            Settings.CustomCharacter19 = CustomCharacter19;
            Settings.CustomCharacter20 = CustomCharacter20;

            string serialString = JsonConvert.SerializeObject(Settings);
            Directory.CreateDirectory(folderPath);
            File.WriteAllText(SettingsPath, serialString);
        }
    }
}
