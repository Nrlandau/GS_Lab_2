/* Lab 2 by Nicholas Landau
This program takes a length and a width of a room and calculates the area and perimeter of it.
 */
using System;
using System.Text.RegularExpressions;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Vars
            Regex repeat = new Regex("^[yY]");
            double length , width, hight;
            double area, perimeter, volume;
            
            do{
            //Input
            System.Console.WriteLine("Length:");
            length = double.Parse(System.Console.ReadLine());
            System.Console.WriteLine("Width:");
            width = double.Parse(System.Console.ReadLine());
            System.Console.WriteLine("Hight");
            hight = double.Parse(System.Console.ReadLine());
            //Magic
            area = length * width;
            perimeter = 2.0 * ( length + width);
            volume = length * width * hight;
            //Output
            System.Console.WriteLine("The area is {0} \n The perimeter is {1} The volume is {2}", area, perimeter, volume);

            System.Console.WriteLine("continue?(Y/?)");
            }while (repeat.IsMatch(System.Console.ReadLine()));

        }
    }
}
