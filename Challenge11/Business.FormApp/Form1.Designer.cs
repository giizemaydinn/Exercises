namespace Business.FormApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.btnEditUserInfo = new System.Windows.Forms.Button();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnEditAddress = new System.Windows.Forms.Button();
            this.btnAddAddress = new System.Windows.Forms.Button();
            this.cmbAddress = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDeleteUser);
            this.groupBox1.Controls.Add(this.btnEditUserInfo);
            this.groupBox1.Controls.Add(this.txtLastName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtPwd);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtUName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(322, 208);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kişisel Bilgiler";
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.Location = new System.Drawing.Point(179, 164);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(94, 29);
            this.btnDeleteUser.TabIndex = 9;
            this.btnDeleteUser.Text = "Sil";
            this.btnDeleteUser.UseVisualStyleBackColor = true;
            // 
            // btnEditUserInfo
            // 
            this.btnEditUserInfo.Location = new System.Drawing.Point(79, 164);
            this.btnEditUserInfo.Name = "btnEditUserInfo";
            this.btnEditUserInfo.Size = new System.Drawing.Size(94, 29);
            this.btnEditUserInfo.TabIndex = 8;
            this.btnEditUserInfo.Text = "Düzenle";
            this.btnEditUserInfo.UseVisualStyleBackColor = true;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(111, 131);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(125, 27);
            this.txtLastName.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Soyad: ";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(111, 98);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(125, 27);
            this.txtName.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ad: ";
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(111, 65);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.Size = new System.Drawing.Size(125, 27);
            this.txtPwd.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Şifre:";
            // 
            // txtUName
            // 
            this.txtUName.Location = new System.Drawing.Point(111, 32);
            this.txtUName.Name = "txtUName";
            this.txtUName.Size = new System.Drawing.Size(125, 27);
            this.txtUName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı: ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnEditAddress);
            this.groupBox2.Controls.Add(this.btnAddAddress);
            this.groupBox2.Controls.Add(this.cmbAddress);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(369, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(726, 92);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Adres Bilgileri";
            // 
            // btnEditAddress
            // 
            this.btnEditAddress.Location = new System.Drawing.Point(386, 32);
            this.btnEditAddress.Name = "btnEditAddress";
            this.btnEditAddress.Size = new System.Drawing.Size(134, 29);
            this.btnEditAddress.TabIndex = 24;
            this.btnEditAddress.Text = "Adresi Düzenle";
            this.btnEditAddress.UseVisualStyleBackColor = true;
            this.btnEditAddress.Click += new System.EventHandler(this.btnEditAddress_Click);
            // 
            // btnAddAddress
            // 
            this.btnAddAddress.Location = new System.Drawing.Point(252, 31);
            this.btnAddAddress.Name = "btnAddAddress";
            this.btnAddAddress.Size = new System.Drawing.Size(128, 29);
            this.btnAddAddress.TabIndex = 23;
            this.btnAddAddress.Text = "Yeni Adres Ekle";
            this.btnAddAddress.UseVisualStyleBackColor = true;
            // 
            // cmbAddress
            // 
            this.cmbAddress.FormattingEnabled = true;
            this.cmbAddress.Location = new System.Drawing.Point(79, 31);
            this.cmbAddress.Name = "cmbAddress";
            this.cmbAddress.Size = new System.Drawing.Size(151, 28);
            this.cmbAddress.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 20);
            this.label8.TabIndex = 8;
            this.label8.Text = "Başlık: ";
            // 
            // btnAddUser
            // 
            this.btnAddUser.Location = new System.Drawing.Point(369, 148);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(187, 78);
            this.btnAddUser.TabIndex = 9;
            this.btnAddUser.Text = "Yeni Kullanıcı Oluştur";
            this.btnAddUser.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(582, 148);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(187, 78);
            this.button8.TabIndex = 10;
            this.button8.Text = "Kullanıcıları Görüntüle";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // dgvUsers
            // 
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Location = new System.Drawing.Point(12, 254);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.RowHeadersWidth = 51;
            this.dgvUsers.RowTemplate.Height = 29;
            this.dgvUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsers.Size = new System.Drawing.Size(1083, 224);
            this.dgvUsers.TabIndex = 11;
            this.dgvUsers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsers_CellContentClick);
            this.dgvUsers.DoubleClick += new System.EventHandler(this.dgvUsers_DoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 490);
            this.Controls.Add(this.dgvUsers);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Hesap";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Button btnEditUserInfo;
        private TextBox txtLastName;
        private Label label4;
        private TextBox txtName;
        private Label label3;
        private TextBox txtPwd;
        private Label label2;
        private TextBox txtUName;
        private Label label1;
        private GroupBox groupBox2;
        private ComboBox cmbAddress;
        private Label label8;
        private Button btnEditAddress;
        private Button btnAddAddress;
        private Button btnAddUser;
        private Button button8;
        private DataGridView dgvUsers;
        private Button btnDeleteUser;
    }
}