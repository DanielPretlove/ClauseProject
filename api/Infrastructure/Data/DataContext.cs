using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {

           
        }

        public DbSet<ClauseText> clauseTexts { get; set; }
        public DbSet<ClauseLeft> clauseLefts { get; set; }
        public DbSet<ClauseRight> clauseRights { get; set; }     


// Creating Procedure
// CREATE PROCEDURE [dbo].[Initializer] AS 
// TRUNCATE TABLE [dbo].[Clause Left];
// TRUNCATE TABLE [dbo].[Clause Right];
// TRUNCATE TABLE [dbo].[Clause Text];
// INSERT INTO [dbo].[Clause Text] (ClauseName, Text) 
// VALUES ('A', 'This is Clause A'), ('B', 'This is Clause B'), ('C', 'This is Clause C'), ('D', 'This is Clause D');
// INSERT INTO [dbo].[Clause Left] (Clause) 
// VALUES ('A'), ('B'), ('C'), ('D');

    }
}