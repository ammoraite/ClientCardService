using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CardStorageService.Data;

namespace CardStorageService.Services
{
    public interface ICardRepositoryService:IRepository<Card,string>
    {
        IList<Card> GetByClientId(string clientId);
    }
}
