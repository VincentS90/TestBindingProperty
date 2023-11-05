using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ListBase
{
    public class ViewModelBaseVM : INotifyPropertyChanged
    {
        public ViewModelBaseVM()
        {
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string propname = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propname));
        }
    }
}

