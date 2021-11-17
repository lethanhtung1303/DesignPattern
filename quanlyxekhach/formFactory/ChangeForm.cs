using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanlyxekhach.formFactory
{
    internal class ChangeForm
    {
        private FormFactory formFactory;

        public ChangeForm()
        {
            formFactory = new FormFactory();
        }

        // chuyển từ form này qua form khác
        public void dispatch(String request, Form formFrom)
        {
            formFrom.Hide();
            //Factory pattern
            formFactory.getForm(request).ShowDialog();
            formFrom.Close();
        }
    }
}