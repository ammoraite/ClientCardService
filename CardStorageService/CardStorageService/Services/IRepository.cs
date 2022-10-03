using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardStorageService.Services
{
    public interface IRepository<T,Tid>
    {
        IList<T> GetAll ( );

        T GetById (Tid id);

        Tid Create ( T data );

        int Update ( T data );

        int Delete ( Tid id );

    }
}
