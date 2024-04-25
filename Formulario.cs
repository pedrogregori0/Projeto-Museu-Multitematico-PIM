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
    public partial class Formulario : Form
    {
        Thread TelaPergunta1;
        Thread TelaTecladoNome;
        
        public Formulario()
        {
            InitializeComponent();

        }
        internal void AdicionarCaractere(string v)
        {
            throw new NotImplementedException();
        }
        internal void AdiconarCaractere(char caractere)
        {
            throw new NotImplementedException();
        }

        private void abrirTelaPergunta1(object obj)
        {
            Application.Run(new Pergunta1());
        }

        private void abrirTecladoNome(object obj)
        {
            Application.Run(new TecladoNome());
        }

        public void AdicionarCaractere(char caractere)
        {
            lblRespostaNome.Text += caractere;
        }

        private void btnFinalizarCadastro_Click(object sender, EventArgs e)
        {
            if (lblRespostaNome.Text.Length < 3 ||
                lblRespostaSobrenome.Text.Length < 3 ||
                cbxFaixaEtaria.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor preencha todos os campos corretamente para prosseguir!.");
            }
            else
            {
                this.Close();
                TelaPergunta1 = new Thread(abrirTelaPergunta1);
                TelaPergunta1.SetApartmentState(ApartmentState.STA);
                TelaPergunta1.Start();
            }

        }

        private void btnTecladoNome_Click(object sender, EventArgs e)
        {
            TelaTecladoNome = new Thread(abrirTecladoNome);
            TelaTecladoNome.SetApartmentState (ApartmentState.STA);
            TelaTecladoNome.Start();
        }

    }
}

