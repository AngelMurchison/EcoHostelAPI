namespace EcoHostelAPI.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using EcoHostelAPI.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<EcoHostelAPI.Models.ApplicationDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(EcoHostelAPI.Models.ApplicationDBContext context)
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

            //var event0 = new Event()
            //{
            //    title = "Community Yard Sale",
            //    description = "Far far away, behind the word mountains, far from the countries Vokalia and Consonantia, there live the blind texts.",
            //    datetime = DateTime.Now.AddDays(10),
            //    location = "St. Pete Eco-Hostel, St. Pete Florida"
            //};
            //var event1 = new Event()
            //{
            //    title = "Flag Football Tournament",
            //    description = "A wonderful serenity has taken possession of my entire soul, like these sweet mornings of spring which I enjoy with my whole heart. ",
            //    datetime = DateTime.Now.AddDays(12),
            //    location = "St. Pete Eco-Hostel, St. Pete Florida"
            //};
            //var event2 = new Event()
            //{
            //    title = "Italian Dinner Night",
            //    description = "One morning, when Gregor Samsa woke from troubled dreams, he found himself transformed in his bed into a horrible vermin. ",
            //    datetime = DateTime.Now.AddDays(13),
            //    location = "St. Pete Eco-Hostel, St. Pete Florida"
            //};
            //var event3 = new Event()
            //{
            //    title = "St. Pete Smash n' Grab",
            //    description = "The quick, brown fox jumps over a lazy dog. DJs flock by when MTV ax quiz prog. Junk MTV quiz graced by fox whelps. ",
            //    datetime = DateTime.Now.AddDays(16),
            //    location = "St. Pete Eco-Hostel, St. Pete Florida"
            //};
            //context.Events.AddOrUpdate(e => e.title, event0);
            //context.Events.AddOrUpdate(e => e.title, event1);
            //context.Events.AddOrUpdate(e => e.title, event2);
            //context.Events.AddOrUpdate(e => e.title, event3);

            //var rule0 = new Rules()
            //{
            //    title = "Office closes at 10pm every night!",
            //    description = "Far far away, behind the word mountains, far from the countries Vokalia and Consonantia, there live the blind texts."
            //};
            //var rule1 = new Rules()
            //{
            //    title = "Lights out by 2am!",
            //    description = "A wonderful serenity has taken possession of my entire soul, like these sweet mornings of spring which I enjoy with my whole heart. "
            //};
            //var rule2 = new Rules()
            //{
            //    title = "Overnight visitors stay in your room, and can stay a maximum of 2 days.",
            //    description = "One morning, when Gregor Samsa woke from troubled dreams, he found himself transformed in his bed into a horrible vermin. "
            //};
            //var rule3 = new Rules()
            //{
            //    title = "Be the person you would like to meet.",
            //    description = "The quick, brown fox jumps over a lazy dog. DJs flock by when MTV ax quiz prog. Junk MTV quiz graced by fox whelps. "
            //};
            //context.Rules.AddOrUpdate(r => r.title, rule0);
            //context.Rules.AddOrUpdate(r => r.title, rule1);
            //context.Rules.AddOrUpdate(r => r.title, rule2);
            //context.Rules.AddOrUpdate(r => r.title, rule3);

            //var class0 = new Class()
            //{
            //    title = "Intro to knitting!",
            //    description = "Far far away, behind the word mountains, far from the countries Vokalia and Consonantia, there live the blind texts.",
            //    datetime = DateTime.Now.AddDays(10)
            //};
            //var class1 = new Class()
            //{
            //    title = "Eco-friendly Living",
            //    description = "A wonderful serenity has taken possession of my entire soul, like these sweet mornings of spring which I enjoy with my whole heart. ",
            //    datetime = DateTime.Now.AddDays(12)
            //};
            //var class2 = new Class()
            //{
            //    title = "Beginner's Merengue Dancing",
            //    description = "One morning, when Gregor Samsa woke from troubled dreams, he found himself transformed in his bed into a horrible vermin. ",
            //    datetime = DateTime.Now.AddDays(16)
            //};
            //var class3 = new Class()
            //{
            //    title = "Wilderness Survival",
            //    description = "The quick, brown fox jumps over a lazy dog. DJs flock by when MTV ax quiz prog. Junk MTV quiz graced by fox whelps. ",
            //    datetime = DateTime.Now.AddDays(20)
            //};
            //context.Classes.AddOrUpdate(c => c.title, class0);
            //context.Classes.AddOrUpdate(c => c.title, class1);
            //context.Classes.AddOrUpdate(c => c.title, class2);
            //context.Classes.AddOrUpdate(c => c.title, class3);

            //var volunteertime0 = new VolunteerTime()
            //{
            //    title = "Farm Day",
            //    datetime = DateTime.Now.AddDays(11),
            //    location = "St. Pete Eco-Hostel"
            //};
            //var volunteertime1 = new VolunteerTime()
            //{
            //    title = "Cook for your Hostelmates!",
            //    datetime = DateTime.Now.AddDays(13),
            //    location = "St. Pete Eco-Hostel"
            //};
            //var volunteertime2 = new VolunteerTime()
            //{
            //    title = "Farm Day",
            //    datetime = DateTime.Now.AddDays(15),
            //    location = "St. Pete Eco-Hostel"
            //};
            //var volunteertime3 = new VolunteerTime()
            //{
            //    title = "Cleaning up the Park",
            //    datetime = DateTime.Now.AddDays(15),
            //    location = "Williams Park, St. Pete FL."
            //};
            //context.volunteerTimes.AddOrUpdate(v => v.title, volunteertime0);
            //context.volunteerTimes.AddOrUpdate(v => v.title, volunteertime1);
            //context.volunteerTimes.AddOrUpdate(v => v.title, volunteertime2);
            //context.volunteerTimes.AddOrUpdate(v => v.title, volunteertime3);
            var room = new Room()
            {
                roomType = "single"
            };
            var room1 = new Room()
            {
                roomType = "double"
            };
            var room2 = new Room()
            {
                roomType = "commmunal"
            };

            context.Rooms.AddOrUpdate(r => r.roomType, room);
            context.Rooms.AddOrUpdate(r => r.roomType, room1);
            context.Rooms.AddOrUpdate(r => r.roomType, room2);
            context.SaveChanges();
        }
    }
}
