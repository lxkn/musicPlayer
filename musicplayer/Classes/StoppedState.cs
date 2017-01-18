using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using mPlayer.Views;
namespace mPlayer.Classes
{
    class StoppedState : PlayState
    {

        public override void nextSong(MainWindow context)
        {
            Console.WriteLine("Stan stopped - nextSong- play //- mp3");
            Song tempSong = context.normalIterator.Next;
            context.mp3player.URL = tempSong.path;
            context.mp3player.controls.play();
            base.setState(context, new PlayingState());
        }

        public override void pauseSong(MainWindow context)
        {
            Console.WriteLine("Zatrzymanie piosenki na stooped -stan bez zmian");
        }


        public override void playSong(MainWindow context)
        {
            String type = context.songPath.Substring(context.songPath.Length - 4);


            if (type.Equals(".mp3", StringComparison.InvariantCultureIgnoreCase))
            {

                Console.WriteLine("Stan stopped - play - mp3");
                context.mp3player.URL = context.songPath;
                context.mp3player.controls.play();
                base.setState(context, new PlayingState());
            }
            else if(type.Equals(".wav", StringComparison.InvariantCultureIgnoreCase))
            {
                Console.WriteLine("Stan stopped - play - wav");
                context.playAdapter.play(context.songPath);
                base.setState(context, new PlayingState());
            }
            else
            {
                Console.WriteLine("NIeodtwarzany format pliku");
            }
            
        }

        public override void previousSong(MainWindow context)
        {
            Console.WriteLine("Previus - stopped state");
            Song tempSong = context.normalIterator.Previous;
            context.mp3player.URL = tempSong.path;
            context.mp3player.controls.play();
            base.setState(context, new PlayingState());
        }

        public override void stopSong(MainWindow context)
        {
            Console.WriteLine("Stop song  - nic sie nie dzieje - stan stopped");
            // stopmusic(path);

        }
    }
}