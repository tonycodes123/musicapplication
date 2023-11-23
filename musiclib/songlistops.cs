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
        public List<singerlist> singerid { get; set; }

        public DateTime songreleasedate { get; set; }

        public List<songlist> GetSonglists()
        {
            return dbcontext.songlists.ToList();
        }
        public List<songlist> updatetsonglist()
        {
            return dbcontext.songlists.ToList();
        }
        public List<songlist> deletesonglist()
        {
            return dbcontext.songlists.ToList();
        }
        public List<songlist> insertsonglist()
        {
            return dbcontext.songlists.ToList();
        }

    }
}
