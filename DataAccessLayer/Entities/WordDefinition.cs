using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DataAccessLayer.Entities
{
   public class WordDefinition
    {
        public int Id { get; set; }
        public string Word { get; set; }
        public int LangId { get; set; }
           
        [ForeignKey("LangId")]
        public virtual Language Lang { get; set; }
        [JsonIgnore]
        public virtual List<WordMeaning> WordMeanings { get; set; }
    }
}
