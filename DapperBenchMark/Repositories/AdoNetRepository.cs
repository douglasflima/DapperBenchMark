using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using DapperBenchMark.Models;
using System;
using DapperBenchMark.Helpers;

namespace DapperBenchMark.Repositories
{
  public class AdoNetRepository
  {
    public List<ColigadaFake> GetColigadaWithAdoNet()
    {
      using (var conn = new SqlConnection(Utils.ConnectionString))
      {
        using (var cmd = new SqlCommand(Utils.Query, conn))
        {
          using (var adapter = new SqlDataAdapter(cmd))
          {
            var resultTable = new DataTable();
            adapter.Fill(resultTable);

            return (from DataRow dr in resultTable.Rows
                    select new ColigadaFake()
                    {
                      Code = dr["Code"].ToString(),
                      Description = dr["Description"].ToString(),
                      RecCreatedBy = dr["RecCreatedBy"].ToString(),
                      RecCreatedOn = Convert.ToDateTime(dr["RecCreatedOn"].ToString())
                    }).ToList();
          }
        }
      }
    }
  }
}
