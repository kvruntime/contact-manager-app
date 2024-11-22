using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using ContactsAppDomain.Entities;
using ContactsAppMaui.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsAppMaui.Viewmodels.Contacts
{
    public partial class ContactAddViewmodel : BaseViewmodel
    {
        [ObservableProperty]
        ContactEntity newContact;
        public ContactAddViewmodel()
        {
            Title = "Add new contact ➕";
        }

        [RelayCommand]
        public async Task AddContact()
        {
            WeakReferenceMessenger.Default.Send(new ContactAdded(NewContact));
            await Shell.Current.GoToAsync("..");
        }
    }
}
