using System;

namespace ContactsAppMaui.Data;

public static class AppConfig
{
public static string GetDbConnectionString()
{
    var dbPath = Path.Combine(FileSystem.AppDataDirectory, "todo.sqlite");
    return $"Data Source={dbPath}";
}
}
