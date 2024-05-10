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
    public partial class Pergunta2 : Form
    {
        Thread TelaPergunta3;
        Thread TelaHome;

        private Pessoa pessoa;

        public string zero = "Excelente";
        public string um = "Bom";
        public string dois = "Regular / Neutro";
        public string tres = "Ruim";
        public string quatro = "Péssimo";
        public Pergunta2(Pessoa pessoa)
        {
            InitializeComponent();
            this.pessoa = pessoa;
        }

        private void abrirTelaPergunta3(object obj)
        {
            Application.Run(new Pergunta3(pessoa));
        }

        private void abrirTelaHome(object obj)
        {
            Application.Run(new Home());
        }
        private void btnExcelentePergunta2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Confirma a resposta?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                pessoa.RespostaPergunta2 = zero.ToString();
                this.Close();
                TelaPergunta3 = new Thread(abrirTelaPergunta3);
                TelaPergunta3.SetApartmentState(ApartmentState.STA);
                TelaPergunta3.Start(pessoa);
            }
        }
        private void btnBomPergunta2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Confirma a resposta?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                pessoa.RespostaPergunta2 = um.ToString();
                this.Close();
                TelaPergunta3 = new Thread(abrirTelaPergunta3);
                TelaPergunta3.SetApartmentState(ApartmentState.STA);
                TelaPergunta3.Start(pessoa);
            }
        }
        private void btnRegularPergunta2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Confirma a resposta?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                pessoa.RespostaPergunta2 = dois.ToString();
                this.Close();
                TelaPergunta3 = new Thread(abrirTelaPergunta3);
                TelaPergunta3.SetApartmentState(ApartmentState.STA);
                TelaPergunta3.Start(pessoa);
            }
        }
        private void btnRuimPergunta2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Confirma a resposta?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                pessoa.RespostaPergunta2 = tres.ToString();
                this.Close();
                TelaPergunta3 = new Thread(abrirTelaPergunta3);
                TelaPergunta3.SetApartmentState(ApartmentState.STA);
                TelaPergunta3.Start(pessoa);
            }
        }
        private void btnPessimoPergunta2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Confirma a resposta?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                pessoa.RespostaPergunta2 = quatro.ToString();
                this.Close();
                TelaPergunta3 = new Thread(abrirTelaPergunta3);
                TelaPergunta3.SetApartmentState(ApartmentState.STA);
                TelaPergunta3.Start(pessoa);
            }
        }
        private void btnProximoPergunta2_Click(object sender, EventArgs e)
        {
            this.Close();
            TelaPergunta3 = new Thread(abrirTelaPergunta3);
            TelaPergunta3.SetApartmentState(ApartmentState.STA);
            TelaPergunta3.Start(pessoa);
        }

        private void btnHomePergunta2_Click(object sender, EventArgs e)
        {
            this.Close();
            TelaHome = new Thread(abrirTelaHome);
            TelaHome.SetApartmentState (ApartmentState.STA);
            TelaHome.Start(pessoa);
        }
    }
}
