/* Lab 2 by Nicholas Landau
This program takes a length and a width of a room and calculates the area and perimeter of it.
 */
using System;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Var Dec
            double length;
            double width;
            double hight;
            double area;
            double surfaceArea;
            double volume;
            double perimeter;
            char repeat;
            //Main Loop
            while(true){
            //User Input
                System.Console.WriteLine("Input the Length of the room:");
                length = double.Parse(System.Console.ReadLine());
                System.Console.WriteLine("Input the Width of the room:");
                width = double.Parse(System.Console.ReadLine());
                System.Console.WriteLine("Input the Hight of the room:");
                hight = double.Parse(System.Console.ReadLine());
            //Logic
                area = length * width;
                perimeter = length * 2.0 + width * 2.0;
                volume = length * width * hight;
                surfaceArea = length * width * 2.0 + width * hight * 2.0 + length * hight * 2.0;
            //Output
                System.Console.WriteLine("The area is ({0}) and the perimeter is ({1})",area,perimeter);
                System.Console.WriteLine("The volume of the room is ({0}) and the surface area is ({1})",volume,surfaceArea);
                System.Console.WriteLine("Do you want to repeat?(Y/?)");
                repeat = System.Console.ReadLine()[0];
                if (repeat != 'y' && repeat != 'Y')
                    break; 
            }
        }
    }
}
