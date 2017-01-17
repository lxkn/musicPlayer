using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using mPlayer.Views;
namespace mPlayer.Classes
{
    class PausedState : PlayState
    {
        public override void nextSong(MainWindow context)
        {
            Console.WriteLine("Nastepna piosenka - stan bez zmian");
        }

        public override void pauseSong(MainWindow context)
        {
            Console.WriteLine("Pauza na pauzie - tan bez zmian");
        }

        public override void playSong(MainWindow context, string path)
        {
            Console.WriteLine("Play song zmiana stanu na play");
            base.setState(context, new PlayingState());
        }

        public override void previousSong(MainWindow context)
        {
            Console.WriteLine("Poprzednia piosenka - stan bez zmian");
        }

        public override void stopSong(MainWindow context)
        {
            Console.WriteLine("Stop - zmian stanu na stopped");
            base.setState(context, new StoppedState());
        }
    }
}
