using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YchPr_KornilovaVaravra320.DB
{
    public partial class Employee
    {
        public bool IsChief
        {
            get 
            {
                if (Chief == Num_emp)
                {
                    return true;
                }
                else
                { 
                    return false; 
                }
            }
        }
    }
}
