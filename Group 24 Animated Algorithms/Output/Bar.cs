using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group_24_Animated_Algorithms.Output
{
    class Bar
    {
        //bar fields: width and height in pixels and position
        private int height = 100;
        private int width = 10;
        private int pos = 0;
        private Decimal value = 0;

        //bar properties: width and height in pixels and position
        public int Height { get => height; set => height = value; }
        public int Width { get => width; set => width = value; }
        public int Pos { get => pos; set => pos = value; }
        public decimal Value { get => value; set => this.value = value; }
        public int[] Colour = new int[3] { 0, 0, 255 };
    }
}
