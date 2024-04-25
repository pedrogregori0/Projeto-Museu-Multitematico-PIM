namespace Projeto_Museu_Multitematico_PIM
{
    partial class Formulario
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
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            cbxFaixaEtaria = new ComboBox();
            btnFinalizarCadastro = new Button();
            lblPreenchaFormulario = new Label();
            lblRespostaSobrenome = new Label();
            lblRespostaNome = new Label();
            btnTecladoNome = new Button();
            btnTecladoSobrenome = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 112);
            label1.Name = "label1";
            label1.Size = new Size(122, 20);
            label1.TabIndex = 0;
            label1.Text = "Digite seu nome ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(54, 198);
            label2.Name = "label2";
            label2.Size = new Size(155, 20);
            label2.TabIndex = 1;
            label2.Text = "Digite seu sobrenome";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(54, 284);
            label4.Name = "label4";
            label4.Size = new Size(177, 20);
            label4.TabIndex = 6;
            label4.Text = "Selecione sua faixa etaria";
            // 
            // cbxFaixaEtaria
            // 
            cbxFaixaEtaria.FormattingEnabled = true;
            cbxFaixaEtaria.Items.AddRange(new object[] { "6 a 12 anos", "13 a 18 anos", "18 a 24 anos", "24 ou mais" });
            cbxFaixaEtaria.Location = new Point(251, 281);
            cbxFaixaEtaria.Margin = new Padding(3, 4, 3, 4);
            cbxFaixaEtaria.Name = "cbxFaixaEtaria";
            cbxFaixaEtaria.Size = new Size(138, 28);
            cbxFaixaEtaria.TabIndex = 7;
            cbxFaixaEtaria.Text = "Faixa Etária";
            // 
            // btnFinalizarCadastro
            // 
            btnFinalizarCadastro.Location = new Point(611, 425);
            btnFinalizarCadastro.Margin = new Padding(3, 4, 3, 4);
            btnFinalizarCadastro.Name = "btnFinalizarCadastro";
            btnFinalizarCadastro.Size = new Size(122, 88);
            btnFinalizarCadastro.TabIndex = 8;
            btnFinalizarCadastro.Text = "Finalizar/ Pergunta 1";
            btnFinalizarCadastro.UseVisualStyleBackColor = true;
            btnFinalizarCadastro.Click += btnFinalizarCadastro_Click;
            // 
            // lblPreenchaFormulario
            // 
            lblPreenchaFormulario.AutoSize = true;
            lblPreenchaFormulario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPreenchaFormulario.Location = new Point(174, 31);
            lblPreenchaFormulario.Name = "lblPreenchaFormulario";
            lblPreenchaFormulario.Size = new Size(426, 28);
            lblPreenchaFormulario.TabIndex = 9;
            lblPreenchaFormulario.Text = "Preencha o formulario para avaliação do museu";
            // 
            // lblRespostaSobrenome
            // 
            lblRespostaSobrenome.AutoSize = true;
            lblRespostaSobrenome.Location = new Point(210, 198);
            lblRespostaSobrenome.Name = "lblRespostaSobrenome";
            lblRespostaSobrenome.Size = new Size(21, 20);
            lblRespostaSobrenome.TabIndex = 10;
            lblRespostaSobrenome.Text = "R:";
            lblRespostaSobrenome.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblRespostaNome
            // 
            lblRespostaNome.AutoSize = true;
            lblRespostaNome.Location = new Point(174, 112);
            lblRespostaNome.Name = "lblRespostaNome";
            lblRespostaNome.Size = new Size(21, 20);
            lblRespostaNome.TabIndex = 11;
            lblRespostaNome.Text = "R:";
            lblRespostaNome.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnTecladoNome
            // 
            btnTecladoNome.Location = new Point(595, 112);
            btnTecladoNome.Name = "btnTecladoNome";
            btnTecladoNome.Size = new Size(167, 29);
            btnTecladoNome.TabIndex = 12;
            btnTecladoNome.Text = "Responder nome";
            btnTecladoNome.UseVisualStyleBackColor = true;
            btnTecladoNome.Click += btnTecladoNome_Click;
            // 
            // btnTecladoSobrenome
            // 
            btnTecladoSobrenome.Location = new Point(595, 189);
            btnTecladoSobrenome.Name = "btnTecladoSobrenome";
            btnTecladoSobrenome.Size = new Size(167, 29);
            btnTecladoSobrenome.TabIndex = 13;
            btnTecladoSobrenome.Text = "Responder sobrenome";
            btnTecladoSobrenome.UseVisualStyleBackColor = true;
            // 
            // Formulario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(774, 548);
            Controls.Add(btnTecladoSobrenome);
            Controls.Add(btnTecladoNome);
            Controls.Add(lblRespostaNome);
            Controls.Add(lblRespostaSobrenome);
            Controls.Add(lblPreenchaFormulario);
            Controls.Add(btnFinalizarCadastro);
            Controls.Add(cbxFaixaEtaria);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Formulario";
            Text = "Formulário ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label4;
        private ComboBox cbxFaixaEtaria;
        private Button btnFinalizarCadastro;
        private Label lblPreenchaFormulario;
        private Label lblRespostaSobrenome;
        private Label lblRespostaNome;
        private Button btnTecladoNome;
        private Button btnTecladoSobrenome;
    }
}