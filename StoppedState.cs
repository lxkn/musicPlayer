using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mPlayer
{
    class StoppedState : PlayState
    {
        public override void playSong(MainWindow elo)
        {
            Console.WriteLine("Odtwarzacz zaczyna grac przechodzi w stan playingState");
            base.setState(elo, new PlayingState());
        }

        public override void stopSong(MainWindow elo)
        {
            Console.WriteLine("Piosenka jest nieodtwarzana nic sie nie dzieje");
        }
    }
}
