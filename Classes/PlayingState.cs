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
        
        public override void playSong(MainWindow context,string path)
        {
            //
        }

        public override void previousSong(MainWindow context)
        {
            Console.WriteLine("Poprzednia piosenka - stan bez zmian");
            
        }

        public void stopmusic(string songpath)
        {


            String type;
            type = songpath.Substring(songpath.Length - 4);


            if (type.Equals(".mp3", StringComparison.InvariantCultureIgnoreCase))
            {
                mp3player = new WMPLib.WindowsMediaPlayer();
                mp3player.URL = songpath;
                mp3player.controls.stop();
            }


            else if (type.Equals(".mp3", StringComparison.InvariantCultureIgnoreCase))
            {
                playAdapter = new playAdapter(songpath);
                playAdapter.stop(songpath);
            }

            else
            {
                Console.WriteLine("Nieobslugiwany format pliku: " + type);
            }
        }

        public override void stopSong(MainWindow context,String path)
        {
            stopmusic(path);
            base.setState(context, new StoppedState());
        }
    }
}
