using ContactsAppDomain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsAppDomain.Interfaces
{
    public interface IContactRepository : IRepository<ContactEntity> 
    {
    }
}
