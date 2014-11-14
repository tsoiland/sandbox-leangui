namespace Sandbox.LeanGui.Application.Dto
{
    public class CreditCardTripDto : TripDto
    {
        public string CreditCardNumber { get; set; }
        public string ExpirationDate { get; set; }
        public string CardSecurityCode { get; set; }
    }
}