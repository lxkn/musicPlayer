using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mPlayer.Classes
{
    class LoopIterator : IIterator
    {
        List<Song> songs = null;
        int index = 0;

        public LoopIterator(List<Song> list, int idx)
        {
            songs = list;
            index = idx;
        }

        public Song First { get; }
        public Song Last { get; }
        public Song Next
        {
            get
            {
                return songs[index];
            }
        }
        public Song Previous
        {
            get
            {
                return songs[index];
            }
        }
        public Boolean hasNext
        {
            get
            {
                return true;
            }
        }
        public Boolean hasPrevious
        {
            get
            {
                return true;
            }
        }
        public Song current
        {
            get
            {
                return songs[index];
            }
        }

    }
}
