using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioNotaPAD
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno p1 = new Aluno("João Gabriel", 14, "Programação de Jogos");
            Professor p2 = new Professor("Francisco", 32, "Lógica de Programação");

            Console.WriteLine("Nome: {0}\nIdade: {1}\nCurso {2}\n", p1.GetNome(), p1.GetIdade(), p1.GetCurso());
            Console.WriteLine("Nome: {0}\nIdade: {1}\nCurso {2}\n", p2.GetNome(), p2.GetIdade(), p2.Disciplina);
        }
    }
}
