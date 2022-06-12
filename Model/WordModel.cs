using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerySecretiveRandomMusicSearchApp.Model
{
    public class WordModel
    {
        public string Word { get; set; }
        public string Definiton { get; set; }
        public string Pronunciation { get; set; }

        public WordModel(string name)
        {
            Word = name;
        }
    }
}
