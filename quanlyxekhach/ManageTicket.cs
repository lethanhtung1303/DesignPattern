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
    public partial class ManageTicket : Form
    {
        private TicketDao ticketDAO;
        private CommandButtonManage enableBtnFind, disableBtnFind, 
            enableBtnDelete, disableBtnDelete;
        private Ticket currentTicket;
        private string dataInfo;
        private void ManageTicket_Load(object sender, EventArgs e)
        {
            showAll();
            disableBtnFind.Execute();
            disableBtnDelete.Execute();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            string value = txtFind.Text;
            if (!string.IsNullOrEmpty(value))
            {
                DataTable tb = ticketDAO.Find(value);
                dataGridView1.DataSource = tb;
            }
            else
            {
                showAll();
            }
        }

        private void txtFind_TextChanged(object sender, EventArgs e)
        {
            if (txtFind.Text == "")
            {
                disableBtnFind.Execute();
                showAll();
            }
            else
            {
                enableBtnFind.Execute();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index < 0 || index >= dataGridView1.RowCount)
            {
                return;
            }
            else
            {
                // get data in cells of gridView
                DataGridViewRow row = dataGridView1.Rows[index];
                currentTicket = new Ticket();
                currentTicket.MaPhieu = Convert.ToString(row.Cells[1].Value);
                currentTicket.MaKH = Convert.ToString(row.Cells[2].Value);
                currentTicket.TenKH = Convert.ToString(row.Cells[3].Value);
                currentTicket.MaNVBV = Convert.ToString(row.Cells[4].Value);
                currentTicket.TenNVBV = Convert.ToString(row.Cells[5].Value);
                currentTicket.SoTien = Convert.ToInt32(row.Cells[6].Value);
                currentTicket.ChoNgoi = Convert.ToString(row.Cells[7].Value);
                currentTicket.MaChuyenxe = Convert.ToString(row.Cells[8].Value);
                currentTicket.NgayKhoiHanh = Convert.ToString(row.Cells[9].Value);
                currentTicket.TenDD = Convert.ToString(row.Cells[10].Value);

                //enable button Delete
                enableBtnDelete.Execute();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (ticketDAO.Delete(currentTicket))
                {
                    MessageBox.Show("Xóa vé thành công!!!",
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

        public ManageTicket(string dataSend)
        {
            InitializeComponent();
            CreateTicketDao();
            enableBtnFind = new ManageButtonEnable(btnFind);
            disableBtnFind = new ManageButtonDisable(btnFind);

            enableBtnDelete = new ManageButtonEnable(btnDelete);
            disableBtnDelete = new ManageButtonDisable(btnDelete);

            dataInfo = dataSend;
        }

        public void CreateTicketDao()
        {
            AbstractDbFactory sql = SqlFactory.GetInstance();
            ticketDAO = new TicketDao(sql);
        }

        public void showAll()
        {
            DataTable tb = ticketDAO.GetAll();
            dataGridView1.DataSource = tb;
        }
    }
}
