using Group_24_Animated_Algorithms.Sorting_Algorithms.Bubble;
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
    public partial class Input : Form
    {
        private Decimal[] array;
        private Random r = new Random();

        public Input()
        {
            InitializeComponent();
            rb_ascending.Checked = true;
        }


        private void Bt_Bubble_Click(object sender, EventArgs e)
        {
            if (rb_ascending.Checked)
            {
                var BubbleObj = new Bubble.Ascending(array);
            }
            else
            {
                var BubbleObj = new Bubble.Descending(array);
            }
            
        }

        private void Bt_GenerateArray_Click(object sender, EventArgs e)
        {
            array = new Decimal[int.Parse(tb_arraysize.Text)];

            for (int i = 0; i < int.Parse(tb_arraysize.Text); i++)
            {
                switch (cb_decimals.Checked)
                {
                    case true:
                        array[i] = ((Decimal)r.Next(int.Parse(tb_min.Text)*100, int.Parse(tb_max.Text)*100))/100;
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
        }
    }
}
