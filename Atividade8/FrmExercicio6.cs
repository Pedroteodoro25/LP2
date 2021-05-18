using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using System.Windows.Forms;

namespace PAtividade8
{
    public partial class FrmExercicio6 : Form
    {
        public FrmExercicio6()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int[] quantidade = new int[3];
            double[] valor = new double[3];
            double total = 0;

            for (int i = 0; i < quantidade.Length; i++)
            {
                var leitura = Interaction.InputBox("Quantidade vendida do item { i + 1} ", "Recebendo Informaçao ");

                if (!int.TryParse(leitura, out quantidade[i]))
                {
                    MessageBox.Show("Valor Invalido");

                    i--;
                    continue;

                }






                leitura = Interaction.InputBox("Quantidade vendida do item { i + 1} ", "Recebendo Informaçao ");

                if (!double.TryParse(leitura, out valor[i]))
                {
                    MessageBox.Show("Valor Invalido");
                    i--;
                    continue;
                }
                total = total + (quantidade[i] * valor[i]);
            }
            MessageBox.Show("Faturando Total = R$ " + total);
        }
    }
            } 
        