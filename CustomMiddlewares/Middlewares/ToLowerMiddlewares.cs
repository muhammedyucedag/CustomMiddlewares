namespace CustomMiddlewares.Middlewares
{
    public class ToLowerMiddlewares
    {
        //Bir sonraki Middleware temsil eden delegate
        private readonly RequestDelegate _next;
        public ToLowerMiddlewares(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            if (context.Items["value"] != null) 
            { 
                var value = context.Items["value"].ToString();
                context.Items["value"] = value.ToLower();
            }
            await _next(context);
        }
    }
}
