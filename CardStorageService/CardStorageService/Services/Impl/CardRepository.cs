using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CardStorageService.Data;

namespace CardStorageService.Services.Impl
{
    public class CardRepository: ICardRepositoryService
    {
        private readonly CardStorageServiceDbContext _context;
        private readonly ILogger<CardRepository> _logger;
        public CardRepository
            ( CardStorageServiceDbContext context,
            ILogger<CardRepository> logger )
        {
            _context=context;
            _logger=logger;
        }

        public string Create ( Card data )
        {
            throw new NotImplementedException ( );
        }

        public int Delete ( string id )
        {
            throw new NotImplementedException ( );
        }

        public IList<Card> GetAll ( )
        {
            throw new NotImplementedException ( );
        }

        public IList<Card> GetByClientId ( string clientId )
        {
            throw new NotImplementedException ( );
        }

        public Card GetById ( string id )
        {
            throw new NotImplementedException ( );
        }

        public int Update ( Card data )
        {
            throw new NotImplementedException ( );
        }
    }
}
