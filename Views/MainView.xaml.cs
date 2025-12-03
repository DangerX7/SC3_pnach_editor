using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.Extensions.FileSystemGlobbing;
using NAudio.Wave;
using SC3_pnach_editor.Codes;
using SC3_pnach_editor.Services;
using SC3_pnach_editor.ViewModels;
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
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Timers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Resources;
using System.Windows.Threading;

namespace SC3_pnach_editor.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainView : System.Windows.Controls.UserControl
    {
        MainViewModel viewModel;

        private DispatcherTimer timer; // Declare timer at the class level
        private bool firstTime = true;

        public MainView()
        {
            InitializeComponent();

            //Check if configuration file exist
            FirstTimeConfiguration();

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
            //WeaponSpecialPowerComboP1.ItemsSource = viewModel.WeaponSpecialPowerCombo;
            //WeaponSpecialPowerComboP1.SelectedIndex = SettingsClass.WeaponSpecialPowerP1;
            WeaponEffectComboP2.ItemsSource = viewModel.WeaponEffectCombo;
            WeaponEffectComboP2.SelectedIndex = SettingsClass.WeaponEffectP2;
            //WeaponSpecialPowerComboP2.ItemsSource = viewModel.WeaponSpecialPowerCombo;
            //WeaponSpecialPowerComboP2.SelectedIndex = SettingsClass.WeaponSpecialPowerP2;

            ArmorComboP1.ItemsSource = viewModel.ArmorCombo;
            ArmorComboP1.SelectedIndex = SettingsClass.GuardianForceP1;
            ArmorComboP2.ItemsSource = viewModel.ArmorCombo;
            ArmorComboP2.SelectedIndex = SettingsClass.GuardianForceP2;

            CharacterChronicles.ItemsSource = viewModel.ChroniclesOfTheSwordCharacters;
            CharacterChronicles.SelectedIndex = SettingsClass.ChroniclesCharacterP1;
            CharacterChronicles2.ItemsSource = viewModel.ChroniclesOfTheSwordCharacters;
            CharacterChronicles2.SelectedIndex = SettingsClass.ChroniclesCharacterP2;

            CharacterChroniclesA.ItemsSource = viewModel.Discipline;
            CharacterChroniclesA.SelectedIndex = SettingsClass.ChroniclesCharacterP1_weapon;
            CharacterChroniclesB.ItemsSource = viewModel.Discipline;
            CharacterChroniclesB.SelectedIndex = SettingsClass.ChroniclesCharacterP2_weapon;


            PlayerControlCombo.ItemsSource = viewModel.PlayerControlCombo;
            PlayerControlCombo.SelectedIndex = SettingsClass.PlayerControl;

            OpponentControlCombo.ItemsSource = viewModel.OpponentControlCombo;
            OpponentControlCombo.SelectedIndex = SettingsClass.OpponentControl;


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
            string tyest = SettingsClass.CharacterP1;

            string weaponEfcP1 = Convert.ToString(WeaponEffectComboP1.SelectedValue);
            //string weaponSpP1 = Convert.ToString(WeaponSpecialPowerComboP1.SelectedValue);
            string weaponEfcP2 = Convert.ToString(WeaponEffectComboP2.SelectedValue);
            //string weaponSpP2 = Convert.ToString(WeaponSpecialPowerComboP2.SelectedValue);
            string selectedChar = Convert.ToString(CharacterChronicles.SelectedValue);
            string selectedChar2 = Convert.ToString(CharacterChronicles2.SelectedValue);
            string playerControl = Convert.ToString(PlayerControlCombo.SelectedValue);
            string opponentControl = Convert.ToString(OpponentControlCombo.SelectedValue);
            string selectedDiscipline = Convert.ToString(CharacterChroniclesA.SelectedValue);
            string selectedDiscipline2 = Convert.ToString(CharacterChroniclesB.SelectedValue);

            int P1SPEED = int.Parse(slider_P1spd.Value.ToString());
            int P2SPEED = int.Parse(slider_P2spd.Value.ToString());

            //if (
            //    (weaponSpP1 == "All Guard Break" && weaponSpP2 == "All Unblockable")
            // || (weaponSpP1 == "All Guard Break" && weaponSpP2 == "Paralysis")
            // || (weaponSpP1 == "All Guard Break" && weaponSpP2 == "Down Lose")
            // || (weaponSpP1 == "All Guard Break" && weaponSpP2 == "Cure")
            // || (weaponSpP1 == "All Guard Break" && weaponSpP2 == "Poison")
            // || (weaponSpP1 == "All Unblockable" && weaponSpP2 == "All Guard Break")
            // || (weaponSpP1 == "All Unblockable" && weaponSpP2 == "Paralysis")
            // || (weaponSpP1 == "All Unblockable" && weaponSpP2 == "Down Lose")
            // || (weaponSpP1 == "All Unblockable" && weaponSpP2 == "Cure")
            // || (weaponSpP1 == "All Unblockable" && weaponSpP2 == "Poison")
            // || (weaponSpP1 == "Paralysis"       && weaponSpP2 == "All Guard Break")
            // || (weaponSpP1 == "Paralysis"       && weaponSpP2 == "All Unblockable")
            // || (weaponSpP1 == "Paralysis"       && weaponSpP2 == "Down Lose")
            // || (weaponSpP1 == "Paralysis"       && weaponSpP2 == "Cure")
            // || (weaponSpP1 == "Paralysis"       && weaponSpP2 == "Poison")
            // || (weaponSpP1 == "Down Lose"       && weaponSpP2 == "All Guard Break")
            // || (weaponSpP1 == "Down Lose"       && weaponSpP2 == "All Unblockable")
            // || (weaponSpP1 == "Down Lose"       && weaponSpP2 == "Paralysis")
            // || (weaponSpP1 == "Down Lose"       && weaponSpP2 == "Cure")
            // || (weaponSpP1 == "Down Lose"       && weaponSpP2 == "Poison")
            // || (weaponSpP1 == "Cure"            && weaponSpP2 == "All Guard Break")
            // || (weaponSpP1 == "Cure"            && weaponSpP2 == "All Unblockable")
            // || (weaponSpP1 == "Cure"            && weaponSpP2 == "Paralysis")
            // || (weaponSpP1 == "Cure"            && weaponSpP2 == "Down Lose")
            // || (weaponSpP1 == "Cure"            && weaponSpP2 == "Poison")
            // || (weaponSpP1 == "Poison"          && weaponSpP2 == "All Guard Break")
            // || (weaponSpP1 == "Poison"          && weaponSpP2 == "All Unblockable")
            // || (weaponSpP1 == "Poison"          && weaponSpP2 == "Paralysis")
            // || (weaponSpP1 == "Poison"          && weaponSpP2 == "Down Lose")
            // || (weaponSpP1 == "Poison"          && weaponSpP2 == "Cure")
            //  )
            //{
            //    MessageBox.Show("Players cannot have different Weapon Powers!");
            //    return;
            //}


            SettingsClass.WeaponEffectP1 = WeaponEffectComboP1.SelectedIndex;
            //SettingsClass.WeaponSpecialPowerP1 = WeaponSpecialPowerComboP1.SelectedIndex;
            SettingsClass.WeaponEffectP2 = WeaponEffectComboP2.SelectedIndex;
            //SettingsClass.WeaponSpecialPowerP2 = WeaponSpecialPowerComboP2.SelectedIndex;

            SettingsClass.ChroniclesCharacterP1 = CharacterChronicles.SelectedIndex;
            SettingsClass.ChroniclesCharacterP2 = CharacterChronicles2.SelectedIndex;
            SettingsClass.ChroniclesCharacterP1_weapon = CharacterChroniclesA.SelectedIndex;
            SettingsClass.ChroniclesCharacterP2_weapon = CharacterChroniclesB.SelectedIndex;
            SettingsClass.PlayerControl = PlayerControlCombo.SelectedIndex;
            SettingsClass.OpponentControl = OpponentControlCombo.SelectedIndex;

            bool isCotsEffectActivated = false;
            if (SettingsClass.AllGuardBreakP1 == true ||
                SettingsClass.AllGuardBreakP2 == true ||
                SettingsClass.AllUnblockableP1 == true ||
                SettingsClass.AllUnblockableP2 == true ||
                SettingsClass.ParalysisP1 == true ||
                SettingsClass.ParalysisP2 == true ||
                SettingsClass.DownLoseP1 == true ||
                SettingsClass.DownLoseP2 == true ||
                SettingsClass.MinusGuardP1 == true ||
                SettingsClass.MinusGuardP2 == true ||
                SettingsClass.PoisonP1 == true ||
                SettingsClass.PoisonP2 == true ||
                SettingsClass.SuperPoisonP1 == true ||
                SettingsClass.SuperPoisonP2 == true ||
                SettingsClass.MegaPoisonP1 == true ||
                SettingsClass.MegaPoisonP2 == true ||
                SettingsClass.CureP1 == true ||
                SettingsClass.CureP2 == true ||
                SettingsClass.SuperCureP1 == true ||
                SettingsClass.SuperCureP2 == true ||
                SettingsClass.MegaCureP1 == true ||
                SettingsClass.MegaCureP2 == true ||
                SettingsClass.DefenseDownP1 == true ||
                SettingsClass.DefenseDownP2 == true ||
                SettingsClass.DefenseUpP1 == true ||
                SettingsClass.DefenseUpP2 == true ||
                SettingsClass.SuperDefenseP1 == true ||
                SettingsClass.SuperDefenseP2 == true ||
                SettingsClass.GlueP1 == true ||
                SettingsClass.GlueP2 == true ||
                SettingsClass.SeparateP1 == true ||
                SettingsClass.SeparateP2 == true ||
                SettingsClass.IceP1 == true ||
                SettingsClass.IceP2 == true ||
                SettingsClass.WhirlwindP1 == true ||
                SettingsClass.WhirlwindP2 == true ||
                SettingsClass.AerialWindP1 == true ||
                SettingsClass.AerialWindP2 == true ||
                SettingsClass.SmashP1 == true ||
                SettingsClass.SmashP2 == true ||
                SettingsClass.SoulSmashP1 == true ||
                SettingsClass.SoulSmashP2 == true ||
                SettingsClass.ReserveOffenseUpP1 == true ||
                SettingsClass.ReserveOffenseUpP2 == true)
            {
                isCotsEffectActivated = true;
            }

            SettingsClass.GfxCopyFrom = viewModel.GfxCopyFrom;
            SettingsClass.GfxCopyTo = viewModel.GfxCopyTo;
            SettingsClass.SurvivalPath = viewModel.SurvivalPath;

            SettingsClass.P1Speed = int.Parse(slider_P1spd.Value.ToString());
            SettingsClass.P2Speed = int.Parse(slider_P2spd.Value.ToString());

            SettingsClass.GuardianForceP1 = ArmorComboP1.SelectedIndex;
            SettingsClass.GuardianForceP2 = ArmorComboP2.SelectedIndex;

            SettingsClass.SaveData();

            if ((SettingsClass.GuardianForceP2 != 0 || SettingsClass.WeaponEffectP2 != 0 || isCotsEffectActivated == true || SettingsClass.ChroniclesCharacterP2 != 0 ||
                SettingsClass.ChroniclesCharacterP2_weapon != 0 || SettingsClass.SlipperyFieldP2 != false ||
                (SettingsClass.CharacterP2 != "" && SettingsClass.CharacterP2 != "none") || (SettingsClass.ModelP2 != "" && SettingsClass.ModelP2 != "none") ||
                (SettingsClass.P2Speed != 0 && SettingsClass.P2Speed != 4) || SettingsClass.GuardianForceP1 != 0 ||
                (SettingsClass.StageValue != "XX" && SettingsClass.StageValue != "")) &&
                SettingsClass.SelectedSurvivalMode != "")
            {
                System.Windows.Forms.MessageBox.Show("Survival mode and other codes were found! Either deactivate survival mode or the other ones" +
                    "(Player 2 or stage), or simply click the button bellow named RESET CODES.\n" +
                    "You can edit only P1 selected character and weapon effects to combine with survival mode");
                return;
            }


            string SurvivalPnach = "";
            if (SettingsClass.SelectedSurvivalMode != "")
            {
                SurvivalPnach = SurvivalModeCodes.GetSurvivalCode(SettingsClass.SelectedSurvivalMode, false);
            }


            statusText.Text = "Codes Activated";
            timer.Start();

            CreatePnach.ExportPnach(SurvivalPnach, viewModel.BonusCharacters, weaponEfcP1, "", SettingsClass.GuardianForceP1,
                viewModel.SlipperyFieldP1, weaponEfcP2, "", SettingsClass.GuardianForceP2,
                viewModel.SlipperyFieldP2, selectedChar, selectedChar2, playerControl, opponentControl, selectedDiscipline, selectedDiscipline2,
                viewModel.UltimateWeapons, P1SPEED, P2SPEED);
        }

        private void Char_Info(object sender, RoutedEventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("Select any warrior you want from the Chronicles of the Sword mode! \n" +
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

            System.Windows.Controls.ComboBox comboBox = (System.Windows.Controls.ComboBox)sender; // Get the ComboBox that triggered the event
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

            //SET EVERYTHING TO DEFAULT except folder paths
            SettingsClass.BonusCharacters = false;
            SettingsClass.UltimateWeapons = false;
            SettingsClass.GuardianForceP1 = 0;
            SettingsClass.GuardianForceP2 = 0;

            SettingsClass.WeaponEffectP1 = 0;
            SettingsClass.WeaponSpecialPowerP1 = 0;
            SettingsClass.WeaponEffectP2 = 0;
            SettingsClass.WeaponSpecialPowerP2 = 0;
            SettingsClass.ChroniclesCharacterP1 = 0;
            SettingsClass.ChroniclesCharacterP2 = 0;
            SettingsClass.ChroniclesCharacterP1_weapon = 0;
            SettingsClass.ChroniclesCharacterP2_weapon = 0;

            SettingsClass.PlayerControl = 0;
            SettingsClass.OpponentControl = 0;
            SettingsClass.SlipperyFieldP1 = false;
            SettingsClass.SlipperyFieldP2 = false;

            SettingsClass.WpnEffect1 = 0;
            SettingsClass.WpnEffect2 = 0;
            SettingsClass.WpnEffect3 = 0;
            SettingsClass.WpnEffect4 = 0;
            SettingsClass.WpnEffect5 = 0;
            SettingsClass.WpnEffect6 = 0;
            SettingsClass.WpnEffect7 = 0;
            SettingsClass.WpnEffect8 = 0;
            SettingsClass.WpnEffect9 = 0;
            SettingsClass.WpnEffect10 = 0;
            SettingsClass.WpnEffect11 = 0;
            SettingsClass.WpnEffect12 = 0;
            SettingsClass.WpnEffect13 = 0;
            SettingsClass.WpnEffect14 = 0;
            SettingsClass.WpnEffect15 = 0;
            SettingsClass.WpnEffect16 = 0;
            SettingsClass.WpnEffect17 = 0;
            SettingsClass.WpnEffect18 = 0;

            SettingsClass.CharacterP1 = "";
            SettingsClass.CharacterP2 = "";
            SettingsClass.ModelP1 = "";
            SettingsClass.ModelP2 = "";
            SettingsClass.UseSetCharacters = false;
            SettingsClass.StageValue = "XX";
            SettingsClass.P1Speed = 0;
            SettingsClass.P2Speed = 0;

            SettingsClass.NightTerrorSkin = "";
            SettingsClass.Taki1Skin = "";
            SettingsClass.Cassandra2Skin = "";
            SettingsClass.ColossusSkin  = "";
            SettingsClass.Lynette1Skin = "";
            SettingsClass.Nightmare1Skin = "";
            SettingsClass.Siegfried1Skin = "";
            SettingsClass.Sophitia1Skin = "";
            SettingsClass.Amy1Skin = "";
            SettingsClass.CharadeSkin = "";
            SettingsClass.LizardMenSkin = "";
            SettingsClass.Astaroth2Skin = "";
            SettingsClass.SeongMina1Skin = "";
            SettingsClass.Raphael2Skin = "";
            SettingsClass.Ivy1Skin = "";
            SettingsClass.Cassandra1Skin = "";
            SettingsClass.Sophitia2Skin = "";
            SettingsClass.Tira1Skin = "";

            SettingsClass.SelectedSurvivalMode = "";

            SettingsClass.LastSelectedCharP1 = "";
            SettingsClass.LastSelectedCharP2 = "";
            SettingsClass.LastSelectedIndexP1 = -1;
            SettingsClass.LastSelectedIndexP2 = -1;
            SettingsClass.VoiceP1 = "";
            SettingsClass.VoiceP2 = "";

            SettingsClass.AllGuardBreakP1 = false;
            SettingsClass.AllGuardBreakP2 = false;
            SettingsClass.AllUnblockableP1 = false;
            SettingsClass.AllUnblockableP2 = false;
            SettingsClass.ParalysisP1 = false;
            SettingsClass.ParalysisP2 = false;
            SettingsClass.DownLoseP1 = false;
            SettingsClass.DownLoseP2 = false;
            SettingsClass.MinusGuardP1 = false;
            SettingsClass.MinusGuardP2 = false;
            SettingsClass.PoisonP1 = false;
            SettingsClass.PoisonP2 = false;
            SettingsClass.SuperPoisonP1 = false;
            SettingsClass.SuperPoisonP2 = false;
            SettingsClass.MegaPoisonP1 = false;
            SettingsClass.MegaPoisonP2 = false;
            SettingsClass.CureP1 = false;
            SettingsClass.CureP2 = false;
            SettingsClass.SuperCureP1 = false;
            SettingsClass.SuperCureP2 = false;
            SettingsClass.MegaCureP1 = false;
            SettingsClass.MegaCureP2 = false;
            SettingsClass.DefenseDownP1 = false;
            SettingsClass.DefenseDownP2 = false;
            SettingsClass.DefenseUpP1 = false;
            SettingsClass.DefenseUpP2 = false;
            SettingsClass.SuperDefenseP1 = false;
            SettingsClass.SuperDefenseP2 = false;
            SettingsClass.GlueP1 = false;
            SettingsClass.GlueP2 = false;
            SettingsClass.SeparateP1 = false;
            SettingsClass.SeparateP2 = false;
            SettingsClass.IceP1 = false;
            SettingsClass.IceP2 = false;
            SettingsClass.WhirlwindP1 = false;
            SettingsClass.WhirlwindP2 = false;
            SettingsClass.AerialWindP1 = false;
            SettingsClass.AerialWindP2 = false;
            SettingsClass.SmashP1 = false;
            SettingsClass.SmashP2 = false;
            SettingsClass.SoulSmashP1 = false;
            SettingsClass.SoulSmashP2 = false;
            SettingsClass.ReserveOffenseUpP1 = false;
            SettingsClass.ReserveOffenseUpP2 = false;

            //remove cistom characters data
            SettingsClass.CustomCharacter1 = "";
            SettingsClass.CustomCharacter2 = "";
            SettingsClass.CustomCharacter3 = "";
            SettingsClass.CustomCharacter4 = "";
            SettingsClass.CustomCharacter5 = "";
            SettingsClass.CustomCharacter6 = "";
            SettingsClass.CustomCharacter7 = "";
            SettingsClass.CustomCharacter8 = "";
            SettingsClass.CustomCharacter9 = "";
            SettingsClass.CustomCharacter10 = "";
            SettingsClass.CustomCharacter11 = "";
            SettingsClass.CustomCharacter12 = "";
            SettingsClass.CustomCharacter13 = "";
            SettingsClass.CustomCharacter14 = "";
            SettingsClass.CustomCharacter15 = "";
            SettingsClass.CustomCharacter16 = "";
            SettingsClass.CustomCharacter17 = "";
            SettingsClass.CustomCharacter18 = "";
            SettingsClass.CustomCharacter19 = "";
            SettingsClass.CustomCharacter20 = "";

            SettingsClass.Slot1Type = "Memory Card 1";
            SettingsClass.Slot2Type = "Memory Card 2";

            string reset = CreatePnach.GetCustomCharactersPnachCodes("RESET");

            SettingsClass.SaveData();

            //DELETE MAIN GFX FOLDER
            if (Directory.Exists(SettingsClass.GfxCopyTo))
            {
                // Remove Read-Only Attribute from All Files
                foreach (string file in Directory.GetFiles(SettingsClass.GfxCopyTo, "*", SearchOption.AllDirectories))
                {
                    File.SetAttributes(file, FileAttributes.Normal);
                }

                // Delete the folder and its contents
                Directory.Delete(SettingsClass.GfxCopyTo, true);
            }

            viewModel.DisplayMainView();
        }

        private void GoToCostumesPage_Click(object sender, RoutedEventArgs e)
        {
            SettingsClass.SaveData();
            viewModel.DisplayCostumesView();
        }

        private void GoToSurvivalPage_Click(object sender, RoutedEventArgs e)
        {
            SettingsClass.SaveData();
            viewModel.DisplaySurvivalView();
        }

        private void GoToSpecialEffectsPage_Click(object sender, RoutedEventArgs e)
        {
            SettingsClass.SaveData();
            viewModel.DisplaySpecialEffectsView();
        }

        private void GoToCustomCharactersPage_Click(object sender, RoutedEventArgs e)
        {
            SettingsClass.SaveData();
            viewModel.DisplayCustomCharactersView();
        }

        private void FirstTimeConfiguration()
        {
            // Step 1: Check if Settings_File2 exists
            if (!File.Exists(@"C:\AppSettings\Settings_File2"))
            {
                // Step 2: Welcome message
                System.Windows.Forms.MessageBox.Show(
                    "Welcome to the PNACH Editor! To get started, please locate your PCSX2 folder and select the PCSX2 executable file."
                );

                // Step 3: Open file dialog for PCSX2
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Title = "Select PCSX2 Executable";
                dialog.Filter = "PCSX2 Executables|pcsx2*.exe";   // Shows pcsx2.exe, pcsx2-qt.exe, etc.
                dialog.InitialDirectory = "C:\\";                  // Optional

                DialogResult result = dialog.ShowDialog();

                // Step 4: Handle cancel
                if (result == DialogResult.Cancel)
                {
                    System.Windows.Forms.MessageBox.Show("Operation canceled. You must select a PCSX2 executable to continue.");
                    return;
                }

                // Step 5: Handle correct selection
                if (result == DialogResult.OK)
                {
                    string pcsx2Path = dialog.FileName;
                    int lastBackslashIndex = pcsx2Path.LastIndexOf('\\');
                    string pcsx2FolderPath = pcsx2Path.Substring(0, lastBackslashIndex);

                    string codeFolderPath = pcsx2FolderPath + "\\cheats";
                    string texturesOutFolderPath = pcsx2FolderPath + "\\textures\\SLUS-21216\\replacements\\pnachEditor";
                    if (!Directory.Exists(texturesOutFolderPath))
                    {
                        Directory.CreateDirectory(texturesOutFolderPath);
                    }

                    // OPTIONAL: Validate filename begins with pcsx2
                    if (!Path.GetFileName(pcsx2Path).ToLower().StartsWith("pcsx2"))
                    {
                        System.Windows.Forms.MessageBox.Show("Invalid file selected. Please configure folder paths manually.");
                        return;
                    }

                    // Get the full path of the executable
                    string exePath = Assembly.GetExecutingAssembly().Location;

                    // Get just the folder path
                    string exeFolder = Path.GetDirectoryName(exePath);

                    string texturesInFolderPath = exeFolder + "\\Textures";
                    string survivalAndCustomPath = exeFolder + "\\Custom Survival Files";

                    SettingsClass.LoadData();
                    SettingsClass.codeFolderPath = codeFolderPath;
                    SettingsClass.GfxCopyFrom = texturesInFolderPath;
                    SettingsClass.GfxCopyTo = texturesOutFolderPath;
                    SettingsClass.SurvivalPath = survivalAndCustomPath;
                    SettingsClass.SaveData();

                    // Step 6: configure pnach
                    // Show message box with Yes/No buttons and custom text
                    DialogResult result2 = System.Windows.Forms.MessageBox.Show("Are you using Topaz arcade edition or the original version of the game? Select Yes for Topaz or no for Original.", "Choose", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                    string selectedPnach = "";

                    if (result2 == DialogResult.Yes)
                    {
                        selectedPnach = "Topaz arcade edition";
                    }
                    else if (result2 == DialogResult.No)
                    {
                        selectedPnach = "Original version";
                    }
                    else // DialogResult.Cancel or closed window
                    {
                        selectedPnach = "Close";
                    }

                    // Step 7: Success message
                    if (selectedPnach == "Close")
                    {
                        SettingsClass.PnachName = @"\CAB2086E.pnach";
                        System.Windows.Forms.MessageBox.Show("Paths configured successfully! Topaz version was selected.\n\n" + pcsx2Path);
                    }
                    else
                    {
                        if (selectedPnach == "Topaz arcade edition")
                        {
                            SettingsClass.PnachName = @"\CAB2086E.pnach";
                            System.Windows.Forms.MessageBox.Show("Paths configured successfully! Topaz version was selected.\n\n" + pcsx2Path);
                        }
                        else if (selectedPnach == "Original version")
                        {
                            SettingsClass.PnachName = @"\027C604C.pnach";
                            System.Windows.Forms.MessageBox.Show("Paths configured successfully! Original version was selected.\n\n" + pcsx2Path);
                        }
                    }


                    //CAB2086E

                    // TODO: Save the path or continue setup here
                    // Example:
                    // File.WriteAllText(@"C:\AppSettings\PCSX2_Path.txt", pcsx2Path);
                }
            }
        }
    }



}
