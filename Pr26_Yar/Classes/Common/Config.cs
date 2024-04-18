using Microsoft.EntityFrameworkCore;
using System;
namespace Pr26_Yar.Classes.Common
{
   public class Config
    {
        public static string ConnectionConfig = "server=10.0.201.4; uid=root; pwd=;database=pcClub;";
        public static MySqlServerVersion Version = new MySqlServerVersion(new Version(8, 0, 11));
    }
}
