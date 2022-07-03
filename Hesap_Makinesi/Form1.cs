using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hesap_Makinesi
{

    public partial class Form1 : Form
    {

        
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (labelekran.Text == "0")
            {
                labelekran.Text = "7";
            }
            else
            {
                labelekran.Text = labelekran.Text + "7";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void buttonbir_Click(object sender, EventArgs e)
        {
            if (labelekran.Text == "0")
            {
                labelekran.Text = "1";
            }
            else
            {
                labelekran.Text = labelekran.Text + "1";

            }
        }

        private void buttoniki_Click(object sender, EventArgs e)
        {
            if (labelekran.Text == "0")
            {
                labelekran.Text = "2";
            }
            else
            {
                labelekran.Text = labelekran.Text + "2";
            }
        }

        private void buttonuc_Click(object sender, EventArgs e)
        {
            if (labelekran.Text == "0")
            {
                labelekran.Text = "3";
            }
            else
            {
                labelekran.Text = labelekran.Text + "3";
            }
        }

        private void buttondort_Click(object sender, EventArgs e)
        {
            if (labelekran.Text == "0")
            {
                labelekran.Text = "4";
            }
            else
            {
                labelekran.Text = labelekran.Text + "4";
            }
        }

        private void buttonbes_Click(object sender, EventArgs e)
        {
            if (labelekran.Text == "0")
            {
                labelekran.Text = "5";
            }
            else
            {
                labelekran.Text = labelekran.Text + "5";
            }
        }

        private void buttonaltı_Click(object sender, EventArgs e)
        {
            if (labelekran.Text == "0")
            {
                labelekran.Text = "6";
            }
            else
            {
                labelekran.Text = labelekran.Text + "6";
            }
        }

        private void buttonsekiz_Click(object sender, EventArgs e)
        {
            if (labelekran.Text == "0")
            {
                labelekran.Text = "8";
            }
            else
            {
                labelekran.Text = labelekran.Text + "8";
            }
        }

        private void buttondokuz_Click(object sender, EventArgs e)
        {
            if (labelekran.Text == "0")
            {
                labelekran.Text = "9";
            }
            else
            {
                labelekran.Text = labelekran.Text + "9";
            }
        }

        private void buttonsifirlama_Click(object sender, EventArgs e)
        {
            labelekran.Text = "0";
            ilksayi = 0;
            ikincisayi = -1;
        }

        private void buttonsifir_Click(object sender, EventArgs e)
        {
            if (labelekran.Text == "0")
            {

            }
            else
            {
                labelekran.Text = labelekran.Text + "0";
            }
        }
        
        private void buttonsilme_Click(object sender, EventArgs e)
        {
            int labelmetinuzunluk = labelekran.Text.Length;
            
            if (labelekran.Text.Length == 1)
            {
                labelekran.Text = "0";
            }
            else
            {
                labelekran.Text = labelekran.Text.Remove(labelmetinuzunluk - 1);
            }
        }

        private void buttonkok_Click(object sender, EventArgs e)
        {
            double labelsayi;
            labelsayi = Math.Sqrt(Convert.ToDouble(labelekran.Text));
            labelekran.Text = Convert.ToString(labelsayi);

        }

        private void buttonvirgul_Click(object sender, EventArgs e)
        {
            string[] labelharfleri = new string[labelekran.Text.Length];
            for (int i = 0; i < labelekran.Text.Length; i++)
            {
                labelharfleri[i] = labelekran.Text.Substring(i, 1);
            }
            if (labelharfleri.Contains(","))
            {
                
            }
            else
            {
                labelekran.Text = labelekran.Text + ",";
            }
            
        }

        private void buttonyuzde_Click(object sender, EventArgs e)
        {
            labelekran.Text = Convert.ToString(Convert.ToDouble(labelekran.Text) / 100);
        }
        
        double ilksayi;
        double ikincisayi=-1;
        double sonuc;
        string islem;
        private void buttontoplama_Click(object sender, EventArgs e)
        {
            if (ikincisayi==-1)
            {
                ilksayi = Convert.ToDouble(labelekran.Text);
                islem = "toplama";
                labelekran.Text = "0";
                ikincisayi = 0;
            }
            else
            {
                ikincisayi = Convert.ToDouble(labelekran.Text);
                if (islem == "toplama")
                {
                    ikincisayi = Convert.ToDouble(labelekran.Text);
                    sonuc = ilksayi + ikincisayi;
                    
                    
                }
                else if (islem == "cikartma")
                {
                    ikincisayi = Convert.ToDouble(labelekran.Text);
                    sonuc = ilksayi - ikincisayi;
                    
                    
                }
                else if (islem == "carpma")
                {
                    ikincisayi = Convert.ToDouble(labelekran.Text);
                    sonuc = ilksayi * ikincisayi;
                    
                    
                }
                else
                {
                    ikincisayi = Convert.ToDouble(labelekran.Text);
                    sonuc = ilksayi / ikincisayi;
                    
                    
                    
                }
                labelekran.Text = "0";
                ikincisayi = 0;
                ilksayi = sonuc;
                islem = "toplama";
            }
        }

        private void buttoncikartma_Click(object sender, EventArgs e)
        {
            if (ikincisayi == -1)
            {
                ilksayi = Convert.ToDouble(labelekran.Text);
                islem = "cikartma";
                labelekran.Text = "0";
                ikincisayi = 0;
            }
            else
            {
                ikincisayi = Convert.ToDouble(labelekran.Text);
                if (islem == "toplama")
                {
                    ikincisayi = Convert.ToDouble(labelekran.Text);
                    sonuc = ilksayi + ikincisayi;
                    
                    
                    
                }
                else if (islem == "cikartma")
                {
                    ikincisayi = Convert.ToDouble(labelekran.Text);
                    sonuc = ilksayi - ikincisayi;
                    
                    
                    
                }
                else if (islem == "carpma")
                {
                    ikincisayi = Convert.ToDouble(labelekran.Text);
                    sonuc = ilksayi * ikincisayi;
                    
                    
                    
                }
                else
                {
                    ikincisayi = Convert.ToDouble(labelekran.Text);
                    sonuc = ilksayi / ikincisayi;
                    
                    
                    
                }
                islem = "cikartma";
                labelekran.Text = "0";
                ikincisayi = 0;
                ilksayi = sonuc;
            }
        }

        private void buttoncarpma_Click(object sender, EventArgs e)
        {
            if (ikincisayi == -1)
            {
                ilksayi = Convert.ToDouble(labelekran.Text);
                islem = "carpma";
                labelekran.Text = "0";
                ikincisayi = 0;
            }
            else
            {
                ikincisayi = Convert.ToDouble(labelekran.Text);
                if (islem == "toplama")
                {
                    ikincisayi = Convert.ToDouble(labelekran.Text);
                    sonuc = ilksayi + ikincisayi;
                    
                    
                    
                }
                else if (islem == "cikartma")
                {
                    ikincisayi = Convert.ToDouble(labelekran.Text);
                    sonuc = ilksayi - ikincisayi;
                    
                    

                }
                else if (islem == "carpma")
                {
                    ikincisayi = Convert.ToDouble(labelekran.Text);
                    sonuc = ilksayi * ikincisayi;
                    
                    
                    
                }
                else
                {
                    ikincisayi = Convert.ToDouble(labelekran.Text);
                    sonuc = ilksayi / ikincisayi;
                    
                    
                    
                }
                labelekran.Text = "0";
                ikincisayi = 0;
                ilksayi = sonuc;
                islem = "carpma";
            }
        }

        private void buttonbolme_Click(object sender, EventArgs e)
        {
            if (ikincisayi == -1)
            {
                ilksayi = Convert.ToDouble(labelekran.Text);
                islem = "bolme";
                labelekran.Text = "0";
                ikincisayi = 0;
            }
            else
            {
                ikincisayi = Convert.ToDouble(labelekran.Text);
                if (islem == "toplama")
                {
                    ikincisayi = Convert.ToDouble(labelekran.Text);
                    sonuc = ilksayi + ikincisayi;
                    
                    
                    
                }
                else if (islem == "cikartma")
                {
                    ikincisayi = Convert.ToDouble(labelekran.Text);
                    sonuc = ilksayi - ikincisayi;
                    
                    
                    
                }
                else if (islem == "carpma")
                {
                    ikincisayi = Convert.ToDouble(labelekran.Text);
                    sonuc = ilksayi * ikincisayi;
                    
                    
                    
                }
                else
                {
                    ikincisayi = Convert.ToDouble(labelekran.Text);
                    sonuc = ilksayi / ikincisayi;
                    
                    
                    
                }
                labelekran.Text = "0";
                ikincisayi = 0;
                ilksayi = sonuc;
                islem = "bolme";
            }
        }

        private void buttonesittir_Click(object sender, EventArgs e)
        {
            if (islem=="toplama")
            {
                ikincisayi = Convert.ToDouble(labelekran.Text);
                sonuc = ilksayi + ikincisayi;
                labelekran.Text = Convert.ToString(sonuc);
                ilksayi = 0;
                ikincisayi = -1;
            }
            else if (islem=="cikartma")
            {
                ikincisayi = Convert.ToDouble(labelekran.Text);
                sonuc = ilksayi - ikincisayi;
                labelekran.Text = Convert.ToString(sonuc);
                ilksayi = 0;
                ikincisayi = -1;
            }
            else if (islem=="carpma")
            {
                ikincisayi = Convert.ToDouble(labelekran.Text);
                sonuc = ilksayi * ikincisayi;
                labelekran.Text = Convert.ToString(sonuc);
                ilksayi = 0;
                ikincisayi = -1;
            }
            else
            {
                ikincisayi = Convert.ToDouble(labelekran.Text);
                sonuc = ilksayi / ikincisayi;
                labelekran.Text = Convert.ToString(sonuc);
                ilksayi = 0;
                ikincisayi = -1;
            }
            
        }
    }
}
