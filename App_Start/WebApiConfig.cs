using Microsoft.AspNet.OData.Builder;
using Microsoft.AspNet.OData.Extensions;
using ODataService.Models;
using System.Web.Http;

namespace ODataService
{
  public static class WebApiConfig
  {
    public static void Register(HttpConfiguration config)
    {
      var builder = new ODataConventionModelBuilder();

      builder.EntitySet<Product>("Products")
        .EntityType.Count().Filter().OrderBy().Expand().Select();

      config.MapODataServiceRoute("ODataRoute", null, builder.GetEdmModel());
    }
  }
}
