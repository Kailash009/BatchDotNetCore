using Microsoft.AspNetCore.Mvc.Filters;

namespace BatchMithilesh11AMWE.Filter
{
    public class CustomActionFilter : IActionFilter
    {
        public void OnActionExecuting(ActionExecutingContext context)
        {
           // Write Code Before Action Method Executing...
        }
        public void OnActionExecuted(ActionExecutedContext context)
        {
            // Write Code After Action Method Executing...
        }       
    }
}
