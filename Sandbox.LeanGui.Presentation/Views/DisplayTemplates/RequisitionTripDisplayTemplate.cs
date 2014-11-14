namespace Sandbox.LeanGui.Presentation.Views.DisplayTemplates
{
    using Sandbox.LeanGui.Presentation.ViewModels;

    public class RequisitionTripDisplayTemplate
    {
        public static string Render(RequisitionViewModel viewModel)
        {
            return "Rekvisisjonsnummer: " + viewModel.RequisitionNumber;
        }
    }
}