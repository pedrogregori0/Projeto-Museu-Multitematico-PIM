using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using Projeto_Museu_Multitematico_PIM.Telas;

namespace Projeto_Museu_Multitematico_PIM
{
    public partial class Formulario : Form
    {
        Thread TelaPergunta1;
        Thread TelaTecladoNome;
        Thread TelaHome;

        private Pessoa pessoa;

        public Formulario(Pessoa pessoa)
        {
            InitializeComponent();
            this.pessoa = pessoa;
        }
        private void abrirTelaPergunta1(object obj)
        {
            Application.Run(new Pergunta1(pessoa));
        }
        private void abrirTelaHome(object obj)
        {
            Application.Run(new Home());
        }
        public void AdicionarCaractereNome(string caractere)
        {
            txbRespostaNome.Text += caractere[0];
        }
        public void AdicionarCaractereSobrenome(string caractere)
        {
            txbRespostaSobrenome.Text += caractere[0];
        }
        public void ExcluirCaractereNome()
        {
            if (txbRespostaNome.Text.Length > 0)
            {
                txbRespostaNome.Text = txbRespostaNome.Text.Substring(0, txbRespostaNome.Text.Length - 1);
            }
        }
        public void ExcluirCaractereSobrenome()
        {
            if (txbRespostaSobrenome.Text.Length > 0)
            {
                txbRespostaSobrenome.Text = txbRespostaSobrenome.Text.Substring(0, txbRespostaSobrenome.TextLength - 1);
            }
        }
        private void btnFinalizarCadastro_Click(object sender, EventArgs e)
        {
            if (txbRespostaNome.Text.Length < 3 ||
                txbRespostaNome.Text.Length > 50 ||
                txbRespostaSobrenome.Text.Length < 3 ||
                txbRespostaSobrenome.Text.Length > 50 ||
                cbxFaixaEtaria.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor preencha todos os campos corretamente para prosseguir!.");
            }
            else
            {
                DialogResult result = MessageBox.Show("Seus dados estão corretos?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    pessoa.Nome = txbRespostaNome.Text;
                    pessoa.Sobrenome = txbRespostaSobrenome.Text;
                    pessoa.FaixaEtaria = cbxFaixaEtaria.SelectedItem.ToString();

                    this.Close();
                    TelaPergunta1 = new Thread(abrirTelaPergunta1);
                    TelaPergunta1.SetApartmentState(ApartmentState.STA);
                    TelaPergunta1.Start(pessoa);
                }
            }
        }
        private void btnTecladoNome_Click(object sender, EventArgs e)
        {
            TecladoNome tecladonome = new TecladoNome(this);
            tecladonome.Show();
        }
        private void btnTecladoSobrenome_Click(object sender, EventArgs e)
        {
            TecladoSobrenome tecladosobrenome = new TecladoSobrenome(this);
            tecladosobrenome.Show();
        }
        internal void AdicionarCaractere(char caractere)
        {
            throw new NotImplementedException();
        }
        private void btnSairFormulario_Click(object sender, EventArgs e)
        {
            this.Close();
            TelaHome = new Thread(abrirTelaHome);
            TelaHome.SetApartmentState (ApartmentState.STA);
            TelaHome.Start();
        }
    }
}

