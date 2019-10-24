using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioNotaPAD
{
    class Professor : Pessoa
    {
        private string disciplina;

        protected override string Trabalhar()
        {
            return "Ensinando";
        }
        public Professor(string n, int i, string d) : base(n,i){
            this.disciplina = d; 
        }

        public string Disciplina{
            get{
                return disciplina;
            }
            set{
                this.disciplina = value;
            }
        }
    }
}
