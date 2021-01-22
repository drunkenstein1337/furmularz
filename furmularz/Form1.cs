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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string imie = tbimie.Text;
            string nazwisko = tbnazwisko.Text;
            string dane;
            string wizerunek;
            string faktury;
            string info;
            if (checkBox1.Checked)
            {
                dane = "przetwarzanie danych osobowych, ";
            }
            else
            {
                dane = "";
            }

            if(checkBox2.Checked)
            {
                wizerunek = "wykorzystanie wizerunku, ";
            }
            else
            {
                wizerunek = "";
            }

            if(checkBox3.Checked)
            {
                faktury = "wystawianie faktur bez opamiętania";
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
                info = "telewizji i  radia";

            double granica; 
            Double.TryParse(tbgranica.Text, out granica);


            MessageBox.Show(""+imie+" "+nazwisko+" wyraził(a) zgodę na " +
                ""+dane+""+wizerunek+""+faktury+". Pozuskuje informacje z " +
                ""+info+" oraz deklaruje opłatę w wysokości "+2*granica+" zł.   ");
        }


    }
}
