using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using domain_boodschappen.Persistence;

namespace domain_boodschappen.Business
{
    internal class repository
    {
        private List<boodschap> boodschappen;

        public List<boodschap> Boodschappen
        {
            get { return Boodschappen; }
            set { Boodschappen = value; }
        }
        public void deleteBoodschap(boodschap boodschap)
        {
            boodschappen.Remove(boodschap);
        }

        public void addBoodschap(boodschap boodschap)
        {
            if (boodschappen == null)
            {
                boodschappen = new List<boodschap>();
            }
            boodschappen.Add(boodschap);
        }

        public repository()
        {
            boodschappen = new List<boodschap>();
        }


    }
}
