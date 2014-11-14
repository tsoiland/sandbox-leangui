namespace Sandbox.LeanGui.Presentation.Bad.FrameworkStuff
{
    using Sandbox.LeanGui.Application;
    using Sandbox.LeanGui.Presentation.Bad;

    public class Automapper
    {
        // !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        //
        // You wouldn't actually have to write any of this code. Automapper does it _for_ you by reflection/convention.
        //
        // !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        public static ViewModel MapToViewModel(Trip trip)
        {
            return new ViewModel
            {
                RequisitionNumber = trip.RequisitionNumber,
                CreditCardNumber = trip.CreditCardNumber,
                CardSecurityCode = trip.CardSecurityCode,
                ExpirationDate = trip.ExpirationDate,
                InternalCardNumber = trip.InternalCardNumber
            };
        }
    }
}