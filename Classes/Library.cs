using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mPlayer.Classes
{
    public class Library
    {
        private static Library singletonInstance;


        private Library()
        {
        }
        public static Library Instance
        {
            get
            {
                // Jeżeli nie ma obiektu, stwórz
                if (singletonInstance == null)
                {
                    singletonInstance = new Library();
                }
                return singletonInstance;
            }
        }
    }
}
