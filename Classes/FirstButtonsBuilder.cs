using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mPlayer.Classes
{
    class FirstButtonsBuilder : ButtonI
    {
        public override void buildNextButton()
        {
            bp.setNextButton("next.png");
        }

        public override void buildPauseButton()
        {
            bp.setPauseButton("pause.png");
        }

        public override void buildPlayButton()
        {
            bp.setPlayButton("play.png");
        }

        public override void buildPreviousButton()
        {
            bp.setPreviousButton("previous.png");
        }

        public override void buildRepeatButton()
        {
            bp.setRepeatButton("repeat.png");
        }

        public override void buildShuffleButton()
        {
            bp.setShuffleButton("shuffle.png");
        }

        public override void buildStopButton()
        {
            bp.setStopButton("stop.png");
        }
        
    }
}
