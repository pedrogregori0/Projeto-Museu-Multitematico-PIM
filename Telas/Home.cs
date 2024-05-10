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
        Thread TelaObra1;
        Thread TelaObra2;
        Thread TelaObra3;
        Thread TelaObra4;
        public Home()
        {
            InitializeComponent();
        }
        private void abrirTelaObra1(object obj)
        {
            Application.Run(new Obra1());
        }
        private void abrirTelaObra2(object obj)
        {
            Application.Run(new Obra2());
        }
        private void abrirTelaObra3(object obj)
        {
            Application.Run(new Obra3());
        }
        private void abrirTelaObra4(object obj)
        {
            Application.Run(new Obra4());
        }
        private void abrirTelaAvaliacao(object obj)
        {
            Application.Run(new ListaDeAvaliacao());
        }
        private void btnListaAvaliacaoPergunta1_Click(object sender, EventArgs e)
        {
            this.Close();
            TelaListaAvaliacao = new Thread(abrirTelaAvaliacao);
            TelaListaAvaliacao.SetApartmentState(ApartmentState.STA);
            TelaListaAvaliacao.Start();
        }
        private void btnObra1_Click(object sender, EventArgs e)
        {
            this.Close();
            TelaObra1 = new Thread(abrirTelaObra1);
            TelaObra1.SetApartmentState(ApartmentState.STA);
            TelaObra1.Start();
        }
        private void btnObra2_Click(object sender, EventArgs e)
        {
            this.Close();
            TelaObra2 = new Thread(abrirTelaObra2);
            TelaObra2.SetApartmentState(ApartmentState.STA);
            TelaObra2.Start();
        }
        private void btnObra3_Click(object sender, EventArgs e)
        {
            this.Close();
            TelaObra3 = new Thread(abrirTelaObra3);
            TelaObra3.SetApartmentState(ApartmentState.STA);
            TelaObra3.Start();
        }
        private void btnObra4_Click(object sender, EventArgs e)
        {
            this.Close();
            TelaObra4 = new Thread(abrirTelaObra4);
            TelaObra4.SetApartmentState(ApartmentState.STA);
            TelaObra4.Start();
        }
        private void btnProximoPergunta1_Click(object sender, EventArgs e)
        {
            this.Close();
            TelaObra1 = new Thread(abrirTelaObra1);
            TelaObra1.SetApartmentState(ApartmentState.STA);
            TelaObra1.Start();
        }
    }
}
