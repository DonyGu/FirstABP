using Volo.Abp;

namespace FirstABP
{
    public abstract class FirstABPApplicationTestBase : AbpIntegratedTest<FirstABPApplicationTestModule>
    {
        protected override void SetAbpApplicationCreationOptions(AbpApplicationCreationOptions options)
        {
            options.UseAutofac();
        }
    }
}
