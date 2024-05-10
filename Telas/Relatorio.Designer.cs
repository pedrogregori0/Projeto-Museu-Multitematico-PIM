namespace Projeto_Museu_Multitematico_PIM
{
    partial class Relatorio
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
            lblFimQuestionario = new Label();
            lblRespostasPessoa = new Label();
            btnSairRelatorio = new Button();
            lblRespotaRelatorio = new Label();
            lblObrigadoVisita = new Label();
            lblTotalVisitantes = new Label();
            lblMedias1e2 = new Label();
            lblMedias3e4 = new Label();
            SuspendLayout();
            // 
            // lblFimQuestionario
            // 
            lblFimQuestionario.AutoSize = true;
            lblFimQuestionario.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            lblFimQuestionario.Location = new Point(504, 24);
            lblFimQuestionario.Name = "lblFimQuestionario";
            lblFimQuestionario.Size = new Size(342, 46);
            lblFimQuestionario.TabIndex = 0;
            lblFimQuestionario.Text = "Fim do questionário";
            lblFimQuestionario.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblRespostasPessoa
            // 
            lblRespostasPessoa.AutoSize = true;
            lblRespostasPessoa.Font = new Font("Segoe UI Semibold", 17.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblRespostasPessoa.Location = new Point(14, 168);
            lblRespostasPessoa.Name = "lblRespostasPessoa";
            lblRespostasPessoa.Size = new Size(147, 40);
            lblRespostasPessoa.TabIndex = 1;
            lblRespostasPessoa.Text = "Respostas";
            // 
            // btnSairRelatorio
            // 
            btnSairRelatorio.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnSairRelatorio.Location = new Point(1190, 567);
            btnSairRelatorio.Name = "btnSairRelatorio";
            btnSairRelatorio.Size = new Size(113, 123);
            btnSairRelatorio.TabIndex = 2;
            btnSairRelatorio.Text = "Sair";
            btnSairRelatorio.UseVisualStyleBackColor = true;
            btnSairRelatorio.Click += btnSairRelatorio_Click;
            // 
            // lblRespotaRelatorio
            // 
            lblRespotaRelatorio.AutoSize = true;
            lblRespotaRelatorio.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblRespotaRelatorio.Location = new Point(14, 238);
            lblRespotaRelatorio.Name = "lblRespotaRelatorio";
            lblRespotaRelatorio.Size = new Size(0, 25);
            lblRespotaRelatorio.TabIndex = 3;
            // 
            // lblObrigadoVisita
            // 
            lblObrigadoVisita.AutoSize = true;
            lblObrigadoVisita.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblObrigadoVisita.Location = new Point(480, 107);
            lblObrigadoVisita.Name = "lblObrigadoVisita";
            lblObrigadoVisita.Size = new Size(402, 35);
            lblObrigadoVisita.TabIndex = 4;
            lblObrigadoVisita.Text = "Obrigado pela visita, volte sempre!";
            // 
            // lblTotalVisitantes
            // 
            lblTotalVisitantes.AutoSize = true;
            lblTotalVisitantes.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotalVisitantes.Location = new Point(762, 174);
            lblTotalVisitantes.Name = "lblTotalVisitantes";
            lblTotalVisitantes.Size = new Size(180, 28);
            lblTotalVisitantes.TabIndex = 5;
            lblTotalVisitantes.Text = "Total de visitantes:";
            // 
            // lblMedias1e2
            // 
            lblMedias1e2.AutoSize = true;
            lblMedias1e2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblMedias1e2.Location = new Point(574, 240);
            lblMedias1e2.Name = "lblMedias1e2";
            lblMedias1e2.Size = new Size(0, 23);
            lblMedias1e2.TabIndex = 6;
            // 
            // lblMedias3e4
            // 
            lblMedias3e4.AutoSize = true;
            lblMedias3e4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblMedias3e4.Location = new Point(868, 240);
            lblMedias3e4.Name = "lblMedias3e4";
            lblMedias3e4.Size = new Size(0, 23);
            lblMedias3e4.TabIndex = 7;
            // 
            // Relatorio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1362, 748);
            Controls.Add(lblMedias3e4);
            Controls.Add(lblMedias1e2);
            Controls.Add(lblTotalVisitantes);
            Controls.Add(lblObrigadoVisita);
            Controls.Add(lblRespotaRelatorio);
            Controls.Add(btnSairRelatorio);
            Controls.Add(lblRespostasPessoa);
            Controls.Add(lblFimQuestionario);
            Name = "Relatorio";
            Text = "Relatorio";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFimQuestionario;
        private Label lblRespostasPessoa;
        private Button btnSairRelatorio;
        private Label lblRespotaRelatorio;
        private Label lblObrigadoVisita;
        private Label lblTotalVisitantes;
        private Label lblMedias1e2;
        private Label lblMedias3e4;
    }
}