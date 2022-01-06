using System;
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
        public void dispatch(String request, string dataSend, Form formFrom)
        {
            formFrom.Hide();
            //Factory pattern
            formFactory.getForm(request, dataSend).ShowDialog();
            formFrom.Show();
        }
    }
}