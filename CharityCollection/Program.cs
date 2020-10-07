using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharityCollection
{
    class Program
    {
        static void Main(string[] args)
        {

            int totalRaised; 

            Money Person1 = new Money();
            Money Person2 = new Money();
            Money Person3 = new Money();

            Person1.GetAmount();
            Person2.GetAmount();
            Person3.GetAmount();

            totalRaised = Person1.amountCollected + Person2.amountCollected + Person3.amountCollected;

            if(totalRaised > 1000)
            {
                Console.WriteLine("A total of " + totalRaised + " was raised.");
                Console.WriteLine("This will be doubled to " + totalRaised * 2);
            }
            else
            {
                Console.WriteLine("A total of " + totalRaised + " was raised.");
            }
            Console.ReadLine();
        }
    }
}
