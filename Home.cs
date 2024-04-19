using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Projeto_Museu_Multitematico_PIM
{
    public partial class Home : Form
    {
        Thread TelaListaAvaliacao;
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void btnListaAvaliacaoPergunta1_Click(object sender, EventArgs e)
        {
            this.Close();
            TelaListaAvaliacao = new Thread(abrirTelaAvaliacao);
            TelaListaAvaliacao.SetApartmentState(ApartmentState.STA);
            TelaListaAvaliacao.Start();
        }
        private void abrirTelaAvaliacao(object obj)
        {
            Application.Run(new ListaDeAvaliacao());
        }
    }
}
