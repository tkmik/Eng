using MyContext.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyContext.Models
{
    [Table("Verbs")]
    [Serializable]
    public class Verb
    {
        [Key]
        [JsonProperty("verb_id")]
        public int VerbId { get; set; }
        [Required]
        [JsonProperty("infinitive")]
        public string Infinitive { get; set; }
        [Required]
        [JsonProperty("past_simple")]
        public string PastSimple { get; set; }
        [Required]
        [JsonProperty("past_participle")]
        public string PastParticiple { get; set; }
        [Required]
        [JsonProperty("translation")]
        public string Translation { get; set; }
        [Required]
        [JsonProperty("number_of_group")]
        public int NumberOfGroup { get; set; } = 1;
        [JsonProperty("is_known")]
        public bool IsKnown { get; set; } = false;
    }
}
