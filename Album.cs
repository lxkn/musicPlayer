using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mPlayer
{
    class Album
    {
        public String title { get; set; }
        public String author { get; set; }
        public String year { get; set; }
        public String label { get; set; }
        public List<Song> songList { get; set;}

        public Album(String title, String author, String year, String label)
        {
            this.title = title;
            this.author = author;
            this.year = year;
            this.label = label;
        }
    }
}
