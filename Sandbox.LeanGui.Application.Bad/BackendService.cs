namespace Sandbox.LeanGui.Application.Bad
{
    using System.Collections.Generic;

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

        public Trip GetTrip(int tripId)
        {
            return this.tripRepository[tripId];
        }
    }
}