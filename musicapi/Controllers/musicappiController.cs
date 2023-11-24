using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using musicdal;
using musiclib;
using musicpl.Models;
using System;

namespace musicapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class musicappiController : ControllerBase
    {
        [HttpGet("/api/songs")]
        public IActionResult GetAllSongs() //since Ok will give status code put IActionResult instead of List<Person>
        {
           
            return Ok(SongOperations.GetAllSongs());
        }
        [HttpPost("/add")]
        public IActionResult addsongs(string pname, int psongid, DateTime psongreleasedate)
        {
            songlistops.insertsonglists(pname, psongid, psongreleasedate);
            return Ok($"Created person with Aadhar  successfully");
        }

        [HttpPost("/update")]
        public IActionResult Updatesongs(string pname, int psongid, DateTime psongreleasedate)
        {
            try
            {
                songlistops.updatesonglists(pname, psongid, psongreleasedate);
                return Ok("Update successful");
            }
            catch (Exception ex) //catch can be many but one at a time will be executed, finally only once
            {
                return NotFound(ex.Message);
            }

        }
        [HttpDelete("/delete")] 
        public IActionResult Deletesongs(string pname) //parameter binder [fromquery]
        {
            try
            {
                songlistops.deletesonglists(pname);
                return Ok("Deletion successful");
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }

        }
    }
}
