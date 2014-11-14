namespace Sandbox.LeanGui.Presentation.Views
{
    using Sandbox.LeanGui.Presentation.ThingsThatASP.NetWouldDoForYou;
    using Sandbox.LeanGui.Presentation.Views.DisplayTemplates;

    public class View
    {
        private readonly IViewModel viewModel;

        public View(IViewModel viewModel)
        {
            this.viewModel = viewModel;
        }

        public string Render()
        {
            return @"
                <html>
                    <title>Good view with no business logic</title>
                <body>
                    <h1>Turens betalingsdetaljer</h1>" +
                    HtmlHelpers.DisplayForModel(this.viewModel) + @"
                    
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