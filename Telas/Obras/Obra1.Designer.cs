﻿namespace Projeto_Museu_Multitematico_PIM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Obra1));
            btnListaAvaliacaoObra1 = new Button();
            btnProximoObra1 = new Button();
            btnVoltarObra1 = new Button();
            btnHomeObra1 = new Button();
            lblObra1 = new Label();
            pcbxObra1 = new PictureBox();
            lblApollo11 = new Label();
            ((System.ComponentModel.ISupportInitialize)pcbxObra1).BeginInit();
            SuspendLayout();
            // 
            // btnListaAvaliacaoObra1
            // 
            btnListaAvaliacaoObra1.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
            btnListaAvaliacaoObra1.Image = Properties.Resources.botao_lista;
            btnListaAvaliacaoObra1.Location = new Point(961, 655);
            btnListaAvaliacaoObra1.Name = "btnListaAvaliacaoObra1";
            btnListaAvaliacaoObra1.Size = new Size(145, 145);
            btnListaAvaliacaoObra1.TabIndex = 39;
            btnListaAvaliacaoObra1.Text = "Lista de Avaliação";
            btnListaAvaliacaoObra1.TextAlign = ContentAlignment.BottomCenter;
            btnListaAvaliacaoObra1.UseVisualStyleBackColor = true;
            btnListaAvaliacaoObra1.Click += btnListaAvaliacaoObra1_Click;
            // 
            // btnProximoObra1
            // 
            btnProximoObra1.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            btnProximoObra1.Image = Properties.Resources.botao_direita;
            btnProximoObra1.Location = new Point(766, 655);
            btnProximoObra1.Name = "btnProximoObra1";
            btnProximoObra1.Size = new Size(145, 145);
            btnProximoObra1.TabIndex = 38;
            btnProximoObra1.Text = "Próximo";
            btnProximoObra1.TextAlign = ContentAlignment.BottomCenter;
            btnProximoObra1.UseVisualStyleBackColor = true;
            btnProximoObra1.Click += btnProximoObra1_Click;
            // 
            // btnVoltarObra1
            // 
            btnVoltarObra1.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            btnVoltarObra1.Image = Properties.Resources.botao_esquerda;
            btnVoltarObra1.Location = new Point(571, 656);
            btnVoltarObra1.Name = "btnVoltarObra1";
            btnVoltarObra1.Size = new Size(145, 145);
            btnVoltarObra1.TabIndex = 37;
            btnVoltarObra1.Text = "Voltar";
            btnVoltarObra1.TextAlign = ContentAlignment.BottomCenter;
            btnVoltarObra1.UseVisualStyleBackColor = true;
            btnVoltarObra1.Click += btnVoltarObra1_Click;
            // 
            // btnHomeObra1
            // 
            btnHomeObra1.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            btnHomeObra1.Image = Properties.Resources.botao_home;
            btnHomeObra1.Location = new Point(376, 655);
            btnHomeObra1.Name = "btnHomeObra1";
            btnHomeObra1.Size = new Size(145, 145);
            btnHomeObra1.TabIndex = 36;
            btnHomeObra1.Text = "Home";
            btnHomeObra1.TextAlign = ContentAlignment.BottomCenter;
            btnHomeObra1.UseVisualStyleBackColor = true;
            btnHomeObra1.Click += btnHomeObra1_Click;
            // 
            // lblObra1
            // 
            lblObra1.AutoEllipsis = true;
            lblObra1.BackColor = Color.Transparent;
            lblObra1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblObra1.ForeColor = Color.DarkGoldenrod;
            lblObra1.Location = new Point(240, 553);
            lblObra1.Name = "lblObra1";
            lblObra1.Size = new Size(1003, 79);
            lblObra1.TabIndex = 40;
            lblObra1.Text = "O objetivo principal da Apollo 11 era completar uma meta nacional estabelecida pelo presidente John F. Kennedy em 25 de maio de 1961: realizar um pouso lunar tripulado e retornar à Terra.";
            lblObra1.TextAlign = ContentAlignment.MiddleLeft;
            lblObra1.UseMnemonic = false;
            // 
            // pcbxObra1
            // 
            pcbxObra1.BackColor = Color.Transparent;
            pcbxObra1.BorderStyle = BorderStyle.FixedSingle;
            pcbxObra1.Image = (Image)resources.GetObject("pcbxObra1.Image");
            pcbxObra1.Location = new Point(499, 12);
            pcbxObra1.Name = "pcbxObra1";
            pcbxObra1.Size = new Size(485, 485);
            pcbxObra1.SizeMode = PictureBoxSizeMode.Zoom;
            pcbxObra1.TabIndex = 41;
            pcbxObra1.TabStop = false;
            // 
            // lblApollo11
            // 
            lblApollo11.AutoSize = true;
            lblApollo11.BackColor = Color.Transparent;
            lblApollo11.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblApollo11.ForeColor = Color.DarkGoldenrod;
            lblApollo11.Location = new Point(682, 504);
            lblApollo11.Name = "lblApollo11";
            lblApollo11.Size = new Size(118, 32);
            lblApollo11.TabIndex = 42;
            lblApollo11.Text = "Apolo 11";
            // 
            // Obra1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Espaço__nasa_;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1482, 853);
            Controls.Add(lblApollo11);
            Controls.Add(pcbxObra1);
            Controls.Add(lblObra1);
            Controls.Add(btnListaAvaliacaoObra1);
            Controls.Add(btnProximoObra1);
            Controls.Add(btnVoltarObra1);
            Controls.Add(btnHomeObra1);
            Name = "Obra1";
            Text = "Obra 1 - Apollo 11";
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
        private Label lblApollo11;
    }
}