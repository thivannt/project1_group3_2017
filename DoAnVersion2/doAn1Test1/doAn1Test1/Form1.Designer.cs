namespace doAn1Test1
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
            this.pnKhoiTao = new System.Windows.Forms.Panel();
            this.btnNhapMang = new System.Windows.Forms.Button();
            this.btnNhapTay = new System.Windows.Forms.Button();
            this.btnNgauNhien = new System.Windows.Forms.Button();
            this.txtSoPtu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnInterchangeS = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnInsertionS = new System.Windows.Forms.Button();
            this.btnMergeSort = new System.Windows.Forms.Button();
            this.btnQuickSort = new System.Windows.Forms.Button();
            this.pnKhoiTao.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnKhoiTao
            // 
            this.pnKhoiTao.Controls.Add(this.btnNhapMang);
            this.pnKhoiTao.Controls.Add(this.btnNhapTay);
            this.pnKhoiTao.Controls.Add(this.btnNgauNhien);
            this.pnKhoiTao.Controls.Add(this.txtSoPtu);
            this.pnKhoiTao.Controls.Add(this.label1);
            this.pnKhoiTao.Location = new System.Drawing.Point(1067, 494);
            this.pnKhoiTao.Name = "pnKhoiTao";
            this.pnKhoiTao.Size = new System.Drawing.Size(350, 223);
            this.pnKhoiTao.TabIndex = 0;
            // 
            // btnNhapMang
            // 
            this.btnNhapMang.Location = new System.Drawing.Point(8, 140);
            this.btnNhapMang.Name = "btnNhapMang";
            this.btnNhapMang.Size = new System.Drawing.Size(100, 42);
            this.btnNhapMang.TabIndex = 3;
            this.btnNhapMang.Text = "nhập mảng";
            this.btnNhapMang.UseVisualStyleBackColor = true;
            this.btnNhapMang.Click += new System.EventHandler(this.btnNhapMang_Click);
            // 
            // btnNhapTay
            // 
            this.btnNhapTay.Location = new System.Drawing.Point(218, 79);
            this.btnNhapTay.Name = "btnNhapTay";
            this.btnNhapTay.Size = new System.Drawing.Size(100, 42);
            this.btnNhapTay.TabIndex = 2;
            this.btnNhapTay.Text = "nhập tay";
            this.btnNhapTay.UseVisualStyleBackColor = true;
            this.btnNhapTay.Click += new System.EventHandler(this.btnNhapTay_Click);
            // 
            // btnNgauNhien
            // 
            this.btnNgauNhien.Location = new System.Drawing.Point(8, 79);
            this.btnNgauNhien.Name = "btnNgauNhien";
            this.btnNgauNhien.Size = new System.Drawing.Size(100, 42);
            this.btnNgauNhien.TabIndex = 1;
            this.btnNgauNhien.Text = "ngẫu nhiên";
            this.btnNgauNhien.UseVisualStyleBackColor = true;
            this.btnNgauNhien.Click += new System.EventHandler(this.btnNgauNhien_Click);
            // 
            // txtSoPtu
            // 
            this.txtSoPtu.Location = new System.Drawing.Point(114, 32);
            this.txtSoPtu.Name = "txtSoPtu";
            this.txtSoPtu.Size = new System.Drawing.Size(100, 22);
            this.txtSoPtu.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Số phần tử :";
            // 
            // btnInterchangeS
            // 
            this.btnInterchangeS.Location = new System.Drawing.Point(901, 683);
            this.btnInterchangeS.Name = "btnInterchangeS";
            this.btnInterchangeS.Size = new System.Drawing.Size(126, 23);
            this.btnInterchangeS.TabIndex = 1;
            this.btnInterchangeS.Text = "interchangesort";
            this.btnInterchangeS.UseVisualStyleBackColor = true;
            this.btnInterchangeS.Click += new System.EventHandler(this.btnInterchangeS_Click);
            // 
            // btnPause
            // 
            this.btnPause.Location = new System.Drawing.Point(1342, 465);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(75, 23);
            this.btnPause.TabIndex = 2;
            this.btnPause.Text = "pause";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnInsertionS
            // 
            this.btnInsertionS.Location = new System.Drawing.Point(747, 683);
            this.btnInsertionS.Name = "btnInsertionS";
            this.btnInsertionS.Size = new System.Drawing.Size(137, 23);
            this.btnInsertionS.TabIndex = 3;
            this.btnInsertionS.Text = "insertionSort";
            this.btnInsertionS.UseVisualStyleBackColor = true;
            this.btnInsertionS.Click += new System.EventHandler(this.btnInsertionS_Click);
            // 
            // btnMergeSort
            // 
            this.btnMergeSort.Location = new System.Drawing.Point(602, 682);
            this.btnMergeSort.Name = "btnMergeSort";
            this.btnMergeSort.Size = new System.Drawing.Size(125, 24);
            this.btnMergeSort.TabIndex = 4;
            this.btnMergeSort.Text = "merge tang";
            this.btnMergeSort.UseVisualStyleBackColor = true;
            this.btnMergeSort.Click += new System.EventHandler(this.btnMergeSort_Click);
            // 
            // btnQuickSort
            // 
            this.btnQuickSort.Location = new System.Drawing.Point(901, 644);
            this.btnQuickSort.Name = "btnQuickSort";
            this.btnQuickSort.Size = new System.Drawing.Size(126, 23);
            this.btnQuickSort.TabIndex = 5;
            this.btnQuickSort.Text = "quickSortTang";
            this.btnQuickSort.UseVisualStyleBackColor = true;
            this.btnQuickSort.Click += new System.EventHandler(this.btnQuickSort_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1417, 718);
            this.Controls.Add(this.btnQuickSort);
            this.Controls.Add(this.btnMergeSort);
            this.Controls.Add(this.btnInsertionS);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.btnInterchangeS);
            this.Controls.Add(this.pnKhoiTao);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnKhoiTao.ResumeLayout(false);
            this.pnKhoiTao.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnKhoiTao;
        private System.Windows.Forms.Button btnNhapMang;
        private System.Windows.Forms.Button btnNhapTay;
        private System.Windows.Forms.Button btnNgauNhien;
        private System.Windows.Forms.TextBox txtSoPtu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnInterchangeS;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnInsertionS;
        private System.Windows.Forms.Button btnMergeSort;
        private System.Windows.Forms.Button btnQuickSort;
    }
}

