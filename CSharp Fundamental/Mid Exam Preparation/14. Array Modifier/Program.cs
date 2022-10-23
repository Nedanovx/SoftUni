using System;
using System.Linq;

namespace _14._Array_Modifier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] elements = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            string commmand = Console.ReadLine();
            while(commmand != "end")
            {
                string[] cmdArg = commmand.Split(" ");
                string cmdType = cmdArg[0];
                
                if (cmdType == "swap")
                {
                    int index1 = int.Parse(cmdArg[1]);
                    int index2 = int.Parse(cmdArg[2]);
                    int copyIndex = elements[index1];
                    elements[index1] = elements[index2];
                    elements[index2] = copyIndex;
                }
                else if (cmdType == "multiply")
                {
                    int index1 = int.Parse(cmdArg[1]);
                    int index2 = int.Parse(cmdArg[2]);
                    int multiplySum = elements[index1] * elements[index2];
                    elements[index1] = multiplySum;
                }
                else if(cmdType == "decrease")
                {
                    for(int i = 0; i < elements.Length; i++)
                    {
                        elements[i] =elements[i] - 1;
                    }
                }
                commmand = Console.ReadLine();
            }
            Console.WriteLine(string.Join(", ", elements));
        }
    }
}
