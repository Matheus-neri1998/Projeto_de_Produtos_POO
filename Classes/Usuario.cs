using System;
namespace Projeto_de_Produtos_POO.Classes
{
    public class Usuario
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public DateTime DataCadastro { get; set; }
        
        public Usuario(){
            Cadastrar(); //Executa o primeiro método construtor Usuario
        }

        public Usuario(int code, string name, string _email, string password){
            // Executando o segundo método construtor Usuario

            Codigo = code;
            Nome = name;
            Email = _email;
            Senha = password;
            DataCadastro = DateTime.UtcNow;
        }
        
        public void Cadastrar(){
            // Inserindo os dados e efetuando o cadastro
            Nome = "Matheus";
            Email = "admin@gmail.com";
            Senha = "admin";
            DataCadastro = DateTime.Today; // 2020-12-22T11:11:10 => Mostra o horário neste formato

        } // fim do método construtor Cadastrar

        public void Deletar(){
            Nome = "";
            Email = "";
            Senha = "";
            DataCadastro = DateTime.Parse("");

        } // fim do método construtor Deletar
    }
}