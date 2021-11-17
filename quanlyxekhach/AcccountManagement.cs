using quanlyxekhach.AbstractModel;
using quanlyxekhach.Models;
using System;
using System.Data;
using System.Windows.Forms;

namespace quanlyxekhach
{
    public partial class AccountManagement : Form
    {
        private AccountDao dao;

        public AccountManagement()
        {
            InitializeComponent();
            CreateAccountDao();
        }

        public void CreateAccountDao()
        {
            AbstractDbFactory sql = SqlFactory.GetInstance();
            dao = new AccountDao(sql);
        }

        public void ReloadTextBox()
        {
            txtUserName.Text = "";
            txtPosition.Text = "";
            txtNameEmp.Text = "";
            txtPass.Text = "";
        }

        public void LoadData()
        {
            DataTable tb = dao.GetAll();
            dataGridView1.DataSource = tb;
        }

        private void btnChangeDataAcc_Click(object sender, EventArgs e)
        {
            Account acc = new Account();
            acc.TenNv = txtNameEmp.Text;
            acc.ChucVu = txtPosition.Text;
            acc.TenTK = txtUserName.Text;
            acc.MatKhau = txtPass.Text;

            var UpdateAcc = dao.Update(acc);

            if (UpdateAcc)
            {
                MessageBox.Show("Cập nhật tài khoan thành công");
                LoadData();
                ReloadTextBox();
            }
            else MessageBox.Show("Có lỗi xảy ra");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            this.Hide();
            register.ShowDialog();
            this.Show();
        }

        private void btnDeleteAcc_Click(object sender, EventArgs e)
        {
            if (dao.Delete(txtUserName.Text.Trim()))
            {
                MessageBox.Show("Xóa tài khoan thành công");
                LoadData();
                ReloadTextBox();
            }
            else MessageBox.Show("Có lỗi xảy ra");
        }

        private void AccountManagement_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index < 0 || index >= dataGridView1.RowCount)
            {
                return;
            }
            DataGridViewRow row = dataGridView1.Rows[index];
            string stt = Convert.ToString(row.Cells[0].Value);
            string MaNV = Convert.ToString(row.Cells[1].Value);
            string tenNv = Convert.ToString(row.Cells[2].Value);
            string chucVu = Convert.ToString(row.Cells[3].Value);
            string tenTK = Convert.ToString(row.Cells[4].Value);
            string matKhau = Convert.ToString(row.Cells[5].Value);

            txtNameEmp.Text = tenNv;
            txtPosition.Text = chucVu;
            txtUserName.Text = tenTK;
            txtPass.Text = matKhau;
        }
    }
}