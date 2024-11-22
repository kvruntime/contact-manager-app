using ContactsAppApplication.Usecases;
using ContactsAppDomain.Entities;
using ContactsAppMaui.Pages.Contacts;
using ContactsAppMaui.Viewmodels.Contacts;
using System.Diagnostics;

namespace ContactsAppMaui.Pages;

public partial class ContactsPage : ContentPage
{
    int count = 0;

    public ContactsPage(ContactsViewmodel vm)
    {
        InitializeComponent();
        BindingContext = vm;

    }
}
