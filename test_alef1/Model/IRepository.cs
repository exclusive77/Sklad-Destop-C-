using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_alef1.Model
{
    interface IRepository<T> where T : class
    {
        void Update(T item);
        void Delete(int id);
        void Create(T item);
        T Get(int id);
        IEnumerable<T> GetAll();
        IEnumerable<T> GetAll(Func<T, bool> predicate);
    }
}
