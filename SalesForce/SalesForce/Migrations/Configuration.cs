namespace SalesForce.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<SalesForce.Data.SalesforceContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(SalesForce.Data.SalesforceContext context)
        {
            context.Accounts.AddOrUpdate(
                new Data.Models.Account { Type = "Customer", Name = "Best Buy"},
                new Data.Models.Account { Type = "Customer", Name = "Target" },
                new Data.Models.Account { Type = "Customer", Name = "Walmart" }
           );
        }
    }
}
