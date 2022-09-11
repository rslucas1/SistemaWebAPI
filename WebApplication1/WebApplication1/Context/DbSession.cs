using Microsoft.Extensions.Configuration;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace API.Rejected.Context
{
    public class DbSession : IDisposable
    {
        public MySql.Data.MySqlClient.MySqlConnection Connection { get; }
   
        public DbSession(IConfiguration configuration)
        {

            Connection = new MySql.Data.MySqlClient.MySqlConnection();
            Connection.ConnectionString = configuration.GetConnectionString("DefaultConnection");
            Connection.Open();
        }
        public void Dispose() => Connection?.Dispose();
        
    }
}
