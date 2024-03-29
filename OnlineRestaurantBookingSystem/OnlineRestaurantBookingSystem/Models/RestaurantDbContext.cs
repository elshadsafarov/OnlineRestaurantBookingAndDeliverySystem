﻿using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineRestaurantBookingSystem.Models
{
    public class RestaurantDbContext : IdentityDbContext<IdentityUser>
    {
        public RestaurantDbContext(DbContextOptions<RestaurantDbContext> options) : base(options) 
        {
            
        }
    }
}
