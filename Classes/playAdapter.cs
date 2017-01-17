using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WMPLib;
namespace mPlayer.Classes
{
    
    class playAdapter : Player
    {
        WMPLib.WindowsMediaPlayer wplayer;

        public playAdapter(String songpath)
        {
            String type;
            type = songpath.Substring(songpath.Length - 4);

            if (type.Equals(".wav", StringComparison.InvariantCultureIgnoreCase))
            {
                wplayer = new WMPLib.WindowsMediaPlayer();
            }
        }
                

       			
     public void play(String songpath)
        {
            String type;
            type = songpath.Substring(songpath.Length - 4);
            if (type.Equals(".wav", StringComparison.InvariantCultureIgnoreCase))
            {
                wplayer.URL = songpath;
                wplayer.controls.play();
            }


        }
    }
}
