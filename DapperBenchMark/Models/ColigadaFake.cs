using System;
using System.ComponentModel.DataAnnotations;

namespace DapperBenchMark.Models
{
  public partial class ColigadaFake
  {
    [Required()]
    public int Id { get; set; }
    [Required()]
    [MaxLength(20)]
    public string Code { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    [MaxLength(50)]
    public string RecCreatedBy { get; set; } = string.Empty;
    public DateTime RecCreatedOn { get; set; } = DateTime.Now;
  }
}
