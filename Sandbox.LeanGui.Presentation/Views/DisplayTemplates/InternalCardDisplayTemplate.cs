namespace Sandbox.LeanGui.Presentation.Views.DisplayTemplates
{
    using Sandbox.LeanGui.Presentation.ViewModels;

    public class InternalCardDisplayTemplate
    {
        public static string Render(InternalCardViewModel viewModel)
        {
            return "Internt kortnummer: " + viewModel.InternalCardNumber;
        }
    }
}