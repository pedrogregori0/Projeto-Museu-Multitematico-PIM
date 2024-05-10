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
            btnTecladoNome = new Button();
            btnTecladoSobrenome = new Button();
            txbRespostaNome = new TextBox();
            txbRespostaSobrenome = new TextBox();
            btnSairFormulario = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(47, 136);
            label1.Name = "label1";
            label1.Size = new Size(121, 20);
            label1.TabIndex = 0;
            label1.Text = "Digite seu nome:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(47, 203);
            label2.Name = "label2";
            label2.Size = new Size(158, 20);
            label2.TabIndex = 1;
            label2.Text = "Digite seu sobrenome:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(47, 270);
            label4.Name = "label4";
            label4.Size = new Size(180, 20);
            label4.TabIndex = 6;
            label4.Text = "Selecione sua faixa etaria:";
            // 
            // cbxFaixaEtaria
            // 
            cbxFaixaEtaria.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            cbxFaixaEtaria.FormattingEnabled = true;
            cbxFaixaEtaria.Items.AddRange(new object[] { "6 a 12 anos", "13 a 18 anos", "18 a 24 anos", "24 ou mais" });
            cbxFaixaEtaria.Location = new Point(233, 266);
            cbxFaixaEtaria.Name = "cbxFaixaEtaria";
            cbxFaixaEtaria.Size = new Size(121, 28);
            cbxFaixaEtaria.TabIndex = 7;
            cbxFaixaEtaria.Text = "Faixa Etária";
            // 
            // btnFinalizarCadastro
            // 
            btnFinalizarCadastro.Location = new Point(716, 427);
            btnFinalizarCadastro.Name = "btnFinalizarCadastro";
            btnFinalizarCadastro.Size = new Size(121, 83);
            btnFinalizarCadastro.TabIndex = 8;
            btnFinalizarCadastro.Text = "Finalizar/ Pergunta 1";
            btnFinalizarCadastro.UseVisualStyleBackColor = true;
            btnFinalizarCadastro.Click += btnFinalizarCadastro_Click;
            // 
            // lblPreenchaFormulario
            // 
            lblPreenchaFormulario.AutoSize = true;
            lblPreenchaFormulario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPreenchaFormulario.Location = new Point(272, 51);
            lblPreenchaFormulario.Name = "lblPreenchaFormulario";
            lblPreenchaFormulario.Size = new Size(341, 21);
            lblPreenchaFormulario.TabIndex = 9;
            lblPreenchaFormulario.Text = "Preencha o formulario para avaliação do museu";
            // 
            // btnTecladoNome
            // 
            btnTecladoNome.Location = new Point(691, 129);
            btnTecladoNome.Margin = new Padding(3, 2, 3, 2);
            btnTecladoNome.Name = "btnTecladoNome";
            btnTecladoNome.Size = new Size(146, 34);
            btnTecladoNome.TabIndex = 12;
            btnTecladoNome.Text = "Responder nome";
            btnTecladoNome.UseVisualStyleBackColor = true;
            btnTecladoNome.Click += btnTecladoNome_Click;
            // 
            // btnTecladoSobrenome
            // 
            btnTecladoSobrenome.Location = new Point(691, 196);
            btnTecladoSobrenome.Margin = new Padding(3, 2, 3, 2);
            btnTecladoSobrenome.Name = "btnTecladoSobrenome";
            btnTecladoSobrenome.Size = new Size(146, 34);
            btnTecladoSobrenome.TabIndex = 13;
            btnTecladoSobrenome.Text = "Responder sobrenome";
            btnTecladoSobrenome.UseVisualStyleBackColor = true;
            btnTecladoSobrenome.Click += btnTecladoSobrenome_Click;
            // 
            // txbRespostaNome
            // 
            txbRespostaNome.BackColor = SystemColors.ControlLightLight;
            txbRespostaNome.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txbRespostaNome.Location = new Point(174, 133);
            txbRespostaNome.Name = "txbRespostaNome";
            txbRespostaNome.ReadOnly = true;
            txbRespostaNome.Size = new Size(498, 27);
            txbRespostaNome.TabIndex = 14;
            // 
            // txbRespostaSobrenome
            // 
            txbRespostaSobrenome.BackColor = SystemColors.ControlLightLight;
            txbRespostaSobrenome.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txbRespostaSobrenome.Location = new Point(211, 200);
            txbRespostaSobrenome.Name = "txbRespostaSobrenome";
            txbRespostaSobrenome.ReadOnly = true;
            txbRespostaSobrenome.Size = new Size(461, 27);
            txbRespostaSobrenome.TabIndex = 15;
            // 
            // btnSairFormulario
            // 
            btnSairFormulario.Location = new Point(47, 427);
            btnSairFormulario.Name = "btnSairFormulario";
            btnSairFormulario.Size = new Size(121, 83);
            btnSairFormulario.TabIndex = 16;
            btnSairFormulario.Text = "Sair do formulário";
            btnSairFormulario.UseVisualStyleBackColor = true;
            btnSairFormulario.Click += btnSairFormulario_Click;
            // 
            // Formulario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 561);
            Controls.Add(btnSairFormulario);
            Controls.Add(txbRespostaSobrenome);
            Controls.Add(txbRespostaNome);
            Controls.Add(btnTecladoSobrenome);
            Controls.Add(btnTecladoNome);
            Controls.Add(lblPreenchaFormulario);
            Controls.Add(btnFinalizarCadastro);
            Controls.Add(cbxFaixaEtaria);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
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
        private Button btnTecladoNome;
        private Button btnTecladoSobrenome;
        private TextBox txbRespostaNome;
        private TextBox txbRespostaSobrenome;
        private Button btnSairFormulario;
    }
}