using quanlyxekhach.AbstractModel;
using quanlyxekhach.CommandButton;
using quanlyxekhach.formFactory;
using quanlyxekhach.Models;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace quanlyxekhach
{
    public partial class Payment : Form
    {
        private LocationDao locationDao;
        private AccountDao accountDao;
        private CustomerDAO customerDao;
        private TicketDao ticketDao;
        private string dataInfo;
        private FormController formController;
        private CommandButtonManage enablePayment, disablePayment;

        public Payment(string dataSend)
        {
            InitializeComponent();
            AbstractDbFactory sql = SqlFactory.GetInstance();
            locationDao = new LocationDao(sql);
            accountDao = new AccountDao(sql);
            customerDao = new CustomerDAO(sql);
            ticketDao = new TicketDao(sql);
            dataInfo = dataSend;
            enablePayment= new ManageButtonEnable(btnPayment);
            disablePayment = new ManageButtonDisable(btnPayment);
            disablePayment.Execute();
        }

        private void btnShowDataBox_Click(object sender, System.EventArgs e)
        {
            var listCar = locationDao.GetAllTemp();
            cbIDveh.DataSource = listCar;
            cbIDveh.DisplayMember = "MaXe";

            var listLocation = locationDao.GetAll();
            cbLocation.DataSource = listLocation;
            cbLocation.DisplayMember = "TebDD";
            cbCost.DataSource = listLocation;
            cbCost.DisplayMember = "GiaTien";

            var accountInfo = accountDao.GetAccount(dataInfo);
            txtNameEmp.Text = accountInfo.TenNv;
            txtIdEmp.Text = accountInfo.MaNV;

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
            if (string.IsNullOrEmpty(txtPhoneNum.Text))
            {
                MessageBox.Show("Vui lòng nhập Số điện thoại!!!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                txtPhoneNum.Focus();
                return false;
            }
         /*   if (!txtCustomerPhoneNum.Validate() || txtCustomerPhoneNum.Text.Length < 10)
            {
                MessageBox.Show("Số Điện Thoại phải có 10 chữ số!!!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Question);
                txtCustomerPhoneNum.Focus();
                return false;
            }*/// phần này cần valid lại
            if (!radMaleCus.Checked && !radFemaleCus.Checked)
            {
                MessageBox.Show("Vui lòng chọn Giới Tính!!!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                radMaleCus.Checked = true;
                return false;
            }
            if (string.IsNullOrEmpty(txtNameEmp.Text))
            {
                MessageBox.Show("Vui lòng bấm nút hiển thị dữ liệu để lấy dữ liệu!!!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                txtCusPay.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtSit.Text))
            {
                MessageBox.Show("Vui lòng nhập vị trí ghế!!!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                txtCusPay.Focus();
                return false;
            }
            if (!txtSit.Validate())
            {
                MessageBox.Show("Vị trí ghế nhập vào không đúng định dạng!!!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Question);
                txtCusPay.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtCusPay.Text))
            {
                MessageBox.Show("Vui lòng nhập số tiền khách trả!!!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                txtCusPay.Focus();
                return false;
            }
            if (!txtCusPay.Validate())
            {
                MessageBox.Show("Số tiền nhập vào không đúng định dạng!!!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Question);
                txtCusPay.Focus();
                return false;
            }
            if (Convert.ToInt32(txtCusPay.Text) < Convert.ToInt32(cbCost.Text))
            {
                MessageBox.Show("Số tiền khách trả phải lớn hơn số tiền cần trả");
                return false;
            }

            return true;
        }
        private void btnPayment_Click(object sender, System.EventArgs e)
        {
            if(checkData())
            {
                var toTalCustomer = customerDao.Count();
                var totalTicket = ticketDao.Count();
                Customer customer = new Customer();

                customer.maKH = "KH" + Convert.ToString(toTalCustomer + 1);
                customer.tenKH = txtCustomerName.Text;
                customer.sdt = txtPhoneNum.Text;
                customer.gioiTinh = radMaleCus.Checked ? true : false;

                var addCustomer = customerDao.Insert(customer);
                if (addCustomer)
                {
                    string format = "yyyy-MM-dd HH:mm:ss";
                    Ticket ticket = new Ticket()
                    {
                        MaPhieu = "PV" + Convert.ToString(totalTicket + 1),
                        MaKH = "KH" + Convert.ToString(toTalCustomer + 1),
                        TenKH = txtCustomerName.Text,
                        TenNVBV = txtNameEmp.Text,
                        MaNVBV = txtIdEmp.Text,
                        SoTien = Convert.ToInt32(cbCost.Text),
                        ChoNgoi = txtSit.Text,
                        NgayKhoiHanh = Convert.ToDateTime(dtTimeStart.Text).ToString(format),
                        MaChuyenxe = cbIDveh.Text,
                        TenDD = cbLocation.Text
                    };
                    var addTicket = ticketDao.Add(ticket);
                    if (addTicket)
                    {
                        MessageBox.Show("Mua vé thành công");
                    }
                }
                
            }
            
        }

        private void radMaleCus_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtCustomerName_TextChanged(object sender, EventArgs e)
        {
            if (txtCustomerName.TextLength >0)
            {
                enablePayment.Execute();
            }
        }

        private void txtPhoneNum_TextChanged(object sender, EventArgs e)
        {
            if (txtNameEmp.TextLength > 0)
            {
                enablePayment.Execute();
            }
        }

        private void txtSit_TextChanged(object sender, EventArgs e)
        {
            if (txtSit.TextLength > 0)
            {
                enablePayment.Execute();
            }
        }

        private void txtCusPay_TextChanged(object sender, EventArgs e)
        {
            if (txtCusPay.TextLength > 0)
            {
                enablePayment.Execute();
            }
        }

        private void thôngTinNgườiDùngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var accountInfo = accountDao.GetAccount(dataInfo);
            MessageBox.Show("Tên người dùng: " + accountInfo.TenNv + "\nChức vụ: " + accountInfo.ChucVu + "\nTên tài khoản: " + accountInfo.TenTK);
        }
    }
}