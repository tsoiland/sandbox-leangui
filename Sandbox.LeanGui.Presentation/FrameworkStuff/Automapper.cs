namespace Sandbox.LeanGui.Presentation.FrameworkStuff
{
    using Sandbox.LeanGui.Application.Dto;
    using Sandbox.LeanGui.Presentation.ViewModels;
    using Sandbox.LeanGui.Presentation.Views.DisplayTemplates;

    public class Automapper
    {
        // !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        //
        // You wouldn't actually have to write any of this code. Automapper does it _for_ you by reflection/convention.
        //
        // !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        public static IViewModel MapToViewModel(TripDto trip)
        {
            var t1 = trip as CreditCardTripDto;
            if (t1 != null)
            {
                return new CreditCardViewModel
                       {
                           CreditCardNumber = t1.CreditCardNumber,
                           CardSecurityCode = t1.CardSecurityCode,
                           ExpirationDate = t1.ExpirationDate
                       };
            }

            var t2 = trip as InternalCardTripDto;
            if (t2 != null)
            {
                return new InternalCardViewModel { InternalCardNumber = t2.InternalCardNumber };
            }

            var t3 = trip as RequisitionTripDto;
            return new RequisitionViewModel
                   {
                       RequisitionNumber = t3.RequisitionNumber
                   };
        }
    }
}