namespace Composition
{
    public class DbMigration
    {
        private readonly Logger _logger;

        public DbMigration(Logger logger)
        {
            _logger = logger;
        }

        public void Migration()
        {
            _logger.Log("We are migration");
        }
    }
}
