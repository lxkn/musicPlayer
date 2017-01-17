using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mPlayer.Classes
{
    public class Player : IPlayer
    {
        playAdapter playAdapter;
        System.Media.SoundPlayer mp3player;
        //
        //tu powinno byc @ovverride
        public void playmusic(String songpath)
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
    }
}

