using BenchmarkDotNet.Running;
using System;

namespace DapperBenchMark
{
  internal class Program
  {
    static void Main(string[] args)
    {
      var resume = BenchmarkRunner.Run(typeof(AdoNetVsDapper));

      Console.WriteLine(resume);
      Console.WriteLine("Fim");
      Console.ReadLine();
    }
  }
}
