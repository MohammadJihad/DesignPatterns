using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.BehavioralPatterns.StatePattern
{
    /// <summary>
    /// After refactoring
    /// </summary>
    public class CDPlayer
    {
        public ICDPlayerStateChange State { get; set; }
        public CDPlayer()
        {
            State = new CDPlayerCloseState();
        }
        public void Press()
        {
            State.Press(this);
        }
    }

    //Before refactoring
    //public enum CDPlayerState
    //{
    //    Closed,
    //    Opened,
    //    Playing
    //}
    //public class CDPlayer
    //{
    //    public CDPlayerState State { get; set; }
    //    public void Press()
    //    {
    //        if (State == CDPlayerState.Closed)
    //        {
    //            State = CDPlayerState.Opened;
    //            Console.WriteLine("CD Player earlier state: Closed");
    //            Console.WriteLine("CD Player new state: Opened\n");
    //        }
    //        else if (State == CDPlayerState.Opened)
    //        {
    //            State = CDPlayerState.Playing;
    //            Console.WriteLine("CD Player earlier state: Opened");
    //            Console.WriteLine("CD Player new state: Playing\n");
    //        }
    //        else if (State == CDPlayerState.Playing)
    //        {
    //            State = CDPlayerState.Closed;
    //            Console.WriteLine("CD Player earlier state: Playing");
    //            Console.WriteLine("CD Player new state: Closed\n");
    //        }
    //    }
    //}
}
