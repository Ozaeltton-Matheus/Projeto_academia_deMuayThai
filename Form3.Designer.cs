namespace Projeto_academia_deMuayThai
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            btnPesquisarAluno = new Button();
            textBoxPesquisarAluno = new TextBox();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnPesquisarAluno
            // 
            btnPesquisarAluno.BackColor = Color.Green;
            btnPesquisarAluno.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPesquisarAluno.ForeColor = Color.White;
            btnPesquisarAluno.Location = new Point(658, 20);
            btnPesquisarAluno.Name = "btnPesquisarAluno";
            btnPesquisarAluno.Size = new Size(119, 45);
            btnPesquisarAluno.TabIndex = 1;
            btnPesquisarAluno.Text = "Pesquisar";
            btnPesquisarAluno.UseVisualStyleBackColor = false;
            btnPesquisarAluno.Click += button1_Click;
            // 
            // textBoxPesquisarAluno
            // 
            textBoxPesquisarAluno.BackColor = Color.Black;
            textBoxPesquisarAluno.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxPesquisarAluno.ForeColor = Color.White;
            textBoxPesquisarAluno.Location = new Point(14, 25);
            textBoxPesquisarAluno.Name = "textBoxPesquisarAluno";
            textBoxPesquisarAluno.Size = new Size(638, 34);
            textBoxPesquisarAluno.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.Black;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = Color.White;
            dataGridView1.Location = new Point(14, 82);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(763, 356);
            dataGridView1.TabIndex = 3;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            BackgroundImage = Properties.Resources.Fundo_Form3;
            ClientSize = new Size(789, 450);
            Controls.Add(dataGridView1);
            Controls.Add(textBoxPesquisarAluno);
            Controls.Add(btnPesquisarAluno);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form3";
            Text = "Exibir treinos";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnPesquisarAluno;
        private TextBox textBoxPesquisarAluno;
        private DataGridView dataGridView1;
    }
}