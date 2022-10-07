using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caculadora.Clases
{
    internal class ClsDivision
    {
        public string divide(double n1, double n2)
        {
            if (n2 != 0)
            {
                double d = n1 / n2;
                return d.ToString();
            }
            else
            {
                string e = "Error";
                return e;
            }
        }
    }
}
