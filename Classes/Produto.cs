using System;
using System.Collections.Generic;

namespace Projeto_de_Produtos_POO.Classes
{
    public class Produto
    {
        public int Codigo {get; set;}
        public string NomeProduto{get; set;}
        public float Preco {get; set;}
        public DateTime DataCadastro {get; set;}
        public object Usuario { get; private set; }

        public Marca Marca = new Marca();

        public Usuario User = new Usuario();
        public List<Produto> ListaDeProdutos = new List<Produto>();

        public void Cadastrar(){ // Fazendo o cadastro do produto, utilizando o método construtor
            Produto novoProduto = new Produto();

            Console.WriteLine("Digite o código do produto: ");
            novoProduto.Codigo = int.Parse(Console.ReadLine()); // Pedindo o código do produto

            Console.WriteLine("Digite o nome do produto: ");
            novoProduto.NomeProduto = Console.ReadLine(); // Pedindo o nome do produto

            Console.WriteLine("Digite o preço do produto: ");
            novoProduto.Preco = float.Parse(Console.ReadLine()); // Pedindo o preço do produto

            DataCadastro = DateTime.UtcNow;

            // Chamamos um método do objeto/propriedade "Marca"
            novoProduto.Marca = Marca.Cadastrar();

            // Utilizamos o próprio método construtor para atribuir um objeto completo de "Usuário"
            novoProduto.User = new Usuario();

            ListaDeProdutos.Add(novoProduto); // Adicioando produto

        }

        public void Listar(){

            Console.ForegroundColor = ConsoleColor.Blue;

            foreach (Produto item in ListaDeProdutos)
            {
                Console.WriteLine($"Código: {item.Codigo}");
                Console.WriteLine($"Produto: {item.NomeProduto}");
                Console.WriteLine($"Preço: {item.Preco}");
                Console.WriteLine($"Data do Cadastro: {item.DataCadastro}");
                Console.WriteLine($"Marca: {item.Marca.NomeMarca}");
                Console.WriteLine($"Cadastrado por: {item.User.Nome}");
            }
            
            Console.ResetColor();
        }

        public void Deletar(int cod){
            Produto prodDelete = ListaDeProdutos.Find(p => p.Codigo == cod);
            ListaDeProdutos.Remove(prodDelete);

        }
    }
}