
namespace QUANLYNHASACH
{
    partial class ThongKe
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lst_hdnhap = new System.Windows.Forms.ListView();
            this.lst_hdxuat = new System.Windows.Forms.ListView();
            this.date_ngaybd = new System.Windows.Forms.DateTimePicker();
            this.btn_timkiem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.date_ngaykt = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_chiphi = new System.Windows.Forms.TextBox();
            this.txt_loinhuan = new System.Windows.Forms.TextBox();
            this.txt_doanhthu = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lst_hdnhap
            // 
            this.lst_hdnhap.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.lst_hdnhap.HideSelection = false;
            this.lst_hdnhap.Location = new System.Drawing.Point(12, 73);
            this.lst_hdnhap.Name = "lst_hdnhap";
            this.lst_hdnhap.Size = new System.Drawing.Size(690, 129);
            this.lst_hdnhap.TabIndex = 0;
            this.lst_hdnhap.UseCompatibleStateImageBehavior = false;
            this.lst_hdnhap.View = System.Windows.Forms.View.Details;
            // 
            // lst_hdxuat
            // 
            this.lst_hdxuat.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader13,
            this.columnHeader14});
            this.lst_hdxuat.HideSelection = false;
            this.lst_hdxuat.Location = new System.Drawing.Point(12, 232);
            this.lst_hdxuat.Name = "lst_hdxuat";
            this.lst_hdxuat.Size = new System.Drawing.Size(690, 142);
            this.lst_hdxuat.TabIndex = 1;
            this.lst_hdxuat.UseCompatibleStateImageBehavior = false;
            this.lst_hdxuat.View = System.Windows.Forms.View.Details;
            // 
            // date_ngaybd
            // 
            this.date_ngaybd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_ngaybd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_ngaybd.Location = new System.Drawing.Point(163, 16);
            this.date_ngaybd.Name = "date_ngaybd";
            this.date_ngaybd.Size = new System.Drawing.Size(112, 24);
            this.date_ngaybd.TabIndex = 3;
            this.date_ngaybd.Value = new System.DateTime(2022, 12, 13, 14, 34, 43, 0);
            // 
            // btn_timkiem
            // 
            this.btn_timkiem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_timkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_timkiem.Location = new System.Drawing.Point(555, 12);
            this.btn_timkiem.Name = "btn_timkiem";
            this.btn_timkiem.Size = new System.Drawing.Size(84, 36);
            this.btn_timkiem.TabIndex = 4;
            this.btn_timkiem.Text = "Tìm kiếm";
            this.btn_timkiem.UseVisualStyleBackColor = false;
            this.btn_timkiem.Click += new System.EventHandler(this.btn_timkiem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(93, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Từ ngày:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(336, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Đến ngày:";
            // 
            // date_ngaykt
            // 
            this.date_ngaykt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_ngaykt.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_ngaykt.Location = new System.Drawing.Point(416, 16);
            this.date_ngaykt.Name = "date_ngaykt";
            this.date_ngaykt.Size = new System.Drawing.Size(112, 24);
            this.date_ngaykt.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = "Hóa đơn nhập";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 18);
            this.label4.TabIndex = 10;
            this.label4.Text = "Hóa đơn xuất";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã HĐ";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên NCC";
            this.columnHeader2.Width = 118;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Ngày nhập";
            this.columnHeader3.Width = 79;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Tên Sách";
            this.columnHeader4.Width = 174;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Số lượng";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Đơn giá";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Tổng tiền";
            this.columnHeader7.Width = 85;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Mã HĐ";
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Tên KH";
            this.columnHeader9.Width = 118;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Ngày nhập";
            this.columnHeader10.Width = 76;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Tên sách";
            this.columnHeader11.Width = 179;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Số lượng";
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Đơn giá";
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "Tổng tiền";
            this.columnHeader14.Width = 83;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(28, 397);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 18);
            this.label5.TabIndex = 11;
            this.label5.Text = "Chi Phí";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(229, 397);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 18);
            this.label6.TabIndex = 12;
            this.label6.Text = "Doanh Thu";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(464, 397);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 18);
            this.label7.TabIndex = 13;
            this.label7.Text = "Lợi Nhuận";
            // 
            // txt_chiphi
            // 
            this.txt_chiphi.Enabled = false;
            this.txt_chiphi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_chiphi.Location = new System.Drawing.Point(89, 394);
            this.txt_chiphi.Name = "txt_chiphi";
            this.txt_chiphi.Size = new System.Drawing.Size(100, 24);
            this.txt_chiphi.TabIndex = 14;
            this.txt_chiphi.Text = "0";
            // 
            // txt_loinhuan
            // 
            this.txt_loinhuan.Enabled = false;
            this.txt_loinhuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_loinhuan.Location = new System.Drawing.Point(545, 394);
            this.txt_loinhuan.Name = "txt_loinhuan";
            this.txt_loinhuan.Size = new System.Drawing.Size(100, 24);
            this.txt_loinhuan.TabIndex = 15;
            this.txt_loinhuan.Text = "0";
            // 
            // txt_doanhthu
            // 
            this.txt_doanhthu.Enabled = false;
            this.txt_doanhthu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_doanhthu.Location = new System.Drawing.Point(316, 394);
            this.txt_doanhthu.Name = "txt_doanhthu";
            this.txt_doanhthu.Size = new System.Drawing.Size(100, 24);
            this.txt_doanhthu.TabIndex = 16;
            this.txt_doanhthu.Text = "0";
            // 
            // ThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 461);
            this.Controls.Add(this.txt_doanhthu);
            this.Controls.Add(this.txt_loinhuan);
            this.Controls.Add(this.txt_chiphi);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.date_ngaykt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_timkiem);
            this.Controls.Add(this.date_ngaybd);
            this.Controls.Add(this.lst_hdxuat);
            this.Controls.Add(this.lst_hdnhap);
            this.Name = "ThongKe";
            this.Text = "ThongKe";
            this.Load += new System.EventHandler(this.ThongKe_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lst_hdnhap;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ListView lst_hdxuat;
        private System.Windows.Forms.DateTimePicker date_ngaybd;
        private System.Windows.Forms.Button btn_timkiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker date_ngaykt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_chiphi;
        private System.Windows.Forms.TextBox txt_loinhuan;
        private System.Windows.Forms.TextBox txt_doanhthu;
    }
}