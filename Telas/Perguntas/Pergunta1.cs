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
    public partial class Pergunta1 : Form
    {
        Thread TelaPergunta2;
        Thread TelaHome;

        private Pessoa pessoa;

        public string zero = "Excelente";
        public string um = "Bom";
        public string dois = "Regular / Neutro";
        public string tres = "Ruim";
        public string quatro = "Péssimo";
        public Pergunta1(Pessoa pessoa)
        {
            InitializeComponent();
            this.pessoa = pessoa;
        }

        private void abrirTelaPergunta2(object obj)
        {
            Application.Run(new Pergunta2(pessoa));
        }

        private void abrirTelaHome(object obj)
        {
            Application.Run(new Home());
        }
        private void btnExcelentePergunta1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Confirma a resposta?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                pessoa.RespostaPergunta1 = zero.ToString();
                this.Close();
                TelaPergunta2 = new Thread(abrirTelaPergunta2);
                TelaPergunta2.SetApartmentState(ApartmentState.STA);
                TelaPergunta2.Start(pessoa);
            }
        }
        private void btnBomPergunta1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Confirma a resposta?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                pessoa.RespostaPergunta1 = um.ToString();
                this.Close();
                TelaPergunta2 = new Thread(abrirTelaPergunta2);
                TelaPergunta2.SetApartmentState(ApartmentState.STA);
                TelaPergunta2.Start(pessoa);
            }
        }
        private void btnRegularPergunta1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Confirma a resposta?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                pessoa.RespostaPergunta1 = dois.ToString();
                this.Close();
                TelaPergunta2 = new Thread(abrirTelaPergunta2);
                TelaPergunta2.SetApartmentState(ApartmentState.STA);
                TelaPergunta2.Start(pessoa);
            }
        }
        private void btnRuimPergunta1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Confirma a resposta?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                pessoa.RespostaPergunta1 = tres.ToString();
                this.Close();
                TelaPergunta2 = new Thread(abrirTelaPergunta2);
                TelaPergunta2.SetApartmentState(ApartmentState.STA);
                TelaPergunta2.Start(pessoa);
            }
        }
        private void btnPessimoPergunta1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Confirma a resposta?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                pessoa.RespostaPergunta1 = quatro.ToString();
                this.Close();
                TelaPergunta2 = new Thread(abrirTelaPergunta2);
                TelaPergunta2.SetApartmentState(ApartmentState.STA);
                TelaPergunta2.Start(pessoa);
            }
        }
        private void btnProximoPergunta1_Click(object sender, EventArgs e)
        {
            this.Close();
            TelaPergunta2 = new Thread(abrirTelaPergunta2);
            TelaPergunta2.SetApartmentState(ApartmentState.STA);
            TelaPergunta2.Start(pessoa);
        }

        private void btnHomePergunta1_Click(object sender, EventArgs e)
        {
            this.Close();
            TelaHome = new Thread(abrirTelaHome);
            TelaHome.SetApartmentState(ApartmentState.STA);
            TelaHome.Start(pessoa);
        }
    }
}
