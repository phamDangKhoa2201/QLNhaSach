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
    public partial class NHAPSACH : Form
    {
        SqlConnection connsql;
        ConnSQL connect = new ConnSQL();
        public NHAPSACH()
        {
            InitializeComponent();
            connsql = connect.KetNoiCSDL();
            //connsql = new SqlConnection(@"Data Source=DESKTOP-EROU1IR\SQLEXPRESS;Initial Catalog=QL_NHASACH;Integrated Security=True");
        }
        bool KT_KhoaChinh(string pma)
        {
            connsql.Open();
            string selectString = "Select * from SACH Where MASACH = '" + pma + "' ";
            SqlCommand cmd = new SqlCommand(selectString, connsql);
            SqlDataReader re = cmd.ExecuteReader();
            if (re.HasRows)
            {
                re.Close();
                connsql.Close();
                return false;
            }
            else
            {
                re.Close();
                connsql.Close();
                return true;
            }
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
                ListViewItem item = new ListViewItem(new[] { n.ToString(), rd["MASACH"].ToString(), rd["TENSACH"].ToString(), rd["TENTG"].ToString(), rd["TENTHELOAI"].ToString(), rd["GIABAN"].ToString(),rd["SOLUONG"].ToString() });
                lst_nhapsach.Items.Add(item);
                n++;
            }
            connsql.Close();
            lst_nhapsach.FullRowSelect = true;
        }
        private void loadcthd_lv()
        {
            string selectString = "select *  FROM CTHOADONNHAP where MAHDN='" + txt_mahoadonnhap.Text + "'";
            SqlCommand cmd = new SqlCommand(selectString, connsql);
            SqlDataReader rd = cmd.ExecuteReader();
            //int n = 1;
            while (rd.Read())
            {
                ListViewItem item = new ListViewItem(new[] { rd["MAHDN"].ToString(), rd["MASACH"].ToString(), rd["SOLUONG"].ToString(), rd["DONGIA"].ToString(), rd["TONGTIEN"].ToString() });
                lst_cthoadonnhap.Items.Add(item);
                //n++;
            }


            lst_cthoadonnhap.FullRowSelect = true;
        }

        private void lst_nhapsach_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListViewItem item = lst_nhapsach.FocusedItem;
            txt_masach.Text = item.SubItems[1].Text;
            txt_tensach.Text = item.SubItems[2].Text;
            cbb_tacgia.Text = item.SubItems[3].Text;
            cbb_theloai.Text = item.SubItems[4].Text;
            txt_dongia.Text = item.SubItems[5].Text;
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
        private void loadncc_cbb()
        {
            connsql.Open();
            DataSet ds = new DataSet();
            string strselect = "Select * from NHACUNGCAP";
            SqlDataAdapter da = new SqlDataAdapter(strselect, connsql);
            da.Fill(ds, "NHACUNGCAP");
            cbb_ncc.DataSource = ds.Tables[0];
            cbb_ncc.DisplayMember = "MANCC";
            cbb_ncc.ValueMember = "MANCC";
            connsql.Close();
        }
        private void loadmahdn_txt()
        {
            
            connsql.Open();
            
            string strselect = "select  top(1) MAHDN  from HOADONNHAP order by MAHDN  desc";
            SqlCommand cmd = new SqlCommand(strselect, connsql);
            SqlDataReader rd = cmd.ExecuteReader();
            while(rd.Read())
            {
                txt_mahoadonnhap.Text = rd["MAHDN"].ToString();
            }    

            rd.Close();
            
            connsql.Close();
        }
        

        private void NHAPSACH_Load(object sender, EventArgs e)
        {
            loadLop_lv();
            loadncc_cbb();
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
            txt_mahoadonnhap.Hide();
            btn_inhd.Enabled = false;
            

        }

        private void label8_Click(object sender, EventArgs e)
        {

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
                insertString = "set dateformat dmy  insert into HOADONNHAP(MANCC,NGAYNHAP) values('" + cbb_ncc.SelectedValue.ToString() + "', '" + date_ngaynhap.Text + "')";
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
                cbb_ncc.Enabled = false;
                date_ngaynhap.Enabled = false;
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
                
                string insertString;
                float dongia = float.Parse(txt_dongia.Text);
                int sl = int.Parse(txt_soluong.Text);
                float tongtien = dongia * sl;
                insertString = " insert into CTHOADONNHAP values('" + txt_mahoadonnhap.Text + "', '" + txt_masach.Text + "'," + sl + ", " + dongia + ", " + tongtien + ")";
                SqlCommand cmd = new SqlCommand(insertString, connsql);
                cmd.ExecuteNonQuery();

                
                
                MessageBox.Show("Thêm thành công");
                
                btn_thanhtoan.Enabled = true;
                txt_thanhtien.Text = (dongia * sl).ToString();
                float tam = float.Parse(txt_tongtien.Text);
                float tong = 0;
                float a = dongia * sl;
                tong = tong + a + tam;
                txt_tongtien.Text = tong.ToString();
                
                string insertSach;
                insertSach = "update SACH set SOLUONG= SOLUONG + " + txt_soluong.Text + " where MASACH= '" + txt_masach.Text + "'";
                SqlCommand cmd1 = new SqlCommand(insertSach, connsql);
                cmd1.ExecuteNonQuery();
                lst_cthoadonnhap.Items.Clear();
                
                loadcthd_lv();
                
                connsql.Close();
                
            }


            catch (Exception ex)
            {
                MessageBox.Show("Thêm thất bại");
            }
        }

        private void txt_thanhtien_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btn_thanhtoan_Click(object sender, EventArgs e)

        {
            float tam = float.Parse(txt_tongtien.Text);
            float tong = 0;
            //float a = float.Parse(txt_thanhtien.Text);
            tong = tong  + tam ;
            MessageBox.Show("Tổng tiền phải thanh toán là: " + tong.ToString() + "", "Hóa Đơn",
                MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            lst_nhapsach.Items.Clear();
            loadLop_lv();
            //report();
            btn_inhd.Enabled = true;
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
            cbb_ncc.Enabled = true;
            date_ngaynhap.Enabled = true;
            btn_taohd.Enabled = true;
           
            txt_dongia.Clear();
            txt_soluong.Clear();
            txt_masach.Clear();
            txt_tensach.Clear();
            txt_thanhtien.Clear();
            txt_tongtien.Text = 0.ToString();
            lst_cthoadonnhap.Items.Clear();
        }

        private void btn_timsach_Click(object sender, EventArgs e)
        {
            connsql.Open();
            if (rdb_tacgia.Checked == true)
            {
                lst_nhapsach.Items.Clear();
                string selectString = "select S.*,TG.TENTG,TL.TENTHELOAI from (SACH S RIGHT JOIN TACGIA TG ON S.MATG=TG.MATG) RIGHT JOIN THELOAI TL ON S.MATL=TL.MATL where TG.MATG= '"+cbb_tacgia.SelectedValue.ToString()+"'";
                SqlCommand cmd = new SqlCommand(selectString, connsql);
                SqlDataReader rd = cmd.ExecuteReader();
                int n = 1;
                while (rd.Read())
                {
                    ListViewItem item = new ListViewItem(new[] { n.ToString(), rd["MASACH"].ToString(), rd["TENSACH"].ToString(), rd["TENTG"].ToString(), rd["TENTHELOAI"].ToString(), rd["GIABAN"].ToString(),rd["SOLUONG"].ToString() });
                    lst_nhapsach.Items.Add(item);
                    n++;
                }
            }
            if(rdb_theloai.Checked==true)
            {
                lst_nhapsach.Items.Clear();
                string selectString1 = "select S.*,TG.TENTG,TL.TENTHELOAI from (SACH S RIGHT JOIN TACGIA TG ON S.MATG=TG.MATG) RIGHT JOIN THELOAI TL ON S.MATL=TL.MATL where TL.MATL= '" + cbb_theloai.SelectedValue.ToString() + "'";
                SqlCommand cmd1 = new SqlCommand(selectString1, connsql);
                SqlDataReader rd1 = cmd1.ExecuteReader();
                int n = 1;
                while (rd1.Read())
                {
                    ListViewItem item = new ListViewItem(new[] { n.ToString(), rd1["MASACH"].ToString(), rd1["TENSACH"].ToString(), rd1["TENTG"].ToString(), rd1["TENTHELOAI"].ToString(), rd1["GIABAN"].ToString(),rd1["SOLUONG"].ToString() });
                    lst_nhapsach.Items.Add(item);
                    n++;
                }
            }    
            connsql.Close();
            lst_nhapsach.FullRowSelect = true;
        }

        private void txt_tongtien_TextChanged(object sender, EventArgs e)
        {
            //loadcthd_lv();
        }

        private void btn_inhd_Click(object sender, EventArgs e)
        {
            connsql.Open();
            DataTable dt = new DataTable();
            string strselect = "select * from hdnhap where MAHDN= "+txt_mahoadonnhap.Text+"";
            SqlDataAdapter da = new SqlDataAdapter(strselect, connsql);
            da.Fill(dt);

            frm_nhap f = new frm_nhap(); 
            ReportNhap rpt = new ReportNhap();
            rpt.SetDataSource(dt);
            
            f.crystalReportViewer1.ReportSource = rpt;
            f.crystalReportViewer1.Refresh();
            f.ShowDialog();
            
            connsql.Close();
        }
    }
}
