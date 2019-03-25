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
        SoundPlayer snd_button = new SoundPlayer("Button.wav");
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
            if (Math.Abs(decimal.Parse(tb_max.Text) - decimal.Parse(tb_min.Text)) < decimal.Parse(tb_arraysize.Text))
            {
                tb_max.Text = (decimal.Parse(tb_min.Text) + decimal.Parse(tb_arraysize.Text)).ToString();
            }

            GenerateArray();
        }

        private void GenerateArray()
        {
            array = new Decimal[int.Parse(tb_arraysize.Text)];
            var numbers = new List<decimal>();
            switch (cb_decimals.Checked)
            {
                case true:
                    while (numbers.Count() < array.Length)
                    {
                        numbers.Add(((Decimal)r.Next(int.Parse(tb_min.Text) * 100, int.Parse(tb_max.Text) * 100)) / 100);
                        var tmp = numbers.Distinct().ToList();
                        numbers.Clear();
                        numbers.AddRange(tmp);
                    }
                    break;
                case false:
                    while (numbers.Count() < array.Length)
                    {
                        numbers.Add(r.Next(int.Parse(tb_min.Text), int.Parse(tb_max.Text)));
                        var tmp = numbers.Distinct().ToList();
                        numbers.Clear();
                        numbers.AddRange(tmp);
                    }
                    break;
                default:
                    break;
            }
            array = numbers.ToArray();
            tb_array.Text = string.Join(", ", array);
            tb_realmax.Text = array.Max().ToString();
            tb_realmin.Text = array.Min().ToString();
            tb_searchfor.Text = array[r.Next(array.Count())].ToString();
        }

        private void BT_Bubble_Click(object sender, EventArgs e)
        {
            WorkerThread = delegate
            {
                snd_button.Play();
            };
            BeginInvoke(WorkerThread);
            //Create new output window
            if (rb_ascending.Checked)
            {
                FormThread = delegate
                {
                    Form = new OutputScreen(array, Sorting.Bubble, true, int.Parse(tb_time.Text))
                    {
                        Text = "Output Bubble Sort Ascending"
                    };
                };
                BeginInvoke(FormThread);
            }
            else
            {
                FormThread = delegate
                {
                    Form = new OutputScreen(array, Sorting.Bubble, false, int.Parse(tb_time.Text))
                    {
                        Text = "Output Bubble Sort Descending"
                    };
                };
                BeginInvoke(FormThread);
            }
        }

        private void BT_Heap_Click(object sender, EventArgs e)
        {
            WorkerThread = delegate
            {
                snd_button.Play();
            };
            BeginInvoke(WorkerThread);
            //Create new output window
            if (rb_ascending.Checked)
            {
                FormThread = delegate
                {
                    Form = new OutputScreen(array, Sorting.Heap, true, int.Parse(tb_time.Text))
                    {
                        Text = "Output Heap Sort Ascending"
                    };
                };
                BeginInvoke(FormThread);
            }
            else
            {
                FormThread = delegate
                {
                    Form = new OutputScreen(array, Sorting.Heap, false, int.Parse(tb_time.Text))
                    {
                        Text = "Output Heap Sort Descending"
                    };
                };
                BeginInvoke(FormThread);
            }
        }

        private void BT_Quick_Click(object sender, EventArgs e)
        {
            WorkerThread = delegate
            {
                snd_button.Play();
            };
            BeginInvoke(WorkerThread);
            //Create new output window
            if (rb_ascending.Checked)
            {
                FormThread = delegate
                {
                    Form = new OutputScreen(array, Sorting.Quick, true, int.Parse(tb_time.Text))
                    {
                        Text = "Output Quick Sort Ascending"
                    };
                };
                BeginInvoke(FormThread);
            }
            else
            {
                FormThread = delegate
                {
                    Form = new OutputScreen(array, Sorting.Quick, false, int.Parse(tb_time.Text))
                    {
                        Text = "Output Quick Sort Descending"
                    };
                };
                BeginInvoke(FormThread);
            }
        }

        private void BT_Merge_Click(object sender, EventArgs e)
        {
            WorkerThread = delegate
            {
                snd_button.Play();
            };
            BeginInvoke(WorkerThread);
            //Create new output window
            if (rb_ascending.Checked)
            {
                FormThread = delegate
                {
                    Form = new OutputScreen(array, Sorting.Merge, true, int.Parse(tb_time.Text))
                    {
                        Text = "Output Merge Sort Ascending"
                    };
                };
                BeginInvoke(FormThread);
            }
            else
            {
                FormThread = delegate
                {
                    Form = new OutputScreen(array, Sorting.Merge, false, int.Parse(tb_time.Text))
                    {
                        Text = "Output Merge Sort Descending"
                    };
                };
                BeginInvoke(FormThread);
            }
        }

        private void BT_Insertion_Go_Click(object sender, EventArgs e)
        {
            WorkerThread = delegate
            {
                snd_button.Play();
            };
            BeginInvoke(WorkerThread);
            //Create new output window
            if (rb_ascending.Checked)
            {
                FormThread = delegate
                {
                    Form = new OutputScreen(array, Sorting.Insertion, true, int.Parse(tb_time.Text))
                    {
                        Text = "Output Insertion Sort Ascending"
                    };
                };
                BeginInvoke(FormThread);
            }
            else
            {

                FormThread = delegate
                {
                    Form = new OutputScreen(array, Sorting.Insertion, false, int.Parse(tb_time.Text))
                    {
                        Text = "Output Insertion Sort Descending"
                    };
                };
                BeginInvoke(FormThread);
            }
        }

        private void Bt_interpolation_Click(object sender, EventArgs e)
        {

            WorkerThread = delegate
            {
                snd_button.Play();
            };
            BeginInvoke(WorkerThread);
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
                Form = new OutputScreen(array, Searching.Interpolation, decimal.Parse(tb_searchfor.Text), int.Parse(tb_time.Text))
                {
                    Text = "Output Interpolation Search"
                };
            };
            BeginInvoke(FormThread);
        }

        private void tb_max_TextChanged(object sender, EventArgs e)
        {
            if (decimal.Parse(tb_max.Text) < decimal.Parse(tb_min.Text))
            {
                var tmp = tb_max.Text;
                tb_max.Text = tb_min.Text;
                tb_min.Text = tmp;
            }

            if (Math.Abs(decimal.Parse(tb_max.Text) - decimal.Parse(tb_min.Text)) < decimal.Parse(tb_arraysize.Text))
            {
                tb_max.Text = (decimal.Parse(tb_min.Text) + decimal.Parse(tb_arraysize.Text)).ToString();
            }

            GenerateArray();
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

    public class Data
    {
        public string time = "";
        public string space = "";
    }
}
