namespace Projeto_Museu_Multitematico_PIM
{
    partial class Obra1
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
            btnListaAvaliacaoObra1 = new Button();
            btnProximoObra1 = new Button();
            btnVoltarObra1 = new Button();
            btnHomeObra1 = new Button();
            lblObra1 = new Label();
            pcbxObra1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pcbxObra1).BeginInit();
            SuspendLayout();
            // 
            // btnListaAvaliacaoObra1
            // 
            btnListaAvaliacaoObra1.Image = Properties.Resources.botao_lista;
            btnListaAvaliacaoObra1.ImageAlign = ContentAlignment.TopCenter;
            btnListaAvaliacaoObra1.Location = new Point(559, 423);
            btnListaAvaliacaoObra1.Name = "btnListaAvaliacaoObra1";
            btnListaAvaliacaoObra1.Size = new Size(94, 109);
            btnListaAvaliacaoObra1.TabIndex = 39;
            btnListaAvaliacaoObra1.Text = "Lista de Avaliação";
            btnListaAvaliacaoObra1.TextAlign = ContentAlignment.BottomCenter;
            btnListaAvaliacaoObra1.UseVisualStyleBackColor = true;
            btnListaAvaliacaoObra1.Click += btnListaAvaliacaoObra1_Click;
            // 
            // btnProximoObra1
            // 
            btnProximoObra1.Image = Properties.Resources.botao_direita;
            btnProximoObra1.Location = new Point(411, 423);
            btnProximoObra1.Name = "btnProximoObra1";
            btnProximoObra1.Size = new Size(94, 109);
            btnProximoObra1.TabIndex = 38;
            btnProximoObra1.Text = "Próximo";
            btnProximoObra1.TextAlign = ContentAlignment.BottomCenter;
            btnProximoObra1.UseVisualStyleBackColor = true;
            btnProximoObra1.Click += btnProximoObra1_Click;
            // 
            // btnVoltarObra1
            // 
            btnVoltarObra1.Image = Properties.Resources.botao_esquerda;
            btnVoltarObra1.Location = new Point(265, 423);
            btnVoltarObra1.Name = "btnVoltarObra1";
            btnVoltarObra1.Size = new Size(94, 109);
            btnVoltarObra1.TabIndex = 37;
            btnVoltarObra1.Text = "Voltar";
            btnVoltarObra1.TextAlign = ContentAlignment.BottomCenter;
            btnVoltarObra1.UseVisualStyleBackColor = true;
            btnVoltarObra1.Click += btnVoltarObra1_Click;
            // 
            // btnHomeObra1
            // 
            btnHomeObra1.Image = Properties.Resources.botao_home;
            btnHomeObra1.Location = new Point(121, 423);
            btnHomeObra1.Name = "btnHomeObra1";
            btnHomeObra1.Size = new Size(94, 109);
            btnHomeObra1.TabIndex = 36;
            btnHomeObra1.Text = "Home";
            btnHomeObra1.TextAlign = ContentAlignment.BottomCenter;
            btnHomeObra1.UseVisualStyleBackColor = true;
            btnHomeObra1.Click += btnHomeObra1_Click;
            // 
            // lblObra1
            // 
            lblObra1.AutoSize = true;
            lblObra1.Location = new Point(153, 364);
            lblObra1.Name = "lblObra1";
            lblObra1.Size = new Size(466, 20);
            lblObra1.TabIndex = 40;
            lblObra1.Text = "Um breve resumo referente a obra, bal balba balba lbalba lba bla ba";
            // 
            // pcbxObra1
            // 
            pcbxObra1.Image = Properties.Resources._125b4749900b13cbacf81faade2a5f8f;
            pcbxObra1.Location = new Point(114, 16);
            pcbxObra1.Name = "pcbxObra1";
            pcbxObra1.Size = new Size(545, 309);
            pcbxObra1.SizeMode = PictureBoxSizeMode.Zoom;
            pcbxObra1.TabIndex = 41;
            pcbxObra1.TabStop = false;
            // 
            // Obra1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(774, 548);
            Controls.Add(pcbxObra1);
            Controls.Add(lblObra1);
            Controls.Add(btnListaAvaliacaoObra1);
            Controls.Add(btnProximoObra1);
            Controls.Add(btnVoltarObra1);
            Controls.Add(btnHomeObra1);
            Name = "Obra1";
            Text = "Obra 1";
            ((System.ComponentModel.ISupportInitialize)pcbxObra1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnListaAvaliacaoObra1;
        private Button btnProximoObra1;
        private Button btnVoltarObra1;
        private Button btnHomeObra1;
        private Label lblObra1;
        private PictureBox pcbxObra1;
    }
}