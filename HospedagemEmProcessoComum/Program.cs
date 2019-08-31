using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore;
using System;

namespace GenericWebHost
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("http://localhost:5000/");

            using (var host = WebHost.Start(app => app.Response.WriteAsync("Hello, World!")))
            {
                Console.WriteLine("Use Ctrl-C to shutdown the host...");
                host.WaitForShutdown();
            }
        }


    }
}
