namespace EcoHostelAPI.Models
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class ApplicationDBContext : DbContext
    {
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
}