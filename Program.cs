using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_lecture_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank Ameria = new Bank();
            Console.WriteLine("The name of the bank is {0}", Ameria.Name);
            Ameria.IVR();


            Console.Read();
        }
    }
}
