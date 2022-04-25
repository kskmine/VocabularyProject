using DataAccessLayer.Entities;
using DataAccessLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Interfaces
{
    public interface IWordDefinitionRepository:IRepositoryBase<WordDefinition>
    {
        public List<WordDefinition> List(string searchKeyword)
        //public List<WordDefinition> List();
        //public WordDefinition GetById(int id);
        //public void Add(WordDefinition entity);
        //public void Update(WordDefinition entity);
        //public void Delete(int id);
    }
}
