using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QUANLYNHASACH
{
    public partial class DangKi : Form
    {
        SqlConnection connsql;
        ConnSQL connect = new ConnSQL();
        public DangKi()
        {
            InitializeComponent();
            connsql = connect.KetNoiCSDL();
            //connsql = new SqlConnection(@"Data Source=DESKTOP-EROU1IR\SQLEXPRESS;Initial Catalog=QL_NHASACH;Integrated Security=True");
        }
        private void loadcbb()
        {
            string[] gt = { "Nam", "Nữ" };
            foreach (string s in gt)
            {
                cbb_gioitinh.Items.Add(s);
            }

        }
        bool KT_TaiKhoan(string ma)
        {
            try
            {
                connsql.Open();
                string selectString = "Select Count(*) from NHANVIEN where TAIKHOAN= '" + ma + "' ";
                SqlCommand cmd = new SqlCommand(selectString, connsql);
                int count = (int)cmd.ExecuteScalar();
                connsql.Close();
                if (count >= 1)
                    return false;
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }

        private void btn_dk_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_mk.Text == txt_nhaplaimk.Text)
                {
                    if (KT_TaiKhoan(txt_taikhoan.Text) == true)
                    {
                        if (connsql.State == ConnectionState.Closed)
                        {
                            connsql.Open();
                        }
                        string insertString;
                        insertString = "Insert into NHANVIEN values( N'" + txt_hoten.Text + "','" + txt_taikhoan.Text + "', '" + txt_mk.Text + "', '"+txt_cccd.Text+"','"+txt_sdt.Text+"', N'"+cbb_gioitinh.SelectedItem.ToString()+"')";
                        SqlCommand cmd = new SqlCommand(insertString, connsql);
                        cmd.ExecuteNonQuery();
                        if (connsql.State == ConnectionState.Open)
                        {
                            connsql.Close();
                        }

                        MessageBox.Show("Đăng Kí Thành Công");
                        this.Hide();

                    }
                    else
                    {
                        MessageBox.Show("Tài khoản đã tồn tại. Vui lòng chọn tên tài khoản khác");
                       
                    }
                }
                else
                {
                    MessageBox.Show("Mật khẩu không trùng nhau");
                }

            }
            catch
            {
                MessageBox.Show("Thất Bại");
            }
        }

        private void txt_hoten_Leave(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Trim().Length == 0)
                this.errorProvider1.SetError(ctr, "Không để trống họ và tên");
            else
                this.errorProvider1.Clear();
        }

        private void txt_taikhoan_Leave(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Trim().Length == 0)
                this.errorProvider1.SetError(ctr, "Không để trống tên tài khoản");
            else
                this.errorProvider1.Clear();
        }
    
        private void txt_mk_Leave(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Trim().Length == 0)
                this.errorProvider1.SetError(ctr, "Không để trống mật khẩu");
            else
                this.errorProvider1.Clear();
        }

        private void txt_nhaplaimk_Leave(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Trim().Length == 0)
                this.errorProvider1.SetError(ctr, "Không để trống ô này");
            else
                this.errorProvider1.Clear();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            DangNhap dn = new DangNhap();
            this.Hide();
            dn.ShowDialog();
        }

        private void DangKi_Load(object sender, EventArgs e)
        {
            loadcbb();
        }
    }
}
