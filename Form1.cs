namespace Projeto_academia_deMuayThai
{
    public partial class nome_do_app : Form
    {
        public nome_do_app()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Remover_usuario_Click(object sender, EventArgs e)
        {

        }

        private void exibirTToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void usuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja sair?", "Fechar aplicativo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Close();
            }

        }

        private void adicionarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
            // O Show mostra o outro formulário e permite que você também interaja com o formulário principal
            // já o ShowDialog abre o outro formulário e bloqueia a interação com o formulário principal até que o outro formulário seja dechado.
        }

        private void verTreinosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.ShowDialog();
        }
    }
}
