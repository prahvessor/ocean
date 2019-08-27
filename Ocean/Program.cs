using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ocean
{
    class Program
    {
        static void Main(string[] args)
        {
            Ocean ocean1 = new Ocean();
            //Console.WriteLine(ocean1.Size);
            ocean1.initialise();
            ocean1.display();

            Console.ReadKey();
        }
    }
}
