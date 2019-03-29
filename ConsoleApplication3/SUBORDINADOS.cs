using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAD2C032919
{
    class SUBORDINADOS
    {
        public string primeiroNome;
        public string psobrenome;
        public float salarioPmes;
        public float aumento = 0.1f;

        public float AtualizacaoPromo()
        {
            return salarioPmes += aumento * salarioPmes;
        }
        public string DefinirNome(string nome)
        {    
            return primeiroNome = nome;
        }
        public string DefinirSobrenome(string sobrenome)
        {
            return psobrenome = sobrenome;
        }
        public float DefinirSalarioMensal(float Salario)
        {
            return salarioPmes = Salario;
        }
    }
}
