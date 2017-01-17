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

        public playAdapter()
        {
            wplayer = new System.Media.SoundPlayer();
        }

        public void play(String songpath)
        {
                wplayer.SoundLocation = songpath;
                wplayer.Play();
        }

        public void stop(String songpath)
        {
                wplayer.SoundLocation = songpath;
                wplayer.Stop();
        }
    }
}
