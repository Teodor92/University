using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SimpleBookStore.Web.Startup))]
namespace SimpleBookStore.Web
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
