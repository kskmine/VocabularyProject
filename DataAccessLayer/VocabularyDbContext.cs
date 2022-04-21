using DataAccessLayer.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class VocabularyDbContext:DbContext
    {
        public VocabularyDbContext(DbContextOptions<VocabularyDbContext> options) : base(options)
        {
                
        }
        public DbSet<Language> Languages { get; set; }
        public DbSet<WordDefinition> WordDefinitions { get; set; }
        public DbSet<WordMeaning> WordMeanings { get; set; }
        public DbSet<Test> Tests { get; set; }
    }
}
