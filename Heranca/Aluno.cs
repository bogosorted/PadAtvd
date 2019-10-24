using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioNotaPAD
{
    class Aluno : Pessoa
    {
        private string curso;

        protected override string Trabalhar()
        {
            return "Estudando";
        }

        public Aluno(string n, int i, string c) : base(n,i){
            this.curso = c;
        }

        public string GetCurso(){
            return curso;
        }
        public void SetCurso(string c){
            this.curso = c;
        }
    }
}
