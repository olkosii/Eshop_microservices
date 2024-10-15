namespace Basket.API.Basket.BasketCheckout
{
    public class BasketCheckoutCommandValidator : AbstractValidator<BasketCheckoutCommand>
    {
        public BasketCheckoutCommandValidator()
        {
            RuleFor(x => x.BasketCheckoutDto).NotNull().WithMessage("BasketCheckoutDto can't be null");
            RuleFor(x => x.BasketCheckoutDto.UserName).NotEmpty().WithMessage("UserName is required");
        }
    }
}
