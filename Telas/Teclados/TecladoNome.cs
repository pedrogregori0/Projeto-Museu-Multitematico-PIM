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
    public partial class TecladoNome : Form
    {
        private Formulario formulario;
        public TecladoNome(Formulario formulario)
        {
            InitializeComponent();
            this.formulario = formulario;
        }

        private void btnTecNomeNum1_Click(object sender, EventArgs e)
        {
            formulario.AdicionarCaractereNome("1");

        }

        private void btnTecNomeNum2_Click(object sender, EventArgs e)
        {
            formulario.AdicionarCaractereNome("2");
        }

        private void btnTecNomeNum3_Click(object sender, EventArgs e)
        {
            formulario.AdicionarCaractereNome("3");
        }

        private void btnTecNomeNum4_Click(object sender, EventArgs e)
        {
            formulario.AdicionarCaractereNome("4");
        }

        private void btnTecNomeNum5_Click(object sender, EventArgs e)
        {
            formulario.AdicionarCaractereNome("5");
        }

        private void btnTecNomeNum6_Click(object sender, EventArgs e)
        {
            formulario.AdicionarCaractereNome("6");
        }

        private void btnTecNomeNum7_Click(object sender, EventArgs e)
        {
            formulario.AdicionarCaractereNome("7");
        }

        private void btnTecNomeNum8_Click(object sender, EventArgs e)
        {
            formulario.AdicionarCaractereNome("8");
        }

        private void btnTecNomeNum9_Click(object sender, EventArgs e)
        {
            formulario.AdicionarCaractereNome("9");
        }

        private void btnTecNomeNum0_Click(object sender, EventArgs e)
        {
            formulario.AdicionarCaractereNome("0");
        }

        private void btnTecNomeQ_Click(object sender, EventArgs e)
        {
            formulario.AdicionarCaractereNome("Q");
        }

        private void btnTecNomeW_Click(object sender, EventArgs e)
        {
            formulario.AdicionarCaractereNome("W");
        }

        private void btnTecNomeE_Click(object sender, EventArgs e)
        {
            formulario.AdicionarCaractereNome("E");
        }

        private void btnTecNomeR_Click(object sender, EventArgs e)
        {
            formulario.AdicionarCaractereNome("R");
        }

        private void btnTecNomeT_Click(object sender, EventArgs e)
        {
            formulario.AdicionarCaractereNome("T");
        }

        private void btnTecNomeY_Click(object sender, EventArgs e)
        {
            formulario.AdicionarCaractereNome("Y");
        }

        private void btnTecNomeU_Click(object sender, EventArgs e)
        {
            formulario.AdicionarCaractereNome("U");
        }

        private void btnTecNomeI_Click(object sender, EventArgs e)
        {
            formulario.AdicionarCaractereNome("I");
        }

        private void btnTecNomeO_Click(object sender, EventArgs e)
        {
            formulario.AdicionarCaractereNome("O");
        }

        private void btnTecNomeP_Click(object sender, EventArgs e)
        {
            formulario.AdicionarCaractereNome("P");
        }

        private void btnTecNomeA_Click(object sender, EventArgs e)
        {
            formulario.AdicionarCaractereNome("A");
        }

        private void btnTecNomeS_Click(object sender, EventArgs e)
        {
            formulario.AdicionarCaractereNome("S");
        }

        private void btnTecNomeD_Click(object sender, EventArgs e)
        {
            formulario.AdicionarCaractereNome("D");
        }

        private void btnTecNomeF_Click(object sender, EventArgs e)
        {
            formulario.AdicionarCaractereNome("F");
        }

        private void btnTecNomeG_Click(object sender, EventArgs e)
        {
            formulario.AdicionarCaractereNome("G");
        }

        private void btnTecNomeH_Click(object sender, EventArgs e)
        {
            formulario.AdicionarCaractereNome("H");
        }

        private void btnTecNomeJ_Click(object sender, EventArgs e)
        {
            formulario.AdicionarCaractereNome("J");
        }

        private void btnTecNomeK_Click(object sender, EventArgs e)
        {
            formulario.AdicionarCaractereNome("K");
        }

        private void btnTecNomeL_Click(object sender, EventArgs e)
        {
            formulario.AdicionarCaractereNome("L");
        }

        private void btnTecNomeCedilha_Click(object sender, EventArgs e)
        {
            formulario.AdicionarCaractereNome("Ç");
        }

        private void btnTecNomeZ_Click(object sender, EventArgs e)
        {
            formulario.AdicionarCaractereNome("Z");
        }

        private void btnTecNomeX_Click(object sender, EventArgs e)
        {
            formulario.AdicionarCaractereNome("X");
        }

        private void btnTecNomeC_Click(object sender, EventArgs e)
        {
            formulario.AdicionarCaractereNome("C");
        }

        private void btnTecNomeV_Click(object sender, EventArgs e)
        {
            formulario.AdicionarCaractereNome("V");
        }

        private void btnTecNomeB_Click(object sender, EventArgs e)
        {
            formulario.AdicionarCaractereNome("B");
        }

        private void btnTecNomeN_Click(object sender, EventArgs e)
        {
            formulario.AdicionarCaractereNome("N");
        }

        private void btnTecNomeM_Click(object sender, EventArgs e)
        {
            formulario.AdicionarCaractereNome("M");
        }

        private void btnTecNomeVirgula_Click(object sender, EventArgs e)
        {
            formulario.AdicionarCaractereNome(",");
        }

        private void btnTecNomePontoFinal_Click(object sender, EventArgs e)
        {
            formulario.AdicionarCaractereNome(".");
        }

        private void btnTecNomeDelete_Click(object sender, EventArgs e)
        {
            formulario.ExcluirCaractereNome();
        }

        private void btnTecNomeEnter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTecNomeEspaco_Click(object sender, EventArgs e)
        {
            formulario.AdicionarCaractereNome(" ");
        }

        private void TecladoNome_Load(object sender, EventArgs e)
        {

        }
    }
}
