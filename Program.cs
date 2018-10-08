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
            float length;
            float width;
            float hight;
            float area;
            float surfaceArea;
            float volume;
            float perimeter;
            char repeat;
            //Main Loop
            while(true){
            //User Input
                System.Console.WriteLine("Input the Length of the room:");
                length = float.Parse(System.Console.ReadLine());
                System.Console.WriteLine("Input the Width of the room:");
                width = float.Parse(System.Console.ReadLine());
                System.Console.WriteLine("Input the Hight of the room:");
                hight = float.Parse(System.Console.ReadLine());
            //Logic
                area = length * width;
                perimeter = length * 2.0f + width * 2.0f;
                volume = length * width * hight;
                surfaceArea = length * width * 2.0f + width * hight * 2.0f + length * hight * 2.0f;
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
