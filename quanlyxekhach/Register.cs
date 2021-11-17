using quanlyxekhach.AbstractModel;
using quanlyxekhach.Models;
using System;
using System.Windows.Forms;

namespace quanlyxekhach
{
    public partial class Register : Form
    {
        /*       public static AbstractDbFactory Factory()
               {
                   return new SqlFactory();
               }*/
        private AccountDao dao;

        public Register()
        {
            InitializeComponent();
            CreateAccountDao();
        }

        public void CreateAccountDao()
        {
            AbstractDbFactory sql = SqlFactory.GetInstance();
            dao = new AccountDao(sql);
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            Account account = new Account();
            account.TenNv = txtNameEmp.Text;
            account.MaNV = "NV1";
            account.TenTK = txtUsername.Text;
            account.ChucVu = txtPosition.Text;
            account.MatKhau = txtPassword.Text;
            var createAcc = dao.Add(account);

            if (createAcc)
            {
                MessageBox.Show("Đăng kí tài khoan thành công");
                txtNameEmp.Text = "";
                txtPosition.Text = "";
                txtUsername.Text = "";
                txtPassword.Text = "";
                txtConfirmPassword.Text = "";
            }
        }
    }
}