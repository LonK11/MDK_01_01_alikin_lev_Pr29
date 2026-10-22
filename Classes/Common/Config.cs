using Microsoft.EntityFrameworkCore;

namespace Kino_Alikin.Classes.Common
{
    public class Config
    {
        public static string ConnectionConfig = "server=127.0.0.1;port=3307;uid=root;pwd=;database=pcClub;";

        public static MySqlServerVersion Version = new MySqlServerVersion(new Version(8, 0, 11));
    }
}
