using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace VerySecretiveRandomMusicSearchApp.ViewModel
{
    internal class NumberSelectionViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private int _sliderValue;

        public int SliderValue
        {
            get { return _sliderValue; }
            set { _sliderValue = value; OnPropertyChanged("SliderValue"); }
        }

        private void OnPropertyChanged(string property)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(property));
        }

        public void OnNextClick(object sender, RoutedEventArgs args)
        {

        }
    }
}
