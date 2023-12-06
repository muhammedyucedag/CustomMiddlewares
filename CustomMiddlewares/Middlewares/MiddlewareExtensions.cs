namespace CustomMiddlewares.Middlewares
{
    public static class MiddlewareExtensions
    {
        public static IApplicationBuilder UseHelloChecker(this IApplicationBuilder app)
        {
            return app.UseMiddleware<HelloMiddleware>();
        }

        public static IApplicationBuilder UseExcepitonHandler(this IApplicationBuilder app)
        {
            return app.UseMiddleware<ExceptionHandlerMiddleware>();
        }

        public static IApplicationBuilder UseRequestResponseMiddleware(this IApplicationBuilder app)
        {
            return app.UseMiddleware<RequestResponseMiddleware>();
        }
    }
}
