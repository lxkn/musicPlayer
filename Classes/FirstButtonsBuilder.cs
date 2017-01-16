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
            bp.setNextButton();
        }

        public override void buildPauseButton()
        {
            bp.setPauseButton();
        }

        public override void buildPlayButton()
        {
            bp.setPlayButton();
        }

        public override void buildPreviousButton()
        {
            bp.setPreviousButton();
        }

        public override void buildRepeatButton()
        {
            bp.setRepeatButton();
        }

        public override void buildShuffleButton()
        {
            bp.setShuffleButton();
        }

        public override void buildStopButton()
        {
            bp.setStopButton();
        }

        public override ButtonsPanel getPanel()
        {
            throw new NotImplementedException();
        }
    }
}
