using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EcoHostelAPI.Models
{
    public class UserServices
    {
        public static ApplicationDBContext db = new ApplicationDBContext();
        public static bool verifyUser(System.Security.Claims.ClaimsIdentity user)
        {
            var userid = user.Claims.First(f => f.Type == "user_id").Value;
            var userExists = db.Users.Contains
                (db.Users.First
                (f => f.ID == user.Claims.First
                (c => c.Type == "user_id").Value));
            return userExists;
        }
        public static User createUser(System.Security.Claims.ClaimsIdentity user)
        {
            var newUser = new User()
            {
                userName = user.Name,
                phoneNumber = user.Claims.FirstOrDefault(f => f.Type == "phonenumber").Value,
                email = user.Claims.FirstOrDefault(f => f.Type == "email").Value,
                ID = user.Claims.FirstOrDefault(f => f.Type == "user_id").Value,
                profilePictureURL = user.Claims.FirstOrDefault(f => f.Type == "picture").Value
            };
            return newUser;
        }

    }
}