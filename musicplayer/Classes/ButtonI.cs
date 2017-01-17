using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mPlayer.Classes
{
    public abstract class ButtonI
    {
        protected ButtonsPanel bp;

        public void newPanel()
        {
            bp = new ButtonsPanel();
        }
        public ButtonsPanel getPanel()
        {
            return bp;
        }
        public abstract void buildPlayButton();
        public abstract void buildStopButton();
        public abstract void buildPauseButton();
        public abstract void buildNextButton();
        public abstract void buildPreviousButton();
        public abstract void buildShuffleButton();
        public abstract void buildRepeatButton();

    }
}
