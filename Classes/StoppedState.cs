using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mPlayer.Classes
{
    class StoppedState : PlayState
    {
        public override void nextSong(MainWindow context)
        {
            Console.WriteLine("Nastepna piosenka - stan bez zmian");
        }

        public override void pauseSong(MainWindow context)
        {
            Console.WriteLine("Zatrzymanie piosenki na stooped -stan bez zmian");
        }

        public override void playSong(MainWindow context)
        {
            Console.WriteLine("Odtwarzacz zaczyna grac przechodzi w stan playingState");
            base.setState(context, new PlayingState());
        }

        public override void previousSong(MainWindow context)
        {
            Console.WriteLine("Poprzednia piosenka - stan bez zmian");
        }

        public override void stopSong(MainWindow context)
        {
            Console.WriteLine("Piosenka jest nieodtwarzana nic sie nie dzieje");
        }
    }
}
