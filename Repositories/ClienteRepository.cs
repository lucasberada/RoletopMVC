using System;
using System.IO;
using RoletopMVC.Models;

namespace RoletopMVC.Repositories
{
    public class ClienteRepository : RepositoryBase
    {
         private const string PATH = "Database/Cliente.csv";
        
        public ClienteRepository()
        {
            if (!File.Exists(PATH))
            {
                File.Create(PATH).Close();
            }
        }


        public bool Inserir(Cliente cliente)
        {
            var linha = new string[] { PrepararRegistroCSV(cliente) };
            File.AppendAllLines(PATH, linha);

            return true;
        }

        public Cliente ObterPor(string email)
        {
            var linhas = File.ReadAllLines(PATH);
            foreach (var item in linhas)
            {
                if (ExtrairValorDoCampo("email", item).Equals(email))
                {
                    Cliente c = new Cliente();
                    c.Nome = ExtrairValorDoCampo("nome", item);
                    c.Email = ExtrairValorDoCampo("email", item);
                    c.Idade = DateTime.Parse(ExtrairValorDoCampo("idade", item));
                    c.RG = ExtrairValorDoCampo("rg", item);
                    c.CPF = ExtrairValorDoCampo("cpf", item);
                    c.Senha = ExtrairValorDoCampo("senha", item);

                    return c;
                }

            }
            return null;
        }
        private string PrepararRegistroCSV(Cliente cliente)
        {
            return $"nome={cliente.Nome};email={cliente.Email};senha={cliente.Senha};cpf={cliente.CPF};rg={cliente.RG};idade={cliente.Idade}";
        }
    }
}
