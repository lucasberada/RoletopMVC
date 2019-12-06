using System;
using System.Collections.Generic;
using RoletopMVC.Models;

namespace RoletopMVC.ViewModels
{
    public class PedidoViewModel : BaseViewModel
    {
        public string NomeUsuario {get;set;}
        public Cliente Cliente {get;set;}
        public DateTime DataDoEvento { get; set; }
        public string FormaPagamento {get;set;}
        public string LuzSom {get;set;}
        public string Descricao {get;set;}
        public string Pergunta {get;set;}


        public PedidoViewModel()
        {
            this.NomeUsuario = "Jovem";
            this.Cliente = new Cliente();
            this.DataDoEvento = DataDoEvento;
            this.FormaPagamento = FormaPagamento;
            this.LuzSom = LuzSom;
            this.Descricao = Descricao;
            this.Pergunta = Pergunta;

        }

    }
}



