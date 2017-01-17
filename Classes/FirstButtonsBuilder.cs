using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mPlayer.Classes
{
    //Przypisywanie jednego rodzaju ścieżek
    class FirstButtonsBuilder : ButtonI
    {
        public override void buildNextButton()
        {
            bp.nextPath="next.png";
        }

        public override void buildPauseButton()
        {
            bp.pausePath = "pause.png";
        }

        public override void buildPlayButton()
        {
            bp.playPath = "play.png";
        }

        public override void buildPreviousButton()
        {
            bp.previousPath ="previous.png";
        }

        public override void buildRepeatButton()
        {
            bp.repeatPath = "repeat.png";
        }

        public override void buildShuffleButton()
        {
            bp.shufflePath = "shuffle.png";
        }

        public override void buildStopButton()
        {
            bp.stopPath = "stopButton.png";
        }
        
    }
}
