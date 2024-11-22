using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using ContactsAppApplication.Usecases;
using ContactsAppDomain.Entities;
using ContactsAppMaui.Messages;
using ContactsAppMaui.Pages.Contacts;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsAppMaui.Viewmodels.Contacts
{
    public partial class ContactsViewmodel : BaseViewmodel, IRecipient<ContactAdded>
    {
        private readonly UserUsecases _usecase;
        public ObservableCollection<ContactEntity> Contacts { get; } = new();
        [ObservableProperty]
        string filterText;
        public ContactsViewmodel(UserUsecases usecase)
        {
            _usecase = usecase;
            Title = "All Contacts";
            WeakReferenceMessenger.Default.Register<ContactAdded>(this);
        }

        [RelayCommand]
        public async Task FilterContact()
        {
            var _contacts = await _usecase.RetrieveAllContacts(FilterText);
            if (_contacts != null && _contacts.Count > 0)
            {
                Contacts.Clear();
                foreach (var contact in _contacts)
                {
                    Contacts.Add(contact);
                }
            }
        }
        [RelayCommand]
        public async Task LoadContacts()
        {
            var _contacts = await _usecase.RetrieveAllContacts();
            if (_contacts != null && _contacts.Count > 0)
            {
                Contacts.Clear();
                foreach (var contact in _contacts)
                {
                    Contacts.Add(contact);
                }
            }
            FilterText = "";
        }

        [RelayCommand]
        public async Task GotoEditContact(ContactEntity contact)
        {
            if (contact != null)
            {
                await Shell.Current.GoToAsync(
                    nameof(ContactEditPage),
                    true,
                    new Dictionary<string, object> { { "Contact", contact } }
                    );
            }
        }
        [RelayCommand]
        public async Task GotoAddContact() => await Shell.Current.GoToAsync(nameof(ContactAddPage));

        async void IRecipient<ContactAdded>.Receive(ContactAdded message)
        {
            await _usecase.CreateNewContact(message.Value);
        }
    }
}


