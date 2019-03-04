using Group_24_Animated_Algorithms.Output;
using Group_24_Animated_Algorithms.Searching_Algorithms;
using Group_24_Animated_Algorithms.Sorting_Algorithms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
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
        bool isSorting;
        int target;

        //Variable holds the base width of the bars
        private int barWidth;

        //Variables hold inputs min and max (old scale)
        private int min;
        private int max;

        //Graphics
        Graphics Graphics;
        SolidBrush Backbrush;

        //Editable past this point
        SolidBrush MainBrush = new SolidBrush(Color.Blue);
        SolidBrush SelectBrush = new SolidBrush(Color.Red);

        //Variables hold new scale
        const int newMin = 10;
        const int newMax = 400;

        //Side margin
        const int marginRight = 300;

        //Variable holds min bar width
        const int minWidth = 5;
        //how long you want to hover over a highlighted bar 
        const int miliseconds = 50;

        //////////////////
        // Constructors //
        //////////////////
        
        //Sorting Constructor
        public OutputScreen(Decimal[] Input, Sorting Sorting, bool Ascending)
        {
            input = Input;
            sorting = Sorting;
            ascending = Ascending;
            isSorting = true;

            InitializeComponent(); //Build in, for GUI
            Init();

            var me = this;

            switch (sorting)
            {
                //Bubble
                case Sorting.Bubble:
                    var Bubble = new Bubble(ref me);
                    if (ascending)
                        Bubble.Ascending(input);
                    else
                        Bubble.Descending(input);
                    break;

                //Quick
                case Sorting.Quick:
                    var Quick = new Quick(ref me);
                    if (ascending)
                        Quick.Ascending(input);
                    else
                        Quick.Descending(input);
                    break;
                
                //Heap
                case Sorting.Heap:
                    var Heap = new Heap(ref me);
                    if (ascending)
                        Heap.Ascending(input);
                    else
                        Heap.Descending(input);
                    break;

                //Merge
                case Sorting.Merge:
                    var Merge = new Merge(ref me);
                    if (ascending)
                        Merge.Ascending(input);
                    else
                        Merge.Descending(input);
                    break;

                //Insertion
                case Sorting.Insertion:
                    var Insertion = new Insertion(ref me);
                    if (ascending)
                        Insertion.Ascending(input);
                    else
                        Insertion.Descending(input);
                    break;

                default:
                    break;
            }

            DrawBars();
        }
        //Searching Constructor
        public OutputScreen(Decimal[] Input, Searching Searching, int Target)
        {
            input = Input;
            searching = Searching;
            target = Target;
            isSorting = false;

            InitializeComponent(); //Build in, for GUI
            Init();

            var me = this;

            grp_result.Enabled = true;
            switch (searching)
            {
                case Searching.Interpolation:
                    var search = new Interpolation(ref me);
                    TB_Result.Text = search.ISearch(Input, 0, Input.Count() - 1, (decimal)target);
                    break;
                default:
                    break;
            }
        }

        //Destructor 
        ~OutputScreen()
        {
            MainBrush.Dispose();
            Graphics.Dispose();
        }

        //Setup the window width height etc.
        private void Init()
        { 

            this.UpdateStyles();

            //Set the width of the bars so that they sill the screen
            barWidth = input.Count() / this.Width;

            //Set min and max values
            min = (int)input.Min();
            max = (int)input.Max();

            //If <newWidth px width resize the window to fit them all with newWidth px
            if (barWidth < minWidth)
            {
                barWidth = minWidth;
                this.Width = (input.Count() * minWidth) + (barWidth * 2) + marginRight;
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

        //Updates the Text on output window
        public void UpdateInfo(string info, string code)
        {
            this.TB_Info.Text = info;
            this.TB_How.Text = code;
            TB_How.Refresh();
            TB_Info.Refresh();
        }

        //Updates the operations counter
        public void UpdateOperations(int value)
        {
            tb_operations.Text = value.ToString();
            tb_operations.Refresh();
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
        
        //Draw specific bar
        private void DrawBar(Bar bar)
        {
            Graphics.FillRectangle(MainBrush, new Rectangle(bar.Width * bar.Pos, 0, bar.Width, bar.Height));
            //Graphics.Flush(System.Drawing.Drawing2D.FlushIntention.Sync);
        }

        //Remove bar at position
        private void ClearBar(int pos)
        {
            Graphics.FillRectangle(Backbrush, new Rectangle(minWidth * pos, 0, minWidth, Height));
            //Graphics.Flush(System.Drawing.Drawing2D.FlushIntention.Sync);
        }

        //Draw specific bar
        private void CurrentBar(Bar bar)
        {
            Graphics.FillRectangle(SelectBrush, new Rectangle(bar.Width * bar.Pos, 0, bar.Width, bar.Height));
            //Graphics.Flush(System.Drawing.Drawing2D.FlushIntention.Sync);
        }

        //highlights a bar
        public void HighlightBar(int pos)
        {
            var bar = bars.Single(x => x.Pos == pos);
            Graphics.FillRectangle(SelectBrush, new Rectangle(bar.Width * bar.Pos, 0, bar.Width, bar.Height));
            //Graphics.Flush(System.Drawing.Drawing2D.FlushIntention.Sync);
            Graphics.FillRectangle(MainBrush, new Rectangle(bar.Width * bar.Pos, 0, bar.Width, bar.Height));
            //Graphics.Flush(System.Drawing.Drawing2D.FlushIntention.Sync);
        }

        //swaps two bars positions
        public void SwapBars(int CurrentPos, Decimal Val, int NewPos, Decimal NewVal)
        {
            //store the bars
            var bar1 = bars.Single(x => x.Pos == CurrentPos && x.Value == Val);
            var bar2 = bars.Single(x => x.Pos == NewPos && x.Value == NewVal);

            //if they're the same dont try swap
            if (bar1.Pos == bar2.Pos && bar1.Value == bar2.Value)
            {
                return;
            }

            CurrentBar(bar1);
            CurrentBar(bar2);

            //move 1st bar to tmp pos
            bars.Single(x => x.Pos == CurrentPos && x.Value == Val).Pos = -1;
            //move over 2nd bar
            bars.Single(x => x.Pos == NewPos && x.Value == NewVal).Pos = CurrentPos;
            //move over 1st bar
            bars.Single(x => x.Pos == -1 && x.Value == Val).Pos = NewPos;

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

        }
    }

}
