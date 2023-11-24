using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace musicdal
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
        

        public DateTime songreleasedate { get; set; }
    }
    public class singerlist
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int singerid { get; set;}
        public string singername { get; set;}
        public string singerimage { get; set; }
        public List<songlist> songid { get; set; }
    }

    public class musicdbcontext : DbContext
    {
       public DbSet<albumlist> albumlists { get; set; }
        public DbSet<songlist> songlists { get; set; }
        public DbSet<singerlist> singerlists { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=MusicDB;Trusted_Connection=true");
        }
    }

}