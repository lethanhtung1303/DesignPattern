using quanlyxekhach.AbstractModel;
using quanlyxekhach.DAO;
using quanlyxekhach.IDAO;
using quanlyxekhach.Models;
using quanlyxekhach.Models.AccountBuilder;
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
        private IAccountDao dao;
  
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
            IAccountBuilder accountBuilder = new AccountBuilder();
            Account account = accountBuilder.AddTenNV(txtNameEmp.Text)
                .AddMaNV("NV1")
                .AddTenTK(txtUsername.Text)
                .AddChucVu(txtPosition.Text)
                .AddMatKhau(txtPassword.Text).Builder();
        
            var createAcc = dao.Insert(account);

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