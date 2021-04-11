using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.BehavioralPatterns.StatePattern
{
    public class CDPlayerPlayingState : ICDPlayerStateChange
    {
        public void Press(CDPlayer cdPlayer)
        {
            cdPlayer.State = new CDPlayerCloseState();
            Console.WriteLine("CD Player earlier state: Playing");
            Console.WriteLine("CD Player new state: Closed\n");
        }
    }
}
