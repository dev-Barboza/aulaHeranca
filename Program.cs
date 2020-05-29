using System;

namespace Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            
            CPF cpf = new CPF();
            cpf.nome = " Matheus";
            Console.WriteLine( cpf.Saudar() );

            cpf.cpf = "111.111.111-11";
            Console.WriteLine( cpf.ValidarCPF() );

        


        }
    }
}