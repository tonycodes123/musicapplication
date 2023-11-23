using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using musiclib;

namespace musicpl.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class musicController : Controller
    {
        [HttpGet("/getsongs")]
        //public IActionResult GetAllSongs()
        //{
        //    var song = SongOperations.GetAllSongs();
        //    return View("SongsList", songs);
        //}
        //crud
        public IActionResult GetSonglist()
        {
            var songBl = new songlistops();
            return View("FromDb", songBl.GetSonglists());
        }

        public IActionResult insertsonglist()
        {
            var songBl = new songlistops();
            return View("InsertDb", songBl.insertsonglists());
        }

        public IActionResult updatetsonglist()
        {
            var songBl = new songlistops();
            return View("UpdateDb", songBl.updatesonglists());
        }

        public IActionResult deletesonglist()
        {
            var songBl = new songlistops();
            return View("DeleteDb", songBl.deletesonglists());
        }

    }
}
