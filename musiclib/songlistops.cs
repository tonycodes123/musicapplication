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
        public static void updatesonglists(string pname, int psongid, DateTime psongreleasedate)
        {
            var tobeupdated = dbcontext.songlists.ToList().Where((p) => p.songname == pname).FirstOrDefault();
            tobeupdated.songname = pname;
            tobeupdated.songid = psongid;
            tobeupdated.songreleasedate = psongreleasedate;
            dbcontext.SaveChanges();

        }
        public static void deletesonglists(string pname)
        {
            var tobedeleted = dbcontext.songlists.ToList().Where((p) => p.songname == pname).FirstOrDefault();
            dbcontext.songlists.Remove(tobedeleted);
            dbcontext.SaveChanges();
        }
        public static void insertsonglists(string pname, int psongid, DateTime psongreleasedate)
        {
            dbcontext.songlists.Add(new songlist() { songname = pname, songid = psongid, songreleasedate = psongreleasedate });
            dbcontext.SaveChanges();
        }
        public static songlist search1(string sname)
        {
            var res = dbcontext.songlists.ToList().Where(p => p.songname == sname).FirstOrDefault();
            return res as songlist;
        }

    }
}
