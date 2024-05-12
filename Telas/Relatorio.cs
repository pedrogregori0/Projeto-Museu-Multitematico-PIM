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
    public partial class Relatorio : Form
    {
        Thread TelaHome;
        
        private Pessoa pessoa;
        private TotalVisitantes totalVisitantes;
        private Controle controle;

        public Relatorio(Pessoa pessoa, Controle controle, TotalVisitantes totalVisitantes)
        {
            InitializeComponent();
            this.pessoa = pessoa;
            MostrarRelatorios(controle);
            MostrarPorcentagemMedia1(controle);
            MostrarPorcentagemMedia2(controle);
            MostrarPorcentagemMedia3(controle);
            MostrarPorcentagemMedia4(controle);

            lblTotalVisitantes.Text = $"Total de visitantes: {totalVisitantes.TotalDeVisitantes.ToString()}";
        }
        private void abrirTelaHome(object obj)
        {
            Application.Run(new Home());
        }
        private void MostrarRelatorios(Controle controle)
        {
            StringBuilder sbMostrarRelatorios = new StringBuilder();

            if (pessoa != null)
            {
                sbMostrarRelatorios.AppendLine($"Nome: {pessoa.Nome} {pessoa.Sobrenome}");
                sbMostrarRelatorios.AppendLine($"Faixa Etária: {pessoa.FaixaEtaria}");
                sbMostrarRelatorios.AppendLine($"Pergunta 1 - R: {pessoa.RespostaPergunta1}");
                sbMostrarRelatorios.AppendLine($"Pergunta 2 - R: {pessoa.RespostaPergunta2}");
                sbMostrarRelatorios.AppendLine($"Pergunta 3 - R: {pessoa.RespostaPergunta3}");
                sbMostrarRelatorios.AppendLine($"Pergunta 4 - R: {pessoa.RespostaPergunta4}");
                sbMostrarRelatorios.AppendLine($"Pergunta 5 - R: {pessoa.RespostaPergunta5}");

                sbMostrarRelatorios.AppendLine();

            }
            else
            {
                sbMostrarRelatorios.AppendLine("Nenhuma pessoa foi cadastrada");
            }

            lblRespotaRelatorio.Text = sbMostrarRelatorios.ToString();
        }
        private void MostrarPorcentagemMedia1(Controle controle)
        {
            StringBuilder sbMostrarMedia1 = new StringBuilder();

            sbMostrarMedia1.AppendLine($"{controle.MediaExcelenteP1:F2}%   selecionaram Excelente.");
            sbMostrarMedia1.AppendLine($"{controle.MediaBomP1:F2}%   selecionaram Bom.");
            sbMostrarMedia1.AppendLine($"{controle.MediaRegularP1:F2}%   selecionaram Regular / Neutro.");
            sbMostrarMedia1.AppendLine($"{controle.MediaRuimP1:F2}%   selecionaram Ruim.");
            sbMostrarMedia1.AppendLine($"{controle.MediaPessimoP1:F2}%   selecionaram Péssimo.");
            sbMostrarMedia1.AppendLine();

            lblMedia1.Text = sbMostrarMedia1.ToString();

        }

        private void MostrarPorcentagemMedia2(Controle controle)
        {
            StringBuilder sbMostrarMedia2 = new StringBuilder();

            sbMostrarMedia2.AppendLine($"{controle.MediaExcelenteP2:F2}%   selecionaram Excelente.");
            sbMostrarMedia2.AppendLine($"{controle.MediaBomP2:F2}%   selecionaram Bom.");
            sbMostrarMedia2.AppendLine($"{controle.MediaRegularP2:F2}%   selecionaram Regular / Neutro.");
            sbMostrarMedia2.AppendLine($"{controle.MediaRuimP2:F2}%   selecionaram Ruim.");
            sbMostrarMedia2.AppendLine($"{controle.MediaPessimoP2:F2}%   selecionaram Péssimo.");
            sbMostrarMedia2.AppendLine();

            lblMedia2.Text = sbMostrarMedia2.ToString();

        }

        private void MostrarPorcentagemMedia3(Controle controle)
        {
            StringBuilder sbMostrarMedia3 = new StringBuilder();

            sbMostrarMedia3.AppendLine($"{controle.MediaComCertezaP3:F2}%   selecionaram Com Certeza.");
            sbMostrarMedia3.AppendLine($"{controle.MediaSimP3:F2}%   selecionaram Sim.");
            sbMostrarMedia3.AppendLine($"{controle.MediaTalvezP3:F2}%   selecionaram Talvez.");
            sbMostrarMedia3.AppendLine($"{controle.MediaNaoP3:F2}%   selecionaram Não.");
            sbMostrarMedia3.AppendLine($"{controle.MediaDefinitivamenteNaoP3:F2}%   selecionaram Definitivamente Não.");
            sbMostrarMedia3.AppendLine();

            lblMedia3.Text = sbMostrarMedia3.ToString();
         
        }

        private void MostrarPorcentagemMedia4(Controle controle)
        {
            StringBuilder sbMostrarMedia4 = new StringBuilder();

            sbMostrarMedia4.AppendLine($"{controle.MediaExcelenteP4:F2}%   selecionaram Excelente.");
            sbMostrarMedia4.AppendLine($"{controle.MediaBomP4:F2}%   selecionaram Bom.");
            sbMostrarMedia4.AppendLine($"{controle.MediaRegularP4:F2}%   selecionaram Regular / Neutro.");
            sbMostrarMedia4.AppendLine($"{controle.MediaRuimP4:F2}%   selecionaram Ruim.");
            sbMostrarMedia4.AppendLine($"{controle.MediaPessimoP4:F2}%   selecionaram Péssimo.");
            sbMostrarMedia4.AppendLine();

            lblMedia4.Text = sbMostrarMedia4.ToString();

        }

        private void btnSairRelatorio_Click(object sender, EventArgs e)
        {
            this.Close();
            TelaHome = new Thread(abrirTelaHome);
            TelaHome.SetApartmentState(ApartmentState.STA);
            TelaHome.Start();
        }
    }
}
