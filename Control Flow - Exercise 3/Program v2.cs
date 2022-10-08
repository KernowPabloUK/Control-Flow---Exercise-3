using System;

namespace Control_Flow___Exercise_3
{
    public class Program
    {
        static void Main(string[] args)
        {
            //3- Write a program and ask the user to enter the width and height of an image. Then tell if the image is landscape or portrait.  

            //width
                Console.WriteLine("Please enter the width of the image in cm...");
                int widthNumber = readIntNumberFromConsole();

            //height
                Console.WriteLine("Please enter the height of the image in cm...");
                int heightNumber = readIntNumberFromConsole();

                if (widthNumber > heightNumber)
                    Console.WriteLine("Image is Landscape");
                else
                    Console.WriteLine("Image is Portrait");
        }
        //method for converting number
        private static int readIntNumberFromConsole()
        {
            string Input = Console.ReadLine();
            int Output = Convert.ToInt32(Input);
            return Output;
        }
    }
}
