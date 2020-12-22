using System;
using System.Collections.Generic;

namespace Projeto_de_Produtos_POO.Classes
{
    public class Marca
    {
        public int Codigo {get; set;} // Declarando método

        public string NomeMarca { get; set; } 

        public DateTime DataCadastro { get; set; } // Objeto DateTime

        public List<Marca> ListaDeMarcas = new List<Marca>(); // Instanciando a Lista de Marca

        public Marca Cadastrar(){
            // A partir daqui fazendo um cadastro da marca de algum produto

            Marca novaMarca = new Marca(); // Instanciando nova marca


            Console.WriteLine("Digite o código da marca: "); // Mostrando e pedindo o código da marca
            novaMarca.Codigo = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o nome da marca desejada: "); // Mostrando e pedindo o nome da marca
            novaMarca.NomeMarca = Console.ReadLine();

            DataCadastro = DateTime.UtcNow; // Mostrando o horário que foi efetuado o cadastro

            ListaDeMarcas.Add(novaMarca); // Adicionando uma nova marca na lista

            return novaMarca; 

        } // Fim de Cadastrar


        public void Listar(){

            Console.ForegroundColor = ConsoleColor.Red; // Exibir as informações com uma coloração no terminal

            foreach (Marca pertence in ListaDeMarcas)
            {
                Console.WriteLine($"Código: {pertence.Codigo}");
                Console.WriteLine($"Marca: {pertence.NomeMarca}");
                Console.WriteLine($"Data do cadastro: {pertence.DataCadastro}");
                
                // Listando em ordem o cadastro da Marca, usando código; nome; data
            }

            Console.ResetColor(); // Voltar à cor padrão
        }

        // internal static Marca Cadastrar()
        // {
        //     throw new NotImplementedException();
        // }

        public void Deletar(int cod){

            Marca marcaDelete = ListaDeMarcas.Find(m => m.Codigo == cod); // Procurando uma marca e deletando se houver um código

            ListaDeMarcas.Remove(marcaDelete); // Removendo uma marca
        }
    }
}