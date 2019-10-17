# Examples

## Require Enum query OK

A Request to https://localhost:44363/Products?$filter=(Required in ('A', 'B')) succeeds with:

```json
{
    "@odata.context": "https://localhost:44363/$metadata#Products",
    "value": [
        {
            "PK": 1,
            "Name": null,
            "Optional": null,
            "Required": "A"
        },
        {
            "PK": 2,
            "Name": null,
            "Optional": "A",
            "Required": "A"
        },
        {
            "PK": 3,
            "Name": null,
            "Optional": null,
            "Required": "B"
        },
        {
            "PK": 4,
            "Name": null,
            "Optional": "B",
            "Required": "B"
        }
    ]
}

```

## Optional Enum query fails

A Request to <https://localhost:44363/Products?$filter=(Optional in ('A', 'B'))> fails with:

```json
{
    "error": {
        "code": "",
        "message": "An error has occurred.",
        "innererror": {
            "message": "Expression of type 'System.Collections.Generic.List`1[ODataService.Models.MyEnum]' cannot be used for parameter of type 'System.Collections.Generic.IEnumerable`1[System.Nullable`1[ODataService.Models.MyEnum]]' of method 'Boolean Contains[Nullable`1](System.Collections.Generic.IEnumerable`1[System.Nullable`1[ODataService.Models.MyEnum]], System.Nullable`1[ODataService.Models.MyEnum])'",
            "type": "System.ArgumentException",
            "stacktrace": "   at System.Linq.Expressions.Expression.ValidateOneArgument(MethodBase method, ExpressionType nodeKind, Expression arg, ParameterInfo pi)\r\n   at System.Linq.Expressions.Expression.Call(Expression instance, MethodInfo method, Expression arg0, Expression arg1)\r\n   at Microsoft.AspNet.OData.Query.Expressions.FilterBinder.BindInNode(InNode inNode)\r\n   at Microsoft.AspNet.OData.Query.Expressions.FilterBinder.BindSingleValueNode(SingleValueNode node)\r\n   at Microsoft.AspNet.OData.Query.Expressions.FilterBinder.Bind(QueryNode node)\r\n   at Microsoft.AspNet.OData.Query.Expressions.FilterBinder.BindExpression(SingleValueNode expression, RangeVariable rangeVariable, Type elementType)\r\n   at Microsoft.AspNet.OData.Query.Expressions.FilterBinder.BindFilterClause(FilterBinder binder, FilterClause filterClause, Type filterType)\r\n   at Microsoft.AspNet.OData.Query.Expressions.FilterBinder.Bind(IQueryable baseQuery, FilterClause filterClause, Type filterType, ODataQueryContext context, ODataQuerySettings querySettings)\r\n   at Microsoft.AspNet.OData.Query.FilterQueryOption.ApplyTo(IQueryable query, ODataQuerySettings querySettings)\r\n   at Microsoft.AspNet.OData.Query.ODataQueryOptions.ApplyTo(IQueryable query, ODataQuerySettings querySettings)\r\n   at Microsoft.AspNet.OData.EnableQueryAttribute.ApplyQuery(IQueryable queryable, ODataQueryOptions queryOptions)\r\n   at Microsoft.AspNet.OData.EnableQueryAttribute.ExecuteQuery(Object responseValue, IQueryable singleResultCollection, IWebApiActionDescriptor actionDescriptor, Func`2 modelFunction, IWebApiRequestMessage request, Func`2 createQueryOptionFunction)\r\n   at Microsoft.AspNet.OData.EnableQueryAttribute.OnActionExecuted(Object responseValue, IQueryable singleResultCollection, IWebApiActionDescriptor actionDescriptor, IWebApiRequestMessage request, Func`2 modelFunction, Func`2 createQueryOptionFunction, Action`1 createResponseAction, Action`3 createErrorAction)\r\n   at Microsoft.AspNet.OData.EnableQueryAttribute.OnActionExecuted(HttpActionExecutedContext actionExecutedContext)\r\n   at System.Web.Http.Filters.ActionFilterAttribute.OnActionExecutedAsync(HttpActionExecutedContext actionExecutedContext, CancellationToken cancellationToken)\r\n--- End of stack trace from previous location where exception was thrown ---\r\n   at System.Runtime.CompilerServices.TaskAwaiter.ThrowForNonSuccess(Task task)\r\n   at System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(Task task)\r\n   at System.Web.Http.Filters.ActionFilterAttribute.<CallOnActionExecutedAsync>d__6.MoveNext()\r\n--- End of stack trace from previous location where exception was thrown ---\r\n   at System.Runtime.CompilerServices.TaskAwaiter.ThrowForNonSuccess(Task task)\r\n   at System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(Task task)\r\n   at System.Web.Http.Filters.ActionFilterAttribute.<ExecuteActionFilterAsyncCore>d__5.MoveNext()\r\n--- End of stack trace from previous location where exception was thrown ---\r\n   at System.Runtime.CompilerServices.TaskAwaiter.ThrowForNonSuccess(Task task)\r\n   at System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(Task task)\r\n   at System.Web.Http.Controllers.ActionFilterResult.<ExecuteAsync>d__5.MoveNext()\r\n--- End of stack trace from previous location where exception was thrown ---\r\n   at System.Runtime.CompilerServices.TaskAwaiter.ThrowForNonSuccess(Task task)\r\n   at System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(Task task)\r\n   at System.Web.Http.Dispatcher.HttpControllerDispatcher.<SendAsync>d__15.MoveNext()"
        }
    }
}
```