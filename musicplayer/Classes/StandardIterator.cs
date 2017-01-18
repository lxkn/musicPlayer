using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mPlayer.Classes
{
    public class StandardIterator : IIterator
    {
        List<Song> songs = null;
        int index = 0;

        public StandardIterator(List<Song> list, int idx)
        {
            songs = list;
            index = idx;
        }

        public Song First { get { index = 0; return songs[index]; } }
        public Song Last { get { index = songs.Count; return songs[index]; } }
        public Song Next
        {
            get
            {
                if (hasNext) { index++; return songs[index]; }
                else { return First; }
            }
        }
        public Song Previous
        {
            get
            {
                if (hasPrevious) { index--; return songs[index]; }
                else { return Last; }
            }
        }
        public Boolean hasNext
        {
            get
            {
                if (index < (songs.Count-1)) { return true; }
                else { return false; }
            }
        }
        public Boolean hasPrevious
        {
            get
            {
                if (index > 0) { return true; }
                else { return false; }
            }
        }



    }
}

