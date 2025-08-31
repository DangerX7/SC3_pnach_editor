using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SC3_pnach_editor.ViewModelsClasses
{
    public class SurvivalList
    {
        public string stageLevel = "";
        public string stageMusic = "";
        public int stageNumber = 0;
        public string fightingStyle = "";
        public string model = "";
        public string costume = "";
        public string weaponNumber = "";

        public string aiLevel = "";
        public string weaponSpecial = ""; //Fire, Thunder etc
        public string guardianForce = ""; //Keres
        public string stickyFeet = ""; //Slippery Feets
        public string speed = "";

        public string weaponEffect = ""; //0 = Nothing, 1 = Increase attack over time, 2 = Guard Impact becomes easier to perform
        public string attack = ""; //Decrease/Increase Attack
        public string defense = ""; //Decrease/Increase Defense
        public string stealHp = ""; //Steal health from enemy
        public string pierceDamage = ""; //Damage inflicted thru guard
        public string weaponSize = "";
        public string atkPushForce = ""; //Decrease/Increase Attack Pushback Force
        public string counterRate = ""; //Increase Counter Chance
        public string nullCounter = ""; //Nullify Enemies Counters chance
        public string guardHpModify = ""; //Decrease/Increase Health while guarding enemies attacks
        public string autoGuardImpact = ""; //Automatically Guard Impact some attacks
        public string parryDamage = ""; //Increase Damage Received by Opponent when successfully Guard Impact
        public string parryRegen = ""; //Recover Health when successfully Guard Impact
        public string guardBreakRate = ""; //Increase Guard Break Chance
        public string throwEscapeChance = ""; //Increase Throw Escape Rate
        public string ringOutEscapeChance = ""; //Increase Ring-Out Escape Rate
        public string hpRegenOrDrain = ""; //Drain/Recover Health over Time
        public string hpRegenOrDrainOnAtk = ""; //Drain/Recover Health when Attacking

        public string? voice = null;
        public string? specialData = null;
    }
}
