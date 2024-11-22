using ContactsAppDomain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsAppDomain.Interfaces
{
    public interface IRepository<T> where T : BaseEntity
    {
        public Task Add(T entity);
        public Task<T>? Get(Guid id);
        public Task<List<T>> GetAll();
        public Task Remove(T entity);
        public Task Update(Guid id, T entity);
        public Task Save();
    }
}
