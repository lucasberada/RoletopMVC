using System;

namespace RoletopMVC.Models
{
    public class Cliente
    {
        public string Nome { get; set; }
        public string RG { get; set; }
        public string CPF { get; set; }
        public string Senha { get; set; }
        public string Email { get; set; }
        public DateTime Idade { get; set; }



        public Cliente()
        {
            
        }

        public Cliente(string nome, string email, string cpf,string rg, string senha, DateTime idade)
        {
            this.Nome = nome;
            this.RG = rg;
            this.CPF = cpf;
            this.Senha = senha;
            this.Email = email;
            this.Idade = idade;
        }

    }

    
}