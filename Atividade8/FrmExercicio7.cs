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
    public partial class FrmExercicio7 : Form
    {
        public FrmExercicio7()
        {
            InitializeComponent();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            string[] nomes = new  string[5];
            int[] letras = new int[nomes.Length];

            for(int  i = 0 ; i < nomes.Length; i++ )
            {
                var leitura = Interaction.InputBox(  " Digite o # { i + 1 } nome ", " Leitura de Nomes ");

                if (string.IsNullOrEmpty(leitura))
                {
                    MessageBox.Show(" Nome inválido ");
                    i -- ;
                    continue;
                }

                nomes[i] = leitura;
                quantidade int = 0;
                
               

                 

                foreach (letra char in nomes[i])  
                {
                    if (letra != ' ')
                        quantidade++ ;
                }

                letras[i] = quantidade;
            }
            for(int  i = 0 ; i < nomes.Lenght; i++ )
            {
                listnomes.Itens.Add  (" O nome { nomes [ i ]} possui { letras [ i ]} caracteres \ n ")
        }
    }
}
