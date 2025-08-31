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
using System.Windows.Media.TextFormatting;
using System.Windows.Shapes;

namespace SC3_pnach_editor.ViewModels
{
    public class SpecialEffectsViewModel : BaseViewModel
    {


        public SpecialEffectsViewModel()
        {
            SettingsClass.LoadData();

            AllGuardBreakP1        = SettingsClass.AllGuardBreakP1      ; 
            AllGuardBreakP2        = SettingsClass.AllGuardBreakP2      ;
            AllUnblockableP1       = SettingsClass.AllUnblockableP1     ;
            AllUnblockableP2       = SettingsClass.AllUnblockableP2     ;
            ParalysisP1            = SettingsClass.ParalysisP1          ;
            ParalysisP2            = SettingsClass.ParalysisP2          ;
            DownLoseP1             = SettingsClass.DownLoseP1           ;
            DownLoseP2             = SettingsClass.DownLoseP2           ;
            MinusGuardP1           = SettingsClass.MinusGuardP1         ;
            MinusGuardP2           = SettingsClass.MinusGuardP2         ;
            PoisonP1               = SettingsClass.PoisonP1             ;
            PoisonP2               = SettingsClass.PoisonP2             ;
            SuperPoisonP1          = SettingsClass.SuperPoisonP1        ;
            SuperPoisonP2          = SettingsClass.SuperPoisonP2        ;
            MegaPoisonP1           = SettingsClass.MegaPoisonP1         ;
            MegaPoisonP2           = SettingsClass.MegaPoisonP2         ;
            CureP1                 = SettingsClass.CureP1               ;
            CureP2                 = SettingsClass.CureP2               ;
            SuperCureP1            = SettingsClass.SuperCureP1          ;
            SuperCureP2            = SettingsClass.SuperCureP2          ;
            MegaCureP1             = SettingsClass.MegaCureP1           ;
            MegaCureP2             = SettingsClass.MegaCureP2           ;
            DefenseDownP1          = SettingsClass.DefenseDownP1        ;
            DefenseDownP2          = SettingsClass.DefenseDownP2        ;
            DefenseUpP1            = SettingsClass.DefenseUpP1          ;
            DefenseUpP2            = SettingsClass.DefenseUpP2          ;
            SuperDefenseP1         = SettingsClass.SuperDefenseP1       ;
            SuperDefenseP2         = SettingsClass.SuperDefenseP2       ;
            GlueP1                 = SettingsClass.GlueP1               ;
            GlueP2                 = SettingsClass.GlueP2               ;
            SeparateP1             = SettingsClass.SeparateP1           ;
            SeparateP2             = SettingsClass.SeparateP2           ;
            IceP1                  = SettingsClass.IceP1                ;
            IceP2                  = SettingsClass.IceP2                ;
            WhirlwindP1            = SettingsClass.WhirlwindP1          ;
            WhirlwindP2            = SettingsClass.WhirlwindP2          ;
            AerialWindP1           = SettingsClass.AerialWindP1         ;
            AerialWindP2           = SettingsClass.AerialWindP2         ;
            SmashP1                = SettingsClass.SmashP1              ;
            SmashP2                = SettingsClass.SmashP2              ;
            SoulSmashP1            = SettingsClass.SoulSmashP1          ;
            SoulSmashP2            = SettingsClass.SoulSmashP2          ;
            ReserveOffenseUpP1     = SettingsClass.ReserveOffenseUpP1   ;
            ReserveOffenseUpP2     = SettingsClass.ReserveOffenseUpP2;
        }


        private bool _allGuardBreakP1;

        public bool AllGuardBreakP1
        {
            get { return _allGuardBreakP1; }
            set
            {
                if (_allGuardBreakP1 != value)
                {
                    _allGuardBreakP1 = value;
                    SettingsClass.AllGuardBreakP1 = _allGuardBreakP1;
                    RaisePropertyChanged("AllGuardBreakP1");
                }
            }
        }

        private bool _allGuardBreakP2;

        public bool AllGuardBreakP2
        {
            get { return _allGuardBreakP2; }
            set
            {
                if (_allGuardBreakP2 != value)
                {
                    _allGuardBreakP2 = value;
                    SettingsClass.AllGuardBreakP2 = _allGuardBreakP2;
                    RaisePropertyChanged("AllGuardBreakP2");
                }
            }
        }

        private bool _allUnblockableP1;

        public bool AllUnblockableP1
        {
            get { return _allUnblockableP1; }
            set
            {
                if (_allUnblockableP1 != value)
                {
                    _allUnblockableP1 = value;
                    SettingsClass.AllUnblockableP1 = _allUnblockableP1;
                    RaisePropertyChanged("AllUnblockableP1");
                }
            }
        }

        private bool _allUnblockableP2;

        public bool AllUnblockableP2
        {
            get { return _allUnblockableP2; }
            set
            {
                if (_allUnblockableP2 != value)
                {
                    _allUnblockableP2 = value;
                    SettingsClass.AllUnblockableP2 = _allUnblockableP2;
                    RaisePropertyChanged("AllUnblockableP2");
                }
            }
        }

        private bool _paralysisP1;

        public bool ParalysisP1
        {
            get { return _paralysisP1; }
            set
            {
                if (_paralysisP1 != value)
                {
                    _paralysisP1 = value;
                    SettingsClass.ParalysisP1 = _paralysisP1;
                    RaisePropertyChanged("ParalysisP1");
                }
            }
        }

        private bool _paralysisP2;

        public bool ParalysisP2
        {
            get { return _paralysisP2; }
            set
            {
                if (_paralysisP2 != value)
                {
                    _paralysisP2 = value;
                    SettingsClass.ParalysisP2 = _paralysisP2;
                    RaisePropertyChanged("ParalysisP2");
                }
            }
        }

        private bool _downLoseP1;

        public bool DownLoseP1
        {
            get { return _downLoseP1; }
            set
            {
                if (_downLoseP1 != value)
                {
                    _downLoseP1 = value;
                    SettingsClass.DownLoseP1 = _downLoseP1;
                    RaisePropertyChanged("DownLoseP1");
                }
            }
        }

        private bool _downLoseP2;

        public bool DownLoseP2
        {
            get { return _downLoseP2; }
            set
            {
                if (_downLoseP2 != value)
                {
                    _downLoseP2 = value;
                    SettingsClass.DownLoseP2 = _downLoseP2;
                    RaisePropertyChanged("DownLoseP2");
                }
            }
        }

        private bool _minusGuardP1;

        public bool MinusGuardP1
        {
            get { return _minusGuardP1; }
            set
            {
                if (_minusGuardP1 != value)
                {
                    _minusGuardP1 = value;
                    SettingsClass.MinusGuardP1 = _minusGuardP1;
                    RaisePropertyChanged("MinusGuardP1");
                }
            }
        }

        private bool _minusGuardP2;

        public bool MinusGuardP2
        {
            get { return _minusGuardP2; }
            set
            {
                if (_minusGuardP2 != value)
                {
                    _minusGuardP2 = value;
                    SettingsClass.MinusGuardP2 = _minusGuardP2;
                    RaisePropertyChanged("MinusGuardP2");
                }
            }
        }

        private bool _poisonP1;

        public bool PoisonP1
        {
            get { return _poisonP1; }
            set
            {
                if (_poisonP1 != value)
                {
                    _poisonP1 = value;
                    SettingsClass.PoisonP1 = _poisonP1;
                    RaisePropertyChanged("PoisonP1");
                }
            }
        }

        private bool _poisonP2;

        public bool PoisonP2
        {
            get { return _poisonP2; }
            set
            {
                if (_poisonP2 != value)
                {
                    _poisonP2 = value;
                    SettingsClass.PoisonP2 = _poisonP2;
                    RaisePropertyChanged("PoisonP2");
                }
            }
        }

        private bool _superPoisonP1;

        public bool SuperPoisonP1
        {
            get { return _superPoisonP1; }
            set
            {
                if (_superPoisonP1 != value)
                {
                    _superPoisonP1 = value;
                    SettingsClass.SuperPoisonP1 = _superPoisonP1;
                    RaisePropertyChanged("SuperPoisonP1");
                }
            }
        }

        private bool _superPoisonP2;

        public bool SuperPoisonP2
        {
            get { return _superPoisonP2; }
            set
            {
                if (_superPoisonP2 != value)
                {
                    _superPoisonP2 = value;
                    SettingsClass.SuperPoisonP2 = _superPoisonP2;
                    RaisePropertyChanged("SuperPoisonP2");
                }
            }
        }

        private bool _megaPoisonP1;

        public bool MegaPoisonP1
        {
            get { return _megaPoisonP1; }
            set
            {
                if (_megaPoisonP1 != value)
                {
                    _megaPoisonP1 = value;
                    SettingsClass.MegaPoisonP1 = _megaPoisonP1;
                    RaisePropertyChanged("MegaPoisonP1");
                }
            }
        }

        private bool _megaPoisonP2;

        public bool MegaPoisonP2
        {
            get { return _megaPoisonP2; }
            set
            {
                if (_megaPoisonP2 != value)
                {
                    _megaPoisonP2 = value;
                    SettingsClass.MegaPoisonP2 = _megaPoisonP2;
                    RaisePropertyChanged("MegaPoisonP2");
                }
            }
        }

        private bool _cureP1;

        public bool CureP1
        {
            get { return _cureP1; }
            set
            {
                if (_cureP1 != value)
                {
                    _cureP1 = value;
                    SettingsClass.CureP1 = _cureP1;
                    RaisePropertyChanged("CureP1");
                }
            }
        }

        private bool _cureP2;

        public bool CureP2
        {
            get { return _cureP2; }
            set
            {
                if (_cureP2 != value)
                {
                    _cureP2 = value;
                    SettingsClass.CureP2 = _cureP2;
                    RaisePropertyChanged("CureP2");
                }
            }
        }

        private bool _superCureP1;

        public bool SuperCureP1
        {
            get { return _superCureP1; }
            set
            {
                if (_superCureP1 != value)
                {
                    _superCureP1 = value;
                    SettingsClass.SuperCureP1 = _superCureP1;
                    RaisePropertyChanged("SuperCureP1");
                }
            }
        }

        private bool _superCureP2;

        public bool SuperCureP2
        {
            get { return _superCureP2; }
            set
            {
                if (_superCureP2 != value)
                {
                    _superCureP2 = value;
                    SettingsClass.SuperCureP2 = _superCureP2;
                    RaisePropertyChanged("SuperCureP2");
                }
            }
        }

        private bool _megaCureP1;

        public bool MegaCureP1
        {
            get { return _megaCureP1; }
            set
            {
                if (_megaCureP1 != value)
                {
                    _megaCureP1 = value;
                    SettingsClass.MegaCureP1 = _megaCureP1;
                    RaisePropertyChanged("MegaCureP1");
                }
            }
        }

        private bool _megaCureP2;

        public bool MegaCureP2
        {
            get { return _megaCureP2; }
            set
            {
                if (_megaCureP2 != value)
                {
                    _megaCureP2 = value;
                    SettingsClass.MegaCureP2 = _megaCureP2;
                    RaisePropertyChanged("MegaCureP2");
                }
            }
        }

        private bool _defenseDownP1;

        public bool DefenseDownP1
        {
            get { return _defenseDownP1; }
            set
            {
                if (_defenseDownP1 != value)
                {
                    _defenseDownP1 = value;
                    SettingsClass.DefenseDownP1 = _defenseDownP1;
                    RaisePropertyChanged("DefenseDownP1");
                }
            }
        }

        private bool _defenseDownP2;

        public bool DefenseDownP2
        {
            get { return _defenseDownP2; }
            set
            {
                if (_defenseDownP2 != value)
                {
                    _defenseDownP2 = value;
                    SettingsClass.DefenseDownP2 = _defenseDownP2;
                    RaisePropertyChanged("DefenseDownP2");
                }
            }
        }

        private bool _defenseUpP1;

        public bool DefenseUpP1
        {
            get { return _defenseUpP1; }
            set
            {
                if (_defenseUpP1 != value)
                {
                    _defenseUpP1 = value;
                    SettingsClass.DefenseUpP1 = _defenseUpP1;
                    RaisePropertyChanged("DefenseUpP1");
                }
            }
        }

        private bool _defenseUpP2;

        public bool DefenseUpP2
        {
            get { return _defenseUpP2; }
            set
            {
                if (_defenseUpP2 != value)
                {
                    _defenseUpP2 = value;
                    SettingsClass.DefenseUpP2 = _defenseUpP2;
                    RaisePropertyChanged("DefenseUpP2");
                }
            }
        }

        private bool _superDefenseP1;

        public bool SuperDefenseP1
        {
            get { return _superDefenseP1; }
            set
            {
                if (_superDefenseP1 != value)
                {
                    _superDefenseP1 = value;
                    SettingsClass.SuperDefenseP1 = _superDefenseP1;
                    RaisePropertyChanged("SuperDefenseP1");
                }
            }
        }

        private bool _superDefenseP2;

        public bool SuperDefenseP2
        {
            get { return _superDefenseP2; }
            set
            {
                if (_superDefenseP2 != value)
                {
                    _superDefenseP2 = value;
                    SettingsClass.SuperDefenseP2 = _superDefenseP2;
                    RaisePropertyChanged("SuperDefenseP2");
                }
            }
        }

        private bool _glueP1;

        public bool GlueP1
        {
            get { return _glueP1; }
            set
            {
                if (_glueP1 != value)
                {
                    _glueP1 = value;
                    SettingsClass.GlueP1 = _glueP1;
                    RaisePropertyChanged("GlueP1");
                }
            }
        }

        private bool _glueP2;

        public bool GlueP2
        {
            get { return _glueP2; }
            set
            {
                if (_glueP2 != value)
                {
                    _glueP2 = value;
                    SettingsClass.GlueP2 = _glueP2;
                    RaisePropertyChanged("GlueP2");
                }
            }
        }

        private bool _separateP1;

        public bool SeparateP1
        {
            get { return _separateP1; }
            set
            {
                if (_separateP1 != value)
                {
                    _separateP1 = value;
                    SettingsClass.SeparateP1 = _separateP1;
                    RaisePropertyChanged("SeparateP1");
                }
            }
        }

        private bool _separateP2;

        public bool SeparateP2
        {
            get { return _separateP2; }
            set
            {
                if (_separateP2 != value)
                {
                    _separateP2 = value;
                    SettingsClass.SeparateP2 = _separateP2;
                    RaisePropertyChanged("SeparateP2");
                }
            }
        }

        private bool _iceP1;

        public bool IceP1
        {
            get { return _iceP1; }
            set
            {
                if (_iceP1 != value)
                {
                    _iceP1 = value;
                    SettingsClass.IceP1 = _iceP1;
                    RaisePropertyChanged("IceP1");
                }
            }
        }

        private bool _iceP2;

        public bool IceP2
        {
            get { return _iceP2; }
            set
            {
                if (_iceP2 != value)
                {
                    _iceP2 = value;
                    SettingsClass.IceP2 = _iceP2;
                    RaisePropertyChanged("IceP2");
                }
            }
        }

        private bool _whirlwindP1;

        public bool WhirlwindP1
        {
            get { return _whirlwindP1; }
            set
            {
                if (_whirlwindP1 != value)
                {
                    _whirlwindP1 = value;
                    SettingsClass.WhirlwindP1 = _whirlwindP1;
                    RaisePropertyChanged("WhirlwindP1");
                }
            }
        }

        private bool _whirlwindP2;

        public bool WhirlwindP2
        {
            get { return _whirlwindP2; }
            set
            {
                if (_whirlwindP2 != value)
                {
                    _whirlwindP2 = value;
                    SettingsClass.WhirlwindP2 = _whirlwindP2;
                    RaisePropertyChanged("WhirlwindP2");
                }
            }
        }

        private bool _aerialWindP1;

        public bool AerialWindP1
        {
            get { return _aerialWindP1; }
            set
            {
                if (_aerialWindP1 != value)
                {
                    _aerialWindP1 = value;
                    SettingsClass.AerialWindP1 = _aerialWindP1;
                    RaisePropertyChanged("AerialWindP1");
                }
            }
        }

        private bool _aerialWindP2;

        public bool AerialWindP2
        {
            get { return _aerialWindP2; }
            set
            {
                if (_aerialWindP2 != value)
                {
                    _aerialWindP2 = value;
                    SettingsClass.AerialWindP2 = _aerialWindP2;
                    RaisePropertyChanged("AerialWindP2");
                }
            }
        }

        private bool _smashP1;

        public bool SmashP1
        {
            get { return _smashP1; }
            set
            {
                if (_smashP1 != value)
                {
                    _smashP1 = value;
                    SettingsClass.SmashP1 = _smashP1;
                    RaisePropertyChanged("SmashP1");
                }
            }
        }

        private bool _smashP2;

        public bool SmashP2
        {
            get { return _smashP2; }
            set
            {
                if (_smashP2 != value)
                {
                    _smashP2 = value;
                    SettingsClass.SmashP2 = _smashP2;
                    RaisePropertyChanged("SmashP2");
                }
            }
        }

        private bool _soulSmashP1;

        public bool SoulSmashP1
        {
            get { return _soulSmashP1; }
            set
            {
                if (_soulSmashP1 != value)
                {
                    _soulSmashP1 = value;
                    SettingsClass.SoulSmashP1 = _soulSmashP1;
                    RaisePropertyChanged("SoulSmashP1");
                }
            }
        }

        private bool _soulSmashP2;

        public bool SoulSmashP2
        {
            get { return _soulSmashP2; }
            set
            {
                if (_soulSmashP2 != value)
                {
                    _soulSmashP2 = value;
                    SettingsClass.SoulSmashP2 = _soulSmashP2;
                    RaisePropertyChanged("SoulSmashP2");
                }
            }
        }

        private bool _reserveOffenseUpP1;

        public bool ReserveOffenseUpP1
        {
            get { return _reserveOffenseUpP1; }
            set
            {
                if (_reserveOffenseUpP1 != value)
                {
                    _reserveOffenseUpP1 = value;
                    SettingsClass.ReserveOffenseUpP1 = _reserveOffenseUpP1;
                    RaisePropertyChanged("ReserveOffenseUpP1");
                }
            }
        }

        private bool _reserveOffenseUpP2;

        public bool ReserveOffenseUpP2
        {
            get { return _reserveOffenseUpP2; }
            set
            {
                if (_reserveOffenseUpP2 != value)
                {
                    _reserveOffenseUpP2 = value;
                    SettingsClass.ReserveOffenseUpP2 = _reserveOffenseUpP2;
                    RaisePropertyChanged("ReserveOffenseUpP2");
                }
            }
        }


        private string _modeInformation = "";

        public string ModeInformation
        {
            get { return _modeInformation; }
            set
            {
                if (_modeInformation != value)
                {
                    _modeInformation = value;
                    RaisePropertyChanged("ModeInformation");
                }
            }
        }

    }
}
