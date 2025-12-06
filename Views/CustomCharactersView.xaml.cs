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
using System.Text.RegularExpressions;
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


            if (SettingsClass.SoundOn)
            {
                string soundPath = System.IO.Path.Combine(Directory.GetParent(SettingsClass.SurvivalPath)!.FullName,
                    @"Extras\Char_Creation_Bgm.mp3");
                customSound.Source = new Uri(soundPath);
                customSound.Volume = 0.1;
            }

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


            if (SettingsClass.CustomCharacter11 == "")
            {
                UpdateImageAndText("Slot11", null, null, null);
            }
            else
            {
                UpdateImageAndText("Slot11", null, SettingsClass.CustomCharacter11, 11);
            }

            if (SettingsClass.CustomCharacter12 == "")
            {
                UpdateImageAndText("Slot12", null, null, null);
            }
            else
            {
                UpdateImageAndText("Slot12", null, SettingsClass.CustomCharacter12, 12);
            }

            if (SettingsClass.CustomCharacter13 == "")
            {
                UpdateImageAndText("Slot13", null, null, null);
            }
            else
            {
                UpdateImageAndText("Slot13", null, SettingsClass.CustomCharacter13, 13);
            }

            if (SettingsClass.CustomCharacter14 == "")
            {
                UpdateImageAndText("Slot14", null, null, null);
            }
            else
            {
                UpdateImageAndText("Slot14", null, SettingsClass.CustomCharacter14, 14);
            }

            if (SettingsClass.CustomCharacter15 == "")
            {
                UpdateImageAndText("Slot15", null, null, null);
            }
            else
            {
                UpdateImageAndText("Slot15", null, SettingsClass.CustomCharacter15, 15);
            }

            if (SettingsClass.CustomCharacter16 == "")
            {
                UpdateImageAndText("Slot16", null, null, null);
            }
            else
            {
                UpdateImageAndText("Slot16", null, SettingsClass.CustomCharacter16, 16);
            }

            if (SettingsClass.CustomCharacter17 == "")
            {
                UpdateImageAndText("Slot17", null, null, null);
            }
            else
            {
                UpdateImageAndText("Slot17", null, SettingsClass.CustomCharacter17, 17);
            }

            if (SettingsClass.CustomCharacter18 == "")
            {
                UpdateImageAndText("Slot18", null, null, null);
            }
            else
            {
                UpdateImageAndText("Slot18", null, SettingsClass.CustomCharacter18, 18);
            }

            if (SettingsClass.CustomCharacter19 == "")
            {
                UpdateImageAndText("Slot19", null, null, null);
            }
            else
            {
                UpdateImageAndText("Slot19", null, SettingsClass.CustomCharacter19, 19);
            }

            if (SettingsClass.CustomCharacter20 == "")
            {
                UpdateImageAndText("Slot20", null, null, null);
            }
            else
            {
                UpdateImageAndText("Slot20", null, SettingsClass.CustomCharacter20, 20);
            }


            UpdateImageAndText("YuilinValues", null, null, null);
            UpdateImageAndText("LucaValues", null, null, null);
            UpdateImageAndText("LupiValues", null, null, null);
            UpdateImageAndText("NinaValues", null, null, null);
            UpdateImageAndText("ScorpionValues", null, null, null);
            UpdateImageAndText("CelestaValues", null, null, null);
            UpdateImageAndText("PoisonValues", null, null, null);
            UpdateImageAndText("SoniaValues", null, null, null);
            UpdateImageAndText("KOSMOSValues", null, null, null);
            UpdateImageAndText("TifaValues", null, null, null);

            UpdateImageAndText("BlackKnightValues", null, null, null);
            UpdateImageAndText("EurydiceValues", null, null, null);
            UpdateImageAndText("TsangValues", null, null, null);
            UpdateImageAndText("SheenaValues", null, null, null);
            UpdateImageAndText("DemetriusValues", null, null, null);
            UpdateImageAndText("JaniceValues", null, null, null);
            UpdateImageAndText("KitaValues", null, null, null);
            UpdateImageAndText("EileenValues", null, null, null);
            UpdateImageAndText("OrikValues", null, null, null);
            UpdateImageAndText("RosaValues", null, null, null);

            UpdateImageAndText("SoruValues", null, null, null);
            UpdateImageAndText("CecilValues", null, null, null);
            UpdateImageAndText("StellaValues", null, null, null);
            UpdateImageAndText("JilliannaValues", null, null, null);
            UpdateImageAndText("BloodValues", null, null, null);
            UpdateImageAndText("DaelkereValues", null, null, null);
            UpdateImageAndText("IrolValues", null, null, null);
            UpdateImageAndText("RoyValues", null, null, null);
            UpdateImageAndText("KokuenraValues", null, null, null);
            UpdateImageAndText("SpicaValues", null, null, null);

            UpdateImageAndText("DracoValues", null, null, null);
            UpdateImageAndText("UmiValues", null, null, null);
            UpdateImageAndText("EdgeMasterValues", null, null, null);
            UpdateImageAndText("MournfaerValues", null, null, null);
            UpdateImageAndText("VelikastrousValues", null, null, null);
            UpdateImageAndText("KaosValues", null, null, null);
            UpdateImageAndText("AkaraValues", null, null, null);
            UpdateImageAndText("CitrineValues", null, null, null);
            UpdateImageAndText("MariseValues", null, null, null);
            UpdateImageAndText("GrimReaperValues", null, null, null);

            UpdateImageAndText("LeonUzumakiValues", null, null, null);
            UpdateImageAndText("CherylValues", null, null, null);
            UpdateImageAndText("TheoHValues", null, null, null);
            UpdateImageAndText("ChimeraValues", null, null, null);
            UpdateImageAndText("FitzgeraldValues", null, null, null);
            UpdateImageAndText("RoanCascadeValues", null, null, null);
            UpdateImageAndText("SorenValues", null, null, null);
            UpdateImageAndText("BasiliskValues", null, null, null);
            UpdateImageAndText("ThymeValues", null, null, null);
            UpdateImageAndText("TheCalamityValues", null, null, null);

            UpdateImageAndText("ValcuaValues", null, null, null);
            UpdateImageAndText("AversaValues", null, null, null);
            UpdateImageAndText("EdgarValues", null, null, null);
            UpdateImageAndText("BlancheValues", null, null, null);
            UpdateImageAndText("HelenaValues", null, null, null);
            UpdateImageAndText("NicholasValues", null, null, null);
            UpdateImageAndText("GailValues", null, null, null);
            UpdateImageAndText("KatrinaValues", null, null, null);
            UpdateImageAndText("SaellumvValues", null, null, null);
            UpdateImageAndText("KronneValues", null, null, null);

            UpdateImageAndText("AkashanValues", null, null, null);
            UpdateImageAndText("ErnestValues", null, null, null);
            UpdateImageAndText("NokklingValues", null, null, null);
            UpdateImageAndText("RaitenValues", null, null, null);
            UpdateImageAndText("AdamValues", null, null, null);
            UpdateImageAndText("AlexanderValues", null, null, null);
            UpdateImageAndText("KhanateValues", null, null, null);
            UpdateImageAndText("SindrielValues", null, null, null);
            UpdateImageAndText("TristanValues", null, null, null);
            UpdateImageAndText("LongcastleValues", null, null, null);

            PreUpdateIcons();
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

            if (imageName.Contains("Slot"))
            {
                string selectedSlot = "";
                switch (imageName)
                {
                    case "Slot1":
                        selectedSlot = SettingsClass.CustomCharacter1;
                        break;
                    case "Slot2":
                        selectedSlot = SettingsClass.CustomCharacter2;
                        break;
                    case "Slot3":
                        selectedSlot = SettingsClass.CustomCharacter3;
                        break;
                    case "Slot4":
                        selectedSlot = SettingsClass.CustomCharacter4;
                        break;
                    case "Slot5":
                        selectedSlot = SettingsClass.CustomCharacter5;
                        break;
                    case "Slot6":
                        selectedSlot = SettingsClass.CustomCharacter6;
                        break;
                    case "Slot7":
                        selectedSlot = SettingsClass.CustomCharacter7;
                        break;
                    case "Slot8":
                        selectedSlot = SettingsClass.CustomCharacter8;
                        break;
                    case "Slot9":
                        selectedSlot = SettingsClass.CustomCharacter9;
                        break;
                    case "Slot10":
                        selectedSlot = SettingsClass.CustomCharacter10;
                        break;

                    case "Slot11":
                        selectedSlot = SettingsClass.CustomCharacter11;
                        break;
                    case "Slot12":
                        selectedSlot = SettingsClass.CustomCharacter12;
                        break;
                    case "Slot13":
                        selectedSlot = SettingsClass.CustomCharacter13;
                        break;
                    case "Slot14":
                        selectedSlot = SettingsClass.CustomCharacter14;
                        break;
                    case "Slot15":
                        selectedSlot = SettingsClass.CustomCharacter15;
                        break;
                    case "Slot16":
                        selectedSlot = SettingsClass.CustomCharacter16;
                        break;
                    case "Slot17":
                        selectedSlot = SettingsClass.CustomCharacter17;
                        break;
                    case "Slot18":
                        selectedSlot = SettingsClass.CustomCharacter18;
                        break;
                    case "Slot19":
                        selectedSlot = SettingsClass.CustomCharacter19;
                        break;
                    case "Slot20":
                        selectedSlot = SettingsClass.CustomCharacter20;
                        break;
                }

                if (selectedSlot != "")
                {
                    string removeLetter = Regex.Replace(selectedSlot, "[A-Za-z]", "");
                    int number = int.Parse(removeLetter);
                    string newImage = CustomCharactersViewModel.CharList[number - 1];

                    if (!string.IsNullOrEmpty(selectedSlot))
                    {
                        //for second costume
                        char lastChar = selectedSlot[selectedSlot.Length - 1];

                        if (char.IsDigit(lastChar))
                        {
                            currentIndex = 0;
                        }
                        else if (lastChar == 'B')
                        {
                            currentIndex = 1;
                        }
                    }

                    UpdateImageAndText(newImage, null, null, null);
                }
            }
            else
            {
                UpdateImageAndText(imageName, null, null, null);
            }
        }
        private void UpdateImageAndText(string? btnName, int? slotSelected, string? charSelected, int? preselectSlot)
        {
            string[,] currentArray;
            string imageName = "";
            if (preselectSlot != null)
            {
                string convert = Regex.Replace(charSelected, "[A-Za-z]", "");
                int index = Convert.ToInt32(convert);
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
                TextureTextBlock.Text = "";


                CharNameTextBlock.Text = currentArray[currentIndex, 0];
                if (currentArray.GetLength(0) > 0)
                {
                    CostumeTextBlock1.Text = currentArray[0, 1];
                    CostumeTextBlock1.Foreground = Brushes.White;
                    SoulTextBlock1.Text = currentArray[0, 2];
                    SoulTextBlock1.Foreground = Brushes.White;
                    if (!btnName.Contains("Slot"))
                    {
                        TextureTextBlock.Text = currentArray[0, 8];
                        TextureTextBlock.Foreground = Brushes.White;
                    }
                }
                if (currentArray.GetLength(0) > 1)
                {
                    CostumeTextBlock2.Text = currentArray[1, 1];
                    CostumeTextBlock2.Foreground = Brushes.White;
                    SoulTextBlock2.Text = currentArray[1, 2];
                    SoulTextBlock2.Foreground = Brushes.White;
                    if (!btnName.Contains("Slot"))
                    {
                        TextureTextBlock.Text = currentArray[1, 8];
                        TextureTextBlock.Foreground = Brushes.White;
                    }
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
                case "CelestaValues":
                    CelestaValues.Source = bitmap;
                    break;
                case "PoisonValues":
                    PoisonValues.Source = bitmap;
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

                case "BlackKnightValues":
                    BlackKnightValues.Source = bitmap;
                    break;
                case "EurydiceValues":
                    EurydiceValues.Source = bitmap;
                    break;
                case "TsangValues":
                    TsangValues.Source = bitmap;
                    break;
                case "SheenaValues":
                    SheenaValues.Source = bitmap;
                    break;
                case "DemetriusValues":
                    DemetriusValues.Source = bitmap;
                    break;
                case "JaniceValues":
                    JaniceValues.Source = bitmap;
                    break;
                case "KitaValues":
                    KitaValues.Source = bitmap;
                    break;
                case "EileenValues":
                    EileenValues.Source = bitmap;
                    break;
                case "OrikValues":
                    OrikValues.Source = bitmap;
                    break;
                case "RosaValues":
                    RosaValues.Source = bitmap;
                    break;

                case "SoruValues":
                    SoruValues.Source = bitmap;
                    break;
                case "CecilValues":
                    CecilValues.Source = bitmap;
                    break;
                case "StellaValues":
                    StellaValues.Source = bitmap;
                    break;
                case "JilliannaValues":
                    JilliannaValues.Source = bitmap;
                    break;
                case "BloodValues":
                    BloodValues.Source = bitmap;
                    break;
                case "DaelkereValues":
                    DaelkereValues.Source = bitmap;
                    break;
                case "IrolValues":
                    IrolValues.Source = bitmap;
                    break;
                case "RoyValues":
                    RoyValues.Source = bitmap;
                    break;
                case "KokuenraValues":
                    KokuenraValues.Source = bitmap;
                    break;
                case "SpicaValues":
                    SpicaValues.Source = bitmap;
                    break;

                case "DracoValues":
                    DracoValues.Source = bitmap;
                    break;
                case "UmiValues":
                    UmiValues.Source = bitmap;
                    break;
                case "EdgeMasterValues":
                    EdgeMasterValues.Source = bitmap;
                    break;
                case "MournfaerValues":
                    MournfaerValues.Source = bitmap;
                    break;
                case "VelikastrousValues":
                    VelikastrousValues.Source = bitmap;
                    break;
                case "KaosValues":
                    KaosValues.Source = bitmap;
                    break;
                case "AkaraValues":
                    AkaraValues.Source = bitmap;
                    break;
                case "CitrineValues":
                    CitrineValues.Source = bitmap;
                    break;
                case "MariseValues":
                    MariseValues.Source = bitmap;
                    break;
                case "GrimReaperValues":
                    GrimReaperValues.Source = bitmap;
                    break;

                case "LeonUzumakiValues":
                    LeonUzumakiValues.Source = bitmap;
                    break;
                case "CherylValues":
                    CherylValues.Source = bitmap;
                    break;
                case "TheoHValues":
                    TheoHValues.Source = bitmap;
                    break;
                case "ChimeraValues":
                    ChimeraValues.Source = bitmap;
                    break;
                case "FitzgeraldValues":
                    FitzgeraldValues.Source = bitmap;
                    break;
                case "RoanCascadeValues":
                    RoanCascadeValues.Source = bitmap;
                    break;
                case "SorenValues":
                    SorenValues.Source = bitmap;
                    break;
                case "BasiliskValues":
                    BasiliskValues.Source = bitmap;
                    break;
                case "ThymeValues":
                    ThymeValues.Source = bitmap;
                    break;
                case "TheCalamityValues":
                    TheCalamityValues.Source = bitmap;
                    break;

                case "ValcuaValues":
                    ValcuaValues.Source = bitmap;
                    break;
                case "AversaValues":
                    AversaValues.Source = bitmap;
                    break;
                case "EdgarValues":
                    EdgarValues.Source = bitmap;
                    break;
                case "BlancheValues":
                    BlancheValues.Source = bitmap;
                    break;
                case "HelenaValues":
                    HelenaValues.Source = bitmap;
                    break;
                case "NicholasValues":
                    NicholasValues.Source = bitmap;
                    break;
                case "GailValues":
                    GailValues.Source = bitmap;
                    break;
                case "KatrinaValues":
                    KatrinaValues.Source = bitmap;
                    break;
                case "SaellumvValues":
                    SaellumvValues.Source = bitmap;
                    break;
                case "KronneValues":
                    KronneValues.Source = bitmap;
                    break;

                case "AkashanValues":
                    AkashanValues.Source = bitmap;
                    break;
                case "ErnestValues":
                    ErnestValues.Source = bitmap;
                    break;
                case "NokklingValues":
                    NokklingValues.Source = bitmap;
                    break;
                case "RaitenValues":
                    RaitenValues.Source = bitmap;
                    break;
                case "AdamValues":
                    AdamValues.Source = bitmap;
                    break;
                case "AlexanderValues":
                    AlexanderValues.Source = bitmap;
                    break;
                case "KhanateValues":
                    KhanateValues.Source = bitmap;
                    break;
                case "SindrielValues":
                    SindrielValues.Source = bitmap;
                    break;
                case "TristanValues":
                    TristanValues.Source = bitmap;
                    break;
                case "LongcastleValues":
                    LongcastleValues.Source = bitmap;
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


                case "Slot11":
                    Slot11.Source = bitmap;
                    break;
                case "Slot12":
                    Slot12.Source = bitmap;
                    break;
                case "Slot13":
                    Slot13.Source = bitmap;
                    break;
                case "Slot14":
                    Slot14.Source = bitmap;
                    break;
                case "Slot15":
                    Slot15.Source = bitmap;
                    break;
                case "Slot16":
                    Slot16.Source = bitmap;
                    break;
                case "Slot17":
                    Slot17.Source = bitmap;
                    break;
                case "Slot18":
                    Slot18.Source = bitmap;
                    break;
                case "Slot19":
                    Slot19.Source = bitmap;
                    break;
                case "Slot20":
                    Slot20.Source = bitmap;
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
                case "CelestaValues":
                    currentArray = viewModel.CelestaValues;
                    break;
                case "PoisonValues":
                    currentArray = viewModel.PoisonValues;
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

                case "BlackKnightValues":
                    currentArray = viewModel.BlackKnightValues;
                    break;
                case "EurydiceValues":
                    currentArray = viewModel.EurydiceValues;
                    break;
                case "TsangValues":
                    currentArray = viewModel.TsangValues;
                    break;
                case "SheenaValues":
                    currentArray = viewModel.SheenaValues;
                    break;
                case "DemetriusValues":
                    currentArray = viewModel.DemetriusValues;
                    break;
                case "JaniceValues":
                    currentArray = viewModel.JaniceValues;
                    break;
                case "KitaValues":
                    currentArray = viewModel.KitaValues;
                    break;
                case "EileenValues":
                    currentArray = viewModel.EileenValues;
                    break;
                case "OrikValues":
                    currentArray = viewModel.OrikValues;
                    break;
                case "RosaValues":
                    currentArray = viewModel.RosaValues;
                    break;

                case "SoruValues":
                    currentArray = viewModel.SoruValues;
                    break;
                case "CecilValues":
                    currentArray = viewModel.CecilValues;
                    break;
                case "StellaValues":
                    currentArray = viewModel.StellaValues;
                    break;
                case "JilliannaValues":
                    currentArray = viewModel.JilliannaValues;
                    break;
                case "BloodValues":
                    currentArray = viewModel.BloodValues;
                    break;
                case "DaelkereValues":
                    currentArray = viewModel.DaelkereValues;
                    break;
                case "IrolValues":
                    currentArray = viewModel.IrolValues;
                    break;
                case "RoyValues":
                    currentArray = viewModel.RoyValues;
                    break;
                case "KokuenraValues":
                    currentArray = viewModel.KokuenraValues;
                    break;
                case "SpicaValues":
                    currentArray = viewModel.SpicaValues;
                    break;

                case "DracoValues":
                    currentArray = viewModel.DracoValues;
                    break;
                case "UmiValues":
                    currentArray = viewModel.UmiValues;
                    break;
                case "EdgeMasterValues":
                    currentArray = viewModel.EdgeMasterValues;
                    break;
                case "MournfaerValues":
                    currentArray = viewModel.MournfaerValues;
                    break;
                case "VelikastrousValues":
                    currentArray = viewModel.VelikastrousValues;
                    break;
                case "KaosValues":
                    currentArray = viewModel.KaosValues;
                    break;
                case "AkaraValues":
                    currentArray = viewModel.AkaraValues;
                    break;
                case "CitrineValues":
                    currentArray = viewModel.CitrineValues;
                    break;
                case "MariseValues":
                    currentArray = viewModel.MariseValues;
                    break;
                case "GrimReaperValues":
                    currentArray = viewModel.GrimReaperValues;
                    break;

                case "LeonUzumakiValues":
                    currentArray = viewModel.LeonUzumakiValues;
                    break;
                case "CherylValues":
                    currentArray = viewModel.CherylValues;
                    break;
                case "TheoHValues":
                    currentArray = viewModel.TheoHValues;
                    break;
                case "ChimeraValues":
                    currentArray = viewModel.ChimeraValues;
                    break;
                case "FitzgeraldValues":
                    currentArray = viewModel.FitzgeraldValues;
                    break;
                case "RoanCascadeValues":
                    currentArray = viewModel.RoanCascadeValues;
                    break;
                case "SorenValues":
                    currentArray = viewModel.SorenValues;
                    break;
                case "BasiliskValues":
                    currentArray = viewModel.BasiliskValues;
                    break;
                case "ThymeValues":
                    currentArray = viewModel.ThymeValues;
                    break;
                case "TheCalamityValues":
                    currentArray = viewModel.TheCalamityValues;
                    break;

                case "ValcuaValues":
                    currentArray = viewModel.ValcuaValues;
                    break;
                case "AversaValues":
                    currentArray = viewModel.AversaValues;
                    break;
                case "EdgarValues":
                    currentArray = viewModel.EdgarValues;
                    break;
                case "BlancheValues":
                    currentArray = viewModel.BlancheValues;
                    break;
                case "HelenaValues":
                    currentArray = viewModel.HelenaValues;
                    break;
                case "NicholasValues":
                    currentArray = viewModel.NicholasValues;
                    break;
                case "GailValues":
                    currentArray = viewModel.GailValues;
                    break;
                case "KatrinaValues":
                    currentArray = viewModel.KatrinaValues;
                    break;
                case "SaellumvValues":
                    currentArray = viewModel.SaellumvValues;
                    break;
                case "KronneValues":
                    currentArray = viewModel.KronneValues;
                    break;

                case "AkashanValues":
                    currentArray = viewModel.AkashanValues;
                    break;
                case "ErnestValues":
                    currentArray = viewModel.ErnestValues;
                    break;
                case "NokklingValues":
                    currentArray = viewModel.NokklingValues;
                    break;
                case "RaitenValues":
                    currentArray = viewModel.RaitenValues;
                    break;
                case "AdamValues":
                    currentArray = viewModel.AdamValues;
                    break;
                case "AlexanderValues":
                    currentArray = viewModel.AlexanderValues;
                    break;
                case "KhanateValues":
                    currentArray = viewModel.KhanateValues;
                    break;
                case "SindrielValues":
                    currentArray = viewModel.SindrielValues;
                    break;
                case "TristanValues":
                    currentArray = viewModel.TristanValues;
                    break;
                case "LongcastleValues":
                    currentArray = viewModel.LongcastleValues;
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


                case "Slot11":
                    currentArray = viewModel.Slot11Values;
                    break;
                case "Slot12":
                    currentArray = viewModel.Slot12Values;
                    break;
                case "Slot13":
                    currentArray = viewModel.Slot13Values;
                    break;
                case "Slot14":
                    currentArray = viewModel.Slot14Values;
                    break;
                case "Slot15":
                    currentArray = viewModel.Slot15Values;
                    break;
                case "Slot16":
                    currentArray = viewModel.Slot16Values;
                    break;
                case "Slot17":
                    currentArray = viewModel.Slot17Values;
                    break;
                case "Slot18":
                    currentArray = viewModel.Slot18Values;
                    break;
                case "Slot19":
                    currentArray = viewModel.Slot19Values;
                    break;
                case "Slot20":
                    currentArray = viewModel.Slot20Values;
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
            string textureToCopy = "";
            string applyTexture = currentArray[currentIndex, 8];
            if (applyTexture == "Yes")
            {
                textureToCopy = currentArray[currentIndex, 0];
            }

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

                case 11:
                    SettingsClass.CustomCharacter11 = charIndex;
                    SettingsClass.SaveData();
                    break;
                case 12:
                    SettingsClass.CustomCharacter12 = charIndex;
                    SettingsClass.SaveData();
                    break;
                case 13:
                    SettingsClass.CustomCharacter13 = charIndex;
                    SettingsClass.SaveData();
                    break;
                case 14:
                    SettingsClass.CustomCharacter14 = charIndex;
                    SettingsClass.SaveData();
                    break;
                case 15:
                    SettingsClass.CustomCharacter15 = charIndex;
                    SettingsClass.SaveData();
                    break;
                case 16:
                    SettingsClass.CustomCharacter16 = charIndex;
                    SettingsClass.SaveData();
                    break;
                case 17:
                    SettingsClass.CustomCharacter17 = charIndex;
                    SettingsClass.SaveData();
                    break;
                case 18:
                    SettingsClass.CustomCharacter18 = charIndex;
                    SettingsClass.SaveData();
                    break;
                case 19:
                    SettingsClass.CustomCharacter19 = charIndex;
                    SettingsClass.SaveData();
                    break;
                case 20:
                    SettingsClass.CustomCharacter20 = charIndex;
                    SettingsClass.SaveData();
                    break;
            }

            string customCharacterPnachData = CreatePnach.GetCustomCharactersPnachCodes(textureToCopy);

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

            UpdateImageAndText("Slot11", null, null, null);
            UpdateImageAndText("Slot12", null, null, null);
            UpdateImageAndText("Slot13", null, null, null);
            UpdateImageAndText("Slot14", null, null, null);
            UpdateImageAndText("Slot15", null, null, null);
            UpdateImageAndText("Slot16", null, null, null);
            UpdateImageAndText("Slot17", null, null, null);
            UpdateImageAndText("Slot18", null, null, null);
            UpdateImageAndText("Slot19", null, null, null);
            UpdateImageAndText("Slot20", null, null, null);

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
            SettingsClass.SaveData();

            string customCharacterPnachData = CreatePnach.GetCustomCharactersPnachCodes("RESET");

            File.WriteAllText(SettingsClass.codeFilePath, customCharacterPnachData, Encoding.UTF8);

        }

        private void DumpHexData_Click(object sender, RoutedEventArgs e)
        {
            #region notes
            //USA
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

            //EUROPE
            //1  20540C90 - 2054137F
            //2  20541380 - 20541A6F
            //3  20541A70 - 2054215F
            //4  20542160 - 2054284F
            //5  20542850 - 20542F3F
            //6  20542F40 - 2054362F
            //7  20543630 - 20543D1F
            //8  20543D20 - 2054440F
            //9  20544410 - 20544AFF
            //10 20544B00 - 205451EF

            //USA slot 2
            //1  20C32280 - 20C3296F
            //2  20C32970 - 20C3305F
            //3  20C33060 - 20C3374F
            //4  20C33750 - 20C33E3F
            //5  20C33E40 - 20C3452F
            //6  20C34530 - 20C34C1F
            //7  20C34C20 - 20C3530F
            //8  20C35310 - 20C359FF
            //9  20C35A00 - 20C360EF
            //10 20C360F0 - 20C367DF

            //TRUE START OF slot 1
            //1  20C2D520 - 20C2DC0F
            //2  20C2DC10 - 20C2E2FF
            //3  20C2E300 - 20C2E9EF
            //4  20C2E9F0 - 20C2F0DF
            //5  20C2F0E0 - 20C2F7CF
            //6  20C2F7D0 - 20C2FEBF
            //7  20C2FEC0 - 20C305AF
            //8  20C305B0 - 20C30C9F
            //9  20C30CA0 - 20C3138F
            //10 20C31390 - 20C31A7F

            //add 6F0

            //Cots replace

            //Customs
            //1  20C0F000 - 20C0F6EF
            //2  20C0F6F0 - 20C0FDDF
            //3  20C0FDE0 - 20C104CF
            //4  20C104D0 - 20C10BBF
            //5  20C10BC0 - 20C112AF
            //6  20C112B0 - 20C1199F
            //7  20C119A0 - 20C1208F
            //8  20C12090 - 20C1277F
            //9  20C12780 - 20C12E6F
            //10 20C12E70 - 20C1355F

            //Originals
            //20C13560-20C2135F
            //Abelia
            //Abelia
            //Abelia
            //Girardot
            //Aeneas
            //Aeneas
            //Eurydice
            //Eurydice
            //Jinkai
            //Jinkai
            //Xiaoxin
            //Xiaoxin
            //Meiga
            //Meiga
            //Kanon
            //Kanon
            //Ailian
            //Ailian
            //Leraje
            //Leraje
            //Rudiger
            //Feofan
            //Tina
            //Yuilin
            //Luca
            //Luna
            //Aege
            //Heal-Do
            //Elua
            //Lupi

            #endregion

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


        private void ImageControl_MouseWheel(object sender, MouseWheelEventArgs e)
        {
            string imageName = ((Image)sender).Name;
            string[,] currentArray = GetSelectedArray(imageName);

            if (e.Delta > 0)
            {
                // Scroll down
                currentIndex = (currentIndex - 1 + currentArray.GetLength(0)) % currentArray.GetLength(0);
            }
            else
            {
                // Scroll up
                currentIndex = (currentIndex + 1) % currentArray.GetLength(0);
            }

            UpdateImageAndText(imageName, null, null, null);
        }

        private void Slot1_Click(object sender, MouseButtonEventArgs e)
        {
            string lastOption = SettingsClass.Slot1Type;
            if (lastOption == "")
            {
                lastOption = "Memory Card 1";
            }
            string option = GetNewOption(lastOption, 1);

            //MessageBox.Show("Slot change to: " + option);
            SettingsClass.Slot1Type = option;

            string customCharacterPnachData = CreatePnach.GetCustomCharactersPnachCodes("");
            File.WriteAllText(SettingsClass.codeFilePath, customCharacterPnachData, Encoding.UTF8);

            SettingsClass.SaveData();
        }

        private void Slot2_Click(object sender, MouseButtonEventArgs e)
        {
            string lastOption = SettingsClass.Slot2Type;
            if (lastOption == "")
            {
                lastOption = "Memory Card 2";
            }
            string option = GetNewOption(lastOption, 2);

            //MessageBox.Show("Slot change to: " + option);
            SettingsClass.Slot2Type = option;

            string customCharacterPnachData = CreatePnach.GetCustomCharactersPnachCodes("");
            File.WriteAllText(SettingsClass.codeFilePath, customCharacterPnachData, Encoding.UTF8);

            SettingsClass.SaveData();
        }

        private string GetNewOption(string lastOption, int slotNumber)
        {
            string option = "";
            switch (lastOption)
            {
                case "Memory Card 1":
                    option = "Memory Card 2";
                    if (slotNumber == 1)
                    {
                        MemCard.Source = new BitmapImage(new Uri("/Resources/MemoryIcon2.png", UriKind.Relative));
                    }
                    else if (slotNumber == 2)
                    {
                        MemCard2.Source = new BitmapImage(new Uri("/Resources/MemoryIcon2.png", UriKind.Relative));
                    }
                    break;
                case "Memory Card 2":
                    option = "Character Creation Menu";
                    if (slotNumber == 1)
                    {
                        MemCard.Source = new BitmapImage(new Uri("/Resources/MemoryIconX.png", UriKind.Relative));
                    }
                    else if (slotNumber == 2)
                    {
                        MemCard2.Source = new BitmapImage(new Uri("/Resources/MemoryIconX.png", UriKind.Relative));
                    }
                    break;
                case "Character Creation Menu":
                    option = "Cots Mode";
                    if (slotNumber == 1)
                    {
                        MemCard.Source = new BitmapImage(new Uri("/Resources/MemoryIconY.png", UriKind.Relative));
                    }
                    else if (slotNumber == 2)
                    {
                        MemCard2.Source = new BitmapImage(new Uri("/Resources/MemoryIconY.png", UriKind.Relative));
                    }
                    break;
                case "Cots Mode":
                    option = "Memory Card 1";
                    if (slotNumber == 1)
                    {
                        MemCard.Source = new BitmapImage(new Uri("/Resources/MemoryIcon.png", UriKind.Relative));
                    }
                    else if (slotNumber == 2)
                    {
                        MemCard2.Source = new BitmapImage(new Uri("/Resources/MemoryIcon.png", UriKind.Relative));
                    }
                    break;
            }
            return option;
        }

        private void PreUpdateIcons()
        {
            switch (SettingsClass.Slot1Type)
            {
                case "Memory Card 1":
                    MemCard.Source = new BitmapImage(new Uri("/Resources/MemoryIcon.png", UriKind.Relative));
                    break;
                case "Memory Card 2":
                    MemCard.Source = new BitmapImage(new Uri("/Resources/MemoryIcon2.png", UriKind.Relative));
                    break;
                case "Character Creation Menu":
                    MemCard.Source = new BitmapImage(new Uri("/Resources/MemoryIconX.png", UriKind.Relative));
                    break;
                case "Cots Mode":
                    MemCard.Source = new BitmapImage(new Uri("/Resources/MemoryIconY.png", UriKind.Relative));
                    break;
            }
            switch (SettingsClass.Slot2Type)
            {
                case "Memory Card 1":
                    MemCard2.Source = new BitmapImage(new Uri("/Resources/MemoryIcon.png", UriKind.Relative));
                    break;
                case "Memory Card 2":
                    MemCard2.Source = new BitmapImage(new Uri("/Resources/MemoryIcon2.png", UriKind.Relative));
                    break;
                case "Character Creation Menu":
                    MemCard2.Source = new BitmapImage(new Uri("/Resources/MemoryIconX.png", UriKind.Relative));
                    break;
                case "Cots Mode":
                    MemCard2.Source = new BitmapImage(new Uri("/Resources/MemoryIconY.png", UriKind.Relative));
                    break;
            }
        }

        private void Slot_Clear(object sender, MouseButtonEventArgs e)
        {
            // Convert sender to Image
            Image clickedImage = sender as Image;
            string slotName = clickedImage.Name;
            string slotNumberStr = new string(slotName.Where(char.IsDigit).ToArray());
            _selectedSlotNumber = Convert.ToInt32(slotNumberStr);
            currentIndex = 0;

            switch (_selectedSlotNumber)
            {
                case 1:
                    UpdateImageAndText("Slot1", null, null, null);
                    SettingsClass.CustomCharacter1 = "";
                    break;
                case 2:
                    UpdateImageAndText("Slot2", null, null, null);
                    SettingsClass.CustomCharacter2 = "";
                    break;
                case 3:
                    UpdateImageAndText("Slot3", null, null, null);
                    SettingsClass.CustomCharacter3 = "";
                    break;
                case 4:
                    UpdateImageAndText("Slot4", null, null, null);
                    SettingsClass.CustomCharacter4 = "";
                    break;
                case 5:
                    UpdateImageAndText("Slot5", null, null, null);
                    SettingsClass.CustomCharacter5 = "";
                    break;
                case 6:
                    UpdateImageAndText("Slot6", null, null, null);
                    SettingsClass.CustomCharacter6 = "";
                    break;
                case 7:
                    UpdateImageAndText("Slot7", null, null, null);
                    SettingsClass.CustomCharacter7 = "";
                    break;
                case 8:
                    UpdateImageAndText("Slot8", null, null, null);
                    SettingsClass.CustomCharacter8 = "";
                    break;
                case 9:
                    UpdateImageAndText("Slot9", null, null, null);
                    SettingsClass.CustomCharacter9 = "";
                    break;
                case 10:
                    UpdateImageAndText("Slot10", null, null, null);
                    SettingsClass.CustomCharacter10 = "";
                    break;

                case 11:
                    UpdateImageAndText("Slot11", null, null, null);
                    SettingsClass.CustomCharacter11 = "";
                    break;
                case 12:
                    UpdateImageAndText("Slot12", null, null, null);
                    SettingsClass.CustomCharacter12 = "";
                    break;
                case 13:
                    UpdateImageAndText("Slot13", null, null, null);
                    SettingsClass.CustomCharacter13 = "";
                    break;
                case 14:
                    UpdateImageAndText("Slot14", null, null, null);
                    SettingsClass.CustomCharacter14 = "";
                    break;
                case 15:
                    UpdateImageAndText("Slot15", null, null, null);
                    SettingsClass.CustomCharacter15 = "";
                    break;
                case 16:
                    UpdateImageAndText("Slot16", null, null, null);
                    SettingsClass.CustomCharacter16 = "";
                    break;
                case 17:
                    UpdateImageAndText("Slot17", null, null, null);
                    SettingsClass.CustomCharacter17 = "";
                    break;
                case 18:
                    UpdateImageAndText("Slot18", null, null, null);
                    SettingsClass.CustomCharacter18 = "";
                    break;
                case 19:
                    UpdateImageAndText("Slot19", null, null, null);
                    SettingsClass.CustomCharacter19 = "";
                    break;
                case 20:
                    UpdateImageAndText("Slot20", null, null, null);
                    SettingsClass.CustomCharacter20 = "";
                    break;
            }

            SettingsClass.SaveData();

            string customCharacterPnachData = CreatePnach.GetCustomCharactersPnachCodes("RESET");

            File.WriteAllText(SettingsClass.codeFilePath, customCharacterPnachData, Encoding.UTF8);
        }
    }



}
