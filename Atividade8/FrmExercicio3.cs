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
    public partial class FrmExercicio3 : Form
    {
        public FrmExercicio3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Váriaveis
            int[] QtdMercadoria = new int[10];
            int[] PrecoMercadoria = new int[10];

            //Inputbox e for
            string inputbox = "";
            int contador;
            int contador2;

            //Saidas
            int saidaQtdMercadoria = 0;
            int saidaPreco = 0;

            // ------------> QUANTIDADE <------------

            for (contador = 0; contador < QtdMercadoria.Length; contador++)
            {
                inputbox = Interaction.InputBox("Entre com a quantidade vendida da " +
                (contador + 1).ToString() + "º " + " mercadoria: ",
                "Faturamento Mensal");

                if (inputbox == "")
                {
                    break;
                }

                if (int.TryParse(inputbox, out QtdMercadoria[contador]))
                {
                    saidaQtdMercadoria += QtdMercadoria[contador];
                }
                else
                {
                    MessageBox.Show("Número inválido");
                    contador--;
                }
            }
        }
    }
}
