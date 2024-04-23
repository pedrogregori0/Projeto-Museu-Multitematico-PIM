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
    public partial class Obra4 : Form
    {
        Thread TelaHome;
        Thread TelaObra3;
        Thread TelaListaPerguntas;
        public Obra4()
        {
            InitializeComponent();
        }

        private void abrirTelaHome(object obj)
        {
            Application.Run(new Home());
        }

        private void abrirTelaObra3(object obj)
        {
            Application.Run(new Obra3());
        }
        private void abrirTelaListaPerguntas(object obj)
        {
            Application.Run(new ListaDeAvaliacao());
        }


        private void btnHomeObra4_Click(object sender, EventArgs e)
        {
            this.Close();
            TelaHome = new Thread(abrirTelaHome);
            TelaHome.SetApartmentState(ApartmentState.STA);
            TelaHome.Start();
        }

        private void btnVoltarObra4_Click(object sender, EventArgs e)
        {
            this.Close();
            TelaObra3 = new Thread(abrirTelaObra3);
            TelaObra3.SetApartmentState(ApartmentState.STA);
            TelaObra3.Start();
        }

        private void btnProximoObra4_Click(object sender, EventArgs e)
        {
            this.Close();
            TelaListaPerguntas = new Thread(abrirTelaListaPerguntas);
            TelaListaPerguntas.SetApartmentState(ApartmentState.STA);
            TelaListaPerguntas.Start();
        }

        private void btnListaAvaliacaoObra4_Click(object sender, EventArgs e)
        {
            this.Close();
            TelaListaPerguntas = new Thread(abrirTelaListaPerguntas);
            TelaListaPerguntas.SetApartmentState(ApartmentState.STA);
            TelaListaPerguntas.Start();
        }
    }
}
