using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(MovieSubscription.StartupOwin))]

namespace MovieSubscription
{
    public partial class StartupOwin
    {
        public void Configuration(IAppBuilder app)
        {
            //AuthStartup.ConfigureAuth(app);
        }
    }
}
