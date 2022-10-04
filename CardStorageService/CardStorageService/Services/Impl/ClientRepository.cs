using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CardStorageService.Data;

namespace CardStorageService.Services.Impl
{
    public class ClientRepository : IClientRepositoryService
    {
        private readonly CardStorageServiceDbContext _context;
        private readonly ILogger<ClientRepository> _logger;
        public ClientRepository 
            (CardStorageServiceDbContext context, 
            ILogger<ClientRepository> logger )
        {
            _context=context;
            _logger=logger;
        }

        
        public int Create ( Client data )
        {
            throw new NotImplementedException ( );
        }

        public int Delete ( int id )
        {
            throw new NotImplementedException ( );
        }

        public IList<Client> GetAll ( )
        {
            throw new NotImplementedException ( );
        }

        public Client GetById ( int id )
        {
            throw new NotImplementedException ( );
        }

        public int Update ( Client data )
        {
            throw new NotImplementedException ( );
        }
    }
}
