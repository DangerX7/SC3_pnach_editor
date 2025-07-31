using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Diagnostics.PerformanceData;
using System.DirectoryServices;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Resources;
using System.Windows.Threading;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.Extensions.FileSystemGlobbing;
using NAudio.Wave;
using SC3_pnach_editor.Codes;
using SC3_pnach_editor.Services;
using SC3_pnach_editor.ViewModels;

namespace SC3_pnach_editor.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainView : UserControl
    {
        MainViewModel viewModel;

        private DispatcherTimer timer; // Declare timer at the class level
        private bool firstTime = true;

        public MainView()
        {
            InitializeComponent();


            viewModel = new();
            this.DataContext = viewModel;

            SettingsClass.LoadData();


            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(2); // Adjust the duration as needed
            timer.Tick += Timer_Tick;


            customSound.Source = new Uri(@"D:\Danger\Mods And Others\ps2\Soulcalibur 3\WPF Build\Extras\Narator_Tittle_Screen.wav");
            customSound.Volume = 0.2;

            if (SettingsClass.P1Speed == 0)
            {
                slider_P1spd.Value = 4;
            }
            else
            {
                slider_P1spd.Value = SettingsClass.P1Speed;
            }
            if (SettingsClass.P2Speed == 0)
            {
                slider_P2spd.Value = 4;
            }
            else
            {
                slider_P2spd.Value = SettingsClass.P2Speed;
            }

            CharacterChronicles.Visibility = Visibility.Collapsed;
            CharacterChronicles2.Visibility = Visibility.Collapsed;
            CharacterChroniclesA.Visibility = Visibility.Collapsed;
            CharacterChroniclesB.Visibility = Visibility.Collapsed;
            CharText.Visibility = Visibility.Collapsed;
            CharInfo.Visibility = Visibility.Collapsed;

            WeaponEffectComboP1.ItemsSource = viewModel.WeaponEffectCombo;
            WeaponEffectComboP1.SelectedIndex = SettingsClass.WeaponEffectP1;
            WeaponSpecialPowerComboP1.ItemsSource = viewModel.WeaponSpecialPowerCombo;
            WeaponSpecialPowerComboP1.SelectedIndex = SettingsClass.WeaponSpecialPowerP1;
            WeaponEffectComboP2.ItemsSource = viewModel.WeaponEffectCombo;
            WeaponEffectComboP2.SelectedIndex = SettingsClass.WeaponEffectP2;
            WeaponSpecialPowerComboP2.ItemsSource = viewModel.WeaponSpecialPowerCombo;
            WeaponSpecialPowerComboP2.SelectedIndex = SettingsClass.WeaponSpecialPowerP2;
            CharacterChronicles.ItemsSource = viewModel.ChroniclesOfTheSwordCharacters;
            CharacterChronicles.SelectedIndex = SettingsClass.ChroniclesCharacterP1;
            CharacterChronicles2.ItemsSource = viewModel.ChroniclesOfTheSwordCharacters;
            CharacterChronicles2.SelectedIndex = SettingsClass.ChroniclesCharacterP2;

            CharacterChroniclesA.ItemsSource = viewModel.Discipline;
            CharacterChroniclesA.SelectedIndex = SettingsClass.ChroniclesCharacterP1_weapon;
            CharacterChroniclesB.ItemsSource = viewModel.Discipline;
            CharacterChroniclesB.SelectedIndex = SettingsClass.ChroniclesCharacterP2_weapon;

            OpponentControlCombo.ItemsSource = viewModel.OpponentControlCombo;
            OpponentControlCombo.SelectedIndex = SettingsClass.OpponentControl;

            SurvivalModeCodes.GetSurvivalCode("Test");
        }

        private void ValueSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            // Handle the value change here
            double sliderValue_1 = slider_P1spd.Value;
            double sliderValue_2 = slider_P2spd.Value;
        }

        private void SavePath_Click(object sender, RoutedEventArgs e)
        {
            SettingsClass.codeFolderPath = viewModel.FolderPath;
            SettingsClass.codeFilePath = viewModel.FolderPath + SettingsClass.PnachName;
            SettingsClass.SaveData();
        }

        private void ChangeCodeFileName_Click(object sender, RoutedEventArgs e)
        {
            viewModel.CRC_Name = @"\" + viewModel.CRC_Name + ".pnach";
            SettingsClass.PnachName = viewModel.CRC_Name;
            SettingsClass.codeFilePath = SettingsClass.codeFolderPath + SettingsClass.PnachName;
            SettingsClass.SaveData();
        }

        private void Hyperlink_RequestNavigate(object sender, System.Windows.Navigation.RequestNavigateEventArgs e)
        {
            // Open the default web browser and navigate to the specified URI
            Process.Start(new ProcessStartInfo
            {
                FileName = e.Uri.AbsoluteUri,
                UseShellExecute = true
            });

            // Mark the event as handled, so WPF doesn't try to navigate automatically
            e.Handled = true;
        }

        private void GoToWeaponsEffectsPage_Click(object sender, RoutedEventArgs e)
        {
            SettingsClass.SaveData();
            viewModel.DisplayWeaponEffectView();
        }
        private void GoToCharactersPage_Click(object sender, RoutedEventArgs e)
        {
            SettingsClass.SaveData();
            viewModel.DisplayCharactersView();
        }

        private void ActivateCodes_Click(object sender, RoutedEventArgs e)
        {

            string weaponEfcP1 = Convert.ToString(WeaponEffectComboP1.SelectedValue);
            string weaponSpP1 = Convert.ToString(WeaponSpecialPowerComboP1.SelectedValue);
            string weaponEfcP2 = Convert.ToString(WeaponEffectComboP2.SelectedValue);
            string weaponSpP2 = Convert.ToString(WeaponSpecialPowerComboP2.SelectedValue);
            string selectedChar = Convert.ToString(CharacterChronicles.SelectedValue);
            string selectedChar2 = Convert.ToString(CharacterChronicles2.SelectedValue);
            string opponentControl = Convert.ToString(OpponentControlCombo.SelectedValue);
            string selectedDiscipline = Convert.ToString(CharacterChroniclesA.SelectedValue);
            string selectedDiscipline2 = Convert.ToString(CharacterChroniclesB.SelectedValue);

            int P1SPEED = int.Parse(slider_P1spd.Value.ToString());
            int P2SPEED = int.Parse(slider_P2spd.Value.ToString());

            if (
                (weaponSpP1 == "All Guard Break" && weaponSpP2 == "All Unblockable")
             || (weaponSpP1 == "All Guard Break" && weaponSpP2 == "Paralysis")
             || (weaponSpP1 == "All Guard Break" && weaponSpP2 == "Down Lose")
             || (weaponSpP1 == "All Guard Break" && weaponSpP2 == "Cure")
             || (weaponSpP1 == "All Guard Break" && weaponSpP2 == "Poison")
             || (weaponSpP1 == "All Unblockable" && weaponSpP2 == "All Guard Break")
             || (weaponSpP1 == "All Unblockable" && weaponSpP2 == "Paralysis")
             || (weaponSpP1 == "All Unblockable" && weaponSpP2 == "Down Lose")
             || (weaponSpP1 == "All Unblockable" && weaponSpP2 == "Cure")
             || (weaponSpP1 == "All Unblockable" && weaponSpP2 == "Poison")
             || (weaponSpP1 == "Paralysis"       && weaponSpP2 == "All Guard Break")
             || (weaponSpP1 == "Paralysis"       && weaponSpP2 == "All Unblockable")
             || (weaponSpP1 == "Paralysis"       && weaponSpP2 == "Down Lose")
             || (weaponSpP1 == "Paralysis"       && weaponSpP2 == "Cure")
             || (weaponSpP1 == "Paralysis"       && weaponSpP2 == "Poison")
             || (weaponSpP1 == "Down Lose"       && weaponSpP2 == "All Guard Break")
             || (weaponSpP1 == "Down Lose"       && weaponSpP2 == "All Unblockable")
             || (weaponSpP1 == "Down Lose"       && weaponSpP2 == "Paralysis")
             || (weaponSpP1 == "Down Lose"       && weaponSpP2 == "Cure")
             || (weaponSpP1 == "Down Lose"       && weaponSpP2 == "Poison")
             || (weaponSpP1 == "Cure"            && weaponSpP2 == "All Guard Break")
             || (weaponSpP1 == "Cure"            && weaponSpP2 == "All Unblockable")
             || (weaponSpP1 == "Cure"            && weaponSpP2 == "Paralysis")
             || (weaponSpP1 == "Cure"            && weaponSpP2 == "Down Lose")
             || (weaponSpP1 == "Cure"            && weaponSpP2 == "Poison")
             || (weaponSpP1 == "Poison"          && weaponSpP2 == "All Guard Break")
             || (weaponSpP1 == "Poison"          && weaponSpP2 == "All Unblockable")
             || (weaponSpP1 == "Poison"          && weaponSpP2 == "Paralysis")
             || (weaponSpP1 == "Poison"          && weaponSpP2 == "Down Lose")
             || (weaponSpP1 == "Poison"          && weaponSpP2 == "Cure")
              )
            {
                MessageBox.Show("Players cannot have different Weapon Powers!");
                return;
            }


            SettingsClass.WeaponEffectP1 = WeaponEffectComboP1.SelectedIndex;
            SettingsClass.WeaponSpecialPowerP1 = WeaponSpecialPowerComboP1.SelectedIndex;
            SettingsClass.WeaponEffectP2 = WeaponEffectComboP2.SelectedIndex;
            SettingsClass.WeaponSpecialPowerP2 = WeaponSpecialPowerComboP2.SelectedIndex;

            SettingsClass.ChroniclesCharacterP1 = CharacterChronicles.SelectedIndex;
            SettingsClass.ChroniclesCharacterP2 = CharacterChronicles2.SelectedIndex;
            SettingsClass.ChroniclesCharacterP1_weapon = CharacterChroniclesA.SelectedIndex;
            SettingsClass.ChroniclesCharacterP2_weapon = CharacterChroniclesB.SelectedIndex;
            SettingsClass.OpponentControl = OpponentControlCombo.SelectedIndex;


            SettingsClass.GfxCopyFrom = viewModel.GfxCopyFrom;
            SettingsClass.GfxCopyTo = viewModel.GfxCopyTo;

            SettingsClass.P1Speed = int.Parse(slider_P1spd.Value.ToString());
            SettingsClass.P2Speed = int.Parse(slider_P2spd.Value.ToString());

            SettingsClass.SaveData();


            statusText.Text = "Codes Activated";
            timer.Start();

            CreatePnach.ExportPnach(viewModel.BonusCharacters, weaponEfcP1, weaponSpP1, viewModel.GuardianForceP1,
                viewModel.SlipperyFieldP1, weaponEfcP2, weaponSpP2, viewModel.GuardianForceP2,
                viewModel.SlipperyFieldP2, selectedChar, selectedChar2, opponentControl, selectedDiscipline, selectedDiscipline2,
                viewModel.UltimateWeapons, P1SPEED, P2SPEED);
        }

        private void Char_Info(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Select any warrior you want from the Chronicles of the Sword mode! \n" +
                "Some characters will crash the game in Soul Arena - Quick mode. \n" +
                "And don't change Player 2 if you play Soul Arena - Mission or World Competition modes.");
            return;
        }

        private void CharacterChronicles_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (CharacterChronicles.SelectedIndex <= 118)
            {
                CharacterChroniclesA.Visibility = Visibility.Collapsed;
            }
            else
            {
                CharacterChroniclesA.Visibility = Visibility.Visible;
            }
            if (CharacterChronicles2.SelectedIndex <= 118)
            {
                CharacterChroniclesB.Visibility = Visibility.Collapsed;
            }
            else
            {
                CharacterChroniclesB.Visibility = Visibility.Visible;
            }

            ComboBox comboBox = (ComboBox)sender; // Get the ComboBox that triggered the event
            viewModel.CharPreview = "/Resources/" + Convert.ToString(comboBox.SelectedValue) + ".webp";
        }



        private void Timer_Tick(object sender, EventArgs e)
        {
            statusText.Text = string.Empty;
            timer.Stop();
        }

        private void DeactivateCodes_Click(object sender, RoutedEventArgs e)
        {
            statusText.Text = "Codes Removed";
            timer.Start();
            CreatePnach.ClearPnach();
        }

        private void GoToCostumesPage_Click(object sender, RoutedEventArgs e)
        {
            SettingsClass.SaveData();
            viewModel.DisplayCostumesView();
        }
    }



}
