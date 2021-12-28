using System;
using System.Collections.Generic;
using System.Linq;

namespace Desafio3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Usuario> usuarios = new List<Usuario>();
            List<Casa> casas = new List<Casa>();
            List<Carro> carros = new List<Carro>();
            {
                Usuario _usuario = new Usuario();
                Console.Write("Informe o Nome do usuario: ");
                _usuario.Nome = Convert.ToString(Console.ReadLine());
                Console.Write("Informe a Data de nascimento do usuario: ");
                _usuario.DataDeNascimento = Convert.ToString(Console.ReadLine());
                Console.Write("Informe a Altura do usuario: ");
                _usuario.Altura = Convert.ToString(Console.ReadLine());

                usuarios.Add(_usuario);

                Casa _casa = new Casa();
                Console.Write("Informe a Cor da casa: ");
                _casa.Cor = Convert.ToString(Console.ReadLine());
                Console.Write("Informe o Numero da casa: ");
                _casa.Numero = Convert.ToString(Console.ReadLine());
                Console.Write("Informe o Endereco da casa: ");
                _casa.Endereco = Convert.ToString(Console.ReadLine());

                casas.Add(_casa);

                Carro _carro = new Carro();
                Console.Write("Informe a Cor do carro: ");
                _carro.Cor = Convert.ToString(Console.ReadLine());
                Console.Write("Informe as Portas do carro: ");
                _carro.Portas = Convert.ToString(Console.ReadLine());
                Console.Write("Informe o Combustivel do carro: ");
                _carro.Combustivel = Convert.ToString(Console.ReadLine());

                carros.Add(_carro);
            }

            foreach (Usuario _u in usuarios.OrderBy(n => n.Nome))
            {
                Console.WriteLine(_u.Nome);
                Console.WriteLine(_u.DataDeNascimento);
                Console.WriteLine(_u.Altura);
                
            }
            foreach (Casa _c in casas.OrderBy(n => n.Cor))
            {
                Console.WriteLine(_c.Cor);
                Console.WriteLine(_c.Numero);
                Console.WriteLine(_c.Endereco);
                
            }
            foreach (Carro _r in carros.OrderBy(n => n.Cor))
            {
                Console.WriteLine(_r.Cor);
                Console.WriteLine(_r.Portas);
                Console.WriteLine(_r.Combustivel);
                
            }
            Console.ReadKey();
        }
    }
}
