using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mPlayer.Classes
{
    public class Song
    {
        public double length { get; set; }
        public string title { get; set; }
        public string artist { get; set; }
        public string album { get; set; }
        public int number { get; set; }
        public int year { get; set; }
        public string path { get; set; }
        public Song(double length, string title, string artist, string album, int year, int number,string path)
        {
            this.length = length;
            this.title = title;
            this.artist = artist;
            this.album = album;
            this.year = year;
            this.number = number;
            this.path = path;
        }
        public Song()
        {

        }
    }
}
