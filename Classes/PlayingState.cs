using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using mPlayer.Views;
namespace mPlayer.Classes
{
    class PlayingState : PlayState, IPlayer
    {
        playAdapter playAdapter;
        System.Media.SoundPlayer mp3player;
        public override void nextSong(MainWindow context)
        {
            Console.WriteLine("Nastepna piosenka - stan bez zmian");
        }

        public override void pauseSong(MainWindow context)
        {
            Console.WriteLine("Zatrzymanie piosenki - zmiana stanu na pused");
            base.setState(context, new PausedState());
        }

        public void playmusic(string songpath)
        {
            String type;
            type = songpath.Substring(songpath.Length - 4);


            if (type.Equals(".mp3", StringComparison.InvariantCultureIgnoreCase))
            {
                mp3player = new System.Media.SoundPlayer();
                mp3player.SoundLocation = songpath;
                mp3player.Play();


            }


            else if (type.Equals(".wav", StringComparison.InvariantCultureIgnoreCase))
            {
                playAdapter = new playAdapter(songpath);
                playAdapter.play(songpath);
            }

            else
            {
                Console.WriteLine("Nieobslugiwany format pliku: " + type);
            }
        }

        public override void playSong(MainWindow context,string path)
        {
            playmusic(path);
        }

        public override void previousSong(MainWindow context)
        {
            Console.WriteLine("Poprzednia piosenka - stan bez zmian");
        }

        public override void stopSong(MainWindow context)
        {
            Console.WriteLine("Odtwarzacz przestaje grac i wchodzi w stan stoppedState");
            base.setState(context, new StoppedState());
        }
    }
}
