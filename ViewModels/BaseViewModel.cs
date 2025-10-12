using SC3_pnach_editor.Views;
using SC3_pnach_editor.Services;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace SC3_pnach_editor.ViewModels
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        internal void RaisePropertyChanged(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }


        public void DisplayMainView()
        {
            Application.Current.Dispatcher.Invoke((Action)delegate
            {
                ProcessingClass.MainWindowFrame.Content = new MainView();
            });
        }


        public void DisplayWeaponEffectView()
        {
            Application.Current.Dispatcher.Invoke((Action)delegate
            {
                ProcessingClass.MainWindowFrame.Content = new WeaponEffectView();
            });
        }


        public void DisplayCharactersView()
        {
            Application.Current.Dispatcher.Invoke((Action)delegate
            {
                ProcessingClass.MainWindowFrame.Content = new CharactersView();
            });
        }

        public void DisplayCostumesView()
        {
            Application.Current.Dispatcher.Invoke((Action)delegate
            {
                ProcessingClass.MainWindowFrame.Content = new CostumesView();
            });
        }

        public void DisplaySurvivalView()
        {
            Application.Current.Dispatcher.Invoke((Action)delegate
            {
                ProcessingClass.MainWindowFrame.Content = new SurvivalView();
            });
        }

        public void DisplaySpecialEffectsView()
        {
            Application.Current.Dispatcher.Invoke((Action)delegate
            {
                ProcessingClass.MainWindowFrame.Content = new SpecialEffectsView();
            });
        }

        public void DisplayCustomCharactersView()
        {
            Application.Current.Dispatcher.Invoke((Action)delegate
            {
                ProcessingClass.MainWindowFrame.Content = new CustomCharactersView();
            });
        }
    }
}
