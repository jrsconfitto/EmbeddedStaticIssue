namespace Demo.Embedded
{
    using Nancy;
    using Nancy.Conventions;
    using Nancy.Diagnostics;
    using Nancy.Embedded;
    using Nancy.Embedded.Conventions;

    public class Bootstrapper : DefaultNancyBootstrapper
    {
        protected override Nancy.Diagnostics.DiagnosticsConfiguration DiagnosticsConfiguration
        {
            get
            {
                return new DiagnosticsConfiguration() {Password = "pass"};
            }
        }
        protected override void ConfigureConventions(NancyConventions nancyConventions)
        {
            nancyConventions.StaticContentsConventions.AddEmbeddedDirectory("/Content", "Content");
        }
    }
}