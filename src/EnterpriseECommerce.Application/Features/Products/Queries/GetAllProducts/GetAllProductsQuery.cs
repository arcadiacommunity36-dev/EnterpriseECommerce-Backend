using EnterpriseECommerce.Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace EnterpriseECommerce.Application.Features.Products.Queries.GetAllProducts;

// 1. Request (Dışarıdan parametre almayacağımız için içi boş record)
public record GetAllProductsQuery() : IRequest<List<GetAllProductsResponse>>;

// 2. Response DTO (Müşteriye döneceğimiz veri formatı)
public record GetAllProductsResponse(Guid Id, string Name, string Description, decimal Price, int Stock, string CategoryName);

// 3. Handler (Veritabanından veriyi çeken iş mantığı)
public class GetAllProductsQueryHandler : IRequestHandler<GetAllProductsQuery, List<GetAllProductsResponse>>
{
    private readonly IApplicationDbContext _context;

    public GetAllProductsQueryHandler(IApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<List<GetAllProductsResponse>> Handle(GetAllProductsQuery request, CancellationToken cancellationToken)
    {
        // Performans için Include kullanarak Kategoriyi de çekiyoruz ve Response formatına mapliyoruz
        var products = await _context.Products
            .Include(p => p.Category)
            .Select(p => new GetAllProductsResponse(
                p.Id,
                p.Name,
                p.Description,
                p.Price,
                p.Stock,
                p.Category.Name
            ))
            .ToListAsync(cancellationToken);

        return products;
    }
}