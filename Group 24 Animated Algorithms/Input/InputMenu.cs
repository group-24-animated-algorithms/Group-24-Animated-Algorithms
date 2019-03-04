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
using System.Threading;
using Group_24_Animated_Algorithms.Output;

namespace Group_24_Animated_Algorithms
{

    public partial class Input : Form
    {
        private Decimal[] array;
        private Random r = new Random();
        SoundPlayer splayer = new SoundPlayer("button21.wav");
        Action WorkerThread;
        Action FormThread;
        OutputScreen Form;

        public Input()
        {
            InitializeComponent();
            rb_ascending.Checked = true;
            GenerateArray();
        }

        private void BT_GenerateArray_Click(object sender, EventArgs e)
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

        private void Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Enabled = true;
        }

        private void BT_Bubble_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            //Create new output window
            if (rb_ascending.Checked)
            {
                FormThread = delegate
                {
                    Form = new OutputScreen(array, Sorting.Bubble, true)
                    {
                        Text = "Output Bubble Sort Ascending"
                    };
                    Form.FormClosed += Form_FormClosed;
                };
                BeginInvoke(FormThread);

                WorkerThread = delegate
                {
                    splayer.Play();
                };
                BeginInvoke(WorkerThread);
            }
            else
            {
                FormThread = delegate
                {
                    Form = new OutputScreen(array, Sorting.Bubble, false)
                    {
                        Text = "Output Bubble Sort Descending"
                    };
                    Form.FormClosed += Form_FormClosed;
                };
                BeginInvoke(FormThread);

                WorkerThread = delegate
                {
                    splayer.Play();
                };
                BeginInvoke(WorkerThread);
            }
        }

        private void BT_Heap_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            //Create new output window
            if (rb_ascending.Checked)
            {
                FormThread = delegate
                {
                    Form = new OutputScreen(array, Sorting.Heap, true)
                    {
                        Text = "Output Heap Sort Ascending"
                    };
                    Form.FormClosed += Form_FormClosed;
                };
                BeginInvoke(FormThread);

                WorkerThread = delegate
                {
                    splayer.Play();
                };
                BeginInvoke(WorkerThread);
            }
            else
            {
                FormThread = delegate
                {
                    Form = new OutputScreen(array, Sorting.Heap, false)
                    {
                        Text = "Output Heap Sort Descending"
                    };
                    Form.FormClosed += Form_FormClosed;
                };
                BeginInvoke(FormThread);

                WorkerThread = delegate
                {
                    splayer.Play();
                };
                BeginInvoke(WorkerThread);
            }
        }

        private void BT_Quick_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            //Create new output window
            if (rb_ascending.Checked)
            {
                FormThread = delegate
                {
                    Form = new OutputScreen(array, Sorting.Quick, true)
                    {
                        Text = "Output Quick Sort Ascending"
                    };
                    Form.FormClosed += Form_FormClosed;
                };
                BeginInvoke(FormThread);

                WorkerThread = delegate
                {
                    splayer.Play();
                };
                BeginInvoke(WorkerThread);
            }
            else
            {
                FormThread = delegate
                {
                    Form = new OutputScreen(array, Sorting.Quick, false)
                    {
                        Text = "Output Quick Sort Descending"
                    };
                    Form.FormClosed += Form_FormClosed;
                };
                BeginInvoke(FormThread);

                WorkerThread = delegate
                {
                    splayer.Play();
                };
                BeginInvoke(WorkerThread);
            }
        }

        private void BT_Merge_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            //Create new output window
            if (rb_ascending.Checked)
            {
                FormThread = delegate
                {
                    Form = new OutputScreen(array, Sorting.Merge, true)
                    {
                        Text = "Output Merge Sort Ascending"
                    };
                    Form.FormClosed += Form_FormClosed;
                };
                BeginInvoke(FormThread);

                WorkerThread = delegate
                {
                    splayer.Play();
                };
                BeginInvoke(WorkerThread);
            }
            else
            {
                FormThread = delegate
                {
                    Form = new OutputScreen(array, Sorting.Merge, false)
                    {
                        Text = "Output Merge Sort Descending"
                    };
                    Form.FormClosed += Form_FormClosed;
                };
                BeginInvoke(FormThread);
                WorkerThread = delegate
                {
                    splayer.Play();
                };
                BeginInvoke(WorkerThread);
            }
        }

        private void BT_Insertion_Go_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            //Create new output window
            if (rb_ascending.Checked)
            {
                FormThread = delegate
                {
                    Form = new OutputScreen(array, Sorting.Insertion, true)
                    {
                        Text = "Output Insertion Sort Ascending"
                    };
                    Form.FormClosed += Form_FormClosed;
                };
                BeginInvoke(FormThread);

                WorkerThread = delegate
                {
                    splayer.Play();
                };
                BeginInvoke(WorkerThread);
            }
            else
            {
                FormThread = delegate
                {
                    Form = new OutputScreen(array, Sorting.Insertion, false)
                    {
                        Text = "Output Insertion Sort Descending"
                    };
                    Form.FormClosed += Form_FormClosed;
                };
                BeginInvoke(FormThread);

                WorkerThread = delegate
                {
                    splayer.Play();
                };
                BeginInvoke(WorkerThread);
            }
        }

        private void Bt_interpolation_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            FormThread = delegate
            {
                Array.Sort(array);

                tb_array.Text = string.Join(", ", array);

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
                Form = new OutputScreen(array, Sorting.Insertion, true)
                {
                    Text = "Output Interpolation Search"
                };
                Form.FormClosed += Form_FormClosed;
            };
            BeginInvoke(FormThread);

            WorkerThread = delegate
            {
                splayer.Play();
            };
            BeginInvoke(WorkerThread);
        }
    }

    public enum Sorting
    {
        Bubble = 1,
        Quick = 2,
        Heap = 3,
        Merge = 4,
        Insertion = 5,
    }

    public enum Searching
    {
        Interpolation = 1
    }
}
