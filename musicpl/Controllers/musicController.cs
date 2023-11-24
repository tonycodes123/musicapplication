using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using musicdal;
using musicpl.Models;

namespace musicpl.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class musicController : Controller
    {
        [HttpGet("/getsongs")]
        public IActionResult GetAllSongs()
        {
            var song = SongOperations.GetAllSongs();
            return View("SongsList", song);
        }

        [HttpGet("/search/{sname}")]
        public IActionResult GetSongdetails(string sname)
        {
            var songBl = SongOperations.Search(sname);
            return View("search", songBl);
        }
   


[HttpGet("/create")]
public IActionResult create()
{
  return View("create", new songlist());
}
[HttpPost("/create")]
public IActionResult create([FromForm] songlist p)
{
  SongOperations.CreateNew(p);
  return View("SongsList", SongOperations.GetAllSongs());
 
}
       
[HttpGet("/edit/{sname}")]
public IActionResult edit(string sname)
{
var found2 = SongOperations.Search(sname);
return View("edit", found2);
}
[HttpPost("/edit/{sname}")]
public IActionResult edit(string sname, [FromForm] songlist p)
{
var found3 = SongOperations.Search(p.songname);
found3.songname = p.songname;
found3.songid = p.songid;
found3.songreleasedate = p.songreleasedate;
return View("SongsList", SongOperations.GetAllSongs());
}
    }
}


