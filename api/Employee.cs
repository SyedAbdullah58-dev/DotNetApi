using System.Text.Json.Serialization;

namespace api
{
    public class Employee
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }

         public DateTime Date { get; set; }=DateTime.Now;
      [JsonIgnore]
        public  Department? Department { get; set; }
      public int DepartmentId { get; set; }
    


    }
}
