using Group_24_Animated_Algorithms.Output;
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
        bool issorting = false;
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
            //assign variables
            this.time = time;
            input = Input;
            issorting = true;
            sorting = Sorting;
            ascending = Ascending;
            InitializeComponent(); //Build in, for GUI
            Init();
            DrawBars();

            //setup and start background thread
            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.WorkerSupportsCancellation = true;
            backgroundWorker1.RunWorkerAsync();
        }

        //Searching Constructor
        public OutputScreen(Decimal[] Input, Searching Searching, decimal Target, int time)
        {
            //assign variables
            this.time = time;
            input = Input;
            issorting = false;
            searching = Searching;
            target = Target;
            InitializeComponent(); //Build in, for GUI
            Init();
            grp_result.Enabled = true;

            //setup and start background thread
            backgroundWorker2.WorkerReportsProgress = true;
            backgroundWorker2.WorkerSupportsCancellation = true;
            backgroundWorker2.RunWorkerAsync();
        }

        //Destructor 
        ~OutputScreen()
        {
            Graphics.Dispose();
        }

        //Setup the window width height etc.
        private void Init()
        {

            //Set the width of the bars so that they fill the screen
            barWidth = input.Count() / this.Width;

            //Set min and max values
            min = (int)input.Min();
            max = (int)input.Max();

            //if there are too many bars make the output window bigger
            if (barWidth < minWidth)
            {
                //set bar width to min if lower
                barWidth = minWidth;

                int size = minScreenWidth;

                //if the window should be resized, resize
                if ((input.Count() * minWidth) + (barWidth * 2) > minScreenWidth)
                {
                    size = (input.Count() * minWidth) + (barWidth * 2);
                }

                //set new size + margin
                this.Width = size + marginRight;
            }

            //Create bar objects from array and all them to a list
            bars = ArrayToBarList(input);

            //set background colour as brush
            Backbrush = new SolidBrush(this.BackColor);

            //init graphics object
            Graphics = CreateGraphics();
            Graphics.BeginContainer();
            Graphics.ScaleTransform(1.0F, -1.0F);
            Graphics.TranslateTransform(0.0F, -(float)Height);

            //draw self
            DrawBars();
            Show();
        }

        ///////////////
        // Functions //
        ///////////////

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
            //add the colours
            tmpBarList = Getnewrgb(tmpBarList);

            //Return list
            return tmpBarList;
        }

        //gets the colour of the list of bars
        private List<Bar> Getnewrgb(List<Bar> bars)
        {
            //duplicate the bars list
            var tmpbars = new List<Bar>();
            //sort the bars list by value (get to the end state)
            tmpbars = bars.OrderBy(b => b.Value).ToList();

            //variables
            decimal a = tmpbars.Count();
            List<int[]> tmp = new List<int[]>(); //list to hold colours

            //get count divided by rgb split
            decimal x = (a / 5);
            //round up to int
            int counter = (int)Math.Ceiling(x);

            //run for loops creating rgb colours at "equal" (enough) intervals
            for (int r = 0; r < counter; r++) tmp.Add(new int[3] { r * 255 / counter, 255, 0 });
            for (int g = counter; g > 0; g--) tmp.Add(new int[3] { 255, g * 255 / counter, 0 });
            for (int b = 0; b < counter; b++) tmp.Add(new int[3] { 255, 0, b * 255 / counter });
            for (int r = counter; r > 0; r--) tmp.Add(new int[3] { r * 255 / counter, 0, 255 });
            //as counter was rounded up, calculate the remaining time needed to run
            for (int g = 0; g < ((int)a - (counter * 4)); g++) tmp.Add(new int[3] { 0, g * 255 / ((int)a - (counter * 4)), 255 });

            //assign new colours
            for (int i = 0; i < a; i++)
            {
                tmpbars[i].Colour = tmp[i];
            }

            //transfer colours from ordered bars to original bars
            foreach (var item in tmpbars)
            {
                bars.Single(z => z.Value == item.Value).Colour = item.Colour;
            }

            //return
            return bars;
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

        //uses invoke to update ui elements text property from a different thread
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

        //uses invoke to update ui code from a different thread
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

        //uses invoke to update highlighted lines of code from a different thread
        public void UpdateBox(int line, int line2)
        {
            try
            {
                if (!InvokeRequired)
                {
                    //need to scroll?
                    bool scroll = false;
                    //character locations of start and end of highlight
                    var startIndex = TB_Info.GetFirstCharIndexFromLine(line - 1);
                    var endIndex = TB_Info.GetFirstCharIndexFromLine(line2);

                    //if the highlighted lines are above previously highlighted ("off screen") then scroll
                    if (TB_Info.SelectionStart > startIndex)
                    {
                        scroll = true;
                    }

                    //highlight
                    TB_Info.Select(startIndex, (endIndex - 1) - startIndex);
                    //refresh ui element
                    TB_Info.Refresh();
                    //give element focus
                    TB_Info.Focus();

                    //if needed scroll to the right location
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

        //uses invoke to update  the operations counter from a different thread
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

        //Draw All the outlines
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

        //draw a specific bars outline
        private void DrawOutline(Bar bar)
        {
            var x = new Pen(Color.Black, bar.Width / 8);
            Graphics.DrawRectangle(x, new Rectangle((bar.Width * bar.Pos) + ((bar.Width / 8) / 2), 40, bar.Width - ((bar.Width / 8)), bar.Height));
        }

        //Draw specific bar from position
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

        //highlights a bar at position
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
            //if foreground, play sound
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

            //clear and redraw
            ClearBar(bar1.Pos);
            ClearBar(bar2.Pos);
            DrawBar(bar1);
            DrawBar(bar2);
        }

        ////////////
        // Events //
        ////////////

        //tell algorithm object to begin closing
        private void OutputScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.algorithm.Close();
        }

        //if minimised and resumed draw back the bars (bug fix)
        private void OutputScreen_Resize(object sender, EventArgs e)
        {
            if (algorithm != null)
            {
                if (WindowState != FormWindowState.Minimized)
                {
                    if (issorting)
                    {
                        DrawBars();
                    }
                    else
                    {
                        OutlineBars();
                        algorithm.HighlightAll();
                    }
                }
                else if (!paused) //when minimised pause the solution (just an extra feature)
                {
                    algorithm.Chill();
                    algorithm.TogglePause(paused);
                    BT_Pause.Text = "Resume";
                    paused = true;
                    BT_Step.Enabled = true;
                }
            }
        }

        /////////////
        // Buttons //
        /////////////

        private void BT_Pause_Click(object sender, EventArgs e)
        {
            //if paused resume
            if (paused)
            {
                //slow down
                algorithm.Chill();
                //resume
                algorithm.TogglePause(paused);
                //change text on button
                BT_Pause.Text = "Pause";

                //if focused play sound
                if (this.ContainsFocus)
                {
                    snd_button.Play();
                }

                //update states
                paused = false;
                step = false;

                //ensure stepping is false in algorithm
                algorithm.ToggleStepping(step);

                //disable step button
                BT_Step.Enabled = false;
            }
            //pause
            else
            {
                //slow down
                algorithm.Chill();
                //resume
                algorithm.TogglePause(paused);
                //change text on button
                BT_Pause.Text = "Resume";

                //if focused play sound
                if (this.ContainsFocus)
                {
                    snd_button.Play();
                }

                //update states
                paused = true;
                BT_Step.Enabled = true;
            }
        }

        private void BT_Step_Click(object sender, EventArgs e)
        {
            //if already stepping take next step
            if (step)
            {
                snd_button.Play();
                algorithm.NextStep();
            }
            //change to stepping state and step
            else
            {
                snd_button.Play();
                step = true;
                algorithm.ToggleStepping(step);
            }
        }

        ////////////////
        // Algorithms //
        ////////////////

        private void BackgroundWorker1_Sort(object sender, DoWorkEventArgs e)
        {
            //get ref to self to pass
            var me = this;
            //mark thread as background
            Thread.CurrentThread.IsBackground = true;

            //assign algorithm object to selected sort
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

            //update ui with space and time complexity
            UpdateControl(LB_Space, algorithm.data.space);
            UpdateControl(LB_Time, algorithm.data.time);

            //run algorithm
            if (ascending)
                algorithm.Ascending(input);
            else
                algorithm.Descending(input);

            //after completion disable the pause button
            Action x = delegate
            {
                BT_Pause.Text = "Complete";
                BT_Pause.Enabled = false;
            };
            try
            {
                //display window informing that it is complete
                Invoke(x);
                MessageBox.Show($"Sorting Completed", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DrawBars();
            }
            catch { }
        }

        private void BackgroundWorker2_Search(object sender, DoWorkEventArgs e)
        {
            //get ref to self to pass
            var me = this;
            //mark thread as background
            Thread.CurrentThread.IsBackground = true;
            //draw line outlines
            OutlineBars();

            //update ui with target
            Action y = delegate
            {
                TB_SearchFor.Text = target.ToString();
            };
            Invoke(y);

            //assign algorithm object to selected search
            switch (searching)
            {
                case Searching.Interpolation:
                    algorithm = new Interpolation(ref me, time);
                    break;
                default:
                    break;
            }

            //update ui with space and time complexity
            UpdateControl(LB_Space, algorithm.data.space);
            UpdateControl(LB_Time, algorithm.data.time);

            //run search
            var result = algorithm.Search(input, target);

            //after completion disable the pause button
            Action x = delegate
            {
                TB_Result.Text = result;
                BT_Pause.Text = "Complete";
                BT_Pause.Enabled = false;
            };
            try
            {
                //display window informing that it is complete
                Invoke(x);
                MessageBox.Show($"Search Completed", result, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch { }

        }


    }
}
