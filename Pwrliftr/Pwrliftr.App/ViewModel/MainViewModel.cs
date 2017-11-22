using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using System.ComponentModel;

namespace Pwrliftr.App.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        public MainViewModel()
        {
        }


        private RelayCommand _showSettingsCommand;

        public RelayCommand ShowSettingsCommand
        {
            get
            {
                return _showSettingsCommand ?? (_showSettingsCommand = new RelayCommand(
                     () =>
                    {
                        ShowSettings();
                    }));
            }
        }

        private void ShowSettings()
        {
            var settingsPage = new Settings();
            settingsPage.ShowDialog();

        }
    }
}