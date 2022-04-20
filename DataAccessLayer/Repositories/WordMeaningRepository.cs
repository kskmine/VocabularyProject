using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class WordMeaningRepository
    {
        VocabularyDbContext _context; 
        public WordMeaningRepository(VocabularyDbContext context)
        {
            _context = context;
        }
     }
}
