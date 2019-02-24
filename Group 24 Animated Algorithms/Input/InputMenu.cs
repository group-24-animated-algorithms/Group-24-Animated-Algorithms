using Group_24_Animated_Algorithms.Sorting_Algorithms;
using Group_24_Animated_Algorithms.Searching_Algorithms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Group_24_Animated_Algorithms
{
    public partial class Input : Form
    {
        private Decimal[] array;
        private Random r = new Random();
        SoundPlayer splayer = new SoundPlayer("button21.wav");
        int waitbeforeclose = 2000;

        public Input()
        {
            InitializeComponent();
            rb_ascending.Checked = true;
            GenerateArray();
        }

        private void Bt_GenerateArray_Click(object sender, EventArgs e)
        {
            GenerateArray();
        }

        private void GenerateArray()
        {
            array = new Decimal[int.Parse(tb_arraysize.Text)];

            for (int i = 0; i < int.Parse(tb_arraysize.Text); i++)
            {
                switch (cb_decimals.Checked)
                {
                    case true:
                        array[i] = ((Decimal)r.Next(int.Parse(tb_min.Text) * 100, int.Parse(tb_max.Text) * 100)) / 100;
                        break;
                    case false:
                        array[i] = r.Next(int.Parse(tb_min.Text), int.Parse(tb_max.Text));
                        break;
                    default:
                        break;
                }
            }

            tb_array.Text = string.Join(", ", array);
            tb_realmax.Text = array.Max().ToString();
            tb_realmin.Text = array.Min().ToString();
            tb_searchfor.Text = array[r.Next(array.Count())].ToString();
        }

        private void Bt_Bubble_Click(object sender, EventArgs e)
        {
            //Create new output window
            OutputScreen OutputWin = new OutputScreen(array) { Text = "Output Bubble Sort Ascending" };
            OutputWin.Show();
            OutputWin.DrawBars();

            if (rb_ascending.Checked)
            {
                splayer.Play();
                var BubbleObj = new Bubble.Ascending(array, ref OutputWin);
            }
            else
            {
                splayer.Play();
                var BubbleObj = new Bubble.Descending(array, ref OutputWin);
            }
            System.Threading.Thread.Sleep(waitbeforeclose);
            OutputWin.Close();
        }

        private void Bt_Heap_Click(object sender, EventArgs e)
        {
            //Create new output window
            OutputScreen OutputWin = new OutputScreen(array) { Text = "Output Bubble Sort Ascending" };
            OutputWin.Show();
            OutputWin.DrawBars();

            if (rb_ascending.Checked)
            {
                splayer.Play();
                var HeapObj = new Heap.Ascending(array, ref OutputWin);
            }
            else
            {
                splayer.Play();
                var HeapObj = new Heap.Descending(array, ref OutputWin);
            }
            System.Threading.Thread.Sleep(waitbeforeclose);
            OutputWin.Close();
        }

        private void Bt_Interpolation_ClickAsync(object sender, EventArgs e)
        {
            splayer.Play();
            Array.Sort(array);
            tb_array.Text = string.Join(", ", array);

            //Create new output window
            OutputScreen OutputWin = new OutputScreen(array) { Text = "Output Bubble Sort Ascending" };
            OutputWin.Show();
            OutputWin.DrawBars();

            if (this.tb_searchfor.Text == "")
            {
                this.tb_searchfor.Text = array[r.Next(array.Count())].ToString();
            }
            try
            {
                decimal.Parse(this.tb_searchfor.Text);
            }
            catch (Exception)
            {
                return;
            }
            int c = 0;
            var search = new Interpolation();
            this.tb_searchresult.Text = search.ISearch(array, 0, array.Count()-1, decimal.Parse(this.tb_searchfor.Text), ref c, ref OutputWin);
            System.Threading.Thread.Sleep(waitbeforeclose);
            OutputWin.Close();
        }

        private void Bt_quick_Click(object sender, EventArgs e)
        {
            splayer.Play();

        }

        private void Bt_merge_Click(object sender, EventArgs e)
        {
            splayer.Play();

        }

        private void bt_insertion_go_Click(object sender, EventArgs e)
        {
            if (rb_ascending.Checked)
            {
                splayer.Play();
                var InsertionObj = new Insertion.Ascending(array);
            }
            else
            {
                splayer.Play();
                var InsertionObj = new Insertion.Descending(array);
            }
        }
    }
}
