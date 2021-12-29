using System;
using System.Collections.Generic;
using System.Linq;

namespace Desafio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
                Usuario _usuario = new Usuario();
                Console.Write("Informe o Nome do usuario: ");
                _usuario.Nome = Convert.ToString(Console.ReadLine());
                Console.Write("Informe a Data de nascimento do usuario: ");
                _usuario.DataDeNascimento = Convert.ToString(Console.ReadLine());
                Console.Write("Informe a Altura do usuario: ");
                _usuario.Altura = Convert.ToString(Console.ReadLine());

                Casa _casa = new Casa();
                Console.Write("Informe a Cor da casa: ");
                _casa.Cor = Convert.ToString(Console.ReadLine());
                Console.Write("Informe o Numero da casa: ");
                _casa.Numero = Convert.ToString(Console.ReadLine());
                Console.Write("Informe o Endereco da casa: ");
                _casa.Endereco = Convert.ToString(Console.ReadLine());

                Carro _carro = new Carro();
                Console.Write("Informe a Cor do carro: ");
                _carro.Cor = Convert.ToString(Console.ReadLine());
                Console.Write("Informe as Portas do carro: ");
                _carro.Portas = Convert.ToString(Console.ReadLine());
                Console.Write("Informe o Combustivel do carro: ");
                _carro.Combustivel = Convert.ToString(Console.ReadLine());

               
            
                Console.WriteLine(_usuario.Nome);
                Console.WriteLine(_usuario.DataDeNascimento);
                Console.WriteLine(_usuario.Altura);
                
            
           
            
                Console.WriteLine(_casa.Cor);
                Console.WriteLine(_casa.Numero);
                Console.WriteLine(_casa.Endereco);
                
            
            
            
                Console.WriteLine(_carro.Cor);
                Console.WriteLine(_carro.Portas);
                Console.WriteLine(_carro.Combustivel);
                
            
            Console.ReadKey();
        }
    }
}
