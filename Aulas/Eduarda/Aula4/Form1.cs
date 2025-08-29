using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //botao calcular
        private void Button1_Click(object sender, EventArgs e)
        {
            double vel, dist, tempo;

            dist = Convert.ToDouble(txtdist.Text);
            tempo = Convert.ToDouble(txttempo.Text);

            vel = dist / tempo;

            txtvel.Text = vel.ToString();//simplificação apenas para string.. caso contrario: convert.tostring(vel);
            btcalcular.BackColor = Color.Magenta;
        }
       
        private void Label1_Click(object sender, EventArgs e)
        {

        }

        //botao limpar
        private void Btlimpar_Click(object sender, EventArgs e)
        {
            txtdist.Text = "";
            txttempo.Text = "";
            txtvel.Text = "";
        }

        private void Btlimpar_MouseEnter(object sender, EventArgs e)
        {
            btlimpar.BackColor = Color.Magenta;
        }

        private void Btlimpar_Click_1(object sender, EventArgs e)
        {

        }

        private void Btlimpar_MouseLeave(object sender, EventArgs e)
        {
            btlimpar.BackColor = Color.MediumPurple;
        }

        private void Btcalcular_MouseLeave(object sender, EventArgs e)
        {
            btcalcular.BackColor = Color.MediumPurple;
        }
    }
}

//maneiras de limpar o campo
/*
 txtdist.clear();
 txttempo.text="";
 txtvel.text="0";
     
     */
