using quanlyxekhach.AbstractModel;
using quanlyxekhach.CommandButton;
using quanlyxekhach.DAO;
using quanlyxekhach.IDAO;
using quanlyxekhach.Models;
using quanlyxekhach.Models.TicketBuilder;
using System;
using System.Data;
using System.Windows.Forms;

namespace quanlyxekhach
{
    public partial class ManageTicket : Form
    {
        private ITicketDao ticketDAO;

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
                ITicketBuilder ticketBuilder = new TicketBuilder(); 
                currentTicket = ticketBuilder.AddMaPhieu(Convert.ToString(row.Cells[1].Value))
                    .AdddMaKh(Convert.ToString(row.Cells[2].Value))
                    .AddTenKH(Convert.ToString(row.Cells[3].Value))
                    .AddMaNVBV(Convert.ToString(row.Cells[4].Value))
                    .AddTenNVBV(Convert.ToString(row.Cells[5].Value))
                    .AddSoTien(Convert.ToInt32(row.Cells[6].Value))
                    .AddChoNgoi(Convert.ToString(row.Cells[7].Value))
                    .AddMaChuyenXe(Convert.ToString(row.Cells[8].Value))
                    .AddNgayKhoihanh(Convert.ToString(row.Cells[9].Value))
                    .AddTenDD(Convert.ToString(row.Cells[10].Value)).Builder();

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