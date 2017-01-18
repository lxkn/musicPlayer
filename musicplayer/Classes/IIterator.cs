using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mPlayer.Classes
{
    public class IIterator
    {
        public Song First { get; }
        public Song Last { get; }
        public Song Next { get; }
        public Song Previous { get; }
        public Boolean hasNext { get; }
        public Boolean hasPrevious { get; }
    }
}
