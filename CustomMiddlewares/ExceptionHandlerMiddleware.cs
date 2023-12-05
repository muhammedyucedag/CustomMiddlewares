namespace CustomMiddlewares
{
    public class ExceptionHandlerMiddleware
    {
        private readonly RequestDelegate next;

        public ExceptionHandlerMiddleware(RequestDelegate Next)
        {
            next = Next;
        }

        public async Task Invoke(HttpContext httpContext)
        {
            await next.Invoke(httpContext);
        }
    }
}
