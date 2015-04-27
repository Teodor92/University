using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SimpleBookstore.Web.Startup))]
namespace SimpleBookstore.Web
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
