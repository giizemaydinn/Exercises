namespace Example15
{
    partial class Form2DisconnectedArch
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
            this.btnFill = new System.Windows.Forms.Button();
            this.btnUygula = new System.Windows.Forms.Button();
            this.dg = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dg)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFill
            // 
            this.btnFill.Location = new System.Drawing.Point(342, 378);
            this.btnFill.Name = "btnFill";
            this.btnFill.Size = new System.Drawing.Size(184, 44);
            this.btnFill.TabIndex = 5;
            this.btnFill.Text = "Doldur";
            this.btnFill.UseVisualStyleBackColor = true;
            // 
            // btnUygula
            // 
            this.btnUygula.Location = new System.Drawing.Point(121, 378);
            this.btnUygula.Name = "btnUygula";
            this.btnUygula.Size = new System.Drawing.Size(184, 44);
            this.btnUygula.TabIndex = 4;
            this.btnUygula.Text = "Değişiklikleri Uygula";
            this.btnUygula.UseVisualStyleBackColor = true;
            // 
            // dg
            // 
            this.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg.Location = new System.Drawing.Point(121, 29);
            this.dg.Name = "dg";
            this.dg.RowHeadersWidth = 51;
            this.dg.RowTemplate.Height = 29;
            this.dg.Size = new System.Drawing.Size(558, 313);
            this.dg.TabIndex = 3;
            // 
            // Form2DisconnectedArch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFill);
            this.Controls.Add(this.btnUygula);
            this.Controls.Add(this.dg);
            this.Name = "Form2DisconnectedArch";
            this.Text = "Form2DisconnectedArch";
            ((System.ComponentModel.ISupportInitialize)(this.dg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnFill;
        private Button btnUygula;
        private DataGridView dg;
    }
}