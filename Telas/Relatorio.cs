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
            MostrarPorcentagemMedia1e2(controle);
            MostrarPorcentagemMedia3e4(controle);
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
        private void MostrarPorcentagemMedia1e2(Controle controle)
        {
            StringBuilder sbMostrarMedia1e2 = new StringBuilder();

            sbMostrarMedia1e2.AppendLine($"Respostas pergunta 1");
            sbMostrarMedia1e2.AppendLine();
            sbMostrarMedia1e2.AppendLine($"{controle.MediaExcelenteP1:F2}%   selecionaram Excelente.");
            sbMostrarMedia1e2.AppendLine($"{controle.MediaBomP1:F2}%   selecionaram Bom.");
            sbMostrarMedia1e2.AppendLine($"{controle.MediaRegularP1:F2}%   selecionaram Regular / Neutro.");
            sbMostrarMedia1e2.AppendLine($"{controle.MediaRuimP1:F2}%   selecionaram Ruim.");
            sbMostrarMedia1e2.AppendLine($"{controle.MediaPessimoP1:F2}%   selecionaram Péssimo.");
            sbMostrarMedia1e2.AppendLine();

            sbMostrarMedia1e2.AppendLine($"Respostas pergunta 2");
            sbMostrarMedia1e2.AppendLine();
            sbMostrarMedia1e2.AppendLine($"{controle.MediaExcelenteP2:F2}%   selecionaram Excelente.");
            sbMostrarMedia1e2.AppendLine($"{controle.MediaBomP2:F2}%   selecionaram Bom.");
            sbMostrarMedia1e2.AppendLine($"{controle.MediaRegularP2:F2}%   selecionaram Regular / Neutro.");
            sbMostrarMedia1e2.AppendLine($"{controle.MediaRuimP2:F2}%   selecionaram Ruim.");
            sbMostrarMedia1e2.AppendLine($"{controle.MediaPessimoP2:F2}%   selecionaram Péssimo.");
            sbMostrarMedia1e2.AppendLine();

            lblMedias1e2.Text = sbMostrarMedia1e2.ToString();

        }
        private void MostrarPorcentagemMedia3e4(Controle controle)
        {
            StringBuilder sbMostrarMedia3e4 = new StringBuilder();

            sbMostrarMedia3e4.AppendLine($"Respostas pergunta 3");
            sbMostrarMedia3e4.AppendLine();
            sbMostrarMedia3e4.AppendLine($"{controle.MediaComCertezaP3:F2}%   selecionaram Com Certeza.");
            sbMostrarMedia3e4.AppendLine($"{controle.MediaSimP3:F2}%   selecionaram Sim.");
            sbMostrarMedia3e4.AppendLine($"{controle.MediaTalvezP3:F2}%   selecionaram Talvez.");
            sbMostrarMedia3e4.AppendLine($"{controle.MediaNaoP3:F2}%   selecionaram Não.");
            sbMostrarMedia3e4.AppendLine($"{controle.MediaDefinitivamenteNaoP3:F2}%   selecionaram Definitivamente Não.");
            sbMostrarMedia3e4.AppendLine();

            sbMostrarMedia3e4.AppendLine($"Respostas pergunta 4");
            sbMostrarMedia3e4.AppendLine();
            sbMostrarMedia3e4.AppendLine($"{controle.MediaExcelenteP4:F2}%   selecionaram Excelente.");
            sbMostrarMedia3e4.AppendLine($"{controle.MediaBomP4:F2}%   selecionaram Bom.");
            sbMostrarMedia3e4.AppendLine($"{controle.MediaRegularP4:F2}%   selecionaram Regular / Neutro.");
            sbMostrarMedia3e4.AppendLine($"{controle.MediaRuimP4:F2}%   selecionaram Ruim.");
            sbMostrarMedia3e4.AppendLine($"{controle.MediaPessimoP4:F2}%   selecionaram Péssimo.");
            sbMostrarMedia3e4.AppendLine();

            lblMedias3e4.Text = sbMostrarMedia3e4.ToString();
         
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
