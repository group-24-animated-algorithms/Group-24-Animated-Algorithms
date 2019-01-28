using Group_24_Animated_Algorithms.Output;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
        //Value holding variables

        //List holds all the bars
        private List<Bar> bars = new List<Bar>();
        //Variable holds the base width of the bars
        private int barWidth;
        //Variables hold inputs min and max (old scale)
        private int min;
        private int max;
        //Graphics
        Graphics Graphics;
        SolidBrush MainBrush = new SolidBrush(Color.Blue);
        SolidBrush SelectBrush = new SolidBrush(Color.Red);
        SolidBrush Backbrush;

        //Editable properties

        //Variables hold new scale
        const int newMin = 10;
        const int newMax = 400;
        //Variable holds min bar width
        const int minWidth = 5;
        //how long you want to hover over a highlighted bar 
        const int miliseconds = 50;

        //Constructor
        public OutputScreen(Decimal[] Input)
        {
            InitializeComponent(); //Build in, for GUI
            this.SetStyle(
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.UserPaint |
                ControlStyles.OptimizedDoubleBuffer, true);
            this.UpdateStyles();

            //Set the width of the bars so that they sill the screen
            barWidth = Input.Count() / this.Width;

            //Set min and max values
            min = (int)Input.Min();
            max = (int)Input.Max();

            //If <newWidth px width resize the window to fit them all with newWidth px
            if (barWidth < minWidth)
            {
                barWidth = minWidth;
                this.Width = Input.Count() * minWidth + (barWidth * 2);
            }

            //Create bar objects from array and all them to a list
            bars = ArrayToBarList(Input);

            Backbrush = new SolidBrush(this.BackColor);
            Graphics = CreateGraphics();
            Graphics.BeginContainer();
            Graphics.ScaleTransform(1.0F, -1.0F);
            Graphics.TranslateTransform(0.0F, -(float)Height);
        }

        //Destructor 
        ~OutputScreen()
        {
            MainBrush.Dispose();
            Graphics.Dispose();
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

        public void UpdateOperations(int value)
        {
            lb_operations.Text = $"Number of operations: {value}";
            lb_operations.Refresh();
        }

        public void DrawBars()
        {
            foreach (var item in bars)
            {
                DrawBar(item);
            }
        }

        private void Clear()
        {
            Graphics.Clear(this.BackColor);
            Graphics.Flush(System.Drawing.Drawing2D.FlushIntention.Sync);
        }

        private void DrawBar(Bar bar)
        {
            Graphics.FillRectangle(MainBrush, new Rectangle(bar.Width * bar.Pos, 0, bar.Width, bar.Height));
            Graphics.Flush(System.Drawing.Drawing2D.FlushIntention.Sync);
        }

        private void ClearBar(int pos)
        {
            Graphics.FillRectangle(Backbrush, new Rectangle(minWidth * pos, 0, minWidth, Height));
            Graphics.Flush(System.Drawing.Drawing2D.FlushIntention.Sync);
        }

        private void CurrentBar(Bar bar)
        {
            Graphics.FillRectangle(SelectBrush, new Rectangle(bar.Width * bar.Pos, 0, bar.Width, bar.Height));
            Graphics.Flush(System.Drawing.Drawing2D.FlushIntention.Sync);
        }

        public void HighlightBar(int pos)
        {
            var bar = bars.Single(x => x.Pos == pos);
            Graphics.FillRectangle(SelectBrush, new Rectangle(bar.Width * bar.Pos, 0, bar.Width, bar.Height));
            Graphics.Flush(System.Drawing.Drawing2D.FlushIntention.Sync);
            System.Threading.Thread.Sleep(miliseconds);
            Graphics.FillRectangle(MainBrush, new Rectangle(bar.Width * bar.Pos, 0, bar.Width, bar.Height));
            Graphics.Flush(System.Drawing.Drawing2D.FlushIntention.Sync);
        }

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
    }

}
