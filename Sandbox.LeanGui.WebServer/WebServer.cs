namespace Sandbox.LeanGui.WebServer
{
    using System;
    using System.Net;
    using System.Reflection;
    using System.Text;

    using Sandbox.LeanGui.Presentation.Controllers;

    public class WebServer
    {
        public void Run(object controller, int portNumber)
        {
            // Set up webserver
            var httpListener = new HttpListener();
            httpListener.Prefixes.Add("http://*:" + portNumber + "/");
            httpListener.Start();

            // Process requests
            while (true)
            {
                // Listen for http requests
                var context = httpListener.GetContext();
                var request = context.Request;

                // Ignore some bullshit I don't want to look up.
                if (request.RawUrl == "/favicon.ico")
                {
                    continue;
                }

                // Parse http querystring
                var s = request.QueryString.Get("tripId");
                var tripId = !string.IsNullOrEmpty(s) ? int.Parse(request.QueryString.Get("tripId")) : 1;

                // Call the controller
                var view = controller.GetType().GetMethod("Action").Invoke(controller, new object[] { tripId});

                // Render the returned view
                var result = (string)view.GetType().GetMethod("Render").Invoke(view, new object[0]);

                // Send http response
                var byteData = Encoding.Default.GetBytes(result);
                context.Response.OutputStream.Write(byteData, 0, byteData.Length);
                context.Response.OutputStream.Close();
            }
        }
    }
}
