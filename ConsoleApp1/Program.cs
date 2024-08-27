using System;
using System.Threading.Channels;
namespace applikation
{ 

       public class Shape
    {
        double width;
        double height;
        public Shape(double width, double height)
        {
            this.width = width;
            this.height = height;
        }
    }
    public class Triangle(double width, double height) : Shape(width, height)
    {
        public double Area()
        {
            return (width * height) / 2;
        }
        public double omkrets()
        {
            double hypotenusa = Math.Sqrt((height * height) + (width * width));
            return hypotenusa + width + height;
        }
    }
    public class Rectangle(double width, double height) : Shape(width, height)
    {
        public double Area()
        {
            return width * height;
        }
        public double omkrets()
        {
            return width + width + height + height;
        }
      
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in bredden");
            double width = double.Parse(Console.ReadLine());
            Console.WriteLine("Skriv in höjden");
            double height = double.Parse(Console.ReadLine());
            Console.WriteLine("Är det en Rektangel eller Triangel(R/T)");
            string svar = Console.ReadLine();
            if (svar == "R")
            {
                Rectangle rectangle = new Rectangle(width, height);
                Console.WriteLine("arean är: " + rectangle.Area());
                Console.WriteLine("Omkretsen är: " + rectangle.omkrets());
            }
            else if (svar == "T")
            {
                Triangle triangle = new Triangle(width, height);
                Console.WriteLine("arean är: " + triangle.Area());
                Console.WriteLine("Omkretsen är: " + triangle.omkrets());
            }
            else
            { 
                Console.WriteLine("Alternativet finns inte");
            }
        }
    }
}

  

    



    

    


