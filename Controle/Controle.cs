using Projeto_Museu_Multitematico_PIM.Telas;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;


namespace Projeto_Museu_Multitematico_PIM
{
    public class Controle
    {
        private Pessoa pessoa;
        private TotalVisitantes totalVisitantes;

        private string zero = "Excelente";
        private string um = "Bom";
        private string dois = "Regular / Neutro";
        private string tres = "Ruim";

        private string zeroP3 = "Com Certeza";
        private string umP3 = "Sim";
        private string doisP3 = "Talvez";
        private string tresP3 = "Não";

        public double MediaExcelenteP1;
        public double MediaBomP1;
        public double MediaRegularP1;
        public double MediaRuimP1;
        public double MediaPessimoP1;

        public double MediaExcelenteP2;
        public double MediaBomP2;
        public double MediaRegularP2;
        public double MediaRuimP2;
        public double MediaPessimoP2;

        public double MediaComCertezaP3;
        public double MediaSimP3;
        public double MediaTalvezP3;
        public double MediaNaoP3;
        public double MediaDefinitivamenteNaoP3;

        public double MediaExcelenteP4;
        public double MediaBomP4;
        public double MediaRegularP4;
        public double MediaRuimP4;
        public double MediaPessimoP4;
     
        public Controle()
        {
            this.pessoa = pessoa;
            this.totalVisitantes = totalVisitantes;   
        }
        public void AssociarRespostaPergunta1(Pessoa pessoa, TotalVisitantes totalVisitantes)
        {
            if (pessoa.RespostaPergunta1.Equals(zero))
            {
                totalVisitantes.TotalResExcelenteP1++;
            }
            else if (pessoa.RespostaPergunta1.Equals(um))
            {
                totalVisitantes.TotalResBomP1++;
            }
            else if (pessoa.RespostaPergunta1.Equals(dois))
            {
                totalVisitantes.TotalResRegularP1++;
            }
            else if (pessoa.RespostaPergunta1.Equals(tres))
            {
                totalVisitantes.TotalResRuimP1++;
            }
            else
            {
                totalVisitantes.TotalResPessimoP1++;
            }
        }
        public void AssociarRespostaPergunta2(Pessoa pessoa, TotalVisitantes totalVisitantes)
        {
            if (pessoa.RespostaPergunta2.Equals(zero))
            {
                totalVisitantes.TotalResExcelenteP2++;
            }
            else if (pessoa.RespostaPergunta2.Equals(um))
            {
                totalVisitantes.TotalResBomP2++;
            }
            else if (pessoa.RespostaPergunta2.Equals(dois))
            {
                totalVisitantes.TotalResRegularP2++;
            }
            else if (pessoa.RespostaPergunta2.Equals(tres))
            {
                totalVisitantes.TotalResRuimP2++;
            }
            else
            {
                totalVisitantes.TotalResPessimoP2++;
            }

        }
        public void AssociarRespostaPergunta3(Pessoa pessoa, TotalVisitantes totalVisitantes)
        {
            if (pessoa.RespostaPergunta3.Equals(zeroP3))
            {
                totalVisitantes.TotalResComCertezaP3++;
            }
            else if (pessoa.RespostaPergunta3.Equals(umP3))
            {
                totalVisitantes.TotalResSimP3++;
            }
            else if (pessoa.RespostaPergunta3.Equals(doisP3))
            {
                totalVisitantes.TotalResTalvezP3++;
            }
            else if (pessoa.RespostaPergunta3.Equals(tresP3))
            {
                totalVisitantes.TotalResNaoP3++;
            }
            else
            {
                totalVisitantes.TotalResDefinitivamenteNaoP3++;
            }
        }
        public void AssociarRespostaPergunta4(Pessoa pessoa, TotalVisitantes totalVisitantes)
        {
            if (pessoa.RespostaPergunta4.Equals(zero))
            {
                totalVisitantes.TotalResExcelenteP4++;
            }
            else if (pessoa.RespostaPergunta4.Equals(um))
            {
                totalVisitantes.TotalResBomP4++;
            }
            else if (pessoa.RespostaPergunta4.Equals(dois))
            {
                totalVisitantes.TotalResRegularP4++;
            }
            else if (pessoa.RespostaPergunta4.Equals(tres))
            {
                totalVisitantes.TotalResRuimP4++;
            }
            else
            {
                totalVisitantes.TotalResPessimoP4++;
            }
        }

        public void ExecutarMediaPerguntas(TotalVisitantes totalVisitantes)
        {
            MediaExcelenteP1 = ((double)totalVisitantes.TotalResExcelenteP1 / totalVisitantes.TotalDeVisitantes) * 100;
            MediaBomP1 = ((double)totalVisitantes.TotalResBomP1 / totalVisitantes.TotalDeVisitantes) * 100;
            MediaRegularP1 = ((double)totalVisitantes.TotalResRegularP1 / totalVisitantes.TotalDeVisitantes) * 100;
            MediaRuimP1 = ((double)totalVisitantes.TotalResRuimP1 / totalVisitantes.TotalDeVisitantes) *100;
            MediaPessimoP1 = ((double)totalVisitantes.TotalResPessimoP1 / totalVisitantes.TotalDeVisitantes) *100;

            MediaExcelenteP2 = ((double)totalVisitantes.TotalResExcelenteP2 / totalVisitantes.TotalDeVisitantes) * 100;
            MediaBomP2 = ((double)totalVisitantes.TotalResBomP2 / totalVisitantes.TotalDeVisitantes) * 100;
            MediaRegularP2 = ((double)totalVisitantes.TotalResRegularP2 / totalVisitantes.TotalDeVisitantes) * 100;
            MediaRuimP2 = ((double)totalVisitantes.TotalResRuimP2 / totalVisitantes.TotalDeVisitantes) * 100;
            MediaPessimoP2 = ((double)totalVisitantes.TotalResPessimoP2 / totalVisitantes.TotalDeVisitantes) * 100;

            MediaComCertezaP3 = ((double)totalVisitantes.TotalResComCertezaP3 / totalVisitantes.TotalDeVisitantes) * 100;
            MediaSimP3 = ((double)totalVisitantes.TotalResSimP3 / totalVisitantes.TotalDeVisitantes) * 100;
            MediaTalvezP3 = ((double)totalVisitantes.TotalResTalvezP3 / totalVisitantes.TotalDeVisitantes) * 100;
            MediaNaoP3 = ((double)totalVisitantes.TotalResNaoP3 / totalVisitantes.TotalDeVisitantes) * 100;
            MediaDefinitivamenteNaoP3 = (totalVisitantes.TotalResDefinitivamenteNaoP3 / totalVisitantes.TotalDeVisitantes) * 100;

            MediaExcelenteP4 = ((double)totalVisitantes.TotalResExcelenteP4 / totalVisitantes.TotalDeVisitantes) * 100;
            MediaBomP4 = ((double)totalVisitantes.TotalResBomP4 / totalVisitantes.TotalDeVisitantes) * 100;
            MediaRegularP4 = ((double)totalVisitantes.TotalResRegularP4 / totalVisitantes.TotalDeVisitantes) * 100;
            MediaRuimP4 = ((double)totalVisitantes.TotalResRuimP4 / totalVisitantes.TotalDeVisitantes) * 100;
            MediaPessimoP4 = ((double)totalVisitantes.TotalResPessimoP4 / totalVisitantes.TotalDeVisitantes) * 100;
        }

        public void AtualizarTotalVisitantes(TotalVisitantes totalVisitantes, string descricao, int valor)
        {
            switch (descricao)
            {
                case "TotalDeVisitantes":
                    totalVisitantes.TotalDeVisitantes = valor;
                    break;
                case "TotalResExcelenteP1":
                    totalVisitantes.TotalResExcelenteP1 = valor;
                    break;
                case "TotalResBomP1":
                    totalVisitantes.TotalResBomP1 = valor;
                    break;
                case "TotalResRegularP1":
                    totalVisitantes.TotalResRegularP1 = valor;
                    break;
                case "TotalResRuimP1":
                    totalVisitantes.TotalResRuimP1 = valor;
                    break;
                case "TotalResPessimoP1":
                    totalVisitantes.TotalResPessimoP1 = valor;
                    break;
                case "TotalResExcelenteP2":
                    totalVisitantes.TotalResExcelenteP2 = valor;
                    break;
                case "TotalResBomP2":
                    totalVisitantes.TotalResBomP2 = valor;
                    break;
                case "TotalResRegularP2":
                    totalVisitantes.TotalResRegularP2 = valor;
                    break;
                case "TotalResRuimP2":
                    totalVisitantes.TotalResRuimP2 = valor;
                    break;
                case "TotalResPessimoP2":
                    totalVisitantes.TotalResPessimoP2 = valor;
                    break;
                case "TotalResComCertezaP3":
                    totalVisitantes.TotalResComCertezaP3 = valor;
                    break;
                case "TotalResSimP3":
                    totalVisitantes.TotalResSimP3 = valor;
                    break;
                case "TotalResTalvezP3":
                    totalVisitantes.TotalResTalvezP3 = valor;
                    break;
                case "TotalResNaoP3":
                    totalVisitantes.TotalResNaoP3 = valor;
                    break;
                case "TotalResDefinitivamenteNaoP3":
                    totalVisitantes.TotalResDefinitivamenteNaoP3 = valor;
                    break;
                case "TotalResExcelenteP4":
                    totalVisitantes.TotalResExcelenteP4 = valor;
                    break;
                case "TotalResBomP4":
                    totalVisitantes.TotalResBomP4 = valor;
                    break;
                case "TotalResRegularP4":
                    totalVisitantes.TotalResRegularP4 = valor;
                    break;
                case "TotalResRuimP4":
                    totalVisitantes.TotalResRuimP4 = valor;
                    break;
                case "TotalResPessimoP4":
                    totalVisitantes.TotalResPessimoP4 = valor;
                    break;
                default:
                    
                    break;
            }
        }
    }
}
