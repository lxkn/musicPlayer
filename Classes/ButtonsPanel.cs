using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mPlayer.Classes
{
    public class ButtonsPanel
    {
        string playPath, stopPath, pausePath, nextPath, previousPath, shufflePath, repeatPath;
        public ButtonsPanel()
        {

        }
        public void setPlayButton(string playpath)
        {
            this.playPath = playpath;
        }
        public void setStopButton(string stoppath)
        {
            this.stopPath = stoppath;
        }
        public void setPauseButton(string pausepath)
        {
            this.pausePath = pausepath;
        }
        public void setNextButton(string nextpath)
        {
            this.nextPath = nextpath;
        }
        public void setPreviousButton(string previouspath)
        {
            this.previousPath = previouspath;
        }
        public void setShuffleButton(string shufflepath)
        {
            this.shufflePath = shufflepath;
        }
        public void setRepeatButton(string repeatpath)
        {
            this.repeatPath = repeatpath;
        }
    }
}
