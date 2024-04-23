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
            txbNomeCadastro = new TextBox();
            txbSobrenomeCadastro = new TextBox();
            cbxGenero = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            cbxFaixaEtaria = new ComboBox();
            btnFinalizarCadastro = new Button();
            lblPreenchaFormulario = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(326, 116);
            label1.Name = "label1";
            label1.Size = new Size(122, 20);
            label1.TabIndex = 0;
            label1.Text = "Digite seu nome ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(310, 199);
            label2.Name = "label2";
            label2.Size = new Size(155, 20);
            label2.TabIndex = 1;
            label2.Text = "Digite seu sobrenome";
            // 
            // txbNomeCadastro
            // 
            txbNomeCadastro.Location = new Point(191, 154);
            txbNomeCadastro.Margin = new Padding(3, 4, 3, 4);
            txbNomeCadastro.Name = "txbNomeCadastro";
            txbNomeCadastro.Size = new Size(392, 27);
            txbNomeCadastro.TabIndex = 2;
            // 
            // txbSobrenomeCadastro
            // 
            txbSobrenomeCadastro.Location = new Point(191, 237);
            txbSobrenomeCadastro.Margin = new Padding(3, 4, 3, 4);
            txbSobrenomeCadastro.Name = "txbSobrenomeCadastro";
            txbSobrenomeCadastro.Size = new Size(392, 27);
            txbSobrenomeCadastro.TabIndex = 3;
            // 
            // cbxGenero
            // 
            cbxGenero.FormattingEnabled = true;
            cbxGenero.Items.AddRange(new object[] { "Masculino", "Feminino" });
            cbxGenero.Location = new Point(318, 320);
            cbxGenero.Margin = new Padding(3, 4, 3, 4);
            cbxGenero.Name = "cbxGenero";
            cbxGenero.Size = new Size(138, 28);
            cbxGenero.TabIndex = 4;
            cbxGenero.Tag = "";
            cbxGenero.Text = "Sexo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(312, 282);
            label3.Name = "label3";
            label3.Size = new Size(150, 20);
            label3.TabIndex = 5;
            label3.Text = "Selecione seu genero";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(299, 366);
            label4.Name = "label4";
            label4.Size = new Size(177, 20);
            label4.TabIndex = 6;
            label4.Text = "Selecione sua faixa etaria";
            // 
            // cbxFaixaEtaria
            // 
            cbxFaixaEtaria.FormattingEnabled = true;
            cbxFaixaEtaria.Items.AddRange(new object[] { "6 a 12 anos", "13 a 18 anos", "18 a 24 anos", "24 ou mais" });
            cbxFaixaEtaria.Location = new Point(318, 404);
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
            // Formulario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(774, 548);
            Controls.Add(lblPreenchaFormulario);
            Controls.Add(btnFinalizarCadastro);
            Controls.Add(cbxFaixaEtaria);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(cbxGenero);
            Controls.Add(txbSobrenomeCadastro);
            Controls.Add(txbNomeCadastro);
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
        private TextBox txbNomeCadastro;
        private TextBox txbSobrenomeCadastro;
        private ComboBox cbxGenero;
        private Label label3;
        private Label label4;
        private ComboBox cbxFaixaEtaria;
        private Button btnFinalizarCadastro;
        private Label lblPreenchaFormulario;
    }
}