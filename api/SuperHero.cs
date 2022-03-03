﻿using System.ComponentModel.DataAnnotations;

namespace api
{
    public class SuperHero
    {
       [Key]
        public int Id { get; set; }
        public string Name { get; set; } =String.Empty;
        public string Description { get; set; } =String.Empty;
        public string FirstName {get; set;} = String.Empty;
        public string LastName {get; set;} = String.Empty;
         

    }
}
