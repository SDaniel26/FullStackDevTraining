using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(QuotesApp.Startup))]
namespace QuotesApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
