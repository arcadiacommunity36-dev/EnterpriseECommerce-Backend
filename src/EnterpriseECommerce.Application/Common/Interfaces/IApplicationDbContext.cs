using EnterpriseECommerce.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace EnterpriseECommerce.Application.Common.Interfaces;

public interface IApplicationDbContext
{
    DbSet<Product> Products { get; set; }
    DbSet<Category> Categories { get; set; }
    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}