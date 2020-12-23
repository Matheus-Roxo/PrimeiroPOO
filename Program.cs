using System;

namespace PrimeiroPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Personagem objetoPersonagem1 = new Personagem();

            objetoPersonagem1.nome = "Batman";
            objetoPersonagem1.idade = 37;
            objetoPersonagem1.armadura = "Força";

            Personagem objetoPersonagem2 = new Personagem();

            objetoPersonagem2.nome = "Superman";
            objetoPersonagem2.idade = 29;
            objetoPersonagem2.armadura = "Força";

            Console.WriteLine($"Personagem 1 = {objetoPersonagem1.nome} - {objetoPersonagem1.Atacar()}");
            Console.WriteLine($"Personagem 2 = {objetoPersonagem2.nome} - {objetoPersonagem2.Atacar()}");
        }
    }
}
