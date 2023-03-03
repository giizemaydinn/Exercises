namespace Challenge08
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
            this.lblEvet = new System.Windows.Forms.Label();
            this.lblOnay = new System.Windows.Forms.Label();
            this.gbSaveBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.chkXml = new System.Windows.Forms.CheckBox();
            this.chkJson = new System.Windows.Forms.CheckBox();
            this.cmbStock = new System.Windows.Forms.ComboBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.gbSaveBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblEvet
            // 
            this.lblEvet.AutoSize = true;
            this.lblEvet.Location = new System.Drawing.Point(483, 342);
            this.lblEvet.Name = "lblEvet";
            this.lblEvet.Size = new System.Drawing.Size(35, 20);
            this.lblEvet.TabIndex = 5;
            this.lblEvet.Text = "Test";
            // 
            // lblOnay
            // 
            this.lblOnay.AutoSize = true;
            this.lblOnay.Location = new System.Drawing.Point(638, 164);
            this.lblOnay.Name = "lblOnay";
            this.lblOnay.Size = new System.Drawing.Size(0, 20);
            this.lblOnay.TabIndex = 4;
            // 
            // gbSaveBox
            // 
            this.gbSaveBox.Controls.Add(this.label1);
            this.gbSaveBox.Controls.Add(this.lblStock);
            this.gbSaveBox.Controls.Add(this.btnKaydet);
            this.gbSaveBox.Controls.Add(this.chkXml);
            this.gbSaveBox.Controls.Add(this.chkJson);
            this.gbSaveBox.Controls.Add(this.cmbStock);
            this.gbSaveBox.Controls.Add(this.txtPassword);
            this.gbSaveBox.Controls.Add(this.lblPassword);
            this.gbSaveBox.Controls.Add(this.txtUserName);
            this.gbSaveBox.Controls.Add(this.lblUserName);
            this.gbSaveBox.Location = new System.Drawing.Point(163, 88);
            this.gbSaveBox.Name = "gbSaveBox";
            this.gbSaveBox.Size = new System.Drawing.Size(453, 216);
            this.gbSaveBox.TabIndex = 3;
            this.gbSaveBox.TabStop = false;
            this.gbSaveBox.Text = "Çıktı Alma";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(320, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Çıktı Tipi:";
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(9, 114);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(121, 20);
            this.lblStock.TabIndex = 9;
            this.lblStock.Text = "Malzeme Listesi: ";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(172, 167);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(94, 29);
            this.btnKaydet.TabIndex = 8;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            // 
            // chkXml
            // 
            this.chkXml.AutoSize = true;
            this.chkXml.Location = new System.Drawing.Point(320, 93);
            this.chkXml.Name = "chkXml";
            this.chkXml.Size = new System.Drawing.Size(64, 24);
            this.chkXml.TabIndex = 7;
            this.chkXml.Text = "XML ";
            this.chkXml.UseVisualStyleBackColor = true;
            // 
            // chkJson
            // 
            this.chkJson.AutoSize = true;
            this.chkJson.Location = new System.Drawing.Point(320, 64);
            this.chkJson.Name = "chkJson";
            this.chkJson.Size = new System.Drawing.Size(66, 24);
            this.chkJson.TabIndex = 6;
            this.chkJson.Text = "JSON";
            this.chkJson.UseVisualStyleBackColor = true;
            // 
            // cmbStock
            // 
            this.cmbStock.FormattingEnabled = true;
            this.cmbStock.Location = new System.Drawing.Point(136, 111);
            this.cmbStock.Name = "cmbStock";
            this.cmbStock.Size = new System.Drawing.Size(151, 28);
            this.cmbStock.TabIndex = 5;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(136, 78);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(151, 27);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(9, 85);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(46, 20);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Şifre: ";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(136, 46);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(151, 27);
            this.txtUserName.TabIndex = 1;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(9, 49);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(99, 20);
            this.lblUserName.TabIndex = 0;
            this.lblUserName.Text = "Kullanıcı Adı: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblEvet);
            this.Controls.Add(this.lblOnay);
            this.Controls.Add(this.gbSaveBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbSaveBox.ResumeLayout(false);
            this.gbSaveBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Label lblEvet;
        private Label lblOnay;
        private GroupBox gbSaveBox;
        private Label label1;
        private Label lblStock;
        private Button btnKaydet;
        private CheckBox chkXml;
        private CheckBox chkJson;
        private ComboBox cmbStock;
        private TextBox txtPassword;
        private Label lblPassword;
        private TextBox txtUserName;
        private Label lblUserName;
    }
}