using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace furmularz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string imie = tbimie.Text;
            string nazwisko = tbnazwisko.Text;
            string dane;
            string wizerunek;
            string faktury;
            string info;
            int prz = 0;

            if (checkBox1.Checked)
            {
                dane = "przetwarzanie danych osobowych";
                prz++;
            }
            else
            {
                dane = "";
            }

            if(checkBox2.Checked)
            {
                if(prz > 0)
                    wizerunek = ", wykorzystanie wizerunku";
                else
                    wizerunek = "wykorzystanie wizerunku";

                prz++;
            }
            else
            {
                wizerunek = "";
            }

            if(checkBox3.Checked)
            {
                if (prz == 2)
                    faktury = " oraz wystawianie faktur bez opamiętania";
                else if (prz > 0)
                    faktury = ", wystawianie faktur bez opamiętania";
                else
                    faktury = "wystawianie faktur bez opamiętania";
                prz++;
            }
            else
            {
                faktury = "";
            }

            if (radioButton1.Checked)
            {
                info = "telewizji";
            }
            else if (radioButton2.Checked)
            {
                info = "radia";
            }
            else
                info = "telewizji i radia";

            int granica; 
            Int32.TryParse(tbgranica.Text, out granica);

            if(prz == 0)
            {
                MessageBox.Show("" + imie + " " + nazwisko + " pozyskuje informacje z " +
                "" + info + " oraz deklaruje opłatę w wysokości " + 2 * granica + " zł.");
            }
            else
            {
                MessageBox.Show("" + imie + " " + nazwisko + " wyraził(a) zgodę na " +
               "" + dane + "" + wizerunek + "" + faktury + ". Pozyskuje informacje z " +
               "" + info + " oraz deklaruje opłatę w wysokości " + 2 * granica + " zł.");
            }
        }

        private void tbgranica_TextChanged(object sender, EventArgs e)
        {
            if (tbgranica.Text.Length > 0)
            {
                char c = tbgranica.Text[tbgranica.Text.Length - 1];
                int n = c;
                if (n > 57 || n < 48)
                {
                    tbgranica.Text = tbgranica.Text.Substring(0, tbgranica.Text.Length - 1);
                    tbgranica.SelectionStart = tbgranica.Text.Length;
                }
            }
        }
    }
}
