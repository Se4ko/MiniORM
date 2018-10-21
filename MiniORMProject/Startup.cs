namespace MiniORMProject
{
    using System;
    using Entities;
    using Interfaces;

    public class Startup
    {
        public static void Main()
        {
            string connectionString = new ConnectionStringBuilder("MinionsDB").ConnectionString;
            IDbContex context = new EntityManager(connectionString, true);

            User user = new User("Iskra", "asd", 35, DateTime.Now);
            context.Persist(user);


        }
    }
}
