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
    public partial class frmExercicio2 : Form
    {
        public frmExercicio2()
        {
            InitializeComponent();
        }

        private void btnEspaçoBranco_Click(object sender, EventArgs e)
        {
            int Brancos = 0;

            foreach (char letra in rchTxtR.Text)
            {
                if(letra == ' ')
                {
                    Brancos++;
                }
            }
            MessageBox.Show(Brancos.ToString());
        }

        private void btnLetraR_Click(object sender, EventArgs e)
        {
            int R = 0;

            foreach(char letra in rchTxtR.Text)
            {
                if (char.ToUpper(letra) == 'R')
                {
                    R++;
                }
            }
            MessageBox.Show(R.ToString());
        }

        private void btnParLetras_Click(object sender, EventArgs e)
        {
            int Pares = 0;
            string texto = rchTxtR.Text;

            for(int letra=0; letra<texto.Length-1; letra++)
            {
                if(texto[letra] == texto[letra + 1])
                {
                    Pares++;
                }
            }
            MessageBox.Show(Pares.ToString());
        }
    }
}
