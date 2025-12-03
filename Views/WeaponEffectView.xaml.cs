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
    public partial class WeaponEffectView : UserControl
    {
        WeaponEffectViewModel viewModel;
        public WeaponEffectView()
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


            slider_1.Value = SettingsClass.WpnEffect1;
            slider_2.Value = SettingsClass.WpnEffect2;
            slider_3.Value = SettingsClass.WpnEffect3;
            slider_4.Value = SettingsClass.WpnEffect4;
            slider_5.Value = SettingsClass.WpnEffect5;
            slider_6.Value = SettingsClass.WpnEffect6;
            slider_7.Value = SettingsClass.WpnEffect7;
            slider_8.Value = SettingsClass.WpnEffect8;
            slider_9.Value = SettingsClass.WpnEffect9;
            slider_10.Value = SettingsClass.WpnEffect10;
            slider_11.Value = SettingsClass.WpnEffect11;
            slider_12.Value = SettingsClass.WpnEffect12;
            slider_13.Value = SettingsClass.WpnEffect13;
            slider_14.Value = SettingsClass.WpnEffect14;
            slider_15.Value = SettingsClass.WpnEffect15;
            slider_16.Value = SettingsClass.WpnEffect16;
            slider_17.Value = SettingsClass.WpnEffect17;
            slider_18.Value = SettingsClass.WpnEffect18;

            slider_1.ValueChanged += ValueSlider_ValueChanged;
            slider_2.ValueChanged += ValueSlider_ValueChanged;
            slider_3.ValueChanged += ValueSlider_ValueChanged;
            slider_4.ValueChanged += ValueSlider_ValueChanged;
            slider_5.ValueChanged += ValueSlider_ValueChanged;
            slider_6.ValueChanged += ValueSlider_ValueChanged;
            slider_7.ValueChanged += ValueSlider_ValueChanged;
            slider_8.ValueChanged += ValueSlider_ValueChanged;
            slider_9.ValueChanged += ValueSlider_ValueChanged;
            slider_10.ValueChanged += ValueSlider_ValueChanged;
            slider_11.ValueChanged += ValueSlider_ValueChanged;
            slider_12.ValueChanged += ValueSlider_ValueChanged;
            slider_13.ValueChanged += ValueSlider_ValueChanged;
            slider_14.ValueChanged += ValueSlider_ValueChanged;
            slider_15.ValueChanged += ValueSlider_ValueChanged;
            slider_16.ValueChanged += ValueSlider_ValueChanged;
            slider_17.ValueChanged += ValueSlider_ValueChanged;
            slider_18.ValueChanged += ValueSlider_ValueChanged;
        }


        private void ValueSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            // Handle the value change here
            double sliderValue_1 = slider_1.Value;
            double sliderValue_2 = slider_2.Value;
            double sliderValue_3 = slider_3.Value;
            double sliderValue_4 = slider_4.Value;
            double sliderValue_5 = slider_5.Value;
            double sliderValue_6 = slider_6.Value;
            double sliderValue_7 = slider_7.Value;
            double sliderValue_8 = slider_8.Value;
            double sliderValue_9 = slider_9.Value;
            double sliderValue_10 = slider_10.Value;
            double sliderValue_11 = slider_11.Value;
            double sliderValue_12 = slider_12.Value;
            double sliderValue_13 = slider_13.Value;
            double sliderValue_14 = slider_14.Value;
            double sliderValue_15 = slider_15.Value;
            double sliderValue_16 = slider_16.Value;
            double sliderValue_17 = slider_17.Value;
            double sliderValue_18 = slider_18.Value;
        }

        private void GoToMainPage_Click(object sender, RoutedEventArgs e)
        {
            SettingsClass.WpnEffect1 = Convert.ToInt32(slider_1.Value);
            SettingsClass.WpnEffect2 = Convert.ToInt32(slider_2.Value);
            SettingsClass.WpnEffect3 = Convert.ToInt32(slider_3.Value);
            SettingsClass.WpnEffect4 = Convert.ToInt32(slider_4.Value);
            SettingsClass.WpnEffect5 = Convert.ToInt32(slider_5.Value);
            SettingsClass.WpnEffect6 = Convert.ToInt32(slider_6.Value);
            SettingsClass.WpnEffect7 = Convert.ToInt32(slider_7.Value);
            SettingsClass.WpnEffect8 = Convert.ToInt32(slider_8.Value);
            SettingsClass.WpnEffect9 = Convert.ToInt32(slider_9.Value);
            SettingsClass.WpnEffect10 = Convert.ToInt32(slider_10.Value);
            SettingsClass.WpnEffect11 = Convert.ToInt32(slider_11.Value);
            SettingsClass.WpnEffect12 = Convert.ToInt32(slider_12.Value);
            SettingsClass.WpnEffect13 = Convert.ToInt32(slider_13.Value);
            SettingsClass.WpnEffect14 = Convert.ToInt32(slider_14.Value);
            SettingsClass.WpnEffect15 = Convert.ToInt32(slider_15.Value);
            SettingsClass.WpnEffect16 = Convert.ToInt32(slider_16.Value);
            SettingsClass.WpnEffect17 = Convert.ToInt32(slider_17.Value);
            SettingsClass.WpnEffect18 = Convert.ToInt32(slider_18.Value);

            SettingsClass.SaveData();
            viewModel.DisplayMainView();
        }

        private void ResetToDefault_Click(object sender, RoutedEventArgs e)
        {
            slider_1.Value  = 0;
            slider_2.Value  = 0;
            slider_3.Value  = 0;
            slider_4.Value  = 0;
            slider_5.Value  = 0;
            slider_6.Value  = 0;
            slider_7.Value  = 0;
            slider_8.Value  = 0;
            slider_9.Value  = 0;
            slider_10.Value = 0;
            slider_11.Value = 0;
            slider_12.Value = 0;
            slider_13.Value = 0;
            slider_14.Value = 0;
            slider_15.Value = 0;
            slider_16.Value = 0;
            slider_17.Value = 0;
            slider_18.Value = 0;
        }
    }




}
