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
    public partial class Pergunta3 : Form
    {
        Thread TelaPergunta4;
        Thread TelaHome;
        public Pergunta3()
        {
            InitializeComponent();
        }

        private void abrirTelaHome(object obj)
        {
            Application.Run(new Home());
        }

        private void abrirTelaPergunta4(object obj)
        {
            Application.Run(new Pergunta4());
        }
        private void btnComCertezaPergunta3_Click(object sender, EventArgs e)
        {
            this.Close();
            TelaPergunta4 = new Thread(abrirTelaPergunta4);
            TelaPergunta4.SetApartmentState(ApartmentState.STA);
            TelaPergunta4.Start();
        }

        private void btnSimPergunta3_Click(object sender, EventArgs e)
        {
            this.Close();
            TelaPergunta4 = new Thread(abrirTelaPergunta4);
            TelaPergunta4.SetApartmentState(ApartmentState.STA);
            TelaPergunta4.Start();
        }

        private void btnTalvezPergunta3_Click(object sender, EventArgs e)
        {
            this.Close();
            TelaPergunta4 = new Thread(abrirTelaPergunta4);
            TelaPergunta4.SetApartmentState(ApartmentState.STA);
            TelaPergunta4.Start();
        }

        private void btnNaoPergunta3_Click(object sender, EventArgs e)
        {
            this.Close();
            TelaPergunta4 = new Thread(abrirTelaPergunta4);
            TelaPergunta4.SetApartmentState(ApartmentState.STA);
            TelaPergunta4.Start();
        }

        private void btnDefinitivamenteNaoPergunta3_Click(object sender, EventArgs e)
        {
            this.Close();
            TelaPergunta4 = new Thread(abrirTelaPergunta4);
            TelaPergunta4.SetApartmentState(ApartmentState.STA);
            TelaPergunta4.Start();
        }

        private void btnProximoPergunta3_Click(object sender, EventArgs e)
        {
            this.Close();
            TelaPergunta4 = new Thread(abrirTelaPergunta4);
            TelaPergunta4.SetApartmentState(ApartmentState.STA);
            TelaPergunta4.Start();
        }

        private void btnHomePergunta3_Click(object sender, EventArgs e)
        {
            this.Close();
            TelaHome = new Thread(abrirTelaHome);
            TelaHome.SetApartmentState(ApartmentState.STA);
            TelaHome.Start();
        }
    }
}
