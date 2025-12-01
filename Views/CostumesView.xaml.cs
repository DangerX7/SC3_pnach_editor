using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using SC3_pnach_editor.ViewModels;
using OfficeOpenXml;
using System.IO;
using System.Data;
using System.Windows.Media.Media3D;
using SC3_pnach_editor.Services;
using NAudio.Wave;
using NAudio.Gui;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace SC3_pnach_editor.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class CostumesView : UserControl
    {
        CostumesViewModel viewModel;
        public CostumesView()
        {

            InitializeComponent();

            viewModel = new();

            this.DataContext = viewModel;


            SettingsClass.LoadData();
            SetBooleans();


            customSound.Source = new Uri(@"D:\Danger\Mods And Others\ps2\Soulcalibur 3\WPF Build\Extras\Char_Creation_Bgm.mp3");
            customSound.Volume = 0.1;


        }

        public void SetBooleans()
        {
            if (SettingsClass.NightTerrorSkin == @"Night_Terror_blue")
            {
                NightTerrorCheckBox.IsChecked = true;
            }
            if (SettingsClass.Taki1Skin == @"Taki_Blue")
            {
                Taki1CheckBox.IsChecked = true;
            }
            if (SettingsClass.Cassandra2Skin == @"Cassandra_pink")
            {
                Cassandra2CheckBox.IsChecked = true;
            }
            if (SettingsClass.ColossusSkin == @"Colossus_golden")
            {
                ColossusCheckBox.IsChecked = true;
            }
            if (SettingsClass.Lynette1Skin == @"green_lynette")
            {
                Lynette1CheckBox.IsChecked = true;
            }
            if (SettingsClass.Nightmare1Skin == @"Nightmare_red")
            {
                Nightmare1CheckBox.IsChecked = true;
            }
            if (SettingsClass.Siegfried1Skin == @"Siegfried_red")
            {
                Siegfried1CheckBox.IsChecked = true;
            }
            if (SettingsClass.Sophitia1Skin == @"Sophitia_brown")
            {
                Sophitia1CheckBox.IsChecked = true;
            }
            if (SettingsClass.Amy1Skin == @"Red_Amy")
            {
                Amy1CheckBox.IsChecked = true;
            }
            if (SettingsClass.CharadeSkin == @"Charade_P2")
            {
                CharadeCheckBox.IsChecked = true;
            }
            if (SettingsClass.LizardMenSkin == @"Lizard_Men_Blue")
            {
                LizardMenCheckBox.IsChecked = true;
            }
            if (SettingsClass.Lynette1Skin == @"Lynette_Goth")
            {
                Lynette1CheckBox2.IsChecked = true;
            }
            if (SettingsClass.Astaroth2Skin == @"Astaroth_Human")
            {
                Astaroth2CheckBox.IsChecked = true;
            }
            if (SettingsClass.SeongMina1Skin == @"Seong_Mina_Cyan")
            {
                SeongMina1CheckBox.IsChecked = true;
            }
            if (SettingsClass.Raphael2Skin == @"Raphael_Custom")
            {
                Raphael2CheckBox.IsChecked = true;
            }
            if (SettingsClass.Ivy1Skin == @"Ivy_Purple")
            {
                Ivy1CheckBox.IsChecked = true;
            }
            if (SettingsClass.Cassandra1Skin == @"Cassandra_Red")
            {
                Cassandra1CheckBox.IsChecked = true;
            }
            if (SettingsClass.Cassandra2Skin == @"Cassandra_Valkyrie")
            {
                Cassandra2CheckBox2.IsChecked = true;
            }
            if (SettingsClass.Sophitia2Skin == @"Sophitia_Custom")
            {
                Sophitia2CheckBox.IsChecked = true;
            }
            if (SettingsClass.Tira1Skin == @"Tira_Posessed")
            {
                Tira1CheckBox.IsChecked = true;
            }

        }

        private void ResetToDefault_Click(object sender, RoutedEventArgs e)
        {
            viewModel.AddOrRemoveTextures("remove", "ALL", "");
        }

        private void GoToMainPage_Click(object sender, RoutedEventArgs e)
        {
            viewModel.DisplayMainView();
        }

        private void SkinPreview(object sender, MouseEventArgs e)
        {
            TextBlock textBlock = sender as TextBlock;
            if (textBlock != null)
            {
                string customString = textBlock.Tag as string; // Retrieve the custom string

                viewModel.SkinPreview = "/Resources/" + customString + ".png";
            }
        }


        private void NightTerrorGraySkin_Checked(object sender, RoutedEventArgs e)
        {
            viewModel.AddOrRemoveTextures("add", @"Night_Terror_blue", "NightTerrorSkin");
        }

        private void NightTerrorGraySkin_Unchecked(object sender, RoutedEventArgs e)
        {
            viewModel.AddOrRemoveTextures("remove", @"Night_Terror_blue", "NightTerrorSkin");
        }

        private void TakiStockingsSkin_Checked(object sender, RoutedEventArgs e)
        {
            viewModel.AddOrRemoveTextures("add", @"Taki_Blue", "Taki1Skin");
        }

        private void TakiStockingsSkin_Unchecked(object sender, RoutedEventArgs e)
        {
            viewModel.AddOrRemoveTextures("remove", @"Taki_Blue", "Taki1Skin");
        }

        private void CassandraPinkSkin_Checked(object sender, RoutedEventArgs e)
        {
            Cassandra2CheckBox2.IsChecked = false;
            viewModel.AddOrRemoveTextures("add", @"Cassandra_pink", "Cassandra2Skin");
        }

        private void CassandraPinkSkin_Unchecked(object sender, RoutedEventArgs e)
        {
            viewModel.AddOrRemoveTextures("remove", @"Cassandra_pink", "Cassandra2Skin");
        }

        private void ColossusGoldenSkin_Checked(object sender, RoutedEventArgs e)
        {
            viewModel.AddOrRemoveTextures("add", @"Colossus_golden", "ColossusSkin");
        }

        private void ColossusGoldenSkin_Unchecked(object sender, RoutedEventArgs e)
        {
            viewModel.AddOrRemoveTextures("remove", @"Colossus_golden", "ColossusSkin");
        }

        private void GreenLynetteSkin_Checked(object sender, RoutedEventArgs e)
        {
            Lynette1CheckBox2.IsChecked = false;
            viewModel.AddOrRemoveTextures("add", @"green_lynette", "Lynette1Skin");
        }

        private void GreenLynetteSkin_Unchecked(object sender, RoutedEventArgs e)
        {
            viewModel.AddOrRemoveTextures("remove", @"green_lynette", "Lynette1Skin");
        }

        private void NightmareRedSkin_Checked(object sender, RoutedEventArgs e)
        {
            viewModel.AddOrRemoveTextures("add", @"Nightmare_red", "Nightmare1Skin");
        }

        private void NightmareRedSkin_Unchecked(object sender, RoutedEventArgs e)
        {
            viewModel.AddOrRemoveTextures("remove", @"Nightmare_red", "Nightmare1Skin");
        }

        private void SiegfriedPurpleSkin_Checked(object sender, RoutedEventArgs e)
        {
            viewModel.AddOrRemoveTextures("add", @"Siegfried_red", "Siegfried1Skin");
        }

        private void SiegfriedPurpleSkin_Unchecked(object sender, RoutedEventArgs e)
        {
            viewModel.AddOrRemoveTextures("remove", @"Siegfried_red", "Siegfried1Skin");
        }

        private void SophitiaBrownSkin_Checked(object sender, RoutedEventArgs e)
        {
            viewModel.AddOrRemoveTextures("add", @"Sophitia_brown", "Sophitia1Skin");
        }

        private void SophitiaBrownSkin_Unchecked(object sender, RoutedEventArgs e)
        {
            viewModel.AddOrRemoveTextures("remove", @"Sophitia_brown", "Sophitia1Skin");
        }

        private void RedAmySkin_Checked(object sender, RoutedEventArgs e)
        {
            viewModel.AddOrRemoveTextures("add", @"Red_Amy", "Amy1Skin");
        }

        private void RedAmySkin_Unchecked(object sender, RoutedEventArgs e)
        {
            viewModel.AddOrRemoveTextures("remove", @"Red_Amy", "Amy1Skin");
        }

        private void CharadeP2Skin_Checked(object sender, RoutedEventArgs e)
        {
            viewModel.AddOrRemoveTextures("add", @"Charade_P2", "CharadeSkin");
        }

        private void CharadeP2Skin_Unchecked(object sender, RoutedEventArgs e)
        {
            viewModel.AddOrRemoveTextures("remove", @"Charade_P2", "CharadeSkin");
        }

        private void LizardMenBlueSkin_Checked(object sender, RoutedEventArgs e)
        {
            viewModel.AddOrRemoveTextures("add", @"Lizard_Men_Blue", "LizardMenSkin");
        }

        private void LizardMenBlueSkin_Unchecked(object sender, RoutedEventArgs e)
        {
            viewModel.AddOrRemoveTextures("remove", @"Lizard_Men_Blue", "LizardMenSkin");
        }

        private void LynetteGothSkin_Checked(object sender, RoutedEventArgs e)
        {
            Lynette1CheckBox.IsChecked = false;
            viewModel.AddOrRemoveTextures("add", @"Lynette_Goth", "Lynette1Skin");
        }

        private void LynetteGothSkin_Unchecked(object sender, RoutedEventArgs e)
        {
            viewModel.AddOrRemoveTextures("remove", @"Lynette_Goth", "Lynette1Skin");
        }

        private void AstarothHumanSkin_Checked(object sender, RoutedEventArgs e)
        {
            viewModel.AddOrRemoveTextures("add", @"Astaroth_Human", "Astaroth2Skin");
        }

        private void AstarothHumanSkin_Unchecked(object sender, RoutedEventArgs e)
        {
            viewModel.AddOrRemoveTextures("remove", @"Astaroth_Human", "Astaroth2Skin");
        }

        private void SeongMinaCyanSkin_Checked(object sender, RoutedEventArgs e)
        {
            viewModel.AddOrRemoveTextures("add", @"Seong_Mina_Cyan", "SeongMina1Skin");
        }

        private void SeongMinaCyanSkin_Unchecked(object sender, RoutedEventArgs e)
        {
            viewModel.AddOrRemoveTextures("remove", @"Seong_Mina_Cyan", "SeongMina1Skin");
        }

        private void RaphaelCustomSkin_Checked(object sender, RoutedEventArgs e)
        {
            viewModel.AddOrRemoveTextures("add", @"Raphael_Custom", "Raphael2Skin");
        }

        private void RaphaelCustomSkin_Unchecked(object sender, RoutedEventArgs e)
        {
            viewModel.AddOrRemoveTextures("remove", @"Raphael_Custom", "Raphael2Skin");
        }

        private void IvyPurpleSkin_Checked(object sender, RoutedEventArgs e)
        {
            viewModel.AddOrRemoveTextures("add", @"Ivy_Purple", "Ivy1Skin");
        }

        private void IvyPurpleSkin_Unchecked(object sender, RoutedEventArgs e)
        {
            viewModel.AddOrRemoveTextures("remove", @"Ivy_Purple", "Ivy1Skin");
        }

        private void CassandraRedSkin_Checked(object sender, RoutedEventArgs e)
        {
            viewModel.AddOrRemoveTextures("add", @"Cassandra_Red", "Cassandra1Skin");
        }

        private void CassandraRedSkin_Unchecked(object sender, RoutedEventArgs e)
        {
            viewModel.AddOrRemoveTextures("remove", @"Cassandra_Red", "Cassandra1Skin");
        }

        private void CassandraValkyrieSkin_Checked(object sender, RoutedEventArgs e)
        {
            Cassandra2CheckBox.IsChecked = false;
            viewModel.AddOrRemoveTextures("add", @"Cassandra_Valkyrie", "Cassandra2Skin");
        }

        private void CassandraValkyrieSkin_Unchecked(object sender, RoutedEventArgs e)
        {
            viewModel.AddOrRemoveTextures("remove", @"Cassandra_Valkyrie", "Cassandra2Skin");
        }

        private void SophitiaCustomSkin_Checked(object sender, RoutedEventArgs e)
        {
            viewModel.AddOrRemoveTextures("add", @"Sophitia_Custom", "Sophitia2Skin");
        }

        private void SophitiaCustomSkin_Unchecked(object sender, RoutedEventArgs e)
        {
            viewModel.AddOrRemoveTextures("remove", @"Sophitia_Custom", "Sophitia2Skin");
        }

        private void TiraPosessedSkin_Checked(object sender, RoutedEventArgs e)
        {
            viewModel.AddOrRemoveTextures("add", @"Tira_Posessed", "Tira1Skin");
        }

        private void TiraPosessedSkin_Unchecked(object sender, RoutedEventArgs e)
        {
            viewModel.AddOrRemoveTextures("remove", @"Tira_Posessed", "Tira1Skin");
        }

    }




}
