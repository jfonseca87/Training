using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ConsumerService.Startup))]
namespace ConsumerService
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
