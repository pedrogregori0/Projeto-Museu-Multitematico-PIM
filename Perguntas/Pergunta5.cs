using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Museu_Multitematico_PIM
{
    public partial class Pergunta5 : Form
    {
        Thread TelaHome;
        public Pergunta5()
        {
            InitializeComponent();
        }

        private void abrirTelaHome(object obj)
        {
            Application.Run(new Home());
        }

        private void mostrarTecladoVirtual(TextBox textBox)
        {
 
        }

        private void btnHomePergunta5_Click(object sender, EventArgs e)
        {
            this.Close();
            TelaHome = new Thread(abrirTelaHome);
            TelaHome.SetApartmentState(ApartmentState.STA);
            TelaHome.Start();
        }

        private void btnProximoPergunta5_Click(object sender, EventArgs e)
        {
            if (txbPergunta5.Text.Length < 4)
            {
                MessageBox.Show("Digite a resposta para concluir as avaliações.");
            }
            else
            {
                this.Close();
                TelaHome = new Thread(abrirTelaHome);
                TelaHome.SetApartmentState(ApartmentState.STA);
                TelaHome.Start();
            }
        }

        private void txbPergunta5_TextChanged(object sender, EventArgs e)
        {

        }
        private void txbPergunta5_Click(object obj)
        {

        }

        private void btnListaAvaliacaoPergunta5_Click(object sender, EventArgs e)
        {

        }
    }
}
