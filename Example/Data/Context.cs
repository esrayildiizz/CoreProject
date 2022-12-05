using Example.Models;
using Microsoft.EntityFrameworkCore;

namespace Example.Data
{
    public class Context:DbContext
    {
        public Context(DbContextOptions<Context>options ):base(options) 
        {
            //startup a ekleme yapacağız burası gerekli yani DbContextOptions sınıfını kullanarak veri tabanına ekle
        }

        //veri tabanında oluşacak tablolarım.
        public virtual DbSet<Workman> Workmans { get; set; }
    }
}
