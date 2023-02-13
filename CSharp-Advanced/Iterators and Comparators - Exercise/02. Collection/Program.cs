using System;
using System.Collections.Generic;
using System.Linq;

namespace Collection
{
    public class Program
    {
        static void Main(string[] args)
        {          
                List<string> items = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Skip(1).ToList();
                ListyIterator<string> list = new ListyIterator<string>(items);
                string command = Console.ReadLine();
                while (command != "END")
                {
                    switch (command)
                    {
                        case "Move":
                            Console.WriteLine(list.Move());
                            break;
                        case "HasNext":
                            Console.WriteLine(list.HasNext());
                            break;
                        case "Print":
                            try
                            {
                                list.Print();
                            }
                            catch (InvalidOperationException exeption)
                            {
                                Console.WriteLine(exeption.Message);
                            }
                            break;
                        case "PrintAll":
                            foreach(var item in list)
                            {
                                Console.Write($"{item} ");
                            }
                        Console.WriteLine();
                            break;
                    }


                    command = Console.ReadLine();
                }            
        }
    }
}
