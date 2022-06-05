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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.ForeColor = Color.Gold;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.ForeColor = Color.LawnGreen;
        }

        private void button4_MouseEnter(object sender, EventArgs e)
        {
            button4.ForeColor = Color.Red;
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button4.ForeColor = Color.Gold;
        }
        int NSD(int a, int b)
        {
            while (a != b)
            {
                if (a > b) a -= b;
                else b -= a;
            }
            return a;
        }
        private bool JePrvocislo(int cislo)
        {
            bool prvocislo = true;
            if (cislo == 2) prvocislo = true;
            else
            {
                if (cislo == 1 || cislo % 2 == 0) prvocislo = false;
                else for (int delitel = 3; delitel <= Math.Sqrt(cislo) && prvocislo; ++delitel)
                    {
                        if (cislo % delitel == 0) return false;
                    }
            }
            return prvocislo;
        }
        void Rozklad(int a, ListBox listbox)
        {
            int pomocna = 1;
            listbox.Items.Clear();
            int i = 2;
            while (i <= a)
            {
                if (JePrvocislo(i) == false) ;
                while (a % i == 0)
                {
                    listbox.Items.Add(i);
                    a /= i;
                }
                if (i == 3) pomocna = 2;
                i += pomocna;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = (int)numericUpDown1.Value;
            int b = (int)numericUpDown2.Value;
            Rozklad(a, listBox2);
            Rozklad(b, listBox1);
            odpovedNSD.Text = NSD(a, b).ToString();
            odpovedNSN.Text = Convert.ToString((a * b) / NSD(a, b));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            this.Hide();
            menu.ShowDialog();
            this.Close();
        }
    }
}
