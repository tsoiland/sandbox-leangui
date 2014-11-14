namespace Sandbox.LeanGui.Presentation.Bad
{
    using System.Collections.Specialized;

    using Sandbox.LeanGui.Application.Bad;
    using Sandbox.LeanGui.Presentation.Bad.FrameworkStuff;

    public class Controller
    {
        private readonly BackendService backendService;

        public Controller(BackendService backendService)
        {
            this.backendService = backendService;
        }

        public View Action(NameValueCollection queryString)
        {
            // Parse parameter from http.
            var tripId = int.Parse(queryString.Get("tripId"));

            // Get data from our backend.
            var trip = this.backendService.GetTrip(tripId);

            // Map it to a viewmodel.
            var viewModel = Automapper.MapToViewModel(trip);

            // Return view.
            return new View(viewModel);
        }
    }
}