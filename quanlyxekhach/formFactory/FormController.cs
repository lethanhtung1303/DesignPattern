using System;
using System.Windows.Forms;

namespace quanlyxekhach.formFactory
{
    public class FormController
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
        public void FormRequest(String request, string dataSend, Form formFrom)
        {
            changeForm.dispatch(request, dataSend, formFrom);
        }
    }
}