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
    public partial class Teclado : Form
    {
        private Formulario formulario;
        public Teclado(Formulario form)
        {
            InitializeComponent();
            formulario = form;
        }
        private void AdicionarCaractere(char caractere)
        {
            formulario.AdiconarCaractere(caractere);
        }

        private void btnNum1_Click(object sender, EventArgs e)
        {
            formulario.AdicionarCaractere("1");
        }


        private void btnNum2_Click(object sender, EventArgs e)
        {
            formulario.AdicionarCaractere("2");
        }

        private void btnNum3_Click(object sender, EventArgs e)
        {
            formulario.AdicionarCaractere("3");
        }

        private void btnNum4_Click(object sender, EventArgs e)
        {
            formulario.AdicionarCaractere("4");
        }

        private void btnNum5_Click(object sender, EventArgs e)
        {
            formulario.AdicionarCaractere("5");
        }

        private void btnNum6_Click(object sender, EventArgs e)
        {
            formulario.AdicionarCaractere("6");
        }

        private void btnNum7_Click(object sender, EventArgs e)
        {
            formulario.AdicionarCaractere("7");
        }

        private void btnNum8_Click(object sender, EventArgs e)
        {
            formulario.AdicionarCaractere("8");
        }

        private void btnNum9_Click(object sender, EventArgs e)
        {
            formulario.AdicionarCaractere("9");
        }

        private void btnNum0_Click(object sender, EventArgs e)
        {
            formulario.AdicionarCaractere("0");
        }

        private void btnQ_Click(object sender, EventArgs e)
        {
            formulario.AdicionarCaractere("Q");
        }

        private void btnW_Click(object sender, EventArgs e)
        {
            formulario.AdicionarCaractere("W");
        }

        private void btnE_Click(object sender, EventArgs e)
        {
            formulario.AdicionarCaractere("E");
        }

        private void btnR_Click(object sender, EventArgs e)
        {
            formulario.AdicionarCaractere("R");
        }

        private void btnT_Click(object sender, EventArgs e)
        {
            formulario.AdicionarCaractere("T");
        }

        private void btnY_Click(object sender, EventArgs e)
        {
            formulario.AdicionarCaractere("Y");
        }

        private void btnU_Click(object sender, EventArgs e)
        {
            formulario.AdicionarCaractere("U");
        }

        private void btnI_Click(object sender, EventArgs e)
        {
            formulario.AdicionarCaractere("I");
        }

        private void btnO_Click(object sender, EventArgs e)
        {
            formulario.AdicionarCaractere("O");
        }

        private void btnP_Click(object sender, EventArgs e)
        {
            formulario.AdicionarCaractere("P");
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            formulario.AdicionarCaractere("A");
        }

        private void btnS_Click(object sender, EventArgs e)
        {
            formulario.AdicionarCaractere("S");
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            formulario.AdicionarCaractere("D");
        }

        private void btnF_Click(object sender, EventArgs e)
        {
            formulario.AdicionarCaractere("F");
        }

        private void btnG_Click(object sender, EventArgs e)
        {
            formulario.AdicionarCaractere("G");
        }

        private void btnH_Click(object sender, EventArgs e)
        {
            formulario.AdicionarCaractere("H");
        }

        private void btnJ_Click(object sender, EventArgs e)
        {
            formulario.AdicionarCaractere("J");
        }

        private void btnK_Click(object sender, EventArgs e)
        {
            formulario.AdicionarCaractere("K");
        }

        private void btnL7_Click(object sender, EventArgs e)
        {
            formulario.AdicionarCaractere("L");
        }

        private void btnCedilha_Click(object sender, EventArgs e)
        {
            formulario.AdicionarCaractere("Ç");
        }

        private void btnZ_Click(object sender, EventArgs e)
        {
            formulario.AdicionarCaractere("Z");
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            formulario.AdicionarCaractere("X");
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            formulario.AdicionarCaractere("C");
        }

        private void btnV_Click(object sender, EventArgs e)
        {
            formulario.AdicionarCaractere("V");
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            formulario.AdicionarCaractere("B");
        }

        private void btnN_Click(object sender, EventArgs e)
        {
            formulario.AdicionarCaractere("N");
        }

        private void btnM_Click(object sender, EventArgs e)
        {
            formulario.AdicionarCaractere("M");
        }

        private void btnVirgula_Click(object sender, EventArgs e)
        {
            formulario.AdicionarCaractere(",");
        }

        private void btnPontoFinal_Click(object sender, EventArgs e)
        {
            formulario.AdicionarCaractere(".");
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnEspaco_Click(object sender, EventArgs e)
        {
            formulario.AdicionarCaractere(" ");
        }
    }
}
