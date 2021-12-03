using System;
using CSharp;
using Interface;
using Enum;

namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // usando o enum
            var pessoa1 = (Pessoas)0;
            Pessoas pessoa2 = Pessoas.Julia;
            Pessoas pessoa3 = (Pessoas)1;

            // usando a classe
            var person = new Pessoa();
            person.Nome = "Gabriel";
            person.Idade = 19;
            person.Estado = "SP";

            var person2 = new Pessoa();
            person2.Nome = "Vieira";
            person2.Idade = 21;
            person2.Estado = "PR";

            // usando a classe com interface
            Animal animal = new Animal();
            animal.Nome = "Dody";
            animal.NomeDono = "eu";
            animal.Especie = "vira lata";
            
            Console.WriteLine(pessoa3);
              
        }
    }
}