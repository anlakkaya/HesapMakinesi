using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string[] takimlar = {"","Akhisar Bld", "Göztepe", "Galatasaray", "Fenerbahçe", "Beşiktaş", "Trabzonspor", "Sivasspor",  "Kayserispor" };
            string[] tarihler = { "24.01.2010 Saat:13:30", "31.01.2010 Saat:19:30", "7.02.2019 Saat:18:30", "14.02.2019 Saat:16:30", "21.02.2019 Saat:20:00", "28.02.2019 Saat:21:30", "07.03.2019 Saat:22:00", "14.03.2019 Saat:20:30", "21.03.2019 Saat:14:30", "28.03.2019 Saat:18:00", "04.04.2019 Saat:17:15", "11.04.2019 Saat:13:25", "18.04.2019 Saat:16:15", "25.04.2019 Saat:14:20", "02.05.2019 Saat:20:00", "09.05.2019 Saat:15:50", "16.05.2019 Saat:19:30"};

            Random r = new Random();
            int a,b,c,d,d1,f,g,h,i;
            int x, y, z, w;
            x = r.Next(17);
            y = r.Next(17);
            z = r.Next(17);
            w = r.Next(17);
            label10.Text = tarihler[x];
            label11.Text = tarihler[y];
            label12.Text = tarihler[z];
            label13.Text = tarihler[w];








            Random r1 = new Random();
            int[] sayilar = new int[9];

            int sayac = 0, rsayi;

            while (sayac <8)
            {
                rsayi = r1.Next(9);

                if (Array.IndexOf(sayilar, rsayi) == -1)
                {
                    sayilar[sayac] = rsayi;
                    sayac++;
                }
            }

            a = sayilar[0];
            b = sayilar[1];
            c = sayilar[2];
            d = sayilar[3];
            d1 = sayilar[4];
            f = sayilar[5];
            g = sayilar[6];
            h = sayilar[7];
            i = sayilar[8];


            label1.Text = takimlar[a].ToString();
            label2.Text = takimlar[b].ToString();
            label3.Text = takimlar[c].ToString();
            label4.Text = takimlar[d].ToString();
            label5.Text = takimlar[d1].ToString();
            label6.Text = takimlar[f].ToString();
            label7.Text = takimlar[g].ToString();
            label8.Text = takimlar[h].ToString();
            label9.Text = takimlar[i].ToString();
            
            
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "";
            label2.Text = "";
            label3.Text = "";
            label4.Text = "";
            label5.Text = "";
            label6.Text = "";
            label7.Text = "";
            label8.Text = "";
            label9.Text = "";
            label10.Text = "";
            label11.Text = "";
            label12.Text = "";
            label13.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            


            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            listBox1.Font = new Font("Courier New", 10, FontStyle.Bold);
            listBox1.Items.Add(label1.Text.PadRight(25)+ label15.Text.PadRight(5) + label2.Text.PadRight(20)+label10.Text);
            listBox1.Items.Add(label3.Text.PadRight(25)+ label16.Text.PadRight(5)+ label4.Text.PadRight(20) + label11.Text);
            listBox1.Items.Add(label5.Text.PadRight(25) + label17.Text.PadRight(5) + label6.Text.PadRight(20)+ label12.Text);
            listBox1.Items.Add(label7.Text.PadRight(25)+ label18.Text.PadRight(5)+ label8.Text.PadRight(20)+ label13.Text);

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            listBox1.Items.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox1.Font = new Font("Courier New", 10, FontStyle.Bold);
            listBox1.Items.Add("------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");

        }
    }
}
