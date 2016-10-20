using Nancy;

namespace CoreApp
{
    public class HomeModule : NancyModule
    {
        private class AsyncRequestResult
        {
            public int id { get; set; }
        }
        public HomeModule ()
        {
            Before.AddItemToStartOfPipeline(ctx=> {if(ctx.Parameters.id ?? 0 >40) return 404; else return null;});
            Get("/", args=>"Nancy accepted the invitation");
            Get("/message/{target}/{text}", args=> $"Message to {args.target} sent: {args.text}");
            Get("/api/{id:int}", args => $"api:{args.id}");
          
        }
        
    }
}