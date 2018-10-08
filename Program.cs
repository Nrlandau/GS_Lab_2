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
            float area;
            float perimeter;
            char repeat;
            //Main Loop
            while(true){
            //User Input
                System.Console.WriteLine("Input the Length of the room:");
                length = float.Parse(System.Console.ReadLine());
                System.Console.WriteLine("Input the Width of the room:");
                width = float.Parse(System.Console.ReadLine());
            //Logic
                area = length * width;
                perimeter = length * 2.0f + width * 2.0f;
            //Output
                System.Console.WriteLine("The area is ({0}) and the perimeter is ({1})",area,perimeter);

                System.Console.WriteLine("Do you want to repeat?(Y/?");
                repeat = char.Parse(System.Console.ReadLine());
                if (repeat != 'y' && repeat != 'Y')
                    break; 

            }

        }
    }
}
