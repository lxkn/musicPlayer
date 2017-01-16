using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mPlayer.Classes
{
    public abstract class ButtonI
    {
        ButtonsPanel bp = new ButtonsPanel();

        public abstract void newPanel();
        public abstract ButtonsPanel getPanel();
        public abstract void buildPlayButton();
        public abstract void buildStopButton();
        public abstract void buildPauseButton();
        public abstract void buildNextButton();
        public abstract void buildPreviousButton();
        public abstract void buildShuffleButton();
        public abstract void buildRepeatButton();

    }
}
