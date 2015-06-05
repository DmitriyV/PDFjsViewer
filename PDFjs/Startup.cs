using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PDFjs.Startup))]
namespace PDFjs
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            
        }
    }
}
