using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerySecretiveRandomMusicSearchApp.Model
{
    public class Song : INotifyPropertyChanged
    {   
        //Due to the basic nature of our program we won't need the PropertyChanged event handler, because we won't be changing songs, but it's still good to have for future possible refactoring :)
        public event PropertyChangedEventHandler PropertyChanged;

        private string _artist;

        public string Artist
        {
            get { return _artist; }
            set { _artist = value; OnPropertyChanged("Artist"); }
        }

        private string _album;

        public string Album
        {
            get { return _album; }
            set { _album = value; OnPropertyChanged("Album"); }
        }

        private string _title;

        public string Title
        {
            get { return _title; }
            set { _title = value; OnPropertyChanged("Title"); }
        }

        private void OnPropertyChanged(string property)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(property));
        }

        public override string ToString()
        {
            return $"{Artist}-'{Album}'-'{Title}'";
        }
    }
}
