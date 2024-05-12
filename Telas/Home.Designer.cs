namespace Projeto_Museu_Multitematico_PIM
{
    partial class Home
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
            btnListaAvaliacaoPergunta1 = new Button();
            btnHomePergunta1 = new Button();
            btnVoltarPergunta1 = new Button();
            btnProximoPergunta1 = new Button();
            btnObra1 = new Button();
            btnObra2 = new Button();
            btnObra3 = new Button();
            btnObra4 = new Button();
            lblTituloMuseuMultitematico = new Label();
            lblTituloTema = new Label();
            lblObraApollo11 = new Label();
            lblObraDestaqueMissao = new Label();
            lblObraNeilA = new Label();
            lblObraTripulacao = new Label();
            lblCliqueEmImagem = new Label();
            SuspendLayout();
            // 
            // btnListaAvaliacaoPergunta1
            // 
            btnListaAvaliacaoPergunta1.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
            btnListaAvaliacaoPergunta1.Image = Properties.Resources.botao_lista;
            btnListaAvaliacaoPergunta1.Location = new Point(961, 655);
            btnListaAvaliacaoPergunta1.Name = "btnListaAvaliacaoPergunta1";
            btnListaAvaliacaoPergunta1.Size = new Size(145, 145);
            btnListaAvaliacaoPergunta1.TabIndex = 17;
            btnListaAvaliacaoPergunta1.Text = "Lista de Avaliação";
            btnListaAvaliacaoPergunta1.TextAlign = ContentAlignment.BottomCenter;
            btnListaAvaliacaoPergunta1.UseVisualStyleBackColor = true;
            btnListaAvaliacaoPergunta1.Click += btnListaAvaliacaoPergunta1_Click;
            // 
            // btnHomePergunta1
            // 
            btnHomePergunta1.Enabled = false;
            btnHomePergunta1.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            btnHomePergunta1.Image = Properties.Resources.botao_home;
            btnHomePergunta1.Location = new Point(376, 655);
            btnHomePergunta1.Name = "btnHomePergunta1";
            btnHomePergunta1.Size = new Size(145, 145);
            btnHomePergunta1.TabIndex = 14;
            btnHomePergunta1.Text = "Home";
            btnHomePergunta1.TextAlign = ContentAlignment.BottomCenter;
            btnHomePergunta1.UseVisualStyleBackColor = true;
            // 
            // btnVoltarPergunta1
            // 
            btnVoltarPergunta1.Enabled = false;
            btnVoltarPergunta1.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            btnVoltarPergunta1.Image = Properties.Resources.icons8_duplo_para_a_esquerda_50;
            btnVoltarPergunta1.Location = new Point(571, 655);
            btnVoltarPergunta1.Name = "btnVoltarPergunta1";
            btnVoltarPergunta1.Size = new Size(145, 145);
            btnVoltarPergunta1.TabIndex = 15;
            btnVoltarPergunta1.Text = "Voltar";
            btnVoltarPergunta1.TextAlign = ContentAlignment.BottomCenter;
            btnVoltarPergunta1.UseVisualStyleBackColor = false;
            // 
            // btnProximoPergunta1
            // 
            btnProximoPergunta1.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            btnProximoPergunta1.Image = Properties.Resources.icons8_duplo_para_a_direita_50;
            btnProximoPergunta1.Location = new Point(766, 655);
            btnProximoPergunta1.Name = "btnProximoPergunta1";
            btnProximoPergunta1.Size = new Size(145, 145);
            btnProximoPergunta1.TabIndex = 16;
            btnProximoPergunta1.Text = "Próximo";
            btnProximoPergunta1.TextAlign = ContentAlignment.BottomCenter;
            btnProximoPergunta1.UseVisualStyleBackColor = true;
            btnProximoPergunta1.Click += btnProximoPergunta1_Click;
            // 
            // btnObra1
            // 
            btnObra1.BackgroundImage = Properties.Resources.Apollo_11__nave_;
            btnObra1.BackgroundImageLayout = ImageLayout.Stretch;
            btnObra1.Font = new Font("Rubik", 11.999999F, FontStyle.Bold, GraphicsUnit.Point);
            btnObra1.ForeColor = Color.LightCyan;
            btnObra1.Location = new Point(45, 228);
            btnObra1.Name = "btnObra1";
            btnObra1.Size = new Size(330, 330);
            btnObra1.TabIndex = 22;
            btnObra1.TextAlign = ContentAlignment.BottomCenter;
            btnObra1.UseVisualStyleBackColor = true;
            btnObra1.Click += btnObra1_Click;
            // 
            // btnObra2
            // 
            btnObra2.BackgroundImage = Properties.Resources.Neil_Armstrong;
            btnObra2.BackgroundImageLayout = ImageLayout.Stretch;
            btnObra2.Font = new Font("Rubik", 11.999999F, FontStyle.Bold, GraphicsUnit.Point);
            btnObra2.ForeColor = Color.Black;
            btnObra2.Location = new Point(753, 228);
            btnObra2.Name = "btnObra2";
            btnObra2.Size = new Size(330, 330);
            btnObra2.TabIndex = 23;
            btnObra2.TextAlign = ContentAlignment.BottomCenter;
            btnObra2.UseVisualStyleBackColor = true;
            btnObra2.Click += btnObra2_Click;
            // 
            // btnObra3
            // 
            btnObra3.BackgroundImage = Properties.Resources.Lancamento_do_foguete;
            btnObra3.BackgroundImageLayout = ImageLayout.Stretch;
            btnObra3.Font = new Font("Rubik", 11.999999F, FontStyle.Regular, GraphicsUnit.Point);
            btnObra3.ForeColor = Color.White;
            btnObra3.Location = new Point(399, 228);
            btnObra3.Name = "btnObra3";
            btnObra3.Size = new Size(330, 330);
            btnObra3.TabIndex = 24;
            btnObra3.TextAlign = ContentAlignment.BottomCenter;
            btnObra3.UseVisualStyleBackColor = true;
            btnObra3.Click += btnObra3_Click;
            // 
            // btnObra4
            // 
            btnObra4.BackgroundImage = Properties.Resources.Tripulação_apollo_11;
            btnObra4.BackgroundImageLayout = ImageLayout.Stretch;
            btnObra4.Font = new Font("Rubik", 11.999999F, FontStyle.Regular, GraphicsUnit.Point);
            btnObra4.ForeColor = Color.LightCyan;
            btnObra4.Location = new Point(1107, 228);
            btnObra4.Name = "btnObra4";
            btnObra4.Size = new Size(330, 330);
            btnObra4.TabIndex = 25;
            btnObra4.TextAlign = ContentAlignment.BottomCenter;
            btnObra4.UseVisualStyleBackColor = true;
            btnObra4.Click += btnObra4_Click;
            // 
            // lblTituloMuseuMultitematico
            // 
            lblTituloMuseuMultitematico.AutoSize = true;
            lblTituloMuseuMultitematico.BackColor = Color.FromArgb(15, 14, 75);
            lblTituloMuseuMultitematico.Font = new Font("DejaVu Sans Condensed", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            lblTituloMuseuMultitematico.ForeColor = Color.Black;
            lblTituloMuseuMultitematico.Location = new Point(529, 34);
            lblTituloMuseuMultitematico.Name = "lblTituloMuseuMultitematico";
            lblTituloMuseuMultitematico.Size = new Size(424, 40);
            lblTituloMuseuMultitematico.TabIndex = 26;
            lblTituloMuseuMultitematico.Text = "MUSEU MULTITEMÁTICO";
            // 
            // lblTituloTema
            // 
            lblTituloTema.AutoSize = true;
            lblTituloTema.BackColor = Color.FromArgb(15, 14, 75);
            lblTituloTema.Font = new Font("Franklin Gothic Medium Cond", 27F, FontStyle.Regular, GraphicsUnit.Point);
            lblTituloTema.ForeColor = Color.DarkGoldenrod;
            lblTituloTema.Location = new Point(425, 116);
            lblTituloTema.Name = "lblTituloTema";
            lblTituloTema.Size = new Size(633, 52);
            lblTituloTema.TabIndex = 27;
            lblTituloTema.Text = "PRIMEIRA VIAGEM DO HOMEM A LUA";
            // 
            // lblObraApollo11
            // 
            lblObraApollo11.AutoSize = true;
            lblObraApollo11.BackColor = Color.Transparent;
            lblObraApollo11.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            lblObraApollo11.ForeColor = Color.DarkGoldenrod;
            lblObraApollo11.Location = new Point(110, 579);
            lblObraApollo11.Name = "lblObraApollo11";
            lblObraApollo11.Size = new Size(210, 35);
            lblObraApollo11.TabIndex = 28;
            lblObraApollo11.Text = "Obra - Apollo 11";
            // 
            // lblObraDestaqueMissao
            // 
            lblObraDestaqueMissao.AutoSize = true;
            lblObraDestaqueMissao.BackColor = Color.Transparent;
            lblObraDestaqueMissao.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            lblObraDestaqueMissao.ForeColor = Color.DarkGoldenrod;
            lblObraDestaqueMissao.Location = new Point(399, 579);
            lblObraDestaqueMissao.Name = "lblObraDestaqueMissao";
            lblObraDestaqueMissao.Size = new Size(340, 35);
            lblObraDestaqueMissao.TabIndex = 29;
            lblObraDestaqueMissao.Text = "Obra - Destaques da missão";
            // 
            // lblObraNeilA
            // 
            lblObraNeilA.AutoSize = true;
            lblObraNeilA.BackColor = Color.Transparent;
            lblObraNeilA.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            lblObraNeilA.ForeColor = Color.DarkGoldenrod;
            lblObraNeilA.Location = new Point(772, 579);
            lblObraNeilA.Name = "lblObraNeilA";
            lblObraNeilA.Size = new Size(311, 35);
            lblObraNeilA.TabIndex = 30;
            lblObraNeilA.Text = "Obra - Neil A. Armstrong";
            // 
            // lblObraTripulacao
            // 
            lblObraTripulacao.AutoSize = true;
            lblObraTripulacao.BackColor = Color.Transparent;
            lblObraTripulacao.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            lblObraTripulacao.ForeColor = Color.DarkGoldenrod;
            lblObraTripulacao.Location = new Point(1168, 579);
            lblObraTripulacao.Name = "lblObraTripulacao";
            lblObraTripulacao.Size = new Size(218, 35);
            lblObraTripulacao.TabIndex = 31;
            lblObraTripulacao.Text = "Obra - Tripulação";
            // 
            // lblCliqueEmImagem
            // 
            lblCliqueEmImagem.AutoSize = true;
            lblCliqueEmImagem.BackColor = Color.Transparent;
            lblCliqueEmImagem.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
            lblCliqueEmImagem.ForeColor = Color.DarkGoldenrod;
            lblCliqueEmImagem.Location = new Point(45, 196);
            lblCliqueEmImagem.Name = "lblCliqueEmImagem";
            lblCliqueEmImagem.Size = new Size(430, 25);
            lblCliqueEmImagem.TabIndex = 32;
            lblCliqueEmImagem.Text = "Clique em uma imagem para ver a descrição da obra";
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Espaço__nasa_;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1482, 853);
            Controls.Add(lblCliqueEmImagem);
            Controls.Add(lblObraTripulacao);
            Controls.Add(lblObraNeilA);
            Controls.Add(lblObraDestaqueMissao);
            Controls.Add(lblObraApollo11);
            Controls.Add(lblTituloTema);
            Controls.Add(lblTituloMuseuMultitematico);
            Controls.Add(btnObra4);
            Controls.Add(btnObra3);
            Controls.Add(btnObra2);
            Controls.Add(btnObra1);
            Controls.Add(btnListaAvaliacaoPergunta1);
            Controls.Add(btnProximoPergunta1);
            Controls.Add(btnVoltarPergunta1);
            Controls.Add(btnHomePergunta1);
            Name = "Home";
            Text = "Home";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnListaAvaliacaoPergunta1;
        private Button btnHomePergunta1;
        private Button btnVoltarPergunta1;
        private Button btnProximoPergunta1;
        private Button btnObra1;
        private Button btnObra2;
        private Button btnObra3;
        private Button btnObra4;
        private Label lblTituloMuseuMultitematico;
        private Label lblTituloTema;
        private Label lblObraApollo11;
        private Label lblObraDestaqueMissao;
        private Label lblObraNeilA;
        private Label lblObraTripulacao;
        private Label lblCliqueEmImagem;
    }
}