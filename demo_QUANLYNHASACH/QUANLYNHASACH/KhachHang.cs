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
    public partial class KhachHang : Form
    {
        SqlConnection connsql;
        ConnSQL connect = new ConnSQL();
        public KhachHang()
        {
            InitializeComponent();
            connsql = connect.KetNoiCSDL();
            //connsql = new SqlConnection(@"Data Source=DESKTOP-EROU1IR\SQLEXPRESS;Initial Catalog=QL_NHASACH;Integrated Security=True");

        }
        bool KT_KhoaChinh(string pma)
        {
            connsql.Open();
            string selectString = "Select * from KHACHHANG Where MAKH = '" + pma + "' ";
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
            string selectString = "select * from KHACHHANG";
            SqlCommand cmd = new SqlCommand(selectString, connsql);
            SqlDataReader rd = cmd.ExecuteReader();
            int n = 1;
            while (rd.Read())
            {
                ListViewItem item = new ListViewItem(new[] { n.ToString(), rd["MAKH"].ToString(), rd["TENKH"].ToString(), rd["DIACHI"].ToString(), rd["SDT"].ToString() });
                lst_kh.Items.Add(item);
                n++;
            }
            connsql.Close();
            lst_kh.FullRowSelect = true;
        }
        private void btn_them_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_makh.Text == string.Empty)
                {
                    MessageBox.Show("Bạn phải nhập " + label2.Text);
                    txt_makh.Focus();
                    return;
                }
                if (KT_KhoaChinh(txt_makh.Text) == true)
                {
                    if (connsql.State == ConnectionState.Closed)
                    {
                        connsql.Open();
                    }
                    string insertString;
                    insertString = "insert into KHACHHANG values('" + txt_makh.Text + "',N'" + txt_tenkh.Text + "',N'" + txt_diachi.Text + "','" + txt_sdt.Text + "')";
                    SqlCommand cmd = new SqlCommand(insertString, connsql);
                    cmd.ExecuteNonQuery();
                    if (connsql.State == ConnectionState.Open)
                    {
                        connsql.Close();
                    }
                    lst_kh.Items.Clear();
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

        private void lst_kh_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListViewItem item = lst_kh.FocusedItem;
            txt_makh.Text = item.SubItems[1].Text;
            txt_tenkh.Text = item.SubItems[2].Text;
            txt_diachi.Text = item.SubItems[3].Text;
            txt_sdt.Text = item.SubItems[4].Text;
        }

        private void KhachHang_Load(object sender, EventArgs e)
        {
            loadLop_lv();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            try
            {
                {
                    if (txt_makh.Text == string.Empty)
                    {
                        MessageBox.Show("Bạn phải nhập " + label2.Text);
                        txt_makh.Focus();
                        return;
                    }
                    if (connsql.State == ConnectionState.Closed)
                    {
                        connsql.Open();
                    }
                    string deleteString = "delete KHACHHANG where MAKH='" + txt_makh.Text + "'";
                    SqlCommand cmd = new SqlCommand(deleteString, connsql);
                    cmd.ExecuteNonQuery();
                    if (connsql.State == ConnectionState.Open)
                    {
                        connsql.Close();
                    }
                    lst_kh.Items.Clear();
                    loadLop_lv();
                    MessageBox.Show("Xóa thành công");
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Xóa thất bại");
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            try
            {
                {
                    if (txt_makh.Text == string.Empty)
                    {
                        MessageBox.Show("Bạn phải nhập " + label2.Text);
                        txt_makh.Focus();
                        return;
                    }
                    if (connsql.State == ConnectionState.Closed)
                    {
                        connsql.Open();
                    }
                    string updateString = "update KHACHHANG set TENKH= N'" + txt_tenkh.Text + "', DIACHI= N'" + txt_diachi.Text + "',SDT= N'" + txt_sdt.Text + "' where MAKH='" + txt_makh.Text + "'";
                    SqlCommand cmd = new SqlCommand(updateString, connsql);
                    cmd.ExecuteNonQuery();
                    if (connsql.State == ConnectionState.Open)
                    {
                        connsql.Close();
                    }
                    lst_kh.Items.Clear();
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
