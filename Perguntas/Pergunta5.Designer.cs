namespace Projeto_Museu_Multitematico_PIM
{
    partial class Pergunta5
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblPergunta5 = new Label();
            btnListaAvaliacaoPergunta5 = new Button();
            btnProximoPergunta5 = new Button();
            btnVoltarPergunta5 = new Button();
            btnHomePergunta5 = new Button();
            lblPergunta5Enunciado = new Label();
            txbPergunta5 = new TextBox();
            SuspendLayout();
            // 
            // lblPergunta5
            // 
            lblPergunta5.AutoSize = true;
            lblPergunta5.Location = new Point(150, 101);
            lblPergunta5.Name = "lblPergunta5";
            lblPergunta5.Size = new Size(467, 20);
            lblPergunta5.TabIndex = 36;
            lblPergunta5.Text = "Cite um tema que você gostaria de ver futuramente em nosso museu:";
            // 
            // btnListaAvaliacaoPergunta5
            // 
            btnListaAvaliacaoPergunta5.Enabled = false;
            btnListaAvaliacaoPergunta5.Image = Properties.Resources.botao_lista;
            btnListaAvaliacaoPergunta5.ImageAlign = ContentAlignment.TopCenter;
            btnListaAvaliacaoPergunta5.Location = new Point(565, 421);
            btnListaAvaliacaoPergunta5.Name = "btnListaAvaliacaoPergunta5";
            btnListaAvaliacaoPergunta5.Size = new Size(94, 109);
            btnListaAvaliacaoPergunta5.TabIndex = 35;
            btnListaAvaliacaoPergunta5.Text = "Lista de Avaliação";
            btnListaAvaliacaoPergunta5.TextAlign = ContentAlignment.BottomCenter;
            btnListaAvaliacaoPergunta5.UseVisualStyleBackColor = true;
            // 
            // btnProximoPergunta5
            // 
            btnProximoPergunta5.Image = Properties.Resources.botao_direita;
            btnProximoPergunta5.Location = new Point(417, 421);
            btnProximoPergunta5.Name = "btnProximoPergunta5";
            btnProximoPergunta5.Size = new Size(94, 109);
            btnProximoPergunta5.TabIndex = 34;
            btnProximoPergunta5.Text = "Próximo";
            btnProximoPergunta5.TextAlign = ContentAlignment.BottomCenter;
            btnProximoPergunta5.UseVisualStyleBackColor = true;
            btnProximoPergunta5.Click += btnProximoPergunta5_Click;
            // 
            // btnVoltarPergunta5
            // 
            btnVoltarPergunta5.Enabled = false;
            btnVoltarPergunta5.Image = Properties.Resources.botao_esquerda;
            btnVoltarPergunta5.Location = new Point(271, 421);
            btnVoltarPergunta5.Name = "btnVoltarPergunta5";
            btnVoltarPergunta5.Size = new Size(94, 109);
            btnVoltarPergunta5.TabIndex = 33;
            btnVoltarPergunta5.Text = "Voltar";
            btnVoltarPergunta5.TextAlign = ContentAlignment.BottomCenter;
            btnVoltarPergunta5.UseVisualStyleBackColor = true;
            // 
            // btnHomePergunta5
            // 
            btnHomePergunta5.Image = Properties.Resources.botao_home;
            btnHomePergunta5.Location = new Point(127, 421);
            btnHomePergunta5.Name = "btnHomePergunta5";
            btnHomePergunta5.Size = new Size(94, 109);
            btnHomePergunta5.TabIndex = 32;
            btnHomePergunta5.Text = "Home";
            btnHomePergunta5.TextAlign = ContentAlignment.BottomCenter;
            btnHomePergunta5.UseVisualStyleBackColor = true;
            btnHomePergunta5.Click += btnHomePergunta5_Click;
            // 
            // lblPergunta5Enunciado
            // 
            lblPergunta5Enunciado.AutoSize = true;
            lblPergunta5Enunciado.Location = new Point(114, 17);
            lblPergunta5Enunciado.Name = "lblPergunta5Enunciado";
            lblPergunta5Enunciado.Size = new Size(79, 20);
            lblPergunta5Enunciado.TabIndex = 27;
            lblPergunta5Enunciado.Text = "Pergunta 5";
            // 
            // txbPergunta5
            // 
            txbPergunta5.AcceptsReturn = true;
            txbPergunta5.Location = new Point(114, 209);
            txbPergunta5.Multiline = true;
            txbPergunta5.Name = "txbPergunta5";
            txbPergunta5.Size = new Size(539, 167);
            txbPergunta5.TabIndex = 37;
            txbPergunta5.TextChanged += txbPergunta5_TextChanged;
            // 
            // Pergunta5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(774, 548);
            Controls.Add(txbPergunta5);
            Controls.Add(lblPergunta5);
            Controls.Add(btnListaAvaliacaoPergunta5);
            Controls.Add(btnProximoPergunta5);
            Controls.Add(btnVoltarPergunta5);
            Controls.Add(btnHomePergunta5);
            Controls.Add(lblPergunta5Enunciado);
            Name = "Pergunta5";
            Text = "Pergunta 5";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPergunta5;
        private Button btnListaAvaliacaoPergunta5;
        private Button btnProximoPergunta5;
        private Button btnVoltarPergunta5;
        private Button btnHomePergunta5;
        private Label lblPergunta5Enunciado;
        private TextBox txbPergunta5;
    }
}