using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FrmProyecto
{
    public partial class Frmlogin : Form
    {
        public Frmlogin()
        {
            InitializeComponent();
        }

        public void limpiar()
        {
            txtusuario.Clear();
            txtcontraseña.Clear();
            txtusuario.Focus();
        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {
            BdConexion.Conexion();
            

            SqlDataAdapter da = new SqlDataAdapter("SELECT COUNT(*) FROM Ingreso WHERE DataUser = '" + txtusuario.Text + "'  AND DataPassword = '" + txtcontraseña.Text + " ' ", BdConexion.Conexion());

            DataTable dt = new DataTable();
            da.Fill(dt);

            if(dt.Rows[0][0].ToString()=="1")
            {
                this.Hide();
                new FrmPrincipal().Show();
            }
            else
            {
                MessageBox.Show("Acceso no permitido");
                limpiar();
            }
        }
        private void Frmlogin_Load(object sender, EventArgs e)
        {
            BdConexion.Conexion();
            MessageBox.Show("Conexion Exitosa");
        }
    }
}
