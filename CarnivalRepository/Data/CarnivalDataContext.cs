using CarnivalRepository.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarnivalRepository.Data
{
    public class CarnivalDataContext : DbContext
    {
        public CarnivalDataContext(DbContextOptions<CarnivalDataContext> options): base(options)
        {

        }
        public  DbSet<Manager>? Managers { get; set; }
    }
}
