using DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Interfaces
{
    public interface IWordMeaningRepository
    {
        public List<WordMeaning> List();
        public WordMeaning GetById(int id);
        public void Add(WordMeaning entity);
        public void Update(WordMeaning entity);
        public void Delete(int id);
    }
}
