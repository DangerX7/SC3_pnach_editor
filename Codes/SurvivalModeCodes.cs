using SC3_pnach_editor.Services;
using SC3_pnach_editor.ViewModelsClasses;
using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SC3_pnach_editor.Codes
{
    public class SurvivalModeCodes
    {
        public static string GetSurvivalCode(string survivalName, bool liteMode)
        {
            SurvivalList survivalCode = new SurvivalList();
            List<string> survivalPnach = new List<string>();
            string stageCode = "";
            switch (survivalName)
            {
                #region Training Arc  [Assassin]
                case "Training Arc":
                    survivalCode.stageLevel = "000D";
                    survivalCode.stageMusic = "0D";
                    survivalCode.stageNumber = 1;
                    survivalCode.model = "85";
                    survivalCode.costume = "00";
                    survivalCode.fightingStyle = "4D";
                    survivalCode.weaponNumber = "00"; //Gladiator 1

                    survivalCode.aiLevel = "00"; // 00-05
                    survivalCode.weaponSpecial = ""; //Fire, Thunder etc
                    survivalCode.guardianForce = "04"; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                    survivalCode.stickyFeet = ""; //Slippery Feets
                    survivalCode.speed = "3F80"; //3F80 default speed

                    survivalCode.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                    survivalCode.attack = ""; //Decrease/Increase Attack
                    survivalCode.defense = ""; //Decrease/Increase Defense
                    survivalCode.stealHp = ""; //Steal health from enemy
                    survivalCode.pierceDamage = ""; //Damage inflicted thru guard
                    survivalCode.weaponSize = "3F600000";
                    survivalCode.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                    survivalCode.counterRate = ""; //Increase Counter Chance
                    survivalCode.nullCounter = ""; //Nullify Enemies Counters chance
                    survivalCode.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                    survivalCode.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                    survivalCode.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                    survivalCode.parryRegen = ""; //Recover Health when successfully Guard Impact
                    survivalCode.guardBreakRate = ""; //Increase Guard Break Chance
                    survivalCode.throwEscapeChance = ""; //Increase Throw Escape Rate
                    survivalCode.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                    survivalCode.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                    survivalCode.hpRegenOrDrainOnAtk = "C0000000"; //Drain/Recover Health when Attacking
                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "";
                    survivalCode.stageNumber = 2;
                    survivalCode.model = "8C";
                    survivalCode.costume = "01";
                    survivalCode.fightingStyle = "41";
                    survivalCode.weaponNumber = "00"; //Fu-ma Ninja 5

                    survivalCode.aiLevel = "00"; // 0-5
                    survivalCode.weaponSpecial = ""; //Fire, Thunder etc
                    survivalCode.guardianForce = "04"; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                    survivalCode.stickyFeet = ""; //Slippery Feets
                    survivalCode.speed = "3F80"; //3F80 default speed

                    survivalCode.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                    survivalCode.attack = ""; //Decrease/Increase Attack
                    survivalCode.defense = ""; //Decrease/Increase Defense
                    survivalCode.stealHp = ""; //Steal health from enemy
                    survivalCode.pierceDamage = ""; //Damage inflicted thru guard
                    survivalCode.weaponSize = "";
                    survivalCode.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                    survivalCode.counterRate = ""; //Increase Counter Chance
                    survivalCode.nullCounter = ""; //Nullify Enemies Counters chance
                    survivalCode.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                    survivalCode.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                    survivalCode.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                    survivalCode.parryRegen = ""; //Recover Health when successfully Guard Impact
                    survivalCode.guardBreakRate = ""; //Increase Guard Break Chance
                    survivalCode.throwEscapeChance = ""; //Increase Throw Escape Rate
                    survivalCode.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                    survivalCode.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                    survivalCode.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "";
                    survivalCode.stageNumber = 3;
                    survivalCode.model = "97";
                    survivalCode.costume = "00";
                    survivalCode.fightingStyle = "47";
                    survivalCode.weaponNumber = "00"; //Sentry

                    survivalCode.aiLevel = "00"; // 0-5
                    survivalCode.weaponSpecial = ""; //Fire, Thunder etc
                    survivalCode.guardianForce = "04"; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                    survivalCode.stickyFeet = ""; //Slippery Feets
                    survivalCode.speed = "3F80"; //3F80 default speed

                    survivalCode.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                    survivalCode.attack = ""; //Decrease/Increase Attack
                    survivalCode.defense = ""; //Decrease/Increase Defense
                    survivalCode.stealHp = ""; //Steal health from enemy
                    survivalCode.pierceDamage = ""; //Damage inflicted thru guard
                    survivalCode.weaponSize = "";
                    survivalCode.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                    survivalCode.counterRate = ""; //Increase Counter Chance
                    survivalCode.nullCounter = ""; //Nullify Enemies Counters chance
                    survivalCode.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                    survivalCode.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                    survivalCode.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                    survivalCode.parryRegen = ""; //Recover Health when successfully Guard Impact
                    survivalCode.guardBreakRate = ""; //Increase Guard Break Chance
                    survivalCode.throwEscapeChance = ""; //Increase Throw Escape Rate
                    survivalCode.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                    survivalCode.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                    survivalCode.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "";
                    survivalCode.stageNumber = 4;
                    survivalCode.model = "B3";
                    survivalCode.costume = "02";
                    survivalCode.fightingStyle = "4B";
                    survivalCode.weaponNumber = "00"; //Aika

                    survivalCode.aiLevel = "00"; // 0-5
                    survivalCode.weaponSpecial = ""; //Fire, Thunder etc
                    survivalCode.guardianForce = ""; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                    survivalCode.stickyFeet = ""; //Slippery Feets
                    survivalCode.speed = "3F40"; //3F80 default speed

                    survivalCode.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                    survivalCode.attack = ""; //Decrease/Increase Attack
                    survivalCode.defense = ""; //Decrease/Increase Defense
                    survivalCode.stealHp = ""; //Steal health from enemy
                    survivalCode.pierceDamage = ""; //Damage inflicted thru guard
                    survivalCode.weaponSize = "";
                    survivalCode.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                    survivalCode.counterRate = ""; //Increase Counter Chance
                    survivalCode.nullCounter = ""; //Nullify Enemies Counters chance
                    survivalCode.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                    survivalCode.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                    survivalCode.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                    survivalCode.parryRegen = ""; //Recover Health when successfully Guard Impact
                    survivalCode.guardBreakRate = ""; //Increase Guard Break Chance
                    survivalCode.throwEscapeChance = ""; //Increase Throw Escape Rate
                    survivalCode.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                    survivalCode.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                    survivalCode.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "";
                    survivalCode.stageNumber = 5;
                    survivalCode.model = "AA";
                    survivalCode.costume = "00";
                    survivalCode.fightingStyle = "46";
                    survivalCode.weaponNumber = "00"; //Ignis

                    survivalCode.aiLevel = "00"; // 0-5
                    survivalCode.weaponSpecial = ""; //Fire, Thunder etc
                    survivalCode.guardianForce = ""; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                    survivalCode.stickyFeet = ""; //Slippery Feets
                    survivalCode.speed = "3F40"; //3F80 default speed

                    survivalCode.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                    survivalCode.attack = ""; //Decrease/Increase Attack
                    survivalCode.defense = ""; //Decrease/Increase Defense
                    survivalCode.stealHp = ""; //Steal health from enemy
                    survivalCode.pierceDamage = ""; //Damage inflicted thru guard
                    survivalCode.weaponSize = "";
                    survivalCode.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                    survivalCode.counterRate = ""; //Increase Counter Chance
                    survivalCode.nullCounter = ""; //Nullify Enemies Counters chance
                    survivalCode.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                    survivalCode.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                    survivalCode.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                    survivalCode.parryRegen = ""; //Recover Health when successfully Guard Impact
                    survivalCode.guardBreakRate = ""; //Increase Guard Break Chance
                    survivalCode.throwEscapeChance = ""; //Increase Throw Escape Rate
                    survivalCode.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                    survivalCode.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                    survivalCode.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "0001";
                    survivalCode.stageMusic = "01";
                    survivalCode.stageNumber = 6;
                    survivalCode.model = "54";
                    survivalCode.costume = "01";
                    survivalCode.fightingStyle = "54";
                    survivalCode.weaponNumber = "00"; //Revenant

                    survivalCode.aiLevel = "00"; // 0-5
                    survivalCode.weaponSpecial = ""; //Fire, Thunder etc
                    survivalCode.guardianForce = ""; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                    survivalCode.stickyFeet = ""; //Slippery Feets ; no means will trip
                    survivalCode.speed = "3F60"; //3F80 default speed

                    survivalCode.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                    survivalCode.attack = ""; //Decrease/Increase Attack
                    survivalCode.defense = ""; //Decrease/Increase Defense
                    survivalCode.stealHp = ""; //Steal health from enemy
                    survivalCode.pierceDamage = ""; //Damage inflicted thru guard
                    survivalCode.weaponSize = "3F600000";
                    survivalCode.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                    survivalCode.counterRate = ""; //Increase Counter Chance
                    survivalCode.nullCounter = ""; //Nullify Enemies Counters chance
                    survivalCode.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                    survivalCode.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                    survivalCode.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                    survivalCode.parryRegen = ""; //Recover Health when successfully Guard Impact
                    survivalCode.guardBreakRate = ""; //Increase Guard Break Chance
                    survivalCode.throwEscapeChance = ""; //Increase Throw Escape Rate
                    survivalCode.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                    survivalCode.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                    survivalCode.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "";
                    survivalCode.stageNumber = 7;
                    survivalCode.model = "4A";
                    survivalCode.costume = "01";
                    survivalCode.fightingStyle = "4A";
                    survivalCode.weaponNumber = "00"; //Demuth

                    survivalCode.aiLevel = "00"; // 0-5
                    survivalCode.weaponSpecial = "Poison P2"; //Fire, Thunder etc
                    survivalCode.guardianForce = ""; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                    survivalCode.stickyFeet = ""; //Slippery Feets ; no means will trip
                    survivalCode.speed = "3F80"; //3F80 default speed

                    survivalCode.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                    survivalCode.attack = ""; //Decrease/Increase Attack
                    survivalCode.defense = ""; //Decrease/Increase Defense
                    survivalCode.stealHp = ""; //Steal health from enemy
                    survivalCode.pierceDamage = ""; //Damage inflicted thru guard
                    survivalCode.weaponSize = "";
                    survivalCode.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                    survivalCode.counterRate = ""; //Increase Counter Chance
                    survivalCode.nullCounter = ""; //Nullify Enemies Counters chance
                    survivalCode.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                    survivalCode.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                    survivalCode.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                    survivalCode.parryRegen = ""; //Recover Health when successfully Guard Impact
                    survivalCode.guardBreakRate = ""; //Increase Guard Break Chance
                    survivalCode.throwEscapeChance = ""; //Increase Throw Escape Rate
                    survivalCode.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                    survivalCode.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                    survivalCode.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "";
                    survivalCode.stageNumber = 8;
                    survivalCode.model = "84";
                    survivalCode.costume = "02";
                    survivalCode.fightingStyle = "43";
                    survivalCode.weaponNumber = "00"; //Samurai 3

                    survivalCode.aiLevel = "00"; // 0-5
                    survivalCode.weaponSpecial = "Poison P2"; //Fire, Thunder etc
                    survivalCode.guardianForce = ""; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                    survivalCode.stickyFeet = ""; //Slippery Feets ; no means will trip
                    survivalCode.speed = "3F80"; //3F80 default speed

                    survivalCode.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                    survivalCode.attack = ""; //Decrease/Increase Attack
                    survivalCode.defense = ""; //Decrease/Increase Defense
                    survivalCode.stealHp = ""; //Steal health from enemy
                    survivalCode.pierceDamage = ""; //Damage inflicted thru guard
                    survivalCode.weaponSize = "";
                    survivalCode.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                    survivalCode.counterRate = ""; //Increase Counter Chance
                    survivalCode.nullCounter = ""; //Nullify Enemies Counters chance
                    survivalCode.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                    survivalCode.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                    survivalCode.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                    survivalCode.parryRegen = ""; //Recover Health when successfully Guard Impact
                    survivalCode.guardBreakRate = ""; //Increase Guard Break Chance
                    survivalCode.throwEscapeChance = ""; //Increase Throw Escape Rate
                    survivalCode.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                    survivalCode.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                    survivalCode.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "";
                    survivalCode.stageNumber = 9;
                    survivalCode.model = "A2";
                    survivalCode.costume = "00";
                    survivalCode.fightingStyle = "42";
                    survivalCode.weaponNumber = "00"; //Cassius

                    survivalCode.aiLevel = "00"; // 0-5
                    survivalCode.weaponSpecial = "Poison P2"; //Fire, Thunder etc
                    survivalCode.guardianForce = ""; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                    survivalCode.stickyFeet = ""; //Slippery Feets ; no means will trip
                    survivalCode.speed = "3F80"; //3F80 default speed

                    survivalCode.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                    survivalCode.attack = ""; //Decrease/Increase Attack
                    survivalCode.defense = ""; //Decrease/Increase Defense
                    survivalCode.stealHp = ""; //Steal health from enemy
                    survivalCode.pierceDamage = ""; //Damage inflicted thru guard
                    survivalCode.weaponSize = "";
                    survivalCode.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                    survivalCode.counterRate = ""; //Increase Counter Chance
                    survivalCode.nullCounter = ""; //Nullify Enemies Counters chance
                    survivalCode.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                    survivalCode.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                    survivalCode.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                    survivalCode.parryRegen = ""; //Recover Health when successfully Guard Impact
                    survivalCode.guardBreakRate = ""; //Increase Guard Break Chance
                    survivalCode.throwEscapeChance = ""; //Increase Throw Escape Rate
                    survivalCode.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                    survivalCode.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                    survivalCode.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "";
                    survivalCode.stageNumber = 10;
                    survivalCode.model = "B8";
                    survivalCode.costume = "02";
                    survivalCode.fightingStyle = "4E";
                    survivalCode.weaponNumber = "00"; //Feofan

                    survivalCode.aiLevel = "00"; // 0-5
                    survivalCode.weaponSpecial = "Poison P2"; //Fire, Thunder etc
                    survivalCode.guardianForce = ""; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                    survivalCode.stickyFeet = ""; //Slippery Feets ; no means will trip
                    survivalCode.speed = "3F80"; //3F80 default speed

                    survivalCode.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                    survivalCode.attack = ""; //Decrease/Increase Attack
                    survivalCode.defense = ""; //Decrease/Increase Defense
                    survivalCode.stealHp = ""; //Steal health from enemy
                    survivalCode.pierceDamage = ""; //Damage inflicted thru guard
                    survivalCode.weaponSize = "";
                    survivalCode.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                    survivalCode.counterRate = ""; //Increase Counter Chance
                    survivalCode.nullCounter = ""; //Nullify Enemies Counters chance
                    survivalCode.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                    survivalCode.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                    survivalCode.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                    survivalCode.parryRegen = ""; //Recover Health when successfully Guard Impact
                    survivalCode.guardBreakRate = ""; //Increase Guard Break Chance
                    survivalCode.throwEscapeChance = ""; //Increase Throw Escape Rate
                    survivalCode.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                    survivalCode.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                    survivalCode.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "0016";
                    survivalCode.stageMusic = "16";
                    survivalCode.stageNumber = 11;
                    survivalCode.model = "1E";
                    survivalCode.costume = "00";
                    survivalCode.fightingStyle = "0E";
                    survivalCode.weaponNumber = "06"; //Lizard Men

                    survivalCode.aiLevel = "00"; // 0-5
                    survivalCode.weaponSpecial = ""; //Fire, Thunder etc
                    survivalCode.guardianForce = ""; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                    survivalCode.stickyFeet = ""; //Slippery Feets
                    survivalCode.speed = "3F80"; //3F80 default speed

                    survivalCode.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                    survivalCode.attack = ""; //Decrease/Increase Attack
                    survivalCode.defense = ""; //Decrease/Increase Defense
                    survivalCode.stealHp = ""; //Steal health from enemy
                    survivalCode.pierceDamage = ""; //Damage inflicted thru guard
                    survivalCode.weaponSize = "";
                    survivalCode.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                    survivalCode.counterRate = ""; //Increase Counter Chance
                    survivalCode.nullCounter = ""; //Nullify Enemies Counters chance
                    survivalCode.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                    survivalCode.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                    survivalCode.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                    survivalCode.parryRegen = ""; //Recover Health when successfully Guard Impact
                    survivalCode.guardBreakRate = ""; //Increase Guard Break Chance
                    survivalCode.throwEscapeChance = ""; //Increase Throw Escape Rate
                    survivalCode.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                    survivalCode.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                    survivalCode.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "";
                    survivalCode.stageNumber = 12;
                    survivalCode.model = "1A";
                    survivalCode.costume = "01";
                    survivalCode.fightingStyle = "1A";
                    survivalCode.weaponNumber = "06"; //Yun-Seong

                    survivalCode.aiLevel = "00"; // 0-5
                    survivalCode.weaponSpecial = ""; //Fire, Thunder etc
                    survivalCode.guardianForce = ""; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                    survivalCode.stickyFeet = ""; //Slippery Feets
                    survivalCode.speed = "3F80"; //3F80 default speed

                    survivalCode.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                    survivalCode.attack = ""; //Decrease/Increase Attack
                    survivalCode.defense = ""; //Decrease/Increase Defense
                    survivalCode.stealHp = ""; //Steal health from enemy
                    survivalCode.pierceDamage = ""; //Damage inflicted thru guard
                    survivalCode.weaponSize = "";
                    survivalCode.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                    survivalCode.counterRate = ""; //Increase Counter Chance
                    survivalCode.nullCounter = ""; //Nullify Enemies Counters chance
                    survivalCode.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                    survivalCode.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                    survivalCode.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                    survivalCode.parryRegen = ""; //Recover Health when successfully Guard Impact
                    survivalCode.guardBreakRate = ""; //Increase Guard Break Chance
                    survivalCode.throwEscapeChance = ""; //Increase Throw Escape Rate
                    survivalCode.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                    survivalCode.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                    survivalCode.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "";
                    survivalCode.stageNumber = 13;
                    survivalCode.model = "0F";
                    survivalCode.costume = "01";
                    survivalCode.fightingStyle = "0F";
                    survivalCode.weaponNumber = "06"; //Yoshimitsu

                    survivalCode.aiLevel = "00"; // 0-5
                    survivalCode.weaponSpecial = ""; //Fire, Thunder etc
                    survivalCode.guardianForce = ""; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                    survivalCode.stickyFeet = ""; //Slippery Feets
                    survivalCode.speed = "3F80"; //3F80 default speed

                    survivalCode.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                    survivalCode.attack = ""; //Decrease/Increase Attack
                    survivalCode.defense = ""; //Decrease/Increase Defense
                    survivalCode.stealHp = ""; //Steal health from enemy
                    survivalCode.pierceDamage = ""; //Damage inflicted thru guard
                    survivalCode.weaponSize = "";
                    survivalCode.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                    survivalCode.counterRate = ""; //Increase Counter Chance
                    survivalCode.nullCounter = ""; //Nullify Enemies Counters chance
                    survivalCode.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                    survivalCode.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                    survivalCode.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                    survivalCode.parryRegen = ""; //Recover Health when successfully Guard Impact
                    survivalCode.guardBreakRate = ""; //Increase Guard Break Chance
                    survivalCode.throwEscapeChance = ""; //Increase Throw Escape Rate
                    survivalCode.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                    survivalCode.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                    survivalCode.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "";
                    survivalCode.stageNumber = 14;
                    survivalCode.model = "08";
                    survivalCode.costume = "01";
                    survivalCode.fightingStyle = "08";
                    survivalCode.weaponNumber = "06"; //Rock

                    survivalCode.aiLevel = "00"; // 0-5
                    survivalCode.weaponSpecial = ""; //Fire, Thunder etc
                    survivalCode.guardianForce = ""; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                    survivalCode.stickyFeet = ""; //Slippery Feets
                    survivalCode.speed = "3F80"; //3F80 default speed

                    survivalCode.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                    survivalCode.attack = ""; //Decrease/Increase Attack
                    survivalCode.defense = ""; //Decrease/Increase Defense
                    survivalCode.stealHp = ""; //Steal health from enemy
                    survivalCode.pierceDamage = ""; //Damage inflicted thru guard
                    survivalCode.weaponSize = "";
                    survivalCode.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                    survivalCode.counterRate = ""; //Increase Counter Chance
                    survivalCode.nullCounter = ""; //Nullify Enemies Counters chance
                    survivalCode.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                    survivalCode.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                    survivalCode.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                    survivalCode.parryRegen = ""; //Recover Health when successfully Guard Impact
                    survivalCode.guardBreakRate = ""; //Increase Guard Break Chance
                    survivalCode.throwEscapeChance = ""; //Increase Throw Escape Rate
                    survivalCode.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                    survivalCode.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                    survivalCode.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "";
                    survivalCode.stageNumber = 15;
                    survivalCode.model = "11";
                    survivalCode.costume = "01";
                    survivalCode.fightingStyle = "11";
                    survivalCode.weaponNumber = "06"; //Nightmare

                    survivalCode.aiLevel = "00"; // 0-5
                    survivalCode.weaponSpecial = ""; //Fire, Thunder etc
                    survivalCode.guardianForce = ""; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                    survivalCode.stickyFeet = ""; //Slippery Feets
                    survivalCode.speed = "3F80"; //3F80 default speed

                    survivalCode.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                    survivalCode.attack = ""; //Decrease/Increase Attack
                    survivalCode.defense = ""; //Decrease/Increase Defense
                    survivalCode.stealHp = ""; //Steal health from enemy
                    survivalCode.pierceDamage = ""; //Damage inflicted thru guard
                    survivalCode.weaponSize = "";
                    survivalCode.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                    survivalCode.counterRate = ""; //Increase Counter Chance
                    survivalCode.nullCounter = ""; //Nullify Enemies Counters chance
                    survivalCode.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                    survivalCode.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                    survivalCode.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                    survivalCode.parryRegen = ""; //Recover Health when successfully Guard Impact
                    survivalCode.guardBreakRate = ""; //Increase Guard Break Chance
                    survivalCode.throwEscapeChance = ""; //Increase Throw Escape Rate
                    survivalCode.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                    survivalCode.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                    survivalCode.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "0010";
                    survivalCode.stageMusic = "10";
                    survivalCode.stageNumber = 16;
                    survivalCode.model = "16";
                    survivalCode.costume = "01";
                    survivalCode.fightingStyle = "16";
                    survivalCode.weaponNumber = "06"; //Talim

                    survivalCode.aiLevel = "00"; // 0-5
                    survivalCode.weaponSpecial = ""; //Fire, Thunder etc
                    survivalCode.guardianForce = ""; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                    survivalCode.stickyFeet = ""; //Slippery Feets
                    survivalCode.speed = "3F80"; //3F80 default speed

                    survivalCode.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                    survivalCode.attack = ""; //Decrease/Increase Attack
                    survivalCode.defense = ""; //Decrease/Increase Defense
                    survivalCode.stealHp = ""; //Steal health from enemy
                    survivalCode.pierceDamage = ""; //Damage inflicted thru guard
                    survivalCode.weaponSize = "";
                    survivalCode.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                    survivalCode.counterRate = ""; //Increase Counter Chance
                    survivalCode.nullCounter = ""; //Nullify Enemies Counters chance
                    survivalCode.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                    survivalCode.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                    survivalCode.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                    survivalCode.parryRegen = ""; //Recover Health when successfully Guard Impact
                    survivalCode.guardBreakRate = ""; //Increase Guard Break Chance
                    survivalCode.throwEscapeChance = ""; //Increase Throw Escape Rate
                    survivalCode.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                    survivalCode.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                    survivalCode.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "";
                    survivalCode.stageNumber = 17;
                    survivalCode.model = "35";
                    survivalCode.costume = "00";
                    survivalCode.fightingStyle = "24";
                    survivalCode.weaponNumber = "06"; //Zasalamel

                    survivalCode.aiLevel = "00"; // 0-5
                    survivalCode.weaponSpecial = ""; //Fire, Thunder etc
                    survivalCode.guardianForce = ""; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                    survivalCode.stickyFeet = ""; //Slippery Feets
                    survivalCode.speed = "3F80"; //3F80 default speed

                    survivalCode.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                    survivalCode.attack = ""; //Decrease/Increase Attack
                    survivalCode.defense = ""; //Decrease/Increase Defense
                    survivalCode.stealHp = ""; //Steal health from enemy
                    survivalCode.pierceDamage = ""; //Damage inflicted thru guard
                    survivalCode.weaponSize = "";
                    survivalCode.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                    survivalCode.counterRate = ""; //Increase Counter Chance
                    survivalCode.nullCounter = ""; //Nullify Enemies Counters chance
                    survivalCode.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                    survivalCode.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                    survivalCode.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                    survivalCode.parryRegen = ""; //Recover Health when successfully Guard Impact
                    survivalCode.guardBreakRate = ""; //Increase Guard Break Chance
                    survivalCode.throwEscapeChance = ""; //Increase Throw Escape Rate
                    survivalCode.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                    survivalCode.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                    survivalCode.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "";
                    survivalCode.stageNumber = 18;
                    survivalCode.model = "25";
                    survivalCode.costume = "01";
                    survivalCode.fightingStyle = "25";
                    survivalCode.weaponNumber = "06"; //Olcadan

                    survivalCode.aiLevel = "00"; // 0-5
                    survivalCode.weaponSpecial = ""; //Fire, Thunder etc
                    survivalCode.guardianForce = ""; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                    survivalCode.stickyFeet = ""; //Slippery Feets
                    survivalCode.speed = "3F80"; //3F80 default speed

                    survivalCode.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                    survivalCode.attack = ""; //Decrease/Increase Attack
                    survivalCode.defense = ""; //Decrease/Increase Defense
                    survivalCode.stealHp = ""; //Steal health from enemy
                    survivalCode.pierceDamage = ""; //Damage inflicted thru guard
                    survivalCode.weaponSize = "";
                    survivalCode.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                    survivalCode.counterRate = ""; //Increase Counter Chance
                    survivalCode.nullCounter = ""; //Nullify Enemies Counters chance
                    survivalCode.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                    survivalCode.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                    survivalCode.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                    survivalCode.parryRegen = ""; //Recover Health when successfully Guard Impact
                    survivalCode.guardBreakRate = ""; //Increase Guard Break Chance
                    survivalCode.throwEscapeChance = ""; //Increase Throw Escape Rate
                    survivalCode.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                    survivalCode.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                    survivalCode.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "";
                    survivalCode.stageNumber = 19;
                    survivalCode.model = "07";
                    survivalCode.costume = "01";
                    survivalCode.fightingStyle = "07";
                    survivalCode.weaponNumber = "06"; //Siegfried

                    survivalCode.aiLevel = "00"; // 0-5
                    survivalCode.weaponSpecial = ""; //Fire, Thunder etc
                    survivalCode.guardianForce = ""; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                    survivalCode.stickyFeet = ""; //Slippery Feets
                    survivalCode.speed = "3F80"; //3F80 default speed

                    survivalCode.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                    survivalCode.attack = ""; //Decrease/Increase Attack
                    survivalCode.defense = ""; //Decrease/Increase Defense
                    survivalCode.stealHp = ""; //Steal health from enemy
                    survivalCode.pierceDamage = ""; //Damage inflicted thru guard
                    survivalCode.weaponSize = "";
                    survivalCode.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                    survivalCode.counterRate = ""; //Increase Counter Chance
                    survivalCode.nullCounter = ""; //Nullify Enemies Counters chance
                    survivalCode.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                    survivalCode.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                    survivalCode.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                    survivalCode.parryRegen = ""; //Recover Health when successfully Guard Impact
                    survivalCode.guardBreakRate = ""; //Increase Guard Break Chance
                    survivalCode.throwEscapeChance = ""; //Increase Throw Escape Rate
                    survivalCode.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                    survivalCode.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                    survivalCode.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "";
                    survivalCode.stageNumber = 20;
                    survivalCode.model = "93";
                    survivalCode.costume = "00";
                    survivalCode.fightingStyle = "42";
                    survivalCode.weaponNumber = "03"; //Assassin

                    survivalCode.aiLevel = "00"; // 0-5
                    survivalCode.weaponSpecial = ""; //Fire, Thunder etc
                    survivalCode.guardianForce = ""; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                    survivalCode.stickyFeet = ""; //Slippery Feets
                    survivalCode.speed = "3F80"; //3F80 default speed

                    survivalCode.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                    survivalCode.attack = ""; //Decrease/Increase Attack
                    survivalCode.defense = ""; //Decrease/Increase Defense
                    survivalCode.stealHp = ""; //Steal health from enemy
                    survivalCode.pierceDamage = ""; //Damage inflicted thru guard
                    survivalCode.weaponSize = "";
                    survivalCode.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                    survivalCode.counterRate = ""; //Increase Counter Chance
                    survivalCode.nullCounter = ""; //Nullify Enemies Counters chance
                    survivalCode.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                    survivalCode.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                    survivalCode.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                    survivalCode.parryRegen = ""; //Recover Health when successfully Guard Impact
                    survivalCode.guardBreakRate = ""; //Increase Guard Break Chance
                    survivalCode.throwEscapeChance = ""; //Increase Throw Escape Rate
                    survivalCode.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                    survivalCode.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                    survivalCode.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                    break;
                #endregion

                #region Amateur Arc  [Dragon]
                case "Amateur Arc":
                    survivalCode.stageLevel = "0011";
                    survivalCode.stageMusic = "11";
                    survivalCode.stageNumber = 1;
                    survivalCode.model = "BF";
                    survivalCode.costume = "01";
                    survivalCode.fightingStyle = "54";
                    survivalCode.weaponNumber = "00"; //Riese

                    survivalCode.aiLevel = "00"; // 00-05
                    survivalCode.weaponSpecial = ""; //Fire, Thunder etc
                    survivalCode.guardianForce = ""; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                    survivalCode.stickyFeet = ""; //Slippery Feets
                    survivalCode.speed = "3F80"; //3F80 default speed

                    survivalCode.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                    survivalCode.attack = ""; //Decrease/Increase Attack
                    survivalCode.defense = ""; //Decrease/Increase Defense
                    survivalCode.stealHp = ""; //Steal health from enemy
                    survivalCode.pierceDamage = ""; //Damage inflicted thru guard
                    survivalCode.weaponSize = "";
                    survivalCode.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                    survivalCode.counterRate = ""; //Increase Counter Chance
                    survivalCode.nullCounter = ""; //Nullify Enemies Counters chance
                    survivalCode.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                    survivalCode.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                    survivalCode.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                    survivalCode.parryRegen = ""; //Recover Health when successfully Guard Impact
                    survivalCode.guardBreakRate = ""; //Increase Guard Break Chance
                    survivalCode.throwEscapeChance = ""; //Increase Throw Escape Rate
                    survivalCode.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                    survivalCode.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                    survivalCode.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "";
                    survivalCode.stageNumber = 2;
                    survivalCode.model = "C1";
                    survivalCode.costume = "01";
                    survivalCode.fightingStyle = "30";
                    survivalCode.weaponNumber = "00"; //Eris

                    survivalCode.aiLevel = "00"; // 00-05
                    survivalCode.weaponSpecial = ""; //Fire, Thunder etc
                    survivalCode.guardianForce = ""; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                    survivalCode.stickyFeet = ""; //Slippery Feets
                    survivalCode.speed = "3F80"; //3F80 default speed

                    survivalCode.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                    survivalCode.attack = ""; //Decrease/Increase Attack
                    survivalCode.defense = ""; //Decrease/Increase Defense
                    survivalCode.stealHp = ""; //Steal health from enemy
                    survivalCode.pierceDamage = ""; //Damage inflicted thru guard
                    survivalCode.weaponSize = "";
                    survivalCode.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                    survivalCode.counterRate = ""; //Increase Counter Chance
                    survivalCode.nullCounter = ""; //Nullify Enemies Counters chance
                    survivalCode.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                    survivalCode.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                    survivalCode.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                    survivalCode.parryRegen = ""; //Recover Health when successfully Guard Impact
                    survivalCode.guardBreakRate = ""; //Increase Guard Break Chance
                    survivalCode.throwEscapeChance = ""; //Increase Throw Escape Rate
                    survivalCode.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                    survivalCode.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                    survivalCode.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "";
                    survivalCode.stageNumber = 3;
                    survivalCode.model = "95";
                    survivalCode.costume = "00";
                    survivalCode.fightingStyle = "4E";
                    survivalCode.weaponNumber = "00"; //FootSoldier

                    survivalCode.aiLevel = "00"; // 00-05
                    survivalCode.weaponSpecial = ""; //Fire, Thunder etc
                    survivalCode.guardianForce = ""; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                    survivalCode.stickyFeet = ""; //Slippery Feets
                    survivalCode.speed = "3F80"; //3F80 default speed

                    survivalCode.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                    survivalCode.attack = ""; //Decrease/Increase Attack
                    survivalCode.defense = ""; //Decrease/Increase Defense
                    survivalCode.stealHp = ""; //Steal health from enemy
                    survivalCode.pierceDamage = ""; //Damage inflicted thru guard
                    survivalCode.weaponSize = "";
                    survivalCode.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                    survivalCode.counterRate = ""; //Increase Counter Chance
                    survivalCode.nullCounter = ""; //Nullify Enemies Counters chance
                    survivalCode.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                    survivalCode.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                    survivalCode.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                    survivalCode.parryRegen = ""; //Recover Health when successfully Guard Impact
                    survivalCode.guardBreakRate = ""; //Increase Guard Break Chance
                    survivalCode.throwEscapeChance = ""; //Increase Throw Escape Rate
                    survivalCode.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                    survivalCode.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                    survivalCode.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "";
                    survivalCode.stageNumber = 4;
                    survivalCode.model = "90";
                    survivalCode.costume = "00";
                    survivalCode.fightingStyle = "4C";
                    survivalCode.weaponNumber = "00"; //Thief 2

                    survivalCode.aiLevel = "00"; // 00-05
                    survivalCode.weaponSpecial = ""; //Fire, Thunder etc
                    survivalCode.guardianForce = ""; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                    survivalCode.stickyFeet = ""; //Slippery Feets
                    survivalCode.speed = "3F80"; //3F80 default speed

                    survivalCode.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                    survivalCode.attack = ""; //Decrease/Increase Attack
                    survivalCode.defense = ""; //Decrease/Increase Defense
                    survivalCode.stealHp = ""; //Steal health from enemy
                    survivalCode.pierceDamage = ""; //Damage inflicted thru guard
                    survivalCode.weaponSize = "";
                    survivalCode.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                    survivalCode.counterRate = ""; //Increase Counter Chance
                    survivalCode.nullCounter = ""; //Nullify Enemies Counters chance
                    survivalCode.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                    survivalCode.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                    survivalCode.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                    survivalCode.parryRegen = ""; //Recover Health when successfully Guard Impact
                    survivalCode.guardBreakRate = ""; //Increase Guard Break Chance
                    survivalCode.throwEscapeChance = ""; //Increase Throw Escape Rate
                    survivalCode.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                    survivalCode.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                    survivalCode.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "";
                    survivalCode.stageNumber = 5;
                    survivalCode.model = "AF";
                    survivalCode.costume = "02";
                    survivalCode.fightingStyle = "48";
                    survivalCode.weaponNumber = "00"; //Brunhild

                    survivalCode.aiLevel = "00"; // 00-05
                    survivalCode.weaponSpecial = ""; //Fire, Thunder etc
                    survivalCode.guardianForce = ""; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                    survivalCode.stickyFeet = ""; //Slippery Feets
                    survivalCode.speed = "3F80"; //3F80 default speed

                    survivalCode.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                    survivalCode.attack = ""; //Decrease/Increase Attack
                    survivalCode.defense = ""; //Decrease/Increase Defense
                    survivalCode.stealHp = ""; //Steal health from enemy
                    survivalCode.pierceDamage = ""; //Damage inflicted thru guard
                    survivalCode.weaponSize = "";
                    survivalCode.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                    survivalCode.counterRate = ""; //Increase Counter Chance
                    survivalCode.nullCounter = ""; //Nullify Enemies Counters chance
                    survivalCode.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                    survivalCode.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                    survivalCode.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                    survivalCode.parryRegen = ""; //Recover Health when successfully Guard Impact
                    survivalCode.guardBreakRate = ""; //Increase Guard Break Chance
                    survivalCode.throwEscapeChance = ""; //Increase Throw Escape Rate
                    survivalCode.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                    survivalCode.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                    survivalCode.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "000B";
                    survivalCode.stageMusic = "0B";
                    survivalCode.stageNumber = 6;
                    survivalCode.model = "ED";
                    survivalCode.costume = "00";
                    survivalCode.fightingStyle = "4E";
                    survivalCode.weaponNumber = "00"; //Hyle

                    survivalCode.aiLevel = "01"; // 00-05
                    survivalCode.weaponSpecial = ""; //Fire, Thunder etc
                    survivalCode.guardianForce = ""; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                    survivalCode.stickyFeet = ""; //Slippery Feets
                    survivalCode.speed = "3F80"; //3F80 default speed

                    survivalCode.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                    survivalCode.attack = ""; //Decrease/Increase Attack
                    survivalCode.defense = ""; //Decrease/Increase Defense
                    survivalCode.stealHp = ""; //Steal health from enemy
                    survivalCode.pierceDamage = ""; //Damage inflicted thru guard
                    survivalCode.weaponSize = "";
                    survivalCode.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                    survivalCode.counterRate = ""; //Increase Counter Chance
                    survivalCode.nullCounter = ""; //Nullify Enemies Counters chance
                    survivalCode.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                    survivalCode.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                    survivalCode.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                    survivalCode.parryRegen = ""; //Recover Health when successfully Guard Impact
                    survivalCode.guardBreakRate = ""; //Increase Guard Break Chance
                    survivalCode.throwEscapeChance = ""; //Increase Throw Escape Rate
                    survivalCode.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                    survivalCode.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                    survivalCode.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "";
                    survivalCode.stageNumber = 7;
                    survivalCode.model = "E4";
                    survivalCode.costume = "00";
                    survivalCode.fightingStyle = "4C";
                    survivalCode.weaponNumber = "00"; //Chester

                    survivalCode.aiLevel = "01"; // 00-05
                    survivalCode.weaponSpecial = ""; //Fire, Thunder etc
                    survivalCode.guardianForce = ""; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                    survivalCode.stickyFeet = ""; //Slippery Feets
                    survivalCode.speed = "3F80"; //3F80 default speed

                    survivalCode.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                    survivalCode.attack = ""; //Decrease/Increase Attack
                    survivalCode.defense = ""; //Decrease/Increase Defense
                    survivalCode.stealHp = ""; //Steal health from enemy
                    survivalCode.pierceDamage = ""; //Damage inflicted thru guard
                    survivalCode.weaponSize = "";
                    survivalCode.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                    survivalCode.counterRate = ""; //Increase Counter Chance
                    survivalCode.nullCounter = ""; //Nullify Enemies Counters chance
                    survivalCode.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                    survivalCode.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                    survivalCode.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                    survivalCode.parryRegen = ""; //Recover Health when successfully Guard Impact
                    survivalCode.guardBreakRate = ""; //Increase Guard Break Chance
                    survivalCode.throwEscapeChance = ""; //Increase Throw Escape Rate
                    survivalCode.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                    survivalCode.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                    survivalCode.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "";
                    survivalCode.stageNumber = 8;
                    survivalCode.model = "46";
                    survivalCode.costume = "01";
                    survivalCode.fightingStyle = "46";
                    survivalCode.weaponNumber = "00"; //Valeria

                    survivalCode.aiLevel = "01"; // 00-05
                    survivalCode.weaponSpecial = ""; //Fire, Thunder etc
                    survivalCode.guardianForce = ""; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                    survivalCode.stickyFeet = ""; //Slippery Feets
                    survivalCode.speed = "3F80"; //3F80 default speed

                    survivalCode.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                    survivalCode.attack = ""; //Decrease/Increase Attack
                    survivalCode.defense = ""; //Decrease/Increase Defense
                    survivalCode.stealHp = ""; //Steal health from enemy
                    survivalCode.pierceDamage = ""; //Damage inflicted thru guard
                    survivalCode.weaponSize = "";
                    survivalCode.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                    survivalCode.counterRate = ""; //Increase Counter Chance
                    survivalCode.nullCounter = ""; //Nullify Enemies Counters chance
                    survivalCode.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                    survivalCode.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                    survivalCode.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                    survivalCode.parryRegen = ""; //Recover Health when successfully Guard Impact
                    survivalCode.guardBreakRate = ""; //Increase Guard Break Chance
                    survivalCode.throwEscapeChance = ""; //Increase Throw Escape Rate
                    survivalCode.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                    survivalCode.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                    survivalCode.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "";
                    survivalCode.stageNumber = 9;
                    survivalCode.model = "8A";
                    survivalCode.costume = "00";
                    survivalCode.fightingStyle = "42";
                    survivalCode.weaponNumber = "00"; //Fu-ma Ninja 1

                    survivalCode.aiLevel = "01"; // 00-05
                    survivalCode.weaponSpecial = ""; //Fire, Thunder etc
                    survivalCode.guardianForce = ""; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                    survivalCode.stickyFeet = ""; //Slippery Feets
                    survivalCode.speed = "3F80"; //3F80 default speed

                    survivalCode.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                    survivalCode.attack = ""; //Decrease/Increase Attack
                    survivalCode.defense = ""; //Decrease/Increase Defense
                    survivalCode.stealHp = ""; //Steal health from enemy
                    survivalCode.pierceDamage = ""; //Damage inflicted thru guard
                    survivalCode.weaponSize = "";
                    survivalCode.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                    survivalCode.counterRate = ""; //Increase Counter Chance
                    survivalCode.nullCounter = ""; //Nullify Enemies Counters chance
                    survivalCode.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                    survivalCode.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                    survivalCode.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                    survivalCode.parryRegen = ""; //Recover Health when successfully Guard Impact
                    survivalCode.guardBreakRate = ""; //Increase Guard Break Chance
                    survivalCode.throwEscapeChance = ""; //Increase Throw Escape Rate
                    survivalCode.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                    survivalCode.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                    survivalCode.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "";
                    survivalCode.stageNumber = 10;
                    survivalCode.model = "A0";
                    survivalCode.costume = "00";
                    survivalCode.fightingStyle = "41";
                    survivalCode.weaponNumber = "00"; //Jinkai

                    survivalCode.aiLevel = "01"; // 00-05
                    survivalCode.weaponSpecial = ""; //Fire, Thunder etc
                    survivalCode.guardianForce = ""; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                    survivalCode.stickyFeet = ""; //Slippery Feets
                    survivalCode.speed = "3F80"; //3F80 default speed

                    survivalCode.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                    survivalCode.attack = ""; //Decrease/Increase Attack
                    survivalCode.defense = ""; //Decrease/Increase Defense
                    survivalCode.stealHp = ""; //Steal health from enemy
                    survivalCode.pierceDamage = ""; //Damage inflicted thru guard
                    survivalCode.weaponSize = "";
                    survivalCode.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                    survivalCode.counterRate = ""; //Increase Counter Chance
                    survivalCode.nullCounter = ""; //Nullify Enemies Counters chance
                    survivalCode.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                    survivalCode.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                    survivalCode.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                    survivalCode.parryRegen = ""; //Recover Health when successfully Guard Impact
                    survivalCode.guardBreakRate = ""; //Increase Guard Break Chance
                    survivalCode.throwEscapeChance = ""; //Increase Throw Escape Rate
                    survivalCode.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                    survivalCode.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                    survivalCode.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "0018";
                    survivalCode.stageMusic = "18";
                    survivalCode.stageNumber = 11;
                    survivalCode.model = "22";
                    survivalCode.costume = "01";
                    survivalCode.fightingStyle = "22";
                    survivalCode.weaponNumber = "00"; //Setsuka

                    survivalCode.aiLevel = "01"; // 00-05
                    survivalCode.weaponSpecial = ""; //Fire, Thunder etc
                    survivalCode.guardianForce = ""; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                    survivalCode.stickyFeet = ""; //Slippery Feets
                    survivalCode.speed = "3F80"; //3F80 default speed

                    survivalCode.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                    survivalCode.attack = ""; //Decrease/Increase Attack
                    survivalCode.defense = ""; //Decrease/Increase Defense
                    survivalCode.stealHp = ""; //Steal health from enemy
                    survivalCode.pierceDamage = ""; //Damage inflicted thru guard
                    survivalCode.weaponSize = "";
                    survivalCode.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                    survivalCode.counterRate = ""; //Increase Counter Chance
                    survivalCode.nullCounter = ""; //Nullify Enemies Counters chance
                    survivalCode.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                    survivalCode.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                    survivalCode.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                    survivalCode.parryRegen = ""; //Recover Health when successfully Guard Impact
                    survivalCode.guardBreakRate = ""; //Increase Guard Break Chance
                    survivalCode.throwEscapeChance = ""; //Increase Throw Escape Rate
                    survivalCode.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                    survivalCode.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                    survivalCode.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "";
                    survivalCode.stageNumber = 12;
                    survivalCode.model = "04";
                    survivalCode.costume = "01";
                    survivalCode.fightingStyle = "04";
                    survivalCode.weaponNumber = "00"; //Maxi

                    survivalCode.aiLevel = "01"; // 00-05
                    survivalCode.weaponSpecial = ""; //Fire, Thunder etc
                    survivalCode.guardianForce = ""; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                    survivalCode.stickyFeet = ""; //Slippery Feets
                    survivalCode.speed = "3F80"; //3F80 default speed

                    survivalCode.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                    survivalCode.attack = ""; //Decrease/Increase Attack
                    survivalCode.defense = ""; //Decrease/Increase Defense
                    survivalCode.stealHp = ""; //Steal health from enemy
                    survivalCode.pierceDamage = ""; //Damage inflicted thru guard
                    survivalCode.weaponSize = "";
                    survivalCode.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                    survivalCode.counterRate = ""; //Increase Counter Chance
                    survivalCode.nullCounter = ""; //Nullify Enemies Counters chance
                    survivalCode.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                    survivalCode.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                    survivalCode.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                    survivalCode.parryRegen = ""; //Recover Health when successfully Guard Impact
                    survivalCode.guardBreakRate = ""; //Increase Guard Break Chance
                    survivalCode.throwEscapeChance = ""; //Increase Throw Escape Rate
                    survivalCode.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                    survivalCode.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                    survivalCode.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "";
                    survivalCode.stageNumber = 13;
                    survivalCode.model = "36";
                    survivalCode.costume = "00";
                    survivalCode.fightingStyle = "0E";
                    survivalCode.weaponNumber = "00"; //Lizardman

                    survivalCode.aiLevel = "01"; // 00-05
                    survivalCode.weaponSpecial = ""; //Fire, Thunder etc
                    survivalCode.guardianForce = ""; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                    survivalCode.stickyFeet = ""; //Slippery Feets
                    survivalCode.speed = "3F80"; //3F80 default speed

                    survivalCode.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                    survivalCode.attack = ""; //Decrease/Increase Attack
                    survivalCode.defense = ""; //Decrease/Increase Defense
                    survivalCode.stealHp = ""; //Steal health from enemy
                    survivalCode.pierceDamage = ""; //Damage inflicted thru guard
                    survivalCode.weaponSize = "";
                    survivalCode.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                    survivalCode.counterRate = ""; //Increase Counter Chance
                    survivalCode.nullCounter = ""; //Nullify Enemies Counters chance
                    survivalCode.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                    survivalCode.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                    survivalCode.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                    survivalCode.parryRegen = ""; //Recover Health when successfully Guard Impact
                    survivalCode.guardBreakRate = ""; //Increase Guard Break Chance
                    survivalCode.throwEscapeChance = ""; //Increase Throw Escape Rate
                    survivalCode.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                    survivalCode.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                    survivalCode.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "";
                    survivalCode.stageNumber = 14;
                    survivalCode.model = "84";
                    survivalCode.costume = "00";
                    survivalCode.fightingStyle = "43";
                    survivalCode.weaponNumber = "00"; //Samurai 1

                    survivalCode.aiLevel = "01"; // 00-05
                    survivalCode.weaponSpecial = ""; //Fire, Thunder etc
                    survivalCode.guardianForce = ""; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                    survivalCode.stickyFeet = ""; //Slippery Feets
                    survivalCode.speed = "3F80"; //3F80 default speed

                    survivalCode.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                    survivalCode.attack = ""; //Decrease/Increase Attack
                    survivalCode.defense = ""; //Decrease/Increase Defense
                    survivalCode.stealHp = ""; //Steal health from enemy
                    survivalCode.pierceDamage = ""; //Damage inflicted thru guard
                    survivalCode.weaponSize = "";
                    survivalCode.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                    survivalCode.counterRate = ""; //Increase Counter Chance
                    survivalCode.nullCounter = ""; //Nullify Enemies Counters chance
                    survivalCode.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                    survivalCode.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                    survivalCode.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                    survivalCode.parryRegen = ""; //Recover Health when successfully Guard Impact
                    survivalCode.guardBreakRate = ""; //Increase Guard Break Chance
                    survivalCode.throwEscapeChance = ""; //Increase Throw Escape Rate
                    survivalCode.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                    survivalCode.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                    survivalCode.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "";
                    survivalCode.stageNumber = 15;
                    survivalCode.model = "B7";
                    survivalCode.costume = "01";
                    survivalCode.fightingStyle = "4D";
                    survivalCode.weaponNumber = "00"; //Eurydice

                    survivalCode.aiLevel = "01"; // 00-05
                    survivalCode.weaponSpecial = ""; //Fire, Thunder etc
                    survivalCode.guardianForce = ""; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                    survivalCode.stickyFeet = ""; //Slippery Feets
                    survivalCode.speed = "3F80"; //3F80 default speed

                    survivalCode.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                    survivalCode.attack = ""; //Decrease/Increase Attack
                    survivalCode.defense = ""; //Decrease/Increase Defense
                    survivalCode.stealHp = ""; //Steal health from enemy
                    survivalCode.pierceDamage = ""; //Damage inflicted thru guard
                    survivalCode.weaponSize = "";
                    survivalCode.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                    survivalCode.counterRate = ""; //Increase Counter Chance
                    survivalCode.nullCounter = ""; //Nullify Enemies Counters chance
                    survivalCode.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                    survivalCode.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                    survivalCode.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                    survivalCode.parryRegen = ""; //Recover Health when successfully Guard Impact
                    survivalCode.guardBreakRate = ""; //Increase Guard Break Chance
                    survivalCode.throwEscapeChance = ""; //Increase Throw Escape Rate
                    survivalCode.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                    survivalCode.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                    survivalCode.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "000A";
                    survivalCode.stageMusic = "0A";
                    survivalCode.stageNumber = 16;
                    survivalCode.model = "01";
                    survivalCode.costume = "01";
                    survivalCode.fightingStyle = "01";
                    survivalCode.weaponNumber = "00"; //Mitsurugi

                    survivalCode.aiLevel = "01"; // 00-05
                    survivalCode.weaponSpecial = ""; //Fire, Thunder etc
                    survivalCode.guardianForce = ""; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                    survivalCode.stickyFeet = ""; //Slippery Feets
                    survivalCode.speed = "3F80"; //3F80 default speed

                    survivalCode.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                    survivalCode.attack = ""; //Decrease/Increase Attack
                    survivalCode.defense = ""; //Decrease/Increase Defense
                    survivalCode.stealHp = ""; //Steal health from enemy
                    survivalCode.pierceDamage = ""; //Damage inflicted thru guard
                    survivalCode.weaponSize = "";
                    survivalCode.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                    survivalCode.counterRate = ""; //Increase Counter Chance
                    survivalCode.nullCounter = ""; //Nullify Enemies Counters chance
                    survivalCode.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                    survivalCode.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                    survivalCode.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                    survivalCode.parryRegen = ""; //Recover Health when successfully Guard Impact
                    survivalCode.guardBreakRate = ""; //Increase Guard Break Chance
                    survivalCode.throwEscapeChance = ""; //Increase Throw Escape Rate
                    survivalCode.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                    survivalCode.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                    survivalCode.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "";
                    survivalCode.stageNumber = 17;
                    survivalCode.model = "06";
                    survivalCode.costume = "01";
                    survivalCode.fightingStyle = "06";
                    survivalCode.weaponNumber = "00"; //Sophitia

                    survivalCode.aiLevel = "01"; // 00-05
                    survivalCode.weaponSpecial = ""; //Fire, Thunder etc
                    survivalCode.guardianForce = ""; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                    survivalCode.stickyFeet = ""; //Slippery Feets
                    survivalCode.speed = "3F80"; //3F80 default speed

                    survivalCode.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                    survivalCode.attack = ""; //Decrease/Increase Attack
                    survivalCode.defense = ""; //Decrease/Increase Defense
                    survivalCode.stealHp = ""; //Steal health from enemy
                    survivalCode.pierceDamage = ""; //Damage inflicted thru guard
                    survivalCode.weaponSize = "";
                    survivalCode.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                    survivalCode.counterRate = ""; //Increase Counter Chance
                    survivalCode.nullCounter = ""; //Nullify Enemies Counters chance
                    survivalCode.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                    survivalCode.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                    survivalCode.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                    survivalCode.parryRegen = ""; //Recover Health when successfully Guard Impact
                    survivalCode.guardBreakRate = ""; //Increase Guard Break Chance
                    survivalCode.throwEscapeChance = ""; //Increase Throw Escape Rate
                    survivalCode.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                    survivalCode.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                    survivalCode.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "";
                    survivalCode.stageNumber = 18;
                    survivalCode.model = "89";
                    survivalCode.costume = "00";
                    survivalCode.fightingStyle = "43";
                    survivalCode.weaponNumber = "00"; //Unknown Soul

                    survivalCode.aiLevel = "01"; // 00-05
                    survivalCode.weaponSpecial = ""; //Fire, Thunder etc
                    survivalCode.guardianForce = ""; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                    survivalCode.stickyFeet = ""; //Slippery Feets
                    survivalCode.speed = "3F80"; //3F80 default speed

                    survivalCode.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                    survivalCode.attack = ""; //Decrease/Increase Attack
                    survivalCode.defense = ""; //Decrease/Increase Defense
                    survivalCode.stealHp = ""; //Steal health from enemy
                    survivalCode.pierceDamage = ""; //Damage inflicted thru guard
                    survivalCode.weaponSize = "";
                    survivalCode.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                    survivalCode.counterRate = ""; //Increase Counter Chance
                    survivalCode.nullCounter = ""; //Nullify Enemies Counters chance
                    survivalCode.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                    survivalCode.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                    survivalCode.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                    survivalCode.parryRegen = ""; //Recover Health when successfully Guard Impact
                    survivalCode.guardBreakRate = ""; //Increase Guard Break Chance
                    survivalCode.throwEscapeChance = ""; //Increase Throw Escape Rate
                    survivalCode.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                    survivalCode.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                    survivalCode.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "";
                    survivalCode.stageNumber = 19;
                    survivalCode.model = "14";
                    survivalCode.costume = "01";
                    survivalCode.fightingStyle = "14";
                    survivalCode.weaponNumber = "00"; //Cervantes

                    survivalCode.aiLevel = "01"; // 00-05
                    survivalCode.weaponSpecial = ""; //Fire, Thunder etc
                    survivalCode.guardianForce = ""; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                    survivalCode.stickyFeet = ""; //Slippery Feets
                    survivalCode.speed = "3F80"; //3F80 default speed

                    survivalCode.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                    survivalCode.attack = ""; //Decrease/Increase Attack
                    survivalCode.defense = ""; //Decrease/Increase Defense
                    survivalCode.stealHp = ""; //Steal health from enemy
                    survivalCode.pierceDamage = ""; //Damage inflicted thru guard
                    survivalCode.weaponSize = "";
                    survivalCode.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                    survivalCode.counterRate = ""; //Increase Counter Chance
                    survivalCode.nullCounter = ""; //Nullify Enemies Counters chance
                    survivalCode.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                    survivalCode.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                    survivalCode.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                    survivalCode.parryRegen = ""; //Recover Health when successfully Guard Impact
                    survivalCode.guardBreakRate = ""; //Increase Guard Break Chance
                    survivalCode.throwEscapeChance = ""; //Increase Throw Escape Rate
                    survivalCode.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                    survivalCode.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                    survivalCode.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "";
                    survivalCode.stageNumber = 20;
                    survivalCode.model = "99";
                    survivalCode.costume = "00";
                    survivalCode.fightingStyle = "44";
                    survivalCode.weaponNumber = "06"; //Dragon

                    survivalCode.aiLevel = "01"; // 00-05
                    survivalCode.weaponSpecial = ""; //Fire, Thunder etc
                    survivalCode.guardianForce = ""; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                    survivalCode.stickyFeet = ""; //Slippery Feets
                    survivalCode.speed = "3F80"; //3F80 default speed

                    survivalCode.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                    survivalCode.attack = "3FA00000"; //Decrease/Increase Attack
                    survivalCode.defense = ""; //Decrease/Increase Defense
                    survivalCode.stealHp = ""; //Steal health from enemy
                    survivalCode.pierceDamage = ""; //Damage inflicted thru guard
                    survivalCode.weaponSize = "";
                    survivalCode.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                    survivalCode.counterRate = ""; //Increase Counter Chance
                    survivalCode.nullCounter = ""; //Nullify Enemies Counters chance
                    survivalCode.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                    survivalCode.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                    survivalCode.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                    survivalCode.parryRegen = ""; //Recover Health when successfully Guard Impact
                    survivalCode.guardBreakRate = ""; //Increase Guard Break Chance
                    survivalCode.throwEscapeChance = ""; //Increase Throw Escape Rate
                    survivalCode.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                    survivalCode.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                    survivalCode.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);

                    break;
                #endregion

                #region Intermediate Arc  [Rudiger]
                case "Intermediate Arc":
                    survivalCode.stageLevel = "0009";
                    survivalCode.stageMusic = "09";
                    survivalCode.stageNumber = 1;
                    survivalCode.model = "0B";
                    survivalCode.costume = "09";
                    survivalCode.fightingStyle = "0B";
                    survivalCode.weaponNumber = "02"; //Ivy

                    survivalCode.aiLevel = "01"; // 00-05
                    survivalCode.weaponSpecial = ""; //Fire, Thunder etc
                    survivalCode.guardianForce = ""; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                    survivalCode.stickyFeet = ""; //Slippery Feets
                    survivalCode.speed = "3F80"; //3F80 default speed

                    survivalCode.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                    survivalCode.attack = ""; //Decrease/Increase Attack
                    survivalCode.defense = ""; //Decrease/Increase Defense
                    survivalCode.stealHp = ""; //Steal health from enemy
                    survivalCode.pierceDamage = ""; //Damage inflicted thru guard
                    survivalCode.weaponSize = "";
                    survivalCode.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                    survivalCode.counterRate = ""; //Increase Counter Chance
                    survivalCode.nullCounter = ""; //Nullify Enemies Counters chance
                    survivalCode.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                    survivalCode.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                    survivalCode.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                    survivalCode.parryRegen = ""; //Recover Health when successfully Guard Impact
                    survivalCode.guardBreakRate = ""; //Increase Guard Break Chance
                    survivalCode.throwEscapeChance = ""; //Increase Throw Escape Rate
                    survivalCode.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                    survivalCode.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                    survivalCode.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "";
                    survivalCode.stageNumber = 2;
                    survivalCode.model = "0D";
                    survivalCode.costume = "09";
                    survivalCode.fightingStyle = "0D";
                    survivalCode.weaponNumber = "02"; //Xianghua

                    survivalCode.aiLevel = "01"; // 00-05
                    survivalCode.weaponSpecial = ""; //Fire, Thunder etc
                    survivalCode.guardianForce = ""; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                    survivalCode.stickyFeet = ""; //Slippery Feets
                    survivalCode.speed = "3F80"; //3F80 default speed

                    survivalCode.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                    survivalCode.attack = ""; //Decrease/Increase Attack
                    survivalCode.defense = ""; //Decrease/Increase Defense
                    survivalCode.stealHp = ""; //Steal health from enemy
                    survivalCode.pierceDamage = ""; //Damage inflicted thru guard
                    survivalCode.weaponSize = "";
                    survivalCode.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                    survivalCode.counterRate = ""; //Increase Counter Chance
                    survivalCode.nullCounter = ""; //Nullify Enemies Counters chance
                    survivalCode.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                    survivalCode.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                    survivalCode.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                    survivalCode.parryRegen = ""; //Recover Health when successfully Guard Impact
                    survivalCode.guardBreakRate = ""; //Increase Guard Break Chance
                    survivalCode.throwEscapeChance = ""; //Increase Throw Escape Rate
                    survivalCode.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                    survivalCode.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                    survivalCode.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "";
                    survivalCode.stageNumber = 3;
                    survivalCode.model = "12";
                    survivalCode.costume = "08";
                    survivalCode.fightingStyle = "12";
                    survivalCode.weaponNumber = "02"; //Astaroth

                    survivalCode.aiLevel = "01"; // 00-05
                    survivalCode.weaponSpecial = ""; //Fire, Thunder etc
                    survivalCode.guardianForce = ""; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                    survivalCode.stickyFeet = ""; //Slippery Feets
                    survivalCode.speed = "3F80"; //3F80 default speed

                    survivalCode.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                    survivalCode.attack = ""; //Decrease/Increase Attack
                    survivalCode.defense = ""; //Decrease/Increase Defense
                    survivalCode.stealHp = ""; //Steal health from enemy
                    survivalCode.pierceDamage = ""; //Damage inflicted thru guard
                    survivalCode.weaponSize = "";
                    survivalCode.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                    survivalCode.counterRate = ""; //Increase Counter Chance
                    survivalCode.nullCounter = ""; //Nullify Enemies Counters chance
                    survivalCode.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                    survivalCode.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                    survivalCode.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                    survivalCode.parryRegen = ""; //Recover Health when successfully Guard Impact
                    survivalCode.guardBreakRate = ""; //Increase Guard Break Chance
                    survivalCode.throwEscapeChance = ""; //Increase Throw Escape Rate
                    survivalCode.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                    survivalCode.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                    survivalCode.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "";
                    survivalCode.stageNumber = 4;
                    survivalCode.model = "23";
                    survivalCode.costume = "08";
                    survivalCode.fightingStyle = "23";
                    survivalCode.weaponNumber = "02"; //Tira

                    survivalCode.aiLevel = "01"; // 00-05
                    survivalCode.weaponSpecial = ""; //Fire, Thunder etc
                    survivalCode.guardianForce = ""; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                    survivalCode.stickyFeet = ""; //Slippery Feets
                    survivalCode.speed = "3F80"; //3F80 default speed

                    survivalCode.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                    survivalCode.attack = ""; //Decrease/Increase Attack
                    survivalCode.defense = ""; //Decrease/Increase Defense
                    survivalCode.stealHp = ""; //Steal health from enemy
                    survivalCode.pierceDamage = ""; //Damage inflicted thru guard
                    survivalCode.weaponSize = "";
                    survivalCode.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                    survivalCode.counterRate = ""; //Increase Counter Chance
                    survivalCode.nullCounter = ""; //Nullify Enemies Counters chance
                    survivalCode.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                    survivalCode.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                    survivalCode.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                    survivalCode.parryRegen = ""; //Recover Health when successfully Guard Impact
                    survivalCode.guardBreakRate = ""; //Increase Guard Break Chance
                    survivalCode.throwEscapeChance = ""; //Increase Throw Escape Rate
                    survivalCode.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                    survivalCode.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                    survivalCode.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "";
                    survivalCode.stageNumber = 5;
                    survivalCode.model = "25";
                    survivalCode.costume = "08";
                    survivalCode.fightingStyle = "25";
                    survivalCode.weaponNumber = "02"; //Olcadan

                    survivalCode.aiLevel = "01"; // 00-05
                    survivalCode.weaponSpecial = ""; //Fire, Thunder etc
                    survivalCode.guardianForce = ""; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                    survivalCode.stickyFeet = ""; //Slippery Feets
                    survivalCode.speed = "3F80"; //3F80 default speed

                    survivalCode.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                    survivalCode.attack = ""; //Decrease/Increase Attack
                    survivalCode.defense = ""; //Decrease/Increase Defense
                    survivalCode.stealHp = ""; //Steal health from enemy
                    survivalCode.pierceDamage = ""; //Damage inflicted thru guard
                    survivalCode.weaponSize = "";
                    survivalCode.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                    survivalCode.counterRate = ""; //Increase Counter Chance
                    survivalCode.nullCounter = ""; //Nullify Enemies Counters chance
                    survivalCode.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                    survivalCode.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                    survivalCode.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                    survivalCode.parryRegen = ""; //Recover Health when successfully Guard Impact
                    survivalCode.guardBreakRate = ""; //Increase Guard Break Chance
                    survivalCode.throwEscapeChance = ""; //Increase Throw Escape Rate
                    survivalCode.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                    survivalCode.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                    survivalCode.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "0007";
                    survivalCode.stageMusic = "07";
                    survivalCode.stageNumber = 6;
                    survivalCode.model = "07";
                    survivalCode.costume = "08";
                    survivalCode.fightingStyle = "07";
                    survivalCode.weaponNumber = "02"; //Siegfried

                    survivalCode.aiLevel = "01"; // 00-05
                    survivalCode.weaponSpecial = ""; //Fire, Thunder etc
                    survivalCode.guardianForce = ""; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                    survivalCode.stickyFeet = ""; //Slippery Feets
                    survivalCode.speed = "3F80"; //3F80 default speed

                    survivalCode.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                    survivalCode.attack = ""; //Decrease/Increase Attack
                    survivalCode.defense = ""; //Decrease/Increase Defense
                    survivalCode.stealHp = ""; //Steal health from enemy
                    survivalCode.pierceDamage = ""; //Damage inflicted thru guard
                    survivalCode.weaponSize = "";
                    survivalCode.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                    survivalCode.counterRate = ""; //Increase Counter Chance
                    survivalCode.nullCounter = ""; //Nullify Enemies Counters chance
                    survivalCode.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                    survivalCode.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                    survivalCode.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                    survivalCode.parryRegen = ""; //Recover Health when successfully Guard Impact
                    survivalCode.guardBreakRate = ""; //Increase Guard Break Chance
                    survivalCode.throwEscapeChance = ""; //Increase Throw Escape Rate
                    survivalCode.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                    survivalCode.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                    survivalCode.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "";
                    survivalCode.stageNumber = 7;
                    survivalCode.model = "15";
                    survivalCode.costume = "09";
                    survivalCode.fightingStyle = "15";
                    survivalCode.weaponNumber = "02"; //Raphael

                    survivalCode.aiLevel = "01"; // 00-05
                    survivalCode.weaponSpecial = ""; //Fire, Thunder etc
                    survivalCode.guardianForce = ""; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                    survivalCode.stickyFeet = ""; //Slippery Feets
                    survivalCode.speed = "3F80"; //3F80 default speed

                    survivalCode.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                    survivalCode.attack = ""; //Decrease/Increase Attack
                    survivalCode.defense = ""; //Decrease/Increase Defense
                    survivalCode.stealHp = ""; //Steal health from enemy
                    survivalCode.pierceDamage = ""; //Damage inflicted thru guard
                    survivalCode.weaponSize = "";
                    survivalCode.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                    survivalCode.counterRate = ""; //Increase Counter Chance
                    survivalCode.nullCounter = ""; //Nullify Enemies Counters chance
                    survivalCode.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                    survivalCode.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                    survivalCode.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                    survivalCode.parryRegen = ""; //Recover Health when successfully Guard Impact
                    survivalCode.guardBreakRate = ""; //Increase Guard Break Chance
                    survivalCode.throwEscapeChance = ""; //Increase Throw Escape Rate
                    survivalCode.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                    survivalCode.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                    survivalCode.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "";
                    survivalCode.stageNumber = 8;
                    survivalCode.model = "17";
                    survivalCode.costume = "09";
                    survivalCode.fightingStyle = "17";
                    survivalCode.weaponNumber = "02"; //Cassandra

                    survivalCode.aiLevel = "01"; // 00-05
                    survivalCode.weaponSpecial = ""; //Fire, Thunder etc
                    survivalCode.guardianForce = ""; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                    survivalCode.stickyFeet = ""; //Slippery Feets
                    survivalCode.speed = "3F80"; //3F80 default speed

                    survivalCode.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                    survivalCode.attack = ""; //Decrease/Increase Attack
                    survivalCode.defense = ""; //Decrease/Increase Defense
                    survivalCode.stealHp = ""; //Steal health from enemy
                    survivalCode.pierceDamage = ""; //Damage inflicted thru guard
                    survivalCode.weaponSize = "";
                    survivalCode.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                    survivalCode.counterRate = ""; //Increase Counter Chance
                    survivalCode.nullCounter = ""; //Nullify Enemies Counters chance
                    survivalCode.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                    survivalCode.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                    survivalCode.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                    survivalCode.parryRegen = ""; //Recover Health when successfully Guard Impact
                    survivalCode.guardBreakRate = ""; //Increase Guard Break Chance
                    survivalCode.throwEscapeChance = ""; //Increase Throw Escape Rate
                    survivalCode.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                    survivalCode.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                    survivalCode.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "";
                    survivalCode.stageNumber = 9;
                    survivalCode.model = "30";
                    survivalCode.costume = "01";
                    survivalCode.fightingStyle = "30";
                    survivalCode.weaponNumber = "01"; //Amy

                    survivalCode.aiLevel = "01"; // 00-05
                    survivalCode.weaponSpecial = ""; //Fire, Thunder etc
                    survivalCode.guardianForce = ""; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                    survivalCode.stickyFeet = ""; //Slippery Feets
                    survivalCode.speed = "3F80"; //3F80 default speed

                    survivalCode.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                    survivalCode.attack = ""; //Decrease/Increase Attack
                    survivalCode.defense = ""; //Decrease/Increase Defense
                    survivalCode.stealHp = ""; //Steal health from enemy
                    survivalCode.pierceDamage = ""; //Damage inflicted thru guard
                    survivalCode.weaponSize = "";
                    survivalCode.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                    survivalCode.counterRate = ""; //Increase Counter Chance
                    survivalCode.nullCounter = ""; //Nullify Enemies Counters chance
                    survivalCode.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                    survivalCode.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                    survivalCode.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                    survivalCode.parryRegen = ""; //Recover Health when successfully Guard Impact
                    survivalCode.guardBreakRate = ""; //Increase Guard Break Chance
                    survivalCode.throwEscapeChance = ""; //Increase Throw Escape Rate
                    survivalCode.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                    survivalCode.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                    survivalCode.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "";
                    survivalCode.stageNumber = 10;
                    survivalCode.model = "2A";
                    survivalCode.costume = "00";
                    survivalCode.fightingStyle = "2A";
                    survivalCode.weaponNumber = "00"; //Charade

                    survivalCode.aiLevel = "05"; // 00-05
                    survivalCode.weaponSpecial = ""; //Fire, Thunder etc
                    survivalCode.guardianForce = "05"; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                    survivalCode.stickyFeet = ""; //Slippery Feets
                    survivalCode.speed = "3F80"; //3F80 default speed

                    survivalCode.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                    survivalCode.attack = ""; //Decrease/Increase Attack
                    survivalCode.defense = ""; //Decrease/Increase Defense
                    survivalCode.stealHp = ""; //Steal health from enemy
                    survivalCode.pierceDamage = ""; //Damage inflicted thru guard
                    survivalCode.weaponSize = "";
                    survivalCode.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                    survivalCode.counterRate = ""; //Increase Counter Chance
                    survivalCode.nullCounter = ""; //Nullify Enemies Counters chance
                    survivalCode.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                    survivalCode.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                    survivalCode.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                    survivalCode.parryRegen = ""; //Recover Health when successfully Guard Impact
                    survivalCode.guardBreakRate = ""; //Increase Guard Break Chance
                    survivalCode.throwEscapeChance = ""; //Increase Throw Escape Rate
                    survivalCode.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                    survivalCode.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                    survivalCode.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "0013";
                    survivalCode.stageMusic = "13";
                    survivalCode.stageNumber = 11;
                    survivalCode.model = "88";
                    survivalCode.costume = "00";
                    survivalCode.fightingStyle = "1A";
                    survivalCode.weaponNumber = "00"; //Unknown Soul

                    survivalCode.aiLevel = "02"; // 00-05
                    survivalCode.weaponSpecial = ""; //Fire, Thunder etc
                    survivalCode.guardianForce = ""; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                    survivalCode.stickyFeet = ""; //Slippery Feets
                    survivalCode.speed = "3F80"; //3F80 default speed

                    survivalCode.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                    survivalCode.attack = ""; //Decrease/Increase Attack
                    survivalCode.defense = ""; //Decrease/Increase Defense
                    survivalCode.stealHp = ""; //Steal health from enemy
                    survivalCode.pierceDamage = ""; //Damage inflicted thru guard
                    survivalCode.weaponSize = "";
                    survivalCode.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                    survivalCode.counterRate = ""; //Increase Counter Chance
                    survivalCode.nullCounter = ""; //Nullify Enemies Counters chance
                    survivalCode.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                    survivalCode.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                    survivalCode.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                    survivalCode.parryRegen = ""; //Recover Health when successfully Guard Impact
                    survivalCode.guardBreakRate = ""; //Increase Guard Break Chance
                    survivalCode.throwEscapeChance = ""; //Increase Throw Escape Rate
                    survivalCode.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                    survivalCode.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                    survivalCode.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "";
                    survivalCode.stageNumber = 12;
                    survivalCode.model = "2E";
                    survivalCode.costume = "00";
                    survivalCode.fightingStyle = "2E";
                    survivalCode.weaponNumber = "01"; //Shadow Master

                    survivalCode.aiLevel = "02"; // 00-05
                    survivalCode.weaponSpecial = ""; //Fire, Thunder etc
                    survivalCode.guardianForce = ""; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                    survivalCode.stickyFeet = ""; //Slippery Feets
                    survivalCode.speed = "3F80"; //3F80 default speed

                    survivalCode.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                    survivalCode.attack = ""; //Decrease/Increase Attack
                    survivalCode.defense = ""; //Decrease/Increase Defense
                    survivalCode.stealHp = ""; //Steal health from enemy
                    survivalCode.pierceDamage = ""; //Damage inflicted thru guard
                    survivalCode.weaponSize = "";
                    survivalCode.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                    survivalCode.counterRate = ""; //Increase Counter Chance
                    survivalCode.nullCounter = ""; //Nullify Enemies Counters chance
                    survivalCode.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                    survivalCode.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                    survivalCode.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                    survivalCode.parryRegen = ""; //Recover Health when successfully Guard Impact
                    survivalCode.guardBreakRate = ""; //Increase Guard Break Chance
                    survivalCode.throwEscapeChance = ""; //Increase Throw Escape Rate
                    survivalCode.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                    survivalCode.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                    survivalCode.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "";
                    survivalCode.stageNumber = 13;
                    survivalCode.model = "91";
                    survivalCode.costume = "00";
                    survivalCode.fightingStyle = "4C";
                    survivalCode.weaponNumber = "01"; //Pirate 1

                    survivalCode.aiLevel = "02"; // 00-05
                    survivalCode.weaponSpecial = ""; //Fire, Thunder etc
                    survivalCode.guardianForce = ""; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                    survivalCode.stickyFeet = ""; //Slippery Feets
                    survivalCode.speed = "3F80"; //3F80 default speed

                    survivalCode.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                    survivalCode.attack = ""; //Decrease/Increase Attack
                    survivalCode.defense = ""; //Decrease/Increase Defense
                    survivalCode.stealHp = ""; //Steal health from enemy
                    survivalCode.pierceDamage = ""; //Damage inflicted thru guard
                    survivalCode.weaponSize = "";
                    survivalCode.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                    survivalCode.counterRate = ""; //Increase Counter Chance
                    survivalCode.nullCounter = ""; //Nullify Enemies Counters chance
                    survivalCode.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                    survivalCode.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                    survivalCode.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                    survivalCode.parryRegen = ""; //Recover Health when successfully Guard Impact
                    survivalCode.guardBreakRate = ""; //Increase Guard Break Chance
                    survivalCode.throwEscapeChance = ""; //Increase Throw Escape Rate
                    survivalCode.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                    survivalCode.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                    survivalCode.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "";
                    survivalCode.stageNumber = 14;
                    survivalCode.model = "B9";
                    survivalCode.costume = "00";
                    survivalCode.fightingStyle = "4E";
                    survivalCode.weaponNumber = "02"; //Eunice

                    survivalCode.aiLevel = "02"; // 00-05
                    survivalCode.weaponSpecial = ""; //Fire, Thunder etc
                    survivalCode.guardianForce = ""; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                    survivalCode.stickyFeet = ""; //Slippery Feets
                    survivalCode.speed = "3F80"; //3F80 default speed

                    survivalCode.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                    survivalCode.attack = ""; //Decrease/Increase Attack
                    survivalCode.defense = ""; //Decrease/Increase Defense
                    survivalCode.stealHp = ""; //Steal health from enemy
                    survivalCode.pierceDamage = ""; //Damage inflicted thru guard
                    survivalCode.weaponSize = "";
                    survivalCode.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                    survivalCode.counterRate = ""; //Increase Counter Chance
                    survivalCode.nullCounter = ""; //Nullify Enemies Counters chance
                    survivalCode.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                    survivalCode.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                    survivalCode.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                    survivalCode.parryRegen = ""; //Recover Health when successfully Guard Impact
                    survivalCode.guardBreakRate = ""; //Increase Guard Break Chance
                    survivalCode.throwEscapeChance = ""; //Increase Throw Escape Rate
                    survivalCode.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                    survivalCode.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                    survivalCode.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "";
                    survivalCode.stageNumber = 15;
                    survivalCode.model = "A1";
                    survivalCode.costume = "01";
                    survivalCode.fightingStyle = "41";
                    survivalCode.weaponNumber = "02"; //Chikage

                    survivalCode.aiLevel = "02"; // 00-05
                    survivalCode.weaponSpecial = ""; //Fire, Thunder etc
                    survivalCode.guardianForce = ""; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                    survivalCode.stickyFeet = ""; //Slippery Feets
                    survivalCode.speed = "3F80"; //3F80 default speed

                    survivalCode.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                    survivalCode.attack = ""; //Decrease/Increase Attack
                    survivalCode.defense = ""; //Decrease/Increase Defense
                    survivalCode.stealHp = ""; //Steal health from enemy
                    survivalCode.pierceDamage = ""; //Damage inflicted thru guard
                    survivalCode.weaponSize = "";
                    survivalCode.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                    survivalCode.counterRate = ""; //Increase Counter Chance
                    survivalCode.nullCounter = ""; //Nullify Enemies Counters chance
                    survivalCode.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                    survivalCode.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                    survivalCode.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                    survivalCode.parryRegen = ""; //Recover Health when successfully Guard Impact
                    survivalCode.guardBreakRate = ""; //Increase Guard Break Chance
                    survivalCode.throwEscapeChance = ""; //Increase Throw Escape Rate
                    survivalCode.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                    survivalCode.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                    survivalCode.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "000C";
                    survivalCode.stageMusic = "0C";
                    survivalCode.stageNumber = 16;
                    survivalCode.model = "BC";
                    survivalCode.costume = "02";
                    survivalCode.fightingStyle = "51";
                    survivalCode.weaponNumber = "00"; //Dufeng

                    survivalCode.aiLevel = "02"; // 00-05
                    survivalCode.weaponSpecial = ""; //Fire, Thunder etc
                    survivalCode.guardianForce = ""; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                    survivalCode.stickyFeet = ""; //Slippery Feets
                    survivalCode.speed = "3F80"; //3F80 default speed

                    survivalCode.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                    survivalCode.attack = ""; //Decrease/Increase Attack
                    survivalCode.defense = ""; //Decrease/Increase Defense
                    survivalCode.stealHp = ""; //Steal health from enemy
                    survivalCode.pierceDamage = ""; //Damage inflicted thru guard
                    survivalCode.weaponSize = "";
                    survivalCode.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                    survivalCode.counterRate = ""; //Increase Counter Chance
                    survivalCode.nullCounter = ""; //Nullify Enemies Counters chance
                    survivalCode.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                    survivalCode.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                    survivalCode.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                    survivalCode.parryRegen = ""; //Recover Health when successfully Guard Impact
                    survivalCode.guardBreakRate = ""; //Increase Guard Break Chance
                    survivalCode.throwEscapeChance = ""; //Increase Throw Escape Rate
                    survivalCode.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                    survivalCode.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                    survivalCode.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "";
                    survivalCode.stageNumber = 17;
                    survivalCode.model = "94";
                    survivalCode.costume = "00";
                    survivalCode.fightingStyle = "45";
                    survivalCode.weaponNumber = "03"; //Swordsman 1

                    survivalCode.aiLevel = "02"; // 00-05
                    survivalCode.weaponSpecial = ""; //Fire, Thunder etc
                    survivalCode.guardianForce = ""; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                    survivalCode.stickyFeet = ""; //Slippery Feets
                    survivalCode.speed = "3F80"; //3F80 default speed

                    survivalCode.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                    survivalCode.attack = ""; //Decrease/Increase Attack
                    survivalCode.defense = ""; //Decrease/Increase Defense
                    survivalCode.stealHp = ""; //Steal health from enemy
                    survivalCode.pierceDamage = ""; //Damage inflicted thru guard
                    survivalCode.weaponSize = "";
                    survivalCode.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                    survivalCode.counterRate = ""; //Increase Counter Chance
                    survivalCode.nullCounter = ""; //Nullify Enemies Counters chance
                    survivalCode.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                    survivalCode.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                    survivalCode.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                    survivalCode.parryRegen = ""; //Recover Health when successfully Guard Impact
                    survivalCode.guardBreakRate = ""; //Increase Guard Break Chance
                    survivalCode.throwEscapeChance = ""; //Increase Throw Escape Rate
                    survivalCode.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                    survivalCode.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                    survivalCode.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "";
                    survivalCode.stageNumber = 18;
                    survivalCode.model = "4B";
                    survivalCode.costume = "01";
                    survivalCode.fightingStyle = "4B";
                    survivalCode.weaponNumber = "00"; //Aurelia

                    survivalCode.aiLevel = "02"; // 00-05
                    survivalCode.weaponSpecial = ""; //Fire, Thunder etc
                    survivalCode.guardianForce = ""; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                    survivalCode.stickyFeet = ""; //Slippery Feets
                    survivalCode.speed = "3F80"; //3F80 default speed

                    survivalCode.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                    survivalCode.attack = ""; //Decrease/Increase Attack
                    survivalCode.defense = ""; //Decrease/Increase Defense
                    survivalCode.stealHp = ""; //Steal health from enemy
                    survivalCode.pierceDamage = ""; //Damage inflicted thru guard
                    survivalCode.weaponSize = "";
                    survivalCode.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                    survivalCode.counterRate = ""; //Increase Counter Chance
                    survivalCode.nullCounter = ""; //Nullify Enemies Counters chance
                    survivalCode.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                    survivalCode.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                    survivalCode.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                    survivalCode.parryRegen = ""; //Recover Health when successfully Guard Impact
                    survivalCode.guardBreakRate = ""; //Increase Guard Break Chance
                    survivalCode.throwEscapeChance = ""; //Increase Throw Escape Rate
                    survivalCode.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                    survivalCode.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                    survivalCode.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "";
                    survivalCode.stageNumber = 19;
                    survivalCode.model = "8B";
                    survivalCode.costume = "00";
                    survivalCode.fightingStyle = "4B";
                    survivalCode.weaponNumber = "01"; //Fu-ma Ninja 2

                    survivalCode.aiLevel = "02"; // 00-05
                    survivalCode.weaponSpecial = ""; //Fire, Thunder etc
                    survivalCode.guardianForce = ""; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                    survivalCode.stickyFeet = ""; //Slippery Feets
                    survivalCode.speed = "3F80"; //3F80 default speed

                    survivalCode.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                    survivalCode.attack = ""; //Decrease/Increase Attack
                    survivalCode.defense = ""; //Decrease/Increase Defense
                    survivalCode.stealHp = ""; //Steal health from enemy
                    survivalCode.pierceDamage = ""; //Damage inflicted thru guard
                    survivalCode.weaponSize = "";
                    survivalCode.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                    survivalCode.counterRate = ""; //Increase Counter Chance
                    survivalCode.nullCounter = ""; //Nullify Enemies Counters chance
                    survivalCode.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                    survivalCode.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                    survivalCode.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                    survivalCode.parryRegen = ""; //Recover Health when successfully Guard Impact
                    survivalCode.guardBreakRate = ""; //Increase Guard Break Chance
                    survivalCode.throwEscapeChance = ""; //Increase Throw Escape Rate
                    survivalCode.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                    survivalCode.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                    survivalCode.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "";
                    survivalCode.stageNumber = 20;
                    survivalCode.model = "AE";
                    survivalCode.costume = "01";
                    survivalCode.fightingStyle = "48";
                    survivalCode.weaponNumber = "07"; //Rudiger

                    survivalCode.aiLevel = "02"; // 00-05
                    survivalCode.weaponSpecial = "All Guard Break"; //Fire, Thunder, Paralysis, Cure etc
                    survivalCode.guardianForce = ""; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                    survivalCode.stickyFeet = ""; //Slippery Feets
                    survivalCode.speed = "3F80"; //3F80 default speed

                    survivalCode.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                    survivalCode.attack = ""; //Decrease/Increase Attack
                    survivalCode.defense = ""; //Decrease/Increase Defense
                    survivalCode.stealHp = ""; //Steal health from enemy
                    survivalCode.pierceDamage = ""; //Damage inflicted thru guard
                    survivalCode.weaponSize = "";
                    survivalCode.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                    survivalCode.counterRate = ""; //Increase Counter Chance
                    survivalCode.nullCounter = ""; //Nullify Enemies Counters chance
                    survivalCode.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                    survivalCode.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                    survivalCode.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                    survivalCode.parryRegen = ""; //Recover Health when successfully Guard Impact
                    survivalCode.guardBreakRate = ""; //Increase Guard Break Chance
                    survivalCode.throwEscapeChance = ""; //Increase Throw Escape Rate
                    survivalCode.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                    survivalCode.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                    survivalCode.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                    break;
                #endregion

                #region Advanced Arc  [Areon]
                case "Advanced Arc":
                    survivalCode.stageLevel = "0002";
                    survivalCode.stageMusic = "02";
                    survivalCode.stageNumber = 1;
                    survivalCode.model = "14";
                    survivalCode.costume = "01";
                    survivalCode.fightingStyle = "14";
                    survivalCode.weaponNumber = "04"; //Cervantes

                    survivalCode.aiLevel = "02"; // 00-05
                    survivalCode.weaponSpecial = ""; //Fire, Thunder, Paralysis, Cure etc
                    survivalCode.guardianForce = ""; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                    survivalCode.stickyFeet = ""; //Slippery Feets
                    survivalCode.speed = "3F80"; //3F80 default speed

                    survivalCode.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                    survivalCode.attack = ""; //Decrease/Increase Attack
                    survivalCode.defense = ""; //Decrease/Increase Defense
                    survivalCode.stealHp = ""; //Steal health from enemy
                    survivalCode.pierceDamage = ""; //Damage inflicted thru guard
                    survivalCode.weaponSize = "";
                    survivalCode.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                    survivalCode.counterRate = ""; //Increase Counter Chance
                    survivalCode.nullCounter = ""; //Nullify Enemies Counters chance
                    survivalCode.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                    survivalCode.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                    survivalCode.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                    survivalCode.parryRegen = ""; //Recover Health when successfully Guard Impact
                    survivalCode.guardBreakRate = ""; //Increase Guard Break Chance
                    survivalCode.throwEscapeChance = ""; //Increase Throw Escape Rate
                    survivalCode.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                    survivalCode.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                    survivalCode.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "";
                    survivalCode.stageNumber = 2;
                    survivalCode.model = "E7";
                    survivalCode.costume = "02";
                    survivalCode.fightingStyle = "4D";
                    survivalCode.weaponNumber = "03"; //Aege

                    survivalCode.aiLevel = "02"; // 00-05
                    survivalCode.weaponSpecial = ""; //Fire, Thunder, Paralysis, Cure etc
                    survivalCode.guardianForce = ""; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                    survivalCode.stickyFeet = ""; //Slippery Feets
                    survivalCode.speed = "3F80"; //3F80 default speed

                    survivalCode.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                    survivalCode.attack = ""; //Decrease/Increase Attack
                    survivalCode.defense = ""; //Decrease/Increase Defense
                    survivalCode.stealHp = ""; //Steal health from enemy
                    survivalCode.pierceDamage = ""; //Damage inflicted thru guard
                    survivalCode.weaponSize = "";
                    survivalCode.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                    survivalCode.counterRate = ""; //Increase Counter Chance
                    survivalCode.nullCounter = ""; //Nullify Enemies Counters chance
                    survivalCode.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                    survivalCode.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                    survivalCode.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                    survivalCode.parryRegen = ""; //Recover Health when successfully Guard Impact
                    survivalCode.guardBreakRate = ""; //Increase Guard Break Chance
                    survivalCode.throwEscapeChance = ""; //Increase Throw Escape Rate
                    survivalCode.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                    survivalCode.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                    survivalCode.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "";
                    survivalCode.stageNumber = 3;
                    survivalCode.model = "B1";
                    survivalCode.costume = "01";
                    survivalCode.fightingStyle = "4A";
                    survivalCode.weaponNumber = "03"; //Azalea

                    survivalCode.aiLevel = "02"; // 00-05
                    survivalCode.weaponSpecial = ""; //Fire, Thunder, Paralysis, Cure etc
                    survivalCode.guardianForce = ""; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                    survivalCode.stickyFeet = ""; //Slippery Feets
                    survivalCode.speed = "3F80"; //3F80 default speed

                    survivalCode.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                    survivalCode.attack = ""; //Decrease/Increase Attack
                    survivalCode.defense = ""; //Decrease/Increase Defense
                    survivalCode.stealHp = ""; //Steal health from enemy
                    survivalCode.pierceDamage = ""; //Damage inflicted thru guard
                    survivalCode.weaponSize = "";
                    survivalCode.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                    survivalCode.counterRate = ""; //Increase Counter Chance
                    survivalCode.nullCounter = ""; //Nullify Enemies Counters chance
                    survivalCode.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                    survivalCode.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                    survivalCode.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                    survivalCode.parryRegen = ""; //Recover Health when successfully Guard Impact
                    survivalCode.guardBreakRate = ""; //Increase Guard Break Chance
                    survivalCode.throwEscapeChance = ""; //Increase Throw Escape Rate
                    survivalCode.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                    survivalCode.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                    survivalCode.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "";
                    survivalCode.stageNumber = 4;
                    survivalCode.model = "42";
                    survivalCode.costume = "01";
                    survivalCode.fightingStyle = "42";
                    survivalCode.weaponNumber = "02"; //Greed

                    survivalCode.aiLevel = "02"; // 00-05
                    survivalCode.weaponSpecial = ""; //Fire, Thunder, Paralysis, Cure etc
                    survivalCode.guardianForce = ""; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                    survivalCode.stickyFeet = ""; //Slippery Feets
                    survivalCode.speed = "3F80"; //3F80 default speed

                    survivalCode.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                    survivalCode.attack = ""; //Decrease/Increase Attack
                    survivalCode.defense = ""; //Decrease/Increase Defense
                    survivalCode.stealHp = ""; //Steal health from enemy
                    survivalCode.pierceDamage = ""; //Damage inflicted thru guard
                    survivalCode.weaponSize = "";
                    survivalCode.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                    survivalCode.counterRate = ""; //Increase Counter Chance
                    survivalCode.nullCounter = ""; //Nullify Enemies Counters chance
                    survivalCode.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                    survivalCode.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                    survivalCode.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                    survivalCode.parryRegen = ""; //Recover Health when successfully Guard Impact
                    survivalCode.guardBreakRate = ""; //Increase Guard Break Chance
                    survivalCode.throwEscapeChance = ""; //Increase Throw Escape Rate
                    survivalCode.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                    survivalCode.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                    survivalCode.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "";
                    survivalCode.stageNumber = 5;
                    survivalCode.model = "A4";
                    survivalCode.costume = "00";
                    survivalCode.fightingStyle = "43";
                    survivalCode.weaponNumber = "01"; //Meiga

                    survivalCode.aiLevel = "02"; // 00-05
                    survivalCode.weaponSpecial = ""; //Fire, Thunder, Paralysis, Cure etc
                    survivalCode.guardianForce = ""; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                    survivalCode.stickyFeet = ""; //Slippery Feets
                    survivalCode.speed = "3F80"; //3F80 default speed

                    survivalCode.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                    survivalCode.attack = ""; //Decrease/Increase Attack
                    survivalCode.defense = ""; //Decrease/Increase Defense
                    survivalCode.stealHp = ""; //Steal health from enemy
                    survivalCode.pierceDamage = ""; //Damage inflicted thru guard
                    survivalCode.weaponSize = "";
                    survivalCode.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                    survivalCode.counterRate = ""; //Increase Counter Chance
                    survivalCode.nullCounter = ""; //Nullify Enemies Counters chance
                    survivalCode.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                    survivalCode.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                    survivalCode.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                    survivalCode.parryRegen = ""; //Recover Health when successfully Guard Impact
                    survivalCode.guardBreakRate = ""; //Increase Guard Break Chance
                    survivalCode.throwEscapeChance = ""; //Increase Throw Escape Rate
                    survivalCode.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                    survivalCode.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                    survivalCode.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "0005";
                    survivalCode.stageMusic = "05";
                    survivalCode.stageNumber = 6;
                    survivalCode.model = "EE";
                    survivalCode.costume = "00";
                    survivalCode.fightingStyle = "45";
                    survivalCode.weaponNumber = "07"; //Mooncalf

                    survivalCode.aiLevel = "02"; // 00-05
                    survivalCode.weaponSpecial = ""; //Fire, Thunder, Paralysis, Cure etc
                    survivalCode.guardianForce = ""; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                    survivalCode.stickyFeet = ""; //Slippery Feets
                    survivalCode.speed = "3F80"; //3F80 default speed

                    survivalCode.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                    survivalCode.attack = ""; //Decrease/Increase Attack
                    survivalCode.defense = ""; //Decrease/Increase Defense
                    survivalCode.stealHp = ""; //Steal health from enemy
                    survivalCode.pierceDamage = ""; //Damage inflicted thru guard
                    survivalCode.weaponSize = "";
                    survivalCode.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                    survivalCode.counterRate = ""; //Increase Counter Chance
                    survivalCode.nullCounter = ""; //Nullify Enemies Counters chance
                    survivalCode.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                    survivalCode.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                    survivalCode.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                    survivalCode.parryRegen = ""; //Recover Health when successfully Guard Impact
                    survivalCode.guardBreakRate = ""; //Increase Guard Break Chance
                    survivalCode.throwEscapeChance = ""; //Increase Throw Escape Rate
                    survivalCode.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                    survivalCode.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                    survivalCode.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "";
                    survivalCode.stageNumber = 7;
                    survivalCode.model = "B6";
                    survivalCode.costume = "00";
                    survivalCode.fightingStyle = "4D";
                    survivalCode.weaponNumber = "04"; //Balduin

                    survivalCode.aiLevel = "02"; // 00-05
                    survivalCode.weaponSpecial = ""; //Fire, Thunder, Paralysis, Cure etc
                    survivalCode.guardianForce = ""; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                    survivalCode.stickyFeet = ""; //Slippery Feets
                    survivalCode.speed = "3F80"; //3F80 default speed

                    survivalCode.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                    survivalCode.attack = ""; //Decrease/Increase Attack
                    survivalCode.defense = ""; //Decrease/Increase Defense
                    survivalCode.stealHp = ""; //Steal health from enemy
                    survivalCode.pierceDamage = ""; //Damage inflicted thru guard
                    survivalCode.weaponSize = "";
                    survivalCode.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                    survivalCode.counterRate = ""; //Increase Counter Chance
                    survivalCode.nullCounter = ""; //Nullify Enemies Counters chance
                    survivalCode.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                    survivalCode.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                    survivalCode.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                    survivalCode.parryRegen = ""; //Recover Health when successfully Guard Impact
                    survivalCode.guardBreakRate = ""; //Increase Guard Break Chance
                    survivalCode.throwEscapeChance = ""; //Increase Throw Escape Rate
                    survivalCode.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                    survivalCode.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                    survivalCode.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "";
                    survivalCode.stageNumber = 8;
                    survivalCode.model = "29";
                    survivalCode.costume = "00";
                    survivalCode.fightingStyle = "29";
                    survivalCode.weaponNumber = "03"; //Charade

                    survivalCode.aiLevel = "02"; // 00-05
                    survivalCode.weaponSpecial = ""; //Fire, Thunder, Paralysis, Cure etc
                    survivalCode.guardianForce = "00"; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                    survivalCode.stickyFeet = ""; //Slippery Feets
                    survivalCode.speed = "3F80"; //3F80 default speed

                    survivalCode.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                    survivalCode.attack = ""; //Decrease/Increase Attack
                    survivalCode.defense = ""; //Decrease/Increase Defense
                    survivalCode.stealHp = ""; //Steal health from enemy
                    survivalCode.pierceDamage = ""; //Damage inflicted thru guard
                    survivalCode.weaponSize = "";
                    survivalCode.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                    survivalCode.counterRate = ""; //Increase Counter Chance
                    survivalCode.nullCounter = ""; //Nullify Enemies Counters chance
                    survivalCode.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                    survivalCode.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                    survivalCode.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                    survivalCode.parryRegen = ""; //Recover Health when successfully Guard Impact
                    survivalCode.guardBreakRate = ""; //Increase Guard Break Chance
                    survivalCode.throwEscapeChance = ""; //Increase Throw Escape Rate
                    survivalCode.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                    survivalCode.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                    survivalCode.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "";
                    survivalCode.stageNumber = 9;
                    survivalCode.model = "41";
                    survivalCode.costume = "01";
                    survivalCode.fightingStyle = "41";
                    survivalCode.weaponNumber = "03"; //Miser

                    survivalCode.aiLevel = "02"; // 00-05
                    survivalCode.weaponSpecial = ""; //Fire, Thunder, Paralysis, Cure etc
                    survivalCode.guardianForce = ""; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                    survivalCode.stickyFeet = ""; //Slippery Feets
                    survivalCode.speed = "3F80"; //3F80 default speed

                    survivalCode.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                    survivalCode.attack = ""; //Decrease/Increase Attack
                    survivalCode.defense = ""; //Decrease/Increase Defense
                    survivalCode.stealHp = ""; //Steal health from enemy
                    survivalCode.pierceDamage = ""; //Damage inflicted thru guard
                    survivalCode.weaponSize = "";
                    survivalCode.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                    survivalCode.counterRate = ""; //Increase Counter Chance
                    survivalCode.nullCounter = ""; //Nullify Enemies Counters chance
                    survivalCode.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                    survivalCode.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                    survivalCode.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                    survivalCode.parryRegen = ""; //Recover Health when successfully Guard Impact
                    survivalCode.guardBreakRate = ""; //Increase Guard Break Chance
                    survivalCode.throwEscapeChance = ""; //Increase Throw Escape Rate
                    survivalCode.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                    survivalCode.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                    survivalCode.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "";
                    survivalCode.stageNumber = 10;
                    survivalCode.model = "B0";
                    survivalCode.costume = "02";
                    survivalCode.fightingStyle = "4A";
                    survivalCode.weaponNumber = "04"; //Aeolos

                    survivalCode.aiLevel = "02"; // 00-05
                    survivalCode.weaponSpecial = ""; //Fire, Thunder, Paralysis, Cure etc
                    survivalCode.guardianForce = ""; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                    survivalCode.stickyFeet = ""; //Slippery Feets
                    survivalCode.speed = "3F80"; //3F80 default speed

                    survivalCode.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                    survivalCode.attack = ""; //Decrease/Increase Attack
                    survivalCode.defense = ""; //Decrease/Increase Defense
                    survivalCode.stealHp = ""; //Steal health from enemy
                    survivalCode.pierceDamage = ""; //Damage inflicted thru guard
                    survivalCode.weaponSize = "";
                    survivalCode.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                    survivalCode.counterRate = ""; //Increase Counter Chance
                    survivalCode.nullCounter = ""; //Nullify Enemies Counters chance
                    survivalCode.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                    survivalCode.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                    survivalCode.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                    survivalCode.parryRegen = ""; //Recover Health when successfully Guard Impact
                    survivalCode.guardBreakRate = ""; //Increase Guard Break Chance
                    survivalCode.throwEscapeChance = ""; //Increase Throw Escape Rate
                    survivalCode.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                    survivalCode.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                    survivalCode.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "0004";
                    survivalCode.stageMusic = "04";
                    survivalCode.stageNumber = 11;
                    survivalCode.model = "92";
                    survivalCode.costume = "00";
                    survivalCode.fightingStyle = "44";
                    survivalCode.weaponNumber = "02"; //Pirate 4

                    survivalCode.aiLevel = "02"; // 00-05
                    survivalCode.weaponSpecial = ""; //Fire, Thunder, Paralysis, Cure etc
                    survivalCode.guardianForce = ""; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                    survivalCode.stickyFeet = ""; //Slippery Feets
                    survivalCode.speed = "3F80"; //3F80 default speed

                    survivalCode.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                    survivalCode.attack = ""; //Decrease/Increase Attack
                    survivalCode.defense = ""; //Decrease/Increase Defense
                    survivalCode.stealHp = ""; //Steal health from enemy
                    survivalCode.pierceDamage = ""; //Damage inflicted thru guard
                    survivalCode.weaponSize = "";
                    survivalCode.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                    survivalCode.counterRate = ""; //Increase Counter Chance
                    survivalCode.nullCounter = ""; //Nullify Enemies Counters chance
                    survivalCode.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                    survivalCode.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                    survivalCode.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                    survivalCode.parryRegen = ""; //Recover Health when successfully Guard Impact
                    survivalCode.guardBreakRate = ""; //Increase Guard Break Chance
                    survivalCode.throwEscapeChance = ""; //Increase Throw Escape Rate
                    survivalCode.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                    survivalCode.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                    survivalCode.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "";
                    survivalCode.stageNumber = 12;
                    survivalCode.model = "0B";
                    survivalCode.costume = "08";
                    survivalCode.fightingStyle = "0B";
                    survivalCode.weaponNumber = "04"; //Ivy

                    survivalCode.aiLevel = "02"; // 00-05
                    survivalCode.weaponSpecial = ""; //Fire, Thunder, Paralysis, Cure etc
                    survivalCode.guardianForce = ""; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                    survivalCode.stickyFeet = ""; //Slippery Feets
                    survivalCode.speed = "3F80"; //3F80 default speed

                    survivalCode.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                    survivalCode.attack = ""; //Decrease/Increase Attack
                    survivalCode.defense = ""; //Decrease/Increase Defense
                    survivalCode.stealHp = ""; //Steal health from enemy
                    survivalCode.pierceDamage = ""; //Damage inflicted thru guard
                    survivalCode.weaponSize = "";
                    survivalCode.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                    survivalCode.counterRate = ""; //Increase Counter Chance
                    survivalCode.nullCounter = ""; //Nullify Enemies Counters chance
                    survivalCode.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                    survivalCode.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                    survivalCode.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                    survivalCode.parryRegen = ""; //Recover Health when successfully Guard Impact
                    survivalCode.guardBreakRate = ""; //Increase Guard Break Chance
                    survivalCode.throwEscapeChance = ""; //Increase Throw Escape Rate
                    survivalCode.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                    survivalCode.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                    survivalCode.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "";
                    survivalCode.stageNumber = 13;
                    survivalCode.model = "44";
                    survivalCode.costume = "01";
                    survivalCode.fightingStyle = "44";
                    survivalCode.weaponNumber = "05"; //Hwang

                    survivalCode.aiLevel = "02"; // 00-05
                    survivalCode.weaponSpecial = "All Guard Break"; //Fire, Thunder, Paralysis, Cure etc
                    survivalCode.guardianForce = ""; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                    survivalCode.stickyFeet = ""; //Slippery Feets
                    survivalCode.speed = "3F82"; //3F80 default speed

                    survivalCode.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                    survivalCode.attack = ""; //Decrease/Increase Attack
                    survivalCode.defense = ""; //Decrease/Increase Defense
                    survivalCode.stealHp = ""; //Steal health from enemy
                    survivalCode.pierceDamage = ""; //Damage inflicted thru guard
                    survivalCode.weaponSize = "";
                    survivalCode.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                    survivalCode.counterRate = ""; //Increase Counter Chance
                    survivalCode.nullCounter = ""; //Nullify Enemies Counters chance
                    survivalCode.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                    survivalCode.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                    survivalCode.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                    survivalCode.parryRegen = ""; //Recover Health when successfully Guard Impact
                    survivalCode.guardBreakRate = ""; //Increase Guard Break Chance
                    survivalCode.throwEscapeChance = ""; //Increase Throw Escape Rate
                    survivalCode.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                    survivalCode.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                    survivalCode.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "";
                    survivalCode.stageNumber = 14;
                    survivalCode.model = "12";
                    survivalCode.costume = "08";
                    survivalCode.fightingStyle = "12";
                    survivalCode.weaponNumber = "05"; //Astaroth

                    survivalCode.aiLevel = "02"; // 00-05
                    survivalCode.weaponSpecial = ""; //Fire, Thunder, Paralysis, Cure etc
                    survivalCode.guardianForce = ""; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                    survivalCode.stickyFeet = ""; //Slippery Feets
                    survivalCode.speed = "3F78"; //3F80 default speed

                    survivalCode.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                    survivalCode.attack = ""; //Decrease/Increase Attack
                    survivalCode.defense = ""; //Decrease/Increase Defense
                    survivalCode.stealHp = ""; //Steal health from enemy
                    survivalCode.pierceDamage = ""; //Damage inflicted thru guard
                    survivalCode.weaponSize = "";
                    survivalCode.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                    survivalCode.counterRate = ""; //Increase Counter Chance
                    survivalCode.nullCounter = ""; //Nullify Enemies Counters chance
                    survivalCode.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                    survivalCode.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                    survivalCode.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                    survivalCode.parryRegen = ""; //Recover Health when successfully Guard Impact
                    survivalCode.guardBreakRate = ""; //Increase Guard Break Chance
                    survivalCode.throwEscapeChance = ""; //Increase Throw Escape Rate
                    survivalCode.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                    survivalCode.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                    survivalCode.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "";
                    survivalCode.stageNumber = 15;
                    survivalCode.model = "26";
                    survivalCode.costume = "08";
                    survivalCode.fightingStyle = "26";
                    survivalCode.weaponNumber = "01"; //Abyss

                    survivalCode.aiLevel = "02"; // 00-05
                    survivalCode.weaponSpecial = ""; //Fire, Thunder, Paralysis, Cure etc
                    survivalCode.guardianForce = ""; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                    survivalCode.stickyFeet = ""; //Slippery Feets
                    survivalCode.speed = "3F80"; //3F80 default speed

                    survivalCode.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                    survivalCode.attack = ""; //Decrease/Increase Attack
                    survivalCode.defense = ""; //Decrease/Increase Defense
                    survivalCode.stealHp = ""; //Steal health from enemy
                    survivalCode.pierceDamage = ""; //Damage inflicted thru guard
                    survivalCode.weaponSize = "";
                    survivalCode.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                    survivalCode.counterRate = ""; //Increase Counter Chance
                    survivalCode.nullCounter = ""; //Nullify Enemies Counters chance
                    survivalCode.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                    survivalCode.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                    survivalCode.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                    survivalCode.parryRegen = ""; //Recover Health when successfully Guard Impact
                    survivalCode.guardBreakRate = ""; //Increase Guard Break Chance
                    survivalCode.throwEscapeChance = ""; //Increase Throw Escape Rate
                    survivalCode.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                    survivalCode.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                    survivalCode.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "0000";
                    survivalCode.stageMusic = "00";
                    survivalCode.stageNumber = 16;
                    survivalCode.model = "84";
                    survivalCode.costume = "01";
                    survivalCode.fightingStyle = "43";
                    survivalCode.weaponNumber = "01"; //Samurai 2

                    survivalCode.aiLevel = "03"; // 00-05
                    survivalCode.weaponSpecial = ""; //Fire, Thunder, Paralysis, Cure etc
                    survivalCode.guardianForce = ""; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                    survivalCode.stickyFeet = ""; //Slippery Feets
                    survivalCode.speed = "3F80"; //3F80 default speed

                    survivalCode.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                    survivalCode.attack = ""; //Decrease/Increase Attack
                    survivalCode.defense = ""; //Decrease/Increase Defense
                    survivalCode.stealHp = ""; //Steal health from enemy
                    survivalCode.pierceDamage = ""; //Damage inflicted thru guard
                    survivalCode.weaponSize = "";
                    survivalCode.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                    survivalCode.counterRate = ""; //Increase Counter Chance
                    survivalCode.nullCounter = ""; //Nullify Enemies Counters chance
                    survivalCode.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                    survivalCode.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                    survivalCode.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                    survivalCode.parryRegen = ""; //Recover Health when successfully Guard Impact
                    survivalCode.guardBreakRate = ""; //Increase Guard Break Chance
                    survivalCode.throwEscapeChance = ""; //Increase Throw Escape Rate
                    survivalCode.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                    survivalCode.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                    survivalCode.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "";
                    survivalCode.stageNumber = 17;
                    survivalCode.model = "02";
                    survivalCode.costume = "08";
                    survivalCode.fightingStyle = "02";
                    survivalCode.weaponNumber = "02"; //Seong Mi-na

                    survivalCode.aiLevel = "03"; // 00-05
                    survivalCode.weaponSpecial = ""; //Fire, Thunder, Paralysis, Cure etc
                    survivalCode.guardianForce = ""; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                    survivalCode.stickyFeet = ""; //Slippery Feets
                    survivalCode.speed = "3F80"; //3F80 default speed

                    survivalCode.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                    survivalCode.attack = ""; //Decrease/Increase Attack
                    survivalCode.defense = ""; //Decrease/Increase Defense
                    survivalCode.stealHp = ""; //Steal health from enemy
                    survivalCode.pierceDamage = ""; //Damage inflicted thru guard
                    survivalCode.weaponSize = "";
                    survivalCode.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                    survivalCode.counterRate = ""; //Increase Counter Chance
                    survivalCode.nullCounter = ""; //Nullify Enemies Counters chance
                    survivalCode.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                    survivalCode.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                    survivalCode.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                    survivalCode.parryRegen = ""; //Recover Health when successfully Guard Impact
                    survivalCode.guardBreakRate = ""; //Increase Guard Break Chance
                    survivalCode.throwEscapeChance = ""; //Increase Throw Escape Rate
                    survivalCode.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                    survivalCode.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                    survivalCode.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "";
                    survivalCode.stageNumber = 18;
                    survivalCode.model = "98";
                    survivalCode.costume = "00";
                    survivalCode.fightingStyle = "4D";
                    survivalCode.weaponNumber = "00"; //Keres

                    survivalCode.aiLevel = "00"; // 00-05
                    survivalCode.weaponSpecial = ""; //Fire, Thunder, Paralysis, Cure etc
                    survivalCode.guardianForce = ""; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                    survivalCode.stickyFeet = ""; //Slippery Feets
                    survivalCode.speed = "3F80"; //3F80 default speed

                    survivalCode.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                    survivalCode.attack = ""; //Decrease/Increase Attack
                    survivalCode.defense = ""; //Decrease/Increase Defense
                    survivalCode.stealHp = ""; //Steal health from enemy
                    survivalCode.pierceDamage = ""; //Damage inflicted thru guard
                    survivalCode.weaponSize = "";
                    survivalCode.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                    survivalCode.counterRate = ""; //Increase Counter Chance
                    survivalCode.nullCounter = ""; //Nullify Enemies Counters chance
                    survivalCode.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                    survivalCode.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                    survivalCode.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                    survivalCode.parryRegen = ""; //Recover Health when successfully Guard Impact
                    survivalCode.guardBreakRate = ""; //Increase Guard Break Chance
                    survivalCode.throwEscapeChance = ""; //Increase Throw Escape Rate
                    survivalCode.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                    survivalCode.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                    survivalCode.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "";
                    survivalCode.stageNumber = 19;
                    survivalCode.model = "A2";
                    survivalCode.costume = "01";
                    survivalCode.fightingStyle = "42";
                    survivalCode.weaponNumber = "01"; //Saizou

                    survivalCode.aiLevel = "03"; // 00-05
                    survivalCode.weaponSpecial = ""; //Fire, Thunder, Paralysis, Cure etc
                    survivalCode.guardianForce = ""; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                    survivalCode.stickyFeet = ""; //Slippery Feets
                    survivalCode.speed = "3F80"; //3F80 default speed

                    survivalCode.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                    survivalCode.attack = ""; //Decrease/Increase Attack
                    survivalCode.defense = ""; //Decrease/Increase Defense
                    survivalCode.stealHp = ""; //Steal health from enemy
                    survivalCode.pierceDamage = ""; //Damage inflicted thru guard
                    survivalCode.weaponSize = "";
                    survivalCode.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                    survivalCode.counterRate = ""; //Increase Counter Chance
                    survivalCode.nullCounter = ""; //Nullify Enemies Counters chance
                    survivalCode.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                    survivalCode.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                    survivalCode.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                    survivalCode.parryRegen = ""; //Recover Health when successfully Guard Impact
                    survivalCode.guardBreakRate = ""; //Increase Guard Break Chance
                    survivalCode.throwEscapeChance = ""; //Increase Throw Escape Rate
                    survivalCode.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                    survivalCode.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                    survivalCode.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "";
                    survivalCode.stageNumber = 20;
                    survivalCode.model = "B6";
                    survivalCode.costume = "02";
                    survivalCode.fightingStyle = "4D";
                    survivalCode.weaponNumber = "06"; //Areon

                    survivalCode.aiLevel = "03"; // 00-05
                    survivalCode.weaponSpecial = ""; //Fire, Thunder, Paralysis, Cure etc
                    survivalCode.guardianForce = ""; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                    survivalCode.stickyFeet = ""; //Slippery Feets
                    survivalCode.speed = "3F82"; //3F80 default speed

                    survivalCode.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                    survivalCode.attack = ""; //Decrease/Increase Attack
                    survivalCode.defense = ""; //Decrease/Increase Defense
                    survivalCode.stealHp = ""; //Steal health from enemy
                    survivalCode.pierceDamage = ""; //Damage inflicted thru guard
                    survivalCode.weaponSize = "3F900000";
                    survivalCode.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                    survivalCode.counterRate = ""; //Increase Counter Chance
                    survivalCode.nullCounter = ""; //Nullify Enemies Counters chance
                    survivalCode.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                    survivalCode.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                    survivalCode.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                    survivalCode.parryRegen = ""; //Recover Health when successfully Guard Impact
                    survivalCode.guardBreakRate = ""; //Increase Guard Break Chance
                    survivalCode.throwEscapeChance = ""; //Increase Throw Escape Rate
                    survivalCode.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                    survivalCode.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                    survivalCode.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                    break;
                #endregion

                #region Expert Arc  [Ende]
                case "Expert Arc":
                    survivalCode.stageLevel = "0015";
                    survivalCode.stageMusic = "15";
                    survivalCode.stageNumber = 1;
                    survivalCode.model = "26";
                    survivalCode.costume = "00";
                    survivalCode.fightingStyle = "26";
                    survivalCode.weaponNumber = "00"; //Abyss

                    survivalCode.aiLevel = "03"; // 00-05
                    survivalCode.weaponSpecial = ""; //Fire, Thunder, Paralysis, Cure etc
                    survivalCode.guardianForce = ""; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                    survivalCode.stickyFeet = ""; //Slippery Feets
                    survivalCode.speed = "3F80"; //3F80 default speed

                    survivalCode.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                    survivalCode.attack = ""; //Decrease/Increase Attack
                    survivalCode.defense = ""; //Decrease/Increase Defense
                    survivalCode.stealHp = ""; //Steal health from enemy
                    survivalCode.pierceDamage = ""; //Damage inflicted thru guard
                    survivalCode.weaponSize = "";
                    survivalCode.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                    survivalCode.counterRate = ""; //Increase Counter Chance
                    survivalCode.nullCounter = ""; //Nullify Enemies Counters chance
                    survivalCode.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                    survivalCode.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                    survivalCode.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                    survivalCode.parryRegen = ""; //Recover Health when successfully Guard Impact
                    survivalCode.guardBreakRate = ""; //Increase Guard Break Chance
                    survivalCode.throwEscapeChance = ""; //Increase Throw Escape Rate
                    survivalCode.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                    survivalCode.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                    survivalCode.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "";
                    survivalCode.stageNumber = 2;
                    survivalCode.model = "03";
                    survivalCode.costume = "08";
                    survivalCode.fightingStyle = "03";
                    survivalCode.weaponNumber = "02"; //Taki

                    survivalCode.aiLevel = "03"; // 00-05
                    survivalCode.weaponSpecial = ""; //Fire, Thunder, Paralysis, Cure etc
                    survivalCode.guardianForce = ""; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                    survivalCode.stickyFeet = ""; //Slippery Feets
                    survivalCode.speed = "3F82"; //3F80 default speed

                    survivalCode.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                    survivalCode.attack = ""; //Decrease/Increase Attack
                    survivalCode.defense = ""; //Decrease/Increase Defense
                    survivalCode.stealHp = ""; //Steal health from enemy
                    survivalCode.pierceDamage = ""; //Damage inflicted thru guard
                    survivalCode.weaponSize = "";
                    survivalCode.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                    survivalCode.counterRate = ""; //Increase Counter Chance
                    survivalCode.nullCounter = ""; //Nullify Enemies Counters chance
                    survivalCode.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                    survivalCode.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                    survivalCode.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                    survivalCode.parryRegen = ""; //Recover Health when successfully Guard Impact
                    survivalCode.guardBreakRate = ""; //Increase Guard Break Chance
                    survivalCode.throwEscapeChance = ""; //Increase Throw Escape Rate
                    survivalCode.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                    survivalCode.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                    survivalCode.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "";
                    survivalCode.stageNumber = 3;
                    survivalCode.model = "1E";
                    survivalCode.costume = "00";
                    survivalCode.fightingStyle = "0E";
                    survivalCode.weaponNumber = "04"; //Lizard Men

                    survivalCode.aiLevel = "03"; // 00-05
                    survivalCode.weaponSpecial = ""; //Fire, Thunder, Paralysis, Cure etc
                    survivalCode.guardianForce = ""; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                    survivalCode.stickyFeet = ""; //Slippery Feets
                    survivalCode.speed = "3F82"; //3F80 default speed

                    survivalCode.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                    survivalCode.attack = ""; //Decrease/Increase Attack
                    survivalCode.defense = ""; //Decrease/Increase Defense
                    survivalCode.stealHp = ""; //Steal health from enemy
                    survivalCode.pierceDamage = ""; //Damage inflicted thru guard
                    survivalCode.weaponSize = "";
                    survivalCode.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                    survivalCode.counterRate = ""; //Increase Counter Chance
                    survivalCode.nullCounter = ""; //Nullify Enemies Counters chance
                    survivalCode.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                    survivalCode.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                    survivalCode.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                    survivalCode.parryRegen = ""; //Recover Health when successfully Guard Impact
                    survivalCode.guardBreakRate = ""; //Increase Guard Break Chance
                    survivalCode.throwEscapeChance = ""; //Increase Throw Escape Rate
                    survivalCode.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                    survivalCode.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                    survivalCode.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "";
                    survivalCode.stageNumber = 4;
                    survivalCode.model = "43";
                    survivalCode.costume = "00";
                    survivalCode.fightingStyle = "43";
                    survivalCode.weaponNumber = "03"; //Arthur

                    survivalCode.aiLevel = "03"; // 00-05
                    survivalCode.weaponSpecial = "Paralysis"; //Fire, Thunder, Paralysis, Cure etc
                    survivalCode.guardianForce = ""; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                    survivalCode.stickyFeet = ""; //Slippery Feets
                    survivalCode.speed = "3F80"; //3F80 default speed

                    survivalCode.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                    survivalCode.attack = ""; //Decrease/Increase Attack
                    survivalCode.defense = ""; //Decrease/Increase Defense
                    survivalCode.stealHp = ""; //Steal health from enemy
                    survivalCode.pierceDamage = ""; //Damage inflicted thru guard
                    survivalCode.weaponSize = "";
                    survivalCode.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                    survivalCode.counterRate = ""; //Increase Counter Chance
                    survivalCode.nullCounter = ""; //Nullify Enemies Counters chance
                    survivalCode.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                    survivalCode.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                    survivalCode.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                    survivalCode.parryRegen = ""; //Recover Health when successfully Guard Impact
                    survivalCode.guardBreakRate = ""; //Increase Guard Break Chance
                    survivalCode.throwEscapeChance = ""; //Increase Throw Escape Rate
                    survivalCode.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                    survivalCode.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                    survivalCode.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "";
                    survivalCode.stageNumber = 5;
                    survivalCode.model = "84";
                    survivalCode.costume = "03";
                    survivalCode.fightingStyle = "43";
                    survivalCode.weaponNumber = "02"; //Samurai 4

                    survivalCode.aiLevel = "03"; // 00-05
                    survivalCode.weaponSpecial = ""; //Fire, Thunder, Paralysis, Cure etc
                    survivalCode.guardianForce = ""; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                    survivalCode.stickyFeet = ""; //Slippery Feets
                    survivalCode.speed = "3F82"; //3F80 default speed

                    survivalCode.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                    survivalCode.attack = ""; //Decrease/Increase Attack
                    survivalCode.defense = ""; //Decrease/Increase Defense
                    survivalCode.stealHp = ""; //Steal health from enemy
                    survivalCode.pierceDamage = ""; //Damage inflicted thru guard
                    survivalCode.weaponSize = "3FB00000";
                    survivalCode.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                    survivalCode.counterRate = ""; //Increase Counter Chance
                    survivalCode.nullCounter = ""; //Nullify Enemies Counters chance
                    survivalCode.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                    survivalCode.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                    survivalCode.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                    survivalCode.parryRegen = ""; //Recover Health when successfully Guard Impact
                    survivalCode.guardBreakRate = ""; //Increase Guard Break Chance
                    survivalCode.throwEscapeChance = ""; //Increase Throw Escape Rate
                    survivalCode.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                    survivalCode.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                    survivalCode.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "0006";
                    survivalCode.stageMusic = "06";
                    survivalCode.stageNumber = 6;
                    survivalCode.model = "B6";
                    survivalCode.costume = "01";
                    survivalCode.fightingStyle = "4D";
                    survivalCode.weaponNumber = "07"; //Aloces

                    survivalCode.aiLevel = "03"; // 00-05
                    survivalCode.weaponSpecial = "All Guard Break"; //Fire, Thunder, Paralysis, Cure etc
                    survivalCode.guardianForce = ""; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                    survivalCode.stickyFeet = ""; //Slippery Feets
                    survivalCode.speed = "3F80"; //3F80 default speed

                    survivalCode.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                    survivalCode.attack = ""; //Decrease/Increase Attack
                    survivalCode.defense = ""; //Decrease/Increase Defense
                    survivalCode.stealHp = ""; //Steal health from enemy
                    survivalCode.pierceDamage = ""; //Damage inflicted thru guard
                    survivalCode.weaponSize = "";
                    survivalCode.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                    survivalCode.counterRate = ""; //Increase Counter Chance
                    survivalCode.nullCounter = ""; //Nullify Enemies Counters chance
                    survivalCode.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                    survivalCode.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                    survivalCode.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                    survivalCode.parryRegen = ""; //Recover Health when successfully Guard Impact
                    survivalCode.guardBreakRate = ""; //Increase Guard Break Chance
                    survivalCode.throwEscapeChance = ""; //Increase Throw Escape Rate
                    survivalCode.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                    survivalCode.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                    survivalCode.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "";
                    survivalCode.stageNumber = 7;
                    survivalCode.model = "E0";
                    survivalCode.costume = "02";
                    survivalCode.fightingStyle = "4E";
                    survivalCode.weaponNumber = "05"; //Abelia

                    survivalCode.aiLevel = "03"; // 00-05
                    survivalCode.weaponSpecial = ""; //Fire, Thunder, Paralysis, Cure etc
                    survivalCode.guardianForce = ""; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                    survivalCode.stickyFeet = ""; //Slippery Feets
                    survivalCode.speed = "3F80"; //3F80 default speed

                    survivalCode.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                    survivalCode.attack = ""; //Decrease/Increase Attack
                    survivalCode.defense = ""; //Decrease/Increase Defense
                    survivalCode.stealHp = ""; //Steal health from enemy
                    survivalCode.pierceDamage = ""; //Damage inflicted thru guard
                    survivalCode.weaponSize = "";
                    survivalCode.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                    survivalCode.counterRate = ""; //Increase Counter Chance
                    survivalCode.nullCounter = ""; //Nullify Enemies Counters chance
                    survivalCode.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                    survivalCode.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                    survivalCode.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                    survivalCode.parryRegen = ""; //Recover Health when successfully Guard Impact
                    survivalCode.guardBreakRate = ""; //Increase Guard Break Chance
                    survivalCode.throwEscapeChance = ""; //Increase Throw Escape Rate
                    survivalCode.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                    survivalCode.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                    survivalCode.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "";
                    survivalCode.stageNumber = 8;
                    survivalCode.model = "2E";
                    survivalCode.costume = "00";
                    survivalCode.fightingStyle = "2E";
                    survivalCode.weaponNumber = "04"; //Shadow Master

                    survivalCode.aiLevel = "03"; // 00-05
                    survivalCode.weaponSpecial = ""; //Fire, Thunder, Paralysis, Cure etc
                    survivalCode.guardianForce = ""; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                    survivalCode.stickyFeet = ""; //Slippery Feets
                    survivalCode.speed = "3F80"; //3F80 default speed

                    survivalCode.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                    survivalCode.attack = ""; //Decrease/Increase Attack
                    survivalCode.defense = ""; //Decrease/Increase Defense
                    survivalCode.stealHp = ""; //Steal health from enemy
                    survivalCode.pierceDamage = ""; //Damage inflicted thru guard
                    survivalCode.weaponSize = "";
                    survivalCode.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                    survivalCode.counterRate = ""; //Increase Counter Chance
                    survivalCode.nullCounter = ""; //Nullify Enemies Counters chance
                    survivalCode.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                    survivalCode.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                    survivalCode.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                    survivalCode.parryRegen = ""; //Recover Health when successfully Guard Impact
                    survivalCode.guardBreakRate = ""; //Increase Guard Break Chance
                    survivalCode.throwEscapeChance = ""; //Increase Throw Escape Rate
                    survivalCode.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                    survivalCode.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                    survivalCode.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "";
                    survivalCode.stageNumber = 9;
                    survivalCode.model = "AE";
                    survivalCode.costume = "00";
                    survivalCode.fightingStyle = "48";
                    survivalCode.weaponNumber = "04"; //Noel

                    survivalCode.aiLevel = "03"; // 00-05
                    survivalCode.weaponSpecial = ""; //Fire, Thunder, Paralysis, Cure etc
                    survivalCode.guardianForce = ""; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                    survivalCode.stickyFeet = ""; //Slippery Feets
                    survivalCode.speed = "3F80"; //3F80 default speed

                    survivalCode.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                    survivalCode.attack = ""; //Decrease/Increase Attack
                    survivalCode.defense = ""; //Decrease/Increase Defense
                    survivalCode.stealHp = ""; //Steal health from enemy
                    survivalCode.pierceDamage = ""; //Damage inflicted thru guard
                    survivalCode.weaponSize = "3FC00000";
                    survivalCode.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                    survivalCode.counterRate = ""; //Increase Counter Chance
                    survivalCode.nullCounter = ""; //Nullify Enemies Counters chance
                    survivalCode.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                    survivalCode.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                    survivalCode.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                    survivalCode.parryRegen = ""; //Recover Health when successfully Guard Impact
                    survivalCode.guardBreakRate = ""; //Increase Guard Break Chance
                    survivalCode.throwEscapeChance = ""; //Increase Throw Escape Rate
                    survivalCode.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                    survivalCode.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                    survivalCode.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "";
                    survivalCode.stageNumber = 10;
                    survivalCode.model = "28";
                    survivalCode.costume = "00";
                    survivalCode.fightingStyle = "28";
                    survivalCode.weaponNumber = "06"; //Charade

                    survivalCode.aiLevel = "03"; // 00-05
                    survivalCode.weaponSpecial = "Cure"; //Fire, Thunder, Paralysis, Cure etc
                    survivalCode.guardianForce = "00"; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                    survivalCode.stickyFeet = ""; //Slippery Feets
                    survivalCode.speed = "3F80"; //3F80 default speed

                    survivalCode.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                    survivalCode.attack = ""; //Decrease/Increase Attack
                    survivalCode.defense = ""; //Decrease/Increase Defense
                    survivalCode.stealHp = ""; //Steal health from enemy
                    survivalCode.pierceDamage = ""; //Damage inflicted thru guard
                    survivalCode.weaponSize = "";
                    survivalCode.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                    survivalCode.counterRate = ""; //Increase Counter Chance
                    survivalCode.nullCounter = ""; //Nullify Enemies Counters chance
                    survivalCode.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                    survivalCode.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                    survivalCode.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                    survivalCode.parryRegen = ""; //Recover Health when successfully Guard Impact
                    survivalCode.guardBreakRate = ""; //Increase Guard Break Chance
                    survivalCode.throwEscapeChance = ""; //Increase Throw Escape Rate
                    survivalCode.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                    survivalCode.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                    survivalCode.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "000E";
                    survivalCode.stageMusic = "0E";
                    survivalCode.stageNumber = 11;
                    survivalCode.model = "81";
                    survivalCode.costume = "00";
                    survivalCode.fightingStyle = "48";
                    survivalCode.weaponNumber = "01"; //Berserker

                    survivalCode.aiLevel = "03"; // 00-05
                    survivalCode.weaponSpecial = ""; //Fire, Thunder, Paralysis, Cure etc
                    survivalCode.guardianForce = ""; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                    survivalCode.stickyFeet = ""; //Slippery Feets
                    survivalCode.speed = "3F80"; //3F80 default speed

                    survivalCode.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                    survivalCode.attack = ""; //Decrease/Increase Attack
                    survivalCode.defense = ""; //Decrease/Increase Defense
                    survivalCode.stealHp = "3F800000"; //Steal health from enemy
                    survivalCode.pierceDamage = ""; //Damage inflicted thru guard
                    survivalCode.weaponSize = "";
                    survivalCode.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                    survivalCode.counterRate = ""; //Increase Counter Chance
                    survivalCode.nullCounter = ""; //Nullify Enemies Counters chance
                    survivalCode.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                    survivalCode.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                    survivalCode.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                    survivalCode.parryRegen = ""; //Recover Health when successfully Guard Impact
                    survivalCode.guardBreakRate = ""; //Increase Guard Break Chance
                    survivalCode.throwEscapeChance = ""; //Increase Throw Escape Rate
                    survivalCode.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                    survivalCode.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                    survivalCode.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "";
                    survivalCode.stageNumber = 12;
                    survivalCode.model = "A6";
                    survivalCode.costume = "00";
                    survivalCode.fightingStyle = "44";
                    survivalCode.weaponNumber = "01"; //Xiaoxin

                    survivalCode.aiLevel = "03"; // 00-05
                    survivalCode.weaponSpecial = "Paralysis"; //Fire, Thunder, Paralysis, Cure etc
                    survivalCode.guardianForce = ""; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                    survivalCode.stickyFeet = ""; //Slippery Feets
                    survivalCode.speed = "3F80"; //3F80 default speed

                    survivalCode.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                    survivalCode.attack = ""; //Decrease/Increase Attack
                    survivalCode.defense = ""; //Decrease/Increase Defense
                    survivalCode.stealHp = ""; //Steal health from enemy
                    survivalCode.pierceDamage = ""; //Damage inflicted thru guard
                    survivalCode.weaponSize = "";
                    survivalCode.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                    survivalCode.counterRate = ""; //Increase Counter Chance
                    survivalCode.nullCounter = ""; //Nullify Enemies Counters chance
                    survivalCode.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                    survivalCode.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                    survivalCode.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                    survivalCode.parryRegen = ""; //Recover Health when successfully Guard Impact
                    survivalCode.guardBreakRate = ""; //Increase Guard Break Chance
                    survivalCode.throwEscapeChance = ""; //Increase Throw Escape Rate
                    survivalCode.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                    survivalCode.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                    survivalCode.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "";
                    survivalCode.stageNumber = 13;
                    survivalCode.model = "AC";
                    survivalCode.costume = "00";
                    survivalCode.fightingStyle = "47";
                    survivalCode.weaponNumber = "02"; //Jyurai

                    survivalCode.aiLevel = "03"; // 00-05
                    survivalCode.weaponSpecial = ""; //Fire, Thunder, Paralysis, Cure etc
                    survivalCode.guardianForce = ""; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                    survivalCode.stickyFeet = ""; //Slippery Feets
                    survivalCode.speed = "3F84"; //3F80 default speed

                    survivalCode.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                    survivalCode.attack = ""; //Decrease/Increase Attack
                    survivalCode.defense = ""; //Decrease/Increase Defense
                    survivalCode.stealHp = ""; //Steal health from enemy
                    survivalCode.pierceDamage = ""; //Damage inflicted thru guard
                    survivalCode.weaponSize = "";
                    survivalCode.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                    survivalCode.counterRate = ""; //Increase Counter Chance
                    survivalCode.nullCounter = ""; //Nullify Enemies Counters chance
                    survivalCode.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                    survivalCode.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                    survivalCode.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                    survivalCode.parryRegen = "3E800000"; //Recover Health when successfully Guard Impact
                    survivalCode.guardBreakRate = ""; //Increase Guard Break Chance
                    survivalCode.throwEscapeChance = "3EA00000"; //Increase Throw Escape Rate
                    survivalCode.ringOutEscapeChance = "3F000000"; //Increase Ring-Out Escape Rate
                    survivalCode.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                    survivalCode.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "";
                    survivalCode.stageNumber = 14;
                    survivalCode.model = "EA";
                    survivalCode.costume = "01";
                    survivalCode.fightingStyle = "48";
                    survivalCode.weaponNumber = "02"; //Lupi

                    survivalCode.aiLevel = "03"; // 00-05
                    survivalCode.weaponSpecial = ""; //Fire, Thunder, Paralysis, Cure etc
                    survivalCode.guardianForce = ""; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                    survivalCode.stickyFeet = ""; //Slippery Feets
                    survivalCode.speed = "3F80"; //3F80 default speed

                    survivalCode.weaponEffect = "00080000"; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                    survivalCode.attack = ""; //Decrease/Increase Attack
                    survivalCode.defense = "3F400000"; //Decrease/Increase Defense
                    survivalCode.stealHp = ""; //Steal health from enemy
                    survivalCode.pierceDamage = "3F000000"; //Damage inflicted thru guard
                    survivalCode.weaponSize = "";
                    survivalCode.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                    survivalCode.counterRate = ""; //Increase Counter Chance
                    survivalCode.nullCounter = ""; //Nullify Enemies Counters chance
                    survivalCode.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                    survivalCode.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                    survivalCode.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                    survivalCode.parryRegen = ""; //Recover Health when successfully Guard Impact
                    survivalCode.guardBreakRate = ""; //Increase Guard Break Chance
                    survivalCode.throwEscapeChance = ""; //Increase Throw Escape Rate
                    survivalCode.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                    survivalCode.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                    survivalCode.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "";
                    survivalCode.stageNumber = 15;
                    survivalCode.model = "EF";
                    survivalCode.costume = "01";
                    survivalCode.fightingStyle = "01";
                    survivalCode.weaponNumber = "02"; //Yotory

                    survivalCode.aiLevel = "03"; // 00-05
                    survivalCode.weaponSpecial = ""; //Fire, Thunder, Paralysis, Cure etc
                    survivalCode.guardianForce = ""; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                    survivalCode.stickyFeet = ""; //Slippery Feets
                    survivalCode.speed = "3F80"; //3F80 default speed

                    survivalCode.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                    survivalCode.attack = ""; //Decrease/Increase Attack
                    survivalCode.defense = ""; //Decrease/Increase Defense
                    survivalCode.stealHp = ""; //Steal health from enemy
                    survivalCode.pierceDamage = "3E000000"; //Damage inflicted thru guard
                    survivalCode.weaponSize = "3FA00000";
                    survivalCode.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                    survivalCode.counterRate = ""; //Increase Counter Chance
                    survivalCode.nullCounter = ""; //Nullify Enemies Counters chance
                    survivalCode.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                    survivalCode.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                    survivalCode.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                    survivalCode.parryRegen = ""; //Recover Health when successfully Guard Impact
                    survivalCode.guardBreakRate = ""; //Increase Guard Break Chance
                    survivalCode.throwEscapeChance = ""; //Increase Throw Escape Rate
                    survivalCode.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                    survivalCode.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                    survivalCode.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "0017";
                    survivalCode.stageMusic = "17";
                    survivalCode.stageNumber = 16;
                    survivalCode.model = "EC";
                    survivalCode.costume = "01";
                    survivalCode.fightingStyle = "46";
                    survivalCode.weaponNumber = "06"; //Kierkess

                    survivalCode.aiLevel = "03"; // 00-05
                    survivalCode.weaponSpecial = "All Unblockable"; //Fire, Thunder, Paralysis, Cure etc
                    survivalCode.guardianForce = ""; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                    survivalCode.stickyFeet = ""; //Slippery Feets
                    survivalCode.speed = "3F7E"; //3F80 default speed

                    survivalCode.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                    survivalCode.attack = ""; //Decrease/Increase Attack
                    survivalCode.defense = "3FB00000"; //Decrease/Increase Defense
                    survivalCode.stealHp = ""; //Steal health from enemy
                    survivalCode.pierceDamage = ""; //Damage inflicted thru guard
                    survivalCode.weaponSize = "";
                    survivalCode.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                    survivalCode.counterRate = ""; //Increase Counter Chance
                    survivalCode.nullCounter = ""; //Nullify Enemies Counters chance
                    survivalCode.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                    survivalCode.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                    survivalCode.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                    survivalCode.parryRegen = ""; //Recover Health when successfully Guard Impact
                    survivalCode.guardBreakRate = ""; //Increase Guard Break Chance
                    survivalCode.throwEscapeChance = ""; //Increase Throw Escape Rate
                    survivalCode.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                    survivalCode.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                    survivalCode.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "";
                    survivalCode.stageNumber = 17;
                    survivalCode.model = "E9";
                    survivalCode.costume = "01";
                    survivalCode.fightingStyle = "42";
                    survivalCode.weaponNumber = "02"; //Elua

                    survivalCode.aiLevel = "03"; // 00-05
                    survivalCode.weaponSpecial = ""; //Fire, Thunder, Paralysis, Cure etc
                    survivalCode.guardianForce = ""; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                    survivalCode.stickyFeet = ""; //Slippery Feets
                    survivalCode.speed = "3F86"; //3F80 default speed

                    survivalCode.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                    survivalCode.attack = ""; //Decrease/Increase Attack
                    survivalCode.defense = ""; //Decrease/Increase Defense
                    survivalCode.stealHp = ""; //Steal health from enemy
                    survivalCode.pierceDamage = ""; //Damage inflicted thru guard
                    survivalCode.weaponSize = "";
                    survivalCode.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                    survivalCode.counterRate = ""; //Increase Counter Chance
                    survivalCode.nullCounter = ""; //Nullify Enemies Counters chance
                    survivalCode.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                    survivalCode.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                    survivalCode.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                    survivalCode.parryRegen = ""; //Recover Health when successfully Guard Impact
                    survivalCode.guardBreakRate = ""; //Increase Guard Break Chance
                    survivalCode.throwEscapeChance = ""; //Increase Throw Escape Rate
                    survivalCode.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                    survivalCode.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                    survivalCode.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "";
                    survivalCode.stageNumber = 18;
                    survivalCode.model = "BC";
                    survivalCode.costume = "01";
                    survivalCode.fightingStyle = "51";
                    survivalCode.weaponNumber = "03"; //Yakumo

                    survivalCode.aiLevel = "03"; // 00-05
                    survivalCode.weaponSpecial = "All Guard Break"; //Fire, Thunder, Paralysis, Cure etc
                    survivalCode.guardianForce = ""; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                    survivalCode.stickyFeet = ""; //Slippery Feets
                    survivalCode.speed = "3F84"; //3F80 default speed

                    survivalCode.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                    survivalCode.attack = ""; //Decrease/Increase Attack
                    survivalCode.defense = ""; //Decrease/Increase Defense
                    survivalCode.stealHp = ""; //Steal health from enemy
                    survivalCode.pierceDamage = ""; //Damage inflicted thru guard
                    survivalCode.weaponSize = "";
                    survivalCode.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                    survivalCode.counterRate = ""; //Increase Counter Chance
                    survivalCode.nullCounter = ""; //Nullify Enemies Counters chance
                    survivalCode.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                    survivalCode.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                    survivalCode.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                    survivalCode.parryRegen = ""; //Recover Health when successfully Guard Impact
                    survivalCode.guardBreakRate = ""; //Increase Guard Break Chance
                    survivalCode.throwEscapeChance = ""; //Increase Throw Escape Rate
                    survivalCode.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                    survivalCode.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                    survivalCode.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "";
                    survivalCode.stageNumber = 19;
                    survivalCode.model = "11";
                    survivalCode.costume = "00";
                    survivalCode.fightingStyle = "11";
                    survivalCode.weaponNumber = "05"; //Nightmare

                    survivalCode.aiLevel = "03"; // 00-05
                    survivalCode.weaponSpecial = ""; //Fire, Thunder, Paralysis, Cure etc
                    survivalCode.guardianForce = ""; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                    survivalCode.stickyFeet = ""; //Slippery Feets
                    survivalCode.speed = "3F86"; //3F80 default speed

                    survivalCode.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                    survivalCode.attack = "40000000"; //Decrease/Increase Attack
                    survivalCode.defense = ""; //Decrease/Increase Defense
                    survivalCode.stealHp = ""; //Steal health from enemy
                    survivalCode.pierceDamage = ""; //Damage inflicted thru guard
                    survivalCode.weaponSize = "";
                    survivalCode.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                    survivalCode.counterRate = ""; //Increase Counter Chance
                    survivalCode.nullCounter = ""; //Nullify Enemies Counters chance
                    survivalCode.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                    survivalCode.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                    survivalCode.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                    survivalCode.parryRegen = ""; //Recover Health when successfully Guard Impact
                    survivalCode.guardBreakRate = ""; //Increase Guard Break Chance
                    survivalCode.throwEscapeChance = ""; //Increase Throw Escape Rate
                    survivalCode.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                    survivalCode.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                    survivalCode.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "";
                    survivalCode.stageNumber = 20;
                    survivalCode.model = "EF";
                    survivalCode.costume = "00";
                    survivalCode.fightingStyle = "43";
                    survivalCode.weaponNumber = "06"; //Ende

                    survivalCode.aiLevel = "04"; // 00-05
                    survivalCode.weaponSpecial = "Paralysis"; //Fire, Thunder, Paralysis, Cure etc
                    survivalCode.guardianForce = ""; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                    survivalCode.stickyFeet = ""; //Slippery Feets
                    survivalCode.speed = "3F88"; //3F80 default speed

                    survivalCode.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                    survivalCode.attack = ""; //Decrease/Increase Attack
                    survivalCode.defense = ""; //Decrease/Increase Defense
                    survivalCode.stealHp = ""; //Steal health from enemy
                    survivalCode.pierceDamage = ""; //Damage inflicted thru guard
                    survivalCode.weaponSize = "";
                    survivalCode.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                    survivalCode.counterRate = ""; //Increase Counter Chance
                    survivalCode.nullCounter = ""; //Nullify Enemies Counters chance
                    survivalCode.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                    survivalCode.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                    survivalCode.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                    survivalCode.parryRegen = ""; //Recover Health when successfully Guard Impact
                    survivalCode.guardBreakRate = ""; //Increase Guard Break Chance
                    survivalCode.throwEscapeChance = ""; //Increase Throw Escape Rate
                    survivalCode.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                    survivalCode.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                    survivalCode.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                    break;
                #endregion

                #region Master Arc  [Abyss]
                case "Master Arc":
                    survivalCode.stageLevel = "0210";
                    survivalCode.stageMusic = "10";
                    survivalCode.stageNumber = 1;
                    survivalCode.model = "EF";
                    survivalCode.costume = "01";
                    survivalCode.fightingStyle = "01";
                    survivalCode.weaponNumber = "05"; //Yotory

                    survivalCode.aiLevel = "04"; // 00-05
                    survivalCode.weaponSpecial = "All Guard Break"; //Fire, Thunder, Paralysis, Cure etc
                    survivalCode.guardianForce = ""; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                    survivalCode.stickyFeet = ""; //Slippery Feets
                    survivalCode.speed = "3F80"; //3F80 default speed

                    survivalCode.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                    survivalCode.attack = ""; //Decrease/Increase Attack
                    survivalCode.defense = ""; //Decrease/Increase Defense
                    survivalCode.stealHp = ""; //Steal health from enemy
                    survivalCode.pierceDamage = "3D000000"; //Damage inflicted thru guard
                    survivalCode.weaponSize = "";
                    survivalCode.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                    survivalCode.counterRate = ""; //Increase Counter Chance
                    survivalCode.nullCounter = ""; //Nullify Enemies Counters chance
                    survivalCode.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                    survivalCode.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                    survivalCode.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                    survivalCode.parryRegen = ""; //Recover Health when successfully Guard Impact
                    survivalCode.guardBreakRate = ""; //Increase Guard Break Chance
                    survivalCode.throwEscapeChance = ""; //Increase Throw Escape Rate
                    survivalCode.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                    survivalCode.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                    survivalCode.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "";
                    survivalCode.stageNumber = 2;
                    survivalCode.model = "B4";
                    survivalCode.costume = "01";
                    survivalCode.fightingStyle = "4C";
                    survivalCode.weaponNumber = "05"; //Celestis

                    survivalCode.aiLevel = "04"; // 00-05
                    survivalCode.weaponSpecial = "Cure"; //Fire, Thunder, Paralysis, Cure etc
                    survivalCode.guardianForce = ""; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                    survivalCode.stickyFeet = ""; //Slippery Feets
                    survivalCode.speed = "3F82"; //3F80 default speed

                    survivalCode.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                    survivalCode.attack = ""; //Decrease/Increase Attack
                    survivalCode.defense = ""; //Decrease/Increase Defense
                    survivalCode.stealHp = ""; //Steal health from enemy
                    survivalCode.pierceDamage = ""; //Damage inflicted thru guard
                    survivalCode.weaponSize = "";
                    survivalCode.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                    survivalCode.counterRate = ""; //Increase Counter Chance
                    survivalCode.nullCounter = ""; //Nullify Enemies Counters chance
                    survivalCode.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                    survivalCode.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                    survivalCode.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                    survivalCode.parryRegen = ""; //Recover Health when successfully Guard Impact
                    survivalCode.guardBreakRate = ""; //Increase Guard Break Chance
                    survivalCode.throwEscapeChance = ""; //Increase Throw Escape Rate
                    survivalCode.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                    survivalCode.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                    survivalCode.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "";
                    survivalCode.stageNumber = 3;
                    survivalCode.model = "96";
                    survivalCode.costume = "00";
                    survivalCode.fightingStyle = "4D";
                    survivalCode.weaponNumber = "03"; //General

                    survivalCode.aiLevel = "03"; // 00-05
                    survivalCode.weaponSpecial = ""; //Fire, Thunder, Paralysis, Cure etc
                    survivalCode.guardianForce = "06"; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06, Soul Armor custom 06
                    survivalCode.stickyFeet = ""; //Slippery Feets
                    survivalCode.speed = "3F80"; //3F80 default speed

                    survivalCode.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                    survivalCode.attack = ""; //Decrease/Increase Attack
                    survivalCode.defense = ""; //Decrease/Increase Defense
                    survivalCode.stealHp = ""; //Steal health from enemy
                    survivalCode.pierceDamage = ""; //Damage inflicted thru guard
                    survivalCode.weaponSize = "";
                    survivalCode.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                    survivalCode.counterRate = ""; //Increase Counter Chance
                    survivalCode.nullCounter = ""; //Nullify Enemies Counters chance
                    survivalCode.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                    survivalCode.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                    survivalCode.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                    survivalCode.parryRegen = ""; //Recover Health when successfully Guard Impact
                    survivalCode.guardBreakRate = ""; //Increase Guard Break Chance
                    survivalCode.throwEscapeChance = ""; //Increase Throw Escape Rate
                    survivalCode.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                    survivalCode.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                    survivalCode.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "";
                    survivalCode.stageNumber = 4;
                    survivalCode.model = "2E";
                    survivalCode.costume = "00";
                    survivalCode.fightingStyle = "2E";
                    survivalCode.weaponNumber = "05"; //Shadow Master

                    survivalCode.aiLevel = "04"; // 00-05
                    survivalCode.weaponSpecial = "All Guard Break"; //Fire, Thunder, Paralysis, Cure etc
                    survivalCode.guardianForce = ""; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                    survivalCode.stickyFeet = ""; //Slippery Feets
                    survivalCode.speed = "3F80"; //3F80 default speed

                    survivalCode.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                    survivalCode.attack = ""; //Decrease/Increase Attack
                    survivalCode.defense = ""; //Decrease/Increase Defense
                    survivalCode.stealHp = ""; //Steal health from enemy
                    survivalCode.pierceDamage = ""; //Damage inflicted thru guard
                    survivalCode.weaponSize = "";
                    survivalCode.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                    survivalCode.counterRate = ""; //Increase Counter Chance
                    survivalCode.nullCounter = ""; //Nullify Enemies Counters chance
                    survivalCode.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                    survivalCode.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                    survivalCode.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                    survivalCode.parryRegen = ""; //Recover Health when successfully Guard Impact
                    survivalCode.guardBreakRate = ""; //Increase Guard Break Chance
                    survivalCode.throwEscapeChance = ""; //Increase Throw Escape Rate
                    survivalCode.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                    survivalCode.hpRegenOrDrain = "3C000000"; //Drain/Recover Health over Time
                    survivalCode.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "";
                    survivalCode.stageNumber = 5;
                    survivalCode.model = "48";
                    survivalCode.costume = "01";
                    survivalCode.fightingStyle = "48";
                    survivalCode.weaponNumber = "03"; //Girardot

                    survivalCode.aiLevel = "04"; // 00-05
                    survivalCode.weaponSpecial = "All Unblockable"; //Fire, Thunder, Paralysis, Cure etc
                    survivalCode.guardianForce = ""; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                    survivalCode.stickyFeet = ""; //Slippery Feets
                    survivalCode.speed = "3F60"; //3F80 default speed

                    survivalCode.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                    survivalCode.attack = ""; //Decrease/Increase Attack
                    survivalCode.defense = ""; //Decrease/Increase Defense
                    survivalCode.stealHp = ""; //Steal health from enemy
                    survivalCode.pierceDamage = ""; //Damage inflicted thru guard
                    survivalCode.weaponSize = "";
                    survivalCode.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                    survivalCode.counterRate = ""; //Increase Counter Chance
                    survivalCode.nullCounter = ""; //Nullify Enemies Counters chance
                    survivalCode.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                    survivalCode.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                    survivalCode.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                    survivalCode.parryRegen = ""; //Recover Health when successfully Guard Impact
                    survivalCode.guardBreakRate = ""; //Increase Guard Break Chance
                    survivalCode.throwEscapeChance = ""; //Increase Throw Escape Rate
                    survivalCode.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                    survivalCode.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                    survivalCode.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "0014";
                    survivalCode.stageMusic = "16";
                    survivalCode.stageNumber = 6;
                    survivalCode.model = "A0";
                    survivalCode.costume = "01";
                    survivalCode.fightingStyle = "41";
                    survivalCode.weaponNumber = "04"; //Kagami

                    survivalCode.aiLevel = "04"; // 00-05
                    survivalCode.weaponSpecial = "All Guard Break"; //Fire, Thunder, Paralysis, Cure etc
                    survivalCode.guardianForce = ""; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                    survivalCode.stickyFeet = ""; //Slippery Feets
                    survivalCode.speed = "3F86"; //3F80 default speed

                    survivalCode.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                    survivalCode.attack = ""; //Decrease/Increase Attack
                    survivalCode.defense = ""; //Decrease/Increase Defense
                    survivalCode.stealHp = ""; //Steal health from enemy
                    survivalCode.pierceDamage = ""; //Damage inflicted thru guard
                    survivalCode.weaponSize = "";
                    survivalCode.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                    survivalCode.counterRate = ""; //Increase Counter Chance
                    survivalCode.nullCounter = ""; //Nullify Enemies Counters chance
                    survivalCode.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                    survivalCode.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                    survivalCode.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                    survivalCode.parryRegen = ""; //Recover Health when successfully Guard Impact
                    survivalCode.guardBreakRate = ""; //Increase Guard Break Chance
                    survivalCode.throwEscapeChance = ""; //Increase Throw Escape Rate
                    survivalCode.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                    survivalCode.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                    survivalCode.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "";
                    survivalCode.stageNumber = 7;
                    survivalCode.model = "AF";
                    survivalCode.costume = "00";
                    survivalCode.fightingStyle = "48";
                    survivalCode.weaponNumber = "06"; //Annaretta

                    survivalCode.aiLevel = "04"; // 00-05
                    survivalCode.weaponSpecial = ""; //Fire, Thunder, Paralysis, Cure etc
                    survivalCode.guardianForce = ""; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                    survivalCode.stickyFeet = ""; //Slippery Feets
                    survivalCode.speed = "3F80"; //3F80 default speed

                    survivalCode.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                    survivalCode.attack = ""; //Decrease/Increase Attack
                    survivalCode.defense = ""; //Decrease/Increase Defense
                    survivalCode.stealHp = ""; //Steal health from enemy
                    survivalCode.pierceDamage = ""; //Damage inflicted thru guard
                    survivalCode.weaponSize = "3FC00000";
                    survivalCode.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                    survivalCode.counterRate = ""; //Increase Counter Chance
                    survivalCode.nullCounter = ""; //Nullify Enemies Counters chance
                    survivalCode.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                    survivalCode.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                    survivalCode.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                    survivalCode.parryRegen = ""; //Recover Health when successfully Guard Impact
                    survivalCode.guardBreakRate = ""; //Increase Guard Break Chance
                    survivalCode.throwEscapeChance = ""; //Increase Throw Escape Rate
                    survivalCode.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                    survivalCode.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                    survivalCode.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "";
                    survivalCode.stageNumber = 8;
                    survivalCode.model = "A4";
                    survivalCode.costume = "02";
                    survivalCode.fightingStyle = "43";
                    survivalCode.weaponNumber = "06"; //Shizuma

                    survivalCode.aiLevel = "04"; // 00-05
                    survivalCode.weaponSpecial = ""; //Fire, Thunder, Paralysis, Cure etc
                    survivalCode.guardianForce = "04"; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                    survivalCode.stickyFeet = ""; //Slippery Feets
                    survivalCode.speed = "3FA8"; //3F80 default speed

                    survivalCode.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                    survivalCode.attack = ""; //Decrease/Increase Attack
                    survivalCode.defense = ""; //Decrease/Increase Defense
                    survivalCode.stealHp = ""; //Steal health from enemy
                    survivalCode.pierceDamage = ""; //Damage inflicted thru guard
                    survivalCode.weaponSize = "";
                    survivalCode.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                    survivalCode.counterRate = ""; //Increase Counter Chance
                    survivalCode.nullCounter = ""; //Nullify Enemies Counters chance
                    survivalCode.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                    survivalCode.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                    survivalCode.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                    survivalCode.parryRegen = ""; //Recover Health when successfully Guard Impact
                    survivalCode.guardBreakRate = ""; //Increase Guard Break Chance
                    survivalCode.throwEscapeChance = ""; //Increase Throw Escape Rate
                    survivalCode.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                    survivalCode.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                    survivalCode.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "";
                    survivalCode.stageNumber = 9;
                    survivalCode.model = "AA";
                    survivalCode.costume = "01";
                    survivalCode.fightingStyle = "46";
                    survivalCode.weaponNumber = "04"; //Notus

                    survivalCode.aiLevel = "04"; // 00-05
                    survivalCode.weaponSpecial = "Paralysis"; //Fire, Thunder, Paralysis, Cure etc
                    survivalCode.guardianForce = ""; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                    survivalCode.stickyFeet = ""; //Slippery Feets
                    survivalCode.speed = "3F80"; //3F80 default speed

                    survivalCode.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                    survivalCode.attack = ""; //Decrease/Increase Attack
                    survivalCode.defense = "3F000000"; //Decrease/Increase Defense
                    survivalCode.stealHp = ""; //Steal health from enemy
                    survivalCode.pierceDamage = ""; //Damage inflicted thru guard
                    survivalCode.weaponSize = "";
                    survivalCode.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                    survivalCode.counterRate = ""; //Increase Counter Chance
                    survivalCode.nullCounter = ""; //Nullify Enemies Counters chance
                    survivalCode.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                    survivalCode.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                    survivalCode.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                    survivalCode.parryRegen = ""; //Recover Health when successfully Guard Impact
                    survivalCode.guardBreakRate = ""; //Increase Guard Break Chance
                    survivalCode.throwEscapeChance = ""; //Increase Throw Escape Rate
                    survivalCode.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                    survivalCode.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                    survivalCode.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "";
                    survivalCode.stageNumber = 10;
                    survivalCode.model = "31";
                    survivalCode.costume = "00";
                    survivalCode.fightingStyle = "31";
                    survivalCode.weaponNumber = "00"; //Colossus

                    survivalCode.aiLevel = "04"; // 00-05
                    survivalCode.weaponSpecial = ""; //Fire, Thunder, Paralysis, Cure etc
                    survivalCode.guardianForce = ""; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                    survivalCode.stickyFeet = ""; //Slippery Feets
                    survivalCode.speed = "3F80"; //3F80 default speed

                    survivalCode.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                    survivalCode.attack = ""; //Decrease/Increase Attack
                    survivalCode.defense = ""; //Decrease/Increase Defense
                    survivalCode.stealHp = ""; //Steal health from enemy
                    survivalCode.pierceDamage = ""; //Damage inflicted thru guard
                    survivalCode.weaponSize = "";
                    survivalCode.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                    survivalCode.counterRate = ""; //Increase Counter Chance
                    survivalCode.nullCounter = ""; //Nullify Enemies Counters chance
                    survivalCode.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                    survivalCode.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                    survivalCode.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                    survivalCode.parryRegen = ""; //Recover Health when successfully Guard Impact
                    survivalCode.guardBreakRate = ""; //Increase Guard Break Chance
                    survivalCode.throwEscapeChance = ""; //Increase Throw Escape Rate
                    survivalCode.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                    survivalCode.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                    survivalCode.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "0005";
                    survivalCode.stageMusic = "05";
                    survivalCode.stageNumber = 11;
                    survivalCode.model = "8E";
                    survivalCode.costume = "00";
                    survivalCode.fightingStyle = "4B";
                    survivalCode.weaponNumber = "05"; //Bandit 2

                    survivalCode.aiLevel = "04"; // 00-05
                    survivalCode.weaponSpecial = ""; //Fire, Thunder, Paralysis, Cure etc
                    survivalCode.guardianForce = ""; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                    survivalCode.stickyFeet = ""; //Slippery Feets
                    survivalCode.speed = "3F80"; //3F80 default speed

                    survivalCode.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                    survivalCode.attack = ""; //Decrease/Increase Attack
                    survivalCode.defense = ""; //Decrease/Increase Defense
                    survivalCode.stealHp = "3F000000"; //Steal health from enemy
                    survivalCode.pierceDamage = "3E000000"; //Damage inflicted thru guard
                    survivalCode.weaponSize = "";
                    survivalCode.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                    survivalCode.counterRate = ""; //Increase Counter Chance
                    survivalCode.nullCounter = ""; //Nullify Enemies Counters chance
                    survivalCode.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                    survivalCode.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                    survivalCode.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                    survivalCode.parryRegen = ""; //Recover Health when successfully Guard Impact
                    survivalCode.guardBreakRate = ""; //Increase Guard Break Chance
                    survivalCode.throwEscapeChance = ""; //Increase Throw Escape Rate
                    survivalCode.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                    survivalCode.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                    survivalCode.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "";
                    survivalCode.stageNumber = 12;
                    survivalCode.model = "07";
                    survivalCode.costume = "01";
                    survivalCode.fightingStyle = "07";
                    survivalCode.weaponNumber = "05"; //Siegfried

                    survivalCode.aiLevel = "04"; // 00-05
                    survivalCode.weaponSpecial = ""; //Fire, Thunder, Paralysis, Cure etc
                    survivalCode.guardianForce = ""; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                    survivalCode.stickyFeet = ""; //Slippery Feets
                    survivalCode.speed = "3F80"; //3F80 default speed

                    survivalCode.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                    survivalCode.attack = ""; //Decrease/Increase Attack
                    survivalCode.defense = "3F200000"; //Decrease/Increase Defense
                    survivalCode.stealHp = ""; //Steal health from enemy
                    survivalCode.pierceDamage = ""; //Damage inflicted thru guard
                    survivalCode.weaponSize = "";
                    survivalCode.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                    survivalCode.counterRate = ""; //Increase Counter Chance
                    survivalCode.nullCounter = ""; //Nullify Enemies Counters chance
                    survivalCode.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                    survivalCode.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                    survivalCode.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                    survivalCode.parryRegen = ""; //Recover Health when successfully Guard Impact
                    survivalCode.guardBreakRate = ""; //Increase Guard Break Chance
                    survivalCode.throwEscapeChance = ""; //Increase Throw Escape Rate
                    survivalCode.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                    survivalCode.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                    survivalCode.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "";
                    survivalCode.stageNumber = 13;
                    survivalCode.model = "24";
                    survivalCode.costume = "01";
                    survivalCode.fightingStyle = "24";
                    survivalCode.weaponNumber = "05"; //Zasalamel

                    survivalCode.aiLevel = "04"; // 00-05
                    survivalCode.weaponSpecial = "All Unblockable"; //Fire, Thunder, Paralysis, Cure etc
                    survivalCode.guardianForce = ""; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                    survivalCode.stickyFeet = ""; //Slippery Feets
                    survivalCode.speed = "3F80"; //3F80 default speed

                    survivalCode.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                    survivalCode.attack = ""; //Decrease/Increase Attack
                    survivalCode.defense = ""; //Decrease/Increase Defense
                    survivalCode.stealHp = ""; //Steal health from enemy
                    survivalCode.pierceDamage = ""; //Damage inflicted thru guard
                    survivalCode.weaponSize = "";
                    survivalCode.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                    survivalCode.counterRate = ""; //Increase Counter Chance
                    survivalCode.nullCounter = ""; //Nullify Enemies Counters chance
                    survivalCode.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                    survivalCode.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                    survivalCode.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                    survivalCode.parryRegen = ""; //Recover Health when successfully Guard Impact
                    survivalCode.guardBreakRate = ""; //Increase Guard Break Chance
                    survivalCode.throwEscapeChance = ""; //Increase Throw Escape Rate
                    survivalCode.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                    survivalCode.hpRegenOrDrain = "B4000000"; //Drain/Recover Health over Time
                    survivalCode.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "";
                    survivalCode.stageNumber = 14;
                    survivalCode.model = "15";
                    survivalCode.costume = "01";
                    survivalCode.fightingStyle = "15";
                    survivalCode.weaponNumber = "05"; //Raphael

                    survivalCode.aiLevel = "04"; // 00-05
                    survivalCode.weaponSpecial = ""; //Fire, Thunder, Paralysis, Cure etc
                    survivalCode.guardianForce = ""; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                    survivalCode.stickyFeet = ""; //Slippery Feets
                    survivalCode.speed = "3F80"; //3F80 default speed

                    survivalCode.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                    survivalCode.attack = ""; //Decrease/Increase Attack
                    survivalCode.defense = ""; //Decrease/Increase Defense
                    survivalCode.stealHp = ""; //Steal health from enemy
                    survivalCode.pierceDamage = ""; //Damage inflicted thru guard
                    survivalCode.weaponSize = "";
                    survivalCode.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                    survivalCode.counterRate = ""; //Increase Counter Chance
                    survivalCode.nullCounter = ""; //Nullify Enemies Counters chance
                    survivalCode.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                    survivalCode.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                    survivalCode.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                    survivalCode.parryRegen = ""; //Recover Health when successfully Guard Impact
                    survivalCode.guardBreakRate = ""; //Increase Guard Break Chance
                    survivalCode.throwEscapeChance = ""; //Increase Throw Escape Rate
                    survivalCode.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                    survivalCode.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                    survivalCode.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "";
                    survivalCode.stageNumber = 15;
                    survivalCode.model = "EB";
                    survivalCode.costume = "01";
                    survivalCode.fightingStyle = "48";
                    survivalCode.weaponNumber = "07"; //Roin

                    survivalCode.aiLevel = "04"; // 00-05
                    survivalCode.weaponSpecial = ""; //Fire, Thunder, Paralysis, Cure etc
                    survivalCode.guardianForce = ""; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                    survivalCode.stickyFeet = ""; //Slippery Feets
                    survivalCode.speed = "3F84"; //3F80 default speed

                    survivalCode.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                    survivalCode.attack = ""; //Decrease/Increase Attack
                    survivalCode.defense = ""; //Decrease/Increase Defense
                    survivalCode.stealHp = ""; //Steal health from enemy
                    survivalCode.pierceDamage = ""; //Damage inflicted thru guard
                    survivalCode.weaponSize = "40000000";
                    survivalCode.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                    survivalCode.counterRate = ""; //Increase Counter Chance
                    survivalCode.nullCounter = ""; //Nullify Enemies Counters chance
                    survivalCode.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                    survivalCode.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                    survivalCode.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                    survivalCode.parryRegen = ""; //Recover Health when successfully Guard Impact
                    survivalCode.guardBreakRate = ""; //Increase Guard Break Chance
                    survivalCode.throwEscapeChance = ""; //Increase Throw Escape Rate
                    survivalCode.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                    survivalCode.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                    survivalCode.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "0101";
                    survivalCode.stageMusic = "15";
                    survivalCode.stageNumber = 16;
                    survivalCode.model = "B8";
                    survivalCode.costume = "00";
                    survivalCode.fightingStyle = "4E";
                    survivalCode.weaponNumber = "05"; //Rufus

                    survivalCode.aiLevel = "05"; // 00-05
                    survivalCode.weaponSpecial = ""; //Fire, Thunder, Paralysis, Cure etc
                    survivalCode.guardianForce = ""; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                    survivalCode.stickyFeet = ""; //Slippery Feets
                    survivalCode.speed = "3F80"; //3F80 default speed

                    survivalCode.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                    survivalCode.attack = ""; //Decrease/Increase Attack
                    survivalCode.defense = ""; //Decrease/Increase Defense
                    survivalCode.stealHp = ""; //Steal health from enemy
                    survivalCode.pierceDamage = ""; //Damage inflicted thru guard
                    survivalCode.weaponSize = "";
                    survivalCode.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                    survivalCode.counterRate = ""; //Increase Counter Chance
                    survivalCode.nullCounter = ""; //Nullify Enemies Counters chance
                    survivalCode.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                    survivalCode.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                    survivalCode.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                    survivalCode.parryRegen = ""; //Recover Health when successfully Guard Impact
                    survivalCode.guardBreakRate = ""; //Increase Guard Break Chance
                    survivalCode.throwEscapeChance = ""; //Increase Throw Escape Rate
                    survivalCode.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                    survivalCode.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                    survivalCode.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "";
                    survivalCode.stageNumber = 17;
                    survivalCode.model = "8C";
                    survivalCode.costume = "03";
                    survivalCode.fightingStyle = "41";
                    survivalCode.weaponNumber = "04"; //Fu-ma Ninja 7

                    survivalCode.aiLevel = "05"; // 00-05
                    survivalCode.weaponSpecial = ""; //Fire, Thunder, Paralysis, Cure etc
                    survivalCode.guardianForce = ""; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                    survivalCode.stickyFeet = ""; //Slippery Feets
                    survivalCode.speed = "3F80"; //3F80 default speed

                    survivalCode.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                    survivalCode.attack = ""; //Decrease/Increase Attack
                    survivalCode.defense = ""; //Decrease/Increase Defense
                    survivalCode.stealHp = ""; //Steal health from enemy
                    survivalCode.pierceDamage = ""; //Damage inflicted thru guard
                    survivalCode.weaponSize = "";
                    survivalCode.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                    survivalCode.counterRate = ""; //Increase Counter Chance
                    survivalCode.nullCounter = ""; //Nullify Enemies Counters chance
                    survivalCode.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                    survivalCode.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                    survivalCode.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                    survivalCode.parryRegen = ""; //Recover Health when successfully Guard Impact
                    survivalCode.guardBreakRate = ""; //Increase Guard Break Chance
                    survivalCode.throwEscapeChance = ""; //Increase Throw Escape Rate
                    survivalCode.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                    survivalCode.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                    survivalCode.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "";
                    survivalCode.stageNumber = 18;
                    survivalCode.model = "25";
                    survivalCode.costume = "00";
                    survivalCode.fightingStyle = "25";
                    survivalCode.weaponNumber = "05"; //Olcadan

                    survivalCode.aiLevel = "05"; // 00-05
                    survivalCode.weaponSpecial = ""; //Fire, Thunder, Paralysis, Cure etc
                    survivalCode.guardianForce = ""; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                    survivalCode.stickyFeet = ""; //Slippery Feets
                    survivalCode.speed = "3F80"; //3F80 default speed

                    survivalCode.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                    survivalCode.attack = ""; //Decrease/Increase Attack
                    survivalCode.defense = ""; //Decrease/Increase Defense
                    survivalCode.stealHp = ""; //Steal health from enemy
                    survivalCode.pierceDamage = ""; //Damage inflicted thru guard
                    survivalCode.weaponSize = "";
                    survivalCode.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                    survivalCode.counterRate = ""; //Increase Counter Chance
                    survivalCode.nullCounter = ""; //Nullify Enemies Counters chance
                    survivalCode.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                    survivalCode.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                    survivalCode.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                    survivalCode.parryRegen = ""; //Recover Health when successfully Guard Impact
                    survivalCode.guardBreakRate = ""; //Increase Guard Break Chance
                    survivalCode.throwEscapeChance = ""; //Increase Throw Escape Rate
                    survivalCode.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                    survivalCode.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                    survivalCode.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "";
                    survivalCode.stageNumber = 19;
                    survivalCode.model = "03";
                    survivalCode.costume = "08";
                    survivalCode.fightingStyle = "03";
                    survivalCode.weaponNumber = "05"; //Taki

                    survivalCode.aiLevel = "05"; // 00-05
                    survivalCode.weaponSpecial = ""; //Fire, Thunder, Paralysis, Cure etc
                    survivalCode.guardianForce = ""; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                    survivalCode.stickyFeet = ""; //Slippery Feets
                    survivalCode.speed = "3F80"; //3F80 default speed

                    survivalCode.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                    survivalCode.attack = "3FC00000"; //Decrease/Increase Attack
                    survivalCode.defense = "3F400000"; //Decrease/Increase Defense
                    survivalCode.stealHp = ""; //Steal health from enemy
                    survivalCode.pierceDamage = ""; //Damage inflicted thru guard
                    survivalCode.weaponSize = "3FB00000";
                    survivalCode.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                    survivalCode.counterRate = ""; //Increase Counter Chance
                    survivalCode.nullCounter = ""; //Nullify Enemies Counters chance
                    survivalCode.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                    survivalCode.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                    survivalCode.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                    survivalCode.parryRegen = ""; //Recover Health when successfully Guard Impact
                    survivalCode.guardBreakRate = ""; //Increase Guard Break Chance
                    survivalCode.throwEscapeChance = ""; //Increase Throw Escape Rate
                    survivalCode.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                    survivalCode.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                    survivalCode.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "";
                    survivalCode.stageNumber = 20;
                    survivalCode.model = "26";
                    survivalCode.costume = "01";
                    survivalCode.fightingStyle = "26";
                    survivalCode.weaponNumber = "01"; //Abyss

                    survivalCode.aiLevel = "05"; // 00-05
                    survivalCode.weaponSpecial = ""; //Fire, Thunder, Paralysis, Cure etc
                    survivalCode.guardianForce = ""; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                    survivalCode.stickyFeet = ""; //Slippery Feets
                    survivalCode.speed = "3F90"; //3F80 default speed

                    survivalCode.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                    survivalCode.attack = "3FA00000"; //Decrease/Increase Attack
                    survivalCode.defense = "3F600000"; //Decrease/Increase Defense
                    survivalCode.stealHp = ""; //Steal health from enemy
                    survivalCode.pierceDamage = ""; //Damage inflicted thru guard
                    survivalCode.weaponSize = "";
                    survivalCode.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                    survivalCode.counterRate = ""; //Increase Counter Chance
                    survivalCode.nullCounter = ""; //Nullify Enemies Counters chance
                    survivalCode.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                    survivalCode.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                    survivalCode.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                    survivalCode.parryRegen = ""; //Recover Health when successfully Guard Impact
                    survivalCode.guardBreakRate = ""; //Increase Guard Break Chance
                    survivalCode.throwEscapeChance = ""; //Increase Throw Escape Rate
                    survivalCode.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                    survivalCode.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                    survivalCode.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    break;
                #endregion

                #region Champion Arc  [Sophitia]
                case "Champion Arc":
                    survivalCode.stageLevel = "0008";
                    survivalCode.stageMusic = "08";
                    survivalCode.stageNumber = 1;
                    survivalCode.model = "16";
                    survivalCode.costume = "00";
                    survivalCode.fightingStyle = "16";
                    survivalCode.weaponNumber = "05"; //Talim

                    survivalCode.aiLevel = "04"; // 00-05
                    survivalCode.weaponSpecial = ""; //Fire, Thunder, Paralysis, Cure etc
                    survivalCode.guardianForce = ""; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                    survivalCode.stickyFeet = ""; //Slippery Feets
                    survivalCode.speed = "3F80"; //3F80 default speed

                    survivalCode.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                    survivalCode.attack = ""; //Decrease/Increase Attack
                    survivalCode.defense = ""; //Decrease/Increase Defense
                    survivalCode.stealHp = ""; //Steal health from enemy
                    survivalCode.pierceDamage = ""; //Damage inflicted thru guard
                    survivalCode.weaponSize = "";
                    survivalCode.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                    survivalCode.counterRate = ""; //Increase Counter Chance
                    survivalCode.nullCounter = ""; //Nullify Enemies Counters chance
                    survivalCode.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                    survivalCode.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                    survivalCode.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                    survivalCode.parryRegen = ""; //Recover Health when successfully Guard Impact
                    survivalCode.guardBreakRate = ""; //Increase Guard Break Chance
                    survivalCode.throwEscapeChance = ""; //Increase Throw Escape Rate
                    survivalCode.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                    survivalCode.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                    survivalCode.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "";
                    survivalCode.stageMusic = "";
                    survivalCode.stageNumber = 2;
                    survivalCode.model = "0D";
                    survivalCode.costume = "00";
                    survivalCode.fightingStyle = "0D";
                    survivalCode.weaponNumber = "05"; //Xianghua

                    survivalCode.aiLevel = "04"; // 00-05
                    survivalCode.weaponSpecial = ""; //Fire, Thunder, Paralysis, Cure etc
                    survivalCode.guardianForce = ""; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                    survivalCode.stickyFeet = ""; //Slippery Feets
                    survivalCode.speed = "3F84"; //3F80 default speed

                    survivalCode.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                    survivalCode.attack = ""; //Decrease/Increase Attack
                    survivalCode.defense = ""; //Decrease/Increase Defense
                    survivalCode.stealHp = ""; //Steal health from enemy
                    survivalCode.pierceDamage = ""; //Damage inflicted thru guard
                    survivalCode.weaponSize = "";
                    survivalCode.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                    survivalCode.counterRate = ""; //Increase Counter Chance
                    survivalCode.nullCounter = ""; //Nullify Enemies Counters chance
                    survivalCode.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                    survivalCode.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                    survivalCode.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                    survivalCode.parryRegen = ""; //Recover Health when successfully Guard Impact
                    survivalCode.guardBreakRate = ""; //Increase Guard Break Chance
                    survivalCode.throwEscapeChance = ""; //Increase Throw Escape Rate
                    survivalCode.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                    survivalCode.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                    survivalCode.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "";
                    survivalCode.stageMusic = "";
                    survivalCode.stageNumber = 3;
                    survivalCode.model = "14";
                    survivalCode.costume = "00";
                    survivalCode.fightingStyle = "14";
                    survivalCode.weaponNumber = "05"; //Cervantes

                    survivalCode.aiLevel = "05"; // 00-05
                    survivalCode.weaponSpecial = ""; //Fire, Thunder, Paralysis, Cure etc
                    survivalCode.guardianForce = ""; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                    survivalCode.stickyFeet = ""; //Slippery Feets
                    survivalCode.speed = "3F80"; //3F80 default speed

                    survivalCode.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                    survivalCode.attack = ""; //Decrease/Increase Attack
                    survivalCode.defense = ""; //Decrease/Increase Defense
                    survivalCode.stealHp = ""; //Steal health from enemy
                    survivalCode.pierceDamage = ""; //Damage inflicted thru guard
                    survivalCode.weaponSize = "";
                    survivalCode.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                    survivalCode.counterRate = ""; //Increase Counter Chance
                    survivalCode.nullCounter = ""; //Nullify Enemies Counters chance
                    survivalCode.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                    survivalCode.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                    survivalCode.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                    survivalCode.parryRegen = ""; //Recover Health when successfully Guard Impact
                    survivalCode.guardBreakRate = ""; //Increase Guard Break Chance
                    survivalCode.throwEscapeChance = ""; //Increase Throw Escape Rate
                    survivalCode.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                    survivalCode.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                    survivalCode.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "";
                    survivalCode.stageMusic = "";
                    survivalCode.stageNumber = 4;
                    survivalCode.model = "01";
                    survivalCode.costume = "00";
                    survivalCode.fightingStyle = "01";
                    survivalCode.weaponNumber = "05"; //Mitsurugi

                    survivalCode.aiLevel = "05"; // 00-05
                    survivalCode.weaponSpecial = ""; //Fire, Thunder, Paralysis, Cure etc
                    survivalCode.guardianForce = ""; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                    survivalCode.stickyFeet = ""; //Slippery Feets
                    survivalCode.speed = "3F80"; //3F80 default speed

                    survivalCode.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                    survivalCode.attack = ""; //Decrease/Increase Attack
                    survivalCode.defense = ""; //Decrease/Increase Defense
                    survivalCode.stealHp = ""; //Steal health from enemy
                    survivalCode.pierceDamage = ""; //Damage inflicted thru guard
                    survivalCode.weaponSize = "";
                    survivalCode.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                    survivalCode.counterRate = ""; //Increase Counter Chance
                    survivalCode.nullCounter = ""; //Nullify Enemies Counters chance
                    survivalCode.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                    survivalCode.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                    survivalCode.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                    survivalCode.parryRegen = ""; //Recover Health when successfully Guard Impact
                    survivalCode.guardBreakRate = ""; //Increase Guard Break Chance
                    survivalCode.throwEscapeChance = ""; //Increase Throw Escape Rate
                    survivalCode.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                    survivalCode.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                    survivalCode.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "";
                    survivalCode.stageMusic = "";
                    survivalCode.stageNumber = 5;
                    survivalCode.model = "A3";
                    survivalCode.costume = "02";
                    survivalCode.fightingStyle = "42";
                    survivalCode.weaponNumber = "04"; //Tomoe

                    survivalCode.aiLevel = "05"; // 00-05
                    survivalCode.weaponSpecial = ""; //Fire, Thunder, Paralysis, Cure etc
                    survivalCode.guardianForce = ""; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                    survivalCode.stickyFeet = ""; //Slippery Feets
                    survivalCode.speed = "3F82"; //3F80 default speed

                    survivalCode.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                    survivalCode.attack = ""; //Decrease/Increase Attack
                    survivalCode.defense = ""; //Decrease/Increase Defense
                    survivalCode.stealHp = ""; //Steal health from enemy
                    survivalCode.pierceDamage = ""; //Damage inflicted thru guard
                    survivalCode.weaponSize = "";
                    survivalCode.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                    survivalCode.counterRate = ""; //Increase Counter Chance
                    survivalCode.nullCounter = ""; //Nullify Enemies Counters chance
                    survivalCode.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                    survivalCode.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                    survivalCode.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                    survivalCode.parryRegen = ""; //Recover Health when successfully Guard Impact
                    survivalCode.guardBreakRate = ""; //Increase Guard Break Chance
                    survivalCode.throwEscapeChance = ""; //Increase Throw Escape Rate
                    survivalCode.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                    survivalCode.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                    survivalCode.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "0003";
                    survivalCode.stageMusic = "03";
                    survivalCode.stageNumber = 6;
                    survivalCode.model = "51";
                    survivalCode.costume = "00";
                    survivalCode.fightingStyle = "51";
                    survivalCode.weaponNumber = "04"; //Li Long

                    survivalCode.aiLevel = "05"; // 00-05
                    survivalCode.weaponSpecial = "All Guard Break"; //Fire, Thunder, Paralysis, Cure etc
                    survivalCode.guardianForce = ""; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                    survivalCode.stickyFeet = ""; //Slippery Feets
                    survivalCode.speed = "3F80"; //3F80 default speed

                    survivalCode.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                    survivalCode.attack = ""; //Decrease/Increase Attack
                    survivalCode.defense = ""; //Decrease/Increase Defense
                    survivalCode.stealHp = ""; //Steal health from enemy
                    survivalCode.pierceDamage = ""; //Damage inflicted thru guard
                    survivalCode.weaponSize = "";
                    survivalCode.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                    survivalCode.counterRate = ""; //Increase Counter Chance
                    survivalCode.nullCounter = ""; //Nullify Enemies Counters chance
                    survivalCode.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                    survivalCode.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                    survivalCode.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                    survivalCode.parryRegen = ""; //Recover Health when successfully Guard Impact
                    survivalCode.guardBreakRate = ""; //Increase Guard Break Chance
                    survivalCode.throwEscapeChance = ""; //Increase Throw Escape Rate
                    survivalCode.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                    survivalCode.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                    survivalCode.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "";
                    survivalCode.stageMusic = "";
                    survivalCode.stageNumber = 7;
                    survivalCode.model = "48";
                    survivalCode.costume = "00";
                    survivalCode.fightingStyle = "48";
                    survivalCode.weaponNumber = "00"; //Girardot

                    survivalCode.aiLevel = "05"; // 00-05
                    survivalCode.weaponSpecial = ""; //Fire, Thunder, Paralysis, Cure etc
                    survivalCode.guardianForce = ""; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                    survivalCode.stickyFeet = ""; //Slippery Feets
                    survivalCode.speed = "3F88"; //3F80 default speed

                    survivalCode.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                    survivalCode.attack = ""; //Decrease/Increase Attack
                    survivalCode.defense = ""; //Decrease/Increase Defense
                    survivalCode.stealHp = ""; //Steal health from enemy
                    survivalCode.pierceDamage = ""; //Damage inflicted thru guard
                    survivalCode.weaponSize = "";
                    survivalCode.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                    survivalCode.counterRate = ""; //Increase Counter Chance
                    survivalCode.nullCounter = ""; //Nullify Enemies Counters chance
                    survivalCode.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                    survivalCode.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                    survivalCode.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                    survivalCode.parryRegen = ""; //Recover Health when successfully Guard Impact
                    survivalCode.guardBreakRate = ""; //Increase Guard Break Chance
                    survivalCode.throwEscapeChance = ""; //Increase Throw Escape Rate
                    survivalCode.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                    survivalCode.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                    survivalCode.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "";
                    survivalCode.stageMusic = "";
                    survivalCode.stageNumber = 8;
                    survivalCode.model = "23";
                    survivalCode.costume = "00";
                    survivalCode.fightingStyle = "23";
                    survivalCode.weaponNumber = "05"; //Tira

                    survivalCode.aiLevel = "05"; // 00-05
                    survivalCode.weaponSpecial = ""; //Fire, Thunder, Paralysis, Cure etc
                    survivalCode.guardianForce = ""; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                    survivalCode.stickyFeet = ""; //Slippery Feets
                    survivalCode.speed = "3F80"; //3F80 default speed

                    survivalCode.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                    survivalCode.attack = ""; //Decrease/Increase Attack
                    survivalCode.defense = ""; //Decrease/Increase Defense
                    survivalCode.stealHp = ""; //Steal health from enemy
                    survivalCode.pierceDamage = ""; //Damage inflicted thru guard
                    survivalCode.weaponSize = "";
                    survivalCode.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                    survivalCode.counterRate = ""; //Increase Counter Chance
                    survivalCode.nullCounter = ""; //Nullify Enemies Counters chance
                    survivalCode.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                    survivalCode.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                    survivalCode.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                    survivalCode.parryRegen = ""; //Recover Health when successfully Guard Impact
                    survivalCode.guardBreakRate = ""; //Increase Guard Break Chance
                    survivalCode.throwEscapeChance = ""; //Increase Throw Escape Rate
                    survivalCode.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                    survivalCode.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                    survivalCode.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "";
                    survivalCode.stageMusic = "";
                    survivalCode.stageNumber = 9;
                    survivalCode.model = "02";
                    survivalCode.costume = "00";
                    survivalCode.fightingStyle = "02";
                    survivalCode.weaponNumber = "05"; //Seong Mi-na

                    survivalCode.aiLevel = "05"; // 00-05
                    survivalCode.weaponSpecial = ""; //Fire, Thunder, Paralysis, Cure etc
                    survivalCode.guardianForce = ""; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                    survivalCode.stickyFeet = ""; //Slippery Feets
                    survivalCode.speed = "3F80"; //3F80 default speed

                    survivalCode.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                    survivalCode.attack = ""; //Decrease/Increase Attack
                    survivalCode.defense = ""; //Decrease/Increase Defense
                    survivalCode.stealHp = ""; //Steal health from enemy
                    survivalCode.pierceDamage = ""; //Damage inflicted thru guard
                    survivalCode.weaponSize = "";
                    survivalCode.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                    survivalCode.counterRate = ""; //Increase Counter Chance
                    survivalCode.nullCounter = ""; //Nullify Enemies Counters chance
                    survivalCode.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                    survivalCode.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                    survivalCode.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                    survivalCode.parryRegen = ""; //Recover Health when successfully Guard Impact
                    survivalCode.guardBreakRate = ""; //Increase Guard Break Chance
                    survivalCode.throwEscapeChance = ""; //Increase Throw Escape Rate
                    survivalCode.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                    survivalCode.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                    survivalCode.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "";
                    survivalCode.stageMusic = "";
                    survivalCode.stageNumber = 10;
                    survivalCode.model = "28";
                    survivalCode.costume = "00";
                    survivalCode.fightingStyle = "26";
                    survivalCode.weaponNumber = "03"; //Charade

                    survivalCode.aiLevel = "05"; // 00-05
                    survivalCode.weaponSpecial = "Paralysis"; //Fire, Thunder, Paralysis, Cure etc
                    survivalCode.guardianForce = ""; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                    survivalCode.stickyFeet = ""; //Slippery Feets
                    survivalCode.speed = "3F88"; //3F80 default speed

                    survivalCode.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                    survivalCode.attack = ""; //Decrease/Increase Attack
                    survivalCode.defense = ""; //Decrease/Increase Defense
                    survivalCode.stealHp = ""; //Steal health from enemy
                    survivalCode.pierceDamage = ""; //Damage inflicted thru guard
                    survivalCode.weaponSize = "";
                    survivalCode.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                    survivalCode.counterRate = ""; //Increase Counter Chance
                    survivalCode.nullCounter = ""; //Nullify Enemies Counters chance
                    survivalCode.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                    survivalCode.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                    survivalCode.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                    survivalCode.parryRegen = ""; //Recover Health when successfully Guard Impact
                    survivalCode.guardBreakRate = ""; //Increase Guard Break Chance
                    survivalCode.throwEscapeChance = ""; //Increase Throw Escape Rate
                    survivalCode.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                    survivalCode.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                    survivalCode.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "000F";
                    survivalCode.stageMusic = "0F";
                    survivalCode.stageNumber = 11;
                    survivalCode.model = "47";
                    survivalCode.costume = "00";
                    survivalCode.fightingStyle = "47";
                    survivalCode.weaponNumber = "04"; //Hualin

                    survivalCode.aiLevel = "05"; // 00-05
                    survivalCode.weaponSpecial = ""; //Fire, Thunder, Paralysis, Cure etc
                    survivalCode.guardianForce = ""; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                    survivalCode.stickyFeet = ""; //Slippery Feets
                    survivalCode.speed = "3F80"; //3F80 default speed

                    survivalCode.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                    survivalCode.attack = ""; //Decrease/Increase Attack
                    survivalCode.defense = ""; //Decrease/Increase Defense
                    survivalCode.stealHp = ""; //Steal health from enemy
                    survivalCode.pierceDamage = ""; //Damage inflicted thru guard
                    survivalCode.weaponSize = "";
                    survivalCode.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                    survivalCode.counterRate = ""; //Increase Counter Chance
                    survivalCode.nullCounter = ""; //Nullify Enemies Counters chance
                    survivalCode.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                    survivalCode.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                    survivalCode.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                    survivalCode.parryRegen = ""; //Recover Health when successfully Guard Impact
                    survivalCode.guardBreakRate = ""; //Increase Guard Break Chance
                    survivalCode.throwEscapeChance = "40000000"; //Increase Throw Escape Rate
                    survivalCode.ringOutEscapeChance = "40000000"; //Increase Ring-Out Escape Rate
                    survivalCode.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                    survivalCode.hpRegenOrDrainOnAtk = "BF000000"; //Drain/Recover Health when Attacking
                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "";
                    survivalCode.stageMusic = "";
                    survivalCode.stageNumber = 12;
                    survivalCode.model = "E1";
                    survivalCode.costume = "02";
                    survivalCode.fightingStyle = "45";
                    survivalCode.weaponNumber = "05"; //Luna

                    survivalCode.aiLevel = "05"; // 00-05
                    survivalCode.weaponSpecial = ""; //Fire, Thunder, Paralysis, Cure etc
                    survivalCode.guardianForce = ""; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                    survivalCode.stickyFeet = ""; //Slippery Feets
                    survivalCode.speed = "3F80"; //3F80 default speed

                    survivalCode.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                    survivalCode.attack = ""; //Decrease/Increase Attack
                    survivalCode.defense = ""; //Decrease/Increase Defense
                    survivalCode.stealHp = ""; //Steal health from enemy
                    survivalCode.pierceDamage = "3F200000"; //Damage inflicted thru guard
                    survivalCode.weaponSize = "40000000";
                    survivalCode.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                    survivalCode.counterRate = ""; //Increase Counter Chance
                    survivalCode.nullCounter = ""; //Nullify Enemies Counters chance
                    survivalCode.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                    survivalCode.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                    survivalCode.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                    survivalCode.parryRegen = ""; //Recover Health when successfully Guard Impact
                    survivalCode.guardBreakRate = ""; //Increase Guard Break Chance
                    survivalCode.throwEscapeChance = ""; //Increase Throw Escape Rate
                    survivalCode.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                    survivalCode.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                    survivalCode.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "";
                    survivalCode.stageMusic = "";
                    survivalCode.stageNumber = 13;
                    survivalCode.model = "4F";
                    survivalCode.costume = "00";
                    survivalCode.fightingStyle = "4F";
                    survivalCode.weaponNumber = "04"; //Lynette

                    survivalCode.aiLevel = "05"; // 00-05
                    survivalCode.weaponSpecial = "All Guard Break"; //Fire, Thunder, Paralysis, Cure etc
                    survivalCode.guardianForce = ""; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                    survivalCode.stickyFeet = ""; //Slippery Feets
                    survivalCode.speed = "3F80"; //3F80 default speed

                    survivalCode.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                    survivalCode.attack = ""; //Decrease/Increase Attack
                    survivalCode.defense = ""; //Decrease/Increase Defense
                    survivalCode.stealHp = ""; //Steal health from enemy
                    survivalCode.pierceDamage = ""; //Damage inflicted thru guard
                    survivalCode.weaponSize = "";
                    survivalCode.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                    survivalCode.counterRate = ""; //Increase Counter Chance
                    survivalCode.nullCounter = ""; //Nullify Enemies Counters chance
                    survivalCode.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                    survivalCode.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                    survivalCode.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                    survivalCode.parryRegen = ""; //Recover Health when successfully Guard Impact
                    survivalCode.guardBreakRate = ""; //Increase Guard Break Chance
                    survivalCode.throwEscapeChance = ""; //Increase Throw Escape Rate
                    survivalCode.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                    survivalCode.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                    survivalCode.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "";
                    survivalCode.stageMusic = "";
                    survivalCode.stageNumber = 14;
                    survivalCode.model = "E8";
                    survivalCode.costume = "01";
                    survivalCode.fightingStyle = "54";
                    survivalCode.weaponNumber = "04"; //HealDo

                    survivalCode.aiLevel = "05"; // 00-05
                    survivalCode.weaponSpecial = ""; //Fire, Thunder, Paralysis, Cure etc
                    survivalCode.guardianForce = ""; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                    survivalCode.stickyFeet = ""; //Slippery Feets
                    survivalCode.speed = "3F80"; //3F80 default speed

                    survivalCode.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                    survivalCode.attack = ""; //Decrease/Increase Attack
                    survivalCode.defense = ""; //Decrease/Increase Defense
                    survivalCode.stealHp = ""; //Steal health from enemy
                    survivalCode.pierceDamage = ""; //Damage inflicted thru guard
                    survivalCode.weaponSize = "";
                    survivalCode.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                    survivalCode.counterRate = ""; //Increase Counter Chance
                    survivalCode.nullCounter = ""; //Nullify Enemies Counters chance
                    survivalCode.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                    survivalCode.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                    survivalCode.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                    survivalCode.parryRegen = ""; //Recover Health when successfully Guard Impact
                    survivalCode.guardBreakRate = ""; //Increase Guard Break Chance
                    survivalCode.throwEscapeChance = ""; //Increase Throw Escape Rate
                    survivalCode.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                    survivalCode.hpRegenOrDrain = "3C800000"; //Drain/Recover Health over Time
                    survivalCode.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "";
                    survivalCode.stageMusic = "";
                    survivalCode.stageNumber = 15;
                    survivalCode.model = "4D";
                    survivalCode.costume = "01";
                    survivalCode.fightingStyle = "4D";
                    survivalCode.weaponNumber = "06"; //Strife

                    survivalCode.aiLevel = "05"; // 00-05
                    survivalCode.weaponSpecial = ""; //Fire, Thunder, Paralysis, Cure etc
                    survivalCode.guardianForce = ""; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                    survivalCode.stickyFeet = ""; //Slippery Feets
                    survivalCode.speed = "3F80"; //3F80 default speed

                    survivalCode.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                    survivalCode.attack = "3FD00000"; //Decrease/Increase Attack
                    survivalCode.defense = ""; //Decrease/Increase Defense
                    survivalCode.stealHp = ""; //Steal health from enemy
                    survivalCode.pierceDamage = ""; //Damage inflicted thru guard
                    survivalCode.weaponSize = "";
                    survivalCode.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                    survivalCode.counterRate = ""; //Increase Counter Chance
                    survivalCode.nullCounter = ""; //Nullify Enemies Counters chance
                    survivalCode.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                    survivalCode.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                    survivalCode.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                    survivalCode.parryRegen = ""; //Recover Health when successfully Guard Impact
                    survivalCode.guardBreakRate = ""; //Increase Guard Break Chance
                    survivalCode.throwEscapeChance = ""; //Increase Throw Escape Rate
                    survivalCode.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                    survivalCode.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                    survivalCode.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "0201";
                    survivalCode.stageMusic = "01";
                    survivalCode.stageNumber = 16;
                    survivalCode.model = "17";
                    survivalCode.costume = "01";
                    survivalCode.fightingStyle = "17";
                    survivalCode.weaponNumber = "05"; //Cassandra

                    survivalCode.aiLevel = "05"; // 00-05
                    survivalCode.weaponSpecial = ""; //Fire, Thunder, Paralysis, Cure etc
                    survivalCode.guardianForce = ""; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                    survivalCode.stickyFeet = ""; //Slippery Feets
                    survivalCode.speed = "3F86"; //3F80 default speed

                    survivalCode.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                    survivalCode.attack = ""; //Decrease/Increase Attack
                    survivalCode.defense = ""; //Decrease/Increase Defense
                    survivalCode.stealHp = ""; //Steal health from enemy
                    survivalCode.pierceDamage = ""; //Damage inflicted thru guard
                    survivalCode.weaponSize = "";
                    survivalCode.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                    survivalCode.counterRate = ""; //Increase Counter Chance
                    survivalCode.nullCounter = ""; //Nullify Enemies Counters chance
                    survivalCode.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                    survivalCode.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                    survivalCode.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                    survivalCode.parryRegen = ""; //Recover Health when successfully Guard Impact
                    survivalCode.guardBreakRate = ""; //Increase Guard Break Chance
                    survivalCode.throwEscapeChance = ""; //Increase Throw Escape Rate
                    survivalCode.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                    survivalCode.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                    survivalCode.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "";
                    survivalCode.stageMusic = "";
                    survivalCode.stageNumber = 17;
                    survivalCode.model = "0B";
                    survivalCode.costume = "00";
                    survivalCode.fightingStyle = "0B";
                    survivalCode.weaponNumber = "05"; //Ivy

                    survivalCode.aiLevel = "05"; // 00-05
                    survivalCode.weaponSpecial = "Paralysis"; //Fire, Thunder, Paralysis, Cure etc
                    survivalCode.guardianForce = ""; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                    survivalCode.stickyFeet = ""; //Slippery Feets
                    survivalCode.speed = "3F80"; //3F80 default speed

                    survivalCode.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                    survivalCode.attack = ""; //Decrease/Increase Attack
                    survivalCode.defense = ""; //Decrease/Increase Defense
                    survivalCode.stealHp = ""; //Steal health from enemy
                    survivalCode.pierceDamage = ""; //Damage inflicted thru guard
                    survivalCode.weaponSize = "3FD00000";
                    survivalCode.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                    survivalCode.counterRate = ""; //Increase Counter Chance
                    survivalCode.nullCounter = ""; //Nullify Enemies Counters chance
                    survivalCode.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                    survivalCode.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                    survivalCode.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                    survivalCode.parryRegen = ""; //Recover Health when successfully Guard Impact
                    survivalCode.guardBreakRate = ""; //Increase Guard Break Chance
                    survivalCode.throwEscapeChance = ""; //Increase Throw Escape Rate
                    survivalCode.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                    survivalCode.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                    survivalCode.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "";
                    survivalCode.stageMusic = "";
                    survivalCode.stageNumber = 18;
                    survivalCode.model = "07";
                    survivalCode.costume = "00";
                    survivalCode.fightingStyle = "07";
                    survivalCode.weaponNumber = "05"; //Siegfried

                    survivalCode.aiLevel = "05"; // 00-05
                    survivalCode.weaponSpecial = "All Guard Break"; //Fire, Thunder, Paralysis, Cure etc
                    survivalCode.guardianForce = ""; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                    survivalCode.stickyFeet = ""; //Slippery Feets
                    survivalCode.speed = "3F80"; //3F80 default speed

                    survivalCode.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                    survivalCode.attack = ""; //Decrease/Increase Attack
                    survivalCode.defense = "3F400000"; //Decrease/Increase Defense
                    survivalCode.stealHp = ""; //Steal health from enemy
                    survivalCode.pierceDamage = ""; //Damage inflicted thru guard
                    survivalCode.weaponSize = "";
                    survivalCode.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                    survivalCode.counterRate = ""; //Increase Counter Chance
                    survivalCode.nullCounter = ""; //Nullify Enemies Counters chance
                    survivalCode.guardHpModify = "3C400000"; //Decrease/Increase Health while guarding enemies attacks
                    survivalCode.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                    survivalCode.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                    survivalCode.parryRegen = ""; //Recover Health when successfully Guard Impact
                    survivalCode.guardBreakRate = ""; //Increase Guard Break Chance
                    survivalCode.throwEscapeChance = "40000000"; //Increase Throw Escape Rate
                    survivalCode.ringOutEscapeChance = "40000000"; //Increase Ring-Out Escape Rate
                    survivalCode.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                    survivalCode.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "";
                    survivalCode.stageMusic = "";
                    survivalCode.stageNumber = 19;
                    survivalCode.model = "11";
                    survivalCode.costume = "00";
                    survivalCode.fightingStyle = "11";
                    survivalCode.weaponNumber = "05"; //Nightmare

                    survivalCode.aiLevel = "05"; // 00-05
                    survivalCode.weaponSpecial = "All Unblockable"; //Fire, Thunder, Paralysis, Cure etc
                    survivalCode.guardianForce = ""; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                    survivalCode.stickyFeet = ""; //Slippery Feets
                    survivalCode.speed = "3F50"; //3F80 default speed

                    survivalCode.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                    survivalCode.attack = ""; //Decrease/Increase Attack
                    survivalCode.defense = ""; //Decrease/Increase Defense
                    survivalCode.stealHp = ""; //Steal health from enemy
                    survivalCode.pierceDamage = ""; //Damage inflicted thru guard
                    survivalCode.weaponSize = "";
                    survivalCode.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                    survivalCode.counterRate = ""; //Increase Counter Chance
                    survivalCode.nullCounter = ""; //Nullify Enemies Counters chance
                    survivalCode.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                    survivalCode.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                    survivalCode.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                    survivalCode.parryRegen = ""; //Recover Health when successfully Guard Impact
                    survivalCode.guardBreakRate = ""; //Increase Guard Break Chance
                    survivalCode.throwEscapeChance = ""; //Increase Throw Escape Rate
                    survivalCode.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                    survivalCode.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                    survivalCode.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "";
                    survivalCode.stageMusic = "";
                    survivalCode.stageNumber = 20;
                    survivalCode.model = "06";
                    survivalCode.costume = "09";
                    survivalCode.fightingStyle = "06";
                    survivalCode.weaponNumber = "05"; //Sophitia

                    survivalCode.aiLevel = "05"; // 00-05
                    survivalCode.weaponSpecial = "Cure"; //Fire, Thunder, Paralysis, Cure etc
                    survivalCode.guardianForce = ""; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                    survivalCode.stickyFeet = ""; //Slippery Feets
                    survivalCode.speed = "3F80"; //3F80 default speed

                    survivalCode.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                    survivalCode.attack = "3F200000"; //Decrease/Increase Attack
                    survivalCode.defense = ""; //Decrease/Increase Defense
                    survivalCode.stealHp = ""; //Steal health from enemy
                    survivalCode.pierceDamage = ""; //Damage inflicted thru guard
                    survivalCode.weaponSize = "";
                    survivalCode.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                    survivalCode.counterRate = ""; //Increase Counter Chance
                    survivalCode.nullCounter = ""; //Nullify Enemies Counters chance
                    survivalCode.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                    survivalCode.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                    survivalCode.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                    survivalCode.parryRegen = ""; //Recover Health when successfully Guard Impact
                    survivalCode.guardBreakRate = ""; //Increase Guard Break Chance
                    survivalCode.throwEscapeChance = ""; //Increase Throw Escape Rate
                    survivalCode.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                    survivalCode.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                    survivalCode.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                    break;
                #endregion

                #region Legendary Arc  [Inferno]
                case "Legendary Arc":
                    survivalCode.stageLevel = "0109";
                    survivalCode.stageMusic = "09";
                    survivalCode.stageNumber = 1;
                    survivalCode.model = "0C";
                    survivalCode.costume = "00";
                    survivalCode.fightingStyle = "0C";
                    survivalCode.weaponNumber = "07"; //Kilik

                    survivalCode.aiLevel = "05"; // 00-05
                    survivalCode.weaponSpecial = ""; //Fire, Thunder, Paralysis, Cure etc
                    survivalCode.guardianForce = ""; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                    survivalCode.stickyFeet = ""; //Slippery Feets
                    survivalCode.speed = "3F88"; //3F80 default speed

                    survivalCode.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                    survivalCode.attack = ""; //Decrease/Increase Attack
                    survivalCode.defense = ""; //Decrease/Increase Defense
                    survivalCode.stealHp = ""; //Steal health from enemy
                    survivalCode.pierceDamage = ""; //Damage inflicted thru guard
                    survivalCode.weaponSize = "";
                    survivalCode.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                    survivalCode.counterRate = ""; //Increase Counter Chance
                    survivalCode.nullCounter = ""; //Nullify Enemies Counters chance
                    survivalCode.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                    survivalCode.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                    survivalCode.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                    survivalCode.parryRegen = ""; //Recover Health when successfully Guard Impact
                    survivalCode.guardBreakRate = ""; //Increase Guard Break Chance
                    survivalCode.throwEscapeChance = ""; //Increase Throw Escape Rate
                    survivalCode.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                    survivalCode.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                    survivalCode.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "";
                    survivalCode.stageMusic = "";
                    survivalCode.stageNumber = 2;
                    survivalCode.model = "05";
                    survivalCode.costume = "00";
                    survivalCode.fightingStyle = "05";
                    survivalCode.weaponNumber = "07"; //Voldo

                    survivalCode.aiLevel = "05"; // 00-05
                    survivalCode.weaponSpecial = ""; //Fire, Thunder, Paralysis, Cure etc
                    survivalCode.guardianForce = ""; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                    survivalCode.stickyFeet = ""; //Slippery Feets
                    survivalCode.speed = "3F90"; //3F80 default speed

                    survivalCode.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                    survivalCode.attack = ""; //Decrease/Increase Attack
                    survivalCode.defense = ""; //Decrease/Increase Defense
                    survivalCode.stealHp = ""; //Steal health from enemy
                    survivalCode.pierceDamage = ""; //Damage inflicted thru guard
                    survivalCode.weaponSize = "";
                    survivalCode.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                    survivalCode.counterRate = ""; //Increase Counter Chance
                    survivalCode.nullCounter = ""; //Nullify Enemies Counters chance
                    survivalCode.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                    survivalCode.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                    survivalCode.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                    survivalCode.parryRegen = ""; //Recover Health when successfully Guard Impact
                    survivalCode.guardBreakRate = ""; //Increase Guard Break Chance
                    survivalCode.throwEscapeChance = ""; //Increase Throw Escape Rate
                    survivalCode.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                    survivalCode.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                    survivalCode.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "";
                    survivalCode.stageMusic = "";
                    survivalCode.stageNumber = 3;
                    survivalCode.model = "0F";
                    survivalCode.costume = "00";
                    survivalCode.fightingStyle = "0F";
                    survivalCode.weaponNumber = "07"; //Yoshimitsu

                    survivalCode.aiLevel = "05"; // 00-05
                    survivalCode.weaponSpecial = "Paralysis"; //Fire, Thunder, Paralysis, Cure etc
                    survivalCode.guardianForce = ""; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                    survivalCode.stickyFeet = ""; //Slippery Feets
                    survivalCode.speed = "3F90"; //3F80 default speed

                    survivalCode.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                    survivalCode.attack = ""; //Decrease/Increase Attack
                    survivalCode.defense = ""; //Decrease/Increase Defense
                    survivalCode.stealHp = ""; //Steal health from enemy
                    survivalCode.pierceDamage = ""; //Damage inflicted thru guard
                    survivalCode.weaponSize = "";
                    survivalCode.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                    survivalCode.counterRate = ""; //Increase Counter Chance
                    survivalCode.nullCounter = ""; //Nullify Enemies Counters chance
                    survivalCode.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                    survivalCode.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                    survivalCode.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                    survivalCode.parryRegen = ""; //Recover Health when successfully Guard Impact
                    survivalCode.guardBreakRate = ""; //Increase Guard Break Chance
                    survivalCode.throwEscapeChance = ""; //Increase Throw Escape Rate
                    survivalCode.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                    survivalCode.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                    survivalCode.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "";
                    survivalCode.stageMusic = "";
                    survivalCode.stageNumber = 4;
                    survivalCode.model = "24";
                    survivalCode.costume = "00";
                    survivalCode.fightingStyle = "24";
                    survivalCode.weaponNumber = "07"; //Zasalamel

                    survivalCode.aiLevel = "05"; // 00-05
                    survivalCode.weaponSpecial = ""; //Fire, Thunder, Paralysis, Cure etc
                    survivalCode.guardianForce = ""; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                    survivalCode.stickyFeet = ""; //Slippery Feets
                    survivalCode.speed = "3F80"; //3F80 default speed

                    survivalCode.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                    survivalCode.attack = "3FB80000"; //Decrease/Increase Attack
                    survivalCode.defense = "3F600000"; //Decrease/Increase Defense
                    survivalCode.stealHp = ""; //Steal health from enemy
                    survivalCode.pierceDamage = ""; //Damage inflicted thru guard
                    survivalCode.weaponSize = "3FB00000";
                    survivalCode.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                    survivalCode.counterRate = ""; //Increase Counter Chance
                    survivalCode.nullCounter = ""; //Nullify Enemies Counters chance
                    survivalCode.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                    survivalCode.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                    survivalCode.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                    survivalCode.parryRegen = ""; //Recover Health when successfully Guard Impact
                    survivalCode.guardBreakRate = ""; //Increase Guard Break Chance
                    survivalCode.throwEscapeChance = ""; //Increase Throw Escape Rate
                    survivalCode.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                    survivalCode.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                    survivalCode.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "";
                    survivalCode.stageMusic = "";
                    survivalCode.stageNumber = 5;
                    survivalCode.model = "AE";
                    survivalCode.costume = "02";
                    survivalCode.fightingStyle = "48";
                    survivalCode.weaponNumber = "07"; //Aeneas

                    survivalCode.aiLevel = "05"; // 00-05
                    survivalCode.weaponSpecial = "All Guard Break"; //Fire, Thunder, Paralysis, Cure etc
                    survivalCode.guardianForce = ""; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                    survivalCode.stickyFeet = ""; //Slippery Feets
                    survivalCode.speed = "3F88"; //3F80 default speed

                    survivalCode.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                    survivalCode.attack = ""; //Decrease/Increase Attack
                    survivalCode.defense = ""; //Decrease/Increase Defense
                    survivalCode.stealHp = ""; //Steal health from enemy
                    survivalCode.pierceDamage = ""; //Damage inflicted thru guard
                    survivalCode.weaponSize = "40000000";
                    survivalCode.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                    survivalCode.counterRate = ""; //Increase Counter Chance
                    survivalCode.nullCounter = ""; //Nullify Enemies Counters chance
                    survivalCode.guardHpModify = "3D800000"; //Decrease/Increase Health while guarding enemies attacks
                    survivalCode.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                    survivalCode.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                    survivalCode.parryRegen = ""; //Recover Health when successfully Guard Impact
                    survivalCode.guardBreakRate = ""; //Increase Guard Break Chance
                    survivalCode.throwEscapeChance = ""; //Increase Throw Escape Rate
                    survivalCode.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                    survivalCode.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                    survivalCode.hpRegenOrDrainOnAtk = "C0000000"; //Drain/Recover Health when Attacking
                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "0210";
                    survivalCode.stageMusic = "10";
                    survivalCode.stageNumber = 6;
                    survivalCode.model = "03";
                    survivalCode.costume = "00";
                    survivalCode.fightingStyle = "03";
                    survivalCode.weaponNumber = "07"; //Taki

                    survivalCode.aiLevel = "05"; // 00-05
                    survivalCode.weaponSpecial = ""; //Fire, Thunder, Paralysis, Cure etc
                    survivalCode.guardianForce = ""; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                    survivalCode.stickyFeet = ""; //Slippery Feets
                    survivalCode.speed = "3F90"; //3F80 default speed

                    survivalCode.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                    survivalCode.attack = ""; //Decrease/Increase Attack
                    survivalCode.defense = ""; //Decrease/Increase Defense
                    survivalCode.stealHp = ""; //Steal health from enemy
                    survivalCode.pierceDamage = ""; //Damage inflicted thru guard
                    survivalCode.weaponSize = "";
                    survivalCode.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                    survivalCode.counterRate = ""; //Increase Counter Chance
                    survivalCode.nullCounter = ""; //Nullify Enemies Counters chance
                    survivalCode.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                    survivalCode.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                    survivalCode.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                    survivalCode.parryRegen = ""; //Recover Health when successfully Guard Impact
                    survivalCode.guardBreakRate = ""; //Increase Guard Break Chance
                    survivalCode.throwEscapeChance = ""; //Increase Throw Escape Rate
                    survivalCode.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                    survivalCode.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                    survivalCode.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "";
                    survivalCode.stageMusic = "";
                    survivalCode.stageNumber = 7;
                    survivalCode.model = "01";
                    survivalCode.costume = "00";
                    survivalCode.fightingStyle = "01";
                    survivalCode.weaponNumber = "07"; //Mitsurugi

                    survivalCode.aiLevel = "05"; // 00-05
                    survivalCode.weaponSpecial = "Paralysis"; //Fire, Thunder, Paralysis, Cure etc
                    survivalCode.guardianForce = ""; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                    survivalCode.stickyFeet = ""; //Slippery Feets
                    survivalCode.speed = "3F80"; //3F80 default speed

                    survivalCode.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                    survivalCode.attack = ""; //Decrease/Increase Attack
                    survivalCode.defense = ""; //Decrease/Increase Defense
                    survivalCode.stealHp = ""; //Steal health from enemy
                    survivalCode.pierceDamage = ""; //Damage inflicted thru guard
                    survivalCode.weaponSize = "";
                    survivalCode.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                    survivalCode.counterRate = ""; //Increase Counter Chance
                    survivalCode.nullCounter = ""; //Nullify Enemies Counters chance
                    survivalCode.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                    survivalCode.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                    survivalCode.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                    survivalCode.parryRegen = ""; //Recover Health when successfully Guard Impact
                    survivalCode.guardBreakRate = ""; //Increase Guard Break Chance
                    survivalCode.throwEscapeChance = ""; //Increase Throw Escape Rate
                    survivalCode.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                    survivalCode.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                    survivalCode.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "";
                    survivalCode.stageMusic = "";
                    survivalCode.stageNumber = 8;
                    survivalCode.model = "23";
                    survivalCode.costume = "08";
                    survivalCode.fightingStyle = "23";
                    survivalCode.weaponNumber = "07"; //Tira

                    survivalCode.aiLevel = "05"; // 00-05
                    survivalCode.weaponSpecial = "Paralysis"; //Fire, Thunder, Paralysis, Cure etc
                    survivalCode.guardianForce = ""; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                    survivalCode.stickyFeet = ""; //Slippery Feets
                    survivalCode.speed = "3F84"; //3F80 default speed

                    survivalCode.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                    survivalCode.attack = ""; //Decrease/Increase Attack
                    survivalCode.defense = ""; //Decrease/Increase Defense
                    survivalCode.stealHp = ""; //Steal health from enemy
                    survivalCode.pierceDamage = ""; //Damage inflicted thru guard
                    survivalCode.weaponSize = "";
                    survivalCode.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                    survivalCode.counterRate = ""; //Increase Counter Chance
                    survivalCode.nullCounter = ""; //Nullify Enemies Counters chance
                    survivalCode.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                    survivalCode.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                    survivalCode.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                    survivalCode.parryRegen = ""; //Recover Health when successfully Guard Impact
                    survivalCode.guardBreakRate = ""; //Increase Guard Break Chance
                    survivalCode.throwEscapeChance = ""; //Increase Throw Escape Rate
                    survivalCode.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                    survivalCode.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                    survivalCode.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "";
                    survivalCode.stageMusic = "";
                    survivalCode.stageNumber = 9;
                    survivalCode.model = "16";
                    survivalCode.costume = "00";
                    survivalCode.fightingStyle = "16";
                    survivalCode.weaponNumber = "07"; //Talim

                    survivalCode.aiLevel = "05"; // 00-05
                    survivalCode.weaponSpecial = ""; //Fire, Thunder, Paralysis, Cure etc
                    survivalCode.guardianForce = ""; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                    survivalCode.stickyFeet = ""; //Slippery Feets
                    survivalCode.speed = "3F8A"; //3F80 default speed

                    survivalCode.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                    survivalCode.attack = ""; //Decrease/Increase Attack
                    survivalCode.defense = ""; //Decrease/Increase Defense
                    survivalCode.stealHp = ""; //Steal health from enemy
                    survivalCode.pierceDamage = ""; //Damage inflicted thru guard
                    survivalCode.weaponSize = "";
                    survivalCode.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                    survivalCode.counterRate = ""; //Increase Counter Chance
                    survivalCode.nullCounter = ""; //Nullify Enemies Counters chance
                    survivalCode.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                    survivalCode.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                    survivalCode.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                    survivalCode.parryRegen = ""; //Recover Health when successfully Guard Impact
                    survivalCode.guardBreakRate = ""; //Increase Guard Break Chance
                    survivalCode.throwEscapeChance = ""; //Increase Throw Escape Rate
                    survivalCode.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                    survivalCode.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                    survivalCode.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "";
                    survivalCode.stageMusic = "";
                    survivalCode.stageNumber = 10;
                    survivalCode.model = "11";
                    survivalCode.costume = "00";
                    survivalCode.fightingStyle = "11";
                    survivalCode.weaponNumber = "07"; //Nightmare

                    survivalCode.aiLevel = "05"; // 00-05
                    survivalCode.weaponSpecial = ""; //Fire, Thunder, Paralysis, Cure etc
                    survivalCode.guardianForce = ""; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                    survivalCode.stickyFeet = ""; //Slippery Feets
                    survivalCode.speed = "3F90"; //3F80 default speed

                    survivalCode.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                    survivalCode.attack = ""; //Decrease/Increase Attack
                    survivalCode.defense = ""; //Decrease/Increase Defense
                    survivalCode.stealHp = ""; //Steal health from enemy
                    survivalCode.pierceDamage = ""; //Damage inflicted thru guard
                    survivalCode.weaponSize = "40000000";
                    survivalCode.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                    survivalCode.counterRate = ""; //Increase Counter Chance
                    survivalCode.nullCounter = ""; //Nullify Enemies Counters chance
                    survivalCode.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                    survivalCode.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                    survivalCode.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                    survivalCode.parryRegen = ""; //Recover Health when successfully Guard Impact
                    survivalCode.guardBreakRate = ""; //Increase Guard Break Chance
                    survivalCode.throwEscapeChance = ""; //Increase Throw Escape Rate
                    survivalCode.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                    survivalCode.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                    survivalCode.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "0012";
                    survivalCode.stageMusic = "12";
                    survivalCode.stageNumber = 11;
                    survivalCode.model = "12";
                    survivalCode.costume = "00";
                    survivalCode.fightingStyle = "12";
                    survivalCode.weaponNumber = "07"; //Astaroth

                    survivalCode.aiLevel = "05"; // 00-05
                    survivalCode.weaponSpecial = "Poison P2"; //Fire, Thunder, Paralysis, Cure etc
                    survivalCode.guardianForce = "05"; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                    survivalCode.stickyFeet = ""; //Slippery Feets
                    survivalCode.speed = "3F70"; //3F80 default speed

                    survivalCode.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                    survivalCode.attack = ""; //Decrease/Increase Attack
                    survivalCode.defense = ""; //Decrease/Increase Defense
                    survivalCode.stealHp = ""; //Steal health from enemy
                    survivalCode.pierceDamage = ""; //Damage inflicted thru guard
                    survivalCode.weaponSize = "";
                    survivalCode.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                    survivalCode.counterRate = ""; //Increase Counter Chance
                    survivalCode.nullCounter = ""; //Nullify Enemies Counters chance
                    survivalCode.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                    survivalCode.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                    survivalCode.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                    survivalCode.parryRegen = ""; //Recover Health when successfully Guard Impact
                    survivalCode.guardBreakRate = ""; //Increase Guard Break Chance
                    survivalCode.throwEscapeChance = ""; //Increase Throw Escape Rate
                    survivalCode.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                    survivalCode.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                    survivalCode.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "";
                    survivalCode.stageMusic = "";
                    survivalCode.stageNumber = 12;
                    survivalCode.model = "1A";
                    survivalCode.costume = "00";
                    survivalCode.fightingStyle = "1A";
                    survivalCode.weaponNumber = "07"; //Yun-Seong

                    survivalCode.aiLevel = "05"; // 00-05
                    survivalCode.weaponSpecial = "All Guard Break"; //Fire, Thunder, Paralysis, Cure etc
                    survivalCode.guardianForce = ""; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                    survivalCode.stickyFeet = ""; //Slippery Feets
                    survivalCode.speed = "3F92"; //3F80 default speed

                    survivalCode.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                    survivalCode.attack = ""; //Decrease/Increase Attack
                    survivalCode.defense = ""; //Decrease/Increase Defense
                    survivalCode.stealHp = ""; //Steal health from enemy
                    survivalCode.pierceDamage = ""; //Damage inflicted thru guard
                    survivalCode.weaponSize = "";
                    survivalCode.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                    survivalCode.counterRate = ""; //Increase Counter Chance
                    survivalCode.nullCounter = ""; //Nullify Enemies Counters chance
                    survivalCode.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                    survivalCode.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                    survivalCode.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                    survivalCode.parryRegen = ""; //Recover Health when successfully Guard Impact
                    survivalCode.guardBreakRate = ""; //Increase Guard Break Chance
                    survivalCode.throwEscapeChance = ""; //Increase Throw Escape Rate
                    survivalCode.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                    survivalCode.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                    survivalCode.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "";
                    survivalCode.stageMusic = "";
                    survivalCode.stageNumber = 13;
                    survivalCode.model = "04";
                    survivalCode.costume = "00";
                    survivalCode.fightingStyle = "04";
                    survivalCode.weaponNumber = "07"; //Maxi

                    survivalCode.aiLevel = "05"; // 00-05
                    survivalCode.weaponSpecial = "All Guard Break"; //Fire, Thunder, Paralysis, Cure etc
                    survivalCode.guardianForce = ""; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                    survivalCode.stickyFeet = ""; //Slippery Feets
                    survivalCode.speed = "3F92"; //3F80 default speed

                    survivalCode.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                    survivalCode.attack = ""; //Decrease/Increase Attack
                    survivalCode.defense = ""; //Decrease/Increase Defense
                    survivalCode.stealHp = ""; //Steal health from enemy
                    survivalCode.pierceDamage = ""; //Damage inflicted thru guard
                    survivalCode.weaponSize = "";
                    survivalCode.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                    survivalCode.counterRate = ""; //Increase Counter Chance
                    survivalCode.nullCounter = ""; //Nullify Enemies Counters chance
                    survivalCode.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                    survivalCode.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                    survivalCode.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                    survivalCode.parryRegen = ""; //Recover Health when successfully Guard Impact
                    survivalCode.guardBreakRate = ""; //Increase Guard Break Chance
                    survivalCode.throwEscapeChance = ""; //Increase Throw Escape Rate
                    survivalCode.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                    survivalCode.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                    survivalCode.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "";
                    survivalCode.stageMusic = "";
                    survivalCode.stageNumber = 14;
                    survivalCode.model = "22";
                    survivalCode.costume = "00";
                    survivalCode.fightingStyle = "22";
                    survivalCode.weaponNumber = "07"; //Setsuka

                    survivalCode.aiLevel = "05"; // 00-05
                    survivalCode.weaponSpecial = "Paralysis"; //Fire, Thunder, Paralysis, Cure etc
                    survivalCode.guardianForce = ""; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                    survivalCode.stickyFeet = ""; //Slippery Feets
                    survivalCode.speed = "3F92"; //3F80 default speed

                    survivalCode.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                    survivalCode.attack = ""; //Decrease/Increase Attack
                    survivalCode.defense = ""; //Decrease/Increase Defense
                    survivalCode.stealHp = ""; //Steal health from enemy
                    survivalCode.pierceDamage = ""; //Damage inflicted thru guard
                    survivalCode.weaponSize = "3FB00000";
                    survivalCode.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                    survivalCode.counterRate = ""; //Increase Counter Chance
                    survivalCode.nullCounter = ""; //Nullify Enemies Counters chance
                    survivalCode.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                    survivalCode.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                    survivalCode.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                    survivalCode.parryRegen = ""; //Recover Health when successfully Guard Impact
                    survivalCode.guardBreakRate = ""; //Increase Guard Break Chance
                    survivalCode.throwEscapeChance = ""; //Increase Throw Escape Rate
                    survivalCode.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                    survivalCode.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                    survivalCode.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "";
                    survivalCode.stageMusic = "";
                    survivalCode.stageNumber = 15;
                    survivalCode.model = "17";
                    survivalCode.costume = "00";
                    survivalCode.fightingStyle = "17";
                    survivalCode.weaponNumber = "07"; //Cassandra

                    survivalCode.aiLevel = "05"; // 00-05
                    survivalCode.weaponSpecial = ""; //Fire, Thunder, Paralysis, Cure etc
                    survivalCode.guardianForce = ""; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                    survivalCode.stickyFeet = ""; //Slippery Feets
                    survivalCode.speed = "3F84"; //3F80 default speed

                    survivalCode.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                    survivalCode.attack = ""; //Decrease/Increase Attack
                    survivalCode.defense = ""; //Decrease/Increase Defense
                    survivalCode.stealHp = ""; //Steal health from enemy
                    survivalCode.pierceDamage = ""; //Damage inflicted thru guard
                    survivalCode.weaponSize = "";
                    survivalCode.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                    survivalCode.counterRate = ""; //Increase Counter Chance
                    survivalCode.nullCounter = ""; //Nullify Enemies Counters chance
                    survivalCode.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                    survivalCode.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                    survivalCode.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                    survivalCode.parryRegen = ""; //Recover Health when successfully Guard Impact
                    survivalCode.guardBreakRate = ""; //Increase Guard Break Chance
                    survivalCode.throwEscapeChance = ""; //Increase Throw Escape Rate
                    survivalCode.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                    survivalCode.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                    survivalCode.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "0019";
                    survivalCode.stageMusic = "19";
                    survivalCode.stageNumber = 16;
                    survivalCode.model = "08";
                    survivalCode.costume = "00";
                    survivalCode.fightingStyle = "08";
                    survivalCode.weaponNumber = "07"; //Rock

                    survivalCode.aiLevel = "05"; // 00-05
                    survivalCode.weaponSpecial = ""; //Fire, Thunder, Paralysis, Cure etc
                    survivalCode.guardianForce = "06"; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                    survivalCode.stickyFeet = ""; //Slippery Feets
                    survivalCode.speed = "3F80"; //3F80 default speed

                    survivalCode.weaponEffect = "00100000"; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                    survivalCode.attack = ""; //Decrease/Increase Attack
                    survivalCode.defense = "3E000000"; //Decrease/Increase Defense
                    survivalCode.stealHp = ""; //Steal health from enemy
                    survivalCode.pierceDamage = ""; //Damage inflicted thru guard
                    survivalCode.weaponSize = "";
                    survivalCode.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                    survivalCode.counterRate = ""; //Increase Counter Chance
                    survivalCode.nullCounter = ""; //Nullify Enemies Counters chance
                    survivalCode.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                    survivalCode.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                    survivalCode.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                    survivalCode.parryRegen = ""; //Recover Health when successfully Guard Impact
                    survivalCode.guardBreakRate = ""; //Increase Guard Break Chance
                    survivalCode.throwEscapeChance = ""; //Increase Throw Escape Rate
                    survivalCode.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                    survivalCode.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                    survivalCode.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "";
                    survivalCode.stageMusic = "";
                    survivalCode.stageNumber = 17;
                    survivalCode.model = "06";
                    survivalCode.costume = "00";
                    survivalCode.fightingStyle = "06";
                    survivalCode.weaponNumber = "07"; //Sophitia

                    survivalCode.aiLevel = "05"; // 00-05
                    survivalCode.weaponSpecial = "All Guard Break"; //Fire, Thunder, Paralysis, Cure etc
                    survivalCode.guardianForce = ""; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                    survivalCode.stickyFeet = ""; //Slippery Feets
                    survivalCode.speed = "3F88"; //3F80 default speed

                    survivalCode.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                    survivalCode.attack = ""; //Decrease/Increase Attack
                    survivalCode.defense = ""; //Decrease/Increase Defense
                    survivalCode.stealHp = ""; //Steal health from enemy
                    survivalCode.pierceDamage = ""; //Damage inflicted thru guard
                    survivalCode.weaponSize = "";
                    survivalCode.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                    survivalCode.counterRate = ""; //Increase Counter Chance
                    survivalCode.nullCounter = ""; //Nullify Enemies Counters chance
                    survivalCode.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                    survivalCode.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                    survivalCode.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                    survivalCode.parryRegen = ""; //Recover Health when successfully Guard Impact
                    survivalCode.guardBreakRate = ""; //Increase Guard Break Chance
                    survivalCode.throwEscapeChance = ""; //Increase Throw Escape Rate
                    survivalCode.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                    survivalCode.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                    survivalCode.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "";
                    survivalCode.stageMusic = "";
                    survivalCode.stageNumber = 18;
                    survivalCode.model = "0D";
                    survivalCode.costume = "00";
                    survivalCode.fightingStyle = "0D";
                    survivalCode.weaponNumber = "07"; //Xianghua

                    survivalCode.aiLevel = "05"; // 00-05
                    survivalCode.weaponSpecial = "Paralysis"; //Fire, Thunder, Paralysis, Cure etc
                    survivalCode.guardianForce = ""; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                    survivalCode.stickyFeet = ""; //Slippery Feets
                    survivalCode.speed = "3F8A"; //3F80 default speed

                    survivalCode.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                    survivalCode.attack = ""; //Decrease/Increase Attack
                    survivalCode.defense = ""; //Decrease/Increase Defense
                    survivalCode.stealHp = ""; //Steal health from enemy
                    survivalCode.pierceDamage = ""; //Damage inflicted thru guard
                    survivalCode.weaponSize = "";
                    survivalCode.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                    survivalCode.counterRate = ""; //Increase Counter Chance
                    survivalCode.nullCounter = ""; //Nullify Enemies Counters chance
                    survivalCode.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                    survivalCode.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                    survivalCode.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                    survivalCode.parryRegen = ""; //Recover Health when successfully Guard Impact
                    survivalCode.guardBreakRate = ""; //Increase Guard Break Chance
                    survivalCode.throwEscapeChance = ""; //Increase Throw Escape Rate
                    survivalCode.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                    survivalCode.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                    survivalCode.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "";
                    survivalCode.stageMusic = "";
                    survivalCode.stageNumber = 19;
                    survivalCode.model = "07";
                    survivalCode.costume = "00";
                    survivalCode.fightingStyle = "07";
                    survivalCode.weaponNumber = "07"; //Siegfried

                    survivalCode.aiLevel = "05"; // 00-05
                    survivalCode.weaponSpecial = "All Unblockable"; //Fire, Thunder, Paralysis, Cure etc
                    survivalCode.guardianForce = ""; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                    survivalCode.stickyFeet = ""; //Slippery Feets
                    survivalCode.speed = "3F84"; //3F80 default speed

                    survivalCode.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                    survivalCode.attack = ""; //Decrease/Increase Attack
                    survivalCode.defense = ""; //Decrease/Increase Defense
                    survivalCode.stealHp = ""; //Steal health from enemy
                    survivalCode.pierceDamage = ""; //Damage inflicted thru guard
                    survivalCode.weaponSize = "";
                    survivalCode.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                    survivalCode.counterRate = ""; //Increase Counter Chance
                    survivalCode.nullCounter = ""; //Nullify Enemies Counters chance
                    survivalCode.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                    survivalCode.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                    survivalCode.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                    survivalCode.parryRegen = ""; //Recover Health when successfully Guard Impact
                    survivalCode.guardBreakRate = ""; //Increase Guard Break Chance
                    survivalCode.throwEscapeChance = ""; //Increase Throw Escape Rate
                    survivalCode.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                    survivalCode.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                    survivalCode.hpRegenOrDrainOnAtk = "41000000"; //Drain/Recover Health when Attacking
                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "";
                    survivalCode.stageMusic = "";
                    survivalCode.stageNumber = 20;
                    survivalCode.model = "2B";
                    survivalCode.costume = "00";
                    survivalCode.fightingStyle = "14";
                    survivalCode.weaponNumber = "05"; //Inferno

                    survivalCode.aiLevel = "05"; // 00-05
                    survivalCode.weaponSpecial = ""; //Fire, Thunder, Paralysis, Cure etc
                    survivalCode.guardianForce = "00"; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                    survivalCode.stickyFeet = ""; //Slippery Feets
                    survivalCode.speed = "3FA0"; //3F80 default speed

                    survivalCode.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                    survivalCode.attack = "40000000"; //Decrease/Increase Attack
                    survivalCode.defense = "3F400000"; //Decrease/Increase Defense
                    survivalCode.stealHp = ""; //Steal health from enemy
                    survivalCode.pierceDamage = ""; //Damage inflicted thru guard
                    survivalCode.weaponSize = "";
                    survivalCode.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                    survivalCode.counterRate = ""; //Increase Counter Chance
                    survivalCode.nullCounter = ""; //Nullify Enemies Counters chance
                    survivalCode.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                    survivalCode.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                    survivalCode.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                    survivalCode.parryRegen = ""; //Recover Health when successfully Guard Impact
                    survivalCode.guardBreakRate = ""; //Increase Guard Break Chance
                    survivalCode.throwEscapeChance = ""; //Increase Throw Escape Rate
                    survivalCode.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                    survivalCode.hpRegenOrDrain = "00000000"; //Drain/Recover Health over Time
                    survivalCode.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                    break;
                #endregion

                #region God Arc  [Night Terror]
                case "God Arc":
                    survivalCode.stageLevel = "0210";
                    survivalCode.stageMusic = "10";
                    survivalCode.stageNumber = 1;
                    survivalCode.model = "98";
                    survivalCode.costume = "00";
                    survivalCode.fightingStyle = "4D";
                    survivalCode.weaponNumber = "02"; //Keres

                    survivalCode.aiLevel = "05"; // 00-05
                    survivalCode.weaponSpecial = ""; //Fire, Thunder, Paralysis, Cure etc
                    survivalCode.guardianForce = ""; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                    survivalCode.stickyFeet = ""; //Slippery Feets
                    survivalCode.speed = "3F84"; //3F80 default speed

                    survivalCode.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                    survivalCode.attack = ""; //Decrease/Increase Attack
                    survivalCode.defense = ""; //Decrease/Increase Defense
                    survivalCode.stealHp = ""; //Steal health from enemy
                    survivalCode.pierceDamage = ""; //Damage inflicted thru guard
                    survivalCode.weaponSize = "3FA00000";
                    survivalCode.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                    survivalCode.counterRate = ""; //Increase Counter Chance
                    survivalCode.nullCounter = ""; //Nullify Enemies Counters chance
                    survivalCode.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                    survivalCode.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                    survivalCode.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                    survivalCode.parryRegen = ""; //Recover Health when successfully Guard Impact
                    survivalCode.guardBreakRate = ""; //Increase Guard Break Chance
                    survivalCode.throwEscapeChance = ""; //Increase Throw Escape Rate
                    survivalCode.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                    survivalCode.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                    survivalCode.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "";
                    survivalCode.stageMusic = "";
                    survivalCode.stageNumber = 2;
                    survivalCode.model = "28";
                    survivalCode.costume = "00";
                    survivalCode.fightingStyle = "54";
                    survivalCode.weaponNumber = "05"; //Charade #SET add a lot of piercing damage

                    survivalCode.aiLevel = "05"; // 00-05
                    survivalCode.weaponSpecial = "Paralysis"; //Fire, Thunder, Paralysis, Cure etc
                    survivalCode.guardianForce = ""; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                    survivalCode.stickyFeet = ""; //Slippery Feets
                    survivalCode.speed = "3FC0"; //3F80 default speed

                    survivalCode.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                    survivalCode.attack = ""; //Decrease/Increase Attack
                    survivalCode.defense = ""; //Decrease/Increase Defense
                    survivalCode.stealHp = ""; //Steal health from enemy
                    survivalCode.pierceDamage = "3F000000"; //Damage inflicted thru guard
                    survivalCode.weaponSize = "";
                    survivalCode.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                    survivalCode.counterRate = ""; //Increase Counter Chance
                    survivalCode.nullCounter = ""; //Nullify Enemies Counters chance
                    survivalCode.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                    survivalCode.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                    survivalCode.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                    survivalCode.parryRegen = ""; //Recover Health when successfully Guard Impact
                    survivalCode.guardBreakRate = ""; //Increase Guard Break Chance
                    survivalCode.throwEscapeChance = ""; //Increase Throw Escape Rate
                    survivalCode.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                    survivalCode.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                    survivalCode.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "";
                    survivalCode.stageMusic = "";
                    survivalCode.stageNumber = 3;
                    survivalCode.model = "93";
                    survivalCode.costume = "00";
                    survivalCode.fightingStyle = "42";
                    survivalCode.weaponNumber = "00"; //Assassin #SET poisons you and steal your hp

                    survivalCode.aiLevel = "05"; // 00-05
                    survivalCode.weaponSpecial = "Poison"; //Fire, Thunder, Paralysis, Cure etc
                    survivalCode.guardianForce = ""; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                    survivalCode.stickyFeet = ""; //Slippery Feets
                    survivalCode.speed = "3FA8"; //3F80 default speed

                    survivalCode.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                    survivalCode.attack = ""; //Decrease/Increase Attack
                    survivalCode.defense = ""; //Decrease/Increase Defense
                    survivalCode.stealHp = "40000000"; //Steal health from enemy
                    survivalCode.pierceDamage = ""; //Damage inflicted thru guard
                    survivalCode.weaponSize = "";
                    survivalCode.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                    survivalCode.counterRate = ""; //Increase Counter Chance
                    survivalCode.nullCounter = ""; //Nullify Enemies Counters chance
                    survivalCode.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                    survivalCode.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                    survivalCode.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                    survivalCode.parryRegen = ""; //Recover Health when successfully Guard Impact
                    survivalCode.guardBreakRate = ""; //Increase Guard Break Chance
                    survivalCode.throwEscapeChance = ""; //Increase Throw Escape Rate
                    survivalCode.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                    survivalCode.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                    survivalCode.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "";
                    survivalCode.stageMusic = "";
                    survivalCode.stageNumber = 4;
                    survivalCode.model = "81";
                    survivalCode.costume = "00";
                    survivalCode.fightingStyle = "48";
                    survivalCode.weaponNumber = "07"; //Berserker

                    survivalCode.aiLevel = "05"; // 00-05
                    survivalCode.weaponSpecial = "All Unblockable"; //Fire, Thunder, Paralysis, Cure etc
                    survivalCode.guardianForce = ""; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                    survivalCode.stickyFeet = ""; //Slippery Feets
                    survivalCode.speed = "3F90"; //3F80 default speed

                    survivalCode.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                    survivalCode.attack = "3F900000"; //Decrease/Increase Attack
                    survivalCode.defense = ""; //Decrease/Increase Defense
                    survivalCode.stealHp = ""; //Steal health from enemy
                    survivalCode.pierceDamage = ""; //Damage inflicted thru guard
                    survivalCode.weaponSize = "40000000";
                    survivalCode.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                    survivalCode.counterRate = ""; //Increase Counter Chance
                    survivalCode.nullCounter = ""; //Nullify Enemies Counters chance
                    survivalCode.guardHpModify = "00000000"; //Decrease/Increase Health while guarding enemies attacks
                    survivalCode.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                    survivalCode.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                    survivalCode.parryRegen = ""; //Recover Health when successfully Guard Impact
                    survivalCode.guardBreakRate = ""; //Increase Guard Break Chance
                    survivalCode.throwEscapeChance = ""; //Increase Throw Escape Rate
                    survivalCode.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                    survivalCode.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                    survivalCode.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "";
                    survivalCode.stageMusic = "";
                    survivalCode.stageNumber = 5;
                    survivalCode.model = "31";
                    survivalCode.costume = "00";
                    survivalCode.fightingStyle = "31";
                    survivalCode.weaponNumber = "00"; //Collosus

                    survivalCode.aiLevel = "05"; // 00-05
                    survivalCode.weaponSpecial = ""; //Fire, Thunder, Paralysis, Cure etc
                    survivalCode.guardianForce = ""; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                    survivalCode.stickyFeet = ""; //Slippery Feets
                    survivalCode.speed = "4000"; //3F80 default speed

                    survivalCode.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                    survivalCode.attack = ""; //Decrease/Increase Attack
                    survivalCode.defense = "3E800000"; //Decrease/Increase Defense
                    survivalCode.stealHp = ""; //Steal health from enemy
                    survivalCode.pierceDamage = ""; //Damage inflicted thru guard
                    survivalCode.weaponSize = "";
                    survivalCode.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                    survivalCode.counterRate = ""; //Increase Counter Chance
                    survivalCode.nullCounter = ""; //Nullify Enemies Counters chance
                    survivalCode.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                    survivalCode.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                    survivalCode.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                    survivalCode.parryRegen = ""; //Recover Health when successfully Guard Impact
                    survivalCode.guardBreakRate = ""; //Increase Guard Break Chance
                    survivalCode.throwEscapeChance = ""; //Increase Throw Escape Rate
                    survivalCode.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                    survivalCode.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                    survivalCode.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "0012";
                    survivalCode.stageMusic = "12";
                    survivalCode.stageNumber = 6;
                    survivalCode.model = "4D";
                    survivalCode.costume = "01";
                    survivalCode.fightingStyle = "4D";
                    survivalCode.weaponNumber = "06"; //Strife

                    survivalCode.aiLevel = "05"; // 00-05
                    survivalCode.weaponSpecial = "All Guard Break"; //Fire, Thunder, Paralysis, Cure etc
                    survivalCode.guardianForce = ""; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                    survivalCode.stickyFeet = ""; //Slippery Feets
                    survivalCode.speed = "3F98"; //3F80 default speed

                    survivalCode.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                    survivalCode.attack = ""; //Decrease/Increase Attack
                    survivalCode.defense = ""; //Decrease/Increase Defense
                    survivalCode.stealHp = "3F400000"; //Steal health from enemy
                    survivalCode.pierceDamage = "3F800000"; //Damage inflicted thru guard
                    survivalCode.weaponSize = "40800000";
                    survivalCode.atkPushForce = "41000000"; //Decrease/Increase Attack Pushback Force
                    survivalCode.counterRate = ""; //Increase Counter Chance
                    survivalCode.nullCounter = ""; //Nullify Enemies Counters chance
                    survivalCode.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                    survivalCode.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                    survivalCode.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                    survivalCode.parryRegen = ""; //Recover Health when successfully Guard Impact
                    survivalCode.guardBreakRate = ""; //Increase Guard Break Chance
                    survivalCode.throwEscapeChance = ""; //Increase Throw Escape Rate
                    survivalCode.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                    survivalCode.hpRegenOrDrain = "00000000"; //Drain/Recover Health over Time
                    survivalCode.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "";
                    survivalCode.stageMusic = "";
                    survivalCode.stageNumber = 7;
                    survivalCode.model = "30";
                    survivalCode.costume = "00";
                    survivalCode.fightingStyle = "30";
                    survivalCode.weaponNumber = "04"; //Amy

                    survivalCode.aiLevel = "05"; // 00-05
                    survivalCode.weaponSpecial = "All Unblockable"; //Fire, Thunder, Paralysis, Cure etc
                    survivalCode.guardianForce = ""; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                    survivalCode.stickyFeet = ""; //Slippery Feets
                    survivalCode.speed = "3FB0"; //3F80 default speed

                    survivalCode.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                    survivalCode.attack = ""; //Decrease/Increase Attack
                    survivalCode.defense = ""; //Decrease/Increase Defense
                    survivalCode.stealHp = ""; //Steal health from enemy
                    survivalCode.pierceDamage = ""; //Damage inflicted thru guard
                    survivalCode.weaponSize = "";
                    survivalCode.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                    survivalCode.counterRate = ""; //Increase Counter Chance
                    survivalCode.nullCounter = ""; //Nullify Enemies Counters chance
                    survivalCode.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                    survivalCode.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                    survivalCode.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                    survivalCode.parryRegen = ""; //Recover Health when successfully Guard Impact
                    survivalCode.guardBreakRate = ""; //Increase Guard Break Chance
                    survivalCode.throwEscapeChance = ""; //Increase Throw Escape Rate
                    survivalCode.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                    survivalCode.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                    survivalCode.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "";
                    survivalCode.stageMusic = "";
                    survivalCode.stageNumber = 8;
                    survivalCode.model = "1E";
                    survivalCode.costume = "00";
                    survivalCode.fightingStyle = "0E";
                    survivalCode.weaponNumber = "06"; //Lizard Men

                    survivalCode.aiLevel = "05"; // 00-05
                    survivalCode.weaponSpecial = "Ice"; //Fire, Thunder, Paralysis, Cure etc
                    survivalCode.guardianForce = ""; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                    survivalCode.stickyFeet = ""; //Slippery Feets
                    survivalCode.speed = "3FA0"; //3F80 default speed

                    survivalCode.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                    survivalCode.attack = ""; //Decrease/Increase Attack
                    survivalCode.defense = ""; //Decrease/Increase Defense
                    survivalCode.stealHp = "40000000"; //Steal health from enemy
                    survivalCode.pierceDamage = ""; //Damage inflicted thru guard
                    survivalCode.weaponSize = "";
                    survivalCode.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                    survivalCode.counterRate = ""; //Increase Counter Chance
                    survivalCode.nullCounter = ""; //Nullify Enemies Counters chance
                    survivalCode.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                    survivalCode.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                    survivalCode.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                    survivalCode.parryRegen = ""; //Recover Health when successfully Guard Impact
                    survivalCode.guardBreakRate = ""; //Increase Guard Break Chance
                    survivalCode.throwEscapeChance = ""; //Increase Throw Escape Rate
                    survivalCode.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                    survivalCode.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                    survivalCode.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "";
                    survivalCode.stageMusic = "";
                    survivalCode.stageNumber = 9;
                    survivalCode.model = "07";
                    survivalCode.costume = "01";
                    survivalCode.fightingStyle = "11";
                    survivalCode.weaponNumber = "00"; //Siegfried with Nightmare fighting style

                    survivalCode.aiLevel = "05"; // 00-05
                    survivalCode.weaponSpecial = ""; //Fire, Thunder, Paralysis, Cure etc
                    survivalCode.guardianForce = "05"; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                    survivalCode.stickyFeet = ""; //Slippery Feets
                    survivalCode.speed = "3F88"; //3F80 default speed

                    survivalCode.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                    survivalCode.attack = ""; //Decrease/Increase Attack
                    survivalCode.defense = ""; //Decrease/Increase Defense
                    survivalCode.stealHp = ""; //Steal health from enemy
                    survivalCode.pierceDamage = "3F000000"; //Damage inflicted thru guard
                    survivalCode.weaponSize = "";
                    survivalCode.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                    survivalCode.counterRate = ""; //Increase Counter Chance
                    survivalCode.nullCounter = ""; //Nullify Enemies Counters chance
                    survivalCode.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                    survivalCode.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                    survivalCode.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                    survivalCode.parryRegen = ""; //Recover Health when successfully Guard Impact
                    survivalCode.guardBreakRate = ""; //Increase Guard Break Chance
                    survivalCode.throwEscapeChance = ""; //Increase Throw Escape Rate
                    survivalCode.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                    survivalCode.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                    survivalCode.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "";
                    survivalCode.stageMusic = "";
                    survivalCode.stageNumber = 10;
                    survivalCode.model = "26";
                    survivalCode.costume = "00";
                    survivalCode.fightingStyle = "26";
                    survivalCode.weaponNumber = "00"; //Abyss

                    survivalCode.aiLevel = "05"; // 00-05
                    survivalCode.weaponSpecial = "Down Lose"; //Fire, Thunder, Paralysis, Cure etc
                    survivalCode.guardianForce = ""; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                    survivalCode.stickyFeet = ""; //Slippery Feets
                    survivalCode.speed = "3F90"; //3F80 default speed

                    survivalCode.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                    survivalCode.attack = ""; //Decrease/Increase Attack
                    survivalCode.defense = ""; //Decrease/Increase Defense
                    survivalCode.stealHp = ""; //Steal health from enemy
                    survivalCode.pierceDamage = ""; //Damage inflicted thru guard
                    survivalCode.weaponSize = "";
                    survivalCode.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                    survivalCode.counterRate = ""; //Increase Counter Chance
                    survivalCode.nullCounter = ""; //Nullify Enemies Counters chance
                    survivalCode.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                    survivalCode.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                    survivalCode.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                    survivalCode.parryRegen = ""; //Recover Health when successfully Guard Impact
                    survivalCode.guardBreakRate = ""; //Increase Guard Break Chance
                    survivalCode.throwEscapeChance = ""; //Increase Throw Escape Rate
                    survivalCode.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                    survivalCode.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                    survivalCode.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "0019";
                    survivalCode.stageMusic = "19";
                    survivalCode.stageNumber = 11;
                    survivalCode.model = "15";
                    survivalCode.costume = "00";
                    survivalCode.fightingStyle = "15";
                    survivalCode.weaponNumber = "05"; //Raphael

                    survivalCode.aiLevel = "05"; // 00-05
                    survivalCode.weaponSpecial = "All Unblockable"; //Fire, Thunder, Paralysis, Cure etc
                    survivalCode.guardianForce = ""; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                    survivalCode.stickyFeet = ""; //Slippery Feets
                    survivalCode.speed = "3FA0"; //3F80 default speed

                    survivalCode.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                    survivalCode.attack = ""; //Decrease/Increase Attack
                    survivalCode.defense = ""; //Decrease/Increase Defense
                    survivalCode.stealHp = ""; //Steal health from enemy
                    survivalCode.pierceDamage = ""; //Damage inflicted thru guard
                    survivalCode.weaponSize = "";
                    survivalCode.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                    survivalCode.counterRate = ""; //Increase Counter Chance
                    survivalCode.nullCounter = ""; //Nullify Enemies Counters chance
                    survivalCode.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                    survivalCode.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                    survivalCode.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                    survivalCode.parryRegen = ""; //Recover Health when successfully Guard Impact
                    survivalCode.guardBreakRate = ""; //Increase Guard Break Chance
                    survivalCode.throwEscapeChance = ""; //Increase Throw Escape Rate
                    survivalCode.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                    survivalCode.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                    survivalCode.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "";
                    survivalCode.stageMusic = "";
                    survivalCode.stageNumber = 12;
                    survivalCode.model = "12";
                    survivalCode.costume = "00";
                    survivalCode.fightingStyle = "12";
                    survivalCode.weaponNumber = "05"; //Astaroth

                    survivalCode.aiLevel = "05"; // 00-05
                    survivalCode.weaponSpecial = ""; //Fire, Thunder, Paralysis, Cure etc
                    survivalCode.guardianForce = "05"; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                    survivalCode.stickyFeet = ""; //Slippery Feets
                    survivalCode.speed = "3F40"; //3F80 default speed

                    survivalCode.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                    survivalCode.attack = "40400000"; //Decrease/Increase Attack
                    survivalCode.defense = "3F400000"; //Decrease/Increase Defense
                    survivalCode.stealHp = ""; //Steal health from enemy
                    survivalCode.pierceDamage = ""; //Damage inflicted thru guard
                    survivalCode.weaponSize = "";
                    survivalCode.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                    survivalCode.counterRate = ""; //Increase Counter Chance
                    survivalCode.nullCounter = ""; //Nullify Enemies Counters chance
                    survivalCode.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                    survivalCode.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                    survivalCode.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                    survivalCode.parryRegen = ""; //Recover Health when successfully Guard Impact
                    survivalCode.guardBreakRate = ""; //Increase Guard Break Chance
                    survivalCode.throwEscapeChance = ""; //Increase Throw Escape Rate
                    survivalCode.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                    survivalCode.hpRegenOrDrain = "00000000"; //Drain/Recover Health over Time
                    survivalCode.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "";
                    survivalCode.stageMusic = "";
                    survivalCode.stageNumber = 13;
                    survivalCode.model = "02";
                    survivalCode.costume = "00";
                    survivalCode.fightingStyle = "02";
                    survivalCode.weaponNumber = "03"; //Seong Mi-na 

                    survivalCode.aiLevel = "05"; // 00-05
                    survivalCode.weaponSpecial = "Paralysis"; //Fire, Thunder, Paralysis, Cure etc
                    survivalCode.guardianForce = ""; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                    survivalCode.stickyFeet = ""; //Slippery Feets
                    survivalCode.speed = "3FA8"; //3F80 default speed

                    survivalCode.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                    survivalCode.attack = ""; //Decrease/Increase Attack
                    survivalCode.defense = ""; //Decrease/Increase Defense
                    survivalCode.stealHp = ""; //Steal health from enemy
                    survivalCode.pierceDamage = "3F800000"; //Damage inflicted thru guard
                    survivalCode.weaponSize = "40800000";
                    survivalCode.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                    survivalCode.counterRate = ""; //Increase Counter Chance
                    survivalCode.nullCounter = ""; //Nullify Enemies Counters chance
                    survivalCode.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                    survivalCode.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                    survivalCode.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                    survivalCode.parryRegen = ""; //Recover Health when successfully Guard Impact
                    survivalCode.guardBreakRate = ""; //Increase Guard Break Chance
                    survivalCode.throwEscapeChance = ""; //Increase Throw Escape Rate
                    survivalCode.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                    survivalCode.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                    survivalCode.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "";
                    survivalCode.stageMusic = "";
                    survivalCode.stageNumber = 14;
                    survivalCode.model = "06";
                    survivalCode.costume = "00";
                    survivalCode.fightingStyle = "06";
                    survivalCode.weaponNumber = "05"; //Sophitia

                    survivalCode.aiLevel = "05"; // 00-05
                    survivalCode.weaponSpecial = "Cure"; //Fire, Thunder, Paralysis, Cure etc
                    survivalCode.guardianForce = ""; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                    survivalCode.stickyFeet = ""; //Slippery Feets
                    survivalCode.speed = "3FA0"; //3F80 default speed

                    survivalCode.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                    survivalCode.attack = ""; //Decrease/Increase Attack
                    survivalCode.defense = ""; //Decrease/Increase Defense
                    survivalCode.stealHp = ""; //Steal health from enemy
                    survivalCode.pierceDamage = ""; //Damage inflicted thru guard
                    survivalCode.weaponSize = "3FA00000";
                    survivalCode.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                    survivalCode.counterRate = ""; //Increase Counter Chance
                    survivalCode.nullCounter = ""; //Nullify Enemies Counters chance
                    survivalCode.guardHpModify = "3E800000"; //Decrease/Increase Health while guarding enemies attacks
                    survivalCode.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                    survivalCode.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                    survivalCode.parryRegen = "3E800000"; //Recover Health when successfully Guard Impact
                    survivalCode.guardBreakRate = ""; //Increase Guard Break Chance
                    survivalCode.throwEscapeChance = "40000000"; //Increase Throw Escape Rate
                    survivalCode.ringOutEscapeChance = "40000000"; //Increase Ring-Out Escape Rate
                    survivalCode.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                    survivalCode.hpRegenOrDrainOnAtk = "C0000000"; //Drain/Recover Health when Attacking
                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "";
                    survivalCode.stageMusic = "";
                    survivalCode.stageNumber = 15;
                    survivalCode.model = "2B";
                    survivalCode.costume = "00";
                    survivalCode.fightingStyle = "14";
                    survivalCode.weaponNumber = "05"; //Inferno

                    survivalCode.aiLevel = "05"; // 00-05
                    survivalCode.weaponSpecial = "All Unblockable"; //Fire, Thunder, Paralysis, Cure etc
                    survivalCode.guardianForce = "00"; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                    survivalCode.stickyFeet = ""; //Slippery Feets
                    survivalCode.speed = "3FA0"; //3F80 default speed

                    survivalCode.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                    survivalCode.attack = "40000000"; //Decrease/Increase Attack
                    survivalCode.defense = "3F700000"; //Decrease/Increase Defense
                    survivalCode.stealHp = ""; //Steal health from enemy
                    survivalCode.pierceDamage = ""; //Damage inflicted thru guard
                    survivalCode.weaponSize = "";
                    survivalCode.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                    survivalCode.counterRate = ""; //Increase Counter Chance
                    survivalCode.nullCounter = ""; //Nullify Enemies Counters chance
                    survivalCode.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                    survivalCode.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                    survivalCode.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                    survivalCode.parryRegen = ""; //Recover Health when successfully Guard Impact
                    survivalCode.guardBreakRate = ""; //Increase Guard Break Chance
                    survivalCode.throwEscapeChance = ""; //Increase Throw Escape Rate
                    survivalCode.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                    survivalCode.hpRegenOrDrain = "00000000"; //Drain/Recover Health over Time
                    survivalCode.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "0009";
                    survivalCode.stageMusic = "09";
                    survivalCode.stageNumber = 16;
                    survivalCode.model = "ED";
                    survivalCode.costume = "01";
                    survivalCode.fightingStyle = "4E";
                    survivalCode.weaponNumber = "06"; //Hyle

                    survivalCode.aiLevel = "05"; // 00-05
                    survivalCode.weaponSpecial = "All Guard Break"; //Fire, Thunder, Paralysis, Cure etc
                    survivalCode.guardianForce = ""; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                    survivalCode.stickyFeet = ""; //Slippery Feets
                    survivalCode.speed = "3FA0"; //3F80 default speed

                    survivalCode.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                    survivalCode.attack = ""; //Decrease/Increase Attack
                    survivalCode.defense = "3E800000"; //Decrease/Increase Defense
                    survivalCode.stealHp = ""; //Steal health from enemy
                    survivalCode.pierceDamage = ""; //Damage inflicted thru guard
                    survivalCode.weaponSize = "";
                    survivalCode.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                    survivalCode.counterRate = ""; //Increase Counter Chance
                    survivalCode.nullCounter = ""; //Nullify Enemies Counters chance
                    survivalCode.guardHpModify = "3E800000"; //Decrease/Increase Health while guarding enemies attacks
                    survivalCode.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                    survivalCode.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                    survivalCode.parryRegen = ""; //Recover Health when successfully Guard Impact
                    survivalCode.guardBreakRate = ""; //Increase Guard Break Chance
                    survivalCode.throwEscapeChance = ""; //Increase Throw Escape Rate
                    survivalCode.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                    survivalCode.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                    survivalCode.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "";
                    survivalCode.stageMusic = "";
                    survivalCode.stageNumber = 17;
                    survivalCode.model = "43";
                    survivalCode.costume = "00";
                    survivalCode.fightingStyle = "43";
                    survivalCode.weaponNumber = "14"; //Arthur with Soul Calibur from Luna

                    survivalCode.aiLevel = "05"; // 00-05
                    survivalCode.weaponSpecial = "All Unblockable"; //Fire, Thunder, Paralysis, Cure etc
                    survivalCode.guardianForce = ""; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                    survivalCode.stickyFeet = ""; //Slippery Feets
                    survivalCode.speed = "3FA0"; //3F80 default speed

                    survivalCode.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                    survivalCode.attack = ""; //Decrease/Increase Attack
                    survivalCode.defense = ""; //Decrease/Increase Defense
                    survivalCode.stealHp = ""; //Steal health from enemy
                    survivalCode.pierceDamage = ""; //Damage inflicted thru guard
                    survivalCode.weaponSize = "3FC00000";
                    survivalCode.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                    survivalCode.counterRate = ""; //Increase Counter Chance
                    survivalCode.nullCounter = ""; //Nullify Enemies Counters chance
                    survivalCode.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                    survivalCode.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                    survivalCode.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                    survivalCode.parryRegen = ""; //Recover Health when successfully Guard Impact
                    survivalCode.guardBreakRate = ""; //Increase Guard Break Chance
                    survivalCode.throwEscapeChance = ""; //Increase Throw Escape Rate
                    survivalCode.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                    survivalCode.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                    survivalCode.hpRegenOrDrainOnAtk = "C1800000"; //Drain/Recover Health when Attacking
                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "";
                    survivalCode.stageMusic = "";
                    survivalCode.stageNumber = 18;
                    survivalCode.model = "27";
                    survivalCode.costume = "00";
                    survivalCode.fightingStyle = "27";
                    survivalCode.weaponNumber = "00"; //Night Terror

                    survivalCode.aiLevel = "05"; // 00-05
                    survivalCode.weaponSpecial = "All Unblockable"; //Fire, Thunder, Paralysis, Cure etc
                    survivalCode.guardianForce = "05"; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                    survivalCode.stickyFeet = ""; //Slippery Feets
                    survivalCode.speed = "3F90"; //3F80 default speed

                    survivalCode.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                    survivalCode.attack = ""; //Decrease/Increase Attack
                    survivalCode.defense = ""; //Decrease/Increase Defense
                    survivalCode.stealHp = ""; //Steal health from enemy
                    survivalCode.pierceDamage = ""; //Damage inflicted thru guard
                    survivalCode.weaponSize = "";
                    survivalCode.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                    survivalCode.counterRate = ""; //Increase Counter Chance
                    survivalCode.nullCounter = ""; //Nullify Enemies Counters chance
                    survivalCode.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                    survivalCode.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                    survivalCode.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                    survivalCode.parryRegen = ""; //Recover Health when successfully Guard Impact
                    survivalCode.guardBreakRate = ""; //Increase Guard Break Chance
                    survivalCode.throwEscapeChance = ""; //Increase Throw Escape Rate
                    survivalCode.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                    survivalCode.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                    survivalCode.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "";
                    survivalCode.stageMusic = "";
                    survivalCode.stageNumber = 19;
                    survivalCode.model = "03";
                    survivalCode.costume = "00";
                    survivalCode.fightingStyle = "03";
                    survivalCode.weaponNumber = "6D"; //Taki with Cervantes Soul Edge

                    survivalCode.aiLevel = "05"; // 00-05
                    survivalCode.weaponSpecial = "All Unblockable"; //Fire, Thunder, Paralysis, Cure etc
                    survivalCode.guardianForce = ""; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                    survivalCode.stickyFeet = ""; //Slippery Feets
                    survivalCode.speed = "3FB0"; //3F80 default speed

                    survivalCode.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                    survivalCode.attack = ""; //Decrease/Increase Attack
                    survivalCode.defense = ""; //Decrease/Increase Defense
                    survivalCode.stealHp = "40000000"; //Steal health from enemy
                    survivalCode.pierceDamage = ""; //Damage inflicted thru guard
                    survivalCode.weaponSize = "3FC00000";
                    survivalCode.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                    survivalCode.counterRate = ""; //Increase Counter Chance
                    survivalCode.nullCounter = ""; //Nullify Enemies Counters chance
                    survivalCode.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                    survivalCode.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                    survivalCode.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                    survivalCode.parryRegen = ""; //Recover Health when successfully Guard Impact
                    survivalCode.guardBreakRate = ""; //Increase Guard Break Chance
                    survivalCode.throwEscapeChance = ""; //Increase Throw Escape Rate
                    survivalCode.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                    survivalCode.hpRegenOrDrain = "00000000"; //Drain/Recover Health over Time
                    survivalCode.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "";
                    survivalCode.stageMusic = "";
                    survivalCode.stageNumber = 20;
                    survivalCode.model = "25";
                    survivalCode.costume = "00";
                    survivalCode.fightingStyle = "25";
                    survivalCode.weaponNumber = "07"; //Olcadan 

                    survivalCode.aiLevel = "05"; // 00-05
                    survivalCode.weaponSpecial = ""; //Fire, Thunder, Paralysis, Cure etc
                    survivalCode.guardianForce = ""; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                    survivalCode.stickyFeet = ""; //Slippery Feets
                    survivalCode.speed = "3F80"; //3F80 default speed

                    survivalCode.weaponEffect = "00100000"; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                    survivalCode.attack = "3FB33332"; //Decrease/Increase Attack
                    survivalCode.defense = "3F19A957"; //Decrease/Increase Defense
                    survivalCode.stealHp = "3EFFFFFE"; //Steal health from enemy
                    survivalCode.pierceDamage = "3EFFFFFE"; //Damage inflicted thru guard
                    survivalCode.weaponSize = "3FA66665";
                    survivalCode.atkPushForce = "3FA66665"; //Decrease/Increase Attack Pushback Force
                    survivalCode.counterRate = "3EFFFFFE"; //Increase Counter Chance
                    survivalCode.nullCounter = "3F199998"; //Nullify Enemies Counters chance
                    survivalCode.guardHpModify = "3DCCCCCB"; //Decrease/Increase Health while guarding enemies attacks
                    survivalCode.autoGuardImpact = "3DCCCCCB"; //Automatically Guard Impact some attacks
                    survivalCode.parryDamage = "3F199998"; //Increase Damage Received by Opponent when successfully Guard Impact
                    survivalCode.parryRegen = "3EFFFFFE"; //Recover Health when successfully Guard Impact
                    survivalCode.guardBreakRate = "3E199998"; //Increase Guard Break Chance
                    survivalCode.throwEscapeChance = "3F333332"; //Increase Throw Escape Rate
                    survivalCode.ringOutEscapeChance = "3F333332"; //Increase Ring-Out Escape Rate
                    survivalCode.hpRegenOrDrain = "3D4CCCCC"; //Drain/Recover Health over Time
                    survivalCode.hpRegenOrDrainOnAtk = "C0800000"; //Drain/Recover Health when Attacking
                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                    break;
                #endregion

                #region Special Arc  [Nina]
                case "Special Arc":
                    survivalCode.stageLevel = "0010";
                    survivalCode.stageMusic = "10";
                    survivalCode.stageNumber = 1;
                    survivalCode.model = "0F";
                    survivalCode.costume = "09";
                    survivalCode.fightingStyle = "0F";
                    survivalCode.weaponNumber = "05"; //Yoshimitsu

                    survivalCode.aiLevel = "05"; // 00-05
                    survivalCode.weaponSpecial = ""; //Fire, Thunder, Paralysis, Cure etc
                    survivalCode.guardianForce = ""; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                    survivalCode.stickyFeet = ""; //Slippery Feets
                    survivalCode.speed = "3F80"; //3F80 default speed
                    survivalCode.voice = null;

                    survivalCode.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                    survivalCode.attack = ""; //Decrease/Increase Attack
                    survivalCode.defense = ""; //Decrease/Increase Defense
                    survivalCode.stealHp = ""; //Steal health from enemy
                    survivalCode.pierceDamage = ""; //Damage inflicted thru guard
                    survivalCode.weaponSize = "";
                    survivalCode.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                    survivalCode.counterRate = ""; //Increase Counter Chance
                    survivalCode.nullCounter = ""; //Nullify Enemies Counters chance
                    survivalCode.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                    survivalCode.autoGuardImpact = "3DCCCCCB"; //Automatically Guard Impact some attacks
                    survivalCode.parryDamage = "3E000000"; //Increase Damage Received by Opponent when successfully Guard Impact
                    survivalCode.parryRegen = "40000000"; //Recover Health when successfully Guard Impact
                    survivalCode.guardBreakRate = ""; //Increase Guard Break Chance
                    survivalCode.throwEscapeChance = ""; //Increase Throw Escape Rate
                    survivalCode.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                    survivalCode.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                    survivalCode.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "";
                    survivalCode.stageMusic = "";
                    survivalCode.stageNumber = 2;
                    survivalCode.model = "30";
                    survivalCode.costume = "00";
                    survivalCode.fightingStyle = "30";
                    survivalCode.weaponNumber = "04"; //Amy

                    survivalCode.aiLevel = "05"; // 00-05
                    survivalCode.weaponSpecial = ""; //Fire, Thunder, Paralysis, Cure etc
                    survivalCode.guardianForce = ""; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                    survivalCode.stickyFeet = ""; //Slippery Feets
                    survivalCode.speed = "3F80"; //3F80 default speed
                    survivalCode.voice = null;

                    survivalCode.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                    survivalCode.attack = ""; //Decrease/Increase Attack
                    survivalCode.defense = ""; //Decrease/Increase Defense
                    survivalCode.stealHp = ""; //Steal health from enemy
                    survivalCode.pierceDamage = ""; //Damage inflicted thru guard
                    survivalCode.weaponSize = "";
                    survivalCode.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                    survivalCode.counterRate = ""; //Increase Counter Chance
                    survivalCode.nullCounter = ""; //Nullify Enemies Counters chance
                    survivalCode.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                    survivalCode.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                    survivalCode.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                    survivalCode.parryRegen = ""; //Recover Health when successfully Guard Impact
                    survivalCode.guardBreakRate = ""; //Increase Guard Break Chance
                    survivalCode.throwEscapeChance = ""; //Increase Throw Escape Rate
                    survivalCode.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                    survivalCode.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                    survivalCode.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "";
                    survivalCode.stageMusic = "";
                    survivalCode.stageNumber = 3;
                    survivalCode.model = "EA";
                    survivalCode.costume = "01";
                    survivalCode.fightingStyle = "48";
                    survivalCode.weaponNumber = "06"; //Lupi

                    survivalCode.aiLevel = "05"; // 00-05
                    survivalCode.weaponSpecial = ""; //Fire, Thunder, Paralysis, Cure etc
                    survivalCode.guardianForce = ""; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                    survivalCode.stickyFeet = ""; //Slippery Feets
                    survivalCode.speed = "3F84"; //3F80 default speed
                    survivalCode.voice = null;

                    survivalCode.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                    survivalCode.attack = ""; //Decrease/Increase Attack
                    survivalCode.defense = ""; //Decrease/Increase Defense
                    survivalCode.stealHp = ""; //Steal health from enemy
                    survivalCode.pierceDamage = ""; //Damage inflicted thru guard
                    survivalCode.weaponSize = "";
                    survivalCode.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                    survivalCode.counterRate = ""; //Increase Counter Chance
                    survivalCode.nullCounter = ""; //Nullify Enemies Counters chance
                    survivalCode.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                    survivalCode.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                    survivalCode.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                    survivalCode.parryRegen = ""; //Recover Health when successfully Guard Impact
                    survivalCode.guardBreakRate = ""; //Increase Guard Break Chance
                    survivalCode.throwEscapeChance = ""; //Increase Throw Escape Rate
                    survivalCode.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                    survivalCode.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                    survivalCode.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "";
                    survivalCode.stageMusic = "";
                    survivalCode.stageNumber = 4;
                    survivalCode.model = "2E";
                    survivalCode.costume = "00";
                    survivalCode.fightingStyle = "2E";
                    survivalCode.weaponNumber = "04"; //Shadow Master

                    survivalCode.aiLevel = "05"; // 00-05
                    survivalCode.weaponSpecial = ""; //Fire, Thunder, Paralysis, Cure etc
                    survivalCode.guardianForce = ""; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                    survivalCode.stickyFeet = ""; //Slippery Feets
                    survivalCode.speed = "3F84"; //3F80 default speed
                    survivalCode.voice = null;

                    survivalCode.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                    survivalCode.attack = ""; //Decrease/Increase Attack
                    survivalCode.defense = ""; //Decrease/Increase Defense
                    survivalCode.stealHp = ""; //Steal health from enemy
                    survivalCode.pierceDamage = ""; //Damage inflicted thru guard
                    survivalCode.weaponSize = "";
                    survivalCode.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                    survivalCode.counterRate = ""; //Increase Counter Chance
                    survivalCode.nullCounter = ""; //Nullify Enemies Counters chance
                    survivalCode.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                    survivalCode.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                    survivalCode.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                    survivalCode.parryRegen = ""; //Recover Health when successfully Guard Impact
                    survivalCode.guardBreakRate = ""; //Increase Guard Break Chance
                    survivalCode.throwEscapeChance = ""; //Increase Throw Escape Rate
                    survivalCode.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                    survivalCode.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                    survivalCode.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "";
                    survivalCode.stageMusic = "";
                    survivalCode.stageNumber = 5;
                    survivalCode.model = "31";
                    survivalCode.costume = "00";
                    survivalCode.fightingStyle = "31";
                    survivalCode.weaponNumber = "00"; //Colossus

                    survivalCode.aiLevel = "05"; // 00-05
                    survivalCode.weaponSpecial = ""; //Fire, Thunder, Paralysis, Cure etc
                    survivalCode.guardianForce = ""; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                    survivalCode.stickyFeet = ""; //Slippery Feets
                    survivalCode.speed = "3F80"; //3F80 default speed
                    survivalCode.voice = null;

                    survivalCode.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                    survivalCode.attack = ""; //Decrease/Increase Attack
                    survivalCode.defense = "3F000000"; //Decrease/Increase Defense
                    survivalCode.stealHp = ""; //Steal health from enemy
                    survivalCode.pierceDamage = ""; //Damage inflicted thru guard
                    survivalCode.weaponSize = "";
                    survivalCode.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                    survivalCode.counterRate = ""; //Increase Counter Chance
                    survivalCode.nullCounter = ""; //Nullify Enemies Counters chance
                    survivalCode.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                    survivalCode.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                    survivalCode.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                    survivalCode.parryRegen = ""; //Recover Health when successfully Guard Impact
                    survivalCode.guardBreakRate = ""; //Increase Guard Break Chance
                    survivalCode.throwEscapeChance = ""; //Increase Throw Escape Rate
                    survivalCode.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                    survivalCode.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                    survivalCode.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "0000";
                    survivalCode.stageMusic = "00";
                    survivalCode.stageNumber = 6;
                    survivalCode.model = "E9";
                    survivalCode.costume = "02";
                    survivalCode.fightingStyle = "42";
                    survivalCode.weaponNumber = "04"; //Tina (Created) #VOICE 74
                    survivalCode.voice = "74";

                    survivalCode.aiLevel = "05"; // 00-05
                    survivalCode.weaponSpecial = "Paralysis"; //Fire, Thunder, Paralysis, Cure etc
                    survivalCode.guardianForce = ""; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                    survivalCode.stickyFeet = ""; //Slippery Feets
                    survivalCode.speed = "3F80"; //3F80 default speed

                    survivalCode.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                    survivalCode.attack = ""; //Decrease/Increase Attack
                    survivalCode.defense = ""; //Decrease/Increase Defense
                    survivalCode.stealHp = ""; //Steal health from enemy
                    survivalCode.pierceDamage = ""; //Damage inflicted thru guard
                    survivalCode.weaponSize = "";
                    survivalCode.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                    survivalCode.counterRate = ""; //Increase Counter Chance
                    survivalCode.nullCounter = ""; //Nullify Enemies Counters chance
                    survivalCode.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                    survivalCode.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                    survivalCode.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                    survivalCode.parryRegen = ""; //Recover Health when successfully Guard Impact
                    survivalCode.guardBreakRate = ""; //Increase Guard Break Chance
                    survivalCode.throwEscapeChance = ""; //Increase Throw Escape Rate
                    survivalCode.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                    survivalCode.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                    survivalCode.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "";
                    survivalCode.stageMusic = "";
                    survivalCode.stageNumber = 7;
                    survivalCode.model = "E1";
                    survivalCode.costume = "02";
                    survivalCode.fightingStyle = "45";
                    survivalCode.weaponNumber = "06"; //Luna

                    survivalCode.aiLevel = "05"; // 00-05
                    survivalCode.weaponSpecial = ""; //Fire, Thunder, Paralysis, Cure etc
                    survivalCode.guardianForce = ""; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                    survivalCode.stickyFeet = ""; //Slippery Feets
                    survivalCode.speed = "3F80"; //3F80 default speed
                    survivalCode.voice = null;

                    survivalCode.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                    survivalCode.attack = ""; //Decrease/Increase Attack
                    survivalCode.defense = ""; //Decrease/Increase Defense
                    survivalCode.stealHp = ""; //Steal health from enemy
                    survivalCode.pierceDamage = ""; //Damage inflicted thru guard
                    survivalCode.weaponSize = "";
                    survivalCode.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                    survivalCode.counterRate = ""; //Increase Counter Chance
                    survivalCode.nullCounter = ""; //Nullify Enemies Counters chance
                    survivalCode.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                    survivalCode.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                    survivalCode.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                    survivalCode.parryRegen = ""; //Recover Health when successfully Guard Impact
                    survivalCode.guardBreakRate = ""; //Increase Guard Break Chance
                    survivalCode.throwEscapeChance = ""; //Increase Throw Escape Rate
                    survivalCode.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                    survivalCode.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                    survivalCode.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "";
                    survivalCode.stageMusic = "";
                    survivalCode.stageNumber = 8;
                    survivalCode.model = "B6";
                    survivalCode.costume = "02";
                    survivalCode.fightingStyle = "4D";
                    survivalCode.weaponNumber = "06"; //Areon

                    survivalCode.aiLevel = "05"; // 00-05
                    survivalCode.weaponSpecial = ""; //Fire, Thunder, Paralysis, Cure etc
                    survivalCode.guardianForce = ""; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                    survivalCode.stickyFeet = ""; //Slippery Feets
                    survivalCode.speed = "3F80"; //3F80 default speed
                    survivalCode.voice = null;

                    survivalCode.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                    survivalCode.attack = ""; //Decrease/Increase Attack
                    survivalCode.defense = ""; //Decrease/Increase Defense
                    survivalCode.stealHp = ""; //Steal health from enemy
                    survivalCode.pierceDamage = "3F000000"; //Damage inflicted thru guard
                    survivalCode.weaponSize = "";
                    survivalCode.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                    survivalCode.counterRate = ""; //Increase Counter Chance
                    survivalCode.nullCounter = ""; //Nullify Enemies Counters chance
                    survivalCode.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                    survivalCode.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                    survivalCode.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                    survivalCode.parryRegen = ""; //Recover Health when successfully Guard Impact
                    survivalCode.guardBreakRate = ""; //Increase Guard Break Chance
                    survivalCode.throwEscapeChance = ""; //Increase Throw Escape Rate
                    survivalCode.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                    survivalCode.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                    survivalCode.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "";
                    survivalCode.stageMusic = "";
                    survivalCode.stageNumber = 9;
                    survivalCode.model = "A6";
                    survivalCode.costume = "00";
                    survivalCode.fightingStyle = "44";
                    survivalCode.weaponNumber = "02"; //Xiaoxin (Voice) 68
                    survivalCode.voice = "68";

                    survivalCode.aiLevel = "05"; // 00-05
                    survivalCode.weaponSpecial = "All Guard Break"; //Fire, Thunder, Paralysis, Cure etc
                    survivalCode.guardianForce = ""; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                    survivalCode.stickyFeet = ""; //Slippery Feets
                    survivalCode.speed = "3F82"; //3F80 default speed

                    survivalCode.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                    survivalCode.attack = ""; //Decrease/Increase Attack
                    survivalCode.defense = ""; //Decrease/Increase Defense
                    survivalCode.stealHp = ""; //Steal health from enemy
                    survivalCode.pierceDamage = ""; //Damage inflicted thru guard
                    survivalCode.weaponSize = "";
                    survivalCode.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                    survivalCode.counterRate = ""; //Increase Counter Chance
                    survivalCode.nullCounter = ""; //Nullify Enemies Counters chance
                    survivalCode.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                    survivalCode.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                    survivalCode.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                    survivalCode.parryRegen = ""; //Recover Health when successfully Guard Impact
                    survivalCode.guardBreakRate = ""; //Increase Guard Break Chance
                    survivalCode.throwEscapeChance = ""; //Increase Throw Escape Rate
                    survivalCode.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                    survivalCode.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                    survivalCode.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "";
                    survivalCode.stageMusic = "";
                    survivalCode.stageNumber = 10;
                    survivalCode.model = "A0";
                    survivalCode.costume = "00";
                    survivalCode.fightingStyle = "41";
                    survivalCode.weaponNumber = "02"; //Jinkai (Voice) 6A
                    survivalCode.voice = "6A";

                    survivalCode.aiLevel = "05"; // 00-05
                    survivalCode.weaponSpecial = "All Guard Break"; //Fire, Thunder, Paralysis, Cure etc
                    survivalCode.guardianForce = ""; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                    survivalCode.stickyFeet = ""; //Slippery Feets
                    survivalCode.speed = "3F84"; //3F80 default speed

                    survivalCode.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                    survivalCode.attack = ""; //Decrease/Increase Attack
                    survivalCode.defense = ""; //Decrease/Increase Defense
                    survivalCode.stealHp = ""; //Steal health from enemy
                    survivalCode.pierceDamage = ""; //Damage inflicted thru guard
                    survivalCode.weaponSize = "";
                    survivalCode.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                    survivalCode.counterRate = ""; //Increase Counter Chance
                    survivalCode.nullCounter = ""; //Nullify Enemies Counters chance
                    survivalCode.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                    survivalCode.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                    survivalCode.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                    survivalCode.parryRegen = ""; //Recover Health when successfully Guard Impact
                    survivalCode.guardBreakRate = ""; //Increase Guard Break Chance
                    survivalCode.throwEscapeChance = ""; //Increase Throw Escape Rate
                    survivalCode.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                    survivalCode.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                    survivalCode.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "000F";
                    survivalCode.stageMusic = "0F";
                    survivalCode.stageNumber = 11;
                    survivalCode.model = "81";
                    survivalCode.costume = "00";    
                    survivalCode.fightingStyle = "48";
                    survivalCode.weaponNumber = "04"; //Berserker

                    survivalCode.aiLevel = "05"; // 00-05
                    survivalCode.weaponSpecial = ""; //Fire, Thunder, Paralysis, Cure etc
                    survivalCode.guardianForce = ""; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                    survivalCode.stickyFeet = ""; //Slippery Feets
                    survivalCode.speed = "3F80"; //3F80 default speed
                    survivalCode.voice = null;

                    survivalCode.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                    survivalCode.attack = ""; //Decrease/Increase Attack
                    survivalCode.defense = ""; //Decrease/Increase Defense
                    survivalCode.stealHp = ""; //Steal health from enemy
                    survivalCode.pierceDamage = ""; //Damage inflicted thru guard
                    survivalCode.weaponSize = "";
                    survivalCode.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                    survivalCode.counterRate = ""; //Increase Counter Chance
                    survivalCode.nullCounter = ""; //Nullify Enemies Counters chance
                    survivalCode.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                    survivalCode.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                    survivalCode.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                    survivalCode.parryRegen = ""; //Recover Health when successfully Guard Impact
                    survivalCode.guardBreakRate = ""; //Increase Guard Break Chance
                    survivalCode.throwEscapeChance = ""; //Increase Throw Escape Rate
                    survivalCode.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                    survivalCode.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                    survivalCode.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "";
                    survivalCode.stageMusic = "";
                    survivalCode.stageNumber = 12;
                    survivalCode.model = "25";
                    survivalCode.costume = "00";
                    survivalCode.fightingStyle = "25";
                    survivalCode.weaponNumber = "05"; //Olcadan

                    survivalCode.aiLevel = "05"; // 00-05
                    survivalCode.weaponSpecial = ""; //Fire, Thunder, Paralysis, Cure etc
                    survivalCode.guardianForce = ""; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                    survivalCode.stickyFeet = ""; //Slippery Feets
                    survivalCode.speed = "3F80"; //3F80 default speed
                    survivalCode.voice = null;

                    survivalCode.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                    survivalCode.attack = ""; //Decrease/Increase Attack
                    survivalCode.defense = ""; //Decrease/Increase Defense
                    survivalCode.stealHp = ""; //Steal health from enemy
                    survivalCode.pierceDamage = ""; //Damage inflicted thru guard
                    survivalCode.weaponSize = "";
                    survivalCode.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                    survivalCode.counterRate = ""; //Increase Counter Chance
                    survivalCode.nullCounter = ""; //Nullify Enemies Counters chance
                    survivalCode.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                    survivalCode.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                    survivalCode.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                    survivalCode.parryRegen = ""; //Recover Health when successfully Guard Impact
                    survivalCode.guardBreakRate = ""; //Increase Guard Break Chance
                    survivalCode.throwEscapeChance = ""; //Increase Throw Escape Rate
                    survivalCode.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                    survivalCode.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                    survivalCode.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "";
                    survivalCode.stageMusic = "";
                    survivalCode.stageNumber = 13;
                    survivalCode.model = "BF";
                    survivalCode.costume = "01";
                    survivalCode.fightingStyle = "54";
                    survivalCode.weaponNumber = "04"; //Riese (Voice) 70
                    survivalCode.voice = "70";
                    survivalCode.specialData = "Riese voice";

                    survivalCode.aiLevel = "05"; // 00-05
                    survivalCode.weaponSpecial = "All Guard Break"; //Fire, Thunder, Paralysis, Cure etc
                    survivalCode.guardianForce = ""; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                    survivalCode.stickyFeet = ""; //Slippery Feets
                    survivalCode.speed = "3F80"; //3F80 default speed

                    survivalCode.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                    survivalCode.attack = ""; //Decrease/Increase Attack
                    survivalCode.defense = ""; //Decrease/Increase Defense
                    survivalCode.stealHp = ""; //Steal health from enemy
                    survivalCode.pierceDamage = ""; //Damage inflicted thru guard
                    survivalCode.weaponSize = "";
                    survivalCode.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                    survivalCode.counterRate = ""; //Increase Counter Chance
                    survivalCode.nullCounter = ""; //Nullify Enemies Counters chance
                    survivalCode.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                    survivalCode.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                    survivalCode.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                    survivalCode.parryRegen = ""; //Recover Health when successfully Guard Impact
                    survivalCode.guardBreakRate = ""; //Increase Guard Break Chance
                    survivalCode.throwEscapeChance = ""; //Increase Throw Escape Rate
                    survivalCode.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                    survivalCode.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                    survivalCode.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "";
                    survivalCode.stageMusic = "";
                    survivalCode.stageNumber = 14;
                    survivalCode.model = "B7";
                    survivalCode.costume = "01";
                    survivalCode.fightingStyle = "4D";
                    survivalCode.weaponNumber = "04"; //Eurydice (Voice) 76
                    survivalCode.voice = "76";

                    survivalCode.aiLevel = "05"; // 00-05
                    survivalCode.weaponSpecial = ""; //Fire, Thunder, Paralysis, Cure etc
                    survivalCode.guardianForce = ""; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                    survivalCode.stickyFeet = ""; //Slippery Feets
                    survivalCode.speed = "3F84"; //3F80 default speed

                    survivalCode.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                    survivalCode.attack = ""; //Decrease/Increase Attack
                    survivalCode.defense = ""; //Decrease/Increase Defense
                    survivalCode.stealHp = ""; //Steal health from enemy
                    survivalCode.pierceDamage = ""; //Damage inflicted thru guard
                    survivalCode.weaponSize = "";
                    survivalCode.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                    survivalCode.counterRate = ""; //Increase Counter Chance
                    survivalCode.nullCounter = ""; //Nullify Enemies Counters chance
                    survivalCode.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                    survivalCode.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                    survivalCode.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                    survivalCode.parryRegen = ""; //Recover Health when successfully Guard Impact
                    survivalCode.guardBreakRate = ""; //Increase Guard Break Chance
                    survivalCode.throwEscapeChance = ""; //Increase Throw Escape Rate
                    survivalCode.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                    survivalCode.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                    survivalCode.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "";
                    survivalCode.stageMusic = "";
                    survivalCode.stageNumber = 15;
                    survivalCode.model = "17";
                    survivalCode.costume = "09";
                    survivalCode.fightingStyle = "17";
                    survivalCode.weaponNumber = "05"; //Cassandra

                    survivalCode.aiLevel = "05"; // 00-05
                    survivalCode.weaponSpecial = "Paralysis"; //Fire, Thunder, Paralysis, Cure etc
                    survivalCode.guardianForce = ""; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                    survivalCode.stickyFeet = ""; //Slippery Feets
                    survivalCode.speed = "3F88"; //3F80 default speed
                    survivalCode.voice = null;

                    survivalCode.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                    survivalCode.attack = ""; //Decrease/Increase Attack
                    survivalCode.defense = ""; //Decrease/Increase Defense
                    survivalCode.stealHp = ""; //Steal health from enemy
                    survivalCode.pierceDamage = ""; //Damage inflicted thru guard
                    survivalCode.weaponSize = "";
                    survivalCode.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                    survivalCode.counterRate = ""; //Increase Counter Chance
                    survivalCode.nullCounter = ""; //Nullify Enemies Counters chance
                    survivalCode.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                    survivalCode.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                    survivalCode.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                    survivalCode.parryRegen = ""; //Recover Health when successfully Guard Impact
                    survivalCode.guardBreakRate = ""; //Increase Guard Break Chance
                    survivalCode.throwEscapeChance = ""; //Increase Throw Escape Rate
                    survivalCode.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                    survivalCode.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                    survivalCode.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "0022";
                    survivalCode.stageMusic = "18";
                    survivalCode.stageNumber = 16;
                    survivalCode.model = "AE";
                    survivalCode.costume = "02";
                    survivalCode.fightingStyle = "48";
                    survivalCode.weaponNumber = "01"; //Aeneas (Voice) 60
                    survivalCode.voice = "60";

                    survivalCode.aiLevel = "05"; // 00-05
                    survivalCode.weaponSpecial = "Cure"; //Fire, Thunder, Paralysis, Cure etc
                    survivalCode.guardianForce = ""; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                    survivalCode.stickyFeet = ""; //Slippery Feets
                    survivalCode.speed = "3F80"; //3F80 default speed

                    survivalCode.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                    survivalCode.attack = ""; //Decrease/Increase Attack
                    survivalCode.defense = ""; //Decrease/Increase Defense
                    survivalCode.stealHp = ""; //Steal health from enemy
                    survivalCode.pierceDamage = ""; //Damage inflicted thru guard
                    survivalCode.weaponSize = "40000000";
                    survivalCode.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                    survivalCode.counterRate = ""; //Increase Counter Chance
                    survivalCode.nullCounter = ""; //Nullify Enemies Counters chance
                    survivalCode.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                    survivalCode.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                    survivalCode.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                    survivalCode.parryRegen = ""; //Recover Health when successfully Guard Impact
                    survivalCode.guardBreakRate = ""; //Increase Guard Break Chance
                    survivalCode.throwEscapeChance = ""; //Increase Throw Escape Rate
                    survivalCode.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                    survivalCode.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                    survivalCode.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "";
                    survivalCode.stageMusic = "";
                    survivalCode.stageNumber = 17;
                    survivalCode.model = "A4";
                    survivalCode.costume = "00";
                    survivalCode.fightingStyle = "43";
                    survivalCode.weaponNumber = "03"; //Meiga (Voice) 60
                    survivalCode.voice = "60";

                    survivalCode.aiLevel = "05"; // 00-05
                    survivalCode.weaponSpecial = "All Guard Break"; //Fire, Thunder, Paralysis, Cure etc
                    survivalCode.guardianForce = ""; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                    survivalCode.stickyFeet = ""; //Slippery Feets
                    survivalCode.speed = "3F90"; //3F80 default speed

                    survivalCode.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                    survivalCode.attack = ""; //Decrease/Increase Attack
                    survivalCode.defense = ""; //Decrease/Increase Defense
                    survivalCode.stealHp = ""; //Steal health from enemy
                    survivalCode.pierceDamage = ""; //Damage inflicted thru guard
                    survivalCode.weaponSize = "";
                    survivalCode.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                    survivalCode.counterRate = ""; //Increase Counter Chance
                    survivalCode.nullCounter = ""; //Nullify Enemies Counters chance
                    survivalCode.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                    survivalCode.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                    survivalCode.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                    survivalCode.parryRegen = ""; //Recover Health when successfully Guard Impact
                    survivalCode.guardBreakRate = ""; //Increase Guard Break Chance
                    survivalCode.throwEscapeChance = ""; //Increase Throw Escape Rate
                    survivalCode.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                    survivalCode.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                    survivalCode.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "";
                    survivalCode.stageMusic = "";
                    survivalCode.stageNumber = 18;
                    survivalCode.model = "AE";
                    survivalCode.costume = "01";
                    survivalCode.fightingStyle = "48";
                    survivalCode.weaponNumber = "03"; //Rudiger (Voice) 67
                    survivalCode.voice = "67";

                    survivalCode.aiLevel = "05"; // 00-05
                    survivalCode.weaponSpecial = "All Unblockable"; //Fire, Thunder, Paralysis, Cure etc
                    survivalCode.guardianForce = ""; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                    survivalCode.stickyFeet = ""; //Slippery Feets
                    survivalCode.speed = "3F60"; //3F80 default speed

                    survivalCode.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                    survivalCode.attack = ""; //Decrease/Increase Attack
                    survivalCode.defense = ""; //Decrease/Increase Defense
                    survivalCode.stealHp = ""; //Steal health from enemy
                    survivalCode.pierceDamage = ""; //Damage inflicted thru guard
                    survivalCode.weaponSize = "";
                    survivalCode.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                    survivalCode.counterRate = ""; //Increase Counter Chance
                    survivalCode.nullCounter = ""; //Nullify Enemies Counters chance
                    survivalCode.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                    survivalCode.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                    survivalCode.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                    survivalCode.parryRegen = ""; //Recover Health when successfully Guard Impact
                    survivalCode.guardBreakRate = ""; //Increase Guard Break Chance
                    survivalCode.throwEscapeChance = ""; //Increase Throw Escape Rate
                    survivalCode.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                    survivalCode.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                    survivalCode.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "";
                    survivalCode.stageMusic = "";
                    survivalCode.stageNumber = 19;
                    survivalCode.model = "EF";
                    survivalCode.costume = "00";
                    survivalCode.fightingStyle = "43";
                    survivalCode.weaponNumber = "06"; //Ende
                    survivalCode.voice = null;

                    survivalCode.aiLevel = "05"; // 00-05
                    survivalCode.weaponSpecial = ""; //Fire, Thunder, Paralysis, Cure etc
                    survivalCode.guardianForce = ""; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                    survivalCode.stickyFeet = ""; //Slippery Feets
                    survivalCode.speed = "3F80"; //3F80 default speed

                    survivalCode.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                    survivalCode.attack = "3FC00000"; //Decrease/Increase Attack
                    survivalCode.defense = "3F400000"; //Decrease/Increase Defense
                    survivalCode.stealHp = ""; //Steal health from enemy
                    survivalCode.pierceDamage = ""; //Damage inflicted thru guard
                    survivalCode.weaponSize = "";
                    survivalCode.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                    survivalCode.counterRate = ""; //Increase Counter Chance
                    survivalCode.nullCounter = ""; //Nullify Enemies Counters chance
                    survivalCode.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                    survivalCode.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                    survivalCode.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                    survivalCode.parryRegen = ""; //Recover Health when successfully Guard Impact
                    survivalCode.guardBreakRate = ""; //Increase Guard Break Chance
                    survivalCode.throwEscapeChance = ""; //Increase Throw Escape Rate
                    survivalCode.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                    survivalCode.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                    survivalCode.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "";
                    survivalCode.stageMusic = "";
                    survivalCode.stageNumber = 20;
                    survivalCode.model = "60";
                    survivalCode.costume = "00";
                    survivalCode.fightingStyle = "03";
                    survivalCode.weaponNumber = "05"; //Nina (Created)

                    survivalCode.aiLevel = "05"; // 00-05
                    survivalCode.weaponSpecial = ""; //Fire, Thunder, Paralysis, Cure etc
                    survivalCode.guardianForce = ""; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                    survivalCode.stickyFeet = ""; //Slippery Feets
                    survivalCode.speed = "3FA0"; //3F80 default speed
                    survivalCode.voice = "73";

                    survivalCode.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                    survivalCode.attack = ""; //Decrease/Increase Attack
                    survivalCode.defense = ""; //Decrease/Increase Defense
                    survivalCode.stealHp = ""; //Steal health from enemy
                    survivalCode.pierceDamage = ""; //Damage inflicted thru guard
                    survivalCode.weaponSize = "";
                    survivalCode.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                    survivalCode.counterRate = ""; //Increase Counter Chance
                    survivalCode.nullCounter = ""; //Nullify Enemies Counters chance
                    survivalCode.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                    survivalCode.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                    survivalCode.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                    survivalCode.parryRegen = ""; //Recover Health when successfully Guard Impact
                    survivalCode.guardBreakRate = ""; //Increase Guard Break Chance
                    survivalCode.throwEscapeChance = ""; //Increase Throw Escape Rate
                    survivalCode.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                    survivalCode.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                    survivalCode.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                    break;
                #endregion

                #region Mysterious Arc  [Random]
                case "Mysterious Arc":

                    Random rnd = new Random();

                    string selectedDifficulty = "";
                    switch (SettingsClass.OpponentControl)
                    {
                        case 2:
                            selectedDifficulty = "00"; //Easy
                            break;
                        case 3:
                            selectedDifficulty = "01"; //Normal
                            break;
                        case 4:
                            selectedDifficulty = "02"; //Hard
                            break;
                        case 5:
                            selectedDifficulty = "03"; //Very Hard
                            break;
                        case 6:
                            selectedDifficulty = "04"; //Ultra Hard
                            break;
                        case 7:
                            selectedDifficulty = "05"; //Extremely Hard
                            break;
                        default:
                            selectedDifficulty = "01"; //Normal
                            break;
                    }

                    
                    int selectStage1 = rnd.Next(1, 32);
                    string selectedStage1 = SurvivalModeSubCodes.GetRandomStageData(selectStage1);
                    int selectStage2 = rnd.Next(1, 32);
                    string selectedStage2 = SurvivalModeSubCodes.GetRandomStageData(selectStage2);
                    int selectStage3 = rnd.Next(1, 32);
                    string selectedStage3 = SurvivalModeSubCodes.GetRandomStageData(selectStage3);
                    int selectStage4 = rnd.Next(1, 32);
                    string selectedStage4 = SurvivalModeSubCodes.GetRandomStageData(selectStage4);

                    int CharacterLocation = 0;
                    string CharacterCode = "";
                    string weaponCode = "";
                    int modifierPick = 0;

                    int level1Limit = 8;
                    int level2Limit = 11;
                    int level3Limit = 11;
                    int level4Limit = 10;
                    int level5Limit = 5;//bosses

                    List<string> addedEnemies = new List<string>();

                    //Enemy 1
                    CharacterLocation = rnd.Next(1, 21); //10 is max
                    CharacterCode = SurvivalModeSubCodes.GetRandomCharacterData(CharacterLocation, addedEnemies);
                    addedEnemies.Add(CharacterCode);
                    weaponCode = SurvivalModeSubCodes.GetRandomWeaponData(CharacterCode.Substring(4, 2), 1);
                    modifierPick = rnd.Next(1, level1Limit + 1);
                    survivalCode = SurvivalModeSubCodes.GetRandomModifiers(modifierPick, "1-3");

                    survivalCode.stageLevel = selectedStage1;
                    survivalCode.stageMusic = selectedStage1.Substring(2, 2);
                    survivalCode.stageNumber = 1;
                    survivalCode.model = CharacterCode.Substring(0, 2);
                    survivalCode.costume = CharacterCode.Substring(2, 2);
                    survivalCode.fightingStyle = CharacterCode.Substring(4, 2);
                    survivalCode.weaponNumber = weaponCode;
                    survivalCode.aiLevel = selectedDifficulty;

                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);

                    //Enemy 2
                    CharacterLocation = rnd.Next(1, 21);
                    CharacterCode = SurvivalModeSubCodes.GetRandomCharacterData(CharacterLocation, addedEnemies);
                    addedEnemies.Add(CharacterCode);
                    weaponCode = SurvivalModeSubCodes.GetRandomWeaponData(CharacterCode.Substring(4, 2), 1);
                    modifierPick = rnd.Next(1, level1Limit + 1);
                    survivalCode = SurvivalModeSubCodes.GetRandomModifiers(modifierPick, "1-3");

                    survivalCode.stageLevel = "";
                    survivalCode.stageMusic = "";
                    survivalCode.stageNumber = 2;
                    survivalCode.model = CharacterCode.Substring(0, 2);
                    survivalCode.costume = CharacterCode.Substring(2, 2);
                    survivalCode.fightingStyle = CharacterCode.Substring(4, 2);
                    survivalCode.weaponNumber = weaponCode;
                    survivalCode.aiLevel = selectedDifficulty;

                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);

                    //Enemy 3
                    CharacterLocation = rnd.Next(1, 21);
                    CharacterCode = SurvivalModeSubCodes.GetRandomCharacterData(CharacterLocation, addedEnemies);
                    addedEnemies.Add(CharacterCode);
                    weaponCode = SurvivalModeSubCodes.GetRandomWeaponData(CharacterCode.Substring(4, 2), 1);
                    modifierPick = rnd.Next(1, level1Limit + 1);
                    survivalCode = SurvivalModeSubCodes.GetRandomModifiers(modifierPick, "1-3");

                    survivalCode.stageLevel = "";
                    survivalCode.stageMusic = "";
                    survivalCode.stageNumber = 3;
                    survivalCode.model = CharacterCode.Substring(0, 2);
                    survivalCode.costume = CharacterCode.Substring(2, 2);
                    survivalCode.fightingStyle = CharacterCode.Substring(4, 2);
                    survivalCode.weaponNumber = weaponCode;
                    survivalCode.aiLevel = selectedDifficulty;

                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);

                    //Enemy 4
                    CharacterLocation = rnd.Next(1, 21);
                    CharacterCode = SurvivalModeSubCodes.GetRandomCharacterData(CharacterLocation, addedEnemies);
                    addedEnemies.Add(CharacterCode);
                    weaponCode = SurvivalModeSubCodes.GetRandomWeaponData(CharacterCode.Substring(4, 2), 2);
                    modifierPick = rnd.Next(1, level2Limit + 1);
                    survivalCode = SurvivalModeSubCodes.GetRandomModifiers(modifierPick, "4-9");

                    survivalCode.stageLevel = "";
                    survivalCode.stageMusic = "";
                    survivalCode.stageNumber = 4;
                    survivalCode.model = CharacterCode.Substring(0, 2);
                    survivalCode.costume = CharacterCode.Substring(2, 2);
                    survivalCode.fightingStyle = CharacterCode.Substring(4, 2);
                    survivalCode.weaponNumber = weaponCode;
                    survivalCode.aiLevel = selectedDifficulty;

                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);

                    //Enemy 5
                    CharacterLocation = rnd.Next(1, 21);
                    CharacterCode = SurvivalModeSubCodes.GetRandomCharacterData(CharacterLocation, addedEnemies);
                    addedEnemies.Add(CharacterCode);
                    weaponCode = SurvivalModeSubCodes.GetRandomWeaponData(CharacterCode.Substring(4, 2), 2);
                    modifierPick = rnd.Next(1, level2Limit + 1);
                    survivalCode = SurvivalModeSubCodes.GetRandomModifiers(modifierPick, "4-9");

                    survivalCode.stageLevel = "";
                    survivalCode.stageMusic = "";
                    survivalCode.stageNumber = 5;
                    survivalCode.model = CharacterCode.Substring(0, 2);
                    survivalCode.costume = CharacterCode.Substring(2, 2);
                    survivalCode.fightingStyle = CharacterCode.Substring(4, 2);
                    survivalCode.weaponNumber = weaponCode;
                    survivalCode.aiLevel = selectedDifficulty;

                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);

                    //Enemy 6
                    CharacterLocation = rnd.Next(1, 21); //10 is max
                    CharacterCode = SurvivalModeSubCodes.GetRandomCharacterData(CharacterLocation, addedEnemies);
                    addedEnemies.Add(CharacterCode);
                    weaponCode = SurvivalModeSubCodes.GetRandomWeaponData(CharacterCode.Substring(4, 2), 2);
                    modifierPick = rnd.Next(1, level2Limit + 1);
                    survivalCode = SurvivalModeSubCodes.GetRandomModifiers(modifierPick, "4-9");

                    survivalCode.stageLevel = selectedStage2;
                    survivalCode.stageMusic = selectedStage2.Substring(2, 2);
                    survivalCode.stageNumber = 6;
                    survivalCode.model = CharacterCode.Substring(0, 2);
                    survivalCode.costume = CharacterCode.Substring(2, 2);
                    survivalCode.fightingStyle = CharacterCode.Substring(4, 2);
                    survivalCode.weaponNumber = weaponCode;
                    survivalCode.aiLevel = selectedDifficulty;

                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);

                    //Enemy 7
                    CharacterLocation = rnd.Next(1, 21); //10 is max
                    CharacterCode = SurvivalModeSubCodes.GetRandomCharacterData(CharacterLocation, addedEnemies);
                    addedEnemies.Add(CharacterCode);
                    weaponCode = SurvivalModeSubCodes.GetRandomWeaponData(CharacterCode.Substring(4, 2), 2);
                    modifierPick = rnd.Next(1, level2Limit + 1);
                    survivalCode = SurvivalModeSubCodes.GetRandomModifiers(modifierPick, "4-9");

                    survivalCode.stageLevel = "";
                    survivalCode.stageMusic = "";
                    survivalCode.stageNumber = 7;
                    survivalCode.model = CharacterCode.Substring(0, 2);
                    survivalCode.costume = CharacterCode.Substring(2, 2);
                    survivalCode.fightingStyle = CharacterCode.Substring(4, 2);
                    survivalCode.weaponNumber = weaponCode;
                    survivalCode.aiLevel = selectedDifficulty;

                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);

                    //Enemy 8
                    CharacterLocation = rnd.Next(1, 21); //10 is max
                    CharacterCode = SurvivalModeSubCodes.GetRandomCharacterData(CharacterLocation, addedEnemies);
                    addedEnemies.Add(CharacterCode);
                    weaponCode = SurvivalModeSubCodes.GetRandomWeaponData(CharacterCode.Substring(4, 2), 2);
                    modifierPick = rnd.Next(1, level2Limit + 1);
                    survivalCode = SurvivalModeSubCodes.GetRandomModifiers(modifierPick, "4-9");

                    survivalCode.stageLevel = "";
                    survivalCode.stageMusic = "";
                    survivalCode.stageNumber = 8;
                    survivalCode.model = CharacterCode.Substring(0, 2);
                    survivalCode.costume = CharacterCode.Substring(2, 2);
                    survivalCode.fightingStyle = CharacterCode.Substring(4, 2);
                    survivalCode.weaponNumber = weaponCode;
                    survivalCode.aiLevel = selectedDifficulty;

                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);

                    //Enemy 9
                    CharacterLocation = rnd.Next(1, 21); //10 is max
                    CharacterCode = SurvivalModeSubCodes.GetRandomCharacterData(CharacterLocation, addedEnemies);
                    addedEnemies.Add(CharacterCode);
                    weaponCode = SurvivalModeSubCodes.GetRandomWeaponData(CharacterCode.Substring(4, 2), 2);
                    modifierPick = rnd.Next(1, level2Limit + 1);
                    survivalCode = SurvivalModeSubCodes.GetRandomModifiers(modifierPick, "4-9");

                    survivalCode.stageLevel = "";
                    survivalCode.stageMusic = "";
                    survivalCode.stageNumber = 9;
                    survivalCode.model = CharacterCode.Substring(0, 2);
                    survivalCode.costume = CharacterCode.Substring(2, 2);
                    survivalCode.fightingStyle = CharacterCode.Substring(4, 2);
                    survivalCode.weaponNumber = weaponCode;
                    survivalCode.aiLevel = selectedDifficulty;

                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);

                    //Enemy 10
                    CharacterLocation = rnd.Next(1, 21); //10 is max
                    CharacterCode = SurvivalModeSubCodes.GetRandomCharacterData(CharacterLocation, addedEnemies);
                    addedEnemies.Add(CharacterCode);
                    weaponCode = SurvivalModeSubCodes.GetRandomWeaponData(CharacterCode.Substring(4, 2), 3);
                    modifierPick = rnd.Next(1, level3Limit + 1);
                    survivalCode = SurvivalModeSubCodes.GetRandomModifiers(modifierPick, "10-15");

                    survivalCode.stageLevel = "";
                    survivalCode.stageMusic = "";
                    survivalCode.stageNumber = 10;
                    survivalCode.model = CharacterCode.Substring(0, 2);
                    survivalCode.costume = CharacterCode.Substring(2, 2);
                    survivalCode.fightingStyle = CharacterCode.Substring(4, 2);
                    survivalCode.weaponNumber = weaponCode;
                    survivalCode.aiLevel = selectedDifficulty;

                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);

                    //Enemy 11
                    CharacterLocation = rnd.Next(1, 21); //10 is max
                    CharacterCode = SurvivalModeSubCodes.GetRandomCharacterData(CharacterLocation, addedEnemies);
                    addedEnemies.Add(CharacterCode);
                    weaponCode = SurvivalModeSubCodes.GetRandomWeaponData(CharacterCode.Substring(4, 2), 3);
                    modifierPick = rnd.Next(1, level3Limit + 1);
                    survivalCode = SurvivalModeSubCodes.GetRandomModifiers(modifierPick, "10-15");

                    survivalCode.stageLevel = selectedStage3;
                    survivalCode.stageMusic = selectedStage3.Substring(2, 2);
                    survivalCode.stageNumber = 11;
                    survivalCode.model = CharacterCode.Substring(0, 2);
                    survivalCode.costume = CharacterCode.Substring(2, 2);
                    survivalCode.fightingStyle = CharacterCode.Substring(4, 2);
                    survivalCode.weaponNumber = weaponCode;
                    survivalCode.aiLevel = selectedDifficulty;

                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);

                    //Enemy 12
                    CharacterLocation = rnd.Next(1, 21); //10 is max
                    CharacterCode = SurvivalModeSubCodes.GetRandomCharacterData(CharacterLocation, addedEnemies);
                    addedEnemies.Add(CharacterCode);
                    weaponCode = SurvivalModeSubCodes.GetRandomWeaponData(CharacterCode.Substring(4, 2), 3);
                    modifierPick = rnd.Next(1, level3Limit + 1);
                    survivalCode = SurvivalModeSubCodes.GetRandomModifiers(modifierPick, "10-15");

                    survivalCode.stageLevel = "";
                    survivalCode.stageMusic = "";
                    survivalCode.stageNumber = 12;
                    survivalCode.model = CharacterCode.Substring(0, 2);
                    survivalCode.costume = CharacterCode.Substring(2, 2);
                    survivalCode.fightingStyle = CharacterCode.Substring(4, 2);
                    survivalCode.weaponNumber = weaponCode;
                    survivalCode.aiLevel = selectedDifficulty;

                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);

                    //Enemy 13
                    CharacterLocation = rnd.Next(1, 21); //10 is max
                    CharacterCode = SurvivalModeSubCodes.GetRandomCharacterData(CharacterLocation, addedEnemies);
                    addedEnemies.Add(CharacterCode);
                    weaponCode = SurvivalModeSubCodes.GetRandomWeaponData(CharacterCode.Substring(4, 2), 3);
                    modifierPick = rnd.Next(1, level3Limit + 1);
                    survivalCode = SurvivalModeSubCodes.GetRandomModifiers(modifierPick, "10-15");

                    survivalCode.stageLevel = "";
                    survivalCode.stageMusic = "";
                    survivalCode.stageNumber = 13;
                    survivalCode.model = CharacterCode.Substring(0, 2);
                    survivalCode.costume = CharacterCode.Substring(2, 2);
                    survivalCode.fightingStyle = CharacterCode.Substring(4, 2);
                    survivalCode.weaponNumber = weaponCode;
                    survivalCode.aiLevel = selectedDifficulty;

                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);

                    //Enemy 14
                    CharacterLocation = rnd.Next(1, 21); //10 is max
                    CharacterCode = SurvivalModeSubCodes.GetRandomCharacterData(CharacterLocation, addedEnemies);
                    addedEnemies.Add(CharacterCode);
                    weaponCode = SurvivalModeSubCodes.GetRandomWeaponData(CharacterCode.Substring(4, 2), 3);
                    modifierPick = rnd.Next(1, level3Limit + 1);
                    survivalCode = SurvivalModeSubCodes.GetRandomModifiers(modifierPick, "10-15");

                    survivalCode.stageLevel = "";
                    survivalCode.stageMusic = "";
                    survivalCode.stageNumber = 14;
                    survivalCode.model = CharacterCode.Substring(0, 2);
                    survivalCode.costume = CharacterCode.Substring(2, 2);
                    survivalCode.fightingStyle = CharacterCode.Substring(4, 2);
                    survivalCode.weaponNumber = weaponCode;
                    survivalCode.aiLevel = selectedDifficulty;

                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);

                    //Enemy 15
                    CharacterLocation = rnd.Next(1, 21); //10 is max
                    CharacterCode = SurvivalModeSubCodes.GetRandomCharacterData(CharacterLocation, addedEnemies);
                    addedEnemies.Add(CharacterCode);
                    weaponCode = SurvivalModeSubCodes.GetRandomWeaponData(CharacterCode.Substring(4, 2), 3);
                    modifierPick = rnd.Next(1, level3Limit + 1);
                    survivalCode = SurvivalModeSubCodes.GetRandomModifiers(modifierPick, "10-15");

                    survivalCode.stageLevel = "";
                    survivalCode.stageMusic = "";
                    survivalCode.stageNumber = 15;
                    survivalCode.model = CharacterCode.Substring(0, 2);
                    survivalCode.costume = CharacterCode.Substring(2, 2);
                    survivalCode.fightingStyle = CharacterCode.Substring(4, 2);
                    survivalCode.weaponNumber = weaponCode;
                    survivalCode.aiLevel = selectedDifficulty;

                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);

                    //Enemy 16
                    CharacterLocation = rnd.Next(1, 21); //10 is max
                    CharacterCode = SurvivalModeSubCodes.GetRandomCharacterData(CharacterLocation, addedEnemies);
                    addedEnemies.Add(CharacterCode);
                    weaponCode = SurvivalModeSubCodes.GetRandomWeaponData(CharacterCode.Substring(4, 2), 4);
                    modifierPick = rnd.Next(1, level4Limit + 1);
                    survivalCode = SurvivalModeSubCodes.GetRandomModifiers(modifierPick, "16-19");

                    survivalCode.stageLevel = selectedStage4;
                    survivalCode.stageMusic = selectedStage4.Substring(2, 2);
                    survivalCode.stageNumber = 16;
                    survivalCode.model = CharacterCode.Substring(0, 2);
                    survivalCode.costume = CharacterCode.Substring(2, 2);
                    survivalCode.fightingStyle = CharacterCode.Substring(4, 2);
                    survivalCode.weaponNumber = weaponCode;
                    survivalCode.aiLevel = selectedDifficulty;

                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);

                    //Enemy 17
                    CharacterLocation = rnd.Next(1, 21); //10 is max
                    CharacterCode = SurvivalModeSubCodes.GetRandomCharacterData(CharacterLocation, addedEnemies);
                    addedEnemies.Add(CharacterCode);
                    weaponCode = SurvivalModeSubCodes.GetRandomWeaponData(CharacterCode.Substring(4, 2), 4);
                    modifierPick = rnd.Next(1, level4Limit + 1);
                    survivalCode = SurvivalModeSubCodes.GetRandomModifiers(modifierPick, "16-19");

                    survivalCode.stageLevel = "";
                    survivalCode.stageMusic = "";
                    survivalCode.stageNumber = 17;
                    survivalCode.model = CharacterCode.Substring(0, 2);
                    survivalCode.costume = CharacterCode.Substring(2, 2);
                    survivalCode.fightingStyle = CharacterCode.Substring(4, 2);
                    survivalCode.weaponNumber = weaponCode;
                    survivalCode.aiLevel = selectedDifficulty;

                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);

                    //Enemy 18
                    CharacterLocation = rnd.Next(1, 21); //10 is max
                    CharacterCode = SurvivalModeSubCodes.GetRandomCharacterData(CharacterLocation, addedEnemies);
                    addedEnemies.Add(CharacterCode);
                    weaponCode = SurvivalModeSubCodes.GetRandomWeaponData(CharacterCode.Substring(4, 2), 4);
                    modifierPick = rnd.Next(1, level4Limit + 1);
                    survivalCode = SurvivalModeSubCodes.GetRandomModifiers(modifierPick, "16-19");

                    survivalCode.stageLevel = "";
                    survivalCode.stageMusic = "";
                    survivalCode.stageNumber = 18;
                    survivalCode.model = CharacterCode.Substring(0, 2);
                    survivalCode.costume = CharacterCode.Substring(2, 2);
                    survivalCode.fightingStyle = CharacterCode.Substring(4, 2);
                    survivalCode.weaponNumber = weaponCode;
                    survivalCode.aiLevel = selectedDifficulty;

                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);

                    //Enemy 19
                    CharacterLocation = rnd.Next(1, 21); //10 is max
                    CharacterCode = SurvivalModeSubCodes.GetRandomCharacterData(CharacterLocation, addedEnemies);
                    addedEnemies.Add(CharacterCode);
                    weaponCode = SurvivalModeSubCodes.GetRandomWeaponData(CharacterCode.Substring(4, 2), 4);
                    modifierPick = rnd.Next(1, level4Limit + 1);
                    survivalCode = SurvivalModeSubCodes.GetRandomModifiers(modifierPick, "16-19");

                    survivalCode.stageLevel = "";
                    survivalCode.stageMusic = "";
                    survivalCode.stageNumber = 19;
                    survivalCode.model = CharacterCode.Substring(0, 2);
                    survivalCode.costume = CharacterCode.Substring(2, 2);
                    survivalCode.fightingStyle = CharacterCode.Substring(4, 2);
                    survivalCode.weaponNumber = weaponCode;
                    survivalCode.aiLevel = selectedDifficulty;

                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);

                    //Enemy 20 (Boss)
                    modifierPick = rnd.Next(1, level5Limit + 1); //boss pick
                    survivalCode = SurvivalModeSubCodes.GetRandomModifiers(modifierPick, "20");

                    survivalCode.stageNumber = 20;
                    survivalCode.aiLevel = selectedDifficulty;

                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                    break;
                #endregion

                #region Bonus Arc  [Shadow Master]
                case "Bonus Arc":
                    survivalCode.stageLevel = "000B";
                    survivalCode.stageMusic = "0B";
                    survivalCode.stageNumber = 1;
                    survivalCode.model = "47";
                    survivalCode.costume = "00";
                    survivalCode.fightingStyle = "47";
                    survivalCode.weaponNumber = "05"; //Hualin

                    survivalCode.aiLevel = "03"; // 00-05
                    survivalCode.weaponSpecial = "Glue"; //Fire, Thunder, Paralysis, Cure etc
                    survivalCode.guardianForce = ""; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                    survivalCode.stickyFeet = ""; //Slippery Feets
                    survivalCode.speed = "3F80"; //3F80 default speed
                    survivalCode.voice = null;

                    survivalCode.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                    survivalCode.attack = ""; //Decrease/Increase Attack
                    survivalCode.defense = ""; //Decrease/Increase Defense
                    survivalCode.stealHp = ""; //Steal health from enemy
                    survivalCode.pierceDamage = ""; //Damage inflicted thru guard
                    survivalCode.weaponSize = "";
                    survivalCode.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                    survivalCode.counterRate = ""; //Increase Counter Chance
                    survivalCode.nullCounter = ""; //Nullify Enemies Counters chance
                    survivalCode.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                    survivalCode.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                    survivalCode.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                    survivalCode.parryRegen = ""; //Recover Health when successfully Guard Impact
                    survivalCode.guardBreakRate = ""; //Increase Guard Break Chance
                    survivalCode.throwEscapeChance = ""; //Increase Throw Escape Rate
                    survivalCode.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                    survivalCode.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                    survivalCode.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "";
                    survivalCode.stageNumber = 2;
                    survivalCode.model = "46";
                    survivalCode.costume = "00";
                    survivalCode.fightingStyle = "46";
                    survivalCode.weaponNumber = "05"; //Valeria

                    survivalCode.aiLevel = "03"; // 00-05
                    survivalCode.weaponSpecial = "Defense Down"; //Fire, Thunder, Paralysis, Cure etc
                    survivalCode.guardianForce = ""; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                    survivalCode.stickyFeet = ""; //Slippery Feets
                    survivalCode.speed = "3F80"; //3F80 default speed
                    survivalCode.voice = null;

                    survivalCode.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                    survivalCode.attack = ""; //Decrease/Increase Attack
                    survivalCode.defense = ""; //Decrease/Increase Defense
                    survivalCode.stealHp = ""; //Steal health from enemy
                    survivalCode.pierceDamage = ""; //Damage inflicted thru guard
                    survivalCode.weaponSize = "";
                    survivalCode.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                    survivalCode.counterRate = ""; //Increase Counter Chance
                    survivalCode.nullCounter = ""; //Nullify Enemies Counters chance
                    survivalCode.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                    survivalCode.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                    survivalCode.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                    survivalCode.parryRegen = ""; //Recover Health when successfully Guard Impact
                    survivalCode.guardBreakRate = ""; //Increase Guard Break Chance
                    survivalCode.throwEscapeChance = ""; //Increase Throw Escape Rate
                    survivalCode.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                    survivalCode.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                    survivalCode.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "";
                    survivalCode.stageNumber = 3;
                    survivalCode.model = "4F";
                    survivalCode.costume = "00";
                    survivalCode.fightingStyle = "4F";
                    survivalCode.weaponNumber = "05"; //Lynette

                    survivalCode.aiLevel = "03"; // 00-05
                    survivalCode.weaponSpecial = "Cure"; //Fire, Thunder, Paralysis, Cure etc
                    survivalCode.guardianForce = ""; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                    survivalCode.stickyFeet = ""; //Slippery Feets
                    survivalCode.speed = "3F80"; //3F80 default speed
                    survivalCode.voice = null;

                    survivalCode.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                    survivalCode.attack = ""; //Decrease/Increase Attack
                    survivalCode.defense = ""; //Decrease/Increase Defense
                    survivalCode.stealHp = ""; //Steal health from enemy
                    survivalCode.pierceDamage = ""; //Damage inflicted thru guard
                    survivalCode.weaponSize = "";
                    survivalCode.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                    survivalCode.counterRate = ""; //Increase Counter Chance
                    survivalCode.nullCounter = ""; //Nullify Enemies Counters chance
                    survivalCode.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                    survivalCode.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                    survivalCode.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                    survivalCode.parryRegen = ""; //Recover Health when successfully Guard Impact
                    survivalCode.guardBreakRate = ""; //Increase Guard Break Chance
                    survivalCode.throwEscapeChance = ""; //Increase Throw Escape Rate
                    survivalCode.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                    survivalCode.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                    survivalCode.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "";
                    survivalCode.stageNumber = 4;
                    survivalCode.model = "41";
                    survivalCode.costume = "00";
                    survivalCode.fightingStyle = "41";
                    survivalCode.weaponNumber = "05"; //Miser

                    survivalCode.aiLevel = "03"; // 00-05
                    survivalCode.weaponSpecial = "Whirlwind"; //Fire, Thunder, Paralysis, Cure etc
                    survivalCode.guardianForce = ""; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                    survivalCode.stickyFeet = ""; //Slippery Feets
                    survivalCode.speed = "3F80"; //3F80 default speed
                    survivalCode.voice = null;

                    survivalCode.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                    survivalCode.attack = ""; //Decrease/Increase Attack
                    survivalCode.defense = ""; //Decrease/Increase Defense
                    survivalCode.stealHp = ""; //Steal health from enemy
                    survivalCode.pierceDamage = ""; //Damage inflicted thru guard
                    survivalCode.weaponSize = "";
                    survivalCode.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                    survivalCode.counterRate = ""; //Increase Counter Chance
                    survivalCode.nullCounter = ""; //Nullify Enemies Counters chance
                    survivalCode.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                    survivalCode.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                    survivalCode.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                    survivalCode.parryRegen = ""; //Recover Health when successfully Guard Impact
                    survivalCode.guardBreakRate = ""; //Increase Guard Break Chance
                    survivalCode.throwEscapeChance = ""; //Increase Throw Escape Rate
                    survivalCode.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                    survivalCode.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                    survivalCode.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "";
                    survivalCode.stageNumber = 5;
                    survivalCode.model = "42";
                    survivalCode.costume = "00";
                    survivalCode.fightingStyle = "42";
                    survivalCode.weaponNumber = "05"; //Greed

                    survivalCode.aiLevel = "03"; // 00-05
                    survivalCode.weaponSpecial = "Poison"; //Fire, Thunder, Paralysis, Cure etc
                    survivalCode.guardianForce = ""; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                    survivalCode.stickyFeet = ""; //Slippery Feets
                    survivalCode.speed = "3F80"; //3F80 default speed
                    survivalCode.voice = null;

                    survivalCode.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                    survivalCode.attack = ""; //Decrease/Increase Attack
                    survivalCode.defense = ""; //Decrease/Increase Defense
                    survivalCode.stealHp = ""; //Steal health from enemy
                    survivalCode.pierceDamage = ""; //Damage inflicted thru guard
                    survivalCode.weaponSize = "";
                    survivalCode.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                    survivalCode.counterRate = ""; //Increase Counter Chance
                    survivalCode.nullCounter = ""; //Nullify Enemies Counters chance
                    survivalCode.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                    survivalCode.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                    survivalCode.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                    survivalCode.parryRegen = ""; //Recover Health when successfully Guard Impact
                    survivalCode.guardBreakRate = ""; //Increase Guard Break Chance
                    survivalCode.throwEscapeChance = ""; //Increase Throw Escape Rate
                    survivalCode.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                    survivalCode.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                    survivalCode.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "0006";
                    survivalCode.stageMusic = "06";
                    survivalCode.stageNumber = 6;
                    survivalCode.model = "4A";
                    survivalCode.costume = "00";
                    survivalCode.fightingStyle = "4A";
                    survivalCode.weaponNumber = "05"; //Demuth

                    survivalCode.aiLevel = "03"; // 00-05
                    survivalCode.weaponSpecial = "Smash"; //Fire, Thunder, Paralysis, Cure etc
                    survivalCode.guardianForce = ""; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                    survivalCode.stickyFeet = ""; //Slippery Feets
                    survivalCode.speed = "3F80"; //3F80 default speed
                    survivalCode.voice = null;

                    survivalCode.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                    survivalCode.attack = "3F900000"; //Decrease/Increase Attack
                    survivalCode.defense = ""; //Decrease/Increase Defense
                    survivalCode.stealHp = ""; //Steal health from enemy
                    survivalCode.pierceDamage = ""; //Damage inflicted thru guard
                    survivalCode.weaponSize = "";
                    survivalCode.atkPushForce = "3F900000"; //Decrease/Increase Attack Pushback Force
                    survivalCode.counterRate = ""; //Increase Counter Chance
                    survivalCode.nullCounter = ""; //Nullify Enemies Counters chance
                    survivalCode.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                    survivalCode.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                    survivalCode.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                    survivalCode.parryRegen = ""; //Recover Health when successfully Guard Impact
                    survivalCode.guardBreakRate = ""; //Increase Guard Break Chance
                    survivalCode.throwEscapeChance = ""; //Increase Throw Escape Rate
                    survivalCode.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                    survivalCode.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                    survivalCode.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "";
                    survivalCode.stageNumber = 7;
                    survivalCode.model = "4B";
                    survivalCode.costume = "00";
                    survivalCode.fightingStyle = "4B";
                    survivalCode.weaponNumber = "05"; //Aurelia

                    survivalCode.aiLevel = "03"; // 00-05
                    survivalCode.weaponSpecial = "Paralysis"; //Fire, Thunder, Paralysis, Cure etc
                    survivalCode.guardianForce = ""; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                    survivalCode.stickyFeet = ""; //Slippery Feets
                    survivalCode.speed = "3F80"; //3F80 default speed
                    survivalCode.voice = null;

                    survivalCode.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                    survivalCode.attack = ""; //Decrease/Increase Attack
                    survivalCode.defense = ""; //Decrease/Increase Defense
                    survivalCode.stealHp = ""; //Steal health from enemy
                    survivalCode.pierceDamage = ""; //Damage inflicted thru guard
                    survivalCode.weaponSize = "";
                    survivalCode.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                    survivalCode.counterRate = ""; //Increase Counter Chance
                    survivalCode.nullCounter = ""; //Nullify Enemies Counters chance
                    survivalCode.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                    survivalCode.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                    survivalCode.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                    survivalCode.parryRegen = ""; //Recover Health when successfully Guard Impact
                    survivalCode.guardBreakRate = ""; //Increase Guard Break Chance
                    survivalCode.throwEscapeChance = ""; //Increase Throw Escape Rate
                    survivalCode.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                    survivalCode.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                    survivalCode.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "";
                    survivalCode.stageNumber = 8;
                    survivalCode.model = "45";
                    survivalCode.costume = "00";
                    survivalCode.fightingStyle = "45";
                    survivalCode.weaponNumber = "05"; //Luna

                    survivalCode.aiLevel = "03"; // 00-05
                    survivalCode.weaponSpecial = "Cure"; //Fire, Thunder, Paralysis, Cure etc
                    survivalCode.guardianForce = ""; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                    survivalCode.stickyFeet = ""; //Slippery Feets
                    survivalCode.speed = "3F80"; //3F80 default speed
                    survivalCode.voice = null;

                    survivalCode.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                    survivalCode.attack = ""; //Decrease/Increase Attack
                    survivalCode.defense = ""; //Decrease/Increase Defense
                    survivalCode.stealHp = ""; //Steal health from enemy
                    survivalCode.pierceDamage = ""; //Damage inflicted thru guard
                    survivalCode.weaponSize = "";
                    survivalCode.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                    survivalCode.counterRate = ""; //Increase Counter Chance
                    survivalCode.nullCounter = ""; //Nullify Enemies Counters chance
                    survivalCode.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                    survivalCode.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                    survivalCode.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                    survivalCode.parryRegen = ""; //Recover Health when successfully Guard Impact
                    survivalCode.guardBreakRate = ""; //Increase Guard Break Chance
                    survivalCode.throwEscapeChance = ""; //Increase Throw Escape Rate
                    survivalCode.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                    survivalCode.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                    survivalCode.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "";
                    survivalCode.stageNumber = 9;
                    survivalCode.model = "4E";
                    survivalCode.costume = "00";
                    survivalCode.fightingStyle = "4E";
                    survivalCode.weaponNumber = "05"; //Abelia

                    survivalCode.aiLevel = "03"; // 00-05
                    survivalCode.weaponSpecial = "Defense Down"; //Fire, Thunder, Paralysis, Cure etc
                    survivalCode.guardianForce = ""; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                    survivalCode.stickyFeet = ""; //Slippery Feets
                    survivalCode.speed = "3F80"; //3F80 default speed
                    survivalCode.voice = null;

                    survivalCode.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                    survivalCode.attack = ""; //Decrease/Increase Attack
                    survivalCode.defense = ""; //Decrease/Increase Defense
                    survivalCode.stealHp = ""; //Steal health from enemy
                    survivalCode.pierceDamage = ""; //Damage inflicted thru guard
                    survivalCode.weaponSize = "";
                    survivalCode.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                    survivalCode.counterRate = ""; //Increase Counter Chance
                    survivalCode.nullCounter = ""; //Nullify Enemies Counters chance
                    survivalCode.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                    survivalCode.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                    survivalCode.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                    survivalCode.parryRegen = ""; //Recover Health when successfully Guard Impact
                    survivalCode.guardBreakRate = ""; //Increase Guard Break Chance
                    survivalCode.throwEscapeChance = ""; //Increase Throw Escape Rate
                    survivalCode.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                    survivalCode.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                    survivalCode.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "";
                    survivalCode.stageNumber = 10;
                    survivalCode.model = "48";
                    survivalCode.costume = "00";
                    survivalCode.fightingStyle = "48";
                    survivalCode.weaponNumber = "05"; //Girardot

                    survivalCode.aiLevel = "03"; // 00-05
                    survivalCode.weaponSpecial = "Separate"; //Fire, Thunder, Paralysis, Cure etc
                    survivalCode.guardianForce = ""; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                    survivalCode.stickyFeet = ""; //Slippery Feets
                    survivalCode.speed = "3F80"; //3F80 default speed
                    survivalCode.voice = null;

                    survivalCode.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                    survivalCode.attack = ""; //Decrease/Increase Attack
                    survivalCode.defense = ""; //Decrease/Increase Defense
                    survivalCode.stealHp = ""; //Steal health from enemy
                    survivalCode.pierceDamage = ""; //Damage inflicted thru guard
                    survivalCode.weaponSize = "";
                    survivalCode.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                    survivalCode.counterRate = ""; //Increase Counter Chance
                    survivalCode.nullCounter = ""; //Nullify Enemies Counters chance
                    survivalCode.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                    survivalCode.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                    survivalCode.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                    survivalCode.parryRegen = ""; //Recover Health when successfully Guard Impact
                    survivalCode.guardBreakRate = ""; //Increase Guard Break Chance
                    survivalCode.throwEscapeChance = ""; //Increase Throw Escape Rate
                    survivalCode.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                    survivalCode.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                    survivalCode.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "0004";
                    survivalCode.stageMusic = "04";
                    survivalCode.stageNumber = 11;
                    survivalCode.model = "44";
                    survivalCode.costume = "00";
                    survivalCode.fightingStyle = "44";
                    survivalCode.weaponNumber = "05"; //Hwang

                    survivalCode.aiLevel = "03"; // 00-05
                    survivalCode.weaponSpecial = "Aerial Wind"; //Fire, Thunder, Paralysis, Cure etc
                    survivalCode.guardianForce = ""; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                    survivalCode.stickyFeet = ""; //Slippery Feets
                    survivalCode.speed = "3F80"; //3F80 default speed
                    survivalCode.voice = null;

                    survivalCode.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                    survivalCode.attack = ""; //Decrease/Increase Attack
                    survivalCode.defense = ""; //Decrease/Increase Defense
                    survivalCode.stealHp = ""; //Steal health from enemy
                    survivalCode.pierceDamage = ""; //Damage inflicted thru guard
                    survivalCode.weaponSize = "";
                    survivalCode.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                    survivalCode.counterRate = ""; //Increase Counter Chance
                    survivalCode.nullCounter = ""; //Nullify Enemies Counters chance
                    survivalCode.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                    survivalCode.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                    survivalCode.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                    survivalCode.parryRegen = ""; //Recover Health when successfully Guard Impact
                    survivalCode.guardBreakRate = ""; //Increase Guard Break Chance
                    survivalCode.throwEscapeChance = ""; //Increase Throw Escape Rate
                    survivalCode.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                    survivalCode.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                    survivalCode.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "";
                    survivalCode.stageNumber = 12;
                    survivalCode.model = "93";
                    survivalCode.costume = "00";
                    survivalCode.fightingStyle = "42";
                    survivalCode.weaponNumber = "00"; //Assassin

                    survivalCode.aiLevel = "03"; // 00-05
                    survivalCode.weaponSpecial = "Super Poison"; //Fire, Thunder, Paralysis, Cure etc
                    survivalCode.guardianForce = ""; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                    survivalCode.stickyFeet = ""; //Slippery Feets
                    survivalCode.speed = "3F80"; //3F80 default speed
                    survivalCode.voice = null;

                    survivalCode.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                    survivalCode.attack = ""; //Decrease/Increase Attack
                    survivalCode.defense = ""; //Decrease/Increase Defense
                    survivalCode.stealHp = ""; //Steal health from enemy
                    survivalCode.pierceDamage = ""; //Damage inflicted thru guard
                    survivalCode.weaponSize = "";
                    survivalCode.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                    survivalCode.counterRate = ""; //Increase Counter Chance
                    survivalCode.nullCounter = ""; //Nullify Enemies Counters chance
                    survivalCode.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                    survivalCode.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                    survivalCode.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                    survivalCode.parryRegen = ""; //Recover Health when successfully Guard Impact
                    survivalCode.guardBreakRate = ""; //Increase Guard Break Chance
                    survivalCode.throwEscapeChance = ""; //Increase Throw Escape Rate
                    survivalCode.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                    survivalCode.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                    survivalCode.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "";
                    survivalCode.stageNumber = 13;
                    survivalCode.model = "51";
                    survivalCode.costume = "00";
                    survivalCode.fightingStyle = "51";
                    survivalCode.weaponNumber = "05"; //Li Long

                    survivalCode.aiLevel = "03"; // 00-05
                    survivalCode.weaponSpecial = "Ice"; //Fire, Thunder, Paralysis, Cure etc
                    survivalCode.guardianForce = ""; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                    survivalCode.stickyFeet = ""; //Slippery Feets
                    survivalCode.speed = "3F80"; //3F80 default speed
                    survivalCode.voice = null;

                    survivalCode.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                    survivalCode.attack = ""; //Decrease/Increase Attack
                    survivalCode.defense = ""; //Decrease/Increase Defense
                    survivalCode.stealHp = ""; //Steal health from enemy
                    survivalCode.pierceDamage = ""; //Damage inflicted thru guard
                    survivalCode.weaponSize = "";
                    survivalCode.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                    survivalCode.counterRate = ""; //Increase Counter Chance
                    survivalCode.nullCounter = ""; //Nullify Enemies Counters chance
                    survivalCode.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                    survivalCode.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                    survivalCode.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                    survivalCode.parryRegen = ""; //Recover Health when successfully Guard Impact
                    survivalCode.guardBreakRate = ""; //Increase Guard Break Chance
                    survivalCode.throwEscapeChance = ""; //Increase Throw Escape Rate
                    survivalCode.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                    survivalCode.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                    survivalCode.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "";
                    survivalCode.stageNumber = 14;
                    survivalCode.model = "81";
                    survivalCode.costume = "00";
                    survivalCode.fightingStyle = "48";
                    survivalCode.weaponNumber = "00"; //Berserker

                    survivalCode.aiLevel = "03"; // 00-05
                    survivalCode.weaponSpecial = "Whirlwind"; //Fire, Thunder, Paralysis, Cure etc
                    survivalCode.guardianForce = ""; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                    survivalCode.stickyFeet = ""; //Slippery Feets
                    survivalCode.speed = "3F80"; //3F80 default speed
                    survivalCode.voice = null;

                    survivalCode.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                    survivalCode.attack = ""; //Decrease/Increase Attack
                    survivalCode.defense = ""; //Decrease/Increase Defense
                    survivalCode.stealHp = ""; //Steal health from enemy
                    survivalCode.pierceDamage = ""; //Damage inflicted thru guard
                    survivalCode.weaponSize = "";
                    survivalCode.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                    survivalCode.counterRate = ""; //Increase Counter Chance
                    survivalCode.nullCounter = ""; //Nullify Enemies Counters chance
                    survivalCode.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                    survivalCode.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                    survivalCode.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                    survivalCode.parryRegen = ""; //Recover Health when successfully Guard Impact
                    survivalCode.guardBreakRate = ""; //Increase Guard Break Chance
                    survivalCode.throwEscapeChance = ""; //Increase Throw Escape Rate
                    survivalCode.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                    survivalCode.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                    survivalCode.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "";
                    survivalCode.stageNumber = 15;
                    survivalCode.model = "43";
                    survivalCode.costume = "00";
                    survivalCode.fightingStyle = "43";
                    survivalCode.weaponNumber = "05"; //Arthur

                    survivalCode.aiLevel = "03"; // 00-05
                    survivalCode.weaponSpecial = "Glue"; //Fire, Thunder, Paralysis, Cure etc
                    survivalCode.guardianForce = ""; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                    survivalCode.stickyFeet = ""; //Slippery Feets
                    survivalCode.speed = "3F80"; //3F80 default speed
                    survivalCode.voice = null;

                    survivalCode.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                    survivalCode.attack = ""; //Decrease/Increase Attack
                    survivalCode.defense = ""; //Decrease/Increase Defense
                    survivalCode.stealHp = ""; //Steal health from enemy
                    survivalCode.pierceDamage = ""; //Damage inflicted thru guard
                    survivalCode.weaponSize = "";
                    survivalCode.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                    survivalCode.counterRate = ""; //Increase Counter Chance
                    survivalCode.nullCounter = ""; //Nullify Enemies Counters chance
                    survivalCode.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                    survivalCode.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                    survivalCode.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                    survivalCode.parryRegen = ""; //Recover Health when successfully Guard Impact
                    survivalCode.guardBreakRate = ""; //Increase Guard Break Chance
                    survivalCode.throwEscapeChance = ""; //Increase Throw Escape Rate
                    survivalCode.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                    survivalCode.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                    survivalCode.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "0017";
                    survivalCode.stageMusic = "17";
                    survivalCode.stageNumber = 16;
                    survivalCode.model = "4C";
                    survivalCode.costume = "00";
                    survivalCode.fightingStyle = "4C";
                    survivalCode.weaponNumber = "05"; //Chester

                    survivalCode.aiLevel = "03"; // 00-05
                    survivalCode.weaponSpecial = "Minus Guard"; //Fire, Thunder, Paralysis, Cure etc
                    survivalCode.guardianForce = ""; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                    survivalCode.stickyFeet = ""; //Slippery Feets
                    survivalCode.speed = "3F80"; //3F80 default speed
                    survivalCode.voice = null;

                    survivalCode.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                    survivalCode.attack = ""; //Decrease/Increase Attack
                    survivalCode.defense = ""; //Decrease/Increase Defense
                    survivalCode.stealHp = ""; //Steal health from enemy
                    survivalCode.pierceDamage = ""; //Damage inflicted thru guard
                    survivalCode.weaponSize = "";
                    survivalCode.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                    survivalCode.counterRate = ""; //Increase Counter Chance
                    survivalCode.nullCounter = ""; //Nullify Enemies Counters chance
                    survivalCode.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                    survivalCode.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                    survivalCode.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                    survivalCode.parryRegen = ""; //Recover Health when successfully Guard Impact
                    survivalCode.guardBreakRate = ""; //Increase Guard Break Chance
                    survivalCode.throwEscapeChance = ""; //Increase Throw Escape Rate
                    survivalCode.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                    survivalCode.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                    survivalCode.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "";
                    survivalCode.stageNumber = 17;
                    survivalCode.model = "4D";
                    survivalCode.costume = "00";
                    survivalCode.fightingStyle = "4D";
                    survivalCode.weaponNumber = "05"; //Strife

                    survivalCode.aiLevel = "03"; // 00-05
                    survivalCode.weaponSpecial = "Reserve Offense Up"; //Fire, Thunder, Paralysis, Cure etc
                    survivalCode.guardianForce = ""; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                    survivalCode.stickyFeet = ""; //Slippery Feets
                    survivalCode.speed = "3F80"; //3F80 default speed
                    survivalCode.voice = null;

                    survivalCode.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                    survivalCode.attack = ""; //Decrease/Increase Attack
                    survivalCode.defense = ""; //Decrease/Increase Defense
                    survivalCode.stealHp = ""; //Steal health from enemy
                    survivalCode.pierceDamage = ""; //Damage inflicted thru guard
                    survivalCode.weaponSize = "";
                    survivalCode.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                    survivalCode.counterRate = ""; //Increase Counter Chance
                    survivalCode.nullCounter = ""; //Nullify Enemies Counters chance
                    survivalCode.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                    survivalCode.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                    survivalCode.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                    survivalCode.parryRegen = ""; //Recover Health when successfully Guard Impact
                    survivalCode.guardBreakRate = ""; //Increase Guard Break Chance
                    survivalCode.throwEscapeChance = ""; //Increase Throw Escape Rate
                    survivalCode.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                    survivalCode.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                    survivalCode.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "";
                    survivalCode.stageNumber = 18;
                    survivalCode.model = "30";
                    survivalCode.costume = "00";
                    survivalCode.fightingStyle = "30";
                    survivalCode.weaponNumber = "05"; //Amy

                    survivalCode.aiLevel = "03"; // 00-05
                    survivalCode.weaponSpecial = "All Guard Break"; //Fire, Thunder, Paralysis, Cure etc
                    survivalCode.guardianForce = ""; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                    survivalCode.stickyFeet = ""; //Slippery Feets
                    survivalCode.speed = "3F80"; //3F80 default speed
                    survivalCode.voice = null;

                    survivalCode.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                    survivalCode.attack = ""; //Decrease/Increase Attack
                    survivalCode.defense = ""; //Decrease/Increase Defense
                    survivalCode.stealHp = ""; //Steal health from enemy
                    survivalCode.pierceDamage = ""; //Damage inflicted thru guard
                    survivalCode.weaponSize = "";
                    survivalCode.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                    survivalCode.counterRate = ""; //Increase Counter Chance
                    survivalCode.nullCounter = ""; //Nullify Enemies Counters chance
                    survivalCode.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                    survivalCode.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                    survivalCode.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                    survivalCode.parryRegen = ""; //Recover Health when successfully Guard Impact
                    survivalCode.guardBreakRate = ""; //Increase Guard Break Chance
                    survivalCode.throwEscapeChance = ""; //Increase Throw Escape Rate
                    survivalCode.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                    survivalCode.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                    survivalCode.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "";
                    survivalCode.stageNumber = 19;
                    survivalCode.model = "54";
                    survivalCode.costume = "00";
                    survivalCode.fightingStyle = "54";
                    survivalCode.weaponNumber = "05"; //Revenant

                    survivalCode.aiLevel = "03"; // 00-05
                    survivalCode.weaponSpecial = "Defense Up"; //Fire, Thunder, Paralysis, Cure etc
                    survivalCode.guardianForce = ""; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                    survivalCode.stickyFeet = ""; //Slippery Feets
                    survivalCode.speed = "3F80"; //3F80 default speed
                    survivalCode.voice = null;

                    survivalCode.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                    survivalCode.attack = ""; //Decrease/Increase Attack
                    survivalCode.defense = ""; //Decrease/Increase Defense
                    survivalCode.stealHp = ""; //Steal health from enemy
                    survivalCode.pierceDamage = ""; //Damage inflicted thru guard
                    survivalCode.weaponSize = "";
                    survivalCode.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                    survivalCode.counterRate = ""; //Increase Counter Chance
                    survivalCode.nullCounter = ""; //Nullify Enemies Counters chance
                    survivalCode.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                    survivalCode.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                    survivalCode.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                    survivalCode.parryRegen = ""; //Recover Health when successfully Guard Impact
                    survivalCode.guardBreakRate = ""; //Increase Guard Break Chance
                    survivalCode.throwEscapeChance = ""; //Increase Throw Escape Rate
                    survivalCode.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                    survivalCode.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                    survivalCode.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "";
                    survivalCode.stageNumber = 20;
                    survivalCode.model = "2E";
                    survivalCode.costume = "00";
                    survivalCode.fightingStyle = "2E";
                    survivalCode.weaponNumber = "00"; //Shadow Master

                    survivalCode.aiLevel = "04"; // 00-05
                    survivalCode.weaponSpecial = ""; //Fire, Thunder, Paralysis, Cure etc
                    survivalCode.guardianForce = ""; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                    survivalCode.stickyFeet = ""; //Slippery Feets
                    survivalCode.speed = "3F88"; //3F80 default speed
                    survivalCode.voice = "68";

                    survivalCode.weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                    survivalCode.attack = ""; //Decrease/Increase Attack
                    survivalCode.defense = ""; //Decrease/Increase Defense
                    survivalCode.stealHp = ""; //Steal health from enemy
                    survivalCode.pierceDamage = ""; //Damage inflicted thru guard
                    survivalCode.weaponSize = "";
                    survivalCode.atkPushForce = ""; //Decrease/Increase Attack Pushback Force
                    survivalCode.counterRate = ""; //Increase Counter Chance
                    survivalCode.nullCounter = ""; //Nullify Enemies Counters chance
                    survivalCode.guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
                    survivalCode.autoGuardImpact = ""; //Automatically Guard Impact some attacks
                    survivalCode.parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
                    survivalCode.parryRegen = ""; //Recover Health when successfully Guard Impact
                    survivalCode.guardBreakRate = ""; //Increase Guard Break Chance
                    survivalCode.throwEscapeChance = ""; //Increase Throw Escape Rate
                    survivalCode.ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
                    survivalCode.hpRegenOrDrain = ""; //Drain/Recover Health over Time
                    survivalCode.hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking
                    stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                    break;
                #endregion

                #region Custom Arc [Your selection]
                case "Custom Arc":

                    string appFolder = AppDomain.CurrentDomain.BaseDirectory;
                    string customFolder = Path.Combine(appFolder, "Custom Survival Files");
                    string templateFile = Path.Combine(customFolder, "template.txt");

                    if (File.Exists(templateFile))
                    {
                        string fileContents = File.ReadAllText(templateFile);

                        // Split into parts by #
                        List<string> parts = fileContents
                            .Split('#')
                            .ToList();

                        // For each part, extract values inside quotes and store in a list of lists
                        List<List<string>> importedData = parts
                            .Select(part =>
                                Regex.Matches(part, "\"([^\"]*)\"")
                                     .Cast<Match>()
                                     .Select(m => m.Groups[1].Value)
                                     .ToList()
                            )
                            .ToList();


                        survivalCode.stageLevel = importedData[0][0];
                        survivalCode.stageMusic = importedData[0][1];
                        survivalCode.stageNumber = 1;
                        survivalCode.model = importedData[1][0];
                        survivalCode.costume = importedData[1][1];
                        survivalCode.fightingStyle = importedData[1][2];
                        survivalCode.weaponNumber = importedData[1][3];

                        survivalCode.aiLevel = importedData[1][4]; // 00-05
                        survivalCode.weaponSpecial = importedData[1][5]; //Fire, Thunder, Paralysis, Cure etc
                        survivalCode.guardianForce = importedData[1][6]; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                        survivalCode.stickyFeet = importedData[1][7]; //Slippery Feets
                        survivalCode.speed = importedData[1][8]; //3F80 default speed
                        survivalCode.voice = importedData[1][9];

                        survivalCode.weaponEffect = importedData[1][10]; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                        survivalCode.attack = importedData[1][11]; //Decrease/Increase Attack
                        survivalCode.defense = importedData[1][12]; //Decrease/Increase Defense
                        survivalCode.stealHp = importedData[1][13]; //Steal health from enemy
                        survivalCode.pierceDamage = importedData[1][14]; //Damage inflicted thru guard
                        survivalCode.weaponSize = importedData[1][15];
                        survivalCode.atkPushForce = importedData[1][16]; //Decrease/Increase Attack Pushback Force
                        survivalCode.counterRate = importedData[1][17]; //Increase Counter Chance
                        survivalCode.nullCounter = importedData[1][18]; //Nullify Enemies Counters chance
                        survivalCode.guardHpModify = importedData[1][19]; //Decrease/Increase Health while guarding enemies attacks
                        survivalCode.autoGuardImpact = importedData[1][20]; //Automatically Guard Impact some attacks
                        survivalCode.parryDamage = importedData[1][20]; //Increase Damage Received by Opponent when successfully Guard Impact
                        survivalCode.parryRegen = importedData[1][21]; //Recover Health when successfully Guard Impact
                        survivalCode.guardBreakRate = importedData[1][22]; //Increase Guard Break Chance
                        survivalCode.throwEscapeChance = importedData[1][23]; //Increase Throw Escape Rate
                        survivalCode.ringOutEscapeChance = importedData[1][24]; //Increase Ring-Out Escape Rate
                        survivalCode.hpRegenOrDrain = importedData[1][25]; //Drain/Recover Health over Time
                        survivalCode.hpRegenOrDrainOnAtk = importedData[1][26]; //Drain/Recover Health when Attacking
                        stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                        //////////////////////////////////////////////////////////////////////////////////////////////////
                        survivalCode.stageLevel = "";
                        survivalCode.stageNumber = 2;
                        survivalCode.model = importedData[2][0];
                        survivalCode.costume = importedData[2][1];
                        survivalCode.fightingStyle = importedData[2][2];
                        survivalCode.weaponNumber = importedData[2][3];

                        survivalCode.aiLevel = importedData[2][4]; // 00-05
                        survivalCode.weaponSpecial = importedData[2][5]; //Fire, Thunder, Paralysis, Cure etc
                        survivalCode.guardianForce = importedData[2][6]; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                        survivalCode.stickyFeet = importedData[2][7]; //Slippery Feets
                        survivalCode.speed = importedData[2][8]; //3F80 default speed
                        survivalCode.voice = importedData[2][9];

                        survivalCode.weaponEffect = importedData[2][10]; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                        survivalCode.attack = importedData[2][11]; //Decrease/Increase Attack
                        survivalCode.defense = importedData[2][12]; //Decrease/Increase Defense
                        survivalCode.stealHp = importedData[2][13]; //Steal health from enemy
                        survivalCode.pierceDamage = importedData[2][14]; //Damage inflicted thru guard
                        survivalCode.weaponSize = importedData[2][15];
                        survivalCode.atkPushForce = importedData[2][16]; //Decrease/Increase Attack Pushback Force
                        survivalCode.counterRate = importedData[2][17]; //Increase Counter Chance
                        survivalCode.nullCounter = importedData[2][18]; //Nullify Enemies Counters chance
                        survivalCode.guardHpModify = importedData[2][19]; //Decrease/Increase Health while guarding enemies attacks
                        survivalCode.autoGuardImpact = importedData[2][20]; //Automatically Guard Impact some attacks
                        survivalCode.parryDamage = importedData[2][20]; //Increase Damage Received by Opponent when successfully Guard Impact
                        survivalCode.parryRegen = importedData[2][21]; //Recover Health when successfully Guard Impact
                        survivalCode.guardBreakRate = importedData[2][22]; //Increase Guard Break Chance
                        survivalCode.throwEscapeChance = importedData[2][23]; //Increase Throw Escape Rate
                        survivalCode.ringOutEscapeChance = importedData[2][24]; //Increase Ring-Out Escape Rate
                        survivalCode.hpRegenOrDrain = importedData[2][25]; //Drain/Recover Health over Time
                        survivalCode.hpRegenOrDrainOnAtk = importedData[2][26]; //Drain/Recover Health when Attacking
                        stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                        //////////////////////////////////////////////////////////////////////////////////////////////////
                        survivalCode.stageLevel = "";
                        survivalCode.stageNumber = 3;
                        survivalCode.model = importedData[3][0];
                        survivalCode.costume = importedData[3][1];
                        survivalCode.fightingStyle = importedData[3][2];
                        survivalCode.weaponNumber = importedData[3][3];

                        survivalCode.aiLevel = importedData[3][4]; // 00-05
                        survivalCode.weaponSpecial = importedData[3][5]; //Fire, Thunder, Paralysis, Cure etc
                        survivalCode.guardianForce = importedData[3][6]; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                        survivalCode.stickyFeet = importedData[3][7]; //Slippery Feets
                        survivalCode.speed = importedData[3][8]; //3F80 default speed
                        survivalCode.voice = importedData[3][9];

                        survivalCode.weaponEffect = importedData[3][10]; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                        survivalCode.attack = importedData[3][11]; //Decrease/Increase Attack
                        survivalCode.defense = importedData[3][12]; //Decrease/Increase Defense
                        survivalCode.stealHp = importedData[3][13]; //Steal health from enemy
                        survivalCode.pierceDamage = importedData[3][14]; //Damage inflicted thru guard
                        survivalCode.weaponSize = importedData[3][15];
                        survivalCode.atkPushForce = importedData[3][16]; //Decrease/Increase Attack Pushback Force
                        survivalCode.counterRate = importedData[3][17]; //Increase Counter Chance
                        survivalCode.nullCounter = importedData[3][18]; //Nullify Enemies Counters chance
                        survivalCode.guardHpModify = importedData[3][19]; //Decrease/Increase Health while guarding enemies attacks
                        survivalCode.autoGuardImpact = importedData[3][20]; //Automatically Guard Impact some attacks
                        survivalCode.parryDamage = importedData[3][20]; //Increase Damage Received by Opponent when successfully Guard Impact
                        survivalCode.parryRegen = importedData[3][21]; //Recover Health when successfully Guard Impact
                        survivalCode.guardBreakRate = importedData[3][22]; //Increase Guard Break Chance
                        survivalCode.throwEscapeChance = importedData[3][23]; //Increase Throw Escape Rate
                        survivalCode.ringOutEscapeChance = importedData[3][24]; //Increase Ring-Out Escape Rate
                        survivalCode.hpRegenOrDrain = importedData[3][25]; //Drain/Recover Health over Time
                        survivalCode.hpRegenOrDrainOnAtk = importedData[3][26]; //Drain/Recover Health when Attacking
                        stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                        //////////////////////////////////////////////////////////////////////////////////////////////////
                        survivalCode.stageLevel = "";
                        survivalCode.stageNumber = 4;
                        survivalCode.model = importedData[4][0];
                        survivalCode.costume = importedData[4][1];
                        survivalCode.fightingStyle = importedData[4][2];
                        survivalCode.weaponNumber = importedData[4][3];

                        survivalCode.aiLevel = importedData[4][4]; // 00-05
                        survivalCode.weaponSpecial = importedData[4][5]; //Fire, Thunder, Paralysis, Cure etc
                        survivalCode.guardianForce = importedData[4][6]; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                        survivalCode.stickyFeet = importedData[4][7]; //Slippery Feets
                        survivalCode.speed = importedData[4][8]; //3F80 default speed
                        survivalCode.voice = importedData[4][9];

                        survivalCode.weaponEffect = importedData[4][10]; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                        survivalCode.attack = importedData[4][11]; //Decrease/Increase Attack
                        survivalCode.defense = importedData[4][12]; //Decrease/Increase Defense
                        survivalCode.stealHp = importedData[4][13]; //Steal health from enemy
                        survivalCode.pierceDamage = importedData[4][14]; //Damage inflicted thru guard
                        survivalCode.weaponSize = importedData[4][15];
                        survivalCode.atkPushForce = importedData[4][16]; //Decrease/Increase Attack Pushback Force
                        survivalCode.counterRate = importedData[4][17]; //Increase Counter Chance
                        survivalCode.nullCounter = importedData[4][18]; //Nullify Enemies Counters chance
                        survivalCode.guardHpModify = importedData[4][19]; //Decrease/Increase Health while guarding enemies attacks
                        survivalCode.autoGuardImpact = importedData[4][20]; //Automatically Guard Impact some attacks
                        survivalCode.parryDamage = importedData[4][20]; //Increase Damage Received by Opponent when successfully Guard Impact
                        survivalCode.parryRegen = importedData[4][21]; //Recover Health when successfully Guard Impact
                        survivalCode.guardBreakRate = importedData[4][22]; //Increase Guard Break Chance
                        survivalCode.throwEscapeChance = importedData[4][23]; //Increase Throw Escape Rate
                        survivalCode.ringOutEscapeChance = importedData[4][24]; //Increase Ring-Out Escape Rate
                        survivalCode.hpRegenOrDrain = importedData[4][25]; //Drain/Recover Health over Time
                        survivalCode.hpRegenOrDrainOnAtk = importedData[4][26]; //Drain/Recover Health when Attacking
                        stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                        //////////////////////////////////////////////////////////////////////////////////////////////////
                        survivalCode.stageLevel = "";
                        survivalCode.stageNumber = 5;
                        survivalCode.model = importedData[5][0];
                        survivalCode.costume = importedData[5][1];
                        survivalCode.fightingStyle = importedData[5][2];
                        survivalCode.weaponNumber = importedData[5][3];

                        survivalCode.aiLevel = importedData[5][4]; // 00-05
                        survivalCode.weaponSpecial = importedData[5][5]; //Fire, Thunder, Paralysis, Cure etc
                        survivalCode.guardianForce = importedData[5][6]; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                        survivalCode.stickyFeet = importedData[5][7]; //Slippery Feets
                        survivalCode.speed = importedData[5][8]; //3F80 default speed
                        survivalCode.voice = importedData[5][9];

                        survivalCode.weaponEffect = importedData[5][10]; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                        survivalCode.attack = importedData[5][11]; //Decrease/Increase Attack
                        survivalCode.defense = importedData[5][12]; //Decrease/Increase Defense
                        survivalCode.stealHp = importedData[5][13]; //Steal health from enemy
                        survivalCode.pierceDamage = importedData[5][14]; //Damage inflicted thru guard
                        survivalCode.weaponSize = importedData[5][15];
                        survivalCode.atkPushForce = importedData[5][16]; //Decrease/Increase Attack Pushback Force
                        survivalCode.counterRate = importedData[5][17]; //Increase Counter Chance
                        survivalCode.nullCounter = importedData[5][18]; //Nullify Enemies Counters chance
                        survivalCode.guardHpModify = importedData[5][19]; //Decrease/Increase Health while guarding enemies attacks
                        survivalCode.autoGuardImpact = importedData[5][20]; //Automatically Guard Impact some attacks
                        survivalCode.parryDamage = importedData[5][20]; //Increase Damage Received by Opponent when successfully Guard Impact
                        survivalCode.parryRegen = importedData[5][21]; //Recover Health when successfully Guard Impact
                        survivalCode.guardBreakRate = importedData[5][22]; //Increase Guard Break Chance
                        survivalCode.throwEscapeChance = importedData[5][23]; //Increase Throw Escape Rate
                        survivalCode.ringOutEscapeChance = importedData[5][24]; //Increase Ring-Out Escape Rate
                        survivalCode.hpRegenOrDrain = importedData[5][25]; //Drain/Recover Health over Time
                        survivalCode.hpRegenOrDrainOnAtk = importedData[5][26]; //Drain/Recover Health when Attacking
                        stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                        //////////////////////////////////////////////////////////////////////////////////////////////////
                        survivalCode.stageLevel = importedData[0][2];
                        survivalCode.stageMusic = importedData[0][3];
                        survivalCode.stageNumber = 6;
                        survivalCode.model = importedData[6][0];
                        survivalCode.costume = importedData[6][1];
                        survivalCode.fightingStyle = importedData[6][2];
                        survivalCode.weaponNumber = importedData[6][3];

                        survivalCode.aiLevel = importedData[6][4]; // 00-05
                        survivalCode.weaponSpecial = importedData[6][5]; //Fire, Thunder, Paralysis, Cure etc
                        survivalCode.guardianForce = importedData[6][6]; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                        survivalCode.stickyFeet = importedData[6][7]; //Slippery Feets
                        survivalCode.speed = importedData[6][8]; //3F80 default speed
                        survivalCode.voice = importedData[6][9];

                        survivalCode.weaponEffect = importedData[6][10]; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                        survivalCode.attack = importedData[6][11]; //Decrease/Increase Attack
                        survivalCode.defense = importedData[6][12]; //Decrease/Increase Defense
                        survivalCode.stealHp = importedData[6][13]; //Steal health from enemy
                        survivalCode.pierceDamage = importedData[6][14]; //Damage inflicted thru guard
                        survivalCode.weaponSize = importedData[6][15];
                        survivalCode.atkPushForce = importedData[6][16]; //Decrease/Increase Attack Pushback Force
                        survivalCode.counterRate = importedData[6][17]; //Increase Counter Chance
                        survivalCode.nullCounter = importedData[6][18]; //Nullify Enemies Counters chance
                        survivalCode.guardHpModify = importedData[6][19]; //Decrease/Increase Health while guarding enemies attacks
                        survivalCode.autoGuardImpact = importedData[6][20]; //Automatically Guard Impact some attacks
                        survivalCode.parryDamage = importedData[6][20]; //Increase Damage Received by Opponent when successfully Guard Impact
                        survivalCode.parryRegen = importedData[6][21]; //Recover Health when successfully Guard Impact
                        survivalCode.guardBreakRate = importedData[6][22]; //Increase Guard Break Chance
                        survivalCode.throwEscapeChance = importedData[6][23]; //Increase Throw Escape Rate
                        survivalCode.ringOutEscapeChance = importedData[6][24]; //Increase Ring-Out Escape Rate
                        survivalCode.hpRegenOrDrain = importedData[6][25]; //Drain/Recover Health over Time
                        survivalCode.hpRegenOrDrainOnAtk = importedData[6][26]; //Drain/Recover Health when Attacking
                        stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                        //////////////////////////////////////////////////////////////////////////////////////////////////
                        survivalCode.stageLevel = "";
                        survivalCode.stageNumber = 7;
                        survivalCode.model = importedData[7][0];
                        survivalCode.costume = importedData[7][1];
                        survivalCode.fightingStyle = importedData[7][2];
                        survivalCode.weaponNumber = importedData[7][3];

                        survivalCode.aiLevel = importedData[7][4]; // 00-05
                        survivalCode.weaponSpecial = importedData[7][5]; //Fire, Thunder, Paralysis, Cure etc
                        survivalCode.guardianForce = importedData[7][6]; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                        survivalCode.stickyFeet = importedData[7][7]; //Slippery Feets
                        survivalCode.speed = importedData[7][8]; //3F80 default speed
                        survivalCode.voice = importedData[7][9];

                        survivalCode.weaponEffect = importedData[7][10]; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                        survivalCode.attack = importedData[7][11]; //Decrease/Increase Attack
                        survivalCode.defense = importedData[7][12]; //Decrease/Increase Defense
                        survivalCode.stealHp = importedData[7][13]; //Steal health from enemy
                        survivalCode.pierceDamage = importedData[7][14]; //Damage inflicted thru guard
                        survivalCode.weaponSize = importedData[7][15];
                        survivalCode.atkPushForce = importedData[7][16]; //Decrease/Increase Attack Pushback Force
                        survivalCode.counterRate = importedData[7][17]; //Increase Counter Chance
                        survivalCode.nullCounter = importedData[7][18]; //Nullify Enemies Counters chance
                        survivalCode.guardHpModify = importedData[7][19]; //Decrease/Increase Health while guarding enemies attacks
                        survivalCode.autoGuardImpact = importedData[7][20]; //Automatically Guard Impact some attacks
                        survivalCode.parryDamage = importedData[7][20]; //Increase Damage Received by Opponent when successfully Guard Impact
                        survivalCode.parryRegen = importedData[7][21]; //Recover Health when successfully Guard Impact
                        survivalCode.guardBreakRate = importedData[7][22]; //Increase Guard Break Chance
                        survivalCode.throwEscapeChance = importedData[7][23]; //Increase Throw Escape Rate
                        survivalCode.ringOutEscapeChance = importedData[7][24]; //Increase Ring-Out Escape Rate
                        survivalCode.hpRegenOrDrain = importedData[7][25]; //Drain/Recover Health over Time
                        survivalCode.hpRegenOrDrainOnAtk = importedData[7][26]; //Drain/Recover Health when Attacking
                        stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                        //////////////////////////////////////////////////////////////////////////////////////////////////
                        survivalCode.stageLevel = "";
                        survivalCode.stageNumber = 8;
                        survivalCode.model = importedData[8][0];
                        survivalCode.costume = importedData[8][1];
                        survivalCode.fightingStyle = importedData[8][2];
                        survivalCode.weaponNumber = importedData[8][3];

                        survivalCode.aiLevel = importedData[8][4]; // 00-05
                        survivalCode.weaponSpecial = importedData[8][5]; //Fire, Thunder, Paralysis, Cure etc
                        survivalCode.guardianForce = importedData[8][6]; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                        survivalCode.stickyFeet = importedData[8][7]; //Slippery Feets
                        survivalCode.speed = importedData[8][8]; //3F80 default speed
                        survivalCode.voice = importedData[8][9];

                        survivalCode.weaponEffect = importedData[8][10]; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                        survivalCode.attack = importedData[8][11]; //Decrease/Increase Attack
                        survivalCode.defense = importedData[8][12]; //Decrease/Increase Defense
                        survivalCode.stealHp = importedData[8][13]; //Steal health from enemy
                        survivalCode.pierceDamage = importedData[8][14]; //Damage inflicted thru guard
                        survivalCode.weaponSize = importedData[8][15];
                        survivalCode.atkPushForce = importedData[8][16]; //Decrease/Increase Attack Pushback Force
                        survivalCode.counterRate = importedData[8][17]; //Increase Counter Chance
                        survivalCode.nullCounter = importedData[8][18]; //Nullify Enemies Counters chance
                        survivalCode.guardHpModify = importedData[8][19]; //Decrease/Increase Health while guarding enemies attacks
                        survivalCode.autoGuardImpact = importedData[8][20]; //Automatically Guard Impact some attacks
                        survivalCode.parryDamage = importedData[8][20]; //Increase Damage Received by Opponent when successfully Guard Impact
                        survivalCode.parryRegen = importedData[8][21]; //Recover Health when successfully Guard Impact
                        survivalCode.guardBreakRate = importedData[8][22]; //Increase Guard Break Chance
                        survivalCode.throwEscapeChance = importedData[8][23]; //Increase Throw Escape Rate
                        survivalCode.ringOutEscapeChance = importedData[8][24]; //Increase Ring-Out Escape Rate
                        survivalCode.hpRegenOrDrain = importedData[8][25]; //Drain/Recover Health over Time
                        survivalCode.hpRegenOrDrainOnAtk = importedData[8][26]; //Drain/Recover Health when Attacking
                        stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                        //////////////////////////////////////////////////////////////////////////////////////////////////
                        survivalCode.stageLevel = "";
                        survivalCode.stageNumber = 9;
                        survivalCode.model = importedData[9][0];
                        survivalCode.costume = importedData[9][1];
                        survivalCode.fightingStyle = importedData[9][2];
                        survivalCode.weaponNumber = importedData[9][3];

                        survivalCode.aiLevel = importedData[9][4]; // 00-05
                        survivalCode.weaponSpecial = importedData[9][5]; //Fire, Thunder, Paralysis, Cure etc
                        survivalCode.guardianForce = importedData[9][6]; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                        survivalCode.stickyFeet = importedData[9][7]; //Slippery Feets
                        survivalCode.speed = importedData[9][8]; //3F80 default speed
                        survivalCode.voice = importedData[9][9];

                        survivalCode.weaponEffect = importedData[9][10]; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                        survivalCode.attack = importedData[9][11]; //Decrease/Increase Attack
                        survivalCode.defense = importedData[9][12]; //Decrease/Increase Defense
                        survivalCode.stealHp = importedData[9][13]; //Steal health from enemy
                        survivalCode.pierceDamage = importedData[9][14]; //Damage inflicted thru guard
                        survivalCode.weaponSize = importedData[9][15];
                        survivalCode.atkPushForce = importedData[9][16]; //Decrease/Increase Attack Pushback Force
                        survivalCode.counterRate = importedData[9][17]; //Increase Counter Chance
                        survivalCode.nullCounter = importedData[9][18]; //Nullify Enemies Counters chance
                        survivalCode.guardHpModify = importedData[9][19]; //Decrease/Increase Health while guarding enemies attacks
                        survivalCode.autoGuardImpact = importedData[9][20]; //Automatically Guard Impact some attacks
                        survivalCode.parryDamage = importedData[9][20]; //Increase Damage Received by Opponent when successfully Guard Impact
                        survivalCode.parryRegen = importedData[9][21]; //Recover Health when successfully Guard Impact
                        survivalCode.guardBreakRate = importedData[9][22]; //Increase Guard Break Chance
                        survivalCode.throwEscapeChance = importedData[9][23]; //Increase Throw Escape Rate
                        survivalCode.ringOutEscapeChance = importedData[9][24]; //Increase Ring-Out Escape Rate
                        survivalCode.hpRegenOrDrain = importedData[9][25]; //Drain/Recover Health over Time
                        survivalCode.hpRegenOrDrainOnAtk = importedData[9][26]; //Drain/Recover Health when Attacking
                        stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                        //////////////////////////////////////////////////////////////////////////////////////////////////
                        survivalCode.stageLevel = "";
                        survivalCode.stageNumber = 10;
                        survivalCode.model = importedData[10][0];
                        survivalCode.costume = importedData[10][1];
                        survivalCode.fightingStyle = importedData[10][2];
                        survivalCode.weaponNumber = importedData[10][3];

                        survivalCode.aiLevel = importedData[10][4]; // 00-05
                        survivalCode.weaponSpecial = importedData[10][5]; //Fire, Thunder, Paralysis, Cure etc
                        survivalCode.guardianForce = importedData[10][6]; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                        survivalCode.stickyFeet = importedData[10][7]; //Slippery Feets
                        survivalCode.speed = importedData[10][8]; //3F80 default speed
                        survivalCode.voice = importedData[10][9];

                        survivalCode.weaponEffect = importedData[10][10]; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                        survivalCode.attack = importedData[10][11]; //Decrease/Increase Attack
                        survivalCode.defense = importedData[10][12]; //Decrease/Increase Defense
                        survivalCode.stealHp = importedData[10][13]; //Steal health from enemy
                        survivalCode.pierceDamage = importedData[10][14]; //Damage inflicted thru guard
                        survivalCode.weaponSize = importedData[10][15];
                        survivalCode.atkPushForce = importedData[10][16]; //Decrease/Increase Attack Pushback Force
                        survivalCode.counterRate = importedData[10][17]; //Increase Counter Chance
                        survivalCode.nullCounter = importedData[10][18]; //Nullify Enemies Counters chance
                        survivalCode.guardHpModify = importedData[10][19]; //Decrease/Increase Health while guarding enemies attacks
                        survivalCode.autoGuardImpact = importedData[10][20]; //Automatically Guard Impact some attacks
                        survivalCode.parryDamage = importedData[10][20]; //Increase Damage Received by Opponent when successfully Guard Impact
                        survivalCode.parryRegen = importedData[10][21]; //Recover Health when successfully Guard Impact
                        survivalCode.guardBreakRate = importedData[10][22]; //Increase Guard Break Chance
                        survivalCode.throwEscapeChance = importedData[10][23]; //Increase Throw Escape Rate
                        survivalCode.ringOutEscapeChance = importedData[10][24]; //Increase Ring-Out Escape Rate
                        survivalCode.hpRegenOrDrain = importedData[10][25]; //Drain/Recover Health over Time
                        survivalCode.hpRegenOrDrainOnAtk = importedData[10][26]; //Drain/Recover Health when Attacking
                        stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                        //////////////////////////////////////////////////////////////////////////////////////////////////
                        survivalCode.stageLevel = importedData[0][4];
                        survivalCode.stageMusic = importedData[0][5];
                        survivalCode.stageNumber = 11;
                        survivalCode.model = importedData[11][0];
                        survivalCode.costume = importedData[11][1];
                        survivalCode.fightingStyle = importedData[11][2];
                        survivalCode.weaponNumber = importedData[11][3];

                        survivalCode.aiLevel = importedData[11][4]; // 00-05
                        survivalCode.weaponSpecial = importedData[11][5]; //Fire, Thunder, Paralysis, Cure etc
                        survivalCode.guardianForce = importedData[11][6]; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                        survivalCode.stickyFeet = importedData[11][7]; //Slippery Feets
                        survivalCode.speed = importedData[11][8]; //3F80 default speed
                        survivalCode.voice = importedData[11][9];

                        survivalCode.weaponEffect = importedData[11][10]; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                        survivalCode.attack = importedData[11][11]; //Decrease/Increase Attack
                        survivalCode.defense = importedData[11][12]; //Decrease/Increase Defense
                        survivalCode.stealHp = importedData[11][13]; //Steal health from enemy
                        survivalCode.pierceDamage = importedData[11][14]; //Damage inflicted thru guard
                        survivalCode.weaponSize = importedData[11][15];
                        survivalCode.atkPushForce = importedData[11][16]; //Decrease/Increase Attack Pushback Force
                        survivalCode.counterRate = importedData[11][17]; //Increase Counter Chance
                        survivalCode.nullCounter = importedData[11][18]; //Nullify Enemies Counters chance
                        survivalCode.guardHpModify = importedData[11][19]; //Decrease/Increase Health while guarding enemies attacks
                        survivalCode.autoGuardImpact = importedData[11][20]; //Automatically Guard Impact some attacks
                        survivalCode.parryDamage = importedData[11][20]; //Increase Damage Received by Opponent when successfully Guard Impact
                        survivalCode.parryRegen = importedData[11][21]; //Recover Health when successfully Guard Impact
                        survivalCode.guardBreakRate = importedData[11][22]; //Increase Guard Break Chance
                        survivalCode.throwEscapeChance = importedData[11][23]; //Increase Throw Escape Rate
                        survivalCode.ringOutEscapeChance = importedData[11][24]; //Increase Ring-Out Escape Rate
                        survivalCode.hpRegenOrDrain = importedData[11][25]; //Drain/Recover Health over Time
                        survivalCode.hpRegenOrDrainOnAtk = importedData[11][26]; //Drain/Recover Health when Attacking
                        stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                        //////////////////////////////////////////////////////////////////////////////////////////////////
                        survivalCode.stageLevel = "";
                        survivalCode.stageNumber = 12;
                        survivalCode.model = importedData[12][0];
                        survivalCode.costume = importedData[12][1];
                        survivalCode.fightingStyle = importedData[12][2];
                        survivalCode.weaponNumber = importedData[12][3];

                        survivalCode.aiLevel = importedData[12][4]; // 00-05
                        survivalCode.weaponSpecial = importedData[12][5]; //Fire, Thunder, Paralysis, Cure etc
                        survivalCode.guardianForce = importedData[12][6]; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                        survivalCode.stickyFeet = importedData[12][7]; //Slippery Feets
                        survivalCode.speed = importedData[12][8]; //3F80 default speed
                        survivalCode.voice = importedData[12][9];

                        survivalCode.weaponEffect = importedData[12][10]; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                        survivalCode.attack = importedData[12][11]; //Decrease/Increase Attack
                        survivalCode.defense = importedData[12][12]; //Decrease/Increase Defense
                        survivalCode.stealHp = importedData[12][13]; //Steal health from enemy
                        survivalCode.pierceDamage = importedData[12][14]; //Damage inflicted thru guard
                        survivalCode.weaponSize = importedData[12][15];
                        survivalCode.atkPushForce = importedData[12][16]; //Decrease/Increase Attack Pushback Force
                        survivalCode.counterRate = importedData[12][17]; //Increase Counter Chance
                        survivalCode.nullCounter = importedData[12][18]; //Nullify Enemies Counters chance
                        survivalCode.guardHpModify = importedData[12][19]; //Decrease/Increase Health while guarding enemies attacks
                        survivalCode.autoGuardImpact = importedData[12][20]; //Automatically Guard Impact some attacks
                        survivalCode.parryDamage = importedData[12][20]; //Increase Damage Received by Opponent when successfully Guard Impact
                        survivalCode.parryRegen = importedData[12][21]; //Recover Health when successfully Guard Impact
                        survivalCode.guardBreakRate = importedData[12][22]; //Increase Guard Break Chance
                        survivalCode.throwEscapeChance = importedData[12][23]; //Increase Throw Escape Rate
                        survivalCode.ringOutEscapeChance = importedData[12][24]; //Increase Ring-Out Escape Rate
                        survivalCode.hpRegenOrDrain = importedData[12][25]; //Drain/Recover Health over Time
                        survivalCode.hpRegenOrDrainOnAtk = importedData[12][26]; //Drain/Recover Health when Attacking
                        stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                        //////////////////////////////////////////////////////////////////////////////////////////////////
                        survivalCode.stageLevel = "";
                        survivalCode.stageNumber = 13;
                        survivalCode.model = importedData[13][0];
                        survivalCode.costume = importedData[13][1];
                        survivalCode.fightingStyle = importedData[13][2];
                        survivalCode.weaponNumber = importedData[13][3];

                        survivalCode.aiLevel = importedData[13][4]; // 00-05
                        survivalCode.weaponSpecial = importedData[13][5]; //Fire, Thunder, Paralysis, Cure etc
                        survivalCode.guardianForce = importedData[13][6]; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                        survivalCode.stickyFeet = importedData[13][7]; //Slippery Feets
                        survivalCode.speed = importedData[13][8]; //3F80 default speed
                        survivalCode.voice = importedData[13][9];

                        survivalCode.weaponEffect = importedData[13][10]; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                        survivalCode.attack = importedData[13][11]; //Decrease/Increase Attack
                        survivalCode.defense = importedData[13][12]; //Decrease/Increase Defense
                        survivalCode.stealHp = importedData[13][13]; //Steal health from enemy
                        survivalCode.pierceDamage = importedData[13][14]; //Damage inflicted thru guard
                        survivalCode.weaponSize = importedData[13][15];
                        survivalCode.atkPushForce = importedData[13][16]; //Decrease/Increase Attack Pushback Force
                        survivalCode.counterRate = importedData[13][17]; //Increase Counter Chance
                        survivalCode.nullCounter = importedData[13][18]; //Nullify Enemies Counters chance
                        survivalCode.guardHpModify = importedData[13][19]; //Decrease/Increase Health while guarding enemies attacks
                        survivalCode.autoGuardImpact = importedData[13][20]; //Automatically Guard Impact some attacks
                        survivalCode.parryDamage = importedData[13][20]; //Increase Damage Received by Opponent when successfully Guard Impact
                        survivalCode.parryRegen = importedData[13][21]; //Recover Health when successfully Guard Impact
                        survivalCode.guardBreakRate = importedData[13][22]; //Increase Guard Break Chance
                        survivalCode.throwEscapeChance = importedData[13][23]; //Increase Throw Escape Rate
                        survivalCode.ringOutEscapeChance = importedData[13][24]; //Increase Ring-Out Escape Rate
                        survivalCode.hpRegenOrDrain = importedData[13][25]; //Drain/Recover Health over Time
                        survivalCode.hpRegenOrDrainOnAtk = importedData[13][26]; //Drain/Recover Health when Attacking
                        stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                        //////////////////////////////////////////////////////////////////////////////////////////////////
                        survivalCode.stageLevel = "";
                        survivalCode.stageNumber = 14;
                        survivalCode.model = importedData[14][0];
                        survivalCode.costume = importedData[14][1];
                        survivalCode.fightingStyle = importedData[14][2];
                        survivalCode.weaponNumber = importedData[14][3];

                        survivalCode.aiLevel = importedData[14][4]; // 00-05
                        survivalCode.weaponSpecial = importedData[14][5]; //Fire, Thunder, Paralysis, Cure etc
                        survivalCode.guardianForce = importedData[14][6]; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                        survivalCode.stickyFeet = importedData[14][7]; //Slippery Feets
                        survivalCode.speed = importedData[14][8]; //3F80 default speed
                        survivalCode.voice = importedData[14][9];

                        survivalCode.weaponEffect = importedData[14][10]; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                        survivalCode.attack = importedData[14][11]; //Decrease/Increase Attack
                        survivalCode.defense = importedData[14][12]; //Decrease/Increase Defense
                        survivalCode.stealHp = importedData[14][13]; //Steal health from enemy
                        survivalCode.pierceDamage = importedData[14][14]; //Damage inflicted thru guard
                        survivalCode.weaponSize = importedData[14][15];
                        survivalCode.atkPushForce = importedData[14][16]; //Decrease/Increase Attack Pushback Force
                        survivalCode.counterRate = importedData[14][17]; //Increase Counter Chance
                        survivalCode.nullCounter = importedData[14][18]; //Nullify Enemies Counters chance
                        survivalCode.guardHpModify = importedData[14][19]; //Decrease/Increase Health while guarding enemies attacks
                        survivalCode.autoGuardImpact = importedData[14][20]; //Automatically Guard Impact some attacks
                        survivalCode.parryDamage = importedData[14][20]; //Increase Damage Received by Opponent when successfully Guard Impact
                        survivalCode.parryRegen = importedData[14][21]; //Recover Health when successfully Guard Impact
                        survivalCode.guardBreakRate = importedData[14][22]; //Increase Guard Break Chance
                        survivalCode.throwEscapeChance = importedData[14][23]; //Increase Throw Escape Rate
                        survivalCode.ringOutEscapeChance = importedData[14][24]; //Increase Ring-Out Escape Rate
                        survivalCode.hpRegenOrDrain = importedData[14][25]; //Drain/Recover Health over Time
                        survivalCode.hpRegenOrDrainOnAtk = importedData[14][26]; //Drain/Recover Health when Attacking
                        stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                        //////////////////////////////////////////////////////////////////////////////////////////////////
                        survivalCode.stageLevel = "";
                        survivalCode.stageNumber = 15;
                        survivalCode.model = importedData[15][0];
                        survivalCode.costume = importedData[15][1];
                        survivalCode.fightingStyle = importedData[15][2];
                        survivalCode.weaponNumber = importedData[15][3];

                        survivalCode.aiLevel = importedData[15][4]; // 00-05
                        survivalCode.weaponSpecial = importedData[15][5]; //Fire, Thunder, Paralysis, Cure etc
                        survivalCode.guardianForce = importedData[15][6]; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                        survivalCode.stickyFeet = importedData[15][7]; //Slippery Feets
                        survivalCode.speed = importedData[15][8]; //3F80 default speed
                        survivalCode.voice = importedData[15][9];

                        survivalCode.weaponEffect = importedData[15][10]; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                        survivalCode.attack = importedData[15][11]; //Decrease/Increase Attack
                        survivalCode.defense = importedData[15][12]; //Decrease/Increase Defense
                        survivalCode.stealHp = importedData[15][13]; //Steal health from enemy
                        survivalCode.pierceDamage = importedData[15][14]; //Damage inflicted thru guard
                        survivalCode.weaponSize = importedData[15][15];
                        survivalCode.atkPushForce = importedData[15][16]; //Decrease/Increase Attack Pushback Force
                        survivalCode.counterRate = importedData[15][17]; //Increase Counter Chance
                        survivalCode.nullCounter = importedData[15][18]; //Nullify Enemies Counters chance
                        survivalCode.guardHpModify = importedData[15][19]; //Decrease/Increase Health while guarding enemies attacks
                        survivalCode.autoGuardImpact = importedData[15][20]; //Automatically Guard Impact some attacks
                        survivalCode.parryDamage = importedData[15][20]; //Increase Damage Received by Opponent when successfully Guard Impact
                        survivalCode.parryRegen = importedData[15][21]; //Recover Health when successfully Guard Impact
                        survivalCode.guardBreakRate = importedData[15][22]; //Increase Guard Break Chance
                        survivalCode.throwEscapeChance = importedData[15][23]; //Increase Throw Escape Rate
                        survivalCode.ringOutEscapeChance = importedData[15][24]; //Increase Ring-Out Escape Rate
                        survivalCode.hpRegenOrDrain = importedData[15][25]; //Drain/Recover Health over Time
                        survivalCode.hpRegenOrDrainOnAtk = importedData[15][26]; //Drain/Recover Health when Attacking
                        stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                        //////////////////////////////////////////////////////////////////////////////////////////////////
                        survivalCode.stageLevel = importedData[0][6];
                        survivalCode.stageMusic = importedData[0][7];
                        survivalCode.stageNumber = 16;
                        survivalCode.model = importedData[16][0];
                        survivalCode.costume = importedData[16][1];
                        survivalCode.fightingStyle = importedData[16][2];
                        survivalCode.weaponNumber = importedData[16][3];

                        survivalCode.aiLevel = importedData[16][4]; // 00-05
                        survivalCode.weaponSpecial = importedData[16][5]; //Fire, Thunder, Paralysis, Cure etc
                        survivalCode.guardianForce = importedData[16][6]; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                        survivalCode.stickyFeet = importedData[16][7]; //Slippery Feets
                        survivalCode.speed = importedData[16][8]; //3F80 default speed
                        survivalCode.voice = importedData[16][9];

                        survivalCode.weaponEffect = importedData[16][10]; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                        survivalCode.attack = importedData[16][11]; //Decrease/Increase Attack
                        survivalCode.defense = importedData[16][12]; //Decrease/Increase Defense
                        survivalCode.stealHp = importedData[16][13]; //Steal health from enemy
                        survivalCode.pierceDamage = importedData[16][14]; //Damage inflicted thru guard
                        survivalCode.weaponSize = importedData[16][15];
                        survivalCode.atkPushForce = importedData[16][16]; //Decrease/Increase Attack Pushback Force
                        survivalCode.counterRate = importedData[16][17]; //Increase Counter Chance
                        survivalCode.nullCounter = importedData[16][18]; //Nullify Enemies Counters chance
                        survivalCode.guardHpModify = importedData[16][19]; //Decrease/Increase Health while guarding enemies attacks
                        survivalCode.autoGuardImpact = importedData[16][20]; //Automatically Guard Impact some attacks
                        survivalCode.parryDamage = importedData[16][20]; //Increase Damage Received by Opponent when successfully Guard Impact
                        survivalCode.parryRegen = importedData[16][21]; //Recover Health when successfully Guard Impact
                        survivalCode.guardBreakRate = importedData[16][22]; //Increase Guard Break Chance
                        survivalCode.throwEscapeChance = importedData[16][23]; //Increase Throw Escape Rate
                        survivalCode.ringOutEscapeChance = importedData[16][24]; //Increase Ring-Out Escape Rate
                        survivalCode.hpRegenOrDrain = importedData[16][25]; //Drain/Recover Health over Time
                        survivalCode.hpRegenOrDrainOnAtk = importedData[16][26]; //Drain/Recover Health when Attacking
                        stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                        //////////////////////////////////////////////////////////////////////////////////////////////////
                        survivalCode.stageLevel = "";
                        survivalCode.stageNumber = 17;
                        survivalCode.model = importedData[17][0];
                        survivalCode.costume = importedData[17][1];
                        survivalCode.fightingStyle = importedData[17][2];
                        survivalCode.weaponNumber = importedData[17][3];

                        survivalCode.aiLevel = importedData[17][4]; // 00-05
                        survivalCode.weaponSpecial = importedData[17][5]; //Fire, Thunder, Paralysis, Cure etc
                        survivalCode.guardianForce = importedData[17][6]; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                        survivalCode.stickyFeet = importedData[17][7]; //Slippery Feets
                        survivalCode.speed = importedData[17][8]; //3F80 default speed
                        survivalCode.voice = importedData[17][9];

                        survivalCode.weaponEffect = importedData[17][10]; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                        survivalCode.attack = importedData[17][11]; //Decrease/Increase Attack
                        survivalCode.defense = importedData[17][12]; //Decrease/Increase Defense
                        survivalCode.stealHp = importedData[17][13]; //Steal health from enemy
                        survivalCode.pierceDamage = importedData[17][14]; //Damage inflicted thru guard
                        survivalCode.weaponSize = importedData[17][15];
                        survivalCode.atkPushForce = importedData[17][16]; //Decrease/Increase Attack Pushback Force
                        survivalCode.counterRate = importedData[17][17]; //Increase Counter Chance
                        survivalCode.nullCounter = importedData[17][18]; //Nullify Enemies Counters chance
                        survivalCode.guardHpModify = importedData[17][19]; //Decrease/Increase Health while guarding enemies attacks
                        survivalCode.autoGuardImpact = importedData[17][20]; //Automatically Guard Impact some attacks
                        survivalCode.parryDamage = importedData[17][20]; //Increase Damage Received by Opponent when successfully Guard Impact
                        survivalCode.parryRegen = importedData[17][21]; //Recover Health when successfully Guard Impact
                        survivalCode.guardBreakRate = importedData[17][22]; //Increase Guard Break Chance
                        survivalCode.throwEscapeChance = importedData[17][23]; //Increase Throw Escape Rate
                        survivalCode.ringOutEscapeChance = importedData[17][24]; //Increase Ring-Out Escape Rate
                        survivalCode.hpRegenOrDrain = importedData[17][25]; //Drain/Recover Health over Time
                        survivalCode.hpRegenOrDrainOnAtk = importedData[17][26]; //Drain/Recover Health when Attacking
                        stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                        //////////////////////////////////////////////////////////////////////////////////////////////////
                        survivalCode.stageLevel = "";
                        survivalCode.stageNumber = 18;
                        survivalCode.model = importedData[18][0];
                        survivalCode.costume = importedData[18][1];
                        survivalCode.fightingStyle = importedData[18][2];
                        survivalCode.weaponNumber = importedData[18][3];

                        survivalCode.aiLevel = importedData[18][4]; // 00-05
                        survivalCode.weaponSpecial = importedData[18][5]; //Fire, Thunder, Paralysis, Cure etc
                        survivalCode.guardianForce = importedData[18][6]; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                        survivalCode.stickyFeet = importedData[18][7]; //Slippery Feets
                        survivalCode.speed = importedData[18][8]; //3F80 default speed
                        survivalCode.voice = importedData[18][9];

                        survivalCode.weaponEffect = importedData[18][10]; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                        survivalCode.attack = importedData[18][11]; //Decrease/Increase Attack
                        survivalCode.defense = importedData[18][12]; //Decrease/Increase Defense
                        survivalCode.stealHp = importedData[18][13]; //Steal health from enemy
                        survivalCode.pierceDamage = importedData[18][14]; //Damage inflicted thru guard
                        survivalCode.weaponSize = importedData[18][15];
                        survivalCode.atkPushForce = importedData[18][16]; //Decrease/Increase Attack Pushback Force
                        survivalCode.counterRate = importedData[18][17]; //Increase Counter Chance
                        survivalCode.nullCounter = importedData[18][18]; //Nullify Enemies Counters chance
                        survivalCode.guardHpModify = importedData[18][19]; //Decrease/Increase Health while guarding enemies attacks
                        survivalCode.autoGuardImpact = importedData[18][20]; //Automatically Guard Impact some attacks
                        survivalCode.parryDamage = importedData[18][20]; //Increase Damage Received by Opponent when successfully Guard Impact
                        survivalCode.parryRegen = importedData[18][21]; //Recover Health when successfully Guard Impact
                        survivalCode.guardBreakRate = importedData[18][22]; //Increase Guard Break Chance
                        survivalCode.throwEscapeChance = importedData[18][23]; //Increase Throw Escape Rate
                        survivalCode.ringOutEscapeChance = importedData[18][24]; //Increase Ring-Out Escape Rate
                        survivalCode.hpRegenOrDrain = importedData[18][25]; //Drain/Recover Health over Time
                        survivalCode.hpRegenOrDrainOnAtk = importedData[18][26]; //Drain/Recover Health when Attacking
                        stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                        //////////////////////////////////////////////////////////////////////////////////////////////////
                        survivalCode.stageLevel = "";
                        survivalCode.stageNumber = 19;
                        survivalCode.model = importedData[19][0];
                        survivalCode.costume = importedData[19][1];
                        survivalCode.fightingStyle = importedData[19][2];
                        survivalCode.weaponNumber = importedData[19][3];

                        survivalCode.aiLevel = importedData[19][4]; // 00-05
                        survivalCode.weaponSpecial = importedData[19][5]; //Fire, Thunder, Paralysis, Cure etc
                        survivalCode.guardianForce = importedData[19][6]; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                        survivalCode.stickyFeet = importedData[19][7]; //Slippery Feets
                        survivalCode.speed = importedData[19][8]; //3F80 default speed
                        survivalCode.voice = importedData[19][9];

                        survivalCode.weaponEffect = importedData[19][10]; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                        survivalCode.attack = importedData[19][11]; //Decrease/Increase Attack
                        survivalCode.defense = importedData[19][12]; //Decrease/Increase Defense
                        survivalCode.stealHp = importedData[19][13]; //Steal health from enemy
                        survivalCode.pierceDamage = importedData[19][14]; //Damage inflicted thru guard
                        survivalCode.weaponSize = importedData[19][15];
                        survivalCode.atkPushForce = importedData[19][16]; //Decrease/Increase Attack Pushback Force
                        survivalCode.counterRate = importedData[19][17]; //Increase Counter Chance
                        survivalCode.nullCounter = importedData[19][18]; //Nullify Enemies Counters chance
                        survivalCode.guardHpModify = importedData[19][19]; //Decrease/Increase Health while guarding enemies attacks
                        survivalCode.autoGuardImpact = importedData[19][20]; //Automatically Guard Impact some attacks
                        survivalCode.parryDamage = importedData[19][20]; //Increase Damage Received by Opponent when successfully Guard Impact
                        survivalCode.parryRegen = importedData[19][21]; //Recover Health when successfully Guard Impact
                        survivalCode.guardBreakRate = importedData[19][22]; //Increase Guard Break Chance
                        survivalCode.throwEscapeChance = importedData[19][23]; //Increase Throw Escape Rate
                        survivalCode.ringOutEscapeChance = importedData[19][24]; //Increase Ring-Out Escape Rate
                        survivalCode.hpRegenOrDrain = importedData[19][25]; //Drain/Recover Health over Time
                        survivalCode.hpRegenOrDrainOnAtk = importedData[19][26]; //Drain/Recover Health when Attacking
                        stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);
                        //////////////////////////////////////////////////////////////////////////////////////////////////
                        survivalCode.stageLevel = "";
                        survivalCode.stageNumber = 20;
                        survivalCode.model = importedData[20][0];
                        survivalCode.costume = importedData[20][1];
                        survivalCode.fightingStyle = importedData[20][2];
                        survivalCode.weaponNumber = importedData[20][3];

                        survivalCode.aiLevel = importedData[20][4]; // 00-05
                        survivalCode.weaponSpecial = importedData[20][5]; //Fire, Thunder, Paralysis, Cure etc
                        survivalCode.guardianForce = importedData[20][6]; //Keres have 05, Will o the wisp have 04, Soul Armor custom 06
                        survivalCode.stickyFeet = importedData[20][7]; //Slippery Feets
                        survivalCode.speed = importedData[20][8]; //3F80 default speed
                        survivalCode.voice = importedData[20][9];

                        survivalCode.weaponEffect = importedData[20][10]; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
                        survivalCode.attack = importedData[20][11]; //Decrease/Increase Attack
                        survivalCode.defense = importedData[20][12]; //Decrease/Increase Defense
                        survivalCode.stealHp = importedData[20][13]; //Steal health from enemy
                        survivalCode.pierceDamage = importedData[20][14]; //Damage inflicted thru guard
                        survivalCode.weaponSize = importedData[20][15];
                        survivalCode.atkPushForce = importedData[20][16]; //Decrease/Increase Attack Pushback Force
                        survivalCode.counterRate = importedData[20][17]; //Increase Counter Chance
                        survivalCode.nullCounter = importedData[20][18]; //Nullify Enemies Counters chance
                        survivalCode.guardHpModify = importedData[20][19]; //Decrease/Increase Health while guarding enemies attacks
                        survivalCode.autoGuardImpact = importedData[20][20]; //Automatically Guard Impact some attacks
                        survivalCode.parryDamage = importedData[20][20]; //Increase Damage Received by Opponent when successfully Guard Impact
                        survivalCode.parryRegen = importedData[20][21]; //Recover Health when successfully Guard Impact
                        survivalCode.guardBreakRate = importedData[20][22]; //Increase Guard Break Chance
                        survivalCode.throwEscapeChance = importedData[20][23]; //Increase Throw Escape Rate
                        survivalCode.ringOutEscapeChance = importedData[20][24]; //Increase Ring-Out Escape Rate
                        survivalCode.hpRegenOrDrain = importedData[20][25]; //Drain/Recover Health over Time
                        survivalCode.hpRegenOrDrainOnAtk = importedData[20][26]; //Drain/Recover Health when Attacking
                        stageCode += SurvivalModeSubCodes.GetStageCode(survivalCode);

                    }
                    else
                    {
                        string notFound = "template.txt not found at:\n" + templateFile;
                    }

                    break;
                    #endregion
            }

            string timeCode = Environment.NewLine + "patch=1,EE,204ED89C,extended,000003E8 //Time Limit set to 1000 seconds" + Environment.NewLine;
            stageCode = timeCode + stageCode;

            string survivalCodeNotLite = stageCode;

            SettingsClass.LoadData();

            bool restrictP1 = !SettingsClass.UseSetCharacters;

            stageCode += Codes.NewWeapons.GetWeaponsCode(SettingsClass.UltimateWeapons, false, false);
            stageCode += Codes.CharacterSelect.GetCharacterPnachCode(true, true, restrictP1);

            File.WriteAllText(SettingsClass.codeFilePath, stageCode, Encoding.UTF8);

            if (liteMode == true)
            {
                return "ok";
            }
            else
            {
                return survivalCodeNotLite;
            }
        }

    }
}
