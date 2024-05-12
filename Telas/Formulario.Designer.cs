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
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkGoldenrod;
            label1.Location = new Point(103, 181);
            label1.Name = "label1";
            label1.Size = new Size(176, 30);
            label1.TabIndex = 0;
            label1.Text = "Digite seu nome:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.DarkGoldenrod;
            label2.Location = new Point(103, 271);
            label2.Name = "label2";
            label2.Size = new Size(231, 30);
            label2.TabIndex = 1;
            label2.Text = "Digite seu sobrenome:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.DarkGoldenrod;
            label4.Location = new Point(103, 360);
            label4.Name = "label4";
            label4.Size = new Size(259, 30);
            label4.TabIndex = 6;
            label4.Text = "Selecione sua faixa etaria:";
            // 
            // cbxFaixaEtaria
            // 
            cbxFaixaEtaria.BackColor = Color.White;
            cbxFaixaEtaria.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            cbxFaixaEtaria.ForeColor = Color.Black;
            cbxFaixaEtaria.FormattingEnabled = true;
            cbxFaixaEtaria.Items.AddRange(new object[] { "6 a 12 anos", "13 a 18 anos", "18 a 24 anos", "24 ou mais" });
            cbxFaixaEtaria.Location = new Point(368, 357);
            cbxFaixaEtaria.Margin = new Padding(3, 4, 3, 4);
            cbxFaixaEtaria.Name = "cbxFaixaEtaria";
            cbxFaixaEtaria.Size = new Size(149, 38);
            cbxFaixaEtaria.TabIndex = 7;
            cbxFaixaEtaria.Text = "Faixa Etária";
            // 
            // btnFinalizarCadastro
            // 
            btnFinalizarCadastro.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnFinalizarCadastro.Location = new Point(1301, 672);
            btnFinalizarCadastro.Margin = new Padding(3, 4, 3, 4);
            btnFinalizarCadastro.Name = "btnFinalizarCadastro";
            btnFinalizarCadastro.Size = new Size(145, 145);
            btnFinalizarCadastro.TabIndex = 8;
            btnFinalizarCadastro.Text = "Finalizar / Pergunta 1";
            btnFinalizarCadastro.UseVisualStyleBackColor = true;
            btnFinalizarCadastro.Click += btnFinalizarCadastro_Click;
            // 
            // lblPreenchaFormulario
            // 
            lblPreenchaFormulario.AutoSize = true;
            lblPreenchaFormulario.BackColor = Color.Transparent;
            lblPreenchaFormulario.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblPreenchaFormulario.ForeColor = Color.DarkGoldenrod;
            lblPreenchaFormulario.Location = new Point(480, 68);
            lblPreenchaFormulario.Name = "lblPreenchaFormulario";
            lblPreenchaFormulario.Size = new Size(522, 32);
            lblPreenchaFormulario.TabIndex = 9;
            lblPreenchaFormulario.Text = "Preencha o formulario para avaliação do museu";
            // 
            // btnTecladoNome
            // 
            btnTecladoNome.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            btnTecladoNome.Location = new Point(1212, 174);
            btnTecladoNome.Name = "btnTecladoNome";
            btnTecladoNome.Size = new Size(167, 45);
            btnTecladoNome.TabIndex = 12;
            btnTecladoNome.Text = "Responder nome";
            btnTecladoNome.UseVisualStyleBackColor = true;
            btnTecladoNome.Click += btnTecladoNome_Click;
            // 
            // btnTecladoSobrenome
            // 
            btnTecladoSobrenome.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            btnTecladoSobrenome.Location = new Point(1212, 264);
            btnTecladoSobrenome.Name = "btnTecladoSobrenome";
            btnTecladoSobrenome.Size = new Size(167, 45);
            btnTecladoSobrenome.TabIndex = 13;
            btnTecladoSobrenome.Text = "Responder sobrenome";
            btnTecladoSobrenome.UseVisualStyleBackColor = true;
            btnTecladoSobrenome.Click += btnTecladoSobrenome_Click;
            // 
            // txbRespostaNome
            // 
            txbRespostaNome.BackColor = Color.White;
            txbRespostaNome.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txbRespostaNome.ForeColor = Color.Black;
            txbRespostaNome.Location = new Point(285, 178);
            txbRespostaNome.Margin = new Padding(3, 4, 3, 4);
            txbRespostaNome.Name = "txbRespostaNome";
            txbRespostaNome.ReadOnly = true;
            txbRespostaNome.Size = new Size(879, 36);
            txbRespostaNome.TabIndex = 14;
            // 
            // txbRespostaSobrenome
            // 
            txbRespostaSobrenome.BackColor = Color.White;
            txbRespostaSobrenome.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txbRespostaSobrenome.ForeColor = Color.Black;
            txbRespostaSobrenome.Location = new Point(340, 268);
            txbRespostaSobrenome.Margin = new Padding(3, 4, 3, 4);
            txbRespostaSobrenome.Name = "txbRespostaSobrenome";
            txbRespostaSobrenome.ReadOnly = true;
            txbRespostaSobrenome.Size = new Size(824, 36);
            txbRespostaSobrenome.TabIndex = 15;
            // 
            // btnSairFormulario
            // 
            btnSairFormulario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSairFormulario.Location = new Point(37, 672);
            btnSairFormulario.Margin = new Padding(3, 4, 3, 4);
            btnSairFormulario.Name = "btnSairFormulario";
            btnSairFormulario.Size = new Size(145, 145);
            btnSairFormulario.TabIndex = 16;
            btnSairFormulario.Text = "Sair do formulário";
            btnSairFormulario.UseVisualStyleBackColor = true;
            btnSairFormulario.Click += btnSairFormulario_Click;
            // 
            // Formulario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Espaço__nasa_;
            ClientSize = new Size(1482, 853);
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
        private Button btnTecladoNome;
        private Button btnTecladoSobrenome;
        private TextBox txbRespostaNome;
        private TextBox txbRespostaSobrenome;
        private Button btnSairFormulario;
    }
}