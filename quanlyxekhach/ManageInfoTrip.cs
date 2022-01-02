using quanlyxekhach.AbstractModel;
using quanlyxekhach.CommandButton;
using quanlyxekhach.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanlyxekhach
{
    public partial class ManageInfoTrip : Form
    {
        private InfoTripDAO infoTripDAO;
        private string maChuyen;

        private CommandButtonManage enablebtnFind, disablebtnFind,
            enablebtnChange, disablebtnChange,
            enablebtnUpdate, disablebtnUpdate;

        private void cbNameDriver_TextChanged(object sender, EventArgs e)
        {
            if (cbNameDriver.Text == "")
            {
                disablebtnChange.Execute();
                disablebtnUpdate.Execute();
            }
            else
            {
                enablebtnChange.Execute();
                enablebtnUpdate.Execute();
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            string value = txtFind.Text;
            if (!string.IsNullOrEmpty(value))
            {
                DataTable tb = infoTripDAO.Find(value);
                dataGridView1.DataSource = tb;
            }
            else
            {
                showAll();
            }
        }

        private void btnShowData_Click(object sender, EventArgs e)
        {
            var listTaiXe = infoTripDAO.GetAllTaiXe();
            cbNameDriver.DataSource = listTaiXe;
            cbNameDriver.DisplayMember = "TenNV";
            cbIdDriver.DataSource = listTaiXe;
            cbIdDriver.DisplayMember = "MaNV";

            var listHDV = infoTripDAO.GetAllHDV();
            cbNameTG.DataSource = listHDV;
            cbNameTG.DisplayMember = "TenNV";
            cbIdTG.DataSource = listHDV;
            cbIdTG.DisplayMember = "MaNV";

            var listVehicle = infoTripDAO.GetAllVehicle();
            cbIdVeh.DataSource = listVehicle;
            cbIdVeh.DisplayMember = "MaXe";

            var listLocation = infoTripDAO.GetAllLocation();
            cbNameLocation.DataSource = listLocation;
            cbNameLocation.DisplayMember = "TenDD";
        }

        public void ClearData()
        {
            cbIdDriver.Text = "";
            cbNameDriver.Text = "";
            cbIdTG.Text = "";
            cbNameTG.Text = "";
            cbIdVeh.Text = "";
            cbNameDriver.Text = "";
            cbNameLocation.Text = "";
            dtstar.Value = DateTime.Now;
            dtEnd.Value = DateTime.Now;
            disablebtnUpdate.Execute();
            disablebtnChange.Execute();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index < 0 || index >= dataGridView1.RowCount)
            {
                return;
            }
            // get data in cells of gridView
            DataGridViewRow row = dataGridView1.Rows[index];
            maChuyen = Convert.ToString(row.Cells[1].Value);
            String maTx = Convert.ToString(row.Cells[2].Value);
            String tenTX = Convert.ToString(row.Cells[3].Value);
            String maHDV = Convert.ToString(row.Cells[4].Value);
            String tenHDV = Convert.ToString(row.Cells[5].Value);
            String maChuyenXe = Convert.ToString(row.Cells[6].Value);
            String tenDD = Convert.ToString(row.Cells[7].Value);
            DateTime star = Convert.ToDateTime(row.Cells[8].Value);
            DateTime end = Convert.ToDateTime(row.Cells[9].Value);

            //upload UI
            cbIdDriver.Text = maTx;
            cbNameDriver.Text = tenTX;
            cbIdTG.Text = maHDV;
            cbNameTG.Text = tenHDV;
            cbIdVeh.Text = maChuyenXe;
            cbNameLocation.Text = tenDD;
            dtstar.Value = star;
            dtEnd.Value = end;
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            InfoTrip infoTrip = new InfoTrip();
            infoTrip.maChuyen = maChuyen;
            infoTrip.maTaiXe = cbIdDriver.Text;
            infoTrip.tenTaiXe = cbNameDriver.Text;
            infoTrip.maHuongDanVien = cbIdTG.Text;
            infoTrip.tenHuongDanVien = cbNameTG.Text;
            infoTrip.maCX = cbIdVeh.Text;
            infoTrip.tenDD = cbNameLocation.Text;
            infoTrip.ngayBatDau = dtstar.Value;
            infoTrip.ngayKetThuc = dtEnd.Value;

            if (infoTripDAO.Update(infoTrip))
            {
                MessageBox.Show("Sửa thông tin thành công!!!",
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DataTable tb = infoTripDAO.GetAll();
            int sttCount = tb.Rows.Count;
            InfoTrip infoTrip = new InfoTrip();
            infoTrip.maChuyen = "CD" + Convert.ToString(sttCount + 1);
            infoTrip.maTaiXe = cbIdDriver.Text;
            infoTrip.tenTaiXe = cbNameDriver.Text;
            infoTrip.maHuongDanVien = cbIdTG.Text;
            infoTrip.tenHuongDanVien = cbNameTG.Text;
            infoTrip.maCX = cbIdVeh.Text;
            infoTrip.tenDD = cbNameLocation.Text;
            infoTrip.ngayBatDau = dtstar.Value;
            infoTrip.ngayKetThuc = dtEnd.Value;

            if (infoTripDAO.Insert(infoTrip))
            {
                MessageBox.Show("Thêm thành công!!!",
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

        private void txtFind_TextChanged(object sender, EventArgs e)
        {
            if (txtFind.Text == "")
            {
                disablebtnFind.Execute();
                showAll();
            }
            else
            {
                enablebtnFind.Execute();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có thật sự muốn thoát ?", "Thoát ứng dụng", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (dialogResult == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void ManageInfoTrip_Load(object sender, EventArgs e)
        {
            disablebtnUpdate.Execute();
            disablebtnChange.Execute();
            disablebtnFind.Execute();
            showAll();
        }

        public ManageInfoTrip()
        {
            InitializeComponent();
            AbstractDbFactory sql = SqlFactory.GetInstance();
            infoTripDAO = new InfoTripDAO(sql);

            enablebtnChange = new ManageButtonEnable(btnChange);
            disablebtnChange = new ManageButtonDisable(btnChange);

            enablebtnFind = new ManageButtonEnable(btnFind);
            disablebtnFind = new ManageButtonDisable(btnFind);

            enablebtnUpdate = new ManageButtonEnable(btnUpdate);
            disablebtnUpdate = new ManageButtonDisable(btnUpdate);
        }

        public void showAll()
        {
            DataTable tb = infoTripDAO.GetAll();
            dataGridView1.DataSource = tb;
        }
    }
}
