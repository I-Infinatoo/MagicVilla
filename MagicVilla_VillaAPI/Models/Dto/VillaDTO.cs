using System.ComponentModel.DataAnnotations;

namespace MagicVilla_VillaAPI.Models.Dto
{
    /* DTO:
     * 
     * Provides wrapper between controller and model
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
    }
}
