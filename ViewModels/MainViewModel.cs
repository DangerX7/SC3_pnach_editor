using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SC3_pnach_editor.Services;

namespace SC3_pnach_editor.ViewModels
{
    public class MainViewModel:BaseViewModel
    {
        public MainViewModel()
        {
            SettingsClass.LoadData();
            FolderPath = SettingsClass.codeFolderPath;
            CRC_Name = SettingsClass.PnachName;
            EditorVersion = InfoClass.editorVersion;
            DiscordServer = InfoClass.discordServer;
            
            BonusCharacters = SettingsClass.BonusCharacters;
            UltimateWeapons = SettingsClass.UltimateWeapons;
            GuardianForceP1 = SettingsClass.GuardianForceP1;
            GuardianForceP2 = SettingsClass.GuardianForceP2;
            SlipperyFieldP1 = SettingsClass.SlipperyFieldP1;
            SlipperyFieldP2 = SettingsClass.SlipperyFieldP2;

            GfxCopyFrom = SettingsClass.GfxCopyFrom;
            GfxCopyTo = SettingsClass.GfxCopyTo;
            SurvivalPath = SettingsClass.SurvivalPath;

            UseSetCharacters = SettingsClass.UseSetCharacters;

        }

        private string _folderPath;
        public string FolderPath
        {
            get { return _folderPath; }
            set
            {
                if (_folderPath != value)
                {
                    _folderPath = value;
                    RaisePropertyChanged("FolderPath");
                }
            }
        }

        private string _cRC_Name = "";

        public string CRC_Name
        {
            get { return _cRC_Name; }
            set
            {
                if (_cRC_Name != value)
                {
                    _cRC_Name = value;
                    RaisePropertyChanged("CRC_Name");
                }
            }
        }


        private string _gfxCopyFrom;
        public string GfxCopyFrom
        {
            get { return _gfxCopyFrom; }
            set
            {
                if (_gfxCopyFrom != value)
                {
                    _gfxCopyFrom = value;
                    RaisePropertyChanged("GfxCopyFrom");
                }
            }
        }

        private string _gfxCopyTo;
        public string GfxCopyTo
        {
            get { return _gfxCopyTo; }
            set
            {
                if (_gfxCopyTo != value)
                {
                    _gfxCopyTo = value;
                    RaisePropertyChanged("GfxCopyTo");
                }
            }
        }

        private string _survivalPath;
        public string SurvivalPath
        {
            get { return _survivalPath; }
            set
            {
                if (_survivalPath != value)
                {
                    _survivalPath = value;
                    RaisePropertyChanged("SurvivalPath");
                }
            }
        }


        

        private string _editorVersion;
        public string EditorVersion
        {
            get { return _editorVersion; }
            set
            {
                if (_editorVersion != value)
                {
                    _editorVersion = value;
                    RaisePropertyChanged("EditorVersion");
                }
            }
        }

        private string _discordServer;
        public string DiscordServer
        {
            get { return _discordServer; }
            set
            {
                if (_discordServer != value)
                {
                    _discordServer = value;
                    RaisePropertyChanged("DiscordServer");
                }
            }
        }




        private bool _bonusCharacters;

        public bool BonusCharacters
        {
            get { return _bonusCharacters; }
            set
            {
                if (_bonusCharacters != value)
                {
                    _bonusCharacters = value;
                    SettingsClass.BonusCharacters = _bonusCharacters;
                    RaisePropertyChanged("BonusCharacters");
                }
            }
        }



        private bool _ultimateWeapons;

        public bool UltimateWeapons
        {
            get { return _ultimateWeapons; }
            set
            {
                if (_ultimateWeapons != value)
                {
                    _ultimateWeapons = value;
                    SettingsClass.UltimateWeapons = _ultimateWeapons;
                    RaisePropertyChanged("UltimateWeapons");
                }
            }
        }

        private bool _useSetCharacters;

        public bool UseSetCharacters
        {
            get { return _useSetCharacters; }
            set
            {
                if (_useSetCharacters != value)
                {
                    _useSetCharacters = value;
                    SettingsClass.UseSetCharacters = _useSetCharacters;
                    RaisePropertyChanged("UseSetCharacters");
                }
            }
        }

        private int _guardianForceP1;

        public int GuardianForceP1
        {
            get { return _guardianForceP1; }
            set
            {
                if (_guardianForceP1 != value)
                {
                    _guardianForceP1 = value;
                    SettingsClass.GuardianForceP1 = _guardianForceP1;
                    RaisePropertyChanged("GuardianForceP1");
                }
            }
        }

        private int _guardianForceP2;

        public int GuardianForceP2
        {
            get { return _guardianForceP2; }
            set
            {
                if (_guardianForceP2 != value)
                {
                    _guardianForceP2 = value;
                    SettingsClass.GuardianForceP2 = _guardianForceP2;
                    RaisePropertyChanged("GuardianForceP2");
                }
            }
        }


        private string _weaponEffectP1 = "";

        public string WeaponEffectP1
        {
            get { return _weaponEffectP1; }
            set
            {
                if (_weaponEffectP1 != value)
                {
                    _weaponEffectP1 = value;
                    RaisePropertyChanged("WeaponEffectP1");
                }
            }
        }

        private string _weaponSpecialPowerP1 = "";

        public string WeaponSpecialPowerP1
        {
            get { return _weaponSpecialPowerP1; }
            set
            {
                if (_weaponSpecialPowerP1 != value)
                {
                    _weaponSpecialPowerP1 = value;
                    RaisePropertyChanged("WeaponSpecialPowerP1");
                }
            }
        }

        private string _weaponEffectP2 = "";

        public string WeaponEffectP2
        {
            get { return _weaponEffectP2; }
            set
            {
                if (_weaponEffectP2 != value)
                {
                    _weaponEffectP2 = value;
                    RaisePropertyChanged("WeaponEffectP2");
                }
            }
        }

        private string _weaponSpecialPowerP2 = "";

        public string WeaponSpecialPowerP2
        {
            get { return _weaponSpecialPowerP2; }
            set
            {
                if (_weaponSpecialPowerP2 != value)
                {
                    _weaponSpecialPowerP2 = value;
                    RaisePropertyChanged("WeaponSpecialPowerP2");
                }
            }
        }



        public List<string> WeaponEffectCombo = new List<string>
        {
            "Original",
            "Custom",
            "Soul Edge Complete",
            "Soul Calibur Complete",
            "The Ancient True Power",
            "Olympus Punisher Power",
            "One hit kill [OP]"
        };

        public List<string> WeaponSpecialPowerCombo = new List<string>
        {
            "None",
            "-All Guard Break",
            "-All Unblockable",
            "-Paralysis",
            "-Minus Guard",
            "-Poison",
            "-Super Poison",
            "-Mega Poison",
            "+Cure",
            "+Super Cure",
            "+Mega Cure",
            "-Defense Down",
            "+Defense Up",
            "+Super Defense",
            "+Reserve Offense Up",
            "-Glue",
            "-Separate",
            "-Ice",
            "-Whirlwind",
            "-Aerial Wind",
            "-Smash",
            "-Soul Smash",
            "-Down Lose"
        };

        public List<string> ArmorCombo = new List<string>
        {
            "Default",
            "Frail",
            "No Armor",
            "Soul Armor (Only P2 in mission)",
            "Guardian Force"
        };




        private bool _slipperyFieldP1;

        public bool SlipperyFieldP1
        {
            get { return _slipperyFieldP1; }
            set
            {
                if (_slipperyFieldP1 != value)
                {
                    _slipperyFieldP1 = value;
                    SettingsClass.SlipperyFieldP1 = _slipperyFieldP1;
                    RaisePropertyChanged("SlipperyFieldP1");
                }
            }
        }

        private bool _slipperyFieldP2;

        public bool SlipperyFieldP2
        {
            get { return _slipperyFieldP2; }
            set
            {
                if (_slipperyFieldP2 != value)
                {
                    _slipperyFieldP2 = value;
                    SettingsClass.SlipperyFieldP2 = _slipperyFieldP2;
                    RaisePropertyChanged("SlipperyFieldP2");
                }
            }
        }



        public List<string> ChroniclesOfTheSwordCharacters = new List<string>
        {
            "None",
            "Jinkai",
            "Kagami",
            "Shiun",
            "Shiina",
            "Chikage",
            "Konomi",
            "Cassius",
            "Saizou",
            "Ryouga",
            "Kimika",
            "Syunna",
            "Tomoe",
            "Meiga",
            "Alastor",
            "Shizuma",
            "Azumi",
            "Yukina",
            "Ouka",
            "Xiaoxin",
            "Oruks",
            "Agareth",
            "Jyuri",
            "Shuyu",
            "Mingyue",
            "Veles",
            "Aether",
            "Ixion",
            "Siulan",
            "Fenglin",
            "Philine",
            "Ignis",
            "Notus",
            "Azrael",
            "Mireille",
            "Aglaia",
            "Kanon",
            "Jyurai",
            "Kureha",
            "Xunyu",
            "Fengyu",
            "Fenglei",
            "Minglian",
            "Noel",
            "Rudiger",
            "Aeneas",
            "Annaretta",
            "Iris",
            "Brunhild",
            "Asrafil",
            "Zifeng",
            "Aeolos",
            "Amrita",
            "Azalea",
            "Yueliang",
            "Kanade",
            "Domenthi",
            "Marid",
            "Ambrose",
            "Ailian",
            "Aika",
            "Loki",
            "Celestis",
            "Beleth",
            "Karen",
            "Lilan",
            "Abigail",
            "Balduin",
            "Aloces",
            "Areon",
            "Juno",
            "Eurydice",
            "Ishtar",
            "Rufus",
            "Raguel",
            "Feofan",
            "Eunice",
            "Acacia",
            "Hilda",
            "Iblis",
            "Alberic",
            "Leshy",
            "Muriel",
            "Wenli",
            "Irene",
            "Yufeng",
            "Yakumo",
            "Dufeng",
            "Mayura",
            "Meilan",
            "Rhea",
            "Halphas",
            "Gorus",
            "Ilyusha",
            "Edith",
            "Riese",
            "Agave",
            "Haystir",
            "Leraje",
            "Ratziel",
            "Katina",
            "Eris",
            "Sizuku",
            "Aege_1",
            "Aege_2",
            "Heal-Do_1",
            "Heal-Do_2",
            "Elua_1",
            "Elua_2",
            "Lupi_1",
            "Lupi_2",
            "Roin_1",
            "Roin_2",
            "Kierkess_1",
            "Kierkess_2",
            "Hyle_1",
            "Hyle_2",
            "Mooncalf",
            "Ende",
            "Grandall_M",
            "Grandall_F",
            "Dalkia_M",
            "Dalkia_F",
            "Brigand_M",
            "Brigand_F",
            "Maletta_M",
            "Maletta_F",
            "Rebel_M",
            "Rebel_F",
        };


        public List<string> Discipline = new List<string>
        {
            "Katana & Shuriken",
            "Kunai",
            "Katana",
            "Chinese Sword",
            "Chinese Blade",
            "Grieve Edge",
            "Staff",
            "Lance",
            "Steel Fan",
            "Sickle",
            "Dagger",
            "Iron Sword",
            "Sword & Shield",
            "Tambourine",
            "Nunchaku",
            "Wave Sword",
            "Rapier",
        };

        private string _charPreview;
        public string CharPreview
        {
            get { return _charPreview; }
            set
            {
                if (_charPreview != value)
                {
                    _charPreview = value;
                    RaisePropertyChanged("CharPreview");
                }
            }
        }

        

        public List<string> PlayerControlCombo = new List<string>
        {
            "No Change",
            "Player 1",
            "Easy",
            "Normal",
            "Hard",
            "Very Hard",
            "Ultra Hard",
            "Extremely Hard"
        };

        public List<string> OpponentControlCombo = new List<string>
        {
            "No Change",
            "Player 2",
            "Easy",
            "Normal",
            "Hard",
            "Very Hard",
            "Ultra Hard",
            "Extremely Hard"
        };
    }


}
