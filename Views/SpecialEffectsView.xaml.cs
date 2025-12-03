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
    public partial class SpecialEffectsView : UserControl
    {
        SpecialEffectsViewModel viewModel;
        public SpecialEffectsView()
        {

            InitializeComponent();

            viewModel = new();

            this.DataContext = viewModel;


            SettingsClass.LoadData();

            if (SettingsClass.SoundOn)
            {
                string soundPath = System.IO.Path.Combine(Directory.GetParent(SettingsClass.SurvivalPath)!.FullName,
                    @"Extras\Char_Creation_Bgm.mp3");
                customSound.Source = new Uri(soundPath);
                customSound.Volume = 0.1;
            }
        }

        private void Activate_Click(object sender, RoutedEventArgs e)
        {
            var access = true;

            bool mainGroup1 = SettingsClass.PoisonP1
                          || SettingsClass.SuperPoisonP1
                          || SettingsClass.MegaPoisonP1
                          || SettingsClass.AerialWindP1
                          || SettingsClass.SoulSmashP1;

            int mainCount1 =
                (SettingsClass.PoisonP1 ? 1 : 0) +
                (SettingsClass.SuperPoisonP1 ? 1 : 0) +
                (SettingsClass.MegaPoisonP1 ? 1 : 0) +
                (SettingsClass.AerialWindP1 ? 1 : 0) +
                (SettingsClass.SoulSmashP1 ? 1 : 0);

            bool secondaryGroup1 =
                SettingsClass.AllGuardBreakP1 || SettingsClass.AllUnblockableP1 || SettingsClass.ParalysisP1 ||
                SettingsClass.DownLoseP1 || SettingsClass.MinusGuardP1 || SettingsClass.CureP1 || SettingsClass.SuperCureP1 ||
                SettingsClass.MegaCureP1 || SettingsClass.DefenseDownP1 || SettingsClass.DefenseUpP1 ||
                SettingsClass.SuperDefenseP1 || SettingsClass.GlueP1 || SettingsClass.SeparateP1 ||
                SettingsClass.IceP1 || SettingsClass.WhirlwindP1 ||
                SettingsClass.SmashP1 || SettingsClass.ReserveOffenseUpP1;

            if (mainCount1 >= 2 || (mainGroup1 && secondaryGroup1))
            {
                access = false;
            }

            bool mainGroup2 = SettingsClass.PoisonP2
                          || SettingsClass.SuperPoisonP2
                          || SettingsClass.MegaPoisonP2
                          || SettingsClass.AerialWindP2
                          || SettingsClass.SoulSmashP2;

            int mainCount2 =
                (SettingsClass.PoisonP2 ? 1 : 0) +
                (SettingsClass.SuperPoisonP2 ? 1 : 0) +
                (SettingsClass.MegaPoisonP2 ? 1 : 0) +
                (SettingsClass.AerialWindP2 ? 1 : 0) +
                (SettingsClass.SoulSmashP2 ? 1 : 0);

            bool secondaryGroup2 =
                SettingsClass.AllGuardBreakP2 || SettingsClass.AllUnblockableP2 || SettingsClass.ParalysisP2 ||
                SettingsClass.DownLoseP2 || SettingsClass.MinusGuardP2 || SettingsClass.CureP2 || SettingsClass.SuperCureP2 ||
                SettingsClass.MegaCureP2 || SettingsClass.DefenseDownP2 || SettingsClass.DefenseUpP2 ||
                SettingsClass.SuperDefenseP2 || SettingsClass.GlueP2 || SettingsClass.SeparateP2 ||
                SettingsClass.IceP2 || SettingsClass.WhirlwindP2 ||
                SettingsClass.SmashP2 || SettingsClass.ReserveOffenseUpP2;

            if (mainCount2 >= 2 || (mainGroup2 && secondaryGroup2))
            {
                access = false;
            }


            int countP1 = 0;
            if (SettingsClass.MinusGuardP1)
            {
                countP1++;
            }
            if (SettingsClass.CureP1)
            {
                countP1++;
            }
            if (SettingsClass.SuperCureP1)
            {
                countP1++;
            }
            if (SettingsClass.MegaCureP1)
            {
                countP1++;
            }
            if (SettingsClass.DefenseDownP1)
            {
                countP1++;
            }
            if (SettingsClass.DefenseUpP1)
            {
                countP1++;
            }
            if (SettingsClass.SuperDefenseP1)
            {
                countP1++;
            }
            if (SettingsClass.GlueP1)
            {
                countP1++;
            }
            if (SettingsClass.SeparateP1)
            {
                countP1++;
            }
            if (SettingsClass.IceP1)
            {
                countP1++;
            }
            if (SettingsClass.WhirlwindP1)
            {
                countP1++;
            }
            if (SettingsClass.AerialWindP1)
            {
                countP1++;
            }
            if (SettingsClass.SoulSmashP1)
            {
                countP1++;
            }
            if (SettingsClass.ReserveOffenseUpP1)
            {
                countP1++;
            }
            if (countP1 > 1)
            {
                access = false;
            }

            int countP2 = 0;
            if (SettingsClass.MinusGuardP2)
            {
                countP2++;
            }
            if (SettingsClass.CureP2)
            {
                countP2++;
            }
            if (SettingsClass.SuperCureP2)
            {
                countP2++;
            }
            if (SettingsClass.MegaCureP2)
            {
                countP2++;
            }
            if (SettingsClass.DefenseDownP2)
            {
                countP2++;
            }
            if (SettingsClass.DefenseUpP2)
            {
                countP2++;
            }
            if (SettingsClass.SuperDefenseP2)
            {
                countP2++;
            }
            if (SettingsClass.GlueP2)
            {
                countP2++;
            }
            if (SettingsClass.SeparateP2)
            {
                countP2++;
            }
            if (SettingsClass.IceP2)
            {
                countP2++;
            }
            if (SettingsClass.WhirlwindP2)
            {
                countP2++;
            }
            if (SettingsClass.AerialWindP2)
            {
                countP2++;
            }
            if (SettingsClass.SoulSmashP2)
            {
                countP2++;
            }
            if (SettingsClass.ReserveOffenseUpP2)
            {
                countP2++;
            }
            if (countP2 > 1)
            {
                access = false;
            }

            if (access == false)
            {
                MessageBox.Show("Don't be greedy! Respect the rules!", "Error", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                SettingsClass.SaveData();

                CreatePnach.ExportPnach("", false, "", "", 0,
                    false, "", "", 0,
                    false, "", "", "", "", "", "",
                    false, 4, 4);
            }

        }
        private void GoToMainPage_Click(object sender, RoutedEventArgs e)
        {
            viewModel.DisplayMainView();
        }
        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            //if (sender is CheckBox chk)
            //{
            //    string name = chk.Name;
            //    bool isChecked = chk.IsChecked == true;

            //    // now you can branch logic based on Name
            //    switch (name)
            //    {
            //        case "AllGuardBreakP1":

            //            break;

            //        case "AllGuardBreakP2":

            //            break;

            //        case "AllUnblockableP1":

            //            break;

            //        case "AllUnblockableP2":

            //            break;

            //        case "ParalysisP1":

            //            break;

            //        case "ParalysisP2":

            //            break;

            //        case "DownLoseP1":

            //            break;

            //        case "DownLoseP2":

            //            break;
            //    }
            //}
        }
        private void CheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            //if (sender is CheckBox chk)
            //{
            //    string name = chk.Name;
            //    switch (name)
            //    {
            //        case "AllGuardBreakP1":

            //            break;

            //        case "AllGuardBreakP2":

            //            break;

            //        case "AllUnblockableP1":

            //            break;

            //        case "AllUnblockableP2":

            //            break;
            //    }
            //}
        }

        private void EffectPreview(object sender, MouseEventArgs e)
        {
            TextBlock textBlock = sender as TextBlock;
            if (textBlock != null)
            {
                string customString = textBlock.Tag as string; // Retrieve the custom string

                switch (customString)
                {
                    case "AllGuardBreak":
                        viewModel.ModeInformation = "All Guard Break: All attacks have Guard Break properties against the selected player.\n" +
                            "";
                        break;
                    case "AllUnblockable":
                        viewModel.ModeInformation = "All Unblockable: All attacks become Unblockable against the selected player.\n" +
                            "";
                        break;
                    case "Paralysis":
                        viewModel.ModeInformation = "Paralysis: All attacks will stun the selected player.\n" +
                            "";
                        break;
                    case "DownLose":
                        viewModel.ModeInformation = "Down Lose: Player is defeated the moment he is knocked down.\n" +
                            "";
                        break;
                    case "MinusGuard":
                        viewModel.ModeInformation = "Minus Guard: Slowly lose health while Guarding.\n" +
                            "";
                        break;
                    case "Poison":
                        viewModel.ModeInformation = "Poison: Health decreases gradually.\n" +
                            "";
                        break;
                    case "SuperPoison":
                        viewModel.ModeInformation = "Super Poison: Health decreases fast\n" +
                            "";
                        break;
                    case "MegaPoison":
                        viewModel.ModeInformation = "Mega Poison: Health decreases very fast\n" +
                            "";
                        break;
                    case "Cure":
                        viewModel.ModeInformation = "Cure: Slowly regains health.\n" +
                            "";
                        break;
                    case "SuperCure":
                        viewModel.ModeInformation = "Super Cure: Regain health faster.\n" +
                            "";
                        break;
                    case "MegaCure":
                        viewModel.ModeInformation = "Mega Cure: Regain health very fast.\n" +
                            "";
                        break;
                    case "DefenseDown":
                        viewModel.ModeInformation = "Defense Down: Defense is lower than normal.\n" +
                            "";
                        break;
                    case "DefenseUp":
                        viewModel.ModeInformation = "Defense Up: Defense is higher than normal.\n" +
                            "";
                        break;
                    case "SuperDefense":
                        viewModel.ModeInformation = "Super Defense: Defense is way higher than normal.\n" +
                            "";
                        break;
                    case "Glue":
                        viewModel.ModeInformation = "Glue: The selected player will be slowly pulled towards the opponent.\n" +
                            "";
                        break;
                    case "Separate":
                        viewModel.ModeInformation = "Separate: The selected player is slowly being pulled away from the opponent.\n" +
                            "Can also fall out of the stage when near the edge.\n" +
                            "";
                        break;
                    case "Ice":
                        viewModel.ModeInformation = "Ice: The floor becomes slippery to the selected player.\n" +
                            "Can also fall out of the stage when near the edge.\n" +
                            "";
                        break;
                    case "Whirlwind":
                        viewModel.ModeInformation = "Whirlwind: The selected player will be slowly pushed around the ring in a circular manner.\n" +
                            "Can also fall out of the stage when near the edge.\n" +
                            "";
                        break;
                    case "Aerialwind":
                        viewModel.ModeInformation = "Aerial wind: The selected player style attacks have a stronger effect, causing the opponent to float longer in the air.\n" +
                            "";
                        break;
                    case "Smash":
                        viewModel.ModeInformation = "Smash: Launcher style attacks knocks the selected player far backwards.\n" +
                            "Will also explode when hit.\n" +
                            "";
                        break;
                    case "SoulSmash":
                        viewModel.ModeInformation = "Soul Smash: Launcher style attacks knocks the selected player extremely far backwards.\n" +
                            "";
                        break;
                    case "ReserveOffenseUp":
                        viewModel.ModeInformation = "Reserve Offense Up: Offence increases with damage taken for selected player.\n" +
                            "";
                        break;
                }
            }
        }

        private void DissableAll_Click(object sender, RoutedEventArgs e)
        {
            viewModel.AllGuardBreakP1     = false;
            viewModel.AllGuardBreakP2     = false;
            viewModel.AllUnblockableP1    = false; 
            viewModel.AllUnblockableP2    = false;
            viewModel.ParalysisP1         = false;
            viewModel.ParalysisP2         = false;
            viewModel.DownLoseP1          = false;
            viewModel.DownLoseP2          = false;
            viewModel.MinusGuardP1        = false;
            viewModel.MinusGuardP2        = false;
            viewModel.PoisonP1            = false;
            viewModel.PoisonP2            = false;
            viewModel.SuperPoisonP1       = false;
            viewModel.SuperPoisonP2       = false;
            viewModel.MegaPoisonP1        = false;
            viewModel.MegaPoisonP2        = false;
            viewModel.CureP1              = false;
            viewModel.CureP2              = false;
            viewModel.SuperCureP1         = false;
            viewModel.SuperCureP2         = false;
            viewModel.MegaCureP1          = false;
            viewModel.MegaCureP2          = false;
            viewModel.DefenseDownP1       = false;
            viewModel.DefenseDownP2       = false;
            viewModel.DefenseUpP1         = false;
            viewModel.DefenseUpP2         = false;
            viewModel.SuperDefenseP1      = false;
            viewModel.SuperDefenseP2      = false;
            viewModel.GlueP1              = false;
            viewModel.GlueP2              = false;
            viewModel.SeparateP1          = false;
            viewModel.SeparateP2          = false;
            viewModel.IceP1               = false;
            viewModel.IceP2               = false;
            viewModel.WhirlwindP1         = false;
            viewModel.WhirlwindP2         = false;
            viewModel.AerialWindP1        = false;
            viewModel.AerialWindP2        = false;
            viewModel.SmashP1             = false;
            viewModel.SmashP2             = false;
            viewModel.SoulSmashP1         = false;
            viewModel.SoulSmashP2         = false;
            viewModel.ReserveOffenseUpP1  = false;
            viewModel.ReserveOffenseUpP2 = false;
        }

    }




}
