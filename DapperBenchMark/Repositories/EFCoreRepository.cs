using DapperBenchMark.Models;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using DapperBenchMark.Helpers;
using System.Linq;

namespace DapperBenchMark.Repositories
{
  public class EFCoreRepository
  {
    public List<ColigadaFake> GetColigadaWithEFCore()
    {
      using (var db = new ColigadaFakeEFContext())
      {
        return db.ColigadasFake.FromSqlRaw(Utils.Query).AsNoTracking().ToList();
        //return db.ColigadasFake.FromSql(Utils.GetQuery()).AsNoTracking().ToList();
        //return db.ColigadasFake.Take(50).AsNoTracking().ToList();
      }
    }
  }
}
