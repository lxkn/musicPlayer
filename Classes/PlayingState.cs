using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using mPlayer.Views;
namespace mPlayer.Classes
{
    class PlayingState : PlayState
    {

        public override void nextSong(MainWindow context)
        {
            Console.WriteLine("Nastepna piosenka - stan bez zmian");
        }

        public override void pauseSong(MainWindow context)
        {
            Console.WriteLine("Zatrzymanie piosenki - zmiana stanu na pused");
            base.setState(context, new PausedState());
        }

        public override void playSong(MainWindow context)
        {
            Console.WriteLine("Piosenka sie odtwarza - stan playing");
        }

        public override void previousSong(MainWindow context)
        {
            Console.WriteLine("Poprzednia piosenka - stan bez zmian");

        }

        public override void stopSong(MainWindow context)
        {
            Console.WriteLine("Zatrzymaj sie - playing state");

            context.mp3player.URL = context.songPath;
            context.mp3player.controls.stop();
            base.setState(context, new StoppedState());
        }
    }
}