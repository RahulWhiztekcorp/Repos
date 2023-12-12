using DapperCoreAPI.Dapper.Interface;
using System.Data;
using System.Data.SqlClient;

namespace DapperCoreAPI.Dapper.Implimentaions
{
    public class DapperContext : IDapperContext
    {
        private readonly IConfiguration _iConfiguration;
        private readonly string _connString;
        public DapperContext(IConfiguration iConfiguration)
        {
            _iConfiguration = iConfiguration;
            _connString = _iConfiguration.GetConnectionString("DefaultConnection");
        }
        public IDbConnection CreateConnection() => new SqlConnection(_connString);
    }
}
