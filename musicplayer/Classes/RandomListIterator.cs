using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mPlayer.Classes
{
    class RandomListIterator : IIterator
    {
        /*
        List<Song> songs = null;
        int index = 0;
        int tmp = 0;

        public RandomListIterator(List<Song> list, int idx)
        {
            songs = list;
            index = idx;
        }

        Random rnd = new Random();

        List<int> numbers = Enumerable.Range(0, songs.Count).OrderBy(r =>
        {

            return rnd.Next();
        }
        ).ToList();

        Song First { get { index = numbers[0]; tmp = 0; return songs[index]; } }
        Song Last { get { index = numbers[numbers.Count]; tmp = numbers.Count; return songs[index]; } }
        Song Next
        {
            get
            {
                if (hasNext) { tmp++; index = numbers[tmp]; return songs[index]; }
                else { tmp = 0; index = numbers[tmp]; return songs[index]; }
            }
        }
        Song Previous
        {
            get
            {
                if (hasPrevious) { tmp--; index = numbers[tmp]; return songs[index]; }
                else { tmp = numbers.Count; index = numbers[tmp]; return songs[index]; }
            }
        }
        Boolean hasNext
        {
            get
            {
                if (index != numbers[numbers.Count]) { return true; }
                else { return false; }
            }
        }
        Boolean hasPrevious
        {
            get
            {
                if (index != numbers[0]) { return true; }
                else { return false; }
            }
        }
        */

    }
}



