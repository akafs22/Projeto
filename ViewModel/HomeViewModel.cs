using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Projeto.Models;

namespace Projeto.ViewModel
{
    public class HomeViewModel
    {
        public IEnumerable<Item> ItensEmDestaque{get;set;}
    }
}