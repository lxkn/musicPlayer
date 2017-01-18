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
            Console.WriteLine("Stan playing - nextSong - play //- mp3");
            context.mp3player.URL = context.tempSong.path;
            context.mp3player.controls.play();
            base.setState(context, new PlayingState());
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
                context.mp3player.controls.stop();
                context.playAdapter.stop(context.songPath);
                base.setState(context, new StoppedState());
        }
    }
}