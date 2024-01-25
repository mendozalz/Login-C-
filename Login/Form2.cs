using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            lblResult.Text = "";
        }

        private void listProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            imgProduct.ImageLocation = "C:/Users/MENDO/Pictures/cursoWindowsForms/" + listProduct.Text + ".png";
        }

        private void comPasarela_SelectedIndexChanged(object sender, EventArgs e)
        {
            imgPasarela.ImageLocation = "C:/Users/MENDO/Pictures/cursoWindowsForms/" + comPasarela.Text + ".png";
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Login volver = new Login();
            volver.Show();
            this.Hide();
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            int contProducts = 0;
            int contPasarela = 0;
            int total = 0;
            string pasarela = "";

            if (listProduct.Text == "shirt")
            {
                total += 500;
                contProducts++;
            }
            if (listProduct.Text == "shoes")
            {
                total += 900;
                contProducts++;
            }
            if (listProduct.Text == "short")
            {
                total += 300;
                contProducts++;
            }
            if (comPasarela.Text == "tdc")
            {
                pasarela = "Se pago con TDC ";
                contPasarela++;
            }
            if (comPasarela.Text == "paypal")
            {
                pasarela = "Se pago con Paypal ";
                contPasarela++;
            }
            if (contPasarela > 0 && contProducts>0)
            {
                lblResult.Text = pasarela + "el valor total de "+ total;
            }
            else
            {
                lblResult.Text = "Debes seleccionar algo para continuar";
            }
        }
    }
}
