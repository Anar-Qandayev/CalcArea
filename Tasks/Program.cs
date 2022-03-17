using System;

namespace Tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter the side of the square!");
            int side = Convert.ToInt32(Console.ReadLine());
            if (side<0)
            {
                side = -side;
            }
            Console.WriteLine("Enter the width of the rectangle!");
            int width = Convert.ToInt32(Console.ReadLine());
            if (width<0)
            {
                width = -width;
            }
            Console.WriteLine("Enter the length of the rectangle!");
            int length = Convert.ToInt32(Console.ReadLine());
            if (length<0)
            {
                length = -length;
            }
            Square squ = new Square(side);
            Rectangular rec = new Rectangular(width, length);

            
            //rec.CalcArea();

            //İstifadəçi 1 yazıb enter-ə click - ləsə Square -in CalcArea methodu işə düşməlidir.
            //İstifadəçi 2 yazıb enter-ə click - ləsə Rectangular -in CalcArea methodu işə düşməlidir.
            //İstifadəçi 0 yazıb enter-ə click - ləsə proqram sonlanmalıdı.
            int key = 0;
            do
            {
                Console.WriteLine("0 - Quit" + "\n" +
                                   "1 - Square" + "\n" +
                                   "2 - Rectangular" + "\n");
                Console.WriteLine("Reqem daxil edin!");
                key = Convert.ToInt32(Console.ReadLine());


                switch (key)
                {
                    case 1:
                        Console.WriteLine("1st Method ");                       
                        squ.CalcArea();
                        break;
                    case 2:
                        Console.WriteLine("2nd Method ");
                        rec.CalcArea();
                        break;
                    case 0:
                        Console.WriteLine("0th Method ");
                        Console.WriteLine("Good bye!");

                        break;
                }

            } while (key!=0);
        }

    }
    abstract class Figure
    {
        public abstract void CalcArea();
        
    }
    class Square: Figure
    {
        public int side { get; set; } 
        public Square(int side)
        {
            this.side = side;
        }
        public override void CalcArea()
        {
            int S = side * side;
            Console.WriteLine($"Area of a square -> {S} ");
        }
    }
    class Rectangular:Figure
    {

        public int width { get; set; } 
        public int length { get; set; }
        public Rectangular(int width,int length)
        {
            this.width = width;
            this.length = length;
        }
        public override void CalcArea()
        {
            int S = width * length;
            Console.WriteLine($"Area of a Rectangular -> {S} ");
        }
    }
}
