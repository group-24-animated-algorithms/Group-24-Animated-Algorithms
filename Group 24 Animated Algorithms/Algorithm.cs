using Group_24_Animated_Algorithms.Output;
using System;
using System.Collections.Generic;
using System.Threading;

namespace Group_24_Animated_Algorithms
{
    class Algorithm
    {
        //Variables
        protected OutputScreen Output;
        protected ManualResetEvent pauseEvent = new ManualResetEvent(true);
        protected bool stepping = false;
        protected List<int> searched = new List<int>();
        public Data data;


        //Functions
        public void TogglePause(bool paused)
        {
            //if paused, resume
            if (paused)
            {
                pauseEvent.Set();
            }
            else
            //pause
            {
                pauseEvent.Reset();
            }
        }

        public void ToggleStepping(bool Step)
        {
            //if already stepping, stop stepping
            if (Step)
            {
                stepping = true;
                step = true;
                pauseEvent.Set();
            }
            else
            //start stepping
            {
                stepping = false;
                step = true;
            }
        }

        public void NextStep()
        {
            //take next step
            pauseEvent.Set();
            step = true;
        }

        public void Close()
        {
            //enter closing state
            close = true;
        }

        protected void Update(int line1, int line2)
        {
            //if closing dont update ui
            if (close)
            {
                return;
            }
            //if stepping
            if (stepping)
            {
                //step over
                step = false;
                //wait
                pauseEvent.Reset();
                pauseEvent.WaitOne(Timeout.Infinite);
                //wait for next step
                while (!step)
                {
                    Thread.Sleep(50);
                }
            }
            //add wait location
            pauseEvent.WaitOne(Timeout.Infinite);
            //Highlight lines in ui
            Output.UpdateBox(line1, line2);
            //if not stepping wait
            if (!stepping)
            {
                System.Threading.Thread.Sleep(Output.time);
            }
        }

        public void Chill()
        {
            //tells thread to wait for a little while
            if (!stepping)
            {
                System.Threading.Thread.Sleep(500);
            }
        }

        public void SwapBars(int i, int j)
        {
            //if closing dont update ui
            if (close)
            {
                return;
            }
            //highlight the two swapping bars
            Output.StartHighlightBar(i);
            Output.StartHighlightBar(j);
            //if not stepping, wait
            if (!stepping)
            {
                System.Threading.Thread.Sleep(Output.time);
            }
            //remove the previous bars and redraw in new positions
            Output.ClearBar(i);
            Output.ClearBar(j);
            Output.SwapBars(i, j);
        }

        public void SwapBars(decimal v, int k)
        {
            //if closing dont update ui
            if (close)
            {
                return;
            }
            //if not stepping, wait
            if (!stepping)
            {
                System.Threading.Thread.Sleep(Output.time);
            }
            //remove the previous bar and redraw in new positions
            Output.EditBarPos(v, k);
        }

        public void Highlight(int i)
        {
            //add found location to list
            searched.Add(i);
            //colour the bar just searched for
            Output.DrawBar(i, 50);
            //if not stepping, wait
            if (!stepping)
            {
                System.Threading.Thread.Sleep(Output.time);
            }
        }
        public void HighlightFound(int i)
        {
            searchFound = i;
            //add found location to list
            searched.Add(i);
            //colour the bar just searched for
            Output.DrawBar(i);
            //if not stepping, wait
            if (!stepping)
            {
                System.Threading.Thread.Sleep(Output.time);
            }
        }

        public void HighlightAll()
        {
            //fixes bug and redraws all searched bars onto the screen when required
            foreach (var item in searched)
            {
                if (searchFound == item)
                {
                    Output.DrawBar(item);
                }
                else
                {
                    Output.DrawBar(item, 50);
                }
            }
        }

        public virtual void Ascending(Decimal[] input) { }
        public virtual void Descending(Decimal[] input) { }
        public virtual string Search(Decimal[] input, decimal target) { return ""; }

    }
}
