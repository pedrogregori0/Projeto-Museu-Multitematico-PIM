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
    public partial class Pergunta4 : Form
    {
        Thread TelaHome;
        Thread TelaPergunta5;

        private Pessoa pessoa;
        
        public string zero = "Excelente";
        public string um = "Bom";
        public string dois = "Regular / Neutro";
        public string tres = "Ruim";
        public string quatro = "Péssimo";
        public Pergunta4(Pessoa pessoa)
        {
            InitializeComponent();
            this.pessoa = pessoa;
        }
        private void abrirTelaHome(object obj)
        {
            Application.Run(new Home());
        }
        private void abrirTelaPergunta5(object obj)
        {
            Application.Run(new Pergunta5(pessoa));
        }
        private void btnExcelentePergunta4_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Confirma a resposta?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                pessoa.RespostaPergunta4 = zero.ToString();
                this.Close();
                TelaPergunta5 = new Thread(abrirTelaPergunta5);
                TelaPergunta5.SetApartmentState(ApartmentState.STA);
                TelaPergunta5.Start(pessoa);
            }
        }
        private void btnBomPergunta4_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Confirma a resposta?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                pessoa.RespostaPergunta4 = um.ToString();
                this.Close();
                TelaPergunta5 = new Thread(abrirTelaPergunta5);
                TelaPergunta5.SetApartmentState(ApartmentState.STA);
                TelaPergunta5.Start(pessoa);
            }
        }
        private void btnRegularPergunta4_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Confirma a resposta?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                pessoa.RespostaPergunta4 = dois.ToString();
                this.Close();
                TelaPergunta5 = new Thread(abrirTelaPergunta5);
                TelaPergunta5.SetApartmentState(ApartmentState.STA);
                TelaPergunta5.Start(pessoa);
            }
        }
        private void btnRuimPergunta4_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Confirma a resposta?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                pessoa.RespostaPergunta4 = tres.ToString();
                this.Close();
                TelaPergunta5 = new Thread(abrirTelaPergunta5);
                TelaPergunta5.SetApartmentState(ApartmentState.STA);
                TelaPergunta5.Start(pessoa);
            }
        }
        private void btnPessimoPergunta4_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Confirma a resposta?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                pessoa.RespostaPergunta4 = quatro.ToString();
                this.Close();
                TelaPergunta5 = new Thread(abrirTelaPergunta5);
                TelaPergunta5.SetApartmentState(ApartmentState.STA);
                TelaPergunta5.Start(pessoa);
            }
        }
        private void btnProximoPergunta4_Click(object sender, EventArgs e)
        {
            this.Close();
            TelaPergunta5 = new Thread(abrirTelaPergunta5);
            TelaPergunta5.SetApartmentState(ApartmentState.STA);
            TelaPergunta5.Start(pessoa);
        }

        private void btnHomePergunta4_Click(object sender, EventArgs e)
        {
            this.Close();
            TelaHome = new Thread(abrirTelaHome);
            TelaHome.SetApartmentState (ApartmentState.STA);
            TelaHome.Start(pessoa);
        }
    }
}
