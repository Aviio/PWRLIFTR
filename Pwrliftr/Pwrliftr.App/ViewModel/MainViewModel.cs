using GalaSoft.MvvmLight;
using Pwrliftr.App.Model;
using System.ComponentModel;
using System.Windows.Input;

namespace Pwrliftr.App.ViewModel
{
    public class MainViewModel : INotifyPropertyChanged
    {
        
        
        public MainViewModel()
        {
            
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