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
    public partial class FrmCalculos : Form
    {
        public FrmCalculos()
        {
            InitializeComponent(); 
        }        
        

        public void btnSumar_Click(object sender, EventArgs e)
        {
            try
            {
                    ClsCalculos  suma = new ClsCalculos ();
                    txtresultado.Text= suma.Sumar(Convert.ToDouble(txt1.Text), Convert.ToDouble(txt2.Text)).ToString();
            }
            catch (Exception ex )
            {
                if (txt1.Text == "")
                {
                    MessageBox.Show("Ingrese primer numero ");
                    txt1.Focus();
                    return ;
                }
                if (txt2.Text == "")
                {
                    MessageBox.Show("Ingrese segundo numero ");
                    txt2.Focus();
                    return;
                }
                else
                {
                    MessageBox.Show("Ingrese valores correctos ", "*** Error en el Ingreso de datos ***");
                    txtresultado.Clear();
                    txt1.Focus();
                }
                //FrmCalculos con = new FrmCalculos();
                //con.condicion();
                //this.condicion();
                                                              
            }
        }

        private void btnrestar_Click(object sender, EventArgs e)
        {
            try
            {
                ClsCalculos resta = new ClsCalculos();
                txtresultado.Text = resta.Restar (Convert.ToDouble(txt1.Text), Convert.ToDouble(txt2.Text)).ToString();
            }
            catch (Exception ex)
            {
                if (txt1.Text == "")
                {
                    MessageBox.Show("Ingrese primer numero ");
                    txt1.Focus();
                    return;
                }
                if (txt2.Text == "")
                {
                    MessageBox.Show("Ingrese segundo numero ");
                    txt2.Focus();
                }
                else
                {
                    MessageBox.Show("Ingrese valores correctos ", "*** Error en el Ingreso de datos ***");
                    txtresultado.Clear();
                    txt1.Focus();
                }

            }
        }

        private void btnmultiplicar_Click(object sender, EventArgs e)
        {
            try
            {
                ClsCalculos multiplicacion = new ClsCalculos();
                txtresultado.Text = multiplicacion.Multiplicar(Convert.ToDouble(txt1.Text), Convert.ToDouble(txt2.Text)).ToString();
            }
            catch (Exception ex)
            {
                if (txt1.Text == "")
                {
                    MessageBox.Show("Ingrese primer numero ");
                    txt1.Focus();
                    return;
                }
                if (txt2.Text == "")
                {
                    MessageBox.Show("Ingrese segundo numero ");
                    txt2.Focus();
                }
                else
                {
                    MessageBox.Show("Ingrese valores correctos ", "*** Error en el Ingreso de datos ***");
                    txtresultado.Clear();
                    txt1.Focus();  

                }
            }
        }

        private void btndividir_Click(object sender, EventArgs e)
        {
            try
            {
                ClsCalculos dividir = new ClsCalculos();
                txtresultado.Text = dividir.Dividir(Convert.ToDouble(txt1.Text), Convert.ToDouble(txt2.Text)).ToString();
            }
            catch (Exception ex)
            {
                if (txt1.Text == "")
                {
                    MessageBox.Show("Ingrese primer numero ");
                    txt1.Focus();
                    return; 
                }
                if (txt2.Text == "")
                {
                    MessageBox.Show("Ingrese segundo numero ");
                    txt2.Focus();
                }
                else
                {
                    MessageBox.Show("Ingrese valores correctos ", "*** Error en el Ingreso de datos ***");
                    txtresultado.Clear();
                    txt1.Focus();  
                }
            }
        }

        private void btnencerrar_Click(object sender, EventArgs e)
        {
            txt1.Clear();
            txt2.Clear();
            txtresultado.Clear();
            txt1.Focus();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

       
    }
}

