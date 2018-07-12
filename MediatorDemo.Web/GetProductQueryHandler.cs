using System.Threading;
using System.Threading.Tasks;
using MediatR;

namespace MediatorDemo.Web
{
  public class GetProductQueryHandler : IRequestHandler<GetProductQuery, ProductViewModel>
  {
    public async Task<ProductViewModel> Handle(GetProductQuery request, CancellationToken cancellationToken)
    {
      return new ProductViewModel
      {
        Id = 1,
        Name = "MyProduct"
      };
    }
  }
}