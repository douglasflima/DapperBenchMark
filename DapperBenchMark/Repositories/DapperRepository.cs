using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using DapperBenchMark.Models;
using Dapper;
using DapperBenchMark.Helpers;

namespace DapperBenchMark.Repositories
{
  public class DapperRepository
  {
    public List<ColigadaFake> GetColigadaWithDapper()
    {
      using (IDbConnection db = new SqlConnection(Utils.ConnectionString))
        return db.Query<ColigadaFake>(Utils.Query).ToList();
    }
  }
}
