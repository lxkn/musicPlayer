using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WMPLib;
namespace mPlayer.Classes
{

    class playAdapter : MainWindow
    {
        System.Media.SoundPlayer wplayer;

        public playAdapter(String songpath)
        {
            String type;
            type = songpath.Substring(songpath.Length - 4);

            if (type.Equals(".wav", StringComparison.InvariantCultureIgnoreCase))
            {
                wplayer = new System.Media.SoundPlayer();
            }
        }



        public void play(String songpath)
        {
            String type;
            type = songpath.Substring(songpath.Length - 4);
            if (type.Equals(".wav", StringComparison.InvariantCultureIgnoreCase))
            {

                wplayer.SoundLocation = songpath;
                wplayer.Play();
            }


        }

        public void stop(String songpath)
        {
            String type;
            type = songpath.Substring(songpath.Length - 4);
            if (type.Equals(".wav", StringComparison.InvariantCultureIgnoreCase))
            {

                wplayer.SoundLocation = songpath;
                wplayer.Stop();
            }


        }
    }
}
