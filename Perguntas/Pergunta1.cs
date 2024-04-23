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
    public partial class Pergunta1 : Form
    {
        Thread TelaPergunta2;
        Thread TelaHome;
        public Pergunta1()
        {
            InitializeComponent();
        }

        private void abrirTelaPergunta2(object obj)
        {
            Application.Run(new Pergunta2());
        }

        private void abrirTelaHome(object obj)
        {
            Application.Run(new Home());
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnExcelentePergunta1_Click(object sender, EventArgs e)
        {
            this.Close();
            TelaPergunta2 = new Thread(abrirTelaPergunta2);
            TelaPergunta2.SetApartmentState(ApartmentState.STA);
            TelaPergunta2.Start();
        }

        private void btnBomPergunta1_Click(object sender, EventArgs e)
        {
            this.Close();
            TelaPergunta2 = new Thread(abrirTelaPergunta2);
            TelaPergunta2.SetApartmentState(ApartmentState.STA);
            TelaPergunta2.Start();
        }

        private void btnRegularPergunta1_Click(object sender, EventArgs e)
        {
            this.Close();
            TelaPergunta2 = new Thread(abrirTelaPergunta2);
            TelaPergunta2.SetApartmentState(ApartmentState.STA);
            TelaPergunta2.Start();
        }

        private void btnRuimPergunta1_Click(object sender, EventArgs e)
        {
            this.Close();
            TelaPergunta2 = new Thread(abrirTelaPergunta2);
            TelaPergunta2.SetApartmentState(ApartmentState.STA);
            TelaPergunta2.Start();
        }

        private void btnPessimoPergunta1_Click(object sender, EventArgs e)
        {
            this.Close();
            TelaPergunta2 = new Thread(abrirTelaPergunta2);
            TelaPergunta2.SetApartmentState(ApartmentState.STA);
            TelaPergunta2.Start();
        }

        private void btnProximoPergunta1_Click(object sender, EventArgs e)
        {
            this.Close();
            TelaPergunta2 = new Thread(abrirTelaPergunta2);
            TelaPergunta2.SetApartmentState(ApartmentState.STA);
            TelaPergunta2.Start();
        }

        private void btnHomePergunta1_Click(object sender, EventArgs e)
        {
            this.Close();
            TelaHome =  new Thread(abrirTelaHome);
            TelaHome.SetApartmentState(ApartmentState.STA);
            TelaHome.Start();
        }
    }
}
