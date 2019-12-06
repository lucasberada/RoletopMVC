using System;
using RoletopMVC.Enums;
using RoletopMVC.Models;
using RoletopMVC.Repositories;
using RoletopMVC.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RoletopMVC.Controllers;

namespace RoletopMVC.Controllers {
    public class PedidoController : AbstractController {
        PedidoRepository pedidoRepository = new PedidoRepository ();

        ClienteRepository clienteRepository = new ClienteRepository();

        public IActionResult Index()
        {
            return View(new BaseViewModel()
            {
                NomeView = "Pedido",
                UsuarioEmail = ObterUsuarioSession(),
                UsuarioNome = ObterUsuarioNomeSession()
            });
        }

        public IActionResult RegistrarPedido(IFormCollection form)
        {
            ViewData["Action"] = "Pedido";
            try
            {
                Pedido pedido = new Pedido()
                {
                    Descricao=form["discricao"],
                    FormaPagamento= form["forma_pagamento"],
                    Pergunta = form["pergunta"],
                    LuzSom = form["ls"],
                    DataDoEvento = DateTime.Parse(form["data_evento"]),
                    };

                pedidoRepository.Inserir(pedido);

               return View("Sucesso", new RespostaViewModel()
                {
                    NomeView = "Pedido",
                    UsuarioEmail = ObterUsuarioSession(),
                    UsuarioNome = ObterUsuarioNomeSession()
                    
                });
            }
            catch (Exception e)
            {
                 System.Console.WriteLine(e.StackTrace);
                return View("Erro", new RespostaViewModel()
                {
                    NomeView = "Pedido",
                    UsuarioEmail = ObterUsuarioSession(),
                    UsuarioNome = ObterUsuarioNomeSession()
                });
        }
       
        }

    }
}




