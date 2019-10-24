using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioNotaPAD
{
    abstract class Pessoa
    {
        protected string nome;
        protected int idade;

        public Pessoa(string n, int i){
            this.nome = n;
            this.idade = i;
        }

        abstract protected string Trabalhar();

        public string GetNome(){
            return nome;
        }
        public void SetNome(string n){
            this.nome = n;
        }
        public int GetIdade(){
            return idade;
        }
        public void SetIdade(int i){
            this.idade = i;
        }
    }
}
