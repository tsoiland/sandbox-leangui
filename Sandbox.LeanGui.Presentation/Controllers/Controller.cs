﻿namespace Sandbox.LeanGui.Presentation.Controllers
{
    using System.Collections.Specialized;

    using Sandbox.LeanGui.Application;
    using Sandbox.LeanGui.Presentation.FrameworkStuff;
    using Sandbox.LeanGui.Presentation.Views;

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

            // return view.
            return new View(viewModel);
        }
    }
}
