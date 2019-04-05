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
        ///////////////
        // Variables //
        ///////////////
        //array holder
        private Decimal[] array;
        //random
        private Random r = new Random();
        //button sound
        SoundPlayer snd_button = new SoundPlayer("Button.wav");
        //Action holders for threading
        Action WorkerThread;
        Action FormThread;
        //output ref holder
        OutputScreen Form;

        /////////////////
        // Constructor //
        /////////////////
        public Input()
        {
            //basic init
            InitializeComponent();
            //check ascending by default
            rb_ascending.Checked = true;
            //generate a new array
            GenerateArray();
            Bar_Speed.Value = 500;
        }

        ///////////////
        // Functions //
        ///////////////

        private void Changeminmax()
        {
            //if the difference between the min and max is greater than the amount of numbers in the array increase max size
            if (Math.Abs(decimal.Parse(tb_max.Text) - decimal.Parse(tb_min.Text)) < decimal.Parse(tb_arraysize.Text))
            {
                tb_max.Text = (decimal.Parse(tb_min.Text) + decimal.Parse(tb_arraysize.Text)).ToString();
            }
        }

        private void GenerateArray()
        {
            //init array
            array = new Decimal[int.Parse(tb_arraysize.Text)];
            //create a list to hold numbers
            var numbers = new List<decimal>();
            //check if decimals
            switch (cb_decimals.Checked)
            {
                case true:
                    //until array is full
                    while (numbers.Count() < array.Length)
                    {
                        //add random number in min-max
                        numbers.Add(((Decimal)r.Next(int.Parse(tb_min.Text) * 100, int.Parse(tb_max.Text) * 100)) / 100);
                        //make list distinct
                        var tmp = numbers.Distinct().ToList();
                        //clear and reasign list
                        numbers.Clear();
                        numbers.AddRange(tmp);
                    }
                    break;
                case false:
                    //until array is full
                    while (numbers.Count() < array.Length)
                    {
                        //add random number in min-max
                        numbers.Add(r.Next(int.Parse(tb_min.Text), int.Parse(tb_max.Text)));
                        //make list distinct
                        var tmp = numbers.Distinct().ToList();
                        //clear and reasign list
                        numbers.Clear();
                        numbers.AddRange(tmp);
                    }
                    break;
                default:
                    break;
            }
            //assign list to array
            array = numbers.ToArray();
            //write array to ui
            tb_array.Text = string.Join(", ", array);
            tb_realmax.Text = array.Max().ToString();
            tb_realmin.Text = array.Min().ToString();
            //find random number in array to search for
            tb_searchfor.Text = array[r.Next(array.Count())].ToString();
        }

        ////////////
        // Events //
        ////////////

        private void Tb_Max_TextChanged(object sender, EventArgs e)
        {
            //if min is greater than max, swap
            if (decimal.Parse(tb_max.Text) < decimal.Parse(tb_min.Text))
            {
                var tmp = tb_max.Text;
                tb_max.Text = tb_min.Text;
                tb_min.Text = tmp;
            }

            //swap if needed
            Changeminmax();
        }
        ///////////////////
        // Button Events //
        ///////////////////

        //Generate array
        private void BT_GenerateArray_Click(object sender, EventArgs e)
        {
            //Change mins and maximums in case of errors
            Changeminmax();

            //Generate new array
            GenerateArray();
        }

        //Bubble sort
        private void BT_Bubble_Click(object sender, EventArgs e)
        {
            //play sound in seperate thread
            WorkerThread = delegate
            {
                snd_button.Play();
            };
            BeginInvoke(WorkerThread);

            //Create new output window ascending
            if (rb_ascending.Checked)
            {
                FormThread = delegate
                {
                    Form = new OutputScreen(array, Sorting.Bubble, true, Bar_Speed.Value)
                    {
                        Text = "Output Bubble Sort Ascending"
                    };
                };
                BeginInvoke(FormThread);
            }
            //Create new output window descending
            else
            {
                FormThread = delegate
                {
                    Form = new OutputScreen(array, Sorting.Bubble, false, Bar_Speed.Value)
                    {
                        Text = "Output Bubble Sort Descending"
                    };
                };
                BeginInvoke(FormThread);
            }
            GenerateArray();
        }

        //Heap sort
        private void BT_Heap_Click(object sender, EventArgs e)
        {
            //play sound in seperate thread
            WorkerThread = delegate
            {
                snd_button.Play();
            };
            BeginInvoke(WorkerThread);

            //Create new output window ascending
            if (rb_ascending.Checked)
            {
                FormThread = delegate
                {
                    Form = new OutputScreen(array, Sorting.Heap, true, Bar_Speed.Value)
                    {
                        Text = "Output Heap Sort Ascending"
                    };
                };
                BeginInvoke(FormThread);
            }
            //Create new output window descending
            else
            {
                FormThread = delegate
                {
                    Form = new OutputScreen(array, Sorting.Heap, false, Bar_Speed.Value)
                    {
                        Text = "Output Heap Sort Descending"
                    };
                };
                BeginInvoke(FormThread);
            }
            GenerateArray();
        }

        //Quick sort
        private void BT_Quick_Click(object sender, EventArgs e)
        {
            //play sound in seperate thread
            WorkerThread = delegate
            {
                snd_button.Play();
            };
            BeginInvoke(WorkerThread);

            //Create new output window ascending
            if (rb_ascending.Checked)
            {
                FormThread = delegate
                {
                    Form = new OutputScreen(array, Sorting.Quick, true, Bar_Speed.Value)
                    {
                        Text = "Output Quick Sort Ascending"
                    };
                };
                BeginInvoke(FormThread);
            }
            //Create new output window descending
            else
            {
                FormThread = delegate
                {
                    Form = new OutputScreen(array, Sorting.Quick, false, Bar_Speed.Value)
                    {
                        Text = "Output Quick Sort Descending"
                    };
                };
                BeginInvoke(FormThread);
            }
            GenerateArray();
        }

        //Merge sort
        private void BT_Merge_Click(object sender, EventArgs e)
        {
            //play sound in seperate thread
            WorkerThread = delegate
            {
                snd_button.Play();
            };
            BeginInvoke(WorkerThread);
            //Create new output window ascending
            if (rb_ascending.Checked)
            {
                FormThread = delegate
                {
                    Form = new OutputScreen(array, Sorting.Merge, true, Bar_Speed.Value)
                    {
                        Text = "Output Merge Sort Ascending"
                    };
                };
                BeginInvoke(FormThread);
            }
            //Create new output window descending
            else
            {
                FormThread = delegate
                {
                    Form = new OutputScreen(array, Sorting.Merge, false, Bar_Speed.Value)
                    {
                        Text = "Output Merge Sort Descending"
                    };
                };
                BeginInvoke(FormThread);
            }
            GenerateArray();
        }

        private void Bt_Gnome_Click(object sender, EventArgs e)
        {

            //play sound in seperate thread
            WorkerThread = delegate
            {
                snd_button.Play();
            };
            BeginInvoke(WorkerThread);
            //Create new output window ascending
            if (rb_ascending.Checked)
            {
                FormThread = delegate
                {
                    Form = new OutputScreen(array, Sorting.Gnome, true, Bar_Speed.Value)
                    {
                        Text = "Output Gnome Sort Ascending"
                    };
                };
                BeginInvoke(FormThread);
            }
            else
            {
                //Create new output window descending
                FormThread = delegate
                {
                    Form = new OutputScreen(array, Sorting.Gnome, false, Bar_Speed.Value)
                    {
                        Text = "Output Gnome Sort Descending"
                    };
                };
                BeginInvoke(FormThread);
            }
            GenerateArray();
        }

        //Insertion sort
        private void BT_Insertion_Go_Click(object sender, EventArgs e)
        {
            //play sound in seperate thread
            WorkerThread = delegate
            {
                snd_button.Play();
            };
            BeginInvoke(WorkerThread);
            //Create new output window ascending
            if (rb_ascending.Checked)
            {
                FormThread = delegate
                {
                    Form = new OutputScreen(array, Sorting.Insertion, true, Bar_Speed.Value)
                    {
                        Text = "Output Insertion Sort Ascending"
                    };
                };
                BeginInvoke(FormThread);
            }
            else
            {
                //Create new output window descending
                FormThread = delegate
                {
                    Form = new OutputScreen(array, Sorting.Insertion, false, Bar_Speed.Value)
                    {
                        Text = "Output Insertion Sort Descending"
                    };
                };
                BeginInvoke(FormThread);
            }
            GenerateArray();
        }

        //Interpolation Search
        private void Bt_interpolation_Click(object sender, EventArgs e)
        {
            //play sound in seperate thread
            WorkerThread = delegate
            {
                snd_button.Play();
            };
            BeginInvoke(WorkerThread);

            FormThread = delegate
            {
                //sort the array
                Array.Sort(array);
                //update ui
                tb_array.Text = string.Join(", ", array);
                //add "search for" if blank
                if (this.tb_searchfor.Text == "")
                {
                    this.tb_searchfor.Text = array[r.Next(array.Count())].ToString();
                }

                //try convert text to string
                try
                {
                    decimal.Parse(this.tb_searchfor.Text);
                }
                catch (Exception)
                {
                    return;
                }

                //Create new output window
                Form = new OutputScreen(array, Searching.Interpolation, decimal.Parse(tb_searchfor.Text), Bar_Speed.Value)
                {
                    Text = "Output Interpolation Search"
                };
            };
            BeginInvoke(FormThread);
        }

        private void Bt_Exponential_Click(object sender, EventArgs e)
        {
            //play sound in seperate thread
            WorkerThread = delegate
            {
                snd_button.Play();
            };
            BeginInvoke(WorkerThread);

            FormThread = delegate
            {
                //sort the array
                Array.Sort(array);
                //update ui
                tb_array.Text = string.Join(", ", array);
                //add "search for" if blank
                if (this.tb_searchfor.Text == "")
                {
                    this.tb_searchfor.Text = array[r.Next(array.Count())].ToString();
                }

                //try convert text to string
                try
                {
                    decimal.Parse(this.tb_searchfor.Text);
                }
                catch (Exception)
                {
                    return;
                }

                //Create new output window
                Form = new OutputScreen(array, Searching.Exponential, decimal.Parse(tb_searchfor.Text), Bar_Speed.Value)
                {
                    Text = "Output Exponential Search"
                };
            };
            BeginInvoke(FormThread);
        }

        private void Bt_Binary_Click(object sender, EventArgs e)
        {
            //play sound in seperate thread
            WorkerThread = delegate
            {
                snd_button.Play();
            };
            BeginInvoke(WorkerThread);

            FormThread = delegate
            {
                //sort the array
                Array.Sort(array);
                //update ui
                tb_array.Text = string.Join(", ", array);
                //add "search for" if blank
                if (this.tb_searchfor.Text == "")
                {
                    this.tb_searchfor.Text = array[r.Next(array.Count())].ToString();
                }

                //try convert text to string
                try
                {
                    decimal.Parse(this.tb_searchfor.Text);
                }
                catch (Exception)
                {
                    return;
                }

                //Create new output window
                Form = new OutputScreen(array, Searching.Binary, decimal.Parse(tb_searchfor.Text), Bar_Speed.Value)
                {
                    Text = "Output Binary Search"
                };
            };
            BeginInvoke(FormThread);
        }

        private void Bt_Linear_Click(object sender, EventArgs e)
        {
            //play sound in seperate thread
            WorkerThread = delegate
            {
                snd_button.Play();
            };
            BeginInvoke(WorkerThread);

            FormThread = delegate
            {
                //update ui
                tb_array.Text = string.Join(", ", array);

                //add "search for" if blank
                if (this.tb_searchfor.Text == "")
                {
                    this.tb_searchfor.Text = array[r.Next(array.Count())].ToString();
                }

                //try convert text to string
                try
                {
                    decimal.Parse(this.tb_searchfor.Text);
                }
                catch (Exception)
                {
                    return;
                }

                //Create new output window
                Form = new OutputScreen(array, Searching.Linear, decimal.Parse(tb_searchfor.Text), Bar_Speed.Value)
                {
                    Text = "Output Linear Search"
                };
            };
            BeginInvoke(FormThread);
        }

        private void Bt_Fibonacci_Click(object sender, EventArgs e)
        {
            //play sound in seperate thread
            WorkerThread = delegate
            {
                snd_button.Play();
            };
            BeginInvoke(WorkerThread);

            FormThread = delegate
            {
                //sort the array
                Array.Sort(array);
                //update ui
                tb_array.Text = string.Join(", ", array);
                //add "search for" if blank
                if (this.tb_searchfor.Text == "")
                {
                    this.tb_searchfor.Text = array[r.Next(array.Count())].ToString();
                }

                //try convert text to string
                try
                {
                    decimal.Parse(this.tb_searchfor.Text);
                }
                catch (Exception)
                {
                    return;
                }

                //Create new output window
                Form = new OutputScreen(array, Searching.Fibonacci, decimal.Parse(tb_searchfor.Text), Bar_Speed.Value)
                {
                    Text = "Output Binary Search"
                };
            };
            BeginInvoke(FormThread);
        }

        private void Bar_Speed_Scroll(object sender, EventArgs e)
        {
            label9.Text = ((float)Bar_Speed.Value / (float)100).ToString() + "s";
        }

        private void Tb_array_Leave(object sender, EventArgs e)
        {
            try
            {
                var tmp = tb_array.Text.Split(',');
                decimal[] tmp0 = new decimal[tmp.Length];
                for (int i = 0; i < tmp.Length; i++)
                {
                    tmp0[i] = decimal.Parse(tmp[i].Trim());
                }

                bool isUnique = tmp0.Distinct().Count() == tmp0.Count();

                if (!isUnique)
                {
                    MessageBox.Show("Array is not distinct", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                tmp0 = tmp0.Distinct().ToArray();
                array = tmp0;
            }
            catch (Exception)
            {
                MessageBox.Show("There was an error changing the array", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            tb_array.Text = string.Join(", ", array);
            tb_arraysize.Text = array.Length.ToString();
            tb_realmax.Text = array.Max().ToString();
            tb_realmin.Text = array.Min().ToString();

            if (decimal.Parse(tb_max.Text.Trim()) < array.Max())
            {
                tb_max.Text = array.Max().ToString();
            }

            if (decimal.Parse(tb_min.Text.Trim()) > array.Min())
            {
                tb_min.Text = array.Min().ToString();
            }

            tb_searchfor.Text = array[r.Next(array.Count())].ToString();
        }

    }
    //Enum for sorting
    public enum Sorting
    {
        Bubble = 1,
        Quick = 2,
        Heap = 3,
        Merge = 4,
        Insertion = 5,
        Gnome = 6
    }


    //Enum for searching
    public enum Searching
    {
        Interpolation = 1,
        Exponential = 2,
        Binary = 3,
        Linear = 4,
        Fibonacci = 5
    }

    //class to hold time and space complexity of algorithms
    public class Data
    {
        public string time = "";
        public string space = "";
    }
}
