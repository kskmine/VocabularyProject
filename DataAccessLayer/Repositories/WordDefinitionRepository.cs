using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class WordDefinitionRepository
    {

         VocabularyDbContext _context;
        public WordDefinitionRepository(VocabularyDbContext context)
        {
            _context = context;
        }
    }
}
