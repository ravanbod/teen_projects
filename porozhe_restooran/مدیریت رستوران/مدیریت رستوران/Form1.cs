using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace مدیریت_رستوران
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!Directory.Exists("c:\\restoran") == true)
            {
                Directory.CreateDirectory("c:\\restoran");
                Directory.CreateDirectory("c:\\restoran\\ghazayegarm");
                Directory.CreateDirectory("c:\\restoran\\ghazayesard");
                Directory.CreateDirectory("c:\\restoran\\deser");
                Directory.CreateDirectory("c:\\restoran\\noshidani");
                Directory.CreateDirectory("c:\\restoran\\mokhalafat");
                Directory.CreateDirectory("c:\\restoran\\faktor");
                StreamWriter shomarande = new StreamWriter("c:\\restoran\\shomarande.txt");
                shomarande.Write("0");
                shomarande.Close();
                StreamWriter shomarandefaktor = new StreamWriter("c:\\restoran\\shomarandefaktor.txt");
                shomarande.Write("0");
                shomarande.Close();

            }
            StreamReader al = new StreamReader("c:\\restoran\\shomarande.txt");
            string kkk= al.ReadToEnd();
            int pio = Convert.ToInt16(kkk);
            al.Close();
            for (int i = 0; i <= pio;i++ )
            {
                if(File.Exists("c:\\restoran\\ghazayegarm\\"+i.ToString()+".txt"))
                {
                   StreamReader uio1 = new StreamReader("c:\\restoran\\ghazayegarm\\"+i.ToString()+".txt");
                   listBox1.Items.Add(uio1.ReadToEnd()+"      "+i.ToString());
                   uio1.Close();
                }
            }
            for (int i = 0; i <= pio; i++)
            {
                if (File.Exists("c:\\restoran\\ghazayesard\\" + i.ToString() + ".txt"))
                {
                    StreamReader uio1 = new StreamReader("c:\\restoran\\ghazayesard\\" + i.ToString() + ".txt");
                    listBox1.Items.Add(uio1.ReadToEnd() + "      " + i.ToString());
                    uio1.Close();
                }
            }
            for (int i = 0; i <= pio; i++)
            {
                if (File.Exists("c:\\restoran\\deser\\" + i.ToString() + ".txt"))
                {
                    StreamReader uio1 = new StreamReader("c:\\restoran\\deser\\" + i.ToString() + ".txt");
                    listBox1.Items.Add(uio1.ReadToEnd() + "      " + i.ToString());
                    uio1.Close();
                }
            }
            for (int i = 0; i <= pio; i++)
            {
                if (File.Exists("c:\\restoran\\noshidani\\" + i.ToString() + ".txt"))
                {
                    StreamReader uio1 = new StreamReader("c:\\restoran\\noshidani\\" + i.ToString() + ".txt");
                    listBox1.Items.Add(uio1.ReadToEnd() + "      " + i.ToString());
                    uio1.Close();
                }
            }
            for (int i = 0; i <= pio; i++)
            {
                if (File.Exists("c:\\restoran\\mokhalafat\\" + i.ToString() + ".txt"))
                {
                    StreamReader uio1 = new StreamReader("c:\\restoran\\mokhalafat\\" + i.ToString() + ".txt");
                    listBox1.Items.Add(uio1.ReadToEnd() + "      " + i.ToString());
                    uio1.Close();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            StreamReader gh=new StreamReader("c:\\restoran\\shomarande.txt");
            label5.Text = gh.ReadToEnd();
            gh.Close();
            int shomare = Convert.ToInt16(label5.Text);
            shomare++;
            StreamWriter gj = new StreamWriter("c:\\restoran\\shomarande.txt");
            gj.Write(shomare.ToString());
            gj.Close();
            if (radioButton1.Checked)
            {
                StreamWriter name = new StreamWriter("c:\\restoran\\ghazayegarm\\"+shomare+".txt");
                name.Write(textBox1.Text);
                name.Close();
                StreamWriter price = new StreamWriter("c:\\restoran\\ghazayegarm\\" + shomare+"p" + ".txt");
                price.Write(textBox2.Text);
                price.Close();
            }
            if (radioButton2.Checked)
            {
                StreamWriter name = new StreamWriter("c:\\restoran\\ghazayesard\\" + shomare + ".txt");
                name.Write(textBox1.Text);
                name.Close();
                StreamWriter price = new StreamWriter("c:\\restoran\\ghazayesard\\" + shomare + "p" + ".txt");
                price.Write(textBox2.Text);
                price.Close();
            }
            if (radioButton3.Checked)
            {
                StreamWriter name = new StreamWriter("c:\\restoran\\deser\\" + shomare + ".txt");
                name.Write(textBox1.Text);
                name.Close();
                StreamWriter price = new StreamWriter("c:\\restoran\\deser\\" + shomare + "p" + ".txt");
                price.Write(textBox2.Text);
                price.Close();
            }
            if (radioButton4.Checked)
            {
                StreamWriter name = new StreamWriter("c:\\restoran\\noshidani\\" + shomare + ".txt");
                name.Write(textBox1.Text);
                name.Close();
                StreamWriter price = new StreamWriter("c:\\restoran\\noshidani\\" + shomare + "p" + ".txt");
                price.Write(textBox2.Text);
                price.Close();
            }
            if (radioButton5.Checked)
            {
                StreamWriter name = new StreamWriter("c:\\restoran\\mokhalafat\\" + shomare + ".txt");
                name.Write(textBox1.Text);
                name.Close();
                StreamWriter price = new StreamWriter("c:\\restoran\\mokhalafat\\" + shomare + "p" + ".txt");
                price.Write(textBox2.Text);
                price.Close();
            }
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            textBox1.Text = "";
            textBox2.Text = "";
            StreamReader al = new StreamReader("c:\\restoran\\shomarande.txt");
            string kkk = al.ReadToEnd();
            int pio = Convert.ToInt16(kkk);
            al.Close();
            for (int i = 0; i <= pio; i++)
            {
                if (File.Exists("c:\\restoran\\ghazayegarm\\" + i.ToString() + ".txt"))
                {
                    StreamReader uio1 = new StreamReader("c:\\restoran\\ghazayegarm\\" + i.ToString() + ".txt");
                    listBox1.Items.Add(uio1.ReadToEnd()+"      "+i.ToString());
                    uio1.Close();
                }
            }
            for (int i = 0; i <= pio; i++)
            {
                if (File.Exists("c:\\restoran\\ghazayesard\\" + i.ToString() + ".txt"))
                {
                    StreamReader uio1 = new StreamReader("c:\\restoran\\ghazayesard\\" + i.ToString() + ".txt");
                    listBox1.Items.Add(uio1.ReadToEnd()+"      "+i.ToString());
                    uio1.Close();
                }
            }
            for (int i = 0; i <= pio; i++)
            {
                if (File.Exists("c:\\restoran\\deser\\" + i.ToString() + ".txt"))
                {
                    StreamReader uio1 = new StreamReader("c:\\restoran\\deser\\" + i.ToString() + ".txt");
                    listBox1.Items.Add(uio1.ReadToEnd()+"      "+i.ToString());
                    uio1.Close();
                }
            }
            for (int i = 0; i <= pio; i++)
            {
                if (File.Exists("c:\\restoran\\noshidani\\" + i.ToString() + ".txt"))
                {
                    StreamReader uio1 = new StreamReader("c:\\restoran\\noshidani\\" + i.ToString() + ".txt");
                    listBox1.Items.Add(uio1.ReadToEnd()+"      "+i.ToString());
                    uio1.Close();
                }
            }
            for (int i = 0; i <= pio; i++)
            {
                if (File.Exists("c:\\restoran\\mokhalafat\\" + i.ToString() + ".txt"))
                {
                    StreamReader uio1 = new StreamReader("c:\\restoran\\mokhalafat\\" + i.ToString() + ".txt");
                    listBox1.Items.Add(uio1.ReadToEnd()+"      "+i.ToString());
                    uio1.Close();
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }
        string namemahsol, gheymatemahsol;
        private void button3_Click(object sender, EventArgs e)
        {
            if (File.Exists("c:\\restoran\\ghazayegarm\\" + textBox3.Text + ".txt"))
            {
                StreamReader ppp = new StreamReader("c:\\restoran\\ghazayegarm\\" + textBox3.Text + ".txt");
                label7.Text = ppp.ReadToEnd();
                ppp.Close();
                StreamReader pppp = new StreamReader("c:\\restoran\\ghazayegarm\\" + textBox3.Text + "p" + ".txt");
                label8.Text = pppp.ReadToEnd();
                pppp.Close();
                namemahsol = "c:\\restoran\\ghazayegarm\\" + textBox3.Text + ".txt";
                gheymatemahsol = "c:\\restoran\\ghazayegarm\\" + textBox3.Text + "p" + ".txt";
            }
            
            if (File.Exists("c:\\restoran\\ghazayesard\\" + textBox3.Text + ".txt"))
            {
                StreamReader ppp = new StreamReader("c:\\restoran\\ghazayesard\\" + textBox3.Text + ".txt");
                label7.Text = ppp.ReadToEnd();
                ppp.Close();
                StreamReader pppp = new StreamReader("c:\\restoran\\ghazayesard\\" + textBox3.Text + "p" + ".txt");
                label8.Text = pppp.ReadToEnd();
                pppp.Close();
                namemahsol = "c:\\restoran\\ghazayesard\\" + textBox3.Text + ".txt";
                gheymatemahsol = "c:\\restoran\\ghazayesard\\" + textBox3.Text + "p" + ".txt";
            }
            if (File.Exists("c:\\restoran\\deser\\" + textBox3.Text + ".txt"))
            {
                StreamReader ppp = new StreamReader("c:\\restoran\\deser\\" + textBox3.Text + ".txt");
                label7.Text = ppp.ReadToEnd();
                ppp.Close();
                StreamReader pppp = new StreamReader("c:\\restoran\\deser\\" + textBox3.Text + "p" + ".txt");
                label8.Text = pppp.ReadToEnd();
                pppp.Close();
                namemahsol = "c:\\restoran\\deser\\" + textBox3.Text + ".txt";
                gheymatemahsol = "c:\\restoran\\deser\\" + textBox3.Text + "p" + ".txt";
            }
            if (File.Exists("c:\\restoran\\noshidani\\" + textBox3.Text + ".txt"))
            {
                StreamReader ppp = new StreamReader("c:\\restoran\\noshidani\\" + textBox3.Text + ".txt");
                label7.Text = ppp.ReadToEnd();
                ppp.Close();
                StreamReader pppp = new StreamReader("c:\\restoran\\noshidani\\" + textBox3.Text + "p" + ".txt");
                label8.Text = pppp.ReadToEnd();
                pppp.Close();
                namemahsol = "c:\\restoran\\noshidani\\" + textBox3.Text + ".txt";
                gheymatemahsol = "c:\\restoran\\noshidani\\" + textBox3.Text + "p" + ".txt";
            }
            if (File.Exists("c:\\restoran\\mokhalafat\\" + textBox3.Text + ".txt"))
            {
                StreamReader ppp = new StreamReader("c:\\restoran\\mokhalafat\\" + textBox3.Text + ".txt");
                label7.Text = ppp.ReadToEnd();
                ppp.Close();
                StreamReader pppp = new StreamReader("c:\\restoran\\mokhalafat\\" + textBox3.Text + "p" + ".txt");
                label8.Text = pppp.ReadToEnd();
                pppp.Close();
                namemahsol = "c:\\restoran\\mokhalafat\\" + textBox3.Text + ".txt";
                gheymatemahsol = "c:\\restoran\\mokhalafat\\" + textBox3.Text + "p" + ".txt";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            StreamWriter hjj = new StreamWriter(namemahsol);
            hjj.Write(textBox4.Text);
            hjj.Close();
            StreamWriter hkk = new StreamWriter(gheymatemahsol);
            hkk.Write(textBox5.Text);
            hkk.Close();
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (File.Exists("c:\\restoran\\ghazayegarm\\" + textBox6.Text + ".txt"))
            {
                namemahsol = "c:\\restoran\\ghazayegarm\\" + textBox6.Text + ".txt";
                gheymatemahsol = "c:\\restoran\\ghazayegarm\\" + textBox6.Text + "p" + ".txt";
                File.Delete(namemahsol);
                File.Delete(gheymatemahsol);
            }

            if (File.Exists("c:\\restoran\\ghazayesard\\" + textBox6.Text + ".txt"))
            {
                namemahsol = "c:\\restoran\\ghazayesard\\" + textBox6.Text + ".txt";
                gheymatemahsol = "c:\\restoran\\ghazayesard\\" + textBox6.Text + "p" + ".txt";
                File.Delete(namemahsol);
                File.Delete(gheymatemahsol);
            }
            if (File.Exists("c:\\restoran\\deser\\" + textBox6.Text + ".txt"))
            {
                namemahsol = "c:\\restoran\\deser\\" + textBox6.Text + ".txt";
                gheymatemahsol = "c:\\restoran\\deser\\" + textBox6.Text + "p" + ".txt";
                File.Delete(namemahsol);
                File.Delete(gheymatemahsol);
            }
            if (File.Exists("c:\\restoran\\noshidani\\" + textBox6.Text + ".txt"))
            {
                namemahsol = "c:\\restoran\\noshidani\\" + textBox6.Text + ".txt";
                gheymatemahsol = "c:\\restoran\\noshidani\\" + textBox6.Text + "p" + ".txt";
                File.Delete(namemahsol);
                File.Delete(gheymatemahsol);
            }
            if (File.Exists("c:\\restoran\\mokhalafat\\" + textBox6.Text + ".txt"))
            {
                namemahsol = "c:\\restoran\\mokhalafat\\" + textBox6.Text + ".txt";
                gheymatemahsol = "c:\\restoran\\mokhalafat\\" + textBox6.Text + "p" + ".txt";
                File.Delete(namemahsol);
                File.Delete(gheymatemahsol);
            }
            
        }
    }
}
