using DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace VocabularyProject.Models
{
    public class WordDefinitionViewModel
    {
        public int Id { get; set; }
        public string Word { get; set; }
        public string LangCode { get; set; }
        public string LangName { get; set; }

        // [Required(ErrorMessage = "Dil ID si giriniz")]
        public int LangId { get; set; }
        public string LangText { get; internal set; }

        //[ForeignKey("LangId")]
        //public virtual Language Lang { get; set; }
    }
}
