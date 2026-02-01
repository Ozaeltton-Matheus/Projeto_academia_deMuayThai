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
            textBoxNomeAluno = new TextBox();
            textBoxNomeTreino = new TextBox();
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
            // textBoxNomeAluno
            // 
            textBoxNomeAluno.BackColor = Color.Black;
            textBoxNomeAluno.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxNomeAluno.ForeColor = Color.White;
            textBoxNomeAluno.Location = new Point(382, 74);
            textBoxNomeAluno.Name = "textBoxNomeAluno";
            textBoxNomeAluno.Size = new Size(170, 34);
            textBoxNomeAluno.TabIndex = 2;
            // 
            // textBoxNomeTreino
            // 
            textBoxNomeTreino.BackColor = Color.Black;
            textBoxNomeTreino.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxNomeTreino.ForeColor = Color.White;
            textBoxNomeTreino.Location = new Point(377, 145);
            textBoxNomeTreino.Name = "textBoxNomeTreino";
            textBoxNomeTreino.Size = new Size(175, 34);
            textBoxNomeTreino.TabIndex = 3;
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
            btnCadastrarTreino.Click += btnCadastrarTreino_Click;
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
            Controls.Add(textBoxNomeTreino);
            Controls.Add(textBoxNomeAluno);
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
        private TextBox textBoxNomeAluno;
        private TextBox textBoxNomeTreino;
        private Button btnCadastrarTreino;
        private Button btnRemoverTreino;
    }
}