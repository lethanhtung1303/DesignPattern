using quanlyxekhach.AbstractModel;
using quanlyxekhach.CommandButton;
using quanlyxekhach.Models;
using System;
using System.Data;
using System.Windows.Forms;

namespace quanlyxekhach
{
    public partial class ManageCustomer : Form
    {
        private CustomerDAO customerDAO;
        private string maKH;

        private CommandButtonManage enablebtnDelete, disablebtnDelete,
            enablebtnChange, disablebtnChange,
            enablebtnFind, disablebtnFind;

        public ManageCustomer()
        {
            InitializeComponent();
            AbstractDbFactory sql = SqlFactory.GetInstance();
            customerDAO = new CustomerDAO(sql);

            enablebtnDelete = new ManageButtonEnable(btnDelete);
            disablebtnDelete = new ManageButtonDisable(btnDelete);

            enablebtnChange = new ManageButtonEnable(btnChange);
            disablebtnChange = new ManageButtonDisable(btnChange);

            enablebtnFind = new ManageButtonEnable(btnFind);
            disablebtnFind = new ManageButtonDisable(btnFind);
        }

        public void showAll()
        {
            DataTable tb = customerDAO.GetAll();
            dataGridView1.DataSource = tb;
        }

        private void ManageCustomer_Load(object sender, System.EventArgs e)
        {
            //btnFind.Enabled = false;
            //btnChange.Enabled = false;
            //btnDelete.Enabled = false;
            //btnDeleteTextBox.Enabled = false;
            disablebtnFind.Execute();
            disablebtnChange.Execute();
            disablebtnDelete.Execute();
            showAll();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //btnChange.Enabled = true;
            //btnDelete.Enabled = true;
            //btnDeleteTextBox.Enabled = true;
            enablebtnChange.Execute();
            enablebtnDelete.Execute();

            var index = e.RowIndex;
            if (index >= 0)
            {
                maKH = Convert.ToString(dataGridView1.Rows[index].Cells["MaKH"].Value);
                txtMaKh.Text = maKH;
                txtCustomerName.Text = Convert.ToString(dataGridView1.Rows[index].Cells["TenKH"].Value);
                txtCustomerPhoneNum.Text = Convert.ToString(dataGridView1.Rows[index].Cells["Sdt"].Value);
                radMaleCus.Checked = Convert.ToBoolean(dataGridView1.Rows[index].Cells["GioiTinh"].Value);
                if (!radMaleCus.Checked)
                {
                    radFemaleCus.Checked = true;
                }
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            string value = txtFind.Text;
            if (!string.IsNullOrEmpty(value))
            {
                DataTable tb = customerDAO.Find(value);
                dataGridView1.DataSource = tb;
            }
            else
            {
                showAll();
            }
        }

        private void txtFind_TextChanged(object sender, EventArgs e)
        {
            string value = txtFind.Text;
            if (string.IsNullOrEmpty(value))
            {
                //btnFind.Enabled = false;
                disablebtnFind.Execute();
            }
            else
            {
                //btnFind.Enabled = true;
                enablebtnFind.Execute();
            }
        }

        public bool checkData()
        {
            if (string.IsNullOrEmpty(txtCustomerName.Text))
            {
                MessageBox.Show("Vui lòng nhập Tên!!!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                txtCustomerName.Focus();
                return false;
            }
            if (!txtCustomerName.Validate())
            {
                MessageBox.Show("Tên không đúng định dạng!!!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Question);
                txtCustomerName.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtCustomerPhoneNum.Text))
            {
                MessageBox.Show("Vui lòng nhập Số điện thoại!!!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                txtCustomerPhoneNum.Focus();
                return false;
            }
            if (txtCustomerPhoneNum.Text.Length < 10)
            {
                MessageBox.Show("Số Điện Thoại phải có 10 chữ số!!!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Question);
                txtCustomerPhoneNum.Focus();
                return false;
            }
            if (!txtCustomerPhoneNum.Validate())
            {
                MessageBox.Show("Số Điện Thoại không đúng định dạng!!!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Question);
                txtCustomerPhoneNum.Focus();
                return false;
            }
            if (!radMaleCus.Checked && !radFemaleCus.Checked)
            {
                MessageBox.Show("Vui lòng chọn Giới Tính!!!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                radMaleCus.Checked = true;
                return false;
            }
            return true;
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if (checkData())
            {
                Customer customer = new Customer()
                {
                    maKH = maKH,
                    tenKH = txtCustomerName.Text,
                    sdt = txtCustomerPhoneNum.Text,
                    gioiTinh = radMaleCus.Checked ? true : false
                };
                if (customerDAO.Update(customer))
                {
                    MessageBox.Show("Sửa khách hàng thành công!!!",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    showAll();
                }
                else
                {
                    MessageBox.Show("Có lỗi xãy ra, Vui lòng thử lại!!!",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Stop);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Customer customer = new Customer()
                {
                    maKH = maKH,
                };
                if (customerDAO.Delete(customer))
                {
                    MessageBox.Show("Xóa khách hàng thành công!!!",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    showAll();
                    txtCustomerName.Text = "";
                    txtCustomerPhoneNum.Text = "";
                    txtMaKh.Text = "";
                    radFemaleCus.Checked = false;
                    radMaleCus.Checked = false;
                }
                else
                {
                    MessageBox.Show("Có lỗi xãy ra, Vui lòng thử lại!!!",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Stop);
                }
            }
        }

        private void btnDeleteTextBox_Click(object sender, EventArgs e)
        {
            txtCustomerName.Text = "";
            txtCustomerPhoneNum.Text = "";
            txtMaKh.Text = "";
            radFemaleCus.Checked = false;
            radMaleCus.Checked = false;
        }
    }
}