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

namespace P0030482021028
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            
            double[,] vendas = new double[8, 4];
            double totalSemanas = 0, totalMeses = 0;
            int mes, semana;
            string ar;

            
            for (mes = 0; mes < vendas.GetLength(0); mes++)
            {
                
                for (semana = 0; semana < vendas.GetLength(1); semana++)
                {
                    
                    ar = Interaction.InputBox($"Semana #{semana + 1}", $"Mês #{mes + 1}");

                   
                    if (ar == string.Empty)
                        return;

                    
                    if (!double.TryParse(ar, out vendas[mes, semana]))
                    {
                        MessageBox.Show("Valor informado inválido!\nPor favor, apenas dados númericos.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        semana--;
                    }
                }
            }

            
            if (listVendas.Items.Count > 0) 
            {
                
                listVendas.Items.Add("----------------------------------------------------");
            }

            for (mes = 0; mes < vendas.GetLength(0); mes++)
            {
                totalSemanas = 0;

                for (semana = 0; semana < vendas.GetLength(1); semana++)
                {
                    listVendas.Items.Add($"Total do mês: {mes + 1} Semana: {semana + 1}: {vendas[mes, semana]:C2}");
                    totalSemanas += vendas[mes, semana];
                }

                listVendas.Items.Add($" Total Mês: {totalSemanas:C2}");
                totalMeses += totalSemanas;
                listVendas.Items.Add("-------------");
            }

            listVendas.Items.Add($" Total Geral: {totalMeses:C2}");
        }

        
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            listVendas.Items.Clear();
        }
    }
}
