
namespace Basket.API.Basket.BasketCheckout
{
    public record BasketCheckoutCommand(BasketCheckoutDto BasketCheckoutDto) : ICommand<BasketCheckoutCommandResult>;
    public record BasketCheckoutCommandResult(bool IsSuccess);
}
