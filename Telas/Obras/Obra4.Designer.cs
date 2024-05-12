namespace Projeto_Museu_Multitematico_PIM
{
    partial class Obra4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Obra4));
            pcbxObra4 = new PictureBox();
            lblObra4 = new Label();
            btnListaAvaliacaoObra4 = new Button();
            btnProximoObra4 = new Button();
            btnVoltarObra4 = new Button();
            btnHomeObra4 = new Button();
            lblTripulacao = new Label();
            ((System.ComponentModel.ISupportInitialize)pcbxObra4).BeginInit();
            SuspendLayout();
            // 
            // pcbxObra4
            // 
            pcbxObra4.BorderStyle = BorderStyle.FixedSingle;
            pcbxObra4.Image = (Image)resources.GetObject("pcbxObra4.Image");
            pcbxObra4.Location = new Point(499, 12);
            pcbxObra4.Name = "pcbxObra4";
            pcbxObra4.Size = new Size(485, 485);
            pcbxObra4.SizeMode = PictureBoxSizeMode.Zoom;
            pcbxObra4.TabIndex = 59;
            pcbxObra4.TabStop = false;
            // 
            // lblObra4
            // 
            lblObra4.AutoEllipsis = true;
            lblObra4.BackColor = Color.Transparent;
            lblObra4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblObra4.ForeColor = Color.DarkGoldenrod;
            lblObra4.Location = new Point(240, 553);
            lblObra4.Name = "lblObra4";
            lblObra4.Size = new Size(1003, 96);
            lblObra4.TabIndex = 58;
            lblObra4.Text = resources.GetString("lblObra4.Text");
            lblObra4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnListaAvaliacaoObra4
            // 
            btnListaAvaliacaoObra4.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
            btnListaAvaliacaoObra4.Image = Properties.Resources.botao_lista;
            btnListaAvaliacaoObra4.Location = new Point(961, 655);
            btnListaAvaliacaoObra4.Name = "btnListaAvaliacaoObra4";
            btnListaAvaliacaoObra4.Size = new Size(145, 145);
            btnListaAvaliacaoObra4.TabIndex = 57;
            btnListaAvaliacaoObra4.Text = "Lista de Avaliação";
            btnListaAvaliacaoObra4.TextAlign = ContentAlignment.BottomCenter;
            btnListaAvaliacaoObra4.UseVisualStyleBackColor = true;
            btnListaAvaliacaoObra4.Click += btnListaAvaliacaoObra4_Click;
            // 
            // btnProximoObra4
            // 
            btnProximoObra4.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            btnProximoObra4.Image = Properties.Resources.botao_direita;
            btnProximoObra4.Location = new Point(766, 655);
            btnProximoObra4.Name = "btnProximoObra4";
            btnProximoObra4.Size = new Size(145, 145);
            btnProximoObra4.TabIndex = 56;
            btnProximoObra4.Text = "Próximo";
            btnProximoObra4.TextAlign = ContentAlignment.BottomCenter;
            btnProximoObra4.UseVisualStyleBackColor = true;
            btnProximoObra4.Click += btnProximoObra4_Click;
            // 
            // btnVoltarObra4
            // 
            btnVoltarObra4.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            btnVoltarObra4.Image = Properties.Resources.botao_esquerda;
            btnVoltarObra4.Location = new Point(571, 655);
            btnVoltarObra4.Name = "btnVoltarObra4";
            btnVoltarObra4.Size = new Size(145, 145);
            btnVoltarObra4.TabIndex = 55;
            btnVoltarObra4.Text = "Voltar";
            btnVoltarObra4.TextAlign = ContentAlignment.BottomCenter;
            btnVoltarObra4.UseVisualStyleBackColor = true;
            btnVoltarObra4.Click += btnVoltarObra4_Click;
            // 
            // btnHomeObra4
            // 
            btnHomeObra4.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            btnHomeObra4.Image = Properties.Resources.botao_home;
            btnHomeObra4.Location = new Point(376, 655);
            btnHomeObra4.Name = "btnHomeObra4";
            btnHomeObra4.Size = new Size(145, 145);
            btnHomeObra4.TabIndex = 54;
            btnHomeObra4.Text = "Home";
            btnHomeObra4.TextAlign = ContentAlignment.BottomCenter;
            btnHomeObra4.UseVisualStyleBackColor = true;
            btnHomeObra4.Click += btnHomeObra4_Click;
            // 
            // lblTripulacao
            // 
            lblTripulacao.AutoSize = true;
            lblTripulacao.BackColor = Color.Transparent;
            lblTripulacao.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblTripulacao.ForeColor = Color.DarkGoldenrod;
            lblTripulacao.Location = new Point(682, 504);
            lblTripulacao.Name = "lblTripulacao";
            lblTripulacao.Size = new Size(133, 32);
            lblTripulacao.TabIndex = 60;
            lblTripulacao.Text = "Tripulação";
            // 
            // Obra4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Espaço__nasa_;
            ClientSize = new Size(1482, 853);
            Controls.Add(lblTripulacao);
            Controls.Add(pcbxObra4);
            Controls.Add(lblObra4);
            Controls.Add(btnListaAvaliacaoObra4);
            Controls.Add(btnProximoObra4);
            Controls.Add(btnVoltarObra4);
            Controls.Add(btnHomeObra4);
            Name = "Obra4";
            Text = "Obra 4 - Tripulação";
            ((System.ComponentModel.ISupportInitialize)pcbxObra4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pcbxObra4;
        private Label lblObra4;
        private Button btnListaAvaliacaoObra4;
        private Button btnProximoObra4;
        private Button btnVoltarObra4;
        private Button btnHomeObra4;
        private Label lblTripulacao;
    }
}