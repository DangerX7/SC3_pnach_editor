using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.Primitives;
using NAudio.Gui;
using NAudio.Wave;
using OfficeOpenXml;
using SC3_pnach_editor.Services;
using SC3_pnach_editor.ViewModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Reflection;
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

namespace SC3_pnach_editor.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class CustomCharactersView : UserControl
    {
        CustomCharactersViewModel viewModel;

        private int currentIndex = 0;
        private bool soundOn = false;
        private Image _selectedSlot = null;
        private int _selectedSlotNumber = -1;

        public CustomCharactersView()
        {

            InitializeComponent();

            viewModel = new();

            this.DataContext = viewModel;



            SettingsClass.LoadData();


            customSound.Source = new Uri(@"D:\Danger\Mods And Others\ps2\Soulcalibur 3\WPF Build\Extras\Char_Creation_Bgm.mp3");
            customSound.Volume = 0.1;

            if (SettingsClass.CustomCharacter1 == "")
            {
                UpdateImageAndText("Slot1", null, null, null);
            }
            else
            {
                UpdateImageAndText("Slot1", null, SettingsClass.CustomCharacter1, 1);
            }

            if (SettingsClass.CustomCharacter2 == "")
            {
                UpdateImageAndText("Slot2", null, null, null);
            }
            else
            {
                UpdateImageAndText("Slot2", null, SettingsClass.CustomCharacter2, 2);
            }

            if (SettingsClass.CustomCharacter3 == "")
            {
                UpdateImageAndText("Slot3", null, null, null);
            }
            else
            {
                UpdateImageAndText("Slot3", null, SettingsClass.CustomCharacter3, 3);
            }

            if (SettingsClass.CustomCharacter4 == "")
            {
                UpdateImageAndText("Slot4", null, null, null);
            }
            else
            {
                UpdateImageAndText("Slot4", null, SettingsClass.CustomCharacter4, 4);
            }

            if (SettingsClass.CustomCharacter5 == "")
            {
                UpdateImageAndText("Slot5", null, null, null);
            }
            else
            {
                UpdateImageAndText("Slot5", null, SettingsClass.CustomCharacter5, 5);
            }

            if (SettingsClass.CustomCharacter6 == "")
            {
                UpdateImageAndText("Slot6", null, null, null);
            }
            else
            {
                UpdateImageAndText("Slot6", null, SettingsClass.CustomCharacter6, 6);
            }

            if (SettingsClass.CustomCharacter7 == "")
            {
                UpdateImageAndText("Slot7", null, null, null);
            }
            else
            {
                UpdateImageAndText("Slot7", null, SettingsClass.CustomCharacter7, 7);
            }

            if (SettingsClass.CustomCharacter8 == "")
            {
                UpdateImageAndText("Slot8", null, null, null);
            }
            else
            {
                UpdateImageAndText("Slot8", null, SettingsClass.CustomCharacter8, 8);
            }

            if (SettingsClass.CustomCharacter9 == "")
            {
                UpdateImageAndText("Slot9", null, null, null);
            }
            else
            {
                UpdateImageAndText("Slot9", null, SettingsClass.CustomCharacter9, 9);
            }

            if (SettingsClass.CustomCharacter10 == "")
            {
                UpdateImageAndText("Slot10", null, null, null);
            }
            else
            {
                UpdateImageAndText("Slot10", null, SettingsClass.CustomCharacter10, 10);
            }

            UpdateImageAndText("YuilinValues", null, null, null);
            UpdateImageAndText("LucaValues", null, null, null);
            UpdateImageAndText("LupiValues", null, null, null);
            UpdateImageAndText("NinaValues", null, null, null);
            UpdateImageAndText("ScorpionValues", null, null, null);
            UpdateImageAndText("BloodValues", null, null, null);
            UpdateImageAndText("SoruValues", null, null, null);
            UpdateImageAndText("SoniaValues", null, null, null);
            UpdateImageAndText("KOSMOSValues", null, null, null);
            UpdateImageAndText("TifaValues", null, null, null);

        }

        private void GoToMainPage_Click(object sender, RoutedEventArgs e)
        {
            SettingsClass.SaveData();
            viewModel.DisplayMainView();
        }

        private void MouseEnter(object sender, MouseEventArgs e)
        {
            string imageName = ((Image)sender).Name;

            currentIndex = 0;
            UpdateImageAndText(imageName, null, null, null);
        }
        private void UpdateImageAndText(string? btnName, int? slotSelected, string? charSelected, int? preselectSlot)
        {
            string[,] currentArray;
            string imageName = "";
            if (preselectSlot != null)
            {
                int index = Convert.ToInt32(charSelected);
                imageName = viewModel.CharListItem(index);
                currentArray = GetSelectedArray(imageName);
                imageName = currentArray[currentIndex, 3];
            }

            BitmapImage bitmap = new BitmapImage();

            if (imageName == "")
            {
                if (btnName != null)
                {
                    currentArray = GetSelectedArray(btnName);
                    imageName = currentArray[currentIndex, 3];
                }
                else
                {
                    currentArray = GetSelectedArray(charSelected);
                    imageName = currentArray[currentIndex, 3];
                }
            }
            else
            {
                currentArray = new string[0, 0];
            }

            bitmap.BeginInit();
            bitmap.UriSource = new Uri($"/Resources/{imageName}", UriKind.Relative);
            bitmap.EndInit();


            if (btnName != null && preselectSlot == null)
            {
                #region Text Config
                //Clean all text first
                CostumeTextBlock1.Text = "";
                CostumeTextBlock2.Text = "";
                SoulTextBlock1.Text = "";
                SoulTextBlock2.Text = "";


                CharNameTextBlock.Text = currentArray[currentIndex, 0];
                if (currentArray.GetLength(0) > 0)
                {
                    CostumeTextBlock1.Text = currentArray[0, 1];
                    CostumeTextBlock1.Foreground = Brushes.White;
                    SoulTextBlock1.Text = currentArray[0, 2];
                    SoulTextBlock1.Foreground = Brushes.White;
                }
                if (currentArray.GetLength(0) > 1)
                {
                    CostumeTextBlock2.Text = currentArray[1, 1];
                    CostumeTextBlock2.Foreground = Brushes.White;
                    SoulTextBlock2.Text = currentArray[1, 2];
                    SoulTextBlock2.Foreground = Brushes.White;
                }

                switch (currentIndex)
                {
                    case 0:
                        CostumeTextBlock1.Foreground = Brushes.Yellow;
                        SoulTextBlock1.Foreground = Brushes.Yellow;
                        viewModel.CharacterPortrait = "/Resources/" + currentArray[currentIndex, 6];
                        break;
                    case 1:
                        CostumeTextBlock2.Foreground = Brushes.Yellow;
                        SoulTextBlock2.Foreground = Brushes.Yellow;
                        viewModel.CharacterPortrait = "/Resources/" + currentArray[currentIndex, 6];
                        break;
                }
                #endregion
            }

            btnName = btnName ?? "Slot" + slotSelected;

            switch (btnName)
            {
                case "YuilinValues":
                    YuilinValues.Source = bitmap;
                    break;
                case "LucaValues":
                    LucaValues.Source = bitmap;
                    break;
                case "LupiValues":
                    LupiValues.Source = bitmap;
                    break;
                case "NinaValues":
                    NinaValues.Source = bitmap;
                    break;
                case "ScorpionValues":
                    ScorpionValues.Source = bitmap;
                    break;
                case "BloodValues":
                    BloodValues.Source = bitmap;
                    break;
                case "SoruValues":
                    SoruValues.Source = bitmap;
                    break;
                case "SoniaValues":
                    SoniaValues.Source = bitmap;
                    break;
                case "KOSMOSValues":
                    KOSMOSValues.Source = bitmap;
                    break;
                case "TifaValues":
                    TifaValues.Source = bitmap;
                    break;

                case "Slot1":
                    Slot1.Source = bitmap;
                    break;
                case "Slot2":
                    Slot2.Source = bitmap;
                    break;
                case "Slot3":
                    Slot3.Source = bitmap;
                    break;
                case "Slot4":
                    Slot4.Source = bitmap;
                    break;
                case "Slot5":
                    Slot5.Source = bitmap;
                    break;
                case "Slot6":
                    Slot6.Source = bitmap;
                    break;
                case "Slot7":
                    Slot7.Source = bitmap;
                    break;
                case "Slot8":
                    Slot8.Source = bitmap;
                    break;
                case "Slot9":
                    Slot9.Source = bitmap;
                    break;
                case "Slot10":
                    Slot10.Source = bitmap;
                    break;
            }

        }


        private string[,] GetSelectedArray(string imageName)
        {
            string[,] currentArray = viewModel.Empty;
            switch (imageName)
            {
                case "YuilinValues":
                    currentArray = viewModel.YuilinValues;
                    break;
                case "LucaValues":
                    currentArray = viewModel.LucaValues;
                    break;
                case "LupiValues":
                    currentArray = viewModel.LupiValues;
                    break;
                case "NinaValues":
                    currentArray = viewModel.NinaValues;
                    break;
                case "ScorpionValues":
                    currentArray = viewModel.ScorpionValues;
                    break;
                case "BloodValues":
                    currentArray = viewModel.BloodValues;
                    break;
                case "SoruValues":
                    currentArray = viewModel.SoruValues;
                    break;
                case "SoniaValues":
                    currentArray = viewModel.SoniaValues;
                    break;
                case "KOSMOSValues":
                    currentArray = viewModel.KOSMOSValues;
                    break;
                case "TifaValues":
                    currentArray = viewModel.TifaValues;
                    break;

                case "Slot1":
                    currentArray = viewModel.Slot1Values;
                    break;
                case "Slot2":
                    currentArray = viewModel.Slot2Values;
                    break;
                case "Slot3":
                    currentArray = viewModel.Slot3Values;
                    break;
                case "Slot4":
                    currentArray = viewModel.Slot4Values;
                    break;
                case "Slot5":
                    currentArray = viewModel.Slot5Values;
                    break;
                case "Slot6":
                    currentArray = viewModel.Slot6Values;
                    break;
                case "Slot7":
                    currentArray = viewModel.Slot7Values;
                    break;
                case "Slot8":
                    currentArray = viewModel.Slot8Values;
                    break;
                case "Slot9":
                    currentArray = viewModel.Slot9Values;
                    break;
                case "Slot10":
                    currentArray = viewModel.Slot10Values;
                    break;
            }
            return currentArray;
        }

        private void Slot_Click(object sender, MouseButtonEventArgs e)
        {
            // Convert sender to Image
            Image clickedImage = sender as Image;
            string slotName = clickedImage.Name;
            string slotNumberStr = new string(slotName.Where(char.IsDigit).ToArray());
            _selectedSlotNumber = Convert.ToInt32(slotNumberStr);

            // Deselect previously selected image
            if (_selectedSlot != null && _selectedSlot != clickedImage)
            {
                _selectedSlot.Opacity = 1.0; // reset previous image
            }

            // Toggle highlight for the clicked one
            if (_selectedSlot == clickedImage)
            {
                // Deselect if same clicked again
                clickedImage.Opacity = 1.0;
                _selectedSlot = null;
            }
            else
            {
                // Highlight the clicked image
                clickedImage.Opacity = 0.6;
                _selectedSlot = clickedImage;
            }

        }

        private void Character_Click(object sender, MouseButtonEventArgs e)
        {
            if (_selectedSlotNumber == -1)
            {
                MessageBox.Show("No slot selected yet.");
                return;
            }

            Image clickedImage = sender as Image;

            string imageName = "";
            if (clickedImage != null)
            {
                imageName = clickedImage.Name;
            }

            UpdateImageAndText(null, _selectedSlotNumber, imageName, null);

            string[,] currentArray = GetSelectedArray(imageName);
            string charIndex = currentArray[currentIndex, 4];

            switch (_selectedSlotNumber)
            {
                case 1:
                    SettingsClass.CustomCharacter1 = charIndex;
                    SettingsClass.SaveData();
                    break;
                case 2:
                    SettingsClass.CustomCharacter2 = charIndex;
                    SettingsClass.SaveData();
                    break;
                case 3:
                    SettingsClass.CustomCharacter3 = charIndex;
                    SettingsClass.SaveData();
                    break;
                case 4:
                    SettingsClass.CustomCharacter4 = charIndex;
                    SettingsClass.SaveData();
                    break;
                case 5:
                    SettingsClass.CustomCharacter5 = charIndex;
                    SettingsClass.SaveData();
                    break;
                case 6:
                    SettingsClass.CustomCharacter6 = charIndex;
                    SettingsClass.SaveData();
                    break;
                case 7:
                    SettingsClass.CustomCharacter7 = charIndex;
                    SettingsClass.SaveData();
                    break;
                case 8:
                    SettingsClass.CustomCharacter8 = charIndex;
                    SettingsClass.SaveData();
                    break;
                case 9:
                    SettingsClass.CustomCharacter9 = charIndex;
                    SettingsClass.SaveData();
                    break;
                case 10:
                    SettingsClass.CustomCharacter10 = charIndex;
                    SettingsClass.SaveData();
                    break;
            }

            string customCharacterPnachData = CreatePnach.GetCustomCharactersPnachCodes();

            File.WriteAllText(SettingsClass.codeFilePath, customCharacterPnachData, Encoding.UTF8);
        }

        private void ResetAll_Click(object sender, RoutedEventArgs e)
        {
            //Reset image slots
            UpdateImageAndText("Slot1", null, null, null);
            UpdateImageAndText("Slot2", null, null, null);
            UpdateImageAndText("Slot3", null, null, null);
            UpdateImageAndText("Slot4", null, null, null);
            UpdateImageAndText("Slot5", null, null, null);
            UpdateImageAndText("Slot6", null, null, null);
            UpdateImageAndText("Slot7", null, null, null);
            UpdateImageAndText("Slot8", null, null, null);
            UpdateImageAndText("Slot9", null, null, null);
            UpdateImageAndText("Slot10", null, null, null);

            //Reset setting data
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
            SettingsClass.SaveData();

            string customCharacterPnachData = CreatePnach.GetCustomCharactersPnachCodes();

            File.WriteAllText(SettingsClass.codeFilePath, customCharacterPnachData, Encoding.UTF8);

        }

        private void DumpHexData_Click(object sender, RoutedEventArgs e)
        {
            //1  2053FC60 - 2054034F
            //2  20540350 - 20540A3F
            //3  20540A40 - 2054112F
            //4  20541130 - 2054181F
            //5  20541820 - 20541F0F
            //6  20541F10 - 205425FF
            //7  20542600 - 20542CEF
            //8  20542CF0 - 205433DF
            //9  205433E0 - 20543ACF
            //10 20543AD0 - 205441BF

            MessageBoxResult result = MessageBox.Show(
                "Dump your character hex code in a text file, place it on desktop and name it hexInput.txt",
                "Hex Input Required",
                MessageBoxButton.OKCancel,
                MessageBoxImage.Information
            );

            if (result == MessageBoxResult.OK)
            {
                // Continue with your logic

                // Get Desktop path
                string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                string inputFile = System.IO.Path.Combine(desktopPath, "hexInput.txt");
                string outputFile = System.IO.Path.Combine(desktopPath, "pnachOutput.txt");

                if (!File.Exists(inputFile))
                {
                    MessageBox.Show("Input file not found on Desktop: hexInput.txt");
                    return;
                }

                // Read all tokens (split by spaces/newlines)
                string text = File.ReadAllText(inputFile);
                string[] tokens = text.Split(new[] { ' ', '\t', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);

                using (StreamWriter writer = new StreamWriter(outputFile))
                {
                    for (int i = 0; i < tokens.Length; i += 4)
                    {
                        // Take groups of 4 tokens at a time
                        var group = tokens.Skip(i).Take(4).ToArray();

                        // Reverse them
                        Array.Reverse(group);

                        // Join without spaces and write a new line
                        string outputLine = string.Join("", group);
                        writer.WriteLine(outputLine);
                    }
                }

                MessageBox.Show("✅ Conversion complete! File saved as pnachOutput.txt on Desktop.");
            }
            else
            {
                // Cancel the operation
            }


        }
    }



}
