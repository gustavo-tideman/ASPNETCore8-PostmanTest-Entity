namespace WebAPI.Entity
{
    public class PostmanPipeline
    {
        public PostmanPipeline()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }
        
        public string Text { get; set; }
    }
}
