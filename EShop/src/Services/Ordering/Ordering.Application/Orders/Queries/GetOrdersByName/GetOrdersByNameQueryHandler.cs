using Microsoft.EntityFrameworkCore;
using Ordering.Application.Data;
using Ordering.Application.Extensions;
using Ordering.Application.Orders.Queries.GetOrderByName;

namespace Ordering.Application.Orders.Queries.GetOrdersByName
{
    public class GetOrdersByNameQueryHandler(IApplicationDbContext dbContext) : IQueryHandler<GetOrdersByNameQuery, GetOrdersByNameQueryResult>
    {
        public async Task<GetOrdersByNameQueryResult> Handle(GetOrdersByNameQuery query, CancellationToken cancellationToken)
        {
            var orders = await dbContext.Orders
                .Include(o => o.OrderItems)
                .AsNoTracking()
                .Where(o => o.OrderName.Value.Contains(query.OrderName))
                .OrderBy(o => o.OrderName.Value)
                .ToListAsync(cancellationToken);
            
            return new GetOrdersByNameQueryResult(orders.ToOrderDtoList());
        }
    }
}
