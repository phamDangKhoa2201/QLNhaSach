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
    public partial class ThongKe : Form
    {
        SqlConnection connsql;
        ConnSQL connect = new ConnSQL();
        public ThongKe()
            
        {
            InitializeComponent();
            connsql = connect.KetNoiCSDL();
        }
        private void loadhdn_lv()
        {
            connsql.Open();
            string selectString = "set dateformat dmy select hdn.MAHDN, TENCC,NGAYNHAP,TENSACH,cthd.SOLUONG,DONGIA,TONGTIEN from HOADONNHAP hdn,CTHOADONNHAP cthd, NHACUNGCAP ncc, SACH s where hdn.MAHDN=cthd.MAHDN and hdn.MANCC=ncc.MANCC and s.MASACH=cthd.MASACH and hdn.NGAYNHAP between '" + date_ngaybd.Text+"' and '"+date_ngaykt.Text+"'";
            SqlCommand cmd = new SqlCommand(selectString, connsql);
            SqlDataReader rd = cmd.ExecuteReader();
            //int n = 1;
            while (rd.Read())
                
            {
                int a = int.Parse(rd["TONGTIEN"].ToString());
                int tam = int.Parse(txt_chiphi.Text);
                int tong = a + tam;
                txt_chiphi.Text = tong.ToString();
                ListViewItem item = new ListViewItem(new[] { rd["MAHDN"].ToString(), rd["TENCC"].ToString(), rd["NGAYNHAP"].ToString(), rd["TENSACH"].ToString(), rd["SOLUONG"].ToString(), rd["DONGIA"].ToString(), rd["TONGTIEN"].ToString() });
                lst_hdnhap.Items.Add(item);
                //n++;
            }
            connsql.Close();
            lst_hdnhap.FullRowSelect = true;
        }
        private void loadhdx_lv()
        {
            connsql.Open();
            string selectString = "set dateformat dmy select hdx.MAHDX, TENKH,NGAYXUAT,TENSACH,cthdx.SOLUONG,DONGIA,TONGTIEN from HOADONXUAT hdx,CTHOADONXUAT cthdx, KHACHHANG kh, SACH s where hdx.MAHDX=cthdx.MAHDX and hdx.MAKH=kh.MAKH and s.MASACH=cthdx.MASACH and hdx.NGAYXUAT between '" + date_ngaybd.Text+"' and '"+date_ngaykt.Text+"'";
            SqlCommand cmd = new SqlCommand(selectString, connsql);
            SqlDataReader rd = cmd.ExecuteReader();
            //int n = 1;
            while (rd.Read())
            {
                double a = double.Parse(rd["TONGTIEN"].ToString());
                double tam = double.Parse(txt_doanhthu.Text);
                double tong = a + tam;
                txt_doanhthu.Text = tong.ToString();
                ListViewItem item = new ListViewItem(new[] { rd["MAHDX"].ToString(), rd["TENKH"].ToString(), rd["NGAYXUAT"].ToString(), rd["TENSACH"].ToString(), rd["SOLUONG"].ToString(), rd["DONGIA"].ToString(), rd["TONGTIEN"].ToString() });
                lst_hdxuat.Items.Add(item);
                //n++;
            }
            connsql.Close();
            lst_hdxuat.FullRowSelect = true;
        }

        private void ThongKe_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            lst_hdnhap.Items.Clear();
            lst_hdxuat.Items.Clear();
            loadhdn_lv();
            loadhdx_lv();
            double a = double.Parse(txt_chiphi.Text);
            double b = double.Parse(txt_doanhthu.Text);
            txt_loinhuan.Text = (b - a).ToString();
        }
    }
}
