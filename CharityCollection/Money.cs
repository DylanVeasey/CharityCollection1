using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharityCollection
{
    class Money
    {
        public int amountCollected;

        public void GetAmount()
        {
            Console.WriteLine("How much money did you raise?");
            amountCollected = Int32.Parse(Console.ReadLine());
        }
    }
}
