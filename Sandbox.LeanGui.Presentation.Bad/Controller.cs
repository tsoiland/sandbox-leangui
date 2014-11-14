namespace Sandbox.LeanGui.Presentation.Bad
{
    using Sandbox.LeanGui.Application.Bad;
    using Sandbox.LeanGui.Presentation.Bad.FrameworkStuff;

    public class Controller
    {
        private readonly BackendService backendService;

        public Controller(BackendService backendService)
        {
            this.backendService = backendService;
        }

        public View Action(int tripId)
        {
            // Get data from our backend.
            var trip = this.backendService.GetTrip(tripId);

            // Map it to a viewmodel.
            var viewModel = Automapper.MapToViewModel(trip);

            // Return view.
            return new View(viewModel);
        }
    }
}