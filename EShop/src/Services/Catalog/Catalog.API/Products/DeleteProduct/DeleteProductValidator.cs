namespace Catalog.API.Products.DeleteProduct
{
    public class DeleteProductValidator : AbstractValidator<DeleteProductCommand>
    {
        public DeleteProductValidator()
        {
            RuleFor(command => command.Id).NotEmpty().WithMessage("Product Id is required");
        }
    }
}
