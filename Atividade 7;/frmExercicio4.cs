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
    public partial class frmExercicio4 : Form
    {
        public frmExercicio4()
        {
            InitializeComponent();
        }

        private void btnPalindromo_Click(object sender, EventArgs e)
        {
            string texto = txtPalavra.Text;

            texto = texto.Replace(" ", "");

            texto = texto.ToUpper();

            string textoInvertido = new string(texto.Reverse().ToArray());

            if (texto == textoInvertido)
            {
                MessageBox.Show("É um palindromo");
            }
            else
                MessageBox.Show("Nao é palindromo");
        }
    }
}
