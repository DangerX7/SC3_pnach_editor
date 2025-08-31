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
    public class SurvivalViewModel : BaseViewModel
    {


        public SurvivalViewModel()
        {
            SettingsClass.LoadData();
        }



        private string _errorTextMessage;

        public string ErrorTextMessage
        {
            get { return _errorTextMessage; }
            set
            {
                if (_errorTextMessage != value)
                {
                    _errorTextMessage = value;
                    RaisePropertyChanged("ErrorTextMessage");
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

        private string _codeInformation = "";

        public string CodeInformation
        {
            get { return _codeInformation; }
            set
            {
                if (_codeInformation != value)
                {
                    _codeInformation = value;
                    RaisePropertyChanged("CodeInformation");
                }
            }
        }

        
    }
}
