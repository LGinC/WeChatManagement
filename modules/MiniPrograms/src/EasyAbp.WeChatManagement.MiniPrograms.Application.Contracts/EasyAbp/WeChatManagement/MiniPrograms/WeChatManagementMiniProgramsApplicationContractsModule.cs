﻿using Volo.Abp.Application;
using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;
using Volo.Abp.Authorization;

namespace EasyAbp.WeChatManagement.MiniPrograms
{
    [DependsOn(
        typeof(WeChatManagementMiniProgramsDomainSharedModule),
        typeof(AbpDddApplicationContractsModule),
        typeof(AbpAuthorizationModule)
    )]
    public class WeChatManagementMiniProgramsApplicationContractsModule : AbpModule
    {

    }
}
