﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace Vidly.Models
{
    public class Movie
    {

        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        public DateTime ReleaseDate { get; set; }
        public DateTime DateAdded { get; set; }
        public Genre Genre { get; set; }
        public byte GenreId { get; set; }


    }
}