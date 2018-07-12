using MediatorDemo.Web.ViewModels;
using MediatR;

namespace MediatorDemo.Web.Queries
{
  public class GetProductQuery : IRequest<ProductViewModel>
  {
    public GetProductQuery()
    { }

    public int Id { get; set; }

    public GetProductQuery(int id)
    {
      Id = id;
    }
  }
}