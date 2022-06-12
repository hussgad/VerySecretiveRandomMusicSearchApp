using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using VerySecretiveRandomMusicSearchApp.Model;

namespace VerySecretiveRandomMusicSearchApp
{
    /// <summary>
    /// Interaction logic for SongPage.xaml
    /// </summary>
    public partial class SongPage : Page
    {
        private string url = "https://random-words-api.vercel.app/word";
        public int numOfSongs { get; set; }
        public List<Song> Songs { get; set; }

        public List<WordModel> Words { get; set; }

        public SongPage()
        {
            InitializeComponent();
            this.numOfSongs = Properties.Settings.Default.SliderNum;
            using (WebClient client = new WebClient())
            {
                for(int i = 0; i < numOfSongs; i++)
                {
                    string s = client.DownloadString(url);
                    List<WordModel> wordModel = JsonConvert.DeserializeObject<List<WordModel>>(s);
                    Words.Add(new WordModel(wordModel[0].Word));
                }
            }

        }
    }
}
