using Microsoft.EntityFrameworkCore;

namespace Kino_Alikin.Classes.Common
{
    public class Config
    {
        public static string ConnectionConfig = "server=10.0.201.4;uid=root;pwd=;database=pcClub;";

        public static MySqlServerVersion Version = new MySqlServerVersion(new Version(8, 0, 11));
    }
}
