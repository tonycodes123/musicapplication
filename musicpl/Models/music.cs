using musicdal;
using musiclib;

namespace musicpl.Models
{


    public class SongOperations
    {
        private static List<songlist> _song = new List<songlist>();

        //correct this
        public static List<songlist> GetAllSongs()
        {
           /* if (_song.Count == 0)
            {
                _song.Add(new musiclib.songlistops() { songid = 1001, songname = "Barfi", singerid = 1, songreleasedate = new DateTime(22,09,2023) });
                _song.Add(new songlistops() { songid = 1002, songname = "Challeya", singerid = 2, songreleasedate = new DateTime(12, 09, 2023) });
                _song.Add(new songlistops() { songid = 1003, songname = "Humsafar", singerid = 3, songreleasedate = new DateTime(25, 09, 2023) });
            }
            return _song;*/
           return songlistops.GetSonglists();
        }

        public static songlist Search(string sname)
        {
            return GetAllSongs().Where(p => p.songname == sname).FirstOrDefault();
        }

        internal static void CreateNew(songlist p)
        {
            //GetAllSongs();
            GetAllSongs().Add(p);
        }
    }
}
