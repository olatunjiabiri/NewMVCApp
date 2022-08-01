﻿using Microsoft.EntityFrameworkCore;
using NewMVCApp.Models;

namespace NewMVCApp.Data
{
    public class ApplicationDBContext :DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options
            ) : base(options)
        {
                
        }

        public DbSet<Category> Categories { get; set; }
    }
}
