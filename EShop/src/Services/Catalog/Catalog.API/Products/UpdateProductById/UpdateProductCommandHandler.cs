
namespace Catalog.API.Products.UpdateProductById
{
    internal class UpdateProductCommandHandler(IDocumentSession session) : ICommandHandler<UpdateProductCommand, UpdateProductResult>
    {
        public async Task<UpdateProductResult> Handle(UpdateProductCommand command, CancellationToken cancellationToken)
        {
            var product = await session.LoadAsync<Product>(command.Id);

            if (product is null)
                throw new ProductNotFoundException(command.Id);

            product.Name = command.Name;
            product.Price = command.Price;
            product.Category = command.Category;
            product.ImageFile = command.ImageFile;
            product.Description = command.Description;

            session.Update(product);
            session.SaveChanges();

            return new UpdateProductResult(true);
        }
    }
}
