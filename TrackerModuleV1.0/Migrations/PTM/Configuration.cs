namespace TrackerModuleV1._0.Migrations.PTM
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Data;

    internal sealed class Configuration : DbMigrationsConfiguration<TrackerModuleV1._0.Data.PTMContex>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"Migrations\PTM";
        }

        protected override void Seed(TrackerModuleV1._0.Data.PTMContex context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            context.Projects.AddOrUpdate(
                p =>  p.ProjectName, DummyData.getProjects().ToArray());
            context.SaveChanges();

            context.Users.AddOrUpdate(
                u => new { u.FirstName, u.LastName }, DummyData.getUsers(context).ToArray());
            context.SaveChanges();
        }
    }
}
