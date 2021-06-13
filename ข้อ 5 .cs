using System;

namespace _36
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please insert the number of item in invenntory : ");
            int num = int.Parse(Console.ReadLine());
            

            string[] itemname = new string[num];
            string[] typeofitem = new string[num];
            

            for(int i =0; i<num;i++)
            {
                Console.Write("PLasae insert your item name  -------> ");
                itemname[i] = Console.ReadLine();
                Console.Write("Please insert your item type  -------> ");
                typeofitem[i] = Console.ReadLine();
                
            }

            Console.WriteLine();
            Console.WriteLine("Your item in inventory");
            Console.WriteLine();
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine(itemname[i]);
                Console.WriteLine(typeofitem[i]);
            }


        }
    }
}
