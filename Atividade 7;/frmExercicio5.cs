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
    public partial class frmExercicio5 : Form
    {
        public frmExercicio5()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtProduçao.Text, out int produçao)&&
                double.TryParse(txtSalario.Text, out double salario)&&
                double.TryParse(txtGratificaçao.Text, out double gratificaçao))
            {
                int B = 0, C = 0, D = 0;

                if (produçao >= 100)
                    B = 1;
                if (produçao >= 120)
                     C = 1;
                if (produçao >= 150)
                    D = 1;

                double salariobruto = salario + salario * (0.05 * B + 0.1 * C + 0.1 * D) + gratificaçao;

                if(salariobruto > 7000 && (D==0 || gratificaçao == 0))
                {
                    salariobruto = 7000;
                }
                txtSalarioBruto.Text = salariobruto.ToString("N2");


            }
            else
            {
                MessageBox.Show("Atençao, preencher todos os campos necessarios");
            } 

        }
    }
}
