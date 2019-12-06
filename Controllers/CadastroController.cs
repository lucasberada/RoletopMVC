using System;
using RoletopMVC.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RoletopMVC.Models;
using RoletopMVC.ViewModels;
using RoletopMVC.Controllers;

namespace RoletopMVC.Controllers
{
        public class CadastroController : AbstractController
    {
        ClienteRepository clienteRepository = new ClienteRepository();

        public IActionResult Index()
        {
                return View(new BaseViewModel()
            {
                NomeView = "Cadastro",
                UsuarioEmail = ObterUsuarioSession(),
                UsuarioNome = ObterUsuarioNomeSession()
            });        }

        public IActionResult CadastrarCliente(IFormCollection form)
        {
            ViewData["Action"] = "Cadastro";
            try
            {
                Cliente cliente = new Cliente(
                    form["nome"],
                    form["email"],
                    form["cpf"],
                    form["rg"],
                    form["senha"],
                    DateTime.Parse(form["idade"]));

                clienteRepository.Inserir(cliente);

               return View("Sucesso", new RespostaViewModel()
                {
                    NomeView = "Cadastro",
                    UsuarioEmail = ObterUsuarioSession(),
                    UsuarioNome = ObterUsuarioNomeSession()
                    
                });
            }
            catch (Exception e)
            {
                 System.Console.WriteLine(e.StackTrace);
                return View("Erro", new RespostaViewModel()
                {
                    NomeView = "Cadastro",
                    UsuarioEmail = ObterUsuarioSession(),
                    UsuarioNome = ObterUsuarioNomeSession()
                });
            }
        }
       
    }
}
