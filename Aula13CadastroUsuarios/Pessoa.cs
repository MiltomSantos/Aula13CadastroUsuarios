using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula13CadastroUsuarios
{
    internal class Pessoa
    {
        public string nome;
        public int idade;
        public string rua;
        public string cidade;

        public Pessoa(string nome2, int idade2, string rua2, string cidade2) 
        {
            this.nome = nome2;
            this.idade = idade2;
            this.rua = rua2;
            this.cidade = cidade2;
        }
    }
}
