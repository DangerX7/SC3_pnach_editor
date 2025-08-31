using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Collections.ObjectModel;
using System.IO;
using System.Windows;
using SC3_pnach_editor.Services;
using System.Drawing;

namespace SC3_pnach_editor.ViewModels
{
    public class CharactersViewModel : BaseViewModel
    {


        public CharactersViewModel()
        {
            SettingsClass.LoadData();
        }


        private string _characterPortrait;
        public string CharacterPortrait
        {
            get { return _characterPortrait; }
            set
            {
                if (_characterPortrait != value)
                {
                    _characterPortrait = value;
                    RaisePropertyChanged("CharacterPortrait");
                }
            }
        }
        private string _player1Character;
        public string Player1Character
        {
            get { return _player1Character; }
            set
            {
                if (_player1Character != value)
                {
                    _player1Character = value;
                    RaisePropertyChanged("Player1Character");
                }
            }
        }
        private string _player2Character;
        public string Player2Character
        {
            get { return _player2Character; }
            set
            {
                if (_player2Character != value)
                {
                    _player2Character = value;
                    RaisePropertyChanged("Player2Character");
                }
            }
        }
        private string _soundButton;
        public string SoundButton
        {
            get { return _soundButton; }
            set
            {
                if (_soundButton != value)
                {
                    _soundButton = value;
                    RaisePropertyChanged("SoundButton");
                }
            }
        }

        private string _stageValue;
        public string StageValue
        {
            get { return _stageValue; }
            set
            {
                if (_stageValue != value)
                {
                    _stageValue = value;
                    RaisePropertyChanged("StageValue");
                }
            }
        }

        public ObservableCollection<string> StagesCodesList { get; } = new ObservableCollection<string>
    {
        "XX - Original",
        "00 - Highlands (Earthquake in Vs. Special)",
        "01 - Egyptian Temple",
        "02 - Clock Tower",
        "03 - Eurydice Shrine",
        "04 - Ostrheinsburg Castle - Battlement",
        "05 - Water Mill Valley",
        "06 - Battle in the Strait",
        "07 - Valentine Mansion",
        "08 - Ling-Sheng Su Temple Ruin",
        "09 - Lakeside Coliseum",
        "0A - Kunpaetku Shrine Ruins",
        "0B - Indian Port",
        "0C - Lost Cathedral",
        "0D - Secret Money Pit",
        "0E - Underground Buddhist Sanctum",
        "0F - Proving Grounds",
        "10 - Grand Labyrinth",
        "11 - Sacred Mt. Fuji",
        "12 - Lost Cathedral - Ruin",
        "13 - Pirate Raid",
        "14 - Jyurakudai Villa",
        "15 - Romanian Valley - Castle Siege",
        "16 - Lotus Garden",
        "17 - Old Toledo - Burning Gallery",
        "18 - Silk Road Ruin",
        "19 - Chaos - Spiritual Realm",
        "1A - Castle Room (Shop, Olcadan ending)",
        "1B - Azuchi-Momoyama road (Mitsurugi/Taki ending)",
        "1C - Castle Gate (Nightmare/Lizardman ending)",
        "1D - Field (Kilik/Xianghua ending)",
        "1E - Bridge (Talim/Seong Mi-na ending)",
        "1F - Forest (Tira/Raphael ending)",
        "20 - Sacred Money Pit (Voldo ending)",
        "21 - Sailing boat (Rock ending) <Camera!>",
        "22 - Badlands (Astaroth ending)",
        "23 - Pirate Raid (Cervantes ending) <Camera!>",
        "24 - Library (Zasalamel/Raphael ending)",
        "25 - Eurydice Shrine Gallery (Cassandra/Sophitia ending)",
        "26 - Blacksmith / Sophitia's house (Cassandra/Tira ending) <Camera!>",
        "27 - Soul Edge in Lost Cathedral (Ending) <Crash!>",
        "28 - Indian Port (Ending) <Crash!>",
        "29 - Lakeside Coliseum (Ending) <Crash!>",
        "30 - Character selection background",
        "31 - Main menu background",
        "32 - Soul Calibur III logo",
        "33 - Character creation background"
        // Add more options as needed
    };

        public string[,] Empty = new string[,]
        {
            { "_", "_"},
            { "_", "_"}
        };

        //Standard Characters
        public string[,] MitsurugiValues = new string[,]
        {
            { "Mitsurugi", "Costume 1", "Soul of Mitsurugi", "Mitsurugi_1.png", "01", "00", "Mitsurugi__1.png", "" },
            { "Mitsurugi", "Costume 2", "_", "Mitsurugi_2.png", "01", "01", "Mitsurugi__2.png", "" },
            { "Mitsurugi", "Costume 1 Color Edit", "_", "Mitsurugi_1.png", "01", "08", "Mitsurugi__1E.png", "" },
            { "Mitsurugi", "Costume 2 Color Edit", "_", "Mitsurugi_2.png", "01", "09", "Mitsurugi__2E.png", "" }
        };
        public string[,] SeongMinaValues = new string[,]
        {
            { "Seong Mi-na", "Costume 1", "Soul of Seong Mi-na", "SeongMi-na_1.png", "02", "00", "Seong Mi-na__1.png", "" },
            { "Seong Mi-na", "Costume 2", "_", "SeongMi-na_2.png", "02", "01", "Seong Mi-na__2.png", "" },
            { "Seong Mi-na", "Costume 1 Color Edit", "_", "SeongMi-na_1.png", "02", "08", "Seong Mi-na__1E.png", "" },
            { "Seong Mi-na", "Costume 2 Color Edit", "_", "SeongMi-na_2.png", "02", "09", "Seong Mi-na__2E.png", "" }
        };
        public string[,] TakiValues = new string[,]
        {
            { "Taki", "Costume 1", "Soul of Taki", "Taki_1.png", "03", "00", "Taki__1.png", "" },
            { "Taki", "Costume 2", "_", "Taki_2.png", "03", "01", "Taki__2.png", "" },
            { "Taki", "Costume 1 Color Edit", "_", "Taki_1.png", "03", "08", "Taki__1E.png", "" },
            { "Taki", "Costume 2 Color Edit", "_", "Taki_2.png", "03", "09", "Taki__2E.png", "" }
        };
        public string[,] MaxiValues = new string[,]
        {
            { "Maxi", "Costume 1", "Soul of Maxi", "Maxi_1.png", "04", "00", "Maxi__1.png", "" },
            { "Maxi", "Costume 2", "_", "Maxi_2.png", "04", "01", "Maxi__2.png", "" },
            { "Maxi", "Costume 1 Color Edit", "_", "Maxi_1.png", "04", "08", "Maxi__1E.png", "" },
            { "Maxi", "Costume 2 Color Edit", "_", "Maxi_2.png", "04", "09", "Maxi__2E.png", "" }
        };
        public string[,] VoldoValues = new string[,]
        {
            { "Voldo", "Costume 1", "Soul of Voldo", "Voldo_1.png", "05", "00", "Voldo__1.png", "" },
            { "Voldo", "Costume 2", "_", "Voldo_2.png", "05", "01", "Voldo__2.png", "" },
            { "Voldo", "Costume 1 Color Edit", "_", "Voldo_1.png", "05", "08", "Voldo__1E.png", "" },
            { "Voldo", "Costume 2 Color Edit", "_", "Voldo_2.png", "05", "09", "Voldo__2E.png", "" }
        };
        public string[,] SophitiaValues = new string[,]
        {
            { "Sophitia", "Costume 1", "Soul of Sophitia", "Sophitia_1.png", "06", "00", "Sophitia__1.png", "" },
            { "Sophitia", "Costume 2", "_", "Sophitia_2.png", "06", "01", "Sophitia__2.png", "" },
            { "Sophitia", "Costume 1 Color Edit", "_", "Sophitia_1.png", "06", "08", "Sophitia__1E.png", "" },
            { "Sophitia", "Costume 2 Color Edit", "_", "Sophitia_2.png", "06", "09", "Sophitia__2E.png", "" }
        };
        public string[,] SiegfriedValues = new string[,]
        {
            { "Siegfried", "Costume 1", "Soul of Siegfried", "Siegfried_1.png", "07", "00", "Siegfried__1.png", "" },
            { "Siegfried", "Costume 2", "_", "Siegfried_2.png", "07", "01", "Siegfried__2.png", "" },
            { "Siegfried", "Costume 1 Color Edit", "_", "Siegfried_1.png", "07", "08", "Siegfried__1E.png", "" },
            { "Siegfried", "Costume 2 Color Edit", "_", "Siegfried_2.png", "07", "09", "Siegfried__2E.png", "" }
        };
        public string[,] RockValues = new string[,]
        {
            { "Rock", "Costume 1", "Soul of Rock", "Rock_1.png", "08", "00", "Rock__1.png", "" },
            { "Rock", "Costume 2", "_", "Rock_2.png", "08", "01", "Rock__2.png", "" },
            { "Rock", "Costume 1 Color Edit", "_", "Rock_1.png", "08", "08", "Rock__1E.png", "" },
            { "Rock", "Costume 2 Color Edit", "_", "Rock_2.png", "08", "09", "Rock__2E.png", "" }
        };
        public string[,] IvyValues = new string[,]
        {
            { "Ivy", "Costume 1", "Soul of Ivy", "Ivy_1.png", "0B", "00", "Ivy__1.png", "" },
            { "Ivy", "Costume 2", "_", "Ivy_2.png", "0B", "01", "Ivy__2.png", "" },
            { "Ivy", "Costume 1 Color Edit", "_", "Ivy_1.png", "0B", "08", "Ivy__1E.png", "" },
            { "Ivy", "Costume 2 Color Edit", "_", "Ivy_2.png", "0B", "09", "Ivy__2E.png", "" }
        };
        public string[,] KilikValues = new string[,]
        {
            { "Kilik", "Costume 1", "Soul of Kilik", "Kilik_1.png", "0C", "00", "Kilik__1.png", "" },
            { "Kilik", "Costume 2", "_", "Kilik_2.png", "0C", "01", "Kilik__2.png", "" },
            { "Kilik", "Costume 1 Color Edit", "_", "Kilik_1.png", "0C", "08", "Kilik__1E.png", "" },
            { "Kilik", "Costume 2 Color Edit", "_", "Kilik_2.png", "0C", "09", "Kilik__2E.png", "" }
        };
        public string[,] XianghuaValues = new string[,]
        {
            { "Xianghua", "Costume 1", "Soul of Xianghua", "Xianghua_1.png", "0D", "00", "Xianghua__1.png", "" },
            { "Xianghua", "Costume 2", "_", "Xianghua_2.png", "0D", "01", "Xianghua__2.png", "" },
            { "Xianghua", "Costume 1 Color Edit", "_", "Xianghua_1.png", "0D", "08", "Xianghua__1E.png", "" },
            { "Xianghua", "Costume 2 Color Edit", "_", "Xianghua_2.png", "0D", "09", "Xianghua__2E.png", "" }
        };
        public string[,] LizardmanValues = new string[,]
        {
            { "Lizardman", "Costume 1", "Soul of Lizardman", "Lizardman_1.png", "0E", "00", "Lizardman__1.png", "" },
            { "Lizardman", "Costume 2", "_", "Lizardman_2.png", "0E", "01", "Lizardman__2.png", "" },
            { "Lizardman", "Costume 1 Color Edit", "_", "Lizardman_1.png", "0E", "08", "Lizardman__1E.png", "" },
            { "Lizardman", "Costume 2 Color Edit", "_", "Lizardman_2.png", "0E", "09", "Lizardman__2E.png", "" },
            { "Lizardman", "With crown", "_", "Lizardman_1.png", "36", "00", "Lizardman__EX1.png", "" },
            { "Lizardman", "With Voldo mask", "_", "Lizardman_1.png", "37", "00", "Lizardman__EX2.png", "" },
            { "Lizardman", "Without tail", "_", "Lizardman_1.png", "38", "00", "Lizardman__EX3.png", "" }
        };
        public string[,] YoshimitsuValues = new string[,]
        {
            { "Yoshimitsu", "Costume 1", "Soul of Yoshimitsu", "Yoshimitsu_1.png", "0F", "00", "Yoshimitsu__1.png", "" },
            { "Yoshimitsu", "Costume 2", "_", "Yoshimitsu_2.png", "0F", "01", "Yoshimitsu__2.png", "" },
            { "Yoshimitsu", "Costume 1 Color Edit", "_", "Yoshimitsu_1.png", "0F", "08", "Yoshimitsu__1E.png", "" },
            { "Yoshimitsu", "Costume 2 Color Edit", "_", "Yoshimitsu_2.png", "0F", "09", "Yoshimitsu__2E.png", "" }
        };
        public string[,] NightmareValues = new string[,]
        {
            { "Nightmare", "Costume 1", "Soul of Nightmare", "Nightmare_1.png", "11", "00", "Nightmare__1.png", "" },
            { "Nightmare", "Costume 2", "_", "Nightmare_2.png", "11", "01", "Nightmare__2.png", "" },
            { "Nightmare", "Costume 1 Color Edit", "_", "Nightmare_1.png", "11", "08", "Nightmare__1E.png", "" },
            { "Nightmare", "Costume 2 Color Edit", "_", "Nightmare_2.png", "11", "09", "Nightmare__2E.png", "" }
        };
        public string[,] AstarothValues = new string[,]
        {
            { "Astaroth", "Costume 1", "Soul of Astaroth", "Astaroth_1.png", "12", "00", "Astaroth__1.png", "" },
            { "Astaroth", "Costume 2", "_", "Astaroth_2.png", "12", "01", "Astaroth__2.png", "" },
            { "Astaroth", "Costume 1 Color Edit", "_", "Astaroth_1.png", "12", "08", "Astaroth__1E.png", "" },
            { "Astaroth", "Costume 2 Color Edit", "_", "Astaroth_2.png", "12", "09", "Astaroth__2E.png", "" }
        };
        public string[,] CervantesValues = new string[,]
        {
            { "Cervantes", "Costume 1", "Soul of Cervantes", "Cervantes_1.png", "14", "00", "Cervantes__1.png", "" },
            { "Cervantes", "Costume 2", "_", "Cervantes_2.png", "14", "01", "Cervantes__2.png", "" },
            { "Cervantes", "Costume 1 Color Edit", "_", "Cervantes_1.png", "14", "08", "Cervantes__1E.png", "" },
            { "Cervantes", "Costume 2 Color Edit", "_", "Cervantes_2.png", "14", "09", "Cervantes__2E.png", "" }
        };
        public string[,] RaphaelValues = new string[,]
        {
            { "Raphael", "Costume 1", "Soul of Raphael", "Raphael_1.png", "15", "00", "Raphael__1.png", "" },
            { "Raphael", "Costume 2", "_", "Raphael_2.png", "15", "01", "Raphael__2.png", "" },
            { "Raphael", "Costume 1 Color Edit", "_", "Raphael_1.png", "15", "08", "Raphael__1E.png", "" },
            { "Raphael", "Costume 2 Color Edit", "_", "Raphael_2.png", "15", "09", "Raphael__2E.png", "" }
        };
        public string[,] TalimValues = new string[,]
        {
            { "Talim", "Costume 1", "Soul of Talim", "Talim_1.png", "16", "00", "Talim__1.png", "" },
            { "Talim", "Costume 2", "_", "Talim_2.png", "16", "01", "Talim__2.png", "" },
            { "Talim", "Costume 1 Color Edit", "_", "Talim_1.png", "16", "08", "Talim__1E.png", "" },
            { "Talim", "Costume 2 Color Edit", "_", "Talim_2.png", "16", "09", "Talim__2E.png", "" }
        };
        public string[,] CassandraValues = new string[,]
        {
            { "Cassandra", "Costume 1", "Soul of Cassandra", "Cassandra_1.png", "17", "00", "Cassandra__1.png", "" },
            { "Cassandra", "Costume 2", "_", "Cassandra_2.png", "17", "01", "Cassandra__2.png", "" },
            { "Cassandra", "Costume 1 Color Edit", "_", "Cassandra_1.png", "17", "08", "Cassandra__1E.png", "" },
            { "Cassandra", "Costume 2 Color Edit", "_", "Cassandra_2.png", "17", "09", "Cassandra__2E.png", "" }
        };
        public string[,] YunSeongValues = new string[,]
        {
            { "Yun-Seong", "Costume 1", "Soul of Yun-Seong", "Yun-Seong_1.png", "1A", "00", "Yun-Seong__1.png", "" },
            { "Yun-Seong", "Costume 2", "_", "Yun-Seong_2.png", "1A", "01", "Yun-Seong__2.png", "" },
            { "Yun-Seong", "Costume 1 Color Edit", "_", "Yun-Seong_1.png", "1A", "08", "Yun-Seong__1E.png", "" },
            { "Yun-Seong", "Costume 2 Color Edit", "_", "Yun-Seong_2.png", "1A", "09", "Yun-Seong__2E.png", "" }
        };
        public string[,] SetsukaValues = new string[,]
        {
            { "Setsuka", "Costume 1", "Soul of Setsuka", "Setsuka_1.png", "22", "00", "Setsuka__1.png", "" },
            { "Setsuka", "Costume 2", "_", "Setsuka_2.png", "22", "01", "Setsuka__2.png", "" },
            { "Setsuka", "Costume 1 Color Edit", "_", "Setsuka_1.png", "22", "08", "Setsuka__1E.png", "" },
            { "Setsuka", "Costume 2 Color Edit", "_", "Setsuka_2.png", "22", "09", "Setsuka__2E.png", "" }
        };
        public string[,] TiraValues = new string[,]
        {
            { "Tira", "Costume 1", "Soul of Tira", "Tira_1.png", "23", "00", "Tira__1.png", "" },
            { "Tira", "Costume 2", "_", "Tira_2.png", "23", "01", "Tira__2.png", "" },
            { "Tira", "Costume 1 Color Edit", "_", "Tira_1.png", "23", "08", "Tira__1E.png", "" },
            { "Tira", "Costume 2 Color Edit", "_", "Tira_2.png", "23", "09", "Tira__2E.png", "" }
        };
        public string[,] ZasalamelValues = new string[,]
        {
            { "Zasalamel", "Costume 1", "Soul of Zasalamel", "Zasalamel_1.png", "24", "00", "Zasalamel__1.png", "" },
            { "Zasalamel", "Costume 2", "_", "Zasalamel_2.png", "24", "01", "Zasalamel__2.png", "" },
            { "Zasalamel", "Costume 1 Color Edit", "_", "Zasalamel_1.png", "24", "08", "Zasalamel__1E.png", "" },
            { "Zasalamel", "Costume 2 Color Edit", "_", "Zasalamel_2.png", "24", "09", "Zasalamel__2E.png", "" },
            { "Zasalamel", "Old man", "_", "Zasalamel_2.png", "35", "00", "Zasalamel__EX.png", "" }
        };
        public string[,] OlcadanValues = new string[,]
        {
            { "Olcadan", "Costume 1", "Soul of Olcadan", "Olcadan_1.png", "25", "00", "Olcadan__1.png", "" },
            { "Olcadan", "Costume 2", "_", "Olcadan_2.png", "25", "01", "Olcadan__2.png", "" },
            { "Olcadan", "Costume 1 Color Edit", "_", "Olcadan_1.png", "25", "08", "Olcadan__1E.png", "" },
            { "Olcadan", "Costume 2 Color Edit", "_", "Olcadan_2.png", "25", "09", "Olcadan__2E.png", "" }
        };
        public string[,] AbyssValues = new string[,]
        {
            { "Abyss", "Costume 1", "Soul of Abyss", "Abyss_1.png", "26", "00", "Abyss__1.png", "" },
            { "Abyss", "Costume 2", "_", "Abyss_2.png", "26", "01", "Abyss__2.png", "" },
            { "Abyss", "Costume 1 Color Edit", "_", "Abyss_1.png", "26", "08", "Abyss__1E.png", "" },
            { "Abyss", "Costume 2 Color Edit", "_", "Abyss_2.png", "26", "09", "Abyss__2E.png", "" }
        };

        //Bonus Characters
        public string[,] AmyValues = new string[,]
        {
            { "Amy", "Costume 1", "Rapier", "Amy.png", "30", "00", "Amy__1.png", "" },
            { "Amy", "Costume 2", "_", "Amy.png", "30", "01", "Amy__2.png", "" },
            { "Amy", "Custom voice", "_", "Amy.png", "30", "00", "Amy__1.png", "73" }
        };
        public string[,] MiserValues = new string[,]
        {
            { "Miser", "Costume 1", "Katana & Shuriken", "Miser.png", "41", "00", "Miser__1.png", "" },
            { "Miser", "Costume 2", "_", "Miser.png", "41", "01", "Miser__2.png", "" }
        };
        public string[,] GreedValues = new string[,]
        {
            { "Greed", "Costume 1", "Kunai", "Greed.png", "42", "00", "Greed__1.png", "" },
            { "Greed", "Costume 2", "_", "Greed.png", "42", "01", "Greed__2.png", "" }
        };
        public string[,] ArthurValues = new string[,]
        {
            { "Arthur", "Costume 1", "Katana", "Arthur.png", "43", "00", "Arthur__1.png", "" },
            { "Arthur", "Costume 2", "_", "Arthur.png", "43", "01", "Arthur__2.png", "" }
        };
        public string[,] HwangValues = new string[,]
        {
            { "Hwang", "Costume 1", "Chinese Sword", "Hwang.png", "44", "00", "Hwang__1.png", "" },
            { "Hwang", "Costume 2", "_", "Hwang.png", "44", "01", "Hwang__2.png", "" }
        };
        public string[,] LunaValues = new string[,]
        {
            { "Luna", "Costume 1", "Chinese Blade", "Luna_1.webp", "45", "00", "Luna__1.png", "" },
            { "Luna", "Costume 2", "_", "Luna_2.webp", "45", "01", "Luna__2.png", "" },
            { "Luna", "Costume 3", "_", "Luna.png", "E1", "02", "Luna__3.png", "" }
        };
        public string[,] ValeriaValues = new string[,]
        {
            { "Valeria", "Costume 1", "Grieve Edge", "Valeria.png", "46", "00", "Valeria__1.png", "" },
            { "Valeria", "Costume 2", "_", "Valeria.png", "46", "01", "Valeria__2.png", "" }
        };
        public string[,] HualinValues = new string[,]
        {
            { "Hualin", "Costume 1", "Staff", "Hualin.png", "47", "00", "Hualin__1.png", "" },
            { "Hualin", "Costume 2", "_", "Hualin.png", "47", "01", "Hualin__2.png", "" }
        };
        public string[,] GirardotValues = new string[,]
        {
            { "Girardot", "Costume 1", "Lance", "Girardot_1.webp", "48", "00", "Girardot__1.png", "" },
            { "Girardot", "Costume 2", "_", "Girardot_2.webp", "48", "01", "Girardot__2.png", "" }
        };
        public string[,] DemuthValues = new string[,]
        {
            { "Demuth", "Costume 1", "Steel Fan", "Demuth_1.webp", "4A", "00", "Demuth__1.png", "" },
            { "Demuth", "Costume 2", "_", "Demuth_2.webp", "4A", "01", "Demuth__2.png", "" }
        };
        public string[,] AureliaValues = new string[,]
        {
            { "Aurelia", "Costume 1", "Sickle", "Aurelia_1.webp", "4B", "00", "Aurelia__1.png", "" },
            { "Aurelia", "Costume 2", "_", "Aurelia_2.webp", "4B", "01", "Aurelia__2.png", "" }
        };
        public string[,] ChesterValues = new string[,]
        {
            { "Chester", "Costume 3", "_", "Chester_1.webp", "E4", "00", "Chester__3.png", "" },
            { "Chester", "Costume 1", "Dagger", "Chester_2.webp", "4C", "00", "Chester__1.png", "" },
            { "Chester", "Costume 2", "_", "Chester_3.webp", "4C", "01", "Chester__2.png", "" }
        };
        public string[,] StrifeValues = new string[,]
        {
            { "Strife", "Costume 1", "Iron Sword", "Strife_1.webp", "4D", "00", "Strife__1.png", "" },
            { "Strife", "Costume 2", "_", "Strife_2.webp", "4D", "01", "Strife__2.png", "" }
        };
        public string[,] AbeliaValues = new string[,]
        {
            { "Abelia", "Ally unit", "_", "Abelia_1.webp", "E0", "00", "Abelia__4.png", "72" },
            { "Abelia", "Ally unit", "_", "Abelia_2.webp", "E0", "01", "Abelia__5.png", "71" },
            { "Abelia", "Costume 1", "Sword & Shield", "Abelia.png", "4E", "00", "Abelia__1.png", "" },
            { "Abelia", "Costume 2", "_", "Abelia.png", "4E", "01", "Abelia__2.png", "" },
            { "Abelia", "Costume 3", "_", "Abelia.png", "E0", "02", "Abelia__3.png", "" }
        };
        public string[,] LynetteValues = new string[,]
        {
            { "Lynette", "Costume 1", "Tambourine", "Lynette.png", "4F", "00", "Lynette__1.png", "" },
            { "Lynette", "Costume 2", "_", "Lynette.png", "4F", "01", "Lynette__2.png", "" }
        };
        public string[,] LiLongValues = new string[,]
        {
            { "Li Long", "Costume 1", "Nunchaku", "LiLong.png", "51", "00", "Li Long__1.png", "" },
            { "Li Long", "Costume 2", "_", "LiLong.png", "51", "01", "Li Long__2.png", "" }
        };
        public string[,] RevenantValues = new string[,]
        {
            { "Revenant", "Costume 1", "Wave Sword", "Revenant.png", "54", "00", "Revenant__1.png", "" },
            { "Revenant", "Costume 2", "_", "Revenant.png", "54", "01", "Revenant__2.png", "" }
        };

        //Tales of Souls NPC
        public string[,] LizardMenValues = new string[,]
        {
            { "Lizard Men", "Costume 1", "Soul of Lizardman", "LizardMen.png", "1E", "00", "Lizard Men__1.png", "" }
        };
        public string[,] NightTerrorValues = new string[,]
        {
            { "Night Terror", "Costume 1", "Soul of Night Terror", "NightTerror.png", "27", "00", "Night Terror__1.png", "" }
        };
        public string[,] CharadeValues = new string[,]
        {
            { "Charade", "Costume 1", "Wave Sword", "Charade.png", "28", "00", "Charade__1.png", "" },
            { "Charade", "Costume 2", "Grieve Edge", "Charade.png", "29", "00", "Charade__2.png", "" },
            { "Charade", "Costume 3", "Soul of Charade", "Charade.png", "2A", "00", "Charade__3.png", "" }
        };
        public string[,] InfernoValues = new string[,]
        {
            { "Inferno", "Costume 1", "Soul of Cervantes", "Inferno.png", "2B", "00", "Inferno__1.png", "" }
        };
        public string[,] ShadowMasterValues = new string[,]
        {
            { "Shadow Master", "Costume 1", "Random Bonus Char", "Shadow Master.png", "2E", "00", "Shadow Master__1.png", "" }
        };
        public string[,] ColossusValues = new string[,]
        {
            { "Colossus", "Costume 1", "Soul of Collosus", "Colossus.png", "31", "00", "Colossus__1.png", "" }
        };
        public string[,] BerserkerValues = new string[,]
        {
            { "Berserker", "Costume 1", "Lance", "Berserker.png", "81", "00", "Berserker__1.png", "" }
        };
        public string[,] Samurai1Values = new string[,]
        {
            { "Samurai 1", "Costume 1", "Katana", "Samurai_1.png", "84", "00", "Samurai__1.png", "" }
        };
        public string[,] Samurai2Values = new string[,]
        {
            { "Samurai 2", "Costume 1", "Katana", "Samurai_2.png", "84", "01", "Samurai__2.png", "" }
        };
        public string[,] Samurai3Values = new string[,]
        {
            { "Samurai 3", "Costume 1", "Katana", "Samurai_3.png", "84", "02", "Samurai__3.png", "" }
        };
        public string[,] Samurai4Values = new string[,]
        {
            { "Samurai 4", "Costume 1", "Katana", "Samurai_4.png", "84", "03", "Samurai__4.png", "" }
        };
        public string[,] Gladiator1Values = new string[,]
        {
            { "Gladiator 1", "Costume 1", "Iron Sword", "Gladiator_1.png", "85", "00", "Gladiator__1.png", "" }
        };
        public string[,] Gladiator2Values = new string[,]
        {
            { "Gladiator 2", "Costume 1", "Sword & Shield", "Gladiator_2.png", "86", "00", "Gladiator__2.png", "" }
        };
        public string[,] UnknownSoulValues = new string[,]
        {
            { "Unknown Soul", "Li Long", "Nunchaku", "UnknownSoul_1.png", "87", "00", "Unknown Soul__1.png", "" },
            { "Unknown Soul", "Hwang", "Chinese Sword", "UnknownSoul_2.png", "88", "00", "Unknown Soul__2.png", "" },
            { "Unknown Soul", "Arthur", "Katana", "UnknownSoul_3.png", "89", "00", "Unknown Soul__3.png", "" }
        };
        public string[,] FumaNinja1Values = new string[,]
        {
            { "Fu-ma Ninja 1", "Costume 1", "Kunai", "Fu-maNinja_1.png", "8A", "00", "Fu-ma Ninja__1.png", "" }
        };
        public string[,] FumaNinja2Values = new string[,]
        {
            { "Fu-ma Ninja 2", "Costume 1", "Sickle", "Fu-maNinja_2.png", "8B", "00", "Fu-ma Ninja__2.png", "" }
        };
        public string[,] FumaNinja3Values = new string[,]
        {
            { "Fu-ma Ninja 3", "Costume 1", "Sickle", "Fu-maNinja_3.png", "8B", "01", "Fu-ma Ninja__3.png", "" }
        };
        public string[,] FumaNinja4Values = new string[,]
        {
            { "Fu-ma Ninja 4", "Costume 1", "Katana & Shuriken", "Fu-maNinja_4.png", "8C", "00", "Fu-ma Ninja__4.png", "" }
        };
        public string[,] FumaNinja5Values = new string[,]
        {
            { "Fu-ma Ninja 5", "Costume 1", "Katana & Shuriken", "Fu-maNinja_5.png", "8C", "01", "Fu-ma Ninja__5.png", "" }
        };
        public string[,] FumaNinja6Values = new string[,]
        {
            { "Fu-ma Ninja 6", "Costume 1", "Katana & Shuriken", "Fu-maNinja_6.png", "8C", "02", "Fu-ma Ninja__6.png", "" }
        };
        public string[,] FumaNinja7Values = new string[,]
        {
            { "Fu-ma Ninja 7", "Costume 1", "Katana & Shuriken", "Fu-maNinja_7.png", "8C", "03", "Fu-ma Ninja__7.png", "" }
        };
        public string[,] Bandit1Values = new string[,]
        {
            { "Bandit 1", "Costume 1", "Chinese Blade", "Bandit_1.png", "8D", "00", "Bandit__1.png", "" }
        };
        public string[,] Bandit2Values = new string[,]
        {
            { "Bandit 2", "Costume 1", "Sickle", "Bandit_2.png", "8E", "00", "Bandit__2.png", "" }
        };
        public string[,] Bandit3Values = new string[,]
        {
            { "Bandit 3", "Costume 1", "Sickle", "Bandit_3.png", "8E", "01", "Bandit__3.png", "" }
        };
        public string[,] Thief1Values = new string[,]
        {
            { "Thief 1", "Costume 1", "Dagger", "Thief_1.png", "8F", "00", "Thief__1.png", "" }
        };
        public string[,] Thief2Values = new string[,]
        {
            { "Thief 2", "Costume 1", "Dagger", "Thief_2.png", "90", "00", "Thief__2.png", "" }
        };
        public string[,] Pirate1Values = new string[,]
        {
            { "Pirate 1", "Costume 1", "Dagger", "Pirate_1.png", "91", "00", "Pirate__1.png", "" }
        };
        public string[,] Pirate2Values = new string[,]
        {
            { "Pirate 2", "Costume 1", "Dagger", "Pirate_2.png", "91", "01", "Pirate__2.png", "" }
        };
        public string[,] Pirate3Values = new string[,]
        {
            { "Pirate 3", "Costume 1", "Dagger", "Pirate_3.png", "91", "02", "Pirate__3.png", "" }
        };
        public string[,] Pirate4Values = new string[,]
        {
            { "Pirate 4", "Costume 1", "Chinese Sword", "Pirate_4.png", "92", "00", "Pirate__4.png", "" }
        };
        public string[,] Pirate5Values = new string[,]
        {
            { "Pirate 5", "Costume 1", "Chinese Sword", "Pirate_5.png", "92", "01", "Pirate__5.png", "" }
        };
        public string[,] Pirate6Values = new string[,]
        {
            { "Pirate 6", "Costume 1", "Chinese Sword", "Pirate_6.png", "92", "02", "Pirate__6.png", "" }
        };
        public string[,] Pirate7Values = new string[,]
        {
            { "Pirate 7", "Costume 1", "Chinese Sword", "Pirate_7.png", "92", "03", "Pirate__7.png", "" }
        };
        public string[,] AssassinValues = new string[,]
        {
            { "Assassin", "Costume 1", "Kunai", "Assassin.png", "93", "00", "Assassin__1.png", "" }
        };
        public string[,] Swordsman1Values = new string[,]
        {
            { "Swordsman 1", "Costume 1", "Chinese Blade", "Swordsman_1.png", "94", "00", "Swordsman__1.png", "" }
        };
        public string[,] Swordsman2Values = new string[,]
        {
            { "Swordsman 2", "Costume 1", "Chinese Blade", "Swordsman_2.png", "94", "01", "Swordsman__2.png", "" }
        };
        public string[,] FootSoldierValues = new string[,]
        {
            { "FootSoldier", "Costume 1", "Sword & Shield", "FootSoldier.png", "95", "00", "FootSoldier__1.png", "" }
        };
        public string[,] GeneralValues = new string[,]
        {
            { "General", "Costume 1", "Iron Sword", "General.png", "96", "00", "General__1.png", "" }
        };
        public string[,] SentryValues = new string[,]
        {
            { "Sentry", "Costume 1", "Staff", "Sentry.png", "97", "00", "Sentry__1.png", "" }
        };
        public string[,] KeresValues = new string[,]
        {
            { "Keres", "Costume 1", "Iron Sword", "Keres.png", "98", "00", "Keres__1.png", "" }
        };
        public string[,] DragonValues = new string[,]
        {
            { "Dragon", "Costume 1", "Chinese Sword", "Dragon.png", "99", "00", "Dragon__1.png", "" }
        };

        //Chronicles of the Sword
        public string[,] JinkaiValues = new string[,]
        {
            { "Jinkai", "Ally unit", "Katana & Shuriken", "Jinkai.webp", "A0", "00", "Jinkai__2.png", "6A" },
            { "Jinkai", "Enemy unit", "Katana & Shuriken", "Jinkai.webp", "A0", "00", "Jinkai__1.png", "" }
        };
        public string[,] KagamiValues = new string[,]
        {
            { "Kagami", "Costume 1", "Katana & Shuriken", "Kagami.webp", "A0", "01", "Kagami__1.png", "" }
        };
        public string[,] ShiunValues = new string[,]
        {
            { "Shiun", "Costume 1", "Katana & Shuriken", "Shiun.webp", "A0", "02", "Shiun__1.png", "" }
        };
        public string[,] ShiinaValues = new string[,]
        {
            { "Shiina", "Costume 1", "Katana & Shuriken", "Shiina.webp", "A1", "00", "Shiina__1.png", "" }
        };
        public string[,] ChikageValues = new string[,]
        {
            { "Chikage", "Costume 1", "Katana & Shuriken", "Chikage.webp", "A1", "01", "Chikage__1.png", "" }
        };
        public string[,] KonomiValues = new string[,]
        {
            { "Konomi", "Costume 1", "Katana & Shuriken", "Konomi.webp", "A1", "02", "Konomi__1.png", "" }
        };
        public string[,] CassiusValues = new string[,]
        {
            { "Cassius", "Costume 1", "Kunai", "Cassius.webp", "A2", "00", "Cassius__1.png", "" }
        };
        public string[,] SaizouValues = new string[,]
        {
            { "Saizou", "Costume 1", "Kunai", "Saizou.webp", "A2", "01", "Saizou__1.png", "" }
        };
        public string[,] RyougaValues = new string[,]
        {
            { "Ryouga", "Costume 1", "Kunai", "Ryouga.webp", "A2", "02", "Ryouga__1.png", "" }
        };
        public string[,] KimikaValues = new string[,]
        {
            { "Kimika", "Costume 1", "Kunai", "Kimika.webp", "A3", "00", "Kimika__1.png", "" }
        };
        public string[,] SyunnaValues = new string[,]
        {
            { "Syunna", "Costume 1", "Kunai", "Syunna.webp", "A3", "01", "Syunna__1.png", "" }
        };
        public string[,] TomoeValues = new string[,]
        {
            { "Tomoe", "Costume 1", "Kunai", "Tomoe.webp", "A3", "02", "Tomoe__1.png", "" }
        };
        public string[,] MeigaValues = new string[,]
        {
            { "Meiga", "Ally unit", "Katana", "Meiga.webp", "A4", "00", "Meiga__2.png", "60" },
            { "Meiga", "Enemy unit", "Katana", "Meiga.webp", "A4", "00", "Meiga__1.png", "" }
        };
        public string[,] AlastorValues = new string[,]
        {
            { "Alastor", "Costume 1", "Katana", "Alastor.webp", "A4", "01", "Alastor__1.png", "" }
        };
        public string[,] ShizumaValues = new string[,]
        {
            { "Shizuma", "Costume 1", "Katana", "Shizuma.webp", "A4", "02", "Shizuma__1.png", "" }
        };
        public string[,] AzumiValues = new string[,]
        {
            { "Azumi", "Costume 1", "Katana", "Azumi.webp", "A5", "00", "Azumi__1.png", "" }
        };
        public string[,] YukinaValues = new string[,]
        {
            { "Yukina", "Costume 1", "Katana", "Yukina.webp", "A5", "01", "Yukina__1.png", "" }
        };
        public string[,] OukaValues = new string[,]
        {
            { "Ouka", "Costume 1", "Katana", "Ouka.webp", "A5", "02", "Ouka__1.png", "" }
        };
        public string[,] XiaoxinValues = new string[,]
        {
            { "Xiaoxin", "Ally unit", "Chinese Sword", "Xiaoxin.webp", "A6", "00", "Xiaoxin__2.png", "68" },
            { "Xiaoxin", "Enemy unit", "Chinese Sword", "Xiaoxin.webp", "A6", "00", "Xiaoxin__1.png", "" }
        };
        public string[,] OruksValues = new string[,]
        {
            { "Oruks", "Costume 1", "Chinese Sword", "Oruks.webp", "A6", "01", "Oruks__1.png", "" }
        };
        public string[,] AgarethValues = new string[,]
        {
            { "Agareth", "Costume 1", "Chinese Sword", "Agareth.webp", "A6", "02", "Agareth__1.png", "" }
        };
        public string[,] JyuriValues = new string[,]
        {
            { "Jyuri", "Costume 1", "Chinese Sword", "Jyuri.webp", "A7", "00", "Jyuri__1.png", "" }
        };
        public string[,] ShuyuValues = new string[,]
        {
            { "Shuyu", "Costume 1", "Chinese Sword", "Shuyu.webp", "A7", "01", "Shuyu__1.png", "" }
        };
        public string[,] MingyueValues = new string[,]
        {
            { "Mingyue", "Costume 1", "Chinese Sword", "Mingyue.webp", "A7", "02", "Mingyue__1.png", "" }
        };
        public string[,] VelesValues = new string[,]
        {
            { "Veles", "Costume 1", "Chinese Blade", "Veles.webp", "A8", "00", "Veles__1.png", "" }
        };
        public string[,] AetherValues = new string[,]
        {
            { "Aether", "Costume 1", "Chinese Blade", "Aether.webp", "A8", "01", "Aether__1.png", "" }
        };
        public string[,] IxionValues = new string[,]
        {
            { "Ixion", "Costume 1", "Chinese Blade", "Ixion.webp", "A8", "02", "Ixion__1.png", "" }
        };
        public string[,] SiulanValues = new string[,]
        {
            { "Siulan", "Costume 1", "Chinese Blade", "Siulan.webp", "A9", "00", "Siulan__1.png", "" }
        };
        public string[,] FenglinValues = new string[,]
        {
            { "Fenglin", "Costume 1", "Chinese Blade", "Fenglin.webp", "A9", "01", "Fenglin__1.png", "" }
        };
        public string[,] PhilineValues = new string[,]
        {
            { "Philine", "Costume 1", "Chinese Blade", "Philine.webp", "A9", "02", "Philine__1.png", "" }
        };
        public string[,] IgnisValues = new string[,]
        {
            { "Ignis", "Costume 1", "Grieve Edge", "Ignis.webp", "AA", "00", "Ignis__1.png", "" }
        };
        public string[,] NotusValues = new string[,]
        {
            { "Notus", "Costume 1", "Grieve Edge", "Notus.webp", "AA", "01", "Notus__1.png", "" }
        };
        public string[,] AzraelValues = new string[,]
        {
            { "Azrael", "Costume 1", "Grieve Edge", "Azrael.webp", "AA", "02", "Azrael__1.png", "" }
        };
        public string[,] MireilleValues = new string[,]
        {
            { "Mireille", "Costume 1", "Grieve Edge", "Mireille.webp", "AB", "00", "Mireille__1.png", "" }
        };
        public string[,] AglaiaValues = new string[,]
        {
            { "Aglaia", "Costume 1", "Grieve Edge", "Aglaia.webp", "AB", "01", "Aglaia__1.png", "" }
        };
        public string[,] KanonValues = new string[,]
        {
            { "Kanon", "Ally unit", "Grieve Edge", "Kanon.webp", "AB", "02", "Kanon__2.png", "74" },
            { "Kanon", "Enemy unit", "Grieve Edge", "Kanon.webp", "AB", "02", "Kanon__1.png", "" }
        };
        public string[,] JyuraiValues = new string[,]
        {
            { "Jyurai", "Costume 1", "Staff", "Jyurai.webp", "AC", "00", "Jyurai__1.png", "" }
        };
        public string[,] KurehaValues = new string[,]
        {
            { "Kureha", "Costume 1", "Staff", "Kureha.webp", "AC", "01", "Kureha__1.png", "" }
        };
        public string[,] XunyuValues = new string[,]
        {
            { "Xunyu", "Costume 1", "Staff", "Xunyu.webp", "AC", "02", "Xunyu__1.png", "" }
        };
        public string[,] FengyuValues = new string[,]
        {
            { "Fengyu", "Costume 1", "Staff", "Fengyu.webp", "AD", "00", "Fengyu__1.png", "" }
        };
        public string[,] FengleiValues = new string[,]
        {
            { "Fenglei", "Costume 1", "Staff", "Fenglei.webp", "AD", "01", "Fenglei__1.png", "" }
        };
        public string[,] MinglianValues = new string[,]
        {
            { "Minlian", "Costume 1", "Staff", "Minglian.webp", "AD", "02", "Minglian__1.png", "" }
        };
        public string[,] NoelValues = new string[,]
        {
            { "Noel", "Costume 1", "Lance", "Noel.webp", "AE", "00", "Noel__1.png", "" }
        };
        public string[,] RudigerValues = new string[,]
        {
            { "Rudiger", "Ally unit", "Lance", "Rudiger_2.webp", "AE", "01", "Rudiger__2.png", "67" },
            { "Rudiger", "Enemy unit", "Lance", "Rudiger_1.webp", "AE", "01", "Rudiger__1.png", "" }
        };
        public string[,] AeneasValues = new string[,]
        {
            { "Aeneas", "Ally unit", "Lance", "Aeneas.webp", "AE", "02", "Aeneas__2.png", "60" },
            { "Aeneas", "Enemy unit", "Lance", "Aeneas.webp", "AE", "02", "Aeneas__1.png", "" }
        };
        public string[,] AnnarettaValues = new string[,]
        {
            { "Annaretta", "Costume 1", "Lance", "Annaretta.webp", "AF", "00", "Annaretta__1.png", "" }
        };
        public string[,] IrisValues = new string[,]
        {
            { "Iris", "Costume 1", "Lance", "Iris.webp", "AF", "01", "Iris__1.png", "" }
        };
        public string[,] BrunhildValues = new string[,]
        {
            { "Brunhild", "Costume 1", "Lance", "Brunhild.webp", "AF", "02", "Brunhild__1.png", "" }
        };
        public string[,] AsrafilValues = new string[,]
        {
            { "Asrafil", "Costume 1", "Steel Fan", "Asrafil.webp", "B0", "00", "Asrafil__1.png", "" }
        };
        public string[,] ZifengValues = new string[,]
        {
            { "Zifeng", "Costume 1", "Steel Fan", "Zifeng.webp", "B0", "01", "Zifeng__1.png", "" }
        };
        public string[,] AeolosValues = new string[,]
        {
            { "Aeolos", "Costume 1", "Steel Fan", "Aeolos.webp", "B0", "02", "Aeolos__1.png", "" }
        };
        public string[,] AmritaValues = new string[,]
        {
            { "Amrita", "Costume 1", "Steel Fan", "Amrita.webp", "B1", "00", "Amrita__1.png", "" }
        };
        public string[,] AzaleaValues = new string[,]
        {
            { "Azalea", "Costume 1", "Steel Fan", "Azalea.webp", "B1", "01", "Azalea__1.png", "" }
        };
        public string[,] YueliangValues = new string[,]
        {
            { "Yueliang", "Costume 1", "Steel Fan", "Yueliang.webp", "B1", "02", "Yueliang__1.png", "" }
        };
        public string[,] KanadeValues = new string[,]
        {
            { "Kanade", "Costume 1", "Sickle", "Kanade.webp", "B2", "00", "Kanade__1.png", "" }
        };
        public string[,] DomenthiValues = new string[,]
        {
            { "Domenthi", "Costume 1", "Sickle", "Domenthi.webp", "B2", "01", "Domenthi__1.png", "" }
        };
        public string[,] MaridValues = new string[,]
        {
            { "Marid", "Costume 1", "Sickle", "Marid.webp", "B2", "02", "Marid__1.png", "" }
        };
        public string[,] AmbroseValues = new string[,]
        {
            { "Ambrose", "Costume 1", "Sickle", "Ambrose.webp", "B3", "00", "Ambrose__1.png", "" }
        };
        public string[,] AilianValues = new string[,]
        {
            { "Ailian", "Ally unit", "Sickle", "Ailian.webp", "B3", "01", "Ailian__2.png", "71" },
            { "Ailian", "Enemy unit", "Sickle", "Ailian.webp", "B3", "01", "Ailian__1.png", "" }
        };
        public string[,] AikaValues = new string[,]
        {
            { "Aika", "Costume 1", "Sickle", "Aika.webp", "B3", "02", "Aika__1.png", "" }
        };
        public string[,] LokiValues = new string[,]
        {
            { "Loki", "Costume 1", "Dagger", "Loki.webp", "B4", "00", "Loki__1.png", "" }
        };
        public string[,] CelestisValues = new string[,]
        {
            { "Celestis", "Costume 1", "Dagger", "Celestis.webp", "B4", "01", "Celestis__1.png", "" }
        };
        public string[,] BelethValues = new string[,]
        {
            { "Beleth", "Costume 1", "Dagger", "Beleth.webp", "B4", "02", "Beleth__1.png", "" }
        };
        public string[,] KarenValues = new string[,]
        {
            { "Karen", "Costume 1", "Dagger", "Karen.webp", "B5", "00", "Karen__1.png", "" }
        };
        public string[,] LilanValues = new string[,]
        {
            { "Lilan", "Costume 1", "Dagger", "Lilan.webp", "B5", "01", "Lilan__1.png", "" }
        };
        public string[,] AbigailValues = new string[,]
        {
            { "Abigail", "Costume 1", "Dagger", "Abigail.webp", "B5", "02", "Abigail__1.png", "" }
        };
        public string[,] BalduinValues = new string[,]
        {
            { "Balduin", "Costume 1", "Iron Sword", "Balduin.webp", "B6", "00", "Balduin__1.png", "" }
        };
        public string[,] AlocesValues = new string[,]
        {
            { "Aloces", "Costume 1", "Iron Sword", "Aloces.webp", "B6", "01", "Aloces__1.png", "" }
        };
        public string[,] AreonValues = new string[,]
        {
            { "Areon", "Costume 1", "Iron Sword", "Areon.webp", "B6", "02", "Areon__1.png", "" }
        };
        public string[,] JunoValues = new string[,]
        {
            { "Juno", "Costume 1", "Iron Sword", "Juno.webp", "B7", "00", "Juno__1.png", "" }
        };
        public string[,] EurydiceValues = new string[,]
        {
            { "Eurydice", "Ally unit", "Iron Sword", "Eurydice.webp", "B7", "01", "Eurydice__2.png", "76" },
            { "Eurydice", "Enemy unit", "Iron Sword", "Eurydice.webp", "B7", "01", "Eurydice__1.png", "" }
        };
        public string[,] IshtarValues = new string[,]
        {
            { "Ishtar", "Costume 1", "Iron Sword", "Ishtar.webp", "B7", "02", "Ishtar__1.png", "" }
        };
        public string[,] RufusValues = new string[,]
        {
            { "Rufus", "Costume 1", "Sword & Shield", "Rufus.webp", "B8", "00", "Rufus__1.png", "" }
        };
        public string[,] RaguelValues = new string[,]
        {
            { "Raguel", "Costume 1", "Sword & Shield", "Raguel.webp", "B8", "01", "Raguel__1.png", "" }
        };
        public string[,] FeofanValues = new string[,]
        {
            { "Feofan", "Ally unit", "Sword & Shield", "Feofan.webp", "B8", "02", "Feofan__2.png", "64" },
            { "Feofan", "Enemy unit", "Sword & Shield", "Feofan.webp", "B8", "02", "Feofan__1.png", "" }
        };
        public string[,] EuniceValues = new string[,]
        {
            { "Eunice", "Costume 1", "Sword & Shield", "Eunice.webp", "B9", "00", "Eunice__1.png", "" }
        };
        public string[,] AcaciaValues = new string[,]
        {
            { "Acacia", "Costume 1", "Sword & Shield", "Acacia.webp", "B9", "01", "Acacia__1.png", "" }
        };
        public string[,] HildaValues = new string[,]
        {
            { "Hilda", "Costume 1", "Sword & Shield", "Hilda.webp", "B9", "02", "Hilda__1.png", "" }
        };
        public string[,] IblisValues = new string[,]
        {
            { "Iblis", "Costume 1", "Tambourine", "Iblis.webp", "BA", "00", "Iblis__1.png", "" }
        };
        public string[,] AlbericValues = new string[,]
        {
            { "Alberic", "Costume 1", "Tambourine", "Alberic.webp", "BA", "01", "Alberic__1.png", "" }
        };
        public string[,] LeshyValues = new string[,]
        {
            { "Leshy", "Costume 1", "Tambourine", "Leshy.webp", "BA", "02", "Leshy__1.png", "" }
        };
        public string[,] MurielValues = new string[,]
        {
            { "Muriel", "Costume 1", "Tambourine", "Muriel.webp", "BB", "00", "Muriel__1.png", "" }
        };
        public string[,] WenliValues = new string[,]
        {
            { "Wenli", "Costume 1", "Tambourine", "Wenli.webp", "BB", "01", "Wenli__1.png", "" }
        };
        public string[,] IreneValues = new string[,]
        {
            { "Irene", "Costume 1", "Tambourine", "Irene.webp", "BB", "02", "Irene__1.png", "" }
        };
        public string[,] YufengValues = new string[,]
        {
            { "Yufeng", "Costume 1", "Nunchaku", "Yufeng.webp", "BC", "00", "Yufeng__1.png", "" }
        };
        public string[,] YakumoValues = new string[,]
        {
            { "Yakumo", "Costume 1", "Nunchaku", "Yakumo.webp", "BC", "01", "Yakumo__1.png", "" }
        };
        public string[,] DufengValues = new string[,]
        {
            { "Dufeng", "Costume 1", "Nunchaku", "Dufeng.webp", "BC", "02", "Dufeng__1.png", "" }
        };
        public string[,] MayuraValues = new string[,]
        {
            { "Mayura", "Costume 1", "Nunchaku", "Mayura.webp", "BD", "00", "Mayura__1.png", "" }
        };
        public string[,] MeilanValues = new string[,]
        {
            { "Meilan", "Costume 1", "Nunchaku", "Meilan.webp", "BD", "01", "Meilan__1.png", "" }
        };
        public string[,] RheaValues = new string[,]
        {
            { "Rhea", "Costume 1", "Nunchaku", "Rhea.webp", "BD", "02", "Rhea__1.png", "" }
        };
        public string[,] HalphasValues = new string[,]
        {
            { "Halphas", "Costume 1", "Wave Sword", "Halphas.webp", "BE", "00", "Halphas__1.png", "" }
        };
        public string[,] GorusValues = new string[,]
        {
            { "Gorus", "Costume 1", "Wave Sword", "Gorus.webp", "BE", "01", "Gorus__1.png", "" }
        };
        public string[,] IlyushaValues = new string[,]
        {
            { "Ilyusha", "Costume 1", "Wave Sword", "Ilyusha.webp", "BE", "02", "Ilyusha__1.png", "" }
        };
        public string[,] EdithValues = new string[,]
        {
            { "Edith", "Costume 1", "Wave Sword", "Edith.webp", "BF", "00", "Edith__1.png", "" }
        };
        public string[,] RieseValues = new string[,]
        {
            { "Riese", "Ally unit", "Wave Sword", "Riese.webp", "BF", "01", "Riese__2.png", "70" },
            { "Riese", "Enemy unit", "Wave Sword", "Riese.webp", "BF", "01", "Riese__1.png", "" }
        };
        public string[,] AgaveValues = new string[,]
        {
            { "Agave", "Costume 1", "Wave Sword", "Agave.webp", "BF", "02", "Agave__1.png", "" }
        };
        public string[,] HaystirValues = new string[,]
        {
            { "Haystir", "Costume 1", "Rapier", "Haystir.webp", "C0", "00", "Haystir__1.png", "" }
        };
        public string[,] LerajeValues = new string[,]
        {
            { "Leraje", "Ally unit", "Rapier", "Leraje.webp", "C0", "01", "Leraje__2.png", "64" },
            { "Leraje", "Enemy unit", "Rapier", "Leraje.webp", "C0", "01", "Leraje__1.png", "" }
        };
        public string[,] RatzielValues = new string[,]
        {
            { "Ratziel", "Costume 1", "Rapier", "Ratziel.webp", "C0", "02", "Ratziel__1.png", "" }
        };
        public string[,] KatinaValues = new string[,]
        {
            { "Katina", "Costume 1", "Rapier", "Katina.webp", "C1", "00", "Katina__1.png", "" }
        };
        public string[,] ErisValues = new string[,]
        {
            { "Eris", "Costume 1", "Rapier", "Eris.webp", "C1", "01", "Eris__1.png", "" }
        };
        public string[,] SizukuValues = new string[,]
        {
            { "Sizuku", "Costume 1", "Rapier", "Sizuku.webp", "C1", "02", "Sizuku__1.png", "" }
        };
        public string[,] GrandallMaleValues = new string[,]
        {
            { "Grandall", "Male", "Katana & Shuriken", "Grandall_M.webp", "A0", "03", "Grandall__1.png", "" },
            { "Grandall", "", "Kunai", "Grandall_M.webp", "A2", "03", "Grandall__1.png", "" },
            { "Grandall", "", "Katana", "Grandall_M.webp", "A4", "03", "Grandall__1.png", "" },
            { "Grandall", "", "Chinese Sword", "Grandall_M.webp", "A6", "03", "Grandall__1.png", "" },
            { "Grandall", "", "Chinese Blade", "Grandall_M.webp", "A8", "03", "Grandall__1.png", "" },
            { "Grandall", "", "Grieve Edge", "Grandall_M.webp", "AA", "03", "Grandall__1.png", "" },
            { "Grandall", "", "Staff", "Grandall_M.webp", "AC", "03", "Grandall__1.png", "" },
            { "Grandall", "", "Lance", "Grandall_M.webp", "AE", "03", "Grandall__1.png", "" },
            { "Grandall", "", "Steel Fan", "Grandall_M.webp", "B0", "03", "Grandall__1.png", "" },
            { "Grandall", "", "Sickle", "Grandall_M.webp", "B2", "03", "Grandall__1.png", "" },
            { "Grandall", "", "Dagger", "Grandall_M.webp", "B4", "03", "Grandall__1.png", "" },
            { "Grandall", "", "Iron Sword", "Grandall_M.webp", "B6", "03", "Grandall__1.png", "" },
            { "Grandall", "", "Sword & Shield", "Grandall_M.webp", "B8", "03", "Grandall__1.png", "" },
            { "Grandall", "", "Tambourine", "Grandall_M.webp", "BA", "03", "Grandall__1.png", "" },
            { "Grandall", "", "Nunchaku", "Grandall_M.webp", "BC", "03", "Grandall__1.png", "" },
            { "Grandall", "", "Wave Sword", "Grandall_M.webp", "BE", "03", "Grandall__1.png", "" },
            { "Grandall", "", "Rapier", "Grandall_M.webp", "C0", "03", "Grandall__1.png", "" }
        };
        public string[,] DalkiaMaleValues = new string[,]
        {
            { "Dalkia", "Male", "Katana & Shuriken", "Dalkia_M.webp", "A0", "04", "Dalkia__1.png", "" },
            { "Dalkia", "", "Kunai", "Dalkia_M.webp", "A2", "04", "Dalkia__1.png", "" },
            { "Dalkia", "", "Katana", "Dalkia_M.webp", "A4", "04", "Dalkia__1.png", "" },
            { "Dalkia", "", "Chinese Sword", "Dalkia_M.webp", "A6", "04", "Dalkia__1.png", "" },
            { "Dalkia", "", "Chinese Blade", "Dalkia_M.webp", "A8", "04", "Dalkia__1.png", "" },
            { "Dalkia", "", "Grieve Edge", "Dalkia_M.webp", "AA", "04", "Dalkia__1.png", "" },
            { "Dalkia", "", "Staff", "Dalkia_M.webp", "AC", "04", "Dalkia__1.png", "" },
            { "Dalkia", "", "Lance", "Dalkia_M.webp", "AE", "04", "Dalkia__1.png", "" },
            { "Dalkia", "", "Steel Fan", "Dalkia_M.webp", "B0", "04", "Dalkia__1.png", "" },
            { "Dalkia", "", "Sickle", "Dalkia_M.webp", "B2", "04", "Dalkia__1.png", "" },
            { "Dalkia", "", "Dagger", "Dalkia_M.webp", "B4", "04", "Dalkia__1.png", "" },
            { "Dalkia", "", "Iron Sword", "Dalkia_M.webp", "B6", "04", "Dalkia__1.png", "" },
            { "Dalkia", "", "Sword & Shield", "Dalkia_M.webp", "B8", "04", "Dalkia__1.png", "" },
            { "Dalkia", "", "Tambourine", "Dalkia_M.webp", "BA", "04", "Dalkia__1.png", "" },
            { "Dalkia", "", "Nunchaku", "Dalkia_M.webp", "BC", "04", "Dalkia__1.png", "" },
            { "Dalkia", "", "Wave Sword", "Dalkia_M.webp", "BE", "04", "Dalkia__1.png", "" },
            { "Dalkia", "", "Rapier", "Dalkia_M.webp", "C0", "04", "Dalkia__1.png", "" }
        };
        public string[,] BrigandMaleValues = new string[,]
        {
            { "Brigand", "Male", "Katana & Shuriken", "Brigand_M.webp", "A0", "05", "Brigand__1.png", "" },
            { "Brigand", "", "Kunai", "Brigand_M.webp", "A2", "05", "Brigand__1.png", "" },
            { "Brigand", "", "Katana", "Brigand_M.webp", "A4", "05", "Brigand__1.png", "" },
            { "Brigand", "", "Chinese Sword", "Brigand_M.webp", "A6", "05", "Brigand__1.png", "" },
            { "Brigand", "", "Chinese Blade", "Brigand_M.webp", "A8", "05", "Brigand__1.png", "" },
            { "Brigand", "", "Grieve Edge", "Brigand_M.webp", "AA", "05", "Brigand__1.png", "" },
            { "Brigand", "", "Staff", "Brigand_M.webp", "AC", "05", "Brigand__1.png", "" },
            { "Brigand", "", "Lance", "Brigand_M.webp", "AE", "05", "Brigand__1.png", "" },
            { "Brigand", "", "Steel Fan", "Brigand_M.webp", "B0", "05", "Brigand__1.png", "" },
            { "Brigand", "", "Sickle", "Brigand_M.webp", "B2", "05", "Brigand__1.png", "" },
            { "Brigand", "", "Dagger", "Brigand_M.webp", "B4", "05", "Brigand__1.png", "" },
            { "Brigand", "", "Iron Sword", "Brigand_M.webp", "B6", "05", "Brigand__1.png", "" },
            { "Brigand", "", "Sword & Shield", "Brigand_M.webp", "B8", "05", "Brigand__1.png", "" },
            { "Brigand", "", "Tambourine", "Brigand_M.webp", "BA", "05", "Brigand__1.png", "" },
            { "Brigand", "", "Nunchaku", "Brigand_M.webp", "BC", "05", "Brigand__1.png", "" },
            { "Brigand", "", "Wave Sword", "Brigand_M.webp", "BE", "05", "Brigand__1.png", "" },
            { "Brigand", "", "Rapier", "Brigand_M.webp", "C0", "05", "Brigand__1.png", "" }
        };
        public string[,] MalettaMaleValues = new string[,]
        {
            { "Maletta", "Male", "Katana & Shuriken", "Maletta_M.webp", "A0", "06", "Maletta__1.png", "" },
            { "Maletta", "", "Kunai", "Maletta_M.webp", "A2", "06", "Maletta__1.png", "" },
            { "Maletta", "", "Katana", "Maletta_M.webp", "A4", "06", "Maletta__1.png", "" },
            { "Maletta", "", "Chinese Sword", "Maletta_M.webp", "A6", "06", "Maletta__1.png", "" },
            { "Maletta", "", "Chinese Blade", "Maletta_M.webp", "A8", "06", "Maletta__1.png", "" },
            { "Maletta", "", "Grieve Edge", "Maletta_M.webp", "AA", "06", "Maletta__1.png", "" },
            { "Maletta", "", "Staff", "Maletta_M.webp", "AC", "06", "Maletta__1.png", "" },
            { "Maletta", "", "Lance", "Maletta_M.webp", "AE", "06", "Maletta__1.png", "" },
            { "Maletta", "", "Steel Fan", "Maletta_M.webp", "B0", "06", "Maletta__1.png", "" },
            { "Maletta", "", "Sickle", "Maletta_M.webp", "B2", "06", "Maletta__1.png", "" },
            { "Maletta", "", "Dagger", "Maletta_M.webp", "B4", "06", "Maletta__1.png", "" },
            { "Maletta", "", "Iron Sword", "Maletta_M.webp", "B6", "06", "Maletta__1.png", "" },
            { "Maletta", "", "Sword & Shield", "Maletta_M.webp", "B8", "06", "Maletta__1.png", "" },
            { "Maletta", "", "Tambourine", "Maletta_M.webp", "BA", "06", "Maletta__1.png", "" },
            { "Maletta", "", "Nunchaku", "Maletta_M.webp", "BC", "06", "Maletta__1.png", "" },
            { "Maletta", "", "Wave Sword", "Maletta_M.webp", "BE", "06", "Maletta__1.png", "" },
            { "Maletta", "", "Rapier", "Maletta_M.webp", "C0", "06", "Maletta__1.png", "" }
        };
        public string[,] RebelMaleValues = new string[,]
        {
            { "Halteese/Rebel", "Male", "Katana & Shuriken", "Rebel_M.webp", "A0", "07", "Rebel__1.png", "" },
            { "Halteese/Rebel", "", "Kunai", "Rebel_M.webp", "A2", "07", "Rebel__1.png", "" },
            { "Halteese/Rebel", "", "Katana", "Rebel_M.webp", "A4", "07", "Rebel__1.png", "" },
            { "Halteese/Rebel", "", "Chinese Sword", "Rebel_M.webp", "A6", "07", "Rebel__1.png", "" },
            { "Halteese/Rebel", "", "Chinese Blade", "Rebel_M.webp", "A8", "07", "Rebel__1.png", "" },
            { "Halteese/Rebel", "", "Grieve Edge", "Rebel_M.webp", "AA", "07", "Rebel__1.png", "" },
            { "Halteese/Rebel", "", "Staff", "Rebel_M.webp", "AC", "07", "Rebel__1.png", "" },
            { "Halteese/Rebel", "", "Lance", "Rebel_M.webp", "AE", "07", "Rebel__1.png", "" },
            { "Halteese/Rebel", "", "Steel Fan", "Rebel_M.webp", "B0", "07", "Rebel__1.png", "" },
            { "Halteese/Rebel", "", "Sickle", "Rebel_M.webp", "B2", "07", "Rebel__1.png", "" },
            { "Halteese/Rebel", "", "Dagger", "Rebel_M.webp", "B4", "07", "Rebel__1.png", "" },
            { "Halteese/Rebel", "", "Iron Sword", "Rebel_M.webp", "B6", "07", "Rebel__1.png", "" },
            { "Halteese/Rebel", "", "Sword & Shield", "Rebel_M.webp", "B8", "07", "Rebel__1.png", "" },
            { "Halteese/Rebel", "", "Tambourine", "Rebel_M.webp", "BA", "07", "Rebel__1.png", "" },
            { "Halteese/Rebel", "", "Nunchaku", "Rebel_M.webp", "BC", "07", "Rebel__1.png", "" },
            { "Halteese/Rebel", "", "Wave Sword", "Rebel_M.webp", "BE", "07", "Rebel__1.png", "" },
            { "Halteese/Rebel", "", "Rapier", "Rebel_M.webp", "C0", "07", "Rebel__1.png", "" }
        };
        public string[,] GrandallFemaleValues = new string[,]
        {
            { "Grandall", "Female", "Katana & Shuriken", "Grandall_F.webp", "A1", "03", "Grandall__2.png", "" },
            { "Grandall", "", "Kunai", "Grandall_F.webp", "A3", "03", "Grandall__2.png", "" },
            { "Grandall", "", "Katana", "Grandall_F.webp", "A5", "03", "Grandall__2.png", "" },
            { "Grandall", "", "Chinese Sword", "Grandall_F.webp", "A7", "03", "Grandall__2.png", "" },
            { "Grandall", "", "Chinese Blade", "Grandall_F.webp", "A9", "03", "Grandall__2.png", "" },
            { "Grandall", "", "Grieve Edge", "Grandall_F.webp", "AB", "03", "Grandall__2.png", "" },
            { "Grandall", "", "Staff", "Grandall_F.webp", "AD", "03", "Grandall__2.png", "" },
            { "Grandall", "", "Lance", "Grandall_F.webp", "AF", "03", "Grandall__2.png", "" },
            { "Grandall", "", "Steel Fan", "Grandall_F.webp", "B1", "03", "Grandall__2.png", "" },
            { "Grandall", "", "Sickle", "Grandall_F.webp", "B3", "03", "Grandall__2.png", "" },
            { "Grandall", "", "Dagger", "Grandall_F.webp", "B5", "03", "Grandall__2.png", "" },
            { "Grandall", "", "Iron Sword", "Grandall_F.webp", "B7", "03", "Grandall__2.png", "" },
            { "Grandall", "", "Sword & Shield", "Grandall_F.webp", "B9", "03", "Grandall__2.png", "" },
            { "Grandall", "", "Tambourine", "Grandall_F.webp", "BB", "03", "Grandall__2.png", "" },
            { "Grandall", "", "Nunchaku", "Grandall_F.webp", "BD", "03", "Grandall__2.png", "" },
            { "Grandall", "", "Wave Sword", "Grandall_F.webp", "BF", "03", "Grandall__2.png", "" },
            { "Grandall", "", "Rapier", "Grandall_F.webp", "C1", "03", "Grandall__2.png", "" }
        };
        public string[,] DalkiaFemaleValues = new string[,]
        {
            { "Dalkia", "Female", "Katana & Shuriken", "Dalkia_F.webp", "A1", "04", "Dalkia__2.png", "" },
            { "Dalkia", "", "Kunai", "Dalkia_F.webp", "A3", "04", "Dalkia__2.png", "" },
            { "Dalkia", "", "Katana", "Dalkia_F.webp", "A5", "04", "Dalkia__2.png", "" },
            { "Dalkia", "", "Chinese Sword", "Dalkia_F.webp", "A7", "04", "Dalkia__2.png", "" },
            { "Dalkia", "", "Chinese Blade", "Dalkia_F.webp", "A9", "04", "Dalkia__2.png", "" },
            { "Dalkia", "", "Grieve Edge", "Dalkia_F.webp", "AB", "04", "Dalkia__2.png", "" },
            { "Dalkia", "", "Staff", "Dalkia_F.webp", "AD", "04", "Dalkia__2.png", "" },
            { "Dalkia", "", "Lance", "Dalkia_F.webp", "AF", "04", "Dalkia__2.png", "" },
            { "Dalkia", "", "Steel Fan", "Dalkia_F.webp", "B1", "04", "Dalkia__2.png", "" },
            { "Dalkia", "", "Sickle", "Dalkia_F.webp", "B3", "04", "Dalkia__2.png", "" },
            { "Dalkia", "", "Dagger", "Dalkia_F.webp", "B5", "04", "Dalkia__2.png", "" },
            { "Dalkia", "", "Iron Sword", "Dalkia_F.webp", "B7", "04", "Dalkia__2.png", "" },
            { "Dalkia", "", "Sword & Shield", "Dalkia_F.webp", "B9", "04", "Dalkia__2.png", "" },
            { "Dalkia", "", "Tambourine", "Dalkia_F.webp", "BB", "04", "Dalkia__2.png", "" },
            { "Dalkia", "", "Nunchaku", "Dalkia_F.webp", "BD", "04", "Dalkia__2.png", "" },
            { "Dalkia", "", "Wave Sword", "Dalkia_F.webp", "BF", "04", "Dalkia__2.png", "" },
            { "Dalkia", "", "Rapier", "Dalkia_F.webp", "C1", "04", "Dalkia__2.png", "" }
        };
        public string[,] BrigandFemaleValues = new string[,]
        {
            { "Brigand", "Female", "Katana & Shuriken", "Brigand_F.webp", "A1", "05", "Brigand__2.png", "" },
            { "Brigand", "", "Kunai", "Brigand_F.webp", "A3", "05", "Brigand__2.png", "" },
            { "Brigand", "", "Katana", "Brigand_F.webp", "A5", "05", "Brigand__2.png", "" },
            { "Brigand", "", "Chinese Sword", "Brigand_F.webp", "A7", "05", "Brigand__2.png", "" },
            { "Brigand", "", "Chinese Blade", "Brigand_F.webp", "A9", "05", "Brigand__2.png", "" },
            { "Brigand", "", "Grieve Edge", "Brigand_F.webp", "AB", "05", "Brigand__2.png", "" },
            { "Brigand", "", "Staff", "Brigand_F.webp", "AD", "05", "Brigand__2.png", "" },
            { "Brigand", "", "Lance", "Brigand_F.webp", "AF", "05", "Brigand__2.png", "" },
            { "Brigand", "", "Steel Fan", "Brigand_F.webp", "B1", "05", "Brigand__2.png", "" },
            { "Brigand", "", "Sickle", "Brigand_F.webp", "B3", "05", "Brigand__2.png", "" },
            { "Brigand", "", "Dagger", "Brigand_F.webp", "B5", "05", "Brigand__2.png", "" },
            { "Brigand", "", "Iron Sword", "Brigand_F.webp", "B7", "05", "Brigand__2.png", "" },
            { "Brigand", "", "Sword & Shield", "Brigand_F.webp", "B9", "05", "Brigand__2.png", "" },
            { "Brigand", "", "Tambourine", "Brigand_F.webp", "BB", "05", "Brigand__2.png", "" },
            { "Brigand", "", "Nunchaku", "Brigand_F.webp", "BD", "05", "Brigand__2.png", "" },
            { "Brigand", "", "Wave Sword", "Brigand_F.webp", "BF", "05", "Brigand__2.png", "" },
            { "Brigand", "", "Rapier", "Brigand_F.webp", "C1", "05", "Brigand__2.png", "" }
        };
        public string[,] MalettaFemaleValues = new string[,]
        {
            { "Maletta", "Female", "Katana & Shuriken", "Maletta_F.webp", "A1", "06", "Maletta__2.png", "" },
            { "Maletta", "", "Kunai", "Maletta_F.webp", "A3", "06", "Maletta__2.png", "" },
            { "Maletta", "", "Katana", "Maletta_F.webp", "A5", "06", "Maletta__2.png", "" },
            { "Maletta", "", "Chinese Sword", "Maletta_F.webp", "A7", "06", "Maletta__2.png", "" },
            { "Maletta", "", "Chinese Blade", "Maletta_F.webp", "A9", "06", "Maletta__2.png", "" },
            { "Maletta", "", "Grieve Edge", "Maletta_F.webp", "AB", "06", "Maletta__2.png", "" },
            { "Maletta", "", "Staff", "Maletta_F.webp", "AD", "06", "Maletta__2.png", "" },
            { "Maletta", "", "Lance", "Maletta_F.webp", "AF", "06", "Maletta__2.png", "" },
            { "Maletta", "", "Steel Fan", "Maletta_F.webp", "B1", "06", "Maletta__2.png", "" },
            { "Maletta", "", "Sickle", "Maletta_F.webp", "B3", "06", "Maletta__2.png", "" },
            { "Maletta", "", "Dagger", "Maletta_F.webp", "B5", "06", "Maletta__2.png", "" },
            { "Maletta", "", "Iron Sword", "Maletta_F.webp", "B7", "06", "Maletta__2.png", "" },
            { "Maletta", "", "Sword & Shield", "Maletta_F.webp", "B9", "06", "Maletta__2.png", "" },
            { "Maletta", "", "Tambourine", "Maletta_F.webp", "BB", "06", "Maletta__2.png", "" },
            { "Maletta", "", "Nunchaku", "Maletta_F.webp", "BD", "06", "Maletta__2.png", "" },
            { "Maletta", "", "Wave Sword", "Maletta_F.webp", "BF", "06", "Maletta__2.png", "" },
            { "Maletta", "", "Rapier", "Maletta_F.webp", "C1", "06", "Maletta__2.png", "" }
        };
        public string[,] RebelFemaleValues = new string[,]
        {
            { "Halteese/Rebel", "Female", "Katana & Shuriken", "Rebel_F.webp", "A1", "07", "Rebel__2.png", "" },
            { "Halteese/Rebel", "", "Kunai", "Rebel_F.webp", "A3", "07", "Rebel__2.png", "" },
            { "Halteese/Rebel", "", "Katana", "Rebel_F.webp", "A5", "07", "Rebel__2.png", "" },
            { "Halteese/Rebel", "", "Chinese Sword", "Rebel_F.webp", "A7", "07", "Rebel__2.png", "" },
            { "Halteese/Rebel", "", "Chinese Blade", "Rebel_F.webp", "A9", "07", "Rebel__2.png", "" },
            { "Halteese/Rebel", "", "Grieve Edge", "Rebel_F.webp", "AB", "07", "Rebel__2.png", "" },
            { "Halteese/Rebel", "", "Staff", "Rebel_F.webp", "AD", "07", "Rebel__2.png", "" },
            { "Halteese/Rebel", "", "Lance", "Rebel_F.webp", "AF", "07", "Rebel__2.png", "" },
            { "Halteese/Rebel", "", "Steel Fan", "Rebel_F.webp", "B1", "07", "Rebel__2.png", "" },
            { "Halteese/Rebel", "", "Sickle", "Rebel_F.webp", "B3", "07", "Rebel__2.png", "" },
            { "Halteese/Rebel", "", "Dagger", "Rebel_F.webp", "B5", "07", "Rebel__2.png", "" },
            { "Halteese/Rebel", "", "Iron Sword", "Rebel_F.webp", "B7", "07", "Rebel__2.png", "" },
            { "Halteese/Rebel", "", "Sword & Shield", "Rebel_F.webp", "B9", "07", "Rebel__2.png", "" },
            { "Halteese/Rebel", "", "Tambourine", "Rebel_F.webp", "BB", "07", "Rebel__2.png", "" },
            { "Halteese/Rebel", "", "Nunchaku", "Rebel_F.webp", "BD", "07", "Rebel__2.png", "" },
            { "Halteese/Rebel", "", "Wave Sword", "Rebel_F.webp", "BF", "07", "Rebel__2.png", "" },
            { "Halteese/Rebel", "", "Rapier", "Rebel_F.webp", "C1", "07", "Rebel__2.png", "" }
        };
        public string[,] TinaValues = new string[,]
        {
            { "Tina", "Ally unit", "Kunai", "Tina.webp", "E9", "02", "Tina__2.png", "74" }
            //{ "Tina", "Costume 1", "Kunai", "Tina.webp", "E9", "02", "Tina__1.png", "" }
        };
        public string[,] AegeValues = new string[,]
        {
            { "Aege", "Costume 1", "Iron Sword", "Aege_1.webp", "E7", "00", "Aege__1.png", "" },
            { "Aege", "Costume 2", "_", "Aege_2.webp", "E7", "01", "Aege__2.png", "" },
            { "Aege", "Costume 3", "_", "Aege_1.webp", "E7", "02", "Aege__3.png", "" },
            { "Aege", "Ally unit", "_", "Aege_1.webp", "E7", "00", "Aege__4.png", "74" }
        };
        public string[,] HealDoValues = new string[,]
        {
            { "HealDo", "Costume 1", "Wave Sword", "Heal-Do_1.webp", "E8", "00", "Heal-Do__1.png", "" },
            { "HealDo", "Costume 2", "_", "Heal-Do_2.webp", "E8", "01", "Heal-Do__2.png", "" },
            { "HealDo", "Costume 3", "_", "Heal-Do_1.webp", "E8", "02", "Heal-Do__3.png", "" },
            { "HealDo", "Ally unit", "_", "Heal-Do_1.webp", "E8", "00", "Heal-Do__4.png", "71" }
        };
        public string[,] EluaValues = new string[,]
        {
            { "Elua", "Costume 1", "Kunai", "Elua_1.webp", "E9", "00", "Elua__1.png", "" },
            { "Elua", "Costume 2", "_", "Elua_2.webp", "E9", "01", "Elua__2.png", "" },
            { "Elua", "Ally unit", "_", "Elua_1.webp", "E9", "00", "Elua__4.png", "75" }
        };
        public string[,] LupiValues = new string[,]
        {
            { "Lupi", "Costume 1", "Lance", "Lupi_1.webp", "EA", "00", "Lupi__1.png", "" },
            { "Lupi", "Costume 2", "_", "Lupi_2.webp", "EA", "01", "Lupi__2.png", "" },
            { "Lupi", "Costume 3", "_", "Lupi_1.webp", "EA", "02", "Lupi__3.png", "" },
            { "Lupi", "Ally unit", "_", "Lupi_3.webp", "EA", "00", "Lupi__4.png", "71" }
        };
        public string[,] RoinValues = new string[,]
        {
            { "Roin", "Costume 1", "Lance", "Roin_1.webp", "EB", "00", "Roin__1.png", "" },
            { "Roin", "Costume 2", "_", "Roin_2.webp", "EB", "01", "Roin__2.png", "" }
        };
        public string[,] KierkessValues = new string[,]
        {
            { "Kierkess", "Costume 1", "Grieve Edge", "Kierkess_1.webp", "EC", "00", "Kierkess__1.png", "" },
            { "Kierkess", "Costume 2", "_", "Kierkess_2.webp", "EC", "01", "Kierkess__2.png", "" }
        };
        public string[,] HyleValues = new string[,]
        {
            { "Hyle", "Costume 1", "Sword & Shield", "Hyle_1.webp", "ED", "00", "Hyle__1.png", "" },
            { "Hyle", "Costume 2", "_", "Hyle_2.webp", "ED", "01", "Hyle__2.png", "" }
        };
        public string[,] MooncalfValues = new string[,]
        {
            { "Mooncalf", "Costume 1", "Chinese Blade", "Mooncalf.webp", "EE", "00", "Mooncalf__1.png", "" }
        };
        public string[,] EndeValues = new string[,]
        {
            { "Ende", "Costume 1", "Katana", "Ende.webp", "EF", "00", "Ende__1.png", "" }
        };
        public string[,] XValues = new string[,]
        {
            { "Yotory", "Costume 1", "Soul of Mitsurugi", "X.png", "EF", "01", "X__1.png", "" }
        };
        public string[,] RandomValues = new string[,]
        {
            { "Random", "Random", "Random", "Random.png", "XX", "XX", "Random.png", "" }
        };
        public string[,] BossValues = new string[,]
        {
            { "Keres", "Supreme Guardian", "Soul Of Raphael",            "Boss.png", "FF", "01", "Keres__X.png", "" },
            { "Taki", "Flaming Swords", "Soul of Cervantes",           "Boss.png", "FF", "02", "Taki__X.png", "" },
            { "Sophitia", "Protective Shield", "Soul of Sophitia",        "Boss.png", "FF", "03", "Sophitia__X.png", "" },
            { "Arthur", "Soul Calibur Apprentice", "Katana",                    "Boss.png", "FF", "04", "Arthur__X.png", "" },
            { "Siegfried", "Soul Edge Monster", "Soul of Siegfried",      "Boss.png", "FF", "05", "Siegfried__X.png", "" },
            { "Seong Mi-Na", "Chinese Sword", "Soul of Seong Mi-Na",  "Boss.png", "FF", "06", "Seong Mi-na__X.png", "" },
            { "Rock", "Spiked Brute", "Soul of Rock",                "Boss.png", "FF", "07", "Rock__X.png", "" }
        };
        public string[,] BossValues2 = new string[,]
        {
            { "Lizardman", "Health Drainer", "Soul Of Lizardman",        "Boss2.png", "FF", "11", "Lizardman__X.png", "" },
            { "Ende", "Overall Master", "Chinese Sword",           "Boss2.png", "FF", "12", "Ende__X.png", "" },
            { "Nightmare", "Heal Expert", "Soul of Nightmare",       "Boss2.png", "FF", "13", "Nightmare__X.png", "" },
            { "Setsuka", "Paralysis Ninjutsu", "Soul of Setsuka",                   "Boss2.png", "FF", "14", "Setsuka__X.png", "" },
            { "Assassin", "Poison Fangs", "Kunai",       "Boss2.png", "FF", "15", "Assassin__X.png", "" },
            { "Berserker", "Guard Breaker", "Lance",    "Boss2.png", "FF", "16", "Berserker__X.png", "" },
            { "Abyss", "Attack and Guard God", "Soul of Abyss",               "Boss2.png", "FF", "17", "Abyss__X.png", "" }
        };

        public string[,] ExtraValues = new string[,]
        {
            { "Unused characters", "Model 1", "Sword & Shield", "Unused__1.png", "E0", "03", "Extra_1.png", "70" },
            { "Unused characters", "Model 2", "Sword & Shield", "Unused__1.png", "E0", "07", "Extra_2.png", "60" },
            { "Unused characters", "Model 3", "Chinese Blade", "Unused__1.png", "E1", "07", "Extra_3.png", "74" }
        };

    }
}
