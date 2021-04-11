using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.BehavioralPatterns.StatePattern
{
    public interface ICDPlayerStateChange
    {
        void Press(CDPlayer cdPlayer);
    }
}
