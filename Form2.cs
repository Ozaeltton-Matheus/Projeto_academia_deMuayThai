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
        List<Aluno> listaDeAlunos = new List<Aluno>();

        public object DataGridView1 { get; private set; }

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

        public void btnCadastrarTreino_Click(object sender, EventArgs e)
        {
            var aluno = new Aluno();
            aluno.Nome = textBoxNomeAluno.Text;
            aluno.Treino = textBoxNomeTreino.Text;
            // Aqui estou pegando o conteúdo digitado nas caixas de texto onde ficam o nome do aluno e o treino
            // E estou atribuindo ás propriedades do objeto aluno


            // MessageBox.Show(aluno.JsonSerializar(aluno));

            // Serializando no arquivo.json lá na pasta documentos

            // Adicionando o objeto na lista que foi criada lá encima.
            listaDeAlunos.Add(aluno);

            dataGridViewTesteNoForm2.DataSource = null;
            dataGridViewTesteNoForm2.DataSource = listaDeAlunos;





            try
            {
                using (StreamWriter sw = new StreamWriter(@"C:\Users\Windows Falido\Documents\dados_da_academia_de_muaythai\arquivo.json"))
                {
                    sw.WriteLine(aluno.JsonSerializar(aluno));
                }
                MessageBox.Show("Arquivo salvo com sucesso!");
                // Depois de salvar o arquivo, o .Clear limpa os campos do formulário
                textBoxNomeAluno.Clear();
                textBoxNomeTreino.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha: " + ex.Message);
            }
        }

        private void btnRemoverTreino_Click(object sender, EventArgs e)
        {

            try
            {
                var strJson = "";
                using (StreamReader sr = new StreamReader(@"C:\Users\Windows Falido\Documents\dados_da_academia_de_muaythai\arquivo.json"))
                {
                    strJson = sr.ReadToEnd();
                }
                // Aqui o método está desserializando a string que ele leu.
                var aluno = Aluno.JsonDesserializar(strJson);

                textBoxNomeAluno.Text = aluno.Nome;
                textBoxNomeTreino.Text = aluno.Treino;
                // DEvolve o objeto Aluno tem essas propriedades que são da classe aluno
                // Está pegando as propriedades e atribuindo ao textBox
                // O método vai preencher o formulário com os dados do arquivo.json
            }

            catch (Exception ex)
            {

            }
        }

        private void textBoxNomeAluno_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private class dataGridViewForm3
        {
            public static List<Aluno>? DataSource { get; internal set; }
        }
    }
}
