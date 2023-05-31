using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperBenchMark.Helpers
{
  public static class Utils
  {
    public static string Query => "SELECT TOP 50 * FROM ColigadaFake";

    public static string ConnectionString =>
      @"Server=localhost;Database=DappperBenchmark;User Id=mestre;Password=totvs;Trusted_Connection=false;";
  }
}
