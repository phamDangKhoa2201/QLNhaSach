
namespace QUANLYNHASACH
{
    partial class TACGIA
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
            this.labeltentacgia = new System.Windows.Forms.Label();
            this.labelmatacgia = new System.Windows.Forms.Label();
            this.txttentacgia = new System.Windows.Forms.TextBox();
            this.txtmatacgia = new System.Windows.Forms.TextBox();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.lsttacgia = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // labeltentacgia
            // 
            this.labeltentacgia.AutoSize = true;
            this.labeltentacgia.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltentacgia.Location = new System.Drawing.Point(59, 46);
            this.labeltentacgia.Name = "labeltentacgia";
            this.labeltentacgia.Size = new System.Drawing.Size(89, 18);
            this.labeltentacgia.TabIndex = 0;
            this.labeltentacgia.Text = "Tên Tác Giả";
            // 
            // labelmatacgia
            // 
            this.labelmatacgia.AutoSize = true;
            this.labelmatacgia.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelmatacgia.Location = new System.Drawing.Point(63, 9);
            this.labelmatacgia.Name = "labelmatacgia";
            this.labelmatacgia.Size = new System.Drawing.Size(85, 18);
            this.labelmatacgia.TabIndex = 1;
            this.labelmatacgia.Text = "Mã Tác Giả";
            // 
            // txttentacgia
            // 
            this.txttentacgia.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttentacgia.Location = new System.Drawing.Point(154, 46);
            this.txttentacgia.Multiline = true;
            this.txttentacgia.Name = "txttentacgia";
            this.txttentacgia.Size = new System.Drawing.Size(246, 24);
            this.txttentacgia.TabIndex = 2;
            // 
            // txtmatacgia
            // 
            this.txtmatacgia.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmatacgia.Location = new System.Drawing.Point(154, 9);
            this.txtmatacgia.Multiline = true;
            this.txtmatacgia.Name = "txtmatacgia";
            this.txtmatacgia.Size = new System.Drawing.Size(246, 24);
            this.txtmatacgia.TabIndex = 3;
            // 
            // btnthem
            // 
            this.btnthem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnthem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnthem.Location = new System.Drawing.Point(82, 87);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(96, 46);
            this.btnthem.TabIndex = 4;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = false;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnxoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxoa.Location = new System.Drawing.Point(197, 87);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(96, 46);
            this.btnxoa.TabIndex = 5;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = false;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnsua
            // 
            this.btnsua.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnsua.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsua.Location = new System.Drawing.Point(317, 87);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(96, 46);
            this.btnsua.TabIndex = 6;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = false;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // lsttacgia
            // 
            this.lsttacgia.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lsttacgia.HideSelection = false;
            this.lsttacgia.Location = new System.Drawing.Point(109, 231);
            this.lsttacgia.Name = "lsttacgia";
            this.lsttacgia.Size = new System.Drawing.Size(388, 198);
            this.lsttacgia.TabIndex = 7;
            this.lsttacgia.UseCompatibleStateImageBehavior = false;
            this.lsttacgia.View = System.Windows.Forms.View.Details;
            this.lsttacgia.SelectedIndexChanged += new System.EventHandler(this.lsttacgia_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "STT";
            this.columnHeader1.Width = 79;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Mã Tác Giả";
            this.columnHeader2.Width = 84;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Tên Tác Giả";
            this.columnHeader3.Width = 218;
            // 
            // TACGIA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 441);
            this.Controls.Add(this.lsttacgia);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.txtmatacgia);
            this.Controls.Add(this.txttentacgia);
            this.Controls.Add(this.labelmatacgia);
            this.Controls.Add(this.labeltentacgia);
            this.Name = "TACGIA";
            this.Load += new System.EventHandler(this.TACGIA_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labeltentacgia;
        private System.Windows.Forms.Label labelmatacgia;
        private System.Windows.Forms.TextBox txttentacgia;
        private System.Windows.Forms.TextBox txtmatacgia;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.ListView lsttacgia;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}