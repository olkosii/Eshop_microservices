
namespace Basket.API.Basket.StoreBasket
{
    internal class StoreBasketCommandHandler(IBasketRepository _basketRepository) : ICommandHandler<StoreBasketCommand, StoreBasketResult>
    {
        public async Task<StoreBasketResult> Handle(StoreBasketCommand command, CancellationToken cancellationToken)
        {
            await _basketRepository.StoreBasketAsync(command.Cart, cancellationToken);

            return new StoreBasketResult(command.Cart.UserName);
        }
    }
}
