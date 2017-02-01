namespace EcoHostelAPI.Models
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class ApplicationDBContext : DbContext
    {
        // Your context has been configured to use a 'IdentityModel' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'EcoHostelAPI.Models.IdentityModel' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'IdentityModel' 
        // connection string in the application configuration file.
        public ApplicationDBContext()
            : base("name=DefaultConnection")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<Reservation> Reservations { get; set; }
        public virtual DbSet<Room> Rooms { get; set; }
        public virtual DbSet<User> User { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}