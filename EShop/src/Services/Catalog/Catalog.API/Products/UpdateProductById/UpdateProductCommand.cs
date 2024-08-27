namespace Catalog.API.Products.UpdateProductById
{
    public record UpdateProductCommand(Guid Id, string Name, List<string> Category, string Description, string ImageFile, decimal Price) 
        : ICommand<UpdateProductResult>;
    public record UpdateProductResult(bool IsSeccess);
}
