using System;
using System.Collections.Generic;
using API.Extensions;

namespace API.Entities
{
    public class AppUser
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string NickName { get; set; }
        public DateTime Created { get; set; }
        public DateTime LastActive { get; set; }
        public string FavoriteArmy { get; set; }
        public string Bio { get; set; }
        public string City { get; set; }    
        public string Country { get; set; }
        public ICollection<Photo> Photos { get; set; }
        // public int GetAge() 
        // {
        //     return DateOfBirth.CalculateAge();
        // }
    }
}