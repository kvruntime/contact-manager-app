using ContactsAppDomain.Entities;
using ContactsAppDomain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsAppInfrastructure
{
    public class InMemoryContactStore : IContactRepository
    {
        List<ContactEntity> contacts = new()
        {
            new ContactEntity{Firstname="Viktor", Email="viktor@gmail.com", Address="Agoe", Phone="99999999"},
            new ContactEntity{Firstname="Espoir", Email="espoir@proton.me", Address="Cotonou", Phone="79797979"},
            new ContactEntity{Firstname="Jean", Email="jean@proton.me", Address="There", Phone="98989898"},
        };

        public async Task Add(ContactEntity entity)
        {
            contacts.Add(entity);
        }

        public async Task<ContactEntity>? Get(Guid id)
        {
            return contacts.FirstOrDefault(c => c.Id == id);
        }

        public async Task<List<ContactEntity>> GetAll()
        {
            return contacts;
        }

        public Task Remove(ContactEntity entity)
        {
            throw new NotImplementedException();
        }

        public async Task Save()
        {
            return;
        }

        public Task Update(Guid id, ContactEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
