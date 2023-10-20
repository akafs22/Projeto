using Microsoft.EntityFrameworkCore;
using Projeto.Context;
using Projeto.Models;

namespace Projeto.Repositories.Interfaces
{
    public class ItemRepository : IItemRepository
    {
        private readonly AppDbContext _context;
        public ItemRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Item> Itens => _context.Itens.Include(c =>
        c.Categoria);
        public IEnumerable<Item> ItensEmDestaque =>
        _context.Itens.Where(m => m.Destaque).Include(c => c.Categoria);

    


        public Item GetItemById(int itemId)
        {
            return _context.Itens.FirstOrDefault(m => m.ItemId == itemId);
        }

        public Item GetItemById()
        {
            throw new NotImplementedException();
        }
    }
}