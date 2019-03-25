﻿using Group_24_Animated_Algorithms.Output;
using Group_24_Animated_Algorithms.Searching_Algorithms;
using Group_24_Animated_Algorithms.Sorting_Algorithms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace Group_24_Animated_Algorithms
{
    // NOTE:
    // >window width autoscales with values, starting at a size of 1000px
    // >window height is static and scales the input values between the const int newMin and newMax values
    // >all bars are held within "Bar" objects containing their width, height, values and positions

    public partial class OutputScreen : Form
    {

        ///////////////
        // Variables //
        ///////////////

        //List holds all the bars
        private List<Bar> bars = new List<Bar>();

        //Hold inputs
        private Decimal[] input;
        Sorting sorting;
        Searching searching;
        bool ascending;
        decimal target;
        int time;

        //Variable holds the base width of the bars
        private int barWidth;

        //Variables hold inputs min and max (old scale)
        private int min;
        private int max;

        //Graphics
        Graphics Graphics;
        SolidBrush Backbrush;

        //Variables hold new scale
        const int newMin = 10;
        const int newMax = 650;

        //Side margin
        const int marginRight = 500;
        const int minScreenWidth = 1000;

        //Variable holds min bar width
        const int minWidth = 25;
        //how long you want to hover over a highlighted bar 
        const int miliseconds = 50;
        //holdssounds
        SoundPlayer snd_button = new SoundPlayer("Button.wav");
        SoundPlayer snd_switch = new SoundPlayer("Switch.wav");
        //holds states
        public bool paused = false;
        public bool step = false;
        //holds algorithm object
        Algorithm algorithm;
        //////////////////
        // Constructors //
        //////////////////

        //Sorting Constructor
        public OutputScreen(Decimal[] Input, Sorting Sorting, bool Ascending, int time)
        {
            this.time = time;
            input = Input;
            sorting = Sorting;
            ascending = Ascending;
            InitializeComponent(); //Build in, for GUI
            Init();
            DrawBars();

            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.WorkerSupportsCancellation = true;
            if (backgroundWorker1.IsBusy != true)
            {
                backgroundWorker1.RunWorkerAsync();
            }
        }
        //Searching Constructor
        public OutputScreen(Decimal[] Input, Searching Searching, decimal Target, int time)
        {
            this.time = time;
            input = Input;
            searching = Searching;
            target = Target;
            InitializeComponent(); //Build in, for GUI
            Init();
            grp_result.Enabled = true;

            backgroundWorker2.WorkerReportsProgress = true;
            backgroundWorker2.WorkerSupportsCancellation = true;

            if (backgroundWorker2.IsBusy != true)
            {
                backgroundWorker2.RunWorkerAsync();
            }
        }

        //Destructor 
        ~OutputScreen()
        {
            Graphics.Dispose();
        }

        //Setup the window width height etc.
        private void Init()
        {

            //Set the width of the bars so that they sill the screen
            barWidth = input.Count() / this.Width;

            //Set min and max values
            min = (int)input.Min();
            max = (int)input.Max();

            //If < newWidth px width resize the window to fit them all with newWidth px
            if (barWidth < minWidth)
            {
                barWidth = minWidth;
                int size = minScreenWidth;
                if ((input.Count() * minWidth) + (barWidth * 2) > minScreenWidth)
                {
                    size = (input.Count() * minWidth) + (barWidth * 2);
                }
                this.Width = size + marginRight;
            }

            //Create bar objects from array and all them to a list
            bars = ArrayToBarList(input);

            Backbrush = new SolidBrush(this.BackColor);
            Graphics = CreateGraphics();
            Graphics.BeginContainer();
            Graphics.ScaleTransform(1.0F, -1.0F);
            Graphics.TranslateTransform(0.0F, -(float)Height);

            //draw self
            DrawBars();
            Show();
        }

        ///////////
        // Other //
        ///////////

        //
        private List<Bar> Getnewrgb(List<Bar> bars)
        {
            var tmpbars = new List<Bar>();
            tmpbars = bars.OrderBy(b => b.Value).ToList();

            decimal a = tmpbars.Count();
            List<int[]> tmp = new List<int[]>();
            decimal x = (a / 5);
            int counter = (int)Math.Ceiling(x);
            for (int r = 0; r < counter; r++) tmp.Add(new int[3] { r * 255 / counter, 255, 0 });
            for (int g = counter; g > 0; g--) tmp.Add(new int[3] { 255, g * 255 / counter, 0 });
            for (int b = 0; b < counter; b++) tmp.Add(new int[3] { 255, 0, b * 255 / counter });
            for (int r = counter; r > 0; r--) tmp.Add(new int[3] { r * 255 / counter, 0, 255 });
            for (int g = 0; g < ((int)a - (counter * 4)); g++) tmp.Add(new int[3] { 0, g * 255 / ((int)a - (counter * 4)), 255 });

            for (int i = 0; i < a; i++)
            {
                tmpbars[i].Colour = tmp[i];
            }

            foreach (var item in tmpbars)
            {
                bars.Single(z => z.Value == item.Value).Colour = item.Colour;
            }

            return bars;
        }

        //Takes the array and returns a List of Bar objects
        private List<Bar> ArrayToBarList(Decimal[] Input)
        {
            //Create list
            var tmpBarList = new List<Bar>();

            //create pos counter
            var pos = 0;

            //Fill list
            foreach (var item in Input)
            {
                //create the object and add to list
                tmpBarList.Add(new Bar() { Width = barWidth, Height = CalcHeight(item), Value = item, Pos = pos });

                //increment position
                pos++;
            }
            tmpBarList = Getnewrgb(tmpBarList);
            //Return list
            return tmpBarList;
        }

        //Calculates the height based on the min and max values and stretches to required scale
        private int CalcHeight(Decimal oldValue)
        {
            //Hold the range of the original min and max values
            var oldRange = (max - min);
            //Hold the range of the new scale
            var newRange = (newMax - newMin);
            //Calcualte the new height based on these ranges
            var newValue = (((oldValue - min) * newRange) / oldRange) + newMin;
            return (int)newValue;
        }

        /////////////////
        // Update Text //
        /////////////////
        public void UpdateControl(Control control, string text)
        {
            try
            {
                if (!InvokeRequired)
                {
                    control.Text = text;
                }
                else
                {
                    Invoke(new Action<Control, string>(UpdateControl), control, text);
                }
            }
            catch { }
        }

        public void UpdateInfo(string code)
        {
            try
            {
                if (!InvokeRequired)
                {
                    TB_Info.Text = code;
                    TB_Info.SelectionColor = Color.Yellow;
                    TB_Info.SelectionBackColor = Color.White;
                    TB_Info.Refresh();
                }
                else
                {
                    Invoke(new Action<string>(UpdateInfo), code);
                }
            }
            catch { }
        }

        public void UpdateBox(int line, int line2)
        {
            try
            {
                if (!InvokeRequired)
                {
                    bool scroll = false;
                    var startIndex = TB_Info.GetFirstCharIndexFromLine(line - 1);
                    var endIndex = TB_Info.GetFirstCharIndexFromLine(line2);
                    if (TB_Info.SelectionStart > startIndex)
                    {
                        scroll = true;
                    }
                    TB_Info.Select(startIndex, (endIndex - 1) - startIndex);
                    TB_Info.Refresh();
                    TB_Info.Focus();
                    if (scroll)
                    {
                        TB_Info.ScrollToCaret();
                    }
                }
                else
                {
                    Invoke(new Action<int, int>(UpdateBox), line, line2);
                }
            }
            catch { }
        }

        //Updates the operations counter
        public void UpdateOperations(int value)
        {
            try
            {
                if (!InvokeRequired)
                {
                    tb_operations.Text = value.ToString();
                    tb_operations.Refresh();
                }
                else
                {
                    Invoke(new Action<int>(UpdateOperations), value);
                }
            }
            catch { }
        }

        /////////////
        // DRAWING //
        /////////////

        //Draw All the bars
        public void DrawBars()
        {
            foreach (var item in bars)
            {
                DrawBar(item);
            }
        }

        //Draw All the bars
        public void OutlineBars()
        {
            foreach (var item in bars)
            {
                DrawOutline(item);
            }
        }

        //Draw specific bar
        private void DrawBar(Bar bar)
        {
            var x = new SolidBrush(Color.FromArgb(bar.Colour[0], bar.Colour[1], bar.Colour[2]));
            Graphics.FillRectangle(x, new Rectangle(bar.Width * bar.Pos, 40, bar.Width, bar.Height));
            DrawOutline(bar);
        }
        private void DrawOutline(Bar bar)
        {
            var x = new Pen(Color.Black, bar.Width / 8);
            Graphics.DrawRectangle(x, new Rectangle((bar.Width * bar.Pos) + ((bar.Width / 8) / 2), 40, bar.Width - ((bar.Width / 8)), bar.Height));
        }
        //Draw specific bar
        public void DrawBar(int pos)
        {
            var bar = bars.Single(y => y.Pos == pos);
            var x = new SolidBrush(Color.FromArgb(bar.Colour[0], bar.Colour[1], bar.Colour[2]));
            Graphics.FillRectangle(x, new Rectangle(bar.Width * bar.Pos, 40, bar.Width, bar.Height));
            DrawOutline(bar);
        }

        //Remove bar at position
        public void ClearBar(int pos)
        {
            Graphics.FillRectangle(Backbrush, new Rectangle(minWidth * pos, 40, minWidth, Height));
        }

        //highlights a bar
        public void StartHighlightBar(int pos)
        {
            var bar = bars.Single(x => x.Pos == pos);
            using (Pen p = new Pen(new SolidBrush(Color.FromArgb(0, 0, 0)), 10f))
            {
                p.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;

                Graphics.DrawLine(p, (bar.Width * bar.Pos) + (bar.Width / 2), bar.Height + 100, (bar.Width * bar.Pos) + (bar.Width / 2), bar.Height + 45);
            }
        }

        //swaps two bars positions
        public void SwapBars(int CurrentPos, int NewPos)
        {
            var windowInApplicationIsFocused = Form.ActiveForm != null;
            if (windowInApplicationIsFocused)
            {
                    snd_switch.Play();
            }
            //store the bars
            var bar1 = bars.Single(x => x.Pos == CurrentPos);
            var bar2 = bars.Single(x => x.Pos == NewPos);

            //if they're the same dont try swap
            if (bar1.Pos == bar2.Pos && bar1.Value == bar2.Value)
            {
                DrawBar(bar1);
                return;
            }

            //move 1st bar to tmp pos
            bars.Single(x => x.Pos == CurrentPos).Pos = -1;
            //move over 2nd bar
            bars.Single(x => x.Pos == NewPos).Pos = CurrentPos;
            //move over 1st bar
            bars.Single(x => x.Pos == -1).Pos = NewPos;

            ClearBar(bar1.Pos);
            ClearBar(bar2.Pos);
            DrawBar(bar1);
            DrawBar(bar2);
        }


        ////////////////
        // Algorithms //
        ////////////////

        private void BackgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            var me = this;
            Thread.CurrentThread.IsBackground = true;
            switch (sorting)
            {
                //Bubble
                case Sorting.Bubble:
                    algorithm = new Bubble(ref me, time);
                    break;

                //Quick
                case Sorting.Quick:
                    algorithm = new Quick(ref me, time);
                    break;

                //Heap
                case Sorting.Heap:
                    algorithm = new Heap(ref me, time);
                    break;

                //Merge
                case Sorting.Merge:
                    algorithm = new Merge(ref me, time);
                    break;

                //Insertion
                case Sorting.Insertion:
                    algorithm = new Insertion(ref me, time);
                    break;

                default:
                    break;
            }
            UpdateControl(LB_Space, algorithm.data.space);
            UpdateControl(LB_Time, algorithm.data.time);

            if (ascending)
                algorithm.Ascending(input);
            else
                algorithm.Descending(input);


            Action x = delegate
            {
                BT_Pause.Text = "Complete";
                BT_Pause.Enabled = false;
            };
            try
            {
                Invoke(x);
                MessageBox.Show($"Sorting Completed", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DrawBars();
            }
            catch { }
        }

        private void BackgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            var me = this;
            Thread.CurrentThread.IsBackground = true;
            OutlineBars();

            Action y = delegate
            {
                TB_SearchFor.Text = target.ToString();
            };
            Invoke(y);

            switch (searching)
            {
                case Searching.Interpolation:
                    algorithm = new Interpolation(ref me, time);
                    break;
                default:
                    break;
            }
            UpdateControl(LB_Space, algorithm.data.space);
            UpdateControl(LB_Time, algorithm.data.time);

            var result = algorithm.Search(input, target);

            Action x = delegate
            {
                TB_Result.Text = result;
                BT_Pause.Text = "Complete";
                BT_Pause.Enabled = false;
            };
            try
            {
                Invoke(x);
                MessageBox.Show($"Search Completed", result, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch { }

        }

        private void BT_Pause_Click(object sender, EventArgs e)
        {
            if (paused)
            {
                algorithm.Chill();
                algorithm.TogglePause(paused);
                BT_Pause.Text = "Pause";
                if (this.ContainsFocus)
                {
                    snd_button.Play();
                }
                paused = false;
                step = false;
                algorithm.ToggleStepping(step);
                BT_Step.Enabled = false;
            }
            else
            {
                algorithm.Chill();
                algorithm.TogglePause(paused);
                BT_Pause.Text = "Resume";
                if (this.ContainsFocus)
                {
                    snd_button.Play();
                }
                paused = true;
                BT_Step.Enabled = true;
            }
        }

        private void BT_Step_Click(object sender, EventArgs e)
        {
            if (step)
            {
                snd_button.Play();
                algorithm.NextStep();
            }
            else
            {
                step = true;
                algorithm.ToggleStepping(step);
            }
        }

        private void OutputScreen_FormClosing(object sender, FormClosingEventArgs e)
        {

            this.algorithm.Close();
            this.input = new decimal[] { 1,2,3};
            //this.algorithm = null;
            //this.snd_button.Dispose();
            //this.snd_switch.Dispose();
            //this.Dispose();

        }
    }
}
