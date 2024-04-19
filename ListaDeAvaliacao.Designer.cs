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
            lblListaAvaliacao.Location = new Point(323, 80);
            lblListaAvaliacao.Name = "lblListaAvaliacao";
            lblListaAvaliacao.Size = new Size(127, 20);
            lblListaAvaliacao.TabIndex = 0;
            lblListaAvaliacao.Text = "Lista de avaliação";
            // 
            // btnPergunta1
            // 
            btnPergunta1.Location = new Point(148, 197);
            btnPergunta1.Name = "btnPergunta1";
            btnPergunta1.Size = new Size(476, 29);
            btnPergunta1.TabIndex = 1;
            btnPergunta1.Text = "Quanto didático foi a descrição das obras?";
            btnPergunta1.UseVisualStyleBackColor = true;
            // 
            // btnPergunta2
            // 
            btnPergunta2.Location = new Point(148, 232);
            btnPergunta2.Name = "btnPergunta2";
            btnPergunta2.Size = new Size(476, 29);
            btnPergunta2.TabIndex = 2;
            btnPergunta2.Text = "O percurso das obras ajudou na experiência do museu?";
            btnPergunta2.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(148, 302);
            button4.Name = "button4";
            button4.Size = new Size(476, 29);
            button4.TabIndex = 4;
            button4.Text = "Sobre o conteúdo apresentado, qual o seu nível de satisfação?";
            button4.UseVisualStyleBackColor = true;
            // 
            // btnPergunta3
            // 
            btnPergunta3.Location = new Point(148, 267);
            btnPergunta3.Name = "btnPergunta3";
            btnPergunta3.Size = new Size(476, 29);
            btnPergunta3.TabIndex = 3;
            btnPergunta3.Text = "Você recomendaria a outra pessoa uma visita ao nosso museu?";
            btnPergunta3.UseVisualStyleBackColor = true;
            // 
            // btnPergunta5
            // 
            btnPergunta5.Location = new Point(148, 337);
            btnPergunta5.Name = "btnPergunta5";
            btnPergunta5.Size = new Size(476, 29);
            btnPergunta5.TabIndex = 5;
            btnPergunta5.Text = "Cite um tema que você gostaria de ver futuramente em nosso museu:";
            btnPergunta5.UseVisualStyleBackColor = true;
            // 
            // btnHomeListaAvaliacao
            // 
            btnHomeListaAvaliacao.Image = Properties.Resources.botao_home;
            btnHomeListaAvaliacao.Location = new Point(124, 434);
            btnHomeListaAvaliacao.Name = "btnHomeListaAvaliacao";
            btnHomeListaAvaliacao.Size = new Size(94, 87);
            btnHomeListaAvaliacao.TabIndex = 6;
            btnHomeListaAvaliacao.Text = "Home";
            btnHomeListaAvaliacao.TextAlign = ContentAlignment.BottomCenter;
            btnHomeListaAvaliacao.UseVisualStyleBackColor = true;
            btnHomeListaAvaliacao.Click += btnHomeListaAvaliacao_Click;
            // 
            // btnVoltarListaAvaliacao
            // 
            btnVoltarListaAvaliacao.Image = Properties.Resources.botao_esquerda;
            btnVoltarListaAvaliacao.Location = new Point(268, 434);
            btnVoltarListaAvaliacao.Name = "btnVoltarListaAvaliacao";
            btnVoltarListaAvaliacao.Size = new Size(94, 87);
            btnVoltarListaAvaliacao.TabIndex = 7;
            btnVoltarListaAvaliacao.Text = "Voltar";
            btnVoltarListaAvaliacao.TextAlign = ContentAlignment.BottomCenter;
            btnVoltarListaAvaliacao.UseVisualStyleBackColor = true;
            // 
            // btnProximoListaAvaliacao
            // 
            btnProximoListaAvaliacao.Image = Properties.Resources.botao_direita;
            btnProximoListaAvaliacao.Location = new Point(414, 434);
            btnProximoListaAvaliacao.Name = "btnProximoListaAvaliacao";
            btnProximoListaAvaliacao.Size = new Size(94, 87);
            btnProximoListaAvaliacao.TabIndex = 8;
            btnProximoListaAvaliacao.Text = "Próximo";
            btnProximoListaAvaliacao.TextAlign = ContentAlignment.BottomCenter;
            btnProximoListaAvaliacao.UseVisualStyleBackColor = true;
            // 
            // btnListaAvaliacao
            // 
            btnListaAvaliacao.Image = Properties.Resources.botao_lista;
            btnListaAvaliacao.ImageAlign = ContentAlignment.TopCenter;
            btnListaAvaliacao.Location = new Point(562, 434);
            btnListaAvaliacao.Name = "btnListaAvaliacao";
            btnListaAvaliacao.Size = new Size(94, 87);
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
            Text = "Lista de avaliação";
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
