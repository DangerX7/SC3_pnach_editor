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
using System.Reflection;

namespace SC3_pnach_editor.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class CharactersView : UserControl
    {
        CharactersViewModel viewModel;

        private int currentIndex = 0;
        private bool soundOn = false;
        public CharactersView()
        {

            InitializeComponent();

            viewModel = new();

            this.DataContext = viewModel;


            SettingsClass.LoadData();

            string test = SettingsClass.CharacterP1;

            if (SettingsClass.SoundOn)
            {
                string soundPath = System.IO.Path.Combine(Directory.GetParent(SettingsClass.SurvivalPath)!.FullName,
                    @"Extras\History_Beckons.mp3");
                customSound.Source = new Uri(soundPath);
                customSound.Volume = 0.1;
            }

            soundOn = true;
            viewModel.SoundButton = "/Resources/SoundOn.png";

            #region Initialization
            UpdateImageAndText("MitsurugiValues");
            UpdateImageAndText("SeongMinaValues");
            UpdateImageAndText("TakiValues");
            UpdateImageAndText("MaxiValues");
            UpdateImageAndText("VoldoValues");
            UpdateImageAndText("SophitiaValues");
            UpdateImageAndText("SiegfriedValues");
            UpdateImageAndText("RockValues");
            UpdateImageAndText("IvyValues");
            UpdateImageAndText("KilikValues");
            UpdateImageAndText("XianghuaValues");
            UpdateImageAndText("LizardmanValues");
            UpdateImageAndText("YoshimitsuValues");
            UpdateImageAndText("NightmareValues");
            UpdateImageAndText("AstarothValues");
            UpdateImageAndText("CervantesValues");
            UpdateImageAndText("RaphaelValues");
            UpdateImageAndText("TalimValues");
            UpdateImageAndText("CassandraValues");
            UpdateImageAndText("YunSeongValues");
            UpdateImageAndText("SetsukaValues");
            UpdateImageAndText("TiraValues");
            UpdateImageAndText("ZasalamelValues");
            UpdateImageAndText("OlcadanValues");
            UpdateImageAndText("AbyssValues");

            UpdateImageAndText("AmyValues");
            UpdateImageAndText("MiserValues");
            UpdateImageAndText("GreedValues");
            UpdateImageAndText("ArthurValues");
            UpdateImageAndText("HwangValues");
            UpdateImageAndText("LunaValues");
            UpdateImageAndText("ValeriaValues");
            UpdateImageAndText("HualinValues");
            UpdateImageAndText("GirardotValues");
            UpdateImageAndText("DemuthValues");
            UpdateImageAndText("AureliaValues");
            UpdateImageAndText("ChesterValues");
            UpdateImageAndText("StrifeValues");
            UpdateImageAndText("AbeliaValues");
            UpdateImageAndText("LynetteValues");
            UpdateImageAndText("LiLongValues");
            UpdateImageAndText("RevenantValues");

            UpdateImageAndText("LizardMenValues");
            UpdateImageAndText("NightTerrorValues");
            UpdateImageAndText("CharadeValues");
            UpdateImageAndText("InfernoValues");
            UpdateImageAndText("ShadowMasterValues");
            UpdateImageAndText("ColossusValues");
            UpdateImageAndText("BerserkerValues");
            UpdateImageAndText("Samurai1Values");
            UpdateImageAndText("Samurai2Values");
            UpdateImageAndText("Samurai3Values");
            UpdateImageAndText("Samurai4Values");
            UpdateImageAndText("Gladiator1Values");
            UpdateImageAndText("Gladiator2Values");
            UpdateImageAndText("UnknownSoulValues");
            UpdateImageAndText("FumaNinja1Values");
            UpdateImageAndText("FumaNinja2Values");
            UpdateImageAndText("FumaNinja3Values");
            UpdateImageAndText("FumaNinja4Values");
            UpdateImageAndText("FumaNinja5Values");
            UpdateImageAndText("FumaNinja6Values");
            UpdateImageAndText("FumaNinja7Values");
            UpdateImageAndText("Bandit1Values");
            UpdateImageAndText("Bandit2Values");
            UpdateImageAndText("Bandit3Values");
            UpdateImageAndText("Thief1Values");
            UpdateImageAndText("Thief2Values");
            UpdateImageAndText("Pirate1Values");
            UpdateImageAndText("Pirate2Values");
            UpdateImageAndText("Pirate3Values");
            UpdateImageAndText("Pirate4Values");
            UpdateImageAndText("Pirate5Values");
            UpdateImageAndText("Pirate6Values");
            UpdateImageAndText("Pirate7Values");
            UpdateImageAndText("AssassinValues");
            UpdateImageAndText("Swordsman1Values");
            UpdateImageAndText("Swordsman2Values");
            UpdateImageAndText("FootSoldierValues");
            UpdateImageAndText("GeneralValues");
            UpdateImageAndText("SentryValues");
            UpdateImageAndText("KeresValues");
            UpdateImageAndText("DragonValues");
            UpdateImageAndText("XValues");

            UpdateImageAndText("JinkaiValues");
            UpdateImageAndText("KagamiValues");
            UpdateImageAndText("ShiunValues");
            UpdateImageAndText("ShiinaValues");
            UpdateImageAndText("ChikageValues");
            UpdateImageAndText("KonomiValues");
            UpdateImageAndText("CassiusValues");
            UpdateImageAndText("SaizouValues");
            UpdateImageAndText("RyougaValues");
            UpdateImageAndText("KimikaValues");
            UpdateImageAndText("SyunnaValues");
            UpdateImageAndText("TomoeValues");
            UpdateImageAndText("MeigaValues");
            UpdateImageAndText("AlastorValues");
            UpdateImageAndText("ShizumaValues");
            UpdateImageAndText("AzumiValues");
            UpdateImageAndText("YukinaValues");
            UpdateImageAndText("OukaValues");
            UpdateImageAndText("XiaoxinValues");
            UpdateImageAndText("OruksValues");
            UpdateImageAndText("AgarethValues");
            UpdateImageAndText("JyuriValues");
            UpdateImageAndText("ShuyuValues");
            UpdateImageAndText("MingyueValues");
            UpdateImageAndText("VelesValues");
            UpdateImageAndText("AetherValues");
            UpdateImageAndText("IxionValues");
            UpdateImageAndText("SiulanValues");
            UpdateImageAndText("FenglinValues");
            UpdateImageAndText("PhilineValues");
            UpdateImageAndText("IgnisValues");
            UpdateImageAndText("NotusValues");
            UpdateImageAndText("AzraelValues");
            UpdateImageAndText("MireilleValues");
            UpdateImageAndText("AglaiaValues");
            UpdateImageAndText("KanonValues");
            UpdateImageAndText("JyuraiValues");
            UpdateImageAndText("KurehaValues");
            UpdateImageAndText("XunyuValues");
            UpdateImageAndText("FengyuValues");
            UpdateImageAndText("FengleiValues");
            UpdateImageAndText("MinglianValues");
            UpdateImageAndText("NoelValues");
            UpdateImageAndText("RudigerValues");
            UpdateImageAndText("AeneasValues");
            UpdateImageAndText("AnnarettaValues");
            UpdateImageAndText("IrisValues");
            UpdateImageAndText("BrunhildValues");
            UpdateImageAndText("AsrafilValues");
            UpdateImageAndText("ZifengValues");
            UpdateImageAndText("AeolosValues");
            UpdateImageAndText("AmritaValues");
            UpdateImageAndText("AzaleaValues");
            UpdateImageAndText("YueliangValues");
            UpdateImageAndText("KanadeValues");
            UpdateImageAndText("DomenthiValues");
            UpdateImageAndText("MaridValues");
            UpdateImageAndText("AmbroseValues");
            UpdateImageAndText("AilianValues");
            UpdateImageAndText("AikaValues");
            UpdateImageAndText("LokiValues");
            UpdateImageAndText("CelestisValues");
            UpdateImageAndText("BelethValues");
            UpdateImageAndText("KarenValues");
            UpdateImageAndText("LilanValues");
            UpdateImageAndText("AbigailValues");
            UpdateImageAndText("BalduinValues");
            UpdateImageAndText("AlocesValues");
            UpdateImageAndText("AreonValues");
            UpdateImageAndText("JunoValues");
            UpdateImageAndText("EurydiceValues");
            UpdateImageAndText("IshtarValues");
            UpdateImageAndText("RufusValues");
            UpdateImageAndText("RaguelValues");
            UpdateImageAndText("FeofanValues");
            UpdateImageAndText("EuniceValues");
            UpdateImageAndText("AcaciaValues");
            UpdateImageAndText("HildaValues");
            UpdateImageAndText("IblisValues");
            UpdateImageAndText("AlbericValues");
            UpdateImageAndText("LeshyValues");
            UpdateImageAndText("MurielValues");
            UpdateImageAndText("WenliValues");
            UpdateImageAndText("IreneValues");
            UpdateImageAndText("YufengValues");
            UpdateImageAndText("YakumoValues");
            UpdateImageAndText("DufengValues");
            UpdateImageAndText("MayuraValues");
            UpdateImageAndText("MeilanValues");
            UpdateImageAndText("RheaValues");
            UpdateImageAndText("HalphasValues");
            UpdateImageAndText("GorusValues");
            UpdateImageAndText("IlyushaValues");
            UpdateImageAndText("EdithValues");
            UpdateImageAndText("RieseValues");
            UpdateImageAndText("AgaveValues");
            UpdateImageAndText("HaystirValues");
            UpdateImageAndText("LerajeValues");
            UpdateImageAndText("RatzielValues");
            UpdateImageAndText("KatinaValues");
            UpdateImageAndText("ErisValues");
            UpdateImageAndText("SizukuValues");
            UpdateImageAndText("GrandallMaleValues");
            UpdateImageAndText("DalkiaMaleValues");
            UpdateImageAndText("BrigandMaleValues");
            UpdateImageAndText("MalettaMaleValues");
            UpdateImageAndText("RebelMaleValues");
            UpdateImageAndText("GrandallFemaleValues");
            UpdateImageAndText("DalkiaFemaleValues");
            UpdateImageAndText("BrigandFemaleValues");
            UpdateImageAndText("MalettaFemaleValues");
            UpdateImageAndText("RebelFemaleValues");
            UpdateImageAndText("ExtraValues");
            UpdateImageAndText("TinaValues");
            UpdateImageAndText("AegeValues");
            UpdateImageAndText("HealDoValues");
            UpdateImageAndText("EluaValues");
            UpdateImageAndText("LupiValues");
            UpdateImageAndText("RoinValues");
            UpdateImageAndText("KierkessValues");
            UpdateImageAndText("HyleValues");
            UpdateImageAndText("MooncalfValues");
            UpdateImageAndText("EndeValues");
            UpdateImageAndText("RandomValues");
            UpdateImageAndText("BossValues");
            UpdateImageAndText("BossValues2");
            #endregion

            if (SettingsClass.LastSelectedCharP1 == "" || SettingsClass.LastSelectedIndexP1 == -1)
            {
                viewModel.Player1Character = "/Resources/none.png";
            }
            else if (SettingsClass.LastSelectedCharP1 != "RandomValues")
            {
                CharacterSelect(1, SettingsClass.LastSelectedCharP1, false, "", "");
                string[,] currentArray = GetSelectedArray(SettingsClass.LastSelectedCharP1);
                viewModel.Player1Character = "/Resources/" + currentArray[SettingsClass.LastSelectedIndexP1, 6];
            }
            else
            {
                GetPlayerHex(1);
                viewModel.Player1Character = "/Resources/Random.png";
            }
            if (SettingsClass.LastSelectedCharP2 == "" || SettingsClass.LastSelectedIndexP2 == -1)
            {
                viewModel.Player2Character = "/Resources/none.png";
            }
            else if (SettingsClass.LastSelectedCharP2 != "RandomValues")
            {
                CharacterSelect(2, SettingsClass.LastSelectedCharP2, false, "", "");
                string[,] currentArray = GetSelectedArray(SettingsClass.LastSelectedCharP2);
                viewModel.Player2Character = "/Resources/" + currentArray[SettingsClass.LastSelectedIndexP2, 6];
            }
            else
            {
                GetPlayerHex(2);
                viewModel.Player2Character = "/Resources/Random.png";
            }
        }

        public string GetImageNameAtStartup(string character, string model)
        {
            string imageName = "";

            switch (character)
            {
                case "":
                    imageName = "MitsurugiValues";
                    break;
            }
            return imageName;
        }


        private void MouseEnter(object sender, MouseEventArgs e)
        {
            string imageName = ((Image)sender).Name;

            currentIndex = 0;
            UpdateImageAndText(imageName);
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

            UpdateImageAndText(imageName);
        }

        private void UpdateImageAndText(string btnName)
        {
            string imageName = "";
            BitmapImage bitmap = new BitmapImage();
            string[,] currentArray = GetSelectedArray(btnName);

            imageName = currentArray[currentIndex, 3];
            bitmap.BeginInit();
            bitmap.UriSource = new Uri($"/Resources/{imageName}", UriKind.Relative);
            bitmap.EndInit();

            switch (btnName)
            {
                case "MitsurugiValues":
                    MitsurugiValues.Source = bitmap;
                    break;
                case "SeongMinaValues":
                    SeongMinaValues.Source = bitmap;
                    break;
                case "TakiValues":
                    TakiValues.Source = bitmap;
                    break;
                case "MaxiValues":
                    MaxiValues.Source = bitmap;
                    break;
                case "VoldoValues":
                    VoldoValues.Source = bitmap;
                    break;
                case "SophitiaValues":
                    SophitiaValues.Source = bitmap;
                    break;
                case "SiegfriedValues":
                    SiegfriedValues.Source = bitmap;
                    break;
                case "RockValues":
                    RockValues.Source = bitmap;
                    break;
                case "IvyValues":
                    IvyValues.Source = bitmap;
                    break;
                case "KilikValues":
                    KilikValues.Source = bitmap;
                    break;
                case "XianghuaValues":
                    XianghuaValues.Source = bitmap;
                    break;
                case "LizardmanValues":
                    LizardmanValues.Source = bitmap;
                    break;
                case "YoshimitsuValues":
                    YoshimitsuValues.Source = bitmap;
                    break;
                case "NightmareValues":
                    NightmareValues.Source = bitmap;
                    break;
                case "AstarothValues":
                    AstarothValues.Source = bitmap;
                    break;
                case "CervantesValues":
                    CervantesValues.Source = bitmap;
                    break;
                case "RaphaelValues":
                    RaphaelValues.Source = bitmap;
                    break;
                case "TalimValues":
                    TalimValues.Source = bitmap;
                    break;
                case "CassandraValues":
                    CassandraValues.Source = bitmap;
                    break;
                case "YunSeongValues":
                    YunSeongValues.Source = bitmap;
                    break;
                case "SetsukaValues":
                    SetsukaValues.Source = bitmap;
                    break;
                case "TiraValues":
                    TiraValues.Source = bitmap;
                    break;
                case "ZasalamelValues":
                    ZasalamelValues.Source = bitmap;
                    break;
                case "OlcadanValues":
                    OlcadanValues.Source = bitmap;
                    break;
                case "AbyssValues":
                    AbyssValues.Source = bitmap;
                    break;
                case "AmyValues":
                    AmyValues.Source = bitmap;
                    break;
                case "MiserValues":
                    MiserValues.Source = bitmap;
                    break;
                case "GreedValues":
                    GreedValues.Source = bitmap;
                    break;
                case "ArthurValues":
                    ArthurValues.Source = bitmap;
                    break;
                case "HwangValues":
                    HwangValues.Source = bitmap;
                    break;
                case "LunaValues":
                    LunaValues.Source = bitmap;
                    break;
                case "ValeriaValues":
                    ValeriaValues.Source = bitmap;
                    break;
                case "HualinValues":
                    HualinValues.Source = bitmap;
                    break;
                case "GirardotValues":
                    GirardotValues.Source = bitmap;
                    break;
                case "DemuthValues":
                    DemuthValues.Source = bitmap;
                    break;
                case "AureliaValues":
                    AureliaValues.Source = bitmap;
                    break;
                case "ChesterValues":
                    ChesterValues.Source = bitmap;
                    break;
                case "StrifeValues":
                    StrifeValues.Source = bitmap;
                    break;
                case "AbeliaValues":
                    AbeliaValues.Source = bitmap;
                    break;
                case "LynetteValues":
                    LynetteValues.Source = bitmap;
                    break;
                case "LiLongValues":
                    LiLongValues.Source = bitmap;
                    break;
                case "RevenantValues":
                    RevenantValues.Source = bitmap;
                    break;
                case "LizardMenValues":
                    LizardMenValues.Source = bitmap;
                    break;
                case "NightTerrorValues":
                    NightTerrorValues.Source = bitmap;
                    break;
                case "CharadeValues":
                    CharadeValues.Source = bitmap;
                    break;
                case "InfernoValues":
                    InfernoValues.Source = bitmap;
                    break;
                case "ShadowMasterValues":
                    ShadowMasterValues.Source = bitmap;
                    break;
                case "ColossusValues":
                    ColossusValues.Source = bitmap;
                    break;
                case "BerserkerValues":
                    BerserkerValues.Source = bitmap;
                    break;
                case "Samurai1Values":
                    Samurai1Values.Source = bitmap;
                    break;
                case "Samurai2Values":
                    Samurai2Values.Source = bitmap;
                    break;
                case "Samurai3Values":
                    Samurai3Values.Source = bitmap;
                    break;
                case "Samurai4Values":
                    Samurai4Values.Source = bitmap;
                    break;
                case "Gladiator1Values":
                    Gladiator1Values.Source = bitmap;
                    break;
                case "Gladiator2Values":
                    Gladiator2Values.Source = bitmap;
                    break;
                case "UnknownSoulValues":
                    UnknownSoulValues.Source = bitmap;
                    break;
                case "FumaNinja1Values":
                    FumaNinja1Values.Source = bitmap;
                    break;
                case "FumaNinja2Values":
                    FumaNinja2Values.Source = bitmap;
                    break;
                case "FumaNinja3Values":
                    FumaNinja3Values.Source = bitmap;
                    break;
                case "FumaNinja4Values":
                    FumaNinja4Values.Source = bitmap;
                    break;
                case "FumaNinja5Values":
                    FumaNinja5Values.Source = bitmap;
                    break;
                case "FumaNinja6Values":
                    FumaNinja6Values.Source = bitmap;
                    break;
                case "FumaNinja7Values":
                    FumaNinja7Values.Source = bitmap;
                    break;
                case "Bandit1Values":
                    Bandit1Values.Source = bitmap;
                    break;
                case "Bandit2Values":
                    Bandit2Values.Source = bitmap;
                    break;
                case "Bandit3Values":
                    Bandit3Values.Source = bitmap;
                    break;
                case "Thief1Values":
                    Thief1Values.Source = bitmap;
                    break;
                case "Thief2Values":
                    Thief2Values.Source = bitmap;
                    break;
                case "Pirate1Values":
                    Pirate1Values.Source = bitmap;
                    break;
                case "Pirate2Values":
                    Pirate2Values.Source = bitmap;
                    break;
                case "Pirate3Values":
                    Pirate3Values.Source = bitmap;
                    break;
                case "Pirate4Values":
                    Pirate4Values.Source = bitmap;
                    break;
                case "Pirate5Values":
                    Pirate5Values.Source = bitmap;
                    break;
                case "Pirate6Values":
                    Pirate6Values.Source = bitmap;
                    break;
                case "Pirate7Values":
                    Pirate7Values.Source = bitmap;
                    break;
                case "AssassinValues":
                    AssassinValues.Source = bitmap;
                    break;
                case "Swordsman1Values":
                    Swordsman1Values.Source = bitmap;
                    break;
                case "Swordsman2Values":
                    Swordsman2Values.Source = bitmap;
                    break;
                case "FootSoldierValues":
                    FootSoldierValues.Source = bitmap;
                    break;
                case "GeneralValues":
                    GeneralValues.Source = bitmap;
                    break;
                case "SentryValues":
                    SentryValues.Source = bitmap;
                    break;
                case "KeresValues":
                    KeresValues.Source = bitmap;
                    break;
                case "DragonValues":
                    DragonValues.Source = bitmap;
                    break;
                case "XValues":
                    XValues.Source = bitmap;
                    break;
                case "JinkaiValues":
                    JinkaiValues.Source = bitmap;
                    break;
                case "KagamiValues":
                    KagamiValues.Source = bitmap;
                    break;
                case "ShiunValues":
                    ShiunValues.Source = bitmap;
                    break;
                case "ShiinaValues":
                    ShiinaValues.Source = bitmap;
                    break;
                case "ChikageValues":
                    ChikageValues.Source = bitmap;
                    break;
                case "KonomiValues":
                    KonomiValues.Source = bitmap;
                    break;
                case "CassiusValues":
                    CassiusValues.Source = bitmap;
                    break;
                case "SaizouValues":
                    SaizouValues.Source = bitmap;
                    break;
                case "RyougaValues":
                    RyougaValues.Source = bitmap;
                    break;
                case "KimikaValues":
                    KimikaValues.Source = bitmap;
                    break;
                case "SyunnaValues":
                    SyunnaValues.Source = bitmap;
                    break;
                case "TomoeValues":
                    TomoeValues.Source = bitmap;
                    break;
                case "MeigaValues":
                    MeigaValues.Source = bitmap;
                    break;
                case "AlastorValues":
                    AlastorValues.Source = bitmap;
                    break;
                case "ShizumaValues":
                    ShizumaValues.Source = bitmap;
                    break;
                case "AzumiValues":
                    AzumiValues.Source = bitmap;
                    break;
                case "YukinaValues":
                    YukinaValues.Source = bitmap;
                    break;
                case "OukaValues":
                    OukaValues.Source = bitmap;
                    break;
                case "XiaoxinValues":
                    XiaoxinValues.Source = bitmap;
                    break;
                case "OruksValues":
                    OruksValues.Source = bitmap;
                    break;
                case "AgarethValues":
                    AgarethValues.Source = bitmap;
                    break;
                case "JyuriValues":
                    JyuriValues.Source = bitmap;
                    break;
                case "ShuyuValues":
                    ShuyuValues.Source = bitmap;
                    break;
                case "MingyueValues":
                    MingyueValues.Source = bitmap;
                    break;
                case "VelesValues":
                    VelesValues.Source = bitmap;
                    break;
                case "AetherValues":
                    AetherValues.Source = bitmap;
                    break;
                case "IxionValues":
                    IxionValues.Source = bitmap;
                    break;
                case "SiulanValues":
                    SiulanValues.Source = bitmap;
                    break;
                case "FenglinValues":
                    FenglinValues.Source = bitmap;
                    break;
                case "PhilineValues":
                    PhilineValues.Source = bitmap;
                    break;
                case "IgnisValues":
                    IgnisValues.Source = bitmap;
                    break;
                case "NotusValues":
                    NotusValues.Source = bitmap;
                    break;
                case "AzraelValues":
                    AzraelValues.Source = bitmap;
                    break;
                case "MireilleValues":
                    MireilleValues.Source = bitmap;
                    break;
                case "AglaiaValues":
                    AglaiaValues.Source = bitmap;
                    break;
                case "KanonValues":
                    KanonValues.Source = bitmap;
                    break;
                case "JyuraiValues":
                    JyuraiValues.Source = bitmap;
                    break;
                case "KurehaValues":
                    KurehaValues.Source = bitmap;
                    break;
                case "XunyuValues":
                    XunyuValues.Source = bitmap;
                    break;
                case "FengyuValues":
                    FengyuValues.Source = bitmap;
                    break;
                case "FengleiValues":
                    FengleiValues.Source = bitmap;
                    break;
                case "MinglianValues":
                    MinglianValues.Source = bitmap;
                    break;
                case "NoelValues":
                    NoelValues.Source = bitmap;
                    break;
                case "RudigerValues":
                    RudigerValues.Source = bitmap;
                    break;
                case "AeneasValues":
                    AeneasValues.Source = bitmap;
                    break;
                case "AnnarettaValues":
                    AnnarettaValues.Source = bitmap;
                    break;
                case "IrisValues":
                    IrisValues.Source = bitmap;
                    break;
                case "BrunhildValues":
                    BrunhildValues.Source = bitmap;
                    break;
                case "AsrafilValues":
                    AsrafilValues.Source = bitmap;
                    break;
                case "ZifengValues":
                    ZifengValues.Source = bitmap;
                    break;
                case "AeolosValues":
                    AeolosValues.Source = bitmap;
                    break;
                case "AmritaValues":
                    AmritaValues.Source = bitmap;
                    break;
                case "AzaleaValues":
                    AzaleaValues.Source = bitmap;
                    break;
                case "YueliangValues":
                    YueliangValues.Source = bitmap;
                    break;
                case "KanadeValues":
                    KanadeValues.Source = bitmap;
                    break;
                case "DomenthiValues":
                    DomenthiValues.Source = bitmap;
                    break;
                case "MaridValues":
                    MaridValues.Source = bitmap;
                    break;
                case "AmbroseValues":
                    AmbroseValues.Source = bitmap;
                    break;
                case "AilianValues":
                    AilianValues.Source = bitmap;
                    break;
                case "AikaValues":
                    AikaValues.Source = bitmap;
                    break;
                case "LokiValues":
                    LokiValues.Source = bitmap;
                    break;
                case "CelestisValues":
                    CelestisValues.Source = bitmap;
                    break;
                case "BelethValues":
                    BelethValues.Source = bitmap;
                    break;
                case "KarenValues":
                    KarenValues.Source = bitmap;
                    break;
                case "LilanValues":
                    LilanValues.Source = bitmap;
                    break;
                case "AbigailValues":
                    AbigailValues.Source = bitmap;
                    break;
                case "BalduinValues":
                    BalduinValues.Source = bitmap;
                    break;
                case "AlocesValues":
                    AlocesValues.Source = bitmap;
                    break;
                case "AreonValues":
                    AreonValues.Source = bitmap;
                    break;
                case "JunoValues":
                    JunoValues.Source = bitmap;
                    break;
                case "EurydiceValues":
                    EurydiceValues.Source = bitmap;
                    break;
                case "IshtarValues":
                    IshtarValues.Source = bitmap;
                    break;
                case "RufusValues":
                    RufusValues.Source = bitmap;
                    break;
                case "RaguelValues":
                    RaguelValues.Source = bitmap;
                    break;
                case "FeofanValues":
                    FeofanValues.Source = bitmap;
                    break;
                case "EuniceValues":
                    EuniceValues.Source = bitmap;
                    break;
                case "AcaciaValues":
                    AcaciaValues.Source = bitmap;
                    break;
                case "HildaValues":
                    HildaValues.Source = bitmap;
                    break;
                case "IblisValues":
                    IblisValues.Source = bitmap;
                    break;
                case "AlbericValues":
                    AlbericValues.Source = bitmap;
                    break;
                case "LeshyValues":
                    LeshyValues.Source = bitmap;
                    break;
                case "MurielValues":
                    MurielValues.Source = bitmap;
                    break;
                case "WenliValues":
                    WenliValues.Source = bitmap;
                    break;
                case "IreneValues":
                    IreneValues.Source = bitmap;
                    break;
                case "YufengValues":
                    YufengValues.Source = bitmap;
                    break;
                case "YakumoValues":
                    YakumoValues.Source = bitmap;
                    break;
                case "DufengValues":
                    DufengValues.Source = bitmap;
                    break;
                case "MayuraValues":
                    MayuraValues.Source = bitmap;
                    break;
                case "MeilanValues":
                    MeilanValues.Source = bitmap;
                    break;
                case "RheaValues":
                    RheaValues.Source = bitmap;
                    break;
                case "HalphasValues":
                    HalphasValues.Source = bitmap;
                    break;
                case "GorusValues":
                    GorusValues.Source = bitmap;
                    break;
                case "IlyushaValues":
                    IlyushaValues.Source = bitmap;
                    break;
                case "EdithValues":
                    EdithValues.Source = bitmap;
                    break;
                case "RieseValues":
                    RieseValues.Source = bitmap;
                    break;
                case "AgaveValues":
                    AgaveValues.Source = bitmap;
                    break;
                case "HaystirValues":
                    HaystirValues.Source = bitmap;
                    break;
                case "LerajeValues":
                    LerajeValues.Source = bitmap;
                    break;
                case "RatzielValues":
                    RatzielValues.Source = bitmap;
                    break;
                case "KatinaValues":
                    KatinaValues.Source = bitmap;
                    break;
                case "ErisValues":
                    ErisValues.Source = bitmap;
                    break;
                case "SizukuValues":
                    SizukuValues.Source = bitmap;
                    break;
                case "GrandallMaleValues":
                    GrandallMaleValues.Source = bitmap;
                    break;
                case "DalkiaMaleValues":
                    DalkiaMaleValues.Source = bitmap;
                    break;
                case "BrigandMaleValues":
                    BrigandMaleValues.Source = bitmap;
                    break;
                case "MalettaMaleValues":
                    MalettaMaleValues.Source = bitmap;
                    break;
                case "RebelMaleValues":
                    RebelMaleValues.Source = bitmap;
                    break;
                case "GrandallFemaleValues":
                    GrandallFemaleValues.Source = bitmap;
                    break;
                case "DalkiaFemaleValues":
                    DalkiaFemaleValues.Source = bitmap;
                    break;
                case "BrigandFemaleValues":
                    BrigandFemaleValues.Source = bitmap;
                    break;
                case "MalettaFemaleValues":
                    MalettaFemaleValues.Source = bitmap;
                    break;
                case "RebelFemaleValues":
                    RebelFemaleValues.Source = bitmap;
                    break;
                case "ExtraValues":
                    ExtraValues.Source = bitmap;
                    break;
                case "TinaValues":
                    TinaValues.Source = bitmap;
                    break;
                case "AegeValues":
                    AegeValues.Source = bitmap;
                    break;
                case "HealDoValues":
                    HealDoValues.Source = bitmap;
                    break;
                case "EluaValues":
                    EluaValues.Source = bitmap;
                    break;
                case "LupiValues":
                    LupiValues.Source = bitmap;
                    break;
                case "RoinValues":
                    RoinValues.Source = bitmap;
                    break;
                case "KierkessValues":
                    KierkessValues.Source = bitmap;
                    break;
                case "HyleValues":
                    HyleValues.Source = bitmap;
                    break;
                case "MooncalfValues":
                    MooncalfValues.Source = bitmap;
                    break;
                case "EndeValues":
                    EndeValues.Source = bitmap;
                    break;
                case "RandomValues":
                    RandomValues.Source = bitmap;
                    break;
                case "BossValues":
                    BossValues.Source = bitmap;
                    break;
                case "BossValues2":
                    BossValues2.Source = bitmap;
                    break;
            }

            #region Text Config
            //Clean all text first
            CostumeTextBlock1.Text = "";
            CostumeTextBlock2.Text = "";
            CostumeTextBlock3.Text = "";
            CostumeTextBlock4.Text = "";
            CostumeTextBlock5.Text = "";
            CostumeTextBlock6.Text = "";
            CostumeTextBlock7.Text = "";
            SoulTextBlock1.Text = "";
            SoulTextBlock2.Text = "";
            SoulTextBlock3.Text = "";
            SoulTextBlock4.Text = "";
            SoulTextBlock5.Text = "";
            SoulTextBlock6.Text = "";
            SoulTextBlock7.Text = "";
            SoulTextBlock8.Text = "";
            SoulTextBlock9.Text = "";
            SoulTextBlock10.Text = "";
            SoulTextBlock11.Text = "";
            SoulTextBlock12.Text = "";
            SoulTextBlock13.Text = "";
            SoulTextBlock14.Text = "";
            SoulTextBlock15.Text = "";
            SoulTextBlock16.Text = "";
            SoulTextBlock17.Text = "";


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
            if (currentArray.GetLength(0) > 2)
            {
                CostumeTextBlock3.Text = currentArray[2, 1];
                CostumeTextBlock3.Foreground = Brushes.White;
                SoulTextBlock3.Text = currentArray[2, 2];
                SoulTextBlock3.Foreground = Brushes.White;
            }
            if (currentArray.GetLength(0) > 3)
            {
                CostumeTextBlock4.Text = currentArray[3, 1];
                CostumeTextBlock4.Foreground = Brushes.White;
                SoulTextBlock4.Text = currentArray[3, 2];
                SoulTextBlock4.Foreground = Brushes.White;
            }
            if (currentArray.GetLength(0) > 4)
            {
                CostumeTextBlock5.Text = currentArray[4, 1];
                CostumeTextBlock5.Foreground = Brushes.White;
                SoulTextBlock5.Text = currentArray[4, 2];
                SoulTextBlock5.Foreground = Brushes.White;
            }
            if (currentArray.GetLength(0) > 5)
            {
                CostumeTextBlock6.Text = currentArray[5, 1];
                CostumeTextBlock6.Foreground = Brushes.White;
                SoulTextBlock6.Text = currentArray[5, 2];
                SoulTextBlock6.Foreground = Brushes.White;
            }
            if (currentArray.GetLength(0) > 6)
            {
                CostumeTextBlock7.Text = currentArray[6, 1];
                CostumeTextBlock7.Foreground = Brushes.White;
                SoulTextBlock7.Text = currentArray[6, 2];
                SoulTextBlock7.Foreground = Brushes.White;
            }

            if (currentArray.GetLength(0) > 7)
            {
                SoulTextBlock8.Text = currentArray[7, 2];
                SoulTextBlock8.Foreground = Brushes.White;
            }
            if (currentArray.GetLength(0) > 8)
            {
                SoulTextBlock9.Text = currentArray[8, 2];
                SoulTextBlock9.Foreground = Brushes.White;
            }
            if (currentArray.GetLength(0) > 9)
            {
                SoulTextBlock10.Text = currentArray[9, 2];
                SoulTextBlock10.Foreground = Brushes.White;
            }
            if (currentArray.GetLength(0) > 10)
            {
                SoulTextBlock11.Text = currentArray[10, 2];
                SoulTextBlock11.Foreground = Brushes.White;
            }
            if (currentArray.GetLength(0) > 11)
            {
                SoulTextBlock12.Text = currentArray[11, 2];
                SoulTextBlock12.Foreground = Brushes.White;
            }
            if (currentArray.GetLength(0) > 12)
            {
                SoulTextBlock13.Text = currentArray[12, 2];
                SoulTextBlock13.Foreground = Brushes.White;
            }
            if (currentArray.GetLength(0) > 13)
            {
                SoulTextBlock14.Text = currentArray[13, 2];
                SoulTextBlock14.Foreground = Brushes.White;
            }
            if (currentArray.GetLength(0) > 14)
            {
                SoulTextBlock15.Text = currentArray[14, 2];
                SoulTextBlock15.Foreground = Brushes.White;
            }
            if (currentArray.GetLength(0) > 15)
            {
                SoulTextBlock16.Text = currentArray[15, 2];
                SoulTextBlock16.Foreground = Brushes.White;
            }
            if (currentArray.GetLength(0) > 16)
            {
                SoulTextBlock17.Text = currentArray[16, 2];
                SoulTextBlock17.Foreground = Brushes.White;
            }

            switch (currentIndex)
            {
                case 0:
                    CostumeTextBlock1.Foreground = Brushes.Yellow;
                    SoulTextBlock1.Foreground = Brushes.Yellow;
                    viewModel.CharacterPortrait = "/Resources/"+ currentArray[currentIndex, 6];
                    break;
                case 1:
                    CostumeTextBlock2.Foreground = Brushes.Yellow;
                    SoulTextBlock2.Foreground = Brushes.Yellow;
                    viewModel.CharacterPortrait = "/Resources/" + currentArray[currentIndex, 6];
                    break;
                case 2:
                    CostumeTextBlock3.Foreground = Brushes.Yellow;
                    SoulTextBlock3.Foreground = Brushes.Yellow;
                    viewModel.CharacterPortrait = "/Resources/" + currentArray[currentIndex, 6];
                    break;
                case 3:
                    CostumeTextBlock4.Foreground = Brushes.Yellow;
                    SoulTextBlock4.Foreground = Brushes.Yellow;
                    viewModel.CharacterPortrait = "/Resources/" + currentArray[currentIndex, 6];
                    break;
                case 4:
                    CostumeTextBlock5.Foreground = Brushes.Yellow;
                    SoulTextBlock5.Foreground = Brushes.Yellow;
                    viewModel.CharacterPortrait = "/Resources/" + currentArray[currentIndex, 6];
                    break;
                case 5:
                    CostumeTextBlock6.Foreground = Brushes.Yellow;
                    SoulTextBlock6.Foreground = Brushes.Yellow;
                    viewModel.CharacterPortrait = "/Resources/" + currentArray[currentIndex, 6];
                    break;
                case 6:
                    CostumeTextBlock7.Foreground = Brushes.Yellow;
                    SoulTextBlock7.Foreground = Brushes.Yellow;
                    viewModel.CharacterPortrait = "/Resources/" + currentArray[currentIndex, 6];
                    break;
                case 7:
                    SoulTextBlock8.Foreground = Brushes.Yellow;
                    viewModel.CharacterPortrait = "/Resources/" + currentArray[currentIndex, 6];
                    break;
                case 8:
                    SoulTextBlock9.Foreground = Brushes.Yellow;
                    viewModel.CharacterPortrait = "/Resources/" + currentArray[currentIndex, 6];
                    break;
                case 9:
                    SoulTextBlock10.Foreground = Brushes.Yellow;
                    viewModel.CharacterPortrait = "/Resources/" + currentArray[currentIndex, 6];
                    break;
                case 10:
                    SoulTextBlock11.Foreground = Brushes.Yellow;
                    viewModel.CharacterPortrait = "/Resources/" + currentArray[currentIndex, 6];
                    break;
                case 11:
                    SoulTextBlock12.Foreground = Brushes.Yellow;
                    viewModel.CharacterPortrait = "/Resources/" + currentArray[currentIndex, 6];
                    break;
                case 12:
                    SoulTextBlock13.Foreground = Brushes.Yellow;
                    viewModel.CharacterPortrait = "/Resources/" + currentArray[currentIndex, 6];
                    break;
                case 13:
                    SoulTextBlock14.Foreground = Brushes.Yellow;
                    viewModel.CharacterPortrait = "/Resources/" + currentArray[currentIndex, 6];
                    break;
                case 14:
                    SoulTextBlock15.Foreground = Brushes.Yellow;
                    viewModel.CharacterPortrait = "/Resources/" + currentArray[currentIndex, 6];
                    break;
                case 15:
                    SoulTextBlock16.Foreground = Brushes.Yellow;
                    viewModel.CharacterPortrait = "/Resources/" + currentArray[currentIndex, 6];
                    break;
                case 16:
                    SoulTextBlock17.Foreground = Brushes.Yellow;
                    viewModel.CharacterPortrait = "/Resources/" + currentArray[currentIndex, 6];
                    break;
            }
            #endregion
        }

        private void MouseLeftClick(object sender, MouseButtonEventArgs e)
        {
            string imageName = ((Image)sender).Name;
            int playerIndex = 1;

            if (imageName != "RandomValues")
            {
                CharacterSelect(playerIndex, imageName, false, "", "");
                string[,] currentArray = GetSelectedArray(imageName);
                viewModel.Player1Character = "/Resources/" + currentArray[currentIndex, 6];
            }
            else
            {
                GetPlayerHex(playerIndex);
                viewModel.Player1Character = "/Resources/Random.png";
            }
            SettingsClass.LastSelectedCharP1 = imageName;
            SettingsClass.LastSelectedIndexP1 = currentIndex;
            SettingsClass.SaveData();

        }

        private void MouseRightClick(object sender, MouseButtonEventArgs e)
        {
            string imageName = ((Image)sender).Name;
            int playerIndex = 2;

            if (imageName != "RandomValues")
            {
                CharacterSelect(playerIndex, imageName, false, "", "");
                string[,] currentArray = GetSelectedArray(imageName);
                viewModel.Player2Character = "/Resources/" + currentArray[currentIndex, 6];
            }
            else
            {
                GetPlayerHex(playerIndex);
                viewModel.Player2Character = "/Resources/Random.png";
            }
            SettingsClass.LastSelectedCharP2 = imageName;
            SettingsClass.LastSelectedIndexP2 = currentIndex;
            SettingsClass.SaveData();
        }

        private void CharacterSelect(int playerIndex, string imageName, bool random, string m1, string m2)
        {
            if (imageName == "none")
            {
                if (playerIndex == 1)
                {
                    SettingsClass.CharacterP1 = imageName;
                    SettingsClass.ModelP1 = imageName;
                    SettingsClass.VoiceP1 = "";
                }
                else if (playerIndex == 2)
                {
                    SettingsClass.CharacterP2 = imageName;
                    SettingsClass.ModelP2 = imageName;
                    SettingsClass.VoiceP2 = "";
                }
            }
            else //change ok
            {
                string[,] currentArray = GetSelectedArray(imageName);

                if (!random)
                {
                    if (playerIndex == 1)
                    {
                        if (SettingsClass.CharacterP1 != "FX")
                        {
                            SettingsClass.CharacterP1 = currentArray[currentIndex, 4];
                            SettingsClass.ModelP1 = currentArray[currentIndex, 5];
                            SettingsClass.VoiceP1 = currentArray[currentIndex, 7];
                        }
                    }
                    else if (playerIndex == 2)
                    {
                        if (SettingsClass.CharacterP2 != "FX")
                        {
                            SettingsClass.CharacterP2 = currentArray[currentIndex, 4];
                            SettingsClass.ModelP2 = currentArray[currentIndex, 5];
                            SettingsClass.VoiceP2 = currentArray[currentIndex, 7];
                        }
                    }
                }
                else
                {
                    if (playerIndex == 1)
                    {
                        SettingsClass.CharacterP1 = m1;
                        SettingsClass.ModelP1 = m2;
                    }
                    else if (playerIndex == 2)
                    {
                        SettingsClass.CharacterP2 = m1;
                        SettingsClass.ModelP2 = m2;
                    }
                }
            }
            SettingsClass.SaveData();

            bool dangerIsTheBest = true;
            if (dangerIsTheBest)
            {
                CreatePnach.ExportPnachLite();
            }
        }


        private string[,] GetSelectedArray(string imageName)
        {
            string[,] currentArray = viewModel.Empty;
            switch (imageName)
            {
                case "MitsurugiValues":
                    currentArray = viewModel.MitsurugiValues;
                    break;
                case "SeongMinaValues":
                    currentArray = viewModel.SeongMinaValues;
                    break;
                case "TakiValues":
                    currentArray = viewModel.TakiValues;
                    break;
                case "MaxiValues":
                    currentArray = viewModel.MaxiValues;
                    break;
                case "VoldoValues":
                    currentArray = viewModel.VoldoValues;
                    break;
                case "SophitiaValues":
                    currentArray = viewModel.SophitiaValues;
                    break;
                case "SiegfriedValues":
                    currentArray = viewModel.SiegfriedValues;
                    break;
                case "RockValues":
                    currentArray = viewModel.RockValues;
                    break;
                case "IvyValues":
                    currentArray = viewModel.IvyValues;
                    break;
                case "KilikValues":
                    currentArray = viewModel.KilikValues;
                    break;
                case "XianghuaValues":
                    currentArray = viewModel.XianghuaValues;
                    break;
                case "LizardmanValues":
                    currentArray = viewModel.LizardmanValues;
                    break;
                case "YoshimitsuValues":
                    currentArray = viewModel.YoshimitsuValues;
                    break;
                case "NightmareValues":
                    currentArray = viewModel.NightmareValues;
                    break;
                case "AstarothValues":
                    currentArray = viewModel.AstarothValues;
                    break;
                case "CervantesValues":
                    currentArray = viewModel.CervantesValues;
                    break;
                case "RaphaelValues":
                    currentArray = viewModel.RaphaelValues;
                    break;
                case "TalimValues":
                    currentArray = viewModel.TalimValues;
                    break;
                case "CassandraValues":
                    currentArray = viewModel.CassandraValues;
                    break;
                case "YunSeongValues":
                    currentArray = viewModel.YunSeongValues;
                    break;
                case "SetsukaValues":
                    currentArray = viewModel.SetsukaValues;
                    break;
                case "TiraValues":
                    currentArray = viewModel.TiraValues;
                    break;
                case "ZasalamelValues":
                    currentArray = viewModel.ZasalamelValues;
                    break;
                case "OlcadanValues":
                    currentArray = viewModel.OlcadanValues;
                    break;
                case "AbyssValues":
                    currentArray = viewModel.AbyssValues;
                    break;
                case "AmyValues":
                    currentArray = viewModel.AmyValues;
                    break;
                case "MiserValues":
                    currentArray = viewModel.MiserValues;
                    break;
                case "GreedValues":
                    currentArray = viewModel.GreedValues;
                    break;
                case "ArthurValues":
                    currentArray = viewModel.ArthurValues;
                    break;
                case "HwangValues":
                    currentArray = viewModel.HwangValues;
                    break;
                case "LunaValues":
                    currentArray = viewModel.LunaValues;
                    break;
                case "ValeriaValues":
                    currentArray = viewModel.ValeriaValues;
                    break;
                case "HualinValues":
                    currentArray = viewModel.HualinValues;
                    break;
                case "GirardotValues":
                    currentArray = viewModel.GirardotValues;
                    break;
                case "DemuthValues":
                    currentArray = viewModel.DemuthValues;
                    break;
                case "AureliaValues":
                    currentArray = viewModel.AureliaValues;
                    break;
                case "ChesterValues":
                    currentArray = viewModel.ChesterValues;
                    break;
                case "StrifeValues":
                    currentArray = viewModel.StrifeValues;
                    break;
                case "AbeliaValues":
                    currentArray = viewModel.AbeliaValues;
                    break;
                case "LynetteValues":
                    currentArray = viewModel.LynetteValues;
                    break;
                case "LiLongValues":
                    currentArray = viewModel.LiLongValues;
                    break;
                case "RevenantValues":
                    currentArray = viewModel.RevenantValues;
                    break;
                case "LizardMenValues":
                    currentArray = viewModel.LizardMenValues;
                    break;
                case "NightTerrorValues":
                    currentArray = viewModel.NightTerrorValues;
                    break;
                case "CharadeValues":
                    currentArray = viewModel.CharadeValues;
                    break;
                case "InfernoValues":
                    currentArray = viewModel.InfernoValues;
                    break;
                case "ShadowMasterValues":
                    currentArray = viewModel.ShadowMasterValues;
                    break;
                case "ColossusValues":
                    currentArray = viewModel.ColossusValues;
                    break;
                case "BerserkerValues":
                    currentArray = viewModel.BerserkerValues;
                    break;
                case "Samurai1Values":
                    currentArray = viewModel.Samurai1Values;
                    break;
                case "Samurai2Values":
                    currentArray = viewModel.Samurai2Values;
                    break;
                case "Samurai3Values":
                    currentArray = viewModel.Samurai3Values;
                    break;
                case "Samurai4Values":
                    currentArray = viewModel.Samurai4Values;
                    break;
                case "Gladiator1Values":
                    currentArray = viewModel.Gladiator1Values;
                    break;
                case "Gladiator2Values":
                    currentArray = viewModel.Gladiator2Values;
                    break;
                case "UnknownSoulValues":
                    currentArray = viewModel.UnknownSoulValues;
                    break;
                case "FumaNinja1Values":
                    currentArray = viewModel.FumaNinja1Values;
                    break;
                case "FumaNinja2Values":
                    currentArray = viewModel.FumaNinja2Values;
                    break;
                case "FumaNinja3Values":
                    currentArray = viewModel.FumaNinja3Values;
                    break;
                case "FumaNinja4Values":
                    currentArray = viewModel.FumaNinja4Values;
                    break;
                case "FumaNinja5Values":
                    currentArray = viewModel.FumaNinja5Values;
                    break;
                case "FumaNinja6Values":
                    currentArray = viewModel.FumaNinja6Values;
                    break;
                case "FumaNinja7Values":
                    currentArray = viewModel.FumaNinja7Values;
                    break;
                case "Bandit1Values":
                    currentArray = viewModel.Bandit1Values;
                    break;
                case "Bandit2Values":
                    currentArray = viewModel.Bandit2Values;
                    break;
                case "Bandit3Values":
                    currentArray = viewModel.Bandit3Values;
                    break;
                case "Thief1Values":
                    currentArray = viewModel.Thief1Values;
                    break;
                case "Thief2Values":
                    currentArray = viewModel.Thief2Values;
                    break;
                case "Pirate1Values":
                    currentArray = viewModel.Pirate1Values;
                    break;
                case "Pirate2Values":
                    currentArray = viewModel.Pirate2Values;
                    break;
                case "Pirate3Values":
                    currentArray = viewModel.Pirate3Values;
                    break;
                case "Pirate4Values":
                    currentArray = viewModel.Pirate4Values;
                    break;
                case "Pirate5Values":
                    currentArray = viewModel.Pirate5Values;
                    break;
                case "Pirate6Values":
                    currentArray = viewModel.Pirate6Values;
                    break;
                case "Pirate7Values":
                    currentArray = viewModel.Pirate7Values;
                    break;
                case "AssassinValues":
                    currentArray = viewModel.AssassinValues;
                    break;
                case "Swordsman1Values":
                    currentArray = viewModel.Swordsman1Values;
                    break;
                case "Swordsman2Values":
                    currentArray = viewModel.Swordsman2Values;
                    break;
                case "FootSoldierValues":
                    currentArray = viewModel.FootSoldierValues;
                    break;
                case "GeneralValues":
                    currentArray = viewModel.GeneralValues;
                    break;
                case "SentryValues":
                    currentArray = viewModel.SentryValues;
                    break;
                case "KeresValues":
                    currentArray = viewModel.KeresValues;
                    break;
                case "DragonValues":
                    currentArray = viewModel.DragonValues;
                    break;
                case "XValues":
                    currentArray = viewModel.XValues;
                    break;
                case "JinkaiValues":
                    currentArray = viewModel.JinkaiValues;
                    break;
                case "KagamiValues":
                    currentArray = viewModel.KagamiValues;
                    break;
                case "ShiunValues":
                    currentArray = viewModel.ShiunValues;
                    break;
                case "ShiinaValues":
                    currentArray = viewModel.ShiinaValues;
                    break;
                case "ChikageValues":
                    currentArray = viewModel.ChikageValues;
                    break;
                case "KonomiValues":
                    currentArray = viewModel.KonomiValues;
                    break;
                case "CassiusValues":
                    currentArray = viewModel.CassiusValues;
                    break;
                case "SaizouValues":
                    currentArray = viewModel.SaizouValues;
                    break;
                case "RyougaValues":
                    currentArray = viewModel.RyougaValues;
                    break;
                case "KimikaValues":
                    currentArray = viewModel.KimikaValues;
                    break;
                case "SyunnaValues":
                    currentArray = viewModel.SyunnaValues;
                    break;
                case "TomoeValues":
                    currentArray = viewModel.TomoeValues;
                    break;
                case "MeigaValues":
                    currentArray = viewModel.MeigaValues;
                    break;
                case "AlastorValues":
                    currentArray = viewModel.AlastorValues;
                    break;
                case "ShizumaValues":
                    currentArray = viewModel.ShizumaValues;
                    break;
                case "AzumiValues":
                    currentArray = viewModel.AzumiValues;
                    break;
                case "YukinaValues":
                    currentArray = viewModel.YukinaValues;
                    break;
                case "OukaValues":
                    currentArray = viewModel.OukaValues;
                    break;
                case "XiaoxinValues":
                    currentArray = viewModel.XiaoxinValues;
                    break;
                case "OruksValues":
                    currentArray = viewModel.OruksValues;
                    break;
                case "AgarethValues":
                    currentArray = viewModel.AgarethValues;
                    break;
                case "JyuriValues":
                    currentArray = viewModel.JyuriValues;
                    break;
                case "ShuyuValues":
                    currentArray = viewModel.ShuyuValues;
                    break;
                case "MingyueValues":
                    currentArray = viewModel.MingyueValues;
                    break;
                case "VelesValues":
                    currentArray = viewModel.VelesValues;
                    break;
                case "AetherValues":
                    currentArray = viewModel.AetherValues;
                    break;
                case "IxionValues":
                    currentArray = viewModel.IxionValues;
                    break;
                case "SiulanValues":
                    currentArray = viewModel.SiulanValues;
                    break;
                case "FenglinValues":
                    currentArray = viewModel.FenglinValues;
                    break;
                case "PhilineValues":
                    currentArray = viewModel.PhilineValues;
                    break;
                case "IgnisValues":
                    currentArray = viewModel.IgnisValues;
                    break;
                case "NotusValues":
                    currentArray = viewModel.NotusValues;
                    break;
                case "AzraelValues":
                    currentArray = viewModel.AzraelValues;
                    break;
                case "MireilleValues":
                    currentArray = viewModel.MireilleValues;
                    break;
                case "AglaiaValues":
                    currentArray = viewModel.AglaiaValues;
                    break;
                case "KanonValues":
                    currentArray = viewModel.KanonValues;
                    break;
                case "JyuraiValues":
                    currentArray = viewModel.JyuraiValues;
                    break;
                case "KurehaValues":
                    currentArray = viewModel.KurehaValues;
                    break;
                case "XunyuValues":
                    currentArray = viewModel.XunyuValues;
                    break;
                case "FengyuValues":
                    currentArray = viewModel.FengyuValues;
                    break;
                case "FengleiValues":
                    currentArray = viewModel.FengleiValues;
                    break;
                case "MinglianValues":
                    currentArray = viewModel.MinglianValues;
                    break;
                case "NoelValues":
                    currentArray = viewModel.NoelValues;
                    break;
                case "RudigerValues":
                    currentArray = viewModel.RudigerValues;
                    break;
                case "AeneasValues":
                    currentArray = viewModel.AeneasValues;
                    break;
                case "AnnarettaValues":
                    currentArray = viewModel.AnnarettaValues;
                    break;
                case "IrisValues":
                    currentArray = viewModel.IrisValues;
                    break;
                case "BrunhildValues":
                    currentArray = viewModel.BrunhildValues;
                    break;
                case "AsrafilValues":
                    currentArray = viewModel.AsrafilValues;
                    break;
                case "ZifengValues":
                    currentArray = viewModel.ZifengValues;
                    break;
                case "AeolosValues":
                    currentArray = viewModel.AeolosValues;
                    break;
                case "AmritaValues":
                    currentArray = viewModel.AmritaValues;
                    break;
                case "AzaleaValues":
                    currentArray = viewModel.AzaleaValues;
                    break;
                case "YueliangValues":
                    currentArray = viewModel.YueliangValues;
                    break;
                case "KanadeValues":
                    currentArray = viewModel.KanadeValues;
                    break;
                case "DomenthiValues":
                    currentArray = viewModel.DomenthiValues;
                    break;
                case "MaridValues":
                    currentArray = viewModel.MaridValues;
                    break;
                case "AmbroseValues":
                    currentArray = viewModel.AmbroseValues;
                    break;
                case "AilianValues":
                    currentArray = viewModel.AilianValues;
                    break;
                case "AikaValues":
                    currentArray = viewModel.AikaValues;
                    break;
                case "LokiValues":
                    currentArray = viewModel.LokiValues;
                    break;
                case "CelestisValues":
                    currentArray = viewModel.CelestisValues;
                    break;
                case "BelethValues":
                    currentArray = viewModel.BelethValues;
                    break;
                case "KarenValues":
                    currentArray = viewModel.KarenValues;
                    break;
                case "LilanValues":
                    currentArray = viewModel.LilanValues;
                    break;
                case "AbigailValues":
                    currentArray = viewModel.AbigailValues;
                    break;
                case "BalduinValues":
                    currentArray = viewModel.BalduinValues;
                    break;
                case "AlocesValues":
                    currentArray = viewModel.AlocesValues;
                    break;
                case "AreonValues":
                    currentArray = viewModel.AreonValues;
                    break;
                case "JunoValues":
                    currentArray = viewModel.JunoValues;
                    break;
                case "EurydiceValues":
                    currentArray = viewModel.EurydiceValues;
                    break;
                case "IshtarValues":
                    currentArray = viewModel.IshtarValues;
                    break;
                case "RufusValues":
                    currentArray = viewModel.RufusValues;
                    break;
                case "RaguelValues":
                    currentArray = viewModel.RaguelValues;
                    break;
                case "FeofanValues":
                    currentArray = viewModel.FeofanValues;
                    break;
                case "EuniceValues":
                    currentArray = viewModel.EuniceValues;
                    break;
                case "AcaciaValues":
                    currentArray = viewModel.AcaciaValues;
                    break;
                case "HildaValues":
                    currentArray = viewModel.HildaValues;
                    break;
                case "IblisValues":
                    currentArray = viewModel.IblisValues;
                    break;
                case "AlbericValues":
                    currentArray = viewModel.AlbericValues;
                    break;
                case "LeshyValues":
                    currentArray = viewModel.LeshyValues;
                    break;
                case "MurielValues":
                    currentArray = viewModel.MurielValues;
                    break;
                case "WenliValues":
                    currentArray = viewModel.WenliValues;
                    break;
                case "IreneValues":
                    currentArray = viewModel.IreneValues;
                    break;
                case "YufengValues":
                    currentArray = viewModel.YufengValues;
                    break;
                case "YakumoValues":
                    currentArray = viewModel.YakumoValues;
                    break;
                case "DufengValues":
                    currentArray = viewModel.DufengValues;
                    break;
                case "MayuraValues":
                    currentArray = viewModel.MayuraValues;
                    break;
                case "MeilanValues":
                    currentArray = viewModel.MeilanValues;
                    break;
                case "RheaValues":
                    currentArray = viewModel.RheaValues;
                    break;
                case "HalphasValues":
                    currentArray = viewModel.HalphasValues;
                    break;
                case "GorusValues":
                    currentArray = viewModel.GorusValues;
                    break;
                case "IlyushaValues":
                    currentArray = viewModel.IlyushaValues;
                    break;
                case "EdithValues":
                    currentArray = viewModel.EdithValues;
                    break;
                case "RieseValues":
                    currentArray = viewModel.RieseValues;
                    break;
                case "AgaveValues":
                    currentArray = viewModel.AgaveValues;
                    break;
                case "HaystirValues":
                    currentArray = viewModel.HaystirValues;
                    break;
                case "LerajeValues":
                    currentArray = viewModel.LerajeValues;
                    break;
                case "RatzielValues":
                    currentArray = viewModel.RatzielValues;
                    break;
                case "KatinaValues":
                    currentArray = viewModel.KatinaValues;
                    break;
                case "ErisValues":
                    currentArray = viewModel.ErisValues;
                    break;
                case "SizukuValues":
                    currentArray = viewModel.SizukuValues;
                    break;
                case "GrandallMaleValues":
                    currentArray = viewModel.GrandallMaleValues;
                    break;
                case "DalkiaMaleValues":
                    currentArray = viewModel.DalkiaMaleValues;
                    break;
                case "BrigandMaleValues":
                    currentArray = viewModel.BrigandMaleValues;
                    break;
                case "MalettaMaleValues":
                    currentArray = viewModel.MalettaMaleValues;
                    break;
                case "RebelMaleValues":
                    currentArray = viewModel.RebelMaleValues;
                    break;
                case "GrandallFemaleValues":
                    currentArray = viewModel.GrandallFemaleValues;
                    break;
                case "DalkiaFemaleValues":
                    currentArray = viewModel.DalkiaFemaleValues;
                    break;
                case "BrigandFemaleValues":
                    currentArray = viewModel.BrigandFemaleValues;
                    break;
                case "MalettaFemaleValues":
                    currentArray = viewModel.MalettaFemaleValues;
                    break;
                case "RebelFemaleValues":
                    currentArray = viewModel.RebelFemaleValues;
                    break;
                case "ExtraValues":
                    currentArray = viewModel.ExtraValues;
                    break;
                case "TinaValues":
                    currentArray = viewModel.TinaValues;
                    break;
                case "AegeValues":
                    currentArray = viewModel.AegeValues;
                    break;
                case "HealDoValues":
                    currentArray = viewModel.HealDoValues;
                    break;
                case "EluaValues":
                    currentArray = viewModel.EluaValues;
                    break;
                case "LupiValues":
                    currentArray = viewModel.LupiValues;
                    break;
                case "RoinValues":
                    currentArray = viewModel.RoinValues;
                    break;
                case "KierkessValues":
                    currentArray = viewModel.KierkessValues;
                    break;
                case "HyleValues":
                    currentArray = viewModel.HyleValues;
                    break;
                case "MooncalfValues":
                    currentArray = viewModel.MooncalfValues;
                    break;
                case "EndeValues":
                    currentArray = viewModel.EndeValues;
                    break;
                case "RandomValues":
                    currentArray = viewModel.RandomValues;
                    break;
                case "BossValues":
                    currentArray = viewModel.BossValues;
                    break;
                case "BossValues2":
                    currentArray = viewModel.BossValues2;
                    break;
            }
            return currentArray;
        }

        private void GoToMainPage_Click(object sender, RoutedEventArgs e)
        {
            SettingsClass.SaveData();
            viewModel.DisplayMainView();
        }

        private void MouseLeftClickSound(object sender, MouseButtonEventArgs e)
        {
            if (soundOn)
            {
                viewModel.SoundButton = "/Resources/SoundOff.png";
                customSound.Volume = 0;
            }
            else
            {
                viewModel.SoundButton = "/Resources/SoundOn.png";
                customSound.Volume = 0.1;
            }

            soundOn = !soundOn;
        }

        private void ResetP1(object sender, MouseButtonEventArgs e)
        {
            CharacterSelect(1, "none", false, "", "");
            viewModel.Player1Character = "/Resources/none.png";

            SettingsClass.LastSelectedCharP1 = "";
            SettingsClass.LastSelectedIndexP1 = -1;
            SettingsClass.SaveData();
        }

        private void ResetP2(object sender, MouseButtonEventArgs e)
        {
            CharacterSelect(2, "none", false, "", "");
            viewModel.Player2Character = "/Resources/none.png";

            SettingsClass.LastSelectedCharP2 = "";
            SettingsClass.LastSelectedIndexP2 = -1;
            SettingsClass.SaveData();
        }

        private void Char_Info(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Select any warrior you want from anywhere in the game\n" +
                "Left Mouse Button = Select Player 1 Character\n" +
                "Right Mouse Button = Select player 2 Character\n" +
                "Scroll Up-Down on Mouse Wheel = Costume/Discipline Switch\n" +
                "Right Mouse Button on Character Preview to unselect character");
            return;
        }


        private void GetPlayerHex(int playerIndex)
        {
            int playerHex = 0;
            playerHex = new Random().Next(10, 206);
            string modelString = "";
            int secondRandom = 0;
            string m1 = "";
            string m2 = "";

            switch (playerHex)
            {
                //Standard
                case 1:
                    secondRandom = new Random().Next(1, 5);
                    switch (secondRandom)
                    {
                        case 1:
                            m1 = "01";
                            m2 = "00";
                            break;
                        case 2:
                            m1 = "01";
                            m2 = "01";
                            break;
                        case 3:
                            m1 = "01";
                            m2 = "08";
                            break;
                        case 4:
                            m1 = "01";
                            m2 = "09";
                            break;
                    }
                    break;
                case 2:
                    secondRandom = new Random().Next(1, 5);
                    switch (secondRandom)
                    {
                        case 1:
                            m1 = "02";
                            m2 = "00";
                            break;
                        case 2:
                            m1 = "02";
                            m2 = "01";
                            break;
                        case 3:
                            m1 = "02";
                            m2 = "08";
                            break;
                        case 4:
                            m1 = "02";
                            m2 = "09";
                            break;
                    }
                    break;
                case 3:
                    secondRandom = new Random().Next(1, 5);
                    switch (secondRandom)
                    {
                        case 1:
                            m1 = "03";
                            m2 = "00";
                            break;
                        case 2:
                            m1 = "03";
                            m2 = "01";
                            break;
                        case 3:
                            m1 = "03";
                            m2 = "08";
                            break;
                        case 4:
                            m1 = "03";
                            m2 = "09";
                            break;
                    }
                    break;
                case 4:
                    secondRandom = new Random().Next(1, 5);
                    switch (secondRandom)
                    {
                        case 1:
                            m1 = "04";
                            m2 = "00";
                            break;
                        case 2:
                            m1 = "04";
                            m2 = "01";
                            break;
                        case 3:
                            m1 = "04";
                            m2 = "08";
                            break;
                        case 4:
                            m1 = "04";
                            m2 = "09";
                            break;
                    }
                    break;
                case 5:
                    secondRandom = new Random().Next(1, 5);
                    switch (secondRandom)
                    {
                        case 1:
                            m1 = "05";
                            m2 = "00";
                            break;
                        case 2:
                            m1 = "05";
                            m2 = "01";
                            break;
                        case 3:
                            m1 = "05";
                            m2 = "08";
                            break;
                        case 4:
                            m1 = "05";
                            m2 = "09";
                            break;
                    }
                    break;
                case 6:
                    secondRandom = new Random().Next(1, 5);
                    switch (secondRandom)
                    {
                        case 1:
                            m1 = "06";
                            m2 = "00";
                            break;
                        case 2:
                            m1 = "06";
                            m2 = "01";
                            break;
                        case 3:
                            m1 = "06";
                            m2 = "08";
                            break;
                        case 4:
                            m1 = "06";
                            m2 = "09";
                            break;
                    }
                    break;
                case 7:
                    secondRandom = new Random().Next(1, 5);
                    switch (secondRandom)
                    {
                        case 1:
                            m1 = "07";
                            m2 = "00";
                            break;
                        case 2:
                            m1 = "07";
                            m2 = "01";
                            break;
                        case 3:
                            m1 = "07";
                            m2 = "08";
                            break;
                        case 4:
                            m1 = "07";
                            m2 = "09";
                            break;
                    }
                    break;
                case 8:
                    secondRandom = new Random().Next(1, 5);
                    switch (secondRandom)
                    {
                        case 1:
                            m1 = "08";
                            m2 = "00";
                            break;
                        case 2:
                            m1 = "08";
                            m2 = "01";
                            break;
                        case 3:
                            m1 = "08";
                            m2 = "08";
                            break;
                        case 4:
                            m1 = "08";
                            m2 = "09";
                            break;
                    }
                    break;
                case 9:
                    secondRandom = new Random().Next(1, 5);
                    switch (secondRandom)
                    {
                        case 1:
                            m1 = "0B";
                            m2 = "00";
                            break;
                        case 2:
                            m1 = "0B";
                            m2 = "01";
                            break;
                        case 3:
                            m1 = "0B";
                            m2 = "08";
                            break;
                        case 4:
                            m1 = "0B";
                            m2 = "09";
                            break;
                    }
                    break;
                case 10:
                    secondRandom = new Random().Next(1, 5);
                    switch (secondRandom)
                    {
                        case 1:
                            m1 = "0C";
                            m2 = "00";
                            break;
                        case 2:
                            m1 = "0C";
                            m2 = "01";
                            break;
                        case 3:
                            m1 = "0C";
                            m2 = "08";
                            break;
                        case 4:
                            m1 = "0C";
                            m2 = "09";
                            break;
                    }
                    break;
                case 11:
                    secondRandom = new Random().Next(1, 5);
                    switch (secondRandom)
                    {
                        case 1:
                            m1 = "0D";
                            m2 = "00";
                            break;
                        case 2:
                            m1 = "0D";
                            m2 = "01";
                            break;
                        case 3:
                            m1 = "0D";
                            m2 = "08";
                            break;
                        case 4:
                            m1 = "0D";
                            m2 = "09";
                            break;
                    }
                    break;
                case 12:
                    secondRandom = new Random().Next(1, 8);
                    switch (secondRandom)
                    {
                        case 1:
                            m1 = "0E";
                            m2 = "00";
                            break;
                        case 2:
                            m1 = "0E";
                            m2 = "01";
                            break;
                        case 3:
                            m1 = "0E";
                            m2 = "08";
                            break;
                        case 4:
                            m1 = "0E";
                            m2 = "09";
                            break;
                        case 5:
                            m1 = "36";
                            m2 = "00";
                            break;
                        case 6:
                            m1 = "37";
                            m2 = "00";
                            break;
                        case 7:
                            m1 = "38";
                            m2 = "00";
                            break;
                    }
                    break;
                case 13:
                    secondRandom = new Random().Next(1, 5);
                    switch (secondRandom)
                    {
                        case 1:
                            m1 = "0F";
                            m2 = "00";
                            break;
                        case 2:
                            m1 = "0F";
                            m2 = "01";
                            break;
                        case 3:
                            m1 = "0F";
                            m2 = "08";
                            break;
                        case 4:
                            m1 = "0F";
                            m2 = "09";
                            break;
                    }
                    break;
                case 14:
                    secondRandom = new Random().Next(1, 5);
                    switch (secondRandom)
                    {
                        case 1:
                            m1 = "11";
                            m2 = "00";
                            break;
                        case 2:
                            m1 = "11";
                            m2 = "01";
                            break;
                        case 3:
                            m1 = "11";
                            m2 = "08";
                            break;
                        case 4:
                            m1 = "11";
                            m2 = "09";
                            break;
                    }
                    break;
                case 15:
                    secondRandom = new Random().Next(1, 5);
                    switch (secondRandom)
                    {
                        case 1:
                            m1 = "12";
                            m2 = "00";
                            break;
                        case 2:
                            m1 = "12";
                            m2 = "01";
                            break;
                        case 3:
                            m1 = "12";
                            m2 = "08";
                            break;
                        case 4:
                            m1 = "12";
                            m2 = "09";
                            break;
                    }
                    break;
                case 16:
                    secondRandom = new Random().Next(1, 5);
                    switch (secondRandom)
                    {
                        case 1:
                            m1 = "14";
                            m2 = "00";
                            break;
                        case 2:
                            m1 = "14";
                            m2 = "01";
                            break;
                        case 3:
                            m1 = "14";
                            m2 = "08";
                            break;
                        case 4:
                            m1 = "14";
                            m2 = "09";
                            break;
                    }
                    break;
                case 17:
                    secondRandom = new Random().Next(1, 5);
                    switch (secondRandom)
                    {
                        case 1:
                            m1 = "15";
                            m2 = "00";
                            break;
                        case 2:
                            m1 = "15";
                            m2 = "01";
                            break;
                        case 3:
                            m1 = "15";
                            m2 = "08";
                            break;
                        case 4:
                            m1 = "15";
                            m2 = "09";
                            break;
                    }
                    break;
                case 18:
                    secondRandom = new Random().Next(1, 5);
                    switch (secondRandom)
                    {
                        case 1:
                            m1 = "16";
                            m2 = "00";
                            break;
                        case 2:
                            m1 = "16";
                            m2 = "01";
                            break;
                        case 3:
                            m1 = "16";
                            m2 = "08";
                            break;
                        case 4:
                            m1 = "16";
                            m2 = "09";
                            break;
                    }
                    break;
                case 19:
                    secondRandom = new Random().Next(1, 5);
                    switch (secondRandom)
                    {
                        case 1:
                            m1 = "17";
                            m2 = "00";
                            break;
                        case 2:
                            m1 = "17";
                            m2 = "01";
                            break;
                        case 3:
                            m1 = "17";
                            m2 = "08";
                            break;
                        case 4:
                            m1 = "17";
                            m2 = "09";
                            break;
                    }
                    break;
                case 20:
                    secondRandom = new Random().Next(1, 5);
                    switch (secondRandom)
                    {
                        case 1:
                            m1 = "1A";
                            m2 = "00";
                            break;
                        case 2:
                            m1 = "1A";
                            m2 = "01";
                            break;
                        case 3:
                            m1 = "1A";
                            m2 = "08";
                            break;
                        case 4:
                            m1 = "1A";
                            m2 = "09";
                            break;
                    }
                    break;
                case 21:
                    secondRandom = new Random().Next(1, 5);
                    switch (secondRandom)
                    {
                        case 1:
                            m1 = "22";
                            m2 = "00";
                            break;
                        case 2:
                            m1 = "22";
                            m2 = "01";
                            break;
                        case 3:
                            m1 = "22";
                            m2 = "08";
                            break;
                        case 4:
                            m1 = "22";
                            m2 = "09";
                            break;
                    }
                    break;
                case 22:
                    secondRandom = new Random().Next(1, 5);
                    switch (secondRandom)
                    {
                        case 1:
                            m1 = "23";
                            m2 = "00";
                            break;
                        case 2:
                            m1 = "23";
                            m2 = "01";
                            break;
                        case 3:
                            m1 = "23";
                            m2 = "08";
                            break;
                        case 4:
                            m1 = "23";
                            m2 = "09";
                            break;
                    }
                    break;
                case 23:
                    secondRandom = new Random().Next(1, 6);
                    switch (secondRandom)
                    {
                        case 1:
                            m1 = "24";
                            m2 = "00";
                            break;
                        case 2:
                            m1 = "24";
                            m2 = "01";
                            break;
                        case 3:
                            m1 = "24";
                            m2 = "08";
                            break;
                        case 4:
                            m1 = "24";
                            m2 = "09";
                            break;
                        case 5:
                            m1 = "35";
                            m2 = "00";
                            break;
                    }
                    break;
                case 24:
                    secondRandom = new Random().Next(1, 5);
                    switch (secondRandom)
                    {
                        case 1:
                            m1 = "25";
                            m2 = "00";
                            break;
                        case 2:
                            m1 = "25";
                            m2 = "01";
                            break;
                        case 3:
                            m1 = "25";
                            m2 = "08";
                            break;
                        case 4:
                            m1 = "25";
                            m2 = "09";
                            break;
                    }
                    break;
                case 25:
                    secondRandom = new Random().Next(1, 5);
                    switch (secondRandom)
                    {
                        case 1:
                            m1 = "26";
                            m2 = "00";
                            break;
                        case 2:
                            m1 = "26";
                            m2 = "01";
                            break;
                        case 3:
                            m1 = "26";
                            m2 = "08";
                            break;
                        case 4:
                            m1 = "26";
                            m2 = "09";
                            break;
                    }
                    break;
                //Bonus
                case 26:
                    secondRandom = new Random().Next(1, 3);
                    switch (secondRandom)
                    {
                        case 1:
                            m1 = "30";
                            m2 = "00";
                            break;
                        case 2:
                            m1 = "30";
                            m2 = "01";
                            break;
                    }
                    break;
                case 27:
                    secondRandom = new Random().Next(1, 3);
                    switch (secondRandom)
                    {
                        case 1:
                            m1 = "41";
                            m2 = "00";
                            break;
                        case 2:
                            m1 = "41";
                            m2 = "01";
                            break;
                    }
                    break;
                case 28:
                    secondRandom = new Random().Next(1, 3);
                    switch (secondRandom)
                    {
                        case 1:
                            m1 = "42";
                            m2 = "00";
                            break;
                        case 2:
                            m1 = "42";
                            m2 = "01";
                            break;
                    }
                    break;
                case 29:
                    secondRandom = new Random().Next(1, 3);
                    switch (secondRandom)
                    {
                        case 1:
                            m1 = "43";
                            m2 = "00";
                            break;
                        case 2:
                            m1 = "43";
                            m2 = "01";
                            break;
                    }
                    break;
                case 30:
                    secondRandom = new Random().Next(1, 3);
                    switch (secondRandom)
                    {
                        case 1:
                            m1 = "44";
                            m2 = "00";
                            break;
                        case 2:
                            m1 = "44";
                            m2 = "01";
                            break;
                    }
                    break;
                case 31:
                    secondRandom = new Random().Next(1, 4);
                    switch (secondRandom)
                    {
                        case 1:
                            m1 = "45";
                            m2 = "00";
                            break;
                        case 2:
                            m1 = "45";
                            m2 = "01";
                            break;
                        case 3:
                            m1 = "E1";
                            m2 = "02";
                            break;
                    }
                    break;
                case 32:
                    secondRandom = new Random().Next(1, 3);
                    switch (secondRandom)
                    {
                        case 1:
                            m1 = "46";
                            m2 = "00";
                            break;
                        case 2:
                            m1 = "46";
                            m2 = "01";
                            break;
                    }
                    break;
                case 33:
                    secondRandom = new Random().Next(1, 3);
                    switch (secondRandom)
                    {
                        case 1:
                            m1 = "47";
                            m2 = "00";
                            break;
                        case 2:
                            m1 = "47";
                            m2 = "01";
                            break;
                    }
                    break;
                case 34:
                    secondRandom = new Random().Next(1, 3);
                    switch (secondRandom)
                    {
                        case 1:
                            m1 = "48";
                            m2 = "00";
                            break;
                        case 2:
                            m1 = "48";
                            m2 = "01";
                            break;
                    }
                    break;
                case 35:
                    secondRandom = new Random().Next(1, 3);
                    switch (secondRandom)
                    {
                        case 1:
                            m1 = "4A";
                            m2 = "00";
                            break;
                        case 2:
                            m1 = "4A";
                            m2 = "01";
                            break;
                    }
                    break;
                case 36:
                    secondRandom = new Random().Next(1, 3);
                    switch (secondRandom)
                    {
                        case 1:
                            m1 = "4B";
                            m2 = "00";
                            break;
                        case 2:
                            m1 = "4B";
                            m2 = "01";
                            break;
                    }
                    break;
                case 37:
                    secondRandom = new Random().Next(1, 4);
                    switch (secondRandom)
                    {
                        case 1:
                            m1 = "4C";
                            m2 = "00";
                            break;
                        case 2:
                            m1 = "4C";
                            m2 = "01";
                            break;
                        case 3:
                            m1 = "E4";
                            m2 = "00";
                            break;
                    }
                    break;
                case 38:
                    secondRandom = new Random().Next(1, 3);
                    switch (secondRandom)
                    {
                        case 1:
                            m1 = "4D";
                            m2 = "00";
                            break;
                        case 2:
                            m1 = "4D";
                            m2 = "01";
                            break;
                    }
                    break;
                case 39:
                    secondRandom = new Random().Next(1, 4);
                    switch (secondRandom)
                    {
                        case 1:
                            m1 = "4E";
                            m2 = "00";
                            break;
                        case 2:
                            m1 = "4E";
                            m2 = "01";
                            break;
                        case 3:
                            m1 = "E0";
                            m2 = "02";
                            break;
                    }
                    break;
                case 40:
                    secondRandom = new Random().Next(1, 3);
                    switch (secondRandom)
                    {
                        case 1:
                            m1 = "4F";
                            m2 = "00";
                            break;
                        case 2:
                            m1 = "4F";
                            m2 = "01";
                            break;
                    }
                    break;
                case 41:
                    secondRandom = new Random().Next(1, 3);
                    switch (secondRandom)
                    {
                        case 1:
                            m1 = "51";
                            m2 = "00";
                            break;
                        case 2:
                            m1 = "51";
                            m2 = "01";
                            break;
                    }
                    break;
                case 42:
                    secondRandom = new Random().Next(1, 3);
                    switch (secondRandom)
                    {
                        case 1:
                            m1 = "54";
                            m2 = "00";
                            break;
                        case 2:
                            m1 = "54";
                            m2 = "01";
                            break;
                    }
                    break;
                //ToS NPC
                case 43:
                    secondRandom = new Random().Next(1, 2);
                    switch (secondRandom)
                    {
                        case 1:
                            m1 = "1E";
                            m2 = "00";
                            break;
                    }
                    break;
                case 44:
                    secondRandom = new Random().Next(1, 2);
                    switch (secondRandom)
                    {
                        case 1:
                            m1 = "27";
                            m2 = "00";
                            break;
                    }
                    break;
                case 45:
                    secondRandom = new Random().Next(1, 4);
                    switch (secondRandom)
                    {
                        case 1:
                            m1 = "28";
                            m2 = "00";
                            break;
                        case 2:
                            m1 = "29";
                            m2 = "00";
                            break;
                        case 3:
                            m1 = "2A";
                            m2 = "00";
                            break;
                    }
                    break;
                case 46:
                    secondRandom = new Random().Next(1, 2);
                    switch (secondRandom)
                    {
                        case 1:
                            m1 = "2B";
                            m2 = "00";
                            break;
                    }
                    break;
                case 47:
                    secondRandom = new Random().Next(1, 2);
                    switch (secondRandom)
                    {
                        case 1:
                            m1 = "2E";
                            m2 = "00";
                            break;
                    }
                    break;
                case 48:
                    secondRandom = new Random().Next(1, 2);
                    switch (secondRandom)
                    {
                        case 1:
                            m1 = "31";
                            m2 = "00";
                            break;
                    }
                    break;
                case 49:
                    secondRandom = new Random().Next(1, 2);
                    switch (secondRandom)
                    {
                        case 1:
                            m1 = "81";
                            m2 = "00";
                            break;
                    }
                    break;
                case 50:
                    secondRandom = new Random().Next(1, 2);
                    switch (secondRandom)
                    {
                        case 1:
                            m1 = "84";
                            m2 = "00";
                            break;
                    }
                    break;
                case 51:
                    secondRandom = new Random().Next(1, 2);
                    switch (secondRandom)
                    {
                        case 1:
                            m1 = "84";
                            m2 = "01";
                            break;
                    }
                    break;
                case 52:
                    secondRandom = new Random().Next(1, 2);
                    switch (secondRandom)
                    {
                        case 1:
                            m1 = "84";
                            m2 = "02";
                            break;
                    }
                    break;
                case 53:
                    secondRandom = new Random().Next(1, 2);
                    switch (secondRandom)
                    {
                        case 1:
                            m1 = "84";
                            m2 = "03";
                            break;
                    }
                    break;
                case 54:
                    secondRandom = new Random().Next(1, 2);
                    switch (secondRandom)
                    {
                        case 1:
                            m1 = "85";
                            m2 = "00";
                            break;
                    }
                    break;
                case 55:
                    secondRandom = new Random().Next(1, 2);
                    switch (secondRandom)
                    {
                        case 1:
                            m1 = "86";
                            m2 = "00";
                            break;
                    }
                    break;
                case 56:
                    secondRandom = new Random().Next(1, 4);
                    switch (secondRandom)
                    {
                        case 1:
                            m1 = "87";
                            m2 = "00";
                            break;
                        case 2:
                            m1 = "88";
                            m2 = "00";
                            break;
                        case 3:
                            m1 = "89";
                            m2 = "00";
                            break;
                    }
                    break;
                case 57:
                    secondRandom = new Random().Next(1, 2);
                    switch (secondRandom)
                    {
                        case 1:
                            m1 = "8A";
                            m2 = "00";
                            break;
                    }
                    break;
                case 58:
                    secondRandom = new Random().Next(1, 2);
                    switch (secondRandom)
                    {
                        case 1:
                            m1 = "8B";
                            m2 = "00";
                            break;
                    }
                    break;
                case 59:
                    secondRandom = new Random().Next(1, 2);
                    switch (secondRandom)
                    {
                        case 1:
                            m1 = "8B";
                            m2 = "01";
                            break;
                    }
                    break;
                case 60:
                    secondRandom = new Random().Next(1, 2);
                    switch (secondRandom)
                    {
                        case 1:
                            m1 = "8C";
                            m2 = "00";
                            break;
                    }
                    break;
                case 61:
                    secondRandom = new Random().Next(1, 2);
                    switch (secondRandom)
                    {
                        case 1:
                            m1 = "8C";
                            m2 = "01";
                            break;
                    }
                    break;
                case 62:
                    secondRandom = new Random().Next(1, 2);
                    switch (secondRandom)
                    {
                        case 1:
                            m1 = "8C";
                            m2 = "02";
                            break;
                    }
                    break;
                case 63:
                    secondRandom = new Random().Next(1, 2);
                    switch (secondRandom)
                    {
                        case 1:
                            m1 = "8C";
                            m2 = "03";
                            break;
                    }
                    break;
                case 64:
                    secondRandom = new Random().Next(1, 2);
                    switch (secondRandom)
                    {
                        case 1:
                            m1 = "8D";
                            m2 = "00";
                            break;
                    }
                    break;
                case 65:
                    secondRandom = new Random().Next(1, 2);
                    switch (secondRandom)
                    {
                        case 1:
                            m1 = "8E";
                            m2 = "00";
                            break;
                    }
                    break;
                case 66:
                    secondRandom = new Random().Next(1, 2);
                    switch (secondRandom)
                    {
                        case 1:
                            m1 = "8E";
                            m2 = "01";
                            break;
                    }
                    break;
                case 67:
                    secondRandom = new Random().Next(1, 2);
                    switch (secondRandom)
                    {
                        case 1:
                            m1 = "8F";
                            m2 = "00";
                            break;
                    }
                    break;
                case 68:
                    secondRandom = new Random().Next(1, 2);
                    switch (secondRandom)
                    {
                        case 1:
                            m1 = "90";
                            m2 = "00";
                            break;
                    }
                    break;
                case 69:
                    secondRandom = new Random().Next(1, 2);
                    switch (secondRandom)
                    {
                        case 1:
                            m1 = "91";
                            m2 = "00";
                            break;
                    }
                    break;
                case 70:
                    secondRandom = new Random().Next(1, 2);
                    switch (secondRandom)
                    {
                        case 1:
                            m1 = "91";
                            m2 = "01";
                            break;
                    }
                    break;
                case 71:
                    secondRandom = new Random().Next(1, 2);
                    switch (secondRandom)
                    {
                        case 1:
                            m1 = "91";
                            m2 = "02";
                            break;
                    }
                    break;
                case 72:
                    secondRandom = new Random().Next(1, 2);
                    switch (secondRandom)
                    {
                        case 1:
                            m1 = "92";
                            m2 = "00";
                            break;
                    }
                    break;
                case 73:
                    secondRandom = new Random().Next(1, 2);
                    switch (secondRandom)
                    {
                        case 1:
                            m1 = "92";
                            m2 = "01";
                            break;
                    }
                    break;
                case 74:
                    secondRandom = new Random().Next(1, 2);
                    switch (secondRandom)
                    {
                        case 1:
                            m1 = "92";
                            m2 = "02";
                            break;
                    }
                    break;
                case 75:
                    secondRandom = new Random().Next(1, 2);
                    switch (secondRandom)
                    {
                        case 1:
                            m1 = "92";
                            m2 = "03";
                            break;
                    }
                    break;
                case 76:
                    secondRandom = new Random().Next(1, 2);
                    switch (secondRandom)
                    {
                        case 1:
                            m1 = "93";
                            m2 = "00";
                            break;
                    }
                    break;
                case 77:
                    secondRandom = new Random().Next(1, 2);
                    switch (secondRandom)
                    {
                        case 1:
                            m1 = "94";
                            m2 = "00";
                            break;
                    }
                    break;
                case 78:
                    secondRandom = new Random().Next(1, 2);
                    switch (secondRandom)
                    {
                        case 1:
                            m1 = "94";
                            m2 = "01";
                            break;
                    }
                    break;
                case 79:
                    secondRandom = new Random().Next(1, 2);
                    switch (secondRandom)
                    {
                        case 1:
                            m1 = "95";
                            m2 = "00";
                            break;
                    }
                    break;
                case 80:
                    secondRandom = new Random().Next(1, 2);
                    switch (secondRandom)
                    {
                        case 1:
                            m1 = "96";
                            m2 = "00";
                            break;
                    }
                    break;
                case 81:
                    secondRandom = new Random().Next(1, 2);
                    switch (secondRandom)
                    {
                        case 1:
                            m1 = "97";
                            m2 = "00";
                            break;
                    }
                    break;
                case 82:
                    secondRandom = new Random().Next(1, 2);
                    switch (secondRandom)
                    {
                        case 1:
                            m1 = "98";
                            m2 = "00";
                            break;
                    }
                    break;
                case 83:
                    secondRandom = new Random().Next(1, 2);
                    switch (secondRandom)
                    {
                        case 1:
                            m1 = "99";
                            m2 = "00";
                            break;
                    }
                    break;
                //CoTS
                case 84:
                    secondRandom = new Random().Next(1, 2);
                    switch (secondRandom)
                    {
                        case 1:
                            m1 = "A0";
                            m2 = "00";
                            break;
                    }
                    break;
                case 85:
                    secondRandom = new Random().Next(1, 2);
                    switch (secondRandom)
                    {
                        case 1:
                            m1 = "A0";
                            m2 = "01";
                            break;
                    }
                    break;
                case 86:
                    secondRandom = new Random().Next(1, 2);
                    switch (secondRandom)
                    {
                        case 1:
                            m1 = "A0";
                            m2 = "02";
                            break;
                    }
                    break;
                case 87:
                    secondRandom = new Random().Next(1, 2);
                    switch (secondRandom)
                    {
                        case 1:
                            m1 = "A1";
                            m2 = "00";
                            break;
                    }
                    break;
                case 88:
                    secondRandom = new Random().Next(1, 2);
                    switch (secondRandom)
                    {
                        case 1:
                            m1 = "A1";
                            m2 = "01";
                            break;
                    }
                    break;
                case 89:
                    secondRandom = new Random().Next(1, 2);
                    switch (secondRandom)
                    {
                        case 1:
                            m1 = "A1";
                            m2 = "02";
                            break;
                    }
                    break;
                case 90:
                    secondRandom = new Random().Next(1, 2);
                    switch (secondRandom)
                    {
                        case 1:
                            m1 = "A2";
                            m2 = "00";
                            break;
                    }
                    break;
                case 91:
                    secondRandom = new Random().Next(1, 2);
                    switch (secondRandom)
                    {
                        case 1:
                            m1 = "A2";
                            m2 = "01";
                            break;
                    }
                    break;
                case 92:
                    secondRandom = new Random().Next(1, 2);
                    switch (secondRandom)
                    {
                        case 1:
                            m1 = "A2";
                            m2 = "02";
                            break;
                    }
                    break;
                case 93:
                    secondRandom = new Random().Next(1, 2);
                    switch (secondRandom)
                    {
                        case 1:
                            m1 = "A3";
                            m2 = "00";
                            break;
                    }
                    break;
                case 94:
                    secondRandom = new Random().Next(1, 2);
                    switch (secondRandom)
                    {
                        case 1:
                            m1 = "A3";
                            m2 = "01";
                            break;
                    }
                    break;
                case 95:
                    secondRandom = new Random().Next(1, 2);
                    switch (secondRandom)
                    {
                        case 1:
                            m1 = "A3";
                            m2 = "02";
                            break;
                    }
                    break;
                case 96:
                    secondRandom = new Random().Next(1, 2);
                    switch (secondRandom)
                    {
                        case 1:
                            m1 = "A4";
                            m2 = "00";
                            break;
                    }
                    break;
                case 97:
                    secondRandom = new Random().Next(1, 2);
                    switch (secondRandom)
                    {
                        case 1:
                            m1 = "A4";
                            m2 = "01";
                            break;
                    }
                    break;
                case 98:
                    secondRandom = new Random().Next(1, 2);
                    switch (secondRandom)
                    {
                        case 1:
                            m1 = "A4";
                            m2 = "02";
                            break;
                    }
                    break;
                case 99:
                    secondRandom = new Random().Next(1, 2);
                    switch (secondRandom)
                    {
                        case 1:
                            m1 = "A5";
                            m2 = "00";
                            break;
                    }
                    break;
                case 100:
                    secondRandom = new Random().Next(1, 2);
                    switch (secondRandom)
                    {
                        case 1:
                            m1 = "A5";
                            m2 = "01";
                            break;
                    }
                    break;
                case 101:
                    secondRandom = new Random().Next(1, 2);
                    switch (secondRandom)
                    {
                        case 1:
                            m1 = "A5";
                            m2 = "02";
                            break;
                    }
                    break;
                case 102:
                    secondRandom = new Random().Next(1, 2);
                    switch (secondRandom)
                    {
                        case 1:
                            m1 = "A6";
                            m2 = "00";
                            break;
                    }
                    break;
                case 103:
                    secondRandom = new Random().Next(1, 2);
                    switch (secondRandom)
                    {
                        case 1:
                            m1 = "A6";
                            m2 = "01";
                            break;
                    }
                    break;
                case 104:
                    secondRandom = new Random().Next(1, 2);
                    switch (secondRandom)
                    {
                        case 1:
                            m1 = "A6";
                            m2 = "02";
                            break;
                    }
                    break;
                case 105:
                    secondRandom = new Random().Next(1, 2);
                    switch (secondRandom)
                    {
                        case 1:
                            m1 = "A7";
                            m2 = "00";
                            break;
                    }
                    break;
                case 106:
                    secondRandom = new Random().Next(1, 2);
                    switch (secondRandom)
                    {
                        case 1:
                            m1 = "A7";
                            m2 = "01";
                            break;
                    }
                    break;
                case 107:
                    secondRandom = new Random().Next(1, 2);
                    switch (secondRandom)
                    {
                        case 1:
                            m1 = "A7";
                            m2 = "02";
                            break;
                    }
                    break;
                case 108:
                    secondRandom = new Random().Next(1, 2);
                    switch (secondRandom)
                    {
                        case 1:
                            m1 = "A8";
                            m2 = "00";
                            break;
                    }
                    break;
                case 109:
                    secondRandom = new Random().Next(1, 2);
                    switch (secondRandom)
                    {
                        case 1:
                            m1 = "A8";
                            m2 = "01";
                            break;
                    }
                    break;
                case 110:
                    secondRandom = new Random().Next(1, 2);
                    switch (secondRandom)
                    {
                        case 1:
                            m1 = "A8";
                            m2 = "02";
                            break;
                    }
                    break;
                case 111:
                    secondRandom = new Random().Next(1, 2);
                    switch (secondRandom)
                    {
                        case 1:
                            m1 = "A9";
                            m2 = "00";
                            break;
                    }
                    break;
                case 112:
                    secondRandom = new Random().Next(1, 2);
                    switch (secondRandom)
                    {
                        case 1:
                            m1 = "A9";
                            m2 = "01";
                            break;
                    }
                    break;
                case 113:
                    secondRandom = new Random().Next(1, 2);
                    switch (secondRandom)
                    {
                        case 1:
                            m1 = "A9";
                            m2 = "02";
                            break;
                    }
                    break;
                case 114:
                    secondRandom = new Random().Next(1, 2);
                    switch (secondRandom)
                    {
                        case 1:
                            m1 = "AA";
                            m2 = "00";
                            break;
                    }
                    break;
                case 115:
                    secondRandom = new Random().Next(1, 2);
                    switch (secondRandom)
                    {
                        case 1:
                            m1 = "AA";
                            m2 = "01";
                            break;
                    }
                    break;
                case 116:
                    secondRandom = new Random().Next(1, 2);
                    switch (secondRandom)
                    {
                        case 1:
                            m1 = "AA";
                            m2 = "02";
                            break;
                    }
                    break;
                case 117:
                    secondRandom = new Random().Next(1, 2);
                    switch (secondRandom)
                    {
                        case 1:
                            m1 = "AB";
                            m2 = "00";
                            break;
                    }
                    break;
                case 118:
                    secondRandom = new Random().Next(1, 2);
                    switch (secondRandom)
                    {
                        case 1:
                            m1 = "AB";
                            m2 = "01";
                            break;
                    }
                    break;
                case 119:
                    secondRandom = new Random().Next(1, 2);
                    switch (secondRandom)
                    {
                        case 1:
                            m1 = "AB";
                            m2 = "02";
                            break;
                    }
                    break;
                case 120:
                    secondRandom = new Random().Next(1, 2);
                    switch (secondRandom)
                    {
                        case 1:
                            m1 = "AC";
                            m2 = "00";
                            break;
                    }
                    break;
                case 121:
                    secondRandom = new Random().Next(1, 2);
                    switch (secondRandom)
                    {
                        case 1:
                            m1 = "AC";
                            m2 = "01";
                            break;
                    }
                    break;
                case 122:
                    secondRandom = new Random().Next(1, 2);
                    switch (secondRandom)
                    {
                        case 1:
                            m1 = "AC";
                            m2 = "02";
                            break;
                    }
                    break;
                case 123:
                    secondRandom = new Random().Next(1, 2);
                    switch (secondRandom)
                    {
                        case 1:
                            m1 = "AD";
                            m2 = "00";
                            break;
                    }
                    break;
                case 124:
                    secondRandom = new Random().Next(1, 2);
                    switch (secondRandom)
                    {
                        case 1:
                            m1 = "AD";
                            m2 = "01";
                            break;
                    }
                    break;
                case 125:
                    secondRandom = new Random().Next(1, 2);
                    switch (secondRandom)
                    {
                        case 1:
                            m1 = "AD";
                            m2 = "02";
                            break;
                    }
                    break;
                case 126:
                    secondRandom = new Random().Next(1, 2);
                    switch (secondRandom)
                    {
                        case 1:
                            m1 = "AE";
                            m2 = "00";
                            break;
                    }
                    break;
                case 127:
                    secondRandom = new Random().Next(1, 2);
                    switch (secondRandom)
                    {
                        case 1:
                            m1 = "AE";
                            m2 = "01";
                            break;
                    }
                    break;
                case 128:
                    secondRandom = new Random().Next(1, 2);
                    switch (secondRandom)
                    {
                        case 1:
                            m1 = "AE";
                            m2 = "02";
                            break;
                    }
                    break;
                case 129:
                    secondRandom = new Random().Next(1, 2);
                    switch (secondRandom)
                    {
                        case 1:
                            m1 = "AF";
                            m2 = "00";
                            break;
                    }
                    break;
                case 130:
                    secondRandom = new Random().Next(1, 2);
                    switch (secondRandom)
                    {
                        case 1:
                            m1 = "AF";
                            m2 = "01";
                            break;
                    }
                    break;
                case 131:
                    secondRandom = new Random().Next(1, 2);
                    switch (secondRandom)
                    {
                        case 1:
                            m1 = "AF";
                            m2 = "02";
                            break;
                    }
                    break;
                case 132:
                    secondRandom = new Random().Next(1, 2);
                    switch (secondRandom)
                    {
                        case 1:
                            m1 = "B0";
                            m2 = "00";
                            break;
                    }
                    break;
                case 133:
                    secondRandom = new Random().Next(1, 2);
                    switch (secondRandom)
                    {
                        case 1:
                            m1 = "B0";
                            m2 = "01";
                            break;
                    }
                    break;
                case 134:
                    secondRandom = new Random().Next(1, 2);
                    switch (secondRandom)
                    {
                        case 1:
                            m1 = "B0";
                            m2 = "02";
                            break;
                    }
                    break;
                case 135:
                    secondRandom = new Random().Next(1, 2);
                    switch (secondRandom)
                    {
                        case 1:
                            m1 = "B1";
                            m2 = "00";
                            break;
                    }
                    break;
                case 136:
                    secondRandom = new Random().Next(1, 2);
                    switch (secondRandom)
                    {
                        case 1:
                            m1 = "B1";
                            m2 = "01";
                            break;
                    }
                    break;
                case 137:
                    secondRandom = new Random().Next(1, 2);
                    switch (secondRandom)
                    {
                        case 1:
                            m1 = "B1";
                            m2 = "02";
                            break;
                    }
                    break;
                case 138:
                    secondRandom = new Random().Next(1, 2);
                    switch (secondRandom)
                    {
                        case 1:
                            m1 = "B2";
                            m2 = "00";
                            break;
                    }
                    break;
                case 139:
                    secondRandom = new Random().Next(1, 2);
                    switch (secondRandom)
                    {
                        case 1:
                            m1 = "B2";
                            m2 = "01";
                            break;
                    }
                    break;
                case 140:
                    secondRandom = new Random().Next(1, 2);
                    switch (secondRandom)
                    {
                        case 1:
                            m1 = "B2";
                            m2 = "02";
                            break;
                    }
                    break;
                case 141:
                    secondRandom = new Random().Next(1, 2);
                    switch (secondRandom)
                    {
                        case 1:
                            m1 = "B3";
                            m2 = "00";
                            break;
                    }
                    break;
                case 142:
                    secondRandom = new Random().Next(1, 2);
                    switch (secondRandom)
                    {
                        case 1:
                            m1 = "B3";
                            m2 = "01";
                            break;
                    }
                    break;
                case 143:
                    secondRandom = new Random().Next(1, 2);
                    switch (secondRandom)
                    {
                        case 1:
                            m1 = "B3";
                            m2 = "02";
                            break;
                    }
                    break;
                case 144:
                    secondRandom = new Random().Next(1, 2);
                    switch (secondRandom)
                    {
                        case 1:
                            m1 = "B4";
                            m2 = "00";
                            break;
                    }
                    break;
                case 145:
                    secondRandom = new Random().Next(1, 2);
                    switch (secondRandom)
                    {
                        case 1:
                            m1 = "B4";
                            m2 = "01";
                            break;
                    }
                    break;
                case 146:
                    secondRandom = new Random().Next(1, 2);
                    switch (secondRandom)
                    {
                        case 1:
                            m1 = "B4";
                            m2 = "02";
                            break;
                    }
                    break;
                case 147:
                    secondRandom = new Random().Next(1, 2);
                    switch (secondRandom)
                    {
                        case 1:
                            m1 = "B5";
                            m2 = "00";
                            break;
                    }
                    break;
                case 148:
                    secondRandom = new Random().Next(1, 2);
                    switch (secondRandom)
                    {
                        case 1:
                            m1 = "B5";
                            m2 = "01";
                            break;
                    }
                    break;
                case 149:
                    secondRandom = new Random().Next(1, 2);
                    switch (secondRandom)
                    {
                        case 1:
                            m1 = "B5";
                            m2 = "02";
                            break;
                    }
                    break;
                case 150:
                    secondRandom = new Random().Next(1, 2);
                    switch (secondRandom)
                    {
                        case 1:
                            m1 = "B6";
                            m2 = "00";
                            break;
                    }
                    break;
                case 151:
                    secondRandom = new Random().Next(1, 2);
                    switch (secondRandom)
                    {
                        case 1:
                            m1 = "B6";
                            m2 = "01";
                            break;
                    }
                    break;
                case 152:
                    secondRandom = new Random().Next(1, 2);
                    switch (secondRandom)
                    {
                        case 1:
                            m1 = "B6";
                            m2 = "02";
                            break;
                    }
                    break;
                case 153:
                    secondRandom = new Random().Next(1, 2);
                    switch (secondRandom)
                    {
                        case 1:
                            m1 = "B7";
                            m2 = "00";
                            break;
                    }
                    break;
                case 154:
                    secondRandom = new Random().Next(1, 2);
                    switch (secondRandom)
                    {
                        case 1:
                            m1 = "B7";
                            m2 = "01";
                            break;
                    }
                    break;
                case 155:
                    secondRandom = new Random().Next(1, 2);
                    switch (secondRandom)
                    {
                        case 1:
                            m1 = "B7";
                            m2 = "02";
                            break;
                    }
                    break;
                case 156:
                    secondRandom = new Random().Next(1, 2);
                    switch (secondRandom)
                    {
                        case 1:
                            m1 = "B8";
                            m2 = "00";
                            break;
                    }
                    break;
                case 157:
                    secondRandom = new Random().Next(1, 2);
                    switch (secondRandom)
                    {
                        case 1:
                            m1 = "B8";
                            m2 = "01";
                            break;
                    }
                    break;
                case 158:
                    secondRandom = new Random().Next(1, 2);
                    switch (secondRandom)
                    {
                        case 1:
                            m1 = "B8";
                            m2 = "02";
                            break;
                    }
                    break;
                case 159:
                    secondRandom = new Random().Next(1, 2);
                    switch (secondRandom)
                    {
                        case 1:
                            m1 = "B9";
                            m2 = "00";
                            break;
                    }
                    break;
                case 160:
                    secondRandom = new Random().Next(1, 2);
                    switch (secondRandom)
                    {
                        case 1:
                            m1 = "B9";
                            m2 = "01";
                            break;
                    }
                    break;
                case 161:
                    secondRandom = new Random().Next(1, 2);
                    switch (secondRandom)
                    {
                        case 1:
                            m1 = "B9";
                            m2 = "02";
                            break;
                    }
                    break;
                case 162:
                    secondRandom = new Random().Next(1, 2);
                    switch (secondRandom)
                    {
                        case 1:
                            m1 = "BA";
                            m2 = "00";
                            break;
                    }
                    break;
                case 163:
                    secondRandom = new Random().Next(1, 2);
                    switch (secondRandom)
                    {
                        case 1:
                            m1 = "BA";
                            m2 = "01";
                            break;
                    }
                    break;
                case 164:
                    secondRandom = new Random().Next(1, 2);
                    switch (secondRandom)
                    {
                        case 1:
                            m1 = "BA";
                            m2 = "02";
                            break;
                    }
                    break;
                case 165:
                    secondRandom = new Random().Next(1, 2);
                    switch (secondRandom)
                    {
                        case 1:
                            m1 = "BB";
                            m2 = "00";
                            break;
                    }
                    break;
                case 166:
                    secondRandom = new Random().Next(1, 2);
                    switch (secondRandom)
                    {
                        case 1:
                            m1 = "BB";
                            m2 = "01";
                            break;
                    }
                    break;
                case 167:
                    secondRandom = new Random().Next(1, 2);
                    switch (secondRandom)
                    {
                        case 1:
                            m1 = "BB";
                            m2 = "02";
                            break;
                    }
                    break;
                case 168:
                    secondRandom = new Random().Next(1, 2);
                    switch (secondRandom)
                    {
                        case 1:
                            m1 = "BC";
                            m2 = "00";
                            break;
                    }
                    break;
                case 169:
                    secondRandom = new Random().Next(1, 2);
                    switch (secondRandom)
                    {
                        case 1:
                            m1 = "BC";
                            m2 = "01";
                            break;
                    }
                    break;
                case 170:
                    secondRandom = new Random().Next(1, 2);
                    switch (secondRandom)
                    {
                        case 1:
                            m1 = "BC";
                            m2 = "02";
                            break;
                    }
                    break;
                case 171:
                    secondRandom = new Random().Next(1, 2);
                    switch (secondRandom)
                    {
                        case 1:
                            m1 = "BD";
                            m2 = "00";
                            break;
                    }
                    break;
                case 172:
                    secondRandom = new Random().Next(1, 2);
                    switch (secondRandom)
                    {
                        case 1:
                            m1 = "BD";
                            m2 = "01";
                            break;
                    }
                    break;
                case 173:
                    secondRandom = new Random().Next(1, 2);
                    switch (secondRandom)
                    {
                        case 1:
                            m1 = "BD";
                            m2 = "02";
                            break;
                    }
                    break;
                case 174:
                    secondRandom = new Random().Next(1, 2);
                    switch (secondRandom)
                    {
                        case 1:
                            m1 = "BE";
                            m2 = "00";
                            break;
                    }
                    break;
                case 175:
                    secondRandom = new Random().Next(1, 2);
                    switch (secondRandom)
                    {
                        case 1:
                            m1 = "BE";
                            m2 = "01";
                            break;
                    }
                    break;
                case 176:
                    secondRandom = new Random().Next(1, 2);
                    switch (secondRandom)
                    {
                        case 1:
                            m1 = "BE";
                            m2 = "02";
                            break;
                    }
                    break;
                case 177:
                    secondRandom = new Random().Next(1, 2);
                    switch (secondRandom)
                    {
                        case 1:
                            m1 = "BF";
                            m2 = "00";
                            break;
                    }
                    break;
                case 178:
                    secondRandom = new Random().Next(1, 2);
                    switch (secondRandom)
                    {
                        case 1:
                            m1 = "BF";
                            m2 = "01";
                            break;
                    }
                    break;
                case 179:
                    secondRandom = new Random().Next(1, 2);
                    switch (secondRandom)
                    {
                        case 1:
                            m1 = "BF";
                            m2 = "02";
                            break;
                    }
                    break;
                case 180:
                    secondRandom = new Random().Next(1, 2);
                    switch (secondRandom)
                    {
                        case 1:
                            m1 = "C0";
                            m2 = "00";
                            break;
                    }
                    break;
                case 181:
                    secondRandom = new Random().Next(1, 2);
                    switch (secondRandom)
                    {
                        case 1:
                            m1 = "C0";
                            m2 = "01";
                            break;
                    }
                    break;
                case 182:
                    secondRandom = new Random().Next(1, 2);
                    switch (secondRandom)
                    {
                        case 1:
                            m1 = "C0";
                            m2 = "02";
                            break;
                    }
                    break;
                case 183:
                    secondRandom = new Random().Next(1, 2);
                    switch (secondRandom)
                    {
                        case 1:
                            m1 = "C1";
                            m2 = "00";
                            break;
                    }
                    break;
                case 184:
                    secondRandom = new Random().Next(1, 2);
                    switch (secondRandom)
                    {
                        case 1:
                            m1 = "C1";
                            m2 = "01";
                            break;
                    }
                    break;
                case 185:
                    secondRandom = new Random().Next(1, 2);
                    switch (secondRandom)
                    {
                        case 1:
                            m1 = "C1";
                            m2 = "02";
                            break;
                    }
                    break;
                case 186:
                    secondRandom = new Random().Next(1, 18);//continue here
                    switch (secondRandom)
                    {
                        case 1:
                            m1 = "A0";
                            m2 = "03";
                            break;
                        case 2:
                            m1 = "A2";
                            m2 = "03";
                            break;
                        case 3:
                            m1 = "A4";
                            m2 = "03";
                            break;
                        case 4:
                            m1 = "A6";
                            m2 = "03";
                            break;
                        case 5:
                            m1 = "A8";
                            m2 = "03";
                            break;
                        case 6:
                            m1 = "AA";
                            m2 = "03";
                            break;
                        case 7:
                            m1 = "AC";
                            m2 = "03";
                            break;
                        case 8:
                            m1 = "AE";
                            m2 = "03";
                            break;
                        case 9:
                            m1 = "B0";
                            m2 = "03";
                            break;
                        case 10:
                            m1 = "B2";
                            m2 = "03";
                            break;
                        case 11:
                            m1 = "B4";
                            m2 = "03";
                            break;
                        case 12:
                            m1 = "B6";
                            m2 = "03";
                            break;
                        case 13:
                            m1 = "B8";
                            m2 = "03";
                            break;
                        case 14:
                            m1 = "BA";
                            m2 = "03";
                            break;
                        case 15:
                            m1 = "BC";
                            m2 = "03";
                            break;
                        case 16:
                            m1 = "BE";
                            m2 = "03";
                            break;
                        case 17:
                            m1 = "C0";
                            m2 = "03";
                            break;
                    }
                    break;
                case 187:
                    secondRandom = new Random().Next(1, 18);
                    switch (secondRandom)
                    {
                        case 1:
                            m1 = "A0";
                            m2 = "04";
                            break;
                        case 2:
                            m1 = "A2";
                            m2 = "04";
                            break;
                        case 3:
                            m1 = "A4";
                            m2 = "04";
                            break;
                        case 4:
                            m1 = "A6";
                            m2 = "04";
                            break;
                        case 5:
                            m1 = "A8";
                            m2 = "04";
                            break;
                        case 6:
                            m1 = "AA";
                            m2 = "04";
                            break;
                        case 7:
                            m1 = "AC";
                            m2 = "04";
                            break;
                        case 8:
                            m1 = "AE";
                            m2 = "04";
                            break;
                        case 9:
                            m1 = "B0";
                            m2 = "04";
                            break;
                        case 10:
                            m1 = "B2";
                            m2 = "04";
                            break;
                        case 11:
                            m1 = "B4";
                            m2 = "04";
                            break;
                        case 12:
                            m1 = "B6";
                            m2 = "04";
                            break;
                        case 13:
                            m1 = "B8";
                            m2 = "04";
                            break;
                        case 14:
                            m1 = "BA";
                            m2 = "04";
                            break;
                        case 15:
                            m1 = "BC";
                            m2 = "04";
                            break;
                        case 16:
                            m1 = "BE";
                            m2 = "04";
                            break;
                        case 17:
                            m1 = "C0";
                            m2 = "04";
                            break;
                    }
                    break;
                case 188:
                    secondRandom = new Random().Next(1, 18);
                    switch (secondRandom)
                    {
                        case 1:
                            m1 = "A0";
                            m2 = "05";
                            break;
                        case 2:
                            m1 = "A2";
                            m2 = "05";
                            break;
                        case 3:
                            m1 = "A4";
                            m2 = "05";
                            break;
                        case 4:
                            m1 = "A6";
                            m2 = "05";
                            break;
                        case 5:
                            m1 = "A8";
                            m2 = "05";
                            break;
                        case 6:
                            m1 = "AA";
                            m2 = "05";
                            break;
                        case 7:
                            m1 = "AC";
                            m2 = "05";
                            break;
                        case 8:
                            m1 = "AE";
                            m2 = "05";
                            break;
                        case 9:
                            m1 = "B0";
                            m2 = "05";
                            break;
                        case 10:
                            m1 = "B2";
                            m2 = "05";
                            break;
                        case 11:
                            m1 = "B4";
                            m2 = "05";
                            break;
                        case 12:
                            m1 = "B6";
                            m2 = "05";
                            break;
                        case 13:
                            m1 = "B8";
                            m2 = "05";
                            break;
                        case 14:
                            m1 = "BA";
                            m2 = "05";
                            break;
                        case 15:
                            m1 = "BC";
                            m2 = "05";
                            break;
                        case 16:
                            m1 = "BE";
                            m2 = "05";
                            break;
                        case 17:
                            m1 = "C0";
                            m2 = "05";
                            break;
                    }
                    break;
                case 189:
                    secondRandom = new Random().Next(1, 18);
                    switch (secondRandom)
                    {
                        case 1:
                            m1 = "A0";
                            m2 = "06";
                            break;
                        case 2:
                            m1 = "A2";
                            m2 = "06";
                            break;
                        case 3:
                            m1 = "A4";
                            m2 = "06";
                            break;
                        case 4:
                            m1 = "A6";
                            m2 = "06";
                            break;
                        case 5:
                            m1 = "A8";
                            m2 = "06";
                            break;
                        case 6:
                            m1 = "AA";
                            m2 = "06";
                            break;
                        case 7:
                            m1 = "AC";
                            m2 = "06";
                            break;
                        case 8:
                            m1 = "AE";
                            m2 = "06";
                            break;
                        case 9:
                            m1 = "B0";
                            m2 = "06";
                            break;
                        case 10:
                            m1 = "B2";
                            m2 = "06";
                            break;
                        case 11:
                            m1 = "B4";
                            m2 = "06";
                            break;
                        case 12:
                            m1 = "B6";
                            m2 = "06";
                            break;
                        case 13:
                            m1 = "B8";
                            m2 = "06";
                            break;
                        case 14:
                            m1 = "BA";
                            m2 = "06";
                            break;
                        case 15:
                            m1 = "BC";
                            m2 = "06";
                            break;
                        case 16:
                            m1 = "BE";
                            m2 = "06";
                            break;
                        case 17:
                            m1 = "C0";
                            m2 = "06";
                            break;
                    }
                    break;
                case 190:
                    secondRandom = new Random().Next(1, 18);
                    switch (secondRandom)
                    {
                        case 1:
                            m1 = "A0";
                            m2 = "07";
                            break;
                        case 2:
                            m1 = "A2";
                            m2 = "07";
                            break;
                        case 3:
                            m1 = "A4";
                            m2 = "07";
                            break;
                        case 4:
                            m1 = "A6";
                            m2 = "07";
                            break;
                        case 5:
                            m1 = "A8";
                            m2 = "07";
                            break;
                        case 6:
                            m1 = "AA";
                            m2 = "07";
                            break;
                        case 7:
                            m1 = "AC";
                            m2 = "07";
                            break;
                        case 8:
                            m1 = "AE";
                            m2 = "07";
                            break;
                        case 9:
                            m1 = "B0";
                            m2 = "07";
                            break;
                        case 10:
                            m1 = "B2";
                            m2 = "07";
                            break;
                        case 11:
                            m1 = "B4";
                            m2 = "07";
                            break;
                        case 12:
                            m1 = "B6";
                            m2 = "07";
                            break;
                        case 13:
                            m1 = "B8";
                            m2 = "07";
                            break;
                        case 14:
                            m1 = "BA";
                            m2 = "07";
                            break;
                        case 15:
                            m1 = "BC";
                            m2 = "07";
                            break;
                        case 16:
                            m1 = "BE";
                            m2 = "07";
                            break;
                        case 17:
                            m1 = "C0";
                            m2 = "07";
                            break;
                    }
                    break;
                case 191:
                    secondRandom = new Random().Next(1, 18);
                    switch (secondRandom)
                    {
                        case 1:
                            m1 = "A1";
                            m2 = "03";
                            break;
                        case 2:
                            m1 = "A3";
                            m2 = "03";
                            break;
                        case 3:
                            m1 = "A5";
                            m2 = "03";
                            break;
                        case 4:
                            m1 = "A7";
                            m2 = "03";
                            break;
                        case 5:
                            m1 = "A9";
                            m2 = "03";
                            break;
                        case 6:
                            m1 = "AB";
                            m2 = "03";
                            break;
                        case 7:
                            m1 = "AD";
                            m2 = "03";
                            break;
                        case 8:
                            m1 = "AF";
                            m2 = "03";
                            break;
                        case 9:
                            m1 = "B1";
                            m2 = "03";
                            break;
                        case 10:
                            m1 = "B3";
                            m2 = "03";
                            break;
                        case 11:
                            m1 = "B5";
                            m2 = "03";
                            break;
                        case 12:
                            m1 = "B7";
                            m2 = "03";
                            break;
                        case 13:
                            m1 = "B9";
                            m2 = "03";
                            break;
                        case 14:
                            m1 = "BB";
                            m2 = "03";
                            break;
                        case 15:
                            m1 = "BD";
                            m2 = "03";
                            break;
                        case 16:
                            m1 = "BF";
                            m2 = "03";
                            break;
                        case 17:
                            m1 = "C1";
                            m2 = "03";
                            break;
                    }
                    break;
                case 192:
                    secondRandom = new Random().Next(1, 18);
                    switch (secondRandom)
                    {
                        case 1:
                            m1 = "A1";
                            m2 = "04";
                            break;
                        case 2:
                            m1 = "A3";
                            m2 = "04";
                            break;
                        case 3:
                            m1 = "A5";
                            m2 = "04";
                            break;
                        case 4:
                            m1 = "A7";
                            m2 = "04";
                            break;
                        case 5:
                            m1 = "A9";
                            m2 = "04";
                            break;
                        case 6:
                            m1 = "AB";
                            m2 = "04";
                            break;
                        case 7:
                            m1 = "AD";
                            m2 = "04";
                            break;
                        case 8:
                            m1 = "AF";
                            m2 = "04";
                            break;
                        case 9:
                            m1 = "B1";
                            m2 = "04";
                            break;
                        case 10:
                            m1 = "B3";
                            m2 = "04";
                            break;
                        case 11:
                            m1 = "B5";
                            m2 = "04";
                            break;
                        case 12:
                            m1 = "B7";
                            m2 = "04";
                            break;
                        case 13:
                            m1 = "B9";
                            m2 = "04";
                            break;
                        case 14:
                            m1 = "BB";
                            m2 = "04";
                            break;
                        case 15:
                            m1 = "BD";
                            m2 = "04";
                            break;
                        case 16:
                            m1 = "BF";
                            m2 = "04";
                            break;
                        case 17:
                            m1 = "C1";
                            m2 = "04";
                            break;
                    }
                    break;
                case 193:
                    secondRandom = new Random().Next(1, 18);
                    switch (secondRandom)
                    {
                        case 1:
                            m1 = "A1";
                            m2 = "05";
                            break;
                        case 2:
                            m1 = "A3";
                            m2 = "05";
                            break;
                        case 3:
                            m1 = "A5";
                            m2 = "05";
                            break;
                        case 4:
                            m1 = "A7";
                            m2 = "05";
                            break;
                        case 5:
                            m1 = "A9";
                            m2 = "05";
                            break;
                        case 6:
                            m1 = "AB";
                            m2 = "05";
                            break;
                        case 7:
                            m1 = "AD";
                            m2 = "05";
                            break;
                        case 8:
                            m1 = "AF";
                            m2 = "05";
                            break;
                        case 9:
                            m1 = "B1";
                            m2 = "05";
                            break;
                        case 10:
                            m1 = "B3";
                            m2 = "05";
                            break;
                        case 11:
                            m1 = "B5";
                            m2 = "05";
                            break;
                        case 12:
                            m1 = "B7";
                            m2 = "05";
                            break;
                        case 13:
                            m1 = "B9";
                            m2 = "05";
                            break;
                        case 14:
                            m1 = "BB";
                            m2 = "05";
                            break;
                        case 15:
                            m1 = "BD";
                            m2 = "05";
                            break;
                        case 16:
                            m1 = "BF";
                            m2 = "05";
                            break;
                        case 17:
                            m1 = "C1";
                            m2 = "05";
                            break;
                    }
                    break;
                case 194:
                    secondRandom = new Random().Next(1, 18);
                    switch (secondRandom)
                    {
                        case 1:
                            m1 = "A1";
                            m2 = "06";
                            break;
                        case 2:
                            m1 = "A3";
                            m2 = "06";
                            break;
                        case 3:
                            m1 = "A5";
                            m2 = "06";
                            break;
                        case 4:
                            m1 = "A7";
                            m2 = "06";
                            break;
                        case 5:
                            m1 = "A9";
                            m2 = "06";
                            break;
                        case 6:
                            m1 = "AB";
                            m2 = "06";
                            break;
                        case 7:
                            m1 = "AD";
                            m2 = "06";
                            break;
                        case 8:
                            m1 = "AF";
                            m2 = "06";
                            break;
                        case 9:
                            m1 = "B1";
                            m2 = "06";
                            break;
                        case 10:
                            m1 = "B3";
                            m2 = "06";
                            break;
                        case 11:
                            m1 = "B5";
                            m2 = "06";
                            break;
                        case 12:
                            m1 = "B7";
                            m2 = "06";
                            break;
                        case 13:
                            m1 = "B9";
                            m2 = "06";
                            break;
                        case 14:
                            m1 = "BB";
                            m2 = "06";
                            break;
                        case 15:
                            m1 = "BD";
                            m2 = "06";
                            break;
                        case 16:
                            m1 = "BF";
                            m2 = "06";
                            break;
                        case 17:
                            m1 = "C1";
                            m2 = "06";
                            break;
                    }
                    break;
                case 195:
                    secondRandom = new Random().Next(1, 18);
                    switch (secondRandom)
                    {
                        case 1:
                            m1 = "A1";
                            m2 = "07";
                            break;
                        case 2:
                            m1 = "A3";
                            m2 = "07";
                            break;
                        case 3:
                            m1 = "A5";
                            m2 = "07";
                            break;
                        case 4:
                            m1 = "A7";
                            m2 = "07";
                            break;
                        case 5:
                            m1 = "A9";
                            m2 = "07";
                            break;
                        case 6:
                            m1 = "AB";
                            m2 = "07";
                            break;
                        case 7:
                            m1 = "AD";
                            m2 = "07";
                            break;
                        case 8:
                            m1 = "AF";
                            m2 = "07";
                            break;
                        case 9:
                            m1 = "B1";
                            m2 = "07";
                            break;
                        case 10:
                            m1 = "B3";
                            m2 = "07";
                            break;
                        case 11:
                            m1 = "B5";
                            m2 = "07";
                            break;
                        case 12:
                            m1 = "B7";
                            m2 = "07";
                            break;
                        case 13:
                            m1 = "B9";
                            m2 = "07";
                            break;
                        case 14:
                            m1 = "BB";
                            m2 = "07";
                            break;
                        case 15:
                            m1 = "BD";
                            m2 = "07";
                            break;
                        case 16:
                            m1 = "BF";
                            m2 = "07";
                            break;
                        case 17:
                            m1 = "C1";
                            m2 = "07";
                            break;
                    }
                    break;
                case 196:
                    secondRandom = new Random().Next(1, 4);
                    switch (secondRandom)
                    {
                        case 1:
                            m1 = "E7";
                            m2 = "00";
                            break;
                        case 2:
                            m1 = "E7";
                            m2 = "01";
                            break;
                        case 3:
                            m1 = "E7";
                            m2 = "02";
                            break;
                    }
                    break;
                case 197:
                    secondRandom = new Random().Next(1, 4);
                    switch (secondRandom)
                    {
                        case 1:
                            m1 = "E8";
                            m2 = "00";
                            break;
                        case 2:
                            m1 = "E8";
                            m2 = "01";
                            break;
                        case 3:
                            m1 = "E8";
                            m2 = "02";
                            break;
                    }
                    break;
                case 198:
                    secondRandom = new Random().Next(1, 3);
                    switch (secondRandom)
                    {
                        case 1:
                            m1 = "E9";
                            m2 = "00";
                            break;
                        case 2:
                            m1 = "E9";
                            m2 = "01";
                            break;
                    }
                    break;
                case 199:
                    secondRandom = new Random().Next(1, 4);
                    switch (secondRandom)
                    {
                        case 1:
                            m1 = "EA";
                            m2 = "00";
                            break;
                        case 2:
                            m1 = "EA";
                            m2 = "01";
                            break;
                        case 3:
                            m1 = "EA";
                            m2 = "02";
                            break;
                    }
                    break;
                case 200:
                    secondRandom = new Random().Next(1, 3);
                    switch (secondRandom)
                    {
                        case 1:
                            m1 = "EB";
                            m2 = "00";
                            break;
                        case 2:
                            m1 = "EB";
                            m2 = "01";
                            break;
                    }
                    break;
                case 201:
                    secondRandom = new Random().Next(1, 3);
                    switch (secondRandom)
                    {
                        case 1:
                            m1 = "EC";
                            m2 = "00";
                            break;
                        case 2:
                            m1 = "EC";
                            m2 = "01";
                            break;
                    }
                    break;
                case 202:
                    secondRandom = new Random().Next(1, 3);
                    switch (secondRandom)
                    {
                        case 1:
                            m1 = "ED";
                            m2 = "00";
                            break;
                        case 2:
                            m1 = "ED";
                            m2 = "01";
                            break;
                    }
                    break;
                case 203:
                    secondRandom = new Random().Next(1, 2);
                    switch (secondRandom)
                    {
                        case 1:
                            m1 = "EE";
                            m2 = "00";
                            break;
                    }
                    break;
                case 204:
                    secondRandom = new Random().Next(1, 2);
                    switch (secondRandom)
                    {
                        case 1:
                            m1 = "EF";
                            m2 = "00";
                            break;
                    }
                    break;
                case 205:
                    secondRandom = new Random().Next(1, 2);
                    switch (secondRandom)
                    {
                        case 1:
                            m1 = "EF";
                            m2 = "01";
                            break;
                    }
                    break;


            }


            CharacterSelect(playerIndex, "", true, m1, m2);
        }


        private void StageSelection(object sender, SelectionChangedEventArgs e)
        {
            if (sender is ComboBox comboBox && comboBox.SelectedItem is string selectedValue)
            {
                SettingsClass.StageValue = selectedValue.Substring(0, 2);
                SettingsClass.SaveData();
                CreatePnach.ExportPnachLite();
            }
        }

        private void Stage_Info(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Select the stage you want to fight in\n" +
                "The first option means the game choise");
            return;
        }
    }



}
