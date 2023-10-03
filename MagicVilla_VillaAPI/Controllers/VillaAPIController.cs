using MagicVilla_VillaAPI.Data;
using MagicVilla_VillaAPI.Models;
using MagicVilla_VillaAPI.Models.Dto;
using Microsoft.AspNetCore.Mvc;

namespace MagicVilla_VillaAPI.Controllers
{
    /* route of the controller 
     */
    [Route("api/VillaAPI")]
    
    /* attribute: defines that this will be an API controller
    */
    [ApiController]

    /* ControllerBase
        Contains common methods for returning all the data and users
        that is related to the controllers in .NET Application
     */
    public class VillaAPIController : ControllerBase
    {
        /* endpoint
         * 
         * [HttpGet] => this will specify that, this endpoint is the HTTP GET endpoint
         */
        [HttpGet]
        /*
        public IEnumerable<VillaDTO> GetVillas ()
        {
            return VillaStore.villaList;
        }
        */

        /* ActionResult<>
            : This allows us to return any type from the method.
            
            You use ActionResult if there are multiple return types possible 
            deriving from ActionResult, like ViewResult, FileResult, JsonResult, etc.

            For example, what if you have a method that gives back some content. 
            One time you might want to load it from memory and return it as JSON (JsonResult).
            The next time it is called you have to load the JSON from your file system 
            where FileResult might come in handy.

            You can use a string too as a return type, or if you want to provide 
            the Content-Type you can use return Content("Your string").
         */
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<IEnumerable<VillaDTO>> GetVillas() { 
            return Ok(VillaStore.villaList);
        }

        /*To get the Villa by ID
         * 
         * ("id") => This will tell, it accepts 'id' parameter
         * 
         * ("{id:int}") => this will tell that 'id' is int
         */

        // [HttpGet("id")]
        [HttpGet("{id:int}")]

        /* Status code Documentation
         * 
         * This will tell the API about which Codes are
         * possible to get in return
         * 
         * [ProducesResponseType(200)]
         * [ProducesResponseType(400)]
         * [ProducesResponseType(404)]
         */
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<VillaDTO> GetVilla(int id)
        {
            if (id == 0) {
                // status code : 400
                return BadRequest();
            }

            var villa = VillaStore.villaList.FirstOrDefault(u => u.Id == id);
            if (villa == null) { 
                // status code : 404
                return NotFound();
            }

            // status code : 200
            return Ok(villa);
        }
    }
}
