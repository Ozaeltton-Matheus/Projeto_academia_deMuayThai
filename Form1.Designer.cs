namespace Projeto_academia_deMuayThai
{
    partial class nome_do_app
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(nome_do_app));
            menuStrip1 = new MenuStrip();
            usuáriosToolStripMenuItem = new ToolStripMenuItem();
            adicionarToolStripMenuItem = new ToolStripMenuItem();
            treinosToolStripMenuItem = new ToolStripMenuItem();
            verTreinosToolStripMenuItem = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackgroundImageLayout = ImageLayout.Center;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { usuáriosToolStripMenuItem, treinosToolStripMenuItem, sairToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(927, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // usuáriosToolStripMenuItem
            // 
            usuáriosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { adicionarToolStripMenuItem });
            usuáriosToolStripMenuItem.Name = "usuáriosToolStripMenuItem";
            usuáriosToolStripMenuItem.Size = new Size(106, 24);
            usuáriosToolStripMenuItem.Text = "Gerir Treinos";
            usuáriosToolStripMenuItem.Click += usuáriosToolStripMenuItem_Click;
            // 
            // adicionarToolStripMenuItem
            // 
            adicionarToolStripMenuItem.Name = "adicionarToolStripMenuItem";
            adicionarToolStripMenuItem.Size = new Size(263, 26);
            adicionarToolStripMenuItem.Text = "&Cadastrar/Remover treino";
            adicionarToolStripMenuItem.Click += adicionarToolStripMenuItem_Click;
            // 
            // treinosToolStripMenuItem
            // 
            treinosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { verTreinosToolStripMenuItem });
            treinosToolStripMenuItem.Name = "treinosToolStripMenuItem";
            treinosToolStripMenuItem.Size = new Size(128, 24);
            treinosToolStripMenuItem.Text = "&Verificar Treinos";
            // 
            // verTreinosToolStripMenuItem
            // 
            verTreinosToolStripMenuItem.Name = "verTreinosToolStripMenuItem";
            verTreinosToolStripMenuItem.Size = new Size(164, 26);
            verTreinosToolStripMenuItem.Text = "&Ver Treinos";
            verTreinosToolStripMenuItem.Click += verTreinosToolStripMenuItem_Click;
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(48, 24);
            sairToolStripMenuItem.Text = "&Sair";
            sairToolStripMenuItem.Click += sairToolStripMenuItem_Click;
            // 
            // nome_do_app
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuHighlight;
            BackgroundImage = Properties.Resources.Fundo;
            ClientSize = new Size(927, 549);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "nome_do_app";
            Text = "NAK MUAY THAY SPORTS";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem usuáriosToolStripMenuItem;
        private ToolStripMenuItem adicionarToolStripMenuItem;
        private ToolStripMenuItem treinosToolStripMenuItem;
        private ToolStripMenuItem verTreinosToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
    }
}
