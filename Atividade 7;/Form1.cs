using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PAtividade7
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void exercicio2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fc = Application.OpenForms["frmExercicio2"];

            if (fc != null)
                fc.Close();
            
            frmExercicio2 objFrm2 = new frmExercicio2();
            objFrm2.MdiParent = this;// objeto que esta no ativo no momento no caso é o 
            //frmPrincipal
            objFrm2.WindowState = FormWindowState.Maximized;


            objFrm2.Show();
        }

        private void exercicio3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmExercicio3 objFrm3 = new frmExercicio3();
            objFrm3.MdiParent = this;// objeto que esta no ativo no momento no caso é o 
            //frmPrincipal
            objFrm3.WindowState = FormWindowState.Maximized;
            objFrm3.Show();
        }

        private void exercicio4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmExercicio4 objFrm4 = new frmExercicio4();
            objFrm4.MdiParent = this;// objeto que esta no ativo no momento no caso é o 
            //frmPrincipal
            objFrm4.WindowState = FormWindowState.Maximized;
            objFrm4.Show();


        }

        private void exercicio5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmExercicio5 objFrm5 = new frmExercicio5();
            objFrm5.MdiParent = this;// objeto que esta no ativo no momento no caso é o 
            //frmPrincipal
            objFrm5.WindowState = FormWindowState.Maximized;
            objFrm5.Show();

        }
    }
}
