using Domain;

namespace Infrastructure
{
    public class Airport_DatalistDb
    {
        static Airport_DatalistDb()
        {
            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
        }
        private AppDbContext context = new AppDbContext();
         

        public bool Insert(Airport_Datalist obj)
        {

            context.airport_Datalists.Add(obj);
            context.SaveChanges();
            return true;
        }
    }
}
