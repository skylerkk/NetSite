using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace API.Entities
{
    public class AppUser : IdentityUser<int>
    {

        public DateTime DateOfBirth { get; set; }
        public string NickName { get; set; }
        public DateTime Created { get; set; }
        public DateTime LastActive { get; set; }
        public string FavoriteArmy { get; set; }
        public string Bio { get; set; }
        public string City { get; set; }    
        public string Country { get; set; }
        public ICollection<Photo> Photos { get; set; }
        public ICollection<UserLike> LikedByUsers { get; set; }
        public ICollection<UserLike> LikedUsers { get; set; }
        public ICollection<Message> MessagesSent { get; set; }
        public ICollection<Message> MessagesRecived { get; set; }
        public ICollection<AppUserRole> UserRoles { get; set; }
    }
}