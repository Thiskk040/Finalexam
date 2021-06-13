using System;
using System.Linq;

namespace _35
{
    class Program
    {
        static void Main(string[] args)
        {
            string word;
            double n = double.Parse(Console.ReadLine());
            double[] array = new double[(int)n];

            
                for (int i = 0; i < n; i++)
                {
                    array[i] = double.Parse(Console.ReadLine());


                }
           
            
            string stop = Console.ReadLine();
            if(stop == "End")
            {
                switch(stop)
                {
                    case "FindMin":
                    Console.WriteLine("min = {0}", array.Min());
                        break;
                        case "FindMax":
                    Console.WriteLine("max = {0}", array.Max());
                        break;
                        case "FindMean":
                    Console.WriteLine("Average = {0}", array.Average());
                        break;
                    default:
                        Console.WriteLine("Invalid mode");
                            break;
                }
            }
            

            






        }

    }
}

    

        
    

