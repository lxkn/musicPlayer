﻿using System;
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

        Song First { get; }
        Song Last { get; }
        Song Next
        {
            get
            {
                return songs[index];
            }
        }
        Song Previous
        {
            get
            {
                return songs[index];
            }
        }
        Boolean hasNext
        {
            get
            {
                return true;
            }
        }
        Boolean hasPrevious
        {
            get
            {
                return true;
            }
        }

    }
}
