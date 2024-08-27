﻿
namespace Catalog.API.Products.GetProductById
{
    internal class GetProductByIdQueryHandler(IDocumentSession session) : IQueryHandler<GetProductByIdQuery, GetProductByIdResult>
    {
        public async Task<GetProductByIdResult> Handle(GetProductByIdQuery query, CancellationToken cancellationToken)
        {
            var product = await session.LoadAsync<Product>(query.id, cancellationToken);

            return product is null ? throw new ProductNotFoundException(query.id) : new GetProductByIdResult(product);
        }
    }
}
