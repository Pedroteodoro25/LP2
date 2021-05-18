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
    public partial class FrmExercicio5 : Form
    {
        public FrmExercicio5()
        {
            InitializeComponent();
        }

        private void btnListaNome_Click(object sender, EventArgs e)
        {
             List<string>Nomes = new List<string>()
            {
                "Ana", "Andre", "Debora", "Fatima", "Joao", "Janete","Otavio","Marcelo","Pedro","Thais"
            };
            Nomes.Remove("Otavio");

            string saida = " ";

            foreach (string nome in Name)
            {
                saida += Nomes + "\n";
            }
            MessageBox.Show(saida);
        }
    }
}
