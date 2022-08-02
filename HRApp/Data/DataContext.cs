using HRApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRApp.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Candidate> CandidatesDb { get; set; }

        public DataContext(DbContextOptions options) : base(options)
        {

        }
    }
}
