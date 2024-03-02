using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using domain_boodschappen.Business;

namespace domain_boodschappen.Persistence
{
    internal class Persistence
    {
        public void addBoodschap(boodschap boodschap)
        {
            mapper mapper = new mapper();
            mapper.addBoodschap(boodschap);
        }
        public List<boodschap> getBooschappen()
        {
            mapper mapper = new mapper();
            return mapper.GetBoodschappen();
        }
    }
}
