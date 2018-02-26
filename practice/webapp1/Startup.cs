using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(webapp1.Startup))]
namespace webapp1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
