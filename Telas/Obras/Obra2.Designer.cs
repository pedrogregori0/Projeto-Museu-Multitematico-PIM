namespace Projeto_Museu_Multitematico_PIM
{
    partial class Obra2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Obra2));
            pcbxObra2 = new PictureBox();
            lblObra2 = new Label();
            btnListaAvaliacaoObra2 = new Button();
            btnProximoObra2 = new Button();
            btnVoltarObra2 = new Button();
            btnHomeObra2 = new Button();
            lblNeilArmstrong = new Label();
            ((System.ComponentModel.ISupportInitialize)pcbxObra2).BeginInit();
            SuspendLayout();
            // 
            // pcbxObra2
            // 
            pcbxObra2.BackColor = Color.Transparent;
            pcbxObra2.Image = (Image)resources.GetObject("pcbxObra2.Image");
            pcbxObra2.Location = new Point(499, 12);
            pcbxObra2.Name = "pcbxObra2";
            pcbxObra2.Size = new Size(485, 485);
            pcbxObra2.SizeMode = PictureBoxSizeMode.Zoom;
            pcbxObra2.TabIndex = 47;
            pcbxObra2.TabStop = false;
            // 
            // lblObra2
            // 
            lblObra2.AutoEllipsis = true;
            lblObra2.BackColor = Color.Black;
            lblObra2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblObra2.ForeColor = Color.DarkGoldenrod;
            lblObra2.Location = new Point(240, 553);
            lblObra2.Name = "lblObra2";
            lblObra2.Size = new Size(1003, 79);
            lblObra2.TabIndex = 46;
            lblObra2.Text = "Neil A. Armstrong é provavelmente mais conhecido como o comandante da missão Apollo 11 da NASA à Lua, durante a qual se tornou a primeira pessoa a pisar na Lua em 20 de julho de 1969.";
            lblObra2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnListaAvaliacaoObra2
            // 
            btnListaAvaliacaoObra2.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
            btnListaAvaliacaoObra2.Image = Properties.Resources.botao_lista;
            btnListaAvaliacaoObra2.Location = new Point(961, 655);
            btnListaAvaliacaoObra2.Name = "btnListaAvaliacaoObra2";
            btnListaAvaliacaoObra2.Size = new Size(145, 145);
            btnListaAvaliacaoObra2.TabIndex = 45;
            btnListaAvaliacaoObra2.Text = "Lista de Avaliação";
            btnListaAvaliacaoObra2.TextAlign = ContentAlignment.BottomCenter;
            btnListaAvaliacaoObra2.UseVisualStyleBackColor = true;
            btnListaAvaliacaoObra2.Click += btnListaAvaliacaoObra2_Click;
            // 
            // btnProximoObra2
            // 
            btnProximoObra2.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            btnProximoObra2.Image = Properties.Resources.botao_direita;
            btnProximoObra2.Location = new Point(766, 655);
            btnProximoObra2.Name = "btnProximoObra2";
            btnProximoObra2.Size = new Size(145, 145);
            btnProximoObra2.TabIndex = 44;
            btnProximoObra2.Text = "Próximo";
            btnProximoObra2.TextAlign = ContentAlignment.BottomCenter;
            btnProximoObra2.UseVisualStyleBackColor = true;
            btnProximoObra2.Click += btnProximoObra2_Click;
            // 
            // btnVoltarObra2
            // 
            btnVoltarObra2.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            btnVoltarObra2.Image = Properties.Resources.botao_esquerda;
            btnVoltarObra2.Location = new Point(571, 656);
            btnVoltarObra2.Name = "btnVoltarObra2";
            btnVoltarObra2.Size = new Size(145, 145);
            btnVoltarObra2.TabIndex = 43;
            btnVoltarObra2.Text = "Voltar";
            btnVoltarObra2.TextAlign = ContentAlignment.BottomCenter;
            btnVoltarObra2.UseVisualStyleBackColor = true;
            btnVoltarObra2.Click += btnVoltarObra2_Click;
            // 
            // btnHomeObra2
            // 
            btnHomeObra2.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            btnHomeObra2.Image = Properties.Resources.botao_home;
            btnHomeObra2.Location = new Point(376, 655);
            btnHomeObra2.Name = "btnHomeObra2";
            btnHomeObra2.Size = new Size(145, 145);
            btnHomeObra2.TabIndex = 42;
            btnHomeObra2.Text = "Home";
            btnHomeObra2.TextAlign = ContentAlignment.BottomCenter;
            btnHomeObra2.UseVisualStyleBackColor = true;
            btnHomeObra2.Click += btnHomeObra2_Click;
            // 
            // lblNeilArmstrong
            // 
            lblNeilArmstrong.AutoSize = true;
            lblNeilArmstrong.BackColor = Color.Transparent;
            lblNeilArmstrong.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblNeilArmstrong.ForeColor = Color.DarkGoldenrod;
            lblNeilArmstrong.Location = new Point(630, 504);
            lblNeilArmstrong.Name = "lblNeilArmstrong";
            lblNeilArmstrong.Size = new Size(222, 32);
            lblNeilArmstrong.TabIndex = 48;
            lblNeilArmstrong.Text = "Neil A. Armstrong";
            // 
            // Obra2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Espaço__nasa_;
            ClientSize = new Size(1482, 853);
            Controls.Add(lblNeilArmstrong);
            Controls.Add(pcbxObra2);
            Controls.Add(lblObra2);
            Controls.Add(btnListaAvaliacaoObra2);
            Controls.Add(btnProximoObra2);
            Controls.Add(btnVoltarObra2);
            Controls.Add(btnHomeObra2);
            Name = "Obra2";
            Text = "Obra 2 - Neil A. Armstrong";
            ((System.ComponentModel.ISupportInitialize)pcbxObra2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pcbxObra2;
        private Label lblObra2;
        private Button btnListaAvaliacaoObra2;
        private Button btnProximoObra2;
        private Button btnVoltarObra2;
        private Button btnHomeObra2;
        private Label lblNeilArmstrong;
    }
}