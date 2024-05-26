using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyWork
{
    public class GameDevCompany : Company
    {
        private List<IEmployee> employees;

        public GameDevCompany()
        {
            employees = new List<IEmployee>
            {
                new GameDesigner(),
                new Artist() 
            };
        }

        public override List<IEmployee> GetEmployees()
        {
            return employees;
        }
    }
}
