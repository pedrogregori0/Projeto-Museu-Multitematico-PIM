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
    public partial class Obra3 : Form
    {
        Thread TelaHome;
        Thread TelaObra2;
        Thread TelaObra4;
        Thread TelaListaPerguntas;
        public Obra3()
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

        private void abrirTelaObra4(object obj)
        {
            Application.Run(new Obra4());
        }

        private void abrirTelaListaPerguntas(object obj)
        {
            Application.Run(new ListaDeAvaliacao());
        }

        private void btnHomeObra3_Click(object sender, EventArgs e)
        {
            this.Close();
            TelaHome = new Thread(abrirTelaHome);
            TelaHome.SetApartmentState(ApartmentState.STA);
            TelaHome.Start();
        }

        private void btnVoltarObra3_Click(object sender, EventArgs e)
        {
            this.Close();
            TelaObra2 = new Thread(abrirTelaObra2);
            TelaObra2.SetApartmentState(ApartmentState.STA);
            TelaObra2.Start();
        }

        private void btnProximoObra3_Click(object sender, EventArgs e)
        {
            this.Close();
            TelaObra4 = new Thread(abrirTelaObra4);
            TelaObra4.SetApartmentState(ApartmentState.STA);
            TelaObra4.Start();
        }

        private void btnListaAvaliacaoObra3_Click(object sender, EventArgs e)
        {
            this.Close();
            TelaListaPerguntas = new Thread(abrirTelaListaPerguntas);
            TelaListaPerguntas.SetApartmentState(ApartmentState.STA);
            TelaListaPerguntas.Start();
        }
    }
}
