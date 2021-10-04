// This file is automatically generated by ABP framework to use MVC Controllers from CSharp
using System;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Http.Client;
using Volo.Abp.Http.Modeling;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Http.Client.ClientProxying;
using MyCompanyName.MyProjectName.Samples;

// ReSharper disable once CheckNamespace
namespace MyCompanyName.MyProjectName.Samples.ClientProxies
{
    [Dependency(ReplaceServices = true)]
    [ExposeServices(typeof(ISampleAppService), typeof(SampleClientProxy))]
    public partial class SampleClientProxy : ClientProxyBase<ISampleAppService>, ISampleAppService
    {
        public virtual async Task<SampleDto> GetAsync()
        {
            return await RequestAsync<SampleDto>(nameof(GetAsync));
        }

        public virtual async Task<SampleDto> GetAuthorizedAsync()
        {
            return await RequestAsync<SampleDto>(nameof(GetAuthorizedAsync));
        }
    }
}