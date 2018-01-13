using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(QuickInventory.Startup))]
namespace QuickInventory
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
