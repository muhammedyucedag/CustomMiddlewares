namespace CustomMiddlewares.Middlewares
{
    public class HelloMiddleware
    {
        //Bir sonraki Middleware temsil eden delegate
        private readonly RequestDelegate _next;
        public HelloMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            Console.WriteLine("Merhabalar bu bir sorudur..");
            await _next.Invoke(context);
            Console.WriteLine("Merhabalar bu bir cevaptır.");
        }
    }
}
