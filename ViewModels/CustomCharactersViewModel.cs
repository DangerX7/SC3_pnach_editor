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
            "BloodValues",
            "SoruValues",
            "SoniaValues",
            "KOSMOSValues",
            "TifaValues"
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

        public string[,] YuilinValues = new string[,]
        {
            { "Yuilin", "Costume 1", "Steel Fan", "char_01.png", "01", "", "char__01.png", "" }
        };

        public string[,] LucaValues = new string[,]
        {
            { "Luca", "Costume 1", "Dagger", "char_02.png", "02", "", "char__02.png", "" }
        };

        public string[,] LupiValues = new string[,]
        {
            { "Lupi", "Costume 1", "Lance", "char_03.png", "03", "", "char__03.png", "" }
        };

        public string[,] NinaValues = new string[,]
        {
            { "Nina", "Costume 1", "Soul of Taki", "char_04.png", "04", "", "char__04.png", "" }
        };

        public string[,] ScorpionValues = new string[,]
        {
            { "Scorpion", "Costume 1", "Katana & Shuriken", "char_05.png", "05", "", "char__05.png", "" }
        };

        public string[,] BloodValues = new string[,]
        {
            { "Blood", "Costume 1", "Soul of Siegfried", "char_06.png", "06", "", "char__06.png", "" }
        };

        public string[,] SoruValues = new string[,]
        {
            { "Soru", "Costume 1", "Soul of Nightmare", "char_07.png", "07", "", "char__07.png", "" }
        };

        public string[,] SoniaValues = new string[,]
        {
            { "Sonia", "Costume 1", "Sword & Shield", "char_08.png", "08", "", "char__08.png", "" }
        };

        public string[,] KOSMOSValues = new string[,]
        {
            { "KOS-MOS", "Costume 1", "Grieve Edge", "char_09.png", "09", "", "char__09.png", "" }
        };

        public string[,] TifaValues = new string[,]
        {
            { "Tifa", "Costume 1", "Grieve Edge", "char_10.png", "10", "", "char__10.png", "" }
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
    }
}
