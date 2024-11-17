using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void siparisal_Click(object sender, EventArgs e)
        {
            decimal ucret = 0;
            string icindekiler = "";
            if (checkBoxsucuk.Checked == true)
            { 
                icindekiler += " - " + "Sucuk"; 
            }
            if (checkBoxsosis.Checked == true)
            { 
                icindekiler += " - " + "Sosis"; 
            }
            if (checkBoxmantar.Checked == true)
            {
                icindekiler += " - " + "Mantar";
            }
            if (checkBoxkasar.Checked == true)
            { 
                icindekiler += " - " + "Kaşar"; 
            }
            if (checkBoxpeynir.Checked == true)
            { 
                icindekiler += " - " + "Peynir";
            }
            if (checkBoxbiber.Checked == true)
            { 
                icindekiler += " - " + "Köz Biber";
            }
            if (checkBoxmisir.Checked == true)
            {
                icindekiler += " - " + "Mısır";
            }
            if (checkBoxzeytin.Checked == true)
            {
                icindekiler += " - " + "Zeytin";
            }
            if (checkBoxjambon.Checked == true)
            {
                icindekiler += " - " + "Jambon";
            }

            if (comboBoxPizzaBoy.Text == "Küçük")
            { 
                ucret = numericUpDownpizzaadet.Value * 150; 
            }
            else if (comboBoxPizzaBoy.Text == "Orta")
            {
                ucret = numericUpDownpizzaadet.Value * 175; 
            }
            else if (comboBoxPizzaBoy.Text == "Büyük")
            { 
                ucret = numericUpDownpizzaadet.Value * 200;
            }


            if (comboBoxIcecek.Text == "1lt Coca Cola")
            { 
                ucret += numericUpDownicecekadet.Value * 35; 
            }
            else if (comboBoxIcecek.Text == "1lt Fanta")
            { 
                ucret += numericUpDownicecekadet.Value * 35; 
            }
            else if (comboBoxIcecek.Text == "1lt Sprite")
            { 
                ucret += numericUpDownicecekadet.Value * 35; 
            }
            else if (comboBoxIcecek.Text == "1lt Ayran")
            { 
                ucret += numericUpDownicecekadet.Value * 25;
            }

            listBoxadisoyadi.Items.Add(textBoxAdSoyad.Text);
            listBoxtelefon.Items.Add(textBoxTelefon.Text);
            listBoxadres.Items.Add(textBoxAdres.Text);
            listBoxpizza.Items.Add(numericUpDownpizzaadet.Value + " adet " + comboBoxPizzaBoy.Text);
            listBoxicecek.Items.Add(numericUpDownicecekadet.Value + " adet " + comboBoxIcecek.Text);
            listBoxicindekiler.Items.Add(icindekiler);
            listBoxucret.Items.Add(ucret + "TL");
        }

        private void temizle_Click(object sender, EventArgs e)
        {
            textBoxAdSoyad.Text = "";
            textBoxTelefon.Text = "";
            textBoxAdres.Text = "";
            comboBoxIcecek.Text = "";
            comboBoxPizzaBoy.Text = "";
            numericUpDownpizzaadet.Value = 0;
            numericUpDownicecekadet.Value = 0;
            checkBoxsucuk.Checked = false;
            checkBoxsosis.Checked = false;
            checkBoxmantar.Checked = false;
            checkBoxkasar.Checked = false;
            checkBoxpeynir.Checked = false;
            checkBoxbiber.Checked = false;
            checkBoxmisir.Checked = false;
            checkBoxzeytin.Checked = false;
            checkBoxjambon.Checked = false;
        }

        private void siparistemizle_Click(object sender, EventArgs e)
        {
            listBoxadisoyadi.Items.Clear();
            listBoxtelefon.Items.Clear();
            listBoxadres.Items.Clear();
            listBoxpizza.Items.Clear();
            listBoxicecek.Items.Clear();
            listBoxicindekiler.Items.Clear();
            listBoxucret.Items.Clear();
        }
    }
}
