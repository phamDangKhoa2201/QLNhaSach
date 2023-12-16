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
    public partial class ThanhToan : Form
    {
        SqlConnection connsql;
        ConnSQL connect = new ConnSQL();
        public ThanhToan()
        {
            InitializeComponent();
            connsql = connect.KetNoiCSDL();
            //connsql = new SqlConnection(@"Data Source=DESKTOP-EROU1IR\SQLEXPRESS;Initial Catalog=QL_NHASACH;Integrated Security=True");
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void loadLop_lv()
        {
            connsql.Open();
            string selectString = "select S.*,TG.TENTG,TL.TENTHELOAI from (SACH S RIGHT JOIN TACGIA TG ON S.MATG=TG.MATG) RIGHT JOIN THELOAI TL ON S.MATL=TL.MATL";
            SqlCommand cmd = new SqlCommand(selectString, connsql);
            SqlDataReader rd = cmd.ExecuteReader();
            int n = 1;
            while (rd.Read())
            {
                int a = int.Parse(rd["GIABAN"].ToString());
                double b = a *  1.3;
                ListViewItem item = new ListViewItem(new[] { n.ToString(), rd["MASACH"].ToString(), rd["TENSACH"].ToString(), rd["TENTG"].ToString(), rd["TENTHELOAI"].ToString(), b.ToString(),rd["SOLUONG"].ToString() });
                lst_sach.Items.Add(item);
                n++;
            }
            connsql.Close();
            lst_sach.FullRowSelect = true;
        }

        
        private void loadtg_cbb()
        {
            connsql.Open();
            DataSet ds = new DataSet();
            string strselect = "Select * from TACGIA";
            SqlDataAdapter da = new SqlDataAdapter(strselect, connsql);
            da.Fill(ds, "TACGIA");
            cbb_tacgia.DataSource = ds.Tables[0];
            cbb_tacgia.DisplayMember = "TENTG";
            cbb_tacgia.ValueMember = "MATG";
            connsql.Close();
        }
        private void loadkh_cbb()
        {
            connsql.Open();
            DataSet ds = new DataSet();
            string strselect = "Select * from KHACHHANG";
            SqlDataAdapter da = new SqlDataAdapter(strselect, connsql);
            da.Fill(ds, "KHACHHANG");
            cbb_kh.DataSource = ds.Tables[0];
            cbb_kh.DisplayMember = "MAKH";
            cbb_kh.ValueMember = "MAKH";
            connsql.Close();
        }
        private void loadtl_cbb()
        {
            connsql.Open();
            DataSet ds = new DataSet();
            string strselect = "Select * from THELOAI";
            SqlDataAdapter da = new SqlDataAdapter(strselect, connsql);
            da.Fill(ds, "THELOAI");
            cbb_theloai.DataSource = ds.Tables[0];
            cbb_theloai.DisplayMember = "TENTHELOAI";
            cbb_theloai.ValueMember = "MATL";
            connsql.Close();
        }
        private void loadmahdn_txt()
        {
           
            connsql.Open();

            string strselect = "select  top(1) MAHDX  from HOADONXUAT order by MAHDX  desc";
            SqlCommand cmd = new SqlCommand(strselect, connsql);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                txt_mahoadonxuat.Text = rd["MAHDX"].ToString();
            }

            rd.Close();

            connsql.Close();
        }
        private void loadcthd_lv()
        {
            string selectString = "select *  FROM CTHOADONXUAT where MAHDX='" + txt_mahoadonxuat.Text+ "'";
            SqlCommand cmd = new SqlCommand(selectString, connsql);
            SqlDataReader rd = cmd.ExecuteReader();
            //int n = 1;
            while (rd.Read())
            {
                ListViewItem item = new ListViewItem(new[] { rd["MAHDX"].ToString(), rd["MASACH"].ToString(), rd["SOLUONG"].ToString(), rd["DONGIA"].ToString(), rd["TONGTIEN"].ToString() });
                lst_cthdxuat.Items.Add(item);
                //n++;
            }


            lst_cthdxuat.FullRowSelect = true;
        }
        private void loadslconlai_txt()
        {
            connsql.Open();

            string strselect = "select SOLUONG from SACH where MASACH='"+txt_masach.Text+"'";
            SqlCommand cmd = new SqlCommand(strselect, connsql);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                txt_slconlai.Text = rd["SOLUONG"].ToString();
            }

            rd.Close();

            connsql.Close();
        }

        private void ThanhToan_Load(object sender, EventArgs e)
        {
            
            loadLop_lv();
            loadkh_cbb();
            loadtg_cbb();
            loadtl_cbb();
            
            

            txt_dongia.Enabled = false;
            txt_masach.Enabled = false;
            txt_soluong.Enabled = false;
            txt_tensach.Enabled = false;
            cbb_tacgia.Enabled = false;
            cbb_theloai.Enabled = false;
            txt_thanhtien.Enabled = false;
            txt_tongtien.Enabled = false;
            btn_themsach.Enabled = false;
            btn_thanhtoan.Enabled = false;

            rdb_theloai.Enabled = false;
            rdb_tacgia.Enabled = false;
            btn_timsach.Enabled = false;

            txt_thanhtien.Hide();
            txt_mahoadonxuat.Hide();
            txt_slconlai.Hide();
        }

        private void lst_sach_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListViewItem item = lst_sach.FocusedItem;
            txt_masach.Text = item.SubItems[1].Text;
            txt_tensach.Text = item.SubItems[2].Text;
            cbb_tacgia.Text = item.SubItems[3].Text;
            cbb_theloai.Text = item.SubItems[4].Text;
            txt_dongia.Text = item.SubItems[5].Text;
        }

        private void btn_taohd_Click(object sender, EventArgs e)
        {
            try
            {

                if (connsql.State == ConnectionState.Closed)
                {
                    connsql.Open();
                }
                string insertString;
                insertString = "set dateformat dmy  insert into HOADONXUAT(MAKH,NGAYXUAT) values('"+cbb_kh.SelectedValue.ToString()+"', '" + date_thuchien.Text + "')";
                SqlCommand cmd = new SqlCommand(insertString, connsql);
                cmd.ExecuteNonQuery();
                if (connsql.State == ConnectionState.Open)
                {
                    connsql.Close();
                }
                //lst_sach.Items.Clear();
                //loadLop_lv();
                MessageBox.Show("Thêm thành công");
                loadmahdn_txt();
                cbb_kh.Enabled = false;
                date_thuchien.Enabled = false;
                btn_taohd.Enabled = false;
                
                txt_masach.Enabled = true;
                txt_soluong.Enabled = true;
                txt_tensach.Enabled = true;
                cbb_tacgia.Enabled = true;
                cbb_theloai.Enabled = true;
                btn_themsach.Enabled = true;
                
                rdb_theloai.Enabled = true;
                rdb_tacgia.Enabled = true;
                btn_timsach.Enabled = true;


            }

            catch (Exception ex)
            {
                MessageBox.Show("Thêm thất bại");
            }
        }

        private void btn_themsach_Click(object sender, EventArgs e)
        {
            try
            {
                connsql.Open();
                //loadslconlai_txt();
                int slban = int.Parse(txt_soluong.Text);
                int slconlai = int.Parse(txt_slconlai.Text);
                if (slconlai > slban)
                {
                    string insertString;
                    float dongia = float.Parse(txt_dongia.Text);
                    int sl = int.Parse(txt_soluong.Text);
                    float tongtien = dongia * sl;
                    insertString = " insert into CTHOADONXUAT values('" + txt_mahoadonxuat.Text + "', '" + txt_masach.Text + "'," + sl + ", " + dongia + ", " + tongtien + ")";
                    SqlCommand cmd = new SqlCommand(insertString, connsql);
                    cmd.ExecuteNonQuery();

                    //lst_sach.Items.Clear();
                    //loadLop_lv();

                    MessageBox.Show("Thêm thành công");
                    btn_thanhtoan.Enabled = true;
                    txt_thanhtien.Text = (dongia * sl).ToString();
                    float tam = float.Parse(txt_tongtien.Text);
                    float tong = 0;
                    float a = dongia * sl;
                    tong = tong + a + tam;
                    txt_tongtien.Text = tong.ToString();
                    
                    string insertSach;
                    insertSach = "update SACH set SOLUONG= SOLUONG - " + txt_soluong.Text + " where MASACH= '" + txt_masach.Text + "'";
                    SqlCommand cmd1 = new SqlCommand(insertSach, connsql);
                    cmd1.ExecuteNonQuery();
                    lst_cthdxuat.Items.Clear();
                    loadcthd_lv();
                    connsql.Close();
                }
                else
                {
                    MessageBox.Show("Số lượng trong kho không đủ !!!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                }
                

            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm thất bại");
            }
        }

        private void btn_thanhtoan_Click(object sender, EventArgs e)
        {
            float tam = float.Parse(txt_tongtien.Text);
            float tong = 0;
            //float a = float.Parse(txt_thanhtien.Text);
            tong = tong + tam;
            MessageBox.Show("Tổng tiền phải thanh toán là: " + tong.ToString() + "", "Hóa Đơn",
                MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            lst_sach.Items.Clear();
            loadLop_lv();
            
            lst_sach.FullRowSelect = true;
            txt_dongia.Enabled = false;
            txt_masach.Enabled = false;
            txt_soluong.Enabled = false;
            txt_tensach.Enabled = false;
            cbb_tacgia.Enabled = false;
            cbb_theloai.Enabled = false;
            txt_thanhtien.Enabled = false;
            txt_tongtien.Enabled = false;
            btn_themsach.Enabled = false;
            btn_thanhtoan.Enabled = false;
            rdb_theloai.Enabled = false;
            rdb_tacgia.Enabled = false;
            btn_timsach.Enabled = false;
            cbb_kh.Enabled = true;
            date_thuchien.Enabled = true;
            btn_taohd.Enabled = true;
            
            txt_dongia.Clear();
            txt_soluong.Clear();
            txt_masach.Clear();
            txt_tensach.Clear();
            txt_thanhtien.Clear();
            txt_tongtien.Text = 0.ToString();
            lst_cthdxuat.Items.Clear();
        }

        private void btn_timsach_Click(object sender, EventArgs e)
        {
            connsql.Open();
            if (rdb_tacgia.Checked == true)
            {
                lst_sach.Items.Clear();
                string selectString = "select S.*,TG.TENTG,TL.TENTHELOAI from (SACH S RIGHT JOIN TACGIA TG ON S.MATG=TG.MATG) RIGHT JOIN THELOAI TL ON S.MATL=TL.MATL where TG.MATG= '" + cbb_tacgia.SelectedValue.ToString() + "'";
                SqlCommand cmd = new SqlCommand(selectString, connsql);
                SqlDataReader rd = cmd.ExecuteReader();
                int n = 1;
                while (rd.Read())
                {
                    int a = int.Parse(rd["GIABAN"].ToString());
                    double b = a * 1.3;
                    ListViewItem item = new ListViewItem(new[] { n.ToString(), rd["MASACH"].ToString(), rd["TENSACH"].ToString(), rd["TENTG"].ToString(), rd["TENTHELOAI"].ToString(), b.ToString() });
                    lst_sach.Items.Add(item);
                    n++;
                }
            }
            if (rdb_theloai.Checked == true)
            {
                lst_sach.Items.Clear();
                string selectString1 = "select S.*,TG.TENTG,TL.TENTHELOAI from (SACH S RIGHT JOIN TACGIA TG ON S.MATG=TG.MATG) RIGHT JOIN THELOAI TL ON S.MATL=TL.MATL where TL.MATL= '" + cbb_theloai.SelectedValue.ToString() + "'";
                SqlCommand cmd1 = new SqlCommand(selectString1, connsql);
                SqlDataReader rd1 = cmd1.ExecuteReader();
                int n = 1;
                while (rd1.Read())
                {
                    int a = int.Parse(rd1["GIABAN"].ToString());
                    double b = a * 1.3;
                    ListViewItem item = new ListViewItem(new[] { n.ToString(), rd1["MASACH"].ToString(), rd1["TENSACH"].ToString(), rd1["TENTG"].ToString(), rd1["TENTHELOAI"].ToString(), b.ToString() });
                    lst_sach.Items.Add(item);
                    n++;
                }
            }
            connsql.Close();
            lst_sach.FullRowSelect = true;
        }

        private void txt_masach_TextChanged(object sender, EventArgs e)
        {
            loadslconlai_txt();
        }

        private void txt_tongtien_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btn_inhdxuat_Click(object sender, EventArgs e)
        {
            connsql.Open();
            DataTable dt = new DataTable();
            string strselect = "select * from hdxuat where MAHDX= "+txt_mahoadonxuat.Text+"";
            SqlDataAdapter da = new SqlDataAdapter(strselect, connsql);
            da.Fill(dt);

            frm_xuat f = new frm_xuat();
            ReportXuat rpt = new ReportXuat();
            rpt.SetDataSource(dt);

            f.crystalReportViewer1.ReportSource = rpt;
            f.crystalReportViewer1.Refresh();
            f.ShowDialog();

            connsql.Close();
        }

        private void btn_sapten_Click(object sender, EventArgs e)
        {
            lst_sach.Items.Clear();
            string selectString = "select S.*,TG.TENTG,TL.TENTHELOAI from (SACH S RIGHT JOIN TACGIA TG ON S.MATG=TG.MATG) RIGHT JOIN THELOAI TL ON S.MATL=TL.MATL where TG.MATG= '" + cbb_tacgia.SelectedValue.ToString() + "'";
            SqlCommand cmd = new SqlCommand(selectString, connsql);
            SqlDataReader rd = cmd.ExecuteReader();
            int n = 1;
            while (rd.Read())
            {
                int a = int.Parse(rd["GIABAN"].ToString());
                double b = a * 1.3;
                ListViewItem item = new ListViewItem(new[] { n.ToString(), rd["MASACH"].ToString(), rd["TENSACH"].ToString(), rd["TENTG"].ToString(), rd["TENTHELOAI"].ToString(), b.ToString() });
                lst_sach.Items.Add(item);
                n++;
            }
        }
    }
}
