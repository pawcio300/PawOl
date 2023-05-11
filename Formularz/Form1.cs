using System.Diagnostics;

namespace Formularz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            checkBox1.Checked = false;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            label4.Text = string.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string haslo = textBox2.Text;
            string phaslo = textBox3.Text;
            if (textBox1.Text == string.Empty || textBox2.Text == string.Empty || textBox3.Text == string.Empty || radioButton1.Checked != true && radioButton2.Checked != true && radioButton3.Checked != true || haslo != phaslo)
            {
                label13.ForeColor = Color.Red;
                if (haslo != phaslo)
                {
                    label4.ForeColor = Color.Red;
                    label4.Text = "Has³a nie s¹ identyczne";
                }
                else if(haslo.Length < 8)
                {
                    label4.Text = "Has³o musi mieæ minimum 8 znaków.";                 
                }
                else
                {
                    label4.Text = string.Empty;
                }
                label13.Text = "Uzupe³nij wszystkie pola.";
            }
            else
            {
                label13.Text = string.Empty;
                label9.Text = textBox1.Text;
                label10.Text = textBox2.Text;
                if (checkBox1.Checked == true)
                {
                    label11.Text = "TAK";
                }
                else
                {
                    label11.Text = "NIE";
                }
                if(radioButton1.Checked == true)
                {
                    label12.Text = "ma³a";
                }
                else if(radioButton2.Checked == true)
                {
                    label12.Text = "du¿a";
                }
                else if(radioButton3.Checked == true)
                {
                    label12.Text = "œrednia";
                }
            }

            if (haslo != phaslo)
            {
                label4.ForeColor = Color.Red;
                label4.Text = "Has³a nie s¹ identyczne";
            }
            else
            {
                label4.Text = string.Empty;
            }
        }
        private void checkBox1_Click(object sender, EventArgs e)
        {
            checkBox1.Enabled = false;
        }
    }
}