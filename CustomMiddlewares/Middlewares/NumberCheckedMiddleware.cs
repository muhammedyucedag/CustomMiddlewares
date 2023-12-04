namespace CustomMiddlewares.Middlewares
{
    public class NumberCheckedMiddleware
    {
        private readonly RequestDelegate _next;

        public NumberCheckedMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            if (context.Request.Path == "/products")
            {
                var value = context.Request.Query["category"].ToString();

                if (int.TryParse(value, out int intValue))
                    await context.Response.WriteAsync($"category sayısaldır : {intValue}");

                context.Items["value"] = value;

                await _next(context);
            }
            await _next(context);
        }
    }
}
