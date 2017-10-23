namespace doAn1Test1
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
            this.txtDayso = new System.Windows.Forms.TextBox();
            this.btnOkfrm2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtDayso
            // 
            this.txtDayso.Location = new System.Drawing.Point(135, 49);
            this.txtDayso.Name = "txtDayso";
            this.txtDayso.Size = new System.Drawing.Size(437, 22);
            this.txtDayso.TabIndex = 0;
            // 
            // btnOkfrm2
            // 
            this.btnOkfrm2.Location = new System.Drawing.Point(497, 119);
            this.btnOkfrm2.Name = "btnOkfrm2";
            this.btnOkfrm2.Size = new System.Drawing.Size(75, 23);
            this.btnOkfrm2.TabIndex = 1;
            this.btnOkfrm2.Text = "ok";
            this.btnOkfrm2.UseVisualStyleBackColor = true;
            this.btnOkfrm2.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "nhập mảng :";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 220);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOkfrm2);
            this.Controls.Add(this.txtDayso);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDayso;
        private System.Windows.Forms.Button btnOkfrm2;
        private System.Windows.Forms.Label label1;
    }
}