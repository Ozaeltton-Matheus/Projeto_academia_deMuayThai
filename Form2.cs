using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Projeto_academia_deMuayThai
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastrarTreino_Click(object sender, EventArgs e)
        {
            var aluno = new Aluno();
            aluno.Nome = textBoxNomeAluno.Text;
            aluno.Treino = textBoxNomeTreino.Text;
            // Aqui estou pegando o conteúdo digitado nas caixas de texto onde ficam o nome do aluno e o treino
            // E estou atribuindo ás propriedades do objeto aluno


            // MessageBox.Show(aluno.JsonSerializar(aluno));

            try
            {
                using (StreamWriter sw = new StreamWriter(@"C:\Users\Windows Falido\Documents\dados_da_academia_de_muaythai\arquivo.json"))
                {
                    sw.WriteLine(aluno.JsonSerializar(aluno));
                }
                MessageBox.Show("Arquivo salvo com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha: " + ex.Message);
            }
        }
    }
}
