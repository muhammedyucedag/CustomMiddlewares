namespace CustomMiddlewares.Middlewares
{
    public static class MiddlewareExtensions
    {
        public static IApplicationBuilder HelloMiddlewareChecker(this IApplicationBuilder app)
        {
            return app.UseMiddleware<HelloMiddleware>();
        }

    }
}
