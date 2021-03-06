﻿using System.Net;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Primitives;

namespace ReadMoreAPI
{
    /// <inheritdoc />
    /// <summary>
    /// Marks an action parameter as being required as a query
    /// parameter, returning a BadRequest response if it is not
    /// present.
    /// </summary>
    public class RequiredQueryParameterAttribute : RequiredParameterAttribute
    {
        protected override bool TryGetValue(ActionExecutingContext context, string key, out StringValues values)
        {
            return context.HttpContext.Request.Query.TryGetValue(Name, out values);
        }
    }
}
