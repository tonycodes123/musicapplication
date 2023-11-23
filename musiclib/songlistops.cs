using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using musicdal;


namespace musiclib
{
    public class songlistops
    {

       
        public int songid { get; set; }
        static musicdbcontext dbcontext = new musicdbcontext(); 


        public string songname { get; set; }
        public int singerid { get; set; }

        public DateTime songreleasedate { get; set; }

        public static List<songlist> GetSonglists()
        {
            return dbcontext.songlists.ToList();
        }
        public List<songlist> updatesonglists()
        {
            return dbcontext.songlists.ToList();
        }
        public List<songlist> deletesonglists()
        {
            return dbcontext.songlists.ToList();
        }
        public List<songlist> insertsonglists()
        {
            return dbcontext.songlists.ToList();
        }

        public object? GetSongdetails()
        {
            throw new NotImplementedException();
        }
    }
}
