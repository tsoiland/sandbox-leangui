namespace Sandbox.LeanGui.Presentation.ThingsThatASP.NetWouldDoForYou
{
    using Sandbox.LeanGui.Presentation.ViewModels;
    using Sandbox.LeanGui.Presentation.Views.DisplayTemplates;

    public class HtmlHelpers
    {
        // !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        //
        // You wouldn't actually have to write any of this code. Asp does it _for_ you by reflection.
        //
        // !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        public static string DisplayForModel(IViewModel viewModel)
        {
            var viewModelRequisition = viewModel as RequisitionViewModel;
            if (viewModelRequisition != null)
            {
                return RequisitionTripDisplayTemplate.Render(viewModelRequisition);
            }

            var viewModelInternalCard = viewModel as InternalCardViewModel;
            if (viewModelInternalCard != null)
            {
                return InternalCardDisplayTemplate.Render(viewModelInternalCard);
            }

            var viewModelCreditCard = viewModel as CreditCardViewModel;
            if (viewModelCreditCard != null)
            {
                return CreditCardTripDisplayTemplate.Render(viewModelCreditCard);
            }
            
            return "";
        }
    }
}