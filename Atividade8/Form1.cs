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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] vetor = new int[20];

            string auxiliar = "";

            for (int i = 0; i < vetor.Length; i++)
            {
                auxiliar = Interaction.InputBox("Entrar com o dado da posiçao",
                                "Entrada de Dados");

                if (!int.TryParse(auxiliar, out vetor[i]))
                {
                    Close();

                    MessageBox.Show("Valor Invalido");
                    i--;
                }
            }
                auxiliar = "";

            
            

                for (int i=vetor.Length-1; i>0; i--)
            {
                
                auxiliar += vetor[i] + "\n";
            }
            char[] arr = auxiliar.ToCharArray();
            Array.Reverse(arr);



            MessageBox.Show(auxiliar);
            }
        }
    }

