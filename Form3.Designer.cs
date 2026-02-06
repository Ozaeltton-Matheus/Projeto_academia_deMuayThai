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
            dataGridViewForm3 = new DataGridView();
            btnRemoverAluno = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewForm3).BeginInit();
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
            textBoxPesquisarAluno.Size = new Size(503, 34);
            textBoxPesquisarAluno.TabIndex = 2;
            // 
            // dataGridViewForm3
            // 
            dataGridViewForm3.BackgroundColor = Color.Black;
            dataGridViewForm3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewForm3.GridColor = Color.White;
            dataGridViewForm3.Location = new Point(14, 82);
            dataGridViewForm3.Name = "dataGridViewForm3";
            dataGridViewForm3.RowHeadersWidth = 51;
            dataGridViewForm3.Size = new Size(763, 356);
            dataGridViewForm3.TabIndex = 3;
            dataGridViewForm3.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnRemoverAluno
            // 
            btnRemoverAluno.BackColor = Color.Red;
            btnRemoverAluno.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRemoverAluno.ForeColor = Color.White;
            btnRemoverAluno.Location = new Point(533, 22);
            btnRemoverAluno.Name = "btnRemoverAluno";
            btnRemoverAluno.Size = new Size(119, 40);
            btnRemoverAluno.TabIndex = 4;
            btnRemoverAluno.Text = "Remover";
            btnRemoverAluno.UseVisualStyleBackColor = false;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            BackgroundImage = Properties.Resources.Fundo_Form3;
            ClientSize = new Size(926, 450);
            Controls.Add(btnRemoverAluno);
            Controls.Add(dataGridViewForm3);
            Controls.Add(textBoxPesquisarAluno);
            Controls.Add(btnPesquisarAluno);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form3";
            Text = "Exibir treinos";
            Load += Form3_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewForm3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnPesquisarAluno;
        private TextBox textBoxPesquisarAluno;
        private DataGridView dataGridViewForm3;
        private Button btnRemoverAluno;
    }
}