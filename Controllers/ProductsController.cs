using Microsoft.AspNet.OData;
using ODataService.Models;
using System.Collections.Generic;
using System.Linq;

namespace ODataService.Controllers
{
  public class ProductsController : ODataController
  {
    private static readonly IEnumerable<Product> Database = new[]
     {
      new Product
      {
        PK = 1,
        Optional = null,
        Required = MyEnum.A
      },
      new Product
      {
        PK = 2,
        Optional = MyEnum.A,
        Required = MyEnum.A
      },
      new Product
      {
        PK = 3,
        Optional = null,
        Required = MyEnum.B
      },
      new Product
      {
        PK = 4,
        Optional = MyEnum.B,
        Required = MyEnum.B
      },
      new Product
      {
        PK = 5,
        Optional = MyEnum.C,
        Required = MyEnum.C
      },
    };

    [EnableQuery]
    public IQueryable<Product> Get()
    {
      return Database.AsQueryable();
    }
  }
}