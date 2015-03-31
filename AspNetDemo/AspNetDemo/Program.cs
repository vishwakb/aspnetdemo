using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Owin.Hosting;
using Owin;

namespace AspNetDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var baseAddress = "http://+:8080";

            using (WebApp.Start<Startup>(baseAddress))
            {
                Console.WriteLine("Server Started");
                Console.ReadLine();

            }
        }
    }

    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.UseWelcomePage();
        }
    }
}
