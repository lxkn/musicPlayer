using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mPlayer
{
    class PlayingState : PlayState
    {
        public override void playSong(MainWindow elo)
        {
            Console.WriteLine("Nic sie nie dzieje odtwarzacz gra");
        }

        public override void stopSong(MainWindow elo)
        {
            Console.WriteLine("Odtwarzacz przestaje grac i wchodzi w stan stoppedState");
            base.setState(elo, new StoppedState());
        }
    }
}
