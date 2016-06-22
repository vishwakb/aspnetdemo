using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Owin.Hosting;
using Owin;

namespace AspNetDemo
{
    public class Program
    {
        private static ManualResetEvent _quitEvent = new ManualResetEvent(false);

        static void Main(string[] args)
        {
            var port = 5000;
            if (args.Length > 0)
            {
                int.TryParse(args[0], out port);
            }

            Console.CancelKeyPress += (sender, eArgs) =>
            {
                _quitEvent.Set();
                eArgs.Cancel = true;
            };

            using (WebApp.Start<Startup>(string.Format("http://*:{0}", port)))
            {
                Console.WriteLine("Started");
                _quitEvent.WaitOne();
            }
        }
    }

    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            //for commit 
            /// from shaurya master
            Console.WriteLine("test");
            app.UseWelcomePage();
            // this commit is for merge request
            // Change story 1 
        }
    }
}
