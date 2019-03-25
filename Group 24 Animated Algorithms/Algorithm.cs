using Group_24_Animated_Algorithms.Output;
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
        protected bool stepping = false;
        protected bool step = true;
        protected bool close = false;
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

        public void ToggleStepping(bool Step)
        {
            if (Step)
            {
                stepping = true;
                step = true;
                pauseEvent.Set();
            }
            else
            {
                stepping = false;
                step = true;
            }
        }

        public void NextStep()
        {
            pauseEvent.Set();
            step = true;
        }

        public void Close()
        {
            close = true;
        }

        protected void Update(int lineNo, int lineLength)
        {
            if (close)
            {
                return;
            }
            if (stepping)
            {
                step = false;
                pauseEvent.Reset();
                pauseEvent.WaitOne(Timeout.Infinite);
                while (!step)
                {
                    Thread.Sleep(50);
                }
            }
            pauseEvent.WaitOne(Timeout.Infinite);
            Output.UpdateBox(lineNo, lineLength);
            if (!stepping)
            {
                System.Threading.Thread.Sleep(time);
            }
        }

        public void Chill()
        {
            if (!stepping)
            {
                System.Threading.Thread.Sleep(500);
            }
        }

        public void SwapBars(int i, int j)
        {
            if (close)
            {
                return;
            }
            Output.StartHighlightBar(i);
            Output.StartHighlightBar(j);
            if (!stepping)
            {
                System.Threading.Thread.Sleep(time);
            }
            Output.ClearBar(i);
            Output.ClearBar(j);
            Output.SwapBars(i, j);
        }

        public void Highlight(int i)
        {
            Output.DrawBar(i);
            if (!stepping)
            {
                System.Threading.Thread.Sleep(time);
            }
        }

        public virtual void Ascending(Decimal[] input) { }
        public virtual void Descending(Decimal[] input) { }
        public virtual string Search(Decimal[] input, decimal target) { return ""; }

    }
}
