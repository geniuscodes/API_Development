using Microsoft.AspNetCore.Mvc.Filters;

namespace API_Development.CustomFilters
{

    /// <summary>
    /// This Wiill be my basic Custom Action Filter
    /// Using Attribute because I want to use it
    /// on Action Method and Controller level not global
    /// I will be using / implemementing it as attribute then
    /// </summary>
    /// 
    //Syncronous ActionFilter
    public class BasicCustomActionFilterAttribute : Attribute, IActionFilter
    {

        //This Parameter will specify which Level exc comes from
        private readonly string? _name;

        public BasicCustomActionFilterAttribute(string? name)
        {
            _name = name;
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
            //Do something While Executing
            Console.WriteLine($" Syncronous Filter Processing Done ! {_name} :(");

        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            //Do Something After Execution
            Console.WriteLine($"Syncronous Filter Still Processing. {_name}...");

        }
    }

    public class BasicAsyncCustomActionFilterAttribute : Attribute, IAsyncActionFilter
    {
        public Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            throw new NotImplementedException();
        }
    }
}
