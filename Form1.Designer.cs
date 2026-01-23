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
            removerToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            sairToolStripMenuItem = new ToolStripMenuItem();
            treinosToolStripMenuItem = new ToolStripMenuItem();
            adicionarToolStripMenuItem1 = new ToolStripMenuItem();
            removerToolStripMenuItem1 = new ToolStripMenuItem();
            exibirTToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripSeparator();
            sairToolStripMenuItem1 = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackgroundImageLayout = ImageLayout.Center;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { usuáriosToolStripMenuItem, treinosToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(927, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // usuáriosToolStripMenuItem
            // 
            usuáriosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { adicionarToolStripMenuItem, removerToolStripMenuItem, toolStripMenuItem1, sairToolStripMenuItem });
            usuáriosToolStripMenuItem.Name = "usuáriosToolStripMenuItem";
            usuáriosToolStripMenuItem.Size = new Size(79, 24);
            usuáriosToolStripMenuItem.Text = "Usuários";
            usuáriosToolStripMenuItem.Click += usuáriosToolStripMenuItem_Click;
            // 
            // adicionarToolStripMenuItem
            // 
            adicionarToolStripMenuItem.Name = "adicionarToolStripMenuItem";
            adicionarToolStripMenuItem.Size = new Size(224, 26);
            adicionarToolStripMenuItem.Text = "Adicionar";
            // 
            // removerToolStripMenuItem
            // 
            removerToolStripMenuItem.Name = "removerToolStripMenuItem";
            removerToolStripMenuItem.Size = new Size(224, 26);
            removerToolStripMenuItem.Text = "Remover";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(221, 6);
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(224, 26);
            sairToolStripMenuItem.Text = "Sair";
            // 
            // treinosToolStripMenuItem
            // 
            treinosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { adicionarToolStripMenuItem1, removerToolStripMenuItem1, exibirTToolStripMenuItem, toolStripMenuItem2, sairToolStripMenuItem1 });
            treinosToolStripMenuItem.Name = "treinosToolStripMenuItem";
            treinosToolStripMenuItem.Size = new Size(64, 24);
            treinosToolStripMenuItem.Text = "Treino";
            // 
            // adicionarToolStripMenuItem1
            // 
            adicionarToolStripMenuItem1.Name = "adicionarToolStripMenuItem1";
            adicionarToolStripMenuItem1.Size = new Size(224, 26);
            adicionarToolStripMenuItem1.Text = "Adicionar";
            // 
            // removerToolStripMenuItem1
            // 
            removerToolStripMenuItem1.Name = "removerToolStripMenuItem1";
            removerToolStripMenuItem1.Size = new Size(224, 26);
            removerToolStripMenuItem1.Text = "Remover";
            // 
            // exibirTToolStripMenuItem
            // 
            exibirTToolStripMenuItem.Name = "exibirTToolStripMenuItem";
            exibirTToolStripMenuItem.Size = new Size(224, 26);
            exibirTToolStripMenuItem.Text = "Editar treinos";
            exibirTToolStripMenuItem.Click += exibirTToolStripMenuItem_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(221, 6);
            // 
            // sairToolStripMenuItem1
            // 
            sairToolStripMenuItem1.Name = "sairToolStripMenuItem1";
            sairToolStripMenuItem1.Size = new Size(224, 26);
            sairToolStripMenuItem1.Text = "Sair";
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
        private ToolStripMenuItem removerToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem sairToolStripMenuItem;
        private ToolStripMenuItem treinosToolStripMenuItem;
        private ToolStripMenuItem adicionarToolStripMenuItem1;
        private ToolStripMenuItem removerToolStripMenuItem1;
        private ToolStripMenuItem exibirTToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem2;
        private ToolStripMenuItem sairToolStripMenuItem1;
    }
}
