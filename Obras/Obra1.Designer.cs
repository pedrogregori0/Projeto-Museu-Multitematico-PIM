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
            btnListaAvaliacaoObra1.Location = new Point(489, 317);
            btnListaAvaliacaoObra1.Margin = new Padding(3, 2, 3, 2);
            btnListaAvaliacaoObra1.Name = "btnListaAvaliacaoObra1";
            btnListaAvaliacaoObra1.Size = new Size(82, 82);
            btnListaAvaliacaoObra1.TabIndex = 39;
            btnListaAvaliacaoObra1.Text = "Lista de Avaliação";
            btnListaAvaliacaoObra1.TextAlign = ContentAlignment.BottomCenter;
            btnListaAvaliacaoObra1.UseVisualStyleBackColor = true;
            // 
            // btnProximoObra1
            // 
            btnProximoObra1.Image = Properties.Resources.botao_direita;
            btnProximoObra1.Location = new Point(360, 317);
            btnProximoObra1.Margin = new Padding(3, 2, 3, 2);
            btnProximoObra1.Name = "btnProximoObra1";
            btnProximoObra1.Size = new Size(82, 82);
            btnProximoObra1.TabIndex = 38;
            btnProximoObra1.Text = "Próximo";
            btnProximoObra1.TextAlign = ContentAlignment.BottomCenter;
            btnProximoObra1.UseVisualStyleBackColor = true;
            // 
            // btnVoltarObra1
            // 
            btnVoltarObra1.Image = Properties.Resources.botao_esquerda;
            btnVoltarObra1.Location = new Point(232, 317);
            btnVoltarObra1.Margin = new Padding(3, 2, 3, 2);
            btnVoltarObra1.Name = "btnVoltarObra1";
            btnVoltarObra1.Size = new Size(82, 82);
            btnVoltarObra1.TabIndex = 37;
            btnVoltarObra1.Text = "Voltar";
            btnVoltarObra1.TextAlign = ContentAlignment.BottomCenter;
            btnVoltarObra1.UseVisualStyleBackColor = true;
            // 
            // btnHomeObra1
            // 
            btnHomeObra1.Image = Properties.Resources.botao_home;
            btnHomeObra1.Location = new Point(106, 317);
            btnHomeObra1.Margin = new Padding(3, 2, 3, 2);
            btnHomeObra1.Name = "btnHomeObra1";
            btnHomeObra1.Size = new Size(82, 82);
            btnHomeObra1.TabIndex = 36;
            btnHomeObra1.Text = "Home";
            btnHomeObra1.TextAlign = ContentAlignment.BottomCenter;
            btnHomeObra1.UseVisualStyleBackColor = true;
            // 
            // lblObra1
            // 
            lblObra1.AutoSize = true;
            lblObra1.Location = new Point(134, 273);
            lblObra1.Name = "lblObra1";
            lblObra1.Size = new Size(362, 15);
            lblObra1.TabIndex = 40;
            lblObra1.Text = "Um breve resumo referente a obra, bal balba balba lbalba lba bla ba";
            // 
            // pcbxObra1
            // 
            pcbxObra1.Image = Properties.Resources._125b4749900b13cbacf81faade2a5f8f;
            pcbxObra1.Location = new Point(100, 12);
            pcbxObra1.Margin = new Padding(3, 2, 3, 2);
            pcbxObra1.Name = "pcbxObra1";
            pcbxObra1.Size = new Size(477, 232);
            pcbxObra1.SizeMode = PictureBoxSizeMode.Zoom;
            pcbxObra1.TabIndex = 41;
            pcbxObra1.TabStop = false;
            pcbxObra1.Click += pictureBox1_Click;
            // 
            // Obra1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(677, 411);
            Controls.Add(pcbxObra1);
            Controls.Add(lblObra1);
            Controls.Add(btnListaAvaliacaoObra1);
            Controls.Add(btnProximoObra1);
            Controls.Add(btnVoltarObra1);
            Controls.Add(btnHomeObra1);
            Margin = new Padding(3, 2, 3, 2);
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