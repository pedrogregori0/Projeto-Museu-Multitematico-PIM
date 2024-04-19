namespace Projeto_Museu_Multitematico_PIM
{
    public partial class ListaDeAvaliacao : Form
    {
        Thread TelaHome;
        public ListaDeAvaliacao()
        {
            InitializeComponent();
        }

        private void btnHomeListaAvaliacao_Click(object sender, EventArgs e)
        {
            this.Close();
            TelaHome = new Thread(abrirTelaHome);
            TelaHome.SetApartmentState(ApartmentState.STA);
            TelaHome.Start();
        }
        private void abrirTelaHome(object obj)
        {
            Application.Run(new Home());
        }

    }
}
