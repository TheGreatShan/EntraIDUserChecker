namespace ADChecker;

class Program
{
    public static void Main(string[] args)
    {
        var file = AppSettingsUtils.GetUserFile();
        var ids = EntraIDClient.GetByUpn(file);

        foreach (var id in ids)
        {
            Console.WriteLine($"{id.Upn} - {id.Status}");
        }
    }
}

