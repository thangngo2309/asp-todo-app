using Localization.Resources.AbpUi;
using API.ToDo.Localization;
using Volo.Abp.Account;
using Volo.Abp.FeatureManagement;
using Volo.Abp.Identity;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Volo.Abp.PermissionManagement.HttpApi;
using Volo.Abp.SettingManagement;
using Volo.Abp.TenantManagement;

namespace API.ToDo;

[DependsOn(
    typeof(ToDoApplicationContractsModule)
    //,
    //typeof(AbpAccountHttpApiModule),
    //typeof(AbpIdentityHttpApiModule),
    //typeof(AbpPermissionManagementHttpApiModule),
    //typeof(AbpTenantManagementHttpApiModule),
    //typeof(AbpFeatureManagementHttpApiModule),
    //typeof(AbpSettingManagementHttpApiModule)
    )]
public class ToDoHttpApiModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        ConfigureLocalization();
    }

    private void ConfigureLocalization()
    {
        Configure<AbpLocalizationOptions>(options =>
        {
            options.Resources
                .Get<ToDoResource>()
                .AddBaseTypes(
                    typeof(AbpUiResource)
                );
        });
    }
}
