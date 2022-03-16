﻿using Microsoft.AspNetCore.Mvc;

namespace api
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Employee>? Employees { get; set; }

        
    }

}
