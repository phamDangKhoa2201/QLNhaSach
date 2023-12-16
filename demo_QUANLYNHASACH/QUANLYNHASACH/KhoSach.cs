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
    public partial class KhoSach : Form
    {
        SqlConnection connsql;
        ConnSQL connect = new ConnSQL();
        public KhoSach()
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
                ListViewItem item = new ListViewItem(new[] { n.ToString(), rd["MASACH"].ToString(), rd["TENSACH"].ToString(), rd["TENTG"].ToString(), rd["TENTHELOAI"].ToString(),rd["NAMXB"].ToString(),rd["GIABAN"].ToString(),rd["SOLUONG"].ToString() });
                lst_sach.Items.Add(item);
                n++;
            }
            connsql.Close();
            lst_sach.FullRowSelect = true;
        }

        private void lst_sach_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListViewItem item = lst_sach.FocusedItem;
            txt_masach.Text = item.SubItems[1].Text;
            txt_tensach.Text = item.SubItems[2].Text;
            cbb_tacgia.Text = item.SubItems[3].Text;
            cbb_theloai.Text = item.SubItems[4].Text;
            txt_namxb.Text = item.SubItems[5].Text;
            txt_gianhap.Text = item.SubItems[6].Text;
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

        private void KhoSach_Load(object sender, EventArgs e)
        {
            loadLop_lv();
            loadtg_cbb();
            loadtl_cbb();
            txt_soluong.Hide();
            btn_xoa.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_masach.Text == string.Empty)
                {
                    MessageBox.Show("Bạn phải nhập " + label1.Text);
                    txt_masach.Focus();
                    return;
                }
                if (KT_KhoaChinh(txt_masach.Text) == true)
                {
                    if (connsql.State == ConnectionState.Closed)
                    {
                        connsql.Open();
                    }
                    string insertString;
                    insertString = "insert into SACH values('" + txt_masach.Text + "', N'" + txt_tensach.Text + "', '" + cbb_tacgia.SelectedValue.ToString() + "','" + cbb_theloai.SelectedValue.ToString()+ "' , " + txt_namxb.Text + " , "+ txt_gianhap.Text +", "+txt_soluong.Text+")";
                    SqlCommand cmd = new SqlCommand(insertString, connsql);
                    cmd.ExecuteNonQuery();
                    if (connsql.State == ConnectionState.Open)
                    {
                        connsql.Close();
                    }
                    lst_sach.Items.Clear();
                    loadLop_lv();
                    MessageBox.Show("Thêm thành công");
                }
                else
                {
                    MessageBox.Show("Trùng mã nhà cung cấp");
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm thất bại");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                {
                    if (txt_masach.Text == string.Empty)
                    {
                        MessageBox.Show("Bạn phải nhập " + label1.Text);
                        txt_masach.Focus();
                        return;
                    }
                    if (connsql.State == ConnectionState.Closed)
                    {
                        connsql.Open();
                    }
                    string deleteString = "delete SACH where MASACH='" + txt_masach.Text + "'";
                    SqlCommand cmd = new SqlCommand(deleteString, connsql);
                    cmd.ExecuteNonQuery();
                    if (connsql.State == ConnectionState.Open)
                    {
                        connsql.Close();
                    }
                    lst_sach.Items.Clear();
                    loadLop_lv();
                    MessageBox.Show("Xóa thành công");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Xóa thất bại");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                {
                    if (txt_masach.Text == string.Empty)
                    {
                        MessageBox.Show("Bạn phải nhập " + label1.Text);
                        txt_masach.Focus();
                        return;
                    }
                    if (connsql.State == ConnectionState.Closed)
                    {
                        connsql.Open();
                    }
                    string updateString = "update SACH set TENSACH= N'" + txt_tensach.Text + "', MATG= '" + cbb_tacgia.SelectedValue.ToString() + "',MATL= '" + cbb_theloai.SelectedValue.ToString() + "', NAMXB= " + txt_namxb.Text+ ", GIABAN= "+txt_gianhap.Text+" where MASACH='" + txt_masach.Text + "'";
                    SqlCommand cmd = new SqlCommand(updateString, connsql);
                    cmd.ExecuteNonQuery();
                    if (connsql.State == ConnectionState.Open)
                    {
                        connsql.Close();
                    }
                    lst_sach.Items.Clear();
                    loadLop_lv();
                    MessageBox.Show("Sửa thành công");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Sửa thất bại");
            }
        }
    }
}
