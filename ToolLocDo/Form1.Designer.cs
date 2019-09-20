namespace ToolLocDo
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.tBNguon = new System.Windows.Forms.TextBox();
            this.btNguon = new System.Windows.Forms.Button();
            this.btLuu = new System.Windows.Forms.Button();
            this.tBLuu = new System.Windows.Forms.TextBox();
            this.btBatDau = new System.Windows.Forms.Button();
            this.btDoiTen = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btCropAnh = new System.Windows.Forms.Button();
            this.cBXoaFileGoc = new System.Windows.Forms.CheckBox();
            this.cBBoQuaLoi = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rB3 = new System.Windows.Forms.RadioButton();
            this.rB2 = new System.Windows.Forms.RadioButton();
            this.rB1 = new System.Windows.Forms.RadioButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lbSoAcc = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tBNguon
            // 
            this.tBNguon.Location = new System.Drawing.Point(72, 12);
            this.tBNguon.Name = "tBNguon";
            this.tBNguon.Size = new System.Drawing.Size(216, 20);
            this.tBNguon.TabIndex = 0;
            // 
            // btNguon
            // 
            this.btNguon.Location = new System.Drawing.Point(3, 9);
            this.btNguon.Name = "btNguon";
            this.btNguon.Size = new System.Drawing.Size(63, 23);
            this.btNguon.TabIndex = 1;
            this.btNguon.Text = "Nguồn";
            this.btNguon.UseVisualStyleBackColor = true;
            this.btNguon.Click += new System.EventHandler(this.btNguon_Click);
            // 
            // btLuu
            // 
            this.btLuu.Location = new System.Drawing.Point(3, 55);
            this.btLuu.Name = "btLuu";
            this.btLuu.Size = new System.Drawing.Size(63, 23);
            this.btLuu.TabIndex = 2;
            this.btLuu.Text = "Lưu";
            this.btLuu.UseVisualStyleBackColor = true;
            this.btLuu.Click += new System.EventHandler(this.btLuu_Click);
            // 
            // tBLuu
            // 
            this.tBLuu.Location = new System.Drawing.Point(73, 57);
            this.tBLuu.Name = "tBLuu";
            this.tBLuu.Size = new System.Drawing.Size(215, 20);
            this.tBLuu.TabIndex = 3;
            // 
            // btBatDau
            // 
            this.btBatDau.Location = new System.Drawing.Point(117, 85);
            this.btBatDau.Name = "btBatDau";
            this.btBatDau.Size = new System.Drawing.Size(75, 23);
            this.btBatDau.TabIndex = 4;
            this.btBatDau.Text = "Bắt đầu";
            this.btBatDau.UseVisualStyleBackColor = true;
            this.btBatDau.Click += new System.EventHandler(this.btBatDau_Click);
            // 
            // btDoiTen
            // 
            this.btDoiTen.Location = new System.Drawing.Point(23, 85);
            this.btDoiTen.Name = "btDoiTen";
            this.btDoiTen.Size = new System.Drawing.Size(75, 23);
            this.btDoiTen.TabIndex = 5;
            this.btDoiTen.Text = "Đổi tên file";
            this.btDoiTen.UseVisualStyleBackColor = true;
            this.btDoiTen.Visible = false;
            this.btDoiTen.Click += new System.EventHandler(this.btDoiTen_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBar1.Location = new System.Drawing.Point(0, 193);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(300, 23);
            this.progressBar1.TabIndex = 6;
            // 
            // btCropAnh
            // 
            this.btCropAnh.Location = new System.Drawing.Point(213, 85);
            this.btCropAnh.Name = "btCropAnh";
            this.btCropAnh.Size = new System.Drawing.Size(75, 23);
            this.btCropAnh.TabIndex = 7;
            this.btCropAnh.Text = "Crop Ảnh";
            this.btCropAnh.UseVisualStyleBackColor = true;
            this.btCropAnh.Click += new System.EventHandler(this.btCropAnh_Click);
            // 
            // cBXoaFileGoc
            // 
            this.cBXoaFileGoc.AutoSize = true;
            this.cBXoaFileGoc.Checked = true;
            this.cBXoaFileGoc.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cBXoaFileGoc.Location = new System.Drawing.Point(3, 114);
            this.cBXoaFileGoc.Name = "cBXoaFileGoc";
            this.cBXoaFileGoc.Size = new System.Drawing.Size(82, 17);
            this.cBXoaFileGoc.TabIndex = 8;
            this.cBXoaFileGoc.Text = "Xóa file gốc";
            this.cBXoaFileGoc.UseVisualStyleBackColor = true;
            // 
            // cBBoQuaLoi
            // 
            this.cBBoQuaLoi.AutoSize = true;
            this.cBBoQuaLoi.Checked = true;
            this.cBBoQuaLoi.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cBBoQuaLoi.Location = new System.Drawing.Point(100, 114);
            this.cBBoQuaLoi.Name = "cBBoQuaLoi";
            this.cBBoQuaLoi.Size = new System.Drawing.Size(73, 17);
            this.cBBoQuaLoi.TabIndex = 9;
            this.cBBoQuaLoi.Text = "Bỏ qua lỗi";
            this.cBBoQuaLoi.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rB3);
            this.groupBox1.Controls.Add(this.rB2);
            this.groupBox1.Controls.Add(this.rB1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 147);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 46);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mode";
            // 
            // rB3
            // 
            this.rB3.AutoSize = true;
            this.rB3.Location = new System.Drawing.Point(80, 19);
            this.rB3.Name = "rB3";
            this.rB3.Size = new System.Drawing.Size(31, 17);
            this.rB3.TabIndex = 2;
            this.rB3.TabStop = true;
            this.rB3.Text = "3";
            this.toolTip1.SetToolTip(this.rB3, "Lọc đồ theo nhóm (Data3)");
            this.rB3.UseVisualStyleBackColor = true;
            // 
            // rB2
            // 
            this.rB2.AutoSize = true;
            this.rB2.Location = new System.Drawing.Point(43, 19);
            this.rB2.Name = "rB2";
            this.rB2.Size = new System.Drawing.Size(31, 17);
            this.rB2.TabIndex = 1;
            this.rB2.TabStop = true;
            this.rB2.Text = "2";
            this.toolTip1.SetToolTip(this.rB2, "Lọc rác (Data2)");
            this.rB2.UseVisualStyleBackColor = true;
            // 
            // rB1
            // 
            this.rB1.AutoSize = true;
            this.rB1.Checked = true;
            this.rB1.Location = new System.Drawing.Point(6, 19);
            this.rB1.Name = "rB1";
            this.rB1.Size = new System.Drawing.Size(31, 17);
            this.rB1.TabIndex = 0;
            this.rB1.TabStop = true;
            this.rB1.Text = "1";
            this.toolTip1.SetToolTip(this.rB1, "Mặc định (data)");
            this.rB1.UseVisualStyleBackColor = true;
            // 
            // lbSoAcc
            // 
            this.lbSoAcc.AutoSize = true;
            this.lbSoAcc.Location = new System.Drawing.Point(252, 114);
            this.lbSoAcc.Name = "lbSoAcc";
            this.lbSoAcc.Size = new System.Drawing.Size(0, 13);
            this.lbSoAcc.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 216);
            this.Controls.Add(this.lbSoAcc);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cBBoQuaLoi);
            this.Controls.Add(this.cBXoaFileGoc);
            this.Controls.Add(this.btCropAnh);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btDoiTen);
            this.Controls.Add(this.btBatDau);
            this.Controls.Add(this.tBLuu);
            this.Controls.Add(this.btLuu);
            this.Controls.Add(this.btNguon);
            this.Controls.Add(this.tBNguon);
            this.Name = "Form1";
            this.Text = "PUBG Tool lọc đồ";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tBNguon;
        private System.Windows.Forms.Button btNguon;
        private System.Windows.Forms.Button btLuu;
        private System.Windows.Forms.TextBox tBLuu;
        private System.Windows.Forms.Button btBatDau;
        private System.Windows.Forms.Button btDoiTen;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btCropAnh;
        private System.Windows.Forms.CheckBox cBXoaFileGoc;
        private System.Windows.Forms.CheckBox cBBoQuaLoi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rB1;
        private System.Windows.Forms.RadioButton rB3;
        private System.Windows.Forms.RadioButton rB2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lbSoAcc;
    }
}

