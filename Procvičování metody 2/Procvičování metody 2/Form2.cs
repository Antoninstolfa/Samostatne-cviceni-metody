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
    public partial class Form2 : Form
    {
        public Form2()
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

        void SmazatCislice(string vstup)
        {
            string cifry = "0123456789";
            while (vstup.Contains("  "))
            {
                vstup = vstup.Replace("  ", " ");
            }
            foreach (char c in cifry)
            {
                if (vstup.Contains(c)) vstup = vstup.Replace(c.ToString(), "");
            }
            string[] slova = vstup.Split(' ');
            foreach (string slovo in slova)
            {
                listBox1.Items.Add(slovo);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string vstup = textBox1.Text;
            SmazatCislice(vstup);
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
