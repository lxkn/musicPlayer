using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using mPlayer.Views;
namespace mPlayer.Classes
{
    abstract class PlayState
    {
        playAdapter playAdapter;
        WMPLib.WindowsMediaPlayer mp3player;
        public abstract void playSong(MainWindow context, string path);
        public abstract void pauseSong(MainWindow context);
        public abstract void stopSong(MainWindow context, string path);
        public abstract void nextSong(MainWindow context);
        public abstract void previousSong(MainWindow context);
        public void playmusic(string songpath)
        {
            String type;
            type = songpath.Substring(songpath.Length - 4);


            if (type.Equals(".mp3", StringComparison.InvariantCultureIgnoreCase))
            {
                mp3player = new WMPLib.WindowsMediaPlayer();
                mp3player.URL = songpath;
                mp3player.controls.play();
            }


            else if (type.Equals(".mp3", StringComparison.InvariantCultureIgnoreCase))
            {
                playAdapter = new playAdapter(songpath);
                playAdapter.play(songpath);
            }

            else
            {
                Console.WriteLine("Nieobslugiwany format pliku: " + type);
            }
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
        protected void setState(MainWindow context, PlayState state)
        {
            context.Current_state = state;
        }
    }
}
