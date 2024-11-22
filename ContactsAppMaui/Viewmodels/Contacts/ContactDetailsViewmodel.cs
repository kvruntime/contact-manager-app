using CommunityToolkit.Mvvm.ComponentModel;
using ContactsAppDomain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsAppMaui.Viewmodels.Contacts
{
    [QueryProperty(nameof(ContactEntity), "contact")]
    public partial class ContactDetailsViewmodel:BaseViewmodel
    {
        [ObservableProperty]
        ContactEntity contactEntity;
    }
}
