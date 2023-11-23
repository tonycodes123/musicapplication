using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClassLibrary1
{
    public class albumlist
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int albumid { get; set; }
        public string albumname { get; set; }
         
       public string albumimage {  get; set; }

    }
    public class songlist
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int songid { get; set; }
         
        public string songname { get; set; }
        public List<singerlist> singerid { get; set; }

        public DateTime songreleasedate { get; set; }
    }
    public class singerlist
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int singerid { get; set;}
        public string singername { get; set;}
        public string singerimage { get; set; }
    }

    public class musicdbcontext : DbContext
    {
        DbSet<albumlist> albumlist { get; set; }
        DbSet<songlist> songlist { get; set; }
        DbSet<singerlist> singerlist { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=MusicDB;Trusted_Connection=true");
        }
    }

}