using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            try
            {

                int kilo;
                int boy;
                int sonuc = 0;
                try
                {

                    boy = int.Parse(textBox2.Text);
                    kilo = int.Parse(textBox1.Text);
                    if (radioButton1.Checked == true)
                    {
                        sonuc = boy - (((150 - boy) / 4) + 100);
                        if (kilo > sonuc)
                        {
                            label3.Text = (sonuc - kilo).ToString() + " Kilo fazlanız var";
                            MessageBox.Show("ideal kilonuzu aşmış bulunmaktasınız.");
                        }
                        if (kilo < (sonuc))
                        {
                            label3.Text = (sonuc - kilo).ToString() + " Kilo eksiğiniz var";

                            MessageBox.Show("ideal kilonuzun altındasınız");

                        }


                    }

                    else
                    {
                        sonuc = boy - (((150 - boy) / 4) + 110);
                        if (kilo > sonuc)
                        {
                            label3.Text = (sonuc - kilo).ToString() + " Kilo fazlanız var";
                            MessageBox.Show("ideal kilonuzu aşmış bulunmaktasınız.");
                        }
                        if (kilo < (sonuc))
                        {
                            label3.Text = (sonuc - kilo).ToString() + " Kilo eksiğiniz var";

                            MessageBox.Show("ideal kilonuzun altındasınız");

                        }
                    }
                }
                catch
                {
                    MessageBox.Show("fazla kilonu bizimle paylaş lütfen");
                }


            }


            catch
            {
                ;
            }
            
       }
    }
}
                                                      