using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Procvičování_metody_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool JeAlfanum(string vstup, ref int pocetMalychPismen, ref int pocetVelkychPismen, ref int pocetCifer, ref int pocetOstatni)
        {
            string cifry = "0123456789";
            string malePismena = "yxcvbnmasdfghjklqwertzuiop";
            string velkaPismena = "YXCVBNMASDFGHJKLQWERTZUIOP";
            foreach(char znak in vstup)
            {
                if(malePismena.Contains(znak))
                {
                    pocetMalychPismen++;
                }
                else if(velkaPismena.Contains(znak))
                {
                    pocetVelkychPismen++;
                }
                else if(cifry.Contains(znak))
                {
                    pocetCifer++;
                }
                else
                {
                    pocetOstatni++;
                }    
            }
            if (pocetOstatni == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string vstup = textBox1.Text;
            int pocetMalychPismen = 0, pocetVelkychPismen = 0, pocetCifer = 0, pocetOstatni = 0;
            odpoved.Text = string.Format("Text {0} alfanumerický!\nPočet malých písmen: {1}\nPočet velkých písmen: {2}\nPočet cifer: {3}\nPočet ostatních: {4}", JeAlfanum(vstup, ref pocetMalychPismen, ref pocetVelkychPismen, ref pocetCifer, ref pocetOstatni) ? "je":"není", pocetMalychPismen, pocetVelkychPismen,pocetCifer,pocetOstatni);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            this.Hide();
            menu.ShowDialog();
            this.Close();
        }

        private void button4_MouseEnter(object sender, EventArgs e)
        {
            button4.ForeColor = Color.Red;
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button4.ForeColor = Color.Gold;
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.ForeColor = Color.Gold;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.ForeColor = Color.LawnGreen;
        }
    }
}
