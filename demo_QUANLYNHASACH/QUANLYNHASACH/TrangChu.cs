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
    public partial class TrangChu : Form
    {
        //SqlConnection connsql;

        public TrangChu()
        {
            InitializeComponent();
            //connsql = new SqlConnection(@"Data Source=DESKTOP-EROU1IR\SQLEXPRESS;Initial Catalog=QL_NHASACH;Integrated Security=True");
        }
        

        private Form currentFormChild;
        private void openChildForm(Form childForm)
        {
            if(currentFormChild != null)
            {
                currentFormChild.Close();

            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pn_main.Controls.Add(childForm);
            pn_main.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btn_khachhang_Click(object sender, EventArgs e)
        {
            openChildForm(new KhachHang());
            label1.Text = btn_khachhang.Text;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();

            }
            label1.Text = "Trang chủ";
        }

        

        private void btn_tacgia_Click(object sender, EventArgs e)
        {
            openChildForm(new TACGIA());
            label1.Text = btn_tacgia.Text;
        }

        private void btn_theloai_Click(object sender, EventArgs e)
        {
            openChildForm(new TheLoai());
            label1.Text = btn_theloai.Text;
        }

        private void btn_nhacungcap_Click(object sender, EventArgs e)
        {
            openChildForm(new NhaCungCap());
            label1.Text = btn_nhacungcap.Text;
        }

        private void btn_nhanvien_Click(object sender, EventArgs e)
        {
            openChildForm(new NhanVien());
            label1.Text = btn_nhanvien.Text;
        }

        private void btn_thanhtoan_Click(object sender, EventArgs e)
        {
            openChildForm(new ThanhToan());
            label1.Text = btn_thanhtoan.Text;
        }

        private void btn_dangxuat_Click(object sender, EventArgs e)
        {
            DangNhap dn = new DangNhap();
            this.Hide();
            dn.ShowDialog();
        }

        private void btn_khosach_Click(object sender, EventArgs e)
        {
            openChildForm(new KhoSach());
            label1.Text = btn_khosach.Text;
        }

        private void btn_nhaphang_Click(object sender, EventArgs e)
        {
            openChildForm(new NHAPSACH());
            label1.Text = btn_nhaphang.Text;
        }

        private void btn_thongke_Click(object sender, EventArgs e)
        {
            openChildForm(new ThongKe());
            label1.Text = btn_thongke.Text;
        }
    }
}
