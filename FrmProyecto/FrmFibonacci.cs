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
    public partial class FrmFibonacci : Form
    {
        public FrmFibonacci()
        {
            InitializeComponent();
        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {
                        
            try
            {
                
                if (Convert.ToInt32(txtcantidad.Text) <= 80) 
                {
                    ClsFibonacci fibo = new ClsFibonacci();
                    txtfibo.Text = fibo.serie(Convert.ToInt32(txtcantidad.Text));
  
                    btnlimpiar.Visible = true;
                    txtfibo.Visible = true;
                    btnaceptar.Visible = false;
                }    
                else
                {
                    MessageBox.Show("Ingrese una cantidad menor a 80", "AVISO");
                    txtcantidad.Clear();
                    txtcantidad.Focus(); 
                }
                    
            }
            catch (Exception ex)
            {
                if (txtcantidad.Text == "")
                {
                    MessageBox.Show("Por favor ingrese valor en la serie", "*** Aviso *** ");
                    btnaceptar.Visible = true ;
                    txtcantidad.Focus();
                    btnlimpiar.Visible = false;
                    txtfibo.Visible = false;
                }
                else
                {
                    
                    MessageBox.Show(" Ingreso solo de número no de letras en la serie", "***atentamente la banda***");
                    txtcantidad.Clear();
                    btnaceptar.Visible = true ;
                    txtfibo.Clear();
                    btnlimpiar.Visible = false;
                    txtcantidad.Focus();
                }
            }

        }
        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            btnlimpiar.Visible = false;
            txtcantidad.Clear();
            txtfibo.Clear();
            txtcantidad.Focus();
            txtfibo.Visible = false;
            btnaceptar.Visible = true ;
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtcantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {

                if (e.KeyChar == Convert.ToChar(Keys.Enter))
                {
                    if (Convert.ToInt32(txtcantidad.Text) <= 80)
                    {
                        ClsFibonacci fibo = new ClsFibonacci();
                        txtfibo.Text = fibo.serie(Convert.ToInt32(txtcantidad.Text));
                        btnlimpiar.Visible = true;
                        txtfibo.Visible = true;
                        btnaceptar.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("Ingrese una cantidad menor a 80 y precione enter", "AVISO");
                        txtcantidad.Clear();
                        txtcantidad.Focus();
                        txtfibo.Clear();
                        btnaceptar.Visible=true ;
                        btnlimpiar.Visible = false; 
                    }
                }
            }
            catch (Exception ex)
            {
                if (txtcantidad.Text == "")
                {
                    MessageBox.Show("Por favor ingrese valor en la serie", "*** Aviso *** ");
                    txtcantidad.Focus();
                    btnaceptar.Visible = true ;
                    btnlimpiar.Visible = false;
                    txtfibo.Visible = false;  
                     
                }
                else
                {
                    
                    MessageBox.Show(" Ingrese numero no letras", "***atentamente la banda***");
                    txtcantidad.Clear();
                    txtfibo.Clear();
                    btnaceptar.Visible = true ;
                    btnlimpiar.Visible = false;
                    txtcantidad.Focus();

                }
            }
        }

        private void FrmFibonacci_Load(object sender, EventArgs e)
        {

        }
    }
}
