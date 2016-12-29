using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NewMVCMusicStore.Startup))]
namespace NewMVCMusicStore
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
