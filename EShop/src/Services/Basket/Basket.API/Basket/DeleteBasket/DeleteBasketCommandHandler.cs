
namespace Basket.API.Basket.DeleteBasket
{
    public class DeleteBasketCommandHandler(IBasketRepository _basketRepository) : ICommandHandler<DeleteBasketCommand, DeleteBasketResult>
    {
        public async Task<DeleteBasketResult> Handle(DeleteBasketCommand command, CancellationToken cancellationToken)
        {
            await _basketRepository.DeleteBasketAsync(command.UserName, cancellationToken);

            return new DeleteBasketResult(true);
        }
    }
}
