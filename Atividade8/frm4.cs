using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PAtividade8
{
    public partial class frm4 : Form
    {
        public frm4()
        {
            InitializeComponent();
        }

        private void btnQtdeLetras_Click(object sender, EventArgs e)
        {
            string[] alunos = 
            { "Viviane",
             "Andre",
             " Helio",
             "Denise",
             "Junior",
             "Leonardo",
             "Jose",
             "Nelma",
             "Tobby"
            
            };

            Int32 I, Total = 0;
            Int32 N = alunos.Length;

            for( I = 0; I < N - 1; I++)
            {
                Total += alunos[I].Length;
            }
            MessageBox.Show(" A resposta é = " + Total);




    }
    }
}
