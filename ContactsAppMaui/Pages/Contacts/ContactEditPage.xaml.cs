using ContactsAppApplication.Usecases;
using ContactsAppDomain.Entities;
using ContactsAppMaui.Viewmodels.Contacts;

namespace ContactsAppMaui.Pages.Contacts;

[QueryProperty(nameof(Contact), "Contact")]
public partial class ContactEditPage : ContentPage
{
    private readonly UserUsecases _usecase;

    public ContactEditPage(ContactDetailsViewmodel vm)
    {
        InitializeComponent();
        BindingContext = vm;
    }


}