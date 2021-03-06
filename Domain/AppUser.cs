using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Domain
{
    public class AppUser : IdentityUser
    {
        #region Properties
      

        public string Name { get; set; }

        public string Initials { get; set; }
      
        public List<Media> Uploads { get; set; }
        public List<Comment> Comments { get; set; }

        public Playlist LikedSongs { get; set; } = new Playlist();
        #endregion

        #region Constructor

        public AppUser()
        {

        }
        public AppUser(string userName):base(userName)
        {

        }
        
        #endregion
    }
}
