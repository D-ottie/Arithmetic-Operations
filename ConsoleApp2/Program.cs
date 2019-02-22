using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = 50;
            int length = 100;
            int num6 = 80;
            int num7 = 80;
            
            int perimeter = width*2 + length*2;
            Console.WriteLine("Perimeter is "+perimeter);
            int subtraction = length - width;
            Console.WriteLine("Subtraction of length and width is "+subtraction);
            int area = length * width;
            Console.WriteLine("The area is "+area);
            int division = length / width;
            Console.WriteLine("Division of length and width is "+division);
            int modulus = length % width;
            Console.WriteLine("The modulus of length and width is "+modulus);
            int width1 = width++;
            Console.WriteLine("Increment of width is "+width);
            Console.WriteLine("Increment of width is also "+ ++width);
         
            int num4 = length++;
            Console.WriteLine("Increment of length is "+length);
            int num5 = --width ;
            Console.WriteLine("Decrement of width is "+width);

            
           bool compare=length > width;
           Console.WriteLine(compare);

           bool compare2 = num6 >= num7;
           Console.WriteLine(compare2);
           
            int maxnumber = 5;
            while (maxnumber>2)
            {
                Console.WriteLine(maxnumber);
                maxnumber--;
            }
            
                
            
            Console.ReadKey();
        }
    }
}