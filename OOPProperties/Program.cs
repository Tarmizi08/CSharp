using System;

namespace OOPProperties
{
    class Box
    {
        // member field
        private int length=3;
        private int height;
        private int width;
        private int volume;

        //first method to access private access modifier field
        public void SetLength(int length)
        {
            this.length = length;
        }

        //private void SetLength(int length)
        //{
        //    this.length = length;
        //}

        // also can call getter or setter

        public int Width
        {
            get
            {
                return width;
            }
            set
            {
                this.width = value;
            }
        }

        public int Height
        {
            get
            {
                return height;
            }
            set
            {
                if (value < 0)
                {
                    height = -value;
                }
                else
                {
                    height=value;
                }
                //height = value;
            }
        }

        public int Volume
        {
            get
            {
                return this.length * this.Width * this.Height;
            }
            set
            {
                this.volume = value;
            }
        }

        //getter and setter method

        /*
        public int GetLength()
        {
            return this.length;
        }

        public int SetVolume()
        {
            return this.length * this.width * this.height;
        }

        */


        //class method

        public Box(int length, int width, int height)
        {
            Height = height;
            this.length = length;
            Width = width;
        }

        public void DisplayInfo()
        {
            //Console.WriteLine("The volume of the box was {0}, with the length {1}, height {2}, and width {3}", volume = length*height*width, length, height,width);
            Console.WriteLine("The volume of the box was {0}, with the length {1}, height {2}, and width {3}", Volume, length, Height, Width);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Box firstBox = new Box(3,4,5);
            //firstBox.length = 2;
            //firstBox.height = 4;
            firstBox.SetLength(9);
            firstBox.Height = 5;
            firstBox.Width = 10;
            //firstBox.width = 3;

            // accessed the property through setlength
            //firstBox.SetLength(8);


            //firstBox.GetLength();

            firstBox.DisplayInfo();

            Console.ReadKey();
        }
    }
}

