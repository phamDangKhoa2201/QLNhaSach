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
    public partial class NhaCungCap : Form
    {
        SqlConnection connsql;
        ConnSQL connect = new ConnSQL();
        public NhaCungCap()
        {
            InitializeComponent();
            connsql = connect.KetNoiCSDL();
            //connsql = new SqlConnection(@"Data Source=DESKTOP-EROU1IR\SQLEXPRESS;Initial Catalog=QL_NHASACH;Integrated Security=True");
        }
        bool KT_KhoaChinh(string pma)
        {
            connsql.Open();
            string selectString = "Select * from NHACUNGCAP Where MANCC = '" + pma + "' ";
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
        private void btn_them_Click(object sender, EventArgs e)
        {
            try
            {
                if ( txt_tenncc.Text == string.Empty)
                {
                    MessageBox.Show("Bạn phải nhập " + lb_tenncc.Text);
                    txt_mancc.Focus();
                    return;
                }
                if (KT_KhoaChinh(txt_mancc.Text) == true)
                {
                    if (connsql.State == ConnectionState.Closed)
                    {
                        connsql.Open();
                    }
                    string insertString;
                    insertString = "insert into NHACUNGCAP values('" + txt_mancc.Text + "',N'" + txt_tenncc.Text + "',N'" + txt_diachincc.Text + "','" + txt_sdtncc.Text + "')";
                    SqlCommand cmd = new SqlCommand(insertString, connsql);
                    cmd.ExecuteNonQuery();
                    if (connsql.State == ConnectionState.Open)
                    {
                        connsql.Close();
                    }
                    lst_NhaCC.Items.Clear();
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
        private void loadLop_lv()
        {
            connsql.Open();
            string selectString = "select * from NHACUNGCAP";
            SqlCommand cmd = new SqlCommand(selectString, connsql);
            SqlDataReader rd = cmd.ExecuteReader();
            int n = 1;
            while (rd.Read())
            {
                ListViewItem item = new ListViewItem(new[] { n.ToString(), rd["MANCC"].ToString(), rd["TENCC"].ToString(), rd["DIACHI"].ToString(), rd["SDT"].ToString() });
                lst_NhaCC.Items.Add(item);
                n++;
            }
            connsql.Close();
            lst_NhaCC.FullRowSelect = true;
        }

        private void NhaCungCap_Load(object sender, EventArgs e)
        {
            loadLop_lv();
        }

        private void lst_NhaCC_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListViewItem item = lst_NhaCC.FocusedItem;
            txt_mancc.Text = item.SubItems[1].Text; 
            txt_tenncc.Text = item.SubItems[2].Text;
            txt_diachincc.Text = item.SubItems[3].Text;
            txt_sdtncc.Text = item.SubItems[4].Text;
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            try
            {
                {
                    if (txt_mancc.Text == string.Empty) 
                    {
                        MessageBox.Show("Bạn phải nhập " + lb_mancc.Text);
                        txt_mancc.Focus(); 
                        return;
                    }
                    if (connsql.State == ConnectionState.Closed)
                    {
                        connsql.Open();
                    }
                    string deleteString = "delete NHACUNGCAP where MANCC='" + txt_mancc.Text + "'";
                    SqlCommand cmd = new SqlCommand(deleteString, connsql);
                    cmd.ExecuteNonQuery();
                    if (connsql.State == ConnectionState.Open)
                    {
                        connsql.Close();
                    }
                    lst_NhaCC.Items.Clear(); 
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
                    if (txt_mancc.Text == string.Empty) 
                    {
                        MessageBox.Show("Bạn phải nhập " + lb_mancc.Text);
                        txt_mancc.Focus();
                        return;
                    }
                    if (connsql.State == ConnectionState.Closed)
                    {
                        connsql.Open();
                    }
                    string updateString = "update NHACUNGCAP set TENCC= N'" + txt_tenncc.Text + "', DIACHI= N'"+txt_diachincc.Text+"',SDT= N'"+txt_sdtncc.Text+"' where MANCC='" + txt_mancc.Text + "'";
                    SqlCommand cmd = new SqlCommand(updateString, connsql);
                    cmd.ExecuteNonQuery();
                    if (connsql.State == ConnectionState.Open)
                    {
                        connsql.Close();
                    }
                    lst_NhaCC.Items.Clear();
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
