using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;

namespace doAn1Test1
{
    public partial class Form1 : Form
    {
        public static Button [] mangNhap, mangKetQua;  // tao nhung mang de hien so len mang hinh
        public static int  soPhanTu = 0  ; 
        public static Label[] mangChiSo; // tao mang chi so cua tung phan tu 
        public static int[] a, b, c, h, chuaxep;
        int khoangCach; // khoang cach 2 button cua mangNhap 
        int kichThuoc; // kich thuoc cua button trong mangNhap
        int coChu; // co chu trong button.text ; 
        int canhLe; // vi tri so voi le ben trai 
         int i;
        public static TextBox txtNhapTay;
        public int viTriNhapTay;
        Boolean nhapSoptuTC = false,daTaoMang = false;  // da nhap so phan tu thanh cong hay chua , da tao mang button thanh cong hay chua


        public bool testPause = false; 
       
        

       
        private void btnNhapMang_Click(object sender, EventArgs e) //3.nhap mang vao mang button
        {
            Xoa_mang(mangNhap);
            Form2 frm = new Form2() ;
            frm.ShowDialog();
            taoMang(180);
            try // sau khi da nhap mang vao mang a at form2 thi nhap vao trong mang button
            {
                for(i=0;i<a.Length;i++)
                {
                    mangNhap[i].ForeColor = Color.Red;
                    
                    mangNhap[i].Text = a[i].ToString();
                }

            }
            catch
            {

            }
            

        }

        private void btnNhapTay_Click(object sender, EventArgs e) // 3.nhap tung so vo mang text box
        {

            Xoa_mang(mangNhap);// xoa mang cu truoc khi tao mang moi
            try
            {
                soPhanTu = Convert.ToInt32(txtSoPtu.Text); // lay so phan tu ra

                if (soPhanTu > 15 || soPhanTu <= 2)
                {
                    MessageBox.Show("số phần tử không vượt quá 15");
                }
                else
                {
                    nhapSoptuTC = true;
                    MessageBox.Show(soPhanTu.ToString());

                }

            }
            catch
            {
                MessageBox.Show(" số phần tử không hợp lệ");
            }

            if (nhapSoptuTC == true) // so phan tu thoa mang
            {

                a = new int[soPhanTu];
                taoMang(180);
                Form3 fr3 = new Form3();
                fr3.ShowDialog();
            }

        }
       

        public Form1()
        {
            InitializeComponent();

        }

        private void btnNgauNhien_Click(object sender, EventArgs e) //3.nhap vao mang ngau nhien 
        {
            Xoa_mang(mangNhap);// xoa mang cu truoc khi tao mang moi
            try
            {
                soPhanTu = Convert.ToInt32(txtSoPtu.Text); // lay so phan tu ra
               
                if(soPhanTu >15 || soPhanTu <=2)
                {
                    MessageBox.Show("số phần tử không vượt quá 15");
                }
                else
                {
                    nhapSoptuTC = true;
                    MessageBox.Show(soPhanTu.ToString());

                }
                
            }
            catch
            {
                MessageBox.Show(" số phần tử không hợp lệ");
            }

            if(nhapSoptuTC == true) // so phan tu thoa mang
            {
               
                a = new int[soPhanTu];
                taoMang(180);
                Random r = new Random();
                for (i = 0; i < soPhanTu; i++)
                {
                    //Node[i].BackColor = Color.non; // đặt lại màu cho mảng ngẫu nhiên
                    mangNhap[i].ForeColor = Color.Red;
                    a[i] = r.Next(100);
                    mangNhap[i].Text = a[i].ToString();
                }

            }
        }
        // Hàm hoán vị 2 button
        public void Hoan_vi_Button( int i,  int j)
        {
            Button temp = mangNhap[i];
            mangNhap[i] = mangNhap[j];
            mangNhap[j] = temp;




        }
        
        
        //Hàm dừng toàn bộ chương trình
        public void pauseOrPlay()
        {
            while (testPause == true)
            {
                Application.DoEvents();
            }

        }
        //Hàm Tạm dừng
        public void Tam_dung()
        {
            
                testPause = true;
                btnPause.Enabled = false;
                pauseOrPlay();
            

        }


        //test nut pause
        private void btnPause_Click(object sender, EventArgs e)
        {
            if (btnPause.Text == "pause")
            {
                btnPause.Text = "continue";
                testPause = true;
                pauseOrPlay();
            }
            else
            {
                btnPause.Text = "pause";
                testPause = false;
            }

        }

        private void btnPause2_Click(object sender, EventArgs e)
        {

        }

        public void taoMang(int kc) //  1.viet ham tao mang 
        {
            switch(soPhanTu)
            {
                case 15:
                case 14:
                case 13:
                case 12:
                case 11:
                    kichThuoc = 50;
                   coChu = 18;
                   khoangCach = 18;
                    canhLe = (1024 - kichThuoc * soPhanTu - khoangCach * (soPhanTu - 1)) / 2;
                    break;
                case 10:
                case 9:
                case 8:
                case 7:
                case 6:
                case 5:
                case 4:
                case 3:
                case 2:
                    kichThuoc = 65;
                    coChu = 23;
                    khoangCach = 30;//40
                    canhLe = (1024 - kichThuoc * soPhanTu - khoangCach * (soPhanTu - 1)) / 2;
                    break;
            }


            // khoi tao cac mang chua cac so va chi so 
            mangChiSo = new Label[soPhanTu];
            mangNhap = new Button[soPhanTu];
          
            // tao cac mang 
            for (i =0;i< soPhanTu; i++)
            {
                // mangNhap
                mangNhap[i] = new Button();
                mangNhap[i].Text = a[i].ToString();
                
                mangNhap[i].Width = kichThuoc;
                mangNhap[i].Height = kichThuoc;
                mangNhap[i].Location = new Point(canhLe+ (kichThuoc + khoangCach) * i, kc);
                mangNhap[i].ForeColor = Color.Red;
                mangNhap[i].Font = new Font(this.Font, FontStyle.Bold);
                mangNhap[i].Font = new System.Drawing.Font("Arial", coChu, FontStyle.Bold);
                mangNhap[i].TextAlign = ContentAlignment.MiddleCenter;
                mangNhap[i].BackgroundImageLayout = ImageLayout.Stretch;
                
              
                this.Controls.Add(mangNhap[i]);
                // mang chi so
                mangChiSo[i] = new Label();
                mangChiSo[i].TextAlign = ContentAlignment.MiddleCenter;
                mangChiSo[i].Text = i.ToString();
                mangChiSo[i].Width = kichThuoc;
                mangChiSo[i].Height = kichThuoc;
                mangChiSo[i].ForeColor = Color.BlueViolet;
                mangChiSo[i].Location = new Point(canhLe+ (kichThuoc + khoangCach) * i, 150 + 3 * kichThuoc);
                if (soPhanTu <= 10)
                {
                    mangChiSo[i].Font = new System.Drawing.Font("Arial", coChu - 10, FontStyle.Regular);
                }
                else
                {
                    mangChiSo[i].Font = new System.Drawing.Font("Arial", coChu, FontStyle.Regular);
                }
                this.Controls.Add(mangChiSo[i]);
            }
            daTaoMang = true;
        }
        public void Xoa_mang(Button[] mangXoa) //2.viet ham xoa mang 
        {
            
            if (daTaoMang == true)
            {
                for (i = 0; i < soPhanTu; i++)
                {
                    this.Controls.Remove(mangXoa[i]);
                    this.Controls.Remove(mangChiSo[i]);

                }
                daTaoMang = false;
            }
           
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //4. Hàm swap 2 button có thể hiện
        public void DiChuyenHaiButton(Control t1, Control t2)
        {
            Application.DoEvents();

            this.Invoke((MethodInvoker)delegate
            {
                Point p1 = t1.Location; //lưu vị trí ban đầu của t1
                Point p2 = t2.Location; //lưu vị trí ban đầu của t2
                if (p1 != p2)
                {
                    // t1 lên, t2 xuống
                    while ((t1.Location.Y > p1.Y - (kichThuoc + 5)) || (t2.Location.Y < p2.Y + (kichThuoc + 5)))
                    {
                        Application.DoEvents();
                        t1.Top -= 3;
                        t2.Top += 3;
                        Tre(5);

                    }
                    // t1 dịch phải, t2 dịch trái
                    if (t1.Location.X < t2.Location.X)
                    {

                        while ((t1.Location.X < p2.X) || (t2.Location.X > p1.X))
                        {
                            Application.DoEvents();
                            t1.Left += 3;
                            t2.Left -= 3;
                            Tre(5);


                        }

                    }
                    // t1 dịch trái, t2 dịch phải
                    else
                    {

                        while ((t1.Location.X > p2.X) || (t2.Location.X < p1.X))
                        {
                            Application.DoEvents();
                            t1.Left -= 3;
                            t2.Left += 3;
                            Tre(5);

                        }

                    }
                    // t1 xuống, t2 lên
                    while ((t1.Location.Y < p2.Y) || (t2.Location.Y > p1.Y))
                    {
                        Application.DoEvents();
                        t1.Top += 3;
                        t2.Top -= 3;
                        Tre(5);

                    }
                    t1.Refresh();
                    t2.Refresh();
                }
            });

        }
        // t dịch chuyển sang Phải Step Node
        public void button_qua_phai(Control t, int Step)
        {
            
            Application.DoEvents();
            int canhlevitriden = t.Left + ((kichThuoc + khoangCach)) * Step; // vi tri cach le trai mk t di chuyen den 
            while (canhlevitriden > t.Left)
            {
                t.Left += 2;
                Tre(1);
            }
            t.Refresh();

        }
        // t dịch chuyển sang trai Step Node
        public void Node_qua_trai(Control t, int Step)
        {
            Application.DoEvents();
            int canhlevitriden = t.Left - ((kichThuoc + khoangCach)) * Step; // vi tri cach le trai mk t di chuyen den 
           while (canhlevitriden < t.Left)
            {
                t.Left -= 3;
                Tre(1);
            }
            t.Refresh();

            
        }

        private void btnInterchangeS_Click(object sender, EventArgs e)
        {
            if (daTaoMang == true)
            {

                for (int k = 0; k < soPhanTu - 1; k++)
                {
                    for (int j = k + 1; j < soPhanTu; j++)
                    {
                        //if (Convert.ToInt32(mangNhap[j].Text) < Convert.ToInt32(mangNhap[k].Text))
                        if (a[j]< a[k])
                        {
                            
                            Application.DoEvents();
                            //doi cho hai so va doi cho 2 button
                            int temp = a[k];
                            a[k] = a[j];
                            a[j] = temp;
                            DiChuyenHaiButton(mangNhap[k], mangNhap[j]);
                            
                            Hoan_vi_Button(k, j);
                        }
                    }
                }

            }
        }

        private void btnInsertionS_Click(object sender, EventArgs e)
        {
            if (daTaoMang == true)
            {
                int i, pos, x;
                Button Node_tam;
                int Chi_so_tam;
                int Dem_node;
                Application.DoEvents();

                for (i = 1; i < soPhanTu; i++)
                {
                    Tre(40 * 2);
                    //đếm số bước dịch chuyển 1 button
                    Dem_node = 0;
                    x = a[i];
                    Node_tam = mangNhap[i];
                    Chi_so_tam = i;
                    pos = i - 1;
                    //Di chuyển button cần chèn lên
                    Application.DoEvents();

                    Button_di_len(Node_tam, (kichThuoc + 5));

                    // Tam_dung();
                    while ((pos >= 0) && (a[pos] < x))
                    {
                        Application.DoEvents();
                        //Tre(40 * 3);
                        //Dịch chuyển button qua phải
                        a[pos + 1] = a[pos];
                        Dem_node++;
                        Application.DoEvents();

                        button_qua_phai(mangNhap[pos], 1);

                        Hoan_vi_Button(pos + 1, pos);
                        pos--;

                        //Tam_dung();
                    }
                    a[pos + 1] = x;
                    Application.DoEvents();
                    Node_qua_trai(Node_tam, Dem_node);


                    Application.DoEvents();

                    button_di_xuong(Node_tam, (kichThuoc + 5));

                    mangNhap[pos + 1] = Node_tam;
                    //Tam_dung();
                }
            }
        }

        // t dịch chuyển lên với quãng đường S
        public void Button_di_len(Control t, int S)
        {
            //Application.DoEvents();

            //    int loop_Count = S;
            //    //t xuống
            //    while (loop_Count > 0)
            //    {
            //        Application.DoEvents();
            //        t.Top -= 1;
            //        Tre(1);
            //        loop_Count--;
            //    }
            //    t.Refresh();
            Application.DoEvents();
            int canhlevitriden = t.Top- S; // vi tri cach le ben tren mk t di chuyen den 
            while (canhlevitriden < t.Top)
            {
                t.Top -= 3;
                Tre(1);
            }
            t.Refresh();

        }
        // t dịch chuyển xuống với quãng đường S
        public void button_di_xuong(Control t, int S)
        {
            //Application.DoEvents();

            //    int loop_Count = S;
            //    // t lên
            //    while (loop_Count > 0)
            //    {
            //        Application.DoEvents();
            //        t.Top += 1;
            //        Tre(1);
            //        loop_Count--;
            //    }
            //    t.Refresh();
            Application.DoEvents();
            int canhlevitriden = t.Top + S; // vi tri cach le ben tren mk t di chuyen den 
            while (canhlevitriden > t.Top)
            {
                t.Top += 3;
                Tre(1);
            }
            t.Refresh();

        }

        public void Den_vtri_button(Control t, int i)
        {
            Point p1 = t.Location; // lưu lại vị trí của t
            Point p2 = new Point(canhLe + (kichThuoc + khoangCach) * i, 200);//vị trí của Node i
            Application.DoEvents();
            
                // Di chuyển button lên hoặc xuống nữa đường
                if (p1.Y < p2.Y)
                {
                    while (t.Location.Y < p2.Y - ((p2.Y - p1.Y) / 2))
                    {
                        Application.DoEvents();
                        t.Top += 1;
                        t.Refresh();
                        Tre(1);

                    }
                }
                else
                {
                    while (t.Location.Y > p2.Y + ((p1.Y - p2.Y) / 2))
                    {
                        Application.DoEvents();
                        t.Top -= 1;
                        t.Refresh();
                        Tre(1);

                    }
                }
                // Di chuyển button qua phải hoặc trái
                if (p1.X < p2.X)
                {
                    while (t.Location.X < p2.X)
                    {
                        Application.DoEvents();
                        t.Left += 1;
                        t.Refresh();
                        Tre(1);
                    }
                }
                else
                {
                    while (t.Location.X > p2.X)
                    {
                        Application.DoEvents();
                        t.Left -= 1;
                        t.Refresh();
                        Tre(1);
                    }
                }
                // Tiếp tục di chuyển button lên hoặc xuống nữa đường còn lại
                if (p1.Y < p2.Y)
                {
                    while (t.Location.Y < p2.Y)
                    {
                        Application.DoEvents();
                        t.Top += 1;
                        t.Refresh();
                        Tre(1);

                    }
                }
                else
                {
                    while (t.Location.Y > p2.Y)
                    {
                        Application.DoEvents();
                        t.Top -= 1;
                        t.Refresh();
                        Tre(1);
                    }
                }
            
        }
        // Dịch chuyển 1 button về vị trí bằng với X của mangnhap[i]
        public void Den_tdo_x_button(Control t, int i)
        {
            Point p1 = t.Location; // lưu lại vị trí của t
            Point p2 = new Point(canhLe + (kichThuoc + khoangCach) * i, 200);//vị trí của Node i
            Application.DoEvents();
            
                // Di chuyển nút qua phải hoặc trái
                if (p1.X < p2.X)
                {
                    while (t.Location.X < p2.X)
                    {
                        Application.DoEvents();
                        t.Left += 1;
                        t.Refresh();
                        Tre(1);
                    }
                }
                else
                {
                    while (t.Location.X > p2.X)
                    {
                        Application.DoEvents();
                        t.Left -= 1;
                        t.Refresh();
                        Tre(1);
                    }
                }

        }
        //Hàm ngủ
        public void SleepButton(int milisecond)
        {
            int i;
            for (i = 0; i < milisecond; i++)
            {
                Application.DoEvents();
                Thread.Sleep(1);
            }
            Application.DoEvents();
        }
        //Hàm Trễ
        public void Tre(int milisecond)
        {
            //Nếu tốc độ max thì ko sleep
            

            SleepButton(milisecond);
        }

    }
}
