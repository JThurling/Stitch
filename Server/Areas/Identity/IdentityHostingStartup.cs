using Microsoft.AspNetCore.Hosting;

[assembly: HostingStartup(typeof(Stitch.Server.Areas.Identity.IdentityHostingStartup))]
namespace Stitch.Server.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
            });
        }
    }
}
