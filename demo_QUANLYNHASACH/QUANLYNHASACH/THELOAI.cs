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
    public partial class TheLoai : Form
    {
        ConnSQL connect = new ConnSQL();
        SqlConnection connsql ;
        public TheLoai()
        {   
            {
                InitializeComponent();
                //connsql = new SqlConnection(@"Data Source=DESKTOP-EROU1IR\SQLEXPRESS;Initial Catalog=QL_NHASACH;Integrated Security=True");
                connsql = connect.KetNoiCSDL();
            }
        }
        private void loadLop_lv()
        {
            connsql.Open();
            string selectString = "select * from TheLoai";
            SqlCommand cmd = new SqlCommand(selectString, connsql);
            SqlDataReader rd = cmd.ExecuteReader();
            int n = 1;
            while (rd.Read())
            {
                ListViewItem item = new ListViewItem(new[] { n.ToString(), rd["MATL"].ToString(), rd["TENTHELOAI"].ToString() });
                lsttheloai.Items.Add(item);
                n++;
            }
            connsql.Close();
            lsttheloai.FullRowSelect = true;
        }
        bool KT_KhoaChinh(string pma)
        {
            connsql.Open();
            string selectString = "Select * from THELOAI Where MATL= '" + pma + "' ";
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

        private void btnthem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtmatheloai.Text == string.Empty)
                {
                    MessageBox.Show("Bạn phải nhập " + labelmatheloai.Text);
                    txtmatheloai.Focus();
                    return;
                }
                if (KT_KhoaChinh(txtmatheloai.Text) == true)
                {
                    if (connsql.State == ConnectionState.Closed)
                    {
                        connsql.Open();
                    }
                    string insertString;
                    insertString = "insert into THELOAI values('" + txtmatheloai.Text + "', N'" + txttentheloai.Text + "')";
                    SqlCommand cmd = new SqlCommand(insertString, connsql);
                    cmd.ExecuteNonQuery();
                    if (connsql.State == ConnectionState.Open)
                    {
                        connsql.Close();
                    }
                    lsttheloai.Items.Clear();
                    loadLop_lv();
                    MessageBox.Show("Thêm thành công");
                }
                else
                {
                    MessageBox.Show("Trùng mã thể loại");
                }    
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm thất bại");
            }
        }
        

        private void lsttheloai_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListViewItem item = lsttheloai.FocusedItem;
            txtmatheloai.Text = item.SubItems[1].Text;
            txttentheloai.Text = item.SubItems[2].Text;
        }

        private void TheLoai_Load(object sender, EventArgs e)
        {
            loadLop_lv();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            try
            {
                {
                    if (txtmatheloai.Text == string.Empty)
                    {
                        MessageBox.Show("Bạn phải nhập " + labelmatheloai.Text);
                        txtmatheloai.Focus();
                        return;
                    }
                    if (connsql.State == ConnectionState.Closed)
                    {
                        connsql.Open();
                    }
                    string deleteString = "delete THELOAI where MATL='" + txtmatheloai.Text + "'";
                    SqlCommand cmd = new SqlCommand(deleteString, connsql);
                    cmd.ExecuteNonQuery();
                    if (connsql.State == ConnectionState.Open)
                    {
                        connsql.Close();
                    }
                    lsttheloai.Items.Clear();
                    loadLop_lv();
                    MessageBox.Show("Xóa thành công");
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Xóa thất bại");
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            try
            {
                {
                    if (txtmatheloai.Text == string.Empty)
                    {
                        MessageBox.Show("Bạn phải nhập " + labelmatheloai.Text);
                        txtmatheloai.Focus();
                        return;
                    }
                    if (connsql.State == ConnectionState.Closed)
                    {
                        connsql.Open();
                    }
                    string updateString = "update THELOAI set TENTHELOAI= N'" + txttentheloai.Text + "' where MATL='" + txtmatheloai.Text + "'";
                    SqlCommand cmd = new SqlCommand(updateString, connsql);
                    cmd.ExecuteNonQuery();
                    if (connsql.State == ConnectionState.Open)
                    {
                        connsql.Close();
                    }
                    lsttheloai.Items.Clear();
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
