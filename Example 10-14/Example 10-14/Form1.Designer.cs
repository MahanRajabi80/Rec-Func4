namespace Example_10_14
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
            this.btnBmmKmm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDigit1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDigit2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnBmmKmm
            // 
            this.btnBmmKmm.Location = new System.Drawing.Point(83, 102);
            this.btnBmmKmm.Name = "btnBmmKmm";
            this.btnBmmKmm.Size = new System.Drawing.Size(100, 23);
            this.btnBmmKmm.TabIndex = 2;
            this.btnBmmKmm.Text = "BMM , KMM";
            this.btnBmmKmm.UseVisualStyleBackColor = true;
            this.btnBmmKmm.Click += new System.EventHandler(this.btnBmmKmm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter Digit1:";
            // 
            // txtDigit1
            // 
            this.txtDigit1.Location = new System.Drawing.Point(83, 24);
            this.txtDigit1.Name = "txtDigit1";
            this.txtDigit1.Size = new System.Drawing.Size(100, 20);
            this.txtDigit1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter Digit2:";
            // 
            // txtDigit2
            // 
            this.txtDigit2.Location = new System.Drawing.Point(83, 56);
            this.txtDigit2.Name = "txtDigit2";
            this.txtDigit2.Size = new System.Drawing.Size(100, 20);
            this.txtDigit2.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 143);
            this.Controls.Add(this.txtDigit2);
            this.Controls.Add(this.txtDigit1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBmmKmm);
            this.Name = "Form1";
            this.Text = "Example 10-14 (Rec Func4)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBmmKmm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDigit1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDigit2;
    }
}

