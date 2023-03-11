using System.Security.Principal;

namespace _06._Money_Transactions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, double> bankInfo = new Dictionary<int, double>();
            string[] accaountsInfo = Console.ReadLine().Split(",", StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < accaountsInfo.Length; i++)
            {
                string[] currentAccount = accaountsInfo[i].Split("-", StringSplitOptions.RemoveEmptyEntries);
                int accountId = int.Parse(currentAccount[0]);
                double balance = double.Parse(currentAccount[1]);
                if (!bankInfo.ContainsKey(accountId))
                {
                    bankInfo[accountId] = balance;
                }
            }
            string command = Console.ReadLine();
            while (command != "End")
            {
                string[] cmdArg = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string operation = cmdArg[0];
                int accountId = int.Parse(cmdArg[1]);
                double money = double.Parse(cmdArg[2]);
                try
                {
                    switch (operation)
                    {
                        case "Deposit":
                            bankInfo[accountId] += money;
                            Console.WriteLine($"Account {accountId} has new balance: {bankInfo[accountId]:f2}");
                            break;
                        case "Withdraw":
                            if (bankInfo[accountId] - money >= 0)
                            {
                                bankInfo[accountId] -= money;
                                Console.WriteLine($"Account {accountId} has new balance: {bankInfo[accountId]:f2}");
                            }
                            else
                            {
                                throw new ArgumentException("Insufficient balance!");
                            }
                            break;
                        default:
                            throw new ArgumentException("Invalid command!");
                    }
                }
                catch (KeyNotFoundException)
                {
                    Console.WriteLine("Invalid account!");
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    Console.WriteLine("Enter another command");
                }
                command = Console.ReadLine();
            }
        }
    }
}