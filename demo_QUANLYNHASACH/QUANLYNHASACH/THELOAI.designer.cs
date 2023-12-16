
namespace QUANLYNHASACH
{
    partial class TheLoai
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
            this.labelmatheloai = new System.Windows.Forms.Label();
            this.labeltentheloai = new System.Windows.Forms.Label();
            this.txtmatheloai = new System.Windows.Forms.TextBox();
            this.txttentheloai = new System.Windows.Forms.TextBox();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.lsttheloai = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // labelmatheloai
            // 
            this.labelmatheloai.AutoSize = true;
            this.labelmatheloai.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelmatheloai.Location = new System.Drawing.Point(41, 19);
            this.labelmatheloai.Name = "labelmatheloai";
            this.labelmatheloai.Size = new System.Drawing.Size(90, 18);
            this.labelmatheloai.TabIndex = 0;
            this.labelmatheloai.Text = "Mã Thể Loại";
            // 
            // labeltentheloai
            // 
            this.labeltentheloai.AutoSize = true;
            this.labeltentheloai.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltentheloai.Location = new System.Drawing.Point(37, 64);
            this.labeltentheloai.Name = "labeltentheloai";
            this.labeltentheloai.Size = new System.Drawing.Size(94, 18);
            this.labeltentheloai.TabIndex = 1;
            this.labeltentheloai.Text = "Tên Thể Loại";
            // 
            // txtmatheloai
            // 
            this.txtmatheloai.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmatheloai.Location = new System.Drawing.Point(137, 12);
            this.txtmatheloai.Multiline = true;
            this.txtmatheloai.Name = "txtmatheloai";
            this.txtmatheloai.Size = new System.Drawing.Size(282, 29);
            this.txtmatheloai.TabIndex = 2;
            // 
            // txttentheloai
            // 
            this.txttentheloai.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttentheloai.Location = new System.Drawing.Point(137, 57);
            this.txttentheloai.Multiline = true;
            this.txttentheloai.Name = "txttentheloai";
            this.txttentheloai.Size = new System.Drawing.Size(282, 29);
            this.txttentheloai.TabIndex = 3;
            // 
            // btnthem
            // 
            this.btnthem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnthem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthem.Location = new System.Drawing.Point(109, 110);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(95, 48);
            this.btnthem.TabIndex = 4;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = false;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnxoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxoa.Location = new System.Drawing.Point(210, 110);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(95, 48);
            this.btnxoa.TabIndex = 5;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = false;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnsua
            // 
            this.btnsua.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnsua.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsua.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnsua.Location = new System.Drawing.Point(311, 110);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(95, 48);
            this.btnsua.TabIndex = 6;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = false;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // lsttheloai
            // 
            this.lsttheloai.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lsttheloai.HideSelection = false;
            this.lsttheloai.Location = new System.Drawing.Point(74, 192);
            this.lsttheloai.Name = "lsttheloai";
            this.lsttheloai.Size = new System.Drawing.Size(457, 220);
            this.lsttheloai.TabIndex = 7;
            this.lsttheloai.UseCompatibleStateImageBehavior = false;
            this.lsttheloai.View = System.Windows.Forms.View.Details;
            this.lsttheloai.SelectedIndexChanged += new System.EventHandler(this.lsttheloai_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "STT";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Mã Thể Loại";
            this.columnHeader2.Width = 169;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Tên Thể Loại";
            this.columnHeader3.Width = 136;
            // 
            // TheLoai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 441);
            this.Controls.Add(this.lsttheloai);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.txttentheloai);
            this.Controls.Add(this.txtmatheloai);
            this.Controls.Add(this.labeltentheloai);
            this.Controls.Add(this.labelmatheloai);
            this.Name = "TheLoai";
            this.Text = "THỂ_LOẠI";
            this.Load += new System.EventHandler(this.TheLoai_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelmatheloai;
        private System.Windows.Forms.Label labeltentheloai;
        private System.Windows.Forms.TextBox txtmatheloai;
        private System.Windows.Forms.TextBox txttentheloai;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.ListView lsttheloai;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}