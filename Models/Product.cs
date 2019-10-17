using System.ComponentModel.DataAnnotations;

namespace ODataService.Models
{
  public class Product
  {
    [Key]
    public int PK { get; set; }
    public string Name { get; set; }
    public MyEnum? Optional { get; set; }
    public MyEnum Required { get; set; }
  }

  public enum MyEnum
  {
    NotSpecified,
    A,
    B,
    C
  }
}