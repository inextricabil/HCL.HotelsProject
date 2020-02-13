using Abp.MultiTenancy;
using HCL.HackatonHotels.Authorization.Users;

namespace HCL.HackatonHotels.MultiTenancy
{
    public class Tenant : AbpTenant<User>
    {
        public Tenant()
        {            
        }

        public Tenant(string tenancyName, string name)
            : base(tenancyName, name)
        {
        }
    }
}
