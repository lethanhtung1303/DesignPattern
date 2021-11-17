﻿using quanlyxekhach.AbstractModel;
using quanlyxekhach.Models;
using System;
using System.Data;
using System.Windows.Forms;

namespace quanlyxekhach
{
    public partial class ManageEmployee : Form
    {
        private EmployeeDAO employeeDAO;

        public ManageEmployee()
        {
            InitializeComponent();
            AbstractDbFactory sql = SqlFactory.GetInstance();
            employeeDAO = new EmployeeDAO(sql);
        }

        public void showAll()
        {
            DataTable tb = employeeDAO.GetAll();
            dataGridView1.DataSource = tb;
        }

        private void ManageEmployee_Load(object sender, EventArgs e)
        {
            btnAdd.Enabled = true;
            btnDelete.Enabled = false;
            btnChange.Enabled = false;
            btnFind.Enabled = false;
            bbtnClear.Enabled = true;
            showAll();
        }

        public bool CheckData()
        {
            if (string.IsNullOrEmpty(txtNameE.Text))
            {
                MessageBox.Show("Vui lòng nhập Tên!!!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                txtNameE.Focus();
                return false;
            }
            if (!txtNameE.Validate())
            {
                MessageBox.Show("Tên không đúng định dạng!!!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Question);
                txtNameE.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtPhoneEmp.Text))
            {
                MessageBox.Show("Vui lòng nhập Số điện thoại!!!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                txtPhoneEmp.Focus();
                return false;
            }
            if (!txtPhoneEmp.Validate() || txtPhoneEmp.Text.Length < 10)
            {
                MessageBox.Show("Số Điện Thoại phải có 10 chữ số!!!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Question);
                txtPhoneEmp.Focus();
                return false;
            }
            if (!radMale.Checked && !radFemale.Checked)
            {
                MessageBox.Show("Vui lòng chọn Giới Tính!!!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                radMale.Checked = true;
                return false;
            }
            if (string.IsNullOrEmpty(txtPosition.Text))
            {
                MessageBox.Show("Vui lòng nhập Chức Vụ!!!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                txtPosition.Focus();
                return false;
            }
            if (!txtPosition.Validate())
            {
                MessageBox.Show("Chức Vụ không đúng định dạng!!!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Question);
                txtPosition.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(dtBirth.Text))
            {
                MessageBox.Show("Vui lòng nhập Ngày Sinh!!!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                dtBirth.Focus();
                return false;
            }
            if (!dtBirth.Validate())
            {
                MessageBox.Show("Ngày Sinh không đúng định dạng [dd / MM / yyyy]!!!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Question);
                dtBirth.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(dtDayWork.Text))
            {
                MessageBox.Show("Vui lòng nhập Ngày Vào Làm!!!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                dtDayWork.Focus();
                return false;
            }
            if (!dtDayWork.Validate())
            {
                MessageBox.Show("Ngày Vào Làm không đúng định dạng [dd / MM / yyyy]!!!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Question);
                dtDayWork.Focus();
                return false;
            }
            return true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (CheckData())
            {
                DataTable tb = employeeDAO.GetAll();
                Employee employee = new Employee()
                {
                    MaNV = "NV" + Convert.ToString(tb.Rows.Count + 1),
                    TenNV = txtNameE.Text,
                    SDT = txtPhoneEmp.Text,
                    GioiTinh = radMale.Checked ? true : false,
                    ChucVu = txtPosition.Text,
                    NgaySinh = dtBirth.Text,
                    NgayVaoLam = dtDayWork.Text
                };
                if (employeeDAO.Insert(employee))
                {
                    MessageBox.Show("Thêm Nhân Viên thành công!!!",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    showAll();
                }
                else
                {
                    MessageBox.Show("Có lỗi xãy ra, Vui lòng thử lại sau!!!",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Stop);
                }
            }
        }

        public void ClearData()
        {
            txtStt.Text = "";
            txtMaSo.Text = "";
            txtNameE.Text = "";
            txtPhoneEmp.Text = "";
            txtPosition.Text = "";
            dtBirth.Text = "";
            dtDayWork.Text = "";
            radFemale.Checked = false;
            radMale.Checked = false;
            showAll();
            btnAdd.Enabled = true;
            btnDelete.Enabled = false;
            btnChange.Enabled = false;
        }

        private void bbtnClear_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private string maNV;

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnAdd.Enabled = false;
            btnDelete.Enabled = true;
            btnChange.Enabled = true;
            var index = e.RowIndex;
            if (index >= 0)
            {
                maNV = Convert.ToString(dataGridView1.Rows[index].Cells["MaNV"].Value);
                txtNameE.Text = Convert.ToString(dataGridView1.Rows[index].Cells["TenNV"].Value);
                txtPhoneEmp.Text = Convert.ToString(dataGridView1.Rows[index].Cells["SDT"].Value);
                radMale.Checked = Convert.ToBoolean(dataGridView1.Rows[index].Cells["GioiTinh"].Value);
                if (!radMale.Checked)
                {
                    radFemale.Checked = true;
                }
                txtPosition.Text = Convert.ToString(dataGridView1.Rows[index].Cells["ChucVu"].Value);
                dtBirth.Text = Convert.ToString(dataGridView1.Rows[index].Cells["NgaySinh"].Value);
                dtDayWork.Text = Convert.ToString(dataGridView1.Rows[index].Cells["NgayVaoLam"].Value);
            }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if (CheckData())
            {
                Employee employee = new Employee()
                {
                    MaNV = maNV,
                    TenNV = txtNameE.Text,
                    SDT = txtPhoneEmp.Text,
                    GioiTinh = radMale.Checked ? true : false,
                    ChucVu = txtPosition.Text,
                    NgaySinh = dtBirth.Text,
                    NgayVaoLam = dtDayWork.Text
                };
                if (employeeDAO.Update(employee))
                {
                    MessageBox.Show("Sửa Nhân Viên thành công!!!",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    showAll();
                }
                else
                {
                    MessageBox.Show("Có lỗi xãy ra, Vui lòng thử lại sau!!!",
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
                Employee employee = new Employee()
                {
                    MaNV = maNV,
                };
                if (employeeDAO.Delete(employee))
                {
                    MessageBox.Show("Xóa Nhân Viên thành công!!!",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    showAll();
                }
                else
                {
                    MessageBox.Show("Có lỗi xãy ra, Vui lòng thử lại sau!!!",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Stop);
                }
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            string value = txtFind.Text;
            if (!string.IsNullOrEmpty(value))
            {
                DataTable tb = employeeDAO.Find(value);
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
                btnFind.Enabled = false;
            }
            else
            {
                btnFind.Enabled = true;
            }
        }
    }
}