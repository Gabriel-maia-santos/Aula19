using System;

namespace Aula19
{
    public class IngressoVip
    {
        public float IngressoPreco {get; set;}
        public float valorAdicional = 50.0f;

        public void AdicionarValor(){
            float newValor = IngressoPreco + valorAdicional;
            Console.WriteLine("O valor do Vip é: {0:c}",newValor);
        }

        internal void ImprimirValor()
        {
            throw new NotImplementedException();
        }
    }
}