using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IRepo<T, Id, Crt>
    {
        List<T> Gets();
        T Get(Id id);
        Crt Create(T obj);
        bool Update(T obj);
        bool Delete(Id id);
    }
}
