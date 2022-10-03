using Microsoft.EntityFrameworkCore;

namespace CardStorageService.Data
{
    public class CardStorageServiceDbContext : DbContext
    {
        public CardStorageServiceDbContext (DbContextOptions options ):base(options)
        {

        }
    }
}
