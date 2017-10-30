using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_lecture_1
{
    public class Bank
    {
        public string Name = "Ameria";
        public string Address = "Moskovyan 8";
        public int EmployeeCount = 90;

        public void IVR()
        {
            string response = $"Hello dear customer. You called {Name} bank. Our address is {Address}";
            Console.WriteLine(response);
        }





    }
}
