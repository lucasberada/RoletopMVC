using System;
using RoletopMVC.Enums;

namespace RoletopMVC.Models
{
    public class Pedido
    {
        public ulong Id {get;set;}
        public Cliente Cliente {get;set;}

        public DateTime DataDoEvento {get;set;}
        public uint Status {get;set;}

        public string FormaPagamento {get;set;}
        public string LuzSom {get;set;}
        public string Descricao {get;set;}
        public string Pergunta {get;set;}



        public Pedido()
        {
            this.Cliente = new Cliente();
            this.DataDoEvento = DataDoEvento;
            this.FormaPagamento = FormaPagamento;
            this.LuzSom = LuzSom;
            this.Descricao = Descricao;
            this.Pergunta = Pergunta;
            this.Id = 0;
            this.Status = (uint) StatusPedido.PENDENTE; 
        }
    }
}