﻿using MaSurvey.Domain.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MaSurvey.Persistence.Context
{
    public class MaSurveyDbContext:IdentityDbContext<User,Role,int>
    {
        public MaSurveyDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Option> Options { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Survey> Surveys { get; set; }
    }
}