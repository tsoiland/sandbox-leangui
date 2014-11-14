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
                try
                {
                    // Listen for http requests
                    var context = httpListener.GetContext();
                    var request = context.Request;

                    // Ignore some bullshit I don't want to look up.
                    if (request.RawUrl == "/favicon.ico")
                    {
                        continue;
                    }

                    // Call the controller
                    var view = controller.GetType().GetMethod("Action").Invoke(controller, new object[] {request.QueryString});

                    // Render the returned view
                    var result = (string)view.GetType().GetMethod("Render").Invoke(view, new object[0]);

                    // Send http response
                    var byteData = Encoding.Default.GetBytes(result);
                    context.Response.OutputStream.Write(byteData, 0, byteData.Length);
                    context.Response.OutputStream.Close();
                }
                catch (Exception e)
                {
                    Console.Out.WriteLine("Exception: " + e.Message);
                    Console.Out.WriteLine(e.StackTrace);
                }
            }
        }
    }
}
