using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUANLYNHASACH
{
    public partial class NhanVien : Form
    {
        SqlConnection connsql;
        ConnSQL connect = new ConnSQL();
        public NhanVien()
        {
            InitializeComponent();
            connsql = connect.KetNoiCSDL();
            //connsql = new SqlConnection(@"Data Source=DESKTOP-EROU1IR\SQLEXPRESS;Initial Catalog=QL_NHASACH;Integrated Security=True");
        }
        

        private void loadLop_lv()
        {
            connsql.Open();
            string selectString = "select * from NHANVIEN";
            SqlCommand cmd = new SqlCommand(selectString, connsql);
            SqlDataReader rd = cmd.ExecuteReader();
            int n = 1;
            while (rd.Read())
            {
                ListViewItem item = new ListViewItem(new[] { n.ToString(), rd["TAIKHOAN"].ToString(), rd["HOTEN"].ToString(), rd["CCCD"].ToString(), rd["SDT"].ToString(), rd["GIOITINH"].ToString() });
                lst_nhanvien.Items.Add(item);
                n++;
            }
            connsql.Close();
            lst_nhanvien.FullRowSelect = true;
        }
        

        private void btn_them_Click(object sender, EventArgs e)
        {
            
        }

        private void NhanVien_Load(object sender, EventArgs e)
        {
           
            loadLop_lv();
        }

        private void lst_nhanvien_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            
        }
    }
}
