using Projeto.Models;
using Microsoft.AspNetCore.Mvc;

namespace Projeto.ViewModel
{
    public class CarrinhoViewModel
    {
        public Carrinho Carrinho {get;set;}
        public double CarrinhoTotal{get;set;}
    }
}