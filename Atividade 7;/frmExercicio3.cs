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
    public partial class frmExercicio3 : Form
    {
        public frmExercicio3()
        {
            InitializeComponent();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            if(int.TryParse(txtNumeroN.Text, out int N))
            {
                if(N > 0)
                {
                    double H = 1;
                    while(N > 0)
                    {
                        H += 1.0 / N;

                        N--;
                    }
                    txtNumeroN.Text = H.ToString("N2");
                }
                else
                {
                    MessageBox.Show("O numero precisa ser maior que 0!");
                }
            }
            else
            {
                MessageBox.Show("Nao foi possivel realizar a conversao");
            }
        }
    }
}
