using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;


namespace Bai1_ToiUuHoa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.Text = "Kiểu chữ THƯỜNG";
            label2.Text = "Kiểu chữ HOA";
            label3.Text = "Kiểu SỐ";
            label4.Text = "Kiểu khác";          
        }

        public void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFile.ShowDialog();
            StreamReader txt = new StreamReader(OpenFile.FileName);
            string a = txt.ReadToEnd();
            txt.Close();
            a = a.Replace(" ", "");
            char[] array = a.ToCharArray();
            List<string> Normal= new List<string>();//97-122
            List<string> Capital=new List<string>();//65-90
            List<string> Number=new List <string>();//48-57
            List<string> Other=new List<string>(); 
            // phan loai kieu  ky tu
            for (int i=0; i< array.Length;i++)
            {
                int other=0;
                int temp;
                temp = (int)array[i];
                //x = Convert.ToString(temp);
                //MessageBox.Show(x);
                if(temp>=97 && temp <=122)
                {
                    string flag = Convert.ToString(array[i]);
                    Normal.Add(flag);
                    other++;
                }
                if (temp>=65 && temp <= 90)
                {
                    string flag = Convert.ToString(array[i]);
                    Capital.Add(flag);
                    other++;
                }
                if (temp >=48 && temp <= 57)
                {
                    string flag = Convert.ToString(array[i]);
                    Number.Add(flag);
                    other++;
                }
                if (other ==0)
                {
                    string flag = Convert.ToString(array[i]);
                    Other.Add(flag);
                }
            }
          //txt.Close();
            MessageBox.Show("Bắt đầu phân loại...", "Thông báo!");
          string abc="";
          string hoa = "";
          string number = "";
          string khac = "";
            for (int i=0; i< Normal.Count;i++)
            {
                abc += Normal[i];
                
            }
            for (int i = 0; i < Capital.Count; i++)
            {
                hoa += Capital[i];
            }
            for (int i = 0; i < Number.Count; i++)
            {
                number += Number[i];
            }
            for (int i = 0; i < Other.Count;i++ )
            {
                khac += Other[i];
            }
                txtBox1.Text = abc;
                txtBox2.Text = hoa;
                txtBox3.Text = number;
                txtBox4.Text = khac;
         }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
     }
}
