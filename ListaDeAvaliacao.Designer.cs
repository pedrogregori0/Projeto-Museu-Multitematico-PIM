namespace Projeto_Museu_Multitematico_PIM
{
    partial class ListaDeAvaliacao
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblListaAvaliacao = new Label();
            btnPergunta1 = new Button();
            btnPergunta2 = new Button();
            button4 = new Button();
            btnPergunta3 = new Button();
            btnPergunta5 = new Button();
            btnHomeListaAvaliacao = new Button();
            btnVoltarListaAvaliacao = new Button();
            btnProximoListaAvaliacao = new Button();
            btnListaAvaliacao = new Button();
            SuspendLayout();
            // 
            // lblListaAvaliacao
            // 
            lblListaAvaliacao.AutoSize = true;
            lblListaAvaliacao.Location = new Point(320, 41);
            lblListaAvaliacao.Name = "lblListaAvaliacao";
            lblListaAvaliacao.Size = new Size(127, 20);
            lblListaAvaliacao.TabIndex = 0;
            lblListaAvaliacao.Text = "Lista de avaliação";
            // 
            // btnPergunta1
            // 
            btnPergunta1.Location = new Point(145, 159);
            btnPergunta1.Name = "btnPergunta1";
            btnPergunta1.Size = new Size(475, 29);
            btnPergunta1.TabIndex = 1;
            btnPergunta1.Text = "Quanto didático foi a descrição das obras?";
            btnPergunta1.UseVisualStyleBackColor = true;
            btnPergunta1.Click += btnPergunta1_Click;
            // 
            // btnPergunta2
            // 
            btnPergunta2.BackColor = SystemColors.ControlLightLight;
            btnPergunta2.Enabled = false;
            btnPergunta2.Location = new Point(145, 193);
            btnPergunta2.Name = "btnPergunta2";
            btnPergunta2.Size = new Size(475, 29);
            btnPergunta2.TabIndex = 2;
            btnPergunta2.Text = "O percurso das obras ajudou na experiência do museu?";
            btnPergunta2.UseVisualStyleBackColor = false;
            btnPergunta2.Click += btnPergunta2_Click;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ControlLightLight;
            button4.Enabled = false;
            button4.Location = new Point(145, 263);
            button4.Name = "button4";
            button4.Size = new Size(475, 29);
            button4.TabIndex = 4;
            button4.Text = "Sobre o conteúdo apresentado, qual o seu nível de satisfação?";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // btnPergunta3
            // 
            btnPergunta3.BackColor = SystemColors.ControlLightLight;
            btnPergunta3.Enabled = false;
            btnPergunta3.Location = new Point(145, 228);
            btnPergunta3.Name = "btnPergunta3";
            btnPergunta3.Size = new Size(475, 29);
            btnPergunta3.TabIndex = 3;
            btnPergunta3.Text = "Você recomendaria a outra pessoa uma visita ao nosso museu?";
            btnPergunta3.UseVisualStyleBackColor = false;
            btnPergunta3.Click += btnPergunta3_Click;
            // 
            // btnPergunta5
            // 
            btnPergunta5.BackColor = SystemColors.ControlLightLight;
            btnPergunta5.Enabled = false;
            btnPergunta5.Location = new Point(145, 299);
            btnPergunta5.Name = "btnPergunta5";
            btnPergunta5.Size = new Size(475, 29);
            btnPergunta5.TabIndex = 5;
            btnPergunta5.Text = "Cite um tema que você gostaria de ver futuramente em nosso museu:";
            btnPergunta5.UseVisualStyleBackColor = false;
            btnPergunta5.Click += btnPergunta5_Click;
            // 
            // btnHomeListaAvaliacao
            // 
            btnHomeListaAvaliacao.Image = Properties.Resources.botao_home;
            btnHomeListaAvaliacao.Location = new Point(120, 396);
            btnHomeListaAvaliacao.Name = "btnHomeListaAvaliacao";
            btnHomeListaAvaliacao.Size = new Size(94, 109);
            btnHomeListaAvaliacao.TabIndex = 6;
            btnHomeListaAvaliacao.Text = "Home";
            btnHomeListaAvaliacao.TextAlign = ContentAlignment.BottomCenter;
            btnHomeListaAvaliacao.UseVisualStyleBackColor = true;
            btnHomeListaAvaliacao.Click += btnHomeListaAvaliacao_Click;
            // 
            // btnVoltarListaAvaliacao
            // 
            btnVoltarListaAvaliacao.Image = Properties.Resources.botao_esquerda;
            btnVoltarListaAvaliacao.Location = new Point(264, 396);
            btnVoltarListaAvaliacao.Name = "btnVoltarListaAvaliacao";
            btnVoltarListaAvaliacao.Size = new Size(94, 109);
            btnVoltarListaAvaliacao.TabIndex = 7;
            btnVoltarListaAvaliacao.Text = "Voltar";
            btnVoltarListaAvaliacao.TextAlign = ContentAlignment.BottomCenter;
            btnVoltarListaAvaliacao.UseVisualStyleBackColor = true;
            // 
            // btnProximoListaAvaliacao
            // 
            btnProximoListaAvaliacao.Image = Properties.Resources.botao_direita;
            btnProximoListaAvaliacao.Location = new Point(410, 396);
            btnProximoListaAvaliacao.Name = "btnProximoListaAvaliacao";
            btnProximoListaAvaliacao.Size = new Size(94, 109);
            btnProximoListaAvaliacao.TabIndex = 8;
            btnProximoListaAvaliacao.Text = "Próximo";
            btnProximoListaAvaliacao.TextAlign = ContentAlignment.BottomCenter;
            btnProximoListaAvaliacao.UseVisualStyleBackColor = true;
            // 
            // btnListaAvaliacao
            // 
            btnListaAvaliacao.Image = Properties.Resources.botao_lista;
            btnListaAvaliacao.ImageAlign = ContentAlignment.TopCenter;
            btnListaAvaliacao.Location = new Point(559, 396);
            btnListaAvaliacao.Name = "btnListaAvaliacao";
            btnListaAvaliacao.Size = new Size(94, 109);
            btnListaAvaliacao.TabIndex = 9;
            btnListaAvaliacao.Text = "Lista de Avaliação";
            btnListaAvaliacao.TextAlign = ContentAlignment.BottomCenter;
            btnListaAvaliacao.UseVisualStyleBackColor = true;
            // 
            // ListaDeAvaliacao
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(774, 548);
            Controls.Add(btnListaAvaliacao);
            Controls.Add(btnProximoListaAvaliacao);
            Controls.Add(btnVoltarListaAvaliacao);
            Controls.Add(btnHomeListaAvaliacao);
            Controls.Add(btnPergunta5);
            Controls.Add(button4);
            Controls.Add(btnPergunta3);
            Controls.Add(btnPergunta2);
            Controls.Add(btnPergunta1);
            Controls.Add(lblListaAvaliacao);
            Name = "ListaDeAvaliacao";
            Text = " ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblListaAvaliacao;
        private Button btnPergunta1;
        private Button btnPergunta2;
        private Button button4;
        private Button btnPergunta3;
        private Button btnPergunta5;
        private Button btnHomeListaAvaliacao;
        private Button btnVoltarListaAvaliacao;
        private Button btnProximoListaAvaliacao;
        private Button btnListaAvaliacao;
    }
}
