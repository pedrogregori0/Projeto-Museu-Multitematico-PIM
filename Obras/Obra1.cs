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
    public partial class Obra1 : Form
    {
        Thread TelaHome;
        Thread TelaObra2;
        Thread TelaListaPerguntas;
        public Obra1()
        {
            InitializeComponent();
        }

        private void abrirTelaHome(object obj)
        {
            Application.Run(new Home());
        }

        private void abrirTelaObra2(object obj)
        {
            Application.Run(new Obra2());
        }

        private void abrirTelaListaPerguntas(object obj)
        {
            Application.Run(new ListaDeAvaliacao());
        }

        private void btnProximoObra1_Click(object sender, EventArgs e)
        {
            this.Close();
            TelaObra2 = new Thread(abrirTelaObra2);
            TelaObra2.SetApartmentState(ApartmentState.STA);
            TelaObra2.Start();
        }

        private void btnVoltarObra1_Click(object sender, EventArgs e)
        {
            this.Close();
            TelaHome = new Thread(abrirTelaHome);
            TelaHome.SetApartmentState(ApartmentState.STA);
            TelaHome.Start();
        }

        private void btnHomeObra1_Click(object sender, EventArgs e)
        {
            this.Close();
            TelaHome = new Thread(abrirTelaHome);
            TelaHome.SetApartmentState(ApartmentState.STA);
            TelaHome.Start();
        }

        private void btnListaAvaliacaoObra1_Click(object sender, EventArgs e)
        {
            this.Close();
            TelaListaPerguntas = new Thread(abrirTelaListaPerguntas);
            TelaListaPerguntas.SetApartmentState (ApartmentState.STA);
            TelaListaPerguntas .Start();
        }
    }
}
