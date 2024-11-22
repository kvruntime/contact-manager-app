using ContactsAppMaui.Viewmodels.Contacts;

namespace ContactsAppMaui.Pages.Contacts;

public partial class ContactAddPage : ContentPage
{
    public ContactAddPage(ContactAddViewmodel vm)
    {
        InitializeComponent();
        BindingContext = vm;
    }
}