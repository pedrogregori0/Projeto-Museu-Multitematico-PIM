namespace Projeto_Museu_Multitematico_PIM
{
    partial class Obra3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Obra3));
            pcbxObra3 = new PictureBox();
            lblObra3 = new Label();
            btnListaAvaliacaoObra3 = new Button();
            btnProximoObra3 = new Button();
            btnVoltarObra3 = new Button();
            btnHomeObra3 = new Button();
            lblDestaqueMissao = new Label();
            ((System.ComponentModel.ISupportInitialize)pcbxObra3).BeginInit();
            SuspendLayout();
            // 
            // pcbxObra3
            // 
            pcbxObra3.Image = (Image)resources.GetObject("pcbxObra3.Image");
            pcbxObra3.Location = new Point(151, 11);
            pcbxObra3.Margin = new Padding(3, 2, 3, 2);
            pcbxObra3.Name = "pcbxObra3";
            pcbxObra3.Size = new Size(582, 287);
            pcbxObra3.SizeMode = PictureBoxSizeMode.Zoom;
            pcbxObra3.TabIndex = 53;
            pcbxObra3.TabStop = false;
            // 
            // lblObra3
            // 
            lblObra3.AutoEllipsis = true;
            lblObra3.Location = new Point(87, 320);
            lblObra3.Name = "lblObra3";
            lblObra3.Size = new Size(710, 80);
            lblObra3.TabIndex = 52;
            lblObra3.Text = resources.GetString("lblObra3.Text");
            lblObra3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnListaAvaliacaoObra3
            // 
            btnListaAvaliacaoObra3.Image = Properties.Resources.botao_lista;
            btnListaAvaliacaoObra3.Location = new Point(644, 420);
            btnListaAvaliacaoObra3.Margin = new Padding(3, 2, 3, 2);
            btnListaAvaliacaoObra3.Name = "btnListaAvaliacaoObra3";
            btnListaAvaliacaoObra3.Size = new Size(109, 109);
            btnListaAvaliacaoObra3.TabIndex = 51;
            btnListaAvaliacaoObra3.Text = "Lista de Avaliação";
            btnListaAvaliacaoObra3.TextAlign = ContentAlignment.BottomCenter;
            btnListaAvaliacaoObra3.UseVisualStyleBackColor = true;
            btnListaAvaliacaoObra3.Click += btnListaAvaliacaoObra3_Click;
            // 
            // btnProximoObra3
            // 
            btnProximoObra3.Image = Properties.Resources.botao_direita;
            btnProximoObra3.Location = new Point(473, 420);
            btnProximoObra3.Margin = new Padding(3, 2, 3, 2);
            btnProximoObra3.Name = "btnProximoObra3";
            btnProximoObra3.Size = new Size(109, 109);
            btnProximoObra3.TabIndex = 50;
            btnProximoObra3.Text = "Próximo";
            btnProximoObra3.TextAlign = ContentAlignment.BottomCenter;
            btnProximoObra3.UseVisualStyleBackColor = true;
            btnProximoObra3.Click += btnProximoObra3_Click;
            // 
            // btnVoltarObra3
            // 
            btnVoltarObra3.Image = Properties.Resources.botao_esquerda;
            btnVoltarObra3.Location = new Point(302, 420);
            btnVoltarObra3.Margin = new Padding(3, 2, 3, 2);
            btnVoltarObra3.Name = "btnVoltarObra3";
            btnVoltarObra3.Size = new Size(109, 109);
            btnVoltarObra3.TabIndex = 49;
            btnVoltarObra3.Text = "Voltar";
            btnVoltarObra3.TextAlign = ContentAlignment.BottomCenter;
            btnVoltarObra3.UseVisualStyleBackColor = true;
            btnVoltarObra3.Click += btnVoltarObra3_Click;
            // 
            // btnHomeObra3
            // 
            btnHomeObra3.Image = Properties.Resources.botao_home;
            btnHomeObra3.Location = new Point(131, 420);
            btnHomeObra3.Margin = new Padding(3, 2, 3, 2);
            btnHomeObra3.Name = "btnHomeObra3";
            btnHomeObra3.Size = new Size(109, 109);
            btnHomeObra3.TabIndex = 48;
            btnHomeObra3.Text = "Home";
            btnHomeObra3.TextAlign = ContentAlignment.BottomCenter;
            btnHomeObra3.UseVisualStyleBackColor = true;
            btnHomeObra3.Click += btnHomeObra3_Click;
            // 
            // lblDestaqueMissao
            // 
            lblDestaqueMissao.AutoSize = true;
            lblDestaqueMissao.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblDestaqueMissao.Location = new Point(372, 300);
            lblDestaqueMissao.Name = "lblDestaqueMissao";
            lblDestaqueMissao.Size = new Size(156, 20);
            lblDestaqueMissao.TabIndex = 54;
            lblDestaqueMissao.Text = "Destaques da missão";
            // 
            // Obra3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 561);
            Controls.Add(lblDestaqueMissao);
            Controls.Add(pcbxObra3);
            Controls.Add(lblObra3);
            Controls.Add(btnListaAvaliacaoObra3);
            Controls.Add(btnProximoObra3);
            Controls.Add(btnVoltarObra3);
            Controls.Add(btnHomeObra3);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Obra3";
            Text = "Obra 3";
            ((System.ComponentModel.ISupportInitialize)pcbxObra3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pcbxObra3;
        private Label lblObra3;
        private Button btnListaAvaliacaoObra3;
        private Button btnProximoObra3;
        private Button btnVoltarObra3;
        private Button btnHomeObra3;
        private Label lblDestaqueMissao;
    }
}