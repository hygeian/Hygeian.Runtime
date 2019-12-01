using Microsoft.AspNetCore.Mvc.ApplicationModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hygeian.Runtime.AspNetCore.MvcCustomizations
{
    /// <summary>
    ///     Apply <see cref="NotFoundResultAttribute" /> to all Api controllers
    /// </summary>
    public class NotFoundResultApiConvention : ApiConventionBase
    {
        protected override void ApplyControllerConvention(ControllerModel controller)
        {
            controller.Filters.Add(new NotFoundResultAttribute());
        }
    }
}
