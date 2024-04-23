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
    public partial class Pergunta4 : Form
    {
        Thread TelaHome;
        Thread TelaPergunta5;
        public Pergunta4()
        {
            InitializeComponent();
        }

        private void abrirTelaHome(object obj)
        {
            Application.Run(new Home());
        }

        private void abrirTelaPergunta5(object obj)
        {
            Application.Run(new Pergunta5());
        }
        private void btnExcelentePergunta4_Click(object sender, EventArgs e)
        {
            this.Close();
            TelaPergunta5 = new Thread(abrirTelaPergunta5);
            TelaPergunta5.SetApartmentState(ApartmentState.STA);
            TelaPergunta5.Start();
        }

        private void btnBomPergunta4_Click(object sender, EventArgs e)
        {
            this.Close();
            TelaPergunta5 = new Thread(abrirTelaPergunta5);
            TelaPergunta5.SetApartmentState(ApartmentState.STA);
            TelaPergunta5.Start();
        }

        private void btnRegularPergunta4_Click(object sender, EventArgs e)
        {
            this.Close();
            TelaPergunta5 = new Thread(abrirTelaPergunta5);
            TelaPergunta5.SetApartmentState(ApartmentState.STA);
            TelaPergunta5.Start();
        }

        private void btnRuimPergunta4_Click(object sender, EventArgs e)
        {
            this.Close();
            TelaPergunta5 = new Thread(abrirTelaPergunta5);
            TelaPergunta5.SetApartmentState(ApartmentState.STA);
            TelaPergunta5.Start();
        }

        private void btnPessimoPergunta4_Click(object sender, EventArgs e)
        {
            this.Close();
            TelaPergunta5 = new Thread(abrirTelaPergunta5);
            TelaPergunta5.SetApartmentState(ApartmentState.STA);
            TelaPergunta5.Start();
        }

        private void btnProximoPergunta4_Click(object sender, EventArgs e)
        {
            this.Close();
            TelaPergunta5 = new Thread(abrirTelaPergunta5);
            TelaPergunta5.SetApartmentState(ApartmentState.STA);
            TelaPergunta5.Start();
        }

        private void btnHomePergunta4_Click(object sender, EventArgs e)
        {
            this.Close();
            TelaHome = new Thread(abrirTelaHome);
            TelaHome.SetApartmentState (ApartmentState.STA);
            TelaHome.Start();
        }
    }
}
