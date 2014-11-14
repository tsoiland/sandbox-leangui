namespace Sandbox.LeanGui.Presentation.ViewModels
{
    using Sandbox.LeanGui.Presentation.Views.DisplayTemplates;

    public class CreditCardViewModel : IViewModel
    {
        public string CreditCardNumber { get; set; }
        public string ExpirationDate { get; set; }
        public string CardSecurityCode { get; set; }
    }
}