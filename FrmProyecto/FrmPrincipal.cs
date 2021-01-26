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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void mATEMATICASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCalculos mate = new FrmCalculos();
            mate.MdiParent = this;
            mate.Show();
        }

        private void bINARIASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frmbinario  binario = new Frmbinario ();
            binario.MdiParent = this;
            binario.Show();
        }

        private void fIBONACIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmFibonacci fibo = new FrmFibonacci () ;
            fibo.MdiParent = this;
            fibo.Show();  
            MessageBox.Show("Para que funcione el programa de la mejor manera, debe de ingresar el valor de la posicion en la caja de texto de color blanco, un valor menor de 80 " , " INSTRUCIONES " );  
        }

        
        private void sALIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void OPERACIONESToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
