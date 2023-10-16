using System.Text.Json;

namespace ADChecker;

internal record AppSettings(string LdapUrl, string UserFilePath);

internal class AppSettingsUtils
{
    internal static AppSettings GetAppSettings() =>
        JsonSerializer.Deserialize<AppSettings>(File.ReadAllText("appsettings.json"))!;

    internal static string[] GetUserFile() =>
        File.ReadAllLines(GetAppSettings().UserFilePath);
}