namespace Example15
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
            this.btnClear = new System.Windows.Forms.Button();
            this.btnGetReport = new System.Windows.Forms.Button();
            this.btnExecuteProcedure = new System.Windows.Forms.Button();
            this.btnExecuteReader = new System.Windows.Forms.Button();
            this.btnExecuteScalar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(655, 43);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(94, 29);
            this.btnClear.TabIndex = 19;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnGetReport
            // 
            this.btnGetReport.Location = new System.Drawing.Point(555, 43);
            this.btnGetReport.Name = "btnGetReport";
            this.btnGetReport.Size = new System.Drawing.Size(94, 29);
            this.btnGetReport.TabIndex = 18;
            this.btnGetReport.Text = "Get Report";
            this.btnGetReport.UseVisualStyleBackColor = true;
            // 
            // btnExecuteProcedure
            // 
            this.btnExecuteProcedure.Location = new System.Drawing.Point(346, 381);
            this.btnExecuteProcedure.Name = "btnExecuteProcedure";
            this.btnExecuteProcedure.Size = new System.Drawing.Size(158, 29);
            this.btnExecuteProcedure.TabIndex = 17;
            this.btnExecuteProcedure.Text = "Execute Procedure";
            this.btnExecuteProcedure.UseVisualStyleBackColor = true;
            // 
            // btnExecuteReader
            // 
            this.btnExecuteReader.Location = new System.Drawing.Point(205, 381);
            this.btnExecuteReader.Name = "btnExecuteReader";
            this.btnExecuteReader.Size = new System.Drawing.Size(135, 29);
            this.btnExecuteReader.TabIndex = 16;
            this.btnExecuteReader.Text = "Execute Reader";
            this.btnExecuteReader.UseVisualStyleBackColor = true;
            // 
            // btnExecuteScalar
            // 
            this.btnExecuteScalar.Location = new System.Drawing.Point(79, 381);
            this.btnExecuteScalar.Name = "btnExecuteScalar";
            this.btnExecuteScalar.Size = new System.Drawing.Size(120, 29);
            this.btnExecuteScalar.TabIndex = 15;
            this.btnExecuteScalar.Text = "Execute Scalar";
            this.btnExecuteScalar.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(329, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Year: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Category Name: ";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(379, 44);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(125, 27);
            this.textBox3.TabIndex = 12;
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(73, 94);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(676, 260);
            this.txtResult.TabIndex = 11;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(173, 41);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(125, 27);
            this.textBox1.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnGetReport);
            this.Controls.Add(this.btnExecuteProcedure);
            this.Controls.Add(this.btnExecuteReader);
            this.Controls.Add(this.btnExecuteScalar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnClear;
        private Button btnGetReport;
        private Button btnExecuteProcedure;
        private Button btnExecuteReader;
        private Button btnExecuteScalar;
        private Label label2;
        private Label label1;
        private TextBox textBox3;
        private TextBox txtResult;
        private TextBox textBox1;
    }
}