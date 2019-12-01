using Microsoft.AspNetCore.Mvc.ApplicationModels;

namespace Hygeian.Runtime.AspNetCore.MvcCustomizations
{
    /// <summary>
    ///     Apply <see cref="ProblemDetailsResultAttribute" /> to all Api controllers
    /// </summary>
    public class ProblemDetailsResultApiConvention : ApiConventionBase
    {
        protected override void ApplyControllerConvention(ControllerModel controller)
        {
            controller.Filters.Add(new ProblemDetailsResultAttribute());
        }
    }
}
