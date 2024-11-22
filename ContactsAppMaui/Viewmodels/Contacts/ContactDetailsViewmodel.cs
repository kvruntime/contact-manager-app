using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ContactsAppDomain.Entities;
using ContactsAppMaui.Pages.Contacts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsAppMaui.Viewmodels.Contacts;

[QueryProperty(nameof(CurrentContact), "contact")]
public partial class ContactDetailsViewmodel : BaseViewmodel
{
    [ObservableProperty]
    ContactEntity currentContact;

    [RelayCommand]
    public async Task GotoEditContact()
    {
        await Shell.Current.GoToAsync(
            nameof(ContactEditPage),
            true,
            new Dictionary<string, object>{{
                "contact", CurrentContact
            }}
        );
    }
}
