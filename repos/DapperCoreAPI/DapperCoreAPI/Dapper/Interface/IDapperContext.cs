using System.Data;

namespace DapperCoreAPI.Dapper.Interface
{
    public interface IDapperContext
    {
        IDbConnection CreateConnection();
    }
}
