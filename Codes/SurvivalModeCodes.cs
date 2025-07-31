using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SC3_pnach_editor.Services;
using SC3_pnach_editor.ViewModelsClasses;
using System.IO;

namespace SC3_pnach_editor.Codes
{
    public class SurvivalModeCodes
    {
        public static void GetSurvivalCode(string survivalName)
        {
            SurvivalList survivalCode = new SurvivalList();
            List<string> survivalPnach = new List<string>();
            string stageCode = "";
            switch (survivalName)
            {
                case "Test":
                    survivalCode.stageLevel = "0D";
                    survivalCode.stageNumber = 1;
                    survivalCode.costume = "86";
                    survivalCode.model = "00";
                    survivalCode.fightingStyle = "4D";
                    survivalCode.weaponNumber = 00; //Gladiator 2 

                    survivalCode.aiLevel = "00"; // 00-05
                    survivalCode.weaponSpecial = ""; //Fire, Thunder etc
                    survivalCode.guardianForce = ""; //Keres have 05, I think Will o the wisp have 03 use that too
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
                    stageCode += GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "";
                    survivalCode.stageNumber = 2;
                    survivalCode.costume = "8C";
                    survivalCode.model = "01";
                    survivalCode.fightingStyle = "41";
                    survivalCode.weaponNumber = 00; //Fu-ma Ninja 5

                    survivalCode.aiLevel = "00"; // 0-5
                    survivalCode.weaponSpecial = ""; //Fire, Thunder etc
                    survivalCode.guardianForce = ""; //Keres have 05, I think Will o the wisp have 03 use that too
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
                    stageCode += GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "";
                    survivalCode.stageNumber = 3;
                    survivalCode.costume = "97";
                    survivalCode.model = "00";
                    survivalCode.fightingStyle = "47";
                    survivalCode.weaponNumber = 00; //Sentry

                    survivalCode.aiLevel = "00"; // 0-5
                    survivalCode.weaponSpecial = ""; //Fire, Thunder etc
                    survivalCode.guardianForce = ""; //Keres have 05, I think Will o the wisp have 03 use that too
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
                    stageCode += GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "";
                    survivalCode.stageNumber = 4;
                    survivalCode.costume = "B3";
                    survivalCode.model = "02";
                    survivalCode.fightingStyle = "4B";
                    survivalCode.weaponNumber = 00; //Aika

                    survivalCode.aiLevel = "00"; // 0-5
                    survivalCode.weaponSpecial = ""; //Fire, Thunder etc
                    survivalCode.guardianForce = ""; //Keres have 05, I think Will o the wisp have 03 use that too
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
                    stageCode += GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "";
                    survivalCode.stageNumber = 5;
                    survivalCode.costume = "AA";
                    survivalCode.model = "00";
                    survivalCode.fightingStyle = "46";
                    survivalCode.weaponNumber = 00; //Ignis

                    survivalCode.aiLevel = "00"; // 0-5
                    survivalCode.weaponSpecial = ""; //Fire, Thunder etc
                    survivalCode.guardianForce = ""; //Keres have 05, I think Will o the wisp have 03 use that too
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
                    stageCode += GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "01";
                    survivalCode.stageNumber = 6;
                    survivalCode.costume = "54";
                    survivalCode.model = "01";
                    survivalCode.fightingStyle = "54";
                    survivalCode.weaponNumber = 00; //Revenant

                    survivalCode.aiLevel = "00"; // 0-5
                    survivalCode.weaponSpecial = ""; //Fire, Thunder etc
                    survivalCode.guardianForce = ""; //Keres have 05, I think Will o the wisp have 03 use that too
                    survivalCode.stickyFeet = "no"; //Slippery Feets ; no means will trip
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
                    stageCode += GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "";
                    survivalCode.stageNumber = 7;
                    survivalCode.costume = "4A";
                    survivalCode.model = "01";
                    survivalCode.fightingStyle = "4A";
                    survivalCode.weaponNumber = 00; //Demuth

                    survivalCode.aiLevel = "00"; // 0-5
                    survivalCode.weaponSpecial = ""; //Fire, Thunder etc
                    survivalCode.guardianForce = ""; //Keres have 05, I think Will o the wisp have 03 use that too
                    survivalCode.stickyFeet = "no"; //Slippery Feets ; no means will trip
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
                    stageCode += GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "";
                    survivalCode.stageNumber = 8;
                    survivalCode.costume = "84";
                    survivalCode.model = "02";
                    survivalCode.fightingStyle = "43";
                    survivalCode.weaponNumber = 00; //Samurai 3

                    survivalCode.aiLevel = "00"; // 0-5
                    survivalCode.weaponSpecial = ""; //Fire, Thunder etc
                    survivalCode.guardianForce = ""; //Keres have 05, I think Will o the wisp have 03 use that too
                    survivalCode.stickyFeet = "no"; //Slippery Feets ; no means will trip
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
                    stageCode += GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "";
                    survivalCode.stageNumber = 9;
                    survivalCode.costume = "A2";
                    survivalCode.model = "01";
                    survivalCode.fightingStyle = "42";
                    survivalCode.weaponNumber = 00; //Saizou

                    survivalCode.aiLevel = "00"; // 0-5
                    survivalCode.weaponSpecial = ""; //Fire, Thunder etc
                    survivalCode.guardianForce = ""; //Keres have 05, I think Will o the wisp have 03 use that too
                    survivalCode.stickyFeet = "no"; //Slippery Feets ; no means will trip
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
                    stageCode += GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "";
                    survivalCode.stageNumber = 10;
                    survivalCode.costume = "B8";
                    survivalCode.model = "02";
                    survivalCode.fightingStyle = "4E";
                    survivalCode.weaponNumber = 00; //Feofan

                    survivalCode.aiLevel = "00"; // 0-5
                    survivalCode.weaponSpecial = ""; //Fire, Thunder etc
                    survivalCode.guardianForce = ""; //Keres have 05, I think Will o the wisp have 03 use that too
                    survivalCode.stickyFeet = "no"; //Slippery Feets ; no means will trip
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
                    stageCode += GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "16";
                    survivalCode.stageNumber = 11;
                    survivalCode.costume = "1E";
                    survivalCode.model = "00";
                    survivalCode.fightingStyle = "0E";
                    survivalCode.weaponNumber = 06; //Lizard Men

                    survivalCode.aiLevel = "00"; // 0-5
                    survivalCode.weaponSpecial = ""; //Fire, Thunder etc
                    survivalCode.guardianForce = ""; //Keres have 05, I think Will o the wisp have 03 use that too
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
                    stageCode += GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "";
                    survivalCode.stageNumber = 12;
                    survivalCode.costume = "18";
                    survivalCode.model = "09";
                    survivalCode.fightingStyle = "18";
                    survivalCode.weaponNumber = 06; //Yun-Seong

                    survivalCode.aiLevel = "00"; // 0-5
                    survivalCode.weaponSpecial = ""; //Fire, Thunder etc
                    survivalCode.guardianForce = ""; //Keres have 05, I think Will o the wisp have 03 use that too
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
                    stageCode += GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "";
                    survivalCode.stageNumber = 13;
                    survivalCode.costume = "0F";
                    survivalCode.model = "09";
                    survivalCode.fightingStyle = "0F";
                    survivalCode.weaponNumber = 06; //Yoshimitsu

                    survivalCode.aiLevel = "00"; // 0-5
                    survivalCode.weaponSpecial = ""; //Fire, Thunder etc
                    survivalCode.guardianForce = ""; //Keres have 05, I think Will o the wisp have 03 use that too
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
                    stageCode += GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "";
                    survivalCode.stageNumber = 14;
                    survivalCode.costume = "08";
                    survivalCode.model = "09";
                    survivalCode.fightingStyle = "08";
                    survivalCode.weaponNumber = 06; //Rock

                    survivalCode.aiLevel = "00"; // 0-5
                    survivalCode.weaponSpecial = ""; //Fire, Thunder etc
                    survivalCode.guardianForce = ""; //Keres have 05, I think Will o the wisp have 03 use that too
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
                    stageCode += GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "";
                    survivalCode.stageNumber = 15;
                    survivalCode.costume = "11";
                    survivalCode.model = "09";
                    survivalCode.fightingStyle = "11";
                    survivalCode.weaponNumber = 06; //Nightmare

                    survivalCode.aiLevel = "00"; // 0-5
                    survivalCode.weaponSpecial = ""; //Fire, Thunder etc
                    survivalCode.guardianForce = ""; //Keres have 05, I think Will o the wisp have 03 use that too
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
                    stageCode += GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "10";
                    survivalCode.stageNumber = 16;
                    survivalCode.costume = "16";
                    survivalCode.model = "09";
                    survivalCode.fightingStyle = "16";
                    survivalCode.weaponNumber = 06; //Talim

                    survivalCode.aiLevel = "00"; // 0-5
                    survivalCode.weaponSpecial = ""; //Fire, Thunder etc
                    survivalCode.guardianForce = ""; //Keres have 05, I think Will o the wisp have 03 use that too
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
                    stageCode += GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "";
                    survivalCode.stageNumber = 17;
                    survivalCode.costume = "35";
                    survivalCode.model = "00";
                    survivalCode.fightingStyle = "24";
                    survivalCode.weaponNumber = 06; //Zasalamel

                    survivalCode.aiLevel = "00"; // 0-5
                    survivalCode.weaponSpecial = ""; //Fire, Thunder etc
                    survivalCode.guardianForce = ""; //Keres have 05, I think Will o the wisp have 03 use that too
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
                    stageCode += GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "";
                    survivalCode.stageNumber = 18;
                    survivalCode.costume = "25";
                    survivalCode.model = "09";
                    survivalCode.fightingStyle = "?s";
                    survivalCode.weaponNumber = 06; //Olcadan

                    survivalCode.aiLevel = "00"; // 0-5
                    survivalCode.weaponSpecial = ""; //Fire, Thunder etc
                    survivalCode.guardianForce = ""; //Keres have 05, I think Will o the wisp have 03 use that too
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
                    stageCode += GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "";
                    survivalCode.stageNumber = 19;
                    survivalCode.costume = "07";
                    survivalCode.model = "09";
                    survivalCode.fightingStyle = "07";
                    survivalCode.weaponNumber = 06; //Siegfried

                    survivalCode.aiLevel = "00"; // 0-5
                    survivalCode.weaponSpecial = ""; //Fire, Thunder etc
                    survivalCode.guardianForce = ""; //Keres have 05, I think Will o the wisp have 03 use that too
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
                    stageCode += GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "";
                    survivalCode.stageNumber = 20;
                    survivalCode.costume = "81";
                    survivalCode.model = "00";
                    survivalCode.fightingStyle = "48";
                    survivalCode.weaponNumber = 01; //Berserker

                    survivalCode.aiLevel = "00"; // 0-5
                    survivalCode.weaponSpecial = ""; //Fire, Thunder etc
                    survivalCode.guardianForce = ""; //Keres have 05, I think Will o the wisp have 03 use that too
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
                    stageCode += GetStageCode(survivalCode);
                    break;
                case "Test2":
                    survivalCode.stageLevel = "";
                    survivalCode.stageNumber = 1;
                    survivalCode.costume = "A4";
                    survivalCode.model = "03";
                    survivalCode.fightingStyle = "43";
                    survivalCode.weaponNumber = 00; //Grandall M

                    survivalCode.aiLevel = "00"; // 00-05
                    survivalCode.weaponSpecial = ""; //Fire, Thunder etc
                    survivalCode.guardianForce = ""; //Keres have 05, I think Will o the wisp have 03 use that too
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
                    stageCode += GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "";
                    survivalCode.stageNumber = 2;
                    survivalCode.costume = "C1";
                    survivalCode.model = "01";
                    survivalCode.fightingStyle = "30";
                    survivalCode.weaponNumber = 00; //Eris

                    survivalCode.aiLevel = "00"; // 00-05
                    survivalCode.weaponSpecial = ""; //Fire, Thunder etc
                    survivalCode.guardianForce = ""; //Keres have 05, I think Will o the wisp have 03 use that too
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
                    stageCode += GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "";
                    survivalCode.stageNumber = 3;
                    survivalCode.costume = "96";
                    survivalCode.model = "00";
                    survivalCode.fightingStyle = "4D";
                    survivalCode.weaponNumber = 00; //General

                    survivalCode.aiLevel = "00"; // 00-05
                    survivalCode.weaponSpecial = ""; //Fire, Thunder etc
                    survivalCode.guardianForce = ""; //Keres have 05, I think Will o the wisp have 03 use that too
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
                    stageCode += GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "";
                    survivalCode.stageNumber = 4;
                    survivalCode.costume = "90";
                    survivalCode.model = "00";
                    survivalCode.fightingStyle = "4C";
                    survivalCode.weaponNumber = 00; //Thief 2

                    survivalCode.aiLevel = "00"; // 00-05
                    survivalCode.weaponSpecial = ""; //Fire, Thunder etc
                    survivalCode.guardianForce = ""; //Keres have 05, I think Will o the wisp have 03 use that too
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
                    stageCode += GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "";
                    survivalCode.stageNumber = 5;
                    survivalCode.costume = "AF";
                    survivalCode.model = "02";
                    survivalCode.fightingStyle = "48";
                    survivalCode.weaponNumber = 00; //Brunhild

                    survivalCode.aiLevel = "01"; // 00-05
                    survivalCode.weaponSpecial = ""; //Fire, Thunder etc
                    survivalCode.guardianForce = ""; //Keres have 05, I think Will o the wisp have 03 use that too
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
                    stageCode += GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "";
                    survivalCode.stageNumber = 6;
                    survivalCode.costume = "ED";
                    survivalCode.model = "00";
                    survivalCode.fightingStyle = "4E";
                    survivalCode.weaponNumber = 00; //Hyle

                    survivalCode.aiLevel = "01"; // 00-05
                    survivalCode.weaponSpecial = ""; //Fire, Thunder etc
                    survivalCode.guardianForce = ""; //Keres have 05, I think Will o the wisp have 03 use that too
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
                    stageCode += GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "";
                    survivalCode.stageNumber = 7;
                    survivalCode.costume = "E4";
                    survivalCode.model = "00";
                    survivalCode.fightingStyle = "4C";
                    survivalCode.weaponNumber = 00; //Chester

                    survivalCode.aiLevel = "01"; // 00-05
                    survivalCode.weaponSpecial = ""; //Fire, Thunder etc
                    survivalCode.guardianForce = ""; //Keres have 05, I think Will o the wisp have 03 use that too
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
                    stageCode += GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "";
                    survivalCode.stageNumber = 8;
                    survivalCode.costume = "46";
                    survivalCode.model = "01";
                    survivalCode.fightingStyle = "46";
                    survivalCode.weaponNumber = 00; //Valeria

                    survivalCode.aiLevel = "01"; // 00-05
                    survivalCode.weaponSpecial = ""; //Fire, Thunder etc
                    survivalCode.guardianForce = ""; //Keres have 05, I think Will o the wisp have 03 use that too
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
                    stageCode += GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "";
                    survivalCode.stageNumber = 9;
                    survivalCode.costume = "8A";
                    survivalCode.model = "00";
                    survivalCode.fightingStyle = "42";
                    survivalCode.weaponNumber = 00; //Fu-ma Ninja 1

                    survivalCode.aiLevel = "01"; // 00-05
                    survivalCode.weaponSpecial = ""; //Fire, Thunder etc
                    survivalCode.guardianForce = ""; //Keres have 05, I think Will o the wisp have 03 use that too
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
                    stageCode += GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "";
                    survivalCode.stageNumber = 10;
                    survivalCode.costume = "A0";
                    survivalCode.model = "00";
                    survivalCode.fightingStyle = "41";
                    survivalCode.weaponNumber = 00; //Jinkai

                    survivalCode.aiLevel = "01"; // 00-05
                    survivalCode.weaponSpecial = ""; //Fire, Thunder etc
                    survivalCode.guardianForce = ""; //Keres have 05, I think Will o the wisp have 03 use that too
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
                    stageCode += GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "";
                    survivalCode.stageNumber = 11;
                    survivalCode.costume = "22";
                    survivalCode.model = "08";
                    survivalCode.fightingStyle = "22";
                    survivalCode.weaponNumber = 00; //Setsuka

                    survivalCode.aiLevel = "01"; // 00-05
                    survivalCode.weaponSpecial = ""; //Fire, Thunder etc
                    survivalCode.guardianForce = ""; //Keres have 05, I think Will o the wisp have 03 use that too
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
                    stageCode += GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "";
                    survivalCode.stageNumber = 12;
                    survivalCode.costume = "04";
                    survivalCode.model = "08";
                    survivalCode.fightingStyle = "04";
                    survivalCode.weaponNumber = 00; //Maxi

                    survivalCode.aiLevel = "01"; // 00-05
                    survivalCode.weaponSpecial = ""; //Fire, Thunder etc
                    survivalCode.guardianForce = ""; //Keres have 05, I think Will o the wisp have 03 use that too
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
                    stageCode += GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "";
                    survivalCode.stageNumber = 13;
                    survivalCode.costume = "36";
                    survivalCode.model = "00";
                    survivalCode.fightingStyle = "0E";
                    survivalCode.weaponNumber = 00; //Lizardman

                    survivalCode.aiLevel = "01"; // 00-05
                    survivalCode.weaponSpecial = ""; //Fire, Thunder etc
                    survivalCode.guardianForce = ""; //Keres have 05, I think Will o the wisp have 03 use that too
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
                    stageCode += GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "";
                    survivalCode.stageNumber = 14;
                    survivalCode.costume = "84";
                    survivalCode.model = "00";
                    survivalCode.fightingStyle = "43";
                    survivalCode.weaponNumber = 00; //Samurai 1

                    survivalCode.aiLevel = "01"; // 00-05
                    survivalCode.weaponSpecial = ""; //Fire, Thunder etc
                    survivalCode.guardianForce = ""; //Keres have 05, I think Will o the wisp have 03 use that too
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
                    stageCode += GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "";
                    survivalCode.stageNumber = 15;
                    survivalCode.costume = "B7";
                    survivalCode.model = "01";
                    survivalCode.fightingStyle = "4D";
                    survivalCode.weaponNumber = 00; //Eurydice

                    survivalCode.aiLevel = "01"; // 00-05
                    survivalCode.weaponSpecial = ""; //Fire, Thunder etc
                    survivalCode.guardianForce = ""; //Keres have 05, I think Will o the wisp have 03 use that too
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
                    stageCode += GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "";
                    survivalCode.stageNumber = 16;
                    survivalCode.costume = "01";
                    survivalCode.model = "08";
                    survivalCode.fightingStyle = "01";
                    survivalCode.weaponNumber = 00; //Mitsurugi

                    survivalCode.aiLevel = "01"; // 00-05
                    survivalCode.weaponSpecial = ""; //Fire, Thunder etc
                    survivalCode.guardianForce = ""; //Keres have 05, I think Will o the wisp have 03 use that too
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
                    stageCode += GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "";
                    survivalCode.stageNumber = 17;
                    survivalCode.costume = "06";
                    survivalCode.model = "08";
                    survivalCode.fightingStyle = "06";
                    survivalCode.weaponNumber = 00; //Sophitia

                    survivalCode.aiLevel = "01"; // 00-05
                    survivalCode.weaponSpecial = ""; //Fire, Thunder etc
                    survivalCode.guardianForce = ""; //Keres have 05, I think Will o the wisp have 03 use that too
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
                    stageCode += GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "";
                    survivalCode.stageNumber = 18;
                    survivalCode.costume = "89";
                    survivalCode.model = "00";
                    survivalCode.fightingStyle = "43";
                    survivalCode.weaponNumber = 00; //Unknown Soul

                    survivalCode.aiLevel = "01"; // 00-05
                    survivalCode.weaponSpecial = ""; //Fire, Thunder etc
                    survivalCode.guardianForce = ""; //Keres have 05, I think Will o the wisp have 03 use that too
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
                    stageCode += GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "";
                    survivalCode.stageNumber = 19;
                    survivalCode.costume = "14";
                    survivalCode.model = "01";
                    survivalCode.fightingStyle = "14";
                    survivalCode.weaponNumber = 00; //Cervantes

                    survivalCode.aiLevel = "01"; // 00-05
                    survivalCode.weaponSpecial = ""; //Fire, Thunder etc
                    survivalCode.guardianForce = ""; //Keres have 05, I think Will o the wisp have 03 use that too
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
                    stageCode += GetStageCode(survivalCode);
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    survivalCode.stageLevel = "";
                    survivalCode.stageNumber = 20;
                    survivalCode.costume = "99";
                    survivalCode.model = "00";
                    survivalCode.fightingStyle = "44";
                    survivalCode.weaponNumber = 00; //Dragon

                    survivalCode.aiLevel = "01"; // 00-05
                    survivalCode.weaponSpecial = ""; //Fire, Thunder etc
                    survivalCode.guardianForce = ""; //Keres have 05, I think Will o the wisp have 03 use that too
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
                    stageCode += GetStageCode(survivalCode);

                    break;
            }

            SettingsClass.LoadData();
            stageCode += Codes.NewWeapons.GetWeaponsCode(SettingsClass.UltimateWeapons, false, false);
            stageCode += Codes.CharacterSelect.GetCharacterPnachCode(true);

            File.WriteAllText(SettingsClass.codeFilePath, stageCode, Encoding.UTF8);
        }

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
                stageLevelValue = "patch=1,EE,004ED64C,extended,000000" + survivalCode.stageLevel + " //Stage code";
                stageLevelValue = stageNumberValue + Environment.NewLine + stageLevelValue + Environment.NewLine;
            }

            string charPiece1 = "patch=1,EE,204D1FE0,extended,00" + survivalCode.fightingStyle + "00" + survivalCode.model + " // fighting style + model";
            charPiece1 = stageNumberValue + Environment.NewLine + charPiece1 + Environment.NewLine;
            string charPiece2 = "patch=1,EE,204D1FE4,extended,00" + survivalCode.fightingStyle + "00" + survivalCode.fightingStyle + " // fighting style";
            charPiece2 = stageNumberValue + Environment.NewLine + charPiece2 + Environment.NewLine;
            string charPiece3 = "patch=1,EE,204D1FE8,extended,000100" + survivalCode.fightingStyle + " // type + fighting style";
            charPiece3 = stageNumberValue + Environment.NewLine + charPiece3 + Environment.NewLine;
            string charPiece4 = "patch=1,EE,204D1FEC,extended,00" + survivalCode.costume + "00" + survivalCode.model + " // costume + model";
            charPiece4 = stageNumberValue + Environment.NewLine + charPiece4 + Environment.NewLine;
            string charPiece5 = "patch=1,EE,004D2016,extended," + survivalCode.weaponNumber + " //Selected Weapon";
            charPiece5 = stageNumberValue + Environment.NewLine + charPiece5 + Environment.NewLine;

            string specPiece1 = "";
            if (survivalCode.aiLevel != "")
            {
                specPiece1 = "patch=1,EE,10520D54,extended,00" + survivalCode.aiLevel + " //opponent AI";
                specPiece1 = stageNumberValue + Environment.NewLine + specPiece1 + Environment.NewLine;
            }

            string specPiece2 = "";
            switch (survivalCode.weaponSpecial)
            {
                case "All Guard Break":
                    specPiece2 =
                    "patch=1,EE,104ED9CA,extended,0001 //Enable weapon effects [Shared]" + Environment.NewLine +
                    "patch=1,EE,1053CE1C,extended,0002 //Thunder Effect P2" + Environment.NewLine +
                    "patch=1,EE,1053CF20,extended,0001 //Thunder Gfx P2" + Environment.NewLine +
                    "patch=1,EE,2053CD40,extended,00010002 //Thunder Effect + Gfx P2 [Shared]" + Environment.NewLine +
                    "";
                    break;
                case "All Unblockable":
                    specPiece2 =
                    "patch=1,EE,104ED9CA,extended,0001 //Enable weapon effects [Shared]" + Environment.NewLine +
                    "patch=1,EE,1053CE18,extended,0002 //Fire Effect P2" + Environment.NewLine +
                    "patch=1,EE,1053CFB0,extended,0001 //Fire Gfx P2" + Environment.NewLine +
                    "patch=1,EE,2053CD40,extended,00010002 //Fire Effect + Gfx P2 [Shared]" + Environment.NewLine +
                    "";
                    break;
                case "Paralysis":
                    specPiece2 =
                    "patch=1,EE,104ED9CA,extended,0001 //Enable weapon effects [Shared]" + Environment.NewLine +
                    "patch=1,EE,1053CE14,extended,0001 //Paralysis Effect P2" + Environment.NewLine +
                    "patch=1,EE,1053CFAC,extended,0002 //Paralysis Gfx P2" + Environment.NewLine +
                    "patch=1,EE,2053CD40,extended,00020001 //Paralysis Effect + Gfx P2 [Shared]" + Environment.NewLine +
                    "";
                    break;
                case "Down Lose":
                    specPiece2 =
                    "patch=1,EE,104ED9CA,extended,0001 //Enable weapon effects [Shared]" + Environment.NewLine +
                    "patch=1,EE,1053CF34,extended,0007 //Down Lose Effect P2" + Environment.NewLine +
                    "patch=1,EE,2053CD40,extended,00010000 //Down Lose Effect P1 & P2 [Shared]" + Environment.NewLine +
                    "";
                    break;
                case "Cure":
                    specPiece2 = 
                    "patch=1,EE,104D23EE,extended,3D80 // Change Weapon Heal Stat" + Environment.NewLine +
                    "patch=1,EE,104ED9CA,extended,0001 // Enable weapon effects [Shared]" + Environment.NewLine +
                    "patch=1,EE,1053CF48,extended,0001 // Cure Gfx P2" + Environment.NewLine +
                    "patch=1,EE,2053CD40,extended,00010000 // P2 Cure" + Environment.NewLine +
                    "";
                    break;
                case "Poison":
                    specPiece2 = 
                    "patch=1,EE,104D23EE,extended,BD80 // Change Weapon Damage Stat P2" + Environment.NewLine +
                    "patch=1,EE,104ED9CA,extended,0001 // Enable weapon effects [Shared]" + Environment.NewLine +
                    "patch=1,EE,1053CFCC,extended,0001 // Poison Gfx P2" + Environment.NewLine +
                    "patch=1,EE,2053CD40,extended,00030000 // P2 Poison" + Environment.NewLine +
                    "";
                    break;
            }
            if (specPiece2 != "")
            {
                specPiece2 = stageNumberValue + Environment.NewLine + specPiece2 + Environment.NewLine;
            }

            string specPiece3 = "";
            if (survivalCode.guardianForce != "")
            {
                specPiece3 = "patch=1,EE,204D2274,extended,000200" + survivalCode.guardianForce + " //Guardian Force";
                specPiece3 = stageNumberValue + Environment.NewLine + specPiece3 + Environment.NewLine;
            }

            string specPiece4 = "";
            if (survivalCode.stickyFeet != "")
            {
                specPiece4 = 
                "patch=1,EE,1053CD42,extended,0007 //Slippery Feets Player 2" + Environment.NewLine +
                "patch=1,EE,1053CED8,extended,0001 //Can Fall Of The Ring Player 2" + Environment.NewLine +
                "patch=1,EE,1053CEE4,extended,0001 //Slippery Feets Player 2";
                specPiece4 = stageNumberValue + Environment.NewLine + specPiece4 + Environment.NewLine;
            }

            string specPiece5 = "";
            if (survivalCode.speed != "")
            {
                string speedCodePiece1 = "patch=1,EE,200FFD0C,extended,3C01" + survivalCode.speed + "//P2";
                string speedCodePiece2 = "patch=1,EE,200FFD10,extended,3C04004D//P2";
                string speedCodePiece3 = "patch=1,EE,200FFD14,extended,AC8136D0//P2";
                string speedCodePiece4 = "patch=1,EE,200FFD18,extended,0260202D//BOTH";
                string speedCodePiece5 = "patch=1,EE,200FFD1C,extended,0806CDD1//BOTH";
                string speedCodePiece6 = "patch=1,EE,201B3740,extended,0803FF40//BOTH";

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
                wpnPiece6 = "patch=1,EE,204D23C0,extended," + survivalCode.weaponSize + " //Steal health from enemy";
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

    }
}
