using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// データベース接続のパスワードが漏れるため関数化しちゃった
// string connectionString = DatabaseConfig.ConnectionString;でコネクション
namespace WindowsFormsApp1
{
    internal class DatabaseConfig
    {
        public static string ConnectionString = "server=localhost;database=stem-ask;user=root;password=;";
    }
}
