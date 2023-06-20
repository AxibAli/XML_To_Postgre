using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
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
