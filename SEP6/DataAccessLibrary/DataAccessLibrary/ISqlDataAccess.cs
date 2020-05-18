using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    interface ISqlDataAccess
    {
        string ConnectionString { get; set; }

        Task<List<T>> LoadData<T, U>(string sql, U parameters);
    }
}