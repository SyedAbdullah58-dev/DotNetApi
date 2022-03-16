namespace api
{
    public class CreateEmployeeDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public DateTime Date { get; set; }
        public int DepartmentId { get; set; }
    }
}
