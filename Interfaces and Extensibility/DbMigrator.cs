using System;

namespace Interfaces_and_Extensibility
{
    public class DbMigrator
    {
        private readonly ILogger _logger;
        public DbMigrator(ILogger logger)
        {
            _logger = logger;
        }

        public void Migrate()
        {
            _logger.LogInfo("Migrationg started at {0}" + DateTime.Now);

            // Details of migrating the datebase

            _logger.LogInfo("Migrationg finished at {0}" + DateTime.Now);
        }
    }
}
