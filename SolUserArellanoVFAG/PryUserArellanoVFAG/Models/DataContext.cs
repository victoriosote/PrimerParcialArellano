using System.Data.Entity;

namespace PryUserArellanoVFAG.Models
{
    public class DataContext:DbContext
    {
        public DataContext():base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<PryUserArellanoVFAG.Models.Exam> Exams { get; set; }
    }
}