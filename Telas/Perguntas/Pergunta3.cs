using Projeto_Museu_Multitematico_PIM.Telas;
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

        private Pessoa pessoa;

        public string zero = "Com Certeza";
        public string um = "Sim";
        public string dois = "Talvez";
        public string tres = "Não";
        public string quatro = "Definitivamente não";
        public Pergunta3(Pessoa pessoa)
        {
            InitializeComponent();
            this.pessoa = pessoa;
        }

        private void abrirTelaHome(object obj)
        {
            Application.Run(new Home());
        }

        private void abrirTelaPergunta4(object obj)
        {
            Application.Run(new Pergunta4(pessoa));
        }
        private void btnComCertezaPergunta3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Confirma a resposta?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                pessoa.RespostaPergunta3 = zero.ToString();

                this.Close();
                TelaPergunta4 = new Thread(abrirTelaPergunta4);
                TelaPergunta4.SetApartmentState(ApartmentState.STA);
                TelaPergunta4.Start(pessoa);
            }
        }
        private void btnSimPergunta3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Confirma a resposta?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                pessoa.RespostaPergunta3 = um.ToString();
                this.Close();
                TelaPergunta4 = new Thread(abrirTelaPergunta4);
                TelaPergunta4.SetApartmentState(ApartmentState.STA);
                TelaPergunta4.Start(pessoa);
            }
        }
        private void btnTalvezPergunta3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Confirma a resposta?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                pessoa.RespostaPergunta3 = dois.ToString();
                this.Close();
                TelaPergunta4 = new Thread(abrirTelaPergunta4);
                TelaPergunta4.SetApartmentState(ApartmentState.STA);
                TelaPergunta4.Start(pessoa);
            }
        }
        private void btnNaoPergunta3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Confirma a resposta?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                pessoa.RespostaPergunta3 = tres.ToString();
                this.Close();
                TelaPergunta4 = new Thread(abrirTelaPergunta4);
                TelaPergunta4.SetApartmentState(ApartmentState.STA);
                TelaPergunta4.Start(pessoa);
            }
        }
        private void btnDefinitivamenteNaoPergunta3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Confirma a resposta?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                pessoa.RespostaPergunta3 = quatro.ToString();
                this.Close();
                TelaPergunta4 = new Thread(abrirTelaPergunta4);
                TelaPergunta4.SetApartmentState(ApartmentState.STA);
                TelaPergunta4.Start(pessoa);
            }
        }
        private void btnProximoPergunta3_Click(object sender, EventArgs e)
        {
            this.Close();
            TelaPergunta4 = new Thread(abrirTelaPergunta4);
            TelaPergunta4.SetApartmentState(ApartmentState.STA);
            TelaPergunta4.Start(pessoa);
        }
        private void btnHomePergunta3_Click(object sender, EventArgs e)
        {
            this.Close();
            TelaHome = new Thread(abrirTelaHome);
            TelaHome.SetApartmentState(ApartmentState.STA);
            TelaHome.Start(pessoa);
        }
    }
}
