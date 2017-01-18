using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mPlayer.Classes
{
    
        public class RandomListIterator : IIterator
        {
            List<Song> songs = null;
            int index = 0;
            int tmp = 0;
            List<int> numbers = null;

            public RandomListIterator(List<Song> list, int idx)
            {
                songs = list;
                index = idx;
                Random rnd = new Random();

                numbers = Enumerable.Range(0, (songs.Count-1)).OrderBy(r =>
                {

                    return rnd.Next();
                }
                ).ToList();
            }



            public Song First { get { index = numbers[0]; tmp = 0; return songs[index]; } }
            public Song Last { get { index = numbers[numbers.Count - 1]; tmp = numbers.Count - 1; return songs[index]; } }
            public Song Next
            {
                get
                {
                    if (hasNext) { tmp++; index = numbers[tmp]; return songs[index]; }
                    else { tmp = 0; index = numbers[tmp]; return songs[index]; }
                }
            }
            public Song Previous
            {
                get
                {
                    if (hasPrevious) { tmp--; index = numbers[tmp]; return songs[index]; }
                    else { tmp = numbers.Count - 1; index = numbers[tmp]; return songs[index]; }
                }
            }
            public Boolean hasNext
            {
                get
                {
                    if (index != numbers[numbers.Count - 1]) { return true; }
                    else { return false; }
                }
            }
            public Boolean hasPrevious
            {
                get
                {
                    if (index != numbers[0]) { return true; }
                    else { return false; }
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




