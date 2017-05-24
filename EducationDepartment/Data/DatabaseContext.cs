using System;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using EducationDepartment.Models;

namespace EducationDepartment.Data
{
    public class DatabaseContext: IdentityDbContext<Account>
    {
        public DatabaseContext(DbContextOptions options)
        : base(options)
        {
		}
    }
}
