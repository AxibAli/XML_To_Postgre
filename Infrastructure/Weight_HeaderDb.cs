using Domain;
namespace Infrastructure
{
    public class Weight_HeaderDb
    {
        private AppDbContext context = new AppDbContext();


        public bool Insert(Weight_Header obj)
        {

            context.weight_Headers.Add(obj);
            context.SaveChanges();
            return true;
        }
    }
}
