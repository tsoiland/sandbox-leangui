namespace Sandbox.LeanGui.Presentation.Bad
{
    using System;
    using System.Text;
    
    public class View
    {
        private readonly ViewModel viewModel;

        public View(ViewModel viewModel)
        {
            this.viewModel = viewModel;
        }

        public string Render()
        {
            // The func and anonymous function below is just to be able to inline the logic.
            // That way it looks roughly like it would in a real template engine like webforms or razor.
            return @"
                <html>
                    <title>Bad view with business logic</title>
                <body>
                    <h1>Turens betalingsdetaljer</h1>" + (new Func<string> (() => {
                        if (viewModel.RequisitionNumber != "")
                        {
                            return "Rekvisisjonsnummer: " + viewModel.RequisitionNumber;
                        }
                        else if (this.viewModel.InternalCardNumber != "")
                        {
                            return "Internt kortnummer: " + this.viewModel.InternalCardNumber;
                        }
                        else
                        {
                            var r = new StringBuilder();
                            r.Append("Kredittkortnummer: " + this.viewModel.CreditCardNumber);
                            r.Append("<br/>Utløpsdato: " + this.viewModel.ExpirationDate);
                            r.Append("<br/>Sikkerhetskode: " + this.viewModel.CardSecurityCode);
                            return r.ToString();
                        }})()) + @"
                    <h1>Andre turer</h1>
                    <ul>
                        <li><a href='?tripId=1'>Rekvisisjonstur</a></li>
                        <li><a href='?tripId=2'>Kredittkorttur</a></li>
                        <li><a href='?tripId=3'>Internkorttur</a></li>
                    </ul>
                </body>
                </html>";
        }
    }
}