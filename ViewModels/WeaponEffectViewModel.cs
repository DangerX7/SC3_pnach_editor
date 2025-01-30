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
    public class WeaponEffectViewModel : BaseViewModel
    {


        public WeaponEffectViewModel()
        {
            SettingsClass.LoadData();
        }
 

        public void StoreStats()
        {
            int _placeholder1  = 0;
            int _placeholder2  = 0;
            int _placeholder3  = 0;
            int _placeholder4  = 0;
            int _placeholder5  = 0;
            int _placeholder6  = 0;
            int _placeholder7  = 0;
            int _placeholder8  = 0;
            int _placeholder9  = 0;
            int _placeholder10 = 0;
            int _placeholder11 = 0;
            int _placeholder12 = 0;
            int _placeholder13 = 0;
            int _placeholder14 = 0;
            int _placeholder15 = 0;
            int _placeholder16 = 0;
            int _placeholder17 = 0;
            int _placeholder18 = 0;



            SettingsClass.WpnEffect1  = _placeholder1;
            SettingsClass.WpnEffect2  = _placeholder2;
            SettingsClass.WpnEffect3  = _placeholder3;
            SettingsClass.WpnEffect4  = _placeholder4;
            SettingsClass.WpnEffect5  = _placeholder5;
            SettingsClass.WpnEffect6  = _placeholder6;
            SettingsClass.WpnEffect7  = _placeholder7;
            SettingsClass.WpnEffect8  = _placeholder8;
            SettingsClass.WpnEffect9  = _placeholder9;
            SettingsClass.WpnEffect10 = _placeholder10;
            SettingsClass.WpnEffect11 = _placeholder11;
            SettingsClass.WpnEffect12 = _placeholder12;
            SettingsClass.WpnEffect13 = _placeholder13;
            SettingsClass.WpnEffect14 = _placeholder14;
            SettingsClass.WpnEffect15 = _placeholder15;
            SettingsClass.WpnEffect16 = _placeholder16;
            SettingsClass.WpnEffect17 = _placeholder17;
            SettingsClass.WpnEffect18 = _placeholder18;

        }


    }
}
