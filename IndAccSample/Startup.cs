using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(IndAccSample.Startup))]
namespace IndAccSample
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
