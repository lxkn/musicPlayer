using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mPlayer.Classes
{
    class StandardIterator : IIterator
    {
        List<Song> songs = null;
        int index = 0;

        public StandardIterator(List<Song> list, int idx)
        {
            songs = list;
            index = idx;
        }

        Song First { get { index = 0; return songs[index]; } }
        Song Last { get { index = songs.Count; return songs[index]; } }
        Song Next
        {
            get
            {
                if (hasNext) { index++; return songs[index]; }
                else { return First; }
            }
        }
        Song Previous
        {
            get
            {
                if (hasPrevious) { index--; return songs[index]; }
                else { return Last; }
            }
        }
        Boolean hasNext
        {
            get
            {
                if (index < songs.Count) { return true; }
                else { return false; }
            }
        }
        Boolean hasPrevious
        {
            get
            {
                if (index > 0) { return true; }
                else { return false; }
            }
        }



    }
}

