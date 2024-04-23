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
    public partial class Pergunta2 : Form
    {
        Thread TelaPergunta3;
        Thread TelaHome;
        public Pergunta2()
        {
            InitializeComponent();
        }

        private void abrirTelaPergunta3(object obj)
        {
            Application.Run(new Pergunta3());
        }

        private void abrirTelaHome(object obj)
        {
            Application.Run(new Home());
        }
        private void btnExcelentePergunta2_Click(object sender, EventArgs e)
        {
            this.Close();
            TelaPergunta3 = new Thread(abrirTelaPergunta3);
            TelaPergunta3.SetApartmentState(ApartmentState.STA);
            TelaPergunta3.Start();
        }

        private void btnBomPergunta2_Click(object sender, EventArgs e)
        {
            this.Close();
            TelaPergunta3 = new Thread(abrirTelaPergunta3);
            TelaPergunta3.SetApartmentState(ApartmentState.STA);
            TelaPergunta3.Start();
        }

        private void btnRegularPergunta2_Click(object sender, EventArgs e)
        {
            this.Close();
            TelaPergunta3 = new Thread(abrirTelaPergunta3);
            TelaPergunta3.SetApartmentState(ApartmentState.STA);
            TelaPergunta3.Start();
        }

        private void btnRuimPergunta2_Click(object sender, EventArgs e)
        {
            this.Close();
            TelaPergunta3 = new Thread(abrirTelaPergunta3);
            TelaPergunta3.SetApartmentState(ApartmentState.STA);
            TelaPergunta3.Start();
        }

        private void btnPessimoPergunta2_Click(object sender, EventArgs e)
        {
            this.Close();
            TelaPergunta3 = new Thread(abrirTelaPergunta3);
            TelaPergunta3.SetApartmentState(ApartmentState.STA);
            TelaPergunta3.Start();
        }

        private void btnProximoPergunta2_Click(object sender, EventArgs e)
        {
            this.Close();
            TelaPergunta3 = new Thread(abrirTelaPergunta3);
            TelaPergunta3.SetApartmentState(ApartmentState.STA);
            TelaPergunta3.Start();
        }

        private void btnHomePergunta2_Click(object sender, EventArgs e)
        {
            this.Close();
            TelaHome = new Thread(abrirTelaHome);
            TelaHome.SetApartmentState (ApartmentState.STA);
            TelaHome.Start();
        }
    }
}
