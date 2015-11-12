using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TemplateTag.Startup))]
namespace TemplateTag
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
