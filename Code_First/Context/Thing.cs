using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Code_First.Context
{
    public class Thing
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [MaxLength(30)]
        public string WhatIsIt { get; set; }
        [MinLength(0)]
        public int HowMany { get; set; }
    }

    public class ThingContext : DbContext
    {
        public DbSet<Thing> Things { get; set; }
        public ThingContext(DbContextOptions options) : base(options)
        {
        }
    }
}
