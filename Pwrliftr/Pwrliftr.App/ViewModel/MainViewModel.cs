using GalaSoft.MvvmLight.CommandWpf;
using System.ComponentModel;

namespace Pwrliftr.App.ViewModel
{
    public class MainViewModel : INotifyPropertyChanged
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
            settingsPage.Show();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void RaisePropertyChanged(string propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}