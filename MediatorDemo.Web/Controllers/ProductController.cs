using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MediatorDemo.Web.Infrastructure;
using MediatorDemo.Web.Queries;
using MediatorDemo.Web.ViewModels;

namespace MediatorDemo.Web.Controllers
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