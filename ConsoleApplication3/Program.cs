using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAD2C032919
{
    class Program
    {      
        static void Main(string[] args)
        {
            SUBORDINADOS promovido = new SUBORDINADOS();
            Console.WriteLine("Parabéns você foi PRO-MO-VI-DO!!!");
            Console.Write("Escreva o seu primeiro nome:");
            string nome = Console.ReadLine();
            promovido.DefinirNome(nome);
        }
    }
}
