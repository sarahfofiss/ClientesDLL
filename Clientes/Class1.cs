using System;

namespace Clientes
{
    public class Cliente
    {
        public string nome;
        public double cpf;
        public double cep;
        public string pet;
        public double telefone;
        public string email;

        public void cadastrarCliente()
        {
            Console.WriteLine("Digite seu nome");
            nome = Console.ReadLine();
            Console.WriteLine("Digite o CPF");
            cpf = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o CEP");
            cep = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o nome do seu Pet");
            pet = Console.ReadLine();
            Console.WriteLine("Digite o Telefone");
            telefone = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o email");
            email = Console.ReadLine();


        }
    }
}
