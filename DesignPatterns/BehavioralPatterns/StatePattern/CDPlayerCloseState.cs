using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.BehavioralPatterns.StatePattern
{
    public class CDPlayerCloseState : ICDPlayerStateChange
    {
        public void Press(CDPlayer cdPlayer)
        {
            cdPlayer.State = new CDPlayerOpenedState();
            Console.WriteLine("CD Player earlier state: Closed");
            Console.WriteLine("CD Player new state: Opened\n");
        }
    }
}
