
﻿using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace AuthApi.Models
{
    public class AppUser:IdentityUser
    {
        [PersonalData]
        public string FullName { get; set; }
           [PersonalData]
        public string Gender { get; set; }

        [PersonalData]
        public DateOnly DOB { get; set; }

        [PersonalData]
        public int? LibraryID { get; set; }
    }
}
