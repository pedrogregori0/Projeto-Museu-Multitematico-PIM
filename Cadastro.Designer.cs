namespace Projeto_Museu_Multitematico_PIM
{
    partial class Cadastro
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            comboBox1 = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            comboBox2 = new ComboBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(66, 55);
            label1.Name = "label1";
            label1.Size = new Size(96, 15);
            label1.TabIndex = 0;
            label1.Text = "Digite seu nome ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(66, 101);
            label2.Name = "label2";
            label2.Size = new Size(122, 15);
            label2.TabIndex = 1;
            label2.Text = "Digite seu sobrenome";
            label2.Click += label2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(66, 73);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(66, 119);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 3;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Masculino", "Feminino" });
            comboBox1.Location = new Point(66, 186);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(66, 168);
            label3.Name = "label3";
            label3.Size = new Size(118, 15);
            label3.TabIndex = 5;
            label3.Text = "Selecione seu genero";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(66, 243);
            label4.Name = "label4";
            label4.Size = new Size(138, 15);
            label4.TabIndex = 6;
            label4.Text = "Selecione sua faixa etaria";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "6 a 12 anos", "13 a 18 anos", "18 a 24 anos", "24 ou mais" });
            comboBox2.Location = new Point(67, 261);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 7;
            // 
            // button1
            // 
            button1.Location = new Point(283, 310);
            button1.Name = "button1";
            button1.Size = new Size(107, 66);
            button1.TabIndex = 8;
            button1.Text = "Finalizar/ Pergunta 1";
            button1.UseVisualStyleBackColor = true;
            // 
            // Cadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(677, 411);
            Controls.Add(button1);
            Controls.Add(comboBox2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(comboBox1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Cadastro";
            Text = "Cadastro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private ComboBox comboBox1;
        private Label label3;
        private Label label4;
        private ComboBox comboBox2;
        private Button button1;
    }
}