using ContactsAppDomain.Entities;
using ContactsAppDomain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsAppApplication.Usecases
{
    public class UserUsecases
    {
        private readonly IContactRepository _contactRepo;

        public UserUsecases(IContactRepository contactRepo)
        {
            _contactRepo = contactRepo;
        }
        public async Task<List<ContactEntity>> RetrieveAllContacts(string? filterText = null)
        {
            var contacts = await _contactRepo.GetAll();
            if (filterText is null) return contacts;

            var filteredContacts = contacts.Where(c => !String.IsNullOrWhiteSpace(c.Firstname) && c.Firstname.StartsWith(filterText, StringComparison.OrdinalIgnoreCase)).ToList();
            if (filteredContacts is null || filteredContacts.Count <= 0)
                return contacts;
            return filteredContacts;
        }
        public async Task<ContactEntity>? RetrieveContactInformations(Guid id)
        {
            return await _contactRepo.Get(id);
        }
        public async Task CreateNewContact(ContactEntity contact)
        {
            await _contactRepo.Add(contact);
        }
        public async Task DeleteContact(ContactEntity contact)
        {
            await _contactRepo.Remove(contact);
        }
    }
}
