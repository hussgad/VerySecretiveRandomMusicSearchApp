using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using VerySecretiveRandomMusicSearchApp.Model;

namespace VerySecretiveRandomMusicSearchApp.ViewModel
{
    internal class SongViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private string url = "https://random-words-api.vercel.app/word";

        public int numOfSongs { get; set; }

        private ObservableCollection<Song> _songs;

        public ObservableCollection<Song> Songs
        {
            get { return _songs; }
            set { _songs = value; OnPropertyChanged("Songs"); }
        }


        public SongViewModel(int numOfSongs)
        {
            this.numOfSongs = numOfSongs;
            using (WebClient client = new WebClient())
            {
                string s = client.DownloadString(url);
                List<WordModel> wordModel = JsonConvert.DeserializeObject<List<WordModel>>(s);
                Properties.Settings.Default.Word = wordModel[0].Word;
            }

        }

        private void OnPropertyChanged(string property)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(property));
        }
    }
}
