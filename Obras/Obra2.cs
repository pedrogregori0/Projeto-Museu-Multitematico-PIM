using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace Projeto_Museu_Multitematico_PIM
{
    public partial class Obra2 : Form
    {
        Thread TelaHome;
        Thread TelaObra1;
        Thread TelaObra3;
        Thread TelaListaPerguntas;
        public Obra2()
        {
            InitializeComponent();
        }

        private void abrirTelaHome(object obj)
        {
            Application.Run(new Home());
        }

        private void abrirTelaObra1(object obj)
        {
            Application.Run(new Obra1());
        }

        private void abrirTelaObra3(object obj)
        {
            Application.Run(new Obra3());
        }

        private void abrirTelaListaPerguntas(object obj)
        {
            Application.Run(new ListaDeAvaliacao());
        }

        private void btnHomeObra2_Click(object sender, EventArgs e)
        {
            this.Close();
            TelaHome = new Thread(abrirTelaHome);
            TelaHome.SetApartmentState(ApartmentState.STA);
            TelaHome.Start();
        }

        private void btnVoltarObra2_Click(object sender, EventArgs e)
        {
            this.Close();
            TelaObra1 = new Thread(abrirTelaObra1);
            TelaObra1.SetApartmentState(ApartmentState.STA);
            TelaObra1.Start();
        }

        private void btnProximoObra2_Click(object sender, EventArgs e)
        {
            this.Close();
            TelaObra3 = new Thread(abrirTelaObra3);
            TelaObra3.SetApartmentState(ApartmentState.STA);
            TelaObra3.Start();
        }

        private void btnListaAvaliacaoObra2_Click(object sender, EventArgs e)
        {
            this.Close();
            TelaListaPerguntas = new Thread(abrirTelaListaPerguntas);
            TelaListaPerguntas.SetApartmentState(ApartmentState.STA);
            TelaListaPerguntas.Start();
        }
    }
}
