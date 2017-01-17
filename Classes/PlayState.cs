using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using mPlayer.Views;
namespace mPlayer.Classes
{
    abstract class PlayState
    {      
        public abstract void playSong(MainWindow context);
        public abstract void pauseSong(MainWindow context);
        public abstract void stopSong(MainWindow context);
        public abstract void nextSong(MainWindow context);
        public abstract void previousSong(MainWindow context);
        protected void setState(MainWindow context, PlayState state)
        {
            context.Current_state = state;
        }
    }
}
