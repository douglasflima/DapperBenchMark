using BenchmarkDotNet.Attributes;
using DapperBenchMark.Models;
using DapperBenchMark.Repositories;
using System.Collections.Generic;

namespace DapperBenchMark
{
  [RankColumn]
  [MemoryDiagnoser]
  public class AdoNetVsDapper
  { 
    public readonly DapperRepository _DapperRepo;
    public readonly AdoNetRepository _ADORepository;

    public AdoNetVsDapper()
    {
      _DapperRepo = new DapperRepository();
      _ADORepository = new AdoNetRepository();
    }

    [Benchmark]
    public List<ColigadaFake> GetDatasWithDapper() => 
      _DapperRepo.GetColigadaWithDapper();

    [Benchmark]
    public List<ColigadaFake> GetDatasWithADO() => 
      _ADORepository.GetColigadaWithAdoNet();

    #region Outros
    /*
    [Benchmark]
    public List<ColigadaFake> GetDatasWithEFCore() =>
      _EFRepo.GetColigadaWithEFCore();*/

    #endregion
  }
}
