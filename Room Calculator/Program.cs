using System;

public class Program
{
    public static void Main()
    {
        string roomLength = string.Empty;
        string roomWidth = string.Empty;
        string doLoop = string.Empty;
        string roomHeight = string.Empty;
        do
        {

            // can a laptop get an input
            Console.WriteLine("Welcome to the Grand Circus Room Detail Generator!");
            Console.Write("Enter Length (Convert to decimal form if needed):");
            roomLength = Console.ReadLine();
            Console.Write("Enter Width (Convert to decimal form if needed):");
            roomWidth = Console.ReadLine();
            Console.Write("Enter Height (Convert to decimal form if needed):");
            roomHeight = Console.ReadLine();
            // how are we gonna process this 
            double length = double.Parse(roomLength);
            double width = double.Parse(roomWidth);
            double height = double.Parse(roomHeight);
            //math
            double area;
            double peremeter;
            double volume;
            area = length * width;
            peremeter = length + length + width + width;
            volume = length * width * height;

            // what did you expect to happen
            Console.WriteLine("Area of the room: " + area);
            Console.WriteLine("Peremeter of the room: " + peremeter);
            Console.WriteLine("Volume of the room: " + volume);
            Console.Write("\nDo you wish to continue? Select Y or N and then press enter.");
            doLoop = Console.ReadLine();
        }
        while (doLoop == "Y" || doLoop == "YES" || doLoop == "Yes" || doLoop == "y" || doLoop == "yes");
        }

    }
