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
    public partial class TACGIA : Form
    {
        SqlConnection connsql;
        ConnSQL connect = new ConnSQL();
        public TACGIA()
        {
            InitializeComponent();
            connsql = connect.KetNoiCSDL();
            //connsql = new SqlConnection(@"Data Source=DESKTOP-EROU1IR\SQLEXPRESS;Initial Catalog=QL_NHASACH;Integrated Security=True");
        }


        bool KT_KhoaChinh(string pma)
        {
            connsql.Open();
            string selectString = "Select * from TACGIA Where MATG= '" + pma + "' ";
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
            string selectString = "select * from TacGia";
            SqlCommand cmd = new SqlCommand(selectString, connsql);
            SqlDataReader rd = cmd.ExecuteReader();
            int n = 1;
            while (rd.Read())
            {
                ListViewItem item = new ListViewItem(new[] { n.ToString(), rd["MaTG"].ToString(), rd["TenTG"].ToString() });
                lsttacgia.Items.Add(item);
                n++;
            }
            connsql.Close();
            lsttacgia.FullRowSelect = true;
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtmatacgia.Text == string.Empty)
                {
                    MessageBox.Show("Bạn phải nhập " + labelmatacgia.Text);
                    txtmatacgia.Focus();
                    return;
                }
                if (KT_KhoaChinh(txtmatacgia.Text) == true)
                {
                    if (connsql.State == ConnectionState.Closed)
                    {
                        connsql.Open();
                    }
                    string insertString;
                    insertString = "insert into TACGIA values('" + txtmatacgia.Text + "', N'" + txttentacgia.Text + "')";
                    SqlCommand cmd = new SqlCommand(insertString, connsql);
                    cmd.ExecuteNonQuery();
                    if (connsql.State == ConnectionState.Open)
                    {
                        connsql.Close();
                    }
                    lsttacgia.Items.Clear();
                    loadLop_lv();
                    MessageBox.Show("Thêm thành công");
                }
                else
                {
                    MessageBox.Show("Trùng mã tác giả");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm thất bại");
            }
        }

        private void TACGIA_Load(object sender, EventArgs e)
        {
            loadLop_lv();
        }

        private void lsttacgia_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListViewItem item = lsttacgia.FocusedItem;
            txtmatacgia.Text = item.SubItems[1].Text;
            txttentacgia.Text = item.SubItems[2].Text;
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            try
            {
                {
                    if (txtmatacgia.Text == string.Empty)
                    {
                        MessageBox.Show("Bạn phải nhập " + labelmatacgia.Text);
                        txtmatacgia.Focus();
                        return;
                    }
                    if (connsql.State == ConnectionState.Closed)
                    {
                        connsql.Open();
                    }
                    string deleteString = "delete TACGIA where MATG='" + txtmatacgia.Text + "'";
                    SqlCommand cmd = new SqlCommand(deleteString, connsql);
                    cmd.ExecuteNonQuery();
                    if (connsql.State == ConnectionState.Open)
                    {
                        connsql.Close();
                    }
                    lsttacgia.Items.Clear();
                    loadLop_lv();
                    MessageBox.Show("Xóa thành công");
                }

            }
            catch(Exception ex)
            {

                MessageBox.Show("Xóa thất bại");
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            try
            {
                {
                    if (txtmatacgia.Text == string.Empty)
                    {
                        MessageBox.Show("Bạn phải nhập " + labelmatacgia.Text);
                        txtmatacgia.Focus();
                        return;
                    }
                    if (connsql.State == ConnectionState.Closed)
                    {
                        connsql.Open();
                    }
                    string updateString = "update TACGIA set TENTG= N'" + txttentacgia.Text + "' where MATG='"+ txtmatacgia.Text + "'";
                    SqlCommand cmd = new SqlCommand(updateString, connsql);
                    cmd.ExecuteNonQuery();
                    if (connsql.State == ConnectionState.Open)
                    {
                        connsql.Close();
                    }
                    lsttacgia.Items.Clear();
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


