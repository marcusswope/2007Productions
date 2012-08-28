using FubuMVC.Core;
using FubuMVC.Razor;
using _2007Productions.Web.Endpoints;

namespace _2007Productions.Web
{
    public class ConfigureFubuMVC : FubuRegistry
    {
        public ConfigureFubuMVC()
        {
            IncludeDiagnostics(true);

            Actions.IncludeTypesNamed(x => x.EndsWith("Endpoint"));
            
            Routes
                .HomeIs<HomeRequest>()
                .IgnoreControllerNamesEntirely()
                .IgnoreControllerNamespaceEntirely()
                .IgnoreMethodSuffix("Html")
                .RootAtAssemblyNamespace();

            Views.TryToAttachWithDefaultConventions();
            Assets.CombineAllUniqueAssetRequests();
            Import<RazorEngineRegistry>();
        }
    }
}