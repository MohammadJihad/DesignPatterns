using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.CreationalPatterns
{
    /// <summary>
    /// Not safe for multithreading environment
    /// </summary>
    //public sealed class Singleton
    //{
    //    private static Singleton instance;
    //    private Singleton() { }

    //    public static Singleton Instance
    //    {
    //        get
    //        {
    //            if (instance == null)
    //            {
    //                instance = new Singleton();
    //            }
    //            return instance;
    //        }
    //    }
    //}



    /// <summary>
    /// Performance suffers since a lock is required every time an instance is requested.
    /// </summary>
    //public sealed class Singleton
    //{
    //    private static Singleton instance = null;
    //    private static readonly object syncRoot = new object();
    //    private Singleton() { }
    //    public static Singleton Instance
    //    {
    //        get
    //        {
    //            lock (syncRoot)
    //            {
    //                if (instance == null)
    //                {
    //                    instance = new Singleton();
    //                }
    //                return instance;
    //            }
    //        }
    //    }
    //}

    public sealed class Singleton
    {
        //private static volatile Singleton instance = null;
        private static Singleton instance = null;
        private static readonly object syncRoot = new object();
        private Singleton() { }
        public static Singleton Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        if (instance == null)
                        {
                            instance = new Singleton();
                        }
                    }
                }
                return instance;
            }
        }
    }
}

