using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace doAn1Test1
{
    public partial class Form2 : Form //form de nhap day so vao
    {
        public Form2()
        {
            InitializeComponent();
        }
        public static int[] mangSo;
        public static bool nhapMangFrm2 = false;

        private void button1_Click(object sender, EventArgs e)
        { 
            string chuoiNhap = txtDayso.Text;
            string[] mangChuoiNhap = chuoiNhap.Split("".ToArray(), StringSplitOptions.RemoveEmptyEntries);
            try
            {
                mangSo = Array.ConvertAll<string, int>(mangChuoiNhap, int.Parse); // chuyen tu chuoi sang mang so nguyen
                

                if (mangSo.Length > 15 || mangSo.Length<= 2)
                {
                    MessageBox.Show("số phần tử không vượt quá 15");
                }
                else
                {
                    for(int i =0;i<mangSo.Length;i++)
                    {
                        if (mangSo[i] > 100 || mangSo[i] < 0)
                        {
                            MessageBox.Show(" 0< giá trị phần tử <100 ");
                            return;
                        }
                        else
                        {
                           
                                Form1.a = new int[Form2.mangSo.Length];
                            Form1.soPhanTu = Form2.mangSo.Length;
                            

                                for (i = 0; i < Form2.mangSo.Length; i++)
                                {
                                   
                                Form1.a[i] = Form2.mangSo[i];
                                    
                                }
                            this.Close();
                            }
                        
                    }

                }
            }
            catch
            {
                MessageBox.Show("số nhập vào không hợp lệ");
            }
            

            
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
