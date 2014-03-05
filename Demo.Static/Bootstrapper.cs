namespace Demo.Embedded
{
    using Nancy;
    using Nancy.Conventions;
    using NancyEmbedded;
    using NancyEmbedded.Conventions;

    public class Bootstrapper : DefaultNancyBootstrapper
    {
        protected override void ConfigureConventions(NancyConventions nancyConventions)
        {
            nancyConventions.StaticContentsConventions.AddEmbeddedDirectory("/Content", "Content");
        }
    }
}