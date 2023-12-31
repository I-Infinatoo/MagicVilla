﻿using System.ComponentModel.DataAnnotations;

namespace MagicVilla_VillaAPI.Models.Dto
{
    /* DTO:
     * 
     * Provides wrapper between controller and model
     * 
     * Used for communicating with API 
     */
    public class VillaDTO
    {
        public int Id { get; set; }

        /* Checks on Name Field
         * 
         * [Required] => This indicates that Name field is required to be entered
         * [MaxLength(30)] => Maximum allowed length is 30 characters
         */
        [Required]
        [MaxLength(30)]
        public string Name { get; set; }
  
        public int Occupancy { get; set; }
        public string Details { get; set; }
        
        [Required]
        public double Rate { get; set; }
        public int Sqft { get; set; }

        public string ImageUrl { get; set; }
        public string Amenity { get; set; }
    }
}
