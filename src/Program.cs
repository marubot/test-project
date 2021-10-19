using System;

namespace ProjetoFinal
{
    class Program
    {
        static void Main(string[] args)
        {
            Identifier identifier;

            Console.WriteLine("Olá! Digite uma string a ser validada:");
            string inputString = Console.ReadLine(); 
            identifier = new Identifier(inputString);
            
            if(identifier.ValidateIdentifier())
                Console.WriteLine("Valido");
            else 
                Console.Write("Invalido");
         }
    }
}
