using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanlyxekhach.formFactory
{
    internal class FormFactory
    {
        public FormFactory()
        {
        }

        // factory
        public Form getForm(String nameForm, string dataSend)
        {
            if (nameForm == "EMPLOYEE")
            {
                return new ManageCustomer();
            }
            else if (nameForm == "SELLER")
            {
                return new Payment(dataSend);
            }
            else if (nameForm == "ADMIN")
            {
                return new ManageEmployee();
            }
            return null;
        }
    }
}