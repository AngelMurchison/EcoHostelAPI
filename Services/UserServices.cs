using EcoHostelAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace EcoHostelAPI.Services
{
    public class UserServices
    {
        public static ApplicationDBContext db = new ApplicationDBContext();
        public static bool verifyUser(System.Security.Claims.ClaimsIdentity user)
        {
            var userExists = db.Users.AsEnumerable().Contains
                (db.Users.FirstOrDefault
                (f => f.ID == user.Name));
            return userExists;
        }
        public static User createUser(System.Security.Claims.ClaimsIdentity user)
        {
            var userclaims = user.Claims.ToList();
            var newUser = new User()
            {
                userName = user.Name,
                //phoneNumber = user.Claims.FirstOrDefault(f => f.Type == "phonenumber").Value,
                //phoneNumber = user.FindFirst("phonenumber").ToString(),
                //email = user.FindFirst("email").ToString(),
                ID = user.Name,
                //profilePictureURL = user.FindFirst("picture").ToString(),
            };
            db.Users.Add(newUser);
            db.SaveChanges();
            return newUser;
        }

    }
}