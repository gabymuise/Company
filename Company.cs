using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyWork
{
    public abstract class Company
    {
        public abstract List<IEmployee> GetEmployees();

        public void CreateSoftware()
        {
            foreach (var employee in GetEmployees())
            {
                employee.DoWork();
            }
        }
    }
}
