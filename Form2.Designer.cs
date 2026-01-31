namespace Projeto_academia_deMuayThai
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            labelNome = new Label();
            labelTreino = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            btnCadastrarTreino = new Button();
            btnRemoverTreino = new Button();
            SuspendLayout();
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.BackColor = Color.Transparent;
            labelNome.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelNome.ForeColor = Color.White;
            labelNome.Location = new Point(382, 43);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(172, 28);
            labelNome.TabIndex = 0;
            labelNome.Text = "Nome do Aluno: ";
            labelNome.Click += label1_Click;
            // 
            // labelTreino
            // 
            labelTreino.AutoEllipsis = true;
            labelTreino.AutoSize = true;
            labelTreino.BackColor = Color.Transparent;
            labelTreino.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTreino.ForeColor = Color.White;
            labelTreino.Location = new Point(379, 114);
            labelTreino.Name = "labelTreino";
            labelTreino.Size = new Size(175, 28);
            labelTreino.TabIndex = 1;
            labelTreino.Text = "Nome do Treino: ";
            labelTreino.Click += label2_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Blue;
            textBox1.Location = new Point(382, 74);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(170, 27);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.Yellow;
            textBox2.Location = new Point(377, 145);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(175, 27);
            textBox2.TabIndex = 3;
            // 
            // btnCadastrarTreino
            // 
            btnCadastrarTreino.BackColor = Color.Green;
            btnCadastrarTreino.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCadastrarTreino.ForeColor = Color.White;
            btnCadastrarTreino.Location = new Point(403, 191);
            btnCadastrarTreino.Name = "btnCadastrarTreino";
            btnCadastrarTreino.Size = new Size(119, 39);
            btnCadastrarTreino.TabIndex = 4;
            btnCadastrarTreino.Text = "Cadastrar";
            btnCadastrarTreino.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnCadastrarTreino.UseVisualStyleBackColor = false;
            // 
            // btnRemoverTreino
            // 
            btnRemoverTreino.BackColor = Color.Red;
            btnRemoverTreino.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRemoverTreino.ForeColor = Color.White;
            btnRemoverTreino.Location = new Point(403, 236);
            btnRemoverTreino.Name = "btnRemoverTreino";
            btnRemoverTreino.Size = new Size(119, 38);
            btnRemoverTreino.TabIndex = 5;
            btnRemoverTreino.Text = "Remover";
            btnRemoverTreino.UseVisualStyleBackColor = false;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Blue;
            BackgroundImage = Properties.Resources.Fundo_Form2;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRemoverTreino);
            Controls.Add(btnCadastrarTreino);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(labelTreino);
            Controls.Add(labelNome);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form2";
            Text = "Gerir Treinos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelNome;
        private Label labelTreino;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button btnCadastrarTreino;
        private Button btnRemoverTreino;
    }
}