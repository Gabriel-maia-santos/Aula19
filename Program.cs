using System;

namespace Aula19
{
    class Program
    {
        static void Main(string[] args)
        {
            IngressoVip vip = new IngressoVip();
            vip.IngressoPreco = 23.90f;
            vip.ImprimirValor();
            vip.AdicionarValor();

           Console.WriteLine("A diferença de valores é: ");

        }
    }
}
