using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Projeto_academia_deMuayThai
{
    internal class Aluno
    {
        public String ?Nome { get; set; }
        public String ?Treino { get; set; }

        public String JsonSerializar(Aluno aluno)
        {
            return JsonConvert.SerializeObject(aluno);
            // Esse método recebe um objeto Aluno, serializa e devolve uma String Json pra quem chamar o método JsonSerializar
        }


        // Tava dando erro de que era necessário ter um retorno e eu adicionei o void
        public static Object  JsonDeserializar(String Json)
        {
            return JsonConvert.DeserializeObject<Aluno>(Json);
        }

    }
}
