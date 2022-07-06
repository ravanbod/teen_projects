using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
namespace مدیریت_رستوران2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StreamReader a = new StreamReader("c:\\restoran\\shomarande.txt");
            string shomare = a.ReadToEnd();
            a.Close();
            int shomarande = Convert.ToInt16(shomare);
            for (int i = 1; i <= shomarande; i++)
            {
                if (File.Exists("c:\\restoran\\ghazayegarm\\" + i + ".txt"))
                {
                    StreamReader garm = new StreamReader("c:\\restoran\\ghazayegarm\\" + i + ".txt");
                    comboBox1.Items.Add(garm.ReadToEnd());
                    garm.Close();
                }
            }
            for (int i = 1; i <= shomarande; i++)
            {
                if (File.Exists("c:\\restoran\\ghazayesard\\" + i + ".txt"))
                {
                    StreamReader garm = new StreamReader("c:\\restoran\\ghazayesard\\" + i + ".txt");
                    comboBox2.Items.Add(garm.ReadToEnd());
                    garm.Close();
                }
            }
            for (int i = 1; i <= shomarande; i++)
            {
                if (File.Exists("c:\\restoran\\deser\\" + i + ".txt"))
                {
                    StreamReader garm = new StreamReader("c:\\restoran\\deser\\" + i + ".txt");
                    comboBox3.Items.Add(garm.ReadToEnd());
                    garm.Close();
                }
            }
            for (int i = 1; i <= shomarande; i++)
            {
                if (File.Exists("c:\\restoran\\noshidani\\" + i + ".txt"))
                {
                    StreamReader garm = new StreamReader("c:\\restoran\\noshidani\\" + i + ".txt");
                    comboBox4.Items.Add(garm.ReadToEnd());
                    garm.Close();
                }
            }
            for (int i = 1; i <= shomarande; i++)
            {
                if (File.Exists("c:\\restoran\\mokhalafat\\" + i + ".txt"))
                {
                    StreamReader garm = new StreamReader("c:\\restoran\\mokhalafat\\" + i + ".txt");
                    comboBox5.Items.Add(garm.ReadToEnd());
                    garm.Close();
                }
            }
        }
        int tedadekala = 0;
        long hazine,iop=0;
        private void button1_Click(object sender, EventArgs e)
        {
            tedadekala++;
            StreamReader a = new StreamReader("c:\\restoran\\shomarande.txt");
            string shomare = a.ReadToEnd();
            a.Close();
            int shomarande = Convert.ToInt16(shomare);
            for (int i = 1; i <= shomarande; i++)
            {
                if (File.Exists("c:\\restoran\\ghazayegarm\\" + i + ".txt"))
                {
                    StreamReader jij = new StreamReader("c:\\restoran\\ghazayegarm\\" + i + ".txt");
                    if (jij.ReadToEnd() == comboBox1.Text)
                    {
                        StreamReader hgy = new StreamReader("c:\\restoran\\ghazayegarm\\" + i + "p.txt");
                        string opo = hgy.ReadToEnd();
                        long lll = Convert.ToInt64(opo) * Convert.ToInt64(textBox1.Text);
                        hazine += lll;
                        label11.Text = hazine.ToString();
                        richTextBox1.Text += ("\n" + comboBox1.Text + "       " + Convert.ToInt16(textBox1.Text) + "       " + hazine + "\n");
                    }
                    jij.Close();
                }
            }
            iop = iop + hazine;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tedadekala++;
            StreamReader a = new StreamReader("c:\\restoran\\shomarande.txt");
            string shomare = a.ReadToEnd();
            a.Close();
            int shomarande = Convert.ToInt16(shomare);
            for (int i = 1; i <= shomarande; i++)
            {
                if (File.Exists("c:\\restoran\\ghazayesard\\" + i + ".txt"))
                {
                    StreamReader jij = new StreamReader("c:\\restoran\\ghazayesard\\" + i + ".txt");
                    if (jij.ReadToEnd() == comboBox2.Text)
                    {
                        StreamReader hgy = new StreamReader("c:\\restoran\\ghazayesard\\" + i + "p.txt");
                        string opo = hgy.ReadToEnd();
                        long lll = Convert.ToInt64(opo) * Convert.ToInt64(textBox2.Text);
                        hazine += lll;
                        label12.Text = hazine.ToString();
                        richTextBox1.Text += ("\n" + comboBox2.Text + "       " + Convert.ToInt16(textBox1.Text) + "       " + hazine + "\n");
                    }
                    jij.Close();
                }
            }
            iop = iop + hazine;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tedadekala++;
            StreamReader a = new StreamReader("c:\\restoran\\shomarande.txt");
            string shomare = a.ReadToEnd();
            a.Close();
            int shomarande = Convert.ToInt16(shomare);
            for (int i = 1; i <= shomarande; i++)
            {
                if (File.Exists("c:\\restoran\\deser\\" + i + ".txt"))
                {
                    StreamReader jij = new StreamReader("c:\\restoran\\deser\\" + i + ".txt");
                    if (jij.ReadToEnd() == comboBox3.Text)
                    {
                        StreamReader hgy = new StreamReader("c:\\restoran\\deser\\" + i + "p.txt");
                        string opo = hgy.ReadToEnd();
                        long lll = Convert.ToInt64(opo) * Convert.ToInt64(textBox3.Text);
                        hazine += lll;
                        label13.Text = hazine.ToString();
                        richTextBox1.Text += ("\n" + comboBox3.Text + "       " + Convert.ToInt16(textBox1.Text) + "       " + hazine + "\n");
                    }
                    jij.Close();
                }
            }
            iop = iop + hazine;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tedadekala++;
            StreamReader a = new StreamReader("c:\\restoran\\shomarande.txt");
            string shomare = a.ReadToEnd();
            a.Close();
            int shomarande = Convert.ToInt16(shomare);
            for (int i = 1; i <= shomarande; i++)
            {
                if (File.Exists("c:\\restoran\\noshidani\\" + i + ".txt"))
                {
                    StreamReader jij = new StreamReader("c:\\restoran\\noshidani\\" + i + ".txt");
                    if (jij.ReadToEnd() == comboBox4.Text)
                    {
                        StreamReader hgy = new StreamReader("c:\\restoran\\noshidani\\" + i + "p.txt");
                        string opo = hgy.ReadToEnd();
                        long lll = Convert.ToInt64(opo) * Convert.ToInt64(textBox4.Text);
                        hazine += lll;
                        label14.Text = hazine.ToString();
                        richTextBox1.Text += ("\n" + comboBox4.Text + "       " + Convert.ToInt16(textBox1.Text) + "       " + hazine + "\n");
                    }
                    jij.Close();
                }
            }
            iop = iop + hazine;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            tedadekala++;
            StreamReader a = new StreamReader("c:\\restoran\\shomarande.txt");
            string shomare = a.ReadToEnd();
            a.Close();
            long shomarande = Convert.ToInt64(shomare);
            for (int i = 1; i <= shomarande; i++)
            {
                if (File.Exists("c:\\restoran\\mokhalafat\\" + i + ".txt"))
                {
                    StreamReader jij = new StreamReader("c:\\restoran\\mokhalafat\\" + i + ".txt");
                    if (jij.ReadToEnd() == comboBox5.Text)
                    {
                        StreamReader hgy = new StreamReader("c:\\restoran\\mokhalafat\\" + i + "p.txt");
                        string opo = hgy.ReadToEnd();
                        long lll = Convert.ToInt64(opo) * Convert.ToInt64(textBox5.Text);
                        hazine += lll;
                        label15.Text = hazine.ToString();
                        richTextBox1.Text += ("\n" + comboBox5.Text + "       " + Convert.ToInt16(textBox1.Text) + "       " + hazine + "\n");
                    }
                    jij.Close();
                }
            }
            iop = iop + hazine;
        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += ("\n______________________" + "\n");
            long jamekol=Convert.ToInt64(label11.Text)+Convert.ToInt64(label12.Text)+Convert.ToInt64(label13.Text)+Convert.ToInt64(label14.Text)+Convert.ToInt64(label15.Text);
            richTextBox1.Text += ("\n" + "جمع هزینه ها" + "                 " + iop.ToString() + "\n");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            StreamReader uiu = new StreamReader("c:\\restoran\\shomarandefaktor.txt");
            string yyy = uiu.ReadToEnd();
            int shomare = Convert.ToInt16(yyy);
            shomare++;
            uiu.Close();
            StreamWriter ioi = new StreamWriter("c:\\restoran\\shomarandefaktor.txt");
            ioi.Write(shomare.ToString());
            ioi.Close();
            StreamWriter faktor = new StreamWriter("c:\\restoran\\faktor\\"+shomare+".txt");
            faktor.Write(richTextBox1.Text);
            faktor.Close();
        }
    }
}
