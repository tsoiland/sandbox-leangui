namespace Sandbox.LeanGui.Presentation.Views.DisplayTemplates
{
    using System.Text;

    using Sandbox.LeanGui.Presentation.ViewModels;

    public class CreditCardTripDisplayTemplate
    {
        public static string Render(CreditCardViewModel viewModel)
        {
            var r = new StringBuilder();
            r.Append("Kredittkortnummer: " + viewModel.CreditCardNumber);
            r.Append("<br/>Utløpsdato: " + viewModel.ExpirationDate);
            r.Append("<br/>Sikkerhetskode: " + viewModel.CardSecurityCode);
            return r.ToString();
        }
    }
}