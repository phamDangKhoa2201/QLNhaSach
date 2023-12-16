namespace QUANLYNHASACH
{
    partial class NhaCungCap
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
            this.lb_mancc = new System.Windows.Forms.Label();
            this.lb_tenncc = new System.Windows.Forms.Label();
            this.lb_diachincc = new System.Windows.Forms.Label();
            this.lb_sdtncc = new System.Windows.Forms.Label();
            this.btn_them = new System.Windows.Forms.Button();
            this.txt_mancc = new System.Windows.Forms.TextBox();
            this.txt_tenncc = new System.Windows.Forms.TextBox();
            this.txt_diachincc = new System.Windows.Forms.TextBox();
            this.txt_sdtncc = new System.Windows.Forms.TextBox();
            this.lst_NhaCC = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_mancc
            // 
            this.lb_mancc.AutoSize = true;
            this.lb_mancc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_mancc.Location = new System.Drawing.Point(5, 39);
            this.lb_mancc.Name = "lb_mancc";
            this.lb_mancc.Size = new System.Drawing.Size(117, 16);
            this.lb_mancc.TabIndex = 1;
            this.lb_mancc.Text = "Mã Nhà Cung Cấp";
            // 
            // lb_tenncc
            // 
            this.lb_tenncc.AutoSize = true;
            this.lb_tenncc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tenncc.Location = new System.Drawing.Point(0, 69);
            this.lb_tenncc.Name = "lb_tenncc";
            this.lb_tenncc.Size = new System.Drawing.Size(122, 16);
            this.lb_tenncc.TabIndex = 2;
            this.lb_tenncc.Text = "Tên Nhà Cung Cấp";
            // 
            // lb_diachincc
            // 
            this.lb_diachincc.AutoSize = true;
            this.lb_diachincc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_diachincc.Location = new System.Drawing.Point(70, 102);
            this.lb_diachincc.Name = "lb_diachincc";
            this.lb_diachincc.Size = new System.Drawing.Size(48, 16);
            this.lb_diachincc.TabIndex = 3;
            this.lb_diachincc.Text = "Địa chỉ";
            // 
            // lb_sdtncc
            // 
            this.lb_sdtncc.AutoSize = true;
            this.lb_sdtncc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_sdtncc.Location = new System.Drawing.Point(349, 39);
            this.lb_sdtncc.Name = "lb_sdtncc";
            this.lb_sdtncc.Size = new System.Drawing.Size(35, 16);
            this.lb_sdtncc.TabIndex = 4;
            this.lb_sdtncc.Text = "SĐT";
            // 
            // btn_them
            // 
            this.btn_them.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_them.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_them.Location = new System.Drawing.Point(143, 149);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(95, 48);
            this.btn_them.TabIndex = 5;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = false;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // txt_mancc
            // 
            this.txt_mancc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mancc.Location = new System.Drawing.Point(124, 36);
            this.txt_mancc.Name = "txt_mancc";
            this.txt_mancc.Size = new System.Drawing.Size(174, 22);
            this.txt_mancc.TabIndex = 6;
            // 
            // txt_tenncc
            // 
            this.txt_tenncc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tenncc.Location = new System.Drawing.Point(124, 67);
            this.txt_tenncc.Name = "txt_tenncc";
            this.txt_tenncc.Size = new System.Drawing.Size(174, 22);
            this.txt_tenncc.TabIndex = 7;
            // 
            // txt_diachincc
            // 
            this.txt_diachincc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_diachincc.Location = new System.Drawing.Point(124, 100);
            this.txt_diachincc.Name = "txt_diachincc";
            this.txt_diachincc.Size = new System.Drawing.Size(256, 22);
            this.txt_diachincc.TabIndex = 8;
            // 
            // txt_sdtncc
            // 
            this.txt_sdtncc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sdtncc.Location = new System.Drawing.Point(386, 36);
            this.txt_sdtncc.Name = "txt_sdtncc";
            this.txt_sdtncc.Size = new System.Drawing.Size(174, 22);
            this.txt_sdtncc.TabIndex = 9;
            // 
            // lst_NhaCC
            // 
            this.lst_NhaCC.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lst_NhaCC.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lst_NhaCC.GridLines = true;
            this.lst_NhaCC.HideSelection = false;
            this.lst_NhaCC.Location = new System.Drawing.Point(12, 235);
            this.lst_NhaCC.Name = "lst_NhaCC";
            this.lst_NhaCC.Size = new System.Drawing.Size(580, 167);
            this.lst_NhaCC.TabIndex = 10;
            this.lst_NhaCC.UseCompatibleStateImageBehavior = false;
            this.lst_NhaCC.View = System.Windows.Forms.View.Details;
            this.lst_NhaCC.SelectedIndexChanged += new System.EventHandler(this.lst_NhaCC_SelectedIndexChanged);
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "STT";
            this.columnHeader5.Width = 42;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã nhà cung cấp";
            this.columnHeader1.Width = 109;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên nhà cung cấp";
            this.columnHeader2.Width = 125;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Địa chỉ";
            this.columnHeader3.Width = 148;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "SDT";
            this.columnHeader4.Width = 140;
            // 
            // btn_xoa
            // 
            this.btn_xoa.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_xoa.Location = new System.Drawing.Point(244, 149);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(95, 48);
            this.btn_xoa.TabIndex = 11;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = false;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sua.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_sua.Location = new System.Drawing.Point(345, 149);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(95, 48);
            this.btn_sua.TabIndex = 12;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = false;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // NhaCungCap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 441);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.lst_NhaCC);
            this.Controls.Add(this.txt_sdtncc);
            this.Controls.Add(this.txt_diachincc);
            this.Controls.Add(this.txt_tenncc);
            this.Controls.Add(this.txt_mancc);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.lb_sdtncc);
            this.Controls.Add(this.lb_diachincc);
            this.Controls.Add(this.lb_tenncc);
            this.Controls.Add(this.lb_mancc);
            this.Name = "NhaCungCap";
            this.Text = "Nhà Cung Cấp";
            this.Load += new System.EventHandler(this.NhaCungCap_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lb_mancc;
        private System.Windows.Forms.Label lb_tenncc;
        private System.Windows.Forms.Label lb_diachincc;
        private System.Windows.Forms.Label lb_sdtncc;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.TextBox txt_mancc;
        private System.Windows.Forms.TextBox txt_tenncc;
        private System.Windows.Forms.TextBox txt_diachincc;
        private System.Windows.Forms.TextBox txt_sdtncc;
        private System.Windows.Forms.ListView lst_NhaCC;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}