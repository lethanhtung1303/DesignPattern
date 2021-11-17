using quanlyxekhach.AbstractModel;
using quanlyxekhach.formFactory;
using quanlyxekhach.Models;
using System;
using System.Windows.Forms;

namespace quanlyxekhach
{
    public partial class Login : Form
    {
        private AccountDao dao;
        private FormController formController;

        public Login()
        {
            InitializeComponent();
            CreateAccountDao();
            formController = FormController.getInstance();// gọi simple factory ( ko tạo mới vì đã singleton)
        }

        public void CreateAccountDao()
        {
            AbstractDbFactory sql = SqlFactory.GetInstance();
            dao = new AccountDao(sql);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            txtErrorMess.Text = "";
            if (string.IsNullOrEmpty(txtPassword.Text) || string.IsNullOrEmpty(txtUsername.Text))
            {
                txtErrorMess.Text = "Vui lòng điền đầy đủ thông tin";
            }
            else if (dao.Login(txtUsername.Text.Trim(), txtPassword.Text.Trim()))
            {
                if (txtUsername.Text.Contains("admin"))
                {
                    formController.FormRequest("EMPLOYEE", this); //có chỉnh sửa ở đây :))
                }
                else if (txtUsername.Text.Contains("employee"))
                {
                    formController.FormRequest("EMPLOYEE", this);// sử dụng simple factory
                }
                else if (txtUsername.Text.Contains("seller"))
                {
                    formController.FormRequest("SELLER", this);
                }
            }
            else
            {
                txtErrorMess.Text = "Sai tên tài khoản hoặc mật khẩu";
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("bạn có thật sự muốn thoát ?", "thoát ứng dụng", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (dialogResult == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}