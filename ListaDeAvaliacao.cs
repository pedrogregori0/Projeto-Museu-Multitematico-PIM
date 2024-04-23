namespace Projeto_Museu_Multitematico_PIM
{
    public partial class ListaDeAvaliacao : Form
    {
        Thread TelaHome;
        Thread TelaFormulario;
        Thread TelaPergunta1;
        Thread TelaPergunta2;
        Thread TelaPergunta3;
        Thread TelaPergunta4;
        Thread TelaPergunta5;
        public ListaDeAvaliacao()
        {
            InitializeComponent();
        }
        private void abrirTelaHome(object obj)
        {
            Application.Run(new Home());
        }

        private void abrirTelaFormulario(object obj)
        {
            Application.Run(new Formulario());
        }
        private void abrirTelaPergunta1(object obj)
        {
            Application.Run(new Pergunta1());
        }

        private void abrirTelaPergunta2(object obj)
        {
            Application.Run(new Pergunta2());
        }

        private void abrirTelaPergunta3(object obj)
        {
            Application.Run(new Pergunta3());
        }

        private void abrirTelaPergunta4(object obj)
        {
            Application.Run(new Pergunta4());
        }

        private void abrirTelaPergunta5(object obj)
        {
            Application.Run(new Pergunta5());
        }
        private void btnHomeListaAvaliacao_Click(object sender, EventArgs e)
        {
            this.Close();
            TelaHome = new Thread(abrirTelaHome);
            TelaHome.SetApartmentState(ApartmentState.STA);
            TelaHome.Start();
        }

        private void btnPergunta1_Click(object sender, EventArgs e)
        {
            this.Close();
            TelaFormulario = new Thread(abrirTelaFormulario);
            TelaFormulario.SetApartmentState(ApartmentState.STA);
            TelaFormulario.Start();
        }

        private void btnPergunta2_Click(object sender, EventArgs e)
        {
            this.Close();
            TelaPergunta2 = new Thread(abrirTelaPergunta2);
            TelaPergunta2.SetApartmentState(ApartmentState.STA);
            TelaPergunta2.Start();
        }

        private void btnPergunta3_Click(object sender, EventArgs e)
        {
            this.Close();
            TelaPergunta3 = new Thread(abrirTelaPergunta3);
            TelaPergunta3.SetApartmentState(ApartmentState.STA);
            TelaPergunta3.Start();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            TelaPergunta4 = new Thread(abrirTelaPergunta4);
            TelaPergunta4.SetApartmentState(ApartmentState.STA);
            TelaPergunta4.Start();
        }

        private void btnPergunta5_Click(object sender, EventArgs e)
        {
            this.Close();
            TelaPergunta5 = new Thread(abrirTelaPergunta5);
            TelaPergunta5.SetApartmentState (ApartmentState.STA);
            TelaPergunta5.Start();
        }
    }
}
