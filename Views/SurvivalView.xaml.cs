using Microsoft.EntityFrameworkCore.Metadata.Internal;
using NAudio.CoreAudioApi;
using NAudio.Gui;
using NAudio.Wave;
using OfficeOpenXml;
using SC3_pnach_editor.Codes;
using SC3_pnach_editor.Services;
using SC3_pnach_editor.ViewModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Navigation;
using System.Windows.Shapes;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace SC3_pnach_editor.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class SurvivalView : UserControl
    {
        SurvivalViewModel viewModel;
        public SurvivalView()
        {

            InitializeComponent();

            viewModel = new();

            this.DataContext = viewModel;


            SettingsClass.LoadData();


            if (SettingsClass.SoundOn)
            {
                string soundPath = System.IO.Path.Combine(Directory.GetParent(SettingsClass.SurvivalPath)!.FullName,
                    @"Extras\Lorekeeper.mp3");
                customSound.Source = new Uri(soundPath);
                customSound.Volume = 0.1;
            }

        }

        private void GoToMainPage_Click(object sender, RoutedEventArgs e)
        {
            viewModel.DisplayMainView();
        }

        private void TrainingArcSurvival_Click(object sender, RoutedEventArgs e)
        {
            string modeName = "Training Arc";
            GenerateCode(modeName);
        }

        private void AmateurArcSurvival_Click(object sender, RoutedEventArgs e)
        {
            string modeName = "Amateur Arc";
            GenerateCode(modeName);
        }

        private void IntermediateArcSurvival_Click(object sender, RoutedEventArgs e)
        {
            string modeName = "Intermediate Arc";
            GenerateCode(modeName);
        }

        private void AdvancedArcSurvival_Click(object sender, RoutedEventArgs e)
        {
            string modeName = "Advanced Arc";
            GenerateCode(modeName);
        }

        private void ExpertArcSurvival_Click(object sender, RoutedEventArgs e)
        {
            string modeName = "Expert Arc";
            GenerateCode(modeName);
        }

        private void MasterArcSurvival_Click(object sender, RoutedEventArgs e)
        {
            string modeName = "Master Arc";
            GenerateCode(modeName);
        }

        private void ChampionArcSurvival_Click(object sender, RoutedEventArgs e)
        {
            string modeName = "Champion Arc";
            GenerateCode(modeName);
        }

        private void LegendaryArcSurvival_Click(object sender, RoutedEventArgs e)
        {
            string modeName = "Legendary Arc";
            GenerateCode(modeName);
        }

        private void GodArcSurvival_Click(object sender, RoutedEventArgs e)
        {
            string modeName = "God Arc";
            GenerateCode(modeName);
        }

        private void SpecialArcSurvival_Click(object sender, RoutedEventArgs e)
        {
            string modeName = "Special Arc";
            GenerateCode(modeName);
        }
        private void MysteriousArcSurvival_Click(object sender, RoutedEventArgs e)
        {
            string modeName = "Mysterious Arc";
            GenerateCode(modeName);
        }

        private void BonusArcSurvival_Click(object sender, RoutedEventArgs e)
        {
            string modeName = "Bonus Arc";
            GenerateCode(modeName);
        }
        private void CustomArcSurvival_Click(object sender, RoutedEventArgs e)
        {
            string modeName = "Custom Arc";
            GenerateCode(modeName);
        }
        public void GenerateCode(string modeName)
        {
            SurvivalModeCodes.GetSurvivalCode(modeName, true);
            SettingsClass.SelectedSurvivalMode = modeName;
            SettingsClass.SaveData();
            viewModel.CodeInformation = "Mode " + modeName + " was activated succesfully";
        }

        private void TrainingArcSurvival_MouseEnter(object sender, MouseEventArgs e)
        {
            viewModel.ModeInformation = "-----Training Arc-----\n" +
                "\n" +
                "Welcome to the starting grounds.\n" +
                "Every enemy here is weakened and barely poses a threat,\n" +
                "with the simplest AI behavior imaginable.\n" +
                "It’s more target practice than combat,\n" +
                "the perfect place to learn the ropes\n" +
                "and sharpen your reflexes without fear.\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "Soul Arena - Mission - Survival (Easy)\n" +
                "\n" +
                "Difficulty ★\n";
        }
           
        private void AmateurArcSurvival_MouseEnter(object sender, MouseEventArgs e)
        {
            viewModel.ModeInformation = "-----Amateur Arc-----\n" +
                "\n" +
                "The first few waves use simple AI,\n" +
                "but the rest fight with improved tactics.\n" +
                "No nerfs this time,\n" +
                "just a gradually rising challenge.\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "Soul Arena - Mission - Survival (Easy)\n" +
                "\n" +
                "Difficulty ★★\n";
        }

        private void IntermediateArcSurvival_MouseEnter(object sender, MouseEventArgs e)
        {
            viewModel.ModeInformation = "-----Intermediate Arc-----\n" +
                "\n" +
                "Enemies now fight with slightly improved AI and begin using better weapons.\n" +
                "A good pick for a balanced challenge.\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "Soul Arena - Mission - Survival (Easy)\n" +
                "\n" +
                "Difficulty ★★★\n";
             
        }

        private void AdvancedArcSurvival_MouseEnter(object sender, MouseEventArgs e)
        {
            viewModel.ModeInformation = "-----Advanced Arc-----\n" +
                "\n" +
                "Enemies use tougher AI and slightly improved weapons.\n" +
                "Modifiers apear more often this time making things harder.\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "Soul Arena - Mission - Survival (Easy)\n" +
                "\n" +
                "Difficulty ★★★★\n";
        }

        private void ExpertArcSurvival_MouseEnter(object sender, MouseEventArgs e)
        {
            viewModel.ModeInformation = "-----Expert Arc-----\n" +
                "\n" +
                "Enemies start to get a small speed boost and use more effects from Chronicles of the Sword.\n" +
                "Get ready.\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "Soul Arena - Mission - Survival (Easy)\n" +
                "\n" +
                "Difficulty ★★★★★\n";
        }

        private void MasterArcSurvival_MouseEnter(object sender, MouseEventArgs e)
        {
            viewModel.ModeInformation = "-----Master Arc-----\n" +
                "\n" +
                "The AI is much more skilled this time, and enemies start using overpowered effects like Fire Weapon and Guardian Force.\n" +
                "Watch out!\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "Soul Arena - Mission - Survival (Easy)\n" +
                "\n" +
                "Difficulty ★★★★★★\n";
        }

        private void ChampionArcSurvival_MouseEnter(object sender, MouseEventArgs e)
        {
            viewModel.ModeInformation = "-----Champion Arc-----\n" +
                "\n" +
                "Most enemies will use either the best weapon in the game and pretty good modifiers.\n" +
                "Let's not forget the best AI in the game.\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "Soul Arena - Mission - Survival (Easy)\n" +
                "\n" +
                "Difficulty ★★★★★★★\n";
        }

        private void LegendaryArcSurvival_MouseEnter(object sender, MouseEventArgs e)
        {
            viewModel.ModeInformation = "-----Legendary Arc-----\n" +
                "\n" +
                "The best challenge available—enemies use legendary weapons, a decent speed boost, and great modifiers.\n" +
                "Are you ready for the final challenge?\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "Note: you must have ultimate weapons activated in order for this to work properly.\n" +
                "\n" +
                "\n" +
                "\n" +
                "Soul Arena - Mission - Survival (Easy)\n" +
                "\n" +
                "Difficulty ★★★★★★★★\n";
        }

        private void GodArcSurvival_MouseEnter(object sender, MouseEventArgs e)
        {
            viewModel.ModeInformation = "-----God Arc-----\n" +
                "\n" +
                "You didn’t have enough, did you? You really want more, huh? Well, get ready for hell—this is the most unfair challenge ever.\n" +
                "Enemies come with insanely overpowered modifiers: Guardian Force, Fire Weapons, massive speed boosts, HP regeneration, and more.\n" +
                "All the game’s bosses and overpowered NPCs show up here.\n" +
                "Either bring an OP character yourself, or get ready to bite the dust. Let’s see how far you can make it in this nightmare.\n" +
                "\n" +
                "Soul Arena - Mission - Survival (Easy)\n" +
                "\n" +
                "Difficulty ★★★★★★★★★★\n";
        }

        private void SpecialArcSurvival_MouseEnter(object sender, MouseEventArgs e)
        {
            viewModel.ModeInformation = "-----Special Arc-----\n" +
                "\n" +
                "This is a special challenge featuring characters I handpicked—mostly allied units from Chronicles of the Sword.\n" +
                "The modifiers are light, but don’t let that fool you—the AI is at its hardest.\n" +
                "\n" +
                "\n" +
                "Note: In order for this to work, you must have a created character in the first slot on MC1.\n" +
                "\n" +
                "\n" +
                "\n" +
                "Soul Arena - Mission - Survival (Easy)\n" +
                "\n" +
                "Difficulty ★★★★★★★\n";
        }
        private void MysteriousArcSurvival_MouseEnter(object sender, MouseEventArgs e)
        {
            viewModel.ModeInformation = "-----Mysterious Arc-----\n" +
                "\n" +
                "Enemies and modifiers are completely random.\n" +
                "The AI difficulty will match the one you selected in the main menu.\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "Soul Arena - Mission - Survival (Easy)\n" +
                "\n" +
                "Difficulty ★★ - ★★★★★★★\n";
        }

        private void BonusArcSurvival_MouseEnter(object sender, MouseEventArgs e)
        {
            viewModel.ModeInformation = "-----Bonus Arc-----\n" +
                "\n" +
                "Bonus enemies appear here, with some new modifiers.\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "Soul Arena - Mission - Survival (Easy)\n" +
                "\n" +
                "Difficulty ★★★★★\n";
        }
        private void CustomArcSurvival_MouseEnter(object sender, MouseEventArgs e)
        {
            viewModel.ModeInformation = "-----Custom Arc-----\n" +
                "\n" +
                "Fully customizable arc, you make the rules.\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "Soul Arena - Mission - Survival (Easy)\n" +
                "\n" +
                "Difficulty ???\n";
        }


        private void Remove_Click(object sender, RoutedEventArgs e)
        {
            SettingsClass.SelectedSurvivalMode = "";
            SettingsClass.SaveData();
            viewModel.CodeInformation = "The code has been reset";
        }


    }




}
