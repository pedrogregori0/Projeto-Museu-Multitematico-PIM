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
    public partial class TecladoSobrenome : Form
    {
        private Formulario formulario;
        public TecladoSobrenome(Formulario formulario)
        {
            InitializeComponent();
            this.formulario = formulario;
        }
        private void btnTecSobrenomeNum1_Click(object sender, EventArgs e)
        {
            formulario.AdicionarCaractereSobrenome("1");
        }

        private void btnTecSobrenomeNum2_Click(object sender, EventArgs e)
        {
            formulario.AdicionarCaractereSobrenome("2");
        }

        private void btnTecSobrenomeNum3_Click(object sender, EventArgs e)
        {
            formulario.AdicionarCaractereSobrenome("3");
        }

        private void btnTecSobrenomeNum4_Click(object sender, EventArgs e)
        {
            formulario.AdicionarCaractereSobrenome("4");
        }

        private void btnTecSobrenomeNum5_Click(object sender, EventArgs e)
        {
            formulario.AdicionarCaractereSobrenome("5");
        }

        private void btnTecSobrenomeNum6_Click(object sender, EventArgs e)
        {
            formulario.AdicionarCaractereSobrenome("6");
        }

        private void btnTecSobrenomeNum7_Click(object sender, EventArgs e)
        {
            formulario.AdicionarCaractereSobrenome("7");
        }

        private void btnTecSobrenomeNum8_Click(object sender, EventArgs e)
        {
            formulario.AdicionarCaractereSobrenome("8");
        }

        private void btnTecSobrenomeNum9_Click(object sender, EventArgs e)
        {
            formulario.AdicionarCaractereSobrenome("9");
        }

        private void btnTecSobrenomeNum0_Click(object sender, EventArgs e)
        {
            formulario.AdicionarCaractereSobrenome("0");
        }

        private void btnTecSobrenomeQ_Click(object sender, EventArgs e)
        {
            formulario.AdicionarCaractereSobrenome("Q");
        }

        private void btnTecSobrenomeW_Click(object sender, EventArgs e)
        {
            formulario.AdicionarCaractereSobrenome("W");
        }

        private void btnTecSobrenomeE_Click(object sender, EventArgs e)
        {
            formulario.AdicionarCaractereSobrenome("E");
        }

        private void btnTecSobrenomeR_Click(object sender, EventArgs e)
        {
            formulario.AdicionarCaractereSobrenome("R");
        }

        private void btnTecSobrenomeT_Click(object sender, EventArgs e)
        {
            formulario.AdicionarCaractereSobrenome("T");
        }

        private void btnTecSobrenomeY_Click(object sender, EventArgs e)
        {
            formulario.AdicionarCaractereSobrenome("Y");
        }

        private void btnTecSobrenomeU_Click(object sender, EventArgs e)
        {
            formulario.AdicionarCaractereSobrenome("U");
        }

        private void btnTecSobrenomeI_Click(object sender, EventArgs e)
        {
            formulario.AdicionarCaractereSobrenome("I");
        }

        private void btnTecSobrenomeO_Click(object sender, EventArgs e)
        {
            formulario.AdicionarCaractereSobrenome("O");
        }

        private void btnTecSobrenomeP_Click(object sender, EventArgs e)
        {
            formulario.AdicionarCaractereSobrenome("P");
        }

        private void btnTecSobrenomeA_Click(object sender, EventArgs e)
        {
            formulario.AdicionarCaractereSobrenome("A");
        }

        private void btnTecSobrenomeS_Click(object sender, EventArgs e)
        {
            formulario.AdicionarCaractereSobrenome("S");
        }

        private void btnTecSobrenomeD_Click(object sender, EventArgs e)
        {
            formulario.AdicionarCaractereSobrenome("D");
        }

        private void btnTecSobrenomeF_Click(object sender, EventArgs e)
        {
            formulario.AdicionarCaractereSobrenome("F");
        }

        private void btnTecSobrenomeG_Click(object sender, EventArgs e)
        {
            formulario.AdicionarCaractereSobrenome("G");
        }

        private void btnTecSobrenomeH_Click(object sender, EventArgs e)
        {
            formulario.AdicionarCaractereSobrenome("H");
        }

        private void btnTecSobrenomeJ_Click(object sender, EventArgs e)
        {
            formulario.AdicionarCaractereSobrenome("J");
        }

        private void btnTecSobrenomeK_Click(object sender, EventArgs e)
        {
            formulario.AdicionarCaractereSobrenome("K");
        }

        private void btnTecSobrenomeL_Click(object sender, EventArgs e)
        {
            formulario.AdicionarCaractereSobrenome("L");
        }

        private void btnTecSobrenomeCedilha_Click(object sender, EventArgs e)
        {
            formulario.AdicionarCaractereSobrenome("Ç");
        }

        private void btnTecSobrenomeZ_Click(object sender, EventArgs e)
        {
            formulario.AdicionarCaractereSobrenome("Z");
        }

        private void btnTecSobrenomeX_Click(object sender, EventArgs e)
        {
            formulario.AdicionarCaractereSobrenome("X");
        }

        private void btnTecSobrenomeC_Click(object sender, EventArgs e)
        {
            formulario.AdicionarCaractereSobrenome("C");
        }

        private void btnTecSobrenomeV_Click(object sender, EventArgs e)
        {
            formulario.AdicionarCaractereSobrenome("V");
        }

        private void btnTecSobrenomeB_Click(object sender, EventArgs e)
        {
            formulario.AdicionarCaractereSobrenome("B");
        }

        private void btnTecSobrenomeN_Click(object sender, EventArgs e)
        {
            formulario.AdicionarCaractereSobrenome("N");
        }

        private void btnTecSobrenomeM_Click(object sender, EventArgs e)
        {
            formulario.AdicionarCaractereSobrenome("M");
        }

        private void btnTecSobrenomeVirgula_Click(object sender, EventArgs e)
        {
            formulario.AdicionarCaractereSobrenome(",");
        }

        private void btnTecSobrenomePontoFinal_Click(object sender, EventArgs e)
        {
            formulario.AdicionarCaractereSobrenome(".");
        }

        private void btnTecSobrenomeDelete_Click(object sender, EventArgs e)
        {
            formulario.ExcluirCaractereSobrenome();
        }

        private void btnTecSobrenomeEnter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTecSobrenomeEspaco_Click(object sender, EventArgs e)
        {
            formulario.AdicionarCaractereSobrenome(" ");
        }
    }
}
