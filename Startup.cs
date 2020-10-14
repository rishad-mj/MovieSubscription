using Microsoft.Owin;
using Owin;
[assembly: OwinStartup(typeof(MovieSubscription.Startup))]

namespace MovieSubscription
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
