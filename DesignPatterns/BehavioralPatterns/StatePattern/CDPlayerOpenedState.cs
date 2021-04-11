using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.BehavioralPatterns.StatePattern
{
    public class CDPlayerOpenedState : ICDPlayerStateChange
    {
        public void Press(CDPlayer cdPlayer)
        {
            cdPlayer.State = new CDPlayerPlayingState();
            Console.WriteLine("CD Player earlier state: Opened");
            Console.WriteLine("CD Player new state: Playing\n");
        }
    }
}
