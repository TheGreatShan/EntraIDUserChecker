using System.Diagnostics.CodeAnalysis;
using System.DirectoryServices;
using static ADChecker.AppSettingsUtils;

namespace ADChecker;

[SuppressMessage("Interoperability", "CA1416:Validate platform compatibility")]
internal class EntraIDClient
{
    internal static List<EntraID> GetByUpn(string[] upns)
    {
        var users = new List<EntraID>();
        foreach (var upn in upns)
        {
            var filter = $"( &(objectClass=user)(userPrincipalName={upn}))";

            using var dSearcher = new DirectorySearcher(new DirectoryEntry(GetAppSettings().LdapUrl));
            dSearcher.Filter = filter;

            var searchResult = dSearcher.FindOne();

            if (searchResult==null)
            {
                continue;
            }
            
            int userAccountControlValue = (int)searchResult.Properties["userAccountControl"][0];
            bool isAccountEnabled = (userAccountControlValue & 2) == 0;
            users.Add(new EntraID(searchResult!.Properties["userprincipalname"][0].ToString()!, isAccountEnabled.ToString()));
        }

        return users;
    }
}

internal record EntraID(string Upn, string Status);