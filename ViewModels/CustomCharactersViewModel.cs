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
    public class CustomCharactersViewModel : BaseViewModel
    {


        public CustomCharactersViewModel()
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

        public static List<string> CharList = new List<string>
        {
            "YuilinValues",
            "LucaValues",
            "LupiValues",
            "NinaValues",
            "ScorpionValues",
            "CelestaValues",
            "PoisonValues",
            "SoniaValues",
            "KOSMOSValues",
            "TifaValues",

            "BlackKnightValues",
            "EurydiceValues",
            "TsangValues",
            "SheenaValues",
            "DemetriusValues",
            "JaniceValues",
            "KitaValues",
            "EileenValues",
            "OrikValues",
            "RosaValues",

            "SoruValues",
            "CecilValues",
            "StellaValues",
            "JilliannaValues",
            "BloodValues",
            "DaelkereValues",
            "IrolValues",
            "RoyValues",
            "KokuenraValues",
            "SpicaValues",

            "DracoValues",
            "UmiValues",
            "EdgeMasterValues",
            "MournfaerValues",
            "VelikastrousValues",
            "KaosValues",
            "AkaraValues",
            "CitrineValues",
            "MariseValues",
            "GrimReaperValues",

            "LeonUzumakiValues",
            "CherylValues",
            "TheoHValues",
            "ChimeraValues",
            "FitzgeraldValues",
            "RoanCascadeValues",
            "SorenValues",
            "BasiliskValues",
            "ThymeValues",
            "TheCalamityValues",

            "ValcuaValues",
            "AversaValues",
            "EdgarValues",
            "BlancheValues",
            "HelenaValues",
            "NicholasValues",
            "GailValues",
            "KatrinaValues",
            "SaellumvValues",
            "KronneValues",

            "AkashanValues",
            "ErnestValues",
            "NokklingValues",
            "RaitenValues",
            "AdamValues",
            "AlexanderValues",
            "KhanateValues",
            "SindrielValues",
            "TristanValues",
            "LongcastleValues"

        };

        public string CharListItem(int index)
        {
            if (index < 1 || index > CharList.Count)
                return "Invalid index";
            return CharList[index - 1];
        }

        public string[,] Empty = new string[,]
        {
            { "_", "_"},
            { "_", "_"}
        };

        //0
        public string[,] YuilinValues = new string[,]
        {
            { "Yuilin", "Costume 1", "Steel Fan", "char_01.png", "01", "", "char__01.png", "", "No" }
        };

        public string[,] LucaValues = new string[,]
        {
            { "Luca", "Costume 1", "Dagger", "char_02.png", "02", "", "char__02.png", "", "No" }
        };

        public string[,] LupiValues = new string[,]
        {
            { "Lupi", "Costume 1", "Lance", "char_03.png", "03", "", "char__03.png", "", "No" }
        };

        public string[,] NinaValues = new string[,]
        {
            { "Nina", "Costume 1", "Soul of Taki", "char_04.png", "04", "", "char__04.png", "", "No" },
            { "Nina 2", "Costume 2", "Soul of Taki", "char_04.png", "04B", "", "char__04B.png", "", "Yes" }
        };

        public string[,] ScorpionValues = new string[,]
        {
            { "Scorpion", "Costume 1", "Katana & Shuriken", "char_05.png", "05", "", "char__05.png", "", "No" }
        };

        public string[,] CelestaValues = new string[,]
        {
            { "Celesta", "Costume 1", "Katana", "char_06.png", "06", "", "char__06.png", "", "No" }
        };

        public string[,] PoisonValues = new string[,]
        {
            { "Poison", "Costume 1", "Soul of Tira", "char_07.png", "07", "", "char__07.png", "", "No" }
        };

        public string[,] SoniaValues = new string[,]
        {
            { "Sonia", "Costume 1", "Sword & Shield", "char_08.png", "08", "", "char__08.png", "", "No" }
        };

        public string[,] KOSMOSValues = new string[,]
        {
            { "KOS-MOS", "Costume 1", "Grieve Edge", "char_09.png", "09", "", "char__09.png", "", "No" }
        };

        public string[,] TifaValues = new string[,]
        {
            { "Tifa", "Costume 1", "Grieve Edge", "char_10.png", "10", "", "char__10.png", "", "No" }
        };

        //1
        public string[,] BlackKnightValues = new string[,]
        {
            { "Black Knight", "Costume 1", "Iron Sword", "char_11.png", "11", "", "char__11.png", "", "No" }
        };

        public string[,] EurydiceValues = new string[,]
        {
            { "Eurydice", "Costume 1", "Iron Sword", "char_12.png", "12", "", "char__12.png", "", "No" }
        };

        public string[,] TsangValues = new string[,]
        {
            { "Tsang", "Costume 1", "Chinese Sword", "char_13.png", "13", "", "char__13.png", "", "No" }
        };

        public string[,] SheenaValues = new string[,]
        {
            { "Sheena", "Costume 1", "Soul of Seong Mi-na", "char_14.png", "14", "", "char__14.png", "", "No" }
        };

        public string[,] DemetriusValues = new string[,]
        {
            { "Demetrius", "Costume 1", "Soul of Zasalamel", "char_15.png", "15", "", "char__15.png", "", "No" }
        };

        public string[,] JaniceValues = new string[,]
        {
            { "Janice", "Costume 1", "Tambourine", "char_16.png", "16", "", "char__16.png", "", "No" }
        };

        public string[,] KitaValues = new string[,]
        {
            { "Kita", "Costume 1", "Soul of Mitsurugi", "char_17.png", "17", "", "char__17.png", "", "No" }
        };

        public string[,] EileenValues = new string[,]
        {
            { "Eileen", "Costume 1", "Soul of Tira", "char_18.png", "18", "", "char__18.png", "", "No" }
        };

        public string[,] OrikValues = new string[,]
        {
            { "Orik", "Costume 1", "Soul of Nightmare", "char_19.png", "19", "", "char__19.png", "", "No" }
        };

        public string[,] RosaValues = new string[,]
        {
            { "Rosa", "Costume 1", "Sword & Shield", "char_20.png", "20", "", "char__20.png", "", "No" }
        };

        //2
        public string[,] SoruValues = new string[,]
        {
            { "Soru", "Costume 1", "Soul of Siegfried", "char_21.png", "21", "", "char__21.png", "", "No" },
            { "Soru", "Costume 2", "Iron Sword", "char_21.png", "21B", "", "char__21B.png", "", "No" }
        };

        public string[,] CecilValues = new string[,]
        {
            { "Cecil", "Costume 1", "Soul of Zasalamel", "char_22.png", "22", "", "char__22.png", "", "No" }
        };

        public string[,] StellaValues = new string[,]
        {
            { "Stella", "Costume 1", "Soul of Xianghua", "char_23.png", "23", "", "char__23.png", "", "No" }
        };

        public string[,] JilliannaValues = new string[,]
        {
            { "Jillianna", "Costume 1", "Soul of Mitsurugi", "char_24.png", "24", "", "char__24.png", "", "No" },
            { "Jillianna", "Costume 2", "Soul of Ivy", "char_24.png", "24B", "", "char__24B.png", "", "No" }
        };

        public string[,] BloodValues = new string[,]
        {
            { "Blood", "Costume 1", "Soul of Raphael", "char_25.png", "25", "", "char__25.png", "", "No" }
        };

        public string[,] DaelkereValues = new string[,]
        {
            { "Daelkere", "Costume 1", "Soul of Siegfried", "char_26.png", "26", "", "char__26.png", "", "No" }
        };

        public string[,] IrolValues = new string[,]
        {
            { "Irol", "Costume 1", "Soul of Nightmare", "char_27.png", "27", "", "char__27.png", "", "Yes" }
        };

        public string[,] RoyValues = new string[,]
        {
            { "Roy", "Costume 1", "Soul of Raphael", "char_28.png", "28", "", "char__28.png", "", "No" }
        };

        public string[,] KokuenraValues = new string[,]
        {
            { "Kokuenra", "Costume 1", "Katana", "char_29.png", "29", "", "char__29.png", "", "No" }
        };

        public string[,] SpicaValues = new string[,]
        {
            { "Spica", "Costume 1", "Rapier", "char_30.png", "30", "", "char__30.png", "", "No" }
        };

        //3
        public string[,] DracoValues = new string[,]
        {
            { "Draco", "Costume 1", "Soul of Nightmare", "char_31.png", "31", "", "char__31.png", "", "No" }
        };

        public string[,] UmiValues = new string[,]
        {
            { "Umi", "Costume 1", "Rapier", "char_32.png", "32", "", "char__32.png", "", "No" }
        };

        public string[,] EdgeMasterValues = new string[,]
        {
            { "Edge Master", "Costume 1", "Any", "char_33.png", "33", "", "char__33.png", "", "No" }
        };

        public string[,] MournfaerValues = new string[,]
        {
            { "Morne faer 1", "Costume 1", "Soul of Siegfried", "char_34.png", "34", "", "char__34.png", "", "Yes" },
            { "Morne faer 2", "Costume 2", "Soul of Siegfried", "char_34.png", "34B", "", "char__34B.png", "", "Yes" }
        };

        public string[,] VelikastrousValues = new string[,]
        {
            { "Velikastrous", "Costume 1", "Soul of Cervantes", "char_35.png", "35", "", "char__35.png", "", "No" }
        };

        public string[,] KaosValues = new string[,]
        {
            { "Kaos", "Costume 1", "Lance", "char_36.png", "36", "", "char__36.png", "", "No" }
        };

        public string[,] AkaraValues = new string[,]
        {
            { "Akara", "Costume 1", "Steel Fan", "char_37.png", "37", "", "char__37.png", "", "No" }
        };

        public string[,] CitrineValues = new string[,]
        {
            { "Citrine", "Costume 1", "Sword & Shield", "char_38.png", "38", "", "char__38.png", "", "No" }
        };

        public string[,] MariseValues = new string[,]
        {
            { "Marise", "Costume 1", "Soul of Raphael", "char_39.png", "39", "", "char__39.png", "", "No" }
        };

        public string[,] GrimReaperValues = new string[,]
        {
            { "Grim Reaper", "Costume 1", "Soul of Zasalamel", "char_40.png", "40", "", "char__40.png", "", "No" }
        };

        //4
        public string[,] LeonUzumakiValues = new string[,]
        {
            { "Leon Uzumaki", "Costume 1", "Soul of Siegfried", "char_41.png", "41", "", "char__41.png", "", "Yes" }
        };

        public string[,] CherylValues = new string[,]
        {
            { "Cheryl Estheim", "Costume 1", "Soul of Ivy", "char_42.png", "42", "", "char__42.png", "", "No" }
        };

        public string[,] TheoHValues = new string[,]
        {
            { "Theo H.", "Costume 1", "Kunai", "char_43.png", "43", "", "char__43.png", "", "No" }
        };

        public string[,] ChimeraValues = new string[,]
        {
            { "Chimera", "Costume 1", "Nunchaku", "char_44.png", "44", "", "char__44.png", "", "No" }
        };

        public string[,] FitzgeraldValues = new string[,]
        {
            { "Fitzgerald", "Costume 1", "Soul of Cassandra", "char_45.png", "45", "", "char__45.png", "", "Yes" }
        };

        public string[,] RoanCascadeValues = new string[,]
        {
            { "Roan Cascade", "Costume 1", "Sword & Shield", "char_46.png", "46", "", "char__46.png", "", "No" }
        };

        public string[,] SorenValues = new string[,]
        {
            { "Soren", "Costume 1", "Chinese Sword", "char_47.png", "47", "", "char__47.png", "", "No" }
        };

        public string[,] BasiliskValues = new string[,]
        {
            { "Basilisk", "Costume 1", "Katana", "char_48.png", "48", "", "char__48.png", "", "No" }
        };

        public string[,] ThymeValues = new string[,]
        {
            { "Thyme", "Costume 1", "Soul of Ivy", "char_49.png", "49", "", "char__49.png", "", "Yes" }
        };

        public string[,] TheCalamityValues = new string[,]
        {
            { "The Calamity", "Costume 1", "Soul of Nightmare", "char_50.png", "50", "", "char__50.png", "", "No" }
        };

        //5
        public string[,] ValcuaValues = new string[,]
        {
            { "Valcua", "Costume 1", "Soul of Siegfried", "char_51.png", "51", "", "char__51.png", "", "Yes" },
            { "Valcua", "Costume 2", "Iron Sword", "char_51.png", "51B", "", "char__51B.png", "", "No" }
        };

        public string[,] AversaValues = new string[,]
        {
            { "Aversa", "Costume 1", "Soul of Zasalamel", "char_52.png", "52", "", "char__52.png", "", "No" }
        };

        public string[,] EdgarValues = new string[,]
        {
            { "Edgar", "Costume 1", "Soul of Mitsurugi", "char_53.png", "53", "", "char__53.png", "", "No" }
        };

        public string[,] BlancheValues = new string[,]
        {
            { "Blanche", "Costume 1", "Soul of Xianghua", "char_54.png", "54", "", "char__54.png", "", "No" }
        };

        public string[,] HelenaValues = new string[,]
        {
            { "Helena", "Costume 1", "Soul of Setsuka", "char_55.png", "55", "", "char__55.png", "", "No" }
        };

        public string[,] NicholasValues = new string[,]
        {
            { "Nicholas", "Costume 1", "Katana & Shuriken", "char_56.png", "56", "", "char__56.png", "", "No" }
        };

        public string[,] GailValues = new string[,]
        {
            { "Gail", "Costume 1", "Soul of Nightmare", "char_57.png", "57", "", "char__57.png", "", "Yes" }
        };

        public string[,] KatrinaValues = new string[,]
        {
            { "Katrina", "Costume 1", "Chinese Sword", "char_58.png", "58", "", "char__58.png", "", "No" }
        };

        public string[,] SaellumvValues = new string[,]
        {
            { "Saellum V", "Costume 1", "Soul of Siegfried", "char_59.png", "59", "", "char__59.png", "", "No" }
        };

        public string[,] KronneValues = new string[,]
        {
            { "Kronne", "Costume 1", "Iron Sword", "char_60.png", "60", "", "char__60.png", "", "No" }
        };

        //6
        public string[,] AkashanValues = new string[,]
        {
            { "AkashanValues", "Costume 1", "Soul of Yun-Seong", "char_61.png", "61", "", "char__61.png", "", "No" }
        };

        public string[,] ErnestValues = new string[,]
        {
            { "Ernest", "Costume 1", "Wave Sword", "char_62.png", "62", "", "char__62.png", "", "No" }
        };

        public string[,] NokklingValues = new string[,]
        {
            { "Nokkling", "Costume 1", "Wave Sword", "char_63.png", "63", "", "char__63.png", "", "No" }
        };

        public string[,] RaitenValues = new string[,]
        {
            { "Raiten", "Costume 1", "Katana & Shuriken", "char_64.png", "64", "", "char__64.png", "", "Yes" }
        };

        public string[,] AdamValues = new string[,]
        {
            { "Adam", "Costume 1", "Iron Sword", "char_65.png", "65", "", "char__65.png", "", "No" }
        };

        public string[,] AlexanderValues = new string[,]
        {
            { "Alexander", "Costume 1", "Lance", "char_66.png", "66", "", "char__66.png", "", "No" }
        };

        public string[,] KhanateValues = new string[,]
        {
            { "Khanate", "Costume 1", "Iron Sword", "char_67.png", "67", "", "char__67.png", "", "Yes" }
        };

        public string[,] SindrielValues = new string[,]
        {
            { "Sindriel", "Costume 1", "Katana", "char_68.png", "68", "", "char__68.png", "", "No" }
        };

        public string[,] TristanValues = new string[,]
        {
            { "Tristan", "Costume 1", "Soul of Siegfried", "char_69.png", "69", "", "char__69.png", "", "No" }
        };

        public string[,] LongcastleValues = new string[,]
        {
            { "Longcastle", "Costume 1", "Soul of Raphael", "char_70.png", "70", "", "char__70.png", "", "No" }
        };


        public string[,] Slot1Values = new string[,]
        {
            { "", "", "", "Slot1.png", "", "", "", "" }
        };

        public string[,] Slot2Values = new string[,]
        {
            { "", "", "", "Slot2.png", "", "", "", "" }
        };

        public string[,] Slot3Values = new string[,]
        {
            { "", "", "", "Slot3.png", "", "", "", "" }
        };

        public string[,] Slot4Values = new string[,]
        {
            { "", "", "", "Slot4.png", "", "", "", "" }
        };

        public string[,] Slot5Values = new string[,]
        {
            { "", "", "", "Slot5.png", "", "", "", "" }
        };

        public string[,] Slot6Values = new string[,]
        {
            { "", "", "", "Slot6.png", "", "", "", "" }
        };

        public string[,] Slot7Values = new string[,]
        {
            { "", "", "", "Slot7.png", "", "", "", "" }
        };

        public string[,] Slot8Values = new string[,]
        {
            { "", "", "", "Slot8.png", "", "", "", "" }
        };

        public string[,] Slot9Values = new string[,]
        {
            { "", "", "", "Slot9.png", "", "", "", "" }
        };

        public string[,] Slot10Values = new string[,]
        {
            { "", "", "", "Slot10.png", "", "", "", "" }
        };

        public string[,] Slot11Values = new string[,]
        {
            { "", "", "", "Slot1.png", "", "", "", "" }
        };

        public string[,] Slot12Values = new string[,]
        {
            { "", "", "", "Slot2.png", "", "", "", "" }
        };

        public string[,] Slot13Values = new string[,]
        {
            { "", "", "", "Slot3.png", "", "", "", "" }
        };

        public string[,] Slot14Values = new string[,]
        {
            { "", "", "", "Slot4.png", "", "", "", "" }
        };

        public string[,] Slot15Values = new string[,]
        {
            { "", "", "", "Slot5.png", "", "", "", "" }
        };

        public string[,] Slot16Values = new string[,]
        {
            { "", "", "", "Slot6.png", "", "", "", "" }
        };

        public string[,] Slot17Values = new string[,]
        {
            { "", "", "", "Slot7.png", "", "", "", "" }
        };

        public string[,] Slot18Values = new string[,]
        {
            { "", "", "", "Slot8.png", "", "", "", "" }
        };

        public string[,] Slot19Values = new string[,]
        {
            { "", "", "", "Slot9.png", "", "", "", "" }
        };

        public string[,] Slot20Values = new string[,]
        {
            { "", "", "", "Slot10.png", "", "", "", "" }
        };

        public List<string> MenuOptions { get; } = new List<string>
        {
            "Memory Card 1",
            "Memory Card 2",
            "Character Creation Menu",
            "Cots Mode"
        };
    }
}
