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
            return app.UseMiddleware<HelloMiddleware>();
        }
    }
}
