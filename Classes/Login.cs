using System;

namespace Projeto_de_Produtos_POO.Classes
{
    public class Login
    {
        public bool Logado {get; set;}

        public Login(){
            Logar();

            if (Logado == true){
                GerarMenu();
            }
        }

        public void GerarMenu(){

            Produto product = new Produto();
            Marca marca = new Marca();

            string opcao = "n";

            do{

                Console.ForegroundColor = ConsoleColor.Green;

                Console.WriteLine("Escolha uma opção abaixo: ");
                Console.WriteLine("1 - Cadastrar Marca ");
                Console.WriteLine("2 - Listar Marca ");
                Console.WriteLine("3 - Excluir Marca ");
                Console.WriteLine("4 - Cadastrar Produto ");
                Console.WriteLine("5 - Listar Produto" );
                Console.WriteLine("6 - Excluir Produto ");
                Console.WriteLine("0 - Sair ");

                Console.ResetColor();

                opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        marca.Cadastrar(); // Cadastrando a marca
                        break;
                    case "2":
                        marca.Listar(); // Listando a marca
                        break;

                    case "3":
                        Console.WriteLine("Digite um código para excluir a marca: ");
                        int codigo = int.Parse(Console.ReadLine());
                        marca.Deletar(codigo); // Excluindo a marca
                        break;

                    case "4":
                        product.Cadastrar();
                        break; // Cadastrando o produto

                    case "5":
                        product.Listar();
                        break; // Listando o produto

                    case "6":
                         Console.WriteLine("Digite um código para excluir o produto: ");
                        int codigoProduto = int.Parse(Console.ReadLine());
                        product.Deletar(codigoProduto); // Excluindo o produto
                        break;

                    default:
                        break;
                }
                


            } while (opcao != "0");
        }
        public void Logar(){
            Usuario user = new Usuario();

            Console.WriteLine("Digite o seu email: ");
            string emailLogin = Console.ReadLine();

            Console.WriteLine("Digite sua senha: ");
            string senhaLogin = Console.ReadLine();

            if(emailLogin == user.Email && senhaLogin == user.Senha){

                Logado = true;
                Console.WriteLine("Login efetuado com sucesso!"); 
            }else{
                Console.WriteLine("Falha ao realizar o login. Tente novamente!");
            }
        }

        public void Deslogar(){
            Logado = false;
        }


        
    }
}