﻿
using System.ComponentModel.DataAnnotations;

namespace WebApplication12.Models
{
    public class Actor
    {
        [Key]
        public int Id { get; set; }
        public string? ProfilePictureURL { get; set; }
        public string? FullName { get; set; }
      public  string?  Bio { get; set; }
        //Relationship
        public List<Actor_Movie>? Actor_Movies { get; set; }
    }
}
