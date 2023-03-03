namespace Challenge08
{
    partial class Form2
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
            this.btnOnay = new System.Windows.Forms.Button();
            this.txtOnay = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOnay
            // 
            this.btnOnay.Location = new System.Drawing.Point(110, 146);
            this.btnOnay.Name = "btnOnay";
            this.btnOnay.Size = new System.Drawing.Size(139, 31);
            this.btnOnay.TabIndex = 5;
            this.btnOnay.Text = "Onay";
            this.btnOnay.UseVisualStyleBackColor = true;
            // 
            // txtOnay
            // 
            this.txtOnay.Location = new System.Drawing.Point(89, 113);
            this.txtOnay.Name = "txtOnay";
            this.txtOnay.Size = new System.Drawing.Size(186, 27);
            this.txtOnay.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Onaylıyorsanız \"Evet\" yazın.";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 250);
            this.Controls.Add(this.btnOnay);
            this.Controls.Add(this.txtOnay);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnOnay;
        private TextBox txtOnay;
        private Label label1;
    }
}