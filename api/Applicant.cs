using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace api
{
    public class Applicant
    {
        public int Id { get; set; }
       
        [Column("Applicant_name", TypeName = "varchar(200)" ) ]
        public string Name { get; set; }
        public string Country  { get; set; }

        [Column(TypeName ="decimal(5,2)")]
        public int SkillLevel { get; set; }
        [JsonIgnore]
        public IList<Job> Jobs { get; set; }
    }
}
