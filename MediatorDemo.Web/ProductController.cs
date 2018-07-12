using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MediatorDemo.Web
{
  [Route("api/[controller]")]
  [ApiController]
  public class ProductController : BaseController
  {
    [HttpGet]
    public Task<ProductViewModel> GetProducts()
    {
      return Mediator.Send(new GetProductQuery());
    }
  }
}