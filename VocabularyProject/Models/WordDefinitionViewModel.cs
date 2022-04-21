using DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace VocabularyProject.Models
{
    public class WordDefinitionViewModel
    {
        public int Id { get; set; }
        public string Word { get; set; }
        public int LangId { get; set; }
        //[ForeignKey("LangId")]
        //public virtual Language Lang { get; set; }
    }
}
