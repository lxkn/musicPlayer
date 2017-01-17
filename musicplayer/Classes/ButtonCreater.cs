using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mPlayer.Classes
{
    public class ButtonCreater
    {
        private ButtonI buttonsBuild;
        public ButtonI Builder
        {
            get { return buttonsBuild; }
            set { buttonsBuild = value; }
        }

        public ButtonsPanel getPanel()
        {
            return buttonsBuild.getPanel();
        }
        public void createButtons()
        {
            buttonsBuild.newPanel();
            buttonsBuild.buildNextButton();
            buttonsBuild.buildPauseButton();
            buttonsBuild.buildPlayButton();
            buttonsBuild.buildPreviousButton();
            buttonsBuild.buildRepeatButton();
            buttonsBuild.buildShuffleButton();
            buttonsBuild.buildStopButton();
        }
    }
}
