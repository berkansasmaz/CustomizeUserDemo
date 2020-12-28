using System;
using System.Collections.Generic;
using System.Text;
using CustomizeUserDemo.Localization;
using Volo.Abp.Application.Services;

namespace CustomizeUserDemo
{
    /* Inherit your application services from this class.
     */
    public abstract class CustomizeUserDemoAppService : ApplicationService
    {
        protected CustomizeUserDemoAppService()
        {
            LocalizationResource = typeof(CustomizeUserDemoResource);
        }
    }
}
