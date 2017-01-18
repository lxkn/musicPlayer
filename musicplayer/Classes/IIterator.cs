using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mPlayer.Classes
{
    public interface IIterator
    {
       
        Song First { get; }
        Song Last { get; }
        Song Next { get; }
        Song Previous { get; }
        Boolean hasNext { get; }
        Boolean hasPrevious { get; }
    }
}
