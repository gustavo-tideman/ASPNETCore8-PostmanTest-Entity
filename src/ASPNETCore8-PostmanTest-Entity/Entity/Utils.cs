namespace WebAPI.Entity
{
    public class Utils
    {
        private readonly Context _context;

        public Utils(Context context)
        {
            _context = context; 
        }

        public bool SqlServerHealthCheck()
        {
            return _context.Database.CanConnect();
        }
    }
}
