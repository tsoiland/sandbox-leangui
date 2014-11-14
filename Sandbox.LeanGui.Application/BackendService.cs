namespace Sandbox.LeanGui.Application
{
    using System.Collections.Generic;

    using Sandbox.LeanGui.Application.Dto;

    public class BackendService
    {
        private readonly Dictionary<int, Trip> tripRepository;
        
        public BackendService()
        {
            // Set up some testdata.
            this.tripRepository = new Dictionary<int, Trip>
                        {
                            { 1, new Trip
                                {
                                    RequisitionNumber = "test",
                                    CreditCardNumber = "",
                                    ExpirationDate = "",
                                    CardSecurityCode = "",
                                    InternalCardNumber = ""
                                }},
                            { 2, new Trip
                                {
                                    RequisitionNumber = "",
                                    CreditCardNumber = "ccnr",
                                    ExpirationDate = "1015",
                                    CardSecurityCode = "123",
                                    InternalCardNumber = ""
                                }},
                            { 3, new Trip
                                {
                                    RequisitionNumber = "",
                                    CreditCardNumber = "",
                                    ExpirationDate = "",
                                    CardSecurityCode = "",
                                    InternalCardNumber = "220955"
                                }},
                        };
        }

        public TripDto GetTrip(int tripId)
        {
            var trip = this.tripRepository[tripId];

            if (trip.RequisitionNumber != "")
            {
                return new RequisitionTripDto
                    {
                        RequisitionNumber = trip.RequisitionNumber
                    };
            }
            
            if (trip.InternalCardNumber != "")
            {
                return new InternalCardTripDto
                    {
                        InternalCardNumber = trip.InternalCardNumber
                    };
            }
            
            return new CreditCardTripDto
                {
                    CreditCardNumber = trip.CreditCardNumber,
                    CardSecurityCode = trip.CardSecurityCode,
                    ExpirationDate = trip.ExpirationDate
                };
        }
    }
}
