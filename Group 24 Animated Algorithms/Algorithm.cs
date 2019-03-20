﻿using Group_24_Animated_Algorithms.Output;
using System;
using System.Threading;

namespace Group_24_Animated_Algorithms
{
    class Algorithm
    {
        //Variables
        protected OutputScreen Output;
        protected int time = 0;
        protected ManualResetEvent pauseEvent = new ManualResetEvent(true);
        public Data data;
        //Functions
        public void TogglePause(bool paused)
        {
            if (paused)
            {
                pauseEvent.Set();
            }
            else
            {
                pauseEvent.Reset();
            }
        }

        protected void Update(int lineNo, int lineLength)
        {
            pauseEvent.WaitOne(Timeout.Infinite);
            Output.UpdateBox(lineNo, lineLength);
            System.Threading.Thread.Sleep(time);
        }

        public void Chill()
        {
            System.Threading.Thread.Sleep(500);
        }

        public virtual void Ascending(Decimal[] input) { }
        public virtual void Descending(Decimal[] input) { }
        public virtual string Search(Decimal[] input, decimal target) { return ""; }

    }
}
