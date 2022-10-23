using System;

namespace Experience_Gaining
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double experience = double.Parse(Console.ReadLine());
            int countBattle = int.Parse(Console.ReadLine());
            double sum = 0;
            int count = 0;
           while(countBattle>0)
            {
                int expBattle = int.Parse(Console.ReadLine());
                sum += expBattle;
                count++;
                
                
                if(count % 3 == 0)
                {
                    sum += expBattle * 0.15;
                }
                if(count % 5 == 0)
                {
                    sum -= expBattle * 0.1;
                }
                if(count % 15 == 0)
                {
                    sum += expBattle * 0.5;
                }
                if(sum>=experience)
                {
                    break;
                }
                countBattle--;
            }
           if(sum < experience)
            {
                Console.WriteLine($"Player was not able to collect the needed experience, {(experience - sum):f2} more needed.");
            }
           else
            {
                Console.WriteLine($"Player successfully collected his needed experience for {count} battles.");
            }


        }
    }
}
