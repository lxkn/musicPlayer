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
            // pobiera z iteratora nastepna pozycje i przekazuje do odtwarzania
            Song tempSong = context.normalIterator.Next;
            context.mp3player.URL = tempSong.path;
            context.mp3player.controls.play();
        }

        public override void pauseSong(MainWindow context)
        {
            Console.WriteLine("Zatrzymanie piosenki - zmiana stanu na pused");
            base.setState(context, new PausedState());
        }

        public override void playSong(MainWindow context)
        {
            // stan play button playSong nic nie robi
            Console.WriteLine("Piosenka sie odtwarza - stan playing");
        }

        public override void previousSong(MainWindow context)
        {
            Console.WriteLine("Previus - playing state");
            // pobiera z iteratora aktualnie grana pozycje i ja powtarza
            Song tempSong = context.normalIterator.current;
            context.mp3player.URL = tempSong.path;
            context.mp3player.controls.play();
        }

        public override void stopSong(MainWindow context)
        {
            context.mp3player.controls.stop();
            context.playAdapter.stop(context.songPath);
            //zatrzymanie piosenki i przejscie w stan StoppedState            
            base.setState(context, new StoppedState());
        }
    }
}