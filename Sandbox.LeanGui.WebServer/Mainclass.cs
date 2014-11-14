namespace Sandbox.LeanGui.WebServer
{
    using System.Threading.Tasks;

    using Sandbox.LeanGui.Application;
    using Sandbox.LeanGui.Presentation.Controllers;
    using Sandbox.LeanGui.Presentation.Bad;
    using Sandbox.LeanGui.Application.Bad;

    public class MainClass
    {
        public static void Main()
        {
            var controller = new Sandbox.LeanGui.Presentation.Controllers.Controller(new Sandbox.LeanGui.Application.BackendService());
            var badController = new Sandbox.LeanGui.Presentation.Bad.Controller(new Sandbox.LeanGui.Application.Bad.BackendService());
            new Task(() => new WebServer().Run(controller, 1234)).Start();
            new WebServer().Run(badController, 1235);
        }
    }
}