using quanlyxekhach.AbstractModel;
using quanlyxekhach.CommandButton;
using quanlyxekhach.DAO;
using quanlyxekhach.formFactory;
using quanlyxekhach.IDAO;
using System;
using System.Windows.Forms;

namespace quanlyxekhach
{
    public partial class Login : Form
    {
        private IAccountDao dao;
        private FormController formController;
        private CommandButtonManage enableLogin, disableLogin;

        public Login()
        {
            InitializeComponent();
            CreateAccountDao();
            formController = FormController.getInstance();// gọi simple factory ( ko tạo mới vì đã singleton)
            enableLogin = new ManageButtonEnable(btnLogin);
            disableLogin = new ManageButtonDisable(btnLogin);
            disableLogin.Execute();
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

            if (dao.Login(txtUsername.Text.Trim(), txtPassword.Text.Trim()))
            {
                if (txtUsername.Text.Contains("admin"))
                {
                    formController.FormRequest("ADMIN", txtUsername.Text, this);
                }
                else if (txtUsername.Text.Contains("employee"))
                {
                    formController.FormRequest("EMPLOYEE", txtUsername.Text, this);// sử dụng simple factory
                }
                else if (txtUsername.Text.Contains("seller"))
                {
                    formController.FormRequest("SELLER", txtUsername.Text, this);
                }
            }
            else
            {
                txtErrorMess.Text = "Sai tên tài khoản hoặc mật khẩu";
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtPassword.TextLength > 0 || txtUsername.TextLength > 0)
            {
                enableLogin.Execute();
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