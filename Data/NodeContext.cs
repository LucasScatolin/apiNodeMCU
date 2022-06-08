using APINodeMcu.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APINodeMcu.Data
{
    public class NodeContext : DbContext

    {
        public NodeContext(DbContextOptions<NodeContext> opt) : base(opt)
        {

        }

        public DbSet <Dataesp> DataEsp { get; set; }
    }
}
