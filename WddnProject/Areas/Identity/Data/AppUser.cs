﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using WDDNProject.Models;

namespace WDDNProject.Areas.Identity.Data
{
    // Add profile data for application users by adding properties to the AppUser class
    public class AppUser : IdentityUser
    {

        [PersonalData]
        [Column(TypeName = "nvarchar(100)")]
        public string FirstName { get; set; }

        [PersonalData]
        [Column(TypeName = "nvarchar(100)")]
        public string LastName { get; set; }
        public virtual ICollection<Exam> Exams { get; set; }
        
        public virtual ICollection<Group> Groups { get; set; }

        public virtual IList<AppUserGroupMember> AppUserGroupMembers { get; set; }
    }

}
