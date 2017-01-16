using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mPlayer
{
    abstract class PlayState
    {
        public abstract void playSong(MainWindow elo);
        public abstract void stopSong(MainWindow elo);
        protected void setState(MainWindow elo, PlayState stan)
        {
            elo.Current_state = stan;
        }
    }
}
