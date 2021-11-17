using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanlyxekhach.formFactory
{
    internal class FormController
    {
        private ChangeForm changeForm;

        // singleton
        private FormController()
        {
            changeForm = new ChangeForm();
        }

        private static FormController Instance;

        public static FormController getInstance()
        {
            if (Instance == null)
            {
                Instance = new FormController();
            }
            return Instance;
        }

        // lấy thông tin để chuyển form
        public void FormRequest(String request, Form formFrom)
        {
            changeForm.dispatch(request, formFrom);
        }
    }
}