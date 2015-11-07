using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BookStoreWebSite.Startup))]
namespace BookStoreWebSite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
