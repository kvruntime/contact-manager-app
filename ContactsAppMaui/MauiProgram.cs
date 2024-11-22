using ContactsAppApplication.Usecases;
using ContactsAppDomain.Interfaces;
using ContactsAppInfrastructure;
using ContactsAppMaui.Data;
using ContactsAppMaui.Pages;
using ContactsAppMaui.Pages.Contacts;
using ContactsAppMaui.Viewmodels.Contacts;
using Microsoft.Extensions.Logging;

namespace ContactsAppMaui
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif
            
            // builder.Services.AddSingleton<IContactRepository, InMemoryContactStore>();
            builder.Services.AddSingleton<IContactRepository, SqliteContactStore>();
            builder.Services.AddSingleton<UserUsecases>();

            builder.Services.AddSingleton<ContactsPage>();
            builder.Services.AddTransient<ContactEditPage>();
            builder.Services.AddTransient<ContactAddPage>();
            builder.Services.AddTransient<ContactDetailPage>();

            builder.Services.AddSingleton<ContactsViewmodel>();
            builder.Services.AddTransient<ContactDetailsViewmodel>();
            builder.Services.AddTransient<ContactAddViewmodel>();
            builder.Services.AddTransient<ContactDetailsViewmodel>();

            builder.Services.AddDbContext<AppDbContext>(o=>{
            });
            var dbContext =new  AppDbContext();
            dbContext.Database.EnsureCreated();
            dbContext.Dispose();

            

            return builder.Build();
        }
    }
}
