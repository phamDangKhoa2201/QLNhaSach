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
    public partial class DangNhap : Form
    {
        
        SqlConnection connsql;
        ConnSQL connect = new ConnSQL();
        public DangNhap()
        {
            InitializeComponent();
            connsql = connect.KetNoiCSDL();
            //connsql = new SqlConnection(@"Data Source=DESKTOP-EROU1IR\SQLEXPRESS;Initial Catalog=QL_NHASACH;Integrated Security=True");

        }
        private void btn_dangnhap_Click(object sender, EventArgs e)
        {
            try
            {
                connsql.Open();
                string tk = txt_tk.Text;
                string mk = txt_mk.Text;
                string sql = "select * from NHANVIEN where TAIKHOAN = '" + tk + "' and MATKHAU= '" + mk + "'";
                SqlCommand cmd = new SqlCommand(sql, connsql);
                SqlDataReader rd = cmd.ExecuteReader();
                if(rd.Read()==true)
                {
                    MessageBox.Show("Đăng nhập thành công");
                    TrangChu tc = new TrangChu();
                    this.Hide();
                    tc.ShowDialog();
                    this.Show();
                    rd.Close();
                } 
                else
                {
                    rd.Close();
                    MessageBox.Show("Sai mật khẩu hoặc tài khoản");
                    txt_tk.Clear();
                    txt_mk.Clear();
                    txt_tk.Focus();
                    
                }
                connsql.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi kết nỗi");
            }
            //TrangChu tc = new TrangChu();
            //this.Hide();
            //tc.ShowDialog();
            //this.Show();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_dangki_Click(object sender, EventArgs e)
        {
            DangKi dk = new DangKi();
            this.Hide();
            dk.ShowDialog();
            this.Show();
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {

        }
    }
}
