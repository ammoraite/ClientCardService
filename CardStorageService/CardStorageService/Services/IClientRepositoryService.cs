using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CardStorageService.Data;

namespace CardStorageService.Services
{
    public interface IClientRepositoryService:IRepository<Client,int>
    {
    }
}
