using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace API.ToDo;

[Dependency(ReplaceServices = true)]
public class ToDoBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "ToDo";
}
