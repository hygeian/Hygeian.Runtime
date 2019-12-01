using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Hygeian.Runtime.AspNetCore.MvcCustomizations
{
    public static class ProblemDetailsHelper
    {
        public static void SetTraceId(ProblemDetails details, HttpContext httpContext)
        {
            // this is the same behaviour that Asp.Net core uses
            var traceId = Activity.Current?.Id ?? httpContext.TraceIdentifier;
            details.Extensions["traceId"] = traceId;
        }
    }
}
