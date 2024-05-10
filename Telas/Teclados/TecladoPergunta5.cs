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
    public partial class TecladoPergunta5 : Form
    {
        private Pergunta5 pergunta5;
        
        public TecladoPergunta5(Pergunta5 pergunta5)
        {
            InitializeComponent();
            this.pergunta5 = pergunta5;
        }
        private void btnTecPergunta5Num1_Click(object sender, EventArgs e)
        {
            pergunta5.AdicionarCaracterePergunta5("1");
        }

        private void btnTecPergunta5Num2_Click(object sender, EventArgs e)
        {
            pergunta5.AdicionarCaracterePergunta5("2");
        }

        private void btnTecPergunta5Num3_Click(object sender, EventArgs e)
        {
            pergunta5.AdicionarCaracterePergunta5("3");
        }

        private void btnTecPergunta5Num4_Click(object sender, EventArgs e)
        {
            pergunta5.AdicionarCaracterePergunta5("4");
        }

        private void btnTecPergunta5Num5_Click(object sender, EventArgs e)
        {
            pergunta5.AdicionarCaracterePergunta5("5");
        }

        private void btnTecPergunta5Num6_Click(object sender, EventArgs e)
        {
            pergunta5.AdicionarCaracterePergunta5("6");
        }

        private void btnTecPergunta5Num7_Click(object sender, EventArgs e)
        {
            pergunta5.AdicionarCaracterePergunta5("7");
        }

        private void btnTecPergunta5Num8_Click(object sender, EventArgs e)
        {
            pergunta5.AdicionarCaracterePergunta5("8");
        }

        private void btnTecPergunta5Num9_Click(object sender, EventArgs e)
        {
            pergunta5.AdicionarCaracterePergunta5("9");
        }

        private void btnTecPergunta5Num0_Click(object sender, EventArgs e)
        {
            pergunta5.AdicionarCaracterePergunta5("0");
        }

        private void btnTecPergunta5Q_Click(object sender, EventArgs e)
        {
            pergunta5.AdicionarCaracterePergunta5("Q");
        }

        private void btnTecPergunta5W_Click(object sender, EventArgs e)
        {
            pergunta5.AdicionarCaracterePergunta5("W");
        }

        private void btnTecPergunta5E_Click(object sender, EventArgs e)
        {
            pergunta5.AdicionarCaracterePergunta5("E");
        }

        private void btnTecPergunta5R_Click(object sender, EventArgs e)
        {
            pergunta5.AdicionarCaracterePergunta5("R");
        }

        private void btnTecPergunta5T_Click(object sender, EventArgs e)
        {
            pergunta5.AdicionarCaracterePergunta5("T");
        }

        private void btnTecPergunta5Y_Click(object sender, EventArgs e)
        {
            pergunta5.AdicionarCaracterePergunta5("Y");
        }

        private void btnTecPergunta5U_Click(object sender, EventArgs e)
        {
            pergunta5.AdicionarCaracterePergunta5("U");
        }

        private void btnTecPergunta5I_Click(object sender, EventArgs e)
        {
            pergunta5.AdicionarCaracterePergunta5("I");
        }

        private void btnTecPergunta5O_Click(object sender, EventArgs e)
        {
            pergunta5.AdicionarCaracterePergunta5("O");
        }

        private void btnTecPergunta5P_Click(object sender, EventArgs e)
        {
            pergunta5.AdicionarCaracterePergunta5("P");
        }

        private void btnTecPergunta5A_Click(object sender, EventArgs e)
        {
            pergunta5.AdicionarCaracterePergunta5("A");
        }

        private void btnTecPergunta5S_Click(object sender, EventArgs e)
        {
            pergunta5.AdicionarCaracterePergunta5("S");
        }

        private void btnTecPergunta5D_Click(object sender, EventArgs e)
        {
            pergunta5.AdicionarCaracterePergunta5("D");
        }

        private void btnTecPergunta5F_Click(object sender, EventArgs e)
        {
            pergunta5.AdicionarCaracterePergunta5("F");
        }

        private void btnTecPergunta5G_Click(object sender, EventArgs e)
        {
            pergunta5.AdicionarCaracterePergunta5("G");
        }

        private void btnTecPergunta5H_Click(object sender, EventArgs e)
        {
            pergunta5.AdicionarCaracterePergunta5("H");
        }

        private void btnTecPergunta5J_Click(object sender, EventArgs e)
        {
            pergunta5.AdicionarCaracterePergunta5("J");
        }

        private void btnTecPergunta5K_Click(object sender, EventArgs e)
        {
            pergunta5.AdicionarCaracterePergunta5("K");
        }

        private void btnTecPergunta5L_Click(object sender, EventArgs e)
        {
            pergunta5.AdicionarCaracterePergunta5("L");
        }

        private void btnTecPergunta5Cedilha_Click(object sender, EventArgs e)
        {
            pergunta5.AdicionarCaracterePergunta5("Ç");
        }

        private void btnTecPergunta5Z_Click(object sender, EventArgs e)
        {
            pergunta5.AdicionarCaracterePergunta5("Z");
        }

        private void btnTecPergunta5X_Click(object sender, EventArgs e)
        {
            pergunta5.AdicionarCaracterePergunta5("X");
        }

        private void btnTecPergunta5C_Click(object sender, EventArgs e)
        {
            pergunta5.AdicionarCaracterePergunta5("C");
        }

        private void btnTecPergunta5V_Click(object sender, EventArgs e)
        {
            pergunta5.AdicionarCaracterePergunta5("V");
        }

        private void btnTecPergunta5B_Click(object sender, EventArgs e)
        {
            pergunta5.AdicionarCaracterePergunta5("B");
        }

        private void btnTecPergunta5N_Click(object sender, EventArgs e)
        {
            pergunta5.AdicionarCaracterePergunta5("N");
        }

        private void btnTecPergunta5M_Click(object sender, EventArgs e)
        {
            pergunta5.AdicionarCaracterePergunta5("M");
        }

        private void btnTecPergunta5Virgula_Click(object sender, EventArgs e)
        {
            pergunta5.AdicionarCaracterePergunta5(",");
        }

        private void btnTecPergunta5PontoFinal_Click(object sender, EventArgs e)
        {
            pergunta5.AdicionarCaracterePergunta5(".");
        }

        private void btnTecPergunta5Delete_Click(object sender, EventArgs e)
        {
            pergunta5.ExcluirUltimoCaracterePergunta5();
        }

        private void btnTecPergunta5Enter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTecPergunta5Espaco_Click(object sender, EventArgs e)
        {
            pergunta5.AdicionarCaracterePergunta5(" ");

        }
    }
}
