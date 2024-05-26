using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyWork
{

    public class OutSourcingCompany : Company
    {
        private List<IEmployee> employees;

        public OutSourcingCompany()
        {
            employees = new List<IEmployee>
            {
                new Programmer(),
                new Tester() 
            };
        }

        public override List<IEmployee> GetEmployees()
        {
            return employees;
        }
    }

}
