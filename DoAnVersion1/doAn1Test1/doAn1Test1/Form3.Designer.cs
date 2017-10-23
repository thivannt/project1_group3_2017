namespace doAn1Test1
{
    partial class Form3
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtChiSo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtGiaTri = new System.Windows.Forms.TextBox();
            this.btnNhapFrm3 = new System.Windows.Forms.Button();
            this.btnThoatFrm3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Phần tử thứ ";
            // 
            // txtChiSo
            // 
            this.txtChiSo.Location = new System.Drawing.Point(117, 85);
            this.txtChiSo.Name = "txtChiSo";
            this.txtChiSo.Size = new System.Drawing.Size(48, 22);
            this.txtChiSo.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(184, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(12, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = ":";
            // 
            // txtGiaTri
            // 
            this.txtGiaTri.Location = new System.Drawing.Point(221, 82);
            this.txtGiaTri.Name = "txtGiaTri";
            this.txtGiaTri.Size = new System.Drawing.Size(164, 22);
            this.txtGiaTri.TabIndex = 3;
            // 
            // btnNhapFrm3
            // 
            this.btnNhapFrm3.Location = new System.Drawing.Point(121, 149);
            this.btnNhapFrm3.Name = "btnNhapFrm3";
            this.btnNhapFrm3.Size = new System.Drawing.Size(75, 23);
            this.btnNhapFrm3.TabIndex = 4;
            this.btnNhapFrm3.Text = "Nhập";
            this.btnNhapFrm3.UseVisualStyleBackColor = true;
            this.btnNhapFrm3.Click += new System.EventHandler(this.btnNhapFrm3_Click);
            // 
            // btnThoatFrm3
            // 
            this.btnThoatFrm3.Location = new System.Drawing.Point(310, 149);
            this.btnThoatFrm3.Name = "btnThoatFrm3";
            this.btnThoatFrm3.Size = new System.Drawing.Size(75, 23);
            this.btnThoatFrm3.TabIndex = 5;
            this.btnThoatFrm3.Text = "Thoát";
            this.btnThoatFrm3.UseVisualStyleBackColor = true;
            this.btnThoatFrm3.Click += new System.EventHandler(this.btnThoatFrm3_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 213);
            this.Controls.Add(this.btnThoatFrm3);
            this.Controls.Add(this.btnNhapFrm3);
            this.Controls.Add(this.txtGiaTri);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtChiSo);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtChiSo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtGiaTri;
        private System.Windows.Forms.Button btnNhapFrm3;
        private System.Windows.Forms.Button btnThoatFrm3;
    }
}