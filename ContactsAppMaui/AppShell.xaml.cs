using ContactsAppMaui.Pages.Contacts;

namespace ContactsAppMaui
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ContactEditPage), typeof(ContactEditPage));
            Routing.RegisterRoute(nameof(ContactAddPage), typeof(ContactAddPage));
        }
    }
}
