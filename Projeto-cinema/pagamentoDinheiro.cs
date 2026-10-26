using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_cinema
{
    public partial class pagamentoDinheiro : Form
    {
        public pagamentoDinheiro()
        {
            InitializeComponent();
        }

        private void Aguarde_Click(object sender, EventArgs e)
        {
            concluido pagamentoConcluido = new concluido();
            pagamentoConcluido.ShowDialog();
        }
    }
}
