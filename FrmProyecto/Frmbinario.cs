using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmProyecto
{
    public partial class Frmbinario : Form
    {
        public Frmbinario()
        {
            InitializeComponent();
        }
        public void btnconvertir_Click(object sender, EventArgs e)
        {
            try
            {
                btnconvertir.Visible = false;
                btnlimpiar.Visible = true;
                string bi = "";
                string binar = "";

                int.Parse(txt1.Text); int.Parse(txt2.Text); int bin = int.Parse(txt1.Text);

                while (bin > 0)
                {
                    bi = bin % 2 + bi;
                    bin = bin / 2;
                }
                txtbina1.Text = bi;

                int bina = int.Parse(txt2.Text);
                while (bina > 0)
                {
                    binar = bina % 2 + binar;
                    bina = bina / 2;
                }

                txtbina2.Text = binar;
            }
            catch (Exception ex)
            {
                btnconvertir.Visible = true;
                btnlimpiar.Visible = false;

                if (txt1.Text == "")
                {
                    MessageBox.Show("Ingrese primer numero ", "*** ERRAR DE INGRESO DATOS ***");
                    txt1.Focus();
                    return;
                }
                if (txt2.Text == "")
                {
                    MessageBox.Show("Ingrese segundo numero ", "*** ERRAR DE INGRESO DATOS ***");
                    txt2.Focus();
                    return;
                }
                else
                {
                    MessageBox.Show("Revise Los datos que sean numeros enteros ", "*** Alvertencia ***");

                }

            }

        }
        public void btnsuma_Click(object sender, EventArgs e)
        {
            try
            {
                btnlimpiar.Visible = true;
                ClsBinario suma = new ClsBinario();
                txtresultado.Text = suma.Sumar(Convert.ToInt16(txt1.Text), Convert.ToInt16(txt2.Text)).ToString();

                string bi = "";
                int bin = int.Parse(txtresultado.Text);

                while (bin > 0)
                {
                    bi = bin % 2 + bi;
                    bin = bin / 2;
                }
                txtbinaresultado.Text = bi;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de ingreso de datos", "***Error de datos***");

                txt1.Focus();
            }
        }

        private void btnresta_Click(object sender, EventArgs e)
        {
            try
            {
                ClsBinario resta = new ClsBinario();
                txtresultado.Text = resta.Restar(Convert.ToInt16(txt1.Text), Convert.ToInt16(txt2.Text)).ToString();

                string bi = "";
                int bin = int.Parse(txtresultado.Text);

                while (bin > 0)
                {
                    bi = bin % 2 + bi;
                    bin = bin / 2;
                }
                txtbinaresultado.Text = bi;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de ingreso de datos", "***Error de datos***");
                txt1.Focus();
            }
        }

        private void btnmultiplicar_Click(object sender, EventArgs e)
        {
            try
            {
                ClsBinario multiplicacion = new ClsBinario();
                txtresultado.Text = multiplicacion.Multiplicar(Convert.ToInt16(txt1.Text), Convert.ToInt16(txt2.Text)).ToString();

                string bi = "";
                int bin = int.Parse(txtresultado.Text);

                while (bin > 0)
                {
                    bi = bin % 2 + bi;
                    bin = bin / 2;
                }
                txtbinaresultado.Text = bi;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de ingreso de datos", "***Error de datos***");
                txt1.Focus();
            }

        }

        private void btndividir_Click(object sender, EventArgs e)
        {
            try
            {
                ClsBinario dividir = new ClsBinario();
                txtresultado.Text = dividir.Dividir(Convert.ToInt16(txt1.Text), Convert.ToInt16(txt2.Text)).ToString();

                string bi = "";
                int bin = int.Parse(txtresultado.Text);

                while (bin > 0)
                {
                    bi = bin % 2 + bi;
                    bin = bin / 2;
                }
                txtbinaresultado.Text = bi;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de ingreso de datos", "***Error de datos***");
                txt1.Focus();
            }
        }
        /// <summary>
        /// //////
        /// </summary>
        /// <param name="Fabian Caicedo"></param>
        /// <param name="e"></param>
        public void txt1_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {

                if (!(char.IsNumber(e.KeyChar))&& !(e.KeyChar == Convert.ToChar(Keys.Enter)))
                {
                    MessageBox.Show  ("Ingrese solo numeros" , " *** ERRAR DE INGRESO DATOS ***");
                    e.Handled = true;
                    return;
                }
                else if (e.KeyChar == Convert.ToChar(Keys.Enter))
                {
                    string bi = "";
                    int bin = int.Parse(txt1.Text);
                    while (bin > 0)
                    {
                        bi = bin % 2 + bi;
                        bin = bin / 2;
                    }
                    txtbina1.Text = bi;
                    txt2.Focus();
                    btnlimpiar.Visible = true;

                }
            }
            catch (Exception ex)
            {
                if (txt1.Text == "")
                {
                    MessageBox.Show("Ingrese primer numero ");
                    txtbina1.Clear();
                    txtbinaresultado.Clear();
                    txtresultado.Clear();
                    txt1.Focus();
                }
                MessageBox.Show("Revise que sean numeros enteros", "*** Alvertencia ***");

            }

        }

        private void txt2_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!(char.IsNumber(e.KeyChar)) && !(e.KeyChar == Convert.ToChar(Keys.Enter)))
                {
                    MessageBox.Show("Ingrese solo numeros", "*** ERRAR DE INGRESO DATOS ***");
                    e.Handled = true;
                    return;
                }

                else if (e.KeyChar == Convert.ToChar(Keys.Enter))
                {
                    string binar = "";

                    int bina = int.Parse(txt2.Text);
                    while (bina > 0)
                    {
                        binar = bina % 2 + binar;
                        bina = bina / 2;
                    }

                    txtbina2.Text = binar;
                    btnlimpiar.Visible = true;
                    btnconvertir.Visible = false;
                }
            }
            catch (Exception ex)
            {
                if (txt2.Text == "")
                {
                    MessageBox.Show("Ingrese segundo numero ");
                    txtbina2.Clear();
                    txtbinaresultado.Clear();
                    txtresultado.Clear();
                    txt2.Focus();
                }
                MessageBox.Show("Revise que sean numeros enteros", "*** Alvertencia ***");

            }

        }
        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            btnlimpiar.Visible = false;
            btnconvertir.Visible = true;
            txt1.Clear();
            txt2.Clear();
            txtbinaresultado.Clear();
            txtresultado.Clear();
            txtbina1.Clear();
            txtbina2.Clear();
            txt1.Focus();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
