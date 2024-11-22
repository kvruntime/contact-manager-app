namespace ContactsAppMaui.Controls.Contacts;

public partial class ContactCard : ContentView
{
	public static readonly BindableProperty FirstnameProperty = BindableProperty.Create(
		nameof(Firstname), typeof(string), typeof(ContactCard), default(string));

	public static readonly BindableProperty PhoneProperty = BindableProperty.Create(
		nameof(Phone), typeof(string), typeof(ContactCard), default(string));
	public ContactCard()
	{
		InitializeComponent();
		// BindingContext = this;
	}
	public string Firstname
	{
		get => GetValue(FirstnameProperty) as string;
		set => SetValue(FirstnameProperty, value);
	}
	public string Phone
	{
		get => (string)GetValue(PhoneProperty);
		set => SetValue(PhoneProperty, value);
	}
}