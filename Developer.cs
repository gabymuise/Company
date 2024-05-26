using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyWork
{
    public class Developer : IEmployee
    {
        public void DoWork()
        {
            Console.WriteLine("Programando...");
        }
    }

}
