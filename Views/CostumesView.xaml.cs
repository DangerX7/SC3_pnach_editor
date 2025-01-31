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


            customSound.Source = new Uri(@"D:\Danger\Mods And Others\ps2\Soulcalibur 3\WPF Build\Extras\Char_Creation_Bgm.mp3");
            customSound.Volume = 0.1;


        }

        private void ResetToDefault_Click(object sender, RoutedEventArgs e)
        {
            viewModel.AddOrRemoveTextures("remove", "ALL");
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
            viewModel.AddOrRemoveTextures("add", "nightTerrorGraySkin");
        }

        private void NightTerrorGraySkin_Unchecked(object sender, RoutedEventArgs e)
        {
            viewModel.AddOrRemoveTextures("remove", "nightTerrorGraySkin");
        }

        private void TakiStockingsSkin_Checked(object sender, RoutedEventArgs e)
        {
            viewModel.AddOrRemoveTextures("add", "takiStockingsSkin");
        }

        private void TakiStockingsSkin_Unchecked(object sender, RoutedEventArgs e)
        {
            viewModel.AddOrRemoveTextures("remove", "takiStockingsSkin");
        }

    }




}
