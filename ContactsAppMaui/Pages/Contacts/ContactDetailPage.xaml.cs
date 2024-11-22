using ContactsAppMaui.Viewmodels.Contacts;

namespace ContactsAppMaui.Pages.Contacts;

public partial class ContactDetailPage : ContentPage
{
	public ContactDetailPage(ContactDetailsViewmodel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}