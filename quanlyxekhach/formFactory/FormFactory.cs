using quanlyxekhach.Forms;
using System;
using System.Windows.Forms;

namespace quanlyxekhach.formFactory
{
    public class FormFactory
    {
        public FormFactory()
        {
        }

        // factory
        public Form getForm(String nameForm, string dataSend)
        {
            if (nameForm == "EMPLOYEE")
            {
                return new ManageCustomer(dataSend);
            }
            else if (nameForm == "SELLER")
            {
                return new Payment(dataSend);
            }
            else if (nameForm == "ADMIN")
            {
                return new ManageEmployee();
            }
            else if (nameForm == "EMPLOYEE_INFO_TRIP")
            {
                return new ManageInfoTrip(dataSend);
            }
            else if (nameForm == "EMPLOYEE_INFO_PAYMENT")
            {
                return new ManageTicket(dataSend);
            }
            return null;
        }
    }
}