using System;

namespace HW1
{
    class Program
    {
        static void Main(string[] args)
        {
            string choice;

            Console.WriteLine("This program has multiple functionalities");
            Console.WriteLine("A to convert miles to KM, B to convert inches to CM, C to convert lbs to kg");
            Console.WriteLine("D to convert KM to miles, E to convert CM to inches, F to convert kg to lbs");
            Console.Write("Enter choice: ");
            choice = Console.ReadLine();

            switch (choice.ToUpper())
            {
                case "A":
                            //do something
                            Console.Write("Enter the number of Miles you would like to convert: ");
                            double miles = double.Parse(Console.ReadLine());
                            double km = (miles * 1.6);
                            Console.WriteLine(miles + " miles is = " + km + " kilometers");

                            break;
                case "C":
                            //do something
                            Console.Write("Enter the number of LBS you would like to convert: ");
                            double lbs = double.Parse(Console.ReadLine());
                            double kg = (lbs * 0.45359237);
                            Console.WriteLine(lbs + "lbs is = " + kg + " kilograms");
                            break;
                case "B":
                            //do something
                            Console.Write("Enter the number of Inches you would like to convert: ");
                            double inches = double.Parse(Console.ReadLine());
                            double cm = (inches * 2.54);
                            Console.WriteLine(inches + " inches is = " + cm + " centimeters");

                            break;
                case "D":
                            //do something
                            Console.Write("Enter the number of KM you would like to convert: ");
                            double kilometers = double.Parse(Console.ReadLine());
                            double Miles = (kilometers * 0.62137119);
                            Console.WriteLine(kilometers + " KM is = " + Miles + " miles");
                            break;

                case "E":
                            //do something
                            Console.Write("Enter the number of CM you would like to convert: ");
                            double Centimenters = double.Parse(Console.ReadLine());
                            double Inches = (Centimenters * 0.62137119);
                            Console.WriteLine(Centimenters + " CM is = " + Inches + " inches");
                            break;
                case "F":
                            //do something
                            Console.Write("Enter the number of CM you would like to convert: ");
                            double Kilograms = double.Parse(Console.ReadLine());
                            double LBS = (Kilograms * 2.2);
                            Console.WriteLine(Kilograms + " KG is = " + LBS + " lbs");
                            break;
                default:
                    break;
            }

            Console.ReadLine();

            //continues here
        }
    }
}
