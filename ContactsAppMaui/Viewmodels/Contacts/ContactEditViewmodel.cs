using System;
using CommunityToolkit.Mvvm.ComponentModel;
using ContactsAppDomain.Entities;

namespace ContactsAppMaui.Viewmodels.Contacts;

[QueryProperty(nameof(ContactEntity), "contact")]
public partial class ContactEditViewmodel : BaseViewmodel
{
  [ObservableProperty]
  ContactEntity contactEntity;
}
