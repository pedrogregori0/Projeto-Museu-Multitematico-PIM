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
using Microsoft.VisualBasic.ApplicationServices;

namespace Projeto_Museu_Multitematico_PIM
{
    public partial class Pergunta5 : Form
    {
        Thread TelaHome;
        Thread TelaRelatorio;

        private Pessoa pessoa;
        private TotalVisitantes totalVisitantes = new TotalVisitantes();
        private Controle controle = new Controle();
        public Pergunta5(Pessoa pessoa)
        {
            InitializeComponent();
            this.pessoa = pessoa;
            this.controle = controle;
        }
        private void abrirTecladoPergunta5(object obj)
        {
            Application.Run();
        }

        private void abrirTelaHome(object obj)
        {
            Application.Run(new Home());
        }

        private void abrirTelaRelatorio(object obj)
        {
            Application.Run(new Relatorio(pessoa, controle, totalVisitantes));
        }
        public void AdicionarCaracterePergunta5(string caractere)
        {
            txbRespostaPergunta5.Text += caractere[0];
        }

        public void ExcluirUltimoCaracterePergunta5()
        {
            if (txbRespostaPergunta5.Text.Length > 0)
            {
                txbRespostaPergunta5.Text = txbRespostaPergunta5.Text.Substring(0, txbRespostaPergunta5.Text.Length - 1);
            }
        }
        private void btnHomePergunta5_Click(object sender, EventArgs e)
        {
            this.Close();
            TelaHome = new Thread(abrirTelaHome);
            TelaHome.SetApartmentState(ApartmentState.STA);
            TelaHome.Start(pessoa);
        }
        private void btnProximoPergunta5_Click(object sender, EventArgs e)
        {
            if (txbRespostaPergunta5.Text.Length < 4 || txbRespostaPergunta5.TextLength > 80)
            {
                MessageBox.Show("Digite a resposta para concluir as avaliações.");
            }
            else
            {
                DialogResult result = MessageBox.Show("Confirma a resposta?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                CarregarDadosTotalVisitantes(totalVisitantes);

                controle.AssociarRespostaPergunta1(pessoa, totalVisitantes);
                controle.AssociarRespostaPergunta2(pessoa, totalVisitantes);
                controle.AssociarRespostaPergunta3(pessoa, totalVisitantes);
                controle.AssociarRespostaPergunta4(pessoa, totalVisitantes);

                totalVisitantes.TotalDeVisitantes += 1;
                
                SalvarDadosTotalVisitantes(totalVisitantes);

                controle.ExecutarMediaPerguntas(totalVisitantes);

                if (result == DialogResult.Yes)
                {
                    pessoa.RespostaPergunta5 = txbRespostaPergunta5.Text;
                    this.Close();
                    TelaRelatorio = new Thread(abrirTelaRelatorio);
                    TelaRelatorio.SetApartmentState(ApartmentState.STA);
                    TelaRelatorio.Start(pessoa);
                }
            }
        }
        private void SalvarDadosTotalVisitantes(TotalVisitantes totalVisitantes)
        {
            try
            {
                string caminhoArquivo = @"C:\Users\pedro\OneDrive\Área de Trabalho\backup Media\DadosClasseTotalVisitantes.txt";

                if (!File.Exists(caminhoArquivo))
                {
                    using (StreamWriter criarArquivo = File.CreateText(caminhoArquivo))
                    {

                    }
                }
                using (StreamWriter escrever = new StreamWriter(caminhoArquivo))
                {
                    escrever.WriteLine($"TotalDeVisitantes = {totalVisitantes.TotalDeVisitantes},");

                    escrever.WriteLine($"TotalResExcelenteP1 = {totalVisitantes.TotalResExcelenteP1},");
                    escrever.WriteLine($"TotalResBomP1 = {totalVisitantes.TotalResBomP1}");
                    escrever.WriteLine($"TotalResRegularP1 = {totalVisitantes.TotalResRegularP1},");
                    escrever.WriteLine($"TotalResRuimP1 = {totalVisitantes.TotalResRuimP1},");
                    escrever.WriteLine($"TotalResPessimoP1 = {totalVisitantes.TotalResPessimoP1},");

                    escrever.WriteLine($"TotalResExcelenteP2 = {totalVisitantes.TotalResExcelenteP2},");
                    escrever.WriteLine($"TotalResBomP2 = {totalVisitantes.TotalResBomP2},");
                    escrever.WriteLine($"TotalResRegularP2 = {totalVisitantes.TotalResRegularP2},");
                    escrever.WriteLine($"TotalResRuimP2 = {totalVisitantes.TotalResRuimP2},");
                    escrever.WriteLine($"TotalResPessimoP2 = {totalVisitantes.TotalResPessimoP2},");

                    escrever.WriteLine($"TotalResComCertezaP3 = {totalVisitantes.TotalResComCertezaP3},");
                    escrever.WriteLine($"TotalResSimP3 = {totalVisitantes.TotalResSimP3},");
                    escrever.WriteLine($"TotalResTalvezP3 = {totalVisitantes.TotalResTalvezP3},");
                    escrever.WriteLine($"TotalResNaoP3 = {totalVisitantes.TotalResNaoP3},");
                    escrever.WriteLine($"TotalResDefinitivamenteNaoP3 = {totalVisitantes.TotalResDefinitivamenteNaoP3},");

                    escrever.WriteLine($"TotalResExcelenteP4 = {totalVisitantes.TotalResExcelenteP4},");
                    escrever.WriteLine($"TotalResBomP4 = {totalVisitantes.TotalResBomP4},");
                    escrever.WriteLine($"TotalResRegularP4 = {totalVisitantes.TotalResRegularP4},");
                    escrever.WriteLine($"TotalResRuimP4 = {totalVisitantes.TotalResRuimP4},");
                    escrever.WriteLine($"TotalResPessimoP4 = {totalVisitantes.TotalResPessimoP4},");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao salvar os dados");
            }
        }
        private void CarregarDadosTotalVisitantes(TotalVisitantes totalVisitantes)
        {
            try 
            {
               string caminhoArquivo = @"C:\Users\pedro\OneDrive\Área de Trabalho\backup Media\DadosClasseTotalVisitantes.txt";

        if (File.Exists(caminhoArquivo))
        {
            string conteudoArquivo = File.ReadAllText(caminhoArquivo);
            using (StringReader ler = new StringReader(conteudoArquivo))
            {
                string linha;
                while ((linha = ler.ReadLine())!= null)
                {
                    string[] partes = linha.Split(",");
                    foreach (string parte in partes)
                    {
                        string[] dados = parte.Split("=");
                        if (dados.Length == 2) 
                        {
                            string descricao = dados[0].Trim();
                            int valor;
                            if (int.TryParse(dados[1], out valor))
                            {
                                controle.AtualizarTotalVisitantes(totalVisitantes, descricao, valor);
                            }
                        }
                    }
                }
            }
        }
            }
            catch 
            {
                MessageBox.Show("Erro ao carregar os dados");
            }
        }
        private void btnTecladoPegunta5_Click(object sender, EventArgs e)
        {
            TecladoPergunta5 tecladoPergunta5 = new TecladoPergunta5(this);
            tecladoPergunta5.Show();
        }
    }
}
