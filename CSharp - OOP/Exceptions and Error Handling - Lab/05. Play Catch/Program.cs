using System.Text;

namespace _05._Play_Catch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList());
            int exceptionCount = 3;
            while(exceptionCount > 0)
            {
                string[] cmdArg = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string cmd = cmdArg[0];
                switch(cmd)
                {
                    case "Replace":
                        
                        
                        try
                        {
                            int index = int.Parse(cmdArg[1]);
                            int newValue = int.Parse(cmdArg[2]);
                            if (index < 0 || index >= list.Count)
                            {
                                throw new ArgumentOutOfRangeException();
                            }
                            else
                            {
                                list[index] = newValue;
                            }
                        }
                        catch(FormatException)
                        {
                            Console.WriteLine("The variable is not in the correct format!");
                            exceptionCount--;
                        }
                        catch(ArgumentOutOfRangeException )
                        {
                            Console.WriteLine("The index does not exist!");
                            exceptionCount--;
                        }
                        break;
                    case "Print":                   
                        try
                        {
                            int startIndex = int.Parse(cmdArg[1]);
                            int endIndex = int.Parse(cmdArg[2]);
                            if (startIndex < endIndex && startIndex >= 0 && startIndex < list.Count && endIndex >= 0 && endIndex < list.Count)
                            {
                                var newList = list.GetRange(startIndex, endIndex);
                                Console.WriteLine(String.Join(", ", newList).TrimEnd());
                            }
                            else
                            {
                                throw new ArgumentOutOfRangeException();
                               
                            }
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("The variable is not in the correct format!");
                            exceptionCount--;
                        }
                        catch (ArgumentOutOfRangeException )
                        {
                            Console.WriteLine("The index does not exist!");
                            exceptionCount--;
                        }
                        break;
                    case "Show":
                        try
                        {
                            int index = int.Parse(cmdArg[1]);
                            if (index < 0 || index >= list.Count)
                            {
                                throw new ArgumentOutOfRangeException();
                            }
                            else
                            {
                                Console.WriteLine(list[index]);
                            }
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("The variable is not in the correct format!");
                            exceptionCount--;
                        }
                        catch (ArgumentOutOfRangeException )
                        {
                            Console.WriteLine("The index does not exist!");
                            exceptionCount--;
                        }
                        break;
                }
            }
            Console.WriteLine(String.Join(", ",list));
        }       
    }   
}